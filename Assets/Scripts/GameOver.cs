using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject _gameOverPanel, _arrowSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            Time.timeScale = 0;

            _gameOverPanel.SetActive(true);

            _arrowSpawn.GetComponent<ArrowSpawn>().enabled = false;
        }
    }

    public void PlayAgainOnClick()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        _gameOverPanel.SetActive(false);
    }

    public void ExitButonOnClick()
    {
        SceneManager.LoadScene(0);
    }

}
