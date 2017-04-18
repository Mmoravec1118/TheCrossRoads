using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Destroy(this);
        }
    }


}
