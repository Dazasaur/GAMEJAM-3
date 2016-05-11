using UnityEngine;
using System.Collections;

public class Actions : MonoBehaviour {

    public Transform target;
    public int damp = 5;
	// Use this for initialization
	void Start () {
	
	}
     
 void Update()
    {
        if (target) // we get sure the target is here
        {
            var rotationAngle = Quaternion.LookRotation(target.position - transform.position); // we get the angle has to be rotated
            Debug.Log(rotationAngle);
            Debug.Log(target);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationAngle, Time.deltaTime * damp); // we rotate the rotationAngle 
        }
    }
}
