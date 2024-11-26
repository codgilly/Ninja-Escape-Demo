using UnityEngine;

public class TimeStop : MonoBehaviour
{
    public void TimeSlow()
    {
        Time.timeScale = 0.1f;
        Invoke("TimeContinue", 2f);

        StopAllCoroutines();
    }

    void TimeContinue()
    {
        Time.timeScale = 1f;
    }
}
