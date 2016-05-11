using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    Rigidbody2D Rigidbody;
    float moveSpeed = 10;
    float hMove;
    float vMove;
    Vector2 vel;
    Vector2 mousePosition;
    float speed = 2f;
    float horizontalSpeed = 2f;
    float verticalSpeed = 2f;
	// Use this for initialization
	void Start () {
        Rigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");

        vel = new Vector2(hMove, vMove);

        Rigidbody.velocity = vel * moveSpeed;
        
    }
}
