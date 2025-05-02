using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartManager : MonoBehaviour {

	public GameObject startPanel;
	public GameObject levelPanel;
	public GameObject settingsPanel;
	public GameObject guidePanel;
	public GameObject creditPanel;
	public GameObject Quit;
    

    // Use this for initialization
    void Start () {

        if (SceneState.tunjukkanMenu == "Menu")
        {
            Home();
        }
        else if (SceneState.tunjukkanMenu == "Level")
        {
            PlayGame();
        }
    }
  

    public void PlayGame ()
	{
        startPanel.SetActive(false);
		levelPanel.SetActive(true);
        settingsPanel.SetActive(false);
        guidePanel.SetActive(false);
        creditPanel.SetActive(false);
    }

	public void Home ()
	{
		startPanel.SetActive(true);
		levelPanel.SetActive(false);
        settingsPanel.SetActive(false);
        guidePanel.SetActive(false);
        creditPanel.SetActive(false);
       
        
    }

	public void Settings ()
	{
        startPanel.SetActive(false);
        levelPanel.SetActive(false);
        settingsPanel.SetActive(true);
        guidePanel.SetActive(false);
        creditPanel.SetActive(false);
    }

	public void Guide ()
	{
        startPanel.SetActive(false);
        levelPanel.SetActive(false);
        settingsPanel.SetActive(false);
        guidePanel.SetActive(true);
        creditPanel.SetActive(false);
    }

	public void Credit ()
	{
        startPanel.SetActive(false);
        levelPanel.SetActive(false);
        settingsPanel.SetActive(false);
        guidePanel.SetActive(false);
        creditPanel.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
