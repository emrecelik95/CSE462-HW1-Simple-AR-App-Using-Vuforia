using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnOnDownGroundPos : MonoBehaviour {

    [SerializeField]
    private GameObject spawnee;

    [SerializeField]
    private float height = 2.0f;

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit) && !EventSystem.current.IsPointerOverGameObject())
        {
            spawnee.SetActive(false);
            Vector3 pos = hit.point;
            pos.y += height;
            spawnee.transform.position = pos;
            spawnee.transform.rotation = Quaternion.identity;
            spawnee.SetActive(true);
        }
    }

}
