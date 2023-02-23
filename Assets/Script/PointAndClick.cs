using UnityEngine;
using UnityEngine.SceneManagement;

public class PointAndClick : MonoBehaviour
{
    [SerializeField] string gameRoomSceneName;
    [SerializeField] GameObject RoomGameObject;
    public ToTheNextScene clickScene;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.name == RoomGameObject.gameObject.name)
                {
                    clickScene.SceneName = gameRoomSceneName;
                    clickScene.onClick();
                }
            }
        }
    }
}
