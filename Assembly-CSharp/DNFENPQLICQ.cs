using System;
using System.Collections;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200027C RID: 636
public class DNFENPQLICQ : MonoBehaviour
{
	// Token: 0x0600578E RID: 22414 RVA: 0x002CB920 File Offset: 0x002C9B20
	public void UpdateGUI()
	{
		this.DQPFLILJDEM.SetActive(false);
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.JBLQIEPJLPN.PDBGQNOLMBG("skinshop", 1);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
			string text = string.Empty;
			if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
			{
				text = "_Male";
			}
			else
			{
				text = "_Female";
			}
			if (this.FGLGOGGLMMJ != null && this.FGLGOGGLMMJ.Length > 0)
			{
				for (int i = 0; i < this.FGLGOGGLMMJ.Length; i++)
				{
					bool flag = false;
					if (this.QQOEQIBBIDC == 0 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Clothe)
					{
						LNPEDCCCPPN component = this.JBLQIEPJLPN.JPODNGNQBKQ("skinshop", 1).GetComponent<LNPEDCCCPPN>();
						component.transform.parent = this.JHDGENGBPQF.transform;
						component.transform.localScale = new Vector3(1f, 1f, 1f);
						component.gameObject.SetActive(true);
						component.EKIFQMCDLLJ();
						component.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Clothe;
						component.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component.DBPKNCDGGEP = i;
						if (this.DDIDOHCLEBJ.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.KJPIOFDLCOD == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							}
							else
							{
								component.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Owned";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0") + "\n[PG]" + this.FGLGOGGLMMJ[i].MoneyPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].MoneyPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.OKNBGPNOJDL(component.gameObject);
						}
						string text2 = "1";
						component.HODQHNIKPDM = text2;
						component.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
						{
							"Player/Body",
							text,
							"/",
							ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
							"_",
							ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
							"_",
							text2
						}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
						component.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
						{
							"Player/Clothe",
							text,
							"/",
							this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL(),
							"_",
							text2
						}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
						component.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 1 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Hat)
					{
						LNPEDCCCPPN component2 = this.JBLQIEPJLPN.JPODNGNQBKQ("skinshop", 1).GetComponent<LNPEDCCCPPN>();
						component2.transform.parent = this.JHDGENGBPQF.transform;
						component2.transform.localScale = new Vector3(1f, 1f, 1f);
						component2.gameObject.SetActive(true);
						component2.EKIFQMCDLLJ();
						component2.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component2.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Hat;
						component2.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component2.DBPKNCDGGEP = i;
						if (this.POIOQEQPCFK.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.QEPOHCJIGQP == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component2.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component2.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component2.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							}
							else
							{
								component2.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Owned";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component2.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0") + "\n[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component2.PLCBFLQBCQN.PIDLOFMIEFQ = "[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component2.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component2.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.OKNBGPNOJDL(component2.gameObject);
						}
						component2.GMCQFIGGJKE = this.FGLGOGGLMMJ[i].SpriteID;
						string text3 = "1";
						component2.HODQHNIKPDM = text3;
						component2.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
						{
							"Player/Body",
							text,
							"/",
							ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
							"_",
							ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
							"_",
							text3
						}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component2.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
						component2.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text3, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component2.PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
						component2.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hats/" + (this.FGLGOGGLMMJ[i].SpriteID - 1).QQKICQQBIJL() + "_" + text3, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component2.DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
						component2.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component2.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component2.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 2 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Mount)
					{
						LNPEDCCCPPN component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("skinshop", 1).GetComponent<LNPEDCCCPPN>();
						component3.transform.parent = this.JHDGENGBPQF.transform;
						component3.transform.localScale = new Vector3(1f, 1f, 1f);
						component3.gameObject.SetActive(true);
						component3.EKIFQMCDLLJ();
						component3.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component3.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Mount;
						component3.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component3.DBPKNCDGGEP = i;
						if (this.FGLGOGGLMMJ[i].Name.ToLowerInvariant().Contains("bicycle"))
						{
							component3.OBHJIDJOFFO.SetActive(true);
						}
						if (this.HHNPLECEPEI == 0 && this.FGLGOGGLMMJ[i].SpriteID < 2)
						{
							component3.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component3.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							flag = true;
						}
						else if (this.FEDPGMLPLQN.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.HHNPLECEPEI == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component3.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component3.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							}
							else
							{
								component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Owned";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0") + "\n[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.OKNBGPNOJDL(component3.gameObject);
						}
						string text4 = "5";
						if (this.FGLGOGGLMMJ[i].SpriteID == 0 || this.FGLGOGGLMMJ[i].SpriteID == 1 || this.FGLGOGGLMMJ[i].SpriteID == 11 || this.FGLGOGGLMMJ[i].SpriteID == 12 || this.FGLGOGGLMMJ[i].SpriteID == 13)
						{
							text4 = "2";
						}
						component3.HODQHNIKPDM = text4;
						component3.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
						{
							"Player/Body",
							text,
							"/",
							ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
							"_",
							ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
							"_",
							text4
						}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component3.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component3.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 3 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Surf)
					{
						LNPEDCCCPPN component4 = this.JBLQIEPJLPN.JPODNGNQBKQ("skinshop", 1).GetComponent<LNPEDCCCPPN>();
						component4.transform.parent = this.JHDGENGBPQF.transform;
						component4.transform.localScale = new Vector3(1f, 1f, 1f);
						component4.gameObject.SetActive(true);
						component4.EKIFQMCDLLJ();
						component4.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component4.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Surf;
						component4.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component4.DBPKNCDGGEP = i;
						if (this.FGMFPEOQBNO == 0 && this.FGLGOGGLMMJ[i].SpriteID == 7)
						{
							flag = true;
							component4.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component4.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
						}
						else if (this.EHQEONDMHLC.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.FGMFPEOQBNO == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component4.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component4.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							}
							else
							{
								component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Owned";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0") + "\n[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.OKNBGPNOJDL(component4.gameObject);
						}
						string text5 = "4";
						component4.HODQHNIKPDM = text5;
						component4.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
						{
							"Player/Body",
							text,
							"/",
							ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL(),
							"_",
							ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL(),
							"_",
							text5
						}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component4.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text5, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component4.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component4.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component4.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component4.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 4 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Fly)
					{
						LNPEDCCCPPN component5 = this.JBLQIEPJLPN.JPODNGNQBKQ("skinshop", 1).GetComponent<LNPEDCCCPPN>();
						component5.transform.parent = this.JHDGENGBPQF.transform;
						component5.transform.localScale = new Vector3(1f, 1f, 1f);
						component5.gameObject.SetActive(true);
						component5.EKIFQMCDLLJ();
						component5.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component5.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Fly;
						component5.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component5.DBPKNCDGGEP = i;
						if (this.MCPQEOLLKNH == 0 && this.FGLGOGGLMMJ[i].SpriteID == 1)
						{
							flag = true;
							component5.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component5.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
						}
						else if (this.HGBDHOELHNJ.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.MCPQEOLLKNH == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component5.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component5.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Equipped";
							}
							else
							{
								component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[00DD00]Owned";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0") + "\n[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[PG]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "[PD]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("#,##0");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.OKNBGPNOJDL(component5.gameObject);
						}
						string hodqhnikpdm = "4";
						component5.HODQHNIKPDM = hodqhnikpdm;
						component5.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + EMLOFJDOMKH.QOQONHOOLNE.HNDLNMDNJOI(this.FGLGOGGLMMJ[i].SpriteID), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component5.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0f, 0f, 1f, 1f);
						component5.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component5.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component5.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component5.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component5.gameObject);
						}
					}
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(true);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(this.PMQOEMJKJML, true);
			this.JHDGENGBPQF.CLQFFBMLIQH = true;
			if (this.JQFHCCPHMNO > -1)
			{
				IEnumerator enumerator = this.JHDGENGBPQF.transform.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Transform transform = (Transform)obj;
						if (transform.GetComponent<LNPEDCCCPPN>().DBPKNCDGGEP == this.JQFHCCPHMNO)
						{
							transform.GetComponent<LNPEDCCCPPN>().PGDHENNHBDG();
						}
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
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x00022417 File Offset: 0x00020617
	public void CHDDNLKCQLQ()
	{
		this.DQPFLILJDEM.SetActive(true);
		this.QQOEQIBBIDC = 8;
		this.PMQOEMJKJML = 1559f;
		this.JQFHCCPHMNO = -1;
		this.QOLPJCIJOCP(5);
		this.UpdateGUI();
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x0002244B File Offset: 0x0002064B
	public void MJBNHCCOHQB()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 3;
		this.PMQOEMJKJML = 729f;
		this.JQFHCCPHMNO = -1;
		this.QOLPJCIJOCP(0);
		this.EPPOPBKQCQK();
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x0002247F File Offset: 0x0002067F
	public void POGMINNNJPI()
	{
		if (this.GEPLOLLDDDL)
		{
			return;
		}
		this.GEPLOLLDDDL = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Skins(), true);
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x000224A1 File Offset: 0x000206A1
	private void Start()
	{
		this.JBLQIEPJLPN = LPEQICNMHIL.QOQONHOOLNE;
		this.EINFMIKHKBJ(0);
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x000224B5 File Offset: 0x000206B5
	public void ClickSurfMounts()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 3;
		this.PMQOEMJKJML = 0f;
		this.JQFHCCPHMNO = -1;
		this.EINFMIKHKBJ(3);
		this.UpdateGUI();
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x002CD028 File Offset: 0x002CB228
	public void GMCEEBIOQIL()
	{
		if (this.LDCIFEQGFQQ.GINPFQOBGBO == new Rect(433f, 1815f, 1148f, 455f))
		{
			return;
		}
		this.IBQPCCDGLEC += 256f;
		if (this.IBQPCCDGLEC >= 1256f)
		{
			this.IBQPCCDGLEC = 470f;
		}
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(523f, this.IBQPCCDGLEC, 173f, 1582f);
		this.LINHMLKDFMN.GGLBJMEKGQL(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		this.PKBPIHPBFLG.GGLBJMEKGQL(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		this.KNPPMKBOGDL.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.DGOOHFGLFMI.GGLBJMEKGQL(this.LDCIFEQGFQQ.GINPFQOBGBO);
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x000224E9 File Offset: 0x000206E9
	public void HFBLCLEQNNB(PSXAPI.Response.Skins BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.All != null)
		{
			this.FGLGOGGLMMJ = BJGCBDNBQCJ.All;
			this.HCQINBCDGNO.SetActive(false);
			this.EPPOPBKQCQK();
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x06005796 RID: 22422 RVA: 0x00022511 File Offset: 0x00020711
	public static DNFENPQLICQ QOQONHOOLNE
	{
		get
		{
			return DNFENPQLICQ.HBFFCJHOCPE;
		}
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x00022518 File Offset: 0x00020718
	public void ClickMounts()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 2;
		this.PMQOEMJKJML = 0f;
		this.JQFHCCPHMNO = -1;
		this.EINFMIKHKBJ(2);
		this.UpdateGUI();
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x0002254C File Offset: 0x0002074C
	public void ClickFlyMounts()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 4;
		this.PMQOEMJKJML = 0f;
		this.JQFHCCPHMNO = -1;
		this.EINFMIKHKBJ(4);
		this.UpdateGUI();
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x002CD108 File Offset: 0x002CB308
	public void PIFJCFHOJNE()
	{
		this.JQFHCCPHMNO = -1;
		this.DQPFLILJDEM.SetActive(false);
		this.FJEKDQBMPBJ();
		base.CancelInvoke("The Pokémon is so lucky that the critical-hit ratios of its moves are boosted.");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1156f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.UpdateGUI();
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x00022580 File Offset: 0x00020780
	public void LIOGLBBCPBF()
	{
		this.DQPFLILJDEM.SetActive(true);
		this.QQOEQIBBIDC = 8;
		this.PMQOEMJKJML = 498f;
		this.JQFHCCPHMNO = -1;
		this.QOLPJCIJOCP(3);
		this.UpdateGUI();
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x000225B4 File Offset: 0x000207B4
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600579D RID: 22429 RVA: 0x002CD1D4 File Offset: 0x002CB3D4
	public void KMQCHQGLKOE(PSXAPI.Response.Skin BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Action == PSXAPI.Response.SkinAction.Add)
		{
			switch (BJGCBDNBQCJ.Type)
			{
			case PSXAPI.Response.Payload.SkinType.None:
				this.DDIDOHCLEBJ.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Clothe:
				this.POIOQEQPCFK.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Hat:
				this.FEDPGMLPLQN.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Mount:
				this.EHQEONDMHLC.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Surf:
				this.HGBDHOELHNJ.Add(BJGCBDNBQCJ.SpriteID);
				break;
			}
			this.UpdateGUI();
		}
	}

	// Token: 0x0600579E RID: 22430 RVA: 0x002CD278 File Offset: 0x002CB478
	private void QOLPJCIJOCP(int OMBOCJEKDFF)
	{
		CFDMNELIJLO[] pgblhmldgoj = this.PGBLHMLDGOJ;
		for (int i = 1; i < pgblhmldgoj.Length; i += 0)
		{
			CFDMNELIJLO cfdmnelijlo = pgblhmldgoj[i];
			cfdmnelijlo.enabled = true;
		}
		this.PGBLHMLDGOJ[OMBOCJEKDFF].enabled = true;
		this.PGBLHMLDGOJ[OMBOCJEKDFF].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x000225DD File Offset: 0x000207DD
	private void Awake()
	{
		DNFENPQLICQ.HBFFCJHOCPE = this;
	}

	// Token: 0x060057A0 RID: 22432 RVA: 0x002CD2C4 File Offset: 0x002CB4C4
	public void EMQECLQMBEC(PSXAPI.Response.Skin BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Action == PSXAPI.Response.SkinAction.Add)
		{
			switch (BJGCBDNBQCJ.Type)
			{
			case PSXAPI.Response.Payload.SkinType.Clothe:
				this.DDIDOHCLEBJ.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Hat:
				this.POIOQEQPCFK.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Mount:
				this.FEDPGMLPLQN.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Surf:
				this.EHQEONDMHLC.Add(BJGCBDNBQCJ.SpriteID);
				break;
			case PSXAPI.Response.Payload.SkinType.Fly:
				this.HGBDHOELHNJ.Add(BJGCBDNBQCJ.SpriteID);
				break;
			}
			this.UpdateGUI();
		}
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x000225E5 File Offset: 0x000207E5
	public void FJEKDQBMPBJ()
	{
		if (this.GEPLOLLDDDL)
		{
			return;
		}
		this.GEPLOLLDDDL = true;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Skins(), false);
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x002CD368 File Offset: 0x002CB568
	public void HQQMDICDKCB(UserSkins BJGCBDNBQCJ)
	{
		this.KJPIOFDLCOD = BJGCBDNBQCJ.EquipedClothe;
		this.QEPOHCJIGQP = BJGCBDNBQCJ.EquipedHat;
		this.HHNPLECEPEI = BJGCBDNBQCJ.EquipedMount;
		this.FGMFPEOQBNO = BJGCBDNBQCJ.EquipedSurfMount;
		this.MCPQEOLLKNH = BJGCBDNBQCJ.EquipedFlyMount;
		if (BJGCBDNBQCJ.Hats != null)
		{
			this.POIOQEQPCFK.AddRange(BJGCBDNBQCJ.Hats);
		}
		if (BJGCBDNBQCJ.Clothes != null)
		{
			this.DDIDOHCLEBJ.AddRange(BJGCBDNBQCJ.Clothes);
		}
		if (BJGCBDNBQCJ.Mounts != null)
		{
			this.FEDPGMLPLQN.AddRange(BJGCBDNBQCJ.Mounts);
		}
		if (BJGCBDNBQCJ.SurfMounts != null)
		{
			this.EHQEONDMHLC.AddRange(BJGCBDNBQCJ.SurfMounts);
		}
		if (BJGCBDNBQCJ.FlyMounts != null)
		{
			this.HGBDHOELHNJ.AddRange(BJGCBDNBQCJ.FlyMounts);
		}
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x002CD368 File Offset: 0x002CB568
	public void KEBOBBFCKON(UserSkins BJGCBDNBQCJ)
	{
		this.KJPIOFDLCOD = BJGCBDNBQCJ.EquipedClothe;
		this.QEPOHCJIGQP = BJGCBDNBQCJ.EquipedHat;
		this.HHNPLECEPEI = BJGCBDNBQCJ.EquipedMount;
		this.FGMFPEOQBNO = BJGCBDNBQCJ.EquipedSurfMount;
		this.MCPQEOLLKNH = BJGCBDNBQCJ.EquipedFlyMount;
		if (BJGCBDNBQCJ.Hats != null)
		{
			this.POIOQEQPCFK.AddRange(BJGCBDNBQCJ.Hats);
		}
		if (BJGCBDNBQCJ.Clothes != null)
		{
			this.DDIDOHCLEBJ.AddRange(BJGCBDNBQCJ.Clothes);
		}
		if (BJGCBDNBQCJ.Mounts != null)
		{
			this.FEDPGMLPLQN.AddRange(BJGCBDNBQCJ.Mounts);
		}
		if (BJGCBDNBQCJ.SurfMounts != null)
		{
			this.EHQEONDMHLC.AddRange(BJGCBDNBQCJ.SurfMounts);
		}
		if (BJGCBDNBQCJ.FlyMounts != null)
		{
			this.HGBDHOELHNJ.AddRange(BJGCBDNBQCJ.FlyMounts);
		}
	}

	// Token: 0x060057A4 RID: 22436 RVA: 0x00022607 File Offset: 0x00020807
	private void HGBQFJMBMDO()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x00022511 File Offset: 0x00020711
	public static DNFENPQLICQ JJCONJJNDQN()
	{
		return DNFENPQLICQ.HBFFCJHOCPE;
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x0002261A File Offset: 0x0002081A
	public void BKHNJILOJCB()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 0;
		this.PMQOEMJKJML = 340f;
		this.EINFMIKHKBJ(1);
		this.UpdateGUI();
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x00022647 File Offset: 0x00020847
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060057A8 RID: 22440 RVA: 0x002CD430 File Offset: 0x002CB630
	public void RotateLeft()
	{
		if (this.LDCIFEQGFQQ.GINPFQOBGBO == new Rect(0f, 0f, 1f, 1f))
		{
			return;
		}
		this.IBQPCCDGLEC -= 0.25f;
		if (this.IBQPCCDGLEC < 0f)
		{
			this.IBQPCCDGLEC = 0.75f;
		}
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, this.IBQPCCDGLEC, 0.25f, 0.25f);
		this.LINHMLKDFMN.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.PKBPIHPBFLG.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.KNPPMKBOGDL.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.DGOOHFGLFMI.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x002CD510 File Offset: 0x002CB710
	public void EquipItem()
	{
		PSXAPI.Request.SkinType pikdjcddppc = this.PIKDJCDDPPC;
		if (pikdjcddppc != PSXAPI.Request.SkinType.Mount)
		{
			if (pikdjcddppc == PSXAPI.Request.SkinType.Surf)
			{
				this.FGMFPEOQBNO = this.FGLGOGGLMMJ[this.JQFHCCPHMNO].SpriteID;
			}
		}
		else
		{
			this.HHNPLECEPEI = this.FGLGOGGLMMJ[this.JQFHCCPHMNO].SpriteID;
		}
		this.PMQOEMJKJML = this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		this.UpdateGUI();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Skin
		{
			Action = PSXAPI.Request.SkinAction.Equip,
			Type = this.PIKDJCDDPPC,
			SpriteID = this.FGLGOGGLMMJ[this.JQFHCCPHMNO].SpriteID
		}, false);
	}

	// Token: 0x060057AA RID: 22442 RVA: 0x0002265A File Offset: 0x0002085A
	public void FHQOFHNMIMG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.HDQPGPMIJGH();
		}
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x002CD5C8 File Offset: 0x002CB7C8
	public void BuyItem()
	{
		this.PMQOEMJKJML = this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
		if (INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ >= this.FGLGOGGLMMJ[this.JQFHCCPHMNO].MoneyPrice && INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB >= this.FGLGOGGLMMJ[this.JQFHCCPHMNO].GoldPrice)
		{
			CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
			string hiefqeedhgg = "Purchase Costume";
			string nqfqgcgphbe = "Are you sure you want to purchase '" + this.FGLGOGGLMMJ[this.JQFHCCPHMNO].Name + "'?";
			int pikdjcddppc = (int)this.PIKDJCDDPPC;
			qoqonhoolne.OBCNMKNGFIF(hiefqeedhgg, nqfqgcgphbe, pikdjcddppc.ToString() + ":" + this.FGLGOGGLMMJ[this.JQFHCCPHMNO].SpriteID.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Purchasing Costume", "You can not afford to buy this item.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
	}

	// Token: 0x060057AC RID: 22444 RVA: 0x002CD6CC File Offset: 0x002CB8CC
	private void EINFMIKHKBJ(int OMBOCJEKDFF)
	{
		foreach (CFDMNELIJLO cfdmnelijlo in this.PGBLHMLDGOJ)
		{
			cfdmnelijlo.enabled = true;
		}
		this.PGBLHMLDGOJ[OMBOCJEKDFF].enabled = false;
		this.PGBLHMLDGOJ[OMBOCJEKDFF].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x002CD718 File Offset: 0x002CB918
	private void Update()
	{
		if (this.HCQINBCDGNO.gameObject.activeSelf)
		{
			this.HCQINBCDGNO.transform.localEulerAngles += new Vector3(0f, 0f, -256f * UnityEngine.Time.deltaTime);
		}
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x0002268C File Offset: 0x0002088C
	public void ClickHats()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 1;
		this.PMQOEMJKJML = 0f;
		this.EINFMIKHKBJ(1);
		this.UpdateGUI();
	}

	// Token: 0x060057AF RID: 22447 RVA: 0x000226B9 File Offset: 0x000208B9
	public void MCEDQOBOFJN()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke(",", 1894f);
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x002CD76C File Offset: 0x002CB96C
	public void CPPFBCNMQHN()
	{
		if (this.LDCIFEQGFQQ.GINPFQOBGBO == new Rect(1130f, 1750f, 477f, 1980f))
		{
			return;
		}
		this.IBQPCCDGLEC += 265f;
		if (this.IBQPCCDGLEC >= 79f)
		{
			this.IBQPCCDGLEC = 527f;
		}
		this.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(1445f, this.IBQPCCDGLEC, 301f, 48f));
		this.LINHMLKDFMN.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.PKBPIHPBFLG.GINPFQOBGBO = this.LDCIFEQGFQQ.OOGJHJDFEFJ();
		this.KNPPMKBOGDL.IBQDCLQMGLG(this.LDCIFEQGFQQ.GINPFQOBGBO);
		this.DGOOHFGLFMI.IBQDCLQMGLG(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
	}

	// Token: 0x060057B1 RID: 22449 RVA: 0x000226E2 File Offset: 0x000208E2
	public void QJLNMMDGPMI()
	{
		if (this.GEPLOLLDDDL)
		{
			return;
		}
		this.GEPLOLLDDDL = true;
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Skins(), false);
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x002CD84C File Offset: 0x002CBA4C
	public void EPPOPBKQCQK()
	{
		this.DQPFLILJDEM.SetActive(false);
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.JBLQIEPJLPN.KNJDCJDDLDF("timer", 0);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(1073f, true);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
			string text = string.Empty;
			if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
			{
				text = "\r\nLv ";
			}
			else
			{
				text = "The Pokémon can hit Ghost-type Pokémon with Normal- and Fighting-type moves.";
			}
			if (this.FGLGOGGLMMJ != null && this.FGLGOGGLMMJ.Length > 0)
			{
				for (int i = 1; i < this.FGLGOGGLMMJ.Length; i += 0)
				{
					bool flag = false;
					if (this.QQOEQIBBIDC == 0 && this.FGLGOGGLMMJ[i].Type == PSXAPI.Response.Payload.SkinType.Clothe)
					{
						LNPEDCCCPPN component = this.JBLQIEPJLPN.FCIIBFEGBML("_Vignette_Color", 0).GetComponent<LNPEDCCCPPN>();
						component.transform.parent = this.JHDGENGBPQF.transform;
						component.transform.localScale = new Vector3(1101f, 854f, 1365f);
						component.gameObject.SetActive(true);
						component.EKIFQMCDLLJ();
						component.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component.BBKKHIDMQIQ = PSXAPI.Request.SkinType.None;
						component.NKKMJICKKLB.LKPOBCBOFIC(this.FGLGOGGLMMJ[i].Name);
						component.DBPKNCDGGEP = i;
						if (this.DDIDOHCLEBJ.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = false;
							if (this.KJPIOFDLCOD == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component.PLCBFLQBCQN.LKPOBCBOFIC("Stench");
							}
							else
							{
								component.PLCBFLQBCQN.PIDLOFMIEFQ = "Could not find a ConstantShakePreset with the name: ";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "noguard" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("_") + "purepower" + this.FGLGOGGLMMJ[i].MoneyPrice.ToString("Username");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "'s wish came true!\r\n" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("MSGBOX - Confirm EVs");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component.PLCBFLQBCQN.PIDLOFMIEFQ = "Assets/AssetBundles/MapAssets2/Models/Materials/c102_mado.mat" + this.FGLGOGGLMMJ[i].MoneyPrice.ToString("/00_1");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component.PLCBFLQBCQN.LKPOBCBOFIC(string.Empty);
							this.JBLQIEPJLPN.GICMLGFNLNL(component.gameObject);
						}
						string text2 = "Assets/AssetBundles/Sprites/";
						component.HODQHNIKPDM = text2;
						ENFMCDNLEQQ ldcifeqgfqq = component.LDCIFEQGFQQ;
						GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
						string[] array = new string[4];
						array[1] = "0";
						array[0] = text;
						array[7] = "Pokémon Caught:";
						array[1] = ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL();
						array[2] = "miniormeteor";
						array[6] = ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
						array[4] = "/call ";
						array[8] = text2;
						ldcifeqgfqq.GOIHJQNMMJD = gfhgejnhlfq.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(544f, 865f, 257f, 1004f));
						ENFMCDNLEQQ pkbpihpbflg = component.PKBPIHPBFLG;
						GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.MOGQNGEPCEO();
						string[] array2 = new string[1];
						array2[0] = "[-]!\r\n";
						array2[1] = text;
						array2[1] = "strongjaw";
						array2[3] = this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL();
						array2[3] = " Changed to Shield Forme!\r\n";
						array2[6] = text2;
						pkbpihpbflg.GOIHJQNMMJD = gfhgejnhlfq2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component.PKBPIHPBFLG.IBQDCLQMGLG(new Rect(1948f, 455f, 402f, 1863f));
						component.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("OnDragOver", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("bounce", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.QGHHECDQCDI(component.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.HJGBDJEFOJK(component.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 0 && this.FGLGOGGLMMJ[i].Type == (PSXAPI.Response.Payload.SkinType)6)
					{
						LNPEDCCCPPN component2 = this.JBLQIEPJLPN.FCIIBFEGBML("4x", 1).GetComponent<LNPEDCCCPPN>();
						component2.transform.parent = this.JHDGENGBPQF.transform;
						component2.transform.localScale = new Vector3(904f, 1606f, 1016f);
						component2.gameObject.SetActive(false);
						component2.CQPDQGHHKCM();
						component2.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component2.BBKKHIDMQIQ = PSXAPI.Request.SkinType.None;
						component2.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component2.DBPKNCDGGEP = i;
						if (this.POIOQEQPCFK.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.QEPOHCJIGQP == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component2.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component2.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component2.PLCBFLQBCQN.LKPOBCBOFIC("Pokédollars");
							}
							else
							{
								component2.PLCBFLQBCQN.PIDLOFMIEFQ = "Trade Request";
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component2.PLCBFLQBCQN.LKPOBCBOFIC("Battle Update: " + this.FGLGOGGLMMJ[i].GoldPrice.ToString("-") + "-primal" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("1"));
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component2.PLCBFLQBCQN.PIDLOFMIEFQ = "You are unable to use " + this.FGLGOGGLMMJ[i].GoldPrice.ToString("F");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component2.PLCBFLQBCQN.LKPOBCBOFIC("   " + this.FGLGOGGLMMJ[i].GoldPrice.ToString("Enabled"));
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component2.PLCBFLQBCQN.LKPOBCBOFIC(string.Empty);
							this.JBLQIEPJLPN.NOONCJPPGJD(component2.gameObject);
						}
						component2.GMCQFIGGJKE = this.FGLGOGGLMMJ[i].SpriteID;
						string text3 = "East";
						component2.HODQHNIKPDM = text3;
						ENFMCDNLEQQ ldcifeqgfqq2 = component2.LDCIFEQGFQQ;
						GFHGEJNHLFQ gfhgejnhlfq3 = GFHGEJNHLFQ.BEKHPOHIPDE();
						string[] array3 = new string[6];
						array3[0] = "Temporarily Suspended";
						array3[0] = text;
						array3[8] = "[FFFF00]/252";
						array3[4] = ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL();
						array3[2] = "Limit Distance";
						array3[7] = ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
						array3[4] = "\\n";
						array3[8] = text3;
						ldcifeqgfqq2.GOIHJQNMMJD = gfhgejnhlfq3.CPFJEOGMHOD(string.Concat(array3), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component2.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1615f, 1251f, 1556f, 1615f));
						component2.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("FOG_AREA_BOX" + text + "Heat" + text3, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component2.PKBPIHPBFLG.GINPFQOBGBO = new Rect(716f, 1147f, 1390f, 493f);
						component2.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("fnt" + (this.FGLGOGGLMMJ[i].SpriteID - 1).QQKICQQBIJL() + "[-]" + text3, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component2.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(1531f, 887f, 127f, 1444f));
						component2.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("FinishSelect", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.HPEHCEBQJGI(component2.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.HJGBDJEFOJK(component2.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 2 && this.FGLGOGGLMMJ[i].Type == (PSXAPI.Response.Payload.SkinType)8)
					{
						LNPEDCCCPPN component3 = this.JBLQIEPJLPN.JPODNGNQBKQ("LJMOLEKDCLP", 1).GetComponent<LNPEDCCCPPN>();
						component3.transform.parent = this.JHDGENGBPQF.transform;
						component3.transform.localScale = new Vector3(247f, 111f, 1954f);
						component3.gameObject.SetActive(false);
						component3.PCDQLKMQEDN();
						component3.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component3.BBKKHIDMQIQ = (PSXAPI.Request.SkinType)8;
						component3.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component3.DBPKNCDGGEP = i;
						if (this.FGLGOGGLMMJ[i].Name.ToLowerInvariant().Contains("..."))
						{
							component3.OBHJIDJOFFO.SetActive(false);
						}
						if (this.HHNPLECEPEI == 0 && this.FGLGOGGLMMJ[i].SpriteID < 2)
						{
							component3.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component3.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component3.PLCBFLQBCQN.LKPOBCBOFIC("UpdateTweenPosition");
							flag = false;
						}
						else if (this.FEDPGMLPLQN.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.HHNPLECEPEI == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component3.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component3.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component3.PLCBFLQBCQN.LKPOBCBOFIC("BuffIcon_RodCooldown");
							}
							else
							{
								component3.PLCBFLQBCQN.LKPOBCBOFIC(" Obtained");
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component3.PLCBFLQBCQN.PIDLOFMIEFQ = "CombinersArgsAlphaSrc1" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("[PD]") + "[ff6666]" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("More Likely Male Encounters");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component3.PLCBFLQBCQN.LKPOBCBOFIC("Are you sure you want to purchase '" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("Hidden/Post FX/Blit"));
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component3.PLCBFLQBCQN.LKPOBCBOFIC("poke" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("Shadow Tag"));
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component3.PLCBFLQBCQN.LKPOBCBOFIC(string.Empty);
							this.JBLQIEPJLPN.HPEHCEBQJGI(component3.gameObject);
						}
						string text4 = "Snow Warning";
						if (this.FGLGOGGLMMJ[i].SpriteID == 0 || this.FGLGOGGLMMJ[i].SpriteID == 0 || this.FGLGOGGLMMJ[i].SpriteID == 12 || this.FGLGOGGLMMJ[i].SpriteID == -77 || this.FGLGOGGLMMJ[i].SpriteID == -22)
						{
							text4 = "Btn_TabHighlighted_Hover";
						}
						component3.HODQHNIKPDM = text4;
						ENFMCDNLEQQ ldcifeqgfqq3 = component3.LDCIFEQGFQQ;
						GFHGEJNHLFQ gfhgejnhlfq4 = GFHGEJNHLFQ.MOGQNGEPCEO();
						string[] array4 = new string[2];
						array4[0] = "Flame Body";
						array4[1] = text;
						array4[6] = "CombinersArgsAlphaSrc0";
						array4[2] = ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL();
						array4[7] = "PrimitiveInnerRight";
						array4[4] = ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
						array4[2] = "default";
						array4[5] = text4;
						ldcifeqgfqq3.GOIHJQNMMJD = gfhgejnhlfq4.NMPCLCEQJMP(string.Concat(array4), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("/01_" + text + "1" + text4, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("_FadeDistance" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL() + "other", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component3.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("tox" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.EPGKCMBINEO(component3.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.HBEBEOPGHPM(component3.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 6 && this.FGLGOGGLMMJ[i].Type == (PSXAPI.Response.Payload.SkinType)8)
					{
						LNPEDCCCPPN component4 = this.JBLQIEPJLPN.HCOQJPNIEHI("The heavy rain has lifted!", 1).GetComponent<LNPEDCCCPPN>();
						component4.transform.parent = this.JHDGENGBPQF.transform;
						component4.transform.localScale = new Vector3(1832f, 1471f, 654f);
						component4.gameObject.SetActive(true);
						component4.DGPQBHEQEJH();
						component4.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component4.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Mount;
						component4.NKKMJICKKLB.LKPOBCBOFIC(this.FGLGOGGLMMJ[i].Name);
						component4.DBPKNCDGGEP = i;
						if (this.FGMFPEOQBNO == 0 && this.FGLGOGGLMMJ[i].SpriteID == 8)
						{
							flag = true;
							component4.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component4.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = " minutes";
						}
						else if (this.EHQEONDMHLC.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = false;
							if (this.FGMFPEOQBNO == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component4.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component4.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component4.PLCBFLQBCQN.LKPOBCBOFIC("-formechange");
							}
							else
							{
								component4.PLCBFLQBCQN.LKPOBCBOFIC("magnetrise");
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "strongjaw" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("\n") + "\n" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("Failed to use '");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component4.PLCBFLQBCQN.LKPOBCBOFIC("Remove from Ignore" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("[-]!\r\n"));
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component4.PLCBFLQBCQN.PIDLOFMIEFQ = "phscore" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("17");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component4.PLCBFLQBCQN.LKPOBCBOFIC(string.Empty);
							this.JBLQIEPJLPN.HPEHCEBQJGI(component4.gameObject);
						}
						string text5 = " endured the hit!\r\n";
						component4.HODQHNIKPDM = text5;
						ENFMCDNLEQQ ldcifeqgfqq4 = component4.LDCIFEQGFQQ;
						GFHGEJNHLFQ gfhgejnhlfq5 = GFHGEJNHLFQ.MOGQNGEPCEO();
						string[] array5 = new string[2];
						array5[0] = "#,##0";
						array5[1] = text;
						array5[6] = "PrimitiveLeft";
						array5[7] = ppmjcbonmqj.HDCKEHHFCDN.Skin.QQKICQQBIJL();
						array5[7] = "_MainTex";
						array5[4] = ppmjcbonmqj.HDCKEHHFCDN.Eyes.QQKICQQBIJL();
						array5[3] = "The Pokémon moves after all other Pokémon do.";
						array5[1] = text5;
						ldcifeqgfqq4.GOIHJQNMMJD = gfhgejnhlfq5.GOKLDOEGJHI(string.Concat(array5), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component4.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Own Tempo" + text + " and " + text5, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component4.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("_GrainTex" + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL() + "HidePanel", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component4.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("UnityEngine." + this.FGLGOGGLMMJ[i].SpriteID.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.HJGBDJEFOJK(component4.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.NOONCJPPGJD(component4.gameObject);
						}
					}
					if (this.QQOEQIBBIDC == 5 && this.FGLGOGGLMMJ[i].Type == (PSXAPI.Response.Payload.SkinType)6)
					{
						LNPEDCCCPPN component5 = this.JBLQIEPJLPN.GKNLQNEMKKF(".", 1).GetComponent<LNPEDCCCPPN>();
						component5.transform.parent = this.JHDGENGBPQF.transform;
						component5.transform.localScale = new Vector3(1724f, 1360f, 102f);
						component5.gameObject.SetActive(true);
						component5.EMPDNCICEBL();
						component5.gameObject.name = this.FGLGOGGLMMJ[i].Name;
						component5.BBKKHIDMQIQ = PSXAPI.Request.SkinType.Fly;
						component5.NKKMJICKKLB.PIDLOFMIEFQ = this.FGLGOGGLMMJ[i].Name;
						component5.DBPKNCDGGEP = i;
						if (this.MCPQEOLLKNH == 0 && this.FGLGOGGLMMJ[i].SpriteID == 0)
						{
							flag = true;
							component5.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
							component5.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "Direct3D";
						}
						else if (this.HGBDHOELHNJ.Contains(this.FGLGOGGLMMJ[i].SpriteID))
						{
							flag = true;
							if (this.MCPQEOLLKNH == this.FGLGOGGLMMJ[i].SpriteID)
							{
								component5.BLLHQPQBHBB.IDEOONDHNEL = this.KMKNQPELMDI;
								component5.BLLHQPQBHBB.BKOENCLICDI = this.KMKNQPELMDI;
								component5.PLCBFLQBCQN.LKPOBCBOFIC("<|>");
							}
							else
							{
								component5.PLCBFLQBCQN.LKPOBCBOFIC("-mega-x");
							}
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u && this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("???") + "Bounty Quests" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("QGKFGKOJKCK");
						}
						else if (this.FGLGOGGLMMJ[i].GoldPrice != 0u)
						{
							component5.PLCBFLQBCQN.LKPOBCBOFIC("Gooey" + this.FGLGOGGLMMJ[i].GoldPrice.ToString("]#"));
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice != 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = "Boosts move power when the Pokémon moves last." + this.FGLGOGGLMMJ[i].GoldPrice.ToString("[-] ");
						}
						else if (this.FGLGOGGLMMJ[i].MoneyPrice == 0u && this.FGLGOGGLMMJ[i].GoldPrice == 0u)
						{
							component5.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
							this.JBLQIEPJLPN.EPGKCMBINEO(component5.gameObject);
						}
						string hodqhnikpdm = "System";
						component5.HODQHNIKPDM = hodqhnikpdm;
						component5.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("Assets/AssetBundles/MapAssets/Models/Materials/com_c02_mado0.mat" + EMLOFJDOMKH.BDPEQNCNPJO().NDQBBBFNBEE(this.FGLGOGGLMMJ[i].SpriteID), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component5.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1848f, 20f, 583f, 657f));
						component5.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("ffb649", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
						component5.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("[-]!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						component5.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("unaware", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
						if (!this.HJQICCFQQFK.value && flag)
						{
							this.JBLQIEPJLPN.OKNBGPNOJDL(component5.gameObject);
						}
						if (!this.MMQHQBGPIQH.value && !flag)
						{
							this.JBLQIEPJLPN.NOONCJPPGJD(component5.gameObject);
						}
					}
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(true);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(this.PMQOEMJKJML, true);
			this.JHDGENGBPQF.CLQFFBMLIQH = false;
			if (this.JQFHCCPHMNO > -1)
			{
				IEnumerator enumerator = this.JHDGENGBPQF.transform.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Transform transform = (Transform)obj;
						if (transform.GetComponent<LNPEDCCCPPN>().DBPKNCDGGEP == this.JQFHCCPHMNO)
						{
							transform.GetComponent<LNPEDCCCPPN>().JOLFPPDQBQF();
						}
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
	}

	// Token: 0x060057B3 RID: 22451 RVA: 0x002CEF54 File Offset: 0x002CD154
	public void RotateRight()
	{
		if (this.LDCIFEQGFQQ.GINPFQOBGBO == new Rect(0f, 0f, 1f, 1f))
		{
			return;
		}
		this.IBQPCCDGLEC += 0.25f;
		if (this.IBQPCCDGLEC >= 0.9f)
		{
			this.IBQPCCDGLEC = 0f;
		}
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, this.IBQPCCDGLEC, 0.25f, 0.25f);
		this.LINHMLKDFMN.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.PKBPIHPBFLG.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.KNPPMKBOGDL.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		this.DGOOHFGLFMI.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
	}

	// Token: 0x060057B4 RID: 22452 RVA: 0x00022704 File Offset: 0x00020904
	public void ClickClothes()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 0;
		this.PMQOEMJKJML = 0f;
		this.JQFHCCPHMNO = -1;
		this.EINFMIKHKBJ(0);
		this.UpdateGUI();
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x00022511 File Offset: 0x00020711
	public static DNFENPQLICQ BDPEQNCNPJO()
	{
		return DNFENPQLICQ.HBFFCJHOCPE;
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x002CD368 File Offset: 0x002CB568
	public void IJFEPHBHDJG(UserSkins BJGCBDNBQCJ)
	{
		this.KJPIOFDLCOD = BJGCBDNBQCJ.EquipedClothe;
		this.QEPOHCJIGQP = BJGCBDNBQCJ.EquipedHat;
		this.HHNPLECEPEI = BJGCBDNBQCJ.EquipedMount;
		this.FGMFPEOQBNO = BJGCBDNBQCJ.EquipedSurfMount;
		this.MCPQEOLLKNH = BJGCBDNBQCJ.EquipedFlyMount;
		if (BJGCBDNBQCJ.Hats != null)
		{
			this.POIOQEQPCFK.AddRange(BJGCBDNBQCJ.Hats);
		}
		if (BJGCBDNBQCJ.Clothes != null)
		{
			this.DDIDOHCLEBJ.AddRange(BJGCBDNBQCJ.Clothes);
		}
		if (BJGCBDNBQCJ.Mounts != null)
		{
			this.FEDPGMLPLQN.AddRange(BJGCBDNBQCJ.Mounts);
		}
		if (BJGCBDNBQCJ.SurfMounts != null)
		{
			this.EHQEONDMHLC.AddRange(BJGCBDNBQCJ.SurfMounts);
		}
		if (BJGCBDNBQCJ.FlyMounts != null)
		{
			this.HGBDHOELHNJ.AddRange(BJGCBDNBQCJ.FlyMounts);
		}
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x002CF034 File Offset: 0x002CD234
	public void Open()
	{
		this.JQFHCCPHMNO = -1;
		this.DQPFLILJDEM.SetActive(false);
		this.FJEKDQBMPBJ();
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.UpdateGUI();
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060057B8 RID: 22456 RVA: 0x00022607 File Offset: 0x00020807
	private void PCNIPNDDFHM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x00022738 File Offset: 0x00020938
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x0002276A File Offset: 0x0002096A
	public void HDQPGPMIJGH()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Big/", 1470f);
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x00022793 File Offset: 0x00020993
	public void NOMBJKBLIDC()
	{
		this.DQPFLILJDEM.SetActive(false);
		this.QQOEQIBBIDC = 0;
		this.PMQOEMJKJML = 1423f;
		this.JQFHCCPHMNO = -1;
		this.EINFMIKHKBJ(1);
		this.EPPOPBKQCQK();
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x000227C7 File Offset: 0x000209C7
	public void HNIQIFCKMNC(PSXAPI.Response.Skins BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.All != null)
		{
			this.FGLGOGGLMMJ = BJGCBDNBQCJ.All;
			this.HCQINBCDGNO.SetActive(false);
			this.UpdateGUI();
		}
	}

	// Token: 0x0400130B RID: 4875
	public UIToggle HJQICCFQQFK;

	// Token: 0x0400130C RID: 4876
	public UIToggle MMQHQBGPIQH;

	// Token: 0x0400130D RID: 4877
	private static DNFENPQLICQ HBFFCJHOCPE;

	// Token: 0x0400130E RID: 4878
	private LPEQICNMHIL JBLQIEPJLPN;

	// Token: 0x0400130F RID: 4879
	private List<int> POIOQEQPCFK = new List<int>();

	// Token: 0x04001310 RID: 4880
	private List<int> DDIDOHCLEBJ = new List<int>();

	// Token: 0x04001311 RID: 4881
	private List<int> FEDPGMLPLQN = new List<int>();

	// Token: 0x04001312 RID: 4882
	private List<int> EHQEONDMHLC = new List<int>();

	// Token: 0x04001313 RID: 4883
	private List<int> HGBDHOELHNJ = new List<int>();

	// Token: 0x04001314 RID: 4884
	public int KJPIOFDLCOD;

	// Token: 0x04001315 RID: 4885
	public int QEPOHCJIGQP;

	// Token: 0x04001316 RID: 4886
	public int HHNPLECEPEI;

	// Token: 0x04001317 RID: 4887
	public int FGMFPEOQBNO;

	// Token: 0x04001318 RID: 4888
	public int MCPQEOLLKNH;

	// Token: 0x04001319 RID: 4889
	private PSXAPI.Response.Payload.Skin[] FGLGOGGLMMJ;

	// Token: 0x0400131A RID: 4890
	public GameObject HCQINBCDGNO;

	// Token: 0x0400131B RID: 4891
	public GameObject FHOFDEIBFNH;

	// Token: 0x0400131C RID: 4892
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x0400131D RID: 4893
	private bool GEPLOLLDDDL;

	// Token: 0x0400131E RID: 4894
	private int QQOEQIBBIDC;

	// Token: 0x0400131F RID: 4895
	public CFDMNELIJLO[] PGBLHMLDGOJ;

	// Token: 0x04001320 RID: 4896
	private float PMQOEMJKJML;

	// Token: 0x04001321 RID: 4897
	public Color KMKNQPELMDI;

	// Token: 0x04001322 RID: 4898
	public BKKHLBCLPJM QJBKBGOGFKB;

	// Token: 0x04001323 RID: 4899
	public BKKHLBCLPJM EJHCCNOOBBH;

	// Token: 0x04001324 RID: 4900
	public BKKHLBCLPJM HQODFDDPQIN;

	// Token: 0x04001325 RID: 4901
	public BKKHLBCLPJM PECEMJFDJHB;

	// Token: 0x04001326 RID: 4902
	public JLMPBLMOICG LDCIFEQGFQQ;

	// Token: 0x04001327 RID: 4903
	public JLMPBLMOICG PKBPIHPBFLG;

	// Token: 0x04001328 RID: 4904
	public JLMPBLMOICG KNPPMKBOGDL;

	// Token: 0x04001329 RID: 4905
	public JLMPBLMOICG DGOOHFGLFMI;

	// Token: 0x0400132A RID: 4906
	public JLMPBLMOICG LINHMLKDFMN;

	// Token: 0x0400132B RID: 4907
	public GameObject IHHPBBJKKGP;

	// Token: 0x0400132C RID: 4908
	public GameObject BKOHNOHJIEI;

	// Token: 0x0400132D RID: 4909
	public BKKHLBCLPJM PMLQJPCKCOF;

	// Token: 0x0400132E RID: 4910
	public GameObject DQPFLILJDEM;

	// Token: 0x0400132F RID: 4911
	public CFDMNELIJLO KIMLCNBIMMG;

	// Token: 0x04001330 RID: 4912
	public int JQFHCCPHMNO = -1;

	// Token: 0x04001331 RID: 4913
	public PSXAPI.Request.SkinType PIKDJCDDPPC;

	// Token: 0x04001332 RID: 4914
	public float IBQPCCDGLEC = 0.25f;

	// Token: 0x04001333 RID: 4915
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04001334 RID: 4916
	public EPIJJNOIKEK JDPBPOKJFQK;
}
