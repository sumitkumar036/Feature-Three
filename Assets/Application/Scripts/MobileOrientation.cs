using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OrientationType
{
    Portrait,
    LandScape,

    LandScapeRight,

    LandScapeLeft,
}

public class MobileOrientation : MonoBehaviour
{
    public OrientationType orientationType;
    private void Awake()
    {
        Init();
    }

    void Init()
    {
        if (OrientationType.Portrait == orientationType)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }

        if (OrientationType.LandScape == orientationType)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }

        if (OrientationType.LandScapeLeft == orientationType)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }

        if (OrientationType.LandScapeRight == orientationType)
        {
            Screen.orientation = ScreenOrientation.LandscapeRight;
        }
    }
}
