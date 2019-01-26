using UnityEngine;
using UnityEngine.EventSystems;

public class ExtendJoystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler{

    public RectTransform joystick;

    private Vector3 orgJoyPos;

    public void OnPointerDown(PointerEventData eventData)
    {
        joystick.anchoredPosition = eventData.position;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        joystick.anchoredPosition = orgJoyPos;
    }

    private void Awake()
    {
        orgJoyPos = joystick.anchoredPosition;
    }

}
