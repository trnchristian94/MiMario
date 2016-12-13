using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PickupCoin : MonoBehaviour
{

    public AudioClip smw_coin;
    public static int coins;
    public static int lifes;

    // Use this for initialization
    void Start()
    {
        
    }
    void Awake()
    {
        coins = 0;


    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
            if (coins <= 99)
            {
                coins++;
                AudioSource.PlayClipAtPoint(smw_coin, transform.position, 1);
                Destroy(gameObject); // this destroys the collider as well     
            }
        if (coins >= 100) {coins = 0;} // resetea monedas al llegar a 100

    }

}