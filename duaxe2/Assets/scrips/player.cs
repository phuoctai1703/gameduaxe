using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float speedup;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, rb.velocity.y, Input.GetAxis("Vertical")*speed);
        if (Input.GetButton("speedup"))
        {
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed*speedup, rb.velocity.y, Input.GetAxis("Vertical") * speed*speedup);
        }
    }
}
