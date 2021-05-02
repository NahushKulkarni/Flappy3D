using UnityEngine;

public class Keys : MonoBehaviour
{
    public Rigidbody Player;
    public Vector3 UpForce;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            Player.AddForce(UpForce);
        }
    }
}
