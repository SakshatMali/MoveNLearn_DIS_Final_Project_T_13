using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLook : MonoBehaviour
{

    //public Transform target;
    public Camera targetCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetCamera != null)
        {
            //transform.LookAt(target);
            Vector3 vc = new Vector3(0, 0, 0);
            transform.LookAt(targetCamera.transform.position);
        }
    }
}
