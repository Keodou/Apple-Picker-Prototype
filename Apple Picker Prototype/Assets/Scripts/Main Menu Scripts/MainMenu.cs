using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
