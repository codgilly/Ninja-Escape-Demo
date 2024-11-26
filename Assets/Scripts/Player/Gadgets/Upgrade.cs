using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                player.transform.tag = "Hidden";
                player.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
                Invoke("UnHideon", 5f);
                this.gameObject.SetActive(false);
            }
        }
    }

    void UnHideon()
    {
        player.transform.tag = "Player";
        player.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, 1f);
    }
}
