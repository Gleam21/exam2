using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] float speed;
  

    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(Vector3.up, Mathf.PI);



        float val = Mathf.PingPong(Time.time*speed, 1);

        GetComponent<Renderer>().material.SetFloat("_TexValue", val);

    }
}
