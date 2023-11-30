abstract class Character
{
    protected string Name;
    protected int HP;
    public Character(string name, int hp)
    {
        this.Name = name;
        this.HP = hp;
    }
    public abstract void Print();
}