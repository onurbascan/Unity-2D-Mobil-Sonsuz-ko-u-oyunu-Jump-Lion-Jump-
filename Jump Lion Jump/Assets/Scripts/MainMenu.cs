using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string PlayGameLevel;
    public GameObject karatersecpanel;


	public void PlayGame()
    {
        Application.LoadLevel(PlayGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void KaraterMenuAc()
    {
        karatersecpanel.SetActive(true);
    }
    public void Start()
    {
        karatersecpanel.SetActive(false);
    }
    public void KarakterMenuKapat()
    {
        karatersecpanel.SetActive(false);
    }

}
