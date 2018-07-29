using System;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class EPIJJNOIKEK : UITweener
{
	// Token: 0x0600190B RID: 6411 RVA: 0x0000D597 File Offset: 0x0000B797
	public virtual void NCDDJJQMELE()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
	protected virtual void LDMIQOPGDBQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x0000D5BF File Offset: 0x0000B7BF
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06001918 RID: 6424 RVA: 0x0000D5D6 File Offset: 0x0000B7D6
	// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000D5CD File Offset: 0x0000B7CD
	[Obsolete("Use 'value' instead")]
	public float DIIHJCJOKMP
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

	// Token: 0x0600190F RID: 6415 RVA: 0x0000D597 File Offset: 0x0000B797
	public virtual void LJEPKPOEJDF()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x000AD77C File Offset: 0x000AB97C
	public static EPIJJNOIKEK JGLQEJDQKCO(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float DIIHJCJOKMP, float GCIJNEIIPIM = 0f)
	{
		EPIJJNOIKEK epijjnoikek = UITweener.Begin<EPIJJNOIKEK>(CGHIENBIHCO, CPKNEQGKQPQ, GCIJNEIIPIM);
		epijjnoikek.CGHQEHCBQHB = epijjnoikek.BGBMIEJJQKC;
		epijjnoikek.BKMCCCGOGOM = DIIHJCJOKMP;
		if (CPKNEQGKQPQ <= 1744f)
		{
			epijjnoikek.Sample(988f, false);
			epijjnoikek.enabled = false;
		}
		return epijjnoikek;
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
	public static EPIJJNOIKEK FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float DIIHJCJOKMP, float GCIJNEIIPIM = 0f)
	{
		EPIJJNOIKEK epijjnoikek = UITweener.Begin<EPIJJNOIKEK>(CGHIENBIHCO, CPKNEQGKQPQ, GCIJNEIIPIM);
		epijjnoikek.CGHQEHCBQHB = epijjnoikek.BGBMIEJJQKC;
		epijjnoikek.BKMCCCGOGOM = DIIHJCJOKMP;
		if (CPKNEQGKQPQ <= 0f)
		{
			epijjnoikek.Sample(1f, true);
			epijjnoikek.enabled = false;
		}
		return epijjnoikek;
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x0000D597 File Offset: 0x0000B797
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
	protected virtual void FCQQFPGHGEM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x0000D5BF File Offset: 0x0000B7BF
	public virtual void EJCLFGKMBEB()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x0600191D RID: 6429 RVA: 0x000AD9A4 File Offset: 0x000ABBA4
	// (set) Token: 0x06001915 RID: 6421 RVA: 0x000AD80C File Offset: 0x000ABA0C
	public float BGBMIEJJQKC
	{
		get
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.FBPOKBEMCEL != null)
			{
				return this.FBPOKBEMCEL.DIIHJCJOKMP;
			}
			if (this.ENNQHIBCIMC != null)
			{
				return this.ENNQHIBCIMC.color.a;
			}
			return (!(this.OEFCJHKBJJG != null)) ? 1f : this.OEFCJHKBJJG.color.a;
		}
		set
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.FBPOKBEMCEL != null)
			{
				this.FBPOKBEMCEL.DIIHJCJOKMP = value;
			}
			else if (this.ENNQHIBCIMC != null)
			{
				Color color = this.ENNQHIBCIMC.color;
				color.a = value;
				this.ENNQHIBCIMC.color = color;
			}
			else if (this.OEFCJHKBJJG != null)
			{
				Color color2 = this.OEFCJHKBJJG.color;
				color2.a = value;
				this.OEFCJHKBJJG.color = color2;
			}
		}
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x0000D5A5 File Offset: 0x0000B7A5
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Mathf.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
	private void FDMEBNCJLHF()
	{
		this.BJJNMHBPFNL = false;
		this.FBPOKBEMCEL = base.GetComponent<BLMNBILNMOE>();
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.FBPOKBEMCEL == null && this.ENNQHIBCIMC == null)
		{
			Renderer component = base.GetComponent<Renderer>();
			if (component != null)
			{
				this.OEFCJHKBJJG = component.material;
			}
			if (this.OEFCJHKBJJG == null)
			{
				this.FBPOKBEMCEL = base.GetComponentInChildren<BLMNBILNMOE>();
			}
		}
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x000AD924 File Offset: 0x000ABB24
	private void MDKEQEPIOEF()
	{
		this.BJJNMHBPFNL = true;
		this.FBPOKBEMCEL = base.GetComponent<BLMNBILNMOE>();
		this.ENNQHIBCIMC = base.GetComponent<SpriteRenderer>();
		if (this.FBPOKBEMCEL == null && this.ENNQHIBCIMC == null)
		{
			Renderer component = base.GetComponent<Renderer>();
			if (component != null)
			{
				this.OEFCJHKBJJG = component.material;
			}
			if (this.OEFCJHKBJJG == null)
			{
				this.FBPOKBEMCEL = base.GetComponentInChildren<BLMNBILNMOE>();
			}
		}
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x0000D597 File Offset: 0x0000B797
	public virtual void EQGCGMJNJPE()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x0000D5CD File Offset: 0x0000B7CD
	public void NEHHENECCLH(float BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x0400050D RID: 1293
	[Range(0f, 1f)]
	public float CGHQEHCBQHB = 1f;

	// Token: 0x0400050E RID: 1294
	[Range(0f, 1f)]
	public float BKMCCCGOGOM = 1f;

	// Token: 0x0400050F RID: 1295
	private bool BJJNMHBPFNL;

	// Token: 0x04000510 RID: 1296
	private BLMNBILNMOE FBPOKBEMCEL;

	// Token: 0x04000511 RID: 1297
	private Material OEFCJHKBJJG;

	// Token: 0x04000512 RID: 1298
	private SpriteRenderer ENNQHIBCIMC;
}
