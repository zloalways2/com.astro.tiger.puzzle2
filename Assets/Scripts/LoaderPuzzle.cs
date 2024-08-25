using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderPuzzle : MonoBehaviour
{
    [SerializeField] ProgressBar progressBarPuzzle;
    float TimerPuzzle = 0;

    void Update()
    {
        if (Time.timeSinceLevelLoad >= TimerPuzzle)
        {
            TimerPuzzle = TimerPuzzle + 0.03f;
            progressBarPuzzle.BarValue += 1;
        }
        if (progressBarPuzzle.BarValue == 100)
        {
            SceneManager.LoadScene(1);
        }
    }
}
