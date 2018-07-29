using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200008A RID: 138
[RequireComponent(typeof(UIToggle))]
[AddComponentMenu("NGUI/Interaction/Toggled Components")]
[ExecuteInEditMode]
public class ODKFNJJIFQG : MonoBehaviour
{
	// Token: 0x060011E9 RID: 4585 RVA: 0x00086F00 File Offset: 0x00085100
	private void MCPOMCHMKJK()
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
		EventDelegate.LHQECHHMOGD(component.onChange, new EventDelegate.LKPMKQMCHFH(this.BDPQCCOQFFK));
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00086F8C File Offset: 0x0008518C
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

	// Token: 0x060011EB RID: 4587 RVA: 0x00087018 File Offset: 0x00085218
	public void BDGKBKGCBBJ()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00087098 File Offset: 0x00085298
	public void BDPQCCOQFFK()
	{
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00087118 File Offset: 0x00085318
	private void PEOBQCMFLML()
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
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.NDOGEMQJOJF));
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x000871A4 File Offset: 0x000853A4
	public void NDOGEMQJOJF()
	{
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00087224 File Offset: 0x00085424
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
		EventDelegate.IPDHQPLBNFQ(component.onChange, new EventDelegate.LKPMKQMCHFH(this.DHBGECDECGC));
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x000872B0 File Offset: 0x000854B0
	public void LKKNELOCBMP()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x000871A4 File Offset: 0x000853A4
	public void LPHQIIBKQEB()
	{
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00087330 File Offset: 0x00085530
	private void HLHPCLEMCKI()
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
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.BDGKBKGCBBJ));
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x000873BC File Offset: 0x000855BC
	private void LEJQMIECFCH()
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
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.JQFBBLKNFQM));
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00087448 File Offset: 0x00085648
	public void DDGNQFHEBJO()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x000872B0 File Offset: 0x000854B0
	public void NNONKQEFJGM()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00087448 File Offset: 0x00085648
	public void NNLOFLGBLKE()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x000874C8 File Offset: 0x000856C8
	public void GKEGDQPCCGM()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011F9 RID: 4601 RVA: 0x00087548 File Offset: 0x00085748
	private void IPKCDQONLBJ()
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
		EventDelegate.CKGFMHDGPIN(component.onChange, new EventDelegate.LKPMKQMCHFH(this.LKKNELOCBMP));
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x000875D4 File Offset: 0x000857D4
	public void DQOHMEMLEBI()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 1; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00087654 File Offset: 0x00085854
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
		EventDelegate.LQCGLENQEDM(component.onChange, new EventDelegate.LKPMKQMCHFH(this.LKKNELOCBMP));
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x000872B0 File Offset: 0x000854B0
	public void DHBGECDECGC()
	{
		if (base.enabled)
		{
			for (int i = 1; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x060011FD RID: 4605 RVA: 0x000876E0 File Offset: 0x000858E0
	public void JQFBBLKNFQM()
	{
		if (base.enabled)
		{
			for (int i = 0; i < this.ODPKQOIFKMB.Count; i++)
			{
				MonoBehaviour monoBehaviour = this.ODPKQOIFKMB[i];
				monoBehaviour.enabled = UIToggle.current.value;
			}
			for (int j = 0; j < this.LLPQQNQGMPM.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = this.LLPQQNQGMPM[j];
				monoBehaviour2.enabled = !UIToggle.current.value;
			}
		}
	}

	// Token: 0x04000352 RID: 850
	public List<MonoBehaviour> ODPKQOIFKMB;

	// Token: 0x04000353 RID: 851
	public List<MonoBehaviour> LLPQQNQGMPM;

	// Token: 0x04000354 RID: 852
	[HideInInspector]
	[SerializeField]
	private MonoBehaviour target;

	// Token: 0x04000355 RID: 853
	[HideInInspector]
	[SerializeField]
	private bool inverse;
}
