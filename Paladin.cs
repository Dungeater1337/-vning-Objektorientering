class Paladin : Character 
{
    private  Paladin(string name, int hp) : base(name, hp)
    {
        Weapon = weapon;
    }

    private override string Name => $"Paladin: {base.Name}";
    private override int HP => base.HP;

    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, HP: {HP}");
    }
}