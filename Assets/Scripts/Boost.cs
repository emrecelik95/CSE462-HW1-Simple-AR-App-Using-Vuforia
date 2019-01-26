using UnityEngine;
using UnityEngine.EventSystems;

public class Boost : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject boost;
    public WheelDrive wheelDrive;

    public void OnPointerEnter(PointerEventData eventData)
    {
        wheelDrive.isBoosting = true;
        boost.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        wheelDrive.isBoosting = false;
        boost.SetActive(false);
    }
}
