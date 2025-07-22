using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void GoToScene(int number)
    {
        SceneManager.LoadScene(number);
    }
}