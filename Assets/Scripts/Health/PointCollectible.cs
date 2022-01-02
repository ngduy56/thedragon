using UnityEngine;

public class PointCollectible : MonoBehaviour
{
    [SerializeField] private float pointValue;
    [SerializeField] private AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(pickupSound);
            collision.GetComponent<Point>().AddPoint(pointValue);
            gameObject.SetActive(false);
        }
    }
 

}
