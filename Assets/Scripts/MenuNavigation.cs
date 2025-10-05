using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToVersusMode()
    {
        GameModeChosen.SelectedMode = GameMode.Versus;
        SceneManager.LoadScene("CharacterSelect"); // change to your game scene name
    }
    public void GoToGroupMenu()
    {
        SceneManager.LoadScene("GroupMenu"); // change to your game scene name
    }

    public void GoToStartMenu()
    {
        SceneManager.LoadScene("StartMenu"); // change to your game scene name
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
