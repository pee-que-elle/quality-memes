using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002C5 RID: 709
public sealed class FFMEDEIIJOC : ONQQOCQBQIE<GrainModel>
{
	// Token: 0x060062B3 RID: 25267 RVA: 0x00323B24 File Offset: 0x00321D24
	public bool IKNNJPFFMHL()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QLIGQMEDNJC().intensity > 654f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x00323B74 File Offset: 0x00321D74
	public bool ENQOBJKHPIH()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.IKIPBLGNBKQ().intensity > 1681f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060062B5 RID: 25269 RVA: 0x00026A73 File Offset: 0x00024C73
	public void GKPPOKPLBPH()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062B6 RID: 25270 RVA: 0x00323BC4 File Offset: 0x00321DC4
	public bool PJMKJBBOONF()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.FMKCQGMJHME().intensity <= 803f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555) || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060062B7 RID: 25271 RVA: 0x00323C14 File Offset: 0x00321E14
	public void HFBHMPPLCJE(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("Add to Ignore");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(23, 156, 1, RenderTextureFormat.ARGB4444)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "0"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO(" was hurled into the air!\r\n");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 510f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 429f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062B8 RID: 25272 RVA: 0x00323D90 File Offset: 0x00321F90
	public void JLGKCKMICGJ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.FMKCQGMJHME();
		LQMHKMOOHDB.EnableKeyword("[PD]");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(146, -70, 0, RenderTextureFormat.Shadowmap)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "system"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO("_FogAreaData");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 19f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 578f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062B9 RID: 25273 RVA: 0x00323F0C File Offset: 0x0032210C
	public bool FHFMFDQOEII()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.QLIGQMEDNJC().intensity <= 1485f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x00323F5C File Offset: 0x0032215C
	public void KJPPBJFHKMJ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.BFIBIFKFFHH();
		LQMHKMOOHDB.EnableKeyword("Assets/AssetBundles/MapAssets2/Models/House F 1/Materials/com_chip_mado1_mat.mat");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-152, 169, 1, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "TCPManager"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("Duplicate!");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1796f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 805f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062BB RID: 25275 RVA: 0x00026A73 File Offset: 0x00024C73
	public override void MEGLEJHOGQK()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062BC RID: 25276 RVA: 0x00026A73 File Offset: 0x00024C73
	public void JKKJCHEHECK()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062BD RID: 25277 RVA: 0x00026A73 File Offset: 0x00024C73
	public void GCIEMOEHNFE()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x003240D8 File Offset: 0x003222D8
	public void NMPJNHIPNND(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QMPCNGEMKCQ();
		LQMHKMOOHDB.EnableKeyword("Battle");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(121, -6, 0, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "Damage adds to the amount of damage done in combat"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("_FogOfWarCenter");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1728f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1633f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x00324254 File Offset: 0x00322454
	public void GHDDHOHIIHD(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QMPCNGEMKCQ();
		LQMHKMOOHDB.EnableKeyword("Protean");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-43, -30, 0, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "Run"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("BattlePoke");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1581f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 726f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062C0 RID: 25280 RVA: 0x003243D0 File Offset: 0x003225D0
	public bool FICGCOHNQHI()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OKEDNECPIQK().intensity <= 66f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060062C1 RID: 25281 RVA: 0x00324420 File Offset: 0x00322620
	public void FNBJLQCHOBO(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QKIEQHKDJEP();
		LQMHKMOOHDB.EnableKeyword(" minute ago");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(98, 162, 1, RenderTextureFormat.ARGB4444)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "A bell chimed!\r\n"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("Restores HP if hit by an Electric-type move, instead of taking damage.");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 922f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 529f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062C2 RID: 25282 RVA: 0x00026A73 File Offset: 0x00024C73
	public void GHQMEKKBHOI()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062C3 RID: 25283 RVA: 0x0032459C File Offset: 0x0032279C
	public bool DKNGHPQGIDN()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.IKIPBLGNBKQ().intensity > 386f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060062C4 RID: 25284 RVA: 0x00026A73 File Offset: 0x00024C73
	public void LBJMPMHKMEL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062C5 RID: 25285 RVA: 0x003245EC File Offset: 0x003227EC
	public bool PEDKKOKCBOB()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OKEDNECPIQK().intensity > 167f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x0032463C File Offset: 0x0032283C
	public void OQHLDPJHCGG(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("TabSettings");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(124, 115, 1, RenderTextureFormat.ARGB32)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Kanto"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("ProCamera2D Repeater extension - No ObjectToRepeat defined!");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1938f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 277f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062C7 RID: 25287 RVA: 0x00026A73 File Offset: 0x00024C73
	public void EJIEOEGQQII()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062C8 RID: 25288 RVA: 0x003247B8 File Offset: 0x003229B8
	public void FJPDEBIGDDQ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.IKIPBLGNBKQ();
		LQMHKMOOHDB.EnableKeyword(" ");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(84, -71, 0, RenderTextureFormat.RGB565)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "Shader not found ({0})"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("_Bottom");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 408f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 524f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x00324934 File Offset: 0x00322B34
	public bool JBOJHCQNCMJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 273f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x060062CA RID: 25290 RVA: 0x00324984 File Offset: 0x00322B84
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 0f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x00026A73 File Offset: 0x00024C73
	public void IIPBHPOBQGL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x003249D4 File Offset: 0x00322BD4
	public bool MCBHGIQBQGN()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.settings.intensity <= 1094f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060062CD RID: 25293 RVA: 0x00324A24 File Offset: 0x00322C24
	public bool GQQGOFKFFOF()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.IKIPBLGNBKQ().intensity > 1200f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060062CE RID: 25294 RVA: 0x00324A74 File Offset: 0x00322C74
	public bool GNCHKDJEHCJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QMPCNGEMKCQ().intensity > 129f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x00324AC4 File Offset: 0x00322CC4
	public bool MLIMGGOLOCO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.GILEDLIDHKJ().intensity > 242f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565) && !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062D0 RID: 25296 RVA: 0x00324B14 File Offset: 0x00322D14
	public void EIIMQBGGBGF(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.GILEDLIDHKJ();
		LQMHKMOOHDB.EnableKeyword("+");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-128, -90, 0, RenderTextureFormat.ARGB1555)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = ",1+"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("][");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1104f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1029f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062D1 RID: 25297 RVA: 0x00026A73 File Offset: 0x00024C73
	public void HDJICFQCJCN()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062D2 RID: 25298 RVA: 0x00324C90 File Offset: 0x00322E90
	public bool FFIFKCJECIQ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QKIEQHKDJEP().intensity > 45f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060062D3 RID: 25299 RVA: 0x00324CE0 File Offset: 0x00322EE0
	public void CKBBCHNFCJG(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QMPCNGEMKCQ();
		LQMHKMOOHDB.EnableKeyword("VolumetricFogAndMist/CopyOpaque");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-165, 44, 1, RenderTextureFormat.ARGB1555)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "Are you sure you wish to delete your '"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("Party");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1341f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1550f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x00026A73 File Offset: 0x00024C73
	public void CCIIKDGCEIL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x00324E5C File Offset: 0x0032305C
	public void DCEPQMBPBGQ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		LQMHKMOOHDB.EnableKeyword("Trade Error");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-183, -191, 1, RenderTextureFormat.Default)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "[PD]"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("The hail stopped.");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1953f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1558f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062D6 RID: 25302 RVA: 0x00324FD8 File Offset: 0x003231D8
	public bool GJJIBBQDKNF()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QMPCNGEMKCQ().intensity > 1839f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444) && !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x00026A73 File Offset: 0x00024C73
	public void OHFKKHPGNPP()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x00325028 File Offset: 0x00323228
	public bool EOPQCNGCKKH()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OKEDNECPIQK().intensity > 832f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444) && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x00325078 File Offset: 0x00323278
	public void LEPBEKPENFC(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		LQMHKMOOHDB.EnableKeyword("_Jitter");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-34, 150, 1, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "yawn"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("x");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 503f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 517f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062DA RID: 25306 RVA: 0x003251F4 File Offset: 0x003233F4
	public void FLHPMJGDDFD(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		LQMHKMOOHDB.EnableKeyword("JOFLHFQQCKG");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(57, -189, 1, RenderTextureFormat.ARGB4444)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "_NeutralTonemapperParams1"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("/03_1");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1673f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1476f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x00325370 File Offset: 0x00323570
	public bool LIIPEPQIGQF()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.QMPCNGEMKCQ().intensity <= 392f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555) || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062DC RID: 25308 RVA: 0x003253C0 File Offset: 0x003235C0
	public void BDKDEELLGCI(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		LQMHKMOOHDB.EnableKeyword("'s torment wore off!\r\n");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(62, 173, 1, RenderTextureFormat.Shadowmap)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Flash"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("'.");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 35f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1349f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x0032553C File Offset: 0x0032373C
	public void GKQLOPKCIOF(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.FMKCQGMJHME();
		LQMHKMOOHDB.EnableKeyword("(Q)");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-39, -138, 1, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "[-]!\r\n"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("_ReflectionBufferSize");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1529f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1268f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062DE RID: 25310 RVA: 0x003256B8 File Offset: 0x003238B8
	public bool KJNQOOQQDDO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OKEDNECPIQK().intensity > 84f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444) && !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060062DF RID: 25311 RVA: 0x00325708 File Offset: 0x00323908
	public bool DPEGBIKCKMJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QMPCNGEMKCQ().intensity > 1325f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010) && !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062E0 RID: 25312 RVA: 0x00325758 File Offset: 0x00323958
	public void GJFKFDJHFMG(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.OKEDNECPIQK();
		LQMHKMOOHDB.EnableKeyword("Boulder Badge");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-15, -53, 1, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "High Chance to encounter Steel-Type"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("MSGBOX - Confirm EVs");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1261f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 214f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062E1 RID: 25313 RVA: 0x003258D4 File Offset: 0x00323AD4
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("GRAIN");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(192, 192, 0, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Grain Lookup Texture"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Grain Generator");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 20f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 20f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062E2 RID: 25314 RVA: 0x00325A50 File Offset: 0x00323C50
	public bool OCLNJQFCJOD()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.NQOJGDFCPHG().intensity <= 614f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555) || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060062E3 RID: 25315 RVA: 0x00325AA0 File Offset: 0x00323CA0
	public bool ILHMOONEMCB()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OKEDNECPIQK().intensity <= 1783f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060062E4 RID: 25316 RVA: 0x00026A73 File Offset: 0x00024C73
	public void BKNILFIBHIF()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x00325AF0 File Offset: 0x00323CF0
	public void NPHFFONOFOJ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.OKEDNECPIQK();
		LQMHKMOOHDB.EnableKeyword("colorchange");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(125, -74, 0, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Effort Values[FFFF00] ("
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("hypercutter");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 452f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 625f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062E7 RID: 25319 RVA: 0x00325C6C File Offset: 0x00323E6C
	public void NKBKHOMIFIP(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		LQMHKMOOHDB.EnableKeyword("Level Ball");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(155, -65, 1, RenderTextureFormat.ARGB1555)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "Guild Request"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("Flare Boost");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 661f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 701f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062E8 RID: 25320 RVA: 0x00026A73 File Offset: 0x00024C73
	public void DBNCHQFFEOG()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062E9 RID: 25321 RVA: 0x00325DE8 File Offset: 0x00323FE8
	public bool FMBQKNIDJGE()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DNDPKMIFFDJ().intensity <= 1318f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565) || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060062EA RID: 25322 RVA: 0x00325E38 File Offset: 0x00324038
	public void MPFCKJEJFIM(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		LQMHKMOOHDB.EnableKeyword("OnDragOut");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(188, -55, 0, RenderTextureFormat.RGB565)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "[ATK]"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("RightS");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 471f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1504f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x00325FB4 File Offset: 0x003241B4
	public void GIPBHBIQMQK(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.IKIPBLGNBKQ();
		LQMHKMOOHDB.EnableKeyword("curse");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(128, 177, 1, RenderTextureFormat.ARGB32)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "slp"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("Active: ");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1987f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1590f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x00326130 File Offset: 0x00324330
	public void OIMKDFOQHIO(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.OKEDNECPIQK();
		LQMHKMOOHDB.EnableKeyword(" ");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-162, 49, 1, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "High Chance to encounter Steel-Type"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("[PD]");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1206f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 650f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x003262AC File Offset: 0x003244AC
	public void PLDPQNQKCEQ(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.KKJKEOPIHLO();
		LQMHKMOOHDB.EnableKeyword("_FogAlpha");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(40, 28, 0, RenderTextureFormat.Shadowmap)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "[ffff00]"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("Small/");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1384f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 1 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1671f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x00026A73 File Offset: 0x00024C73
	public void JGMBMHBFHDF()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062EF RID: 25327 RVA: 0x00026A73 File Offset: 0x00024C73
	public void NFPQKFCHDGM()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062F0 RID: 25328 RVA: 0x00326428 File Offset: 0x00324628
	public void OHOOHBNODFC(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("_Blinds");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(-127, 86, 1, RenderTextureFormat.Default)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = " was freed from Leech Seed!\r\n"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB("[upkeep]");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 866f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 0);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1515f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x060062F1 RID: 25329 RVA: 0x00026A73 File Offset: 0x00024C73
	public void NNBNJQECJBE()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
		this.GNQHOLDOGHG = null;
	}

	// Token: 0x060062F2 RID: 25330 RVA: 0x003265A4 File Offset: 0x003247A4
	public void FFIMGKENCMN(Material LQMHKMOOHDB)
	{
		GrainModel.Settings settings = base.FIFNHCKNDQE.GILEDLIDHKJ();
		LQMHKMOOHDB.EnableKeyword("A heavy rain began to fall!");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.GNQHOLDOGHG == null || !this.GNQHOLDOGHG.IsCreated())
		{
			LGJGBKJCKPH.MOPPIIOIIDM(this.GNQHOLDOGHG);
			this.GNQHOLDOGHG = new RenderTexture(46, 34, 0, RenderTextureFormat.RGB565)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "Password is too short"
			};
			this.GNQHOLDOGHG.Create();
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO("Bicycle");
		material.SetFloat(FFMEDEIIJOC.CKFEJMMCIHL.HDCCMOOKEFM, realtimeSinceStartup / 1397f);
		Graphics.Blit(null, this.GNQHOLDOGHG, material, (!settings.colored) ? 0 : 1);
		LQMHKMOOHDB.SetTexture(FFMEDEIIJOC.CKFEJMMCIHL.EBLFCCGHNQF, this.GNQHOLDOGHG);
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.DKNNNJPNCLL, new Vector2(settings.luminanceContribution, settings.intensity * 1171f));
		LQMHKMOOHDB.SetVector(FFMEDEIIJOC.CKFEJMMCIHL.QHDPKLPFFCD, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)this.GNQHOLDOGHG.width / settings.size, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)this.GNQHOLDOGHG.height / settings.size, value, value2));
	}

	// Token: 0x040014F6 RID: 5366
	private RenderTexture GNQHOLDOGHG;

	// Token: 0x020002C6 RID: 710
	private static class CKFEJMMCIHL
	{
		// Token: 0x040014F7 RID: 5367
		internal static readonly int DKNNNJPNCLL = Shader.PropertyToID("_Grain_Params1");

		// Token: 0x040014F8 RID: 5368
		internal static readonly int QHDPKLPFFCD = Shader.PropertyToID("_Grain_Params2");

		// Token: 0x040014F9 RID: 5369
		internal static readonly int EBLFCCGHNQF = Shader.PropertyToID("_GrainTex");

		// Token: 0x040014FA RID: 5370
		internal static readonly int HDCCMOOKEFM = Shader.PropertyToID("_Phase");
	}
}
