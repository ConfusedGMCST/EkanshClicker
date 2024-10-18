using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Node2d : Node2D
{
    int EkanshPresses = 0;
    private RichTextLabel textLabel;
    private Area2D ekanshArea;

    public override void _Ready()
    {
        textLabel = GetNode<RichTextLabel>("/root/Node2D/ekanshText");
        ekanshArea = GetNode<Area2D>("/root/Node2D/Sprite2D/Area2D");

        if (textLabel != null) 
        {
            GD.Print("EkanshCounter initiated.");
        }
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("click"))
        {
            EkanshPresses++;
        }
        textLabel.Text = "Ekansh Clicks: " + EkanshPresses.ToString();
    }
}
