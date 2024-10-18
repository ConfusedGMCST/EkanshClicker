using Godot;
using System;

public partial class Area2d : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public Area2D ekanshArea;
	public Node2D gameNode;
	public RichTextLabel ekanshLabel;
	public int EkanshClicks = 0;
	public bool onEkansh = false;
	public override void _Ready()
	{
		string node2D = "/root/Node2D";
        gameNode = GetNode<Node2D>(node2D);
        ekanshLabel = GetNode<RichTextLabel>(node2D + "/ekanshText");
		ekanshArea = GetNode<Area2D>(node2D + "/ekanshArea");

		if (ekanshArea != null && gameNode != null && ekanshLabel != null)
		{
			GD.Print("Game initiated.");
		}
	}

    public override void _Process(double delta)
    {
		ekanshLabel.Text = "Ekansh Clicks: " + EkanshClicks.ToString();
		if (Input.IsActionJustPressed("click") && onEkansh == true)
        {
            EkanshClicks++;
        }
    }

    public override void _MouseEnter()
    {
		onEkansh = true;
    }
    public override void _MouseExit()
    {
		onEkansh = false;
    }
}
