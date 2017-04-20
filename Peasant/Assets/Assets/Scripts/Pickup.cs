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
        DontDestroyOnLoad(this);
    }
    void Action()
    {
        GameObject.FindGameObjectWithTag("InventoryViewer").GetComponent<Inventory>().inventory.Add(this);
        foreach (Component item in gameObject.GetComponents<Component>())
        {
            if (item != transform && item != this)
            {
                Destroy(item);
            }
        }
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        uIBit.GetComponent<RectTransform>().sizeDelta = uIImage.rect.size;
        uIBit.GetComponent<Image>().sprite = uIImage;
        GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().text = pickUpText;
        uIBit.GetComponent<UIPickup>().OnEnable();
    }
}
