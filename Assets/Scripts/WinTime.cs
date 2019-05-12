using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class WinTime : MonoBehaviour {

    public Text winTimeText;

    private static float finalTime;

    // Use this for initialization
    void Start () {
        finalTime = FirstPersonController.currentTime - 10f;
        string minutes = ((int)finalTime / 60).ToString("00.##");
        string seconds = (finalTime % 60).ToString("00");
        winTimeText.text = "Time Left: " + minutes + ":" + seconds;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
