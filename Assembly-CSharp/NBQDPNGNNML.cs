using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000265 RID: 613
public class NBQDPNGNNML : MonoBehaviour
{
	// Token: 0x060053A0 RID: 21408 RVA: 0x00020F24 File Offset: 0x0001F124
	private void CNQGGPQKEGP()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x002A7744 File Offset: 0x002A5944
	private PSXAPI.Response.Quest HHCNELBDQKC(string CIQFCJGQEMH)
	{
		if (this.MJELIKDEDCO.Count > 1)
		{
			for (int i = 1; i < this.MJELIKDEDCO.Count; i += 0)
			{
				if (this.ICQJLIFEPBF == this.MJELIKDEDCO[i].ID)
				{
					return this.MJELIKDEDCO[i];
				}
			}
		}
		return null;
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x00020F37 File Offset: 0x0001F137
	private void PDPLLHOKCJG()
	{
		this.OGQOMJGIKQJ.enabled = true;
		this.OGQOMJGIKQJ.PlayReverse();
		base.Invoke("HideQuestsPanel", 0.5f);
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x002A77A4 File Offset: 0x002A59A4
	private void IGLOECDKBCD()
	{
		base.CancelInvoke("HideQuestsPanel");
		if (this.FPLEMIOILQN.DIIHJCJOKMP == 1f)
		{
			this.FPLEMIOILQN.gameObject.SetActive(true);
			this.PDDJMNOOPJD();
		}
		else
		{
			this.FPLEMIOILQN.DIIHJCJOKMP = 0f;
			this.FPLEMIOILQN.gameObject.SetActive(true);
			this.OGQOMJGIKQJ.enabled = true;
			this.OGQOMJGIKQJ.PlayForward();
			this.PDDJMNOOPJD();
		}
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x00020F60 File Offset: 0x0001F160
	private void PBPCFIJBJDB()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("2_", 1623f);
	}

	// Token: 0x060053A5 RID: 21413 RVA: 0x00020F89 File Offset: 0x0001F189
	private static QuestType QBECLENEHJJ(PSXAPI.Response.Quest DGKOIGOLHDM)
	{
		return DGKOIGOLHDM.Type;
	}

	// Token: 0x060053A6 RID: 21414 RVA: 0x00020F91 File Offset: 0x0001F191
	private void MQKMIOHNQCK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060053A7 RID: 21415 RVA: 0x002A7828 File Offset: 0x002A5A28
	public bool EELECEQLQGP(PSXAPI.Response.Quest BJFOCLIKMIJ)
	{
		bool result = true;
		INFJMNPKNQF infjmnpknqf = INFJMNPKNQF.DOGEBLQHDHI();
		int num = 0;
		switch (BJFOCLIKMIJ.ProgressType)
		{
		case QuestProgressType.Manual:
			num = BJFOCLIKMIJ.Progress;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Level:
			if ((ulong)CNCJKLNHQBH.MOGQNGEPCEO().EOMPMQNGIBD.UserLevel >= (ulong)((long)BJFOCLIKMIJ.Required))
			{
				result = false;
			}
			break;
		case QuestProgressType.Item:
			num = (int)infjmnpknqf.PNEEENCMBCN(BJFOCLIKMIJ.ProgressID);
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Badge:
			if (infjmnpknqf.DFMLMCDHNCM != null)
			{
				for (int i = 0; i < infjmnpknqf.DFMLMCDHNCM.Length; i++)
				{
					if (infjmnpknqf.DFMLMCDHNCM[i] == BJFOCLIKMIJ.ProgressID)
					{
						result = true;
						break;
					}
				}
			}
			break;
		case QuestProgressType.Pokemon:
		{
			HFCMDEQKCKH hfcmdeqkckh = HFCMDEQKCKH.CFGIOIGOIFQ();
			for (int j = 1; j < hfcmdeqkckh.LIJHMFEGCCK.Count; j++)
			{
				if (hfcmdeqkckh.QLJEQBGLPOE(hfcmdeqkckh.LIJHMFEGCCK[j]).EDGHHFPMHBL() == BJFOCLIKMIJ.ProgressID)
				{
					num++;
				}
			}
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		}
		case QuestProgressType.Money:
			num = (int)infjmnpknqf.EPDKBQCHOJQ;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Gold:
			num = (int)infjmnpknqf.QIOKIQOBMMB;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		}
		return result;
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x002A7988 File Offset: 0x002A5B88
	public void FNIFFFBEMDE()
	{
		this.NBNJQDBOKQJ.transform.NMBPDMIIHJB();
		int num = Mathf.Max(Screen.height, 768) - 500;
		int num2 = 0;
		int num3 = 0;
		string str = string.Empty;
		for (int i = 0; i < this.MJELIKDEDCO.Count; i++)
		{
			if (this.MJELIKDEDCO[i].Type != QuestType.Hidden)
			{
				if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[0];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Daily)
				{
					str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[1];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Bounty)
				{
					str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[2];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Side)
				{
					str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[3];
				}
				if (((this.MJELIKDEDCO[i].Type != QuestType.Daily && PlayerPrefs.GetInt("qTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 1) == 1) || (this.MJELIKDEDCO[i].Type == QuestType.Daily && PlayerPrefs.GetInt("qdTrack" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 0) == 1)) && (this.MJELIKDEDCO[i].Type == QuestType.Main || this.MJELIKDEDCO[i].Type == QuestType.Side || this.MJELIKDEDCO[i].Type == QuestType.Bounty || this.MJELIKDEDCO[i].Type == QuestType.Daily))
				{
					GameObject gameObject = this.NBNJQDBOKQJ.gameObject.BFCKNMFEBDM(this.DFGQJLPBHQJ);
					gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[0].PIDLOFMIEFQ = str + this.MJELIKDEDCO[i].Name;
					gameObject.GetComponent<QJGQEJGNOQH>().QBDIMIPFBLQ = this.MJELIKDEDCO[i].ID;
					if (this.JGEOEMMOKFD(this.MJELIKDEDCO[i]))
					{
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[1].PIDLOFMIEFQ = this.MJELIKDEDCO[i].Description + " (Completed)";
					}
					else
					{
						string str2 = string.Empty;
						if (this.MJELIKDEDCO[i].ProgressType == QuestProgressType.Manual)
						{
							int num4 = this.MJELIKDEDCO[i].Progress;
							if (num4 >= this.MJELIKDEDCO[i].Required)
							{
								num4 = this.MJELIKDEDCO[i].Required;
							}
							str2 = string.Concat(new string[]
							{
								" [FAFA00](",
								num4.ToString(),
								"/",
								this.MJELIKDEDCO[i].Required.ToString(),
								")[-]"
							});
						}
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[1].PIDLOFMIEFQ = this.MJELIKDEDCO[i].Description + str2;
					}
					num3 += (int)JNNGOIIKENH.HFMJNILQCMK(gameObject.transform).size.y + 4;
					num2++;
					if (num3 + 70 >= num)
					{
						break;
					}
				}
			}
		}
		if (num2 <= 0)
		{
			this.HOMCBLPIDNE.gameObject.SetActive(false);
		}
		else
		{
			this.HOMCBLPIDNE.gameObject.SetActive(true);
		}
		this.NBNJQDBOKQJ.CLQFFBMLIQH = true;
	}

	// Token: 0x060053A9 RID: 21417 RVA: 0x00020F91 File Offset: 0x0001F191
	private void KPMMHQOMJEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x00020FA4 File Offset: 0x0001F1A4
	private void Start()
	{
		this.Open();
		JFDJLDBQQKC nbnjqdbokqj = this.NBNJQDBOKQJ;
		nbnjqdbokqj.KGFNPBELMFI = (JFDJLDBQQKC.DLDKEBCHPOF)Delegate.Combine(nbnjqdbokqj.KGFNPBELMFI, new JFDJLDBQQKC.DLDKEBCHPOF(this.JKJFLBLOQPM));
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x00020FD3 File Offset: 0x0001F1D3
	private void QIKFOCKCGKL()
	{
		NBQDPNGNNML.HBFFCJHOCPE = this;
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x002A7D54 File Offset: 0x002A5F54
	public void COLIBFCPQMH()
	{
		this.KMCMNHDMJHF.transform.NMBPDMIIHJB();
		this.KMCMNHDMJHF.Reposition();
		this.KMCMNHDMJHF.gameObject.SetActive(false);
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.HNIJKCKHOFK(277f, false);
		GameObject gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.ODJQHLJCFGH().IEHHHBCDIOH[0] + "Corrupt preference file for ";
		gameObject.name = "adjacentFoe";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.JPMOJGDNKNC().IEHHHBCDIOH[0] + "[FFFF00]/252");
		gameObject.name = " fainted!\r\n";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.GDDGJKOLGIQ().IEHHHBCDIOH[7] + "Slots_7");
		gameObject.name = "The specified Port ";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.QQCNCIQQPIG().IEHHHBCDIOH[7] + "#,##0";
		gameObject.name = "Mouse ScrollWheel";
		string str = string.Empty;
		for (int i = 0; i < this.MJELIKDEDCO.Count; i += 0)
		{
			if (this.MJELIKDEDCO[i].Type != QuestType.Daily)
			{
				gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.ONMEBJFMJPD);
				gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(this.MJELIKDEDCO[i].Name);
				GCMCBQGMNIH component = gameObject.GetComponent<GCMCBQGMNIH>();
				component.DBPKNCDGGEP = this.MJELIKDEDCO[i].ID;
				component.DJPFQIFPGHP = this.MJELIKDEDCO[i].Type;
				if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "Coins were scattered everywhere!\r\n";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Side)
				{
					str = "waterfall";
				}
				else if (this.MJELIKDEDCO[i].Type == (QuestType)7)
				{
					str = "Passes through the opposing Pokémon's barrier, substitute, and the like and strikes.";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = ".wav";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "guild";
				}
				else
				{
					str = string.Empty;
				}
				gameObject.name = str + this.MJELIKDEDCO[i].ID;
			}
		}
		this.FNIFFFBEMDE();
		this.KMCMNHDMJHF.gameObject.SetActive(true);
		this.KMCMNHDMJHF.LCHKFMBLEKH();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.KMCMNHDMJHF.KPPLEDBFGFD(false);
		if (this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.OFJCBHKJCOP(this.ICQJLIFEPBF);
		}
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x002A8090 File Offset: 0x002A6290
	public void IBPKFNPPDKF()
	{
		this.NBNJQDBOKQJ.transform.NMBPDMIIHJB();
		int num = Mathf.Max(Screen.height, -176) - -156;
		int num2 = 1;
		int num3 = 0;
		string str = string.Empty;
		for (int i = 0; i < this.MJELIKDEDCO.Count; i += 0)
		{
			if (this.MJELIKDEDCO[i].Type != QuestType.Daily)
			{
				if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = MDBOHBDKMMM.JPMOJGDNKNC().IEHHHBCDIOH[0];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Bounty)
				{
					str = MDBOHBDKMMM.ODJQHLJCFGH().IEHHHBCDIOH[0];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = MDBOHBDKMMM.LGIPDGGFINQ().IEHHHBCDIOH[4];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Daily)
				{
					str = MDBOHBDKMMM.FFCOKMHBCQJ().IEHHHBCDIOH[0];
				}
				if (((this.MJELIKDEDCO[i].Type != (QuestType)8 && PlayerPrefs.GetInt("_FogOfWarCenterAdjusted" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 1) == 0) || (this.MJELIKDEDCO[i].Type == QuestType.Hidden && PlayerPrefs.GetInt("16" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 0) == 1)) && (this.MJELIKDEDCO[i].Type == QuestType.Main || this.MJELIKDEDCO[i].Type == QuestType.Bounty || this.MJELIKDEDCO[i].Type == QuestType.Bounty || this.MJELIKDEDCO[i].Type == QuestType.Bounty))
				{
					GameObject gameObject = this.NBNJQDBOKQJ.gameObject.BFCKNMFEBDM(this.DFGQJLPBHQJ);
					gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[1].PIDLOFMIEFQ = str + this.MJELIKDEDCO[i].Name;
					gameObject.GetComponent<QJGQEJGNOQH>().QBDIMIPFBLQ = this.MJELIKDEDCO[i].ID;
					if (this.EELECEQLQGP(this.MJELIKDEDCO[i]))
					{
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[0].LKPOBCBOFIC(this.MJELIKDEDCO[i].Description + "HidePanel");
					}
					else
					{
						string str2 = string.Empty;
						if (this.MJELIKDEDCO[i].ProgressType == QuestProgressType.None)
						{
							int num4 = this.MJELIKDEDCO[i].Progress;
							if (num4 >= this.MJELIKDEDCO[i].Required)
							{
								num4 = this.MJELIKDEDCO[i].Required;
							}
							string[] array = new string[1];
							array[1] = "TARGET TILE NOT ASSIGNED";
							array[0] = num4.ToString();
							array[8] = "0";
							array[2] = this.MJELIKDEDCO[i].Required.ToString();
							array[8] = "/3";
							str2 = string.Concat(array);
						}
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[0].PIDLOFMIEFQ = this.MJELIKDEDCO[i].Description + str2;
					}
					num3 += (int)JNNGOIIKENH.HFMJNILQCMK(gameObject.transform).size.y + 8;
					num2++;
					if (num3 + 20 >= num)
					{
						break;
					}
				}
			}
		}
		if (num2 <= 0)
		{
			this.HOMCBLPIDNE.gameObject.SetActive(false);
		}
		else
		{
			this.HOMCBLPIDNE.gameObject.SetActive(true);
		}
		this.NBNJQDBOKQJ.OIINFQGEJON(false);
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x002A845C File Offset: 0x002A665C
	private void GCMCBQGMNIH(int IIHDGMLHICI)
	{
		this.ICQJLIFEPBF = this.MJELIKDEDCO[IIHDGMLHICI].ID;
		string str = string.Empty;
		if (this.MJELIKDEDCO[IIHDGMLHICI].Type == QuestType.Main)
		{
			str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[0];
		}
		else if (this.MJELIKDEDCO[IIHDGMLHICI].Type == QuestType.Daily)
		{
			str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[1];
		}
		else if (this.MJELIKDEDCO[IIHDGMLHICI].Type == QuestType.Bounty)
		{
			str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[2];
		}
		else if (this.MJELIKDEDCO[IIHDGMLHICI].Type == QuestType.Side)
		{
			str = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[3];
		}
		this.QEQGLEQBENB.PIDLOFMIEFQ = str + this.MJELIKDEDCO[IIHDGMLHICI].Name;
		this.BGJKBEFCKQG.PIDLOFMIEFQ = this.MJELIKDEDCO[IIHDGMLHICI].Description;
		this.MFPPKEKELKM.gameObject.SetActive(false);
		this.JOQKNHFBIBO.gameObject.SetActive(false);
		INFJMNPKNQF qoqonhoolne = INFJMNPKNQF.QOQONHOOLNE;
		int num = 0;
		bool flag = false;
		switch (this.MJELIKDEDCO[IIHDGMLHICI].ProgressType)
		{
		case QuestProgressType.Manual:
			num = this.MJELIKDEDCO[IIHDGMLHICI].Progress;
			if (num >= this.MJELIKDEDCO[IIHDGMLHICI].Required)
			{
				num = this.MJELIKDEDCO[IIHDGMLHICI].Required;
				flag = true;
			}
			this.MFPPKEKELKM.BGBMIEJJQKC = (float)num / (float)this.MJELIKDEDCO[IIHDGMLHICI].Required;
			this.FHKLJFDCQHN.PIDLOFMIEFQ = num + "/" + this.MJELIKDEDCO[IIHDGMLHICI].Required.ToString();
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		case QuestProgressType.Level:
			if ((ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)this.MJELIKDEDCO[IIHDGMLHICI].Required))
			{
				flag = true;
			}
			break;
		case QuestProgressType.Item:
		{
			KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.MJELIKDEDCO[IIHDGMLHICI].ProgressID);
			num = (int)qoqonhoolne.PNEEENCMBCN(this.MJELIKDEDCO[IIHDGMLHICI].ProgressID);
			if (num >= this.MJELIKDEDCO[IIHDGMLHICI].Required)
			{
				num = this.MJELIKDEDCO[IIHDGMLHICI].Required;
				flag = true;
			}
			this.MFPPKEKELKM.BGBMIEJJQKC = (float)num / (float)this.MJELIKDEDCO[IIHDGMLHICI].Required;
			this.FHKLJFDCQHN.PIDLOFMIEFQ = string.Concat(new object[]
			{
				num,
				"/",
				this.MJELIKDEDCO[IIHDGMLHICI].Required.ToString(),
				" ",
				item.Name,
				" Obtained"
			});
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		}
		case QuestProgressType.Badge:
		{
			bool flag2 = false;
			if (qoqonhoolne.DFMLMCDHNCM != null)
			{
				for (int i = 0; i < qoqonhoolne.DFMLMCDHNCM.Length; i++)
				{
					if (qoqonhoolne.DFMLMCDHNCM[i] == this.MJELIKDEDCO[IIHDGMLHICI].ProgressID)
					{
						flag2 = true;
						break;
					}
				}
			}
			this.FHKLJFDCQHN.PIDLOFMIEFQ = "Obtain the " + KGQECFKLKOP.PBKLDIHQLGE(this.MJELIKDEDCO[IIHDGMLHICI].ProgressID);
			if (flag2)
			{
				flag = true;
				this.MFPPKEKELKM.BGBMIEJJQKC = 1f;
			}
			else
			{
				this.MFPPKEKELKM.BGBMIEJJQKC = 0f;
			}
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		}
		case QuestProgressType.Pokemon:
		{
			HFCMDEQKCKH qoqonhoolne2 = HFCMDEQKCKH.QOQONHOOLNE;
			for (int j = 0; j < qoqonhoolne2.LIJHMFEGCCK.Count; j++)
			{
				if (qoqonhoolne2.PEJHBEBOCOJ(qoqonhoolne2.LIJHMFEGCCK[j]).BEQHNFFEHMQ == this.MJELIKDEDCO[IIHDGMLHICI].ProgressID)
				{
					num++;
				}
			}
			if (num >= this.MJELIKDEDCO[IIHDGMLHICI].Required)
			{
				num = this.MJELIKDEDCO[IIHDGMLHICI].Required;
				flag = true;
			}
			this.MFPPKEKELKM.BGBMIEJJQKC = (float)num / (float)this.MJELIKDEDCO[IIHDGMLHICI].Required;
			this.FHKLJFDCQHN.PIDLOFMIEFQ = string.Concat(new string[]
			{
				this.MJELIKDEDCO[IIHDGMLHICI].Progress.ToString(),
				"/",
				this.MJELIKDEDCO[IIHDGMLHICI].Required.ToString(),
				" ",
				KGQECFKLKOP.NNHFLHEQMOI(this.MJELIKDEDCO[IIHDGMLHICI].ProgressID),
				" Obtained "
			});
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		}
		case QuestProgressType.Money:
			num = (int)qoqonhoolne.EPDKBQCHOJQ;
			if (num >= this.MJELIKDEDCO[IIHDGMLHICI].Required)
			{
				num = this.MJELIKDEDCO[IIHDGMLHICI].Required;
				flag = true;
			}
			this.MFPPKEKELKM.BGBMIEJJQKC = (float)num / (float)this.MJELIKDEDCO[IIHDGMLHICI].Required;
			this.FHKLJFDCQHN.PIDLOFMIEFQ = "[PD]" + num.ToString("#,##0") + "/[PD]" + this.MJELIKDEDCO[IIHDGMLHICI].Required.ToString("#,##0");
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		case QuestProgressType.Gold:
			num = (int)qoqonhoolne.QIOKIQOBMMB;
			if (num >= this.MJELIKDEDCO[IIHDGMLHICI].Required)
			{
				num = this.MJELIKDEDCO[IIHDGMLHICI].Required;
				flag = true;
			}
			this.MFPPKEKELKM.BGBMIEJJQKC = (float)num / (float)this.MJELIKDEDCO[IIHDGMLHICI].Required;
			this.FHKLJFDCQHN.PIDLOFMIEFQ = "[PG]" + num.ToString() + "/[PG]" + this.MJELIKDEDCO[IIHDGMLHICI].Required.ToString();
			this.MFPPKEKELKM.gameObject.SetActive(true);
			break;
		}
		this.BGECKJLGEQD.transform.NMBPDMIIHJB();
		this.BGECKJLGEQD.Reposition();
		this.BGECKJLGEQD.gameObject.SetActive(false);
		if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Items != null)
		{
			for (int k = 0; k < this.MJELIKDEDCO[IIHDGMLHICI].Reward.Items.Length; k++)
			{
				JCQFGICFNEO component = this.BGECKJLGEQD.gameObject.BFCKNMFEBDM(this.GGMNODBKQFH).GetComponent<JCQFGICFNEO>();
				component.BQLIIQIIMDH(this.MJELIKDEDCO[IIHDGMLHICI].Reward.Items[k], 1);
			}
		}
		if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Pokemon > 0)
		{
			JCQFGICFNEO component2 = this.BGECKJLGEQD.gameObject.BFCKNMFEBDM(this.GGMNODBKQFH).GetComponent<JCQFGICFNEO>();
			component2.BQLIIQIIMDH(this.MJELIKDEDCO[IIHDGMLHICI].Reward.Pokemon, this.MJELIKDEDCO[IIHDGMLHICI].Reward.PokemonShiny, this.MJELIKDEDCO[IIHDGMLHICI].Reward.PokemonLevel);
		}
		this.BGECKJLGEQD.gameObject.SetActive(true);
		this.BGECKJLGEQD.Reposition();
		string text = string.Empty;
		if (this.MJELIKDEDCO[IIHDGMLHICI].Reward != null)
		{
			if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Exp > 0)
			{
				text = text + "[00AAFF]" + this.MJELIKDEDCO[IIHDGMLHICI].Reward.Exp.ToString() + " EXP[-]";
			}
			if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Money > 0u)
			{
				if (text != string.Empty)
				{
					text += "\n";
				}
				text = text + "[PD]" + this.MJELIKDEDCO[IIHDGMLHICI].Reward.Money.ToString("#,##0");
			}
			if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Gold > 0u)
			{
				if (text != string.Empty)
				{
					text += "\n";
				}
				text = text + "[PG]" + this.MJELIKDEDCO[IIHDGMLHICI].Reward.Gold.ToString("#,##0");
			}
			if (this.MJELIKDEDCO[IIHDGMLHICI].Reward.Badge > 0)
			{
				if (text != string.Empty)
				{
					text += "\n";
				}
				text = text + "[00FF00]" + KGQECFKLKOP.PBKLDIHQLGE(this.MJELIKDEDCO[IIHDGMLHICI].Reward.Badge) + "[-]";
			}
		}
		this.BLDPCDIDJDL.PIDLOFMIEFQ = string.Empty;
		bool flag3 = true;
		if (this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC != null && this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC.Length > 1 && (this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC.Substring(0, 1) == "@" || this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC.Substring(0, 1) == "#" || this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC.Substring(0, 1) == "." || this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC.ToLowerInvariant() == "new npc"))
		{
			flag3 = false;
		}
		if (this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC != null && this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC != string.Empty && flag3)
		{
			BKKHLBCLPJM bldpcdidjdl = this.BLDPCDIDJDL;
			bldpcdidjdl.PIDLOFMIEFQ = bldpcdidjdl.PIDLOFMIEFQ + "[00AAFF]From:[-] " + this.MJELIKDEDCO[IIHDGMLHICI].SourceNPC;
			if (this.MJELIKDEDCO[IIHDGMLHICI].SourceArea != null && this.MJELIKDEDCO[IIHDGMLHICI].SourceArea != string.Empty)
			{
				BKKHLBCLPJM bldpcdidjdl2 = this.BLDPCDIDJDL;
				bldpcdidjdl2.PIDLOFMIEFQ = bldpcdidjdl2.PIDLOFMIEFQ + " (" + this.MJELIKDEDCO[IIHDGMLHICI].SourceArea + ")\n";
			}
			else
			{
				BKKHLBCLPJM bldpcdidjdl3 = this.BLDPCDIDJDL;
				bldpcdidjdl3.PIDLOFMIEFQ += "\n";
			}
		}
		else if (this.MJELIKDEDCO[IIHDGMLHICI].SourceArea != null && this.MJELIKDEDCO[IIHDGMLHICI].SourceArea != string.Empty)
		{
			BKKHLBCLPJM bldpcdidjdl4 = this.BLDPCDIDJDL;
			bldpcdidjdl4.PIDLOFMIEFQ = bldpcdidjdl4.PIDLOFMIEFQ + "[00AAFF]From:[-] " + this.MJELIKDEDCO[IIHDGMLHICI].SourceArea + "\n";
		}
		string text2 = (this.MJELIKDEDCO[IIHDGMLHICI].Required <= 0 || this.MJELIKDEDCO[IIHDGMLHICI].Progress < this.MJELIKDEDCO[IIHDGMLHICI].Required) ? this.MJELIKDEDCO[IIHDGMLHICI].TargetArea : this.MJELIKDEDCO[IIHDGMLHICI].TargetCompletedArea;
		if (text2 != null && text2 != string.Empty)
		{
			BKKHLBCLPJM bldpcdidjdl5 = this.BLDPCDIDJDL;
			bldpcdidjdl5.PIDLOFMIEFQ = bldpcdidjdl5.PIDLOFMIEFQ + "[00AAFF]Location:[-] " + text2;
		}
		this.PBLOEDQJDOE.PIDLOFMIEFQ = text;
		if (flag)
		{
			if (this.MJELIKDEDCO[IIHDGMLHICI].AutoComplete)
			{
				this.JOQKNHFBIBO.gameObject.SetActive(true);
				this.JOQKNHFBIBO.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = "Complete";
			}
			else if (this.MJELIKDEDCO[IIHDGMLHICI].TargetCompleted != default(Guid))
			{
				this.JOQKNHFBIBO.gameObject.SetActive(true);
				this.JOQKNHFBIBO.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = "Goto";
			}
		}
		else if (this.MJELIKDEDCO[IIHDGMLHICI].Target != default(Guid))
		{
			this.JOQKNHFBIBO.gameObject.SetActive(true);
			this.JOQKNHFBIBO.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = "Goto";
		}
		this.OMOCMQJGDDI.gameObject.SetActive(true);
		if (this.MJELIKDEDCO[IIHDGMLHICI].CanCancel)
		{
			this.OMOCMQJGDDI.gameObject.SetActive(true);
			this.OMOCMQJGDDI.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.OMOCMQJGDDI.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.OMOCMQJGDDI.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.OMOCMQJGDDI.GetComponent<BoxCollider>().enabled = false;
			this.OMOCMQJGDDI.gameObject.SetActive(false);
		}
		if (this.MJELIKDEDCO[IIHDGMLHICI].CanShare)
		{
			this.NJNJEQHNDDQ.gameObject.SetActive(true);
			this.NJNJEQHNDDQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.NJNJEQHNDDQ.GetComponent<BoxCollider>().enabled = true;
		}
		else
		{
			this.NJNJEQHNDDQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.NJNJEQHNDDQ.GetComponent<BoxCollider>().enabled = false;
			this.NJNJEQHNDDQ.gameObject.SetActive(false);
		}
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x002A922C File Offset: 0x002A742C
	public void GLEFJQQKILF(PSXAPI.Response.Quest BJFOCLIKMIJ, bool PFFLBEHLKIG = false)
	{
		int i = 0;
		while (i < this.MJELIKDEDCO.Count)
		{
			if (!(this.MJELIKDEDCO[i].ID == BJFOCLIKMIJ.ID))
			{
				i++;
			}
			else
			{
				this.MJELIKDEDCO.RemoveAt(i);
				IL_42:
				if (BJFOCLIKMIJ.Type == QuestType.None)
				{
					this.PDDJMNOOPJD();
					return;
				}
				if (!BJFOCLIKMIJ.Completed && BJFOCLIKMIJ.Name != null && BJFOCLIKMIJ.Name != string.Empty)
				{
					if (BJFOCLIKMIJ.Description != null)
					{
						BJFOCLIKMIJ.Description = KGQECFKLKOP.LGGPFIJQHOM(BJFOCLIKMIJ.Description);
					}
					this.MJELIKDEDCO.Add(BJFOCLIKMIJ);
				}
				else if (BJFOCLIKMIJ.Completed && BJFOCLIKMIJ.Name != null && BJFOCLIKMIJ.Name != string.Empty)
				{
					JPPCMGBCNNJ.QOQONHOOLNE.NLPCILIPELK("Quest Complete!", BJFOCLIKMIJ.Name, 29);
				}
				if (this.MJELIKDEDCO != null && this.MJELIKDEDCO.Count > 1)
				{
					IEnumerable<PSXAPI.Response.Quest> mjelikdedco = this.MJELIKDEDCO;
					if (NBQDPNGNNML.HNCJFHJNHDN == null)
					{
						NBQDPNGNNML.HNCJFHJNHDN = new Func<PSXAPI.Response.Quest, QuestType>(NBQDPNGNNML.MGEGFJGBQIN);
					}
					this.MJELIKDEDCO = mjelikdedco.OrderBy(NBQDPNGNNML.HNCJFHJNHDN).ToList<PSXAPI.Response.Quest>();
				}
				if (!PFFLBEHLKIG)
				{
					if (this.NMDNMMBBJLI != null)
					{
						base.StopCoroutine(this.NMDNMMBBJLI);
					}
					this.NMDNMMBBJLI = base.StartCoroutine(this.CKCJQGPEBCM());
				}
				this.PDDJMNOOPJD();
				return;
			}
		}
		goto IL_42;
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x002A9384 File Offset: 0x002A7584
	public void OFJCBHKJCOP(string DBPKNCDGGEP)
	{
		if (this.MJELIKDEDCO.Count > 1)
		{
			int iihdgmlhici = 0;
			for (int i = 1; i < this.MJELIKDEDCO.Count; i += 0)
			{
				if (DBPKNCDGGEP == this.MJELIKDEDCO[i].ID)
				{
					iihdgmlhici = i;
					IL_43:
					this.GCMCBQGMNIH(iihdgmlhici);
					this.EBMPKICGIHQ.SetActive(true);
					return;
				}
			}
			goto IL_43;
		}
		this.EBMPKICGIHQ.SetActive(false);
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x00020F89 File Offset: 0x0001F189
	private static QuestType DEJEPHFOBNH(PSXAPI.Response.Quest DGKOIGOLHDM)
	{
		return DGKOIGOLHDM.Type;
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x00020F89 File Offset: 0x0001F189
	[CompilerGenerated]
	private static QuestType MGEGFJGBQIN(PSXAPI.Response.Quest DGKOIGOLHDM)
	{
		return DGKOIGOLHDM.Type;
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x00020FF9 File Offset: 0x0001F1F9
	private void JCQCNFLNMNP()
	{
		this.LGEOCKGQGPH();
		JFDJLDBQQKC nbnjqdbokqj = this.NBNJQDBOKQJ;
		nbnjqdbokqj.KGFNPBELMFI = (JFDJLDBQQKC.DLDKEBCHPOF)Delegate.Combine(nbnjqdbokqj.KGFNPBELMFI, new JFDJLDBQQKC.DLDKEBCHPOF(this.JKJFLBLOQPM));
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x002A93F8 File Offset: 0x002A75F8
	public void NNLHHOOLNQK()
	{
		PSXAPI.Response.Quest quest = this.IBIMOJKGPHH(this.ICQJLIFEPBF);
		if (quest != null && quest.CanCancel)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Quest
			{
				Action = (QuestAction)4,
				ID = quest.ID
			}, false);
		}
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x00021028 File Offset: 0x0001F228
	private void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x060053B7 RID: 21431 RVA: 0x00021051 File Offset: 0x0001F251
	private void BDHEBFIKFOF()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("2", 1287f);
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x0002107A File Offset: 0x0001F27A
	public void BBDGMEOPLNG()
	{
		if (!this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.IGLOECDKBCD();
			this.FPLEMIOILQN.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.PDPLLHOKCJG();
		}
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x000210AC File Offset: 0x0001F2AC
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.PDDJMNOOPJD();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x00020F91 File Offset: 0x0001F191
	private void QPLKGKLGEBM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x000210D4 File Offset: 0x0001F2D4
	private void HideQuestsPanel()
	{
		this.FPLEMIOILQN.gameObject.SetActive(false);
	}

	// Token: 0x060053BC RID: 21436 RVA: 0x002A9444 File Offset: 0x002A7644
	private void JKJFLBLOQPM()
	{
		this.HOMCBLPIDNE.DFKQMMIQDOO = (int)JNNGOIIKENH.HFMJNILQCMK(this.NBNJQDBOKQJ.transform).size.y + 6;
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x002A9480 File Offset: 0x002A7680
	public void QKLDMOIQGIN()
	{
		PSXAPI.Response.Quest quest = this.IBIMOJKGPHH(this.ICQJLIFEPBF);
		if (quest != null && quest.CanCancel)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Quest
			{
				Action = (QuestAction)7,
				ID = quest.ID
			}, true);
		}
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x000210E7 File Offset: 0x0001F2E7
	public void CQNHGCOCNKD()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.BLCLGIIEGFK();
		}
		else
		{
			this.BDHEBFIKFOF();
		}
	}

	// Token: 0x060053BF RID: 21439 RVA: 0x002A94CC File Offset: 0x002A76CC
	public void CancelQuest()
	{
		PSXAPI.Response.Quest quest = this.IBIMOJKGPHH(this.ICQJLIFEPBF);
		if (quest != null && quest.CanCancel)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Quest
			{
				Action = QuestAction.Cancel,
				ID = quest.ID
			}, false);
		}
	}

	// Token: 0x060053C0 RID: 21440 RVA: 0x002A9518 File Offset: 0x002A7718
	private void Open()
	{
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060053C1 RID: 21441 RVA: 0x002A9568 File Offset: 0x002A7768
	[DebuggerHidden]
	private IEnumerator CKCJQGPEBCM()
	{
		NBQDPNGNNML.IBJFEKJQCLF ibjfekjqclf = new NBQDPNGNNML.IBJFEKJQCLF();
		ibjfekjqclf.QNDQJMNKFNN = this;
		return ibjfekjqclf;
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x00020FF9 File Offset: 0x0001F1F9
	private void EKIFLKDPKNM()
	{
		this.LGEOCKGQGPH();
		JFDJLDBQQKC nbnjqdbokqj = this.NBNJQDBOKQJ;
		nbnjqdbokqj.KGFNPBELMFI = (JFDJLDBQQKC.DLDKEBCHPOF)Delegate.Combine(nbnjqdbokqj.KGFNPBELMFI, new JFDJLDBQQKC.DLDKEBCHPOF(this.JKJFLBLOQPM));
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x0002110F File Offset: 0x0001F30F
	private void NOLQNFCODBK()
	{
		this.DIMCBEEENJL();
		JFDJLDBQQKC nbnjqdbokqj = this.NBNJQDBOKQJ;
		nbnjqdbokqj.KGFNPBELMFI = (JFDJLDBQQKC.DLDKEBCHPOF)Delegate.Combine(nbnjqdbokqj.KGFNPBELMFI, new JFDJLDBQQKC.DLDKEBCHPOF(this.JKJFLBLOQPM));
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x002A9584 File Offset: 0x002A7784
	private void LGEOCKGQGPH()
	{
		base.CancelInvoke(" type was added to ");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1941f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x002A95D4 File Offset: 0x002A77D4
	public void ENMIEHBMGOC(PSXAPI.Response.Quest BJFOCLIKMIJ, bool PFFLBEHLKIG = false)
	{
		int i = 1;
		while (i < this.MJELIKDEDCO.Count)
		{
			if (!(this.MJELIKDEDCO[i].ID == BJFOCLIKMIJ.ID))
			{
				i++;
			}
			else
			{
				this.MJELIKDEDCO.RemoveAt(i);
				IL_42:
				if (BJFOCLIKMIJ.Type == QuestType.None)
				{
					this.OMCFMCPELLB();
					return;
				}
				if (!BJFOCLIKMIJ.Completed && BJFOCLIKMIJ.Name != null && BJFOCLIKMIJ.Name != string.Empty)
				{
					if (BJFOCLIKMIJ.Description != null)
					{
						BJFOCLIKMIJ.Description = KGQECFKLKOP.LGGPFIJQHOM(BJFOCLIKMIJ.Description);
					}
					this.MJELIKDEDCO.Add(BJFOCLIKMIJ);
				}
				else if (BJFOCLIKMIJ.Completed && BJFOCLIKMIJ.Name != null && BJFOCLIKMIJ.Name != string.Empty)
				{
					JPPCMGBCNNJ.QBNCFLKLLKC().NLPCILIPELK("Female", BJFOCLIKMIJ.Name, 112);
				}
				if (this.MJELIKDEDCO != null && this.MJELIKDEDCO.Count > 0)
				{
					IEnumerable<PSXAPI.Response.Quest> mjelikdedco = this.MJELIKDEDCO;
					if (NBQDPNGNNML.HNCJFHJNHDN == null)
					{
						NBQDPNGNNML.HNCJFHJNHDN = new Func<PSXAPI.Response.Quest, QuestType>(NBQDPNGNNML.DEJEPHFOBNH);
					}
					this.MJELIKDEDCO = mjelikdedco.OrderBy(NBQDPNGNNML.HNCJFHJNHDN).ToList<PSXAPI.Response.Quest>();
				}
				if (!PFFLBEHLKIG)
				{
					if (this.NMDNMMBBJLI != null)
					{
						base.StopCoroutine(this.NMDNMMBBJLI);
					}
					this.NMDNMMBBJLI = base.StartCoroutine(this.CKCJQGPEBCM());
				}
				this.COLIBFCPQMH();
				return;
			}
		}
		goto IL_42;
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x002A972C File Offset: 0x002A792C
	public void NOHHNEGFFPC()
	{
		PSXAPI.Response.Quest quest = this.HHCNELBDQKC(this.ICQJLIFEPBF);
		if (quest != null)
		{
			if (this.EELECEQLQGP(quest))
			{
				if (quest.AutoComplete)
				{
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Quest
					{
						Action = QuestAction.Complete,
						ID = quest.ID
					}, true);
					this.JOQKNHFBIBO.gameObject.SetActive(false);
				}
				else if (quest.TargetCompleted != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 605f)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Path
					{
						Request = quest.TargetCompleted
					}, false);
					this.JOQKNHFBIBO.GGBPLMICFHN = false;
					this.EGQFDJMMQQL = UnityEngine.Time.time;
				}
			}
			else if (quest.Target != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 370f)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Path
				{
					Request = quest.Target
				}, false);
				this.JOQKNHFBIBO.GGBPLMICFHN = true;
				this.EGQFDJMMQQL = UnityEngine.Time.time;
			}
		}
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x002A9868 File Offset: 0x002A7A68
	private PSXAPI.Response.Quest GHGDKKQHEMC(string CIQFCJGQEMH)
	{
		if (this.MJELIKDEDCO.Count > 0)
		{
			for (int i = 1; i < this.MJELIKDEDCO.Count; i += 0)
			{
				if (this.ICQJLIFEPBF == this.MJELIKDEDCO[i].ID)
				{
					return this.MJELIKDEDCO[i];
				}
			}
		}
		return null;
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x00020F24 File Offset: 0x0001F124
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x002A98C8 File Offset: 0x002A7AC8
	private void JGHBBPPGNMC()
	{
		base.CancelInvoke("The Pokémon only takes damage from attacks.");
		if (this.FPLEMIOILQN.DIIHJCJOKMP == 309f)
		{
			this.FPLEMIOILQN.gameObject.SetActive(false);
			this.OMCFMCPELLB();
		}
		else
		{
			this.FPLEMIOILQN.DIIHJCJOKMP = 1694f;
			this.FPLEMIOILQN.gameObject.SetActive(true);
			this.OGQOMJGIKQJ.enabled = false;
			this.OGQOMJGIKQJ.PlayForward();
			this.OMCFMCPELLB();
		}
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x002A994C File Offset: 0x002A7B4C
	private PSXAPI.Response.Quest IBIMOJKGPHH(string CIQFCJGQEMH)
	{
		if (this.MJELIKDEDCO.Count > 0)
		{
			for (int i = 0; i < this.MJELIKDEDCO.Count; i++)
			{
				if (this.ICQJLIFEPBF == this.MJELIKDEDCO[i].ID)
				{
					return this.MJELIKDEDCO[i];
				}
			}
		}
		return null;
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x002A99AC File Offset: 0x002A7BAC
	public void PDDJMNOOPJD()
	{
		this.KMCMNHDMJHF.transform.NMBPDMIIHJB();
		this.KMCMNHDMJHF.Reposition();
		this.KMCMNHDMJHF.gameObject.SetActive(false);
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		GameObject gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[0] + "Main Quests";
		gameObject.name = "0_";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[1] + "Daily Quests";
		gameObject.name = "2_";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[2] + "Bounty Quests";
		gameObject.name = "4_";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[3] + "Side Quests";
		gameObject.name = "6_";
		string str = string.Empty;
		for (int i = 0; i < this.MJELIKDEDCO.Count; i++)
		{
			if (this.MJELIKDEDCO[i].Type != QuestType.Hidden)
			{
				gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.ONMEBJFMJPD);
				gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = this.MJELIKDEDCO[i].Name;
				GCMCBQGMNIH component = gameObject.GetComponent<GCMCBQGMNIH>();
				component.DBPKNCDGGEP = this.MJELIKDEDCO[i].ID;
				component.DJPFQIFPGHP = this.MJELIKDEDCO[i].Type;
				if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = "1_";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Daily)
				{
					str = "3_";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Bounty)
				{
					str = "5_";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Side)
				{
					str = "7_";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "8_";
				}
				else
				{
					str = string.Empty;
				}
				gameObject.name = str + this.MJELIKDEDCO[i].ID;
			}
		}
		this.FNIFFFBEMDE();
		this.KMCMNHDMJHF.gameObject.SetActive(true);
		this.KMCMNHDMJHF.Reposition();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.KMCMNHDMJHF.CLQFFBMLIQH = true;
		if (this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.GCMCBQGMNIH(this.ICQJLIFEPBF);
		}
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x002A9CE8 File Offset: 0x002A7EE8
	public void ConfirmButton()
	{
		PSXAPI.Response.Quest quest = this.IBIMOJKGPHH(this.ICQJLIFEPBF);
		if (quest != null)
		{
			if (this.JGEOEMMOKFD(quest))
			{
				if (quest.AutoComplete)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Quest
					{
						Action = QuestAction.Complete,
						ID = quest.ID
					}, false);
					this.JOQKNHFBIBO.gameObject.SetActive(false);
				}
				else if (quest.TargetCompleted != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 2f)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Path
					{
						Request = quest.TargetCompleted
					}, false);
					this.JOQKNHFBIBO.GGBPLMICFHN = false;
					this.EGQFDJMMQQL = UnityEngine.Time.time;
				}
			}
			else if (quest.Target != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 2f)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Path
				{
					Request = quest.Target
				}, false);
				this.JOQKNHFBIBO.GGBPLMICFHN = false;
				this.EGQFDJMMQQL = UnityEngine.Time.time;
			}
		}
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x00020FD3 File Offset: 0x0001F1D3
	private void Awake()
	{
		NBQDPNGNNML.HBFFCJHOCPE = this;
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x00020FD3 File Offset: 0x0001F1D3
	private void EMMIHJIFJFM()
	{
		NBQDPNGNNML.HBFFCJHOCPE = this;
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060053CF RID: 21455 RVA: 0x0002113E File Offset: 0x0001F33E
	// (set) Token: 0x060053D4 RID: 21460 RVA: 0x0002118D File Offset: 0x0001F38D
	public static NBQDPNGNNML QOQONHOOLNE
	{
		get
		{
			return NBQDPNGNNML.HBFFCJHOCPE;
		}
		set
		{
			NBQDPNGNNML.HBFFCJHOCPE = NBQDPNGNNML.QOQONHOOLNE;
		}
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x00021145 File Offset: 0x0001F345
	private void HHDOQLFIFFL()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("_Detail", 1682f);
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x0002116E File Offset: 0x0001F36E
	public void OCJEMFJJLLI(string CIQFCJGQEMH)
	{
		this.IGLOECDKBCD();
		this.FPLEMIOILQN.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		this.GCMCBQGMNIH(CIQFCJGQEMH);
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x002A9E24 File Offset: 0x002A8024
	public void GCMCBQGMNIH(string DBPKNCDGGEP)
	{
		if (this.MJELIKDEDCO.Count > 0)
		{
			int iihdgmlhici = 0;
			for (int i = 0; i < this.MJELIKDEDCO.Count; i++)
			{
				if (DBPKNCDGGEP == this.MJELIKDEDCO[i].ID)
				{
					iihdgmlhici = i;
					IL_43:
					this.GCMCBQGMNIH(iihdgmlhici);
					this.EBMPKICGIHQ.SetActive(true);
					return;
				}
			}
			goto IL_43;
		}
		this.EBMPKICGIHQ.SetActive(false);
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x002A9E98 File Offset: 0x002A8098
	public void CBOIPMDILFC()
	{
		this.NBNJQDBOKQJ.transform.NMBPDMIIHJB();
		int num = Mathf.Max(Screen.height, -100) - 173;
		int num2 = 0;
		int num3 = 1;
		string str = string.Empty;
		for (int i = 1; i < this.MJELIKDEDCO.Count; i += 0)
		{
			if (this.MJELIKDEDCO[i].Type != (QuestType)7)
			{
				if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = MDBOHBDKMMM.FFCOKMHBCQJ().IEHHHBCDIOH[1];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = MDBOHBDKMMM.LGIPDGGFINQ().IEHHHBCDIOH[1];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = MDBOHBDKMMM.IIHFFPCIFBM().IEHHHBCDIOH[7];
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Hidden)
				{
					str = MDBOHBDKMMM.KEHHJHKPKBE().IEHHHBCDIOH[3];
				}
				if (((this.MJELIKDEDCO[i].Type != QuestType.Bounty && PlayerPrefs.GetInt("!\r\n" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 0) == 1) || (this.MJELIKDEDCO[i].Type == QuestType.Hidden && PlayerPrefs.GetInt("[" + KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() + this.MJELIKDEDCO[i].ID, 0) == 0)) && (this.MJELIKDEDCO[i].Type == QuestType.Main || this.MJELIKDEDCO[i].Type == (QuestType)6 || this.MJELIKDEDCO[i].Type == (QuestType)7 || this.MJELIKDEDCO[i].Type == QuestType.Bounty))
				{
					GameObject gameObject = this.NBNJQDBOKQJ.gameObject.BFCKNMFEBDM(this.DFGQJLPBHQJ);
					gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[1].LKPOBCBOFIC(str + this.MJELIKDEDCO[i].Name);
					gameObject.GetComponent<QJGQEJGNOQH>().QBDIMIPFBLQ = this.MJELIKDEDCO[i].ID;
					if (this.EELECEQLQGP(this.MJELIKDEDCO[i]))
					{
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[1].LKPOBCBOFIC(this.MJELIKDEDCO[i].Description + "Big/");
					}
					else
					{
						string str2 = string.Empty;
						if (this.MJELIKDEDCO[i].ProgressType == QuestProgressType.Manual)
						{
							int num4 = this.MJELIKDEDCO[i].Progress;
							if (num4 >= this.MJELIKDEDCO[i].Required)
							{
								num4 = this.MJELIKDEDCO[i].Required;
							}
							string[] array = new string[3];
							array[1] = "_FogPointLightColor0";
							array[0] = num4.ToString();
							array[8] = "[/u][-][/urn]: ";
							array[8] = this.MJELIKDEDCO[i].Required.ToString();
							array[0] = "][-] [00CCFF]";
							str2 = string.Concat(array);
						}
						gameObject.GetComponentsInChildren<BKKHLBCLPJM>()[0].LKPOBCBOFIC(this.MJELIKDEDCO[i].Description + str2);
					}
					num3 += (int)JNNGOIIKENH.HFMJNILQCMK(gameObject.transform).size.y + 5;
					num2++;
					if (num3 + -88 >= num)
					{
						break;
					}
				}
			}
		}
		if (num2 <= 1)
		{
			this.HOMCBLPIDNE.gameObject.SetActive(false);
		}
		else
		{
			this.HOMCBLPIDNE.gameObject.SetActive(true);
		}
		this.NBNJQDBOKQJ.ODIBBLJQHOL(true);
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x002AA264 File Offset: 0x002A8464
	public void BLCLGIIEGFK()
	{
		this.KMCMNHDMJHF.transform.NMBPDMIIHJB();
		this.KMCMNHDMJHF.Reposition();
		this.KMCMNHDMJHF.gameObject.SetActive(false);
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(73f, true);
		GameObject gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.JPMOJGDNKNC().IEHHHBCDIOH[1] + "Bg_SocialStatus_Online");
		gameObject.name = "Physical attacks to the Pokémon lower its Defense stat but sharply raise its Speed stat.";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.IIHFFPCIFBM().IEHHHBCDIOH[0] + "Icon_Status_Frozen");
		gameObject.name = "damp";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.HGEKKNEPOHK().IEHHHBCDIOH[3] + "Powers up moves that make direct contact.";
		gameObject.name = "grass";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = MDBOHBDKMMM.CPIJOBOQLOK().IEHHHBCDIOH[3] + "_Cutoff";
		gameObject.name = "Guild name must be between 3 and 20 Characters in length.";
		string str = string.Empty;
		for (int i = 0; i < this.MJELIKDEDCO.Count; i += 0)
		{
			if (this.MJELIKDEDCO[i].Type != QuestType.Bounty)
			{
				gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.ONMEBJFMJPD);
				gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = this.MJELIKDEDCO[i].Name;
				GCMCBQGMNIH component = gameObject.GetComponent<GCMCBQGMNIH>();
				component.DBPKNCDGGEP = this.MJELIKDEDCO[i].ID;
				component.DJPFQIFPGHP = this.MJELIKDEDCO[i].Type;
				if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = ")";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Daily)
				{
					str = "WATER_EDGEBLEND_OFF";
				}
				else if (this.MJELIKDEDCO[i].Type == (QuestType)7)
				{
					str = "physical";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = "[ohko]";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "[/sup]";
				}
				else
				{
					str = string.Empty;
				}
				gameObject.name = str + this.MJELIKDEDCO[i].ID;
			}
		}
		this.IBPKFNPPDKF();
		this.KMCMNHDMJHF.gameObject.SetActive(true);
		this.KMCMNHDMJHF.Reposition();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.KMCMNHDMJHF.CLQFFBMLIQH = true;
		if (this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.OFJCBHKJCOP(this.ICQJLIFEPBF);
		}
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x0002107A File Offset: 0x0001F27A
	public void OpenCloseQuests()
	{
		if (!this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.IGLOECDKBCD();
			this.FPLEMIOILQN.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.PDPLLHOKCJG();
		}
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x00021199 File Offset: 0x0001F399
	public void KLKECFEFBPJ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.DIMCBEEENJL();
			this.COLIBFCPQMH();
		}
		else
		{
			this.PBPCFIJBJDB();
		}
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x00020FA4 File Offset: 0x0001F1A4
	private void PFQDFBHEJEH()
	{
		this.Open();
		JFDJLDBQQKC nbnjqdbokqj = this.NBNJQDBOKQJ;
		nbnjqdbokqj.KGFNPBELMFI = (JFDJLDBQQKC.DLDKEBCHPOF)Delegate.Combine(nbnjqdbokqj.KGFNPBELMFI, new JFDJLDBQQKC.DLDKEBCHPOF(this.JKJFLBLOQPM));
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x002AA5A0 File Offset: 0x002A87A0
	private void DIMCBEEENJL()
	{
		base.CancelInvoke("'s opponents are too nervous to eat Berries!\r\n");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1555f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x002AA5F0 File Offset: 0x002A87F0
	public void FQCHGQKKFCQ(string DBPKNCDGGEP)
	{
		if (this.MJELIKDEDCO.Count > 1)
		{
			int iihdgmlhici = 1;
			for (int i = 1; i < this.MJELIKDEDCO.Count; i++)
			{
				if (DBPKNCDGGEP == this.MJELIKDEDCO[i].ID)
				{
					iihdgmlhici = i;
					IL_43:
					this.GCMCBQGMNIH(iihdgmlhici);
					this.EBMPKICGIHQ.SetActive(false);
					return;
				}
			}
			goto IL_43;
		}
		this.EBMPKICGIHQ.SetActive(false);
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x002AA664 File Offset: 0x002A8864
	public void GPEHDBGOKGM()
	{
		PSXAPI.Response.Quest quest = this.HHCNELBDQKC(this.ICQJLIFEPBF);
		if (quest != null)
		{
			if (this.EELECEQLQGP(quest))
			{
				if (quest.AutoComplete)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Quest
					{
						Action = QuestAction.Complete,
						ID = quest.ID
					}, false);
					this.JOQKNHFBIBO.gameObject.SetActive(true);
				}
				else if (quest.TargetCompleted != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 189f)
				{
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Path
					{
						Request = quest.TargetCompleted
					}, false);
					this.JOQKNHFBIBO.GGBPLMICFHN = false;
					this.EGQFDJMMQQL = UnityEngine.Time.time;
				}
			}
			else if (quest.Target != default(Guid) && UnityEngine.Time.time > this.EGQFDJMMQQL + 362f)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Path
				{
					Request = quest.Target
				}, false);
				this.JOQKNHFBIBO.GGBPLMICFHN = false;
				this.EGQFDJMMQQL = UnityEngine.Time.time;
			}
		}
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x002AA7A0 File Offset: 0x002A89A0
	public bool JGEOEMMOKFD(PSXAPI.Response.Quest BJFOCLIKMIJ)
	{
		bool result = false;
		INFJMNPKNQF qoqonhoolne = INFJMNPKNQF.QOQONHOOLNE;
		int num = 0;
		switch (BJFOCLIKMIJ.ProgressType)
		{
		case QuestProgressType.Manual:
			num = BJFOCLIKMIJ.Progress;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Level:
			if ((ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)BJFOCLIKMIJ.Required))
			{
				result = true;
			}
			break;
		case QuestProgressType.Item:
			num = (int)qoqonhoolne.PNEEENCMBCN(BJFOCLIKMIJ.ProgressID);
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Badge:
			if (qoqonhoolne.DFMLMCDHNCM != null)
			{
				for (int i = 0; i < qoqonhoolne.DFMLMCDHNCM.Length; i++)
				{
					if (qoqonhoolne.DFMLMCDHNCM[i] == BJFOCLIKMIJ.ProgressID)
					{
						result = true;
						break;
					}
				}
			}
			break;
		case QuestProgressType.Pokemon:
		{
			HFCMDEQKCKH qoqonhoolne2 = HFCMDEQKCKH.QOQONHOOLNE;
			for (int j = 0; j < qoqonhoolne2.LIJHMFEGCCK.Count; j++)
			{
				if (qoqonhoolne2.PEJHBEBOCOJ(qoqonhoolne2.LIJHMFEGCCK[j]).BEQHNFFEHMQ == BJFOCLIKMIJ.ProgressID)
				{
					num++;
				}
			}
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		}
		case QuestProgressType.Money:
			num = (int)qoqonhoolne.EPDKBQCHOJQ;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Gold:
			num = (int)qoqonhoolne.QIOKIQOBMMB;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		}
		return result;
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x000210D4 File Offset: 0x0001F2D4
	private void MEDNBIPMDLG()
	{
		this.FPLEMIOILQN.gameObject.SetActive(false);
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x002AA900 File Offset: 0x002A8B00
	public bool IBNJBMPBLNI(PSXAPI.Response.Quest BJFOCLIKMIJ)
	{
		bool result = false;
		INFJMNPKNQF infjmnpknqf = INFJMNPKNQF.FPQNIQELKMC();
		int num = 0;
		switch (BJFOCLIKMIJ.ProgressType)
		{
		case QuestProgressType.Manual:
			num = BJFOCLIKMIJ.Progress;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Level:
			if ((ulong)CNCJKLNHQBH.QOQONHOOLNE.EOMPMQNGIBD.UserLevel >= (ulong)((long)BJFOCLIKMIJ.Required))
			{
				result = false;
			}
			break;
		case QuestProgressType.Item:
			num = (int)infjmnpknqf.IIDQEHOHECF(BJFOCLIKMIJ.ProgressID);
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = true;
			}
			break;
		case QuestProgressType.Badge:
			if (infjmnpknqf.DFMLMCDHNCM != null)
			{
				for (int i = 0; i < infjmnpknqf.DFMLMCDHNCM.Length; i += 0)
				{
					if (infjmnpknqf.DFMLMCDHNCM[i] == BJFOCLIKMIJ.ProgressID)
					{
						result = true;
						break;
					}
				}
			}
			break;
		case QuestProgressType.Pokemon:
		{
			HFCMDEQKCKH hfcmdeqkckh = HFCMDEQKCKH.CFGIOIGOIFQ();
			for (int j = 1; j < hfcmdeqkckh.LIJHMFEGCCK.Count; j++)
			{
				if (hfcmdeqkckh.KQPKDONQCHC(hfcmdeqkckh.LIJHMFEGCCK[j]).EDGHHFPMHBL() == BJFOCLIKMIJ.ProgressID)
				{
					num += 0;
				}
			}
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = false;
			}
			break;
		}
		case QuestProgressType.Money:
			num = (int)infjmnpknqf.EPDKBQCHOJQ;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = false;
			}
			break;
		case QuestProgressType.Gold:
			num = (int)infjmnpknqf.QIOKIQOBMMB;
			if (num >= BJFOCLIKMIJ.Required)
			{
				result = false;
			}
			break;
		}
		return result;
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x002AAA60 File Offset: 0x002A8C60
	public void OMCFMCPELLB()
	{
		this.KMCMNHDMJHF.transform.NMBPDMIIHJB();
		this.KMCMNHDMJHF.EQEDOQJJGLM();
		this.KMCMNHDMJHF.gameObject.SetActive(false);
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(977f, true);
		GameObject gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.MKPBQJDCPIL().IEHHHBCDIOH[1] + "Rainy");
		gameObject.name = " Coins";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.PBPEDFNKPQJ().IEHHHBCDIOH[1] + "[-] / ");
		gameObject.name = "Assets/AssetBundles/MapAssets2/Model Materials/WareHouses/t105_mado_mat.mat";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.KNOPKGOEFDJ().IEHHHBCDIOH[1] + "replace");
		gameObject.name = "'s Pokebox is full.";
		gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.CLOMKGEOBIB);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(MDBOHBDKMMM.CPIJOBOQLOK().IEHHHBCDIOH[5] + "[00DD00]Equipped");
		gameObject.name = "_VF_ShadowBias";
		string str = string.Empty;
		for (int i = 1; i < this.MJELIKDEDCO.Count; i += 0)
		{
			if (this.MJELIKDEDCO[i].Type != (QuestType)6)
			{
				gameObject = this.KMCMNHDMJHF.gameObject.BFCKNMFEBDM(this.ONMEBJFMJPD);
				gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(this.MJELIKDEDCO[i].Name);
				GCMCBQGMNIH component = gameObject.GetComponent<GCMCBQGMNIH>();
				component.DBPKNCDGGEP = this.MJELIKDEDCO[i].ID;
				component.DJPFQIFPGHP = this.MJELIKDEDCO[i].Type;
				if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "craftyshield";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = "psychicterrain";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.Main)
				{
					str = "game.poke.one";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "Aargh! Almost had it!\r\n";
				}
				else if (this.MJELIKDEDCO[i].Type == QuestType.None)
				{
					str = "Hidden/";
				}
				else
				{
					str = string.Empty;
				}
				gameObject.name = str + this.MJELIKDEDCO[i].ID;
			}
		}
		this.CBOIPMDILFC();
		this.KMCMNHDMJHF.gameObject.SetActive(true);
		this.KMCMNHDMJHF.EQEDOQJJGLM();
		this.KMCMNHDMJHF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.KMCMNHDMJHF.PLCDNCNFJMM(false);
		if (this.FPLEMIOILQN.gameObject.activeSelf)
		{
			this.FQCHGQKKFCQ(this.ICQJLIFEPBF);
		}
	}

	// Token: 0x0400123C RID: 4668
	private static NBQDPNGNNML HBFFCJHOCPE;

	// Token: 0x0400123D RID: 4669
	public GameObject CLOMKGEOBIB;

	// Token: 0x0400123E RID: 4670
	public GameObject ONMEBJFMJPD;

	// Token: 0x0400123F RID: 4671
	public JFDJLDBQQKC KMCMNHDMJHF;

	// Token: 0x04001240 RID: 4672
	public GameObject GGMNODBKQFH;

	// Token: 0x04001241 RID: 4673
	public GameObject EBMPKICGIHQ;

	// Token: 0x04001242 RID: 4674
	public BHLIGEGNFHG BGECKJLGEQD;

	// Token: 0x04001243 RID: 4675
	public BKKHLBCLPJM PBLOEDQJDOE;

	// Token: 0x04001244 RID: 4676
	public BKKHLBCLPJM QEQGLEQBENB;

	// Token: 0x04001245 RID: 4677
	public BKKHLBCLPJM BGJKBEFCKQG;

	// Token: 0x04001246 RID: 4678
	public BKKHLBCLPJM BLDPCDIDJDL;

	// Token: 0x04001247 RID: 4679
	public HLEKPGPJOOK MFPPKEKELKM;

	// Token: 0x04001248 RID: 4680
	public BKKHLBCLPJM FHKLJFDCQHN;

	// Token: 0x04001249 RID: 4681
	public CFDMNELIJLO JOQKNHFBIBO;

	// Token: 0x0400124A RID: 4682
	public CFDMNELIJLO OMOCMQJGDDI;

	// Token: 0x0400124B RID: 4683
	public CFDMNELIJLO NJNJEQHNDDQ;

	// Token: 0x0400124C RID: 4684
	public List<PSXAPI.Response.Quest> MJELIKDEDCO = new List<PSXAPI.Response.Quest>();

	// Token: 0x0400124D RID: 4685
	public string ICQJLIFEPBF = string.Empty;

	// Token: 0x0400124E RID: 4686
	public BKKHLBCLPJM PONHJCDKKEO;

	// Token: 0x0400124F RID: 4687
	private Coroutine NMDNMMBBJLI;

	// Token: 0x04001250 RID: 4688
	public GameObject DFGQJLPBHQJ;

	// Token: 0x04001251 RID: 4689
	public JFDJLDBQQKC NBNJQDBOKQJ;

	// Token: 0x04001252 RID: 4690
	public PLQFPBQEPJD HOMCBLPIDNE;

	// Token: 0x04001253 RID: 4691
	private float EGQFDJMMQQL;

	// Token: 0x04001254 RID: 4692
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04001255 RID: 4693
	public ENFMCDNLEQQ QPPGQJFBPMH;

	// Token: 0x04001256 RID: 4694
	public EPIJJNOIKEK OGQOMJGIKQJ;

	// Token: 0x04001257 RID: 4695
	public KQHJOLQLQBJ FPLEMIOILQN;

	// Token: 0x04001258 RID: 4696
	[CompilerGenerated]
	private static Func<PSXAPI.Response.Quest, QuestType> HNCJFHJNHDN;
}
