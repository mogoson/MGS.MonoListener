/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  IMonoDragListener.cs
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
    public interface IMonoDragListener : IMonoListener
    {
        event Action<Vector3> OnBeginDragEvent;
        event Action<Vector3> OnDragEvent;
        event Action<Vector3> OnEndDragEvent;
    }
}