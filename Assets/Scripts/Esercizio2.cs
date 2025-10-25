using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    [SerializeField] int[] numeri = new int[4];
    int somma;
    int prodotto = 1;
    void Start()
    {
      for (int i = 0; i < numeri.Length; i++)
          {
              somma += numeri[i];
              prodotto *= numeri[i];
            
        }
        Debug.Log("La somma di tutti i numeri è: " + somma);
        Debug.Log("Il prodotto di tutti i numeri è: " + prodotto);

    }

    
    void Update()
    {
        
    }
}
