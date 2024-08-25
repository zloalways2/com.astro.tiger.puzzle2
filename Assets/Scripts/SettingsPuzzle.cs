using UnityEngine;

public class SettingsPuzzle : MonoBehaviour
{

    [SerializeField] Lean.Gui.LeanToggle musicTogglePuzzle;
    [SerializeField] Lean.Gui.LeanToggle soundsTogglePuzzle;

    void Start()
    {
        musicTogglePuzzle.On = PlayerPrefs.GetString("musicPuzzle", "1") == "1";
        soundsTogglePuzzle.On = PlayerPrefs.GetString("soundsPuzzle", "1") == "1";
    }

    public void onMusicPuzzzle()
    {
        PlayerPrefs.SetString("musicPuzzle", "1");
        PlayerPrefs.Save();
    }

    public void offMusicPuzzzle()
    {
        PlayerPrefs.SetString("musicPuzzle", "0");
        PlayerPrefs.Save();
    }

    public void onSoundsPuzzzle()
    {
        PlayerPrefs.SetString("soundsPuzzle", "1");
        PlayerPrefs.Save();
    }

    public void offSoundsPuzzzle()
    {
        PlayerPrefs.SetString("soundsPuzzle", "0");
        PlayerPrefs.Save();
    }
}
