using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x0200039F RID: 927
	[AddComponentMenu("")]
	public class FogAreaCullingManager : MonoBehaviour
	{
		// Token: 0x06007D3D RID: 32061 RVA: 0x0002C7F7 File Offset: 0x0002A9F7
		private void OnEnable()
		{
			if (this.fog == null)
			{
				this.fog = base.GetComponent<VolumetricFog>();
				if (this.fog == null)
				{
					this.fog = base.gameObject.AddComponent<VolumetricFog>();
				}
			}
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x0002C832 File Offset: 0x0002AA32
		private void OnBecameVisible()
		{
			if (this.fog != null)
			{
				this.fog.enabled = true;
			}
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0002C84E File Offset: 0x0002AA4E
		private void OnBecameInvisible()
		{
			if (this.fog != null)
			{
				this.fog.enabled = false;
			}
		}

		// Token: 0x04001B42 RID: 6978
		public VolumetricFog fog;
	}
}
