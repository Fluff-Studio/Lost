using Godot;
using System;

public partial class Main : Node2D
{
    [Export] PackedScene world;
    [Export] Button playButton;

    public override void _Ready()
    {
        // Get the button by name (assuming you named it "MyButton" in the editor)
        playButton = GetNode<Button>("Play");

        // Connect the button's "pressed" signal to a function
        playButton.Pressed += OnButtonPressed;
    }

    // The function to handle the button press
    private void OnButtonPressed()
    {
        GD.Print("Button was pressed!");
        GetTree().ChangeSceneToPacked(world);
    }

}
