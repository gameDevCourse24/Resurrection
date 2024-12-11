using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector2 offset = Vector2.zero;
    void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, -10);
    }
}
