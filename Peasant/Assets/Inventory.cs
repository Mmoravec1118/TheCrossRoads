using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour {

    public GameObject inventoryPanel;

    bool inventoryOpen = false;

    private PlayerController player;
    [SerializeField]
    GameObject Rectile, InvPanel;

    int xpos = -300;

   public List<Pickup> inventory;
    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        inventory = new List<Pickup>();

    }

    // Update is called once per frame
    void Update () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        if (Input.GetKeyDown(KeyCode.I) && !inventoryOpen)
        {
            Rectile.SetActive(false);
            player.m_MouseLook.SetCursorLock(false);
            player.canMove = false;
            Time.timeScale = 0;
            inventoryPanel.SetActive(true);
            inventoryOpen = true;

            foreach (Pickup item in inventory)
            {
                Vector3 pos = new Vector3(xpos, 0, 0);
                GameObject obj = Instantiate(Resources.Load("InvItem"), InvPanel.transform) as GameObject;
                obj.GetComponent<RectTransform>().localPosition = pos;
                obj.GetComponent<Image>().sprite = item.uIImage;
                xpos += (int)obj.GetComponent<RectTransform>().rect.width + 25;
            }
        }

        else if (Input.GetKeyDown(KeyCode.I) && inventoryOpen)
            {
            Rectile.SetActive(true);
            player.m_MouseLook.SetCursorLock(true);
            player.canMove = true;
            Time.timeScale = 1;
            inventoryPanel.SetActive(false);
            inventoryOpen = false;
            xpos = -300;
            foreach (RectTransform item in InvPanel.GetComponentInChildren<RectTransform>())
            {
                Destroy(item.gameObject);
            }
        }
    }
}
