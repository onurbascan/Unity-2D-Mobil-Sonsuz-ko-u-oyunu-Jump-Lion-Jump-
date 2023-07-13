using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{

    private bool doublePoints;
    private bool safeMode;

    private bool powerupActive;

    private float powerupLenghtCounter;

    private ScoreManager theScoreManager;
    private PlatformGenerator thePlatformGenerator;
    private GameManager theGameManager;

    private float normalPointsPerSecond;
    private float spikeRate;

    private PlatformDestroyer[] spikeList;

    public float sure = 5f;

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 0.8f;

        theScoreManager = FindObjectOfType<ScoreManager>();
        thePlatformGenerator = FindObjectOfType<PlatformGenerator>();
        theGameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(powerupActive)
        {
            powerupLenghtCounter -= Time.deltaTime;

            if(theGameManager.powerupReset)
            {
                powerupLenghtCounter = 0;
                theGameManager.powerupReset = false;
            }

            if(doublePoints)

            {
                theScoreManager.pointsPerSecond = normalPointsPerSecond * 2.75f;
                theScoreManager.shouldDouble = true;
            }

            if(safeMode)
            {
                sure -= Time.deltaTime;
                thePlatformGenerator.randomSpikeThreshold = 0f;
                if(sure<=0f)
                {
                    safeMode = false;
                    sure = 5f;
                    thePlatformGenerator.randomSpikeThreshold = 75f;
                    spikeList = FindObjectsOfType<PlatformDestroyer>();

                    for (int i = 0; i < spikeList.Length; i++)
                    {
                        if (spikeList[i].gameObject.name.Contains("spikes"))
                        {
                            spikeList[i].gameObject.SetActive(true);
                        }

                    }
                }
            }


            if(powerupLenghtCounter<=0)
            {
                
                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theScoreManager.shouldDouble = false;
                thePlatformGenerator.randomSpikeThreshold = spikeRate;
                powerupActive = false;
            }
        }
	}

    public void ActivatePowerup(bool points,bool safe,float time)
    {
        doublePoints = points;
        safeMode = safe;
        powerupLenghtCounter = time;
        if(!powerupActive)
        {
            normalPointsPerSecond = theScoreManager.pointsPerSecond;
            spikeRate = thePlatformGenerator.randomSpikeThreshold;
        }
        

        if(safeMode)
        {
            spikeList = FindObjectsOfType<PlatformDestroyer>();

            for (int i = 0; i < spikeList.Length; i++)
            {
                if(spikeList[i].gameObject.name.Contains("spikes"))
                {
                    spikeList[i].gameObject.SetActive(false);
                }
                
            }
        }

        

        powerupActive = true;
    }
}
