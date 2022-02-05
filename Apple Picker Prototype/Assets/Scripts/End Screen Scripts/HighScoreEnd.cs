using UnityEngine;
using UnityEngine.UI;

public class HighScoreEnd : MonoBehaviour
{
    public Text highScoreText;

    private void Update()
    {
        highScoreText = GetComponent<Text>();
        highScoreText.text = HighScore.score.ToString();
    }
}