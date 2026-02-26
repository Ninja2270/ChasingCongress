using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetMasterLvl(float masterlvl)
    {
        masterMixer.SetFloat("MasterVol", masterlvl);
    }

    public void SetSFXLvl(float sfxlvl)
    {
        masterMixer.SetFloat("SFXVol", sfxlvl);
    }

    public void SetMusicLvl(float musiclvl)
    {
        masterMixer.SetFloat("MusicVol", musiclvl);
    }
}
