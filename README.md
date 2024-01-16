# godotegp-framework-nongame

This project started as a way to use my
[GodotEGP Framework](https://github.com/elgatopanzon/godotegp-framework) library
outside of Godot itself. I also refer to it as "Fake Godot" or a partial Godot
environment emulation.

For the most part, this is just a dummy library however it does include an
implementation of Godot's Nodes system and the `SceneTree` providing a 60 FPS
threaded `BackgroundService` instance providing delta time to issue
`_Process()`and `_PhysicsProcess()` calls, and makes Nodes actually work e.g.
the `Timer` node.
