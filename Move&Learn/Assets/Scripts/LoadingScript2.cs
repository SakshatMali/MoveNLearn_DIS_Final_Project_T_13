using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript2 : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(53f);
        SceneManager.LoadScene(7);
    }
}
