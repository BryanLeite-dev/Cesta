using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloInfinito : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 puloInfinito;

    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(puloInfinito, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    