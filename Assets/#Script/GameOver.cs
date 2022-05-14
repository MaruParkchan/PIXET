using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text playTime = null;

    private void Awake()
    {
        PlayTime();
        ResetNum();
    }

    public void ResetNum()
    {
        Weapon.fireRate = 0.1f;
        StoreController.powerLevel = 1;
        StoreController.FireRateLevel = 1;
        StoreController.shieldLevel = 1;
        DataController.instance.score = 0;
        DataController.instance.money = 0;
        DataController.instance.mapNum = 1;
        DataController.instance.damage = 10;
        DataController.instance.playerMaxHp = 10;
        DataController.instance.currentHp = 10;
    }

    public void PlayTime()
    {
        playTime.text = string.Format("{0}{1:D2}{2}{3:D2}", "PlayTime ", (int)DataController.instance.timer / 60, ":", (int)DataController.instance.timer % 60);
    }

    public void IntroBack()
    {
        SceneManager.LoadScene("Intro");
    }
}
