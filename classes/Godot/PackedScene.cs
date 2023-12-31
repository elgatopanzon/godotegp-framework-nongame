/**
 * @author      : ElGatoPanzon (contact@elgatopanzon.io) Copyright (c) ElGatoPanzon
 * @file        : PackedScene
 * @created     : Saturday Dec 30, 2023 21:17:05 CST
 */

namespace Godot;

public partial class PackedScene : Resource
{
	public PackedScene()
	{
		
	}

	public Node Instantiate()
	{
		return new Node();
	}
}

