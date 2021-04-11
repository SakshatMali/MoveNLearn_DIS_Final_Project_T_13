using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;

public class AnimalSound : MonoBehaviour
{

    //public static Health hel;

    //public int score = 0;
    //public TextAsset asset;


    [SerializeField]
    private int startingHealth = 3; //5 ini

    //public bool glow = false;

    public Behaviour halo; 

    private int currentHealth;
    private int currentHealthSound;

    //public int over = 0;

    public Transform target;

    public AudioSource Audio;
    public AudioClip query;

    private const float xangle = 90f;

    //private float delay;


    public IEnumerator delay()
    {
        //Debug.Log("Start");
        yield return new WaitForSeconds(.5f);
        halo.enabled = false;
        //Debug.Log("End");
    }
    /*public void setGlow(bool glow)
    {
        if (glow)
        {
            halo.enabled = true;
            StartCoroutine(delay());
         
        }
    }*/

    private void OnEnable()
    {
        currentHealth = startingHealth;
        //halo = (Behaviour)GetComponent("Halo");
        
        
        //hel = this;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealthSound -= damageAmount;
        halo.enabled= true;

        if (currentHealth <= 2)
        {
            
            Die();
            currentHealth = startingHealth;
            
        }

        if (currentHealthSound <= 0)
        {

            DieSound();
            currentHealthSound = startingHealth;

        }
    }

    public void Die()
    {
        //Audio.PlayOneShot(query);
        StartCoroutine(delay());
        
    }

    public void DieSound()
    {
        Audio.PlayOneShot(query);
        //StartCoroutine(delay());

    }

    public void Loadit()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        //halo.enabled = false;


    }
}
