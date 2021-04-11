using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;

public class Health7 : MonoBehaviour
{

    //public static Health hel;

    //public int score = 0;
    //public TextAsset asset;


    [SerializeField]
    private int startingHealth = 3; //5 ini

    private int currentHealth;

    public int over = 0;

    public Transform target;

    public AudioSource Audio;
    public AudioClip query;


    //public AudioSource AudioVoice;
    //public AudioClip Spell;

    private const float xangle = 90f;

    

    private void OnEnable()
    {
        currentHealth = startingHealth;
        //hel = this;

    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {

            /*string path = "Assets/Scripts/Incorrect.txt";
            StreamReader reader = new StreamReader(path);
            string score = reader.ReadToEnd();
            reader.Close();

            int curr = int.Parse(score);
            //Debug.Log(curr);
            curr++;
            //Debug.Log(curr);

            //string path = "Assets/Scripts/Score.txt";
            File.Create(path).Close();
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(curr.ToString());
            writer.Close();*/


            //Audio.GetComponent<AudioSource>().Play();



            /*string path = Application.streamingAssetsPath + "/Text/" + "Incorrect" + ".txt";
            string score = File.ReadAllText(path);

            int curr = int.Parse(score);
            curr++;

            File.WriteAllText(path, curr.ToString());
            Debug.Log(curr.ToString());*/



            Die();

            

        }
    }


   

    public void Die()
    {

        Audio.PlayOneShot(query , 1f);
        //Destroy(gameObject);
        gameObject.SetActive(false);

        //gameObject.transform.position = gameObject.transform.forward * 100;



        /*over++;
        if (over >= 1)
        {
            Loadit();
        }*/

        Loadit();
    }

    public void Loadit()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        //transform.rotation = Quaternion.Euler(xangle, 0, 0);
        /*Vector3 dir = new Vector3(0, 1, 0);
        Vector3 direction = Vector3.RotateTowards(dir, target.transform.position - transform.position, 2f, 0f);
        transform.rotation = Quaternion.LookRotation(direction);*/

        /*Vector3 _dir = (target.position - transform.position);
        _dir.Normalize();
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_dir), 20 * Time.deltaTime);*/

        //Debug.Log(score);
    }
}
