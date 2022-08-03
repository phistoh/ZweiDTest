using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuScript : MonoBehaviour
{
	
	public void StartGame()
	{
		SceneManager.LoadScene("Stage1");
	}
	
	public void ExitGame()
	{
		Application.Quit();
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
