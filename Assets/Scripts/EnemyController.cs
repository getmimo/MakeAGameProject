using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

  public bool moveLeft;
  public LayerMask groundLayer;
  public Transform wallCheck;
  public float wallCheckRadius;
  private bool wallCollision;
  
  void Start () {
    moveLeft = true;
  }

  void FixedUpdate () {
    wallCollision = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, groundLayer);
  }
  
  void Update ()
  {
    var rigidBody = GetComponent<Rigidbody2D> ();
    
    if (wallCollision) {
      moveLeft = !moveLeft;
    }

    if (moveLeft) {
      transform.localScale = new Vector2 (1,1);
      rigidBody.velocity = new Vector2 (-5, rigidBody.velocity.y);
    } else {
      transform.localScale = new Vector2 (-1,1);
      rigidBody.velocity = new Vector2 (5,rigidBody.velocity.y);
    } 
  }
}
