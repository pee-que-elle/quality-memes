using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
[AddComponentMenu("NGUI/Interaction/Saved Option")]
public class EGGLDDLQLME : MonoBehaviour
{
	// Token: 0x06001038 RID: 4152 RVA: 0x000097CA File Offset: 0x000079CA
	public void FFCICHGHBCC()
	{
		PlayerPrefs.SetFloat(this.PICNCDINJPQ(), BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ());
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x000097E1 File Offset: 0x000079E1
	private void Awake()
	{
		this.JNMDHMGQBMD = base.GetComponent<QCPKMJONIGF>();
		this.DQJCFQMONFN = base.GetComponent<UIToggle>();
		this.LQBJQLNLNID = base.GetComponent<BJQGLGOLMPQ>();
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x0007A7B0 File Offset: 0x000789B0
	private void GIBEHDOEMDB()
	{
		if (this.DQJCFQMONFN != null)
		{
			EventDelegate.QPCPQKPQGEC(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
		}
		else if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.HFOLJHQMMFF));
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.FFCICHGHBCC));
		}
		else
		{
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				if (uitoggle.value)
				{
					PlayerPrefs.SetString(this.LOHECPFGPGO, uitoggle.name);
					break;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x0007A880 File Offset: 0x00078A80
	private void JGPFFDGPGFJ()
	{
		if (this.DQJCFQMONFN != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
		}
		else if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.QPCPQKPQGEC(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.HFOLJHQMMFF));
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.QPCPQKPQGEC(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PLPMOMMPQBI));
		}
		else
		{
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				if (uitoggle.value)
				{
					PlayerPrefs.SetString(this.IGBBOOCQINM(), uitoggle.name);
					break;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0007A950 File Offset: 0x00078B50
	private void FBDPQLQPFPM()
	{
		if (this.DQJCFQMONFN != null)
		{
			EventDelegate.QPCPQKPQGEC(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
		}
		else if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.QPCPQKPQGEC(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PJNBGFEIIKM));
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PLPMOMMPQBI));
		}
		else
		{
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				if (uitoggle.value)
				{
					PlayerPrefs.SetString(this.LDFNGOJHOLJ(), uitoggle.name);
					break;
				}
				i++;
			}
		}
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00009807 File Offset: 0x00007A07
	private string LDFNGOJHOLJ()
	{
		return (!string.IsNullOrEmpty(this.EKLJDIJHKME)) ? this.EKLJDIJHKME : ("K5" + base.name);
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0000982E File Offset: 0x00007A2E
	public void PLPMOMMPQBI()
	{
		PlayerPrefs.SetFloat(this.PICNCDINJPQ(), BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC);
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00009845 File Offset: 0x00007A45
	private string IGBBOOCQINM()
	{
		return (!string.IsNullOrEmpty(this.EKLJDIJHKME)) ? this.EKLJDIJHKME : ("typeadd" + base.name);
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x0000986C File Offset: 0x00007A6C
	public void ENONDGPIPQP()
	{
		PlayerPrefs.SetInt(this.IGBBOOCQINM(), (!UIToggle.current.value) ? 1 : 0);
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00009889 File Offset: 0x00007A89
	public void NCNHIFGGMBG()
	{
		PlayerPrefs.SetFloat(this.LDFNGOJHOLJ(), BJQGLGOLMPQ.OMQCQCBLQGJ.HKDJGHOHBFQ());
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06001042 RID: 4162 RVA: 0x000098A0 File Offset: 0x00007AA0
	private string LOHECPFGPGO
	{
		get
		{
			return (!string.IsNullOrEmpty(this.EKLJDIJHKME)) ? this.EKLJDIJHKME : ("NGUI State: " + base.name);
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x0007AA20 File Offset: 0x00078C20
	private void OnDisable()
	{
		if (this.DQJCFQMONFN != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
		}
		else if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PJNBGFEIIKM));
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.OBHLOJCMDIH));
		}
		else
		{
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				if (uitoggle.value)
				{
					PlayerPrefs.SetString(this.LOHECPFGPGO, uitoggle.name);
					break;
				}
				i++;
			}
		}
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x000097E1 File Offset: 0x000079E1
	private void MEOLPIBOBHB()
	{
		this.JNMDHMGQBMD = base.GetComponent<QCPKMJONIGF>();
		this.DQJCFQMONFN = base.GetComponent<UIToggle>();
		this.LQBJQLNLNID = base.GetComponent<BJQGLGOLMPQ>();
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x000097E1 File Offset: 0x000079E1
	private void CHKQIFFEEPL()
	{
		this.JNMDHMGQBMD = base.GetComponent<QCPKMJONIGF>();
		this.DQJCFQMONFN = base.GetComponent<UIToggle>();
		this.LQBJQLNLNID = base.GetComponent<BJQGLGOLMPQ>();
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x000098C7 File Offset: 0x00007AC7
	private string PICNCDINJPQ()
	{
		return (!string.IsNullOrEmpty(this.EKLJDIJHKME)) ? this.EKLJDIJHKME : ("_TileMaxLoop" + base.name);
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x000097E1 File Offset: 0x000079E1
	private void IPKCDQONLBJ()
	{
		this.JNMDHMGQBMD = base.GetComponent<QCPKMJONIGF>();
		this.DQJCFQMONFN = base.GetComponent<UIToggle>();
		this.LQBJQLNLNID = base.GetComponent<BJQGLGOLMPQ>();
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x0007AAF0 File Offset: 0x00078CF0
	private void OnEnable()
	{
		if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.LHQECHHMOGD(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PJNBGFEIIKM));
			string @string = PlayerPrefs.GetString(this.LOHECPFGPGO);
			if (!string.IsNullOrEmpty(@string))
			{
				this.JNMDHMGQBMD.BGBMIEJJQKC = @string;
			}
		}
		else if (this.DQJCFQMONFN != null)
		{
			EventDelegate.LHQECHHMOGD(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
			this.DQJCFQMONFN.value = (PlayerPrefs.GetInt(this.LOHECPFGPGO, (!this.DQJCFQMONFN.startsActive) ? 0 : 1) != 0);
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.LHQECHHMOGD(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.OBHLOJCMDIH));
			this.LQBJQLNLNID.BGBMIEJJQKC = PlayerPrefs.GetFloat(this.LOHECPFGPGO, this.LQBJQLNLNID.BGBMIEJJQKC);
		}
		else
		{
			string string2 = PlayerPrefs.GetString(this.LOHECPFGPGO);
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				uitoggle.value = (uitoggle.name == string2);
				i++;
			}
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0007AC3C File Offset: 0x00078E3C
	private void NFPQKFCHDGM()
	{
		if (this.DQJCFQMONFN != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.ENONDGPIPQP));
		}
		else if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.FQDMDDOHCQJ(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.HFOLJHQMMFF));
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.QPCPQKPQGEC(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.OBHLOJCMDIH));
		}
		else
		{
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				if (uitoggle.value)
				{
					PlayerPrefs.SetString(this.LOHECPFGPGO, uitoggle.name);
					break;
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x000098EE File Offset: 0x00007AEE
	public void QFJIOOMIIPQ()
	{
		PlayerPrefs.SetInt(this.LOHECPFGPGO, (!UIToggle.current.value) ? 0 : 0);
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x0000990B File Offset: 0x00007B0B
	public void PJNBGFEIIKM()
	{
		PlayerPrefs.SetString(this.LOHECPFGPGO, QCPKMJONIGF.OMQCQCBLQGJ.BGBMIEJJQKC);
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x000097E1 File Offset: 0x000079E1
	private void OHGPOPQILFG()
	{
		this.JNMDHMGQBMD = base.GetComponent<QCPKMJONIGF>();
		this.DQJCFQMONFN = base.GetComponent<UIToggle>();
		this.LQBJQLNLNID = base.GetComponent<BJQGLGOLMPQ>();
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0007AD0C File Offset: 0x00078F0C
	private void EBIJMQIMQOF()
	{
		if (this.JNMDHMGQBMD != null)
		{
			EventDelegate.IPDHQPLBNFQ(this.JNMDHMGQBMD.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.PJNBGFEIIKM));
			string @string = PlayerPrefs.GetString(this.IGBBOOCQINM());
			if (!string.IsNullOrEmpty(@string))
			{
				this.JNMDHMGQBMD.BGBMIEJJQKC = @string;
			}
		}
		else if (this.DQJCFQMONFN != null)
		{
			EventDelegate.LHQECHHMOGD(this.DQJCFQMONFN.onChange, new EventDelegate.LKPMKQMCHFH(this.DGEGHMNIMLC));
			this.DQJCFQMONFN.value = (PlayerPrefs.GetInt(this.LDFNGOJHOLJ(), (!this.DQJCFQMONFN.startsActive) ? 0 : 1) != 1);
		}
		else if (this.LQBJQLNLNID != null)
		{
			EventDelegate.IPDHQPLBNFQ(this.LQBJQLNLNID.OHEFEKMMIFL, new EventDelegate.LKPMKQMCHFH(this.FFCICHGHBCC));
			this.LQBJQLNLNID.GIPBBFDPCKG(PlayerPrefs.GetFloat(this.IGBBOOCQINM(), this.LQBJQLNLNID.HKDJGHOHBFQ()));
		}
		else
		{
			string string2 = PlayerPrefs.GetString(this.LDFNGOJHOLJ());
			UIToggle[] componentsInChildren = base.GetComponentsInChildren<UIToggle>(true);
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				UIToggle uitoggle = componentsInChildren[i];
				uitoggle.value = (uitoggle.name == string2);
				i++;
			}
		}
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00009922 File Offset: 0x00007B22
	public void DGEGHMNIMLC()
	{
		PlayerPrefs.SetInt(this.LOHECPFGPGO, (!UIToggle.current.value) ? 0 : 1);
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0000993F File Offset: 0x00007B3F
	public void OBHLOJCMDIH()
	{
		PlayerPrefs.SetFloat(this.LOHECPFGPGO, BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC);
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x00009956 File Offset: 0x00007B56
	public void HFOLJHQMMFF()
	{
		PlayerPrefs.SetString(this.PICNCDINJPQ(), QCPKMJONIGF.OMQCQCBLQGJ.ONPQLDJHHGB());
	}

	// Token: 0x040002DA RID: 730
	public string EKLJDIJHKME;

	// Token: 0x040002DB RID: 731
	private QCPKMJONIGF JNMDHMGQBMD;

	// Token: 0x040002DC RID: 732
	private UIToggle DQJCFQMONFN;

	// Token: 0x040002DD RID: 733
	private BJQGLGOLMPQ LQBJQLNLNID;
}
