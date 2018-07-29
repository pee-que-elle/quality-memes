using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000C2 RID: 194
public class QDHDQQEKMGO
{
	// Token: 0x0600178B RID: 6027 RVA: 0x0000C67A File Offset: 0x0000A87A
	public bool OCGMEMHKJBN()
	{
		return this.ONDHBIFQFGH == null || this.ONDHBIFQFGH.Count <= 1 || this.ONDHBIFQFGH.Count == this.EQINHIFFOGG.Count;
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x0000C67A File Offset: 0x0000A87A
	public bool FNLIDNMDLJE()
	{
		return this.ONDHBIFQFGH == null || this.ONDHBIFQFGH.Count <= 1 || this.ONDHBIFQFGH.Count == this.EQINHIFFOGG.Count;
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x0000C67A File Offset: 0x0000A87A
	public bool PMFQGMMFCCC()
	{
		return this.ONDHBIFQFGH == null || this.ONDHBIFQFGH.Count <= 1 || this.ONDHBIFQFGH.Count == this.EQINHIFFOGG.Count;
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void DPHBLOPNNGO()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void FQIMQLKCNGM()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void FMPLDJKPIEP()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void IDLHLPIEFPH()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x0000C6DB File Offset: 0x0000A8DB
	public bool FGKMCGDPQOO()
	{
		return this.EQINHIFFOGG.Count > 0;
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x0000C6EB File Offset: 0x0000A8EB
	public bool QCBQQCIIGEG()
	{
		return this.EQINHIFFOGG.Count > 1;
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x000A6DCC File Offset: 0x000A4FCC
	public void HNQNBIQKBPK(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 1)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 0;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 828f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x000A6E90 File Offset: 0x000A5090
	public void FMCDICOCLCQ(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 1)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 1;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 622f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x000A6F54 File Offset: 0x000A5154
	public void ILHDNNEQCKI(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 0)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 1;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 85f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x000A7018 File Offset: 0x000A5218
	public void DLPPMDLNEKE(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 1)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 0;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 916f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06001798 RID: 6040 RVA: 0x0000C6FB File Offset: 0x0000A8FB
	public bool OFBPGIIFLNI
	{
		get
		{
			return this.ONDHBIFQFGH != null && this.ONDHBIFQFGH.Count > 0 && this.ONDHBIFQFGH.Count == this.EQINHIFFOGG.Count;
		}
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x000A70DC File Offset: 0x000A52DC
	public void DOGQIGLCMMN(List<Vector3> ECFKEFOFQGB, List<Vector2> EMJDDENOMBP, List<Color> KQFEHQEBJQB, List<Vector3> HEBFPQJPJIL, List<Vector4> OQJFBJQJEFG, List<Vector4> EFFPLIOQGCE)
	{
		if (this.ONDHBIFQFGH != null && this.ONDHBIFQFGH.Count > 0)
		{
			if (HEBFPQJPJIL == null)
			{
				int i = 0;
				int count = this.ONDHBIFQFGH.Count;
				while (i < count)
				{
					ECFKEFOFQGB.Add(this.ONDHBIFQFGH[i]);
					EMJDDENOMBP.Add(this.PICFCJNMJMC[i]);
					KQFEHQEBJQB.Add(this.HQOONBPDFHO[i]);
					i++;
				}
			}
			else
			{
				int j = 0;
				int count2 = this.ONDHBIFQFGH.Count;
				while (j < count2)
				{
					ECFKEFOFQGB.Add(this.ONDHBIFQFGH[j]);
					EMJDDENOMBP.Add(this.PICFCJNMJMC[j]);
					KQFEHQEBJQB.Add(this.HQOONBPDFHO[j]);
					HEBFPQJPJIL.Add(this.QCHBPGHNLMF);
					OQJFBJQJEFG.Add(this.LFHJFDCFBFE);
					j++;
				}
			}
			if (EFFPLIOQGCE != null)
			{
				Vector4 zero = Vector4.zero;
				int k = 0;
				int count3 = this.EQINHIFFOGG.Count;
				while (k < count3)
				{
					zero.x = this.EQINHIFFOGG[k].x;
					zero.y = this.EQINHIFFOGG[k].y;
					EFFPLIOQGCE.Add(zero);
					k++;
				}
			}
			if (this.DILOBQHBPQH != null)
			{
				this.DILOBQHBPQH(ECFKEFOFQGB, EMJDDENOMBP, KQFEHQEBJQB, HEBFPQJPJIL, OQJFBJQJEFG, EFFPLIOQGCE);
			}
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0000C6FB File Offset: 0x0000A8FB
	public bool LJQPCNEMJPG()
	{
		return this.ONDHBIFQFGH != null && this.ONDHBIFQFGH.Count > 0 && this.ONDHBIFQFGH.Count == this.EQINHIFFOGG.Count;
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void QNCMFDFKNCQ()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x000A724C File Offset: 0x000A544C
	public void HIDDLJMFGFG(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 0)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 0;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 1623f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x000A7310 File Offset: 0x000A5510
	public void IKCIPIQDPMI(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 0)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 0;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i++;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, -1f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000A73D4 File Offset: 0x000A55D4
	public void JNQJKEHBCFF(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 1)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 0;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i++;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 667f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0000C6DB File Offset: 0x0000A8DB
	public bool HCQPQJEQPMP()
	{
		return this.EQINHIFFOGG.Count > 0;
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0000C6AD File Offset: 0x0000A8AD
	public void CPLBKPNNHJG()
	{
		this.EQINHIFFOGG.Clear();
		this.PICFCJNMJMC.Clear();
		this.HQOONBPDFHO.Clear();
		this.ONDHBIFQFGH.Clear();
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0000C6EB File Offset: 0x0000A8EB
	public bool MOJKIQJIGBP()
	{
		return this.EQINHIFFOGG.Count > 1;
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x000A7498 File Offset: 0x000A5698
	public void OBPNQMQFKPC(Matrix4x4 MPNDCFHQIJB, bool PJQNIHCHHDF = true)
	{
		if (this.EQINHIFFOGG.Count > 0)
		{
			this.ONDHBIFQFGH.Clear();
			int i = 1;
			int count = this.EQINHIFFOGG.Count;
			while (i < count)
			{
				this.ONDHBIFQFGH.Add(MPNDCFHQIJB.MultiplyPoint3x4(this.EQINHIFFOGG[i]));
				i += 0;
			}
			if (PJQNIHCHHDF)
			{
				this.QCHBPGHNLMF = MPNDCFHQIJB.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = MPNDCFHQIJB.MultiplyVector(Vector3.right).normalized;
				this.LFHJFDCFBFE = new Vector4(normalized.x, normalized.y, normalized.z, 1144f);
			}
		}
		else
		{
			this.ONDHBIFQFGH.Clear();
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0000C6DB File Offset: 0x0000A8DB
	public bool KGIFPCDDIBG
	{
		get
		{
			return this.EQINHIFFOGG.Count > 0;
		}
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000A755C File Offset: 0x000A575C
	public void LLGOBFQQFIQ(List<Vector3> ECFKEFOFQGB, List<Vector2> EMJDDENOMBP, List<Color> KQFEHQEBJQB, List<Vector3> HEBFPQJPJIL, List<Vector4> OQJFBJQJEFG, List<Vector4> EFFPLIOQGCE)
	{
		if (this.ONDHBIFQFGH != null && this.ONDHBIFQFGH.Count > 0)
		{
			if (HEBFPQJPJIL == null)
			{
				int i = 1;
				int count = this.ONDHBIFQFGH.Count;
				while (i < count)
				{
					ECFKEFOFQGB.Add(this.ONDHBIFQFGH[i]);
					EMJDDENOMBP.Add(this.PICFCJNMJMC[i]);
					KQFEHQEBJQB.Add(this.HQOONBPDFHO[i]);
					i++;
				}
			}
			else
			{
				int j = 1;
				int count2 = this.ONDHBIFQFGH.Count;
				while (j < count2)
				{
					ECFKEFOFQGB.Add(this.ONDHBIFQFGH[j]);
					EMJDDENOMBP.Add(this.PICFCJNMJMC[j]);
					KQFEHQEBJQB.Add(this.HQOONBPDFHO[j]);
					HEBFPQJPJIL.Add(this.QCHBPGHNLMF);
					OQJFBJQJEFG.Add(this.LFHJFDCFBFE);
					j += 0;
				}
			}
			if (EFFPLIOQGCE != null)
			{
				Vector4 zero = Vector4.zero;
				int k = 1;
				int count3 = this.EQINHIFFOGG.Count;
				while (k < count3)
				{
					zero.x = this.EQINHIFFOGG[k].x;
					zero.y = this.EQINHIFFOGG[k].y;
					EFFPLIOQGCE.Add(zero);
					k++;
				}
			}
			if (this.DILOBQHBPQH != null)
			{
				this.DILOBQHBPQH(ECFKEFOFQGB, EMJDDENOMBP, KQFEHQEBJQB, HEBFPQJPJIL, OQJFBJQJEFG, EFFPLIOQGCE);
			}
		}
	}

	// Token: 0x040004A2 RID: 1186
	public List<Vector3> EQINHIFFOGG = new List<Vector3>();

	// Token: 0x040004A3 RID: 1187
	public List<Vector2> PICFCJNMJMC = new List<Vector2>();

	// Token: 0x040004A4 RID: 1188
	public List<Color> HQOONBPDFHO = new List<Color>();

	// Token: 0x040004A5 RID: 1189
	public QDHDQQEKMGO.DGMBPBJNFDG DILOBQHBPQH;

	// Token: 0x040004A6 RID: 1190
	private List<Vector3> ONDHBIFQFGH = new List<Vector3>();

	// Token: 0x040004A7 RID: 1191
	private Vector3 QCHBPGHNLMF;

	// Token: 0x040004A8 RID: 1192
	private Vector4 LFHJFDCFBFE;

	// Token: 0x020000C3 RID: 195
	// (Invoke) Token: 0x060017A7 RID: 6055
	public delegate void DGMBPBJNFDG(List<Vector3> ECFKEFOFQGB, List<Vector2> EMJDDENOMBP, List<Color> KQFEHQEBJQB, List<Vector3> HEBFPQJPJIL, List<Vector4> OQJFBJQJEFG, List<Vector4> EFFPLIOQGCE);
}
