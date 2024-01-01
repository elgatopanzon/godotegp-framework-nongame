/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : StringName
 * @created     : Saturday Dec 30, 2023 20:27:39 CST
 */

namespace Godot;

public partial class StringName
{
	public string _string { get; set; }

	public StringName(string stringname)
	{
		_string = stringname;
	}

	public static implicit operator string(StringName stringname)
	{
		return (string) stringname._string;
	}

	public static implicit operator StringName(string stringname)
	{
		return (StringName) stringname;
	}
}

