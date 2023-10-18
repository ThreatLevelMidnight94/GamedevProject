using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthText : MonoBehaviour
{
    public Text Healthtext;
    public int Health = 5;
    public static HealthText instance;

    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
      Healthtext.text = "Health: " + Health.ToString();
    }
        public void AddPoint(int hp){
        
        Healthtext.text = "Health: " + hp.ToString();
        }
        public void SubPoint(int hp){
       /* if(Health == 0){
            SceneManager.LoadScene("Menu");
        }*/
        
        Healthtext.text = "Health: " + hp.ToString();
        }
 
}
