using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000342 RID: 834
public static class BDKMFJQPGGE
{
	// Token: 0x06006DF9 RID: 28153 RVA: 0x003591D8 File Offset: 0x003573D8
	public static float QEDDMFBJBQO(float GBEBKHGGPKM, float QNDMNIDPICH, float BGBMIEJJQKC, GMNJJQQPEDB DPQFDCNLLPC = GMNJJQQPEDB.EaseInOut)
	{
		BGBMIEJJQKC = Mathf.Clamp01(BGBMIEJJQKC);
		switch (DPQFDCNLLPC)
		{
		case GMNJJQQPEDB.EaseInOut:
			return Mathf.Lerp(GBEBKHGGPKM, QNDMNIDPICH, BGBMIEJJQKC * BGBMIEJJQKC * (3f - 2f * BGBMIEJJQKC));
		case GMNJJQQPEDB.EaseOut:
			return Mathf.Lerp(GBEBKHGGPKM, QNDMNIDPICH, Mathf.Sin(BGBMIEJJQKC * 3.14159274f * 0.5f));
		case GMNJJQQPEDB.EaseIn:
			return Mathf.Lerp(GBEBKHGGPKM, QNDMNIDPICH, 1f - Mathf.Cos(BGBMIEJJQKC * 3.14159274f * 0.5f));
		default:
			return Mathf.Lerp(GBEBKHGGPKM, QNDMNIDPICH, BGBMIEJJQKC);
		}
	}

	// Token: 0x06006DFA RID: 28154 RVA: 0x0035925C File Offset: 0x0035745C
	public static float EEHCCCJBEOG(float BQDICNJGMFM, float HJIHKKKQENG, float BDBEMIIKNLE, float KDEMMJKGDJM, float GPFIDEJEMEG)
	{
		float num = GPFIDEJEMEG * KDEMMJKGDJM;
		float num2 = (BDBEMIIKNLE - HJIHKKKQENG) / num;
		float num3 = BQDICNJGMFM - HJIHKKKQENG + num2;
		return BDBEMIIKNLE - num2 + num3 * Mathf.Exp(-num);
	}

	// Token: 0x06006DFB RID: 28155 RVA: 0x00028D1F File Offset: 0x00026F1F
	public static float PMNDBPOMOGG(this float BGBMIEJJQKC, float GEJDPFEOQKI, float IEHMQJGCKKE, float IDHDCCNONGO, float MDQGFKKIIHQ)
	{
		return Mathf.Clamp((BGBMIEJJQKC - GEJDPFEOQKI) / (IEHMQJGCKKE - GEJDPFEOQKI) * (MDQGFKKIIHQ - IDHDCCNONGO) + IDHDCCNONGO, IDHDCCNONGO, MDQGFKKIIHQ);
	}

	// Token: 0x06006DFC RID: 28156 RVA: 0x00028D37 File Offset: 0x00026F37
	public static void OIHLBBIFQHE(Vector3 NKKGPNPGDEM, Vector3 PECKDHFNOKI, float INEHJPQEIBL = 0.25f, float JGIBPQPMNPI = 20f)
	{
		Gizmos.DrawRay(NKKGPNPGDEM, PECKDHFNOKI);
		BDKMFJQPGGE.DMHMGGGOJCE(true, NKKGPNPGDEM, PECKDHFNOKI, Gizmos.color, INEHJPQEIBL, JGIBPQPMNPI);
	}

	// Token: 0x06006DFD RID: 28157 RVA: 0x00028D4F File Offset: 0x00026F4F
	public static void OIHLBBIFQHE(Vector3 NKKGPNPGDEM, Vector3 PECKDHFNOKI, Color CEGFBBHMKOE, float INEHJPQEIBL = 0.25f, float JGIBPQPMNPI = 20f)
	{
		Gizmos.DrawRay(NKKGPNPGDEM, PECKDHFNOKI);
		BDKMFJQPGGE.DMHMGGGOJCE(true, NKKGPNPGDEM, PECKDHFNOKI, CEGFBBHMKOE, INEHJPQEIBL, JGIBPQPMNPI);
	}

	// Token: 0x06006DFE RID: 28158 RVA: 0x00028D64 File Offset: 0x00026F64
	public static void QQQHBGILBKQ(Vector3 NKKGPNPGDEM, Vector3 PECKDHFNOKI, float INEHJPQEIBL = 0.25f, float JGIBPQPMNPI = 20f)
	{
		Debug.DrawRay(NKKGPNPGDEM, PECKDHFNOKI);
		BDKMFJQPGGE.DMHMGGGOJCE(false, NKKGPNPGDEM, PECKDHFNOKI, Gizmos.color, INEHJPQEIBL, JGIBPQPMNPI);
	}

	// Token: 0x06006DFF RID: 28159 RVA: 0x00028D7C File Offset: 0x00026F7C
	public static void QQQHBGILBKQ(Vector3 NKKGPNPGDEM, Vector3 PECKDHFNOKI, Color CEGFBBHMKOE, float INEHJPQEIBL = 0.25f, float JGIBPQPMNPI = 20f)
	{
		Debug.DrawRay(NKKGPNPGDEM, PECKDHFNOKI, CEGFBBHMKOE);
		BDKMFJQPGGE.DMHMGGGOJCE(false, NKKGPNPGDEM, PECKDHFNOKI, CEGFBBHMKOE, INEHJPQEIBL, JGIBPQPMNPI);
	}

