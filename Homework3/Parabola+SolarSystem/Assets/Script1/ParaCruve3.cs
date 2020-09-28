using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaCruve3 : MonoBehaviour
{
    public float horizontalSpeed = 5.00f;
    public float verticalSpeed = 0.00f;
    const float g = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start!");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 change = new Vector3(Time.deltaTime * horizontalSpeed, -Time.deltaTime * verticalSpeed, 0.0f);
        this.transform.Translate(change);
        verticalSpeed += g;
    }
}
