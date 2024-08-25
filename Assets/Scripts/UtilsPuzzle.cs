using UnityEngine;
using UnityEngine.SceneManagement;

public class UtilsPuzzle : MonoBehaviour
{
    public void OpenSettingsPuzzle()
    {
        counter++;
        SceneManager.LoadScene(2);
    }

    private int counter = 0;

    public void OpenMenuPuzzle()
    {
        counter--;
        SceneManager.LoadScene(1);
    }
}
