using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene(0);
        }
    }
}
