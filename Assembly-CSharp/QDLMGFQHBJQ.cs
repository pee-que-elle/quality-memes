using System;
using System.Collections;
using System.Diagnostics;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020003B1 RID: 945
public class QDLMGFQHBJQ : MonoBehaviour
{
	// Token: 0x06007E91 RID: 32401 RVA: 0x003C1544 File Offset: 0x003BF744
	public void Hide(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FKFEMKGMNPD());
			this.PLDCLOBLHMI = true;
		}
	}

	// Token: 0x06007E92 RID: 32402 RVA: 0x003C15B4 File Offset: 0x003BF7B4
	public void PJMKLHKFBJM(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			this.HLPKFPBFJQP.LHQECHHMOGD(new ENMOIEBMHNJ
			{
				PELCNBCMNFH = NKKGPNPGDEM,
				CDDKNNJMCMP = IGGPMQGKKQC
			});
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			this.HLPKFPBFJQP.LHQECHHMOGD(new ENMOIEBMHNJ
			{
				PELCNBCMNFH = NKKGPNPGDEM,
				CDDKNNJMCMP = IGGPMQGKKQC
			});
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = true;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		}
	}

	// Token: 0x06007E93 RID: 32403 RVA: 0x003C167C File Offset: 0x003BF87C
	[DebuggerHidden]
	private IEnumerator LCLQHIKFJMG()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007E94 RID: 32404 RVA: 0x003C1698 File Offset: 0x003BF898
	public void KNGQHHLPDMH()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1740f)
		{
			EMLOFJDOMKH.BDPEQNCNPJO().EDMNQJQIKHB(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.FNBNIBJJMMN();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.IPFNKIPHPHD();
			this.KKONMBCFEJC.position = enmoiebmhnj.HMHEBIDMCHM();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("Assets/AssetBundles/MapAssets/Models/Ext_House_VermCity_1/Materials/chip_mado.mat");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("spikyshield");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007E95 RID: 32405 RVA: 0x003C1764 File Offset: 0x003BF964
	public void EGLBJNMBKQB(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.KGEHEHQMMCD());
			this.PLDCLOBLHMI = true;
		}
	}

	// Token: 0x06007E96 RID: 32406 RVA: 0x003C17D4 File Offset: 0x003BF9D4
	public void MFONIPHOFGF(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
			this.PLDCLOBLHMI = false;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		}
	}

	// Token: 0x06007E97 RID: 32407 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator LFOJJCOHJJF()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007E98 RID: 32408 RVA: 0x003C18A4 File Offset: 0x003BFAA4
	public void EQEHGQHOOKL(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(0f, 2.5f, 0f);
				this.OPILOFIJJDF.JJMDLPEJOCK();
				this.OPILOFIJJDF.HCNPIJLODQE(HHNBICLDQKI, "(5)");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.EIOMPOHLEMC();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "[ZZZ]";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "[BATTLE]";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "[WAIT]";
			}
			string str2 = "[67befc]";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.Developer)
			{
				if (staffRank != StaffRank.GameModerator)
				{
					if (staffRank == StaffRank.Moderator)
					{
						str2 = "[7fff49]";
					}
				}
				else
				{
					str2 = "[ffb649]";
				}
			}
			else
			{
				str2 = "[ff4949]";
			}
			this.OPILOFIJJDF.HCNPIJLODQE(str + str2 + HHNBICLDQKI, string.Concat(new string[]
			{
				" [",
				CGOIPHKQMPD.QOQONHOOLNE.EFCDQKBEMBP(EKDDQNPBPJL.Level),
				"](",
				EKDDQNPBPJL.Level.ToString(),
				")"
			}));
			this.OPILOFIJJDF.JJMDLPEJOCK();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.HCNEOFKGDGP());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.HCNEOFKGDGP());
			}
		}
	}

	// Token: 0x06007E99 RID: 32409 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator NDHQCOHKPCG()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007E9A RID: 32410 RVA: 0x003C1B10 File Offset: 0x003BFD10
	public void EPKGNIPJOEF()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1687f)
		{
			EMLOFJDOMKH.HGLDHNMOLPD().DQKBOQBOBOM(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.QKNPJDIBCGG();
			this.KKONMBCFEJC.position = enmoiebmhnj.GKFFHLQHDGM();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("BuffIcon_EncounterRateLowered");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("'s moves have been electrified!\r\n");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007E9B RID: 32411 RVA: 0x003C1BDC File Offset: 0x003BFDDC
	public void GHGOHOBBDEF(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.JJJJIDQGFHE());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007E9C RID: 32412 RVA: 0x003C1C4C File Offset: 0x003BFE4C
	public void POFOEMPKIQE(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = true;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.KGEHEHQMMCD());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007E9D RID: 32413 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator QJQMQNQHNGJ()
	{
		AssetBundleRequest assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		UnityEngine.Object asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		SkinnedMeshRenderer[] componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007E9E RID: 32414 RVA: 0x003C1CD8 File Offset: 0x003BFED8
	public void QCPFKBQODCL(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(584f, 221f, 764f);
				this.OPILOFIJJDF.NFILEFHQQHB();
				this.OPILOFIJJDF.QKNQECPDJDF(HHNBICLDQKI, "You account is not Verified yet..");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.DEOCHNECJGG();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "Reset EVs";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "Max: ";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "metronome";
			}
			string str2 = "fly";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != (StaffRank)5)
				{
					if (staffRank == StaffRank.GameModerator)
					{
						str2 = "stamina";
					}
				}
				else
				{
					str2 = "0";
				}
			}
			else
			{
				str2 = "Players: ";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[0];
			array[1] = "Shift+";
			array[0] = CGOIPHKQMPD.BEKHPOHIPDE().EFCDQKBEMBP(EKDDQNPBPJL.Level);
			array[7] = "sandstorm";
			array[2] = EKDDQNPBPJL.Level.ToString();
			array[4] = "_Gain";
			opilofijjdf.QFNPKFKPLEO(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.ICNIJJJIFND();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.HCNEOFKGDGP());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.IOCCQOMPHHM());
			}
		}
	}

	// Token: 0x06007E9F RID: 32415 RVA: 0x003C1F44 File Offset: 0x003C0144
	public void LEFDQKGBBQQ(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(889f, 1982f, 191f);
				this.OPILOFIJJDF.OOBDJPHNBHG();
				this.OPILOFIJJDF.IPQBPQQFQME(HHNBICLDQKI, " lost all of its PP due to the grudge!\r\n");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.EJGCJGFEGPQ();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "An electric current runs across the battlefield!\r\n";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "Boosts the Attack and Sp. Def stats of itself and allies when it is sunny.";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!";
			}
			string str2 = "' to the Localization dictionary.\n";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != StaffRank.None)
				{
					if (staffRank == (StaffRank)7)
					{
						str2 = " stockpiled 2!\r\n";
					}
				}
				else
				{
					str2 = "0";
				}
			}
			else
			{
				str2 = "0";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[4];
			array[1] = "blank";
			array[0] = CGOIPHKQMPD.NKDNGLNOJJG().GEQPNJQJCKP(EKDDQNPBPJL.Level);
			array[5] = "berserk";
			array[8] = EKDDQNPBPJL.Level.ToString();
			array[0] = "victorystar";
			opilofijjdf.PHMFLFMPLJF(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.JJMDLPEJOCK();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.EHHEBLEDNIE());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.HCNEOFKGDGP());
			}
		}
	}

	// Token: 0x06007EA0 RID: 32416 RVA: 0x003C21B0 File Offset: 0x003C03B0
	public void MHDLPKHHHNN(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.QOFNGNPMHMO(NKKGPNPGDEM);
			enmoiebmhnj.FOEENKELEDH(IGGPMQGKKQC);
			hlpkfpbfjqp.LHQECHHMOGD(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.FNKIMEIIPGQ(NKKGPNPGDEM);
			enmoiebmhnj.OEPFJCEKHCN(IGGPMQGKKQC);
			hlpkfpbfjqp2.LHQECHHMOGD(enmoiebmhnj);
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = false;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.JKLQHMQODJN());
		}
	}

	// Token: 0x06007EA1 RID: 32417 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator IOCCQOMPHHM()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EA2 RID: 32418 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator HOKDDJNOGHJ()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EA3 RID: 32419 RVA: 0x0002E079 File Offset: 0x0002C279
	private void NNEMLECOOIM()
	{
		UnityEngine.Object.DestroyImmediate(this.OPILOFIJJDF.gameObject);
	}

	// Token: 0x06007EA4 RID: 32420 RVA: 0x0002E079 File Offset: 0x0002C279
	private void OnDestroy()
	{
		UnityEngine.Object.DestroyImmediate(this.OPILOFIJJDF.gameObject);
	}

	// Token: 0x06007EA5 RID: 32421 RVA: 0x003C2278 File Offset: 0x003C0478
	public void JEGNBLJFIEE()
	{
		if (!this.PLDCLOBLHMI && !this.MQQIPNKNGOC)
		{
			this.MQQIPNKNGOC = true;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FKFEMKGMNPD());
		}
	}

	// Token: 0x06007EA6 RID: 32422 RVA: 0x003C22E4 File Offset: 0x003C04E4
	[DebuggerHidden]
	private IEnumerator FKFEMKGMNPD()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EA7 RID: 32423 RVA: 0x003C2300 File Offset: 0x003C0500
	public void KNBFDBMPDDH()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1790f)
		{
			EMLOFJDOMKH.DPJQQGKEIIF().EDMNQJQIKHB(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.QMMIBQFBHJL();
			this.KKONMBCFEJC.position = enmoiebmhnj.NBQPNONPHMN();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("HidePanel");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("telepathy");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EA8 RID: 32424 RVA: 0x003C23CC File Offset: 0x003C05CC
	public void OPHENCLMQHG(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = true;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.QQJHNLGMKQM());
			this.PLDCLOBLHMI = false;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LFOJJCOHJJF());
		}
	}

	// Token: 0x06007EA9 RID: 32425 RVA: 0x003C249C File Offset: 0x003C069C
	public void IENJNCIDFNK()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1828f)
		{
			EMLOFJDOMKH.BCQGHQGLLPF().EDMNQJQIKHB(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.GLMGFLLBBGE();
			this.KKONMBCFEJC.position = enmoiebmhnj.KKCHEQHGNFQ();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade(" Pokédollars.");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("_Chunk");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EAA RID: 32426 RVA: 0x003C2568 File Offset: 0x003C0768
	public void FDDBHCGOJLP(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = true;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FKFEMKGMNPD());
			this.PLDCLOBLHMI = true;
		}
	}

	// Token: 0x06007EAB RID: 32427 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator QQJHNLGMKQM()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007EAC RID: 32428 RVA: 0x003C25D8 File Offset: 0x003C07D8
	public void Update()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 10f)
		{
			EMLOFJDOMKH.QOQONHOOLNE.EDMNQJQIKHB(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CLJLDIGMNQI();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.CDDKNNJMCMP;
			this.KKONMBCFEJC.position = enmoiebmhnj.PELCNBCMNFH;
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("300");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("301");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EAD RID: 32429 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator FHBNJDLDBLM()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EAE RID: 32430 RVA: 0x003C26A4 File Offset: 0x003C08A4
	public void QQFMGLFQQML(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.KGEHEHQMMCD());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007EAF RID: 32431 RVA: 0x003C2714 File Offset: 0x003C0914
	public void FMEIMNHHCCD(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.JKLQHMQODJN());
			this.PLDCLOBLHMI = true;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = true;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.MEJJGOCCNON());
		}
	}

	// Token: 0x06007EB0 RID: 32432 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator EPJCNIDGCQN()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EB1 RID: 32433 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator JENPEDOOLBI()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EB2 RID: 32434 RVA: 0x003C27E4 File Offset: 0x003C09E4
	public void IFNICCLBLOO(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.PELCNBCMNFH = NKKGPNPGDEM;
			enmoiebmhnj.IPFNNNKGCON(IGGPMQGKKQC);
			hlpkfpbfjqp.LHQECHHMOGD(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.QOFNGNPMHMO(NKKGPNPGDEM);
			enmoiebmhnj.IPFNNNKGCON(IGGPMQGKKQC);
			hlpkfpbfjqp2.LHQECHHMOGD(enmoiebmhnj);
			this.JKOHGDIFIEI = false;
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = false;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.MEJJGOCCNON());
		}
	}

	// Token: 0x06007EB3 RID: 32435 RVA: 0x003C28AC File Offset: 0x003C0AAC
	public void FBKNCKKFJJG()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1497f)
		{
			EMLOFJDOMKH.BDPEQNCNPJO().NHLOJNJGMKF(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.IPFNKIPHPHD();
			this.KKONMBCFEJC.position = enmoiebmhnj.OCBMQQJDJGG();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("Fix");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("Sweet Veil");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EB4 RID: 32436 RVA: 0x003C2978 File Offset: 0x003C0B78
	public void BCHILGCDEFP(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.EPGCCPINEQH(NKKGPNPGDEM);
			enmoiebmhnj.FOEENKELEDH(IGGPMQGKKQC);
			hlpkfpbfjqp.NHBJMGDNCBM(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.FNKIMEIIPGQ(NKKGPNPGDEM);
			enmoiebmhnj.OLNFJPMCMJI(IGGPMQGKKQC);
			hlpkfpbfjqp2.NHBJMGDNCBM(enmoiebmhnj);
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = false;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		}
	}

	// Token: 0x06007EB5 RID: 32437 RVA: 0x003C2A40 File Offset: 0x003C0C40
	public void JQPKDIBJHHF()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 498f)
		{
			EMLOFJDOMKH.DGCQMNHFQNH().NGOLHNMLCLN(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.FNBNIBJJMMN();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.OCOKFJCDPPP();
			this.KKONMBCFEJC.position = enmoiebmhnj.JCBDILOKJCQ();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("afteryou");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("Influences Sum");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EB6 RID: 32438 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator LOOKKJDHBKP()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EB7 RID: 32439 RVA: 0x003C2B0C File Offset: 0x003C0D0C
	public void LJPLPQLGBHQ(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.GLPQOQPFBOE());
			this.PLDCLOBLHMI = true;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.JKLQHMQODJN());
		}
	}

	// Token: 0x06007EB8 RID: 32440 RVA: 0x003C2BDC File Offset: 0x003C0DDC
	public void NKDPHGCGJIL()
	{
		if (!this.PLDCLOBLHMI && !this.MQQIPNKNGOC)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.NIGCBPHEQHO());
		}
	}

	// Token: 0x06007EB9 RID: 32441 RVA: 0x003C2C48 File Offset: 0x003C0E48
	public void KQCKQEPPFJL(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
			this.PLDCLOBLHMI = true;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.HIELDHDLNCL());
		}
	}

	// Token: 0x06007EBA RID: 32442 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator HCNEOFKGDGP()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EBB RID: 32443 RVA: 0x003C2D18 File Offset: 0x003C0F18
	public void EODNODBGOIK(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.HCEBMJNBOIM(NKKGPNPGDEM);
			enmoiebmhnj.HNELEGGDGCJ(IGGPMQGKKQC);
			hlpkfpbfjqp.NHBJMGDNCBM(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.HCEBMJNBOIM(NKKGPNPGDEM);
			enmoiebmhnj.PFJGEMEJELH(IGGPMQGKKQC);
			hlpkfpbfjqp2.LHQECHHMOGD(enmoiebmhnj);
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = true;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.GLPQOQPFBOE());
		}
	}

	// Token: 0x06007EBC RID: 32444 RVA: 0x003C2DE0 File Offset: 0x003C0FE0
	public void COPCNGCMQDF(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(1167f, 1290f, 339f);
				this.OPILOFIJJDF.CFJILJIGDII();
				this.OPILOFIJJDF.NONQODKMGNM(HHNBICLDQKI, " ");
				this.GHGQFCBQEJO = false;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.JIBIHELIJIO();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "Big/";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += " fell asleep!\r\n";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "3";
			}
			string str2 = "Could not connect to Server..";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.Developer)
			{
				if (staffRank != (StaffRank)6)
				{
					if (staffRank == (StaffRank)7)
					{
						str2 = "inven ";
					}
				}
				else
				{
					str2 = "General";
				}
			}
			else
			{
				str2 = "Comatose";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[]
			{
				"[ATK]"
			};
			array[0] = CGOIPHKQMPD.LQIDEJOEHNH().GEQPNJQJCKP(EKDDQNPBPJL.Level);
			array[5] = " ";
			array[4] = EKDDQNPBPJL.Level.ToString();
			array[0] = "Pokédex Seen:";
			opilofijjdf.DGJQFQFIPPN(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.NFILEFHQQHB();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.BNGEOJFJDFP());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.QJQMQNQHNGJ());
			}
		}
	}

	// Token: 0x06007EBD RID: 32445 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator EHHEBLEDNIE()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EBE RID: 32446 RVA: 0x003C304C File Offset: 0x003C124C
	public void OBNDQJFDQEK()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 777f)
		{
			EMLOFJDOMKH.DPJQQGKEIIF().LBPPHNDNPMG(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.FNBNIBJJMMN();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.KEBHQDCBQKM();
			this.KKONMBCFEJC.position = enmoiebmhnj.KKCHEQHGNFQ();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("Assets/AssetBundles/MapAssets/ModelPrefabs/");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("'s substitute faded!\r\n");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EBF RID: 32447 RVA: 0x003C26A4 File Offset: 0x003C08A4
	public void LECIOLIFGEN(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.KGEHEHQMMCD());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007EC0 RID: 32448 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator FJIJFJMJCKF()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EC1 RID: 32449 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator DOONNOKGOQD()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EC2 RID: 32450 RVA: 0x003C3118 File Offset: 0x003C1318
	public void HGEFPOJCJKE(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = true;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.NDHQCOHKPCG());
			this.PLDCLOBLHMI = true;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LFOJJCOHJJF());
		}
	}

	// Token: 0x06007EC3 RID: 32451 RVA: 0x003C31E8 File Offset: 0x003C13E8
	public void BNDGQGBCLBQ()
	{
		if (!this.PLDCLOBLHMI && !this.MQQIPNKNGOC)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FHBNJDLDBLM());
		}
	}

	// Token: 0x06007EC4 RID: 32452 RVA: 0x0002E079 File Offset: 0x0002C279
	private void CBPPIFFFPME()
	{
		UnityEngine.Object.DestroyImmediate(this.OPILOFIJJDF.gameObject);
	}

	// Token: 0x06007EC5 RID: 32453 RVA: 0x003C3254 File Offset: 0x003C1454
	public void EPOCMHBMHGC()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 954f)
		{
			EMLOFJDOMKH.BDPEQNCNPJO().GIGIKIGGBCD(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.PBDGQMPDPMN();
			this.KKONMBCFEJC.position = enmoiebmhnj.NBQPNONPHMN();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("The Pokémon may gather Honey after a battle.");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("[itm=");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EC7 RID: 32455 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator JJJJIDQGFHE()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EC8 RID: 32456 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator KGEHEHQMMCD()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EC9 RID: 32457 RVA: 0x003C3320 File Offset: 0x003C1520
	public void LBFBLIBCMON(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(1719f, 1586f, 385f);
				this.OPILOFIJJDF.ICNIJJJIFND();
				this.OPILOFIJJDF.NFINOFMECBF(HHNBICLDQKI, "Data/pokemon");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.BBDCINMJMNK();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "shscore";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "ironfist";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "OnPress";
			}
			string str2 = "'?";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != StaffRank.GameModerator)
				{
					if (staffRank == StaffRank.None)
					{
						str2 = "marvelscale";
					}
				}
				else
				{
					str2 = "None";
				}
			}
			else
			{
				str2 = "Assets/AssetBundles/MapAssets2/Model Materials/WareHouses/t105_mado_mat.mat";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[3];
			array[0] = "Cannot disconnect, not connected!";
			array[1] = CGOIPHKQMPD.BDPEQNCNPJO().FPNFQLGFEQB(EKDDQNPBPJL.Level);
			array[4] = "map";
			array[2] = EKDDQNPBPJL.Level.ToString();
			array[0] = "[ff6666]";
			opilofijjdf.IKFQCEIKBMK(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.EPEEEBIIEDI();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.EHHEBLEDNIE());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.BFLMMIEOMHN());
			}
		}
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator BNGEOJFJDFP()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator KGQHOCGOPMH()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007ECC RID: 32460 RVA: 0x003C358C File Offset: 0x003C178C
	public void PFQNKLLLBBP(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = true;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.JJJJIDQGFHE());
			this.PLDCLOBLHMI = true;
		}
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x003C35FC File Offset: 0x003C17FC
	public void KMDEDOLPPLF(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.BIJEQKKMFMD(NKKGPNPGDEM);
			enmoiebmhnj.GLLQGMHOJGF(IGGPMQGKKQC);
			hlpkfpbfjqp.LHQECHHMOGD(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.QOFNGNPMHMO(NKKGPNPGDEM);
			enmoiebmhnj.OEPFJCEKHCN(IGGPMQGKKQC);
			hlpkfpbfjqp2.NHBJMGDNCBM(enmoiebmhnj);
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = true;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LFOJJCOHJJF());
		}
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator PNCKPGBHDOP()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007ECF RID: 32463 RVA: 0x003C36C4 File Offset: 0x003C18C4
	public void EFDILDHBMOK(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FJIJFJMJCKF());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007ED0 RID: 32464 RVA: 0x0002E079 File Offset: 0x0002C279
	private void HLNNFGDHLOD()
	{
		UnityEngine.Object.DestroyImmediate(this.OPILOFIJJDF.gameObject);
	}

	// Token: 0x06007ED1 RID: 32465 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator GLPQOQPFBOE()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007ED2 RID: 32466 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator BFLMMIEOMHN()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007ED3 RID: 32467 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator JKLQHMQODJN()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007ED4 RID: 32468 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator MEJJGOCCNON()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007ED5 RID: 32469 RVA: 0x0002E079 File Offset: 0x0002C279
	private void GDDBJCOJNKC()
	{
		UnityEngine.Object.DestroyImmediate(this.OPILOFIJJDF.gameObject);
	}

	// Token: 0x06007ED6 RID: 32470 RVA: 0x003C3734 File Offset: 0x003C1934
	public void KHPPDHOEPJD(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.JKLQHMQODJN());
			this.PLDCLOBLHMI = false;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = false;
			this.MQQIPNKNGOC = false;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.JKLQHMQODJN());
		}
	}

	// Token: 0x06007ED7 RID: 32471 RVA: 0x003C3804 File Offset: 0x003C1A04
	public void HDCHLOLKEGL(bool PIIMECMDJMH = true)
	{
		this.JKOHGDIFIEI = PIIMECMDJMH;
		this.MQQIPNKNGOC = false;
		if (!this.PLDCLOBLHMI)
		{
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.PNCKPGBHDOP());
			this.PLDCLOBLHMI = false;
		}
	}

	// Token: 0x06007ED8 RID: 32472 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator NHEHHOOMFJC()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007ED9 RID: 32473 RVA: 0x003C1CBC File Offset: 0x003BFEBC
	private IEnumerator EMMHLLJFLEC()
	{
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(this.LIMHLDPQOKF) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, base.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15E;
		IL_FE:
		componentsInChildren[num].material.SetFloat("_Dissolve", 0.5f);
		componentsInChildren[num].material.SetFloat("_DissolveScale", 96f);
		componentsInChildren[num].transform.parent = componentsInChildren[num].rootBone.transform;
		num++;
		IL_15E:
		if (num < componentsInChildren.Length)
		{
			goto IL_FE;
		}
		this.DJQDMBNLQDI.SetActive(false);
		this.MQQIPNKNGOC = true;
		if (this.KBKJGIEOFLB == null)
		{
			goto IL_1A9;
		}
		base.StopCoroutine(this.KBKJGIEOFLB);
		IL_1A9:
		if (this.ICMOFOPOJLM == null)
		{
			goto IL_1CC;
		}
		base.StopCoroutine(this.ICMOFOPOJLM);
		IL_1CC:
		this.ICMOFOPOJLM = base.StartCoroutine(this.LCLQHIKFJMG());
		yield break;
	}

	// Token: 0x06007EDA RID: 32474 RVA: 0x003C3874 File Offset: 0x003C1A74
	public void GKMKINDKNPJ()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 1297f)
		{
			EMLOFJDOMKH.DKJQQCEGJKO().LQPMQHHPMFB(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CGDGNLGEKIQ();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.OFFLBOBCBLP();
			this.KKONMBCFEJC.position = enmoiebmhnj.PELCNBCMNFH;
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade("RightS");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("refrigerate");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EDB RID: 32475 RVA: 0x003C3940 File Offset: 0x003C1B40
	public void CIHJOEIFMQE()
	{
		if (this.PLDCLOBLHMI && !this.JKOHGDIFIEI && UnityEngine.Time.time > this.OEHQLOMBGDF + 975f)
		{
			EMLOFJDOMKH.DPJQQGKEIIF().GIGIKIGGBCD(this.DJINHGFKCCG);
			return;
		}
		ENMOIEBMHNJ enmoiebmhnj = this.HLPKFPBFJQP.CLJLDIGMNQI();
		if (enmoiebmhnj != null)
		{
			this.KKONMBCFEJC.rotation = enmoiebmhnj.PBDGQMPDPMN();
			this.KKONMBCFEJC.position = enmoiebmhnj.KCNQJEOMMNM();
		}
		if (this.HPIMMEFNKJH != null)
		{
			if (this.CDODCODMPEI == this.KKONMBCFEJC.position)
			{
				this.HPIMMEFNKJH.CrossFade(" days");
			}
			else
			{
				this.HPIMMEFNKJH.CrossFade("Limit Distance");
			}
		}
		this.CDODCODMPEI = this.KKONMBCFEJC.position;
	}

	// Token: 0x06007EDC RID: 32476 RVA: 0x003C31E8 File Offset: 0x003C13E8
	public void DKCGOGOKKEK()
	{
		if (!this.PLDCLOBLHMI && !this.MQQIPNKNGOC)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FHBNJDLDBLM());
		}
	}

	// Token: 0x06007EDD RID: 32477 RVA: 0x003C3A0C File Offset: 0x003C1C0C
	public void OMNHFENGIDG(Vector3 NKKGPNPGDEM, Quaternion IGGPMQGKKQC, bool LBOKFQHEQBM = false)
	{
		if (LBOKFQHEQBM)
		{
			MLDCGDPQJKM hlpkfpbfjqp = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.QOFNGNPMHMO(NKKGPNPGDEM);
			enmoiebmhnj.IPFNNNKGCON(IGGPMQGKKQC);
			hlpkfpbfjqp.LHQECHHMOGD(enmoiebmhnj);
		}
		else
		{
			this.KKONMBCFEJC.position = NKKGPNPGDEM;
			this.KKONMBCFEJC.rotation = IGGPMQGKKQC;
			this.HLPKFPBFJQP = new MLDCGDPQJKM();
			MLDCGDPQJKM hlpkfpbfjqp2 = this.HLPKFPBFJQP;
			ENMOIEBMHNJ enmoiebmhnj = new ENMOIEBMHNJ();
			enmoiebmhnj.HCEBMJNBOIM(NKKGPNPGDEM);
			enmoiebmhnj.CDDKNNJMCMP = IGGPMQGKKQC;
			hlpkfpbfjqp2.NHBJMGDNCBM(enmoiebmhnj);
			this.JKOHGDIFIEI = true;
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = true;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.QQJHNLGMKQM());
		}
	}

	// Token: 0x06007EDE RID: 32478 RVA: 0x003C3AD4 File Offset: 0x003C1CD4
	public void DDIOCHNQJPH(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(1615f, 1195f, 1519f);
				this.OPILOFIJJDF.ICNIJJJIFND();
				this.OPILOFIJJDF.MHQJOQMDDPN(HHNBICLDQKI, ".png");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.JIBIHELIJIO();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "_FogDistance";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "_DebugWidth";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += "quash";
			}
			string str2 = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EDY4N2MVWY2G6&custom=";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.Developer)
			{
				if (staffRank != StaffRank.None)
				{
					if (staffRank == (StaffRank)7)
					{
						str2 = "\"\nYou may need to increase the preloaded object count for this prefab?";
					}
				}
				else
				{
					str2 = "/50 Friends";
				}
			}
			else
			{
				str2 = "tanglinghair";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[8];
			array[0] = "[urn=";
			array[0] = CGOIPHKQMPD.QOQONHOOLNE.BQLJDCKNKIM(EKDDQNPBPJL.Level);
			array[1] = "[F]";
			array[8] = EKDDQNPBPJL.Level.ToString();
			array[1] = " melted the ice!\r\n";
			opilofijjdf.MQIPBCBLOIC(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.JJMDLPEJOCK();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.EPJCNIDGCQN());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.JENPEDOOLBI());
			}
		}
	}

	// Token: 0x06007EDF RID: 32479 RVA: 0x003C3D40 File Offset: 0x003C1F40
	public void OGIIJNDQEBK(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(1432f, 965f, 1435f);
				this.OPILOFIJJDF.GMBMGKJMMPN();
				this.OPILOFIJJDF.NFINOFMECBF(HHNBICLDQKI, "Simulated Lag: ");
				this.GHGQFCBQEJO = false;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.KBFPJDGOIIL();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = "d";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "_TileMaxOffs";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += " has chosen to run.";
			}
			string str2 = "[00EE07]";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != (StaffRank)4)
				{
					if (staffRank == StaffRank.GameModerator)
					{
						str2 = "Run_White";
					}
				}
				else
				{
					str2 = "[/pok]";
				}
			}
			else
			{
				str2 = "#,##0";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[]
			{
				null,
				"Battle"
			};
			array[1] = CGOIPHKQMPD.GDDGJKOLGIQ().OLBBJHKDONF(EKDDQNPBPJL.Level);
			array[0] = "The Pokémon is full of vitality, and that prevents it from falling asleep.";
			array[8] = EKDDQNPBPJL.Level.ToString();
			array[8] = " learned the move ";
			opilofijjdf.NONQODKMGNM(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.ICNIJJJIFND();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.EPJCNIDGCQN());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.KGQHOCGOPMH());
			}
		}
	}

	// Token: 0x06007EE0 RID: 32480 RVA: 0x003C22E4 File Offset: 0x003C04E4
	private IEnumerator NIGCBPHEQHO()
	{
		QDLMGFQHBJQ.PBFLDBDCMOC pbfldbdcmoc = new QDLMGFQHBJQ.PBFLDBDCMOC();
		pbfldbdcmoc.QNDQJMNKFNN = this;
		return pbfldbdcmoc;
	}

	// Token: 0x06007EE1 RID: 32481 RVA: 0x003C3FAC File Offset: 0x003C21AC
	public void FBHNDOJQHLB(bool LBKMBCOOIHC = false)
	{
		if (this.JKOHGDIFIEI && this.PLDCLOBLHMI)
		{
			this.MQQIPNKNGOC = true;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.QQJHNLGMKQM());
			this.PLDCLOBLHMI = true;
		}
		else if (LBKMBCOOIHC && this.JKOHGDIFIEI && this.MQQIPNKNGOC)
		{
			this.PLDCLOBLHMI = true;
			this.MQQIPNKNGOC = true;
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			this.ICMOFOPOJLM = base.StartCoroutine(this.LFOJJCOHJJF());
		}
	}

	// Token: 0x06007EE2 RID: 32482 RVA: 0x003C167C File Offset: 0x003BF87C
	private IEnumerator HIELDHDLNCL()
	{
		QDLMGFQHBJQ.HMJPPQKNPGD hmjppqknpgd = new QDLMGFQHBJQ.HMJPPQKNPGD();
		hmjppqknpgd.QNDQJMNKFNN = this;
		return hmjppqknpgd;
	}

	// Token: 0x06007EE3 RID: 32483 RVA: 0x003C31E8 File Offset: 0x003C13E8
	public void CDPPFOHHEMF()
	{
		if (!this.PLDCLOBLHMI && !this.MQQIPNKNGOC)
		{
			this.MQQIPNKNGOC = false;
			this.OEHQLOMBGDF = UnityEngine.Time.time;
			if (this.KBKJGIEOFLB != null)
			{
				base.StopCoroutine(this.KBKJGIEOFLB);
			}
			if (this.ICMOFOPOJLM != null)
			{
				base.StopCoroutine(this.ICMOFOPOJLM);
			}
			this.KBKJGIEOFLB = base.StartCoroutine(this.FHBNJDLDBLM());
		}
	}

	// Token: 0x06007EE4 RID: 32484 RVA: 0x003C407C File Offset: 0x003C227C
	public void PGBEPJNLDLO(FlyUserData EKDDQNPBPJL, string HHNBICLDQKI)
	{
		if (EKDDQNPBPJL != null)
		{
			this.DJINHGFKCCG = HHNBICLDQKI;
			if (!this.GHGQFCBQEJO)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<EHDQKOBOHPE>(this.HQCPKMDMFCN, base.transform);
				this.OPILOFIJJDF.transform.localPosition = new Vector3(1172f, 243f, 13f);
				this.OPILOFIJJDF.OOBDJPHNBHG();
				this.OPILOFIJJDF.HCNPIJLODQE(HHNBICLDQKI, "Player/Hair");
				this.GHGQFCBQEJO = true;
			}
			if (this.OPILOFIJJDF.DFMCFGLQLNL != EKDDQNPBPJL.GuildName || this.OPILOFIJJDF.EBDMBIIOKFJ != (int)EKDDQNPBPJL.EmblemId)
			{
				this.OPILOFIJJDF.DFMCFGLQLNL = EKDDQNPBPJL.GuildName;
				this.OPILOFIJJDF.EBDMBIIOKFJ = (int)EKDDQNPBPJL.EmblemId;
				this.OPILOFIJJDF.HOFPCOOCHJM();
			}
			string str = string.Empty;
			if (EKDDQNPBPJL.Away)
			{
				str = " is being withdrawn!\r\n";
			}
			if (EKDDQNPBPJL.Battle)
			{
				str += "powder";
			}
			else if (EKDDQNPBPJL.Lobby)
			{
				str += " / ";
			}
			string str2 = "_FogWindDir";
			StaffRank staffRank = EKDDQNPBPJL.StaffRank;
			if (staffRank != StaffRank.None)
			{
				if (staffRank != (StaffRank)7)
				{
					if (staffRank == StaffRank.Developer)
					{
						str2 = "/Model.prefab";
					}
				}
				else
				{
					str2 = "Mouse ScrollWheel";
				}
			}
			else
			{
				str2 = "Guild";
			}
			EHDQKOBOHPE opilofijjdf = this.OPILOFIJJDF;
			string dbepqkemjop = str + str2 + HHNBICLDQKI;
			string[] array = new string[6];
			array[1] = "~";
			array[0] = CGOIPHKQMPD.BEKHPOHIPDE().NKHFOKCHGEE(EKDDQNPBPJL.Level);
			array[8] = "#,##0";
			array[4] = EKDDQNPBPJL.Level.ToString();
			array[2] = "bag";
			opilofijjdf.IKFQCEIKBMK(dbepqkemjop, string.Concat(array));
			this.OPILOFIJJDF.ICNIJJJIFND();
			if (this.DJQDMBNLQDI == null)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.HOKDDJNOGHJ());
			}
			else if (this.DJQDMBNLQDI != null && this.LIMHLDPQOKF != EKDDQNPBPJL.FlyMount)
			{
				this.LIMHLDPQOKF = EKDDQNPBPJL.FlyMount;
				if (this.BMGPPMNNLHI != null)
				{
					base.StopCoroutine(this.BMGPPMNNLHI);
				}
				UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
				this.HPIMMEFNKJH = null;
				this.DJQDMBNLQDI = null;
				this.BMGPPMNNLHI = base.StartCoroutine(this.BNGEOJFJDFP());
			}
		}
	}

	// Token: 0x04001CA7 RID: 7335
	private int LIMHLDPQOKF;

	// Token: 0x04001CA8 RID: 7336
	public string DJINHGFKCCG;

	// Token: 0x04001CA9 RID: 7337
	public EHDQKOBOHPE OPILOFIJJDF;

	// Token: 0x04001CAA RID: 7338
	public EHDQKOBOHPE HQCPKMDMFCN;

	// Token: 0x04001CAB RID: 7339
	public GameObject DJQDMBNLQDI;

	// Token: 0x04001CAC RID: 7340
	public float MPDHBQPINNH = 24f;

	// Token: 0x04001CAD RID: 7341
	public float LLPEMNIPJBO = 5f;

	// Token: 0x04001CAE RID: 7342
	public Transform KKONMBCFEJC;

	// Token: 0x04001CAF RID: 7343
	private Vector3 FQLIMHHCIJC;

	// Token: 0x04001CB0 RID: 7344
	private Quaternion NDCBBEPMLBD;

	// Token: 0x04001CB1 RID: 7345
	private MLDCGDPQJKM HLPKFPBFJQP = new MLDCGDPQJKM();

	// Token: 0x04001CB2 RID: 7346
	private bool GHGQFCBQEJO;

	// Token: 0x04001CB3 RID: 7347
	private float OEHQLOMBGDF;

	// Token: 0x04001CB4 RID: 7348
	private bool PLDCLOBLHMI;

	// Token: 0x04001CB5 RID: 7349
	private bool JKOHGDIFIEI = true;

	// Token: 0x04001CB6 RID: 7350
	private Coroutine KBKJGIEOFLB;

	// Token: 0x04001CB7 RID: 7351
	private Coroutine ICMOFOPOJLM;

	// Token: 0x04001CB8 RID: 7352
	private bool MQQIPNKNGOC;

	// Token: 0x04001CB9 RID: 7353
	private Coroutine BMGPPMNNLHI;

	// Token: 0x04001CBA RID: 7354
	private Animation HPIMMEFNKJH;

	// Token: 0x04001CBB RID: 7355
	private Vector3 CDODCODMPEI;
}
