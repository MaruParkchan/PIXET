using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapController : MonoBehaviour {

    private string scene = "Stage";

    public Transform[] point;
    public GameObject[] clearImage;
    public GameObject lightObject;

    private void Awake()
    {
        StartCoroutine(SceneChange());

        lightPoint();
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(2.0f);
        SceneMove();
    }

    public void SceneMove()
    {
        scene += DataController.instance.mapNum;
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }

    public void lightPoint()
    {
        if (DataController.instance.mapNum == 1)
        {
            lightObject.transform.position = point[0].position;
            clearImage[0].SetActive(false);
            clearImage[1].SetActive(false);
            clearImage[2].SetActive(false);
        }

        if (DataController.instance.mapNum == 2)
        {
            lightObject.transform.position = point[1].position;
            clearImage[0].SetActive(true);
        }

        if (DataController.instance.mapNum == 3)
        {
            lightObject.transform.position = point[2].position;
            clearImage[0].SetActive(true);
            clearImage[1].SetActive(true);
        }

        if (DataController.instance.mapNum == 4)
        {
            lightObject.transform.position = point[3].position;
            clearImage[0].SetActive(true);
            clearImage[1].SetActive(true);
            clearImage[2].SetActive(true);
        }

    }
}
