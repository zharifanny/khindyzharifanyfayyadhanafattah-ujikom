using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HorseHealth : MonoBehaviour
{
    public int horseHealth = 200;
    // public TextMeshProUGUI scoreText;
    public string horseTarget = "horse";
    public string foodProjectile = "projectile";
    public ScoreController scoreCTRL;

    // Start is called before the first frame update
    void Start()
    {
        UpdatehorseHealth();
        
    }

    // Update is called once per frame
    void UpdatehorseHealth()
    {
        // if (scoreText != null)
        // {
        //     // scoreText.text = "Health : " + point.ToString();
            
        // }

        if (horseHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("horse Destroyed");
            //Add score buat dog
            scoreCTRL.point += 5;
            scoreCTRL.UpdateScore();
            Debug.Log("Score Added");
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(foodProjectile))
        {
            Debug.Log("si horse Kena");
            
            horseHealth -= 25;
            UpdatehorseHealth();
            
        }

        if (other.CompareTag("destroyer"))
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");

        }

    }
}
