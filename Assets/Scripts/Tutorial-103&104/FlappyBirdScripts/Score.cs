using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

public static Score instance;

[Header("VALUES")]
[SerializeField] private TextMeshProUGUI currentScore;
[SerializeField] private TextMeshProUGUI bestScore;

private int score;

private void Awake()
{
    if(instance == null)
    {
        instance = this;
    }
}

private void Start()
{
    currentScore.text = score.ToString();

    bestScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
}

private void UpdateHighScore()
{
    if(score > PlayerPrefs.GetInt("HighScore"))
    {
     PlayerPrefs.SetInt("HighScore",score);
     bestScore.text = score.ToString();
    }
}

public void UpdateScore()
{
    score++;
    currentScore.text = score.ToString();
    UpdateHighScore();
}
}
