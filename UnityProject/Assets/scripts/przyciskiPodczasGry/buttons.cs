using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

	public Texture btnTxtExit;
	public Texture btnTxtSave;
	public Texture btnTxtToMenu;

	public GUISkin skin;

	void OnGUI() {
		
		if (!btnTxtExit && !btnTxtSave && !btnTxtToMenu)
		{
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}

		if (GUI.Button(new Rect(Screen.width - 70, 20, 50, 50), btnTxtExit, skin.GetStyle ("PrzyciskiWGrze")))
			Application.Quit ();
		
		if (GUI.Button (new Rect (Screen.width - 130, 20, 50, 50), btnTxtToMenu, skin.GetStyle ("PrzyciskiWGrze")))
			SceneManager.LoadScene("menuScene");

		if (GUI.Button (new Rect (Screen.width - 190, 20, 50, 50), btnTxtSave, skin.GetStyle ("PrzyciskiWGrze"))) {

			PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
			PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
			PlayerPrefs.SetFloat ("ZapisaneZdrowie", PlayerPrefs.GetFloat ("Zdrowie"));
			PlayerPrefs.SetInt ("Saved", 1);
			PlayerPrefs.Save ();
		}
	}
}
