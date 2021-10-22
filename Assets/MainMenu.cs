using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayMainLevel ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitMainMenu ()
    {
        Debug.Log("UDAH KELUAR LUR!!~");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
