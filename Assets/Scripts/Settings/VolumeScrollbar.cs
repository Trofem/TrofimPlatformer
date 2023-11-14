using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeScrollbar : MonoBehaviour
{

    public Slider volumeSl;
    public Text VolumeText;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 0.5f);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void SetVolume(float volume)
    {
        AudioListener.volume = volumeSl.value;
        Debug.Log(AudioListener.volume);
        VolumeText.text = "Volume = " + Mathf.Round(AudioListener.volume * 10000.0f) * 0.01f + ".";
    }
    private void Load()
    {
        volumeSl.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSl.value);
    }
}
