using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Follow : MonoBehaviour
{
    public Camera Cam;
    public Transform Light;
    public Transform Player;
    public Rigidbody RigidPlayer;
    public Transform Grass;
    public Text Score;
    public Vector3 Offset;
    public Vector3 LightOffset;

    void Update()
    {
        Cam.transform.position = Player.position + Offset;
        Grass.transform.position.Set(-29.5f, Cam.transform.position.y, Cam.transform.position.z);
        Light.position = Player.position + LightOffset;
        if (Score.text.CompareTo("Hit!") != 0)
        {
            Score.text = "Score: " + ((int)Player.position.z - 9).ToString();
        }

        if (Player.position.y <= 0)
        {
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadScene(1);
        }    
    }
}
