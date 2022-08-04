using UnityEngine;
using UnityEngine.SceneManagement;

public class loosingMenu : MonoBehaviour
{
    public void play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
