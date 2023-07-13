using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour {



    public GameObject[] backgrounds;

    public float sure = 15f;
    public int backgroundsayac=0;

	void Update () {

        sure -= Time.deltaTime;
            
            if(sure<=0)
            {
            sure = 5f;
            backgroundsayac++;
            if(backgroundsayac==4)
            {
                backgroundsayac = 0;
            }
            for (int i = 0; i < backgrounds.Length; i++)
            {
                if(i== backgroundsayac)
                {
                    backgrounds[i].SetActive(true);
                }else
                {
                    backgrounds[i].SetActive(false);
                }
                
            }
                 
            }

	}
}
