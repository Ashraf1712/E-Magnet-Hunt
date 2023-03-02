using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    [SerializeField] GameObject CongratulationPrefabs;
    [SerializeField] BoxCollider2D fuseCollider;
    private bool congratsSoundPlayed = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "Fuse" && !congratsSoundPlayed)
                {
                    AudioManager audioManager = FindObjectOfType<AudioManager>();
                    if (audioManager != null)
                    {
                        audioManager.playCongratsSound();
                    }
                    CongratulationPrefabs.SetActive(true);
                    congratsSoundPlayed = true;
                }
            }
        }
    }
}
