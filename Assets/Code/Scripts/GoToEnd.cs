using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEnd : MonoBehaviour
{
    public float TimeToWait;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(EndGame());
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(TimeToWait);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
