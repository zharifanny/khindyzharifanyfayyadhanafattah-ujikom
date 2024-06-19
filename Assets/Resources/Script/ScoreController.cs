using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int point = 0;
    public TextMeshProUGUI scoreText;
    public string targetTag = "triggerAddScore";

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
        
    }

    // Update is called once per frame
    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score : " + point.ToString();
            
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            point += 1;
            UpdateScore();
        }

    }
}
