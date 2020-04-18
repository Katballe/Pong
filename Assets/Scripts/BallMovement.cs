using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float movementSpeed;
    public float speedIncrease;
    public float maxMovementSpeedIncrease;

    int hitCounter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hit counter: {this.hitCounter}, Ball speed: {this.movementSpeed}, Current speed: {movementSpeed * hitCounter}");
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else
            this.MoveBall(new Vector2(1, 0));


    }

    public void IncreaseHitCounter()
    {
        if (this.hitCounter * this.speedIncrease <= this.maxMovementSpeedIncrease)
        {
            this.hitCounter++;
            Debug.Log($"Hit counter: {this.hitCounter}, Ball speed: {this.speedIncrease}, Current speed: {400 + this.speedIncrease * this.hitCounter}");
        }
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        Debug.Log(dir);
        float speed = this.movementSpeed + this.hitCounter * this.speedIncrease;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * speed;
        Debug.Log(rigidbody2D.velocity);

    }
}
