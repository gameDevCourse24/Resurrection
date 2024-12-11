using UnityEngine;

public class AreaScript : MonoBehaviour
{
    [SerializeField] string trigerTag = "Player";
    [SerializeField] GameObject[] objectsInArea;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(trigerTag))
        {
            Debug.Log(trigerTag + " entered the area.");
            foreach (GameObject obj in objectsInArea)
            {
                if (obj != null && obj.GetComponent<Mover>() != null)
                {
                    obj.GetComponent<Mover>().atackThePlayer();
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag(trigerTag))
        {
            foreach (GameObject obj in objectsInArea)
            {
                if (obj != null && obj.GetComponent<Mover>() != null)
                {
                    obj.GetComponent<Mover>().atackThePlayer();
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(trigerTag))
        {
            foreach (GameObject obj in objectsInArea)
            {
                if (obj != null && obj.GetComponent<KeepTracking>() != null)
                {
                    obj.GetComponent<KeepTracking>().ChengeKeepTrackingTo(true);
                }
            }
        }
    }
}
