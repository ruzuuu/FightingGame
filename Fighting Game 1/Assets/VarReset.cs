using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VarReset : MonoBehaviour
{
    BattleManager battlemanager;
    GameSetting gamesetting;

    void Start() {

    }

    public void restart() {
        BattleManager.healthP1 = GameSetting.hpOpt;
        BattleManager.healthP2 = GameSetting.hpOpt;
        BattleManager.spc1Used = 0;
        BattleManager.spc2Used = 0;
        SceneManager.LoadScene("Scene 1");
    }

    public void end() {
        Application.Quit();
    }
}
