using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] int startNumber; 
    [SerializeField] int amount;
    void Start()
    {
        for (int i = 0; i <= amount; i++)
        {
            Debug.Log(startNumber + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
