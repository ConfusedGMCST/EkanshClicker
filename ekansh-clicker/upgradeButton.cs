using Godot;
using System;

public partial class upgradeButton : Area2D
{
	public Area2D button;
	public Node2D gameNode;
	public int EkanshClicks;
	public bool onButton = false;
	public override void _Ready()
	{
        string node2D = "/root/Node2D/";
        button = GetNode<Area2D>(node2D + "voterButton");
		gameNode = GetNode<Node2D>(node2D);
		EkanshClicks = (int) gameNode.GetMeta("EkanshClicks");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        EkanshClicks = (int)gameNode.GetMeta("EkanshClicks");
        if (Input.IsActionJustPressed("click") && onButton == true) 
		{
			GD.Print(EkanshClicks);
		}
	}

    public override void _MouseEnter()
    {
        onButton = true;
    }
    public override void _MouseExit()
    {
        onButton = false;
    }
}
