using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider masterSlider;
    public Slider sfxSlider;
    public Slider musicSlider;


    public void Start()
    {
        float savedMasterVolume = PlayerPrefs.GetFloat("MasterVol", 0.75f);
        masterSlider.value = savedMasterVolume;
        SetMasterLvl(savedMasterVolume);

        float savedSFXVolume = PlayerPrefs.GetFloat("SFXVol", 0.75f);
        sfxSlider.value = savedSFXVolume;
        SetSFXLvl(savedSFXVolume);

        float savedMusicVolume = PlayerPrefs.GetFloat("MusicVol", 0.75f);
        musicSlider.value = savedMusicVolume;
        SetMusicLvl(savedMusicVolume);
    }

    public void SetMasterLvl(float masterlvl)
    {
        masterMixer.SetFloat("MasterVol", Mathf.Log10(masterlvl) * 20f);
        PlayerPrefs.SetFloat("MasterVol", masterlvl);
    }

    public void SetSFXLvl(float sfxlvl)
    {
        masterMixer.SetFloat("SFXVol", Mathf.Log10(sfxlvl) * 20f);
        PlayerPrefs.SetFloat("SFXVol", sfxlvl);
    }

    public void SetMusicLvl(float musiclvl)
    {
        masterMixer.SetFloat("MusicVol", Mathf.Log10(musiclvl) * 20f);
        PlayerPrefs.SetFloat("MusicVol", musiclvl);
    }
}
