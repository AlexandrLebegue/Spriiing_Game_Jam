using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{

  public Animator animator;
  private int levelToLoad;
  void OnGUI()
  {
    const int buttonWidth = 84;
    const int buttonHeight = 60;
    
    
    //imageToFade.img = GameObject.Find("Fade_Image").GetComponent<Image>();
    // Affiche un bouton pour démarrer la partie
    if (GUI.Button(
        // Centré en x, 2/3 en y
        new Rect(
          Screen.width / 2 - (buttonWidth / 2),
          (2.5f * Screen.height / 3) - (buttonHeight / 2),
          buttonWidth,
          buttonHeight
        ),
        "Let's goo !"
      )
    )
    {
      //animator.SetTrigger("FadeOut");
      // Sur le clic, on démarre le premier niveau
      // "Stage1" est le nom de la première scène que nous avons créés.
      //imageToFade.StartFade();
      FadeToNextLevel();
      
    }


  }

public void FadeToNextLevel ()
	{
		FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void FadeToLevel (int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadScene(levelToLoad);
	}

}
