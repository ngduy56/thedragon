using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private float currentPoint, currentPointLevel, requirePoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentPointLevel = PlayerPrefs.GetFloat("Points", currentPoint);
        requirePoint = 9;
        Debug.Log(currentPointLevel);
        if (collision.tag == "Player" && currentPointLevel == requirePoint)
        {
            Debug.Log("You have va cham");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}