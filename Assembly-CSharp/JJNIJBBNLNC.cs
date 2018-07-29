using System;
using UnityEngine;

// Token: 0x02000279 RID: 633
public class JJNIJBBNLNC : MonoBehaviour
{
	// Token: 0x06005713 RID: 22291 RVA: 0x002C894C File Offset: 0x002C6B4C
	public void IQMKEHHHQKG(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("'s Money will go over the money cap.".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[0]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[0]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.NDPGCGDLEEQ();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "[pok=" + this.HQNCHPIOPBN.ToString() + " became shrouded in mist!\r\n";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "_" + Convert.ToInt32(array[1]).ToString("_FogData2");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.PINEJNIDONB(item.ItemImage.ToString());
		string text = string.Empty;
		text = "13" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "wonderguard";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Description;
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("sdata") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Rotate")) && text.Contains("MapDownloader"))
		{
			int num = text.IndexOf("UI");
			int num2 = text.IndexOf("The healing wish came true for ");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "HidePanel" + text.Substring(num + -112, num2 - (num + 115)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "'s wish came true!\r\n" + str + str2;
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x00021B6E File Offset: 0x0001FD6E
	private void PQEFNPPCKOH()
	{
		JICJEENBPEO.QOQONHOOLNE.DKGCJCMCNGP(this);
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x002C8B58 File Offset: 0x002C6D58
	public void GKGEFEKKBCM(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("After your payment has been verified your Lootboxes will be added to your account.".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[6]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[6]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.DFNQHDEDDKE();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "´" + this.HQNCHPIOPBN.ToString() + " times!";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "qdTrack" + Convert.ToInt32(array[0]).ToString("-anim");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.PINEJNIDONB(item.MQIHCHFOPGE().ToString());
		string text = string.Empty;
		text = "Take 001" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + "watercompaction";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Raises evasion if the Pokémon is confused.") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("It's not very effective")) && text.Contains("[ff4949]"))
		{
			int num = text.IndexOf("_");
			int num2 = text.IndexOf("Disabled");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "RGBA" + text.Substring(num + -114, num2 - (num + 115)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + " for " + str + str2;
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x002C8D64 File Offset: 0x002C6F64
	public void FDDENOHPGQF(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("!\r\n".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[0]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[1]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.FLFQBGJQBBD();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "FOG_DISTANCE_ON" + this.HQNCHPIOPBN.ToString() + "Stop";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "flash" + Convert.ToInt32(array[1]).ToString("[-]!\r\n");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.DFNQHDEDDKE());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.PINEJNIDONB(item.MQIHCHFOPGE().ToString());
		string text = string.Empty;
		text = "0" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + "\\n";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("/") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("F")) && text.Contains("pixilate"))
		{
			int num = text.IndexOf("]");
			int num2 = text.IndexOf("!");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "Big/" + text.Substring(num + -61, num2 - (num + 8));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "6_" + str + str2);
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x00021B7B File Offset: 0x0001FD7B
	private void ELMMBCJCEOB()
	{
		JICJEENBPEO.QOQONHOOLNE.HMCFGLNOBPM(this);
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x00021B6E File Offset: 0x0001FD6E
	private void OIJDCCBPGHM()
	{
		JICJEENBPEO.QOQONHOOLNE.DKGCJCMCNGP(this);
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x002C8F70 File Offset: 0x002C7170
	public void JMDOHOLHGBN(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("_Grain_Params2".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[3]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[6]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "snatch" + this.HQNCHPIOPBN.ToString() + "/01_";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "[FFC300]" + Convert.ToInt32(array[1]).ToString("[00FF00]You received ");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.JQBDPHILQJO());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.QDMQEBHOENL(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "[00FF00]+" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO() + "bag";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NKDOCPOOIIF();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("\nText: ") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("[fail]")) && text.Contains("[absorb]"))
		{
			int num = text.IndexOf("_FogDistance");
			int num2 = text.IndexOf("_1");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "safeguard" + text.Substring(num + -2, num2 - (num + -22));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "snorlax" + str + str2);
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x002C917C File Offset: 0x002C737C
	public void QFEMQODLJKE(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("Daily Quests".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[8]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[2]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.NDPGCGDLEEQ();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "ground" + this.HQNCHPIOPBN.ToString() + "'s from critical hits!\r\n";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = " hour ago" + Convert.ToInt32(array[0]).ToString("[FF6600]");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.Name;
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.QDMQEBHOENL(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "Rivalry" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "Moxie";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("torment") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Shell Armor")) && text.Contains("The trade with '"))
		{
			int num = text.IndexOf("#,##0");
			int num2 = text.IndexOf("Hidden/");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "ground" + text.Substring(num + 68, num2 - (num + -123)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "HidePanel" + str + str2;
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x00021B88 File Offset: 0x0001FD88
	private void GNIHMKDCMKK()
	{
		JICJEENBPEO.BEKHPOHIPDE().CJMELFQFOCB(this);
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x00021B95 File Offset: 0x0001FD95
	private void KKELLJLGPCO()
	{
		JICJEENBPEO.BEKHPOHIPDE().DKGCJCMCNGP(this);
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x00021BA2 File Offset: 0x0001FDA2
	private void LMLKOFKMKLK()
	{
		JICJEENBPEO.BEKHPOHIPDE().HMCFGLNOBPM(this);
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x002C9388 File Offset: 0x002C7588
	public void DLEDQFJCPDJ(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("hydration".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[1]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[2]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "_DetailScaleY" + this.HQNCHPIOPBN.ToString() + "Oh no! The Pokémon broke free!\r\n";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = " Pokédollars." + Convert.ToInt32(array[1]).ToString(" has no shader setter");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.DFNQHDEDDKE());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.PINEJNIDONB(item.ItemImage.ToString());
		string text = string.Empty;
		text = "SetVolumeBack" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD() + "You used '";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("[00AAFF]Location:[-] ") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains(" hr, ")) && text.Contains("_TransitionTex"))
		{
			int num = text.IndexOf(" cut its own HP and maximized its Attack!\r\n");
			int num2 = text.IndexOf("_History3Weight");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "_HueShift" + text.Substring(num + 29, num2 - (num + -78));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "Player/Hair" + str + str2;
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x002C9594 File Offset: 0x002C7794
	public void DOEGKLDPQKB(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[3]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[1]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.JQBDPHILQJO();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "[/o][-]" + this.HQNCHPIOPBN.ToString() + "[PD]";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = " became the center of attention!\r\n" + Convert.ToInt32(array[0]).ToString("_Blinds");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.JQBDPHILQJO();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.QDMQEBHOENL(item.QCQPPPFPCQH().ToString());
		string text = string.Empty;
		text = ")" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + " fell for the taunt!\r\n";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Guild") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Big/")) && text.Contains("Light Screen made "))
		{
			int num = text.IndexOf(",");
			int num2 = text.IndexOf("Battle Update: ");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "MapCache" + text.Substring(num + -38, num2 - (num + 81)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "recoil" + str + str2);
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x00021BAF File Offset: 0x0001FDAF
	private void CJIFEQFKPIM()
	{
		JICJEENBPEO.QOQONHOOLNE.CJMELFQFOCB(this);
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x00021BBC File Offset: 0x0001FDBC
	private void MQJBDIJQQEP()
	{
		JICJEENBPEO.BDPEQNCNPJO().KDJLCIDQIQL(this);
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x002C97A0 File Offset: 0x002C79A0
	public void LIDHPLOIFNP(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("<|>".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[4]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[0]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "p" + this.HQNCHPIOPBN.ToString() + ".png";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "[b]" + Convert.ToInt32(array[1]).ToString(" fell in love!\r\n");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.JQBDPHILQJO();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.QDMQEBHOENL(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "CombinersArgsColorSrc0" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD() + "Magician";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QKMHPDJNJHE();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("~") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains(" has chosen to use an item.")) && text.Contains("R"))
		{
			int num = text.IndexOf("The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.");
			int num2 = text.IndexOf("_Smoothing");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "\"" + text.Substring(num + 3, num2 - (num + -58));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "ability" + str + str2;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x00021BA2 File Offset: 0x0001FDA2
	private void DFBNIOEIFDD()
	{
		JICJEENBPEO.BEKHPOHIPDE().HMCFGLNOBPM(this);
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x00021BC9 File Offset: 0x0001FDC9
	private void NNOPGECPIDJ()
	{
		JICJEENBPEO.QOQONHOOLNE.KDJLCIDQIQL(this);
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x002C99AC File Offset: 0x002C7BAC
	public void QKCOIIKFPKG(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("FinishSelect".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[3]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[6]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "_WorldLightDir" + this.HQNCHPIOPBN.ToString() + "[00DD00]Equipped";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "Del" + Convert.ToInt32(array[0]).ToString("other");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.JQBDPHILQJO();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.QDMQEBHOENL(item.QCQPPPFPCQH().ToString());
		string text = string.Empty;
		text = "|" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + "special";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Die") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("megay")) && text.Contains("Sand Stream"))
		{
			int num = text.IndexOf("The Pokémon summons a sandstorm when it enters a battle.");
			int num2 = text.IndexOf("Player/Hair");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "[absorb]" + text.Substring(num + -6, num2 - (num + -25)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "map:flymap" + str + str2);
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x002C9BB8 File Offset: 0x002C7DB8
	public void FIJEJMDOLJN(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("*".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[2]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[3]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.NDPGCGDLEEQ();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "_Saturation" + this.HQNCHPIOPBN.ToString() + "] [u]";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "spikes" + Convert.ToInt32(array[1]).ToString("-endability");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.PINEJNIDONB(item.QCQPPPFPCQH().ToString());
		string text = string.Empty;
		text = "cheekpouch" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "(LB)";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LGOODGEDFQG();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("e") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("DirX")) && text.Contains("firepledge"))
		{
			int num = text.IndexOf("_LogLut_Params");
			int num2 = text.IndexOf(" can't sleep in an uproar!\r\n");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "HTE/Battle Monster Shader" + text.Substring(num + -84, num2 - (num + -13)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "perish1" + str + str2);
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x002C9DC4 File Offset: 0x002C7FC4
	public void KGBBFDJGGPQ(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("EnableDragScrollView".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[1]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[2]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.FLFQBGJQBBD();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "Dig" + this.HQNCHPIOPBN.ToString() + "WATER_EDGEBLEND_OFF";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "[-]" + Convert.ToInt32(array[0]).ToString("uproar");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.NDPGCGDLEEQ());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.PINEJNIDONB(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "Rotate" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + "HidePanel";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QKMHPDJNJHE();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("ffb649") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("blank")) && text.Contains("~"))
		{
			int num = text.IndexOf("][urn=");
			int num2 = text.IndexOf("Player/Mounts/");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "physical" + text.Substring(num + 112, num2 - (num + -75)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "Camera Distance Limit" + str + str2);
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x00021BD6 File Offset: 0x0001FDD6
	private void OBEGPCOBLNF()
	{
		JICJEENBPEO.BDPEQNCNPJO().HMCFGLNOBPM(this);
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x00021BBC File Offset: 0x0001FDBC
	private void OFLNDJGLONN()
	{
		JICJEENBPEO.BDPEQNCNPJO().KDJLCIDQIQL(this);
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x002C9FD0 File Offset: 0x002C81D0
	public void PJJFGOKNQMJ(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split(" is radiating a bursting aura!\r\n".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[6]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[4]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.JQBDPHILQJO();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "allAdjacentFoes" + this.HQNCHPIOPBN.ToString() + "Sound";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "Max Repel" + Convert.ToInt32(array[0]).ToString("[/itm]");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.JQBDPHILQJO();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.PINEJNIDONB(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = ".png" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "#,##0";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LGOODGEDFQG();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("#,##0") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("_")) && text.Contains("Battle Update: "))
		{
			int num = text.IndexOf("Party");
			int num2 = text.IndexOf(" shader doesn't have a clipped shader version for ");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "[ATK]" + text.Substring(num + -27, num2 - (num + -97));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "Zephyr Badge" + str + str2);
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x002CA1DC File Offset: 0x002C83DC
	public void EEOOPJNPMPJ(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("Battle Bond".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[6]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[8]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "special" + this.HQNCHPIOPBN.ToString() + "][";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "stockple" + Convert.ToInt32(array[0]).ToString("\r\n");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.DFNQHDEDDKE();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.OKBJNLOPPBF(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "CombinersArgsColorOp1" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO() + "_FogOfWarCenterAdjusted";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("defog") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("-mega-x")) && text.Contains(" has chosen to use an item."))
		{
			int num = text.IndexOf("\nEvening");
			int num2 = text.IndexOf("_DestortionShiftY");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "Camera Window" + text.Substring(num + -19, num2 - (num + 0));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "[-]!\r\n" + str + str2;
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x00021BE3 File Offset: 0x0001FDE3
	private void PODLKFQCEHI()
	{
		JICJEENBPEO.BEKHPOHIPDE().KDJLCIDQIQL(this);
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x002CA3E8 File Offset: 0x002C85E8
	public void QMKELEEOHBE(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("flyLimit".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[5]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[1]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "An electric current runs across the battlefield!\r\n" + this.HQNCHPIOPBN.ToString() + "/";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "[rare]" + Convert.ToInt32(array[1]).ToString("[FF0000]-");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.PINEJNIDONB(item.ItemImage.ToString());
		string text = string.Empty;
		text = "Battle_Wild" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD() + "_FogData";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QKMHPDJNJHE();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Not Input") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("You have lost your lucky four leaf clover.. Slot Machines luck has been reduced. Maybe you should take a break for awhile.")) && text.Contains("Music"))
		{
			int num = text.IndexOf("p1");
			int num2 = text.IndexOf("[ffff00]Wide Guard[-] protected ");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "OnSocketDataRecieved" + text.Substring(num + 7, num2 - (num + -44));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "Player/Clothe" + str + str2);
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x002CA5F4 File Offset: 0x002C87F4
	public void KDCHGCMPDLJ(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("[ffff00]Quick Guard[-] protected ".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[0]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[5]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.JQBDPHILQJO();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "Logging in.." + this.HQNCHPIOPBN.ToString() + "_VolumetricFog_OpaqueFrame";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "BuffIcon_EncounterRateIncrease" + Convert.ToInt32(array[1]).ToString("'s Ability became Mummy!\r\n");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.JQBDPHILQJO());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.OKBJNLOPPBF(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "[00FF00]" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "'s [ffff00]";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("SetVolumeBack") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("][-] [00CCFF]")) && text.Contains("battlebag"))
		{
			int num = text.IndexOf("shelltrap");
			int num2 = text.IndexOf("_OnRails");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "perishsong" + text.Substring(num + 91, num2 - (num + 73));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "Battle Update: " + str + str2;
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x002CA800 File Offset: 0x002C8A00
	public void PBEFGBBHKPH(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("Rails".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[1]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[6]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.FLFQBGJQBBD();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "[PG]" + this.HQNCHPIOPBN.ToString() + "dots";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "Battle" + Convert.ToInt32(array[1]).ToString("Invite to Party");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.PINEJNIDONB(item.QCQPPPFPCQH().ToString());
		string text = string.Empty;
		text = " disappeared!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NDPGCGDLEEQ() + "bag";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Connection Established..") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("HidePanel")) && text.Contains("Restores HP in rain or when hit by Water-type moves. Reduces HP in sunshine, and increases the damage received from Fire-type moves."))
		{
			int num = text.IndexOf("UpdateAnchors");
			int num2 = text.IndexOf("b");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "rkssystem" + text.Substring(num + -90, num2 - (num + -108)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "default_" + str + str2;
	}

	// Token: 0x06005731 RID: 22321 RVA: 0x002CAA0C File Offset: 0x002C8C0C
	public void EGKMLKHJCDD(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("http://poke.one/terms.html".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[8]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[3]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.FLFQBGJQBBD();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "Small/" + this.HQNCHPIOPBN.ToString() + "_Threshold";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "transform" + Convert.ToInt32(array[0]).ToString("aftermath");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.JQBDPHILQJO();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.OKBJNLOPPBF(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "_Texture0" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD() + "C";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("map:") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("JOFLHFQQCKG")) && text.Contains("Player/Mounts/"))
		{
			int num = text.IndexOf("13");
			int num2 = text.IndexOf("!\r\n");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "COLOR_GRADING" + text.Substring(num + 23, num2 - (num + -93)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "p1" + str + str2);
	}

	// Token: 0x06005732 RID: 22322 RVA: 0x00021BF0 File Offset: 0x0001FDF0
	private void NIIPONIQJCE()
	{
		JICJEENBPEO.BDPEQNCNPJO().DKGCJCMCNGP(this);
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x00021BAF File Offset: 0x0001FDAF
	private void OnClick()
	{
		JICJEENBPEO.QOQONHOOLNE.CJMELFQFOCB(this);
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x002CAC18 File Offset: 0x002C8E18
	public void HOFCKQELDLF(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("rotomfrost".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[5]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[1]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.DFNQHDEDDKE();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "Big/" + this.HQNCHPIOPBN.ToString() + "unburden";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "Enables a sure getaway from wild Pokémon." + Convert.ToInt32(array[0]).ToString("healer");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.FLFQBGJQBBD();
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.PINEJNIDONB(item.MQIHCHFOPGE().ToString());
		string text = string.Empty;
		text = "[eol]" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD() + "Dig";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("OnPress") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Restores HP if the Pokémon is poisoned, instead of losing HP.")) && text.Contains("l"))
		{
			int num = text.IndexOf("dispMode");
			int num2 = text.IndexOf("game object ghost not found");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "ability" + text.Substring(num + 81, num2 - (num + 17)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "beastboost" + str + str2);
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x002CAE24 File Offset: 0x002C9024
	public void BQLIIQIIMDH(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split(",".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[3]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[2]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "[PG]" + this.HQNCHPIOPBN.ToString() + "   ";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "[PD]" + Convert.ToInt32(array[1]).ToString("#,##0");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.Name;
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.QOQONHOOLNE.QIDKBCQIGOD.QDMQEBHOENL(item.ItemImage.ToString());
		string text = string.Empty;
		text = "[33CCFF]" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "[-]\n\n";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Description;
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("HM") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("TM")) && text.Contains("[u][33CCFF]"))
		{
			int num = text.IndexOf("[u][33CCFF]");
			int num2 = text.IndexOf("[-][/u]");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + " - " + text.Substring(num + 11, num2 - (num + 11));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "\n" + str + str2;
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x002CB030 File Offset: 0x002C9230
	public void PCFNFCMCMII(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("Leave Party".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[4]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[2]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.NDPGCGDLEEQ();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "Trigger Influence" + this.HQNCHPIOPBN.ToString() + "toxicspikes";
		}
		if (this.QGIFBQPKNPD > 1)
		{
			str2 = "[MEGA]" + Convert.ToInt32(array[0]).ToString("#,##0");
		}
		this.NKKMJICKKLB.PIDLOFMIEFQ = item.Name;
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.QDMQEBHOENL(item.MQIHCHFOPGE().ToString());
		string text = string.Empty;
		text = "[-] has come online." + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO() + "[";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LGOODGEDFQG();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("solarpower") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("Volt Absorb")) && text.Contains("Slots_8"))
		{
			int num = text.IndexOf("/ignore ");
			int num2 = text.IndexOf("Searching..");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "item" + text.Substring(num + -36, num2 - (num + -21));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "mindreader" + str + str2;
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x00021BA2 File Offset: 0x0001FDA2
	private void OMGFKKMONEQ()
	{
		JICJEENBPEO.BEKHPOHIPDE().HMCFGLNOBPM(this);
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x002CB23C File Offset: 0x002C943C
	public void IBJNQFPIMMC(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("/".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[1]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[7]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[7]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.DFNQHDEDDKE();
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "What Pokémon will hatch from this Egg? It doesn't seem close to hatching." + this.HQNCHPIOPBN.ToString() + "The Pokémon can't use a move the following turn if it uses one.";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "guild" + Convert.ToInt32(array[0]).ToString("blaze");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.NDPGCGDLEEQ());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BDPEQNCNPJO().QIDKBCQIGOD.QDMQEBHOENL(item.ItemImage.ToString());
		string text = string.Empty;
		text = "focuspunch" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE() + "shadowforce";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("[-]!\r\n") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("friendr")) && text.Contains("But there was no PP left for the move!\r\n"))
		{
			int num = text.IndexOf("Attempting to add a callback to a list that's null");
			int num2 = text.IndexOf("Enemy threw a Pokeball!\r\n");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "Blaze" + text.Substring(num + -111, num2 - (num + -51)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "/Model_S.prefab" + str + str2);
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x00021B88 File Offset: 0x0001FD88
	private void KDIMINFFGEL()
	{
		JICJEENBPEO.BEKHPOHIPDE().CJMELFQFOCB(this);
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x00021B7B File Offset: 0x0001FD7B
	private void NGMQHPMGDPP()
	{
		JICJEENBPEO.QOQONHOOLNE.HMCFGLNOBPM(this);
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x00021BBC File Offset: 0x0001FDBC
	private void DBMBOONLPIL()
	{
		JICJEENBPEO.BDPEQNCNPJO().KDJLCIDQIQL(this);
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x002CB448 File Offset: 0x002C9648
	public void FQFIFPGJDBE(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("#,##0".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[4]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[1]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[6]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 0)
		{
			str = "Username already in use" + this.HQNCHPIOPBN.ToString() + "no arguments";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = "Take 001" + Convert.ToInt32(array[0]).ToString("Misty Surge");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.JQBDPHILQJO());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.QDMQEBHOENL(item.MQIHCHFOPGE().ToString());
		string text = string.Empty;
		text = "Cap" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO() + "_ClipToWorld";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LGOODGEDFQG();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("HidePanel") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("electric")) && text.Contains("'s move...\r\n"))
		{
			int num = text.IndexOf(", ");
			int num2 = text.IndexOf("F5");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.LKPOBCBOFIC(nkkmjickklb.PIDLOFMIEFQ + "game.poke.one" + text.Substring(num + -78, num2 - (num + 99)));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.PIDLOFMIEFQ = nkkmjickklb2.PIDLOFMIEFQ + "Active: " + str + str2;
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x00021BD6 File Offset: 0x0001FDD6
	private void NQDGCNMFKLL()
	{
		JICJEENBPEO.BDPEQNCNPJO().HMCFGLNOBPM(this);
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x00021B7B File Offset: 0x0001FD7B
	private void HKLIDELHEJB()
	{
		JICJEENBPEO.QOQONHOOLNE.HMCFGLNOBPM(this);
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x002CB654 File Offset: 0x002C9854
	public void CQKHIPOLJNL(string EKDDQNPBPJL)
	{
		string[] array = EKDDQNPBPJL.Split("_FogPointLightColor2".ToCharArray());
		this.DBPKNCDGGEP = Convert.ToInt32(array[0]);
		this.DDGHMKCGIDM = Convert.ToUInt32(array[0]);
		this.QGIFBQPKNPD = Convert.ToInt32(array[0]);
		this.HQNCHPIOPBN = Convert.ToInt32(array[1]);
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.FPQBICGEHMJ = item.Name;
		string str = string.Empty;
		string str2 = string.Empty;
		if (this.HQNCHPIOPBN > 1)
		{
			str = "_NeutralTonemapperParams2" + this.HQNCHPIOPBN.ToString() + "Disabled";
		}
		if (this.QGIFBQPKNPD > 0)
		{
			str2 = " for " + Convert.ToInt32(array[1]).ToString("CombinersArgsAlphaSrc2");
		}
		this.NKKMJICKKLB.LKPOBCBOFIC(item.DFNQHDEDDKE());
		this.PHMFEMBPQLN.GOIHJQNMMJD = JICJEENBPEO.BEKHPOHIPDE().QIDKBCQIGOD.OKBJNLOPPBF(item.LEQLIKKPHHI().ToString());
		string text = string.Empty;
		text = "Turns the ground into Misty Terrain when the Pokémon enters a battle." + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name + "1";
		text += KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NKDOCPOOIIF();
		this.OQGNNFECDNJ.OKFNHJPFIGB = text;
		if ((this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("-meteor") || this.NKKMJICKKLB.PIDLOFMIEFQ.Contains("desolateland")) && text.Contains("Shift+"))
		{
			int num = text.IndexOf("Skill Link");
			int num2 = text.IndexOf("move");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM nkkmjickklb = this.NKKMJICKKLB;
				nkkmjickklb.PIDLOFMIEFQ = nkkmjickklb.PIDLOFMIEFQ + "Prevents itself and ally Pokémon from falling asleep." + text.Substring(num + -3, num2 - (num + -48));
			}
		}
		BKKHLBCLPJM nkkmjickklb2 = this.NKKMJICKKLB;
		nkkmjickklb2.LKPOBCBOFIC(nkkmjickklb2.PIDLOFMIEFQ + "PropertyBinding" + str + str2);
	}

	// Token: 0x04001300 RID: 4864
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x04001301 RID: 4865
	public JLMPBLMOICG PHMFEMBPQLN;

	// Token: 0x04001302 RID: 4866
	public int DBPKNCDGGEP;

	// Token: 0x04001303 RID: 4867
	public uint DDGHMKCGIDM;

	// Token: 0x04001304 RID: 4868
	public int QGIFBQPKNPD;

	// Token: 0x04001305 RID: 4869
	public int HQNCHPIOPBN;

	// Token: 0x04001306 RID: 4870
	public string FPQBICGEHMJ;

	// Token: 0x04001307 RID: 4871
	public CPLHOLGBMKB OQGNNFECDNJ;
}
