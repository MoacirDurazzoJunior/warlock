using UnityEngine;
using UnityEngine.UI;

public class Cronometer : MonoBehaviour {
	private float gameTime      = 0;
	private int   sign          = 1;
	public  bool  startFromZero = true;
	public  float startTime     = 121;
	public  Text  cron;


	public void Start() {
		if (!startFromZero) {
			sign     = -1;
			gameTime = startTime;
		}
	}


	public void Update () {
		gameTime        = gameTime + sign * Time.deltaTime;
		int minutes     = (int)(gameTime / 60);
		int seconds     = (int)(gameTime % 60);
		int miliseconds = (int)(gameTime * 100) % 100;
		cron.text       = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, miliseconds);
	}

}
