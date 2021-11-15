using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linebenderer : MonoBehaviour
{
    public LayerMask layer;
    LineRenderer lr;
    public Camera cam;
    bool isClicked;
    bool isConnected;
    Vector3 startpos;
    public Material startmaterial;
    public Material endmaterial;
    
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit,1000f,layer))
        {
            Debug.DrawLine(cam.transform.position,hit.point,Color.red);

            // ilk tıklama
            if (Input.GetMouseButtonDown(0) && hit.transform.tag == "startpoint")
            {
                startmaterial = hit.transform.GetComponent<MeshRenderer>().material;
                startpos = hit.transform.position;

                lr = hit.transform.gameObject.GetComponent<LineRenderer>();
                lr.SetPosition(0,hit.transform.position);
                lr.SetPosition(1,hit.transform.position);

                lr.startColor = startmaterial.color;
                lr.endColor = startmaterial.color;

                isClicked = true;
            }

            // basılı tutma hali
            if (isClicked == true)
            {
                lr.SetPosition(1,hit.point);
            }

            // son tıklama
            if (Input.GetMouseButtonUp(0) && startmaterial != null)
            {
                endmaterial = hit.transform.GetComponent<MeshRenderer>().material;

                if (startmaterial.name == endmaterial.name)
                {
                    lr.SetPosition(1,hit.transform.position);
                    isConnected = true;
                    isClicked = false;
                    print("hey");
                }
                else if(isConnected)
                {
                    lr.SetPosition(1,startpos);
                    isClicked = false;
                    print("olmadi");
                }
            }
            

            
        }
    }
}
