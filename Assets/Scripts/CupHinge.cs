using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupHinge : MonoBehaviour
{
    public float timer;
    public bool countdown;
    // Start is called before the first frame update
    void Start()
    {
        timer = 900;
        countdown = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Circle")
        {
            countdown = true;
        }
    }

        // Update is called once per frame
        void Update()
    {
        if (timer > 0 && countdown == true) {
            timer -= 1;
        }
        if (timer == 0) {
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
