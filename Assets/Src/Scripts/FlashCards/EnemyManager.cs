using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int currentHealth;

    public GameObject currentEnemy;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            currentEnemy.gameObject.SetActive(false);
        }
    }
}
