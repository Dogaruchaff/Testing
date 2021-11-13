using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egemen : MonoBehaviour
{
    int haha = 31;
    bool isprime;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 2; i <= 100; i++) {  
            for (int j = 2; j <= 100; j++) {  
                if (i != j && i % j == 0) {  
                    
                    break;  
                }  
            }  
        }
    }

    // Update is called once per frame
    void Update()
    {
        

  
    }
}
