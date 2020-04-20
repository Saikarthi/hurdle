using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public LayerMask groundlayer;
    public float jumpforce = 7.0f;
    public Rigidbody rb;
    public BoxCollider col;
    public bool isgrounded = true;

  
    void Start()
    {
        
    }


    void Update()
    {
        if(g() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
   
  public bool g()
    {
        float DisstanceToTheGround = GetComponent<Collider>().bounds.extents.y;

        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, DisstanceToTheGround + 0.1f);
        return (IsGrounded);
    }
}
