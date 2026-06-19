/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  XRIHoverListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace MGS.MonoListener.XRI
{
    public class XRIHoverListener : XRIListener, IMonoHoverListener
    {
        public event Action<Vector3> OnEnterEvent;
        public event Action<Vector3> OnMoveEvent;
        public event Action<Vector3> OnExitEvent;

        protected override void OnHoverEntered(HoverEnterEventArgs args)
        {
            base.OnHoverEntered(args);
            OnEnterEvent?.Invoke(Vector3.zero);
        }

        protected override void OnHoverExited(HoverExitEventArgs args)
        {
            base.OnHoverExited(args);
            OnExitEvent?.Invoke(Vector3.zero);
        }
    }
}