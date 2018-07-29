using System;
using UnityEngine;

// Token: 0x020000DC RID: 220
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
public class MFMMDFDHOEK : UITweener
{
	// Token: 0x06001A16 RID: 6678 RVA: 0x0000DE0A File Offset: 0x0000C00A
	public virtual void NQKCOBJHCJD()
	{
		this.BKMCCCGOGOM = this.JKPCEJEOCLH();
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x0000DE18 File Offset: 0x0000C018
	public virtual void NCDDJJQMELE()
	{
		this.BKMCCCGOGOM = this.BCCIEGQBFKL();
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera OPHINCHQBJD()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x0000DE48 File Offset: 0x0000C048
	public void QEKCOMCPQBH(float BGBMIEJJQKC)
	{
		this.DNLMCLKPOLM(BGBMIEJJQKC);
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x0000DE51 File Offset: 0x0000C051
	public virtual void MHQLDKJQJJC()
	{
		this.CGHQEHCBQHB = this.JKPCEJEOCLH();
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x0000DE5F File Offset: 0x0000C05F
	public float KPHNJHHJHHO()
	{
		return this.EDLNFHQCCLM().orthographicSize;
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x0000DE6C File Offset: 0x0000C06C
	public virtual void HDNHHBNDOKH()
	{
		this.BKMCCCGOGOM = this.MIDLEJPLHME();
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x000B06E8 File Offset: 0x000AE8E8
	public static MFMMDFDHOEK HHHQDJKJNGF(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 1018f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.JKPCEJEOCLH();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1073f)
		{
			mfmmdfdhoek.Sample(1172f, true);
			mfmmdfdhoek.enabled = true;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x0000DE7A File Offset: 0x0000C07A
	public void DMJNJNBQBQB(float BGBMIEJJQKC)
	{
		this.EIIIDFGLNDL(BGBMIEJJQKC);
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0000DE83 File Offset: 0x0000C083
	public virtual void QJFILDGDDMD()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0000DE91 File Offset: 0x0000C091
	public virtual void KMLFDLPNCLJ()
	{
		this.BKMCCCGOGOM = this.KPHNJHHJHHO();
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera FIIGLQFDQOD()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x0000DE9F File Offset: 0x0000C09F
	public void EIIIDFGLNDL(float BGBMIEJJQKC)
	{
		this.EQOOPGKHOFB.orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x0000DEAD File Offset: 0x0000C0AD
	protected virtual void PIILLLFMOLB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EIIIDFGLNDL(this.CGHQEHCBQHB * (1303f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x0000DECC File Offset: 0x0000C0CC
	public virtual void PCOJOQLNGGC()
	{
		this.CGHQEHCBQHB = this.BCCIEGQBFKL();
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x0000DEDA File Offset: 0x0000C0DA
	public void EGDLFEPLBBH(float BGBMIEJJQKC)
	{
		this.EDLNFHQCCLM().orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x0000DE83 File Offset: 0x0000C083
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
	public void HIHQDDLHQFF(float BGBMIEJJQKC)
	{
		this.JCHCPGDQLFE(BGBMIEJJQKC);
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0000DEF1 File Offset: 0x0000C0F1
	// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000E021 File Offset: 0x0000C221
	[Obsolete("Use 'value' instead")]
	public float CBQNCIDGBPJ
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

	// Token: 0x06001A29 RID: 6697 RVA: 0x000B0734 File Offset: 0x000AE934
	public static MFMMDFDHOEK CHOFMOHLQOI(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 515f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.JKPCEJEOCLH();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 688f)
		{
			mfmmdfdhoek.Sample(1881f, false);
			mfmmdfdhoek.enabled = true;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x0000DEF9 File Offset: 0x0000C0F9
	protected virtual void OBEHKKHPHQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.ONOLMLNJLBE(this.CGHQEHCBQHB * (1811f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x000B0780 File Offset: 0x000AE980
	public static MFMMDFDHOEK FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.BGBMIEJJQKC;
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 0f)
		{
			mfmmdfdhoek.Sample(1f, true);
			mfmmdfdhoek.enabled = false;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x0000DE5F File Offset: 0x0000C05F
	public float LNJGPEKQEMI()
	{
		return this.EDLNFHQCCLM().orthographicSize;
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0000DF18 File Offset: 0x0000C118
	// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000DE9F File Offset: 0x0000C09F
	public float BGBMIEJJQKC
	{
		get
		{
			return this.EQOOPGKHOFB.orthographicSize;
		}
		set
		{
			this.EQOOPGKHOFB.orthographicSize = value;
		}
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x0000DE48 File Offset: 0x0000C048
	public void DGDGJLJNKPH(float BGBMIEJJQKC)
	{
		this.DNLMCLKPOLM(BGBMIEJJQKC);
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x0000DF25 File Offset: 0x0000C125
	protected virtual void QIHHPHFGIED(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (463f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x000B07CC File Offset: 0x000AE9CC
	public static MFMMDFDHOEK PCNQDPHGDFJ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 498f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.KPHNJHHJHHO();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 458f)
		{
			mfmmdfdhoek.Sample(1070f, false);
			mfmmdfdhoek.enabled = false;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x0000DF44 File Offset: 0x0000C144
	public virtual void BKDFBLJLOKD()
	{
		this.BKMCCCGOGOM = this.KEJFFMLDLOK();
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x0000DE91 File Offset: 0x0000C091
	public virtual void OENLMQKIFCG()
	{
		this.BKMCCCGOGOM = this.KPHNJHHJHHO();
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x0000DF52 File Offset: 0x0000C152
	public float HHGQFLQNHQP()
	{
		return this.KEJFFMLDLOK();
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x0000DF5A File Offset: 0x0000C15A
	protected virtual void FCQQFPGHGEM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EIIIDFGLNDL(this.CGHQEHCBQHB * (162f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x0000DF79 File Offset: 0x0000C179
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x0000DF98 File Offset: 0x0000C198
	public virtual void POOHLPEJKLH()
	{
		this.CGHQEHCBQHB = this.LNJGPEKQEMI();
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera HJDKCQKMOQM()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x0000DFA6 File Offset: 0x0000C1A6
	public virtual void HKMJNOIIOFI()
	{
		this.CGHQEHCBQHB = this.KPHNJHHJHHO();
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera EDLNFHQCCLM()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera EQOOPGKHOFB
	{
		get
		{
			if (this.OJIDBLEKBBO == null)
			{
				this.OJIDBLEKBBO = base.GetComponent<Camera>();
			}
			return this.OJIDBLEKBBO;
		}
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x0000DFC2 File Offset: 0x0000C1C2
	public void JCHCPGDQLFE(float BGBMIEJJQKC)
	{
		this.HJDKCQKMOQM().orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
	protected virtual void CCEFNILMGGD(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.ONOLMLNJLBE(this.CGHQEHCBQHB * (518f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0000DFEF File Offset: 0x0000C1EF
	public virtual void KEFCHGCIIQN()
	{
		this.CGHQEHCBQHB = this.KEJFFMLDLOK();
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x0000DFFD File Offset: 0x0000C1FD
	public float KEJFFMLDLOK()
	{
		return this.FIIGLQFDQOD().orthographicSize;
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x0000DE9F File Offset: 0x0000C09F
	public void GJKOJCNDDBK(float BGBMIEJJQKC)
	{
		this.EQOOPGKHOFB.orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x000B0818 File Offset: 0x000AEA18
	public static MFMMDFDHOEK GEFDGLJIFED(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 670f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.KPHNJHHJHHO();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 743f)
		{
			mfmmdfdhoek.Sample(255f, false);
			mfmmdfdhoek.enabled = true;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x0000E00A File Offset: 0x0000C20A
	public void DNLMCLKPOLM(float BGBMIEJJQKC)
	{
		this.LOIGODCOKMP().orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x0000DE6C File Offset: 0x0000C06C
	public virtual void IEMEFIDMKMI()
	{
		this.BKMCCCGOGOM = this.MIDLEJPLHME();
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera CLQQNDKPIID()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x0000DE0A File Offset: 0x0000C00A
	public virtual void JBMNKDQCFEF()
	{
		this.BKMCCCGOGOM = this.JKPCEJEOCLH();
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x0000DF44 File Offset: 0x0000C144
	public virtual void BQLNQJEBQDD()
	{
		this.BKMCCCGOGOM = this.KEJFFMLDLOK();
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x000B0864 File Offset: 0x000AEA64
	public static MFMMDFDHOEK LHIPLGQNCBQ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 1729f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.BCCIEGQBFKL();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1108f)
		{
			mfmmdfdhoek.Sample(18f, false);
			mfmmdfdhoek.enabled = true;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x0000E018 File Offset: 0x0000C218
	public void NMBEOMJIPED(float BGBMIEJJQKC)
	{
		this.GJKOJCNDDBK(BGBMIEJJQKC);
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera LOIGODCOKMP()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera BLMCLCCIHBI()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x0000DE51 File Offset: 0x0000C051
	public virtual void IHPMINBJING()
	{
		this.CGHQEHCBQHB = this.JKPCEJEOCLH();
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x000B08B0 File Offset: 0x000AEAB0
	public static MFMMDFDHOEK LKGOLQQDMLK(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 1047f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.BCCIEGQBFKL();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 615f)
		{
			mfmmdfdhoek.Sample(1023f, false);
			mfmmdfdhoek.enabled = false;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x0000DE9F File Offset: 0x0000C09F
	public void ONOLMLNJLBE(float BGBMIEJJQKC)
	{
		this.EQOOPGKHOFB.orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x0000E02A File Offset: 0x0000C22A
	public float NCPQIBOBPCH()
	{
		return this.JKPCEJEOCLH();
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0000E032 File Offset: 0x0000C232
	public float MIDLEJPLHME()
	{
		return this.CLQQNDKPIID().orthographicSize;
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x000B08FC File Offset: 0x000AEAFC
	public static MFMMDFDHOEK MJQNQQLKJHN(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 204f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.MIDLEJPLHME();
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 809f)
		{
			mfmmdfdhoek.Sample(58f, true);
			mfmmdfdhoek.enabled = true;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x0000E03F File Offset: 0x0000C23F
	public float BCCIEGQBFKL()
	{
		return this.LOIGODCOKMP().orthographicSize;
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x0000E04C File Offset: 0x0000C24C
	protected virtual void NCDPHIQEPHD(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.JCHCPGDQLFE(this.CGHQEHCBQHB * (1282f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x000B0948 File Offset: 0x000AEB48
	public static MFMMDFDHOEK IJFBMODIEBQ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MFMMDFDHOEK mfmmdfdhoek = UITweener.Begin<MFMMDFDHOEK>(CGHIENBIHCO, CPKNEQGKQPQ, 1465f);
		mfmmdfdhoek.CGHQEHCBQHB = mfmmdfdhoek.BGBMIEJJQKC;
		mfmmdfdhoek.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1957f)
		{
			mfmmdfdhoek.Sample(1289f, true);
			mfmmdfdhoek.enabled = false;
		}
		return mfmmdfdhoek;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x0000E06B File Offset: 0x0000C26B
	public float JKPCEJEOCLH()
	{
		return this.BLMCLCCIHBI().orthographicSize;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x0000DE18 File Offset: 0x0000C018
	public virtual void CLCEKQGEBLC()
	{
		this.BKMCCCGOGOM = this.BCCIEGQBFKL();
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x0000DE26 File Offset: 0x0000C026
	public Camera BCCKDKGDLDE()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x0000E096 File Offset: 0x0000C296
	protected virtual void JQKIGPHENIF(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.EGDLFEPLBBH(this.CGHQEHCBQHB * (114f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x0000E00A File Offset: 0x0000C20A
	public void QQBMJHLOPEJ(float BGBMIEJJQKC)
	{
		this.LOIGODCOKMP().orthographicSize = BGBMIEJJQKC;
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x0000DFEF File Offset: 0x0000C1EF
	public virtual void NMLKPCEICBQ()
	{
		this.CGHQEHCBQHB = this.KEJFFMLDLOK();
	}

	// Token: 0x0400053D RID: 1341
	public float CGHQEHCBQHB = 1f;

	// Token: 0x0400053E RID: 1342
	public float BKMCCCGOGOM = 1f;

	// Token: 0x0400053F RID: 1343
	private Camera OJIDBLEKBBO;
}
