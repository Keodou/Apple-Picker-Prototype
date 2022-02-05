using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void LevelButton(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
