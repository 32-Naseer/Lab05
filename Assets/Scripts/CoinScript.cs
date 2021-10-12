using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreCount == 60)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (scoreCount != 60)
            {
                Destroy(gameObject);
                scoreCount += 10;
                scoreText.text = "Score: " + scoreCount;
                Instantiate(particle, gameObject.transform.position, Quaternion.identity);
            }
        }
    }

}
