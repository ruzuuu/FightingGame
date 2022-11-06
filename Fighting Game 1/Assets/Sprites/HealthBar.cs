using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    GameSetting gamesetting;
    BattleManager battlemanager;
    private static float MaxHealth = (float)GameSetting.hpOpt;
    public static float health1 = (float)BattleManager.healthP1;
    private Image healthbar;
    public Gradient gradient;
    void Start()
    {
        healthbar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        health1 = BattleManager.healthP1;
        healthbar.fillAmount = health1/MaxHealth;

        healthbar.color=gradient.Evaluate(healthbar.fillAmount);
    }
}
