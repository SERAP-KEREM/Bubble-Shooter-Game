using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    int patlayanBalon;
    public Text  balonText;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("+" + other.gameObject.name);
        //patlayanBalon -= 1;
        //balonText.text = "Balon : " + patlayanBalon;
        //Debug.Log(balonText.text);
        gameManager.BalonCikart();
    }
}
