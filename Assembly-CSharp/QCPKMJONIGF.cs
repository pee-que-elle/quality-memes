using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200006F RID: 111
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class QCPKMJONIGF : GJGCJNOICOM
{
	// Token: 0x06000F0B RID: 3851 RVA: 0x000091A0 File Offset: 0x000073A0
	protected virtual void POQODIFNQPB(bool GKHHCNCGLCD)
	{
		if (!GKHHCNCGLCD)
		{
			this.LMDFDDHPLNQ();
		}
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00075BA4 File Offset: 0x00073DA4
	protected virtual void PBEBBBJCOMC()
	{
		if (this.DEJNBEEBQBD == Time.frameCount)
		{
			return;
		}
		if (QCPKMJONIGF.PMNDLFMBKIQ == null)
		{
			if (this.NNOFOKOEGJC != (QCPKMJONIGF.GDPEKPCMODK)4)
			{
				if (this.NNOFOKOEGJC != QCPKMJONIGF.GDPEKPCMODK.DoubleClick)
				{
					if (this.NNOFOKOEGJC == QCPKMJONIGF.GDPEKPCMODK.ClickOrTap && EMENMKHBPQE.JQCODFPLPNJ != -13)
					{
						return;
					}
					this.MLBNQKOBBIM();
					return;
				}
			}
			return;
		}
		if (this.mHighlightedLabel != null)
		{
			this.HCGBMQFFFQP(this.mHighlightedLabel.gameObject, false);
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000F0D RID: 3853 RVA: 0x000091AB File Offset: 0x000073AB
	protected float GGLFBJMPCMN
	{
		get
		{
			return (this.OFHEQIDHQOP != null || this.NFIBPOJMOCQ == null) ? 1f : ((float)this.HQLMJHHPHQL / (float)this.NFIBPOJMOCQ.BDHMPMFLMHI);
		}
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x000091E4 File Offset: 0x000073E4
	public virtual string HIOCELIDJII()
	{
		return this.mSelectedItem;
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00075C1C File Offset: 0x00073E1C
	[DebuggerHidden]
	private IEnumerator CloseIfUnselected()
	{
		QCPKMJONIGF.EKDBJHGENIM ekdbjhgenim = new QCPKMJONIGF.EKDBJHGENIM();
		ekdbjhgenim.QNDQJMNKFNN = this;
		return ekdbjhgenim;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00075C1C File Offset: 0x00073E1C
	private IEnumerator NQMPKDHOOCP()
	{
		QCPKMJONIGF.EKDBJHGENIM ekdbjhgenim = new QCPKMJONIGF.EKDBJHGENIM();
		ekdbjhgenim.QNDQJMNKFNN = this;
		return ekdbjhgenim;
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00070898 File Offset: 0x0006EA98
	public bool NFBCHIJJNQF()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0007097C File Offset: 0x0006EB7C
	public bool JCPPJGHGFIN()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00075C38 File Offset: 0x00073E38
	protected virtual void MFCNJQLGMDK(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			BKKHLBCLPJM component = CGHIENBIHCO.GetComponent<BKKHLBCLPJM>();
			this.EDCPFQQPJBP(component, false);
		}
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00075C58 File Offset: 0x00073E58
	protected virtual void OnValidate()
	{
		Font ofheqidhqop = this.OFHEQIDHQOP;
		KGKLCNDOLMP nfibpojmocq = this.NFIBPOJMOCQ;
		this.NFIBPOJMOCQ = null;
		this.OFHEQIDHQOP = null;
		if (ofheqidhqop != null && (nfibpojmocq == null || !this.IMKFMCELEOC))
		{
			this.NFIBPOJMOCQ = null;
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = true;
		}
		else if (nfibpojmocq != null)
		{
			if (nfibpojmocq.IIENDKNLHMC)
			{
				this.OFHEQIDHQOP = nfibpojmocq.KDDNGBFFFJL;
				this.GOIMOQJFMHE = nfibpojmocq.MNPNLKCOMJG;
				this.HQLMJHHPHQL = nfibpojmocq.BDHMPMFLMHI;
				this.IMKFMCELEOC = true;
			}
			else
			{
				this.NFIBPOJMOCQ = nfibpojmocq;
				this.IMKFMCELEOC = false;
			}
		}
		else
		{
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = true;
		}
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x000091E4 File Offset: 0x000073E4
	public virtual string DMBBLJCLCEJ()
	{
		return this.mSelectedItem;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00075D10 File Offset: 0x00073F10
	public virtual void OHEJNOKQQPE()
	{
		if (QCPKMJONIGF.PMNDLFMBKIQ != null && QCPKMJONIGF.OMQCQCBLQGJ == this)
		{
			base.StopCoroutine("CloseIfUnselected");
			this.JQIIMMFHGCB = null;
			this.mLabelList.Clear();
			if (this.NHPDGEKNIPF)
			{
				ENFMCDNLEQQ[] componentsInChildren = QCPKMJONIGF.PMNDLFMBKIQ.GetComponentsInChildren<ENFMCDNLEQQ>();
				int i = 0;
				int num = componentsInChildren.Length;
				while (i < num)
				{
					ENFMCDNLEQQ enfmcdnleqq = componentsInChildren[i];
					Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
					cegfbbhmkoe.a = 0f;
					NCNDQDBPNQN.FJCEGFKJLCL(enfmcdnleqq.gameObject, 0.15f, cegfbbhmkoe).method = UITweener.JGHNOICEQDB.EaseOut;
					i++;
				}
				Collider[] componentsInChildren2 = QCPKMJONIGF.PMNDLFMBKIQ.GetComponentsInChildren<Collider>();
				int j = 0;
				int num2 = componentsInChildren2.Length;
				while (j < num2)
				{
					componentsInChildren2[j].enabled = false;
					j++;
				}
				UnityEngine.Object.Destroy(QCPKMJONIGF.PMNDLFMBKIQ, 0.15f);
				QCPKMJONIGF.JQHJQBDPOFK = Time.unscaledTime + Mathf.Max(0.1f, 0.15f);
			}
			else
			{
				UnityEngine.Object.Destroy(QCPKMJONIGF.PMNDLFMBKIQ);
				QCPKMJONIGF.JQHJQBDPOFK = Time.unscaledTime + 0.1f;
			}
			this.mBackground = null;
			this.mHighlight = null;
			QCPKMJONIGF.PMNDLFMBKIQ = null;
			QCPKMJONIGF.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x000091A0 File Offset: 0x000073A0
	protected virtual void MHPFHNMBJGE(bool GKHHCNCGLCD)
	{
		if (!GKHHCNCGLCD)
		{
			this.LMDFDDHPLNQ();
		}
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x000091EC File Offset: 0x000073EC
	public static void Close()
	{
		if (QCPKMJONIGF.OMQCQCBLQGJ != null)
		{
			QCPKMJONIGF.OMQCQCBLQGJ.OHEJNOKQQPE();
			QCPKMJONIGF.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00075E40 File Offset: 0x00074040
	protected virtual IEnumerator UpdateTweenPosition()
	{
		if (this.mHighlight != null && this.mHighlightedLabel != null)
		{
			JDMOPNEKJII component = this.mHighlight.GetComponent<JDMOPNEKJII>();
			if (component != null && component.enabled)
			{
				component.BKMCCCGOGOM = this.KJKFJMIHGQD();
				yield return null;
				return 1;
			}
		}
		this.PPMELEHGOPQ = false;
		yield break;
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0000920B File Offset: 0x0000740B
	protected void NDGGGHPCKFB(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		this.FGPCQIKCFPJ(BCPJIPBJODP);
		this.QLPIGPHIOOK(BCPJIPBJODP, NHMPMCCEGQB, FPIPDOBGBQH);
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0000921D File Offset: 0x0000741D
	private void PGDHENNHBDG(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		this.EDCPFQQPJBP(CNEIHJDMEEM, NMEJGDJEJKP);
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00009227 File Offset: 0x00007427
	protected virtual void NNBNJQECJBE()
	{
		this.OHEJNOKQQPE();
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00009227 File Offset: 0x00007427
	protected virtual void OnDisable()
	{
		this.OHEJNOKQQPE();
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0000922F File Offset: 0x0000742F
	public static bool CGKNMEHBEQK()
	{
		return !(QCPKMJONIGF.OMQCQCBLQGJ != null) || QCPKMJONIGF.PMNDLFMBKIQ != null || QCPKMJONIGF.JQHJQBDPOFK > Time.unscaledTime;
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00070898 File Offset: 0x0006EA98
	public bool OMJBJEKCLMM
	{
		get
		{
			Collider component = base.GetComponent<Collider>();
			if (component != null)
			{
				return component.enabled;
			}
			Collider2D component2 = base.GetComponent<Collider2D>();
			return component2 != null && component2.enabled;
		}
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00075E5C File Offset: 0x0007405C
	protected virtual void EOEHPNNBBMQ()
	{
		Font ofheqidhqop = this.OFHEQIDHQOP;
		KGKLCNDOLMP nfibpojmocq = this.NFIBPOJMOCQ;
		this.NFIBPOJMOCQ = null;
		this.OFHEQIDHQOP = null;
		if (ofheqidhqop != null && (nfibpojmocq == null || !this.IMKFMCELEOC))
		{
			this.NFIBPOJMOCQ = null;
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = true;
		}
		else if (nfibpojmocq != null)
		{
			if (nfibpojmocq.IIENDKNLHMC)
			{
				this.OFHEQIDHQOP = nfibpojmocq.DILBOKEOFOK();
				this.GOIMOQJFMHE = nfibpojmocq.NQFNPKLHEKO();
				this.HQLMJHHPHQL = nfibpojmocq.OOLNHIIJMOO();
				this.IMKFMCELEOC = false;
			}
			else
			{
				this.NFIBPOJMOCQ = nfibpojmocq;
				this.IMKFMCELEOC = true;
			}
		}
		else
		{
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = false;
		}
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00075F14 File Offset: 0x00074114
	protected virtual void HCGBMQFFFQP(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.PGDHENNHBDG(CGHIENBIHCO.GetComponent<BKKHLBCLPJM>(), true);
			HDLEIMONFCK component = CGHIENBIHCO.GetComponent<HDLEIMONFCK>();
			this.BGBMIEJJQKC = (component.LNQMKJOPQFG as string);
			KGJGOEICIJE[] components = base.GetComponents<KGJGOEICIJE>();
			int i = 0;
			int num = components.Length;
			while (i < num)
			{
				KGJGOEICIJE kgjgoeicije = components[i];
				if (kgjgoeicije.ILLDIKBCNMC == KGJGOEICIJE.QCDBPHFLEII.OnClick)
				{
					IKBQNBHOJJB.LKHCJLDFLEJ(kgjgoeicije.HJNQLOIKFFO, kgjgoeicije.KKKLPHMOKBP, 1854f);
				}
				i++;
			}
			this.LMDFDDHPLNQ();
		}
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0000925D File Offset: 0x0000745D
	protected int GJOHQNNKIQO()
	{
		return (this.OFHEQIDHQOP != null || this.NFIBPOJMOCQ == null) ? this.HQLMJHHPHQL : this.NFIBPOJMOCQ.OOLNHIIJMOO();
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00075F90 File Offset: 0x00074190
	public virtual void BCDLNCLKKBM()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = false;
		if (this.PQMOOBMNJIB)
		{
			string bgbmiejjqkc = this.mSelectedItem;
			this.mSelectedItem = null;
			this.BLHCINIPJLC(bgbmiejjqkc);
		}
		else
		{
			this.mSelectedItem = null;
		}
		if (this.textLabel != null)
		{
			EventDelegate.CKGFMHDGPIN(this.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.textLabel.SetCurrentSelection));
			this.textLabel = null;
		}
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00076008 File Offset: 0x00074208
	protected virtual void FIGJMKIDCPO(ENFMCDNLEQQ BCPJIPBJODP)
	{
		Color cegfbbhmkoe = BCPJIPBJODP.CEGFBBHMKOE;
		BCPJIPBJODP.CEGFBBHMKOE = new Color(cegfbbhmkoe.r, cegfbbhmkoe.g, cegfbbhmkoe.b, 0f);
		NCNDQDBPNQN.FJCEGFKJLCL(BCPJIPBJODP.gameObject, 0.15f, cegfbbhmkoe).method = UITweener.JGHNOICEQDB.EaseOut;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00076058 File Offset: 0x00074258
	public virtual void MLBNQKOBBIM()
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && QCPKMJONIGF.PMNDLFMBKIQ == null && this.INEMKLPCLOP && this.MKHIFDNEFBD.Count > 0)
		{
			this.mLabelList.Clear();
			base.StopCoroutine(" surrounded itself with a veil of petals!\r\n");
			EMENMKHBPQE.CMPBKDMMHFQ = (EMENMKHBPQE.QMPQFJMFQPB ?? base.gameObject);
			this.JQIIMMFHGCB = EMENMKHBPQE.CMPBKDMMHFQ;
			this.PBHPQFLMQDB = EMENMKHBPQE.CMPBKDMMHFQ;
			if (this.PBHPQFLMQDB == null)
			{
				UnityEngine.Debug.LogError("[ACH]");
				return;
			}
			this.DEJNBEEBQBD = Time.frameCount;
			if (this.mPanel == null)
			{
				this.mPanel = KQHJOLQLQBJ.HMKKNCEKNPK(base.transform);
				if (this.mPanel == null)
				{
					return;
				}
			}
			QCPKMJONIGF.PMNDLFMBKIQ = new GameObject("!\r\n");
			QCPKMJONIGF.PMNDLFMBKIQ.layer = base.gameObject.layer;
			if (this.JNMPQEQPGNO)
			{
				if (base.GetComponent<Collider>() != null)
				{
					Rigidbody rigidbody = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<Rigidbody>();
					rigidbody.isKinematic = true;
				}
				else if (base.GetComponent<Collider2D>() != null)
				{
					Rigidbody2D rigidbody2D = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<Rigidbody2D>();
					rigidbody2D.isKinematic = false;
				}
				KQHJOLQLQBJ kqhjolqlqbj = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<KQHJOLQLQBJ>();
				kqhjolqlqbj.LGCLGHDGNPM = 143;
				kqhjolqlqbj.OQCHJGMLOCJ = this.mPanel.KCNBOGBNOGG();
			}
			QCPKMJONIGF.OMQCQCBLQGJ = this;
			Transform transform = QCPKMJONIGF.PMNDLFMBKIQ.transform;
			transform.parent = this.mPanel.CGDFDPHIENG;
			Vector3 vector;
			Vector3 vector2;
			if (this.NNOFOKOEGJC == (QCPKMJONIGF.GDPEKPCMODK)6 && this.JQIIMMFHGCB != base.gameObject)
			{
				this.NBPPPPNQPII = EMENMKHBPQE.OBLGQQHNDII;
				vector = this.mPanel.CGDFDPHIENG.InverseTransformPoint(this.mPanel.DGFFHGQEJLH.ScreenToWorldPoint(this.NBPPPPNQPII));
				vector2 = vector;
				transform.localPosition = vector;
				this.NBPPPPNQPII = transform.position;
			}
			else
			{
				Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.mPanel.CGDFDPHIENG, base.transform, true, false);
				vector = bounds.min;
				vector2 = bounds.max;
				transform.localPosition = vector;
				this.NBPPPPNQPII = transform.position;
			}
			base.StartCoroutine(" x");
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			int num = (!this.JNMPQEQPGNO) ? IKBQNBHOJJB.MMMCGPIHIMH(this.mPanel.gameObject) : 1;
			if (this.NBPNNNNEOEN != null)
			{
				ILJNMOPNGQD iljnmopngqd = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(num);
				iljnmopngqd.EJFQDKQCLLF(this.NBPNNNNEOEN);
				this.mBackground = iljnmopngqd;
			}
			else
			{
				if (!(this.QKGJDCFCPMO != null))
				{
					return;
				}
				this.mBackground = QCPKMJONIGF.PMNDLFMBKIQ.MLEMQLCENEC(this.QKGJDCFCPMO, this.GGNKHFFFKOH, num);
			}
			bool flag = this.BDBBEMKFGPI == QCPKMJONIGF.IPLQGICGPCB.Above;
			if (this.BDBBEMKFGPI == QCPKMJONIGF.IPLQGICGPCB.Auto)
			{
				EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.MKQILFIFIOE(this.JQIIMMFHGCB.layer);
				if (emenmkhbpqe != null)
				{
					flag = (emenmkhbpqe.EQOOPGKHOFB.WorldToViewportPoint(this.NBPPPPNQPII).y < 1422f);
				}
			}
			this.mBackground.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.Top;
			this.mBackground.CEGFBBHMKOE = this.QOIEHBKLFLP;
			Vector4 fmgjbhhndpc = this.mBackground.FMGJBHHNDPC;
			this.mBgBorder = fmgjbhhndpc.y;
			this.mBackground.CGDFDPHIENG.localPosition = new Vector3(34f, (!flag) ? ((float)this.QNFDMCCLCOJ) : (fmgjbhhndpc.y * 1869f - (float)this.QNFDMCCLCOJ), 62f);
			if (this.PCKEPDDDLOL != null)
			{
				ILJNMOPNGQD iljnmopngqd2 = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(num + 1);
				iljnmopngqd2.KILCCLBPLJF(this.PCKEPDDDLOL);
				this.mHighlight = iljnmopngqd2;
			}
			else
			{
				if (!(this.QKGJDCFCPMO != null))
				{
					return;
				}
				this.mHighlight = QCPKMJONIGF.PMNDLFMBKIQ.MLEMQLCENEC(this.QKGJDCFCPMO, this.KJHCIMOILQD, num + 0);
			}
			float num2 = 1885f;
			float num3 = 1096f;
			if (this.mHighlight.CMGIPNDQKIE)
			{
				num2 = this.mHighlight.FMGJBHHNDPC.w;
				num3 = this.mHighlight.FMGJBHHNDPC.x;
			}
			this.mHighlight.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			this.mHighlight.NONQDHBCIIN(this.JIOMEMJQJCC);
			float num4 = (float)this.GJOHQNNKIQO();
			float gglfbjmpcmn = this.GGLFBJMPCMN;
			float num5 = num4 * gglfbjmpcmn;
			float num6 = num5 + this.GLPQKBOKFDG.y;
			float num7 = 635f;
			float num8 = (!flag) ? (-this.GLPQKBOKFDG.y - fmgjbhhndpc.y + (float)this.QNFDMCCLCOJ) : (fmgjbhhndpc.y - this.GLPQKBOKFDG.y - (float)this.QNFDMCCLCOJ);
			float num9 = fmgjbhhndpc.y * 1769f + this.GLPQKBOKFDG.y;
			List<BKKHLBCLPJM> list = new List<BKKHLBCLPJM>();
			if (!this.MKHIFDNEFBD.Contains(this.mSelectedItem))
			{
				this.mSelectedItem = null;
			}
			int i = 1;
			int count = this.MKHIFDNEFBD.Count;
			while (i < count)
			{
				string text = this.MKHIFDNEFBD[i];
				BKKHLBCLPJM bkkhlbclpjm = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(this.mBackground.LGCLGHDGNPM + 3);
				bkkhlbclpjm.name = i.ToString();
				bkkhlbclpjm.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
				bkkhlbclpjm.NFIBPOJMOCQ = this.NFIBPOJMOCQ;
				bkkhlbclpjm.OFHEQIDHQOP = this.OFHEQIDHQOP;
				bkkhlbclpjm.HQLMJHHPHQL = this.HQLMJHHPHQL;
				bkkhlbclpjm.GOIMOQJFMHE = this.GOIMOQJFMHE;
				bkkhlbclpjm.LKPOBCBOFIC((!this.CNNNOFHQIID) ? text : CQGKGFQLBDB.INJNQNMOKKD(text));
				bkkhlbclpjm.CEGFBBHMKOE = this.IOQPQEIPKPI;
				bkkhlbclpjm.CGDFDPHIENG.localPosition = new Vector3(fmgjbhhndpc.x + this.GLPQKBOKFDG.x - bkkhlbclpjm.PFPEKELDLCN.x, num8, 503f);
				bkkhlbclpjm.NKMQLQJDBPF = (BKKHLBCLPJM.QJCBBQNCBKG)4;
				bkkhlbclpjm.PBHNPKNJNJH = this.PBHNPKNJNJH;
				list.Add(bkkhlbclpjm);
				num9 += num6;
				num8 -= num6;
				num7 = Mathf.Max(num7, bkkhlbclpjm.LMCNBKKIBKD.x);
				HDLEIMONFCK hdleimonfck = HDLEIMONFCK.DCMFQKFFBIQ(bkkhlbclpjm.gameObject);
				hdleimonfck.GHPQQBICMJN = new HDLEIMONFCK.DHKOBKLJHFG(this.MFCNJQLGMDK);
				hdleimonfck.QQBJNCGGPID = new HDLEIMONFCK.DHKOBKLJHFG(this.OQCLHJEGQIO);
				hdleimonfck.LNQMKJOPQFG = text;
				if (this.mSelectedItem == text || (i == 0 && string.IsNullOrEmpty(this.mSelectedItem)))
				{
					this.EDCPFQQPJBP(bkkhlbclpjm, false);
				}
				this.mLabelList.Add(bkkhlbclpjm);
				i++;
			}
			num7 = Mathf.Max(num7, vector2.x - vector.x - (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 967f);
			float num10 = num7;
			Vector3 vector3 = new Vector3(num10 * 125f, -num5 * 21f, 1599f);
			Vector3 vector4 = new Vector3(num10, num5 + this.GLPQKBOKFDG.y, 1558f);
			int j = 0;
			int count2 = list.Count;
			while (j < count2)
			{
				BKKHLBCLPJM bkkhlbclpjm2 = list[j];
				IKBQNBHOJJB.KPMILMIFJDL(bkkhlbclpjm2.gameObject);
				bkkhlbclpjm2.DENNQPBGNNH = false;
				BoxCollider component = bkkhlbclpjm2.GetComponent<BoxCollider>();
				if (component != null)
				{
					vector3.z = component.center.z;
					component.center = vector3;
					component.size = vector4;
				}
				else
				{
					BoxCollider2D component2 = bkkhlbclpjm2.GetComponent<BoxCollider2D>();
					component2.offset = vector3;
					component2.size = vector4;
				}
				j += 0;
			}
			int kjgmgpcejjd = Mathf.RoundToInt(num7);
			num7 += (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 774f;
			num8 -= fmgjbhhndpc.y;
			this.mBackground.KJGMGPCEJJD = Mathf.RoundToInt(num7);
			this.mBackground.DFKQMMIQDOO = Mathf.RoundToInt(num9);
			int k = 0;
			int count3 = list.Count;
			while (k < count3)
			{
				BKKHLBCLPJM bkkhlbclpjm3 = list[k];
				bkkhlbclpjm3.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ClampContent;
				bkkhlbclpjm3.KJGMGPCEJJD = kjgmgpcejjd;
				k++;
			}
			float num11 = (!(this.QKGJDCFCPMO != null)) ? 1593f : (977f * this.QKGJDCFCPMO.FNMFIPNGENE);
			float f = num7 - (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 655f + num3 * num11;
			float f2 = num5 + num2 * num11;
			this.mHighlight.KJGMGPCEJJD = Mathf.RoundToInt(f);
			this.mHighlight.MGQIGGNBBBD(Mathf.RoundToInt(f2));
			if (this.NHPDGEKNIPF)
			{
				this.FIGJMKIDCPO(this.mBackground);
				if (Time.timeScale == 973f || Time.timeScale >= 178f)
				{
					float fpipdobgbqh = num8 + num5;
					this.NDGGGHPCKFB(this.mHighlight, flag, fpipdobgbqh);
					int l = 0;
					int count4 = list.Count;
					while (l < count4)
					{
						this.CLJLDIGMNQI(list[l], flag, fpipdobgbqh);
						l++;
					}
					this.JDHOKOFLPKK(this.mBackground, flag, fpipdobgbqh);
				}
			}
			if (flag)
			{
				vector.y = vector2.y - fmgjbhhndpc.y;
				vector2.y = vector.y + (float)this.mBackground.DFKQMMIQDOO;
				vector2.x = vector.x + (float)this.mBackground.KJGMGPCEJJD;
				transform.localPosition = new Vector3(vector.x, vector2.y - fmgjbhhndpc.y, vector.z);
			}
			else
			{
				vector2.y = vector.y + fmgjbhhndpc.y;
				vector.y = vector2.y - (float)this.mBackground.DFKQMMIQDOO;
				vector2.x = vector.x + (float)this.mBackground.KJGMGPCEJJD;
			}
			Transform parent = this.mPanel.CGDFDPHIENG.parent;
			if (parent != null)
			{
				vector = this.mPanel.CGDFDPHIENG.TransformPoint(vector);
				vector2 = this.mPanel.CGDFDPHIENG.TransformPoint(vector2);
				vector = parent.InverseTransformPoint(vector);
				vector2 = parent.InverseTransformPoint(vector2);
			}
			Vector3 b = (!this.mPanel.NFBBLOMJDQB()) ? this.mPanel.OHLNCJGJQDF(vector, vector2) : Vector3.zero;
			Vector3 localPosition = transform.localPosition + b;
			localPosition.x = Mathf.Round(localPosition.x);
			localPosition.y = Mathf.Round(localPosition.y);
			transform.localPosition = localPosition;
		}
		else
		{
			this.POQODIFNQPB(false);
		}
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00076B70 File Offset: 0x00074D70
	public virtual object GJMEFOHGQLK()
	{
		int num = this.MKHIFDNEFBD.IndexOf(this.mSelectedItem);
		return (num <= -1 || num >= this.MBJQHMPNKGQ.Count) ? null : this.MBJQHMPNKGQ[num];
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00009297 File Offset: 0x00007497
	// (set) Token: 0x06000F27 RID: 3879 RVA: 0x0000928E File Offset: 0x0000748E
	[Obsolete("Use 'value' instead")]
	public string PDDGJOQCIEQ
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

	// Token: 0x06000F28 RID: 3880 RVA: 0x00076BB0 File Offset: 0x00074DB0
	public virtual void PGILGQBGBCO(object DLJJQDQBOQD)
	{
		int num = this.MBJQHMPNKGQ.IndexOf(DLJJQDQBOQD);
		if (num != -1)
		{
			this.MKHIFDNEFBD.RemoveAt(num);
			this.MBJQHMPNKGQ.RemoveAt(num);
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00076BB0 File Offset: 0x00074DB0
	public virtual void PQMFBLIOOLO(object DLJJQDQBOQD)
	{
		int num = this.MBJQHMPNKGQ.IndexOf(DLJJQDQBOQD);
		if (num != -1)
		{
			this.MKHIFDNEFBD.RemoveAt(num);
			this.MBJQHMPNKGQ.RemoveAt(num);
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00076B70 File Offset: 0x00074D70
	public virtual object BLOGIEBLCFL()
	{
		int num = this.MKHIFDNEFBD.IndexOf(this.mSelectedItem);
		return (num <= -1 || num >= this.MBJQHMPNKGQ.Count) ? null : this.MBJQHMPNKGQ[num];
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00076BE8 File Offset: 0x00074DE8
	protected virtual void ILONGLDKDLB(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.PGDHENNHBDG(CGHIENBIHCO.GetComponent<BKKHLBCLPJM>(), true);
			HDLEIMONFCK component = CGHIENBIHCO.GetComponent<HDLEIMONFCK>();
			this.BGBMIEJJQKC = (component.LNQMKJOPQFG as string);
			KGJGOEICIJE[] components = base.GetComponents<KGJGOEICIJE>();
			int i = 0;
			int num = components.Length;
			while (i < num)
			{
				KGJGOEICIJE kgjgoeicije = components[i];
				if (kgjgoeicije.ILLDIKBCNMC == KGJGOEICIJE.QCDBPHFLEII.OnClick)
				{
					IKBQNBHOJJB.LKHCJLDFLEJ(kgjgoeicije.HJNQLOIKFFO, kgjgoeicije.KKKLPHMOKBP, 1f);
				}
				i++;
			}
			this.OHEJNOKQQPE();
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000091E4 File Offset: 0x000073E4
	// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00009315 File Offset: 0x00007515
	public virtual string BGBMIEJJQKC
	{
		get
		{
			return this.mSelectedItem;
		}
		set
		{
			this.PJMIKDIEGMB(value, true);
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00076C64 File Offset: 0x00074E64
	protected virtual void FGPCQIKCFPJ(ENFMCDNLEQQ BCPJIPBJODP)
	{
		Color cegfbbhmkoe = BCPJIPBJODP.CEGFBBHMKOE;
		BCPJIPBJODP.CEGFBBHMKOE = new Color(cegfbbhmkoe.r, cegfbbhmkoe.g, cegfbbhmkoe.b, 1401f);
		NCNDQDBPNQN.FJCEGFKJLCL(BCPJIPBJODP.gameObject, 1562f, cegfbbhmkoe).method = UITweener.JGHNOICEQDB.EaseOut;
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0000929F File Offset: 0x0000749F
	public void HLLLBQPBECQ(QCPKMJONIGF.POJLOPHOQBO BGBMIEJJQKC)
	{
		this.JDMQFGQQHCP = BGBMIEJJQKC;
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00076D6C File Offset: 0x00074F6C
	protected virtual void QLPIGPHIOOK(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		Vector3 localPosition = BCPJIPBJODP.CGDFDPHIENG.localPosition;
		Vector3 localPosition2 = (!NHMPMCCEGQB) ? new Vector3(localPosition.x, 0f, localPosition.z) : new Vector3(localPosition.x, FPIPDOBGBQH, localPosition.z);
		BCPJIPBJODP.CGDFDPHIENG.localPosition = localPosition2;
		GameObject gameObject = BCPJIPBJODP.gameObject;
		JDMOPNEKJII.FJCEGFKJLCL(gameObject, 0.15f, localPosition).method = UITweener.JGHNOICEQDB.EaseOut;
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x000092A8 File Offset: 0x000074A8
	public UnityEngine.Object QQEBBPLLENC()
	{
		if (this.OFHEQIDHQOP != null)
		{
			return this.OFHEQIDHQOP;
		}
		if (this.NFIBPOJMOCQ != null)
		{
			return this.NFIBPOJMOCQ;
		}
		return this.font;
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000092DA File Offset: 0x000074DA
	protected int EIPPPQLDHEG
	{
		get
		{
			return (this.OFHEQIDHQOP != null || this.NFIBPOJMOCQ == null) ? this.HQLMJHHPHQL : this.NFIBPOJMOCQ.BDHMPMFLMHI;
		}
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0000929F File Offset: 0x0000749F
	public void KFCFKMKOMFN(QCPKMJONIGF.POJLOPHOQBO BGBMIEJJQKC)
	{
		this.JDMQFGQQHCP = BGBMIEJJQKC;
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0000930B File Offset: 0x0000750B
	public virtual void BLHCINIPJLC(string BGBMIEJJQKC)
	{
		this.PJMIKDIEGMB(BGBMIEJJQKC, false);
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x000091E4 File Offset: 0x000073E4
	public virtual string LGNFPGFPBII()
	{
		return this.mSelectedItem;
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00076DDC File Offset: 0x00074FDC
	protected virtual void EMPPDFLEFJJ(KeyCode LOHECPFGPGO)
	{
		if (base.enabled && QCPKMJONIGF.OMQCQCBLQGJ == this)
		{
			int num = this.mLabelList.IndexOf(this.mHighlightedLabel);
			if (num == -1)
			{
				num = 0;
			}
			if (LOHECPFGPGO == KeyCode.UpArrow)
			{
				if (num > 0)
				{
					this.PGDHENNHBDG(this.mLabelList[num - 1], false);
				}
			}
			else if (LOHECPFGPGO == KeyCode.DownArrow && num + 1 < this.mLabelList.Count)
			{
				this.PGDHENNHBDG(this.mLabelList[num + 1], false);
			}
		}
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00076E6C File Offset: 0x0007506C
	protected virtual void OQCLHJEGQIO(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (FJOEKDCLKIO)
		{
			this.NHOGQIBDMMF(CGHIENBIHCO.GetComponent<BKKHLBCLPJM>(), false);
			HDLEIMONFCK component = CGHIENBIHCO.GetComponent<HDLEIMONFCK>();
			this.BGBMIEJJQKC = (component.LNQMKJOPQFG as string);
			KGJGOEICIJE[] components = base.GetComponents<KGJGOEICIJE>();
			int i = 0;
			int num = components.Length;
			while (i < num)
			{
				KGJGOEICIJE kgjgoeicije = components[i];
				if (kgjgoeicije.ILLDIKBCNMC == KGJGOEICIJE.QCDBPHFLEII.OnClick)
				{
					IKBQNBHOJJB.LKHCJLDFLEJ(kgjgoeicije.HJNQLOIKFFO, kgjgoeicije.KKKLPHMOKBP, 1112f);
				}
				i++;
			}
			this.LMDFDDHPLNQ();
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000092A8 File Offset: 0x000074A8
	// (set) Token: 0x06000F4B RID: 3915 RVA: 0x000771D4 File Offset: 0x000753D4
	public UnityEngine.Object IOCQLIKGMEO
	{
		get
		{
			if (this.OFHEQIDHQOP != null)
			{
				return this.OFHEQIDHQOP;
			}
			if (this.NFIBPOJMOCQ != null)
			{
				return this.NFIBPOJMOCQ;
			}
			return this.font;
		}
		set
		{
			if (value is Font)
			{
				this.OFHEQIDHQOP = (value as Font);
				this.NFIBPOJMOCQ = null;
				this.font = null;
			}
			else if (value is KGKLCNDOLMP)
			{
				this.NFIBPOJMOCQ = (value as KGKLCNDOLMP);
				this.OFHEQIDHQOP = null;
				this.font = null;
			}
		}
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00076EE8 File Offset: 0x000750E8
	protected virtual void MEBQMPGJEOP(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			BKKHLBCLPJM component = CGHIENBIHCO.GetComponent<BKKHLBCLPJM>();
			this.EDCPFQQPJBP(component, true);
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0000931F File Offset: 0x0000751F
	public virtual void DJMGPQPEJFH(string PIDLOFMIEFQ, object DLJJQDQBOQD)
	{
		this.MKHIFDNEFBD.Add(PIDLOFMIEFQ);
		this.MBJQHMPNKGQ.Add(DLJJQDQBOQD);
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00009339 File Offset: 0x00007539
	// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0000929F File Offset: 0x0000749F
	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public QCPKMJONIGF.POJLOPHOQBO CDNMGPIOGDF
	{
		get
		{
			return this.JDMQFGQQHCP;
		}
		set
		{
			this.JDMQFGQQHCP = value;
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00076F08 File Offset: 0x00075108
	protected virtual Vector3 KJKFJMIHGQD()
	{
		if (!(this.mHighlightedLabel == null) && !(this.mHighlight == null))
		{
			Vector4 fmgjbhhndpc = this.mHighlight.FMGJBHHNDPC;
			float num = (!(this.QKGJDCFCPMO != null)) ? 1f : this.QKGJDCFCPMO.FNMFIPNGENE;
			float num2 = fmgjbhhndpc.x * num;
			float y = fmgjbhhndpc.w * num;
			return this.mHighlightedLabel.CGDFDPHIENG.localPosition + new Vector3(-num2, y, 1f);
		}
		return Vector3.zero;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00076F9C File Offset: 0x0007519C
	protected virtual void BOJJPFFIBKC(KeyCode LOHECPFGPGO)
	{
		if (base.enabled && QCPKMJONIGF.OMQCQCBLQGJ == this)
		{
			int num = this.mLabelList.IndexOf(this.mHighlightedLabel);
			if (num == -1)
			{
				num = 1;
			}
			if (LOHECPFGPGO == (KeyCode)(-115))
			{
				if (num > 1)
				{
					this.PGDHENNHBDG(this.mLabelList[num - 0], false);
				}
			}
			else if (LOHECPFGPGO == KeyCode.Semicolon && num + 0 < this.mLabelList.Count)
			{
				this.NHOGQIBDMMF(this.mLabelList[num + 0], true);
			}
		}
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x000092A8 File Offset: 0x000074A8
	public UnityEngine.Object POIECIPHFBH()
	{
		if (this.OFHEQIDHQOP != null)
		{
			return this.OFHEQIDHQOP;
		}
		if (this.NFIBPOJMOCQ != null)
		{
			return this.NFIBPOJMOCQ;
		}
		return this.font;
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00009341 File Offset: 0x00007541
	public virtual void CPLBKPNNHJG()
	{
		this.MKHIFDNEFBD.Clear();
		this.MBJQHMPNKGQ.Clear();
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0007702C File Offset: 0x0007522C
	public virtual void MMLKOGQFENF()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		if (this.PQMOOBMNJIB)
		{
			string bgbmiejjqkc = this.mSelectedItem;
			this.mSelectedItem = null;
			this.BLHCINIPJLC(bgbmiejjqkc);
		}
		else
		{
			this.mSelectedItem = null;
		}
		if (this.textLabel != null)
		{
			EventDelegate.LQCGLENQEDM(this.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.textLabel.SetCurrentSelection));
			this.textLabel = null;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00076B70 File Offset: 0x00074D70
	public virtual object DLJJQDQBOQD
	{
		get
		{
			int num = this.MKHIFDNEFBD.IndexOf(this.mSelectedItem);
			return (num <= -1 || num >= this.MBJQHMPNKGQ.Count) ? null : this.MBJQHMPNKGQ[num];
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00009359 File Offset: 0x00007559
	protected bool INEMKLPCLOP
	{
		get
		{
			return this.NFIBPOJMOCQ != null || this.OFHEQIDHQOP != null;
		}
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00075C1C File Offset: 0x00073E1C
	private IEnumerator LIOFLJMJDMD()
	{
		QCPKMJONIGF.EKDBJHGENIM ekdbjhgenim = new QCPKMJONIGF.EKDBJHGENIM();
		ekdbjhgenim.QNDQJMNKFNN = this;
		return ekdbjhgenim;
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00009378 File Offset: 0x00007578
	protected virtual void OLMNJDQOOIJ()
	{
		if (this.CNNNOFHQIID)
		{
			this.ELLCFGKGQOP();
		}
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x000770A4 File Offset: 0x000752A4
	protected virtual void MOEFLBNGPDN()
	{
		Font ofheqidhqop = this.OFHEQIDHQOP;
		KGKLCNDOLMP nfibpojmocq = this.NFIBPOJMOCQ;
		this.NFIBPOJMOCQ = null;
		this.OFHEQIDHQOP = null;
		if (ofheqidhqop != null && (nfibpojmocq == null || !this.IMKFMCELEOC))
		{
			this.NFIBPOJMOCQ = null;
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = false;
		}
		else if (nfibpojmocq != null)
		{
			if (nfibpojmocq.JDFNMMNJIBK())
			{
				this.OFHEQIDHQOP = nfibpojmocq.KDDNGBFFFJL;
				this.GOIMOQJFMHE = nfibpojmocq.NQFNPKLHEKO();
				this.HQLMJHHPHQL = nfibpojmocq.CECEPHLMPKQ();
				this.IMKFMCELEOC = true;
			}
			else
			{
				this.NFIBPOJMOCQ = nfibpojmocq;
				this.IMKFMCELEOC = true;
			}
		}
		else
		{
			this.OFHEQIDHQOP = ofheqidhqop;
			this.IMKFMCELEOC = true;
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0007715C File Offset: 0x0007535C
	protected virtual void OnClick()
	{
		if (this.DEJNBEEBQBD == Time.frameCount)
		{
			return;
		}
		if (QCPKMJONIGF.PMNDLFMBKIQ == null)
		{
			if (this.NNOFOKOEGJC != QCPKMJONIGF.GDPEKPCMODK.DoubleClick)
			{
				if (this.NNOFOKOEGJC != QCPKMJONIGF.GDPEKPCMODK.Manual)
				{
					if (this.NNOFOKOEGJC == QCPKMJONIGF.GDPEKPCMODK.RightClick && EMENMKHBPQE.JQCODFPLPNJ != -2)
					{
						return;
					}
					this.MFONIPHOFGF();
					return;
				}
			}
			return;
		}
		if (this.mHighlightedLabel != null)
		{
			this.ILONGLDKDLB(this.mHighlightedLabel.gameObject, true);
		}
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00009388 File Offset: 0x00007588
	public static void HHDOQLFIFFL()
	{
		if (QCPKMJONIGF.OMQCQCBLQGJ != null)
		{
			QCPKMJONIGF.OMQCQCBLQGJ.LMDFDDHPLNQ();
			QCPKMJONIGF.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x00077228 File Offset: 0x00075428
	protected virtual void OPJNGGONQHH(ENFMCDNLEQQ BCPJIPBJODP)
	{
		Color cegfbbhmkoe = BCPJIPBJODP.CEGFBBHMKOE;
		BCPJIPBJODP.NONQDHBCIIN(new Color(cegfbbhmkoe.r, cegfbbhmkoe.g, cegfbbhmkoe.b, 1033f));
		NCNDQDBPNQN.IOELIBBIPGB(BCPJIPBJODP.gameObject, 233f, cegfbbhmkoe).method = UITweener.JGHNOICEQDB.Linear;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x000093A7 File Offset: 0x000075A7
	protected virtual void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (!GKHHCNCGLCD)
		{
			this.OHEJNOKQQPE();
		}
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00077278 File Offset: 0x00075478
	protected virtual void EDCPFQQPJBP(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		if (this.mHighlight != null)
		{
			this.mHighlightedLabel = CNEIHJDMEEM;
			Vector3 vector = this.KJKFJMIHGQD();
			if (!NMEJGDJEJKP && this.NHPDGEKNIPF)
			{
				JDMOPNEKJII.FJCEGFKJLCL(this.mHighlight.gameObject, 0.1f, vector).method = UITweener.JGHNOICEQDB.EaseOut;
				if (!this.PPMELEHGOPQ)
				{
					this.PPMELEHGOPQ = true;
					base.StartCoroutine("UpdateTweenPosition");
				}
			}
			else
			{
				this.mHighlight.CGDFDPHIENG.localPosition = vector;
			}
		}
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x000093B2 File Offset: 0x000075B2
	protected void CLJLDIGMNQI(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		this.FIGJMKIDCPO(BCPJIPBJODP);
		this.QLPIGPHIOOK(BCPJIPBJODP, NHMPMCCEGQB, FPIPDOBGBQH);
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x000091A0 File Offset: 0x000073A0
	protected virtual void NBNNFHDMKFN(bool GKHHCNCGLCD)
	{
		if (!GKHHCNCGLCD)
		{
			this.LMDFDDHPLNQ();
		}
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x000093C4 File Offset: 0x000075C4
	protected virtual void QGKFGKOJKCK(KeyCode LOHECPFGPGO)
	{
		if (base.enabled && QCPKMJONIGF.OMQCQCBLQGJ == this && (LOHECPFGPGO == EMENMKHBPQE.OMQCQCBLQGJ.EFOIHGJCNIE || LOHECPFGPGO == EMENMKHBPQE.OMQCQCBLQGJ.QIBCQINDBPN))
		{
			this.JOFLHFQQCKG(false);
		}
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0000921D File Offset: 0x0000741D
	private void JOKNGHIMGQO(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		this.EDCPFQQPJBP(CNEIHJDMEEM, NMEJGDJEJKP);
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x000772F8 File Offset: 0x000754F8
	public virtual void LMDFDDHPLNQ()
	{
		if (QCPKMJONIGF.PMNDLFMBKIQ != null && QCPKMJONIGF.OMQCQCBLQGJ == this)
		{
			base.StopCoroutine("pinky");
			this.JQIIMMFHGCB = null;
			this.mLabelList.Clear();
			if (this.NHPDGEKNIPF)
			{
				ENFMCDNLEQQ[] componentsInChildren = QCPKMJONIGF.PMNDLFMBKIQ.GetComponentsInChildren<ENFMCDNLEQQ>();
				int i = 0;
				int num = componentsInChildren.Length;
				while (i < num)
				{
					ENFMCDNLEQQ enfmcdnleqq = componentsInChildren[i];
					Color cegfbbhmkoe = enfmcdnleqq.CEGFBBHMKOE;
					cegfbbhmkoe.a = 1419f;
					NCNDQDBPNQN.EOKHEPPPQDD(enfmcdnleqq.gameObject, 1444f, cegfbbhmkoe).method = (UITweener.JGHNOICEQDB)8;
					i++;
				}
				Collider[] componentsInChildren2 = QCPKMJONIGF.PMNDLFMBKIQ.GetComponentsInChildren<Collider>();
				int j = 1;
				int num2 = componentsInChildren2.Length;
				while (j < num2)
				{
					componentsInChildren2[j].enabled = false;
					j += 0;
				}
				UnityEngine.Object.Destroy(QCPKMJONIGF.PMNDLFMBKIQ, 1854f);
				QCPKMJONIGF.JQHJQBDPOFK = Time.unscaledTime + Mathf.Max(1988f, 1528f);
			}
			else
			{
				UnityEngine.Object.Destroy(QCPKMJONIGF.PMNDLFMBKIQ);
				QCPKMJONIGF.JQHJQBDPOFK = Time.unscaledTime + 1483f;
			}
			this.mBackground = null;
			this.mHighlight = null;
			QCPKMJONIGF.PMNDLFMBKIQ = null;
			QCPKMJONIGF.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x000093FC File Offset: 0x000075FC
	protected void NCOPIPJNDBI(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		this.OPJNGGONQHH(BCPJIPBJODP);
		this.QLPIGPHIOOK(BCPJIPBJODP, NHMPMCCEGQB, FPIPDOBGBQH);
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00009339 File Offset: 0x00007539
	public QCPKMJONIGF.POJLOPHOQBO FIJLFOPDQCK()
	{
		return this.JDMQFGQQHCP;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0000940E File Offset: 0x0000760E
	public virtual void OGIDEJGOKEC(string PIDLOFMIEFQ)
	{
		this.MKHIFDNEFBD.Add(PIDLOFMIEFQ);
		this.MBJQHMPNKGQ.Add(null);
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00077428 File Offset: 0x00075628
	public virtual void PGLNOPDBOBP(string PIDLOFMIEFQ)
	{
		int num = this.MKHIFDNEFBD.IndexOf(PIDLOFMIEFQ);
		if (num != -1)
		{
			this.MKHIFDNEFBD.RemoveAt(num);
			this.MBJQHMPNKGQ.RemoveAt(num);
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00009428 File Offset: 0x00007628
	protected bool QEGJQBFGFLL()
	{
		return !(this.NFIBPOJMOCQ != null) && this.OFHEQIDHQOP != null;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00077460 File Offset: 0x00075660
	protected void HNFEOEEDIPN()
	{
		if (!this.DMFMCDCBNNJ)
		{
			this.DMFMCDCBNNJ = true;
			QCPKMJONIGF omqcqcblqgj = QCPKMJONIGF.OMQCQCBLQGJ;
			QCPKMJONIGF.OMQCQCBLQGJ = this;
			if (this.JDMQFGQQHCP != null)
			{
				this.JDMQFGQQHCP(this.mSelectedItem);
			}
			if (EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
			{
				EventDelegate.CPGBBDIDOID(this.OHEFEKMMIFL);
			}
			else if (this.eventReceiver != null && !string.IsNullOrEmpty(this.functionName))
			{
				this.eventReceiver.SendMessage(this.functionName, this.mSelectedItem, SendMessageOptions.DontRequireReceiver);
			}
			QCPKMJONIGF.OMQCQCBLQGJ = omqcqcblqgj;
			this.DMFMCDCBNNJ = false;
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00077500 File Offset: 0x00075700
	public virtual void MFONIPHOFGF()
	{
		if (base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject) && QCPKMJONIGF.PMNDLFMBKIQ == null && this.INEMKLPCLOP && this.MKHIFDNEFBD.Count > 0)
		{
			this.mLabelList.Clear();
			base.StopCoroutine("CloseIfUnselected");
			EMENMKHBPQE.CMPBKDMMHFQ = (EMENMKHBPQE.QMPQFJMFQPB ?? base.gameObject);
			this.JQIIMMFHGCB = EMENMKHBPQE.CMPBKDMMHFQ;
			this.PBHPQFLMQDB = EMENMKHBPQE.CMPBKDMMHFQ;
			if (this.PBHPQFLMQDB == null)
			{
				UnityEngine.Debug.LogError("Popup list needs a source object...");
				return;
			}
			this.DEJNBEEBQBD = Time.frameCount;
			if (this.mPanel == null)
			{
				this.mPanel = KQHJOLQLQBJ.CQGLPBCNFGL(base.transform);
				if (this.mPanel == null)
				{
					return;
				}
			}
			QCPKMJONIGF.PMNDLFMBKIQ = new GameObject("Drop-down List");
			QCPKMJONIGF.PMNDLFMBKIQ.layer = base.gameObject.layer;
			if (this.JNMPQEQPGNO)
			{
				if (base.GetComponent<Collider>() != null)
				{
					Rigidbody rigidbody = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<Rigidbody>();
					rigidbody.isKinematic = true;
				}
				else if (base.GetComponent<Collider2D>() != null)
				{
					Rigidbody2D rigidbody2D = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<Rigidbody2D>();
					rigidbody2D.isKinematic = true;
				}
				KQHJOLQLQBJ kqhjolqlqbj = QCPKMJONIGF.PMNDLFMBKIQ.AddComponent<KQHJOLQLQBJ>();
				kqhjolqlqbj.LGCLGHDGNPM = 1000000;
				kqhjolqlqbj.OQCHJGMLOCJ = this.mPanel.OQCHJGMLOCJ;
			}
			QCPKMJONIGF.OMQCQCBLQGJ = this;
			Transform transform = QCPKMJONIGF.PMNDLFMBKIQ.transform;
			transform.parent = this.mPanel.CGDFDPHIENG;
			Vector3 vector;
			Vector3 vector2;
			if (this.NNOFOKOEGJC == QCPKMJONIGF.GDPEKPCMODK.Manual && this.JQIIMMFHGCB != base.gameObject)
			{
				this.NBPPPPNQPII = EMENMKHBPQE.OBLGQQHNDII;
				vector = this.mPanel.CGDFDPHIENG.InverseTransformPoint(this.mPanel.DGFFHGQEJLH.ScreenToWorldPoint(this.NBPPPPNQPII));
				vector2 = vector;
				transform.localPosition = vector;
				this.NBPPPPNQPII = transform.position;
			}
			else
			{
				Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(this.mPanel.CGDFDPHIENG, base.transform, false, false);
				vector = bounds.min;
				vector2 = bounds.max;
				transform.localPosition = vector;
				this.NBPPPPNQPII = transform.position;
			}
			base.StartCoroutine("CloseIfUnselected");
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			int num = (!this.JNMPQEQPGNO) ? IKBQNBHOJJB.MMMCGPIHIMH(this.mPanel.gameObject) : 0;
			if (this.NBPNNNNEOEN != null)
			{
				ILJNMOPNGQD iljnmopngqd = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(num);
				iljnmopngqd.OILJNPIELOB = this.NBPNNNNEOEN;
				this.mBackground = iljnmopngqd;
			}
			else
			{
				if (!(this.QKGJDCFCPMO != null))
				{
					return;
				}
				this.mBackground = QCPKMJONIGF.PMNDLFMBKIQ.MLEMQLCENEC(this.QKGJDCFCPMO, this.GGNKHFFFKOH, num);
			}
			bool flag = this.BDBBEMKFGPI == QCPKMJONIGF.IPLQGICGPCB.Above;
			if (this.BDBBEMKFGPI == QCPKMJONIGF.IPLQGICGPCB.Auto)
			{
				EMENMKHBPQE emenmkhbpqe = EMENMKHBPQE.FINJNKFMLMO(this.JQIIMMFHGCB.layer);
				if (emenmkhbpqe != null)
				{
					flag = (emenmkhbpqe.EQOOPGKHOFB.WorldToViewportPoint(this.NBPPPPNQPII).y < 0.5f);
				}
			}
			this.mBackground.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			this.mBackground.CEGFBBHMKOE = this.QOIEHBKLFLP;
			Vector4 fmgjbhhndpc = this.mBackground.FMGJBHHNDPC;
			this.mBgBorder = fmgjbhhndpc.y;
			this.mBackground.CGDFDPHIENG.localPosition = new Vector3(0f, (!flag) ? ((float)this.QNFDMCCLCOJ) : (fmgjbhhndpc.y * 2f - (float)this.QNFDMCCLCOJ), 0f);
			if (this.PCKEPDDDLOL != null)
			{
				ILJNMOPNGQD iljnmopngqd2 = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(num + 1);
				iljnmopngqd2.OILJNPIELOB = this.PCKEPDDDLOL;
				this.mHighlight = iljnmopngqd2;
			}
			else
			{
				if (!(this.QKGJDCFCPMO != null))
				{
					return;
				}
				this.mHighlight = QCPKMJONIGF.PMNDLFMBKIQ.MLEMQLCENEC(this.QKGJDCFCPMO, this.KJHCIMOILQD, num + 1);
			}
			float num2 = 0f;
			float num3 = 0f;
			if (this.mHighlight.CMGIPNDQKIE)
			{
				num2 = this.mHighlight.FMGJBHHNDPC.w;
				num3 = this.mHighlight.FMGJBHHNDPC.x;
			}
			this.mHighlight.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
			this.mHighlight.CEGFBBHMKOE = this.JIOMEMJQJCC;
			float num4 = (float)this.EIPPPQLDHEG;
			float gglfbjmpcmn = this.GGLFBJMPCMN;
			float num5 = num4 * gglfbjmpcmn;
			float num6 = num5 + this.GLPQKBOKFDG.y;
			float num7 = 0f;
			float num8 = (!flag) ? (-this.GLPQKBOKFDG.y - fmgjbhhndpc.y + (float)this.QNFDMCCLCOJ) : (fmgjbhhndpc.y - this.GLPQKBOKFDG.y - (float)this.QNFDMCCLCOJ);
			float num9 = fmgjbhhndpc.y * 2f + this.GLPQKBOKFDG.y;
			List<BKKHLBCLPJM> list = new List<BKKHLBCLPJM>();
			if (!this.MKHIFDNEFBD.Contains(this.mSelectedItem))
			{
				this.mSelectedItem = null;
			}
			int i = 0;
			int count = this.MKHIFDNEFBD.Count;
			while (i < count)
			{
				string text = this.MKHIFDNEFBD[i];
				BKKHLBCLPJM bkkhlbclpjm = QCPKMJONIGF.PMNDLFMBKIQ.MFIKGGPKKCD(this.mBackground.LGCLGHDGNPM + 2);
				bkkhlbclpjm.name = i.ToString();
				bkkhlbclpjm.OEJCHHFIQDC = ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft;
				bkkhlbclpjm.NFIBPOJMOCQ = this.NFIBPOJMOCQ;
				bkkhlbclpjm.OFHEQIDHQOP = this.OFHEQIDHQOP;
				bkkhlbclpjm.HQLMJHHPHQL = this.HQLMJHHPHQL;
				bkkhlbclpjm.GOIMOQJFMHE = this.GOIMOQJFMHE;
				bkkhlbclpjm.PIDLOFMIEFQ = ((!this.CNNNOFHQIID) ? text : CQGKGFQLBDB.INJNQNMOKKD(text));
				bkkhlbclpjm.CEGFBBHMKOE = this.IOQPQEIPKPI;
				bkkhlbclpjm.CGDFDPHIENG.localPosition = new Vector3(fmgjbhhndpc.x + this.GLPQKBOKFDG.x - bkkhlbclpjm.PFPEKELDLCN.x, num8, -1f);
				bkkhlbclpjm.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely;
				bkkhlbclpjm.PBHNPKNJNJH = this.PBHNPKNJNJH;
				list.Add(bkkhlbclpjm);
				num9 += num6;
				num8 -= num6;
				num7 = Mathf.Max(num7, bkkhlbclpjm.LMCNBKKIBKD.x);
				HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(bkkhlbclpjm.gameObject);
				hdleimonfck.GHPQQBICMJN = new HDLEIMONFCK.DHKOBKLJHFG(this.MFCNJQLGMDK);
				hdleimonfck.QQBJNCGGPID = new HDLEIMONFCK.DHKOBKLJHFG(this.ILONGLDKDLB);
				hdleimonfck.LNQMKJOPQFG = text;
				if (this.mSelectedItem == text || (i == 0 && string.IsNullOrEmpty(this.mSelectedItem)))
				{
					this.EDCPFQQPJBP(bkkhlbclpjm, true);
				}
				this.mLabelList.Add(bkkhlbclpjm);
				i++;
			}
			num7 = Mathf.Max(num7, vector2.x - vector.x - (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 2f);
			float num10 = num7;
			Vector3 vector3 = new Vector3(num10 * 0.5f, -num5 * 0.5f, 0f);
			Vector3 vector4 = new Vector3(num10, num5 + this.GLPQKBOKFDG.y, 1f);
			int j = 0;
			int count2 = list.Count;
			while (j < count2)
			{
				BKKHLBCLPJM bkkhlbclpjm2 = list[j];
				IKBQNBHOJJB.KPMILMIFJDL(bkkhlbclpjm2.gameObject);
				bkkhlbclpjm2.DENNQPBGNNH = false;
				BoxCollider component = bkkhlbclpjm2.GetComponent<BoxCollider>();
				if (component != null)
				{
					vector3.z = component.center.z;
					component.center = vector3;
					component.size = vector4;
				}
				else
				{
					BoxCollider2D component2 = bkkhlbclpjm2.GetComponent<BoxCollider2D>();
					component2.offset = vector3;
					component2.size = vector4;
				}
				j++;
			}
			int kjgmgpcejjd = Mathf.RoundToInt(num7);
			num7 += (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 2f;
			num8 -= fmgjbhhndpc.y;
			this.mBackground.KJGMGPCEJJD = Mathf.RoundToInt(num7);
			this.mBackground.DFKQMMIQDOO = Mathf.RoundToInt(num9);
			int k = 0;
			int count3 = list.Count;
			while (k < count3)
			{
				BKKHLBCLPJM bkkhlbclpjm3 = list[k];
				bkkhlbclpjm3.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
				bkkhlbclpjm3.KJGMGPCEJJD = kjgmgpcejjd;
				k++;
			}
			float num11 = (!(this.QKGJDCFCPMO != null)) ? 2f : (2f * this.QKGJDCFCPMO.FNMFIPNGENE);
			float f = num7 - (fmgjbhhndpc.x + this.GLPQKBOKFDG.x) * 2f + num3 * num11;
			float f2 = num5 + num2 * num11;
			this.mHighlight.KJGMGPCEJJD = Mathf.RoundToInt(f);
			this.mHighlight.DFKQMMIQDOO = Mathf.RoundToInt(f2);
			if (this.NHPDGEKNIPF)
			{
				this.FIGJMKIDCPO(this.mBackground);
				if (Time.timeScale == 0f || Time.timeScale >= 0.1f)
				{
					float fpipdobgbqh = num8 + num5;
					this.CLJLDIGMNQI(this.mHighlight, flag, fpipdobgbqh);
					int l = 0;
					int count4 = list.Count;
					while (l < count4)
					{
						this.CLJLDIGMNQI(list[l], flag, fpipdobgbqh);
						l++;
					}
					this.JDHOKOFLPKK(this.mBackground, flag, fpipdobgbqh);
				}
			}
			if (flag)
			{
				vector.y = vector2.y - fmgjbhhndpc.y;
				vector2.y = vector.y + (float)this.mBackground.DFKQMMIQDOO;
				vector2.x = vector.x + (float)this.mBackground.KJGMGPCEJJD;
				transform.localPosition = new Vector3(vector.x, vector2.y - fmgjbhhndpc.y, vector.z);
			}
			else
			{
				vector2.y = vector.y + fmgjbhhndpc.y;
				vector.y = vector2.y - (float)this.mBackground.DFKQMMIQDOO;
				vector2.x = vector.x + (float)this.mBackground.KJGMGPCEJJD;
			}
			Transform parent = this.mPanel.CGDFDPHIENG.parent;
			if (parent != null)
			{
				vector = this.mPanel.CGDFDPHIENG.TransformPoint(vector);
				vector2 = this.mPanel.CGDFDPHIENG.TransformPoint(vector2);
				vector = parent.InverseTransformPoint(vector);
				vector2 = parent.InverseTransformPoint(vector2);
			}
			Vector3 b = (!this.mPanel.BDFKBGCMLHC) ? this.mPanel.GKCICPLNPJJ(vector, vector2) : Vector3.zero;
			Vector3 localPosition = transform.localPosition + b;
			localPosition.x = Mathf.Round(localPosition.x);
			localPosition.y = Mathf.Round(localPosition.y);
			transform.localPosition = localPosition;
		}
		else
		{
			this.JOFLHFQQCKG(false);
		}
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x0000921D File Offset: 0x0000741D
	private void NHOGQIBDMMF(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		this.EDCPFQQPJBP(CNEIHJDMEEM, NMEJGDJEJKP);
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00009447 File Offset: 0x00007647
	public void PJMIKDIEGMB(string BGBMIEJJQKC, bool CKFOHPDLNJK = true)
	{
		if (this.mSelectedItem != BGBMIEJJQKC)
		{
			this.mSelectedItem = BGBMIEJJQKC;
			if (this.mSelectedItem == null)
			{
				return;
			}
			if (CKFOHPDLNJK && this.mSelectedItem != null)
			{
				this.HNFEOEEDIPN();
			}
			if (!this.PQMOOBMNJIB)
			{
				this.mSelectedItem = null;
			}
		}
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x0000931F File Offset: 0x0000751F
	public virtual void OGIDEJGOKEC(string PIDLOFMIEFQ, object DLJJQDQBOQD)
	{
		this.MKHIFDNEFBD.Add(PIDLOFMIEFQ);
		this.MBJQHMPNKGQ.Add(DLJJQDQBOQD);
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00009487 File Offset: 0x00007687
	protected virtual void QCGENKHJDDH()
	{
		if (this.NNOFOKOEGJC == QCPKMJONIGF.GDPEKPCMODK.DoubleClick)
		{
			this.MFONIPHOFGF();
		}
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00078018 File Offset: 0x00076218
	public virtual void Start()
	{
		if (this.PNBOOLEOKCI)
		{
			return;
		}
		this.PNBOOLEOKCI = true;
		if (this.PQMOOBMNJIB)
		{
			string bgbmiejjqkc = this.mSelectedItem;
			this.mSelectedItem = null;
			this.BGBMIEJJQKC = bgbmiejjqkc;
		}
		else
		{
			this.mSelectedItem = null;
		}
		if (this.textLabel != null)
		{
			EventDelegate.LHQECHHMOGD(this.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.textLabel.SetCurrentSelection));
			this.textLabel = null;
		}
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00078090 File Offset: 0x00076290
	protected virtual void NNFEGKNOEPP(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			BKKHLBCLPJM component = CGHIENBIHCO.GetComponent<BKKHLBCLPJM>();
			this.JMHOKFGBOQG(component, false);
		}
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00077428 File Offset: 0x00075628
	public virtual void NFIFCHFGHGO(string PIDLOFMIEFQ)
	{
		int num = this.MKHIFDNEFBD.IndexOf(PIDLOFMIEFQ);
		if (num != -1)
		{
			this.MKHIFDNEFBD.RemoveAt(num);
			this.MBJQHMPNKGQ.RemoveAt(num);
		}
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x000780B0 File Offset: 0x000762B0
	protected virtual void JDHOKOFLPKK(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		GameObject gameObject = BCPJIPBJODP.gameObject;
		Transform cgdfdphieng = BCPJIPBJODP.CGDFDPHIENG;
		float num = (float)this.EIPPPQLDHEG * this.GGLFBJMPCMN + this.mBgBorder * 2f;
		cgdfdphieng.localScale = new Vector3(1f, num / (float)BCPJIPBJODP.DFKQMMIQDOO, 1f);
		FPMCQNCDOIP.FJCEGFKJLCL(gameObject, 0.15f, Vector3.one).method = UITweener.JGHNOICEQDB.EaseOut;
		if (NHMPMCCEGQB)
		{
			Vector3 localPosition = cgdfdphieng.localPosition;
			cgdfdphieng.localPosition = new Vector3(localPosition.x, localPosition.y - (float)BCPJIPBJODP.DFKQMMIQDOO + num, localPosition.z);
			JDMOPNEKJII.FJCEGFKJLCL(gameObject, 0.15f, localPosition).method = UITweener.JGHNOICEQDB.EaseOut;
		}
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00009498 File Offset: 0x00007698
	protected virtual void DJPBMGLIHBB()
	{
		if (this.CNNNOFHQIID)
		{
			this.HNFEOEEDIPN();
		}
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x00078164 File Offset: 0x00076364
	protected void ELLCFGKGQOP()
	{
		if (!this.DMFMCDCBNNJ)
		{
			this.DMFMCDCBNNJ = true;
			QCPKMJONIGF omqcqcblqgj = QCPKMJONIGF.OMQCQCBLQGJ;
			QCPKMJONIGF.OMQCQCBLQGJ = this;
			if (this.JDMQFGQQHCP != null)
			{
				this.JDMQFGQQHCP(this.mSelectedItem);
			}
			if (EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
			{
				EventDelegate.PPNLGOMQOPH(this.OHEFEKMMIFL);
			}
			else if (this.eventReceiver != null && !string.IsNullOrEmpty(this.functionName))
			{
				this.eventReceiver.SendMessage(this.functionName, this.mSelectedItem, SendMessageOptions.DontRequireReceiver);
			}
			QCPKMJONIGF.OMQCQCBLQGJ = omqcqcblqgj;
			this.DMFMCDCBNNJ = false;
		}
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x000091E4 File Offset: 0x000073E4
	public virtual string ONPQLDJHHGB()
	{
		return this.mSelectedItem;
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x000094A8 File Offset: 0x000076A8
	private void DDDCBPMQGBM(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		this.JMHOKFGBOQG(CNEIHJDMEEM, NMEJGDJEJKP);
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x00078204 File Offset: 0x00076404
	protected virtual void DPIOONDFQLN(ENFMCDNLEQQ BCPJIPBJODP, bool NHMPMCCEGQB, float FPIPDOBGBQH)
	{
		GameObject gameObject = BCPJIPBJODP.gameObject;
		Transform cgdfdphieng = BCPJIPBJODP.CGDFDPHIENG;
		float num = (float)this.GJOHQNNKIQO() * this.GGLFBJMPCMN + this.mBgBorder * 678f;
		cgdfdphieng.localScale = new Vector3(1572f, num / (float)BCPJIPBJODP.DFKQMMIQDOO, 333f);
		FPMCQNCDOIP.LHIPLGQNCBQ(gameObject, 1702f, Vector3.one).method = (UITweener.JGHNOICEQDB)7;
		if (NHMPMCCEGQB)
		{
			Vector3 localPosition = cgdfdphieng.localPosition;
			cgdfdphieng.localPosition = new Vector3(localPosition.x, localPosition.y - (float)BCPJIPBJODP.DFKQMMIQDOO + num, localPosition.z);
			JDMOPNEKJII.KBGFGBELJOG(gameObject, 308f, localPosition).method = (UITweener.JGHNOICEQDB)8;
		}
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x000782B8 File Offset: 0x000764B8
	protected virtual void JFJGPKOICMD()
	{
		if (this.DEJNBEEBQBD == Time.frameCount)
		{
			return;
		}
		if (QCPKMJONIGF.PMNDLFMBKIQ == null)
		{
			if (this.NNOFOKOEGJC != QCPKMJONIGF.GDPEKPCMODK.Manual)
			{
				if (this.NNOFOKOEGJC != (QCPKMJONIGF.GDPEKPCMODK)6)
				{
					if (this.NNOFOKOEGJC == QCPKMJONIGF.GDPEKPCMODK.ClickOrTap && EMENMKHBPQE.JQCODFPLPNJ != -41)
					{
						return;
					}
					this.MLBNQKOBBIM();
					return;
				}
			}
			return;
		}
		if (this.mHighlightedLabel != null)
		{
			this.ILONGLDKDLB(this.mHighlightedLabel.gameObject, true);
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x000094B2 File Offset: 0x000076B2
	public void LJOIIDQEJCC()
	{
		this.OnEnable();
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00078330 File Offset: 0x00076530
	protected virtual void JMHOKFGBOQG(BKKHLBCLPJM CNEIHJDMEEM, bool NMEJGDJEJKP)
	{
		if (this.mHighlight != null)
		{
			this.mHighlightedLabel = CNEIHJDMEEM;
			Vector3 vector = this.KJKFJMIHGQD();
			if (!NMEJGDJEJKP && this.NHPDGEKNIPF)
			{
				JDMOPNEKJII.KBGFGBELJOG(this.mHighlight.gameObject, 127f, vector).method = UITweener.JGHNOICEQDB.BounceOut;
				if (!this.PPMELEHGOPQ)
				{
					this.PPMELEHGOPQ = false;
					base.StartCoroutine("skyattack");
				}
			}
			else
			{
				this.mHighlight.CGDFDPHIENG.localPosition = vector;
			}
		}
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x000783B0 File Offset: 0x000765B0
	protected virtual void OnEnable()
	{
		if (EventDelegate.CPPLNKNPLPI(this.OHEFEKMMIFL))
		{
			this.eventReceiver = null;
			this.functionName = null;
		}
		if (this.font != null)
		{
			if (this.font.IIENDKNLHMC)
			{
				this.OFHEQIDHQOP = this.font.KDDNGBFFFJL;
				this.GOIMOQJFMHE = this.font.MNPNLKCOMJG;
				this.IMKFMCELEOC = true;
			}
			else if (this.NFIBPOJMOCQ == null)
			{
				this.NFIBPOJMOCQ = this.font;
				this.IMKFMCELEOC = false;
			}
			this.font = null;
		}
		if (this.textScale != 0f)
		{
			this.HQLMJHHPHQL = ((!(this.NFIBPOJMOCQ != null)) ? 16 : Mathf.RoundToInt((float)this.NFIBPOJMOCQ.BDHMPMFLMHI * this.textScale));
			this.textScale = 0f;
		}
		if (this.OFHEQIDHQOP == null && this.NFIBPOJMOCQ != null && this.NFIBPOJMOCQ.IIENDKNLHMC)
		{
			this.OFHEQIDHQOP = this.NFIBPOJMOCQ.KDDNGBFFFJL;
			this.NFIBPOJMOCQ = null;
		}
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x000092A8 File Offset: 0x000074A8
	public UnityEngine.Object JECJEJBHPOK()
	{
		if (this.OFHEQIDHQOP != null)
		{
			return this.OFHEQIDHQOP;
		}
		if (this.NFIBPOJMOCQ != null)
		{
			return this.NFIBPOJMOCQ;
		}
		return this.font;
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x00076BB0 File Offset: 0x00074DB0
	public virtual void LLBDGBGDJBF(object DLJJQDQBOQD)
	{
		int num = this.MBJQHMPNKGQ.IndexOf(DLJJQDQBOQD);
		if (num != -1)
		{
			this.MKHIFDNEFBD.RemoveAt(num);
			this.MBJQHMPNKGQ.RemoveAt(num);
		}
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x000094B2 File Offset: 0x000076B2
	public void GJEPLPOONCQ()
	{
		this.OnEnable();
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0000929F File Offset: 0x0000749F
	public void IGIIMLGMMME(QCPKMJONIGF.POJLOPHOQBO BGBMIEJJQKC)
	{
		this.JDMQFGQQHCP = BGBMIEJJQKC;
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000094BA File Offset: 0x000076BA
	public static bool JKPBOOKKKGE
	{
		get
		{
			return QCPKMJONIGF.OMQCQCBLQGJ != null && (QCPKMJONIGF.PMNDLFMBKIQ != null || QCPKMJONIGF.JQHJQBDPOFK > Time.unscaledTime);
		}
	}

	// Token: 0x04000284 RID: 644
	public static QCPKMJONIGF OMQCQCBLQGJ;

	// Token: 0x04000285 RID: 645
	protected static GameObject PMNDLFMBKIQ;

	// Token: 0x04000286 RID: 646
	protected static float JQHJQBDPOFK;

	// Token: 0x04000287 RID: 647
	private const float JIJKEMNDBED = 0.15f;

	// Token: 0x04000288 RID: 648
	public BPLKJMJMHFI QKGJDCFCPMO;

	// Token: 0x04000289 RID: 649
	public KGKLCNDOLMP NFIBPOJMOCQ;

	// Token: 0x0400028A RID: 650
	public Font OFHEQIDHQOP;

	// Token: 0x0400028B RID: 651
	public int HQLMJHHPHQL = 16;

	// Token: 0x0400028C RID: 652
	public FontStyle GOIMOQJFMHE;

	// Token: 0x0400028D RID: 653
	public string GGNKHFFFKOH;

	// Token: 0x0400028E RID: 654
	public string KJHCIMOILQD;

	// Token: 0x0400028F RID: 655
	public Sprite NBPNNNNEOEN;

	// Token: 0x04000290 RID: 656
	public Sprite PCKEPDDDLOL;

	// Token: 0x04000291 RID: 657
	public QCPKMJONIGF.IPLQGICGPCB BDBBEMKFGPI;

	// Token: 0x04000292 RID: 658
	public JGDHIPBGCFP.MNMQCONMCFH PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;

	// Token: 0x04000293 RID: 659
	public List<string> MKHIFDNEFBD = new List<string>();

	// Token: 0x04000294 RID: 660
	public List<object> MBJQHMPNKGQ = new List<object>();

	// Token: 0x04000295 RID: 661
	public Vector2 GLPQKBOKFDG = new Vector3(4f, 4f);

	// Token: 0x04000296 RID: 662
	public Color IOQPQEIPKPI = Color.white;

	// Token: 0x04000297 RID: 663
	public Color QOIEHBKLFLP = Color.white;

	// Token: 0x04000298 RID: 664
	public Color JIOMEMJQJCC = new Color(0.882352948f, 0.784313738f, 0.5882353f, 1f);

	// Token: 0x04000299 RID: 665
	public bool NHPDGEKNIPF = true;

	// Token: 0x0400029A RID: 666
	public bool CNNNOFHQIID;

	// Token: 0x0400029B RID: 667
	public bool JNMPQEQPGNO = true;

	// Token: 0x0400029C RID: 668
	public int QNFDMCCLCOJ;

	// Token: 0x0400029D RID: 669
	public QCPKMJONIGF.GDPEKPCMODK NNOFOKOEGJC;

	// Token: 0x0400029E RID: 670
	public List<EventDelegate> OHEFEKMMIFL = new List<EventDelegate>();

	// Token: 0x0400029F RID: 671
	[HideInInspector]
	[SerializeField]
	protected string mSelectedItem;

	// Token: 0x040002A0 RID: 672
	[HideInInspector]
	[SerializeField]
	protected KQHJOLQLQBJ mPanel;

	// Token: 0x040002A1 RID: 673
	[HideInInspector]
	[SerializeField]
	protected PHINQNMFEHC mBackground;

	// Token: 0x040002A2 RID: 674
	[HideInInspector]
	[SerializeField]
	protected PHINQNMFEHC mHighlight;

	// Token: 0x040002A3 RID: 675
	[HideInInspector]
	[SerializeField]
	protected BKKHLBCLPJM mHighlightedLabel;

	// Token: 0x040002A4 RID: 676
	[SerializeField]
	[HideInInspector]
	protected List<BKKHLBCLPJM> mLabelList = new List<BKKHLBCLPJM>();

	// Token: 0x040002A5 RID: 677
	[HideInInspector]
	[SerializeField]
	protected float mBgBorder;

	// Token: 0x040002A6 RID: 678
	[Tooltip("Whether the selection will be persistent even after the popup list is closed. By default the selection is cleared when the popup is closed so that the same selection can be chosen again the next time the popup list is opened. If enabled, the selection will persist, but selecting the same choice in succession will not result in the onChange notification being triggered more than once.")]
	public bool PQMOOBMNJIB;

	// Token: 0x040002A7 RID: 679
	[NonSerialized]
	protected GameObject JQIIMMFHGCB;

	// Token: 0x040002A8 RID: 680
	[NonSerialized]
	protected int DEJNBEEBQBD;

	// Token: 0x040002A9 RID: 681
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	// Token: 0x040002AA RID: 682
	[HideInInspector]
	[SerializeField]
	private string functionName = "OnSelectionChange";

	// Token: 0x040002AB RID: 683
	[SerializeField]
	[HideInInspector]
	private float textScale;

	// Token: 0x040002AC RID: 684
	[HideInInspector]
	[SerializeField]
	private KGKLCNDOLMP font;

	// Token: 0x040002AD RID: 685
	[SerializeField]
	[HideInInspector]
	private BKKHLBCLPJM textLabel;

	// Token: 0x040002AE RID: 686
	[NonSerialized]
	public Vector3 NBPPPPNQPII;

	// Token: 0x040002AF RID: 687
	private QCPKMJONIGF.POJLOPHOQBO JDMQFGQQHCP;

	// Token: 0x040002B0 RID: 688
	[NonSerialized]
	protected bool DMFMCDCBNNJ;

	// Token: 0x040002B1 RID: 689
	protected bool IMKFMCELEOC;

	// Token: 0x040002B2 RID: 690
	[NonSerialized]
	protected bool PNBOOLEOKCI;

	// Token: 0x040002B3 RID: 691
	protected bool PPMELEHGOPQ;

	// Token: 0x040002B4 RID: 692
	public GameObject PBHPQFLMQDB;

	// Token: 0x02000070 RID: 112
	public enum IPLQGICGPCB
	{
		// Token: 0x040002B6 RID: 694
		Auto,
		// Token: 0x040002B7 RID: 695
		Above,
		// Token: 0x040002B8 RID: 696
		Below
	}

	// Token: 0x02000071 RID: 113
	public enum GDPEKPCMODK
	{
		// Token: 0x040002BA RID: 698
		ClickOrTap,
		// Token: 0x040002BB RID: 699
		RightClick,
		// Token: 0x040002BC RID: 700
		DoubleClick,
		// Token: 0x040002BD RID: 701
		Manual
	}

	// Token: 0x02000072 RID: 114
	// (Invoke) Token: 0x06000F73 RID: 3955
	public delegate void POJLOPHOQBO(string QJFQOMOIOOI);
}
