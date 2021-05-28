using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pointText;
    private int points = 0;

    // Update is called once per frame
    void Update()
    {
        pointText.text = "score : " + points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Rocket")
        {
            points += 1;
            Destroy(other.gameObject);
        }    
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
