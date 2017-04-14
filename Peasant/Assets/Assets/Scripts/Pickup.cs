using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Pickup : MonoBehaviour
{
    public GameObject uIBit;
    public string pickUpText;
    public Sprite uIImage;
    // Use this for initialization

    void Action()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().inventory.Add(this);
        Destroy(gameObject);
        uIBit.SetActive(true);
        uIBit.GetComponent<RectTransform>().sizeDelta = uIImage.rect.size;
        uIBit.GetComponent<Image>().sprite = uIImage;
        uIBit.GetComponent<UIPickup>().text.text = pickUpText;
    }
}
