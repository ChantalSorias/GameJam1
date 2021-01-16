using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mouseTracker;
    Rigidbody rb_thigh;
    // Rigidbody rb_
    void Awake()
    {
        rb_thigh = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) // User clicked Primary button
        {
            rb_thigh.AddForce(mouseTracker.GetComponent<MouseMovement>().delta * mouseTracker.GetComponent<MouseMovement>().mouseCursorSpeed);
        }
    }
}
