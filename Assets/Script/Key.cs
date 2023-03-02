using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject CongratulationPrefabs;
    private bool congratsSoundPlayed = false;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == "KeyImage" && !congratsSoundPlayed)
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
