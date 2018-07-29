using System;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200027D RID: 637
public class LNPEDCCCPPN : MonoBehaviour
{
	// Token: 0x060057BD RID: 22461 RVA: 0x002CF0A4 File Offset: 0x002CD2A4
	public void HILGGGLCGJB()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(214f, 1820f, 645f, 1986f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(640f, 555f, 656f, 1534f);
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(1299f, 475f, 330f, 231f);
		this.DGOOHFGLFMI.GINPFQOBGBO = new Rect(421f, 1798f, 1896f, 1221f);
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("leechseed", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("A", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Rainy", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("last online ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057BE RID: 22462 RVA: 0x002CF1C8 File Offset: 0x002CD3C8
	private void QINBLQBMGGI()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.BDPEQNCNPJO();
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = this.LDCIFEQGFQQ.OOGJHJDFEFJ();
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(this.DGOOHFGLFMI.GINPFQOBGBO);
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(227f, dnfenpqlicq.IBQPCCDGLEC, 269f, 1927f);
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "move";
		}
		else
		{
			text = " is tightening its focus!\r\n";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.Hat)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(587f, 1176f, 1641f, 410f);
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("[/itm]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.QOQONHOOLNE.KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("d", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)8)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("Trade Error" + text + "Hydration" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("The Pokémon's type becomes the type of the move used on it." + text + "[" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
				string[] array = new string[5];
				array[0] = "Fly Mount";
				array[0] = text;
				array[8] = "limitFPS";
				array[1] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[6] = "'";
				array[1] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.MOGQNGEPCEO();
			string[] array2 = new string[3];
			array2[0] = "'s HP!\r\n";
			array2[1] = text;
			array2[8] = "other";
			array2[0] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[6] = "Leaf Guard";
			array2[0] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 1;
		}
		dnfenpqlicq.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2]);
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Boxes Owned: "))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("HidePanel");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("general"))
		{
			if (this.BBKKHIDMQIQ != SkinType.Hat && this.BBKKHIDMQIQ != (SkinType)6 && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("English") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "fire") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Sweet Veil"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
				dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("DirX");
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057BF RID: 22463 RVA: 0x002CF71C File Offset: 0x002CD91C
	private void OnClick()
	{
		DNFENPQLICQ qoqonhoolne = DNFENPQLICQ.QOQONHOOLNE;
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		qoqonhoolne.JQFHCCPHMNO = this.DBPKNCDGGEP;
		qoqonhoolne.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		qoqonhoolne.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		qoqonhoolne.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		qoqonhoolne.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		qoqonhoolne.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.GINPFQOBGBO;
		qoqonhoolne.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		qoqonhoolne.KNPPMKBOGDL.GINPFQOBGBO = this.KNPPMKBOGDL.GINPFQOBGBO;
		qoqonhoolne.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		qoqonhoolne.DGOOHFGLFMI.GINPFQOBGBO = this.DGOOHFGLFMI.GINPFQOBGBO;
		qoqonhoolne.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, qoqonhoolne.IBQPCCDGLEC, 0.25f, 0.25f);
		qoqonhoolne.LINHMLKDFMN.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO;
		qoqonhoolne.PKBPIHPBFLG.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO;
		qoqonhoolne.KNPPMKBOGDL.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO;
		qoqonhoolne.DGOOHFGLFMI.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO;
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
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.Hat)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Fly)
		{
			qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0f, 0f, 1f, 1f);
			qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.QOQONHOOLNE.HMOOOQOPPJO(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hair" + text + "/01_" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hair" + text + "/03_" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Hair",
					text,
					"/",
					ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
					"_",
					this.HODQHNIKPDM
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
			{
				"Player/Hair",
				text,
				"/",
				ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL(),
				"_",
				this.HODQHNIKPDM
			}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		qoqonhoolne.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.QOQONHOOLNE.OFGHDGJBDOL[num2];
		if (qoqonhoolne.KIMLCNBIMMG != null)
		{
			qoqonhoolne.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			qoqonhoolne.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		qoqonhoolne.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Owned"))
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
			qoqonhoolne.PMLQJPCKCOF.PIDLOFMIEFQ = "Equip";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Equipped"))
		{
			if (this.BBKKHIDMQIQ != SkinType.Mount && this.BBKKHIDMQIQ != SkinType.Surf && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("None") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Default") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Bicycle"))
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
				qoqonhoolne.PMLQJPCKCOF.PIDLOFMIEFQ = "Unequip";
			}
			else
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		qoqonhoolne.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057C0 RID: 22464 RVA: 0x002CFC70 File Offset: 0x002CDE70
	public void LHOOQEOBDJK()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1962f, 225f, 499f, 5f);
		this.PKBPIHPBFLG.GGLBJMEKGQL(new Rect(665f, 610f, 1787f, 1934f));
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(898f, 298f, 1670f, 1473f));
		this.DGOOHFGLFMI.GGLBJMEKGQL(new Rect(716f, 1918f, 1226f, 1546f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("The rainbow on ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("General", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("Enabled", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("'s torment wore off!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057C1 RID: 22465 RVA: 0x002CFD94 File Offset: 0x002CDF94
	public void FMJPBOEFEQB()
	{
		this.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(1602f, 1202f, 345f, 34f));
		this.PKBPIHPBFLG.IBQDCLQMGLG(new Rect(1564f, 864f, 1064f, 548f));
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(1305f, 578f, 1630f, 1751f);
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(438f, 1763f, 658f, 1543f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD(" levitated with electromagnetism!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("Player/Hair", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("wishiwashischool", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("Powers up each Pokémon's Dark-type moves.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057C2 RID: 22466 RVA: 0x000227EF File Offset: 0x000209EF
	public void JOLFPPDQBQF()
	{
		this.HKLIDELHEJB();
	}

	// Token: 0x060057C3 RID: 22467 RVA: 0x002CFEB8 File Offset: 0x002CE0B8
	public void EMPDNCICEBL()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1421f, 1823f, 189f, 1550f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(1292f, 1053f, 214f, 708f);
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(273f, 1779f, 8f, 1641f));
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(934f, 87f, 888f, 1531f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Tilesets/Materials/1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("Battle", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Aargh! Almost had it!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("lunardance", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(true);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057C4 RID: 22468 RVA: 0x002CFFDC File Offset: 0x002CE1DC
	private void JEKICNJPOHH()
	{
		DNFENPQLICQ qoqonhoolne = DNFENPQLICQ.QOQONHOOLNE;
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		qoqonhoolne.JQFHCCPHMNO = this.DBPKNCDGGEP;
		qoqonhoolne.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		qoqonhoolne.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		qoqonhoolne.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		qoqonhoolne.LDCIFEQGFQQ.IBQDCLQMGLG(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		qoqonhoolne.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.GINPFQOBGBO;
		qoqonhoolne.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		qoqonhoolne.KNPPMKBOGDL.GINPFQOBGBO = this.KNPPMKBOGDL.OOGJHJDFEFJ();
		qoqonhoolne.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		qoqonhoolne.DGOOHFGLFMI.GGLBJMEKGQL(this.DGOOHFGLFMI.OOGJHJDFEFJ());
		qoqonhoolne.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1512f, qoqonhoolne.IBQPCCDGLEC, 870f, 493f);
		qoqonhoolne.LINHMLKDFMN.GGLBJMEKGQL(qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO);
		qoqonhoolne.PKBPIHPBFLG.GGLBJMEKGQL(qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.KNPPMKBOGDL.GGLBJMEKGQL(qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.DGOOHFGLFMI.GGLBJMEKGQL(qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO);
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "/03_1";
		}
		else
		{
			text = "WATER_EDGEBLEND_ON";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == (SkinType)7)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Surf)
		{
			qoqonhoolne.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(225f, 1208f, 1941f, 863f));
			qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("BuffIcon_Teleport", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else if (num >= 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.BEKHPOHIPDE().KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("Player/Body", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP(" traced " + text + " stronger against special moves!\r\n" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP(".png" + text + "Zen" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = qoqonhoolne.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
				string[] array = new string[7];
				array[1] = "Unable to add '";
				array[1] = text;
				array[3] = "Chat Box - PMChat";
				array[7] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[6] = "Explode";
				array[1] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = qoqonhoolne.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.BEKHPOHIPDE();
			string[] array2 = new string[8];
			array2[0] = "Aroma Veil";
			array2[1] = text;
			array2[0] = "]";
			array2[5] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[6] = "d";
			array2[0] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		qoqonhoolne.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2]);
		if (qoqonhoolne.KIMLCNBIMMG != null)
		{
			qoqonhoolne.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			qoqonhoolne.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		qoqonhoolne.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("[-] was removed!\r\n"))
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
			qoqonhoolne.PMLQJPCKCOF.PIDLOFMIEFQ = "Enabled";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Score: "))
		{
			if (this.BBKKHIDMQIQ != SkinType.Surf && this.BBKKHIDMQIQ != SkinType.Clothe && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("RenderType") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "#,##0") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Rainbow Badge"))
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(true);
				qoqonhoolne.PMLQJPCKCOF.LKPOBCBOFIC("par");
			}
			else
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(true);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
		}
		qoqonhoolne.DQPFLILJDEM.SetActive(false);
	}

	// Token: 0x060057C5 RID: 22469 RVA: 0x002D0530 File Offset: 0x002CE730
	public void KMGEHOLBLKI()
	{
		this.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(457f, 1444f, 1548f, 565f));
		this.PKBPIHPBFLG.IBQDCLQMGLG(new Rect(1402f, 166f, 353f, 1266f));
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(284f, 921f, 1780f, 278f));
		this.DGOOHFGLFMI.GGLBJMEKGQL(new Rect(1138f, 1675f, 491f, 271f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("Corrupt preference file for ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("Timer Ball", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("_MaxCoC", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI(" specified", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057C6 RID: 22470 RVA: 0x002D0654 File Offset: 0x002CE854
	private void EKLNQHLPKLN()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.GINPFQOBGBO;
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GINPFQOBGBO = this.KNPPMKBOGDL.OOGJHJDFEFJ();
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(this.DGOOHFGLFMI.GINPFQOBGBO);
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(218f, dnfenpqlicq.IBQPCCDGLEC, 1478f, 961f);
		dnfenpqlicq.LINHMLKDFMN.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ();
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Chance for same Nature";
		}
		else
		{
			text = "itemamount";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			num = this.GMCQFIGGJKE - 0;
		}
		if (this.BBKKHIDMQIQ == (SkinType)7)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1828f, 272f, 991f, 570f);
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("VFMDepthSunCamera", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.BEKHPOHIPDE().KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Button", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("steelworker" + text + "Run_White" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("p1" + text + "wrap" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
				string[] array = new string[7];
				array[1] = "Mouse ScrollWheel";
				array[0] = text;
				array[0] = "normal";
				array[7] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[7] = "Trade Error";
				array[1] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.MOGQNGEPCEO();
			string[] array2 = new string[2];
			array2[0] = "CombinersArgsColorOp1";
			array2[0] = text;
			array2[3] = "Poison spikes were scattered on the ground all around ";
			array2[7] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[1] = " was badly poisoned";
			array2[7] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.GGBPGMMCGLI().OFGHDGJBDOL[num2];
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("["))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("Assets/AssetBundles/MapAssets/ModelPrefabs/");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("-prepare"))
		{
			if (this.BBKKHIDMQIQ != (SkinType)7 && this.BBKKHIDMQIQ != SkinType.None && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("[-]!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "0_") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Inner Focus"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
				dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC(" (TextureClip)");
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057C7 RID: 22471 RVA: 0x002D0BA8 File Offset: 0x002CEDA8
	private void BIHKFCFCFGP()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = this.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(this.DGOOHFGLFMI.OOGJHJDFEFJ());
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1867f, dnfenpqlicq.IBQPCCDGLEC, 387f, 982f));
		dnfenpqlicq.LINHMLKDFMN.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_ClipSharpness";
		}
		else
		{
			text = "0_";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Surf)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(577f, 992f, 250f, 1203f);
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP(" shared its guard with the target!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.QOQONHOOLNE.KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("blank", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)3)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("psychicsurge" + text + "hail" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("|" + text + "Cap" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
				string[] array = new string[7];
				array[1] = "[PD]";
				array[1] = text;
				array[4] = "M";
				array[3] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[8] = "CacheDefaultColor";
				array[6] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.GGBPGMMCGLI();
			string[] array2 = new string[]
			{
				null,
				"[00EE07]"
			};
			array2[1] = text;
			array2[6] = "lockon";
			array2[0] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[4] = "slowstart";
			array2[1] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.QOQONHOOLNE.OFGHDGJBDOL[num2];
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("frz"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("M5");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("_MainTex"))
		{
			if (this.BBKKHIDMQIQ != SkinType.None && this.BBKKHIDMQIQ != (SkinType)6 && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("ghost") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "]") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Marsh Badge"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
				dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("shelltrap");
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(false);
	}

	// Token: 0x060057C8 RID: 22472 RVA: 0x002D10FC File Offset: 0x002CF2FC
	public void EKIFQMCDLLJ()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
		this.DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x002D1220 File Offset: 0x002CF420
	public void PMLQIICPHND()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(541f, 633f, 31f, 1671f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(455f, 62f, 1441f, 1735f);
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(540f, 632f, 748f, 1080f));
		this.DGOOHFGLFMI.GGLBJMEKGQL(new Rect(1549f, 96f, 1657f, 271f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("unnerve", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("Teleport", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("hugepower", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("_", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x002D1344 File Offset: 0x002CF544
	private void NHDKCIJQGCH()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = this.DGOOHFGLFMI.GINPFQOBGBO;
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1156f, dnfenpqlicq.IBQPCCDGLEC, 571f, 763f));
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "MissingNo.";
		}
		else
		{
			text = "Immediate Mode GUI";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == (SkinType)7)
		{
			num = this.GMCQFIGGJKE - 0;
		}
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1235f, 1960f, 1230f, 749f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("liquidvoice", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.MOGQNGEPCEO().KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("frisk", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" for " + text + "Trace" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Boosts the Pokémon's Speed stat in sunshine." + text + "[-]!\r\n" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
				string[] array = new string[6];
				array[1] = "stench";
				array[1] = text;
				array[2] = "Protects the Pokémon from Defense-lowering effects.";
				array[4] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[3] = "physical";
				array[2] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = qoqonhoolne.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
			string[] array2 = new string[]
			{
				"ChatSettings",
				text,
				null,
				null,
				null,
				null,
				null,
				"slushrush"
			};
			array2[4] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[2] = "Beacon Badge";
			array2[2] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.GGBPGMMCGLI().OFGHDGJBDOL[num2]);
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("snorlax"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "x ";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("QTY: "))
		{
			if (this.BBKKHIDMQIQ != SkinType.Fly && this.BBKKHIDMQIQ != SkinType.Hat && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains(" lost some of its HP!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "After your payment has been verified your Lootboxes will be added to your account.") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == " cut its own HP and put a curse on "))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
				dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "-2";
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x002D1898 File Offset: 0x002CFA98
	public void DGPQBHEQEJH()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1161f, 685f, 1498f, 527f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(1147f, 921f, 251f, 1943f);
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(172f, 1685f, 1711f, 357f);
		this.DGOOHFGLFMI.GINPFQOBGBO = new Rect(274f, 1998f, 747f, 746f);
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("_FogOfWarCenterAdjusted", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("You got away safely!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP(", ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Parent and child each attacks.", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(true);
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x002D19BC File Offset: 0x002CFBBC
	public void CQPDQGHHKCM()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(987f, 1533f, 28f, 86f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(73f, 1304f, 1235f, 466f);
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(759f, 1525f, 30f, 1301f);
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(1819f, 327f, 981f, 409f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("_PrefilterOffs", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("no arguments", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x000227F7 File Offset: 0x000209F7
	public void OIGJECEKIMH()
	{
		this.GGMINIPOKJI();
	}

	// Token: 0x060057CE RID: 22478 RVA: 0x000227FF File Offset: 0x000209FF
	public void GOMEEDPFEOC()
	{
		this.EKLNQHLPKLN();
	}

	// Token: 0x060057CF RID: 22479 RVA: 0x002D1AE0 File Offset: 0x002CFCE0
	private void GGMINIPOKJI()
	{
		DNFENPQLICQ qoqonhoolne = DNFENPQLICQ.QOQONHOOLNE;
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		qoqonhoolne.JQFHCCPHMNO = this.DBPKNCDGGEP;
		qoqonhoolne.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		qoqonhoolne.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		qoqonhoolne.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		qoqonhoolne.LDCIFEQGFQQ.GGLBJMEKGQL(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		qoqonhoolne.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.OOGJHJDFEFJ();
		qoqonhoolne.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		qoqonhoolne.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.GINPFQOBGBO);
		qoqonhoolne.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		qoqonhoolne.DGOOHFGLFMI.GGLBJMEKGQL(this.DGOOHFGLFMI.GINPFQOBGBO);
		qoqonhoolne.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		qoqonhoolne.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(465f, qoqonhoolne.IBQPCCDGLEC, 828f, 225f));
		qoqonhoolne.LINHMLKDFMN.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ();
		qoqonhoolne.PKBPIHPBFLG.GGLBJMEKGQL(qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO);
		qoqonhoolne.KNPPMKBOGDL.IBQDCLQMGLG(qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO);
		qoqonhoolne.DGOOHFGLFMI.IBQDCLQMGLG(qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ());
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "!\r\n";
		}
		else
		{
			text = "physical";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Hat)
		{
			qoqonhoolne.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(1099f, 259f, 1444f, 347f));
			qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("-primal", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.GGBPGMMCGLI().BFPKOMNHGBE(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("[-]'s [ff6600]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("BuffIcon_MaxRepel" + text + "[b]" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("][#" + text + "wishiwashischool" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = qoqonhoolne.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
				string[] array = new string[]
				{
					null,
					"_1"
				};
				array[1] = text;
				array[0] = "klutz";
				array[4] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[4] = "l";
				array[6] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = qoqonhoolne.LINHMLKDFMN;
			GFHGEJNHLFQ qoqonhoolne2 = GFHGEJNHLFQ.QOQONHOOLNE;
			string[] array2 = new string[8];
			array2[1] = "Invalid Username or Password..";
			array2[0] = text;
			array2[7] = "3d";
			array2[0] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[6] = "[MEGA]";
			array2[7] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = qoqonhoolne2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		qoqonhoolne.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2]);
		if (qoqonhoolne.KIMLCNBIMMG != null)
		{
			qoqonhoolne.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			qoqonhoolne.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		qoqonhoolne.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("normal"))
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(false);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
			qoqonhoolne.PMLQJPCKCOF.PIDLOFMIEFQ = "???";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Dolly zooming is only supported on perspective cameras"))
		{
			if (this.BBKKHIDMQIQ != SkinType.None && this.BBKKHIDMQIQ != SkinType.Hat && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("It's not very effective") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == " transformed!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Steals an item from an attacker that made direct contact."))
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(true);
				qoqonhoolne.PMLQJPCKCOF.LKPOBCBOFIC("physical");
			}
			else
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		qoqonhoolne.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057D0 RID: 22480 RVA: 0x002D2034 File Offset: 0x002D0234
	public void PLIQINILCJF()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(407f, 1914f, 186f, 903f);
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(698f, 660f, 1534f, 1308f);
		this.KNPPMKBOGDL.IBQDCLQMGLG(new Rect(1069f, 1680f, 1885f, 110f));
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(1672f, 699f, 728f, 1627f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Rotate", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("Player/Mounts/", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("d", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("[FF8F00]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x002D2158 File Offset: 0x002D0358
	private void ELMMBCJCEOB()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		dnfenpqlicq.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = this.LDCIFEQGFQQ.OOGJHJDFEFJ();
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(this.DGOOHFGLFMI.OOGJHJDFEFJ());
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(62f, dnfenpqlicq.IBQPCCDGLEC, 417f, 506f);
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Guild";
		}
		else
		{
			text = "--offline";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.Clothe)
		{
			num = this.GMCQFIGGJKE - 0;
		}
		if (this.BBKKHIDMQIQ == SkinType.Fly)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1530f, 1882f, 1316f, 949f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("_ClipRange1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.GGBPGMMCGLI().BFPKOMNHGBE(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("Assets/AssetBundles/MapAssets/Models/Building_PokemonCentre/Materials/chip_mado.mat", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Sticky Hold" + text + "Auto Decline" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Ultra Ball" + text + "Encounter Rate Decreased" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
				string[] array = new string[5];
				array[0] = "trickroom";
				array[0] = text;
				array[7] = " cured its poison!\r\n";
				array[8] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[3] = "/";
				array[7] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.BEKHPOHIPDE();
			string[] array2 = new string[6];
			array2[0] = "Unlit/Transparent Colored";
			array2[0] = text;
			array2[4] = "/";
			array2[1] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[8] = "NT";
			array2[1] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.QOQONHOOLNE.OFGHDGJBDOL[num2];
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Reduces the amount of damage the Pokémon takes when its HP is full."))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("WATER_VERTEX_DISPLACEMENT_ON");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Player/Clothe"))
		{
			if (this.BBKKHIDMQIQ != SkinType.Surf && this.BBKKHIDMQIQ != SkinType.Surf && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("~") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "East") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == " intends to flip up a mat and block incoming attacks!\r\n"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
				dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "Materials/DFODesktop";
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x002D26AC File Offset: 0x002D08AC
	private void MQJBDIJQQEP()
	{
		DNFENPQLICQ qoqonhoolne = DNFENPQLICQ.QOQONHOOLNE;
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
		qoqonhoolne.JQFHCCPHMNO = this.DBPKNCDGGEP;
		qoqonhoolne.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		qoqonhoolne.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		qoqonhoolne.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		qoqonhoolne.LDCIFEQGFQQ.IBQDCLQMGLG(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		qoqonhoolne.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.GINPFQOBGBO);
		qoqonhoolne.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		qoqonhoolne.KNPPMKBOGDL.IBQDCLQMGLG(this.KNPPMKBOGDL.OOGJHJDFEFJ());
		qoqonhoolne.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		qoqonhoolne.DGOOHFGLFMI.GINPFQOBGBO = this.DGOOHFGLFMI.GINPFQOBGBO;
		qoqonhoolne.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(322f, qoqonhoolne.IBQPCCDGLEC, 1913f, 1994f);
		qoqonhoolne.LINHMLKDFMN.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO;
		qoqonhoolne.PKBPIHPBFLG.IBQDCLQMGLG(qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ());
		qoqonhoolne.KNPPMKBOGDL.GINPFQOBGBO = qoqonhoolne.LDCIFEQGFQQ.OOGJHJDFEFJ();
		qoqonhoolne.DGOOHFGLFMI.IBQDCLQMGLG(qoqonhoolne.LDCIFEQGFQQ.GINPFQOBGBO);
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "TabSettings";
		}
		else
		{
			text = "Move Learning";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.Hat)
		{
			num = this.GMCQFIGGJKE - 0;
		}
		if (this.BBKKHIDMQIQ == SkinType.Fly)
		{
			qoqonhoolne.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1952f, 75f, 1985f, 1152f));
			qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("You are unable to use ", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.QOQONHOOLNE.HMOOOQOPPJO(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("darmanitan", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Short)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("0" + text + "CombinersColorPassThrough" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					qoqonhoolne.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("Desolate Land" + text + "refrigerate" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = qoqonhoolne.LINHMLKDFMN;
				GFHGEJNHLFQ qoqonhoolne2 = GFHGEJNHLFQ.QOQONHOOLNE;
				string[] array = new string[4];
				array[0] = "Btn_TabHighlighted_Normal";
				array[0] = text;
				array[6] = "#,##0";
				array[2] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[1] = "perish1";
				array[7] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = qoqonhoolne2.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = qoqonhoolne.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
			string[] array2 = new string[3];
			array2[0] = "\n";
			array2[1] = text;
			array2[4] = "_Start";
			array2[0] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[1] = "anticipation";
			array2[5] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		qoqonhoolne.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.QOQONHOOLNE.OFGHDGJBDOL[num2]);
		if (qoqonhoolne.KIMLCNBIMMG != null)
		{
			qoqonhoolne.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			qoqonhoolne.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		qoqonhoolne.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("forecast"))
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(true);
			qoqonhoolne.PMLQJPCKCOF.LKPOBCBOFIC("'s [ffff00]");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains(" is locked in a nightmare!\r\n"))
		{
			if (this.BBKKHIDMQIQ != (SkinType)6 && this.BBKKHIDMQIQ != SkinType.Mount && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Materials/DFGSimple") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "mummy") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "BuffIcon_EncounterRateDecreased"))
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(true);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
				qoqonhoolne.PMLQJPCKCOF.LKPOBCBOFIC("You can not afford to buy this item.");
			}
			else
			{
				qoqonhoolne.IHHPBBJKKGP.SetActive(false);
				qoqonhoolne.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			qoqonhoolne.IHHPBBJKKGP.SetActive(true);
			qoqonhoolne.BKOHNOHJIEI.SetActive(false);
		}
		qoqonhoolne.DQPFLILJDEM.SetActive(false);
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x002D2C00 File Offset: 0x002D0E00
	public void LLIIEJGBKMG()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1117f, 498f, 764f, 1509f);
		this.PKBPIHPBFLG.IBQDCLQMGLG(new Rect(563f, 793f, 1579f, 1803f));
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(885f, 1109f, 1899f, 1380f));
		this.DGOOHFGLFMI.GGLBJMEKGQL(new Rect(401f, 360f, 430f, 1059f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("FOG_SCATTERING_ON", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("The Pokémon cowardly switches out when its HP becomes half or less.", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Assets/AssetBundles/MapAssets/Models/Materials/c102_09_mado.mat", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("Female", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.OBHJIDJOFFO.SetActive(true);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x002D2D24 File Offset: 0x002D0F24
	public void QJLBPOBEPOQ()
	{
		this.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(56f, 1959f, 1202f, 1040f);
		this.PKBPIHPBFLG.IBQDCLQMGLG(new Rect(425f, 1649f, 56f, 903f));
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(59f, 764f, 1112f, 1498f);
		this.DGOOHFGLFMI.GINPFQOBGBO = new Rect(265f, 775f, 996f, 641f);
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("thief", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("/", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("sweetveil", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("F8", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(true);
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x002D2E48 File Offset: 0x002D1048
	private void HKLIDELHEJB()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = this.LDCIFEQGFQQ.OOGJHJDFEFJ();
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.OOGJHJDFEFJ();
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = this.DGOOHFGLFMI.GINPFQOBGBO;
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(541f, dnfenpqlicq.IBQPCCDGLEC, 870f, 654f));
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ();
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "Chances of finding a wild Pokémon holding an item increased.\nTriggers: [2ecc71]Compound Eyes[-]";
		}
		else
		{
			text = "[00FF00]";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == (SkinType)6)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(314f, 1377f, 1012f, 157f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.GGBPGMMCGLI().BFPKOMNHGBE(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("!", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)8)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("clamp" + text + "naturepower" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("[00]" + text + "Powers up moves of the same type as the Pokémon." + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
				string[] array = new string[1];
				array[0] = "move: ";
				array[1] = text;
				array[3] = "PrimitiveInnerRight";
				array[5] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[0] = " flung its [ffff00]";
				array[8] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.GGBPGMMCGLI();
			string[] array2 = new string[3];
			array2[1] = "/kick ";
			array2[0] = text;
			array2[1] = "/force down";
			array2[0] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[5] = "Boosts the Defense stat when hit by an attack.";
			array2[7] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 1;
		}
		dnfenpqlicq.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2];
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains(" waits for a target to make a move!\r\n"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "d";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("The specified buffer must be at least "))
		{
			if (this.BBKKHIDMQIQ != SkinType.Surf && this.BBKKHIDMQIQ != (SkinType)7 && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains(" avoided the attack!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Stench") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "'s "))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
				dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "Fitter Line";
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x002D339C File Offset: 0x002D159C
	public void PCDQLKMQEDN()
	{
		this.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1331f, 1386f, 622f, 110f));
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(805f, 422f, 1757f, 1264f);
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(724f, 1213f, 606f, 1474f);
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(580f, 821f, 603f, 609f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("[orange]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP(" BP", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("Numeric Boundaries", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP(" floats in the air with its Air Balloon!\r\n", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.OBHJIDJOFFO.SetActive(true);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057D7 RID: 22487 RVA: 0x002D34C0 File Offset: 0x002D16C0
	private void JMLMNQIHQBJ()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.BDPEQNCNPJO();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.GINPFQOBGBO = this.PKBPIHPBFLG.GINPFQOBGBO;
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GINPFQOBGBO = this.KNPPMKBOGDL.GINPFQOBGBO;
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(this.DGOOHFGLFMI.OOGJHJDFEFJ());
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(1292f, dnfenpqlicq.IBQPCCDGLEC, 722f, 1318f);
		dnfenpqlicq.LINHMLKDFMN.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ();
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "bloom";
		}
		else
		{
			text = "TransitionsFX not initialized yet. You're probably calling TransitionEnter/Exit from an Awake method. Please call it from a Start method instead.";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.None)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == (SkinType)8)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(857f, 1956f, 1868f, 890f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("i", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.MOGQNGEPCEO().HMOOOQOPPJO(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("Pokemon View", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("healblock" + text + "Move To Player" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("/mute " + text + "Assets/AssetBundles/MapAssets2/Models/Materials/c102_mado.mat" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
				string[] array = new string[5];
				array[1] = "deltastream";
				array[1] = text;
				array[7] = "dazzling";
				array[2] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[1] = "Localization";
				array[2] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.GGBPGMMCGLI();
			string[] array2 = new string[0];
			array2[0] = "u";
			array2[0] = text;
			array2[0] = "debug";
			array2[7] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[5] = "[-] ";
			array2[3] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 1;
		}
		dnfenpqlicq.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2]);
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains(" became the center of attention!\r\n"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "Map";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("RS"))
		{
			if (this.BBKKHIDMQIQ != SkinType.Surf && this.BBKKHIDMQIQ != SkinType.Mount && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Female") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "berry_5") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "clyde"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
				dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "When used inside of a cave or certain buildings, you will be transported to the last entrance you used.\n\n[2ecc71]Left Click to use this.[-]";
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(false);
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x002D3A14 File Offset: 0x002D1C14
	private void KKELLJLGPCO()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.JJCONJJNDQN();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		dnfenpqlicq.PECEMJFDJHB.PIDLOFMIEFQ = this.PLCBFLQBCQN.PIDLOFMIEFQ;
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(this.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GGLBJMEKGQL(this.KNPPMKBOGDL.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(this.DGOOHFGLFMI.GINPFQOBGBO);
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1066f, dnfenpqlicq.IBQPCCDGLEC, 52f, 1772f));
		dnfenpqlicq.LINHMLKDFMN.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "qdTrack";
		}
		else
		{
			text = "user: ";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == (SkinType)6)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Surf)
		{
			dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(401f, 112f, 1784f, 875f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("castformsnowy", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 0)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.MOGQNGEPCEO().HMOOOQOPPJO(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Blade", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)8)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("00CCFF" + text + "UNITY_COLORSPACE_GAMMA" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("]" + text + "The specified Port " + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
				string[] array = new string[5];
				array[1] = "Music";
				array[0] = text;
				array[4] = "_FogDownsampled";
				array[5] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[4] = "Small/";
				array[1] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.NMPCLCEQJMP(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.MOGQNGEPCEO();
			string[] array2 = new string[1];
			array2[0] = "Map";
			array2[1] = text;
			array2[2] = "Repeat Ball";
			array2[1] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[5] = "The Pokémon cowardly switches out when its HP becomes half or less.";
			array2[3] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.GOKLDOEGJHI(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.QOQONHOOLNE.OFGHDGJBDOL[num2]);
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Hidden/Post FX/Ambient Occlusion"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "_FogAlpha";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains(" is radiating a dark aura!\r\n"))
		{
			if (this.BBKKHIDMQIQ != SkinType.Fly && this.BBKKHIDMQIQ != (SkinType)8 && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Cherish Ball") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "Shift"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
				dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "[u][33CCFF]";
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x002D3F68 File Offset: 0x002D2168
	private void PBEBBBJCOMC()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.BDPEQNCNPJO();
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.LKPOBCBOFIC(this.NKKMJICKKLB.PIDLOFMIEFQ);
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(this.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.GINPFQOBGBO);
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(this.KNPPMKBOGDL.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.IBQDCLQMGLG(this.DGOOHFGLFMI.OOGJHJDFEFJ());
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(1326f, dnfenpqlicq.IBQPCCDGLEC, 432f, 456f));
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.PKBPIHPBFLG.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(dnfenpqlicq.LDCIFEQGFQQ.OOGJHJDFEFJ());
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "[00DD00]Equipped";
		}
		else
		{
			text = "wideguard";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == SkinType.Hat)
		{
			num = this.GMCQFIGGJKE - 1;
		}
		if (this.BBKKHIDMQIQ == SkinType.Mount)
		{
			dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(323f, 1174f, 1294f, 1503f);
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP(" days", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else if (num >= 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.BEKHPOHIPDE().HMOOOQOPPJO(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("\r\nPP ", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
			else if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Default)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("]" + text + "-noJoystick" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("VolumetricFogAndMist/Chaos Lerp" + text + "1_" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
				string[] array = new string[4];
				array[1] = "[SHINY]";
				array[1] = text;
				array[1] = "{0:0.0} ms ({1:0.} fps)";
				array[5] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[7] = "_ExposureCompensation";
				array[2] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
			string[] array2 = new string[5];
			array2[1] = "/";
			array2[1] = text;
			array2[2] = "FocusPoint";
			array2[1] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[3] = ",1+";
			array2[4] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = qoqonhoolne.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 0;
		}
		dnfenpqlicq.LINHMLKDFMN.NONQDHBCIIN(GFHGEJNHLFQ.GGBPGMMCGLI().OFGHDGJBDOL[num2]);
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = false;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("#,##0"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			dnfenpqlicq.PMLQJPCKCOF.PIDLOFMIEFQ = "The battlers shared their pain!\r\n";
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains(" was wrapped by "))
		{
			if (this.BBKKHIDMQIQ != SkinType.Fly && this.BBKKHIDMQIQ != (SkinType)7 && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains(" days") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "soulheart") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "/"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
				dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("/kick ");
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(false);
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x002D44BC File Offset: 0x002D26BC
	public void CNEKFODMQFJ()
	{
		this.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(229f, 63f, 8f, 1571f));
		this.PKBPIHPBFLG.GGLBJMEKGQL(new Rect(705f, 390f, 496f, 76f));
		this.KNPPMKBOGDL.GINPFQOBGBO = new Rect(894f, 1617f, 343f, 1463f);
		this.DGOOHFGLFMI.IBQDCLQMGLG(new Rect(1086f, 1462f, 1691f, 1226f));
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("System", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("[green]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("The Pokémon can't use a move the following turn if it uses one.", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("[00EE07]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = false;
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x00022807 File Offset: 0x00020A07
	public void PGDHENNHBDG()
	{
		this.OnClick();
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x002D45E0 File Offset: 0x002D27E0
	private void NNLDKMENINQ()
	{
		DNFENPQLICQ dnfenpqlicq = DNFENPQLICQ.BDPEQNCNPJO();
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
		dnfenpqlicq.JQFHCCPHMNO = this.DBPKNCDGGEP;
		dnfenpqlicq.HQODFDDPQIN.PIDLOFMIEFQ = this.NKKMJICKKLB.PIDLOFMIEFQ;
		dnfenpqlicq.PECEMJFDJHB.LKPOBCBOFIC(this.PLCBFLQBCQN.PIDLOFMIEFQ);
		dnfenpqlicq.LDCIFEQGFQQ.GOIHJQNMMJD = this.LDCIFEQGFQQ.GOIHJQNMMJD;
		dnfenpqlicq.LDCIFEQGFQQ.GGLBJMEKGQL(this.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.PKBPIHPBFLG.GOIHJQNMMJD = this.PKBPIHPBFLG.GOIHJQNMMJD;
		dnfenpqlicq.PKBPIHPBFLG.IBQDCLQMGLG(this.PKBPIHPBFLG.OOGJHJDFEFJ());
		dnfenpqlicq.KNPPMKBOGDL.GOIHJQNMMJD = this.KNPPMKBOGDL.GOIHJQNMMJD;
		dnfenpqlicq.KNPPMKBOGDL.GINPFQOBGBO = this.KNPPMKBOGDL.GINPFQOBGBO;
		dnfenpqlicq.DGOOHFGLFMI.GOIHJQNMMJD = this.DGOOHFGLFMI.GOIHJQNMMJD;
		dnfenpqlicq.DGOOHFGLFMI.GGLBJMEKGQL(this.DGOOHFGLFMI.GINPFQOBGBO);
		dnfenpqlicq.PIKDJCDDPPC = this.BBKKHIDMQIQ;
		dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO = new Rect(704f, dnfenpqlicq.IBQPCCDGLEC, 161f, 850f);
		dnfenpqlicq.LINHMLKDFMN.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.PKBPIHPBFLG.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		dnfenpqlicq.KNPPMKBOGDL.IBQDCLQMGLG(dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO);
		dnfenpqlicq.DGOOHFGLFMI.GINPFQOBGBO = dnfenpqlicq.LDCIFEQGFQQ.GINPFQOBGBO;
		DJOOHHIQGJK ppmjcbonmqj = CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ;
		string text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "[-]!\r\n";
		}
		else
		{
			text = "]#";
		}
		int num = -1;
		if (this.BBKKHIDMQIQ == (SkinType)7)
		{
			num = this.GMCQFIGGJKE - 0;
		}
		if (this.BBKKHIDMQIQ == SkinType.Clothe)
		{
			dnfenpqlicq.LDCIFEQGFQQ.IBQDCLQMGLG(new Rect(1086f, 1529f, 1582f, 1164f));
			dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("]", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else if (num >= 1)
		{
			GFHGEJNHLFQ.LPNNHBCLDGK lpnnhbcldgk = GFHGEJNHLFQ.GGBPGMMCGLI().KBLFDMNICCJ(num, ppmjcbonmqj.HDCKEHHFCDN.Gender, ppmjcbonmqj.HDCKEHHFCDN.Hair);
			if (lpnnhbcldgk == GFHGEJNHLFQ.LPNNHBCLDGK.Hide)
			{
				dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("magiccoat", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (lpnnhbcldgk == (GFHGEJNHLFQ.LPNNHBCLDGK)4)
			{
				if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("[00EE00]" + text + "-" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
				else
				{
					dnfenpqlicq.LINHMLKDFMN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("[^0-9.-]" + text + "High" + this.HODQHNIKPDM, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				}
			}
			else
			{
				ENFMCDNLEQQ linhmlkdfmn = dnfenpqlicq.LINHMLKDFMN;
				GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
				string[] array = new string[8];
				array[1] = "[/SUB]";
				array[1] = text;
				array[2] = "SP";
				array[7] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
				array[7] = "disable";
				array[4] = this.HODQHNIKPDM;
				linhmlkdfmn.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(string.Concat(array), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			}
		}
		else
		{
			ENFMCDNLEQQ linhmlkdfmn2 = dnfenpqlicq.LINHMLKDFMN;
			GFHGEJNHLFQ gfhgejnhlfq2 = GFHGEJNHLFQ.MOGQNGEPCEO();
			string[] array2 = new string[1];
			array2[1] = "confusion";
			array2[0] = text;
			array2[8] = "HidePanel";
			array2[8] = ppmjcbonmqj.HDCKEHHFCDN.Hair.QQKICQQBIJL();
			array2[2] = "'s [ffff00]";
			array2[2] = this.HODQHNIKPDM;
			linhmlkdfmn2.GOIHJQNMMJD = gfhgejnhlfq2.CPFJEOGMHOD(string.Concat(array2), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		int num2 = ppmjcbonmqj.HDCKEHHFCDN.HairColor;
		if (num2 == -1)
		{
			num2 = 1;
		}
		dnfenpqlicq.LINHMLKDFMN.CEGFBBHMKOE = GFHGEJNHLFQ.MOGQNGEPCEO().OFGHDGJBDOL[num2];
		if (dnfenpqlicq.KIMLCNBIMMG != null)
		{
			dnfenpqlicq.KIMLCNBIMMG.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			dnfenpqlicq.KIMLCNBIMMG.GetComponent<BoxCollider>().enabled = true;
		}
		dnfenpqlicq.KIMLCNBIMMG = this.BLLHQPQBHBB;
		if (this.PLCBFLQBCQN.PIDLOFMIEFQ == string.Empty)
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("dd/MM/yyyy"))
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("_Histogram");
		}
		else if (this.PLCBFLQBCQN.PIDLOFMIEFQ.Contains("Pokémon Caught:"))
		{
			if (this.BBKKHIDMQIQ != (SkinType)7 && this.BBKKHIDMQIQ != SkinType.Surf && !this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Target Root object cannot be the same object that has Envelop Content. Make it a sibling instead.") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "!\r\n") && !(this.NKKMJICKKLB.PIDLOFMIEFQ == "celebrate"))
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(true);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
				dnfenpqlicq.PMLQJPCKCOF.LKPOBCBOFIC("Net Ball");
			}
			else
			{
				dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
				dnfenpqlicq.BKOHNOHJIEI.SetActive(true);
			}
		}
		else
		{
			dnfenpqlicq.IHHPBBJKKGP.SetActive(false);
			dnfenpqlicq.BKOHNOHJIEI.SetActive(false);
		}
		dnfenpqlicq.DQPFLILJDEM.SetActive(true);
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x002D4B34 File Offset: 0x002D2D34
	public void HLDDDPPPPDK()
	{
		this.LDCIFEQGFQQ.GGLBJMEKGQL(new Rect(1841f, 194f, 1785f, 985f));
		this.PKBPIHPBFLG.GINPFQOBGBO = new Rect(1103f, 1857f, 1331f, 687f);
		this.KNPPMKBOGDL.GGLBJMEKGQL(new Rect(108f, 1110f, 1331f, 1571f));
		this.DGOOHFGLFMI.GINPFQOBGBO = new Rect(191f, 1890f, 1200f, 545f);
		this.LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("~", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("OnScroll", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("VolumetricFogAndMist/VolumetricFog", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("_DestortionX", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.OBHJIDJOFFO.SetActive(false);
		this.BLLHQPQBHBB.GGBPLMICFHN = true;
	}

	// Token: 0x04001335 RID: 4917
	public GameObject OBHJIDJOFFO;

	// Token: 0x04001336 RID: 4918
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x04001337 RID: 4919
	public BKKHLBCLPJM PLCBFLQBCQN;

	// Token: 0x04001338 RID: 4920
	public JLMPBLMOICG LDCIFEQGFQQ;

	// Token: 0x04001339 RID: 4921
	public JLMPBLMOICG PKBPIHPBFLG;

	// Token: 0x0400133A RID: 4922
	public JLMPBLMOICG KNPPMKBOGDL;

	// Token: 0x0400133B RID: 4923
	public JLMPBLMOICG DGOOHFGLFMI;

	// Token: 0x0400133C RID: 4924
	public CFDMNELIJLO BLLHQPQBHBB;

	// Token: 0x0400133D RID: 4925
	public BoxCollider NDLCLMNEHOI;

	// Token: 0x0400133E RID: 4926
	public SkinType BBKKHIDMQIQ;

	// Token: 0x0400133F RID: 4927
	public int DBPKNCDGGEP;

	// Token: 0x04001340 RID: 4928
	public string HODQHNIKPDM = "1";

	// Token: 0x04001341 RID: 4929
	public int GMCQFIGGJKE;
}
