using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public int _score;
    public Text _scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _score = 0;
    }

    public void SetScore(int value)
    {
        _score += value;
        Debug.Log("Player Score : " + _score);
        _scoreText.text = "Player Score : " + _score;
    }

}
