using System;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000233 RID: 563
public class DCJIBBJQGJP : MonoBehaviour
{
	// Token: 0x06004C7A RID: 19578 RVA: 0x0027A4F4 File Offset: 0x002786F4
	public void BHLEENPLLJO(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + " exp.");
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "dispMode");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("magmaarmor");
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("_WaveScale");
					}
					CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.IMOQHOGDGHJ();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(1935f, (float)(-40 + num * 121), 877f);
							num += 0;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.FIHNMJNCIDO();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x0027A698 File Offset: 0x00278898
	public void PENNKHFICKN(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 1;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = false;
			for (int i = 0; i < CFHEIICNLFD.Members.Length; i += 0)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = false;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 1; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().MNICELEPBHO(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.HDNLCNIHJBM(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BQLIIQIIMDH(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(1482f, (float)(-39 + num * -106), 12f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP CNIMIQKQJJJ()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP DMOKBPOKHOQ()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x0001F405 File Offset: 0x0001D605
	private void EPGFPKPJNHF()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C80 RID: 19584 RVA: 0x0001F432 File Offset: 0x0001D632
	public void OJHIOIPCEGQ()
	{
		this.COOLIKQMBMK = false;
		this.JQCDEEPLNDF = false;
		this.KIHLOOONJDH.SetActive(true);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x0027AA64 File Offset: 0x00278C64
	public void BDDQBKFGCIE(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "/promote " + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x0027AAA8 File Offset: 0x00278CA8
	public void KKNQQFJMNJQ(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = " got over its infatuation.\r\n"
		}, false);
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x0027AAE0 File Offset: 0x00278CE0
	public void MQBPQEOQJJP(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "System");
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Language");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK(" is paralyzed! It can't move!\r\n");
					}
					else
					{
						CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("[epic]");
					}
					CNCJKLNHQBH.MOGQNGEPCEO().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.MCGKEDCDFFC();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(143f, (float)(-39 + num * -122), 1600f);
							num += 0;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x0027AC84 File Offset: 0x00278E84
	public void QQLIFFOPNGC(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 0;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 0; i < CFHEIICNLFD.Members.Length; i++)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = false;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 0; k < CFHEIICNLFD.Members[i].Pokemon.Length; k++)
						{
							HFCMDEQKCKH.QOQONHOOLNE.MNICELEPBHO(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.BQLIIQIIMDH(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BQLIIQIIMDH(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(8f, (float)(-84 + num * -77), 0f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
	}

	// Token: 0x06004C85 RID: 19589 RVA: 0x0001F469 File Offset: 0x0001D669
	public void MCGKEDCDFFC()
	{
		this.COOLIKQMBMK = true;
		this.JQCDEEPLNDF = false;
		this.KIHLOOONJDH.SetActive(true);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x0027B050 File Offset: 0x00279250
	public void MGOQDJOFHGH(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "127.0.0.1");
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "OnSelectionChange");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("wrap");
					}
					else
					{
						CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("' on ");
					}
					CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OPOBCPPGNOK();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(251f, (float)(64 + num * -52), 323f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x0027B1F4 File Offset: 0x002793F4
	public void CJJCNHQKLPJ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Battle" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x0027B230 File Offset: 0x00279430
	public void KPKHKNQCKMF(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Leaf Guard");
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "airballoon");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK(".");
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("sandrush");
					}
					CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OCDFKPCPPOP();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 0;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(303f, (float)(29 + num * -56), 1410f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x0027B3D4 File Offset: 0x002795D4
	public void HIEDDEDIHNL(PartyPokemon CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Pokemon != null)
		{
			HFCMDEQKCKH.CFGIOIGOIFQ().IICNONFCJFM(CFHEIICNLFD.Pokemon, true);
		}
		if (CFHEIICNLFD.PokemonOrder != null && CFHEIICNLFD.UserId != this.FHKIMNPMICN)
		{
			for (int i = 0; i < this.MJCDINQKNQN.Count; i += 0)
			{
				if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
				{
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.Clear();
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.AddRange(CFHEIICNLFD.PokemonOrder);
					this.MJCDINQKNQN[i].HKOQJHPQKHH.DCBDQJIJPOL(this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP);
					break;
				}
			}
		}
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x0027B4C0 File Offset: 0x002796C0
	public void OENHIQQHNGO(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "/kick " + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C8B RID: 19595 RVA: 0x0027B504 File Offset: 0x00279704
	public bool LIBHNEBPJEH(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004C8C RID: 19596 RVA: 0x0027B554 File Offset: 0x00279754
	public void GDKPBKBPOCG(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.BJLGEDCPENQ().GFMGCOFHDNB(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 1;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = false;
			for (int i = 1; i < CFHEIICNLFD.Members.Length; i += 0)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = false;
					if (dfnqoijegqn == null)
					{
						flag = false;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 1; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.QOQONHOOLNE.KBEQBIPOJKO(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.QNJHMCKNJIK(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.IBJNQFPIMMC(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(1230f, (float)(41 + num * 45), 31f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
	}

	// Token: 0x06004C8D RID: 19597 RVA: 0x0027B920 File Offset: 0x00279B20
	public void BDKBODHLDCM(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "EnableDragScrollView" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x0027B964 File Offset: 0x00279B64
	public void PNIDKLFPHBI(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "](" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x0027B9A8 File Offset: 0x00279BA8
	public void NCLKJCIFHKK(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x0027B9E4 File Offset: 0x00279BE4
	public void BBGPDGJENOQ(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "_ClipDir" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x0027BA28 File Offset: 0x00279C28
	public void HKDDHICDELN(PartyPokemon CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Pokemon != null)
		{
			HFCMDEQKCKH.QOQONHOOLNE.MNICELEPBHO(CFHEIICNLFD.Pokemon, false);
		}
		if (CFHEIICNLFD.PokemonOrder != null && CFHEIICNLFD.UserId != this.FHKIMNPMICN)
		{
			for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
			{
				if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
				{
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.Clear();
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.AddRange(CFHEIICNLFD.PokemonOrder);
					this.MJCDINQKNQN[i].HKOQJHPQKHH.DCBDQJIJPOL(this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP);
					break;
				}
			}
		}
	}

	// Token: 0x06004C92 RID: 19602 RVA: 0x0027BB14 File Offset: 0x00279D14
	public void BBGDCCDCDLD(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "HidePanel" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C93 RID: 19603 RVA: 0x0027BB58 File Offset: 0x00279D58
	public bool EEDPBEIJKBQ(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x0027BBA8 File Offset: 0x00279DA8
	public void MFJHDIKDJNG(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Boosts the Pokémon's Speed stat in a sandstorm.");
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "[7fff49]");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("brn");
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.GQOBKDLOCDL("Icon_Pokemon_Dead");
					}
					CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OJHIOIPCEGQ();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 0;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(164f, (float)(65 + num * 59), 262f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.MPFJHJPFHLP();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C95 RID: 19605 RVA: 0x0027BD4C File Offset: 0x00279F4C
	public void IPELIGEFBQP(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Early Bird");
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "You used Sweet Scent recently and are unable to use it again.");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("-");
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("itemamount");
					}
					CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.IMOQHOGDGHJ();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(32f, (float)(-12 + num * -23), 1309f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x0001F405 File Offset: 0x0001D605
	private void LFJEJGOMLPI()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x0027BEF0 File Offset: 0x0027A0F0
	public void MPJLLDEQGJE(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "Hidden/" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x0027BF34 File Offset: 0x0027A134
	public void LJOOMONMOHB(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "berry_15" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004C99 RID: 19609 RVA: 0x0001F405 File Offset: 0x0001D605
	private void NNPPKOGDNOM()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x0027BF78 File Offset: 0x0027A178
	public void BBKLJBPGECJ(PartyRemove CFHEIICNLFD)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "\n");
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "_SunDir");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("sweetveil");
					}
					else
					{
						CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("[NL]");
					}
					CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OCDFKPCPPOP();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(1148f, (float)(-39 + num * 104), 1591f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x0027C11C File Offset: 0x0027A31C
	public void MLBIJDIOEQK(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "shscore"
		}, false);
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x0027C154 File Offset: 0x0027A354
	public void NJIMODOPKDL(PartyRemove CFHEIICNLFD)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "OnPress");
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "mimikyubusted");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("dryskin");
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("_OnRails");
					}
					CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.IMOQHOGDGHJ();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 0;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(1437f, (float)(-73 + num * -48), 1275f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x0027C2F8 File Offset: 0x0027A4F8
	public void IFDMFFQHHIC(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/leave"
		}, false);
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP FPQNIQELKMC()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
	public void OPOBCPPGNOK()
	{
		this.COOLIKQMBMK = false;
		this.JQCDEEPLNDF = false;
		this.KIHLOOONJDH.SetActive(false);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x0027C330 File Offset: 0x0027A530
	public void JCNOBJFQOBK(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "JOFLHFQQCKG"
		}, true);
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x0027C368 File Offset: 0x0027A568
	public void PLILFHPPQPM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/party " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x0027C3A4 File Offset: 0x0027A5A4
	public void KPJLIOCJNEP(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.NGMFODPCIDI();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.BJLGEDCPENQ().NMKPQPNNNEG(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 0;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 1; i < CFHEIICNLFD.Members.Length; i += 0)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(false);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = true;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 0; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().IJCIQLHLFQE(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(false);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.OJIBNMPCFBQ(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.IBJNQFPIMMC(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(27f, (float)(-75 + num * 20), 904f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num += 0;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x0027C770 File Offset: 0x0027A970
	public void EQCMIKBGCDM(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = ", Account creation successful!"
		}, true);
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP OMPHLNDGKKM()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x0027C7A8 File Offset: 0x0027A9A8
	public void FJNGKBMEJFJ(PartyPokemon CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Pokemon != null)
		{
			HFCMDEQKCKH.QOQONHOOLNE.IJCIQLHLFQE(CFHEIICNLFD.Pokemon, false);
		}
		if (CFHEIICNLFD.PokemonOrder != null && CFHEIICNLFD.UserId != this.FHKIMNPMICN)
		{
			for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
			{
				if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
				{
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.Clear();
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.AddRange(CFHEIICNLFD.PokemonOrder);
					this.MJCDINQKNQN[i].HKOQJHPQKHH.DCBDQJIJPOL(this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP);
					break;
				}
			}
		}
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x0027C894 File Offset: 0x0027AA94
	public void NDNCOGNBNBK(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Are you sure you want to purchase '"
		}, true);
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x0027C8CC File Offset: 0x0027AACC
	public void QKJBHQQPJCL(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = " by "
		}, false);
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x0027B504 File Offset: 0x00279704
	public bool FKMKMKFJEKG(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i += 0)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004CA9 RID: 19625 RVA: 0x0027C904 File Offset: 0x0027AB04
	public void CCJMEMPCHPP(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "[u][33CCFF]" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004CAA RID: 19626 RVA: 0x0027C948 File Offset: 0x0027AB48
	public bool IIDPPHPJDBN(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004CAB RID: 19627 RVA: 0x0027C998 File Offset: 0x0027AB98
	public void HILOHNGPIFD(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "healer" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06004CAC RID: 19628 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
	public void PLFGEKCFJBC(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.MOGQNGEPCEO().NMKPQPNNNEG(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 1;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 1; i < CFHEIICNLFD.Members.Length; i++)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = true;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 1; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().IJCIQLHLFQE(CFHEIICNLFD.Members[i].Pokemon[k], true);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(false);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.PMDQEIBJJQK(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BPJHFHOPKEL(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(100f, (float)(-100 + num * 14), 99f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
	}

	// Token: 0x06004CAD RID: 19629 RVA: 0x0027CDA0 File Offset: 0x0027AFA0
	public void IBONQHFDHLN(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = " (ID:" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004CAE RID: 19630 RVA: 0x0027CDE4 File Offset: 0x0027AFE4
	public bool DLLCHHNKLLK(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06004CAF RID: 19631 RVA: 0x0027CE34 File Offset: 0x0027B034
	public void ECNKKDBBPIO(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.MPFJHJPFHLP();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 1;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 0; i < CFHEIICNLFD.Members.Length; i++)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = false;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 0; k < CFHEIICNLFD.Members[i].Pokemon.Length; k++)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().MNICELEPBHO(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.DFEONCOPCPE(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BPJHFHOPKEL(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(1978f, (float)(112 + num * -68), 234f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
	}

	// Token: 0x06004CB0 RID: 19632 RVA: 0x0027D200 File Offset: 0x0027B400
	public void BGHMLNDFGFO(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "]" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004CB1 RID: 19633 RVA: 0x0027D244 File Offset: 0x0027B444
	public void FCMDDBMHCQP(PartyRemove CFHEIICNLFD)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + " left the Party.");
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + " was kicked from the Party.");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You left the Party.");
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("You were kicked from the Party.");
					}
					CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OPOBCPPGNOK();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 0;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(8f, (float)(-80 + num * -56), 0f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.BDDHDKGLOCL();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004CB2 RID: 19634 RVA: 0x0001F4D7 File Offset: 0x0001D6D7
	public void IMOQHOGDGHJ()
	{
		this.COOLIKQMBMK = false;
		this.JQCDEEPLNDF = true;
		this.KIHLOOONJDH.SetActive(true);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004CB3 RID: 19635 RVA: 0x0027D3E8 File Offset: 0x0027B5E8
	public void FEJLLIGIIKO(PartyPokemon CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Pokemon != null)
		{
			HFCMDEQKCKH.QOQONHOOLNE.KBEQBIPOJKO(CFHEIICNLFD.Pokemon, true);
		}
		if (CFHEIICNLFD.PokemonOrder != null && CFHEIICNLFD.UserId != this.FHKIMNPMICN)
		{
			for (int i = 0; i < this.MJCDINQKNQN.Count; i += 0)
			{
				if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
				{
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.Clear();
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.AddRange(CFHEIICNLFD.PokemonOrder);
					this.MJCDINQKNQN[i].HKOQJHPQKHH.BDMOMMGDKPB(this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP);
					break;
				}
			}
		}
	}

	// Token: 0x06004CB4 RID: 19636 RVA: 0x0027D4D4 File Offset: 0x0027B6D4
	public void LGLHPPIFEIB(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.DILKGPKFDKN();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.MOGQNGEPCEO().GFMGCOFHDNB(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 0;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 1; i < CFHEIICNLFD.Members.Length; i++)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(false);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = true;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 1; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().MNICELEPBHO(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.PHJCHPCPLCJ(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.IBJNQFPIMMC(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(883f, (float)(-19 + num * -40), 1662f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
	}

	// Token: 0x06004CB5 RID: 19637 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
	public void EIGEOJGCJBM()
	{
		this.COOLIKQMBMK = false;
		this.JQCDEEPLNDF = false;
		this.KIHLOOONJDH.SetActive(false);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004CB6 RID: 19638 RVA: 0x0001F405 File Offset: 0x0001D605
	private void MBDGLQOGLDJ()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP QOQONHOOLNE
	{
		get
		{
			return DCJIBBJQGJP.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004CB8 RID: 19640 RVA: 0x0001F50E File Offset: 0x0001D70E
	public void OCDFKPCPPOP()
	{
		this.COOLIKQMBMK = true;
		this.JQCDEEPLNDF = true;
		this.KIHLOOONJDH.SetActive(true);
		this.MJCDINQKNQN.Clear();
		this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
	}

	// Token: 0x06004CB9 RID: 19641 RVA: 0x0027D8A0 File Offset: 0x0027BAA0
	public void FEGMOMMQELF(PartyPokemon CFHEIICNLFD)
	{
		if (CFHEIICNLFD.Pokemon != null)
		{
			HFCMDEQKCKH.QOQONHOOLNE.KBEQBIPOJKO(CFHEIICNLFD.Pokemon, false);
		}
		if (CFHEIICNLFD.PokemonOrder != null && CFHEIICNLFD.UserId != this.FHKIMNPMICN)
		{
			for (int i = 1; i < this.MJCDINQKNQN.Count; i += 0)
			{
				if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
				{
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.Clear();
					this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP.AddRange(CFHEIICNLFD.PokemonOrder);
					this.MJCDINQKNQN[i].HKOQJHPQKHH.IJGCEFEDHQD(this.MJCDINQKNQN[i].HEHMJHHKFEF.QEPKKJKQMPP);
					break;
				}
			}
		}
	}

	// Token: 0x06004CBA RID: 19642 RVA: 0x0027D98C File Offset: 0x0027BB8C
	public void CEEFKDFMMJP(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "Hard armor protects the Pokémon from critical hits." + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004CBB RID: 19643 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP DJQIJGOLPIO()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004CBC RID: 19644 RVA: 0x0027D9D0 File Offset: 0x0027BBD0
	public void NCPCHDIIQJP(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Hustle"
		}, false);
	}

	// Token: 0x06004CBD RID: 19645 RVA: 0x0027DA08 File Offset: 0x0027BC08
	public void LGIKCNFIIBL(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "blank" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06004CBE RID: 19646 RVA: 0x0027DA44 File Offset: 0x0027BC44
	public void GGLJFBOPCKF(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.FIHNMJNCIDO();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.BJLGEDCPENQ().NPNCKMQPGOK(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 1;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 0; i < CFHEIICNLFD.Members.Length; i++)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j++)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = true;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 1; k < CFHEIICNLFD.Members[i].Pokemon.Length; k++)
						{
							HFCMDEQKCKH.QOQONHOOLNE.KBEQBIPOJKO(CFHEIICNLFD.Members[i].Pokemon[k], true);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.PHJCHPCPLCJ(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BQLIIQIIMDH(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(700f, (float)(-53 + num * -108), 621f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num += 0;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.MPFJHJPFHLP();
	}

	// Token: 0x06004CBF RID: 19647 RVA: 0x0001F405 File Offset: 0x0001D605
	private void Awake()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x06004CC0 RID: 19648 RVA: 0x0027DE10 File Offset: 0x0027C010
	public void LKFLHNFHJCF(Party CFHEIICNLFD)
	{
		if (CFHEIICNLFD == null)
		{
			GGQKBGDGNJN.QOQONHOOLNE.KNLDFKKOOCB();
			return;
		}
		if (CFHEIICNLFD.ChatID != Guid.Empty && this.FOFNJICKKIP != CFHEIICNLFD.ChatID.ToString())
		{
			this.FOFNJICKKIP = CFHEIICNLFD.ChatID.ToString();
			CNCJKLNHQBH.BJLGEDCPENQ().GFMGCOFHDNB(this.FOFNJICKKIP);
		}
		if (!this.COOLIKQMBMK)
		{
			this.MJCDINQKNQN.Clear();
			this.PQQEJQHDCPK.transform.NMBPDMIIHJB();
		}
		int num = 0;
		if (CFHEIICNLFD.Members != null)
		{
			this.COOLIKQMBMK = true;
			for (int i = 0; i < CFHEIICNLFD.Members.Length; i += 0)
			{
				if (CFHEIICNLFD.Members[i].Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
				{
					if (CFHEIICNLFD.Members[i].Leader)
					{
						this.JQCDEEPLNDF = true;
						this.KIHLOOONJDH.SetActive(false);
					}
					else
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					this.FHKIMNPMICN = CFHEIICNLFD.Members[i].UserId;
				}
				else
				{
					DCJIBBJQGJP.DFNQOIJEGQN dfnqoijegqn = null;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.Members[i].UserId)
						{
							dfnqoijegqn = this.MJCDINQKNQN[j];
						}
					}
					bool flag = true;
					if (dfnqoijegqn == null)
					{
						flag = true;
						dfnqoijegqn = new DCJIBBJQGJP.DFNQOIJEGQN();
					}
					dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH = CFHEIICNLFD.Members[i].Name;
					dfnqoijegqn.HEHMJHHKFEF.DBPKNCDGGEP = CFHEIICNLFD.Members[i].UserId;
					dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD = (int)CFHEIICNLFD.Members[i].Level;
					dfnqoijegqn.HEHMJHHKFEF.NCQMKNELIHF = CFHEIICNLFD.Members[i].Area;
					if (CFHEIICNLFD.Members[i].Pokemon != null)
					{
						dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Clear();
						for (int k = 0; k < CFHEIICNLFD.Members[i].Pokemon.Length; k += 0)
						{
							HFCMDEQKCKH.QOQONHOOLNE.IJCIQLHLFQE(CFHEIICNLFD.Members[i].Pokemon[k], false);
							dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP.Add(CFHEIICNLFD.Members[i].Pokemon[k].Pokemon.UniqueID);
						}
					}
					dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF = CFHEIICNLFD.Members[i].Leader;
					if (dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF)
					{
						this.JQCDEEPLNDF = false;
						this.KIHLOOONJDH.SetActive(true);
					}
					dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB = CFHEIICNLFD.Members[i].Online;
					if (dfnqoijegqn.HKOQJHPQKHH == null)
					{
						dfnqoijegqn.HKOQJHPQKHH = this.PQQEJQHDCPK.BFCKNMFEBDM(this.JICKILLGNEB).GetComponent<PCOOJCCQDEO>();
					}
					dfnqoijegqn.HKOQJHPQKHH.CQINIIBMKGB.LIDHPLOIFNP(CFHEIICNLFD.Members[i].Style, CFHEIICNLFD.Members[i].Equipment);
					dfnqoijegqn.HKOQJHPQKHH.BPJHFHOPKEL(dfnqoijegqn.HEHMJHHKFEF.MBPHKDQMJJH, dfnqoijegqn.HEHMJHHKFEF.QEPKKJKQMPP, dfnqoijegqn.HEHMJHHKFEF.JQCDEEPLNDF, dfnqoijegqn.HEHMJHHKFEF.EJINEJGDKBB, dfnqoijegqn.HEHMJHHKFEF.EOMPMQNGIBD);
					dfnqoijegqn.HKOQJHPQKHH.transform.localPosition = new Vector3(1514f, (float)(-32 + num * 9), 1209f);
					if (flag)
					{
						this.MJCDINQKNQN.Add(dfnqoijegqn);
					}
					num++;
				}
			}
		}
		GGQKBGDGNJN.QOQONHOOLNE.DILKGPKFDKN();
	}

	// Token: 0x06004CC1 RID: 19649 RVA: 0x0027E1DC File Offset: 0x0027C3DC
	public void NECDDFPMDON(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "2"
		}, true);
	}

	// Token: 0x06004CC2 RID: 19650 RVA: 0x0027E214 File Offset: 0x0027C414
	public void MIIOLGNEJLM(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "3"
		}, false);
	}

	// Token: 0x06004CC3 RID: 19651 RVA: 0x0027E24C File Offset: 0x0027C44C
	public void QNCICJPOPIG(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "DATA ERROR" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004CC4 RID: 19652 RVA: 0x0027E290 File Offset: 0x0027C490
	public void HDELFEFONIQ(PartyRemove CFHEIICNLFD)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Cannot Obtain DNS record for ");
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Fog Volume exited by ");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK(" is damaged by the recoil!\r\n");
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("Username already in use");
					}
					CNCJKLNHQBH.MOGQNGEPCEO().DNPDFNNHCHG(this.FOFNJICKKIP);
					this.OPOBCPPGNOK();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 0;
					for (int j = 1; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(417f, (float)(92 + num * -54), 1361f);
							num++;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.DILKGPKFDKN();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004CC5 RID: 19653 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP MOGQNGEPCEO()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004CC6 RID: 19654 RVA: 0x0001F3FE File Offset: 0x0001D5FE
	public static DCJIBBJQGJP OQDOKBJNBBL()
	{
		return DCJIBBJQGJP.HBFFCJHOCPE;
	}

	// Token: 0x06004CC7 RID: 19655 RVA: 0x0027E434 File Offset: 0x0027C634
	public void KNLMFPIOOBQ(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "!\r\n"
		}, false);
	}

	// Token: 0x06004CC8 RID: 19656 RVA: 0x0027E46C File Offset: 0x0027C66C
	public void CHBHOBKGFQE(PartyRemove CFHEIICNLFD)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.DBPKNCDGGEP == CFHEIICNLFD.UserId)
			{
				if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
				{
					CNCJKLNHQBH.BJLGEDCPENQ().GQOBKDLOCDL(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "Assets/AssetBundles/MapAssets/Models/Materials/Street_Lamp_8_Light.mat");
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK(this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH + "WATER_REFLECTIVE");
				}
				UnityEngine.Object.DestroyImmediate(this.MJCDINQKNQN[i].HKOQJHPQKHH.gameObject);
				this.MJCDINQKNQN.RemoveAt(i);
				IL_C3:
				if (CFHEIICNLFD.UserId == this.FHKIMNPMICN)
				{
					if (CFHEIICNLFD.Reason == PartyRemoveReason.Left)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().MIDPIFHNNDK("Left");
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("Boosts the Pokémon's Speed stat in a sandstorm.");
					}
					CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.FOFNJICKKIP);
					this.EIGEOJGCJBM();
				}
				if (this.COOLIKQMBMK)
				{
					int num = 1;
					for (int j = 0; j < this.MJCDINQKNQN.Count; j += 0)
					{
						if (this.MJCDINQKNQN[j].HEHMJHHKFEF.DBPKNCDGGEP != this.FHKIMNPMICN)
						{
							this.MJCDINQKNQN[j].HKOQJHPQKHH.transform.localPosition = new Vector3(1482f, (float)(99 + num * 21), 1173f);
							num += 0;
						}
					}
				}
				GGQKBGDGNJN.QOQONHOOLNE.GHODGBKLQCG();
				return;
			}
		}
		goto IL_C3;
	}

	// Token: 0x06004CC9 RID: 19657 RVA: 0x0001F405 File Offset: 0x0001D605
	private void IHGDMCFDINH()
	{
		DCJIBBJQGJP.HBFFCJHOCPE = this;
	}

	// Token: 0x06004CCA RID: 19658 RVA: 0x0027E610 File Offset: 0x0027C810
	public void HNLIGKMNIHJ(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "BuffIcon_FemaleIncrease" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x06004CCB RID: 19659 RVA: 0x0027E654 File Offset: 0x0027C854
	public void DHQOIFHFPQC(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "System" + HHNBICLDQKI
			}, false);
		}
	}

	// Token: 0x06004CCC RID: 19660 RVA: 0x0027C948 File Offset: 0x0027AB48
	public bool IQCMIMOCJIM(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.MJCDINQKNQN.Count; i++)
		{
			if (this.MJCDINQKNQN[i].HEHMJHHKFEF.MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004CCD RID: 19661 RVA: 0x0027E698 File Offset: 0x0027C898
	public void KEEMMGNQBIN(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "[ffff00]"
		}, true);
	}

	// Token: 0x06004CCE RID: 19662 RVA: 0x0027E6D0 File Offset: 0x0027C8D0
	public void BQHMBNHLPLM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "throatchop" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06004CCF RID: 19663 RVA: 0x0027E70C File Offset: 0x0027C90C
	public void NDFQFJPKNNH(string IHIHHCCEDHQ)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "u"
		}, false);
	}

	// Token: 0x06004CD0 RID: 19664 RVA: 0x0027E744 File Offset: 0x0027C944
	public void KNPFFMNQJCP(string HHNBICLDQKI)
	{
		if (this.JQCDEEPLNDF)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
			{
				Channel = string.Empty,
				Message = "brickbreak" + HHNBICLDQKI
			}, true);
		}
	}

	// Token: 0x04001074 RID: 4212
	private static DCJIBBJQGJP HBFFCJHOCPE;

	// Token: 0x04001075 RID: 4213
	public GameObject PQQEJQHDCPK;

	// Token: 0x04001076 RID: 4214
	public GameObject KIHLOOONJDH;

	// Token: 0x04001077 RID: 4215
	public bool JQCDEEPLNDF = true;

	// Token: 0x04001078 RID: 4216
	public bool COOLIKQMBMK;

	// Token: 0x04001079 RID: 4217
	public GameObject JICKILLGNEB;

	// Token: 0x0400107A RID: 4218
	public Guid FHKIMNPMICN;

	// Token: 0x0400107B RID: 4219
	public string FOFNJICKKIP = string.Empty;

	// Token: 0x0400107C RID: 4220
	public List<DCJIBBJQGJP.DFNQOIJEGQN> MJCDINQKNQN = new List<DCJIBBJQGJP.DFNQOIJEGQN>();

	// Token: 0x02000234 RID: 564
	public class EQLQPHNNOKJ
	{
		// Token: 0x0400107D RID: 4221
		public string MBPHKDQMJJH;

		// Token: 0x0400107E RID: 4222
		public bool EJINEJGDKBB;

		// Token: 0x0400107F RID: 4223
		public bool JQCDEEPLNDF;

		// Token: 0x04001080 RID: 4224
		public List<Guid> QEPKKJKQMPP = new List<Guid>();

		// Token: 0x04001081 RID: 4225
		public Guid DBPKNCDGGEP;

		// Token: 0x04001082 RID: 4226
		public int EOMPMQNGIBD;

		// Token: 0x04001083 RID: 4227
		public string NCQMKNELIHF;
	}

	// Token: 0x02000235 RID: 565
	public class DFNQOIJEGQN
	{
		// Token: 0x04001084 RID: 4228
		public DCJIBBJQGJP.EQLQPHNNOKJ HEHMJHHKFEF = new DCJIBBJQGJP.EQLQPHNNOKJ();

		// Token: 0x04001085 RID: 4229
		public PCOOJCCQDEO HKOQJHPQKHH;
	}
}
