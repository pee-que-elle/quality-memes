using System;
using System.Diagnostics;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public static class JNNGOIIKENH
{
	// Token: 0x0600155E RID: 5470 RVA: 0x0000B3C4 File Offset: 0x000095C4
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float GGJJLQLFKCE(float CGHQEHCBQHB, float BKMCCCGOGOM, float PJDGFDBEOOJ)
	{
		return CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + BKMCCCGOGOM * PJDGFDBEOOJ;
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x0000B3D3 File Offset: 0x000095D3
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int OFEGEKKQDDE(int QJFQOMOIOOI, int MJGGCLOGKFL)
	{
		return (QJFQOMOIOOI >= 0) ? ((QJFQOMOIOOI >= MJGGCLOGKFL) ? (MJGGCLOGKFL - 1) : QJFQOMOIOOI) : 0;
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x0000B3E6 File Offset: 0x000095E6
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int FNNIKCNKDIN(int QJFQOMOIOOI, int MJGGCLOGKFL)
	{
		if (MJGGCLOGKFL < 1)
		{
			return 0;
		}
		while (QJFQOMOIOOI < 0)
		{
			QJFQOMOIOOI += MJGGCLOGKFL;
		}
		while (QJFQOMOIOOI >= MJGGCLOGKFL)
		{
			QJFQOMOIOOI -= MJGGCLOGKFL;
		}
		return QJFQOMOIOOI;
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x0000B403 File Offset: 0x00009603
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float MCKGBIELBHK(float MPNNMHJBOPN)
	{
		while (MPNNMHJBOPN > 180f)
		{
			MPNNMHJBOPN -= 360f;
		}
		while (MPNNMHJBOPN < -180f)
		{
			MPNNMHJBOPN += 360f;
		}
		return MPNNMHJBOPN;
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x0000B42D File Offset: 0x0000962D
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float CLKOHCCPFLD(float QJFQOMOIOOI)
	{
		return QJFQOMOIOOI - (float)Mathf.FloorToInt(QJFQOMOIOOI);
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x000994F0 File Offset: 0x000976F0
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int FGFGLNBGBPB(char BFBMOIKCELJ)
	{
		switch (BFBMOIKCELJ)
		{
		case '0':
			return 0;
		case '1':
			return 1;
		case '2':
			return 2;
		case '3':
			return 3;
		case '4':
			return 4;
		case '5':
			return 5;
		case '6':
			return 6;
		case '7':
			return 7;
		case '8':
			return 8;
		case '9':
			return 9;
		case 'A':
			return 10;
		case 'B':
			return 11;
		case 'C':
			return 12;
		case 'D':
			return 13;
		case 'E':
			return 14;
		case 'F':
			return 15;
		}
		switch (BFBMOIKCELJ)
		{
		case 'a':
			return 10;
		case 'b':
			return 11;
		case 'c':
			return 12;
		case 'd':
			return 13;
		case 'e':
			return 14;
		case 'f':
			return 15;
		default:
			return 15;
		}
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x0000B438 File Offset: 0x00009638
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static char IHPOCJDIPPN(int PKCKIFDBOHF)
	{
		if (PKCKIFDBOHF > 15)
		{
			return 'F';
		}
		if (PKCKIFDBOHF < 10)
		{
			return (char)(48 + PKCKIFDBOHF);
		}
		return (char)(65 + PKCKIFDBOHF - 10);
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x0000B455 File Offset: 0x00009655
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string PBPNFGLLLMF(int PKCKIFDBOHF)
	{
		PKCKIFDBOHF &= 255;
		return PKCKIFDBOHF.ToString("X2");
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x0000B46C File Offset: 0x0000966C
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string FNGPCLGJDOL(int PKCKIFDBOHF)
	{
		PKCKIFDBOHF &= 16777215;
		return PKCKIFDBOHF.ToString("X6");
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x0000B483 File Offset: 0x00009683
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string DNPBDQJDOBQ(int PKCKIFDBOHF)
	{
		return PKCKIFDBOHF.ToString("X8");
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x000995B0 File Offset: 0x000977B0
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int HIHEBGODQPI(Color KQFEHQEBJQB)
	{
		int num = 0 | Mathf.RoundToInt(KQFEHQEBJQB.r * 255f) << 24;
		num |= Mathf.RoundToInt(KQFEHQEBJQB.g * 255f) << 16;
		num |= Mathf.RoundToInt(KQFEHQEBJQB.b * 255f) << 8;
		return num | Mathf.RoundToInt(KQFEHQEBJQB.a * 255f);
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x0009961C File Offset: 0x0009781C
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color JBLNHEQBEFO(int QJFQOMOIOOI)
	{
		float num = 0.003921569f;
		Color black = Color.black;
		black.r = num * (float)(QJFQOMOIOOI >> 24 & 255);
		black.g = num * (float)(QJFQOMOIOOI >> 16 & 255);
		black.b = num * (float)(QJFQOMOIOOI >> 8 & 255);
		black.a = num * (float)(QJFQOMOIOOI & 255);
		return black;
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x00099684 File Offset: 0x00097884
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static string HEEHFKEPONK(int QJFQOMOIOOI, int NOCODJGBDMH)
	{
		string text = string.Empty;
		int i = NOCODJGBDMH;
		while (i > 0)
		{
			if (i == 8 || i == 16 || i == 24)
			{
				text += " ";
			}
			text += (((QJFQOMOIOOI & 1 << --i) == 0) ? '0' : '1');
		}
		return text;
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x0000B491 File Offset: 0x00009691
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color NFHLPGFILIO(uint QJFQOMOIOOI)
	{
		return JNNGOIIKENH.JBLNHEQBEFO((int)QJFQOMOIOOI);
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x000996DC File Offset: 0x000978DC
	public static Rect NFBOPKDICDF(Rect QHFMJCLLHQL, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		Rect result = QHFMJCLLHQL;
		if ((float)KJGMGPCEJJD != 0f && (float)DFKQMMIQDOO != 0f)
		{
			result.xMin = QHFMJCLLHQL.xMin / (float)KJGMGPCEJJD;
			result.xMax = QHFMJCLLHQL.xMax / (float)KJGMGPCEJJD;
			result.yMin = 1f - QHFMJCLLHQL.yMax / (float)DFKQMMIQDOO;
			result.yMax = 1f - QHFMJCLLHQL.yMin / (float)DFKQMMIQDOO;
		}
		return result;
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00099750 File Offset: 0x00097950
	public static Rect JGKFJCNNBBE(Rect QHFMJCLLHQL, int KJGMGPCEJJD, int DFKQMMIQDOO, bool HNOCMPCEPIK)
	{
		Rect result = QHFMJCLLHQL;
		if (HNOCMPCEPIK)
		{
			result.xMin = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMin * (float)KJGMGPCEJJD);
			result.xMax = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMax * (float)KJGMGPCEJJD);
			result.yMin = (float)Mathf.RoundToInt((1f - QHFMJCLLHQL.yMax) * (float)DFKQMMIQDOO);
			result.yMax = (float)Mathf.RoundToInt((1f - QHFMJCLLHQL.yMin) * (float)DFKQMMIQDOO);
		}
		else
		{
			result.xMin = QHFMJCLLHQL.xMin * (float)KJGMGPCEJJD;
			result.xMax = QHFMJCLLHQL.xMax * (float)KJGMGPCEJJD;
			result.yMin = (1f - QHFMJCLLHQL.yMax) * (float)DFKQMMIQDOO;
			result.yMax = (1f - QHFMJCLLHQL.yMin) * (float)DFKQMMIQDOO;
		}
		return result;
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00099820 File Offset: 0x00097A20
	public static Rect IQFQEOFBQKM(Rect QHFMJCLLHQL)
	{
		QHFMJCLLHQL.xMin = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMin);
		QHFMJCLLHQL.yMin = (float)Mathf.RoundToInt(QHFMJCLLHQL.yMin);
		QHFMJCLLHQL.xMax = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMax);
		QHFMJCLLHQL.yMax = (float)Mathf.RoundToInt(QHFMJCLLHQL.yMax);
		return QHFMJCLLHQL;
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00099880 File Offset: 0x00097A80
	public static Rect IQFQEOFBQKM(Rect QHFMJCLLHQL, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		QHFMJCLLHQL = JNNGOIIKENH.JGKFJCNNBBE(QHFMJCLLHQL, KJGMGPCEJJD, DFKQMMIQDOO, true);
		QHFMJCLLHQL.xMin = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMin);
		QHFMJCLLHQL.yMin = (float)Mathf.RoundToInt(QHFMJCLLHQL.yMin);
		QHFMJCLLHQL.xMax = (float)Mathf.RoundToInt(QHFMJCLLHQL.xMax);
		QHFMJCLLHQL.yMax = (float)Mathf.RoundToInt(QHFMJCLLHQL.yMax);
		return JNNGOIIKENH.NFBOPKDICDF(QHFMJCLLHQL, KJGMGPCEJJD, DFKQMMIQDOO);
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x000998F0 File Offset: 0x00097AF0
	public static Vector2 JJLHMHPBOQG(Vector2 LCPIFEKBCDQ, Vector2 QLHCKCHLCIN, Vector2 NICIDGDIOQJ, Vector2 EGIOHPEHPKP)
	{
		Vector2 zero = Vector2.zero;
		float num = QLHCKCHLCIN.x - LCPIFEKBCDQ.x;
		float num2 = QLHCKCHLCIN.y - LCPIFEKBCDQ.y;
		float num3 = EGIOHPEHPKP.x - NICIDGDIOQJ.x;
		float num4 = EGIOHPEHPKP.y - NICIDGDIOQJ.y;
		if (num > num3)
		{
			float num5 = num - num3;
			NICIDGDIOQJ.x -= num5;
			EGIOHPEHPKP.x += num5;
		}
		if (num2 > num4)
		{
			float num6 = num2 - num4;
			NICIDGDIOQJ.y -= num6;
			EGIOHPEHPKP.y += num6;
		}
		if (LCPIFEKBCDQ.x < NICIDGDIOQJ.x)
		{
			zero.x += NICIDGDIOQJ.x - LCPIFEKBCDQ.x;
		}
		if (QLHCKCHLCIN.x > EGIOHPEHPKP.x)
		{
			zero.x -= QLHCKCHLCIN.x - EGIOHPEHPKP.x;
		}
		if (LCPIFEKBCDQ.y < NICIDGDIOQJ.y)
		{
			zero.y += NICIDGDIOQJ.y - LCPIFEKBCDQ.y;
		}
		if (QLHCKCHLCIN.y > EGIOHPEHPKP.y)
		{
			zero.y -= QLHCKCHLCIN.y - EGIOHPEHPKP.y;
		}
		return zero;
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x00099A50 File Offset: 0x00097C50
	public static Bounds LPPOONFLLOC(Transform HHMCPQQKIKB)
	{
		if (!(HHMCPQQKIKB != null))
		{
			return new Bounds(Vector3.zero, Vector3.zero);
		}
		ENFMCDNLEQQ[] componentsInChildren = HHMCPQQKIKB.GetComponentsInChildren<ENFMCDNLEQQ>();
		if (componentsInChildren.Length == 0)
		{
			return new Bounds(HHMCPQQKIKB.position, Vector3.zero);
		}
		Vector3 center = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		Vector3 point = new Vector3(float.MinValue, float.MinValue, float.MinValue);
		int i = 0;
		int num = componentsInChildren.Length;
		while (i < num)
		{
			ENFMCDNLEQQ enfmcdnleqq = componentsInChildren[i];
			if (enfmcdnleqq.enabled)
			{
				Vector3[] pmcnqichcle = enfmcdnleqq.PMCNQICHCLE;
				for (int j = 0; j < 4; j++)
				{
					Vector3 vector = pmcnqichcle[j];
					if (vector.x > point.x)
					{
						point.x = vector.x;
					}
					if (vector.y > point.y)
					{
						point.y = vector.y;
					}
					if (vector.z > point.z)
					{
						point.z = vector.z;
					}
					if (vector.x < center.x)
					{
						center.x = vector.x;
					}
					if (vector.y < center.y)
					{
						center.y = vector.y;
					}
					if (vector.z < center.z)
					{
						center.z = vector.z;
					}
				}
			}
			i++;
		}
		Bounds result = new Bounds(center, Vector3.zero);
		result.Encapsulate(point);
		return result;
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x0000B499 File Offset: 0x00009699
	public static Bounds HFMJNILQCMK(Transform HHMCPQQKIKB)
	{
		return JNNGOIIKENH.HFMJNILQCMK(HHMCPQQKIKB, HHMCPQQKIKB, false, true);
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x0000B4A4 File Offset: 0x000096A4
	public static Bounds HFMJNILQCMK(Transform HHMCPQQKIKB, bool LOCNFMJIOQQ)
	{
		return JNNGOIIKENH.HFMJNILQCMK(HHMCPQQKIKB, HHMCPQQKIKB, LOCNFMJIOQQ, true);
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x0000B4AF File Offset: 0x000096AF
	public static Bounds HFMJNILQCMK(Transform ENOQKGBPJKQ, Transform COPDMKMJGEJ)
	{
		return JNNGOIIKENH.HFMJNILQCMK(ENOQKGBPJKQ, COPDMKMJGEJ, false, true);
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00099BEC File Offset: 0x00097DEC
	public static Bounds HFMJNILQCMK(Transform ENOQKGBPJKQ, Transform COPDMKMJGEJ, bool LOCNFMJIOQQ, bool JMGHFHHEBMI = true)
	{
		if (COPDMKMJGEJ != null && ENOQKGBPJKQ != null)
		{
			bool flag = false;
			Matrix4x4 worldToLocalMatrix = ENOQKGBPJKQ.worldToLocalMatrix;
			Vector3 center = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 point = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			JNNGOIIKENH.HFMJNILQCMK(COPDMKMJGEJ, LOCNFMJIOQQ, true, ref worldToLocalMatrix, ref center, ref point, ref flag, JMGHFHHEBMI);
			if (flag)
			{
				Bounds result = new Bounds(center, Vector3.zero);
				result.Encapsulate(point);
				return result;
			}
		}
		return new Bounds(Vector3.zero, Vector3.zero);
	}

	// Token: 0x06001576 RID: 5494 RVA: 0x00099C7C File Offset: 0x00097E7C
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void HFMJNILQCMK(Transform COPDMKMJGEJ, bool LOCNFMJIOQQ, bool NGBQFCCKEBF, ref Matrix4x4 IHFCQEOOKCK, ref Vector3 FHMHGJIQJPI, ref Vector3 DHLJOEOGEMD, ref bool JFOPNBNHFEJ, bool JMGHFHHEBMI)
	{
		if (COPDMKMJGEJ == null)
		{
			return;
		}
		if (!LOCNFMJIOQQ && !IKBQNBHOJJB.PBBDNDMELHQ(COPDMKMJGEJ.gameObject))
		{
			return;
		}
		KQHJOLQLQBJ kqhjolqlqbj = (!NGBQFCCKEBF) ? COPDMKMJGEJ.GetComponent<KQHJOLQLQBJ>() : null;
		if (kqhjolqlqbj != null && !kqhjolqlqbj.enabled)
		{
			return;
		}
		if (kqhjolqlqbj != null && kqhjolqlqbj.GEOIDOMHKLJ != KMCGDKDIJIE.PDFPPCIHPMI.None)
		{
			Vector3[] pmcnqichcle = kqhjolqlqbj.PMCNQICHCLE;
			for (int i = 0; i < 4; i++)
			{
				Vector3 vector = IHFCQEOOKCK.MultiplyPoint3x4(pmcnqichcle[i]);
				if (vector.x > DHLJOEOGEMD.x)
				{
					DHLJOEOGEMD.x = vector.x;
				}
				if (vector.y > DHLJOEOGEMD.y)
				{
					DHLJOEOGEMD.y = vector.y;
				}
				if (vector.z > DHLJOEOGEMD.z)
				{
					DHLJOEOGEMD.z = vector.z;
				}
				if (vector.x < FHMHGJIQJPI.x)
				{
					FHMHGJIQJPI.x = vector.x;
				}
				if (vector.y < FHMHGJIQJPI.y)
				{
					FHMHGJIQJPI.y = vector.y;
				}
				if (vector.z < FHMHGJIQJPI.z)
				{
					FHMHGJIQJPI.z = vector.z;
				}
				JFOPNBNHFEJ = true;
			}
		}
		else
		{
			ENFMCDNLEQQ component = COPDMKMJGEJ.GetComponent<ENFMCDNLEQQ>();
			if (component != null && component.enabled)
			{
				Vector3[] pmcnqichcle2 = component.PMCNQICHCLE;
				for (int j = 0; j < 4; j++)
				{
					Vector3 vector2 = IHFCQEOOKCK.MultiplyPoint3x4(pmcnqichcle2[j]);
					if (vector2.x > DHLJOEOGEMD.x)
					{
						DHLJOEOGEMD.x = vector2.x;
					}
					if (vector2.y > DHLJOEOGEMD.y)
					{
						DHLJOEOGEMD.y = vector2.y;
					}
					if (vector2.z > DHLJOEOGEMD.z)
					{
						DHLJOEOGEMD.z = vector2.z;
					}
					if (vector2.x < FHMHGJIQJPI.x)
					{
						FHMHGJIQJPI.x = vector2.x;
					}
					if (vector2.y < FHMHGJIQJPI.y)
					{
						FHMHGJIQJPI.y = vector2.y;
					}
					if (vector2.z < FHMHGJIQJPI.z)
					{
						FHMHGJIQJPI.z = vector2.z;
					}
					JFOPNBNHFEJ = true;
				}
				if (!JMGHFHHEBMI)
				{
					return;
				}
			}
			int k = 0;
			int childCount = COPDMKMJGEJ.childCount;
			while (k < childCount)
			{
				JNNGOIIKENH.HFMJNILQCMK(COPDMKMJGEJ.GetChild(k), LOCNFMJIOQQ, false, ref IHFCQEOOKCK, ref FHMHGJIQJPI, ref DHLJOEOGEMD, ref JFOPNBNHFEJ, true);
				k++;
			}
		}
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00099F08 File Offset: 0x00098108
	public static Vector3 BNIGGHLNIOB(ref Vector3 NPDQBPLNQBI, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		if (GPFIDEJEMEG > 1f)
		{
			GPFIDEJEMEG = 1f;
		}
		float f = 1f - IEMGQKFCEHM * 0.001f;
		int num = Mathf.RoundToInt(GPFIDEJEMEG * 1000f);
		float num2 = Mathf.Pow(f, (float)num);
		Vector3 a = NPDQBPLNQBI * ((num2 - 1f) / Mathf.Log(f));
		NPDQBPLNQBI *= num2;
		return a * 0.06f;
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00099F80 File Offset: 0x00098180
	public static Vector2 BNIGGHLNIOB(ref Vector2 NPDQBPLNQBI, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		if (GPFIDEJEMEG > 1f)
		{
			GPFIDEJEMEG = 1f;
		}
		float f = 1f - IEMGQKFCEHM * 0.001f;
		int num = Mathf.RoundToInt(GPFIDEJEMEG * 1000f);
		float num2 = Mathf.Pow(f, (float)num);
		Vector2 a = NPDQBPLNQBI * ((num2 - 1f) / Mathf.Log(f));
		NPDQBPLNQBI *= num2;
		return a * 0.06f;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00099FF8 File Offset: 0x000981F8
	public static float IKCQOQFIENL(float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		if (GPFIDEJEMEG > 1f)
		{
			GPFIDEJEMEG = 1f;
		}
		int num = Mathf.RoundToInt(GPFIDEJEMEG * 1000f);
		GPFIDEJEMEG = 0.001f * IEMGQKFCEHM;
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			num2 = Mathf.Lerp(num2, 1f, GPFIDEJEMEG);
		}
		return num2;
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x0009A04C File Offset: 0x0009824C
	public static float IKCQOQFIENL(float CGHQEHCBQHB, float BKMCCCGOGOM, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		if (GPFIDEJEMEG > 1f)
		{
			GPFIDEJEMEG = 1f;
		}
		int num = Mathf.RoundToInt(GPFIDEJEMEG * 1000f);
		GPFIDEJEMEG = 0.001f * IEMGQKFCEHM;
		for (int i = 0; i < num; i++)
		{
			CGHQEHCBQHB = Mathf.Lerp(CGHQEHCBQHB, BKMCCCGOGOM, GPFIDEJEMEG);
		}
		return CGHQEHCBQHB;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x0000B4BA File Offset: 0x000096BA
	public static Vector2 IKCQOQFIENL(Vector2 CGHQEHCBQHB, Vector2 BKMCCCGOGOM, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		return Vector2.Lerp(CGHQEHCBQHB, BKMCCCGOGOM, JNNGOIIKENH.IKCQOQFIENL(IEMGQKFCEHM, GPFIDEJEMEG));
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x0000B4CA File Offset: 0x000096CA
	public static Vector3 IKCQOQFIENL(Vector3 CGHQEHCBQHB, Vector3 BKMCCCGOGOM, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		return Vector3.Lerp(CGHQEHCBQHB, BKMCCCGOGOM, JNNGOIIKENH.IKCQOQFIENL(IEMGQKFCEHM, GPFIDEJEMEG));
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x0000B4DA File Offset: 0x000096DA
	public static Quaternion IKCQOQFIENL(Quaternion CGHQEHCBQHB, Quaternion BKMCCCGOGOM, float IEMGQKFCEHM, float GPFIDEJEMEG)
	{
		return Quaternion.Slerp(CGHQEHCBQHB, BKMCCCGOGOM, JNNGOIIKENH.IKCQOQFIENL(IEMGQKFCEHM, GPFIDEJEMEG));
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x0009A098 File Offset: 0x00098298
	public static float JFPJKBNQKQG(float CGHQEHCBQHB, float BKMCCCGOGOM, float GNJFQDKGEMF)
	{
		float num = JNNGOIIKENH.MCKGBIELBHK(BKMCCCGOGOM - CGHQEHCBQHB);
		if (Mathf.Abs(num) > GNJFQDKGEMF)
		{
			num = GNJFQDKGEMF * Mathf.Sign(num);
		}
		return CGHQEHCBQHB + num;
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x0009A0C4 File Offset: 0x000982C4
	private static float FCEQGBGOGKH(Vector2 NKNELLKPMEB, Vector2 ECHMFPQNBMC, Vector2 IBMINEHKPFF)
	{
		float sqrMagnitude = (IBMINEHKPFF - ECHMFPQNBMC).sqrMagnitude;
		if (sqrMagnitude == 0f)
		{
			return (NKNELLKPMEB - ECHMFPQNBMC).magnitude;
		}
		float num = Vector2.Dot(NKNELLKPMEB - ECHMFPQNBMC, IBMINEHKPFF - ECHMFPQNBMC) / sqrMagnitude;
		if (num < 0f)
		{
			return (NKNELLKPMEB - ECHMFPQNBMC).magnitude;
		}
		if (num > 1f)
		{
			return (NKNELLKPMEB - IBMINEHKPFF).magnitude;
		}
		Vector2 b = ECHMFPQNBMC + num * (IBMINEHKPFF - ECHMFPQNBMC);
		return (NKNELLKPMEB - b).magnitude;
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x0009A168 File Offset: 0x00098368
	public static float GMICEGQDKCN(Vector2[] MHQHBKOPLMK, Vector2 OGLKGQQHFNG)
	{
		bool flag = false;
		int qjfqomoiooi = 4;
		for (int i = 0; i < 5; i++)
		{
			Vector3 vector = MHQHBKOPLMK[JNNGOIIKENH.FNNIKCNKDIN(i, 4)];
			Vector3 vector2 = MHQHBKOPLMK[JNNGOIIKENH.FNNIKCNKDIN(qjfqomoiooi, 4)];
			if (vector.y > OGLKGQQHFNG.y != vector2.y > OGLKGQQHFNG.y && OGLKGQQHFNG.x < (vector2.x - vector.x) * (OGLKGQQHFNG.y - vector.y) / (vector2.y - vector.y) + vector.x)
			{
				flag = !flag;
			}
			qjfqomoiooi = i;
		}
		if (!flag)
		{
			float num = -1f;
			for (int j = 0; j < 4; j++)
			{
				Vector3 v = MHQHBKOPLMK[j];
				Vector3 v2 = MHQHBKOPLMK[JNNGOIIKENH.FNNIKCNKDIN(j + 1, 4)];
				float num2 = JNNGOIIKENH.FCEQGBGOGKH(OGLKGQQHFNG, v, v2);
				if (num2 < num || num < 0f)
				{
					num = num2;
				}
			}
			return num;
		}
		return 0f;
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x0009A2A0 File Offset: 0x000984A0
	public static float GMICEGQDKCN(Vector3[] FEJLEONFOOK, Vector2 OGLKGQQHFNG, Camera EBINQJLDHPM)
	{
		Vector2[] array = new Vector2[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = EBINQJLDHPM.WorldToScreenPoint(FEJLEONFOOK[i]);
		}
		return JNNGOIIKENH.GMICEGQDKCN(array, OGLKGQQHFNG);
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x0009A2EC File Offset: 0x000984EC
	public static Vector2 QFOMHNELBIN(ENFMCDNLEQQ.GGBIQFIQQCM HPGECLPNNMN)
	{
		Vector2 zero = Vector2.zero;
		if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Top && HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Center)
		{
			if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Bottom)
			{
				if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight && HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Right)
				{
					if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight)
					{
						zero.x = 0f;
						goto IL_4A;
					}
				}
				zero.x = 1f;
				goto IL_4A;
			}
		}
		zero.x = 0.5f;
		IL_4A:
		if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Left && HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Center)
		{
			if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Right)
			{
				if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft && HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.Top)
				{
					if (HPGECLPNNMN != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight)
					{
						zero.y = 0f;
						return zero;
					}
				}
				zero.y = 1f;
				return zero;
			}
		}
		zero.y = 0.5f;
		return zero;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x0009A388 File Offset: 0x00098588
	public static ENFMCDNLEQQ.GGBIQFIQQCM PMLDKODQFPI(Vector2 LCMMCNFNHMF)
	{
		if (LCMMCNFNHMF.x == 0f)
		{
			if (LCMMCNFNHMF.y == 0f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft;
			}
			if (LCMMCNFNHMF.y == 1f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			}
			return ENFMCDNLEQQ.GGBIQFIQQCM.Left;
		}
		else if (LCMMCNFNHMF.x == 1f)
		{
			if (LCMMCNFNHMF.y == 0f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight;
			}
			if (LCMMCNFNHMF.y == 1f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.TopRight;
			}
			return ENFMCDNLEQQ.GGBIQFIQQCM.Right;
		}
		else
		{
			if (LCMMCNFNHMF.y == 0f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.Bottom;
			}
			if (LCMMCNFNHMF.y == 1f)
			{
				return ENFMCDNLEQQ.GGBIQFIQQCM.Top;
			}
			return ENFMCDNLEQQ.GGBIQFIQQCM.Center;
		}
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x0000B4EA File Offset: 0x000096EA
	public static void LOPQLFMQCKC(BLMNBILNMOE OKQHFQFJGCH, float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		JNNGOIIKENH.IMEBEBEGHQI(OKQHFQFJGCH, DGKOIGOLHDM, DDLQKFDFMCJ);
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x0009A418 File Offset: 0x00098618
	public static void IMEBEBEGHQI(BLMNBILNMOE QHFMJCLLHQL, float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		int num = Mathf.FloorToInt(DGKOIGOLHDM + 0.5f);
		int num2 = Mathf.FloorToInt(DDLQKFDFMCJ + 0.5f);
		Transform cgdfdphieng = QHFMJCLLHQL.CGDFDPHIENG;
		cgdfdphieng.localPosition += new Vector3((float)num, (float)num2);
		int num3 = 0;
		if (QHFMJCLLHQL.HJDMKGDLJEP.target)
		{
			num3++;
			QHFMJCLLHQL.HJDMKGDLJEP.absolute += num;
		}
		if (QHFMJCLLHQL.HKPCCMEEHDL.target)
		{
			num3++;
			QHFMJCLLHQL.HKPCCMEEHDL.absolute += num;
		}
		if (QHFMJCLLHQL.LBGJKGDECCN.target)
		{
			num3++;
			QHFMJCLLHQL.LBGJKGDECCN.absolute += num2;
		}
		if (QHFMJCLLHQL.NOPCJFECJDP.target)
		{
			num3++;
			QHFMJCLLHQL.NOPCJFECJDP.absolute += num2;
		}
		if (num3 != 0)
		{
			QHFMJCLLHQL.UpdateAnchors();
		}
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x0000B4F4 File Offset: 0x000096F4
	public static void LNQGLIIFOOC(ENFMCDNLEQQ OKQHFQFJGCH, ENFMCDNLEQQ.GGBIQFIQQCM OEJCHHFIQDC, float DGKOIGOLHDM, float DDLQKFDFMCJ, int QPKCPBJINBK, int IPGGCHLFDCF)
	{
		JNNGOIIKENH.LNQGLIIFOOC(OKQHFQFJGCH, OEJCHHFIQDC, DGKOIGOLHDM, DDLQKFDFMCJ, 2, 2, 100000, 100000);
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x0009A510 File Offset: 0x00098710
	public static void LNQGLIIFOOC(ENFMCDNLEQQ OKQHFQFJGCH, ENFMCDNLEQQ.GGBIQFIQQCM OEJCHHFIQDC, float DGKOIGOLHDM, float DDLQKFDFMCJ, int QPKCPBJINBK, int IPGGCHLFDCF, int ONEIONJNOPO, int DKLQCGDMQKB)
	{
		if (OEJCHHFIQDC == ENFMCDNLEQQ.GGBIQFIQQCM.Center)
		{
			int num = Mathf.RoundToInt(DGKOIGOLHDM - (float)OKQHFQFJGCH.KJGMGPCEJJD);
			int num2 = Mathf.RoundToInt(DDLQKFDFMCJ - (float)OKQHFQFJGCH.DFKQMMIQDOO);
			num -= (num & 1);
			num2 -= (num2 & 1);
			if ((num | num2) != 0)
			{
				num >>= 1;
				num2 >>= 1;
				JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, (float)(-(float)num), (float)(-(float)num2), (float)num, (float)num2, QPKCPBJINBK, IPGGCHLFDCF);
			}
			return;
		}
		Vector3 point = new Vector3(DGKOIGOLHDM, DDLQKFDFMCJ);
		point = Quaternion.Inverse(OKQHFQFJGCH.CGDFDPHIENG.localRotation) * point;
		switch (OEJCHHFIQDC)
		{
		case ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, point.x, 0f, 0f, point.y, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.Top:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, 0f, 0f, 0f, point.y, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.TopRight:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, 0f, 0f, point.x, point.y, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.Left:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, point.x, 0f, 0f, 0f, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.Right:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, 0f, 0f, point.x, 0f, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, point.x, point.y, 0f, 0f, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.Bottom:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, 0f, point.y, 0f, 0f, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		case ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight:
			JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, 0f, point.y, point.x, 0f, QPKCPBJINBK, IPGGCHLFDCF, ONEIONJNOPO, DKLQCGDMQKB);
			break;
		}
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x0009A700 File Offset: 0x00098900
	public static void EBNIMDGIINO(ENFMCDNLEQQ OKQHFQFJGCH, float DEQIFCDFMDK, float FPIPDOBGBQH, float JKDFCPKCQJP, float FNKCEOPHHKL)
	{
		JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, DEQIFCDFMDK, FPIPDOBGBQH, JKDFCPKCQJP, FNKCEOPHHKL, 2, 2, 100000, 100000);
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x0009A724 File Offset: 0x00098924
	public static void EBNIMDGIINO(ENFMCDNLEQQ OKQHFQFJGCH, float DEQIFCDFMDK, float FPIPDOBGBQH, float JKDFCPKCQJP, float FNKCEOPHHKL, int QPKCPBJINBK, int IPGGCHLFDCF)
	{
		JNNGOIIKENH.EBNIMDGIINO(OKQHFQFJGCH, DEQIFCDFMDK, FPIPDOBGBQH, JKDFCPKCQJP, FNKCEOPHHKL, QPKCPBJINBK, IPGGCHLFDCF, 100000, 100000);
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x0009A74C File Offset: 0x0009894C
	public static void EBNIMDGIINO(ENFMCDNLEQQ OKQHFQFJGCH, float DEQIFCDFMDK, float FPIPDOBGBQH, float JKDFCPKCQJP, float FNKCEOPHHKL, int QPKCPBJINBK, int IPGGCHLFDCF, int ONEIONJNOPO, int DKLQCGDMQKB)
	{
		Vector2 pfpekeldlcn = OKQHFQFJGCH.PFPEKELDLCN;
		Transform transform = OKQHFQFJGCH.CGDFDPHIENG;
		Quaternion localRotation = transform.localRotation;
		int num = Mathf.FloorToInt(DEQIFCDFMDK + 0.5f);
		int num2 = Mathf.FloorToInt(FPIPDOBGBQH + 0.5f);
		int num3 = Mathf.FloorToInt(JKDFCPKCQJP + 0.5f);
		int num4 = Mathf.FloorToInt(FNKCEOPHHKL + 0.5f);
		if (pfpekeldlcn.x == 0.5f && (num == 0 || num3 == 0))
		{
			num = num >> 1 << 1;
			num3 = num3 >> 1 << 1;
		}
		if (pfpekeldlcn.y == 0.5f && (num2 == 0 || num4 == 0))
		{
			num2 = num2 >> 1 << 1;
			num4 = num4 >> 1 << 1;
		}
		Vector3 vector = localRotation * new Vector3((float)num, (float)num4);
		Vector3 vector2 = localRotation * new Vector3((float)num3, (float)num4);
		Vector3 vector3 = localRotation * new Vector3((float)num, (float)num2);
		Vector3 vector4 = localRotation * new Vector3((float)num3, (float)num2);
		Vector3 vector5 = localRotation * new Vector3((float)num, 0f);
		Vector3 vector6 = localRotation * new Vector3((float)num3, 0f);
		Vector3 vector7 = localRotation * new Vector3(0f, (float)num4);
		Vector3 vector8 = localRotation * new Vector3(0f, (float)num2);
		Vector3 zero = Vector3.zero;
		if (pfpekeldlcn.x == 0f && pfpekeldlcn.y == 1f)
		{
			zero.x = vector.x;
			zero.y = vector.y;
		}
		else if (pfpekeldlcn.x == 1f && pfpekeldlcn.y == 0f)
		{
			zero.x = vector4.x;
			zero.y = vector4.y;
		}
		else if (pfpekeldlcn.x == 0f && pfpekeldlcn.y == 0f)
		{
			zero.x = vector3.x;
			zero.y = vector3.y;
		}
		else if (pfpekeldlcn.x == 1f && pfpekeldlcn.y == 1f)
		{
			zero.x = vector2.x;
			zero.y = vector2.y;
		}
		else if (pfpekeldlcn.x == 0f && pfpekeldlcn.y == 0.5f)
		{
			zero.x = vector5.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector5.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pfpekeldlcn.x == 1f && pfpekeldlcn.y == 0.5f)
		{
			zero.x = vector6.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector6.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pfpekeldlcn.x == 0.5f && pfpekeldlcn.y == 1f)
		{
			zero.x = vector7.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector7.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pfpekeldlcn.x == 0.5f && pfpekeldlcn.y == 0f)
		{
			zero.x = vector8.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector8.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pfpekeldlcn.x == 0.5f && pfpekeldlcn.y == 0.5f)
		{
			zero.x = (vector5.x + vector6.x + vector7.x + vector8.x) * 0.5f;
			zero.y = (vector7.y + vector8.y + vector5.y + vector6.y) * 0.5f;
		}
		QPKCPBJINBK = Mathf.Max(QPKCPBJINBK, OKQHFQFJGCH.QPKCPBJINBK);
		IPGGCHLFDCF = Mathf.Max(IPGGCHLFDCF, OKQHFQFJGCH.IPGGCHLFDCF);
		int num5 = OKQHFQFJGCH.KJGMGPCEJJD + num3 - num;
		int num6 = OKQHFQFJGCH.DFKQMMIQDOO + num4 - num2;
		Vector3 zero2 = Vector3.zero;
		int num7 = num5;
		if (num5 < QPKCPBJINBK)
		{
			num7 = QPKCPBJINBK;
		}
		else if (num5 > ONEIONJNOPO)
		{
			num7 = ONEIONJNOPO;
		}
		if (num5 != num7)
		{
			if (num != 0)
			{
				zero2.x -= Mathf.Lerp((float)(num7 - num5), 0f, pfpekeldlcn.x);
			}
			else
			{
				zero2.x += Mathf.Lerp(0f, (float)(num7 - num5), pfpekeldlcn.x);
			}
			num5 = num7;
		}
		int num8 = num6;
		if (num6 < IPGGCHLFDCF)
		{
			num8 = IPGGCHLFDCF;
		}
		else if (num6 > DKLQCGDMQKB)
		{
			num8 = DKLQCGDMQKB;
		}
		if (num6 != num8)
		{
			if (num2 != 0)
			{
				zero2.y -= Mathf.Lerp((float)(num8 - num6), 0f, pfpekeldlcn.y);
			}
			else
			{
				zero2.y += Mathf.Lerp(0f, (float)(num8 - num6), pfpekeldlcn.y);
			}
			num6 = num8;
		}
		if (pfpekeldlcn.x == 0.5f)
		{
			num5 = num5 >> 1 << 1;
		}
		if (pfpekeldlcn.y == 0.5f)
		{
			num6 = num6 >> 1 << 1;
		}
		Vector3 localPosition = transform.localPosition + zero + localRotation * zero2;
		transform.localPosition = localPosition;
		OKQHFQFJGCH.MJCOMHHDPGG(num5, num6);
		if (OKQHFQFJGCH.IEEHOJCLFDJ)
		{
			transform = transform.parent;
			float num9 = localPosition.x - pfpekeldlcn.x * (float)num5;
			float num10 = localPosition.y - pfpekeldlcn.y * (float)num6;
			if (OKQHFQFJGCH.HJDMKGDLJEP.target)
			{
				OKQHFQFJGCH.HJDMKGDLJEP.JHOBHJMCDIO(transform, num9);
			}
			if (OKQHFQFJGCH.HKPCCMEEHDL.target)
			{
				OKQHFQFJGCH.HKPCCMEEHDL.JHOBHJMCDIO(transform, num9 + (float)num5);
			}
			if (OKQHFQFJGCH.LBGJKGDECCN.target)
			{
				OKQHFQFJGCH.LBGJKGDECCN.QLDIPJFBNGC(transform, num10);
			}
			if (OKQHFQFJGCH.NOPCJFECJDP.target)
			{
				OKQHFQFJGCH.NOPCJFECJDP.QLDIPJFBNGC(transform, num10 + (float)num6);
			}
		}
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x0009ADE4 File Offset: 0x00098FE4
	public static int MPJPNENGCGH(float DFKQMMIQDOO)
	{
		float num = Screen.dpi;
		RuntimePlatform platform = Application.platform;
		if (num == 0f)
		{
			float num2;
			if (platform != RuntimePlatform.Android)
			{
				if (platform != RuntimePlatform.IPhonePlayer)
				{
					num2 = 96f;
					goto IL_2B;
				}
			}
			num2 = 160f;
			IL_2B:
			num = num2;
		}
		int num3 = Mathf.RoundToInt(DFKQMMIQDOO * (96f / num));
		if ((num3 & 1) == 1)
		{
			num3++;
		}
		return num3;
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x0009AE38 File Offset: 0x00099038
	public static Vector2 FIMJFJBMNCQ(Vector2 NKKGPNPGDEM, Transform ENOQKGBPJKQ)
	{
		int layer = ENOQKGBPJKQ.gameObject.layer;
		Camera camera = IKBQNBHOJJB.FINJNKFMLMO(layer);
		if (camera == null)
		{
			UnityEngine.Debug.LogWarning("No camera found for layer " + layer);
			return NKKGPNPGDEM;
		}
		Vector3 position = camera.ScreenToWorldPoint(NKKGPNPGDEM);
		return ENOQKGBPJKQ.InverseTransformPoint(position);
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x0009AE94 File Offset: 0x00099094
	public static Vector2 LDCOJBJQLPJ(Vector2 NKKGPNPGDEM, Transform ENOQKGBPJKQ)
	{
		int layer = ENOQKGBPJKQ.gameObject.layer;
		if (ENOQKGBPJKQ.parent != null)
		{
			ENOQKGBPJKQ = ENOQKGBPJKQ.parent;
		}
		Camera camera = IKBQNBHOJJB.FINJNKFMLMO(layer);
		if (camera == null)
		{
			UnityEngine.Debug.LogWarning("No camera found for layer " + layer);
			return NKKGPNPGDEM;
		}
		Vector3 vector = camera.ScreenToWorldPoint(NKKGPNPGDEM);
		return (!(ENOQKGBPJKQ != null)) ? vector : ENOQKGBPJKQ.InverseTransformPoint(vector);
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0000B50B File Offset: 0x0000970B
	public static Vector3 QBHIHKMDKOO(Vector3 PHCMBMCKQDC, Camera DIMBGJIBPMI, Camera JGPFIPEOQGG, Transform ENOQKGBPJKQ)
	{
		PHCMBMCKQDC = DIMBGJIBPMI.WorldToViewportPoint(PHCMBMCKQDC);
		PHCMBMCKQDC = JGPFIPEOQGG.ViewportToWorldPoint(PHCMBMCKQDC);
		if (ENOQKGBPJKQ == null)
		{
			return PHCMBMCKQDC;
		}
		ENOQKGBPJKQ = ENOQKGBPJKQ.parent;
		if (ENOQKGBPJKQ == null)
		{
			return PHCMBMCKQDC;
		}
		return ENOQKGBPJKQ.InverseTransformPoint(PHCMBMCKQDC);
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x0009AF10 File Offset: 0x00099110
	public static void JEGLBEGPJEM(this Transform HHMCPQQKIKB, Vector3 PHCMBMCKQDC, Camera DIMBGJIBPMI, Camera FPKGLLEPMDN)
	{
		PHCMBMCKQDC = DIMBGJIBPMI.WorldToViewportPoint(PHCMBMCKQDC);
		PHCMBMCKQDC = FPKGLLEPMDN.ViewportToWorldPoint(PHCMBMCKQDC);
		Transform parent = HHMCPQQKIKB.parent;
		HHMCPQQKIKB.localPosition = ((!(parent != null)) ? PHCMBMCKQDC : parent.InverseTransformPoint(PHCMBMCKQDC));
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x0009AF50 File Offset: 0x00099150
	public static void JEGLBEGPJEM(this Transform HHMCPQQKIKB, Vector3 PHCMBMCKQDC, Camera DIMBGJIBPMI)
	{
		Camera camera = IKBQNBHOJJB.FINJNKFMLMO(HHMCPQQKIKB.gameObject.layer);
		if (camera != null)
		{
			HHMCPQQKIKB.JEGLBEGPJEM(PHCMBMCKQDC, DIMBGJIBPMI, camera);
		}
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0009AF80 File Offset: 0x00099180
	public static void JEGLBEGPJEM(this Transform HHMCPQQKIKB, Transform ILBCCCBJNCL)
	{
		Camera camera = IKBQNBHOJJB.FINJNKFMLMO(HHMCPQQKIKB.gameObject.layer);
		Camera camera2 = IKBQNBHOJJB.FINJNKFMLMO(ILBCCCBJNCL.gameObject.layer);
		if (camera != null && camera2 != null)
		{
			HHMCPQQKIKB.JEGLBEGPJEM(ILBCCCBJNCL.position, camera2, camera);
		}
	}
}
