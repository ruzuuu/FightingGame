using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSetting : MonoBehaviour
{
    static int butSet = 0;
    public static int hpOpt = 100;
    public Button btn1, btn2, btn3, btn4;
    public TMP_InputField nameIn1, nameIn2;
    public static string name1, name2;

    void Start()
    {
        
    }

    void Update()
    {
        switch (butSet) {
            case 1: {
                btn1.interactable = false;
                btn2.interactable = true;
                btn3.interactable = true;
                btn4.interactable = true;
                break;
            }
            case 2: {
                btn1.interactable = true;
                btn2.interactable = false;
                btn3.interactable = true;
                btn4.interactable = true;
                break;
            }
            case 3: {
                btn1.interactable = true;
                btn2.interactable = true;
                btn3.interactable = false;
                btn4.interactable = true;
                break;
            }
            case 4: {
                btn1.interactable = true;
                btn2.interactable = true;
                btn3.interactable = true;
                btn4.interactable = false;
                break;
            }
        }
    }
    
    public void HP50() {
        hpOpt = 50;
        butSet = 1;
        Debug.Log("HP set.");
    }

    public void HP100() {
        hpOpt = 100;
        butSet = 2;
        Debug.Log("HP set.");
    }
    
    public void HP150() {
        hpOpt = 150;
        butSet = 3;
        Debug.Log("HP set.");
    }

    public void HP200() {
        hpOpt = 200;
        butSet = 4;
        Debug.Log("HP set.");
    }

    public void setname() {
        name1 = nameIn1.text;
        name2 = nameIn2.text;
        Debug.Log("P1 name is " + name1);
        Debug.Log("P2 name is " + name2);
    }

    public void Entry() {
        SceneManager.LoadScene("Scene 2");
    }

    public void Back() {
        SceneManager.LoadScene("Scene 1");
    }

    public void Strt() {
        setname();
        SceneManager.LoadScene(2);
    }

}
