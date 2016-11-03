using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	bool paused = false;

	void Update()
	{
		if(Input.GetKeyDown("w"))
			paused = togglePause();
	}

	void OnGUI()
	{
		if(paused)
		{
			GUILayout.Label ("Jogo Pausado");

			if(GUILayout.Button("Voltar ao Jogo"))
				paused = togglePause();
		}
	}

	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}