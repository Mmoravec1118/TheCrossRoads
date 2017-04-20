using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MouseOverToolTip : MonoBehaviour {

    public Pickup pickUp
    {
        get; set;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MouseEnter()
    {
        GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().text = pickUp.pickUpText;
    }

    public void MouseExit()
    {
        GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().text = "";
    }
}
