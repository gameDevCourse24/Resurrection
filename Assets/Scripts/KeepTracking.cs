using UnityEngine;

public class KeepTracking : MonoBehaviour
{
    [SerializeField, Tooltip("The Player Tag")] string playerTag = "Player";
    private bool keepTracking = false;

    public void ChengeKeepTrackingTo(bool val)
    {
        keepTracking = val;
    }
    // Update is called once per frame
    void Update()
    {
        if (keepTracking)
        {
            GameObject player = GameObject.FindGameObjectWithTag(playerTag);
            if (player != null)
            {
                Mover mover = GetComponent<Mover>();
                if (mover != null)
                {
                    mover.atackThePlayer();
                }
            }
        }
    }
}
