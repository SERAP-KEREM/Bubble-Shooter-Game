using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text zamanText, balonText;
    public float zamanSayaci = 60;
    public GameObject patlama;
    int patlayanBalon = 0;


    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;

    }

    // Update is called once per frame
    void Update()
    {
        if(zamanSayaci>0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Süre : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Balon");
            for(int i=0;i<go.Length;i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }

    }
    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon : " + patlayanBalon;

    }
    public void BalonCikart()
    {
        Debug.Log("hjhuk");
        patlayanBalon -= 1;
        balonText.text = "Balon : " + patlayanBalon;
        Debug.Log(balonText.text);

    }
}
