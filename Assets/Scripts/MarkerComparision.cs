using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerComparision : MonoBehaviour
{

    public GameObject femurObject;
    public GameObject tibiaObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (femurObject && tibiaObject)
        {
            float dist = Vector3.Distance(femurObject.transform.position, tibiaObject.transform.position);
            print("Distance to other: " + dist);
            if ((dist > 10) && checkRotation())
            {
                print("The bones are in distance and rotation is the same");
            }
        }
    }
    

    bool checkRotation()
    {
        if ((checkOriantationInOneAxis(femurObject.transform.eulerAngles.x, tibiaObject.transform.eulerAngles.x)) &&
            (checkOriantationInOneAxis(femurObject.transform.eulerAngles.y, tibiaObject.transform.eulerAngles.y)) &&
            (checkOriantationInOneAxis(femurObject.transform.eulerAngles.z, tibiaObject.transform.eulerAngles.z)))
            return true;
        else
            return false;
    }

    bool checkOriantationInOneAxis(float femuraxis, float tibiaaxis)
    {
        float angleDifference = 0.1f; //it can be %10 tilted...
        if (femuraxis * (1 + angleDifference) > tibiaaxis && femuraxis * (1 - angleDifference) < tibiaaxis)
            return true;
        else
            return false;
    }
}
