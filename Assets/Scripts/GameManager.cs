using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text inputPlayerNickname;
    string playerNickname = "Nickname";
    public TextMeshProUGUI playerNicknameUi;

    void Start()
    {
        playerNicknameUi.text = PlayerPrefs.GetString("playerNickname");
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        playerNickname = inputPlayerNickname.text;

        PlayerPrefs.SetString("playerNickname", playerNickname);
        PlayerPrefs.Save();

        playerNicknameUi.text = playerNickname;

        //SceneManager.LoadScene("sala");
    }
}
