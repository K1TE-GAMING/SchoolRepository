using TMPro;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
        private TextMeshProUGUI EnemyCountText;


    private void Awake()
    {
        EnemyCountText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int EnemiesLeft = GameObject.FindGameObjectsWithTag("Tank").Length;
        EnemyCountText.text = EnemiesLeft.ToString();

    }
}
