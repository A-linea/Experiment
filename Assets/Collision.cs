using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collission, ouch");
    }
}
