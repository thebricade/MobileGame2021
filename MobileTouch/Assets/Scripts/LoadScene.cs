using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //this will just load a new scene when it is called

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName); 
    }
}
