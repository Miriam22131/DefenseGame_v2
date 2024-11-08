using UnityEngine;

public class SnowPile : PlacedBuildingBase
{
    public float slowdownFactor = 0.5f;
    public float slowdownDuration = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.SlowDown(slowdownFactor, slowdownDuration);
            }
        }
    }
}

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float originalSpeed;

    private void Start()
    {
        originalSpeed = speed;
    }

    public void SlowDown(float factor, float duration)
    {
        speed *= factor;
        Invoke("ResetSpeed", duration);
    }

    private void ResetSpeed()
    {
        speed = originalSpeed;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}