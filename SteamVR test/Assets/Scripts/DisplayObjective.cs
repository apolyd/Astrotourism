using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayObjective : MonoBehaviour
{
    //public Text nameLabel;
    public Camera UIcamera;
    public RectTransform canvas, nameLabel;

    void Update()
    {
        Vector3 namePos = UIcamera.WorldToViewportPoint(this.transform.position);
        //  nameLabel.transform.position = namePos;
        // canvas.anchorMin = namePos;
        // canvas.anchorMax = namePos;
        Vector2 ViewportPosition = UIcamera.WorldToViewportPoint(this.transform.position);
        Vector2 WorldObject_ScreenPosition = new Vector2(
        ((ViewportPosition.x * canvas.sizeDelta.x) - (canvas.sizeDelta.x * 0.5f)),
        ((ViewportPosition.y * canvas.sizeDelta.y) - (canvas.sizeDelta.y * 0.5f)));

        //now you can set the position of the ui element
        nameLabel.anchoredPosition = WorldObject_ScreenPosition;
    }
}
