using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Main : MonoBehaviour
{
    public Player player;
    public Image fire;
    public Sprite nonFire, isFire;
    public GameObject PauseScreen;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public SoundEffector soundEffector;
    public AudioSource musSource, soundSource;
    public GameObject Music;
    public GameObject[] objs1;


    

    private void Awake()
    {
        objs1 = GameObject.FindGameObjectsWithTag("Sound");
        if (objs1.Length == 0)
        {
            Music = Instantiate(Music); //создаем объект из префаба
            DontDestroyOnLoad(Music.gameObject); //Ответ на Ваш вопрос
        }
        else
        {
            Music = GameObject.Find("BGMusic"); //обращаемся к объекту, если он уже существует.
        }
    }
    public void ReloadLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }

    public void Start()
    {
        
        musSource.volume = PlayerPrefs.GetFloat("MusicVolume");
        soundSource.volume = PlayerPrefs.GetFloat("SoumdVolume");
        musSource = Music.GetComponent<AudioSource>();
    }

    public void PauseOn()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        PauseScreen.SetActive(true);
    }

    public void PauseOff()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        PauseScreen.SetActive(false);
    }

    public void Win()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        WinScreen.SetActive(true);
        if (!PlayerPrefs.HasKey("Lvl") || PlayerPrefs.GetInt("Lvl") < SceneManager.GetActiveScene().buildIndex)
        {
            PlayerPrefs.SetInt("Lvl", SceneManager.GetActiveScene().buildIndex -1);
            soundEffector.PlayWinS();
        }
        print(PlayerPrefs.GetInt("Lvl"));
    }

    public void Lose()
    {
        
        Time.timeScale = 0f;
        player.enabled = false;
        LoseScreen.SetActive(true);
        
    }

    public void MenuLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(0);
        
    }

    public void NextLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        
        transform.position = new Vector2(transform.position.x, transform.position.y);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
   public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(1);
        transform.position = new Vector2(transform.position.x, transform.position.y);        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    
}
