using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class BattleManager : MonoBehaviour
{
    public GameSetting gamesetting;
    public GameObject hp1GO, hp2GO;
    public GameObject spc1btn, spc2btn;
    public static int spc1Used = 0, spc2Used = 0;
    public static int healthP1 = GameSetting.hpOpt, healthP2 = GameSetting.hpOpt;

    void Start() {
        Debug.Log("HP: " + GameSetting.hpOpt);
    }

    void Update() {
        if (spc1Used > 2) {
            Destroy(spc1btn.gameObject);
        }
        if (spc2Used > 2) {
            Destroy(spc2btn.gameObject);
        }
        hp1GO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = healthP1 + "";
        hp2GO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = healthP2 + "";
        if (BattleManager.healthP1 <= 0) {
            BattleManager.healthP1 = 0;
        }
        if (BattleManager.healthP2 <= 0) {
            BattleManager.healthP2 = 0;
        }
    }
    public void removebtn1() {
        Debug.Log("removed");
        spc1Used = 5;
        Destroy(spc1btn.gameObject);
    }

    public void removebtn2() {
        Debug.Log("removed");
        spc2Used = 5;
        Destroy(spc2btn.gameObject);
    }           

    void damCalcA(int hpNow1, int abdam1, int accuracy1, int x, int y) {
        int ran = Random.Range(0,101);
        if (ran <= accuracy1) {
            healthP2 = hpNow1 -= abdam1;
            SceneManager.LoadScene(x);
        }
        else {
            SceneManager.LoadScene(y);
        }
    }

    void damCalcB(int hpNow2, int abdam2, int accuracy2, int x, int y) {
        int ran = Random.Range(0,101);
        if (ran <= accuracy2) {
            healthP1 = hpNow2 -= abdam2;
            SceneManager.LoadScene(x);
        }
        else {
            SceneManager.LoadScene(y);
        }
    }

    public void P1LowPunch() {
        damCalcA(healthP2, 3, 75, 7, 8);
    }

    public void P1HighPunch() {
        damCalcA(healthP2, 8, 55, 9, 10);
    }

    public void P1LowKick() {
        damCalcA(healthP2, 6, 65, 3, 4);
    }

    public void P1HighKick() {
        damCalcA(healthP2, 12, 45, 5, 6);
    }

    public void P1Special() {
        damCalcA(healthP2, 25, 105, 11, 11);
    }

    public void P2LowPunch() {
        damCalcB(healthP1, 3, 75, 17, 18);
    }

    public void P2HighPunch() {
        damCalcB(healthP1, 8, 55, 19, 20);
    }

    public void P2LowKick() {
        damCalcB(healthP1, 6, 65, 13, 14);
    }

    public void P2HighKick() {
        damCalcB(healthP1, 12, 45, 15, 16);
    }

    public void P2Special() {
        damCalcB(healthP1, 25, 105, 12, 12);
    }
}
