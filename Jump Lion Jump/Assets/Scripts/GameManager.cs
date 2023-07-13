using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerController thePlayer;
    public PlayerController thePlayer2;
    public PlayerController thePlayer3;

    private Vector3 playerStartPoint;

    private PlatformDestroyer[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu theDeathScreen;

    public PowerupManager powerupManagerScript;

    

    public bool powerupReset;

    private int secilikarakter = 1;

	// Use this for initialization
    void Start ()
    {
        secilikarakter = PlayerPrefs.GetInt("karakterSec");
        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;
        playerStartPoint = thePlayer2.transform.position;
        playerStartPoint = thePlayer3.transform.position;
        theScoreManager = FindObjectOfType<ScoreManager>();
        if (secilikarakter==0)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(true);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (secilikarakter==1)
        {
            thePlayer.gameObject.SetActive(true);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (true)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;

        if (secilikarakter == 0)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(true);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (secilikarakter == 1)
        {
            thePlayer.gameObject.SetActive(true);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (secilikarakter == 2)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(true);
        }



        theDeathScreen.gameObject.SetActive(true);
        thePlayer.gameObject.SetActive(false);
        thePlayer2.gameObject.SetActive(false);
        thePlayer3.gameObject.SetActive(false);

        powerupManagerScript.sure = 5f;

        

        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theDeathScreen.gameObject.SetActive(false);

        platformList = FindObjectsOfType<PlatformDestroyer>();

        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;

        thePlayer2.transform.position = playerStartPoint;

        thePlayer3.transform.position = playerStartPoint;

        platformGenerator.position = platformStartPoint;

        if (secilikarakter == 0)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(true);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (secilikarakter == 1)
        {
            thePlayer.gameObject.SetActive(true);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(false);
        }
        else if (true)
        {
            thePlayer.gameObject.SetActive(false);
            thePlayer2.gameObject.SetActive(false);
            thePlayer3.gameObject.SetActive(true);
        }


        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
        powerupReset = true;
    }

    /*public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;

        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platformList = FindObjectsOfType<PlatformDestroyer>();

        for (int i=0;i<platformList.Length;i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }*/
}
