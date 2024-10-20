using Godot;
using System;

public partial class upgradeButton : Area2D
{
	public Area2D button;
	public Node2D gameNode;
	public string addedCps = "AddedCps";
	public string cpsAdd = "cpsAdd";
    public string totalCps = "totalCps";
	public string price = "price";
	public float currentPrice;
    public float EkanshClicks;
	public float priceModifier;
    public bool onButton = false;
	public override void _Ready()
	{
        string node2D = "/root/Node2D/";
        button = GetNode<Area2D>(node2D + "upgradeButton1");
		gameNode = GetNode<Node2D>(node2D);
		EkanshClicks = (float) gameNode.GetMeta("EkanshClicks");

    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        EkanshClicks = (float) gameNode.GetMeta("EkanshClicks");
		currentPrice = (float) button.GetMeta(price);
		priceModifier = (float) gameNode.GetMeta("priceModifier");

        if (Input.IsActionJustPressed("click") && onButton == true && EkanshClicks >= currentPrice) 
		{
			GD.Print("upgrade");
			EkanshClicks -= currentPrice;
            button.SetMeta(price, currentPrice *= priceModifier);
            gameNode.SetMeta("EkanshClicks", EkanshClicks);
            GD.Print("Ekansh Clicks: " + gameNode.GetMeta("EkanshClicks") + "\nUpgrade Price: " + button.GetMeta(price));
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
