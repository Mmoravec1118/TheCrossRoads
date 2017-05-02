using UnityEngine;
using System.Collections;


public class ScrollingText : MonoBehaviour
{
    public string[] intro = { "Thanks for playing!", "Designer, Engineer: Marty Moravec", "Music: Bob Carpenter" };
    public float off;
    public float speed = 100;
    public GameObject title;

    void Start()
    {
        // intro = { "Thanks for playing!", "Designer, Engineer: Marty Moravec", "Music: Bob Carpenter"};
        Invoke("FinalScreen", 20);
    }

    public void OnGUI()
    {
        off += Time.deltaTime * speed;
        for (int i = 0; i < intro.Length; i++)
        {
            float roff = (intro.Length * -20) + (i * 20 + off);
            float alph = Mathf.Sin((roff / Screen.height) * 180 * Mathf.Deg2Rad);
            GUI.color = new Color(1, 1, 1, alph);
            GUI.Label(new Rect(128, roff, Screen.width, 20), intro[i]);
            GUI.color = new Color(1, 1, 1, 1);
        }
    }

    public void FinalScreen()
    {
        title.SetActive(true);
    }
}