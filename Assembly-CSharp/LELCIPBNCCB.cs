using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200037D RID: 893
[HelpURL("http://www.procamera2d.com/user-guide/trigger-boundaries/")]
public class LELCIPBNCCB : JKQPIHPQDHQ, PDLMPKMDBBQ
{
	// Token: 0x060076A2 RID: 30370 RVA: 0x0038B844 File Offset: 0x00389A44
	protected virtual void OKHMCBJOHDN()
	{
		base.DOJBNQQEFBE();
		if (this.LMODGJFCFNL.MMKHBFGFDQO != null)
		{
			base.StartCoroutine(this.FDBOBQIINJD(this.LMODGJFCFNL.MMKHBFGFDQO));
		}
		if ((this.LMODGJFCFNL.MMKHBFGFDQO != null && this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ != this.PHFGINEKBGQ) || this.LMODGJFCFNL.MMKHBFGFDQO == null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			base.StartCoroutine(this.FFKKNCPPHGK());
		}
	}

	// Token: 0x060076A3 RID: 30371 RVA: 0x0038B8DC File Offset: 0x00389ADC
	protected virtual void OLKMMICCQLP()
	{
		base.DOJBNQQEFBE();
		if (this.LMODGJFCFNL.MMKHBFGFDQO != null)
		{
			base.StartCoroutine(this.FDBOBQIINJD(this.LMODGJFCFNL.MMKHBFGFDQO));
		}
		if ((this.LMODGJFCFNL.MMKHBFGFDQO != null && this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ != this.PHFGINEKBGQ) || this.LMODGJFCFNL.MMKHBFGFDQO == null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			base.StartCoroutine(this.DGPGDLOOOFF());
		}
	}

	// Token: 0x060076A4 RID: 30372 RVA: 0x0002AB06 File Offset: 0x00028D06
	[CompilerGenerated]
	private void BMCLCFCNBKB()
	{
		if (this.LMODGJFCFNL.EBHHEFPJIKL != null)
		{
			this.LMODGJFCFNL.EBHHEFPJIKL();
		}
	}

	// Token: 0x060076A5 RID: 30373 RVA: 0x0002AB25 File Offset: 0x00028D25
	public bool FIBJFOFKLFK()
	{
		return this.JNBGPEQPGGH;
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x060076C6 RID: 30406 RVA: 0x0002AB25 File Offset: 0x00028D25
	// (set) Token: 0x060076A6 RID: 30374 RVA: 0x0038B974 File Offset: 0x00389B74
	public bool JDBMMPEBJMB
	{
		get
		{
			return this.JNBGPEQPGGH;
		}
		set
		{
			if (value && !this.JNBGPEQPGGH)
			{
				UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(LELCIPBNCCB));
				foreach (LELCIPBNCCB lelcipbnccb in array)
				{
					lelcipbnccb.JDBMMPEBJMB = false;
				}
			}
			this.JNBGPEQPGGH = value;
		}
	}

