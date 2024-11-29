using UnityEngine;
using UnityEngine.Diagnostics;

public class crash : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("FCrash", 3f);
    }

    void FCrash()
    {
        Utils.ForceCrash(ForcedCrashCategory.Abort);
        //Application.ForceCrash(0);
    }
}
