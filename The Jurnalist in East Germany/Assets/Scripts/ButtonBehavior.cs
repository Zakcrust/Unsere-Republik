using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float pointerOffsetX;
    public float pointerOffsetY;
    public GameObject pointer;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        pointer.SetActive(true);
        pointer.transform.position = new Vector3(this.transform.position.x - pointerOffsetX, this.transform.position.y + pointerOffsetY, this.transform.position.z);
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        pointer.SetActive(false);
    }
}
