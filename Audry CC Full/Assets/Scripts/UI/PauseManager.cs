using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

	public GameObject pausePanel;
	private Board board;
    private int level;
    public bool paused = false;

	// Use this for initialization
	void Start () {
		pausePanel.SetActive(false);
		board = GameObject.FindWithTag("Board").GetComponent<Board>();
        level = board.level + 1;
    }
	
	// Update is called once per frame
	void Update () {
		if (paused && !pausePanel.activeInHierarchy)
		{
			pausePanel.SetActive(true);
			board.currentState = GameState.pause;
		}
		
	}

	public void PauseGame()
	{
		paused = !paused;
	}

	public void QuitGame()
	{
        SceneState.tunjukkanMenu = "Level"; 
		SceneManager.LoadScene("Splash");
	}

	public void ContinueGame()
	{
		pausePanel.SetActive(false);
		board.currentState = GameState.move;
		paused = !paused;
	}

    public void Retry()
    {
        SceneManager.LoadScene(level);
    }
}
