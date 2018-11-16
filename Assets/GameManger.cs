using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {

	public void OnStartGame(string ScneneName){
		SceneManager.LoadScene (ScneneName);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
