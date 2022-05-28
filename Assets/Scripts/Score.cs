using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    Text _scoreText;

    int _score;

    private void Awake()
    {
        _scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
    }

    private void Start()
    {
        _score = int.Parse(_scoreText.text);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "monster")
        {
            _score += 1;

            _scoreText.text = _score.ToString();
        }
    }
}
