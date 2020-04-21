using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public LayerMask groundlayer;
    public float jumpforce = 7.0f;
    public Rigidbody rb;
    public BoxCollider col;
    public Animator a;
    public bool isgrounded = true;

  
    void Start()
    {
       
    }


    void Update()
    {
        if(g() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            a.SetBool("jump", true);
        }
        else
        {
            a.SetBool("jump", false);
        }
    }
   
  public bool g()
    {
        float DisstanceToTheGround = GetComponent<Collider>().bounds.extents.y;

        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, DisstanceToTheGround + 0.1f);
        return (IsGrounded);
    }
}
