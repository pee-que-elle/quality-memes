using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000248 RID: 584
public class HFCMDEQKCKH : MonoBehaviour
{
	// Token: 0x06004FC0 RID: 20416 RVA: 0x000205A2 File Offset: 0x0001E7A2
	public void Start()
	{
		this.PDDJMNOOPJD();
	}

	// Token: 0x06004FC1 RID: 20417 RVA: 0x0029772C File Offset: 0x0029592C
	public bool CEGFMOGGKNE()
	{
		for (int i = 0; i < this.LIJHMFEGCCK.Count; i++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(this.LIJHMFEGCCK[i]);
			if (fekoiojqnkh != null && fekoiojqnkh.EEILBMOOJHJ != null)
			{
				for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
				{
					if (fekoiojqnkh.EEILBMOOJHJ[j] != null && fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK.ToLowerInvariant() == "flash")
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06004FC2 RID: 20418 RVA: 0x002977AC File Offset: 0x002959AC
	public void EGNCKJPNONP(PSXAPI.Response.Learn BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, true);
		}
		if (BJGCBDNBQCJ.Result == LearnResult.Success)
		{
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Pokemon.Pokemon.Payload.PokemonID) + " learned the move " + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + "!");
		}
		else if (BJGCBDNBQCJ.Result == LearnResult.Failed)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.HBFFCJHOCPE.PEJHBEBOCOJ(BJGCBDNBQCJ.PokemonUID);
			if (fekoiojqnkh != null)
			{
				CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + " failed to learn the move " + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + "!");
			}
		}
		else if (BJGCBDNBQCJ.Result == LearnResult.Canceled)
		{
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Pokemon.Pokemon.Payload.PokemonID) + " did not learn the move " + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + "!");
		}
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x0001F741 File Offset: 0x0001D941
	[CompilerGenerated]
	private static int KEFKOHHJBFO(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x002978B0 File Offset: 0x00295AB0
	public void QDMQKHCLHBC(PSXAPI.Response.Inventory CFHEIICNLFD)
	{
		this.LIJHMFEGCCK.Clear();
		if (CFHEIICNLFD != null && CFHEIICNLFD.ActivePokemon != null)
		{
			for (int i = 0; i < CFHEIICNLFD.ActivePokemon.Length; i++)
			{
				this.IJCIQLHLFQE(CFHEIICNLFD.ActivePokemon[i], false);
				this.LIJHMFEGCCK.Add(CFHEIICNLFD.ActivePokemon[i].Pokemon.UniqueID);
			}
		}
		this.PDDJMNOOPJD();
		if (JJGLMJNELOK.QOQONHOOLNE != null)
		{
			if (!string.IsNullOrEmpty(JJGLMJNELOK.KGOPJQOMMNC().JKDFLFMOOHP.HJMJDJKOILH()))
			{
				JJGLMJNELOK.BEKHPOHIPDE().CNEBQQPDGIP();
				JJGLMJNELOK.BEKHPOHIPDE().OECECCPCLII();
				JJGLMJNELOK.KGOPJQOMMNC().GEEHLPKMFCD();
			}
			else
			{
				JJGLMJNELOK.KGOPJQOMMNC().DEGOICOIDON();
			}
		}
	}

	// Token: 0x06004FC5 RID: 20421 RVA: 0x00297968 File Offset: 0x00295B68
	public int PGMDEOONOMN()
	{
		int jjpkkpfcqkn = JJGLMJNELOK.QOQONHOOLNE.JJPKKPFCQKN;
		int num = 0;
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].GNLNPCCPBCF == jjpkkpfcqkn && this.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x002979EC File Offset: 0x00295BEC
	public void HGNMBOCBJGL(PSXAPI.Response.Evs BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result != EvsResult.Failed)
		{
			if (BJGCBDNBQCJ.Result != EvsResult.Reset)
			{
				if (BJGCBDNBQCJ.Result == EvsResult.Request)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.KQPKDONQCHC(BJGCBDNBQCJ.PokemonUID);
					string text = string.Empty;
					if (BJGCBDNBQCJ.Money > 0u)
					{
						text = text + "_Radius" + BJGCBDNBQCJ.Money.ToString("item");
						if (BJGCBDNBQCJ.Gold > 1u)
						{
							text += "Powers up Grass-type moves when the Pokémon's HP is low.";
						}
					}
					if (BJGCBDNBQCJ.Gold > 0u)
					{
						text = text + "Assets/AssetBundles/MapAssets/Models/Materials/akari_kanazumi.mat" + BJGCBDNBQCJ.Gold.ToString();
					}
					CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.BJLGEDCPENQ();
					string hiefqeedhgg = "friendr";
					string[] array = new string[1];
					array[1] = "[u][33CCFF]";
					array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					array[2] = "The Pokémon's marvelous scales boost the Defense stat if it has a status condition.";
					array[2] = text;
					array[5] = "BuffIcon";
					cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), BJGCBDNBQCJ.PokemonUID.ToString(), (LPBPDPMJKNN.PJIJIFKBMBB)7, true, null, -1, true);
					return;
				}
				if (BJGCBDNBQCJ.Result == EvsResult.Failed)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("_DownsampledDepth", "NGUI State: ", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
					return;
				}
				return;
			}
		}
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, true);
		}
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x00297B38 File Offset: 0x00295D38
	public void EDQIHJMOIID(PSXAPI.Response.Evs BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result != EvsResult.Skilled)
		{
			if (BJGCBDNBQCJ.Result != EvsResult.Reset)
			{
				if (BJGCBDNBQCJ.Result == EvsResult.Request)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(BJGCBDNBQCJ.PokemonUID);
					string text = string.Empty;
					if (BJGCBDNBQCJ.Money > 0u)
					{
						text = text + "[PD]" + BJGCBDNBQCJ.Money.ToString("#,##0");
						if (BJGCBDNBQCJ.Gold > 0u)
						{
							text += "   ";
						}
					}
					if (BJGCBDNBQCJ.Gold > 0u)
					{
						text = text + "[PG]" + BJGCBDNBQCJ.Gold.ToString();
					}
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Reset EVs", string.Concat(new string[]
					{
						"Resetting EVs for your ",
						KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
						" will cost\n",
						text,
						"\nAre you sure you want to reset its EVs?"
					}), BJGCBDNBQCJ.PokemonUID.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
					return;
				}
				if (BJGCBDNBQCJ.Result == EvsResult.Failed)
				{
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Resetting EVs", "You can not afford to reset your EVs", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
					return;
				}
				return;
			}
		}
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, true);
		}
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x000205AA File Offset: 0x0001E7AA
	public void LNDPEMECPQM()
	{
		this.LHQQCLOEHJG.Clear();
		this.LIJHMFEGCCK.Clear();
	}

	// Token: 0x06004FC9 RID: 20425 RVA: 0x00297C84 File Offset: 0x00295E84
	public void GJMNNFOPODM(Guid QQQEPOCKCME, Guid NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = QQQEPOCKCME,
			Pokemon2 = NPGFLNDCNMC
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FCA RID: 20426 RVA: 0x00297CC0 File Offset: 0x00295EC0
	public void JDBLBHFELNQ(PSXAPI.Response.Release BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == ReleaseResult.Success)
		{
			if (this.LHQQCLOEHJG.Count > 0)
			{
				for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
				{
					if (this.LHQQCLOEHJG[i].LDQDJLFIDCN == BJGCBDNBQCJ.Pokemon)
					{
						this.LHQQCLOEHJG[i].GNLNPCCPBCF = -1;
						this.LHQQCLOEHJG[i].PELCNBCMNFH = -1;
						break;
					}
				}
			}
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
			if (JJGLMJNELOK.QOQONHOOLNE != null)
			{
				if (!string.IsNullOrEmpty(JJGLMJNELOK.QOQONHOOLNE.JKDFLFMOOHP.BGBMIEJJQKC))
				{
					JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
					JJGLMJNELOK.QOQONHOOLNE.Search();
					JJGLMJNELOK.QOQONHOOLNE.HDDJPQFJIIC();
				}
				else
				{
					JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
				}
			}
		}
	}

	// Token: 0x06004FCB RID: 20427 RVA: 0x00297D9C File Offset: 0x00295F9C
	public void JLHPNIEEGJD(PSXAPI.Response.Reorder BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Box == 0)
		{
			for (int i = 0; i < this.LIJHMFEGCCK.Count; i++)
			{
				this.PEJHBEBOCOJ(this.LIJHMFEGCCK[i]).GNLNPCCPBCF = -1;
			}
			this.LIJHMFEGCCK.Clear();
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int j = 0; j < BJGCBDNBQCJ.Pokemon.Length; j++)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon[j]);
					this.LIJHMFEGCCK.Add(BJGCBDNBQCJ.Pokemon[j]);
					if (fekoiojqnkh != null)
					{
						fekoiojqnkh.GNLNPCCPBCF = 0;
						fekoiojqnkh.PELCNBCMNFH = j + 1;
					}
				}
			}
			CNCJKLNHQBH.QOQONHOOLNE.BGJGEDKNOMC("Hold or Use?");
			CNCJKLNHQBH.QOQONHOOLNE.BGJGEDKNOMC("Item Usage");
			CNCJKLNHQBH.QOQONHOOLNE.BGJGEDKNOMC("Hold Item");
		}
		else
		{
			for (int k = 0; k < this.LHQQCLOEHJG.Count; k++)
			{
				if (this.LHQQCLOEHJG[k].GNLNPCCPBCF == BJGCBDNBQCJ.Box)
				{
					this.LHQQCLOEHJG[k].GNLNPCCPBCF = -1;
				}
			}
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int l = 0; l < BJGCBDNBQCJ.Pokemon.Length; l++)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon[l]);
					if (fekoiojqnkh2 != null)
					{
						fekoiojqnkh2.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
						fekoiojqnkh2.PELCNBCMNFH = l + 1;
					}
				}
			}
			JJGLMJNELOK.QOQONHOOLNE.NNCPPBFPEPK();
		}
		this.PDDJMNOOPJD();
		if (JJGLMJNELOK.QOQONHOOLNE != null)
		{
			if (!string.IsNullOrEmpty(JJGLMJNELOK.QOQONHOOLNE.JKDFLFMOOHP.BGBMIEJJQKC))
			{
				JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
				JJGLMJNELOK.QOQONHOOLNE.Search();
				JJGLMJNELOK.QOQONHOOLNE.HDDJPQFJIIC();
			}
			else
			{
				JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
			}
		}
	}

	// Token: 0x06004FCC RID: 20428 RVA: 0x00297F74 File Offset: 0x00296174
	public void GDECBJMCQPQ(PSXAPI.Response.Inventory CFHEIICNLFD)
	{
		this.LIJHMFEGCCK.Clear();
		if (CFHEIICNLFD != null && CFHEIICNLFD.ActivePokemon != null)
		{
			for (int i = 0; i < CFHEIICNLFD.ActivePokemon.Length; i++)
			{
				this.MNICELEPBHO(CFHEIICNLFD.ActivePokemon[i], false);
				this.LIJHMFEGCCK.Add(CFHEIICNLFD.ActivePokemon[i].Pokemon.UniqueID);
			}
		}
		this.PDDJMNOOPJD();
		if (JJGLMJNELOK.QOQONHOOLNE != null)
		{
			if (!string.IsNullOrEmpty(JJGLMJNELOK.QOQONHOOLNE.JKDFLFMOOHP.BGBMIEJJQKC))
			{
				JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
				JJGLMJNELOK.QOQONHOOLNE.Search();
				JJGLMJNELOK.QOQONHOOLNE.HDDJPQFJIIC();
			}
			else
			{
				JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
			}
		}
	}

	// Token: 0x06004FCD RID: 20429 RVA: 0x000205A2 File Offset: 0x0001E7A2
	public void LBIFHHFMPHD()
	{
		this.PDDJMNOOPJD();
	}

	// Token: 0x06004FCE RID: 20430 RVA: 0x0029802C File Offset: 0x0029622C
	public void ECMKGDCJPMD(PSXAPI.Response.Release BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == ReleaseResult.Failed)
		{
			if (this.LHQQCLOEHJG.Count > 0)
			{
				for (int i = 1; i < this.LHQQCLOEHJG.Count; i++)
				{
					if (this.LHQQCLOEHJG[i].KGMFIOCJLEP() == BJGCBDNBQCJ.Pokemon)
					{
						this.LHQQCLOEHJG[i].GNLNPCCPBCF = -1;
						this.LHQQCLOEHJG[i].PELCNBCMNFH = -1;
						break;
					}
				}
			}
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
			if (JJGLMJNELOK.KGOPJQOMMNC() != null)
			{
				if (!string.IsNullOrEmpty(JJGLMJNELOK.KGOPJQOMMNC().JKDFLFMOOHP.HJMJDJKOILH()))
				{
					JJGLMJNELOK.QOQONHOOLNE.DEGOICOIDON();
					JJGLMJNELOK.BEKHPOHIPDE().EDBMIGDPJHM();
					JJGLMJNELOK.BEKHPOHIPDE().JHCLEHKNGFE();
				}
				else
				{
					JJGLMJNELOK.KGOPJQOMMNC().DEGOICOIDON();
				}
			}
		}
	}

	// Token: 0x06004FCF RID: 20431 RVA: 0x00297C84 File Offset: 0x00295E84
	public void MDGQHMBNKQG(Guid QQQEPOCKCME, Guid NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = QQQEPOCKCME,
			Pokemon2 = NPGFLNDCNMC
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FD0 RID: 20432 RVA: 0x00298108 File Offset: 0x00296308
	public void GGHNEEKOGQG(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 6 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 1) || QQQEPOCKCME + 1 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		PSXAPI.Request.Reorder dcgclgqcgdq = new PSXAPI.Request.Reorder
		{
			Pokemon = this.LIJHMFEGCCK[QQQEPOCKCME],
			Position = NPGFLNDCNMC + 1
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x00298178 File Offset: 0x00296378
	public Guid FPHJJLLFNPI(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 1];
		}
		return default(Guid);
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x000205C2 File Offset: 0x0001E7C2
	private void LKDKBNOBIPK()
	{
		HFCMDEQKCKH.HBFFCJHOCPE = this;
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x002981AC File Offset: 0x002963AC
	public int NBLNQGHIKCG(Guid JNOOPPDPFEH)
	{
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].LDQDJLFIDCN == JNOOPPDPFEH)
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x002981FC File Offset: 0x002963FC
	public KGQECFKLKOP.FEKOIOJQNKH LKFLGPCGHFD(PokemonData CFHEIICNLFD)
	{
		return this.MNICELEPBHO(new InventoryPokemon
		{
			Box = -1,
			Position = -1,
			Pokemon = CFHEIICNLFD
		}, false);
	}

	// Token: 0x06004FD5 RID: 20437 RVA: 0x0029822C File Offset: 0x0029642C
	public void JNQJDBOFCPC(Guid QQQEPOCKCME, Guid NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = QQQEPOCKCME,
			Pokemon2 = NPGFLNDCNMC
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x00298268 File Offset: 0x00296468
	public void PDDJMNOOPJD()
	{
		for (int i = 0; i < 6; i++)
		{
			if (i < this.LIJHMFEGCCK.Count)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(this.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null)
				{
					this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
					this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
					if (fekoiojqnkh.DCFKMOILHEC <= 0)
					{
						this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
					}
					this.NLCFMOLBKGI[i].BQLIIQIIMDH(fekoiojqnkh);
					this.NLCFMOLBKGI[i].transform.parent.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB = fekoiojqnkh.LDQDJLFIDCN;
					if (i == 0)
					{
						CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.IDICNBQHCJG = fekoiojqnkh.QKNEIJQHGCB;
						CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.BEQHNFFEHMQ = fekoiojqnkh.BEQHNFFEHMQ;
						CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.BKNFHNFFCHE = fekoiojqnkh.BKNFHNFFCHE;
						CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.NBDBHLEKENM();
					}
				}
			}
			else
			{
				this.IGEHQIEGNHL[i].CEGFBBHMKOE = Color.white;
				this.IGEHQIEGNHL[i].KCLBMPFIPNQ = "Icon_Pokemon_Empty";
				this.NLCFMOLBKGI[i].BQLIIQIIMDH(null);
				this.NLCFMOLBKGI[i].transform.parent.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB = default(Guid);
			}
		}
		if (!this.IEHKHJNIIIQ.LGMNEFJMQGQ())
		{
			this.PDHECMQCCKQ.CKNDFBPHPDG();
		}
		MCNLIHMMLCF.QOQONHOOLNE.DHJLPCKHQBH();
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x002983F0 File Offset: 0x002965F0
	public void KLHIDJLEJFG(PSXAPI.Response.Release BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == ReleaseResult.Failed)
		{
			if (this.LHQQCLOEHJG.Count > 0)
			{
				for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
				{
					if (this.LHQQCLOEHJG[i].LDQDJLFIDCN == BJGCBDNBQCJ.Pokemon)
					{
						this.LHQQCLOEHJG[i].GNLNPCCPBCF = -1;
						this.LHQQCLOEHJG[i].PELCNBCMNFH = -1;
						break;
					}
				}
			}
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
			if (JJGLMJNELOK.QOQONHOOLNE != null)
			{
				if (!string.IsNullOrEmpty(JJGLMJNELOK.KGOPJQOMMNC().JKDFLFMOOHP.BGBMIEJJQKC))
				{
					JJGLMJNELOK.KGOPJQOMMNC().DEGOICOIDON();
					JJGLMJNELOK.BEKHPOHIPDE().OECECCPCLII();
					JJGLMJNELOK.BEKHPOHIPDE().CDCKKIJNHGD();
				}
				else
				{
					JJGLMJNELOK.QOQONHOOLNE.DEGOICOIDON();
				}
			}
		}
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x002984CC File Offset: 0x002966CC
	public Guid BOOBMLJMCLI(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 0];
		}
		return default(Guid);
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x00298500 File Offset: 0x00296700
	public int MJLJLFGEJQG(Guid JNOOPPDPFEH)
	{
		if (this.LHQQCLOEHJG.Count > 1)
		{
			for (int i = 1; i < this.LHQQCLOEHJG.Count; i += 0)
			{
				if (this.LHQQCLOEHJG[i].KGMFIOCJLEP() == JNOOPPDPFEH)
				{
					return i;
				}
			}
		}
		return -1;
	}

	// Token: 0x06004FDA RID: 20442 RVA: 0x0001F741 File Offset: 0x0001D941
	private static int KHKGMFHJBBE(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x00298550 File Offset: 0x00296750
	public void ECNHBBBHGPF(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 0 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 1) || QQQEPOCKCME + 0 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		PSXAPI.Request.Reorder dcgclgqcgdq = new PSXAPI.Request.Reorder
		{
			Pokemon = this.LIJHMFEGCCK[QQQEPOCKCME],
			Position = NPGFLNDCNMC + 1
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x002985C0 File Offset: 0x002967C0
	public void FCOQCHGIIGN(PSXAPI.Response.Evolve BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == EvolutionResult.Success)
		{
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Previous) + " evolved into " + KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Pokemon.Pokemon.Payload.PokemonID) + "!");
		}
		else if (BJGCBDNBQCJ.Result == EvolutionResult.Failed)
		{
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("Failed to evolve!");
		}
		else if (BJGCBDNBQCJ.Result == EvolutionResult.Canceled)
		{
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Previous) + " did not evolve!");
		}
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, true);
		}
	}

	// Token: 0x06004FDD RID: 20445 RVA: 0x00298670 File Offset: 0x00296870
	public void PBLEJMDECNP(PSXAPI.Response.Evs BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result != (EvsResult)5)
		{
			if (BJGCBDNBQCJ.Result != (EvsResult)5)
			{
				if (BJGCBDNBQCJ.Result == EvsResult.Failed)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.QLJEQBGLPOE(BJGCBDNBQCJ.PokemonUID);
					string text = string.Empty;
					if (BJGCBDNBQCJ.Money > 0u)
					{
						text = text + "tangledfeet" + BJGCBDNBQCJ.Money.ToString("#,##0");
						if (BJGCBDNBQCJ.Gold > 0u)
						{
							text += "[33CCFF]";
						}
					}
					if (BJGCBDNBQCJ.Gold > 0u)
					{
						text = text + "ice" + BJGCBDNBQCJ.Gold.ToString();
					}
					CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.MOGQNGEPCEO();
					string hiefqeedhgg = "/03_1";
					string[] array = new string[3];
					array[0] = "[";
					array[0] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					array[3] = "Blank";
					array[4] = text;
					array[6] = "adjacentAlly";
					cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), BJGCBDNBQCJ.PokemonUID.ToString(), (LPBPDPMJKNN.PJIJIFKBMBB)6, false, null, -1, false);
					return;
				}
				if (BJGCBDNBQCJ.Result == EvsResult.Failed)
				{
					CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("^emote+", "Stance Change", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
					return;
				}
				return;
			}
		}
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.IJCIQLHLFQE(BJGCBDNBQCJ.Pokemon, true);
		}
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x002987BC File Offset: 0x002969BC
	public void LMCFJKKPENB(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 6 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 1) || QQQEPOCKCME + 1 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = this.LIJHMFEGCCK[QQQEPOCKCME],
			Pokemon2 = this.LIJHMFEGCCK[NPGFLNDCNMC]
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x00298834 File Offset: 0x00296A34
	public KGQECFKLKOP.FEKOIOJQNKH KQPKDONQCHC(Guid JNOOPPDPFEH)
	{
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 1; i < this.LHQQCLOEHJG.Count; i += 0)
			{
				if (this.LHQQCLOEHJG[i].FCQMGQOEDLJ() == JNOOPPDPFEH)
				{
					return this.LHQQCLOEHJG[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x00298890 File Offset: 0x00296A90
	public KGQECFKLKOP.FEKOIOJQNKH HQPPLJEPDGO(PokemonData CFHEIICNLFD)
	{
		return this.IJCIQLHLFQE(new InventoryPokemon
		{
			Box = -1,
			Position = -1,
			Pokemon = CFHEIICNLFD
		}, false);
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x002988C0 File Offset: 0x00296AC0
	public void LIFEQHOJCDL(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 0 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 1) || QQQEPOCKCME + 1 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = this.LIJHMFEGCCK[QQQEPOCKCME],
			Pokemon2 = this.LIJHMFEGCCK[NPGFLNDCNMC]
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x00298938 File Offset: 0x00296B38
	public KGQECFKLKOP.FEKOIOJQNKH IJCIQLHLFQE(InventoryPokemon BJGCBDNBQCJ, bool CGHLGBDQPDJ = true)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = null;
		if (BJGCBDNBQCJ != null)
		{
			fekoiojqnkh = new KGQECFKLKOP.FEKOIOJQNKH();
			bool flag = false;
			if (BJGCBDNBQCJ.Position == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.KQPKDONQCHC(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh2 != null && fekoiojqnkh2.PELCNBCMNFH != -1)
				{
					flag = false;
					fekoiojqnkh.PELCNBCMNFH = fekoiojqnkh2.PELCNBCMNFH;
				}
			}
			if (flag)
			{
				fekoiojqnkh.PELCNBCMNFH = BJGCBDNBQCJ.Position;
			}
			if (BJGCBDNBQCJ.Pokemon.Payload == null)
			{
				PSXAPI.Response.Payload.Pokemon pokemon = new PSXAPI.Response.Payload.Pokemon();
				pokemon.EVs = new PokemonStats();
				pokemon.IVs = new PokemonStats();
				pokemon.Shiny = false;
				BJGCBDNBQCJ.Pokemon.Payload = pokemon;
				BJGCBDNBQCJ.Pokemon.Stats = new PokemonStats();
			}
			fekoiojqnkh.LDQDJLFIDCN = BJGCBDNBQCJ.Pokemon.UniqueID;
			fekoiojqnkh.QKNEIJQHGCB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			bool flag2 = false;
			if (BJGCBDNBQCJ.Box == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh3 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh3 != null && fekoiojqnkh3.GNLNPCCPBCF != -1)
				{
					flag2 = true;
					fekoiojqnkh.GNLNPCCPBCF = fekoiojqnkh3.GNLNPCCPBCF;
				}
			}
			if (flag2)
			{
				fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			}
			fekoiojqnkh.CQQPFJQINIM = BJGCBDNBQCJ.Pokemon.EggState;
			fekoiojqnkh.JQJCBJQNQGH = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.JQJCBJQNQGH.EQOCFKQLIQI(BJGCBDNBQCJ.Pokemon.Payload.EVs.Atk);
			fekoiojqnkh.JQJCBJQNQGH.DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Payload.EVs.Def);
			fekoiojqnkh.JQJCBJQNQGH.GEHNNOIODBK(BJGCBDNBQCJ.Pokemon.Payload.EVs.Speed);
			fekoiojqnkh.JQJCBJQNQGH.JBEEQJJEGOL(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpAtk);
			fekoiojqnkh.JQJCBJQNQGH.QCLCPPFKMOF(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpDef);
			fekoiojqnkh.JQJCBJQNQGH.FBHCKFCQJDC(BJGCBDNBQCJ.Pokemon.Payload.EVs.HP);
			fekoiojqnkh.KJHPHCELIEM(BJGCBDNBQCJ.Pokemon.Payload.Personality);
			fekoiojqnkh.IGNCCHJJGCI(new KGQECFKLKOP.JEMOPHMPLJB());
			fekoiojqnkh.PHNEOKOLPJH().CNQHCGCKDLM(BJGCBDNBQCJ.Pokemon.Payload.IVs.Atk);
			fekoiojqnkh.PHNEOKOLPJH().DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Payload.IVs.Def);
			fekoiojqnkh.PHNEOKOLPJH().MHDELFIJJMI(BJGCBDNBQCJ.Pokemon.Payload.IVs.Speed);
			fekoiojqnkh.DGOCNDGDBOJ.GOIDCIDMLCN(BJGCBDNBQCJ.Pokemon.Payload.IVs.SpAtk);
			fekoiojqnkh.PHNEOKOLPJH().KDPQNIPNBHD(BJGCBDNBQCJ.Pokemon.Payload.IVs.SpDef);
			fekoiojqnkh.DGOCNDGDBOJ.QBKHOPLHEJH(BJGCBDNBQCJ.Pokemon.Payload.IVs.HP);
			fekoiojqnkh.HHKJGOPMMQL = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.HHKJGOPMMQL.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Stats.Atk;
			fekoiojqnkh.HHKJGOPMMQL.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Stats.Def;
			fekoiojqnkh.HHKJGOPMMQL.DEHIKNQGCNQ(BJGCBDNBQCJ.Pokemon.Stats.Speed);
			fekoiojqnkh.HHKJGOPMMQL.CJGPQDKIENB(BJGCBDNBQCJ.Pokemon.Stats.SpAtk);
			fekoiojqnkh.HHKJGOPMMQL.QCLCPPFKMOF(BJGCBDNBQCJ.Pokemon.Stats.SpDef);
			fekoiojqnkh.HHKJGOPMMQL.MFDFLGQCKOO(BJGCBDNBQCJ.Pokemon.Stats.HP);
			fekoiojqnkh.EGDMHCLOGCC = BJGCBDNBQCJ.Pokemon.ExpNext;
			fekoiojqnkh.QBIOBPFKCBK(BJGCBDNBQCJ.Pokemon.ExpStart);
			fekoiojqnkh.GMEHGLPQQIN(BJGCBDNBQCJ.Pokemon.Payload.Exp);
			fekoiojqnkh.PQCNDKGBHHQ = !BJGCBDNBQCJ.Pokemon.Payload.NotTradeable;
			fekoiojqnkh.EHHMQOODCFH(BJGCBDNBQCJ.Pokemon.Payload.Pokeball);
			if (fekoiojqnkh.PCIEOCNICGI == 0)
			{
				fekoiojqnkh.PCIEOCNICGI = 8;
			}
			fekoiojqnkh.ELNPOGIQCGK = new KGQECFKLKOP.JEMOPHMPLJB();
			if (BJGCBDNBQCJ.Pokemon.Payload.EVsCollected != null)
			{
				fekoiojqnkh.ELNPOGIQCGK.KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Atk);
				fekoiojqnkh.ELNPOGIQCGK.DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Def);
				fekoiojqnkh.ELNPOGIQCGK.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Speed;
				fekoiojqnkh.ELNPOGIQCGK.GOQNPJHBLMB(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpAtk);
				fekoiojqnkh.ELNPOGIQCGK.KDPQNIPNBHD(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpDef);
				fekoiojqnkh.ELNPOGIQCGK.FJKJJILNECP(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.HP);
			}
			fekoiojqnkh.OQDOCCGPJDQ = (KGQECFKLKOP.LKHFHFNEKIJ)BJGCBDNBQCJ.Pokemon.Payload.Gender;
			fekoiojqnkh.JENKCPBFNQC = BJGCBDNBQCJ.Pokemon.Payload.Happiness;
			fekoiojqnkh.OJBCJLMDNIC(BJGCBDNBQCJ.Pokemon.Payload.HP);
			fekoiojqnkh.QKBGGCKIOLG = BJGCBDNBQCJ.Pokemon.Stats.HP;
			fekoiojqnkh.BBJIGEGIEGN = BJGCBDNBQCJ.Pokemon.Payload.CaughtLevel;
			fekoiojqnkh.KIFNIBMPFFP(BJGCBDNBQCJ.Pokemon.Payload.CaughtDateUtc.ToString("i"));
			if (BJGCBDNBQCJ.Pokemon.Payload.Moves != null)
			{
				fekoiojqnkh.BNGOLEPOJGM(new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.Pokemon.Payload.Moves.Length]);
				for (int i = 0; i < BJGCBDNBQCJ.Pokemon.Payload.Moves.Length; i += 0)
				{
					fekoiojqnkh.EEILBMOOJHJ[i] = new KGQECFKLKOP.EDHMLDLCFHC();
					fekoiojqnkh.EEILBMOOJHJ[i].CKDGGBOMOGO(KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move));
					fekoiojqnkh.EEILBMOOJHJ[i].HPMPDPMMGFE(BJGCBDNBQCJ.Pokemon.Payload.Moves[i].PP);
					fekoiojqnkh.EEILBMOOJHJ[i].JMMIPIBDEKL(BJGCBDNBQCJ.Pokemon.Payload.Moves[i].MaxPP);
					fekoiojqnkh.EEILBMOOJHJ[i].DNEICCPKCBL(((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move).ToString());
				}
			}
			fekoiojqnkh.EOMPMQNGIBD = BJGCBDNBQCJ.Pokemon.Payload.Level;
			fekoiojqnkh.GECLELHHNIO = BJGCBDNBQCJ.Pokemon.Payload.HoldItem;
			fekoiojqnkh.NIONIJNNKCE = (KGQECFKLKOP.MMOPMGNGOQB)BJGCBDNBQCJ.Pokemon.Payload.Nature;
			fekoiojqnkh.BEQHNFFEHMQ = (int)BJGCBDNBQCJ.Pokemon.Payload.PokemonID;
			fekoiojqnkh.PLCBFLQBCQN = (KGQECFKLKOP.PFPBKQFQFFG)BJGCBDNBQCJ.Pokemon.Payload.Condition;
			fekoiojqnkh.BKNFHNFFCHE = BJGCBDNBQCJ.Pokemon.Payload.Shiny;
			fekoiojqnkh.BHPMOFEKHPM = BJGCBDNBQCJ.Pokemon.Ability;
			fekoiojqnkh.FOKJIJLEIDO = BJGCBDNBQCJ.Pokemon.OriginalTrainer;
			fekoiojqnkh.HHNOCOQJOJF = BJGCBDNBQCJ.Pokemon.Trainer;
			fekoiojqnkh.HMOJBOLDNNI = BJGCBDNBQCJ.CanLearnMove;
			fekoiojqnkh.PEIDDQJBENJ = BJGCBDNBQCJ.CanEvolve;
			if (fekoiojqnkh.CQQPFJQINIM != EggState.None)
			{
				fekoiojqnkh.BEQHNFFEHMQ = 72;
			}
			this.ICJKHJHMECD(fekoiojqnkh);
			if (CNCJKLNHQBH.MOGQNGEPCEO().GetComponent<LINELKKDMEE>().LDQDJLFIDCN == fekoiojqnkh.KPJLEOCJFFO())
			{
				CNCJKLNHQBH.MOGQNGEPCEO().GetComponent<LINELKKDMEE>().BQLIIQIIMDH(fekoiojqnkh);
			}
		}
		if (CGHLGBDQPDJ)
		{
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
		}
		return fekoiojqnkh;
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x002990E4 File Offset: 0x002972E4
	public KGQECFKLKOP.FEKOIOJQNKH MNICELEPBHO(InventoryPokemon BJGCBDNBQCJ, bool CGHLGBDQPDJ = true)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = null;
		if (BJGCBDNBQCJ != null)
		{
			fekoiojqnkh = new KGQECFKLKOP.FEKOIOJQNKH();
			bool flag = true;
			if (BJGCBDNBQCJ.Position == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh2 != null && fekoiojqnkh2.PELCNBCMNFH != -1)
				{
					flag = false;
					fekoiojqnkh.PELCNBCMNFH = fekoiojqnkh2.PELCNBCMNFH;
				}
			}
			if (flag)
			{
				fekoiojqnkh.PELCNBCMNFH = BJGCBDNBQCJ.Position;
			}
			if (BJGCBDNBQCJ.Pokemon.Payload == null)
			{
				PSXAPI.Response.Payload.Pokemon pokemon = new PSXAPI.Response.Payload.Pokemon();
				pokemon.EVs = new PokemonStats();
				pokemon.IVs = new PokemonStats();
				pokemon.Shiny = false;
				BJGCBDNBQCJ.Pokemon.Payload = pokemon;
				BJGCBDNBQCJ.Pokemon.Stats = new PokemonStats();
			}
			fekoiojqnkh.LDQDJLFIDCN = BJGCBDNBQCJ.Pokemon.UniqueID;
			fekoiojqnkh.QKNEIJQHGCB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			bool flag2 = true;
			if (BJGCBDNBQCJ.Box == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh3 = this.PEJHBEBOCOJ(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh3 != null && fekoiojqnkh3.GNLNPCCPBCF != -1)
				{
					flag2 = false;
					fekoiojqnkh.GNLNPCCPBCF = fekoiojqnkh3.GNLNPCCPBCF;
				}
			}
			if (flag2)
			{
				fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			}
			fekoiojqnkh.CQQPFJQINIM = BJGCBDNBQCJ.Pokemon.EggState;
			fekoiojqnkh.JQJCBJQNQGH = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.JQJCBJQNQGH.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Payload.EVs.Atk;
			fekoiojqnkh.JQJCBJQNQGH.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Payload.EVs.Def;
			fekoiojqnkh.JQJCBJQNQGH.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Payload.EVs.Speed;
			fekoiojqnkh.JQJCBJQNQGH.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Payload.EVs.SpAtk;
			fekoiojqnkh.JQJCBJQNQGH.PFDGJOLJEHC = BJGCBDNBQCJ.Pokemon.Payload.EVs.SpDef;
			fekoiojqnkh.JQJCBJQNQGH.BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Payload.EVs.HP;
			fekoiojqnkh.JJLPBICFJKB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			fekoiojqnkh.DGOCNDGDBOJ = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.DGOCNDGDBOJ.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Payload.IVs.Atk;
			fekoiojqnkh.DGOCNDGDBOJ.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Payload.IVs.Def;
			fekoiojqnkh.DGOCNDGDBOJ.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Payload.IVs.Speed;
			fekoiojqnkh.DGOCNDGDBOJ.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Payload.IVs.SpAtk;
			fekoiojqnkh.DGOCNDGDBOJ.PFDGJOLJEHC = BJGCBDNBQCJ.Pokemon.Payload.IVs.SpDef;
			fekoiojqnkh.DGOCNDGDBOJ.BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Payload.IVs.HP;
			fekoiojqnkh.HHKJGOPMMQL = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.HHKJGOPMMQL.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Stats.Atk;
			fekoiojqnkh.HHKJGOPMMQL.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Stats.Def;
			fekoiojqnkh.HHKJGOPMMQL.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Stats.Speed;
			fekoiojqnkh.HHKJGOPMMQL.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Stats.SpAtk;
			fekoiojqnkh.HHKJGOPMMQL.PFDGJOLJEHC = BJGCBDNBQCJ.Pokemon.Stats.SpDef;
			fekoiojqnkh.HHKJGOPMMQL.BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Stats.HP;
			fekoiojqnkh.EGDMHCLOGCC = BJGCBDNBQCJ.Pokemon.ExpNext;
			fekoiojqnkh.BNGBQLEQCPL = BJGCBDNBQCJ.Pokemon.ExpStart;
			fekoiojqnkh.CKPQFBKFLND = BJGCBDNBQCJ.Pokemon.Payload.Exp;
			fekoiojqnkh.PQCNDKGBHHQ = !BJGCBDNBQCJ.Pokemon.Payload.NotTradeable;
			fekoiojqnkh.PCIEOCNICGI = BJGCBDNBQCJ.Pokemon.Payload.Pokeball;
			if (fekoiojqnkh.PCIEOCNICGI == 0)
			{
				fekoiojqnkh.PCIEOCNICGI = 4;
			}
			fekoiojqnkh.ELNPOGIQCGK = new KGQECFKLKOP.JEMOPHMPLJB();
			if (BJGCBDNBQCJ.Pokemon.Payload.EVsCollected != null)
			{
				fekoiojqnkh.ELNPOGIQCGK.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Atk;
				fekoiojqnkh.ELNPOGIQCGK.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Def;
				fekoiojqnkh.ELNPOGIQCGK.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Speed;
				fekoiojqnkh.ELNPOGIQCGK.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpAtk;
				fekoiojqnkh.ELNPOGIQCGK.PFDGJOLJEHC = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpDef;
				fekoiojqnkh.ELNPOGIQCGK.BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.HP;
			}
			fekoiojqnkh.OQDOCCGPJDQ = (KGQECFKLKOP.LKHFHFNEKIJ)BJGCBDNBQCJ.Pokemon.Payload.Gender;
			fekoiojqnkh.JENKCPBFNQC = BJGCBDNBQCJ.Pokemon.Payload.Happiness;
			fekoiojqnkh.DCFKMOILHEC = BJGCBDNBQCJ.Pokemon.Payload.HP;
			fekoiojqnkh.QKBGGCKIOLG = BJGCBDNBQCJ.Pokemon.Stats.HP;
			fekoiojqnkh.BBJIGEGIEGN = BJGCBDNBQCJ.Pokemon.Payload.CaughtLevel;
			fekoiojqnkh.OMMNBECPELQ = BJGCBDNBQCJ.Pokemon.Payload.CaughtDateUtc.ToString("dd/MM/yyyy");
			if (BJGCBDNBQCJ.Pokemon.Payload.Moves != null)
			{
				fekoiojqnkh.EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.Pokemon.Payload.Moves.Length];
				for (int i = 0; i < BJGCBDNBQCJ.Pokemon.Payload.Moves.Length; i++)
				{
					fekoiojqnkh.EEILBMOOJHJ[i] = new KGQECFKLKOP.EDHMLDLCFHC();
					fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK = KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move);
					fekoiojqnkh.EEILBMOOJHJ[i].LIQCECMEOIJ = BJGCBDNBQCJ.Pokemon.Payload.Moves[i].PP;
					fekoiojqnkh.EEILBMOOJHJ[i].JPLIFCNPICK = BJGCBDNBQCJ.Pokemon.Payload.Moves[i].MaxPP;
					fekoiojqnkh.EEILBMOOJHJ[i].CIQFCJGQEMH = ((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move).ToString();
				}
			}
			fekoiojqnkh.EOMPMQNGIBD = BJGCBDNBQCJ.Pokemon.Payload.Level;
			fekoiojqnkh.GECLELHHNIO = BJGCBDNBQCJ.Pokemon.Payload.HoldItem;
			fekoiojqnkh.NIONIJNNKCE = (KGQECFKLKOP.MMOPMGNGOQB)BJGCBDNBQCJ.Pokemon.Payload.Nature;
			fekoiojqnkh.BEQHNFFEHMQ = (int)BJGCBDNBQCJ.Pokemon.Payload.PokemonID;
			fekoiojqnkh.PLCBFLQBCQN = (KGQECFKLKOP.PFPBKQFQFFG)BJGCBDNBQCJ.Pokemon.Payload.Condition;
			fekoiojqnkh.BKNFHNFFCHE = BJGCBDNBQCJ.Pokemon.Payload.Shiny;
			fekoiojqnkh.BHPMOFEKHPM = BJGCBDNBQCJ.Pokemon.Ability;
			fekoiojqnkh.FOKJIJLEIDO = BJGCBDNBQCJ.Pokemon.OriginalTrainer;
			fekoiojqnkh.HHNOCOQJOJF = BJGCBDNBQCJ.Pokemon.Trainer;
			fekoiojqnkh.HMOJBOLDNNI = BJGCBDNBQCJ.CanLearnMove;
			fekoiojqnkh.PEIDDQJBENJ = BJGCBDNBQCJ.CanEvolve;
			if (fekoiojqnkh.CQQPFJQINIM != EggState.None)
			{
				fekoiojqnkh.BEQHNFFEHMQ = 9999;
			}
			this.ICJKHJHMECD(fekoiojqnkh);
			if (CNCJKLNHQBH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().LDQDJLFIDCN == fekoiojqnkh.LDQDJLFIDCN)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().BQLIIQIIMDH(fekoiojqnkh);
			}
		}
		if (CGHLGBDQPDJ)
		{
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
		}
		return fekoiojqnkh;
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x00299890 File Offset: 0x00297A90
	public void ICJKHJHMECD(KGQECFKLKOP.FEKOIOJQNKH PDIBIIKFBDH)
	{
		bool flag = true;
		int index = 0;
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].LDQDJLFIDCN == PDIBIIKFBDH.LDQDJLFIDCN)
				{
					flag = false;
					index = i;
					break;
				}
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			this.LHQQCLOEHJG.Add(PDIBIIKFBDH);
		}
		else
		{
			this.LHQQCLOEHJG[index] = PDIBIIKFBDH;
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x000205CA File Offset: 0x0001E7CA
	public static HFCMDEQKCKH QOQONHOOLNE
	{
		get
		{
			return HFCMDEQKCKH.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x0029990C File Offset: 0x00297B0C
	public void BJFKOHCDFKN()
	{
		for (int i = 0; i < this.LIJHMFEGCCK.Count; i++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(this.LIJHMFEGCCK[i]);
			if (fekoiojqnkh != null && i == 0)
			{
				CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.IDICNBQHCJG = fekoiojqnkh.QKNEIJQHGCB;
				CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.BEQHNFFEHMQ = fekoiojqnkh.BEQHNFFEHMQ;
				CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.BKNFHNFFCHE = fekoiojqnkh.BKNFHNFFCHE;
				CNCJKLNHQBH.QOQONHOOLNE.QMGOPPGNGPI.NBDBHLEKENM();
				return;
			}
		}
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x00299998 File Offset: 0x00297B98
	public void CCIMCGIEHJJ(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 1 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 0) || QQQEPOCKCME + 1 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = this.LIJHMFEGCCK[QQQEPOCKCME],
			Pokemon2 = this.LIJHMFEGCCK[NPGFLNDCNMC]
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x00299A10 File Offset: 0x00297C10
	public void MBLFHJFEELC()
	{
		List<HFCMDEQKCKH.CFQQQKEJLFH> list = new List<HFCMDEQKCKH.CFQQQKEJLFH>();
		this.LIJHMFEGCCK.Clear();
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].GNLNPCCPBCF == 0 && this.LHQQCLOEHJG[i].PELCNBCMNFH > 0 && this.LHQQCLOEHJG[i].PELCNBCMNFH < 7 && this.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					list.Add(new HFCMDEQKCKH.CFQQQKEJLFH
					{
						CIQFCJGQEMH = this.LHQQCLOEHJG[i].LDQDJLFIDCN,
						BDBBEMKFGPI = this.LHQQCLOEHJG[i].PELCNBCMNFH
					});
				}
			}
		}
		if (list.Count > 0)
		{
			List<HFCMDEQKCKH.CFQQQKEJLFH> list2 = list;
			if (HFCMDEQKCKH.HNCJFHJNHDN == null)
			{
				HFCMDEQKCKH.HNCJFHJNHDN = new Comparison<HFCMDEQKCKH.CFQQQKEJLFH>(HFCMDEQKCKH.KEFKOHHJBFO);
			}
			list2.Sort(HFCMDEQKCKH.HNCJFHJNHDN);
			for (int j = 0; j < 6; j++)
			{
				if (j < list.Count)
				{
					if (this.PEJHBEBOCOJ(list[j].CIQFCJGQEMH) != null)
					{
						this.PEJHBEBOCOJ(list[j].CIQFCJGQEMH).PELCNBCMNFH = j + 1;
					}
					this.LIJHMFEGCCK.Add(list[j].CIQFCJGQEMH);
				}
			}
		}
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x00298178 File Offset: 0x00296378
	public Guid QHQCCDKCQDD(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 1];
		}
		return default(Guid);
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x000205CA File Offset: 0x0001E7CA
	public static HFCMDEQKCKH CFGIOIGOIFQ()
	{
		return HFCMDEQKCKH.HBFFCJHOCPE;
	}

	// Token: 0x06004FEB RID: 20459 RVA: 0x0001F741 File Offset: 0x0001D941
	private static int NDNBCOJFKOD(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x00299B9C File Offset: 0x00297D9C
	public void FHNJGBQIDFC(PSXAPI.Response.Ivs BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == IvsResult.Changed)
		{
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, true);
			}
		}
		else if (BJGCBDNBQCJ.Result == IvsResult.Request)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(BJGCBDNBQCJ.PokemonUID);
			string text = string.Empty;
			if (BJGCBDNBQCJ.Money > 0u)
			{
				text = text + "[PD]" + BJGCBDNBQCJ.Money.ToString("#,##0");
				if (BJGCBDNBQCJ.Gold > 0u)
				{
					text += "   ";
				}
			}
			if (BJGCBDNBQCJ.Gold > 0u)
			{
				text = text + "[PG]" + BJGCBDNBQCJ.Gold.ToString();
			}
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Reset IVs", string.Concat(new string[]
			{
				"Resetting IVs for your ",
				KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ),
				" will cost\n",
				text,
				"\nAre you sure you want to Reset its IVs?"
			}), BJGCBDNBQCJ.PokemonUID.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
		}
		else if (BJGCBDNBQCJ.Result == IvsResult.Failed && BJGCBDNBQCJ.Gold > 0u)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Resetting IVs", "You can not afford to reset your IVs", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
		}
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x00299CE4 File Offset: 0x00297EE4
	public void OLEFNOKCLIG(Guid QQQEPOCKCME, Guid NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = QQQEPOCKCME,
			Pokemon2 = NPGFLNDCNMC
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x000205C2 File Offset: 0x0001E7C2
	private void COFPBILHHNO()
	{
		HFCMDEQKCKH.HBFFCJHOCPE = this;
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x00298178 File Offset: 0x00296378
	public Guid CBHKEIBQFGF(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 1];
		}
		return default(Guid);
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x00299D20 File Offset: 0x00297F20
	public KGQECFKLKOP.FEKOIOJQNKH KBEQBIPOJKO(InventoryPokemon BJGCBDNBQCJ, bool CGHLGBDQPDJ = true)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = null;
		if (BJGCBDNBQCJ != null)
		{
			fekoiojqnkh = new KGQECFKLKOP.FEKOIOJQNKH();
			bool flag = false;
			if (BJGCBDNBQCJ.Position == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh2 != null && fekoiojqnkh2.PELCNBCMNFH != -1)
				{
					flag = true;
					fekoiojqnkh.PELCNBCMNFH = fekoiojqnkh2.PELCNBCMNFH;
				}
			}
			if (flag)
			{
				fekoiojqnkh.PELCNBCMNFH = BJGCBDNBQCJ.Position;
			}
			if (BJGCBDNBQCJ.Pokemon.Payload == null)
			{
				PSXAPI.Response.Payload.Pokemon pokemon = new PSXAPI.Response.Payload.Pokemon();
				pokemon.EVs = new PokemonStats();
				pokemon.IVs = new PokemonStats();
				pokemon.Shiny = false;
				BJGCBDNBQCJ.Pokemon.Payload = pokemon;
				BJGCBDNBQCJ.Pokemon.Stats = new PokemonStats();
			}
			fekoiojqnkh.JHMGIDEIELL(BJGCBDNBQCJ.Pokemon.UniqueID);
			fekoiojqnkh.PMLIIKLEBMI(BJGCBDNBQCJ.Pokemon.Payload.Personality);
			bool flag2 = true;
			if (BJGCBDNBQCJ.Box == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh3 = this.KQPKDONQCHC(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh3 != null && fekoiojqnkh3.GNLNPCCPBCF != -1)
				{
					flag2 = true;
					fekoiojqnkh.GNLNPCCPBCF = fekoiojqnkh3.GNLNPCCPBCF;
				}
			}
			if (flag2)
			{
				fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			}
			fekoiojqnkh.CQQPFJQINIM = BJGCBDNBQCJ.Pokemon.EggState;
			fekoiojqnkh.JQJCBJQNQGH = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.JQJCBJQNQGH.KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Payload.EVs.Atk);
			fekoiojqnkh.JQJCBJQNQGH.LEQMKNLPKHI(BJGCBDNBQCJ.Pokemon.Payload.EVs.Def);
			fekoiojqnkh.JQJCBJQNQGH.MHDELFIJJMI(BJGCBDNBQCJ.Pokemon.Payload.EVs.Speed);
			fekoiojqnkh.JQJCBJQNQGH.DHGDDKDEHHM(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpAtk);
			fekoiojqnkh.JQJCBJQNQGH.JHIOCFNHCLG(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpDef);
			fekoiojqnkh.JQJCBJQNQGH.QBKHOPLHEJH(BJGCBDNBQCJ.Pokemon.Payload.EVs.HP);
			fekoiojqnkh.JJLPBICFJKB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			fekoiojqnkh.DGOCNDGDBOJ = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.DGOCNDGDBOJ.CNQHCGCKDLM(BJGCBDNBQCJ.Pokemon.Payload.IVs.Atk);
			fekoiojqnkh.PHNEOKOLPJH().DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Payload.IVs.Def);
			fekoiojqnkh.PHNEOKOLPJH().BGKDKPEFMJI(BJGCBDNBQCJ.Pokemon.Payload.IVs.Speed);
			fekoiojqnkh.PHNEOKOLPJH().OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Payload.IVs.SpAtk;
			fekoiojqnkh.PHNEOKOLPJH().KDPQNIPNBHD(BJGCBDNBQCJ.Pokemon.Payload.IVs.SpDef);
			fekoiojqnkh.DGOCNDGDBOJ.FJKJJILNECP(BJGCBDNBQCJ.Pokemon.Payload.IVs.HP);
			fekoiojqnkh.HHKJGOPMMQL = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.HHKJGOPMMQL.CNQHCGCKDLM(BJGCBDNBQCJ.Pokemon.Stats.Atk);
			fekoiojqnkh.HHKJGOPMMQL.DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Stats.Def);
			fekoiojqnkh.HHKJGOPMMQL.GEHNNOIODBK(BJGCBDNBQCJ.Pokemon.Stats.Speed);
			fekoiojqnkh.HHKJGOPMMQL.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Stats.SpAtk;
			fekoiojqnkh.HHKJGOPMMQL.KDPQNIPNBHD(BJGCBDNBQCJ.Pokemon.Stats.SpDef);
			fekoiojqnkh.HHKJGOPMMQL.KIODEJHFLDM(BJGCBDNBQCJ.Pokemon.Stats.HP);
			fekoiojqnkh.EGDMHCLOGCC = BJGCBDNBQCJ.Pokemon.ExpNext;
			fekoiojqnkh.BNGBQLEQCPL = BJGCBDNBQCJ.Pokemon.ExpStart;
			fekoiojqnkh.CKPQFBKFLND = BJGCBDNBQCJ.Pokemon.Payload.Exp;
			fekoiojqnkh.PQCNDKGBHHQ = BJGCBDNBQCJ.Pokemon.Payload.NotTradeable;
			fekoiojqnkh.EHHMQOODCFH(BJGCBDNBQCJ.Pokemon.Payload.Pokeball);
			if (fekoiojqnkh.HFKQMNDQKNG() == 0)
			{
				fekoiojqnkh.CQHJHGHHEPP(5);
			}
			fekoiojqnkh.ELNPOGIQCGK = new KGQECFKLKOP.JEMOPHMPLJB();
			if (BJGCBDNBQCJ.Pokemon.Payload.EVsCollected != null)
			{
				fekoiojqnkh.ELNPOGIQCGK.KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Atk);
				fekoiojqnkh.ELNPOGIQCGK.LEQMKNLPKHI(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Def);
				fekoiojqnkh.ELNPOGIQCGK.GEHNNOIODBK(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Speed);
				fekoiojqnkh.ELNPOGIQCGK.OCNKGBBOOHF = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpAtk;
				fekoiojqnkh.ELNPOGIQCGK.JHIOCFNHCLG(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpDef);
				fekoiojqnkh.ELNPOGIQCGK.MFDFLGQCKOO(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.HP);
			}
			fekoiojqnkh.OQDOCCGPJDQ = (KGQECFKLKOP.LKHFHFNEKIJ)BJGCBDNBQCJ.Pokemon.Payload.Gender;
			fekoiojqnkh.JENKCPBFNQC = BJGCBDNBQCJ.Pokemon.Payload.Happiness;
			fekoiojqnkh.PFLNFKGPHFP(BJGCBDNBQCJ.Pokemon.Payload.HP);
			fekoiojqnkh.QKBGGCKIOLG = BJGCBDNBQCJ.Pokemon.Stats.HP;
			fekoiojqnkh.BBJIGEGIEGN = BJGCBDNBQCJ.Pokemon.Payload.CaughtLevel;
			fekoiojqnkh.KIFNIBMPFFP(BJGCBDNBQCJ.Pokemon.Payload.CaughtDateUtc.ToString("BB:"));
			if (BJGCBDNBQCJ.Pokemon.Payload.Moves != null)
			{
				fekoiojqnkh.EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.Pokemon.Payload.Moves.Length];
				for (int i = 1; i < BJGCBDNBQCJ.Pokemon.Payload.Moves.Length; i++)
				{
					fekoiojqnkh.EEILBMOOJHJ[i] = new KGQECFKLKOP.EDHMLDLCFHC();
					fekoiojqnkh.EEILBMOOJHJ[i].FBCKQEDONJK = KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move);
					fekoiojqnkh.EEILBMOOJHJ[i].LFPNPJIDOGE(BJGCBDNBQCJ.Pokemon.Payload.Moves[i].PP);
					fekoiojqnkh.EEILBMOOJHJ[i].JMMIPIBDEKL(BJGCBDNBQCJ.Pokemon.Payload.Moves[i].MaxPP);
					fekoiojqnkh.EEILBMOOJHJ[i].CKOQNHHLHMD(((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move).ToString());
				}
			}
			fekoiojqnkh.EOMPMQNGIBD = BJGCBDNBQCJ.Pokemon.Payload.Level;
			fekoiojqnkh.GECLELHHNIO = BJGCBDNBQCJ.Pokemon.Payload.HoldItem;
			fekoiojqnkh.NIONIJNNKCE = (KGQECFKLKOP.MMOPMGNGOQB)BJGCBDNBQCJ.Pokemon.Payload.Nature;
			fekoiojqnkh.BEQHNFFEHMQ = (int)BJGCBDNBQCJ.Pokemon.Payload.PokemonID;
			fekoiojqnkh.PLCBFLQBCQN = (KGQECFKLKOP.PFPBKQFQFFG)BJGCBDNBQCJ.Pokemon.Payload.Condition;
			fekoiojqnkh.BKNFHNFFCHE = BJGCBDNBQCJ.Pokemon.Payload.Shiny;
			fekoiojqnkh.PGOOOKLGJKQ(BJGCBDNBQCJ.Pokemon.Ability);
			fekoiojqnkh.FOKJIJLEIDO = BJGCBDNBQCJ.Pokemon.OriginalTrainer;
			fekoiojqnkh.HHNOCOQJOJF = BJGCBDNBQCJ.Pokemon.Trainer;
			fekoiojqnkh.HMOJBOLDNNI = BJGCBDNBQCJ.CanLearnMove;
			fekoiojqnkh.PEIDDQJBENJ = BJGCBDNBQCJ.CanEvolve;
			if (fekoiojqnkh.CQQPFJQINIM != EggState.None)
			{
				fekoiojqnkh.BEQHNFFEHMQ = 19;
			}
			this.ICJKHJHMECD(fekoiojqnkh);
			if (CNCJKLNHQBH.MOGQNGEPCEO().GetComponent<LINELKKDMEE>().LDQDJLFIDCN == fekoiojqnkh.KPJLEOCJFFO())
			{
				CNCJKLNHQBH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().BQLIIQIIMDH(fekoiojqnkh);
			}
		}
		if (CGHLGBDQPDJ)
		{
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
		}
		return fekoiojqnkh;
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x0029A4CC File Offset: 0x002986CC
	public void ONDIPCGKDGE(PSXAPI.Response.Release BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == ReleaseResult.Failed)
		{
			if (this.LHQQCLOEHJG.Count > 0)
			{
				for (int i = 0; i < this.LHQQCLOEHJG.Count; i += 0)
				{
					if (this.LHQQCLOEHJG[i].GBNQEKLJFCI() == BJGCBDNBQCJ.Pokemon)
					{
						this.LHQQCLOEHJG[i].GNLNPCCPBCF = -1;
						this.LHQQCLOEHJG[i].PELCNBCMNFH = -1;
						break;
					}
				}
			}
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
			if (JJGLMJNELOK.QOQONHOOLNE != null)
			{
				if (!string.IsNullOrEmpty(JJGLMJNELOK.BEKHPOHIPDE().JKDFLFMOOHP.BGBMIEJJQKC))
				{
					JJGLMJNELOK.KGOPJQOMMNC().CNEBQQPDGIP();
					JJGLMJNELOK.QOQONHOOLNE.LPMCEKBJCHK();
					JJGLMJNELOK.BEKHPOHIPDE().GEEHLPKMFCD();
				}
				else
				{
					JJGLMJNELOK.KGOPJQOMMNC().CNEBQQPDGIP();
				}
			}
		}
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x00298178 File Offset: 0x00296378
	public Guid OLLLBGMLIMI(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 1];
		}
		return default(Guid);
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x0029A5A8 File Offset: 0x002987A8
	public void IGEBMGJKECH(PSXAPI.Response.Release BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == ReleaseResult.Failed)
		{
			if (this.LHQQCLOEHJG.Count > 0)
			{
				for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
				{
					if (this.LHQQCLOEHJG[i].FCQMGQOEDLJ() == BJGCBDNBQCJ.Pokemon)
					{
						this.LHQQCLOEHJG[i].GNLNPCCPBCF = -1;
						this.LHQQCLOEHJG[i].PELCNBCMNFH = -1;
						break;
					}
				}
			}
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
			if (JJGLMJNELOK.QOQONHOOLNE != null)
			{
				if (!string.IsNullOrEmpty(JJGLMJNELOK.BEKHPOHIPDE().JKDFLFMOOHP.HJMJDJKOILH()))
				{
					JJGLMJNELOK.BEKHPOHIPDE().DEGOICOIDON();
					JJGLMJNELOK.QOQONHOOLNE.OECECCPCLII();
					JJGLMJNELOK.KGOPJQOMMNC().CDCKKIJNHGD();
				}
				else
				{
					JJGLMJNELOK.BEKHPOHIPDE().DEGOICOIDON();
				}
			}
		}
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x0029A684 File Offset: 0x00298884
	public KGQECFKLKOP.FEKOIOJQNKH IICNONFCJFM(InventoryPokemon BJGCBDNBQCJ, bool CGHLGBDQPDJ = true)
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = null;
		if (BJGCBDNBQCJ != null)
		{
			fekoiojqnkh = new KGQECFKLKOP.FEKOIOJQNKH();
			bool flag = true;
			if (BJGCBDNBQCJ.Position == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh2 != null && fekoiojqnkh2.PELCNBCMNFH != -1)
				{
					flag = true;
					fekoiojqnkh.PELCNBCMNFH = fekoiojqnkh2.PELCNBCMNFH;
				}
			}
			if (flag)
			{
				fekoiojqnkh.PELCNBCMNFH = BJGCBDNBQCJ.Position;
			}
			if (BJGCBDNBQCJ.Pokemon.Payload == null)
			{
				PSXAPI.Response.Payload.Pokemon pokemon = new PSXAPI.Response.Payload.Pokemon();
				pokemon.EVs = new PokemonStats();
				pokemon.IVs = new PokemonStats();
				pokemon.Shiny = true;
				BJGCBDNBQCJ.Pokemon.Payload = pokemon;
				BJGCBDNBQCJ.Pokemon.Stats = new PokemonStats();
			}
			fekoiojqnkh.FDLHKNJJQQH(BJGCBDNBQCJ.Pokemon.UniqueID);
			fekoiojqnkh.QKNEIJQHGCB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			bool flag2 = true;
			if (BJGCBDNBQCJ.Box == -1)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh3 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon.UniqueID);
				if (fekoiojqnkh3 != null && fekoiojqnkh3.GNLNPCCPBCF != -1)
				{
					flag2 = false;
					fekoiojqnkh.GNLNPCCPBCF = fekoiojqnkh3.GNLNPCCPBCF;
				}
			}
			if (flag2)
			{
				fekoiojqnkh.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
			}
			fekoiojqnkh.CQQPFJQINIM = BJGCBDNBQCJ.Pokemon.EggState;
			fekoiojqnkh.JQJCBJQNQGH = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.JQJCBJQNQGH.JOJCLQMGJJP = BJGCBDNBQCJ.Pokemon.Payload.EVs.Atk;
			fekoiojqnkh.JQJCBJQNQGH.DOFDHGDMNBJ(BJGCBDNBQCJ.Pokemon.Payload.EVs.Def);
			fekoiojqnkh.JQJCBJQNQGH.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Payload.EVs.Speed;
			fekoiojqnkh.JQJCBJQNQGH.DHGDDKDEHHM(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpAtk);
			fekoiojqnkh.JQJCBJQNQGH.CMGBEHMHDJQ(BJGCBDNBQCJ.Pokemon.Payload.EVs.SpDef);
			fekoiojqnkh.JQJCBJQNQGH.BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Payload.EVs.HP;
			fekoiojqnkh.JJLPBICFJKB = BJGCBDNBQCJ.Pokemon.Payload.Personality;
			fekoiojqnkh.DGOCNDGDBOJ = new KGQECFKLKOP.JEMOPHMPLJB();
			fekoiojqnkh.PHNEOKOLPJH().KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Payload.IVs.Atk);
			fekoiojqnkh.PHNEOKOLPJH().EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Payload.IVs.Def;
			fekoiojqnkh.PHNEOKOLPJH().BGKDKPEFMJI(BJGCBDNBQCJ.Pokemon.Payload.IVs.Speed);
			fekoiojqnkh.PHNEOKOLPJH().CJGPQDKIENB(BJGCBDNBQCJ.Pokemon.Payload.IVs.SpAtk);
			fekoiojqnkh.PHNEOKOLPJH().CMGBEHMHDJQ(BJGCBDNBQCJ.Pokemon.Payload.IVs.SpDef);
			fekoiojqnkh.PHNEOKOLPJH().BLHBPGMPPNI = BJGCBDNBQCJ.Pokemon.Payload.IVs.HP;
			fekoiojqnkh.NHIFQFNBECF(new KGQECFKLKOP.JEMOPHMPLJB());
			fekoiojqnkh.HHKJGOPMMQL.KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Stats.Atk);
			fekoiojqnkh.HHKJGOPMMQL.LEQMKNLPKHI(BJGCBDNBQCJ.Pokemon.Stats.Def);
			fekoiojqnkh.HHKJGOPMMQL.OHGEFICKJJN = BJGCBDNBQCJ.Pokemon.Stats.Speed;
			fekoiojqnkh.HHKJGOPMMQL.GOQNPJHBLMB(BJGCBDNBQCJ.Pokemon.Stats.SpAtk);
			fekoiojqnkh.HHKJGOPMMQL.CMGBEHMHDJQ(BJGCBDNBQCJ.Pokemon.Stats.SpDef);
			fekoiojqnkh.HHKJGOPMMQL.FJKJJILNECP(BJGCBDNBQCJ.Pokemon.Stats.HP);
			fekoiojqnkh.EGDMHCLOGCC = BJGCBDNBQCJ.Pokemon.ExpNext;
			fekoiojqnkh.QBIOBPFKCBK(BJGCBDNBQCJ.Pokemon.ExpStart);
			fekoiojqnkh.CKPQFBKFLND = BJGCBDNBQCJ.Pokemon.Payload.Exp;
			fekoiojqnkh.PQCNDKGBHHQ = !BJGCBDNBQCJ.Pokemon.Payload.NotTradeable;
			fekoiojqnkh.EHHMQOODCFH(BJGCBDNBQCJ.Pokemon.Payload.Pokeball);
			if (fekoiojqnkh.PCIEOCNICGI == 0)
			{
				fekoiojqnkh.PCIEOCNICGI = 0;
			}
			fekoiojqnkh.ELNPOGIQCGK = new KGQECFKLKOP.JEMOPHMPLJB();
			if (BJGCBDNBQCJ.Pokemon.Payload.EVsCollected != null)
			{
				fekoiojqnkh.ELNPOGIQCGK.KHLNCDDHMHQ(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Atk);
				fekoiojqnkh.ELNPOGIQCGK.EOCPIGECLCM = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Def;
				fekoiojqnkh.ELNPOGIQCGK.GEHNNOIODBK(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.Speed);
				fekoiojqnkh.ELNPOGIQCGK.DHGDDKDEHHM(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpAtk);
				fekoiojqnkh.ELNPOGIQCGK.PFDGJOLJEHC = BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.SpDef;
				fekoiojqnkh.ELNPOGIQCGK.KIODEJHFLDM(BJGCBDNBQCJ.Pokemon.Payload.EVsCollected.HP);
			}
			fekoiojqnkh.OQDOCCGPJDQ = (KGQECFKLKOP.LKHFHFNEKIJ)BJGCBDNBQCJ.Pokemon.Payload.Gender;
			fekoiojqnkh.JENKCPBFNQC = BJGCBDNBQCJ.Pokemon.Payload.Happiness;
			fekoiojqnkh.OJBCJLMDNIC(BJGCBDNBQCJ.Pokemon.Payload.HP);
			fekoiojqnkh.QKBGGCKIOLG = BJGCBDNBQCJ.Pokemon.Stats.HP;
			fekoiojqnkh.BBJIGEGIEGN = BJGCBDNBQCJ.Pokemon.Payload.CaughtLevel;
			fekoiojqnkh.OMMNBECPELQ = BJGCBDNBQCJ.Pokemon.Payload.CaughtDateUtc.ToString("flowerveil");
			if (BJGCBDNBQCJ.Pokemon.Payload.Moves != null)
			{
				fekoiojqnkh.EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[BJGCBDNBQCJ.Pokemon.Payload.Moves.Length];
				for (int i = 1; i < BJGCBDNBQCJ.Pokemon.Payload.Moves.Length; i += 0)
				{
					fekoiojqnkh.EEILBMOOJHJ[i] = new KGQECFKLKOP.EDHMLDLCFHC();
					fekoiojqnkh.EEILBMOOJHJ[i].CKDGGBOMOGO(KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move));
					fekoiojqnkh.EEILBMOOJHJ[i].LIQCECMEOIJ = BJGCBDNBQCJ.Pokemon.Payload.Moves[i].PP;
					fekoiojqnkh.EEILBMOOJHJ[i].JPLIFCNPICK = BJGCBDNBQCJ.Pokemon.Payload.Moves[i].MaxPP;
					fekoiojqnkh.EEILBMOOJHJ[i].DNEICCPKCBL(((int)BJGCBDNBQCJ.Pokemon.Payload.Moves[i].Move).ToString());
				}
			}
			fekoiojqnkh.HOIEQINCNFI(BJGCBDNBQCJ.Pokemon.Payload.Level);
			fekoiojqnkh.GECLELHHNIO = BJGCBDNBQCJ.Pokemon.Payload.HoldItem;
			fekoiojqnkh.NIONIJNNKCE = (KGQECFKLKOP.MMOPMGNGOQB)BJGCBDNBQCJ.Pokemon.Payload.Nature;
			fekoiojqnkh.BEQHNFFEHMQ = (int)BJGCBDNBQCJ.Pokemon.Payload.PokemonID;
			fekoiojqnkh.PLCBFLQBCQN = (KGQECFKLKOP.PFPBKQFQFFG)BJGCBDNBQCJ.Pokemon.Payload.Condition;
			fekoiojqnkh.BKNFHNFFCHE = BJGCBDNBQCJ.Pokemon.Payload.Shiny;
			fekoiojqnkh.PGOOOKLGJKQ(BJGCBDNBQCJ.Pokemon.Ability);
			fekoiojqnkh.HPNHCMMQHNF(BJGCBDNBQCJ.Pokemon.OriginalTrainer);
			fekoiojqnkh.HHNOCOQJOJF = BJGCBDNBQCJ.Pokemon.Trainer;
			fekoiojqnkh.HMOJBOLDNNI = BJGCBDNBQCJ.CanLearnMove;
			fekoiojqnkh.PEIDDQJBENJ = BJGCBDNBQCJ.CanEvolve;
			if (fekoiojqnkh.CQQPFJQINIM != EggState.None)
			{
				fekoiojqnkh.BEQHNFFEHMQ = 43;
			}
			this.ICJKHJHMECD(fekoiojqnkh);
			if (CNCJKLNHQBH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().LDQDJLFIDCN == fekoiojqnkh.KPJLEOCJFFO())
			{
				CNCJKLNHQBH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().BQLIIQIIMDH(fekoiojqnkh);
			}
		}
		if (CGHLGBDQPDJ)
		{
			this.MBLFHJFEELC();
			this.PDDJMNOOPJD();
		}
		return fekoiojqnkh;
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x0001F741 File Offset: 0x0001D941
	private static int FHQLFEBMFGF(HFCMDEQKCKH.CFQQQKEJLFH IIPEMEFFDQF, HFCMDEQKCKH.CFQQQKEJLFH BQKFLFGLCJQ)
	{
		return IIPEMEFFDQF.BDBBEMKFGPI.CompareTo(BQKFLFGLCJQ.BDBBEMKFGPI);
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x0029AE30 File Offset: 0x00299030
	public void HIFNEGDCPDO(int GCHOHJEKMNG, Guid JNOOPPDPFEH)
	{
		PSXAPI.Request.Transfer dcgclgqcgdq = new PSXAPI.Request.Transfer
		{
			Box = GCHOHJEKMNG,
			Pokemon = JNOOPPDPFEH
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x00298178 File Offset: 0x00296378
	public Guid PGGLNJIFDDF(int DBPKNCDGGEP)
	{
		if (this.LIJHMFEGCCK.Count >= DBPKNCDGGEP)
		{
			return this.LIJHMFEGCCK[DBPKNCDGGEP - 1];
		}
		return default(Guid);
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x0029AE60 File Offset: 0x00299060
	public int NNBOPGKEFCN()
	{
		int jjpkkpfcqkn = JJGLMJNELOK.QOQONHOOLNE.JJPKKPFCQKN;
		int num = 1;
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i += 0)
			{
				if (this.LHQQCLOEHJG[i].GNLNPCCPBCF == jjpkkpfcqkn && this.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					num += 0;
				}
			}
		}
		return num;
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x0029AEE4 File Offset: 0x002990E4
	public void DEMINPFDMEG(int QQQEPOCKCME, int NPGFLNDCNMC)
	{
		if (QQQEPOCKCME == NPGFLNDCNMC)
		{
			return;
		}
		if (this.LIJHMFEGCCK == null)
		{
			return;
		}
		if ((NPGFLNDCNMC < 2 && this.LIJHMFEGCCK.Count < NPGFLNDCNMC + 0) || QQQEPOCKCME + 1 > this.LIJHMFEGCCK.Count)
		{
			return;
		}
		Swap dcgclgqcgdq = new Swap
		{
			Pokemon1 = this.LIJHMFEGCCK[QQQEPOCKCME],
			Pokemon2 = this.LIJHMFEGCCK[NPGFLNDCNMC]
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x0029AF5C File Offset: 0x0029915C
	public void PEJHIPCNNCG(PSXAPI.Response.Learn BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Pokemon != null)
		{
			this.MNICELEPBHO(BJGCBDNBQCJ.Pokemon, false);
		}
		if (BJGCBDNBQCJ.Result == (LearnResult)7)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Pokemon.Pokemon.Payload.PokemonID) + "cant" + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + "[-]");
		}
		else if (BJGCBDNBQCJ.Result == LearnResult.Failed)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.HBFFCJHOCPE.QLJEQBGLPOE(BJGCBDNBQCJ.PokemonUID);
			if (fekoiojqnkh != null)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + " began charging power!\r\n" + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + ")");
			}
		}
		else if (BJGCBDNBQCJ.Result == LearnResult.Failed)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(KGQECFKLKOP.NNHFLHEQMOI((int)BJGCBDNBQCJ.Pokemon.Pokemon.Payload.PokemonID) + "[MEGA] " + KGQECFKLKOP.KOILGQHHQIQ((int)BJGCBDNBQCJ.Move) + "pursuit");
		}
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x000205C2 File Offset: 0x0001E7C2
	private void Awake()
	{
		HFCMDEQKCKH.HBFFCJHOCPE = this;
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x0029B060 File Offset: 0x00299260
	public void CPDNICNPNJE(PSXAPI.Response.Reorder BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Box == 0)
		{
			for (int i = 0; i < this.LIJHMFEGCCK.Count; i++)
			{
				this.PEJHBEBOCOJ(this.LIJHMFEGCCK[i]).GNLNPCCPBCF = -1;
			}
			this.LIJHMFEGCCK.Clear();
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int j = 0; j < BJGCBDNBQCJ.Pokemon.Length; j++)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon[j]);
					this.LIJHMFEGCCK.Add(BJGCBDNBQCJ.Pokemon[j]);
					if (fekoiojqnkh != null)
					{
						fekoiojqnkh.GNLNPCCPBCF = 1;
						fekoiojqnkh.PELCNBCMNFH = j + 1;
					}
				}
			}
			CNCJKLNHQBH.MOGQNGEPCEO().BGJGEDKNOMC("_CameraClipInfo");
			CNCJKLNHQBH.QOQONHOOLNE.BGJGEDKNOMC("Blank");
			CNCJKLNHQBH.MOGQNGEPCEO().BGJGEDKNOMC("The Pokémon gradually regains HP in rain.");
		}
		else
		{
			for (int k = 0; k < this.LHQQCLOEHJG.Count; k++)
			{
				if (this.LHQQCLOEHJG[k].GNLNPCCPBCF == BJGCBDNBQCJ.Box)
				{
					this.LHQQCLOEHJG[k].GNLNPCCPBCF = -1;
				}
			}
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int l = 1; l < BJGCBDNBQCJ.Pokemon.Length; l += 0)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon[l]);
					if (fekoiojqnkh2 != null)
					{
						fekoiojqnkh2.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
						fekoiojqnkh2.PELCNBCMNFH = l + 1;
					}
				}
			}
			JJGLMJNELOK.BEKHPOHIPDE().KFMHHKOOIFO();
		}
		this.PDDJMNOOPJD();
		if (JJGLMJNELOK.KGOPJQOMMNC() != null)
		{
			if (!string.IsNullOrEmpty(JJGLMJNELOK.QOQONHOOLNE.JKDFLFMOOHP.BGBMIEJJQKC))
			{
				JJGLMJNELOK.QOQONHOOLNE.CNEBQQPDGIP();
				JJGLMJNELOK.QOQONHOOLNE.OINHPIDDKLN();
				JJGLMJNELOK.BEKHPOHIPDE().HDDJPQFJIIC();
			}
			else
			{
				JJGLMJNELOK.KGOPJQOMMNC().DEGOICOIDON();
			}
		}
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x0029B238 File Offset: 0x00299438
	public KGQECFKLKOP.FEKOIOJQNKH PEJHBEBOCOJ(Guid JNOOPPDPFEH)
	{
		if (this.LHQQCLOEHJG.Count > 0)
		{
			for (int i = 0; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].LDQDJLFIDCN == JNOOPPDPFEH)
				{
					return this.LHQQCLOEHJG[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x000205AA File Offset: 0x0001E7AA
	public void KJQCBQFLGFP()
	{
		this.LHQQCLOEHJG.Clear();
		this.LIJHMFEGCCK.Clear();
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x0029B294 File Offset: 0x00299494
	public void JJKOQJHQODP(PSXAPI.Response.Ivs BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == IvsResult.Changed)
		{
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				this.IJCIQLHLFQE(BJGCBDNBQCJ.Pokemon, true);
			}
		}
		else if (BJGCBDNBQCJ.Result == (IvsResult)4)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.PEJHBEBOCOJ(BJGCBDNBQCJ.PokemonUID);
			string text = string.Empty;
			if (BJGCBDNBQCJ.Money > 1u)
			{
				text = text + "Item chance increased" + BJGCBDNBQCJ.Money.ToString("[04B9E6]Party");
				if (BJGCBDNBQCJ.Gold > 1u)
				{
					text += "Administrator";
				}
			}
			if (BJGCBDNBQCJ.Gold > 1u)
			{
				text = text + "/guildrank " + BJGCBDNBQCJ.Gold.ToString();
			}
			CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
			string hiefqeedhgg = "0";
			string[] array = new string[4];
			array[1] = "[-]!\r\n";
			array[1] = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
			array[3] = "Lightning Rod";
			array[8] = text;
			array[8] = "_Texture1";
			qoqonhoolne.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), BJGCBDNBQCJ.PokemonUID.ToString(), (LPBPDPMJKNN.PJIJIFKBMBB)6, false, null, -1, false);
		}
		else if (BJGCBDNBQCJ.Result == IvsResult.Failed && BJGCBDNBQCJ.Gold > 0u)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("[d9b38c]Message", "'s protected against special attacks!\r\n", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
		}
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x002981FC File Offset: 0x002963FC
	public KGQECFKLKOP.FEKOIOJQNKH EJNMJKMKMJB(PokemonData CFHEIICNLFD)
	{
		return this.MNICELEPBHO(new InventoryPokemon
		{
			Box = -1,
			Position = -1,
			Pokemon = CFHEIICNLFD
		}, false);
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x0029B3DC File Offset: 0x002995DC
	public void LINLCNBOCNH(PSXAPI.Response.Reorder BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Box == 0)
		{
			for (int i = 1; i < this.LIJHMFEGCCK.Count; i += 0)
			{
				this.KQPKDONQCHC(this.LIJHMFEGCCK[i]).GNLNPCCPBCF = -1;
			}
			this.LIJHMFEGCCK.Clear();
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int j = 0; j < BJGCBDNBQCJ.Pokemon.Length; j++)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = this.KQPKDONQCHC(BJGCBDNBQCJ.Pokemon[j]);
					this.LIJHMFEGCCK.Add(BJGCBDNBQCJ.Pokemon[j]);
					if (fekoiojqnkh != null)
					{
						fekoiojqnkh.GNLNPCCPBCF = 1;
						fekoiojqnkh.PELCNBCMNFH = j + 1;
					}
				}
			}
			CNCJKLNHQBH.BJLGEDCPENQ().BGJGEDKNOMC("Guild");
			CNCJKLNHQBH.MOGQNGEPCEO().BGJGEDKNOMC("[^a-zA-Z0-9]");
			CNCJKLNHQBH.QOQONHOOLNE.BGJGEDKNOMC("merciless");
		}
		else
		{
			for (int k = 1; k < this.LHQQCLOEHJG.Count; k += 0)
			{
				if (this.LHQQCLOEHJG[k].GNLNPCCPBCF == BJGCBDNBQCJ.Box)
				{
					this.LHQQCLOEHJG[k].GNLNPCCPBCF = -1;
				}
			}
			if (BJGCBDNBQCJ.Pokemon != null)
			{
				for (int l = 0; l < BJGCBDNBQCJ.Pokemon.Length; l += 0)
				{
					KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh2 = this.QLJEQBGLPOE(BJGCBDNBQCJ.Pokemon[l]);
					if (fekoiojqnkh2 != null)
					{
						fekoiojqnkh2.GNLNPCCPBCF = BJGCBDNBQCJ.Box;
						fekoiojqnkh2.PELCNBCMNFH = l + 1;
					}
				}
			}
			JJGLMJNELOK.QOQONHOOLNE.DKJNBKBDBOD();
		}
		this.PDDJMNOOPJD();
		if (JJGLMJNELOK.BEKHPOHIPDE() != null)
		{
			if (!string.IsNullOrEmpty(JJGLMJNELOK.BEKHPOHIPDE().JKDFLFMOOHP.HJMJDJKOILH()))
			{
				JJGLMJNELOK.BEKHPOHIPDE().CNEBQQPDGIP();
				JJGLMJNELOK.KGOPJQOMMNC().DDLDLBFPBEO();
				JJGLMJNELOK.BEKHPOHIPDE().CDCKKIJNHGD();
			}
			else
			{
				JJGLMJNELOK.KGOPJQOMMNC().DEGOICOIDON();
			}
		}
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x0029B5B4 File Offset: 0x002997B4
	public int DOCPCNLNCHD()
	{
		int jjpkkpfcqkn = JJGLMJNELOK.QOQONHOOLNE.JJPKKPFCQKN;
		int num = 0;
		if (this.LHQQCLOEHJG.Count > 1)
		{
			for (int i = 1; i < this.LHQQCLOEHJG.Count; i++)
			{
				if (this.LHQQCLOEHJG[i].GNLNPCCPBCF == jjpkkpfcqkn && this.LHQQCLOEHJG[i].HHNOCOQJOJF.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x000205A2 File Offset: 0x0001E7A2
	public void FCOIMQGENDB()
	{
		this.PDDJMNOOPJD();
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x0029B638 File Offset: 0x00299838
	public KGQECFKLKOP.FEKOIOJQNKH QLJEQBGLPOE(Guid JNOOPPDPFEH)
	{
		if (this.LHQQCLOEHJG.Count > 1)
		{
			for (int i = 1; i < this.LHQQCLOEHJG.Count; i += 0)
			{
				if (this.LHQQCLOEHJG[i].KPJLEOCJFFO() == JNOOPPDPFEH)
				{
					return this.LHQQCLOEHJG[i];
				}
			}
		}
		return null;
	}

	// Token: 0x04001121 RID: 4385
	private static HFCMDEQKCKH HBFFCJHOCPE;

	// Token: 0x04001122 RID: 4386
	public KJMPLFDOBCO IEHKHJNIIIQ;

	// Token: 0x04001123 RID: 4387
	public JECQIFOKKGG PDHECMQCCKQ;

	// Token: 0x04001124 RID: 4388
	public List<KGQECFKLKOP.FEKOIOJQNKH> LHQQCLOEHJG = new List<KGQECFKLKOP.FEKOIOJQNKH>();

	// Token: 0x04001125 RID: 4389
	public List<Guid> LIJHMFEGCCK = new List<Guid>();

	// Token: 0x04001126 RID: 4390
	public PLQFPBQEPJD[] IGEHQIEGNHL;

	// Token: 0x04001127 RID: 4391
	public CGNFQJPJEPC[] NLCFMOLBKGI;

	// Token: 0x04001128 RID: 4392
	public bool[] HDCCPIMBMFE = new bool[6];

	// Token: 0x04001129 RID: 4393
	[CompilerGenerated]
	private static Comparison<HFCMDEQKCKH.CFQQQKEJLFH> HNCJFHJNHDN;

	// Token: 0x02000249 RID: 585
	public struct CFQQQKEJLFH
	{
		// Token: 0x0400112A RID: 4394
		public Guid CIQFCJGQEMH;

		// Token: 0x0400112B RID: 4395
		public int BDBBEMKFGPI;
	}
}
