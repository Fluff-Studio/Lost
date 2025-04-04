using Godot;
using System;

public partial class Player : CharacterBody3D
{
   
    [Export] public float Speed = 5.0f; // Player movement speed
    private Vector3 _direction = Vector3.Zero; // Direction to move

    public override void _PhysicsProcess(double delta)
    {
        _direction = Vector3.Zero; // Reset direction each frame

        // Check for forward movement (W key)
        if (Input.IsActionPressed("forward"))
            _direction.Z -= 1;

        // Check for backward movement (S key)
        if (Input.IsActionPressed("backward"))
            _direction.Z += 1;

        // Check for left movement (A key)
        if (Input.IsActionPressed("left"))
            _direction.X -= 1;

        // Check for right movement (D key)
        if (Input.IsActionPressed("right"))
            _direction.X += 1;

        // Normalize direction to prevent faster diagonal movement
        _direction = _direction.Normalized();

        // Update the velocity of the character
        Vector3 velocity = Velocity;
        velocity.X = _direction.X * Speed; // Update x velocity (left/right)
        velocity.Z = _direction.Z * Speed; // Update z velocity (forward/back)

        // Apply velocity and move the character
        Velocity = velocity;
        MoveAndSlide();
    }

}
