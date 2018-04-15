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
  
  }
  
  void Update () {
    var rigidBody = GetComponent<Rigidbody2D> ();
    if (moveLeft) {
      rigidBody.velocity = new Vector2 (-5, rigidBody.velocity.y);
    } else {
        rigidBody.velocity = new Vector2 (5,rigidBody.velocity.y);
    } 
  }
}
