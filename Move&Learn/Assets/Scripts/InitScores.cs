using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class InitScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path = Application.streamingAssetsPath + "/Text/" + "Incorrect" + ".txt";
        File.WriteAllText(path, "0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
