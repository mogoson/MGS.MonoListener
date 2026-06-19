/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  PointerDragListener.cs
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
    public class PointerDragListener : GraphicListener, IMonoDragListener,
        IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public event Action<Vector3> OnBeginDragEvent;
        public event Action<Vector3> OnDragEvent;
        public event Action<Vector3> OnEndDragEvent;

        public void OnBeginDrag(PointerEventData eventData)
        {
            OnBeginDragEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnDrag(PointerEventData eventData)
        {
            OnDragEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            OnEndDragEvent?.Invoke(eventData.pointerCurrentRaycast.worldPosition);
        }
    }
}