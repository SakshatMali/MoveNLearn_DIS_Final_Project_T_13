using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundPlayerX : MonoBehaviour
{

    private float rpos = .3f;

    //public GameObject obj;
    public AudioSource Audio;
    public AudioClip letter;
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

        if (player.transform.position.x < transform.position.x + rpos && player.transform.position.x > transform.position.x - rpos)
        {
            if (s)
            {
                Audio.GetComponent<AudioSource>().Play();
                Debug.Log("road");
                Debug.Log(transform.name);
                s = false;
            }

        }


        if (player.transform.position.x > transform.position.x + rpos || player.transform.position.x < transform.position.x - rpos)
        {
            s = true;
        }

    }
}
