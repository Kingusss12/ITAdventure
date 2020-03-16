using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    public GameObject escapeCanvas;
   

    // Update is called once per frame
    void Update()
    {
        //If player push the "escape button, the player goes back to the MainScreen(Main Menu)"
        if (Input.GetKey("escape"))
        {
            escapeCanvas.gameObject.SetActive(true);
        }
    }

    /*
Saves player's data's like Live and coin amount to a binary file and navigates back to MainScene
*/


    public void SavePlayer()
    {
        SaverScript.SavePlayer(Player.Instance.lives, Player.Instance.coins);
        escapeCanvas.gameObject.SetActive(false);
        SceneManager.LoadScene("MainScreen");

    }

    public void Leave()
    {
        escapeCanvas.gameObject.SetActive(false);
        SceneManager.LoadScene("MainScreen");
    }


}
