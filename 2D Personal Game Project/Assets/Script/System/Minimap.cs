using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Minimap : MonoBehaviour
{
    public CinemachineVirtualCamera vCam;
    public float size;

    public void Open()
    {
        vCam.m_Lens.OrthographicSize = size;
    }
    public void Close()
    {
        vCam.m_Lens.OrthographicSize = 3f;
    }
}
