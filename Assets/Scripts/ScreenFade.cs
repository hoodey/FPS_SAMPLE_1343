using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    [SerializeField] Color startingColor;
    [SerializeField] Color targetColor;
    [SerializeField] Image fadeImage;
    [SerializeField] float fadeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fade()
    {
        fadeImage.color = startingColor;
        StartCoroutine(DamageFade());
    }

    IEnumerator DamageFade()
    {
        for (float i = 1.0f; i >= 0.1f; i -= 0.01f)
        {
            var currentColor = fadeImage.color;
            currentColor = Color.Lerp(currentColor, targetColor, fadeSpeed * Time.deltaTime);
            fadeImage.color = currentColor;
            yield return new WaitForSeconds(.05f);
        }
        fadeImage.color = targetColor; 
    }
}
