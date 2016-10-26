using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
    public float tumble;
    private Rigidbody rb;
    private Vector3 rotSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Vector3.Scale(Random.insideUnitSphere, new Vector3(1,1,1)) * tumble;
        //rotSpeed = Vector3.Scale(Random.insideUnitSphere, new Vector3(1,0,1)) * tumble;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(rotSpeed);
    }
}
