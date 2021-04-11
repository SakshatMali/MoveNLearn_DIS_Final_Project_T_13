using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{
    private CharacterController cc;
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        cc = GetComponent<CharacterController>();
        //transform.Rotate(Vector3.up);
        //cc.SimpleMove(transform.right * Time.deltaTime * 0.0001f)
        Vector3 forward = transform.TransformDirection(Vector3.up);
        float curSpeed = speed;
        cc.SimpleMove(forward * curSpeed);
        //cc.SimpleMove(transform.right * Time.deltaTime * 0.1f);
        if (transform.position.x < 20 || transform.position.x >25)
        {
            Vector3 v = new Vector3(3, 0, 0);
            transform.Rotate(v);
        }
        //transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
        //Debug.Log(player.transform.position.x);

       

    }
}
