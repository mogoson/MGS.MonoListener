/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoDragListenerSample.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.MonoListener.Sample
{
    public class MonoDragListenerSample : MonoBehaviour
    {
        private void Awake()
        {
            var listener = GetComponent<IMonoDragListener>();
            if (listener == null) return;
            listener.OnBeginDragEvent += pos => Debug.Log("OnBeginDragEvent");
            listener.OnDragEvent += pos => Debug.Log("OnDragEvent");
            listener.OnEndDragEvent += pos => Debug.Log("OnEndDragEvent");
        }
    }
}