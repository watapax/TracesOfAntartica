using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

	Text text;
	string textoActual;

	void Awake()
	{
		text = GetComponent<Text>();
		textoActual = text.text;
		text.text = "";
	}

	void Start()
	{
		StartCoroutine(FadeIn());
	}

	IEnumerator FadeIn()
	{
		string[] palabras = textoActual.Split(null);

		for(int i = 0; i < palabras.Length; i++)
		{
			text.text += palabras[i] + " ";
			yield return new WaitForSeconds(0.1f);
		}
	}

}
