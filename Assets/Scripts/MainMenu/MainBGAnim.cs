using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBGAnim : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Anim");
    }

    public float Time;
    public float Speed;

    IEnumerator Anim()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * Speed;
        while (true)
        {
            yield return new WaitForSeconds(Time);
            GetComponent<Rigidbody2D>().velocity *= -1;
        }
    }
}
