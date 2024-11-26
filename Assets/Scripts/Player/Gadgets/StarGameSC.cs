using UnityEngine;

public class StarGameSC : MonoBehaviour
{
    public GameObject starButton;
    Rigidbody2D rb;
    public int speed;

    public GameObject enemy;
    private void Start()
    {
        starButton.GetComponent<Star>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        //print("dir=" + starButton.GetComponent<Star>().direction);
        if (starButton.GetComponent<Star>().shot == true)
        {
            print("Shot pressed!!!");
            if (rb.linearVelocity.magnitude == 0)
            {
                rb.linearVelocity = starButton.GetComponent<Star>().direction * speed;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(!collision.CompareTag("Player") || !collision.CompareTag("Hidden"))
            {
                enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, this.transform.position, 20);

                this.gameObject.SetActive(false);
            }
        }
  
        
    }
   
}
