using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {
    Animation anim;
    public bool pulled = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Action()
    {
        if (!anim.isPlaying)
        {
            if (!pulled)
            {
                anim["C4D Animation Take"].time = 0;
                anim["C4D Animation Take"].speed = 1;
                anim.Play();
                pulled = true;
            }
            else
            {
                anim["C4D Animation Take"].time = anim["C4D Animation Take"].length;
                anim["C4D Animation Take"].speed = -1;
                anim.Play();
                pulled = false;
            }
        }
    }
}
