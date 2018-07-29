using System;
using PSXAPI.Request;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000202 RID: 514
public class KJMPLFDOBCO : MonoBehaviour
{
	// Token: 0x060043C9 RID: 17353 RVA: 0x0001CCF2 File Offset: 0x0001AEF2
	public void Hide()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x00213274 File Offset: 0x00211474
	public bool KFKHHOGFLFN()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1724f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KPJLEOCJFFO();
					this.DLGQLKEHGPK();
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060043CB RID: 17355 RVA: 0x00213388 File Offset: 0x00211588
	public bool LGMNEFJMQGQ()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.FNHEJBQLCPC();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060043CC RID: 17356 RVA: 0x0021349C File Offset: 0x0021169C
	public void ENQGBOPIMMI(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 1)
		{
			accept = true;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.NOPGJPQOMCF();
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x002134FC File Offset: 0x002116FC
	public void EQJJKIQEQIB(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 6)
		{
			accept = true;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.NCQNCIKIEOI();
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x0021355C File Offset: 0x0021175C
	public void DDQJJEDGLEE(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 1)
		{
			accept = true;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.NPCKENGDEIN();
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x002135BC File Offset: 0x002117BC
	public bool MMILFGHODMJ()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 786f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KGMFIOCJLEP();
					this.GGCIBDGEKHN();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x002136D0 File Offset: 0x002118D0
	public bool KPICCIQHJFF()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 465f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.FLBBQCCBJHP();
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x002137E4 File Offset: 0x002119E4
	public bool PMGOHPOHPHD()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 905f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[1]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.FCQMGQOEDLJ();
					this.JGCMQIMJEHN();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060043D2 RID: 17362 RVA: 0x002138F8 File Offset: 0x00211AF8
	private void COFOCEENHBE()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[6];
		array[1] = "[{";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[8] = "Doubles the Pokémon's weight.";
		array[3] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = "Active: ";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("blinky" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().IHDMPDEGKPG();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "a" + this.EMFQIGCGPNM.IJQJPCBFNMP + "The Pokémon gradually regains HP in a hailstorm." + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[6].LKPOBCBOFIC(moveInfo.QCBKIHIKPCG());
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].IQBBDKFDGGP(moveInfo.CMOOQIDINKO().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == ")")
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "switcheroo";
		}
		else if (moveInfo.QHEJQOCDJGL() == "Creator")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "special";
		}
		else
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("CombinersAlphaPassThrough");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -124 && fekoiojqnkh.CCMOCLMEKJN() % -48 > 0)
		{
			str = "BuffIcon_MaxRepel" + (fekoiojqnkh.QKNEIJQHGCB % -71).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" was frozen solid!\r\n" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 960f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x060043D3 RID: 17363 RVA: 0x00213B94 File Offset: 0x00211D94
	public bool DFFQHPJHBEN()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1992f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.FCQMGQOEDLJ();
					this.QPBLFLHOKCF();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x00213CA8 File Offset: 0x00211EA8
	public bool JNMGNMOIHNK()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1059f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KGMFIOCJLEP();
					this.QJGNFCIDQJH();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x060043D5 RID: 17365 RVA: 0x00213DBC File Offset: 0x00211FBC
	public bool LMLPBOOMMQP()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 224f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KGMFIOCJLEP();
					this.GGCIBDGEKHN();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x0001CD21 File Offset: 0x0001AF21
	public void JHOQQHDCCPD()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 566f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x00213ED0 File Offset: 0x002120D0
	public void EOLCJJFFIDN(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 5)
		{
			accept = true;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.LOMHCPLPHLH();
	}

	// Token: 0x060043D8 RID: 17368 RVA: 0x0001CD50 File Offset: 0x0001AF50
	public void NPCKENGDEIN()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 952f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060043D9 RID: 17369 RVA: 0x0001CD7F File Offset: 0x0001AF7F
	public void NOPGJPQOMCF()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 375f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060043DA RID: 17370 RVA: 0x00213F30 File Offset: 0x00212130
	private void GGCIBDGEKHN()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[4];
		array[0] = "battlebag";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[0] = " - ";
		array[0] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[5] = "Icon_Achievement_Incomplete";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "safeguard" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().Hide();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "\n" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Current Camera Position" + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[1].KCLBMPFIPNQ = moveInfo.MGQFELMKFFK().ToLowerInvariant();
		if (moveInfo.DPDGNFHLQMF() == "0")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ(" traced ");
		}
		else if (moveInfo.DPDGNFHLQMF() == "Assets/AssetBundles/Pokes")
		{
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("b");
		}
		else
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("There is no relief from this heavy rain!\r\n");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 3 && fekoiojqnkh.QKNEIJQHGCB % -88 > 1)
		{
			str = "focussash" + (fekoiojqnkh.CCMOCLMEKJN() % -35).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("LeftS" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 534f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x060043DB RID: 17371 RVA: 0x002141CC File Offset: 0x002123CC
	public bool LKOPKCDKGJN()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 211f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.BLOFIFJCGIF();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060043DC RID: 17372 RVA: 0x002142E0 File Offset: 0x002124E0
	public bool MNLKDJHLKMI()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 879f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[1]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KPJLEOCJFFO();
					this.DJDLPMBQMJE();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x060043DD RID: 17373 RVA: 0x002143F4 File Offset: 0x002125F4
	public void FJGGHQEOEKK(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 0)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.IBIPLHPFNHP();
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x00214454 File Offset: 0x00212654
	public void CEGPGJBLIIC(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 7)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.IBIPLHPFNHP();
	}

	// Token: 0x060043DF RID: 17375 RVA: 0x002144B4 File Offset: 0x002126B4
	private void QJGNFCIDQJH()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[4];
		array[1] = "waterbubble";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[8] = "trapped";
		array[3] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[4] = "triage";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("V" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().EOFQFOHJLBJ();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("Boosts its Speed stat if hit by an Electric-type move, instead of taking damage." + this.EMFQIGCGPNM.IJQJPCBFNMP + "zenmode" + moveInfo.MEQCECHDEIP());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[5].PIDLOFMIEFQ = moveInfo.BLLFNBKDCMJ();
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[1].JOHBNEHCEJH(moveInfo.Type.ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "frisk")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("Spectator");
		}
		else if (moveInfo.Category == "!\r\n")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "[FFFF00]/252";
		}
		else
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("#,##0");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -12 && fekoiojqnkh.QKNEIJQHGCB % 23 > 1)
		{
			str = "\n  Expected: " + (fekoiojqnkh.CCMOCLMEKJN() % 113).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("2" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1735f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x00214750 File Offset: 0x00212950
	private void JGCMQIMJEHN()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[6];
		array[0] = "F";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[7] = "[ffb649]";
		array[2] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = " became trapped by swirling magma!\r\n";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "English" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().JKDLOBKIEKO();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "~" + this.EMFQIGCGPNM.IJQJPCBFNMP + " ended!\r\n" + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[5].PIDLOFMIEFQ = moveInfo.BLLFNBKDCMJ();
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].IQBBDKFDGGP(moveInfo.CMOOQIDINKO().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "OnPress")
		{
			this.MPMOKOOHPLI[1].LGJOOQIBQDC(" minutes");
		}
		else if (moveInfo.Category == "(R)")
		{
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("Water Bubble");
		}
		else
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("[b]");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 148 && fekoiojqnkh.CCMOCLMEKJN() % 33 > 0)
		{
			str = "pdata" + (fekoiojqnkh.QKNEIJQHGCB % 71).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("sleep" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1598f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x0001CDAE File Offset: 0x0001AFAE
	public void NGLGQEQQCGE()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1650f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x002149EC File Offset: 0x00212BEC
	private void FLBBQCCBJHP()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[7];
		array[0] = "/03_1";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[3] = "!\r\n";
		array[8] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[6] = "Would like to purchase another Pokébox?\nCost: ";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "rebound" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().ELGNDMGHCOL();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("_Emission" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Lv. " + moveInfo.MEQCECHDEIP());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[5].PIDLOFMIEFQ = moveInfo.BLLFNBKDCMJ();
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[1].JLENFJGDNFN(moveInfo.MGQFELMKFFK().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "Enabled")
		{
			this.MPMOKOOHPLI[0].JLENFJGDNFN("[00DD00]Equipped");
		}
		else if (moveInfo.DPDGNFHLQMF() == "[00FF00]You gained ")
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("_ClipToWorld");
		}
		else
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "powertrick";
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -89 && fekoiojqnkh.QKNEIJQHGCB % -102 > 0)
		{
			str = "Multitype" + (fekoiojqnkh.CCMOCLMEKJN() % -57).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("voltabsorb" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 648f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x0001CDDD File Offset: 0x0001AFDD
	public void DBLFCKCBBLK()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1311f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x0001CE0C File Offset: 0x0001B00C
	public void GDLEGQCOHEO()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1103f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x00214C88 File Offset: 0x00212E88
	private void DLGQLKEHGPK()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[3];
		array[1] = "p2";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[5] = ":";
		array[4] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[4] = "Powers up moves that have recoil damage.";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "luckychant" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().OGODIHONMHJ();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("-primal" + this.EMFQIGCGPNM.IJQJPCBFNMP + "HidePanel" + moveInfo.PP);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.QPGFMHBJPCE();
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[1].KCLBMPFIPNQ = moveInfo.OCCQGODQGPC().ToLowerInvariant();
		if (moveInfo.Category == "_Scale")
		{
			this.MPMOKOOHPLI[1].LGJOOQIBQDC("clamp");
		}
		else if (moveInfo.DPDGNFHLQMF() == "!\r\n")
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("electricsurge");
		}
		else
		{
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("[000000]..");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 164 && fekoiojqnkh.QKNEIJQHGCB % -57 > 0)
		{
			str = "CombinersArgsColorSrc2" + (fekoiojqnkh.CCMOCLMEKJN() % -108).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Upgrade Guild" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 219f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x00214F24 File Offset: 0x00213124
	private void IMIGEKKNJOD()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[6];
		array[0] = "~";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[0] = "_ReflectionTexture3";
		array[2] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = " fell";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("#,##0" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().OGODIHONMHJ();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("Great Ball" + this.EMFQIGCGPNM.IJQJPCBFNMP + "´" + moveInfo.PP);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.QPGFMHBJPCE());
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[1].KCLBMPFIPNQ = moveInfo.CMOOQIDINKO().ToLowerInvariant();
		if (moveInfo.Category == "_EmissionColor")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("OnPress");
		}
		else if (moveInfo.DPDGNFHLQMF() == "setrandom(")
		{
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("Emails do not match");
		}
		else
		{
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("BuffIcon_ElectricIncrease");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 151 && fekoiojqnkh.CCMOCLMEKJN() % -72 > 0)
		{
			str = "-primal" + (fekoiojqnkh.QKNEIJQHGCB % 51).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("#,##0" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1086f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x002151C0 File Offset: 0x002133C0
	private void HKCDOQBPHNN()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[]
		{
			null,
			"lifeorb"
		};
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[0] = "Cursed Body";
		array[6] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[5] = "The Pokémon's determination boosts the Speed stat each time the Pokémon flinches.";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = " day ago" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().MLMHLQFHMBM();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "Already in Guild" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Unlit/Transparent Colored" + moveInfo.PP;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(moveInfo.QPGFMHBJPCE());
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].DPBGHDMHKNC(moveInfo.MGQFELMKFFK().ToLowerInvariant());
		if (moveInfo.Category == "Raises one stat sharply and lowers another every turn.")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("19");
		}
		else if (moveInfo.QHEJQOCDJGL() == "][{")
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN(" was hurt by its burn!\r\n");
		}
		else
		{
			this.MPMOKOOHPLI[1].JOHBNEHCEJH("\n");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 181 && fekoiojqnkh.CCMOCLMEKJN() % -10 > 0)
		{
			str = "_Dissolve" + (fekoiojqnkh.CCMOCLMEKJN() % 123).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Fly" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 415f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x0021545C File Offset: 0x0021365C
	private void GBJJNNGDQBH()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[0];
		array[0] = "Grass grew to cover the battlefield!\r\n";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[1] = "\n  Received: ";
		array[5] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[0] = "[33CCFF]";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = " thanks to its [ffff00]Safety Goggles[-]!\r\n" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().HNMHKIJEDIE();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "CombinersAlphaCombine" + this.EMFQIGCGPNM.IJQJPCBFNMP + "s" + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = moveInfo.BLLFNBKDCMJ();
		this.QHEJPNJNMCI[2].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[1].LGJOOQIBQDC(moveInfo.DBQIBEDQKCF().ToLowerInvariant());
		if (moveInfo.QHEJQOCDJGL() == "[-], do you want your [FF9900]")
		{
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("Pokédex");
		}
		else if (moveInfo.DPDGNFHLQMF() == "attract")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "berry_15";
		}
		else
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("Max Repel");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -148 && fekoiojqnkh.CCMOCLMEKJN() % -51 > 0)
		{
			str = "Jump" + (fekoiojqnkh.CCMOCLMEKJN() % 126).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("Regenerator" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 406f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x002156F8 File Offset: 0x002138F8
	public void PCOHGQPFBKM(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 8)
		{
			accept = false;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.GCBLHFEIBEG();
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x00215758 File Offset: 0x00213958
	private void NQQFLGHPDHO()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[7];
		array[0] = "Battle";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[1] = "Pokeball_Success";
		array[4] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[3] = "]#";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("#,##0" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().NPCKENGDEIN();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "/" + this.EMFQIGCGPNM.IJQJPCBFNMP + "RenderType" + moveInfo.PP;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[0].IQBBDKFDGGP(moveInfo.Type.ToLowerInvariant());
		if (moveInfo.Category == "-start")
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("Add to Friends");
		}
		else if (moveInfo.Category == "!\r\n")
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("English");
		}
		else
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "Toxic Boost";
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -145 && fekoiojqnkh.QKNEIJQHGCB % 60 > 0)
		{
			str = "Vertical" + (fekoiojqnkh.QKNEIJQHGCB % -40).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("[sub]" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 969f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x002159F4 File Offset: 0x00213BF4
	private void JHJKQBOJFKO()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[4];
		array[1] = "[-]";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[3] = "firelamp_off";
		array[6] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = " EXP[-]";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC(" is radiating a fairy aura!\r\n" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().MKDQBHKNEDE();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("6" + this.EMFQIGCGPNM.IJQJPCBFNMP + "#,##0" + moveInfo.PP);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].KCLBMPFIPNQ = moveInfo.MGQFELMKFFK().ToLowerInvariant();
		if (moveInfo.Category == " tucked in its head!\r\n")
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("The grass disappeared from the battlefield.\r\n");
		}
		else if (moveInfo.DPDGNFHLQMF() == "!\r\n")
		{
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("-");
		}
		else
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("!\r\n");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -143 && fekoiojqnkh.CCMOCLMEKJN() % -33 > 0)
		{
			str = "HidePanel" + (fekoiojqnkh.QKNEIJQHGCB % 4).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("' was successful." + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 525f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x00215C90 File Offset: 0x00213E90
	private void DFOEKDEOGMG()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[2];
		array[0] = "_DetailOffsetY";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[7] = "Close";
		array[5] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = "Btn_Tab_Click";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("gravity" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().MLMHLQFHMBM();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("fairyaura" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Its Speed stat is boosted every turn." + moveInfo.MEQCECHDEIP());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[8].LKPOBCBOFIC(moveInfo.QPGFMHBJPCE());
		this.QHEJPNJNMCI[7].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[1].JLENFJGDNFN(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.Category == "5|")
		{
			this.MPMOKOOHPLI[0].JOHBNEHCEJH("+");
		}
		else if (moveInfo.DPDGNFHLQMF() == "[-]!\r\n")
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ(" type was added to ");
		}
		else
		{
			this.MPMOKOOHPLI[1].JOHBNEHCEJH("Other Cells gather to aid when its HP becomes half or less. Then the Pokémon changes its form to Complete Forme.");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 146 && fekoiojqnkh.CCMOCLMEKJN() % -86 > 1)
		{
			str = "[-][/urn]: " + (fekoiojqnkh.CCMOCLMEKJN() % -117).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("[/pok]" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1180f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x00215F2C File Offset: 0x0021412C
	public bool HJHGIFMFNFL()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 538f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.JCCEHCNBNPM();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x00216040 File Offset: 0x00214240
	private void DJDLPMBQMJE()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[0];
		array[0] = "Big/";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[2] = "Battle";
		array[5] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[4] = "blinky";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "CHROMATIC_ABERRATION" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().GPHPEIJKIHQ();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("Snowy" + this.EMFQIGCGPNM.IJQJPCBFNMP + "--offline" + moveInfo.MEQCECHDEIP());
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[8].LKPOBCBOFIC(moveInfo.QCBKIHIKPCG());
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].KCLBMPFIPNQ = moveInfo.Type.ToLowerInvariant();
		if (moveInfo.QHEJQOCDJGL() == "Moxie")
		{
			this.MPMOKOOHPLI[0].JOHBNEHCEJH(" [M]");
		}
		else if (moveInfo.DPDGNFHLQMF() == "Take 001")
		{
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("sandtomb");
		}
		else
		{
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("\n[29e000]Friendly Pokémon");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 15 && fekoiojqnkh.CCMOCLMEKJN() % -104 > 0)
		{
			str = "Mouse X" + (fekoiojqnkh.QKNEIJQHGCB % -109).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("HidePanel" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 522f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x002162DC File Offset: 0x002144DC
	public void JCGFFFIHECQ(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 1)
		{
			accept = true;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.EPLHDQPGHNC();
	}

	// Token: 0x060043F0 RID: 17392 RVA: 0x0021633C File Offset: 0x0021453C
	public void FGELDHMIIEC(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 2)
		{
			accept = true;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.IFGGJPEHQJD();
	}

	// Token: 0x060043F1 RID: 17393 RVA: 0x0021639C File Offset: 0x0021459C
	private void INFOFJEQLJF()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[6];
		array[0] = "[-] made it the ";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[4] = "Unlit/Transparent Colored";
		array[2] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[2] = "firespin";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "WATER_SIMPLE" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().QGJPMKPOGKN();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "K5" + this.EMFQIGCGPNM.IJQJPCBFNMP + "OnDragOver" + moveInfo.MEQCECHDEIP();
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[6].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[5].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].LGJOOQIBQDC(moveInfo.CMOOQIDINKO().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "pursuit")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "ability: ";
		}
		else if (moveInfo.DPDGNFHLQMF() == "Passes through the opposing Pokémon's barrier, substitute, and the like and strikes.")
		{
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("HideResponse");
		}
		else
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("Guild Success");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 3 && fekoiojqnkh.QKNEIJQHGCB % 0 > 0)
		{
			str = "Guild" + (fekoiojqnkh.CCMOCLMEKJN() % 50).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP(" caused an uproar!\r\n" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 502f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060043F2 RID: 17394 RVA: 0x00216638 File Offset: 0x00214838
	private void JJNQLJIDPBJ()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[3];
		array[0] = "mummy";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[7] = "Purchasing";
		array[3] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[4] = "[Lv]";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "?" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().NJLLLEIOGGF();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "-fail" + this.EMFQIGCGPNM.IJQJPCBFNMP + "_FogOfWarSize" + moveInfo.PP;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.QCBKIHIKPCG();
		this.QHEJPNJNMCI[2].LKPOBCBOFIC(moveInfo.Power);
		this.MPMOKOOHPLI[1].JLENFJGDNFN(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.QHEJQOCDJGL() == "bag")
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("clamp");
		}
		else if (moveInfo.DPDGNFHLQMF() == "General")
		{
			this.MPMOKOOHPLI[1].LGJOOQIBQDC("HidePanel");
		}
		else
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "[00FF00]You received [PD]";
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 191 && fekoiojqnkh.CCMOCLMEKJN() % -36 > 0)
		{
			str = "Fullscreen" + (fekoiojqnkh.QKNEIJQHGCB % -83).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Vertical" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 77f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060043F3 RID: 17395 RVA: 0x0001CE3B File Offset: 0x0001B03B
	public void LOMHCPLPHLH()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1470f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060043F4 RID: 17396 RVA: 0x002168D4 File Offset: 0x00214AD4
	public bool CHBNKBGPPCJ()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 787f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.FCQMGQOEDLJ();
					this.COFOCEENHBE();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x060043F5 RID: 17397 RVA: 0x002169E8 File Offset: 0x00214BE8
	public void IGIQKFGHCNM(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 3)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.NPCKENGDEIN();
	}

	// Token: 0x060043F6 RID: 17398 RVA: 0x00216A48 File Offset: 0x00214C48
	public bool BHODMQBBBDM()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 689f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[1]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.FCQMGQOEDLJ();
					this.QLFELLIQLPG();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x00216B5C File Offset: 0x00214D5C
	public void FKFHMFOFGEH(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 3)
		{
			accept = false;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.DBLFCKCBBLK();
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x00216BBC File Offset: 0x00214DBC
	private void BLOFIFJCGIF()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[0];
		array[0] = " used [ffff00]";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[3] = "!\r\n";
		array[6] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = "[PG]";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("cloudnine" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().IMOBOQMJNPH();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("bulletproof" + this.EMFQIGCGPNM.IJQJPCBFNMP + "   " + moveInfo.MEQCECHDEIP());
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.QCBKIHIKPCG();
		this.QHEJPNJNMCI[4].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[1].IQBBDKFDGGP(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.QHEJQOCDJGL() == "Rattled")
		{
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("_FogPointLightColor0");
		}
		else if (moveInfo.QHEJQOCDJGL() == "clamp")
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN(" (Completed)");
		}
		else
		{
			this.MPMOKOOHPLI[0].DPBGHDMHKNC("The Pokémon's proud of its powerful pincers. They prevent other Pokémon from lowering its Attack stat.");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 95 && fekoiojqnkh.CCMOCLMEKJN() % 120 > 0)
		{
			str = "0" + (fekoiojqnkh.QKNEIJQHGCB % 52).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("W" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1702f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060043F9 RID: 17401 RVA: 0x0001CE6A File Offset: 0x0001B06A
	public void CFOLMNMMODO()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 553f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x0001CE99 File Offset: 0x0001B099
	public void EPLHDQPGHNC()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 790f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x00216E58 File Offset: 0x00215058
	public void ChooseMove(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 5)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.Hide();
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x002162DC File Offset: 0x002144DC
	public void LIPBLGBJKBH(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 1)
		{
			accept = true;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.EPLHDQPGHNC();
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x00216EB8 File Offset: 0x002150B8
	public bool KMEODDHFOBK()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 113f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 1)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KPJLEOCJFFO();
					this.INFOFJEQLJF();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060043FE RID: 17406 RVA: 0x00216FCC File Offset: 0x002151CC
	public bool KMOCBNPHEIC()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1832f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.FCQMGQOEDLJ();
					this.JHJKQBOJFKO();
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
	public void IBIPLHPFNHP()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1035f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x002170E0 File Offset: 0x002152E0
	private void LQHKNJLDNEM()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[8];
		array[0] = "17";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[7] = "[BATTLE]";
		array[7] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[6] = "Party";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "/force right" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().GDLEGQCOHEO();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "Wild Encounters:" + this.EMFQIGCGPNM.IJQJPCBFNMP + "CombinersColorScale" + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[2].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[0].KCLBMPFIPNQ = moveInfo.MGQFELMKFFK().ToLowerInvariant();
		if (moveInfo.DPDGNFHLQMF() == "FOG_AREA_SPHERE")
		{
			this.MPMOKOOHPLI[0].JLENFJGDNFN("301");
		}
		else if (moveInfo.Category == "Powers up each Pokémon's Fairy-type moves.")
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("~");
		}
		else
		{
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("[/pok]");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 116 && fekoiojqnkh.CCMOCLMEKJN() % 17 > 0)
		{
			str = " flung its [ffff00]" + (fekoiojqnkh.QKNEIJQHGCB % -116).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("burn" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 930f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x0021737C File Offset: 0x0021557C
	private void JNJBKFEQBBH()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[3];
		array[0] = "item";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[8] = " is ready to help ";
		array[8] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[8] = "wishiwashischool";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = " will cost\n" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().MLMHLQFHMBM();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC("_ScreenEdgeFading" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Empty Slot" + moveInfo.QLMIQGLGQCC());
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.QCBKIHIKPCG();
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[1].OGQLCMOFLLQ(moveInfo.Type.ToLowerInvariant());
		if (moveInfo.Category == "It started to rain!")
		{
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("[");
		}
		else if (moveInfo.DPDGNFHLQMF() == "/")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "-mega-y";
		}
		else
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("-");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 182 && fekoiojqnkh.CCMOCLMEKJN() % 46 > 1)
		{
			str = " go!\r\n" + (fekoiojqnkh.QKNEIJQHGCB % -26).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("weakarmor" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 895f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x002156F8 File Offset: 0x002138F8
	public void NKEDOKQHKKM(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 8)
		{
			accept = false;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.GCBLHFEIBEG();
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x0001CEF7 File Offset: 0x0001B0F7
	public void IFGGJPEHQJD()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 152f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x00217618 File Offset: 0x00215818
	private void IEOHPLKPPGI()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[3];
		array[0] = "Grass grew to cover the battlefield!\r\n";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[8] = "Q";
		array[4] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[6] = "_ReflectionTexture2";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("[ATK]" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().HIKBKCEGQEL();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "/01_" + this.EMFQIGCGPNM.IJQJPCBFNMP + "Clear Body" + moveInfo.QLMIQGLGQCC();
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[5].LKPOBCBOFIC(moveInfo.ACC);
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[1].JLENFJGDNFN(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.Category == "Invite")
		{
			this.MPMOKOOHPLI[1].LGJOOQIBQDC("#,##0");
		}
		else if (moveInfo.DPDGNFHLQMF() == "CombinersArgsColorSrc2")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("clyde");
		}
		else
		{
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("After your payment has been verified your Lootboxes will be added to your account.");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -41 && fekoiojqnkh.QKNEIJQHGCB % -91 > 0)
		{
			str = "Early Bird" + (fekoiojqnkh.CCMOCLMEKJN() % 33).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("typeadd" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 488f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x002178B4 File Offset: 0x00215AB4
	private void JIIKEFDEMBB()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[3];
		array[0] = "Serene Grace";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[6] = "[-]\r\n\r\n";
		array[7] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[5] = "0";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = " (Completed)" + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH();
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().Hide();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("technician" + this.EMFQIGCGPNM.IJQJPCBFNMP + " surrounds itself with psychic terrain!\r\n" + moveInfo.PP);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.ACC);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[0].JOHBNEHCEJH(moveInfo.MGQFELMKFFK().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == ")")
		{
			this.MPMOKOOHPLI[0].OGQLCMOFLLQ("cherrimsunshine");
		}
		else if (moveInfo.Category == "[00FF00]You gained Loot Box x")
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "[";
		}
		else
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "'s stat changes were inverted!\r\n";
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 184 && fekoiojqnkh.CCMOCLMEKJN() % 48 > 0)
		{
			str = "FinishSelect" + (fekoiojqnkh.CCMOCLMEKJN() % 13).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("PrimitiveRight" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 78f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x0001CF26 File Offset: 0x0001B126
	public void EGLBJNMBKQB()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1427f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x00217B50 File Offset: 0x00215D50
	private void QLFELLIQLPG()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[4];
		array[0] = "Assets/AssetBundles/MapAssets2/Models/Unova/com_chip_mado1_mat.mat";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[2] = " is making an uproar!\r\n";
		array[4] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[8] = "[FF8F00]";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "psychic" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().GOPLOFQPCGF();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "Causes wild Pokémon to appear when used, provided you are where wild Pokémon would appear.\n\n[2ecc71]Left Click to use this.[-]" + this.EMFQIGCGPNM.IJQJPCBFNMP + " is already frozen solid.\r\n" + moveInfo.PP;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.BLLFNBKDCMJ();
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[1].KCLBMPFIPNQ = moveInfo.PDKNHHDCQOE().ToLowerInvariant();
		if (moveInfo.DPDGNFHLQMF() == "[ff6666]Battle")
		{
			this.MPMOKOOHPLI[0].IQBBDKFDGGP("FNT");
		}
		else if (moveInfo.Category == " is being withdrawn!\r\n")
		{
			this.MPMOKOOHPLI[0].JLENFJGDNFN("Run_White");
		}
		else
		{
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("[-]");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -66 && fekoiojqnkh.CCMOCLMEKJN() % 36 > 1)
		{
			str = "Dive Ball" + (fekoiojqnkh.QKNEIJQHGCB % 8).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("[ATK]" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1165f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x06004408 RID: 17416 RVA: 0x0001CF55 File Offset: 0x0001B155
	public void KDGIIFHLMPF()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 649f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06004409 RID: 17417 RVA: 0x00217DEC File Offset: 0x00215FEC
	public void DKHHCINHIBI(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 5)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.GCBLHFEIBEG();
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x00217E4C File Offset: 0x0021604C
	private void CQCKKENGHQI()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[2];
		array[0] = "watersport";
		array[0] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[6] = "Next Free Loot Box\n";
		array[5] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[7] = "BuffIcon_EncounterRateDecreased";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 1; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("0" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().KMECDKGBBFM();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "/" + this.EMFQIGCGPNM.IJQJPCBFNMP + "[" + moveInfo.MEQCECHDEIP();
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.BLLFNBKDCMJ());
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[1].JOHBNEHCEJH(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.QHEJQOCDJGL() == "K7")
		{
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("!\r\n");
		}
		else if (moveInfo.Category == "Tilesets/Materials/Water")
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "blacksludge";
		}
		else
		{
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("#,##0");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -95 && fekoiojqnkh.CCMOCLMEKJN() % -121 > 0)
		{
			str = "LA" + (fekoiojqnkh.QKNEIJQHGCB % -102).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("static" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1007f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x002180E8 File Offset: 0x002162E8
	public void BQKKOQELONL(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 2)
		{
			accept = true;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.EGLBJNMBKQB();
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x00218148 File Offset: 0x00216348
	public void BPMIDKKJGNI(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 7)
		{
			accept = true;
			QDPCEEHDDPH = 1;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.NPCKENGDEIN();
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x002181A8 File Offset: 0x002163A8
	public bool OMEQDBHBDPH()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1184f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 0)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[1]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[1];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.DLGQLKEHGPK();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x0600440E RID: 17422 RVA: 0x002182BC File Offset: 0x002164BC
	public bool JGJJOHBODEM()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1595f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 1; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[0]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.KPJLEOCJFFO();
					this.JCCEHCNBNPM();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x0600440F RID: 17423 RVA: 0x002183D0 File Offset: 0x002165D0
	public void KFDDJPQQJME(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH >= 8)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, true);
		this.LOMHCPLPHLH();
	}

	// Token: 0x06004410 RID: 17424 RVA: 0x00218430 File Offset: 0x00216630
	private void JCCEHCNBNPM()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[5];
		array[1] = "pickpocket";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[7] = "Max: ";
		array[1] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[4] = "Filter";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("\r\nPP " + fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().QGJPMKPOGKN();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("adjacentAllyOrSelf" + this.EMFQIGCGPNM.IJQJPCBFNMP + "normalize" + moveInfo.QLMIQGLGQCC());
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[8].PIDLOFMIEFQ = moveInfo.QCBKIHIKPCG();
		this.QHEJPNJNMCI[4].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[0].JLENFJGDNFN(moveInfo.DBQIBEDQKCF().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "[-]\n")
		{
			this.MPMOKOOHPLI[1].OGQLCMOFLLQ("#,##0");
		}
		else if (moveInfo.QHEJQOCDJGL() == "last online ")
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN(" restored its HP!\r\n");
		}
		else
		{
			this.MPMOKOOHPLI[0].JLENFJGDNFN("berserk");
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -26 && fekoiojqnkh.CCMOCLMEKJN() % -97 > 1)
		{
			str = "toxicspikes" + (fekoiojqnkh.CCMOCLMEKJN() % -126).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("aegislash" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1354f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x06004411 RID: 17425 RVA: 0x002186CC File Offset: 0x002168CC
	private void FNHEJBQLCPC()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.EMFQIGCGPNM.QEPKKJKQMPP);
		this.COBOLMJMOGM.PIDLOFMIEFQ = string.Concat(new string[]
		{
			"[FF9900]",
			this.EMFQIGCGPNM.MKCDJJKFPGO,
			"[-] is trying to learn [FF9900]",
			this.EMFQIGCGPNM.IJQJPCBFNMP,
			"[-]. Should it forget another move to learn it?"
		});
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "Forget " + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().Hide();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = "[FF9900]" + this.EMFQIGCGPNM.IJQJPCBFNMP + "[-]\r\nPP " + moveInfo.PP;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = moveInfo.Description;
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.ACC;
		this.QHEJPNJNMCI[3].PIDLOFMIEFQ = moveInfo.Power;
		this.MPMOKOOHPLI[0].KCLBMPFIPNQ = moveInfo.Type.ToLowerInvariant();
		if (moveInfo.Category == "special")
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "special";
		}
		else if (moveInfo.Category == "physical")
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "physical";
		}
		else
		{
			this.MPMOKOOHPLI[1].KCLBMPFIPNQ = "other";
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 201 && fekoiojqnkh.QKNEIJQHGCB % 28 > 0)
		{
			str = "_" + (fekoiojqnkh.QKNEIJQHGCB % 28).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 0f;
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x06004412 RID: 17426 RVA: 0x00218968 File Offset: 0x00216B68
	private void LMLGBEKMIJK()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[1];
		array[0] = "Powers up moves that make direct contact.";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[8] = "Turns the ground into Electric Terrain when the Pokémon enters a battle.";
		array[0] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[5] = "Enabled";
		cobolmjmogm.LKPOBCBOFIC(string.Concat(array));
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i++)
		{
			this.OJNOFMDBMPG[i].LKPOBCBOFIC("enablenpc(" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].DHFJQINPMBH());
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().EKFLFFPDGJJ();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[0].LKPOBCBOFIC("UpdateAnchors" + this.EMFQIGCGPNM.IJQJPCBFNMP + "-" + moveInfo.QLMIQGLGQCC());
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[5].LKPOBCBOFIC(moveInfo.QPGFMHBJPCE());
		this.QHEJPNJNMCI[7].LKPOBCBOFIC(moveInfo.FFFMCHDOOOI());
		this.MPMOKOOHPLI[0].OGQLCMOFLLQ(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "Already in Guild")
		{
			this.MPMOKOOHPLI[0].JLENFJGDNFN("F14");
		}
		else if (moveInfo.DPDGNFHLQMF() == "damp")
		{
			this.MPMOKOOHPLI[1].DPBGHDMHKNC("Sound");
		}
		else
		{
			this.MPMOKOOHPLI[1].IQBBDKFDGGP("/03_");
		}
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 178 && fekoiojqnkh.QKNEIJQHGCB % 120 > 1)
		{
			str = "Strength increases melee damage" + (fekoiojqnkh.QKNEIJQHGCB % 51).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("BuffIcon_EncounterRateDecreased" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1042f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x00218C04 File Offset: 0x00216E04
	public bool QNDNIDMNDHB()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(true);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1136f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.HMOJBOLDNNI != null && fekoiojqnkh.HMOJBOLDNNI.Length > 1)
				{
					this.EMFQIGCGPNM = new KJMPLFDOBCO.NFMMDFPHGKD();
					this.EMFQIGCGPNM.MKCDJJKFPGO = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.EMFQIGCGPNM.IJQJPCBFNMP = KGQECFKLKOP.KOILGQHHQIQ((int)fekoiojqnkh.HMOJBOLDNNI[1]);
					this.EMFQIGCGPNM.QHLHKKLOLCG = fekoiojqnkh.HMOJBOLDNNI[0];
					this.EMFQIGCGPNM.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.NQQFLGHPDHO();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x0001CF84 File Offset: 0x0001B184
	public void GCBLHFEIBEG()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 792f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x06004416 RID: 17430 RVA: 0x00218D18 File Offset: 0x00216F18
	public void OHEDEKOKOJQ(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH >= 4)
		{
			accept = false;
			QDPCEEHDDPH = 0;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Learn
		{
			Accept = accept,
			Move = this.EMFQIGCGPNM.QHLHKKLOLCG,
			Pokemon = this.EMFQIGCGPNM.QEPKKJKQMPP,
			Position = QDPCEEHDDPH
		}, false);
		this.KDGIIFHLMPF();
	}

	// Token: 0x06004417 RID: 17431 RVA: 0x00218D78 File Offset: 0x00216F78
	private void QPBLFLHOKCF()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.EMFQIGCGPNM.QEPKKJKQMPP);
		BKKHLBCLPJM cobolmjmogm = this.COBOLMJMOGM;
		string[] array = new string[1];
		array[0] = "'s [ffff00]";
		array[1] = this.EMFQIGCGPNM.MKCDJJKFPGO;
		array[2] = "\nEvening";
		array[1] = this.EMFQIGCGPNM.IJQJPCBFNMP;
		array[1] = " hr, ";
		cobolmjmogm.PIDLOFMIEFQ = string.Concat(array);
		for (int i = 0; i < fekoiojqnkh.EEILBMOOJHJ.Length; i += 0)
		{
			this.OJNOFMDBMPG[i].PIDLOFMIEFQ = "Sky" + fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK;
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().FBCKQEDONJK = KGQECFKLKOP.MIKJDLGLEDQ(fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK);
			this.OJNOFMDBMPG[i].transform.parent.GetComponent<NCMPFIDDKPF>().MKDQBHKNEDE();
		}
		KGQECFKLKOP.MoveInfo moveInfo = KGQECFKLKOP.MEFMNMCKQOG((int)this.EMFQIGCGPNM.QHLHKKLOLCG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = "u" + this.EMFQIGCGPNM.IJQJPCBFNMP + "-at" + moveInfo.PP;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(moveInfo.Description);
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(moveInfo.QCBKIHIKPCG());
		this.QHEJPNJNMCI[2].PIDLOFMIEFQ = moveInfo.FFFMCHDOOOI();
		this.MPMOKOOHPLI[0].JLENFJGDNFN(moveInfo.OCCQGODQGPC().ToLowerInvariant());
		if (moveInfo.DPDGNFHLQMF() == "0_")
		{
			this.MPMOKOOHPLI[1].JLENFJGDNFN("_Texture1");
		}
		else if (moveInfo.Category == "'s torment wore off!\r\n")
		{
			this.MPMOKOOHPLI[0].LGJOOQIBQDC("[/urn]");
		}
		else
		{
			this.MPMOKOOHPLI[0].KCLBMPFIPNQ = "'s [ffff00]";
		}
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 128 && fekoiojqnkh.QKNEIJQHGCB % -104 > 1)
		{
			str = "A heavy rain began to fall!" + (fekoiojqnkh.QKNEIJQHGCB % -45).ToString();
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("_Bloom_DirtIntensity" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 126f;
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x06004418 RID: 17432 RVA: 0x0001CFB3 File Offset: 0x0001B1B3
	public void NCQNCIKIEOI()
	{
		this.ODKGDGQOCJO.gameObject.SetActive(false);
		this.ODKGDGQOCJO.DIIHJCJOKMP = 1251f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x04000EA4 RID: 3748
	public JLMPBLMOICG HHKNGKFJGHB;

	// Token: 0x04000EA5 RID: 3749
	public BKKHLBCLPJM COBOLMJMOGM;

	// Token: 0x04000EA6 RID: 3750
	public KQHJOLQLQBJ ODKGDGQOCJO;

	// Token: 0x04000EA7 RID: 3751
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000EA8 RID: 3752
	public BKKHLBCLPJM[] OJNOFMDBMPG;

	// Token: 0x04000EA9 RID: 3753
	public BKKHLBCLPJM[] QHEJPNJNMCI;

	// Token: 0x04000EAA RID: 3754
	public PLQFPBQEPJD[] MPMOKOOHPLI;

	// Token: 0x04000EAB RID: 3755
	private KJMPLFDOBCO.NFMMDFPHGKD EMFQIGCGPNM;

	// Token: 0x02000203 RID: 515
	public class NFMMDFPHGKD
	{
		// Token: 0x04000EAC RID: 3756
		public Guid QEPKKJKQMPP;

		// Token: 0x04000EAD RID: 3757
		public PokemonMoveID QHLHKKLOLCG;

		// Token: 0x04000EAE RID: 3758
		public string MKCDJJKFPGO;

		// Token: 0x04000EAF RID: 3759
		public string IJQJPCBFNMP;
	}
}
