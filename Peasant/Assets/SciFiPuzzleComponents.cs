using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciFiPuzzleComponents : MonoBehaviour {
    [SerializeField]
    scificontroller controller;
	// Use this for initialization
	void Action()
    {
        GetComponent<Light>().enabled = true;
        controller.checkCorrectOrder(gameObject);
    }

}
