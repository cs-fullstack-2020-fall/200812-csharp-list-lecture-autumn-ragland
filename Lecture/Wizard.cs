using System;

// derived class
class Wizard : DnDCharacter
{
    public string magic; // property unique to Wizard objects

    /* optionally repeat base constructor
    public Wizard(string name,int strength, int intelligence, int hp, string magic)
    {
        this.strength = strength;
        this.intelligence = intelligence;
        this.hp = hp;   
        this.name = name;
        this.magic = magic
    }
    */
    public Wizard(string name, int strength, int intelligence, int hp, string magic) : base(name, strength, intelligence, hp)
    {
        this.magic = magic;
    }
    // method to display spell message
    public void Spell()
    {
        Console.WriteLine($"{this.name} casts a spell with {this.strength} power");
    }
    // method to display magic message
    public void OutputMagic()
    {
        Console.WriteLine($"{this.name} magical ability is : {this.magic}");
    }
    // overwite base class method
    public new void Attack()
    {
        this.Spell();
    }
    // method to add items to list
    public void StockMagicItems()
    {
        this.inventory.Add("potion");
        Console.WriteLine($"{this.name} added a potion to your inventory. You inventory now has {this.inventory.Count} items");
    }

}
