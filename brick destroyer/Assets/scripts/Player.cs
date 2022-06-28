using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        RB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0f);
    }
}
