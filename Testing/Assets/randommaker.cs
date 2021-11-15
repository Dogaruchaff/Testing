using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommaker : MonoBehaviour
{
    public GameObject[] Points;
    public Material[] pointmaterial;
    int sayi;
    void Start()
    {
        for (int i = 0; i < Points.Length; i++)
        {
            sayi = Random.Range(0,Points.Length);
            
        }
    }

    void Update()
    {
        
    }
}
