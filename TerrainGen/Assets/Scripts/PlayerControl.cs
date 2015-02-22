using UnityEngine;
using System.Collections;
 
public class PlayerControl : MonoBehaviour {
 
  public float speed;
 
  void FixedUpdate () {
    Vector2 movement = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
    rigidbody2D.velocity = movement * speed;
  }
}