using System;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x020001F5 RID: 501
public class MCMHEQDOMOI : MonoBehaviour
{
	// Token: 0x060041A2 RID: 16802 RVA: 0x001FE41C File Offset: 0x001FC61C
	public void LCCLHQMCGNB(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "1";
		}
		else
		{
			text = "Down";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[0];
		array[0] = "|";
		array[1] = text;
		array[2] = "/[PD]";
		array[6] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[7] = "[668cff]Inspect";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[1] = "' was successful.";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[1] = ".";
		array2[1] = text;
		array2[1] = "When attacking, the Pokémon ignores the target Pokémon's stat changes.";
		array2[7] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "airlock";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[]
		{
			"H",
			text,
			null,
			"PC2DBackgroundCamera",
			JMDLLJPEFKM.Hair.QQKICQQBIJL()
		};
		array3[3] = "map:flymap";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("[ATK]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)7)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("_FogScatteringData2" + text + "BuffIcon_SandstormEncounterDecreased", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("BuffIcon_MuteIcon" + text + "[FF8F00]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[]
				{
					"HidePanel"
				};
				array4[0] = text;
				array4[2] = "_Female";
				array4[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[1] = "[FF8F00]";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[2];
			array5[0] = "Hidden/Post FX/Temporal Anti-aliasing";
			array5[1] = text;
			array5[4] = "bag";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[2] = "Materials/DFGDesktop";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.NMPCLCEQJMP(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Limit Speed" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "Agility increases armor", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[3].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x001FE724 File Offset: 0x001FC924
	public void PCFNFCMCMII(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "[FFFF00]/252";
		}
		else
		{
			text = "[FF9900]";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[7];
		array[0] = "Run";
		array[0] = text;
		array[0] = "Hide";
		array[3] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[0] = "FactoryTempTexture";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "Popup list needs a source object...";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[5];
		array2[0] = "Influences Sum";
		array2[0] = text;
		array2[6] = "Repel";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[5] = "AI";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("/", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" protected itself!\r\n" + text + "Sound", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("/ban " + text + "^emote+", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[0];
				array3[1] = " switched all changes to its Attack and Sp. Atk with its target!\r\n";
				array3[0] = text;
				array3[6] = " has no mainTexture setter";
				array3[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[4] = "s Lucky Chant wore off!\r\n";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[]
			{
				null,
				"-invertboost"
			};
			array4[0] = text;
			array4[1] = "Language";
			array4[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "Reposition";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("/Model.prefab" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "CombinersAlphaScale", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 1; i < 5; i += 0)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[4].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041A4 RID: 16804 RVA: 0x001FEA20 File Offset: 0x001FCC20
	public void PMDQEIBJJQK(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Are you sure you wish to remove [2ecc71]";
		}
		else
		{
			text = " hours";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[1];
		array[1] = "Dist0";
		array[0] = text;
		array[7] = "]";
		array[6] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[5] = "The Pokémon may heal its own status conditions by shedding its skin.";
		array[3] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[8] = "_Bloom_DirtTex";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[6];
		array2[0] = "[-] has come online.";
		array2[0] = text;
		array2[0] = "Battle Bond";
		array2[0] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[4] = "psn";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[4];
		array3[1] = "\nAre you sure you want to Reset its IVs?";
		array3[1] = text;
		array3[0] = "p1";
		array3[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[6] = "FOG_EXP2";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("\n[FF9900]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("beatup" + text + "spectatorleave", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("A critical hit" + text + "par", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[8];
				array4[1] = "~";
				array4[0] = text;
				array4[6] = "Connecting to Server..";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[8] = "magiccoat";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[0];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[7];
			array5[1] = "[ff6666]";
			array5[1] = text;
			array5[2] = "Male";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[6] = "'s ";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.NMPCLCEQJMP(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Cap" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "_Top", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[4].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x001FED28 File Offset: 0x001FCF28
	public void LBGCODKNHHP(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "waterveil";
		}
		else
		{
			text = "The [ffff00]";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[4];
		array[1] = "The power of ";
		array[1] = text;
		array[0] = "-mega-y";
		array[5] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[8] = " EXP[-]";
		array[8] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[3] = ".";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[6];
		array2[0] = "choice";
		array2[1] = text;
		array2[3] = "water";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = "flowergift";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("BuffIcon_SandstormEncounterDecreased", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("/510)" + text + "baddreams", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Skill Link" + text + "Player/Hair", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[3];
				array3[1] = "\n";
				array3[0] = text;
				array3[0] = "u";
				array3[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[5] = "Assets/AssetBundles/MapAssets/Models/Ext_House_VermCity_1/Materials/chip_mado.mat";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[4];
			array4[0] = ")";
			array4[0] = text;
			array4[7] = "minus";
			array4[8] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[4] = "_FogPointLightColor0";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("less than 1 minute ago" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "[-]!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 0; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[2].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x001FF024 File Offset: 0x001FD224
	public void KIIGEFHQMDI(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "[7fff49]";
		}
		else
		{
			text = " exp.";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[7];
		array[1] = "\r\n";
		array[0] = text;
		array[0] = "[^0-9.-]";
		array[2] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[5] = "CombinersColorPassThrough";
		array[3] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[5] = "~";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[3];
		array2[0] = "M1";
		array2[0] = text;
		array2[8] = "truant";
		array2[6] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = "Move To Player";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("sketch" + text + "[fail]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("berry_5" + text + "Target Root object cannot be the same object that has Envelop Content. Make it a sibling instead.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[2];
				array3[0] = "Music";
				array3[1] = text;
				array3[2] = "/";
				array3[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[6] = "liquidooze";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[4];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[]
			{
				null,
				"'s [ffff00]"
			};
			array4[0] = text;
			array4[0] = " was squeezed by ";
			array4[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[4] = "Queenly Majesty";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("p2" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "_NormalAndRoughnessTexture", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 4; i++)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[8].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x001FF320 File Offset: 0x001FD520
	public void DLEDQFJCPDJ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "[00EE07]";
		}
		else
		{
			text = "Sound";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[5];
		array[0] = "stockpile1";
		array[1] = text;
		array[8] = "'s Wonder Guard evades the attack!\r\n";
		array[7] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[2] = " hung on using its [ffff00]Focus Sash[-]!\r\n";
		array[2] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "typeadd";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[1] = "berry_17";
		array2[1] = text;
		array2[7] = "Battle";
		array2[8] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[2] = "psychicsurge";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[8];
		array3[0] = "~";
		array3[1] = text;
		array3[1] = "dazzling";
		array3[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[2] = "(B)";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("|0|", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("ironbarbs" + text + " into the sky!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("ability: " + text + "replace", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[1];
				array4[1] = "[PG]";
				array4[1] = text;
				array4[2] = "CombinersUpAlphaBuff";
				array4[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[0] = "_BilateralUpsampling";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[4];
			array5[0] = "[-]";
			array5[0] = text;
			array5[8] = "\nDay";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[2] = "FOG_EXP2";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("CombinersArgsAlphaOp2" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "[PG]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[0].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x001FF628 File Offset: 0x001FD828
	public void HDNLCNIHJBM(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "_Male";
		}
		else
		{
			text = "berry_12";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[2];
		array[0] = "unburden";
		array[1] = text;
		array[6] = "overgrow";
		array[0] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[6] = "_History3Weight";
		array[0] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[2] = "Guild";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[]
		{
			null,
			"Sweet Veil"
		};
		array2[0] = text;
		array2[7] = "_Direction";
		array2[4] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "flowerveil";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[3];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[1];
		array3[0] = "frisk";
		array3[1] = text;
		array3[3] = "magmaarmor";
		array3[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[6] = "Mummy";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("OnNavigate" + text + "#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Slush Rush" + text + "Map", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[3];
				array4[0] = "l";
				array4[0] = text;
				array4[3] = "mdata2";
				array4[2] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[3] = "Enabled";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[8];
			array5[1] = " switched Speed with its target!\r\n";
			array5[0] = text;
			array5[6] = "slp";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[1] = "CombinersUpAlphaBuff";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("System" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "door_4", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x001FF930 File Offset: 0x001FDB30
	public void DFEONCOPCPE(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "OnClick";
		}
		else
		{
			text = ",";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[2];
		array[0] = "pickpocket";
		array[1] = text;
		array[6] = "What Pokémon will hatch from this Egg? It doesn't seem close to hatching.";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[6] = "blank";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[4] = "User";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[0] = "Delta Stream";
		array2[0] = text;
		array2[8] = "14.5 17\n14 17\n14 20\n7 20\n\n7 26\n7 30\n2 30\n2 26";
		array2[4] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[2] = "Motor Drive";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[7];
		array3[0] = " shared its power with the target!\r\n";
		array3[1] = text;
		array3[0] = "-primal";
		array3[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[6] = "[-] was disabled!\r\n";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[-] back!\r\n" + text + "pacman", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("/" + text + "hail", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[7];
				array4[0] = "´";
				array4[1] = text;
				array4[0] = "Damages the attacker if it contacts the Pokémon with a finishing hit.";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[3] = "StopRow1";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[]
			{
				"runaway",
				text,
				null,
				null,
				null,
				null,
				null,
				"-"
			};
			array5[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[5] = "p";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("QMECFKNPOGJ" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "_VelocityTex", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x001FFC38 File Offset: 0x001FDE38
	public void MJNQFGMQFEQ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Disabled";
		}
		else
		{
			text = "][/itm] ";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[]
		{
			"Aurora Veil made "
		};
		array[0] = text;
		array[7] = "'s Drizzle made it rain!";
		array[8] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[2] = "*";
		array[6] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[7] = "RightS";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[0] = "JOFLHFQQCKG";
		array2[1] = text;
		array2[2] = "[/c]";
		array2[7] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "_ReflectionTex";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[8];
		array3[1] = "/4";
		array3[0] = text;
		array3[3] = "longreach";
		array3[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[6] = "_FogDistance";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Powers up special attacks when the Pokémon is burned.", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Mounts/" + text + "Could not connect to Server..", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Gravity returned to normal!\r\n" + text + "[pok=", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[0];
				array4[0] = "minior";
				array4[0] = text;
				array4[2] = "Dig";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "Motion Blur";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[4];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[0];
			array5[1] = "_TileVRT";
			array5[0] = text;
			array5[6] = "[ATK]";
			array5[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[2] = "Overall Offset";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("aa" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "[", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[6].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041AB RID: 16811 RVA: 0x001FFF40 File Offset: 0x001FE140
	public void HFMLDHINKJO(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "sketch";
		}
		else
		{
			text = "Enabled";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[7];
		array[0] = "Effect Spore";
		array[0] = text;
		array[3] = "p";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[3] = "Knuckle Badge";
		array[1] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "M3";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[7];
		array2[1] = "'s [ffff00]";
		array2[1] = text;
		array2[4] = ")";
		array2[5] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = " has no Animation component";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Reckless", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)6)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("(Y)" + text + "ReflecG", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[-]" + text + "merciless", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[5];
				array3[1] = "Sweet Scent";
				array3[1] = text;
				array3[0] = "-mega-x";
				array3[3] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[0] = "_ColorMul";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[7];
			array4[1] = "Enabled";
			array4[1] = text;
			array4[1] = "Teleport to the last Pokémon Center or healing place visited.\n\n[2ecc71]Left Click to use this.[-]";
			array4[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[0] = " failed to learn the move ";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("mdata" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "Party", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 1; i += 0)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[7].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x0020023C File Offset: 0x001FE43C
	public void NPBOJJOKEME(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Fly";
		}
		else
		{
			text = "CombinersArgsColorSrc0";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[4];
		array[1] = "[00EE00]";
		array[1] = text;
		array[8] = "Muted";
		array[3] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[5] = "colorchange";
		array[5] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[5] = "_MainTex";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[2];
		array2[0] = "pressure";
		array2[1] = text;
		array2[8] = "_FogPointLightColor0";
		array2[5] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[5] = "Score: ";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("_LogLut_Params", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("_" + text + "'s [ffff00]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("General" + text + "[00DD00]Equipped", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[8];
				array3[1] = " for [PD]";
				array3[1] = text;
				array3[7] = "/";
				array3[5] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[8] = "game.poke.one";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[4];
			array4[0] = "PM: ";
			array4[1] = text;
			array4[8] = " Lvl:";
			array4[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[2] = "You used Sweet Scent recently and are unable to use it again.";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("kg" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "'s taunt wore off!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 4; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[6].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x00200538 File Offset: 0x001FE738
	public void COIMFDQIOKL(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.BEKHPOHIPDE();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "English";
		}
		else
		{
			text = "CombinersArgsAlphaOp1";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[5];
		array[1] = "JOFLHFQQCKG";
		array[1] = text;
		array[4] = "[";
		array[0] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[3] = "OnPress";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "ironbarbs";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[0];
		array2[1] = "skydrop";
		array2[0] = text;
		array2[1] = "Battle Update: ";
		array2[7] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[8] = "-noMouse";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[4];
		array3[1] = "'s ";
		array3[1] = text;
		array3[4] = "Active events: ";
		array3[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[4] = "Slots_4";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("When its HP becomes half or less, the Pokémon's shell breaks and it becomes aggressive.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Music" + text + "_Cutoff", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("flareboost" + text + " fell", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[5];
				array4[1] = "<|>";
				array4[0] = text;
				array4[6] = "firelamp";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[1] = "NT";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[4];
			array5[0] = "_ChannelMixerRed";
			array5[0] = text;
			array5[2] = "\r\n";
			array5[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[8] = "Early Bird";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("berry_16" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "Guild Name", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[0].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041AE RID: 16814 RVA: 0x00200840 File Offset: 0x001FEA40
	public void LQFDMHPELCJ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Busted";
		}
		else
		{
			text = "Connection Established..";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[8];
		array[1] = "Camera Window";
		array[1] = text;
		array[5] = "M3";
		array[0] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[6] = "Sweet Scent";
		array[0] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[3] = "[FFFFFF][";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[3];
		array2[1] = "Protects the Pokémon from recoil damage.";
		array2[1] = text;
		array2[7] = "furcoat";
		array2[0] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[1] = " surrounded itself with a veil of petals!\r\n";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[3];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[8];
		array3[1] = "s Lucky Chant wore off!\r\n";
		array3[1] = text;
		array3[8] = "2";
		array3[6] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[8] = "'s stat changes were inverted!\r\n";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("missingno.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("You were kicked from the Party." + text + "1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("ability" + text + "rocksmash", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[4];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[0];
				array4[1] = "[PD]";
				array4[0] = text;
				array4[7] = "Reset EVs";
				array4[6] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "castformsunny";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[7];
			array5[1] = "[00EE07]";
			array5[1] = text;
			array5[6] = "rebound";
			array5[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[7] = "[^0-9.-]";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.NMPCLCEQJMP(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("](" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "All status conditions heal when the Pokémon switches out.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[0].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x00200B48 File Offset: 0x001FED48
	public void LIDHPLOIFNP(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "]";
		}
		else
		{
			text = " was poisoned";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[1] = "Disguise";
		array[0] = text;
		array[1] = "Assets/Media/Bundle_Items/";
		array[4] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[3] = "Up";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "It's not very effective";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[0];
		array2[1] = "Weak Armor";
		array2[1] = text;
		array2[1] = "Fast Ball";
		array2[6] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[2] = "s";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[]
		{
			null,
			"%"
		};
		array3[0] = text;
		array3[6] = "NPC";
		array3[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[7] = "F14";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("focusband", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)7)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("/" + text + ",", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("\n" + text + "_ClipRange4", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[1];
				array4[1] = "[";
				array4[1] = text;
				array4[0] = "Pokeball_Break";
				array4[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[5] = "_";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[3];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[1];
			array5[1] = "battlearmor";
			array5[0] = text;
			array5[3] = "None";
			array5[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[2] = ":";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("_SSRMultiplier" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "Slots_5", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[6].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x00200E50 File Offset: 0x001FF050
	public void FDEDICFQNEJ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "qTrack";
		}
		else
		{
			text = "The Pokémon is suffering from insomnia and cannot fall asleep.";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[6];
		array[1] = "Health prolongs life";
		array[0] = text;
		array[6] = "Static";
		array[5] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[7] = "WATER_REFRACTIVE";
		array[3] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[4] = "Chromatic Aberration Spectrum Lookup";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[5];
		array2[1] = "_";
		array2[0] = text;
		array2[5] = "[^a-zA-Z0-9_.]+";
		array2[1] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[1] = "_1";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("desolateland", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("_ReflectionColor" + text + "A", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Chat Box" + text + "#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[7];
				array3[1] = "!\r\n";
				array3[0] = text;
				array3[2] = "RenderType";
				array3[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[8] = "aa";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[3];
			array4[0] = "whirlpool";
			array4[1] = text;
			array4[5] = "Take 001";
			array4[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[2] = "[PD]";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("#,##0" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "gray", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 0; i < 7; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[2].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x0020114C File Offset: 0x001FF34C
	public void HPGELNGEGPM(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "[/u][/url]";
		}
		else
		{
			text = "Materials/DFODesktopPlus";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[8];
		array[1] = "[ATK]";
		array[1] = text;
		array[5] = "slowstart";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "flyLimit";
		array[1] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "[weak]";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[0] = "Sprite";
		array2[1] = text;
		array2[5] = "ffffff";
		array2[6] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[2] = "[-] has come online.";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[7];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[7];
		array3[0] = "Num";
		array3[0] = text;
		array3[6] = "Small/";
		array3[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[3] = "3";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("-singlemove", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("_History3Weight" + text + "_FogColor2", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Simulated Lag: " + text + "[5cd65c]Social", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[7];
				array4[0] = "[/pok]";
				array4[0] = text;
				array4[5] = "Oozed liquid has strong stench, which damages attackers using any draining move.";
				array4[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[0] = "strength";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[5];
			array5[1] = "[mythical]";
			array5[0] = text;
			array5[7] = " ";
			array5[6] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[6] = "Applying a new Guild Logo will cost [PG]300.\n\nAre you sure you want to do this?\nInappropriate images drawn will result in account termination.";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("_DestortionShiftX" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "Head", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[0].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x00201454 File Offset: 0x001FF654
	public void HOFCKQELDLF(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "BuffIcon_EncounterRateLowered";
		}
		else
		{
			text = "[o]";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[1] = "I";
		array[0] = text;
		array[1] = "Speedy Babies";
		array[8] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[0] = "The [ffff00]";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[3] = "Battle";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[0] = "May poison a target when the Pokémon makes contact.";
		array2[1] = text;
		array2[0] = " drastically";
		array2[6] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = "Emergency Exit";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" is tightening its focus!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[FF0000]-" + text + "Player/Clothe", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" days" + text + "adjacentFoe", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[]
				{
					null,
					"Coal Badge"
				};
				array3[1] = text;
				array3[5] = "Forward Focus";
				array3[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[5] = " ate its [ffff00]";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[0] = "flowerveil";
			array4[0] = text;
			array4[6] = "/";
			array4[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[2] = "bcam";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("cutecharm" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "berry_15", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 6; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[2].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x00201750 File Offset: 0x001FF950
	public void PHJCHPCPLCJ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Aargh! Almost had it!\r\n";
		}
		else
		{
			text = "Are you sure you wish to let ";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[5];
		array[0] = "#,##0";
		array[0] = text;
		array[1] = "Kanto";
		array[1] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "Boosts the Sp. Atk stat sharply when a stat is lowered.";
		array[6] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[8] = ".";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[6];
		array2[1] = "Icon_Pokemon_Alive";
		array2[0] = text;
		array2[4] = "VFMDepthSunCamera";
		array2[1] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[5] = "gold=";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[]
		{
			null,
			"_Dissolve"
		};
		array3[1] = text;
		array3[2] = "LJMOLEKDCLP";
		array3[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[2] = "13";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("TM", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)8)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("/Model_S.prefab" + text + "VFMDepthCamera", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("p" + text + " finally got its act together!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[5];
				array4[1] = "Players: ";
				array4[1] = text;
				array4[0] = "Player/Body";
				array4[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[6] = "Player Information";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[]
			{
				"\r\nDEF"
			};
			array5[0] = text;
			array5[2] = "(B)";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[1] = "rotomfan";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Icon_Pokemon_Alive" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "move: ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[0].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041B4 RID: 16820 RVA: 0x00201A58 File Offset: 0x001FFC58
	public void BQLIIQIIMDH(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "_Male";
		}
		else
		{
			text = "_Female";
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
		{
			"Player/Body",
			text,
			"/",
			JMDLLJPEFKM.Skin.QQKICQQBIJL(),
			"_",
			JMDLLJPEFKM.Eyes.QQKICQQBIJL(),
			"_1"
		}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
		{
			"Player/Clothe",
			text,
			"/",
			GBQOIGLGLMI.Clothe.QQKICQQBIJL(),
			"_1"
		}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
		{
			"Player/Hair",
			text,
			"/",
			JMDLLJPEFKM.Hair.QQKICQQBIJL(),
			"_1"
		}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text + "/01_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text + "/03_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Hair",
					text,
					"/",
					JMDLLJPEFKM.Hair.QQKICQQBIJL(),
					"_1"
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
			{
				"Player/Hair",
				text,
				"/",
				JMDLLJPEFKM.Hair.QQKICQQBIJL(),
				"_1"
			}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hats/" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[2].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x00201D60 File Offset: 0x001FFF60
	public void PBEFGBBHKPH(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "\"";
		}
		else
		{
			text = "Upgrade Pokébox";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[]
		{
			"MSGBOX - "
		};
		array[0] = text;
		array[7] = "[{";
		array[1] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[7] = " and found it's ";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[3] = " ";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[0] = "OnDrag";
		array2[1] = text;
		array2[3] = "Unable to add ";
		array2[7] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[7] = "'s Pokémon";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Net Ball", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)7)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("But it failed!\r\n" + text + "stickyhold", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[pok=" + text + "_Tile2RT", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[8];
				array3[0] = "Player/Clothe";
				array3[0] = text;
				array3[4] = "_Cutoff";
				array3[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[4] = "\n[29e000]Friendly Pokémon";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[4];
			array4[1] = "NPC/Sprite";
			array4[0] = text;
			array4[2] = "#,##0";
			array4[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "Take 001";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("HidePanel" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "Blade", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 2; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[8].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041B6 RID: 16822 RVA: 0x0020205C File Offset: 0x0020025C
	public void ONNDNJHJNPI(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "dazzling";
		}
		else
		{
			text = "mistysurge";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[6];
		array[0] = "Fitter Line";
		array[1] = text;
		array[7] = "BuffIcon_EncounterRateLowered";
		array[8] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[3] = "Bg_SocialStatus_Offline";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[1] = "_FogPointLightPosition1";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[0] = "Player/Mounts/";
		array2[1] = text;
		array2[5] = "OnScroll";
		array2[7] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[0] = "[ATK]";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Stop", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI(" x " + text + "-mega-y", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Prevents status conditions in sunny weather." + text + "Button", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[7];
				array3[1] = "Close";
				array3[0] = text;
				array3[4] = "_Vignette_Color";
				array3[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[2] = "_Texture0";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[0];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[0] = "Effort Values[FFFF00] (";
			array4[0] = text;
			array4[6] = "!\r\n";
			array4[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[6] = "Fly can be used to travel to significant places you have visited.\n\n[2ecc71]Left Click to use this.[-]";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("!\r\n" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "_InvGamma", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 0; i < 2; i++)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[1].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041B7 RID: 16823 RVA: 0x00202358 File Offset: 0x00200558
	public void EEOOPJNPMPJ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Icon_Achievement_Incomplete";
		}
		else
		{
			text = "u";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[4];
		array[0] = " recieved [ffff00]";
		array[0] = text;
		array[0] = ".";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[1] = "17";
		array[0] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[2] = "General";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[0] = "\n[PG]";
		array2[1] = text;
		array2[5] = "[00FF00]You received [PG]";
		array2[4] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[4] = "Are you sure you wish to let ";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[8];
		array3[1] = "[";
		array3[0] = text;
		array3[7] = "b";
		array3[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[0] = "Normalize";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(".", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("FOG_AREA_SPHERE" + text + " copied ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("_HairTex" + text + "dryskin", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[2];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[2];
				array4[0] = "Bicycle";
				array4[0] = text;
				array4[8] = "#,##0";
				array4[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[6] = "OnPress";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[4];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[0];
			array5[0] = "egg";
			array5[0] = text;
			array5[3] = "/0";
			array5[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[0] = "Fog";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.NMPCLCEQJMP(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("^emote+" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "Run_White", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[1].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041B8 RID: 16824 RVA: 0x00202660 File Offset: 0x00200860
	public void LCCQBMMFONQ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Love Ball";
		}
		else
		{
			text = ":";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[2];
		array[0] = ".\r\n";
		array[1] = text;
		array[8] = "_Dissolve";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[1] = "Assets/AssetBundles/Pokes";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[7] = "refrigerate";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[7];
		array2[0] = "ReflecG";
		array2[0] = text;
		array2[0] = "Open";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[7] = " Lv. ";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("_SampleScale", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Could not connect to Server.." + text + "Enabled", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(")[-]" + text + "scald", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[3];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[3];
				array3[1] = "replace";
				array3[0] = text;
				array3[0] = "'s encore ended!\r\n";
				array3[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[0] = "blank";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[4];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[0];
			array4[0] = "Sound";
			array4[0] = text;
			array4[3] = "Connecting to Server..";
			array4[8] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[2] = "]#";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(" became cloaked in a harsh light!\r\n" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "_", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 3; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[3].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041B9 RID: 16825 RVA: 0x0020295C File Offset: 0x00200B5C
	public void EHOONGNHQEQ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Technician";
		}
		else
		{
			text = "Boosts its Sp. Atk stat every time a Pokémon faints.";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[0] = "L";
		array[0] = text;
		array[6] = "Aerodactyl";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[0] = "Enter a name for your New Tab.";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[8] = "UnityEngine.";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[1] = "[pok=";
		array2[0] = text;
		array2[3] = "fairylock";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[3] = "General";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("WATER_SIMPLE", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" switched items with its target!\r\n" + text + " closed the Chat Window.", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("_DebugWidth" + text + "BuffIcon_MaleIncrease", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[8];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[8];
				array3[0] = "Dist1";
				array3[0] = text;
				array3[7] = "s Lucky Chant wore off!\r\n";
				array3[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[3] = "_FogColor2";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[0];
			array4[0] = "[-]";
			array4[1] = text;
			array4[8] = "/";
			array4[1] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[1] = "[/U]";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Die" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "TabSettings", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 1; i < 1; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[1].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x00202C58 File Offset: 0x00200E58
	public void KEHBPLMFDIP(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_1";
		}
		else
		{
			text = "less than 1 minute ago";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[2];
		array[0] = "\nNight";
		array[0] = text;
		array[1] = "CombinersAlphaScale";
		array[2] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[4] = "Fishing Bites occur more often";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[1] = "_ClipDir";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[6];
		array2[1] = "brn";
		array2[1] = text;
		array2[2] = "-";
		array2[0] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[8] = "1_";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI(" is protected by Safeguard!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Packed" + text + "sdata", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Party Request" + text + "|", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[3];
				array3[1] = "perish0";
				array3[1] = text;
				array3[1] = "[ATK]";
				array3[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[3] = "Slot Machine";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[1] = " cured its poison!\r\n";
			array4[0] = text;
			array4[2] = "14";
			array4[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[0] = "ProCamera2D does not have a Shake extension.";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("item: " + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "music(", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 7; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[2].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041BB RID: 16827 RVA: 0x00202F54 File Offset: 0x00201154
	public void DEPHJMJBIPE(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "[/C]";
		}
		else
		{
			text = ".";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[1] = ",";
		array[0] = text;
		array[6] = "'s can't use [ffff00]";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[4] = "The [ffff00]";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "Base Stats\n[d9b38c]ATK:[-] ";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[0];
		array2[1] = "_Jitter";
		array2[0] = text;
		array2[5] = "Fog";
		array2[3] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[8] = "mimikyubusted";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[pok=", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(". " + text + "_Dissolve", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Anger Point" + text + "Stop", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[0];
				array3[1] = "battlebag";
				array3[1] = text;
				array3[4] = "The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.";
				array3[3] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[3] = "00";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[2];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[8];
			array4[0] = "Lv ";
			array4[0] = text;
			array4[3] = "_DetailOffsetY";
			array4[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[4] = "Disguise";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("BuffIcon_Surf" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "[u][33CCFF]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 1; i < 6; i += 0)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x00203250 File Offset: 0x00201450
	public void FQFIFPGJDBE(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_Bloom_DirtTex";
		}
		else
		{
			text = "[-]!\r\n";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[1] = "berry_17";
		array[0] = text;
		array[1] = "[-]!\r\n";
		array[2] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[6] = "weakarmor";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[7] = "VolumetricFogAndMist/Blur";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[1] = "[33ccff]Lv. ";
		array2[1] = text;
		array2[7] = "The Pokémon shows moxie, and that boosts the Attack stat after knocking out any Pokémon.";
		array2[4] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[3] = "Dolly zooming is only supported on perspective cameras";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("It's A Nice Day For Fishing", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI(" learned " + text + "|0|", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("recharge" + text + "]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[3];
				array3[0] = "Pixilate";
				array3[0] = text;
				array3[3] = "WATER_REFRACTIVE";
				array3[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[7] = "Assets/AssetBundles/MapAssets/Models/Mansion/Materials/com_chip_mado1.mat";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[0] = "[-]";
			array4[0] = text;
			array4[8] = "minior";
			array4[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[8] = " became cloaked in freezing air!\r\n";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("!\r\n" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "recharge", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 0; i++)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x0020354C File Offset: 0x0020174C
	public void MIEHJOOLEHC(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = " Seconds.";
		}
		else
		{
			text = "compoundeyes";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[4];
		array[1] = "ghost";
		array[0] = text;
		array[6] = "/guild ";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[7] = "sandstorm";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[1] = "receiver";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[]
		{
			null,
			" Obtained "
		};
		array2[1] = text;
		array2[4] = "+";
		array2[1] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[2] = "Moderator";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("wonderroom", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("darmanitan" + text + "Kick", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("BuffIcon_MuteIcon" + text + "#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[0];
				array3[0] = " shared its power with the target!\r\n";
				array3[1] = text;
				array3[1] = "map";
				array3[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[2] = "Sniper";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[1] = "watercompaction";
			array4[1] = text;
			array4[1] = "Username can only contain 3 capitals";
			array4[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "But it failed.\r\n";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("ResolutionX" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "mudsport", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 0; i < 5; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[0].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x00203848 File Offset: 0x00201A48
	public void CLMGPMLLIDN(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "general";
		}
		else
		{
			text = "3";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[0] = "d";
		array[1] = text;
		array[0] = "[7fff49]";
		array[5] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[6] = "Simple";
		array[3] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "\n";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[0] = "Searching..";
		array2[1] = text;
		array2[7] = "Direct3D";
		array2[7] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[7] = " unleashed its energy!\r\n";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("enablelink(", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("[u][33CCFF]" + text + "[ffff00]Quick Guard[-] protected ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("darkaura" + text + "Clr", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[8];
				array3[1] = "Male Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]";
				array3[0] = text;
				array3[7] = "´";
				array3[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[4] = "'s attack missed!\r\n";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[6];
			array4[1] = "The sunlight faded.";
			array4[1] = text;
			array4[4] = "WATER_VERTEX_DISPLACEMENT_OFF";
			array4[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "-useTouch";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" Lvl:" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 3; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[0].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x00203B44 File Offset: 0x00201D44
	public void BLFPCGEIDNL(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "swap";
		}
		else
		{
			text = "Left";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[8];
		array[1] = "pdata";
		array[0] = text;
		array[0] = "stormdrain";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[4] = "/";
		array[8] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[8] = "b";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[0];
		array2[1] = "scripted";
		array2[1] = text;
		array2[5] = "AlwaysRain";
		array2[1] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[1] = "Hidden/Post FX/Screen Space Reflection";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("shadowforce", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("flamebody" + text + "pdata", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("taunt" + text + "[^a-zA-Z0-9]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[3];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[]
				{
					null,
					"_1"
				};
				array3[1] = text;
				array3[5] = "Test Message: ";
				array3[4] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[2] = "_VolumetricFogSunProj";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[4];
			array4[1] = ", ";
			array4[1] = text;
			array4[6] = "MSGBOX - Shop";
			array4[1] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[2] = "Small/9999";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("17" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "_Offset", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 0; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[1].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x00203E40 File Offset: 0x00202040
	public void BICQHMIPHJM(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "2.6.3";
		}
		else
		{
			text = "The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[1];
		array[1] = "-enditem";
		array[1] = text;
		array[7] = "The Pokémon copies the Ability of a defeated ally.";
		array[7] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[2] = "_FogDither";
		array[1] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "_Intensity";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[0];
		array2[0] = " is no longer protected by mist!\r\n";
		array2[0] = text;
		array2[1] = "tangledfeet";
		array2[4] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[4] = "\r\n";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[1];
		array3[0] = " (ID:";
		array3[1] = text;
		array3[4] = "ingrain";
		array3[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[3] = " and ";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("-", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("/" + text + "[-]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Sandy" + text + "Frisk", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[4];
				array4[1] = "_SampleCount";
				array4[1] = text;
				array4[5] = "Join Channel";
				array4[2] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[0] = "Mineral Badge";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[5];
			array5[0] = "Rails";
			array5[0] = text;
			array5[5] = "mummy";
			array5[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[1] = "Username already in use";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Shift" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "VolumetricFogAndMist/CopyDepth", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[3].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x00204148 File Offset: 0x00202348
	public void PEHHOQIHMKP(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = " calmed down.\r\n";
		}
		else
		{
			text = "Raises evasion if the Pokémon is confused.";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[0];
		array[0] = "Take 001";
		array[0] = text;
		array[4] = "Player/Mounts/";
		array[8] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "Battle";
		array[3] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[3] = "gray";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[3];
		array2[1] = "Horizontal";
		array2[0] = text;
		array2[6] = "psn";
		array2[3] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[4] = "Prevents itself and ally Pokémon from falling asleep.";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[0];
		array3[0] = "typechange";
		array3[0] = text;
		array3[4] = "Shields Down";
		array3[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[3] = "[33CCFF][Time of Day][-]";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("The Pokémon can't use any held items.", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)6)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("ResolutionX" + text + "WATER_SIMPLE", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("[ATK]" + text + "electric", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[3];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[6];
				array4[1] = "ability";
				array4[0] = text;
				array4[5] = "Enabled";
				array4[2] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "_MainTex";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[7];
			array5[1] = "Friend Request";
			array5[1] = text;
			array5[8] = "HidePanel";
			array5[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[8] = "superluck";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("#,##0" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "SetVolumeBack", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[1].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x00204450 File Offset: 0x00202650
	public void EDKDPDKIBJN(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "HidePanel";
		}
		else
		{
			text = "m_TangentMode";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[4];
		array[0] = "22 20\n22 26\n\n27 26\n27 30\n22 30\n22 26";
		array[0] = text;
		array[1] = "Damages the attacker if it contacts the Pokémon with a finishing hit.";
		array[0] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[3] = "Party";
		array[6] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[4] = "speedboost";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[5];
		array2[0] = "d";
		array2[1] = text;
		array2[3] = "General";
		array2[3] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "Take 001";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[8];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[5];
		array3[1] = "300";
		array3[1] = text;
		array3[8] = "deltastream";
		array3[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[7] = "Hidden/Post FX/Builtin Debug Views";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("split", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("][/itm] " + text + "HideResponse", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("Rails extension couldn't be found on ProCamera2D. Please enable it to use this trigger." + text + "Script:", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[8];
				array4[1] = "[ATK]";
				array4[0] = text;
				array4[6] = "_Direction";
				array4[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "#PGSEONEp0k326783&^@#dgg4G@$W";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[3];
			array5[1] = "UpS";
			array5[1] = text;
			array5[8] = "Muted";
			array5[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[4] = "Powers up Grass-type moves when the Pokémon's HP is low.";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.NMPCLCEQJMP(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("start" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "\n  Received: ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[7].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x00204758 File Offset: 0x00202958
	public void EJJBDNMPFIM(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.BEKHPOHIPDE();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "burmy";
		}
		else
		{
			text = "[^a-zA-Z0-9]";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[1];
		array[0] = "Synchronize";
		array[1] = text;
		array[0] = "The battlers shared their pain!\r\n";
		array[4] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "]";
		array[4] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[5] = "sound(";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[1] = "Battle";
		array2[1] = text;
		array2[0] = "[33ccff]TMs[-]";
		array2[8] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[5] = "Adaptability";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[4];
		array3[0] = "[^a-zA-Z0-9]";
		array3[1] = text;
		array3[5] = "AFK";
		array3[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[8] = "spectralthief";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Mouse ScrollWheel", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)7)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Chance for same Nature" + text + "_RayStepSize", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("stickyweb" + text + "-mustrecharge", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[6];
				array4[1] = "Oozed liquid has strong stench, which damages attackers using any draining move.";
				array4[1] = text;
				array4[4] = "0";
				array4[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[6] = "Player/Hair";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[0];
			array5[0] = " declined the Guild Request.";
			array5[1] = text;
			array5[7] = "u";
			array5[6] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[0] = "_Texture0";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" " + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "[of]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[4].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x00204A60 File Offset: 0x00202C60
	public void QKCOIIKFPKG(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Sound";
		}
		else
		{
			text = " surrounded itself with a veil of water!\r\n";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[]
		{
			null,
			"^emote+"
		};
		array[1] = text;
		array[8] = "Forward Focus";
		array[8] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[5] = "attract";
		array[1] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[5] = "RightS";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[1] = "17";
		array2[0] = text;
		array2[7] = "Battle";
		array2[8] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = "_1";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("_FogSkyData", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("!\r\n" + text + "Egg", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI(" restored its HP!\r\n" + text + "'s [ffff00]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[4];
				array3[0] = "Halves the damage from physical moves.";
				array3[0] = text;
				array3[5] = "][-] [00CCFF]";
				array3[8] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[6] = "\r\nHP";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[0];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[3];
			array4[0] = "0";
			array4[0] = text;
			array4[4] = " disappeared!\r\n";
			array4[1] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "When used inside of a cave or certain buildings, you will be transported to the last entrance you used.\n\n[2ecc71]Left Click to use this.[-]";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("_1" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "gold=", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 3; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[8].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041C5 RID: 16837 RVA: 0x00204D5C File Offset: 0x00202F5C
	public void BQLIIQIIMDH(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.QOQONHOOLNE;
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_Male";
		}
		else
		{
			text = "_Female";
		}
		this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
		{
			"Player/Body",
			text,
			"/",
			BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
			"_",
			BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
			"_1"
		}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
		{
			"Player/Clothe",
			text,
			"/",
			BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL(),
			"_1"
		}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text + "/01_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text + "/03_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Hair",
					text,
					"/",
					BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
					"_1"
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
			{
				"Player/Hair",
				text,
				"/",
				BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
				"_1"
			}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hats/" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 4; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[2].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041C6 RID: 16838 RVA: 0x00205058 File Offset: 0x00203258
	public void FDDENOHPGQF(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Dive Ball";
		}
		else
		{
			text = "slp";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[7];
		array[1] = " BP";
		array[1] = text;
		array[8] = " transformed into the ";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[7] = "Reduces the power of supereffective attacks taken.";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[5] = "Guild Name: ";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[0] = "Small/";
		array2[0] = text;
		array2[0] = "Score: ";
		array2[0] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[7] = "Boosts the Pokémon's evasion in a sandstorm.";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("HidePanel", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("d" + text + "Purchasing Costume", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("shelltrap" + text + "Purchase Costume", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[2];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[6];
				array3[1] = "Battle";
				array3[1] = text;
				array3[5] = "The Pokémon is protected by its white smoke, which prevents other Pokémon from lowering its stats.";
				array3[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[2] = "[00]";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[2];
			array4[0] = "Assets/AssetBundles/MapAssets/Model Materials/ShortCut_Window.mat";
			array4[0] = text;
			array4[0] = "_ClipRange0";
			array4[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[0] = "Hidden/Post FX/Uber Shader";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("[BATTLE]" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + ",", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 0; i < 7; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[0].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041C7 RID: 16839 RVA: 0x00205354 File Offset: 0x00203554
	public void QNJHMCKNJIK(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.BEKHPOHIPDE();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = ")";
		}
		else
		{
			text = "2";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[8];
		array[1] = " shared its power with the target!\r\n";
		array[1] = text;
		array[6] = "'s electromagnetism wore off!\r\n";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[5] = "[-] let it move first!\r\n";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[0] = "More Bites!";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[1] = "OnLongPress";
		array2[0] = text;
		array2[1] = "_ReflectionBlur";
		array2[4] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[2] = "Slots_9";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[4];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[7];
		array3[0] = "Create Guild";
		array3[1] = text;
		array3[7] = "ACC: -";
		array3[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[3] = "Zubat";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("symbiosis", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("'s protection!\r\n" + text + "aa", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Wimp Out" + text + "[-] was disabled!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[8];
				array4[1] = "flameburst";
				array4[0] = text;
				array4[5] = "CombinersColorScale";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[2] = "Purchasing Costume";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[6];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[8];
			array5[1] = "_DetailScaleY";
			array5[1] = text;
			array5[0] = "You sense the presence of many!\r\n";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[2] = "Join Channel";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("\n\n[2ecc71]Right Click to Cancel this Buff.[-]" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "_History2ChromaTex", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041C8 RID: 16840 RVA: 0x0020565C File Offset: 0x0020385C
	public void KDCHGCMPDLJ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.BEKHPOHIPDE();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "1_";
		}
		else
		{
			text = "CombinersAlphaPassThrough";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[]
		{
			"[d9b38c]Message"
		};
		array[0] = text;
		array[4] = "dig";
		array[0] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[2] = "Invite to Party";
		array[4] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[2] = "_1";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[3];
		array2[0] = "_MainTex";
		array2[1] = text;
		array2[2] = "B";
		array2[4] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[0] = "sdata";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("X2", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("sapsipper" + text + "Cloud Nine", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("\nRank: " + text + "slowstart", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[8];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[4];
				array3[0] = "magician";
				array3[0] = text;
				array3[1] = "'";
				array3[7] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[5] = " is in love with ";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[8];
			array4[1] = " left the Party.";
			array4[0] = text;
			array4[0] = " obtained one [ffff00]";
			array4[5] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[7] = "[00]";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("moldbreaker" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "16.5 17\n15 17\n15 20\n22 20\n\n22 8\n19 8\n19 5\n16 5\n16 2\n27 2\n27 5\n22 5", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 1; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[8].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041CA RID: 16842 RVA: 0x00205958 File Offset: 0x00203B58
	public void OJIBNMPCFBQ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Take 001";
		}
		else
		{
			text = "[/pok]";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[7];
		array[1] = "Login";
		array[0] = text;
		array[4] = "Assets/AssetBundles/MapAssets2/Models/Materials/com_c02_mado0.mat";
		array[6] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[3] = "Blank";
		array[0] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[2] = "_History1ChromaTex";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[0] = "status: ";
		array2[1] = text;
		array2[5] = "rotomfan";
		array2[0] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "Battle";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[2];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[4];
		array3[1] = "_";
		array3[0] = text;
		array3[7] = "'?";
		array3[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[8] = "\r\n";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP(" x ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("NT" + text + "CombinersArgsAlphaOp1", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("normal" + text + "0", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[2];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[8];
				array4[1] = "thickfat";
				array4[0] = text;
				array4[0] = " flinched and couldn't move!\r\n";
				array4[5] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[0] = "dots";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[2];
			array5[0] = "[ATK]";
			array5[0] = text;
			array5[0] = "Liquid Voice";
			array5[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[8] = "Slots_3";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.CPFJEOGMHOD(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("bug" + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "MSGBOX - Confirm EVs", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[2].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041CB RID: 16843 RVA: 0x00205C60 File Offset: 0x00203E60
	public void MDFGEPJEJCQ(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "+";
		}
		else
		{
			text = "Administrator";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[1];
		array[1] = "Passwords do not match";
		array[1] = text;
		array[3] = "Temp Sound Clip";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[4] = "mummy";
		array[8] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[7] = "Zapdos";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[1] = "Powers up physical attacks when the Pokémon is poisoned.";
		array2[1] = text;
		array2[8] = "l";
		array2[5] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[1] = "[SHINY]";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[1];
		array3[0] = "input";
		array3[1] = text;
		array3[7] = "Battle_Wild";
		array3[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[7] = "Crit increases the chance of landing a critical strike";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("_ScreenEdgeFading", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Boosts the Pokémon's Speed stat in a sandstorm." + text + "Restores HP if the Pokémon is poisoned, instead of losing HP.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("StopRow3" + text + "CombinersArgsColorSrc2", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[7];
				array4[0] = "MissingNo.";
				array4[1] = text;
				array4[8] = "shadowforce";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "'s ";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[7];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[8];
			array5[1] = "AFK";
			array5[1] = text;
			array5[1] = "P. ";
			array5[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[1] = "o";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("]" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + " is to heavy to be lifted!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[2].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041CC RID: 16844 RVA: 0x00205F68 File Offset: 0x00204168
	public void CQKHIPOLJNL(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "liquidvoice";
		}
		else
		{
			text = "pickpocket";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[0] = "HidePanel";
		array[1] = text;
		array[6] = "http://poke.one/terms.html";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[8] = "skinshop";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[7] = "_DepthOfFieldParams";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[6];
		array2[0] = "14";
		array2[1] = text;
		array2[1] = " was poisoned";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[4] = "WATER_EDGEBLEND_ON";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("wonderguard", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Teleport" + text + "_WorldLightDir", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("electricterrain" + text + "0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[4];
				array3[1] = "Pixel Perfect";
				array3[1] = text;
				array3[6] = "slp";
				array3[1] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[7] = "slp";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[5];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[3];
			array4[1] = "_ReflectionTex";
			array4[1] = text;
			array4[7] = "|";
			array4[3] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[0] = "Mute";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Empty Slot" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "wonderguard", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		for (int i = 1; i < 6; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[4].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x060041CD RID: 16845 RVA: 0x00206264 File Offset: 0x00204464
	public void OEJDMOMEKGC(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Sweet Scent";
		}
		else
		{
			text = "i";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[3];
		array[1] = "'s protections!\r\n";
		array[0] = text;
		array[5] = "[/c]";
		array[2] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[8] = "WATER_EDGEBLEND_OFF";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "[ff4949]";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[1];
		array2[1] = "HideResponse";
		array2[0] = text;
		array2[6] = "Player/Hair_";
		array2[0] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[0] = "NPC";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Pointer Influence", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("gravity" + text + "F5", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[6].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("[33ccff]Lv. " + text + "focuspunch", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[0];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[3];
				array3[1] = "PrimitiveRear";
				array3[1] = text;
				array3[0] = "Blank";
				array3[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[4] = "item";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[]
			{
				null,
				"_FogSkyData"
			};
			array4[1] = text;
			array4[3] = "CombinersAlphaScale";
			array4[6] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "/50 Friends";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[8].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("_Downsample" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "No Animation found for MoveID ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 1; i < 3; i += 0)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[3].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041CE RID: 16846 RVA: 0x00206560 File Offset: 0x00204760
	public void JKHJPEFINFL(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Current Region:";
		}
		else
		{
			text = "Upgrade Pokébox";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[0];
		array[0] = "Infiltrator";
		array[0] = text;
		array[6] = "[-]\n\n";
		array[8] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "Lv";
		array[2] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[0] = "Boosts the Attack stat, but lowers accuracy.";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[0] = " would like to Battle with you. Do you wish to Battle?";
		array2[0] = text;
		array2[5] = "_Female";
		array2[5] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[5] = "Level Ups:";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[2];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[0];
		array3[0] = "[00EE07]";
		array3[0] = text;
		array3[7] = "Power of Alchemy";
		array3[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[0] = " day, ";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("door_1", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)5)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("mist" + text + " Coins", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Hidden/Post FX/Builtin Debug Views" + text + "Purchasing", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[6];
				array4[0] = "MSGBOX - ";
				array4[0] = text;
				array4[3] = "NPC";
				array4[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[7] = "[FF8F00]";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[2];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[4];
			array5[1] = "Party Request";
			array5[0] = text;
			array5[6] = ".";
			array5[4] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[7] = "[/u][/url]";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("0" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "!", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[0].CEGFBBHMKOE = this.QIDKBCQIGOD.OFGHDGJBDOL[num];
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x00206868 File Offset: 0x00204A68
	public void LGDBKJFOFOK(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.GGBPGMMCGLI();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.";
		}
		else
		{
			text = "East";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[]
		{
			null,
			" foresaw an attack!\r\n"
		};
		array[1] = text;
		array[7] = "<|>";
		array[7] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[8] = "ability";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[5] = "TM";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[4];
		array2[1] = ".";
		array2[0] = text;
		array2[2] = "I Hope These Don't Land On My Head";
		array2[7] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[6] = "Offline";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[4].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(" is covered in powder!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(" was freed from the Sky Drop!\r\n" + text + "_Male", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("Map" + text + "[u][33CCFF]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[5];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[7];
				array3[1] = "[-]\r\nPP ";
				array3[1] = text;
				array3[7] = "The effects of the weather disappeared.\r\n";
				array3[3] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[8] = " fainted!\r\n";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[0];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[8];
			array4[0] = "pickpocket";
			array4[0] = text;
			array4[5] = "Icon_Status_Burn";
			array4[3] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[7] = "frz";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.GOKLDOEGJHI(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Default" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "[-]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 1; i < 6; i++)
		{
			this.KKJPFIBDNJI[i].NONQDHBCIIN(Color.white);
		}
		this.KKJPFIBDNJI[1].NONQDHBCIIN(BFBMOIKCELJ.KKJPFIBDNJI.material.color);
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x00206B64 File Offset: 0x00204D64
	public void EGKMLKHJCDD(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "Trigger Boundaries";
		}
		else
		{
			text = "(E)";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[1];
		array[1] = "]";
		array[1] = text;
		array[1] = ".";
		array[3] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[2] = "_";
		array[6] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[4] = "Materials/DFGBasic";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[5];
		array2[1] = "You can not trade during interactions or battles.";
		array2[1] = text;
		array2[4] = "Almost As Good As Repel!";
		array2[0] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[1] = "_ClipRange0";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[2];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[8];
		array3[0] = "/0";
		array3[0] = text;
		array3[2] = "b";
		array3[8] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[1] = "0";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 1, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("Lv. ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)8)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[0].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("aromatherapy" + text + "[sub]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("shelltrap" + text + "[", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[]
				{
					"focusband"
				};
				array4[0] = text;
				array4[8] = "Inactive";
				array4[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "'s ";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[8];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[0];
			array5[0] = "When the flame touched the powder on the Pokémon, it exploded!\r\n";
			array5[1] = text;
			array5[7] = "\n";
			array5[7] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[6] = "magnetrise";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("ENABLE_GREEN_CHANNEL" + (GBQOIGLGLMI.Hat - 0).QQKICQQBIJL() + "[c]", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 1;
		}
		this.KKJPFIBDNJI[2].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041D1 RID: 16849 RVA: 0x00206E6C File Offset: 0x0020506C
	public void DFNDGODMFOM(Style JMDLLJPEFKM, Equip GBQOIGLGLMI)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.BEKHPOHIPDE();
		}
		string text = string.Empty;
		if (JMDLLJPEFKM.Gender == Gender.Male)
		{
			text = "-core";
		}
		else
		{
			text = "VolumetricFogAndMist/VolumetricFog";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[0];
		array[0] = "/gkick ";
		array[1] = text;
		array[6] = "[-] back!\r\n";
		array[2] = JMDLLJPEFKM.Skin.QQKICQQBIJL();
		array[8] = "Vertical";
		array[0] = JMDLLJPEFKM.Eyes.QQKICQQBIJL();
		array[8] = "MSGBOX - Move Learning";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[0] = "Oh no! The Pokémon broke free!\r\n";
		array2[1] = text;
		array2[0] = "stancechange";
		array2[8] = GBQOIGLGLMI.Clothe.QQKICQQBIJL();
		array2[7] = "Player/Hair";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
		string[] array3 = new string[1];
		array3[0] = " ";
		array3[1] = text;
		array3[8] = "Enemy's team won the Battle!\r\n";
		array3[1] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
		array3[2] = "electricterrain";
		enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.NMPCLCEQJMP(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (GBQOIGLGLMI.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(GBQOIGLGLMI.Hat - 0, JMDLLJPEFKM.Gender, JMDLLJPEFKM.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				this.KKJPFIBDNJI[2].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("coins=", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (JMDLLJPEFKM.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("aquaring" + text + "Primordial Sea", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.NMPCLCEQJMP("The Pokémon makes it rain when it enters a battle." + text + "lightscreen", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[7];
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[1];
				array4[1] = "-fieldend";
				array4[1] = text;
				array4[1] = "healer";
				array4[0] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
				array4[4] = "Default";
				enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq5 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod5 = this.QIDKBCQIGOD;
			string[] array5 = new string[2];
			array5[0] = "Times Fainted:";
			array5[1] = text;
			array5[6] = "CombinersArgsAlphaOp1";
			array5[3] = JMDLLJPEFKM.Hair.QQKICQQBIJL();
			array5[0] = "p1";
			enfmcdnleqq5.GOIHJQNMMJD = qidkbcqigod5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD(". Using default." + (GBQOIGLGLMI.Hat - 1).QQKICQQBIJL() + "Guild Success", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = JMDLLJPEFKM.HairColor;
		if (JMDLLJPEFKM.HairColor == -1)
		{
			num = 0;
		}
		this.KKJPFIBDNJI[6].NONQDHBCIIN(this.QIDKBCQIGOD.OFGHDGJBDOL[num]);
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x00207174 File Offset: 0x00205374
	public void BFBEIJGQKHJ(DJOOHHIQGJK BFBMOIKCELJ)
	{
		if (this.QIDKBCQIGOD == null)
		{
			this.QIDKBCQIGOD = GFHGEJNHLFQ.MOGQNGEPCEO();
		}
		string text = string.Empty;
		if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "The Pokémon can sense an opposing Pokémon's dangerous moves.";
		}
		else
		{
			text = "!\r\n";
		}
		ENFMCDNLEQQ enfmcdnleqq = this.KKJPFIBDNJI[0];
		GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
		string[] array = new string[2];
		array[0] = "[FFFF00]/252";
		array[0] = text;
		array[7] = "Friend Request";
		array[6] = BFBMOIKCELJ.HDCKEHHFCDN.Skin.QQKICQQBIJL();
		array[3] = " on ";
		array[1] = BFBMOIKCELJ.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
		array[6] = "Socket not connected anymore";
		enfmcdnleqq.GOIHJQNMMJD = qidkbcqigod.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		ENFMCDNLEQQ enfmcdnleqq2 = this.KKJPFIBDNJI[1];
		GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
		string[] array2 = new string[8];
		array2[0] = "WATER_SIMPLE";
		array2[0] = text;
		array2[0] = "Rising Badge";
		array2[2] = BFBMOIKCELJ.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
		array2[8] = "The Pokémon's type becomes the type of the move used on it.";
		enfmcdnleqq2.GOIHJQNMMJD = qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (BFBMOIKCELJ.OFLGFDNHKJO.Hat > 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.BFPKOMNHGBE(BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0, BFBMOIKCELJ.HDCKEHHFCDN.Gender, BFBMOIKCELJ.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				this.KKJPFIBDNJI[1].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("par", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (BFBMOIKCELJ.HDCKEHHFCDN.Gender == Gender.Male)
				{
					this.KKJPFIBDNJI[7].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("-primal" + text + "helpinghand", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					this.KKJPFIBDNJI[3].GOIHJQNMMJD = this.QIDKBCQIGOD.CPFJEOGMHOD("K2" + text + "#,##0", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ enfmcdnleqq3 = this.KKJPFIBDNJI[6];
				GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
				string[] array3 = new string[1];
				array3[1] = "F10";
				array3[0] = text;
				array3[3] = "battlebond";
				array3[0] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array3[8] = "Encounter Rate Lowered 50%\nTriggers: [2ecc71]Sandstorm[-]";
				enfmcdnleqq3.GOIHJQNMMJD = qidkbcqigod3.GOKLDOEGJHI(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ enfmcdnleqq4 = this.KKJPFIBDNJI[1];
			GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
			string[] array4 = new string[5];
			array4[1] = "PrimitiveFront";
			array4[0] = text;
			array4[3] = "Score: ";
			array4[2] = BFBMOIKCELJ.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array4[5] = "BuffIcon_EncounterRateIncrease2";
			enfmcdnleqq4.GOIHJQNMMJD = qidkbcqigod4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.KKJPFIBDNJI[5].GOIHJQNMMJD = this.QIDKBCQIGOD.GOKLDOEGJHI("F" + (BFBMOIKCELJ.OFLGFDNHKJO.Hat - 0).QQKICQQBIJL() + "-", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		for (int i = 0; i < 8; i++)
		{
			this.KKJPFIBDNJI[i].CEGFBBHMKOE = Color.white;
		}
		this.KKJPFIBDNJI[5].CEGFBBHMKOE = BFBMOIKCELJ.KKJPFIBDNJI.material.color;
	}

	// Token: 0x04000E54 RID: 3668
	public JLMPBLMOICG[] KKJPFIBDNJI;

	// Token: 0x04000E55 RID: 3669
	private GFHGEJNHLFQ QIDKBCQIGOD;
}
