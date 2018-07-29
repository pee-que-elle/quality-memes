using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x020001FD RID: 509
public class INFJMNPKNQF : MonoBehaviour
{
	// Token: 0x060042F2 RID: 17138 RVA: 0x0020BDE8 File Offset: 0x00209FE8
	public void IIPDEPIPDKH(int COQJPLDFJBB)
	{
		foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
		{
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 1265f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(1942f, true);
		this.JBLQIEPJLPN.KNJDCJDDLDF("[FFFFFF][", 5);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(1476f, true);
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		foreach (CFDMNELIJLO cfdmnelijlo in this.KMDNMJGGDHF)
		{
			cfdmnelijlo.enabled = false;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = false;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		if (this.NGHCPLBPQEC.Count > 1)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.IFFFLJINPPQ > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown || ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.HCOQJPNIEHI("!\r\n", 2).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(1008f, 1518f, 1123f);
						component.gameObject.SetActive(false);
						component.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Pokeball)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.GKNLQNEMKKF("ResolutionY", 6).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(1810f, 1436f, 1603f);
						component2.gameObject.SetActive(false);
						component2.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.HCOQJPNIEHI("26", 7).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(1835f, 449f, 344f);
						component3.gameObject.SetActive(false);
						component3.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.QLGFDFKBHMN() == (ItemCategory)8)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("Core", 3).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(1165f, 1413f, 1567f);
						component4.gameObject.SetActive(true);
						component4.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Machine)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.PEJIFGJPCGD(" is immobilized by love!\r\n", 1).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(339f, 199f, 803f);
						component5.gameObject.SetActive(true);
						component5.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Machine)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.QIQPJQFDBCP("_AllowBackwardsRays", 2).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(440f, 1930f, 1148f);
						component6.gameObject.SetActive(true);
						component6.QMKELEEOHBE(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 5)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Custom;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(qjfqomoiooi, true);
		this.BMFQIHPMEBO.CLQFFBMLIQH = true;
	}

	// Token: 0x060042F3 RID: 17139 RVA: 0x0001CA50 File Offset: 0x0001AC50
	public static INFJMNPKNQF IPOKOKIJECO()
	{
		return INFJMNPKNQF.HBFFCJHOCPE;
	}

	// Token: 0x060042F4 RID: 17140 RVA: 0x0020C308 File Offset: 0x0020A508
	public void LDFEMKIFPOG(PSXAPI.Response.HoldItem BJGCBDNBQCJ)
	{
		base.GetComponent<LINELKKDMEE>().Close();
		if (BJGCBDNBQCJ.Result == HoldItemResult.Failed)
		{
			int num = HFCMDEQKCKH.QOQONHOOLNE.NBLNQGHIKCG(BJGCBDNBQCJ.Pokemon);
			if (num != -1)
			{
				HFCMDEQKCKH.QOQONHOOLNE.LHQQCLOEHJG[num].GECLELHHNIO = BJGCBDNBQCJ.Item;
			}
			HFCMDEQKCKH.CFGIOIGOIFQ().PDDJMNOOPJD();
		}
	}

	// Token: 0x060042F5 RID: 17141 RVA: 0x0020C364 File Offset: 0x0020A564
	public void OQPNKJLOINN(PSXAPI.Response.UseItem CFHEIICNLFD)
	{
		switch (CFHEIICNLFD.Result)
		{
		case UseItemResult.Failed:
			if (CFHEIICNLFD.Item != 8 && CFHEIICNLFD.Item != -164 && CFHEIICNLFD.Item != -143)
			{
				if (CFHEIICNLFD.Item != 30)
				{
					if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CFHEIICNLFD.Pokemon) != null)
					{
						CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
						string[] array = new string[]
						{
							null,
							")\n"
						};
						array[1] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO();
						array[8] = "Powers up each Pokémon's Dark-type moves.";
						array[2] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ);
						array[8] = "[-] strengthened ";
						qoqonhoolne.GQOBKDLOCDL(string.Concat(array));
						break;
					}
					CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("The specified Port " + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).NDPGCGDLEEQ() + "dark");
					break;
				}
			}
			return;
		case UseItemResult.Success:
			if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(CFHEIICNLFD.Pokemon) != null)
			{
				CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.MOGQNGEPCEO();
				string[] array2 = new string[4];
				array2[1] = " returned its status to normal using its [ffff00]White Herb[-]!\r\n";
				array2[1] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).FLFQBGJQBBD();
				array2[0] = "ProCamera2DShakeContainer";
				array2[4] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).EDGHHFPMHBL());
				array2[6] = " seems to have a null sprite!";
				cncjklnhqbh.MIDPIFHNNDK(string.Concat(array2));
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("-ohko" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name + "Right");
			}
			break;
		case UseItemResult.InvalidItem:
		case UseItemResult.InvalidPokemon:
			CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("Boosts the Pokémon's Sp. Atk stat when it takes a hit that causes its HP to become half or less." + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO() + "[/urn][-]: ");
			break;
		}
	}

	// Token: 0x060042F6 RID: 17142 RVA: 0x0020C594 File Offset: 0x0020A794
	public void HDGHLOGHHIK(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Hold Item", string.Concat(new string[]
		{
			"Are you sure you wish to let ",
			KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[DBPKNCDGGEP]).BEQHNFFEHMQ),
			" hold [2ecc71]",
			KGQECFKLKOP.BFNBQBMJHFL(MKBCKPPCIQO.DBPKNCDGGEP).Name,
			"[-]?\n\nOnce you let a Pokémon hold an item you can no longer get it back."
		}), DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, MKBCKPPCIQO, -1, false);
	}

	// Token: 0x060042F7 RID: 17143 RVA: 0x0020C620 File Offset: 0x0020A820
	public void IKNOBIPHNPP(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.OCFGFJMJIGP() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			PSXAPI.Request.HoldItem dcgclgqcgdq = new PSXAPI.Request.HoldItem
			{
				Item = MKBCKPPCIQO.FQOOHOOPFOH(),
				Pokemon = HFCMDEQKCKH.QOQONHOOLNE.FPHJJLLFNPI(DBPKNCDGGEP + 0)
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("torrent");
	}

	// Token: 0x060042F8 RID: 17144 RVA: 0x0020C6A8 File Offset: 0x0020A8A8
	public void OMBKEPGPIGE(PSXAPI.Response.Inventory MNDPFDHJCCH)
	{
		this.LEIODPOMLHC();
		if (MNDPFDHJCCH.Items != null && MNDPFDHJCCH.Items.Length > 1)
		{
			for (int i = 0; i < MNDPFDHJCCH.Items.Length; i += 0)
			{
				KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie = new KGQECFKLKOP.IJHPPMDDKIE();
				ijhppmddkie.JJBLNNNHDJD(MNDPFDHJCCH.Items[i].ItemID);
				ijhppmddkie.BHKGCCEIGLQ(MNDPFDHJCCH.Items[i].Count);
				ijhppmddkie.QJBCNEFKEEJ(MNDPFDHJCCH.Items[i].CanHold);
				ijhppmddkie.JNOBHLDHQBP(MNDPFDHJCCH.Items[i].CanUseOutsideBattle);
				ijhppmddkie.OINGOHBICNQ(MNDPFDHJCCH.Items[i].CanUseInBattle);
				ijhppmddkie.EFIGFPHLPNI(MNDPFDHJCCH.Items[i].CanTrade);
				ijhppmddkie.JILENMCJCHF = MNDPFDHJCCH.Items[i].Target;
				ijhppmddkie.NKJHNBKJFEL(MNDPFDHJCCH.Items[i].Pocket);
				ijhppmddkie.OPLNNPOCQGK(MNDPFDHJCCH.Items[i].Category);
				this.NGHCPLBPQEC.Add(ijhppmddkie);
			}
		}
		this.DFMLMCDHNCM = MNDPFDHJCCH.Badges;
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Money > this.EPDKBQCHOJQ)
		{
			this.ENIDNEOKEPL("General" + (MNDPFDHJCCH.Money - this.EPDKBQCHOJQ).ToString("Slots_9") + "motordrive", 0);
		}
		if (!KOJBBGEINPH.CPLQICHLGCI().QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Gold > this.QIOKIQOBMMB)
		{
			this.DLJJFQOHNGL("Normalize" + (MNDPFDHJCCH.Gold - this.QIOKIQOBMMB).ToString(" can not trade their last active Pokemon.") + "-busted", 1);
		}
		this.EPDKBQCHOJQ = MNDPFDHJCCH.Money;
		this.QIOKIQOBMMB = MNDPFDHJCCH.Gold;
		this.QJBKBGOGFKB.LKPOBCBOFIC(MNDPFDHJCCH.Money.ToString("flash"));
		this.EJHCCNOOBBH.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("[eat]");
		this.IGJNCOHOHMG.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("_FogOfWarCenterAdjusted");
		this.MJQLBCBDPNB.LKPOBCBOFIC(MNDPFDHJCCH.Gold.ToString("/"));
		DNFENPQLICQ.BDPEQNCNPJO().QJBKBGOGFKB.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString(" surrounds itself with a protective mist!\r\n");
		DNFENPQLICQ.JJCONJJNDQN().EJHCCNOOBBH.LKPOBCBOFIC(MNDPFDHJCCH.Gold.ToString("firelamp"));
		QLKJQPNKPBC.PDPCLOECLOF().BMMQCLFBQKG();
		this.CNBFBGHGGND = false;
	}

	// Token: 0x060042F9 RID: 17145 RVA: 0x0020C95C File Offset: 0x0020AB5C
	public void HLDLDLGIIDF(int COQJPLDFJBB)
	{
		foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
		{
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 1296f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HKDJGHOHBFQ();
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(374f, false);
		this.JBLQIEPJLPN.MIECCNEBLPD("skydrop", 7);
		this.BMFQIHPMEBO.PFEIQDIJEKE();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(1770f, true);
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		CFDMNELIJLO[] kmdnmjggdhf = this.KMDNMJGGDHF;
		for (int j = 1; j < kmdnmjggdhf.Length; j++)
		{
			CFDMNELIJLO cfdmnelijlo = kmdnmjggdhf[j];
			cfdmnelijlo.enabled = false;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = false;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.EQCJBDOQDBB() > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.KJLJHGEECPK() == ItemCategory.General || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == (ItemCategory)8))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.GKNLQNEMKKF(" stronger against physical moves!\r\n", 2).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(146f, 826f, 1876f);
						component.gameObject.SetActive(false);
						component.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.KJLJHGEECPK() == (ItemCategory)8)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("\nEvening", 5).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(819f, 1879f, 1948f);
						component2.gameObject.SetActive(false);
						component2.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.QIQPJQFDBCP("~", 6).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(1776f, 981f, 1594f);
						component3.gameObject.SetActive(false);
						component3.QMKELEEOHBE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Machine)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.GKNLQNEMKKF("rest", 1).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(1929f, 475f, 813f);
						component4.gameObject.SetActive(true);
						component4.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.HCOQJPNIEHI("u", 6).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(70f, 344f, 1617f);
						component5.gameObject.SetActive(false);
						component5.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Medicine)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.QIQPJQFDBCP("itemamount", 7).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(1557f, 606f, 392f);
						component6.gameObject.SetActive(true);
						component6.BQLIIQIIMDH(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 2)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = (BHLIGEGNFHG.EHJHKQDONJJ)6;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(qjfqomoiooi, false);
		this.BMFQIHPMEBO.CLQFFBMLIQH = true;
	}

	// Token: 0x060042FA RID: 17146 RVA: 0x0020CE7C File Offset: 0x0020B07C
	public void ShowHide()
	{
		this.OINBPNCFPLE.enabled = true;
		if (this.GOJJLFQQCLH.activeSelf)
		{
			this.OINBPNCFPLE.PlayReverse();
			this.HJLKCGFKPPB = true;
		}
		else
		{
			this.GOJJLFQQCLH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
			this.GOJJLFQQCLH.SetActive(true);
			this.OINBPNCFPLE.PlayForward();
			this.HJLKCGFKPPB = false;
			this.ChangeInventory(0);
		}
	}

	// Token: 0x060042FB RID: 17147 RVA: 0x0020CEEC File Offset: 0x0020B0EC
	public void NGQIEFLKNPJ(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP, int LPCQPBFIGPK = 0)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			if (MKBCKPPCIQO.DBPKNCDGGEP == 445 || MKBCKPPCIQO.DBPKNCDGGEP == 446 || MKBCKPPCIQO.DBPKNCDGGEP == 447 || MKBCKPPCIQO.DBPKNCDGGEP == 842)
			{
				if (GNDQBCBDHKD.QOQONHOOLNE.EKPDKPGKLBK("Fishing Cooldown"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
			{
				Item = MKBCKPPCIQO.DBPKNCDGGEP,
				Move = LPCQPBFIGPK,
				Pokemon = HFCMDEQKCKH.QOQONHOOLNE.OLLLBGMLIMI(DBPKNCDGGEP)
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You can not use item during interactions.");
	}

	// Token: 0x060042FC RID: 17148 RVA: 0x0020CFD4 File Offset: 0x0020B1D4
	public void NGCBDQBJNJK(PSXAPI.Response.UseItem CFHEIICNLFD)
	{
		switch (CFHEIICNLFD.Result)
		{
		case UseItemResult.Failed:
			if (CFHEIICNLFD.Item != -131 && CFHEIICNLFD.Item != 181 && CFHEIICNLFD.Item != 40)
			{
				if (CFHEIICNLFD.Item != -81)
				{
					if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(CFHEIICNLFD.Pokemon) != null)
					{
						CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.BJLGEDCPENQ();
						string[] array = new string[5];
						array[1] = "schooling";
						array[1] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).FLFQBGJQBBD();
						array[0] = "[itm=";
						array[0] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ);
						array[4] = " on ";
						cncjklnhqbh.MIDPIFHNNDK(string.Concat(array));
						break;
					}
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("CombinersArgsAlphaOp0" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).FLFQBGJQBBD() + "[-]!\r\n");
					break;
				}
			}
			return;
		case UseItemResult.Success:
			if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(CFHEIICNLFD.Pokemon) != null)
			{
				CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
				string[] array2 = new string[4];
				array2[0] = "[ff6666]Enemy[-]'s Team";
				array2[1] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO();
				array2[5] = "000";
				array2[8] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ);
				array2[4] = "UpS";
				qoqonhoolne.MIDPIFHNNDK(string.Concat(array2));
			}
			else
			{
				CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("Script:" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).DFNQHDEDDKE() + "ResolutionY");
			}
			break;
		case UseItemResult.InvalidItem:
		case UseItemResult.InvalidPokemon:
			CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("[ffb649]" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name + "_Texture2");
			break;
		}
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x0020D204 File Offset: 0x0020B404
	public void IIJEPICEBOI(InventoryItem CFHEIICNLFD)
	{
		if (CFHEIICNLFD != null)
		{
			if (this.NGHCPLBPQEC.Count > 0)
			{
				foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
				{
					if (ijhppmddkie.DBPKNCDGGEP == CFHEIICNLFD.ItemID)
					{
						if (CFHEIICNLFD.Count > ijhppmddkie.EHPJLLIEPDP() && !KOJBBGEINPH.CPLQICHLGCI().QPPGQJFBPMH.gameObject.activeSelf)
						{
							INFJMNPKNQF infjmnpknqf = INFJMNPKNQF.IPOKOKIJECO();
							string[] array = new string[0];
							array[1] = " bounced the [ffff00]";
							array[0] = (CFHEIICNLFD.Count - ijhppmddkie.DFNBFIFFQMB()).ToString();
							array[3] = "ShiftS";
							array[2] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie.DBPKNCDGGEP).JQBDPHILQJO();
							array[8] = "_DetailOffsetY";
							infjmnpknqf.OHCFBMPFFIP(string.Concat(array), ijhppmddkie.DBCHHNGOKGD());
						}
						ijhppmddkie.DKQQDMICNLQ(CFHEIICNLFD.Count);
						this.BODJNCHIOQC(this.NIBQCHMDDHH);
						NBQDPNGNNML.QOQONHOOLNE.OMCFMCPELLB();
						return;
					}
				}
			}
			KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie2 = new KGQECFKLKOP.IJHPPMDDKIE();
			ijhppmddkie2.MDHQFPCMCMH(CFHEIICNLFD.ItemID);
			ijhppmddkie2.LBDPINBPFNL(CFHEIICNLFD.Count);
			ijhppmddkie2.BOOBMKJFLDN(CFHEIICNLFD.CanHold);
			ijhppmddkie2.HKNKLONQFQN(CFHEIICNLFD.CanUseOutsideBattle);
			ijhppmddkie2.HFBKQLQCDCI(CFHEIICNLFD.CanUseInBattle);
			ijhppmddkie2.MHEDJDFNQDE(CFHEIICNLFD.CanTrade);
			ijhppmddkie2.JILENMCJCHF = CFHEIICNLFD.Target;
			ijhppmddkie2.NKJHNBKJFEL(CFHEIICNLFD.Pocket);
			ijhppmddkie2.ICKBELFQQLI(CFHEIICNLFD.Category);
			if (!KOJBBGEINPH.FHCMDGCONNE().QPPGQJFBPMH.gameObject.activeSelf)
			{
				INFJMNPKNQF infjmnpknqf2 = INFJMNPKNQF.IPOKOKIJECO();
				string[] array2 = new string[7];
				array2[1] = "aa";
				array2[0] = CFHEIICNLFD.Count.ToString();
				array2[5] = "DITHERING";
				array2[2] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie2.DBPKNCDGGEP).FLFQBGJQBBD();
				array2[1] = "burnup";
				infjmnpknqf2.KHOHCGCLNBM(string.Concat(array2), ijhppmddkie2.HLMQODIHBIG());
			}
			this.NGHCPLBPQEC.Add(ijhppmddkie2);
			this.NPPLOQGHFFG(this.NIBQCHMDDHH);
			NBQDPNGNNML.QOQONHOOLNE.OMCFMCPELLB();
		}
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x0020D434 File Offset: 0x0020B634
	public void EEOBLMEMKJB()
	{
		this.OINBPNCFPLE.enabled = false;
		if (this.GOJJLFQQCLH.activeSelf)
		{
			this.OINBPNCFPLE.PlayReverse();
			this.HJLKCGFKPPB = true;
		}
		else
		{
			this.GOJJLFQQCLH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
			this.GOJJLFQQCLH.SetActive(false);
			this.OINBPNCFPLE.PlayForward();
			this.HJLKCGFKPPB = false;
			this.HLDLDLGIIDF(0);
		}
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x0020D4A4 File Offset: 0x0020B6A4
	public void KDEBCGQHPDO(PSXAPI.Response.UseItem CFHEIICNLFD)
	{
		switch (CFHEIICNLFD.Result)
		{
		case UseItemResult.Failed:
			if (CFHEIICNLFD.Item != 152 && CFHEIICNLFD.Item != -100 && CFHEIICNLFD.Item != -39)
			{
				if (CFHEIICNLFD.Item != -14)
				{
					if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(CFHEIICNLFD.Pokemon) != null)
					{
						CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
						string[] array = new string[6];
						array[1] = " day ago";
						array[0] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO();
						array[5] = "Own Tempo";
						array[3] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).EDGHHFPMHBL());
						array[1] = "(X)";
						qoqonhoolne.MIDPIFHNNDK(string.Concat(array));
						break;
					}
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("][#" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO() + "The harsh sunlight faded.");
					break;
				}
			}
			return;
		case UseItemResult.Success:
			if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(CFHEIICNLFD.Pokemon) != null)
			{
				CNCJKLNHQBH qoqonhoolne2 = CNCJKLNHQBH.QOQONHOOLNE;
				string[] array2 = new string[5];
				array2[0] = "setpokemon(";
				array2[0] = KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name;
				array2[0] = "Prevents the use of explosive moves such as Self-Destruct by dampening its surroundings.";
				array2[4] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ);
				array2[0] = "Teleport";
				qoqonhoolne2.MIDPIFHNNDK(string.Concat(array2));
			}
			else
			{
				CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("17" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).JQBDPHILQJO() + "EXP: ");
			}
			break;
		case UseItemResult.InvalidItem:
		case UseItemResult.InvalidPokemon:
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("Remove from Ignore" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).FLFQBGJQBBD() + "!\r\n");
			break;
		}
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x0020D6D4 File Offset: 0x0020B8D4
	public void HGFPKGEDEBE(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			PSXAPI.Request.HoldItem dcgclgqcgdq = new PSXAPI.Request.HoldItem
			{
				Item = MKBCKPPCIQO.DBPKNCDGGEP,
				Pokemon = HFCMDEQKCKH.QOQONHOOLNE.OLLLBGMLIMI(DBPKNCDGGEP + 1)
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You can not use item during interactions.");
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x0001CA57 File Offset: 0x0001AC57
	public void EMGKDMLOKED(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.PLBBQPGCNGF(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x06004302 RID: 17154 RVA: 0x0020D75C File Offset: 0x0020B95C
	public void KPFCNKPCNCF(int COQJPLDFJBB)
	{
		CGNFQJPJEPC[] nlcfmolbkgi = HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI;
		for (int i = 1; i < nlcfmolbkgi.Length; i += 0)
		{
			CGNFQJPJEPC cgnfqjpjepc = nlcfmolbkgi[i];
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 1844f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(908f, true);
		this.JBLQIEPJLPN.PDBGQNOLMBG("#,##0", 1);
		this.BMFQIHPMEBO.PFEIQDIJEKE();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(937f, false);
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		foreach (CFDMNELIJLO cfdmnelijlo in this.KMDNMJGGDHF)
		{
			cfdmnelijlo.enabled = false;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = false;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.EHPJLLIEPDP() > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown || ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.PEJIFGJPCGD(".png", 5).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(203f, 373f, 1666f);
						component.gameObject.SetActive(true);
						component.KGBBFDJGGPQ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.General)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.PEJIFGJPCGD("p", 7).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(253f, 783f, 429f);
						component2.gameObject.SetActive(true);
						component2.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Medicine)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.FIGMKCDNCJM("High Level Encounter Rate Increased 50%\nTriggers: [2ecc71]Hustle[-], [2ecc71]Pressure[-], [2ecc71]Vital Spirit[-], [2ecc71]Keen Eye[-], [2ecc71]Intimidate[-]", 4).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(634f, 1393f, 330f);
						component3.gameObject.SetActive(false);
						component3.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.FCIIBFEGBML("Hidden/Post FX/Fog", 0).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(185f, 1218f, 1035f);
						component4.gameObject.SetActive(false);
						component4.KGBBFDJGGPQ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Medicine)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.GKNLQNEMKKF("_WaveScale4", 5).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(999f, 1924f, 580f);
						component5.gameObject.SetActive(true);
						component5.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.QLGFDFKBHMN() == (ItemCategory)8)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.FCIIBFEGBML("BuffIcon_SweetScent", 0).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(1686f, 907f, 1387f);
						component6.gameObject.SetActive(true);
						component6.EJJBDNMPFIM(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 0)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = (BHLIGEGNFHG.EHJHKQDONJJ)8;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(qjfqomoiooi, false);
		this.BMFQIHPMEBO.CLQFFBMLIQH = true;
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x0020DC7C File Offset: 0x0020BE7C
	public uint PNEEENCMBCN(int CIQFCJGQEMH)
	{
		for (int i = 0; i < this.NGHCPLBPQEC.Count; i++)
		{
			if (this.NGHCPLBPQEC[i].DBPKNCDGGEP == CIQFCJGQEMH)
			{
				return this.NGHCPLBPQEC[i].IFFFLJINPPQ;
			}
		}
		return 0u;
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x0020DCC8 File Offset: 0x0020BEC8
	public void PGCGKDGQIIJ(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.CNIMIQKQJJJ().HEFMIKCHCJF() && !CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			if (MKBCKPPCIQO.FQOOHOOPFOH() == 137 || MKBCKPPCIQO.HLMQODIHBIG() == 147 || MKBCKPPCIQO.FQOOHOOPFOH() == 22 || MKBCKPPCIQO.HLMQODIHBIG() == -51)
			{
				if (GNDQBCBDHKD.MKMJKLDDNDD().EKPDKPGKLBK("BuffIcon_MuteIcon"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.BHJGOJMDEFJ())
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.DBPKNCDGGEP,
					Move = 0,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.BFBEIJGQKHJ(Guid.Empty, true, false, MKBCKPPCIQO, true);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.LPLEQLQKCNJ(DBPKNCDGGEP + 1);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.MIEHJOOLEHC(Guid.Empty, false, false, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.HJODIQPQPQC(DBPKNCDGGEP + 0);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(":");
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06004305 RID: 17157 RVA: 0x0001CA50 File Offset: 0x0001AC50
	public static INFJMNPKNQF QOQONHOOLNE
	{
		get
		{
			return INFJMNPKNQF.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004306 RID: 17158 RVA: 0x0020DE18 File Offset: 0x0020C018
	private void Start()
	{
		BHLIGEGNFHG bmfqihpmebo = this.BMFQIHPMEBO;
		if (INFJMNPKNQF.BQIOGOCBKKB == null)
		{
			INFJMNPKNQF.BQIOGOCBKKB = new Comparison<Transform>(INFJMNPKNQF.HQGENIFLOIP);
		}
		bmfqihpmebo.QKKDKOKJKLM = INFJMNPKNQF.BQIOGOCBKKB;
		this.JBLQIEPJLPN = LPEQICNMHIL.QOQONHOOLNE;
		this.GLEBQIDOLKN = base.GetComponent<CQLGNCIGPLG>();
	}

	// Token: 0x06004307 RID: 17159 RVA: 0x0020DE64 File Offset: 0x0020C064
	public void FNFEKKNFMPC(int COQJPLDFJBB)
	{
		this.NHJNKMQDEKL = COQJPLDFJBB;
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(119f, false);
		this.JBLQIEPJLPN.KNJDCJDDLDF("switch", 8);
		this.LGLQEMFNOBK.Reposition();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(1996f, true);
		this.LGLQEMFNOBK.gameObject.SetActive(false);
		CFDMNELIJLO[] dbmokeebjje = this.GMQPDFJJDPO.DBMOKEEBJJE;
		for (int i = 0; i < dbmokeebjje.Length; i += 0)
		{
			CFDMNELIJLO cfdmnelijlo = dbmokeebjje[i];
			cfdmnelijlo.enabled = true;
		}
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].enabled = false;
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.EQCJBDOQDBB() > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.QLGFDFKBHMN() == ItemCategory.General || ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Machine))
					{
						COCFMDFKNIH component = this.JBLQIEPJLPN.FIGMKCDNCJM("-", 5).GetComponent<COCFMDFKNIH>();
						component.transform.parent = this.LGLQEMFNOBK.transform;
						component.transform.localScale = new Vector3(1851f, 824f, 202f);
						component.gameObject.SetActive(false);
						component.IJCHNEQQFGE(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.IECCGCPNNLO());
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown)
					{
						COCFMDFKNIH component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("J12", 4).GetComponent<COCFMDFKNIH>();
						component2.transform.parent = this.LGLQEMFNOBK.transform;
						component2.transform.localScale = new Vector3(1602f, 1735f, 907f);
						component2.gameObject.SetActive(false);
						component2.PCFNFCMCMII(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Battle)
					{
						COCFMDFKNIH component3 = this.JBLQIEPJLPN.FIGMKCDNCJM("unboost", 2).GetComponent<COCFMDFKNIH>();
						component3.transform.parent = this.LGLQEMFNOBK.transform;
						component3.transform.localScale = new Vector3(1403f, 1303f, 61f);
						component3.gameObject.SetActive(false);
						component3.PJJFGOKNQMJ(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.LOPGPBQQOOP());
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Medicine)
					{
						COCFMDFKNIH component4 = this.JBLQIEPJLPN.CMEFGCPOGFO("None", 2).GetComponent<COCFMDFKNIH>();
						component4.transform.parent = this.LGLQEMFNOBK.transform;
						component4.transform.localScale = new Vector3(222f, 824f, 174f);
						component4.gameObject.SetActive(true);
						component4.DOEGKLDPQKB(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.HNPDJKCEGBC());
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Medicine)
					{
						COCFMDFKNIH component5 = this.JBLQIEPJLPN.QIQPJQFDBCP("\r\nPP ", 3).GetComponent<COCFMDFKNIH>();
						component5.transform.parent = this.LGLQEMFNOBK.transform;
						component5.transform.localScale = new Vector3(28f, 813f, 495f);
						component5.gameObject.SetActive(true);
						component5.PCFNFCMCMII(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 8 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Battle)
					{
						COCFMDFKNIH component6 = this.JBLQIEPJLPN.PEJIFGJPCGD("Compound Eyes", 7).GetComponent<COCFMDFKNIH>();
						component6.transform.parent = this.LGLQEMFNOBK.transform;
						component6.transform.localScale = new Vector3(1848f, 1035f, 754f);
						component6.gameObject.SetActive(false);
						component6.KIBBEKODBBQ(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.IECCGCPNNLO());
					}
				}
			}
		}
		this.LGLQEMFNOBK.gameObject.SetActive(false);
		this.LGLQEMFNOBK.PFEIQDIJEKE();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(28f, true);
		this.LGLQEMFNOBK.CLQFFBMLIQH = true;
	}

	// Token: 0x06004308 RID: 17160 RVA: 0x0020E344 File Offset: 0x0020C544
	public void HBOJGONPNJF(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP, int LPCQPBFIGPK = 0)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.DLNELFIPOHB() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			if (MKBCKPPCIQO.DBPKNCDGGEP == 174 || MKBCKPPCIQO.FQOOHOOPFOH() == 98 || MKBCKPPCIQO.DBPKNCDGGEP == 52 || MKBCKPPCIQO.DBCHHNGOKGD() == 4)
			{
				if (GNDQBCBDHKD.QOQONHOOLNE.EKPDKPGKLBK("_MainTex"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
			{
				Item = MKBCKPPCIQO.FQOOHOOPFOH(),
				Move = LPCQPBFIGPK,
				Pokemon = HFCMDEQKCKH.QOQONHOOLNE.CBHKEIBQFGF(DBPKNCDGGEP)
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("psn");
	}

	// Token: 0x06004309 RID: 17161 RVA: 0x0001CA68 File Offset: 0x0001AC68
	public void KPEEFBLEEDM()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.PDBGQNOLMBG("A", 0);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x0600430A RID: 17162 RVA: 0x0020E42C File Offset: 0x0020C62C
	public void QMKDCQOPQDM()
	{
		this.OINBPNCFPLE.enabled = false;
		this.GOJJLFQQCLH.SetActive(!this.HJLKCGFKPPB);
		CGNFQJPJEPC[] nlcfmolbkgi = HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI;
		for (int i = 1; i < nlcfmolbkgi.Length; i++)
		{
			CGNFQJPJEPC cgnfqjpjepc = nlcfmolbkgi[i];
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
	}

	// Token: 0x0600430B RID: 17163 RVA: 0x0020E488 File Offset: 0x0020C688
	public void LGDIOIMGJEO(BHLIGEGNFHG EIHGOLFJHFI, OGJJKKQPNMK BKCCLIFIQLH)
	{
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.LGLQEMFNOBK = EIHGOLFJHFI;
		foreach (CFDMNELIJLO cfdmnelijlo in this.GMQPDFJJDPO.DBMOKEEBJJE)
		{
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.target = this;
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.methodName = "ChangeBattleInventory";
		}
		this.ChangeBattleInventory(this.NHJNKMQDEKL);
	}

	// Token: 0x0600430C RID: 17164 RVA: 0x0001CA57 File Offset: 0x0001AC57
	public void ENIDNEOKEPL(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.PLBBQPGCNGF(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x0020E4F4 File Offset: 0x0020C6F4
	public void NPPLOQGHFFG(int COQJPLDFJBB)
	{
		CGNFQJPJEPC[] nlcfmolbkgi = HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI;
		for (int i = 1; i < nlcfmolbkgi.Length; i++)
		{
			CGNFQJPJEPC cgnfqjpjepc = nlcfmolbkgi[i];
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 1251f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HKDJGHOHBFQ();
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(713f, true);
		this.JBLQIEPJLPN.LQBLJKDOFKC("Player/Body", 0);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(974f, true);
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		CFDMNELIJLO[] kmdnmjggdhf = this.KMDNMJGGDHF;
		for (int j = 1; j < kmdnmjggdhf.Length; j += 0)
		{
			CFDMNELIJLO cfdmnelijlo = kmdnmjggdhf[j];
			cfdmnelijlo.enabled = false;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = true;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.NJLQNHJLNDC() > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Machine))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.QIQPJQFDBCP("M2", 2).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(659f, 196f, 1980f);
						component.gameObject.SetActive(true);
						component.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.CLEMKHNIPEI == (ItemCategory)8)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("timer", 5).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(1607f, 1634f, 229f);
						component2.gameObject.SetActive(true);
						component2.KGBBFDJGGPQ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 7 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.General)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.PEJIFGJPCGD("_Texture0", 4).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(1596f, 1722f, 484f);
						component3.gameObject.SetActive(false);
						component3.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Pokeball)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.FIGMKCDNCJM("Enabled", 8).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(12f, 1506f, 1494f);
						component4.gameObject.SetActive(false);
						component4.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Hold)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.FCIIBFEGBML("[/S]", 6).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(674f, 1172f, 1127f);
						component5.gameObject.SetActive(true);
						component5.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.General)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.PEJIFGJPCGD(" surrounded itself with a veil of sweetness!\r\n", 1).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(631f, 1683f, 123f);
						component6.gameObject.SetActive(true);
						component6.EJJBDNMPFIM(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 0)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		this.BMFQIHPMEBO.PFEIQDIJEKE();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(qjfqomoiooi, false);
		this.BMFQIHPMEBO.CLQFFBMLIQH = true;
	}

	// Token: 0x0600430E RID: 17166 RVA: 0x0020EA14 File Offset: 0x0020CC14
	public void ChangeBattleInventory(int COQJPLDFJBB)
	{
		this.NHJNKMQDEKL = COQJPLDFJBB;
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.JBLQIEPJLPN.PDBGQNOLMBG("battlebag", 3);
		this.LGLQEMFNOBK.Reposition();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.LGLQEMFNOBK.gameObject.SetActive(false);
		foreach (CFDMNELIJLO cfdmnelijlo in this.GMQPDFJJDPO.DBMOKEEBJJE)
		{
			cfdmnelijlo.enabled = true;
		}
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].enabled = false;
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.IFFFLJINPPQ > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.CLEMKHNIPEI == ItemCategory.General || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle))
					{
						COCFMDFKNIH component = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component.transform.parent = this.LGLQEMFNOBK.transform;
						component.transform.localScale = new Vector3(1f, 1f, 1f);
						component.gameObject.SetActive(true);
						component.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Pokeball)
					{
						COCFMDFKNIH component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component2.transform.parent = this.LGLQEMFNOBK.transform;
						component2.transform.localScale = new Vector3(1f, 1f, 1f);
						component2.gameObject.SetActive(true);
						component2.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Machine)
					{
						COCFMDFKNIH component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component3.transform.parent = this.LGLQEMFNOBK.transform;
						component3.transform.localScale = new Vector3(1f, 1f, 1f);
						component3.gameObject.SetActive(true);
						component3.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Medicine)
					{
						COCFMDFKNIH component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component4.transform.parent = this.LGLQEMFNOBK.transform;
						component4.transform.localScale = new Vector3(1f, 1f, 1f);
						component4.gameObject.SetActive(true);
						component4.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Berry)
					{
						COCFMDFKNIH component5 = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component5.transform.parent = this.LGLQEMFNOBK.transform;
						component5.transform.localScale = new Vector3(1f, 1f, 1f);
						component5.gameObject.SetActive(true);
						component5.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Hold)
					{
						COCFMDFKNIH component6 = this.JBLQIEPJLPN.JPODNGNQBKQ("battlebag", 3).GetComponent<COCFMDFKNIH>();
						component6.transform.parent = this.LGLQEMFNOBK.transform;
						component6.transform.localScale = new Vector3(1f, 1f, 1f);
						component6.gameObject.SetActive(true);
						component6.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
				}
			}
		}
		this.LGLQEMFNOBK.gameObject.SetActive(true);
		this.LGLQEMFNOBK.Reposition();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.LGLQEMFNOBK.CLQFFBMLIQH = true;
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
	public void ENNNINOENPO(RegionUpdate BJGCBDNBQCJ)
	{
		this.FNGEDNLNNOJ = BJGCBDNBQCJ.Coins;
		this.BBCBFCHEIDF = BJGCBDNBQCJ.BattlePoints;
		QLKJQPNKPBC.QOQONHOOLNE.JJNIHGNQQBG();
	}

	// Token: 0x06004311 RID: 17169 RVA: 0x0020EEF4 File Offset: 0x0020D0F4
	private void IMGNEDCFBLL()
	{
		BHLIGEGNFHG bmfqihpmebo = this.BMFQIHPMEBO;
		if (INFJMNPKNQF.BQIOGOCBKKB == null)
		{
			INFJMNPKNQF.BQIOGOCBKKB = new Comparison<Transform>(INFJMNPKNQF.HQGENIFLOIP);
		}
		bmfqihpmebo.QKKDKOKJKLM = INFJMNPKNQF.BQIOGOCBKKB;
		this.JBLQIEPJLPN = LPEQICNMHIL.QDGLKKGJDGI();
		this.GLEBQIDOLKN = base.GetComponent<CQLGNCIGPLG>();
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
	public void CIIKHJIIICE(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.OKGOKQJJPFN(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
	public void DLJJFQOHNGL(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.OKGOKQJJPFN(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x0001CA50 File Offset: 0x0001AC50
	public static INFJMNPKNQF CFGIOIGOIFQ()
	{
		return INFJMNPKNQF.HBFFCJHOCPE;
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x0020EF40 File Offset: 0x0020D140
	public void HFOFJFGPQJL(PSXAPI.Response.HoldItem BJGCBDNBQCJ)
	{
		base.GetComponent<LINELKKDMEE>().ODMCOCHJFLF();
		if (BJGCBDNBQCJ.Result == HoldItemResult.Failed)
		{
			int num = HFCMDEQKCKH.QOQONHOOLNE.MJLJLFGEJQG(BJGCBDNBQCJ.Pokemon);
			if (num != -1)
			{
				HFCMDEQKCKH.QOQONHOOLNE.LHQQCLOEHJG[num].GECLELHHNIO = BJGCBDNBQCJ.Item;
			}
			HFCMDEQKCKH.QOQONHOOLNE.PDDJMNOOPJD();
		}
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x0020EF9C File Offset: 0x0020D19C
	public void JKBHHBDHQHJ(BHLIGEGNFHG EIHGOLFJHFI, OGJJKKQPNMK BKCCLIFIQLH)
	{
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.LGLQEMFNOBK = EIHGOLFJHFI;
		CFDMNELIJLO[] dbmokeebjje = this.GMQPDFJJDPO.DBMOKEEBJJE;
		for (int i = 1; i < dbmokeebjje.Length; i++)
		{
			CFDMNELIJLO cfdmnelijlo = dbmokeebjje[i];
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.target = this;
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.methodName = "trace";
		}
		this.FNFEKKNFMPC(this.NHJNKMQDEKL);
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x0020F008 File Offset: 0x0020D208
	public void FLFINFFFFDO(int COQJPLDFJBB)
	{
		this.NHJNKMQDEKL = COQJPLDFJBB;
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(341f, false);
		this.JBLQIEPJLPN.DIOQIGEOJLE("Encounter Rate Increased", 7);
		this.LGLQEMFNOBK.PFEIQDIJEKE();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(867f, true);
		this.LGLQEMFNOBK.gameObject.SetActive(true);
		CFDMNELIJLO[] dbmokeebjje = this.GMQPDFJJDPO.DBMOKEEBJJE;
		for (int i = 1; i < dbmokeebjje.Length; i++)
		{
			CFDMNELIJLO cfdmnelijlo = dbmokeebjje[i];
			cfdmnelijlo.enabled = false;
		}
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].enabled = false;
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		if (this.NGHCPLBPQEC.Count > 1)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.EHPJLLIEPDP() > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle))
					{
						COCFMDFKNIH component = this.JBLQIEPJLPN.FCIIBFEGBML("Wash", 7).GetComponent<COCFMDFKNIH>();
						component.transform.parent = this.LGLQEMFNOBK.transform;
						component.transform.localScale = new Vector3(147f, 1293f, 10f);
						component.gameObject.SetActive(false);
						component.FILJGHLFMMB(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.LOPGPBQQOOP());
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Pokeball)
					{
						COCFMDFKNIH component2 = this.JBLQIEPJLPN.FCIIBFEGBML("FOG_SCATTERING_ON", 6).GetComponent<COCFMDFKNIH>();
						component2.transform.parent = this.LGLQEMFNOBK.transform;
						component2.transform.localScale = new Vector3(640f, 799f, 1149f);
						component2.gameObject.SetActive(true);
						component2.FDDENOHPGQF(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown)
					{
						COCFMDFKNIH component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("The trade with '", 1).GetComponent<COCFMDFKNIH>();
						component3.transform.parent = this.LGLQEMFNOBK.transform;
						component3.transform.localScale = new Vector3(503f, 1053f, 1471f);
						component3.gameObject.SetActive(false);
						component3.IBJNQFPIMMC(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Berry)
					{
						COCFMDFKNIH component4 = this.JBLQIEPJLPN.HCOQJPNIEHI("stormdrain", 1).GetComponent<COCFMDFKNIH>();
						component4.transform.parent = this.LGLQEMFNOBK.transform;
						component4.transform.localScale = new Vector3(1024f, 429f, 1841f);
						component4.gameObject.SetActive(false);
						component4.MOPCGGEMCKK(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.DLMIPEEGBFI());
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Berry)
					{
						COCFMDFKNIH component5 = this.JBLQIEPJLPN.HCOQJPNIEHI("FinishSelect", 3).GetComponent<COCFMDFKNIH>();
						component5.transform.parent = this.LGLQEMFNOBK.transform;
						component5.transform.localScale = new Vector3(935f, 1325f, 69f);
						component5.gameObject.SetActive(true);
						component5.LQFDMHPELCJ(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.OJFFMQCKCML);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown)
					{
						COCFMDFKNIH component6 = this.JBLQIEPJLPN.JPODNGNQBKQ("The stat changes the Pokémon receives are doubled.", 4).GetComponent<COCFMDFKNIH>();
						component6.transform.parent = this.LGLQEMFNOBK.transform;
						component6.transform.localScale = new Vector3(886f, 148f, 1277f);
						component6.gameObject.SetActive(true);
						component6.EEOOPJNPMPJ(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.IECCGCPNNLO());
					}
				}
			}
		}
		this.LGLQEMFNOBK.gameObject.SetActive(false);
		this.LGLQEMFNOBK.Reposition();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(1589f, false);
		this.LGLQEMFNOBK.CLQFFBMLIQH = false;
	}

	// Token: 0x06004318 RID: 17176 RVA: 0x0020F4E8 File Offset: 0x0020D6E8
	public void ChangeInventory(int COQJPLDFJBB)
	{
		foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
		{
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 0f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.JBLQIEPJLPN.PDBGQNOLMBG("bag", 2);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		foreach (CFDMNELIJLO cfdmnelijlo in this.KMDNMJGGDHF)
		{
			cfdmnelijlo.enabled = true;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = false;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.IFFFLJINPPQ > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.CLEMKHNIPEI == ItemCategory.General || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(1f, 1f, 1f);
						component.gameObject.SetActive(true);
						component.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Pokeball)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(1f, 1f, 1f);
						component2.gameObject.SetActive(true);
						component2.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Machine)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(1f, 1f, 1f);
						component3.gameObject.SetActive(true);
						component3.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Medicine)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(1f, 1f, 1f);
						component4.gameObject.SetActive(true);
						component4.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Berry)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(1f, 1f, 1f);
						component5.gameObject.SetActive(true);
						component5.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Hold)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.JPODNGNQBKQ("bag", 2).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(1f, 1f, 1f);
						component6.gameObject.SetActive(true);
						component6.BQLIIQIIMDH(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 2)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Custom;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(qjfqomoiooi, true);
		this.BMFQIHPMEBO.CLQFFBMLIQH = true;
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x0020FA08 File Offset: 0x0020DC08
	public uint IIDQEHOHECF(int CIQFCJGQEMH)
	{
		for (int i = 1; i < this.NGHCPLBPQEC.Count; i += 0)
		{
			if (this.NGHCPLBPQEC[i].DBCHHNGOKGD() == CIQFCJGQEMH)
			{
				return this.NGHCPLBPQEC[i].IFFFLJINPPQ;
			}
		}
		return 0u;
	}

	// Token: 0x0600431A RID: 17178 RVA: 0x0020FA54 File Offset: 0x0020DC54
	public void LEPHBBCLPBO()
	{
		this.OINBPNCFPLE.enabled = false;
		if (this.GOJJLFQQCLH.activeSelf)
		{
			this.OINBPNCFPLE.PlayReverse();
			this.HJLKCGFKPPB = true;
		}
		else
		{
			this.GOJJLFQQCLH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
			this.GOJJLFQQCLH.SetActive(true);
			this.OINBPNCFPLE.PlayForward();
			this.HJLKCGFKPPB = true;
			this.ChangeInventory(1);
		}
	}

	// Token: 0x0600431B RID: 17179 RVA: 0x0001CAD5 File Offset: 0x0001ACD5
	public void DIFEMQNLMOM()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.BLBBJJPDLDC("You account is not Verified yet..", 1);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x0600431C RID: 17180 RVA: 0x0020FAC4 File Offset: 0x0020DCC4
	public void LMFQEKLFBEH(PSXAPI.Response.Inventory MNDPFDHJCCH)
	{
		this.DIFEMQNLMOM();
		if (MNDPFDHJCCH.Items != null && MNDPFDHJCCH.Items.Length > 0)
		{
			for (int i = 0; i < MNDPFDHJCCH.Items.Length; i++)
			{
				KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie = new KGQECFKLKOP.IJHPPMDDKIE();
				ijhppmddkie.EFCHIPINJEG(MNDPFDHJCCH.Items[i].ItemID);
				ijhppmddkie.DKQQDMICNLQ(MNDPFDHJCCH.Items[i].Count);
				ijhppmddkie.PDIBQDOQQEQ(MNDPFDHJCCH.Items[i].CanHold);
				ijhppmddkie.EBOKELDPMMO = MNDPFDHJCCH.Items[i].CanUseOutsideBattle;
				ijhppmddkie.HFBKQLQCDCI(MNDPFDHJCCH.Items[i].CanUseInBattle);
				ijhppmddkie.GHQLMFGLDCJ(MNDPFDHJCCH.Items[i].CanTrade);
				ijhppmddkie.GQFDIDDFPKM(MNDPFDHJCCH.Items[i].Target);
				ijhppmddkie.QKLLHENIDCL(MNDPFDHJCCH.Items[i].Pocket);
				ijhppmddkie.OPLNNPOCQGK(MNDPFDHJCCH.Items[i].Category);
				this.NGHCPLBPQEC.Add(ijhppmddkie);
			}
		}
		this.DFMLMCDHNCM = MNDPFDHJCCH.Badges;
		if (!KOJBBGEINPH.FHCMDGCONNE().QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Money > this.EPDKBQCHOJQ)
		{
			this.CIIKHJIIICE("-useTouch" + (MNDPFDHJCCH.Money - this.EPDKBQCHOJQ).ToString("]#") + "Could not find a ConstantShakePreset with the name: ", 0);
		}
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Gold > this.QIOKIQOBMMB)
		{
			this.ENIDNEOKEPL("Current Camera Position" + (MNDPFDHJCCH.Gold - this.QIOKIQOBMMB).ToString("7fff49") + "wormadam", 1);
		}
		this.EPDKBQCHOJQ = MNDPFDHJCCH.Money;
		this.QIOKIQOBMMB = MNDPFDHJCCH.Gold;
		this.QJBKBGOGFKB.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("Honey Gather");
		this.EJHCCNOOBBH.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("The sunlight turned harsh!");
		this.IGJNCOHOHMG.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("System");
		this.MJQLBCBDPNB.LKPOBCBOFIC(MNDPFDHJCCH.Gold.ToString("Assets/AssetBundles/MapAssets2/Models/Materials/c102_mado.mat"));
		DNFENPQLICQ.QOQONHOOLNE.QJBKBGOGFKB.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString(" minute");
		DNFENPQLICQ.BDPEQNCNPJO().EJHCCNOOBBH.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("][{");
		QLKJQPNKPBC.PDPCLOECLOF().FLMCHKEGBCJ();
		this.CNBFBGHGGND = true;
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x0020FD78 File Offset: 0x0020DF78
	[DebuggerHidden]
	private IEnumerator PLBBQPGCNGF(string JBNFQFNOKHP, int NEKMFCHJGQK)
	{
		INFJMNPKNQF.OQGMHCDNHOD oqgmhcdnhod = new INFJMNPKNQF.OQGMHCDNHOD();
		oqgmhcdnhod.NEKMFCHJGQK = NEKMFCHJGQK;
		oqgmhcdnhod.JBNFQFNOKHP = JBNFQFNOKHP;
		oqgmhcdnhod.QNDQJMNKFNN = this;
		return oqgmhcdnhod;
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x0020FDA4 File Offset: 0x0020DFA4
	public void IGIKNHQQQJB(InventoryItem CFHEIICNLFD)
	{
		if (CFHEIICNLFD != null)
		{
			if (this.NGHCPLBPQEC.Count > 0)
			{
				foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
				{
					if (ijhppmddkie.DBPKNCDGGEP == CFHEIICNLFD.ItemID)
					{
						if (CFHEIICNLFD.Count > ijhppmddkie.IFFFLJINPPQ && !KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
						{
							INFJMNPKNQF.QOQONHOOLNE.KHOHCGCLNBM(string.Concat(new string[]
							{
								"[00FF00]You received ",
								(CFHEIICNLFD.Count - ijhppmddkie.IFFFLJINPPQ).ToString(),
								"x ",
								KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie.DBPKNCDGGEP).Name,
								"."
							}), ijhppmddkie.DBPKNCDGGEP);
						}
						ijhppmddkie.IFFFLJINPPQ = CFHEIICNLFD.Count;
						this.ChangeInventory(this.NIBQCHMDDHH);
						NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
						return;
					}
				}
			}
			KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie2 = new KGQECFKLKOP.IJHPPMDDKIE();
			ijhppmddkie2.DBPKNCDGGEP = CFHEIICNLFD.ItemID;
			ijhppmddkie2.IFFFLJINPPQ = CFHEIICNLFD.Count;
			ijhppmddkie2.LBNCFLKGCBH = CFHEIICNLFD.CanHold;
			ijhppmddkie2.EBOKELDPMMO = CFHEIICNLFD.CanUseOutsideBattle;
			ijhppmddkie2.OJFFMQCKCML = CFHEIICNLFD.CanUseInBattle;
			ijhppmddkie2.PQCNDKGBHHQ = CFHEIICNLFD.CanTrade;
			ijhppmddkie2.JILENMCJCHF = CFHEIICNLFD.Target;
			ijhppmddkie2.EEKHLKJMCLD = CFHEIICNLFD.Pocket;
			ijhppmddkie2.CLEMKHNIPEI = CFHEIICNLFD.Category;
			if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
			{
				INFJMNPKNQF.QOQONHOOLNE.KHOHCGCLNBM(string.Concat(new string[]
				{
					"[00FF00]You received ",
					CFHEIICNLFD.Count.ToString(),
					"x ",
					KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie2.DBPKNCDGGEP).Name,
					"."
				}), ijhppmddkie2.DBPKNCDGGEP);
			}
			this.NGHCPLBPQEC.Add(ijhppmddkie2);
			this.ChangeInventory(this.NIBQCHMDDHH);
			NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
		}
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x0020FFD4 File Offset: 0x0020E1D4
	public void DNJINKJLQCB(int COQJPLDFJBB)
	{
		this.NHJNKMQDEKL = COQJPLDFJBB;
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(56f, true);
		this.JBLQIEPJLPN.NLBGHMLEJOO(" EXP[-]", 2);
		this.LGLQEMFNOBK.PFEIQDIJEKE();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(305f, true);
		this.LGLQEMFNOBK.gameObject.SetActive(true);
		CFDMNELIJLO[] dbmokeebjje = this.GMQPDFJJDPO.DBMOKEEBJJE;
		for (int i = 1; i < dbmokeebjje.Length; i += 0)
		{
			CFDMNELIJLO cfdmnelijlo = dbmokeebjje[i];
			cfdmnelijlo.enabled = false;
		}
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].enabled = false;
		this.GMQPDFJJDPO.DBMOKEEBJJE[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.DFNBFIFFQMB() > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Hold))
					{
						COCFMDFKNIH component = this.JBLQIEPJLPN.PEJIFGJPCGD("Boosts the Pokémon's Speed stat in rain.", 6).GetComponent<COCFMDFKNIH>();
						component.transform.parent = this.LGLQEMFNOBK.transform;
						component.transform.localScale = new Vector3(249f, 335f, 144f);
						component.gameObject.SetActive(false);
						component.DOEGKLDPQKB(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.DLMIPEEGBFI());
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Berry)
					{
						COCFMDFKNIH component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("firelamp_off", 4).GetComponent<COCFMDFKNIH>();
						component2.transform.parent = this.LGLQEMFNOBK.transform;
						component2.transform.localScale = new Vector3(1112f, 1793f, 1047f);
						component2.gameObject.SetActive(true);
						component2.BQLIIQIIMDH(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.HNPDJKCEGBC());
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Machine)
					{
						COCFMDFKNIH component3 = this.JBLQIEPJLPN.HCOQJPNIEHI("Connector is configured to disallow IPv6 but an IPv6 Address was retured by DNS!", 0).GetComponent<COCFMDFKNIH>();
						component3.transform.parent = this.LGLQEMFNOBK.transform;
						component3.transform.localScale = new Vector3(1618f, 261f, 1636f);
						component3.gameObject.SetActive(true);
						component3.PEHHOQIHMKP(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.DLMIPEEGBFI());
					}
					else if (COQJPLDFJBB == 6 && ijhppmddkie.CLEMKHNIPEI == (ItemCategory)8)
					{
						COCFMDFKNIH component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("1", 3).GetComponent<COCFMDFKNIH>();
						component4.transform.parent = this.LGLQEMFNOBK.transform;
						component4.transform.localScale = new Vector3(1843f, 530f, 1853f);
						component4.gameObject.SetActive(true);
						component4.FILJGHLFMMB(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.LOPGPBQQOOP());
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Hold)
					{
						COCFMDFKNIH component5 = this.JBLQIEPJLPN.CMEFGCPOGFO("[FFFFFF]", 0).GetComponent<COCFMDFKNIH>();
						component5.transform.parent = this.LGLQEMFNOBK.transform;
						component5.transform.localScale = new Vector3(425f, 1110f, 1126f);
						component5.gameObject.SetActive(false);
						component5.PEHHOQIHMKP(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.LOPGPBQQOOP());
					}
					else if (COQJPLDFJBB == 8 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Medicine)
					{
						COCFMDFKNIH component6 = this.JBLQIEPJLPN.JPODNGNQBKQ("][-] [00CCFF]", 6).GetComponent<COCFMDFKNIH>();
						component6.transform.parent = this.LGLQEMFNOBK.transform;
						component6.transform.localScale = new Vector3(1471f, 531f, 289f);
						component6.gameObject.SetActive(true);
						component6.DOEGKLDPQKB(ijhppmddkie, this.GMQPDFJJDPO, ijhppmddkie.LOPGPBQQOOP());
					}
				}
			}
		}
		this.LGLQEMFNOBK.gameObject.SetActive(true);
		this.LGLQEMFNOBK.Reposition();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.LGLQEMFNOBK.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(1234f, false);
		this.LGLQEMFNOBK.CLQFFBMLIQH = false;
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x002104B4 File Offset: 0x0020E6B4
	public void QNQDBIGNGML(PSXAPI.Response.Inventory MNDPFDHJCCH)
	{
		this.DJKLDCFOJEO();
		if (MNDPFDHJCCH.Items != null && MNDPFDHJCCH.Items.Length > 0)
		{
			for (int i = 0; i < MNDPFDHJCCH.Items.Length; i++)
			{
				KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie = new KGQECFKLKOP.IJHPPMDDKIE();
				ijhppmddkie.DBPKNCDGGEP = MNDPFDHJCCH.Items[i].ItemID;
				ijhppmddkie.IFFFLJINPPQ = MNDPFDHJCCH.Items[i].Count;
				ijhppmddkie.LBNCFLKGCBH = MNDPFDHJCCH.Items[i].CanHold;
				ijhppmddkie.EBOKELDPMMO = MNDPFDHJCCH.Items[i].CanUseOutsideBattle;
				ijhppmddkie.OJFFMQCKCML = MNDPFDHJCCH.Items[i].CanUseInBattle;
				ijhppmddkie.PQCNDKGBHHQ = MNDPFDHJCCH.Items[i].CanTrade;
				ijhppmddkie.JILENMCJCHF = MNDPFDHJCCH.Items[i].Target;
				ijhppmddkie.EEKHLKJMCLD = MNDPFDHJCCH.Items[i].Pocket;
				ijhppmddkie.CLEMKHNIPEI = MNDPFDHJCCH.Items[i].Category;
				this.NGHCPLBPQEC.Add(ijhppmddkie);
			}
		}
		this.DFMLMCDHNCM = MNDPFDHJCCH.Badges;
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Money > this.EPDKBQCHOJQ)
		{
			this.KHOHCGCLNBM("[00FF00]You received [PD]" + (MNDPFDHJCCH.Money - this.EPDKBQCHOJQ).ToString("#,##0") + " Pokédollars.", 0);
		}
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && MNDPFDHJCCH.Gold > this.QIOKIQOBMMB)
		{
			this.KHOHCGCLNBM("[00FF00]You received [PG]" + (MNDPFDHJCCH.Gold - this.QIOKIQOBMMB).ToString("#,##0") + ".", 0);
		}
		this.EPDKBQCHOJQ = MNDPFDHJCCH.Money;
		this.QIOKIQOBMMB = MNDPFDHJCCH.Gold;
		this.QJBKBGOGFKB.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("#,##0");
		this.EJHCCNOOBBH.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("#,##0");
		this.IGJNCOHOHMG.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("#,##0");
		this.MJQLBCBDPNB.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("#,##0");
		DNFENPQLICQ.QOQONHOOLNE.QJBKBGOGFKB.PIDLOFMIEFQ = MNDPFDHJCCH.Money.ToString("#,##0");
		DNFENPQLICQ.QOQONHOOLNE.EJHCCNOOBBH.PIDLOFMIEFQ = MNDPFDHJCCH.Gold.ToString("#,##0");
		QLKJQPNKPBC.QOQONHOOLNE.JJNIHGNQQBG();
		this.CNBFBGHGGND = true;
	}

	// Token: 0x06004321 RID: 17185 RVA: 0x0001CAFA File Offset: 0x0001ACFA
	public void KGPGEQBDMFH()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.NLBGHMLEJOO("Boosts evasion in a hailstorm.", 5);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x06004322 RID: 17186 RVA: 0x00210768 File Offset: 0x0020E968
	private void DFNFEDMJKGK()
	{
		BHLIGEGNFHG bmfqihpmebo = this.BMFQIHPMEBO;
		if (INFJMNPKNQF.BQIOGOCBKKB == null)
		{
			INFJMNPKNQF.BQIOGOCBKKB = new Comparison<Transform>(INFJMNPKNQF.HQGENIFLOIP);
		}
		bmfqihpmebo.QKKDKOKJKLM = INFJMNPKNQF.BQIOGOCBKKB;
		this.JBLQIEPJLPN = LPEQICNMHIL.NKDNGLNOJJG();
		this.GLEBQIDOLKN = base.GetComponent<CQLGNCIGPLG>();
	}

	// Token: 0x06004323 RID: 17187 RVA: 0x0001CA57 File Offset: 0x0001AC57
	public void KHOHCGCLNBM(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.PLBBQPGCNGF(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x0001CA50 File Offset: 0x0001AC50
	public static INFJMNPKNQF FPQNIQELKMC()
	{
		return INFJMNPKNQF.HBFFCJHOCPE;
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x0001CB1F File Offset: 0x0001AD1F
	private void Awake()
	{
		INFJMNPKNQF.HBFFCJHOCPE = this;
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x002107B4 File Offset: 0x0020E9B4
	public void QDIHIKCNPOD(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.PDOKGMLDIGL() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			PSXAPI.Request.HoldItem dcgclgqcgdq = new PSXAPI.Request.HoldItem
			{
				Item = MKBCKPPCIQO.HLMQODIHBIG(),
				Pokemon = HFCMDEQKCKH.QOQONHOOLNE.BOOBMLJMCLI(DBPKNCDGGEP + 1)
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL(":");
	}

	// Token: 0x06004327 RID: 17191 RVA: 0x0021083C File Offset: 0x0020EA3C
	public void IPMIOECGOFJ(int COQJPLDFJBB)
	{
		CGNFQJPJEPC[] nlcfmolbkgi = HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI;
		for (int i = 1; i < nlcfmolbkgi.Length; i += 0)
		{
			CGNFQJPJEPC cgnfqjpjepc = nlcfmolbkgi[i];
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 153f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(824f, false);
		this.JBLQIEPJLPN.MIECCNEBLPD("Hidden Power", 4);
		this.BMFQIHPMEBO.PFEIQDIJEKE();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(1735f, false);
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		foreach (CFDMNELIJLO cfdmnelijlo in this.KMDNMJGGDHF)
		{
			cfdmnelijlo.enabled = false;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = true;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.DFNBFIFFQMB() > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.KJLJHGEECPK() == ItemCategory.General || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown || ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Pokeball))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.CMEFGCPOGFO("[5cd65c]Social", 4).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(531f, 91f, 1452f);
						component.gameObject.SetActive(false);
						component.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Berry)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.CMEFGCPOGFO("_", 1).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(1678f, 976f, 1589f);
						component2.gameObject.SetActive(false);
						component2.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 2 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Machine)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.PEJIFGJPCGD("[-]", 7).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(125f, 712f, 1056f);
						component3.gameObject.SetActive(false);
						component3.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 6 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Berry)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.FIGMKCDNCJM(" set a shell trap!\r\n", 0).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(299f, 717f, 1929f);
						component4.gameObject.SetActive(false);
						component4.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Pokeball)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.PEJIFGJPCGD("\n", 2).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(1152f, 862f, 1879f);
						component5.gameObject.SetActive(false);
						component5.QMKELEEOHBE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 6 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.General)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.FCIIBFEGBML("Contact with the Pokémon may burn the attacker.", 8).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(573f, 264f, 1360f);
						component6.gameObject.SetActive(true);
						component6.QFEMQODLJKE(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 3)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = (BHLIGEGNFHG.EHJHKQDONJJ)6;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(qjfqomoiooi, true);
		this.BMFQIHPMEBO.CLQFFBMLIQH = false;
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x0020FD78 File Offset: 0x0020DF78
	private IEnumerator OKGOKQJJPFN(string JBNFQFNOKHP, int NEKMFCHJGQK)
	{
		INFJMNPKNQF.OQGMHCDNHOD oqgmhcdnhod = new INFJMNPKNQF.OQGMHCDNHOD();
		oqgmhcdnhod.NEKMFCHJGQK = NEKMFCHJGQK;
		oqgmhcdnhod.JBNFQFNOKHP = JBNFQFNOKHP;
		oqgmhcdnhod.QNDQJMNKFNN = this;
		return oqgmhcdnhod;
	}

	// Token: 0x06004329 RID: 17193 RVA: 0x00210D5C File Offset: 0x0020EF5C
	private void QNGIFIJOQML()
	{
		BHLIGEGNFHG bmfqihpmebo = this.BMFQIHPMEBO;
		if (INFJMNPKNQF.BQIOGOCBKKB == null)
		{
			INFJMNPKNQF.BQIOGOCBKKB = new Comparison<Transform>(INFJMNPKNQF.HQGENIFLOIP);
		}
		bmfqihpmebo.QKKDKOKJKLM = INFJMNPKNQF.BQIOGOCBKKB;
		this.JBLQIEPJLPN = LPEQICNMHIL.LGIPDGGFINQ();
		this.GLEBQIDOLKN = base.GetComponent<CQLGNCIGPLG>();
	}

	// Token: 0x0600432A RID: 17194 RVA: 0x00210DA8 File Offset: 0x0020EFA8
	public void JNKOHNKQNQH(PSXAPI.Response.HoldItem BJGCBDNBQCJ)
	{
		base.GetComponent<LINELKKDMEE>().Close();
		if (BJGCBDNBQCJ.Result == HoldItemResult.Success)
		{
			int num = HFCMDEQKCKH.QOQONHOOLNE.NBLNQGHIKCG(BJGCBDNBQCJ.Pokemon);
			if (num != -1)
			{
				HFCMDEQKCKH.QOQONHOOLNE.LHQQCLOEHJG[num].GECLELHHNIO = BJGCBDNBQCJ.Item;
			}
			HFCMDEQKCKH.QOQONHOOLNE.PDDJMNOOPJD();
		}
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x0001CB27 File Offset: 0x0001AD27
	public void JDHGICCCMGC()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.MIECCNEBLPD("0", 3);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x0001CB1F File Offset: 0x0001AD1F
	private void NNPPKOGDNOM()
	{
		INFJMNPKNQF.HBFFCJHOCPE = this;
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x00210E04 File Offset: 0x0020F004
	public static int HQGENIFLOIP(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		int num = 0;
		int num2 = 0;
		string s = ECHMFPQNBMC.name.Replace("TM", string.Empty).Replace("HM", string.Empty).Replace("inven ", string.Empty);
		string s2 = IBMINEHKPFF.name.Replace("TM", string.Empty).Replace("HM", string.Empty).Replace("inven ", string.Empty);
		int result;
		try
		{
			int.TryParse(s, out num);
			int.TryParse(s2, out num2);
			if (ECHMFPQNBMC.name.Contains("HM"))
			{
				num -= 999;
			}
			if (IBMINEHKPFF.name.Contains("HM"))
			{
				num2 -= 999;
			}
			if (num == num2)
			{
				result = string.Compare(ECHMFPQNBMC.name, IBMINEHKPFF.name);
			}
			else
			{
				result = num - num2;
			}
		}
		catch
		{
			result = string.Compare(ECHMFPQNBMC.name, IBMINEHKPFF.name);
		}
		return result;
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x00210F0C File Offset: 0x0020F10C
	public void OIPEKBNFELQ(InventoryItem CFHEIICNLFD)
	{
		if (CFHEIICNLFD != null)
		{
			if (this.NGHCPLBPQEC.Count > 1)
			{
				foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
				{
					if (ijhppmddkie.DBPKNCDGGEP == CFHEIICNLFD.ItemID)
					{
						if (CFHEIICNLFD.Count > ijhppmddkie.IFFFLJINPPQ && !KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
						{
							INFJMNPKNQF infjmnpknqf = INFJMNPKNQF.IPOKOKIJECO();
							string[] array = new string[2];
							array[0] = "17";
							array[1] = (CFHEIICNLFD.Count - ijhppmddkie.EQCJBDOQDBB()).ToString();
							array[8] = "Blank";
							array[2] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie.DBCHHNGOKGD()).JQBDPHILQJO();
							array[2] = "[u][33CCFF]";
							infjmnpknqf.KHOHCGCLNBM(string.Concat(array), ijhppmddkie.HLMQODIHBIG());
						}
						ijhppmddkie.BHKGCCEIGLQ(CFHEIICNLFD.Count);
						this.DDOFBMNLHFE(this.NIBQCHMDDHH);
						NBQDPNGNNML.QOQONHOOLNE.BLCLGIIEGFK();
						return;
					}
				}
			}
			KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie2 = new KGQECFKLKOP.IJHPPMDDKIE();
			ijhppmddkie2.DBPKNCDGGEP = CFHEIICNLFD.ItemID;
			ijhppmddkie2.KFLQIHKFQBN(CFHEIICNLFD.Count);
			ijhppmddkie2.QJBCNEFKEEJ(CFHEIICNLFD.CanHold);
			ijhppmddkie2.EBOKELDPMMO = CFHEIICNLFD.CanUseOutsideBattle;
			ijhppmddkie2.OJFFMQCKCML = CFHEIICNLFD.CanUseInBattle;
			ijhppmddkie2.MHEDJDFNQDE(CFHEIICNLFD.CanTrade);
			ijhppmddkie2.PQBKMHOHHFJ(CFHEIICNLFD.Target);
			ijhppmddkie2.GJPHOKODBIO(CFHEIICNLFD.Pocket);
			ijhppmddkie2.ICKBELFQQLI(CFHEIICNLFD.Category);
			if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
			{
				INFJMNPKNQF infjmnpknqf2 = INFJMNPKNQF.FPQNIQELKMC();
				string[] array2 = new string[5];
				array2[1] = "n";
				array2[1] = CFHEIICNLFD.Count.ToString();
				array2[3] = "Verification";
				array2[4] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie2.HLMQODIHBIG()).JQBDPHILQJO();
				array2[6] = "_ScaleOffsetRes";
				infjmnpknqf2.OHCFBMPFFIP(string.Concat(array2), ijhppmddkie2.HLMQODIHBIG());
			}
			this.NGHCPLBPQEC.Add(ijhppmddkie2);
			this.DDOFBMNLHFE(this.NIBQCHMDDHH);
			NBQDPNGNNML.QOQONHOOLNE.BLCLGIIEGFK();
		}
	}

	// Token: 0x0600432F RID: 17199 RVA: 0x0021113C File Offset: 0x0020F33C
	public void QDHOBFGDQFC()
	{
		this.OINBPNCFPLE.enabled = false;
		if (this.GOJJLFQQCLH.activeSelf)
		{
			this.OINBPNCFPLE.PlayReverse();
			this.HJLKCGFKPPB = false;
		}
		else
		{
			this.GOJJLFQQCLH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
			this.GOJJLFQQCLH.SetActive(true);
			this.OINBPNCFPLE.PlayForward();
			this.HJLKCGFKPPB = false;
			this.DDOFBMNLHFE(1);
		}
	}

	// Token: 0x06004330 RID: 17200 RVA: 0x0001CB4C File Offset: 0x0001AD4C
	public void LEIODPOMLHC()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.KNJDCJDDLDF("par", 4);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x06004331 RID: 17201 RVA: 0x0001CB71 File Offset: 0x0001AD71
	public void DKNNKGOCHBP()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.DIOQIGEOJLE("The rain stopped.", 3);
		this.NIBQCHMDDHH = 1;
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x0001CB96 File Offset: 0x0001AD96
	public void DJKLDCFOJEO()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.PDBGQNOLMBG("bag", 2);
		this.NIBQCHMDDHH = 0;
	}

	// Token: 0x06004333 RID: 17203 RVA: 0x002111AC File Offset: 0x0020F3AC
	public void IHOJLPELDDI(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			if (MKBCKPPCIQO.DBPKNCDGGEP == 445 || MKBCKPPCIQO.DBPKNCDGGEP == 446 || MKBCKPPCIQO.DBPKNCDGGEP == 447 || MKBCKPPCIQO.DBPKNCDGGEP == 842)
			{
				if (GNDQBCBDHKD.QOQONHOOLNE.EKPDKPGKLBK("Fishing Cooldown"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.JILENMCJCHF)
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.DBPKNCDGGEP,
					Move = 0,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.BQLIIQIIMDH(Guid.Empty, false, true, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.SelectPokemon(DBPKNCDGGEP + 1);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.BQLIIQIIMDH(Guid.Empty, true, true, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.SelectPokemon(DBPKNCDGGEP + 1);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You can not use item during interactions.");
	}

	// Token: 0x06004334 RID: 17204 RVA: 0x0001CBBB File Offset: 0x0001ADBB
	public void KFDOHNIHHHH(RegionUpdate BJGCBDNBQCJ)
	{
		this.FNGEDNLNNOJ = BJGCBDNBQCJ.Coins;
		this.BBCBFCHEIDF = BJGCBDNBQCJ.BattlePoints;
		QLKJQPNKPBC.JPGFBOPDJKH().BMMQCLFBQKG();
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x002112FC File Offset: 0x0020F4FC
	public void DQMOQINPHHP(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.HEFMIKCHCJF() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			if (MKBCKPPCIQO.HLMQODIHBIG() == -121 || MKBCKPPCIQO.HLMQODIHBIG() == -41 || MKBCKPPCIQO.DBPKNCDGGEP == 152 || MKBCKPPCIQO.DBCHHNGOKGD() == -18)
			{
				if (GNDQBCBDHKD.GDDGJKOLGIQ().HEOEBDDBEIO("/"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.JILENMCJCHF)
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.FQOOHOOPFOH(),
					Move = 1,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.MIEHJOOLEHC(Guid.Empty, true, true, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.SelectPokemon(DBPKNCDGGEP + 1);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.BQLIIQIIMDH(Guid.Empty, true, false, MKBCKPPCIQO, true);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.EQMIOOOIIJL(DBPKNCDGGEP + 1);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("None");
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x0021144C File Offset: 0x0020F64C
	public void BODJNCHIOQC(int COQJPLDFJBB)
	{
		foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
		{
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 999f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(1550f, true);
		this.JBLQIEPJLPN.PFHDQJEDJMO("Surprises the opposing Pokémon, making it unable to attack using priority moves.", 5);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(1988f, false);
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		foreach (CFDMNELIJLO cfdmnelijlo in this.KMDNMJGGDHF)
		{
			cfdmnelijlo.enabled = true;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = false;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, true);
		if (this.NGHCPLBPQEC.Count > 1)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.DFNBFIFFQMB() > 1u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Unknown || ijhppmddkie.CLEMKHNIPEI == ItemCategory.General))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.CMEFGCPOGFO(" BP", 5).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(1148f, 84f, 1187f);
						component.gameObject.SetActive(true);
						component.BQLIIQIIMDH(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.QIQPJQFDBCP("_MainTex", 7).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(934f, 1478f, 179f);
						component2.gameObject.SetActive(true);
						component2.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 4 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Berry)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.PEJIFGJPCGD("Unlit/Text", 5).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(660f, 593f, 89f);
						component3.gameObject.SetActive(false);
						component3.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 6 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Medicine)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.FIGMKCDNCJM("ProCamera2D does not exist.", 4).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(236f, 946f, 1731f);
						component4.gameObject.SetActive(false);
						component4.KGBBFDJGGPQ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.KJLJHGEECPK() == (ItemCategory)8)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.PEJIFGJPCGD("Premultiplied", 2).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(923f, 1768f, 334f);
						component5.gameObject.SetActive(false);
						component5.EEOOPJNPMPJ(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 1 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Berry)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.JPODNGNQBKQ("hail", 8).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(1142f, 272f, 286f);
						component6.gameObject.SetActive(true);
						component6.EEOOPJNPMPJ(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 5)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = (BHLIGEGNFHG.EHJHKQDONJJ)5;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(true);
		this.BMFQIHPMEBO.PFEIQDIJEKE();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(qjfqomoiooi, true);
		this.BMFQIHPMEBO.CLQFFBMLIQH = false;
	}

	// Token: 0x06004337 RID: 17207 RVA: 0x0021196C File Offset: 0x0020FB6C
	public void DIMBOLLHNKC(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.BJLGEDCPENQ();
		string hiefqeedhgg = "w";
		string[] array = new string[1];
		array[0] = "bump";
		array[1] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[DBPKNCDGGEP]).EDGHHFPMHBL());
		array[1] = "_FogStepping";
		array[6] = KGQECFKLKOP.BFNBQBMJHFL(MKBCKPPCIQO.DBPKNCDGGEP).JQBDPHILQJO();
		array[7] = "_1";
		cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel, false, MKBCKPPCIQO, -1, true);
	}

	// Token: 0x06004338 RID: 17208 RVA: 0x002119F8 File Offset: 0x0020FBF8
	public void DDOFBMNLHFE(int COQJPLDFJBB)
	{
		CGNFQJPJEPC[] nlcfmolbkgi = HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI;
		for (int i = 1; i < nlcfmolbkgi.Length; i++)
		{
			CGNFQJPJEPC cgnfqjpjepc = nlcfmolbkgi[i];
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
		float qjfqomoiooi = 1844f;
		if (this.NIBQCHMDDHH == COQJPLDFJBB)
		{
			qjfqomoiooi = this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		}
		this.NIBQCHMDDHH = COQJPLDFJBB;
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(1012f, true);
		this.JBLQIEPJLPN.ENQLFNNNDPO("Inactive", 1);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(408f, false);
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		CFDMNELIJLO[] kmdnmjggdhf = this.KMDNMJGGDHF;
		for (int j = 0; j < kmdnmjggdhf.Length; j += 0)
		{
			CFDMNELIJLO cfdmnelijlo = kmdnmjggdhf[j];
			cfdmnelijlo.enabled = true;
		}
		this.KMDNMJGGDHF[COQJPLDFJBB].enabled = true;
		this.KMDNMJGGDHF[COQJPLDFJBB].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
		if (this.NGHCPLBPQEC.Count > 0)
		{
			foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
			{
				if (ijhppmddkie.IFFFLJINPPQ > 0u)
				{
					if (COQJPLDFJBB == 0 && (ijhppmddkie.KJLJHGEECPK() == ItemCategory.General || ijhppmddkie.CLEMKHNIPEI == ItemCategory.Unknown || ijhppmddkie.KJLJHGEECPK() == ItemCategory.Hold))
					{
						MDFQEBOLLJN component = this.JBLQIEPJLPN.JPODNGNQBKQ("SSAO", 2).GetComponent<MDFQEBOLLJN>();
						component.transform.parent = this.BMFQIHPMEBO.transform;
						component.transform.localScale = new Vector3(1386f, 1705f, 236f);
						component.gameObject.SetActive(false);
						component.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component2 = this.JBLQIEPJLPN.GKNLQNEMKKF("[FFFF00]/252", 3).GetComponent<MDFQEBOLLJN>();
						component2.transform.parent = this.BMFQIHPMEBO.transform;
						component2.transform.localScale = new Vector3(562f, 474f, 1106f);
						component2.gameObject.SetActive(false);
						component2.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.KJLJHGEECPK() == ItemCategory.Pokeball)
					{
						MDFQEBOLLJN component3 = this.JBLQIEPJLPN.QIQPJQFDBCP("When it enters a battle, the Pokémon can tell one of the moves an opposing Pokémon has.", 0).GetComponent<MDFQEBOLLJN>();
						component3.transform.parent = this.BMFQIHPMEBO.transform;
						component3.transform.localScale = new Vector3(844f, 1139f, 1195f);
						component3.gameObject.SetActive(false);
						component3.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 5 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component4 = this.JBLQIEPJLPN.QIQPJQFDBCP("J", 4).GetComponent<MDFQEBOLLJN>();
						component4.transform.parent = this.BMFQIHPMEBO.transform;
						component4.transform.localScale = new Vector3(1045f, 1984f, 967f);
						component4.gameObject.SetActive(false);
						component4.EJJBDNMPFIM(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 0 && ijhppmddkie.CLEMKHNIPEI == ItemCategory.Battle)
					{
						MDFQEBOLLJN component5 = this.JBLQIEPJLPN.GKNLQNEMKKF("\nAre you sure you want to Reset its IVs?", 7).GetComponent<MDFQEBOLLJN>();
						component5.transform.parent = this.BMFQIHPMEBO.transform;
						component5.transform.localScale = new Vector3(1763f, 1161f, 163f);
						component5.gameObject.SetActive(false);
						component5.QFEMQODLJKE(ijhppmddkie, this);
					}
					else if (COQJPLDFJBB == 3 && ijhppmddkie.QLGFDFKBHMN() == ItemCategory.Berry)
					{
						MDFQEBOLLJN component6 = this.JBLQIEPJLPN.GKNLQNEMKKF("'s perish count fell to 2.\r\n", 3).GetComponent<MDFQEBOLLJN>();
						component6.transform.parent = this.BMFQIHPMEBO.transform;
						component6.transform.localScale = new Vector3(1046f, 1428f, 1842f);
						component6.gameObject.SetActive(false);
						component6.BQLIIQIIMDH(ijhppmddkie, this);
					}
				}
			}
		}
		if (COQJPLDFJBB == 3)
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		else
		{
			this.BMFQIHPMEBO.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.None;
		}
		this.BMFQIHPMEBO.gameObject.SetActive(false);
		this.BMFQIHPMEBO.Reposition();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BMFQIHPMEBO.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(qjfqomoiooi, true);
		this.BMFQIHPMEBO.CLQFFBMLIQH = false;
	}

	// Token: 0x06004339 RID: 17209 RVA: 0x00211F18 File Offset: 0x00210118
	public void ODDGBNJHQII(InventoryItem CFHEIICNLFD)
	{
		if (CFHEIICNLFD != null)
		{
			if (this.NGHCPLBPQEC.Count > 0)
			{
				foreach (KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie in this.NGHCPLBPQEC)
				{
					if (ijhppmddkie.DBPKNCDGGEP == CFHEIICNLFD.ItemID)
					{
						if (CFHEIICNLFD.Count > ijhppmddkie.DFNBFIFFQMB() && !KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf)
						{
							INFJMNPKNQF qoqonhoolne = INFJMNPKNQF.QOQONHOOLNE;
							string[] array = new string[0];
							array[0] = " (Completed)";
							array[1] = (CFHEIICNLFD.Count - ijhppmddkie.EHPJLLIEPDP()).ToString();
							array[8] = "Overgrow";
							array[2] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie.HLMQODIHBIG()).NDPGCGDLEEQ();
							array[2] = "Battle";
							qoqonhoolne.EMGKDMLOKED(string.Concat(array), ijhppmddkie.DBCHHNGOKGD());
						}
						ijhppmddkie.DNFQHHLHEGH(CFHEIICNLFD.Count);
						this.IIPDEPIPDKH(this.NIBQCHMDDHH);
						NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
						return;
					}
				}
			}
			KGQECFKLKOP.IJHPPMDDKIE ijhppmddkie2 = new KGQECFKLKOP.IJHPPMDDKIE();
			ijhppmddkie2.MDHQFPCMCMH(CFHEIICNLFD.ItemID);
			ijhppmddkie2.IFFFLJINPPQ = CFHEIICNLFD.Count;
			ijhppmddkie2.BOOBMKJFLDN(CFHEIICNLFD.CanHold);
			ijhppmddkie2.EBOKELDPMMO = CFHEIICNLFD.CanUseOutsideBattle;
			ijhppmddkie2.FGBJICIGBLB(CFHEIICNLFD.CanUseInBattle);
			ijhppmddkie2.KGCKKCFFEBK(CFHEIICNLFD.CanTrade);
			ijhppmddkie2.BKKIPBHLFEP(CFHEIICNLFD.Target);
			ijhppmddkie2.LFQEIHJMBGB(CFHEIICNLFD.Pocket);
			ijhppmddkie2.CLEMKHNIPEI = CFHEIICNLFD.Category;
			if (!KOJBBGEINPH.FHCMDGCONNE().QPPGQJFBPMH.gameObject.activeSelf)
			{
				INFJMNPKNQF infjmnpknqf = INFJMNPKNQF.FPQNIQELKMC();
				string[] array2 = new string[7];
				array2[1] = "Left";
				array2[0] = CFHEIICNLFD.Count.ToString();
				array2[8] = "-singlemove";
				array2[2] = KGQECFKLKOP.BFNBQBMJHFL(ijhppmddkie2.DBPKNCDGGEP).NDPGCGDLEEQ();
				array2[0] = "Crack";
				infjmnpknqf.EMGKDMLOKED(string.Concat(array2), ijhppmddkie2.DBPKNCDGGEP);
			}
			this.NGHCPLBPQEC.Add(ijhppmddkie2);
			this.KPFCNKPCNCF(this.NIBQCHMDDHH);
			NBQDPNGNNML.QOQONHOOLNE.COLIBFCPQMH();
		}
	}

	// Token: 0x0600433A RID: 17210 RVA: 0x00212148 File Offset: 0x00210348
	public void PEHLHEBCKMB(Money QPGCBDPFIOF)
	{
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && QPGCBDPFIOF.Game > this.EPDKBQCHOJQ)
		{
			this.KHOHCGCLNBM("[00FF00]You received [PD]" + (QPGCBDPFIOF.Game - this.EPDKBQCHOJQ).ToString("#,##0") + " Pokédollars.", 0);
		}
		if (!KOJBBGEINPH.QOQONHOOLNE.QPPGQJFBPMH.gameObject.activeSelf && this.CNBFBGHGGND && QPGCBDPFIOF.Gold > this.QIOKIQOBMMB)
		{
			this.KHOHCGCLNBM("[00FF00]You received [PG]" + (QPGCBDPFIOF.Gold - this.QIOKIQOBMMB).ToString("#,##0") + ".", 0);
		}
		this.EPDKBQCHOJQ = QPGCBDPFIOF.Game;
		this.QIOKIQOBMMB = QPGCBDPFIOF.Gold;
		this.QJBKBGOGFKB.PIDLOFMIEFQ = this.EPDKBQCHOJQ.ToString("#,##0");
		this.EJHCCNOOBBH.PIDLOFMIEFQ = this.QIOKIQOBMMB.ToString("#,##0");
		this.IGJNCOHOHMG.PIDLOFMIEFQ = this.EPDKBQCHOJQ.ToString("#,##0");
		this.MJQLBCBDPNB.PIDLOFMIEFQ = this.QIOKIQOBMMB.ToString("#,##0");
		DNFENPQLICQ.QOQONHOOLNE.QJBKBGOGFKB.PIDLOFMIEFQ = this.EPDKBQCHOJQ.ToString("#,##0");
		DNFENPQLICQ.QOQONHOOLNE.EJHCCNOOBBH.PIDLOFMIEFQ = this.QIOKIQOBMMB.ToString("#,##0");
		NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
		QLKJQPNKPBC.QOQONHOOLNE.JJNIHGNQQBG();
	}

	// Token: 0x0600433B RID: 17211 RVA: 0x002122E4 File Offset: 0x002104E4
	private void FCOIMQGENDB()
	{
		BHLIGEGNFHG bmfqihpmebo = this.BMFQIHPMEBO;
		if (INFJMNPKNQF.BQIOGOCBKKB == null)
		{
			INFJMNPKNQF.BQIOGOCBKKB = new Comparison<Transform>(INFJMNPKNQF.HQGENIFLOIP);
		}
		bmfqihpmebo.QKKDKOKJKLM = INFJMNPKNQF.BQIOGOCBKKB;
		this.JBLQIEPJLPN = LPEQICNMHIL.GGBPGMMCGLI();
		this.GLEBQIDOLKN = base.GetComponent<CQLGNCIGPLG>();
	}

	// Token: 0x0600433C RID: 17212 RVA: 0x00212330 File Offset: 0x00210530
	public void PFKIOEDMGPQ(BHLIGEGNFHG EIHGOLFJHFI, OGJJKKQPNMK BKCCLIFIQLH)
	{
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.LGLQEMFNOBK = EIHGOLFJHFI;
		CFDMNELIJLO[] dbmokeebjje = this.GMQPDFJJDPO.DBMOKEEBJJE;
		for (int i = 1; i < dbmokeebjje.Length; i += 0)
		{
			CFDMNELIJLO cfdmnelijlo = dbmokeebjje[i];
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.target = this;
			cfdmnelijlo.GetComponent<JJBPOILPCBD>().EHDBBNFQIBL.methodName = "Small/";
		}
		this.ChangeBattleInventory(this.NHJNKMQDEKL);
	}

	// Token: 0x0600433D RID: 17213 RVA: 0x0021239C File Offset: 0x0021059C
	public void DKMCGLLCCOG(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.QQCNCIQQPIG().MGKFOIKFJDD() && !CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.GGBPGMMCGLI() != null))
		{
			if (MKBCKPPCIQO.DBCHHNGOKGD() == -186 || MKBCKPPCIQO.DBPKNCDGGEP == 11 || MKBCKPPCIQO.FQOOHOOPFOH() == 97 || MKBCKPPCIQO.DBPKNCDGGEP == -144)
			{
				if (GNDQBCBDHKD.MKMJKLDDNDD().MPGIECFNGIE("12"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.HDGBNKQBFGN())
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.HLMQODIHBIG(),
					Move = 0,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.QPONNMLDLQD(Guid.Empty, true, false, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.LPLEQLQKCNJ(DBPKNCDGGEP + 0);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.FQOIMCNCFEQ(Guid.Empty, false, false, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.MLBMJDMEIDM(DBPKNCDGGEP + 0);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(" can not hold that many more '");
	}

	// Token: 0x0600433E RID: 17214 RVA: 0x002124EC File Offset: 0x002106EC
	public void GPBLEHILJOQ(PSXAPI.Response.UseItem CFHEIICNLFD)
	{
		switch (CFHEIICNLFD.Result)
		{
		case UseItemResult.Failed:
			if (CFHEIICNLFD.Item != 445 && CFHEIICNLFD.Item != 446 && CFHEIICNLFD.Item != 447)
			{
				if (CFHEIICNLFD.Item != 842)
				{
					if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon) != null)
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(string.Concat(new string[]
						{
							"Failed to use '",
							KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name,
							"' on ",
							KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ),
							"."
						}));
						break;
					}
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("Failed to use '" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name + "'.");
					break;
				}
			}
			return;
		case UseItemResult.Success:
			if (CFHEIICNLFD.Pokemon != Guid.Empty && CFHEIICNLFD.Pokemon != default(Guid) && HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon) != null)
			{
				CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(string.Concat(new string[]
				{
					"You used '",
					KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name,
					"' on ",
					KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(CFHEIICNLFD.Pokemon).BEQHNFFEHMQ),
					"."
				}));
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You used '" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name + "'.");
			}
			break;
		case UseItemResult.InvalidItem:
		case UseItemResult.InvalidPokemon:
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("Failed to use '" + KGQECFKLKOP.BFNBQBMJHFL(CFHEIICNLFD.Item).Name + "'.");
			break;
		}
	}

	// Token: 0x0600433F RID: 17215 RVA: 0x0021271C File Offset: 0x0021091C
	public void NFODEGPOGLG(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().DLNELFIPOHB() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.GGBPGMMCGLI() != null))
		{
			if (MKBCKPPCIQO.HLMQODIHBIG() == -194 || MKBCKPPCIQO.DBCHHNGOKGD() == -111 || MKBCKPPCIQO.DBPKNCDGGEP == -8 || MKBCKPPCIQO.HLMQODIHBIG() == -45)
			{
				if (GNDQBCBDHKD.MKMJKLDDNDD().EKPDKPGKLBK("Sound"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.BHJGOJMDEFJ())
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.HLMQODIHBIG(),
					Move = 0,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.MIEHJOOLEHC(Guid.Empty, true, true, MKBCKPPCIQO, true);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.OPQFKGHGQKE(DBPKNCDGGEP + 0);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.FQOIMCNCFEQ(Guid.Empty, false, false, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.HJODIQPQPQC(DBPKNCDGGEP + 0);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("#,##0");
	}

	// Token: 0x06004340 RID: 17216 RVA: 0x0021286C File Offset: 0x00210A6C
	public void OONOOFJNIHK(KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int DBPKNCDGGEP)
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().HKQNOMKNEFO() && !CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			if (MKBCKPPCIQO.DBCHHNGOKGD() == -78 || MKBCKPPCIQO.FQOOHOOPFOH() == 44 || MKBCKPPCIQO.HLMQODIHBIG() == 153 || MKBCKPPCIQO.HLMQODIHBIG() == -183)
			{
				if (GNDQBCBDHKD.MKMJKLDDNDD().HEOEBDDBEIO("Blank"))
				{
					return;
				}
				GDDKPIHHICF.QOQONHOOLNE.PDKBHHPOQPJ();
			}
			switch (MKBCKPPCIQO.JILENMCJCHF)
			{
			case ItemTarget.None:
			{
				PSXAPI.Request.UseItem dcgclgqcgdq = new PSXAPI.Request.UseItem
				{
					Item = MKBCKPPCIQO.FQOOHOOPFOH(),
					Move = 0,
					Pokemon = default(Guid)
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
				break;
			}
			case ItemTarget.Pokemon:
				this.GLEBQIDOLKN.EEMHMOCLHPP(Guid.Empty, false, true, MKBCKPPCIQO, false);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.HJODIQPQPQC(DBPKNCDGGEP + 0);
				}
				break;
			case ItemTarget.Move:
				this.GLEBQIDOLKN.MIEHJOOLEHC(Guid.Empty, true, false, MKBCKPPCIQO, true);
				if (DBPKNCDGGEP > -1)
				{
					this.GLEBQIDOLKN.OPQFKGHGQKE(DBPKNCDGGEP + 1);
				}
				break;
			default:
				return;
			}
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("u");
	}

	// Token: 0x06004341 RID: 17217 RVA: 0x0001CA57 File Offset: 0x0001AC57
	public void OHCFBMPFFIP(string JBNFQFNOKHP, int NEKMFCHJGQK = 0)
	{
		base.StartCoroutine(this.PLBBQPGCNGF(JBNFQFNOKHP, NEKMFCHJGQK));
	}

	// Token: 0x06004342 RID: 17218 RVA: 0x0001CBDF File Offset: 0x0001ADDF
	public void GMBHNHJEQKC()
	{
		this.NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();
		this.JBLQIEPJLPN.LQBLJKDOFKC("(F)", 3);
		this.NIBQCHMDDHH = 1;
	}

	// Token: 0x06004343 RID: 17219 RVA: 0x0001CA50 File Offset: 0x0001AC50
	public static INFJMNPKNQF DOGEBLQHDHI()
	{
		return INFJMNPKNQF.HBFFCJHOCPE;
	}

	// Token: 0x06004344 RID: 17220 RVA: 0x0001CC04 File Offset: 0x0001AE04
	public void EBMOPEFKKOI(RegionUpdate BJGCBDNBQCJ)
	{
		this.FNGEDNLNNOJ = BJGCBDNBQCJ.Coins;
		this.BBCBFCHEIDF = BJGCBDNBQCJ.BattlePoints;
		QLKJQPNKPBC.PDPCLOECLOF().KQCKLGHEBEB();
	}

	// Token: 0x06004345 RID: 17221 RVA: 0x002129BC File Offset: 0x00210BBC
	public void AfterTween()
	{
		this.OINBPNCFPLE.enabled = false;
		this.GOJJLFQQCLH.SetActive(!this.HJLKCGFKPPB);
		foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
		{
			cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
		}
	}

	// Token: 0x06004346 RID: 17222 RVA: 0x0001CC28 File Offset: 0x0001AE28
	public void LIOHDBMEEBM(RegionUpdate BJGCBDNBQCJ)
	{
		this.FNGEDNLNNOJ = BJGCBDNBQCJ.Coins;
		this.BBCBFCHEIDF = BJGCBDNBQCJ.BattlePoints;
		QLKJQPNKPBC.PDPCLOECLOF().BMMQCLFBQKG();
	}

	// Token: 0x04000E77 RID: 3703
	private static INFJMNPKNQF HBFFCJHOCPE;

	// Token: 0x04000E78 RID: 3704
	public GameObject PNFPOQMPCJO;

	// Token: 0x04000E79 RID: 3705
	public CQLGNCIGPLG GLEBQIDOLKN;

	// Token: 0x04000E7A RID: 3706
	public BKKHLBCLPJM QJBKBGOGFKB;

	// Token: 0x04000E7B RID: 3707
	public BKKHLBCLPJM EJHCCNOOBBH;

	// Token: 0x04000E7C RID: 3708
	public BKKHLBCLPJM IGJNCOHOHMG;

	// Token: 0x04000E7D RID: 3709
	public BKKHLBCLPJM MJQLBCBDPNB;

	// Token: 0x04000E7E RID: 3710
	public uint EPDKBQCHOJQ;

	// Token: 0x04000E7F RID: 3711
	public uint QIOKIQOBMMB;

	// Token: 0x04000E80 RID: 3712
	public GameObject GEGHMKKMPBI;

	// Token: 0x04000E81 RID: 3713
	public GameObject QKNKBFNNNQP;

	// Token: 0x04000E82 RID: 3714
	public BHLIGEGNFHG BMFQIHPMEBO;

	// Token: 0x04000E83 RID: 3715
	public GameObject GOJJLFQQCLH;

	// Token: 0x04000E84 RID: 3716
	public EPIJJNOIKEK OINBPNCFPLE;

	// Token: 0x04000E85 RID: 3717
	public CFDMNELIJLO[] KMDNMJGGDHF;

	// Token: 0x04000E86 RID: 3718
	public GameObject BJFJMOHBJLP;

	// Token: 0x04000E87 RID: 3719
	public GameObject BNDPQBDPMIP;

	// Token: 0x04000E88 RID: 3720
	public BHLIGEGNFHG NQEHGDFIBOM;

	// Token: 0x04000E89 RID: 3721
	private List<KGQECFKLKOP.IJHPPMDDKIE> NGHCPLBPQEC = new List<KGQECFKLKOP.IJHPPMDDKIE>();

	// Token: 0x04000E8A RID: 3722
	private LPEQICNMHIL JBLQIEPJLPN;

	// Token: 0x04000E8B RID: 3723
	private BHLIGEGNFHG LGLQEMFNOBK;

	// Token: 0x04000E8C RID: 3724
	private OGJJKKQPNMK GMQPDFJJDPO;

	// Token: 0x04000E8D RID: 3725
	private int NHJNKMQDEKL;

	// Token: 0x04000E8E RID: 3726
	private int NIBQCHMDDHH;

	// Token: 0x04000E8F RID: 3727
	public uint FNGEDNLNNOJ;

	// Token: 0x04000E90 RID: 3728
	public uint BBCBFCHEIDF;

	// Token: 0x04000E91 RID: 3729
	public int[] DFMLMCDHNCM;

	// Token: 0x04000E92 RID: 3730
	private bool CNBFBGHGGND;

	// Token: 0x04000E93 RID: 3731
	private bool HJLKCGFKPPB;

	// Token: 0x04000E94 RID: 3732
	[CompilerGenerated]
	private static Comparison<Transform> BQIOGOCBKKB;
}
