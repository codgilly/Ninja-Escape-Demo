using UnityEngine;

public class TimeStop : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }
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
