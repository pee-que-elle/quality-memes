using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002BB RID: 699
public sealed class LFEMGHQGCKK : ONQQOCQBQIE<DepthOfFieldModel>
{
	// Token: 0x06006145 RID: 24901 RVA: 0x0002617A File Offset: 0x0002437A
	public bool IKNNJPFFMHL()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006146 RID: 24902 RVA: 0x00319C7C File Offset: 0x00317E7C
	public void GECNLHMHNCN(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)(-95);
		RenderTextureFormat renderTextureFormat = this.DIGFLIFOBIK((RenderTextureFormat)(-128), (RenderTextureFormat)(-41));
		float num = this.CNDMFKIGBJQ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 208f * 1606f);
		float num5 = this.JFFFQDCEEBK(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GONNQQIJNLJ("Username already in use");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1379f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1007f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "You can not use buffs during interactions.");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.DOGQLEENOGD(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.ONCCDMLHNQL())) ? 1344f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 1, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.CHODJCGKMOK() / 2, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 5, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "Rough Skin");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 0);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(this.BEHMQBIFCOJ.CHODJCGKMOK() / 1, this.BEHMQBIFCOJ.JKGBHEHKBPC() / 8, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(2 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 2);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.LDFGHCBMHHH(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals))
		{
			LQMHKMOOHDB.EnableKeyword("/3");
			this.BEHMQBIFCOJ.MLMBQMFLHOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("airlock");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture3);
	}

	// Token: 0x06006147 RID: 24903 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode LMOLLEFMEPQ()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006148 RID: 24904 RVA: 0x0002619A File Offset: 0x0002439A
	public void BNKGGNOQODC()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006149 RID: 24905 RVA: 0x000261BC File Offset: 0x000243BC
	private bool FBEBNCJCCGN(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600614A RID: 24906 RVA: 0x000261F8 File Offset: 0x000243F8
	public bool GFEKCOGFOEQ()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x0600614B RID: 24907 RVA: 0x000261BC File Offset: 0x000243BC
	private bool FNINPGNGQNB(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600614C RID: 24908 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode GBHQGJOILNN()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600614D RID: 24909 RVA: 0x000261BC File Offset: 0x000243BC
	private bool NEGENGEIIHL(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600614E RID: 24910 RVA: 0x00026218 File Offset: 0x00024418
	private bool LLNJODJKDHJ(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600614F RID: 24911 RVA: 0x00026254 File Offset: 0x00024454
	public bool CBJDGOFDOKN()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x0002619A File Offset: 0x0002439A
	public void LBJMPMHKMEL()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006151 RID: 24913 RVA: 0x00026218 File Offset: 0x00024418
	private bool DIGHJJIMEIE(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode FQHONQLCGHM()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006153 RID: 24915 RVA: 0x00319F8C File Offset: 0x0031818C
	public void MFKBJEJLDNJ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)114;
		RenderTextureFormat renderTextureFormat = this.EJCFKFPFQGM((RenderTextureFormat)(-93), (RenderTextureFormat)83);
		float num = this.MCFIEQKCPBG();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1339f * 1603f);
		float num5 = this.BEOENKEFLMF(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GONNQQIJNLJ("infestation");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1154f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 438f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "_BaseTex");
		Graphics.Blit(null, renderTexture, material, 0);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.LLNJODJKDHJ(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.ONCCDMLHNQL())) ? 90f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 1);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.CHODJCGKMOK() / 3, this.BEHMQBIFCOJ.KPFJEIKPCBG() / 6, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "/[delegate]");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 5);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 5, this.BEHMQBIFCOJ.KPFJEIKPCBG() / 5, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "Spikes were scattered on the ground all around ");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(3 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 1);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			LQMHKMOOHDB.EnableKeyword("[-]!\r\n");
			this.BEHMQBIFCOJ.MLMBQMFLHOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("door_2");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture3);
	}

	// Token: 0x06006154 RID: 24916 RVA: 0x0002619A File Offset: 0x0002439A
	public void IPOJIEGOQFN()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006155 RID: 24917 RVA: 0x0031A29C File Offset: 0x0031849C
	public void IKILHOCFQKF(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)(-116);
		RenderTextureFormat renderTextureFormat = this.JDKQFGBBHOC((RenderTextureFormat)102, (RenderTextureFormat)(-90));
		float num = this.CNDMFKIGBJQ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1817f * 797f);
		float num5 = this.CBGHBODJKBL(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("u");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 418f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1085f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, " woke it up!\r\n");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.QPCJCOKPOEC(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.KPFJEIKPCBG())) ? 273f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.ONCCDMLHNQL(), 1, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.KJGMGPCEJJD / 3, this.BEHMQBIFCOJ.DFKQMMIQDOO / 4, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "FOG_OFF");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 4);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 5, this.BEHMQBIFCOJ.JKGBHEHKBPC() / 0, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "\n");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(3 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 6);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
		{
			LQMHKMOOHDB.EnableKeyword("shadowforce");
			this.BEHMQBIFCOJ.KNGHIQJHKOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("matblock");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture3);
	}

	// Token: 0x06006156 RID: 24918 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode IPHOHOKIOHM()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006157 RID: 24919 RVA: 0x00026274 File Offset: 0x00024474
	private RenderTextureFormat EJCFKFPFQGM(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGB4444;
	}

	// Token: 0x06006158 RID: 24920 RVA: 0x0031A5AC File Offset: 0x003187AC
	private float CNDMFKIGBJQ()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 181f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1859f;
		return 1012f / Mathf.Tan(1886f * num);
	}

	// Token: 0x06006159 RID: 24921 RVA: 0x0031A608 File Offset: 0x00318808
	private float NOIDFHHIEOO()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.DCBJMHJEFMG();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1424f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1425f;
		return 543f / Mathf.Tan(817f * num);
	}

	// Token: 0x0600615A RID: 24922 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode MJINGQEEBEG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600615B RID: 24923 RVA: 0x00026274 File Offset: 0x00024474
	private RenderTextureFormat DIGFLIFOBIK(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGB4444;
	}

	// Token: 0x0600615C RID: 24924 RVA: 0x0031A664 File Offset: 0x00318864
	private float FDLBFGEHCEI(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.ICJOMIGQMFC().kernelSize * 1631f + 481f;
		return Mathf.Min(1040f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x0600615D RID: 24925 RVA: 0x0031A6A0 File Offset: 0x003188A0
	private float GGGMEJKGBKH(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.QKIEQHKDJEP().kernelSize * 1005f + 1975f;
		return Mathf.Min(463f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x0600615E RID: 24926 RVA: 0x0031A6DC File Offset: 0x003188DC
	public void GJFKFDJHFMG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICEIQHLLNEL();
		RenderTextureFormat eibobkjigqb = RenderTextureFormat.RFloat;
		RenderTextureFormat renderTextureFormat = this.DIGFLIFOBIK((RenderTextureFormat)(-39), (RenderTextureFormat)34);
		float num = this.CJQCEBFJFPQ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 963f * 1883f);
		float num5 = this.HFOOFLICCOQ(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("Mouse Click Collider");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 578f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 509f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "!\r\n");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.LLNJODJKDHJ(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JKGBHEHKBPC())) ? 1517f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.KJGMGPCEJJD / 8, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 1, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "moldbreaker");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 1);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(this.BEHMQBIFCOJ.KJGMGPCEJJD / 5, this.BEHMQBIFCOJ.JHHQQQGMQBM() / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "!\r\n");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(0 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 6);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.JMMJGNMOPLE(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			LQMHKMOOHDB.EnableKeyword("Command Exception [Login]: System.TimeoutException");
			this.BEHMQBIFCOJ.KNGHIQJHKOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword(".");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture3);
	}

	// Token: 0x0600615F RID: 24927 RVA: 0x0031A9EC File Offset: 0x00318BEC
	private float OENDBHEKFIO()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICEIQHLLNEL();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1420f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1426f;
		return 949f / Mathf.Tan(1356f * num);
	}

	// Token: 0x06006160 RID: 24928 RVA: 0x0031AA48 File Offset: 0x00318C48
	private float MBJDFOQCPNG()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 191f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 594f;
		return 312f / Mathf.Tan(1516f * num);
	}

	// Token: 0x06006161 RID: 24929 RVA: 0x0002628B File Offset: 0x0002448B
	public bool FHFMFDQOEII()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006162 RID: 24930 RVA: 0x000262AB File Offset: 0x000244AB
	public bool DHHJCEFGDJN()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006163 RID: 24931 RVA: 0x0002619A File Offset: 0x0002439A
	public void FQPFQEDLIFL()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x000262CB File Offset: 0x000244CB
	public bool JBLIOCQCHBH()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x00026218 File Offset: 0x00024418
	private bool FBEPIFQQIJO(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006166 RID: 24934 RVA: 0x000261BC File Offset: 0x000243BC
	private bool EMMIODONDHO(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006167 RID: 24935 RVA: 0x0031AAA4 File Offset: 0x00318CA4
	public void GCQOKKCDPFH(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.settings;
		RenderTextureFormat eibobkjigqb = RenderTextureFormat.ARGB32;
		RenderTextureFormat renderTextureFormat = this.EQQKQNHKDEL((RenderTextureFormat)119, (RenderTextureFormat)(-76));
		float num = this.FFMFLGPBOJE();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1277f * 605f);
		float num5 = this.BEOENKEFLMF(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("wideguard");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1627f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 620f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_BloomTex");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.LLNJODJKDHJ(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.ONCCDMLHNQL())) ? 235f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(this.BEHMQBIFCOJ.KJGMGPCEJJD / 8, this.BEHMQBIFCOJ.JHHQQQGMQBM() / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "The Pokémon can use 'not very effective' moves to deal regular damage.");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 8);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 7, this.BEHMQBIFCOJ.JKGBHEHKBPC() / 8, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "´");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(5 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 3);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OPIGCJNFNMN(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion))
		{
			LQMHKMOOHDB.EnableKeyword("Are you sure you want to purchase '");
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("W");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture3);
	}

	// Token: 0x06006168 RID: 24936 RVA: 0x0031ADB4 File Offset: 0x00318FB4
	private float BJHKMMJDBNJ(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.EQLDMPKOGEL().kernelSize * 1587f + 1853f;
		return Mathf.Min(847f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x06006169 RID: 24937 RVA: 0x000262EB File Offset: 0x000244EB
	private RenderTextureFormat DMIHHEONHLQ(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGBHalf;
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x0031ADF0 File Offset: 0x00318FF0
	private float CGJDQLFFFQP()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1000f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 0.0174532924f;
		return 0.012f / Mathf.Tan(0.5f * num);
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x000262EB File Offset: 0x000244EB
	private RenderTextureFormat NGCPDEHMNLH(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGBHalf;
	}

	// Token: 0x0600616C RID: 24940 RVA: 0x0000B03A File Offset: 0x0000923A
	public override DepthTextureMode FDQNPDGFNHH()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600616D RID: 24941 RVA: 0x0031AE4C File Offset: 0x0031904C
	private float MEOOMLPGDFN()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 333f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 664f;
		return 1613f / Mathf.Tan(1906f * num);
	}

	// Token: 0x0600616E RID: 24942 RVA: 0x00026218 File Offset: 0x00024418
	private bool QPCJCOKPOEC(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600616F RID: 24943 RVA: 0x0031AEA8 File Offset: 0x003190A8
	private float CJQCEBFJFPQ()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1295f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1475f;
		return 1743f / Mathf.Tan(154f * num);
	}

	// Token: 0x06006170 RID: 24944 RVA: 0x0002619A File Offset: 0x0002439A
	public void NNBNJQECJBE()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006171 RID: 24945 RVA: 0x0031AF04 File Offset: 0x00319104
	public void OHOOHBNODFC(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)103;
		RenderTextureFormat renderTextureFormat = this.JDKQFGBBHOC((RenderTextureFormat)(-17), (RenderTextureFormat)(-47));
		float num = this.OENDBHEKFIO();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1003f * 98f);
		float num5 = this.HFOOFLICCOQ(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("/03_1");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 637f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1157f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 0, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "Applying a new Guild Logo will cost [PG]300.\n\nAre you sure you want to do this?\nInappropriate images drawn will result in account termination.");
		Graphics.Blit(null, renderTexture, material, 0);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.QPCJCOKPOEC(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC())) ? 314f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 1);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(this.BEHMQBIFCOJ.CHODJCGKMOK() / 4, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 6, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "default");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 2);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(this.BEHMQBIFCOJ.KJGMGPCEJJD / 5, this.BEHMQBIFCOJ.JHHQQQGMQBM() / 2, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, " already has a substitute!\r\n");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(1 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 5);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.KPPGBNLQHLM(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			LQMHKMOOHDB.EnableKeyword("_");
			this.BEHMQBIFCOJ.OIONKMPKBKJ();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("F5");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture3);
	}

	// Token: 0x06006172 RID: 24946 RVA: 0x0031B214 File Offset: 0x00319414
	private float HHHKKGCPBDG(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.EQLDMPKOGEL().kernelSize * 1541f + 309f;
		return Mathf.Min(397f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x06006173 RID: 24947 RVA: 0x0031B250 File Offset: 0x00319450
	private float LPILCJQPLFD()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.QKIEQHKDJEP();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1633f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1363f;
		return 563f / Mathf.Tan(706f * num);
	}

	// Token: 0x06006174 RID: 24948 RVA: 0x00026218 File Offset: 0x00024418
	private bool DOGQLEENOGD(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006175 RID: 24949 RVA: 0x000261BC File Offset: 0x000243BC
	private bool OMKPDHONHGG(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006176 RID: 24950 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode CDOLEKJNGQO()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006177 RID: 24951 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode CJFEQFLJOBL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006179 RID: 24953 RVA: 0x0031B2AC File Offset: 0x003194AC
	private float CBGHBODJKBL(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.settings.kernelSize * 1991f + 361f;
		return Mathf.Min(1870f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x1700036C RID: 876
	// (get) Token: 0x0600617A RID: 24954 RVA: 0x0002630A File Offset: 0x0002450A
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600617B RID: 24955 RVA: 0x0002619A File Offset: 0x0002439A
	public void MHNMQLMILMQ()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x0600617C RID: 24956 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode BQDEFBEEJFF()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x0031B2E8 File Offset: 0x003194E8
	private float IFCJIMCNBPQ(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.EQLDMPKOGEL().kernelSize * 851f + 1775f;
		return Mathf.Min(167f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x0031B324 File Offset: 0x00319524
	public void JOGBJIFMKCB(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)81;
		RenderTextureFormat renderTextureFormat = this.EJCFKFPFQGM((RenderTextureFormat)50, RenderTextureFormat.RInt);
		float num = this.CJQCEBFJFPQ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1970f * 1901f);
		float num5 = this.JFFFQDCEEBK(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI(", ");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 236f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1153f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "sheerforce");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.HJHEIGOFLIO(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.DFKQMMIQDOO)) ? 15f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(this.BEHMQBIFCOJ.KJGMGPCEJJD / 7, this.BEHMQBIFCOJ.JKGBHEHKBPC() / 0, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "'s Heal Block wore off!\r\n");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 4);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 6, this.BEHMQBIFCOJ.DFKQMMIQDOO / 1, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, ". Vertex Count: ");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(5 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			LQMHKMOOHDB.EnableKeyword("1");
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("_ClipToWorld");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture3);
	}

	// Token: 0x0600617F RID: 24959 RVA: 0x0031B634 File Offset: 0x00319834
	private float JFFFQDCEEBK(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.DCPMJDLDNMM().kernelSize * 1103f + 1362f;
		return Mathf.Min(546f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x06006180 RID: 24960 RVA: 0x00026274 File Offset: 0x00024474
	private RenderTextureFormat JEOLPKHQJGF(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGB4444;
	}

	// Token: 0x06006181 RID: 24961 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode OMJHDKGNDQN()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006182 RID: 24962 RVA: 0x0031B670 File Offset: 0x00319870
	private float DJFBCMOONJP(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.settings.kernelSize * 303f + 342f;
		return Mathf.Min(1100f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x06006183 RID: 24963 RVA: 0x0031B6AC File Offset: 0x003198AC
	private float MHDQBOOOBHP()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICEIQHLLNEL();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 754f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 124f;
		return 28f / Mathf.Tan(864f * num);
	}

	// Token: 0x06006184 RID: 24964 RVA: 0x0031B708 File Offset: 0x00319908
	private float NPOGLHKNIJE()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 64f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1708f;
		return 229f / Mathf.Tan(150f * num);
	}

	// Token: 0x06006185 RID: 24965 RVA: 0x0031B764 File Offset: 0x00319964
	private float MCFIEQKCPBG()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1832f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1929f;
		return 1078f / Mathf.Tan(652f * num);
	}

	// Token: 0x06006186 RID: 24966 RVA: 0x0002632A File Offset: 0x0002452A
	public bool IIBLPLDEEPB()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x06006187 RID: 24967 RVA: 0x0002628B File Offset: 0x0002448B
	public bool MCBHGIQBQGN()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006188 RID: 24968 RVA: 0x0002619A File Offset: 0x0002439A
	public override void MEGLEJHOGQK()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006189 RID: 24969 RVA: 0x0031B7C0 File Offset: 0x003199C0
	private float HFOOFLICCOQ(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.ICEIQHLLNEL().kernelSize * 2f + 179f;
		return Mathf.Min(1762f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x0002634A File Offset: 0x0002454A
	private RenderTextureFormat EQQKQNHKDEL(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.Default;
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x0031B7FC File Offset: 0x003199FC
	private float BEOENKEFLMF(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.OILMJDEQKHM().kernelSize * 346f + 770f;
		return Mathf.Min(1225f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x00026218 File Offset: 0x00024418
	private bool HJHEIGOFLIO(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return !(this.JBLIMDOEPEL != null) || !this.JBLIMDOEPEL.IsCreated() || this.JBLIMDOEPEL.width != KJGMGPCEJJD || this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode QFFKNJCJMFN()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x0031B838 File Offset: 0x00319A38
	public void JIHIIEEQPBI(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.ICJOMIGQMFC();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)(-32);
		RenderTextureFormat renderTextureFormat = this.NGCPDEHMNLH((RenderTextureFormat)(-25), (RenderTextureFormat)(-126));
		float num = this.MBJDFOQCPNG();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1985f * 1739f);
		float num5 = this.DJFBCMOONJP(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("shadowshield");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1473f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 893f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.KPFJEIKPCBG(), 0, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "[");
		Graphics.Blit(null, renderTexture, material, 0);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.FBEPIFQQIJO(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO)) ? 408f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 1);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(this.BEHMQBIFCOJ.CHODJCGKMOK() / 7, this.BEHMQBIFCOJ.KPFJEIKPCBG() / 4, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "!\r\n");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 5);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(this.BEHMQBIFCOJ.KJGMGPCEJJD / 1, this.BEHMQBIFCOJ.DFKQMMIQDOO / 3, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "cheekpouch");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(0 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 8);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			LQMHKMOOHDB.EnableKeyword("[-]!\r\n");
			this.BEHMQBIFCOJ.KNGHIQJHKOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("[fail]");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.ICJLJEKEIJL(renderTexture3);
	}

	// Token: 0x0600618F RID: 24975 RVA: 0x00026361 File Offset: 0x00024561
	public bool OCLNJQFCJOD()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x0031BB48 File Offset: 0x00319D48
	private float KOGGGCLKPNJ(int OKFPHFBQHBH)
	{
		float num = (float)base.FIFNHCKNDQE.settings.kernelSize * 4f + 6f;
		return Mathf.Min(0.05f, num / (float)OKFPHFBQHBH);
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x0002619A File Offset: 0x0002439A
	public void BFCGNMEJDPH()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x0031BB84 File Offset: 0x00319D84
	public void FJPDEBIGDDQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.settings;
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)(-25);
		RenderTextureFormat renderTextureFormat = this.EQQKQNHKDEL((RenderTextureFormat)30, (RenderTextureFormat)(-119));
		float num = this.CJQCEBFJFPQ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1945f * 858f);
		float num5 = this.DJFBCMOONJP(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QFIDLQIGGDL("Slots_8");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 797f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 967f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Icon_Status_Burn");
		Graphics.Blit(null, renderTexture, material, 0);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.FNINPGNGQNB(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JKGBHEHKBPC())) ? 1570f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JHHQQQGMQBM(), 1, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 0, this.BEHMQBIFCOJ.JHHQQQGMQBM() / 8, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "-endability");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 7);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(this.BEHMQBIFCOJ.CQNLNDBFFFP() / 3, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 4, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "JOFLHFQQCKG");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(7 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 3);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.NHJLBCFQCGD(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			LQMHKMOOHDB.EnableKeyword("-mega-x");
			this.BEHMQBIFCOJ.KNGHIQJHKOL();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("Head");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture3);
	}

	// Token: 0x06006193 RID: 24979 RVA: 0x0031BE94 File Offset: 0x0031A094
	public void DFLOLMMCGID(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.settings;
		RenderTextureFormat eibobkjigqb = RenderTextureFormat.DefaultHDR;
		RenderTextureFormat renderTextureFormat = this.EQQKQNHKDEL(RenderTextureFormat.R8, RenderTextureFormat.RHalf);
		float num = this.CGJDQLFFFQP();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 0.024f * 2f);
		float num5 = this.KOGGGCLKPNJ(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Depth Of Field");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(null, renderTexture, material, 0);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.NEGENGEIIHL(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO)) ? 0f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 1);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.KJGMGPCEJJD / 2, this.BEHMQBIFCOJ.DFKQMMIQDOO / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 2);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(this.BEHMQBIFCOJ.KJGMGPCEJJD / 2, this.BEHMQBIFCOJ.DFKQMMIQDOO / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(3 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			LQMHKMOOHDB.EnableKeyword("DEPTH_OF_FIELD_COC_VIEW");
			this.BEHMQBIFCOJ.OIONKMPKBKJ();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("DEPTH_OF_FIELD");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture3);
	}

	// Token: 0x06006194 RID: 24980 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode OOHIGFGPHEO()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006195 RID: 24981 RVA: 0x000261BC File Offset: 0x000243BC
	private bool JCIBIQKJQKP(int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		return this.JBLIMDOEPEL != null && this.JBLIMDOEPEL.IsCreated() && this.JBLIMDOEPEL.width == KJGMGPCEJJD && this.JBLIMDOEPEL.height == DFKQMMIQDOO;
	}

	// Token: 0x06006196 RID: 24982 RVA: 0x0031C1A4 File Offset: 0x0031A3A4
	private float FFMFLGPBOJE()
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.QKIEQHKDJEP();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1462f;
		}
		float num = this.BEHMQBIFCOJ.LNCKNGKGHLN.fieldOfView * 1365f;
		return 1896f / Mathf.Tan(280f * num);
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x0031C200 File Offset: 0x0031A400
	public void CDFCMCPICGC(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, bool BNNPLOIJCOH, Vector2 MCNCBFDPCIH, float IPLBLGNHMOM)
	{
		DepthOfFieldModel.Settings settings = base.FIFNHCKNDQE.QKIEQHKDJEP();
		RenderTextureFormat eibobkjigqb = (RenderTextureFormat)94;
		RenderTextureFormat renderTextureFormat = this.JEOLPKHQJGF((RenderTextureFormat)(-38), (RenderTextureFormat)(-50));
		float num = this.LPILCJQPLFD();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)PBHPQFLMQDB.width / (float)PBHPQFLMQDB.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 402f * 265f);
		float num5 = this.HFOOFLICCOQ(PBHPQFLMQDB.height);
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO("Achievement Points:");
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DGIQPDNECFK, num2);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.NJJQGQGHPNH, num4);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.FMOBJFDHCDF, num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.MJNGHMNDONJ, 1929f / num5);
		material.SetFloat(LFEMGHQGCKK.OQJNGIQJNJD.DCKGCGDNICK, 1254f / num3);
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.ONCCDMLHNQL(), 0, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "item: ");
		Graphics.Blit(null, renderTexture, material, 1);
		if (BNNPLOIJCOH)
		{
			material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
			float z = (!this.LLNJODJKDHJ(this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.DFKQMMIQDOO)) ? 1910f : IPLBLGNHMOM;
			material.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.JMBMDIQHMLK, new Vector3(MCNCBFDPCIH.x, MCNCBFDPCIH.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.KPFJEIKPCBG(), 0, renderTextureFormat);
			Graphics.Blit(this.JBLIMDOEPEL, temporary, material, 0);
			this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
			if (this.JBLIMDOEPEL != null)
			{
				RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
			}
			renderTexture = (this.JBLIMDOEPEL = temporary);
		}
		RenderTexture renderTexture2 = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(this.BEHMQBIFCOJ.KJGMGPCEJJD / 5, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 1, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Camera Window");
		material.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.HKOLMKNMFJK, renderTexture);
		Graphics.Blit(PBHPQFLMQDB, renderTexture2, material, 5);
		RenderTexture renderTexture3 = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(this.BEHMQBIFCOJ.KJGMGPCEJJD / 1, this.BEHMQBIFCOJ.ONCCDMLHNQL() / 0, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "skydrop");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(2 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		LQMHKMOOHDB.SetVector(LFEMGHQGCKK.OQJNGIQJNJD.FNEHOCCOGDJ, new Vector3(num2, num4, num5));
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.MOKDJMOKIKO(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			LQMHKMOOHDB.EnableKeyword("[/sup]");
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else
		{
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.JCNDIHPFOLF, renderTexture2);
			LQMHKMOOHDB.SetTexture(LFEMGHQGCKK.OQJNGIQJNJD.FPEOGMDPCEQ, renderTexture);
			LQMHKMOOHDB.EnableKeyword("/");
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture3);
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x0002619A File Offset: 0x0002439A
	public void OQOENCJJGBG()
	{
		if (this.JBLIMDOEPEL != null)
		{
			RenderTexture.ReleaseTemporary(this.JBLIMDOEPEL);
		}
		this.JBLIMDOEPEL = null;
	}

	// Token: 0x06006199 RID: 24985 RVA: 0x00026381 File Offset: 0x00024581
	private RenderTextureFormat JDKQFGBBHOC(RenderTextureFormat HEFGGOQPOQP, RenderTextureFormat OEKFKIBFNLN)
	{
		if (SystemInfo.SupportsRenderTextureFormat(HEFGGOQPOQP))
		{
			return HEFGGOQPOQP;
		}
		if (SystemInfo.SupportsRenderTextureFormat(OEKFKIBFNLN))
		{
			return OEKFKIBFNLN;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x040014CA RID: 5322
	private const string OEEBQBQIEPO = "Hidden/Post FX/Depth Of Field";

	// Token: 0x040014CB RID: 5323
	private RenderTexture JBLIMDOEPEL;

	// Token: 0x040014CC RID: 5324
	private const float PPMINFELDCI = 0.024f;

	// Token: 0x020002BC RID: 700
	private static class OQJNGIQJNJD
	{
		// Token: 0x040014CD RID: 5325
		internal static readonly int JCNDIHPFOLF = Shader.PropertyToID("_DepthOfFieldTex");

		// Token: 0x040014CE RID: 5326
		internal static readonly int FPEOGMDPCEQ = Shader.PropertyToID("_DepthOfFieldCoCTex");

		// Token: 0x040014CF RID: 5327
		internal static readonly int DGIQPDNECFK = Shader.PropertyToID("_Distance");

		// Token: 0x040014D0 RID: 5328
		internal static readonly int NJJQGQGHPNH = Shader.PropertyToID("_LensCoeff");

		// Token: 0x040014D1 RID: 5329
		internal static readonly int FMOBJFDHCDF = Shader.PropertyToID("_MaxCoC");

		// Token: 0x040014D2 RID: 5330
		internal static readonly int MJNGHMNDONJ = Shader.PropertyToID("_RcpMaxCoC");

		// Token: 0x040014D3 RID: 5331
		internal static readonly int DCKGCGDNICK = Shader.PropertyToID("_RcpAspect");

		// Token: 0x040014D4 RID: 5332
		internal static readonly int OKKONPEBLHN = Shader.PropertyToID("_MainTex");

		// Token: 0x040014D5 RID: 5333
		internal static readonly int HKOLMKNMFJK = Shader.PropertyToID("_CoCTex");

		// Token: 0x040014D6 RID: 5334
		internal static readonly int JMBMDIQHMLK = Shader.PropertyToID("_TaaParams");

		// Token: 0x040014D7 RID: 5335
		internal static readonly int FNEHOCCOGDJ = Shader.PropertyToID("_DepthOfFieldParams");
	}
}
