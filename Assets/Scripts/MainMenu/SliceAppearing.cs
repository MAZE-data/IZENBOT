using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceAppearing : MonoBehaviour
{
    public GameObject[] Slices;

    void Start()
    {
        StartCoroutine("_SliceAppearing");
    }

    public IEnumerator _SliceAppearing()
    {
        for (int i = Slices.Length - 1; i >= 0; i--)
        {
            yield return new WaitForSeconds(0.1f);
            Slices[i].SetActive(true);
        }
    }
}
