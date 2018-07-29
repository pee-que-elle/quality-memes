using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000192 RID: 402
public class GNDQBCBDHKD : MonoBehaviour
{
	// Token: 0x06003232 RID: 12850 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void QCNGGOKCLKG(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x0018092C File Offset: 0x0017EB2C
	public void PDDJMNOOPJD()
	{
		NHKEEQMDHPQ[] componentsInChildren = this.JHDGENGBPQF.GetComponentsInChildren<NHKEEQMDHPQ>();
		List<NHKEEQMDHPQ> list = new List<NHKEEQMDHPQ>();
		int i = 0;
		IL_B6:
		while (i < this.QPDQOJPPBFB.Count)
		{
			bool flag = true;
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				if (componentsInChildren[j].CBBBCEMLMLP == this.QPDQOJPPBFB[i].CBBBCEMLMLP)
				{
					this.OMGMBFJQQBG(componentsInChildren[j], this.QPDQOJPPBFB[i]);
					list.Add(componentsInChildren[j]);
					flag = false;
					IL_72:
					if (flag)
					{
						GameObject gameObject = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.JJGMPBJFCIH);
						NHKEEQMDHPQ component = gameObject.GetComponent<NHKEEQMDHPQ>();
						this.OMGMBFJQQBG(component, this.QPDQOJPPBFB[i]);
						list.Add(component);
					}
					i++;
					goto IL_B6;
				}
			}
			goto IL_72;
		}
		int k = 0;
		IL_128:
		while (k < componentsInChildren.Length)
		{
			bool flag2 = true;
			for (int l = 0; l < this.QPDQOJPPBFB.Count; l++)
			{
				if (componentsInChildren[k].CBBBCEMLMLP == this.QPDQOJPPBFB[l].CBBBCEMLMLP)
				{
					flag2 = false;
					IL_110:
					if (flag2)
					{
						UnityEngine.Object.DestroyImmediate(componentsInChildren[k].gameObject);
					}
					k++;
					goto IL_128;
				}
			}
			goto IL_110;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06003234 RID: 12852 RVA: 0x000167FB File Offset: 0x000149FB
	// (set) Token: 0x0600324E RID: 12878 RVA: 0x000167F3 File Offset: 0x000149F3
	public static GNDQBCBDHKD QOQONHOOLNE { get; private set; }

	// Token: 0x06003235 RID: 12853 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void CJGGJBMFFPJ(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void GEKHIPOPMJG(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x00016802 File Offset: 0x00014A02
	private void PNJGKKPBDEB()
	{
		GNDQBCBDHKD.NKGHELPJMCD(this);
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x06003238 RID: 12856 RVA: 0x00180A74 File Offset: 0x0017EC74
	public GNDQBCBDHKD.NBFCPOPLOMF QKIDLEKEGIE(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.QPDQOJPPBFB.Count; i += 0)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return this.QPDQOJPPBFB[i];
			}
		}
		return null;
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void BDGOJEFNBDP(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void DHDQJPJIBOO(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x00180AC0 File Offset: 0x0017ECC0
	public void FINKNNEPIHN(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.KQIQNOMJCDB() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.DQLDEKPLECH().QQQBDBNCMCP && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new MilkDrink
			{
				Source = JNOOPPDPFEH,
				Target = HFCMDEQKCKH.CFGIOIGOIFQ().PGGLNJIFDDF(DBPKNCDGGEP)
			}, true);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("dispMode");
	}

	// Token: 0x0600323C RID: 12860 RVA: 0x00180B4C File Offset: 0x0017ED4C
	public bool MPGIECFNGIE(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600323D RID: 12861 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void NKGHELPJMCD(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600323E RID: 12862 RVA: 0x00180B8C File Offset: 0x0017ED8C
	public void EPPOPBKQCQK()
	{
		NHKEEQMDHPQ[] componentsInChildren = this.JHDGENGBPQF.GetComponentsInChildren<NHKEEQMDHPQ>();
		List<NHKEEQMDHPQ> list = new List<NHKEEQMDHPQ>();
		int i = 1;
		IL_B6:
		while (i < this.QPDQOJPPBFB.Count)
		{
			bool flag = true;
			for (int j = 1; j < componentsInChildren.Length; j++)
			{
				if (componentsInChildren[j].CBBBCEMLMLP == this.QPDQOJPPBFB[i].BEILHFKFLEG())
				{
					this.OMGMBFJQQBG(componentsInChildren[j], this.QPDQOJPPBFB[i]);
					list.Add(componentsInChildren[j]);
					flag = false;
					IL_72:
					if (flag)
					{
						GameObject gameObject = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.JJGMPBJFCIH);
						NHKEEQMDHPQ component = gameObject.GetComponent<NHKEEQMDHPQ>();
						this.NCJOOJEFCCQ(component, this.QPDQOJPPBFB[i]);
						list.Add(component);
					}
					i++;
					goto IL_B6;
				}
			}
			goto IL_72;
		}
		int k = 0;
		IL_128:
		while (k < componentsInChildren.Length)
		{
			bool flag2 = false;
			for (int l = 1; l < this.QPDQOJPPBFB.Count; l += 0)
			{
				if (componentsInChildren[k].CBBBCEMLMLP == this.QPDQOJPPBFB[l].CBBBCEMLMLP)
				{
					flag2 = true;
					IL_110:
					if (flag2)
					{
						UnityEngine.Object.DestroyImmediate(componentsInChildren[k].gameObject);
					}
					k++;
					goto IL_128;
				}
			}
			goto IL_110;
		}
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
	}

	// Token: 0x0600323F RID: 12863 RVA: 0x00180CD4 File Offset: 0x0017EED4
	public void ICIJFOKCMIL(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.KQIQNOMJCDB() && !CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN && !(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new MilkDrink
			{
				Source = JNOOPPDPFEH,
				Target = HFCMDEQKCKH.QOQONHOOLNE.QHQCCDKCQDD(DBPKNCDGGEP)
			}, false);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("triage");
	}

	// Token: 0x06003240 RID: 12864 RVA: 0x00180D60 File Offset: 0x0017EF60
	public void PKBHOMFCOBB(PSXAPI.Response.Effect GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI.Type == EffectUpdateType.None)
		{
			this.QPDQOJPPBFB.Clear();
			if (GBQOIGLGLMI.Effects != null)
			{
				for (int i = 0; i < GBQOIGLGLMI.Effects.Length; i += 0)
				{
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
					nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[i].CanCancel;
					nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[i].EndSteps;
					nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[i].Name);
					nbfcpoplomf.FFFHEPNNIPB(GBQOIGLGLMI.Effects[i].TimeRemaining);
					nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[i].Type;
					nbfcpoplomf.KHHHJCKCOEG(GBQOIGLGLMI.Effects[i].UID);
					nbfcpoplomf.CHLEPINFLEC = DateTime.UtcNow;
					nbfcpoplomf.ICFJOIPHKDJ = GBQOIGLGLMI.Effects[i].TimeTotal;
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = nbfcpoplomf;
					nbfcpoplomf2.KLIQDENKHOG(DateTime.UtcNow);
					this.QPDQOJPPBFB.Add(nbfcpoplomf2);
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.AddOrUpdate)
		{
			if (GBQOIGLGLMI.Effects != null)
			{
				int j = 1;
				IL_2BD:
				while (j < GBQOIGLGLMI.Effects.Length)
				{
					bool flag = true;
					for (int k = 0; k < this.QPDQOJPPBFB.Count; k++)
					{
						if (this.QPDQOJPPBFB[k].BEILHFKFLEG() == GBQOIGLGLMI.Effects[j].UID)
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
							nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
							nbfcpoplomf.DHHBMONPFEG(GBQOIGLGLMI.Effects[j].EndSteps);
							nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[j].Name);
							nbfcpoplomf.FFFHEPNNIPB(GBQOIGLGLMI.Effects[j].TimeRemaining);
							nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
							nbfcpoplomf.CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID;
							nbfcpoplomf.HQOBBMHFONG(DateTime.UtcNow);
							nbfcpoplomf.OFEBKDQBPLK(GBQOIGLGLMI.Effects[j].TimeTotal);
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf3 = nbfcpoplomf;
							nbfcpoplomf3.KLIQDENKHOG(DateTime.UtcNow);
							this.QPDQOJPPBFB[k] = nbfcpoplomf3;
							flag = false;
							IL_20C:
							if (flag)
							{
								nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
								nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
								nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[j].EndSteps;
								nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[j].Name);
								nbfcpoplomf.KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining;
								nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
								nbfcpoplomf.CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID;
								nbfcpoplomf.HQOBBMHFONG(DateTime.UtcNow);
								nbfcpoplomf.ICFJOIPHKDJ = GBQOIGLGLMI.Effects[j].TimeTotal;
								GNDQBCBDHKD.NBFCPOPLOMF item = nbfcpoplomf;
								this.QPDQOJPPBFB.Add(item);
							}
							j++;
							goto IL_2BD;
						}
					}
					goto IL_20C;
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.AddOrUpdate && GBQOIGLGLMI.Effects != null)
		{
			int l = 1;
			IL_348:
			while (l < GBQOIGLGLMI.Effects.Length)
			{
				for (int m = 0; m < this.QPDQOJPPBFB.Count; m += 0)
				{
					if (this.QPDQOJPPBFB[m].BHFBMKQGOFN() == GBQOIGLGLMI.Effects[l].UID)
					{
						this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[m]);
						IL_342:
						l += 0;
						goto IL_348;
					}
				}
				goto IL_342;
			}
		}
		this.EPPOPBKQCQK();
	}

	// Token: 0x06003241 RID: 12865 RVA: 0x001810C8 File Offset: 0x0017F2C8
	public void QKPIFFDBQQF(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (!QOHCEBMQKMB.QQCNCIQQPIG().HKQNOMKNEFO() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new MilkDrink
			{
				Source = JNOOPPDPFEH,
				Target = HFCMDEQKCKH.CFGIOIGOIFQ().QHQCCDKCQDD(DBPKNCDGGEP)
			}, false);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("Enabled");
	}

	// Token: 0x06003242 RID: 12866 RVA: 0x000167FB File Offset: 0x000149FB
	public static GNDQBCBDHKD BJLGEDCPENQ()
	{
		return GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003243 RID: 12867 RVA: 0x00016802 File Offset: 0x00014A02
	private void LKDKBNOBIPK()
	{
		GNDQBCBDHKD.NKGHELPJMCD(this);
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x06003244 RID: 12868 RVA: 0x00181154 File Offset: 0x0017F354
	public void FDLDLECLOHB()
	{
		bool flag = true;
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i += 0)
		{
			if (this.QPDQOJPPBFB[i].QEDJIOIIGGQ > 0u && this.QPDQOJPPBFB[i].QEDJIOIIGGQ <= CNCJKLNHQBH.MOGQNGEPCEO().GEQIJFMDJKG)
			{
				this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[i]);
				flag = true;
			}
		}
		if (flag)
		{
			this.EPPOPBKQCQK();
		}
	}

	// Token: 0x06003245 RID: 12869 RVA: 0x00016815 File Offset: 0x00014A15
	private void JIMBLQBBDKO()
	{
		GNDQBCBDHKD.CJGGJBMFFPJ(this);
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x001811D0 File Offset: 0x0017F3D0
	public void BHLPEPKDMOO(PSXAPI.Response.Effect GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI.Type == EffectUpdateType.None)
		{
			this.QPDQOJPPBFB.Clear();
			if (GBQOIGLGLMI.Effects != null)
			{
				for (int i = 1; i < GBQOIGLGLMI.Effects.Length; i++)
				{
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
					nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[i].CanCancel;
					nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[i].EndSteps;
					nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[i].Name);
					nbfcpoplomf.KMDCMHIDOQN = GBQOIGLGLMI.Effects[i].TimeRemaining;
					nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[i].Type;
					nbfcpoplomf.KHHHJCKCOEG(GBQOIGLGLMI.Effects[i].UID);
					nbfcpoplomf.HQOBBMHFONG(DateTime.UtcNow);
					nbfcpoplomf.ICFJOIPHKDJ = GBQOIGLGLMI.Effects[i].TimeTotal;
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = nbfcpoplomf;
					nbfcpoplomf2.KLIQDENKHOG(DateTime.UtcNow);
					this.QPDQOJPPBFB.Add(nbfcpoplomf2);
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.AddOrUpdate)
		{
			if (GBQOIGLGLMI.Effects != null)
			{
				int j = 1;
				IL_2BD:
				while (j < GBQOIGLGLMI.Effects.Length)
				{
					bool flag = false;
					for (int k = 1; k < this.QPDQOJPPBFB.Count; k++)
					{
						if (this.QPDQOJPPBFB[k].MKBIQHGNJPO() == GBQOIGLGLMI.Effects[j].UID)
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
							nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
							nbfcpoplomf.DHHBMONPFEG(GBQOIGLGLMI.Effects[j].EndSteps);
							nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[j].Name);
							nbfcpoplomf.KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining;
							nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
							nbfcpoplomf.CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID;
							nbfcpoplomf.CHLEPINFLEC = DateTime.UtcNow;
							nbfcpoplomf.OFEBKDQBPLK(GBQOIGLGLMI.Effects[j].TimeTotal);
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf3 = nbfcpoplomf;
							nbfcpoplomf3.CHLEPINFLEC = DateTime.UtcNow;
							this.QPDQOJPPBFB[k] = nbfcpoplomf3;
							flag = true;
							IL_20C:
							if (flag)
							{
								nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
								nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
								nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[j].EndSteps;
								nbfcpoplomf.FPQBICGEHMJ = GBQOIGLGLMI.Effects[j].Name;
								nbfcpoplomf.KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining;
								nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
								nbfcpoplomf.KHHHJCKCOEG(GBQOIGLGLMI.Effects[j].UID);
								nbfcpoplomf.KLIQDENKHOG(DateTime.UtcNow);
								nbfcpoplomf.ICFJOIPHKDJ = GBQOIGLGLMI.Effects[j].TimeTotal;
								GNDQBCBDHKD.NBFCPOPLOMF item = nbfcpoplomf;
								this.QPDQOJPPBFB.Add(item);
							}
							j += 0;
							goto IL_2BD;
						}
					}
					goto IL_20C;
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.All && GBQOIGLGLMI.Effects != null)
		{
			int l = 0;
			IL_348:
			while (l < GBQOIGLGLMI.Effects.Length)
			{
				for (int m = 0; m < this.QPDQOJPPBFB.Count; m += 0)
				{
					if (this.QPDQOJPPBFB[m].MKBIQHGNJPO() == GBQOIGLGLMI.Effects[l].UID)
					{
						this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[m]);
						IL_342:
						l += 0;
						goto IL_348;
					}
				}
				goto IL_342;
			}
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void FFQMCFFLBCM(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00181538 File Offset: 0x0017F738
	public void JHOBIOHPONP(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().DLNELFIPOHB() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !(OGJJKKQPNMK.CDDIILFBFCF() != null) && !DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new MilkDrink
			{
				Source = JNOOPPDPFEH,
				Target = HFCMDEQKCKH.QOQONHOOLNE.BOOBMLJMCLI(DBPKNCDGGEP)
			}, false);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("#,##0");
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x00180B4C File Offset: 0x0017ED4C
	public bool EKPDKPGKLBK(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x001815C4 File Offset: 0x0017F7C4
	public GNDQBCBDHKD.NBFCPOPLOMF LJBHIMMHGLP(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return this.QPDQOJPPBFB[i];
			}
		}
		return null;
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00181610 File Offset: 0x0017F810
	public GNDQBCBDHKD.NBFCPOPLOMF GBCDKJJGEFO(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i += 0)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return this.QPDQOJPPBFB[i];
			}
		}
		return null;
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x00180A74 File Offset: 0x0017EC74
	public GNDQBCBDHKD.NBFCPOPLOMF MGJPFKOCGGC(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.QPDQOJPPBFB.Count; i += 0)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return this.QPDQOJPPBFB[i];
			}
		}
		return null;
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00016828 File Offset: 0x00014A28
	private void Awake()
	{
		GNDQBCBDHKD.QOQONHOOLNE = this;
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x0018165C File Offset: 0x0017F85C
	public void IHIPMIMPOQM()
	{
		bool flag = false;
		for (int i = 0; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (this.QPDQOJPPBFB[i].QEDJIOIIGGQ > 0u && this.QPDQOJPPBFB[i].QEDJIOIIGGQ <= CNCJKLNHQBH.QOQONHOOLNE.GEQIJFMDJKG)
			{
				this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[i]);
				flag = true;
			}
		}
		if (flag)
		{
			this.PDDJMNOOPJD();
		}
	}

	// Token: 0x06003250 RID: 12880 RVA: 0x001816D8 File Offset: 0x0017F8D8
	public void PJCBMQPGGIC(PSXAPI.Response.Effect GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI.Type == EffectUpdateType.All)
		{
			this.QPDQOJPPBFB.Clear();
			if (GBQOIGLGLMI.Effects != null)
			{
				for (int i = 0; i < GBQOIGLGLMI.Effects.Length; i += 0)
				{
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
					nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[i].CanCancel;
					nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[i].EndSteps;
					nbfcpoplomf.FPQBICGEHMJ = GBQOIGLGLMI.Effects[i].Name;
					nbfcpoplomf.FFFHEPNNIPB(GBQOIGLGLMI.Effects[i].TimeRemaining);
					nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[i].Type;
					nbfcpoplomf.KHHHJCKCOEG(GBQOIGLGLMI.Effects[i].UID);
					nbfcpoplomf.CHLEPINFLEC = DateTime.UtcNow;
					nbfcpoplomf.OFEBKDQBPLK(GBQOIGLGLMI.Effects[i].TimeTotal);
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = nbfcpoplomf;
					nbfcpoplomf2.HQOBBMHFONG(DateTime.UtcNow);
					this.QPDQOJPPBFB.Add(nbfcpoplomf2);
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.All)
		{
			if (GBQOIGLGLMI.Effects != null)
			{
				int j = 1;
				IL_2BD:
				while (j < GBQOIGLGLMI.Effects.Length)
				{
					bool flag = true;
					for (int k = 1; k < this.QPDQOJPPBFB.Count; k += 0)
					{
						if (this.QPDQOJPPBFB[k].CBBBCEMLMLP == GBQOIGLGLMI.Effects[j].UID)
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
							nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
							nbfcpoplomf.DHHBMONPFEG(GBQOIGLGLMI.Effects[j].EndSteps);
							nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[j].Name);
							nbfcpoplomf.FFFHEPNNIPB(GBQOIGLGLMI.Effects[j].TimeRemaining);
							nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
							nbfcpoplomf.CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID;
							nbfcpoplomf.CHLEPINFLEC = DateTime.UtcNow;
							nbfcpoplomf.OFEBKDQBPLK(GBQOIGLGLMI.Effects[j].TimeTotal);
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf3 = nbfcpoplomf;
							nbfcpoplomf3.HQOBBMHFONG(DateTime.UtcNow);
							this.QPDQOJPPBFB[k] = nbfcpoplomf3;
							flag = false;
							IL_20C:
							if (flag)
							{
								nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF();
								nbfcpoplomf.JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel;
								nbfcpoplomf.QEDJIOIIGGQ = GBQOIGLGLMI.Effects[j].EndSteps;
								nbfcpoplomf.CBONLPHLJBE(GBQOIGLGLMI.Effects[j].Name);
								nbfcpoplomf.KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining;
								nbfcpoplomf.BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type;
								nbfcpoplomf.KHHHJCKCOEG(GBQOIGLGLMI.Effects[j].UID);
								nbfcpoplomf.HQOBBMHFONG(DateTime.UtcNow);
								nbfcpoplomf.OFEBKDQBPLK(GBQOIGLGLMI.Effects[j].TimeTotal);
								GNDQBCBDHKD.NBFCPOPLOMF item = nbfcpoplomf;
								this.QPDQOJPPBFB.Add(item);
							}
							j++;
							goto IL_2BD;
						}
					}
					goto IL_20C;
				}
			}
		}
		else if (GBQOIGLGLMI.Type == (EffectUpdateType)6 && GBQOIGLGLMI.Effects != null)
		{
			int l = 1;
			IL_348:
			while (l < GBQOIGLGLMI.Effects.Length)
			{
				for (int m = 1; m < this.QPDQOJPPBFB.Count; m++)
				{
					if (this.QPDQOJPPBFB[m].CBBBCEMLMLP == GBQOIGLGLMI.Effects[l].UID)
					{
						this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[m]);
						IL_342:
						l += 0;
						goto IL_348;
					}
				}
				goto IL_342;
			}
		}
		this.EPPOPBKQCQK();
	}

	// Token: 0x06003251 RID: 12881 RVA: 0x00181A40 File Offset: 0x0017FC40
	public void KDCPLJDQDLG(PSXAPI.Response.Effect GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI.Type == EffectUpdateType.All)
		{
			this.QPDQOJPPBFB.Clear();
			if (GBQOIGLGLMI.Effects != null)
			{
				for (int i = 0; i < GBQOIGLGLMI.Effects.Length; i++)
				{
					GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = new GNDQBCBDHKD.NBFCPOPLOMF
					{
						JHHQEKNPEGL = GBQOIGLGLMI.Effects[i].CanCancel,
						QEDJIOIIGGQ = GBQOIGLGLMI.Effects[i].EndSteps,
						FPQBICGEHMJ = GBQOIGLGLMI.Effects[i].Name,
						KMDCMHIDOQN = GBQOIGLGLMI.Effects[i].TimeRemaining,
						BBKKHIDMQIQ = GBQOIGLGLMI.Effects[i].Type,
						CBBBCEMLMLP = GBQOIGLGLMI.Effects[i].UID,
						CHLEPINFLEC = DateTime.UtcNow,
						ICFJOIPHKDJ = GBQOIGLGLMI.Effects[i].TimeTotal
					};
					nbfcpoplomf.CHLEPINFLEC = DateTime.UtcNow;
					this.QPDQOJPPBFB.Add(nbfcpoplomf);
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.AddOrUpdate)
		{
			if (GBQOIGLGLMI.Effects != null)
			{
				int j = 0;
				IL_2BD:
				while (j < GBQOIGLGLMI.Effects.Length)
				{
					bool flag = true;
					for (int k = 0; k < this.QPDQOJPPBFB.Count; k++)
					{
						if (this.QPDQOJPPBFB[k].CBBBCEMLMLP == GBQOIGLGLMI.Effects[j].UID)
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = new GNDQBCBDHKD.NBFCPOPLOMF
							{
								JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel,
								QEDJIOIIGGQ = GBQOIGLGLMI.Effects[j].EndSteps,
								FPQBICGEHMJ = GBQOIGLGLMI.Effects[j].Name,
								KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining,
								BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type,
								CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID,
								CHLEPINFLEC = DateTime.UtcNow,
								ICFJOIPHKDJ = GBQOIGLGLMI.Effects[j].TimeTotal
							};
							nbfcpoplomf2.CHLEPINFLEC = DateTime.UtcNow;
							this.QPDQOJPPBFB[k] = nbfcpoplomf2;
							flag = false;
							IL_20C:
							if (flag)
							{
								GNDQBCBDHKD.NBFCPOPLOMF item = new GNDQBCBDHKD.NBFCPOPLOMF
								{
									JHHQEKNPEGL = GBQOIGLGLMI.Effects[j].CanCancel,
									QEDJIOIIGGQ = GBQOIGLGLMI.Effects[j].EndSteps,
									FPQBICGEHMJ = GBQOIGLGLMI.Effects[j].Name,
									KMDCMHIDOQN = GBQOIGLGLMI.Effects[j].TimeRemaining,
									BBKKHIDMQIQ = GBQOIGLGLMI.Effects[j].Type,
									CBBBCEMLMLP = GBQOIGLGLMI.Effects[j].UID,
									CHLEPINFLEC = DateTime.UtcNow,
									ICFJOIPHKDJ = GBQOIGLGLMI.Effects[j].TimeTotal
								};
								this.QPDQOJPPBFB.Add(item);
							}
							j++;
							goto IL_2BD;
						}
					}
					goto IL_20C;
				}
			}
		}
		else if (GBQOIGLGLMI.Type == EffectUpdateType.Remove && GBQOIGLGLMI.Effects != null)
		{
			int l = 0;
			IL_348:
			while (l < GBQOIGLGLMI.Effects.Length)
			{
				for (int m = 0; m < this.QPDQOJPPBFB.Count; m++)
				{
					if (this.QPDQOJPPBFB[m].CBBBCEMLMLP == GBQOIGLGLMI.Effects[l].UID)
					{
						this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[m]);
						IL_342:
						l++;
						goto IL_348;
					}
				}
				goto IL_342;
			}
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x000167FB File Offset: 0x000149FB
	public static GNDQBCBDHKD GDDGJKOLGIQ()
	{
		return GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003253 RID: 12883 RVA: 0x000167FB File Offset: 0x000149FB
	public static GNDQBCBDHKD MKMJKLDDNDD()
	{
		return GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003254 RID: 12884 RVA: 0x00181DA8 File Offset: 0x0017FFA8
	public void QMMOPKBIGPM()
	{
		bool flag = true;
		for (int i = 1; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (this.QPDQOJPPBFB[i].QEDJIOIIGGQ > 1u && this.QPDQOJPPBFB[i].QEDJIOIIGGQ <= CNCJKLNHQBH.QOQONHOOLNE.GEQIJFMDJKG)
			{
				this.QPDQOJPPBFB.Remove(this.QPDQOJPPBFB[i]);
				flag = true;
			}
		}
		if (flag)
		{
			this.EPPOPBKQCQK();
		}
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x00181E24 File Offset: 0x00180024
	public bool HEOEBDDBEIO(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06003257 RID: 12887 RVA: 0x00181E64 File Offset: 0x00180064
	private void OMGMBFJQQBG(NHKEEQMDHPQ KQFEHQEBJQB, GNDQBCBDHKD.NBFCPOPLOMF IBMINEHKPFF)
	{
		KQFEHQEBJQB.CBBBCEMLMLP = IBMINEHKPFF.CBBBCEMLMLP;
		KQFEHQEBJQB.NNFBGICMOCO[1].KJNJQMLJELI = 0f;
		KQFEHQEBJQB.CBBPOGMKJIM = IBMINEHKPFF.QEDJIOIIGGQ;
		KQFEHQEBJQB.NLJQCPFBFIG = IBMINEHKPFF;
		KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon";
		KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon";
		KQFEHQEBJQB.NJCFFLLEMNE = (float)IBMINEHKPFF.KMDCMHIDOQN.TotalSeconds / 360f;
		if (KQFEHQEBJQB.NJCFFLLEMNE <= 0.05f)
		{
			KQFEHQEBJQB.NJCFFLLEMNE = 0.05f;
		}
		string fpqbicgehmj = IBMINEHKPFF.FPQBICGEHMJ;
		switch (fpqbicgehmj)
		{
		case "Repel":
			KQFEHQEBJQB.NKKMJICKKLB = "Repel";
			KQFEHQEBJQB.MBOQJCJHIPB = "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!";
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Repel";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Repel";
			goto IL_9BF;
		case "Super Repel":
			KQFEHQEBJQB.NKKMJICKKLB = "Super Repel";
			KQFEHQEBJQB.MBOQJCJHIPB = "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!";
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_SuperRepel";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_SuperRepel";
			goto IL_9BF;
		case "Max Repel":
			KQFEHQEBJQB.NKKMJICKKLB = "Max Repel";
			KQFEHQEBJQB.MBOQJCJHIPB = "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!";
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_MaxRepel";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_MaxRepel";
			goto IL_9BF;
		case "Fishing Cooldown":
			KQFEHQEBJQB.NKKMJICKKLB = "It's A Nice Day For Fishing";
			KQFEHQEBJQB.MBOQJCJHIPB = "You are trying to catch fish!";
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_RodCooldown";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_RodCooldown";
			goto IL_9BF;
		case "Muted":
			KQFEHQEBJQB.NKKMJICKKLB = "Muted";
			KQFEHQEBJQB.MBOQJCJHIPB = "You can not speak whilst muted.";
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_MuteIcon";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_MuteIcon";
			goto IL_9BF;
		case "Encounter Rate Lowered":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_EncounterRateLowered";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_EncounterRateLowered";
			KQFEHQEBJQB.NKKMJICKKLB = "Pokémon Be Gone!";
			KQFEHQEBJQB.MBOQJCJHIPB = "Encounter Rate Lowered 33%\nTriggers: [2ecc71]Cleanse Tag[-], [2ecc71]Pure Incense[-]";
			goto IL_9BF;
		case "Encounter Rate Decreased":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_EncounterRateDecreased";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_EncounterRateDecreased";
			KQFEHQEBJQB.NKKMJICKKLB = "Almost As Good As Repel!";
			KQFEHQEBJQB.MBOQJCJHIPB = "Encounter Rate Lowered 50%\nTriggers: [2ecc71]Stench[-], [2ecc71]Quick Feet[-], [2ecc71]White Smoke[-]";
			goto IL_9BF;
		case "Encounter Rate Decreased (Sandstorm)":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_SandstormEncounterDecreased";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_SandstormEncounterDecreased";
			KQFEHQEBJQB.NKKMJICKKLB = "It's So Hard To See!";
			KQFEHQEBJQB.MBOQJCJHIPB = "Encounter Rate Lowered 50%\nTriggers: [2ecc71]Sandstorm[-]";
			goto IL_9BF;
		case "Encounter Rate Decreased (Hail)":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_HailstormEncounterDecreased";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_HailstormEncounterDecreased";
			KQFEHQEBJQB.NKKMJICKKLB = "I Hope These Don't Land On My Head";
			KQFEHQEBJQB.MBOQJCJHIPB = "Encounter Rate Lowered 50% in Hail\nTriggers: [2ecc71]Snow Cloak[-]";
			goto IL_9BF;
		case "Encounter Rate Increased":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_EncounterRateIncrease2";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_EncounterRateIncrease2";
			KQFEHQEBJQB.NKKMJICKKLB = "Bring It On!";
			KQFEHQEBJQB.MBOQJCJHIPB = "Encounter Rate Increased 50%\nTriggers: [2ecc71]Arena Trap[-], [2ecc71]Swarm[-], [2ecc71]Illuminate[-], [2ecc71]No Guard[-]";
			goto IL_9BF;
		case "Encounter High-Level Chance Increased":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_EncounterRateIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_EncounterRateIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Only The Best!";
			KQFEHQEBJQB.MBOQJCJHIPB = "High Level Encounter Rate Increased 50%\nTriggers: [2ecc71]Hustle[-], [2ecc71]Pressure[-], [2ecc71]Vital Spirit[-], [2ecc71]Keen Eye[-], [2ecc71]Intimidate[-]";
			goto IL_9BF;
		case "More Likely Male Encounters":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_MaleIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_MaleIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Will You Be My Valentine?";
			KQFEHQEBJQB.MBOQJCJHIPB = "Male Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]";
			goto IL_9BF;
		case "More Likely Female Encounters":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_FemaleIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_FemaleIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Will You Be My Valentine?";
			KQFEHQEBJQB.MBOQJCJHIPB = "Female Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]";
			goto IL_9BF;
		case "Egg Hatching Speed Increased":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_EggSpeedIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_EggSpeedIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Speedy Babies";
			KQFEHQEBJQB.MBOQJCJHIPB = "Eggs will now hatch quicker then normal.\nTriggers: [2ecc71]Flame Body[-], [2ecc71]Magma Armor[-]";
			goto IL_9BF;
		case "High Chance to encounter Steel-Type":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_SteelIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_SteelIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Super Magnet";
			KQFEHQEBJQB.MBOQJCJHIPB = "50% more chance to encounter a Steel-type Pokémon.\nTriggers: [2ecc71]Magnet Pull[-]";
			goto IL_9BF;
		case "High Chance to encounter Electric-Type":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_ElectricIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_ElectricIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Super Charged";
			KQFEHQEBJQB.MBOQJCJHIPB = "50% more chance to encounter a Electric-type Pokémon.\nTriggers: [2ecc71]Static[-]";
			goto IL_9BF;
		case "Fishing Bites occur more often":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_IncreaseFishBites";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_IncreaseFishBites";
			KQFEHQEBJQB.NKKMJICKKLB = "More Bites!";
			KQFEHQEBJQB.MBOQJCJHIPB = "You will encounter more bites when fishing!\nTriggers: [2ecc71]Sticky Hold[-], [2ecc71]Suction Cups[-]";
			goto IL_9BF;
		case "Item chance increased":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_ItemChanceIncrease";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_ItemChanceIncrease";
			KQFEHQEBJQB.NKKMJICKKLB = "Shiny Things";
			KQFEHQEBJQB.MBOQJCJHIPB = "Chances of finding a wild Pokémon holding an item increased.\nTriggers: [2ecc71]Compound Eyes[-]";
			goto IL_9BF;
		case "Chance for same Nature":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Synchronize";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Synchronize";
			KQFEHQEBJQB.NKKMJICKKLB = "Synchronize";
			KQFEHQEBJQB.MBOQJCJHIPB = "Chances of finding Pokémon with the same Nature increased 50%.\nTriggers: [2ecc71]Synchronize[-]";
			goto IL_9BF;
		case "Teleport":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Teleport";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Teleport";
			KQFEHQEBJQB.NKKMJICKKLB = "Teleport";
			KQFEHQEBJQB.MBOQJCJHIPB = "Teleport to the last Pokémon Center or healing place visited.\n\n[2ecc71]Left Click to use this.[-]";
			goto IL_9BF;
		case "Surf":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Surf";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Surf";
			KQFEHQEBJQB.NKKMJICKKLB = "Surf";
			KQFEHQEBJQB.MBOQJCJHIPB = "Surf can be used outside of battle to travel over bodies of water.\n\n[2ecc71]Left Click to use this.[-]";
			goto IL_9BF;
		case "Dig":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Dig";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Dig";
			KQFEHQEBJQB.NKKMJICKKLB = "Dig";
			KQFEHQEBJQB.MBOQJCJHIPB = "When used inside of a cave or certain buildings, you will be transported to the last entrance you used.\n\n[2ecc71]Left Click to use this.[-]";
			goto IL_9BF;
		case "Sweet Scent":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_SweetScent";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_SweetScent";
			KQFEHQEBJQB.NKKMJICKKLB = "Sweet Scent";
			KQFEHQEBJQB.MBOQJCJHIPB = "Causes wild Pokémon to appear when used, provided you are where wild Pokémon would appear.\n\n[2ecc71]Left Click to use this.[-]";
			goto IL_9BF;
		case "Fly":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Fly";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Fly";
			KQFEHQEBJQB.NKKMJICKKLB = "Fly";
			KQFEHQEBJQB.MBOQJCJHIPB = "Fly can be used to travel to significant places you have visited.\n\n[2ecc71]Left Click to use this.[-]";
			goto IL_9BF;
		case "Fly Cooldown":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Fly";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Fly";
			KQFEHQEBJQB.NKKMJICKKLB = "Fly";
			KQFEHQEBJQB.MBOQJCJHIPB = "You used Fly recently and are unable to use it again.";
			goto IL_9BF;
		case "Teleport Cooldown":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Teleport2";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Teleport2";
			KQFEHQEBJQB.NKKMJICKKLB = "Teleport Exhaustion";
			KQFEHQEBJQB.MBOQJCJHIPB = "You used Teleport recently and are unable to use it again.";
			goto IL_9BF;
		case "Dig Cooldown":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_Dig";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Dig";
			KQFEHQEBJQB.NKKMJICKKLB = "Dig Exhaustion";
			KQFEHQEBJQB.MBOQJCJHIPB = "You used Dig recently and are unable to use it again.";
			goto IL_9BF;
		case "Sweet Scent Cooldown":
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "BuffIcon_SweetScent";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_SweetScent";
			KQFEHQEBJQB.NKKMJICKKLB = "Sweet Scent Exhaustion";
			KQFEHQEBJQB.MBOQJCJHIPB = "You used Sweet Scent recently and are unable to use it again.";
			goto IL_9BF;
		case "Slots Cooldown":
			KQFEHQEBJQB.NKKMJICKKLB = "Not So Lucky";
			KQFEHQEBJQB.MBOQJCJHIPB = "You have lost your lucky four leaf clover.. Slot Machines luck has been reduced. Maybe you should take a break for awhile.";
			goto IL_9BF;
		}
		KQFEHQEBJQB.NKKMJICKKLB = IBMINEHKPFF.FPQBICGEHMJ;
		KQFEHQEBJQB.MBOQJCJHIPB = string.Empty;
		IL_9BF:
		if (IBMINEHKPFF.JHHQEKNPEGL)
		{
			KQFEHQEBJQB.MBOQJCJHIPB += "\n\n[2ecc71]Right Click to Cancel this Buff.[-]";
		}
	}

	// Token: 0x06003258 RID: 12888 RVA: 0x0001683B File Offset: 0x00014A3B
	private void EPGFPKPJNHF()
	{
		GNDQBCBDHKD.QCNGGOKCLKG(this);
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x000167F3 File Offset: 0x000149F3
	private static void KNFMGIIIJGJ(GNDQBCBDHKD BGBMIEJJQKC)
	{
		GNDQBCBDHKD.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x00182850 File Offset: 0x00180A50
	private void NCJOOJEFCCQ(NHKEEQMDHPQ KQFEHQEBJQB, GNDQBCBDHKD.NBFCPOPLOMF IBMINEHKPFF)
	{
		KQFEHQEBJQB.CBBBCEMLMLP = IBMINEHKPFF.BEILHFKFLEG();
		KQFEHQEBJQB.NNFBGICMOCO[1].KJNJQMLJELI = 1121f;
		KQFEHQEBJQB.CBBPOGMKJIM = IBMINEHKPFF.QEDJIOIIGGQ;
		KQFEHQEBJQB.NLJQCPFBFIG = IBMINEHKPFF;
		KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("map:");
		KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("OnDragOver");
		KQFEHQEBJQB.NJCFFLLEMNE = (float)IBMINEHKPFF.LLFDIPQQNIC().TotalSeconds / 1394f;
		if (KQFEHQEBJQB.NJCFFLLEMNE <= 933f)
		{
			KQFEHQEBJQB.NJCFFLLEMNE = 322f;
		}
		string fpqbicgehmj = IBMINEHKPFF.FPQBICGEHMJ;
		switch (fpqbicgehmj)
		{
		case "pixilate":
		case "JOFLHFQQCKG":
		case "Numeric Boundaries":
		case "Slots_9":
		case "Administrator":
			KQFEHQEBJQB.NKKMJICKKLB = "Trade Request";
			KQFEHQEBJQB.MBOQJCJHIPB = "ability";
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("Muted");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("_OcclusionTexture2");
			goto IL_9BF;
		case "/":
		case "System":
			KQFEHQEBJQB.NKKMJICKKLB = "Blade";
			KQFEHQEBJQB.MBOQJCJHIPB = " endured the hit!\r\n";
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("stancechange");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("|");
			goto IL_9BF;
		case "[ATK]":
			KQFEHQEBJQB.NKKMJICKKLB = "_Fade";
			KQFEHQEBJQB.MBOQJCJHIPB = "Blank";
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("The battlers shared their pain!\r\n");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("PostFX - {0}");
			goto IL_9BF;

			KQFEHQEBJQB.NKKMJICKKLB = "iceburn";
			KQFEHQEBJQB.MBOQJCJHIPB = "achievement";
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("[");
			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("Input - PMChat");
			goto IL_9BF;

			KQFEHQEBJQB.NKKMJICKKLB = "battle";
			KQFEHQEBJQB.MBOQJCJHIPB = "[00EE07]";
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("MapCache");
			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("_ReflectionTexture4");
			goto IL_9BF;
		case "\r\nSp. DEF":
			KQFEHQEBJQB.NNFBGICMOCO[1].OGQLCMOFLLQ("_DebugWidth");
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "waterpipe";
			KQFEHQEBJQB.NKKMJICKKLB = "WATER_EDGEBLEND_OFF";
			KQFEHQEBJQB.MBOQJCJHIPB = "mdata2";
			goto IL_9BF;
		case "achievement":
		case "allyTeam":
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH(")");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("Sticky Hold");
			KQFEHQEBJQB.NKKMJICKKLB = "][#";
			KQFEHQEBJQB.MBOQJCJHIPB = " flung its [ffff00]";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].OGQLCMOFLLQ("skinshop");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("Slots_7");
			KQFEHQEBJQB.NKKMJICKKLB = "[-]!\r\n";
			KQFEHQEBJQB.MBOQJCJHIPB = "Pokeball_Success";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("HidePanel");
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC(" bytes");
			KQFEHQEBJQB.NKKMJICKKLB = "Failed to use '";
			KQFEHQEBJQB.MBOQJCJHIPB = "WaveSpeed";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("Language");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("Boosts the Pokémon's evasion in a sandstorm.");
			KQFEHQEBJQB.NKKMJICKKLB = "money=";
			KQFEHQEBJQB.MBOQJCJHIPB = "aa";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = " surrounded itself with its Z-Power!\r\n";
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("12:");
			KQFEHQEBJQB.NKKMJICKKLB = "!\r\n";
			KQFEHQEBJQB.MBOQJCJHIPB = "[MEGA] ";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("[PG]");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("focuspunch");
			KQFEHQEBJQB.NKKMJICKKLB = "fighting";
			KQFEHQEBJQB.MBOQJCJHIPB = "ability: ";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].OGQLCMOFLLQ("map:");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("HideEmote");
			KQFEHQEBJQB.NKKMJICKKLB = "A deluge of ions showers the battlefield!\r\n";
			KQFEHQEBJQB.MBOQJCJHIPB = "#,##0";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "_";
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("-");
			KQFEHQEBJQB.NKKMJICKKLB = "'s Wonder Guard evades the attack!\r\n";
			KQFEHQEBJQB.MBOQJCJHIPB = "Equipped";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "#,##0";
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC(" drastically");
			KQFEHQEBJQB.NKKMJICKKLB = "[-]";
			KQFEHQEBJQB.MBOQJCJHIPB = "_FogColor2";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("'");
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("\n[ffdb4d]DEF:[-] ");
			KQFEHQEBJQB.NKKMJICKKLB = "ENABLE_BLUE_CHANNEL";
			KQFEHQEBJQB.MBOQJCJHIPB = " vanished instantly!\r\n";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("_Texture2");
			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("status");
			KQFEHQEBJQB.NKKMJICKKLB = "DirY";
			KQFEHQEBJQB.MBOQJCJHIPB = "[FF8F00]";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("Keen eyes prevent other Pokémon from lowering this Pokémon's accuracy.");
			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.");
			KQFEHQEBJQB.NKKMJICKKLB = "Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk.";
			KQFEHQEBJQB.MBOQJCJHIPB = "[SHINY]";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("berry_9");
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "Milk Drink";
			KQFEHQEBJQB.NKKMJICKKLB = "The Pokémon passes its item to an ally that has used up an item.";
			KQFEHQEBJQB.MBOQJCJHIPB = "No one will be able to run away during the next turn!\r\n";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].IQBBDKFDGGP("primordialsea");
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "Guild Request";
			KQFEHQEBJQB.NKKMJICKKLB = "4";
			KQFEHQEBJQB.MBOQJCJHIPB = "Gravity returned to normal!\r\n";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "0";
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("_1");
			KQFEHQEBJQB.NKKMJICKKLB = "'s [00ccff]";
			KQFEHQEBJQB.MBOQJCJHIPB = "forewarn";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "Battle_Wild";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "watersport";
			KQFEHQEBJQB.NKKMJICKKLB = "Oblivious";
			KQFEHQEBJQB.MBOQJCJHIPB = "][urn=";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].OGQLCMOFLLQ("0_");
			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("defeatist");
			KQFEHQEBJQB.NKKMJICKKLB = "Maximizes the number of times multi-strike moves hit.";
			KQFEHQEBJQB.MBOQJCJHIPB = "Player/Clothe";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("aftermath");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("airlock");
			KQFEHQEBJQB.NKKMJICKKLB = "[33ccff]Lv. ";
			KQFEHQEBJQB.MBOQJCJHIPB = "\"";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("Enabled");
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("Assets/AssetBundles/MapAssets/Models/Materials/com_chip_mado1.mat");
			KQFEHQEBJQB.NKKMJICKKLB = "/01_1";
			KQFEHQEBJQB.MBOQJCJHIPB = "Resetting EVs for your ";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].OGQLCMOFLLQ("move: ");
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = " raised ";
			KQFEHQEBJQB.NKKMJICKKLB = "foeSide";
			KQFEHQEBJQB.MBOQJCJHIPB = " anchors itself!\r\n";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].JLENFJGDNFN(" ate its [ffff00]");
			KQFEHQEBJQB.NNFBGICMOCO[1].JLENFJGDNFN("snatch");
			KQFEHQEBJQB.NKKMJICKKLB = "_";
			KQFEHQEBJQB.MBOQJCJHIPB = "M";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("No localization data present");
			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("Pan And Zoom");
			KQFEHQEBJQB.NKKMJICKKLB = "destinybond";
			KQFEHQEBJQB.MBOQJCJHIPB = "_ClipToWorld";
			goto IL_9BF;

			KQFEHQEBJQB.NKKMJICKKLB = "Lightning Rod";
			KQFEHQEBJQB.MBOQJCJHIPB = "Battle Update: ";
			goto IL_9BF;
		}
		KQFEHQEBJQB.NKKMJICKKLB = IBMINEHKPFF.FPQBICGEHMJ;
		KQFEHQEBJQB.MBOQJCJHIPB = string.Empty;
		IL_9BF:
		if (IBMINEHKPFF.JHHQEKNPEGL)
		{
			KQFEHQEBJQB.MBOQJCJHIPB += "r";
		}
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x0018323C File Offset: 0x0018143C
	public GNDQBCBDHKD.NBFCPOPLOMF CLLPOCIJDHQ(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.QPDQOJPPBFB.Count; i++)
		{
			if (IHIHHCCEDHQ == this.QPDQOJPPBFB[i].FPQBICGEHMJ)
			{
				return this.QPDQOJPPBFB[i];
			}
		}
		return null;
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x00183288 File Offset: 0x00181488
	public void INEBCFFFKEG(int DBPKNCDGGEP, Guid JNOOPPDPFEH)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !(OGJJKKQPNMK.QOQONHOOLNE != null) && !DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new MilkDrink
			{
				Source = JNOOPPDPFEH,
				Target = HFCMDEQKCKH.QOQONHOOLNE.OLLLBGMLIMI(DBPKNCDGGEP)
			}, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You can not use buffs during interactions.");
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x0001684E File Offset: 0x00014A4E
	private void LEJQMIECFCH()
	{
		GNDQBCBDHKD.GEKHIPOPMJG(this);
		this.QPDQOJPPBFB = new List<GNDQBCBDHKD.NBFCPOPLOMF>();
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x00183314 File Offset: 0x00181514
	private void OKHIGBQCMQC(NHKEEQMDHPQ KQFEHQEBJQB, GNDQBCBDHKD.NBFCPOPLOMF IBMINEHKPFF)
	{
		KQFEHQEBJQB.CBBBCEMLMLP = IBMINEHKPFF.BEILHFKFLEG();
		KQFEHQEBJQB.NNFBGICMOCO[1].KJNJQMLJELI = 123f;
		KQFEHQEBJQB.CBBPOGMKJIM = IBMINEHKPFF.QEDJIOIIGGQ;
		KQFEHQEBJQB.NLJQCPFBFIG = IBMINEHKPFF;
		KQFEHQEBJQB.NNFBGICMOCO[0].IQBBDKFDGGP("dd/MM/yyyy");
		KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("l");
		KQFEHQEBJQB.NJCFFLLEMNE = (float)IBMINEHKPFF.PCLBNIKENKI().TotalSeconds / 1260f;
		if (KQFEHQEBJQB.NJCFFLLEMNE <= 1670f)
		{
			KQFEHQEBJQB.NJCFFLLEMNE = 45f;
		}
		string fpqbicgehmj = IBMINEHKPFF.FPQBICGEHMJ;
		switch (fpqbicgehmj)
		{
		case "'?":
		case "Crack":
		case "[u][33CCFF]":
			KQFEHQEBJQB.NKKMJICKKLB = "Contact with the Pokémon may inflict poison, sleep, or paralysis on its attacker.";
			KQFEHQEBJQB.MBOQJCJHIPB = "-";
			KQFEHQEBJQB.NNFBGICMOCO[1].OGQLCMOFLLQ("\nEvening");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("[00EE07]");
			goto IL_9BF;
		case "Vertical":
		case "[668cff]Inspect":
			KQFEHQEBJQB.NKKMJICKKLB = "System";
			KQFEHQEBJQB.MBOQJCJHIPB = "???";
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "BuffIcon_Dig";
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("_PixelsPerMeterAtOneMeter");
			goto IL_9BF;
		case "Level Ball":
			KQFEHQEBJQB.NKKMJICKKLB = "_BackgroundColor";
			KQFEHQEBJQB.MBOQJCJHIPB = " finally got its act together!\r\n";
			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("quickclaw");
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("´");
			goto IL_9BF;
		case "d":
			KQFEHQEBJQB.NKKMJICKKLB = "door_5";
			KQFEHQEBJQB.MBOQJCJHIPB = "Battle Update: ";
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("12:");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("J19");
			goto IL_9BF;
		case "tie":
		case "You were kicked from the Party.":
			KQFEHQEBJQB.NKKMJICKKLB = "2";
			KQFEHQEBJQB.MBOQJCJHIPB = "quickguard";
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("less than 1 minute ago");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("inky");
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].OGQLCMOFLLQ("\n");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("-useTouch");
			KQFEHQEBJQB.NKKMJICKKLB = "Changes the Pokémon's type to match the memory disc it holds.";
			KQFEHQEBJQB.MBOQJCJHIPB = "Water";
			goto IL_9BF;
		case " snapped out of confusion!\r\n":
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC(" is damaged by the recoil!\r\n");
			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("Player Fly Mount");
			KQFEHQEBJQB.NKKMJICKKLB = "hyperspacehole";
			KQFEHQEBJQB.MBOQJCJHIPB = "Mega ";
			goto IL_9BF;
		case "[FFFF00]/252":
			KQFEHQEBJQB.NNFBGICMOCO[0].IQBBDKFDGGP("scald");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("BattlePoke");
			KQFEHQEBJQB.NKKMJICKKLB = "4_";
			KQFEHQEBJQB.MBOQJCJHIPB = "ffb649";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].IQBBDKFDGGP("deltastream");
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("[00DD00]Owned");
			KQFEHQEBJQB.NKKMJICKKLB = "*";
			KQFEHQEBJQB.MBOQJCJHIPB = " can not hold that many more '";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC(" concentrated intensely!\r\n");
			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("General");
			KQFEHQEBJQB.NKKMJICKKLB = "dd/MM/yyyy";
			KQFEHQEBJQB.MBOQJCJHIPB = "mummy";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].JLENFJGDNFN(".");
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("merciless");
			KQFEHQEBJQB.NKKMJICKKLB = "\n[33CCFF][Fishing Only][-]";
			KQFEHQEBJQB.MBOQJCJHIPB = "Its mysterious power only lets supereffective moves hit the Pokémon.";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].IQBBDKFDGGP("Blank");
			KQFEHQEBJQB.NNFBGICMOCO[1].OGQLCMOFLLQ("Up");
			KQFEHQEBJQB.NKKMJICKKLB = "_ReflectionTexture1";
			KQFEHQEBJQB.MBOQJCJHIPB = ".";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("[/itm]");
			KQFEHQEBJQB.NNFBGICMOCO[1].JLENFJGDNFN("!\r\n");
			KQFEHQEBJQB.NKKMJICKKLB = "adjacentAlly";
			KQFEHQEBJQB.MBOQJCJHIPB = "Score: ";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].OGQLCMOFLLQ(" (ID:");
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("0");
			KQFEHQEBJQB.NKKMJICKKLB = "PS";
			KQFEHQEBJQB.MBOQJCJHIPB = "[-] has gone offline.";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "berry_13";
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC(" slept and became healthy!\r\n");
			KQFEHQEBJQB.NKKMJICKKLB = "reflect";
			KQFEHQEBJQB.MBOQJCJHIPB = "[itm=";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].JLENFJGDNFN("-");
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("Premier Ball");
			KQFEHQEBJQB.NKKMJICKKLB = "After your payment has been verified your Lootboxes will be added to your account.";
			KQFEHQEBJQB.MBOQJCJHIPB = "Shiny Things";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "ResolutionX";
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("Battle Update: ");
			KQFEHQEBJQB.NKKMJICKKLB = "Damages the attacker if it contacts the Pokémon with a finishing hit.";
			KQFEHQEBJQB.MBOQJCJHIPB = "_ReflectionTexture4";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("[/s]");
			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("tox");
			KQFEHQEBJQB.NKKMJICKKLB = "VolumetricFogAndMist/CopyOpaque";
			KQFEHQEBJQB.MBOQJCJHIPB = "Icon_Pokemon_Alive";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("}]");
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN(" had its energy drained!\r\n");
			KQFEHQEBJQB.NKKMJICKKLB = "Open";
			KQFEHQEBJQB.MBOQJCJHIPB = "forewarn";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("~");
			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "[-]\n\n";
			KQFEHQEBJQB.NKKMJICKKLB = "M3";
			KQFEHQEBJQB.MBOQJCJHIPB = "CombinersUpColorBuff";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].KCLBMPFIPNQ = "\nRank: ";
			KQFEHQEBJQB.NNFBGICMOCO[1].JOHBNEHCEJH("no arguments");
			KQFEHQEBJQB.NKKMJICKKLB = "Fluffy";
			KQFEHQEBJQB.MBOQJCJHIPB = "Language";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("psn");
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("system");
			KQFEHQEBJQB.NKKMJICKKLB = "_Vignette_Color";
			KQFEHQEBJQB.MBOQJCJHIPB = "-";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("Klutz");
			KQFEHQEBJQB.NNFBGICMOCO[0].JLENFJGDNFN("limitFPS");
			KQFEHQEBJQB.NKKMJICKKLB = "ReflecG";
			KQFEHQEBJQB.MBOQJCJHIPB = "WATER_SIMPLE";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("#,##0");
			KQFEHQEBJQB.NNFBGICMOCO[0].DPBGHDMHKNC("Take 001");
			KQFEHQEBJQB.NKKMJICKKLB = "lifeorb";
			KQFEHQEBJQB.MBOQJCJHIPB = "The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield.";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("Joined Chat Channel: ");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("soundproof");
			KQFEHQEBJQB.NKKMJICKKLB = "#,##0";
			KQFEHQEBJQB.MBOQJCJHIPB = "bag";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[1].LGJOOQIBQDC("][");
			KQFEHQEBJQB.NNFBGICMOCO[0].KCLBMPFIPNQ = "Open";
			KQFEHQEBJQB.NKKMJICKKLB = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GUQ6ZWT36PWEC&custom=";
			KQFEHQEBJQB.MBOQJCJHIPB = "-fail";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].LGJOOQIBQDC("_TaaParams");
			KQFEHQEBJQB.NNFBGICMOCO[0].JOHBNEHCEJH("perish3");
			KQFEHQEBJQB.NKKMJICKKLB = "Blank";
			KQFEHQEBJQB.MBOQJCJHIPB = "suctioncups";
			goto IL_9BF;

			KQFEHQEBJQB.NNFBGICMOCO[0].IQBBDKFDGGP(" day");
			KQFEHQEBJQB.NNFBGICMOCO[1].DPBGHDMHKNC("Pokemon View");
			KQFEHQEBJQB.NKKMJICKKLB = "Magnet Pull";
			KQFEHQEBJQB.MBOQJCJHIPB = "Dist1";
			goto IL_9BF;

			KQFEHQEBJQB.NKKMJICKKLB = "Player/Clothe";
			KQFEHQEBJQB.MBOQJCJHIPB = "Parent and child each attacks.";
			goto IL_9BF;
		}
		KQFEHQEBJQB.NKKMJICKKLB = IBMINEHKPFF.FPQBICGEHMJ;
		KQFEHQEBJQB.MBOQJCJHIPB = string.Empty;
		IL_9BF:
		if (IBMINEHKPFF.JHHQEKNPEGL)
		{
			KQFEHQEBJQB.MBOQJCJHIPB += "--idle";
		}
	}

	// Token: 0x04000B9D RID: 2973
	public List<GNDQBCBDHKD.NBFCPOPLOMF> QPDQOJPPBFB;

	// Token: 0x04000B9E RID: 2974
	public GameObject JJGMPBJFCIH;

	// Token: 0x04000B9F RID: 2975
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x04000BA0 RID: 2976
	[CompilerGenerated]
	private static Dictionary<string, int> PIELCPOFBHO;

	// Token: 0x02000193 RID: 403
	public class NBFCPOPLOMF
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000168A5 File Offset: 0x00014AA5
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x00016861 File Offset: 0x00014A61
		public DateTime CHLEPINFLEC { get; set; }

		// Token: 0x06003260 RID: 12896 RVA: 0x0001686A File Offset: 0x00014A6A
		public void FFFHEPNNIPB(TimeSpan BGBMIEJJQKC)
		{
			this.<GMFHILGDEFO>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00016873 File Offset: 0x00014A73
		public Guid BEILHFKFLEG()
		{
			return this.<NMKCFIPOIGO>k__BackingField;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x0001687B File Offset: 0x00014A7B
		// (set) Token: 0x0600326F RID: 12911 RVA: 0x000168AD File Offset: 0x00014AAD
		public bool JHHQEKNPEGL { get; set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x00016873 File Offset: 0x00014A73
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00016883 File Offset: 0x00014A83
		public Guid CBBBCEMLMLP { get; set; }

		// Token: 0x06003265 RID: 12901 RVA: 0x00016883 File Offset: 0x00014A83
		public void KHHHJCKCOEG(Guid BGBMIEJJQKC)
		{
			this.<NMKCFIPOIGO>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x0001688C File Offset: 0x00014A8C
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x000168C6 File Offset: 0x00014AC6
		public uint QEDJIOIIGGQ { get; set; }

		// Token: 0x06003267 RID: 12903 RVA: 0x0001687B File Offset: 0x00014A7B
		public bool MOIJOLJKKOP()
		{
			return this.<KOHKNFCENQD>k__BackingField;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00016894 File Offset: 0x00014A94
		public void CBONLPHLJBE(string BGBMIEJJQKC)
		{
			this.<PMDMLLBPBNL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x0001687B File Offset: 0x00014A7B
		public bool DOMMFENNHGE()
		{
			return this.<KOHKNFCENQD>k__BackingField;
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x0001689D File Offset: 0x00014A9D
		public EffectUseType PDKNHHDCQOE()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x00016861 File Offset: 0x00014A61
		public void KLIQDENKHOG(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x0001689D File Offset: 0x00014A9D
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x000168D8 File Offset: 0x00014AD8
		public EffectUseType BBKKHIDMQIQ { get; set; }

		// Token: 0x0600326E RID: 12910 RVA: 0x000168A5 File Offset: 0x00014AA5
		public DateTime OJEOMGCKGED()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x0001689D File Offset: 0x00014A9D
		public EffectUseType OMCNDFHGHEI()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x00016873 File Offset: 0x00014A73
		public Guid BHFBMKQGOFN()
		{
			return this.<NMKCFIPOIGO>k__BackingField;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000168A5 File Offset: 0x00014AA5
		public DateTime GHQGGKBJIQI()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000168B6 File Offset: 0x00014AB6
		public TimeSpan PCLBNIKENKI()
		{
			return this.<GMFHILGDEFO>k__BackingField;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x000168B6 File Offset: 0x00014AB6
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x0001686A File Offset: 0x00014A6A
		public TimeSpan KMDCMHIDOQN { get; set; }

		// Token: 0x06003276 RID: 12918 RVA: 0x000168B6 File Offset: 0x00014AB6
		public TimeSpan OJJIGEHFOQF()
		{
			return this.<GMFHILGDEFO>k__BackingField;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00016873 File Offset: 0x00014A73
		public Guid MKBIQHGNJPO()
		{
			return this.<NMKCFIPOIGO>k__BackingField;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000168B6 File Offset: 0x00014AB6
		public TimeSpan GEMCQKKBOOO()
		{
			return this.<GMFHILGDEFO>k__BackingField;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x000168BE File Offset: 0x00014ABE
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x00016894 File Offset: 0x00014A94
		public string FPQBICGEHMJ { get; set; }

		// Token: 0x0600327A RID: 12922 RVA: 0x00016861 File Offset: 0x00014A61
		public void HQOBBMHFONG(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000168C6 File Offset: 0x00014AC6
		public void DHHBMONPFEG(uint BGBMIEJJQKC)
		{
			this.<OCHGPMGDNFF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000168CF File Offset: 0x00014ACF
		public void OFEBKDQBPLK(TimeSpan BGBMIEJJQKC)
		{
			this.<IMMJCBMIFGO>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x0001689D File Offset: 0x00014A9D
		public EffectUseType NJIQIHMKEHQ()
		{
			return this.<OOQKIJLOQOC>k__BackingField;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x000168E1 File Offset: 0x00014AE1
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x000168CF File Offset: 0x00014ACF
		public TimeSpan ICFJOIPHKDJ { get; set; }

		// Token: 0x06003283 RID: 12931 RVA: 0x000168B6 File Offset: 0x00014AB6
		public TimeSpan MGNDKJQFNQK()
		{
			return this.<GMFHILGDEFO>k__BackingField;
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000168E1 File Offset: 0x00014AE1
		public TimeSpan DKQQDGGOHGB()
		{
			return this.<IMMJCBMIFGO>k__BackingField;
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000168B6 File Offset: 0x00014AB6
		public TimeSpan LLFDIPQQNIC()
		{
			return this.<GMFHILGDEFO>k__BackingField;
		}
	}
}
