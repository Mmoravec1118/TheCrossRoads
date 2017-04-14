using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithNavigation : MonoBehaviour {
    NavMeshAgent nav;
    public Transform target;
    AudioSource sound;
    float timer = 0;
	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        sound = GetComponent<AudioSource>();
        nav.destination = target.position;
	}

    // Update is called once per frame
    void Update()
    {
     //   Debug.Log(Vector3.Distance(transform.position, target.position));
        timer -= Time.fixedDeltaTime;
        nav.destination = target.position;
        if (Vector3.Distance(transform.position, target.position) < 10)
        {
            sound.Play();
            target.SendMessage("Die");
        }
        else if (Vector3.Distance(transform.position, target.position) < 150 && !sound.isPlaying)
        {
            if (timer <= 0)
            {
                sound.Play();
                timer = 30;
            }
        }

    }
}
