using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Drag your Game Over Panel here
    public Text gameOverText; // Drag your Game Over Text here
    public Button restartButton; // Drag your Restart Button here
    public Button quitButton; // Drag your Quit Button here
    public Button mainMenuButton;
    private void Start()
    {
        // Initially hide the Game Over panel
        gameOverPanel.SetActive(false);

        // Add listeners to buttons
        restartButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(QuitGame);
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    public void GameOver()
    {
        // Show Game Over panel
        gameOverPanel.SetActive(true);
    }

    private void RestartGame()
    {
        // Restart the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }

    private void MainMenu()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("MainMenu");
        //Application.Quit();
    }
}
