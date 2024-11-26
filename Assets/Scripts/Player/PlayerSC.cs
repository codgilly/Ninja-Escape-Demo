using UnityEngine;

public class PlayerSC : MonoBehaviour
{
    public bool up,down,left,right;

    Rigidbody2D rb;
    SpriteRenderer sr;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.fixedDeltaTime = 1f / 60f * Time.timeScale;
        rb.linearVelocity = new Vector2(0, 0);
        if (up)
        {
            Walking();
            sr.transform.rotation = Quaternion.Euler(0, 0, -90);
            rb.linearVelocity = new Vector2(0, 4);

        }
        if (down)
        {
            Walking();
            sr.transform.rotation = Quaternion.Euler(0, 0, 90);
            rb.linearVelocity = new Vector2(0, -4);
        }
        if (left)
        {
            Walking();
            sr.transform.rotation = Quaternion.Euler(0, 0, 0);
            rb.linearVelocity = new Vector2(-4, 0);
        }
        if (right)
        {
            Walking();
            sr.transform.rotation = Quaternion.Euler(0, 0, 180);
            rb.linearVelocity = new Vector2(4, 0);
        }

       
        //up = false;
        //down = false;
        //left = false;
        //right = false;

    }

    public void Walking()
    {
        anim.SetBool("walking", true);
    }

    public void StopWalking()
    {
        anim.SetBool("walking", false);
    }
}
