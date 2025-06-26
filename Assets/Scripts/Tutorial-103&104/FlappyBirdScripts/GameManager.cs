using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
public static GameManager instance;

[SerializeField] private GameObject gameoverCanvas;

private AudioSource audio;

private void Awake()
{
    audio = GetComponent<AudioSource>();

    if(instance == null)
    {
       instance = this;
    }

    Time.timeScale = 1f;
}

public void GameOver()
{
    gameoverCanvas.SetActive(true);
    audio.Play();
    Time.timeScale = 0f;
}

public void RestartGame()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

}
