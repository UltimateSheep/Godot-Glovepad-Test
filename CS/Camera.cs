using Godot ;
using System;

public partial class Camera : Camera3D
{

	[Export]
	NodePath playerPath;
	SoftBody3D player;



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetNode<SoftBody3D>(playerPath);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
