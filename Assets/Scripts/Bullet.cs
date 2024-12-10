using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletStrength = 20f;
    [SerializeField] float timeToDestroy = 5f;

    void Start()
    {
        Invoke("DestroyThis", timeToDestroy);
    }
    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
