using System;
using System.Collections;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000210 RID: 528
public class KOJBBGEINPH : MonoBehaviour
{
	// Token: 0x060046EA RID: 18154 RVA: 0x0021FF78 File Offset: 0x0021E178
	public void OKOEGJIMCOQ(DailyLootbox KOEEIBDFFGE, TimeSpan OQJFBJQJEFG)
	{
		if (KOEEIBDFFGE != null)
		{
			this.KGGPIOCMFMB = KOEEIBDFFGE;
			this.DQHMJQLIMCF(DateTime.UtcNow);
		}
		if (OQJFBJQJEFG.TotalSeconds > 1710.0)
		{
			this.HHGQMPGKPLF = OQJFBJQJEFG;
			this.MHIGOKOPPBI(DateTime.UtcNow);
		}
		else
		{
			this.HHGQMPGKPLF = new TimeSpan(1L);
		}
		this.HONMHNHFMNI();
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x0001E03A File Offset: 0x0001C23A
	public void ODMCOCHJFLF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("#,##0", 702f);
	}

	// Token: 0x060046EC RID: 18156 RVA: 0x0001E063 File Offset: 0x0001C263
	public void OpenNormal()
	{
		this.PLEBIFPBLIN(PSXAPI.Request.LootboxType.Normal);
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x0001E06C File Offset: 0x0001C26C
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

	// Token: 0x060046EE RID: 18158 RVA: 0x0001E09E File Offset: 0x0001C29E
	public void QLKEMCGJIDC(PSXAPI.Response.Lootbox MMGMFFBMDKI)
	{
		this.FLPOHIKPHNJ(new PSXAPI.Response.Lootbox[]
		{
			MMGMFFBMDKI
		});
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
	public void IQJCMJQLQBI()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("'s can't use [ffff00]", 1733f);
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x0001E0D9 File Offset: 0x0001C2D9
	private void PIQJPNIKGJP()
	{
		KOJBBGEINPH.HBFFCJHOCPE = this;
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x060046F1 RID: 18161 RVA: 0x0001E0E1 File Offset: 0x0001C2E1
	public static KOJBBGEINPH QOQONHOOLNE
	{
		get
		{
			return KOJBBGEINPH.HBFFCJHOCPE;
		}
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x0021FFDC File Offset: 0x0021E1DC
	public void DIBPKNMDEGM(DailyLootbox KOEEIBDFFGE, TimeSpan OQJFBJQJEFG)
	{
		if (KOEEIBDFFGE != null)
		{
			this.KGGPIOCMFMB = KOEEIBDFFGE;
			this.NPLGPKEBIKB(DateTime.UtcNow);
		}
		if (OQJFBJQJEFG.TotalSeconds > 479.0)
		{
			this.HHGQMPGKPLF = OQJFBJQJEFG;
			this.GFIDGICFNNE(DateTime.UtcNow);
		}
		else
		{
			this.HHGQMPGKPLF = new TimeSpan(1L);
		}
		this.DDPMJFIBKHD();
	}

	// Token: 0x060046F3 RID: 18163 RVA: 0x00220040 File Offset: 0x0021E240
	private void JMLOIKQLLHO()
	{
		this.LOEGPLIELBK();
		this.CNQQBMJIFOG[0].PIDLOFMIEFQ = this.LEOBOQFQFDP.ToString();
		this.CNQQBMJIFOG[0].LKPOBCBOFIC(this.CJIHMODGCOQ.ToString());
		if (this.MENMQFGLFLI)
		{
			GameObject[] pgblhmldgoj = this.PGBLHMLDGOJ;
			for (int i = 0; i < pgblhmldgoj.Length; i += 0)
			{
				GameObject gameObject = pgblhmldgoj[i];
				gameObject.SetActive(false);
			}
		}
		else
		{
			this.PGBLHMLDGOJ[8].SetActive(true);
			this.PGBLHMLDGOJ[4].SetActive(true);
			this.PGBLHMLDGOJ[8].SetActive(false);
			this.PGBLHMLDGOJ[0].SetActive(false);
			if (this.LEOBOQFQFDP == 0u)
			{
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[5].SetActive(false);
			}
			else
			{
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[7].SetActive(false);
			}
			if (this.CJIHMODGCOQ == 0u)
			{
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[6].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[7].SetActive(false);
			}
		}
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
	public void QHOPLJLPLEF()
	{
		this.BJEMLINDHOH(PSXAPI.Request.LootboxType.None);
	}

	// Token: 0x060046F5 RID: 18165 RVA: 0x0001E0F1 File Offset: 0x0001C2F1
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x00220178 File Offset: 0x0021E378
	private IEnumerator BEBBOMJJQEI()
	{
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
		for (int i = 0; i < 3; i++)
		{
			this.JEQBIIDFEBM[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < this.FKODEDDMPOJ.Length; j++)
		{
			this.JEQBIIDFEBM[j].gameObject.SetActive(true);
			if (this.FKODEDDMPOJ[j].Duplicate)
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = "Duplicate!";
				if (this.FKODEDDMPOJ[j].DuplicateGold > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk.PIDLOFMIEFQ = mhimpjgqnnk.PIDLOFMIEFQ + "\n[PG]" + this.FKODEDDMPOJ[j].DuplicateGold.ToString("#,##0");
				}
				if (this.FKODEDDMPOJ[j].DuplicateMoney > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk2 = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk2.PIDLOFMIEFQ = mhimpjgqnnk2.PIDLOFMIEFQ + "\n[PD]" + this.FKODEDDMPOJ[j].DuplicateMoney.ToString("#,##0");
				}
			}
			else
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = string.Empty;
			}
			this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			string text2 = "1";
			if (this.FKODEDDMPOJ[j].LootType == LootType.Clothe)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Clothes";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Clothe",
					text,
					"/",
					this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(),
					"_",
					text2
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Hat)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Hat";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hats/" + (this.FKODEDDMPOJ[j].Num - 1).QQKICQQBIJL() + "_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Mount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Mount";
				text2 = "5";
				if (this.FKODEDDMPOJ[j].Num == 0 || this.FKODEDDMPOJ[j].Num == 1 || this.FKODEDDMPOJ[j].Num == 11 || this.FKODEDDMPOJ[j].Num == 12 || this.FKODEDDMPOJ[j].Num == 13)
				{
					text2 = "2";
				}
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.SurfMount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Surf Mount";
				text2 = "4";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Gold)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Poké Gold";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PG]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Money)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Pokédollars";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PD]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Item)
			{
				this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).ItemImage.ToString());
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).Name;
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Pokemon)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + this.FKODEDDMPOJ[j].Num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(this.FKODEDDMPOJ[j].Num);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.FlyMount)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + EMLOFJDOMKH.QOQONHOOLNE.HNDLNMDNJOI(this.FKODEDDMPOJ[j].Num).ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Fly Mount";
			}
		}
		yield return new WaitForSeconds(3f);
		return 1;
		this.MOHCGPMQCBJ.GetComponent<EPIJJNOIKEK>().PlayForward();
		this.MOHCGPMQCBJ.SetActive(true);
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x00220194 File Offset: 0x0021E394
	public void DNBGHKHGNCM(PSXAPI.Response.Lootbox[] MMGMFFBMDKI)
	{
		if (MMGMFFBMDKI != null)
		{
			for (int i = 1; i < MMGMFFBMDKI.Length; i += 0)
			{
				if (MMGMFFBMDKI[i].Type == (PSXAPI.Response.LootboxType)7)
				{
					this.LEOBOQFQFDP = MMGMFFBMDKI[i].Remaining;
				}
				else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.None)
				{
					this.CJIHMODGCOQ = MMGMFFBMDKI[i].Remaining;
				}
				if (MMGMFFBMDKI[i].Action == PSXAPI.Response.LootboxAction.Opened && this.MENMQFGLFLI)
				{
					if (MMGMFFBMDKI[i].Rolls != null)
					{
						this.FKODEDDMPOJ = MMGMFFBMDKI[i].Rolls;
					}
					if (MMGMFFBMDKI[i].Type == (PSXAPI.Response.LootboxType)4)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[1]).GetComponent<DPNKHLLMLQP>();
					}
					else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.None)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[1]).GetComponent<DPNKHLLMLQP>();
					}
					base.StartCoroutine(this.PJDFBPLDIJG());
				}
			}
		}
		if (this.JMEMDHFGCGL != 4294967288u)
		{
			int num = (int)(this.LEOBOQFQFDP + this.CJIHMODGCOQ - this.JMEMDHFGCGL);
			if (num > 0)
			{
				INFJMNPKNQF.IPOKOKIJECO().EMGKDMLOKED("](" + num.ToString() + "!\r\n", 0);
				Transform transform = this.MNNLEEENMKO.BFCKNMFEBDM(this.EJIHJGNFJJP).transform;
				transform.localPosition = new Vector3(1107f, 714f, 1828f);
			}
		}
		this.JMEMDHFGCGL = this.LEOBOQFQFDP + this.CJIHMODGCOQ;
		this.FDBKEJOHHEJ.PIDLOFMIEFQ = (this.LEOBOQFQFDP + this.CJIHMODGCOQ).ToString();
		this.GNPLPIHDPOQ();
	}

	// Token: 0x060046F8 RID: 18168 RVA: 0x0001E11A File Offset: 0x0001C31A
	public void MOEBOQNGJEN(PSXAPI.Response.Lootbox MMGMFFBMDKI)
	{
		PSXAPI.Response.Lootbox[] array = new PSXAPI.Response.Lootbox[1];
		array[1] = MMGMFFBMDKI;
		this.DNBGHKHGNCM(array);
	}

	// Token: 0x060046F9 RID: 18169 RVA: 0x00220348 File Offset: 0x0021E548
	public void BELMJNQKNNP(PSXAPI.Request.LootboxType OQJFBJQJEFG)
	{
		if (this.MENMQFGLFLI)
		{
			return;
		}
		this.MENMQFGLFLI = true;
		this.PDDJMNOOPJD();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Lootbox
		{
			Action = PSXAPI.Request.LootboxAction.None,
			Type = OQJFBJQJEFG
		}, true);
	}

	// Token: 0x060046FA RID: 18170 RVA: 0x0001E12C File Offset: 0x0001C32C
	public void MHNCDQIPPEI()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			return;
		}
		this.DDPMJFIBKHD();
	}

	// Token: 0x060046FC RID: 18172 RVA: 0x0022038C File Offset: 0x0021E58C
	private void DDPMJFIBKHD()
	{
		string text = string.Empty;
		TimeSpan t = DateTime.UtcNow - this.OEPGHGIGLGN();
		t = this.HHGQMPGKPLF - t;
		if (this.KGGPIOCMFMB != null)
		{
			if (this.KGGPIOCMFMB.Type == (PSXAPI.Response.LootboxType)6)
			{
				this.QPBEQPEMBJD[0].SetActive(true);
				this.QPBEQPEMBJD[1].SetActive(true);
			}
			else if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.None)
			{
				this.QPBEQPEMBJD[0].SetActive(false);
				this.QPBEQPEMBJD[1].SetActive(false);
			}
		}
		else
		{
			this.QPBEQPEMBJD[0].SetActive(false);
			this.QPBEQPEMBJD[1].SetActive(false);
		}
		if (this.KGGPIOCMFMB != null && (this.KGGPIOCMFMB == null || this.KGGPIOCMFMB.Type != PSXAPI.Response.LootboxType.None))
		{
			if (this.KGGPIOCMFMB != null)
			{
				t = DateTime.UtcNow - this.DIOFEDKBKFP;
				t = this.KGGPIOCMFMB.Timer - t;
				if (this.KGGPIOCMFMB.Timer.TotalSeconds > 1999.0)
				{
					if (t.Days > 0)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + "#,##0";
						}
						else
						{
							text = text + t.Days.ToString() + "p2";
						}
					}
					else if (t.Hours > 1)
					{
						if (t.Hours > 0)
						{
							text = text + t.Hours.ToString() + "Hi-Score: ";
						}
						else
						{
							text = text + t.Hours.ToString() + "[-]!\r\n";
						}
						if (t.Minutes > 0)
						{
							if (t.Minutes > 0)
							{
								text = text + "[-]!\r\n" + t.Minutes.ToString() + "Unlit/Text";
							}
							else
							{
								text = text + "Contact with the Pokémon may burn the attacker." + t.Minutes.ToString() + " exp.";
							}
						}
					}
					else if (t.Minutes > 1)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + " failed to learn the move ";
						}
						else
						{
							text = text + t.Minutes.ToString() + "???";
						}
					}
					else
					{
						text += "The Pokémon can poison the target even if it's a Steel or Poison type.";
					}
					if (t.TotalSeconds > 711.0)
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC("Hi-Score: " + text);
						this.DLHHEJMDEEQ.gameObject.SetActive(false);
					}
					else
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
				}
				else
				{
					this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
					this.DLHHEJMDEEQ.gameObject.SetActive(false);
				}
			}
			else
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else if (this.HHGQMPGKPLF.TotalSeconds > 1759.0)
		{
			if (t.Days > 0)
			{
				if (t.Days > 0)
				{
					text = text + t.Days.ToString() + "J13";
				}
				else
				{
					text = text + t.Days.ToString() + "\n\n";
				}
			}
			else if (t.Hours > 0)
			{
				if (t.Hours > 1)
				{
					text = text + t.Hours.ToString() + "_Top";
				}
				else
				{
					text = text + t.Hours.ToString() + " declined the Friend Request.";
				}
				if (t.Minutes > 1)
				{
					if (t.Minutes > 0)
					{
						text = text + "attract" + t.Minutes.ToString() + ".";
					}
					else
					{
						text = text + "aegislash" + t.Minutes.ToString() + "system";
					}
				}
			}
			else if (t.Minutes > 1)
			{
				if (t.Minutes > 1)
				{
					text = text + t.Minutes.ToString() + "Fly Mount";
				}
				else
				{
					text = text + t.Minutes.ToString() + "Once per battle, the shroud that covers the Pokémon can protect it from an attack.";
				}
			}
			else
			{
				text += ".";
			}
			if (t.TotalSeconds > 325.0)
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = "Guild" + text;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
			else
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
		}
		else
		{
			this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
			this.DLHHEJMDEEQ.gameObject.SetActive(false);
		}
	}

	// Token: 0x060046FD RID: 18173 RVA: 0x0001E0D9 File Offset: 0x0001C2D9
	private void Awake()
	{
		KOJBBGEINPH.HBFFCJHOCPE = this;
	}

	// Token: 0x060046FE RID: 18174 RVA: 0x00220178 File Offset: 0x0021E378
	private IEnumerator OGCFPPNDBKC()
	{
		ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_Male";
		}
		else
		{
			text = "_Female";
		}
		for (int i = 0; i < 3; i++)
		{
			this.JEQBIIDFEBM[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < this.FKODEDDMPOJ.Length; j++)
		{
			this.JEQBIIDFEBM[j].gameObject.SetActive(true);
			if (this.FKODEDDMPOJ[j].Duplicate)
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = "Duplicate!";
				if (this.FKODEDDMPOJ[j].DuplicateGold > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk.PIDLOFMIEFQ = mhimpjgqnnk.PIDLOFMIEFQ + "\n[PG]" + this.FKODEDDMPOJ[j].DuplicateGold.ToString("#,##0");
				}
				if (this.FKODEDDMPOJ[j].DuplicateMoney > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk2 = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk2.PIDLOFMIEFQ = mhimpjgqnnk2.PIDLOFMIEFQ + "\n[PD]" + this.FKODEDDMPOJ[j].DuplicateMoney.ToString("#,##0");
				}
			}
			else
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = string.Empty;
			}
			this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			string text2 = "1";
			if (this.FKODEDDMPOJ[j].LootType == LootType.Clothe)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Clothes";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Clothe",
					text,
					"/",
					this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(),
					"_",
					text2
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Hat)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Hat";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hats/" + (this.FKODEDDMPOJ[j].Num - 1).QQKICQQBIJL() + "_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Mount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Mount";
				text2 = "5";
				if (this.FKODEDDMPOJ[j].Num == 0 || this.FKODEDDMPOJ[j].Num == 1 || this.FKODEDDMPOJ[j].Num == 11 || this.FKODEDDMPOJ[j].Num == 12 || this.FKODEDDMPOJ[j].Num == 13)
				{
					text2 = "2";
				}
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.SurfMount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Surf Mount";
				text2 = "4";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Gold)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Poké Gold";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PG]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Money)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Pokédollars";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PD]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Item)
			{
				this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).ItemImage.ToString());
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).Name;
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Pokemon)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + this.FKODEDDMPOJ[j].Num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(this.FKODEDDMPOJ[j].Num);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.FlyMount)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + EMLOFJDOMKH.QOQONHOOLNE.HNDLNMDNJOI(this.FKODEDDMPOJ[j].Num).ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Fly Mount";
			}
		}
		yield return new WaitForSeconds(3f);
		return 1;
		this.MOHCGPMQCBJ.GetComponent<EPIJJNOIKEK>().PlayForward();
		this.MOHCGPMQCBJ.SetActive(true);
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x060046FF RID: 18175 RVA: 0x0001E15A File Offset: 0x0001C35A
	public void Reset()
	{
		this.MOHCGPMQCBJ.SetActive(false);
		this.MENMQFGLFLI = false;
		if (this.KQHQNJEFOHB != null)
		{
			UnityEngine.Object.Destroy(this.KQHQNJEFOHB.gameObject);
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x0600472E RID: 18222 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	// (set) Token: 0x06004700 RID: 18176 RVA: 0x0001E193 File Offset: 0x0001C393
	private DateTime CHLEPINFLEC { get; set; }

	// Token: 0x06004701 RID: 18177 RVA: 0x0001E19C File Offset: 0x0001C39C
	public void MBMMJHQDLNK()
	{
		this.BELMJNQKNNP(PSXAPI.Request.LootboxType.None);
	}

	// Token: 0x06004702 RID: 18178 RVA: 0x0001E1A5 File Offset: 0x0001C3A5
	private void IDEJFKDOGIB()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.KIEMMQDMIIO.SetActive(false);
	}

	// Token: 0x06004703 RID: 18179 RVA: 0x00220918 File Offset: 0x0021EB18
	public void EMICOJNLPBP(DailyLootbox KOEEIBDFFGE, TimeSpan OQJFBJQJEFG)
	{
		if (KOEEIBDFFGE != null)
		{
			this.KGGPIOCMFMB = KOEEIBDFFGE;
			this.NPLGPKEBIKB(DateTime.UtcNow);
		}
		if (OQJFBJQJEFG.TotalSeconds > 254.0)
		{
			this.HHGQMPGKPLF = OQJFBJQJEFG;
			this.GFIDGICFNNE(DateTime.UtcNow);
		}
		else
		{
			this.HHGQMPGKPLF = new TimeSpan(1L);
		}
		this.HONMHNHFMNI();
	}

	// Token: 0x06004704 RID: 18180 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
	private void NPLGPKEBIKB(DateTime BGBMIEJJQKC)
	{
		this.<PQHHLLDKQOH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004705 RID: 18181 RVA: 0x0022097C File Offset: 0x0021EB7C
	public void PLEBIFPBLIN(PSXAPI.Request.LootboxType OQJFBJQJEFG)
	{
		if (this.MENMQFGLFLI)
		{
			return;
		}
		this.MENMQFGLFLI = true;
		this.PDDJMNOOPJD();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Lootbox
		{
			Action = PSXAPI.Request.LootboxAction.Open,
			Type = OQJFBJQJEFG
		}, false);
	}

	// Token: 0x06004706 RID: 18182 RVA: 0x0001E193 File Offset: 0x0001C393
	private void OQGLHGOFLHF(DateTime BGBMIEJJQKC)
	{
		this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004707 RID: 18183 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	private DateTime OEPGHGIGLGN()
	{
		return this.<ILEJGPICFKG>k__BackingField;
	}

	// Token: 0x06004708 RID: 18184 RVA: 0x0001E193 File Offset: 0x0001C393
	private void GFIDGICFNNE(DateTime BGBMIEJJQKC)
	{
		this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004709 RID: 18185 RVA: 0x002209C0 File Offset: 0x0021EBC0
	private void PKJECHOPMFF()
	{
		string text = string.Empty;
		TimeSpan t = DateTime.UtcNow - this.BKICKMCHIJJ();
		t = this.HHGQMPGKPLF - t;
		if (this.KGGPIOCMFMB != null)
		{
			if (this.KGGPIOCMFMB.Type == (PSXAPI.Response.LootboxType)5)
			{
				this.QPBEQPEMBJD[0].SetActive(true);
				this.QPBEQPEMBJD[0].SetActive(false);
			}
			else if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.None)
			{
				this.QPBEQPEMBJD[0].SetActive(false);
				this.QPBEQPEMBJD[1].SetActive(false);
			}
		}
		else
		{
			this.QPBEQPEMBJD[1].SetActive(true);
			this.QPBEQPEMBJD[1].SetActive(false);
		}
		if (this.KGGPIOCMFMB != null && (this.KGGPIOCMFMB == null || this.KGGPIOCMFMB.Type != PSXAPI.Response.LootboxType.None))
		{
			if (this.KGGPIOCMFMB != null)
			{
				t = DateTime.UtcNow - this.DIOFEDKBKFP;
				t = this.KGGPIOCMFMB.Timer - t;
				if (this.KGGPIOCMFMB.Timer.TotalSeconds > 847.0)
				{
					if (t.Days > 1)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + "illusion";
						}
						else
						{
							text = text + t.Days.ToString() + "IFGPPIQKOPM";
						}
					}
					else if (t.Hours > 1)
					{
						if (t.Hours > 1)
						{
							text = text + t.Hours.ToString() + "d";
						}
						else
						{
							text = text + t.Hours.ToString() + "Big/";
						}
						if (t.Minutes > 1)
						{
							if (t.Minutes > 1)
							{
								text = text + " by the " + t.Minutes.ToString() + "multitype";
							}
							else
							{
								text = text + "/force left" + t.Minutes.ToString() + "Could not connect to Server..";
							}
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 0)
						{
							text = text + t.Minutes.ToString() + "[url=";
						}
						else
						{
							text = text + t.Minutes.ToString() + "BuffIcon_SweetScent";
						}
					}
					else
					{
						text += "-";
					}
					if (t.TotalSeconds > 1100.0)
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC("powertrick" + text);
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
					else
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
				}
				else
				{
					this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
					this.DLHHEJMDEEQ.gameObject.SetActive(true);
				}
			}
			else
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else if (this.HHGQMPGKPLF.TotalSeconds > 1177.0)
		{
			if (t.Days > 1)
			{
				if (t.Days > 1)
				{
					text = text + t.Days.ToString() + "_RayStepSize";
				}
				else
				{
					text = text + t.Days.ToString() + "n";
				}
			}
			else if (t.Hours > 1)
			{
				if (t.Hours > 0)
				{
					text = text + t.Hours.ToString() + "Assets/AssetBundles/MapAssets2/Models/UnovaGym/Material #464.mat";
				}
				else
				{
					text = text + t.Hours.ToString() + "[00FF00]You gained ";
				}
				if (t.Minutes > 1)
				{
					if (t.Minutes > 0)
					{
						text = text + "default" + t.Minutes.ToString() + "Powers up each Pokémon's Dark-type moves.";
					}
					else
					{
						text = text + "Contrary" + t.Minutes.ToString() + "flying";
					}
				}
			}
			else if (t.Minutes > 0)
			{
				if (t.Minutes > 1)
				{
					text = text + t.Minutes.ToString() + "!\r\n";
				}
				else
				{
					text = text + t.Minutes.ToString() + "!\r\n";
				}
			}
			else
			{
				text += " was kicked from the Party.";
			}
			if (t.TotalSeconds > 150.0)
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = "-" + text;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
			else
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
		}
		else
		{
			this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
			this.DLHHEJMDEEQ.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600470A RID: 18186 RVA: 0x0001E1D5 File Offset: 0x0001C3D5
	public void MMEDDDDFKDC()
	{
		this.PLEBIFPBLIN(PSXAPI.Request.LootboxType.Small);
	}

	// Token: 0x0600470B RID: 18187 RVA: 0x00220F4C File Offset: 0x0021F14C
	public void FIKKIBNELLQ()
	{
		if (this.QPPGQJFBPMH.DIIHJCJOKMP == 77f && this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.CancelInvoke("Sweet Scent Exhaustion");
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
			return;
		}
		this.KIEMMQDMIIO.SetActive(false);
		this.Reset();
		this.JPFLHBKCOLE();
		base.CancelInvoke("psn");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1489f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x0600470C RID: 18188 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	private DateTime OONFDIOQJFB()
	{
		return this.<ILEJGPICFKG>k__BackingField;
	}

	// Token: 0x0600470D RID: 18189 RVA: 0x00221004 File Offset: 0x0021F204
	public void FJEILLHKEPE(DailyLootbox KOEEIBDFFGE, TimeSpan OQJFBJQJEFG)
	{
		if (KOEEIBDFFGE != null)
		{
			this.KGGPIOCMFMB = KOEEIBDFFGE;
			this.DIOFEDKBKFP = DateTime.UtcNow;
		}
		if (OQJFBJQJEFG.TotalSeconds > 0.0)
		{
			this.HHGQMPGKPLF = OQJFBJQJEFG;
			this.CHLEPINFLEC = DateTime.UtcNow;
		}
		else
		{
			this.HHGQMPGKPLF = new TimeSpan(0L);
		}
		this.LOEGPLIELBK();
	}

	// Token: 0x0600470E RID: 18190 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
	private void DQHMJQLIMCF(DateTime BGBMIEJJQKC)
	{
		this.<PQHHLLDKQOH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600470F RID: 18191 RVA: 0x0001E0E1 File Offset: 0x0001C2E1
	public static KOJBBGEINPH OQDOKBJNBBL()
	{
		return KOJBBGEINPH.HBFFCJHOCPE;
	}

	// Token: 0x06004710 RID: 18192 RVA: 0x0001E1D5 File Offset: 0x0001C3D5
	public void OpenSmall()
	{
		this.PLEBIFPBLIN(PSXAPI.Request.LootboxType.Small);
	}

	// Token: 0x06004711 RID: 18193 RVA: 0x0001E1DE File Offset: 0x0001C3DE
	public void DKQEQBMBPDN()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			return;
		}
		this.LOEGPLIELBK();
	}

	// Token: 0x06004712 RID: 18194 RVA: 0x00221068 File Offset: 0x0021F268
	public void FLPOHIKPHNJ(PSXAPI.Response.Lootbox[] MMGMFFBMDKI)
	{
		if (MMGMFFBMDKI != null)
		{
			for (int i = 0; i < MMGMFFBMDKI.Length; i++)
			{
				if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.Normal)
				{
					this.LEOBOQFQFDP = MMGMFFBMDKI[i].Remaining;
				}
				else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.Small)
				{
					this.CJIHMODGCOQ = MMGMFFBMDKI[i].Remaining;
				}
				if (MMGMFFBMDKI[i].Action == PSXAPI.Response.LootboxAction.Opened && this.MENMQFGLFLI)
				{
					if (MMGMFFBMDKI[i].Rolls != null)
					{
						this.FKODEDDMPOJ = MMGMFFBMDKI[i].Rolls;
					}
					if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.Normal)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[0]).GetComponent<DPNKHLLMLQP>();
					}
					else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.Small)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[1]).GetComponent<DPNKHLLMLQP>();
					}
					base.StartCoroutine(this.BEBBOMJJQEI());
				}
			}
		}
		if (this.JMEMDHFGCGL != 999999999u)
		{
			int num = (int)(this.LEOBOQFQFDP + this.CJIHMODGCOQ - this.JMEMDHFGCGL);
			if (num > 0)
			{
				INFJMNPKNQF.QOQONHOOLNE.KHOHCGCLNBM("[00FF00]You gained Loot Box x" + num.ToString() + ".", 0);
				Transform transform = this.MNNLEEENMKO.BFCKNMFEBDM(this.EJIHJGNFJJP).transform;
				transform.localPosition = new Vector3(-20f, -32f, 0f);
			}
		}
		this.JMEMDHFGCGL = this.LEOBOQFQFDP + this.CJIHMODGCOQ;
		this.FDBKEJOHHEJ.PIDLOFMIEFQ = (this.LEOBOQFQFDP + this.CJIHMODGCOQ).ToString();
		this.PDDJMNOOPJD();
	}

	// Token: 0x06004713 RID: 18195 RVA: 0x0001E1F9 File Offset: 0x0001C3F9
	private void KPMMHQOMJEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.KIEMMQDMIIO.SetActive(true);
	}

	// Token: 0x06004714 RID: 18196 RVA: 0x0022121C File Offset: 0x0021F41C
	public void BJEMLINDHOH(PSXAPI.Request.LootboxType OQJFBJQJEFG)
	{
		if (this.MENMQFGLFLI)
		{
			return;
		}
		this.MENMQFGLFLI = true;
		this.JMLOIKQLLHO();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Lootbox
		{
			Action = PSXAPI.Request.LootboxAction.None,
			Type = OQJFBJQJEFG
		}, false);
	}

	// Token: 0x06004715 RID: 18197 RVA: 0x0001E218 File Offset: 0x0001C418
	public void DLDMPMKOLMQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IKJDEDNOEGH();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x06004716 RID: 18198 RVA: 0x0001E24A File Offset: 0x0001C44A
	// (set) Token: 0x0600471B RID: 18203 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
	private DateTime DIOFEDKBKFP { get; set; }

	// Token: 0x06004717 RID: 18199 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	private DateTime JOIBCFNQEMB()
	{
		return this.<ILEJGPICFKG>k__BackingField;
	}

	// Token: 0x06004718 RID: 18200 RVA: 0x0001E252 File Offset: 0x0001C452
	public void PJOODQMKDMG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.FIKKIBNELLQ();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
		}
		else
		{
			this.ODMCOCHJFLF();
		}
	}

	// Token: 0x06004719 RID: 18201 RVA: 0x00221260 File Offset: 0x0021F460
	private void PDDJMNOOPJD()
	{
		this.LOEGPLIELBK();
		this.CNQQBMJIFOG[0].PIDLOFMIEFQ = this.LEOBOQFQFDP.ToString();
		this.CNQQBMJIFOG[1].PIDLOFMIEFQ = this.CJIHMODGCOQ.ToString();
		if (this.MENMQFGLFLI)
		{
			foreach (GameObject gameObject in this.PGBLHMLDGOJ)
			{
				gameObject.SetActive(false);
			}
		}
		else
		{
			this.PGBLHMLDGOJ[2].SetActive(true);
			this.PGBLHMLDGOJ[3].SetActive(true);
			this.PGBLHMLDGOJ[6].SetActive(true);
			this.PGBLHMLDGOJ[7].SetActive(true);
			if (this.LEOBOQFQFDP == 0u)
			{
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[4].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[4].SetActive(false);
			}
			if (this.CJIHMODGCOQ == 0u)
			{
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[5].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[5].SetActive(false);
			}
		}
	}

	// Token: 0x0600471A RID: 18202 RVA: 0x00221398 File Offset: 0x0021F598
	public void Open()
	{
		if (this.QPPGQJFBPMH.DIIHJCJOKMP == 1f && this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.CancelInvoke("HidePanel");
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
			return;
		}
		this.KIEMMQDMIIO.SetActive(true);
		this.Reset();
		this.PDDJMNOOPJD();
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x0600471C RID: 18204 RVA: 0x00221450 File Offset: 0x0021F650
	private void HONMHNHFMNI()
	{
		string text = string.Empty;
		TimeSpan t = DateTime.UtcNow - this.JBGOLGMIJPN();
		t = this.HHGQMPGKPLF - t;
		if (this.KGGPIOCMFMB != null)
		{
			if (this.KGGPIOCMFMB.Type == (PSXAPI.Response.LootboxType)8)
			{
				this.QPBEQPEMBJD[1].SetActive(false);
				this.QPBEQPEMBJD[1].SetActive(false);
			}
			else if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.Small)
			{
				this.QPBEQPEMBJD[0].SetActive(true);
				this.QPBEQPEMBJD[1].SetActive(false);
			}
		}
		else
		{
			this.QPBEQPEMBJD[0].SetActive(false);
			this.QPBEQPEMBJD[0].SetActive(true);
		}
		if (this.KGGPIOCMFMB != null && (this.KGGPIOCMFMB == null || this.KGGPIOCMFMB.Type != PSXAPI.Response.LootboxType.None))
		{
			if (this.KGGPIOCMFMB != null)
			{
				t = DateTime.UtcNow - this.DIOFEDKBKFP;
				t = this.KGGPIOCMFMB.Timer - t;
				if (this.KGGPIOCMFMB.Timer.TotalSeconds > 1220.0)
				{
					if (t.Days > 0)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + "No Guard";
						}
						else
						{
							text = text + t.Days.ToString() + "[";
						}
					}
					else if (t.Hours > 1)
					{
						if (t.Hours > 1)
						{
							text = text + t.Hours.ToString() + "\n[PG]";
						}
						else
						{
							text = text + t.Hours.ToString() + "You can not afford to increase your guild member limit.\nCost: ";
						}
						if (t.Minutes > 1)
						{
							if (t.Minutes > 1)
							{
								text = text + "J" + t.Minutes.ToString() + "skydop";
							}
							else
							{
								text = text + "brickbreak" + t.Minutes.ToString() + " was seeded!\r\n";
							}
						}
					}
					else if (t.Minutes > 1)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + "spikyshield";
						}
						else
						{
							text = text + t.Minutes.ToString() + "StopRow3";
						}
					}
					else
					{
						text += "#,##0";
					}
					if (t.TotalSeconds > 1863.0)
					{
						this.DLHHEJMDEEQ.PIDLOFMIEFQ = "Player/Hats/" + text;
						this.DLHHEJMDEEQ.gameObject.SetActive(false);
					}
					else
					{
						this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
				}
				else
				{
					this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
					this.DLHHEJMDEEQ.gameObject.SetActive(false);
				}
			}
			else
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else if (this.HHGQMPGKPLF.TotalSeconds > 328.0)
		{
			if (t.Days > 0)
			{
				if (t.Days > 1)
				{
					text = text + t.Days.ToString() + "status: ";
				}
				else
				{
					text = text + t.Days.ToString() + "Changes the Pokémon's type to the type of the move it's about to use.";
				}
			}
			else if (t.Hours > 1)
			{
				if (t.Hours > 1)
				{
					text = text + t.Hours.ToString() + " fell for the feint!\r\n";
				}
				else
				{
					text = text + t.Hours.ToString() + "#,##0";
				}
				if (t.Minutes > 0)
				{
					if (t.Minutes > 1)
					{
						text = text + "DownS" + t.Minutes.ToString() + "wrap";
					}
					else
					{
						text = text + "Shed Skin" + t.Minutes.ToString() + "playcry(";
					}
				}
			}
			else if (t.Minutes > 1)
			{
				if (t.Minutes > 0)
				{
					text = text + t.Minutes.ToString() + "LJMOLEKDCLP";
				}
				else
				{
					text = text + t.Minutes.ToString() + "powder";
				}
			}
			else
			{
				text += "Hold or Use?";
			}
			if (t.TotalSeconds > 639.0)
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC("arenatrap" + text);
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
			else
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else
		{
			this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
			this.DLHHEJMDEEQ.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600471D RID: 18205 RVA: 0x0001E1A5 File Offset: 0x0001C3A5
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.KIEMMQDMIIO.SetActive(false);
	}

	// Token: 0x0600471E RID: 18206 RVA: 0x002219DC File Offset: 0x0021FBDC
	public void MPLKQKMQLOM(PSXAPI.Response.Lootbox[] MMGMFFBMDKI)
	{
		if (MMGMFFBMDKI != null)
		{
			for (int i = 1; i < MMGMFFBMDKI.Length; i++)
			{
				if (MMGMFFBMDKI[i].Type == (PSXAPI.Response.LootboxType)6)
				{
					this.LEOBOQFQFDP = MMGMFFBMDKI[i].Remaining;
				}
				else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.None)
				{
					this.CJIHMODGCOQ = MMGMFFBMDKI[i].Remaining;
				}
				if (MMGMFFBMDKI[i].Action == PSXAPI.Response.LootboxAction.None && this.MENMQFGLFLI)
				{
					if (MMGMFFBMDKI[i].Rolls != null)
					{
						this.FKODEDDMPOJ = MMGMFFBMDKI[i].Rolls;
					}
					if (MMGMFFBMDKI[i].Type == (PSXAPI.Response.LootboxType)7)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[0]).GetComponent<DPNKHLLMLQP>();
					}
					else if (MMGMFFBMDKI[i].Type == PSXAPI.Response.LootboxType.Small)
					{
						this.KQHQNJEFOHB = this.IBFHECDGEFK.gameObject.BFCKNMFEBDM(this.NBCCQJFBCHI[1]).GetComponent<DPNKHLLMLQP>();
					}
					base.StartCoroutine(this.BEBBOMJJQEI());
				}
			}
		}
		if (this.JMEMDHFGCGL != 4294967233u)
		{
			int num = (int)(this.LEOBOQFQFDP + this.CJIHMODGCOQ - this.JMEMDHFGCGL);
			if (num > 1)
			{
				INFJMNPKNQF.FPQNIQELKMC().OHCFBMPFFIP("[^0-9.-]" + num.ToString() + "_VFM_CutOff", 1);
				Transform transform = this.MNNLEEENMKO.BFCKNMFEBDM(this.EJIHJGNFJJP).transform;
				transform.localPosition = new Vector3(244f, 828f, 1967f);
			}
		}
		this.JMEMDHFGCGL = this.LEOBOQFQFDP + this.CJIHMODGCOQ;
		this.FDBKEJOHHEJ.LKPOBCBOFIC((this.LEOBOQFQFDP + this.CJIHMODGCOQ).ToString());
		this.PDDJMNOOPJD();
	}

	// Token: 0x0600471F RID: 18207 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	private DateTime JBGOLGMIJPN()
	{
		return this.<ILEJGPICFKG>k__BackingField;
	}

	// Token: 0x06004720 RID: 18208 RVA: 0x00221B90 File Offset: 0x0021FD90
	private void GNPLPIHDPOQ()
	{
		this.HONMHNHFMNI();
		this.CNQQBMJIFOG[0].PIDLOFMIEFQ = this.LEOBOQFQFDP.ToString();
		this.CNQQBMJIFOG[0].LKPOBCBOFIC(this.CJIHMODGCOQ.ToString());
		if (this.MENMQFGLFLI)
		{
			GameObject[] pgblhmldgoj = this.PGBLHMLDGOJ;
			for (int i = 1; i < pgblhmldgoj.Length; i += 0)
			{
				GameObject gameObject = pgblhmldgoj[i];
				gameObject.SetActive(false);
			}
		}
		else
		{
			this.PGBLHMLDGOJ[7].SetActive(true);
			this.PGBLHMLDGOJ[5].SetActive(true);
			this.PGBLHMLDGOJ[5].SetActive(false);
			this.PGBLHMLDGOJ[5].SetActive(true);
			if (this.LEOBOQFQFDP == 0u)
			{
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[5].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[6].SetActive(true);
			}
			if (this.CJIHMODGCOQ == 0u)
			{
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[2].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[8].SetActive(false);
			}
		}
	}

	// Token: 0x06004721 RID: 18209 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
	private void EMQHHKGGOQN(DateTime BGBMIEJJQKC)
	{
		this.<PQHHLLDKQOH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004722 RID: 18210 RVA: 0x0001E284 File Offset: 0x0001C484
	public void ILJEHHHGGLD()
	{
		this.BJEMLINDHOH(PSXAPI.Request.LootboxType.Small);
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x00221CC8 File Offset: 0x0021FEC8
	public void IKJDEDNOEGH()
	{
		if (this.QPPGQJFBPMH.DIIHJCJOKMP == 586f && this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.CancelInvoke("Player/Clothe");
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
			return;
		}
		this.KIEMMQDMIIO.SetActive(true);
		this.Reset();
		this.PDDJMNOOPJD();
		base.CancelInvoke("tox");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 238f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x0001E28D File Offset: 0x0001C48D
	public void NMMLPCLBJMF()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.IKJDEDNOEGH();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
		}
		else
		{
			this.ODMCOCHJFLF();
		}
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x00221D80 File Offset: 0x0021FF80
	private void GFEEKCQOODM()
	{
		string text = string.Empty;
		TimeSpan t = DateTime.UtcNow - this.JOIBCFNQEMB();
		t = this.HHGQMPGKPLF - t;
		if (this.KGGPIOCMFMB != null)
		{
			if (this.KGGPIOCMFMB.Type == (PSXAPI.Response.LootboxType)4)
			{
				this.QPBEQPEMBJD[1].SetActive(false);
				this.QPBEQPEMBJD[0].SetActive(false);
			}
			else if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.None)
			{
				this.QPBEQPEMBJD[1].SetActive(true);
				this.QPBEQPEMBJD[0].SetActive(true);
			}
		}
		else
		{
			this.QPBEQPEMBJD[0].SetActive(true);
			this.QPBEQPEMBJD[1].SetActive(false);
		}
		if (this.KGGPIOCMFMB != null && (this.KGGPIOCMFMB == null || this.KGGPIOCMFMB.Type != PSXAPI.Response.LootboxType.None))
		{
			if (this.KGGPIOCMFMB != null)
			{
				t = DateTime.UtcNow - this.DIOFEDKBKFP;
				t = this.KGGPIOCMFMB.Timer - t;
				if (this.KGGPIOCMFMB.Timer.TotalSeconds > 1961.0)
				{
					if (t.Days > 1)
					{
						if (t.Days > 0)
						{
							text = text + t.Days.ToString() + "Hold or Use?";
						}
						else
						{
							text = text + t.Days.ToString() + "OnDragStart";
						}
					}
					else if (t.Hours > 1)
					{
						if (t.Hours > 0)
						{
							text = text + t.Hours.ToString() + "[FF8F00]";
						}
						else
						{
							text = text + t.Hours.ToString() + "Female Pokemon Rate Increased.\nTriggers: [2ecc71]Cute Charm[-]";
						}
						if (t.Minutes > 0)
						{
							if (t.Minutes > 1)
							{
								text = text + "[yellow]" + t.Minutes.ToString() + "p";
							}
							else
							{
								text = text + "1" + t.Minutes.ToString() + "[PD]";
							}
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 0)
						{
							text = text + t.Minutes.ToString() + "Zen";
						}
						else
						{
							text = text + t.Minutes.ToString() + "]";
						}
					}
					else
					{
						text += "'s ";
					}
					if (t.TotalSeconds > 1870.0)
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC("!\r\n" + text);
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
					else
					{
						this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
						this.DLHHEJMDEEQ.gameObject.SetActive(false);
					}
				}
				else
				{
					this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
					this.DLHHEJMDEEQ.gameObject.SetActive(true);
				}
			}
			else
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC(string.Empty);
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
		}
		else if (this.HHGQMPGKPLF.TotalSeconds > 231.0)
		{
			if (t.Days > 0)
			{
				if (t.Days > 1)
				{
					text = text + t.Days.ToString() + "Resetting EVs for your ";
				}
				else
				{
					text = text + t.Days.ToString() + "'s Heal Block wore off!\r\n";
				}
			}
			else if (t.Hours > 0)
			{
				if (t.Hours > 0)
				{
					text = text + t.Hours.ToString() + "English";
				}
				else
				{
					text = text + t.Hours.ToString() + "Horizontal";
				}
				if (t.Minutes > 1)
				{
					if (t.Minutes > 1)
					{
						text = text + "status: " + t.Minutes.ToString() + "_FogOfWarData";
					}
					else
					{
						text = text + "PlayDeadAnimation" + t.Minutes.ToString() + "[";
					}
				}
			}
			else if (t.Minutes > 1)
			{
				if (t.Minutes > 1)
				{
					text = text + t.Minutes.ToString() + "TM";
				}
				else
				{
					text = text + t.Minutes.ToString() + "instruct";
				}
			}
			else
			{
				text += "M0";
			}
			if (t.TotalSeconds > 1761.0)
			{
				this.DLHHEJMDEEQ.LKPOBCBOFIC("-fieldend" + text);
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
			else
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
		}
		else
		{
			this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
			this.DLHHEJMDEEQ.gameObject.SetActive(true);
		}
	}

	// Token: 0x06004726 RID: 18214 RVA: 0x0022230C File Offset: 0x0022050C
	private void LOEGPLIELBK()
	{
		string text = string.Empty;
		TimeSpan t = DateTime.UtcNow - this.CHLEPINFLEC;
		t = this.HHGQMPGKPLF - t;
		if (this.KGGPIOCMFMB != null)
		{
			if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.Normal)
			{
				this.QPBEQPEMBJD[0].SetActive(true);
				this.QPBEQPEMBJD[1].SetActive(false);
			}
			else if (this.KGGPIOCMFMB.Type == PSXAPI.Response.LootboxType.Small)
			{
				this.QPBEQPEMBJD[1].SetActive(true);
				this.QPBEQPEMBJD[0].SetActive(false);
			}
		}
		else
		{
			this.QPBEQPEMBJD[0].SetActive(true);
			this.QPBEQPEMBJD[1].SetActive(false);
		}
		if (this.KGGPIOCMFMB != null && (this.KGGPIOCMFMB == null || this.KGGPIOCMFMB.Type != PSXAPI.Response.LootboxType.None))
		{
			if (this.KGGPIOCMFMB != null)
			{
				t = DateTime.UtcNow - this.DIOFEDKBKFP;
				t = this.KGGPIOCMFMB.Timer - t;
				if (this.KGGPIOCMFMB.Timer.TotalSeconds > 0.0)
				{
					if (t.Days > 0)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + " days";
						}
						else
						{
							text = text + t.Days.ToString() + " day";
						}
					}
					else if (t.Hours > 0)
					{
						if (t.Hours > 1)
						{
							text = text + t.Hours.ToString() + " hours";
						}
						else
						{
							text = text + t.Hours.ToString() + " hour";
						}
						if (t.Minutes > 0)
						{
							if (t.Minutes > 1)
							{
								text = text + " " + t.Minutes.ToString() + " minutes";
							}
							else
							{
								text = text + " " + t.Minutes.ToString() + " minute";
							}
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + " minutes";
						}
						else
						{
							text = text + t.Minutes.ToString() + " minute";
						}
					}
					else
					{
						text += "< 1 minute";
					}
					if (t.TotalSeconds > 0.0)
					{
						this.DLHHEJMDEEQ.PIDLOFMIEFQ = "Next Free Loot Box\n" + text;
						this.DLHHEJMDEEQ.gameObject.SetActive(true);
					}
					else
					{
						this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
						this.DLHHEJMDEEQ.gameObject.SetActive(false);
					}
				}
				else
				{
					this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
					this.DLHHEJMDEEQ.gameObject.SetActive(false);
				}
			}
			else
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else if (this.HHGQMPGKPLF.TotalSeconds > 0.0)
		{
			if (t.Days > 0)
			{
				if (t.Days > 1)
				{
					text = text + t.Days.ToString() + " days";
				}
				else
				{
					text = text + t.Days.ToString() + " day";
				}
			}
			else if (t.Hours > 0)
			{
				if (t.Hours > 1)
				{
					text = text + t.Hours.ToString() + " hours";
				}
				else
				{
					text = text + t.Hours.ToString() + " hour";
				}
				if (t.Minutes > 0)
				{
					if (t.Minutes > 1)
					{
						text = text + " " + t.Minutes.ToString() + " minutes";
					}
					else
					{
						text = text + " " + t.Minutes.ToString() + " minute";
					}
				}
			}
			else if (t.Minutes > 0)
			{
				if (t.Minutes > 1)
				{
					text = text + t.Minutes.ToString() + " minutes";
				}
				else
				{
					text = text + t.Minutes.ToString() + " minute";
				}
			}
			else
			{
				text += "< 1 minute";
			}
			if (t.TotalSeconds > 0.0)
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = "Daily Reset\n" + text;
				this.DLHHEJMDEEQ.gameObject.SetActive(true);
			}
			else
			{
				this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
				this.DLHHEJMDEEQ.gameObject.SetActive(false);
			}
		}
		else
		{
			this.DLHHEJMDEEQ.PIDLOFMIEFQ = string.Empty;
			this.DLHHEJMDEEQ.gameObject.SetActive(false);
		}
	}

	// Token: 0x06004727 RID: 18215 RVA: 0x00220178 File Offset: 0x0021E378
	private IEnumerator PJDFBPLDIJG()
	{
		ppmjcbonmqj = CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ;
		text = string.Empty;
		if (ppmjcbonmqj.HDCKEHHFCDN.Gender == Gender.Male)
		{
			text = "_Male";
		}
		else
		{
			text = "_Female";
		}
		for (int i = 0; i < 3; i++)
		{
			this.JEQBIIDFEBM[i].gameObject.SetActive(false);
		}
		for (int j = 0; j < this.FKODEDDMPOJ.Length; j++)
		{
			this.JEQBIIDFEBM[j].gameObject.SetActive(true);
			if (this.FKODEDDMPOJ[j].Duplicate)
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = "Duplicate!";
				if (this.FKODEDDMPOJ[j].DuplicateGold > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk.PIDLOFMIEFQ = mhimpjgqnnk.PIDLOFMIEFQ + "\n[PG]" + this.FKODEDDMPOJ[j].DuplicateGold.ToString("#,##0");
				}
				if (this.FKODEDDMPOJ[j].DuplicateMoney > 0u)
				{
					BKKHLBCLPJM mhimpjgqnnk2 = this.JEQBIIDFEBM[j].MHIMPJGQNNK;
					mhimpjgqnnk2.PIDLOFMIEFQ = mhimpjgqnnk2.PIDLOFMIEFQ + "\n[PD]" + this.FKODEDDMPOJ[j].DuplicateMoney.ToString("#,##0");
				}
			}
			else
			{
				this.JEQBIIDFEBM[j].MHIMPJGQNNK.PIDLOFMIEFQ = string.Empty;
			}
			this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = string.Empty;
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Blank", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.5f, 0.25f, 0.25f);
			string text2 = "1";
			if (this.FKODEDDMPOJ[j].LootType == LootType.Clothe)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Clothes";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
				{
					"Player/Clothe",
					text,
					"/",
					this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(),
					"_",
					text2
				}), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Hat)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Hat";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Hats/" + (this.FKODEDDMPOJ[j].Num - 1).QQKICQQBIJL() + "_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GINPFQOBGBO = new Rect(0.25f, 0.25f, 0.25f, 0.25f);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Mount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Mount";
				text2 = "5";
				if (this.FKODEDDMPOJ[j].Num == 0 || this.FKODEDDMPOJ[j].Num == 1 || this.FKODEDDMPOJ[j].Num == 11 || this.FKODEDDMPOJ[j].Num == 12 || this.FKODEDDMPOJ[j].Num == 13)
				{
					text2 = "2";
				}
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.SurfMount)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Surf Mount";
				text2 = "4";
				this.JEQBIIDFEBM[j].LDCIFEQGFQQ.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD(string.Concat(new string[]
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
				this.JEQBIIDFEBM[j].PKBPIHPBFLG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Clothe" + text + "/01_" + text2, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].DGOOHFGLFMI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL() + "_1", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
				this.JEQBIIDFEBM[j].KNPPMKBOGDL.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Player/Mounts/" + this.FKODEDDMPOJ[j].Num.QQKICQQBIJL(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Gold)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Poké Gold";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PG]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Money)
			{
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Pokédollars";
				this.JEQBIIDFEBM[j].MOEKNMHEJGQ.PIDLOFMIEFQ = "[PD]" + this.FKODEDDMPOJ[j].Num.ToString("#,##0");
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Item)
			{
				this.JEQBIIDFEBM[j].JEFJJDIGECG.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).ItemImage.ToString());
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.FKODEDDMPOJ[j].Num).Name;
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.Pokemon)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + this.FKODEDDMPOJ[j].Num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(this.FKODEDDMPOJ[j].Num);
			}
			else if (this.FKODEDDMPOJ[j].LootType == LootType.FlyMount)
			{
				this.JEQBIIDFEBM[j].QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + EMLOFJDOMKH.QOQONHOOLNE.HNDLNMDNJOI(this.FKODEDDMPOJ[j].Num).ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
				this.JEQBIIDFEBM[j].NKKMJICKKLB.PIDLOFMIEFQ = "Fly Mount";
			}
		}
		yield return new WaitForSeconds(3f);
		return 1;
		this.MOHCGPMQCBJ.GetComponent<EPIJJNOIKEK>().PlayForward();
		this.MOHCGPMQCBJ.SetActive(true);
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06004728 RID: 18216 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
	private void NPEMMCDBQOE(DateTime BGBMIEJJQKC)
	{
		this.<PQHHLLDKQOH>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004729 RID: 18217 RVA: 0x0001E1CD File Offset: 0x0001C3CD
	private DateTime BKICKMCHIJJ()
	{
		return this.<ILEJGPICFKG>k__BackingField;
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x0001E0E1 File Offset: 0x0001C2E1
	public static KOJBBGEINPH CPLQICHLGCI()
	{
		return KOJBBGEINPH.HBFFCJHOCPE;
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x0001E0E1 File Offset: 0x0001C2E1
	public static KOJBBGEINPH FHCMDGCONNE()
	{
		return KOJBBGEINPH.HBFFCJHOCPE;
	}

	// Token: 0x0600472C RID: 18220 RVA: 0x0001E284 File Offset: 0x0001C484
	public void QGLHKGGKDCQ()
	{
		this.BJEMLINDHOH(PSXAPI.Request.LootboxType.Small);
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x0001E09E File Offset: 0x0001C29E
	public void JEOPDDCFCEN(PSXAPI.Response.Lootbox MMGMFFBMDKI)
	{
		this.FLPOHIKPHNJ(new PSXAPI.Response.Lootbox[]
		{
			MMGMFFBMDKI
		});
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x0001E193 File Offset: 0x0001C393
	private void MHIGOKOPPBI(DateTime BGBMIEJJQKC)
	{
		this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x00222898 File Offset: 0x00220A98
	private void JPFLHBKCOLE()
	{
		this.PKJECHOPMFF();
		this.CNQQBMJIFOG[1].LKPOBCBOFIC(this.LEOBOQFQFDP.ToString());
		this.CNQQBMJIFOG[0].LKPOBCBOFIC(this.CJIHMODGCOQ.ToString());
		if (this.MENMQFGLFLI)
		{
			GameObject[] pgblhmldgoj = this.PGBLHMLDGOJ;
			for (int i = 1; i < pgblhmldgoj.Length; i += 0)
			{
				GameObject gameObject = pgblhmldgoj[i];
				gameObject.SetActive(true);
			}
		}
		else
		{
			this.PGBLHMLDGOJ[3].SetActive(true);
			this.PGBLHMLDGOJ[4].SetActive(false);
			this.PGBLHMLDGOJ[6].SetActive(false);
			this.PGBLHMLDGOJ[3].SetActive(true);
			if (this.LEOBOQFQFDP == 0u)
			{
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[1].SetActive(false);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[2].SetActive(false);
			}
			if (this.CJIHMODGCOQ == 0u)
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[3].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[0].SetActive(true);
			}
		}
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x0001E0D9 File Offset: 0x0001C2D9
	private void MBDGLQOGLDJ()
	{
		KOJBBGEINPH.HBFFCJHOCPE = this;
	}

	// Token: 0x04000EFD RID: 3837
	private static KOJBBGEINPH HBFFCJHOCPE;

	// Token: 0x04000EFE RID: 3838
	public GameObject[] PGBLHMLDGOJ;

	// Token: 0x04000EFF RID: 3839
	public BKKHLBCLPJM FDBKEJOHHEJ;

	// Token: 0x04000F00 RID: 3840
	public BKKHLBCLPJM[] CNQQBMJIFOG;

	// Token: 0x04000F01 RID: 3841
	public Transform IBFHECDGEFK;

	// Token: 0x04000F02 RID: 3842
	public GameObject[] NBCCQJFBCHI;

	// Token: 0x04000F03 RID: 3843
	public GameObject MOHCGPMQCBJ;

	// Token: 0x04000F04 RID: 3844
	private DPNKHLLMLQP KQHQNJEFOHB;

	// Token: 0x04000F05 RID: 3845
	private uint LEOBOQFQFDP;

	// Token: 0x04000F06 RID: 3846
	private uint CJIHMODGCOQ;

	// Token: 0x04000F07 RID: 3847
	public bool MENMQFGLFLI;

	// Token: 0x04000F08 RID: 3848
	public GameObject KIEMMQDMIIO;

	// Token: 0x04000F09 RID: 3849
	private LootboxRoll[] FKODEDDMPOJ;

	// Token: 0x04000F0A RID: 3850
	private DailyLootbox KGGPIOCMFMB;

	// Token: 0x04000F0B RID: 3851
	private TimeSpan HHGQMPGKPLF;

	// Token: 0x04000F0C RID: 3852
	private uint JMEMDHFGCGL = 999999999u;

	// Token: 0x04000F0D RID: 3853
	public BKKHLBCLPJM DLHHEJMDEEQ;

	// Token: 0x04000F10 RID: 3856
	public GameObject[] QPBEQPEMBJD;

	// Token: 0x04000F11 RID: 3857
	public GameObject EJIHJGNFJJP;

	// Token: 0x04000F12 RID: 3858
	public GameObject MNNLEEENMKO;

	// Token: 0x04000F13 RID: 3859
	public BELIHNPIMPP[] JEQBIIDFEBM;

	// Token: 0x04000F14 RID: 3860
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000F15 RID: 3861
	public EPIJJNOIKEK JDPBPOKJFQK;
}
