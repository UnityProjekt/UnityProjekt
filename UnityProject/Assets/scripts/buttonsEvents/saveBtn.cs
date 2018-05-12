using UnityEngine;
using System.Collections;

public class saveBtn : MonoBehaviour {

	public void Save() {

		PlayerPrefs.SetFloat ("PlayerX", transform.position.x);
		PlayerPrefs.SetFloat ("PlayerY", transform.position.y);
		PlayerPrefs.SetFloat ("ZapisaneZdrowie", PlayerPrefs.GetFloat ("Zdrowie"));
		PlayerPrefs.SetInt ("Saved", 1);
		PlayerPrefs.Save ();
	}
}