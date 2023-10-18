using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fader : MonoBehaviour
{
        [SerializeField] Image fadeImage;
        [SerializeField] Color fadeColor = Color.black;
        [SerializeField] float fadeTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Fadein();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Fadein(){
        StartCoroutine(FadeInRoutine());
        IEnumerator FadeInRoutine(){
            float timer = 0;
            while( timer < fadeTime){
                fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b,1f-(timer/fadeTime));
                timer+=Time.deltaTime;
                
                yield return null;
            }
            fadeImage.color = Color.clear;
            yield return null;
        }
    }

    public void Fadeout(string name){
        StartCoroutine(FadeoutRoutine());
        IEnumerator FadeoutRoutine(){
            float timer = 0f;
            while( timer < fadeTime){
                fadeImage.color = new Color(fadeColor.r,fadeColor.g,fadeColor.b,(timer/fadeTime));
                timer+=Time.deltaTime;
                
                yield return null;
            }
            fadeImage.color = fadeColor;
            yield return null;
            SceneManager.LoadScene(name);
        }
    }
}
