using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPlayerControls : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    public float rotSpeed;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotSpeed;
        translation *= Time.deltaTime; //frame independent movement
        Quaternion turn = Quaternion.Euler(0f, rotation, 0f);

        //modify rigid body for movement
        rb.MovePosition(rb.position + transform.forward * translation);
        rb.MoveRotation(rb.rotation * turn);
	}
}
