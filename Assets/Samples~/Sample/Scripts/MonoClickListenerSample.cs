/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  MonoClickListenerSample.cs
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
    public class MonoClickListenerSample : MonoBehaviour
    {
        private void Awake()
        {
            var listener = GetComponent<IMonoClickListener>();
            if (listener == null) return;
            listener.OnDownEvent += pos => Debug.Log("OnDownEvent");
            listener.OnClickEvent += pos => Debug.Log("OnClickEvent");
            listener.OnUpEvent += pos => Debug.Log("OnUpEvent");
        }
    }
}