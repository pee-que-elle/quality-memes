using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x02000220 RID: 544
public class MFKCMLKCEEM : MonoBehaviour
{
	// Token: 0x06004989 RID: 18825 RVA: 0x0001EC6C File Offset: 0x0001CE6C
	private void JQFIDNCKHMH(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x0001EC84 File Offset: 0x0001CE84
	private void LMQBHEGIIJE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x0001EC9C File Offset: 0x0001CE9C
	private void IFGPPIQKOPM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x0600498C RID: 18828 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
	private void QQHGCHDMMBC(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x0600498D RID: 18829 RVA: 0x00252208 File Offset: 0x00250408
	private void EHOMDICKDIN(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1584f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QQCNCIQQPIG().HKQNOMKNEFO() || CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("par");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.GBNQEKLJFCI()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "skinshop"))
					{
						if (!(pidlofmiefq == "[-] absorbs the attack!\r\n") && !(pidlofmiefq == "allAdjacent") && !(pidlofmiefq == "[delegate]"))
						{
							if (!(pidlofmiefq == "Mount"))
							{
								if (pidlofmiefq == "magmastorm")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.GDDGJKOLGIQ().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.BEILHFKFLEG()
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.MKMJKLDDNDD().QKIDLEKEGIE(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.FPQNIQELKMC().GLEBQIDOLKN.QPONNMLDLQD(this.FFJJCIQPLOP.KPJLEOCJFFO(), false, true, null, false);
					}
				}
			}
		}
	}

