using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(introText());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator introText()
    {
        GetComponent<Text>().text = "Ugh, my head... Where the hell am I? \n Who Am I? Why can't I remember anything...";
        yield return new WaitForSeconds(5);
        GetComponent<Text>().text = "";

    }
}
