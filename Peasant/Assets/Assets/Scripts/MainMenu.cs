using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    public GameObject instructions;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadForest()
    {
        SceneManager.LoadScene("CrossRoads");
    }

    public void ToggleMenu()
    {
        if (instructions.activeSelf == true)
        {
            instructions.SetActive(false);
        }

        else
        {
            instructions.SetActive(true);
        }
    }
}
