using UnityEngine;
using System.Collections;

public class UniScore : MonoBehaviour {
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
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        coins = PickupCoin.coins;
        if (coins == 0 ||(coins%10)==0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin0;
        }
        if (coins == 1||(coins-1)%10==0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin1;
        }
        if (coins == 2 || (coins - 2) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin2;
        }
        if (coins == 3 || (coins - 3) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin3;
        }
        if (coins == 4 || (coins - 4) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin4;
        }
        if (coins == 5 || (coins - 5) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin5;
        }
        if (coins == 6 || (coins - 6) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin6;
        }
        if (coins == 7 || (coins - 7) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin7;
        }
        if (coins == 8 || (coins - 8) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin8;
        }
        if (coins == 9 || (coins - 9) % 10 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Coin9;
        }

    }
}
