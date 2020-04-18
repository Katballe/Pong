using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;

    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        // ball position.       the position of this game object 
        Vector3 ballPosition = this.transform.position;

        // recket position
        Vector3 racketPosition = c.gameObject.transform.position;

        // racket height
        float racketHeight = c.collider.bounds.size.y;

        // the vertical direction the ball should go
        float x;
        if (c.gameObject.name == "Player 1"){
            x = 1;  // rgiht
        }
        else{
            x = -1; // left
        }  
        
        // if y is positive the ball is above the center of the racket, else it's negative
        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            this.BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "Left wall")
        {
            //Debug.Log("Point to player two!");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "Right wall")
        {
            //Debug.Log("Point to player one!");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));
        }

    }
}
