using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D PlayerRb;
    [SerializeField]
    private float speed = 200;

    float currentSpeed;
    float hori;

    private void Awake() {
        PlayerRb = Player.GetComponent<Rigidbody2D>();
    }

    private void Start() {
        currentSpeed = speed;
    }

    private void FixedUpdate() {
        hori = Input.GetAxisRaw("Horizontal");
        PlayerRb.velocity = new Vector2(hori,0)*currentSpeed*Time.fixedDeltaTime;
    }


}
