using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egemen : MonoBehaviour
{
    bool isprime;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 2; i <= 1000; i++)
        {
            
            for (int p = 2; p <= i; p++)
            {
                
                if (i % p == 0 && i != p)
                {
                    isprime = false;
                    break;
                }
                isprime = true;
                
                
                
            }
            if (isprime == true)
            {
                print(i);
            }
        }
        

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

  
    }
}
