using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RectileController : MonoBehaviour
{

    public Sprite defaultimage;
    public Sprite interactImage;
    public float interactDistance;
    public Image Rectile;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(GetComponent<Camera>().transform.position, GetComponent<Camera>().transform.forward, out hit, interactDistance))
        {
            if (hit.transform.tag == "Interact")
            {
                Rectile.sprite = interactImage;
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.SendMessage("Action");
                }
            }
            else
            {
                Rectile.sprite = defaultimage;
            }
        }
        else
        {
            Rectile.sprite = defaultimage;
        }

    }
}
