using UnityEngine;
using System.Collections;

public class Secciones : MonoBehaviour {


	public Animator[] secciones;

	void Start()
	{
		StartCoroutine(ToggleSecciones());
	}


	IEnumerator ToggleSecciones()
	{
		for(int i = 0; i < secciones.Length; i++)
		{
			secciones[i].SetTrigger("activar");
			yield return new WaitForSeconds(0.1f);

		}
	}
	

}
