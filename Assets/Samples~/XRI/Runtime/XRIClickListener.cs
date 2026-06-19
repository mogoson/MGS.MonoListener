/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  XRIClickListener.cs
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
    public class XRIClickListener : XRIListener, IMonoClickListener
    {
        public event Action<Vector3> OnDownEvent;
        public event Action<Vector3> OnClickEvent;
        public event Action<Vector3> OnUpEvent;

        protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            base.OnSelectEntered(args);
            var pos = args.interactableObject.GetAttachPoseOnSelect(args.interactorObject).position;
            OnDownEvent?.Invoke(pos);
        }

        protected override void OnSelectExited(SelectExitEventArgs args)
        {
            base.OnSelectExited(args);
            var pos = args.interactableObject.GetAttachPoseOnSelect(args.interactorObject).position;
            OnClickEvent?.Invoke(pos);
            OnUpEvent?.Invoke(pos);
        }
    }
}