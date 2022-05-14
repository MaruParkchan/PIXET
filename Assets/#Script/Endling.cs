using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endling : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("ChangeIntro", 15.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeIntro()
    {
        SceneManager.LoadScene("Intro");
    }
}
