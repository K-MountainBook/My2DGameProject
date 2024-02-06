using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 追いかける
public class Forever_Chase : MonoBehaviour
{
    public string targetObjectName;
    public float speed = 1;

    GameObject targetObject;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        // 目標オブジェクトを見つけておく
        targetObject = GameObject.Find(targetObjectName);
        // 重力を０にして回転させない
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;

        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);

        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }

}