/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseHoverListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.MonoListener
{
    public class MouseHoverListener : ColliderListener, IMonoHoverListener
    {
        public event Action<Vector3> OnEnterEvent;
        public event Action<Vector3> OnMoveEvent;
        public event Action<Vector3> OnExitEvent;

        protected virtual void OnMouseEnter()
        {
            OnEnterEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseOver()
        {
            OnMoveEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseExit()
        {
            OnExitEvent?.Invoke(Vector3.zero);
        }
    }
}