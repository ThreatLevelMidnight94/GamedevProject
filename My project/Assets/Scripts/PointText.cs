using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointText : MonoBehaviour
{
     public Text Pointtext;
    public int score = 0;
    public static PointText instance;

    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
      Pointtext.text = "Score: " + score.ToString();
    }

  public void AddPoint(){
    score += 1;
    Pointtext.text = "Score: " + score.ToString();
  }
  public void AddPoints(){
    score += 10;
    Pointtext.text = "Score: " + score.ToString();
  }

}
