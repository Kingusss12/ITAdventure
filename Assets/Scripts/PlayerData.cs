[System.Serializable] //save it in file
public class PlayerData
{
    public int Coins, Lives;
    public bool gameIsSaved;

    public PlayerData(int lives, int coins)
    {

        Coins = coins;
        Lives = lives;

    }


}

