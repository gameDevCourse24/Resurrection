using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField, Tooltip("Add the objecy that you want this object will follow")] GameObject objectToFollow;

    void Update()
    {
        if (objectToFollow != null)
        {
            transform.position = objectToFollow.transform.position;
        }
    }
}
