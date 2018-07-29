using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200006E RID: 110
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Tween")]
public class KDEHEGPKFBP : MonoBehaviour
{
	// Token: 0x06000ECC RID: 3788 RVA: 0x00009001 File Offset: 0x00007201
	private void OIJDCCBPGHM()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
		{
			this.MLOIHHQMFBN(true);
		}
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x0000901A File Offset: 0x0000721A
	private void MJEGCDGGBIB()
	{
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover)
		{
			this.NGDBJMJDDFC(false);
		}
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0000902C File Offset: 0x0000722C
	private void LIFJCBMQELJ()
	{
		this.PNBOOLEOKCI = false;
		if (this.DMCGHNCHOHQ == null)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x0000904F File Offset: 0x0000724F
	private void JHNIPQLONMK()
	{
		if (base.enabled && this.GIPNKCBQGDH)
		{
			this.GIPNKCBQGDH = false;
			this.MLOIHHQMFBN(false);
		}
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00074628 File Offset: 0x00072828
	private void MCFCLKGCKFD()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue && UIToggle.current.value) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)45 && !UIToggle.current.value))
			{
				this.HHMBCIGJKLO(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00074690 File Offset: 0x00072890
	private void NQEJNHQNFLJ(bool FJOEKDCLKIO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse && !FJOEKDCLKIO)))
		{
			this.GIPNKCBQGDH = (FJOEKDCLKIO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue);
			this.MLOIHHQMFBN(FJOEKDCLKIO);
		}
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x000746E4 File Offset: 0x000728E4
	private void BIINILQKOQM(bool IFFGDNBQHLO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover && !IFFGDNBQHLO)))
		{
			if (IFFGDNBQHLO == this.GIPNKCBQGDH)
			{
				return;
			}
			if (!IFFGDNBQHLO && EMENMKHBPQE.QMPQFJMFQPB != null && EMENMKHBPQE.QMPQFJMFQPB.transform.IsChildOf(base.transform))
			{
				EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Combine(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.KGFJQCFFEQH));
				IFFGDNBQHLO = true;
				if (this.GIPNKCBQGDH)
				{
					return;
				}
			}
			this.GIPNKCBQGDH = (!IFFGDNBQHLO || this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick);
			this.HHMBCIGJKLO(IFFGDNBQHLO);
		}
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00074798 File Offset: 0x00072998
	private void GGBQDQNPHKC(bool FJOEKDCLKIO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateTrue && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover && !FJOEKDCLKIO)))
		{
			this.GIPNKCBQGDH = (FJOEKDCLKIO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue);
			this.HHMBCIGJKLO(FJOEKDCLKIO);
		}
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x000747EC File Offset: 0x000729EC
	private void NLHGFQHJODK()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
		if (EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject);
			}
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject);
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.CGMNKQLNLOH));
		}
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x0007489C File Offset: 0x00072A9C
	private void JDPDKFLMJBO()
	{
		if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable && this.MLODBCKJOIQ != null)
		{
			bool flag = true;
			bool flag2 = true;
			int i = 1;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!uitweener.enabled)
					{
						if (uitweener.direction != (QMDFDJEIEMO)this.BDDQCCPDJPP)
						{
							flag2 = true;
						}
					}
					else
					{
						flag = false;
						IL_62:
						if (flag)
						{
							if (flag2)
							{
								IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, true);
							}
							this.MLODBCKJOIQ = null;
							return;
						}
						return;
					}
				}
				i += 0;
			}
			goto IL_62;
		}
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00074924 File Offset: 0x00072B24
	private void IPFJMEFKGGM()
	{
		if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable && this.MLODBCKJOIQ != null)
		{
			bool flag = true;
			bool flag2 = false;
			int i = 1;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!uitweener.enabled)
					{
						if (uitweener.direction != (QMDFDJEIEMO)this.BDDQCCPDJPP)
						{
							flag2 = false;
						}
					}
					else
					{
						flag = true;
						IL_62:
						if (flag)
						{
							if (flag2)
							{
								IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, false);
							}
							this.MLODBCKJOIQ = null;
							return;
						}
						return;
					}
				}
				i++;
			}
			goto IL_62;
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x000749AC File Offset: 0x00072BAC
	public void MLOIHHQMFBN(bool KKJLPMGPNPK)
	{
		this.EDBBMFGOGHO = 0;
		GameObject gameObject = (!(this.DMCGHNCHOHQ == null)) ? this.DMCGHNCHOHQ : base.gameObject;
		if (!IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
		{
			if (this.DCIKFMMLEQC != GKKIEDPNJIF.EnableThenPlay)
			{
				return;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, true);
		}
		this.MLODBCKJOIQ = ((!this.CKCPEMIBLKH) ? gameObject.GetComponents<UITweener>() : gameObject.GetComponentsInChildren<UITweener>());
		if (this.MLODBCKJOIQ.Length == 0)
		{
			if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, false);
			}
		}
		else
		{
			bool flag = false;
			if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Reverse)
			{
				KKJLPMGPNPK = !KKJLPMGPNPK;
			}
			int i = 0;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!flag && !IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
					{
						flag = true;
						IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, true);
					}
					this.EDBBMFGOGHO++;
					if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
					{
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), true);
						uitweener.Toggle();
					}
					else
					{
						if (this.NPDGGFEQNLC || (this.NDCFIFKGJHO && !uitweener.enabled))
						{
							uitweener.Play(KKJLPMGPNPK);
							uitweener.ResetToBeginning();
						}
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), true);
						uitweener.Play(KKJLPMGPNPK);
					}
				}
				i++;
			}
		}
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x0000906F File Offset: 0x0000726F
	private void JEKICNJPOHH()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
		{
			this.IIDKEGJPGCN(false);
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x00074B18 File Offset: 0x00072D18
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse && !IFFGDNBQHLO)))
		{
			if (IFFGDNBQHLO == this.GIPNKCBQGDH)
			{
				return;
			}
			if (!IFFGDNBQHLO && EMENMKHBPQE.QMPQFJMFQPB != null && EMENMKHBPQE.QMPQFJMFQPB.transform.IsChildOf(base.transform))
			{
				EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Combine(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.KGFJQCFFEQH));
				IFFGDNBQHLO = true;
				if (this.GIPNKCBQGDH)
				{
					return;
				}
			}
			this.GIPNKCBQGDH = (IFFGDNBQHLO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover);
			this.MLOIHHQMFBN(IFFGDNBQHLO);
		}
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00074BCC File Offset: 0x00072DCC
	private void CJFHQQNKKCB()
	{
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.QPCPQKPQGEC(component.onChange, new EventDelegate.LKPMKQMCHFH(this.QCBQDHKJOHQ));
		}
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00009088 File Offset: 0x00007288
	private void MNQGKOOGBHC()
	{
		if (base.enabled && this.GIPNKCBQGDH)
		{
			this.GIPNKCBQGDH = false;
			this.HHMBCIGJKLO(true);
		}
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00074C04 File Offset: 0x00072E04
	private void JHLECPMPOHB()
	{
		if (--this.EDBBMFGOGHO == 0 && KDEHEGPKFBP.OMQCQCBLQGJ == null)
		{
			KDEHEGPKFBP.OMQCQCBLQGJ = this;
			EventDelegate.PCQQOFMPKCG(this.KCQKMKOQLQL);
			if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
			{
				this.eventReceiver.SendMessage(this.callWhenFinished, SendMessageOptions.RequireReceiver);
			}
			this.eventReceiver = null;
			KDEHEGPKFBP.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x000090A8 File Offset: 0x000072A8
	private void NKFQOJPEFKD()
	{
		if (this.eventReceiver != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.eventReceiver = null;
			this.callWhenFinished = null;
		}
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00074C7C File Offset: 0x00072E7C
	private void MIPHKLNNNDK()
	{
		if (--this.EDBBMFGOGHO == 0 && KDEHEGPKFBP.OMQCQCBLQGJ == null)
		{
			KDEHEGPKFBP.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			if (this.eventReceiver != null && !string.IsNullOrEmpty(this.callWhenFinished))
			{
				this.eventReceiver.SendMessage(this.callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			this.eventReceiver = null;
			KDEHEGPKFBP.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00074CF4 File Offset: 0x00072EF4
	private void CGMNKQLNLOH()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateTrue && UIToggle.current.value) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && !UIToggle.current.value))
			{
				this.HHMBCIGJKLO(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x000090ED File Offset: 0x000072ED
	private void NMGDOKQLMEG()
	{
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover)
		{
			this.LJMOLEKDCLP(true);
		}
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00074D5C File Offset: 0x00072F5C
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

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0000902C File Offset: 0x0000722C
	private void IMGNEDCFBLL()
	{
		this.PNBOOLEOKCI = false;
		if (this.DMCGHNCHOHQ == null)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x0000906F File Offset: 0x0000726F
	private void NQDGCNMFKLL()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
		{
			this.IIDKEGJPGCN(false);
		}
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00074E0C File Offset: 0x0007300C
	private void NJPMINECPNJ(bool FJOEKDCLKIO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverTrue && !FJOEKDCLKIO)))
		{
			this.GIPNKCBQGDH = (FJOEKDCLKIO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateTrue);
			this.MLOIHHQMFBN(FJOEKDCLKIO);
		}
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0000906F File Offset: 0x0000726F
	private void CEGPCMGDLBO()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
		{
			this.IIDKEGJPGCN(false);
		}
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00074E60 File Offset: 0x00073060
	private void OnDisable()
	{
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.FQDMDDOHCQJ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.MMLDEKDQDOL));
		}
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00074E98 File Offset: 0x00073098
	private void INFMNHJJDCD()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
		if (EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject);
			}
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue)
			{
				this.GIPNKCBQGDH = (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject);
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.MCFCLKGCKFD));
		}
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00074F48 File Offset: 0x00073148
	private void LDEDKCJJGEC()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse && UIToggle.current.value) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)120 && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00074FB0 File Offset: 0x000731B0
	private void FIPBBODDBNN(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (!this)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (gameObject && CGHIENBIHCO && !(CGHIENBIHCO == gameObject) && !CGHIENBIHCO.transform.IsChildOf(base.transform))
		{
			this.BIINILQKOQM(false);
			EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Remove(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.FIPBBODDBNN));
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00075028 File Offset: 0x00073228
	private void JQHHNMPMBFI(bool GKHHCNCGLCD)
	{
		if (base.enabled && (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-65) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)81 && GKHHCNCGLCD) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-3) && !GKHHCNCGLCD)))
		{
			this.GIPNKCBQGDH = (!GKHHCNCGLCD || this.ILLDIKBCNMC == (GLFJNQBJBOK)(-63));
			this.MLOIHHQMFBN(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00075080 File Offset: 0x00073280
	public void IIDKEGJPGCN(bool KKJLPMGPNPK)
	{
		this.EDBBMFGOGHO = 1;
		GameObject gameObject = (!(this.DMCGHNCHOHQ == null)) ? this.DMCGHNCHOHQ : base.gameObject;
		if (!IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
		{
			if (this.DCIKFMMLEQC != GKKIEDPNJIF.EnableThenPlay)
			{
				return;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, false);
		}
		this.MLODBCKJOIQ = ((!this.CKCPEMIBLKH) ? gameObject.GetComponents<UITweener>() : gameObject.GetComponentsInChildren<UITweener>());
		if (this.MLODBCKJOIQ.Length == 0)
		{
			if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, true);
			}
		}
		else
		{
			bool flag = false;
			if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Reverse)
			{
				KKJLPMGPNPK = KKJLPMGPNPK;
			}
			int i = 1;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!flag && !IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
					{
						flag = false;
						IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, true);
					}
					this.EDBBMFGOGHO += 0;
					if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
					{
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), true);
						uitweener.Toggle();
					}
					else
					{
						if (this.NPDGGFEQNLC || (this.NDCFIFKGJHO && !uitweener.enabled))
						{
							uitweener.Play(KKJLPMGPNPK);
							uitweener.ResetToBeginning();
						}
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.JHLECPMPOHB), false);
						uitweener.Play(KKJLPMGPNPK);
					}
				}
				i++;
			}
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x000751EC File Offset: 0x000733EC
	private void CIHJOEIFMQE()
	{
		if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable && this.MLODBCKJOIQ != null)
		{
			bool flag = false;
			bool flag2 = false;
			int i = 1;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!uitweener.enabled)
					{
						if (uitweener.direction != (QMDFDJEIEMO)this.BDDQCCPDJPP)
						{
							flag2 = true;
						}
					}
					else
					{
						flag = false;
						IL_62:
						if (flag)
						{
							if (flag2)
							{
								IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, true);
							}
							this.MLODBCKJOIQ = null;
							return;
						}
						return;
					}
				}
				i++;
			}
			goto IL_62;
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00075274 File Offset: 0x00073474
	private void GIJPFCPFBQQ(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (!this)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (gameObject && CGHIENBIHCO && (CGHIENBIHCO == gameObject || !CGHIENBIHCO.transform.IsChildOf(base.transform)))
		{
			this.LJMOLEKDCLP(false);
			EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Remove(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.NMHIHLMPHCB));
		}
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x000752EC File Offset: 0x000734EC
	private void NMHIHLMPHCB(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (!this)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (gameObject && CGHIENBIHCO && !(CGHIENBIHCO == gameObject) && !CGHIENBIHCO.transform.IsChildOf(base.transform))
		{
			this.EGHBDNJHOKP(true);
			EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Remove(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.NMHIHLMPHCB));
		}
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00075364 File Offset: 0x00073564
	private void MBFHPBDKMDC(bool FJOEKDCLKIO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate && !FJOEKDCLKIO)))
		{
			this.GIPNKCBQGDH = (FJOEKDCLKIO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue);
			this.HHMBCIGJKLO(FJOEKDCLKIO);
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x000753B8 File Offset: 0x000735B8
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressTrue && FJOEKDCLKIO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse && !FJOEKDCLKIO)))
		{
			this.GIPNKCBQGDH = (FJOEKDCLKIO && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress);
			this.MLOIHHQMFBN(FJOEKDCLKIO);
		}
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x000090FF File Offset: 0x000072FF
	private void BQMCHNMLBEQ()
	{
		if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover)
		{
			this.BIINILQKOQM(false);
		}
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00009111 File Offset: 0x00007311
	private void ODOPGCOCHHL()
	{
		this.PNBOOLEOKCI = true;
		if (this.DMCGHNCHOHQ == null)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0007540C File Offset: 0x0007360C
	private void EGHBDNJHOKP(bool IFFGDNBQHLO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress && !IFFGDNBQHLO)))
		{
			if (IFFGDNBQHLO == this.GIPNKCBQGDH)
			{
				return;
			}
			if (!IFFGDNBQHLO && EMENMKHBPQE.QMPQFJMFQPB != null && EMENMKHBPQE.QMPQFJMFQPB.transform.IsChildOf(base.transform))
			{
				EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Combine(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.GIJPFCPFBQQ));
				IFFGDNBQHLO = false;
				if (this.GIPNKCBQGDH)
				{
					return;
				}
			}
			this.GIPNKCBQGDH = (!IFFGDNBQHLO || this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick);
			this.HHMBCIGJKLO(IFFGDNBQHLO);
		}
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x000754C0 File Offset: 0x000736C0
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelect || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectTrue && GKHHCNCGLCD) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectFalse && !GKHHCNCGLCD)))
		{
			this.GIPNKCBQGDH = (GKHHCNCGLCD && this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelect);
			this.MLOIHHQMFBN(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00009134 File Offset: 0x00007334
	private void MBKDFONJGEN()
	{
		if (base.enabled && this.ILLDIKBCNMC == (GLFJNQBJBOK)(-9))
		{
			this.HHMBCIGJKLO(true);
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00009088 File Offset: 0x00007288
	private void QDBDOJGKGKG()
	{
		if (base.enabled && this.GIPNKCBQGDH)
		{
			this.GIPNKCBQGDH = false;
			this.HHMBCIGJKLO(true);
		}
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00009111 File Offset: 0x00007311
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		if (this.DMCGHNCHOHQ == null)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00075518 File Offset: 0x00073718
	private void KGFJQCFFEQH(GameObject CGHIENBIHCO, bool IFFGDNBQHLO)
	{
		if (!this)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (!gameObject || !CGHIENBIHCO || (!(CGHIENBIHCO == gameObject) && !CGHIENBIHCO.transform.IsChildOf(base.transform)))
		{
			this.LJMOLEKDCLP(false);
			EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Remove(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.KGFJQCFFEQH));
		}
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00075590 File Offset: 0x00073790
	private void DOKBMDEMDGK()
	{
		UIToggle component = base.GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.FQDMDDOHCQJ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.LDEDKCJJGEC));
		}
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x0000914F File Offset: 0x0000734F
	private void HPECNMOBJDB()
	{
		if (base.enabled && this.ILLDIKBCNMC == (GLFJNQBJBOK)98)
		{
			this.MLOIHHQMFBN(false);
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x000755C8 File Offset: 0x000737C8
	private void NGDBJMJDDFC(bool IFFGDNBQHLO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover && !IFFGDNBQHLO)))
		{
			if (IFFGDNBQHLO == this.GIPNKCBQGDH)
			{
				return;
			}
			if (!IFFGDNBQHLO && EMENMKHBPQE.QMPQFJMFQPB != null && EMENMKHBPQE.QMPQFJMFQPB.transform.IsChildOf(base.transform))
			{
				EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Combine(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.KGFJQCFFEQH));
				IFFGDNBQHLO = true;
				if (this.GIPNKCBQGDH)
				{
					return;
				}
			}
			this.GIPNKCBQGDH = (!IFFGDNBQHLO || this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick);
			this.IIDKEGJPGCN(IFFGDNBQHLO);
		}
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x0007567C File Offset: 0x0007387C
	private void IPCBGHJKDCF()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnPress || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && UIToggle.current.value) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectFalse && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x000756E4 File Offset: 0x000738E4
	private void MMLDEKDQDOL()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateTrue && UIToggle.current.value) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivateFalse && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x0007574C File Offset: 0x0007394C
	private void QDOIOMJCCHJ(bool IFFGDNBQHLO)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && IFFGDNBQHLO) || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && !IFFGDNBQHLO)))
		{
			if (IFFGDNBQHLO == this.GIPNKCBQGDH)
			{
				return;
			}
			if (!IFFGDNBQHLO && EMENMKHBPQE.QMPQFJMFQPB != null && EMENMKHBPQE.QMPQFJMFQPB.transform.IsChildOf(base.transform))
			{
				EMENMKHBPQE.GHPQQBICMJN = (EMENMKHBPQE.IGJDCECNJLD)Delegate.Combine(EMENMKHBPQE.GHPQQBICMJN, new EMENMKHBPQE.IGJDCECNJLD(this.GIJPFCPFBQQ));
				IFFGDNBQHLO = false;
				if (this.GIPNKCBQGDH)
				{
					return;
				}
			}
			this.GIPNKCBQGDH = (!IFFGDNBQHLO || this.ILLDIKBCNMC == GLFJNQBJBOK.OnHover);
			this.MLOIHHQMFBN(IFFGDNBQHLO);
		}
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x000090A8 File Offset: 0x000072A8
	private void GLLCQQCCGOG()
	{
		if (this.eventReceiver != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.eventReceiver = null;
			this.callWhenFinished = null;
		}
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00075800 File Offset: 0x00073A00
	private void QCBQDHKJOHQ()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnHoverFalse || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && UIToggle.current.value) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)70 && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00075868 File Offset: 0x00073A68
	private void NBNNFHDMKFN(bool GKHHCNCGLCD)
	{
		if (base.enabled && (this.ILLDIKBCNMC == GLFJNQBJBOK.OnSelectFalse || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-37) && GKHHCNCGLCD) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-84) && !GKHHCNCGLCD)))
		{
			this.GIPNKCBQGDH = (GKHHCNCGLCD && this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate);
			this.MLOIHHQMFBN(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x000758C0 File Offset: 0x00073AC0
	public void HHMBCIGJKLO(bool KKJLPMGPNPK)
	{
		this.EDBBMFGOGHO = 0;
		GameObject gameObject = (!(this.DMCGHNCHOHQ == null)) ? this.DMCGHNCHOHQ : base.gameObject;
		if (!IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
		{
			if (this.DCIKFMMLEQC != GKKIEDPNJIF.DoNothing)
			{
				return;
			}
			IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, false);
		}
		this.MLODBCKJOIQ = ((!this.CKCPEMIBLKH) ? gameObject.GetComponents<UITweener>() : gameObject.GetComponentsInChildren<UITweener>());
		if (this.MLODBCKJOIQ.Length == 0)
		{
			if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable)
			{
				IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, true);
			}
		}
		else
		{
			bool flag = false;
			if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Reverse)
			{
				KKJLPMGPNPK = !KKJLPMGPNPK;
			}
			int i = 0;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!flag && !IKBQNBHOJJB.PBBDNDMELHQ(gameObject))
					{
						flag = true;
						IKBQNBHOJJB.IFPIGKGKFEQ(gameObject, false);
					}
					this.EDBBMFGOGHO += 0;
					if (this.BFHKGNKMDCQ == QMDFDJEIEMO.Toggle)
					{
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), false);
						uitweener.Toggle();
					}
					else
					{
						if (this.NPDGGFEQNLC || (this.NDCFIFKGJHO && !uitweener.enabled))
						{
							uitweener.Play(KKJLPMGPNPK);
							uitweener.ResetToBeginning();
						}
						EventDelegate.LHQECHHMOGD(uitweener.onFinished, new EventDelegate.LKPMKQMCHFH(this.MIPHKLNNNDK), false);
						uitweener.Play(KKJLPMGPNPK);
					}
				}
				i += 0;
			}
		}
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x00075A2C File Offset: 0x00073C2C
	private void BDLJHINPQIG()
	{
		if (base.enabled && !(UIToggle.current == null))
		{
			if (this.ILLDIKBCNMC == GLFJNQBJBOK.OnActivate || (this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick && UIToggle.current.value) || (this.ILLDIKBCNMC == (GLFJNQBJBOK)(-16) && !UIToggle.current.value))
			{
				this.MLOIHHQMFBN(UIToggle.current.value);
			}
			return;
		}
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x00075A94 File Offset: 0x00073C94
	private void Update()
	{
		if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable && this.MLODBCKJOIQ != null)
		{
			bool flag = true;
			bool flag2 = true;
			int i = 0;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!uitweener.enabled)
					{
						if (uitweener.direction != (QMDFDJEIEMO)this.BDDQCCPDJPP)
						{
							flag2 = false;
						}
					}
					else
					{
						flag = false;
						IL_62:
						if (flag)
						{
							if (flag2)
							{
								IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, false);
							}
							this.MLODBCKJOIQ = null;
							return;
						}
						return;
					}
				}
				i++;
			}
			goto IL_62;
		}
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00009001 File Offset: 0x00007201
	private void OnClick()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnClick)
		{
			this.MLOIHHQMFBN(true);
		}
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0000916A File Offset: 0x0000736A
	private void ONFJIHHQGJI()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnPressFalse)
		{
			this.MLOIHHQMFBN(false);
		}
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00075B1C File Offset: 0x00073D1C
	private void JLBMOKHNDBI()
	{
		if (this.BDDQCCPDJPP != PNDJHKBEPNM.DoNotDisable && this.MLODBCKJOIQ != null)
		{
			bool flag = false;
			bool flag2 = false;
			int i = 1;
			int num = this.MLODBCKJOIQ.Length;
			while (i < num)
			{
				UITweener uitweener = this.MLODBCKJOIQ[i];
				if (uitweener.tweenGroup == this.FDQPOOQFMEJ)
				{
					if (!uitweener.enabled)
					{
						if (uitweener.direction != (QMDFDJEIEMO)this.BDDQCCPDJPP)
						{
							flag2 = false;
						}
					}
					else
					{
						flag = true;
						IL_62:
						if (flag)
						{
							if (flag2)
							{
								IKBQNBHOJJB.IFPIGKGKFEQ(this.DMCGHNCHOHQ, true);
							}
							this.MLODBCKJOIQ = null;
							return;
						}
						return;
					}
				}
				i++;
			}
			goto IL_62;
		}
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00009185 File Offset: 0x00007385
	private void QCGENKHJDDH()
	{
		if (base.enabled && this.ILLDIKBCNMC == GLFJNQBJBOK.OnDoubleClick)
		{
			this.MLOIHHQMFBN(true);
		}
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x000090A8 File Offset: 0x000072A8
	private void Awake()
	{
		if (this.eventReceiver != null && EventDelegate.CPPLNKNPLPI(this.KCQKMKOQLQL))
		{
			this.eventReceiver = null;
			this.callWhenFinished = null;
		}
	}

	// Token: 0x04000273 RID: 627
	public static KDEHEGPKFBP OMQCQCBLQGJ;

	// Token: 0x04000274 RID: 628
	public GameObject DMCGHNCHOHQ;

	// Token: 0x04000275 RID: 629
	public int FDQPOOQFMEJ;

	// Token: 0x04000276 RID: 630
	public GLFJNQBJBOK ILLDIKBCNMC;

	// Token: 0x04000277 RID: 631
	public QMDFDJEIEMO BFHKGNKMDCQ = QMDFDJEIEMO.Forward;

	// Token: 0x04000278 RID: 632
	public bool NPDGGFEQNLC;

	// Token: 0x04000279 RID: 633
	public bool NDCFIFKGJHO;

	// Token: 0x0400027A RID: 634
	public GKKIEDPNJIF DCIKFMMLEQC;

	// Token: 0x0400027B RID: 635
	public PNDJHKBEPNM BDDQCCPDJPP;

	// Token: 0x0400027C RID: 636
	public bool CKCPEMIBLKH;

	// Token: 0x0400027D RID: 637
	public List<EventDelegate> KCQKMKOQLQL = new List<EventDelegate>();

	// Token: 0x0400027E RID: 638
	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	// Token: 0x0400027F RID: 639
	[SerializeField]
	[HideInInspector]
	private string callWhenFinished;

	// Token: 0x04000280 RID: 640
	private UITweener[] MLODBCKJOIQ;

	// Token: 0x04000281 RID: 641
	private bool PNBOOLEOKCI;

	// Token: 0x04000282 RID: 642
	private int EDBBMFGOGHO;

	// Token: 0x04000283 RID: 643
	private bool GIPNKCBQGDH;
}
