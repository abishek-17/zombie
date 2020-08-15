using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ses : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadscene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
 

}
