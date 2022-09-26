using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var slide = GetComponent<SliderJoint2D>();
        var motor = slide.motor;
        if (collision.gameObject.name == "Circle") {
            slide.useMotor = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
