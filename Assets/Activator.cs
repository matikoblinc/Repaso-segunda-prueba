using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject myCube;
    bool Presionado;


    void Start()
    {
        myCube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (Presionado == false)
        //    {
        //        myCube.SetActive(true);
        //        Presionado = true;
        //    }
        //    else
        //    {
        //        myCube.SetActive(false);
        //        Presionado = false;
        //    }

        // el if de arriba y el de abajo hacen lo mismo 

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (myCube.activeInHierarchy == false) 
        //    {
        //        myCube.SetActive(true);
        //        Presionado = true;
        //    }
        //    else
        //    {
        //        myCube.SetActive(false);
        //        Presionado = false;
        //    }

        //}

        // forma mas corta de hacerlo:

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myCube.SetActive(!myCube.activeInHierarchy);
        }
    }
}
