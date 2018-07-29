using System;
using UnityEngine;

// Token: 0x02000377 RID: 887
[HelpURL("http://www.procamera2d.com/user-guide/extension-zoom-to-fit/")]
public class MEMQLOLDBQL : BNEFIOCKQOE, NLQPOLOJJQE
{
	// Token: 0x060075FE RID: 30206 RVA: 0x003895DC File Offset: 0x003877DC
	public override void NGNDCOPDNPH()
	{
		this.BFDQKNMIIKD = 0f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.GFQDCHOQHGP.y * 0.5f;
		this.PIMQQKEQCCK = this.BHHDKFGKGKG;
		this.DDINHLIJQMJ = this.BHHDKFGKGKG;
	}

	// Token: 0x060075FF RID: 30207 RVA: 0x0002A80B File Offset: 0x00028A0B
	public void OGEJHEFGIGL(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007600 RID: 30208 RVA: 0x0038962C File Offset: 0x0038782C
	public float QNIOLBNGKBG(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 600f;
		if (this.GNNMIEOKHFC && base.GPONHFNLHCN.DBLIJKDNBLI.Count <= 0)
		{
			this.PIMQQKEQCCK = base.GPONHFNLHCN.GFQDCHOQHGP.y * 934f;
		}
		else
		{
			if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
			{
				this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1966f;
				this.DDINHLIJQMJ = this.PIMQQKEQCCK;
				this.BFDQKNMIIKD = 504f;
			}
			this.EHFDJONDCNB();
		}
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, (this.PIMQQKEQCCK >= this.DDINHLIJQMJ) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ, 518f, GPFIDEJEMEG);
	}

	// Token: 0x06007603 RID: 30211 RVA: 0x003897B0 File Offset: 0x003879B0
	public virtual void DCLQJFLFHHF()
	{
		this.BFDQKNMIIKD = 818f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.LPEMLNLJNME().y * 1407f;
		this.PIMQQKEQCCK = this.BHHDKFGKGKG;
		this.DDINHLIJQMJ = this.BHHDKFGKGKG;
	}

	// Token: 0x06007604 RID: 30212 RVA: 0x0002A820 File Offset: 0x00028A20
	protected virtual void GIBCBGBKIGQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x06007605 RID: 30213 RVA: 0x00389800 File Offset: 0x00387A00
	private void EHFDJONDCNB()
	{
		float num = float.NegativeInfinity;
		float num2 = float.PositiveInfinity;
		float num3 = float.NegativeInfinity;
		float num4 = float.PositiveInfinity;
		for (int i = 0; i < base.GPONHFNLHCN.DBLIJKDNBLI.Count; i++)
		{
			Vector2 vector = new Vector2(this.FKGNBCKJPQO(base.GPONHFNLHCN.DBLIJKDNBLI[i].TargetPosition) + base.GPONHFNLHCN.DBLIJKDNBLI[i].TargetOffset.x, this.JNBBJCLFFBB(base.GPONHFNLHCN.DBLIJKDNBLI[i].TargetPosition) + base.GPONHFNLHCN.DBLIJKDNBLI[i].TargetOffset.y);
			num = ((vector.x <= num) ? num : vector.x);
			num2 = ((vector.x >= num2) ? num2 : vector.x);
			num3 = ((vector.y <= num3) ? num3 : vector.y);
			num4 = ((vector.y >= num4) ? num4 : vector.y);
		}
		float num5 = Mathf.Abs(num - num2);
		float num6 = Mathf.Abs(num3 - num4);
		if (this.PLOOICMMQEH)
		{
			num5 += Mathf.Abs(this.FKGNBCKJPQO(base.GPONHFNLHCN.HGNEKQHNFCC) - this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) * 2f;
			num6 += Mathf.Abs(this.JNBBJCLFFBB(base.GPONHFNLHCN.HGNEKQHNFCC) - this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) * 2f;
		}
		num5 *= 0.5f;
		num6 *= 0.5f;
		if (num5 <= base.GPONHFNLHCN.PGKODNCDNJQ.x * this.JFPQQJCGHKO * 0.5f && num6 <= base.GPONHFNLHCN.PGKODNCDNJQ.y * this.JFPQQJCGHKO * 0.5f)
		{
			if (num5 < base.GPONHFNLHCN.PGKODNCDNJQ.x * this.FHFLCODHIEE * 0.5f && num6 < base.GPONHFNLHCN.PGKODNCDNJQ.y * this.FHFLCODHIEE * 0.5f)
			{
				if (num5 / base.GPONHFNLHCN.PGKODNCDNJQ.x >= num6 / base.GPONHFNLHCN.PGKODNCDNJQ.y)
				{
					this.PIMQQKEQCCK = num5 / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / this.FHFLCODHIEE;
				}
				else
				{
					this.PIMQQKEQCCK = num6 / this.FHFLCODHIEE;
				}
			}
		}
		else if (num5 / base.GPONHFNLHCN.PGKODNCDNJQ.x >= num6 / base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.PIMQQKEQCCK = num5 / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / this.JFPQQJCGHKO;
		}
		else
		{
			this.PIMQQKEQCCK = num6 / this.JFPQQJCGHKO;
		}
		this.CGGKBOMFNEI = base.GPONHFNLHCN.GFQDCHOQHGP.y * 0.5f / this.GELCLJPKPPB;
		this.ENCECHNPPJD = base.GPONHFNLHCN.GFQDCHOQHGP.y * 0.5f * this.OPJQBGHMFPN;
		this.PIMQQKEQCCK = Mathf.Clamp(this.PIMQQKEQCCK, this.CGGKBOMFNEI, this.ENCECHNPPJD);
	}

