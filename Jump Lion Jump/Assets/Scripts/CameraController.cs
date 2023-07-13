using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public PlayerController thePlayer;
    public PlayerController thePlayer2;
    public PlayerController thePlayer3;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    private int secilikarakter = 0;

	// Use this for initialization
	void Start () {
        secilikarakter = PlayerPrefs.GetInt("karakterSec");
    }
	
	// Update is called once per frame
	void Update () {

        if (secilikarakter==0)
        {
            distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
            transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
            lastPlayerPosition = thePlayer.transform.position;
        }
        else if (secilikarakter==1)
        {
            distanceToMove = thePlayer2.transform.position.x - lastPlayerPosition.x;
            transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
            lastPlayerPosition = thePlayer2.transform.position;
        }
        else if (secilikarakter==2)
        {
            distanceToMove = thePlayer3.transform.position.x - lastPlayerPosition.x;
            transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
            lastPlayerPosition = thePlayer3.transform.position;
        }
        
	}
}
