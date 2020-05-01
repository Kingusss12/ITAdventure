﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesScript : MonoBehaviour
{
    private void Start()
    {
        Animator anim = GetComponent<Animator>();
        anim.Play("HeartPulsing", 0, Random.Range(0.0f, 1f));
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.playPlusLife();
            Player.Instance.presistentData.Lives++;
            Destroy(gameObject);
            AudioManager.playCoinCollected();
        }
    }
}
