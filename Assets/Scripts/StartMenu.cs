using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private TMP_InputField nameInputField;

    public static string playerName = "Player";

    void Start()
    {
        this.startButton.onClick.AddListener(StartGame);
        this.nameInputField.text = playerName;
    }

    private void StartGame()
    {
        playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
