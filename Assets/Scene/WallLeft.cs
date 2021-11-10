using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLeft : MonoBehaviour
{
    public GameObject Projectil;

     void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(Projectil, GameObject.Find("Eject").GetComponent<Transform>().transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
    }
}
