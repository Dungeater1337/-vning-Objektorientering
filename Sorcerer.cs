class Sorcerer : Character 
{
    private int Mana; 
    public Sorcerer(string name, int hp, int mana) : base(name, hp)
    {
        Mana = mana; 
    }
    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, HP: {HP}, Mana: {Mana}");
    }
}