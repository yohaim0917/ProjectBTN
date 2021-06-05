using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movingspeed = 5.0f;
    public float rotatespeed = 100f;
    float ry;

    // Start is called before the first frame update
    void Start()
    {
        ry = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, y) * movingspeed * Time.deltaTime);

        ry += x * rotatespeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, ry, 0));
    }
}
