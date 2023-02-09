using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject light;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            light.SetActive(true);
        }

        else if(light == true)
        {
            if (Input.GetMouseButton(1))
            {
                light.SetActive(false);
            }
        }
    }

}
