using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject go;
    public Vector3 offset;
    private void Start()
    {
        offset = go.transform.position - transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = go.transform.position - offset;
        
        transform.LookAt(go.transform);
    }
}
