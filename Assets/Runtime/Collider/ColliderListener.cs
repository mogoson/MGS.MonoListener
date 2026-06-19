/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  ColliderListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.MonoListener
{
    [RequireComponent(typeof(Collider))]
    public abstract class ColliderListener : MonoBehaviour, IMonoListener
    {
        public virtual bool Interactable
        {
            set { myCollider.enabled = value; }
            get { return myCollider.enabled; }
        }
        protected Collider myCollider;

        protected virtual void Awake()
        {
            myCollider = GetComponent<Collider>();
        }
    }
}