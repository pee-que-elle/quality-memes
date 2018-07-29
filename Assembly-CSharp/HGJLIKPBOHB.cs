using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
[AddComponentMenu("NGUI/Examples/Pan With Mouse")]
public class HGJLIKPBOHB : MonoBehaviour
{
	// Token: 0x0600082D RID: 2093 RVA: 0x00056F00 File Offset: 0x00055100
	private void QFFJMIOJENJ()
	{
		float num = JMIOBJFFGBN.KQPPFINIJDG();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 1136f;
		float num3 = (float)Screen.height * 1570f;
		if (this.OKGLQDDMFCB < 1800f)
		{
			this.OKGLQDDMFCB = 968f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1207f, 1704f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 1697f, 1785f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 871f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1408f);
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00004F1A File Offset: 0x0000311A
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00004F1A File Offset: 0x0000311A
	private void ODIJQBBOLFI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00057008 File Offset: 0x00055208
	private void FHFMKHDMDDI()
	{
		float num = JMIOBJFFGBN.QPEECHQDHFG();
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		float num2 = (float)Screen.width * 1349f;
		float num3 = (float)Screen.height * 1173f;
		if (this.OKGLQDDMFCB < 170f)
		{
			this.OKGLQDDMFCB = 1118f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1253f, 1772f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 1906f, 262f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 609f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 507f);
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x00004F1A File Offset: 0x0000311A
	private void IMGNEDCFBLL()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00004F1A File Offset: 0x0000311A
	private void JPNMOLDKPQP()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00057110 File Offset: 0x00055310
	private void EPOCMHBMHGC()
	{
		float num = JMIOBJFFGBN.DFLFHGFHJMN();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 1723f;
		float num3 = (float)Screen.height * 1189f;
		if (this.OKGLQDDMFCB < 1366f)
		{
			this.OKGLQDDMFCB = 1290f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1501f, 23f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 1104f, 1133f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 315f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1428f);
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00004F1A File Offset: 0x0000311A
	private void JHQCMGKJCCI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00004F1A File Offset: 0x0000311A
	private void JDLQNCEDMPI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00057218 File Offset: 0x00055418
	private void MEDIPECIDQP()
	{
		float num = JMIOBJFFGBN.PPIKCLHKEIH();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 152f;
		float num3 = (float)Screen.height * 1053f;
		if (this.OKGLQDDMFCB < 1351f)
		{
			this.OKGLQDDMFCB = 1729f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 24f, 770f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 407f, 1654f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 962f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1330f);
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00057320 File Offset: 0x00055520
	private void Update()
	{
		float gpfidejemeg = JMIOBJFFGBN.GPFIDEJEMEG;
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num = (float)Screen.width * 0.5f;
		float num2 = (float)Screen.height * 0.5f;
		if (this.OKGLQDDMFCB < 0.1f)
		{
			this.OKGLQDDMFCB = 0.1f;
		}
		float x = Mathf.Clamp((vector.x - num) / num / this.OKGLQDDMFCB, -1f, 1f);
		float y = Mathf.Clamp((vector.y - num2) / num2 / this.OKGLQDDMFCB, -1f, 1f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), gpfidejemeg * 5f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 0f);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00004F1A File Offset: 0x0000311A
	private void IKHIQQKHILB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00004F1A File Offset: 0x0000311A
	private void DBFJHIHLQHO()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00004F1A File Offset: 0x0000311A
	private void QNGIFIJOQML()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00004F1A File Offset: 0x0000311A
	private void NDFNCDDDJPN()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00057428 File Offset: 0x00055628
	private void PIQDBCGQDCH()
	{
		float num = JMIOBJFFGBN.MEJKCDOLEIK();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 1740f;
		float num3 = (float)Screen.height * 1608f;
		if (this.OKGLQDDMFCB < 201f)
		{
			this.OKGLQDDMFCB = 770f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 423f, 1899f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 427f, 1805f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 1406f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1868f);
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x00057530 File Offset: 0x00055730
	private void MOLCLOMMJNQ()
	{
		float num = JMIOBJFFGBN.QPEECHQDHFG();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 1519f;
		float num3 = (float)Screen.height * 119f;
		if (this.OKGLQDDMFCB < 1581f)
		{
			this.OKGLQDDMFCB = 1824f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 80f, 584f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 1689f, 1042f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 1833f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 410f);
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00004F1A File Offset: 0x0000311A
	private void NOLQNFCODBK()
	{
		this.BLLEFKOLKLP = base.transform;
		this.IQPEEMCIIHK = this.BLLEFKOLKLP.localRotation;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00057638 File Offset: 0x00055838
	private void JLBMOKHNDBI()
	{
		float num = JMIOBJFFGBN.MEJKCDOLEIK();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 608f;
		float num3 = (float)Screen.height * 986f;
		if (this.OKGLQDDMFCB < 319f)
		{
			this.OKGLQDDMFCB = 675f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1035f, 175f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 1086f, 1036f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 1431f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1460f);
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00057740 File Offset: 0x00055940
	private void OEFEKHJBGPN()
	{
		float num = JMIOBJFFGBN.FCPBKHJFGJO();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 503f;
		float num3 = (float)Screen.height * 985f;
		if (this.OKGLQDDMFCB < 1552f)
		{
			this.OKGLQDDMFCB = 491f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1348f, 121f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 118f, 1565f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 1152f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 1909f);
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00057848 File Offset: 0x00055A48
	private void HFEGBJEPMPQ()
	{
		float num = JMIOBJFFGBN.PFEELKIHJDG();
		Vector3 vector = EMENMKHBPQE.GDLFOFEJOPK();
		float num2 = (float)Screen.width * 1287f;
		float num3 = (float)Screen.height * 302f;
		if (this.OKGLQDDMFCB < 342f)
		{
			this.OKGLQDDMFCB = 1439f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1973f, 875f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 551f, 369f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 1506f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 898f);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00057950 File Offset: 0x00055B50
	private void HGKPKMMIPLG()
	{
		float num = JMIOBJFFGBN.PFEELKIHJDG();
		Vector3 vector = EMENMKHBPQE.OBLGQQHNDII;
		float num2 = (float)Screen.width * 1180f;
		float num3 = (float)Screen.height * 174f;
		if (this.OKGLQDDMFCB < 479f)
		{
			this.OKGLQDDMFCB = 214f;
		}
		float x = Mathf.Clamp((vector.x - num2) / num2 / this.OKGLQDDMFCB, 1144f, 836f);
		float y = Mathf.Clamp((vector.y - num3) / num3 / this.OKGLQDDMFCB, 385f, 790f);
		this.NCDILLHBJPI = Vector2.Lerp(this.NCDILLHBJPI, new Vector2(x, y), num * 201f);
		this.BLLEFKOLKLP.localRotation = this.IQPEEMCIIHK * Quaternion.Euler(-this.NCDILLHBJPI.y * this.MDFDJKOHQKK.y, this.NCDILLHBJPI.x * this.MDFDJKOHQKK.x, 429f);
	}

	// Token: 0x04000121 RID: 289
	public Vector2 MDFDJKOHQKK = new Vector2(5f, 3f);

	// Token: 0x04000122 RID: 290
	public float OKGLQDDMFCB = 1f;

	// Token: 0x04000123 RID: 291
	private Transform BLLEFKOLKLP;

	// Token: 0x04000124 RID: 292
	private Quaternion IQPEEMCIIHK;

	// Token: 0x04000125 RID: 293
	private Vector2 NCDILLHBJPI = Vector2.zero;
}
