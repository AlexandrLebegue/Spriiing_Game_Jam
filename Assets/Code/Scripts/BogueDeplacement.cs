using UnityEngine;
using System.Collections;

public class BogueDeplacement : MonoBehaviour {
 
    public float speed = 1f;
    public float jumph = 5f;

    void Start () { print ("Start"); }
 
    void Update () {
 
        Vector3 dp = new Vector3();
 
        if (Input.GetKey (KeyCode.Q)) {
            dp.x -= speed;
        }
 
        if (Input.GetKey (KeyCode.D)) {
            dp.x += speed;
        }

        if (Input.GetKey (KeyCode.Space)) {
            dp.y += jumph;  
        }
 
        transform.position += dp;
    }
}