using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

	Vector3 inputVector;
	Image backGroundImage;
	Image joystickImage;

	void Awake()
	{
		backGroundImage = GetComponent<Image>();
		joystickImage = transform.GetChild(0).GetComponent<Image>();
	}

	public void OnDrag(PointerEventData eventData)
	{
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle(backGroundImage.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
		{
			pos.x /= backGroundImage.rectTransform.sizeDelta.x / 2;
			pos.y /= backGroundImage.rectTransform.sizeDelta.y / 2;

			inputVector = new Vector3(pos.x, 0, pos.y);
			inputVector = (inputVector.magnitude > 1) ? inputVector.normalized : inputVector;

			//print(inputVector);
			joystickImage.rectTransform.anchoredPosition = new Vector3(inputVector.x * (backGroundImage.rectTransform.sizeDelta.x / 2),
																	   inputVector.z * (backGroundImage.rectTransform.sizeDelta.y / 2));
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		OnDrag(eventData);	
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		inputVector = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;
	}

	public float Horizontal()
	{
		if (inputVector.x != 0)
			return inputVector.x;
		else
			return Input.GetAxis("Horizontal");
	}

	public float Vertical()
	{
		if (inputVector.z != 0)
			return inputVector.z;
		else
			return Input.GetAxis("Vertical");
	}

}
