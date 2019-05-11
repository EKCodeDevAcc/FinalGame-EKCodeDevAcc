using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour {

    public Transform[] target;
    public float speed = 10.0f;

    private int current;

    // Update is called once per frame
    void Update () {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
            transform.Rotate(0, 180, 0);
        }
    }
}
