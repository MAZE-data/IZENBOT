using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAll : MonoBehaviour
{
    public GameObject[] Slices;

    public GameObject[] Vidjets;

    public void _CloseAll()
    {
        for (int i = 0; i < Slices.Length; i++)
        {
            Slices[i].SetActive(true);
        }
        for (int i = 0; i < Vidjets.Length; i++)
        {
            Vidjets[i].SetActive(false);
        }
    }
}
