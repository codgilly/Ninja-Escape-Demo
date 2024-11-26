using UnityEngine.EventSystems;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject star;
    public bool lef, rig, up,dow, shot;
    public Vector2 direction;

    public Animator anim;

    
    void Start()
    {
        star.GetComponent<StarGameSC>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //Shoot();

        if(lef == true)
        {
            direction = Vector2.left;
        }
        if (rig == true)
        {
            direction = Vector2.right;
        }
        if (up == true)
        {
            direction = Vector2.up;
        }
        if (dow == true)
        {
            direction = Vector2.down;
        }
        rig = false; up = false; dow = false; lef = false;

    }
    public void Shoot()
    {
        //anim.Play("star");
        star.SetActive(true);
        shot = true;
        //change so it is way the player faces
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction);
        Debug.Log(hit.collider);
        Debug.DrawRay(transform.position, direction, Color.yellow);

        if (hit)
        {
            print(hit.collider);

        }
        star.transform.position = this.transform.position;
    }

}
