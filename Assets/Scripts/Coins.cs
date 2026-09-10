using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coins : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;
        ScoreManager.Instance.AddScore(1);

        Destroy(gameObject);
    }


}
