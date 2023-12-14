using UnityEngine;

public class AutoSidescroller : MonoBehaviour
{
    public float scrollSpeed = 5f;  // Adjust the speed as needed
    public Transform player;

    void Update()
    {
        // Move the camera to the right
        Camera.main.transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

        // Move the player to the right (optional)
        if (player != null)
        {
            player.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
        }
    }
}