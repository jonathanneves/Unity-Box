using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftResult : MonoBehaviour {

	public Craft[] craft;
	Card item1;
	Card item2;

	Card resultado;
	public GameObject[] final;
	public Text nomeText;
	public Text descricaoText;
	public Image imageSprite;
	public Transform panel;
	private bool waiting = false;

	void Update(){
		if(CraftZone.instance.totalLista() == 2 && !waiting){
			Crafting();
		}
	}

	public void Crafting(){
		waiting = true;
		item1 = CraftZone.instance.cards[0];
		item2 = CraftZone.instance.cards[1];
		for(int i=0; i<craft.Length; i++){
			if((item1 == craft[i].card1 && item2 == craft[i].card2) || (item2 == craft[i].card1 && item1 == craft[i].card2)){
				resultado = craft[i].result;
				//final.GetComponent<CardDisplay>().card = resultado;
				//final.GetComponent<Image>().sprite = resultado.artwork;
				nomeText.text = "Nome: "+resultado.cardName;
				Debug.Log("Nome: "+resultado.cardName);
				descricaoText.text = "Descrição: "+resultado.description;
				imageSprite.sprite =  resultado.artwork;
				GameObject obj =  (GameObject)Instantiate(final[i]);
				obj.transform.SetParent(panel.transform, false);
				CraftZone.instance.EstaCheio();		
			}
		}
		CraftZone.instance.EstaCheio();
		CraftZone.instance.EstaCheio();
		waiting = false;
	}
}
