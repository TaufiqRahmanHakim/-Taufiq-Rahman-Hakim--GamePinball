using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private GameObject gameOver;
    public void ResetGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void GameOver() => gameOver.SetActive(true);

    public void ExitGame() => Application.Quit();

    public void PlayGame() => SceneManager.LoadScene("SampleScene");
    public void MainMenu() => SceneManager.LoadScene("MainMenu");
}
