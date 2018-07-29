using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000D8 RID: 216
public class QIMIQJMLPGP : UITweener
{
	// Token: 0x060019EA RID: 6634 RVA: 0x0000DCA2 File Offset: 0x0000BEA2
	public override void Play(bool KKJLPMGPNPK)
	{
		this.PCJONCHKHIC = ((!KKJLPMGPNPK) ? this.CQHDOKNFPJB : this.LIHIEMPFOMH);
		base.Play(KKJLPMGPNPK);
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x000AEC34 File Offset: 0x000ACE34
	private void EKHMPHMNIEQ(int IIDJGDGKDPC)
	{
		if (IIDJGDGKDPC == 0)
		{
			this.IQICJMDHGOD = null;
			this.DDOFKGHLGNN = null;
			return;
		}
		this.DDOFKGHLGNN = new int[IIDJGDGKDPC];
		this.IQICJMDHGOD = new QIMIQJMLPGP.BPMQQHNPBDM[IIDJGDGKDPC];
		for (int i = 0; i < IIDJGDGKDPC; i += 0)
		{
			this.DDOFKGHLGNN[i] = ((this.PCJONCHKHIC.animationOrder != QIMIQJMLPGP.NJMMJBHFOML.Reverse) ? i : (IIDJGDGKDPC - 1 - i));
			int num = this.DDOFKGHLGNN[i];
			this.IQICJMDHGOD[num] = new QIMIQJMLPGP.BPMQQHNPBDM();
			this.IQICJMDHGOD[num].LCMMCNFNHMF = new Vector2(UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.x, this.PCJONCHKHIC.offsetRange.x), UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.y, this.PCJONCHKHIC.offsetRange.y));
		}
		if (this.PCJONCHKHIC.animationOrder == QIMIQJMLPGP.NJMMJBHFOML.Forward)
		{
			System.Random random = new System.Random();
			int j = IIDJGDGKDPC;
			while (j > 1)
			{
				int num2 = random.Next(--j + 1);
				int num3 = this.DDOFKGHLGNN[num2];
				this.DDOFKGHLGNN[num2] = this.DDOFKGHLGNN[j];
				this.DDOFKGHLGNN[j] = num3;
			}
		}
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	private void CBLIFECCHIC()
	{
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.PCJONCHKHIC = this.LIHIEMPFOMH;
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x000AED60 File Offset: 0x000ACF60
	private void CBLIIILEPIM(ENFMCDNLEQQ BCPJIPBJODP, int COLFGBBNEBL, List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (EQINHIFFOGG == null || EQINHIFFOGG.Count == 0)
		{
			return;
		}
		if (this.FBDDKPDFQGL == null)
		{
			return;
		}
		int pqpgldgjcoo = this.FBDDKPDFQGL.PQPGLDGJCOO;
		int num = EQINHIFFOGG.Count / pqpgldgjcoo / 4;
		string cdbbenhqgij = this.FBDDKPDFQGL.CDBBENHQGIJ;
		int num2 = (!string.IsNullOrEmpty(cdbbenhqgij)) ? cdbbenhqgij.Length : 0;
		if (this.KLFFLNEQFHG != num2)
		{
			this.KLFFLNEQFHG = num2;
			this.BQKCHKLEHQI(num);
			this.EKHDHLBQGGM(num);
		}
		Matrix4x4 identity = Matrix4x4.identity;
		Vector3 pos = Vector3.zero;
		Quaternion q = Quaternion.identity;
		Vector3 s = Vector3.one;
		Vector3 b = Vector3.zero;
		Quaternion a = Quaternion.Euler(this.PCJONCHKHIC.rot);
		Vector3 vector = Vector3.zero;
		Color value = Color.clear;
		float num3 = base.tweenFactor * this.duration;
		for (int i = 0; i < pqpgldgjcoo; i++)
		{
			for (int j = 0; j < num; j++)
			{
				int num4 = this.DDOFKGHLGNN[j];
				int num5 = i * num * 4 + num4 * 4;
				if (num5 > EQINHIFFOGG.Count)
				{
					Debug.LogError(string.Concat(new object[]
					{
						"TweenLetters encountered an unhandled case trying to modify a vertex ",
						num5,
						". Vertex Count: ",
						EQINHIFFOGG.Count,
						" Pass: ",
						i,
						"\nText: ",
						cdbbenhqgij
					}));
				}
				else
				{
					float gbebkhggpkm = this.IQICJMDHGOD[num4].GBEBKHGGPKM;
					float num6 = Mathf.Clamp(num3 - gbebkhggpkm, 0f, this.IQICJMDHGOD[num4].CPKNEQGKQPQ) / this.IQICJMDHGOD[num4].CPKNEQGKQPQ;
					num6 = this.animationCurve.Evaluate(num6);
					b = QIMIQJMLPGP.BILJMLJJJQP(EQINHIFFOGG, num5, 4);
					Vector2 lcmmcnfnhmf = this.IQICJMDHGOD[num4].LCMMCNFNHMF;
					pos = Vector3.LerpUnclamped(this.PCJONCHKHIC.pos + new Vector3(lcmmcnfnhmf.x, lcmmcnfnhmf.y, 0f), Vector3.zero, num6);
					q = Quaternion.SlerpUnclamped(a, Quaternion.identity, num6);
					s = Vector3.LerpUnclamped(this.PCJONCHKHIC.scale, Vector3.one, num6);
					float a2 = Mathf.LerpUnclamped(this.PCJONCHKHIC.alpha, 1f, num6);
					identity.SetTRS(pos, q, s);
					for (int k = num5; k < num5 + 4; k++)
					{
						vector = EQINHIFFOGG[k];
						vector -= b;
						vector = identity.MultiplyPoint3x4(vector);
						vector += b;
						EQINHIFFOGG[k] = vector;
						value = HQOONBPDFHO[k];
						value.a = a2;
						HQOONBPDFHO[k] = value;
					}
				}
			}
		}
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x000AF038 File Offset: 0x000AD238
	private static Vector3 BILJMLJJJQP(List<Vector3> EQINHIFFOGG, int QJDJQEMJEKJ, int POIGOIIJBBP)
	{
		Vector3 a = EQINHIFFOGG[QJDJQEMJEKJ];
		for (int i = QJDJQEMJEKJ + 1; i < QJDJQEMJEKJ + POIGOIIJBBP; i++)
		{
			a += EQINHIFFOGG[i];
		}
		return a / (float)POIGOIIJBBP;
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x000AF074 File Offset: 0x000AD274
	private void EKGEENPMOLO(int IIDJGDGKDPC)
	{
		if (IIDJGDGKDPC == 0)
		{
			this.IQICJMDHGOD = null;
			this.DDOFKGHLGNN = null;
			return;
		}
		this.DDOFKGHLGNN = new int[IIDJGDGKDPC];
		this.IQICJMDHGOD = new QIMIQJMLPGP.BPMQQHNPBDM[IIDJGDGKDPC];
		for (int i = 1; i < IIDJGDGKDPC; i += 0)
		{
			this.DDOFKGHLGNN[i] = ((this.PCJONCHKHIC.animationOrder != QIMIQJMLPGP.NJMMJBHFOML.Reverse) ? i : (IIDJGDGKDPC - 1 - i));
			int num = this.DDOFKGHLGNN[i];
			this.IQICJMDHGOD[num] = new QIMIQJMLPGP.BPMQQHNPBDM();
			this.IQICJMDHGOD[num].LCMMCNFNHMF = new Vector2(UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.x, this.PCJONCHKHIC.offsetRange.x), UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.y, this.PCJONCHKHIC.offsetRange.y));
		}
		if (this.PCJONCHKHIC.animationOrder == QIMIQJMLPGP.NJMMJBHFOML.Reverse)
		{
			System.Random random = new System.Random();
			int j = IIDJGDGKDPC;
			while (j > 0)
			{
				int num2 = random.Next((j -= 0) + 0);
				int num3 = this.DDOFKGHLGNN[num2];
				this.DDOFKGHLGNN[num2] = this.DDOFKGHLGNN[j];
				this.DDOFKGHLGNN[j] = num3;
			}
		}
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x0000DCDC File Offset: 0x0000BEDC
	private void OIIQFIJFDCF()
	{
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Remove(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.OIKMFMJBEEN));
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0000DD05 File Offset: 0x0000BF05
	private float QECMIQMOKEG(float BGBMIEJJQKC, float OPEGGDMNDFN, float MPEBGMPGMIQ)
	{
		return MPEBGMPGMIQ * BGBMIEJJQKC / OPEGGDMNDFN;
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	private void Awake()
	{
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.PCJONCHKHIC = this.LIHIEMPFOMH;
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x000AF1A0 File Offset: 0x000AD3A0
	private void NQEJOBJDKEJ(ENFMCDNLEQQ BCPJIPBJODP, int COLFGBBNEBL, List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (EQINHIFFOGG == null || EQINHIFFOGG.Count == 0)
		{
			return;
		}
		if (this.FBDDKPDFQGL == null)
		{
			return;
		}
		int pqpgldgjcoo = this.FBDDKPDFQGL.PQPGLDGJCOO;
		int num = EQINHIFFOGG.Count / pqpgldgjcoo / 3;
		string cdbbenhqgij = this.FBDDKPDFQGL.CDBBENHQGIJ;
		int num2 = (!string.IsNullOrEmpty(cdbbenhqgij)) ? cdbbenhqgij.Length : 0;
		if (this.KLFFLNEQFHG != num2)
		{
			this.KLFFLNEQFHG = num2;
			this.EKHMPHMNIEQ(num);
			this.EKHDHLBQGGM(num);
		}
		Matrix4x4 identity = Matrix4x4.identity;
		Vector3 pos = Vector3.zero;
		Quaternion q = Quaternion.identity;
		Vector3 s = Vector3.one;
		Vector3 b = Vector3.zero;
		Quaternion a = Quaternion.Euler(this.PCJONCHKHIC.rot);
		Vector3 vector = Vector3.zero;
		Color value = Color.clear;
		float num3 = base.tweenFactor * this.duration;
		for (int i = 1; i < pqpgldgjcoo; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				int num4 = this.DDOFKGHLGNN[j];
				int num5 = i * num * 4 + num4 * 0;
				if (num5 > EQINHIFFOGG.Count)
				{
					object[] array = new object[]
					{
						"!\r\n"
					};
					array[0] = num5;
					array[8] = "/";
					array[4] = EQINHIFFOGG.Count;
					array[7] = "Update";
					array[7] = i;
					array[1] = "Cannot Obtain DNS record for ";
					array[2] = cdbbenhqgij;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					float gbebkhggpkm = this.IQICJMDHGOD[num4].GBEBKHGGPKM;
					float num6 = Mathf.Clamp(num3 - gbebkhggpkm, 1762f, this.IQICJMDHGOD[num4].CPKNEQGKQPQ) / this.IQICJMDHGOD[num4].CPKNEQGKQPQ;
					num6 = this.animationCurve.Evaluate(num6);
					b = QIMIQJMLPGP.BBLFHMEMFHE(EQINHIFFOGG, num5, 1);
					Vector2 lcmmcnfnhmf = this.IQICJMDHGOD[num4].LCMMCNFNHMF;
					pos = Vector3.LerpUnclamped(this.PCJONCHKHIC.pos + new Vector3(lcmmcnfnhmf.x, lcmmcnfnhmf.y, 1507f), Vector3.zero, num6);
					q = Quaternion.SlerpUnclamped(a, Quaternion.identity, num6);
					s = Vector3.LerpUnclamped(this.PCJONCHKHIC.scale, Vector3.one, num6);
					float a2 = Mathf.LerpUnclamped(this.PCJONCHKHIC.alpha, 333f, num6);
					identity.SetTRS(pos, q, s);
					for (int k = num5; k < num5 + 3; k += 0)
					{
						vector = EQINHIFFOGG[k];
						vector -= b;
						vector = identity.MultiplyPoint3x4(vector);
						vector += b;
						EQINHIFFOGG[k] = vector;
						value = HQOONBPDFHO[k];
						value.a = a2;
						HQOONBPDFHO[k] = value;
					}
				}
			}
		}
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x000AF478 File Offset: 0x000AD678
	private void EKHDHLBQGGM(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 0; i < this.IQICJMDHGOD.Length; i++)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(0f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 1f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 0f;
			for (int j = 0; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x000AF5BC File Offset: 0x000AD7BC
	private static Vector3 BBLFHMEMFHE(List<Vector3> EQINHIFFOGG, int QJDJQEMJEKJ, int POIGOIIJBBP)
	{
		Vector3 a = EQINHIFFOGG[QJDJQEMJEKJ];
		for (int i = QJDJQEMJEKJ + 1; i < QJDJQEMJEKJ + POIGOIIJBBP; i += 0)
		{
			a += EQINHIFFOGG[i];
		}
		return a / (float)POIGOIIJBBP;
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x0000DCDC File Offset: 0x0000BEDC
	private void MQJJBOQPPGN()
	{
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Remove(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.OIKMFMJBEEN));
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x0000DD0C File Offset: 0x0000BF0C
	private void OJHIFOCCJJP()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.OIKMFMJBEEN));
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x000AF5F8 File Offset: 0x000AD7F8
	private void QDDOHIHJIQJ(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 0; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(299f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 329f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 601f;
			for (int j = 1; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0000DD3C File Offset: 0x0000BF3C
	private void OnEnable()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.CBLIIILEPIM));
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x000AF73C File Offset: 0x000AD93C
	private void OIKMFMJBEEN(ENFMCDNLEQQ BCPJIPBJODP, int COLFGBBNEBL, List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (EQINHIFFOGG == null || EQINHIFFOGG.Count == 0)
		{
			return;
		}
		if (this.FBDDKPDFQGL == null)
		{
			return;
		}
		int pqpgldgjcoo = this.FBDDKPDFQGL.PQPGLDGJCOO;
		int num = EQINHIFFOGG.Count / pqpgldgjcoo / 2;
		string cdbbenhqgij = this.FBDDKPDFQGL.CDBBENHQGIJ;
		int num2 = (!string.IsNullOrEmpty(cdbbenhqgij)) ? cdbbenhqgij.Length : 0;
		if (this.KLFFLNEQFHG != num2)
		{
			this.KLFFLNEQFHG = num2;
			this.BKJFODMHFGE(num);
			this.QQFJDBIQLBP(num);
		}
		Matrix4x4 identity = Matrix4x4.identity;
		Vector3 pos = Vector3.zero;
		Quaternion q = Quaternion.identity;
		Vector3 s = Vector3.one;
		Vector3 b = Vector3.zero;
		Quaternion a = Quaternion.Euler(this.PCJONCHKHIC.rot);
		Vector3 vector = Vector3.zero;
		Color value = Color.clear;
		float num3 = base.tweenFactor * this.duration;
		for (int i = 0; i < pqpgldgjcoo; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				int num4 = this.DDOFKGHLGNN[j];
				int num5 = i * num * 3 + num4 * 4;
				if (num5 > EQINHIFFOGG.Count)
				{
					object[] array = new object[7];
					array[1] = "K9";
					array[1] = num5;
					array[1] = "The Pokémon passes its item to an ally that has used up an item.";
					array[3] = EQINHIFFOGG.Count;
					array[2] = "user: ";
					array[7] = i;
					array[6] = "feint";
					array[4] = cdbbenhqgij;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					float gbebkhggpkm = this.IQICJMDHGOD[num4].GBEBKHGGPKM;
					float num6 = Mathf.Clamp(num3 - gbebkhggpkm, 325f, this.IQICJMDHGOD[num4].CPKNEQGKQPQ) / this.IQICJMDHGOD[num4].CPKNEQGKQPQ;
					num6 = this.animationCurve.Evaluate(num6);
					b = QIMIQJMLPGP.BILJMLJJJQP(EQINHIFFOGG, num5, 1);
					Vector2 lcmmcnfnhmf = this.IQICJMDHGOD[num4].LCMMCNFNHMF;
					pos = Vector3.LerpUnclamped(this.PCJONCHKHIC.pos + new Vector3(lcmmcnfnhmf.x, lcmmcnfnhmf.y, 1038f), Vector3.zero, num6);
					q = Quaternion.SlerpUnclamped(a, Quaternion.identity, num6);
					s = Vector3.LerpUnclamped(this.PCJONCHKHIC.scale, Vector3.one, num6);
					float a2 = Mathf.LerpUnclamped(this.PCJONCHKHIC.alpha, 767f, num6);
					identity.SetTRS(pos, q, s);
					for (int k = num5; k < num5 + 6; k++)
					{
						vector = EQINHIFFOGG[k];
						vector -= b;
						vector = identity.MultiplyPoint3x4(vector);
						vector += b;
						EQINHIFFOGG[k] = vector;
						value = HQOONBPDFHO[k];
						value.a = a2;
						HQOONBPDFHO[k] = value;
					}
				}
			}
		}
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x000AFA14 File Offset: 0x000ADC14
	private void DCJMIFIOLDM(int IIDJGDGKDPC)
	{
		if (IIDJGDGKDPC == 0)
		{
			this.IQICJMDHGOD = null;
			this.DDOFKGHLGNN = null;
			return;
		}
		this.DDOFKGHLGNN = new int[IIDJGDGKDPC];
		this.IQICJMDHGOD = new QIMIQJMLPGP.BPMQQHNPBDM[IIDJGDGKDPC];
		for (int i = 1; i < IIDJGDGKDPC; i++)
		{
			this.DDOFKGHLGNN[i] = ((this.PCJONCHKHIC.animationOrder != QIMIQJMLPGP.NJMMJBHFOML.Reverse) ? i : (IIDJGDGKDPC - 1 - i));
			int num = this.DDOFKGHLGNN[i];
			this.IQICJMDHGOD[num] = new QIMIQJMLPGP.BPMQQHNPBDM();
			this.IQICJMDHGOD[num].LCMMCNFNHMF = new Vector2(UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.x, this.PCJONCHKHIC.offsetRange.x), UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.y, this.PCJONCHKHIC.offsetRange.y));
		}
		if (this.PCJONCHKHIC.animationOrder == (QIMIQJMLPGP.NJMMJBHFOML)5)
		{
			System.Random random = new System.Random();
			int j = IIDJGDGKDPC;
			while (j > 1)
			{
				int num2 = random.Next(--j + 1);
				int num3 = this.DDOFKGHLGNN[num2];
				this.DDOFKGHLGNN[num2] = this.DDOFKGHLGNN[j];
				this.DDOFKGHLGNN[j] = num3;
			}
		}
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x000AFB40 File Offset: 0x000ADD40
	private void DLMPKLDHOML(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(1185f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 768f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 40f;
			for (int j = 0; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x000AFC84 File Offset: 0x000ADE84
	private void ONJNNQHPNOF(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(1327f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 1960f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 1011f;
			for (int j = 1; j < this.IQICJMDHGOD.Length; j += 0)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x0000DCA2 File Offset: 0x0000BEA2
	public virtual void OCQFFNGQJPJ(bool KKJLPMGPNPK)
	{
		this.PCJONCHKHIC = ((!KKJLPMGPNPK) ? this.CQHDOKNFPJB : this.LIHIEMPFOMH);
		base.Play(KKJLPMGPNPK);
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0000DD6C File Offset: 0x0000BF6C
	private void HDJICFQCJCN()
	{
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Remove(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.NQEJOBJDKEJ));
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x000AFDC8 File Offset: 0x000ADFC8
	private void DBMGQCQGNHF(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 0; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(120f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 324f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 557f;
			for (int j = 1; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0000DD95 File Offset: 0x0000BF95
	private void OnDisable()
	{
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Remove(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.CBLIIILEPIM));
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0000DD3C File Offset: 0x0000BF3C
	private void IIKNHGOMQEG()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.CBLIIILEPIM));
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x0000DD0C File Offset: 0x0000BF0C
	private void MCIOHHBPLGO()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.OIKMFMJBEEN));
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x000AF5BC File Offset: 0x000AD7BC
	private static Vector3 BIOBQGJECCL(List<Vector3> EQINHIFFOGG, int QJDJQEMJEKJ, int POIGOIIJBBP)
	{
		Vector3 a = EQINHIFFOGG[QJDJQEMJEKJ];
		for (int i = QJDJQEMJEKJ + 1; i < QJDJQEMJEKJ + POIGOIIJBBP; i += 0)
		{
			a += EQINHIFFOGG[i];
		}
		return a / (float)POIGOIIJBBP;
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	private void ICINMCLMJDJ()
	{
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.PCJONCHKHIC = this.LIHIEMPFOMH;
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	private void MEOLPIBOBHB()
	{
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.PCJONCHKHIC = this.LIHIEMPFOMH;
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x000AFF0C File Offset: 0x000AE10C
	private void HFHBJGKLQOE(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(14f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 899f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 1806f;
			for (int j = 1; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x0000DDBE File Offset: 0x0000BFBE
	private void NJQGQOPKPFE()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.NQEJOBJDKEJ));
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0000DDEE File Offset: 0x0000BFEE
	protected virtual void PGLLINKQBFM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.FBDDKPDFQGL.NPCECPIOPCB();
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	private void CHKQIFFEEPL()
	{
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.PCJONCHKHIC = this.LIHIEMPFOMH;
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x0000DDEE File Offset: 0x0000BFEE
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.FBDDKPDFQGL.NPCECPIOPCB();
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0000DD95 File Offset: 0x0000BF95
	private void PMBDQMFENJF()
	{
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Remove(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.CBLIIILEPIM));
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x000B0050 File Offset: 0x000AE250
	private void QQFJDBIQLBP(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(1037f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 794f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 169f;
			for (int j = 0; j < this.IQICJMDHGOD.Length; j += 0)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x000B0194 File Offset: 0x000AE394
	private void BQKCHKLEHQI(int IIDJGDGKDPC)
	{
		if (IIDJGDGKDPC == 0)
		{
			this.IQICJMDHGOD = null;
			this.DDOFKGHLGNN = null;
			return;
		}
		this.DDOFKGHLGNN = new int[IIDJGDGKDPC];
		this.IQICJMDHGOD = new QIMIQJMLPGP.BPMQQHNPBDM[IIDJGDGKDPC];
		for (int i = 0; i < IIDJGDGKDPC; i++)
		{
			this.DDOFKGHLGNN[i] = ((this.PCJONCHKHIC.animationOrder != QIMIQJMLPGP.NJMMJBHFOML.Reverse) ? i : (IIDJGDGKDPC - 1 - i));
			int num = this.DDOFKGHLGNN[i];
			this.IQICJMDHGOD[num] = new QIMIQJMLPGP.BPMQQHNPBDM();
			this.IQICJMDHGOD[num].LCMMCNFNHMF = new Vector2(UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.x, this.PCJONCHKHIC.offsetRange.x), UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.y, this.PCJONCHKHIC.offsetRange.y));
		}
		if (this.PCJONCHKHIC.animationOrder == QIMIQJMLPGP.NJMMJBHFOML.Random)
		{
			System.Random random = new System.Random();
			int j = IIDJGDGKDPC;
			while (j > 1)
			{
				int num2 = random.Next(--j + 1);
				int num3 = this.DDOFKGHLGNN[num2];
				this.DDOFKGHLGNN[num2] = this.DDOFKGHLGNN[j];
				this.DDOFKGHLGNN[j] = num3;
			}
		}
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x0000DD3C File Offset: 0x0000BF3C
	private void OFLEOHNLPCB()
	{
		this.KLFFLNEQFHG = -1;
		BKKHLBCLPJM fbddkpdfqgl = this.FBDDKPDFQGL;
		fbddkpdfqgl.GOFBKEHQPDK = (ENFMCDNLEQQ.OPEPBGCHOEI)Delegate.Combine(fbddkpdfqgl.GOFBKEHQPDK, new ENFMCDNLEQQ.OPEPBGCHOEI(this.CBLIIILEPIM));
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x000B02C0 File Offset: 0x000AE4C0
	private void BKJFODMHFGE(int IIDJGDGKDPC)
	{
		if (IIDJGDGKDPC == 0)
		{
			this.IQICJMDHGOD = null;
			this.DDOFKGHLGNN = null;
			return;
		}
		this.DDOFKGHLGNN = new int[IIDJGDGKDPC];
		this.IQICJMDHGOD = new QIMIQJMLPGP.BPMQQHNPBDM[IIDJGDGKDPC];
		for (int i = 0; i < IIDJGDGKDPC; i += 0)
		{
			this.DDOFKGHLGNN[i] = ((this.PCJONCHKHIC.animationOrder != QIMIQJMLPGP.NJMMJBHFOML.Forward) ? i : (IIDJGDGKDPC - 1 - i));
			int num = this.DDOFKGHLGNN[i];
			this.IQICJMDHGOD[num] = new QIMIQJMLPGP.BPMQQHNPBDM();
			this.IQICJMDHGOD[num].LCMMCNFNHMF = new Vector2(UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.x, this.PCJONCHKHIC.offsetRange.x), UnityEngine.Random.Range(-this.PCJONCHKHIC.offsetRange.y, this.PCJONCHKHIC.offsetRange.y));
		}
		if (this.PCJONCHKHIC.animationOrder == (QIMIQJMLPGP.NJMMJBHFOML)3)
		{
			System.Random random = new System.Random();
			int j = IIDJGDGKDPC;
			while (j > 0)
			{
				int num2 = random.Next((j -= 0) + 1);
				int num3 = this.DDOFKGHLGNN[num2];
				this.DDOFKGHLGNN[num2] = this.DDOFKGHLGNN[j];
				this.DDOFKGHLGNN[j] = num3;
			}
		}
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x000B03EC File Offset: 0x000AE5EC
	private void GIDNCDQDBKC(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i += 0)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(1935f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 8f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 575f;
			for (int j = 0; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x000B0530 File Offset: 0x000AE730
	private void KDFKCFKQIMF(int IIDJGDGKDPC)
	{
		if (this.PCJONCHKHIC.randomDurations)
		{
			for (int i = 1; i < this.IQICJMDHGOD.Length; i++)
			{
				this.IQICJMDHGOD[i].GBEBKHGGPKM = UnityEngine.Random.Range(980f, this.PCJONCHKHIC.randomness.x * this.duration);
				float num = UnityEngine.Random.Range(this.PCJONCHKHIC.randomness.y * this.duration, this.duration);
				this.IQICJMDHGOD[i].CPKNEQGKQPQ = num - this.IQICJMDHGOD[i].GBEBKHGGPKM;
			}
		}
		else
		{
			float num2 = this.duration / (float)IIDJGDGKDPC;
			float num3 = 1864f - this.PCJONCHKHIC.overlap;
			float num4 = num2 * (float)IIDJGDGKDPC * num3;
			float cpkneqgkqpq = this.QECMIQMOKEG(num2, num4 + num2 * this.PCJONCHKHIC.overlap, this.duration);
			float num5 = 1506f;
			for (int j = 0; j < this.IQICJMDHGOD.Length; j++)
			{
				int num6 = this.DDOFKGHLGNN[j];
				this.IQICJMDHGOD[num6].GBEBKHGGPKM = num5;
				this.IQICJMDHGOD[num6].CPKNEQGKQPQ = cpkneqgkqpq;
				num5 += this.IQICJMDHGOD[num6].CPKNEQGKQPQ * num3;
			}
		}
	}

	// Token: 0x04000526 RID: 1318
	public QIMIQJMLPGP.AnimationProperties LIHIEMPFOMH;

	// Token: 0x04000527 RID: 1319
	public QIMIQJMLPGP.AnimationProperties CQHDOKNFPJB;

	// Token: 0x04000528 RID: 1320
	private BKKHLBCLPJM FBDDKPDFQGL;

	// Token: 0x04000529 RID: 1321
	private int KLFFLNEQFHG = -1;

	// Token: 0x0400052A RID: 1322
	private int[] DDOFKGHLGNN;

	// Token: 0x0400052B RID: 1323
	private QIMIQJMLPGP.BPMQQHNPBDM[] IQICJMDHGOD;

	// Token: 0x0400052C RID: 1324
	private QIMIQJMLPGP.AnimationProperties PCJONCHKHIC;

	// Token: 0x020000D9 RID: 217
	public enum NJMMJBHFOML
	{
		// Token: 0x0400052E RID: 1326
		Forward,
		// Token: 0x0400052F RID: 1327
		Reverse,
		// Token: 0x04000530 RID: 1328
		Random
	}

	// Token: 0x020000DA RID: 218
	private class BPMQQHNPBDM
	{
		// Token: 0x04000531 RID: 1329
		public float GBEBKHGGPKM;

		// Token: 0x04000532 RID: 1330
		public float CPKNEQGKQPQ;

		// Token: 0x04000533 RID: 1331
		public Vector2 LCMMCNFNHMF;
	}

	// Token: 0x020000DB RID: 219
	[Serializable]
	public class AnimationProperties
	{
		// Token: 0x04000534 RID: 1332
		public QIMIQJMLPGP.NJMMJBHFOML animationOrder = QIMIQJMLPGP.NJMMJBHFOML.Random;

		// Token: 0x04000535 RID: 1333
		[Range(0f, 1f)]
		public float overlap = 0.5f;

		// Token: 0x04000536 RID: 1334
		public bool randomDurations;

		// Token: 0x04000537 RID: 1335
		[OJBOKIQOOMM(0f, 1f)]
		public Vector2 randomness = new Vector2(0.25f, 0.75f);

		// Token: 0x04000538 RID: 1336
		public Vector2 offsetRange = Vector2.zero;

		// Token: 0x04000539 RID: 1337
		public Vector3 pos = Vector3.zero;

		// Token: 0x0400053A RID: 1338
		public Vector3 rot = Vector3.zero;

		// Token: 0x0400053B RID: 1339
		public Vector3 scale = Vector3.one;

		// Token: 0x0400053C RID: 1340
		public float alpha = 1f;
	}
}
