using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickForceApply : MonoBehaviour
{
    public float thrust = 1.0f;

    public Rigidbody rb;
    Transform initialTransform;
    public float score = 0;
    bool kicked = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialTransform = transform;
    }


    void Update(){
        if(kicked && transform.position.y <= 0){
            score = (transform.position - initialTransform.position).magnitude;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.GetContact(0);
        rb.AddForceAtPosition(contact.normal * thrust,contact.point,ForceMode.Force);
        kicked = true;
    }

    public void Reset(){
        transform.position = initialTransform.position;
        transform.rotation = initialTransform.rotation;
        rb.velocity = Vector3.zero;
        rb.rotation = Quaternion.identity;
        kicked = false;
        score = 0;
    }

}
