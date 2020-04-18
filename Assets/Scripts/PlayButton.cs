using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

	public void PlayGame()
	{
		// -- To test if the button reacts to being pressed
		// Debug.Log("Play Game was pressed");

		// -- Switch scene
		SceneManager.LoadScene("Game");
	}
}
