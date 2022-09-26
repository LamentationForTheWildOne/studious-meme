using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCamMove : MonoBehaviour
{
    public Camera MainCamera;
    public Transform me;
    public Transform ball;
    public bool follow;
    public bool whichfollow;
    // Start is called before the first frame update
    void Start()
    {
        follow = false;
        whichfollow = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Square (45)")
        {
            follow = true;
        }
        if (collision.gameObject.name == "Square (55)")
        {
            whichfollow = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (follow == true) {
            if (whichfollow == true)
            {
                MainCamera.transform.position = new Vector3(me.position.x, me.position.y, -10);
            }
            else {
                MainCamera.transform.position = new Vector3(ball.position.x, ball.position.y, -10);
            }
            }

        }
}
