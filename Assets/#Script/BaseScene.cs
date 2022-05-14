using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseScene : MonoBehaviour {

    public float timer = 0;

    private float indexTimer = 0;
    public GameObject[] textObject;
    private int index = 0;
    private void Awake()
    {
        indexTimer = 0;
        Invoke("introScene", timer);
    }

    private void Update()
    {
        indexTimer += Time.deltaTime;
        ObjectOn();
    }
    public void introScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ObjectOn()
    {
        if (indexTimer >= 15)
        {
            textObject[0].SetActive(false);
            textObject[1].SetActive(false);
            textObject[2].SetActive(false);
            textObject[3].SetActive(true);
        }
        else if(indexTimer >= 10)
        {
             textObject[0].SetActive(false);
             textObject[1].SetActive(false);
             textObject[2].SetActive(true);
             textObject[3].SetActive(false);
        }
        else if (indexTimer >= 5)
        {
            textObject[0].SetActive(false);
            textObject[1].SetActive(true);
            textObject[2].SetActive(false);
            textObject[3].SetActive(false);
        }
        else if (indexTimer >= 0)
        {
            textObject[0].SetActive(true);
            textObject[1].SetActive(false);
            textObject[2].SetActive(false);
            textObject[3].SetActive(false);
        }
    }
}
