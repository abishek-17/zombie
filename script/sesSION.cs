using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sesSION : MonoBehaviour
{
    // Start is called before the first frame update
    public void Rloadscene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void qgame()
    {
        Application.Quit();
    }

}
