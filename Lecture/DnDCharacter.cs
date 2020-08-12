using System;
using System.Collections.Generic; // required import to use lists

// base class
class DnDCharacter
{
    protected string name;
    protected int strength;
    protected int intelligence;
    protected int hp;
    protected List<string> inventory = new List<string>(); // define an empty list of strings
    public DnDCharacter(string name, int strength, int intelligence, int hp)
    {
        this.name = name;
        this.strength = strength;
        this.intelligence = intelligence;
        this.hp = hp;
    }
    /* optionally set empty construtcor if not using :base() in derived class
    public DnDCharacter()
    {

    }
    */
    // method to display properties
    public void OutputProps()
    {
        Console.WriteLine($"{this.name} has {this.hp} hp, {this.strength} strength and {this.intelligence} intelligence");
    }
    // method to display attack message
    public void Attack()
    {
        Console.WriteLine($"{this.name} attacks!");
    }
    // method to add items to list
    public void StockUp()
    {
        this.inventory.Add("cooked meat");
        Console.WriteLine($"{this.name} added cooked meat to your inventory. You inventory now has {this.inventory.Count} items");
    }
    // method to remove items from list by value
    public void RemoveFromInventory(string itemToRemove)
    {
        this.inventory.Remove(itemToRemove);
        Console.WriteLine($"You removed {itemToRemove} you now have {this.inventory.Count} items");
    }
    // method to remove items from list by index position
    public void RemoveFromInventory(int itemToRemove)
    {
        this.inventory.RemoveAt(itemToRemove);
        Console.WriteLine($"You removed {this.inventory[itemToRemove]} you now have {this.inventory.Count} items");
    }
}
