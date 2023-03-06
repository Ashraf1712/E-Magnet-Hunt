using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointAndClickSafe : MonoBehaviour
{
    [SerializeField] private GameObject closedSafeQuestion;
    [SerializeField] GameObject closedSafeName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == closedSafeName.name)
                {
                    closedSafeQuestion.SetActive(true);
                }

            }
        }
    }
}
