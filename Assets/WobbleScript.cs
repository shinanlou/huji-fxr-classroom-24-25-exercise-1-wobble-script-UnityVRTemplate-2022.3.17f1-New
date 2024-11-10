using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(1.231f * Time.time), Mathf.Sin(5 * Time.time), Mathf.Sin(4 * Time.time));

        float rotationX = Mathf.Sin(3 * Time.time) * 2;
        float rotationY = Mathf.Sin(2 * Time.time) * 4;
        float rotationZ = Mathf.Sin(5 * Time.time) * 2;
        transform.Rotate(rotationX, rotationY, rotationZ);
        GetComponent<Rigidbody>().mass= Mathf.Sin(4 * Time.time);
        //test
    }
}
