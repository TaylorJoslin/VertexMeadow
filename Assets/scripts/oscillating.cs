using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillating : MonoBehaviour
{
    public float height;
    public float speed;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        float Newy = Mathf.Sin(Time.deltaTime * speed) *height;
        transform.position = new Vector3(startPos.x, startPos.y + Newy, startPos.z);
    }
}
