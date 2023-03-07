using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenScroll : MonoBehaviour
{
    [SerializeField] GameObject GameObjectThing;
    [SerializeField] Animator _scrollAnim;
    [SerializeField] GameObject ScrollGO;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == GameObjectThing.gameObject.name)
                {
                    ScrollGO.SetActive(true);
                }
            }
        }
    }

    public void closeScroll()
    {
        ScrollGO.SetActive(false);
        _scrollAnim.SetTrigger("scroll");
    }
}
