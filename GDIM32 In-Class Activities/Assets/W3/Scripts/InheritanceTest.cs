using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
	// don't change anything in Main()!
	private void Start()
	{
		Player player = new Player();
		Enemy enemy = new Enemy();
		Villager villager = new Villager();
		
		player.TalkToNpc(enemy);
		player.TalkToNpc(villager);
	}
}

// don't change anything about the Player class!
public class Player 
{
	private string _name = "Travis";
	public virtual void TalkToNpc (Npc npc)
	{
		npc.Talk(_name);
	}
}

// don't change anything about the NPC class!
public class Npc
{
	public virtual void Talk(string playerName) {}
}

// CHANGE THINGS IN VILLAGER...
public class Villager:Npc
{
    public override void Talk(string playerName)
    {
		Debug.Log("hey I am a villager "+playerName);
    }
}

// CHANGE THINGS IN ENEMY...
public class Enemy:Npc
{
    public override void Talk(string playerName)
    {
        Debug.Log("hey I am a Enemy! I'll kill u!"+playerName);
    }
}
