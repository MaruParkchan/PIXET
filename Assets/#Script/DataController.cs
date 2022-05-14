using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour {

    public static DataController instance = null;

    public int score = 0; // 점수
    public float timer = 0; // 플레이시간
    public int money = 0;  // 돈
    public int mapNum = 1;  // 맵 위치
    public int damage;
    public int playerMaxHp = 20;
    public int currentHp = 20;

    void Awake()
    {
        damage = 10;
        mapNum = 1;

        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

}