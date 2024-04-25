public enum Itemtype
{
    Weapon, 
    Armor

}


internal class Item
{
    public string Name { get; }
    public string Desc { get; }

    private Itemtype Type;

    public int HP{ get; }
    public int Atk { get; }
    public int Def { get; }
    public int Price { get; }
    public bool IsEqulp { get; private set; }
    public bool isPurch { get; private set;}

    public Item(string name, string desc, Itemtype type, int hP, int atk, int def, int price, bool isEqulp, bool isPurch)
    {
        Name = name;
        Desc = desc;
        Type = type;
        HP = hP;
        Atk = atk;
        Def = def;
        Price = price;
        IsEqulp = isEqulp;
        this.isPurch = isPurch;
    }
}