using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {

    [SerializeField]
    private int levelNo = 0;
    
	public void loadLevel ()
    {
        SceneManager.LoadScene(levelNo);
    }

}
