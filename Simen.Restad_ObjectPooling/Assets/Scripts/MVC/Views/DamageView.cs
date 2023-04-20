using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageView : HealthType
{
    void OnCollisionStay2D(Collision2D collision) 
    {

        if (collision.gameObject.tag == "Ground")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (collision.gameObject.tag == "Asteroid")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        if (collision.gameObject.tag == "Player")
        {
            app.controller.OnDamageZoneEnter();
        }
    }
}
