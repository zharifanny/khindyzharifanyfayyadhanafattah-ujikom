using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProjectile : MonoBehaviour
{
    public int hungerValue = 25;

    //tidak dipakai
    public string deerTag = "deer";
    public string dogTag = "dog";
    public string horseTag = "horse";

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

    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag(deerTag))
    //     {
    //         enemyHealth2.enemyHealth -= 25;
    //         Debug.Log("kena deer");
    //     }
    // }
}
