using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameStartPanel;
    [SerializeField] GameObject gameEndPanel;

    void Start()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        gm.AddEventToGameStart(DisableStartMenu);
        gm.AddEventToGameEnd(EnableEndMenu);
    }    

    void EnableEndMenu()
    {
        gameEndPanel.SetActive(true);
    }

    void DisableStartMenu()
    {
        gameStartPanel.SetActive(false);
    }
}
