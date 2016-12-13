using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    private Vector2 velocity;
    public float smoothTimeX;

    public GameObject player;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        //float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX,-1.37f,-10);

    }
}
//Script para seguir la posición del jugador y asignarlo a la cámara.