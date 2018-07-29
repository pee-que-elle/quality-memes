using System;
using UnityEngine;
using UnityEngine.XR;

// Token: 0x0200039B RID: 923
[ImageEffectAllowedInSceneView]
[HelpURL("http://kronnect.com/taptapgo")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class MFEJLCEHLHC : HICINJKHLNP
{
	// Token: 0x06007C52 RID: 31826 RVA: 0x003AE5CC File Offset: 0x003AC7CC
	private void MFLPKKHGNBF()
	{
		if (!(this.fogMat == null) && this._alpha != 944f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("-", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Super Repel", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Ultra Ball", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C53 RID: 31827 RVA: 0x003AE6FC File Offset: 0x003AC8FC
	private void MQPJCNEPBJE()
	{
		if (!(this.fogMat == null) && this._alpha != 232f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 105, RenderTextureFormat.ARGB32);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Repeat;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C54 RID: 31828 RVA: 0x003AE7E8 File Offset: 0x003AC9E8
	private void NHBPIKQGOHO()
	{
		if (!(this.fogMat == null) && this._alpha != 1536f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("stockpile1", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[MEGA] ", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("colorchange", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C55 RID: 31829 RVA: 0x003AE918 File Offset: 0x003ACB18
	private void OnPreRender()
	{
		if (!(this.fogMat == null) && this._alpha != 0f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 24, RenderTextureFormat.ARGB32);
				this.EMKLHBIMGDN.antiAliasing = 1;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C56 RID: 31830 RVA: 0x003AEA04 File Offset: 0x003ACC04
	private void MNOGOQCJLBD()
	{
		if (!(this.fogMat == null) && this._alpha != 1307f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("[", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("-primal", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("map", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C57 RID: 31831 RVA: 0x003AEB34 File Offset: 0x003ACD34
	private void LMJQNHKOKPE()
	{
		if (!(this.fogMat == null) && this._alpha != 866f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("Slots_8", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Small/", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_VolumetricFog_OpaqueFrame", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C58 RID: 31832 RVA: 0x003AEC64 File Offset: 0x003ACE64
	private void PCNJOENELBJ()
	{
		if (!(this.fogMat == null) && this._alpha != 1083f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("Account creation failed!", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("BuffIcon_Fly", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("L", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C59 RID: 31833 RVA: 0x003AED94 File Offset: 0x003ACF94
	private void QGJNHHHLOQE()
	{
		if (!(this.fogMat == null) && this._alpha != 1845f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("LS", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("3D", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_ClipArgs2", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C5A RID: 31834 RVA: 0x003AEEC4 File Offset: 0x003AD0C4
	private void PPKFILKIPNC()
	{
		if (!(this.fogMat == null) && this._alpha != 316f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("Hold or Use?", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("primordialsea", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Damages the attacker if it contacts the Pokémon with a finishing hit.", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C5B RID: 31835 RVA: 0x003AEFF4 File Offset: 0x003AD1F4
	private void KBNNHIKGQCG()
	{
		if (!(this.fogMat == null) && this._alpha != 897f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, -76, RenderTextureFormat.ARGB32);
				this.EMKLHBIMGDN.antiAliasing = 1;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C5C RID: 31836 RVA: 0x003AF0E0 File Offset: 0x003AD2E0
	private void GCHHEBFIOQM()
	{
		if (!(this.fogMat == null) && this._alpha != 599f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("Fog", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix(".hit]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Mew", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C5D RID: 31837 RVA: 0x003AF210 File Offset: 0x003AD410
	private void FLGIIFNEQIQ()
	{
		if (!(this.fogMat == null) && this._alpha != 1811f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("CombinersArgsAlphaOp0", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Username", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix(" would like you to join their Guild, do you wish to accept? ", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C5E RID: 31838 RVA: 0x003AF340 File Offset: 0x003AD540
	private void NBNFHDBJOMI()
	{
		if (!(this.fogMat == null) && this._alpha != 1659f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("sweetveil", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("General", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("[-]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C5F RID: 31839 RVA: 0x003AF470 File Offset: 0x003AD670
	private void PJDFKILBHGB()
	{
		if (!(this.fogMat == null) && this._alpha != 1925f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("[ff6666]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("\n[PG]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("[7fff49]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C60 RID: 31840 RVA: 0x003AF5A0 File Offset: 0x003AD7A0
	private void JEHMJDQNOPJ()
	{
		if (!(this.fogMat == null) && this._alpha != 437f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, -102, RenderTextureFormat.Depth);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Repeat;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C61 RID: 31841 RVA: 0x003AF68C File Offset: 0x003AD88C
	private void HLFHLLFEPJM()
	{
		if (!(this.fogMat == null) && this._alpha != 1008f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector(" heals its status!\r\n", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("minior", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix(". Remember you need to add it to the ConstantShakePresets list first.", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C62 RID: 31842 RVA: 0x003AF7BC File Offset: 0x003AD9BC
	private void OHFDDQKJKLC()
	{
		if (!(this.fogMat == null) && this._alpha != 1882f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("Reason: ", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Game", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Slots_3", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C63 RID: 31843 RVA: 0x003AF8EC File Offset: 0x003ADAEC
	private void KQJPDIPMCPM()
	{
		if (!(this.fogMat == null) && this._alpha != 740f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 38, RenderTextureFormat.ARGB32);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C64 RID: 31844 RVA: 0x003AF9D8 File Offset: 0x003ADBD8
	private void LIEQKFNCMHK()
	{
		if (!(this.fogMat == null) && this._alpha != 1457f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector(";", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Assets/AssetBundles/Sprites/", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("! Your account has been verified, you may now log in.", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C65 RID: 31845 RVA: 0x003AFB08 File Offset: 0x003ADD08
	private void QKIOHFLBPGC()
	{
		if (!(this.fogMat == null) && this._alpha != 928f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, -94, RenderTextureFormat.Depth);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C67 RID: 31847 RVA: 0x003AFBF4 File Offset: 0x003ADDF4
	private void FBKOKCLNQJD()
	{
		if (!(this.fogMat == null) && this._alpha != 15f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 105, RenderTextureFormat.Depth);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C68 RID: 31848 RVA: 0x003AFCE0 File Offset: 0x003ADEE0
	private void DMKKFKIQBMI()
	{
		if (!(this.fogMat == null) && this._alpha != 653f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("ingrain", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("custapberry", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Blank", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C69 RID: 31849 RVA: 0x003AFE10 File Offset: 0x003AE010
	private void JKDDGKLFBNJ()
	{
		if (!(this.fogMat == null) && this._alpha != 216f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 97, RenderTextureFormat.ARGB32);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C6A RID: 31850 RVA: 0x003AFEFC File Offset: 0x003AE0FC
	private void BGGHPFDGKGI()
	{
		if (!(this.fogMat == null) && this._alpha != 1322f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("(RB)", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("FOG_SUN_SHADOWS_ON", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("struggle", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C6B RID: 31851 RVA: 0x003B002C File Offset: 0x003AE22C
	private void DIMPOONCOQJ()
	{
		if (!(this.fogMat == null) && this._alpha != 213f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 56, RenderTextureFormat.Depth);
				this.EMKLHBIMGDN.antiAliasing = 0;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Repeat;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C6C RID: 31852 RVA: 0x003B0118 File Offset: 0x003AE318
	private void NFCNPCJHLFG()
	{
		if (!(this.fogMat == null) && this._alpha != 1253f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("MissingNo.", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Failed Sync", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("0", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C6D RID: 31853 RVA: 0x003B0248 File Offset: 0x003AE448
	private void HOQQHFKPNMI()
	{
		if (!(this.fogMat == null) && this._alpha != 241f && !(this.EBNOGGPBLNC == null))
		{
			if (XRSettings.enabled)
			{
				RenderTextureDescriptor eyeTextureDesc = XRSettings.eyeTextureDesc;
				eyeTextureDesc.width = (int)((float)eyeTextureDesc.width * this.KJGQOMPIGMN);
				eyeTextureDesc.height = (int)((float)eyeTextureDesc.height * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(eyeTextureDesc);
			}
			else
			{
				int width = (int)((float)this.EBNOGGPBLNC.pixelWidth * this.KJGQOMPIGMN);
				int height = (int)((float)this.EBNOGGPBLNC.pixelHeight * this.KJGQOMPIGMN);
				this.EMKLHBIMGDN = RenderTexture.GetTemporary(width, height, 124, RenderTextureFormat.Depth);
				this.EMKLHBIMGDN.antiAliasing = 1;
			}
			this.EMKLHBIMGDN.wrapMode = TextureWrapMode.Clamp;
			this.EBNOGGPBLNC.targetTexture = this.EMKLHBIMGDN;
			return;
		}
	}

	// Token: 0x06007C6E RID: 31854 RVA: 0x003B0334 File Offset: 0x003AE534
	private void IKEKKHNFMGK()
	{
		if (!(this.fogMat == null) && this._alpha != 848f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = true;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("5|", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Leave Channel", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("wishiwashischool", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x06007C6F RID: 31855 RVA: 0x003B0464 File Offset: 0x003AE664
	private void OnPostRender()
	{
		if (!(this.fogMat == null) && this._alpha != 0f && !(this.EBNOGGPBLNC == null))
		{
			if (this.EGHPIHKDNMD)
			{
				this.EGHPIHKDNMD = false;
				base.LEKEJJENHQC();
			}
			if (this.EBNOGGPBLNC.orthographic)
			{
				if (!this.PDMEJDMEHGH)
				{
					base.NOOBNMLOBCP();
				}
				this.fogMat.SetVector("_ClipDir", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("_ClipToWorld", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_ClipToWorld", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			this.EBNOGGPBLNC.targetTexture = null;
			Graphics.Blit(this.EMKLHBIMGDN, null, this.fogMat);
			RenderTexture.ReleaseTemporary(this.EMKLHBIMGDN);
			return;
		}
	}

	// Token: 0x04001B13 RID: 6931
	private RenderTexture EMKLHBIMGDN;

	// Token: 0x04001B14 RID: 6932
	[Range(0.1f, 2f)]
	public float KJGQOMPIGMN = 1f;
}
