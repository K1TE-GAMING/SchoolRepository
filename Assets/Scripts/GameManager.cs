using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver = false;

    public GameObject woodPrefab;
    private float spawnerTimer = 0.0f;
    private float rateOfSpawn = 3.0f;
    public Transform[] posRefArray;

    public TMP_Text scoreText;
    public float timelimited = 60;

    public GameObject gameOverScreen;
    public GameObject gameWinScreen;

    float countdown;
    float multiplier = 1.0f;

    private void Start()
    {
           scoreText.text = timelimited.ToString();
        countdown = timelimited;    }

    private void Update()
    {

        CountDown();

      EnableGameOver();

        spawnerTimer += Time.deltaTime;

        // spawn enemy if countdown is greater than 0
        if (countdown > 0)
        {
            if (spawnerTimer >= rateOfSpawn)
            {
                SpawnWood();
                spawnerTimer = 0;
            }
        }


    }


    private void SpawnWood()
    {
        int randomPosIdx = Random.Range(0, posRefArray.Length);
        Instantiate(woodPrefab, posRefArray[randomPosIdx].position, Quaternion.identity);
    }

    public void CountDown()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0)
        {
            countdown = 0;
            EnableGameWin();
        }

        scoreText.text = Mathf.Ceil(countdown).ToString();
    }
    

    public void EnableGameOver()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            //spawn game over screen 
            gameOverScreen.SetActive(true);
            isGameOver = true;
        }

    }

    public void EnableGameWin()
    {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }

}
