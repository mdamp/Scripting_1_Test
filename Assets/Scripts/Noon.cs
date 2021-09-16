using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noon : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float sAngle;
    public float eAngle;
    
    //public Vector3 startAngle;
    //public Vector3 endAngle;
    //Vector3 curVel = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.eulerAngles = startAngle;
        Vector3 angle = this.transform.eulerAngles;
        angle.z = sAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVel, rotationSpeed);

        Vector3 tempAngle = this.transform.eulerAngles;

        tempAngle.z += rotationSpeed * Time.deltaTime;

        this.transform.eulerAngles = tempAngle;
    }
}
