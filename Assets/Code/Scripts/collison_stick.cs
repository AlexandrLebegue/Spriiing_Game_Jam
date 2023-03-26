using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison_stick : MonoBehaviour
{

    public BogueDeplacement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {       
        if(other.gameObject.name == "Bogue")
        {
            print("Collision detected with trigger object "  + player.name);
            player.EnterTheStick();
        }
        Debug.Log("oy");

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Bogue")
        {
            print("Collision detected with trigger object "  + player.name);
            player.EnterTheStick();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.name == "Bogue")
        {
            print("Sortie de bogue"  + player.name);
            player.ExitTheStick();
        }
    }

}
