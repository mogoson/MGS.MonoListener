/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MRTKDragListener.cs
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
    public class MRTKDragListener : ColliderListener, IMonoDragListener,
        IMixedRealityPointerHandler
    {
        public event Action<Vector3> OnBeginDragEvent;
        public event Action<Vector3> OnDragEvent;
        public event Action<Vector3> OnEndDragEvent;

        public void OnPointerDown(MixedRealityPointerEventData eventData)
        {
            OnBeginDragEvent?.Invoke(eventData.Pointer.Position);
        }

        public void OnPointerClicked(MixedRealityPointerEventData eventData) { }

        public void OnPointerDragged(MixedRealityPointerEventData eventData)
        {
            OnDragEvent?.Invoke(eventData.Pointer.Position);
        }

        public void OnPointerUp(MixedRealityPointerEventData eventData)
        {
            OnEndDragEvent?.Invoke(eventData.Pointer.Position);
        }
    }
}