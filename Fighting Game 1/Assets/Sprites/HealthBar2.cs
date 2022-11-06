using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    GameSetting gamesetting;
    BattleManager battlemanager;
    private static float MaxHealth2 = (float)GameSetting.hpOpt;
    public static float health2 = (float)BattleManager.healthP2;
    private Image healthbar2;
    public Gradient gradient2;
    void Start()
    {
        healthbar2 = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        health2 = BattleManager.healthP2;
        healthbar2.fillAmount = health2/MaxHealth2;

        healthbar2.color=gradient2.Evaluate(healthbar2.fillAmount);
    }
}