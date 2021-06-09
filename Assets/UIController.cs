using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject _restartUi;
    [SerializeField] private Text _scoreText;
    
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerDead()
    {
        _restartUi.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        _scoreText.text = score + "";
    }
}
