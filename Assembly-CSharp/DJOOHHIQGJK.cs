using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MAPAPI.Response;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200019D RID: 413
public class DJOOHHIQGJK : MonoBehaviour
{
	// Token: 0x060033E9 RID: 13289 RVA: 0x0018AB00 File Offset: 0x00188D00
	public void NBDBHLEKENM()
	{
		string text = this.ICHKBBMBPGM.ToLowerInvariant();
		switch (text)
		{
		case "door_1":
			this.LCLQHIKFJMG(7);
			return;
		case "door_2":
			this.LCLQHIKFJMG(8);
			return;
		case "door_3":
			this.LCLQHIKFJMG(24);
			return;
		case "door_4":
			this.LCLQHIKFJMG(25);
			return;
		case "door_5":
			this.LCLQHIKFJMG(27);
			return;
		case "snorlax":
			this.LCLQHIKFJMG(14);
			return;
		case "balloon":
			this.LCLQHIKFJMG(31);
			return;
		case "snowman":
			this.LCLQHIKFJMG(32);
			return;
		case "waterpipe":
			this.LCLQHIKFJMG(26);
			return;
		case "pushrock":
			this.LCLQHIKFJMG(28);
			return;
		case "firelamp":
			this.LCLQHIKFJMG(29);
			return;
		case "firelamp_off":
			this.LCLQHIKFJMG(29);
			this.MGDBGBLMKQH[30].SetActive(false);
			return;
		case "whirlpool":
			this.LCLQHIKFJMG(23);
			return;
		case "berry_11":
		case "berry_12":
		case "berry_13":
		case "berry_14":
		case "berry_15":
		case "berry_16":
		case "berry_17":
			this.LCLQHIKFJMG(15);
			return;
		}
		int mfjbpkbnbno = this.MFJBPKBNBNO;
		switch (mfjbpkbnbno)
		{
		case 43:
			this.LCLQHIKFJMG(3);
			return;
		case 44:
			this.LCLQHIKFJMG(4);
			return;
		case 45:
			this.LCLQHIKFJMG(5);
			return;
		case 49:
			this.LCLQHIKFJMG(6);
			return;
		}
		switch (mfjbpkbnbno)
		{
		case 10:
			this.LCLQHIKFJMG(0);
			return;
		case 11:
			this.LCLQHIKFJMG(1);
			return;
		case 12:
			this.LCLQHIKFJMG(2);
			return;
		default:
		{
			if (this.FONOKLECDFB || this.BEQHNFFEHMQ > 0)
			{
				this.KKJPFIBDNJI.gameObject.SetActive(true);
				this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_HatTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_ClotheTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MountTopTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MountBottomTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				if (this.DCMGODHBJEC != null && this.DCMGODHBJEC.EMIEFKNMQMI != null && this.DCMGODHBJEC.EMIEFKNMQMI.MountType != MountType.None)
				{
					this.BEQHNFFEHMQ = 0;
				}
				string text2 = string.Empty;
				if (this.BEQHNFFEHMQ == 201 && this.IDICNBQHCJG % 28 > 0)
				{
					string str = "_";
					int num = this.IDICNBQHCJG % 28;
					text2 = str + num.ToString();
				}
				if (this.BEQHNFFEHMQ == 585 || this.BEQHNFFEHMQ == 586)
				{
					switch (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG)
					{
					case GameSeason.Spring:
						text2 = "-sp";
						break;
					case GameSeason.Summer:
						text2 = "-sm";
						break;
					case GameSeason.Autumn:
						text2 = "-at";
						break;
					case GameSeason.Winter:
						text2 = "-wt";
						break;
					}
				}
				if (this.BKNFHNFFCHE)
				{
					this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.CPFJEOGMHOD("FollowS/" + this.BEQHNFFEHMQ.DBFPJOCLQBI() + "s" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
					if (this.JPGLKGNOICN != null)
					{
						this.JPGLKGNOICN.SetActive(true);
					}
				}
				else
				{
					if (this.JPGLKGNOICN != null)
					{
						this.JPGLKGNOICN.SetActive(false);
					}
					this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Follow/" + this.BEQHNFFEHMQ.DBFPJOCLQBI() + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				}
				if (this.BEQHNFFEHMQ <= 0)
				{
					if (this.NEGLQQQDBEE != null)
					{
						this.NEGLQQQDBEE.SetActive(false);
					}
				}
				else if (this.NEGLQQQDBEE != null)
				{
					this.NEGLQQQDBEE.SetActive(true);
					this.NEGLQQQDBEE.transform.localPosition = new Vector3(0f, -0.9f, 0.06f);
				}
				if (this.KKJPFIBDNJI.material.mainTexture.width > 256)
				{
					if (this.OPILOFIJJDF != null)
					{
						this.OPILOFIJJDF.LCMMCNFNHMF = new Vector3(0.5f, 0.8f, 0.5f);
					}
					this.KKJPFIBDNJI.transform.localScale = new Vector3(2f, 2f, 2f);
					this.KKJPFIBDNJI.transform.localPosition = new Vector3(0f, 0f, -0.0008f);
				}
				else
				{
					if (this.OPILOFIJJDF != null)
					{
						this.OPILOFIJJDF.LCMMCNFNHMF = new Vector3(0.5f, 0f, 0.5f);
					}
					this.KKJPFIBDNJI.transform.localScale = new Vector3(1f, 1f, 1f);
					this.KKJPFIBDNJI.transform.localPosition = new Vector3(0f, -0.5f, -0.0008f);
				}
				return;
			}
			if (this.MFJBPKBNBNO > -1)
			{
				this.KKJPFIBDNJI.material.SetTexture("_HatTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_ClotheTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MountTopTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MountBottomTex", this.QIDKBCQIGOD.CPFJEOGMHOD("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.CPFJEOGMHOD("NPC/Sprite" + this.MFJBPKBNBNO.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				return;
			}
			this.KKJPFIBDNJI.gameObject.SetActive(true);
			string text3;
			if (this.HDCKEHHFCDN.Gender == Gender.Male)
			{
				text3 = "_Male";
			}
			else
			{
				text3 = "_Female";
			}
			string text4 = "1";
			if (this.EMIEFKNMQMI.MountType == MountType.Bike)
			{
				text4 = "2";
			}
			else if (this.EMIEFKNMQMI.MountType == MountType.Surfing)
			{
				text4 = "4";
			}
			else if (this.EMIEFKNMQMI.MountType == MountType.Pokemon)
			{
				if (this.EMIEFKNMQMI.MountID != 1)
				{
					text4 = "5";
				}
				else
				{
					text4 = "2";
				}
			}
			this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
			{
				"Player/Body",
				text3,
				"/",
				this.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
				"_",
				this.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
				"_",
				text4
			}), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			this.KKJPFIBDNJI.material.SetTexture("_ClotheTex", this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
			{
				"Player/Clothe",
				text3,
				"/",
				this.OFLGFDNHKJO.Clothe.QQKICQQBIJL(),
				"_",
				text4
			}), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			if (this.OFLGFDNHKJO.Hat > 0)
			{
				GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.HMOOOQOPPJO(this.OFLGFDNHKJO.Hat - 1, this.HDCKEHHFCDN.Gender, this.HDCKEHHFCDN.Hair);
				if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
				{
					this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				}
				else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
				{
					if (this.HDCKEHHFCDN.Gender == Gender.Male)
					{
						this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text3 + "/01_" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
					}
					else
					{
						this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hair" + text3 + "/03_" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
					}
				}
				else
				{
					this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
					{
						"Player/Hair",
						text3,
						"/",
						this.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
						"_",
						text4
					}), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				}
			}
			else
			{
				this.KKJPFIBDNJI.material.SetTexture("_HairTex", this.QIDKBCQIGOD.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Hair",
					text3,
					"/",
					this.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
					"_",
					text4
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			}
			this.KKJPFIBDNJI.material.SetTexture("_HatTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Hats/" + (this.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "_" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			if (this.EMIEFKNMQMI.MountType != MountType.None)
			{
				this.KKJPFIBDNJI.material.SetTexture("_MountTopTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Mounts/" + this.EMIEFKNMQMI.MountID.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				this.KKJPFIBDNJI.material.SetTexture("_MountBottomTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Player/Mounts/" + this.EMIEFKNMQMI.MountID.QQKICQQBIJL() + string.Empty, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			}
			else
			{
				this.KKJPFIBDNJI.material.SetTexture("_MountTopTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				this.KKJPFIBDNJI.material.SetTexture("_MountBottomTex", this.QIDKBCQIGOD.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			}
			int num2 = this.HDCKEHHFCDN.HairColor;
			if (num2 == -1)
			{
				num2 = 0;
			}
			this.KKJPFIBDNJI.material.color = this.QIDKBCQIGOD.OFGHDGJBDOL[num2];
			if (this.PQNJEKIPLDI)
			{
				CNCJKLNHQBH.QOQONHOOLNE.CMNJMJIEECH.BQLIIQIIMDH(this);
				GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.BQLIIQIIMDH(this);
			}
			return;
		}
		}
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x0018B744 File Offset: 0x00189944
	public bool ONQBQQBQEOJ(int COHDKOBDPCO, int JCJCMMFBGIM, Vector2 JCGMONLIDHP = default(Vector2))
	{
		if (JCGMONLIDHP != Vector2.zero)
		{
			this.INMILPKMQIC.Add(JCGMONLIDHP);
		}
		this.HEODPPJFOLM = new Vector2((float)COHDKOBDPCO, (float)JCJCMMFBGIM);
		List<Vector2> list = KIJNOLJFPLK.BEKHPOHIPDE().NGJCODFLJCB((int)this.QMCNCMNQEGL().x, (int)this.QMCNCMNQEGL().z, COHDKOBDPCO, JCJCMMFBGIM, this.KBKKMQNFJIG);
		if (list != null)
		{
			Vector2 vector = list[list.Count - 1];
			for (int i = list.Count - 1; i > -1; i--)
			{
				if (list[i] != new Vector2((float)((int)this.QMCNCMNQEGL().x), (float)((int)this.QMCNCMNQEGL().z)))
				{
					string cqjeodoleke = string.Empty;
					if (list[i].x > vector.x)
					{
						cqjeodoleke = "_Texture0";
					}
					else if (list[i].x < vector.x)
					{
						cqjeodoleke = "d";
					}
					else if (list[i].y > vector.y)
					{
						cqjeodoleke = "Connection reset";
					}
					else if (list[i].y < vector.y)
					{
						cqjeodoleke = "reflect";
					}
					this.BPQOIEJCNCI(cqjeodoleke, false, false, 1, 1, false);
					vector = list[i];
				}
			}
			this.BHQOFDQCCCG = true;
			return false;
		}
		return true;
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x0018B8C8 File Offset: 0x00189AC8
	public void LEMKNDFEJHE(bool OHOBDLMNJMC)
	{
		if (this.ICHKBBMBPGM == "p" || this.ICHKBBMBPGM == "\n" || this.ICHKBBMBPGM == "Key_" || this.ICHKBBMBPGM == "CombinersArgsAlphaOp0" || this.ICHKBBMBPGM == "Rotate")
		{
			if (OHOBDLMNJMC)
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren = this.MGDBGBLMKQH[1].GetComponentInChildren<Animation>();
				componentInChildren["[-]!\r\n"].time = 1802f;
				componentInChildren["_FogColor2"].speed = 166f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren["grasspledge"].time = 586f;
				componentInChildren["Trade Request"].speed = 1928f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[21].GetComponentInChildren<Animation>();
				componentInChildren["ReflecB"].time = 955f;
				componentInChildren["move: "].speed = 678f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[-20].GetComponentInChildren<Animation>();
				componentInChildren["*"].time = 266f;
				componentInChildren["fly"].speed = 200f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[-95].GetComponentInChildren<Animation>();
				componentInChildren["System"].time = 1669f;
				componentInChildren["Invalid Username or Password.."].speed = 0f;
				componentInChildren.Play();
			}
			else
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren2 = this.MGDBGBLMKQH[3].GetComponentInChildren<Animation>();
				componentInChildren2["Mouse Click Collider"].time = 771f;
				componentInChildren2["Hi-Score: "].speed = 1398f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren2["perish0"].time = 545f;
				componentInChildren2["[Lv]"].speed = 180f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[-86].GetComponentInChildren<Animation>();
				componentInChildren2["GUI/Text Shader"].time = 208f;
				componentInChildren2["Party"].speed = 1001f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[73].GetComponentInChildren<Animation>();
				componentInChildren2[" stockpiled 1!\r\n"].time = 1115f;
				componentInChildren2["futuresight"].speed = 1203f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[40].GetComponentInChildren<Animation>();
				componentInChildren2["_DestortionX"].time = 1366f;
				componentInChildren2["Horizontal"].speed = 1699f;
				componentInChildren2.Play();
			}
			return;
		}
		if (!(this.ICHKBBMBPGM == "Icon_Status_Poisoned") && !this.ICHKBBMBPGM.Contains("_"))
		{
			if (OHOBDLMNJMC)
			{
				this.BKFBOCMOOHH();
				this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
				this.KFNLCPGHQHK = false;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(false);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(true);
				}
				base.gameObject.SetActive(false);
			}
			else
			{
				this.KFNLCPGHQHK = false;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(true);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(false);
				}
				base.gameObject.SetActive(true);
			}
			return;
		}
		this.KFNLCPGHQHK = OHOBDLMNJMC;
		this.DBGLGGODDOH();
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x0018BCF8 File Offset: 0x00189EF8
	public void PJMKLHKFBJM(Vector3 JNFLDQHODDQ, PSXAPI.Response.PlayerDirection PECKDHFNOKI = PSXAPI.Response.PlayerDirection.Default)
	{
		if (this.PDDEIHNJOGE == null)
		{
			this.PDDEIHNJOGE = base.transform;
		}
		this.BHQOFDQCCCG = false;
		this.OQJFBJQJEFG = 0f;
		this.PDDEIHNJOGE.position = JNFLDQHODDQ;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		bool[] array = new bool[4];
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 1) == 24)
		{
			array[0] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 24)
		{
			array[1] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == 24)
		{
			array[2] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 1, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 1, -(int)JNFLDQHODDQ.z) == 24)
		{
			array[3] = true;
		}
		if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Default)
		{
			switch (this.DIEOHLOINHH)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Left;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Down;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Right;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Up;
				break;
			}
			PECKDHFNOKI = this.ILBEOBOIHJE;
		}
		if (PECKDHFNOKI != PSXAPI.Response.PlayerDirection.Default)
		{
			this.ILBEOBOIHJE = PECKDHFNOKI;
			if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Down)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
				{
					if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
					}
					else if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Up)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
				{
					if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
					}
					else if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Left)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
				{
					if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
					}
					else if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Right)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
				{
					if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
					}
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
			{
				if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
			{
				if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Right)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
			{
				if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(-1f, 0f, 0f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, -1f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
				}
			}
		}
		else if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1.5)
		{
			this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(0f, 0f, 1f);
		}
		if (this.HLGCFHIMHFQ == null)
		{
			this.HLGCFHIMHFQ = DOJNBQQBCQJ.QOQONHOOLNE;
		}
		if (!this.FONOKLECDFB)
		{
			for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
			{
				Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
				Vector2 vector = new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z) - new Vector2(transform.position.x, transform.position.z);
				float num = vector.x * vector.x + vector.y * vector.y;
				if (num < 4f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
				{
					this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(this.PQNJEKIPLDI);
				}
			}
			if (this.PQNJEKIPLDI && this.PKCLDNQJMMH)
			{
				if (this.BOGKQOEEBFK == null)
				{
					this.BOGKQOEEBFK = KJBDMOCFMCM.QOQONHOOLNE;
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NCPQEIFNPPP();
				if (nhgkgbgjefj != null)
				{
					this.PKCLDNQJMMH = false;
				}
			}
		}
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x00017340 File Offset: 0x00015540
	public void OPJIONMHFMQ(string CQJEODOLEKE)
	{
		this.QJCBOEFQPGF(CQJEODOLEKE, true, true, 0, 0, false);
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x0018C7B4 File Offset: 0x0018A9B4
	public void GPFOFHLIDMH(Style JMDLLJPEFKM, PSXAPI.Response.Mount QPGCBDPFIOF, Equip GBQOIGLGLMI)
	{
		this.HDCKEHHFCDN = JMDLLJPEFKM;
		if (QPGCBDPFIOF != null)
		{
			this.EMIEFKNMQMI = QPGCBDPFIOF;
		}
		if (GBQOIGLGLMI != null)
		{
			this.OFLGFDNHKJO = GBQOIGLGLMI;
		}
		if (QPGCBDPFIOF != null)
		{
			this.GIBFBFJHNKH.MountID = QPGCBDPFIOF.MountID;
			this.GIBFBFJHNKH.MountType = QPGCBDPFIOF.MountType;
		}
		this.NBDBHLEKENM();
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x0018C808 File Offset: 0x0018AA08
	public void HQNCQOFKPHN(PSXAPI.Response.Mount QPGCBDPFIOF)
	{
		if (QPGCBDPFIOF != null)
		{
			this.EMIEFKNMQMI = QPGCBDPFIOF;
		}
		else
		{
			this.EMIEFKNMQMI = new PSXAPI.Response.Mount
			{
				MountID = 0,
				MountType = MountType.None
			};
		}
		if (this.EMIEFKNMQMI != null)
		{
			this.GIBFBFJHNKH.MountID = this.EMIEFKNMQMI.MountID;
			this.GIBFBFJHNKH.MountType = this.EMIEFKNMQMI.MountType;
		}
		this.NBDBHLEKENM();
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x0001734E File Offset: 0x0001554E
	private void LateUpdate()
	{
		this.JBJIQOFPPHE = false;
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x0018C878 File Offset: 0x0018AA78
	public void OMGLFGJMQCI(bool OHOBDLMNJMC)
	{
		if (this.ICHKBBMBPGM == "Could not find a ConstantShakePreset with the name: " || this.ICHKBBMBPGM == "Open" || this.ICHKBBMBPGM == " cloaked itself in a mystical veil!\r\n" || this.ICHKBBMBPGM == " floats in the air with its Air Balloon!\r\n" || this.ICHKBBMBPGM == "Surf")
		{
			if (OHOBDLMNJMC)
			{
				this.KFNLCPGHQHK = false;
				Animation componentInChildren = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren["_FogDistance"].time = 1265f;
				componentInChildren["s"].speed = 43f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[3].GetComponentInChildren<Animation>();
				componentInChildren["[ffff00]Wide Guard[-] protected "].time = 1583f;
				componentInChildren["Storm Badge"].speed = 1859f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[75].GetComponentInChildren<Animation>();
				componentInChildren["Once per battle, the shroud that covers the Pokémon can protect it from an attack."].time = 996f;
				componentInChildren[" shared its power with "].speed = 1244f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[-95].GetComponentInChildren<Animation>();
				componentInChildren["Open"].time = 1699f;
				componentInChildren["\nAre you sure you want to Reset its IVs?"].speed = 1210f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[-27].GetComponentInChildren<Animation>();
				componentInChildren["Script:"].time = 7f;
				componentInChildren["Blank"].speed = 1129f;
				componentInChildren.Play();
			}
			else
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren2 = this.MGDBGBLMKQH[4].GetComponentInChildren<Animation>();
				componentInChildren2["-"].time = 914f;
				componentInChildren2["[00FF00]You received [PD]"].speed = 1843f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[6].GetComponentInChildren<Animation>();
				componentInChildren2[" lost its focus and couldn't move!\r\n"].time = 1942f;
				componentInChildren2["The Pokémon employs no-guard tactics to ensure incoming and outgoing attacks always land."].speed = 1312f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[81].GetComponentInChildren<Animation>();
				componentInChildren2["l"].time = 874f;
				componentInChildren2["Icon_Pokemon_Alive"].speed = 1421f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[57].GetComponentInChildren<Animation>();
				componentInChildren2["[PD]"].time = 1902f;
				componentInChildren2["_"].speed = 1267f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[-19].GetComponentInChildren<Animation>();
				componentInChildren2["Triage"].time = 803f;
				componentInChildren2["/[PD]"].speed = 1998f;
				componentInChildren2.Play();
			}
			return;
		}
		if (!(this.ICHKBBMBPGM == " - ") && !this.ICHKBBMBPGM.Contains(" minutes"))
		{
			if (OHOBDLMNJMC)
			{
				this.NHLEIQFNHNM();
				this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
				this.KFNLCPGHQHK = true;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(true);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(false);
				}
				base.gameObject.SetActive(true);
			}
			else
			{
				this.KFNLCPGHQHK = true;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(true);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(false);
				}
				base.gameObject.SetActive(true);
			}
			return;
		}
		this.KFNLCPGHQHK = OHOBDLMNJMC;
		this.DBGLGGODDOH();
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x0018CCA8 File Offset: 0x0018AEA8
	public void QJCBOEFQPGF(string CQJEODOLEKE, bool GKHQCBGIOFP, bool EFQMQOPCBNO = false, int DGKOIGOLHDM = 0, int DDLQKFDFMCJ = 0, bool FPBQFQEJOLB = false)
	{
		DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
		jlkckmjegki.BJIGIECDQPG = CQJEODOLEKE;
		if (this.PJGOMOBBNLK.Count == 0)
		{
			jlkckmjegki.PELCNBCMNFH = this.PDDEIHNJOGE.position;
			this.JPOBLCQMKHC = this.PDDEIHNJOGE.position;
		}
		else
		{
			jlkckmjegki.PELCNBCMNFH = this.JPOBLCQMKHC;
		}
		if (CQJEODOLEKE == "u")
		{
			this.JPOBLCQMKHC += new Vector3(0f, 0f, 1f);
		}
		if (CQJEODOLEKE == "d")
		{
			this.JPOBLCQMKHC += new Vector3(0f, 0f, -1f);
		}
		if (CQJEODOLEKE == "l")
		{
			this.JPOBLCQMKHC += new Vector3(-1f, 0f, 0f);
		}
		if (CQJEODOLEKE == "r")
		{
			this.JPOBLCQMKHC += new Vector3(1f, 0f, 0f);
		}
		if (CQJEODOLEKE == "b")
		{
			jlkckmjegki.PELCNBCMNFH = new Vector3((float)DGKOIGOLHDM, this.OHPIPBHKEGC, (float)(-(float)DDLQKFDFMCJ));
		}
		jlkckmjegki.PCGDFKDQHGH = GKHQCBGIOFP;
		jlkckmjegki.QEEPJBBJGQM = EFQMQOPCBNO;
		jlkckmjegki.EBBBQJELOFF = FPBQFQEJOLB;
		this.PJGOMOBBNLK.Add(jlkckmjegki);
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x00017357 File Offset: 0x00015557
	public void LNMPOMFDEGC(Equip GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI != null)
		{
			this.OFLGFDNHKJO = GBQOIGLGLMI;
		}
		this.NBDBHLEKENM();
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x0018CE10 File Offset: 0x0018B010
	private void Update()
	{
		if (this.FONOKLECDFB)
		{
			if (this.DCMGODHBJEC == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.DCMGODHBJEC.OPILOFIJJDF != null)
			{
				this.KKJPFIBDNJI.material.SetFloat("_Dissolve", 0.5f - this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(1f, 1f, 1f, this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
				}
			}
		}
		if (this.OPILOFIJJDF != null)
		{
			if (this.LJDKPJCDCCM)
			{
				if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP > 0f)
				{
					this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP -= 2f * UnityEngine.Time.deltaTime;
					this.KKJPFIBDNJI.material.SetFloat("_Dissolve", 0.5f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
					if (this.HKHDIIGNEFB != null)
					{
						this.HKHDIIGNEFB.color = new Color(1f, 1f, 1f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
					}
				}
			}
			else if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP < 1f)
			{
				this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP += 2f * UnityEngine.Time.deltaTime;
				this.KKJPFIBDNJI.material.SetFloat("_Dissolve", 0.5f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(1f, 1f, 1f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 0.5f);
				}
			}
		}
		if (this.LJDKPJCDCCM && UnityEngine.Time.time > this.DBGMJPEMPQC + 10f)
		{
			CGOIPHKQMPD.QOQONHOOLNE.EDMNQJQIKHB(this);
			return;
		}
		if (!this.PHMOJLGOPHF)
		{
			return;
		}
		this.FDBLQDEOENF();
		this.JBJIQOFPPHE = true;
	}

	// Token: 0x060033F5 RID: 13301 RVA: 0x00017369 File Offset: 0x00015569
	public void FICGKICPHPN(string PIDLOFMIEFQ)
	{
		this.HEDDMKGFMQO.HCNPIJLODQE(PIDLOFMIEFQ);
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x0018D094 File Offset: 0x0018B294
	public int JGGNIDDGPHO()
	{
		return this.LIQLFCKICLQ.POMQCKOIKQJ[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z];
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x0018D0DC File Offset: 0x0018B2DC
	public bool NIHLBPFQGHH(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		return (int)this.IEFBCKQJBGN.position.x == DGKOIGOLHDM && (int)this.IEFBCKQJBGN.position.z == DDLQKFDFMCJ && false;
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x0018D11C File Offset: 0x0018B31C
	public void DFMMCLFKFBH()
	{
		this.OQJFBJQJEFG = Mathf.Clamp(this.OQJFBJQJEFG + UnityEngine.Time.deltaTime * this.QCMIHCBOIJB / this.BNIGIJDGJKM, -999f, 1f);
		this.PDDEIHNJOGE.position = Vector3.Lerp(this.ODGQNNEDJIF, new Vector3(this.PCPQHQMBCBJ.x, this.OHPIPBHKEGC, this.PCPQHQMBCBJ.z), this.OQJFBJQJEFG);
	}

	// Token: 0x060033F9 RID: 13305 RVA: 0x0018D198 File Offset: 0x0018B398
	public IEnumerator HKDHPJFJGBP()
	{
		if (this.PJGOMOBBNLK.Count <= 0)
		{
			yield return true;
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x060033FA RID: 13306 RVA: 0x00017377 File Offset: 0x00015577
	public void NQJHJNQFKKC()
	{
		this.MMPQCIKNBQE = false;
		this.KGCEBGIHKKC = false;
		this.PJGOMOBBNLK.Clear();
	}

	// Token: 0x060033FB RID: 13307 RVA: 0x0018D1B4 File Offset: 0x0018B3B4
	public bool KFFKGFHDFMO(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		return (int)this.IEFBCKQJBGN.position.x != DGKOIGOLHDM || (int)this.IEFBCKQJBGN.position.z != DDLQKFDFMCJ || true;
	}

	// Token: 0x060033FD RID: 13309 RVA: 0x0018D33C File Offset: 0x0018B53C
	public void KLLNKPFJMPJ()
	{
		if (this.OPILOFIJJDF != null)
		{
			this.OPILOFIJJDF.QHQKHCHLEMJ();
			IEnumerator enumerator = this.OPILOFIJJDF.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(false);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x00017392 File Offset: 0x00015592
	private void EOJDBDHKOIP()
	{
		this.HEDDMKGFMQO = UnityEngine.Object.Instantiate<NLDFFJFQJBI>(this.HFFFEDCGPBD);
		this.HEDDMKGFMQO.transform.parent = this.FQLIOJQIKME;
		this.HEDDMKGFMQO.EDLCMBBBKPF(this.PDDEIHNJOGE);
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x000173CC File Offset: 0x000155CC
	public void NQMKJGJOPDH()
	{
		this.IFFEJHHMODI(this.DIEOHLOINHH, 1);
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x000173DB File Offset: 0x000155DB
	public void EDHCHIGLKLF()
	{
		this.BNIGIJDGJKM += 1f;
		this.MOEHFDNNLCB = true;
		if (this.PQNJEKIPLDI)
		{
			DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(19, false);
		}
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x000173CC File Offset: 0x000155CC
	public void OLOQKOMFFNB()
	{
		this.IFFEJHHMODI(this.DIEOHLOINHH, 1);
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x0018D3BC File Offset: 0x0018B5BC
	public void FDBLQDEOENF()
	{
		bool flag = true;
		if (this.LFFNNKJOPFI > 0f)
		{
			if (UnityEngine.Time.time > this.LFFNNKJOPFI + 1f)
			{
				this.LFFNNKJOPFI = 0f;
				this.BHQOFDQCCCG = true;
			}
			else
			{
				flag = false;
			}
		}
		if (this.IEFBCKQJBGN != null && this.PJGOMOBBNLK.Count > 0 && !this.PJGOMOBBNLK[0].PCGDFKDQHGH)
		{
			if (this.EBBBQJELOFF((int)this.PCPQHQMBCBJ.x, (int)this.PCPQHQMBCBJ.z))
			{
				flag = false;
			}
			if (flag && this.EKEKMCMJEOC && !QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO)
			{
				this.EKEKMCMJEOC = false;
			}
		}
		if (this.FONOKLECDFB && this.DCMGODHBJEC != null)
		{
			if (this.DCMGODHBJEC.EMIEFKNMQMI != null && this.DCMGODHBJEC.EMIEFKNMQMI.MountType != MountType.None && this.BEQHNFFEHMQ != 0)
			{
				this.BEQHNFFEHMQ = 0;
				this.NBDBHLEKENM();
				return;
			}
			if (this.BEQHNFFEHMQ == 0)
			{
				this.PJMKLHKFBJM(this.DCMGODHBJEC.FQGJJOLGJFE, PSXAPI.Response.PlayerDirection.Default);
				return;
			}
			if (Vector3.Distance(this.PDDEIHNJOGE.position, this.DCMGODHBJEC.FQGJJOLGJFE) > 2f)
			{
				this.PJMKLHKFBJM(this.DCMGODHBJEC.FQGJJOLGJFE, PSXAPI.Response.PlayerDirection.Default);
			}
			if (this.PDDEIHNJOGE.position.x < this.DCMGODHBJEC.FQGJJOLGJFE.x)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
			}
			else if (this.PDDEIHNJOGE.position.x > this.DCMGODHBJEC.FQGJJOLGJFE.x)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
			}
			else if (this.PDDEIHNJOGE.position.z < this.DCMGODHBJEC.FQGJJOLGJFE.z)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
			}
			else if (this.PDDEIHNJOGE.position.z > this.DCMGODHBJEC.FQGJJOLGJFE.z)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
			}
			if (this.PDDEIHNJOGE.position.x == this.DCMGODHBJEC.FQGJJOLGJFE.x)
			{
				if (this.PDDEIHNJOGE.position.z == this.DCMGODHBJEC.FQGJJOLGJFE.z)
				{
					if (this.DIEOHLOINHH != this.CFHEIICNLFD)
					{
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
					}
					this.CFHEIICNLFD = this.DIEOHLOINHH;
					goto IL_2CF;
				}
			}
			this.PDDEIHNJOGE.position = Vector3.MoveTowards(this.PDDEIHNJOGE.position, new Vector3(this.DCMGODHBJEC.FQGJJOLGJFE.x, this.OHPIPBHKEGC, this.DCMGODHBJEC.FQGJJOLGJFE.z), this.QCMIHCBOIJB * UnityEngine.Time.deltaTime);
			IL_2CF:
			flag = false;
		}
		if (this.QCDHQOLHIEJ != 1)
		{
			if (this.QCDHQOLHIEJ != 2)
			{
				if (this.BHQOFDQCCCG && flag)
				{
					bool flag2 = false;
					if (new Vector3(this.PCPQHQMBCBJ.x, this.OHPIPBHKEGC, this.PCPQHQMBCBJ.z) != new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z))
					{
						if (this.BNIGIJDGJKM == 2f && this.OQIOPJQHCII != null && !this.OQIOPJQHCII.Settings.WalkFast)
						{
							this.QCMIHCBOIJB = 3.25f;
						}
						float num = this.OQJFBJQJEFG + UnityEngine.Time.deltaTime * this.QCMIHCBOIJB / this.BNIGIJDGJKM;
						if (!this.JBJIQOFPPHE)
						{
							this.DPDCGFEEFPB = num - 1f;
							if (this.DPDCGFEEFPB <= 0f)
							{
								this.DPDCGFEEFPB = 0f;
							}
							this.OQJFBJQJEFG = Mathf.Clamp(num, -999f, 1f);
						}
						else
						{
							this.OQJFBJQJEFG += this.DPDCGFEEFPB;
							this.DPDCGFEEFPB = 0f;
						}
						this.PDDEIHNJOGE.position = Vector3.Lerp(this.ODGQNNEDJIF, new Vector3(this.PCPQHQMBCBJ.x, this.OHPIPBHKEGC, this.PCPQHQMBCBJ.z), this.OQJFBJQJEFG);
						if (new Vector3(this.PCPQHQMBCBJ.x, this.OHPIPBHKEGC, this.PCPQHQMBCBJ.z) == new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z))
						{
							flag2 = true;
						}
						this.QKHFEMHPGKC += this.CLIJPELJNGJ * UnityEngine.Time.deltaTime;
						if (this.QKHFEMHPGKC >= 10f)
						{
							this.CBBPOGMKJIM += 1;
							this.QKHFEMHPGKC = 0f;
							if (this.CBBPOGMKJIM > 3)
							{
								this.CBBPOGMKJIM = 0;
							}
							if (!this.KGCEBGIHKKC)
							{
								if (this.EKEKMCMJEOC)
								{
									this.IFFEJHHMODI(this.BJGQDHPBCFC, this.CBBPOGMKJIM);
								}
								else
								{
									this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
								}
							}
							else
							{
								this.IFFEJHHMODI(this.BJGQDHPBCFC, 1);
							}
						}
						this.QCMIHCBOIJB = 3.25f;
						if (this.EMIEFKNMQMI != null && (this.EMIEFKNMQMI.MountType == MountType.Bike || this.EMIEFKNMQMI.MountType == MountType.Pokemon))
						{
							this.QCMIHCBOIJB = 6f;
						}
						if (this.GQFBLMFFQID && this.PJGOMOBBNLK.Count > 30)
						{
							this.QCMIHCBOIJB = 8f;
						}
						if (this.FONOKLECDFB)
						{
							this.QCMIHCBOIJB = 3.25f;
							if (this.DCMGODHBJEC != null)
							{
								this.QCMIHCBOIJB = this.DCMGODHBJEC.QCMIHCBOIJB;
							}
						}
						else if (this.OQIOPJQHCII != null)
						{
							if (this.PFJILOMJDKN)
							{
								this.QCMIHCBOIJB = 4f;
							}
							else if (this.OQIOPJQHCII.Settings.WalkFast)
							{
								this.QCMIHCBOIJB = 4f;
							}
							else
							{
								this.QCMIHCBOIJB = 2f;
							}
						}
					}
					else
					{
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						flag2 = true;
					}
					if (!flag2)
					{
						goto IL_1A38;
					}
					this.GGFNLMNGDJB = UnityEngine.Time.time;
					this.JQBBIQFNONP = UnityEngine.Time.time;
					this.BHQOFDQCCCG = false;
					this.OQJFBJQJEFG = 0f;
					if (this.PQNJEKIPLDI)
					{
						QOHCEBMQKMB.QOQONHOOLNE.KQGLCNGHJLM = false;
					}
					if (this.EKEKMCMJEOC)
					{
						this.IFFEJHHMODI(this.DIEOHLOINHH, 1);
						this.BHQOFDQCCCG = true;
						goto IL_1A38;
					}
					if (this.PQNJEKIPLDI)
					{
						for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
						{
							Vector2 vector = new Vector2(this.PDDEIHNJOGE.position.x, this.PDDEIHNJOGE.position.z) - new Vector2(this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform.position.x, this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform.position.z);
							float num2 = vector.x * vector.x + vector.y * vector.y;
							if (num2 < 4f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
							{
								this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(true);
							}
						}
						if (this.PKCLDNQJMMH)
						{
							if (this.BOGKQOEEBFK == null)
							{
								this.BOGKQOEEBFK = KJBDMOCFMCM.QOQONHOOLNE;
							}
							KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NCPQEIFNPPP();
							if (nhgkgbgjefj != null)
							{
								this.PKCLDNQJMMH = false;
							}
						}
						if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.LIQLFCKICLQ != null && (int)this.PDDEIHNJOGE.position.x <= this.LIQLFCKICLQ.LIQLFCKICLQ.width && -(int)this.PDDEIHNJOGE.position.z <= this.LIQLFCKICLQ.LIQLFCKICLQ.height)
						{
							int num3 = this.LIQLFCKICLQ.POMQCKOIKQJ[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z];
							if (this.JPCQBEEHOJL && (num3 == 2 || num3 == 15))
							{
								this.KGCEBGIHKKC = false;
							}
							if (num3 == 10)
							{
								if (!this.MMPQCIKNBQE)
								{
									this.NQJHJNQFKKC();
								}
								int num4 = -1;
								if (CNCJKLNHQBH.QOQONHOOLNE.BJGQDHPBCFC == PSXAPI.Request.MoveAction.Up)
								{
									num4 = 0;
								}
								if (CNCJKLNHQBH.QOQONHOOLNE.BJGQDHPBCFC == PSXAPI.Request.MoveAction.Down)
								{
									num4 = 1;
								}
								if (CNCJKLNHQBH.QOQONHOOLNE.BJGQDHPBCFC == PSXAPI.Request.MoveAction.Left)
								{
									num4 = 2;
								}
								if (CNCJKLNHQBH.QOQONHOOLNE.BJGQDHPBCFC == PSXAPI.Request.MoveAction.Right)
								{
									num4 = 3;
								}
								this.KGCEBGIHKKC = false;
								if (!this.MMPQCIKNBQE && num4 > -1 && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(num4))
								{
									this.BHQOFDQCCCG = false;
								}
							}
							else if (num3 == 25)
							{
								this.KGCEBGIHKKC = false;
							}
							else if (this.JPCQBEEHOJL && num3 == 31)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 0;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(0))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (this.JPCQBEEHOJL && num3 == 32)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 1;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(1))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (this.JPCQBEEHOJL && num3 == 33)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 2;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(2))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (this.JPCQBEEHOJL && num3 == 34)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 3;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(3))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (num3 == 26)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 0;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(0))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (num3 == 27)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 1;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(1))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (num3 == 28)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 2;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(2))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (num3 == 29)
							{
								if (!this.KGCEBGIHKKC)
								{
									this.NBMPEILGCNG = 3;
								}
								this.KGCEBGIHKKC = true;
								if (!this.MMPQCIKNBQE && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(3))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
							else if (this.KGCEBGIHKKC)
							{
								this.KGCEBGIHKKC = true;
								int num5 = -1;
								switch (CNCJKLNHQBH.QOQONHOOLNE.BJGQDHPBCFC)
								{
								case PSXAPI.Request.MoveAction.Up:
									num5 = 0;
									break;
								case PSXAPI.Request.MoveAction.Down:
									num5 = 1;
									break;
								case PSXAPI.Request.MoveAction.Left:
									num5 = 2;
									break;
								case PSXAPI.Request.MoveAction.Right:
									num5 = 3;
									break;
								}
								if (!this.MMPQCIKNBQE && num5 > -1 && !CNCJKLNHQBH.QOQONHOOLNE.QNPQDFGOOEP(num5))
								{
									this.BHQOFDQCCCG = false;
									this.KGCEBGIHKKC = false;
								}
							}
						}
					}
					if (this.PJGOMOBBNLK.Count <= 0 || this.QHQNCPBLLNK)
					{
						this.MMPQCIKNBQE = false;
						this.PFJILOMJDKN = false;
						goto IL_1A38;
					}
					if (this.PJGOMOBBNLK[0].BJIGIECDQPG != "b" && this.PJGOMOBBNLK[0].BJIGIECDQPG != "p" && this.PJGOMOBBNLK[0].BJIGIECDQPG != "i")
					{
						this.PDDEIHNJOGE.position = new Vector3((float)Math.Round((double)this.PJGOMOBBNLK[0].PELCNBCMNFH.x), this.PDDEIHNJOGE.position.y, (float)Math.Round((double)this.PJGOMOBBNLK[0].PELCNBCMNFH.z));
					}
					this.JDPCHGPENBD = this.PJGOMOBBNLK[0].PELCNBCMNFH;
					if (this.PJGOMOBBNLK[0].QEEPJBBJGQM)
					{
						this.PFJILOMJDKN = true;
					}
					else
					{
						this.PFJILOMJDKN = false;
					}
					int gokglgpcpij = 0;
					if (!this.PQNJEKIPLDI && !this.FONOKLECDFB && this.GQFBLMFFQID)
					{
						this.KBKKMQNFJIG = this.PJGOMOBBNLK[0].MBODJJEPJHD;
						if (this.PJGOMOBBNLK[0].MBODJJEPJHD)
						{
							gokglgpcpij = 1;
						}
					}
					bool flag3 = false;
					string bjigiecdqpg = this.PJGOMOBBNLK[0].BJIGIECDQPG;
					switch (bjigiecdqpg)
					{
					case "u":
						this.EDMFOMGFMGD(0, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, true);
						this.JDPCHGPENBD += new Vector3(0f, 0f, 1f);
						flag3 = true;
						break;
					case "d":
						this.EDMFOMGFMGD(1, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, true);
						this.JDPCHGPENBD += new Vector3(0f, 0f, -1f);
						flag3 = true;
						break;
					case "l":
						this.EDMFOMGFMGD(2, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, true);
						this.JDPCHGPENBD += new Vector3(-1f, 0f, 0f);
						flag3 = true;
						break;
					case "r":
						this.EDMFOMGFMGD(3, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, true);
						this.JDPCHGPENBD += new Vector3(1f, 0f, 0f);
						flag3 = true;
						break;
					case "n":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						break;
					case "s":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						break;
					case "e":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						break;
					case "w":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						break;
					case "1":
						this.EDMFOMGFMGD(4, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, false);
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						break;
					case "2":
						this.EDMFOMGFMGD(5, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, false);
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						break;
					case "3":
						this.EDMFOMGFMGD(6, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, false);
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						break;
					case "4":
						this.EDMFOMGFMGD(7, (!this.PJGOMOBBNLK[0].EBBBQJELOFF) ? null : ((!this.PQNJEKIPLDI) ? null : this.BOGKQOEEBFK), false, 0, 0, gokglgpcpij, false, false);
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						break;
					case "o":
						this.DBGMJPEMPQC = UnityEngine.Time.time;
						this.LJDKPJCDCCM = true;
						break;
					case "a":
						this.LJDKPJCDCCM = false;
						break;
					case "b":
						flag3 = true;
						this.NCDDEEGIEEK(this.PJGOMOBBNLK[0].PELCNBCMNFH);
						break;
					case "p":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						break;
					case "i":
						this.ODGQNNEDJIF = this.JDPCHGPENBD;
						this.LFFNNKJOPFI = UnityEngine.Time.time;
						this.PJGOMOBBNLK.Clear();
						this.EJHFEJCLMOB(false);
						return;
					}
					if (this.EHCDCCNJBDC)
					{
						DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
						jlkckmjegki.BJIGIECDQPG = this.PJGOMOBBNLK[0].BJIGIECDQPG;
						jlkckmjegki.PELCNBCMNFH = this.PJGOMOBBNLK[0].PELCNBCMNFH;
						this.PJGOMOBBNLK.Add(jlkckmjegki);
					}
					if (this.PQNJEKIPLDI)
					{
						if (this.PJGOMOBBNLK.Count > 0)
						{
							PSXAPI.Request.MoveAction moveAction = PSXAPI.Request.MoveAction.None;
							string bjigiecdqpg2 = this.PJGOMOBBNLK[0].BJIGIECDQPG;
							if (bjigiecdqpg2 != null)
							{
								if (!(bjigiecdqpg2 == "u"))
								{
									if (!(bjigiecdqpg2 == "d"))
									{
										if (!(bjigiecdqpg2 == "l"))
										{
											if (bjigiecdqpg2 == "r")
											{
												moveAction = PSXAPI.Request.MoveAction.Right;
											}
										}
										else
										{
											moveAction = PSXAPI.Request.MoveAction.Left;
										}
									}
									else
									{
										moveAction = PSXAPI.Request.MoveAction.Down;
									}
								}
								else
								{
									moveAction = PSXAPI.Request.MoveAction.Up;
								}
							}
							bool flag4;
							if (!(flag4 = QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC()) && this.LIQLFCKICLQ.DMLHFGIFMKM((int)base.transform.position.x, (int)(-(int)base.transform.position.z), moveAction))
							{
								QOHCEBMQKMB.QOQONHOOLNE.KQGLCNGHJLM = true;
								this.NQJHJNQFKKC();
								QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO = true;
							}
							if (moveAction != PSXAPI.Request.MoveAction.None)
							{
								CNCJKLNHQBH.QOQONHOOLNE.GEQIJFMDJKG += 1u;
								GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Move
								{
									X = (int)this.PDDEIHNJOGE.position.x,
									Y = (int)(-(int)this.PDDEIHNJOGE.position.z),
									Map = this.LIQLFCKICLQ.CLPMOMHLNMN,
									Actions = new PSXAPI.Request.MoveAction[]
									{
										moveAction
									}
								}, false);
							}
							if (!flag4 && moveAction != PSXAPI.Request.MoveAction.None)
							{
								CNCJKLNHQBH.QOQONHOOLNE.PCMBMOFNIJE();
								if (CNCJKLNHQBH.QOQONHOOLNE.QELEIBIKPOF == 0)
								{
									this.NQJHJNQFKKC();
								}
							}
							this.LIQLFCKICLQ.JCGBDMKKMMK(this.QMCNCMNQEGL(), false, false);
						}
					}
					else if (this.PJGOMOBBNLK.Count > 0)
					{
						string bjigiecdqpg3 = this.PJGOMOBBNLK[0].BJIGIECDQPG;
						switch (bjigiecdqpg3)
						{
						case "u":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Up;
							break;
						case "d":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Down;
							break;
						case "l":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Left;
							break;
						case "r":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Right;
							break;
						case "1":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Up;
							break;
						case "2":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Down;
							break;
						case "3":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Left;
							break;
						case "4":
							this.BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Right;
							break;
						}
					}
					if (this.PJGOMOBBNLK.Count > 0)
					{
						this.PJGOMOBBNLK.RemoveAt(0);
					}
					if (this.PQNJEKIPLDI)
					{
						if (this.PJGOMOBBNLK.Count == 0)
						{
							CNCJKLNHQBH.QOQONHOOLNE.MJCLOOLBQQB = true;
							goto IL_1A38;
						}
						goto IL_1A38;
					}
					else
					{
						if (this.IEFBCKQJBGN != null)
						{
							if (this.QMBIHEHNIGC > 0 && CNCJKLNHQBH.QOQONHOOLNE.MGFDFQDMGPG == null && !QOHCEBMQKMB.QOQONHOOLNE.QKKQHILJMMO && CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH)
							{
								if (this.BOGKQOEEBFK == null)
								{
									this.BOGKQOEEBFK = KJBDMOCFMCM.QOQONHOOLNE;
								}
								KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj2 = this.BOGKQOEEBFK.ICQJLCGGHOG(this);
								if (nhgkgbgjefj2 != null)
								{
									CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.PKCLDNQJMMH = false;
								}
							}
							if (this.FDINMJHGLQB)
							{
								int num7 = UnityEngine.Random.Range(0, 5);
								if (num7 == 0)
								{
									this.QJCBOEFQPGF("n", false, false, 0, 0, false);
								}
								else if (num7 == 1)
								{
									this.QJCBOEFQPGF("s", false, false, 0, 0, false);
								}
								else if (num7 == 2)
								{
									this.QJCBOEFQPGF("e", false, false, 0, 0, false);
								}
								else if (num7 == 3)
								{
									this.QJCBOEFQPGF("w", false, false, 0, 0, false);
								}
								else if (num7 == 4)
								{
									this.QJCBOEFQPGF("p", false, false, 0, 0, false);
								}
							}
						}
						if (flag3)
						{
							this.PDDEIHNJOGE.position = Vector3.MoveTowards(this.PDDEIHNJOGE.position, new Vector3(this.PCPQHQMBCBJ.x, this.OHPIPBHKEGC, this.PCPQHQMBCBJ.z), this.QCMIHCBOIJB * UnityEngine.Time.deltaTime);
							goto IL_1A38;
						}
						goto IL_1A38;
					}
				}
				else
				{
					if (this.BEQHNFFEHMQ > 0)
					{
						this.QKHFEMHPGKC += this.CLIJPELJNGJ * UnityEngine.Time.deltaTime;
						if (this.QKHFEMHPGKC >= 10f)
						{
							this.CBBPOGMKJIM += 1;
							this.QKHFEMHPGKC = 0f;
							if (this.CBBPOGMKJIM > 3)
							{
								this.CBBPOGMKJIM = 0;
							}
							if (this.EKEKMCMJEOC)
							{
								this.IFFEJHHMODI(this.BJGQDHPBCFC, this.CBBPOGMKJIM);
							}
							else
							{
								this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
							}
						}
					}
					if (UnityEngine.Time.time > this.JQBBIQFNONP + 0.35f)
					{
						this.JQBBIQFNONP = 0f;
					}
					if (UnityEngine.Time.time <= this.GGFNLMNGDJB + 0.2f)
					{
						goto IL_1A38;
					}
					this.GGFNLMNGDJB = 0f;
					if (!this.FONOKLECDFB && this.BEQHNFFEHMQ == 0)
					{
						this.CBBPOGMKJIM = 1;
						this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
						goto IL_1A38;
					}
					if (!(this.DCMGODHBJEC != null))
					{
						goto IL_1A38;
					}
					if (this.PDDEIHNJOGE.position.x < this.DCMGODHBJEC.PDDEIHNJOGE.position.x)
					{
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
						goto IL_1A38;
					}
					if (this.PDDEIHNJOGE.position.x > this.DCMGODHBJEC.PDDEIHNJOGE.position.x)
					{
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
						goto IL_1A38;
					}
					if (this.PDDEIHNJOGE.position.z < this.DCMGODHBJEC.PDDEIHNJOGE.position.z)
					{
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
						goto IL_1A38;
					}
					if (this.PDDEIHNJOGE.position.z > this.DCMGODHBJEC.PDDEIHNJOGE.position.z)
					{
						this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
						goto IL_1A38;
					}
					goto IL_1A38;
				}
			}
		}
		this.QKHFEMHPGKC += this.CLIJPELJNGJ * UnityEngine.Time.deltaTime;
		if (this.QKHFEMHPGKC >= 10f)
		{
			this.CBBPOGMKJIM += 1;
			this.QKHFEMHPGKC = 0f;
			if (this.CBBPOGMKJIM > 3)
			{
				this.CBBPOGMKJIM = 0;
			}
			this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
		}
		IL_1A38:
		if (!this.BHQOFDQCCCG)
		{
			this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
		}
		else if (this.PDDEIHNJOGE.position.y > this.OHPIPBHKEGC - 1.5f && this.PDDEIHNJOGE.position.y < this.OHPIPBHKEGC + 1.5f)
		{
			if (this.PDDEIHNJOGE.position.y <= this.OHPIPBHKEGC - 0.02f)
			{
				this.PDDEIHNJOGE.position += new Vector3(0f, 2f * UnityEngine.Time.deltaTime, 0f);
			}
			else if (this.PDDEIHNJOGE.position.y >= this.OHPIPBHKEGC + 0.02f)
			{
				this.PDDEIHNJOGE.position -= new Vector3(0f, 1f * UnityEngine.Time.deltaTime, 0f);
			}
			else
			{
				this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
			}
		}
		else
		{
			this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
		}
		if (this.MOEHFDNNLCB)
		{
			this.OBMGMDMMNOF.localPosition += new Vector3(0f, this.HEHMDILFLNF, 0f) * UnityEngine.Time.deltaTime;
			if (this.OBMGMDMMNOF.localPosition.y >= this.COBFPHNBPII)
			{
				this.MOEHFDNNLCB = false;
			}
		}
		else if (this.QCDHQOLHIEJ == 1)
		{
			this.OBMGMDMMNOF.localPosition += new Vector3(0f, 3f, 0f) * UnityEngine.Time.deltaTime;
			if (this.OBMGMDMMNOF.localPosition.y >= 2.5f)
			{
				this.QCDHQOLHIEJ = 2;
			}
		}
		else if (this.QCDHQOLHIEJ == 2)
		{
			if (this.OBMGMDMMNOF.localPosition.y > this.QHIODJLFPPG)
			{
				this.OBMGMDMMNOF.localPosition += new Vector3(0f, -3f, 0f) * UnityEngine.Time.deltaTime;
			}
			else
			{
				this.OBMGMDMMNOF.localPosition = this.QICPDBBKMHI;
				this.QCDHQOLHIEJ = 0;
			}
		}
		else if (this.OBMGMDMMNOF.localPosition.y < this.QHIODJLFPPG)
		{
			this.OBMGMDMMNOF.localPosition = this.QICPDBBKMHI;
		}
		else if (this.OBMGMDMMNOF.localPosition.y > this.QHIODJLFPPG)
		{
			this.OBMGMDMMNOF.localPosition += new Vector3(0f, -this.HEHMDILFLNF, 0f) * UnityEngine.Time.deltaTime;
		}
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x0018F18C File Offset: 0x0018D38C
	private bool CCPEMKDNELB(int FDICGOKLNLM, int IGNHJOPJDIO, int GLNJNHDILFP, ref Vector3 JNFLDQHODDQ, KJBDMOCFMCM GPJDBLNDGJP = null)
	{
		this.JPCQBEEHOJL = false;
		if (this.EMIEFKNMQMI.MountType == MountType.Surfing)
		{
			this.JPCQBEEHOJL = true;
		}
		if (this.LIQLFCKICLQ.LIQLFCKICLQ == null || this.LIQLFCKICLQ.HCQINBCDGNO)
		{
			return false;
		}
		if (IGNHJOPJDIO < 0 || IGNHJOPJDIO > this.LIQLFCKICLQ.LIQLFCKICLQ.height - 1 || FDICGOKLNLM < 0 || FDICGOKLNLM > this.LIQLFCKICLQ.LIQLFCKICLQ.width - 1)
		{
			return false;
		}
		int num = this.LIQLFCKICLQ.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		int num2 = 0;
		try
		{
			num2 = this.LIQLFCKICLQ.POMQCKOIKQJ[(int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z];
		}
		catch
		{
		}
		bool flag = false;
		bool flag2 = false;
		if (GLNJNHDILFP == 0)
		{
			if (num == 16 || num == 17 || num == 18 || num == 19 || num == 20)
			{
				flag = true;
			}
			if (num2 == 16 || num2 == 17 || num2 == 18)
			{
				flag2 = true;
			}
		}
		else if (GLNJNHDILFP == 1)
		{
			if (num == 21 || num == 22 || num == 23 || num == 19 || num == 20)
			{
				flag = true;
			}
			if (num2 == 21 || num2 == 22 || num2 == 23)
			{
				flag2 = true;
			}
		}
		else if (GLNJNHDILFP == 2)
		{
			if (num == 16 || num == 17 || num == 19 || num == 21 || num == 22)
			{
				flag = true;
			}
			if (num2 == 16 || num2 == 19 || num2 == 21)
			{
				flag2 = true;
			}
		}
		else if (GLNJNHDILFP == 3)
		{
			if (num == 17 || num == 18 || num == 20 || num == 22 || num == 23)
			{
				flag = true;
			}
			if (num2 == 18 || num2 == 20 || num2 == 23)
			{
				flag2 = true;
			}
		}
		if (this.KBKKMQNFJIG)
		{
			if (num != 11 && num != 12 && num != 13 && num != 14 && num != 15)
			{
				this.KGCEBGIHKKC = false;
				return false;
			}
			if (num == 11 || num == 12 || num == 13 || num == 14 || num == 15)
			{
				flag = true;
			}
		}
		else
		{
			if (num == 11 || num == 12 || num == 13)
			{
				flag = true;
			}
			if (num == 15 && this.JPCQBEEHOJL)
			{
				flag = true;
			}
		}
		if (flag2 || (!flag && (GLNJNHDILFP != 3 || num != 6) && (GLNJNHDILFP != 2 || num != 5) && (GLNJNHDILFP != 0 || num != 7) && (GLNJNHDILFP != 1 || num != 4) && (num != 25 && num != 26 && num != 27 && num != 28 && num != 29 && num != 30 && (num != 31 || !this.JPCQBEEHOJL)) && (num != 32 || !this.JPCQBEEHOJL) && (num != 33 || !this.JPCQBEEHOJL) && (num != 34 || !this.JPCQBEEHOJL) && num != 0 && num != 24 && num != 10 && num != 3 && (num != 2 || !this.JPCQBEEHOJL)))
		{
			this.KGCEBGIHKKC = false;
			return false;
		}
		if (GPJDBLNDGJP != null && GPJDBLNDGJP.BMFMKENMLNE(FDICGOKLNLM, IGNHJOPJDIO, this.PDDEIHNJOGE.position.y))
		{
			this.KGCEBGIHKKC = false;
			if (this.MMPQCIKNBQE)
			{
				DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = null;
				if (this.PJGOMOBBNLK.Count > 0)
				{
					jlkckmjegki = this.PJGOMOBBNLK[0];
				}
				this.NQJHJNQFKKC();
				this.MMPQCIKNBQE = true;
				this.GCCKFGHJFPO((int)this.HEODPPJFOLM.x, (int)this.HEODPPJFOLM.y, new Vector2((float)FDICGOKLNLM, (float)IGNHJOPJDIO));
				if (jlkckmjegki != null)
				{
					jlkckmjegki.PELCNBCMNFH = new Vector3((float)FDICGOKLNLM, jlkckmjegki.PELCNBCMNFH.y, (float)IGNHJOPJDIO);
					jlkckmjegki.BJIGIECDQPG = "b";
					this.PJGOMOBBNLK.Insert(0, jlkckmjegki);
				}
			}
			return false;
		}
		if (GLNJNHDILFP == 0 && num == 7)
		{
			this.EDHCHIGLKLF();
			JNFLDQHODDQ.z += 1f;
		}
		else if (GLNJNHDILFP == 1 && num == 4)
		{
			this.EDHCHIGLKLF();
			JNFLDQHODDQ.z += -1f;
		}
		else if (GLNJNHDILFP == 2 && num == 5)
		{
			this.EDHCHIGLKLF();
			JNFLDQHODDQ.x += -1f;
		}
		else if (GLNJNHDILFP == 3 && num == 6)
		{
			this.EDHCHIGLKLF();
			JNFLDQHODDQ.x += 1f;
		}
		if (this.JPCQBEEHOJL && num != 2 && num != 31 && num != 32 && num != 33 && num != 34 && num != 15 && !this.KBKKMQNFJIG)
		{
			this.JPCQBEEHOJL = false;
			this.EMIEFKNMQMI.MountType = MountType.None;
			this.NBDBHLEKENM();
		}
		if (this.KBKKMQNFJIG)
		{
			if (num == 12)
			{
				this.KBKKMQNFJIG = false;
			}
		}
		else if (num == 11)
		{
			this.KBKKMQNFJIG = true;
		}
		return true;
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x0018D198 File Offset: 0x0018B398
	public IEnumerator BGQBCLGHHMG()
	{
		if (this.PJGOMOBBNLK.Count <= 0)
		{
			yield return true;
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x0018F60C File Offset: 0x0018D80C
	private void OnDestroy()
	{
		if (this.OPILOFIJJDF != null)
		{
			UnityEngine.Object.Destroy(this.OPILOFIJJDF.gameObject);
		}
		if (this.HEDDMKGFMQO != null)
		{
			if (this.HEDDMKGFMQO.IHPIFPFEGNI != null)
			{
				UnityEngine.Object.Destroy(this.HEDDMKGFMQO.IHPIFPFEGNI.gameObject);
			}
			UnityEngine.Object.Destroy(this.HEDDMKGFMQO.gameObject);
		}
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x0018F680 File Offset: 0x0018D880
	public Vector3 QMCNCMNQEGL()
	{
		return new Vector3((float)Math.Round((double)this.PDDEIHNJOGE.position.x), this.OHPIPBHKEGC, -(float)Math.Round((double)this.PDDEIHNJOGE.position.z));
	}

	// Token: 0x06003407 RID: 13319 RVA: 0x0018F6D0 File Offset: 0x0018D8D0
	public void BCHILGCDEFP(Vector3 JNFLDQHODDQ, PSXAPI.Response.PlayerDirection PECKDHFNOKI = PSXAPI.Response.PlayerDirection.Default)
	{
		if (this.PDDEIHNJOGE == null)
		{
			this.PDDEIHNJOGE = base.transform;
		}
		this.BHQOFDQCCCG = false;
		this.OQJFBJQJEFG = 521f;
		this.PDDEIHNJOGE.position = JNFLDQHODDQ;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		bool[] array = new bool[5];
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 0) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 0) == -32)
		{
			array[0] = false;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 93)
		{
			array[1] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 0, -(int)JNFLDQHODDQ.z) == -18)
		{
			array[8] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 0, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 0, -(int)JNFLDQHODDQ.z) == -4)
		{
			array[3] = true;
		}
		if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Default)
		{
			switch (this.DIEOHLOINHH)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				this.ILBEOBOIHJE = (PSXAPI.Response.PlayerDirection)5;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				this.ILBEOBOIHJE = (PSXAPI.Response.PlayerDirection)7;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				this.ILBEOBOIHJE = (PSXAPI.Response.PlayerDirection)7;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Default;
				break;
			}
			PECKDHFNOKI = this.ILBEOBOIHJE;
		}
		if (PECKDHFNOKI != PSXAPI.Response.PlayerDirection.Default)
		{
			this.ILBEOBOIHJE = PECKDHFNOKI;
			if (PECKDHFNOKI == (PSXAPI.Response.PlayerDirection)8)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 628.0)
				{
					if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1925f, 907f, 1466f);
					}
					else if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(719f, 83f, 1041f);
					}
					else if (array[8])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(904f, 1922f, 1599f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1299f, 29f, 379f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1186f, 870f, 585f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Up)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)5;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 171.0)
				{
					if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(171f, 97f, 1941f);
					}
					else if (array[5])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(613f, 944f, 1178f);
					}
					else if (array[5])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(613f, 415f, 1084f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1802f, 633f, 246f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(176f, 151f, 777f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Right)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1856.0)
				{
					if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1370f, 1212f, 1996f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1232f, 33f, 748f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(830f, 1411f, 631f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(736f, 1369f, 1131f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1494f, 1470f, 97f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Left)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)7;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1309.0)
				{
					if (array[5])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(511f, 298f, 226f);
					}
					else if (array[7])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(940f, 693f, 433f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(306f, 1140f, 1195f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(726f, 728f, 1227f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(55f, 1711f, 1144f);
					}
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1249.0)
			{
				if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1672f, 369f, 929f);
				}
				else if (array[8])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(876f, 1044f, 656f);
				}
				else if (array[5])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(813f, 226f, 90f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(187f, 701f, 1698f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(331f, 1486f, 1093f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 930.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1105f, 1491f, 1677f);
				}
				else if (array[4])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(642f, 402f, 267f);
				}
				else if (array[6])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(386f, 1659f, 1377f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1598f, 839f, 1929f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1297f, 1849f, 63f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1649.0)
			{
				if (array[7])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(948f, 1493f, 914f);
				}
				else if (array[4])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(782f, 539f, 27f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1723f, 224f, 50f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(319f, 1010f, 567f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(878f, 1251f, 982f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 641.0)
			{
				if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1891f, 426f, 566f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(980f, 588f, 1861f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1034f, 1637f, 1029f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1152f, 1625f, 1611f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(576f, 572f, 131f);
				}
			}
		}
		else if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 103.0)
		{
			this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(374f, 737f, 1691f);
		}
		if (this.HLGCFHIMHFQ == null)
		{
			this.HLGCFHIMHFQ = DOJNBQQBCQJ.QOQONHOOLNE;
		}
		if (!this.FONOKLECDFB)
		{
			for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
			{
				Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
				Vector2 vector = new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z) - new Vector2(transform.position.x, transform.position.z);
				float num = vector.x * vector.x + vector.y * vector.y;
				if (num < 1608f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
				{
					this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(this.PQNJEKIPLDI);
				}
			}
			if (this.PQNJEKIPLDI && this.PKCLDNQJMMH)
			{
				if (this.BOGKQOEEBFK == null)
				{
					this.BOGKQOEEBFK = KJBDMOCFMCM.BBCBOIFQDBK();
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NPEQHOQCIJN();
				if (nhgkgbgjefj != null)
				{
					this.PKCLDNQJMMH = true;
				}
			}
		}
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x0019018C File Offset: 0x0018E38C
	private void NHLEIQFNHNM()
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		if (this.FONOKLECDFB)
		{
			this.KBKKMQNFJIG = this.DCMGODHBJEC.KBKKMQNFJIG;
		}
		if (this.IEFBCKQJBGN == null && !this.KBKKMQNFJIG)
		{
			float num = 201f;
			if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.EQQLIPKQOJP != null && this.LIQLFCKICLQ.LIQLFCKICLQ != null)
			{
				if ((int)this.PDDEIHNJOGE.position.x < this.LIQLFCKICLQ.LIQLFCKICLQ.width && -(int)this.PDDEIHNJOGE.position.z < this.LIQLFCKICLQ.LIQLFCKICLQ.height && this.LIQLFCKICLQ.POMQCKOIKQJ[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z] == 81)
				{
					int[] array = new int[8];
					array[1] = this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z - 1];
					array[0] = this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z + 0];
					array[5] = this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x - 0, -(int)this.PDDEIHNJOGE.position.z];
					array[4] = this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x + 0, -(int)this.PDDEIHNJOGE.position.z];
					int[] array2 = array;
					int num2 = -17;
					for (int i = 1; i < array2.Length; i++)
					{
						if (array2[i] <= num2)
						{
							num2 = array2[i];
						}
					}
					this.OHPIPBHKEGC = (float)num2 + 682f;
					return;
				}
				if ((int)this.PDDEIHNJOGE.position.x < this.LIQLFCKICLQ.LIQLFCKICLQ.width && -(int)this.PDDEIHNJOGE.position.z < this.LIQLFCKICLQ.LIQLFCKICLQ.height)
				{
					num = (float)this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z];
				}
			}
			if (this.JPCQBEEHOJL)
			{
				num += 1063f;
			}
			if (Physics.Raycast(new Vector3(this.PDDEIHNJOGE.position.x + 1658f, num + 112f, this.PDDEIHNJOGE.position.z - 1020f), -Vector3.up, out this.GHNNQBLIFNE, 169f, this.QMOMPLCPFMH))
			{
				this.OHPIPBHKEGC = num + 1894f - this.GHNNQBLIFNE.distance + 1154f;
				if (this.OHPIPBHKEGC > 301f || this.OHPIPBHKEGC < 1074f)
				{
					this.OHPIPBHKEGC = 78f;
				}
			}
		}
		else if (Physics.Raycast(new Vector3(this.PDDEIHNJOGE.position.x + 1059f, 321f, this.PDDEIHNJOGE.position.z - 1871f), -Vector3.up, out this.GHNNQBLIFNE, 1374f, this.QMOMPLCPFMH))
		{
			this.OHPIPBHKEGC = 1104f - this.GHNNQBLIFNE.distance + 667f;
			if (this.OHPIPBHKEGC > 1233f || this.OHPIPBHKEGC < 1040f)
			{
				this.OHPIPBHKEGC = 754f;
			}
		}
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x001905E0 File Offset: 0x0018E7E0
	public bool GEELOIIHGBK(Vector3 JNFLDQHODDQ)
	{
		this.OQJFBJQJEFG = 1796f;
		this.BNIGIJDGJKM = Vector2.Distance(new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z), new Vector2(this.PDDEIHNJOGE.position.x, this.PDDEIHNJOGE.position.z));
		this.ODGQNNEDJIF = this.PDDEIHNJOGE.position;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
		this.BHQOFDQCCCG = false;
		return true;
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x00190674 File Offset: 0x0018E874
	private void LCLQHIKFJMG(int CIQFCJGQEMH)
	{
		this.KKJPFIBDNJI.gameObject.SetActive(false);
		for (int i = 0; i < this.MGDBGBLMKQH.Length; i++)
		{
			this.MGDBGBLMKQH[i].SetActive(false);
		}
		if (this.NEGLQQQDBEE != null)
		{
			this.NEGLQQQDBEE.SetActive(false);
		}
		this.MGDBGBLMKQH[CIQFCJGQEMH].SetActive(true);
		if (CIQFCJGQEMH == 29 && this.KFNLCPGHQHK)
		{
			this.MGDBGBLMKQH[30].SetActive(true);
		}
		else if (CIQFCJGQEMH > 2 && CIQFCJGQEMH < 6 && this.KFNLCPGHQHK)
		{
			if (this.ICHKBBMBPGM == "berry_1")
			{
				this.MGDBGBLMKQH[9].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_2")
			{
				this.MGDBGBLMKQH[13].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_3")
			{
				this.MGDBGBLMKQH[12].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_4")
			{
				this.MGDBGBLMKQH[10].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_5")
			{
				this.MGDBGBLMKQH[11].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_6")
			{
				this.MGDBGBLMKQH[9].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_7")
			{
				this.MGDBGBLMKQH[13].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_8")
			{
				this.MGDBGBLMKQH[12].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_9")
			{
				this.MGDBGBLMKQH[10].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_10")
			{
				this.MGDBGBLMKQH[11].SetActive(true);
			}
		}
		else if (CIQFCJGQEMH == 15 && this.KFNLCPGHQHK)
		{
			if (this.ICHKBBMBPGM == "berry_11")
			{
				this.MGDBGBLMKQH[16].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_12")
			{
				this.MGDBGBLMKQH[17].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_13")
			{
				this.MGDBGBLMKQH[18].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_14")
			{
				this.MGDBGBLMKQH[19].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_15")
			{
				this.MGDBGBLMKQH[20].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_16")
			{
				this.MGDBGBLMKQH[21].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "berry_17")
			{
				this.MGDBGBLMKQH[22].SetActive(true);
			}
		}
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x0001740B File Offset: 0x0001560B
	public void JKHPICBQMMG(string CQJEODOLEKE)
	{
		this.JMJDPHJNNCI(CQJEODOLEKE, false, true, 0, 1, false);
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x001909A4 File Offset: 0x0018EBA4
	public void EDMFOMGFMGD(Vector3 JNFLDQHODDQ)
	{
		this.OQJFBJQJEFG = 0f;
		this.BNIGIJDGJKM = Vector2.Distance(new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z), new Vector2(this.PDDEIHNJOGE.position.x, this.PDDEIHNJOGE.position.z));
		this.ODGQNNEDJIF = this.PDDEIHNJOGE.position;
		this.BHQOFDQCCCG = true;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00017419 File Offset: 0x00015619
	private void IIDOKQKKFQF()
	{
		this.HEDDMKGFMQO = UnityEngine.Object.Instantiate<NLDFFJFQJBI>(this.HFFFEDCGPBD);
		this.HEDDMKGFMQO.transform.parent = this.FQLIOJQIKME;
		this.HEDDMKGFMQO.JJDIJNQGDMG(this.PDDEIHNJOGE);
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x00190A34 File Offset: 0x0018EC34
	public void ILNILOBFBMJ()
	{
		if (this.PKCLDNQJMMH)
		{
			if (this.BOGKQOEEBFK == null)
			{
				this.BOGKQOEEBFK = KJBDMOCFMCM.GHFFHFCEENG();
			}
			KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.OJQEQJFFHOE();
			if (nhgkgbgjefj != null)
			{
				this.PKCLDNQJMMH = true;
			}
		}
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x00190A78 File Offset: 0x0018EC78
	public bool NCDDEEGIEEK(Vector3 JNFLDQHODDQ)
	{
		this.OQJFBJQJEFG = 0f;
		this.BNIGIJDGJKM = Vector2.Distance(new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z), new Vector2(this.PDDEIHNJOGE.position.x, this.PDDEIHNJOGE.position.z));
		this.ODGQNNEDJIF = this.PDDEIHNJOGE.position;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
		this.BHQOFDQCCCG = true;
		return true;
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x00190B0C File Offset: 0x0018ED0C
	public int DHPIGECQMMM(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (this.LIQLFCKICLQ.LIQLFCKICLQ == null)
		{
			return 1;
		}
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.LIQLFCKICLQ.width - 1)
		{
			return this.LIQLFCKICLQ.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 1;
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x00017453 File Offset: 0x00015653
	private void FixedUpdate()
	{
		this.BKFBOCMOOHH();
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x00190B70 File Offset: 0x0018ED70
	public void EPGFNQMLNBP()
	{
		for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
		{
			Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
			Vector2 vector = new Vector2((float)((int)this.PDDEIHNJOGE.position.x), (float)((int)this.PDDEIHNJOGE.position.z)) - new Vector2(transform.position.x, transform.position.z);
			float num = vector.x * vector.x + vector.y * vector.y;
			if (num < 4f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
			{
				this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(true);
			}
		}
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x00190C68 File Offset: 0x0018EE68
	private void PIJDCPPOGBN(int CIQFCJGQEMH)
	{
		this.KKJPFIBDNJI.gameObject.SetActive(false);
		for (int i = 0; i < this.MGDBGBLMKQH.Length; i += 0)
		{
			this.MGDBGBLMKQH[i].SetActive(false);
		}
		if (this.NEGLQQQDBEE != null)
		{
			this.NEGLQQQDBEE.SetActive(true);
		}
		this.MGDBGBLMKQH[CIQFCJGQEMH].SetActive(true);
		if (CIQFCJGQEMH == 16 && this.KFNLCPGHQHK)
		{
			this.MGDBGBLMKQH[119].SetActive(false);
		}
		else if (CIQFCJGQEMH > 0 && CIQFCJGQEMH < 3 && this.KFNLCPGHQHK)
		{
			if (this.ICHKBBMBPGM == "switcheroo")
			{
				this.MGDBGBLMKQH[100].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "rockclimb")
			{
				this.MGDBGBLMKQH[-115].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "SOURCE_GBUFFER")
			{
				this.MGDBGBLMKQH[-105].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "BattlePoke")
			{
				this.MGDBGBLMKQH[31].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "1")
			{
				this.MGDBGBLMKQH[-97].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "perishsong")
			{
				this.MGDBGBLMKQH[-20].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "*")
			{
				this.MGDBGBLMKQH[19].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "Player/Hair")
			{
				this.MGDBGBLMKQH[-48].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "SSAO")
			{
				this.MGDBGBLMKQH[113].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "[pok=")
			{
				this.MGDBGBLMKQH[102].SetActive(false);
			}
		}
		else if (CIQFCJGQEMH == -17 && this.KFNLCPGHQHK)
		{
			if (this.ICHKBBMBPGM == "SSAO")
			{
				this.MGDBGBLMKQH[121].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == " woke it up!\r\n")
			{
				this.MGDBGBLMKQH[115].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "Enabled")
			{
				this.MGDBGBLMKQH[108].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "Ambient Occlusion")
			{
				this.MGDBGBLMKQH[-24].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "/01_")
			{
				this.MGDBGBLMKQH[54].SetActive(true);
			}
			else if (this.ICHKBBMBPGM == "[PD]")
			{
				this.MGDBGBLMKQH[122].SetActive(false);
			}
			else if (this.ICHKBBMBPGM == "0")
			{
				this.MGDBGBLMKQH[-93].SetActive(false);
			}
		}
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x00190F98 File Offset: 0x0018F198
	public void BQLIIQIIMDH(GFHGEJNHLFQ BPECIEFFNKI, MCNLIHMMLCF OQHGHICKDLE, Transform EDQGILBMJDH, int CGGNJLOGOLM = -1, int IKIJBQLMKJO = 0)
	{
		if (this.NEGLQQQDBEE != null)
		{
			this.HKHDIIGNEFB = this.NEGLQQQDBEE.GetComponent<Renderer>().material;
		}
		this.BEQHNFFEHMQ = IKIJBQLMKJO;
		this.MFJBPKBNBNO = CGGNJLOGOLM;
		this.QIDKBCQIGOD = BPECIEFFNKI;
		this.LIQLFCKICLQ = OQHGHICKDLE;
		if (EDQGILBMJDH != null)
		{
			this.FQLIOJQIKME = EDQGILBMJDH;
		}
		if (this.PDDEIHNJOGE == null)
		{
			this.PDDEIHNJOGE = base.transform;
		}
		if (this.LMDQJKGHBGD)
		{
			if (this.OPILOFIJJDF == null)
			{
				this.OPILOFIJJDF = UnityEngine.Object.Instantiate<NOHCFICLIQK>(this.HQCPKMDMFCN, this.FQLIOJQIKME);
				this.OPILOFIJJDF.transform.localScale = new Vector3(1f, 1f, 1f);
				this.OPILOFIJJDF.ILBCCCBJNCL = this.PDDEIHNJOGE;
				this.OPILOFIJJDF.JJMDLPEJOCK();
			}
		}
		else
		{
			this.KKJPFIBDNJI.material.SetFloat("_Dissolve", 0f);
		}
		this.PDDEIHNJOGE = base.GetComponent<Transform>();
		this.NBDBHLEKENM();
		this.IFFEJHHMODI(DJOOHHIQGJK.JDQNKBIDIKE.Down, 1);
		if (this.MJLLNNIFGNN)
		{
			this.IIDOKQKKFQF();
		}
		if (this.HLGCFHIMHFQ == null)
		{
			this.HLGCFHIMHFQ = DOJNBQQBCQJ.QOQONHOOLNE;
		}
		this.PHMOJLGOPHF = true;
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x001910E4 File Offset: 0x0018F2E4
	public bool EDMFOMGFMGD(int GLNJNHDILFP, KJBDMOCFMCM GPJDBLNDGJP = null, bool PLGEGGGNECI = false, int CIDJCBEBMHG = 0, int MJPEFFPPPHL = 0, int GOKGLGPCPIJ = 0, bool FPBQFQEJOLB = false, bool BQKFPLQCOHH = false)
	{
		if (PLGEGGGNECI && !this.FONOKLECDFB && this.BHQOFDQCCCG)
		{
			if (this.GQFBLMFFQID)
			{
				string cqjeodoleke = "p";
				switch (GLNJNHDILFP)
				{
				case 0:
					cqjeodoleke = "u";
					break;
				case 1:
					cqjeodoleke = "d";
					break;
				case 2:
					cqjeodoleke = "l";
					break;
				case 3:
					cqjeodoleke = "r";
					break;
				case 4:
					cqjeodoleke = "1";
					break;
				case 5:
					cqjeodoleke = "2";
					break;
				case 6:
					cqjeodoleke = "3";
					break;
				case 7:
					cqjeodoleke = "4";
					break;
				case 8:
					cqjeodoleke = "o";
					break;
				case 9:
					cqjeodoleke = "a";
					break;
				case 10:
					cqjeodoleke = "i";
					break;
				}
				this.QJCBOEFQPGF(cqjeodoleke, new Vector3((float)CIDJCBEBMHG, this.OHPIPBHKEGC, (float)MJPEFFPPPHL), true, GOKGLGPCPIJ);
			}
			return false;
		}
		Vector3 vector = new Vector3((float)Math.Round((double)this.PDDEIHNJOGE.position.x), this.OHPIPBHKEGC, (float)Math.Round((double)this.PDDEIHNJOGE.position.z));
		this.ODGQNNEDJIF = vector;
		this.BNIGIJDGJKM = 1f;
		if (GLNJNHDILFP == 0)
		{
			if (this.CQBGCNEDIFE)
			{
				if (this.CCPEMKDNELB((int)vector.x, (int)(-(int)(vector.z + 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP))
				{
					if (BQKFPLQCOHH)
					{
						this.NNFBFBEPIIJ((int)vector.x, (int)(-(int)(vector.z + 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
						if (this.ODGQNNEDJIF != vector && this.PJGOMOBBNLK.Count > 1)
						{
							this.PJGOMOBBNLK.RemoveAt(1);
						}
					}
					vector.z += 1f;
				}
				else if (this.MMPQCIKNBQE)
				{
					return false;
				}
			}
			else
			{
				this.NNFBFBEPIIJ((int)vector.x, (int)(-(int)(vector.z + 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
				if (!this.PQNJEKIPLDI && BQKFPLQCOHH && this.ODGQNNEDJIF != vector)
				{
					if (this.PJGOMOBBNLK.Count > 1 && this.PJGOMOBBNLK[1].BJIGIECDQPG == "u")
					{
						this.PJGOMOBBNLK.RemoveAt(1);
					}
					this.BNIGIJDGJKM = 2f;
				}
				vector.z += 1f;
			}
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		else if (GLNJNHDILFP == 1)
		{
			if (this.CQBGCNEDIFE)
			{
				if (this.CCPEMKDNELB((int)vector.x, (int)(-(int)(vector.z - 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP))
				{
					if (BQKFPLQCOHH)
					{
						this.NNFBFBEPIIJ((int)vector.x, (int)(-(int)(vector.z - 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
						if (this.ODGQNNEDJIF != vector && this.PJGOMOBBNLK.Count > 1)
						{
							this.PJGOMOBBNLK.RemoveAt(1);
						}
					}
					vector.z += -1f;
				}
				else if (this.MMPQCIKNBQE)
				{
					return false;
				}
			}
			else
			{
				this.NNFBFBEPIIJ((int)vector.x, (int)(-(int)(vector.z - 1f)), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
				if (!this.PQNJEKIPLDI && BQKFPLQCOHH && this.ODGQNNEDJIF != vector)
				{
					if (this.PJGOMOBBNLK.Count > 1 && this.PJGOMOBBNLK[1].BJIGIECDQPG == "d")
					{
						this.PJGOMOBBNLK.RemoveAt(1);
					}
					this.BNIGIJDGJKM = 2f;
				}
				vector.z += -1f;
			}
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GLNJNHDILFP == 2)
		{
			if (this.CQBGCNEDIFE)
			{
				if (this.CCPEMKDNELB((int)vector.x - 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP))
				{
					if (BQKFPLQCOHH)
					{
						this.NNFBFBEPIIJ((int)vector.x - 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
						if (this.ODGQNNEDJIF != vector && this.PJGOMOBBNLK.Count > 1)
						{
							this.PJGOMOBBNLK.RemoveAt(1);
						}
					}
					vector.x += -1f;
				}
				else if (this.MMPQCIKNBQE)
				{
					return false;
				}
			}
			else
			{
				this.NNFBFBEPIIJ((int)vector.x - 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
				if (!this.PQNJEKIPLDI && BQKFPLQCOHH && this.ODGQNNEDJIF != vector)
				{
					if (this.PJGOMOBBNLK.Count > 1 && this.PJGOMOBBNLK[1].BJIGIECDQPG == "l")
					{
						this.PJGOMOBBNLK.RemoveAt(1);
					}
					this.BNIGIJDGJKM = 2f;
				}
				vector.x += -1f;
			}
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GLNJNHDILFP == 3)
		{
			if (this.CQBGCNEDIFE)
			{
				if (this.CCPEMKDNELB((int)vector.x + 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP))
				{
					if (BQKFPLQCOHH)
					{
						this.NNFBFBEPIIJ((int)vector.x + 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
						if (this.ODGQNNEDJIF != vector && this.PJGOMOBBNLK.Count > 1)
						{
							this.PJGOMOBBNLK.RemoveAt(1);
						}
					}
					vector.x += 1f;
				}
				else if (this.MMPQCIKNBQE)
				{
					return false;
				}
			}
			else
			{
				this.NNFBFBEPIIJ((int)vector.x + 1, (int)(-(int)vector.z), GLNJNHDILFP, ref vector, GPJDBLNDGJP);
				if (!this.PQNJEKIPLDI && BQKFPLQCOHH && this.ODGQNNEDJIF != vector)
				{
					if (this.PJGOMOBBNLK.Count > 1 && this.PJGOMOBBNLK[1].BJIGIECDQPG == "r")
					{
						this.PJGOMOBBNLK.RemoveAt(1);
					}
					this.BNIGIJDGJKM = 2f;
				}
				vector.x += 1f;
			}
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GLNJNHDILFP == 4)
		{
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Up;
		}
		else if (GLNJNHDILFP == 5)
		{
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
		}
		else if (GLNJNHDILFP == 6)
		{
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
		}
		else if (GLNJNHDILFP == 7)
		{
			this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Right;
		}
		else if (GLNJNHDILFP == 8)
		{
			this.DBGMJPEMPQC = UnityEngine.Time.time;
			this.LJDKPJCDCCM = true;
		}
		else if (GLNJNHDILFP == 9)
		{
			this.DBGMJPEMPQC = UnityEngine.Time.time;
			this.LJDKPJCDCCM = false;
		}
		if (vector.x != this.PDDEIHNJOGE.position.x || vector.z != this.PDDEIHNJOGE.position.z)
		{
			this.FQGJJOLGJFE = new Vector3((float)Math.Round((double)this.PDDEIHNJOGE.position.x), this.OHPIPBHKEGC, (float)Math.Round((double)this.PDDEIHNJOGE.position.z));
		}
		this.PCPQHQMBCBJ = vector;
		if (!this.KGCEBGIHKKC)
		{
			this.IFFEJHHMODI(this.DIEOHLOINHH, this.CBBPOGMKJIM);
		}
		this.BHQOFDQCCCG = true;
		if (!this.FONOKLECDFB && !this.PQNJEKIPLDI)
		{
			for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
			{
				Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
				Vector2 vector2 = new Vector2(vector.x, vector.z) - new Vector2(transform.position.x, transform.position.z);
				float num = vector2.x * vector2.x + vector2.y * vector2.y;
				if (num < 4f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
				{
					this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(false);
				}
			}
			int num2 = this.IEFQGONIEFN((int)vector.x, -(int)vector.z);
			if (this.GQFBLMFFQID)
			{
				if (GOKGLGPCPIJ == 0)
				{
					this.KBKKMQNFJIG = false;
				}
				else
				{
					this.KBKKMQNFJIG = true;
				}
				if (num2 == 12)
				{
					this.KBKKMQNFJIG = false;
				}
				if (num2 == 11)
				{
					this.KBKKMQNFJIG = true;
				}
			}
			if (this.EMIEFKNMQMI.MountType == MountType.Surfing)
			{
				if (GLNJNHDILFP < 4 && num2 != 31 && num2 != 32 && num2 != 33 && num2 != 34 && num2 != 2 && num2 != 15 && !this.KBKKMQNFJIG)
				{
					this.EMIEFKNMQMI.MountType = MountType.None;
					this.NBDBHLEKENM();
				}
			}
			else if (!this.PQNJEKIPLDI && this.EMIEFKNMQMI.MountType == MountType.None && GLNJNHDILFP < 4 && (num2 == 2 || (num2 == 15 && this.KBKKMQNFJIG)))
			{
				this.EMIEFKNMQMI.MountType = this.GIBFBFJHNKH.MountType;
				this.EMIEFKNMQMI.MountID = this.GIBFBFJHNKH.MountID;
				this.NBDBHLEKENM();
			}
		}
		if (vector != new Vector3((float)Math.Round((double)this.PDDEIHNJOGE.position.x), this.OHPIPBHKEGC, (float)Math.Round((double)this.PDDEIHNJOGE.position.z)))
		{
			return true;
		}
		if (this.PQNJEKIPLDI && CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			this.NQJHJNQFKKC();
		}
		return false;
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00191A7C File Offset: 0x0018FC7C
	public int IEFQGONIEFN(int FDICGOKLNLM, int IGNHJOPJDIO)
	{
		if (this.LIQLFCKICLQ.LIQLFCKICLQ == null)
		{
			return 0;
		}
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.LIQLFCKICLQ.width - 1)
		{
			return this.LIQLFCKICLQ.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
		}
		return 0;
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x00191AE0 File Offset: 0x0018FCE0
	private void NNFBFBEPIIJ(int FDICGOKLNLM, int IGNHJOPJDIO, int GLNJNHDILFP, ref Vector3 JNFLDQHODDQ, KJBDMOCFMCM GPJDBLNDGJP = null)
	{
		if (this.LIQLFCKICLQ.LIQLFCKICLQ == null)
		{
			return;
		}
		if (IGNHJOPJDIO >= 0 && IGNHJOPJDIO <= this.LIQLFCKICLQ.LIQLFCKICLQ.height - 1 && FDICGOKLNLM >= 0 && FDICGOKLNLM <= this.LIQLFCKICLQ.LIQLFCKICLQ.width - 1)
		{
			int num = this.LIQLFCKICLQ.POMQCKOIKQJ[FDICGOKLNLM, IGNHJOPJDIO];
			if (GLNJNHDILFP == 0 && num == 7)
			{
				this.EDHCHIGLKLF();
				JNFLDQHODDQ.z += 1f;
			}
			else if (GLNJNHDILFP == 1 && num == 4)
			{
				this.EDHCHIGLKLF();
				JNFLDQHODDQ.z += -1f;
			}
			else if (GLNJNHDILFP == 2 && num == 5)
			{
				this.EDHCHIGLKLF();
				JNFLDQHODDQ.x += -1f;
			}
			else if (GLNJNHDILFP == 3 && num == 6)
			{
				this.EDHCHIGLKLF();
				JNFLDQHODDQ.x += 1f;
			}
			return;
		}
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x00191BD8 File Offset: 0x0018FDD8
	private void EJCHKLBMECH()
	{
		if (this.FONOKLECDFB)
		{
			if (this.DCMGODHBJEC == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.DCMGODHBJEC.OPILOFIJJDF != null)
			{
				this.KKJPFIBDNJI.material.SetFloat("'.", 1769f - this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 269f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(1870f, 898f, 1191f, this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 1875f);
				}
			}
		}
		if (this.OPILOFIJJDF != null)
		{
			if (this.LJDKPJCDCCM)
			{
				if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP > 850f)
				{
					this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP -= 30f * UnityEngine.Time.deltaTime;
					this.KKJPFIBDNJI.material.SetFloat("[-] activated!\r\n", 1904f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 1295f);
					if (this.HKHDIIGNEFB != null)
					{
						this.HKHDIIGNEFB.color = new Color(1946f, 1262f, 1270f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 898f);
					}
				}
			}
			else if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP < 1707f)
			{
				this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP += 917f * UnityEngine.Time.deltaTime;
				this.KKJPFIBDNJI.material.SetFloat("Iron Barbs", 41f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 1031f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(795f, 1762f, 506f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 740f);
				}
			}
		}
		if (this.LJDKPJCDCCM && UnityEngine.Time.time > this.DBGMJPEMPQC + 1854f)
		{
			CGOIPHKQMPD.BDPEQNCNPJO().ENJDOJFQIGQ(this);
			return;
		}
		if (!this.PHMOJLGOPHF)
		{
			return;
		}
		this.FDBLQDEOENF();
		this.JBJIQOFPPHE = false;
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00191E5C File Offset: 0x0019005C
	public void CDJGIHCQFNB()
	{
		for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
		{
			Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
			Vector2 vector = new Vector2((float)((int)this.PDDEIHNJOGE.position.x), (float)((int)this.PDDEIHNJOGE.position.z)) - new Vector2(transform.position.x, transform.position.z);
			float num = vector.x * vector.x + vector.y * vector.y;
			if (num < 617f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
			{
				this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(false);
			}
		}
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x0001745B File Offset: 0x0001565B
	private void Start()
	{
		if (this.PQNJEKIPLDI)
		{
			this.BQLIIQIIMDH(GFHGEJNHLFQ.QOQONHOOLNE, MCNLIHMMLCF.QOQONHOOLNE, null, -1, 0);
		}
		if (this.FONOKLECDFB && !this.PHMOJLGOPHF)
		{
			this.BQLIIQIIMDH(GFHGEJNHLFQ.QOQONHOOLNE, MCNLIHMMLCF.QOQONHOOLNE, null, -1, 0);
		}
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x00191F54 File Offset: 0x00190154
	public void QJCBOEFQPGF(string CQJEODOLEKE, Vector3 EBOMCPQBKJG, bool EFQMQOPCBNO = false, int GOKGLGPCPIJ = 0)
	{
		DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
		jlkckmjegki.BJIGIECDQPG = CQJEODOLEKE;
		jlkckmjegki.PELCNBCMNFH = EBOMCPQBKJG;
		jlkckmjegki.QEEPJBBJGQM = EFQMQOPCBNO;
		if (GOKGLGPCPIJ == 1)
		{
			jlkckmjegki.MBODJJEPJHD = true;
		}
		else
		{
			jlkckmjegki.MBODJJEPJHD = false;
		}
		this.PJGOMOBBNLK.Add(jlkckmjegki);
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x0001749B File Offset: 0x0001569B
	public void BKNILGHMOCB(Equip GBQOIGLGLMI)
	{
		if (GBQOIGLGLMI != null)
		{
			this.OFLGFDNHKJO = GBQOIGLGLMI;
		}
		this.DBGLGGODDOH();
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x00191FA0 File Offset: 0x001901A0
	public void BPQOIEJCNCI(string CQJEODOLEKE, bool GKHQCBGIOFP, bool EFQMQOPCBNO = false, int DGKOIGOLHDM = 0, int DDLQKFDFMCJ = 0, bool FPBQFQEJOLB = false)
	{
		DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
		jlkckmjegki.BJIGIECDQPG = CQJEODOLEKE;
		if (this.PJGOMOBBNLK.Count == 0)
		{
			jlkckmjegki.PELCNBCMNFH = this.PDDEIHNJOGE.position;
			this.JPOBLCQMKHC = this.PDDEIHNJOGE.position;
		}
		else
		{
			jlkckmjegki.PELCNBCMNFH = this.JPOBLCQMKHC;
		}
		if (CQJEODOLEKE == "Enabled")
		{
			this.JPOBLCQMKHC += new Vector3(1036f, 1415f, 1752f);
		}
		if (CQJEODOLEKE == " PM")
		{
			this.JPOBLCQMKHC += new Vector3(728f, 1092f, 1878f);
		}
		if (CQJEODOLEKE == " surrounds itself with electrified terrain!\r\n")
		{
			this.JPOBLCQMKHC += new Vector3(230f, 1158f, 1254f);
		}
		if (CQJEODOLEKE == "´")
		{
			this.JPOBLCQMKHC += new Vector3(1126f, 1131f, 1845f);
		}
		if (CQJEODOLEKE == " @ ")
		{
			jlkckmjegki.PELCNBCMNFH = new Vector3((float)DGKOIGOLHDM, this.OHPIPBHKEGC, (float)(-(float)DDLQKFDFMCJ));
		}
		jlkckmjegki.PCGDFKDQHGH = GKHQCBGIOFP;
		jlkckmjegki.QEEPJBBJGQM = EFQMQOPCBNO;
		jlkckmjegki.EBBBQJELOFF = FPBQFQEJOLB;
		this.PJGOMOBBNLK.Add(jlkckmjegki);
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x00192108 File Offset: 0x00190308
	public void JMJDPHJNNCI(string CQJEODOLEKE, bool GKHQCBGIOFP, bool EFQMQOPCBNO = false, int DGKOIGOLHDM = 0, int DDLQKFDFMCJ = 0, bool FPBQFQEJOLB = false)
	{
		DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
		jlkckmjegki.BJIGIECDQPG = CQJEODOLEKE;
		if (this.PJGOMOBBNLK.Count == 0)
		{
			jlkckmjegki.PELCNBCMNFH = this.PDDEIHNJOGE.position;
			this.JPOBLCQMKHC = this.PDDEIHNJOGE.position;
		}
		else
		{
			jlkckmjegki.PELCNBCMNFH = this.JPOBLCQMKHC;
		}
		if (CQJEODOLEKE == "psn")
		{
			this.JPOBLCQMKHC += new Vector3(1897f, 930f, 1603f);
		}
		if (CQJEODOLEKE == "VolumetricFogAndMist/CopyDepth")
		{
			this.JPOBLCQMKHC += new Vector3(1495f, 408f, 1368f);
		}
		if (CQJEODOLEKE == "shaymin")
		{
			this.JPOBLCQMKHC += new Vector3(753f, 1262f, 1778f);
		}
		if (CQJEODOLEKE == "_FogAlpha")
		{
			this.JPOBLCQMKHC += new Vector3(964f, 53f, 1630f);
		}
		if (CQJEODOLEKE == "Trade Error")
		{
			jlkckmjegki.PELCNBCMNFH = new Vector3((float)DGKOIGOLHDM, this.OHPIPBHKEGC, (float)(-(float)DDLQKFDFMCJ));
		}
		jlkckmjegki.PCGDFKDQHGH = GKHQCBGIOFP;
		jlkckmjegki.QEEPJBBJGQM = EFQMQOPCBNO;
		jlkckmjegki.EBBBQJELOFF = FPBQFQEJOLB;
		this.PJGOMOBBNLK.Add(jlkckmjegki);
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x00192270 File Offset: 0x00190470
	public void MELOIMCMIGN()
	{
		if (this.PKCLDNQJMMH)
		{
			if (this.BOGKQOEEBFK == null)
			{
				this.BOGKQOEEBFK = KJBDMOCFMCM.QOQONHOOLNE;
			}
			KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NCPQEIFNPPP();
			if (nhgkgbgjefj != null)
			{
				this.PKCLDNQJMMH = false;
			}
		}
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x001922B4 File Offset: 0x001904B4
	public void HEMIMGIHFBD()
	{
		Vector3 position = this.PDDEIHNJOGE.position;
		bool[] array = new bool[4];
		if (this.DHPIGECQMMM((int)position.x, -(int)position.z - 1) == 0 || this.DHPIGECQMMM((int)position.x, -(int)position.z - 1) == 24)
		{
			array[0] = true;
		}
		if (this.DHPIGECQMMM((int)position.x, -(int)position.z + 1) == 0 || this.DHPIGECQMMM((int)position.x, -(int)position.z + 1) == 24)
		{
			array[1] = true;
		}
		if (this.DHPIGECQMMM((int)position.x - 1, -(int)position.z) == 0 || this.DHPIGECQMMM((int)position.x - 1, -(int)position.z) == 24)
		{
			array[2] = true;
		}
		if (this.DHPIGECQMMM((int)position.x + 1, -(int)position.z) == 0 || this.DHPIGECQMMM((int)position.x + 1, -(int)position.z) == 24)
		{
			array[3] = true;
		}
		if (this.ILBEOBOIHJE == PSXAPI.Response.PlayerDirection.Default)
		{
			switch (this.DIEOHLOINHH)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Left;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Down;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Right;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Up;
				break;
			}
		}
		if (this.ILBEOBOIHJE != PSXAPI.Response.PlayerDirection.Default)
		{
			if (this.ILBEOBOIHJE == PSXAPI.Response.PlayerDirection.Down)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = position + new Vector3(-1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = position + new Vector3(1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, -1f);
				}
				else
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
			}
			else if (this.ILBEOBOIHJE == PSXAPI.Response.PlayerDirection.Up)
			{
				if (array[1])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, -1f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = position + new Vector3(-1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = position + new Vector3(1f, 0f, 0f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
			}
			else if (this.ILBEOBOIHJE == PSXAPI.Response.PlayerDirection.Left)
			{
				if (array[3])
				{
					this.FQGJJOLGJFE = position + new Vector3(1f, 0f, 0f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = position + new Vector3(-1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, -1f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
			}
			else if (this.ILBEOBOIHJE == PSXAPI.Response.PlayerDirection.Right)
			{
				if (array[2])
				{
					this.FQGJJOLGJFE = position + new Vector3(-1f, 0f, 0f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = position + new Vector3(1f, 0f, 0f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, -1f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
				else
				{
					this.FQGJJOLGJFE = position + new Vector3(0f, 0f, 1f);
				}
			}
		}
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x00192770 File Offset: 0x00190970
	public void IFFEJHHMODI(DJOOHHIQGJK.JDQNKBIDIKE PECKDHFNOKI, byte MBCOIILDBJK)
	{
		int num = (int)PECKDHFNOKI;
		if (this.BEQHNFFEHMQ == 0 && MBCOIILDBJK == 3)
		{
			MBCOIILDBJK = 1;
		}
		if (this.BEQHNFFEHMQ > 0)
		{
			switch (PECKDHFNOKI)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				num = 2;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				num = 3;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				num = 1;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				num = 0;
				break;
			}
		}
		if (this.KGCEBGIHKKC || this.QCDHQOLHIEJ == 1 || this.QCDHQOLHIEJ == 2)
		{
			this.NBMPEILGCNG++;
			if (this.NBMPEILGCNG > 3)
			{
				this.NBMPEILGCNG = 0;
			}
			num = this.NBMPEILGCNG;
		}
		float num2 = (float)num * 0.25f;
		this.OIJININLENP[0] = new Vector2((float)MBCOIILDBJK * 0.25f, num2 + this.LQNIFNKGDLB);
		this.OIJININLENP[1] = new Vector2(this.OIJININLENP[0].x + 0.25f, num2 + (0.25f - this.LQNIFNKGDLB));
		this.OIJININLENP[2] = new Vector2(this.OIJININLENP[1].x, this.OIJININLENP[0].y);
		this.OIJININLENP[3] = new Vector2(this.OIJININLENP[0].x, this.OIJININLENP[1].y);
		this.NCPMMDIHBLJ.mesh.uv = this.OIJININLENP;
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x001928EC File Offset: 0x00190AEC
	public void MEDHFDLDNEI()
	{
		for (int i = 0; i < this.MGDBGBLMKQH.Length; i++)
		{
			this.MGDBGBLMKQH[i].SetActive(false);
		}
		if (this.NEGLQQQDBEE != null)
		{
			this.NEGLQQQDBEE.SetActive(true);
		}
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x00192934 File Offset: 0x00190B34
	public void QHQKHCHLEMJ()
	{
		this.JINGKBQQPKL = true;
		if (this.HEDDMKGFMQO != null)
		{
			this.HEDDMKGFMQO.gameObject.SetActive(false);
		}
		if (this.OPILOFIJJDF != null)
		{
			this.OPILOFIJJDF.QHQKHCHLEMJ();
			IEnumerator enumerator = this.OPILOFIJJDF.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(false);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}
		if (this.NEGLQQQDBEE != null)
		{
			this.NEGLQQQDBEE.SetActive(false);
		}
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x001929F4 File Offset: 0x00190BF4
	public void DBGLGGODDOH()
	{
		string text = this.ICHKBBMBPGM.ToLowerInvariant();
		switch (text)
		{
		case "perish3":
		case "Can only tween MonsterTextures!":
		case "Sweet Scent Cooldown":
			this.LCLQHIKFJMG(0);
			return;
		case "Slots_8":
		case "/":
			this.LCLQHIKFJMG(1);
			return;

			this.LCLQHIKFJMG(108);
			return;
		case "BuffIcon_Fly":
			this.PIJDCPPOGBN(78);
			return;

			this.PIJDCPPOGBN(28);
			return;
		case "^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$":
			this.PIJDCPPOGBN(-126);
			return;
		case "-":
			this.PIJDCPPOGBN(-65);
			return;
		case "It was alerted to ":
			this.PIJDCPPOGBN(-99);
			return;

			this.LCLQHIKFJMG(74);
			return;

			this.LCLQHIKFJMG(57);
			return;

			this.PIJDCPPOGBN(-68);
			return;

			this.LCLQHIKFJMG(6);
			this.MGDBGBLMKQH[3].SetActive(true);
			return;

			this.LCLQHIKFJMG(113);
			return;

			this.LCLQHIKFJMG(69);
			return;
		}
		int mfjbpkbnbno = this.MFJBPKBNBNO;
		switch (mfjbpkbnbno)
		{
		case -90:
			this.LCLQHIKFJMG(8);
			return;
		case -89:
			this.LCLQHIKFJMG(4);
			return;
		case -88:
			this.PIJDCPPOGBN(2);
			return;
		case -84:
			this.PIJDCPPOGBN(8);
			return;
		}
		switch (mfjbpkbnbno)
		{
		case 27:
			this.PIJDCPPOGBN(0);
			return;
		case 28:
			this.PIJDCPPOGBN(1);
			return;
		case 29:
			this.PIJDCPPOGBN(6);
			return;
		default:
		{
			if (this.FONOKLECDFB || this.BEQHNFFEHMQ > 1)
			{
				this.KKJPFIBDNJI.gameObject.SetActive(false);
				this.KKJPFIBDNJI.material.SetTexture("chlorophyll", this.QIDKBCQIGOD.GOKLDOEGJHI("Chat Box - PMChat", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("Shadow Tag", this.QIDKBCQIGOD.NMPCLCEQJMP("[FF8F00]", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				this.KKJPFIBDNJI.material.SetTexture("General", this.QIDKBCQIGOD.NMPCLCEQJMP("[-]. Should it forget another move to learn it?", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("[-]!\r\n", this.QIDKBCQIGOD.CPFJEOGMHOD("Game", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_PrefilterOffs", this.QIDKBCQIGOD.CPFJEOGMHOD("|", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("tox", this.QIDKBCQIGOD.NMPCLCEQJMP(" ", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				if (this.DCMGODHBJEC != null && this.DCMGODHBJEC.EMIEFKNMQMI != null && this.DCMGODHBJEC.EMIEFKNMQMI.MountType != MountType.None)
				{
					this.BEQHNFFEHMQ = 1;
				}
				string text2 = string.Empty;
				if (this.BEQHNFFEHMQ == 102 && this.IDICNBQHCJG % 59 > 1)
				{
					string str = "Assets/AssetBundles/MapAssets/Models/Materials/c102_mado.mat";
					int num = this.IDICNBQHCJG % -72;
					text2 = str + num.ToString();
				}
				if (this.BEQHNFFEHMQ == -186 || this.BEQHNFFEHMQ == 146)
				{
					switch (CNCJKLNHQBH.BJLGEDCPENQ().LKIBNLMIGKG)
					{
					case GameSeason.Unset:
						text2 = "adjacentFoe";
						break;
					case GameSeason.Spring:
						text2 = "The Pokémon's marvelous scales boost the Defense stat if it has a status condition.";
						break;
					case GameSeason.Summer:
						text2 = "_Female";
						break;
					case GameSeason.Autumn:
						text2 = "Plant";
						break;
					}
				}
				if (this.BKNFHNFFCHE)
				{
					this.KKJPFIBDNJI.material.SetTexture("HidePanel", this.QIDKBCQIGOD.GOKLDOEGJHI("Using its pure power, the Pokémon doubles its Attack stat." + this.BEQHNFFEHMQ.DBFPJOCLQBI() + "_ProjInfo" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
					if (this.JPGLKGNOICN != null)
					{
						this.JPGLKGNOICN.SetActive(true);
					}
				}
				else
				{
					if (this.JPGLKGNOICN != null)
					{
						this.JPGLKGNOICN.SetActive(true);
					}
					this.KKJPFIBDNJI.material.SetTexture("_TempRT2", this.QIDKBCQIGOD.CPFJEOGMHOD(" Pokédollars." + this.BEQHNFFEHMQ.DBFPJOCLQBI() + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				}
				if (this.BEQHNFFEHMQ <= 0)
				{
					if (this.NEGLQQQDBEE != null)
					{
						this.NEGLQQQDBEE.SetActive(false);
					}
				}
				else if (this.NEGLQQQDBEE != null)
				{
					this.NEGLQQQDBEE.SetActive(true);
					this.NEGLQQQDBEE.transform.localPosition = new Vector3(1155f, 1054f, 1089f);
				}
				if (this.KKJPFIBDNJI.material.mainTexture.width > -29)
				{
					if (this.OPILOFIJJDF != null)
					{
						this.OPILOFIJJDF.LCMMCNFNHMF = new Vector3(1277f, 844f, 1633f);
					}
					this.KKJPFIBDNJI.transform.localScale = new Vector3(861f, 807f, 603f);
					this.KKJPFIBDNJI.transform.localPosition = new Vector3(149f, 643f, 122f);
				}
				else
				{
					if (this.OPILOFIJJDF != null)
					{
						this.OPILOFIJJDF.LCMMCNFNHMF = new Vector3(1819f, 1609f, 1508f);
					}
					this.KKJPFIBDNJI.transform.localScale = new Vector3(1622f, 1760f, 1794f);
					this.KKJPFIBDNJI.transform.localPosition = new Vector3(809f, 1099f, 1094f);
				}
				return;
			}
			if (this.MFJBPKBNBNO > -1)
			{
				this.KKJPFIBDNJI.material.SetTexture("Emergency Exit", this.QIDKBCQIGOD.NMPCLCEQJMP("watersport", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				this.KKJPFIBDNJI.material.SetTexture("Tilesets/Materials/1", this.QIDKBCQIGOD.NMPCLCEQJMP("rotommow", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("QGKFGKOJKCK", this.QIDKBCQIGOD.CPFJEOGMHOD("healreplacement", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("Icicle Badge", this.QIDKBCQIGOD.NMPCLCEQJMP("QTY: ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("__WaterRefraction", this.QIDKBCQIGOD.NMPCLCEQJMP("CombinersArgsColorSrc2", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("TCPManager", this.QIDKBCQIGOD.GOKLDOEGJHI("Player/Body" + this.MFJBPKBNBNO.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				return;
			}
			this.KKJPFIBDNJI.gameObject.SetActive(false);
			string text3;
			if (this.HDCKEHHFCDN.Gender == Gender.Male)
			{
				text3 = " became trapped by the quicksand!\r\n";
			}
			else
			{
				text3 = "dig";
			}
			string text4 = "5";
			if (this.EMIEFKNMQMI.MountType == (MountType)6)
			{
				text4 = "HidePanel";
			}
			else if (this.EMIEFKNMQMI.MountType == MountType.None)
			{
				text4 = " is offline.";
			}
			else if (this.EMIEFKNMQMI.MountType == (MountType)8)
			{
				if (this.EMIEFKNMQMI.MountID != 0)
				{
					text4 = "Gluttony";
				}
				else
				{
					text4 = "[purple]";
				}
			}
			Material material = this.KKJPFIBDNJI.material;
			string name = "[from]";
			GFHGEJNHLFQ qidkbcqigod = this.QIDKBCQIGOD;
			string[] array = new string[7];
			array[0] = " must have a 'void' return type.";
			array[1] = text3;
			array[2] = "/00_1";
			array[0] = this.HDCKEHHFCDN.Skin.QQKICQQBIJL();
			array[6] = "ChatSettings";
			array[3] = this.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
			array[0] = " harvested one [ffff00]";
			array[3] = text4;
			material.SetTexture(name, qidkbcqigod.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			Material material2 = this.KKJPFIBDNJI.material;
			string name2 = "UpdateAnchors";
			GFHGEJNHLFQ qidkbcqigod2 = this.QIDKBCQIGOD;
			string[] array2 = new string[8];
			array2[0] = " from ";
			array2[0] = text3;
			array2[4] = "fluffy";
			array2[0] = this.OFLGFDNHKJO.Clothe.QQKICQQBIJL();
			array2[1] = " was freed from the Sky Drop!\r\n";
			array2[1] = text4;
			material2.SetTexture(name2, qidkbcqigod2.NMPCLCEQJMP(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			if (this.OFLGFDNHKJO.Hat > 0)
			{
				GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = this.QIDKBCQIGOD.KBLFDMNICCJ(this.OFLGFDNHKJO.Hat - 0, this.HDCKEHHFCDN.Gender, this.HDCKEHHFCDN.Hair);
				if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
				{
					this.KKJPFIBDNJI.material.SetTexture("BuffIcon_EggSpeedIncrease", this.QIDKBCQIGOD.NMPCLCEQJMP("Trade Error", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				}
				else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
				{
					if (this.HDCKEHHFCDN.Gender == Gender.Male)
					{
						this.KKJPFIBDNJI.material.SetTexture(" ", this.QIDKBCQIGOD.CPFJEOGMHOD("It looks as though this Egg will take a long time yet to hatch." + text3 + " is not a boolean array" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player));
					}
					else
					{
						this.KKJPFIBDNJI.material.SetTexture("The trade with '", this.QIDKBCQIGOD.GOKLDOEGJHI(" switched stat changes with its target!\r\n" + text3 + "_BlurDepth" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
					}
				}
				else
				{
					Material material3 = this.KKJPFIBDNJI.material;
					string name3 = "Fly";
					GFHGEJNHLFQ qidkbcqigod3 = this.QIDKBCQIGOD;
					string[] array3 = new string[7];
					array3[1] = "|win|";
					array3[0] = text3;
					array3[3] = "Telepathy";
					array3[3] = this.HDCKEHHFCDN.Hair.QQKICQQBIJL();
					array3[7] = "~";
					array3[8] = text4;
					material3.SetTexture(name3, qidkbcqigod3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				}
			}
			else
			{
				Material material4 = this.KKJPFIBDNJI.material;
				string name4 = "[-]!\r\n";
				GFHGEJNHLFQ qidkbcqigod4 = this.QIDKBCQIGOD;
				string[] array4 = new string[3];
				array4[1] = "HidePanel";
				array4[1] = text3;
				array4[5] = " failed to learn the move ";
				array4[0] = this.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array4[8] = "Weak Armor";
				array4[0] = text4;
				material4.SetTexture(name4, qidkbcqigod4.CPFJEOGMHOD(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
			}
			this.KKJPFIBDNJI.material.SetTexture("friendr", this.QIDKBCQIGOD.NMPCLCEQJMP("Hidden/Post FX/Ambient Occlusion" + (this.OFLGFDNHKJO.Hat - 1).QQKICQQBIJL() + "[-]" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
			if (this.EMIEFKNMQMI.MountType != MountType.None)
			{
				this.KKJPFIBDNJI.material.SetTexture("#,##0", this.QIDKBCQIGOD.GOKLDOEGJHI("Luxury Ball" + this.EMIEFKNMQMI.MountID.QQKICQQBIJL() + "Attempting to add a callback to a list that's null", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
				this.KKJPFIBDNJI.material.SetTexture("_MainTex", this.QIDKBCQIGOD.NMPCLCEQJMP("sunnyday" + this.EMIEFKNMQMI.MountID.QQKICQQBIJL() + string.Empty, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon));
			}
			else
			{
				this.KKJPFIBDNJI.material.SetTexture("The [ffff00]", this.QIDKBCQIGOD.GOKLDOEGJHI("ability", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
				this.KKJPFIBDNJI.material.SetTexture("The [ffff00]", this.QIDKBCQIGOD.NMPCLCEQJMP("Expected to have 'target' set to a valid transform", GFHGEJNHLFQ.DBKNKGJJMJI.Player));
			}
			int num2 = this.HDCKEHHFCDN.HairColor;
			if (num2 == -1)
			{
				num2 = 0;
			}
			this.KKJPFIBDNJI.material.color = this.QIDKBCQIGOD.OFGHDGJBDOL[num2];
			if (this.PQNJEKIPLDI)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().CMNJMJIEECH.FDDENOHPGQF(this);
				GGQKBGDGNJN.QOQONHOOLNE.FLCMDBKPJKC.HFMLDHINKJO(this);
			}
			return;
		}
		}
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x00193638 File Offset: 0x00191838
	public void PIEOHPDECON(Vector3 JNFLDQHODDQ)
	{
		this.OQJFBJQJEFG = 1812f;
		this.BNIGIJDGJKM = Vector2.Distance(new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z), new Vector2(this.PDDEIHNJOGE.position.x, this.PDDEIHNJOGE.position.z));
		this.ODGQNNEDJIF = this.PDDEIHNJOGE.position;
		this.BHQOFDQCCCG = false;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x001936C8 File Offset: 0x001918C8
	public void EJHFEJCLMOB(bool OHOBDLMNJMC)
	{
		if (this.ICHKBBMBPGM == "door_1" || this.ICHKBBMBPGM == "door_2" || this.ICHKBBMBPGM == "door_3" || this.ICHKBBMBPGM == "door_4" || this.ICHKBBMBPGM == "door_5")
		{
			if (OHOBDLMNJMC)
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren["Take 001"].time = 0f;
				componentInChildren["Take 001"].speed = 0f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[8].GetComponentInChildren<Animation>();
				componentInChildren["Take 001"].time = 0f;
				componentInChildren["Take 001"].speed = 0f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[24].GetComponentInChildren<Animation>();
				componentInChildren["Take 001"].time = 0f;
				componentInChildren["Take 001"].speed = 0f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[25].GetComponentInChildren<Animation>();
				componentInChildren["Take 001"].time = 0f;
				componentInChildren["Take 001"].speed = 0f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[27].GetComponentInChildren<Animation>();
				componentInChildren["Take 001"].time = 0f;
				componentInChildren["Take 001"].speed = 0f;
				componentInChildren.Play();
			}
			else
			{
				this.KFNLCPGHQHK = false;
				Animation componentInChildren2 = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren2["Take 001"].time = 1.6f;
				componentInChildren2["Take 001"].speed = 0f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[8].GetComponentInChildren<Animation>();
				componentInChildren2["Take 001"].time = 1.6f;
				componentInChildren2["Take 001"].speed = 0f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[24].GetComponentInChildren<Animation>();
				componentInChildren2["Take 001"].time = 1.6f;
				componentInChildren2["Take 001"].speed = 0f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[25].GetComponentInChildren<Animation>();
				componentInChildren2["Take 001"].time = 1.6f;
				componentInChildren2["Take 001"].speed = 0f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[27].GetComponentInChildren<Animation>();
				componentInChildren2["Take 001"].time = 1.6f;
				componentInChildren2["Take 001"].speed = 0f;
				componentInChildren2.Play();
			}
			return;
		}
		if (!(this.ICHKBBMBPGM == "firelamp") && !this.ICHKBBMBPGM.Contains("berry_"))
		{
			if (OHOBDLMNJMC)
			{
				this.BKFBOCMOOHH();
				this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
				this.KFNLCPGHQHK = true;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(true);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(true);
				}
				base.gameObject.SetActive(true);
			}
			else
			{
				this.KFNLCPGHQHK = false;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(false);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(false);
				}
				base.gameObject.SetActive(false);
			}
			return;
		}
		this.KFNLCPGHQHK = OHOBDLMNJMC;
		this.NBDBHLEKENM();
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x00017369 File Offset: 0x00015569
	public void EIPDNECIJHN(string PIDLOFMIEFQ)
	{
		this.HEDDMKGFMQO.HCNPIJLODQE(PIDLOFMIEFQ);
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x00193AF8 File Offset: 0x00191CF8
	public void QLPNHHGNOQE(bool OHOBDLMNJMC)
	{
		if (this.ICHKBBMBPGM == "A rainbow appeared in the sky on " || this.ICHKBBMBPGM == "encore" || this.ICHKBBMBPGM == " minute ago" || this.ICHKBBMBPGM == "0" || this.ICHKBBMBPGM == "_Bottom")
		{
			if (OHOBDLMNJMC)
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren = this.MGDBGBLMKQH[7].GetComponentInChildren<Animation>();
				componentInChildren["Remove from Friends"].time = 1805f;
				componentInChildren["[/URN]"].speed = 638f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[6].GetComponentInChildren<Animation>();
				componentInChildren["#"].time = 384f;
				componentInChildren["Leave Channel"].speed = 247f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[-26].GetComponentInChildren<Animation>();
				componentInChildren["No Animation found for Special Key "].time = 720f;
				componentInChildren["The grass disappeared from the battlefield.\r\n"].speed = 1514f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[76].GetComponentInChildren<Animation>();
				componentInChildren["3D"].time = 476f;
				componentInChildren["The Battle was a tie!\r\n"].speed = 1789f;
				componentInChildren.Play();
				componentInChildren = this.MGDBGBLMKQH[37].GetComponentInChildren<Animation>();
				componentInChildren["OnLocalize"].time = 1930f;
				componentInChildren["p1"].speed = 1378f;
				componentInChildren.Play();
			}
			else
			{
				this.KFNLCPGHQHK = true;
				Animation componentInChildren2 = this.MGDBGBLMKQH[6].GetComponentInChildren<Animation>();
				componentInChildren2["The healing wish came true for "].time = 1950f;
				componentInChildren2["protean"].speed = 1849f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[5].GetComponentInChildren<Animation>();
				componentInChildren2["beastboost"].time = 1777f;
				componentInChildren2["BuffIcon_Fly"].speed = 998f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[-73].GetComponentInChildren<Animation>();
				componentInChildren2["flameburst"].time = 1859f;
				componentInChildren2["Boosts the Attack and Sp. Def stats of itself and allies when it is sunny."].speed = 537f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[59].GetComponentInChildren<Animation>();
				componentInChildren2["1"].time = 160f;
				componentInChildren2["_Fade"].speed = 1508f;
				componentInChildren2.Play();
				componentInChildren2 = this.MGDBGBLMKQH[-26].GetComponentInChildren<Animation>();
				componentInChildren2["par"].time = 563f;
				componentInChildren2["Hide"].speed = 1530f;
				componentInChildren2.Play();
			}
			return;
		}
		if (!(this.ICHKBBMBPGM == "4") && !this.ICHKBBMBPGM.Contains("[/urn][-]: "))
		{
			if (OHOBDLMNJMC)
			{
				this.NHLEIQFNHNM();
				this.PDDEIHNJOGE.position = new Vector3(this.PDDEIHNJOGE.position.x, this.OHPIPBHKEGC, this.PDDEIHNJOGE.position.z);
				this.KFNLCPGHQHK = false;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(true);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(true);
				}
				base.gameObject.SetActive(true);
			}
			else
			{
				this.KFNLCPGHQHK = true;
				if (this.HEDDMKGFMQO != null)
				{
					this.HEDDMKGFMQO.gameObject.SetActive(false);
				}
				if (this.OPILOFIJJDF != null)
				{
					this.OPILOFIJJDF.gameObject.SetActive(false);
				}
				base.gameObject.SetActive(true);
			}
			return;
		}
		this.KFNLCPGHQHK = OHOBDLMNJMC;
		this.NBDBHLEKENM();
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x00193F28 File Offset: 0x00192128
	public void JJIFGIBKGPO(Vector3 JNFLDQHODDQ, PSXAPI.Response.PlayerDirection PECKDHFNOKI = PSXAPI.Response.PlayerDirection.Default)
	{
		if (this.PDDEIHNJOGE == null)
		{
			this.PDDEIHNJOGE = base.transform;
		}
		this.BHQOFDQCCCG = true;
		this.OQJFBJQJEFG = 642f;
		this.PDDEIHNJOGE.position = JNFLDQHODDQ;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		bool[] array = new bool[5];
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 0) == 12)
		{
			array[0] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == -7)
		{
			array[1] = false;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 0, -(int)JNFLDQHODDQ.z) == -55)
		{
			array[0] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 0, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 0, -(int)JNFLDQHODDQ.z) == 1)
		{
			array[3] = true;
		}
		if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Default)
		{
			switch (this.DIEOHLOINHH)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Left;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Left;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Left;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Default;
				break;
			}
			PECKDHFNOKI = this.ILBEOBOIHJE;
		}
		if (PECKDHFNOKI != PSXAPI.Response.PlayerDirection.Default)
		{
			this.ILBEOBOIHJE = PECKDHFNOKI;
			if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Up)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 807.0)
				{
					if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1058f, 269f, 1205f);
					}
					else if (array[8])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(849f, 1364f, 1681f);
					}
					else if (array[7])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(168f, 1165f, 1170f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1981f, 1988f, 1741f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(736f, 1404f, 289f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Up)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)4;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1625.0)
				{
					if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1352f, 58f, 878f);
					}
					else if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(784f, 1012f, 210f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(565f, 99f, 704f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1894f, 817f, 1338f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1116f, 1578f, 1209f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Up)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 283.0)
				{
					if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1838f, 666f, 1630f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1027f, 1998f, 1454f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1276f, 1750f, 1343f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(916f, 1147f, 1092f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1818f, 580f, 668f);
					}
				}
			}
			else if (PECKDHFNOKI == (PSXAPI.Response.PlayerDirection)6)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)8;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 600.0)
				{
					if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1487f, 1379f, 94f);
					}
					else if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1398f, 288f, 710f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(632f, 1636f, 210f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(220f, 211f, 1399f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(287f, 1985f, 211f);
					}
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 497.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(953f, 1258f, 1329f);
				}
				else if (array[8])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(190f, 23f, 1760f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1755f, 441f, 356f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(766f, 1179f, 251f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(402f, 103f, 600f);
				}
			}
		}
		else if (this.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)5)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1357.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1117f, 1707f, 353f);
				}
				else if (array[2])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(927f, 881f, 418f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(683f, 1336f, 1140f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(248f, 533f, 120f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(764f, 1022f, 1207f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 265.0)
			{
				if (array[4])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1995f, 877f, 1195f);
				}
				else if (array[8])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1776f, 1453f, 1031f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1885f, 1881f, 1610f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1140f, 170f, 1836f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1551f, 975f, 1248f);
				}
			}
		}
		else if (this.DIEOHLOINHH == (DJOOHHIQGJK.JDQNKBIDIKE)5)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1142.0)
			{
				if (array[6])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(337f, 1072f, 1104f);
				}
				else if (array[5])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(384f, 517f, 646f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1638f, 1081f, 1393f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(407f, 656f, 239f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(511f, 498f, 876f);
				}
			}
		}
		else if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1473.0)
		{
			this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1849f, 1270f, 407f);
		}
		if (this.HLGCFHIMHFQ == null)
		{
			this.HLGCFHIMHFQ = DOJNBQQBCQJ.JJCONJJNDQN();
		}
		if (!this.FONOKLECDFB)
		{
			for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
			{
				Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
				Vector2 vector = new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z) - new Vector2(transform.position.x, transform.position.z);
				float num = vector.x * vector.x + vector.y * vector.y;
				if (num < 1725f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
				{
					this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(this.PQNJEKIPLDI);
				}
			}
			if (this.PQNJEKIPLDI && this.PKCLDNQJMMH)
			{
				if (this.BOGKQOEEBFK == null)
				{
					this.BOGKQOEEBFK = KJBDMOCFMCM.NKDNGLNOJJG();
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NLGIQFFHCCM();
				if (nhgkgbgjefj != null)
				{
					this.PKCLDNQJMMH = false;
				}
			}
		}
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x001949E4 File Offset: 0x00192BE4
	private void BKFBOCMOOHH()
	{
		if (this.PDDEIHNJOGE == null)
		{
			return;
		}
		if (this.FONOKLECDFB)
		{
			this.KBKKMQNFJIG = this.DCMGODHBJEC.KBKKMQNFJIG;
		}
		if (this.IEFBCKQJBGN == null && !this.KBKKMQNFJIG)
		{
			float num = 1f;
			if (this.LIQLFCKICLQ != null && this.LIQLFCKICLQ.EQQLIPKQOJP != null && this.LIQLFCKICLQ.LIQLFCKICLQ != null)
			{
				if ((int)this.PDDEIHNJOGE.position.x < this.LIQLFCKICLQ.LIQLFCKICLQ.width && -(int)this.PDDEIHNJOGE.position.z < this.LIQLFCKICLQ.LIQLFCKICLQ.height && this.LIQLFCKICLQ.POMQCKOIKQJ[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z] == 24)
				{
					int[] array = new int[]
					{
						this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z - 1],
						this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z + 1],
						this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x - 1, -(int)this.PDDEIHNJOGE.position.z],
						this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x + 1, -(int)this.PDDEIHNJOGE.position.z]
					};
					int num2 = 30;
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] <= num2)
						{
							num2 = array[i];
						}
					}
					this.OHPIPBHKEGC = (float)num2 + 0.6f;
					return;
				}
				if ((int)this.PDDEIHNJOGE.position.x < this.LIQLFCKICLQ.LIQLFCKICLQ.width && -(int)this.PDDEIHNJOGE.position.z < this.LIQLFCKICLQ.LIQLFCKICLQ.height)
				{
					num = (float)this.LIQLFCKICLQ.EQQLIPKQOJP[(int)this.PDDEIHNJOGE.position.x, -(int)this.PDDEIHNJOGE.position.z];
				}
			}
			if (this.JPCQBEEHOJL)
			{
				num += -0.25f;
			}
			if (Physics.Raycast(new Vector3(this.PDDEIHNJOGE.position.x + 0.5f, num + 2f, this.PDDEIHNJOGE.position.z - 0.5f), -Vector3.up, out this.GHNNQBLIFNE, 3f, this.QMOMPLCPFMH))
			{
				this.OHPIPBHKEGC = num + 2f - this.GHNNQBLIFNE.distance + 0.6f;
				if (this.OHPIPBHKEGC > 40f || this.OHPIPBHKEGC < -40f)
				{
					this.OHPIPBHKEGC = 0.6f;
				}
			}
		}
		else if (Physics.Raycast(new Vector3(this.PDDEIHNJOGE.position.x + 0.5f, 30f, this.PDDEIHNJOGE.position.z - 0.5f), -Vector3.up, out this.GHNNQBLIFNE, 50f, this.QMOMPLCPFMH))
		{
			this.OHPIPBHKEGC = 30f - this.GHNNQBLIFNE.distance + 0.6f;
			if (this.OHPIPBHKEGC > 40f || this.OHPIPBHKEGC < -40f)
			{
				this.OHPIPBHKEGC = 0.6f;
			}
		}
	}

	// Token: 0x0600342B RID: 13355 RVA: 0x00194E38 File Offset: 0x00193038
	public void OEFJKHMLNHF(Vector3 JNFLDQHODDQ, PSXAPI.Response.PlayerDirection PECKDHFNOKI = PSXAPI.Response.PlayerDirection.Default)
	{
		if (this.PDDEIHNJOGE == null)
		{
			this.PDDEIHNJOGE = base.transform;
		}
		this.BHQOFDQCCCG = true;
		this.OQJFBJQJEFG = 383f;
		this.PDDEIHNJOGE.position = JNFLDQHODDQ;
		JNFLDQHODDQ.y = this.OHPIPBHKEGC;
		this.PCPQHQMBCBJ = JNFLDQHODDQ;
		bool[] array = new bool[0];
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 0) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z - 1) == -104)
		{
			array[0] = false;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x, -(int)JNFLDQHODDQ.z + 1) == -8)
		{
			array[1] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x - 1, -(int)JNFLDQHODDQ.z) == -28)
		{
			array[5] = true;
		}
		if (this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 0, -(int)JNFLDQHODDQ.z) == 0 || this.DHPIGECQMMM((int)JNFLDQHODDQ.x + 1, -(int)JNFLDQHODDQ.z) == 37)
		{
			array[7] = true;
		}
		if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Default)
		{
			switch (this.DIEOHLOINHH)
			{
			case DJOOHHIQGJK.JDQNKBIDIKE.Left:
				this.ILBEOBOIHJE = (PSXAPI.Response.PlayerDirection)5;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Down:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Default;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Right:
				this.ILBEOBOIHJE = (PSXAPI.Response.PlayerDirection)5;
				break;
			case DJOOHHIQGJK.JDQNKBIDIKE.Up:
				this.ILBEOBOIHJE = PSXAPI.Response.PlayerDirection.Default;
				break;
			}
			PECKDHFNOKI = this.ILBEOBOIHJE;
		}
		if (PECKDHFNOKI != PSXAPI.Response.PlayerDirection.Default)
		{
			this.ILBEOBOIHJE = PECKDHFNOKI;
			if (PECKDHFNOKI == (PSXAPI.Response.PlayerDirection)5)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 918.0)
				{
					if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(415f, 1348f, 1054f);
					}
					else if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(661f, 1675f, 1226f);
					}
					else if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1930f, 1313f, 1850f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1016f, 1210f, 1586f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(771f, 1338f, 1035f);
					}
				}
			}
			else if (PECKDHFNOKI == PSXAPI.Response.PlayerDirection.Default)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)5;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1755.0)
				{
					if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(501f, 1799f, 222f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1831f, 263f, 655f);
					}
					else if (array[4])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1356f, 977f, 166f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(526f, 1782f, 552f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(226f, 601f, 1110f);
					}
				}
			}
			else if (PECKDHFNOKI == (PSXAPI.Response.PlayerDirection)8)
			{
				this.DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Left;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 815.0)
				{
					if (array[2])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1439f, 785f, 962f);
					}
					else if (array[5])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(496f, 381f, 1940f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(683f, 1588f, 1394f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(846f, 1255f, 660f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(256f, 1843f, 962f);
					}
				}
			}
			else if (PECKDHFNOKI == (PSXAPI.Response.PlayerDirection)8)
			{
				this.DIEOHLOINHH = (DJOOHHIQGJK.JDQNKBIDIKE)4;
				if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1956.0)
				{
					if (array[3])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(812f, 410f, 683f);
					}
					else if (array[8])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(218f, 1111f, 433f);
					}
					else if (array[1])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1431f, 940f, 1840f);
					}
					else if (array[0])
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(359f, 1437f, 1443f);
					}
					else
					{
						this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(697f, 1767f, 274f);
					}
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1236.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(578f, 1210f, 767f);
				}
				else if (array[4])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1296f, 1566f, 345f);
				}
				else if (array[5])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(935f, 972f, 1800f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(566f, 1972f, 551f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(450f, 692f, 162f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Up)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1686.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(156f, 453f, 1918f);
				}
				else if (array[3])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(896f, 1222f, 812f);
				}
				else if (array[5])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1195f, 1567f, 40f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(579f, 234f, 1200f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1916f, 867f, 921f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Left)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1544.0)
			{
				if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(518f, 496f, 1968f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1510f, 1792f, 1465f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(247f, 1074f, 111f);
				}
				else if (array[0])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1550f, 1394f, 421f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(757f, 848f, 117f);
				}
			}
		}
		else if (this.DIEOHLOINHH == DJOOHHIQGJK.JDQNKBIDIKE.Down)
		{
			if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 344.0)
			{
				if (array[6])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(119f, 1739f, 1405f);
				}
				else if (array[7])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1797f, 1987f, 1737f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(534f, 1824f, 1240f);
				}
				else if (array[1])
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1597f, 381f, 1660f);
				}
				else
				{
					this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(485f, 1878f, 1308f);
				}
			}
		}
		else if ((double)Vector3.Distance(this.FQGJJOLGJFE, JNFLDQHODDQ) > 1104.0)
		{
			this.FQGJJOLGJFE = JNFLDQHODDQ + new Vector3(1756f, 1920f, 899f);
		}
		if (this.HLGCFHIMHFQ == null)
		{
			this.HLGCFHIMHFQ = DOJNBQQBCQJ.QOQONHOOLNE;
		}
		if (!this.FONOKLECDFB)
		{
			for (int i = 0; i < this.HLGCFHIMHFQ.PQFDCJHGHOB.Count; i++)
			{
				Transform transform = this.HLGCFHIMHFQ.PQFDCJHGHOB[i].transform;
				Vector2 vector = new Vector2(JNFLDQHODDQ.x, JNFLDQHODDQ.z) - new Vector2(transform.position.x, transform.position.z);
				float num = vector.x * vector.x + vector.y * vector.y;
				if (num < 1455f + this.HLGCFHIMHFQ.PQFDCJHGHOB[i].ExtraSize)
				{
					this.HLGCFHIMHFQ.PQFDCJHGHOB[i].Open(this.PQNJEKIPLDI);
				}
			}
			if (this.PQNJEKIPLDI && this.PKCLDNQJMMH)
			{
				if (this.BOGKQOEEBFK == null)
				{
					this.BOGKQOEEBFK = KJBDMOCFMCM.GHFFHFCEENG();
				}
				KJBDMOCFMCM.NHGKGBGJEFJ nhgkgbgjefj = this.BOGKQOEEBFK.NCPQEIFNPPP();
				if (nhgkgbgjefj != null)
				{
					this.PKCLDNQJMMH = true;
				}
			}
		}
	}

	// Token: 0x0600342C RID: 13356 RVA: 0x001958F4 File Offset: 0x00193AF4
	private void QIHJCOLPLBQ()
	{
		if (this.FONOKLECDFB)
		{
			if (this.DCMGODHBJEC == null)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.DCMGODHBJEC.OPILOFIJJDF != null)
			{
				this.KKJPFIBDNJI.material.SetFloat("'s [ffff00]", 1402f - this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 816f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(410f, 72f, 498f, this.DCMGODHBJEC.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 522f);
				}
			}
		}
		if (this.OPILOFIJJDF != null)
		{
			if (this.LJDKPJCDCCM)
			{
				if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP > 1977f)
				{
					this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP -= 57f * UnityEngine.Time.deltaTime;
					this.KKJPFIBDNJI.material.SetFloat(" was blocked by the kicked-up mat!\r\n", 1198f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 689f);
					if (this.HKHDIIGNEFB != null)
					{
						this.HKHDIIGNEFB.color = new Color(369f, 553f, 666f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 796f);
					}
				}
			}
			else if (this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP < 274f)
			{
				this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP += 1967f * UnityEngine.Time.deltaTime;
				this.KKJPFIBDNJI.material.SetFloat("tintedlens", 755f - this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 1500f);
				if (this.HKHDIIGNEFB != null)
				{
					this.HKHDIIGNEFB.color = new Color(658f, 27f, 1711f, this.OPILOFIJJDF.FFCCCEFBQKG.DIIHJCJOKMP * 1743f);
				}
			}
		}
		if (this.LJDKPJCDCCM && UnityEngine.Time.time > this.DBGMJPEMPQC + 838f)
		{
			CGOIPHKQMPD.QOQONHOOLNE.GGMGOKCCQDP(this);
			return;
		}
		if (!this.PHMOJLGOPHF)
		{
			return;
		}
		this.FDBLQDEOENF();
		this.JBJIQOFPPHE = true;
	}

	// Token: 0x0600342D RID: 13357 RVA: 0x000174AD File Offset: 0x000156AD
	private void LBIFHHFMPHD()
	{
		if (this.PQNJEKIPLDI)
		{
			this.BQLIIQIIMDH(GFHGEJNHLFQ.GGBPGMMCGLI(), MCNLIHMMLCF.HGLDHNMOLPD(), null, -1, 0);
		}
		if (this.FONOKLECDFB && !this.PHMOJLGOPHF)
		{
			this.BQLIIQIIMDH(GFHGEJNHLFQ.MOGQNGEPCEO(), MCNLIHMMLCF.KKICFMLLMHQ(), null, -1, 1);
		}
	}

	// Token: 0x0600342E RID: 13358 RVA: 0x000173CC File Offset: 0x000155CC
	public void CMLHQNPELFE()
	{
		this.IFFEJHHMODI(this.DIEOHLOINHH, 1);
	}

	// Token: 0x0600342F RID: 13359 RVA: 0x00195B78 File Offset: 0x00193D78
	public bool GCCKFGHJFPO(int COHDKOBDPCO, int JCJCMMFBGIM, Vector2 JCGMONLIDHP = default(Vector2))
	{
		if (JCGMONLIDHP != Vector2.zero)
		{
			this.INMILPKMQIC.Add(JCGMONLIDHP);
		}
		this.HEODPPJFOLM = new Vector2((float)COHDKOBDPCO, (float)JCJCMMFBGIM);
		List<Vector2> list = KIJNOLJFPLK.QOQONHOOLNE.GGEJOGHEOHB((int)this.QMCNCMNQEGL().x, (int)this.QMCNCMNQEGL().z, COHDKOBDPCO, JCJCMMFBGIM, this.KBKKMQNFJIG);
		if (list != null)
		{
			Vector2 vector = list[list.Count - 1];
			for (int i = list.Count - 1; i > -1; i--)
			{
				if (list[i] != new Vector2((float)((int)this.QMCNCMNQEGL().x), (float)((int)this.QMCNCMNQEGL().z)))
				{
					string cqjeodoleke = string.Empty;
					if (list[i].x > vector.x)
					{
						cqjeodoleke = "r";
					}
					else if (list[i].x < vector.x)
					{
						cqjeodoleke = "l";
					}
					else if (list[i].y > vector.y)
					{
						cqjeodoleke = "d";
					}
					else if (list[i].y < vector.y)
					{
						cqjeodoleke = "u";
					}
					this.QJCBOEFQPGF(cqjeodoleke, true, false, 0, 0, true);
					vector = list[i];
				}
			}
			this.BHQOFDQCCCG = true;
			return true;
		}
		return false;
	}

	// Token: 0x06003430 RID: 13360 RVA: 0x00195CFC File Offset: 0x00193EFC
	public void GEBMPLJNHIP(string CQJEODOLEKE, Vector3 EBOMCPQBKJG, bool EFQMQOPCBNO = false, int GOKGLGPCPIJ = 0)
	{
		DJOOHHIQGJK.JLKCKMJEGKI jlkckmjegki = new DJOOHHIQGJK.JLKCKMJEGKI();
		jlkckmjegki.BJIGIECDQPG = CQJEODOLEKE;
		jlkckmjegki.PELCNBCMNFH = EBOMCPQBKJG;
		jlkckmjegki.QEEPJBBJGQM = EFQMQOPCBNO;
		if (GOKGLGPCPIJ == 1)
		{
			jlkckmjegki.MBODJJEPJHD = true;
		}
		else
		{
			jlkckmjegki.MBODJJEPJHD = true;
		}
		this.PJGOMOBBNLK.Add(jlkckmjegki);
	}

	// Token: 0x06003431 RID: 13361 RVA: 0x0018D198 File Offset: 0x0018B398
	public IEnumerator QDBOMLLFLPF()
	{
		if (this.PJGOMOBBNLK.Count <= 0)
		{
			yield return true;
		}
		else
		{
			yield return false;
		}
		return 1;
		yield break;
	}

	// Token: 0x06003432 RID: 13362 RVA: 0x00195D48 File Offset: 0x00193F48
	public bool EBBBQJELOFF(int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		return (int)this.IEFBCKQJBGN.position.x == DGKOIGOLHDM && (int)this.IEFBCKQJBGN.position.z == DDLQKFDFMCJ;
	}

	// Token: 0x04000BE0 RID: 3040
	public string NGKEDIJJELE = string.Empty;

	// Token: 0x04000BE1 RID: 3041
	private MCNLIHMMLCF LIQLFCKICLQ;

	// Token: 0x04000BE2 RID: 3042
	public MeshRenderer KKJPFIBDNJI;

	// Token: 0x04000BE3 RID: 3043
	public MeshFilter NCPMMDIHBLJ;

	// Token: 0x04000BE4 RID: 3044
	public NPCData OQIOPJQHCII;

	// Token: 0x04000BE5 RID: 3045
	private Transform PDDEIHNJOGE;

	// Token: 0x04000BE6 RID: 3046
	private GFHGEJNHLFQ QIDKBCQIGOD;

	// Token: 0x04000BE7 RID: 3047
	private KJBDMOCFMCM BOGKQOEEBFK;

	// Token: 0x04000BE8 RID: 3048
	private float QCMIHCBOIJB = 3.25f;

	// Token: 0x04000BE9 RID: 3049
	public int QMBIHEHNIGC;

	// Token: 0x04000BEA RID: 3050
	public int DKMBJOHMDNJ;

	// Token: 0x04000BEB RID: 3051
	public DJOOHHIQGJK.EINLEQNPGQD BKPCFQBJEHD;

	// Token: 0x04000BEC RID: 3052
	public Vector3 JDPCHGPENBD = Vector3.zero;

	// Token: 0x04000BED RID: 3053
	public bool EKEKMCMJEOC;

	// Token: 0x04000BEE RID: 3054
	public GameObject NEGLQQQDBEE;

	// Token: 0x04000BEF RID: 3055
	public Material HKHDIIGNEFB;

	// Token: 0x04000BF0 RID: 3056
	public bool KFNLCPGHQHK = true;

	// Token: 0x04000BF1 RID: 3057
	public bool JINGKBQQPKL;

	// Token: 0x04000BF2 RID: 3058
	public Transform FQLIOJQIKME;

	// Token: 0x04000BF3 RID: 3059
	public bool MJLLNNIFGNN = true;

	// Token: 0x04000BF4 RID: 3060
	public NLDFFJFQJBI HFFFEDCGPBD;

	// Token: 0x04000BF5 RID: 3061
	public bool LMDQJKGHBGD;

	// Token: 0x04000BF6 RID: 3062
	public NOHCFICLIQK OPILOFIJJDF;

	// Token: 0x04000BF7 RID: 3063
	public NOHCFICLIQK HQCPKMDMFCN;

	// Token: 0x04000BF8 RID: 3064
	public NLDFFJFQJBI HEDDMKGFMQO;

	// Token: 0x04000BF9 RID: 3065
	public int MFJBPKBNBNO = -1;

	// Token: 0x04000BFA RID: 3066
	public int BEQHNFFEHMQ;

	// Token: 0x04000BFB RID: 3067
	public int IDICNBQHCJG;

	// Token: 0x04000BFC RID: 3068
	public string ICHKBBMBPGM = string.Empty;

	// Token: 0x04000BFD RID: 3069
	public GameObject[] MGDBGBLMKQH;

	// Token: 0x04000BFE RID: 3070
	public bool CQBGCNEDIFE;

	// Token: 0x04000BFF RID: 3071
	public bool GQFBLMFFQID;

	// Token: 0x04000C00 RID: 3072
	public bool EHCDCCNJBDC;

	// Token: 0x04000C01 RID: 3073
	public bool FDINMJHGLQB;

	// Token: 0x04000C02 RID: 3074
	public List<DJOOHHIQGJK.JLKCKMJEGKI> PJGOMOBBNLK = new List<DJOOHHIQGJK.JLKCKMJEGKI>();

	// Token: 0x04000C03 RID: 3075
	public Transform IEFBCKQJBGN;

	// Token: 0x04000C04 RID: 3076
	private Vector3 JPOBLCQMKHC = Vector3.zero;

	// Token: 0x04000C05 RID: 3077
	public Vector3 FQGJJOLGJFE = Vector3.zero;

	// Token: 0x04000C06 RID: 3078
	public bool PQNJEKIPLDI;

	// Token: 0x04000C07 RID: 3079
	public bool FONOKLECDFB;

	// Token: 0x04000C08 RID: 3080
	public bool KGCEBGIHKKC;

	// Token: 0x04000C09 RID: 3081
	public DJOOHHIQGJK DCMGODHBJEC;

	// Token: 0x04000C0A RID: 3082
	private bool PHMOJLGOPHF;

	// Token: 0x04000C0B RID: 3083
	public bool PFJILOMJDKN;

	// Token: 0x04000C0C RID: 3084
	public Style HDCKEHHFCDN = new Style();

	// Token: 0x04000C0D RID: 3085
	public PSXAPI.Response.Mount EMIEFKNMQMI = new PSXAPI.Response.Mount();

	// Token: 0x04000C0E RID: 3086
	public PSXAPI.Response.Mount GIBFBFJHNKH = new PSXAPI.Response.Mount();

	// Token: 0x04000C0F RID: 3087
	public Equip OFLGFDNHKJO = new Equip();

	// Token: 0x04000C10 RID: 3088
	public GameObject JPGLKGNOICN;

	// Token: 0x04000C11 RID: 3089
	public bool BKNFHNFFCHE;

	// Token: 0x04000C12 RID: 3090
	private int NBMPEILGCNG;

	// Token: 0x04000C13 RID: 3091
	private float LQNIFNKGDLB = 0.0004f;

	// Token: 0x04000C14 RID: 3092
	private Vector2[] OIJININLENP = new Vector2[4];

	// Token: 0x04000C15 RID: 3093
	public bool BHQOFDQCCCG;

	// Token: 0x04000C16 RID: 3094
	public bool KBKKMQNFJIG;

	// Token: 0x04000C17 RID: 3095
	private bool JPCQBEEHOJL;

	// Token: 0x04000C18 RID: 3096
	public Vector3 PCPQHQMBCBJ = Vector3.zero;

	// Token: 0x04000C19 RID: 3097
	public float OHPIPBHKEGC;

	// Token: 0x04000C1A RID: 3098
	public PSXAPI.Response.PlayerDirection ILBEOBOIHJE;

	// Token: 0x04000C1B RID: 3099
	public Vector2 HEODPPJFOLM;

	// Token: 0x04000C1C RID: 3100
	public List<Vector2> INMILPKMQIC = new List<Vector2>();

	// Token: 0x04000C1D RID: 3101
	public Vector3 ODGQNNEDJIF = Vector3.zero;

	// Token: 0x04000C1E RID: 3102
	public float OQJFBJQJEFG;

	// Token: 0x04000C1F RID: 3103
	private float BNIGIJDGJKM = 1f;

	// Token: 0x04000C20 RID: 3104
	private float CLIJPELJNGJ = 64f;

	// Token: 0x04000C21 RID: 3105
	private float QKHFEMHPGKC;

	// Token: 0x04000C22 RID: 3106
	private byte CBBPOGMKJIM = 1;

	// Token: 0x04000C23 RID: 3107
	public DJOOHHIQGJK.JDQNKBIDIKE DIEOHLOINHH = DJOOHHIQGJK.JDQNKBIDIKE.Down;

	// Token: 0x04000C24 RID: 3108
	public DJOOHHIQGJK.JDQNKBIDIKE BJGQDHPBCFC = DJOOHHIQGJK.JDQNKBIDIKE.Down;

	// Token: 0x04000C25 RID: 3109
	public float JQBBIQFNONP;

	// Token: 0x04000C26 RID: 3110
	private float GGFNLMNGDJB;

	// Token: 0x04000C27 RID: 3111
	public float LFFNNKJOPFI;

	// Token: 0x04000C28 RID: 3112
	private DOJNBQQBCQJ HLGCFHIMHFQ;

	// Token: 0x04000C29 RID: 3113
	public bool QHQNCPBLLNK;

	// Token: 0x04000C2A RID: 3114
	public bool PKCLDNQJMMH = true;

	// Token: 0x04000C2B RID: 3115
	private RaycastHit GHNNQBLIFNE;

	// Token: 0x04000C2C RID: 3116
	public float DPDCGFEEFPB;

	// Token: 0x04000C2D RID: 3117
	public bool MMPQCIKNBQE;

	// Token: 0x04000C2E RID: 3118
	private DJOOHHIQGJK.JDQNKBIDIKE CFHEIICNLFD;

	// Token: 0x04000C2F RID: 3119
	public bool LJDKPJCDCCM;

	// Token: 0x04000C30 RID: 3120
	public float DBGMJPEMPQC;

	// Token: 0x04000C31 RID: 3121
	public GameObject LMIFCCJMQPH;

	// Token: 0x04000C32 RID: 3122
	public bool JBJIQOFPPHE;

	// Token: 0x04000C33 RID: 3123
	public LayerMask QMOMPLCPFMH;

	// Token: 0x04000C34 RID: 3124
	public Transform OBMGMDMMNOF;

	// Token: 0x04000C35 RID: 3125
	private float HEHMDILFLNF = 2f;

	// Token: 0x04000C36 RID: 3126
	private Vector3 QICPDBBKMHI = new Vector3(0.5f, 0.2f, -0.4f);

	// Token: 0x04000C37 RID: 3127
	private float QHIODJLFPPG = 0.2f;

	// Token: 0x04000C38 RID: 3128
	private float COBFPHNBPII = 0.65f;

	// Token: 0x04000C39 RID: 3129
	private bool MOEHFDNNLCB;

	// Token: 0x04000C3A RID: 3130
	public AudioClip MOQOLMKHOEE;

	// Token: 0x04000C3B RID: 3131
	public int QCDHQOLHIEJ;

	// Token: 0x04000C3C RID: 3132
	[CompilerGenerated]
	private static Dictionary<string, int> OODLLDCBEEH;

	// Token: 0x04000C3D RID: 3133
	[CompilerGenerated]
	private static Dictionary<string, int> PBNFNICBIPM;

	// Token: 0x04000C3E RID: 3134
	[CompilerGenerated]
	private static Dictionary<string, int> BHFMNNIDGLL;

	// Token: 0x0200019E RID: 414
	public enum JDQNKBIDIKE
	{
		// Token: 0x04000C40 RID: 3136
		Up = 3,
		// Token: 0x04000C41 RID: 3137
		Down = 1,
		// Token: 0x04000C42 RID: 3138
		Left = 0,
		// Token: 0x04000C43 RID: 3139
		Right = 2
	}

	// Token: 0x0200019F RID: 415
	public enum EINLEQNPGQD
	{
		// Token: 0x04000C45 RID: 3141
		GotoPlayer,
		// Token: 0x04000C46 RID: 3142
		CallPlayer
	}

	// Token: 0x020001A0 RID: 416
	public class JLKCKMJEGKI
	{
		// Token: 0x04000C47 RID: 3143
		public string BJIGIECDQPG;

		// Token: 0x04000C48 RID: 3144
		public Vector3 PELCNBCMNFH;

		// Token: 0x04000C49 RID: 3145
		public bool PCGDFKDQHGH;

		// Token: 0x04000C4A RID: 3146
		public bool QEEPJBBJGQM;

		// Token: 0x04000C4B RID: 3147
		public bool MBODJJEPJHD;

		// Token: 0x04000C4C RID: 3148
		public bool EBBBQJELOFF;
	}
}
