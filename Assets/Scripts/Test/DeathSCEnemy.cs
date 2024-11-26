using UnityEngine;

public class DeathSCEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Animator enemyAnim;
    public Animator playeranim;

    public SpriteRenderer card;

    private void Start()
    {
        enemyAnim.GetComponent<Animator>();
        playeranim.GetComponent<Animator>();
        card.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Hidden"))
        {
            enemy.GetComponent<EnemyTest>().dead = true;
            enemyAnim.SetBool("stabbed", true);
            enemyAnim.Play("deathGuard");
            card.sortingOrder = 10;
            playeranim.Play("stabbing");
            Invoke("Death", 0.5f);
        }
    }

    public void Death()
    {
        enemy.SetActive(false);
    }
}
