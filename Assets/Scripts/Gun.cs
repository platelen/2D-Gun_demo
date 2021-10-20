using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float max, min;
    private Controll gunControll;

    private void Start()
    {
        gunControll = GetComponent<Controll>();
    }

    private void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        Vector3 MyPos = Camera.main.WorldToScreenPoint(transform.position);

        float angle = Mathf.Atan2(MousePos.y, MousePos.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, min, max);
        transform.rotation = Quaternion.Euler(0, 0, angle);

        //Vector3 mousePos = Input.mousePosition;
        //mousePos.z = -Camera.main.transform.position.z;

        //transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
