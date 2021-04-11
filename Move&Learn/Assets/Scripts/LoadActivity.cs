using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadActivity : MonoBehaviour
{
    TouchPhase touchPhase = TouchPhase.Ended;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            //Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {

                    GameObject touchedObject = hit.transform.gameObject;

                    Debug.Log("Touched " + touchedObject.transform.name);
                    //LoadIt();

                    string ani = touchedObject.transform.name;

                    if (string.Equals(ani,"cat"))
                    {
                        SceneManager.LoadScene(2);
                    }

                    if (string.Equals(ani, "Fox"))
                    {
                        SceneManager.LoadScene(3);
                    }

                    if (string.Equals(ani, "Bee"))
                    {
                        SceneManager.LoadScene(6);
                    }
                }
            }
            
        }
    
    }

    void LoadIt(string name)
    {
        SceneManager.LoadScene(1);
    }
}
