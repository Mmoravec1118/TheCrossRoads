using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scificontroller : MonoBehaviour {
    [SerializeField]
    GameObject Tube1, Tube2, Tube3, Tube4, Tube5, Tube6, Tube7, Portal;

    GameObject[] correctOrder;
    
    int curr;
    // Use this for initialization
    void Start () {
        curr = 0;
        correctOrder = new GameObject[] { Tube1, Tube2, Tube3, Tube4, Tube5, Tube6, Tube7 };
	}
	
	public void checkCorrectOrder(GameObject tube)
    {
        if (correctOrder[curr] == tube)
        {
            curr++;
            if (curr == 7)
            {
                Portal.SetActive(true);
            }
        }
        else
        {
            curr = 0;
            foreach (GameObject o in correctOrder)
            {
                o.GetComponent<Light>().enabled = false;
            }
        }
    }
}
