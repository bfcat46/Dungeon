public class GameManager
{
    private Player player;
    private List<Item> inventory;

    public GameManager()
    {
        InitializeGame();
    }

    private void InitializeGame();
    {
        player = new Player("창영", 1, "백수", 100, 10, 5, 3000);
    }
}




public class Program
{ 
    public static void Main(string[] args)
    {
        GameManager gameManager = new GameManager();
        gameManager.Start();
    }

}
