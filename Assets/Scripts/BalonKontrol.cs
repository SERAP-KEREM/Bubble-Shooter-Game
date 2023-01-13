using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama;

    GameManager gameManager;
    int patlayanBalon = 0;
    private void Start()
    {
       
        gameManager = GameObject.Find("_Script").GetComponent<GameManager>();
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation);
        Destroy(this.gameObject);
        Destroy(go, 0.333f);

        gameManager.BalonEkle();
    }

}
