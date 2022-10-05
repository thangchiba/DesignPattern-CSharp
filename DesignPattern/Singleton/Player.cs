public class Player
{
    int id;
    string name;
    private object playerLock = new object();

    public Player(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return Id + " : " + Name;
    }
}