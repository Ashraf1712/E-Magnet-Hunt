using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour
{
    public string roomName;
    public ToTheNextScene clickScene;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if(hit.collider.gameObject.name == "KeyImage")
                {
                    clickScene.SceneName = roomName;
                    clickScene.onClick();
                }
            }
        }
    }
}
