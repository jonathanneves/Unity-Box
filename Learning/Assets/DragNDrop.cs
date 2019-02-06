using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	int slot = 0;
	public Transform parentToReturnTo = null;

	public void OnBeginDrag(PointerEventData eventData){
		//startPosition = GetComponent<RectTransform>().localPosition;
		parentToReturnTo = this.transform.parent;
		this.transform.SetParent(this.transform.parent.parent) ;

		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		if(gameObject.name == "Itens")
			slot++;
		if(gameObject.name == "Panel")
			slot--;
		this.transform.SetParent(parentToReturnTo);

		GetComponent<CanvasGroup>().blocksRaycasts = true;
	}
}
