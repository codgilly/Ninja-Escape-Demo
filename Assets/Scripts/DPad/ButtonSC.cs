using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSC : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public GameObject player;
    public GameObject stars;
    public float xv, yv;

    void Start()
    {
    }

    void Update()
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if( xv > 0 )
        {

            player.GetComponent<PlayerSC>().right = true;
            stars.GetComponent<Star>().rig = true;
        }
        if (xv < 0)
        {

            player.GetComponent<PlayerSC>().left = true;
            stars.GetComponent<Star>().lef = true;
        }
        if (yv > 0)
        {
            player.GetComponent<PlayerSC>().up = true;
            stars.GetComponent<Star>().up = true;
        }
        if (yv < 0)
        {
            player.GetComponent<PlayerSC>().down = true;
            stars.GetComponent<Star>().dow = true;
        }



    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (xv > 0)
        {
            player.GetComponent<PlayerSC>().right = false;
            player.GetComponent<PlayerSC>().StopWalking();
        }
        if (xv < 0)
        {
            player.GetComponent<PlayerSC>().left = false;
            player.GetComponent<PlayerSC>().StopWalking();
        }
        if (yv > 0)
        {
            player.GetComponent<PlayerSC>().StopWalking();
            player.GetComponent<PlayerSC>().up = false;
        }
        if (yv < 0)
        {
            player.GetComponent<PlayerSC>().StopWalking();
            player.GetComponent<PlayerSC>().down = false;
        }

    }
}
