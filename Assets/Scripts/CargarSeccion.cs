using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Contenido
{
	public string titulo;
	public string subtitulo;
	[TextArea(1, 15)]
	public string texto;

	[Header("Areas")]

	public bool txt;
	public bool imagen;
	public bool video;
	public bool audio;
	public bool _3d;
	public bool _360;

}

[System.Serializable]
public class PlaceHolders
{
	public Text titulo;
	public Text subtitulo;
	public Text txt;
	public GameObject iconoTxt, iconoImagen, iconoVideo, iconoAudio, icono3D, icono360;
}

public class CargarSeccion : MonoBehaviour {

	public PlaceHolders placeHolders = new PlaceHolders();
	public Contenido contenido = new Contenido();

	Animator anim;



	void Awake()
	{

		anim = GetComponent<Animator>();
		IniciarSeccion();

	}

	void IniciarSeccion()
	{
		// rellenar los contenidos
		placeHolders.titulo.text = contenido.titulo;
		placeHolders.subtitulo.text = contenido.subtitulo;
		placeHolders.txt.text = contenido.texto;

		// activar los iconos
		placeHolders.iconoTxt.SetActive(contenido.txt);
		placeHolders.iconoImagen.SetActive(contenido.imagen);
		placeHolders.iconoVideo.SetActive(contenido.video);
		placeHolders.iconoAudio.SetActive(contenido.audio);
		placeHolders.icono3D.SetActive(contenido._3d);
		placeHolders.icono360.SetActive(contenido._360);
	}

	public void Cargar()
	{

		anim.SetTrigger("cargar");
	}



	public void Volver()
	{
		anim.SetTrigger("volver");
	}




}
