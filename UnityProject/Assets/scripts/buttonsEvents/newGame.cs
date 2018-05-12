using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newGame : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text theText;

    public void doNewGame()
    {
		SceneManager.LoadScene("mainScene");

		PlayerPrefs.SetInt ("Saved", 0);
		PlayerPrefs.SetInt ("Zaladuj", 0);
		PlayerPrefs.SetInt ("Zdrowie", 100);
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
