class Barbarian : Character 
{
    private int RageLevel;
    public Barbarian(string name, int hp, int ragelevel) : base(name, hp)
    {
        RageLevel = ragelevel;
    }

   

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, HP: {HP}, RageLevel: {RageLevel}");
    }
}