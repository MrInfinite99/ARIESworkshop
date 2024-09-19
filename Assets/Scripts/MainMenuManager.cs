using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    // This method is assigned to the Start button
    public void StartGame()
    {
        // Load the game scene (replace "GameScene" with your actual game scene name)
        SceneManager.LoadScene("SampleScene");
    }

    // This method is assigned to the Quit button
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();

        // This line is only useful in the editor for testing
        Debug.Log("Game is quitting...");
    }
}
