using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Photograph : MonoBehaviour
{
    private int startingBattery = 100;
    public int currentBattery;
    public Slider batterySlider;
    public Image blinkImage;
    public AudioClip shooting;
    public float blinkSpeed = 30f;
    public Color flashColour = new Color(0f, 0f, 0f, 0.1f);
	public GameObject counter;

    AudioSource playerAudio;
    private bool isBatteryOver;//A bateria acabou?
    private bool camShot;//O botão da camera foi pressionado?
    public int amount = 5;

    GameObject animacao, inv;
	public GameObject framemanager;
	bool TirarFoto = false;
	public float ZoomSpeed = 5; 
	Vector3 pos;


    void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
        currentBattery = startingBattery;
    }

    void Update()
    {
        if (camShot)
            blinkImage.color = flashColour;
        else
            blinkImage.color = Color.Lerp(blinkImage.color, Color.clear, blinkSpeed * Time.deltaTime);

        camShot = false;

        GetInput();
		PreparacaoFoto ();
	}

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && TirarFoto ) {
			TirarFoto = false;
			other.gameObject.GetComponent<Objeto> ().descoberto = true;
			ObjetoIndoParaGaleria (other);
			indice = other.gameObject.GetComponent<Objeto> ().indiceTexto;
			counter.GetComponent<Score> ().addScore (other.GetComponent<Objeto> ().indiceTexto);//
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().newTxt (true, indice,false);;
		}
	}

	void ObjetoIndoParaGaleria(Collider2D other){
		animacao = Instantiate (other.gameObject);
		animacao.GetComponent<SpriteRenderer> ().sprite = null;
		animacao.transform.localScale += new Vector3 (-0.5f, -0.5f, 0);
		animacao.gameObject.GetComponent<Objeto> ().countdown = true;
		other.gameObject.GetComponent<FadeObjectInOut> ().FadeIn ();
		animacao.gameObject.GetComponent<FadeObjectInOut> ().FadeIn (4f);
	}

	void PreparacaoFoto(){
		if (Input.GetMouseButton(0) && transform.localScale.x > 0.9f) {
			transform.localScale -= new Vector3(ZoomSpeed,ZoomSpeed,1) * Time.deltaTime;
		} 
		if (!Input.GetMouseButton(0) && transform.localScale.x < 1f) {
			transform.localScale += new Vector3(ZoomSpeed/2,ZoomSpeed/2,1) * Time.deltaTime;
		}
		
		if (!TirarFoto && transform.localScale.x > 1f) {
			transform.localScale = new Vector3(1,1,1);
		}

	}

	void GetInput()
    {
		if (!Input.GetMouseButton(0)) {
			TirarFoto = false;
		}
		if (Input.GetMouseButtonUp (0)) {
			TirarFoto = true;
            TakeShot(amount);
        }
	}

    public void TakeShot(int amount)
    {
        camShot = true;
        currentBattery -= amount;
        batterySlider.value = currentBattery;
        playerAudio.Play();

        if (currentBattery <= 0 && !isBatteryOver)
            NoBattery();
    }

    void NoBattery()
    {
        isBatteryOver = true;
    }
}
