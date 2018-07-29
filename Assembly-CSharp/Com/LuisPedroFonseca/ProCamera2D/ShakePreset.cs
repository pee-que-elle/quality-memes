using System;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x0200033C RID: 828
	[CreateAssetMenu(menuName = "ProCamera2D/Shake Preset")]
	[Serializable]
	public class ShakePreset : ScriptableObject
	{
		// Token: 0x0400172C RID: 5932
		public Vector3 Strength = new Vector2(10f, 10f);

		// Token: 0x0400172D RID: 5933
		[Range(0.02f, 3f)]
		public float Duration = 0.5f;

		// Token: 0x0400172E RID: 5934
		[Range(1f, 100f)]
		public int Vibrato = 10;

		// Token: 0x0400172F RID: 5935
		[Range(0f, 1f)]
		public float Randomness = 0.1f;

		// Token: 0x04001730 RID: 5936
		[Range(0f, 0.5f)]
		public float Smoothness = 0.1f;

		// Token: 0x04001731 RID: 5937
		public bool UseRandomInitialAngle = true;

		// Token: 0x04001732 RID: 5938
		[Range(0f, 360f)]
		public float InitialAngle;

		// Token: 0x04001733 RID: 5939
		public Vector3 Rotation;

		// Token: 0x04001734 RID: 5940
		public bool IgnoreTimeScale;
	}
}
