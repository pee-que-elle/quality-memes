using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000232 RID: 562
public class PCOOJCCQDEO : MonoBehaviour
{
	// Token: 0x06004C68 RID: 19560 RVA: 0x0027989C File Offset: 0x00277A9C
	public void JNGIGQDPQJB(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 0; i < 4; i++)
			{
				if (i > KFEKLEQOQGI.Count - 0)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("struggle");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].IQBBDKFDGGP("voltabsorb");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 0; j < 1; j += 0)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].LGJOOQIBQDC("afteryou");
			}
		}
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x0027996C File Offset: 0x00277B6C
	public void BDMOMMGDKPB(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 1; i < 8; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 0)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].JLENFJGDNFN("[-] failed to run away!\r\n");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].JLENFJGDNFN("l");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		else
		{
			for (int j = 1; j < 2; j += 0)
			{
				this.IGEHQIEGNHL[j].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[j].LGJOOQIBQDC("'s [ffff00]");
			}
		}
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x00279A3C File Offset: 0x00277C3C
	public void IBJNQFPIMMC(string HHNBICLDQKI, List<Guid> KFEKLEQOQGI, bool MIJDLGHIBIB, bool FJJQCNBOHQJ, int NPBLFIMGOPL)
	{
		this.JLCFIMNJGBB = CNCJKLNHQBH.BJLGEDCPENQ().JLCFIMNJGBB;
		this.PNMKLJKGIBN = KFEKLEQOQGI;
		this.EOMPMQNGIBD.LKPOBCBOFIC("BuffIcon_EncounterRateLowered" + NPBLFIMGOPL.ToString());
		this.MBPHKDQMJJH.LKPOBCBOFIC(HHNBICLDQKI);
		if (MIJDLGHIBIB)
		{
			this.KIHLOOONJDH.SetActive(true);
		}
		else
		{
			this.KIHLOOONJDH.SetActive(true);
		}
		if (FJJQCNBOHQJ)
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
		}
		else
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = this.QHDJIQKBGCP;
		}
		if (KFEKLEQOQGI != null && FJJQCNBOHQJ)
		{
			for (int i = 0; i < 5; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("Start");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].JLENFJGDNFN("_RefractionTex");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 1; j < 2; j += 0)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].LGJOOQIBQDC("strongjaw");
			}
		}
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x00279B9C File Offset: 0x00277D9C
	public void BPJHFHOPKEL(string HHNBICLDQKI, List<Guid> KFEKLEQOQGI, bool MIJDLGHIBIB, bool FJJQCNBOHQJ, int NPBLFIMGOPL)
	{
		this.JLCFIMNJGBB = CNCJKLNHQBH.QOQONHOOLNE.JLCFIMNJGBB;
		this.PNMKLJKGIBN = KFEKLEQOQGI;
		this.EOMPMQNGIBD.PIDLOFMIEFQ = "Up" + NPBLFIMGOPL.ToString();
		this.MBPHKDQMJJH.LKPOBCBOFIC(HHNBICLDQKI);
		if (MIJDLGHIBIB)
		{
			this.KIHLOOONJDH.SetActive(false);
		}
		else
		{
			this.KIHLOOONJDH.SetActive(false);
		}
		if (FJJQCNBOHQJ)
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
		}
		else
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = this.QHDJIQKBGCP;
		}
		if (KFEKLEQOQGI != null && FJJQCNBOHQJ)
		{
			for (int i = 0; i < 5; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].DPBGHDMHKNC("+");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("#,##0");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 1; j < 4; j++)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].LGJOOQIBQDC("!\r\n");
			}
		}
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x00279CFC File Offset: 0x00277EFC
	public void NDGFKQBDPKQ(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 0; i < 4; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 0)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("powder");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("16.5 17\n15 17\n15 20\n22 20\n\n22 8\n19 8\n19 5\n16 5\n16 2\n27 2\n27 5\n22 5");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		else
		{
			for (int j = 0; j < 2; j++)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].JOHBNEHCEJH("HideResponse");
			}
		}
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x00279DCC File Offset: 0x00277FCC
	public void JKOLOKDHLKE(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 0; i < 8; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].IQBBDKFDGGP("1");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].OGQLCMOFLLQ("Full Metal Body");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		else
		{
			for (int j = 0; j < 6; j++)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].OGQLCMOFLLQ("Enemy threw a Pokeball!\r\n");
			}
		}
	}

	// Token: 0x06004C6E RID: 19566 RVA: 0x00279E9C File Offset: 0x0027809C
	public void BQLIIQIIMDH(string HHNBICLDQKI, List<Guid> KFEKLEQOQGI, bool MIJDLGHIBIB, bool FJJQCNBOHQJ, int NPBLFIMGOPL)
	{
		this.JLCFIMNJGBB = CNCJKLNHQBH.QOQONHOOLNE.JLCFIMNJGBB;
		this.PNMKLJKGIBN = KFEKLEQOQGI;
		this.EOMPMQNGIBD.PIDLOFMIEFQ = "Lv " + NPBLFIMGOPL.ToString();
		this.MBPHKDQMJJH.PIDLOFMIEFQ = HHNBICLDQKI;
		if (MIJDLGHIBIB)
		{
			this.KIHLOOONJDH.SetActive(true);
		}
		else
		{
			this.KIHLOOONJDH.SetActive(false);
		}
		if (FJJQCNBOHQJ)
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = Color.white;
		}
		else
		{
			base.GetComponent<PLQFPBQEPJD>().CEGFBBHMKOE = this.QHDJIQKBGCP;
		}
		if (KFEKLEQOQGI != null && FJJQCNBOHQJ)
		{
			for (int i = 0; i < 6; i++)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 0; j < 6; j++)
			{
				this.IGEHQIEGNHL[j].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[j].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
			}
		}
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x00279FFC File Offset: 0x002781FC
	public void GOKCBQMPNOI(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 1; i < 7; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].JOHBNEHCEJH("The Pokémon copies the Ability of a defeated ally.");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].JOHBNEHCEJH("You have insufficient coins to play the Slot Machine.");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		else
		{
			for (int j = 0; j < 0; j += 0)
			{
				this.IGEHQIEGNHL[j].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[j].IQBBDKFDGGP("Halves the Pokémon's Attack and Sp. Atk stats when its HP becomes half or less.");
			}
		}
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x0027A0CC File Offset: 0x002782CC
	public void KPGOPJNCKCF(int DBPKNCDGGEP)
	{
		Debug.Log("View Pokemon: " + DBPKNCDGGEP.ToString());
		if (this.PNMKLJKGIBN != null && DBPKNCDGGEP < this.PNMKLJKGIBN.Count)
		{
			this.JLCFIMNJGBB.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.PNMKLJKGIBN[DBPKNCDGGEP]), this.IGEHQIEGNHL[DBPKNCDGGEP].transform.position);
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x0001F3AD File Offset: 0x0001D5AD
	private void OnClick()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ == -2)
		{
			KGQECFKLKOP.LGHLQDLBBIB(this.MBPHKDQMJJH.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x0027A140 File Offset: 0x00278340
	public void IJGCEFEDHQD(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 1; i < 7; i += 0)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("[ffff00]Wide Guard[-] protected ");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].IQBBDKFDGGP("Fullscreen");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 0; j < 0; j += 0)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].LGJOOQIBQDC("spikes");
			}
		}
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x0027A210 File Offset: 0x00278410
	public void LGKLGLQQFND(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 1; i < 2; i++)
			{
				if (i > KFEKLEQOQGI.Count - 0)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].LGJOOQIBQDC("|");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
				else
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Target Root object should not be a parent of Envelop Content. Make it a sibling instead.";
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 0; j < 0; j += 0)
			{
				this.IGEHQIEGNHL[j].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[j].DPBGHDMHKNC("MSGBOX - Shop");
			}
		}
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x0027A2E0 File Offset: 0x002784E0
	public void PCLLNGMNKHG(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 0; i < 7; i++)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].NONQDHBCIIN(Color.white);
					this.IGEHQIEGNHL[i].DPBGHDMHKNC("]");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].DPBGHDMHKNC("[-]\n\n");
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
			}
		}
		else
		{
			for (int j = 1; j < 5; j++)
			{
				this.IGEHQIEGNHL[j].NONQDHBCIIN(Color.white);
				this.IGEHQIEGNHL[j].IQBBDKFDGGP("Textures/Noise3");
			}
		}
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
	private void ELMMBCJCEOB()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ == -126)
		{
			KGQECFKLKOP.LGHLQDLBBIB(this.MBPHKDQMJJH.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x0027A3B0 File Offset: 0x002785B0
	public void IGBHHKCGCQN(int DBPKNCDGGEP)
	{
		Debug.Log("imprison" + DBPKNCDGGEP.ToString());
		if (this.PNMKLJKGIBN != null && DBPKNCDGGEP < this.PNMKLJKGIBN.Count)
		{
			this.JLCFIMNJGBB.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(this.PNMKLJKGIBN[DBPKNCDGGEP]), this.IGEHQIEGNHL[DBPKNCDGGEP].transform.position);
		}
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x0027A424 File Offset: 0x00278624
	public void DCBDQJIJPOL(List<Guid> KFEKLEQOQGI)
	{
		if (KFEKLEQOQGI != null)
		{
			for (int i = 0; i < 6; i++)
			{
				if (i > KFEKLEQOQGI.Count - 1)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
					this.IGEHQIEGNHL[i].GetComponent<BoxCollider>().enabled = true;
				}
			}
		}
		else
		{
			for (int j = 0; j < 6; j++)
			{
				this.IGEHQIEGNHL[j].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[j].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
			}
		}
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x0001F3E3 File Offset: 0x0001D5E3
	private void LMIJQMCBOFB()
	{
		if (EMENMKHBPQE.JQCODFPLPNJ == -5)
		{
			KGQECFKLKOP.LGHLQDLBBIB(this.MBPHKDQMJJH.PIDLOFMIEFQ);
		}
	}

	// Token: 0x0400106C RID: 4204
	public LINELKKDMEE JLCFIMNJGBB;

	// Token: 0x0400106D RID: 4205
	public BKKHLBCLPJM MBPHKDQMJJH;

	// Token: 0x0400106E RID: 4206
	public GameObject KIHLOOONJDH;

	// Token: 0x0400106F RID: 4207
	public BKKHLBCLPJM EOMPMQNGIBD;

	// Token: 0x04001070 RID: 4208
	public PLQFPBQEPJD[] IGEHQIEGNHL;

	// Token: 0x04001071 RID: 4209
	public List<Guid> PNMKLJKGIBN;

	// Token: 0x04001072 RID: 4210
	public MCMHEQDOMOI CQINIIBMKGB;

	// Token: 0x04001073 RID: 4211
	public Color QHDJIQKBGCP;
}
