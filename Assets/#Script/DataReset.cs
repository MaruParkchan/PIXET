using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataReset : MonoBehaviour {

    private void Awake()
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
        DataController.instance.timer = 0;
    }
}
