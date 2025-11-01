using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    public void SwitchToScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
   
}
