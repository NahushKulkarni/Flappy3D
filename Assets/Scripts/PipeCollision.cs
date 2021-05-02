using UnityEngine;

public class PipeCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision info)
    {
        if (info.collider.CompareTag("Pipe"))
        {
            GameObject CollisionObject = info.collider.gameObject;
            Destroy(CollisionObject);
        }
    }
}
