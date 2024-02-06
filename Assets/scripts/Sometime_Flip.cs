using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Flip : MonoBehaviour
{
    // Start is called before the first frame update
 
    public int maxCount = 50;

    int count = 0;
    bool flipFlag = false;
    
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = count + 1;
        if(count == maxCount)
        {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}
