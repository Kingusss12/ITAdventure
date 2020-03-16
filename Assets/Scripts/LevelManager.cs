using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*  This script handles the World screen
    It is applied to the player
     */

public class LevelManager : MonoBehaviour
{

     void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "treeTraversal":
                SceneManager.LoadScene("TreeTraversal");
                break;
            case "binarySearchTree":
                SceneManager.LoadScene("BinarySearchTree");
                break;
            default:
                break;
        }       
    }
 
}
