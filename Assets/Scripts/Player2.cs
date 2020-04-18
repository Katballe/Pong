using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float movementSpeedPlayer2;

    // updates a fixed amount of times a second
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeedPlayer2;
    }



}
