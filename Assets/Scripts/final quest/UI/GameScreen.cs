using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameScreen : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject GameWinScreen;

    private void Start()
    {
        GameOverScreen.gameObject.SetActive(false);
        GameWinScreen.gameObject.SetActive(false);
        Time.timeScale = 1f; // ensure the game is running at normal speed when it starts
    }
    public void ShowGameOverScreen()
    {
        GameOverScreen.gameObject.SetActive(true);
        Time.timeScale = 0f; // pause the game when the player dies
    }

    public void ShowGameWinScreen()
    {
       GameWinScreen.gameObject.SetActive(true);
        Time.timeScale = 0f; // pause the game when the player wins
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // reload the current scene to restart the game
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu"); // load the main menu scene
    }

}
