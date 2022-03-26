using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horiz;

        horiz = Input.GetAxis("Horizontal");

        Vector2 newVelocity = new Vector2(horiz, 0.0f);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;


        //float newY;
        //newY = Mathf.Clamp(rBody.position.y, minY, maxY);

       // rBody.position = new Vector2 (rBody.position.x, newY);

    }
}
