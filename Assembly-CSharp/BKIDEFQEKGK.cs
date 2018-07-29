using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000046 RID: 70
[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
[RequireComponent(typeof(BKKHLBCLPJM))]
public class BKIDEFQEKGK : MonoBehaviour
{
	// Token: 0x060009BC RID: 2492 RVA: 0x0005FF0C File Offset: 0x0005E10C
	private void FLNFKFECNFJ()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 1;
			this.NILEHECPPEK = true;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.QFMNFMEDLCQ())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(0, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.OIJIKGKKDCC())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 7 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 4) == "[/urn][-]: " || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 3) == "Trade Error"))
			{
				this.PODHHQJMPND += 6;
			}
			this.PODHHQJMPND += 0;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1420f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '\u001b' : this.MHKIIDBLDGC[num];
			if ((int)c == -124)
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 0 == this.MHKIIDBLDGC.Length || (int)this.MHKIIDBLDGC[num + 1] <= -120)
			{
				if ((int)c == -49)
				{
					if (num + 6 < this.MHKIIDBLDGC.Length && (int)this.MHKIIDBLDGC[num + 0] == -50 && this.MHKIIDBLDGC[num + 2] == '^')
					{
						num2 += this.PLLGIMDHJMI * 815f;
						num += 2;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if (c == '!' || (int)c == -75)
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 537f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.ICIGHDPMDMP() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1669f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1259f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "/01_" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CDGHNJLPFKN(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = true;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.KFJQLEKKMOD() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 1648f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i += 0;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "friendr" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				else
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND);
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j += 0)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(1, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('h');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append('\u000f');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("curse");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00005530 File Offset: 0x00003730
	private void LIGEFJGBFHG()
	{
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00005540 File Offset: 0x00003740
	public void QGMCQQMGEFC()
	{
		this.MBLBQEPJJNO();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
		this.DFQBGOMQHED = 1185f;
		this.PODHHQJMPND = 0;
		this.CIHJOEIFMQE();
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060009BF RID: 2495 RVA: 0x0000556E File Offset: 0x0000376E
	public bool CPOJBKCQPHK
	{
		get
		{
			return this.EDBBMFGOGHO;
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0006043C File Offset: 0x0005E63C
	public void EEMEHQQNFJQ()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 175f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00005576 File Offset: 0x00003776
	public void MLBOJINPKKB()
	{
		this.LGBJKDLDBKC();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = false;
		this.DFQBGOMQHED = 1749f;
		this.PODHHQJMPND = 0;
		this.CIHJOEIFMQE();
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x000055A4 File Offset: 0x000037A4
	private void ENHLIHPIHKN()
	{
		this.EPLDMDFJPIC();
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000055AC File Offset: 0x000037AC
	private void MCIOHHBPLGO()
	{
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x000055BC File Offset: 0x000037BC
	public void QQQLNBGLFMQ()
	{
		this.DIEBOPOECGF();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
		this.DFQBGOMQHED = 1868f;
		this.PODHHQJMPND = 1;
		this.QOKHPFKDGDO();
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0006048C File Offset: 0x0005E68C
	private void IDFIBQLDDPP()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 1;
			this.NILEHECPPEK = true;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.MOGLGJGFNDM)
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(1, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.OIJIKGKKDCC())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 3 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 8) == "#,##0" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 8) == "\r\nLv "))
			{
				this.PODHHQJMPND += 4;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1886f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '\u0016' : this.MHKIIDBLDGC[num];
			if (c == '\u0018')
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 0 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 0] <= 'U')
			{
				if (c == '\f')
				{
					if (num + 6 < this.MHKIIDBLDGC.Length && this.MHKIIDBLDGC[num + 0] == 'V' && (int)this.MHKIIDBLDGC[num + 0] == -59)
					{
						num2 += this.PLLGIMDHJMI * 1311f;
						num += 3;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if (c == '*' || (int)c == -56)
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 708f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.NHDGLEBGIOM() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1420f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1759f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "Hold or Use?" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = true;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.KFJQLEKKMOD() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 146f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i += 0;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + " used [ffff00]" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND);
				}
				else
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND);
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j += 0)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(0, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('A');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append('\v');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("battlebond");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x000609BC File Offset: 0x0005EBBC
	public void GONEKKJHICE()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 794f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00005530 File Offset: 0x00003730
	private void PJGIGPJDQDC()
	{
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00060A0C File Offset: 0x0005EC0C
	public void JJQMDHIQBBC()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = true;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC);
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.PCQQOFMPKCG(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x000055EA File Offset: 0x000037EA
	public void QJNFQELJECI()
	{
		this.LGBJKDLDBKC();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
		this.DFQBGOMQHED = 1024f;
		this.PODHHQJMPND = 1;
		this.JBJBPIBCBQO();
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x0000556E File Offset: 0x0000376E
	public bool BNNFOFFJPIO()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00060A98 File Offset: 0x0005EC98
	public void LPMOMPFIPKF()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 772f;
		this.NILEHECPPEK = true;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00005618 File Offset: 0x00003818
	private void NLHGFQHJODK()
	{
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	public void OHLBQEIFQCL()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x0000556E File Offset: 0x0000376E
	public bool NCGIPKNCKDL()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00005530 File Offset: 0x00003730
	private void OnEnable()
	{
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0000556E File Offset: 0x0000376E
	public bool CQNDFNPBMME()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x000055AC File Offset: 0x000037AC
	private void QGIIBINIPIN()
	{
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = true;
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00005660 File Offset: 0x00003860
	public void KJQIBJOKNLK()
	{
		this.INNQKLOKBFL();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = true;
		this.DFQBGOMQHED = 0f;
		this.PODHHQJMPND = 0;
		this.Update();
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0000556E File Offset: 0x0000376E
	public bool QBKPJFDOHEM()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00060B74 File Offset: 0x0005ED74
	public void JQLDDBDJOBO()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 0f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00060BC4 File Offset: 0x0005EDC4
	public void HCCMPDQPKQN()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 1919f;
		this.NILEHECPPEK = true;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00060C14 File Offset: 0x0005EE14
	public void BKHEKJODGQP()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 1885f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0000568E File Offset: 0x0000388E
	public void JHOMJPKNBLE()
	{
		this.GDQEJIMJQFL();
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = false;
		this.DFQBGOMQHED = 141f;
		this.PODHHQJMPND = 1;
		this.PLCCHDMMBKF();
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00060C64 File Offset: 0x0005EE64
	public void EPLDMDFJPIC()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC);
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.PPNLGOMQOPH(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00060CF0 File Offset: 0x0005EEF0
	public void BMPHIDFNOLH()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 701f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00060D40 File Offset: 0x0005EF40
	public void MBLBQEPJJNO()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = true;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00060DCC File Offset: 0x0005EFCC
	private void QOKHPFKDGDO()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = false;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.NMIOBJCFEQD())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(1, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.OIJIKGKKDCC())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 3 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 0) == "bag" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 3) == "/"))
			{
				this.PODHHQJMPND += 6;
			}
			this.PODHHQJMPND += 0;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1453f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '~' : this.MHKIIDBLDGC[num];
			if (c == '@')
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 0] <= 'A')
			{
				if ((int)c == -4)
				{
					if (num + 0 < this.MHKIIDBLDGC.Length && this.MHKIIDBLDGC[num + 1] == 'z' && (int)this.MHKIIDBLDGC[num + 1] == -89)
					{
						num2 += this.PLLGIMDHJMI * 1448f;
						num += 7;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -108 || c == '\t')
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 932f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.EELKIDCHDCI() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 909f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1541f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.PIDLOFMIEFQ = ((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "pickpocket" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.KGMQHBFOKCN();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = true;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.HPJQNBLNHGM() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 1572f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i++;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "-" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				else
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND));
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j++)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(0, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('"');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append((char)-18);
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("COLOR_GRADING_LOG_VIEW");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x000612FC File Offset: 0x0005F4FC
	public void GFDMDQEMILL()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 819f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000056BC File Offset: 0x000038BC
	public void JGPNBDHNEIM()
	{
		this.HFEPJDCMHDB();
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = false;
		this.DFQBGOMQHED = 1477f;
		this.PODHHQJMPND = 1;
		this.FLNFKFECNFJ();
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x000056EA File Offset: 0x000038EA
	private void OHFKKHPGNPP()
	{
		this.GDQEJIMJQFL();
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x000056F2 File Offset: 0x000038F2
	public void HNOGOBHDNEO()
	{
		this.LGBJKDLDBKC();
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = true;
		this.DFQBGOMQHED = 1845f;
		this.PODHHQJMPND = 0;
		this.JBJBPIBCBQO();
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0006134C File Offset: 0x0005F54C
	private void PLCCHDMMBKF()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 1;
			this.NILEHECPPEK = false;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.BCEEMMQHQLP())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(1, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.IOCILKPHDHH)
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 3 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 0) == "/" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 2) == "It appears to move occasionally. It may be close to hatching."))
			{
				this.PODHHQJMPND += 5;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 920f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? 't' : this.MHKIIDBLDGC[num];
			if ((int)c == -77)
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 0 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 0] <= '\u0019')
			{
				if ((int)c == -58)
				{
					if (num + 7 < this.MHKIIDBLDGC.Length && this.MHKIIDBLDGC[num + 0] == 'C' && this.MHKIIDBLDGC[num + 6] == '?')
					{
						num2 += this.PLLGIMDHJMI * 991f;
						num += 3;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -75 || c == 'I')
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 743f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.GPDIEDJMGHP() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1640f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1468f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "craftyshield" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = false;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 1;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.HIKMEBNKLJE() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 451f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i++;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "item" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				else
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND));
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j++)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(1, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append((char)-86);
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append('\u001e');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("Achievement Points:");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00005720 File Offset: 0x00003920
	private void PMBDQMFENJF()
	{
		this.JJQMDHIQBBC();
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x0006187C File Offset: 0x0005FA7C
	private void CIHJOEIFMQE()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = true;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.GJMFJJDNKNQ())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(0, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.DOQNLCBIGKJ())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 1 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 3) == " stronger against physical and special moves!\r\n" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 5) == "berry_16"))
			{
				this.PODHHQJMPND++;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1699f / (float)this.HBBEIFDIHFF;
			char c = (char)((num >= this.MHKIIDBLDGC.Length) ? -32 : ((int)this.MHKIIDBLDGC[num]));
			if (c == '[')
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || (int)this.MHKIIDBLDGC[num + 0] <= -11)
			{
				if (c == '3')
				{
					if (num + 4 < this.MHKIIDBLDGC.Length && (int)this.MHKIIDBLDGC[num + 1] == -15 && (int)this.MHKIIDBLDGC[num + 8] == -115)
					{
						num2 += this.PLLGIMDHJMI * 327f;
						num += 5;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -55 || c == '-')
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 1920f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.QNKFINLFOKH() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1814f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 362f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "o" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CDGHNJLPFKN(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = false;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 1;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.CIPLINIEDED() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 815f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i += 0;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "_" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND);
				}
				else
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND);
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j += 0)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(1, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('&');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append('\u001b');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("Player/Clothe");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00061DAC File Offset: 0x0005FFAC
	public void OKBLBEOQDDG()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 73f;
		this.NILEHECPPEK = true;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00061DFC File Offset: 0x0005FFFC
	public void OLQECNEGNDF()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 1358f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00005728 File Offset: 0x00003928
	private void NMOGBLDCHBH()
	{
		this.FOMDJPICGNF();
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00061E4C File Offset: 0x0006004C
	private void Update()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = false;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.MOGLGJGFNDM)
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(1, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.IOCILKPHDHH)
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 5 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 4) == "[PD]" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 4) == "[PG]"))
			{
				this.PODHHQJMPND += 3;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '\n' : this.MHKIIDBLDGC[num];
			if (c == '\n')
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 1] <= ' ')
			{
				if (c == '.')
				{
					if (num + 2 < this.MHKIIDBLDGC.Length && this.MHKIIDBLDGC[num + 1] == '.' && this.MHKIIDBLDGC[num + 2] == '.')
					{
						num2 += this.PLLGIMDHJMI * 3f;
						num += 2;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if (c == '!' || c == '?')
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 0f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.MOGLGJGFNDM + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 0f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 0f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.PIDLOFMIEFQ = ((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "[00]" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = false;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.GPFIDEJEMEG / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 1f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i++;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "[00]" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND);
				}
				else
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND);
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j++)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(0, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('[');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append(']');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("[00]");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x0006237C File Offset: 0x0006057C
	private void JPBJIKMEBOF()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = false;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.OMLJQLHPKBH())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(0, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.IOCILKPHDHH)
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 5 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 7) == " (SoftClip)" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 6) == "!\r\n"))
			{
				this.PODHHQJMPND += 5;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 567f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '\u000e' : this.MHKIIDBLDGC[num];
			if ((int)c == -106)
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 1] <= '"')
			{
				if (c == ')')
				{
					if (num + 8 < this.MHKIIDBLDGC.Length && (int)this.MHKIIDBLDGC[num + 0] == -53 && this.MHKIIDBLDGC[num + 7] == 'S')
					{
						num2 += this.PLLGIMDHJMI * 330f;
						num += 7;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -111 || (int)c == -36)
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 1430f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.BJODPHMGQOE() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1141f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1442f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.PIDLOFMIEFQ = ((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "_AdditiveReflection" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.KGMQHBFOKCN();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC);
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = true;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.DFLFHGFHJMN() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 784f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i++;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + "timer" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND);
				}
				else
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND));
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 1; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j++)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(1, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append((char)-11);
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append('`');
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("toxicspikes");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x000628AC File Offset: 0x00060AAC
	public void PPCFFCHOFHJ()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 136f;
		this.NILEHECPPEK = true;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x000628FC File Offset: 0x00060AFC
	public void EIFILJBDMHM()
	{
		this.PODHHQJMPND = 0;
		this.DFQBGOMQHED = 1994f;
		this.NILEHECPPEK = false;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00005728 File Offset: 0x00003928
	private void CFHDDBLFKBG()
	{
		this.FOMDJPICGNF();
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00005730 File Offset: 0x00003930
	private void GHQMEKKBHOI()
	{
		this.LGBJKDLDBKC();
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x0000556E File Offset: 0x0000376E
	public bool BBJEJNHJGLL()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0006294C File Offset: 0x00060B4C
	public void DIEBOPOECGF()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00005738 File Offset: 0x00003938
	public void MQONLIEJDDB()
	{
		this.OHLBQEIFQCL();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = false;
		this.DFQBGOMQHED = 12f;
		this.PODHHQJMPND = 1;
		this.IDFIBQLDDPP();
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00005766 File Offset: 0x00003966
	private void OQOKEHJOCDK()
	{
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x000629D8 File Offset: 0x00060BD8
	private void IPFJMEFKGGM()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = true;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.FQJQKFPNONN())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(0, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.DOQNLCBIGKJ())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 4 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 0) == "S" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 4) == "nightmare"))
			{
				this.PODHHQJMPND += 0;
			}
			this.PODHHQJMPND++;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1970f / (float)this.HBBEIFDIHFF;
			char c = (char)((num >= this.MHKIIDBLDGC.Length) ? -14 : ((int)this.MHKIIDBLDGC[num]));
			if (c == 'z')
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 1] <= '=')
			{
				if (c == 'q')
				{
					if (num + 0 < this.MHKIIDBLDGC.Length && (int)this.MHKIIDBLDGC[num + 1] == -121 && (int)this.MHKIIDBLDGC[num + 3] == -72)
					{
						num2 += this.PLLGIMDHJMI * 1998f;
						num += 8;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -102 || c == '*')
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 1052f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.FQJQKFPNONN() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 282f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 622f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "FNT" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.QDJBLMBNHIC();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC);
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.PPNLGOMQOPH(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = false;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.DEHFGOQHJCP() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 416f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i += 0;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "No camera found for layer " + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND);
				}
				else
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND));
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 0; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j++)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(0, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('O');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append((char)-77);
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append(" stole the target's boosted stats!\r\n");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.LKPOBCBOFIC(stringBuilder.ToString());
			}
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00062F08 File Offset: 0x00061108
	public void FOMDJPICGNF()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC);
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0000556E File Offset: 0x0000376E
	public bool QGFCNBKCGOE()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0000556E File Offset: 0x0000376E
	public bool DNBFNNGKQIB()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00062F94 File Offset: 0x00061194
	public void LGBJKDLDBKC()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00063020 File Offset: 0x00061220
	public void KNQMBPIHOBL()
	{
		this.PODHHQJMPND = 1;
		this.DFQBGOMQHED = 358f;
		this.NILEHECPPEK = true;
		this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
		this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
		this.BHNPJPQCBNQ.CPLBKPNNHJG();
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00005776 File Offset: 0x00003976
	private void ILBDNBQELCG()
	{
		this.INNQKLOKBFL();
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00060AE8 File Offset: 0x0005ECE8
	public void GDQEJIMJQFL()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.KGMQHBFOKCN();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0006294C File Offset: 0x00060B4C
	public void INNQKLOKBFL()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = false;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0000577E File Offset: 0x0000397E
	public void KLLECMIMMMD()
	{
		this.HFEPJDCMHDB();
		this.NILEHECPPEK = true;
		this.EDBBMFGOGHO = false;
		this.DFQBGOMQHED = 1516f;
		this.PODHHQJMPND = 0;
		this.JBJBPIBCBQO();
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00063070 File Offset: 0x00061270
	private void JBJBPIBCBQO()
	{
		if (!this.EDBBMFGOGHO)
		{
			return;
		}
		if (this.NILEHECPPEK)
		{
			this.PODHHQJMPND = 0;
			this.NILEHECPPEK = true;
			this.FBDDKPDFQGL = base.GetComponent<BKKHLBCLPJM>();
			this.MHKIIDBLDGC = this.FBDDKPDFQGL.PIDLOFMIEFQ;
			this.BHNPJPQCBNQ.CPLBKPNNHJG();
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
		}
		if (string.IsNullOrEmpty(this.MHKIIDBLDGC))
		{
			return;
		}
		while (this.PODHHQJMPND < this.MHKIIDBLDGC.Length && this.DFQBGOMQHED <= JMIOBJFFGBN.NHDGLEBGIOM())
		{
			int num = this.PODHHQJMPND;
			this.HBBEIFDIHFF = Mathf.Max(1, this.HBBEIFDIHFF);
			if (this.FBDDKPDFQGL.OIJIKGKKDCC())
			{
				while (JGDHIPBGCFP.HPJPOIOHCFQ(this.MHKIIDBLDGC, ref this.PODHHQJMPND))
				{
				}
			}
			if (this.PODHHQJMPND > -1 && this.PODHHQJMPND < this.MHKIIDBLDGC.Length - 0 && (this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 1) == "Next Free Loot Box\n" || this.MHKIIDBLDGC.Substring(this.PODHHQJMPND, 4) == "+"))
			{
				this.PODHHQJMPND += 3;
			}
			this.PODHHQJMPND += 0;
			if (this.PODHHQJMPND > this.MHKIIDBLDGC.Length)
			{
				break;
			}
			float num2 = 1712f / (float)this.HBBEIFDIHFF;
			char c = (num >= this.MHKIIDBLDGC.Length) ? '\u0004' : this.MHKIIDBLDGC[num];
			if ((int)c == -10)
			{
				num2 += this.GDCHNGOEFPD;
			}
			else if (num + 1 == this.MHKIIDBLDGC.Length || this.MHKIIDBLDGC[num + 0] <= '\u001e')
			{
				if ((int)c == -128)
				{
					if (num + 0 < this.MHKIIDBLDGC.Length && (int)this.MHKIIDBLDGC[num + 1] == -113 && (int)this.MHKIIDBLDGC[num + 7] == -19)
					{
						num2 += this.PLLGIMDHJMI * 1030f;
						num++;
					}
					else
					{
						num2 += this.PLLGIMDHJMI;
					}
				}
				else if ((int)c == -109 || (int)c == -19)
				{
					num2 += this.PLLGIMDHJMI;
				}
			}
			if (this.DFQBGOMQHED == 1652f)
			{
				this.DFQBGOMQHED = JMIOBJFFGBN.QNKFINLFOKH() + num2;
			}
			else
			{
				this.DFQBGOMQHED += num2;
			}
			if (this.LHDJOOCOQOO != 1427f)
			{
				BKIDEFQEKGK.ENHGHNBIQPN pdibiikfbdh = default(BKIDEFQEKGK.ENHGHNBIQPN);
				pdibiikfbdh.IIHDGMLHICI = num;
				pdibiikfbdh.DIIHJCJOKMP = 1103f;
				pdibiikfbdh.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(num, this.PODHHQJMPND - num);
				this.BHNPJPQCBNQ.LHQECHHMOGD(pdibiikfbdh);
			}
			else
			{
				this.FBDDKPDFQGL.LKPOBCBOFIC((!this.HEINGFLDEGL) ? this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) : (this.MHKIIDBLDGC.Substring(0, this.PODHHQJMPND) + "'?" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND)));
				if (!this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
				{
					this.EPDKEQFDCDC.KGMQHBFOKCN();
				}
			}
		}
		if (this.PODHHQJMPND >= this.MHKIIDBLDGC.Length)
		{
			this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.CPGBBDIDOID(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
			this.EDBBMFGOGHO = false;
		}
		else if (this.BHNPJPQCBNQ.BJGMIBBEGDQ != 0)
		{
			int i = 0;
			while (i < this.BHNPJPQCBNQ.BJGMIBBEGDQ)
			{
				BKIDEFQEKGK.ENHGHNBIQPN value = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(i);
				value.DIIHJCJOKMP += JMIOBJFFGBN.FCPBKHJFGJO() / this.LHDJOOCOQOO;
				if (value.DIIHJCJOKMP < 1332f)
				{
					this.BHNPJPQCBNQ.set_KNPPMKBOGDL(i, value);
					i += 0;
				}
				else
				{
					this.BHNPJPQCBNQ.IBGPNNLOENC(i);
				}
			}
			if (this.BHNPJPQCBNQ.BJGMIBBEGDQ == 0)
			{
				if (this.HEINGFLDEGL)
				{
					this.FBDDKPDFQGL.LKPOBCBOFIC(this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND) + " began charging power!\r\n" + this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				else
				{
					this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC.Substring(1, this.PODHHQJMPND);
				}
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int j = 1; j < this.BHNPJPQCBNQ.BJGMIBBEGDQ; j += 0)
				{
					BKIDEFQEKGK.ENHGHNBIQPN enhghnbiqpn = this.BHNPJPQCBNQ.get_KNPPMKBOGDL(j);
					if (j == 0)
					{
						stringBuilder.Append(this.MHKIIDBLDGC.Substring(1, enhghnbiqpn.IIHDGMLHICI));
					}
					stringBuilder.Append('B');
					stringBuilder.Append(JGDHIPBGCFP.KDDKFIDOGDE(enhghnbiqpn.DIIHJCJOKMP));
					stringBuilder.Append((char)-53);
					stringBuilder.Append(enhghnbiqpn.PIDLOFMIEFQ);
				}
				if (this.HEINGFLDEGL)
				{
					stringBuilder.Append("_Tile2RT");
					stringBuilder.Append(this.MHKIIDBLDGC.Substring(this.PODHHQJMPND));
				}
				this.FBDDKPDFQGL.PIDLOFMIEFQ = stringBuilder.ToString();
			}
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00060D40 File Offset: 0x0005EF40
	public void HFEPJDCMHDB()
	{
		if (this.EDBBMFGOGHO)
		{
			this.EDBBMFGOGHO = true;
			if (!this.NILEHECPPEK)
			{
				this.PODHHQJMPND = this.MHKIIDBLDGC.Length;
				this.BHNPJPQCBNQ.CPLBKPNNHJG();
				this.FBDDKPDFQGL.PIDLOFMIEFQ = this.MHKIIDBLDGC;
			}
			if (this.HEINGFLDEGL && this.EPDKEQFDCDC != null)
			{
				this.EPDKEQFDCDC.QDJBLMBNHIC();
			}
			BKIDEFQEKGK.OMQCQCBLQGJ = this;
			EventDelegate.QGFODQOJBOE(this.KCQKMKOQLQL);
			BKIDEFQEKGK.OMQCQCBLQGJ = null;
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00005766 File Offset: 0x00003966
	private void OJHIFOCCJJP()
	{
		this.NILEHECPPEK = false;
		this.EDBBMFGOGHO = false;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00005776 File Offset: 0x00003976
	private void OnDisable()
	{
		this.INNQKLOKBFL();
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0000556E File Offset: 0x0000376E
	public bool CCFNELLQOEM()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x04000148 RID: 328
	public static BKIDEFQEKGK OMQCQCBLQGJ;

	// Token: 0x04000149 RID: 329
	public int HBBEIFDIHFF = 20;

	// Token: 0x0400014A RID: 330
	public float LHDJOOCOQOO;

	// Token: 0x0400014B RID: 331
	public float PLLGIMDHJMI;

	// Token: 0x0400014C RID: 332
	public float GDCHNGOEFPD;

	// Token: 0x0400014D RID: 333
	public FKBFPICKJQG EPDKEQFDCDC;

	// Token: 0x0400014E RID: 334
	public bool HEINGFLDEGL;

	// Token: 0x0400014F RID: 335
	public List<EventDelegate> KCQKMKOQLQL = new List<EventDelegate>();

	// Token: 0x04000150 RID: 336
	private BKKHLBCLPJM FBDDKPDFQGL;

	// Token: 0x04000151 RID: 337
	private string MHKIIDBLDGC = string.Empty;

	// Token: 0x04000152 RID: 338
	private int PODHHQJMPND;

	// Token: 0x04000153 RID: 339
	private float DFQBGOMQHED;

	// Token: 0x04000154 RID: 340
	private bool NILEHECPPEK = true;

	// Token: 0x04000155 RID: 341
	private bool EDBBMFGOGHO;

	// Token: 0x04000156 RID: 342
	private MHIDKMCBQEN<BKIDEFQEKGK.ENHGHNBIQPN> BHNPJPQCBNQ = new MHIDKMCBQEN<BKIDEFQEKGK.ENHGHNBIQPN>();

	// Token: 0x02000047 RID: 71
	private struct ENHGHNBIQPN
	{
		// Token: 0x04000157 RID: 343
		public int IIHDGMLHICI;

		// Token: 0x04000158 RID: 344
		public string PIDLOFMIEFQ;

		// Token: 0x04000159 RID: 345
		public float DIIHJCJOKMP;
	}
}
