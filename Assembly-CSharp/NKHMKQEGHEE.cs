using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
[ExecuteInEditMode]
public class NKHMKQEGHEE : MonoBehaviour
{
	// Token: 0x0600042D RID: 1069 RVA: 0x00002300 File Offset: 0x00000500
	public void IGJMLLFDCHM()
	{
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00003E5E File Offset: 0x0000205E
	private void FCOIMQGENDB()
	{
		if (this.LFHQCPKBNMP)
		{
			this.LMPFCMIMHFH();
		}
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00003E73 File Offset: 0x00002073
	public void JNHEQHNKGJE(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00003E5E File Offset: 0x0000205E
	private void IDIFGIFCEHO()
	{
		if (this.LFHQCPKBNMP)
		{
			this.LMPFCMIMHFH();
		}
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00003E93 File Offset: 0x00002093
	public void FKKCFPLNJOH(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00003EB3 File Offset: 0x000020B3
	private void HMJOBKGICKD()
	{
		if (this.LFHQCPKBNMP)
		{
			this.FODDOKJCJFD();
		}
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002300 File Offset: 0x00000500
	public void LIPJEKLNFJI()
	{
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00003E93 File Offset: 0x00002093
	public void GBFFHOPBKNH(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00002300 File Offset: 0x00000500
	public void Update()
	{
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00003EC8 File Offset: 0x000020C8
	private void PGDEJLCEEKN()
	{
		if (this.LFHQCPKBNMP)
		{
			this.MPPQPGMNNFN();
		}
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00045AC8 File Offset: 0x00043CC8
	public void FIJKJCFPQIF()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 38;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("Normal-type moves become Electric-type moves. The power of those moves is boosted a little.");
			Shader.DisableKeyword("Grass Pelt");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("System Message");
			Shader.DisableKeyword("status: ");
		}
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00002300 File Offset: 0x00000500
	public void GCEDFPKOEMN()
	{
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00045B4C File Offset: 0x00043D4C
	public void GJKEPOHGNEG()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -73;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("_TileVRT");
			Shader.DisableKeyword("_Jitter");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("~");
			Shader.DisableKeyword("127.0.0.1");
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00003EC8 File Offset: 0x000020C8
	private void CMLGQHQJDGQ()
	{
		if (this.LFHQCPKBNMP)
		{
			this.MPPQPGMNNFN();
		}
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00003EDD File Offset: 0x000020DD
	private void MBKJBIQKPGF()
	{
		if (this.LFHQCPKBNMP)
		{
			this.KLFPFJEBLOO();
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002300 File Offset: 0x00000500
	public void DKJKOBGBKCN()
	{
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00045BD0 File Offset: 0x00043DD0
	public void INPHLFBNECK()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -1;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("[S]");
			Shader.DisableKeyword("'s [ffff00]");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("Tangling Hair");
			Shader.DisableKeyword("\nx");
		}
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00003EF2 File Offset: 0x000020F2
	private void NOBDHBBKKHN()
	{
		if (this.LFHQCPKBNMP)
		{
			this.BQLLICIDKNL();
		}
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00003F07 File Offset: 0x00002107
	private void FCGLNCNICGB()
	{
		if (this.LFHQCPKBNMP)
		{
			this.QLDGBBQLCCO();
		}
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00002300 File Offset: 0x00000500
	public void KNFDIHBNPNG()
	{
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00003E93 File Offset: 0x00002093
	public void EJPDEPQEMKL(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00003F1C File Offset: 0x0000211C
	private void Start()
	{
		if (this.LFHQCPKBNMP)
		{
			this.HDNLKEJMJJG();
		}
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00045C54 File Offset: 0x00043E54
	public void FODDOKJCJFD()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -122;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword(" has no shader setter");
			Shader.DisableKeyword(" from using certain moves!\r\n");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("[-]?\n\nOnce you do this, it will be lost forever.");
			Shader.DisableKeyword("c");
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00003F31 File Offset: 0x00002131
	private void DPMNBIMDLIM()
	{
		if (this.LFHQCPKBNMP)
		{
			this.INPHLFBNECK();
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00003E93 File Offset: 0x00002093
	public void DFIGPEDNBKJ(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002300 File Offset: 0x00000500
	public void JLBMOKHNDBI()
	{
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00045CD8 File Offset: 0x00043ED8
	public void EDLCIEIHJKP()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 181;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("skydrop");
			Shader.DisableKeyword("HidePanel");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("\\n");
			Shader.DisableKeyword("No camera found for layer ");
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00003E93 File Offset: 0x00002093
	public void CQMDMJHKNJF(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00002300 File Offset: 0x00000500
	public void JPBJIKMEBOF()
	{
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00003EF2 File Offset: 0x000020F2
	private void JCQCNFLNMNP()
	{
		if (this.LFHQCPKBNMP)
		{
			this.BQLLICIDKNL();
		}
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00003F46 File Offset: 0x00002146
	private void NDFNCDDDJPN()
	{
		if (this.LFHQCPKBNMP)
		{
			this.EDLCIEIHJKP();
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00003E73 File Offset: 0x00002073
	public void HOOKDEPQEFM(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00002300 File Offset: 0x00000500
	public void DLBNQMKQILC()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00045D5C File Offset: 0x00043F5C
	public void MPPQPGMNNFN()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -120;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("[ff6600]");
			Shader.DisableKeyword("FactoryTempTexture");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("Party");
			Shader.DisableKeyword("other");
		}
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00003E73 File Offset: 0x00002073
	public void HILNPINEKJL(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00003E73 File Offset: 0x00002073
	public void POKBMGMLGFF(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00003F5B File Offset: 0x0000215B
	private void LNHDODMGBKC()
	{
		if (this.LFHQCPKBNMP)
		{
			this.GJKEPOHGNEG();
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00002300 File Offset: 0x00000500
	public void PIQDBCGQDCH()
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00002300 File Offset: 0x00000500
	public void GKMKINDKNPJ()
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00003F70 File Offset: 0x00002170
	private void FOPKBNIOGCP()
	{
		if (this.LFHQCPKBNMP)
		{
			this.MFJLGPEHLJF();
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00045DE0 File Offset: 0x00043FE0
	public void NLHJDONJBDG()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -45;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("Fan");
			Shader.DisableKeyword(" hrs, ");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("The [ffff00]");
			Shader.DisableKeyword("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EDY4N2MVWY2G6&custom=");
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00045E64 File Offset: 0x00044064
	public void BQLLICIDKNL()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -177;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("#,##0");
			Shader.DisableKeyword("_FresnelFadePower");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("pacman");
			Shader.DisableKeyword("bloom");
		}
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00003E93 File Offset: 0x00002093
	public void HFHNCMFGBFK(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00045EE8 File Offset: 0x000440E8
	public void CCFONDLLNPO()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -197;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("p");
			Shader.DisableKeyword("!\r\n");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("bounce");
			Shader.DisableKeyword("System");
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002300 File Offset: 0x00000500
	public void FKFEDINPBFF()
	{
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00003F07 File Offset: 0x00002107
	private void DHGEJKGNHCO()
	{
		if (this.LFHQCPKBNMP)
		{
			this.QLDGBBQLCCO();
		}
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00002300 File Offset: 0x00000500
	public void HGKPKMMIPLG()
	{
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00003EC8 File Offset: 0x000020C8
	private void GGGNJNNQMED()
	{
		if (this.LFHQCPKBNMP)
		{
			this.MPPQPGMNNFN();
		}
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00003E73 File Offset: 0x00002073
	public void IDMQHIOGLGL(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00003E73 File Offset: 0x00002073
	public void FQGBBOBFDFO(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x00003F85 File Offset: 0x00002185
	private void LMMGEGJCBJP()
	{
		if (this.LFHQCPKBNMP)
		{
			this.NGIGHLOPDBF();
		}
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x00003F07 File Offset: 0x00002107
	private void LBIFHHFMPHD()
	{
		if (this.LFHQCPKBNMP)
		{
			this.QLDGBBQLCCO();
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00003E73 File Offset: 0x00002073
	public void DNMIIDGFFMG(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00045F6C File Offset: 0x0004416C
	public void MFJLGPEHLJF()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -154;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("Language");
			Shader.DisableKeyword("The sunlight faded.");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("[33CCFF]");
			Shader.DisableKeyword("Tangled Feet");
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00002300 File Offset: 0x00000500
	public void KNGQHHLPDMH()
	{
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00003E93 File Offset: 0x00002093
	public void BOBPNOFBKQI(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00045FF0 File Offset: 0x000441F0
	public void KLFPFJEBLOO()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 118;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("CombinersArgsAlphaOp1");
			Shader.DisableKeyword("The Pokémon can't use a move the following turn if it uses one.");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("stealeat");
			Shader.DisableKeyword("Right");
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00002300 File Offset: 0x00000500
	public void FLNFKFECNFJ()
	{
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00003E73 File Offset: 0x00002073
	public void BEGDQKCFHGK(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00003E93 File Offset: 0x00002093
	public void FMIGBCPHCFP(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00002300 File Offset: 0x00000500
	public void FBKNCKKFJJG()
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002300 File Offset: 0x00000500
	public void NIIPIECJPOL()
	{
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00002300 File Offset: 0x00000500
	public void OODKHHIPKFC()
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00003FA9 File Offset: 0x000021A9
	private void HHLNMNBLHFM()
	{
		if (this.LFHQCPKBNMP)
		{
			this.NLHJDONJBDG();
		}
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00003EB3 File Offset: 0x000020B3
	private void OLLNOFNEEIL()
	{
		if (this.LFHQCPKBNMP)
		{
			this.FODDOKJCJFD();
		}
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00003E73 File Offset: 0x00002073
	public void QJQCPLMOFCP(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00046074 File Offset: 0x00044274
	public void LMPFCMIMHFH()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 112;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("ACC: ");
			Shader.DisableKeyword("[CFX_SpawnSystem.removeObjectsFromPool()] There aren't any preloaded object for: ");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("#");
			Shader.DisableKeyword("berry_15");
		}
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00003EF2 File Offset: 0x000020F2
	private void QNGIFIJOQML()
	{
		if (this.LFHQCPKBNMP)
		{
			this.BQLLICIDKNL();
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x000460F8 File Offset: 0x000442F8
	public void QLDGBBQLCCO()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = -189;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("-ohko");
			Shader.DisableKeyword("_FogDownsampled");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("Fly can be used to travel to significant places you have visited.\n\n[2ecc71]Left Click to use this.[-]");
			Shader.DisableKeyword("queenlymajesty");
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00003E73 File Offset: 0x00002073
	public void ICNGKIMELNM(Transform GFBMGMFNKCD, Camera JOOKJPHGKON)
	{
		if (JOOKJPHGKON && this.LQMJJFLHMOI)
		{
			JOOKJPHGKON.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00003EC8 File Offset: 0x000020C8
	private void LODQBMMKNNM()
	{
		if (this.LFHQCPKBNMP)
		{
			this.MPPQPGMNNFN();
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x0004617C File Offset: 0x0004437C
	public void NGIGHLOPDBF()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 144;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = true;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("[/C]");
			Shader.DisableKeyword("[ffb649]");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.None;
			}
		}
		else
		{
			Shader.EnableKeyword("'");
			Shader.DisableKeyword("effectspore");
		}
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00046200 File Offset: 0x00044400
	public void HDNLKEJMJJG()
	{
		this.LFHQCPKBNMP.shader.maximumLOD = 201;
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.LQMJJFLHMOI = false;
		}
		if (this.LQMJJFLHMOI)
		{
			Shader.EnableKeyword("WATER_EDGEBLEND_ON");
			Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
			if (Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
			Shader.DisableKeyword("WATER_EDGEBLEND_ON");
		}
	}

	// Token: 0x04000098 RID: 152
	public Material LFHQCPKBNMP;

	// Token: 0x04000099 RID: 153
	public bool LQMJJFLHMOI = true;
}
