using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidjetController : MonoBehaviour
{
    public GameObject[] Slices;

    public GameObject Box;

    public void OpenPlayBox(int index)
    {
        for (int i = 0; i < Slices.Length; i++)
        {
            if (i == index) Slices[i].SetActive(true);
            else Slices[i].SetActive(false);
        }
        Box.SetActive(true);
    }
}
