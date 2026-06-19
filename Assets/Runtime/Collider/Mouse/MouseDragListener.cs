/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MouseDragListener.cs
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
    public class MouseDragListener : ColliderListener, IMonoDragListener
    {
        public event Action<Vector3> OnBeginDragEvent;
        public event Action<Vector3> OnDragEvent;
        public event Action<Vector3> OnEndDragEvent;

        protected virtual void OnMouseDown()
        {
            OnBeginDragEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseDrag()
        {
            OnDragEvent?.Invoke(Vector3.zero);
        }

        protected virtual void OnMouseUp()
        {
            OnEndDragEvent?.Invoke(Vector3.zero);
        }
    }
}