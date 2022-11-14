using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSCR : MonoBehaviour
{
    /// Descrição 
    /// Sistema navegação do menu
    /// Descrição 
    
    public void startgame()
    {
        SceneManager.LoadScene("OceanFarm");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
