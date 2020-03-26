[System.Serializable] //save it in file
public class PlayerData
{
    public int Coins, Lives;
    public bool TreeTraversal;

    public PlayerData(int lives, int coins, bool treeTraversal)
    {

        Coins = coins;
        Lives = lives;
        TreeTraversal = treeTraversal;

    }


}

