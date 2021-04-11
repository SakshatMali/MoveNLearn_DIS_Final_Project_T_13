using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement2 : MonoBehaviour
{

    public Transform car;

    private Vector3 init;


    // Start is called before the first frame update
    void Start()
    {
        init = car.transform.position;
        //car.transform.rotation = Quaternion.Inverse(car.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        car.transform.position = car.transform.position + car.transform.forward * .5f;
        //Debug.Log(car.transform.rotation.eulerAngles.y);

        //Vector3 vs = new Vector3(0, speed, 0);

        if (car.transform.position.x >= -402f)
        {
            car.transform.position = init;
        }
    }
}
