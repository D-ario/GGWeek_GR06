using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GotoSettingsMenu()
    {
        SceneManager.LoadScene("Credits");
    }
    public void MaineMenu()
    {
        SceneManager.LoadScene("MAIN MENU");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
