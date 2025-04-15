using Godot;
using System;

public partial class Main : Node2D
{
	[Export] PackedScene world;
	[Export] Button playButton;

	public override void _Ready()
	{
		
		playButton = GetNode<Button>("Play");

		
		playButton.Pressed += OnButtonPressed;
	}

	
	private void OnButtonPressed()
	{
		GD.Print("Button was pressed!");
		GetTree().ChangeSceneToPacked(world);
	}

}
