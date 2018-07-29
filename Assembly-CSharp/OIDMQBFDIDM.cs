using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

// Token: 0x020001AE RID: 430
public class OIDMQBFDIDM<TPathNode> where TPathNode : EIGLJMLJKQQ
{
	// Token: 0x1700024C RID: 588
	// (get) Token: 0x0600365F RID: 13919 RVA: 0x00017877 File Offset: 0x00015A77
	// (set) Token: 0x06003670 RID: 13936 RVA: 0x000178E0 File Offset: 0x00015AE0
	public TPathNode[,] QMOINQLOGQJ { get; private set; }

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06003660 RID: 13920 RVA: 0x0001787F File Offset: 0x00015A7F
	// (set) Token: 0x06003672 RID: 13938 RVA: 0x000178D7 File Offset: 0x00015AD7
	public int DQLBCQQBMHF { get; private set; }

	// Token: 0x06003661 RID: 13921 RVA: 0x001A1750 File Offset: 0x0019F950
	protected virtual double IJBCIQBJIKE(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI KHMDPPFPJJH, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI MIQJCEQCBHB)
	{
		int num = Math.Abs(KHMDPPFPJJH.FDICGOKLNLM - MIQJCEQCBHB.FDICGOKLNLM);
		int num2 = Math.Abs(KHMDPPFPJJH.IGNHJOPJDIO - MIQJCEQCBHB.IGNHJOPJDIO);
		switch (num + num2)
		{
		case 0:
			return 0.0;
		case 1:
			return 1.0;
		case 2:
			return OIDMQBFDIDM<TPathNode>.GGFKLGDJQGB;
		default:
			throw new ApplicationException();
		}
	}

