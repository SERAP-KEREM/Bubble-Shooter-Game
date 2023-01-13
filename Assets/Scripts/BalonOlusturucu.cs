using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = this.gameObject.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katSayi = (int)(gameManager.zamanSayaci / 10) - 6;
        katSayi *= -1;
        if (zamanSayaci < 0 && gameManager.zamanSayaci > 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.75f, 2.75f), -6f, 0), Quaternion.Euler(0, 0, 0));
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f*katSayi, 80f*katSayi), 0));
            zamanSayaci = balonOlusturmaSuresi;
        }


    }
}
