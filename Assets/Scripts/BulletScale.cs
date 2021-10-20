using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScale : MonoBehaviour
{
    void Update()
    {
        BuScale();   
    }

    public void BuScale()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(-0.02f, -0.02f);
            gameObject.transform.tag = "Player";
            
        }
    }
}
