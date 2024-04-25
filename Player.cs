internal class Player
{
    public string Name { get; }

    public int Level { get; }

    public string Job { get; }
    public int Hp { get; }
    public int Atk { get; }

    public int Def { get; }

    public int Gold { get; set; }

    public Player(string name, int level, string job, int hp, int atk, int def, int gold)
    {
        Name = name;
        Level = level;
        Job = job;
        Hp = hp;
        Atk = atk;
        Def = def;
        Gold = gold;
    }
}