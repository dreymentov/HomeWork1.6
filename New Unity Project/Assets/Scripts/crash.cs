using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float speedVector;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(new Vector3(10, 0, 0) * speedVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Произошло столкновение между " + this.gameObject + " и " + other.gameObject);
    }
}
