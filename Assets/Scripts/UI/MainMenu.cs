using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject plot;
    public bool plotBool;

    private int nextSceneToLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        plotBool = false;

        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlotPoint()
    {
        if (plotBool == false)
        {
            plotBool = true;
            plot.SetActive(true);
        }
        else
        {
            plot.SetActive(false);
            plotBool = false;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
