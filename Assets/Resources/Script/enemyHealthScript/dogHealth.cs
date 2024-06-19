using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DogHealth : MonoBehaviour
{
    public int dogHealth = 100;
    // public TextMeshProUGUI scoreText;
    public string dogTarget = "dog";
    public string foodProjectile = "projectile";
    public ScoreController scoreCTRL;

    // Start is called before the first frame update
    void Start()
    {
        UpdatedogHealth();
        
    }

    // Update is called once per frame
    void UpdatedogHealth()
    {
        // if (scoreText != null)
        // {
        //     // scoreText.text = "Health : " + point.ToString();
            
        // }

        if (dogHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("dog Destroyed");
            //Add score buat dog
            scoreCTRL.point += 2;
            scoreCTRL.UpdateScore();
            Debug.Log("Score Added");
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(foodProjectile))
        {
            Debug.Log("si dog Kena");
            
            dogHealth -= 25;
            UpdatedogHealth();
            
        }

    }
}
