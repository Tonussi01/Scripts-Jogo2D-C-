using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[System.Serializable]
	public class Level
	{
		public string levelText;
		public bool habilitado;
		public int desbloqueado;
		public bool txtAtivo;
		public GameObject botao;
	}

	public List<Level> levelList;

	void ListaAdd()
	{
		int i = 1;
		foreach (Level level in levelList)
		{
			GameObject btnNovo = GameObject.Find("BtMap"+i);
			BtLevel btnNew = btnNovo.GetComponent<BtLevel>();
			btnNew.levelTxtBTN.text = level.levelText;

			if (PlayerPrefs.GetInt("Fase" + btnNew.levelTxtBTN.text) == 1)
			{
				level.desbloqueado = 1;
				level.habilitado = true;
				level.txtAtivo = true;
			}
			btnNew.desbloqueadoBtn = level.desbloqueado;
			btnNew.GetComponent<Button>().interactable = level.habilitado;
			btnNew.GetComponentInChildren<Text>().enabled = level.txtAtivo;
			btnNew.GetComponent<Button>().onClick.AddListener(() => ClickLevel("Fase " + btnNew.levelTxtBTN.text));
			i++;
		}
	}

	void ClickLevel(string level)
	{
		SceneManager.LoadScene(level);
	}

	void Awake()
	{
		Destroy(GameObject.Find("UiManager(Clone)"));
		Destroy(GameObject.Find("GameManager(Clone)"));
	}

	void Start()
    {
		ListaAdd();
    }

    void Update()
    {
        
    }
}
