using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject videoObject;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        videoObject.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        videoObject.SetActive(false);
    }

    void Awake () {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
}
