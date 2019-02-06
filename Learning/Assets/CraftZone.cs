using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CraftZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{

	public int slot = 2;

	public static CraftZone instance;
	public List<Card> cards = new List<Card>();

	public Transform panel;

	void Awake()
	{
		if(instance != null)
			return;

		instance = this;
	}


	public void Add (Card card)
	{
		if(cards.Count >= slot){
			Debug.Log("INVENTARIO CHEIO");
			return;
		}
		Debug.Log("Adicionado");
		cards.Add(card);
		return;
	}

	public void Remove (Card card)
	{
		Debug.Log("Removido");
		cards.Remove(card);
	}

	public void EstaCheio()
	{
		cards.Clear();
		foreach (Transform child in transform)
		{
			Debug.Log("Limpa");
			child.transform.SetParent(panel.transform, false);
		}
//		this.transform.GetChild(0).SetParent(panel.transform, false);
		//this.transform.GetChild(0).SetParent(panel.transform, false);
	}

	public void OnPointerEnter(PointerEventData eventData){

	}

	public void OnPointerExit(PointerEventData eventData){
		
	}

	public void OnDrop (PointerEventData eventData){
		DragNDrop d = eventData.pointerDrag.GetComponent<DragNDrop>();
			if(d != null && totalLista() < slot){
				this.Add(eventData.pointerDrag.GetComponent<CardDisplay>().card);
				d.parentToReturnTo = this.transform;
			}
		Debug.Log(totalLista());
	}

	public int totalLista(){
		return cards.Count;
	}
}

