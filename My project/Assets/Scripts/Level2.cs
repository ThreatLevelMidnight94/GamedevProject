using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{   public PointText fscore;
    public HealthText fhealth;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hello");
        PlayerPrefs.SetInt("Player Score", fscore.score);
        PlayerPrefs.SetInt("Player Health",fhealth.Health);
        if(other.gameObject.tag == "Player")
        SceneManager.LoadScene("level2");
    }
}