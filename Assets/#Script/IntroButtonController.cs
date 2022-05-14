using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroButtonController : MonoBehaviour {

    public GameObject howtoObject;
    public GameObject creditObject;

    public void btn_Start() // 게임 시작 버튼
    {
        SceneManager.LoadScene("Map");
    }

    public void btn_Howto() // 게임 방법 버튼
    {
        howtoObject.SetActive(true);
    }

    public void btn_Credit() // 만든 사람들 
    {
        creditObject.SetActive(true);
    }

    public void btn_Exit()
    {
        Application.Quit();
    }

    public void ObjectOff()
    {
        howtoObject.SetActive(false);
        creditObject.SetActive(false);
    }
}
