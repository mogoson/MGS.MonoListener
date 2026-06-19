/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoHoverListenerSample.cs
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
    public class MonoHoverListenerSample : MonoBehaviour
    {
        private void Awake()
        {
            var listener = GetComponent<IMonoHoverListener>();
            if (listener == null) return;
            listener.OnEnterEvent += pos => Debug.Log("OnEnterEvent");
            listener.OnMoveEvent += pos => Debug.Log("OnMoveEvent");
            listener.OnExitEvent += pos => Debug.Log("OnExitEvent");
        }
    }
}