using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forTriggerHouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("В доме кто-то появился, это " + other);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Кто-то вышел из дома, это " + other);
    }

}
