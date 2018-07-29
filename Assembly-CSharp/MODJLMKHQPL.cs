using System;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[AddComponentMenu("NGUI/Tween/Tween Field of View")]
[RequireComponent(typeof(Camera))]
public class MODJLMKHQPL : UITweener
{
	// Token: 0x0600196F RID: 6511 RVA: 0x000AE574 File Offset: 0x000AC774
	public static MODJLMKHQPL FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MODJLMKHQPL modjlmkhqpl = UITweener.Begin<MODJLMKHQPL>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		modjlmkhqpl.CGHQEHCBQHB = modjlmkhqpl.BGBMIEJJQKC;
		modjlmkhqpl.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 0f)
		{
			modjlmkhqpl.Sample(1f, true);
			modjlmkhqpl.enabled = false;
		}
		return modjlmkhqpl;
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x0000D91F File Offset: 0x0000BB1F
	public float POPOMHOFJBO()
	{
		return this.JKPCEJEOCLH();
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06001987 RID: 6535 RVA: 0x0000D9D7 File Offset: 0x0000BBD7
	// (set) Token: 0x06001971 RID: 6513 RVA: 0x0000D927 File Offset: 0x0000BB27
	[Obsolete("Use 'value' instead")]
	public float CLELOFNIEJK
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

	// Token: 0x06001972 RID: 6514 RVA: 0x0000D927 File Offset: 0x0000BB27
	public void BNBQJBHOHCF(float BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x0000D930 File Offset: 0x0000BB30
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x0000D93E File Offset: 0x0000BB3E
	public float FHGPBEBMNLC()
	{
		return this.EQOOPGKHOFB.fieldOfView;
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x0000D94B File Offset: 0x0000BB4B
	private void EEIBINLLKFN()
	{
		this.HHFMGFPDIFL(this.CGHQEHCBQHB);
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x0000D959 File Offset: 0x0000BB59
	public void MBOQMKELMHL(float BGBMIEJJQKC)
	{
		this.KPMBIKBDQPL(BGBMIEJJQKC);
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x0000D962 File Offset: 0x0000BB62
	public float JKPCEJEOCLH()
	{
		return this.MCEGQDQJCED().fieldOfView;
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x0000D96F File Offset: 0x0000BB6F
	public virtual void NQKCOBJHCJD()
	{
		this.BKMCCCGOGOM = this.JKPCEJEOCLH();
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x0000D97D File Offset: 0x0000BB7D
	public virtual void DFOMKKBHNDB()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x0000D98B File Offset: 0x0000BB8B
	public void OHECNGBGKCP(float BGBMIEJJQKC)
	{
		this.LCQHFEQGFLK().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x0000D999 File Offset: 0x0000BB99
	private void QMIIBBPNPMF()
	{
		this.EJBFHKJNELQ(this.CGHQEHCBQHB);
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera MCEGQDQJCED()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x0000D9C9 File Offset: 0x0000BBC9
	public virtual void JNBGQFEJEDL()
	{
		this.CGHQEHCBQHB = this.JKPCEJEOCLH();
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x000AE5C0 File Offset: 0x000AC7C0
	public static MODJLMKHQPL KKOFKCHPCID(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MODJLMKHQPL modjlmkhqpl = UITweener.Begin<MODJLMKHQPL>(CGHIENBIHCO, CPKNEQGKQPQ, 1198f);
		modjlmkhqpl.CGHQEHCBQHB = modjlmkhqpl.JKPCEJEOCLH();
		modjlmkhqpl.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1846f)
		{
			modjlmkhqpl.Sample(144f, true);
			modjlmkhqpl.enabled = true;
		}
		return modjlmkhqpl;
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x0000D9D7 File Offset: 0x0000BBD7
	public float LOGBJGMMDHQ()
	{
		return this.BGBMIEJJQKC;
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x0000D9DF File Offset: 0x0000BBDF
	protected virtual void QDMILBGLJKB(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KPMBIKBDQPL(this.CGHQEHCBQHB * (1596f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ);
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x0000D9FE File Offset: 0x0000BBFE
	public void EJBFHKJNELQ(float BGBMIEJJQKC)
	{
		this.KGLLFCMKCGC().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x000AE60C File Offset: 0x000AC80C
	public static MODJLMKHQPL IOELIBBIPGB(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MODJLMKHQPL modjlmkhqpl = UITweener.Begin<MODJLMKHQPL>(CGHIENBIHCO, CPKNEQGKQPQ, 1625f);
		modjlmkhqpl.CGHQEHCBQHB = modjlmkhqpl.FHGPBEBMNLC();
		modjlmkhqpl.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 455f)
		{
			modjlmkhqpl.Sample(1511f, true);
			modjlmkhqpl.enabled = true;
		}
		return modjlmkhqpl;
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600198F RID: 6543 RVA: 0x0000D93E File Offset: 0x0000BB3E
	// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000DA0C File Offset: 0x0000BC0C
	public float BGBMIEJJQKC
	{
		get
		{
			return this.EQOOPGKHOFB.fieldOfView;
		}
		set
		{
			this.EQOOPGKHOFB.fieldOfView = value;
		}
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x0000DA1A File Offset: 0x0000BC1A
	public virtual void NMLKPCEICBQ()
	{
		this.CGHQEHCBQHB = this.GBHKLOHENQL();
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x0000D91F File Offset: 0x0000BB1F
	public float OOJDIMCKIKE()
	{
		return this.JKPCEJEOCLH();
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x0000DA28 File Offset: 0x0000BC28
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0000DA36 File Offset: 0x0000BC36
	private void JMMKEDHLHQG()
	{
		this.KPMBIKBDQPL(this.CGHQEHCBQHB);
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x0000DA44 File Offset: 0x0000BC44
	public void ONNPPPCJINN(float BGBMIEJJQKC)
	{
		this.OHECNGBGKCP(BGBMIEJJQKC);
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x0000DA4D File Offset: 0x0000BC4D
	public virtual void PENINFJMPDB()
	{
		this.BKMCCCGOGOM = this.GBHKLOHENQL();
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x000AE658 File Offset: 0x000AC858
	public static MODJLMKHQPL BHNPPCIDQMD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MODJLMKHQPL modjlmkhqpl = UITweener.Begin<MODJLMKHQPL>(CGHIENBIHCO, CPKNEQGKQPQ, 1694f);
		modjlmkhqpl.CGHQEHCBQHB = modjlmkhqpl.FHGPBEBMNLC();
		modjlmkhqpl.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 1840f)
		{
			modjlmkhqpl.Sample(872f, false);
			modjlmkhqpl.enabled = false;
		}
		return modjlmkhqpl;
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x0000DA5B File Offset: 0x0000BC5B
	public float LDPDKOQLDDJ()
	{
		return this.JILCINNGENN().fieldOfView;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x0000DA68 File Offset: 0x0000BC68
	public void FJKLHNJCBIG(float BGBMIEJJQKC)
	{
		this.EJBFHKJNELQ(BGBMIEJJQKC);
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x0000DA71 File Offset: 0x0000BC71
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x0000DA7F File Offset: 0x0000BC7F
	public float PJLKHQGNHMH()
	{
		return this.LDPDKOQLDDJ();
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0000D91F File Offset: 0x0000BB1F
	public float BMBINFQGIKJ()
	{
		return this.JKPCEJEOCLH();
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera CCPDIPBCNIJ()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x0000D97D File Offset: 0x0000BB7D
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x0000D9FE File Offset: 0x0000BBFE
	public void KPMBIKBDQPL(float BGBMIEJJQKC)
	{
		this.KGLLFCMKCGC().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06001995 RID: 6549 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
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

	// Token: 0x06001996 RID: 6550 RVA: 0x0000DA87 File Offset: 0x0000BC87
	public void HHFMGFPDIFL(float BGBMIEJJQKC)
	{
		this.CEKFHJQIFJG().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera CEKFHJQIFJG()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0000D96F File Offset: 0x0000BB6F
	public virtual void KEJPPBCPNKH()
	{
		this.BKMCCCGOGOM = this.JKPCEJEOCLH();
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x0000DA0C File Offset: 0x0000BC0C
	public void DGOHLHBIEBK(float BGBMIEJJQKC)
	{
		this.EQOOPGKHOFB.fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x0000DA95 File Offset: 0x0000BC95
	private void QOJJGBKHEMJ()
	{
		this.DGOHLHBIEBK(this.CGHQEHCBQHB);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera JILCINNGENN()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x0000DAA3 File Offset: 0x0000BCA3
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (1f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x0000DAC2 File Offset: 0x0000BCC2
	public float PBHOJCQCNOL()
	{
		return this.GBHKLOHENQL();
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x0000DACA File Offset: 0x0000BCCA
	private void KLJDPGBCPEN()
	{
		this.OHECNGBGKCP(this.BKMCCCGOGOM);
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x0000DAC2 File Offset: 0x0000BCC2
	public float GJJLQENNPQP()
	{
		return this.GBHKLOHENQL();
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x0000DA28 File Offset: 0x0000BC28
	public virtual void BKDFBLJLOKD()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
	protected virtual void CNMFQFMFPDE(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB * (699f - PJDGFDBEOOJ) + this.BKMCCCGOGOM * PJDGFDBEOOJ;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x0000D930 File Offset: 0x0000BB30
	private void QNOFMIPGDPB()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x0000DAF7 File Offset: 0x0000BCF7
	public virtual void MQJPJNPDMPI()
	{
		this.BKMCCCGOGOM = this.FHGPBEBMNLC();
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x0000DB05 File Offset: 0x0000BD05
	public void EIIIDFGLNDL(float BGBMIEJJQKC)
	{
		this.JILCINNGENN().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera KGLLFCMKCGC()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x0000D9FE File Offset: 0x0000BBFE
	public void QHKDFKLEQLK(float BGBMIEJJQKC)
	{
		this.KGLLFCMKCGC().fieldOfView = BGBMIEJJQKC;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0000DB13 File Offset: 0x0000BD13
	public float GBHKLOHENQL()
	{
		return this.LCQHFEQGFLK().fieldOfView;
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x0000D9A7 File Offset: 0x0000BBA7
	public Camera LCQHFEQGFLK()
	{
		if (this.OJIDBLEKBBO == null)
		{
			this.OJIDBLEKBBO = base.GetComponent<Camera>();
		}
		return this.OJIDBLEKBBO;
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x0000DA44 File Offset: 0x0000BC44
	public void DNQMNPKFJKQ(float BGBMIEJJQKC)
	{
		this.OHECNGBGKCP(BGBMIEJJQKC);
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000AE6A4 File Offset: 0x000AC8A4
	public static MODJLMKHQPL COEGBIHCDQE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, float BKMCCCGOGOM)
	{
		MODJLMKHQPL modjlmkhqpl = UITweener.Begin<MODJLMKHQPL>(CGHIENBIHCO, CPKNEQGKQPQ, 1099f);
		modjlmkhqpl.CGHQEHCBQHB = modjlmkhqpl.JKPCEJEOCLH();
		modjlmkhqpl.BKMCCCGOGOM = BKMCCCGOGOM;
		if (CPKNEQGKQPQ <= 493f)
		{
			modjlmkhqpl.Sample(1522f, true);
			modjlmkhqpl.enabled = false;
		}
		return modjlmkhqpl;
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x0000D959 File Offset: 0x0000BB59
	public void OFKEPDQCGIJ(float BGBMIEJJQKC)
	{
		this.KPMBIKBDQPL(BGBMIEJJQKC);
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x0000DB3E File Offset: 0x0000BD3E
	private void DKOINLNEFOG()
	{
		this.OHECNGBGKCP(this.CGHQEHCBQHB);
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x0000DB4C File Offset: 0x0000BD4C
	private void FQHCNKMKEPH()
	{
		this.KPMBIKBDQPL(this.BKMCCCGOGOM);
	}

	// Token: 0x0400051E RID: 1310
	public float CGHQEHCBQHB = 45f;

	// Token: 0x0400051F RID: 1311
	public float BKMCCCGOGOM = 45f;

	// Token: 0x04000520 RID: 1312
	private Camera OJIDBLEKBBO;
}
