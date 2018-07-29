using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000387 RID: 903
[HelpURL("http://www.procamera2d.com/user-guide/trigger-zoom/")]
public class GDNKQBHJHCP : JKQPIHPQDHQ
{
	// Token: 0x060077DC RID: 30684 RVA: 0x00398A00 File Offset: 0x00396C00
	protected void LHCFKHKLLOL(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, float.MaxValue, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 0f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x060077DD RID: 30685 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator NNMGOBBEMQP()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				Vector2 nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				float num = base.OMFMKLNPGPP(nknellkpmeb);
				float num2;
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				float num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077DE RID: 30686 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator LBJLOEQLQPI()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077DF RID: 30687 RVA: 0x00398A8C File Offset: 0x00396C8C
	protected virtual void HDBKLPCNDDJ()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1573f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 551f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1707f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.KENLHNFIKJP());
	}

	// Token: 0x060077E0 RID: 30688 RVA: 0x0002B0B5 File Offset: 0x000292B5
	protected override void FPFNBIDJHKM()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.FCMGPFIHJJP());
		}
	}

	// Token: 0x060077E1 RID: 30689 RVA: 0x00398B48 File Offset: 0x00396D48
	protected virtual void DBHJOKFQJJP()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1645f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 24f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 436f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.ONLMFFNPGCP());
	}

	// Token: 0x060077E2 RID: 30690 RVA: 0x00398C04 File Offset: 0x00396E04
	protected virtual void GPQMNFEPHKM()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1654f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 758f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 937f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.KQIGJQGIDQH());
	}

	// Token: 0x060077E3 RID: 30691 RVA: 0x00398CC0 File Offset: 0x00396EC0
	protected override void DOJBNQQEFBE()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.NNMGOBBEMQP());
	}

	// Token: 0x060077E4 RID: 30692 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator BMFEBGBBNGD()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077E5 RID: 30693 RVA: 0x00398D7C File Offset: 0x00396F7C
	private void HBOFMLLODDM()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.FOOEEHDJBQN().y * 757f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x060077E6 RID: 30694 RVA: 0x0002B0DE File Offset: 0x000292DE
	protected virtual void ILLLEBQOENP()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.GDEKBBPNEDL());
		}
	}

	// Token: 0x060077E7 RID: 30695 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator KQIGJQGIDQH()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077E8 RID: 30696 RVA: 0x00398DF8 File Offset: 0x00396FF8
	private void EDMGBEBGFPD()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.FOOEEHDJBQN().y * 71f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x060077E9 RID: 30697 RVA: 0x00398E74 File Offset: 0x00397074
	protected virtual void PJJQQJFCQFQ()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 840f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1883f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 569f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.JGCDIGEMHGK());
	}

	// Token: 0x060077EA RID: 30698 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator MCJQGPIINQE()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077EB RID: 30699 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator DODHDFHOLFL()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077EC RID: 30700 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator EDQONGCJCGE()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077ED RID: 30701 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator ONLMFFNPGCP()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077EE RID: 30702 RVA: 0x00398F30 File Offset: 0x00397130
	protected void BCJJKFCGDMD(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 676f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.PHJJELLGJOO(this.DDINHLIJQMJ, 1848f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x060077EF RID: 30703 RVA: 0x00398F84 File Offset: 0x00397184
	protected virtual void NNIKPNNLEOM()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1458f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 779f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 345f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.ONLMFFNPGCP());
	}

	// Token: 0x060077F0 RID: 30704 RVA: 0x00399040 File Offset: 0x00397240
	private void BCGQQOFCMQJ()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.FOOEEHDJBQN().y * 955f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x060077F1 RID: 30705 RVA: 0x003990BC File Offset: 0x003972BC
	private void OOIJPOCHQEJ()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 690f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x060077F2 RID: 30706 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator OPGFCCOLFJF()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077F3 RID: 30707 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator JEGEQHNGIKI()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077F4 RID: 30708 RVA: 0x00399138 File Offset: 0x00397338
	protected void QJFCGCCPQDE(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1154f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 1092f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x060077F5 RID: 30709 RVA: 0x0039918C File Offset: 0x0039738C
	protected virtual void JDHPKJCBFLH()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 626f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 916f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1520f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.ONLMFFNPGCP());
	}

	// Token: 0x060077F6 RID: 30710 RVA: 0x00399248 File Offset: 0x00397448
	protected void HCMMBLPCKBG(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 63f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.PHJJELLGJOO(this.DDINHLIJQMJ, 753f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x060077F7 RID: 30711 RVA: 0x0002B107 File Offset: 0x00029307
	protected virtual void EICJIIKBNCG()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.CNNHIJKKCCK());
		}
	}

	// Token: 0x060077F8 RID: 30712 RVA: 0x0039929C File Offset: 0x0039749C
	private void BNGFCDCELHL()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1886f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x060077F9 RID: 30713 RVA: 0x0002B130 File Offset: 0x00029330
	protected virtual void PLQHNKPINIE()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.LBJLOEQLQPI());
		}
	}

	// Token: 0x060077FA RID: 30714 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator QOGCQOEOJKJ()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077FB RID: 30715 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator QLQKCEGBLGF()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x060077FC RID: 30716 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator KENLHNFIKJP()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x060077FD RID: 30717 RVA: 0x0002B159 File Offset: 0x00029359
	protected virtual void KNEDFGMINGK()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.IFLBDCHIQMI());
		}
	}

	// Token: 0x060077FE RID: 30718 RVA: 0x00399318 File Offset: 0x00397518
	protected void ONEOHDHCFLE(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1370f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 1546f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x060077FF RID: 30719 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator JGCDIGEMHGK()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x06007800 RID: 30720 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator GHBDBOPMIDI()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007801 RID: 30721 RVA: 0x0039936C File Offset: 0x0039756C
	protected virtual void FHNNBPFCDKG()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 497f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 243f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 689f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.JGCDIGEMHGK());
	}

	// Token: 0x06007802 RID: 30722 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator IFLBDCHIQMI()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007803 RID: 30723 RVA: 0x00399428 File Offset: 0x00397628
	protected virtual void LGMNNDCOBEE()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1434f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 227f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 187f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.KENLHNFIKJP());
	}

	// Token: 0x06007804 RID: 30724 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator HEJCPFMJDGH()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007805 RID: 30725 RVA: 0x003994E4 File Offset: 0x003976E4
	private void DGMPMICDCIO()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1396f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x06007806 RID: 30726 RVA: 0x00399560 File Offset: 0x00397760
	protected void FQFQECIQQEC(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1951f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 60f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x06007807 RID: 30727 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator GDEKBBPNEDL()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007808 RID: 30728 RVA: 0x0002B182 File Offset: 0x00029382
	protected virtual void EPQJEDCCPJD()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.DODHDFHOLFL());
		}
	}

	// Token: 0x06007809 RID: 30729 RVA: 0x003995B4 File Offset: 0x003977B4
	protected void HNNEJGMCIOD(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1012f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.PHJJELLGJOO(this.DDINHLIJQMJ, 491f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x0600780A RID: 30730 RVA: 0x00399608 File Offset: 0x00397808
	private void BBGHCDGEDEJ()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.FOOEEHDJBQN().y * 412f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x0600780B RID: 30731 RVA: 0x00399684 File Offset: 0x00397884
	protected void QKPJIOJMKID(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1070f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 1043f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x0600780C RID: 30732 RVA: 0x003996D8 File Offset: 0x003978D8
	protected virtual void NKPPNFIHLIG()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 994f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1724f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1704f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.ONLMFFNPGCP());
	}

	// Token: 0x0600780D RID: 30733 RVA: 0x00399794 File Offset: 0x00397994
	private void OPBFJONHHOI()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 315f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x0600780E RID: 30734 RVA: 0x00399810 File Offset: 0x00397A10
	protected void PHJJELLGJOO(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1797f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.PHJJELLGJOO(this.DDINHLIJQMJ, 742f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x0600780F RID: 30735 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator CMBHFHGHQED()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007811 RID: 30737 RVA: 0x0002B1B7 File Offset: 0x000293B7
	protected virtual void HHNPGNKHNQF()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.QLQKCEGBLGF());
		}
	}

	// Token: 0x06007812 RID: 30738 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator FCMGPFIHJJP()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007813 RID: 30739 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator FHPMQIBQPEQ()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007814 RID: 30740 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator INGEBFDMKNP()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007815 RID: 30741 RVA: 0x00399864 File Offset: 0x00397A64
	private void QJGNJIIOHMI()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1366f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x06007817 RID: 30743 RVA: 0x003998E0 File Offset: 0x00397AE0
	protected virtual void IOCDNOLPFCI()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1808f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 408f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 4f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.JGCDIGEMHGK());
	}

	// Token: 0x06007818 RID: 30744 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator ELDIIOFOONK()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x06007819 RID: 30745 RVA: 0x00398A70 File Offset: 0x00396C70
	private IEnumerator CNNHIJKKCCK()
	{
		if (!this.JJCNPCLINKD && this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ && Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) > 0.0001f)
		{
			this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
			yield return base.GPONHFNLHCN.ECIOFNPQPGP();
			return 1;
		}
		this.BFDQKNMIIKD = 0f;
		yield break;
	}

	// Token: 0x0600781A RID: 30746 RVA: 0x0039999C File Offset: 0x00397B9C
	protected virtual void NKHKKBEQGIN()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 969f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1548f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1357f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.OPGFCCOLFJF());
	}

	// Token: 0x0600781B RID: 30747 RVA: 0x0002B0DE File Offset: 0x000292DE
	protected virtual void LCQKMNDILGF()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.GDEKBBPNEDL());
		}
	}

	// Token: 0x0600781C RID: 30748 RVA: 0x00399A58 File Offset: 0x00397C58
	protected virtual void IDLLILHBGIO()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1761f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 603f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 486f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.KENLHNFIKJP());
	}

	// Token: 0x0600781D RID: 30749 RVA: 0x00399B14 File Offset: 0x00397D14
	protected void FLGJNMOJGOH(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 189f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 393f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x0600781E RID: 30750 RVA: 0x00399B68 File Offset: 0x00397D68
	protected void LEQQONCNCEM(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 124f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 571f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x0600781F RID: 30751 RVA: 0x00399BBC File Offset: 0x00397DBC
	protected virtual void LDBGLJMFFLJ()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.FOOEEHDJBQN().y * 605f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.FOOEEHDJBQN().y * 249f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1385f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.MCJQGPIINQE());
	}

	// Token: 0x06007820 RID: 30752 RVA: 0x00399C78 File Offset: 0x00397E78
	private void Start()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x06007821 RID: 30753 RVA: 0x00398A54 File Offset: 0x00396C54
	private IEnumerator PJLHFKIIGPK()
	{
		IL_FE:
		if (this.JJCNPCLINKD)
		{
			if (this.PHFGINEKBGQ == base.GPONHFNLHCN.BPEDJKLJDMJ)
			{
				this.DKKMNJCDGCK = this.IDDJELLPJFD;
				nknellkpmeb = new Vector2(this.FKGNBCKJPQO((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC), this.JNBBJCLFFBB((!this.OCGFLQMHBBG) ? this.HLFEKPCOELI.position : base.GPONHFNLHCN.HGNEKQHNFCC));
				num = base.OMFMKLNPGPP(nknellkpmeb);
				if (this.BKEMPFNPQMM)
				{
					num2 = this.KKQICIBQPDI / this.IIQGQIKIOHG;
				}
				else if (base.GPONHFNLHCN.PGHJQNJLJKG.orthographic)
				{
					num2 = this.IIQGQIKIOHG;
				}
				else
				{
					num2 = Mathf.Abs(this.NHFHQQOCNDF) * Mathf.Tan(this.IIQGQIKIOHG * 0.5f * 0.0174532924f);
				}
				num3 = this.LQHQFLHFQLO * num + num2 * (1f - num);
				if ((num2 > base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 > this.PIMQQKEQCCK) || (num2 < base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f && num3 < this.PIMQQKEQCCK) || this.OPBFFPHKQDQ)
				{
					this.PIMQQKEQCCK = num3;
				}
				this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
				yield return base.GPONHFNLHCN.ECIOFNPQPGP();
				return 1;
			}
		}
		yield break;
		if (Mathf.Abs(base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f - this.PIMQQKEQCCK) <= 0.0001f)
		{
			goto IL_88;
		}
		this.LHCFKHKLLOL((!this.OPBFFPHKQDQ) ? this.CIJKPQCMOMK : this.OPLNGKLLNNM);
		IL_88:
		if (this.BHHDKFGKGKG != base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			goto IL_FE;
		}
		this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.DDINHLIJQMJ = this.PIMQQKEQCCK;
		this.BFDQKNMIIKD = 0f;
		goto IL_FE;
	}

	// Token: 0x06007822 RID: 30754 RVA: 0x00399CF4 File Offset: 0x00397EF4
	protected void CFEGKGEKGPG(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 185f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.PHJJELLGJOO(this.DDINHLIJQMJ, 1558f, GMNJJQQPEDB.EaseOut);
	}

	// Token: 0x06007823 RID: 30755 RVA: 0x00399D48 File Offset: 0x00397F48
	protected virtual void NGICIKNLDNB()
	{
		base.DOJBNQQEFBE();
		base.GPONHFNLHCN.BPEDJKLJDMJ = this.PHFGINEKBGQ;
		if (this.OPBFFPHKQDQ)
		{
			this.LQHQFLHFQLO = this.KKQICIBQPDI;
			this.PIMQQKEQCCK = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1596f;
			this.DDINHLIJQMJ = base.GPONHFNLHCN.PGKODNCDNJQ.y * 475f;
		}
		else
		{
			this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1924f;
			this.PIMQQKEQCCK = this.LQHQFLHFQLO;
			this.DDINHLIJQMJ = this.LQHQFLHFQLO;
		}
		base.StartCoroutine(this.KENLHNFIKJP());
	}

	// Token: 0x06007824 RID: 30756 RVA: 0x00399E04 File Offset: 0x00398004
	private void FPDCCNJOLEF()
	{
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.KKQICIBQPDI = base.GPONHFNLHCN.FOOEEHDJBQN().y * 92f;
		this.LQHQFLHFQLO = this.KKQICIBQPDI;
		this.PIMQQKEQCCK = this.KKQICIBQPDI;
		this.DDINHLIJQMJ = this.KKQICIBQPDI;
		this.NHFHQQOCNDF = this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM);
	}

	// Token: 0x06007825 RID: 30757 RVA: 0x00399E80 File Offset: 0x00398080
	protected void EEQJDHBCNKO(float KFECOLHLLBI)
	{
		this.DDINHLIJQMJ = Mathf.SmoothDamp(this.DDINHLIJQMJ, this.PIMQQKEQCCK, ref this.BFDQKNMIIKD, KFECOLHLLBI, 1781f, base.GPONHFNLHCN.JLHLDNHPINI);
		base.GPONHFNLHCN.LHCFKHKLLOL(this.DDINHLIJQMJ, 959f, GMNJJQQPEDB.EaseInOut);
	}

	// Token: 0x06007826 RID: 30758 RVA: 0x0002B0DE File Offset: 0x000292DE
	protected virtual void OKBOJEIEJNN()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.GDEKBBPNEDL());
		}
	}

	// Token: 0x06007827 RID: 30759 RVA: 0x0002B130 File Offset: 0x00029330
	protected virtual void OFDLLLBMCJM()
	{
		base.FPFNBIDJHKM();
		if (this.OPBFFPHKQDQ)
		{
			this.PIMQQKEQCCK = this.KKQICIBQPDI;
			base.StartCoroutine(this.LBJLOEQLQPI());
		}
	}

	// Token: 0x04001A04 RID: 6660
	public static string KKBIKBIDQEB = "Zoom Trigger";

	// Token: 0x04001A05 RID: 6661
	public bool BKEMPFNPQMM = true;

	// Token: 0x04001A06 RID: 6662
	public float IIQGQIKIOHG = 1.5f;

	// Token: 0x04001A07 RID: 6663
	public float CIJKPQCMOMK = 1f;

	// Token: 0x04001A08 RID: 6664
	[Range(0f, 1f)]
	public float IDDJELLPJFD = 0.25f;

	// Token: 0x04001A09 RID: 6665
	public bool OPBFFPHKQDQ;

	// Token: 0x04001A0A RID: 6666
	public float OPLNGKLLNNM = 1f;

	// Token: 0x04001A0B RID: 6667
	private float KKQICIBQPDI;

	// Token: 0x04001A0C RID: 6668
	private float LQHQFLHFQLO;

	// Token: 0x04001A0D RID: 6669
	private float PIMQQKEQCCK;

	// Token: 0x04001A0E RID: 6670
	private float DDINHLIJQMJ;

	// Token: 0x04001A0F RID: 6671
	private float BHHDKFGKGKG;

	// Token: 0x04001A10 RID: 6672
	private float BFDQKNMIIKD;

	// Token: 0x04001A11 RID: 6673
	private float NHFHQQOCNDF;
}
