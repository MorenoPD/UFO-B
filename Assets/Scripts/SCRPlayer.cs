using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRPlayer : MonoBehaviour
{
    [SerializeField]
    float Velocitat = 3;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        float x, y; //per llegir el gamepad
        x = Input.GetAxis("Horizontal"); //llegim moviment horitzontal  
        y = Input.GetAxis("Vertical"); //llegim moviment vertical

        //print("Horizontal: " + x + "/ Vertical " + y); //mostrarem x y 
        transform.Translate(x *Time.deltaTime * Velocitat , y *Time.deltaTime *Velocitat, 0);
    }
}
