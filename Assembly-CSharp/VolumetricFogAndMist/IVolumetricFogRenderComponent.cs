using System;

namespace VolumetricFogAndMist
{
	// Token: 0x020003A1 RID: 929
	internal interface IVolumetricFogRenderComponent
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06007D44 RID: 32068
		// (set) Token: 0x06007D45 RID: 32069
		VolumetricFog fog { get; set; }

		// Token: 0x06007D46 RID: 32070
		void DestroySelf();
	}
}