	// Token: 0x06007606 RID: 30214 RVA: 0x00389B9C File Offset: 0x00387D9C
	protected virtual void MEOLPIBOBHB()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.LPEMLNLJNME().y * 1007f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007607 RID: 30215 RVA: 0x0002A834 File Offset: 0x00028A34
	protected virtual void CGELNINGDBE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06007609 RID: 30217 RVA: 0x0002A848 File Offset: 0x00028A48
	// (set) Token: 0x06007608 RID: 30216 RVA: 0x0002A80B File Offset: 0x00028A0B
	public int OOKGEICHBQO
	{
		get
		{
			return this.GKLLDJLQPMM;
		}
		set
		{
			this.GKLLDJLQPMM = value;
		}
	}

	// Token: 0x0600760A RID: 30218 RVA: 0x00389BF8 File Offset: 0x00387DF8
	public float LCHPMFFIFLL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		if (this.GNNMIEOKHFC && base.GPONHFNLHCN.DBLIJKDNBLI.Count <= 1)
		{
			this.PIMQQKEQCCK = base.GPONHFNLHCN.GFQDCHOQHGP.y * 0.5f;
		}
		else
		{
			if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
			{
				this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
				this.DDINHLIJQMJ = this.PIMQQKEQCCK;
				this.BFDQKNMIIKD = 0f;
			}
			this.EHFDJONDCNB();
		}
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, (this.PIMQQKEQCCK >= this.DDINHLIJQMJ) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ, float.MaxValue, GPFIDEJEMEG);
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x0002A834 File Offset: 0x00028A34
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x00389D20 File Offset: 0x00387F20
	public virtual void GDNONGFLGBN()
	{
		this.BFDQKNMIIKD = 1451f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.GFQDCHOQHGP.y * 1768f;
		this.PIMQQKEQCCK = this.BHHDKFGKGKG;
		this.DDINHLIJQMJ = this.BHHDKFGKGKG;
	}

	// Token: 0x0600760D RID: 30221 RVA: 0x00389D70 File Offset: 0x00387F70
	protected override void Awake()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.GFQDCHOQHGP.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x0600760E RID: 30222 RVA: 0x0002A820 File Offset: 0x00028A20
	protected virtual void BHJIKJLLIQQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x0600760F RID: 30223 RVA: 0x00389DCC File Offset: 0x00387FCC
	public float OPQBCQPOHPP(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1002f;
		if (this.GNNMIEOKHFC && base.GPONHFNLHCN.DBLIJKDNBLI.Count <= 1)
		{
			this.PIMQQKEQCCK = base.GPONHFNLHCN.GFQDCHOQHGP.y * 1150f;
		}
		else
		{
			if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
			{
				this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 731f;
				this.DDINHLIJQMJ = this.PIMQQKEQCCK;
				this.BFDQKNMIIKD = 339f;
			}
			this.EHFDJONDCNB();
		}
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, (this.PIMQQKEQCCK >= this.DDINHLIJQMJ) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ, 234f, GPFIDEJEMEG);
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x00389EF4 File Offset: 0x003880F4
	public virtual void ELELJEPJFCL()
	{
		this.BFDQKNMIIKD = 691f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.LPEMLNLJNME().y * 589f;
		this.PIMQQKEQCCK = this.BHHDKFGKGKG;
		this.DDINHLIJQMJ = this.BHHDKFGKGKG;
	}

	// Token: 0x06007611 RID: 30225 RVA: 0x00389F44 File Offset: 0x00388144
	public virtual void FMBEDKEPHDH()
	{
		this.BFDQKNMIIKD = 1833f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.LPEMLNLJNME().y * 1843f;
		this.PIMQQKEQCCK = this.BHHDKFGKGKG;
		this.DDINHLIJQMJ = this.BHHDKFGKGKG;
	}

	// Token: 0x06007612 RID: 30226 RVA: 0x00389F94 File Offset: 0x00388194
	protected virtual void LQGMIJIJPCM()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.LPEMLNLJNME().y * 1702f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007613 RID: 30227 RVA: 0x00389FF0 File Offset: 0x003881F0
	protected virtual void LEJQMIECFCH()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.GFQDCHOQHGP.y * 86f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x0400198B RID: 6539
	public static string OPGNGFNJDDP = "Zoom To Fit";

	// Token: 0x0400198C RID: 6540
	public float JFPQQJCGHKO = 0.6f;

	// Token: 0x0400198D RID: 6541
	public float FHFLCODHIEE = 0.4f;

	// Token: 0x0400198E RID: 6542
	public float PIHLKIFBFNJ = 2f;

	// Token: 0x0400198F RID: 6543
	public float OMKJQQEBGJH = 1f;

	// Token: 0x04001990 RID: 6544
	public float GELCLJPKPPB = 2f;

	// Token: 0x04001991 RID: 6545
	public float OPJQBGHMFPN = 4f;

	// Token: 0x04001992 RID: 6546
	public bool GNNMIEOKHFC = true;

	// Token: 0x04001993 RID: 6547
	public bool PLOOICMMQEH;

	// Token: 0x04001994 RID: 6548
	private float BFDQKNMIIKD;

	// Token: 0x04001995 RID: 6549
	private float BHHDKFGKGKG;

	// Token: 0x04001996 RID: 6550
	private float PIMQQKEQCCK;

	// Token: 0x04001997 RID: 6551
	private float DDINHLIJQMJ;

	// Token: 0x04001998 RID: 6552
	private float CGGKBOMFNEI;

	// Token: 0x04001999 RID: 6553
	private float ENCECHNPPJD;

	// Token: 0x0400199A RID: 6554
	private int GKLLDJLQPMM;
}
