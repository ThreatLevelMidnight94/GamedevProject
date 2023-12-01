using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultPoints : MonoBehaviour
{
        
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
        PlayerPrefs.SetInt("Player Score", 0);
        PlayerPrefs.SetInt("Player Health", 6);
    }

}
