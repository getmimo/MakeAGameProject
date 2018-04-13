using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

  public bool moveLeft;
  
  void Start () {
    moveLeft = true;
  }
  
  void Update () {
    var rigidBody = GetComponent<Rigidbody2D> ();
    rigidBody.velocity = new Vector2 (-5,rigidBody.velocity.y);
  }
}