	// Token: 0x06006E00 RID: 28160 RVA: 0x00359288 File Offset: 0x00357488
	private static void DMHMGGGOJCE(bool QICPPFHPQEM, Vector3 NKKGPNPGDEM, Vector3 PECKDHFNOKI, Color CEGFBBHMKOE, float INEHJPQEIBL = 0.25f, float JGIBPQPMNPI = 20f)
	{
		if (PECKDHFNOKI == Vector3.zero)
		{
			return;
		}
		Vector3 a = Quaternion.LookRotation(PECKDHFNOKI) * Quaternion.Euler(JGIBPQPMNPI, 0f, 0f) * Vector3.back;
		Vector3 a2 = Quaternion.LookRotation(PECKDHFNOKI) * Quaternion.Euler(-JGIBPQPMNPI, 0f, 0f) * Vector3.back;
		Vector3 a3 = Quaternion.LookRotation(PECKDHFNOKI) * Quaternion.Euler(0f, JGIBPQPMNPI, 0f) * Vector3.back;
		Vector3 a4 = Quaternion.LookRotation(PECKDHFNOKI) * Quaternion.Euler(0f, -JGIBPQPMNPI, 0f) * Vector3.back;
		if (QICPPFHPQEM)
		{
			Gizmos.color = CEGFBBHMKOE;
			Gizmos.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a * INEHJPQEIBL);
			Gizmos.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a2 * INEHJPQEIBL);
			Gizmos.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a3 * INEHJPQEIBL);
			Gizmos.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a4 * INEHJPQEIBL);
		}
		else
		{
			Debug.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a * INEHJPQEIBL, CEGFBBHMKOE);
			Debug.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a2 * INEHJPQEIBL, CEGFBBHMKOE);
			Debug.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a3 * INEHJPQEIBL, CEGFBBHMKOE);
			Debug.DrawRay(NKKGPNPGDEM + PECKDHFNOKI, a4 * INEHJPQEIBL, CEGFBBHMKOE);
		}
	}

	// Token: 0x06006E01 RID: 28161 RVA: 0x00028D92 File Offset: 0x00026F92
	public static bool GFNGFMKPNPI(float ECHMFPQNBMC, float IBMINEHKPFF, float PCJPIFLLNGM = 0.02f)
	{
		return Mathf.Abs(ECHMFPQNBMC - IBMINEHKPFF) < PCJPIFLLNGM;
	}

	// Token: 0x06006E02 RID: 28162 RVA: 0x003593F0 File Offset: 0x003575F0
	public static Vector2 MLQHJBIONCC(Camera KCOMMGMLLEE, float FKDGEKNHQFB = 10f)
	{
		float x;
		float num;
		if (KCOMMGMLLEE.orthographic)
		{
			if (KCOMMGMLLEE.orthographicSize <= 0.001f)
			{
				return Vector2.zero;
			}
			Vector3 b = KCOMMGMLLEE.ViewportToWorldPoint(new Vector3(0f, 0f, KCOMMGMLLEE.nearClipPlane));
			Vector3 vector = KCOMMGMLLEE.ViewportToWorldPoint(new Vector3(1f, 0f, KCOMMGMLLEE.nearClipPlane));
			Vector3 a = KCOMMGMLLEE.ViewportToWorldPoint(new Vector3(1f, 1f, KCOMMGMLLEE.nearClipPlane));
			x = (vector - b).magnitude;
			num = (a - vector).magnitude;
		}
		else
		{
			num = 2f * Mathf.Abs(FKDGEKNHQFB) * Mathf.Tan(KCOMMGMLLEE.fieldOfView * 0.5f * 0.0174532924f);
			x = num * KCOMMGMLLEE.aspect;
		}
		return new Vector2(x, num);
	}

	// Token: 0x06006E03 RID: 28163 RVA: 0x003594D8 File Offset: 0x003576D8
	public static Vector3 BMBFNKHCOMN(IList<Vector3> QPFMIFONHOF)
	{
		Vector3 vector = Vector3.zero;
		for (int i = 0; i < QPFMIFONHOF.Count; i++)
		{
			vector += QPFMIFONHOF[i];
		}
		return vector;
	}

	// Token: 0x06006E04 RID: 28164 RVA: 0x00028D9F File Offset: 0x00026F9F
	public static float EFJBNBNMJMH(float QPFMIFONHOF, float CKKPKDOPOGJ)
	{
		return Mathf.Round(Mathf.Round(QPFMIFONHOF / CKKPKDOPOGJ) * CKKPKDOPOGJ / CKKPKDOPOGJ) * CKKPKDOPOGJ;
	}

	// Token: 0x06006E05 RID: 28165 RVA: 0x00028DB4 File Offset: 0x00026FB4
	public static bool NDDFJBMCIDB(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, float BMNIENFBILI, float JFJBDKHFOLC)
	{
		return BMNIENFBILI >= DGKOIGOLHDM - KJGMGPCEJJD * 0.5f && BMNIENFBILI <= DGKOIGOLHDM + KJGMGPCEJJD * 0.5f && JFJBDKHFOLC >= DDLQKFDFMCJ - DFKQMMIQDOO * 0.5f && JFJBDKHFOLC <= DDLQKFDFMCJ + DFKQMMIQDOO * 0.5f;
	}

	// Token: 0x06006E06 RID: 28166 RVA: 0x00028DED File Offset: 0x00026FED
	public static bool KHGFDLKPNIQ(float DGKOIGOLHDM, float DDLQKFDFMCJ, float HLDJHBLPJJF, float BMNIENFBILI, float JFJBDKHFOLC)
	{
		return (BMNIENFBILI - DGKOIGOLHDM) * (BMNIENFBILI - DGKOIGOLHDM) + (JFJBDKHFOLC - DDLQKFDFMCJ) * (JFJBDKHFOLC - DDLQKFDFMCJ) < HLDJHBLPJJF * HLDJHBLPJJF;
	}
}