	// Token: 0x06003662 RID: 13922 RVA: 0x00017887 File Offset: 0x00015A87
	protected virtual double LIQEFNPJQJB(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI KHMDPPFPJJH, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI MIQJCEQCBHB)
	{
		return Math.Sqrt((double)((KHMDPPFPJJH.FDICGOKLNLM - MIQJCEQCBHB.FDICGOKLNLM) * (KHMDPPFPJJH.FDICGOKLNLM - MIQJCEQCBHB.FDICGOKLNLM) + (KHMDPPFPJJH.IGNHJOPJDIO - MIQJCEQCBHB.IGNHJOPJDIO) * (KHMDPPFPJJH.IGNHJOPJDIO - MIQJCEQCBHB.IGNHJOPJDIO)));
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06003663 RID: 13923 RVA: 0x000178C6 File Offset: 0x00015AC6
	// (set) Token: 0x0600366C RID: 13932 RVA: 0x000178CE File Offset: 0x00015ACE
	public int QEEHIBJPEKI { get; private set; }

	// Token: 0x06003664 RID: 13924 RVA: 0x000178C6 File Offset: 0x00015AC6
	public int DQMJHCFEMJC()
	{
		return this.<JHLMPJPNOLH>k__BackingField;
	}

	// Token: 0x06003665 RID: 13925 RVA: 0x000178CE File Offset: 0x00015ACE
	private void OIQGOFHNGOI(int BGBMIEJJQKC)
	{
		this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003666 RID: 13926 RVA: 0x0001787F File Offset: 0x00015A7F
	public int DPBHBKNOCGL()
	{
		return this.<ECHHBIJDOGC>k__BackingField;
	}

	// Token: 0x06003667 RID: 13927 RVA: 0x0001787F File Offset: 0x00015A7F
	public int BFLDFOCECHN()
	{
		return this.<ECHHBIJDOGC>k__BackingField;
	}

	// Token: 0x06003668 RID: 13928 RVA: 0x001A17B8 File Offset: 0x0019F9B8
	public OIDMQBFDIDM(TPathNode[,] FIMBDNQBGDD)
	{
		this.QMOINQLOGQJ = FIMBDNQBGDD;
		this.QEEHIBJPEKI = FIMBDNQBGDD.GetLength(0);
		this.DQLBCQQBMHF = FIMBDNQBGDD.GetLength(1);
		this.NIGODPEGNEN = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[this.QEEHIBJPEKI, this.DQLBCQQBMHF];
		this.QHELQJDBGOG = new OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN(this.QEEHIBJPEKI, this.DQLBCQQBMHF);
		this.HCCDHFBHQLM = new OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN(this.QEEHIBJPEKI, this.DQLBCQQBMHF);
		this.MIFDFGPGIJJ = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[this.QEEHIBJPEKI, this.DQLBCQQBMHF];
		this.LGCELOLNNIM = new OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN(this.QEEHIBJPEKI, this.DQLBCQQBMHF);
		this.GGBEEQJKGMP = new IKPMPLEFGCC<OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI>(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI.PBGOHKKHNLM);
		for (int i = 0; i < this.QEEHIBJPEKI; i++)
		{
			for (int j = 0; j < this.DQLBCQQBMHF; j++)
			{
				if (FIMBDNQBGDD[i, j] == null)
				{
					throw new ArgumentNullException();
				}
				this.NIGODPEGNEN[i, j] = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI(i, j, FIMBDNQBGDD[i, j]);
			}
		}
	}

	// Token: 0x06003669 RID: 13929 RVA: 0x000178CE File Offset: 0x00015ACE
	private void IKJJFIMOQDD(int BGBMIEJJQKC)
	{
		this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600366A RID: 13930 RVA: 0x001A18C4 File Offset: 0x0019FAC4
	public LinkedList<TPathNode> NMBCHIIQLIH(Vector2 PIIGQPFEKEI, Vector2 EBPBIEGOFBO)
	{
		OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI olqlhlgpcfi = this.NIGODPEGNEN[(int)PIIGQPFEKEI.x, (int)PIIGQPFEKEI.y];
		OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI olqlhlgpcfi2 = this.NIGODPEGNEN[(int)EBPBIEGOFBO.x, (int)EBPBIEGOFBO.y];
		if (olqlhlgpcfi == olqlhlgpcfi2)
		{
			return new LinkedList<TPathNode>(new TPathNode[]
			{
				olqlhlgpcfi.PBPFLFGFELQ
			});
		}
		OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[] array = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[4];
		this.QHELQJDBGOG.CPLBKPNNHJG();
		this.HCCDHFBHQLM.CPLBKPNNHJG();
		this.LGCELOLNNIM.CPLBKPNNHJG();
		this.GGBEEQJKGMP.CPLBKPNNHJG();
		for (int i = 0; i < this.QEEHIBJPEKI; i++)
		{
			for (int j = 0; j < this.DQLBCQQBMHF; j++)
			{
				this.MIFDFGPGIJJ[i, j] = null;
			}
		}
		olqlhlgpcfi.BILCDKIDOIF = 0.0;
		olqlhlgpcfi.PIIICJFGBHQ = this.LIQEFNPJQJB(olqlhlgpcfi, olqlhlgpcfi2);
		olqlhlgpcfi.NKEIQMNDJLC = olqlhlgpcfi.PIIICJFGBHQ;
		this.HCCDHFBHQLM.LHQECHHMOGD(olqlhlgpcfi);
		this.GGBEEQJKGMP.QPPNQIPNLND(olqlhlgpcfi);
		this.LGCELOLNNIM.LHQECHHMOGD(olqlhlgpcfi);
		int num = 0;
		while (!this.HCCDHFBHQLM.PQPHIEQMHJI)
		{
			OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI olqlhlgpcfi3 = this.GGBEEQJKGMP.IPOQDLCFDFC();
			if (olqlhlgpcfi3 == olqlhlgpcfi2)
			{
				LinkedList<TPathNode> linkedList = this.PGBKBLJBBIO(this.MIFDFGPGIJJ, this.MIFDFGPGIJJ[olqlhlgpcfi2.FDICGOKLNLM, olqlhlgpcfi2.IGNHJOPJDIO]);
				linkedList.AddLast(olqlhlgpcfi2.PBPFLFGFELQ);
				return linkedList;
			}
			this.HCCDHFBHQLM.FQDMDDOHCQJ(olqlhlgpcfi3);
			this.QHELQJDBGOG.LHQECHHMOGD(olqlhlgpcfi3);
			this.JMOPPGPGHKP(olqlhlgpcfi3, array);
			foreach (OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI olqlhlgpcfi4 in array)
			{
				if (olqlhlgpcfi4 != null)
				{
					TPathNode pbpflfgfelq = olqlhlgpcfi4.PBPFLFGFELQ;
					if (pbpflfgfelq.CNMFNCNOBFC() && !this.QHELQJDBGOG.QGJHDEBPEBD(olqlhlgpcfi4))
					{
						num++;
						double num2 = this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi3).BILCDKIDOIF + this.IJBCIQBJIKE(olqlhlgpcfi3, olqlhlgpcfi4);
						bool flag = false;
						bool flag2;
						if (!this.HCCDHFBHQLM.QGJHDEBPEBD(olqlhlgpcfi4))
						{
							this.HCCDHFBHQLM.LHQECHHMOGD(olqlhlgpcfi4);
							flag2 = true;
							flag = true;
						}
						else
						{
							flag2 = (num2 < this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).BILCDKIDOIF);
						}
						if (flag2)
						{
							this.MIFDFGPGIJJ[olqlhlgpcfi4.FDICGOKLNLM, olqlhlgpcfi4.IGNHJOPJDIO] = olqlhlgpcfi3;
							if (!this.LGCELOLNNIM.QGJHDEBPEBD(olqlhlgpcfi4))
							{
								this.LGCELOLNNIM.LHQECHHMOGD(olqlhlgpcfi4);
							}
							this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).BILCDKIDOIF = num2;
							this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).PIIICJFGBHQ = this.LIQEFNPJQJB(olqlhlgpcfi4, olqlhlgpcfi2);
							this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).NKEIQMNDJLC = this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).BILCDKIDOIF + this.LGCELOLNNIM.get_KNPPMKBOGDL(olqlhlgpcfi4).PIIICJFGBHQ;
							if (flag)
							{
								this.GGBEEQJKGMP.QPPNQIPNLND(olqlhlgpcfi4);
							}
							else
							{
								this.GGBEEQJKGMP.IBQCMOEQPGF(olqlhlgpcfi4);
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600366B RID: 13931 RVA: 0x000178CE File Offset: 0x00015ACE
	private void CCBOLBINPQM(int BGBMIEJJQKC)
	{
		this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600366D RID: 13933 RVA: 0x000178D7 File Offset: 0x00015AD7
	private void OLHLCBKILLQ(int BGBMIEJJQKC)
	{
		this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600366E RID: 13934 RVA: 0x001A1BE8 File Offset: 0x0019FDE8
	private LinkedList<TPathNode> PGBKBLJBBIO(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[,] NEICDQPIQHE, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI EKLDFPOKQIC)
	{
		LinkedList<TPathNode> linkedList = new LinkedList<TPathNode>();
		this.OEDCKICOOCK(NEICDQPIQHE, EKLDFPOKQIC, linkedList);
		return linkedList;
	}

	// Token: 0x0600366F RID: 13935 RVA: 0x001A1C08 File Offset: 0x0019FE08
	private void JMOPPGPGHKP(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI KFPJKLDMCLL, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[] DQOOMDCDCEJ)
	{
		int fdicgoklnlm = KFPJKLDMCLL.FDICGOKLNLM;
		int ignhjopjdio = KFPJKLDMCLL.IGNHJOPJDIO;
		if (fdicgoklnlm > 0)
		{
			DQOOMDCDCEJ[0] = this.NIGODPEGNEN[fdicgoklnlm - 1, ignhjopjdio];
		}
		else
		{
			DQOOMDCDCEJ[0] = null;
		}
		if (fdicgoklnlm < this.QEEHIBJPEKI - 1)
		{
			DQOOMDCDCEJ[1] = this.NIGODPEGNEN[fdicgoklnlm + 1, ignhjopjdio];
		}
		else
		{
			DQOOMDCDCEJ[1] = null;
		}
		if (ignhjopjdio > 0)
		{
			DQOOMDCDCEJ[2] = this.NIGODPEGNEN[fdicgoklnlm, ignhjopjdio - 1];
		}
		else
		{
			DQOOMDCDCEJ[2] = null;
		}
		if (ignhjopjdio < this.DQLBCQQBMHF - 1)
		{
			DQOOMDCDCEJ[3] = this.NIGODPEGNEN[fdicgoklnlm, ignhjopjdio + 1];
		}
		else
		{
			DQOOMDCDCEJ[3] = null;
		}
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x000178D7 File Offset: 0x00015AD7
	private void PNFNIFIJHCK(int BGBMIEJJQKC)
	{
		this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003674 RID: 13940 RVA: 0x000178CE File Offset: 0x00015ACE
	private void ILNGBDEBGNM(int BGBMIEJJQKC)
	{
		this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x0001787F File Offset: 0x00015A7F
	public int IICBGEDIGOE()
	{
		return this.<ECHHBIJDOGC>k__BackingField;
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x000178C6 File Offset: 0x00015AC6
	public int CQJHJHBOFJI()
	{
		return this.<JHLMPJPNOLH>k__BackingField;
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x0001787F File Offset: 0x00015A7F
	public int EQMFICPICMO()
	{
		return this.<ECHHBIJDOGC>k__BackingField;
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x001A1CA4 File Offset: 0x0019FEA4
	private void OEDCKICOOCK(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[,] NEICDQPIQHE, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI EKLDFPOKQIC, LinkedList<TPathNode> JCNEFGFILCD)
	{
		OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI olqlhlgpcfi = NEICDQPIQHE[EKLDFPOKQIC.FDICGOKLNLM, EKLDFPOKQIC.IGNHJOPJDIO];
		if (olqlhlgpcfi != null)
		{
			this.OEDCKICOOCK(NEICDQPIQHE, olqlhlgpcfi, JCNEFGFILCD);
			JCNEFGFILCD.AddLast(EKLDFPOKQIC.PBPFLFGFELQ);
		}
		else
		{
			JCNEFGFILCD.AddLast(EKLDFPOKQIC.PBPFLFGFELQ);
		}
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x000178CE File Offset: 0x00015ACE
	private void NICLBBJQQNM(int BGBMIEJJQKC)
	{
		this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x04000CD5 RID: 3285
	private OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN QHELQJDBGOG;

	// Token: 0x04000CD6 RID: 3286
	private OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN HCCDHFBHQLM;

	// Token: 0x04000CD7 RID: 3287
	private IKPMPLEFGCC<OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI> GGBEEQJKGMP;

	// Token: 0x04000CD8 RID: 3288
	private OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[,] MIFDFGPGIJJ;

	// Token: 0x04000CD9 RID: 3289
	private OIDMQBFDIDM<TPathNode>.KJEGPEHNCIN LGCELOLNNIM;

	// Token: 0x04000CDA RID: 3290
	private OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[,] NIGODPEGNEN;

	// Token: 0x04000CDE RID: 3294
	private static readonly double GGFKLGDJQGB = Math.Sqrt(2.0);

	// Token: 0x020001AF RID: 431
	protected class OLQLHLGPCFI : IComparer<OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI>, EIGLJMLJKQQ, CIDNHCPOQIE
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x000178FE File Offset: 0x00015AFE
		internal void EKCMBJEHEKE(double BGBMIEJJQKC)
		{
			this.<JCEQEFNMFOG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00017907 File Offset: 0x00015B07
		public int QIKHCKOQLLQ()
		{
			return this.<QKQEFJMMFCF>k__BackingField;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0001790F File Offset: 0x00015B0F
		internal void COPLECCOCFJ(int BGBMIEJJQKC)
		{
			this.<GENNGGELFBE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00017918 File Offset: 0x00015B18
		public int Compare(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI DGKOIGOLHDM, OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI DDLQKFDFMCJ)
		{
			if (DGKOIGOLHDM.NKEIQMNDJLC < DDLQKFDFMCJ.NKEIQMNDJLC)
			{
				return -1;
			}
			if (DGKOIGOLHDM.NKEIQMNDJLC > DDLQKFDFMCJ.NKEIQMNDJLC)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x0001793B File Offset: 0x00015B3B
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x00017954 File Offset: 0x00015B54
		public int IGNHJOPJDIO { get; internal set; }

		// Token: 0x0600367F RID: 13951 RVA: 0x001A1CEC File Offset: 0x0019FEEC
		public bool CNMFNCNOBFC()
		{
			TPathNode pbpflfgfelq = this.PBPFLFGFELQ;
			return pbpflfgfelq.CNMFNCNOBFC();
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x001A1CEC File Offset: 0x0019FEEC
		public bool GIGOEJNGBOQ()
		{
			TPathNode pbpflfgfelq = this.PBPFLFGFELQ;
			return pbpflfgfelq.CNMFNCNOBFC();
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x0001797F File Offset: 0x00015B7F
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x00017943 File Offset: 0x00015B43
		public TPathNode PBPFLFGFELQ { get; internal set; }

		// Token: 0x06003682 RID: 13954 RVA: 0x0001794C File Offset: 0x00015B4C
		public double DGIPGHCJNEG()
		{
			return this.<QKQQNLMDBPC>k__BackingField;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00017954 File Offset: 0x00015B54
		internal void IDQIEPDKNGD(int BGBMIEJJQKC)
		{
			this.<NKOEMGGDNOM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x000179AD File Offset: 0x00015BAD
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x000178FE File Offset: 0x00015AFE
		public double NKEIQMNDJLC { get; internal set; }

		// Token: 0x06003686 RID: 13958 RVA: 0x0001795D File Offset: 0x00015B5D
		public int QLNHEMOBNPH()
		{
			return this.<GENNGGELFBE>k__BackingField;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x0001794C File Offset: 0x00015B4C
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x00017965 File Offset: 0x00015B65
		public double PIIICJFGBHQ { get; internal set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06003688 RID: 13960 RVA: 0x00017907 File Offset: 0x00015B07
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x00017976 File Offset: 0x00015B76
		public int CDBMKFFDOIJ { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0001795D File Offset: 0x00015B5D
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x0001790F File Offset: 0x00015B0F
		public int FDICGOKLNLM { get; internal set; }

		// Token: 0x0600368B RID: 13963 RVA: 0x0001796E File Offset: 0x00015B6E
		public double NGPJJQGKJEG()
		{
			return this.<IQGQDHHFPLI>k__BackingField;
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0001794C File Offset: 0x00015B4C
		public double CDGDLDCOEBI()
		{
			return this.<QKQQNLMDBPC>k__BackingField;
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00017976 File Offset: 0x00015B76
		public void GCEKBHPJNJQ(int BGBMIEJJQKC)
		{
			this.<QKQEFJMMFCF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0001796E File Offset: 0x00015B6E
		public double DQDMMKLPFKQ()
		{
			return this.<IQGQDHHFPLI>k__BackingField;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00017976 File Offset: 0x00015B76
		public void LNCJENBEQHC(int BGBMIEJJQKC)
		{
			this.<QKQEFJMMFCF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000178FE File Offset: 0x00015AFE
		internal void EIBQLGKOOEM(double BGBMIEJJQKC)
		{
			this.<JCEQEFNMFOG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x001A1CEC File Offset: 0x0019FEEC
		public bool PFEJJBLMJBD()
		{
			TPathNode pbpflfgfelq = this.PBPFLFGFELQ;
			return pbpflfgfelq.CNMFNCNOBFC();
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x000178FE File Offset: 0x00015AFE
		internal void DKQBEHBHCJP(double BGBMIEJJQKC)
		{
			this.<JCEQEFNMFOG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x0001795D File Offset: 0x00015B5D
		public int BIODLIOFOKM()
		{
			return this.<GENNGGELFBE>k__BackingField;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00017987 File Offset: 0x00015B87
		internal void PJJGFJLKCCB(double BGBMIEJJQKC)
		{
			this.<IQGQDHHFPLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00017954 File Offset: 0x00015B54
		internal void CQKJLLEKHMG(int BGBMIEJJQKC)
		{
			this.<NKOEMGGDNOM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x0001796E File Offset: 0x00015B6E
		// (set) Token: 0x06003699 RID: 13977 RVA: 0x00017987 File Offset: 0x00015B87
		public double BILCDKIDOIF { get; internal set; }

		// Token: 0x0600369B RID: 13979 RVA: 0x00017990 File Offset: 0x00015B90
		public OLQLHLGPCFI(int JJNOOQCPLQP, int MLHGFOLDECO, TPathNode HKBDLJQHQFO)
		{
			this.FDICGOKLNLM = JJNOOQCPLQP;
			this.IGNHJOPJDIO = MLHGFOLDECO;
			this.PBPFLFGFELQ = HKBDLJQHQFO;
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00017907 File Offset: 0x00015B07
		public int PHLLQNKNPGI()
		{
			return this.<QKQEFJMMFCF>k__BackingField;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0001794C File Offset: 0x00015B4C
		public double PHJBLGFFGEO()
		{
			return this.<QKQQNLMDBPC>k__BackingField;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0001793B File Offset: 0x00015B3B
		public int IHNBCEGHDCP()
		{
			return this.<NKOEMGGDNOM>k__BackingField;
		}

		// Token: 0x04000CDF RID: 3295
		public static readonly OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI PBGOHKKHNLM = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI(0, 0, default(TPathNode));
	}

	// Token: 0x020001B0 RID: 432
	[DefaultMember("Item")]
	private class KJEGPEHNCIN
	{
		// Token: 0x060036A1 RID: 13985 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void OPGHODHMIGL(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void FDHJEMICPLG(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void HEONJNOICEN(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool HLGFONOFNDL()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int DDQPHQQIJQD()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int KDQNOPLLMGC()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int NNMPMOLBDMD()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000179D9 File Offset: 0x00015BD9
		public int NLIQDFEBGGN()
		{
			return this.<ECHHBIJDOGC>k__BackingField;
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool GDEMLBLPMDP()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000179E1 File Offset: 0x00015BE1
		private void HKINCDMKFIJ(int BGBMIEJJQKC)
		{
			this.<ELIQJIBDNGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x001A1D34 File Offset: 0x0019FF34
		public void NJOGQEPKOBB()
		{
			this.EDHONKQBOQM = 1;
			for (int i = 0; i < this.QEEHIBJPEKI; i += 0)
			{
				for (int j = 1; j < this.DQLBCQQBMHF; j++)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000179D9 File Offset: 0x00015BD9
		public int QONKLCDQMIE()
		{
			return this.<ECHHBIJDOGC>k__BackingField;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void DEFCDECHFPH(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x000179C9 File Offset: 0x00015BC9
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x000179E1 File Offset: 0x00015BE1
		public int EDHONKQBOQM { get; private set; }

		// Token: 0x060036AF RID: 13999 RVA: 0x001A1D78 File Offset: 0x0019FF78
		public void LHQECHHMOGD(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI CKJQMNDGEDI)
		{
			this.JHHCGBIGJBL[CKJQMNDGEDI.FDICGOKLNLM, CKJQMNDGEDI.IGNHJOPJDIO];
			this.EDHONKQBOQM++;
			this.JHHCGBIGJBL[CKJQMNDGEDI.FDICGOKLNLM, CKJQMNDGEDI.IGNHJOPJDIO] = CKJQMNDGEDI;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int CENFOJOBEOJ()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x001A1DC4 File Offset: 0x0019FFC4
		public void MDJOKFQICCC()
		{
			this.EDHONKQBOQM = 0;
			for (int i = 0; i < this.QEEHIBJPEKI; i += 0)
			{
				for (int j = 1; j < this.DQLBCQQBMHF; j++)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000179D9 File Offset: 0x00015BD9
		public int JLGIEBJLIIB()
		{
			return this.<ECHHBIJDOGC>k__BackingField;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool MFEEKJDFKPK()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000179E1 File Offset: 0x00015BE1
		private void CCBKDCQODGH(int BGBMIEJJQKC)
		{
			this.<ELIQJIBDNGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int LHMJPBDKPQG()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x001A1E08 File Offset: 0x001A0008
		public void BJKQHFKGBPE()
		{
			this.EDHONKQBOQM = 0;
			for (int i = 1; i < this.QEEHIBJPEKI; i += 0)
			{
				for (int j = 1; j < this.DQLBCQQBMHF; j += 0)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000179E1 File Offset: 0x00015BE1
		private void MJQOONDGHHK(int BGBMIEJJQKC)
		{
			this.<ELIQJIBDNGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool DNJNEFFLBDL()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000179EA File Offset: 0x00015BEA
		private void GIOFNIFBFDM(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x001A1E4C File Offset: 0x001A004C
		public void FQDMDDOHCQJ(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI CKJQMNDGEDI)
		{
			this.JHHCGBIGJBL[CKJQMNDGEDI.FDICGOKLNLM, CKJQMNDGEDI.IGNHJOPJDIO];
			this.EDHONKQBOQM--;
			this.JHHCGBIGJBL[CKJQMNDGEDI.FDICGOKLNLM, CKJQMNDGEDI.IGNHJOPJDIO] = null;
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int BGLNPMCDIMI()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000179F3 File Offset: 0x00015BF3
		public KJEGPEHNCIN(int CPMPDPMQKBQ, int NQLCEHGPHHK)
		{
			this.JHHCGBIGJBL = new OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[CPMPDPMQKBQ, NQLCEHGPHHK];
			this.QEEHIBJPEKI = CPMPDPMQKBQ;
			this.DQLBCQQBMHF = NQLCEHGPHHK;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool LDPPGQBCDMQ()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool QDMBDEQMLPG()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000179D9 File Offset: 0x00015BD9
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x000179EA File Offset: 0x00015BEA
		public int DQLBCQQBMHF { get; private set; }

		// Token: 0x060036C0 RID: 14016 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void BDMOLGOQPKC(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int BCLPQPPNFKJ()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int IDPPPJKMBKJ()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int FQMJDOLHMIH()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int NNEHDFQBCJI()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x00017A16 File Offset: 0x00015C16
		public bool PQPHIEQMHJI
		{
			get
			{
				return this.EDHONKQBOQM == 0;
			}
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x000179E1 File Offset: 0x00015BE1
		private void HGCMNNHEQNN(int BGBMIEJJQKC)
		{
			this.<ELIQJIBDNGF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00017A16 File Offset: 0x00015C16
		public bool PDENNPLCIQN()
		{
			return this.EDHONKQBOQM == 0;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x001A1E98 File Offset: 0x001A0098
		public bool QGJHDEBPEBD(OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI CKJQMNDGEDI)
		{
			return this.JHHCGBIGJBL[CKJQMNDGEDI.FDICGOKLNLM, CKJQMNDGEDI.IGNHJOPJDIO] != null;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int BFLLDICKQEF()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x000179D1 File Offset: 0x00015BD1
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x000179B5 File Offset: 0x00015BB5
		public int QEEHIBJPEKI { get; private set; }

		// Token: 0x060036CC RID: 14028 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void CDLCBGHBKGF(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000179EA File Offset: 0x00015BEA
		private void JBPEQNOOCHI(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000179B5 File Offset: 0x00015BB5
		private void BNGLQLNLOND(int BGBMIEJJQKC)
		{
			this.<JHLMPJPNOLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool BMLNJIJLOBE()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int MOLELJGBIJO()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000179D9 File Offset: 0x00015BD9
		public int LLBKJIBGMQN()
		{
			return this.<ECHHBIJDOGC>k__BackingField;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00017A21 File Offset: 0x00015C21
		public OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI KNPPMKBOGDL
		{
			get
			{
				return this.JHHCGBIGJBL[NLKPLMKFNKK.FDICGOKLNLM, NLKPLMKFNKK.IGNHJOPJDIO];
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int OBGNOFDIGOF()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool NBHGOJIPQOO()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x000179EA File Offset: 0x00015BEA
		private void KMQBBCQBEMH(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int IBIQIKLCPMB()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00017A3A File Offset: 0x00015C3A
		public OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI KNPPMKBOGDL
		{
			get
			{
				return this.JHHCGBIGJBL[DGKOIGOLHDM, DDLQKFDFMCJ];
			}
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x000179D1 File Offset: 0x00015BD1
		public int OICQJLBFLIH()
		{
			return this.<JHLMPJPNOLH>k__BackingField;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x001A1EC4 File Offset: 0x001A00C4
		public void GLQGJINIJLL()
		{
			this.EDHONKQBOQM = 1;
			for (int i = 0; i < this.QEEHIBJPEKI; i += 0)
			{
				for (int j = 0; j < this.DQLBCQQBMHF; j += 0)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x001A1F08 File Offset: 0x001A0108
		public void LIMQJMHDICQ()
		{
			this.EDHONKQBOQM = 0;
			for (int i = 1; i < this.QEEHIBJPEKI; i += 0)
			{
				for (int j = 0; j < this.DQLBCQQBMHF; j++)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int GJBGHLPQGJM()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x000179EA File Offset: 0x00015BEA
		private void OOHJCIEJJOE(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000179BE File Offset: 0x00015BBE
		public bool EIQPFCBOLMF()
		{
			return this.EDHONKQBOQM == 1;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x000179D9 File Offset: 0x00015BD9
		public int HLQBCCOEIHO()
		{
			return this.<ECHHBIJDOGC>k__BackingField;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x000179EA File Offset: 0x00015BEA
		private void DBBMLBFMJNH(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x001A1F4C File Offset: 0x001A014C
		public void FBFCKBGLGBL()
		{
			this.EDHONKQBOQM = 1;
			for (int i = 0; i < this.QEEHIBJPEKI; i++)
			{
				for (int j = 1; j < this.DQLBCQQBMHF; j += 0)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x001A1F90 File Offset: 0x001A0190
		public void CPLBKPNNHJG()
		{
			this.EDHONKQBOQM = 0;
			for (int i = 0; i < this.QEEHIBJPEKI; i++)
			{
				for (int j = 0; j < this.DQLBCQQBMHF; j++)
				{
					this.JHHCGBIGJBL[i, j] = null;
				}
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000179EA File Offset: 0x00015BEA
		private void MEJQEHLDEJQ(int BGBMIEJJQKC)
		{
			this.<ECHHBIJDOGC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x000179C9 File Offset: 0x00015BC9
		public int CIDCEDEMMGK()
		{
			return this.<ELIQJIBDNGF>k__BackingField;
		}

		// Token: 0x04000CE7 RID: 3303
		private OIDMQBFDIDM<TPathNode>.OLQLHLGPCFI[,] JHHCGBIGJBL;
	}
}
