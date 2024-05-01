using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Pacman");
    }
}
