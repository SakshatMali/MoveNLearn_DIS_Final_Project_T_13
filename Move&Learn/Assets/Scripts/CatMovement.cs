using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    private CharacterController cc;
    //private float xpos = 8.61f;
    private float rpos = 2f;

    //public GameObject obj;
    public AudioSource Audio;
    public AudioClip meow;
    public Transform player;

    public bool s = false;

    // Start is called before the first frame update
    void Start()
    {
        //player = obj.GetComponentInChildren<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        cc = GetComponent<CharacterController>();
        //transform.Rotate(Vector3.up);
        cc.SimpleMove(transform.forward * Time.deltaTime);
        if (transform.position.z > 8 || transform.position.z < 14)
        {
            transform.Rotate(Vector3.up);
        }
        //transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
        //Debug.Log(player.transform.position.x);

        if (player.transform.position.x < transform.position.x + rpos && player.transform.position.x > transform.position.x - rpos &&
            player.transform.position.z < transform.position.z + rpos && player.transform.position.z > transform.position.z - rpos)
        {
            if (s)
            {
                Audio.PlayOneShot(meow);
                s = false;
            }

        }


        if (player.transform.position.x > transform.position.x + rpos || player.transform.position.x < transform.position.x - rpos)
        {
            s = true;
        }

    }
}
