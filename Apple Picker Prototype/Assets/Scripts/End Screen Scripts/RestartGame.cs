using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartLevel(int buttonNumber)
    {
        SceneManager.LoadScene(buttonNumber);
    }
}
