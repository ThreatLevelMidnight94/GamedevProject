using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuHandler : MonoBehaviour
{
     public void PlayGame(){
        SceneManager.LoadScene("Main");
    } 

    public void QuitGame(){
        Debug.Log("QUIT");
        Application.Quit();
    }
}
