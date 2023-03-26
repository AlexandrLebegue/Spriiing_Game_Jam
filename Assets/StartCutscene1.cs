using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene1 : MonoBehaviour
{
    public Animator camAnim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutscene), 2f);
        }
    }

    void StopCutscene()
    {
        camAnim.SetBool("cutscene1", false);
    }
}
