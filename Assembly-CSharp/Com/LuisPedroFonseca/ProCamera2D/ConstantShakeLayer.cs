using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x0200032F RID: 815
	[Serializable]
	public struct ConstantShakeLayer
	{
		// Token: 0x040016F6 RID: 5878
		[BBNHHPICPIF(0.001f, 10f)]
		public Vector2 Frequency;

		// Token: 0x040016F7 RID: 5879
		[Range(0f, 100f)]
		public float AmplitudeHorizontal;

		// Token: 0x040016F8 RID: 5880
		[Range(0f, 100f)]
		public float AmplitudeVertical;

		// Token: 0x040016F9 RID: 5881
		[Range(0f, 100f)]
		public float AmplitudeDepth;
	}
}
