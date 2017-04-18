using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{

    Image image;
    float fadeSpeed = 0.4f;
    float fadeLength = 2;
    bool fade = false;
    private float alpha = 0.0f;
    private float fadeDir = -1f;
    float timer;
    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        SceneManager.sceneLoaded += FadeOut;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeOut(Scene scene, LoadSceneMode load)
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
    }
}
