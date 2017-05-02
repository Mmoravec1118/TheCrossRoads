using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
        if (GameObject.FindGameObjectWithTag("InventoryViewer").GetComponent<Inventory>().inventory.Count == 4)
        {
            gameObject.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Action()
    {
        anim.SetBool("open", true);
    }
}
