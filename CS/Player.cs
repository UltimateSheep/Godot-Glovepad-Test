using Godot;
using System;

public partial class Player : SoftBody3D
{
	public Vector3 rotation_input = Vector3.Zero;

	[Export]
	public int speed = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		ProcessInput(delta);

		Vector3 velocity = new Vector3(rotation_input.X, 0, rotation_input.Z) * speed * (float)delta;
		ApplyCentralForce(velocity);
	}

    private void ProcessInput(double delta)
    {
		rotation_input = Vector3.Zero;

        //forward, sideways, backward movement
		if (Input.IsActionPressed("move_up"))
		{
			rotation_input.X = 1;
		}
		if (Input.IsActionPressed("move_down"))
		{
			rotation_input.X = -1;
		}
		if (Input.IsActionPressed("move_left"))
		{
			rotation_input.Z = -1;
		}
		if (Input.IsActionPressed("move_right"))
		{
			rotation_input.Z = 1;
		}
		if (Input.IsActionJustPressed("jump"))
		{
			ApplyCentralImpulse(new Vector3(0, 2.5f, 0) * speed * TotalMass * (float)delta);
		}
    }

		
}
