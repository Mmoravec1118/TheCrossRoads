using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public Lever lever1;
    public Lever lever2;
    public Lever lever3;
    public Lever lever4;

    public GameObject portal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lever1.pulled && lever2.pulled && lever3.pulled && lever4.pulled)
        {
            portal.SetActive(true);
        }
	}
}
