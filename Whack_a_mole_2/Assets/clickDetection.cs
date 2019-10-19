using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDetection : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0)) { //0 for left, 1 for right
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // the object identified by hit.transform was clicked
                // do whatever you want

            }
        }*/
    }
}
