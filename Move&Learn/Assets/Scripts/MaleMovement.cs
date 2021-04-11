using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleMovement : MonoBehaviour
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

        car.transform.position = car.transform.position + car.transform.forward * Time.deltaTime;
        //Debug.Log(car.transform.rotation.eulerAngles.y);

        //Vector3 vs = new Vector3(0, speed, 0);

        if (car.transform.position.z <= 20f)
        {
            car.transform.position = init;
        }
    }
}
