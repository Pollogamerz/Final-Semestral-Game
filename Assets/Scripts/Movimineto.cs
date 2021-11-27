using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimineto : MonoBehaviour
{
    

    public Joystick joystick;
    public int velocidad;
    public Rigidbody2D rb;
    public bool ConFisicas;

    private void Start()
    {
        

    }
    private void Update()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;

        if(ConFisicas)
        {
            rb.AddForce(direction * velocidad * Time.fixedDeltaTime, ForceMode2D.Impulse);

        }
        else
        {
            gameObject.transform.Translate(direction * velocidad * Time.deltaTime);
        }

    }


}
