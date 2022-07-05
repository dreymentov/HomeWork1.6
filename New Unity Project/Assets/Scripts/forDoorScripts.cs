using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forDoorScripts : MonoBehaviour
{
    private float vectorSpeed = 1;
    public float speed = 0.1f;
    public float maxRange;
    public GameObject _gO;

    // Start is called before the first frame update
    void Start()
    {
        _gO = this.gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _gO.transform.position += Vector3.right * speed * vectorSpeed;
        if((_gO.transform.position.x > maxRange) || (_gO.transform.position.x < -maxRange))
        {
            vectorSpeed *= -1;
        }
    }
}
