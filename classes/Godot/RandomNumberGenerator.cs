/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : RandomNumberGenerator
 * @created     : Saturday Dec 30, 2023 21:14:57 CST
 */

namespace Godot;

using GodotEGP.Logging;

public partial class RandomNumberGenerator : Node
{
	private ulong _seed = 0;
	public ulong Seed
	{
		get { return _seed; }
		set { _seed = value; }
	}

	private ulong _state;
	public ulong State
	{
		get { return _state; }
		set { 
			_state = value;

			_random = new Random((int) _seed);
			for (int i = 0; i < (int) _state; i++)
			{
				_random.NextDouble();
			}
		}
	}

	private Random _random;

	public RandomNumberGenerator()
	{
		_random = new Random((int) _seed);
	}

	public float Randf()
	{
		_state++;
		return (float) _random.NextDouble();
	}

	public float RandfRange(float from, float to)
	{
		_state++;
		return (float) _random.NextDouble() * (to - from) + from;
	}

	public int Randfn()
	{
		_state++;
		LoggerManager.LogCritical("Randfn() not implemented");
		return 0;
	}

	public int Randi()
	{
		_state++;
		return _random.Next();
	}

	public int RandiRange(int from, int to)
	{
		_state++;
		return _random.Next(from, to);
	}

	public void Randomize()
	{
		_seed = (ulong) Guid.NewGuid().GetHashCode();
		_random = new Random((int) _seed);
	}

}

