using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth2 : MonoBehaviour
{
    [SerializeField] public int enemyHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8);
        Debug.Log("Enemy Sudah Di Destroy Otomatis");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <=0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy Di Destroy");
        }
        
    }

}
