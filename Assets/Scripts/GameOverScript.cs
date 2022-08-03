using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameOverScript : MonoBehaviour
{
	
	private Button[] buttons;
	
	void Awake()
	{
		buttons = GetComponentsInChildren<Button>();
		
		HideButtons();
	}
	
	public void HideButtons()
	{
		foreach (var b in buttons)
		{
			b.gameObject.SetActive(false);
		}
	}
	
	public void ShowButtons()
	{
		foreach (var b in buttons)
		{
			b.gameObject.SetActive(true);
		}
	}
	
	public void ExitToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
	
	public void RestartGame()
	{
		SceneManager.LoadScene("Stage1");
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
