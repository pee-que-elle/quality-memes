using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200008B RID: 139
[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
public class EDHHEKQIDCM : MonoBehaviour
{
	// Token: 0x060011FE RID: 4606 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void PJMIKDIEGMB(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x060011FF RID: 4607 RVA: 0x00087760 File Offset: 0x00085960
	private void CBLIFECCHIC()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.CCPEOIJDFCC));
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x000877EC File Offset: 0x000859EC
	private void JIMBLQBBDKO()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.GJNENQLGPNO));
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00087878 File Offset: 0x00085A78
	public void NQQKINLCBJO()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.LLOHPLJBFMQ(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.EFQLGPDJENL(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void JHLDJFJMIFG(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x000878F0 File Offset: 0x00085AF0
	public void GJNENQLGPNO()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.LLOHPLJBFMQ(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.QQBFFEGLGDN(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void MDBEPCDNOIG(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00087968 File Offset: 0x00085B68
	private void IPEEHKMMPCD()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.NJJGNNIQDME));
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void IMMDFHKJEHL(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x000879F4 File Offset: 0x00085BF4
	private void GMFQFQQQFKC()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.NJJGNNIQDME));
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void NGKCGILOOHL(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void LHHMFNJCJOH(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x00087A80 File Offset: 0x00085C80
	public void LHMBBHIJQQM()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.LJNLHONIOPN(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.PBGDJFHDEGK(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void LLOHPLJBFMQ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00087AF8 File Offset: 0x00085CF8
	public void DDGNQFHEBJO()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.OPNJMNHEKEI(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.LJNLHONIOPN(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00087B70 File Offset: 0x00085D70
	public void JQPOMDKKQGN()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.PBGDJFHDEGK(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.KDJODMLBQEB(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void BOPHMCOEPQC(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void BLPNGMMJHNG(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void NDNFHGENFGQ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00087BE8 File Offset: 0x00085DE8
	public void DJQIGGCCKBJ()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.NKMQJHBCCJI(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.OPNJMNHEKEI(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void PBGDJFHDEGK(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00087C60 File Offset: 0x00085E60
	private void PIQJPNIKGJP()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.GJNENQLGPNO));
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void HFJQCLGHFMJ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00087CEC File Offset: 0x00085EEC
	private void PNJGKKPBDEB()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.DJQIGGCCKBJ));
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00087D78 File Offset: 0x00085F78
	private void Awake()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LHQECHHMOGD(component.onChange, new EventDelegate.LKPMKQMCHFH(this.JQFBBLKNFQM));
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00087E04 File Offset: 0x00086004
	public void BDPQCCOQFFK()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.KODHLLDFKGO(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.PBGDJFHDEGK(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00087E7C File Offset: 0x0008607C
	private void QQBINNCOFIG()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.DJQIGGCCKBJ));
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00087F08 File Offset: 0x00086108
	private void PLDQGPCJDGH()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.DDGNQFHEBJO));
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void JOBMLNJDKBH(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00087F94 File Offset: 0x00086194
	private void BMIIKIKIKIK()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.CQGDILJHFGK));
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void GLHNBDJMDKE(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00088020 File Offset: 0x00086220
	public void OGHCIMONBPN()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.GLHNBDJMDKE(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.NKMQJHBCCJI(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00088098 File Offset: 0x00086298
	private void EOKKQCMPDCJ()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.PEKGMQKPNMJ));
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00088124 File Offset: 0x00086324
	public void NEGDDBIKOMI()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.MLEGQPIDCCK(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.NKMQJHBCCJI(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void KDJODMLBQEB(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0008819C File Offset: 0x0008639C
	private void FBDGLDFKODD()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.LHMBBHIJQQM));
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00088228 File Offset: 0x00086428
	public void QFCBBDCLLKQ()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.MLEGQPIDCCK(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.MDBEPCDNOIG(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x000882A0 File Offset: 0x000864A0
	public void LPHQIIBKQEB()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.HNIJKCKHOFK(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.MDBEPCDNOIG(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void CEQNIBMEKQN(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00088318 File Offset: 0x00086518
	public void CEEDDHPCOCJ()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.LJNLHONIOPN(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.BLPNGMMJHNG(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00088390 File Offset: 0x00086590
	private void KFMEDIHJQQD()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.PMHQPFDDMQI));
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x0008841C File Offset: 0x0008661C
	public void PMHQPFDDMQI()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.EFJBHLEGHKL(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.QQBFFEGLGDN(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00088494 File Offset: 0x00086694
	private void OEOJDKBDNMJ()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.JQFBBLKNFQM));
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00088520 File Offset: 0x00086720
	private void EPGFPKPJNHF()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.IKDOEIMPNIO));
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x000885AC File Offset: 0x000867AC
	private void BMQJHNLJMEK()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.CCPEOIJDFCC));
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void KODHLLDFKGO(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00088638 File Offset: 0x00086838
	public void BHMFDCFQMOL()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.PJMIKDIEGMB(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.PJMIKDIEGMB(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x000886B0 File Offset: 0x000868B0
	public void NNONKQEFJGM()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.PJMIKDIEGMB(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.DMBLOQKLGKK(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void NPECJKGLCHJ(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00088728 File Offset: 0x00086928
	public void JQFBBLKNFQM()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.PJMIKDIEGMB(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.PJMIKDIEGMB(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x000887A0 File Offset: 0x000869A0
	public void GCPHFQKKEGM()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.LHHMFNJCJOH(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.MLEGQPIDCCK(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00088818 File Offset: 0x00086A18
	private void PGJHPMOLHKN()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.PEKGMQKPNMJ));
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x000888A4 File Offset: 0x00086AA4
	public void IKDOEIMPNIO()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.JHLDJFJMIFG(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.POGOJNGJKNI(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x0008891C File Offset: 0x00086B1C
	public void HCQEDLIIEBG()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				this.LLOHPLJBFMQ(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.JOBMLNJDKBH(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00088994 File Offset: 0x00086B94
	public void PEKGMQKPNMJ()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.EFQLGPDJENL(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.LHHMFNJCJOH(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void DJLMEDBJIEN(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void NKMQJHBCCJI(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void EFQLGPDJENL(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x00088A0C File Offset: 0x00086C0C
	private void LFJEJGOMLPI()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.NNONKQEFJGM));
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x00088A98 File Offset: 0x00086C98
	public void NHLGMOEBJBQ()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.IMMDFHKJEHL(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.MDBEPCDNOIG(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void DMBLOQKLGKK(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void LJNLHONIOPN(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void POGOJNGJKNI(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00087D78 File Offset: 0x00085F78
	private void MEOLPIBOBHB()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LHQECHHMOGD(component.onChange, new EventDelegate.LKPMKQMCHFH(this.JQFBBLKNFQM));
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00088B10 File Offset: 0x00086D10
	public void CCPEOIJDFCC()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.CEQNIBMEKQN(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				this.LHHMFNJCJOH(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00088B88 File Offset: 0x00086D88
	private void EBBBBBBOCPJ()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.NNONKQEFJGM));
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void HNIJKCKHOFK(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00088C14 File Offset: 0x00086E14
	public void NJJGNNIQDME()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.LJNLHONIOPN(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.MLEGQPIDCCK(this.LLPQQNQGMPM[j], !value);
			}
		}
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void EFJBHLEGHKL(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00088C8C File Offset: 0x00086E8C
	private void QIKFOCKCGKL()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.LHMBBHIJQQM));
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00087760 File Offset: 0x00085960
	private void IQEIPPBNBKH()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.CCPEOIJDFCC));
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void MLEGQPIDCCK(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00088D18 File Offset: 0x00086F18
	private void NNPPKOGDNOM()
	{
		if (this.target != null)
		{
			if (this.ODPKQOIFKMB.Count == 0 && this.LLPQQNQGMPM.Count == 0)
			{
				if (this.inverse)
				{
					this.LLPQQNQGMPM.Add(this.target);
				}
				else
				{
					this.ODPKQOIFKMB.Add(this.target);
				}
			}
			else
			{
				this.target = null;
			}
		}
		UIToggle component = base.GetComponent<UIToggle>();
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.JQFBBLKNFQM));
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00088DA4 File Offset: 0x00086FA4
	public void CQGDILJHFGK()
	{
		bool value = UIToggle.current.value;
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				this.MLEGQPIDCCK(this.ODPKQOIFKMB[i], value);
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				this.MLEGQPIDCCK(this.LLPQQNQGMPM[j], value);
			}
		}
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void QQBFFEGLGDN(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void OPNJMNHEKEI(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x0000A6E8 File Offset: 0x000088E8
	private void QCIGQMIKGBH(GameObject CGHIENBIHCO, bool HHJEFGFNBPG)
	{
		if (CGHIENBIHCO != null)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(CGHIENBIHCO, HHJEFGFNBPG);
		}
	}

	// Token: 0x04000356 RID: 854
	public List<GameObject> ODPKQOIFKMB;

	// Token: 0x04000357 RID: 855
	public List<GameObject> LLPQQNQGMPM;

	// Token: 0x04000358 RID: 856
	[HideInInspector]
	[SerializeField]
	private GameObject target;

	// Token: 0x04000359 RID: 857
	[HideInInspector]
	[SerializeField]
	private bool inverse;
}
