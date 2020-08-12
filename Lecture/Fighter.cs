using System;

// derived class
class Fighter : DnDCharacter
{
    /* optionally repeat base constructor
    public Fighter(string name, int strength, int intelligence, int hp)
    {
        this.strength = strength;
        this.intelligence = intelligence;
        this.hp = hp;   
        this.name = name;
    }
    */
    public Fighter(string name, int strength, int intelligence, int hp) : base(name, strength, intelligence, hp)
    {
        // no items in the constructor bc there are no unique Fighter properties- using :base() to inherent all properties from base class
    }
    // method to display slash message
    public void Slash()
    {
        Console.WriteLine($"{this.name} slashes sword with {this.strength} power");
    }
    // overwite base class method
    public new void Attack()
    {
        this.Slash();
    }
    // method to add items to list
    public void StockWeapons()
    {
        this.inventory.Add("axe");
        Console.WriteLine($"{this.name} added an axe to your inventory. You inventory now has {this.inventory.Count} items");
    }
}
