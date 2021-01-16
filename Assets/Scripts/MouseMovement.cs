using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Vector3 delta = Vector3.zero;
    public Vector3 lastPos = Vector3.zero;
    public float mouseCursorSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // User clicked Primary button
        {
            lastPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0)) // Primary button held down
        {
            // Mouse position
            delta = Input.mousePosition - lastPos;
            Debug.Log("delta: " + delta);

            // Speed
            mouseCursorSpeed = delta.magnitude / Time.deltaTime;
            Debug.Log("mouseCursorSpeed: " + mouseCursorSpeed);

            lastPos = Input.mousePosition;
        }
    }
}
