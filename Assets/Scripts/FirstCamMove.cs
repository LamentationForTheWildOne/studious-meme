using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCamMove : MonoBehaviour
{
    public Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Square (26)")
        {
            MainCamera.transform.position = new Vector3(0,-3,-10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
