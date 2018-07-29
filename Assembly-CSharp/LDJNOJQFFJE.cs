using System;
using UnityEngine;

// Token: 0x020000D5 RID: 213
[RequireComponent(typeof(PHINQNMFEHC))]
[AddComponentMenu("NGUI/Tween/Tween Fill")]
public class LDJNOJQFFJE : UITweener
{
	// Token: 0x06001954 RID: 6484 RVA: 0x0000D74D File Offset: 0x0000B94D
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x0000D75B File Offset: 0x0000B95B
	protected virtual void QDMILBGLJKB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KGHDBJDLJBG(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x0000D775 File Offset: 0x0000B975
	private void HGFMOBBKLOQ()
	{
		this.BJJNMHBPFNL = false;
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x0000D78A File Offset: 0x0000B98A
	public virtual void MCBBDCJDKQD()
	{
		this.BKMCCCGOGOM = this.NGNOKEFNNPM();
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x0000D798 File Offset: 0x0000B998
	public void KGHDBJDLJBG(float BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.HNKNKFBMPFM();
		}
		if (this.LNMJLFLDCML != null)
		{
			this.LNMJLFLDCML.KJNJQMLJELI = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x000AE444 File Offset: 0x000AC644
	public static LDJNOJQFFJE JGLQEJDQKCO(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float OQEOFMPMFBB)
	{
		LDJNOJQFFJE ldjnojqffje = UITweener.Begin<LDJNOJQFFJE>(CGHIENBIHCO, CPKNEQGKQPQ, 1344f);
		ldjnojqffje.CGHQEHCBQHB = ldjnojqffje.NGNOKEFNNPM();
		ldjnojqffje.BKMCCCGOGOM = OQEOFMPMFBB;
		if (CPKNEQGKQPQ <= 1409f)
		{
			ldjnojqffje.Sample(330f, false);
			ldjnojqffje.enabled = true;
		}
		return ldjnojqffje;
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x0000D7C2 File Offset: 0x0000B9C2
	public float OQFKDFJPNFE()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.HGFMOBBKLOQ();
		}
		if (this.LNMJLFLDCML != null)
		{
			return this.LNMJLFLDCML.KJNJQMLJELI;
		}
		return 38f;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
	protected virtual void JQKIGPHENIF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x0000D775 File Offset: 0x0000B975
	private void HNKNKFBMPFM()
	{
		this.BJJNMHBPFNL = false;
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x0000D75B File Offset: 0x0000B95B
	protected virtual void BHHILMHJGDL(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KGHDBJDLJBG(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x0000D80B File Offset: 0x0000BA0B
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x000AE490 File Offset: 0x000AC690
	public static LDJNOJQFFJE QQNLCFBGFKC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float OQEOFMPMFBB)
	{
		LDJNOJQFFJE ldjnojqffje = UITweener.Begin<LDJNOJQFFJE>(CGHIENBIHCO, CPKNEQGKQPQ, 414f);
		ldjnojqffje.CGHQEHCBQHB = ldjnojqffje.CKHOCPIGIFM();
		ldjnojqffje.BKMCCCGOGOM = OQEOFMPMFBB;
		if (CPKNEQGKQPQ <= 1568f)
		{
			ldjnojqffje.Sample(1719f, true);
			ldjnojqffje.enabled = false;
		}
		return ldjnojqffje;
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0000D819 File Offset: 0x0000BA19
	public virtual void MQDLGLCDIHC()
	{
		this.BKMCCCGOGOM = this.OQFKDFJPNFE();
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0000D827 File Offset: 0x0000BA27
	public virtual void MHQLDKJQJJC()
	{
		this.CGHQEHCBQHB = this.NGNOKEFNNPM();
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x0000D78A File Offset: 0x0000B98A
	public virtual void GOFBEOPPMEH()
	{
		this.BKMCCCGOGOM = this.NGNOKEFNNPM();
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x0000D75B File Offset: 0x0000B95B
	protected virtual void OBOFFQLCIMC(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KGHDBJDLJBG(Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0000D835 File Offset: 0x0000BA35
	public float NGNOKEFNNPM()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.HGFMOBBKLOQ();
		}
		if (this.LNMJLFLDCML != null)
		{
			return this.LNMJLFLDCML.KJNJQMLJELI;
		}
		return 635f;
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x0000D864 File Offset: 0x0000BA64
	public float CKHOCPIGIFM()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		if (this.LNMJLFLDCML != null)
		{
			return this.LNMJLFLDCML.KJNJQMLJELI;
		}
		return 1336f;
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06001967 RID: 6503 RVA: 0x0000D893 File Offset: 0x0000BA93
	// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000D8F5 File Offset: 0x0000BAF5
	public float BGBMIEJJQKC
	{
		get
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.LNMJLFLDCML != null)
			{
				return this.LNMJLFLDCML.KJNJQMLJELI;
			}
			return 0f;
		}
		set
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.LNMJLFLDCML != null)
			{
				this.LNMJLFLDCML.KJNJQMLJELI = value;
			}
		}
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x000AE4DC File Offset: 0x000AC6DC
	public static LDJNOJQFFJE FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float OQEOFMPMFBB)
	{
		LDJNOJQFFJE ldjnojqffje = UITweener.Begin<LDJNOJQFFJE>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		ldjnojqffje.CGHQEHCBQHB = ldjnojqffje.BGBMIEJJQKC;
		ldjnojqffje.BKMCCCGOGOM = OQEOFMPMFBB;
		if (CPKNEQGKQPQ <= 0f)
		{
			ldjnojqffje.Sample(1f, true);
			ldjnojqffje.enabled = false;
		}
		return ldjnojqffje;
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x000AE528 File Offset: 0x000AC728
	public static LDJNOJQFFJE DCMLJEIPFMF(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float OQEOFMPMFBB)
	{
		LDJNOJQFFJE ldjnojqffje = UITweener.Begin<LDJNOJQFFJE>(CGHIENBIHCO, CPKNEQGKQPQ, 864f);
		ldjnojqffje.CGHQEHCBQHB = ldjnojqffje.CKHOCPIGIFM();
		ldjnojqffje.BKMCCCGOGOM = OQEOFMPMFBB;
		if (CPKNEQGKQPQ <= 676f)
		{
			ldjnojqffje.Sample(208f, true);
			ldjnojqffje.enabled = false;
		}
		return ldjnojqffje;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
	private void MDKEQEPIOEF()
	{
		this.BJJNMHBPFNL = true;
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
	private void HBHIEJNHDEP()
	{
		this.BJJNMHBPFNL = true;
		this.LNMJLFLDCML = base.GetComponent<PLQFPBQEPJD>();
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x0000D78A File Offset: 0x0000B98A
	public virtual void BBQQLEGNCHJ()
	{
		this.BKMCCCGOGOM = this.NGNOKEFNNPM();
	}

	// Token: 0x0400051A RID: 1306
	[Range(0f, 1f)]
	public float CGHQEHCBQHB = 1f;

	// Token: 0x0400051B RID: 1307
	[Range(0f, 1f)]
	public float BKMCCCGOGOM = 1f;

	// Token: 0x0400051C RID: 1308
	private bool BJJNMHBPFNL;

	// Token: 0x0400051D RID: 1309
	private PHINQNMFEHC LNMJLFLDCML;
}