	// Token: 0x0600498E RID: 18830 RVA: 0x002523E4 File Offset: 0x002505E4
	public void QNJHMCKNJIK(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.Category == null)
		{
			QPGCBDPFIOF.EFJJPJGCQGE(string.Empty);
		}
		this.OQGNNFECDNJ = "It created a bizarre area in which Defense and Sp. Def stats are swapped!\r\n" + QPGCBDPFIOF.DFNQHDEDDKE() + "It created a bizarre area in which Defense and Sp. Def stats are swapped!\r\n" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Boosts move power when the Pokémon moves last.")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP(" swapped Abilities with its target!\r\n");
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "OnClick")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "HidePanel";
		}
		else
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH(".psx");
		}
		if (QPGCBDPFIOF.Type == null)
		{
			QPGCBDPFIOF.CFOMFKCIEQM("BuffIcon_Dig");
		}
		this.GPQPKPHIDIF.OGQLCMOFLLQ(QPGCBDPFIOF.Type.ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("The rain stopped." + HJKCFNJIPHG.ToString() + "4" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.Power = "Blank";
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("FOG_EXP2");
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("Mine Badge" + QPGCBDPFIOF.Power);
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == null)
		{
			QPGCBDPFIOF.QNIJMQQHLQN("Trade Error");
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC(")");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "_FogScatteringData" + QPGCBDPFIOF.QCBKIHIKPCG() + "psychicterrain";
		}
		if (QPGCBDPFIOF.IGLOGLEBNQO() == null)
		{
			QPGCBDPFIOF.LNPFBNNOFFF("_ReflectionTex");
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.IGLOGLEBNQO();
	}

	// Token: 0x0600498F RID: 18831 RVA: 0x0001ECCC File Offset: 0x0001CECC
	private void LGNKBDHHQFM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06004990 RID: 18832 RVA: 0x002525C4 File Offset: 0x002507C4
	public void LQFDMHPELCJ(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.KOBKHDHGJEK(string.Empty);
		}
		this.OQGNNFECDNJ = "_FogAlpha" + QPGCBDPFIOF.DFNQHDEDDKE() + "A bell chimed!\r\n" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "FOG_SCATTERING_ON")
		{
			this.BBKKHIDMQIQ.DPBGHDMHKNC("23");
		}
		else if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "Pokemon3D/Index")
		{
			this.BBKKHIDMQIQ.OGQLCMOFLLQ("OnPress");
		}
		else
		{
			this.BBKKHIDMQIQ.JLENFJGDNFN("_ScaleOffsetRes");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.Type = "clearbody";
		}
		this.GPQPKPHIDIF.KCLBMPFIPNQ = QPGCBDPFIOF.PDKNHHDCQOE().ToLowerInvariant();
		this.JCCEFPKQGEQ.LKPOBCBOFIC("Premultiplied" + HJKCFNJIPHG.ToString() + "User" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.CCMJNJQPJFC("BuffIcon_MuteIcon");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "_VolumetricFogSunShadowsData";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "System Message" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == null)
		{
			QPGCBDPFIOF.ACC = "BuffIcon_EncounterRateIncrease2";
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("Reflection");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "d" + QPGCBDPFIOF.QPGFMHBJPCE() + "ability: ";
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.Name = "Unlit/Transparent Colored";
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.DFNQHDEDDKE();
	}

	// Token: 0x06004991 RID: 18833 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
	private void ENDMIONFPKN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06004992 RID: 18834 RVA: 0x002527A4 File Offset: 0x002509A4
	private void QEJPDBIPHQH(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 870f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QOQONHOOLNE.DLNELFIPOHB() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.OQDOKBJNBBL().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("HideWinow");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.GBNQEKLJFCI()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == " on "))
					{
						if (!(pidlofmiefq == "Dig") && !(pidlofmiefq == "Blank") && !(pidlofmiefq == "Cap"))
						{
							if (!(pidlofmiefq == "[-]"))
							{
								if (pidlofmiefq == "PM: ")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().CLLPOCIJDHQ(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.CBBBCEMLMLP
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.GDDGJKOLGIQ().LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.MKBIQHGNJPO()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.IPOKOKIJECO().GLEBQIDOLKN.QPONNMLDLQD(this.FFJJCIQPLOP.KPJLEOCJFFO(), false, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x06004993 RID: 18835 RVA: 0x00252980 File Offset: 0x00250B80
	public void LGDBKJFOFOK(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.KOBKHDHGJEK(string.Empty);
		}
		this.OQGNNFECDNJ = "Big/" + QPGCBDPFIOF.Name + "Blank" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "_ClipTex")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("VolumetricFogAndMist/CopyOpaque");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "overcoat")
		{
			this.BBKKHIDMQIQ.OGQLCMOFLLQ(")\n");
		}
		else
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("Hidden/Post FX/Ambient Occlusion");
		}
		if (QPGCBDPFIOF.DBQIBEDQKCF() == null)
		{
			QPGCBDPFIOF.ONHEELGIEDJ("Username already in use");
		}
		this.GPQPKPHIDIF.LGJOOQIBQDC(QPGCBDPFIOF.PDKNHHDCQOE().ToLowerInvariant());
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "_MainTex" + HJKCFNJIPHG.ToString() + "[silent]" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.QLGLDDKOBBI("#,##0");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Call";
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("/mute " + QPGCBDPFIOF.FFFMCHDOOOI());
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.ACC = "Take 001";
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("ice");
		}
		else
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("Lure Ball" + QPGCBDPFIOF.QPGFMHBJPCE() + "[00FF00]+");
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.Name = " is already paralyzed.\r\n";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x06004994 RID: 18836 RVA: 0x0001EC9C File Offset: 0x0001CE9C
	private void OMIKGHLDCHL(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06004995 RID: 18837 RVA: 0x0001ECFC File Offset: 0x0001CEFC
	private void MEJLBHKMHEO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JEDHBMEEGEB(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06004996 RID: 18838 RVA: 0x00252B60 File Offset: 0x00250D60
	public void EGKMLKHJCDD(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.JNNLNMPHNCJ(string.Empty);
		}
		this.OQGNNFECDNJ = "!\r\n" + QPGCBDPFIOF.IGLOGLEBNQO() + "intimidate" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "Trade Request")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("airballoon");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "damp")
		{
			this.BBKKHIDMQIQ.JLENFJGDNFN("r");
		}
		else
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH("Guts");
		}
		if (QPGCBDPFIOF.Type == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("#,##0");
		}
		this.GPQPKPHIDIF.IQBBDKFDGGP(QPGCBDPFIOF.DBQIBEDQKCF().ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("'s status cleared!\r\n" + HJKCFNJIPHG.ToString() + "Battle" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.QLGLDDKOBBI("It broke through ");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "[00]";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Feather Badge" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.ACC = "_Female";
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "_SunColor";
		}
		else
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("OnPress" + QPGCBDPFIOF.ACC + "|");
		}
		if (QPGCBDPFIOF.IGLOGLEBNQO() == null)
		{
			QPGCBDPFIOF.Name = "More Likely Female Encounters";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x06004997 RID: 18839 RVA: 0x00252D40 File Offset: 0x00250F40
	private void OnPress(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() || CNCJKLNHQBH.QOQONHOOLNE.CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP || CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You can not use buffs during interactions.");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.LDQDJLFIDCN))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "Milk Drink"))
					{
						if (!(pidlofmiefq == "Teleport") && !(pidlofmiefq == "Dig") && !(pidlofmiefq == "Sweet Scent"))
						{
							if (!(pidlofmiefq == "Fly"))
							{
								if (pidlofmiefq == "Surf")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.CBBBCEMLMLP
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.QOQONHOOLNE.LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.CBBBCEMLMLP
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.LDQDJLFIDCN, true, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x06004998 RID: 18840 RVA: 0x00252F1C File Offset: 0x0025111C
	private void HHHNIOBHPEC(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 419f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.CNIMIQKQJJJ().KFFFKLBMGKD() || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.ODJQHLJCFGH().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("burmysandy");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.LDQDJLFIDCN))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "craftyshield"))
					{
						if (!(pidlofmiefq == "What Pokémon will hatch from this Egg? It doesn't seem close to hatching.") && !(pidlofmiefq == "/") && !(pidlofmiefq == "Fearow"))
						{
							if (!(pidlofmiefq == " already has a burn.\r\n"))
							{
								if (pidlofmiefq == "waterbubble")
								{
									CNCJKLNHQBH.BJLGEDCPENQ().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.QKIDLEKEGIE(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.CBBBCEMLMLP
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.BJLGEDCPENQ().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.IPOKOKIJECO().GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.GBNQEKLJFCI(), true, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x06004999 RID: 18841 RVA: 0x002530F8 File Offset: 0x002512F8
	public void BQLIIQIIMDH(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.Category == null)
		{
			QPGCBDPFIOF.Category = string.Empty;
		}
		this.OQGNNFECDNJ = "[u][33CCFF]" + QPGCBDPFIOF.Name + "[-][/u]\n" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "special")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "special";
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "physical")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "physical";
		}
		else
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "other";
		}
		if (QPGCBDPFIOF.Type == null)
		{
			QPGCBDPFIOF.Type = "normal";
		}
		this.GPQPKPHIDIF.KCLBMPFIPNQ = QPGCBDPFIOF.Type.ToLowerInvariant();
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "PP: " + HJKCFNJIPHG.ToString() + "/" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.Power = "-";
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Power: -";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Power: " + QPGCBDPFIOF.Power;
		}
		if (QPGCBDPFIOF.ACC == null)
		{
			QPGCBDPFIOF.ACC = "-";
		}
		if (QPGCBDPFIOF.ACC == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "ACC: -";
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "ACC: " + QPGCBDPFIOF.ACC + "%";
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.Name = "-";
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.Name;
	}

	// Token: 0x0600499A RID: 18842 RVA: 0x002532D8 File Offset: 0x002514D8
	private void MBMIQPPJMCD(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1665f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.CNIMIQKQJJJ().MGKFOIKFJDD() || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP || CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("psn");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.LDQDJLFIDCN))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "-start"))
					{
						if (!(pidlofmiefq == "_MainTex") && !(pidlofmiefq == "minior") && !(pidlofmiefq == " is in love with "))
						{
							if (!(pidlofmiefq == " [F]"))
							{
								if (pidlofmiefq == "HideQuestsPanel")
								{
									CNCJKLNHQBH.MOGQNGEPCEO().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.BEILHFKFLEG()
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.QOQONHOOLNE.GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.KPJLEOCJFFO(), false, false, null, true);
					}
				}
			}
		}
	}

	// Token: 0x0600499B RID: 18843 RVA: 0x002534B4 File Offset: 0x002516B4
	private void HGHEFJGMMKO(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 163f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QOQONHOOLNE.KFFFKLBMGKD() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.DQLDEKPLECH().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("'s Substitute blocked ");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.KGMFIOCJLEP()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == " on "))
					{
						if (!(pidlofmiefq == "QCGENKHJDDH") && !(pidlofmiefq == "Take 001") && !(pidlofmiefq == "[PG]"))
						{
							if (!(pidlofmiefq == "The weirdness disappeared from the battlefield!\r\n"))
							{
								if (pidlofmiefq == "Delta Stream")
								{
									CNCJKLNHQBH.BJLGEDCPENQ().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().CLLPOCIJDHQ(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.BHFBMKQGOFN()
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.BJLGEDCPENQ().MGJPFKOCGGC(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.IPOKOKIJECO().GLEBQIDOLKN.MIEHJOOLEHC(this.FFJJCIQPLOP.GBNQEKLJFCI(), true, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x0600499C RID: 18844 RVA: 0x0001ED14 File Offset: 0x0001CF14
	private void ELLKLNBLIKK(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x0600499D RID: 18845 RVA: 0x0001ED2C File Offset: 0x0001CF2C
	private void LFJKDJKKQJI(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x00253690 File Offset: 0x00251890
	private void MBFHPBDKMDC(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1381f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.JLLBKOOQKGO().PDOKGMLDIGL() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP || CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("Move Learning");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.KGMFIOCJLEP()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "Blank"))
					{
						if (!(pidlofmiefq == "[PG]") && !(pidlofmiefq == " is already poisoned.\r\n") && !(pidlofmiefq == "'s "))
						{
							if (!(pidlofmiefq == "23"))
							{
								if (pidlofmiefq == "Y")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.GDDGJKOLGIQ().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.BEILHFKFLEG()
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.QOQONHOOLNE.LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.DOGEBLQHDHI().GLEBQIDOLKN.QPONNMLDLQD(this.FFJJCIQPLOP.KGMFIOCJLEP(), false, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x0025386C File Offset: 0x00251A6C
	private void KJLLECIKMED(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 904f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QQCNCIQQPIG().OCFGFJMJIGP() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.GGBPGMMCGLI() != null || DBQLOHBBJMG.DQLDEKPLECH().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("F10");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.KPJLEOCJFFO()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "[-]!\r\n"))
					{
						if (!(pidlofmiefq == "map:") && !(pidlofmiefq == "Inactive") && !(pidlofmiefq == "MegaRayquaza"))
						{
							if (!(pidlofmiefq == "[NGUI] "))
							{
								if (pidlofmiefq == "[ATK]")
								{
									CNCJKLNHQBH.MOGQNGEPCEO().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.BEILHFKFLEG()
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.BJLGEDCPENQ().MGJPFKOCGGC(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.IPOKOKIJECO().GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.GBNQEKLJFCI(), false, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x060049A0 RID: 18848 RVA: 0x00253A48 File Offset: 0x00251C48
	private void NBFOMJEJOMJ(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 299f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.CNIMIQKQJJJ().EKEKMCMJEOC() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL("[");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.FCQMGQOEDLJ()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "[FFFFFF]"))
					{
						if (!(pidlofmiefq == "TONEMAPPING_NEUTRAL") && !(pidlofmiefq == "Snow") && !(pidlofmiefq == "/[delegate]"))
						{
							if (!(pidlofmiefq == "Big/"))
							{
								if (pidlofmiefq == "WATER_REFRACTIVE")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.QKIDLEKEGIE(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.BEILHFKFLEG()
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.GDDGJKOLGIQ().MGJPFKOCGGC(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.BFBEIJGQKHJ(this.FFJJCIQPLOP.LDQDJLFIDCN, true, true, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x0001ED44 File Offset: 0x0001CF44
	private void IDEECIPIBLG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x00253C24 File Offset: 0x00251E24
	public void HPGELNGEGPM(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.EFJJPJGCQGE(string.Empty);
		}
		this.OQGNNFECDNJ = "|" + QPGCBDPFIOF.Name + "[ff4949]" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "\n[ff66cc]SPD:[-] ")
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH(" AM");
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "Slots_3")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "0";
		}
		else
		{
			this.BBKKHIDMQIQ.DPBGHDMHKNC("frz");
		}
		if (QPGCBDPFIOF.OCCQGODQGPC() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("_Female");
		}
		this.GPQPKPHIDIF.LGJOOQIBQDC(QPGCBDPFIOF.DBQIBEDQKCF().ToLowerInvariant());
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "Up" + HJKCFNJIPHG.ToString() + "\n" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.IEQCNMOLIEK("_NeutralTonemapperParams1");
		}
		if (QPGCBDPFIOF.FFFMCHDOOOI() == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("synchronize");
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("Tangling Hair" + QPGCBDPFIOF.Power);
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == null)
		{
			QPGCBDPFIOF.GPJDOILOLDJ("[00AAFF]");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC(".");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "mimikyubusted" + QPGCBDPFIOF.ACC + ": ";
		}
		if (QPGCBDPFIOF.DFNQHDEDDKE() == null)
		{
			QPGCBDPFIOF.GHPFFIEQNJP("~");
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.Name;
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x00253E04 File Offset: 0x00252004
	private void DKKQFEPDLHB(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1331f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QOQONHOOLNE.MGKFOIKFJDD() || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.DQLDEKPLECH().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("´");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.KGMFIOCJLEP()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "_DestortionShiftX"))
					{
						if (!(pidlofmiefq == "Assets/AssetBundles/MapAssets/ModelPrefabs/") && !(pidlofmiefq == "#,##0") && !(pidlofmiefq == "[/pok]"))
						{
							if (!(pidlofmiefq == "LeftS"))
							{
								if (pidlofmiefq == "motordrive")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.CLLPOCIJDHQ(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.CBBBCEMLMLP
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.MKMJKLDDNDD().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.CFGIOIGOIFQ().GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.KPJLEOCJFFO(), false, false, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049A4 RID: 18852 RVA: 0x0001ED5C File Offset: 0x0001CF5C
	private void FNFNHOPFDQO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x060049A5 RID: 18853 RVA: 0x00253FE0 File Offset: 0x002521E0
	public void DEPHJMJBIPE(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.KOBKHDHGJEK(string.Empty);
		}
		this.OQGNNFECDNJ = "rebound" + QPGCBDPFIOF.IGLOGLEBNQO() + " sketched " + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "´")
		{
			this.BBKKHIDMQIQ.DPBGHDMHKNC("!\r\n");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Powers up special attacks when the Pokémon is burned.")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("][#");
		}
		else
		{
			this.BBKKHIDMQIQ.OGQLCMOFLLQ("OnClick");
		}
		if (QPGCBDPFIOF.Type == null)
		{
			QPGCBDPFIOF.CFOMFKCIEQM("_FogPointLightPosition1");
		}
		this.GPQPKPHIDIF.JOHBNEHCEJH(QPGCBDPFIOF.Type.ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC(" won't go any higher!\r\n" + HJKCFNJIPHG.ToString() + "BuffIcon_SweetScent" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.IEQCNMOLIEK("_1");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "[urn=";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = " began charging power!\r\n" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == null)
		{
			QPGCBDPFIOF.ACC = "Steadfast";
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("Muted");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "HidePanel" + QPGCBDPFIOF.QPGFMHBJPCE() + "14.5 17\n14 17\n14 20\n7 20\n\n7 26\n7 30\n2 30\n2 26";
		}
		if (QPGCBDPFIOF.IGLOGLEBNQO() == null)
		{
			QPGCBDPFIOF.Name = ".";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.Name);
	}

	// Token: 0x060049A6 RID: 18854 RVA: 0x002541C0 File Offset: 0x002523C0
	public void PEHHOQIHMKP(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.BDJHKDDDPKG(string.Empty);
		}
		this.OQGNNFECDNJ = "/" + QPGCBDPFIOF.Name + "mist" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "Shaders/EyeHistogram")
		{
			this.BBKKHIDMQIQ.LGJOOQIBQDC("#");
		}
		else if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "_FogVoidData")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "[/pok]";
		}
		else
		{
			this.BBKKHIDMQIQ.LGJOOQIBQDC("pressure");
		}
		if (QPGCBDPFIOF.DBQIBEDQKCF() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("QCGENKHJDDH");
		}
		this.GPQPKPHIDIF.KCLBMPFIPNQ = QPGCBDPFIOF.OCCQGODQGPC().ToLowerInvariant();
		this.JCCEFPKQGEQ.LKPOBCBOFIC("sheerforce" + HJKCFNJIPHG.ToString() + "SOURCE_GBUFFER" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.Power = "deltastream";
		}
		if (QPGCBDPFIOF.FFFMCHDOOOI() == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("[-]");
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("2|" + QPGCBDPFIOF.FFFMCHDOOOI());
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == null)
		{
			QPGCBDPFIOF.CBKHNMEHHHE("]");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "_SSRMultiplier";
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "berry_13" + QPGCBDPFIOF.BLLFNBKDCMJ() + "Premier Ball";
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.Name = "[-]";
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.DFNQHDEDDKE();
	}

	// Token: 0x060049A7 RID: 18855 RVA: 0x002543A0 File Offset: 0x002525A0
	private void IFCHONCBMGM(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1035f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QQCNCIQQPIG().HEFMIKCHCJF() || CNCJKLNHQBH.MOGQNGEPCEO().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.FFCOKMHBCQJ().QQQBDBNCMCP || CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(" took the attack!\r\n");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.FCQMGQOEDLJ()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "_ClipRange4"))
					{
						if (!(pidlofmiefq == "Own Tempo") && !(pidlofmiefq == "_Fade") && !(pidlofmiefq == "\""))
						{
							if (!(pidlofmiefq == "BattlePoke"))
							{
								if (pidlofmiefq == "spite")
								{
									CNCJKLNHQBH.MOGQNGEPCEO().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.BJLGEDCPENQ().CLLPOCIJDHQ(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.MKBIQHGNJPO()
									}, true);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.MKMJKLDDNDD().QKIDLEKEGIE(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.BHFBMKQGOFN()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.CFGIOIGOIFQ().GLEBQIDOLKN.QPONNMLDLQD(this.FFJJCIQPLOP.KPJLEOCJFFO(), true, false, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049A8 RID: 18856 RVA: 0x0025457C File Offset: 0x0025277C
	public void PLBJKOILHJN(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.Category = string.Empty;
		}
		this.OQGNNFECDNJ = " requires " + QPGCBDPFIOF.DFNQHDEDDKE() + "qTrack" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == " sprang up!\r\n")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("Password");
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "Big/")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("3");
		}
		else
		{
			this.BBKKHIDMQIQ.OGQLCMOFLLQ("[-] to evolve?");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("N0");
		}
		this.GPQPKPHIDIF.IQBBDKFDGGP(QPGCBDPFIOF.Type.ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("[ffff00]Quick Guard[-] protected " + HJKCFNJIPHG.ToString() + "Blank" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.OOLHFEEKNEQ("Friend Request");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("taunt");
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "innardsout" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.CBKHNMEHHHE("Hoenn");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("Fly");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "moldbreaker" + QPGCBDPFIOF.ACC + "/afk";
		}
		if (QPGCBDPFIOF.IGLOGLEBNQO() == null)
		{
			QPGCBDPFIOF.Name = "Battle Request";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x060049A9 RID: 18857 RVA: 0x0001ED74 File Offset: 0x0001CF74
	private void LDEINGNKILD(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x060049AA RID: 18858 RVA: 0x0025475C File Offset: 0x0025295C
	private void HMPCDDMJIQQ(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1521f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.JLLBKOOQKGO().OCFGFJMJIGP() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.IECKOKEPENM().QQQBDBNCMCP || CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("/kick ");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.LDQDJLFIDCN))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == " braced itself!\r\n"))
					{
						if (!(pidlofmiefq == "Would like to purchase another Pokébox?\nCost: ") && !(pidlofmiefq == "Light Metal") && !(pidlofmiefq == ")"))
						{
							if (!(pidlofmiefq == "Player/Hair"))
							{
								if (pidlofmiefq == "castform")
								{
									CNCJKLNHQBH.MOGQNGEPCEO().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.BJLGEDCPENQ().LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.MKBIQHGNJPO()
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.BJLGEDCPENQ().MGJPFKOCGGC(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.BQLIIQIIMDH(this.FFJJCIQPLOP.KGMFIOCJLEP(), true, true, null, true);
					}
				}
			}
		}
	}

	// Token: 0x060049AB RID: 18859 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
	private void GNHBPCPIMOP(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.HOICKEIJIHM(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x060049AC RID: 18860 RVA: 0x00254938 File Offset: 0x00252B38
	private void PQNKOHBGFOP(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1691f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.JLLBKOOQKGO().HEFMIKCHCJF() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.PDPCLOECLOF().QQQBDBNCMCP || CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("'s perish count fell to 0.\r\n");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.GBNQEKLJFCI()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "\nEvening"))
					{
						if (!(pidlofmiefq == "illusion") && !(pidlofmiefq == "ability") && !(pidlofmiefq == "par"))
						{
							if (!(pidlofmiefq == "[-]"))
							{
								if (pidlofmiefq == "[blue]")
								{
									CNCJKLNHQBH.QOQONHOOLNE.PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.BJLGEDCPENQ().CLLPOCIJDHQ(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
									{
										Action = EffectAction.Use,
										UID = nbfcpoplomf.CBBBCEMLMLP
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.GDDGJKOLGIQ().LJBHIMMHGLP(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.MKBIQHGNJPO()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.EEMHMOCLHPP(this.FFJJCIQPLOP.GBNQEKLJFCI(), false, true, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049AD RID: 18861 RVA: 0x00254B14 File Offset: 0x00252D14
	public void NPBOJJOKEME(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.Category == null)
		{
			QPGCBDPFIOF.EFJJPJGCQGE(string.Empty);
		}
		this.OQGNNFECDNJ = "'s protection!\r\n" + QPGCBDPFIOF.IGLOGLEBNQO() + "CombinersArgsAlphaSrc2" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "[/itm]")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "'s ";
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "imprison")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("#");
		}
		else
		{
			this.BBKKHIDMQIQ.JLENFJGDNFN(" would like you to join their Party. Do you wish to join?");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("You are unable to use ");
		}
		this.GPQPKPHIDIF.DPBGHDMHKNC(QPGCBDPFIOF.MGQFELMKFFK().ToLowerInvariant());
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "'s [ffff00]" + HJKCFNJIPHG.ToString() + "StopRow2" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.IEQCNMOLIEK("[00FF00]+");
		}
		if (QPGCBDPFIOF.FFFMCHDOOOI() == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "[FF6600]";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "/" + QPGCBDPFIOF.Power;
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.GPJDOILOLDJ("watersport");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("Chat Box - PMChat");
		}
		else
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("[33CCFF]" + QPGCBDPFIOF.QPGFMHBJPCE() + ".");
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.Name = "HidePanel";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x060049AE RID: 18862 RVA: 0x0001EC9C File Offset: 0x0001CE9C
	private void PBPEGDBGBMO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.MFONIPHOFGF(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x0001ED8C File Offset: 0x0001CF8C
	private void HMNHJGIKGFE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.PLMQDDPDOOL(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
	private void QLBLDNGQDQE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x060049B2 RID: 18866 RVA: 0x00254CF4 File Offset: 0x00252EF4
	public void LIDHPLOIFNP(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.Category == null)
		{
			QPGCBDPFIOF.Category = string.Empty;
		}
		this.OQGNNFECDNJ = "Leave Channel" + QPGCBDPFIOF.IGLOGLEBNQO() + "_RcpAspect" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Battle Armor")
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH("You do not have enough Pokédollars to purchase these items.");
		}
		else if (QPGCBDPFIOF.Category.ToLowerInvariant() == "Boosts its Speed stat if hit by an Electric-type move, instead of taking damage.")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("0");
		}
		else
		{
			this.BBKKHIDMQIQ.LGJOOQIBQDC("[00DD00]Owned");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH(" shrouded itself with Magic Coat!\r\n");
		}
		this.GPQPKPHIDIF.JLENFJGDNFN(QPGCBDPFIOF.PDKNHHDCQOE().ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("UpS" + HJKCFNJIPHG.ToString() + " was hurled into the air!\r\n" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.KKQKIBCLQEP("door_2");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Alt+";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "@" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == null)
		{
			QPGCBDPFIOF.NBFPIEMJIDH("auroraveil");
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("[00DD00]Equipped");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "Close" + QPGCBDPFIOF.QPGFMHBJPCE() + "healblock";
		}
		if (QPGCBDPFIOF.DFNQHDEDDKE() == null)
		{
			QPGCBDPFIOF.DFEMCBPDBJF("PrimitiveLeft");
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.IGLOGLEBNQO();
	}

	// Token: 0x060049B3 RID: 18867 RVA: 0x00254ED4 File Offset: 0x002530D4
	public void CQKHIPOLJNL(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.JNNLNMPHNCJ(string.Empty);
		}
		this.OQGNNFECDNJ = "/" + QPGCBDPFIOF.DFNQHDEDDKE() + "HidePanel" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "r")
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP(", ");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Pokebox Button(Clone)")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "'s Pokémon";
		}
		else
		{
			this.BBKKHIDMQIQ.JLENFJGDNFN(" had its energy drained!\r\n");
		}
		if (QPGCBDPFIOF.DBQIBEDQKCF() == null)
		{
			QPGCBDPFIOF.Type = "psn";
		}
		this.GPQPKPHIDIF.JOHBNEHCEJH(QPGCBDPFIOF.PDKNHHDCQOE().ToLowerInvariant());
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "sandrush" + HJKCFNJIPHG.ToString() + "item" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.QLGLDDKOBBI("???");
		}
		if (QPGCBDPFIOF.FFFMCHDOOOI() == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "[^a-zA-Z0-9]";
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC(" held up its [ffff00]Red Card[-] against " + QPGCBDPFIOF.FFFMCHDOOOI());
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.PNCDDQFEGFI("dispMode");
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "Big/";
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "][{" + QPGCBDPFIOF.QPGFMHBJPCE() + "ability";
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.LNPFBNNOFFF("Alola");
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x0001EDCF File Offset: 0x0001CFCF
	private void PGMGCOPEGND(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JEDHBMEEGEB(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.QOLKOBPCJBQ(null);
		}
	}

	// Token: 0x060049B5 RID: 18869 RVA: 0x002550B4 File Offset: 0x002532B4
	public void EHOONGNHQEQ(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.EFJJPJGCQGE(string.Empty);
		}
		this.OQGNNFECDNJ = "Empty Slot" + QPGCBDPFIOF.DFNQHDEDDKE() + "poisonpoint" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "noguard")
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH("_");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "12.5 17\n14 17\n14 20\n7 20\n\n7 8\n7 5\n2 5\n2 2\n13 2\n13 5\n10 5\n10 8")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = "[-]";
		}
		else
		{
			this.BBKKHIDMQIQ.LGJOOQIBQDC("Pointed stones dug into ");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.BFHDCFICJNH("Prefabs/FogSphereArea");
		}
		this.GPQPKPHIDIF.DPBGHDMHKNC(QPGCBDPFIOF.CMOOQIDINKO().ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("default" + HJKCFNJIPHG.ToString() + "The rain stopped." + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.KKQKIBCLQEP("/");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "_ReflectionTex";
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "mdata2" + QPGCBDPFIOF.Power;
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.CBKHNMEHHHE("Duplicate!");
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("weakarmor");
		}
		else
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("anticipation" + QPGCBDPFIOF.QPGFMHBJPCE() + " hung on using its [ffff00]Focus Sash[-]!\r\n");
		}
		if (QPGCBDPFIOF.DFNQHDEDDKE() == null)
		{
			QPGCBDPFIOF.DFEMCBPDBJF("[/pok]");
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.DFNQHDEDDKE();
	}

	// Token: 0x060049B6 RID: 18870 RVA: 0x00255294 File Offset: 0x00253494
	public void MIEHJOOLEHC(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.KOBKHDHGJEK(string.Empty);
		}
		this.OQGNNFECDNJ = "(X)" + QPGCBDPFIOF.Name + "]" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "perishsong")
		{
			this.BBKKHIDMQIQ.OGQLCMOFLLQ("megax");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Hidden/Post FX/Fog")
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH("The heavy rain has lifted!");
		}
		else
		{
			this.BBKKHIDMQIQ.DPBGHDMHKNC("Boosts the Pokémon's Speed stat in sunshine.");
		}
		if (QPGCBDPFIOF.PDKNHHDCQOE() == null)
		{
			QPGCBDPFIOF.ONHEELGIEDJ("hyperspacefury");
		}
		this.GPQPKPHIDIF.OGQLCMOFLLQ(QPGCBDPFIOF.CMOOQIDINKO().ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("DEPTH_OF_FIELD" + HJKCFNJIPHG.ToString() + "Timer Ball" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.OOLHFEEKNEQ("Sweet Scent Cooldown");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Hyper Cutter";
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("OnDragOver" + QPGCBDPFIOF.Power);
		}
		if (QPGCBDPFIOF.BLLFNBKDCMJ() == null)
		{
			QPGCBDPFIOF.GPJDOILOLDJ("/");
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == string.Empty)
		{
			this.QFOLCEFENKE.LKPOBCBOFIC("aquaring");
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "[PD]" + QPGCBDPFIOF.QCBKIHIKPCG() + "[-]?\n\nOnce you do this, it will be lost forever.";
		}
		if (QPGCBDPFIOF.Name == null)
		{
			QPGCBDPFIOF.GHPFFIEQNJP("\\n");
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.DFNQHDEDDKE());
	}

	// Token: 0x060049B7 RID: 18871 RVA: 0x00255474 File Offset: 0x00253674
	public void LOIGHBENOJC(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.QHEJQOCDJGL() == null)
		{
			QPGCBDPFIOF.OMGEHGQPNDI(string.Empty);
		}
		this.OQGNNFECDNJ = "_TreatBackfaceHitAsMiss" + QPGCBDPFIOF.Name + "[-]!\r\n" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "Party Request")
		{
			this.BBKKHIDMQIQ.JLENFJGDNFN("e");
		}
		else if (QPGCBDPFIOF.DPDGNFHLQMF().ToLowerInvariant() == "Pokémon Caught:")
		{
			this.BBKKHIDMQIQ.LGJOOQIBQDC("[-]!\r\n");
		}
		else
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("Fluffy");
		}
		if (QPGCBDPFIOF.CMOOQIDINKO() == null)
		{
			QPGCBDPFIOF.ONHEELGIEDJ("Achievement Points:");
		}
		this.GPQPKPHIDIF.OGQLCMOFLLQ(QPGCBDPFIOF.MGQFELMKFFK().ToLowerInvariant());
		this.JCCEFPKQGEQ.LKPOBCBOFIC("QTY: " + HJKCFNJIPHG.ToString() + "default" + NELLPQFHQJM.ToString());
		if (QPGCBDPFIOF.Power == null)
		{
			QPGCBDPFIOF.IEQCNMOLIEK("ability: ");
		}
		if (QPGCBDPFIOF.Power == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("Side Quests");
		}
		else
		{
			this.HJCCFIJQHJK.PIDLOFMIEFQ = "Discovered Area" + QPGCBDPFIOF.FFFMCHDOOOI();
		}
		if (QPGCBDPFIOF.QCBKIHIKPCG() == null)
		{
			QPGCBDPFIOF.NBFPIEMJIDH("Script:");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "Hidden/Post FX/Temporal Anti-aliasing";
		}
		else
		{
			this.QFOLCEFENKE.LKPOBCBOFIC(" got over its infatuation.\r\n" + QPGCBDPFIOF.QPGFMHBJPCE() + "Goto");
		}
		if (QPGCBDPFIOF.IGLOGLEBNQO() == null)
		{
			QPGCBDPFIOF.LNPFBNNOFFF("Item Usage");
		}
		this.FPQBICGEHMJ.PIDLOFMIEFQ = QPGCBDPFIOF.DFNQHDEDDKE();
	}

	// Token: 0x060049B8 RID: 18872 RVA: 0x00255654 File Offset: 0x00253854
	public void QPONNMLDLQD(KGQECFKLKOP.MoveInfo QPGCBDPFIOF, int HJKCFNJIPHG, int NELLPQFHQJM, KGQECFKLKOP.FEKOIOJQNKH CFHEIICNLFD)
	{
		this.FFJJCIQPLOP = CFHEIICNLFD;
		if (QPGCBDPFIOF == null)
		{
			QPGCBDPFIOF = new KGQECFKLKOP.MoveInfo();
		}
		if (QPGCBDPFIOF.DPDGNFHLQMF() == null)
		{
			QPGCBDPFIOF.BDJHKDDDPKG(string.Empty);
		}
		this.OQGNNFECDNJ = "Unlit/Transparent Colored" + QPGCBDPFIOF.Name + " surrounded itself with its Z-Power!\r\n" + QPGCBDPFIOF.Description;
		if (QPGCBDPFIOF.Category.ToLowerInvariant() == "mummy")
		{
			this.BBKKHIDMQIQ.JOHBNEHCEJH("psn");
		}
		else if (QPGCBDPFIOF.QHEJQOCDJGL().ToLowerInvariant() == "roost")
		{
			this.BBKKHIDMQIQ.KCLBMPFIPNQ = " can't move!\r\n";
		}
		else
		{
			this.BBKKHIDMQIQ.IQBBDKFDGGP("UI");
		}
		if (QPGCBDPFIOF.MGQFELMKFFK() == null)
		{
			QPGCBDPFIOF.Type = "Pointed stones dug into ";
		}
		this.GPQPKPHIDIF.IQBBDKFDGGP(QPGCBDPFIOF.PDKNHHDCQOE().ToLowerInvariant());
		this.JCCEFPKQGEQ.PIDLOFMIEFQ = "cut" + HJKCFNJIPHG.ToString() + "[00AAFF]" + NELLPQFHQJM.ToString();
		if (QPGCBDPFIOF.FFFMCHDOOOI() == null)
		{
			QPGCBDPFIOF.QLGLDDKOBBI("aa");
		}
		if (QPGCBDPFIOF.FFFMCHDOOOI() == string.Empty)
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("Active: ");
		}
		else
		{
			this.HJCCFIJQHJK.LKPOBCBOFIC("Glacier Badge" + QPGCBDPFIOF.Power);
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == null)
		{
			QPGCBDPFIOF.HCCNLNCLEMM("Reckless");
		}
		if (QPGCBDPFIOF.QPGFMHBJPCE() == string.Empty)
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "HM";
		}
		else
		{
			this.QFOLCEFENKE.PIDLOFMIEFQ = "n" + QPGCBDPFIOF.BLLFNBKDCMJ() + "The Pokémon makes it rain when it enters a battle.";
		}
		if (QPGCBDPFIOF.DFNQHDEDDKE() == null)
		{
			QPGCBDPFIOF.Name = "cutecharm";
		}
		this.FPQBICGEHMJ.LKPOBCBOFIC(QPGCBDPFIOF.IGLOGLEBNQO());
	}

	// Token: 0x060049B9 RID: 18873 RVA: 0x00255834 File Offset: 0x00253A34
	private void KHCKGBFPMLK(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 662f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QOQONHOOLNE.MGKFOIKFJDD() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.CDDIILFBFCF() != null || DBQLOHBBJMG.FFCOKMHBCQJ().QQQBDBNCMCP || CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("normalize");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.KGMFIOCJLEP()))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "Power Construct"))
					{
						if (!(pidlofmiefq == "[/urn][-]: ") && !(pidlofmiefq == "[u][33CCFF]") && !(pidlofmiefq == "Temp Sound Clip"))
						{
							if (!(pidlofmiefq == "] "))
							{
								if (pidlofmiefq == "-")
								{
									CNCJKLNHQBH.BJLGEDCPENQ().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.MKBIQHGNJPO()
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.MKMJKLDDNDD().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Use,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, true);
							}
						}
					}
					else
					{
						INFJMNPKNQF.IPOKOKIJECO().GLEBQIDOLKN.MIEHJOOLEHC(this.FFJJCIQPLOP.KPJLEOCJFFO(), false, true, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x00255A10 File Offset: 0x00253C10
	private void OKDCEENMNGE(bool KCICOJFDCPQ)
	{
		if (UnityEngine.Time.time > this.PQGNBMBDCGJ + 1322f)
		{
			this.PQGNBMBDCGJ = UnityEngine.Time.time;
			if (QOHCEBMQKMB.QQCNCIQQPIG().HKQNOMKNEFO() || CNCJKLNHQBH.BJLGEDCPENQ().CNFNKELFCHN || OGJJKKQPNMK.QOQONHOOLNE != null || DBQLOHBBJMG.QOQONHOOLNE.QQQBDBNCMCP || CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf)
			{
				CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("[-]");
				return;
			}
			if (KCICOJFDCPQ && this.FFJJCIQPLOP != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Contains(this.FFJJCIQPLOP.LDQDJLFIDCN))
			{
				string pidlofmiefq = this.FPQBICGEHMJ.PIDLOFMIEFQ;
				if (pidlofmiefq != null)
				{
					if (!(pidlofmiefq == "serenegrace"))
					{
						if (!(pidlofmiefq == "Crack") && !(pidlofmiefq == "symbiosis") && !(pidlofmiefq == "~"))
						{
							if (!(pidlofmiefq == "powder"))
							{
								if (pidlofmiefq == " ")
								{
									CNCJKLNHQBH.MOGQNGEPCEO().PEIGIDFJILJ();
								}
							}
							else
							{
								GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().MGJPFKOCGGC(this.FPQBICGEHMJ.PIDLOFMIEFQ);
								if (nbfcpoplomf != null)
								{
									GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
									{
										Action = EffectAction.Cancel,
										UID = nbfcpoplomf.BHFBMKQGOFN()
									}, false);
								}
							}
						}
						else
						{
							GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf2 = GNDQBCBDHKD.BJLGEDCPENQ().GBCDKJJGEFO(this.FPQBICGEHMJ.PIDLOFMIEFQ);
							if (nbfcpoplomf2 != null)
							{
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
								{
									Action = EffectAction.Cancel,
									UID = nbfcpoplomf2.BEILHFKFLEG()
								}, false);
							}
						}
					}
					else
					{
						INFJMNPKNQF.CFGIOIGOIFQ().GLEBQIDOLKN.QPONNMLDLQD(this.FFJJCIQPLOP.GBNQEKLJFCI(), false, false, null, false);
					}
				}
			}
		}
	}

	// Token: 0x060049BB RID: 18875 RVA: 0x0001EDE7 File Offset: 0x0001CFE7
	private void JODQILJDCCQ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JOFBCKFPFEN(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x060049BC RID: 18876 RVA: 0x0001EDFF File Offset: 0x0001CFFF
	private void CIODIICODLO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			GGGPJQEKNJD.JNDKHLFCEEB(this.OQGNNFECDNJ);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x04000FCA RID: 4042
	public PLQFPBQEPJD BBKKHIDMQIQ;

	// Token: 0x04000FCB RID: 4043
	public PLQFPBQEPJD GPQPKPHIDIF;

	// Token: 0x04000FCC RID: 4044
	public BKKHLBCLPJM FPQBICGEHMJ;

	// Token: 0x04000FCD RID: 4045
	public BKKHLBCLPJM QFOLCEFENKE;

	// Token: 0x04000FCE RID: 4046
	public BKKHLBCLPJM HJCCFIJQHJK;

	// Token: 0x04000FCF RID: 4047
	public BKKHLBCLPJM JCCEFPKQGEQ;

	// Token: 0x04000FD0 RID: 4048
	private string OQGNNFECDNJ = string.Empty;

	// Token: 0x04000FD1 RID: 4049
	private KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP;

	// Token: 0x04000FD2 RID: 4050
	private float PQGNBMBDCGJ;
}
