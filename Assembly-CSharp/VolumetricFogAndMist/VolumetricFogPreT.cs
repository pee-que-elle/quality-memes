using System;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020003AF RID: 943
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera), typeof(VolumetricFog))]
	public class VolumetricFogPreT : MonoBehaviour, IVolumetricFogRenderComponent
	{
		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x0002E046 File Offset: 0x0002C246
		// (set) Token: 0x06007E89 RID: 32393 RVA: 0x0002E04E File Offset: 0x0002C24E
		public VolumetricFog fog { get; set; }

		// Token: 0x06007E8A RID: 32394 RVA: 0x003C0AF0 File Offset: 0x003BECF0
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!(this.fog == null) && this.fog.enabled)
			{
				if (this.fog.renderBeforeTransparent)
				{
					this.fog.DoOnRenderImage(source, destination);
				}
				else
				{
					RenderTextureDescriptor descriptor = source.descriptor;
					this.opaqueFrame = RenderTexture.GetTemporary(descriptor);
					this.fog.DoOnRenderImage(source, this.opaqueFrame);
					Shader.SetGlobalTexture("_VolumetricFog_OpaqueFrame", this.opaqueFrame);
					Graphics.Blit(this.opaqueFrame, destination);
				}
				return;
			}
			Graphics.Blit(source, destination);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0002E057 File Offset: 0x0002C257
		private void OnPostRender()
		{
			if (this.opaqueFrame != null)
			{
				RenderTexture.ReleaseTemporary(this.opaqueFrame);
				this.opaqueFrame = null;
			}
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0002E03E File Offset: 0x0002C23E
		public void DestroySelf()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x04001C7D RID: 7293
		private RenderTexture opaqueFrame;
	}
}
