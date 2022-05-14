using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StringText : MonoBehaviour {

    public Text test;

    public float timer = 0;
    public float saveTime = 0;
    public GameObject nextSceneButton;

    private string saveText =
        "현재 테스트중입니다.\n글자수 테스트 중입니다\n" +
         "현재 테스트중입니다.\n글자수 테스트 중입니다\n" +
         "현재 테스트중입니다.\n글자수 테스트 중입니다\n" +
         "현재 테스트중입니다.\n글자수 테스트 중입니다\n" +
         "현재 테스트중입니다.\n글자수 테스트 중입니다\n";



    private string viewText = "";
    private int index = 0;

    private void Awake()
    {
        viewText = "";
        saveTime = timer; // 시간을 입력해놓고 다시 초기화할때 변수하나 선언함.
    }

    private void Update()
    {
        ViewText();
    }

    public void ViewText() // 대화 차례대로 나오는 코드
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && index < saveText.Length)
        {
            viewText += saveText[index];
            test.text = viewText;
            index++;
            timer = saveTime;
        }
        
        if(index >= saveText.Length)
            nextSceneButton.SetActive(true);

    }

    public void btn_NextScene()
    {
        SceneManager.LoadScene("Map");
    }


}
