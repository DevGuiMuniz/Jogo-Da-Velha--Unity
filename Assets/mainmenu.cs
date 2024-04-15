using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SampleScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
