using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipButton : MonoBehaviour {

    public StringText skipText;
    public float skipTimer = 0;

    public void btn_skipText()
    {
        skipText.saveTime = skipTimer;
    }

}
