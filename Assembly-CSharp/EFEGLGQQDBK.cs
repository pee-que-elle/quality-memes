using System;
using UnityEngine;

// Token: 0x02000065 RID: 101
[AddComponentMenu("NGUI/UI/Image Button")]
public class EFEGLGQQDBK : MonoBehaviour
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000715B8 File Offset: 0x0006F7B8
	// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00071788 File Offset: 0x0006F988
	public bool GGBPLMICFHN
	{
		get
		{
			Collider component = base.gameObject.GetComponent<Collider>();
			return component && component.enabled;
		}
		set
		{
			Collider component = base.gameObject.GetComponent<Collider>();
			if (!component)
			{
				return;
			}
			if (component.enabled != value)
			{
				component.enabled = value;
				this.MJLPFDOLEOB();
			}
		}
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00008631 File Offset: 0x00006831
	private void BHOKCNKPDCM(bool IFFGDNBQHLO)
	{
		if (this.MPFBGHNIGID() && this.ILBCCCBJNCL != null)
		{
			this.CENHKCHMBEE((!IFFGDNBQHLO) ? this.MNIPPKQLKNL : this.OGEJCFNKILL);
		}
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00008660 File Offset: 0x00006860
	private void OnEnable()
	{
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.GetComponentInChildren<PLQFPBQEPJD>();
		}
		this.MJLPFDOLEOB();
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x000715E4 File Offset: 0x0006F7E4
	private void HNIQNBBBEPB(string QDDJBICKQIG)
	{
		if (!(this.ILBCCCBJNCL.QKGJDCFCPMO == null) && this.ILBCCCBJNCL.QKGJDCFCPMO.KPQNNOJJKDO(QDDJBICKQIG) != null)
		{
			this.ILBCCCBJNCL.JOHBNEHCEJH(QDDJBICKQIG);
			if (this.HQDQHHHMLEJ)
			{
				this.ILBCCCBJNCL.IQFQEOFBQKM();
			}
			return;
		}
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00008682 File Offset: 0x00006882
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (this.GGBPLMICFHN && this.ILBCCCBJNCL != null)
		{
			this.CENHKCHMBEE((!IFFGDNBQHLO) ? this.MNIPPKQLKNL : this.OGEJCFNKILL);
		}
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00071638 File Offset: 0x0006F838
	private void BLCQMMOMFGN(string QDDJBICKQIG)
	{
		if (!(this.ILBCCCBJNCL.QKGJDCFCPMO == null) && this.ILBCCCBJNCL.QKGJDCFCPMO.KPQNNOJJKDO(QDDJBICKQIG) != null)
		{
			this.ILBCCCBJNCL.JLENFJGDNFN(QDDJBICKQIG);
			if (this.HQDQHHHMLEJ)
			{
				this.ILBCCCBJNCL.IQFQEOFBQKM();
			}
			return;
		}
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0007168C File Offset: 0x0006F88C
	private void PDNNMLLFEQF()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.MPFBGHNIGID())
			{
				this.BLCQMMOMFGN((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.MNIPPKQLKNL : this.OGEJCFNKILL);
			}
			else
			{
				this.CENHKCHMBEE(this.OILFJBNPDMH);
			}
		}
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x000086C0 File Offset: 0x000068C0
	private void HMPCDDMJIQQ(bool KCICOJFDCPQ)
	{
		if (KCICOJFDCPQ)
		{
			this.EJDKJHGEFPH(this.MQGOHKQLLKH);
		}
		else
		{
			this.MJLPFDOLEOB();
		}
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x000716E0 File Offset: 0x0006F8E0
	private void CENHKCHMBEE(string QDDJBICKQIG)
	{
		if (!(this.ILBCCCBJNCL.QKGJDCFCPMO == null) && this.ILBCCCBJNCL.QKGJDCFCPMO.GMEDHEOGFMB(QDDJBICKQIG) != null)
		{
			this.ILBCCCBJNCL.KCLBMPFIPNQ = QDDJBICKQIG;
			if (this.HQDQHHHMLEJ)
			{
				this.ILBCCCBJNCL.IQFQEOFBQKM();
			}
			return;
		}
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00071734 File Offset: 0x0006F934
	private void EJDKJHGEFPH(string QDDJBICKQIG)
	{
		if (!(this.ILBCCCBJNCL.QKGJDCFCPMO == null) && this.ILBCCCBJNCL.QKGJDCFCPMO.GMEDHEOGFMB(QDDJBICKQIG) != null)
		{
			this.ILBCCCBJNCL.DPBGHDMHKNC(QDDJBICKQIG);
			if (this.HQDQHHHMLEJ)
			{
				this.ILBCCCBJNCL.IQFQEOFBQKM();
			}
			return;
		}
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x000086D9 File Offset: 0x000068D9
	private void GJNLJPHBPMN(bool IFFGDNBQHLO)
	{
		if (this.MPFBGHNIGID() && this.ILBCCCBJNCL != null)
		{
			this.EJDKJHGEFPH((!IFFGDNBQHLO) ? this.MNIPPKQLKNL : this.OGEJCFNKILL);
		}
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00008708 File Offset: 0x00006908
	private void KJLLECIKMED(bool KCICOJFDCPQ)
	{
		if (KCICOJFDCPQ)
		{
			this.CENHKCHMBEE(this.MQGOHKQLLKH);
		}
		else
		{
			this.PDNNMLLFEQF();
		}
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00008721 File Offset: 0x00006921
	private void OnPress(bool KCICOJFDCPQ)
	{
		if (KCICOJFDCPQ)
		{
			this.CENHKCHMBEE(this.MQGOHKQLLKH);
		}
		else
		{
			this.MJLPFDOLEOB();
		}
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x000717C0 File Offset: 0x0006F9C0
	public bool MPFBGHNIGID()
	{
		Collider component = base.gameObject.GetComponent<Collider>();
		return !component || component.enabled;
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x000717EC File Offset: 0x0006F9EC
	private void OnValidate()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (string.IsNullOrEmpty(this.MNIPPKQLKNL))
			{
				this.MNIPPKQLKNL = this.ILBCCCBJNCL.KCLBMPFIPNQ;
			}
			if (string.IsNullOrEmpty(this.OGEJCFNKILL))
			{
				this.OGEJCFNKILL = this.ILBCCCBJNCL.KCLBMPFIPNQ;
			}
			if (string.IsNullOrEmpty(this.MQGOHKQLLKH))
			{
				this.MQGOHKQLLKH = this.ILBCCCBJNCL.KCLBMPFIPNQ;
			}
			if (string.IsNullOrEmpty(this.OILFJBNPDMH))
			{
				this.OILFJBNPDMH = this.ILBCCCBJNCL.KCLBMPFIPNQ;
			}
		}
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00071880 File Offset: 0x0006FA80
	private void MJLPFDOLEOB()
	{
		if (this.ILBCCCBJNCL != null)
		{
			if (this.GGBPLMICFHN)
			{
				this.CENHKCHMBEE((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.MNIPPKQLKNL : this.OGEJCFNKILL);
			}
			else
			{
				this.CENHKCHMBEE(this.OILFJBNPDMH);
			}
		}
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00008660 File Offset: 0x00006860
	private void EOLBEDLCPHQ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.GetComponentInChildren<PLQFPBQEPJD>();
		}
		this.MJLPFDOLEOB();
	}

	// Token: 0x0400022C RID: 556
	public PLQFPBQEPJD ILBCCCBJNCL;

	// Token: 0x0400022D RID: 557
	public string MNIPPKQLKNL;

	// Token: 0x0400022E RID: 558
	public string OGEJCFNKILL;

	// Token: 0x0400022F RID: 559
	public string MQGOHKQLLKH;

	// Token: 0x04000230 RID: 560
	public string OILFJBNPDMH;

	// Token: 0x04000231 RID: 561
	public bool HQDQHHHMLEJ = true;
}
