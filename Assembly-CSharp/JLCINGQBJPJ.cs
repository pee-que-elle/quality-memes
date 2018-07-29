using System;
using UnityEngine;

// Token: 0x020000E2 RID: 226
[AddComponentMenu("NGUI/Tween/Tween Width")]
[RequireComponent(typeof(ENFMCDNLEQQ))]
public class JLCINGQBJPJ : UITweener
{
	// Token: 0x06001B51 RID: 6993 RVA: 0x0000E778 File Offset: 0x0000C978
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x0000E786 File Offset: 0x0000C986
	public ENFMCDNLEQQ PNELCLLFQEI()
	{
		if (this.DLQMOLJPEMO == null)
		{
			this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		}
		return this.DLQMOLJPEMO;
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0000E786 File Offset: 0x0000C986
	public ENFMCDNLEQQ JBLJHCQNBGD
	{
		get
		{
			if (this.DLQMOLJPEMO == null)
			{
				this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
			}
			return this.DLQMOLJPEMO;
		}
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x000B3EF0 File Offset: 0x000B20F0
	public static JLCINGQBJPJ LMHHLNILKML(ENFMCDNLEQQ BCPJIPBJODP, float CPKNEQGKQPQ, int KJGMGPCEJJD, float GCIJNEIIPIM = 0f)
	{
		JLCINGQBJPJ jlcingqbjpj = UITweener.Begin<JLCINGQBJPJ>(BCPJIPBJODP.gameObject, CPKNEQGKQPQ, GCIJNEIIPIM);
		jlcingqbjpj.CGHQEHCBQHB = BCPJIPBJODP.KJGMGPCEJJD;
		jlcingqbjpj.BKMCCCGOGOM = KJGMGPCEJJD;
		if (CPKNEQGKQPQ <= 739f)
		{
			jlcingqbjpj.Sample(588f, false);
			jlcingqbjpj.enabled = false;
		}
		return jlcingqbjpj;
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x000B3F3C File Offset: 0x000B213C
	public static JLCINGQBJPJ FJCEGFKJLCL(ENFMCDNLEQQ BCPJIPBJODP, float CPKNEQGKQPQ, int KJGMGPCEJJD, float GCIJNEIIPIM = 0f)
	{
		JLCINGQBJPJ jlcingqbjpj = UITweener.Begin<JLCINGQBJPJ>(BCPJIPBJODP.gameObject, CPKNEQGKQPQ, GCIJNEIIPIM);
		jlcingqbjpj.CGHQEHCBQHB = BCPJIPBJODP.KJGMGPCEJJD;
		jlcingqbjpj.BKMCCCGOGOM = KJGMGPCEJJD;
		if (CPKNEQGKQPQ <= 0f)
		{
			jlcingqbjpj.Sample(1f, true);
			jlcingqbjpj.enabled = false;
		}
		return jlcingqbjpj;
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x0000E786 File Offset: 0x0000C986
	public ENFMCDNLEQQ INBGKLFOQIH()
	{
		if (this.DLQMOLJPEMO == null)
		{
			this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		}
		return this.DLQMOLJPEMO;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
	public virtual void GOFBEOPPMEH()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	private void OMPEHPMHPIH()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
	private void PQODHQFHKQM()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
	// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
	[Obsolete("Use 'value' instead")]
	public int KJGMGPCEJJD
	{
		get
		{
			return this.BGBMIEJJQKC;
		}
		set
		{
			this.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x0000E7CD File Offset: 0x0000C9CD
	public int CJBJMOELNKE()
	{
		return this.KBLOHEPQEKP().KJGMGPCEJJD;
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0000E7FE File Offset: 0x0000C9FE
	// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000E7DA File Offset: 0x0000C9DA
	public int BGBMIEJJQKC
	{
		get
		{
			return this.JBLJHCQNBGD.KJGMGPCEJJD;
		}
		set
		{
			this.JBLJHCQNBGD.KJGMGPCEJJD = value;
		}
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
	public int EFLBLGFFBEN()
	{
		return this.BGBMIEJJQKC;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0000E786 File Offset: 0x0000C986
	public ENFMCDNLEQQ KBLOHEPQEKP()
	{
		if (this.DLQMOLJPEMO == null)
		{
			this.DLQMOLJPEMO = base.GetComponent<ENFMCDNLEQQ>();
		}
		return this.DLQMOLJPEMO;
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
	public void PIPEHJKHJHH(int BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000B3F88 File Offset: 0x000B2188
	protected virtual void EEGKJBPHMMQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.RoundToInt((float)this.CGHQEHCBQHB * (1292f - PJDGFDBEOOJ) + (float)this.BKMCCCGOGOM * PJDGFDBEOOJ);
		if (this.HILMCKFOHDL)
		{
			if (this.INBDNCCGOIK == null)
			{
				this.INBDNCCGOIK = IKBQNBHOJJB.BBDJCHKMCPI<JFDJLDBQQKC>(base.gameObject);
				if (this.INBDNCCGOIK == null)
				{
					this.HILMCKFOHDL = false;
					return;
				}
			}
			this.INBDNCCGOIK.LGCDIBFQQQI(false);
		}
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
	private void IDPKICOJDDP()
	{
		this.IIQPIHPDGKH(this.CGHQEHCBQHB);
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
	private void LCFMIIJNOIF()
	{
		this.IIQPIHPDGKH(this.CGHQEHCBQHB);
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x0000E80B File Offset: 0x0000CA0B
	public void GGOGMIJEQML(int BGBMIEJJQKC)
	{
		this.IIQPIHPDGKH(BGBMIEJJQKC);
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x0000E814 File Offset: 0x0000CA14
	public void IIQPIHPDGKH(int BGBMIEJJQKC)
	{
		this.PNELCLLFQEI().KJGMGPCEJJD = BGBMIEJJQKC;
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x0000E822 File Offset: 0x0000CA22
	public virtual void KEJPPBCPNKH()
	{
		this.BKMCCCGOGOM = this.NGNOKEFNNPM();
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x000B4004 File Offset: 0x000B2204
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.RoundToInt((float)this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + (float)this.BKMCCCGOGOM * PJDGFDBEOOJ);
		if (this.HILMCKFOHDL)
		{
			if (this.INBDNCCGOIK == null)
			{
				this.INBDNCCGOIK = IKBQNBHOJJB.BBDJCHKMCPI<JFDJLDBQQKC>(base.gameObject);
				if (this.INBDNCCGOIK == null)
				{
					this.HILMCKFOHDL = false;
					return;
				}
			}
			this.INBDNCCGOIK.CLQFFBMLIQH = true;
		}
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000B4080 File Offset: 0x000B2280
	protected virtual void QPFQFPPGING(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.IIQPIHPDGKH(Mathf.RoundToInt((float)this.CGHQEHCBQHB * (1526f - PJDGFDBEOOJ) + (float)this.BKMCCCGOGOM * PJDGFDBEOOJ));
		if (this.HILMCKFOHDL)
		{
			if (this.INBDNCCGOIK == null)
			{
				this.INBDNCCGOIK = IKBQNBHOJJB.BBDJCHKMCPI<JFDJLDBQQKC>(base.gameObject);
				if (this.INBDNCCGOIK == null)
				{
					this.HILMCKFOHDL = true;
					return;
				}
			}
			this.INBDNCCGOIK.KLHEEKGHFLL(false);
		}
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x000B40FC File Offset: 0x000B22FC
	public static JLCINGQBJPJ EOKHEPPPQDD(ENFMCDNLEQQ BCPJIPBJODP, float CPKNEQGKQPQ, int KJGMGPCEJJD, float GCIJNEIIPIM = 0f)
	{
		JLCINGQBJPJ jlcingqbjpj = UITweener.Begin<JLCINGQBJPJ>(BCPJIPBJODP.gameObject, CPKNEQGKQPQ, GCIJNEIIPIM);
		jlcingqbjpj.CGHQEHCBQHB = BCPJIPBJODP.KJGMGPCEJJD;
		jlcingqbjpj.BKMCCCGOGOM = KJGMGPCEJJD;
		if (CPKNEQGKQPQ <= 7f)
		{
			jlcingqbjpj.Sample(1995f, true);
			jlcingqbjpj.enabled = false;
		}
		return jlcingqbjpj;
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x0000E7FE File Offset: 0x0000C9FE
	public int NGNOKEFNNPM()
	{
		return this.JBLJHCQNBGD.KJGMGPCEJJD;
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x0000E848 File Offset: 0x0000CA48
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x0000E822 File Offset: 0x0000CA22
	public virtual void FNHDPQQKQMI()
	{
		this.BKMCCCGOGOM = this.NGNOKEFNNPM();
	}

	// Token: 0x04000558 RID: 1368
	public int CGHQEHCBQHB = 100;

	// Token: 0x04000559 RID: 1369
	public int BKMCCCGOGOM = 100;

	// Token: 0x0400055A RID: 1370
	public bool HILMCKFOHDL;

	// Token: 0x0400055B RID: 1371
	private ENFMCDNLEQQ DLQMOLJPEMO;

	// Token: 0x0400055C RID: 1372
	private JFDJLDBQQKC INBDNCCGOIK;
}
