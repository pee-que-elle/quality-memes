using System;
using UnityEngine;

// Token: 0x0200004F RID: 79
[AddComponentMenu("NGUI/Interaction/Button Offset")]
public class BJLJHNOFGLD : MonoBehaviour
{
	// Token: 0x06000ADF RID: 2783 RVA: 0x00064F00 File Offset: 0x00063100
	private void HMJBLNGEQFO()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00064F4C File Offset: 0x0006314C
	private void GIBEHDOEMDB()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00006185 File Offset: 0x00004385
	private void NMGDOKQLMEG()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x000061BC File Offset: 0x000043BC
	private void JHQCMGKJCCI()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x000061F8 File Offset: 0x000043F8
	private void OLHQILBHHNL()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00006224 File Offset: 0x00004424
	private void PIEQCPMPQMD(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse))
		{
			this.MGIHECOOQOO(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00006240 File Offset: 0x00004440
	private void CQHEEEPPHQH()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0000625B File Offset: 0x0000445B
	private void MDCMKPBIQEH(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.DFDDHNBBDMP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00006277 File Offset: 0x00004477
	private void JHNIPQLONMK()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00064F98 File Offset: 0x00063198
	private void FIMIGCHKHNO(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.MBKJBIQKPGF();
			}
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.Linear;
		}
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x000062A3 File Offset: 0x000044A3
	private void DOGHNJLQJOF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.DFDDHNBBDMP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x000062BE File Offset: 0x000044BE
	private void DPIBGEKNMHP()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = UITweener.JGHNOICEQDB.EaseIn;
		}
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x000062F5 File Offset: 0x000044F5
	private void KBJOKEMFQFN()
	{
		if (this.PNBOOLEOKCI)
		{
			this.MGIHECOOQOO(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x000061BC File Offset: 0x000043BC
	private void GBGEGKHDQKB()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00064F4C File Offset: 0x0006314C
	private void GKPPOKPLBPH()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00006310 File Offset: 0x00004510
	private void HEPFLKMHLOL(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7))
		{
			this.DFDDHNBBDMP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0006501C File Offset: 0x0006321C
	private void JCCMBIHCLCD(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0000632C File Offset: 0x0000452C
	private void HFNOBDDFCDO()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.EaseOut;
		}
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x000650A0 File Offset: 0x000632A0
	private void OnDisable()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.GKHOGHHONGB;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x000061BC File Offset: 0x000043BC
	private void MBKJBIQKPGF()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x000650A0 File Offset: 0x000632A0
	private void FQPFQEDLIFL()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.GKHOGHHONGB;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x00006358 File Offset: 0x00004558
	private void JBEFFMCOIQL()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.EaseOut;
		}
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00006384 File Offset: 0x00004584
	private void POQODIFNQPB(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x000063A0 File Offset: 0x000045A0
	private void PIJJKGGCJIK()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x000063D7 File Offset: 0x000045D7
	private void MKFPDODIHGE()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00006403 File Offset: 0x00004603
	private void KCFPNFCPPCC()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = false;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00006240 File Offset: 0x00004440
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x000650EC File Offset: 0x000632EC
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0000643F File Offset: 0x0000463F
	private void LIGEFJGBFHG()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x000062BE File Offset: 0x000044BE
	private void PHEQFQKIQDQ()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = UITweener.JGHNOICEQDB.EaseIn;
		}
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0000645A File Offset: 0x0000465A
	private void KNLNDFODDGM()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = (UITweener.JGHNOICEQDB)6;
		}
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x0000643F File Offset: 0x0000463F
	private void GKNBOCHLENN()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JKGILEBFHCC(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x000062A3 File Offset: 0x000044A3
	private void EBIJMQIMQOF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.DFDDHNBBDMP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00065148 File Offset: 0x00063348
	private void NFPQKFCHDGM()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.GKHOGHHONGB;
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00006491 File Offset: 0x00004691
	private void FEDNDEHHIFM(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5))
		{
			this.MGIHECOOQOO(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x000064E0 File Offset: 0x000046E0
	private void MCOMOQLFFHP()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.Linear;
		}
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0000650C File Offset: 0x0000470C
	private void NEOBDGHOBGG()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = (UITweener.JGHNOICEQDB)6;
		}
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00065194 File Offset: 0x00063394
	private void DFDDHNBBDMP(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.GBGEGKHDQKB();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)).method = UITweener.JGHNOICEQDB.EaseIn;
		}
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00006538 File Offset: 0x00004738
	private void QJLBKMOKPQC(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7))
		{
			this.JKGILEBFHCC(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B07 RID: 2823 RVA: 0x000651F0 File Offset: 0x000633F0
	private void DKKQFEPDLHB(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.PEJKGQEGPMM();
			}
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = (UITweener.JGHNOICEQDB)6;
		}
	}

	// Token: 0x06000B08 RID: 2824 RVA: 0x00064F00 File Offset: 0x00063100
	private void KPFNGLKEBMD()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00006277 File Offset: 0x00004477
	private void LQBGEEBFNBI()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00064F00 File Offset: 0x00063100
	private void EIICFMBEMFF()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00065274 File Offset: 0x00063474
	private void NQEJNHQNFLJ(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.PEJKGQEGPMM();
			}
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x000652F8 File Offset: 0x000634F8
	private void MGIHECOOQOO(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00006554 File Offset: 0x00004754
	private void CLCDCCHMINK()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = UITweener.JGHNOICEQDB.Linear;
		}
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00006580 File Offset: 0x00004780
	private void BDDLQGNPNBL()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = UITweener.JGHNOICEQDB.BounceIn;
		}
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00065354 File Offset: 0x00063554
	private void HQGGDQDJNQE(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.MBKJBIQKPGF();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.EaseIn;
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x000065B7 File Offset: 0x000047B7
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x000653D8 File Offset: 0x000635D8
	private void OnPress(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00064F00 File Offset: 0x00063100
	private void QMCHEMLDKGI()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x000061BC File Offset: 0x000043BC
	private void Start()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0006545C File Offset: 0x0006365C
	private void COIPCKLMFEK(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.KCFPNFCPPCC();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = UITweener.JGHNOICEQDB.EaseOut;
		}
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x000061BC File Offset: 0x000043BC
	private void PEJKGQEGPMM()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.GKHOGHHONGB = this.DMCGHNCHOHQ.localPosition;
		}
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x000654E0 File Offset: 0x000636E0
	private void QEJPDBIPHQH(bool FJOEKDCLKIO)
	{
		this.EIQLEKDFMMC = FJOEKDCLKIO;
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)) : (this.GKHOGHHONGB + this.KCICOJFDCPQ)).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00065148 File Offset: 0x00063348
	private void MQJJBOQPPGN()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.BGBMIEJJQKC = this.GKHOGHHONGB;
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x000062A3 File Offset: 0x000044A3
	private void OFLEOHNLPCB()
	{
		if (this.PNBOOLEOKCI)
		{
			this.DFDDHNBBDMP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00064F00 File Offset: 0x00063100
	private void EGNIEILNFJH()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			JDMOPNEKJII component = this.DMCGHNCHOHQ.GetComponent<JDMOPNEKJII>();
			if (component != null)
			{
				component.GIPBBFDPCKG(this.GKHOGHHONGB);
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0000650C File Offset: 0x0000470C
	private void MENBEPDBNHJ()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB).method = (UITweener.JGHNOICEQDB)6;
		}
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x000065D3 File Offset: 0x000047D3
	private void JHCMNENIKHJ()
	{
		if (this.EIQLEKDFMMC)
		{
			JDMOPNEKJII.KBGFGBELJOG(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, this.GKHOGHHONGB + this.BBIJQCIJQNM).method = UITweener.JGHNOICEQDB.BounceOut;
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00065564 File Offset: 0x00063764
	private void JKGILEBFHCC(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.KCFPNFCPPCC();
			}
			JDMOPNEKJII.FJCEGFKJLCL(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.GKHOGHHONGB : (this.GKHOGHHONGB + this.BBIJQCIJQNM)).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x0400018A RID: 394
	public Transform DMCGHNCHOHQ;

	// Token: 0x0400018B RID: 395
	public Vector3 BBIJQCIJQNM = Vector3.zero;

	// Token: 0x0400018C RID: 396
	public Vector3 KCICOJFDCPQ = new Vector3(2f, -2f);

	// Token: 0x0400018D RID: 397
	public float CPKNEQGKQPQ = 0.2f;

	// Token: 0x0400018E RID: 398
	[NonSerialized]
	private Vector3 GKHOGHHONGB;

	// Token: 0x0400018F RID: 399
	[NonSerialized]
	private bool PNBOOLEOKCI;

	// Token: 0x04000190 RID: 400
	[NonSerialized]
	private bool EIQLEKDFMMC;
}
