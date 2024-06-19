using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FoodProjectile : MonoBehaviour
{
    AudioSource audioData;
    
    public int hungerValue = 25;
    

    //tidak dipakai
    public string deerTag = "deer";
    public string dogTag = "dog";
    public string horseTag = "horse";
    public string cowTag = "cow";

    public EnemyHealth2 enemyHealth2;
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, 3);
        Debug.Log("Food Destroyed");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("Termakan");
        
        if (other.CompareTag(cowTag))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag(dogTag))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag(horseTag))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag(deerTag))
        {
            Destroy(gameObject);
        }

        

    }
}
