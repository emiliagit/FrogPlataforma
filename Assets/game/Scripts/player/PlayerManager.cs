using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravityMultiplier;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float extraRayHeight;
    private Vector2 moveDirection;
    private Rigidbody2D rb;
    private Animator animator;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {

        FlipSprite();
        SetAnimations();

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && IsGrounded())
            Jump();
    }

    private void FixedUpdate()
    {
        GravityCompensation();
        Movement();

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && IsGrounded())
            Jump();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        moveDirection = new(horizontalInput, 0f);

        transform.Translate(moveSpeed * Time.deltaTime * moveDirection.normalized);
    }

    private void FlipSprite()
    {
        //if (PlayerCombat.isAttacking) return;

        if (moveDirection.x > 0f)
            transform.localScale = new Vector3(5f, 5f, 1f);
        else if (moveDirection.x < 0f)
            transform.localScale = new(-5f, 5f, 1f);
    }

    private void Jump()
    {
        rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);

        animator.SetTrigger("Jump");
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, extraRayHeight, groundLayer);

        return raycastHit.collider != null;
    }

    private void GravityCompensation()
    {
        if (!IsGrounded())
            rb.AddForce(Vector2.down * gravityMultiplier, ForceMode2D.Force);

    }

    private void SetAnimations()
    {
        float xInput = moveDirection.x;
        float yInput = rb.velocity.y;

        if (xInput != 0f)
            animator.SetBool("Moving", true);
        else
            animator.SetBool("Moving", false);

        if (yInput == 0f)
            animator.SetBool("Grounded", true);
        else
            animator.SetBool("Grounded", false);
    }
}
