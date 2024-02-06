using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH_OnCollision_Flip : MonoBehaviour
{

    public float speed = 30;

    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    private void FixedUpdate()
    {
        rbody.velocity = new Vector2(0, speed);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
