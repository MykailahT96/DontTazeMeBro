using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public InputField textBox;
    public Dropdown lifeTotal;

    public void StartGame()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void saveName()
    {
        PlayerPrefs.SetString("playerName", textBox.text);
        Debug.Log(PlayerPrefs.GetString("playerName"));
    }
    public void setLifeTotal()
    {
        switch(lifeTotal.value)
        {
            case 0:
                PlayerPrefs.SetInt("totalLives", 1);
                break;

            case 1:
                PlayerPrefs.SetInt("totalLives", 2);
                break;

            case 2:
                PlayerPrefs.SetInt("totalLives", 3);
                break;
        }
        Debug.Log(PlayerPrefs.GetInt("totalLives"));
    }
}
