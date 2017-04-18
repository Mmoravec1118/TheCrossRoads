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
    private void Start()
    {
        uIBit = GameObject.FindGameObjectWithTag("UiBit");
    }
    void Action()
    {
        GameObject.FindGameObjectWithTag("InventoryViewer").GetComponent<Inventory>().inventory.Add(this);
        Destroy(gameObject);
        uIBit.GetComponent<RectTransform>().sizeDelta = uIImage.rect.size;
        uIBit.GetComponent<Image>().sprite = uIImage;
        uIBit.GetComponent<UIPickup>().text.text = pickUpText;
        uIBit.GetComponent<UIPickup>().OnEnable();
    }
}
