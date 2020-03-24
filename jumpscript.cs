using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscript : MonoBehaviour
{

    public bool jump;
    public bool isground;
    public float jumppower;
    private Rigidbody rg;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }


    void Update()
    {
        jump = Input.GetButton("Jump");

        isground = Physics.Raycast(transform.position, Vector3.down, 2f);

        if (jump && isground)
        {
            rg.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
        }
    }

}
