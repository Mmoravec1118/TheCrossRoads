using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour {

    Animator anim;

    public GameObject door;
	// Use this for initialization
	void Start () {
        anim = GetComponentInParent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("InventoryViewer").GetComponent<Inventory>().inventory.Count == 4)
        {
           door.gameObject.SetActive(true);
        }
    }

    public void Action()
    {
        anim.SetBool("open", true);
    }
}
