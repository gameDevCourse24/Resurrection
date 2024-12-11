using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] string targetTag = "Player";
    [SerializeField] Vector3 offset = Vector3.zero;
    void Update()
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if (target != null)
        {
            transform.position = target.transform.position + offset;
        }
    }
}
