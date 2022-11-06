using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetName : MonoBehaviour
{
    public GameSetting gamesetting;
    public TextMeshProUGUI playname1, playname2;

    void Start()
    {
        Debug.Log(GameSetting.name1 + ", " + GameSetting.name2);
        playname1.text = GameSetting.name1;
        playname2.text = GameSetting.name2;
    }
}
