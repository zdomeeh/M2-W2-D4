using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] int num;
    void Start()
    {
        while (index > 0)
        {
           num++;
           index--;
            Debug.Log("Il num è: " + num);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
