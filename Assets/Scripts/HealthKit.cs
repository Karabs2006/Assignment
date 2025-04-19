using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthKit : MonoBehaviour
{   
    int MedKit = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D trigger)
        {
            Player playerScript = trigger.gameObject.GetComponent<Player>();

            if(trigger.gameObject.name == "Player")
            {
                playerScript.PlayerHealth += MedKit;
                playerScript.myText.text = $"{playerScript.PlayerHealth}";

                Destroy(gameObject);


            }


        }


}
