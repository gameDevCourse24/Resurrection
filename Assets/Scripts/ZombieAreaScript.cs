using UnityEngine;

public class ZombieAreaScript : MonoBehaviour
{
    [SerializeField] GameObject[] zombies;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the zombie area.");
            foreach (GameObject zombie in zombies)
            {
                if (zombie != null && zombie.GetComponent<Mover>() != null)
                {
                    zombie.GetComponent<Mover>().atackThePlayer();
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject zombie in zombies)
            {
                if (zombie != null && zombie.GetComponent<Mover>() != null)
                {
                    zombie.GetComponent<Mover>().atackThePlayer();
                }
            }
        }
    }

}
