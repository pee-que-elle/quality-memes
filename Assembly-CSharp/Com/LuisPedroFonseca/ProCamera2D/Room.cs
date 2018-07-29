using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x02000362 RID: 866
	[Serializable]
	public class Room
	{
		// Token: 0x060072F7 RID: 29431 RVA: 0x0002A04F File Offset: 0x0002824F
		public Room()
		{
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0037ACEC File Offset: 0x00378EEC
		public Room(Room BDGBMCDPOBB)
		{
			this.Dimensions = BDGBMCDPOBB.Dimensions;
			this.TransitionDuration = BDGBMCDPOBB.TransitionDuration;
			this.TransitionEaseType = BDGBMCDPOBB.TransitionEaseType;
			this.ScaleCameraToFit = BDGBMCDPOBB.ScaleCameraToFit;
			this.Zoom = BDGBMCDPOBB.Zoom;
			this.ZoomScale = BDGBMCDPOBB.ZoomScale;
		}

		// Token: 0x040018BC RID: 6332
		public string ID = string.Empty;

		// Token: 0x040018BD RID: 6333
		public Rect Dimensions;

		// Token: 0x040018BE RID: 6334
		[Range(0f, 10f)]
		public float TransitionDuration;

		// Token: 0x040018BF RID: 6335
		public GMNJJQQPEDB TransitionEaseType;

		// Token: 0x040018C0 RID: 6336
		public bool ScaleCameraToFit;

		// Token: 0x040018C1 RID: 6337
		public bool Zoom;

		// Token: 0x040018C2 RID: 6338
		[Range(0.1f, 10f)]
		public float ZoomScale;
	}
}
