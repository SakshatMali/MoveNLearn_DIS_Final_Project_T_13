using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript1 : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(57f);
        SceneManager.LoadScene(6);
    }
}
