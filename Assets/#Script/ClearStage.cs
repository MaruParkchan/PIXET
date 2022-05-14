using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearStage : MonoBehaviour {

    public void Awake()
    {
        Invoke("SceneChange", 4.0f);
        Debug.Log("승리 씬");
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Store");
        Debug.Log("상점 이동");
    }
	
}
