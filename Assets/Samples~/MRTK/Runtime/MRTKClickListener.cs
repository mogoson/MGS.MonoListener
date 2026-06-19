/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MRTKClickListener.cs
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
    public class MRTKClickListener : ColliderListener, IMonoClickListener,
        IMixedRealityPointerHandler, IMixedRealityTouchHandler
    {
        public event Action<Vector3> OnDownEvent;
        public event Action<Vector3> OnClickEvent;
        public event Action<Vector3> OnUpEvent;

        #region Pointer
        public void OnPointerDown(MixedRealityPointerEventData eventData)
        {
            OnDownEvent?.Invoke(eventData.Pointer.Position);
        }

        public void OnPointerClicked(MixedRealityPointerEventData eventData)
        {
            OnClickEvent?.Invoke(eventData.Pointer.Position);
        }

        public void OnPointerDragged(MixedRealityPointerEventData eventData) { }

        public void OnPointerUp(MixedRealityPointerEventData eventData)
        {
            OnUpEvent?.Invoke(eventData.Pointer.Position);
        }
        #endregion

        #region Touch
        public void OnTouchStarted(HandTrackingInputEventData eventData)
        {
            OnDownEvent?.Invoke(eventData.Controller.InputSource.Pointers[0].Position);
        }

        public void OnTouchUpdated(HandTrackingInputEventData eventData) { }

        public void OnTouchCompleted(HandTrackingInputEventData eventData)
        {
            OnClickEvent?.Invoke(eventData.Controller.InputSource.Pointers[0].Position);
            OnUpEvent?.Invoke(eventData.Controller.InputSource.Pointers[0].Position);
        }
        #endregion
    }
}