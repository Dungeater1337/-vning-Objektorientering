class Program
{
    public static void Main(string[] args)
    {
        Paladin paladin = new Paladin("McConel", 100, 15);
        Sorcerer sorcerer = new Sorcerer("Gandalf", 100, 50);
        Barbarian barbarian = new Barbarian("Harald", 100, 200);

        paladin.Print(); 
        sorcerer.Print();
        barbarian.Print();
    }
}