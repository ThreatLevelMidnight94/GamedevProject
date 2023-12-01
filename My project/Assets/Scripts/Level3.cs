using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
     public PointText fscore;
    public HealthText fhealth;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        PlayerPrefs.SetInt("Player Score", fscore.score);
        PlayerPrefs.SetInt("Player Health",fhealth.Health);
        if(other.gameObject.tag == "Player")
        SceneManager.LoadScene("level3");
    }
}
