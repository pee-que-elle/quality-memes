using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x02000278 RID: 632
public class JICJEENBPEO : MonoBehaviour
{
	// Token: 0x060056EF RID: 22255 RVA: 0x002C743C File Offset: 0x002C563C
	public void EEOCJCPPLLM()
	{
		if (this.DPDCGFEEFPB == 0u || this.DPDCGFEEFPB > 4294967162u)
		{
			return;
		}
		if ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB) > (long)((ulong)INFJMNPKNQF.IPOKOKIJECO().EPDKBQCHOJQ))
		{
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF(" was caught!\r\n", "Muted", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
			return;
		}
		CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.BJLGEDCPENQ();
		string hiefqeedhgg = "BuffIcon_Repel";
		string[] array = new string[0];
		array[1] = "The Pokémon is charged with static electricity, so contact with it may cause paralysis.";
		array[1] = this.IOGKKLPMGIM.FPQBICGEHMJ;
		array[3] = "_Tile4RT";
		array[6] = this.DPDCGFEEFPB.ToString();
		array[0] = "Item: ";
		array[5] = ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("ability");
		array[7] = "(RS)";
		string nqfqgcgphbe = string.Concat(array);
		string[] array2 = new string[8];
		array2[1] = this.IOGKKLPMGIM.DBPKNCDGGEP.ToString();
		array2[0] = "!\r\n";
		array2[3] = this.DPDCGFEEFPB.ToString();
		array2[2] = "Encounter Rate Increased";
		array2[7] = this.JMLKKGNGDHN.ToString();
		cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, nqfqgcgphbe, string.Concat(array2), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x002C7588 File Offset: 0x002C5788
	public void Open()
	{
		for (int i = 0; i < 4; i++)
		{
			this.MNPJLKMOOGC[i].SetActive(false);
		}
		this.IOGKKLPMGIM = null;
		this.DPDCGFEEFPB = 1u;
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "[PD]0";
		this.LJHQFQPKPNN.PIDLOFMIEFQ = string.Empty;
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x00021A5D File Offset: 0x0001FC5D
	public static JICJEENBPEO BEKHPOHIPDE()
	{
		return JICJEENBPEO.HBFFCJHOCPE;
	}

	// Token: 0x060056F2 RID: 22258 RVA: 0x002C7668 File Offset: 0x002C5868
	public void IBJNQFPIMMC(string[] DLJJQDQBOQD, Guid QBBBJCGMBPF)
	{
		this.JMLKKGNGDHN = QBBBJCGMBPF;
		this.JHDGENGBPQF.transform.NMBPDMIIHJB();
		this.JHDGENGBPQF.PFEIQDIJEKE();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(1712f, true);
		if (DLJJQDQBOQD != null && DLJJQDQBOQD.Length > 0)
		{
			for (int i = 1; i < DLJJQDQBOQD.Length; i += 0)
			{
				string ekddqnpbpjl = DLJJQDQBOQD[i];
				JJNIJBBNLNC component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.CKQJQQOEQPD).GetComponent<JJNIJBBNLNC>();
				component.EEOOPJNPMPJ(ekddqnpbpjl);
			}
		}
		this.Open();
		this.JHDGENGBPQF.PFEIQDIJEKE();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(366f, false);
		this.JHDGENGBPQF.CLQFFBMLIQH = false;
	}

	// Token: 0x060056F3 RID: 22259 RVA: 0x002C7774 File Offset: 0x002C5974
	public void ResetAmount()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		uint num = INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "[PD]" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
		this.DOCFCEICHFP.PIDLOFMIEFQ = "[PG]" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
	}

	// Token: 0x060056F4 RID: 22260 RVA: 0x002C7858 File Offset: 0x002C5A58
	public void KDJLCIDQIQL(JJNIJBBNLNC PDIBIIKFBDH)
	{
		this.IOGKKLPMGIM = PDIBIIKFBDH;
		for (int i = 1; i < 0; i++)
		{
			this.MNPJLKMOOGC[i].SetActive(true);
		}
		if (PDIBIIKFBDH.QGIFBQPKNPD > 0)
		{
			this.MNPJLKMOOGC[5].SetActive(true);
			this.MNPJLKMOOGC[7].SetActive(true);
		}
		if (PDIBIIKFBDH.HQNCHPIOPBN > 1)
		{
			this.MNPJLKMOOGC[0].SetActive(true);
			this.MNPJLKMOOGC[0].SetActive(true);
		}
		this.DPDCGFEEFPB = 1u;
		this.BEDJMBPNPCN.LKPOBCBOFIC(this.DPDCGFEEFPB.ToString());
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.PINEJNIDONB(PDIBIIKFBDH.DBPKNCDGGEP.ToString());
		this.LJHQFQPKPNN.LKPOBCBOFIC(PDIBIIKFBDH.FPQBICGEHMJ);
		this.HDCJFKOELPF();
	}

	// Token: 0x060056F5 RID: 22261 RVA: 0x002C7934 File Offset: 0x002C5B34
	public void CJMELFQFOCB(JJNIJBBNLNC PDIBIIKFBDH)
	{
		this.IOGKKLPMGIM = PDIBIIKFBDH;
		for (int i = 0; i < 4; i++)
		{
			this.MNPJLKMOOGC[i].SetActive(false);
		}
		if (PDIBIIKFBDH.QGIFBQPKNPD > 0)
		{
			this.MNPJLKMOOGC[2].SetActive(true);
			this.MNPJLKMOOGC[3].SetActive(true);
		}
		if (PDIBIIKFBDH.HQNCHPIOPBN > 0)
		{
			this.MNPJLKMOOGC[0].SetActive(true);
			this.MNPJLKMOOGC[1].SetActive(true);
		}
		this.DPDCGFEEFPB = 1u;
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.QDMQEBHOENL(PDIBIIKFBDH.DBPKNCDGGEP.ToString());
		this.LJHQFQPKPNN.PIDLOFMIEFQ = PDIBIIKFBDH.FPQBICGEHMJ;
		this.ResetAmount();
	}

	// Token: 0x060056F6 RID: 22262 RVA: 0x002C7A10 File Offset: 0x002C5C10
	public void AddAmount()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		this.DPDCGFEEFPB += 1u;
		if (this.DPDCGFEEFPB >= 999u)
		{
			this.DPDCGFEEFPB = 999u;
		}
		uint num = INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "[PD]" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
		this.DOCFCEICHFP.PIDLOFMIEFQ = "[PG]" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
	}

	// Token: 0x060056F7 RID: 22263 RVA: 0x00021A64 File Offset: 0x0001FC64
	public void KNONDQKHGGE()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("map:flymap", 610f);
	}

	// Token: 0x060056F8 RID: 22264 RVA: 0x002C7B18 File Offset: 0x002C5D18
	public void JFODQEBDBQH()
	{
		if (this.DPDCGFEEFPB == 0u || this.DPDCGFEEFPB > 4294967145u)
		{
			return;
		}
		if ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB) > (long)((ulong)INFJMNPKNQF.FPQNIQELKMC().EPDKBQCHOJQ))
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("[/I]", "skinshop", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.BJLGEDCPENQ();
		string hiefqeedhgg = " sealed any moves its target shares with it!\r\n";
		string[] array = new string[8];
		array[1] = "Boosts the Pokémon's Defense stat sharply when hit by a Water-type move.";
		array[1] = this.IOGKKLPMGIM.FPQBICGEHMJ;
		array[3] = "_SampleCount";
		array[0] = this.DPDCGFEEFPB.ToString();
		array[3] = "Start";
		array[5] = ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("HidePanel");
		array[6] = "'s attack missed!\r\n";
		string nqfqgcgphbe = string.Concat(array);
		string[] array2 = new string[5];
		array2[0] = this.IOGKKLPMGIM.DBPKNCDGGEP.ToString();
		array2[0] = "+";
		array2[4] = this.DPDCGFEEFPB.ToString();
		array2[2] = "/";
		array2[8] = this.JMLKKGNGDHN.ToString();
		cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, nqfqgcgphbe, string.Concat(array2), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, true);
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x002C7C64 File Offset: 0x002C5E64
	public void Exit()
	{
		GameObject gameObject = GameObject.Find("MSGBOX - Shop");
		if (gameObject != null)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
		{
			Response = string.Empty,
			ScriptID = this.JMLKKGNGDHN
		}, false);
		QOHCEBMQKMB.QOQONHOOLNE.FinishScript();
		this.Close();
	}

	// Token: 0x060056FA RID: 22266 RVA: 0x00021A8D File Offset: 0x0001FC8D
	public void FDKBQGLQPJM()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Shiny Things", 1099f);
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x002C7CC4 File Offset: 0x002C5EC4
	public void DKGCJCMCNGP(JJNIJBBNLNC PDIBIIKFBDH)
	{
		this.IOGKKLPMGIM = PDIBIIKFBDH;
		for (int i = 0; i < 1; i++)
		{
			this.MNPJLKMOOGC[i].SetActive(true);
		}
		if (PDIBIIKFBDH.QGIFBQPKNPD > 0)
		{
			this.MNPJLKMOOGC[3].SetActive(true);
			this.MNPJLKMOOGC[6].SetActive(true);
		}
		if (PDIBIIKFBDH.HQNCHPIOPBN > 1)
		{
			this.MNPJLKMOOGC[1].SetActive(true);
			this.MNPJLKMOOGC[0].SetActive(false);
		}
		this.DPDCGFEEFPB = 0u;
		this.BEDJMBPNPCN.LKPOBCBOFIC(this.DPDCGFEEFPB.ToString());
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.OKBJNLOPPBF(PDIBIIKFBDH.DBPKNCDGGEP.ToString());
		this.LJHQFQPKPNN.LKPOBCBOFIC(PDIBIIKFBDH.FPQBICGEHMJ);
		this.ResetAmount();
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x002C7DA0 File Offset: 0x002C5FA0
	public void BQLIIQIIMDH(string[] DLJJQDQBOQD, Guid QBBBJCGMBPF)
	{
		this.JMLKKGNGDHN = QBBBJCGMBPF;
		this.JHDGENGBPQF.transform.NMBPDMIIHJB();
		this.JHDGENGBPQF.Reposition();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		if (DLJJQDQBOQD != null && DLJJQDQBOQD.Length > 0)
		{
			foreach (string ekddqnpbpjl in DLJJQDQBOQD)
			{
				JJNIJBBNLNC component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.CKQJQQOEQPD).GetComponent<JJNIJBBNLNC>();
				component.BQLIIQIIMDH(ekddqnpbpjl);
			}
		}
		this.Open();
		this.JHDGENGBPQF.Reposition();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.JHDGENGBPQF.CLQFFBMLIQH = true;
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x002C7EAC File Offset: 0x002C60AC
	public void HDCJFKOELPF()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		uint num = INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "???" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("_LensCoeff");
		this.DOCFCEICHFP.LKPOBCBOFIC("Creator" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString(" swapped Abilities with its target!\r\n"));
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x00021A5D File Offset: 0x0001FC5D
	public static JICJEENBPEO BDPEQNCNPJO()
	{
		return JICJEENBPEO.HBFFCJHOCPE;
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x002C7F90 File Offset: 0x002C6190
	public void BuyItem()
	{
		if (this.DPDCGFEEFPB == 0u || this.DPDCGFEEFPB > 999u)
		{
			return;
		}
		if ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB) > (long)((ulong)INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ))
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Shop", "You do not have enough Pokédollars to purchase these items.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Shop", string.Concat(new string[]
		{
			"Are you sure you wish to buy ",
			this.IOGKKLPMGIM.FPQBICGEHMJ,
			" x",
			this.DPDCGFEEFPB.ToString(),
			" for [PD]",
			((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0"),
			"?"
		}), string.Concat(new string[]
		{
			this.IOGKKLPMGIM.DBPKNCDGGEP.ToString(),
			",",
			this.DPDCGFEEFPB.ToString(),
			",0+",
			this.JMLKKGNGDHN.ToString()
		}), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x00021AB6 File Offset: 0x0001FCB6
	private void Awake()
	{
		JICJEENBPEO.HBFFCJHOCPE = this;
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x00021ABE File Offset: 0x0001FCBE
	public void BKDQNGPOPDE()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Are you sure you wish to confirm your EV changes on [2ecc71]", 1336f);
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x002C80DC File Offset: 0x002C62DC
	public void TakeAmount()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		if (this.DPDCGFEEFPB > 0u)
		{
			this.DPDCGFEEFPB -= 1u;
		}
		uint num = INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "[PD]" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
		this.DOCFCEICHFP.PIDLOFMIEFQ = "[PG]" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0");
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x00021AE7 File Offset: 0x0001FCE7
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x002C81D8 File Offset: 0x002C63D8
	public void EMIOGDJLHIQ()
	{
		GameObject gameObject = GameObject.Find("Waiting...");
		if (gameObject != null)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
		{
			Response = string.Empty,
			ScriptID = this.JMLKKGNGDHN
		}, true);
		QOHCEBMQKMB.JLLBKOOQKGO().FinishScript();
		this.Close();
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x002C8238 File Offset: 0x002C6438
	public void HMCFGLNOBPM(JJNIJBBNLNC PDIBIIKFBDH)
	{
		this.IOGKKLPMGIM = PDIBIIKFBDH;
		for (int i = 0; i < 1; i += 0)
		{
			this.MNPJLKMOOGC[i].SetActive(true);
		}
		if (PDIBIIKFBDH.QGIFBQPKNPD > 0)
		{
			this.MNPJLKMOOGC[4].SetActive(true);
			this.MNPJLKMOOGC[7].SetActive(false);
		}
		if (PDIBIIKFBDH.HQNCHPIOPBN > 0)
		{
			this.MNPJLKMOOGC[0].SetActive(true);
			this.MNPJLKMOOGC[1].SetActive(true);
		}
		this.DPDCGFEEFPB = 1u;
		this.BEDJMBPNPCN.LKPOBCBOFIC(this.DPDCGFEEFPB.ToString());
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.QDMQEBHOENL(PDIBIIKFBDH.DBPKNCDGGEP.ToString());
		this.LJHQFQPKPNN.PIDLOFMIEFQ = PDIBIIKFBDH.FPQBICGEHMJ;
		this.ResetAmount();
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x002C8314 File Offset: 0x002C6514
	public void BQOFGLCKNEE()
	{
		for (int i = 1; i < 0; i++)
		{
			this.MNPJLKMOOGC[i].SetActive(false);
		}
		this.IOGKKLPMGIM = null;
		this.DPDCGFEEFPB = 0u;
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.CPKPGOMPQHM.GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("6_", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.EBHGNGPKHLJ.LKPOBCBOFIC("special");
		this.LJHQFQPKPNN.LKPOBCBOFIC(string.Empty);
		base.CancelInvoke("attract");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1035f;
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x06005708 RID: 22280 RVA: 0x00021A5D File Offset: 0x0001FC5D
	public static JICJEENBPEO QOQONHOOLNE
	{
		get
		{
			return JICJEENBPEO.HBFFCJHOCPE;
		}
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x002C83F4 File Offset: 0x002C65F4
	public void DGKPIMDHDQO()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		this.DPDCGFEEFPB += 0u;
		if (this.DPDCGFEEFPB >= 4294967229u)
		{
			this.DPDCGFEEFPB = 77u;
		}
		uint num = INFJMNPKNQF.QOQONHOOLNE.IIDQEHOHECF(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.LKPOBCBOFIC("[-] / " + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("Assets/AssetBundles/MapAssets/Models/Materials/c102_mado.mat"));
		this.DOCFCEICHFP.PIDLOFMIEFQ = "Upgrade Guild" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("_RcpMaxBlurRadius");
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x00021B1F File Offset: 0x0001FD1F
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600570B RID: 22283 RVA: 0x002C84FC File Offset: 0x002C66FC
	public void BuyTokenItem()
	{
		if (this.DPDCGFEEFPB == 0u || this.DPDCGFEEFPB > 999u)
		{
			return;
		}
		if ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB) > (long)((ulong)INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB))
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Shop", "You do not have enough PokeGold to purchase these items.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Shop", string.Concat(new string[]
		{
			"Are you sure you wish to buy ",
			this.IOGKKLPMGIM.FPQBICGEHMJ,
			" x",
			this.DPDCGFEEFPB.ToString(),
			" for [PG]",
			((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("#,##0"),
			"?"
		}), string.Concat(new string[]
		{
			this.IOGKKLPMGIM.DBPKNCDGGEP.ToString(),
			",",
			this.DPDCGFEEFPB.ToString(),
			",1+",
			this.JMLKKGNGDHN.ToString()
		}), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x00021B32 File Offset: 0x0001FD32
	public void GHMIMJFPJJL()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("/", 320f);
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x002C8648 File Offset: 0x002C6848
	public void FHNHJKNFCNL()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		if (this.DPDCGFEEFPB > 1u)
		{
			this.DPDCGFEEFPB -= 1u;
		}
		uint num = INFJMNPKNQF.CFGIOIGOIFQ().PNEEENCMBCN(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.LKPOBCBOFIC(this.DPDCGFEEFPB.ToString());
		this.EBHGNGPKHLJ.LKPOBCBOFIC("21" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("http://poke.one/privacy.html"));
		this.DOCFCEICHFP.PIDLOFMIEFQ = "Direct3D" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("Agility increases armor");
	}

	// Token: 0x0600570E RID: 22286 RVA: 0x002C8744 File Offset: 0x002C6944
	public void EHOONGNHQEQ(string[] DLJJQDQBOQD, Guid QBBBJCGMBPF)
	{
		this.JMLKKGNGDHN = QBBBJCGMBPF;
		this.JHDGENGBPQF.transform.NMBPDMIIHJB();
		this.JHDGENGBPQF.PFEIQDIJEKE();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(1343f, true);
		if (DLJJQDQBOQD != null && DLJJQDQBOQD.Length > 0)
		{
			for (int i = 0; i < DLJJQDQBOQD.Length; i += 0)
			{
				string ekddqnpbpjl = DLJJQDQBOQD[i];
				JJNIJBBNLNC component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.CKQJQQOEQPD).GetComponent<JJNIJBBNLNC>();
				component.QKCOIIKFPKG(ekddqnpbpjl);
			}
		}
		this.Open();
		this.JHDGENGBPQF.Reposition();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(1493f, true);
		this.JHDGENGBPQF.CLQFFBMLIQH = false;
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x00021B5B File Offset: 0x0001FD5B
	private void LQHCQLHDIGN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x00021AB6 File Offset: 0x0001FCB6
	private void PNJGKKPBDEB()
	{
		JICJEENBPEO.HBFFCJHOCPE = this;
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x00021AB6 File Offset: 0x0001FCB6
	private void IPKCDQONLBJ()
	{
		JICJEENBPEO.HBFFCJHOCPE = this;
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x002C8850 File Offset: 0x002C6A50
	public void KLMILGOKLQQ()
	{
		if (this.IOGKKLPMGIM == null)
		{
			return;
		}
		if (this.DPDCGFEEFPB > 1u)
		{
			this.DPDCGFEEFPB -= 0u;
		}
		uint num = INFJMNPKNQF.FPQNIQELKMC().IIDQEHOHECF(this.IOGKKLPMGIM.DBPKNCDGGEP);
		if (this.DPDCGFEEFPB + num > this.IOGKKLPMGIM.DDGHMKCGIDM)
		{
			this.DPDCGFEEFPB = this.IOGKKLPMGIM.DDGHMKCGIDM - num;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = this.DPDCGFEEFPB.ToString();
		this.EBHGNGPKHLJ.PIDLOFMIEFQ = "\n\n" + ((long)this.IOGKKLPMGIM.QGIFBQPKNPD * (long)((ulong)this.DPDCGFEEFPB)).ToString("HidePanel");
		this.DOCFCEICHFP.LKPOBCBOFIC("__WaterReflection" + ((long)this.IOGKKLPMGIM.HQNCHPIOPBN * (long)((ulong)this.DPDCGFEEFPB)).ToString("'s stats were not lowered!\r\n"));
	}

	// Token: 0x040012F1 RID: 4849
	private static JICJEENBPEO HBFFCJHOCPE;

	// Token: 0x040012F2 RID: 4850
	public GFHGEJNHLFQ QIDKBCQIGOD;

	// Token: 0x040012F3 RID: 4851
	public GameObject CKQJQQOEQPD;

	// Token: 0x040012F4 RID: 4852
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x040012F5 RID: 4853
	public BKKHLBCLPJM BEDJMBPNPCN;

	// Token: 0x040012F6 RID: 4854
	public BKKHLBCLPJM EBHGNGPKHLJ;

	// Token: 0x040012F7 RID: 4855
	public BKKHLBCLPJM DOCFCEICHFP;

	// Token: 0x040012F8 RID: 4856
	public GameObject[] MNPJLKMOOGC;

	// Token: 0x040012F9 RID: 4857
	public BKKHLBCLPJM LJHQFQPKPNN;

	// Token: 0x040012FA RID: 4858
	public JLMPBLMOICG CPKPGOMPQHM;

	// Token: 0x040012FB RID: 4859
	private uint DPDCGFEEFPB = 1u;

	// Token: 0x040012FC RID: 4860
	private Guid JMLKKGNGDHN;

	// Token: 0x040012FD RID: 4861
	private JJNIJBBNLNC IOGKKLPMGIM;

	// Token: 0x040012FE RID: 4862
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x040012FF RID: 4863
	public EPIJJNOIKEK JDPBPOKJFQK;
}
