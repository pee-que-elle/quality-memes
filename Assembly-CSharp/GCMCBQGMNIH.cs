using System;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000277 RID: 631
public class GCMCBQGMNIH : MonoBehaviour
{
	// Token: 0x060056A2 RID: 22178 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void CEGPCMGDLBO()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void PQEFNPPCKOH()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056A4 RID: 22180 RVA: 0x002C575C File Offset: 0x002C395C
	private void FPDCCNJOLEF()
	{
		if (this.DJPFQIFPGHP == QuestType.None)
		{
			if (PlayerPrefs.GetInt("shellos" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("brn" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056A5 RID: 22181 RVA: 0x002C57F0 File Offset: 0x002C39F0
	public void CQKQEMHIMJQ()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)8)
			{
				PlayerPrefs.SetInt("-" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("overcoat" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			PlayerPrefs.SetInt("Hydration" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("*" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056A6 RID: 22182 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void OIFHQPQKEFF()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x002C58AC File Offset: 0x002C3AAC
	public void QPOFONLQNPN()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Side)
			{
				PlayerPrefs.SetInt("skydrop" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("missingno." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			PlayerPrefs.SetInt("Vital Spirit" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("Queenly Majesty" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.IBPKFNPPDKF();
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x002C5968 File Offset: 0x002C3B68
	private void OOIJPOCHQEJ()
	{
		if (this.DJPFQIFPGHP == (QuestType)6)
		{
			if (PlayerPrefs.GetInt("HidePanel" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("desolateland" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x002C59FC File Offset: 0x002C3BFC
	private void HCHIDEKMEBB()
	{
		if (this.DJPFQIFPGHP == (QuestType)7)
		{
			if (PlayerPrefs.GetInt("Hidden Power" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("Sky" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void MNCOKCFNDHB()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056AB RID: 22187 RVA: 0x002C5A90 File Offset: 0x002C3C90
	public void GGODOIGDIML()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)6)
			{
				PlayerPrefs.SetInt("'s [ffff00]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("F6" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == (QuestType)8)
		{
			PlayerPrefs.SetInt("´" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("Left" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void CDMJBDGFHBD()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056AD RID: 22189 RVA: 0x002C5B4C File Offset: 0x002C3D4C
	private void CNIKQOQLFFB()
	{
		if (this.DJPFQIFPGHP == QuestType.Bounty)
		{
			if (PlayerPrefs.GetInt("-useJoystick" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("Huge Power" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056AE RID: 22190 RVA: 0x002C5BE0 File Offset: 0x002C3DE0
	private void BBGHCDGEDEJ()
	{
		if (this.DJPFQIFPGHP == QuestType.None)
		{
			if (PlayerPrefs.GetInt("-" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056AF RID: 22191 RVA: 0x002C5C74 File Offset: 0x002C3E74
	public void PIKNOEEMIDP()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)7)
			{
				PlayerPrefs.SetInt("[-][/u]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("!\r\n" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Side)
		{
			PlayerPrefs.SetInt("Sandy" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("[M]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.IBPKFNPPDKF();
	}

	// Token: 0x060056B0 RID: 22192 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void KDIMINFFGEL()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056B1 RID: 22193 RVA: 0x002C5D30 File Offset: 0x002C3F30
	public void MLDQKOMQPOG()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)8)
			{
				PlayerPrefs.SetInt("_Step" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("TabSettings" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			PlayerPrefs.SetInt("[o]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("WATER_SIMPLE" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x002C5DEC File Offset: 0x002C3FEC
	public void COLLMPLMLFP()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)6)
			{
				PlayerPrefs.SetInt("[orange]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("G" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Main)
		{
			PlayerPrefs.SetInt("Innards Out" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("--catch" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void KJOPKJIKODI()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x002C5EA8 File Offset: 0x002C40A8
	public void MOPKEQPDHGN()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Bounty)
			{
				PlayerPrefs.SetInt("]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("Unity Camera not set and not found on the GameObject: " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == (QuestType)6)
		{
			PlayerPrefs.SetInt(" rose" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("[-]!\r\n" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056B5 RID: 22197 RVA: 0x002C5F64 File Offset: 0x002C4164
	private void BNGFCDCELHL()
	{
		if (this.DJPFQIFPGHP == QuestType.None)
		{
			if (PlayerPrefs.GetInt("." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("{0:0.0} ms ({1:0.} fps)" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x002C5FF8 File Offset: 0x002C41F8
	private void FCGLNCNICGB()
	{
		if (this.DJPFQIFPGHP == (QuestType)6)
		{
			if (PlayerPrefs.GetInt("Assets/AssetBundles/MapAssets2/Models/Materials/com_c02_mado0.mat" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EDY4N2MVWY2G6&custom=" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056B7 RID: 22199 RVA: 0x002C608C File Offset: 0x002C428C
	private void EKIFLKDPKNM()
	{
		if (this.DJPFQIFPGHP == QuestType.None)
		{
			if (PlayerPrefs.GetInt("Left" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("The poison spikes disappeared from the ground around " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056B8 RID: 22200 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void HONNFNFPCEB()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056B9 RID: 22201 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void JEKICNJPOHH()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056BA RID: 22202 RVA: 0x002C6120 File Offset: 0x002C4320
	public void OIIMBJBNFCN()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)8)
			{
				PlayerPrefs.SetInt("Parallax" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("Small/" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.None)
		{
			PlayerPrefs.SetInt("'s [ffff00]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("limber" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056BB RID: 22203 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void BCPEIBCLJQC()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056BC RID: 22204 RVA: 0x002C61DC File Offset: 0x002C43DC
	private void IKHIQQKHILB()
	{
		if (this.DJPFQIFPGHP == (QuestType)8)
		{
			if (PlayerPrefs.GetInt(" and " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt(" has " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056BD RID: 22205 RVA: 0x002C6270 File Offset: 0x002C4470
	private void LMELGHDGJMQ()
	{
		if (this.DJPFQIFPGHP == QuestType.None)
		{
			if (PlayerPrefs.GetInt("[epic]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("furcoat" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056BE RID: 22206 RVA: 0x002C6304 File Offset: 0x002C4504
	public void FBINMFMDELM()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Side)
			{
				PlayerPrefs.SetInt("Battle Update: " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("Cinematics" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Main)
		{
			PlayerPrefs.SetInt("[-]!\r\n" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("|" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056BF RID: 22207 RVA: 0x002C63C0 File Offset: 0x002C45C0
	public void KJOKCPJLEBF()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Side)
			{
				PlayerPrefs.SetInt("Purchasing Costume" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("USER_LUT" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == (QuestType)8)
		{
			PlayerPrefs.SetInt("inky" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("NPC" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.IBPKFNPPDKF();
	}

	// Token: 0x060056C0 RID: 22208 RVA: 0x002C647C File Offset: 0x002C467C
	public void JOHCOBEMOPD()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Bounty)
			{
				PlayerPrefs.SetInt("item: " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("|" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.None)
		{
			PlayerPrefs.SetInt("ANTI_FLICKER" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("HidePanel" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.IBPKFNPPDKF();
	}

	// Token: 0x060056C1 RID: 22209 RVA: 0x002C6538 File Offset: 0x002C4738
	public void FNJFKOHKDHM()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)8)
			{
				PlayerPrefs.SetInt("r" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("Control+" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == (QuestType)6)
		{
			PlayerPrefs.SetInt("Create Tab" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("Color Grading Log LUT" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056C2 RID: 22210 RVA: 0x002C65F4 File Offset: 0x002C47F4
	public void UpdateTracking()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Daily)
			{
				PlayerPrefs.SetInt("qdTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("qTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			PlayerPrefs.SetInt("qdTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("qTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056C3 RID: 22211 RVA: 0x002C66B0 File Offset: 0x002C48B0
	private void PEJKGQEGPMM()
	{
		if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			if (PlayerPrefs.GetInt("rotomfrost" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("General" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056C5 RID: 22213 RVA: 0x002C6744 File Offset: 0x002C4944
	private void KPKQNOCFGIB()
	{
		if (this.DJPFQIFPGHP == (QuestType)7)
		{
			if (PlayerPrefs.GetInt("telekinesis" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("fire" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056C6 RID: 22214 RVA: 0x002C67D8 File Offset: 0x002C49D8
	public void EICMBNOMDNK()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Hidden)
			{
				PlayerPrefs.SetInt("[s]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("-mega" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			PlayerPrefs.SetInt("0" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("fullmetalbody" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056C7 RID: 22215 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void OEDIFGPQIKL()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056C8 RID: 22216 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void QOEQHBIDMIP()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056C9 RID: 22217 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void DFBNIOEIFDD()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056CA RID: 22218 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void MHBNNCGMNHH()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056CB RID: 22219 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void MFPMIFEKEME()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x002C6894 File Offset: 0x002C4A94
	private void EDOGJBLCCMQ()
	{
		if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			if (PlayerPrefs.GetInt("Open" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("Battle Bond" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x002C6928 File Offset: 0x002C4B28
	public void PNKEMIHGCMK()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)6)
			{
				PlayerPrefs.SetInt("_MaxBlurRadius" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("Battle" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			PlayerPrefs.SetInt("Competitive" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("Battle" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056CE RID: 22222 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void LLJQQGDPJFD()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056CF RID: 22223 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void CGOHHFENQJC()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x002C69E4 File Offset: 0x002C4BE4
	public void OKJHCIGKINQ()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Bounty)
			{
				PlayerPrefs.SetInt("freeze" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_7_Light.mat" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			PlayerPrefs.SetInt("HidePanel" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("0" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056D1 RID: 22225 RVA: 0x002C6AA0 File Offset: 0x002C4CA0
	private void PGFHJKDGEMJ()
	{
		if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			if (PlayerPrefs.GetInt("Heavy Metal" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("Maximizes the number of times multi-strike moves hit." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void GGMINIPOKJI()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void QINFLJQBCIK()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x002C6B34 File Offset: 0x002C4D34
	public void QNQPNBKJEEC()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == (QuestType)8)
			{
				PlayerPrefs.SetInt("r" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("Overgrow" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Side)
		{
			PlayerPrefs.SetInt("Join Channel" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		else
		{
			PlayerPrefs.SetInt("Party Request" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056D5 RID: 22229 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void EKLNQHLPKLN()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056D6 RID: 22230 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void MBGOFPBDLFO()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056D7 RID: 22231 RVA: 0x002C6BF0 File Offset: 0x002C4DF0
	public void LLLCDBOMPIN()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Hidden)
			{
				PlayerPrefs.SetInt("[FF0000]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt("L" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Hidden)
		{
			PlayerPrefs.SetInt("Comes out disguised as the Pokémon in the party's last spot." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("#,##0" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056D8 RID: 22232 RVA: 0x002C6CAC File Offset: 0x002C4EAC
	public void GFHOLDNLJCK()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.None)
			{
				PlayerPrefs.SetInt("burmysandy" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("~" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.None)
		{
			PlayerPrefs.SetInt("primordialsea" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("TradeColliders" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x002C6D68 File Offset: 0x002C4F68
	private void Start()
	{
		if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			if (PlayerPrefs.GetInt("qdTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("qTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void MQQHIHHPHNN()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056DB RID: 22235 RVA: 0x002C6DFC File Offset: 0x002C4FFC
	private void NOBDHBBKKHN()
	{
		if (this.DJPFQIFPGHP == (QuestType)6)
		{
			if (PlayerPrefs.GetInt("0" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt(" minute ago" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x002C6E90 File Offset: 0x002C5090
	public void LMDHEGEJLBM()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Bounty)
			{
				PlayerPrefs.SetInt("But " + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
			}
			else
			{
				PlayerPrefs.SetInt(" for [PG]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			PlayerPrefs.SetInt("[BATTLE]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("[yellow]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.FNIFFFBEMDE();
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void MLJHFBQHCCL()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x002C6F4C File Offset: 0x002C514C
	private void HMJOBKGICKD()
	{
		if (this.DJPFQIFPGHP == QuestType.Side)
		{
			if (PlayerPrefs.GetInt("Numeric Boundaries" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("_MainTex" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x002C6FE0 File Offset: 0x002C51E0
	private void GJPGBCKQLDG()
	{
		if (this.DJPFQIFPGHP == (QuestType)8)
		{
			if (PlayerPrefs.GetInt("shscore" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("-sp" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 1)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void PBEBBBJCOMC()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x00021A14 File Offset: 0x0001FC14
	private void OIGEQEDMNGL()
	{
		NBQDPNGNNML.QOQONHOOLNE.OFJCBHKJCOP(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x002C7074 File Offset: 0x002C5274
	private void IJNCFJMGKDE()
	{
		if (this.DJPFQIFPGHP == (QuestType)7)
		{
			if (PlayerPrefs.GetInt("Stance Change" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("[" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056E3 RID: 22243 RVA: 0x002C7108 File Offset: 0x002C5308
	public void LLHFGHQBJIC()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Bounty)
			{
				PlayerPrefs.SetInt("." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats." + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Side)
		{
			PlayerPrefs.SetInt("item" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("item" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		NBQDPNGNNML.QOQONHOOLNE.IBPKFNPPDKF();
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void IQDNNDLMECM()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E5 RID: 22245 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void MEJIONIPLCM()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E6 RID: 22246 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void HLKFJNCPCGH()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E7 RID: 22247 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void NIIPONIQJCE()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E8 RID: 22248 RVA: 0x00021A26 File Offset: 0x0001FC26
	private void MPQCMPELLFC()
	{
		NBQDPNGNNML.QOQONHOOLNE.FQCHGQKKFCQ(this.DBPKNCDGGEP);
	}

	// Token: 0x060056E9 RID: 22249 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void OnClick()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x002C71C4 File Offset: 0x002C53C4
	private void MQIPDNNEFII()
	{
		if (this.DJPFQIFPGHP == (QuestType)6)
		{
			if (PlayerPrefs.GetInt("focusband" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("Battle" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056EB RID: 22251 RVA: 0x002C7258 File Offset: 0x002C5458
	private void BCDLNCLKKBM()
	{
		if (this.DJPFQIFPGHP == QuestType.Bounty)
		{
			if (PlayerPrefs.GetInt("-" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 0)
			{
				this.DNLKIOMIIHG.value = false;
			}
			else
			{
				this.DNLKIOMIIHG.value = false;
			}
		}
		else if (PlayerPrefs.GetInt("baddreams" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = false;
		}
		else
		{
			this.DNLKIOMIIHG.value = true;
		}
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x002C72EC File Offset: 0x002C54EC
	private void CMLGQHQJDGQ()
	{
		if (this.DJPFQIFPGHP == QuestType.Daily)
		{
			if (PlayerPrefs.GetInt("/" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0) == 1)
			{
				this.DNLKIOMIIHG.value = true;
			}
			else
			{
				this.DNLKIOMIIHG.value = true;
			}
		}
		else if (PlayerPrefs.GetInt("flying" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1) == 0)
		{
			this.DNLKIOMIIHG.value = true;
		}
		else
		{
			this.DNLKIOMIIHG.value = false;
		}
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x00021A38 File Offset: 0x0001FC38
	private void JKCPMBPBDCH()
	{
		NBQDPNGNNML.QOQONHOOLNE.GCMCBQGMNIH(this.DBPKNCDGGEP);
	}

	// Token: 0x060056EE RID: 22254 RVA: 0x002C7380 File Offset: 0x002C5580
	public void IFKIIFMEFJC()
	{
		if (this.DNLKIOMIIHG.value)
		{
			if (this.DJPFQIFPGHP == QuestType.Daily)
			{
				PlayerPrefs.SetInt("Are you sure you wish to buy [FF9900]" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
			else
			{
				PlayerPrefs.SetInt("Upgrading Guild" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
			}
		}
		else if (this.DJPFQIFPGHP == QuestType.Bounty)
		{
			PlayerPrefs.SetInt("_FogPointLightColor4" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 1);
		}
		else
		{
			PlayerPrefs.SetInt("_AutoExposure" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.DBPKNCDGGEP, 0);
		}
		NBQDPNGNNML.QOQONHOOLNE.CBOIPMDILFC();
	}

	// Token: 0x040012EE RID: 4846
	public string DBPKNCDGGEP = string.Empty;

	// Token: 0x040012EF RID: 4847
	public QuestType DJPFQIFPGHP;

	// Token: 0x040012F0 RID: 4848
	public UIToggle DNLKIOMIIHG;
}
