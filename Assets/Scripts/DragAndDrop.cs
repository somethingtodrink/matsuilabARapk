using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


// ドラッグとドロップに関するインターフェースを実装する
public class DragAndDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{
    // ドラッグ前の位置
    //private Vector2 prevPos;
    //RectTransform rect;
    private void Awake()
    {
        //rect = this.GetComponent<RectTransform>();
        //rect.localPosition = new Vector3(PlayerPrefs.GetFloat("X", 0.0f), PlayerPrefs.GetFloat("Y", 0.0f), 0);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // ドラッグ前の位置を記憶しておく
        //prevPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // ドラッグ中は位置を更新する
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        //Vector3 savePos = transform.position;
        //savePos = transform.InverseTransformPoint(savePos);
        //PlayerPrefs.SetFloat("X", savePos.x);
        //PlayerPrefs.SetFloat("Y", savePos.y);
        //PlayerPrefs.Save();
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        /*
        var raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);

        foreach (var hit in raycastResults)
        {
            // もし DroppableField の上なら、その位置に固定する
            if (hit.gameObject.CompareTag("DroppableField"))
            {
                transform.position = hit.gameObject.transform.position;
                this.enabled = false;
            }
        }
         */
    }
    
}