using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreController : MonoBehaviour {

    public Text moneyText = null;
    public Text powerText = null;
    public Text fireRateText = null;
    public Text trainShieldText = null;

    public int money = 0;
 //   private int mapNum = 0;

    public int powerMoney = 0;
    public int fireRateMoney = 0;
    public int playerMaxHpMoney = 0;


    public Text[] levelText = null;  // 0 -> power / 1 -> FireRate / 2-> TrainSheield
    static public int powerLevel = 1;
    static public int FireRateLevel = 1;
    static public int shieldLevel = 1;

    private void Awake()
    {
     //   money = DataController.instance.money;
    }

    private void Update()
    {
        MoneyView();
        levelUpdate();
        UpdatedItemStat();
    }

    public void MoneyView()
    {
        moneyText.text = "" + DataController.instance.money;
        powerText.text = "" + powerMoney;
        fireRateText.text = "" + fireRateMoney;
        trainShieldText.text = "" + playerMaxHpMoney;
    }

    public void levelUpdate()
    {
        if (powerLevel >= 5)
            levelText[0].text = "Lv " + powerLevel + "\n  MAX";
        else
            levelText[0].text = "Lv " + powerLevel;

        if (FireRateLevel >= 5)
            levelText[1].text = "Lv " + FireRateLevel + "\n  MAX";
        else
            levelText[1].text = "Lv " + FireRateLevel;

        if (shieldLevel >= 5)
            levelText[2].text = "Lv " + shieldLevel + "\n  MAX";
        else
            levelText[2].text = "Lv " + shieldLevel;
    }

    public void PowerItemBuy()
    {
        if (powerLevel >= 5)
            return;

        if (DataController.instance.money > powerMoney)
        {
            DataController.instance.money -= powerMoney;
            if (powerLevel == 1)
                powerMoney += 500;
            else
                powerMoney += 1000;

            powerLevel++;
        }
    }

    public void FireRateItemBuy()
    {
        if (FireRateLevel >= 5)
            return;

        if (DataController.instance.money > fireRateMoney)
        {
            DataController.instance.money -= fireRateMoney;
            if (FireRateLevel == 1)
                fireRateMoney += 500;
            else
                fireRateMoney += 1000;

            FireRateLevel++;
        }
    }

    public void TrainShieldItemBuy()
    {
        if (shieldLevel >= 5)
            return;

        if (DataController.instance.money > playerMaxHpMoney)
        {
            DataController.instance.money -= playerMaxHpMoney;

            if (shieldLevel == 1)
                playerMaxHpMoney += 500;
            else
               playerMaxHpMoney += 1000;

            shieldLevel++;
        }
    }

    public void NextScene()
    {
        DataController.instance.mapNum++;
        SceneManager.LoadScene("Map");
    }

    public void UpdatedItemStat()
    {
        switch (powerLevel)
        {
            case 1:
                DataController.instance.damage = 10;
                break;

            case 2:
                DataController.instance.damage = 15;
                break;

            case 3:
                DataController.instance.damage = 20;
                break;

            case 4:
                DataController.instance.damage = 25;
                break;

            case 5:
                DataController.instance.damage = 30;
                break;
        }

        switch (FireRateLevel)
        {
            case 1:
                Weapon.fireRate = 0.1f;
                break;

            case 2:
                Weapon.fireRate = 0.06f;
                break;

            case 3:
                Weapon.fireRate = 0.04f;
                break;

            case 4:
                Weapon.fireRate = 0.02f;
                break;

            case 5:
                Weapon.fireRate = 0.01f;
                break;
        }

        switch (shieldLevel)
        {
            case 1:
                DataController.instance.playerMaxHp = 10;
                break;

            case 2:
                DataController.instance.playerMaxHp = 20;
                break;

            case 3:
                DataController.instance.playerMaxHp = 30;
                break;

            case 4:
                DataController.instance.playerMaxHp = 40;
                break;

            case 5:
                DataController.instance.playerMaxHp = 50;
                break;
        }
    }


}
