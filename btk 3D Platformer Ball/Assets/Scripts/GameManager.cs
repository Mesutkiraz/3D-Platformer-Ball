using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerControl playerControl;
    [SerializeField] private float delayTime=2f;
    private bool isGameEnding=false;
    private int score;
    public Text scoreText;
    public Text WinText;
    public GameObject LevelUpPanel;
    void Start()
    {
        playerControl = FindObjectOfType<PlayerControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnEt()
    {
        if (isGameEnding==false)
        {
            isGameEnding = true;
        StartCoroutine(RespawnDelay());

        }
    }

    private IEnumerator RespawnDelay()
    {
        playerControl.gameObject.SetActive(false);
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //playerControl.transform.position = playerControl.spawnPoint;
        //playerControl.gameObject.SetActive(true);
        isGameEnding = false;
    }
    public void ScoreAdd(int numberOfScore)
    {
        score += numberOfScore;
        scoreText.text = score.ToString();
    }
    public void LevelUp()
    {
        LevelUpPanel.SetActive(true);
        WinText.text = "Seviye Tamamlandý Toplam Puan: " + score;
        Invoke("NextLevel", 2f);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
