using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipSpawner : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("SpawnAndMove");
    }

    public float Speed;
    public GameObject SpaceshipPrefab;
    public float MaxDistance;
    public float ScaleX = 1;
    public float ScaleY = 1;

    IEnumerator SpawnAndMove()
    {
        GameObject o = Instantiate(SpaceshipPrefab, transform.position, Quaternion.identity);
        o.GetComponent<Rigidbody2D>().velocity = o.transform.right * Speed;
        o.transform.localScale = new Vector2(ScaleX, ScaleY);
        while (true)
        {
            yield return new WaitUntil(() => { return Vector2.Distance(o.transform.position, transform.position) > MaxDistance; });
            o.transform.position = transform.position;
        }
    }
}
