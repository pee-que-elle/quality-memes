using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x02000357 RID: 855
	[Serializable]
	public class ProCamera2DParallaxLayer
	{
		// Token: 0x04001868 RID: 6248
		public Camera ParallaxCamera;

		// Token: 0x04001869 RID: 6249
		[Range(0f, 5f)]
		public float Speed = 1f;

		// Token: 0x0400186A RID: 6250
		public LayerMask LayerMask;

		// Token: 0x0400186B RID: 6251
		[HideInInspector]
		[NonSerialized]
		public Transform CameraTransform;
	}
}
