using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    private AudioSource music;
    [SerializeField] private int n = 0;
    [SerializeField] private int nx = 0;
    [SerializeField] private string level = "FirstLevel";
    [SerializeField] private bool saveAddon = false;
    private void Update()
    {
        if (n != 0 && DropdownController.Controller == "PS")
        {
            Prepare(n, 1, "Cross");
            Prepare(n, 2, "Round");
            Prepare(n, 3, "Triangle");
            Prepare(n, 4, "Square");
            Prepare(n, 8, "Menu");
            Prepare(n, 9, "Option");
        }
        if (nx != 0 && DropdownController.Controller == "XBOX")
        {
            Prepare(nx, 1, "B");
            Prepare(nx, 2, "X");
            Prepare(nx, 3, "Y");
            Prepare(nx, 4, "A");
            Prepare(nx, 8, "MenuXB");
            Prepare(nx, 9, "Option");
        }
    }
    private void Prepare(int var,int need,string button)
    {
        if (var == need)
        {
            if (Input.GetButtonDown(button))
            {
                StartGame();
            }
        }
    }
    public void StartGame()
    {
        if (!saveAddon)
        {
            SceneManager.LoadScene(level);
        }
        if (saveAddon)
        {
            if (LoadSavedLevel.IsContinue())
            {
                SceneManager.LoadScene(SaveSystem.level);
            }
            else
            {
                SceneManager.LoadScene(level);
            }
        }
    }
}
//1 - cross  //2 round //3 triangle //4 square //8 menu button //9 Options