using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;  // Pausar el tiempo del juego
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;  // Reanudar el tiempo del juego
        isPaused = false;
        
    }
}