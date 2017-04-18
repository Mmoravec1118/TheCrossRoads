using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Fade : MonoBehaviour {

    public Image image;
    float fadeSpeed = 0.4f;
    float fadeLength = 2;
    bool fade = false;
    private float alpha = 0.0f;
    private float fadeDir = 1f;
    float timer;
    public string sceneToLoad;
    void Action()
    {
        StartCoroutine("FadeOut");
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
    }

    IEnumerator FadeOut()
    {
        while (timer < fadeLength / fadeSpeed)
        {
            timer += Time.deltaTime;
            alpha += fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);

            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
            yield return null;
        }
        SceneManager.LoadScene(sceneToLoad);
    }
}
