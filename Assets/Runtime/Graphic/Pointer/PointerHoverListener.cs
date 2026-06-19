/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerHoverListener.cs
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
    public class PointerHoverListener : GraphicListener, IMonoHoverListener,
        IPointerEnterHandler, IPointerMoveHandler, IPointerExitHandler
    {
        public event Action<Vector3> OnEnterEvent;
        public event Action<Vector3> OnMoveEvent;
        public event Action<Vector3> OnExitEvent;

        public void OnPointerEnter(PointerEventData eventData)
        {
            OnEnterEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnPointerMove(PointerEventData eventData)
        {
            OnMoveEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            OnExitEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }
    }
}