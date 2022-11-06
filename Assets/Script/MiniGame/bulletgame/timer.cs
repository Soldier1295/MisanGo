using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
	// Start is called before the first frame update
	public Text counterText;
	public bool timeCounter = true;
	public float seconds, minutes;
	public float begin = 0f;

	// Use this for initialization
	void Start()
	{
		counterText = GetComponent<Text>() as Text;
		begin = 10f;
	}
	// Update is called once per frame
	void Update()
	{

		time();
		if (timeCounter)
		{
			seconds = (int)(begin);
			counterText.text = "�����ð�" + " : " + begin.ToString("00");

		}
	}

	public void time()
	{
		begin -= Time.deltaTime;

		if (begin < 0)
		{
			//Ŭ���� ����ȯ
			DataMgr.instance.shooting = true;
			GameManager.instance.ShootingGameClear = true;
			GameManager.instance.gameCheck();
			SceneManager.LoadScene("Game1_Scene");
			AudioManager.instance.missionBackgroundAudioStop();
			AudioManager.instance.mainAudioStart();

			timeCounter = false;
			counterText.color = Color.green;
			counterText.text = "Clear!";
		}
	}
}
