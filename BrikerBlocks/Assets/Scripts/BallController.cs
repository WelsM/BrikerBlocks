using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject Ball;
    Rigidbody2D BallRb;

    Vector2 direction;
    public float speedBall;
    float currentSpeedBall;
    private void Awake() {
        BallRb = Ball.GetComponent<Rigidbody2D>();
        currentSpeedBall = speedBall;
        direction = new Vector2(Random.Range(-1.0f,1.0f),Random.Range(-1.0f,1.0f));
    }

    private void FixedUpdate() {
        BallRb.MovePosition(BallRb.position+direction*currentSpeedBall*Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag=="Limit")
        {
            direction = new Vector2(-direction.x,direction.y);
        }
        else if (other.gameObject.tag=="Player")
        {
            direction = new Vector2(Random.Range(-1.0f,1.0f),-direction.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
    }
}
