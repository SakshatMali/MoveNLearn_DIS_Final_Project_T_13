using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(1);
    }
}
