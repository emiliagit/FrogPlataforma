using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Camaleon : EnemyPadre
{

    [SerializeField] private int damage;
    [SerializeField] private float attackRange;
    [SerializeField] private float attackHitDelay;
    [SerializeField] private float attackTriggerDistance;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float extraDelayUntilSpriteFlip;
    public Animator animator;
    private float nextTimeToAttack;
    private float distanceToPlayer;


    private bool isAttacking;
    public Transform playerPosition;
    
    private Vector2 toPlayerDirection;

   
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
       
    }

    private void Update()
    {
        if (playerPosition == null) return;

        toPlayerDirection = playerPosition.position - transform.position;
        FlipSprite();

        distanceToPlayer = Vector2.Distance(transform.position, playerPosition.position);

        if (distanceToPlayer <= attackTriggerDistance && !isAttacking && Time.time >= nextTimeToAttack)
        {
            Debug.Log("player detectado");
            Attack();
        }

       


    }


    protected override void Attack()
    {
        nextTimeToAttack = Time.time + 1f / attackSpeed;

        animator.SetTrigger("Attack");
        Debug.Log(("atacando a player"));
        StartCoroutine(AttackAction());
    }


    private IEnumerator AttackAction()
    {
        isAttacking = true;
        yield return new WaitForSeconds(attackHitDelay);

        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);

        foreach (Collider2D player in hitPlayer)
        {
            if (player.TryGetComponent(out LifePlayer health))
            {
                Debug.Log("haciendo daño a player");
                health.TakeDamage(2);
            }

        }

        yield return new WaitForSeconds(extraDelayUntilSpriteFlip);

        isAttacking = false;
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    private void FlipSprite()
    {
        if (isAttacking) return;

        if (toPlayerDirection.x < 0f)
        {
            transform.localScale = new(3f, 3f, 3f);
        }
        else if (toPlayerDirection.x > 0f)
        {
            transform.localScale = new(-3f, 3f, 3f);
        }
    }

   



}
