using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  public SpriteRenderer sprite;
  private bool grounded;
  public LayerMask groundLayer;
  public Transform groundCheck;
  public float groundCheckRadius;
  private bool groundCollision;

  void Start () {

  }

  void FixedUpdate () {
    groundCollision = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, groundLayer);
    Debug.Log ("I am grounded = " + grounded);

  }

  void Update () {
    var rigidBody = GetComponent<Rigidbody2D> ();
    var transform = GetComponent<Transform> ();
    if (Input.GetKey ("right")) {
      sprite.flipX = false; 
      rigidBody.velocity = new Vector2 (5, rigidBody.velocity.y);
    }
    if (Input.GetKey ("left")) {
      sprite.flipX = true;
      rigidBody.velocity = new Vector2 (-5, rigidBody.velocity.y);
    }
    if (Input.GetKeyDown ("space"))
      rigidBody.velocity = new Vector2 (rigidBody.velocity.x,10);
    if (transform.position.y < -6) 
      if (transform.position.x < 2)
        transform.position = new Vector2 (-5,2);
    else
        transform.position = new Vector2 (2,2);
  
  }

  public void OnTriggerEnter2D (Collider2D other) {
    if (other.name == "EnemyDamage") {
      transform.position = new Vector2 (2, 1);
    }
  }
}
