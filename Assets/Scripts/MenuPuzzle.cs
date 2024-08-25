using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPuzzle : MonoBehaviour
{
    public void ExitPuzzle()
    {
        Application.Quit();
    }

    public void OpenLevelsPuzzle()
    {
        labelPuzzle = "levels";
        SceneManager.LoadScene(3);
    }
    private string labelPuzzle;
}
