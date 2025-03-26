using UnityEngine;
using UnityEngine.UI;

public class MusicAndSoundController : MonoBehaviour
{
    public GameObject SoundToToggle;
    public Toggle toggleButton;

    public Toggle MuscicToggleButton;
    public AudioSource backgroundMusic;

    void Start()
    {
        toggleButton.onValueChanged.AddListener(ToggleObject);

        MuscicToggleButton.onValueChanged.AddListener(SetMusicOnAndOff);


    }

    void ToggleObject(bool isOn)
    {
        if (SoundToToggle != null)
        {
            SoundToToggle.SetActive(isOn);
        }
    }


    private void SetMusicOnAndOff(bool isOn)
    {
        if (backgroundMusic != null)
        {
            Debug.Log("get music value here : " + isOn);
            backgroundMusic.enabled = isOn;
        }
    }

}
