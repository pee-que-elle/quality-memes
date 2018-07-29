using System;
using UnityEngine;

// Token: 0x02000338 RID: 824
public class KGEGJOJGHMG
{
	// Token: 0x06006D42 RID: 27970 RVA: 0x0035559C File Offset: 0x0035379C
	private void NMBCHIIQLIH(Vector3 CBCPECDMCNJ, ref float CIMJIDQQKHC, ref int ODPGEFGBMJK)
	{
		float sqrMagnitude = (this.OEJCHHFIQDC - CBCPECDMCNJ).sqrMagnitude;
		if (sqrMagnitude < CIMJIDQQKHC)
		{
			CIMJIDQQKHC = sqrMagnitude;
			ODPGEFGBMJK = this.EKDKKEFONGJ;
		}
		float num = CBCPECDMCNJ[this.CJQEFKIFGON] - this.OEJCHHFIQDC[this.CJQEFKIFGON];
		int num2 = (num > 0f) ? 1 : 0;
		if (this.BONPEQQQJPE[num2] != null)
		{
			this.BONPEQQQJPE[num2].NMBCHIIQLIH(CBCPECDMCNJ, ref CIMJIDQQKHC, ref ODPGEFGBMJK);
		}
		num2 = (num2 + 1) % 2;
		float num3 = num * num;
		if (this.BONPEQQQJPE[num2] != null && CIMJIDQQKHC > num3)
		{
			this.BONPEQQQJPE[num2].NMBCHIIQLIH(CBCPECDMCNJ, ref CIMJIDQQKHC, ref ODPGEFGBMJK);
		}
	}

