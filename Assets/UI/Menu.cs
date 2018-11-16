using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    string Main = "Main_Menu";
    string Game = "SampleScene";
    //string Controls = "Controls";

    //Loads main menu
    public void LoadMenu()
    {
        SceneManager.LoadScene(Main);
    }

    //Loads the endless runner
    public void LoadGame()
    {
        SceneManager.LoadScene(Game);
    }

    //Loads the control screen
    /*public void LoadControls()
    {
        SceneManager.LoadScene(Controls);
    }*/

    //Closes the game
    public void Close()
    {
        Application.Quit();
    }
}
