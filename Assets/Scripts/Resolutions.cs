using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolutions : MonoBehaviour
{
    public TMPro.TMP_Dropdown ResolutionDropdown;
    public TMPro.TMP_Dropdown DiplayModeDropDown;
    public TMPro.TMP_Dropdown QualityDropDown;


    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height + " : " + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height && resolutions[i].refreshRate == Screen.currentResolution.refreshRate)

            {
                currentResolutionIndex = i;
            }

        }


        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = currentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();
    }

    public void SetDisplayMode(int displayIndex)
    {

        switch(displayIndex)
        {
            case 0:
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                break;

            case 1:
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                break;

            case 2:
                Screen.fullScreenMode = FullScreenMode.Windowed;
                break;

        }
        DiplayModeDropDown.value = displayIndex; 
    }

   
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen, resolution.refreshRate);
        ResolutionDropdown.value = (resolutionIndex);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        QualityDropDown.value = qualityIndex;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingsPreference", QualityDropDown.value);
        PlayerPrefs.SetInt("ResolutionPreference", ResolutionDropdown.value);
        PlayerPrefs.SetInt("DisplayMode", DiplayModeDropDown.value);

        Debug.Log("Settings have been saved");
    }

  
}