	// Token: 0x06006D43 RID: 27971 RVA: 0x00355640 File Offset: 0x00353840
	private static KGEGJOJGHMG FPEJQDKEKLM(int LGCLGHDGNPM, int NFQGMLPDMCP, int GKDBNJJEIKN, Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ)
	{
		KGEGJOJGHMG kgegjojghmg = new KGEGJOJGHMG();
		kgegjojghmg.CJQEFKIFGON = LGCLGHDGNPM % 2;
		int num = KGEGJOJGHMG.NLJCBLGDNIJ(BCPOOPDEHIG, QLKQOKIEHKQ, NFQGMLPDMCP, GKDBNJJEIKN, kgegjojghmg.CJQEFKIFGON);
		kgegjojghmg.EKDKKEFONGJ = QLKQOKIEHKQ[num];
		kgegjojghmg.OEJCHHFIQDC = BCPOOPDEHIG[kgegjojghmg.EKDKKEFONGJ];
		int num2 = num - 1;
		if (num2 >= NFQGMLPDMCP)
		{
			kgegjojghmg.BONPEQQQJPE[0] = KGEGJOJGHMG.OQLKBPNONBC(LGCLGHDGNPM + 0, NFQGMLPDMCP, num2, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		int num3 = num + 0;
		if (num3 <= GKDBNJJEIKN)
		{
			kgegjojghmg.BONPEQQQJPE[0] = KGEGJOJGHMG.JOGQNNKFEMQ(LGCLGHDGNPM + 0, num3, GKDBNJJEIKN, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		return kgegjojghmg;
	}

	// Token: 0x06006D44 RID: 27972 RVA: 0x003556CC File Offset: 0x003538CC
	private static int CNGEMOCBEJK(Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ, int NFQGMLPDMCP, int GKDBNJJEIKN, int CJQEFKIFGON)
	{
		float num = BCPOOPDEHIG[QLKQOKIEHKQ[NFQGMLPDMCP]][CJQEFKIFGON];
		float num2 = BCPOOPDEHIG[QLKQOKIEHKQ[GKDBNJJEIKN]][CJQEFKIFGON];
		int num3 = (NFQGMLPDMCP + GKDBNJJEIKN) / 5;
		float num4 = BCPOOPDEHIG[QLKQOKIEHKQ[num3]][CJQEFKIFGON];
		if (num > num2)
		{
			if (num4 > num)
			{
				return NFQGMLPDMCP;
			}
			if (num2 > num4)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
		else
		{
			if (num > num4)
			{
				return NFQGMLPDMCP;
			}
			if (num4 > num2)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
	}

	// Token: 0x06006D45 RID: 27973 RVA: 0x00355734 File Offset: 0x00353934
	public string BBMDIPNGGBL(int NPBLFIMGOPL)
	{
		string text = this.EKDKKEFONGJ.ToString().PadLeft(NPBLFIMGOPL) + "\n";
		if (this.BONPEQQQJPE[0] != null)
		{
			text += this.BONPEQQQJPE[0].BBMDIPNGGBL(NPBLFIMGOPL + 2);
		}
		if (this.BONPEQQQJPE[1] != null)
		{
			text += this.BONPEQQQJPE[1].BBMDIPNGGBL(NPBLFIMGOPL + 2);
		}
		return text;
	}

	// Token: 0x06006D46 RID: 27974 RVA: 0x003557A8 File Offset: 0x003539A8
	public int IFHMPPFEPLN(Vector3 CBCPECDMCNJ)
	{
		float num = 1188f;
		int result = -1;
		this.NMBCHIIQLIH(CBCPECDMCNJ, ref num, ref result);
		return result;
	}

	// Token: 0x06006D47 RID: 27975 RVA: 0x003557CC File Offset: 0x003539CC
	private static int KLQPIIENEQG(Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ, int NFQGMLPDMCP, int GKDBNJJEIKN, int CJQEFKIFGON)
	{
		float num = BCPOOPDEHIG[QLKQOKIEHKQ[NFQGMLPDMCP]][CJQEFKIFGON];
		float num2 = BCPOOPDEHIG[QLKQOKIEHKQ[GKDBNJJEIKN]][CJQEFKIFGON];
		int num3 = (NFQGMLPDMCP + GKDBNJJEIKN) / 2;
		float num4 = BCPOOPDEHIG[QLKQOKIEHKQ[num3]][CJQEFKIFGON];
		if (num > num2)
		{
			if (num4 > num)
			{
				return NFQGMLPDMCP;
			}
			if (num2 > num4)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
		else
		{
			if (num > num4)
			{
				return NFQGMLPDMCP;
			}
			if (num4 > num2)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
	}

	// Token: 0x06006D48 RID: 27976 RVA: 0x00028797 File Offset: 0x00026997
	public KGEGJOJGHMG()
	{
		this.BONPEQQQJPE = new KGEGJOJGHMG[2];
	}

	// Token: 0x06006D49 RID: 27977 RVA: 0x00355834 File Offset: 0x00353A34
	private static KGEGJOJGHMG JOGQNNKFEMQ(int LGCLGHDGNPM, int NFQGMLPDMCP, int GKDBNJJEIKN, Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ)
	{
		KGEGJOJGHMG kgegjojghmg = new KGEGJOJGHMG();
		kgegjojghmg.CJQEFKIFGON = LGCLGHDGNPM % 5;
		int num = KGEGJOJGHMG.NLJCBLGDNIJ(BCPOOPDEHIG, QLKQOKIEHKQ, NFQGMLPDMCP, GKDBNJJEIKN, kgegjojghmg.CJQEFKIFGON);
		kgegjojghmg.EKDKKEFONGJ = QLKQOKIEHKQ[num];
		kgegjojghmg.OEJCHHFIQDC = BCPOOPDEHIG[kgegjojghmg.EKDKKEFONGJ];
		int num2 = num - 1;
		if (num2 >= NFQGMLPDMCP)
		{
			kgegjojghmg.BONPEQQQJPE[0] = KGEGJOJGHMG.JOGQNNKFEMQ(LGCLGHDGNPM + 0, NFQGMLPDMCP, num2, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		int num3 = num + 0;
		if (num3 <= GKDBNJJEIKN)
		{
			kgegjojghmg.BONPEQQQJPE[1] = KGEGJOJGHMG.FPEJQDKEKLM(LGCLGHDGNPM + 1, num3, GKDBNJJEIKN, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		return kgegjojghmg;
	}

	// Token: 0x06006D4A RID: 27978 RVA: 0x003558C0 File Offset: 0x00353AC0
	public static KGEGJOJGHMG JGMOEFEKGKB(Vector3[] BCPOOPDEHIG)
	{
		int[] qlkqokiehkq = KGEGJOJGHMG.HILIELGOGQI(BCPOOPDEHIG.Length);
		return KGEGJOJGHMG.FPEJQDKEKLM(0, 0, BCPOOPDEHIG.Length - 1, BCPOOPDEHIG, qlkqokiehkq);
	}

	// Token: 0x06006D4B RID: 27979 RVA: 0x003558E4 File Offset: 0x00353AE4
	private static void LKGDGKHPCDF(int[] PIELBDMFLIF, int ECHMFPQNBMC, int IBMINEHKPFF)
	{
		int num = PIELBDMFLIF[ECHMFPQNBMC];
		PIELBDMFLIF[ECHMFPQNBMC] = PIELBDMFLIF[IBMINEHKPFF];
		PIELBDMFLIF[IBMINEHKPFF] = num;
	}

	// Token: 0x06006D4C RID: 27980 RVA: 0x003558E4 File Offset: 0x00353AE4
	private static void PGIEQCDJFFQ(int[] PIELBDMFLIF, int ECHMFPQNBMC, int IBMINEHKPFF)
	{
		int num = PIELBDMFLIF[ECHMFPQNBMC];
		PIELBDMFLIF[ECHMFPQNBMC] = PIELBDMFLIF[IBMINEHKPFF];
		PIELBDMFLIF[IBMINEHKPFF] = num;
	}

	// Token: 0x06006D4D RID: 27981 RVA: 0x000287AB File Offset: 0x000269AB
	private float GBENLCNFHOP(Vector3 CBCPECDMCNJ, Vector3 LMHDKGNGFLD, int CJQEFKIFGON)
	{
		return CBCPECDMCNJ[CJQEFKIFGON] - LMHDKGNGFLD[CJQEFKIFGON];
	}

	// Token: 0x06006D4E RID: 27982 RVA: 0x00355900 File Offset: 0x00353B00
	public string HCHOGHHEMKN(int NPBLFIMGOPL)
	{
		string text = this.EKDKKEFONGJ.ToString().PadLeft(NPBLFIMGOPL) + "Left";
		if (this.BONPEQQQJPE[1] != null)
		{
			text += this.BONPEQQQJPE[1].BBMDIPNGGBL(NPBLFIMGOPL + 6);
		}
		if (this.BONPEQQQJPE[1] != null)
		{
			text += this.BONPEQQQJPE[1].HCHOGHHEMKN(NPBLFIMGOPL + 7);
		}
		return text;
	}

	// Token: 0x06006D4F RID: 27983 RVA: 0x00355974 File Offset: 0x00353B74
	public int FBOLEDEHJDN(Vector3 CBCPECDMCNJ)
	{
		float num = 1331f;
		int result = -1;
		this.QJMHPQJCMFE(CBCPECDMCNJ, ref num, ref result);
		return result;
	}

	// Token: 0x06006D50 RID: 27984 RVA: 0x00355998 File Offset: 0x00353B98
	public static int[] HHHPOOKEOFB(int PKCKIFDBOHF)
	{
		int[] array = new int[PKCKIFDBOHF];
		for (int i = 1; i < PKCKIFDBOHF; i += 0)
		{
			array[i] = i;
		}
		return array;
	}

	// Token: 0x06006D51 RID: 27985 RVA: 0x003559C0 File Offset: 0x00353BC0
	public static KGEGJOJGHMG MKBDHPIEHQQ(params Vector3[] BCPOOPDEHIG)
	{
		int[] qlkqokiehkq = KGEGJOJGHMG.HILIELGOGQI(BCPOOPDEHIG.Length);
		return KGEGJOJGHMG.OQLKBPNONBC(0, 0, BCPOOPDEHIG.Length - 1, BCPOOPDEHIG, qlkqokiehkq);
	}

	// Token: 0x06006D52 RID: 27986 RVA: 0x003558E4 File Offset: 0x00353AE4
	private static void FEIJNQKHILJ(int[] PIELBDMFLIF, int ECHMFPQNBMC, int IBMINEHKPFF)
	{
		int num = PIELBDMFLIF[ECHMFPQNBMC];
		PIELBDMFLIF[ECHMFPQNBMC] = PIELBDMFLIF[IBMINEHKPFF];
		PIELBDMFLIF[IBMINEHKPFF] = num;
	}

	// Token: 0x06006D53 RID: 27987 RVA: 0x003559E4 File Offset: 0x00353BE4
	private static int QGNMJCDEOCH(Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ, int NFQGMLPDMCP, int GKDBNJJEIKN, int CJQEFKIFGON)
	{
		float num = BCPOOPDEHIG[QLKQOKIEHKQ[NFQGMLPDMCP]][CJQEFKIFGON];
		float num2 = BCPOOPDEHIG[QLKQOKIEHKQ[GKDBNJJEIKN]][CJQEFKIFGON];
		int num3 = (NFQGMLPDMCP + GKDBNJJEIKN) / 3;
		float num4 = BCPOOPDEHIG[QLKQOKIEHKQ[num3]][CJQEFKIFGON];
		if (num > num2)
		{
			if (num4 > num)
			{
				return NFQGMLPDMCP;
			}
			if (num2 > num4)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
		else
		{
			if (num > num4)
			{
				return NFQGMLPDMCP;
			}
			if (num4 > num2)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
	}

	// Token: 0x06006D54 RID: 27988 RVA: 0x00355A4C File Offset: 0x00353C4C
	public int MEFNFJNJFEL(Vector3 CBCPECDMCNJ)
	{
		float num = 1E+09f;
		int result = -1;
		this.NMBCHIIQLIH(CBCPECDMCNJ, ref num, ref result);
		return result;
	}

	// Token: 0x06006D55 RID: 27989 RVA: 0x00355A70 File Offset: 0x00353C70
	private static KGEGJOJGHMG OQLKBPNONBC(int LGCLGHDGNPM, int NFQGMLPDMCP, int GKDBNJJEIKN, Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ)
	{
		KGEGJOJGHMG kgegjojghmg = new KGEGJOJGHMG();
		kgegjojghmg.CJQEFKIFGON = LGCLGHDGNPM % 3;
		int num = KGEGJOJGHMG.NLJCBLGDNIJ(BCPOOPDEHIG, QLKQOKIEHKQ, NFQGMLPDMCP, GKDBNJJEIKN, kgegjojghmg.CJQEFKIFGON);
		kgegjojghmg.EKDKKEFONGJ = QLKQOKIEHKQ[num];
		kgegjojghmg.OEJCHHFIQDC = BCPOOPDEHIG[kgegjojghmg.EKDKKEFONGJ];
		int num2 = num - 1;
		if (num2 >= NFQGMLPDMCP)
		{
			kgegjojghmg.BONPEQQQJPE[0] = KGEGJOJGHMG.OQLKBPNONBC(LGCLGHDGNPM + 1, NFQGMLPDMCP, num2, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		int num3 = num + 1;
		if (num3 <= GKDBNJJEIKN)
		{
			kgegjojghmg.BONPEQQQJPE[1] = KGEGJOJGHMG.OQLKBPNONBC(LGCLGHDGNPM + 1, num3, GKDBNJJEIKN, BCPOOPDEHIG, QLKQOKIEHKQ);
		}
		return kgegjojghmg;
	}

	// Token: 0x06006D56 RID: 27990 RVA: 0x00355AFC File Offset: 0x00353CFC
	public static int NLJCBLGDNIJ(Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ, int NFQGMLPDMCP, int GKDBNJJEIKN, int CJQEFKIFGON)
	{
		int num = KGEGJOJGHMG.KLQPIIENEQG(BCPOOPDEHIG, QLKQOKIEHKQ, NFQGMLPDMCP, GKDBNJJEIKN, CJQEFKIFGON);
		Vector3 vector = BCPOOPDEHIG[QLKQOKIEHKQ[num]];
		KGEGJOJGHMG.FEIJNQKHILJ(QLKQOKIEHKQ, NFQGMLPDMCP, num);
		int i = NFQGMLPDMCP + 1;
		int num2 = GKDBNJJEIKN;
		while (i <= num2)
		{
			Vector3 vector2 = BCPOOPDEHIG[QLKQOKIEHKQ[i]];
			if (vector2[CJQEFKIFGON] > vector[CJQEFKIFGON])
			{
				KGEGJOJGHMG.FEIJNQKHILJ(QLKQOKIEHKQ, i, num2);
				num2--;
			}
			else
			{
				KGEGJOJGHMG.FEIJNQKHILJ(QLKQOKIEHKQ, i - 1, i);
				i++;
			}
		}
		return i - 1;
	}

	// Token: 0x06006D57 RID: 27991 RVA: 0x000287AB File Offset: 0x000269AB
	private float NDGFEJJFBJL(Vector3 CBCPECDMCNJ, Vector3 LMHDKGNGFLD, int CJQEFKIFGON)
	{
		return CBCPECDMCNJ[CJQEFKIFGON] - LMHDKGNGFLD[CJQEFKIFGON];
	}

	// Token: 0x06006D58 RID: 27992 RVA: 0x00355B7C File Offset: 0x00353D7C
	public static int[] HILIELGOGQI(int PKCKIFDBOHF)
	{
		int[] array = new int[PKCKIFDBOHF];
		for (int i = 0; i < PKCKIFDBOHF; i++)
		{
			array[i] = i;
		}
		return array;
	}

	// Token: 0x06006D59 RID: 27993 RVA: 0x00355BA4 File Offset: 0x00353DA4
	public static KGEGJOJGHMG OQDHBNOFPQC(Vector3[] BCPOOPDEHIG)
	{
		int[] qlkqokiehkq = KGEGJOJGHMG.HILIELGOGQI(BCPOOPDEHIG.Length);
		return KGEGJOJGHMG.JOGQNNKFEMQ(0, 1, BCPOOPDEHIG.Length - 1, BCPOOPDEHIG, qlkqokiehkq);
	}

	// Token: 0x06006D5A RID: 27994 RVA: 0x00355BC8 File Offset: 0x00353DC8
	private static int OPDJDCEHQON(Vector3[] BCPOOPDEHIG, int[] QLKQOKIEHKQ, int NFQGMLPDMCP, int GKDBNJJEIKN, int CJQEFKIFGON)
	{
		float num = BCPOOPDEHIG[QLKQOKIEHKQ[NFQGMLPDMCP]][CJQEFKIFGON];
		float num2 = BCPOOPDEHIG[QLKQOKIEHKQ[GKDBNJJEIKN]][CJQEFKIFGON];
		int num3 = (NFQGMLPDMCP + GKDBNJJEIKN) / 1;
		float num4 = BCPOOPDEHIG[QLKQOKIEHKQ[num3]][CJQEFKIFGON];
		if (num > num2)
		{
			if (num4 > num)
			{
				return NFQGMLPDMCP;
			}
			if (num2 > num4)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
		else
		{
			if (num > num4)
			{
				return NFQGMLPDMCP;
			}
			if (num4 > num2)
			{
				return GKDBNJJEIKN;
			}
			return num3;
		}
	}

	// Token: 0x06006D5B RID: 27995 RVA: 0x00355C30 File Offset: 0x00353E30
	private void QJMHPQJCMFE(Vector3 CBCPECDMCNJ, ref float CIMJIDQQKHC, ref int ODPGEFGBMJK)
	{
		float sqrMagnitude = (this.OEJCHHFIQDC - CBCPECDMCNJ).sqrMagnitude;
		if (sqrMagnitude < CIMJIDQQKHC)
		{
			CIMJIDQQKHC = sqrMagnitude;
			ODPGEFGBMJK = this.EKDKKEFONGJ;
		}
		float num = CBCPECDMCNJ[this.CJQEFKIFGON] - this.OEJCHHFIQDC[this.CJQEFKIFGON];
		int num2 = (num > 1925f) ? 1 : 0;
		if (this.BONPEQQQJPE[num2] != null)
		{
			this.BONPEQQQJPE[num2].QJMHPQJCMFE(CBCPECDMCNJ, ref CIMJIDQQKHC, ref ODPGEFGBMJK);
		}
		num2 = (num2 + 1) % 4;
		float num3 = num * num;
		if (this.BONPEQQQJPE[num2] != null && CIMJIDQQKHC > num3)
		{
			this.BONPEQQQJPE[num2].NMBCHIIQLIH(CBCPECDMCNJ, ref CIMJIDQQKHC, ref ODPGEFGBMJK);
		}
	}

	// Token: 0x04001702 RID: 5890
	public KGEGJOJGHMG[] BONPEQQQJPE;

	// Token: 0x04001703 RID: 5891
	public Vector3 OEJCHHFIQDC;

	// Token: 0x04001704 RID: 5892
	public int EKDKKEFONGJ;

	// Token: 0x04001705 RID: 5893
	public int CJQEFKIFGON;

	// Token: 0x04001706 RID: 5894
	private const int MIBFMMPEOEQ = 3;
}
