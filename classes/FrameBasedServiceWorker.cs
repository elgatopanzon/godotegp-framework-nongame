/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : WorkerService
 * @created     : Saturday Dec 30, 2023 23:25:26 CST
 */

namespace GodotEGPNonGame.ServiceWorkers;

using GodotEGP.Logging;

public partial class FrameBasedServiceWorker : BackgroundService
{
	// holds delta time values
	protected DateTime _startTime = DateTime.Now;
	protected DateTime _prevTime = DateTime.Now;
	protected TimeSpan _deltaTime;
	protected double _targetFps = 60;
	protected double _frameCounter = 0;

	// the time in seconds that we want to execute the task
	protected double _taskRunTimeoutSec = 5;
	protected TimeSpan _taskRunCounter = new TimeSpan();

	public FrameBasedServiceWorker()
	{
        TaskInit();
	}

	public virtual void TaskInit()
	{
        LoggerManager.LogDebug("Init background service task");
	}

	public void SetTargetFps(double targetFps = 60)
	{
		_targetFps = targetFps;
	}
        
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
        	// calculate delta time
        	_deltaTime = _prevTime - _startTime;

        	if (_deltaTime.TotalMilliseconds >= (1 / _targetFps) * 1000)
        	{
        		// LoggerManager.LogDebug("Delta time", "", "deltaTime", _deltaTime);
        		// LoggerManager.LogDebug("Frame count", "", "frameCount", 1000 / _deltaTime.TotalMilliseconds);
        		_startTime = DateTime.Now;

        		_taskRunCounter += _deltaTime;

				// execute the task if timeout is reached
				if (_taskRunCounter.TotalSeconds >= _taskRunTimeoutSec)
				{
					_taskRunCounter = new TimeSpan();
					try
					{
            			await Run();
					}
					catch (System.Exception e)
					{
						LoggerManager.LogDebug("Exception during task run", "", "e", e);
					}
				}

				var _elapsedTime = DateTime.Now - _startTime;
        		// LoggerManager.LogDebug("Elapsed time", "", "elapsedTime", _elapsedTime.TotalMilliseconds);

        		// LoggerManager.LogDebug("Delta adjust", "", "deltaAdjust", _deltaTime - TimeSpan.FromMilliseconds((1 /_targetFps) * 1000));

				var tilNextFrame = TimeSpan.FromMilliseconds((1 /_targetFps) * 1000) - _elapsedTime;
        		// LoggerManager.LogDebug("Next frame in", "", "nextFrame", tilNextFrame - (_deltaTime - TimeSpan.FromMilliseconds((1 /_targetFps) * 1000)));

        		_frameCounter += 1 * _deltaTime.TotalMilliseconds / 1000;

				if (tilNextFrame.TotalMilliseconds > 0)
				{
        			await Task.Delay(tilNextFrame, stoppingToken);
				}
        	}

			// set the end frame time
            _prevTime = DateTime.Now;
        }
    }

    private Task Run()
    {
    	TaskRun();

        return Task.FromResult("Done");
    }

    public virtual void TaskRun()
    {
        LoggerManager.LogDebug("Executing background service task");
        LoggerManager.LogDebug("Frame count", "", "frameCount", 1000 / _deltaTime.TotalMilliseconds);
        System.Threading.Thread.Sleep(5);
    }

    public long GetTimeMsec()
    {
    	return DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }
}
