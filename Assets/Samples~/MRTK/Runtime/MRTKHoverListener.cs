/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MRTKHoverListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace MGS.MonoListener.MRTK
{
    public class MRTKHoverListener : ColliderListener, IMonoHoverListener,
        IMixedRealityFocusHandler
    {
        public event Action<Vector3> OnEnterEvent;
        public event Action<Vector3> OnMoveEvent;
        public event Action<Vector3> OnExitEvent;

        public void OnFocusEnter(FocusEventData eventData)
        {
            OnEnterEvent?.Invoke(eventData.Pointer.Position);
        }

        public void OnFocusExit(FocusEventData eventData)
        {
            OnExitEvent?.Invoke(eventData.Pointer.Position);
        }
    }
}