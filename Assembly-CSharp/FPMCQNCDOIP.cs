using System;
using UnityEngine;

// Token: 0x020000DF RID: 223
[AddComponentMenu("NGUI/Tween/Tween Scale")]
public class FPMCQNCDOIP : UITweener
{
	// Token: 0x06001A8C RID: 6796 RVA: 0x0000E1F1 File Offset: 0x0000C3F1
	private void KCIBHENBLGE()
	{
		this.MDJCJHMJILF(this.CGHQEHCBQHB);
	}

	// Token: 0x06001A8D RID: 6797 RVA: 0x0000E1FF File Offset: 0x0000C3FF
	public virtual void MHQLDKJQJJC()
	{
		this.CGHQEHCBQHB = this.MHMMQFGCKJG();
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0000E20D File Offset: 0x0000C40D
	public void CNPMKCMQBKF(Vector3 BGBMIEJJQKC)
	{
		this.MDJCJHMJILF(BGBMIEJJQKC);
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x000B0DA4 File Offset: 0x000AEFA4
	public static FPMCQNCDOIP CHOFMOHLQOI(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 1688f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.BCBNOPQOHBO();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 358f)
		{
			fpmcqncdoip.Sample(1449f, false);
			fpmcqncdoip.enabled = false;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x0000E216 File Offset: 0x0000C416
	private void FQHCNKMKEPH()
	{
		this.MDJCJHMJILF(this.BKMCCCGOGOM);
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x0000E224 File Offset: 0x0000C424
	private void MFPFKFHDBPG()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x000B0DF0 File Offset: 0x000AEFF0
	protected virtual void GJLNFDHLEOH(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (764f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
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
			this.INBDNCCGOIK.POKQBKFFCQM(true);
		}
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x0000E232 File Offset: 0x0000C432
	private void QEIDQMJHDLK()
	{
		this.GJKOJCNDDBK(this.BKMCCCGOGOM);
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x0000E240 File Offset: 0x0000C440
	public void EGDLFEPLBBH(Vector3 BGBMIEJJQKC)
	{
		this.CGDFDPHIENG.localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform QKBFBQDMENP()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x0000E270 File Offset: 0x0000C470
	public virtual void DKNHFHEJLJF()
	{
		this.CGHQEHCBQHB = this.BCBNOPQOHBO();
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x0000E224 File Offset: 0x0000C424
	private void HPFGLDKDFPI()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x0000E27E File Offset: 0x0000C47E
	public virtual void EIMMBIEJJPN()
	{
		this.CGHQEHCBQHB = this.HJMJDJKOILH();
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x0000E28C File Offset: 0x0000C48C
	public Vector3 CCCMEHOIIEO()
	{
		return this.PGHDGIOFPOG().localScale;
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x0000E299 File Offset: 0x0000C499
	private void KODMQLHPFCE()
	{
		this.ECEBDPPDDIJ(this.BKMCCCGOGOM);
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0000E3FB File Offset: 0x0000C5FB
	// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0000E240 File Offset: 0x0000C440
	public Vector3 BGBMIEJJQKC
	{
		get
		{
			return this.CGDFDPHIENG.localScale;
		}
		set
		{
			this.CGDFDPHIENG.localScale = value;
		}
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x000B0E70 File Offset: 0x000AF070
	public static FPMCQNCDOIP HJGPDEFMEOG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 1060f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.LDPDKOQLDDJ();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 1612f)
		{
			fpmcqncdoip.Sample(1904f, false);
			fpmcqncdoip.enabled = true;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x0000E27E File Offset: 0x0000C47E
	public virtual void FELQJQFGOEG()
	{
		this.CGHQEHCBQHB = this.HJMJDJKOILH();
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x000B0EBC File Offset: 0x000AF0BC
	public static FPMCQNCDOIP BJLDIGIKGLB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 835f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.FIDCEOEFBDK();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 91f)
		{
			fpmcqncdoip.Sample(1285f, true);
			fpmcqncdoip.enabled = false;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x0000E270 File Offset: 0x0000C470
	public virtual void IPBHFFHEHQE()
	{
		this.CGHQEHCBQHB = this.BCBNOPQOHBO();
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x000B0F08 File Offset: 0x000AF108
	public static FPMCQNCDOIP LHIPLGQNCBQ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 1352f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.MHMMQFGCKJG();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 66f)
		{
			fpmcqncdoip.Sample(1090f, false);
			fpmcqncdoip.enabled = false;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform DFOCNIMGEOG()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x0000E2A7 File Offset: 0x0000C4A7
	public virtual void MFLFDQGNNGB()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000B0F54 File Offset: 0x000AF154
	public static FPMCQNCDOIP PKIQMEHGQPG(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 1576f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.BCBNOPQOHBO();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 1862f)
		{
			fpmcqncdoip.Sample(515f, true);
			fpmcqncdoip.enabled = true;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x0000E2B5 File Offset: 0x0000C4B5
	public Vector3 FIDCEOEFBDK()
	{
		return this.DFOCNIMGEOG().localScale;
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
	private void KEINNQNPBPL()
	{
		this.QDGMMEOJHBH(this.BKMCCCGOGOM);
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x0000E2DE File Offset: 0x0000C4DE
	private void KKECJPDECGL()
	{
		this.PMBNQKDEPNN(this.BKMCCCGOGOM);
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x0000E2EC File Offset: 0x0000C4EC
	public void EELLMPPJIBF(Vector3 BGBMIEJJQKC)
	{
		this.GJKOJCNDDBK(BGBMIEJJQKC);
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0000E2F5 File Offset: 0x0000C4F5
	public virtual void JFEHEINJDOI()
	{
		this.BKMCCCGOGOM = this.FOIKGFDGOMO();
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x0000E240 File Offset: 0x0000C440
	public void PMBNQKDEPNN(Vector3 BGBMIEJJQKC)
	{
		this.CGDFDPHIENG.localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform PGHDGIOFPOG()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x0000E303 File Offset: 0x0000C503
	private void MMIHIBCMQOD()
	{
		this.EGDLFEPLBBH(this.BKMCCCGOGOM);
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0000E311 File Offset: 0x0000C511
	public void MDJCJHMJILF(Vector3 BGBMIEJJQKC)
	{
		this.NMPEQKOJGDL().localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x000B0FA0 File Offset: 0x000AF1A0
	protected virtual void PGLLINKQBFM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.HBCQNHMLPHG(this.CGHQEHCBQHB * (328f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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

	// Token: 0x06001AAF RID: 6831 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform BJCQOIEPJDH()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x0000E1F1 File Offset: 0x0000C3F1
	private void CQEIGLBIJGN()
	{
		this.MDJCJHMJILF(this.CGHQEHCBQHB);
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0000E31F File Offset: 0x0000C51F
	public virtual void HDNHHBNDOKH()
	{
		this.BKMCCCGOGOM = this.CCCMEHOIIEO();
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform GLBEIBDOKHK()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x0000E32D File Offset: 0x0000C52D
	private void PDKHIOJIQBM()
	{
		this.EGDLFEPLBBH(this.CGHQEHCBQHB);
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x0000E33B File Offset: 0x0000C53B
	public Vector3 MHMMQFGCKJG()
	{
		return this.QKBFBQDMENP().localScale;
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform HPQNPLCLCLM()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x0000E348 File Offset: 0x0000C548
	public void QDGMMEOJHBH(Vector3 BGBMIEJJQKC)
	{
		this.BJCQOIEPJDH().localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x0000E31F File Offset: 0x0000C51F
	public virtual void BKDFBLJLOKD()
	{
		this.BKMCCCGOGOM = this.CCCMEHOIIEO();
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x0000E356 File Offset: 0x0000C556
	public Vector3 LDPDKOQLDDJ()
	{
		return this.IIKDHKHKMEK().localScale;
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0000E363 File Offset: 0x0000C563
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0000E240 File Offset: 0x0000C440
	public void HBCQNHMLPHG(Vector3 BGBMIEJJQKC)
	{
		this.CGDFDPHIENG.localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x0000E38F File Offset: 0x0000C58F
	public virtual void JNLFJQEGQKH()
	{
		this.BKMCCCGOGOM = this.FIDCEOEFBDK();
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0000E33B File Offset: 0x0000C53B
	public Vector3 HJMJDJKOILH()
	{
		return this.QKBFBQDMENP().localScale;
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000B1020 File Offset: 0x000AF220
	protected virtual void JQKIGPHENIF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.ECEBDPPDDIJ(this.CGHQEHCBQHB * (229f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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
			this.INBDNCCGOIK.MJCCGFQOEJK(false);
		}
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x0000E2A7 File Offset: 0x0000C4A7
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x0000E27E File Offset: 0x0000C47E
	public virtual void KKBCHCMGPJN()
	{
		this.CGHQEHCBQHB = this.HJMJDJKOILH();
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0000E39D File Offset: 0x0000C59D
	public void OICOMNEOCNP(Vector3 BGBMIEJJQKC)
	{
		this.EGDLFEPLBBH(BGBMIEJJQKC);
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x0000E1FF File Offset: 0x0000C3FF
	public virtual void ECFNGFIIPCQ()
	{
		this.CGHQEHCBQHB = this.MHMMQFGCKJG();
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000B10A0 File Offset: 0x000AF2A0
	protected virtual void GLEJBGIHPKI(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.QEKGHBMDIQO(this.CGHQEHCBQHB * (1806f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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
			this.INBDNCCGOIK.KLHEEKGHFLL(false);
		}
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x0000E3A6 File Offset: 0x0000C5A6
	private void OCDBPPDNFKC()
	{
		this.PMBNQKDEPNN(this.CGHQEHCBQHB);
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
	public void QEKGHBMDIQO(Vector3 BGBMIEJJQKC)
	{
		this.QKBFBQDMENP().localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000B1120 File Offset: 0x000AF320
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
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

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000B11A0 File Offset: 0x000AF3A0
	protected virtual void QECQCBOLIIF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (22f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
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
			this.INBDNCCGOIK.OIINFQGEJON(false);
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0000E3C2 File Offset: 0x0000C5C2
	// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000E408 File Offset: 0x0000C608
	[Obsolete("Use 'value' instead")]
	public Vector3 LCHODFNJNBH
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

	// Token: 0x06001AC9 RID: 6857 RVA: 0x0000E3CA File Offset: 0x0000C5CA
	public Vector3 FOIKGFDGOMO()
	{
		return this.BJCQOIEPJDH().localScale;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x0000E3D7 File Offset: 0x0000C5D7
	public void GJKOJCNDDBK(Vector3 BGBMIEJJQKC)
	{
		this.GLBEIBDOKHK().localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0000E3E5 File Offset: 0x0000C5E5
	private void LQFKIGQKFPI()
	{
		this.QEKGHBMDIQO(this.CGHQEHCBQHB);
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x0000E224 File Offset: 0x0000C424
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x0000E1F1 File Offset: 0x0000C3F1
	private void QIGPBLIDHDD()
	{
		this.MDJCJHMJILF(this.CGHQEHCBQHB);
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
	public Vector3 DMFMEGNFEIL()
	{
		return this.BCBNOPQOHBO();
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x000B1220 File Offset: 0x000AF420
	public static FPMCQNCDOIP FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.BGBMIEJJQKC;
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 0f)
		{
			fpmcqncdoip.Sample(1f, true);
			fpmcqncdoip.enabled = false;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x000B126C File Offset: 0x000AF46C
	protected virtual void NJEKOMOMMPB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (779f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
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
			this.INBDNCCGOIK.ICHPGNKDKJF(true);
		}
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x000B12EC File Offset: 0x000AF4EC
	public static FPMCQNCDOIP CLPJPDDOCHC(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 56f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.BGBMIEJJQKC;
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 1436f)
		{
			fpmcqncdoip.Sample(476f, false);
			fpmcqncdoip.enabled = true;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
	public Vector3 PPGBPLHEMHO()
	{
		return this.BCBNOPQOHBO();
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000B1338 File Offset: 0x000AF538
	public static FPMCQNCDOIP BFJFGJOLILP(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 825f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.FOIKGFDGOMO();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 927f)
		{
			fpmcqncdoip.Sample(472f, false);
			fpmcqncdoip.enabled = true;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x0000E31F File Offset: 0x0000C51F
	public virtual void MJPNLGFOFOB()
	{
		this.BKMCCCGOGOM = this.CCCMEHOIIEO();
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform IIKDHKHKMEK()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x000B1384 File Offset: 0x000AF584
	protected virtual void QDMILBGLJKB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.QDGMMEOJHBH(this.CGHQEHCBQHB * (150f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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
			this.INBDNCCGOIK.PLCDNCNFJMM(true);
		}
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform NMPEQKOJGDL()
	{
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.transform;
		}
		return this.BLLEFKOLKLP;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x0000E240 File Offset: 0x0000C440
	public void ECEBDPPDDIJ(Vector3 BGBMIEJJQKC)
	{
		this.CGDFDPHIENG.localScale = BGBMIEJJQKC;
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
	public Vector3 CICEGHPJIKB()
	{
		return this.BCBNOPQOHBO();
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x0000E411 File Offset: 0x0000C611
	public Vector3 BCBNOPQOHBO()
	{
		return this.GLBEIBDOKHK().localScale;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
	private void JLBPDIDJHQG()
	{
		this.QDGMMEOJHBH(this.BKMCCCGOGOM);
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x0000E41E File Offset: 0x0000C61E
	public void JPEQOJIOCPD(Vector3 BGBMIEJJQKC)
	{
		this.HBCQNHMLPHG(BGBMIEJJQKC);
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x0000E427 File Offset: 0x0000C627
	public Vector3 CHDDKMDKHIJ()
	{
		return this.HJMJDJKOILH();
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x0000E42F File Offset: 0x0000C62F
	public Vector3 GLPGKIQOFFB()
	{
		return this.MHMMQFGCKJG();
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x000B1404 File Offset: 0x000AF604
	protected virtual void EHDIJEHKFFH(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.GJKOJCNDDBK(this.CGHQEHCBQHB * (1036f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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
			this.INBDNCCGOIK.POKQBKFFCQM(true);
		}
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x000B1484 File Offset: 0x000AF684
	protected virtual void GFKNDQHJKMJ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EGDLFEPLBBH(this.CGHQEHCBQHB * (1140f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
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
			this.INBDNCCGOIK.POKQBKFFCQM(false);
		}
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x0000E39D File Offset: 0x0000C59D
	public void GCHIMFJDIBK(Vector3 BGBMIEJJQKC)
	{
		this.EGDLFEPLBBH(BGBMIEJJQKC);
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000B1504 File Offset: 0x000AF704
	public static FPMCQNCDOIP LKOEFCKMEQD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Vector3 LCHODFNJNBH)
	{
		FPMCQNCDOIP fpmcqncdoip = UITweener.Begin<FPMCQNCDOIP>(CGHIENBIHCO, CPKNEQGKQPQ, 1935f);
		fpmcqncdoip.CGHQEHCBQHB = fpmcqncdoip.MHMMQFGCKJG();
		fpmcqncdoip.BKMCCCGOGOM = LCHODFNJNBH;
		if (CPKNEQGKQPQ <= 604f)
		{
			fpmcqncdoip.Sample(1310f, false);
			fpmcqncdoip.enabled = false;
		}
		return fpmcqncdoip;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x0000E437 File Offset: 0x0000C637
	public Vector3 NKOEKKCDMPC()
	{
		return this.FOIKGFDGOMO();
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x0000E24E File Offset: 0x0000C44E
	public Transform CGDFDPHIENG
	{
		get
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
			}
			return this.BLLEFKOLKLP;
		}
	}

	// Token: 0x04000549 RID: 1353
	public Vector3 CGHQEHCBQHB = Vector3.one;

	// Token: 0x0400054A RID: 1354
	public Vector3 BKMCCCGOGOM = Vector3.one;

	// Token: 0x0400054B RID: 1355
	public bool HILMCKFOHDL;

	// Token: 0x0400054C RID: 1356
	private Transform BLLEFKOLKLP;

	// Token: 0x0400054D RID: 1357
	private JFDJLDBQQKC INBDNCCGOIK;
}
