using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002B7 RID: 695
public sealed class QHPGHOFCBQD : ONQQOCQBQIE<ChromaticAberrationModel>
{
	// Token: 0x060060B1 RID: 24753 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void QJPDLCLJDNL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060B2 RID: 24754 RVA: 0x00314314 File Offset: 0x00312514
	public bool CCNBLOMHMLE()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 694f && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060060B3 RID: 24755 RVA: 0x0031435C File Offset: 0x0031255C
	public void KJPPBJFHKMJ(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.HPEGEDJEFKF();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(5, 1, TextureFormat.Alpha8, false)
				{
					name = "Defeatist",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
				};
				Color[] array = new Color[5];
				array[0] = new Color(824f, 1108f, 908f);
				array[0] = new Color(51f, 569f, 916f);
				array[1] = new Color(605f, 1879f, 941f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("_FogAlpha");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 749f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060B4 RID: 24756 RVA: 0x00314488 File Offset: 0x00312688
	public void GECNLHMHNCN(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.CCIPOGGHFLN();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(8, 0, TextureFormat.Alpha8, true)
				{
					name = "p1",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 1,
					hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[4];
				array[0] = new Color(935f, 704f, 804f);
				array[0] = new Color(1373f, 188f, 1262f);
				array[1] = new Color(129f, 202f, 1888f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("[00EE07]");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1138f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060B5 RID: 24757 RVA: 0x003145B4 File Offset: 0x003127B4
	public bool MLIMGGOLOCO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.IHFJDFOBCEF().intensity > 300f && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060060B6 RID: 24758 RVA: 0x003145FC File Offset: 0x003127FC
	public void JQKGGNBEMJB(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.HHMGHNLGCQF();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(0, 0, TextureFormat.Alpha8, true)
				{
					name = "+",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = (HideFlags)(-123)
				};
				Color[] array = new Color[6];
				array[1] = new Color(1411f, 563f, 80f);
				array[0] = new Color(773f, 1120f, 768f);
				array[5] = new Color(682f, 152f, 177f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("Purchasing");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1347f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060B7 RID: 24759 RVA: 0x00314728 File Offset: 0x00312928
	public bool IODDLCIHECG()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KDKQOHONODB().intensity <= 1070f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060060B8 RID: 24760 RVA: 0x00314770 File Offset: 0x00312970
	public bool JQEBOPPCNJI()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.INPGLPEDINQ().intensity <= 1520f || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060060B9 RID: 24761 RVA: 0x003147B8 File Offset: 0x003129B8
	public void BMKLOFDIDFG(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.MPQQHEGCDGM();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(0, 0, TextureFormat.Alpha8, true)
				{
					name = "bug",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable)
				};
				Color[] array = new Color[0];
				array[0] = new Color(386f, 1111f, 1368f);
				array[0] = new Color(1688f, 445f, 1769f);
				array[2] = new Color(1926f, 1505f, 1981f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("\n\n");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1087f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x003148E4 File Offset: 0x00312AE4
	public void GKDNPNLHDEF(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.MPQQHEGCDGM();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(4, 0, (TextureFormat)6, false)
				{
					name = "psychic",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable)
				};
				Color[] array = new Color[8];
				array[0] = new Color(1059f, 1683f, 1041f);
				array[0] = new Color(121f, 742f, 13f);
				array[8] = new Color(97f, 1461f, 425f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("`");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 172f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x00314A10 File Offset: 0x00312C10
	public bool QGOCIIGQLFC()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DDCKCBDHLCL().intensity <= 943f || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public override void MEGLEJHOGQK()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x00314A58 File Offset: 0x00312C58
	public bool QEEKFFQJBMO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.CCIPOGGHFLN().intensity > 643f && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x00314AA0 File Offset: 0x00312CA0
	public void BEPLNIICNEH(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.HHMGHNLGCQF();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(7, 0, TextureFormat.Alpha8, false)
				{
					name = "\r\n",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 1,
					hideFlags = (HideFlags)113
				};
				Color[] array = new Color[1];
				array[1] = new Color(743f, 1811f, 1606f);
				array[0] = new Color(1653f, 111f, 837f);
				array[7] = new Color(401f, 281f, 1697f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("CombinersArgsColorSrc1");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1147f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x00314BCC File Offset: 0x00312DCC
	public bool EPEEBMIMHDB()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OLKBFBGKLKJ().intensity <= 1319f || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x00314C14 File Offset: 0x00312E14
	public bool QCGPINKLDIE()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.NJBODQFGHCL().intensity > 1334f && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x00314C5C File Offset: 0x00312E5C
	public bool DHHJCEFGDJN()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DKKHLCIPGKB().intensity <= 733f || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x00314CA4 File Offset: 0x00312EA4
	public bool NMGJQNBOKLD()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.INPGLPEDINQ().intensity > 1569f && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x00314CEC File Offset: 0x00312EEC
	public bool PDGHHOFHQDQ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OLKBFBGKLKJ().intensity > 692f && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x00314D34 File Offset: 0x00312F34
	public bool MCBHGIQBQGN()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.NJBODQFGHCL().intensity <= 374f || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x00314D7C File Offset: 0x00312F7C
	public bool GGBQICFGNGQ()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.NJBODQFGHCL().intensity <= 1288f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x00314DC4 File Offset: 0x00312FC4
	public void EPKBGOOFGIO(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.DDCKCBDHLCL();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(7, 1, TextureFormat.Alpha8, false)
				{
					name = "p1",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = (HideFlags)(-75)
				};
				Color[] array = new Color[3];
				array[0] = new Color(1919f, 853f, 663f);
				array[0] = new Color(1365f, 1676f, 304f);
				array[1] = new Color(575f, 1452f, 1837f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("-miss");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 346f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x00314EF0 File Offset: 0x003130F0
	public bool OKMIMNFJGOD()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.KFKFOIFFPEQ().intensity > 620f && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x00314F38 File Offset: 0x00313138
	public void FBQJNNDDKCK(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.NJBODQFGHCL();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(5, 0, TextureFormat.ARGB4444, true)
				{
					name = "_TileY",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[5];
				array[1] = new Color(1898f, 988f, 276f);
				array[1] = new Color(1688f, 252f, 1153f);
				array[1] = new Color(1213f, 1695f, 405f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("[FF8F00]");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1968f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x00315064 File Offset: 0x00313264
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.settings;
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(3, 1, TextureFormat.RGB24, false)
				{
					name = "Chromatic Aberration Spectrum Lookup",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = HideFlags.DontSave
				};
				Color[] pixels = new Color[]
				{
					new Color(1f, 0f, 0f),
					new Color(0f, 1f, 0f),
					new Color(0f, 0f, 1f)
				};
				this.EGMCHBMDJGJ.SetPixels(pixels);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("CHROMATIC_ABERRATION");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 0.03f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void DBNCHQFFEOG()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x00315190 File Offset: 0x00313390
	public void BHEMFGFHNFH(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.MJHNFDDCGHL();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(0, 1, TextureFormat.RGBA32, true)
				{
					name = "[Shiny]",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 0,
					hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[0];
				array[0] = new Color(556f, 647f, 1429f);
				array[1] = new Color(323f, 429f, 971f);
				array[6] = new Color(197f, 1201f, 1264f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("ragepowder");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 55f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x003152BC File Offset: 0x003134BC
	public bool PEDKKOKCBOB()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.EFKIKEPOEGP().intensity > 607f && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060060CE RID: 24782 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void NMOGBLDCHBH()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x00315304 File Offset: 0x00313504
	public bool HLNQKONHMND()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.ICEIQHLLNEL().intensity <= 1785f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x0031534C File Offset: 0x0031354C
	public void HKCEBPEMIEF(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.HPEGEDJEFKF();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(8, 1, TextureFormat.ARGB32, false)
				{
					name = "The two moves have become one! It's a combined move!\r\n",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 1,
					hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[5];
				array[1] = new Color(956f, 1712f, 305f);
				array[1] = new Color(585f, 798f, 1114f);
				array[0] = new Color(1572f, 1554f, 458f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword("_");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 814f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x00315478 File Offset: 0x00313678
	public bool INCHDBOKENQ()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OLKBFBGKLKJ().intensity <= 1394f || !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060060D2 RID: 24786 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void CCIIKDGCEIL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void LBJMPMHKMEL()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x060060D4 RID: 24788 RVA: 0x003154C0 File Offset: 0x003136C0
	public bool DPEGBIKCKMJ()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.IHFJDFOBCEF().intensity <= 1364f || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x060060D5 RID: 24789 RVA: 0x00315508 File Offset: 0x00313708
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 0f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x060060D6 RID: 24790 RVA: 0x00315550 File Offset: 0x00313750
	public void NMPJNHIPNND(Material LQMHKMOOHDB)
	{
		ChromaticAberrationModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.EGMCHBMDJGJ == null)
			{
				this.EGMCHBMDJGJ = new Texture2D(6, 1, TextureFormat.RGB24, true)
				{
					name = "Fluffy",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[3];
				array[1] = new Color(326f, 1288f, 32f);
				array[1] = new Color(696f, 1495f, 1036f);
				array[3] = new Color(560f, 1413f, 448f);
				this.EGMCHBMDJGJ.SetPixels(array);
				this.EGMCHBMDJGJ.Apply();
			}
			texture2D = this.EGMCHBMDJGJ;
		}
		LQMHKMOOHDB.EnableKeyword(" ");
		LQMHKMOOHDB.SetFloat(QHPGHOFCBQD.HOGMEQILCBB.MPKLKNPELDI, settings.intensity * 1783f);
		LQMHKMOOHDB.SetTexture(QHPGHOFCBQD.HOGMEQILCBB.FILNFGNMDEQ, texture2D);
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x00025CC1 File Offset: 0x00023EC1
	public void PDIDEHKDELQ()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.EGMCHBMDJGJ);
		this.EGMCHBMDJGJ = null;
	}

	// Token: 0x040014AE RID: 5294
	private Texture2D EGMCHBMDJGJ;

	// Token: 0x020002B8 RID: 696
	private static class HOGMEQILCBB
	{
		// Token: 0x040014AF RID: 5295
		internal static readonly int MPKLKNPELDI = Shader.PropertyToID("_ChromaticAberration_Amount");

		// Token: 0x040014B0 RID: 5296
		internal static readonly int FILNFGNMDEQ = Shader.PropertyToID("_ChromaticAberration_Spectrum");
	}
}
