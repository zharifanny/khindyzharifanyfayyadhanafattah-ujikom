using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cowHealth : MonoBehaviour
{
    private Animation anim;
    public int CowHealth = 300;
    // public TextMeshProUGUI scoreText;
    public string cowTarget = "cow";
    public string foodProjectile = "projectile";
    public ScoreController scoreCTRL;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCowHealth();
        anim = gameObject.GetComponent<Animation>();
        anim.Play("walk");
        
    }

    // Update is called once per frame
    void UpdateCowHealth()
    {
        // if (scoreText != null)
        // {
        //     // scoreText.text = "Health : " + point.ToString();
            
        // }

        if (CowHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Cow Destroyed");
            scoreCTRL.point += 5;
            scoreCTRL.UpdateScore();
            Debug.Log("Score Added");
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(foodProjectile))
        {
            Debug.Log("Kena");
            
            CowHealth -= 25;
            UpdateCowHealth();
            
        }

    }
}
