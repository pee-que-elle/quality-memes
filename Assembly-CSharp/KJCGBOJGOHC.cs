using System;
using UnityEngine;

// Token: 0x02000050 RID: 80
[AddComponentMenu("NGUI/Interaction/Button Rotation")]
public class KJCGBOJGOHC : MonoBehaviour
{
	// Token: 0x06000B1D RID: 2845 RVA: 0x000655C0 File Offset: 0x000637C0
	private void KJLLECIKMED(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.JHQCMGKJCCI();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))) : (this.NCDILLHBJPI * Quaternion.Euler(this.KCICOJFDCPQ))).method = UITweener.JGHNOICEQDB.BounceIn;
		}
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0000660A File Offset: 0x0000480A
	private void HJCCEHMKHQC()
	{
		if (this.PNBOOLEOKCI)
		{
			this.NOQMELHJOKH(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00065648 File Offset: 0x00063848
	private void MGIHECOOQOO(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.JCQCNFLNMNP();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = UITweener.JGHNOICEQDB.BounceIn;
		}
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00006625 File Offset: 0x00004825
	private void GNILDNONNPF(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)4))
		{
			this.NFMELFMMGQP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00006641 File Offset: 0x00004841
	private void BBGHCDGEDEJ()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0000667D File Offset: 0x0000487D
	private void EBIJMQIMQOF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B23 RID: 2851 RVA: 0x00006698 File Offset: 0x00004898
	private void HNPKPINGJID()
	{
		if (this.PNBOOLEOKCI)
		{
			this.DHBHIHIELKJ(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00006641 File Offset: 0x00004841
	private void Start()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x000066B3 File Offset: 0x000048B3
	private void JCQCNFLNMNP()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = false;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x000066EF File Offset: 0x000048EF
	private void FKFPNMBJNKI(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x000656A8 File Offset: 0x000638A8
	private void BHOKCNKPDCM(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.BBGHCDGEDEJ();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00006641 File Offset: 0x00004841
	private void ODOPGCOCHHL()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00006698 File Offset: 0x00004898
	private void QGNEKNMJLID()
	{
		if (this.PNBOOLEOKCI)
		{
			this.DHBHIHIELKJ(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00065708 File Offset: 0x00063908
	private void DNFEFBGLBIB(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.ODOPGCOCHHL();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))) : (this.NCDILLHBJPI * Quaternion.Euler(this.KCICOJFDCPQ))).method = UITweener.JGHNOICEQDB.EaseIn;
		}
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x00065790 File Offset: 0x00063990
	private void JPGLIDEBQKM()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			TweenRotation component = this.DMCGHNCHOHQ.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.value = this.NCDILLHBJPI;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x000657DC File Offset: 0x000639DC
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B2D RID: 2861 RVA: 0x0006583C File Offset: 0x00063A3C
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))) : (this.NCDILLHBJPI * Quaternion.Euler(this.KCICOJFDCPQ))).method = UITweener.JGHNOICEQDB.EaseInOut;
		}
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00065790 File Offset: 0x00063990
	private void NJPBCHDJIDM()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			TweenRotation component = this.DMCGHNCHOHQ.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.value = this.NCDILLHBJPI;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x000658C4 File Offset: 0x00063AC4
	private void NFMELFMMGQP(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00065924 File Offset: 0x00063B24
	private void HMPCDDMJIQQ(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))) : (this.NCDILLHBJPI * Quaternion.Euler(this.KCICOJFDCPQ))).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00065790 File Offset: 0x00063990
	private void DBNCHQFFEOG()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			TweenRotation component = this.DMCGHNCHOHQ.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.value = this.NCDILLHBJPI;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x000659AC File Offset: 0x00063BAC
	private void NOQMELHJOKH(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.JCQCNFLNMNP();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = UITweener.JGHNOICEQDB.Linear;
		}
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x0000667D File Offset: 0x0000487D
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x0000670B File Offset: 0x0000490B
	private void JEIKJFFFEKQ(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00006727 File Offset: 0x00004927
	private void QJPNHMOQMFH(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse))
		{
			this.MGIHECOOQOO(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00006743 File Offset: 0x00004943
	private void BIOKJKMHEFD()
	{
		if (this.PNBOOLEOKCI)
		{
			this.BHOKCNKPDCM(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x00065A0C File Offset: 0x00063C0C
	private void DGDJOKNGOMG()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			TweenRotation component = this.DMCGHNCHOHQ.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.value = this.NCDILLHBJPI;
				component.enabled = true;
			}
		}
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x00065A58 File Offset: 0x00063C58
	private void DHBHIHIELKJ(bool IFFGDNBQHLO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.Start();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!IFFGDNBQHLO) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00006641 File Offset: 0x00004841
	private void KPKQNOCFGIB()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = true;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00065AB8 File Offset: 0x00063CB8
	private void ICJMDBHIKIB(bool FJOEKDCLKIO)
	{
		if (base.enabled)
		{
			if (!this.PNBOOLEOKCI)
			{
				this.KPKQNOCFGIB();
			}
			TweenRotation.Begin(this.DMCGHNCHOHQ.gameObject, this.CPKNEQGKQPQ, (!FJOEKDCLKIO) ? ((!EMENMKHBPQE.KHCLCOKOIHL(base.gameObject)) ? this.NCDILLHBJPI : (this.NCDILLHBJPI * Quaternion.Euler(this.BBIJQCIJQNM))) : (this.NCDILLHBJPI * Quaternion.Euler(this.KCICOJFDCPQ))).method = (UITweener.JGHNOICEQDB)7;
		}
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00065790 File Offset: 0x00063990
	private void OnDisable()
	{
		if (this.PNBOOLEOKCI && this.DMCGHNCHOHQ != null)
		{
			TweenRotation component = this.DMCGHNCHOHQ.GetComponent<TweenRotation>();
			if (component != null)
			{
				component.value = this.NCDILLHBJPI;
				component.enabled = false;
			}
		}
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x0000670B File Offset: 0x0000490B
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x000066B3 File Offset: 0x000048B3
	private void JHQCMGKJCCI()
	{
		if (!this.PNBOOLEOKCI)
		{
			this.PNBOOLEOKCI = false;
			if (this.DMCGHNCHOHQ == null)
			{
				this.DMCGHNCHOHQ = base.transform;
			}
			this.NCDILLHBJPI = this.DMCGHNCHOHQ.localRotation;
		}
	}

	// Token: 0x04000191 RID: 401
	public Transform DMCGHNCHOHQ;

	// Token: 0x04000192 RID: 402
	public Vector3 BBIJQCIJQNM = Vector3.zero;

	// Token: 0x04000193 RID: 403
	public Vector3 KCICOJFDCPQ = Vector3.zero;

	// Token: 0x04000194 RID: 404
	public float CPKNEQGKQPQ = 0.2f;

	// Token: 0x04000195 RID: 405
	private Quaternion NCDILLHBJPI;

	// Token: 0x04000196 RID: 406
	private bool PNBOOLEOKCI;
}
