using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody m_rb;

    // Use this for initialization
    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        m_rb.AddForce(new Vector3(movement, 0.0F, 0.0F));
    }
}
 