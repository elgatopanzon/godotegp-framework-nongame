/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : RandomNumberGenerator
 * @created     : Saturday Dec 30, 2023 21:14:57 CST
 */

namespace Godot;

public partial class RandomNumberGenerator : Node
{
	public ulong Seed { get; set; }
	public ulong State { get; set; }

	public RandomNumberGenerator()
	{
		
	}

	public void Randomize()
	{
		
	}

	public float Randf()
	{
		return 0;
	}

	public float RandfRange(float from, float to)
	{
		return 0;
	}
}

