using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020003AE RID: 942
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera), typeof(VolumetricFog))]
	public class VolumetricFogPosT : MonoBehaviour, IVolumetricFogRenderComponent
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06007E83 RID: 32387 RVA: 0x0002E02D File Offset: 0x0002C22D
		// (set) Token: 0x06007E84 RID: 32388 RVA: 0x0002E035 File Offset: 0x0002C235
		public VolumetricFog fog { get; set; }

		// Token: 0x06007E85 RID: 32389 RVA: 0x003C0A20 File Offset: 0x003BEC20
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!(this.fog == null) && this.fog.enabled)
			{
				if (this.fog.transparencyBlendMode == NCJNIPIJBCP.None)
				{
					this.fog.DoOnRenderImage(source, destination);
				}
				else
				{
					RenderTextureDescriptor descriptor = source.descriptor;
					RenderTexture temporary = RenderTexture.GetTemporary(descriptor);
					if (this.copyOpaqueMat == null)
					{
						this.copyOpaqueMat = new Material(Shader.Find("VolumetricFogAndMist/CopyOpaque"));
					}
					this.copyOpaqueMat.SetFloat("_BlendPower", this.fog.transparencyBlendPower);
					Graphics.Blit(source, destination, this.copyOpaqueMat, (!this.fog.computeDepth || this.fog.downsampling != 1) ? 0 : 1);
					RenderTexture.ReleaseTemporary(temporary);
				}
				return;
			}
			Graphics.Blit(source, destination);
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0002E03E File Offset: 0x0002C23E
		public void DestroySelf()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x04001C7B RID: 7291
		private Material copyOpaqueMat;
	}
}
