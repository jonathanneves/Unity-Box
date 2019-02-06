using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{

	bool slot1 = false;

	public void OnPointerEnter(PointerEventData eventData){

	}

	public void OnPointerExit(PointerEventData eventData){
		
	}

	public void OnDrop (PointerEventData eventData){
		Debug.Log(eventData.pointerDrag.name + " was dropped on "+ gameObject.name);
		DragNDrop d = eventData.pointerDrag.GetComponent<DragNDrop>();
		if(d != null){
			CraftZone.instance.Remove(eventData.pointerDrag.GetComponent<CardDisplay>().card);
			d.parentToReturnTo = this.transform;
		}
	}
}
