using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public Text NameBox;
    public Text LifeBox;
    
    // Start is called before the first frame update
    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("playerName");
        
    }

    // Update is called once per frame
    void Update()
    {
        int lifeCount = PlayerPrefs.GetInt("totalLives");
        LifeBox.text = lifeCount.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void EndScene()
    {
        SceneManager.LoadScene("EndGame");
    }
}
