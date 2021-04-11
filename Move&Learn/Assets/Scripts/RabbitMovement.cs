using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMovement : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //cc.SimpleMove(transform.right * Time.deltaTime * 0.1f);
        if (transform.position.x < 16 || transform.position.x > 23)
        {
            Vector3 v = new Vector3(0, 5, 0);
            transform.Rotate(v);
        }
        //transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
        //Debug.Log(player.transform.position.x);



    }
}
