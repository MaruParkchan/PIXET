using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAttack : MonoBehaviour {

    public GameObject ClearClone;

    public Text timeText;
    public bool isClear = false;

    public float timer = 0;

    private void Awake()
    {
        timer = 30;
    }
    void Update ()
    {
        ClearStage();
        timeText.text = string.Format("{0}",(int)timer % 60);
    }

    public void ClearStage()
    {

        if (timer > 0)
            timer -= Time.deltaTime;
        else
        {
            timer = 0;
            ClearClone.SetActive(true);
        }
    }

   
}
