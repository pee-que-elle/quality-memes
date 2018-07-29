using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002BF RID: 703
public sealed class KDMBLOFFMFG : ONQQOCQBQIE<EyeAdaptationModel>
{
	// Token: 0x060061F3 RID: 25075 RVA: 0x0031DB18 File Offset: 0x0031BD18
	public void GCIEMOEHNFE()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 1; i < ioodgkndmho.Length; i += 0)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x000265E9 File Offset: 0x000247E9
	public void CGIQQJOJDNQ()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x000265F2 File Offset: 0x000247F2
	public bool FDECPFHIFML()
	{
		return !base.FIFNHCKNDQE.enabled || !SystemInfo.supportsComputeShaders || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x0031DB80 File Offset: 0x0031BD80
	private Vector4 NFIKBFHINEE()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1971f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / 805f), Mathf.Floor((float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / 1743f));
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x00026619 File Offset: 0x00024819
	public bool FMBQKNIDJGE()
	{
		return base.FIFNHCKNDQE.enabled && SystemInfo.supportsComputeShaders && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x0031DBF4 File Offset: 0x0031BDF4
	private Vector4 NKPMOKKDCHJ()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1139f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / 1362f), Mathf.Floor((float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / 355f));
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x00026640 File Offset: 0x00024840
	public void OCKLNMHIQIK()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x060061FA RID: 25082 RVA: 0x0031DC68 File Offset: 0x0031BE68
	public Texture HFBHMPPLCJE(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.KDKQOHONODB();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("Lowers the power of Fire-type moves done to the Pokémon and prevents the Pokémon from getting a burn.");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("_Step");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(4, 8);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[8];
		}
		Vector4 vector = this.IMGFMGNGKEI();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "Assets/AssetBundles/MapAssets2/ModelPrefabs/");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)(-31));
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)(-76));
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("]#");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "shiny", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "raindance", renderTexture);
		this.KHNPIFIHCEH.SetVector("(R)", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1742f), Mathf.CeilToInt((float)renderTexture.height / 1494f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.ICJLJEKEIJL(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1777f, 562f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1003f, settings.highPercent - 1409f);
		material.SetBuffer("--offline", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 102f, settings.highPercent * 4f, Mathf.Exp(settings.minLuminance * 789f), Mathf.Exp(settings.maxLuminance * 546f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("ff6649");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[(num += 0) % 5];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 6];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 1) % 5;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(154, 179, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 4);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x060061FB RID: 25083 RVA: 0x0031E044 File Offset: 0x0031C244
	public Texture BGDFDBGLPOG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.FOIFBEBOCHD();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("'s ");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("primordialsea");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-88, 2);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-40];
		}
		Vector4 vector = this.HKOOHNMCPQQ();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, " bytes");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 0, 1, (RenderTextureFormat)(-13));
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-17));
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("[/pok]");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "watersport", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "Hidden/", renderTexture);
		this.KHNPIFIHCEH.SetVector("trapped", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 290f), Mathf.CeilToInt((float)renderTexture.height / 502f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1847f, 241f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1367f, settings.highPercent - 857f);
		material.SetBuffer("BuffIcon_EncounterRateIncrease", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 711f, settings.highPercent * 289f, Mathf.Exp(settings.minLuminance * 1284f), Mathf.Exp(settings.maxLuminance * 1840f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("limber");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 1];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 1) % 5;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.DIEGCPFPNLD(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(36, 44, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 7);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x0031E420 File Offset: 0x0031C620
	public void OELBQLEKGNF()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 0; i < ioodgkndmho.Length; i += 0)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x0031E488 File Offset: 0x0031C688
	public void HDPLJPCCCOH()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.GDBEDMQFGNE.x * (float)Screen.width + 8f, 8f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x000265E9 File Offset: 0x000247E9
	public void FLKHQHIGFOL()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006200 RID: 25088 RVA: 0x00026664 File Offset: 0x00024864
	public bool JMDOPJEOKBJ()
	{
		return base.FIFNHCKNDQE.enabled && SystemInfo.supportsComputeShaders && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x000265E9 File Offset: 0x000247E9
	public void OFLEOHNLPCB()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006202 RID: 25090 RVA: 0x0031E504 File Offset: 0x0031C704
	public void NFFQELLLJEJ()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.FNGCCEFEGLQ().x * (float)Screen.width + 1379f, 1627f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006203 RID: 25091 RVA: 0x0002668B File Offset: 0x0002488B
	public bool JBOJHCQNCMJ()
	{
		return base.FIFNHCKNDQE.enabled && SystemInfo.supportsComputeShaders && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006204 RID: 25092 RVA: 0x00026640 File Offset: 0x00024840
	public void OGPKBJBLPGP()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x0031E580 File Offset: 0x0031C780
	public void OBCBHELFKHK()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.OCQPMDOCLLB().x * (float)Screen.width + 1119f, 925f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x0031E5FC File Offset: 0x0031C7FC
	public void KHMHGMOONLF()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.OLIILQIGLGG().x * (float)Screen.width + 802f, 442f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x0031E678 File Offset: 0x0031C878
	private Vector4 QHDDBPNIDPB()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.KQIDFGFENHM();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 739f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / 849f), Mathf.Floor((float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / 1180f));
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x0031E6EC File Offset: 0x0031C8EC
	private Vector4 MJCCFINFDMQ()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 925f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / 216f), Mathf.Floor((float)this.BEHMQBIFCOJ.DFKQMMIQDOO / 1623f));
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x0031E760 File Offset: 0x0031C960
	public Texture CDFCMCPICGC(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.CKBPDQIOCLC();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("3");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.FJIJQOQKHGK("Simple");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-78, 7);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-19];
		}
		Vector4 vector = this.NKPMOKKDCHJ();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, " go!\r\n");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)88);
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 0, 1, (RenderTextureFormat)(-72));
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("_Contrast");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "VFMDepthSunCamera", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "'s [ffff00]", renderTexture);
		this.KHNPIFIHCEH.SetVector("d", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 625f), Mathf.CeilToInt((float)renderTexture.height / 1240f), 1);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1527f, 1390f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1822f, settings.highPercent - 1197f);
		material.SetBuffer("_Scale", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1310f, settings.highPercent * 1073f, Mathf.Exp(settings.minLuminance * 367f), Mathf.Exp(settings.maxLuminance * 853f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Crack");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 7];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 3];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 8;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OMBJCCDPMQM(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-194, 148, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 4);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x0031EB3C File Offset: 0x0031CD3C
	public Texture KBCCBIHFBDP(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.KQIDFGFENHM();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("3D");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("_1");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-119, 0);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-98];
		}
		Vector4 vector = this.NFIKBFHINEE();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, " transformed into the ");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 1, 1, (RenderTextureFormat)(-98));
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 0, 0, RenderTextureFormat.Shadowmap);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("Stench");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "No cinematic targets added to the list", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "Disabled", renderTexture);
		this.KHNPIFIHCEH.SetVector(" braced itself!\r\n", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1734f), Mathf.CeilToInt((float)renderTexture.height / 689f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 158f, 39f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1086f, settings.highPercent - 1396f);
		material.SetBuffer("'s [ffff00]", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1951f, settings.highPercent * 1090f, Mathf.Exp(settings.minLuminance * 586f), Mathf.Exp(settings.maxLuminance * 1400f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 5];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 4;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.GIBGBKMLFOO(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-155, 56, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 2);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x0031EF18 File Offset: 0x0031D118
	public Texture FMMDKKIJQPH(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.IEDQPECKQDN();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("^emote+");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("System");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(59, 2);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-59];
		}
		Vector4 vector = this.NFIKBFHINEE();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "[PD]");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)(-92));
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 0, 1, (RenderTextureFormat)82);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("Battle Update: ");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "-singleturn", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "13", renderTexture);
		this.KHNPIFIHCEH.SetVector("[FF8F00]", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 175f), Mathf.CeilToInt((float)renderTexture.height / 1480f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1278f, 205f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1291f, settings.highPercent - 937f);
		material.SetBuffer("merciless", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1999f, settings.highPercent * 1186f, Mathf.Exp(settings.minLuminance * 701f), Mathf.Exp(settings.maxLuminance * 635f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("BuffIcon_Teleport2");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[(num += 0) % 8];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 1) % 2;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(191, 35, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 0);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x0031F2F4 File Offset: 0x0031D4F4
	public void CBDHNEGBFLG()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.OCQPMDOCLLB().x * (float)Screen.width + 549f, 768f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x0031F370 File Offset: 0x0031D570
	public void MGDGGGGICLK()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.OLIILQIGLGG().x * (float)Screen.width + 559f, 711f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x0031F3EC File Offset: 0x0031D5EC
	public void HONQLJPLOPK()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.LBBDQFPGDDC().x * (float)Screen.width + 101f, 219f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x0600620F RID: 25103 RVA: 0x0031F468 File Offset: 0x0031D668
	public void GHQMEKKBHOI()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x0031F4D0 File Offset: 0x0031D6D0
	public void MBKFNINCILC()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.FNGCCEFEGLQ().x * (float)Screen.width + 226f, 1459f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x0031F54C File Offset: 0x0031D74C
	public Texture DFLOLMMCGID(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("Shaders/EyeHistogram");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Eye Adaptation");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(64, 4);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[64];
		}
		Vector4 vector = this.KQLOJNENELE();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 1, 0, RenderTextureFormat.RFloat);
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 1, 0, RenderTextureFormat.RFloat);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("KEyeHistogram");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "_Histogram", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "_Source", renderTexture);
		this.KHNPIFIHCEH.SetVector("_ScaleOffsetRes", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 16f), Mathf.CeilToInt((float)renderTexture.height / 16f), 1);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1.01f, 99f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1f, settings.highPercent - 0.01f);
		material.SetBuffer("_Histogram", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 0.01f, settings.highPercent * 0.01f, Mathf.Exp(settings.minLuminance * 0.6931472f), Mathf.Exp(settings.maxLuminance * 0.6931472f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("AUTO_KEY_VALUE");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 2];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 2];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 1) % 2;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(256, 128, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 2);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x0031F928 File Offset: 0x0031DB28
	public Texture BFIQNHPQMKM(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.CHPQDOIHNNH();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("PlayDeadAnimation");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("_Params");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(120, 8);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[17];
		}
		Vector4 vector = this.BNJIFLJDNPH();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN((int)vector.z, (int)vector.w, 1, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "[/itm]");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(0, 1, 0, (RenderTextureFormat)88);
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)127);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("PrimitiveRearRightCorner");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "#,##0", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "_VelocityTex", renderTexture);
		this.KHNPIFIHCEH.SetVector("0", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1664f), Mathf.CeilToInt((float)renderTexture.height / 656f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 783f, 88f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1821f, settings.highPercent - 1613f);
		material.SetBuffer("Icon_Pokemon_Alive", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 404f, settings.highPercent * 239f, Mathf.Exp(settings.minLuminance * 1920f), Mathf.Exp(settings.maxLuminance * 503f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("But nothing happened!\r\n");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 7];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 5;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.DIEGCPFPNLD(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-175, 158, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 3);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x00026640 File Offset: 0x00024840
	public void HBJBLMLMEBD()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x0031FD04 File Offset: 0x0031DF04
	public Texture GJFKFDJHFMG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("Nest Ball");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("_Cutoff");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-34, 6);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[93];
		}
		Vector4 vector = this.FHLGOEGJGGQ();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "aa");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 0, 0, (RenderTextureFormat)(-55));
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 1, 1, (RenderTextureFormat)103);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("COLOR_GRADING_LOG_VIEW");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "Enabled", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "Liquid Voice", renderTexture);
		this.KHNPIFIHCEH.SetVector("stormdrain", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1097f), Mathf.CeilToInt((float)renderTexture.height / 1832f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 516f, 917f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 576f, settings.highPercent - 81f);
		material.SetBuffer("C", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1790f, settings.highPercent * 276f, Mathf.Exp(settings.minLuminance * 410f), Mathf.Exp(settings.maxLuminance * 307f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("TM");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 6];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 0;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(181, -116, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 6);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x003200E0 File Offset: 0x0031E2E0
	public Texture MLFHCLPMMLJ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("F6");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GBBDHLKHEOO("When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(93, 5);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-28];
		}
		Vector4 vector = this.FHLGOEGJGGQ();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "1");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-52));
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 1, 1, (RenderTextureFormat)38);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel(" (ID:");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "[00DD00]Equipped", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "?", renderTexture);
		this.KHNPIFIHCEH.SetVector("desolateland", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 988f), Mathf.CeilToInt((float)renderTexture.height / 237f), 1);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1283f, 75f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 737f, settings.highPercent - 1810f);
		material.SetBuffer("Flash", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 242f, settings.highPercent * 1209f, Mathf.Exp(settings.minLuminance * 106f), Mathf.Exp(settings.maxLuminance * 196f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Player Fly Mount");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[(num += 0) % 0];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[(num += 0) % 0];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 7;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-7, 8, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 6);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x003204BC File Offset: 0x0031E6BC
	private Vector4 QLKKNBJKBKI()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.KDKQOHONODB();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 517f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / 164f), Mathf.Floor((float)this.BEHMQBIFCOJ.DFKQMMIQDOO / 910f));
	}

	// Token: 0x06006217 RID: 25111 RVA: 0x00320530 File Offset: 0x0031E730
	private Vector4 HELDCBKLLNI()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 3f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / 664f), Mathf.Floor((float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / 95f));
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x0031E420 File Offset: 0x0031C620
	public void LBJMPMHKMEL()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 0; i < ioodgkndmho.Length; i += 0)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006219 RID: 25113 RVA: 0x000265E9 File Offset: 0x000247E9
	public override void MNIFEBDOGKD()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x0600621A RID: 25114 RVA: 0x0031F468 File Offset: 0x0031D668
	public override void MEGLEJHOGQK()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x0600621B RID: 25115 RVA: 0x003205A4 File Offset: 0x0031E7A4
	private Vector4 IMGFMGNGKEI()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1090f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / 987f), Mathf.Floor((float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / 644f));
	}

	// Token: 0x0600621C RID: 25116 RVA: 0x00320618 File Offset: 0x0031E818
	private Vector4 FHLGOEGJGGQ()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.FOIFBEBOCHD();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1025f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / 843f), Mathf.Floor((float)this.BEHMQBIFCOJ.DFKQMMIQDOO / 1972f));
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x0031F468 File Offset: 0x0031D668
	public void FQPFQEDLIFL()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x00026640 File Offset: 0x00024840
	public void FDFLIPMMEQD()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x0600621F RID: 25119 RVA: 0x00026640 File Offset: 0x00024840
	public void CMDLDHFEEHQ()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006220 RID: 25120 RVA: 0x0032068C File Offset: 0x0031E88C
	public void FFJLCGQCGJM()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.LQNFJIFOHFD().x * (float)Screen.width + 922f, 1554f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006221 RID: 25121 RVA: 0x00320708 File Offset: 0x0031E908
	private Vector4 HKOOHNMCPQQ()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.FOIFBEBOCHD();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 564f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / 876f), Mathf.Floor((float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / 1369f));
	}

	// Token: 0x06006222 RID: 25122 RVA: 0x0032077C File Offset: 0x0031E97C
	public Texture CDGPNFDPKPQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("frz");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("Player/Clothe");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(95, 3);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-73];
		}
		Vector4 vector = this.QLKKNBJKBKI();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Sound");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(0, 1, 0, (RenderTextureFormat)70);
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 1, 1, (RenderTextureFormat)38);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("\r\nPP ");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, " can not hold that many more '", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "It doesn't affect ", renderTexture);
		this.KHNPIFIHCEH.SetVector("berry_6", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 532f), Mathf.CeilToInt((float)renderTexture.height / 1290f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.ICJLJEKEIJL(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1467f, 1704f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1892f, settings.highPercent - 418f);
		material.SetBuffer(" minutes", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1877f, settings.highPercent * 1282f, Mathf.Exp(settings.minLuminance * 759f), Mathf.Exp(settings.maxLuminance * 154f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("lightscreen");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[(num += 0) % 6];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 3];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 2;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[0], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.NHJLBCFQCGD(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-75, -178, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 5);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006223 RID: 25123 RVA: 0x0031F468 File Offset: 0x0031D668
	public void EGNIEILNFJH()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x0031F468 File Offset: 0x0031D668
	public void EIICFMBEMFF()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x00026640 File Offset: 0x00024840
	public void JODCDMDCLFD()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006226 RID: 25126 RVA: 0x000265E9 File Offset: 0x000247E9
	public void HQMLEGGKFNF()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x00026640 File Offset: 0x00024840
	public void KEGDOIJICEL()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x000265E9 File Offset: 0x000247E9
	public void BCONPFCKBKG()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x00320B58 File Offset: 0x0031ED58
	public void DEJLQNOFBDG()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 1; i < ioodgkndmho.Length; i++)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x00320BC0 File Offset: 0x0031EDC0
	public Texture BHEMFGFHNFH(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("[/i]");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("Small/9999");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-19, 3);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-91];
		}
		Vector4 vector = this.IMGFMGNGKEI();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "ability: ");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[1] = new RenderTexture(1, 1, 1, (RenderTextureFormat)(-73));
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-36));
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("_FogPointLightPosition0");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "blank", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "snowwarning", renderTexture);
		this.KHNPIFIHCEH.SetVector("QTY: ", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1160f), Mathf.CeilToInt((float)renderTexture.height / 1476f), 1);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.ICJLJEKEIJL(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 129f, 144f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 415f, settings.highPercent - 602f);
		material.SetBuffer("Mouse ScrollWheel", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1160f, settings.highPercent * 291f, Mathf.Exp(settings.minLuminance * 1382f), Mathf.Exp(settings.maxLuminance * 116f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Rough Skin");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 2];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[(num += 0) % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 5;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 1);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[0]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.HIFCCQDDLJH(BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-157, -137, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 3);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x00320F9C File Offset: 0x0031F19C
	public Texture KJGHGLQFCEG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("Teleport");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NJKNIOFBHBD("wrap");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(77, 0);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-41];
		}
		Vector4 vector = this.HELDCBKLLNI();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "_Distance");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)110);
		}
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 1, 1, RenderTextureFormat.RGB111110Float);
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("Oh no! The Pokémon broke free!\r\n");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "b", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "-curestatus", renderTexture);
		this.KHNPIFIHCEH.SetVector("!\r\n", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 583f), Mathf.CeilToInt((float)renderTexture.height / 1979f), 0);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1372f, 1062f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1981f, settings.highPercent - 1517f);
		material.SetBuffer("#,##0", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1056f, settings.highPercent * 914f, Mathf.Exp(settings.minLuminance * 841f), Mathf.Exp(settings.maxLuminance * 148f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("5_");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[(num += 0) % 5];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 0];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 0) % 8;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[1];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.MOKDJMOKIKO(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-15, -138, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 7);
		}
		this.MGDQKEIKDPO = true;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x00321378 File Offset: 0x0031F578
	private Vector4 KQLOJNENELE()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.settings;
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / 2f), Mathf.Floor((float)this.BEHMQBIFCOJ.DFKQMMIQDOO / 2f));
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x0600622D RID: 25133 RVA: 0x00026664 File Offset: 0x00024864
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && SystemInfo.supportsComputeShaders && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x003213EC File Offset: 0x0031F5EC
	private Vector4 BNJIFLJDNPH()
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.JJGCHIBJKNL();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 862f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / 140f), Mathf.Floor((float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / 1106f));
	}

	// Token: 0x0600622F RID: 25135 RVA: 0x0031F468 File Offset: 0x0031D668
	public void BFCGNMEJDPH()
	{
		foreach (RenderTexture njbfoqdjbon in this.IOODGKNDMHO)
		{
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x0031DB18 File Offset: 0x0031BD18
	public void EHBMMLIEFBQ()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 1; i < ioodgkndmho.Length; i += 0)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x00321460 File Offset: 0x0031F660
	public void INFKLKFBPCN()
	{
		if (!(this.KIEHKPPBPOL == null) && this.KIEHKPPBPOL.IsCreated())
		{
			Rect position = new Rect(this.BEHMQBIFCOJ.OLIILQIGLGG().x * (float)Screen.width + 1820f, 1657f, (float)this.KIEHKPPBPOL.width, (float)this.KIEHKPPBPOL.height);
			GUI.DrawTexture(position, this.KIEHKPPBPOL);
			return;
		}
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x000266B2 File Offset: 0x000248B2
	public bool QEKKBBKKBPD()
	{
		return !base.FIFNHCKNDQE.enabled || !SystemInfo.supportsComputeShaders || this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x00026640 File Offset: 0x00024840
	public void HNPKPINGJID()
	{
		this.MGDQKEIKDPO = false;
	}

	// Token: 0x06006234 RID: 25140 RVA: 0x000266D9 File Offset: 0x000248D9
	public bool DDPQKIGQKEE()
	{
		return base.FIFNHCKNDQE.enabled && SystemInfo.supportsComputeShaders && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006235 RID: 25141 RVA: 0x003214DC File Offset: 0x0031F6DC
	public Texture CEJGBIEMMME(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB)
	{
		EyeAdaptationModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		if (this.KHNPIFIHCEH == null)
		{
			this.KHNPIFIHCEH = Resources.Load<ComputeShader>("runaway");
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("'s move was postponed!\r\n");
		material.shaderKeywords = null;
		if (this.JEBLKNHCLNB == null)
		{
			this.JEBLKNHCLNB = new ComputeBuffer(-90, 5);
		}
		if (KDMBLOFFMFG.JILHJMPCJCH == null)
		{
			KDMBLOFFMFG.JILHJMPCJCH = new uint[-127];
		}
		Vector4 vector = this.HKOOHNMCPQQ();
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM((int)vector.z, (int)vector.w, 0, PBHPQFLMQDB.format, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Cinematics");
		Graphics.Blit(PBHPQFLMQDB, renderTexture);
		if (this.IOODGKNDMHO[1] == null || !this.IOODGKNDMHO[1].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)(-41));
		}
		if (this.IOODGKNDMHO[0] == null || !this.IOODGKNDMHO[0].IsCreated())
		{
			this.IOODGKNDMHO[0] = new RenderTexture(0, 1, 0, (RenderTextureFormat)(-32));
		}
		this.JEBLKNHCLNB.SetData(KDMBLOFFMFG.JILHJMPCJCH);
		int kernelIndex = this.KHNPIFIHCEH.FindKernel("skinshop");
		this.KHNPIFIHCEH.SetBuffer(kernelIndex, "_ReflectionColor", this.JEBLKNHCLNB);
		this.KHNPIFIHCEH.SetTexture(kernelIndex, "Applying a new Guild Logo will cost [PG]300.\n\nAre you sure you want to do this?\nInappropriate images drawn will result in account termination.", renderTexture);
		this.KHNPIFIHCEH.SetVector("Fire's power was weakened!\r\n", vector);
		this.KHNPIFIHCEH.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 832f), Mathf.CeilToInt((float)renderTexture.height / 654f), 1);
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1315f, 564f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1498f, settings.highPercent - 1633f);
		material.SetBuffer(" minutes ago", this.JEBLKNHCLNB);
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.PJEKHIJIFDF, new Vector4(settings.lowPercent * 1829f, settings.highPercent * 912f, Mathf.Exp(settings.minLuminance * 1898f), Mathf.Exp(settings.maxLuminance * 1654f)));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.QGGHJJIPNPK, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(KDMBLOFFMFG.IGBENCIDIEM.OIDIODLEEIP, vector);
		material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.OCGFOKNJGDI, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("BB:");
		}
		if (!this.MGDQKEIKDPO && Application.isPlaying)
		{
			int num = this.IPDJHGLNLBC;
			RenderTexture source = this.IOODGKNDMHO[++num % 2];
			RenderTexture renderTexture2 = this.IOODGKNDMHO[++num % 4];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.IPDJHGLNLBC = (num + 1) % 6;
			this.PIDLQCKJIPI = renderTexture2;
		}
		else
		{
			this.PIDLQCKJIPI = this.IOODGKNDMHO[0];
			Graphics.Blit(null, this.PIDLQCKJIPI, material, 0);
			Graphics.Blit(this.IOODGKNDMHO[1], this.IOODGKNDMHO[1]);
		}
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.KPPGBNLQHLM(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			if (this.KIEHKPPBPOL == null || !this.KIEHKPPBPOL.IsCreated())
			{
				this.KIEHKPPBPOL = new RenderTexture(-188, -159, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(KDMBLOFFMFG.IGBENCIDIEM.QFCIHKGJPML, (float)this.KIEHKPPBPOL.width);
			Graphics.Blit(null, this.KIEHKPPBPOL, material, 6);
		}
		this.MGDQKEIKDPO = false;
		return this.PIDLQCKJIPI;
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x000265E9 File Offset: 0x000247E9
	public void KPECJMCFBJN()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x000265E9 File Offset: 0x000247E9
	public void QHHEJOMINDE()
	{
		this.MGDQKEIKDPO = true;
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x0031E420 File Offset: 0x0031C620
	public void DOKBMDEMDGK()
	{
		RenderTexture[] ioodgkndmho = this.IOODGKNDMHO;
		for (int i = 0; i < ioodgkndmho.Length; i += 0)
		{
			RenderTexture njbfoqdjbon = ioodgkndmho[i];
			LGJGBKJCKPH.MOPPIIOIIDM(njbfoqdjbon);
		}
		if (this.JEBLKNHCLNB != null)
		{
			this.JEBLKNHCLNB.Release();
		}
		this.JEBLKNHCLNB = null;
		if (this.KIEHKPPBPOL != null)
		{
			this.KIEHKPPBPOL.Release();
		}
		this.KIEHKPPBPOL = null;
	}

	// Token: 0x040014DD RID: 5341
	private ComputeShader KHNPIFIHCEH;

	// Token: 0x040014DE RID: 5342
	private ComputeBuffer JEBLKNHCLNB;

	// Token: 0x040014DF RID: 5343
	private readonly RenderTexture[] IOODGKNDMHO = new RenderTexture[2];

	// Token: 0x040014E0 RID: 5344
	private int IPDJHGLNLBC;

	// Token: 0x040014E1 RID: 5345
	private RenderTexture PIDLQCKJIPI;

	// Token: 0x040014E2 RID: 5346
	private RenderTexture KIEHKPPBPOL;

	// Token: 0x040014E3 RID: 5347
	private static uint[] JILHJMPCJCH;

	// Token: 0x040014E4 RID: 5348
	private bool MGDQKEIKDPO = true;

	// Token: 0x040014E5 RID: 5349
	private const int FGHIFMKJHLF = 64;

	// Token: 0x040014E6 RID: 5350
	private const int ENJILMJMHMB = 16;

	// Token: 0x040014E7 RID: 5351
	private const int PIPKBQBHQCE = 16;

	// Token: 0x020002C0 RID: 704
	private static class IGBENCIDIEM
	{
		// Token: 0x040014E8 RID: 5352
		internal static readonly int PJEKHIJIFDF = Shader.PropertyToID("_Params");

		// Token: 0x040014E9 RID: 5353
		internal static readonly int QGGHJJIPNPK = Shader.PropertyToID("_Speed");

		// Token: 0x040014EA RID: 5354
		internal static readonly int OIDIODLEEIP = Shader.PropertyToID("_ScaleOffsetRes");

		// Token: 0x040014EB RID: 5355
		internal static readonly int OCGFOKNJGDI = Shader.PropertyToID("_ExposureCompensation");

		// Token: 0x040014EC RID: 5356
		internal static readonly int GMCGBCJEDPF = Shader.PropertyToID("_AutoExposure");

		// Token: 0x040014ED RID: 5357
		internal static readonly int QFCIHKGJPML = Shader.PropertyToID("_DebugWidth");
	}
}
