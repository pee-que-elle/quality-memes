using System;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000287 RID: 647
public class HDQHPMCPDNJ : MonoBehaviour
{
	// Token: 0x06005A10 RID: 23056 RVA: 0x000233A7 File Offset: 0x000215A7
	private void EPGFPKPJNHF()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x000233A7 File Offset: 0x000215A7
	private void GLLCQQCCGOG()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x002E4BA8 File Offset: 0x002E2DA8
	private void OODKHHIPKFC()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(true);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(944f, 1652f, 971f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06005A13 RID: 23059 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ QOQONHOOLNE
	{
		get
		{
			return HDQHPMCPDNJ.HBFFCJHOCPE;
		}
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x000233B6 File Offset: 0x000215B6
	public void GENGDIFCHHP()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.BIKJFGMFFGN(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
		}
		else
		{
			this.PMKPPJFBOEF();
		}
	}

	// Token: 0x06005A15 RID: 23061 RVA: 0x002E4C18 File Offset: 0x002E2E18
	public void QMOQCMCMJDJ(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("Premultiplied");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1627f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A16 RID: 23062 RVA: 0x002E4CB4 File Offset: 0x002E2EB4
	public void CQKHMMFGMEE(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(true);
		if (JMDLLJPEFKM.Result == (StatsResult)4)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Numeric Boundaries", JMDLLJPEFKM.Username + "flowerveil", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, 68, false);
			this.COCMLEHBDNF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.PMKPPJFBOEF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(false);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.BPFQEKCPJDI();
			component2.KFFHOBQFHFN();
			component.HDDJIDGKKFK();
			component2.HQQDJHEEJHP();
			component2.BFDGBMNGBKH("12.5 17\n14 17\n14 20\n7 20\n\n7 8\n7 5\n2 5\n2 2\n13 2\n13 5\n10 5\n10 8");
			component2.BFDGBMNGBKH("protect");
			component2.LHQECHHMOGD("Rails Trigger");
			component2.LHQECHHMOGD("Leader");
			component2.BFDGBMNGBKH("blinky");
			component2.LHQECHHMOGD("firepledge");
			component2.LHQECHHMOGD("The Pokémon uses its moves without making contact with the target.");
			component2.BFDGBMNGBKH("OnClientDisconnect");
			component2.LHQECHHMOGD("inactive");
			component2.LHQECHHMOGD("-singlemove");
			component2.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("Camera Window");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.LHQECHHMOGD(string.Empty);
			component.LHQECHHMOGD(this.DPGBJPLKMBD(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 1; i < JMDLLJPEFKM.LevelRegions.Length; i += 0)
				{
					component2.BFDGBMNGBKH(this.DPGBJPLKMBD(JMDLLJPEFKM.LevelRegions[i]) + "By floating in the air, the Pokémon receives full immunity to all Ground-type moves.");
					component.LHQECHHMOGD(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.BFDGBMNGBKH(string.Empty);
			component2.LHQECHHMOGD("The Pokémon's intensely focused, and that protects the Pokémon from flinching.");
			component2.LHQECHHMOGD("EventDelegate");
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "\n\n" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)7)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("CombinersArgsAlphaOp1" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "22" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(false);
			this.IEICJDEDICD.LKPOBCBOFIC(NOHEMGHONKK.HGEKKNEPOHK().MQFBIMJJOLM());
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.LBGCODKNHHP(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == StatsResult.Self)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.KFFHOBQFHFN();
			component4.JENBHJDBLEE();
			component3.JMNEKDGHIIF();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD("ProCamera2DShakeContainer");
			component4.BFDGBMNGBKH("2");
			component4.BFDGBMNGBKH("firepledge");
			component4.LHQECHHMOGD(" fell for the taunt!\r\n");
			component4.LHQECHHMOGD("WATER_REFLECTIVE");
			component4.BFDGBMNGBKH("0");
			component4.BFDGBMNGBKH("]");
			component4.BFDGBMNGBKH("friendr");
			component4.LHQECHHMOGD("physical");
			component4.BFDGBMNGBKH("The harsh sunlight faded.");
			component4.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD("u");
			component3.BFDGBMNGBKH(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.BFDGBMNGBKH(string.Empty);
			component3.BFDGBMNGBKH(this.IGIKLGJNQNF(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 0; j < JMDLLJPEFKM.LevelRegions.Length; j += 0)
				{
					component4.BFDGBMNGBKH(this.HODGFQDGELN(JMDLLJPEFKM.LevelRegions[j]) + "Agility increases armor");
					component3.LHQECHHMOGD(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.LHQECHHMOGD(string.Empty);
			component3.BFDGBMNGBKH(string.Empty);
			component4.BFDGBMNGBKH("Once per battle, the shroud that covers the Pokémon can protect it from an attack.");
			component4.LHQECHHMOGD("-mega-x");
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			this.HOMHCPEKQJC.EEOOPJNPMPJ(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "Trigger Shape" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)4)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("," + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)6)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("/01_1" + JMDLLJPEFKM.Username);
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.LKPOBCBOFIC(JMDLLJPEFKM.GuildName);
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.IOCCGFNLFOB(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = "map:";
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 1; k < -27; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(true);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 0; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 0 >= 0 && JMDLLJPEFKM.Badges[l] - 0 < 79)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 1].SetActive(true);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(false);
		this.HCQINBCDGNO = true;
		this.FLIJFKHDPQB.gameObject.SetActive(false);
	}

	// Token: 0x06005A17 RID: 23063 RVA: 0x000233ED File Offset: 0x000215ED
	private void MKPKMKFQNQH()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005A18 RID: 23064 RVA: 0x002E55D0 File Offset: 0x002E37D0
	public void MHOCLMIDEMN()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.QOQONHOOLNE.GCENODFBOJJ
		}, true);
	}

	// Token: 0x06005A19 RID: 23065 RVA: 0x000233A7 File Offset: 0x000215A7
	private void QOGBNEJFCFJ()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A1A RID: 23066 RVA: 0x002E5610 File Offset: 0x002E3810
	public void NQMKOFBMNBK(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = false;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("Connector is configured to disallow IPv6 but an IPv6 Address was retured by DNS!");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1565f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A1B RID: 23067 RVA: 0x00023400 File Offset: 0x00021600
	public void CEKNGBKBLBE()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.BKFMDECNHCQ(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.PMKPPJFBOEF();
		}
	}

	// Token: 0x06005A1C RID: 23068 RVA: 0x00023437 File Offset: 0x00021637
	public void DOBCMHICENN()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.HQCNPOPPIQL(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.OHMHQEFOILI();
		}
	}

	// Token: 0x06005A1D RID: 23069 RVA: 0x002E56AC File Offset: 0x002E38AC
	public void KMONECNJHOH(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = false;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("Moxie");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1824f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A1E RID: 23070 RVA: 0x0002346E File Offset: 0x0002166E
	private void QIMJGHODLNE()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A1F RID: 23071 RVA: 0x002E5748 File Offset: 0x002E3948
	public void QKPHHEBFCOD()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.QOQONHOOLNE.GCENODFBOJJ
		}, false);
	}

	// Token: 0x06005A20 RID: 23072 RVA: 0x002E5788 File Offset: 0x002E3988
	public string MKOEEQPIFPP(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 0:
			return "confusion";
		case 1:
			return "Maximizes the number of times multi-strike moves hit.";
		case 2:
			return " has chosen to run.";
		case 3:
			return "[MEGA] ";
		case 4:
			return "raindance";
		case 5:
			return "_Amount";
		case 6:
			return "Invite to Party";
		default:
			return "][/itm]";
		}
	}

	// Token: 0x06005A21 RID: 23073 RVA: 0x002E57E8 File Offset: 0x002E39E8
	public string HODGFQDGELN(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 0:
			return "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GUQ6ZWT36PWEC&custom=";
		case 1:
			return "Cascade Badge";
		case 2:
			return "Email Address already in use";
		case 3:
			return "Oozed liquid has strong stench, which damages attackers using any draining move.";
		case 4:
			return "_Density";
		case 5:
			return "You are trying to catch fish!";
		case 6:
			return "user: ";
		default:
			return "Dig";
		}
	}

	// Token: 0x06005A22 RID: 23074 RVA: 0x002E5848 File Offset: 0x002E3A48
	public void MLJNDHPOINO(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(false);
		if (JMDLLJPEFKM.Result == (StatsResult)5)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Contact with the Pokémon may cause infatuation.", JMDLLJPEFKM.Username + "0", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, 123, false);
			this.COCMLEHBDNF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.PMKPPJFBOEF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Self)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(false);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.FBFCKBGLGBL();
			component2.KFFHOBQFHFN();
			component.HQQDJHEEJHP();
			component2.HQQDJHEEJHP();
			component2.LHQECHHMOGD("By putting pressure on the opposing Pokémon, it raises their PP usage.");
			component2.BFDGBMNGBKH("[o]");
			component2.LHQECHHMOGD("[33CCFF][Time of Day][-]");
			component2.BFDGBMNGBKH(" ");
			component2.LHQECHHMOGD("Battle Update: ");
			component2.BFDGBMNGBKH("replace");
			component2.BFDGBMNGBKH("-at");
			component2.LHQECHHMOGD(" from using certain moves!\r\n");
			component2.LHQECHHMOGD("Icon_Pokemon_Alive");
			component2.BFDGBMNGBKH(" fell in love!\r\n");
			component2.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("battlebag");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.BFDGBMNGBKH(string.Empty);
			component.BFDGBMNGBKH(this.HODGFQDGELN(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 1; i < JMDLLJPEFKM.LevelRegions.Length; i += 0)
				{
					component2.LHQECHHMOGD(this.EOENNPMHDBJ(JMDLLJPEFKM.LevelRegions[i]) + "[/URN]");
					component.BFDGBMNGBKH(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.LHQECHHMOGD(string.Empty);
			component2.BFDGBMNGBKH("qTrack");
			component2.LHQECHHMOGD(" transformed!\r\n");
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("Password is too short" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)7)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = " has no shader setter" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "rotom" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(true);
			this.IEICJDEDICD.PIDLOFMIEFQ = NOHEMGHONKK.QBNCFLKLLKC().MQFBIMJJOLM();
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.MIEHJOOLEHC(CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == (StatsResult)6)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.JENBHJDBLEE();
			component4.FBFCKBGLGBL();
			component3.JMNEKDGHIIF();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD("#,##0");
			component4.BFDGBMNGBKH("General");
			component4.BFDGBMNGBKH("_CurrentMipLevel");
			component4.LHQECHHMOGD("flying");
			component4.BFDGBMNGBKH("[-]");
			component4.LHQECHHMOGD("Encounter Rate Decreased (Sandstorm)");
			component4.LHQECHHMOGD("\n");
			component4.LHQECHHMOGD("300");
			component4.BFDGBMNGBKH("Emergency Exit");
			component4.BFDGBMNGBKH("_Saturation");
			component4.BFDGBMNGBKH(string.Empty);
			component4.LHQECHHMOGD("It's a one-hit KO!\r\n");
			component3.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.LHQECHHMOGD(string.Empty);
			component3.BFDGBMNGBKH(this.HODGFQDGELN(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 1; j < JMDLLJPEFKM.LevelRegions.Length; j += 0)
				{
					component4.BFDGBMNGBKH(this.EOENNPMHDBJ(JMDLLJPEFKM.LevelRegions[j]) + "J19");
					component3.LHQECHHMOGD(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.BFDGBMNGBKH("You sense the presence of many!\r\n");
			component4.LHQECHHMOGD("Score: ");
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.HDNLCNIHJBM(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "BuffIcon_EncounterRateIncrease" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)7)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("status: " + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)5)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("Icon_Status_Paralyzed" + JMDLLJPEFKM.Username);
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.HGEKKNEPOHK().QEHBPIBLFQJ(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.LKPOBCBOFIC("You do not have enough Pokédollars to purchase these items.");
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 1; k < -61; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(true);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 1; l < JMDLLJPEFKM.Badges.Length; l += 0)
			{
				if (JMDLLJPEFKM.Badges[l] - 0 >= 0 && JMDLLJPEFKM.Badges[l] - 1 < -23)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 1].SetActive(true);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(false);
		this.HCQINBCDGNO = false;
		this.FLIJFKHDPQB.gameObject.SetActive(true);
	}

	// Token: 0x06005A23 RID: 23075 RVA: 0x0002346E File Offset: 0x0002166E
	private void ENHIOPHNJQH()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A24 RID: 23076 RVA: 0x002E6164 File Offset: 0x002E4364
	public void QQCFLBMGNFG(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(false);
		if (JMDLLJPEFKM.Result == (StatsResult)6)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("/", JMDLLJPEFKM.Username + "-", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, 55, true);
			this.Close();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.PMKPPJFBOEF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(true);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.CPLBKPNNHJG();
			component2.KFFHOBQFHFN();
			component.HQQDJHEEJHP();
			component2.HQQDJHEEJHP();
			component2.LHQECHHMOGD("[00EE07]");
			component2.LHQECHHMOGD("[/pok]");
			component2.BFDGBMNGBKH("Mummy");
			component2.LHQECHHMOGD("qdTrack");
			component2.LHQECHHMOGD("deltastream");
			component2.LHQECHHMOGD("Female");
			component2.LHQECHHMOGD("There's no relief from this heavy rain!\r\n");
			component2.LHQECHHMOGD("][/pok] ");
			component2.BFDGBMNGBKH("Blank");
			component2.BFDGBMNGBKH("healbell");
			component2.LHQECHHMOGD(string.Empty);
			component2.BFDGBMNGBKH("waterpledge");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.BFDGBMNGBKH(string.Empty);
			component.BFDGBMNGBKH(this.HODGFQDGELN(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 0; i < JMDLLJPEFKM.LevelRegions.Length; i++)
				{
					component2.BFDGBMNGBKH(this.IGIKLGJNQNF(JMDLLJPEFKM.LevelRegions[i]) + "Chat Box - PMChat");
					component.BFDGBMNGBKH(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.");
			component2.LHQECHHMOGD("ghost");
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("/" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)4)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("Flower Gift" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)8)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "snake(" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(true);
			this.IEICJDEDICD.PIDLOFMIEFQ = NOHEMGHONKK.QOQONHOOLNE.LCIFOODLMLE();
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.HGEKKNEPOHK().KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.NPBOJJOKEME(CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == (StatsResult)4)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.BPFQEKCPJDI();
			component4.FBFCKBGLGBL();
			component3.HQQDJHEEJHP();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD("BuffIcon_Surf");
			component4.BFDGBMNGBKH("_LogLut");
			component4.BFDGBMNGBKH("_LayerThickness");
			component4.BFDGBMNGBKH("rotomfan");
			component4.LHQECHHMOGD("_TileVRT");
			component4.BFDGBMNGBKH("Hustle");
			component4.LHQECHHMOGD("_DestortionShiftY");
			component4.LHQECHHMOGD("The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield.");
			component4.LHQECHHMOGD("_FogOfWarCenterAdjusted");
			component4.BFDGBMNGBKH("Dark Aura");
			component4.BFDGBMNGBKH(string.Empty);
			component4.BFDGBMNGBKH("_Dissolve");
			component3.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.BFDGBMNGBKH(string.Empty);
			component3.BFDGBMNGBKH(this.HODGFQDGELN(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 0; j < JMDLLJPEFKM.LevelRegions.Length; j += 0)
				{
					component4.BFDGBMNGBKH(this.IGIKLGJNQNF(JMDLLJPEFKM.LevelRegions[j]) + "LJMOLEKDCLP");
					component3.BFDGBMNGBKH(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD("sandforce");
			component4.BFDGBMNGBKH("CombinersColor");
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.PMDQEIBJJQK(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "CombinersColorCombine" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("[00FF00]+" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "stealthrock" + JMDLLJPEFKM.Username;
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QBNCFLKLLKC().CILNDLMBNHI(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.LKPOBCBOFIC("\n[PG]");
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 1; k < -99; k += 0)
		{
			this.DFMLMCDHNCM[k].SetActive(false);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 1; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 1 >= 1 && JMDLLJPEFKM.Badges[l] - 0 < -50)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 0].SetActive(false);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(true);
		this.HCQINBCDGNO = true;
		this.FLIJFKHDPQB.gameObject.SetActive(true);
	}

	// Token: 0x06005A25 RID: 23077 RVA: 0x000233A7 File Offset: 0x000215A7
	private void PNJGKKPBDEB()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A26 RID: 23078 RVA: 0x002E6A80 File Offset: 0x002E4C80
	public string OBIHHJPOKNC(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 1:
			return "P";
		case 2:
			return "Music";
		case 3:
			return "Sweet Scent";
		case 4:
			return "50% more chance to encounter a Electric-type Pokémon.\nTriggers: [2ecc71]Static[-]";
		case 5:
			return "electricterrain";
		case 6:
			return " started!\r\n";
		case 7:
			return "None";
		default:
			return "'s electromagnetism wore off!\r\n";
		}
	}

	// Token: 0x06005A27 RID: 23079 RVA: 0x002E6AE0 File Offset: 0x002E4CE0
	public void ILPEJPEFIHI(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(false);
		if (JMDLLJPEFKM.Result == StatsResult.Private)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Player Information", JMDLLJPEFKM.Username + " has their Player Information set to private.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, 15, false);
			this.Close();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.Close();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Self)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(true);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.CPLBKPNNHJG();
			component2.CPLBKPNNHJG();
			component.JMNEKDGHIIF();
			component2.JMNEKDGHIIF();
			component2.LHQECHHMOGD("Play Time:");
			component2.LHQECHHMOGD("Steps Taken:");
			component2.LHQECHHMOGD("Times Fainted:");
			component2.LHQECHHMOGD("Pokémon Caught:");
			component2.LHQECHHMOGD("Level Ups:");
			component2.LHQECHHMOGD("Wild Encounters:");
			component2.LHQECHHMOGD("Poké Balls Thrown:");
			component2.LHQECHHMOGD("Pokédex Seen:");
			component2.LHQECHHMOGD("Pokédex Caught:");
			component2.LHQECHHMOGD("Achievement Points:");
			component2.LHQECHHMOGD(string.Empty);
			component2.LHQECHHMOGD("Current Region:");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.LHQECHHMOGD(string.Empty);
			component.LHQECHHMOGD(this.FKDJMGCNJGK(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 0; i < JMDLLJPEFKM.LevelRegions.Length; i++)
				{
					component2.LHQECHHMOGD(this.FKDJMGCNJGK(JMDLLJPEFKM.LevelRegions[i]) + " Lvl:");
					component.LHQECHHMOGD(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.LHQECHHMOGD(string.Empty);
			component2.LHQECHHMOGD("PvP Wins:");
			component2.LHQECHHMOGD("PvP Losses:");
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[ff4949]" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[ffb649]" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Moderator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[7fff49]" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(true);
			this.IEICJDEDICD.PIDLOFMIEFQ = NOHEMGHONKK.QOQONHOOLNE.DFMCFGLQLNL();
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.BQLIIQIIMDH(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == StatsResult.User)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.CPLBKPNNHJG();
			component4.CPLBKPNNHJG();
			component3.JMNEKDGHIIF();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD("Play Time:");
			component4.LHQECHHMOGD("Steps Taken:");
			component4.LHQECHHMOGD("Times Fainted:");
			component4.LHQECHHMOGD("Pokémon Caught:");
			component4.LHQECHHMOGD("Level Ups:");
			component4.LHQECHHMOGD("Wild Encounters:");
			component4.LHQECHHMOGD("Poké Balls Thrown:");
			component4.LHQECHHMOGD("Pokédex Seen:");
			component4.LHQECHHMOGD("Pokédex Caught:");
			component4.LHQECHHMOGD("Achievement Points:");
			component4.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD("Current Region:");
			component3.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.LHQECHHMOGD(string.Empty);
			component3.LHQECHHMOGD(this.FKDJMGCNJGK(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 0; j < JMDLLJPEFKM.LevelRegions.Length; j++)
				{
					component4.LHQECHHMOGD(this.FKDJMGCNJGK(JMDLLJPEFKM.LevelRegions[j]) + " Lvl:");
					component3.LHQECHHMOGD(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.LHQECHHMOGD(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD("PvP Wins:");
			component4.LHQECHHMOGD("PvP Losses:");
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.BQLIIQIIMDH(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[ff4949]" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[ffb649]" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Moderator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "[7fff49]" + JMDLLJPEFKM.Username;
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.CLHBLLFPJMN(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = "-";
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 0; k < 16; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(false);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 0; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 1 >= 0 && JMDLLJPEFKM.Badges[l] - 1 < 16)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 1].SetActive(true);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(true);
		this.HCQINBCDGNO = false;
		this.FLIJFKHDPQB.gameObject.SetActive(false);
	}

	// Token: 0x06005A28 RID: 23080 RVA: 0x00023481 File Offset: 0x00021681
	public void FQQJEEPKFPL()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.KMONECNJHOH(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
		}
		else
		{
			this.OHMHQEFOILI();
		}
	}

	// Token: 0x06005A29 RID: 23081 RVA: 0x002E73FC File Offset: 0x002E55FC
	public void PFIGIEQMKFD(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("Glacier Badge");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1348f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A2A RID: 23082 RVA: 0x000233A7 File Offset: 0x000215A7
	private void CHKQIFFEEPL()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A2B RID: 23083 RVA: 0x000233A7 File Offset: 0x000215A7
	private void OEEPBOFIEQF()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A2C RID: 23084 RVA: 0x0002346E File Offset: 0x0002166E
	private void HKBLPHHFDNK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A2D RID: 23085 RVA: 0x002E7498 File Offset: 0x002E5698
	private void QIHJCOLPLBQ()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(false);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(447f, 1125f, 456f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x06005A2E RID: 23086 RVA: 0x000233ED File Offset: 0x000215ED
	private void KPGCODGIMKK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005A2F RID: 23087 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ OPJBMJFKIIJ()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A31 RID: 23089 RVA: 0x002E7508 File Offset: 0x002E5708
	public void HKHMGHFJPMO(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke(".");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 782f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A32 RID: 23090 RVA: 0x002E75A4 File Offset: 0x002E57A4
	public void BKFMDECNHCQ(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke("CombinersUpAlphaBuff");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1117f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A33 RID: 23091 RVA: 0x000233A7 File Offset: 0x000215A7
	private void LIPJCQHLQCQ()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A34 RID: 23092 RVA: 0x0002346E File Offset: 0x0002166E
	private void GOBJGGCQMIG()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A35 RID: 23093 RVA: 0x002E7640 File Offset: 0x002E5840
	public void PHEINOBKNMJ(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(false);
		if (JMDLLJPEFKM.Result == StatsResult.Private)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("allAdjacent", JMDLLJPEFKM.Username + "-cureteam", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, 34, false);
			this.Close();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.KHEGOJMIHQG();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(true);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.CPLBKPNNHJG();
			component2.CPLBKPNNHJG();
			component.JMNEKDGHIIF();
			component2.HDDJIDGKKFK();
			component2.LHQECHHMOGD("[BATTLE]");
			component2.BFDGBMNGBKH("0");
			component2.BFDGBMNGBKH("Remove Camera Target");
			component2.BFDGBMNGBKH("Base Power: ");
			component2.LHQECHHMOGD("Blank");
			component2.BFDGBMNGBKH("perish2");
			component2.BFDGBMNGBKH("K7");
			component2.BFDGBMNGBKH("-enditem");
			component2.BFDGBMNGBKH("focusband");
			component2.BFDGBMNGBKH("cant");
			component2.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("physical");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.BFDGBMNGBKH(string.Empty);
			component.BFDGBMNGBKH(this.DPGBJPLKMBD(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 0; i < JMDLLJPEFKM.LevelRegions.Length; i += 0)
				{
					component2.BFDGBMNGBKH(this.OBIHHJPOKNC(JMDLLJPEFKM.LevelRegions[i]) + "spectator");
					component.BFDGBMNGBKH(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("Chat Input");
			component2.BFDGBMNGBKH("#,##0");
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.LHQECHHMOGD((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "´" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "/force up" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)8)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("[-] after the taunt!\r\n" + JMDLLJPEFKM.Username);
			}
			this.GCENODFBOJJ.SetActive(false);
			this.IEICJDEDICD.LKPOBCBOFIC(NOHEMGHONKK.QBNCFLKLLKC().DFMCFGLQLNL());
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QBNCFLKLLKC().KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.FQFIFPGJDBE(CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == (StatsResult)6)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.JENBHJDBLEE();
			component4.BPFQEKCPJDI();
			component3.HDDJIDGKKFK();
			component4.JMNEKDGHIIF();
			component4.BFDGBMNGBKH("speedswap");
			component4.BFDGBMNGBKH("ReflecR");
			component4.BFDGBMNGBKH("Reset EVs");
			component4.BFDGBMNGBKH("unboost");
			component4.BFDGBMNGBKH("guild");
			component4.LHQECHHMOGD("Horizontal");
			component4.LHQECHHMOGD("ResolutionY");
			component4.LHQECHHMOGD("freeze");
			component4.LHQECHHMOGD(" EXP[-]");
			component4.BFDGBMNGBKH("_MainTex");
			component4.BFDGBMNGBKH(string.Empty);
			component4.LHQECHHMOGD(" shuddered!\r\n");
			component3.BFDGBMNGBKH(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.BFDGBMNGBKH(string.Empty);
			component3.BFDGBMNGBKH(this.DPGBJPLKMBD(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 1; j < JMDLLJPEFKM.LevelRegions.Length; j++)
				{
					component4.BFDGBMNGBKH(this.MKOEEQPIFPP(JMDLLJPEFKM.LevelRegions[j]) + "Attempting to add a callback to a list that's null");
					component3.BFDGBMNGBKH(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.LHQECHHMOGD(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.BFDGBMNGBKH("rocksmash");
			component4.LHQECHHMOGD("Are you sure you wish to confirm your EV changes on [2ecc71]");
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.LQFDMHPELCJ(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("partingshot" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)4)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("_DestortionY" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "_FogOfWarCenterAdjusted" + JMDLLJPEFKM.Username;
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.CLHBLLFPJMN(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = "[00EE07]";
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 0; k < -75; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(false);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 1; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 1 >= 1 && JMDLLJPEFKM.Badges[l] - 1 < -72)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 0].SetActive(false);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(true);
		this.HCQINBCDGNO = true;
		this.FLIJFKHDPQB.gameObject.SetActive(false);
	}

	// Token: 0x06005A36 RID: 23094 RVA: 0x002E7F5C File Offset: 0x002E615C
	public string IGIKLGJNQNF(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 1:
			return " snatched ";
		case 2:
			return "Health prolongs life";
		case 3:
			return "_AllowBackwardsRays";
		case 4:
			return "14.5 17\n14 17\n14 20\n7 20\n\n7 26\n7 30\n2 30\n2 26";
		case 5:
			return "'s ";
		case 6:
			return "General";
		case 7:
			return "20";
		default:
			return "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.";
		}
	}

	// Token: 0x06005A37 RID: 23095 RVA: 0x002E55D0 File Offset: 0x002E37D0
	public void MGENKFEFJCN()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.QOQONHOOLNE.GCENODFBOJJ
		}, true);
	}

	// Token: 0x06005A38 RID: 23096 RVA: 0x000233A7 File Offset: 0x000215A7
	private void NPEJDHMIFDJ()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A39 RID: 23097 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ GDDGJKOLGIQ()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A3A RID: 23098 RVA: 0x002E7FBC File Offset: 0x002E61BC
	public void BOLKDCKIJNE()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.QOQONHOOLNE.GCENODFBOJJ
		}, false);
	}

	// Token: 0x06005A3B RID: 23099 RVA: 0x000234C7 File Offset: 0x000216C7
	public void PMKPPJFBOEF()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("FOG_VOID_BOX", 1114f);
	}

	// Token: 0x06005A3C RID: 23100 RVA: 0x002E7FFC File Offset: 0x002E61FC
	public void QPJDLDFNNPJ(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, true);
		}
		this.HCQINBCDGNO = false;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("Changes the Pokémon's type to the type of the move it's about to use.");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1638f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x002E5748 File Offset: 0x002E3948
	public void TogglePrivacy()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.QOQONHOOLNE.GCENODFBOJJ
		}, false);
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x000234F0 File Offset: 0x000216F0
	public void PPFCJHKEFOK()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.NQMKOFBMNBK(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
		}
		else
		{
			this.PMKPPJFBOEF();
		}
	}

	// Token: 0x06005A3F RID: 23103 RVA: 0x002E8098 File Offset: 0x002E6298
	public void HQCNPOPPIQL(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, true);
		}
		this.HCQINBCDGNO = false;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("_Power");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 218f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A40 RID: 23104 RVA: 0x002E8134 File Offset: 0x002E6334
	public void BIKJFGMFFGN(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, true);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke("Spammy chat text of some sorts afh9uaf 9uahf 9afu as9u fa9s ");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 951f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A41 RID: 23105 RVA: 0x002E81D0 File Offset: 0x002E63D0
	public void IDOKIIOQJOD(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("_NeutralTonemapperParams2");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 347f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A42 RID: 23106 RVA: 0x00023527 File Offset: 0x00021727
	public void OHMHQEFOILI()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("After your payment has been verified your Lootboxes will be added to your account.", 1518f);
	}

	// Token: 0x06005A43 RID: 23107 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ OCEJPCQLMHK()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A44 RID: 23108 RVA: 0x0002346E File Offset: 0x0002166E
	private void DEIMDFDLCLK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A45 RID: 23109 RVA: 0x002E826C File Offset: 0x002E646C
	public void GNBBGFDFMEC(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(true);
		if (JMDLLJPEFKM.Result == (StatsResult)4)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF(" is frozen solid!\r\n", JMDLLJPEFKM.Username + " x ", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -119, false);
			this.CHMCLOQIOLN();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.OHMHQEFOILI();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(false);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.CPLBKPNNHJG();
			component2.CPLBKPNNHJG();
			component.HQQDJHEEJHP();
			component2.JMNEKDGHIIF();
			component2.LHQECHHMOGD("_Bottom");
			component2.LHQECHHMOGD(" mins");
			component2.LHQECHHMOGD("Shader not found ({0})");
			component2.LHQECHHMOGD("[-] after the taunt!\r\n");
			component2.LHQECHHMOGD("^emote+");
			component2.BFDGBMNGBKH("leechseed");
			component2.LHQECHHMOGD("Iron Barbs");
			component2.BFDGBMNGBKH("Guild Request");
			component2.LHQECHHMOGD("_Female");
			component2.BFDGBMNGBKH("status: ");
			component2.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("Battle Update: ");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.BFDGBMNGBKH(string.Empty);
			component.LHQECHHMOGD(this.MKOEEQPIFPP(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 0; i < JMDLLJPEFKM.LevelRegions.Length; i += 0)
				{
					component2.BFDGBMNGBKH(this.OBIHHJPOKNC(JMDLLJPEFKM.LevelRegions[i]) + "Expected to have 'target' set to a valid transform");
					component.LHQECHHMOGD(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.BFDGBMNGBKH(string.Empty);
			component2.BFDGBMNGBKH("damp");
			component2.BFDGBMNGBKH("infestation");
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("adjacentAlly" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Moderator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "13" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "blinky" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(false);
			this.IEICJDEDICD.PIDLOFMIEFQ = NOHEMGHONKK.QOQONHOOLNE.DFMCFGLQLNL();
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.HGEKKNEPOHK().KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.FQFIFPGJDBE(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == (StatsResult)8)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.JENBHJDBLEE();
			component4.KFFHOBQFHFN();
			component3.HDDJIDGKKFK();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD("000");
			component4.BFDGBMNGBKH("!\r\n");
			component4.BFDGBMNGBKH("aa");
			component4.LHQECHHMOGD("CombinersAlphaCombine");
			component4.LHQECHHMOGD("_Texture1");
			component4.LHQECHHMOGD("ghost");
			component4.BFDGBMNGBKH(" already has a substitute!\r\n");
			component4.LHQECHHMOGD("Fly");
			component4.LHQECHHMOGD("'s attack continues!\r\n");
			component4.LHQECHHMOGD("]");
			component4.BFDGBMNGBKH(string.Empty);
			component4.BFDGBMNGBKH("17");
			component3.BFDGBMNGBKH(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(this.MKOEEQPIFPP(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 0; j < JMDLLJPEFKM.LevelRegions.Length; j += 0)
				{
					component4.BFDGBMNGBKH(this.IGIKLGJNQNF(JMDLLJPEFKM.LevelRegions[j]) + "VFMDepthCamera");
					component3.BFDGBMNGBKH(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD("struggle");
			component4.BFDGBMNGBKH("move: ");
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.EDKDPDKIBJN(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC(JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "Attempting to add a callback to a list that's null" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "deltastream" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)8)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "(Back)" + JMDLLJPEFKM.Username;
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.HGEKKNEPOHK().ELDCDCOLJJE(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = "'s moves have been electrified!\r\n";
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 1; k < 29; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(true);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 1; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 0 >= 1 && JMDLLJPEFKM.Badges[l] - 0 < 124)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 0].SetActive(false);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(false);
		this.HCQINBCDGNO = true;
		this.FLIJFKHDPQB.gameObject.SetActive(false);
	}

	// Token: 0x06005A46 RID: 23110 RVA: 0x00023550 File Offset: 0x00021750
	public void COCMLEHBDNF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("3d", 955f);
	}

	// Token: 0x06005A47 RID: 23111 RVA: 0x00023579 File Offset: 0x00021779
	public void NMMLPCLBJMF()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.BKFMDECNHCQ(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		}
		else
		{
			this.OHMHQEFOILI();
		}
	}

	// Token: 0x06005A48 RID: 23112 RVA: 0x002E8B88 File Offset: 0x002E6D88
	public string DPGBJPLKMBD(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 1:
			return "COLOR_GRADING";
		case 2:
			return "map";
		case 3:
			return "16";
		case 4:
			return "-";
		case 5:
			return "'s [ffff00]";
		case 6:
			return "_Texture1";
		case 7:
			return "Too many vertices on one panel: ";
		default:
			return "berry_3";
		}
	}

	// Token: 0x06005A49 RID: 23113 RVA: 0x000233ED File Offset: 0x000215ED
	private void LBJODECEJML()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005A4A RID: 23114 RVA: 0x002E8BE8 File Offset: 0x002E6DE8
	public void NQEOMELHLCI(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), true);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(true);
		base.CancelInvoke("flashfire");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 646f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A4B RID: 23115 RVA: 0x000235B0 File Offset: 0x000217B0
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06005A4C RID: 23116 RVA: 0x000233A7 File Offset: 0x000215A7
	private void Awake()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A4D RID: 23117 RVA: 0x000233A7 File Offset: 0x000215A7
	private void OJQHKOJJNCP()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A4E RID: 23118 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ NKFQOEQFFQH()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x002E8C84 File Offset: 0x002E6E84
	public void IFCKQIOKIBN()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			Private = this.BMKDPKDDBDK.value,
			ShowAsOffline = CKMLKNPNPQO.INJDHLQHFFD().GCENODFBOJJ
		}, true);
	}

	// Token: 0x06005A50 RID: 23120 RVA: 0x002E8CC4 File Offset: 0x002E6EC4
	private void GKBQDQKLPIM()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(true);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(1562f, 224f, 121f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x06005A51 RID: 23121 RVA: 0x002E8D34 File Offset: 0x002E6F34
	public void Open(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, false);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A52 RID: 23122 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ ELBNNCEGBDH()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A53 RID: 23123 RVA: 0x000235E7 File Offset: 0x000217E7
	public void KMMJIGFQJOB()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IDOKIIOQJOD(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		}
		else
		{
			this.KHEGOJMIHQG();
		}
	}

	// Token: 0x06005A54 RID: 23124 RVA: 0x0002361E File Offset: 0x0002181E
	public void NPIPKHQOKBF()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.PFIGIEQMKFD(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		}
		else
		{
			this.PMKPPJFBOEF();
		}
	}

	// Token: 0x06005A55 RID: 23125 RVA: 0x00023655 File Offset: 0x00021855
	public void KHEGOJMIHQG()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("p1", 82f);
	}

	// Token: 0x06005A56 RID: 23126 RVA: 0x002E8DD0 File Offset: 0x002E6FD0
	public string EOENNPMHDBJ(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 1:
			return "[blue]";
		case 2:
			return "Congratulations!";
		case 3:
			return "Daily Reset\n";
		case 4:
			return "static";
		case 5:
			return "MSGBOX - Move Learning";
		case 6:
			return "rated";
		case 7:
			return "\r\nPP ";
		default:
			return "Corrosion";
		}
	}

	// Token: 0x06005A57 RID: 23127 RVA: 0x002E8E30 File Offset: 0x002E7030
	public void IKDLNHLPQHB(PSXAPI.Response.Stats JMDLLJPEFKM)
	{
		this.BMKDPKDDBDK.gameObject.SetActive(true);
		if (JMDLLJPEFKM.Result == (StatsResult)4)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Blank", JMDLLJPEFKM.Username + "[MEGA] ", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, 103, true);
			this.COCMLEHBDNF();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.OHMHQEFOILI();
			return;
		}
		if (JMDLLJPEFKM.Result == StatsResult.Error)
		{
			this.BMKDPKDDBDK.gameObject.SetActive(true);
			BMLIGLPMMLG component = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component2 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component.JENBHJDBLEE();
			component2.BPFQEKCPJDI();
			component.HDDJIDGKKFK();
			component2.JMNEKDGHIIF();
			component2.LHQECHHMOGD("\r\n");
			component2.BFDGBMNGBKH(" was frozen solid!\r\n");
			component2.BFDGBMNGBKH("VolumetricFogAndMist/Blur");
			component2.BFDGBMNGBKH("trickroom");
			component2.LHQECHHMOGD("beatup");
			component2.LHQECHHMOGD("|");
			component2.LHQECHHMOGD("Alt+");
			component2.LHQECHHMOGD("[ffff00]");
			component2.BFDGBMNGBKH("Boosts the accuracy of its allies and itself.");
			component2.BFDGBMNGBKH("The effects of Water Sport have faded.\r\n");
			component2.LHQECHHMOGD(string.Empty);
			component2.LHQECHHMOGD("8");
			component.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component.LHQECHHMOGD(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component.BFDGBMNGBKH(string.Empty);
			component.BFDGBMNGBKH(this.EOENNPMHDBJ(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int i = 1; i < JMDLLJPEFKM.LevelRegions.Length; i++)
				{
					component2.BFDGBMNGBKH(this.EOENNPMHDBJ(JMDLLJPEFKM.LevelRegions[i]) + "quash");
					component.BFDGBMNGBKH(JMDLLJPEFKM.Levels[i].ToString());
				}
			}
			component2.LHQECHHMOGD(string.Empty);
			component.LHQECHHMOGD(string.Empty);
			component2.LHQECHHMOGD("mega");
			component2.LHQECHHMOGD("battler");
			component.BFDGBMNGBKH(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			JMDLLJPEFKM.Username = KGQECFKLKOP.HFKHODPJQOJ();
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = " snatched " + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == (StaffRank)4)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("Materials/DFOOnlyFog" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "PrimitiveFront" + JMDLLJPEFKM.Username;
			}
			this.GCENODFBOJJ.SetActive(false);
			this.IEICJDEDICD.PIDLOFMIEFQ = NOHEMGHONKK.QOQONHOOLNE.MQFBIMJJOLM();
			this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.QOQONHOOLNE.KJQBFKQQKEO.GOIHJQNMMJD;
			this.HOMHCPEKQJC.ONNDNJHJNPI(CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ);
		}
		else if (JMDLLJPEFKM.Result == (StatsResult)4)
		{
			BMLIGLPMMLG component3 = this.ICLNEPCODIK.GetComponent<BMLIGLPMMLG>();
			BMLIGLPMMLG component4 = this.QNCBKMGOPJK.GetComponent<BMLIGLPMMLG>();
			component3.CPLBKPNNHJG();
			component4.CPLBKPNNHJG();
			component3.HQQDJHEEJHP();
			component4.JMNEKDGHIIF();
			component4.LHQECHHMOGD(" minutes ago");
			component4.BFDGBMNGBKH("_Histogram");
			component4.LHQECHHMOGD("The healing wish came true for ");
			component4.BFDGBMNGBKH("[00DD00]Owned");
			component4.LHQECHHMOGD("Email is invalid");
			component4.LHQECHHMOGD(" copied ");
			component4.LHQECHHMOGD("You do not have enough Pokédollars to purchase these items.");
			component4.LHQECHHMOGD("/");
			component4.BFDGBMNGBKH("Assets/AssetBundles/MapAssets/Models/Building_Radio_Tower_2/Materials/Single_Window.mat");
			component4.BFDGBMNGBKH("Assets/AssetBundles/MapAssets/Models/Materials/chip_mado.mat");
			component4.LHQECHHMOGD(string.Empty);
			component4.BFDGBMNGBKH("_VolumetricFogSunWorldPos");
			component3.LHQECHHMOGD(KGQECFKLKOP.HHCGODNQJOP(JMDLLJPEFKM.Data.TotalPlayTime));
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.StepsTaken.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TimesFainted.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.TotalPokemonCaught.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.TotalPokemonLevelUps.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.WildEncountered.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokeballsThrown.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexSeen.ToString());
			component3.BFDGBMNGBKH(JMDLLJPEFKM.Data.PokedexCaught.ToString());
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.AchievementPoints.ToString());
			component3.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(this.MKOEEQPIFPP(JMDLLJPEFKM.Region));
			if (JMDLLJPEFKM.LevelRegions != null)
			{
				for (int j = 0; j < JMDLLJPEFKM.LevelRegions.Length; j += 0)
				{
					component4.BFDGBMNGBKH(this.DPGBJPLKMBD(JMDLLJPEFKM.LevelRegions[j]) + "[NL]");
					component3.BFDGBMNGBKH(JMDLLJPEFKM.Levels[j].ToString());
				}
			}
			component4.BFDGBMNGBKH(string.Empty);
			component3.LHQECHHMOGD(string.Empty);
			component4.LHQECHHMOGD(" thanks to its [ffff00]Safety Goggles[-]!\r\n");
			component4.BFDGBMNGBKH("/[PG]");
			component3.LHQECHHMOGD(JMDLLJPEFKM.Data.PVPBattlesWon.ToString());
			component3.BFDGBMNGBKH((JMDLLJPEFKM.Data.PVPBattles - JMDLLJPEFKM.Data.PVPBattlesWon).ToString());
			if (JMDLLJPEFKM.Online)
			{
				this.GCENODFBOJJ.SetActive(true);
			}
			else
			{
				this.GCENODFBOJJ.SetActive(false);
			}
			this.HOMHCPEKQJC.COIMFDQIOKL(JMDLLJPEFKM.Style, JMDLLJPEFKM.Equip);
			if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.None)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "grasspelt" + JMDLLJPEFKM.Username;
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.GameModerator)
			{
				this.MBPHKDQMJJH.LKPOBCBOFIC("J13" + JMDLLJPEFKM.Username);
			}
			else if (JMDLLJPEFKM.StaffRank == StaffRank.Developer)
			{
				this.MBPHKDQMJJH.PIDLOFMIEFQ = "(" + JMDLLJPEFKM.Username;
			}
			if (JMDLLJPEFKM.GuildName != null && !(JMDLLJPEFKM.GuildName == string.Empty))
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = JMDLLJPEFKM.GuildName;
				this.KJQBFKQQKEO.GOIHJQNMMJD = NOHEMGHONKK.HGEKKNEPOHK().ELDCDCOLJJE(JMDLLJPEFKM.GuildName, (int)JMDLLJPEFKM.GuildEmblemId);
			}
			else
			{
				this.IEICJDEDICD.PIDLOFMIEFQ = "chlorophyll";
				this.KJQBFKQQKEO.GOIHJQNMMJD = null;
			}
		}
		for (int k = 0; k < -17; k++)
		{
			this.DFMLMCDHNCM[k].SetActive(true);
		}
		if (JMDLLJPEFKM.Badges != null)
		{
			for (int l = 0; l < JMDLLJPEFKM.Badges.Length; l++)
			{
				if (JMDLLJPEFKM.Badges[l] - 1 >= 0 && JMDLLJPEFKM.Badges[l] - 0 < -1)
				{
					this.DFMLMCDHNCM[JMDLLJPEFKM.Badges[l] - 1].SetActive(false);
				}
			}
		}
		this.IQDCDBCPBEN.SetActive(false);
		this.HCQINBCDGNO = true;
		this.FLIJFKHDPQB.gameObject.SetActive(true);
	}

	// Token: 0x06005A58 RID: 23128 RVA: 0x002E974C File Offset: 0x002E794C
	public string FKDJMGCNJGK(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 1:
			return "Kanto";
		case 2:
			return "Johto";
		case 3:
			return "Hoenn";
		case 4:
			return "Sinnoh";
		case 5:
			return "Unova";
		case 6:
			return "Kalos";
		case 7:
			return "Alola";
		default:
			return "Kanto";
		}
	}

	// Token: 0x06005A59 RID: 23129 RVA: 0x000233A7 File Offset: 0x000215A7
	private void CBLIFECCHIC()
	{
		HDQHPMCPDNJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005A5A RID: 23130 RVA: 0x0002346E File Offset: 0x0002166E
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005A5B RID: 23131 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ JPMOJGDNKNC()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x002E97AC File Offset: 0x002E79AC
	private void EHBDNIOCHNO()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(false);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(208f, 668f, 1968f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x06005A5D RID: 23133 RVA: 0x002E981C File Offset: 0x002E7A1C
	private void ELMIPBNHEGG()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(false);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(248f, 851f, 609f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x002E988C File Offset: 0x002E7A8C
	public string GNJMHMPOOGO(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 0:
			return "PlayDeadAnimation";
		case 1:
			return "'s [ffff00]";
		case 2:
			return "RGBA";
		case 3:
			return "Repeater";
		case 4:
			return "Enabled";
		case 5:
			return "!\r\n";
		case 6:
			return "Shell Armor";
		default:
			return "BuffIcon_EncounterRateIncrease";
		}
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x002E98EC File Offset: 0x002E7AEC
	public string IFCPKIOFHID(int BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ)
		{
		case 0:
			return "[MEGA] ";
		case 1:
			return "aromatherapy";
		case 2:
			return "bellydrum";
		case 3:
			return "guild";
		case 4:
			return "Reduces the power of supereffective attacks taken.";
		case 5:
			return " minute";
		case 6:
			return "-primal";
		default:
			return "Frost";
		}
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x002E994C File Offset: 0x002E7B4C
	private void Update()
	{
		if (this.HCQINBCDGNO)
		{
			if (!this.FLIJFKHDPQB.gameObject.activeSelf)
			{
				this.FLIJFKHDPQB.gameObject.SetActive(true);
			}
			this.FLIJFKHDPQB.transform.localEulerAngles += new Vector3(0f, 0f, -256f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x002E99BC File Offset: 0x002E7BBC
	public void KEBCGPFBFJL(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, true);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke("_Texture2");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1933f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x0002367E File Offset: 0x0002187E
	public void IMQPQIHKDQL()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IDOKIIOQJOD(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.OHMHQEFOILI();
		}
	}

	// Token: 0x06005A63 RID: 23139 RVA: 0x000233AF File Offset: 0x000215AF
	public static HDQHPMCPDNJ PFQBLOEPBJB()
	{
		return HDQHPMCPDNJ.HBFFCJHOCPE;
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x000233ED File Offset: 0x000215ED
	private void QOEMELPLOOG()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x000236B5 File Offset: 0x000218B5
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x000236DE File Offset: 0x000218DE
	public void FDQGJILMNLJ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.BJOKQEICJBQ(string.Empty);
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		}
		else
		{
			this.CHMCLOQIOLN();
		}
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x002E9A58 File Offset: 0x002E7C58
	public void BJOKQEICJBQ(string HHNBICLDQKI = "")
	{
		if (HHNBICLDQKI == string.Empty)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Stats(), false);
		}
		else
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Stats
			{
				Username = HHNBICLDQKI
			}, true);
		}
		this.HCQINBCDGNO = true;
		this.IQDCDBCPBEN.SetActive(false);
		base.CancelInvoke("[-]\r\nPP ");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 737f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005A68 RID: 23144 RVA: 0x00023715 File Offset: 0x00021915
	public void CHMCLOQIOLN()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("VFMDepthSunCamera", 1530f);
	}

	// Token: 0x0400137E RID: 4990
	private static HDQHPMCPDNJ HBFFCJHOCPE;

	// Token: 0x0400137F RID: 4991
	public JLMPBLMOICG FLIJFKHDPQB;

	// Token: 0x04001380 RID: 4992
	public GameObject IQDCDBCPBEN;

	// Token: 0x04001381 RID: 4993
	public BKKHLBCLPJM ICLNEPCODIK;

	// Token: 0x04001382 RID: 4994
	public BKKHLBCLPJM QNCBKMGOPJK;

	// Token: 0x04001383 RID: 4995
	public BKKHLBCLPJM MBPHKDQMJJH;

	// Token: 0x04001384 RID: 4996
	public BKKHLBCLPJM IEICJDEDICD;

	// Token: 0x04001385 RID: 4997
	public GameObject[] DFMLMCDHNCM;

	// Token: 0x04001386 RID: 4998
	public JLMPBLMOICG KJQBFKQQKEO;

	// Token: 0x04001387 RID: 4999
	public UIToggle BMKDPKDDBDK;

	// Token: 0x04001388 RID: 5000
	public MCMHEQDOMOI HOMHCPEKQJC;

	// Token: 0x04001389 RID: 5001
	public GameObject GCENODFBOJJ;

	// Token: 0x0400138A RID: 5002
	private bool HCQINBCDGNO = true;

	// Token: 0x0400138B RID: 5003
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x0400138C RID: 5004
	public KQHJOLQLQBJ QPPGQJFBPMH;
}
