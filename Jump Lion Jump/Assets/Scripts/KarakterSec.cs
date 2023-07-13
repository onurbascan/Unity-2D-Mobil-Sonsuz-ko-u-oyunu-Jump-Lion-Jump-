using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterSec : MonoBehaviour
{

    public GameObject tikaslan;
    public GameObject tikufo;
    public GameObject tiksilahsor;


    public void aslanisec()
    {
        PlayerPrefs.SetInt("karakterSec", 0);//ASLAN
    }
    public void ufoyusec()
    {
        PlayerPrefs.SetInt("karakterSec", 1);//UFO
    }
    public void silahsorsec()
    {
        PlayerPrefs.SetInt("karakterSec", 2);//SİLAHSOR

    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("karakterSec")==0)
        {
            tikaslan.SetActive(true);
            tikufo.SetActive(false);
            tiksilahsor.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("karakterSec")==1)
        {
            tikaslan.SetActive(false);
            tikufo.SetActive(true);
            tiksilahsor.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("karakterSec") == 2)
        {
            tikaslan.SetActive(false);
            tikufo.SetActive(false);
            tiksilahsor.SetActive(true);
        }
    }
}
