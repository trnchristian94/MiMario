using UnityEngine;
using System.Collections;

public class DecScore : MonoBehaviour
{
    public Sprite Coin0;
    public Sprite Coin1;
    public Sprite Coin2;
    public Sprite Coin3;
    public Sprite Coin4;
    public Sprite Coin5;
    public Sprite Coin6;
    public Sprite Coin7;
    public Sprite Coin8;
    public Sprite Coin9;
    public static int coins;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coins = PickupCoin.coins;
        if (coins <= 10)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin0;
        }
        if (coins >= 10)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin1;
        }
        if (coins >= 20)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin2;
        }
        if (coins >= 30)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin3;
        }
        if (coins >= 40)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin4;
        }
        if (coins >= 50)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin5;
        }
        if (coins >= 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin6;
        }
        if (coins >= 70)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin7;
        }
        if (coins >= 80)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin8;
        }
        if (coins >= 90)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin9;
        }

    }
}
