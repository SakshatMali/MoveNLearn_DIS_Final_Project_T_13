using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CalculateScore : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField]
    private string score;

    public Text scoreText;
    public Text activityText;
    public Text starText;

    private string path;
    //private StreamReader reader;

    private WWW data;

    public IEnumerator Fyll()
    {
        data = new WWW(Application.streamingAssetsPath + "/Text/" + "Incorrect" + ".txt");
        yield return data;
    }
    void Start()
    {
        //score = cal.score;
        /*path = "Assets/Scripts/Incorrect.txt";
        reader = new StreamReader(path);
        score = reader.ReadToEnd();
        reader.Close();

        scoreText.text = score;


        path = "Assets/Scripts/Activity.txt";
        reader = new StreamReader(path);
        score = reader.ReadToEnd();
        reader.Close();

        activityText.text = score;


        path = "Assets/Scripts/Star.txt";
        reader = new StreamReader(path);
        score = reader.ReadToEnd();
        reader.Close();

        starText.text = score;
        */

        /*path = Application.streamingAssetsPath + "/Text/" + "Incorrect" + ".txt";
        score = File.ReadAllText(path);
        scoreText.text = score;*/
        StartCoroutine(Fyll());
        scoreText.text = data.text;

        /*
        string reader = Application.streamingAssetsPath + "/Text/" + "Score" + ".txt";
        string sc = File.ReadAllText(reader);
        Debug.Log(sc);
        scoreText.text = sc;

        File.WriteAllText(reader, "98");
        */


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Shooting: " + score);
        
        /*string a = score;
        Debug.Log(a);
        string cur = "Shooting: "+a;
        
        scoreText.text = cur;*/
        //Debug.Log(cur);
        //scoreText.text = "Shooting: " + score;
        //Debug.Log(score);
        //Debug.Log(scoreText);
    }
}
