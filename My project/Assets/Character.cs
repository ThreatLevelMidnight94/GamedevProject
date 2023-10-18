using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
        public string team;
        [SerializeField] int hitpoints = 5;
        

        public void Damage(int hitP){
            hitpoints -= hitP;
            HealthText.instance.SubPoint(hitpoints);
            if(hitpoints < 1){
                Die();
            }
        }
         public void Recover(int hitP){
            hitpoints += hitP;
            HealthText.instance.AddPoint(hitpoints);
           
        }
        void Die(){
            SceneManager.LoadScene("Menu");
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
