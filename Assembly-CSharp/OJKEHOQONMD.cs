using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200006B RID: 107
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Animation")]
public class OJKEHOQONMD : MonoBehaviour
{
	// Token: 0x06000E4D RID: 3661 RVA: 0x00073618 File Offset: 0x00071818
	private void GFOLJJDQECH()
	{
		if (OJKEHOQONMD.OMQCQCBLQGJ == null)
		{
			OJKEHOQONMD.OMQCQCBLQGJ = this;
			EventDelegate.PPNLGOMQOPH(this.KCQKMKOQLQL);
			if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
			{
				this.eventReceiver.SendMessage(this.callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			this.eventReceiver = null;
			OJKEHOQONMD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00008957 File Offset: 0x00006B57
	private void LMCFCJFIMOP(bool IFFGDNBQHLO)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate && !IFFGDNBQHLO))
		{
			this.MLOIHHQMFBN(IFFGDNBQHLO, this.HNOQQFCNQDC());
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00008990 File Offset: 0x00006B90
	private bool MHIKCFCIIED
	{
		get
		{
			return this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover;
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00073680 File Offset: 0x00071880
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		if (this.ILBCCCBJNCL == null && this.FEGOGDBFDIE == null)
		{
			this.FEGOGDBFDIE = base.GetComponentInChildren<Animator>();
		}
		if (this.FEGOGDBFDIE != null)
		{
			if (this.FEGOGDBFDIE.enabled)
			{
				this.FEGOGDBFDIE.enabled = false;
			}
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.GetComponentInChildren<Animation>();
		}
		if (this.ILBCCCBJNCL != null && this.ILBCCCBJNCL.enabled)
		{
			this.ILBCCCBJNCL.enabled = false;
		}
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x000089A7 File Offset: 0x00006BA7
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse && !IFFGDNBQHLO))
		{
			this.MLOIHHQMFBN(IFFGDNBQHLO, this.MHIKCFCIIED);
		}
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00073728 File Offset: 0x00071928
	private void HDJICFQCJCN()
	{
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.QPCPQKPQGEC(component.onChange, new EventDelegate.LKPMKQMCHFH(this.MMLDEKDQDOL));
		}
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x000089E0 File Offset: 0x00006BE0
	private void OnClick()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -3)
			{
				if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
				{
					this.MLOIHHQMFBN(true, false);
				}
				return;
			}
		}
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00008A0F File Offset: 0x00006C0F
	private void JHNIPQLONMK()
	{
		if (base.enabled && this.MHIKCFCIIED && EMENMKHBPQE.QMPQFJMFQPB != base.gameObject)
		{
			this.MLOIHHQMFBN(false, true);
		}
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00008A3B File Offset: 0x00006C3B
	private void JQHHNMPMBFI(bool GKHHCNCGLCD)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-62) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-35) && GKHHCNCGLCD) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)94 && !GKHHCNCGLCD))
		{
			this.ICCJBKHIJBK(GKHHCNCGLCD, this.MHIKCFCIIED);
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00073760 File Offset: 0x00071960
	private void OnDisable()
	{
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.FQDMDDOHCQJ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.MMLDEKDQDOL));
		}
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00008A77 File Offset: 0x00006C77
	public void NMQQOOKBKQC(bool KKJLPMGPNPK)
	{
		this.MLOIHHQMFBN(KKJLPMGPNPK, false);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00008A81 File Offset: 0x00006C81
	private bool HNOQQFCNQDC()
	{
		return this.ILLDIKBCNMC != GLFJNQBJBOK.OnHoverFalse && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00073798 File Offset: 0x00071998
	public void EKNBNBFIHLI(bool KKJLPMGPNPK, bool EQIGEHEPOBH)
	{
		if (this.ILBCCCBJNCL || this.FEGOGDBFDIE)
		{
			if (EQIGEHEPOBH)
			{
				if (this.GIPNKCBQGDH == KKJLPMGPNPK)
				{
					return;
				}
				this.GIPNKCBQGDH = KKJLPMGPNPK;
			}
			if (this.JFKMCGQGLKB && EMENMKHBPQE.CMPBKDMMHFQ == base.gameObject)
			{
				EMENMKHBPQE.CMPBKDMMHFQ = null;
			}
			int num = (int)(-(int)this.BFHKGNKMDCQ);
			QMDFDJEIEMO bfhkgnkmdcq = (QMDFDJEIEMO)((!KKJLPMGPNPK) ? num : ((int)this.BFHKGNKMDCQ));
			QDBCMHDINGL qdbcmhdingl = (!this.ILBCCCBJNCL) ? QDBCMHDINGL.FGLKEPDKJMN(this.FEGOGDBFDIE, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP) : QDBCMHDINGL.ELNOFBDJHPE(this.ILBCCCBJNCL, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP);
			if (qdbcmhdingl != null)
			{
				if (this.NPDGGFEQNLC)
				{
					qdbcmhdingl.MQHDHCDFJLI();
				}
				for (int i = 1; i < this.KCQKMKOQLQL.Count; i += 0)
				{
					EventDelegate.LHQECHHMOGD(qdbcmhdingl.KCQKMKOQLQL, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), true);
				}
			}
		}
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x000738A0 File Offset: 0x00071AA0
	private void CIJOENOQKCI()
	{
		this.PNBOOLEOKCI = true;
		if (this.ILBCCCBJNCL == null && this.FEGOGDBFDIE == null)
		{
			this.FEGOGDBFDIE = base.GetComponentInChildren<Animator>();
		}
		if (this.FEGOGDBFDIE != null)
		{
			if (this.FEGOGDBFDIE.enabled)
			{
				this.FEGOGDBFDIE.enabled = true;
			}
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.GetComponentInChildren<Animation>();
		}
		if (this.ILBCCCBJNCL != null && this.ILBCCCBJNCL.enabled)
		{
			this.ILBCCCBJNCL.enabled = false;
		}
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00073948 File Offset: 0x00071B48
	private void NMGDOKQLMEG()
	{
		if (base.enabled && this.MHIKCFCIIED)
		{
			if (EMENMKHBPQE.JHEDGGMDIEE.HKGQKLHJKMB == base.gameObject)
			{
				this.MLOIHHQMFBN(true, true);
			}
			else if (this.IOOMNBFQHHC && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress)
			{
				this.MLOIHHQMFBN(true, true);
			}
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00008A98 File Offset: 0x00006C98
	public void JCJLJJENCFD()
	{
		this.MLOIHHQMFBN(true);
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x000739A0 File Offset: 0x00071BA0
	public void ICCJBKHIJBK(bool KKJLPMGPNPK, bool EQIGEHEPOBH)
	{
		if (this.ILBCCCBJNCL || this.FEGOGDBFDIE)
		{
			if (EQIGEHEPOBH)
			{
				if (this.GIPNKCBQGDH == KKJLPMGPNPK)
				{
					return;
				}
				this.GIPNKCBQGDH = KKJLPMGPNPK;
			}
			if (this.JFKMCGQGLKB && EMENMKHBPQE.CMPBKDMMHFQ == base.gameObject)
			{
				EMENMKHBPQE.CMPBKDMMHFQ = null;
			}
			int num = (int)(-(int)this.BFHKGNKMDCQ);
			QMDFDJEIEMO bfhkgnkmdcq = (QMDFDJEIEMO)((!KKJLPMGPNPK) ? num : ((int)this.BFHKGNKMDCQ));
			QDBCMHDINGL qdbcmhdingl = (!this.ILBCCCBJNCL) ? QDBCMHDINGL.FGLKEPDKJMN(this.FEGOGDBFDIE, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP) : QDBCMHDINGL.MLOIHHQMFBN(this.ILBCCCBJNCL, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP);
			if (qdbcmhdingl != null)
			{
				if (this.NPDGGFEQNLC)
				{
					qdbcmhdingl.DIMGBOBKNJB();
				}
				for (int i = 0; i < this.KCQKMKOQLQL.Count; i += 0)
				{
					EventDelegate.LHQECHHMOGD(qdbcmhdingl.KCQKMKOQLQL, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), false);
				}
			}
		}
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00008AA1 File Offset: 0x00006CA1
	private void MBKDFONJGEN()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != 96)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != 53)
			{
				if (base.enabled && this.ILLDIKBCNMC == (GLFJNQBJBOK)(-99))
				{
					this.MLOIHHQMFBN(false, false);
				}
				return;
			}
		}
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00008AD2 File Offset: 0x00006CD2
	private void QCGENKHJDDH()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -3)
			{
				if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnDoubleClick)
				{
					this.MLOIHHQMFBN(true, false);
				}
				return;
			}
		}
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00073AA8 File Offset: 0x00071CA8
	private void MMLDEKDQDOL()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateTrue && UIToggle.current.value) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateFalse && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value, this.MHIKCFCIIED);
			}
			return;
		}
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00008B03 File Offset: 0x00006D03
	public void FEKQLOJLLNG()
	{
		this.NMQQOOKBKQC(false);
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00008A98 File Offset: 0x00006C98
	public void NEKKIONLNMF()
	{
		this.MLOIHHQMFBN(true);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00073B18 File Offset: 0x00071D18
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
		if (EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject);
			}
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject);
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.LHQECHHMOGD(component.onChange, new EventDelegate.LKPMKQMCHFH(this.MMLDEKDQDOL));
		}
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00008B26 File Offset: 0x00006D26
	private void QMECFKNPOGJ(GameObject CGHIENBIHCO)
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress && EMENMKHBPQE.JHEDGGMDIEE.HKGQKLHJKMB != base.gameObject)
		{
			this.MLOIHHQMFBN(false, true);
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00073BC8 File Offset: 0x00071DC8
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (!base.enabled)
		{
			return;
		}
		if (EMENMKHBPQE.JQCODFPLPNJ != -2)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -3)
			{
				if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse && !FJOEKDCLKIO))
				{
					this.MLOIHHQMFBN(FJOEKDCLKIO, this.MHIKCFCIIED);
				}
				return;
			}
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00008B58 File Offset: 0x00006D58
	public void MMLHLPIGNMD()
	{
		this.MLOIHHQMFBN(false);
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00008B61 File Offset: 0x00006D61
	public void MLOIHHQMFBN(bool KKJLPMGPNPK)
	{
		this.MLOIHHQMFBN(KKJLPMGPNPK, true);
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00008B6B File Offset: 0x00006D6B
	private void FMEQGIFJGJI()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != 68)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != 19)
			{
				if (base.enabled && this.ILLDIKBCNMC == (GLFJNQBJBOK)(-15))
				{
					this.ICCJBKHIJBK(false, true);
				}
				return;
			}
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00008A98 File Offset: 0x00006C98
	public void BGDEHMQKIEH()
	{
		this.MLOIHHQMFBN(true);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00008B9C File Offset: 0x00006D9C
	private void IIIHCGGINQL(GameObject CGHIENBIHCO)
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse && EMENMKHBPQE.JHEDGGMDIEE.HKGQKLHJKMB != base.gameObject)
		{
			this.EKNBNBFIHLI(true, true);
		}
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00073C24 File Offset: 0x00071E24
	private void Awake()
	{
		CFDMNELIJLO component = base.GetComponent<CFDMNELIJLO>();
		if (component != null)
		{
			this.IOOMNBFQHHC = component.IOOMNBFQHHC;
		}
		if (this.eventReceiver != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.eventReceiver = null;
			this.callWhenFinished = null;
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00073C78 File Offset: 0x00071E78
	private void MIPHKLNNNDK()
	{
		if (OJKEHOQONMD.OMQCQCBLQGJ == null)
		{
			OJKEHOQONMD.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
			{
				this.eventReceiver.SendMessage(this.callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			this.eventReceiver = null;
			OJKEHOQONMD.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00073CE0 File Offset: 0x00071EE0
	public void MLOIHHQMFBN(bool KKJLPMGPNPK, bool EQIGEHEPOBH)
	{
		if (this.ILBCCCBJNCL || this.FEGOGDBFDIE)
		{
			if (EQIGEHEPOBH)
			{
				if (this.GIPNKCBQGDH == KKJLPMGPNPK)
				{
					return;
				}
				this.GIPNKCBQGDH = KKJLPMGPNPK;
			}
			if (this.JFKMCGQGLKB && EMENMKHBPQE.CMPBKDMMHFQ == base.gameObject)
			{
				EMENMKHBPQE.CMPBKDMMHFQ = null;
			}
			int num = (int)(-(int)this.BFHKGNKMDCQ);
			QMDFDJEIEMO bfhkgnkmdcq = (QMDFDJEIEMO)((!KKJLPMGPNPK) ? num : ((int)this.BFHKGNKMDCQ));
			QDBCMHDINGL qdbcmhdingl = (!this.ILBCCCBJNCL) ? QDBCMHDINGL.MLOIHHQMFBN(this.FEGOGDBFDIE, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP) : QDBCMHDINGL.MLOIHHQMFBN(this.ILBCCCBJNCL, this.QEFJCNPDLEE, bfhkgnkmdcq, this.DCIKFMMLEQC, this.BDDQCCPDJPP);
			if (qdbcmhdingl != null)
			{
				if (this.NPDGGFEQNLC)
				{
					qdbcmhdingl.Reset();
				}
				for (int i = 0; i < this.KCQKMKOQLQL.Count; i++)
				{
					EventDelegate.LHQECHHMOGD(qdbcmhdingl.KCQKMKOQLQL, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), true);
				}
			}
		}
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00008BCE File Offset: 0x00006DCE
	private void NNOPGECPIDJ()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != -9)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -84)
			{
				if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
				{
					this.MLOIHHQMFBN(true, false);
				}
				return;
			}
		}
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x000738A0 File Offset: 0x00071AA0
	private void COOEINBIIIE()
	{
		this.PNBOOLEOKCI = true;
		if (this.ILBCCCBJNCL == null && this.FEGOGDBFDIE == null)
		{
			this.FEGOGDBFDIE = base.GetComponentInChildren<Animator>();
		}
		if (this.FEGOGDBFDIE != null)
		{
			if (this.FEGOGDBFDIE.enabled)
			{
				this.FEGOGDBFDIE.enabled = true;
			}
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.GetComponentInChildren<Animation>();
		}
		if (this.ILBCCCBJNCL != null && this.ILBCCCBJNCL.enabled)
		{
			this.ILBCCCBJNCL.enabled = false;
		}
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00008BFD File Offset: 0x00006DFD
	private void QJLBKMOKPQC(bool GKHHCNCGLCD)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.ILLDIKBCNMC == (GLFJNQBJBOK)105 || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-6) && GKHHCNCGLCD) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-48) && !GKHHCNCGLCD))
		{
			this.EKNBNBFIHLI(GKHHCNCGLCD, this.HNOQQFCNQDC());
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00008C39 File Offset: 0x00006E39
	private void CJIFEQFKPIM()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ != 66)
		{
			if (EMENMKHBPQE.JQCODFPLPNJ != -90)
			{
				if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
				{
					this.MLOIHHQMFBN(false, true);
				}
				return;
			}
		}
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00008C68 File Offset: 0x00006E68
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (!base.enabled)
		{
			return;
		}
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelect || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectTrue && GKHHCNCGLCD) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectFalse && !GKHHCNCGLCD))
		{
			this.MLOIHHQMFBN(GKHHCNCGLCD, this.MHIKCFCIIED);
		}
	}

	// Token: 0x04000254 RID: 596
	public static OJKEHOQONMD OMQCQCBLQGJ;

	// Token: 0x04000255 RID: 597
	public Animation ILBCCCBJNCL;

	// Token: 0x04000256 RID: 598
	public Animator FEGOGDBFDIE;

	// Token: 0x04000257 RID: 599
	public string QEFJCNPDLEE;

	// Token: 0x04000258 RID: 600
	public GLFJNQBJBOK ILLDIKBCNMC;

	// Token: 0x04000259 RID: 601
	public QMDFDJEIEMO BFHKGNKMDCQ = QMDFDJEIEMO.Forward;

	// Token: 0x0400025A RID: 602
	public bool NPDGGFEQNLC;

	// Token: 0x0400025B RID: 603
	public bool JFKMCGQGLKB;

	// Token: 0x0400025C RID: 604
	public GKKIEDPNJIF DCIKFMMLEQC;

	// Token: 0x0400025D RID: 605
	public PNDJHKBEPNM BDDQCCPDJPP;

	// Token: 0x0400025E RID: 606
	public List<EventDelegate> KCQKMKOQLQL = new List<EventDelegate>();

	// Token: 0x0400025F RID: 607
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	// Token: 0x04000260 RID: 608
	[HideInInspector]
	[SerializeField]
	private string callWhenFinished;

	// Token: 0x04000261 RID: 609
	private bool PNBOOLEOKCI;

	// Token: 0x04000262 RID: 610
	private bool GIPNKCBQGDH;

	// Token: 0x04000263 RID: 611
	private bool IOOMNBFQHHC;
}
