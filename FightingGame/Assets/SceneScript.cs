using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void Scene1() {  
        SceneManager.LoadScene("Scene 2"); 
    }  
    public void Scene2() {  
        SceneManager.LoadScene("Scene 1"); 
    }  
}
