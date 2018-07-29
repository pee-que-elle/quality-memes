using System;
using UnityEngine;

// Token: 0x02000081 RID: 129
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Slider")]
public class HLEKPGPJOOK : BJQGLGOLMPQ
{
	// Token: 0x0600111C RID: 4380 RVA: 0x00009997 File Offset: 0x00007B97
	public void FCGKBNHKJMQ(float BGBMIEJJQKC)
	{
		base.GIPBBFDPCKG(BGBMIEJJQKC);
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x000820BC File Offset: 0x000802BC
	protected void JHCFQBHLNNQ(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)8)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.HKDJGHOHBFQ() - base.FQOIFJQGEIN(EMENMKHBPQE.OBLGQQHNDII)) : 1776f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00082124 File Offset: 0x00080324
	protected virtual void ICEQNEJCGOQ()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.QMJKDCINICP(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.MKKHOLOIKNB));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.ONIKGNBIEHP));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.NJLOHQMOHIB(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.GLPDJCLFFHF));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.PMOBCPEGIHP));
		}
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00082278 File Offset: 0x00080478
	protected virtual void NDCEDEHKMIM()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.BMNPKIBKFJD));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.NMGPFIBCOQH));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.NJLOHQMOHIB(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.HNQQCQIJFJB));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.ONLHJHDFIJP));
		}
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002300 File Offset: 0x00000500
	public void FCJBIOPHDJH(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x0007097C File Offset: 0x0006EB7C
	public bool FNBKHFDMQPI()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x000823CC File Offset: 0x000805CC
	protected void HNQQCQIJFJB(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.HKDJGHOHBFQ() - base.DQMEFFMNQPJ(EMENMKHBPQE.OBLGQQHNDII)) : 395f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00009E1D File Offset: 0x0000801D
	protected void PPDKNMMFIEJ(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII);
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00009E5A File Offset: 0x0000805A
	protected void OFKNLCFGHLQ(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)6)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.GIPBBFDPCKG(base.FQOIFJQGEIN(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x0007097C File Offset: 0x0006EB7C
	public bool BOCCCJPOOLG()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00009E81 File Offset: 0x00008081
	public bool DLMGINFIDPL()
	{
		return base.HCODIHFPMKG();
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x0000997D File Offset: 0x00007B7D
	public float NKQOQKJDDDP()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00082434 File Offset: 0x00080634
	protected void BLLDJPCIOLM(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.HKDJGHOHBFQ() - base.EOHHNOOCOLJ(EMENMKHBPQE.GDLFOFEJOPK())) : 1611f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002300 File Offset: 0x00000500
	public void MJNONGLQKFM(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x0008249C File Offset: 0x0008069C
	protected virtual void DICJNPGHMHI()
	{
		if (this.direction != HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : ((BJQGLGOLMPQ.CGLEFJOIIND)7));
			}
			this.direction = (HLEKPGPJOOK.IQMGIPNJMPE)7;
		}
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00009E89 File Offset: 0x00008089
	protected void ONFDGNIHHBK(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(base.LGBCIHNJCBF(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00009975 File Offset: 0x00007B75
	public float GMMNBFJOPII()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x0007097C File Offset: 0x0006EB7C
	public bool EHIPJOEMBIH()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002300 File Offset: 0x00000500
	public void HMECJCOKLLF(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00009EC6 File Offset: 0x000080C6
	protected void BMNPKIBKFJD(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(base.DQMEFFMNQPJ(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00082514 File Offset: 0x00080714
	protected void KBFFHOLEMFN(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.BGBMIEJJQKC - base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII)) : 0f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00009F03 File Offset: 0x00008103
	public virtual void IEMOHPDBQMQ(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled && this.EHIPJOEMBIH())
		{
			base.NEQLNOKMEKM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00009F1C File Offset: 0x0000811C
	protected void QMEPOFGFNPQ(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.GIPBBFDPCKG(base.LGBCIHNJCBF(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00009F59 File Offset: 0x00008159
	protected void MKKHOLOIKNB(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.GIPBBFDPCKG(base.EMDNKIONKLN(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00009F96 File Offset: 0x00008196
	protected void KEQHJCFOBFD(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = base.LGBCIHNJCBF(EMENMKHBPQE.GDLFOFEJOPK());
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06001148 RID: 4424 RVA: 0x00009975 File Offset: 0x00007B75
	// (set) Token: 0x06001135 RID: 4405 RVA: 0x00009985 File Offset: 0x00007B85
	[Obsolete("Use 'value' instead")]
	public float JHLEEHKDOEN
	{
		get
		{
			return base.BGBMIEJJQKC;
		}
		set
		{
			base.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x0008257C File Offset: 0x0008077C
	protected virtual void GLCJQBKMHEE()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.DCMFQKFFBIQ(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.PPDKNMMFIEJ));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.HFIILIONPPF));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.QMJKDCINICP(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.HNQQCQIJFJB));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.EFKLBIOBPCD));
		}
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00009FD3 File Offset: 0x000081D3
	protected void FIEFGKHIDHK(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.GIPBBFDPCKG(this.ECCFHDNFOGB + base.FQOIFJQGEIN(EMENMKHBPQE.OBLGQQHNDII));
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002300 File Offset: 0x00000500
	public void PKBKIDBGFKJ(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x000826D0 File Offset: 0x000808D0
	protected virtual void OMGNHQDNDPJ()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.QMJKDCINICP(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.QMEPOFGFNPQ));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.GOQGECLCBOG));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.INJNQNMOKKD(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.HNQQCQIJFJB));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.EFKLBIOBPCD));
		}
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x0000A01B File Offset: 0x0000821B
	public virtual void DMOIHJBHGPL(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled && this.FNBKHFDMQPI())
		{
			base.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00082824 File Offset: 0x00080A24
	protected override void LJMLKQGKQMN()
	{
		if (this.direction != HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : ((BJQGLGOLMPQ.CGLEFJOIIND)6));
			}
			this.direction = (HLEKPGPJOOK.IQMGIPNJMPE)4;
		}
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00009975 File Offset: 0x00007B75
	public float BGCICLPHQEK()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00009975 File Offset: 0x00007B75
	public float OIJJPNHEDLI()
	{
		return base.BGBMIEJJQKC;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x0000A034 File Offset: 0x00008234
	protected void KIJMJHIPIDQ(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.GIPBBFDPCKG(base.EOHHNOOCOLJ(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x0008289C File Offset: 0x00080A9C
	protected virtual void LQQQKKKDKIM()
	{
		if (this.direction != (HLEKPGPJOOK.IQMGIPNJMPE)7)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)5) : ((BJQGLGOLMPQ.CGLEFJOIIND)7));
			}
			this.direction = (HLEKPGPJOOK.IQMGIPNJMPE)5;
		}
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00082914 File Offset: 0x00080B14
	protected virtual void IINCDBGQHMD()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.DBFPBKPPBPI));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.KIJMJHIPIDQ));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.DCMFQKFFBIQ(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.KKKLKEQOKDO));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.PMOBCPEGIHP));
		}
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x0000A05B File Offset: 0x0000825B
	public virtual void IGNPDMFBNKC(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled && this.FNBKHFDMQPI())
		{
			base.JBQCQHMNCHG(JDOGIQGGLKM);
		}
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x0000A074 File Offset: 0x00008274
	protected void GOQGECLCBOG(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)4)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.PLLQOHPCBOP(base.EMDNKIONKLN(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00009E89 File Offset: 0x00008089
	protected void NMKLCPIBNIJ(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(base.LGBCIHNJCBF(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00082A68 File Offset: 0x00080C68
	protected virtual void OHJOMEPHDJG()
	{
		if (this.direction != (HLEKPGPJOOK.IQMGIPNJMPE)5)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)5) : ((BJQGLGOLMPQ.CGLEFJOIIND)7));
			}
			this.direction = HLEKPGPJOOK.IQMGIPNJMPE.Upgraded;
		}
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x0000A09B File Offset: 0x0000829B
	protected void MMCPIHJHIII(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)3)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(this.ECCFHDNFOGB + base.EOHHNOOCOLJ(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00082AE0 File Offset: 0x00080CE0
	protected override void PJGIJLDLIFJ()
	{
		if (this.direction != HLEKPGPJOOK.IQMGIPNJMPE.Upgraded)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.BottomToTop : BJQGLGOLMPQ.CGLEFJOIIND.TopToBottom);
			}
			this.direction = HLEKPGPJOOK.IQMGIPNJMPE.Upgraded;
		}
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002300 File Offset: 0x00000500
	public void PHEHEDCJQIC(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x0007097C File Offset: 0x0006EB7C
	public bool BGDCFCHHOOL()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return !(component2 != null) || component2.enabled;
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00082B58 File Offset: 0x00080D58
	protected virtual void JFDBCKIJLHE()
	{
		if (this.direction != (HLEKPGPJOOK.IQMGIPNJMPE)3)
		{
			this.mValue = this.rawValue;
			if (this.foreground != null)
			{
				this.mFG = this.foreground.GetComponent<ENFMCDNLEQQ>();
			}
			if (this.direction == HLEKPGPJOOK.IQMGIPNJMPE.Horizontal)
			{
				this.mFill = ((!this.mInverted) ? BJQGLGOLMPQ.CGLEFJOIIND.LeftToRight : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			else
			{
				this.mFill = ((!this.mInverted) ? ((BJQGLGOLMPQ.CGLEFJOIIND)6) : BJQGLGOLMPQ.CGLEFJOIIND.RightToLeft);
			}
			this.direction = (HLEKPGPJOOK.IQMGIPNJMPE)4;
		}
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00082BD0 File Offset: 0x00080DD0
	protected virtual void KBMBPLJDCMC()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.NMKLCPIBNIJ));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.NMGPFIBCOQH));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.INJNQNMOKKD(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.MMCPIHJHIII));
		}
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002300 File Offset: 0x00000500
	public void QHLNMDDMJHK(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002300 File Offset: 0x00000500
	public void QFLPOPILQBB(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00070898 File Offset: 0x0006EA98
	public bool CLPDOPKEGII()
	{
		Collider component = base.GetComponent<Collider>();
		if (component != null)
		{
			return component.enabled;
		}
		Collider2D component2 = base.GetComponent<Collider2D>();
		return component2 != null && component2.enabled;
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x0000A0C9 File Offset: 0x000082C9
	protected void QJPHMEPDHMN(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII);
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002300 File Offset: 0x00000500
	public void JBLOKJNFBCJ(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x00082D24 File Offset: 0x00080F24
	protected override void NHONJJHBBEN()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.PPDKNMMFIEJ));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.QJPHMEPDHMN));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.INJNQNMOKKD(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.KBFFHOLEMFN));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.ONLHJHDFIJP));
		}
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x00009E81 File Offset: 0x00008081
	public bool MCPJCGHKLPN()
	{
		return base.HCODIHFPMKG();
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06001154 RID: 4436 RVA: 0x0000A0F0 File Offset: 0x000082F0
	// (set) Token: 0x0600115F RID: 4447 RVA: 0x00002300 File Offset: 0x00000500
	[Obsolete("Use 'fillDirection' instead")]
	public bool INIFQEKPMLD
	{
		get
		{
			return base.IGJHCJQEOLN;
		}
		set
		{
		}
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00082E78 File Offset: 0x00081078
	protected void GLPDJCLFFHF(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.HKDJGHOHBFQ() - base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII)) : 1624f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06001156 RID: 4438 RVA: 0x00070898 File Offset: 0x0006EA98
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

	// Token: 0x06001157 RID: 4439 RVA: 0x0000A0F8 File Offset: 0x000082F8
	protected void ONLHJHDFIJP(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = this.ECCFHDNFOGB + base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII);
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x0000A126 File Offset: 0x00008326
	protected void PMOBCPEGIHP(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(this.ECCFHDNFOGB + base.EMDNKIONKLN(EMENMKHBPQE.OBLGQQHNDII));
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00082EE0 File Offset: 0x000810E0
	protected void KKKLKEQOKDO(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)3)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		if (FJOEKDCLKIO)
		{
			this.ECCFHDNFOGB = ((!(this.mFG == null)) ? (base.HKDJGHOHBFQ() - base.EMDNKIONKLN(EMENMKHBPQE.OBLGQQHNDII)) : 713f);
		}
		else if (this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x0000A154 File Offset: 0x00008354
	public virtual void BDDMDGCLJII(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled && this.OMJBJEKCLMM)
		{
			base.NEQLNOKMEKM(JDOGIQGGLKM);
		}
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00009E81 File Offset: 0x00008081
	public bool KQKBHFOJLHK()
	{
		return base.HCODIHFPMKG();
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x0000A16D File Offset: 0x0000836D
	protected void ONIKGNBIEHP(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.PLLQOHPCBOP(base.EMDNKIONKLN(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x0000A194 File Offset: 0x00008394
	protected void NMGPFIBCOQH(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = base.FQOIFJQGEIN(EMENMKHBPQE.OBLGQQHNDII);
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00009985 File Offset: 0x00007B85
	public void OMHMHDCDIGI(float BGBMIEJJQKC)
	{
		base.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0000A1BB File Offset: 0x000083BB
	protected void EHBQNCONMLF(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)5)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(base.NKJQMGHFLPG(EMENMKHBPQE.OBLGQQHNDII));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x0000A1F8 File Offset: 0x000083F8
	public override void DFBDPGOJHHM(Vector2 JDOGIQGGLKM)
	{
		if (base.enabled && this.OMJBJEKCLMM)
		{
			base.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x0000A211 File Offset: 0x00008411
	protected void HFIILIONPPF(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)4)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.PLLQOHPCBOP(base.NKJQMGHFLPG(EMENMKHBPQE.GDLFOFEJOPK()));
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x00082F48 File Offset: 0x00081148
	protected virtual void KKGINFDMEJF()
	{
		GameObject cghienbihco = (!(this.mBG != null) || (!(this.mBG.GetComponent<Collider>() != null) && !(this.mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : this.mBG.gameObject;
		HDLEIMONFCK hdleimonfck = HDLEIMONFCK.INJNQNMOKKD(cghienbihco);
		HDLEIMONFCK hdleimonfck2 = hdleimonfck;
		hdleimonfck2.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck2.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.KEQHJCFOBFD));
		HDLEIMONFCK hdleimonfck3 = hdleimonfck;
		hdleimonfck3.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck3.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.HFIILIONPPF));
		if (this.BNELEGPJDGK != null && (this.BNELEGPJDGK.GetComponent<Collider>() != null || this.BNELEGPJDGK.GetComponent<Collider2D>() != null) && (this.mFG == null || this.BNELEGPJDGK != this.mFG.CGDFDPHIENG))
		{
			HDLEIMONFCK hdleimonfck4 = HDLEIMONFCK.INJNQNMOKKD(this.BNELEGPJDGK.gameObject);
			HDLEIMONFCK hdleimonfck5 = hdleimonfck4;
			hdleimonfck5.QQBJNCGGPID = (HDLEIMONFCK.DHKOBKLJHFG)Delegate.Combine(hdleimonfck5.QQBJNCGGPID, new HDLEIMONFCK.DHKOBKLJHFG(this.JHCFQBHLNNQ));
			HDLEIMONFCK hdleimonfck6 = hdleimonfck4;
			hdleimonfck6.MMEICCPDLHG = (HDLEIMONFCK.BPOELKODCPD)Delegate.Combine(hdleimonfck6.MMEICCPDLHG, new HDLEIMONFCK.BPOELKODCPD(this.EFKLBIOBPCD));
		}
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x0000997D File Offset: 0x00007B7D
	public float DOCDJNHPHFQ()
	{
		return base.HKDJGHOHBFQ();
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x0000A238 File Offset: 0x00008438
	protected void DBFPBKPPBPI(GameObject CGHIENBIHCO, bool FJOEKDCLKIO)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)7)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.FONJFPIKGEP(base.EMDNKIONKLN(EMENMKHBPQE.GDLFOFEJOPK()));
		if (!FJOEKDCLKIO && this.QEEHHLPOHGI != null)
		{
			this.QEEHHLPOHGI();
		}
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x0000A275 File Offset: 0x00008475
	protected void EFKLBIOBPCD(GameObject CGHIENBIHCO, Vector2 JDOGIQGGLKM)
	{
		if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			return;
		}
		this.OJIDBLEKBBO = EMENMKHBPQE.EBNOGGPBLNC;
		base.BGBMIEJJQKC = this.ECCFHDNFOGB + base.FQOIFJQGEIN(EMENMKHBPQE.OBLGQQHNDII);
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x00002300 File Offset: 0x00000500
	public void PHKQQJDIGJF(bool BGBMIEJJQKC)
	{
	}

	// Token: 0x0400031C RID: 796
	[SerializeField]
	[HideInInspector]
	private Transform foreground;

	// Token: 0x0400031D RID: 797
	[HideInInspector]
	[SerializeField]
	private float rawValue = 1f;

	// Token: 0x0400031E RID: 798
	[HideInInspector]
	[SerializeField]
	private HLEKPGPJOOK.IQMGIPNJMPE direction = HLEKPGPJOOK.IQMGIPNJMPE.Upgraded;

	// Token: 0x0400031F RID: 799
	[SerializeField]
	[HideInInspector]
	protected bool mInverted;

	// Token: 0x02000082 RID: 130
	private enum IQMGIPNJMPE
	{
		// Token: 0x04000321 RID: 801
		Horizontal,
		// Token: 0x04000322 RID: 802
		Vertical,
		// Token: 0x04000323 RID: 803
		Upgraded
	}
}
