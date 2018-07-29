using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x020002C1 RID: 705
public sealed class KEIGFGDMQBF : NHOOQNHPFOB<FogModel>
{
	// Token: 0x0600623A RID: 25146 RVA: 0x00026700 File Offset: 0x00024900
	public bool MCBHGIQBQGN()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KNJIPLQJGKI() && RenderSettings.fog && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x00321920 File Offset: 0x0031FB20
	public void GOJBIGQGHQG(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.settings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("Fishing Cooldown");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != FogMode.Linear)
			{
				if (fogMode == (FogMode)7)
				{
					material.EnableKeyword("300");
				}
			}
			else
			{
				material.EnableKeyword("HidePanel");
			}
		}
		else
		{
			material.EnableKeyword("Zubat");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.EOLMLQPKBKP()) ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)96);
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JKGBHEHKBPC(), 94, FilterMode.Point, format);
		KLIOPLGOLQC.Blit((BuiltinRenderTextureType)6, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.PrepassLight, material, (!settings.excludeSkybox) ? 0 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode KLIGKPJHBOH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x00026734 File Offset: 0x00024934
	public string DDCMFLFDHJH()
	{
		return "Assets/AssetBundles/MapAssets/Models/Shop/Materials/c102_mado.mat";
	}

	// Token: 0x0600623E RID: 25150 RVA: 0x0002673B File Offset: 0x0002493B
	public CameraEvent EFLDLQDPGEQ()
	{
		return (CameraEvent)69;
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode NHCHPMOFCOD()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x0002673F File Offset: 0x0002493F
	public string CCECNCCIDOG()
	{
		return "Logging in..";
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x00026746 File Offset: 0x00024946
	public string BCONMQQBBGO()
	{
		return "_RcpMaxCoC";
	}

	// Token: 0x06006242 RID: 25154 RVA: 0x00321A6C File Offset: 0x0031FC6C
	public void KKFPIMMNJCE(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.HOKGONBDOFC("F3");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != FogMode.ExponentialSquared)
			{
				if (fogMode == (FogMode)5)
				{
					material.EnableKeyword(" EXP");
				}
			}
			else
			{
				material.EnableKeyword("ability");
			}
		}
		else
		{
			material.EnableKeyword("You have insufficient coins to play the Slot Machine.");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.CGKJPFHPGBN()) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)(-106));
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.JKGBHEHKBPC(), -37, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.ResolvedDepth, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.DepthNormals, material, (!settings.excludeSkybox) ? 1 : 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x0002674D File Offset: 0x0002494D
	public CameraEvent GFKFJBNBLPL()
	{
		return (CameraEvent)(-28);
	}

	// Token: 0x06006244 RID: 25156 RVA: 0x00026751 File Offset: 0x00024951
	public bool EPEEBMIMHDB()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.JPOFECLCIEO() && RenderSettings.fog && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x00026785 File Offset: 0x00024985
	public override CameraEvent KHFMCINEPGH()
	{
		return CameraEvent.AfterImageEffectsOpaque;
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x00026789 File Offset: 0x00024989
	public string PPEFBBPQDGO()
	{
		return "rest";
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x00026790 File Offset: 0x00024990
	public string JGPFMGBEHLQ()
	{
		return "Password";
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x0002679F File Offset: 0x0002499F
	public CameraEvent PJMFQJOHEII()
	{
		return (CameraEvent)(-15);
	}

	// Token: 0x0600624A RID: 25162 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode LHJCOCGCQHL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600624B RID: 25163 RVA: 0x00321BB8 File Offset: 0x0031FDB8
	public void HGPMPIPMCBQ(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO("301");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != (FogMode)6)
			{
				if (fogMode == (FogMode)8)
				{
					material.EnableKeyword("6_");
				}
			}
			else
			{
				material.EnableKeyword("Hidden/ProCamera2D/Letterbox");
			}
		}
		else
		{
			material.EnableKeyword(" took the attack!\r\n");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)(-56));
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 66, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit((BuiltinRenderTextureType)6, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.None, material, (!settings.excludeSkybox) ? 0 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode OCJHPJIOOHK()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x000267A3 File Offset: 0x000249A3
	public string MQDELBGDLPB()
	{
		return " is storing energy!\r\n";
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x000267AA File Offset: 0x000249AA
	public CameraEvent DMOFJGOFMMQ()
	{
		return (CameraEvent)(-52);
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode KFIMMEHOQIC()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x000267AE File Offset: 0x000249AE
	public string KOJFHGPCMPD()
	{
		return "switch";
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode OJCNGDLMBOQ()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x000267B5 File Offset: 0x000249B5
	public bool GJJIBBQDKNF()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.GMQFHQJCCDH() && RenderSettings.fog && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x000267E9 File Offset: 0x000249E9
	public string IOPJEDLJKJH()
	{
		return "/force up";
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06006254 RID: 25172 RVA: 0x000267F0 File Offset: 0x000249F0
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.GKHCOPLEQKQ && RenderSettings.fog && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x00026824 File Offset: 0x00024A24
	public CameraEvent DPQJPFNIMOK()
	{
		return (CameraEvent)(-4);
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x00026828 File Offset: 0x00024A28
	public bool IKNNJPFFMHL()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.NNOLMNBLJBP() || !RenderSettings.fog || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x0002685C File Offset: 0x00024A5C
	public CameraEvent CDPMLJCOKGK()
	{
		return (CameraEvent)74;
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x00026860 File Offset: 0x00024A60
	public bool DJPCKDGIIFE()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.GKHCOPLEQKQ && RenderSettings.fog && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x00026894 File Offset: 0x00024A94
	public CameraEvent OEBLHOHHBFG()
	{
		return (CameraEvent)124;
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x00026898 File Offset: 0x00024A98
	public bool IIBLPLDEEPB()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.MEPHDLOPGDJ() && RenderSettings.fog && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x000268CC File Offset: 0x00024ACC
	public CameraEvent BJPEBLBGPHK()
	{
		return (CameraEvent)105;
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x000268D0 File Offset: 0x00024AD0
	public string QGNFINQMNHP()
	{
		return "[/pok]";
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode IKIOJBCGLJO()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x00321D04 File Offset: 0x0031FF04
	public void EONGQMKCQQL(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DNDPKMIFFDJ();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Intelligence increases mana");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != (FogMode)0)
		{
			if (fogMode != FogMode.Linear)
			{
				if (fogMode == (FogMode)0)
				{
					material.EnableKeyword("torrent");
				}
			}
			else
			{
				material.EnableKeyword("/50 Friends");
			}
		}
		else
		{
			material.EnableKeyword("NPC");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)72);
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.DFKQMMIQDOO, -23, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.CameraTarget, material, (!settings.excludeSkybox) ? 1 : 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600625F RID: 25183 RVA: 0x000268D7 File Offset: 0x00024AD7
	public CameraEvent KEGDDPLLFQF()
	{
		return (CameraEvent)108;
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x000268DB File Offset: 0x00024ADB
	public CameraEvent LKBOMLCMFHI()
	{
		return (CameraEvent)(-6);
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x000268DF File Offset: 0x00024ADF
	public bool PDGHHOFHQDQ()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.DMHOKLNNOGB() && RenderSettings.fog && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x00321E50 File Offset: 0x00320050
	public void LLEFLIOFGMQ(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DCPMJDLDNMM();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("[-]!\r\n");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != (FogMode)0)
		{
			if (fogMode != FogMode.ExponentialSquared)
			{
				if (fogMode == (FogMode)5)
				{
					material.EnableKeyword("`");
				}
			}
			else
			{
				material.EnableKeyword("u");
			}
		}
		else
		{
			material.EnableKeyword("Battle");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)88);
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.DFKQMMIQDOO, 73, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.Depth, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.DepthNormals, material, (!settings.excludeSkybox) ? 1 : 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode JOIODIMOHON()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x00321F9C File Offset: 0x0032019C
	public void ILOCPGPOHQJ(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DNDPKMIFFDJ();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KDQCHHNMPQD("Expected to have 'target' set to a valid transform");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != (FogMode)8)
			{
				if (fogMode == FogMode.ExponentialSquared)
				{
					material.EnableKeyword("bind");
				}
			}
			else
			{
				material.EnableKeyword("Water");
			}
		}
		else
		{
			material.EnableKeyword(".");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.Default : ((RenderTextureFormat)(-76));
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), -10, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit((BuiltinRenderTextureType)6, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.None, material, (!settings.excludeSkybox) ? 0 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x003220E8 File Offset: 0x003202E8
	public void CGOJPJDDDON(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("Sound");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != (FogMode)8)
			{
				if (fogMode == FogMode.ExponentialSquared)
				{
					material.EnableKeyword("innerfocus");
				}
			}
			else
			{
				material.EnableKeyword("flying");
			}
		}
		else
		{
			material.EnableKeyword(")");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.Default : ((RenderTextureFormat)44);
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), -121, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.CameraTarget, material, (!settings.excludeSkybox) ? 0 : 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x00026913 File Offset: 0x00024B13
	public string BHILMCFBIKE()
	{
		return "\r\nATK";
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x0002691A File Offset: 0x00024B1A
	public bool JFJDGFQDLKG()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.QDMEBDDICQB() || !RenderSettings.fog || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode BOEHCEFLBMF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x00322234 File Offset: 0x00320434
	public void QMENPKLGQJB(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DNDPKMIFFDJ();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("'s ");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != (FogMode)6)
			{
				if (fogMode == (FogMode)6)
				{
					material.EnableKeyword("[/sub]");
				}
			}
			else
			{
				material.EnableKeyword("weakarmor");
			}
		}
		else
		{
			material.EnableKeyword("Effort Values[FFFF00] (");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.Default : ((RenderTextureFormat)36);
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.KPFJEIKPCBG(), 61, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.PrepassLight, material, (!settings.excludeSkybox) ? 1 : 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x0002694E File Offset: 0x00024B4E
	public CameraEvent MKKPGEBFHCO()
	{
		return (CameraEvent)33;
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x00026952 File Offset: 0x00024B52
	public bool EQQNCODCDFK()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KNJIPLQJGKI() && RenderSettings.fog && this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode OCCJOQJNMMD()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x00322380 File Offset: 0x00320580
	public override void EIQKCDHPCKK(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.settings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Fog");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != FogMode.Linear)
		{
			if (fogMode != FogMode.Exponential)
			{
				if (fogMode == FogMode.ExponentialSquared)
				{
					material.EnableKeyword("FOG_EXP2");
				}
			}
			else
			{
				material.EnableKeyword("FOG_EXP");
			}
		}
		else
		{
			material.EnableKeyword("FOG_LINEAR");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 24, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.CameraTarget, material, (!settings.excludeSkybox) ? 0 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600626E RID: 25198 RVA: 0x00026986 File Offset: 0x00024B86
	public bool GNCHKDJEHCJ()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.NNOLMNBLJBP() || !RenderSettings.fog || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x00026894 File Offset: 0x00024A94
	public CameraEvent PHKDLIEBFND()
	{
		return (CameraEvent)124;
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x000269BA File Offset: 0x00024BBA
	public string ODMPGPPNIKN()
	{
		return "The Pokémon is oblivious, and that keeps it from being infatuated or falling for taunts.";
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x000269C1 File Offset: 0x00024BC1
	public bool JKGMHKINEOC()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.MEPHDLOPGDJ() && RenderSettings.fog && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006272 RID: 25202 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode MGBLNNINHKI()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x00026828 File Offset: 0x00024A28
	public bool JMDOPJEOKBJ()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.NNOLMNBLJBP() || !RenderSettings.fog || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode NEOKIKBHMMJ()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x003224CC File Offset: 0x003206CC
	public void PIQOEOMBINC(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QPKJBEOCKMO("_Dissolve");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != (FogMode)0)
		{
			if (fogMode != (FogMode)6)
			{
				if (fogMode == FogMode.ExponentialSquared)
				{
					material.EnableKeyword("HH:mm:ss");
				}
			}
			else
			{
				material.EnableKeyword("Guild");
			}
		}
		else
		{
			material.EnableKeyword("Unlit/Transparent Colored");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.Default : RenderTextureFormat.RG32;
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.ONCCDMLHNQL(), -49, FilterMode.Point, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.PrepassLight, material, (!settings.excludeSkybox) ? 1 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode QFFKNJCJMFN()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x000269F5 File Offset: 0x00024BF5
	public string KNIGFKBFIOH()
	{
		return "PvP Losses:";
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x000269FC File Offset: 0x00024BFC
	public CameraEvent JIQJCJGMDKC()
	{
		return CameraEvent.AfterImageEffects;
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode OPQMQEJMBQH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600627A RID: 25210 RVA: 0x00026A00 File Offset: 0x00024C00
	public string IJENFBEDJQI()
	{
		return "[-]";
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x00026A07 File Offset: 0x00024C07
	public override string QPDGCILDFLP()
	{
		return "Fog";
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode QGJJGPGQFIH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode PCHMOJGLMQN()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x00026A0E File Offset: 0x00024C0E
	public CameraEvent LDPPPIKQQED()
	{
		return (CameraEvent)(-91);
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x00026A12 File Offset: 0x00024C12
	public string BOCJKMHKHGK()
	{
		return "_Texture2";
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x00026A19 File Offset: 0x00024C19
	public string NQHMCJNHPOM()
	{
		return "Level Ups:";
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x00026A20 File Offset: 0x00024C20
	public CameraEvent DGNGCJCLMJL()
	{
		return (CameraEvent)(-56);
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x0000B03A File Offset: 0x0000923A
	public DepthTextureMode CJFEQFLJOBL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode IGILFNHCPJE()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x00026A24 File Offset: 0x00024C24
	public string NOEEGLGJICD()
	{
		return "+";
	}

	// Token: 0x06006285 RID: 25221 RVA: 0x00026A2B File Offset: 0x00024C2B
	public string LPMBCCPMKOL()
	{
		return "HidePanel";
	}

	// Token: 0x06006286 RID: 25222 RVA: 0x00026A32 File Offset: 0x00024C32
	public CameraEvent LCGBFLFCCPE()
	{
		return (CameraEvent)(-68);
	}

	// Token: 0x06006287 RID: 25223 RVA: 0x0000B03A File Offset: 0x0000923A
	public override DepthTextureMode FDQNPDGFNHH()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06006288 RID: 25224 RVA: 0x00026A36 File Offset: 0x00024C36
	public string DDPMKPODBKK()
	{
		return "Hover: ";
	}

	// Token: 0x06006289 RID: 25225 RVA: 0x00322618 File Offset: 0x00320818
	public void HOEEFIJFCQC(CommandBuffer KLIOPLGOLQC)
	{
		FogModel.Settings settings = base.FIFNHCKNDQE.DNDPKMIFFDJ();
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.HFMKDHIIPNH(" is buffeted by the hail!\r\n");
		material.shaderKeywords = null;
		Color value = (!LGJGBKJCKPH.HDMIHMIGIKJ) ? RenderSettings.fogColor : RenderSettings.fogColor.linear;
		material.SetColor(KEIGFGDMQBF.JJJDFKHCQMK.CIBQFQNCKJP, value);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.NOFOKDDFMIE, RenderSettings.fogDensity);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.CIPNHIMHOOP, RenderSettings.fogStartDistance);
		material.SetFloat(KEIGFGDMQBF.JJJDFKHCQMK.JOJIMGCLLPH, RenderSettings.fogEndDistance);
		FogMode fogMode = RenderSettings.fogMode;
		if (fogMode != (FogMode)0)
		{
			if (fogMode != (FogMode)6)
			{
				if (fogMode == (FogMode)8)
				{
					material.EnableKeyword("waterpledge");
				}
			}
			else
			{
				material.EnableKeyword("Invite to Party");
			}
		}
		else
		{
			material.EnableKeyword("[b]");
		}
		RenderTextureFormat format = (!this.BEHMQBIFCOJ.BJQCGHDPFBB()) ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)(-4));
		KLIOPLGOLQC.GetTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), 41, FilterMode.Bilinear, format);
		KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
		KLIOPLGOLQC.Blit(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP, BuiltinRenderTextureType.PrepassLight, material, (!settings.excludeSkybox) ? 1 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(KEIGFGDMQBF.JJJDFKHCQMK.HJHQQCBOBPP);
	}

	// Token: 0x0600628A RID: 25226 RVA: 0x00026A3D File Offset: 0x00024C3D
	public string QHDICJOPOHQ()
	{
		return "4";
	}

	// Token: 0x0600628B RID: 25227 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public DepthTextureMode HEOJHFKPGDH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0600628C RID: 25228 RVA: 0x00026A44 File Offset: 0x00024C44
	public string JQJPIIMKIBM()
	{
		return "Super Repel";
	}

	// Token: 0x040014EE RID: 5358
	private const string OEEBQBQIEPO = "Hidden/Post FX/Fog";

	// Token: 0x020002C2 RID: 706
	private static class JJJDFKHCQMK
	{
		// Token: 0x040014EF RID: 5359
		internal static readonly int CIBQFQNCKJP = Shader.PropertyToID("_FogColor");

		// Token: 0x040014F0 RID: 5360
		internal static readonly int NOFOKDDFMIE = Shader.PropertyToID("_Density");

		// Token: 0x040014F1 RID: 5361
		internal static readonly int CIPNHIMHOOP = Shader.PropertyToID("_Start");

		// Token: 0x040014F2 RID: 5362
		internal static readonly int JOJIMGCLLPH = Shader.PropertyToID("_End");

		// Token: 0x040014F3 RID: 5363
		internal static readonly int HJHQQCBOBPP = Shader.PropertyToID("_TempRT");
	}
}
