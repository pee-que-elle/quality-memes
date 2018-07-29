using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020001E1 RID: 481
public class QJDPLGKKBQG : MonoBehaviour
{
	// Token: 0x06003EA0 RID: 16032 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int DLDJJFGEEIQ(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x0001A073 File Offset: 0x00018273
	public void MMECHIQBCEB(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x00002300 File Offset: 0x00000500
	private void OLLNOFNEEIL()
	{
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int FKNDNIQPFDK(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int IHLFKCOKIPO(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x00002300 File Offset: 0x00000500
	private void KPKQNOCFGIB()
	{
	}

	// Token: 0x06003EA6 RID: 16038 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int FIEMEEPBEOB(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x00002300 File Offset: 0x00000500
	private void MGBMNEQCEBJ()
	{
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x0001A073 File Offset: 0x00018273
	public void NKEJGDPFDOK(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x001E7ED4 File Offset: 0x001E60D4
	public void JNOPFGENBMO(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = true;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i++)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.CHKKBPEJFJN);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k += 0)
				{
					list[j].GMPPOEHCOCN[k].LGCLGHDGNPM = list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k];
				}
			}
			num += list[j].EJQLMNMBJQP + 0;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].NDJBGPLHKJB(BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l]);
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EAA RID: 16042 RVA: 0x001E8150 File Offset: 0x001E6350
	public void MMKEPJCQGFD(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 0)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.FKNDNIQPFDK);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 0;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 0)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l++)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].NDJBGPLHKJB(BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l]);
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EAB RID: 16043 RVA: 0x001E83CC File Offset: 0x001E65CC
	public void PDEJNQQPCEJ(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 0)
		{
			return;
		}
		bool flag = true;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 0; i < this.DCEIKONDCGO.Count; i++)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.EFCNFQDKJOO);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 1; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].LGCLGHDGNPM = list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k];
				}
			}
			num += list[j].EJQLMNMBJQP + 0;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EAC RID: 16044 RVA: 0x0001A073 File Offset: 0x00018273
	public void IPDHQPLBNFQ(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EAD RID: 16045 RVA: 0x0001A073 File Offset: 0x00018273
	public void GEMQKHFCILM(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EAF RID: 16047 RVA: 0x00002300 File Offset: 0x00000500
	private void CIJOENOQKCI()
	{
	}

	// Token: 0x06003EB0 RID: 16048 RVA: 0x0001A073 File Offset: 0x00018273
	public void FBDKEHOOJLE(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EB1 RID: 16049 RVA: 0x00002300 File Offset: 0x00000500
	private void PFQDFBHEJEH()
	{
	}

	// Token: 0x06003EB2 RID: 16050 RVA: 0x001E8648 File Offset: 0x001E6848
	public void CLBDMIQCBPM(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = false;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 0; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.CHKKBPEJFJN);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 1)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k += 0)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 0;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 0)
			{
				for (int l = 0; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l++)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EB3 RID: 16051 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int MIBEGIMDOKD(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EB4 RID: 16052 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int EFEHMFKMDJJ(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EB5 RID: 16053 RVA: 0x0001A073 File Offset: 0x00018273
	public void FOICNMDCHNP(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EB6 RID: 16054 RVA: 0x00002300 File Offset: 0x00000500
	private void OGQBIPQNIQD()
	{
	}

	// Token: 0x06003EB7 RID: 16055 RVA: 0x001E88C4 File Offset: 0x001E6AC4
	public void NNPKMMOKEOF(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = true;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = false;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i++)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 0)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.BBKMKOGONHI);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 1)
			{
				for (int k = 1; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 0; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EB8 RID: 16056 RVA: 0x0001A073 File Offset: 0x00018273
	public void KDFDPONEHDC(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EB9 RID: 16057 RVA: 0x0001A073 File Offset: 0x00018273
	public void LHQECHHMOGD(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EBA RID: 16058 RVA: 0x00002300 File Offset: 0x00000500
	private void KONKOQLPONQ()
	{
	}

	// Token: 0x06003EBB RID: 16059 RVA: 0x00002300 File Offset: 0x00000500
	private void PGFHJKDGEMJ()
	{
	}

	// Token: 0x06003EBC RID: 16060 RVA: 0x00002300 File Offset: 0x00000500
	private void LMELGHDGJMQ()
	{
	}

	// Token: 0x06003EBD RID: 16061 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int OBBNGENBHKP(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EBE RID: 16062 RVA: 0x0001A073 File Offset: 0x00018273
	public void DHJMGLQCQMJ(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EBF RID: 16063 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	[CompilerGenerated]
	private static int EFCNFQDKJOO(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EC0 RID: 16064 RVA: 0x001E8B40 File Offset: 0x001E6D40
	public void BNHNIGFLEGP(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 0)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.QICONJFGCEQ);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 0;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].NDJBGPLHKJB(BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l]);
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EC1 RID: 16065 RVA: 0x001E8DBC File Offset: 0x001E6FBC
	public void LQOEIGQOLNL(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = true;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = false;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 0; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 0)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.EFCNFQDKJOO);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 1; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].LGCLGHDGNPM = list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k];
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].NDJBGPLHKJB(BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l]);
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EC2 RID: 16066 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int BBKMKOGONHI(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EC3 RID: 16067 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int QICONJFGCEQ(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EC4 RID: 16068 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int PJEBFKGPMBK(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x001E9038 File Offset: 0x001E7238
	public void MHNHFMPLENQ(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i++)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.FIEMEEPBEOB);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 0; j < list.Count; j += 0)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 1)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EC6 RID: 16070 RVA: 0x001E92B4 File Offset: 0x001E74B4
	public void QGPOGIQIGBG(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = true;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = false;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 1; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 0)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.PJEBFKGPMBK);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j += 0)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].NDJBGPLHKJB(list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k]);
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 0)
			{
				for (int l = 1; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l++)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].NDJBGPLHKJB(BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l]);
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003EC7 RID: 16071 RVA: 0x00002300 File Offset: 0x00000500
	private void IKHIQQKHILB()
	{
	}

	// Token: 0x06003EC8 RID: 16072 RVA: 0x0001A073 File Offset: 0x00018273
	public void MMCOMNEFNPO(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003EC9 RID: 16073 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x001E9530 File Offset: 0x001E7730
	public void EDPBCEKCQBG(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = false;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 0; i < this.DCEIKONDCGO.Count; i += 0)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.MIBEGIMDOKD);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 1; j < list.Count; j += 0)
		{
			list[j].QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 1)
			{
				for (int k = 1; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].LGCLGHDGNPM = list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k];
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.NDJBGPLHKJB(num);
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 1)
			{
				for (int l = 0; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l += 0)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x0001A073 File Offset: 0x00018273
	public void MKOHOOGGFLK(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003ECC RID: 16076 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int PCJOLLMGMGO(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x06003ECD RID: 16077 RVA: 0x00002300 File Offset: 0x00000500
	private void BBGHCDGEDEJ()
	{
	}

	// Token: 0x06003ECE RID: 16078 RVA: 0x0001A073 File Offset: 0x00018273
	public void HHEDNDKKCHP(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003ECF RID: 16079 RVA: 0x00002300 File Offset: 0x00000500
	private void JPNMOLDKPQP()
	{
	}

	// Token: 0x06003ED0 RID: 16080 RVA: 0x001E97AC File Offset: 0x001E79AC
	public void NDIJIFHOMJC(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
		if (this.DCEIKONDCGO.Count < 1)
		{
			return;
		}
		bool flag = false;
		if (BCHNDNICINJ.OBCNMKNGFIF)
		{
			flag = true;
		}
		List<KIQKEMNELKN> list = new List<KIQKEMNELKN>();
		for (int i = 0; i < this.DCEIKONDCGO.Count; i++)
		{
			if (this.DCEIKONDCGO[i] != null)
			{
				if (flag)
				{
					if (this.DCEIKONDCGO[i].OBCNMKNGFIF)
					{
						list.Add(this.DCEIKONDCGO[i]);
					}
				}
				else if (!this.DCEIKONDCGO[i].OBCNMKNGFIF)
				{
					list.Add(this.DCEIKONDCGO[i]);
				}
			}
		}
		foreach (KIQKEMNELKN kiqkemnelkn in this.DCEIKONDCGO)
		{
			if (kiqkemnelkn == null)
			{
				list.Remove(kiqkemnelkn);
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		List<KIQKEMNELKN> list2 = list;
		if (QJDPLGKKBQG.HNCJFHJNHDN == null)
		{
			QJDPLGKKBQG.HNCJFHJNHDN = new Comparison<KIQKEMNELKN>(QJDPLGKKBQG.EFCNFQDKJOO);
		}
		list2.Sort(QJDPLGKKBQG.HNCJFHJNHDN);
		int num = this.MGQNJBDQQPC;
		if (flag)
		{
			num = this.NMDPJMDBOEQ;
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (list[j].GMPPOEHCOCN != null && list[j].GMPPOEHCOCN.Length > 0)
			{
				for (int k = 0; k < list[j].GMPPOEHCOCN.Length; k++)
				{
					list[j].GMPPOEHCOCN[k].LGCLGHDGNPM = list[j].QPPGQJFBPMH.LGCLGHDGNPM + list[j].NJCNKIPEBPP[k];
				}
			}
			num += list[j].EJQLMNMBJQP + 1;
		}
		if (BCHNDNICINJ != null)
		{
			BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM = num;
			if (BCHNDNICINJ.GMPPOEHCOCN != null && BCHNDNICINJ.GMPPOEHCOCN.Length > 0)
			{
				for (int l = 0; l < BCHNDNICINJ.GMPPOEHCOCN.Length; l++)
				{
					BCHNDNICINJ.GMPPOEHCOCN[l].LGCLGHDGNPM = BCHNDNICINJ.QPPGQJFBPMH.LGCLGHDGNPM + BCHNDNICINJ.NJCNKIPEBPP[l];
				}
			}
			num += BCHNDNICINJ.EJQLMNMBJQP;
		}
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x0001A073 File Offset: 0x00018273
	public void OLEIBKDCFPB(KIQKEMNELKN BCHNDNICINJ)
	{
		if (!this.DCEIKONDCGO.Contains(BCHNDNICINJ))
		{
			this.DCEIKONDCGO.Add(BCHNDNICINJ);
		}
	}

	// Token: 0x06003ED2 RID: 16082 RVA: 0x001E7EA8 File Offset: 0x001E60A8
	private static int CHKKBPEJFJN(KIQKEMNELKN DGKOIGOLHDM, KIQKEMNELKN DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.QPPGQJFBPMH.LGCLGHDGNPM.CompareTo(DDLQKFDFMCJ.QPPGQJFBPMH.LGCLGHDGNPM);
	}

	// Token: 0x04000DDE RID: 3550
	public List<KIQKEMNELKN> DCEIKONDCGO = new List<KIQKEMNELKN>();

	// Token: 0x04000DDF RID: 3551
	private int MGQNJBDQQPC = 210;

	// Token: 0x04000DE0 RID: 3552
	private int NMDPJMDBOEQ = 650;

	// Token: 0x04000DE1 RID: 3553
	[CompilerGenerated]
	private static Comparison<KIQKEMNELKN> HNCJFHJNHDN;
}
