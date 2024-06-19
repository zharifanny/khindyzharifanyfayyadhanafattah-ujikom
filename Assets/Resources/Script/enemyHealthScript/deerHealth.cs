using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeerHealth : MonoBehaviour
{
    public int deerHealth = 200;
    // public TextMeshProUGUI scoreText;
    public string deerTarget = "deer";
    public string foodProjectile = "projectile";
    public ScoreController scoreCTRL;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDeerHealth();
        
    }

    // Update is called once per frame
    void UpdateDeerHealth()
    {
        // if (scoreText != null)
        // {
        //     // scoreText.text = "Health : " + point.ToString();
            
        // }

        if (deerHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("deer Destroyed");
            scoreCTRL.point += 1;
            scoreCTRL.UpdateScore();
            Debug.Log("Score Added");
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(foodProjectile))
        {
            Debug.Log("si deer Kena");
            
            deerHealth -= 25;
            UpdateDeerHealth();
            
        }

                if (other.CompareTag("destroyer"))
        {
            Destroy(gameObject);

        }

    }
}
