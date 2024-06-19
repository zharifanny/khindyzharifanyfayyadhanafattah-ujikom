using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodProjectile : MonoBehaviour
{
    public int hungerValue = 25;
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
}
