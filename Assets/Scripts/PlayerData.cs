[System.Serializable] //save it in file
public class PlayerData
{
    public int Coins, Lives;
    public bool TreeTraversal, BinarySearchTree, Sort, Queue, Stack, LinkedList;

    public PlayerData(int lives, int coins, bool treeTraversal, bool binarySearchTree, bool sort, bool stack, bool queue, bool linkedList)
    {

        Coins = coins;
        Lives = lives;
        TreeTraversal = treeTraversal;
        BinarySearchTree = binarySearchTree;
        Sort = sort;
        Stack = stack;
        Queue = queue;
        LinkedList = linkedList;

    }


}

