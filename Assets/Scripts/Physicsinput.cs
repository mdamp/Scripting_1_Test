using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physicsinput : MonoBehaviour
{
    public float jumpForce = 1;
    public Rigidbody reggiebody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump down");
        }
        else if (Input.GetButton("Jump"))
        {
            Debug.Log("Jump hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("Jump up");
        }
    }
}
