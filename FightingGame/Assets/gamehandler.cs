using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gamehandler : MonoBehaviour
{public static int gameHealth=100;  
    public TMP_InputField p1Input;
    public TMP_InputField p2Input;
    public static string p1name;
    public static string p2name;
    
    void Start()
    {
        
    }

    
    void Update()
    {

    }

    public void setHealth50(){
        gameHealth=50;
    }
    public void setHealth100(){
        gameHealth=100;
    }
    public void setHealth150(){
        gameHealth=150;
    }
    public void setHealth200(){
        gameHealth=200;
    }

    public void setp1name(){
        p1name =  p1Input.GetComponent<TMP_InputField>().text.ToString();
    }

    public void setp2name(){
        p2name =  p2Input.GetComponent<TMP_InputField>().text.ToString();
    }

    public void Scene3() {  
        setp1name();
        setp2name();
        SceneManager.LoadScene("Scene 3"); 
    }  
}

