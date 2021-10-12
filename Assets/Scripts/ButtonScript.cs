using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameLoseScene")
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (SceneManager.GetActiveScene().name == "GameWinScene")
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Restart()
    {
        // 0 = GameScene
        SceneManager.LoadScene(0);
    }
}
