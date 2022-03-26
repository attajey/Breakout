using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    // Start is called before the first frame update
    private Rigidbody2D rigidbody;
    public float speed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        float y = Random.value < 0.5f ? -1.0f : 1.0f;
        float x = Random.value < 0.5f ? Random.Range(-1.0f, 0.5f) : 
                                        Random.Range(0.5f, 1.0f);
        Vector2 newVelocity = new Vector2(x, y);

        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        rigidbody.position = Vector3.zero;
    }
}
