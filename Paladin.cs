class Paladin : Character 
{
    private int HolyPower;
    public Paladin(string name, int hp, int holyPower) : base(name, hp)
    {
        HolyPower = holyPower;
    }
    


    public override void Print()
    {
        Console.WriteLine($"Name: {Name}, HP: {HP}, HolyPower: {HolyPower}");
    }
}