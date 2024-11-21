using UnityEngine;
using UnityEngine.SceneManagement;




public class MainMenu : MonoBehaviour
{
    public void MapSelection()
    {
      
        SceneManager.LoadSceneAsync(1);
    }
    
    public void PlayMap1()
    {
       
        SceneManager.LoadSceneAsync(2);
    }

    public void PlayMap2()
    {
       
        SceneManager.LoadSceneAsync(3);
    }
    public void PlayMap3()
    {
      
        SceneManager.LoadSceneAsync(4);
    }
    public void PlayMap4()
    {
      
        SceneManager.LoadSceneAsync(5);
    }

    public void BackToMainMenu()
    {
      
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
       
        Application.Quit();
    }
}
