using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScienceDoor : MonoBehaviour {
    public Animation anim;
	// Use this for initialization
	void Action ()
    {
        anim.Play("open");
    }
}
