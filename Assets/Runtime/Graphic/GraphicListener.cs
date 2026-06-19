/*************************************************************************
 *  Copyright © 2026 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  GraphicListener.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  06/19/2026
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;
using UnityEngine.UI;

namespace MGS.MonoListener
{
    [RequireComponent(typeof(Graphic))]
    public abstract class GraphicListener : MonoBehaviour, IMonoListener
    {
        public virtual bool Interactable
        {
            set { graphic.raycastTarget = value; }
            get { return graphic.raycastTarget; }
        }
        protected Graphic graphic;

        protected virtual void Awake()
        {
            graphic = GetComponent<Graphic>();
        }
    }
}