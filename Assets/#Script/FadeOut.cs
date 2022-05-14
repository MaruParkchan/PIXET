using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour {

    public Image fadeImage = null;
    public GameObject fadeObject = null;
    private float alphaNum = 0;
    public bool isFade = false;

    private void Awake()
    {
        alphaNum = 0;
    }

    private void Update()
    {
        Debug.Log(alphaNum);
        if(isFade != false)
           isFadeOn();

        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, alphaNum/255f);
    }

    public void isFadeOn()
    {
        if (alphaNum < 255f)
            alphaNum += Time.deltaTime * 200f;
        else
            SceneManager.LoadScene("ClearStage" + DataController.instance.mapNum);
    }

    public void IsFade()
    {
        isFade = true;
        fadeObject.SetActive(true);
    }
}
