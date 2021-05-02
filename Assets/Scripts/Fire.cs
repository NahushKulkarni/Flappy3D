using UnityEngine;

public class Fire : MonoBehaviour
{
    public Rigidbody Player;
    public Vector3 Force;

    void Update()
    {
        Player.AddForce(Force * Time.deltaTime);
    }
}
