using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x02000344 RID: 836
	[Serializable]
	public class CinematicTarget
	{
		// Token: 0x04001786 RID: 6022
		public Transform TargetTransform;

		// Token: 0x04001787 RID: 6023
		public float EaseInDuration = 1f;

		// Token: 0x04001788 RID: 6024
		public float HoldDuration = 1f;

		// Token: 0x04001789 RID: 6025
		public float Zoom = 1f;

		// Token: 0x0400178A RID: 6026
		public GMNJJQQPEDB EaseType = GMNJJQQPEDB.EaseOut;

		// Token: 0x0400178B RID: 6027
		public string SendMessageName;

		// Token: 0x0400178C RID: 6028
		public string SendMessageParam;
	}
}
