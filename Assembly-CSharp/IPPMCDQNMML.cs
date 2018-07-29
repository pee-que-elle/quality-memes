using System;
using UnityEngine;

// Token: 0x02000118 RID: 280
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/Orthographic Camera")]
public class IPPMCDQNMML : MonoBehaviour
{
	// Token: 0x06001FAA RID: 8106 RVA: 0x00011814 File Offset: 0x0000FA14
	private void CNIKQOQLFFB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void BCDLNCLKKBM()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000CF390 File Offset: 0x000CD590
	private void GKMKINDKNPJ()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 774f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000CF414 File Offset: 0x000CD614
	private void DLBNQMKQILC()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1857f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void MBKJBIQKPGF()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00011814 File Offset: 0x0000FA14
	private void DGMPMICDCIO()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x00011814 File Offset: 0x0000FA14
	private void IMGNEDCFBLL()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000CF498 File Offset: 0x000CD698
	private void JIHOGMQPHDF()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 932f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000CF51C File Offset: 0x000CD71C
	private void IGJKHIMGLFH()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1218f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000CF5A0 File Offset: 0x000CD7A0
	private void GCQNFNBMMPQ()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 567f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000CF624 File Offset: 0x000CD824
	private void NPQEGOIJHIL()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1631f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
	private void JENGGFLPCDQ()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 823f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000CF72C File Offset: 0x000CD92C
	private void Update()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 0.5f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x00011814 File Offset: 0x0000FA14
	private void NOLQNFCODBK()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000CF7B0 File Offset: 0x000CD9B0
	private void OEFEKHJBGPN()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 661f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000CF834 File Offset: 0x000CDA34
	private void PIQDBCGQDCH()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1549f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x00011814 File Offset: 0x0000FA14
	private void ECQHGIBBBPI()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000CF8B8 File Offset: 0x000CDAB8
	private void QDIKKLMCIJK()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1116f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x00011814 File Offset: 0x0000FA14
	private void MHOKPDFOEDP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x00011814 File Offset: 0x0000FA14
	private void FCOIMQGENDB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000CF93C File Offset: 0x000CDB3C
	private void EPOCMHBMHGC()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 482f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000CF9C0 File Offset: 0x000CDBC0
	private void GCEDFPKOEMN()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 394f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000CFA44 File Offset: 0x000CDC44
	private void KHQIGBMDOGP()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1014f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x00011814 File Offset: 0x0000FA14
	private void PGFHJKDGEMJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
	private void EHBDNIOCHNO()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1755f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x00011814 File Offset: 0x0000FA14
	private void DFNFEDMJKGK()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000CFB4C File Offset: 0x000CDD4C
	private void QDHNIMPGNOO()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1876f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00011814 File Offset: 0x0000FA14
	private void LMMGEGJCBJP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000CFBD0 File Offset: 0x000CDDD0
	private void FKFEDINPBFF()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1998f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00011814 File Offset: 0x0000FA14
	private void CMLGQHQJDGQ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void JDLQNCEDMPI()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000CFC54 File Offset: 0x000CDE54
	private void CLNOPBFEBID()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 720f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00011814 File Offset: 0x0000FA14
	private void EDOGJBLCCMQ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00011814 File Offset: 0x0000FA14
	private void ODIJQBBOLFI()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000CFCD8 File Offset: 0x000CDED8
	private void HDMNIKNDNGQ()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 234f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void LNHDODMGBKC()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void ODOPGCOCHHL()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000CFD5C File Offset: 0x000CDF5C
	private void GHBFIQFIBKP()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1092f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void BBGHCDGEDEJ()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x00011814 File Offset: 0x0000FA14
	private void QBGOGFJCLEP()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = false;
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void FCGLNCNICGB()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x0001183A File Offset: 0x0000FA3A
	private void Start()
	{
		this.OJIDBLEKBBO = base.GetComponent<Camera>();
		this.BLLEFKOLKLP = base.transform;
		this.OJIDBLEKBBO.orthographic = true;
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
	private void HFEGBJEPMPQ()
	{
		float num = this.OJIDBLEKBBO.rect.yMin * (float)Screen.height;
		float num2 = this.OJIDBLEKBBO.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 340f * this.BLLEFKOLKLP.lossyScale.y;
		if (!Mathf.Approximately(this.OJIDBLEKBBO.orthographicSize, num3))
		{
			this.OJIDBLEKBBO.orthographicSize = num3;
		}
	}

	// Token: 0x040006F0 RID: 1776
	private Camera OJIDBLEKBBO;

	// Token: 0x040006F1 RID: 1777
	private Transform BLLEFKOLKLP;
}
