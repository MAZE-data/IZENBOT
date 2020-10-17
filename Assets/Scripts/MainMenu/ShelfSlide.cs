using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfSlide : MonoBehaviour
{
    public void Slide()
    {
        StartCoroutine("SlideSFX");
    }

    public void SlideBack()
    {
        StartCoroutine("SlideSFXBack");
    }

    public Transform pos1;
    public Transform pos2;
    public float step;

    IEnumerator SlideSFX()
    {
        for(float i = 0; i<1; i += 0.1f)
        {
            transform.position = Vector2.Lerp(pos1.position, pos2.position, i);
            yield return new WaitForSeconds(step);
        }
    }

    IEnumerator SlideSFXBack()
    {
        for (float i = 0; i < 1; i += 0.1f)
        {
            transform.position = Vector2.Lerp(pos2.position, pos1.position, i);
            yield return new WaitForSeconds(step);
        }
    }
}
