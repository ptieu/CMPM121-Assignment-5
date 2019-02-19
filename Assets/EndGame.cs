using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
  public Player Keys;

    void Start()
    {

    }

    void Update()
    {
      if(Keys.collected == 10)
      {
        MainMenuScene("TitleScreen");
      }

    }

    public void MainMenuScene(string SceneName)
    {
      SceneManager.LoadScene(SceneName);
    }
}
