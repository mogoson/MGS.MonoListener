/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMonoHoverListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.MonoListener
{
    public interface IMonoHoverListener : IMonoListener
    {
        event Action<Vector3> OnEnterEvent;
        event Action<Vector3> OnMoveEvent;
        event Action<Vector3> OnExitEvent;
    }
}