using System;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200013C RID: 316
public class BNJJIOHLOIC : MonoBehaviour
{
	// Token: 0x06002543 RID: 9539 RVA: 0x000F0CAC File Offset: 0x000EEEAC
	public void DOEGKLDPQKB(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)6)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "[-]!\r\n";
			this.OKFNHJPFIGB += "A deluge of ions showers the battlefield!\r\n";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "_BlurDepth";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "Player Fly Mount";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += " stronger against physical moves!\r\n";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Powers up each Pokémon's Dark-type moves.";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "[";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "Heavy Ball";
			this.OKFNHJPFIGB += "flowerveil";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "[FF0000]-";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "!\r\n";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "Disabled";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Fly Cooldown";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "[ATK]";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "\n";
			}
			else
			{
				this.OKFNHJPFIGB = "wideguard";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("1" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x00013883 File Offset: 0x00011A83
	private void LHLLPPOQQIO()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.BBCBOIFQDBK().HKJIHGKDKLM(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000F0F68 File Offset: 0x000EF168
	public void JMDOHOLHGBN(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)8)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "Move Learning";
			this.OKFNHJPFIGB += "Relic Badge";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "\r\nPP ";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "_ChromaticAberration_Amount";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "The sandstorm subsided.";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "[FFFF00]";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += ")\n";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "Beast Boost";
			this.OKFNHJPFIGB += "´";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "-mega";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "Player/Hair_";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "Open";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "You can not afford to learn [FF9900]";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "defog";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "ability";
			}
			else
			{
				this.OKFNHJPFIGB = "door_2";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("[FF8F00]" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000138A7 File Offset: 0x00011AA7
	private void DBMBOONLPIL()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.BBCBOIFQDBK().Open(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000138DE File Offset: 0x00011ADE
	private void POENFFOGPPP(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.Hide();
		}
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x000138F5 File Offset: 0x00011AF5
	private void PBHJNDNOHPB(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.DHJEEJGJCGE();
		}
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x0001390C File Offset: 0x00011B0C
	private void QLBLDNGQDQE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.Hide();
		}
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x00013923 File Offset: 0x00011B23
	private void GKIFHEBPOKB(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JNDKHLFCEEB(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.LLIKMPBFNLK();
		}
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x0001393A File Offset: 0x00011B3A
	private void OnClick()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.Open(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x0001395E File Offset: 0x00011B5E
	private void KKELLJLGPCO()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.IDOKIIOQJOD(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x00013982 File Offset: 0x00011B82
	private void MHBNNCGMNHH()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.OGNMNFNOKDJ(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000F1224 File Offset: 0x000EF424
	public void LQFDMHPELCJ(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)7)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "][-][";
			this.OKFNHJPFIGB += " shrouded itself with Magic Coat!\r\n";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "But it failed! ";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "HidePanel";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "[FF8F00]";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "!\r\n";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Fresnel";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "Heals status conditions if it's raining.";
			this.OKFNHJPFIGB += "'s Pokebox is full.";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "error";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "[FF8F00]";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "[PD]";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += ".";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "trickroom";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "/01_";
			}
			else
			{
				this.OKFNHJPFIGB = "encore";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("slp" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000F14E0 File Offset: 0x000EF6E0
	public void MIEHJOOLEHC(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)5)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + " will cost\n";
			this.OKFNHJPFIGB += "Encounter Rate Lowered 50% in Hail\nTriggers: [2ecc71]Snow Cloak[-]";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "Failed to use '";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "berserk";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += ")";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "_Direction";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "OnNavigate";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "-primal";
			this.OKFNHJPFIGB += "hypercutter";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += " finally got its act together!\r\n";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "snatch";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += " and ";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "s";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "_VolumetricFog_OpaqueFrame";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "Powers up the Pokémon's weaker moves.";
			}
			else
			{
				this.OKFNHJPFIGB = "#,##0";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("cheekpouch" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x0001390C File Offset: 0x00011B0C
	private void GMGBQECJGFK(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.Hide();
		}
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000139A6 File Offset: 0x00011BA6
	private void MQJBDIJQQEP()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.KEHHJHKPKBE().IDOKIIOQJOD(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000139CA File Offset: 0x00011BCA
	private void FJECHOHDBOG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.EBGMENEODCD();
		}
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x000139E1 File Offset: 0x00011BE1
	private void JFKJOLEKQNF(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.LLIKMPBFNLK();
		}
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x000F179C File Offset: 0x000EF99C
	public void HOFCKQELDLF(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == PokedexEntryState.Caught)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "Inflicts damage to the attacker on contact with iron barbs.";
			this.OKFNHJPFIGB += "-core";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "[-]!\r\n";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "´";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "general";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "_FogPointLightPosition4";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "WATER_SIMPLE";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.None)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "[00FF00]You received [PD]";
			this.OKFNHJPFIGB += "door_5";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "normal";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "superluck";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "/";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Open";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "(A)";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "Surf";
			}
			else
			{
				this.OKFNHJPFIGB = "flyLimit";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("receiver" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000138DE File Offset: 0x00011ADE
	private void IFGPPIQKOPM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.Hide();
		}
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x000F1A58 File Offset: 0x000EFC58
	public void DEPHJMJBIPE(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)5)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "/";
			this.OKFNHJPFIGB += "[-]!\r\n";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "d";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "'s Ability was suppressed!\r\n";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "#,##0";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Busted";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "1";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "r";
			this.OKFNHJPFIGB += " on a parent object in order to work";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "Blank";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += " hrs, ";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "!\r\n";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "[{";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Windowed";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "gravity";
			}
			else
			{
				this.OKFNHJPFIGB = "2";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("_VolumetricFogSunWorldPos" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000139F8 File Offset: 0x00011BF8
	private void CIODIICODLO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JEDHBMEEGEB(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.DHJEEJGJCGE();
		}
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000F1D14 File Offset: 0x000EFF14
	public void BQLIIQIIMDH(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == PokedexEntryState.Caught)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "\n\n";
			this.OKFNHJPFIGB += "[33CCFF][Time of Day][-]";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "\nMorning";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "\nDay";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "\nEvening";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "\nEvening";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "\nNight";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "\n\n";
			this.OKFNHJPFIGB += "[33CCFF][Time of Day][-]";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "\nMorning";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "\nDay";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "\nEvening";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "\nEvening";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "\nNight";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "\n[33CCFF][Fishing Only][-]";
			}
			else
			{
				this.OKFNHJPFIGB = "[33CCFF][Fishing Only]";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x000138DE File Offset: 0x00011ADE
	private void HPKHMHMLQFM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.Hide();
		}
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x00013A0F File Offset: 0x00011C0F
	private void DMLGQQILHQO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.EBGMENEODCD();
		}
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x000F1FD0 File Offset: 0x000F01D0
	public void EJJBDNMPFIM(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == PokedexEntryState.Caught)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "!\r\n";
			this.OKFNHJPFIGB += "The hail stopped.";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "BuffIcon_Synchronize";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "bind";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "[pok=";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Base Power: ";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "wrap";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "_Chunk";
			this.OKFNHJPFIGB += "FOG_EXP";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "'s from critical hits!\r\n";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "Already in Guild";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "Close";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "DontScale";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "The sticky web has disappeared from the ground around ";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "i";
			}
			else
			{
				this.OKFNHJPFIGB = "_HairTex";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("[-]!\r\n" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000F228C File Offset: 0x000F048C
	public void LCCQBMMFONQ(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)8)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + " grew drowsy!\r\n";
			this.OKFNHJPFIGB += "5";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "A sandstorm kicked up!";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "angerpoint";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "   ";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += " started!\r\n";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += " Members Online.";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "waterpledge";
			this.OKFNHJPFIGB += "miniorcore";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "_SSRMultiplier";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "mega";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "2";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "0";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "_History2Weight";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(false);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "Misty Surge";
			}
			else
			{
				this.OKFNHJPFIGB = "_TempRT2";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("0" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x00013A26 File Offset: 0x00011C26
	private void IPEFEBPPLBM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.HNMHKIJEDIE();
		}
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000138F5 File Offset: 0x00011AF5
	private void PGMGCOPEGND(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.DHJEEJGJCGE();
		}
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x00013A3D File Offset: 0x00011C3D
	private void PBEBBBJCOMC()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.KEHHJHKPKBE().Open(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x0001395E File Offset: 0x00011B5E
	private void PQEFNPPCKOH()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.IDOKIIOQJOD(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x00013A61 File Offset: 0x00011C61
	private void DFBNIOEIFDD()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.NHFQKBOMHGE(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x00013A85 File Offset: 0x00011C85
	private void HMIILGLLNQM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OKFNHJPFIGB);
		}
		else
		{
			GGGPJQEKNJD.FPGOEMCDQJC();
		}
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000F2548 File Offset: 0x000F0748
	public void FDEDICFQNEJ(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)4)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "#,##0";
			this.OKFNHJPFIGB += "refrigerate";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "[FF9900]";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "Premultiplied";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "General";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += ")";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "waterpledge";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.None)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "x";
			this.OKFNHJPFIGB += "'s [ffff00]";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "CombinersArgsAlphaOp2";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "DITHERING";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "24";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "|";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "[^0-9.-]";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "Invite to Party";
			}
			else
			{
				this.OKFNHJPFIGB = "[FFFFFF]";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("Battle_Wild" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x0001395E File Offset: 0x00011B5E
	private void CGOHHFENQJC()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.QOQONHOOLNE.IDOKIIOQJOD(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000138A7 File Offset: 0x00011AA7
	private void JMLMNQIHQBJ()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.BBCBOIFQDBK().Open(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x00013A9C File Offset: 0x00011C9C
	private void QINFLJQBCIK()
	{
		if (this.IHFGQHCKOFK.Pokedex != PokedexEntryState.None)
		{
			EIDBQCPLPIL.BBCBOIFQDBK().NHFQKBOMHGE(this.IHFGQHCKOFK.PokemonID);
		}
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000F2804 File Offset: 0x000F0A04
	public void LBGCODKNHHP(AreaPokemon CFHEIICNLFD)
	{
		this.OKFNHJPFIGB = string.Empty;
		this.IHFGQHCKOFK = CFHEIICNLFD;
		if (CFHEIICNLFD.Pokedex == (PokedexEntryState)8)
		{
			this.PBJLDINGODP.SetActive(false);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "_Texture1";
			this.OKFNHJPFIGB += "[epic]";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += " was blocked by the kicked-up mat!\r\n";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "A swamp enveloped ";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "][";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "It started to rain!";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "Open";
			}
		}
		else if (CFHEIICNLFD.Pokedex == PokedexEntryState.Seen)
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(true);
			this.OKFNHJPFIGB = KGQECFKLKOP.NNHFLHEQMOI(CFHEIICNLFD.PokemonID) + "/03_";
			this.OKFNHJPFIGB += "snowman";
			if (CFHEIICNLFD.Morning)
			{
				this.OKFNHJPFIGB += "Battle Request";
			}
			if (CFHEIICNLFD.Day)
			{
				this.OKFNHJPFIGB += "#,##0";
			}
			if (CFHEIICNLFD.Evening)
			{
				this.OKFNHJPFIGB += "G";
			}
			if (!CFHEIICNLFD.Evening && CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "battlebag";
			}
			if (CFHEIICNLFD.Night)
			{
				this.OKFNHJPFIGB += "rotomheat";
			}
		}
		else
		{
			this.PBJLDINGODP.SetActive(true);
			this.NGHNKQHLQBB.SetActive(true);
			this.QEPKKJKQMPP.SetActive(false);
		}
		if (CFHEIICNLFD.Fishing)
		{
			if (this.OKFNHJPFIGB != string.Empty)
			{
				this.OKFNHJPFIGB += "Camera Window";
			}
			else
			{
				this.OKFNHJPFIGB = "2";
			}
		}
		this.HHKNGKFJGHB.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI(" restored HP using its [ffff00]" + CFHEIICNLFD.PokemonID.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x04000803 RID: 2051
	private AreaPokemon IHFGQHCKOFK;

	// Token: 0x04000804 RID: 2052
	public JLMPBLMOICG HHKNGKFJGHB;

	// Token: 0x04000805 RID: 2053
	public GameObject NGHNKQHLQBB;

	// Token: 0x04000806 RID: 2054
	public GameObject PBJLDINGODP;

	// Token: 0x04000807 RID: 2055
	public GameObject QEPKKJKQMPP;

	// Token: 0x04000808 RID: 2056
	private string OKFNHJPFIGB = string.Empty;
}
