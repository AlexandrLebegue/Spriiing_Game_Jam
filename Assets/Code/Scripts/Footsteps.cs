using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;
    public Animator animator;

    

    private void Update()
    {
        if (animator.GetBool("Is_Walking")){
            if ((Input.GetKey(KeyCode.Q) & Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.RightArrow)))
            {
                footstepsSound.enabled = false;
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
            {
                footstepsSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = false;
            }
        }
        
    }
}
