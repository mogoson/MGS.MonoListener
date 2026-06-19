/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseClickListener.cs
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
    public class MouseClickListener : ColliderListener, IMonoClickListener
    {
        public event Action<Vector3> OnDownEvent;
        public event Action<Vector3> OnClickEvent;
        public event Action<Vector3> OnUpEvent;

        protected virtual void OnMouseDown()
        {
            OnDownEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseUpAsButton()
        {
            OnClickEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseUp()
        {
            OnUpEvent?.Invoke(Vector3.zero);
        }
    }
}