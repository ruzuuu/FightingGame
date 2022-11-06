using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReaperCheck : MonoBehaviour
{
    public BattleManager battlemanager;
    void Start() {
        if (BattleManager.healthP1 <= 0) {
            BattleManager.healthP1 = 0;
            SceneManager.LoadScene(22);
        }
        if (BattleManager.healthP2 <= 0) {
            BattleManager.healthP2 = 0;
            SceneManager.LoadScene(21);
        }
    }
}
