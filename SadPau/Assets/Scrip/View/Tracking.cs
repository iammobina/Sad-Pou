using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tracking : MonoBehaviour
{
   
 
   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction,Mathf.Infinity);
            

            if (hit.collider != null && hit.transform.GetComponent<ClickControl>().Myisclickeable)
            {
                Debug.Log("ClickControl");
                ClickControl temp = hit.transform.GetComponent<ClickControl>();
                temp.ClickObj();
              
            }
        }
    }


}
