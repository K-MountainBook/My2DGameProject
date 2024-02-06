using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_turn : MonoBehaviour
{

    public float angle = 90;
    public int maxCount = 100;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        count = count + 1;
        if(count == maxCount){
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
