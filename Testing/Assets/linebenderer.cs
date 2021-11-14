using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linebenderer : MonoBehaviour
{
    LineRenderer lr;
    public Camera cam;
    bool isStartPoint;
    Transform startpos;
    void Start()
    {
        lr = this.GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            Debug.DrawLine(cam.transform.position,hit.point,Color.green);
            if (hit.transform.tag == "startpoint" && Input.GetMouseButtonDown(0))
            {
                startpos = hit.transform;
                lr = hit.transform.GetComponent<LineRenderer>();
                lr.SetPosition(0,startpos.position);
                lr.SetPosition(1,startpos.position);
                isStartPoint = true;
            }
            if (hit.transform.tag == "endpoint" && isStartPoint == true)
            {
                lr.SetPosition(1,hit.transform.position);
                isStartPoint = false;
            }
            if (Input.GetMouseButtonUp(0) && hit.transform.tag != "endpoint")
           {
               lr.SetPosition(0,startpos.position);
               lr.SetPosition(1,startpos.position);
               isStartPoint = false;
           }
            if (hit.transform.tag == "wirefix" && isStartPoint == true)
            {
                lr.SetPosition(1, hit.point);
            }
        }
    }
}
