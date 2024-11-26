using UnityEngine;

public class SmokeBomb : MonoBehaviour
{
    public GameObject player;
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.enabled)
        {
            //anim.Play("smokeBomb");
            player.transform.tag = "Hidden";
            Invoke("Disapear", 3f);
        }

        if (!this.enabled)
        {
            
        }

    }

    void Disapear()
    {
        player.transform.tag = "Player";
        this.gameObject.SetActive(false);
    }
}
