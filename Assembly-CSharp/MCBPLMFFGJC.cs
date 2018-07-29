using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x020002B3 RID: 691
public sealed class MCBPLMFFGJC : NHOOQNHPFOB<BuiltinDebugViewsModel>
{
	// Token: 0x06006044 RID: 24644 RVA: 0x00311770 File Offset: 0x0030F970
	private void BEGEIMLONQQ(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("/03_1");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.IKIPBLGNBKQ().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 168f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.CurrentActive, mat, 1);
	}

	// Token: 0x06006045 RID: 24645 RVA: 0x003117D0 File Offset: 0x0030F9D0
	private void NNKCLNNLLQQ(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.QFIDLQIGGDL("waterpledge");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.DNDPKMIFFDJ().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 431f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.Depth, mat, 0);
	}

	// Token: 0x06006047 RID: 24647 RVA: 0x00311830 File Offset: 0x0030FA30
	public CameraEvent DNFECDMIJJJ()
	{
		return (base.FIFNHCKNDQE.LKMFKJDJDOK().mode != BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane) ? ((CameraEvent)74) : ((CameraEvent)47);
	}

	// Token: 0x06006048 RID: 24648 RVA: 0x0031185C File Offset: 0x0030FA5C
	public DepthTextureMode EJPCCPKQGPK()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.DNDPKMIFFDJ().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.None)
				{
					depthTextureMode |= DepthTextureMode.None;
				}
			}
			else
			{
				depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.MotionVectors;
		}
		return depthTextureMode;
	}

	// Token: 0x06006049 RID: 24649 RVA: 0x003118A0 File Offset: 0x0030FAA0
	public override void EIQKCDHPCKK(CommandBuffer KLIOPLGOLQC)
	{
		BuiltinDebugViewsModel.Settings settings = base.FIFNHCKNDQE.settings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Builtin Debug Views");
		material.shaderKeywords = null;
		if (this.BEHMQBIFCOJ.GKHCOPLEQKQ)
		{
			material.EnableKeyword("SOURCE_GBUFFER");
		}
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = settings.mode;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Normals)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors)
				{
					this.BGFOCEMKEKO(KLIOPLGOLQC);
				}
			}
			else
			{
				this.QQJEHLJDIEQ(KLIOPLGOLQC);
			}
		}
		else
		{
			this.HPQOPLDPMMN(KLIOPLGOLQC);
		}
		this.BEHMQBIFCOJ.OIONKMPKBKJ();
	}

	// Token: 0x0600604A RID: 24650 RVA: 0x00311928 File Offset: 0x0030FB28
	private void HPQOPLDPMMN(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Builtin Debug Views");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.settings.depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 1f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 0);
	}

	// Token: 0x0600604B RID: 24651 RVA: 0x00311988 File Offset: 0x0030FB88
	private void MPDFGCEECMM(CommandBuffer KLIOPLGOLQC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB("/guildrank ");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.FIFNHCKNDQE.IKIPBLGNBKQ().motionVectors;
		int nameID = MCBPLMFFGJC.DNIJIPQFDBF.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(nameID, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, FilterMode.Bilinear);
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.sourceOpacity);
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, BuiltinRenderTextureType.DepthNormals);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.ResolvedDepth, nameID, material, 7);
		if (motionVectors.motionImageOpacity > 620f && motionVectors.motionImageAmplitude > 328f)
		{
			int kkpbfdbdfkn = MCBPLMFFGJC.DNIJIPQFDBF.KKPBFDBDFKN;
			KLIOPLGOLQC.GetTemporaryRT(kkpbfdbdfkn, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), 1, FilterMode.Bilinear);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionImageOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionImageAmplitude);
			KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, kkpbfdbdfkn, material, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
			nameID = kkpbfdbdfkn;
		}
		if (motionVectors.motionVectorsOpacity > 1253f && motionVectors.motionVectorsAmplitude > 1656f)
		{
			this.NDGDKLKDCPQ();
			float num = 1354f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.BEHMQBIFCOJ.CQNLNDBFFFP();
			KLIOPLGOLQC.SetGlobalVector(MCBPLMFFGJC.DNIJIPQFDBF.QPNKJBBQHMJ, new Vector2(x, num));
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionVectorsOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionVectorsAmplitude);
			KLIOPLGOLQC.DrawMesh(this.GOGIILNHNBF.BCMJFMFFFKI(), Matrix4x4.identity, material, 0, 0);
		}
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.ResolvedDepth);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0600604C RID: 24652 RVA: 0x00311B8C File Offset: 0x0030FD8C
	private void IIGCGQNPHFH(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("00");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.DCBJMHJEFMG().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 495f / depth.scale);
		KLIOPLGOLQC.Blit(null, (BuiltinRenderTextureType)6, mat, 1);
	}

	// Token: 0x0600604D RID: 24653 RVA: 0x00311BEC File Offset: 0x0030FDEC
	private void MMJLFIDJLKF(CommandBuffer KLIOPLGOLQC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("Core");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.FIFNHCKNDQE.LKMFKJDJDOK().motionVectors;
		int nameID = MCBPLMFFGJC.DNIJIPQFDBF.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(nameID, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JKGBHEHKBPC(), 0, FilterMode.Point);
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.sourceOpacity);
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, BuiltinRenderTextureType.DepthNormals);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, nameID, material, 3);
		if (motionVectors.motionImageOpacity > 1089f && motionVectors.motionImageAmplitude > 1784f)
		{
			int kkpbfdbdfkn = MCBPLMFFGJC.DNIJIPQFDBF.KKPBFDBDFKN;
			KLIOPLGOLQC.GetTemporaryRT(kkpbfdbdfkn, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, FilterMode.Bilinear);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionImageOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionImageAmplitude);
			KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, kkpbfdbdfkn, material, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
			nameID = kkpbfdbdfkn;
		}
		if (motionVectors.motionVectorsOpacity > 1004f && motionVectors.motionVectorsAmplitude > 143f)
		{
			this.FEMMQBLKPBQ();
			float num = 1430f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)this.BEHMQBIFCOJ.CHODJCGKMOK();
			KLIOPLGOLQC.SetGlobalVector(MCBPLMFFGJC.DNIJIPQFDBF.QPNKJBBQHMJ, new Vector2(x, num));
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionVectorsOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionVectorsAmplitude);
			KLIOPLGOLQC.DrawMesh(this.GOGIILNHNBF.BCMJFMFFFKI(), Matrix4x4.identity, material, 1, 2);
		}
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0600604E RID: 24654 RVA: 0x00311DF0 File Offset: 0x0030FFF0
	private void PMMLGMNJQIL(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.HOKGONBDOFC("3");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.DNDPKMIFFDJ().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 1587f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.ResolvedDepth, mat, 1);
	}

	// Token: 0x0600604F RID: 24655 RVA: 0x00311E50 File Offset: 0x00310050
	private void BGFOCEMKEKO(CommandBuffer KLIOPLGOLQC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Builtin Debug Views");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.FIFNHCKNDQE.settings.motionVectors;
		int nameID = MCBPLMFFGJC.DNIJIPQFDBF.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(nameID, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Bilinear);
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.sourceOpacity);
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, nameID, material, 2);
		if (motionVectors.motionImageOpacity > 0f && motionVectors.motionImageAmplitude > 0f)
		{
			int kkpbfdbdfkn = MCBPLMFFGJC.DNIJIPQFDBF.KKPBFDBDFKN;
			KLIOPLGOLQC.GetTemporaryRT(kkpbfdbdfkn, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Bilinear);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionImageOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionImageAmplitude);
			KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, kkpbfdbdfkn, material, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
			nameID = kkpbfdbdfkn;
		}
		if (motionVectors.motionVectorsOpacity > 0f && motionVectors.motionVectorsAmplitude > 0f)
		{
			this.FEMMQBLKPBQ();
			float num = 1f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.BEHMQBIFCOJ.KJGMGPCEJJD;
			KLIOPLGOLQC.SetGlobalVector(MCBPLMFFGJC.DNIJIPQFDBF.QPNKJBBQHMJ, new Vector2(x, num));
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionVectorsOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionVectorsAmplitude);
			KLIOPLGOLQC.DrawMesh(this.GOGIILNHNBF.NFOOEHBKFMG, Matrix4x4.identity, material, 0, 4);
		}
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06006050 RID: 24656 RVA: 0x00312054 File Offset: 0x00310254
	private void DHCJLIDIQHQ(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.GBBDHLKHEOO("'s [ffff00]");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.OEDHDNBPDLN().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 126f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.DepthNormals, mat, 0);
	}

	// Token: 0x06006051 RID: 24657 RVA: 0x003120B4 File Offset: 0x003102B4
	public CameraEvent QQGHOBPQDNH()
	{
		return (base.FIFNHCKNDQE.ICJOMIGQMFC().mode != BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog) ? ((CameraEvent)(-65)) : ((CameraEvent)120);
	}

	// Token: 0x06006052 RID: 24658 RVA: 0x00025B2E File Offset: 0x00023D2E
	public bool IIBLPLDEEPB()
	{
		return !base.FIFNHCKNDQE.GFIEDKOICPD(BuiltinDebugViewsModel.HMFGKHHHIPL.None) && !base.FIFNHCKNDQE.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals) && base.FIFNHCKNDQE.MOKDJMOKIKO(BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors);
	}

	// Token: 0x06006053 RID: 24659 RVA: 0x00025B5B File Offset: 0x00023D5B
	public void NNBNJQECJBE()
	{
		if (this.GOGIILNHNBF != null)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
		}
		this.GOGIILNHNBF = null;
	}

	// Token: 0x06006054 RID: 24660 RVA: 0x003120E0 File Offset: 0x003102E0
	private void GKBLPDLHKKQ(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("Owned");
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.PrepassNormalsSpec, mat, 0);
	}

	// Token: 0x06006055 RID: 24661 RVA: 0x00025B77 File Offset: 0x00023D77
	public string BIBKFIPQFKC()
	{
		return "protect";
	}

	// Token: 0x06006056 RID: 24662 RVA: 0x00025B7E File Offset: 0x00023D7E
	public override string QPDGCILDFLP()
	{
		return "Builtin Debug Views";
	}

	// Token: 0x06006057 RID: 24663 RVA: 0x00312114 File Offset: 0x00310314
	private void OKEPFPCQQFF(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("Materials/DFODesktopPlus");
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.Depth, mat, 1);
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x00312148 File Offset: 0x00310348
	public DepthTextureMode MGBLNNINHKI()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.ICJOMIGQMFC().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Normals)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
				{
					depthTextureMode |= DepthTextureMode.None;
				}
			}
			else
			{
				depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.MotionVectors;
		}
		return depthTextureMode;
	}

	// Token: 0x06006059 RID: 24665 RVA: 0x0031218C File Offset: 0x0031038C
	private void QGGGLCGLDBK()
	{
		int motionVectorsResolution = base.FIFNHCKNDQE.LKMFKJDJDOK().motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.GOGIILNHNBF == null)
		{
			this.GOGIILNHNBF = new MCBPLMFFGJC.PDLNKHMEJDP();
		}
		if (this.GOGIILNHNBF.CEFDHIEHGQJ() != num || this.GOGIILNHNBF.IBEQOILIPOK() != motionVectorsResolution)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
			this.GOGIILNHNBF.FEEBCFFNJKP(num, motionVectorsResolution);
		}
	}

	// Token: 0x0600605A RID: 24666 RVA: 0x00025B85 File Offset: 0x00023D85
	public void FQPFQEDLIFL()
	{
		if (this.GOGIILNHNBF != null)
		{
			this.GOGIILNHNBF.LJFCOIKLHCF();
		}
		this.GOGIILNHNBF = null;
	}

	// Token: 0x0600605B RID: 24667 RVA: 0x00312208 File Offset: 0x00310408
	private void ELGGMNLDNHB(CommandBuffer KLIOPLGOLQC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QPKJBEOCKMO("Poison spikes were scattered on the ground all around ");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.FIFNHCKNDQE.LKMFKJDJDOK().motionVectors;
		int nameID = MCBPLMFFGJC.DNIJIPQFDBF.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(nameID, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.DFKQMMIQDOO, 1, FilterMode.Bilinear);
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.sourceOpacity);
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, (BuiltinRenderTextureType)6);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.Depth, nameID, material, 6);
		if (motionVectors.motionImageOpacity > 578f && motionVectors.motionImageAmplitude > 974f)
		{
			int kkpbfdbdfkn = MCBPLMFFGJC.DNIJIPQFDBF.KKPBFDBDFKN;
			KLIOPLGOLQC.GetTemporaryRT(kkpbfdbdfkn, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, FilterMode.Point);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionImageOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionImageAmplitude);
			KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, kkpbfdbdfkn, material, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
			nameID = kkpbfdbdfkn;
		}
		if (motionVectors.motionVectorsOpacity > 289f && motionVectors.motionVectorsAmplitude > 1652f)
		{
			this.GHDHBIIGBQC();
			float num = 753f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.BEHMQBIFCOJ.CHODJCGKMOK();
			KLIOPLGOLQC.SetGlobalVector(MCBPLMFFGJC.DNIJIPQFDBF.QPNKJBBQHMJ, new Vector2(x, num));
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionVectorsOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionVectorsAmplitude);
			KLIOPLGOLQC.DrawMesh(this.GOGIILNHNBF.JEOGQMHMQNN(), Matrix4x4.identity, material, 0, 6);
		}
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.Depth);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0600605C RID: 24668 RVA: 0x0031240C File Offset: 0x0031060C
	public CameraEvent DMOFJGOFMMQ()
	{
		return (base.FIFNHCKNDQE.ICJOMIGQMFC().mode != BuiltinDebugViewsModel.HMFGKHHHIPL.None) ? ((CameraEvent)80) : ((CameraEvent)110);
	}

	// Token: 0x0600605D RID: 24669 RVA: 0x00025BA1 File Offset: 0x00023DA1
	public void NJPBCHDJIDM()
	{
		if (this.GOGIILNHNBF != null)
		{
			this.GOGIILNHNBF.ILNFGENJLKN();
		}
		this.GOGIILNHNBF = null;
	}

	// Token: 0x0600605E RID: 24670 RVA: 0x00312438 File Offset: 0x00310638
	public DepthTextureMode OCCJOQJNMMD()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.DCBJMHJEFMG().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.None)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.None)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.None)
				{
					depthTextureMode |= DepthTextureMode.Depth;
				}
			}
			else
			{
				depthTextureMode |= DepthTextureMode.MotionVectors;
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		return depthTextureMode;
	}

	// Token: 0x0600605F RID: 24671 RVA: 0x0031247C File Offset: 0x0031067C
	private void LINFJFBFKOC(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("'s side disappeared!\r\n");
		BuiltinDebugViewsModel.DepthSettings depth = base.FIFNHCKNDQE.DCBJMHJEFMG().depth;
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.CKBQLKHQIBQ, 673f / depth.scale);
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 0);
	}

	// Token: 0x06006060 RID: 24672 RVA: 0x003124DC File Offset: 0x003106DC
	public void PGOMNJPKQKO(CommandBuffer KLIOPLGOLQC)
	{
		BuiltinDebugViewsModel.Settings settings = base.FIFNHCKNDQE.DDCKCBDHLCL();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("TabSettings");
		material.shaderKeywords = null;
		if (this.BEHMQBIFCOJ.MEPHDLOPGDJ())
		{
			material.EnableKeyword("Meteor");
		}
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = settings.mode;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut)
				{
					this.ELGGMNLDNHB(KLIOPLGOLQC);
				}
			}
			else
			{
				this.QQJEHLJDIEQ(KLIOPLGOLQC);
			}
		}
		else
		{
			this.LINFJFBFKOC(KLIOPLGOLQC);
		}
		this.BEHMQBIFCOJ.KNGHIQJHKOL();
	}

	// Token: 0x06006061 RID: 24673 RVA: 0x00312564 File Offset: 0x00310764
	public void MOQELDDNILJ(CommandBuffer KLIOPLGOLQC)
	{
		BuiltinDebugViewsModel.Settings settings = base.FIFNHCKNDQE.IKIPBLGNBKQ();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("dispMode");
		material.shaderKeywords = null;
		if (this.BEHMQBIFCOJ.MEPHDLOPGDJ())
		{
			material.EnableKeyword(".");
		}
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = settings.mode;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.Normals)
				{
					this.ELGGMNLDNHB(KLIOPLGOLQC);
				}
			}
			else
			{
				this.GKBLPDLHKKQ(KLIOPLGOLQC);
			}
		}
		else
		{
			this.PMMLGMNJQIL(KLIOPLGOLQC);
		}
		this.BEHMQBIFCOJ.OIONKMPKBKJ();
	}

	// Token: 0x06006062 RID: 24674 RVA: 0x003125EC File Offset: 0x003107EC
	public DepthTextureMode PCHMOJGLMQN()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.DCBJMHJEFMG().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Normals)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.None)
				{
					depthTextureMode |= DepthTextureMode.None;
				}
			}
			else
			{
				depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		return depthTextureMode;
	}

	// Token: 0x06006063 RID: 24675 RVA: 0x00312630 File Offset: 0x00310830
	public CameraEvent BLOGCGBMFOB()
	{
		return (base.FIFNHCKNDQE.ICJOMIGQMFC().mode != BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation) ? ((CameraEvent)81) : ((CameraEvent)(-107));
	}

	// Token: 0x06006064 RID: 24676 RVA: 0x0031265C File Offset: 0x0031085C
	public override CameraEvent KHFMCINEPGH()
	{
		return (base.FIFNHCKNDQE.settings.mode != BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors) ? CameraEvent.BeforeImageEffectsOpaque : CameraEvent.BeforeImageEffects;
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x06006065 RID: 24677 RVA: 0x00025BBD File Offset: 0x00023DBD
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth) || base.FIFNHCKNDQE.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals) || base.FIFNHCKNDQE.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors);
		}
	}

	// Token: 0x06006066 RID: 24678 RVA: 0x00312688 File Offset: 0x00310888
	public override DepthTextureMode FDQNPDGFNHH()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.settings.mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.Normals)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)
				{
					depthTextureMode |= DepthTextureMode.Depth;
				}
			}
			else
			{
				depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.DepthNormals;
		}
		return depthTextureMode;
	}

	// Token: 0x06006067 RID: 24679 RVA: 0x00025BEA File Offset: 0x00023DEA
	public string LDJBJIMQQDM()
	{
		return "FOG_SCATTERING_ON";
	}

	// Token: 0x06006068 RID: 24680 RVA: 0x00025BF1 File Offset: 0x00023DF1
	public bool DPEGBIKCKMJ()
	{
		return !base.FIFNHCKNDQE.MFMGQGBEONI(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth) && !base.FIFNHCKNDQE.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.None) && base.FIFNHCKNDQE.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth);
	}

	// Token: 0x06006069 RID: 24681 RVA: 0x003126CC File Offset: 0x003108CC
	public CameraEvent GFKFJBNBLPL()
	{
		return (base.FIFNHCKNDQE.settings.mode != BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut) ? ((CameraEvent)(-2)) : ((CameraEvent)(-84));
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x00025C1E File Offset: 0x00023E1E
	public string CCECNCCIDOG()
	{
		return "qTrack";
	}

	// Token: 0x0600606B RID: 24683 RVA: 0x00025C25 File Offset: 0x00023E25
	public bool NMLQJHEPGJO()
	{
		return base.FIFNHCKNDQE.NHJLBCFQCGD(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth) || base.FIFNHCKNDQE.JMMJGNMOPLE(BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors) || base.FIFNHCKNDQE.QCHGPHFJMOI(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut);
	}

	// Token: 0x0600606C RID: 24684 RVA: 0x003126F8 File Offset: 0x003108F8
	private void FEMMQBLKPBQ()
	{
		int motionVectorsResolution = base.FIFNHCKNDQE.settings.motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.GOGIILNHNBF == null)
		{
			this.GOGIILNHNBF = new MCBPLMFFGJC.PDLNKHMEJDP();
		}
		if (this.GOGIILNHNBF.QCOPDPHFQBI != num || this.GOGIILNHNBF.PBLFMBGKIIH != motionVectorsResolution)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
			this.GOGIILNHNBF.MLGPPKCKDDJ(num, motionVectorsResolution);
		}
	}

	// Token: 0x0600606D RID: 24685 RVA: 0x00312774 File Offset: 0x00310974
	private void QQJEHLJDIEQ(CommandBuffer KLIOPLGOLQC)
	{
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Builtin Debug Views");
		KLIOPLGOLQC.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 1);
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x003127A8 File Offset: 0x003109A8
	private void NDGDKLKDCPQ()
	{
		int motionVectorsResolution = base.FIFNHCKNDQE.DDCKCBDHLCL().motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.GOGIILNHNBF == null)
		{
			this.GOGIILNHNBF = new MCBPLMFFGJC.PDLNKHMEJDP();
		}
		if (this.GOGIILNHNBF.JEHGKEJMDEC() != num || this.GOGIILNHNBF.FEIGIHIQDEH() != motionVectorsResolution)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
			this.GOGIILNHNBF.KNDPFGGKPLB(num, motionVectorsResolution);
		}
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x00312824 File Offset: 0x00310A24
	public CameraEvent NFKFHLQIGKI()
	{
		return (base.FIFNHCKNDQE.settings.mode != BuiltinDebugViewsModel.HMFGKHHHIPL.None) ? CameraEvent.BeforeForwardAlpha : CameraEvent.BeforeHaloAndLensFlares;
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x00312850 File Offset: 0x00310A50
	private void GHDHBIIGBQC()
	{
		int motionVectorsResolution = base.FIFNHCKNDQE.LKMFKJDJDOK().motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.GOGIILNHNBF == null)
		{
			this.GOGIILNHNBF = new MCBPLMFFGJC.PDLNKHMEJDP();
		}
		if (this.GOGIILNHNBF.JEHGKEJMDEC() != num || this.GOGIILNHNBF.LNEOMDBJOMJ() != motionVectorsResolution)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
			this.GOGIILNHNBF.FCDOKJCFIJL(num, motionVectorsResolution);
		}
	}

	// Token: 0x06006071 RID: 24689 RVA: 0x003128CC File Offset: 0x00310ACC
	public CameraEvent BGMCNHLCNJB()
	{
		return (base.FIFNHCKNDQE.LKMFKJDJDOK().mode != BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog) ? ((CameraEvent)(-41)) : ((CameraEvent)72);
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x00025B5B File Offset: 0x00023D5B
	public override void MEGLEJHOGQK()
	{
		if (this.GOGIILNHNBF != null)
		{
			this.GOGIILNHNBF.DGMKGLLBMFG();
		}
		this.GOGIILNHNBF = null;
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x003128F8 File Offset: 0x00310AF8
	public DepthTextureMode NEOKIKBHMMJ()
	{
		BuiltinDebugViewsModel.HMFGKHHHIPL mode = base.FIFNHCKNDQE.IKIPBLGNBKQ().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation)
		{
			if (mode != BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog)
			{
				if (mode == BuiltinDebugViewsModel.HMFGKHHHIPL.None)
				{
					depthTextureMode |= DepthTextureMode.Depth;
				}
			}
			else
			{
				depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
			}
		}
		else
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		return depthTextureMode;
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x0031293C File Offset: 0x00310B3C
	private void NNDOLOPHLHN(CommandBuffer KLIOPLGOLQC)
	{
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KGNOHIQHHFK("_ClipRange1");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.FIFNHCKNDQE.QFDBNIMIDHO().motionVectors;
		int nameID = MCBPLMFFGJC.DNIJIPQFDBF.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(nameID, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 1, FilterMode.Point);
		KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.sourceOpacity);
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, nameID, material, 7);
		if (motionVectors.motionImageOpacity > 858f && motionVectors.motionImageAmplitude > 1376f)
		{
			int kkpbfdbdfkn = MCBPLMFFGJC.DNIJIPQFDBF.KKPBFDBDFKN;
			KLIOPLGOLQC.GetTemporaryRT(kkpbfdbdfkn, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, FilterMode.Bilinear);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionImageOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionImageAmplitude);
			KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, kkpbfdbdfkn, material, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
			nameID = kkpbfdbdfkn;
		}
		if (motionVectors.motionVectorsOpacity > 743f && motionVectors.motionVectorsAmplitude > 367f)
		{
			this.GHDHBIIGBQC();
			float num = 37f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.BEHMQBIFCOJ.CHODJCGKMOK();
			KLIOPLGOLQC.SetGlobalVector(MCBPLMFFGJC.DNIJIPQFDBF.QPNKJBBQHMJ, new Vector2(x, num));
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.DNJFKENFKKQ, motionVectors.motionVectorsOpacity);
			KLIOPLGOLQC.SetGlobalFloat(MCBPLMFFGJC.DNIJIPQFDBF.BHIFIQGGCMD, motionVectors.motionVectorsAmplitude);
			KLIOPLGOLQC.DrawMesh(this.GOGIILNHNBF.BCMJFMFFFKI(), Matrix4x4.identity, material, 0, 6);
		}
		KLIOPLGOLQC.SetGlobalTexture(MCBPLMFFGJC.DNIJIPQFDBF.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0400149C RID: 5276
	private const string OEEBQBQIEPO = "Hidden/Post FX/Builtin Debug Views";

	// Token: 0x0400149D RID: 5277
	private MCBPLMFFGJC.PDLNKHMEJDP GOGIILNHNBF;

	// Token: 0x020002B4 RID: 692
	private static class DNIJIPQFDBF
	{
		// Token: 0x0400149E RID: 5278
		internal static readonly int CKBQLKHQIBQ = Shader.PropertyToID("_DepthScale");

		// Token: 0x0400149F RID: 5279
		internal static readonly int HJHQQCBOBPP = Shader.PropertyToID("_TempRT");

		// Token: 0x040014A0 RID: 5280
		internal static readonly int DNJFKENFKKQ = Shader.PropertyToID("_Opacity");

		// Token: 0x040014A1 RID: 5281
		internal static readonly int OKKONPEBLHN = Shader.PropertyToID("_MainTex");

		// Token: 0x040014A2 RID: 5282
		internal static readonly int KKPBFDBDFKN = Shader.PropertyToID("_TempRT2");

		// Token: 0x040014A3 RID: 5283
		internal static readonly int BHIFIQGGCMD = Shader.PropertyToID("_Amplitude");

		// Token: 0x040014A4 RID: 5284
		internal static readonly int QPNKJBBQHMJ = Shader.PropertyToID("_Scale");
	}

	// Token: 0x020002B5 RID: 693
	private enum NLKJEFMFICO
	{
		// Token: 0x040014A6 RID: 5286
		Depth,
		// Token: 0x040014A7 RID: 5287
		Normals,
		// Token: 0x040014A8 RID: 5288
		MovecOpacity,
		// Token: 0x040014A9 RID: 5289
		MovecImaging,
		// Token: 0x040014AA RID: 5290
		MovecArrows
	}

	// Token: 0x020002B6 RID: 694
	private class PDLNKHMEJDP
	{
		// Token: 0x06006076 RID: 24694 RVA: 0x00025C52 File Offset: 0x00023E52
		private void PIHKDQPPQFM(int BGBMIEJJQKC)
		{
			this.<BFNJOBLKFLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00312BB8 File Offset: 0x00310DB8
		public void PNCODMEGLCD(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[1];
			array[0] = new Vector3(310f, 1295f, 1214f);
			array[1] = new Vector3(860f, 1455f, 374f);
			array[4] = new Vector3(1902f, 1012f, 1284f);
			array[4] = new Vector3(320f, 1373f, 1379f);
			array[8] = new Vector3(1005f, 1128f, 1759f);
			array[3] = new Vector3(845f, 880f, 808f);
			Vector3[] array2 = array;
			int num = 7 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 1; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((588f + (float)j) / (float)QFLMCBIFGNM, (935f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 7; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.KGEPQNPMMKJ(new Mesh
			{
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			});
			this.FFQOMMNDHQH().SetVertices(list);
			this.NFOOEHBKFMG.SetUVs(1, list2);
			this.FFQOMMNDHQH().SetIndices(array3, MeshTopology.Points, 0);
			this.FFQOMMNDHQH().UploadMeshData(false);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.GCLQPBPCMHL(QGJCOPIMMFN);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x00025C5B File Offset: 0x00023E5B
		public void DGMKGLLBMFG()
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.NFOOEHBKFMG);
			this.NFOOEHBKFMG = null;
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void BCLPDCJNGCF(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060060A7 RID: 24743 RVA: 0x00025C81 File Offset: 0x00023E81
		// (set) Token: 0x0600607A RID: 24698 RVA: 0x00025C78 File Offset: 0x00023E78
		public Mesh NFOOEHBKFMG { get; private set; }

		// Token: 0x0600607B RID: 24699 RVA: 0x00312D84 File Offset: 0x00310F84
		public void OFKEJPEGPME(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[]
			{
				new Vector3(1935f, 852f, 1052f)
			};
			array[0] = new Vector3(427f, 845f, 1037f);
			array[7] = new Vector3(1095f, 1689f, 963f);
			array[0] = new Vector3(1307f, 1446f, 370f);
			array[1] = new Vector3(106f, 424f, 1975f);
			array[4] = new Vector3(930f, 496f, 1666f);
			Vector3[] array2 = array;
			int num = 1 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 1; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((714f + (float)j) / (float)QFLMCBIFGNM, (1782f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 7; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.ODNQQGQCCQQ(new Mesh
			{
				hideFlags = (HideFlags)98
			});
			this.JEOGQMHMQNN().SetVertices(list);
			this.BCMJFMFFFKI().SetUVs(1, list2);
			this.PPMIMQNOGQF().SetIndices(array3, MeshTopology.Points, 0);
			this.HODHCOBFPIH().UploadMeshData(true);
			this.HLLHHQCDBEG(QFLMCBIFGNM);
			this.BCLPDCJNGCF(QGJCOPIMMFN);
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x00312F50 File Offset: 0x00311150
		public void PPDBOKMDHBI(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[5];
			array[1] = new Vector3(792f, 1739f, 1047f);
			array[0] = new Vector3(821f, 307f, 393f);
			array[4] = new Vector3(139f, 995f, 576f);
			array[6] = new Vector3(10f, 857f, 994f);
			array[1] = new Vector3(183f, 263f, 209f);
			array[7] = new Vector3(303f, 1570f, 845f);
			Vector3[] array2 = array;
			int num = 4 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 0; j < QFLMCBIFGNM; j++)
				{
					Vector2 item = new Vector2((1438f + (float)j) / (float)QFLMCBIFGNM, (1024f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 1; k < 7; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.KDQEJGHQPND(new Mesh
			{
				hideFlags = (HideFlags)(-80)
			});
			this.NFOOEHBKFMG.SetVertices(list);
			this.FFQOMMNDHQH().SetUVs(0, list2);
			this.NCCLKDQCOQD().SetIndices(array3, (MeshTopology)6, 0);
			this.HODHCOBFPIH().UploadMeshData(true);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.PBLFMBGKIIH = QGJCOPIMMFN;
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh HCDMJLDLEOI()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00025C78 File Offset: 0x00023E78
		private void KGEPQNPMMKJ(Mesh BGBMIEJJQKC)
		{
			this.<GFQGGNCOECM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x0031311C File Offset: 0x0031131C
		public void KNDPFGGKPLB(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[2];
			array[0] = new Vector3(372f, 1897f, 1071f);
			array[0] = new Vector3(1687f, 1734f, 746f);
			array[1] = new Vector3(1167f, 1813f, 634f);
			array[6] = new Vector3(1376f, 178f, 23f);
			array[3] = new Vector3(1355f, 1892f, 1848f);
			array[8] = new Vector3(202f, 1600f, 472f);
			Vector3[] array2 = array;
			int num = 7 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 1; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((1989f + (float)j) / (float)QFLMCBIFGNM, (31f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 1; k < 8; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.NFOOEHBKFMG = new Mesh
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			};
			this.BCMJFMFFFKI().SetVertices(list);
			this.JEOGQMHMQNN().SetUVs(0, list2);
			this.NFOOEHBKFMG.SetIndices(array3, MeshTopology.Lines, 0);
			this.FFQOMMNDHQH().UploadMeshData(false);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.GCLQPBPCMHL(QGJCOPIMMFN);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x00025C89 File Offset: 0x00023E89
		public int OHEMGBGQCKE()
		{
			return this.<BFNJOBLKFLI>k__BackingField;
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x00025C91 File Offset: 0x00023E91
		// (set) Token: 0x0600609A RID: 24730 RVA: 0x00025C6F File Offset: 0x00023E6F
		public int PBLFMBGKIIH { get; private set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x00025C89 File Offset: 0x00023E89
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x00025C52 File Offset: 0x00023E52
		public int QCOPDPHFQBI { get; private set; }

		// Token: 0x06006083 RID: 24707 RVA: 0x00025C91 File Offset: 0x00023E91
		public int QOBCGIKQLFD()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x00025C78 File Offset: 0x00023E78
		private void NDQEIFLKOGK(Mesh BGBMIEJJQKC)
		{
			this.<GFQGGNCOECM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x00025C89 File Offset: 0x00023E89
		public int JEHGKEJMDEC()
		{
			return this.<BFNJOBLKFLI>k__BackingField;
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void MOJMNJPOMFE(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void ONPQCMMIDCL(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00025C78 File Offset: 0x00023E78
		private void KDQEJGHQPND(Mesh BGBMIEJJQKC)
		{
			this.<GFQGGNCOECM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00025C99 File Offset: 0x00023E99
		public void ILNFGENJLKN()
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.NFOOEHBKFMG);
			this.KGEPQNPMMKJ(null);
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00025C52 File Offset: 0x00023E52
		private void HLLHHQCDBEG(int BGBMIEJJQKC)
		{
			this.<BFNJOBLKFLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00025C78 File Offset: 0x00023E78
		private void GEQKENBKOBH(Mesh BGBMIEJJQKC)
		{
			this.<GFQGGNCOECM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x003132E8 File Offset: 0x003114E8
		public void FEEBCFFNJKP(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[0];
			array[0] = new Vector3(1300f, 878f, 1702f);
			array[1] = new Vector3(444f, 65f, 1320f);
			array[3] = new Vector3(536f, 1857f, 746f);
			array[0] = new Vector3(771f, 1425f, 1417f);
			array[7] = new Vector3(635f, 1744f, 715f);
			array[1] = new Vector3(1069f, 1860f, 1653f);
			Vector3[] array2 = array;
			int num = 0 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(0);
			List<Vector2> list2 = new List<Vector2>(0);
			for (int i = 1; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 1; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((786f + (float)j) / (float)QFLMCBIFGNM, (13f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 4; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.ODNQQGQCCQQ(new Mesh
			{
				hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			});
			this.PPMIMQNOGQF().SetVertices(list);
			this.PPMIMQNOGQF().SetUVs(0, list2);
			this.PPMIMQNOGQF().SetIndices(array3, (MeshTopology)7, 1);
			this.PPMIMQNOGQF().UploadMeshData(true);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.OIQMJIDFKJE(QGJCOPIMMFN);
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x003134B4 File Offset: 0x003116B4
		public void FCDOKJCFIJL(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[3];
			array[0] = new Vector3(1324f, 967f, 251f);
			array[1] = new Vector3(140f, 994f, 694f);
			array[8] = new Vector3(1308f, 566f, 305f);
			array[3] = new Vector3(1108f, 968f, 1150f);
			array[6] = new Vector3(1668f, 1346f, 520f);
			array[4] = new Vector3(1469f, 1634f, 3f);
			Vector3[] array2 = array;
			int num = 0 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(0);
			List<Vector2> list2 = new List<Vector2>(0);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 0; j < QFLMCBIFGNM; j++)
				{
					Vector2 item = new Vector2((624f + (float)j) / (float)QFLMCBIFGNM, (326f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 1; k < 2; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.NDQEIFLKOGK(new Mesh
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			});
			this.NFOOEHBKFMG.SetVertices(list);
			this.HODHCOBFPIH().SetUVs(0, list2);
			this.HCDMJLDLEOI().SetIndices(array3, MeshTopology.Quads, 0);
			this.BCMJFMFFFKI().UploadMeshData(false);
			this.QCOPDPHFQBI = QFLMCBIFGNM;
			this.OIQMJIDFKJE(QGJCOPIMMFN);
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x00025C89 File Offset: 0x00023E89
		public int KBJLBFCIQJF()
		{
			return this.<BFNJOBLKFLI>k__BackingField;
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00025C52 File Offset: 0x00023E52
		private void MBDPFDKEEID(int BGBMIEJJQKC)
		{
			this.<BFNJOBLKFLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x00025C91 File Offset: 0x00023E91
		public int ENJPBBMMJQC()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x00025C78 File Offset: 0x00023E78
		private void ODNQQGQCCQQ(Mesh BGBMIEJJQKC)
		{
			this.<GFQGGNCOECM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void ODDDCLIMDHI(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void GCLQPBPCMHL(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x00025C91 File Offset: 0x00023E91
		public int BQDQDPJICIM()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x00025C91 File Offset: 0x00023E91
		public int CKFJLCLQQIL()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x00025C89 File Offset: 0x00023E89
		public int CEFDHIEHGQJ()
		{
			return this.<BFNJOBLKFLI>k__BackingField;
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh JEOGQMHMQNN()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x00025C91 File Offset: 0x00023E91
		public int FEIGIHIQDEH()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh FFQOMMNDHQH()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x00313680 File Offset: 0x00311880
		public void GGGGDGNQPGH(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[6];
			array[0] = new Vector3(867f, 404f, 1388f);
			array[0] = new Vector3(1321f, 1195f, 1956f);
			array[7] = new Vector3(1158f, 782f, 334f);
			array[2] = new Vector3(494f, 359f, 645f);
			array[7] = new Vector3(1585f, 1167f, 1583f);
			array[8] = new Vector3(612f, 120f, 84f);
			Vector3[] array2 = array;
			int num = 0 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(0);
			List<Vector2> list2 = new List<Vector2>(0);
			for (int i = 0; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 0; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((1850f + (float)j) / (float)QFLMCBIFGNM, (580f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 1; k < 8; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.ODNQQGQCCQQ(new Mesh
			{
				hideFlags = (HideFlags)(-72)
			});
			this.NCCLKDQCOQD().SetVertices(list);
			this.NFOOEHBKFMG.SetUVs(0, list2);
			this.JEOGQMHMQNN().SetIndices(array3, MeshTopology.Points, 1);
			this.PPMIMQNOGQF().UploadMeshData(true);
			this.QCOPDPHFQBI = QFLMCBIFGNM;
			this.EPLGHNKOCCC(QGJCOPIMMFN);
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x00025CAD File Offset: 0x00023EAD
		public void PMBQJMFGJMI()
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.NCCLKDQCOQD());
			this.GEQKENBKOBH(null);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh PPMIMQNOGQF()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x00025C91 File Offset: 0x00023E91
		public int MCFLCHKMKHC()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x0031384C File Offset: 0x00311A4C
		public void IPBHCQEKCCP(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[8];
			array[0] = new Vector3(1195f, 1185f, 368f);
			array[0] = new Vector3(1274f, 1622f, 1654f);
			array[6] = new Vector3(1617f, 1439f, 1185f);
			array[3] = new Vector3(43f, 1262f, 130f);
			array[5] = new Vector3(1461f, 1005f, 101f);
			array[2] = new Vector3(503f, 1293f, 687f);
			Vector3[] array2 = array;
			int num = 2 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 0; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((1968f + (float)j) / (float)QFLMCBIFGNM, (230f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 4; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.KDQEJGHQPND(new Mesh
			{
				hideFlags = (HideFlags)67
			});
			this.HODHCOBFPIH().SetVertices(list);
			this.HODHCOBFPIH().SetUVs(1, list2);
			this.BCMJFMFFFKI().SetIndices(array3, (MeshTopology)7, 0);
			this.HCDMJLDLEOI().UploadMeshData(true);
			this.HLLHHQCDBEG(QFLMCBIFGNM);
			this.PBLFMBGKIIH = QGJCOPIMMFN;
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x00025C91 File Offset: 0x00023E91
		public int IBEQOILIPOK()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00025C89 File Offset: 0x00023E89
		public int DPHIQKJBMMC()
		{
			return this.<BFNJOBLKFLI>k__BackingField;
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void EPLGHNKOCCC(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh HODHCOBFPIH()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00313A18 File Offset: 0x00311C18
		public void MNHFQMCNKMG(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[8];
			array[1] = new Vector3(1224f, 1564f, 289f);
			array[1] = new Vector3(1279f, 1307f, 286f);
			array[7] = new Vector3(920f, 566f, 41f);
			array[0] = new Vector3(253f, 642f, 737f);
			array[4] = new Vector3(199f, 749f, 1836f);
			array[7] = new Vector3(444f, 530f, 1676f);
			Vector3[] array2 = array;
			int num = 4 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 0; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((582f + (float)j) / (float)QFLMCBIFGNM, (1177f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 5; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.KDQEJGHQPND(new Mesh
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset)
			});
			this.BCMJFMFFFKI().SetVertices(list);
			this.JEOGQMHMQNN().SetUVs(1, list2);
			this.NCCLKDQCOQD().SetIndices(array3, MeshTopology.Triangles, 0);
			this.HODHCOBFPIH().UploadMeshData(true);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.GCLQPBPCMHL(QGJCOPIMMFN);
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00313BE4 File Offset: 0x00311DE4
		public void NDEPOGQPFEF(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[0];
			array[1] = new Vector3(149f, 1170f, 1879f);
			array[1] = new Vector3(1062f, 1902f, 1884f);
			array[6] = new Vector3(1527f, 1429f, 487f);
			array[7] = new Vector3(1021f, 870f, 867f);
			array[6] = new Vector3(82f, 677f, 1442f);
			array[4] = new Vector3(1556f, 502f, 1546f);
			Vector3[] array2 = array;
			int num = 3 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 1; j < QFLMCBIFGNM; j++)
				{
					Vector2 item = new Vector2((619f + (float)j) / (float)QFLMCBIFGNM, (1204f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 0; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.KDQEJGHQPND(new Mesh
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			});
			this.HODHCOBFPIH().SetVertices(list);
			this.NFOOEHBKFMG.SetUVs(1, list2);
			this.NFOOEHBKFMG.SetIndices(array3, MeshTopology.Points, 0);
			this.JEOGQMHMQNN().UploadMeshData(true);
			this.MBDPFDKEEID(QFLMCBIFGNM);
			this.PBLFMBGKIIH = QGJCOPIMMFN;
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00313DB0 File Offset: 0x00311FB0
		public void HIGPHEGPJOB(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[5];
			array[0] = new Vector3(510f, 1510f, 1249f);
			array[0] = new Vector3(1902f, 497f, 1770f);
			array[6] = new Vector3(443f, 1654f, 1424f);
			array[4] = new Vector3(785f, 459f, 1131f);
			array[0] = new Vector3(319f, 1292f, 601f);
			array[8] = new Vector3(1715f, 190f, 136f);
			Vector3[] array2 = array;
			int num = 8 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 0; j < QFLMCBIFGNM; j += 0)
				{
					Vector2 item = new Vector2((1368f + (float)j) / (float)QFLMCBIFGNM, (10f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 3; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.KGEPQNPMMKJ(new Mesh
			{
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			});
			this.NFOOEHBKFMG.SetVertices(list);
			this.FFQOMMNDHQH().SetUVs(1, list2);
			this.JEOGQMHMQNN().SetIndices(array3, (MeshTopology)6, 0);
			this.HODHCOBFPIH().UploadMeshData(true);
			this.HLLHHQCDBEG(QFLMCBIFGNM);
			this.GCLQPBPCMHL(QGJCOPIMMFN);
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00025C6F File Offset: 0x00023E6F
		private void OIQMJIDFKJE(int BGBMIEJJQKC)
		{
			this.<GQDDEOENKPL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh NCCLKDQCOQD()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00313F7C File Offset: 0x0031217C
		public void MLGPPKCKDDJ(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[]
			{
				new Vector3(0f, 0f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(-1f, 1f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(1f, 1f, 0f)
			};
			int num = 6 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i++)
			{
				for (int j = 0; j < QFLMCBIFGNM; j++)
				{
					Vector2 item = new Vector2((0.5f + (float)j) / (float)QFLMCBIFGNM, (0.5f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 6; k++)
					{
						list.Add(array[k]);
						list2.Add(item);
					}
				}
			}
			int[] array2 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array2[l] = l;
			}
			this.NFOOEHBKFMG = new Mesh
			{
				hideFlags = HideFlags.DontSave
			};
			this.NFOOEHBKFMG.SetVertices(list);
			this.NFOOEHBKFMG.SetUVs(0, list2);
			this.NFOOEHBKFMG.SetIndices(array2, MeshTopology.Lines, 0);
			this.NFOOEHBKFMG.UploadMeshData(true);
			this.QCOPDPHFQBI = QFLMCBIFGNM;
			this.PBLFMBGKIIH = QGJCOPIMMFN;
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00025C91 File Offset: 0x00023E91
		public int LNEOMDBJOMJ()
		{
			return this.<GQDDEOENKPL>k__BackingField;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00025C81 File Offset: 0x00023E81
		public Mesh BCMJFMFFFKI()
		{
			return this.<GFQGGNCOECM>k__BackingField;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00314148 File Offset: 0x00312348
		public void OGGHPODBDGJ(int QFLMCBIFGNM, int QGJCOPIMMFN)
		{
			Vector3[] array = new Vector3[4];
			array[1] = new Vector3(693f, 1487f, 1690f);
			array[1] = new Vector3(1221f, 893f, 2f);
			array[8] = new Vector3(576f, 869f, 1368f);
			array[4] = new Vector3(678f, 1341f, 887f);
			array[3] = new Vector3(1548f, 1546f, 618f);
			array[0] = new Vector3(668f, 162f, 992f);
			Vector3[] array2 = array;
			int num = 5 * QFLMCBIFGNM * QGJCOPIMMFN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < QGJCOPIMMFN; i += 0)
			{
				for (int j = 1; j < QFLMCBIFGNM; j++)
				{
					Vector2 item = new Vector2((1308f + (float)j) / (float)QFLMCBIFGNM, (835f + (float)i) / (float)QGJCOPIMMFN);
					for (int k = 0; k < 1; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.KGEPQNPMMKJ(new Mesh
			{
				hideFlags = (HideFlags)(-103)
			});
			this.BCMJFMFFFKI().SetVertices(list);
			this.PPMIMQNOGQF().SetUVs(1, list2);
			this.JEOGQMHMQNN().SetIndices(array3, MeshTopology.LineStrip, 0);
			this.NCCLKDQCOQD().UploadMeshData(true);
			this.PIHKDQPPQFM(QFLMCBIFGNM);
			this.OIQMJIDFKJE(QGJCOPIMMFN);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x00025CAD File Offset: 0x00023EAD
		public void LJFCOIKLHCF()
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.NCCLKDQCOQD());
			this.GEQKENBKOBH(null);
		}
	}
}
