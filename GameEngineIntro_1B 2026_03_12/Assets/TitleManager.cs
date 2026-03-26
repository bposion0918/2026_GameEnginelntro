using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    public void Buttonlog()
    {
        Debug.Log("BUTTON CLICKED!");
    }
}
