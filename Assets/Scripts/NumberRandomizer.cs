using UnityEngine;
using TMPro;

public class NumberRandomizer : MonoBehaviour
{
    public TMP_Text numberText;
    private int randomNumber;

    public void RandomizeNumber()
    {
        randomNumber = Random.Range(0, 10);
        numberText.text = randomNumber.ToString();
    }
}
