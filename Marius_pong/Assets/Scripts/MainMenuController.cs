using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadScene("game");
    Debug.Log("Created by Marius Asda");
   }

   public void OpenAuthor()
   {
      Debug.Log("Created by Marius Asda");
   }
}
