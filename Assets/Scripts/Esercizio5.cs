using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    [SerializeField] int numberToFind;
    [SerializeField] int arraySize;
    [SerializeField] int numberOffset;
    void Start()
    {
        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = Random.Range(numberToFind - numberOffset, numberToFind + numberOffset);

            if (array[i] == numberToFind)
            {
                Debug.Log("Found");
            }
            else
            {
                Debug.Log("Not Found");
            }
        }

        Debug.Log("Iteration finished");


        // Update is called once per frame
        void Update()
        {

        }
    }
}
