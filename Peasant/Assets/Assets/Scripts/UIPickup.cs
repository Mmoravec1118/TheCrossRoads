using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPickup : MonoBehaviour {
    bool growDone = false;
    public Text text;
    // Use this for initialization
    private void OnEnable()
    {
        StartCoroutine("Grow");

    }

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && growDone)
        {
            gameObject.SetActive(false);
            text.text = "";
        }
	}

    IEnumerator Grow()
    {
        GetComponent<RectTransform>().localScale = new Vector3(0,0,0);
        for (int i = 0; i < 100; i++)
        {
            GetComponent<RectTransform>().localScale += new Vector3(.01f,.01f);
            yield return null;
        }
        growDone = true;
    }
}
