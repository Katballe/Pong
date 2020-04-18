using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource racketSound;
    public AudioSource wallSound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            this.racketSound.Play();
        }
        else
            this.wallSound.Play();
    }

}
