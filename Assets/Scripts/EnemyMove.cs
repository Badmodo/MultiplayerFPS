using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float timeCounter = 0f;

    public float speed = 5;
    public float width1 = 100;
    public float width2 = 100;
    public float height = 20;

    private void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Sin(timeCounter) * width1;
        float y = height;
        float z = Mathf.Cos(timeCounter) * width2;

        transform.position = new Vector3(x, y, z);
    }
}
