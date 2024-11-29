using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTest : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody2D rb;
    public Transform target;
    Vector2 moveDirection;
    public bool dead = false;
    Animation anim;
    Animator anim2;

    bool hitB;

    Vector2 facing;

    public Transform[] patrolPoints;
    int patrolDestination;

    LayerMask lm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitB = false;
        rb = GetComponent<Rigidbody2D>();
        lm = LayerMask.GetMask("Player");
        print(lm.value);

       // coli = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion leftRayRotation;
        leftRayRotation = Quaternion.AngleAxis(45, Vector3.up);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, facing, 6, lm);

        Debug.DrawRay(transform.position, facing, Color.blue, 6);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.tag);

            if(hit.transform.CompareTag("Walls"))
            {
                return;
            }
            if (hit.transform.CompareTag("Player"))
            {
                //voice line
                Invoke("Caught", 1.5f);
                Debug.Log("hit");
            }
        }
        

        //print(hit.transform.tag);

        if (patrolDestination == 0)
        {
            facing = Vector2.right;
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, speed * Time.deltaTime);
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 10000);

            if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                //transform.Rotate(0, 0, 0);
                patrolDestination = 1;
            }
        }
        if (patrolDestination == 1)
        {
            facing = Vector2.left;
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, speed * Time.deltaTime);
            Quaternion target = Quaternion.Euler(0, 0, 180);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 10000);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                patrolDestination = 0;
            }
        }
    }

    void Caught()
    {
        if(dead == false)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
