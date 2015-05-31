using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public  GameObject jogador;
	public  GameObject menu;
	public  GameObject howToPlay;
	private bool       pause;
	private float      originalFixedDeltaTime;


	public void Start () {
		menu.SetActive(false);
		howToPlay.SetActive(false);

		pause                  = false;
		originalFixedDeltaTime = Time.fixedDeltaTime;
	}


	public void Update() {
		if (Input.GetKeyDown(KeyCode.P)) {
			pause = !pause;
			if (pause) 
				PauseGame();
			else
				UnPauseGame();
		}
	}


	public void NewGame() {
		Time.timeScale      = 1;
		Time.fixedDeltaTime = originalFixedDeltaTime;

		Application.LoadLevel(0);
	}


	public void PauseGame() {
		if (!pause) pause = true;

		menu.SetActive(true);

		Time.timeScale      = 0;
		Time.fixedDeltaTime = 0;

		jogador.GetComponent<ThirdPersonCharacter>().enabled   = false;
		jogador.GetComponent<ThirdPersonUserControl>().enabled = false;

		// Pause the other objects and the Music
		jogador.GetComponent<RPGLifeBar>().enabled           = false;
		jogador.GetComponent<StreetFighterLifeBar>().enabled = false;
		jogador.GetComponent<ZeldaLifeBar>().enabled         = false;
	}


	public void UnPauseGame() {
		if (pause) pause = false;

		menu.SetActive(false);
		howToPlay.SetActive(false);

		Time.timeScale      = 1;
		Time.fixedDeltaTime = originalFixedDeltaTime;
		
		jogador.GetComponent<ThirdPersonCharacter>().enabled   = true;
		jogador.GetComponent<ThirdPersonUserControl>().enabled = true;

		// UnPause the other objects and the Music
		jogador.GetComponent<RPGLifeBar>().enabled           = true;
		jogador.GetComponent<StreetFighterLifeBar>().enabled = true;
		jogador.GetComponent<ZeldaLifeBar>().enabled         = true;
	}

	public void ShowHowToPlay() {
		if (!howToPlay.activeInHierarchy)
			howToPlay.SetActive(true);
		else
			howToPlay.SetActive(false);
	}

	public void QuitGame() {
		Application.Quit();
	}
}
