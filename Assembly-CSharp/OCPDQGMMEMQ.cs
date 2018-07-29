using System;
using UnityEngine;
using UnityEngine.XR;

// Token: 0x02000395 RID: 917
[ImageEffectAllowedInSceneView]
[HelpURL("http://kronnect.com/taptapgo")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class OCPDQGMMEMQ : HICINJKHLNP
{
	// Token: 0x06007B62 RID: 31586 RVA: 0x003A7F30 File Offset: 0x003A6130
	private void LMMNKLHEHCC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1666f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Marvel Scale", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("\n[ffdb4d]DEF:[-] ", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_DitheringCoords", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B63 RID: 31587 RVA: 0x003A8048 File Offset: 0x003A6248
	private void KBPPJONHKDN(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 512f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("clearbody", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[00DD00]Equipped", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Flare Boost", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B64 RID: 31588 RVA: 0x003A8160 File Offset: 0x003A6360
	private void HCEGKODPDED(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 82f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("<|>", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Fly", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B65 RID: 31589 RVA: 0x003A8278 File Offset: 0x003A6478
	private void INHIMGHGPDL(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 568f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("blinky", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Party", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("wimpout", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B66 RID: 31590 RVA: 0x003A8390 File Offset: 0x003A6590
	private void PMKPHQPEJOQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 990f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Player/Hair", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix(" from ", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("#,##0", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B67 RID: 31591 RVA: 0x003A84A8 File Offset: 0x003A66A8
	private void KLPGJFLCNLQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 754f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("aa", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("/", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Max: ", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B69 RID: 31593 RVA: 0x003A85C0 File Offset: 0x003A67C0
	private void NIMIQOEGOMD(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1342f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("bind", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[^0-9.-]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("[blue]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6A RID: 31594 RVA: 0x003A86D8 File Offset: 0x003A68D8
	private void HLKPCJIOEIQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1496f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("telepathy", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Dive Ball", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("-mega-y", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6B RID: 31595 RVA: 0x003A87F0 File Offset: 0x003A69F0
	private void FPJQFCHFPCQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 910f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Lv", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix(".", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Player/Body", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6C RID: 31596 RVA: 0x003A8908 File Offset: 0x003A6B08
	private void HJIGIJILBGH(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1278f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("0", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("StopRow3", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Create Guild", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6D RID: 31597 RVA: 0x003A8A20 File Offset: 0x003A6C20
	private void HGIENPIJLFB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1123f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("[-]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("PC2DPanTarget", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("[NGUI] Mesh", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6E RID: 31598 RVA: 0x003A8B38 File Offset: 0x003A6D38
	private void OMNEJEBNIOB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1067f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("~", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("destinybond", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("K2", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B6F RID: 31599 RVA: 0x003A8C50 File Offset: 0x003A6E50
	private void HQGIKLCMHPP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1916f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("MSGBOX - ", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("The mist disappeared from the battlefield.\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Run", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B70 RID: 31600 RVA: 0x003A8D68 File Offset: 0x003A6F68
	private void EBCMMHDQCQC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1695f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[SHINY]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("System", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B71 RID: 31601 RVA: 0x003A8E80 File Offset: 0x003A7080
	private void MMNNDKBEQJE(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1762f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Connection Established..", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[FF9900]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Kanto", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B72 RID: 31602 RVA: 0x003A8F98 File Offset: 0x003A7198
	private void MIGJCONKCHE(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 552f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("'s wish came true!\r\n", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Are you sure you wish to leave the Channel '", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("RenderType", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B73 RID: 31603 RVA: 0x003A90B0 File Offset: 0x003A72B0
	private void ECKJEKHDNLP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1551f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("[-]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("sandstorm", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("curse", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B74 RID: 31604 RVA: 0x003A91C8 File Offset: 0x003A73C8
	private void CEOHLFQKFHN(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 96f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Upgrade Pokébox", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("PrimitiveRightCorner", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("You got away safely!\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B75 RID: 31605 RVA: 0x003A92E0 File Offset: 0x003A74E0
	private void QIHLGHFJIPK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 778f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Big/", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Equip", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("HidePanel", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B76 RID: 31606 RVA: 0x003A93F8 File Offset: 0x003A75F8
	private void NDOCEGLMQFB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1863f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Snow", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix(" has chosen to use an item.", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("\n", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B77 RID: 31607 RVA: 0x003A9510 File Offset: 0x003A7710
	private void DHKFKFHEOOM(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1465f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("'s [ffff00]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("BuffIcon_ItemChanceIncrease", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("RightS", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B78 RID: 31608 RVA: 0x003A9628 File Offset: 0x003A7828
	private void JGPFHQGKHEM(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1210f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("/01_", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("NPC/Sprite", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("[BATTLE]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B79 RID: 31609 RVA: 0x003A9740 File Offset: 0x003A7940
	private void NNCIEKCBMLP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 621f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("b", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("|", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Shift+", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7A RID: 31610 RVA: 0x003A9858 File Offset: 0x003A7A58
	private void LGKCPPLQPMN(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1505f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("PostFX - {0}", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("1", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Encounter Rate Lowered 50%\nTriggers: [2ecc71]Stench[-], [2ecc71]Quick Feet[-], [2ecc71]White Smoke[-]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7B RID: 31611 RVA: 0x003A9970 File Offset: 0x003A7B70
	private void JKNBMPBECPD(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1804f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("BuffIcon_Fly", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Confirm EVs", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("50% more chance to encounter a Electric-type Pokémon.\nTriggers: [2ecc71]Static[-]", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7C RID: 31612 RVA: 0x003A9A88 File Offset: 0x003A7C88
	private void GJPIGQBMEGC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 189f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("[from]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[ATK]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("(B)", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7D RID: 31613 RVA: 0x003A9BA0 File Offset: 0x003A7DA0
	private void PEBPBMJQIIG(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 156f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("_DownsampledDepth", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Username already in use", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("'s ", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7E RID: 31614 RVA: 0x003A9CB8 File Offset: 0x003A7EB8
	private void GQJMCEONMDC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1412f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("2", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Command Exception [Login]: System.TimeoutException", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("ResolutionY", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B7F RID: 31615 RVA: 0x003A9DD0 File Offset: 0x003A7FD0
	private void QLDFOJBPOOF(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
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
				this.fogMat.SetVector("/510)", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("HidePanel", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Player/Hats/", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B80 RID: 31616 RVA: 0x003A9EE8 File Offset: 0x003A80E8
	private void FPMEPHKPCDK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1166f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("/", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("English", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("WATER_EDGEBLEND_OFF", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B81 RID: 31617 RVA: 0x003AA000 File Offset: 0x003A8200
	private void OnRenderImage(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
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
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B82 RID: 31618 RVA: 0x003AA118 File Offset: 0x003A8318
	private void BCCLFQPCECD(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 306f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("last online ", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("JOFLHFQQCKG", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("The Pokémon awakens twice as fast as other Pokémon from sleep.", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B83 RID: 31619 RVA: 0x003AA230 File Offset: 0x003A8430
	private void GMINPMQHEMH(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1561f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Sandy", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("/", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix(",", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B84 RID: 31620 RVA: 0x003AA348 File Offset: 0x003A8548
	private void NNBEKOPHQLM(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1348f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("system", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("marvelscale", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("BuffIcon_Dig", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B85 RID: 31621 RVA: 0x003AA460 File Offset: 0x003A8660
	private void IQQDNGMKQPO(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 755f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("h:mm tt", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("unaware", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("rated", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B86 RID: 31622 RVA: 0x003AA578 File Offset: 0x003A8778
	private void KQGCPBNLMFB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 937f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector(" is protected by an aromatic veil!\r\n", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("#,##0", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("J14", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B87 RID: 31623 RVA: 0x003AA690 File Offset: 0x003A8890
	private void LDQDKIKBECF(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1953f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Volt Absorb", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("s Tailwind petered out!\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("@", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B88 RID: 31624 RVA: 0x003AA7A8 File Offset: 0x003A89A8
	private void NKMQCQLIDGQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 707f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Its Speed stat is boosted every turn.", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("[00FF00]You received [PG]", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("'s Primal Reversion! It reverted to its primal state!\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B89 RID: 31625 RVA: 0x003AA8C0 File Offset: 0x003A8AC0
	private void MNJBNLCHMNK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 748f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Heat", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("UI", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8A RID: 31626 RVA: 0x003AA9D8 File Offset: 0x003A8BD8
	private void MQPKPONEOMN(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 861f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("#,##0", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("bag", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_ClipToWorld", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8B RID: 31627 RVA: 0x003AAAF0 File Offset: 0x003A8CF0
	private void GFBBMCMDGKP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 338f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("drought", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("_FogColor", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("0", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8C RID: 31628 RVA: 0x003AAC08 File Offset: 0x003A8E08
	private void HMLGOGCFMNI(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1756f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Battle", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("](", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Resetting IVs for your ", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8D RID: 31629 RVA: 0x003AAD20 File Offset: 0x003A8F20
	private void FJLNCNJBFDQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 663f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("/00_1", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Add to Friends", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Clear Body", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8E RID: 31630 RVA: 0x003AAE38 File Offset: 0x003A9038
	private void JHCFKNDHLNP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 763f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector(" shattered ", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix(" hour ago", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Max Repel", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B8F RID: 31631 RVA: 0x003AAF50 File Offset: 0x003A9150
	private void DFJBEKIDKED(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1046f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("[ATK]", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("_DestortionShiftX", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("\n", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B90 RID: 31632 RVA: 0x003AB068 File Offset: 0x003A9268
	private void HFNECQBBOIE(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1000f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("_History3Weight", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Temporarily Suspended", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_NoiseTex", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B91 RID: 31633 RVA: 0x003AB180 File Offset: 0x003A9380
	private void QGIMLNFNDMF(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1160f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Materials/DFOOrthogonal", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("The sunlight turned extremely harsh!", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix(" returned its status to normal using its [ffff00]White Herb[-]!\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B92 RID: 31634 RVA: 0x003AB298 File Offset: 0x003A9498
	private void EBMHMJKMCMC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1840f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("Enabled", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("1", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Hidden/Post FX/Temporal Anti-aliasing", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B93 RID: 31635 RVA: 0x003AB3B0 File Offset: 0x003A95B0
	private void LEIBGEDLCOQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1597f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("\n", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Player/Clothe", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("_Fade", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B94 RID: 31636 RVA: 0x003AB4C8 File Offset: 0x003A96C8
	private void KJKQBFFOIHC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 775f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("dazzling", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("Gravity intensified!\r\n", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("It reduced the PP of ", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x06007B95 RID: 31637 RVA: 0x003AB5E0 File Offset: 0x003A97E0
	private void QPPNIMJDPED(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.fogMat == null) && this._alpha != 1030f && !(this.EBNOGGPBLNC == null))
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
				this.fogMat.SetVector("default", this.EBNOGGPBLNC.transform.forward);
			}
			else if (this.PDMEJDMEHGH)
			{
				base.NOOBNMLOBCP();
			}
			if (this._useSinglePassStereoRenderingMatrix && XRSettings.enabled)
			{
				this.fogMat.SetMatrix("bag", this.EBNOGGPBLNC.cameraToWorldMatrix);
			}
			else
			{
				this.fogMat.SetMatrix("Mouse X", this.EBNOGGPBLNC.cameraToWorldMatrix * this.EBNOGGPBLNC.projectionMatrix.inverse);
			}
			Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, this.fogMat);
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}
}
