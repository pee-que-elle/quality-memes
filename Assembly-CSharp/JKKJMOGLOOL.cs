using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x020002C7 RID: 711
public sealed class JKKJMOGLOOL : NHOOQNHPFOB<MotionBlurModel>
{
	// Token: 0x060062F4 RID: 25332 RVA: 0x00026ACD File Offset: 0x00024CCD
	public void PFHNDLKEHEP()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LKHHEMNNHED();
		}
		this.NJMNPIEGBDP = null;
	}

	// Token: 0x060062F5 RID: 25333 RVA: 0x00026AE9 File Offset: 0x00024CE9
	public string NBEPDEIGPJI()
	{
		return "Assets/AssetBundles/PokemonSprites/";
	}

	// Token: 0x060062F6 RID: 25334 RVA: 0x00026AF0 File Offset: 0x00024CF0
	public override CameraEvent KHFMCINEPGH()
	{
		return CameraEvent.BeforeImageEffects;
	}

	// Token: 0x060062F7 RID: 25335 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK KDHPBMINJBC()
	{
		if (this.QPJFDHCCDFL == null)
		{
			this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
		}
		return this.QPJFDHCCDFL;
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x060062F8 RID: 25336 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK JLJQKLMJLGE
	{
		get
		{
			if (this.QPJFDHCCDFL == null)
			{
				this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
			}
			return this.QPJFDHCCDFL;
		}
	}

	// Token: 0x060062F9 RID: 25337 RVA: 0x0000D051 File Offset: 0x0000B251
	public DepthTextureMode JIKIBMKOOBC()
	{
		return DepthTextureMode.DepthNormals;
	}

	// Token: 0x060062FA RID: 25338 RVA: 0x00026B0F File Offset: 0x00024D0F
	public void BIQLBDMMDFK()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x060062FB RID: 25339 RVA: 0x00026B18 File Offset: 0x00024D18
	public string PBHMLIIECOJ()
	{
		return "[msg]";
	}

	// Token: 0x060062FC RID: 25340 RVA: 0x00026B1F File Offset: 0x00024D1F
	public void HNPKPINGJID()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x060062FD RID: 25341 RVA: 0x00026B28 File Offset: 0x00024D28
	public string DDPMKPODBKK()
	{
		return "phscore";
	}

	// Token: 0x060062FE RID: 25342 RVA: 0x00026B2F File Offset: 0x00024D2F
	public JKKJMOGLOOL.PPNOJFGEGEL INIGBNIQBPI()
	{
		if (this.NJMNPIEGBDP == null)
		{
			this.NJMNPIEGBDP = new JKKJMOGLOOL.PPNOJFGEGEL();
		}
		return this.NJMNPIEGBDP;
	}

	// Token: 0x060062FF RID: 25343 RVA: 0x00026B4A File Offset: 0x00024D4A
	public void NLFHDFBHPLN()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LPQIKIFQJMF();
		}
	}

	// Token: 0x06006300 RID: 25344 RVA: 0x00026B5F File Offset: 0x00024D5F
	public string FJHEKJPPHEP()
	{
		return "[FF6600]";
	}

	// Token: 0x06006301 RID: 25345 RVA: 0x00026B66 File Offset: 0x00024D66
	public override string QPDGCILDFLP()
	{
		return "Motion Blur";
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x00026B6D File Offset: 0x00024D6D
	public void CCOGQNPFCLH()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LKJCCHGDKFG();
		}
		this.NJMNPIEGBDP = null;
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK QPBCCFPPKLC()
	{
		if (this.QPJFDHCCDFL == null)
		{
			this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
		}
		return this.QPJFDHCCDFL;
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x00026B89 File Offset: 0x00024D89
	public void GCIEMOEHNFE()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.NJEHMLKGJHG();
		}
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x00026B2F File Offset: 0x00024D2F
	public JKKJMOGLOOL.PPNOJFGEGEL IOMMOJDOOFL()
	{
		if (this.NJMNPIEGBDP == null)
		{
			this.NJMNPIEGBDP = new JKKJMOGLOOL.PPNOJFGEGEL();
		}
		return this.NJMNPIEGBDP;
	}

	// Token: 0x06006306 RID: 25350 RVA: 0x00026B9E File Offset: 0x00024D9E
	public CameraEvent QQGHOBPQDNH()
	{
		return (CameraEvent)(-38);
	}

	// Token: 0x06006307 RID: 25351 RVA: 0x00326720 File Offset: 0x00324920
	public bool EPEEBMIMHDB()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.IEDQPECKQDN();
		return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 939f && this.NFCHDIJILDM().FKJMEEJEGMD()) || settings.frameBlending > 1390f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Null && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006308 RID: 25352 RVA: 0x00026BA2 File Offset: 0x00024DA2
	public void DDPPFDCQGBM()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.BEENOEDBNGK();
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06006309 RID: 25353 RVA: 0x00326788 File Offset: 0x00324988
	public override bool NGQJLIEBFOM
	{
		get
		{
			MotionBlurModel.Settings settings = base.FIFNHCKNDQE.settings;
			return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 0f && this.JLJQKLMJLGE.FKJMEEJEGMD()) || settings.frameBlending > 0f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLES2 && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600630A RID: 25354 RVA: 0x00026BB7 File Offset: 0x00024DB7
	public DepthTextureMode IKIOJBCGLJO()
	{
		return DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors;
	}

	// Token: 0x0600630B RID: 25355 RVA: 0x00026BBA File Offset: 0x00024DBA
	public string POPOJMOJHKE()
	{
		return "Aargh! Almost had it!\r\n";
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x003267F0 File Offset: 0x003249F0
	public bool LCDBCLGJFOQ()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.GQBFLONJOEC();
		return !base.FIFNHCKNDQE.enabled || ((settings.shutterAngle <= 1074f || !this.HQDDNLGKJKQ().FKJMEEJEGMD()) && settings.frameBlending <= 967f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x00026B0F File Offset: 0x00024D0F
	public void MCIOHHBPLGO()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x00026BC1 File Offset: 0x00024DC1
	public override DepthTextureMode FDQNPDGFNHH()
	{
		return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x00026BC4 File Offset: 0x00024DC4
	public void DIIHNJDHMGF()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.INIDPNCJQGD();
		}
		this.NJMNPIEGBDP = null;
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x00026B1F File Offset: 0x00024D1F
	public void KBJOKEMFQFN()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK GJELLBOGNMK()
	{
		if (this.QPJFDHCCDFL == null)
		{
			this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
		}
		return this.QPJFDHCCDFL;
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK HQDDNLGKJKQ()
	{
		if (this.QPJFDHCCDFL == null)
		{
			this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
		}
		return this.QPJFDHCCDFL;
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x00026BE0 File Offset: 0x00024DE0
	public void GIJLJEIHDBC()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LPQIKIFQJMF();
		}
		this.NJMNPIEGBDP = null;
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x00326858 File Offset: 0x00324A58
	public bool DHHJCEFGDJN()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		return !base.FIFNHCKNDQE.enabled || ((settings.shutterAngle <= 262f || !this.GJELLBOGNMK().PQEJHFENJGE()) && settings.frameBlending <= 556f) || SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x00026BFC File Offset: 0x00024DFC
	public CameraEvent BLMQINCPFMI()
	{
		return (CameraEvent)55;
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x00026B2F File Offset: 0x00024D2F
	public JKKJMOGLOOL.PPNOJFGEGEL JPEKQFHJDHP()
	{
		if (this.NJMNPIEGBDP == null)
		{
			this.NJMNPIEGBDP = new JKKJMOGLOOL.PPNOJFGEGEL();
		}
		return this.NJMNPIEGBDP;
	}

	// Token: 0x06006317 RID: 25367 RVA: 0x00026AF4 File Offset: 0x00024CF4
	public JKKJMOGLOOL.HQFEEBJGHHK NFCHDIJILDM()
	{
		if (this.QPJFDHCCDFL == null)
		{
			this.QPJFDHCCDFL = new JKKJMOGLOOL.HQFEEBJGHHK();
		}
		return this.QPJFDHCCDFL;
	}

	// Token: 0x06006318 RID: 25368 RVA: 0x003268C0 File Offset: 0x00324AC0
	public override void EIQKCDHPCKK(CommandBuffer KLIOPLGOLQC)
	{
		if (this.MGDQKEIKDPO)
		{
			this.MGDQKEIKDPO = false;
			return;
		}
		Material pplipcehgnm = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Motion Blur");
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Blit");
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.settings;
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
		int hjhqqcbobpp = JKKJMOGLOOL.CFGJBNPCEHJ.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Point, format);
		if (settings.shutterAngle > 0f && settings.frameBlending > 0f)
		{
			this.JLJQKLMJLGE.QFDPJGLFPBN(this.BEHMQBIFCOJ, KLIOPLGOLQC, ref settings, BuiltinRenderTextureType.CameraTarget, hjhqqcbobpp, pplipcehgnm);
			this.DPPJEGFJOFH.FHPFDIQFGBK(KLIOPLGOLQC, settings.frameBlending, hjhqqcbobpp, BuiltinRenderTextureType.CameraTarget, pplipcehgnm);
			this.DPPJEGFJOFH.PMKQOGEBNDG(KLIOPLGOLQC, hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, pplipcehgnm);
		}
		else if (settings.shutterAngle > 0f)
		{
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, BuiltinRenderTextureType.CameraTarget);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, hjhqqcbobpp, mat, 0);
			this.JLJQKLMJLGE.QFDPJGLFPBN(this.BEHMQBIFCOJ, KLIOPLGOLQC, ref settings, hjhqqcbobpp, BuiltinRenderTextureType.CameraTarget, pplipcehgnm);
		}
		else if (settings.frameBlending > 0f)
		{
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, BuiltinRenderTextureType.CameraTarget);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, hjhqqcbobpp, mat, 0);
			this.DPPJEGFJOFH.FHPFDIQFGBK(KLIOPLGOLQC, settings.frameBlending, hjhqqcbobpp, BuiltinRenderTextureType.CameraTarget, pplipcehgnm);
			this.DPPJEGFJOFH.PMKQOGEBNDG(KLIOPLGOLQC, hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, pplipcehgnm);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x00326AC0 File Offset: 0x00324CC0
	public bool IODDLCIHECG()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.INPGLPEDINQ();
		return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 1816f && this.HQDDNLGKJKQ().EOPNOBFFBJP()) || settings.frameBlending > 270f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Direct3D11 && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x00026B0F File Offset: 0x00024D0F
	public override void MNIFEBDOGKD()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x0600631B RID: 25371 RVA: 0x00026C00 File Offset: 0x00024E00
	public void QJPDLCLJDNL()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.PJQOLKDCNOD();
		}
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x00026B1F File Offset: 0x00024D1F
	public void HBJBLMLMEBD()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x0600631D RID: 25373 RVA: 0x00026BE0 File Offset: 0x00024DE0
	public void KPECJMCFBJN()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LPQIKIFQJMF();
		}
		this.NJMNPIEGBDP = null;
	}

	// Token: 0x0600631F RID: 25375 RVA: 0x00026B4A File Offset: 0x00024D4A
	public override void MEGLEJHOGQK()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LPQIKIFQJMF();
		}
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x00326B28 File Offset: 0x00324D28
	public bool JFJDGFQDLKG()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.settings;
		return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 1056f && this.HQDDNLGKJKQ().EOPNOBFFBJP()) || settings.frameBlending > 216f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x00026C24 File Offset: 0x00024E24
	public CameraEvent DMOFJGOFMMQ()
	{
		return (CameraEvent)(-17);
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x00326B90 File Offset: 0x00324D90
	public bool DJINFDCBGKB()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 900f && this.JLJQKLMJLGE.FKJMEEJEGMD()) || settings.frameBlending > 1474f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Direct3D9 && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006323 RID: 25379 RVA: 0x00026C28 File Offset: 0x00024E28
	public void NNBNJQECJBE()
	{
		if (this.NJMNPIEGBDP != null)
		{
			this.NJMNPIEGBDP.LKJCCHGDKFG();
		}
	}

	// Token: 0x06006324 RID: 25380 RVA: 0x00026B0F File Offset: 0x00024D0F
	public void HJCCEHMKHQC()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006325 RID: 25381 RVA: 0x00026C3D File Offset: 0x00024E3D
	public string KLDCKPKLNCP()
	{
		return "!\r\n";
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x00326BF8 File Offset: 0x00324DF8
	public bool EEEJKHJQBPL()
	{
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.settings;
		return base.FIFNHCKNDQE.enabled && ((settings.shutterAngle > 642f && this.QPBCCFPPKLC().EOPNOBFFBJP()) || settings.frameBlending > 429f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Xbox360 && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006327 RID: 25383 RVA: 0x00326C60 File Offset: 0x00324E60
	public void EDGHIHODLBC(CommandBuffer KLIOPLGOLQC)
	{
		if (this.MGDQKEIKDPO)
		{
			this.MGDQKEIKDPO = false;
			return;
		}
		Material pplipcehgnm = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("(L)");
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.BLDGCMKLEBC("By putting pressure on the opposing Pokémon, it raises their PP usage.");
		MotionBlurModel.Settings settings = base.FIFNHCKNDQE.IEDQPECKQDN();
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-84));
		int hjhqqcbobpp = JKKJMOGLOOL.CFGJBNPCEHJ.HJHQQCBOBPP;
		KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Bilinear, format);
		if (settings.shutterAngle > 1641f && settings.frameBlending > 1791f)
		{
			this.QPBCCFPPKLC().LBHQBENHOBO(this.BEHMQBIFCOJ, KLIOPLGOLQC, ref settings, BuiltinRenderTextureType.CameraTarget, hjhqqcbobpp, pplipcehgnm);
			this.DPPJEGFJOFH.FHPFDIQFGBK(KLIOPLGOLQC, settings.frameBlending, hjhqqcbobpp, BuiltinRenderTextureType.PrepassNormalsSpec, pplipcehgnm);
			this.IOMMOJDOOFL().QFPMINOELOJ(KLIOPLGOLQC, hjhqqcbobpp, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), pplipcehgnm);
		}
		else if (settings.shutterAngle > 34f)
		{
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, BuiltinRenderTextureType.PrepassNormalsSpec);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.ResolvedDepth, hjhqqcbobpp, mat, 0);
			this.GJELLBOGNMK().IHHEKFINOKE(this.BEHMQBIFCOJ, KLIOPLGOLQC, ref settings, hjhqqcbobpp, BuiltinRenderTextureType.CameraTarget, pplipcehgnm);
		}
		else if (settings.frameBlending > 206f)
		{
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, BuiltinRenderTextureType.PrepassLight);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, hjhqqcbobpp, mat, 1);
			this.FCPNFDQGCOE().FHPFDIQFGBK(KLIOPLGOLQC, settings.frameBlending, hjhqqcbobpp, BuiltinRenderTextureType.CurrentActive, pplipcehgnm);
			this.DPPJEGFJOFH.GJKLOQPDMOG(KLIOPLGOLQC, hjhqqcbobpp, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), pplipcehgnm);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
	}

	// Token: 0x06006328 RID: 25384 RVA: 0x00026B0F File Offset: 0x00024D0F
	public void IIKNHGOMQEG()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06006329 RID: 25385 RVA: 0x00026B2F File Offset: 0x00024D2F
	public JKKJMOGLOOL.PPNOJFGEGEL DPPJEGFJOFH
	{
		get
		{
			if (this.NJMNPIEGBDP == null)
			{
				this.NJMNPIEGBDP = new JKKJMOGLOOL.PPNOJFGEGEL();
			}
			return this.NJMNPIEGBDP;
		}
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x00026B2F File Offset: 0x00024D2F
	public JKKJMOGLOOL.PPNOJFGEGEL FCPNFDQGCOE()
	{
		if (this.NJMNPIEGBDP == null)
		{
			this.NJMNPIEGBDP = new JKKJMOGLOOL.PPNOJFGEGEL();
		}
		return this.NJMNPIEGBDP;
	}

	// Token: 0x0600632B RID: 25387 RVA: 0x00026C44 File Offset: 0x00024E44
	public CameraEvent KGOGPGQIGJC()
	{
		return CameraEvent.AfterDepthTexture;
	}

	// Token: 0x040014FB RID: 5371
	private JKKJMOGLOOL.HQFEEBJGHHK QPJFDHCCDFL;

	// Token: 0x040014FC RID: 5372
	private JKKJMOGLOOL.PPNOJFGEGEL NJMNPIEGBDP;

	// Token: 0x040014FD RID: 5373
	private bool MGDQKEIKDPO = true;

	// Token: 0x020002C8 RID: 712
	private static class CFGJBNPCEHJ
	{
		// Token: 0x040014FE RID: 5374
		internal static readonly int PKKMPHNBIBN = Shader.PropertyToID("_VelocityScale");

		// Token: 0x040014FF RID: 5375
		internal static readonly int NFPGKNFFMKM = Shader.PropertyToID("_MaxBlurRadius");

		// Token: 0x04001500 RID: 5376
		internal static readonly int CCQDMOFDOLO = Shader.PropertyToID("_RcpMaxBlurRadius");

		// Token: 0x04001501 RID: 5377
		internal static readonly int BFFDNMEIHOB = Shader.PropertyToID("_VelocityTex");

		// Token: 0x04001502 RID: 5378
		internal static readonly int OKKONPEBLHN = Shader.PropertyToID("_MainTex");

		// Token: 0x04001503 RID: 5379
		internal static readonly int BNMMGMKJFGF = Shader.PropertyToID("_Tile2RT");

		// Token: 0x04001504 RID: 5380
		internal static readonly int JIQKOIHHGFB = Shader.PropertyToID("_Tile4RT");

		// Token: 0x04001505 RID: 5381
		internal static readonly int BCFQLBFPOFJ = Shader.PropertyToID("_Tile8RT");

		// Token: 0x04001506 RID: 5382
		internal static readonly int KEQNQOFKBHN = Shader.PropertyToID("_TileMaxOffs");

		// Token: 0x04001507 RID: 5383
		internal static readonly int OIONPNNQCHF = Shader.PropertyToID("_TileMaxLoop");

		// Token: 0x04001508 RID: 5384
		internal static readonly int ICKCFJGNNIO = Shader.PropertyToID("_TileVRT");

		// Token: 0x04001509 RID: 5385
		internal static readonly int FQJJFPECQPC = Shader.PropertyToID("_NeighborMaxTex");

		// Token: 0x0400150A RID: 5386
		internal static readonly int LFFEOMGLOEM = Shader.PropertyToID("_LoopCount");

		// Token: 0x0400150B RID: 5387
		internal static readonly int HJHQQCBOBPP = Shader.PropertyToID("_TempRT");

		// Token: 0x0400150C RID: 5388
		internal static readonly int GFHKMCDFBMD = Shader.PropertyToID("_History1LumaTex");

		// Token: 0x0400150D RID: 5389
		internal static readonly int DOHINIQEOBH = Shader.PropertyToID("_History2LumaTex");

		// Token: 0x0400150E RID: 5390
		internal static readonly int KHKOILICMON = Shader.PropertyToID("_History3LumaTex");

		// Token: 0x0400150F RID: 5391
		internal static readonly int KNQGJEJFJFH = Shader.PropertyToID("_History4LumaTex");

		// Token: 0x04001510 RID: 5392
		internal static readonly int BLKGQFJMKOI = Shader.PropertyToID("_History1ChromaTex");

		// Token: 0x04001511 RID: 5393
		internal static readonly int GKCJKDMGPOB = Shader.PropertyToID("_History2ChromaTex");

		// Token: 0x04001512 RID: 5394
		internal static readonly int MEMLLHEBDCF = Shader.PropertyToID("_History3ChromaTex");

		// Token: 0x04001513 RID: 5395
		internal static readonly int FEMHCGEHFOB = Shader.PropertyToID("_History4ChromaTex");

		// Token: 0x04001514 RID: 5396
		internal static readonly int PHHFMQMFHGC = Shader.PropertyToID("_History1Weight");

		// Token: 0x04001515 RID: 5397
		internal static readonly int FKMIGDQNBKN = Shader.PropertyToID("_History2Weight");

		// Token: 0x04001516 RID: 5398
		internal static readonly int LBOOPFNCGEJ = Shader.PropertyToID("_History3Weight");

		// Token: 0x04001517 RID: 5399
		internal static readonly int HLBPKCOQIEN = Shader.PropertyToID("_History4Weight");
	}

	// Token: 0x020002C9 RID: 713
	private enum EDGQOCGDDDG
	{
		// Token: 0x04001519 RID: 5401
		VelocitySetup,
		// Token: 0x0400151A RID: 5402
		TileMax1,
		// Token: 0x0400151B RID: 5403
		TileMax2,
		// Token: 0x0400151C RID: 5404
		TileMaxV,
		// Token: 0x0400151D RID: 5405
		NeighborMax,
		// Token: 0x0400151E RID: 5406
		Reconstruction,
		// Token: 0x0400151F RID: 5407
		FrameCompression,
		// Token: 0x04001520 RID: 5408
		FrameBlendingChroma,
		// Token: 0x04001521 RID: 5409
		FrameBlendingRaw
	}

	// Token: 0x020002CA RID: 714
	public class HQFEEBJGHHK
	{
		// Token: 0x0600632D RID: 25389 RVA: 0x00326FF4 File Offset: 0x003251F4
		public void DHJMPDPGPEO(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(45f * (float)BEHMQBIFCOJ.ONCCDMLHNQL() / 486f);
			int num2 = ((num - 1) / 5 + 0) * 8;
			float value = EFOQFENPFHO.shutterAngle / 1458f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1554f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CQNLNDBFFFP(), BEHMQBIFCOJ.ONCCDMLHNQL(), 1, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 2, BEHMQBIFCOJ.KPFJEIKPCBG() / 6, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CHODJCGKMOK() / 6, BEHMQBIFCOJ.ONCCDMLHNQL() / 1, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CQNLNDBFFFP() / 5, BEHMQBIFCOJ.JKGBHEHKBPC() / 5, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 6);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 823f - 225f) * 637f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1197f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.KJGMGPCEJJD / num2, BEHMQBIFCOJ.JHHQQQGMQBM() / num2, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 6);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / num2;
			int height = BEHMQBIFCOJ.DFKQMMIQDOO / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 5, 0, -97));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x00026C48 File Offset: 0x00024E48
		private void QHMQGNOQFHN()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool EOPNOBFFBJP()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x00026C48 File Offset: 0x00024E48
		private void JJQLBJPQJNH()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x00026C48 File Offset: 0x00024E48
		private void HGOBMEFMHJF()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x003272D8 File Offset: 0x003254D8
		public void QFDPJGLFPBN(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(5f * (float)BEHMQBIFCOJ.DFKQMMIQDOO / 100f);
			int num2 = ((num - 1) / 8 + 1) * 8;
			float value = EFOQFENPFHO.shutterAngle / 360f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 0);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.KJGMGPCEJJD / 2, BEHMQBIFCOJ.DFKQMMIQDOO / 2, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 1);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.KJGMGPCEJJD / 4, BEHMQBIFCOJ.DFKQMMIQDOO / 4, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.KJGMGPCEJJD / 8, BEHMQBIFCOJ.DFKQMMIQDOO / 8, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 8f - 1f) * -0.5f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 8f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.KJGMGPCEJJD / num2, BEHMQBIFCOJ.DFKQMMIQDOO / num2, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / num2;
			int height = BEHMQBIFCOJ.DFKQMMIQDOO / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 2, 1, 64));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool HEBQCMBILDD()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x003275BC File Offset: 0x003257BC
		public void IBDJNJJGQHP(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1885f * (float)BEHMQBIFCOJ.JHHQQQGMQBM() / 1356f);
			int num2 = ((num - 1) / 6 + 1) * 6;
			float value = EFOQFENPFHO.shutterAngle / 639f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1207f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.ONCCDMLHNQL(), 1, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.KJGMGPCEJJD / 1, BEHMQBIFCOJ.DFKQMMIQDOO / 4, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 6, BEHMQBIFCOJ.DFKQMMIQDOO / 8, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CHODJCGKMOK() / 7, BEHMQBIFCOJ.JKGBHEHKBPC() / 3, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 1535f - 965f) * 1072f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1208f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.KJGMGPCEJJD / num2, BEHMQBIFCOJ.JHHQQQGMQBM() / num2, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / num2;
			int height = BEHMQBIFCOJ.ONCCDMLHNQL() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 6, 0, 73));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x003278A0 File Offset: 0x00325AA0
		public void HEMDKLOGOEP(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1472f * (float)BEHMQBIFCOJ.JHHQQQGMQBM() / 682f);
			int num2 = ((num - 1) / 1 + 1) * 3;
			float value = EFOQFENPFHO.shutterAngle / 881f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1057f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CHODJCGKMOK(), BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 0);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.KJGMGPCEJJD / 8, BEHMQBIFCOJ.ONCCDMLHNQL() / 0, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 1);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CHODJCGKMOK() / 2, BEHMQBIFCOJ.JHHQQQGMQBM() / 0, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.KJGMGPCEJJD / 7, BEHMQBIFCOJ.JKGBHEHKBPC() / 6, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 665f - 1674f) * 547f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 624f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CHODJCGKMOK() / num2, BEHMQBIFCOJ.JKGBHEHKBPC() / num2, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CHODJCGKMOK() / num2;
			int height = BEHMQBIFCOJ.JHHQQQGMQBM() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 1, 1, 68));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool OCEMPJEJEIH()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x00026C65 File Offset: 0x00024E65
		public HQFEEBJGHHK()
		{
			this.QHMQGNOQFHN();
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00327B84 File Offset: 0x00325D84
		public void JJILFIMKINK(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(464f * (float)BEHMQBIFCOJ.KPFJEIKPCBG() / 1349f);
			int num2 = ((num - 1) / 4 + 0) * 5;
			float value = EFOQFENPFHO.shutterAngle / 351f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1330f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CQNLNDBFFFP(), BEHMQBIFCOJ.ONCCDMLHNQL(), 0, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 0, BEHMQBIFCOJ.KPFJEIKPCBG() / 8, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.KJGMGPCEJJD / 5, BEHMQBIFCOJ.JHHQQQGMQBM() / 0, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.KJGMGPCEJJD / 0, BEHMQBIFCOJ.ONCCDMLHNQL() / 0, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 656f - 1054f) * 1395f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1361f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CQNLNDBFFFP() / num2, BEHMQBIFCOJ.KPFJEIKPCBG() / num2, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CHODJCGKMOK() / num2;
			int height = BEHMQBIFCOJ.JHHQQQGMQBM() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 8, 1, -43));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x00327E68 File Offset: 0x00326068
		public void BPCPHHNOOMQ(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1040f * (float)BEHMQBIFCOJ.KPFJEIKPCBG() / 1817f);
			int num2 = ((num - 0) / 2 + 0) * 4;
			float value = EFOQFENPFHO.shutterAngle / 1331f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1361f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CHODJCGKMOK(), BEHMQBIFCOJ.KPFJEIKPCBG(), 0, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 0);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 5, BEHMQBIFCOJ.JHHQQQGMQBM() / 3, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 0, BEHMQBIFCOJ.JKGBHEHKBPC() / 7, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.KJGMGPCEJJD / 6, BEHMQBIFCOJ.ONCCDMLHNQL() / 0, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 572f - 1647f) * 414f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 4f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CQNLNDBFFFP() / num2, BEHMQBIFCOJ.JKGBHEHKBPC() / num2, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / num2;
			int height = BEHMQBIFCOJ.JKGBHEHKBPC() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 5, 1, -69));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool FKJMEEJEGMD()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool FONNFPGLMNL()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00026C48 File Offset: 0x00024E48
		private void FKJMJQQKNPI()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x0032814C File Offset: 0x0032634C
		public void IHHEKFINOKE(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(561f * (float)BEHMQBIFCOJ.JHHQQQGMQBM() / 1658f);
			int num2 = ((num - 0) / 3 + 0) * 3;
			float value = EFOQFENPFHO.shutterAngle / 1968f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 699f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.KPFJEIKPCBG(), 1, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 4, BEHMQBIFCOJ.KPFJEIKPCBG() / 8, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 1);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 5, BEHMQBIFCOJ.DFKQMMIQDOO / 2, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CQNLNDBFFFP() / 3, BEHMQBIFCOJ.KPFJEIKPCBG() / 0, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 676f - 1140f) * 1323f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 138f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.KJGMGPCEJJD / num2, BEHMQBIFCOJ.DFKQMMIQDOO / num2, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / num2;
			int height = BEHMQBIFCOJ.DFKQMMIQDOO / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 1, 0, -80));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00026C82 File Offset: 0x00024E82
		private void CNPDDMHDNHK()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00328430 File Offset: 0x00326630
		public void MCLIFOGCDCE(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(434f * (float)BEHMQBIFCOJ.JHHQQQGMQBM() / 941f);
			int num2 = ((num - 1) / 8 + 0) * 8;
			float value = EFOQFENPFHO.shutterAngle / 410f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 684f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CHODJCGKMOK(), BEHMQBIFCOJ.JHHQQQGMQBM(), 0, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 5, BEHMQBIFCOJ.JKGBHEHKBPC() / 2, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CHODJCGKMOK() / 5, BEHMQBIFCOJ.JKGBHEHKBPC() / 1, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CQNLNDBFFFP() / 2, BEHMQBIFCOJ.DFKQMMIQDOO / 4, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 212f - 450f) * 1200f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 157f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CHODJCGKMOK() / num2, BEHMQBIFCOJ.KPFJEIKPCBG() / num2, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CHODJCGKMOK() / num2;
			int height = BEHMQBIFCOJ.JKGBHEHKBPC() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 8, 0, -89));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00026C82 File Offset: 0x00024E82
		private void DIIICGGIIBG()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00328714 File Offset: 0x00326914
		public void IPPPNQEFFLN(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1377f * (float)BEHMQBIFCOJ.KPFJEIKPCBG() / 1238f);
			int num2 = ((num - 1) / 6 + 0) * 7;
			float value = EFOQFENPFHO.shutterAngle / 1269f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1796f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.JKGBHEHKBPC(), 0, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.KJGMGPCEJJD / 6, BEHMQBIFCOJ.JHHQQQGMQBM() / 4, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.KJGMGPCEJJD / 5, BEHMQBIFCOJ.DFKQMMIQDOO / 1, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CHODJCGKMOK() / 0, BEHMQBIFCOJ.JHHQQQGMQBM() / 8, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 727f - 1562f) * 98f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1677f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CQNLNDBFFFP() / num2, BEHMQBIFCOJ.KPFJEIKPCBG() / num2, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CQNLNDBFFFP() / num2;
			int height = BEHMQBIFCOJ.JKGBHEHKBPC() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 7, 0, 101));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x003289F8 File Offset: 0x00326BF8
		public void QHEBQKOPGMF(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1120f * (float)BEHMQBIFCOJ.ONCCDMLHNQL() / 448f);
			float value = EFOQFENPFHO.shutterAngle / 1035f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1555f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.CQNLNDBFFFP(), BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 4, BEHMQBIFCOJ.ONCCDMLHNQL() / 0, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 3, BEHMQBIFCOJ.JHHQQQGMQBM() / 5, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CHODJCGKMOK() / 4, BEHMQBIFCOJ.DFKQMMIQDOO / 5, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * -895f * 1785f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, 0f);
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CHODJCGKMOK() / 0, BEHMQBIFCOJ.JHHQQQGMQBM() / 0, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.KJGMGPCEJJD / 0;
			int height = BEHMQBIFCOJ.ONCCDMLHNQL() / 0;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 7, 0, 10));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00026C48 File Offset: 0x00024E48
		private void ELHPDFBENDL()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool PQEJHFENJGE()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x00328CC4 File Offset: 0x00326EC4
		public void DQIKNIDCLBJ(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(413f * (float)BEHMQBIFCOJ.KPFJEIKPCBG() / 214f);
			int num2 = ((num - 1) / 7 + 1) * 5;
			float value = EFOQFENPFHO.shutterAngle / 1135f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1439f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Point, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CHODJCGKMOK() / 5, BEHMQBIFCOJ.KPFJEIKPCBG() / 1, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 0);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 2, BEHMQBIFCOJ.KPFJEIKPCBG() / 4, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 6);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CHODJCGKMOK() / 4, BEHMQBIFCOJ.ONCCDMLHNQL() / 2, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 915f - 1667f) * 1332f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1231f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CHODJCGKMOK() / num2, BEHMQBIFCOJ.DFKQMMIQDOO / num2, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CQNLNDBFFFP() / num2;
			int height = BEHMQBIFCOJ.ONCCDMLHNQL() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 3, 1, -29));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x00328FA8 File Offset: 0x003271A8
		public void LBHQBENHOBO(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1147f * (float)BEHMQBIFCOJ.JHHQQQGMQBM() / 1861f);
			int num2 = ((num - 1) / 3 + 0) * 5;
			float value = EFOQFENPFHO.shutterAngle / 335f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 246f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CQNLNDBFFFP() / 0, BEHMQBIFCOJ.ONCCDMLHNQL() / 2, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 1);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.KJGMGPCEJJD / 8, BEHMQBIFCOJ.KPFJEIKPCBG() / 0, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 4);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.CQNLNDBFFFP() / 8, BEHMQBIFCOJ.KPFJEIKPCBG() / 1, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 171f - 1335f) * 1008f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 354f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CQNLNDBFFFP() / num2, BEHMQBIFCOJ.JHHQQQGMQBM() / num2, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 7);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CHODJCGKMOK() / num2;
			int height = BEHMQBIFCOJ.ONCCDMLHNQL() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 8, 1, 49));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 5);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x00026C5E File Offset: 0x00024E5E
		public bool EQEDBJHNNPJ()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00026C82 File Offset: 0x00024E82
		private void MQQGIBBNQDF()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00026C48 File Offset: 0x00024E48
		private void QBDOOLLNOCK()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.KOLGIMOJHBC))
			{
				this.KOLGIMOJHBC = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x0032928C File Offset: 0x0032748C
		public void KJDLKGQPCKL(NNLOOFHPMNG BEHMQBIFCOJ, CommandBuffer KLIOPLGOLQC, ref MotionBlurModel.Settings EFOQFENPFHO, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			int num = (int)(1184f * (float)BEHMQBIFCOJ.JKGBHEHKBPC() / 1425f);
			int num2 = ((num - 1) / 0 + 0) * 5;
			float value = EFOQFENPFHO.shutterAngle / 1962f;
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PKKMPHNBIBN, value);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.NFPGKNFFMKM, (float)num);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.CCQDMOFDOLO, 1513f / (float)num);
			int bffdnmeihob = JKKJMOGLOOL.CFGJBNPCEHJ.BFFDNMEIHOB;
			KLIOPLGOLQC.GetTemporaryRT(bffdnmeihob, BEHMQBIFCOJ.KJGMGPCEJJD, BEHMQBIFCOJ.KPFJEIKPCBG(), 1, FilterMode.Bilinear, this.KOLGIMOJHBC, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.Blit(null, bffdnmeihob, PPLIPCEHGNM, 1);
			int bnmmgmkjfgf = JKKJMOGLOOL.CFGJBNPCEHJ.BNMMGMKJFGF;
			KLIOPLGOLQC.GetTemporaryRT(bnmmgmkjfgf, BEHMQBIFCOJ.CHODJCGKMOK() / 3, BEHMQBIFCOJ.ONCCDMLHNQL() / 3, 1, FilterMode.Bilinear, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bffdnmeihob);
			KLIOPLGOLQC.Blit(bffdnmeihob, bnmmgmkjfgf, PPLIPCEHGNM, 1);
			int jiqkoihhgfb = JKKJMOGLOOL.CFGJBNPCEHJ.JIQKOIHHGFB;
			KLIOPLGOLQC.GetTemporaryRT(jiqkoihhgfb, BEHMQBIFCOJ.CQNLNDBFFFP() / 6, BEHMQBIFCOJ.DFKQMMIQDOO / 6, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bnmmgmkjfgf);
			KLIOPLGOLQC.Blit(bnmmgmkjfgf, jiqkoihhgfb, PPLIPCEHGNM, 6);
			KLIOPLGOLQC.ReleaseTemporaryRT(bnmmgmkjfgf);
			int bcfqlbfpofj = JKKJMOGLOOL.CFGJBNPCEHJ.BCFQLBFPOFJ;
			KLIOPLGOLQC.GetTemporaryRT(bcfqlbfpofj, BEHMQBIFCOJ.KJGMGPCEJJD / 0, BEHMQBIFCOJ.ONCCDMLHNQL() / 6, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, jiqkoihhgfb);
			KLIOPLGOLQC.Blit(jiqkoihhgfb, bcfqlbfpofj, PPLIPCEHGNM, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(jiqkoihhgfb);
			Vector2 v = Vector2.one * ((float)num2 / 956f - 592f) * 1248f;
			KLIOPLGOLQC.SetGlobalVector(JKKJMOGLOOL.CFGJBNPCEHJ.KEQNQOFKBHN, v);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.OIONPNNQCHF, (float)((int)((float)num2 / 1995f)));
			int ickcfjgnnio = JKKJMOGLOOL.CFGJBNPCEHJ.ICKCFJGNNIO;
			KLIOPLGOLQC.GetTemporaryRT(ickcfjgnnio, BEHMQBIFCOJ.CQNLNDBFFFP() / num2, BEHMQBIFCOJ.JKGBHEHKBPC() / num2, 1, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Linear);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, bcfqlbfpofj);
			KLIOPLGOLQC.Blit(bcfqlbfpofj, ickcfjgnnio, PPLIPCEHGNM, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(bcfqlbfpofj);
			int fqjjfpecqpc = JKKJMOGLOOL.CFGJBNPCEHJ.FQJJFPECQPC;
			int width = BEHMQBIFCOJ.CHODJCGKMOK() / num2;
			int height = BEHMQBIFCOJ.JHHQQQGMQBM() / num2;
			KLIOPLGOLQC.GetTemporaryRT(fqjjfpecqpc, width, height, 0, FilterMode.Point, this.KGHKPJDOHOL, RenderTextureReadWrite.Default);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, ickcfjgnnio);
			KLIOPLGOLQC.Blit(ickcfjgnnio, fqjjfpecqpc, PPLIPCEHGNM, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(ickcfjgnnio);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LFFEOMGLOEM, (float)Mathf.Clamp(EFOQFENPFHO.sampleCount / 8, 1, -13));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(bffdnmeihob);
			KLIOPLGOLQC.ReleaseTemporaryRT(fqjjfpecqpc);
		}

		// Token: 0x04001522 RID: 5410
		private RenderTextureFormat KGHKPJDOHOL = RenderTextureFormat.RGHalf;

		// Token: 0x04001523 RID: 5411
		private RenderTextureFormat KOLGIMOJHBC = RenderTextureFormat.ARGB2101010;
	}

	// Token: 0x020002CB RID: 715
	public class PPNOJFGEGEL
	{
		// Token: 0x0600634B RID: 25419 RVA: 0x00329570 File Offset: 0x00327770
		private static RenderTextureFormat EFLHDHIKNKB()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[7];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			foreach (RenderTextureFormat renderTextureFormat in array2)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x003295B0 File Offset: 0x003277B0
		private static RenderTextureFormat PPLCLHIBGOG()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[7];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			RenderTextureFormat[] array3 = array2;
			for (int i = 1; i < array3.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array3[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB1555;
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x003295F0 File Offset: 0x003277F0
		public void PJFMGPFJNMO(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.GDCEGQKBPNP(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.GDCEGQKBPNP(-86);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.GDCEGQKBPNP(-76);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.QQHEIKGFLEK(-82);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.MFMQIGFPEFQ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.MFMQIGFPEFQ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.DFEQMMNGNMJ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 2 : 3);
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00329754 File Offset: 0x00327954
		public void QGKKOOHKMPO(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.QQHEIKGFLEK(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.CGHLDGHKKNF(30);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.ECKOBIKIJBN(85);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.GDCEGQKBPNP(-28);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.QNBOEIGEDPN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.DFEQMMNGNMJ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 7 : 0);
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x003298B8 File Offset: 0x00327AB8
		public void LKHHEMNNHED()
		{
			foreach (JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm in this.BEGPBBDMHEP)
			{
				cieilipqohm.DGMKGLLBMFG();
			}
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x003298F0 File Offset: 0x00327AF0
		private static RenderTextureFormat EHCJMINDLQK()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[7];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			RenderTextureFormat[] array3 = array2;
			for (int i = 1; i < array3.Length; i++)
			{
				RenderTextureFormat renderTextureFormat = array3[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Depth;
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00329930 File Offset: 0x00327B30
		public void ECLIHQEDJGM(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.MKJINICJFHI(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.ECKOBIKIJBN(91);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.QQHEIKGFLEK(26);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.PFBLCMEGPLB(-103);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.DFEQMMNGNMJ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.QNBOEIGEDPN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.MFMQIGFPEFQ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 8 : 5);
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x00329A94 File Offset: 0x00327C94
		public void QMFMBQKNQGI(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].OBDMLDIINNE(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].FEBJJLLEOJQ(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00329B04 File Offset: 0x00327D04
		public void MDBLBGOPMLC()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 0; i < begpbbdmhep.Length; i += 0)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.EDLJFKJMLCN();
			}
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00329B3C File Offset: 0x00327D3C
		public void LHPBDNINODD()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 1; i < begpbbdmhep.Length; i++)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.EDLJFKJMLCN();
			}
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x00329B74 File Offset: 0x00327D74
		public void FHPFDIQFGBK(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.MKJINICJFHI(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.MKJINICJFHI(-2);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.MKJINICJFHI(-3);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.MKJINICJFHI(-4);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 8 : 7);
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x00329CD8 File Offset: 0x00327ED8
		public void NIIJJEPPOID(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.PFBLCMEGPLB(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.ECKOBIKIJBN(53);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.ECKOBIKIJBN(-28);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.CGHLDGHKKNF(-67);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.QNBOEIGEDPN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.QNBOEIGEDPN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 5 : 1);
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x00329E3C File Offset: 0x0032803C
		public void GJKLOQPDMOG(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].NJMKFFKHMHF(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].FEBJJLLEOJQ(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x00026C98 File Offset: 0x00024E98
		private static bool QFFDKQNDEBF()
		{
			return SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x00026CAE File Offset: 0x00024EAE
		private static bool OBGOIOGGJNN()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-79)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x00026CC4 File Offset: 0x00024EC4
		private static bool CNOEKDGCGPL()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-6)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x00329EAC File Offset: 0x003280AC
		public void NJEHMLKGJHG()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 0; i < begpbbdmhep.Length; i += 0)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.DGMKGLLBMFG();
			}
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x00329EE4 File Offset: 0x003280E4
		public void LKJCCHGDKFG()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 1; i < begpbbdmhep.Length; i += 0)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.ELDBNQHPLPM();
			}
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00329F1C File Offset: 0x0032811C
		public void QFPMINOELOJ(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].HJNOEOKPKEC(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].ICNBPCENJEK(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00329F8C File Offset: 0x0032818C
		public void PJQOLKDCNOD()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 1; i < begpbbdmhep.Length; i++)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.ELDBNQHPLPM();
			}
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x00329FC4 File Offset: 0x003281C4
		private static RenderTextureFormat NFGKJPKLOLN()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			foreach (RenderTextureFormat renderTextureFormat in array2)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB1555;
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x00329A94 File Offset: 0x00327C94
		public void PMKQOGEBNDG(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].OBDMLDIINNE(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].FEBJJLLEOJQ(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM MKJINICJFHI(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x0032A03C File Offset: 0x0032823C
		public void QHPDCOJMCKN(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.QQHEIKGFLEK(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.MKJINICJFHI(-25);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.QQHEIKGFLEK(-83);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.CGHLDGHKKNF(-76);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.DFEQMMNGNMJ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.DFEQMMNGNMJ(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 4 : 4);
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00026CDA File Offset: 0x00024EDA
		private static bool BBQOCFPDDJJ()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-47)) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x00026CF0 File Offset: 0x00024EF0
		private static bool DGKOFJDOCMJ()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-93)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0032A1A0 File Offset: 0x003283A0
		public void BEENOEDBNGK()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 1; i < begpbbdmhep.Length; i++)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.NOPBKBMNIBN();
			}
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x003298B8 File Offset: 0x00327AB8
		public void LPQIKIFQJMF()
		{
			foreach (JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm in this.BEGPBBDMHEP)
			{
				cieilipqohm.DGMKGLLBMFG();
			}
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM QQHEIKGFLEK(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM PFBLCMEGPLB(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM GDCEGQKBPNP(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x0032A1D8 File Offset: 0x003283D8
		private static RenderTextureFormat KMIOKQFFQDG()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[6];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			foreach (RenderTextureFormat renderTextureFormat in array2)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.RGB565;
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM CGHLDGHKKNF(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x0032A218 File Offset: 0x00328418
		public void MKIJCDEMGJQ(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].HJNOEOKPKEC(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].FEBJJLLEOJQ(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00329F8C File Offset: 0x0032818C
		public void BENGDKLKFGG()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 1; i < begpbbdmhep.Length; i++)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.ELDBNQHPLPM();
			}
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x00329B04 File Offset: 0x00327D04
		public void MBPOGOHPCHP()
		{
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] begpbbdmhep = this.BEGPBBDMHEP;
			for (int i = 0; i < begpbbdmhep.Length; i += 0)
			{
				JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = begpbbdmhep[i];
				cieilipqohm.EDLJFKJMLCN();
			}
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0032A288 File Offset: 0x00328488
		public void GKJLKFKHFBD(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].OBDMLDIINNE(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].JLGKOFDCOND(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x0032A004 File Offset: 0x00328204
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM ECKOBIKIJBN(int LCMMCNFNHMF)
		{
			int num = (Time.frameCount + this.BEGPBBDMHEP.Length + LCMMCNFNHMF) % this.BEGPBBDMHEP.Length;
			return this.BEGPBBDMHEP[num];
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00026D06 File Offset: 0x00024F06
		public PPNOJFGEGEL()
		{
			this.EHJHKFILKMD = JKKJMOGLOOL.PPNOJFGEGEL.QFFDKQNDEBF();
			this.IBBFGPJENNK = JKKJMOGLOOL.PPNOJFGEGEL.IHLGHFEFOPG();
			this.BEGPBBDMHEP = new JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[4];
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x0032A2F8 File Offset: 0x003284F8
		public void INIDPNCJQGD()
		{
			foreach (JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm in this.BEGPBBDMHEP)
			{
				cieilipqohm.EDLJFKJMLCN();
			}
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x0032A330 File Offset: 0x00328530
		public void BDHOOFQDQFN(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].DEJGILPDHHD(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].JLGKOFDCOND(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x0032A3A0 File Offset: 0x003285A0
		private static RenderTextureFormat QNOOHCNKJEJ()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			RenderTextureFormat[] array3 = array2;
			for (int i = 1; i < array3.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array3[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00329E3C File Offset: 0x0032803C
		public void BIBBOHNGJMH(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].NJMKFFKHMHF(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].FEBJJLLEOJQ(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x0032A3E0 File Offset: 0x003285E0
		private static RenderTextureFormat IHLGHFEFOPG()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			foreach (RenderTextureFormat renderTextureFormat in array2)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x0032A420 File Offset: 0x00328620
		public void JHDJPBNELIO(CommandBuffer KLIOPLGOLQC, float IEMGQKFCEHM, RenderTargetIdentifier PBHPQFLMQDB, RenderTargetIdentifier OBEPQQEKFLC, Material PPLIPCEHGNM)
		{
			float time = Time.time;
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm = this.ECKOBIKIJBN(-1);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm2 = this.ECKOBIKIJBN(117);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm3 = this.PFBLCMEGPLB(49);
			JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM cieilipqohm4 = this.GDCEGQKBPNP(-26);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GFHKMCDFBMD, cieilipqohm.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.DOHINIQEOBH, cieilipqohm2.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KHKOILICMON, cieilipqohm3.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.KNQGJEJFJFH, cieilipqohm4.CJKKLECCNEE);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.BLKGQFJMKOI, cieilipqohm.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.GKCJKDMGPOB, cieilipqohm2.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.MEMLLHEBDCF, cieilipqohm3.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.FEMHCGEHFOB, cieilipqohm4.HIJFPCLQHII);
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.PHHFMQMFHGC, cieilipqohm.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.FKMIGDQNBKN, cieilipqohm2.QNBOEIGEDPN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.LBOOPFNCGEJ, cieilipqohm3.QJLICKDHHCI(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalFloat(JKKJMOGLOOL.CFGJBNPCEHJ.HLBPKCOQIEN, cieilipqohm4.NPMMMFNPHHN(IEMGQKFCEHM, time));
			KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
			KLIOPLGOLQC.Blit(PBHPQFLMQDB, OBEPQQEKFLC, PPLIPCEHGNM, (!this.EHJHKFILKMD) ? 1 : 8);
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x0032A584 File Offset: 0x00328784
		public void IMIMCPCBHHN(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.MHEJBDIFBHN)
			{
				return;
			}
			int num = frameCount % this.BEGPBBDMHEP.Length;
			if (this.EHJHKFILKMD)
			{
				this.BEGPBBDMHEP[num].NFFJDIQEHNM(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, PPLIPCEHGNM);
			}
			else
			{
				this.BEGPBBDMHEP[num].JLGKOFDCOND(KLIOPLGOLQC, PBHPQFLMQDB, KJGMGPCEJJD, DFKQMMIQDOO, this.IBBFGPJENNK);
			}
			this.MHEJBDIFBHN = frameCount;
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00026D30 File Offset: 0x00024F30
		private static bool KIEIIFFBCHC()
		{
			return SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x04001524 RID: 5412
		private bool EHJHKFILKMD;

		// Token: 0x04001525 RID: 5413
		private RenderTextureFormat IBBFGPJENNK;

		// Token: 0x04001526 RID: 5414
		private JKKJMOGLOOL.PPNOJFGEGEL.CIEILIPQOHM[] BEGPBBDMHEP;

		// Token: 0x04001527 RID: 5415
		private int MHEJBDIFBHN;

		// Token: 0x020002CC RID: 716
		private struct CIEILIPQOHM
		{
			// Token: 0x0600637A RID: 25466 RVA: 0x0032A5F4 File Offset: 0x003287F4
			public float DFEQMMNGNMJ(float IEMGQKFCEHM, float QCIPOBLONDO)
			{
				if (Mathf.Approximately(this.MNPBKGHNLKL, 1385f))
				{
					return 678f;
				}
				float num = Mathf.Lerp(1298f, 1906f, IEMGQKFCEHM);
				return Mathf.Exp((this.MNPBKGHNLKL - QCIPOBLONDO) * num);
			}

			// Token: 0x0600637B RID: 25467 RVA: 0x0032A63C File Offset: 0x0032883C
			public void EDLJFKJMLCN()
			{
				if (this.CJKKLECCNEE != null)
				{
					RenderTexture.ReleaseTemporary(this.CJKKLECCNEE);
				}
				if (this.HIJFPCLQHII != null)
				{
					RenderTexture.ReleaseTemporary(this.HIJFPCLQHII);
				}
				this.CJKKLECCNEE = null;
				this.HIJFPCLQHII = null;
			}

			// Token: 0x0600637C RID: 25468 RVA: 0x0032A63C File Offset: 0x0032883C
			public void DGMKGLLBMFG()
			{
				if (this.CJKKLECCNEE != null)
				{
					RenderTexture.ReleaseTemporary(this.CJKKLECCNEE);
				}
				if (this.HIJFPCLQHII != null)
				{
					RenderTexture.ReleaseTemporary(this.HIJFPCLQHII);
				}
				this.CJKKLECCNEE = null;
				this.HIJFPCLQHII = null;
			}

			// Token: 0x0600637D RID: 25469 RVA: 0x0032A68C File Offset: 0x0032888C
			public void DEJGILPDHHD(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
			{
				this.DGMKGLLBMFG();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, (RenderTextureFormat)76, RenderTextureReadWrite.Default);
				this.HIJFPCLQHII = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, (RenderTextureFormat)(-2), RenderTextureReadWrite.Linear);
				this.CJKKLECCNEE.filterMode = FilterMode.Bilinear;
				this.HIJFPCLQHII.filterMode = FilterMode.Bilinear;
				if (this.HGHGMDOGFNM == null)
				{
					this.HGHGMDOGFNM = new RenderTargetIdentifier[1];
				}
				this.HGHGMDOGFNM[1] = this.CJKKLECCNEE;
				this.HGHGMDOGFNM[1] = this.HIJFPCLQHII;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, this.CJKKLECCNEE);
				KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, PPLIPCEHGNM, 0, 4);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x0600637E RID: 25470 RVA: 0x0032A63C File Offset: 0x0032883C
			public void NOPBKBMNIBN()
			{
				if (this.CJKKLECCNEE != null)
				{
					RenderTexture.ReleaseTemporary(this.CJKKLECCNEE);
				}
				if (this.HIJFPCLQHII != null)
				{
					RenderTexture.ReleaseTemporary(this.HIJFPCLQHII);
				}
				this.CJKKLECCNEE = null;
				this.HIJFPCLQHII = null;
			}

			// Token: 0x0600637F RID: 25471 RVA: 0x0032A76C File Offset: 0x0032896C
			public void ICNBPCENJEK(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, RenderTextureFormat EIBOBKJIGQB)
			{
				this.ELDBNQHPLPM();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, EIBOBKJIGQB);
				this.CJKKLECCNEE.filterMode = FilterMode.Bilinear;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.Blit(PBHPQFLMQDB, this.CJKKLECCNEE);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006380 RID: 25472 RVA: 0x0032A7C8 File Offset: 0x003289C8
			public float QJLICKDHHCI(float IEMGQKFCEHM, float QCIPOBLONDO)
			{
				if (Mathf.Approximately(this.MNPBKGHNLKL, 0f))
				{
					return 0f;
				}
				float num = Mathf.Lerp(80f, 16f, IEMGQKFCEHM);
				return Mathf.Exp((this.MNPBKGHNLKL - QCIPOBLONDO) * num);
			}

			// Token: 0x06006381 RID: 25473 RVA: 0x0032A63C File Offset: 0x0032883C
			public void ELDBNQHPLPM()
			{
				if (this.CJKKLECCNEE != null)
				{
					RenderTexture.ReleaseTemporary(this.CJKKLECCNEE);
				}
				if (this.HIJFPCLQHII != null)
				{
					RenderTexture.ReleaseTemporary(this.HIJFPCLQHII);
				}
				this.CJKKLECCNEE = null;
				this.HIJFPCLQHII = null;
			}

			// Token: 0x06006382 RID: 25474 RVA: 0x0032A810 File Offset: 0x00328A10
			public void HJNOEOKPKEC(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
			{
				this.EDLJFKJMLCN();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, (RenderTextureFormat)(-53), RenderTextureReadWrite.Default);
				this.HIJFPCLQHII = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, (RenderTextureFormat)41, RenderTextureReadWrite.Default);
				this.CJKKLECCNEE.filterMode = FilterMode.Bilinear;
				this.HIJFPCLQHII.filterMode = FilterMode.Bilinear;
				if (this.HGHGMDOGFNM == null)
				{
					this.HGHGMDOGFNM = new RenderTargetIdentifier[2];
				}
				this.HGHGMDOGFNM[1] = this.CJKKLECCNEE;
				this.HGHGMDOGFNM[1] = this.HIJFPCLQHII;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, this.CJKKLECCNEE);
				KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, PPLIPCEHGNM, 0, 1);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006383 RID: 25475 RVA: 0x0032A8F0 File Offset: 0x00328AF0
			public float NPMMMFNPHHN(float IEMGQKFCEHM, float QCIPOBLONDO)
			{
				if (Mathf.Approximately(this.MNPBKGHNLKL, 1377f))
				{
					return 1579f;
				}
				float num = Mathf.Lerp(72f, 403f, IEMGQKFCEHM);
				return Mathf.Exp((this.MNPBKGHNLKL - QCIPOBLONDO) * num);
			}

			// Token: 0x06006384 RID: 25476 RVA: 0x0032A938 File Offset: 0x00328B38
			public void JLGKOFDCOND(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, RenderTextureFormat EIBOBKJIGQB)
			{
				this.DGMKGLLBMFG();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, EIBOBKJIGQB);
				this.CJKKLECCNEE.filterMode = FilterMode.Point;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.Blit(PBHPQFLMQDB, this.CJKKLECCNEE);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006385 RID: 25477 RVA: 0x0032A994 File Offset: 0x00328B94
			public void NJMKFFKHMHF(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
			{
				this.DGMKGLLBMFG();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, (RenderTextureFormat)(-57), RenderTextureReadWrite.Default);
				this.HIJFPCLQHII = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, (RenderTextureFormat)40, RenderTextureReadWrite.Linear);
				this.CJKKLECCNEE.filterMode = FilterMode.Point;
				this.HIJFPCLQHII.filterMode = FilterMode.Bilinear;
				if (this.HGHGMDOGFNM == null)
				{
					this.HGHGMDOGFNM = new RenderTargetIdentifier[5];
				}
				this.HGHGMDOGFNM[1] = this.CJKKLECCNEE;
				this.HGHGMDOGFNM[1] = this.HIJFPCLQHII;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, this.CJKKLECCNEE);
				KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, PPLIPCEHGNM, 1, 1);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006386 RID: 25478 RVA: 0x0032AA74 File Offset: 0x00328C74
			public void NFFJDIQEHNM(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
			{
				this.NOPBKBMNIBN();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, (RenderTextureFormat)80, RenderTextureReadWrite.Default);
				this.HIJFPCLQHII = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 1, RenderTextureFormat.BGR101010_XR, RenderTextureReadWrite.Linear);
				this.CJKKLECCNEE.filterMode = FilterMode.Point;
				this.HIJFPCLQHII.filterMode = FilterMode.Bilinear;
				if (this.HGHGMDOGFNM == null)
				{
					this.HGHGMDOGFNM = new RenderTargetIdentifier[1];
				}
				this.HGHGMDOGFNM[1] = this.CJKKLECCNEE;
				this.HGHGMDOGFNM[0] = this.HIJFPCLQHII;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, this.CJKKLECCNEE);
				KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, PPLIPCEHGNM, 1, 5);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006387 RID: 25479 RVA: 0x0032AB54 File Offset: 0x00328D54
			public void OBDMLDIINNE(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, Material PPLIPCEHGNM)
			{
				this.DGMKGLLBMFG();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, RenderTextureFormat.R8, RenderTextureReadWrite.Linear);
				this.HIJFPCLQHII = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, RenderTextureFormat.R8, RenderTextureReadWrite.Linear);
				this.CJKKLECCNEE.filterMode = FilterMode.Point;
				this.HIJFPCLQHII.filterMode = FilterMode.Point;
				if (this.HGHGMDOGFNM == null)
				{
					this.HGHGMDOGFNM = new RenderTargetIdentifier[2];
				}
				this.HGHGMDOGFNM[0] = this.CJKKLECCNEE;
				this.HGHGMDOGFNM[1] = this.HIJFPCLQHII;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, this.CJKKLECCNEE);
				KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, PPLIPCEHGNM, 0, 6);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x06006388 RID: 25480 RVA: 0x0032AC34 File Offset: 0x00328E34
			public float QNBOEIGEDPN(float IEMGQKFCEHM, float QCIPOBLONDO)
			{
				if (Mathf.Approximately(this.MNPBKGHNLKL, 1676f))
				{
					return 839f;
				}
				float num = Mathf.Lerp(1662f, 445f, IEMGQKFCEHM);
				return Mathf.Exp((this.MNPBKGHNLKL - QCIPOBLONDO) * num);
			}

			// Token: 0x06006389 RID: 25481 RVA: 0x0032AC7C File Offset: 0x00328E7C
			public void FEBJJLLEOJQ(CommandBuffer KLIOPLGOLQC, RenderTargetIdentifier PBHPQFLMQDB, int KJGMGPCEJJD, int DFKQMMIQDOO, RenderTextureFormat EIBOBKJIGQB)
			{
				this.DGMKGLLBMFG();
				this.CJKKLECCNEE = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, 0, EIBOBKJIGQB);
				this.CJKKLECCNEE.filterMode = FilterMode.Point;
				KLIOPLGOLQC.SetGlobalTexture(JKKJMOGLOOL.CFGJBNPCEHJ.OKKONPEBLHN, PBHPQFLMQDB);
				KLIOPLGOLQC.Blit(PBHPQFLMQDB, this.CJKKLECCNEE);
				this.MNPBKGHNLKL = Time.time;
			}

			// Token: 0x0600638A RID: 25482 RVA: 0x0032ACD8 File Offset: 0x00328ED8
			public float MFMQIGFPEFQ(float IEMGQKFCEHM, float QCIPOBLONDO)
			{
				if (Mathf.Approximately(this.MNPBKGHNLKL, 951f))
				{
					return 457f;
				}
				float num = Mathf.Lerp(370f, 1666f, IEMGQKFCEHM);
				return Mathf.Exp((this.MNPBKGHNLKL - QCIPOBLONDO) * num);
			}

			// Token: 0x04001528 RID: 5416
			public RenderTexture CJKKLECCNEE;

			// Token: 0x04001529 RID: 5417
			public RenderTexture HIJFPCLQHII;

			// Token: 0x0400152A RID: 5418
			private float MNPBKGHNLKL;

			// Token: 0x0400152B RID: 5419
			private RenderTargetIdentifier[] HGHGMDOGFNM;
		}
	}
}
