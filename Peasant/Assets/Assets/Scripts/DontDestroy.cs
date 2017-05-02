using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    // Use this for initialization
    private static GameObject instance;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {
            instance = gameObject;
        }
        else
        {
            DestroyObject(gameObject);
        }
        SceneManager.sceneLoaded += DestroyThis;
    }

    private void DestroyThis(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.buildIndex == SceneUtility.GetBuildIndexByScenePath("Scenes/EndScreen"))
        {
           Destroy(GameObject.FindGameObjectWithTag("Canvas"));
        }
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Destroy(gameObject);
        }
    }
    


}
