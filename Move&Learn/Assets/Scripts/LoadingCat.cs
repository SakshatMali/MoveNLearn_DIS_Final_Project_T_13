using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingCat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cat;
    private float speed=1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cat.transform.position = cat.transform.position + cat.transform.right * speed;
        //Debug.Log(cat.transform.position.x);

        if (cat.transform.position.x>=1490f)
            SceneManager.LoadScene(1);
    }
}
