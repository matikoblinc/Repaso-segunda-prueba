using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{

    public GameObject prefab;
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < num1; i++) {
                GameObject clon;
                clon = Instantiate(prefab);

                Destroy(clon, 0.5f); // que sestruya el clon luego de 1 segundo. 
            }
        }
    }
}
