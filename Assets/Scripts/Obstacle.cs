using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Jugador");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bordes")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Jugador")
        {
            Destroy(player.gameObject);
        }
    }
}
