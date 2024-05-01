using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string gameSceneName = "Pacman"; 
    public PlayButtonHandler playButtonHandler; 

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneName);

        if (playButtonHandler != null)
        {
            playButtonHandler.MoveObjects();
        }
    }
}
