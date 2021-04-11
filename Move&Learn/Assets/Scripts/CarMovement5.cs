using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement5 : MonoBehaviour
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

        car.transform.position = car.transform.position + car.transform.forward * .1f;
        //Debug.Log(car.transform.rotation.eulerAngles.y);

        //Vector3 vs = new Vector3(0, speed, 0);

        if (car.transform.position.x <= -386f)
        {
            car.transform.position = init;
        }
    }
}
