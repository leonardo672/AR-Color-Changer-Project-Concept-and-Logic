using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Change_Color : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;

    public void Red()
    {
        for(int i=0; i<mats.Length; i++)
        {
            mats[i].material.color = colors[0];
        }
    }
    public void Black()
    {
        for (int i=0; i<mats.Length; i++)
        {
            mats[i].material.color = colors[1];
        }
    }

    public void Blue()
    {
        for(int i=0; i<mats.Length; i++)
        {
            mats[i].material.color = colors[2];
        }
    }

    public void Yellow()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            mats[i].material.color = colors[3];
        }

    }
}
