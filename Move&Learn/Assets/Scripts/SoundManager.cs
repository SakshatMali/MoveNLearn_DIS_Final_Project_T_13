using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource LetterSource;
    public AudioSource SpellSource;
    // Start is called before the first frame update
    void Start()
    {
        LetterSource = gameObject.AddComponent<AudioSource>();
        SpellSource = gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
