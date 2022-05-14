using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text moneyText = null;
    public Text scoreText = null;
    public Text timerText = null;
    public Slider playerHpbar = null;

    private void Awake()
    {
        DataController.instance.currentHp = DataController.instance.playerMaxHp;
        playerHpbar.maxValue = DataController.instance.playerMaxHp;
        playerHpbar.value = DataController.instance.playerMaxHp;

        Debug.Log(DataController.instance.playerMaxHp);
    }

    private void Update()
    {
        TimerMethod(); // 시간
        ScoreUpdate(); // 점수 
        MoneyUpdate(); // 돈
        PlayerHp(); // player 체력바
    }

    public void TimerMethod()
    {
        DataController.instance.timer += Time.deltaTime;
        timerText.text = string.Format("{0}{1:D2}{2}{3:D2}", "PlayTime ", (int)DataController.instance.timer / 60, ":", (int)DataController.instance.timer % 60);
    }

    public void ScoreUpdate()
    {
        scoreText.text = "Score : " + DataController.instance.score;
    }

    public void MoneyUpdate()
    {
        moneyText.text = "= " + DataController.instance.money;
    }

    public void PlayerHp()
    {
        playerHpbar.value = DataController.instance.currentHp;
    }

}
