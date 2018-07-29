using System;
using UnityEngine;

// Token: 0x02000161 RID: 353
public class OJNJKONDHBB : UITweener
{
	// Token: 0x06002A9B RID: 10907 RVA: 0x0010A92C File Offset: 0x00108B2C
	public static OJNJKONDHBB EFBDEBOBBCH(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		OJNJKONDHBB ojnjkondhbb = UITweener.Begin<OJNJKONDHBB>(CGHIENBIHCO, CPKNEQGKQPQ, 1856f);
		ojnjkondhbb.CGHQEHCBQHB = ojnjkondhbb.OBKFLKOQCKG();
		ojnjkondhbb.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 354f)
		{
			ojnjkondhbb.Sample(1091f, true);
			ojnjkondhbb.enabled = false;
		}
		return ojnjkondhbb;
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x00014252 File Offset: 0x00012452
	public float CLHNFCQLOIQ()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.NBJPJBEQKPI;
		}
		return 502f;
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x0010A978 File Offset: 0x00108B78
	public static OJNJKONDHBB QNGIMPBJBHC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		OJNJKONDHBB ojnjkondhbb = UITweener.Begin<OJNJKONDHBB>(CGHIENBIHCO, CPKNEQGKQPQ, 338f);
		ojnjkondhbb.CGHQEHCBQHB = ojnjkondhbb.PFBBNDLOFKB();
		ojnjkondhbb.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 80f)
		{
			ojnjkondhbb.Sample(1390f, true);
			ojnjkondhbb.enabled = true;
		}
		return ojnjkondhbb;
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x0010A9C4 File Offset: 0x00108BC4
	public static OJNJKONDHBB MJQNQQLKJHN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		OJNJKONDHBB ojnjkondhbb = UITweener.Begin<OJNJKONDHBB>(CGHIENBIHCO, CPKNEQGKQPQ, 275f);
		ojnjkondhbb.CGHQEHCBQHB = ojnjkondhbb.PFBBNDLOFKB();
		ojnjkondhbb.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 1185f)
		{
			ojnjkondhbb.Sample(946f, true);
			ojnjkondhbb.enabled = true;
		}
		return ojnjkondhbb;
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x00014273 File Offset: 0x00012473
	public void MDMQHECDBLO(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.NBJPJBEQKPI = BGBMIEJJQKC;
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000142BE File Offset: 0x000124BE
	// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x00014273 File Offset: 0x00012473
	public float JGPGEKGHCQP
	{
		get
		{
			if (this.NNFMFGDPCPF != null)
			{
				return this.NNFMFGDPCPF.NBJPJBEQKPI;
			}
			return 0f;
		}
		set
		{
			if (this.NNFMFGDPCPF != null)
			{
				this.NNFMFGDPCPF.NBJPJBEQKPI = value;
			}
		}
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x0001428F File Offset: 0x0001248F
	public float OBKFLKOQCKG()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.NBJPJBEQKPI;
		}
		return 205f;
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x0010AA10 File Offset: 0x00108C10
	public static OJNJKONDHBB FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float NBJPJBEQKPI)
	{
		OJNJKONDHBB ojnjkondhbb = UITweener.Begin<OJNJKONDHBB>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		ojnjkondhbb.CGHQEHCBQHB = ojnjkondhbb.JGPGEKGHCQP;
		ojnjkondhbb.BKMCCCGOGOM = NBJPJBEQKPI;
		if (CPKNEQGKQPQ <= 0f)
		{
			ojnjkondhbb.Sample(1f, true);
			ojnjkondhbb.enabled = false;
		}
		return ojnjkondhbb;
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x000142B0 File Offset: 0x000124B0
	private void Awake()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x000142B0 File Offset: 0x000124B0
	private void CBIFGBNDMHB()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x000142DF File Offset: 0x000124DF
	public float PFBBNDLOFKB()
	{
		if (this.NNFMFGDPCPF != null)
		{
			return this.NNFMFGDPCPF.NBJPJBEQKPI;
		}
		return 1470f;
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x00014273 File Offset: 0x00012473
	public void CFKCEFEQJNM(float BGBMIEJJQKC)
	{
		if (this.NNFMFGDPCPF != null)
		{
			this.NNFMFGDPCPF.NBJPJBEQKPI = BGBMIEJJQKC;
		}
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x00014313 File Offset: 0x00012513
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.JGPGEKGHCQP = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x0001432D File Offset: 0x0001252D
	protected virtual void LDMIQOPGDBQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.CFKCEFEQJNM(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x000142B0 File Offset: 0x000124B0
	private void JIMBLQBBDKO()
	{
		this.NNFMFGDPCPF = base.GetComponentInChildren<OELLFMKIMFH>();
	}

	// Token: 0x04000939 RID: 2361
	public float CGHQEHCBQHB = 1f;

	// Token: 0x0400093A RID: 2362
	public float BKMCCCGOGOM;

	// Token: 0x0400093B RID: 2363
	private OELLFMKIMFH NNFMFGDPCPF;
}
