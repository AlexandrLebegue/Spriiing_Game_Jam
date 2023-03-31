using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public float TimerEndIntro;
    public float TimerRain;
    void Start()
    {
        GameObject.Find("Rain").GetComponent<ParticleSystem>().Play(false);
        //StartCoroutine(PlayRain());
        StartCoroutine(EndIntro());
    }
    /*IEnumerator PlayRain()
    {
        yield return new WaitForSeconds(TimerRain);
        GameObject.Find("Rain").GetComponent<ParticleSystem>().Play(true);
    }*/

    IEnumerator EndIntro()
    {
        yield return new WaitForSeconds(TimerEndIntro);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
