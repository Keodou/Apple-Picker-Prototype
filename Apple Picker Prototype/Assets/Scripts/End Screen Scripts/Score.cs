using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public int currentScore;

    public Text currentScoreText;

    private void Start()
    {
        currentScoreText = GetComponent<Text>();
        currentScoreText.text = "Current Score: " + currentScore.ToString();
    }
}
