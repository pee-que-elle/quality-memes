using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x020002AE RID: 686
public sealed class FCJPPQICFGF : NHOOQNHPFOB<AmbientOcclusionModel>
{
	// Token: 0x06005FD5 RID: 24533 RVA: 0x00309E04 File Offset: 0x00308004
	private FCJPPQICFGF.NNFLPMNCDLF CNEJFGBOQQP()
	{
		if (this.BEHMQBIFCOJ.JPOFECLCIEO() && !base.FIFNHCKNDQE.KNBMBCNPNLF().forceForwardCompatibility)
		{
			return (FCJPPQICFGF.NNFLPMNCDLF)3;
		}
		if (base.FIFNHCKNDQE.NQOJGDFCPHG().highPrecision && (!this.BEHMQBIFCOJ.JPOFECLCIEO() || base.FIFNHCKNDQE.DDCKCBDHLCL().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x00025995 File Offset: 0x00023B95
	public string IEFOGCKINIK()
	{
		return "aegislash";
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x00309E70 File Offset: 0x00308070
	private bool FGCIKKDPLEL()
	{
		return this.BEHMQBIFCOJ.EOLMLQPKBKP() && base.FIFNHCKNDQE.KDKQOHONODB().ambientOnly && this.BEHMQBIFCOJ.KNJIPLQJGKI() && !base.FIFNHCKNDQE.KNBMBCNPNLF().forceForwardCompatibility;
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x00309EC8 File Offset: 0x003080C8
	public DepthTextureMode NPHDIEPEJQL()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.CNEJFGBOQQP() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.CNEJFGBOQQP() != FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x00309EF4 File Offset: 0x003080F4
	private FCJPPQICFGF.NNFLPMNCDLF KEJDOHKDICC()
	{
		if (this.BEHMQBIFCOJ.MEPHDLOPGDJ() && !base.FIFNHCKNDQE.KDKQOHONODB().forceForwardCompatibility)
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
		if (base.FIFNHCKNDQE.OILMJDEQKHM().highPrecision && (!this.BEHMQBIFCOJ.MEPHDLOPGDJ() || base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x0002599C File Offset: 0x00023B9C
	public string JENDDHFNPFL()
	{
		return "p2";
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x00309F60 File Offset: 0x00308160
	public DepthTextureMode GDPLKLHCGNJ()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.GGILFBBEPKN() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.CQLMOHOGNEC() != (FCJPPQICFGF.NNFLPMNCDLF)4)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x00309F8C File Offset: 0x0030818C
	public DepthTextureMode DPHMENEHPPQ()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.GGILFBBEPKN() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.IHQCHCCBEOQ() != (FCJPPQICFGF.NNFLPMNCDLF)7)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		return depthTextureMode;
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x00309FB8 File Offset: 0x003081B8
	public bool IODDLCIHECG()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OKEDNECPIQK().intensity <= 1965f || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x0030A000 File Offset: 0x00308200
	public DepthTextureMode CDOLEKJNGQO()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.CNEJFGBOQQP() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.CNEJFGBOQQP() != FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06005FDF RID: 24543 RVA: 0x0030A02C File Offset: 0x0030822C
	public void EDGHIHODLBC(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("DirX");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB(".");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1481f : 1653f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.GMQFHQJCCDH() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != (FogMode)0)
			{
				if (fogMode != (FogMode)5)
				{
					if (fogMode == (FogMode)0)
					{
						material.EnableKeyword("OnDragStart");
					}
				}
				else
				{
					material.EnableKeyword("-useMouse");
				}
			}
			else
			{
				material.EnableKeyword("_FogData");
			}
		}
		else
		{
			material.EnableKeyword("Main Quests");
		}
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD;
		int num = this.BEHMQBIFCOJ.KPFJEIKPCBG();
		int num2 = (!settings.downsampling) ? 1 : 2;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd / num2, num / num2, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.IHQCHCCBEOQ());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, kjgmgpcejjd, num, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.QBHDEGKIQOL != (FCJPPQICFGF.NNFLPMNCDLF)6) ? 4 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd, num, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 4);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.DIEGCPFPNLD(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CurrentActive, material, 2);
			this.BEHMQBIFCOJ.MLMBQMFLHOL();
		}
		else if (this.GDCOHEOCFFP())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.None);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 5);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)97);
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.KPFJEIKPCBG(), 0, FilterMode.Point, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.Depth, hjhqqcbobpp, mat, 0);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.PrepassNormalsSpec, material, 8);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x0030A34C File Offset: 0x0030854C
	private bool GDCOHEOCFFP()
	{
		return this.BEHMQBIFCOJ.NJKQFCKNNLM() && base.FIFNHCKNDQE.DDCKCBDHLCL().ambientOnly && this.BEHMQBIFCOJ.KNJIPLQJGKI() && base.FIFNHCKNDQE.NQOJGDFCPHG().forceForwardCompatibility;
	}

	// Token: 0x06005FE1 RID: 24545 RVA: 0x0030A3A4 File Offset: 0x003085A4
	public bool FMBQKNIDJGE()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 647f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x0030A3EC File Offset: 0x003085EC
	public void MLFPNPIBEQJ(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("_PrefilterOffs");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NONHJLIJQIP("The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 385f : 1758f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.KNJIPLQJGKI() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != (FogMode)0)
			{
				if (fogMode != (FogMode)5)
				{
					if (fogMode == (FogMode)7)
					{
						material.EnableKeyword("_FogColor");
					}
				}
				else
				{
					material.EnableKeyword("´");
				}
			}
			else
			{
				material.EnableKeyword("/00_1");
			}
		}
		else
		{
			material.EnableKeyword("Fog Volume entered by ");
		}
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD;
		int dfkqmmiqdoo = this.BEHMQBIFCOJ.DFKQMMIQDOO;
		int num = (!settings.downsampling) ? 0 : 1;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd / num, dfkqmmiqdoo / num, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.GMNQLHCQIHI());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, kjgmgpcejjd, dfkqmmiqdoo, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.KEJDOHKDICC() != (FCJPPQICFGF.NNFLPMNCDLF)5) ? 6 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd, dfkqmmiqdoo, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 7);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.MOKDJMOKIKO(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CurrentActive, material, 1);
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else if (this.CPBDIEFKDHP())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.ResolvedDepth);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 3);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGInt;
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), 1, FilterMode.Point, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.None, hjhqqcbobpp, mat, 0);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.Depth, material, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FE3 RID: 24547 RVA: 0x000259A3 File Offset: 0x00023BA3
	public string QDPBJPBJBHK()
	{
		return "[-]'s team won the battle!\r\n";
	}

	// Token: 0x06005FE4 RID: 24548 RVA: 0x0030A70C File Offset: 0x0030890C
	public void CFJDMEPCHBJ(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.EQLDMPKOGEL();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.FJIJQOQKHGK("Temporarily Suspended");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.HFMKDHIIPNH("_Male");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1590f : 998f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.QDMEBDDICQB() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != (FogMode)0)
			{
				if (fogMode != (FogMode)4)
				{
					if (fogMode == (FogMode)5)
					{
						material.EnableKeyword("'.");
					}
				}
				else
				{
					material.EnableKeyword("_ReflectionTex");
				}
			}
			else
			{
				material.EnableKeyword("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.");
			}
		}
		else
		{
			material.EnableKeyword("Assets/AssetBundles/MapAssets2/Models/Materials/c102_09_mado.mat");
		}
		int num = this.BEHMQBIFCOJ.CHODJCGKMOK();
		int num2 = this.BEHMQBIFCOJ.KPFJEIKPCBG();
		int num3 = (!settings.downsampling) ? 0 : 7;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.CQLMOHOGNEC());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.DNFMOJMHLCE() != (FCJPPQICFGF.NNFLPMNCDLF)8) ? 7 : 2);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 3);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.KKQGGHQDMCP(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.ResolvedDepth, material, 3);
			this.BEHMQBIFCOJ.KNGHIQJHKOL();
		}
		else if (this.GMCGDCPGPPQ())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.DepthNormals);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 1, 2);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.EOLMLQPKBKP()) ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGBFloat;
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JKGBHEHKBPC(), 1, FilterMode.Bilinear, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.DepthNormals, hjhqqcbobpp, mat, 0);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, (BuiltinRenderTextureType)6, material, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FE5 RID: 24549 RVA: 0x0030AA2C File Offset: 0x00308C2C
	public override DepthTextureMode FDQNPDGFNHH()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.QBHDEGKIQOL == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.QBHDEGKIQOL != FCJPPQICFGF.NNFLPMNCDLF.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.DepthNormals;
		}
		return depthTextureMode;
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x0030AA58 File Offset: 0x00308C58
	public bool QCGPINKLDIE()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DDCKCBDHLCL().intensity <= 1165f || !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x000259AA File Offset: 0x00023BAA
	public CameraEvent DMOFJGOFMMQ()
	{
		return (!this.ELOCHMBELGO() || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.GFIEDKOICPD(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane)) ? CameraEvent.BeforeDepthTexture : CameraEvent.AfterGBuffer;
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x000259D2 File Offset: 0x00023BD2
	public CameraEvent QMKCPFFPCIC()
	{
		return (!this.FGCIKKDPLEL() || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OMBJCCDPMQM(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut)) ? ((CameraEvent)(-19)) : CameraEvent.BeforeImageEffects;
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x0030AAA0 File Offset: 0x00308CA0
	public bool QHHLOHGFFBP()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.NQOJGDFCPHG().intensity > 1243f && !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06005FEA RID: 24554 RVA: 0x0030AAE8 File Offset: 0x00308CE8
	public bool KJNQOOQQDDO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.EQLDMPKOGEL().intensity > 65f && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06005FEB RID: 24555 RVA: 0x0030AB30 File Offset: 0x00308D30
	private bool MODQLPLJKJK()
	{
		return !this.BEHMQBIFCOJ.GGDPOOCLQGP() || !base.FIFNHCKNDQE.EQLDMPKOGEL().ambientOnly || !this.BEHMQBIFCOJ.GMQFHQJCCDH() || !base.FIFNHCKNDQE.CCIPOGGHFLN().forceForwardCompatibility;
	}

	// Token: 0x06005FEC RID: 24556 RVA: 0x0030AB88 File Offset: 0x00308D88
	private FCJPPQICFGF.NNFLPMNCDLF DNFMOJMHLCE()
	{
		if (this.BEHMQBIFCOJ.GMQFHQJCCDH() && !base.FIFNHCKNDQE.KNBMBCNPNLF().forceForwardCompatibility)
		{
			return (FCJPPQICFGF.NNFLPMNCDLF)8;
		}
		if (base.FIFNHCKNDQE.DCBJMHJEFMG().highPrecision && (!this.BEHMQBIFCOJ.QDMEBDDICQB() || base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x06005FED RID: 24557 RVA: 0x0030ABF4 File Offset: 0x00308DF4
	private bool GDNGBIBFKME()
	{
		return this.BEHMQBIFCOJ.NJKQFCKNNLM() && base.FIFNHCKNDQE.DDCKCBDHLCL().ambientOnly && this.BEHMQBIFCOJ.GNEOKCIFKBP() && base.FIFNHCKNDQE.settings.forceForwardCompatibility;
	}

	// Token: 0x06005FEE RID: 24558 RVA: 0x0030AC4C File Offset: 0x00308E4C
	private FCJPPQICFGF.NNFLPMNCDLF IHQCHCCBEOQ()
	{
		if (this.BEHMQBIFCOJ.DMHOKLNNOGB() && !base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility)
		{
			return (FCJPPQICFGF.NNFLPMNCDLF)8;
		}
		if (base.FIFNHCKNDQE.DDCKCBDHLCL().highPrecision && (!this.BEHMQBIFCOJ.MEPHDLOPGDJ() || base.FIFNHCKNDQE.DCBJMHJEFMG().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x0030ACB8 File Offset: 0x00308EB8
	private FCJPPQICFGF.NNFLPMNCDLF CQLMOHOGNEC()
	{
		if (this.BEHMQBIFCOJ.QDMEBDDICQB() && !base.FIFNHCKNDQE.KNBMBCNPNLF().forceForwardCompatibility)
		{
			return FCJPPQICFGF.NNFLPMNCDLF.GBuffer;
		}
		if (base.FIFNHCKNDQE.settings.highPrecision && (!this.BEHMQBIFCOJ.JPOFECLCIEO() || base.FIFNHCKNDQE.OKEDNECPIQK().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x0030AD24 File Offset: 0x00308F24
	private bool GMCGDCPGPPQ()
	{
		return this.BEHMQBIFCOJ.JCHDOOOJKIC && base.FIFNHCKNDQE.KNBMBCNPNLF().ambientOnly && this.BEHMQBIFCOJ.JPOFECLCIEO() && base.FIFNHCKNDQE.OILMJDEQKHM().forceForwardCompatibility;
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x00025A33 File Offset: 0x00023C33
	public string CBKKNMMKMCQ()
	{
		return "General";
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x0030AD7C File Offset: 0x00308F7C
	public void LBEFCMIFJOQ(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.HOKGONBDOFC("Are you sure you wish to buy ");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC(" is tormented!\r\n");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1002f : 815f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.NNOLMNBLJBP() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != FogMode.Linear)
			{
				if (fogMode != (FogMode)7)
				{
					if (fogMode == (FogMode)7)
					{
						material.EnableKeyword("HidePanel");
					}
				}
				else
				{
					material.EnableKeyword("When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.");
				}
			}
			else
			{
				material.EnableKeyword("Icon_Achievement_Incomplete");
			}
		}
		else
		{
			material.EnableKeyword("Rainbow Badge");
		}
		int num = this.BEHMQBIFCOJ.CQNLNDBFFFP();
		int num2 = this.BEHMQBIFCOJ.KPFJEIKPCBG();
		int num3 = (!settings.downsampling) ? 1 : 6;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.DNFMOJMHLCE());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, num, num2, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.CQLMOHOGNEC() != (FCJPPQICFGF.NNFLPMNCDLF)3) ? 2 : 5);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 6);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.JMMJGNMOPLE(BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.None, material, 2);
			this.BEHMQBIFCOJ.OIONKMPKBKJ();
		}
		else if (this.MODQLPLJKJK())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.PrepassNormalsSpec);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 0);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.NJKQFCKNNLM()) ? RenderTextureFormat.Default : ((RenderTextureFormat)84);
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.ONCCDMLHNQL(), 0, FilterMode.Bilinear, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.DepthNormals, hjhqqcbobpp, mat, 1);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.Depth, material, 3);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x0030B09C File Offset: 0x0030929C
	private FCJPPQICFGF.NNFLPMNCDLF GMNQLHCQIHI()
	{
		if (this.BEHMQBIFCOJ.GMQFHQJCCDH() && !base.FIFNHCKNDQE.DDCKCBDHLCL().forceForwardCompatibility)
		{
			return FCJPPQICFGF.NNFLPMNCDLF.GBuffer;
		}
		if (base.FIFNHCKNDQE.DDCKCBDHLCL().highPrecision && (!this.BEHMQBIFCOJ.MEPHDLOPGDJ() || base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
	}

	// Token: 0x06005FF5 RID: 24565 RVA: 0x0030B108 File Offset: 0x00309308
	private bool QEBCNPPQIJI()
	{
		return !this.BEHMQBIFCOJ.JCHDOOOJKIC || !base.FIFNHCKNDQE.OILMJDEQKHM().ambientOnly || !this.BEHMQBIFCOJ.GMQFHQJCCDH() || base.FIFNHCKNDQE.settings.forceForwardCompatibility;
	}

	// Token: 0x06005FF6 RID: 24566 RVA: 0x00025A3A File Offset: 0x00023C3A
	public override CameraEvent KHFMCINEPGH()
	{
		return (!this.CFONNCHJCMB || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion)) ? CameraEvent.BeforeImageEffectsOpaque : CameraEvent.BeforeReflections;
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x0030B160 File Offset: 0x00309360
	private bool CFONNCHJCMB
	{
		get
		{
			return this.BEHMQBIFCOJ.JCHDOOOJKIC && base.FIFNHCKNDQE.settings.ambientOnly && this.BEHMQBIFCOJ.GKHCOPLEQKQ && !base.FIFNHCKNDQE.settings.forceForwardCompatibility;
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x0030B1B8 File Offset: 0x003093B8
	private FCJPPQICFGF.NNFLPMNCDLF QBHDEGKIQOL
	{
		get
		{
			if (this.BEHMQBIFCOJ.GKHCOPLEQKQ && !base.FIFNHCKNDQE.settings.forceForwardCompatibility)
			{
				return FCJPPQICFGF.NNFLPMNCDLF.GBuffer;
			}
			if (base.FIFNHCKNDQE.settings.highPrecision && (!this.BEHMQBIFCOJ.GKHCOPLEQKQ || base.FIFNHCKNDQE.settings.forceForwardCompatibility))
			{
				return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
			}
			return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
		}
	}

	// Token: 0x06005FF9 RID: 24569 RVA: 0x00025A62 File Offset: 0x00023C62
	public string JQJPIIMKIBM()
	{
		return "PokeboxCollider";
	}

	// Token: 0x06005FFA RID: 24570 RVA: 0x0030B224 File Offset: 0x00309424
	public bool MNDQGOOMMQE()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KNBMBCNPNLF().intensity <= 1534f || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06005FFB RID: 24571 RVA: 0x0030B26C File Offset: 0x0030946C
	public void ECDQLIHQKMQ(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.FMKCQGMJHME();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.KGNOHIQHHFK("[-]!\r\n");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("_TileX");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 126f : 616f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.GMQFHQJCCDH() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != FogMode.Linear)
			{
				if (fogMode != (FogMode)7)
				{
					if (fogMode == FogMode.Linear)
					{
						material.EnableKeyword("Battle Update: ");
					}
				}
				else
				{
					material.EnableKeyword("Down");
				}
			}
			else
			{
				material.EnableKeyword("HidePanel");
			}
		}
		else
		{
			material.EnableKeyword("-mustrecharge");
		}
		int num = this.BEHMQBIFCOJ.CQNLNDBFFFP();
		int num2 = this.BEHMQBIFCOJ.KPFJEIKPCBG();
		int num3 = (!settings.downsampling) ? 1 : 7;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.OKINPCLIIHI());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.KEJDOHKDICC() != (FCJPPQICFGF.NNFLPMNCDLF)8) ? 5 : 8);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 4);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OMBJCCDPMQM(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.PrepassLight, material, 6);
			this.BEHMQBIFCOJ.MLMBQMFLHOL();
		}
		else if (this.GMCGDCPGPPQ())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.CameraTarget);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 1, 3);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-53));
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.KPFJEIKPCBG(), 1, FilterMode.Point, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, hjhqqcbobpp, mat, 0);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.PrepassNormalsSpec, material, 0);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FFC RID: 24572 RVA: 0x0030B58C File Offset: 0x0030978C
	public void ELPQEGLDHKB(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.FMKCQGMJHME();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.FJIJQOQKHGK(" harshly");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QMJKDCINICP("par");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1428f : 1230f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.NNOLMNBLJBP() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != FogMode.Linear)
			{
				if (fogMode != (FogMode)6)
				{
					if (fogMode == (FogMode)8)
					{
						material.EnableKeyword(")");
					}
				}
				else
				{
					material.EnableKeyword("English");
				}
			}
			else
			{
				material.EnableKeyword("voltabsorb");
			}
		}
		else
		{
			material.EnableKeyword("[/itm]");
		}
		int num = this.BEHMQBIFCOJ.CQNLNDBFFFP();
		int num2 = this.BEHMQBIFCOJ.ONCCDMLHNQL();
		int num3 = (!settings.downsampling) ? 0 : 8;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.IHQCHCCBEOQ());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.KEJDOHKDICC() != FCJPPQICFGF.NNFLPMNCDLF.DepthTexture) ? 6 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 0);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.GFIEDKOICPD(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.PrepassNormalsSpec, material, 0);
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else if (this.MODQLPLJKJK())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.None);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 6);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.Shadowmap : ((RenderTextureFormat)74);
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Point, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, hjhqqcbobpp, mat, 1);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, (BuiltinRenderTextureType)6, material, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06005FFD RID: 24573 RVA: 0x0030B8AC File Offset: 0x00309AAC
	public DepthTextureMode FNMDEDNBEOL()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.GMNQLHCQIHI() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.CNEJFGBOQQP() != (FCJPPQICFGF.NNFLPMNCDLF)4)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06005FFE RID: 24574 RVA: 0x0030B8D8 File Offset: 0x00309AD8
	public DepthTextureMode GDOMBCQIJMB()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.GGILFBBEPKN() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.OKINPCLIIHI() != FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture)
		{
			depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06005FFF RID: 24575 RVA: 0x0030B904 File Offset: 0x00309B04
	private FCJPPQICFGF.NNFLPMNCDLF GGILFBBEPKN()
	{
		if (this.BEHMQBIFCOJ.DMHOKLNNOGB() && !base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility)
		{
			return (FCJPPQICFGF.NNFLPMNCDLF)5;
		}
		if (base.FIFNHCKNDQE.OKEDNECPIQK().highPrecision && (!this.BEHMQBIFCOJ.DMHOKLNNOGB() || base.FIFNHCKNDQE.CCIPOGGHFLN().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x06006000 RID: 24576 RVA: 0x00025A69 File Offset: 0x00023C69
	public string LLBFOGIGIIJ()
	{
		return "upkeep";
	}

	// Token: 0x06006001 RID: 24577 RVA: 0x0030B970 File Offset: 0x00309B70
	public bool OKMIMNFJGOD()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KNBMBCNPNLF().intensity <= 978f || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006002 RID: 24578 RVA: 0x0030B9B8 File Offset: 0x00309BB8
	private bool CPBDIEFKDHP()
	{
		return this.BEHMQBIFCOJ.NJKQFCKNNLM() && base.FIFNHCKNDQE.DCBJMHJEFMG().ambientOnly && this.BEHMQBIFCOJ.QDMEBDDICQB() && !base.FIFNHCKNDQE.CCIPOGGHFLN().forceForwardCompatibility;
	}

	// Token: 0x06006003 RID: 24579 RVA: 0x00025A70 File Offset: 0x00023C70
	public CameraEvent IDOQKNFGGOD()
	{
		return (!this.MODQLPLJKJK() || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.LOOOKFHINLO(BuiltinDebugViewsModel.HMFGKHHHIPL.Depth)) ? ((CameraEvent)74) : ((CameraEvent)(-121));
	}

	// Token: 0x06006004 RID: 24580 RVA: 0x0030BA10 File Offset: 0x00309C10
	private FCJPPQICFGF.NNFLPMNCDLF OKINPCLIIHI()
	{
		if (this.BEHMQBIFCOJ.MEPHDLOPGDJ() && !base.FIFNHCKNDQE.NQOJGDFCPHG().forceForwardCompatibility)
		{
			return (FCJPPQICFGF.NNFLPMNCDLF)4;
		}
		if (base.FIFNHCKNDQE.KDKQOHONODB().highPrecision && (!this.BEHMQBIFCOJ.JPOFECLCIEO() || base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility))
		{
			return FCJPPQICFGF.NNFLPMNCDLF.DepthTexture;
		}
		return FCJPPQICFGF.NNFLPMNCDLF.DepthNormalsTexture;
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x06006005 RID: 24581 RVA: 0x0030BA7C File Offset: 0x00309C7C
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.intensity > 0f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x06006006 RID: 24582 RVA: 0x00025A98 File Offset: 0x00023C98
	public string FEDNLGEGDNL()
	{
		return "Powers up Water-type moves when the Pokémon's HP is low.";
	}

	// Token: 0x06006007 RID: 24583 RVA: 0x0030BAC4 File Offset: 0x00309CC4
	public DepthTextureMode ODNMEDODPNK()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.CQLMOHOGNEC() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.DNFMOJMHLCE() != FCJPPQICFGF.NNFLPMNCDLF.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		return depthTextureMode;
	}

	// Token: 0x06006008 RID: 24584 RVA: 0x00025A9F File Offset: 0x00023C9F
	public CameraEvent DNFECDMIJJJ()
	{
		return (!this.GMCGDCPGPPQ() || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion)) ? ((CameraEvent)(-8)) : ((CameraEvent)85);
	}

	// Token: 0x06006009 RID: 24585 RVA: 0x0030BAF0 File Offset: 0x00309CF0
	private bool ELOCHMBELGO()
	{
		return !this.BEHMQBIFCOJ.EOLMLQPKBKP() || !base.FIFNHCKNDQE.KDKQOHONODB().ambientOnly || !this.BEHMQBIFCOJ.GMQFHQJCCDH() || base.FIFNHCKNDQE.CCIPOGGHFLN().forceForwardCompatibility;
	}

	// Token: 0x0600600A RID: 24586 RVA: 0x00025AC7 File Offset: 0x00023CC7
	public string CHMKDNLKLDQ()
	{
		return " has been afflicted with an infestation by ";
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x00025ACE File Offset: 0x00023CCE
	public string PBHMLIIECOJ()
	{
		return "]";
	}

	// Token: 0x0600600C RID: 24588 RVA: 0x00025AD5 File Offset: 0x00023CD5
	public override string QPDGCILDFLP()
	{
		return "Ambient Occlusion";
	}

	// Token: 0x0600600D RID: 24589 RVA: 0x0030BB48 File Offset: 0x00309D48
	public void PGOMNJPKQKO(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.DDCKCBDHLCL();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.QDMHMMGFIOJ("Reduces the HP of sleeping opposing Pokémon.");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KDQCHHNMPQD("   ");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 432f : 1455f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.NNOLMNBLJBP() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != FogMode.Linear)
			{
				if (fogMode != (FogMode)5)
				{
					if (fogMode == FogMode.Exponential)
					{
						material.EnableKeyword("0");
					}
				}
				else
				{
					material.EnableKeyword(" already has a burn.\r\n");
				}
			}
			else
			{
				material.EnableKeyword("Chat Input");
			}
		}
		else
		{
			material.EnableKeyword("w");
		}
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD;
		int dfkqmmiqdoo = this.BEHMQBIFCOJ.DFKQMMIQDOO;
		int num = (!settings.downsampling) ? 1 : 7;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd / num, dfkqmmiqdoo / num, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.CQLMOHOGNEC());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, kjgmgpcejjd, dfkqmmiqdoo, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.GMNQLHCQIHI() != (FCJPPQICFGF.NNFLPMNCDLF)3) ? 4 : 6);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd, dfkqmmiqdoo, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 5);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.LOOOKFHINLO(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.None, material, 1);
			this.BEHMQBIFCOJ.MLMBQMFLHOL();
		}
		else if (this.QEBCNPPQIJI())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.Depth);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 5);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.EOLMLQPKBKP()) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)60);
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CQNLNDBFFFP(), this.BEHMQBIFCOJ.JHHQQQGMQBM(), 1, FilterMode.Bilinear, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, hjhqqcbobpp, mat, 1);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, (BuiltinRenderTextureType)6, material, 2);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x0030BE68 File Offset: 0x0030A068
	public void HODGQNBMPBC(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.DCBJMHJEFMG();
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.HFMKDHIIPNH("wideguard");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("[PG]");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1325f : 1853f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.KNJIPLQJGKI() && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			FogMode fogMode = RenderSettings.fogMode;
			if (fogMode != (FogMode)0)
			{
				if (fogMode != FogMode.ExponentialSquared)
				{
					if (fogMode == FogMode.ExponentialSquared)
					{
						material.EnableKeyword("castformsunny");
					}
				}
				else
				{
					material.EnableKeyword("1");
				}
			}
			else
			{
				material.EnableKeyword("psychic");
			}
		}
		else
		{
			material.EnableKeyword("_DetailOffsetY");
		}
		int num = this.BEHMQBIFCOJ.CHODJCGKMOK();
		int num2 = this.BEHMQBIFCOJ.JHHQQQGMQBM();
		int num3 = (!settings.downsampling) ? 1 : 7;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.OKINPCLIIHI());
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, num, num2, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.GGILFBBEPKN() != (FCJPPQICFGF.NNFLPMNCDLF)8) ? 3 : 1);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 8);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OPIGCJNFNMN(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.PrepassLight, material, 5);
			this.BEHMQBIFCOJ.BNGNEDGKBHK();
		}
		else if (this.EOBQBCLODMO())
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, (BuiltinRenderTextureType)6);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 8);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.GGDPOOCLQGP()) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-114));
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.CHODJCGKMOK(), this.BEHMQBIFCOJ.DFKQMMIQDOO, 1, FilterMode.Point, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.PrepassLight, hjhqqcbobpp, mat, 1);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.ResolvedDepth, material, 1);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x0030C188 File Offset: 0x0030A388
	private bool EOBQBCLODMO()
	{
		return !this.BEHMQBIFCOJ.EOLMLQPKBKP() || !base.FIFNHCKNDQE.CCIPOGGHFLN().ambientOnly || !this.BEHMQBIFCOJ.NNOLMNBLJBP() || base.FIFNHCKNDQE.EQLDMPKOGEL().forceForwardCompatibility;
	}

	// Token: 0x06006010 RID: 24592 RVA: 0x0030C1E0 File Offset: 0x0030A3E0
	public DepthTextureMode MPHODCJFBQD()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.GMNQLHCQIHI() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.GMNQLHCQIHI() != (FCJPPQICFGF.NNFLPMNCDLF)6)
		{
			depthTextureMode |= (DepthTextureMode)8;
		}
		return depthTextureMode;
	}

	// Token: 0x06006011 RID: 24593 RVA: 0x0030C20C File Offset: 0x0030A40C
	public override void EIQKCDHPCKK(CommandBuffer KLIOPLGOLQC)
	{
		AmbientOcclusionModel.Settings settings = base.FIFNHCKNDQE.settings;
		Material mat = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Blit");
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Ambient Occlusion");
		material.shaderKeywords = null;
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.QKPMMQBHQCE, settings.intensity);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.HDIQPNPGCIG, settings.radius);
		material.SetFloat(FCJPPQICFGF.HQDHOQNKPHE.EHLMIOPDLFF, (!settings.downsampling) ? 1f : 0.5f);
		material.SetInt(FCJPPQICFGF.HQDHOQNKPHE.HJFLFODNLCD, (int)settings.sampleCount);
		if (!this.BEHMQBIFCOJ.GKHCOPLEQKQ && RenderSettings.fog)
		{
			material.SetVector(FCJPPQICFGF.HQDHOQNKPHE.IPDLHMDHCGP, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
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
		}
		else
		{
			material.EnableKeyword("FOG_OFF");
		}
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD;
		int dfkqmmiqdoo = this.BEHMQBIFCOJ.DFKQMMIQDOO;
		int num = (!settings.downsampling) ? 1 : 2;
		int nameID = FCJPPQICFGF.HQDHOQNKPHE.CBONNBCKCKL;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd / num, dfkqmmiqdoo / num, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.Blit(null, nameID, material, (int)this.QBHDEGKIQOL);
		int bhnmjbkdenl = FCJPPQICFGF.HQDHOQNKPHE.BHNMJBKDENL;
		KLIOPLGOLQC.GetTemporaryRT(bhnmjbkdenl, kjgmgpcejjd, dfkqmmiqdoo, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
		KLIOPLGOLQC.Blit(nameID, bhnmjbkdenl, material, (this.QBHDEGKIQOL != FCJPPQICFGF.NNFLPMNCDLF.GBuffer) ? 3 : 4);
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
		nameID = FCJPPQICFGF.HQDHOQNKPHE.QKJQKMGNCCB;
		KLIOPLGOLQC.GetTemporaryRT(nameID, kjgmgpcejjd, dfkqmmiqdoo, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, bhnmjbkdenl);
		KLIOPLGOLQC.Blit(bhnmjbkdenl, nameID, material, 5);
		KLIOPLGOLQC.ReleaseTemporaryRT(bhnmjbkdenl);
		if (this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion))
		{
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, nameID);
			KLIOPLGOLQC.Blit(nameID, BuiltinRenderTextureType.CameraTarget, material, 8);
			this.BEHMQBIFCOJ.OIONKMPKBKJ();
		}
		else if (this.CFONNCHJCMB)
		{
			KLIOPLGOLQC.SetRenderTarget(this.HGHGMDOGFNM, BuiltinRenderTextureType.CameraTarget);
			KLIOPLGOLQC.DrawMesh(LGJGBKJCKPH.FCPPPOBKFHK, Matrix4x4.identity, material, 0, 7);
		}
		else
		{
			RenderTextureFormat format = (!this.BEHMQBIFCOJ.JCHDOOOJKIC) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
			int hjhqqcbobpp = FCJPPQICFGF.HQDHOQNKPHE.HJHQQCBOBPP;
			KLIOPLGOLQC.GetTemporaryRT(hjhqqcbobpp, this.BEHMQBIFCOJ.KJGMGPCEJJD, this.BEHMQBIFCOJ.DFKQMMIQDOO, 0, FilterMode.Bilinear, format);
			KLIOPLGOLQC.Blit(BuiltinRenderTextureType.CameraTarget, hjhqqcbobpp, mat, 0);
			KLIOPLGOLQC.SetGlobalTexture(FCJPPQICFGF.HQDHOQNKPHE.OKKONPEBLHN, hjhqqcbobpp);
			KLIOPLGOLQC.Blit(hjhqqcbobpp, BuiltinRenderTextureType.CameraTarget, material, 6);
			KLIOPLGOLQC.ReleaseTemporaryRT(hjhqqcbobpp);
		}
		KLIOPLGOLQC.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06006012 RID: 24594 RVA: 0x0030C52C File Offset: 0x0030A72C
	public bool FICGCOHNQHI()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KNBMBCNPNLF().intensity <= 35f || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006013 RID: 24595 RVA: 0x0030C574 File Offset: 0x0030A774
	public bool MLIMGGOLOCO()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.FMKCQGMJHME().intensity <= 719f || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006014 RID: 24596 RVA: 0x0030C5BC File Offset: 0x0030A7BC
	public bool PEDKKOKCBOB()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DCBJMHJEFMG().intensity <= 701f || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006015 RID: 24597 RVA: 0x00025ADC File Offset: 0x00023CDC
	public CameraEvent BLMQINCPFMI()
	{
		return (!this.MODQLPLJKJK() || this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.OPIGCJNFNMN(BuiltinDebugViewsModel.HMFGKHHHIPL.MotionVectors)) ? ((CameraEvent)(-50)) : ((CameraEvent)(-54));
	}

	// Token: 0x06006016 RID: 24598 RVA: 0x0030C604 File Offset: 0x0030A804
	public DepthTextureMode OOHIGFGPHEO()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.CNEJFGBOQQP() == FCJPPQICFGF.NNFLPMNCDLF.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.GGILFBBEPKN() != FCJPPQICFGF.NNFLPMNCDLF.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.DepthNormals;
		}
		return depthTextureMode;
	}

	// Token: 0x0400147E RID: 5246
	private const string BFHEDBGNNDM = "Hidden/Post FX/Blit";

	// Token: 0x0400147F RID: 5247
	private const string OEEBQBQIEPO = "Hidden/Post FX/Ambient Occlusion";

	// Token: 0x04001480 RID: 5248
	private readonly RenderTargetIdentifier[] HGHGMDOGFNM = new RenderTargetIdentifier[]
	{
		BuiltinRenderTextureType.GBuffer0,
		BuiltinRenderTextureType.CameraTarget
	};

	// Token: 0x020002AF RID: 687
	private static class HQDHOQNKPHE
	{
		// Token: 0x04001481 RID: 5249
		internal static readonly int QKPMMQBHQCE = Shader.PropertyToID("_Intensity");

		// Token: 0x04001482 RID: 5250
		internal static readonly int HDIQPNPGCIG = Shader.PropertyToID("_Radius");

		// Token: 0x04001483 RID: 5251
		internal static readonly int IPDLHMDHCGP = Shader.PropertyToID("_FogParams");

		// Token: 0x04001484 RID: 5252
		internal static readonly int EHLMIOPDLFF = Shader.PropertyToID("_Downsample");

		// Token: 0x04001485 RID: 5253
		internal static readonly int HJFLFODNLCD = Shader.PropertyToID("_SampleCount");

		// Token: 0x04001486 RID: 5254
		internal static readonly int CBONNBCKCKL = Shader.PropertyToID("_OcclusionTexture1");

		// Token: 0x04001487 RID: 5255
		internal static readonly int BHNMJBKDENL = Shader.PropertyToID("_OcclusionTexture2");

		// Token: 0x04001488 RID: 5256
		internal static readonly int QKJQKMGNCCB = Shader.PropertyToID("_OcclusionTexture");

		// Token: 0x04001489 RID: 5257
		internal static readonly int OKKONPEBLHN = Shader.PropertyToID("_MainTex");

		// Token: 0x0400148A RID: 5258
		internal static readonly int HJHQQCBOBPP = Shader.PropertyToID("_TempRT");
	}

	// Token: 0x020002B0 RID: 688
	private enum NNFLPMNCDLF
	{
		// Token: 0x0400148C RID: 5260
		DepthTexture,
		// Token: 0x0400148D RID: 5261
		DepthNormalsTexture,
		// Token: 0x0400148E RID: 5262
		GBuffer
	}
}
