using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BirdCollision : MonoBehaviour
{
    public Rigidbody Player;
    public Text Score;
    public AudioSource Music;

    void OnCollisionEnter(Collision info)
    {
        Score.text="Hit!";
        Music.volume = 0.5f;
        Score.color = Color.red;
        Player.mass = 100;
        Invoke("Over",5);
    }

    void Over()
    {
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(1);
    }
}