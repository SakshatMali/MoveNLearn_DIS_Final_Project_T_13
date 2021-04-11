using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{

    [SerializeField]
    [Range(0.5f, 1.5f)]
    private float fireRate = 1f; //1 ini

    [SerializeField]
    [Range(1, 10)]
    private int damage = 1;

    private float timer;

    private int countObj;

    [SerializeField]
    private Transform firePoint;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            //if (Input.GetButton("Fire1"))
            //{
            timer = 0f;
            FireGun();
            //}
        }
    }

    private void FireGun()
    {
        Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.red, 2f);
        Ray ray = new Ray(firePoint.position, firePoint.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100))
        {
            var health = hitInfo.collider.GetComponent<Health2>();

            GameObject touchedObject = hitInfo.transform.gameObject;

            Debug.Log("Touched " + touchedObject.transform.name);

            string item = touchedObject.transform.name;

            if (string.Equals(item,"Box"))
            {
                countObj++;
            }

            if (string.Equals(item, "Ball"))
            {
                countObj++;
            }

            if (string.Equals(item, "Bear"))
            {
                countObj++;
            }

            if (string.Equals(item, "Bush"))
            {
                countObj++;
            }

            if (countObj >= 12)
            {
                health.boj = true;
            }

            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }
    }
}
