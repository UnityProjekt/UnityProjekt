using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text theText;

    public void doLoad()
	{
		SceneManager.LoadScene("mainScene");

		PlayerPrefs.SetInt ("Saved", 1);
		PlayerPrefs.SetInt ("Zaladuj", 1);
		PlayerPrefs.Save ();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = Color.black;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = Color.white;
    }
}
