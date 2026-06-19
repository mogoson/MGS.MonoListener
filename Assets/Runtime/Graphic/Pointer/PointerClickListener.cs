/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerClickListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MGS.MonoListener
{
    public class PointerClickListener : GraphicListener, IMonoClickListener,
        IPointerDownHandler, IPointerClickHandler, IPointerUpHandler
    {
        public event Action<Vector3> OnDownEvent;
        public event Action<Vector3> OnClickEvent;
        public event Action<Vector3> OnUpEvent;

        public void OnPointerDown(PointerEventData eventData)
        {
            OnDownEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            OnClickEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            OnUpEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }
    }
}