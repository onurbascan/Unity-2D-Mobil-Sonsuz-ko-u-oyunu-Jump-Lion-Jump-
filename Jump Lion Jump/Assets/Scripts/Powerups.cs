using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{

    public bool doublePoints;
    public bool safeMode;

    public float powerupLenght;

    private PowerupManager thePowerupManager;

    public Sprite[] powerupSprites;

	// Use this for initialization
	void Start ()
    {
        thePowerupManager = FindObjectOfType<PowerupManager>();
	}

     void Awake()
    {
        int powerupSelector = Random.Range(0, 2);

        switch(powerupSelector)
        {
            case 0: doublePoints = true;
                break;
            case 1: safeMode = true;
                break;

        }
        GetComponent<SpriteRenderer>().sprite = powerupSprites[powerupSelector];
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name=="Player")
        {
            thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLenght);
        }
        gameObject.SetActive(false);
        if (other.name == "Player2")
        {
            thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLenght);
        }
        gameObject.SetActive(false);
        if (other.name == "Player3")
        {
            thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLenght);
        }
        gameObject.SetActive(false);

    }
}
