using System;
using UnityEngine;

// Token: 0x02000352 RID: 850
[HelpURL("http://www.procamera2d.com/user-guide/extension-limit-speed/")]
public class NOIMMBKKHJB : BNEFIOCKQOE, LIJCFDMDDIJ
{
	// Token: 0x060070C9 RID: 28873 RVA: 0x0036BD94 File Offset: 0x00369F94
	public Vector3 MKKGHGDNEOK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070CA RID: 28874 RVA: 0x0036BE1C File Offset: 0x0036A01C
	public Vector3 KIFBIQOCKMD(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1510f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070CB RID: 28875 RVA: 0x0036BEA4 File Offset: 0x0036A0A4
	public Vector3 QPPOKHDNFIK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1933f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070CC RID: 28876 RVA: 0x0002962B File Offset: 0x0002782B
	public void MNJJNHLOBLD(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070CD RID: 28877 RVA: 0x0036BF2C File Offset: 0x0036A12C
	public Vector3 EFPGFGJDEEL(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1677f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070CE RID: 28878 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void HLHPCLEMCKI()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070CF RID: 28879 RVA: 0x0002962B File Offset: 0x0002782B
	public void KKGOIJPIMPJ(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070D0 RID: 28880 RVA: 0x00029634 File Offset: 0x00027834
	public int BQEIJOMKPNN()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070D1 RID: 28881 RVA: 0x00028E44 File Offset: 0x00027044
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x060070D2 RID: 28882 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void COFPBILHHNO()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070D3 RID: 28883 RVA: 0x0036BFB4 File Offset: 0x0036A1B4
	public Vector3 LHHNJFMGHPP(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1020f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070D4 RID: 28884 RVA: 0x0002962B File Offset: 0x0002782B
	public void EIHFQNNLCPB(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070D5 RID: 28885 RVA: 0x0036C03C File Offset: 0x0036A23C
	public Vector3 MODKNKDHDKK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 939f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070D7 RID: 28887 RVA: 0x00029634 File Offset: 0x00027834
	public int MJOMNNIGKNF()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070D8 RID: 28888 RVA: 0x0002962B File Offset: 0x0002782B
	public void HLJGPGIGCIH(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070D9 RID: 28889 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void FIMPCGCJHIC()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x060070DA RID: 28890 RVA: 0x00028E65 File Offset: 0x00027065
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070DB RID: 28891 RVA: 0x0036C0C4 File Offset: 0x0036A2C4
	public Vector3 HHMJGDKJKDC(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 336f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070DC RID: 28892 RVA: 0x0002962B File Offset: 0x0002782B
	public void BPOFHODLOMF(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x060070DD RID: 28893 RVA: 0x00029634 File Offset: 0x00027834
	// (set) Token: 0x060070DE RID: 28894 RVA: 0x0002962B File Offset: 0x0002782B
	public int DPGOQJMLMNF
	{
		get
		{
			return this.IEDKDIJGNNO;
		}
		set
		{
			this.IEDKDIJGNNO = value;
		}
	}

	// Token: 0x060070DF RID: 28895 RVA: 0x0002962B File Offset: 0x0002782B
	public void NLGHGCOEHJG(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070E0 RID: 28896 RVA: 0x0002962B File Offset: 0x0002782B
	public void FDMCHDJHLCD(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070E2 RID: 28898 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void BHJIKJLLIQQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x060070E3 RID: 28899 RVA: 0x00029634 File Offset: 0x00027834
	public int LNGBPFJCBFK()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x060070E4 RID: 28900 RVA: 0x0036C14C File Offset: 0x0036A34C
	public Vector3 FMFCIFFEFHH(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 1734f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070E5 RID: 28901 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void JENKEGOEEHO()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x060070E6 RID: 28902 RVA: 0x0002962B File Offset: 0x0002782B
	public void LNJOCGDDQPC(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070E7 RID: 28903 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void DFLGFQLDIPI()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x060070E8 RID: 28904 RVA: 0x0002962B File Offset: 0x0002782B
	public void CFNGNNEMMPC(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x060070E9 RID: 28905 RVA: 0x0036C1D4 File Offset: 0x0036A3D4
	public Vector3 EIMNCGQGEKD(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		float num = 511f / GPFIDEJEMEG;
		float num2 = this.FKGNBCKJPQO(HELGNNDIDCI) * num;
		float num3 = this.JNBBJCLFFBB(HELGNNDIDCI) * num;
		if (this.GKLHFBPCMEJ)
		{
			num2 = Mathf.Clamp(num2, -this.ELIQDLOFMDP, this.ELIQDLOFMDP);
		}
		if (this.PBJLKHCHIGJ)
		{
			num3 = Mathf.Clamp(num3, -this.NEPPDNPFKDO, this.NEPPDNPFKDO);
		}
		return this.QMEMFMDBHLI(num2 * GPFIDEJEMEG, num3 * GPFIDEJEMEG);
	}

	// Token: 0x060070EA RID: 28906 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void NJGKJCIKBJD()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x04001807 RID: 6151
	public static string OPGNGFNJDDP = "Limit Speed";

	// Token: 0x04001808 RID: 6152
	public bool GKLHFBPCMEJ = true;

	// Token: 0x04001809 RID: 6153
	public float ELIQDLOFMDP = 2f;

	// Token: 0x0400180A RID: 6154
	public bool PBJLKHCHIGJ = true;

	// Token: 0x0400180B RID: 6155
	public float NEPPDNPFKDO = 2f;

	// Token: 0x0400180C RID: 6156
	private int IEDKDIJGNNO = 1000;
}
