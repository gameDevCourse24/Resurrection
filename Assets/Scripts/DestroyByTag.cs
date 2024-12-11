using UnityEngine;

public class DestroyByTag : MonoBehaviour
{
    [SerializeField] string tagToBeDestroyBy;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagToBeDestroyBy))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Debug.Log(this.gameObject.name + " destroyed by " + other.name + " with tag " + tagToBeDestroyBy);
        }
    }
}
