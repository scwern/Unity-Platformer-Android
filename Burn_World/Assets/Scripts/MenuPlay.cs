using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPlay : MonoBehaviour
{
    public Button[] lvls;
    public Slider musicSl, SoundSl;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Lvl"))
          for (int i = 0; i < lvls.Length; i++)
        {
                if (i <= PlayerPrefs.GetInt("Lvl"))

                    lvls[i].interactable = true;
                else
                    lvls[i].interactable = false;

            }
           if (!PlayerPrefs.HasKey("MusicVolume"))        
         PlayerPrefs.SetFloat("MusicVolume", 1);
        if (!PlayerPrefs.HasKey("SoundVolume"))
          PlayerPrefs.SetFloat("SoundVolume", 1);

        musicSl.value = PlayerPrefs.GetFloat("MusicVolume");
        SoundSl.value = PlayerPrefs.GetFloat("SoundVolume");

    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume",musicSl.value);
        PlayerPrefs.SetFloat("SoundVolume", SoundSl.value);


    }

    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void DelKey()
    {
        PlayerPrefs.DeleteAll();
    }
}
