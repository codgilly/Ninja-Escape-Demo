using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEscape : MonoBehaviour
{
    private int nextSceneToLoad;
    public SpriteRenderer card;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        card.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if(collision.CompareTag("Player") && card.sortingOrder == 10)
            {
                SceneManager.LoadScene(nextSceneToLoad);
                print("Won");
            }
        }
    }
}
