using System;
using UnityEngine;

// Token: 0x020001F3 RID: 499
public class QMBJOMBDDCI : UITweener
{
	// Token: 0x06004163 RID: 16739 RVA: 0x0001BD7F File Offset: 0x00019F7F
	protected virtual void LGLLPJOKCJG(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.GIPBBFDPCKG(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06004164 RID: 16740 RVA: 0x0001BD99 File Offset: 0x00019F99
	// (set) Token: 0x06004169 RID: 16745 RVA: 0x0001BDC8 File Offset: 0x00019FC8
	public Color BGBMIEJJQKC
	{
		get
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.OEFCJHKBJJG != null)
			{
				return this.OEFCJHKBJJG.color;
			}
			return Color.black;
		}
		set
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			else if (this.OEFCJHKBJJG != null)
			{
				this.OEFCJHKBJJG.color = value;
			}
		}
	}

	// Token: 0x06004165 RID: 16741 RVA: 0x0001BDC8 File Offset: 0x00019FC8
	public void HHFMGFPDIFL(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x0001BDF4 File Offset: 0x00019FF4
	public void GNBBEMBPJPO(Color BGBMIEJJQKC)
	{
		this.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x06004167 RID: 16743 RVA: 0x0001BDFD File Offset: 0x00019FFD
	// (set) Token: 0x06004170 RID: 16752 RVA: 0x0001BE2F File Offset: 0x0001A02F
	[Obsolete("Use 'value' instead")]
	public Color CEGFBBHMKOE
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

	// Token: 0x06004168 RID: 16744 RVA: 0x0001BE05 File Offset: 0x0001A005
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x0600416A RID: 16746 RVA: 0x0001BE13 File Offset: 0x0001A013
	private void BLMNMMMNBJB()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x0001BD99 File Offset: 0x00019F99
	public Color OQFKDFJPNFE()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.color;
		}
		return Color.black;
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x0001BE13 File Offset: 0x0001A013
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x0600416D RID: 16749 RVA: 0x0001BDC8 File Offset: 0x00019FC8
	public void NLFMEBBPGDN(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x001FCBA0 File Offset: 0x001FADA0
	public static QMBJOMBDDCI FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		QMBJOMBDDCI qmbjombddci = UITweener.Begin<QMBJOMBDDCI>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		qmbjombddci.CGHQEHCBQHB = qmbjombddci.BGBMIEJJQKC;
		qmbjombddci.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 0f)
		{
			qmbjombddci.Sample(1f, true);
			qmbjombddci.enabled = false;
		}
		return qmbjombddci;
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x0001BE21 File Offset: 0x0001A021
	private void GBJKIJEHNOO()
	{
		this.NLFMEBBPGDN(this.CGHQEHCBQHB);
	}

	// Token: 0x06004171 RID: 16753 RVA: 0x0001BDC8 File Offset: 0x00019FC8
	public void GIPBBFDPCKG(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
	}

	// Token: 0x06004172 RID: 16754 RVA: 0x0001BE38 File Offset: 0x0001A038
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06004173 RID: 16755 RVA: 0x0001BE52 File Offset: 0x0001A052
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06004174 RID: 16756 RVA: 0x0001BE60 File Offset: 0x0001A060
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x0001BDC8 File Offset: 0x00019FC8
	public void KGHDBJDLJBG(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.color = BGBMIEJJQKC;
		}
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x0001BE6E File Offset: 0x0001A06E
	private void KLIKHNDHBBK()
	{
		this.HHFMGFPDIFL(this.CGHQEHCBQHB);
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x0001BE7C File Offset: 0x0001A07C
	public Color PDMGNOIDDIN()
	{
		return this.OQFKDFJPNFE();
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x0001BE6E File Offset: 0x0001A06E
	private void CQEIGLBIJGN()
	{
		this.HHFMGFPDIFL(this.CGHQEHCBQHB);
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x001FCBEC File Offset: 0x001FADEC
	private void MDKEQEPIOEF()
	{
		this.BJJNMHBPFNL = true;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x0001BE84 File Offset: 0x0001A084
	private void IDPKICOJDDP()
	{
		this.GIPBBFDPCKG(this.CGHQEHCBQHB);
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
	protected virtual void EEGKJBPHMMQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KGHDBJDLJBG(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x04000E3A RID: 3642
	public Color CGHQEHCBQHB = Color.white;

	// Token: 0x04000E3B RID: 3643
	public Color BKMCCCGOGOM = Color.white;

	// Token: 0x04000E3C RID: 3644
	private bool BJJNMHBPFNL;

	// Token: 0x04000E3D RID: 3645
	private Material OEFCJHKBJJG;
}
