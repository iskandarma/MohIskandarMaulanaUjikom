using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text TextScore;

    public int ScoreValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        TextScore.text = "Score : " + ScoreValue;
    }

    public void AddScore()
    {
        ScoreValue++;
    }
}
