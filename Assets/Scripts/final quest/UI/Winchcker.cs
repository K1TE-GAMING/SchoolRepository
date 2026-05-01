using UnityEngine;

public class Winchcker : MonoBehaviour
{
    public GameScreen gameScreen;
    private bool gameEnded;

    void Update()
    {
        if (gameEnded) return;

        CheckWin();
        CheckLose();
    }

    void CheckWin()
    {
        GameObject[] tanks = GameObject.FindGameObjectsWithTag("Tank");

        if (tanks.Length == 0)
        {
            gameScreen.ShowGameWinScreen();
            gameEnded = true;
        }
    }

    void CheckLose()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Raccon");

        if (player.Length == 0)
        {
            gameScreen.ShowGameOverScreen();
            gameEnded = true;
        }
    }
}