using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToGroupMenu()
    {
        SceneManager.LoadScene("GroupMenu"); // change to your game scene name
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
