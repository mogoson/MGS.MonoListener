/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  XRIDragListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/20/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace MGS.MonoListener.XRI
{
    public class XRIDragListener : XRIListener, IMonoDragListener
    {
        public event Action<Vector3> OnBeginDragEvent;
        public event Action<Vector3> OnDragEvent;
        public event Action<Vector3> OnEndDragEvent;

        protected override void OnSelectEntering(SelectEnterEventArgs args)
        {
            base.OnSelectEntering(args);
            var pos = args.interactableObject.GetAttachPoseOnSelect(args.interactorObject).position;
            OnBeginDragEvent?.Invoke(pos);
        }

        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            base.OnSelectEntered(args);
            var pos = args.interactableObject.GetAttachPoseOnSelect(args.interactorObject).position;
            OnDragEvent?.Invoke(pos);
        }

        protected override void OnSelectExited(SelectExitEventArgs args)
        {
            base.OnSelectExited(args);
            var pos = args.interactableObject.GetAttachPoseOnSelect(args.interactorObject).position;
            OnEndDragEvent?.Invoke(pos);
        }
    }
}