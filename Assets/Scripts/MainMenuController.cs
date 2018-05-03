using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadHistory()
    {
        Debug.Log("Loading History...");
    }

    public void LoadSurvival()
    {
        Debug.Log("Loading Survival...");
    }

    public void ShowSettings()
    {
        Debug.Log("Showing Settings...");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
