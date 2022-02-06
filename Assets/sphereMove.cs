using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour
{
    private Rigidbody rb;
    Vector3 newVelocity = Vector3.zero;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      
        float newVelocity = 0.1f;
        
        float yRot = gameObject.transform.eulerAngles.y/360 * 2 * Mathf.PI;
        float Vx = newVelocity * Mathf.Cos(yRot);
        float Vy = newVelocity * Mathf.Sin(yRot);
        if (Input.GetKey("w"))
        {
          if (rb.velocity.magnitude < 35)
            rb.velocity += new Vector3(Vy, 0, Vx);
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.Rotate(0, -0.4f, 0, Space.Self);
        }
        if (Input.GetKey("s"))
        {
           rb.velocity += new Vector3(-Vy, 0, -Vx);
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Rotate(0, 0.4f, 0, Space.Self);
        }


       


    }
}
