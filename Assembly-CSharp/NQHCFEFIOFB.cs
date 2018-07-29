using System;
using UnityEngine;

// Token: 0x02000051 RID: 81
[AddComponentMenu("NGUI/Interaction/Button Scale")]
public class NQHCFEFIOFB : MonoBehaviour
{
	// Token: 0x06000B3F RID: 2879 RVA: 0x00065B40 File Offset: 0x00063D40
	private void HDJICFQCJCN()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.DGEGGLFHBKO;
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00006787 File Offset: 0x00004987
	private void MGBMNEQCEBJ()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.DGEGGLFHBKO = this.DMCGHNCHOHQ.localScale;
		}
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x000067C3 File Offset: 0x000049C3
	private void OFLEOHNLPCB()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00065B8C File Offset: 0x00063D8C
	private void DDPPFDCQGBM()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.QDGMMEOJHBH(this.DGEGGLFHBKO);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x000067DE File Offset: 0x000049DE
	private void KDPEJNLDLQC()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00065BD8 File Offset: 0x00063DD8
	private void OnDisable()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.DGEGGLFHBKO;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00065C24 File Offset: 0x00063E24
	private void CCIIKDGCEIL()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.PMBNQKDEPNN(this.DGEGGLFHBKO);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x00065C70 File Offset: 0x00063E70
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			FPMCQNCDOIP.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.DGEGGLFHBKO : Vector3.Scale(this.DGEGGLFHBKO, this.BBIJQCIJQNM)) : Vector3.Scale(this.DGEGGLFHBKO, this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x000067DE File Offset: 0x000049DE
	private void HQMLEGGKFNF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x000067C3 File Offset: 0x000049C3
	private void NJQGQOPKPFE()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x00006787 File Offset: 0x00004987
	private void IKHIQQKHILB()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.DGEGGLFHBKO = this.DMCGHNCHOHQ.localScale;
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x00006787 File Offset: 0x00004987
	private void Start()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.DGEGGLFHBKO = this.DMCGHNCHOHQ.localScale;
		}
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x00065CEC File Offset: 0x00063EEC
	private void PFNLQGQJBKN(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.BBGHCDGEDEJ();
			}
			FPMCQNCDOIP.CLPJPDDOCHC(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.DGEGGLFHBKO : Vector3.Scale(this.DGEGGLFHBKO, this.BBIJQCIJQNM)) : Vector3.Scale(this.DGEGGLFHBKO, this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.EaseOut;
		}
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00065D68 File Offset: 0x00063F68
	private void EJIEOEGQQII()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.QDGMMEOJHBH(this.DGEGGLFHBKO);
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x000067C3 File Offset: 0x000049C3
	private void CGIQQJOJDNQ()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00065E08 File Offset: 0x00064008
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			FPMCQNCDOIP.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.DGEGGLFHBKO : Vector3.Scale(this.DGEGGLFHBKO, this.BBIJQCIJQNM)).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00065E64 File Offset: 0x00064064
	private void JQEKNQNQEML()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			FPMCQNCDOIP component = this.DMCGHNCHOHQ.GetComponent<FPMCQNCDOIP>();
			if (component != null)
			{
				component.QEKGHBMDIQO(this.DGEGGLFHBKO);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00065EB0 File Offset: 0x000640B0
	private void JKGILEBFHCC(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.IKHIQQKHILB();
			}
			FPMCQNCDOIP.BFJFGJOLILP(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.DGEGGLFHBKO : Vector3.Scale(this.DGEGGLFHBKO, this.BBIJQCIJQNM)).method = UITweener.JGHNOICEQDB.BounceOut;
		}
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x000067F9 File Offset: 0x000049F9
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x000067DE File Offset: 0x000049DE
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x000067C3 File Offset: 0x000049C3
	private void BIQLBDMMDFK()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00065F0C File Offset: 0x0006410C
	private void GJKMFLCNCQK(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.MGBMNEQCEBJ();
			}
			FPMCQNCDOIP.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.DGEGGLFHBKO : Vector3.Scale(this.DGEGGLFHBKO, this.BBIJQCIJQNM)) : Vector3.Scale(this.DGEGGLFHBKO, this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.BounceOut;
		}
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00006787 File Offset: 0x00004987
	private void BBGHCDGEDEJ()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.DGEGGLFHBKO = this.DMCGHNCHOHQ.localScale;
		}
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x000067C3 File Offset: 0x000049C3
	private void EBIJMQIMQOF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00006815 File Offset: 0x00004A15
	private void LHNHINOKDDK(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5))
		{
			this.JKGILEBFHCC(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00006787 File Offset: 0x00004987
	private void FOPKBNIOGCP()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.DGEGGLFHBKO = this.DMCGHNCHOHQ.localScale;
		}
	}

	// Token: 0x04000197 RID: 407
	public Transform DMCGHNCHOHQ;

	// Token: 0x04000198 RID: 408
	public Vector3 BBIJQCIJQNM = new Vector3(1.1f, 1.1f, 1.1f);

	// Token: 0x04000199 RID: 409
	public Vector3 KCICOJFDCPQ = new Vector3(1.05f, 1.05f, 1.05f);

	// Token: 0x0400019A RID: 410
	public float CPKNEQGKQPQ = 0.2f;

	// Token: 0x0400019B RID: 411
	private Vector3 DGEGGLFHBKO;

	// Token: 0x0400019C RID: 412
	private bool PNBOOLEOKCI;
}
