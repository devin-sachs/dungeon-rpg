using Godot;
using System;

public partial class Player : CharacterBody3D
{

    private Vector2 direction = new();
    public override void _PhysicsProcess(double delta)
    {
        // base._PhysicsProcess(delta);
        // GD.Print("Player physics process");

        Velocity = new(direction.X, 0, direction.Y);
        Velocity *= 5;

        MoveAndSlide();
    }

    public override void _Input(InputEvent @event)
    {
        // base._input(@event);
        // GD.Print("Player input event");

       direction = Input.GetVector(
            "MoveLeft",
            "MoveRight",
            "MoveForward",
            "MoveBackward"
        );
    }

}
