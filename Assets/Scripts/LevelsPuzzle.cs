using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsPuzzle : MonoBehaviour
{
    private int levelPuzzle = 0;


    public void openGamePuzzle1()
    {
        levelPuzzle = 0;
        PlayerPrefs.SetInt(nameof(levelPuzzle), levelPuzzle);
        PlayerPrefs.Save();
        SceneManager.LoadScene(4);
    }

    public void openGamePuzzle2()
    {
        levelPuzzle = 1;
        PlayerPrefs.SetInt(nameof(levelPuzzle), levelPuzzle);
        PlayerPrefs.Save();
        SceneManager.LoadScene(4);
    }

    public void openGamePuzzle3()
    {
        levelPuzzle = 2;
        PlayerPrefs.SetInt(nameof(levelPuzzle), levelPuzzle);
        PlayerPrefs.Save();
        SceneManager.LoadScene(4);
    }

    public void openGamePuzzle4()
    {
        levelPuzzle = 3;
        PlayerPrefs.SetInt(nameof(levelPuzzle), levelPuzzle);
        PlayerPrefs.Save();
        SceneManager.LoadScene(4);
    }
}
