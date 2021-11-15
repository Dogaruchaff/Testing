using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommaker : MonoBehaviour
{
    public List<GameObject> Points;
    public List<Material> pointmaterial;
    int sayi;
    int sayi2;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            sayi = Random.Range(0,Points.Count);
            sayi2 = Random.Range(0,pointmaterial.Count);
            Points[sayi].gameObject.GetComponent<MeshRenderer>().material = pointmaterial[sayi2];
            Points.RemoveAt(sayi);
            pointmaterial.RemoveAt(sayi2);
            print(sayi);
        }
        
    }

    void Update()
    {
        
    }
}
