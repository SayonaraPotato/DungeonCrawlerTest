using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("MainScene");
    }   
    
    public void ExitPressed()
    {

    }
}
