using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class scrLuke : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public int moveSpeed;
    private float direction;

    private Vector3 facingRight;
    private Vector3 facingLeft;
    public bool taNochao;
    public Transform detactaChao;
    public LayerMask oQueehChao;
   
    
    void Start()
    {
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = facingLeft.x * -1;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("Tacorrendo", true);
        }else 
        {
            animator.SetBool("Tacorrendo", false);
        }

         taNochao = Physics2D.OverlapCircle(detactaChao.position, 0.2f, oQueehChao);

        if (Input.GetButtonDown("Jump") && taNochao == true)

        {
            rb.velocity = Vector2.up * 11;
            animator.SetBool("Tapulando", true);
        }
        if(taNochao && rb.velocity.y == 0)
        {
             animator.SetBool("Tapulando", false);
        }
        direction = Input.GetAxis("Horizontal");

        if(direction > 0)
        {
            transform.localScale = facingRight;
        }
        if(direction < 0)
        {
            transform.localScale = facingLeft;
        }
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
      
    }

    
}
