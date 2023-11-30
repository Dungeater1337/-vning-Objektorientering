abstract class Character
{
    protected abstract string Name;
    protected abstract int HP;
    int Character(string name, int hp)
    {
        Name = name;
        HP = hp; 
    }

    private abstract void Print();
}