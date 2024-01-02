/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : Time
 * @created     : Saturday Dec 30, 2023 21:21:05 CST
 */

namespace Godot;

public partial class Time
{
	private static DateTime _firstAccess = DateTime.Now;

	public Time()
	{
		
	}

	public static ulong GetTicksMsec()
	{
		return (ulong) (DateTime.Now - Time._firstAccess).TotalMilliseconds;
	}
}

