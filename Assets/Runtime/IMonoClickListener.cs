/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMonoClickListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;

namespace MGS.MonoListener
{
    public interface IMonoClickListener : IMonoListener
    {
        event Action<Vector3> OnDownEvent;
        event Action<Vector3> OnClickEvent;
        event Action<Vector3> OnUpEvent;
    }
}