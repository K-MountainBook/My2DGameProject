using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_CreatePrefab : MonoBehaviour
{

    public GameObject newPrefub;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5;
            GameObject newGameObject = Instantiate(newPrefub) as GameObject;
            newGameObject.transform.position = pos;

        }
    }
}
