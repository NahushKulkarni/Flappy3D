using UnityEngine;

public class Obstruct : MonoBehaviour
{
    public Transform Player;
    public GameObject Obstracle;
    static float LastZ;

    private void Start()
    {
        LastZ = Player.position.z + 10;
    }

    void Update()
    {
        if (((int)(Time.time * 10f) % 10) == 0)
        {
            float RU = Random.Range(0, 2);
            float RD = Random.Range(0,2);
            GameObject PipeUp = Instantiate(Obstracle, new Vector3(0, 1f+RU, LastZ), Quaternion.identity) as GameObject;
            PipeUp.transform.localScale += new Vector3(0, RU, 0);
            GameObject PipeDown = Instantiate(Obstracle, new Vector3(0, 8f - RD, LastZ + 7.5f), Quaternion.identity) as GameObject;
            PipeDown.transform.localScale += new Vector3(0, RD, 0);
            PipeDown.transform.Rotate(new Vector3(0,0,180));
            LastZ += 15f;
        }
    }
}
