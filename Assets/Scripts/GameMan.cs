using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
    public GameObject escapeCanvas;

    //private static GameMan instance;
    //public Vector2 lastCheckpointPose;

    // void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(instance);
    //    }
    //    else
    //    {
    //        DestroyObject(gameObject);
    //    }
   
    //}


    // Update is called once per frame
    void Update()
    {
        //If player push the "escape button, the player goes back to the MainScreen(Main Menu)"
        if (Input.GetKey("escape"))
        {
            escapeCanvas.gameObject.SetActive(true);
        }
    }

    public void BackToWorld()
    {
        escapeCanvas.gameObject.SetActive(false);
        SceneManager.LoadScene("World");
    }

    public void ContinueLevel()
    {
        escapeCanvas.gameObject.SetActive(false);
    }
}
