using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour {


    public float timer = 8;

    public GameObject clone;
    public float obejctNumber = 4;
    // Use this for initialization
    void Start () {
        clone.SetActive(false);
        Invoke("SceneChange", timer);
        Invoke("ObjectOn", obejctNumber);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SceneChange()
    {
        SceneManager.LoadScene("Ending");
    }

    public void ObjectOn()
    {
        clone.SetActive(true);
    }

}
