using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class screeenloader : MonoBehaviour
{
    
    public void reloadscene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
  public  void quitgame() {
        Application.Quit();
    }
    
}
