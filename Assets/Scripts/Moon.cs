using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    
    [SerializeField] GameObject Earth;
    Vector3 tr;
    [SerializeField] float speed;
    float x, y;
    void Start()
    {

        tr = Earth.GetComponent<Transform>().position;

         


    }


    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(tr, Vector3.down, speed * Time.deltaTime);
        transform.Rotate(Vector3.up, Mathf.PI);

    }
}
