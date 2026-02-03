using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Call this function from the UI Button
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Optional: Quit the game (useful for Exit button)
    public void QuitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}
