﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public GameObject HelpPanel, unlockText, HelpText, SolvedText;
    bool IsUnlocked = false;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (!IsUnlocked)
            {
                HelpPanel.gameObject.SetActive(true);
                unlockText.gameObject.SetActive(true);
            }
            else
            {
                HelpPanel.gameObject.SetActive(true);
            }
        }
    }

    public void ExitHelp()
    {
        HelpPanel.gameObject.SetActive(false);
    }

    public void unlockHelp()
    {
        if(Player.Instance.presistentData.Coins >= 50)
        {
            Player.Instance.presistentData.Coins -= 50;
            unlockText.gameObject.SetActive(false);
            HelpText.gameObject.SetActive(true);
            IsUnlocked = true;
        }
        else
        {
            AudioManager.playNoMoney();
            ExitHelp();
        }
    }

    public void Open()
    {
        if (!IsUnlocked)
        {
            IsUnlocked = true;
            HelpPanel.gameObject.SetActive(true);
            unlockText.gameObject.SetActive(false);
            HelpText.gameObject.SetActive(false);
            SolvedText.SetActive(true);
        }
    }

}
