using UnityEngine;
using UnityEngine.InputSystem;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class ClickSpawner : MonoBehaviour
{
    [SerializeField] private InputAction spawnAction = new InputAction(type: InputActionType.Button);
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] float speed;

    void Start()
    {
        spawnAction.Enable();
    }
    private void Update()
    {
        if (spawnAction.WasPressedThisFrame())
        {
            SpawnPrefabAtMousePosition();
        }
    }
    void SpawnPrefabAtMousePosition()
    {
        Debug.Log("spawn");
        GameObject newObject = Instantiate(prefabToSpawn, transform.position, transform.rotation);
        Rigidbody2D rb = newObject.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
    }
}
