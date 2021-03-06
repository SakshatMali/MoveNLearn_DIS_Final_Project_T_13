using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeGun : MonoBehaviour
{

    [SerializeField]
    [Range(0.5f, 1.5f)]
    private float fireRate = 1f; //1 ini

    [SerializeField]
    [Range(1, 10)]
    private int damage = 1;

    private float timer;

    [SerializeField]
    private Transform firePoint;

    //public let last_health;
    //private AnimalSound lastHealth;

    // Start is called before the first frame update
    void Start()
    {
        //lastHealth = GetComponent<AnimalSound>();
    }



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
            var health = hitInfo.collider.GetComponent<AnimalSound>();
            //lastHealth.setGlow(false);
            //lastHealth = health;

            if (health != null)
            {
                health.TakeDamage(damage);
                //health.setGlow(true);
                
            }
        }
    }
}
