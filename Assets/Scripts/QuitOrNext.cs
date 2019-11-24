using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitOrNext : MonoBehaviour
{

	private void Update()
	{
	    if (Input.GetKeyUp(KeyCode.Escape))
	    {
	        Application.Quit();
	    }
	}
	    
	private void OnTriggerEnter2D(Collider2D collision)
	{
	    if (collision.tag.Equals("Lady"))
	    {
	        SceneManager.LoadScene("LevelComplete");
	    }
	}

}
