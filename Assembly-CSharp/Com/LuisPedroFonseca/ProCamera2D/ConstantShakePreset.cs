using System;
using System.Collections.Generic;
using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	// Token: 0x0200032E RID: 814
	[CreateAssetMenu(menuName = "ProCamera2D/Constant Shake Preset")]
	[Serializable]
	public class ConstantShakePreset : ScriptableObject
	{
		// Token: 0x040016F4 RID: 5876
		public float Intensity = 0.3f;

		// Token: 0x040016F5 RID: 5877
		public List<ConstantShakeLayer> Layers;
	}
}
