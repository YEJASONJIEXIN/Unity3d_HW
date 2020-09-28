using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCruve1 : MonoBehaviour
{
    public float horizontalSpeed = 5.00f;
    public float verticalSpeed = 0.00f;
    const float g = 0.02f;
    // Use this for initialization
    void Start()
    {
        Debug.Log("start!");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.right * Time.deltaTime * horizontalSpeed;
        this.transform.position += Vector3.down * Time.deltaTime * verticalSpeed;
        verticalSpeed += g;
    }
}
