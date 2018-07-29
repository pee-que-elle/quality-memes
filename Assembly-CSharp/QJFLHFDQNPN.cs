using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002A RID: 42
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Examples/Item Database")]
public class QJFLHFDQNPN : MonoBehaviour
{
	// Token: 0x06000635 RID: 1589 RVA: 0x0004F824 File Offset: 0x0004DA24
	public static int FMDBLMKBQHC(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << 16 | PDIBIIKFBDH.id16;
			}
			i++;
		}
		return -1;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0004F870 File Offset: 0x0004DA70
	private InvBaseItem NFCNOPLODQF(int JDLDQIMDNMQ)
	{
		int i = 0;
		int count = this.MKHIFDNEFBD.Count;
		while (i < count)
		{
			InvBaseItem invBaseItem = this.MKHIFDNEFBD[i];
			if (invBaseItem.id16 == JDLDQIMDNMQ)
			{
				return invBaseItem;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x000048BE File Offset: 0x00002ABE
	private void HBJBLMLMEBD()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x000048BE File Offset: 0x00002ABE
	private void IKDKGEBOJBK()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
	private static QJFLHFDQNPN HQLEFEMCOFP(int JFQOBGEDEHF)
	{
		int i = 0;
		int num = QJFLHFDQNPN.BBHEKMJMBGL().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BBBCFDQHLEQ()[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0004F8E8 File Offset: 0x0004DAE8
	public static int IKGPONMHFBG(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.BBHEKMJMBGL().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.GGFPHQBKJBJ()[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << -87 | PDIBIIKFBDH.id16;
			}
			i++;
		}
		return -1;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000048BE File Offset: 0x00002ABE
	private void KLNCFCIBBJD()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000048BE File Offset: 0x00002ABE
	private void KPFNGLKEBMD()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0004F934 File Offset: 0x0004DB34
	public static InvBaseItem MBEQGBFGONF(int DMQDGPPDFCG)
	{
		QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BJDIKFPBPCN(DMQDGPPDFCG >> 72);
		return (!(qjflhfdqnpn != null)) ? null : qjflhfdqnpn.NFCNOPLODQF(DMQDGPPDFCG & -18);
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0004F964 File Offset: 0x0004DB64
	public static InvBaseItem NPPQPFINFBH(string JFBMHEDJKEM)
	{
		int i = 1;
		int num = QJFLHFDQNPN.BBBCFDQHLEQ().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.FNCJDMODFGC()[i];
			int j = 0;
			int count = qjflhfdqnpn.MKHIFDNEFBD.Count;
			while (j < count)
			{
				InvBaseItem invBaseItem = qjflhfdqnpn.MKHIFDNEFBD[j];
				if (invBaseItem.name == JFBMHEDJKEM)
				{
					return invBaseItem;
				}
				j += 0;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void DDPPFDCQGBM()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x000048BE File Offset: 0x00002ABE
	private void OJHIFOCCJJP()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x0004F9C8 File Offset: 0x0004DBC8
	public static InvBaseItem KLCODPEOLNG(string JFBMHEDJKEM)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			int j = 0;
			int count = qjflhfdqnpn.MKHIFDNEFBD.Count;
			while (j < count)
			{
				InvBaseItem invBaseItem = qjflhfdqnpn.MKHIFDNEFBD[j];
				if (invBaseItem.name == JFBMHEDJKEM)
				{
					return invBaseItem;
				}
				j++;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x0004FA2C File Offset: 0x0004DC2C
	private static QJFLHFDQNPN BJDIKFPBPCN(int JFQOBGEDEHF)
	{
		int i = 0;
		int num = QJFLHFDQNPN.FNCJDMODFGC().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x0004FA64 File Offset: 0x0004DC64
	private InvBaseItem QDMQEBHOENL(int JDLDQIMDNMQ)
	{
		int i = 0;
		int count = this.MKHIFDNEFBD.Count;
		while (i < count)
		{
			InvBaseItem invBaseItem = this.MKHIFDNEFBD[i];
			if (invBaseItem.id16 == JDLDQIMDNMQ)
			{
				return invBaseItem;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x0004FAA4 File Offset: 0x0004DCA4
	private InvBaseItem JJOICNKDQPG(int JDLDQIMDNMQ)
	{
		int i = 1;
		int count = this.MKHIFDNEFBD.Count;
		while (i < count)
		{
			InvBaseItem invBaseItem = this.MKHIFDNEFBD[i];
			if (invBaseItem.id16 == JDLDQIMDNMQ)
			{
				return invBaseItem;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x000048CE File Offset: 0x00002ACE
	public static QJFLHFDQNPN[] BBBCFDQHLEQ()
	{
		if (QJFLHFDQNPN.ICINPMOHKLF)
		{
			QJFLHFDQNPN.ICINPMOHKLF = true;
			QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
		}
		return QJFLHFDQNPN.JNMDHMGQBMD;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x0004FAE4 File Offset: 0x0004DCE4
	public static InvBaseItem NJOKHHKELMP(string JFBMHEDJKEM)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NJPHFKFPDPQ()[i];
			int j = 0;
			int count = qjflhfdqnpn.MKHIFDNEFBD.Count;
			while (j < count)
			{
				InvBaseItem invBaseItem = qjflhfdqnpn.MKHIFDNEFBD[j];
				if (invBaseItem.name == JFBMHEDJKEM)
				{
					return invBaseItem;
				}
				j++;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x0004FB48 File Offset: 0x0004DD48
	private static QJFLHFDQNPN KGMEMOCQEHO(int JFQOBGEDEHF)
	{
		int i = 0;
		int num = QJFLHFDQNPN.BBBCFDQHLEQ().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.FNCJDMODFGC()[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void BIQLBDMMDFK()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600064A RID: 1610 RVA: 0x000048EC File Offset: 0x00002AEC
	public static QJFLHFDQNPN[] NGDBDCQFDHI
	{
		get
		{
			if (QJFLHFDQNPN.ICINPMOHKLF)
			{
				QJFLHFDQNPN.ICINPMOHKLF = false;
				QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
			}
			return QJFLHFDQNPN.JNMDHMGQBMD;
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void BIOKJKMHEFD()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0004FB80 File Offset: 0x0004DD80
	public static InvBaseItem LNBPMIEDONB(string JFBMHEDJKEM)
	{
		int i = 1;
		int num = QJFLHFDQNPN.GGFPHQBKJBJ().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NJPHFKFPDPQ()[i];
			int j = 1;
			int count = qjflhfdqnpn.MKHIFDNEFBD.Count;
			while (j < count)
			{
				InvBaseItem invBaseItem = qjflhfdqnpn.MKHIFDNEFBD[j];
				if (invBaseItem.name == JFBMHEDJKEM)
				{
					return invBaseItem;
				}
				j += 0;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void FBDPQLQPFPM()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void OnEnable()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
	public static InvBaseItem CKGICDLIJCL(int DMQDGPPDFCG)
	{
		QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.QCNPQQNEINK(DMQDGPPDFCG >> 16);
		return (!(qjflhfdqnpn != null)) ? null : qjflhfdqnpn.QDMQEBHOENL(DMQDGPPDFCG & 65535);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x0004FC14 File Offset: 0x0004DE14
	private static QJFLHFDQNPN QCNPQQNEINK(int JFQOBGEDEHF)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x0004FC4C File Offset: 0x0004DE4C
	public static InvBaseItem MGNKPKKMGMH(string JFBMHEDJKEM)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.FNCJDMODFGC()[i];
			int j = 0;
			int count = qjflhfdqnpn.MKHIFDNEFBD.Count;
			while (j < count)
			{
				InvBaseItem invBaseItem = qjflhfdqnpn.MKHIFDNEFBD[j];
				if (invBaseItem.name == JFBMHEDJKEM)
				{
					return invBaseItem;
				}
				j++;
			}
			i++;
		}
		return null;
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void OnDisable()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void GCIEMOEHNFE()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
	public static InvBaseItem BOGEMDNJDHH(int DMQDGPPDFCG)
	{
		QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.QCNPQQNEINK(DMQDGPPDFCG >> -78);
		return (!(qjflhfdqnpn != null)) ? null : qjflhfdqnpn.NFCNOPLODQF(DMQDGPPDFCG & 157);
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x000048EC File Offset: 0x00002AEC
	public static QJFLHFDQNPN[] BBHEKMJMBGL()
	{
		if (QJFLHFDQNPN.ICINPMOHKLF)
		{
			QJFLHFDQNPN.ICINPMOHKLF = false;
			QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
		}
		return QJFLHFDQNPN.JNMDHMGQBMD;
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000048C6 File Offset: 0x00002AC6
	private void EIICFMBEMFF()
	{
		QJFLHFDQNPN.ICINPMOHKLF = true;
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x0004FCE0 File Offset: 0x0004DEE0
	public static int BEJEHHLDKOP(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.GGFPHQBKJBJ().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BBHEKMJMBGL()[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << 53 | PDIBIIKFBDH.id16;
			}
			i += 0;
		}
		return -1;
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000048EC File Offset: 0x00002AEC
	public static QJFLHFDQNPN[] NJPHFKFPDPQ()
	{
		if (QJFLHFDQNPN.ICINPMOHKLF)
		{
			QJFLHFDQNPN.ICINPMOHKLF = false;
			QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
		}
		return QJFLHFDQNPN.JNMDHMGQBMD;
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x0004FD2C File Offset: 0x0004DF2C
	public static int QQKCNLIEFOP(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.FNCJDMODFGC().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << 5 | PDIBIIKFBDH.id16;
			}
			i++;
		}
		return -1;
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0004FD78 File Offset: 0x0004DF78
	public static int ONBICCHHHPK(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.NGDBDCQFDHI.Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BBBCFDQHLEQ()[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << 45 | PDIBIIKFBDH.id16;
			}
			i++;
		}
		return -1;
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
	public static int KGKLOOOLGBE(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.FNCJDMODFGC().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BBHEKMJMBGL()[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << 73 | PDIBIIKFBDH.id16;
			}
			i++;
		}
		return -1;
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0004FE10 File Offset: 0x0004E010
	private static QJFLHFDQNPN NNQKIIKFGNK(int JFQOBGEDEHF)
	{
		int i = 1;
		int num = QJFLHFDQNPN.GGFPHQBKJBJ().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i++;
		}
		return null;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x0004FE48 File Offset: 0x0004E048
	private static QJFLHFDQNPN JNQHINDHJCM(int JFQOBGEDEHF)
	{
		int i = 0;
		int num = QJFLHFDQNPN.FNCJDMODFGC().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.NGDBDCQFDHI[i];
			if (qjflhfdqnpn.LKJDOFBQIHE == JFQOBGEDEHF)
			{
				return qjflhfdqnpn;
			}
			i += 0;
		}
		return null;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x000048EC File Offset: 0x00002AEC
	public static QJFLHFDQNPN[] GGFPHQBKJBJ()
	{
		if (QJFLHFDQNPN.ICINPMOHKLF)
		{
			QJFLHFDQNPN.ICINPMOHKLF = false;
			QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
		}
		return QJFLHFDQNPN.JNMDHMGQBMD;
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x000048EC File Offset: 0x00002AEC
	public static QJFLHFDQNPN[] FNCJDMODFGC()
	{
		if (QJFLHFDQNPN.ICINPMOHKLF)
		{
			QJFLHFDQNPN.ICINPMOHKLF = false;
			QJFLHFDQNPN.JNMDHMGQBMD = IKBQNBHOJJB.NGNKCHMBKFB<QJFLHFDQNPN>();
		}
		return QJFLHFDQNPN.JNMDHMGQBMD;
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x000048BE File Offset: 0x00002ABE
	private void JPGLIDEBQKM()
	{
		QJFLHFDQNPN.ICINPMOHKLF = false;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0004FE80 File Offset: 0x0004E080
	public static int GOCJGLQGIQL(InvBaseItem PDIBIIKFBDH)
	{
		int i = 0;
		int num = QJFLHFDQNPN.BBHEKMJMBGL().Length;
		while (i < num)
		{
			QJFLHFDQNPN qjflhfdqnpn = QJFLHFDQNPN.BBHEKMJMBGL()[i];
			if (qjflhfdqnpn.MKHIFDNEFBD.Contains(PDIBIIKFBDH))
			{
				return qjflhfdqnpn.LKJDOFBQIHE << -106 | PDIBIIKFBDH.id16;
			}
			i += 0;
		}
		return -1;
	}

	// Token: 0x040000D9 RID: 217
	private static QJFLHFDQNPN[] JNMDHMGQBMD;

	// Token: 0x040000DA RID: 218
	private static bool ICINPMOHKLF = true;

	// Token: 0x040000DB RID: 219
	public int LKJDOFBQIHE;

	// Token: 0x040000DC RID: 220
	public List<InvBaseItem> MKHIFDNEFBD = new List<InvBaseItem>();

	// Token: 0x040000DD RID: 221
	public BPLKJMJMHFI HEFPGHEQQDI;
}