	// Token: 0x060076A7 RID: 30375 RVA: 0x0038B9C4 File Offset: 0x00389BC4
	private void OMLLCJNIHBG(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.LMODGJFCFNL.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f < this.LMODGJFCFNL.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.DFFQECIDMDO + base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f;
		}
		else if (this.LMODGJFCFNL.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f > this.LMODGJFCFNL.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.JGJEPKHCBGP - base.GPONHFNLHCN.PGKODNCDNJQ.x / 2f;
		}
		if (this.LMODGJFCFNL.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f < this.LMODGJFCFNL.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.BIPDHOPHDMK + base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		}
		else if (this.LMODGJFCFNL.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f > this.LMODGJFCFNL.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.MMHQFDMKQDQ - base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		}
	}

	// Token: 0x060076A8 RID: 30376 RVA: 0x0002AB2D File Offset: 0x00028D2D
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060076A9 RID: 30377 RVA: 0x0002AB41 File Offset: 0x00028D41
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.BOFHBQKBBFC(this);
		}
	}

	// Token: 0x060076AA RID: 30378 RVA: 0x0002AB06 File Offset: 0x00028D06
	private void NOPONLBDHLQ()
	{
		if (this.LMODGJFCFNL.EBHHEFPJIKL != null)
		{
			this.LMODGJFCFNL.EBHHEFPJIKL();
		}
	}

	// Token: 0x060076AB RID: 30379 RVA: 0x0038BB50 File Offset: 0x00389D50
	protected override void DOJBNQQEFBE()
	{
		base.DOJBNQQEFBE();
		if (this.LMODGJFCFNL.MMKHBFGFDQO != null)
		{
			base.StartCoroutine(this.CBBDKBKIIDH(this.LMODGJFCFNL.MMKHBFGFDQO));
		}
		if ((this.LMODGJFCFNL.MMKHBFGFDQO != null && this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ != this.PHFGINEKBGQ) || this.LMODGJFCFNL.MMKHBFGFDQO == null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			base.StartCoroutine(this.FFKKNCPPHGK());
		}
	}

	// Token: 0x060076AC RID: 30380 RVA: 0x0038BBE8 File Offset: 0x00389DE8
	public void KBNPJIJOQJK(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC && !this.JNBGPEQPGGH)
		{
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(LELCIPBNCCB));
			foreach (LELCIPBNCCB lelcipbnccb in array)
			{
				lelcipbnccb.KBNPJIJOQJK(false);
			}
		}
		this.JNBGPEQPGGH = BGBMIEJJQKC;
	}

	// Token: 0x060076AD RID: 30381 RVA: 0x0038BB50 File Offset: 0x00389D50
	protected virtual void KCGFNGGMLJE()
	{
		base.DOJBNQQEFBE();
		if (this.LMODGJFCFNL.MMKHBFGFDQO != null)
		{
			base.StartCoroutine(this.CBBDKBKIIDH(this.LMODGJFCFNL.MMKHBFGFDQO));
		}
		if ((this.LMODGJFCFNL.MMKHBFGFDQO != null && this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ != this.PHFGINEKBGQ) || this.LMODGJFCFNL.MMKHBFGFDQO == null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			base.StartCoroutine(this.FFKKNCPPHGK());
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x060076AE RID: 30382 RVA: 0x0002AB62 File Offset: 0x00028D62
	public bool KMQFLPMKQPB
	{
		get
		{
			return this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ == this.PHFGINEKBGQ;
		}
	}

	// Token: 0x060076AF RID: 30383 RVA: 0x0002AB7C File Offset: 0x00028D7C
	public void QGOFKBMJEII(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x060076B0 RID: 30384 RVA: 0x0038BC38 File Offset: 0x00389E38
	private void FFLPMOKLOCB()
	{
		if (this.BMMJLPFNENL)
		{
			this.KCNQMDOKFFH = this.JNBBJCLFFBB(base.transform.position) + this.MMHQFDMKQDQ;
			this.GGMEMPEGNML = this.JNBBJCLFFBB(base.transform.position) + this.BIPDHOPHDMK;
			this.EEMEFDFICBK = this.FKGNBCKJPQO(base.transform.position) + this.DFFQECIDMDO;
			this.DNHGBLNKIDM = this.FKGNBCKJPQO(base.transform.position) + this.JGJEPKHCBGP;
		}
		else
		{
			this.KCNQMDOKFFH = this.MMHQFDMKQDQ;
			this.GGMEMPEGNML = this.BIPDHOPHDMK;
			this.EEMEFDFICBK = this.DFFQECIDMDO;
			this.DNHGBLNKIDM = this.JGJEPKHCBGP;
		}
	}

	// Token: 0x060076B1 RID: 30385 RVA: 0x0002AB85 File Offset: 0x00028D85
	public int QQKFEBGDEGD()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x060076B2 RID: 30386 RVA: 0x0002AB2D File Offset: 0x00028D2D
	protected virtual void FOLBFDNJLII()
	{
		base.Awake();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060076B3 RID: 30387 RVA: 0x0002AB2D File Offset: 0x00028D2D
	protected virtual void NGDJNKQELNO()
	{
		base.Awake();
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
	}

	// Token: 0x060076B4 RID: 30388 RVA: 0x0038B844 File Offset: 0x00389A44
	protected virtual void NKHKKBEQGIN()
	{
		base.DOJBNQQEFBE();
		if (this.LMODGJFCFNL.MMKHBFGFDQO != null)
		{
			base.StartCoroutine(this.FDBOBQIINJD(this.LMODGJFCFNL.MMKHBFGFDQO));
		}
		if ((this.LMODGJFCFNL.MMKHBFGFDQO != null && this.LMODGJFCFNL.MMKHBFGFDQO.PHFGINEKBGQ != this.PHFGINEKBGQ) || this.LMODGJFCFNL.MMKHBFGFDQO == null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			base.StartCoroutine(this.FFKKNCPPHGK());
		}
	}

	// Token: 0x060076B5 RID: 30389 RVA: 0x0038BD10 File Offset: 0x00389F10
	private void Start()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (this.LMODGJFCFNL == null)
		{
			MDFGNNIKFEP mdfgnnikfep = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
			this.LMODGJFCFNL = ((!(mdfgnnikfep == null)) ? mdfgnnikfep : base.GPONHFNLHCN.gameObject.AddComponent<MDFGNNIKFEP>());
		}
		this.OLQHKGLLECQ = new PEDFEBKECPI(base.GPONHFNLHCN, this.LMODGJFCFNL);
		PEDFEBKECPI olqhkgllecq = this.OLQHKGLLECQ;
		olqhkgllecq.MQJKNKDJNKH = (Action)Delegate.Combine(olqhkgllecq.MQJKNKDJNKH, new Action(this.HIKHNHLPQNI));
		PEDFEBKECPI olqhkgllecq2 = this.OLQHKGLLECQ;
		olqhkgllecq2.MGEOIQMIIQK = (Action)Delegate.Combine(olqhkgllecq2.MGEOIQMIIQK, new Action(this.BMCLCFCNBKB));
		this.FFLPMOKLOCB();
		if (this.JDBMMPEBJMB)
		{
			this.LFHBDCEGLIM();
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
	}

	// Token: 0x060076B6 RID: 30390 RVA: 0x0038BDFC File Offset: 0x00389FFC
	private IEnumerator FDBOBQIINJD(LELCIPBNCCB ILLDIKBCNMC)
	{
		yield return new WaitForEndOfFrame();
		return 1;
		ILLDIKBCNMC.GKDDKEJOFBP = false;
		yield break;
	}

	// Token: 0x060076B7 RID: 30391 RVA: 0x0038BE18 File Offset: 0x0038A018
	public void LFHBDCEGLIM()
	{
		if (this.LMODGJFCFNL != null)
		{
			this.LMODGJFCFNL.MMKHBFGFDQO = this;
			this.LMODGJFCFNL.QBHHBPBKQDJ = this.QBHHBPBKQDJ;
			if (this.QBHHBPBKQDJ)
			{
				this.LMODGJFCFNL.DFFQECIDMDO = (this.LMODGJFCFNL.CLGBNOOJKQK = this.EEMEFDFICBK);
			}
			this.LMODGJFCFNL.IGPBFPCKNOG = this.IGPBFPCKNOG;
			if (this.IGPBFPCKNOG)
			{
				this.LMODGJFCFNL.JGJEPKHCBGP = (this.LMODGJFCFNL.CJJLGEHJIBE = this.DNHGBLNKIDM);
			}
			this.LMODGJFCFNL.PELBNKEHOHF = this.PELBNKEHOHF;
			if (this.PELBNKEHOHF)
			{
				this.LMODGJFCFNL.MMHQFDMKQDQ = (this.LMODGJFCFNL.MJJNGHFJEOI = this.KCNQMDOKFFH);
			}
			this.LMODGJFCFNL.IKDQPKGPPEH = this.IKDQPKGPPEH;
			if (this.IKDQPKGPPEH)
			{
				this.LMODGJFCFNL.BIPDHOPHDMK = (this.LMODGJFCFNL.CBHMJNDMNOE = this.GGMEMPEGNML);
			}
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x060076B8 RID: 30392 RVA: 0x0002AB85 File Offset: 0x00028D85
	// (set) Token: 0x060076C9 RID: 30409 RVA: 0x0002AB7C File Offset: 0x00028D7C
	public int IDIPKDLCMCK
	{
		get
		{
			return this.HNMJQQFFBCL;
		}
		set
		{
			this.HNMJQQFFBCL = value;
		}
	}

	// Token: 0x060076B9 RID: 30393 RVA: 0x0038BF24 File Offset: 0x0038A124
	private void DLDCHLKJDHB(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.LMODGJFCFNL.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.FOOEEHDJBQN().x / 1589f < this.LMODGJFCFNL.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.DFFQECIDMDO + base.GPONHFNLHCN.PGKODNCDNJQ.x / 1255f;
		}
		else if (this.LMODGJFCFNL.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.FOOEEHDJBQN().x / 84f > this.LMODGJFCFNL.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.JGJEPKHCBGP - base.GPONHFNLHCN.FOOEEHDJBQN().x / 1096f;
		}
		if (this.LMODGJFCFNL.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1426f < this.LMODGJFCFNL.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.BIPDHOPHDMK + base.GPONHFNLHCN.PGKODNCDNJQ.y / 1538f;
		}
		else if (this.LMODGJFCFNL.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.PGKODNCDNJQ.y / 1525f > this.LMODGJFCFNL.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.MMHQFDMKQDQ - base.GPONHFNLHCN.PGKODNCDNJQ.y / 429f;
		}
	}

	// Token: 0x060076BA RID: 30394 RVA: 0x0002AB8D File Offset: 0x00028D8D
	[CompilerGenerated]
	private void HIKHNHLPQNI()
	{
		if (this.LMODGJFCFNL.NFKPHODMHLK != null)
		{
			this.LMODGJFCFNL.NFKPHODMHLK();
		}
	}

	// Token: 0x060076BB RID: 30395 RVA: 0x0002AB8D File Offset: 0x00028D8D
	private void IENLBDJBJLO()
	{
		if (this.LMODGJFCFNL.NFKPHODMHLK != null)
		{
			this.LMODGJFCFNL.NFKPHODMHLK();
		}
	}

	// Token: 0x060076BC RID: 30396 RVA: 0x0002AB25 File Offset: 0x00028D25
	public bool OFEPCQJJLLJ()
	{
		return this.JNBGPEQPGGH;
	}

	// Token: 0x060076BD RID: 30397 RVA: 0x0002AB25 File Offset: 0x00028D25
	public bool EKJNLIQFFHG()
	{
		return this.JNBGPEQPGGH;
	}

	// Token: 0x060076BE RID: 30398 RVA: 0x0038C0B0 File Offset: 0x0038A2B0
	private IEnumerator DGPGDLOOOFF()
	{
		if (!this.PELBNKEHOHF && !this.IKDQPKGPPEH && !this.QBHHBPBKQDJ && !this.IGPBFPCKNOG)
		{
			this.LMODGJFCFNL.PELBNKEHOHF = false;
			this.LMODGJFCFNL.IKDQPKGPPEH = false;
			this.LMODGJFCFNL.QBHHBPBKQDJ = false;
			this.LMODGJFCFNL.IGPBFPCKNOG = false;
			yield break;
		}
		Vector3 position = base.transform.position;
		float num = (!this.BMMJLPFNENL) ? this.MMHQFDMKQDQ : (position.y + this.MMHQFDMKQDQ);
		float num2 = (!this.BMMJLPFNENL) ? this.BIPDHOPHDMK : (position.y + this.BIPDHOPHDMK);
		float num3 = (!this.BMMJLPFNENL) ? this.DFFQECIDMDO : (position.x + this.DFFQECIDMDO);
		float num4 = (!this.BMMJLPFNENL) ? this.JGJEPKHCBGP : (position.x + this.JGJEPKHCBGP);
		bool flag = true;
		if (this.PELBNKEHOHF && (Mathf.Abs(this.LMODGJFCFNL.MMHQFDMKQDQ - num) > 0.01f || !this.LMODGJFCFNL.PELBNKEHOHF))
		{
			flag = false;
		}
		if (flag && this.IKDQPKGPPEH && (Mathf.Abs(this.LMODGJFCFNL.BIPDHOPHDMK - num2) > 0.01f || !this.LMODGJFCFNL.IKDQPKGPPEH))
		{
			flag = false;
		}
		if (flag && this.QBHHBPBKQDJ && (Mathf.Abs(this.LMODGJFCFNL.DFFQECIDMDO - num3) > 0.01f || !this.LMODGJFCFNL.QBHHBPBKQDJ))
		{
			flag = false;
		}
		if (flag && this.IGPBFPCKNOG && (Mathf.Abs(this.LMODGJFCFNL.JGJEPKHCBGP - num4) > 0.01f || !this.LMODGJFCFNL.IGPBFPCKNOG))
		{
			flag = false;
		}
		if (!flag)
		{
			this.FFLPMOKLOCB();
			this.OLQHKGLLECQ.PELBNKEHOHF = this.PELBNKEHOHF;
			this.OLQHKGLLECQ.MMHQFDMKQDQ = this.KCNQMDOKFFH;
			this.OLQHKGLLECQ.IKDQPKGPPEH = this.IKDQPKGPPEH;
			this.OLQHKGLLECQ.BIPDHOPHDMK = this.GGMEMPEGNML;
			this.OLQHKGLLECQ.QBHHBPBKQDJ = this.QBHHBPBKQDJ;
			this.OLQHKGLLECQ.DFFQECIDMDO = this.EEMEFDFICBK;
			this.OLQHKGLLECQ.IGPBFPCKNOG = this.IGPBFPCKNOG;
			this.OLQHKGLLECQ.JGJEPKHCBGP = this.DNHGBLNKIDM;
			this.OLQHKGLLECQ.GEDLQKQGGCH = this.GEDLQKQGGCH;
			this.OLQHKGLLECQ.FGELPQPIOJF = this.FGELPQPIOJF;
			if (this.CNHBCJEQEMO && this.LQHQFLHFQLO / this.IIQGQIKIOHG != base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f)
			{
				base.GPONHFNLHCN.LHCFKHKLLOL(this.LQHQFLHFQLO / this.IIQGQIKIOHG, this.CIJKPQCMOMK, this.FGELPQPIOJF);
			}
			if (this.OLQHKGLLECQ.LCLJBHQNMLE() > 1)
			{
				if (this.LMODGJFCFNL.JJLDKIHQJGG != null)
				{
					this.LMODGJFCFNL.StopCoroutine(this.LMODGJFCFNL.JJLDKIHQJGG);
				}
				this.LMODGJFCFNL.JJLDKIHQJGG = this.LMODGJFCFNL.StartCoroutine(this.GDMDCDPLPNP());
			}
			yield return new WaitForEndOfFrame();
			return 1;
		}
		yield break;
		this.OLQHKGLLECQ.FFKKNCPPHGK();
		yield break;
	}

	// Token: 0x060076C0 RID: 30400 RVA: 0x0002ABB8 File Offset: 0x00028DB8
	public Vector3 FIOLQHKHOED(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		if (this.GKDDKEJOFBP)
		{
			return this.NHCKFQMGIJD;
		}
		return PJKPLOCIBHP;
	}

	// Token: 0x060076C2 RID: 30402 RVA: 0x0038C15C File Offset: 0x0038A35C
	[DebuggerHidden]
	private IEnumerator GDMDCDPLPNP()
	{
		LELCIPBNCCB.BFLIEOIOGEO bflieoiogeo = new LELCIPBNCCB.BFLIEOIOGEO();
		bflieoiogeo.QNDQJMNKFNN = this;
		return bflieoiogeo;
	}

	// Token: 0x060076C3 RID: 30403 RVA: 0x0038BDFC File Offset: 0x00389FFC
	private IEnumerator CBBDKBKIIDH(LELCIPBNCCB ILLDIKBCNMC)
	{
		yield return new WaitForEndOfFrame();
		return 1;
		ILLDIKBCNMC.GKDDKEJOFBP = false;
		yield break;
	}

	// Token: 0x060076C4 RID: 30404 RVA: 0x0002AB25 File Offset: 0x00028D25
	public bool FIQOFGCQQBG()
	{
		return this.JNBGPEQPGGH;
	}

	// Token: 0x060076C5 RID: 30405 RVA: 0x0038C178 File Offset: 0x0038A378
	private void PBJQFJMOCPQ(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC)
	{
		if (this.LMODGJFCFNL.QBHHBPBKQDJ && LHCLJCLFKFJ - base.GPONHFNLHCN.FOOEEHDJBQN().x / 628f < this.LMODGJFCFNL.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.DFFQECIDMDO + base.GPONHFNLHCN.FOOEEHDJBQN().x / 1521f;
		}
		else if (this.LMODGJFCFNL.IGPBFPCKNOG && LHCLJCLFKFJ + base.GPONHFNLHCN.PGKODNCDNJQ.x / 242f > this.LMODGJFCFNL.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = this.LMODGJFCFNL.JGJEPKHCBGP - base.GPONHFNLHCN.PGKODNCDNJQ.x / 601f;
		}
		if (this.LMODGJFCFNL.IKDQPKGPPEH && MMLMNDPKIEC - base.GPONHFNLHCN.FOOEEHDJBQN().y / 861f < this.LMODGJFCFNL.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.BIPDHOPHDMK + base.GPONHFNLHCN.FOOEEHDJBQN().y / 905f;
		}
		else if (this.LMODGJFCFNL.PELBNKEHOHF && MMLMNDPKIEC + base.GPONHFNLHCN.PGKODNCDNJQ.y / 394f > this.LMODGJFCFNL.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = this.LMODGJFCFNL.MMHQFDMKQDQ - base.GPONHFNLHCN.FOOEEHDJBQN().y / 731f;
		}
	}

	// Token: 0x060076C7 RID: 30407 RVA: 0x0038BDFC File Offset: 0x00389FFC
	private IEnumerator QFICJEMMGCJ(LELCIPBNCCB ILLDIKBCNMC)
	{
		yield return new WaitForEndOfFrame();
		return 1;
		ILLDIKBCNMC.GKDDKEJOFBP = false;
		yield break;
	}

	// Token: 0x060076C8 RID: 30408 RVA: 0x0002AB8D File Offset: 0x00028D8D
	private void JEJIOPIIFLH()
	{
		if (this.LMODGJFCFNL.NFKPHODMHLK != null)
		{
			this.LMODGJFCFNL.NFKPHODMHLK();
		}
	}

	// Token: 0x060076CA RID: 30410 RVA: 0x0038C304 File Offset: 0x0038A504
	private void JHQCMGKJCCI()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (this.LMODGJFCFNL == null)
		{
			MDFGNNIKFEP mdfgnnikfep = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
			this.LMODGJFCFNL = ((!(mdfgnnikfep == null)) ? mdfgnnikfep : base.GPONHFNLHCN.gameObject.AddComponent<MDFGNNIKFEP>());
		}
		this.OLQHKGLLECQ = new PEDFEBKECPI(base.GPONHFNLHCN, this.LMODGJFCFNL);
		PEDFEBKECPI olqhkgllecq = this.OLQHKGLLECQ;
		olqhkgllecq.MQJKNKDJNKH = (Action)Delegate.Combine(olqhkgllecq.MQJKNKDJNKH, new Action(this.JEJIOPIIFLH));
		PEDFEBKECPI olqhkgllecq2 = this.OLQHKGLLECQ;
		olqhkgllecq2.MGEOIQMIIQK = (Action)Delegate.Combine(olqhkgllecq2.MGEOIQMIIQK, new Action(this.BMCLCFCNBKB));
		this.FFLPMOKLOCB();
		if (this.FIBJFOFKLFK())
		{
			this.LFHBDCEGLIM();
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 978f;
	}

	// Token: 0x060076CB RID: 30411 RVA: 0x0038C3F0 File Offset: 0x0038A5F0
	private void CIJOENOQKCI()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		if (this.LMODGJFCFNL == null)
		{
			MDFGNNIKFEP mdfgnnikfep = UnityEngine.Object.FindObjectOfType<MDFGNNIKFEP>();
			this.LMODGJFCFNL = ((!(mdfgnnikfep == null)) ? mdfgnnikfep : base.GPONHFNLHCN.gameObject.AddComponent<MDFGNNIKFEP>());
		}
		this.OLQHKGLLECQ = new PEDFEBKECPI(base.GPONHFNLHCN, this.LMODGJFCFNL);
		PEDFEBKECPI olqhkgllecq = this.OLQHKGLLECQ;
		olqhkgllecq.MQJKNKDJNKH = (Action)Delegate.Combine(olqhkgllecq.MQJKNKDJNKH, new Action(this.HIKHNHLPQNI));
		PEDFEBKECPI olqhkgllecq2 = this.OLQHKGLLECQ;
		olqhkgllecq2.MGEOIQMIIQK = (Action)Delegate.Combine(olqhkgllecq2.MGEOIQMIIQK, new Action(this.BMCLCFCNBKB));
		this.FFLPMOKLOCB();
		if (this.FIBJFOFKLFK())
		{
			this.LFHBDCEGLIM();
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1435f;
	}

	// Token: 0x060076CC RID: 30412 RVA: 0x0038C0B0 File Offset: 0x0038A2B0
	private IEnumerator FFKKNCPPHGK()
	{
		if (!this.PELBNKEHOHF && !this.IKDQPKGPPEH && !this.QBHHBPBKQDJ && !this.IGPBFPCKNOG)
		{
			this.LMODGJFCFNL.PELBNKEHOHF = false;
			this.LMODGJFCFNL.IKDQPKGPPEH = false;
			this.LMODGJFCFNL.QBHHBPBKQDJ = false;
			this.LMODGJFCFNL.IGPBFPCKNOG = false;
			yield break;
		}
		position = base.transform.position;
		num = ((!this.BMMJLPFNENL) ? this.MMHQFDMKQDQ : (position.y + this.MMHQFDMKQDQ));
		num2 = ((!this.BMMJLPFNENL) ? this.BIPDHOPHDMK : (position.y + this.BIPDHOPHDMK));
		num3 = ((!this.BMMJLPFNENL) ? this.DFFQECIDMDO : (position.x + this.DFFQECIDMDO));
		num4 = ((!this.BMMJLPFNENL) ? this.JGJEPKHCBGP : (position.x + this.JGJEPKHCBGP));
		flag = true;
		if (this.PELBNKEHOHF && (Mathf.Abs(this.LMODGJFCFNL.MMHQFDMKQDQ - num) > 0.01f || !this.LMODGJFCFNL.PELBNKEHOHF))
		{
			flag = false;
		}
		if (flag && this.IKDQPKGPPEH && (Mathf.Abs(this.LMODGJFCFNL.BIPDHOPHDMK - num2) > 0.01f || !this.LMODGJFCFNL.IKDQPKGPPEH))
		{
			flag = false;
		}
		if (flag && this.QBHHBPBKQDJ && (Mathf.Abs(this.LMODGJFCFNL.DFFQECIDMDO - num3) > 0.01f || !this.LMODGJFCFNL.QBHHBPBKQDJ))
		{
			flag = false;
		}
		if (flag && this.IGPBFPCKNOG && (Mathf.Abs(this.LMODGJFCFNL.JGJEPKHCBGP - num4) > 0.01f || !this.LMODGJFCFNL.IGPBFPCKNOG))
		{
			flag = false;
		}
		if (!flag)
		{
			this.FFLPMOKLOCB();
			this.OLQHKGLLECQ.PELBNKEHOHF = this.PELBNKEHOHF;
			this.OLQHKGLLECQ.MMHQFDMKQDQ = this.KCNQMDOKFFH;
			this.OLQHKGLLECQ.IKDQPKGPPEH = this.IKDQPKGPPEH;
			this.OLQHKGLLECQ.BIPDHOPHDMK = this.GGMEMPEGNML;
			this.OLQHKGLLECQ.QBHHBPBKQDJ = this.QBHHBPBKQDJ;
			this.OLQHKGLLECQ.DFFQECIDMDO = this.EEMEFDFICBK;
			this.OLQHKGLLECQ.IGPBFPCKNOG = this.IGPBFPCKNOG;
			this.OLQHKGLLECQ.JGJEPKHCBGP = this.DNHGBLNKIDM;
			this.OLQHKGLLECQ.GEDLQKQGGCH = this.GEDLQKQGGCH;
			this.OLQHKGLLECQ.FGELPQPIOJF = this.FGELPQPIOJF;
			if (this.CNHBCJEQEMO && this.LQHQFLHFQLO / this.IIQGQIKIOHG != base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f)
			{
				base.GPONHFNLHCN.LHCFKHKLLOL(this.LQHQFLHFQLO / this.IIQGQIKIOHG, this.CIJKPQCMOMK, this.FGELPQPIOJF);
			}
			if (this.OLQHKGLLECQ.LCLJBHQNMLE() > 1)
			{
				if (this.LMODGJFCFNL.JJLDKIHQJGG != null)
				{
					this.LMODGJFCFNL.StopCoroutine(this.LMODGJFCFNL.JJLDKIHQJGG);
				}
				this.LMODGJFCFNL.JJLDKIHQJGG = this.LMODGJFCFNL.StartCoroutine(this.GDMDCDPLPNP());
			}
			yield return new WaitForEndOfFrame();
			return 1;
		}
		yield break;
		this.OLQHKGLLECQ.FFKKNCPPHGK();
		yield break;
	}

	// Token: 0x060076CD RID: 30413 RVA: 0x0002AB41 File Offset: 0x00028D41
	protected virtual void FHPGLDNLOMQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.BOFHBQKBBFC(this);
		}
	}

	// Token: 0x060076CE RID: 30414 RVA: 0x0002AB85 File Offset: 0x00028D85
	public int PNEGOGOBMMO()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x040019B4 RID: 6580
	public static string KKBIKBIDQEB = "Boundaries Trigger";

	// Token: 0x040019B5 RID: 6581
	public MDFGNNIKFEP LMODGJFCFNL;

	// Token: 0x040019B6 RID: 6582
	public bool BMMJLPFNENL = true;

	// Token: 0x040019B7 RID: 6583
	public bool PELBNKEHOHF = true;

	// Token: 0x040019B8 RID: 6584
	public float MMHQFDMKQDQ = 10f;

	// Token: 0x040019B9 RID: 6585
	public bool IKDQPKGPPEH = true;

	// Token: 0x040019BA RID: 6586
	public float BIPDHOPHDMK = -10f;

	// Token: 0x040019BB RID: 6587
	public bool QBHHBPBKQDJ = true;

	// Token: 0x040019BC RID: 6588
	public float DFFQECIDMDO = -10f;

	// Token: 0x040019BD RID: 6589
	public bool IGPBFPCKNOG = true;

	// Token: 0x040019BE RID: 6590
	public float JGJEPKHCBGP = 10f;

	// Token: 0x040019BF RID: 6591
	public float GEDLQKQGGCH = 1f;

	// Token: 0x040019C0 RID: 6592
	public GMNJJQQPEDB FGELPQPIOJF;

	// Token: 0x040019C1 RID: 6593
	public bool CNHBCJEQEMO;

	// Token: 0x040019C2 RID: 6594
	public float IIQGQIKIOHG = 1.5f;

	// Token: 0x040019C3 RID: 6595
	public float CIJKPQCMOMK = 1f;

	// Token: 0x040019C4 RID: 6596
	public bool JNBGPEQPGGH;

	// Token: 0x040019C5 RID: 6597
	private float LQHQFLHFQLO;

	// Token: 0x040019C6 RID: 6598
	private PEDFEBKECPI OLQHKGLLECQ;

	// Token: 0x040019C7 RID: 6599
	private float KCNQMDOKFFH;

	// Token: 0x040019C8 RID: 6600
	private float GGMEMPEGNML;

	// Token: 0x040019C9 RID: 6601
	private float EEMEFDFICBK;

	// Token: 0x040019CA RID: 6602
	private float DNHGBLNKIDM;

	// Token: 0x040019CB RID: 6603
	private bool GKDDKEJOFBP;

	// Token: 0x040019CC RID: 6604
	private Vector3 NHCKFQMGIJD;

	// Token: 0x040019CD RID: 6605
	private int HNMJQQFFBCL = 1000;
}
