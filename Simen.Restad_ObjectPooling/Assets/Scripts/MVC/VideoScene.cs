using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthType : MonoBehaviour
{
    public VideoScene app { get { return GameObject.FindObjectOfType<VideoScene>(); } }
}


public class VideoScene : MonoBehaviour
{
    public HealthModel model;
    public HealthController controller;
    public HealthView view;
}