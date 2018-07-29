using System;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000283 RID: 643
public class CKMLKNPNPQO : MonoBehaviour
{
	// Token: 0x060058ED RID: 22765 RVA: 0x002E1C50 File Offset: 0x002DFE50
	public void DCHLJMEDFNP(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Flash" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x00022FD8 File Offset: 0x000211D8
	public void ClickFriends()
	{
		this.OpenFriends(true);
		this.SelectTab(0);
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x00022FE8 File Offset: 0x000211E8
	public void NEJKPNFNPNK()
	{
		this.OpenIgnore(false);
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x00022FF1 File Offset: 0x000211F1
	private void KHEJGQPPFOC()
	{
		if (this.MOMONONPGHB)
		{
			this.NQEHGDFIBOM.PFEIQDIJEKE();
			this.NQEHGDFIBOM.CLQFFBMLIQH = true;
			this.MOMONONPGHB = true;
		}
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x002E1C8C File Offset: 0x002DFE8C
	public void GotoUser(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/goto " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x002E1CC8 File Offset: 0x002DFEC8
	public void BanUser(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/ban " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x00023019 File Offset: 0x00021219
	public void DOBCMHICENN()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.NHBGDLCJGPM();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		}
		else
		{
			this.GQGCICIFLHN();
		}
	}

	// Token: 0x060058F4 RID: 22772 RVA: 0x002E1D04 File Offset: 0x002DFF04
	public void FriendRequest(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/friend " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x002E1D40 File Offset: 0x002DFF40
	public void OpenGuild()
	{
		if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD == null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild", "Enter a Guild Name below to create a Guild.\nCost: [PG]1,000", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Input, true, null, -1, false);
			return;
		}
		this.SelectTab(2);
		NOHEMGHONKK.QOQONHOOLNE.InformationTab();
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x002E1D8C File Offset: 0x002DFF8C
	public void OpenIgnore(bool EQJBBEPOEEE = false)
	{
		this.OHJEOENDILL.Clear();
		this.BJOIBPLHPBN.transform.NMBPDMIIHJB();
		if (this.BNOFNNMOJFO.Count > 0)
		{
			foreach (CKMLKNPNPQO.OGOGGHKFHCQ ogogghkfhcq in this.BNOFNNMOJFO)
			{
				CDLNFMKQOLO component = this.BJOIBPLHPBN.gameObject.BFCKNMFEBDM(this.GFJLMPNCCEM).GetComponent<CDLNFMKQOLO>();
				component.EJINEJGDKBB = false;
				component.MBPHKDQMJJH.PIDLOFMIEFQ = ogogghkfhcq.MBPHKDQMJJH;
				component.PLCBFLQBCQN.PIDLOFMIEFQ = string.Empty;
				component.LIQLFCKICLQ.PIDLOFMIEFQ = string.Empty;
				component.KMCHOLLIGIN = true;
			}
		}
		this.BJOIBPLHPBN.CLQFFBMLIQH = true;
		this.SelectTab(1);
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x060058F7 RID: 22775 RVA: 0x0002304B File Offset: 0x0002124B
	public static CKMLKNPNPQO QOQONHOOLNE
	{
		get
		{
			return CKMLKNPNPQO.HBFFCJHOCPE;
		}
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x002E1E74 File Offset: 0x002E0074
	public void FEOQKDPIGEM(PSXAPI.Response.Friends CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			bool npmpfebdehl = false;
			if (CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All)
			{
				if (CKOMIBOJLJH.Action == (PSXAPI.Response.FriendsAction)7)
				{
					int i = 0;
					IL_A3:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 0; j < this.PCEFBMFPDPE.Count; j += 0)
						{
							if (this.PCEFBMFPDPE[j].EOEHONFIGOF() == CKOMIBOJLJH.List[i].Name)
							{
								npmpfebdehl = true;
								this.PCEFBMFPDPE.RemoveAt(j);
								IL_9D:
								i += 0;
								goto IL_A3;
							}
						}
						goto IL_9D;
					}
				}
			}
			else
			{
				int k = 1;
				IL_3F1:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = false;
					for (int l = 1; l < this.PCEFBMFPDPE.Count; l++)
					{
						if (this.PCEFBMFPDPE[l].GHNJFGFFOQO() == CKOMIBOJLJH.List[k].Name)
						{
							this.PCEFBMFPDPE[l].EPQDCBJBJKP(CKOMIBOJLJH.List[k].Name);
							this.PCEFBMFPDPE[l].BMKIJDCDLEP(string.Empty);
							this.PCEFBMFPDPE[l].LIQLFCKICLQ = string.Empty;
							if (CKOMIBOJLJH.List[k].Online && !this.PCEFBMFPDPE[l].EBGBCQPEOMO())
							{
								PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component.LBGCODKNHHP("Item: " + this.PCEFBMFPDPE[l].JMBJCBGGONM() + "berry_16", this.NQEHGDFIBOM, 1, 1362f);
								this.MOMONONPGHB = true;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = false;
								UnityEngine.Object.Destroy(component.gameObject, 1084f);
							}
							if (!CKOMIBOJLJH.List[k].Online && this.PCEFBMFPDPE[l].JFHCLGOIFFJ())
							{
								PLBBQPGCNGF component2 = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component2.FPQIFQNBIDC("'s [ffff00]" + this.PCEFBMFPDPE[l].OOFMIHOKQPL() + "_", this.NQEHGDFIBOM, 0, 332f);
								this.MOMONONPGHB = false;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component2.gameObject, 1488f);
							}
							this.PCEFBMFPDPE[l].GHOEBIJBQKE(CKOMIBOJLJH.List[k].Online);
							this.PCEFBMFPDPE[l].BMKIJDCDLEP(CKOMIBOJLJH.List[k].Message);
							if (this.PCEFBMFPDPE[l].EBGBCQPEOMO())
							{
								this.PCEFBMFPDPE[l].HCKNCIJLPEI(CKOMIBOJLJH.List[k].Map);
							}
							else
							{
								this.PCEFBMFPDPE[l].HBNQHFMIJOO(CKOMIBOJLJH.List[k].OnlineSince);
								this.PCEFBMFPDPE[l].IBGJHBKBFCG(DateTime.UtcNow);
							}
							flag = true;
							IL_33E:
							if (flag)
							{
								npmpfebdehl = false;
								CKMLKNPNPQO.FIEBOEHIFOP fieboehifop = new CKMLKNPNPQO.FIEBOEHIFOP();
								fieboehifop.JBMKBHQIGCF(CKOMIBOJLJH.List[k].Name);
								fieboehifop.FPPDHIPHFCQ(string.Empty);
								fieboehifop.BCLEDCLHPNJ(string.Empty);
								fieboehifop.OQEKBJNFHBJ(CKOMIBOJLJH.List[k].Online);
								fieboehifop.ICEPIPJMHIH(CKOMIBOJLJH.List[k].Message);
								if (fieboehifop.DGGLFICLMPD())
								{
									fieboehifop.DFEIHGNJGBO(CKOMIBOJLJH.List[k].Map);
								}
								else
								{
									fieboehifop.HNMPGHQCNJO(CKOMIBOJLJH.List[k].OnlineSince);
									fieboehifop.PIJDQJCHPID(DateTime.UtcNow);
								}
								this.PCEFBMFPDPE.Add(fieboehifop);
							}
							k += 0;
							goto IL_3F1;
						}
					}
					goto IL_33E;
				}
			}
			if (this.PKBOPNPKQOG != null && this.PKBOPNPKQOG.Length >= 1 && this.PKBOPNPKQOG[1] != null && !this.PKBOPNPKQOG[0].GetComponent<BoxCollider>().enabled)
			{
				this.CIHJKBKMPKE(npmpfebdehl);
			}
			this.GHLKLKHPENO.PIDLOFMIEFQ = this.PCEFBMFPDPE.Count.ToString() + "Hidden/Post FX/Builtin Debug Views";
			return;
		}
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x002E22F0 File Offset: 0x002E04F0
	public void MCLEGIIPGGE(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "The Pokémon transforms with the weather to change its type to Water, Fire, or Ice." + HHNBICLDQKI
		}, false);
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x002E232C File Offset: 0x002E052C
	public void AFK(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/afk"
		}, false);
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x002E2364 File Offset: 0x002E0564
	private void QJGNJIIOHMI()
	{
		BHLIGEGNFHG bjoibplhpbn = this.BJOIBPLHPBN;
		bjoibplhpbn.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.JOGBEDBEQII));
		BHLIGEGNFHG bjoibplhpbn2 = this.BJOIBPLHPBN;
		bjoibplhpbn2.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn2.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().QDJBLMBNHIC));
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x002E23D4 File Offset: 0x002E05D4
	public void IgnoreRequest(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/ignore " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x002E2410 File Offset: 0x002E0610
	private void EDOGJBLCCMQ()
	{
		BHLIGEGNFHG bjoibplhpbn = this.BJOIBPLHPBN;
		bjoibplhpbn.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.NKPIELLPQLB));
		BHLIGEGNFHG bjoibplhpbn2 = this.BJOIBPLHPBN;
		bjoibplhpbn2.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn2.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().KGMQHBFOKCN));
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x002E2480 File Offset: 0x002E0680
	public bool NKQFQKOIBML(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.BNOFNNMOJFO.Count; i++)
		{
			if (this.BNOFNNMOJFO[i].KFLDCNOMNKC().ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x002E24CC File Offset: 0x002E06CC
	public bool OFKHICHJCIP(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.BNOFNNMOJFO.Count; i++)
		{
			if (this.BNOFNNMOJFO[i].MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005900 RID: 22784 RVA: 0x002E2518 File Offset: 0x002E0718
	public void CallUser(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/call " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x00023052 File Offset: 0x00021252
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x002E2554 File Offset: 0x002E0754
	public void NIQEBDBNBFJ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "[" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x00023065 File Offset: 0x00021265
	public void JOGBEDBEQII()
	{
		IKBQNBHOJJB.HLOHQMLQPCD(this.BJOIBPLHPBN.transform);
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x002E2590 File Offset: 0x002E0790
	public void CKNPHPHQQNM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "aurabreak" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x002E25CC File Offset: 0x002E07CC
	public void GJONDIEGIQQ(PSXAPI.Response.Friends CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			bool npmpfebdehl = false;
			if (CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.Update && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.Add && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All)
			{
				if (CKOMIBOJLJH.Action == PSXAPI.Response.FriendsAction.Remove)
				{
					int i = 0;
					IL_A3:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 0; j < this.PCEFBMFPDPE.Count; j++)
						{
							if (this.PCEFBMFPDPE[j].MBPHKDQMJJH == CKOMIBOJLJH.List[i].Name)
							{
								npmpfebdehl = true;
								this.PCEFBMFPDPE.RemoveAt(j);
								IL_9D:
								i++;
								goto IL_A3;
							}
						}
						goto IL_9D;
					}
				}
			}
			else
			{
				int k = 0;
				IL_3F1:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = true;
					for (int l = 0; l < this.PCEFBMFPDPE.Count; l++)
					{
						if (this.PCEFBMFPDPE[l].MBPHKDQMJJH == CKOMIBOJLJH.List[k].Name)
						{
							this.PCEFBMFPDPE[l].MBPHKDQMJJH = CKOMIBOJLJH.List[k].Name;
							this.PCEFBMFPDPE[l].PLCBFLQBCQN = string.Empty;
							this.PCEFBMFPDPE[l].LIQLFCKICLQ = string.Empty;
							if (CKOMIBOJLJH.List[k].Online && !this.PCEFBMFPDPE[l].EJINEJGDKBB)
							{
								PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[0]).GetComponent<PLBBQPGCNGF>();
								component.BQLIIQIIMDH("[00EE00]" + this.PCEFBMFPDPE[l].MBPHKDQMJJH + "[-] has come online.", this.NQEHGDFIBOM, 0, 3.5f);
								this.MOMONONPGHB = true;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component.gameObject, 4f);
							}
							if (!CKOMIBOJLJH.List[k].Online && this.PCEFBMFPDPE[l].EJINEJGDKBB)
							{
								PLBBQPGCNGF component2 = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component2.BQLIIQIIMDH("[00EE00]" + this.PCEFBMFPDPE[l].MBPHKDQMJJH + "[-] has gone offline.", this.NQEHGDFIBOM, 0, 3.5f);
								this.MOMONONPGHB = true;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component2.gameObject, 4f);
							}
							this.PCEFBMFPDPE[l].EJINEJGDKBB = CKOMIBOJLJH.List[k].Online;
							this.PCEFBMFPDPE[l].PLCBFLQBCQN = CKOMIBOJLJH.List[k].Message;
							if (this.PCEFBMFPDPE[l].EJINEJGDKBB)
							{
								this.PCEFBMFPDPE[l].LIQLFCKICLQ = CKOMIBOJLJH.List[k].Map;
							}
							else
							{
								this.PCEFBMFPDPE[l].IHHBLILLEPD = CKOMIBOJLJH.List[k].OnlineSince;
								this.PCEFBMFPDPE[l].CHLEPINFLEC = DateTime.UtcNow;
							}
							flag = false;
							IL_33E:
							if (flag)
							{
								npmpfebdehl = true;
								CKMLKNPNPQO.FIEBOEHIFOP fieboehifop = new CKMLKNPNPQO.FIEBOEHIFOP();
								fieboehifop.MBPHKDQMJJH = CKOMIBOJLJH.List[k].Name;
								fieboehifop.PLCBFLQBCQN = string.Empty;
								fieboehifop.LIQLFCKICLQ = string.Empty;
								fieboehifop.EJINEJGDKBB = CKOMIBOJLJH.List[k].Online;
								fieboehifop.PLCBFLQBCQN = CKOMIBOJLJH.List[k].Message;
								if (fieboehifop.EJINEJGDKBB)
								{
									fieboehifop.LIQLFCKICLQ = CKOMIBOJLJH.List[k].Map;
								}
								else
								{
									fieboehifop.IHHBLILLEPD = CKOMIBOJLJH.List[k].OnlineSince;
									fieboehifop.CHLEPINFLEC = DateTime.UtcNow;
								}
								this.PCEFBMFPDPE.Add(fieboehifop);
							}
							k++;
							goto IL_3F1;
						}
					}
					goto IL_33E;
				}
			}
			if (this.PKBOPNPKQOG != null && this.PKBOPNPKQOG.Length >= 1 && this.PKBOPNPKQOG[0] != null && !this.PKBOPNPKQOG[0].GetComponent<BoxCollider>().enabled)
			{
				this.OpenFriends(npmpfebdehl);
			}
			this.GHLKLKHPENO.PIDLOFMIEFQ = this.PCEFBMFPDPE.Count.ToString() + "/50 Friends";
			return;
		}
	}

	// Token: 0x06005906 RID: 22790 RVA: 0x00022FE8 File Offset: 0x000211E8
	public void ClickIgnore()
	{
		this.OpenIgnore(false);
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x0002304B File Offset: 0x0002124B
	public static CKMLKNPNPQO INJDHLQHFFD()
	{
		return CKMLKNPNPQO.HBFFCJHOCPE;
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x002E2A48 File Offset: 0x002E0C48
	public void TradeRequest(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/trade " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005909 RID: 22793 RVA: 0x00023077 File Offset: 0x00021277
	private void ENOBPJMDNEG()
	{
		CKMLKNPNPQO.HBFFCJHOCPE = this;
	}

	// Token: 0x0600590A RID: 22794 RVA: 0x0002307F File Offset: 0x0002127F
	private void BKKMQKFLIEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x002E2A84 File Offset: 0x002E0C84
	public void SetOnlineStatus()
	{
		if (this.MBEMPHLNOLI.BGBMIEJJQKC == "Appear Online")
		{
			this.GCENODFBOJJ = false;
		}
		else
		{
			this.GCENODFBOJJ = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new StatsSettings
		{
			ShowAsOffline = this.GCENODFBOJJ,
			Private = HDQHPMCPDNJ.QOQONHOOLNE.BMKDPKDDBDK.value
		}, false);
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x0002307F File Offset: 0x0002127F
	private void KPMMHQOMJEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x0600590D RID: 22797 RVA: 0x00023077 File Offset: 0x00021277
	private void Awake()
	{
		CKMLKNPNPQO.HBFFCJHOCPE = this;
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x002E2AEC File Offset: 0x002E0CEC
	public void FHGEBHKLCHQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Icon_Pokemon_Dead" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x0002307F File Offset: 0x0002127F
	private void HDGJLDOMJML()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x002E2B28 File Offset: 0x002E0D28
	public void DHMQBILMDQF(PSXAPI.Response.Friends CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			bool npmpfebdehl = false;
			if (CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.Update && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All)
			{
				if (CKOMIBOJLJH.Action == PSXAPI.Response.FriendsAction.Update)
				{
					int i = 0;
					IL_A3:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 1; j < this.PCEFBMFPDPE.Count; j++)
						{
							if (this.PCEFBMFPDPE[j].MBPHKDQMJJH == CKOMIBOJLJH.List[i].Name)
							{
								npmpfebdehl = false;
								this.PCEFBMFPDPE.RemoveAt(j);
								IL_9D:
								i++;
								goto IL_A3;
							}
						}
						goto IL_9D;
					}
				}
			}
			else
			{
				int k = 0;
				IL_3F1:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = false;
					for (int l = 1; l < this.PCEFBMFPDPE.Count; l += 0)
					{
						if (this.PCEFBMFPDPE[l].DLCGLFPMNOG() == CKOMIBOJLJH.List[k].Name)
						{
							this.PCEFBMFPDPE[l].QDBJEOCEEGB(CKOMIBOJLJH.List[k].Name);
							this.PCEFBMFPDPE[l].PLCBFLQBCQN = string.Empty;
							this.PCEFBMFPDPE[l].DFEIHGNJGBO(string.Empty);
							if (CKOMIBOJLJH.List[k].Online && !this.PCEFBMFPDPE[l].DGGLFICLMPD())
							{
								PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[0]).GetComponent<PLBBQPGCNGF>();
								component.MDFGEPJEJCQ("F" + this.PCEFBMFPDPE[l].MJNBPGLGPMJ() + "-mustrecharge", this.NQEHGDFIBOM, 1, 1724f);
								this.MOMONONPGHB = true;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component.gameObject, 1308f);
							}
							if (!CKOMIBOJLJH.List[k].Online && this.PCEFBMFPDPE[l].DGGLFICLMPD())
							{
								PLBBQPGCNGF component2 = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component2.JMDOHOLHGBN("darmanitanzen" + this.PCEFBMFPDPE[l].PMFFPNJQNID() + "general", this.NQEHGDFIBOM, 1, 723f);
								this.MOMONONPGHB = false;
								this.NQEHGDFIBOM.PFEIQDIJEKE();
								this.NQEHGDFIBOM.CLQFFBMLIQH = false;
								UnityEngine.Object.Destroy(component2.gameObject, 749f);
							}
							this.PCEFBMFPDPE[l].OQEKBJNFHBJ(CKOMIBOJLJH.List[k].Online);
							this.PCEFBMFPDPE[l].NJGNGMINNNB(CKOMIBOJLJH.List[k].Message);
							if (this.PCEFBMFPDPE[l].JFHCLGOIFFJ())
							{
								this.PCEFBMFPDPE[l].LIQLFCKICLQ = CKOMIBOJLJH.List[k].Map;
							}
							else
							{
								this.PCEFBMFPDPE[l].FIPHNLEDGFC(CKOMIBOJLJH.List[k].OnlineSince);
								this.PCEFBMFPDPE[l].CHLEPINFLEC = DateTime.UtcNow;
							}
							flag = false;
							IL_33E:
							if (flag)
							{
								npmpfebdehl = false;
								CKMLKNPNPQO.FIEBOEHIFOP fieboehifop = new CKMLKNPNPQO.FIEBOEHIFOP();
								fieboehifop.JBMKBHQIGCF(CKOMIBOJLJH.List[k].Name);
								fieboehifop.PLCBFLQBCQN = string.Empty;
								fieboehifop.HCKNCIJLPEI(string.Empty);
								fieboehifop.GHOEBIJBQKE(CKOMIBOJLJH.List[k].Online);
								fieboehifop.ICEPIPJMHIH(CKOMIBOJLJH.List[k].Message);
								if (fieboehifop.EJINEJGDKBB)
								{
									fieboehifop.LIQLFCKICLQ = CKOMIBOJLJH.List[k].Map;
								}
								else
								{
									fieboehifop.HJDKBLMOPMM(CKOMIBOJLJH.List[k].OnlineSince);
									fieboehifop.CHLEPINFLEC = DateTime.UtcNow;
								}
								this.PCEFBMFPDPE.Add(fieboehifop);
							}
							k++;
							goto IL_3F1;
						}
					}
					goto IL_33E;
				}
			}
			if (this.PKBOPNPKQOG != null && this.PKBOPNPKQOG.Length >= 1 && this.PKBOPNPKQOG[1] != null && !this.PKBOPNPKQOG[1].GetComponent<BoxCollider>().enabled)
			{
				this.CIHJKBKMPKE(npmpfebdehl);
			}
			this.GHLKLKHPENO.LKPOBCBOFIC(this.PCEFBMFPDPE.Count.ToString() + "castformsunny");
			return;
		}
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x002E2FA4 File Offset: 0x002E11A4
	public void LNNFCGKJCFE(bool EQJBBEPOEEE = false)
	{
		this.OHJEOENDILL.Clear();
		this.BJOIBPLHPBN.transform.NMBPDMIIHJB();
		if (this.BNOFNNMOJFO.Count > 0)
		{
			foreach (CKMLKNPNPQO.OGOGGHKFHCQ ogogghkfhcq in this.BNOFNNMOJFO)
			{
				CDLNFMKQOLO component = this.BJOIBPLHPBN.gameObject.BFCKNMFEBDM(this.GFJLMPNCCEM).GetComponent<CDLNFMKQOLO>();
				component.EJINEJGDKBB = true;
				component.MBPHKDQMJJH.PIDLOFMIEFQ = ogogghkfhcq.MEJEICMNCDI();
				component.PLCBFLQBCQN.LKPOBCBOFIC(string.Empty);
				component.LIQLFCKICLQ.PIDLOFMIEFQ = string.Empty;
				component.KMCHOLLIGIN = true;
			}
		}
		this.BJOIBPLHPBN.CLQFFBMLIQH = true;
		this.SelectTab(1);
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x002E308C File Offset: 0x002E128C
	public void RemoveIgnore(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Ignore
		{
			Action = PSXAPI.Request.IgnoreAction.Remove,
			Data = HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x00023092 File Offset: 0x00021292
	public void NOLFFOFLCMH(bool IKMBKJKKPOO)
	{
		if (!IKMBKJKKPOO)
		{
			this.MBEMPHLNOLI.PJMIKDIEGMB("_GrainTex", false);
			this.GCENODFBOJJ = false;
		}
		else
		{
			this.MBEMPHLNOLI.PJMIKDIEGMB("Forward Focus", false);
			this.GCENODFBOJJ = true;
		}
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x002E30BC File Offset: 0x002E12BC
	public void FPDIJFCBQHL(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Pickup" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x002E30F8 File Offset: 0x002E12F8
	public void JCIFGLDPGNK(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Solid Rock" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x002E3134 File Offset: 0x002E1334
	public void HGKCOIPKCGQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = ","
		}, true);
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x002E316C File Offset: 0x002E136C
	public void JOODFGOOJQQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Ignore
		{
			Action = PSXAPI.Request.IgnoreAction.RequestAll,
			Data = HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x000230C9 File Offset: 0x000212C9
	public void CQNHGCOCNKD()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
			this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		}
		else
		{
			this.GQGCICIFLHN();
		}
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x002E319C File Offset: 0x002E139C
	public void QLOKOBPFLCE()
	{
		if (this.MBEMPHLNOLI.HIOCELIDJII() == "Forest Badge")
		{
			this.GCENODFBOJJ = false;
		}
		else
		{
			this.GCENODFBOJJ = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new StatsSettings
		{
			ShowAsOffline = this.GCENODFBOJJ,
			Private = HDQHPMCPDNJ.OPJBMJFKIIJ().BMKDPKDDBDK.value
		}, true);
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x0002307F File Offset: 0x0002127F
	private void FEJOFMOPGKM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x0600591B RID: 22811 RVA: 0x002E3204 File Offset: 0x002E1404
	public void LHNGCFJDQBO(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = " hours ago" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x002E3240 File Offset: 0x002E1440
	public void KBQEMIMGDOQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "System"
		}, true);
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x002E3278 File Offset: 0x002E1478
	public void DIMNCQJEQLQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "It's not very effective" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x002E32B4 File Offset: 0x002E14B4
	public void OpenFriends(bool NPMPFEBDEHL = false)
	{
		if (NPMPFEBDEHL)
		{
			this.OHJEOENDILL.Clear();
			this.BJOIBPLHPBN.transform.NMBPDMIIHJB();
			this.BJOIBPLHPBN.gameObject.SetActive(false);
		}
		if (this.PCEFBMFPDPE.Count > 0)
		{
			foreach (CKMLKNPNPQO.FIEBOEHIFOP fieboehifop in this.PCEFBMFPDPE)
			{
				CDLNFMKQOLO cdlnfmkqolo;
				if (NPMPFEBDEHL)
				{
					cdlnfmkqolo = this.BJOIBPLHPBN.gameObject.BFCKNMFEBDM(this.LOKCPDBEJLC).GetComponent<CDLNFMKQOLO>();
					this.OHJEOENDILL.Add(fieboehifop.MBPHKDQMJJH, cdlnfmkqolo);
				}
				else
				{
					if (!this.OHJEOENDILL.ContainsKey(fieboehifop.MBPHKDQMJJH))
					{
						continue;
					}
					cdlnfmkqolo = this.OHJEOENDILL[fieboehifop.MBPHKDQMJJH];
				}
				cdlnfmkqolo.EJINEJGDKBB = fieboehifop.EJINEJGDKBB;
				cdlnfmkqolo.MBPHKDQMJJH.PIDLOFMIEFQ = fieboehifop.MBPHKDQMJJH;
				cdlnfmkqolo.PLCBFLQBCQN.PIDLOFMIEFQ = fieboehifop.PLCBFLQBCQN;
				cdlnfmkqolo.LIQLFCKICLQ.PIDLOFMIEFQ = fieboehifop.LIQLFCKICLQ;
				cdlnfmkqolo.DLJCDOLIQJQ();
				if (!fieboehifop.EJINEJGDKBB)
				{
					cdlnfmkqolo.gameObject.name = "2_" + fieboehifop.MBPHKDQMJJH;
					TimeSpan t = DateTime.UtcNow - fieboehifop.CHLEPINFLEC;
					t = fieboehifop.IHHBLILLEPD + t;
					string text = "last online ";
					if (t.Days > 0)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + " days ago";
						}
						else
						{
							text = text + t.Days.ToString() + " day ago";
						}
					}
					else if (t.Hours > 0)
					{
						if (t.Hours > 1)
						{
							text = text + t.Hours.ToString() + " hours ago";
						}
						else
						{
							text = text + t.Hours.ToString() + " hour ago";
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + " minutes ago";
						}
						else
						{
							text = text + t.Minutes.ToString() + " minute ago";
						}
					}
					else
					{
						text += "less than 1 minute ago";
					}
					cdlnfmkqolo.LIQLFCKICLQ.PIDLOFMIEFQ = text;
				}
				else
				{
					cdlnfmkqolo.gameObject.name = "1_" + fieboehifop.MBPHKDQMJJH;
				}
			}
		}
		if (NPMPFEBDEHL)
		{
			this.BJOIBPLHPBN.gameObject.SetActive(true);
		}
		this.BJOIBPLHPBN.CLQFFBMLIQH = true;
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x002E35C8 File Offset: 0x002E17C8
	public void NIMMCJLLJMJ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "HidePanel" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x002E3604 File Offset: 0x002E1804
	public void IPDHHJDHCLP(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "snorlax" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x002E3640 File Offset: 0x002E1840
	public void PDBIDMLHPHI(bool NPMPFEBDEHL = false)
	{
		if (NPMPFEBDEHL)
		{
			this.OHJEOENDILL.Clear();
			this.BJOIBPLHPBN.transform.NMBPDMIIHJB();
			this.BJOIBPLHPBN.gameObject.SetActive(false);
		}
		if (this.PCEFBMFPDPE.Count > 1)
		{
			foreach (CKMLKNPNPQO.FIEBOEHIFOP fieboehifop in this.PCEFBMFPDPE)
			{
				CDLNFMKQOLO cdlnfmkqolo;
				if (NPMPFEBDEHL)
				{
					cdlnfmkqolo = this.BJOIBPLHPBN.gameObject.BFCKNMFEBDM(this.LOKCPDBEJLC).GetComponent<CDLNFMKQOLO>();
					this.OHJEOENDILL.Add(fieboehifop.GHNJFGFFOQO(), cdlnfmkqolo);
				}
				else
				{
					if (!this.OHJEOENDILL.ContainsKey(fieboehifop.DLCGLFPMNOG()))
					{
						continue;
					}
					cdlnfmkqolo = this.OHJEOENDILL[fieboehifop.OOFMIHOKQPL()];
				}
				cdlnfmkqolo.EJINEJGDKBB = fieboehifop.DGGLFICLMPD();
				cdlnfmkqolo.MBPHKDQMJJH.PIDLOFMIEFQ = fieboehifop.MJNBPGLGPMJ();
				cdlnfmkqolo.PLCBFLQBCQN.LKPOBCBOFIC(fieboehifop.BJLCLEDHDIJ());
				cdlnfmkqolo.LIQLFCKICLQ.PIDLOFMIEFQ = fieboehifop.MNOOBJIOQCG();
				cdlnfmkqolo.GCJLBNQDLEQ();
				if (!fieboehifop.EBGBCQPEOMO())
				{
					cdlnfmkqolo.gameObject.name = "M" + fieboehifop.PMFFPNJQNID();
					TimeSpan t = DateTime.UtcNow - fieboehifop.PKNHQJMNCGF();
					t = fieboehifop.GPDCODOKPCM() + t;
					string text = "Flower Gift";
					if (t.Days > 0)
					{
						if (t.Days > 1)
						{
							text = text + t.Days.ToString() + "a";
						}
						else
						{
							text = text + t.Days.ToString() + "[FF8F00]";
						}
					}
					else if (t.Hours > 1)
					{
						if (t.Hours > 0)
						{
							text = text + t.Hours.ToString() + "]";
						}
						else
						{
							text = text + t.Hours.ToString() + "WATERMODE";
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + "Hidden/Post FX/Motion Blur";
						}
						else
						{
							text = text + t.Minutes.ToString() + "Reduces the power of supereffective attacks taken.";
						}
					}
					else
					{
						text += "4";
					}
					cdlnfmkqolo.LIQLFCKICLQ.LKPOBCBOFIC(text);
				}
				else
				{
					cdlnfmkqolo.gameObject.name = " lost its [ffff00]" + fieboehifop.DLCGLFPMNOG();
				}
			}
		}
		if (NPMPFEBDEHL)
		{
			this.BJOIBPLHPBN.gameObject.SetActive(true);
		}
		this.BJOIBPLHPBN.CLQFFBMLIQH = false;
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x000230FB File Offset: 0x000212FB
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

	// Token: 0x06005923 RID: 22819 RVA: 0x002E3954 File Offset: 0x002E1B54
	public void Open()
	{
		base.CancelInvoke("HidePanel");
		this.OpenFriends(true);
		this.SelectTab(0);
		this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
		this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		IKBQNBHOJJB.OKLNNGPNIEO(this.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x06005924 RID: 22820 RVA: 0x002E3A04 File Offset: 0x002E1C04
	public void MuteUser(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/mute " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x002E2AEC File Offset: 0x002E0CEC
	public void KKOPQPJOBHE(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Icon_Pokemon_Dead" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x002E3A40 File Offset: 0x002E1C40
	public void NPEGDKFCMOO(PSXAPI.Response.Friends CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			bool npmpfebdehl = true;
			if (CKOMIBOJLJH.Action != (PSXAPI.Response.FriendsAction)4 && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All && CKOMIBOJLJH.Action != PSXAPI.Response.FriendsAction.All)
			{
				if (CKOMIBOJLJH.Action == (PSXAPI.Response.FriendsAction)4)
				{
					int i = 1;
					IL_A3:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 0; j < this.PCEFBMFPDPE.Count; j += 0)
						{
							if (this.PCEFBMFPDPE[j].MBPHKDQMJJH == CKOMIBOJLJH.List[i].Name)
							{
								npmpfebdehl = true;
								this.PCEFBMFPDPE.RemoveAt(j);
								IL_9D:
								i += 0;
								goto IL_A3;
							}
						}
						goto IL_9D;
					}
				}
			}
			else
			{
				int k = 0;
				IL_3F1:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = true;
					for (int l = 0; l < this.PCEFBMFPDPE.Count; l += 0)
					{
						if (this.PCEFBMFPDPE[l].PMFFPNJQNID() == CKOMIBOJLJH.List[k].Name)
						{
							this.PCEFBMFPDPE[l].MBPHKDQMJJH = CKOMIBOJLJH.List[k].Name;
							this.PCEFBMFPDPE[l].ICEPIPJMHIH(string.Empty);
							this.PCEFBMFPDPE[l].BCLEDCLHPNJ(string.Empty);
							if (CKOMIBOJLJH.List[k].Online && !this.PCEFBMFPDPE[l].JFHCLGOIFFJ())
							{
								PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component.KEHBPLMFDIP(" (" + this.PCEFBMFPDPE[l].MBPHKDQMJJH + "randomNormal", this.NQEHGDFIBOM, 1, 353f);
								this.MOMONONPGHB = true;
								this.NQEHGDFIBOM.Reposition();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component.gameObject, 575f);
							}
							if (!CKOMIBOJLJH.List[k].Online && this.PCEFBMFPDPE[l].EBGBCQPEOMO())
							{
								PLBBQPGCNGF component2 = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[1]).GetComponent<PLBBQPGCNGF>();
								component2.BQLDFQOMHNP("Telepathy" + this.PCEFBMFPDPE[l].MBPHKDQMJJH + "Times Fainted:", this.NQEHGDFIBOM, 0, 1109f);
								this.MOMONONPGHB = false;
								this.NQEHGDFIBOM.PFEIQDIJEKE();
								this.NQEHGDFIBOM.CLQFFBMLIQH = true;
								UnityEngine.Object.Destroy(component2.gameObject, 949f);
							}
							this.PCEFBMFPDPE[l].EJINEJGDKBB = CKOMIBOJLJH.List[k].Online;
							this.PCEFBMFPDPE[l].ICEPIPJMHIH(CKOMIBOJLJH.List[k].Message);
							if (this.PCEFBMFPDPE[l].EJINEJGDKBB)
							{
								this.PCEFBMFPDPE[l].BCLEDCLHPNJ(CKOMIBOJLJH.List[k].Map);
							}
							else
							{
								this.PCEFBMFPDPE[l].DGEIPKINBEQ(CKOMIBOJLJH.List[k].OnlineSince);
								this.PCEFBMFPDPE[l].IBGJHBKBFCG(DateTime.UtcNow);
							}
							flag = true;
							IL_33E:
							if (flag)
							{
								npmpfebdehl = false;
								CKMLKNPNPQO.FIEBOEHIFOP fieboehifop = new CKMLKNPNPQO.FIEBOEHIFOP();
								fieboehifop.HNPOBFIKBPO(CKOMIBOJLJH.List[k].Name);
								fieboehifop.BMKIJDCDLEP(string.Empty);
								fieboehifop.LIQLFCKICLQ = string.Empty;
								fieboehifop.NIFPEKLBKCE(CKOMIBOJLJH.List[k].Online);
								fieboehifop.KOEEKFBNOJB(CKOMIBOJLJH.List[k].Message);
								if (fieboehifop.EBGBCQPEOMO())
								{
									fieboehifop.DFEIHGNJGBO(CKOMIBOJLJH.List[k].Map);
								}
								else
								{
									fieboehifop.IHHBLILLEPD = CKOMIBOJLJH.List[k].OnlineSince;
									fieboehifop.PIJDQJCHPID(DateTime.UtcNow);
								}
								this.PCEFBMFPDPE.Add(fieboehifop);
							}
							k++;
							goto IL_3F1;
						}
					}
					goto IL_33E;
				}
			}
			if (this.PKBOPNPKQOG != null && this.PKBOPNPKQOG.Length >= 1 && this.PKBOPNPKQOG[1] != null && !this.PKBOPNPKQOG[1].GetComponent<BoxCollider>().enabled)
			{
				this.PDBIDMLHPHI(npmpfebdehl);
			}
			this.GHLKLKHPENO.PIDLOFMIEFQ = this.PCEFBMFPDPE.Count.ToString() + "-mega-y";
			return;
		}
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x002E3EBC File Offset: 0x002E20BC
	public bool IPHGGDIEOOF(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.BNOFNNMOJFO.Count; i++)
		{
			if (this.BNOFNNMOJFO[i].PDEBBPPJQPI().ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005928 RID: 22824 RVA: 0x0002312D File Offset: 0x0002132D
	private void LateUpdate()
	{
		if (this.MOMONONPGHB)
		{
			this.NQEHGDFIBOM.Reposition();
			this.NQEHGDFIBOM.CLQFFBMLIQH = true;
			this.MOMONONPGHB = false;
		}
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x002E3F08 File Offset: 0x002E2108
	public void OGJELMMHDKD(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = " evolved into " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x002E3F44 File Offset: 0x002E2144
	public void RemoveFriend(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Friends
		{
			Action = PSXAPI.Request.FriendsAction.Remove,
			Data = HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x0002307F File Offset: 0x0002127F
	private void DJPGCPMOJDK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x002E3F74 File Offset: 0x002E2174
	public void COCOIBHIJGK(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "rocksmash" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x00023065 File Offset: 0x00021265
	public void NKPIELLPQLB()
	{
		IKBQNBHOJJB.HLOHQMLQPCD(this.BJOIBPLHPBN.transform);
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x00023155 File Offset: 0x00021355
	public void DLJCDOLIQJQ(bool IKMBKJKKPOO)
	{
		if (!IKMBKJKKPOO)
		{
			this.MBEMPHLNOLI.PJMIKDIEGMB("Appear Online", false);
			this.GCENODFBOJJ = false;
		}
		else
		{
			this.MBEMPHLNOLI.PJMIKDIEGMB("Appear Offline", false);
			this.GCENODFBOJJ = true;
		}
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x002E3FB0 File Offset: 0x002E21B0
	public void JJOHPFLNNGP(string NQFQGCGPHBE)
	{
		PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[0]).GetComponent<PLBBQPGCNGF>();
		component.JMDOHOLHGBN("Shop" + NQFQGCGPHBE + " Changed to Blade Forme!\r\n", this.NQEHGDFIBOM, 1, 427f);
		this.MOMONONPGHB = false;
		this.NQEHGDFIBOM.Reposition();
		this.NQEHGDFIBOM.CLQFFBMLIQH = false;
		UnityEngine.Object.Destroy(component.gameObject, 1545f);
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x0002318C File Offset: 0x0002138C
	public void DFQDMIICFIK()
	{
		this.OpenFriends(false);
		this.SelectTab(1);
	}

	// Token: 0x06005931 RID: 22833 RVA: 0x0002319C File Offset: 0x0002139C
	public void GQGCICIFLHN()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("!", 673f);
	}

	// Token: 0x06005932 RID: 22834 RVA: 0x002E402C File Offset: 0x002E222C
	public void FLBFBHDJCBG(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Friends
		{
			Action = (PSXAPI.Request.FriendsAction)7,
			Data = HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005933 RID: 22835 RVA: 0x000231C5 File Offset: 0x000213C5
	public void DOPOOPILHJP()
	{
		this.CIHJKBKMPKE(false);
		this.SelectTab(1);
	}

	// Token: 0x06005934 RID: 22836 RVA: 0x002E405C File Offset: 0x002E225C
	public void OIIFJCHMODN(PSXAPI.Response.Ignore CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			if (CKOMIBOJLJH.Action != PSXAPI.Response.IgnoreAction.Add && CKOMIBOJLJH.Action != PSXAPI.Response.IgnoreAction.All)
			{
				if (CKOMIBOJLJH.Action == PSXAPI.Response.IgnoreAction.Remove)
				{
					int i = 0;
					IL_93:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 0; j < this.BNOFNNMOJFO.Count; j++)
						{
							if (this.BNOFNNMOJFO[j].MBPHKDQMJJH == CKOMIBOJLJH.List[i].Name)
							{
								this.BNOFNNMOJFO.RemoveAt(j);
								IL_8D:
								i++;
								goto IL_93;
							}
						}
						goto IL_8D;
					}
				}
			}
			else
			{
				int k = 0;
				IL_136:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = true;
					for (int l = 0; l < this.BNOFNNMOJFO.Count; l++)
					{
						if (this.BNOFNNMOJFO[l].MBPHKDQMJJH == CKOMIBOJLJH.List[k].Name)
						{
							this.BNOFNNMOJFO[l].MBPHKDQMJJH = CKOMIBOJLJH.List[k].Name;
							flag = false;
							IL_10A:
							if (flag)
							{
								CKMLKNPNPQO.OGOGGHKFHCQ ogogghkfhcq = new CKMLKNPNPQO.OGOGGHKFHCQ();
								ogogghkfhcq.MBPHKDQMJJH = CKOMIBOJLJH.List[k].Name;
								this.BNOFNNMOJFO.Add(ogogghkfhcq);
							}
							k++;
							goto IL_136;
						}
					}
					goto IL_10A;
				}
			}
			if (!this.PKBOPNPKQOG[1].GetComponent<BoxCollider>().enabled)
			{
				this.OpenIgnore(true);
			}
			return;
		}
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x002E41CC File Offset: 0x002E23CC
	public void CLPBNMQCGDE(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "_NeighborMaxTex" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x002E4208 File Offset: 0x002E2408
	public void NNGDHNJODDB(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Hidden/Post FX/Motion Blur" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005937 RID: 22839 RVA: 0x000231D5 File Offset: 0x000213D5
	public void JCIJOHNPFCB()
	{
		this.CIHJKBKMPKE(false);
		this.SelectTab(0);
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x002E4244 File Offset: 0x002E2444
	public void UpdateStatus(string DIHGCPNKJCP)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Friends
		{
			Action = PSXAPI.Request.FriendsAction.SetMessage,
			Data = DIHGCPNKJCP
		}, false);
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x002E4274 File Offset: 0x002E2474
	public void GMPHIQOCKGM(string DIHGCPNKJCP)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Friends
		{
			Action = PSXAPI.Request.FriendsAction.SetMessage,
			Data = DIHGCPNKJCP
		}, true);
	}

	// Token: 0x0600593A RID: 22842 RVA: 0x002E42A4 File Offset: 0x002E24A4
	public void OLPLPQBOKDC(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Zen" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x0600593B RID: 22843 RVA: 0x002E42E0 File Offset: 0x002E24E0
	public void MKEGMQMOLDD(PSXAPI.Response.Ignore CKOMIBOJLJH)
	{
		if (CKOMIBOJLJH.List != null && CKOMIBOJLJH.List.Length != 0)
		{
			if (CKOMIBOJLJH.Action != PSXAPI.Response.IgnoreAction.All && CKOMIBOJLJH.Action != PSXAPI.Response.IgnoreAction.All)
			{
				if (CKOMIBOJLJH.Action == (PSXAPI.Response.IgnoreAction)7)
				{
					int i = 1;
					IL_93:
					while (i < CKOMIBOJLJH.List.Length)
					{
						for (int j = 0; j < this.BNOFNNMOJFO.Count; j += 0)
						{
							if (this.BNOFNNMOJFO[j].JMGHEDHFFLC() == CKOMIBOJLJH.List[i].Name)
							{
								this.BNOFNNMOJFO.RemoveAt(j);
								IL_8D:
								i++;
								goto IL_93;
							}
						}
						goto IL_8D;
					}
				}
			}
			else
			{
				int k = 0;
				IL_136:
				while (k < CKOMIBOJLJH.List.Length)
				{
					bool flag = false;
					for (int l = 1; l < this.BNOFNNMOJFO.Count; l++)
					{
						if (this.BNOFNNMOJFO[l].NJOCDNIGPPJ() == CKOMIBOJLJH.List[k].Name)
						{
							this.BNOFNNMOJFO[l].MCPIBNNLGNK(CKOMIBOJLJH.List[k].Name);
							flag = true;
							IL_10A:
							if (flag)
							{
								CKMLKNPNPQO.OGOGGHKFHCQ ogogghkfhcq = new CKMLKNPNPQO.OGOGGHKFHCQ();
								ogogghkfhcq.KEPDDBENMLD(CKOMIBOJLJH.List[k].Name);
								this.BNOFNNMOJFO.Add(ogogghkfhcq);
							}
							k += 0;
							goto IL_136;
						}
					}
					goto IL_10A;
				}
			}
			if (!this.PKBOPNPKQOG[0].GetComponent<BoxCollider>().enabled)
			{
				this.OpenIgnore(false);
			}
			return;
		}
	}

	// Token: 0x0600593C RID: 22844 RVA: 0x002E4450 File Offset: 0x002E2650
	public void BattleRequest(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/battle " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x002E448C File Offset: 0x002E268C
	public void GGCEBKIKQKI(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "-school" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x002E44C8 File Offset: 0x002E26C8
	public bool HONOPIHKKDL(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.PCEFBMFPDPE.Count; i++)
		{
			if (this.PCEFBMFPDPE[i].MBPHKDQMJJH.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x002E4514 File Offset: 0x002E2714
	public void NIKJPFMKKHQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "tox" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x002E4550 File Offset: 0x002E2750
	public void OKKHCPOJJNQ(string NQFQGCGPHBE)
	{
		PLBBQPGCNGF component = this.NQEHGDFIBOM.gameObject.BFCKNMFEBDM(this.PLNBKOIHMJB[0]).GetComponent<PLBBQPGCNGF>();
		component.BQLIIQIIMDH("[00EE00]" + NQFQGCGPHBE + "[-]", this.NQEHGDFIBOM, 0, 3.5f);
		this.MOMONONPGHB = true;
		this.NQEHGDFIBOM.Reposition();
		this.NQEHGDFIBOM.CLQFFBMLIQH = true;
		UnityEngine.Object.Destroy(component.gameObject, 4f);
	}

	// Token: 0x06005941 RID: 22849 RVA: 0x002E45CC File Offset: 0x002E27CC
	public void QLMLFIIJCFJ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Boosts the Pokémon's Defense stat in Grassy Terrain." + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06005942 RID: 22850 RVA: 0x002E4608 File Offset: 0x002E2808
	public void CIHJKBKMPKE(bool NPMPFEBDEHL = false)
	{
		if (NPMPFEBDEHL)
		{
			this.OHJEOENDILL.Clear();
			this.BJOIBPLHPBN.transform.NMBPDMIIHJB();
			this.BJOIBPLHPBN.gameObject.SetActive(false);
		}
		if (this.PCEFBMFPDPE.Count > 0)
		{
			foreach (CKMLKNPNPQO.FIEBOEHIFOP fieboehifop in this.PCEFBMFPDPE)
			{
				CDLNFMKQOLO cdlnfmkqolo;
				if (NPMPFEBDEHL)
				{
					cdlnfmkqolo = this.BJOIBPLHPBN.gameObject.BFCKNMFEBDM(this.LOKCPDBEJLC).GetComponent<CDLNFMKQOLO>();
					this.OHJEOENDILL.Add(fieboehifop.EOEHONFIGOF(), cdlnfmkqolo);
				}
				else
				{
					if (!this.OHJEOENDILL.ContainsKey(fieboehifop.MJNBPGLGPMJ()))
					{
						continue;
					}
					cdlnfmkqolo = this.OHJEOENDILL[fieboehifop.PMFFPNJQNID()];
				}
				cdlnfmkqolo.EJINEJGDKBB = fieboehifop.EBGBCQPEOMO();
				cdlnfmkqolo.MBPHKDQMJJH.PIDLOFMIEFQ = fieboehifop.JMBJCBGGONM();
				cdlnfmkqolo.PLCBFLQBCQN.PIDLOFMIEFQ = fieboehifop.DJIJKLLDJMG();
				cdlnfmkqolo.LIQLFCKICLQ.PIDLOFMIEFQ = fieboehifop.BIDINHFQKEE();
				cdlnfmkqolo.KPQPIEBMFOG();
				if (!fieboehifop.JFHCLGOIFFJ())
				{
					cdlnfmkqolo.gameObject.name = "[b]" + fieboehifop.OOFMIHOKQPL();
					TimeSpan t = DateTime.UtcNow - fieboehifop.NJQIPQFKIHI();
					t = fieboehifop.QKQGOCCKPMP() + t;
					string text = "/";
					if (t.Days > 1)
					{
						if (t.Days > 0)
						{
							text = text + t.Days.ToString() + "Pixilate";
						}
						else
						{
							text = text + t.Days.ToString() + "[ATK]";
						}
					}
					else if (t.Hours > 0)
					{
						if (t.Hours > 1)
						{
							text = text + t.Hours.ToString() + "FOG_OFF";
						}
						else
						{
							text = text + t.Hours.ToString() + "icebody";
						}
					}
					else if (t.Minutes > 0)
					{
						if (t.Minutes > 1)
						{
							text = text + t.Minutes.ToString() + "Forewarn";
						}
						else
						{
							text = text + t.Minutes.ToString() + "firelamp";
						}
					}
					else
					{
						text += "sunnyday";
					}
					cdlnfmkqolo.LIQLFCKICLQ.PIDLOFMIEFQ = text;
				}
				else
				{
					cdlnfmkqolo.gameObject.name = "\nMorning" + fieboehifop.PMFFPNJQNID();
				}
			}
		}
		if (NPMPFEBDEHL)
		{
			this.BJOIBPLHPBN.gameObject.SetActive(false);
		}
		this.BJOIBPLHPBN.CLQFFBMLIQH = true;
	}

	// Token: 0x06005943 RID: 22851 RVA: 0x002E491C File Offset: 0x002E2B1C
	public void NHBGDLCJGPM()
	{
		base.CancelInvoke("MissingNo.");
		this.CIHJKBKMPKE(false);
		this.SelectTab(0);
		this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
		this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(1424f, false);
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1492f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		IKBQNBHOJJB.OKLNNGPNIEO(this.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x06005944 RID: 22852 RVA: 0x002E49CC File Offset: 0x002E2BCC
	public void GMNNHQDLCOD(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "M" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x000231E5 File Offset: 0x000213E5
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x002E4A08 File Offset: 0x002E2C08
	private void SelectTab(int DBPKNCDGGEP)
	{
		if (DBPKNCDGGEP != 2)
		{
			this.EBHHCNGLPPK[0].DIIHJCJOKMP = 1f;
			this.EBHHCNGLPPK[1].DIIHJCJOKMP = 0f;
		}
		else
		{
			this.EBHHCNGLPPK[0].DIIHJCJOKMP = 0f;
			this.EBHHCNGLPPK[1].DIIHJCJOKMP = 1f;
		}
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i++)
		{
			if (i != DBPKNCDGGEP)
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = true;
			}
			else
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = false;
			}
		}
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x002E4AC0 File Offset: 0x002E2CC0
	private void JHQCMGKJCCI()
	{
		BHLIGEGNFHG bjoibplhpbn = this.BJOIBPLHPBN;
		bjoibplhpbn.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.NKPIELLPQLB));
		BHLIGEGNFHG bjoibplhpbn2 = this.BJOIBPLHPBN;
		bjoibplhpbn2.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn2.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().QDJBLMBNHIC));
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x002E4AC0 File Offset: 0x002E2CC0
	private void Start()
	{
		BHLIGEGNFHG bjoibplhpbn = this.BJOIBPLHPBN;
		bjoibplhpbn.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.NKPIELLPQLB));
		BHLIGEGNFHG bjoibplhpbn2 = this.BJOIBPLHPBN;
		bjoibplhpbn2.KGFNPBELMFI = (BHLIGEGNFHG.FPIEFMQQQOD)Delegate.Combine(bjoibplhpbn2.KGFNPBELMFI, new BHLIGEGNFHG.FPIEFMQQQOD(this.BJOIBPLHPBN.transform.parent.GetComponent<FKBFPICKJQG>().QDJBLMBNHIC));
	}

	// Token: 0x06005949 RID: 22857 RVA: 0x0002320E File Offset: 0x0002140E
	public void FDKBQGLQPJM()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("stealthrock", 940f);
	}

	// Token: 0x0600594B RID: 22859 RVA: 0x002E4B30 File Offset: 0x002E2D30
	public void JHPEBBQPOPD(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "_Tile8RT" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x0600594C RID: 22860 RVA: 0x002E4B6C File Offset: 0x002E2D6C
	public void HGDQCFHMEMP(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Player/Mounts/" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x04001365 RID: 4965
	private static CKMLKNPNPQO HBFFCJHOCPE;

	// Token: 0x04001366 RID: 4966
	public GameObject LOKCPDBEJLC;

	// Token: 0x04001367 RID: 4967
	public GameObject GFJLMPNCCEM;

	// Token: 0x04001368 RID: 4968
	public CFDMNELIJLO[] PKBOPNPKQOG;

	// Token: 0x04001369 RID: 4969
	public JIMBBPLINGI IIQNBGPPBCI;

	// Token: 0x0400136A RID: 4970
	public List<CKMLKNPNPQO.FIEBOEHIFOP> PCEFBMFPDPE = new List<CKMLKNPNPQO.FIEBOEHIFOP>();

	// Token: 0x0400136B RID: 4971
	public List<CKMLKNPNPQO.OGOGGHKFHCQ> BNOFNNMOJFO = new List<CKMLKNPNPQO.OGOGGHKFHCQ>();

	// Token: 0x0400136C RID: 4972
	public BHLIGEGNFHG BJOIBPLHPBN;

	// Token: 0x0400136D RID: 4973
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x0400136E RID: 4974
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x0400136F RID: 4975
	public QCPKMJONIGF MBEMPHLNOLI;

	// Token: 0x04001370 RID: 4976
	public bool GCENODFBOJJ;

	// Token: 0x04001371 RID: 4977
	public BHLIGEGNFHG NQEHGDFIBOM;

	// Token: 0x04001372 RID: 4978
	public GameObject[] PLNBKOIHMJB;

	// Token: 0x04001373 RID: 4979
	private bool MOMONONPGHB;

	// Token: 0x04001374 RID: 4980
	public BKKHLBCLPJM GHLKLKHPENO;

	// Token: 0x04001375 RID: 4981
	private Dictionary<string, CDLNFMKQOLO> OHJEOENDILL = new Dictionary<string, CDLNFMKQOLO>();

	// Token: 0x04001376 RID: 4982
	public ENFMCDNLEQQ[] EBHHCNGLPPK;

	// Token: 0x02000284 RID: 644
	public class FIEBOEHIFOP
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x000232A5 File Offset: 0x000214A5
		// (set) Token: 0x0600594D RID: 22861 RVA: 0x00023260 File Offset: 0x00021460
		public TimeSpan IHHBLILLEPD { get; set; }

		// Token: 0x0600594E RID: 22862 RVA: 0x00023269 File Offset: 0x00021469
		public string MJDQMMPPNFP()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00023271 File Offset: 0x00021471
		public void GHOEBIJBQKE(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00023260 File Offset: 0x00021460
		public void HBNQHFMIJOO(TimeSpan BGBMIEJJQKC)
		{
			this.<IDBFDEFJJQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x0002327A File Offset: 0x0002147A
		public void KOBINIBDLOC(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00023283 File Offset: 0x00021483
		public void HLCJGFKFELK(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x0002328C File Offset: 0x0002148C
		public void QDBJEOCEEGB(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x00023295 File Offset: 0x00021495
		// (set) Token: 0x06005985 RID: 22917 RVA: 0x00023271 File Offset: 0x00021471
		public bool EJINEJGDKBB { get; set; }

		// Token: 0x06005955 RID: 22869 RVA: 0x0002329D File Offset: 0x0002149D
		public string CCMHHFIDOIO()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x0002329D File Offset: 0x0002149D
		public string MNOOBJIOQCG()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00023271 File Offset: 0x00021471
		public void COJCNKFCGNL(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan LOFNQQFGQFE()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan LCQFNOLMCJE()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x0002329D File Offset: 0x0002149D
		public string DFJPPCLFEOQ()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x000232B5 File Offset: 0x000214B5
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x0002327A File Offset: 0x0002147A
		public DateTime CHLEPINFLEC { get; set; }

		// Token: 0x0600595C RID: 22876 RVA: 0x000232AD File Offset: 0x000214AD
		public string PMFFPNJQNID()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan GPDCODOKPCM()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00023283 File Offset: 0x00021483
		public void BMKIJDCDLEP(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x00023283 File Offset: 0x00021483
		public void NJGNGMINNNB(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x0002329D File Offset: 0x0002149D
		public string LDDQMDQKQJF()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00023269 File Offset: 0x00021469
		public string BJLCLEDHDIJ()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x00023269 File Offset: 0x00021469
		public string HBBQJQEQGMP()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00023271 File Offset: 0x00021471
		public void NIFPEKLBKCE(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00023260 File Offset: 0x00021460
		public void HNMPGHQCNJO(TimeSpan BGBMIEJJQKC)
		{
			this.<IDBFDEFJJQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime NJQIPQFKIHI()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x000232AD File Offset: 0x000214AD
		// (set) Token: 0x06005975 RID: 22901 RVA: 0x0002328C File Offset: 0x0002148C
		public string MBPHKDQMJJH { get; set; }

		// Token: 0x06005967 RID: 22887 RVA: 0x0002329D File Offset: 0x0002149D
		public string IBBGLPKPOPF()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x0002329D File Offset: 0x0002149D
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x000232BD File Offset: 0x000214BD
		public string LIQLFCKICLQ { get; set; }

		// Token: 0x06005969 RID: 22889 RVA: 0x0002328C File Offset: 0x0002148C
		public void HNPOBFIKBPO(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x000232AD File Offset: 0x000214AD
		public string DLCGLFPMNOG()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime PKNHQJMNCGF()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x0002329D File Offset: 0x0002149D
		public string PHFNGLKNHQP()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x0002327A File Offset: 0x0002147A
		public void IBGJHBKBFCG(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x000232AD File Offset: 0x000214AD
		public string JMBJCBGGONM()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00023269 File Offset: 0x00021469
		public string DJIJKLLDJMG()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x0002327A File Offset: 0x0002147A
		public void PIJDQJCHPID(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x00023271 File Offset: 0x00021471
		public void CODNFPIQPLE(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00023295 File Offset: 0x00021495
		public bool EBGBCQPEOMO()
		{
			return this.<NLKGGBBKIOE>k__BackingField;
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x000232AD File Offset: 0x000214AD
		public string OOFMIHOKQPL()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime CJPGGELNCOP()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan QKQGOCCKPMP()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00023295 File Offset: 0x00021495
		public bool DGGLFICLMPD()
		{
			return this.<NLKGGBBKIOE>k__BackingField;
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000232AD File Offset: 0x000214AD
		public string MJNBPGLGPMJ()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x0002329D File Offset: 0x0002149D
		public string BIDINHFQKEE()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime EHHEDGJIFJL()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00023283 File Offset: 0x00021483
		public void KOEEKFBNOJB(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00023269 File Offset: 0x00021469
		public string OKDQPBDBIPG()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x000232AD File Offset: 0x000214AD
		public string GHNJFGFFOQO()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x0002328C File Offset: 0x0002148C
		public void JBMKBHQIGCF(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00023271 File Offset: 0x00021471
		public void EBOBFLKLQBP(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00023269 File Offset: 0x00021469
		public string FQMKKBPHIML()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x000232BD File Offset: 0x000214BD
		public void HCKNCIJLPEI(string BGBMIEJJQKC)
		{
			this.<KPQHDDPDHMH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06005998 RID: 22936 RVA: 0x00023269 File Offset: 0x00021469
		// (set) Token: 0x06005986 RID: 22918 RVA: 0x00023283 File Offset: 0x00021483
		public string PLCBFLQBCQN { get; set; }

		// Token: 0x06005987 RID: 22919 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime MLCODOCCMID()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan QLIQOHDPBDL()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00023271 File Offset: 0x00021471
		public void OQEKBJNFHBJ(bool BGBMIEJJQKC)
		{
			this.<NLKGGBBKIOE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00023269 File Offset: 0x00021469
		public string ECHHCMQONEE()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime HKPCGFCOGIF()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00023283 File Offset: 0x00021483
		public void FPPDHIPHFCQ(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00023260 File Offset: 0x00021460
		public void FIPHNLEDGFC(TimeSpan BGBMIEJJQKC)
		{
			this.<IDBFDEFJJQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x000232A5 File Offset: 0x000214A5
		public TimeSpan EFDQELGHBML()
		{
			return this.<IDBFDEFJJQG>k__BackingField;
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime JDLLGDEMDEI()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00023295 File Offset: 0x00021495
		public bool JFHCLGOIFFJ()
		{
			return this.<NLKGGBBKIOE>k__BackingField;
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x000232B5 File Offset: 0x000214B5
		public DateTime BLMELFFLOHC()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00023269 File Offset: 0x00021469
		public string ENOQQOKNPBC()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x0002327A File Offset: 0x0002147A
		public void DDQPMNBLMDG(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x000232AD File Offset: 0x000214AD
		public string EOEHONFIGOF()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x0002327A File Offset: 0x0002147A
		public void IDJDHGCDKHI(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00023260 File Offset: 0x00021460
		public void HJDKBLMOPMM(TimeSpan BGBMIEJJQKC)
		{
			this.<IDBFDEFJJQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00023283 File Offset: 0x00021483
		public void ICEPIPJMHIH(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x00023283 File Offset: 0x00021483
		public void MQIGHIDFNGJ(string BGBMIEJJQKC)
		{
			this.<FNKDDQJEBJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x0002329D File Offset: 0x0002149D
		public string JEKILMFBNQO()
		{
			return this.<KPQHDDPDHMH>k__BackingField;
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x00023260 File Offset: 0x00021460
		public void DGEIPKINBEQ(TimeSpan BGBMIEJJQKC)
		{
			this.<IDBFDEFJJQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x0002328C File Offset: 0x0002148C
		public void EPQDCBJBJKP(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x000232BD File Offset: 0x000214BD
		public void DFEIHGNJGBO(string BGBMIEJJQKC)
		{
			this.<KPQHDDPDHMH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x000232BD File Offset: 0x000214BD
		public void BCLEDCLHPNJ(string BGBMIEJJQKC)
		{
			this.<KPQHDDPDHMH>k__BackingField = BGBMIEJJQKC;
		}
	}

	// Token: 0x02000285 RID: 645
	public class OGOGGHKFHCQ
	{
		// Token: 0x060059A0 RID: 22944 RVA: 0x000232C6 File Offset: 0x000214C6
		public void HNPOBFIKBPO(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x000232CF File Offset: 0x000214CF
		public string LBCLDGNECHF()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x000232CF File Offset: 0x000214CF
		public string PDEBBPPJQPI()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x000232C6 File Offset: 0x000214C6
		public void NQBKMDIHJKQ(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x000232C6 File Offset: 0x000214C6
		public void FHFGJKNFIPC(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060059A5 RID: 22949 RVA: 0x000232CF File Offset: 0x000214CF
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x000232C6 File Offset: 0x000214C6
		public string MBPHKDQMJJH { get; set; }

		// Token: 0x060059A6 RID: 22950 RVA: 0x000232CF File Offset: 0x000214CF
		public string JCLPDDOJNKK()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x000232CF File Offset: 0x000214CF
		public string EOEHONFIGOF()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x000232C6 File Offset: 0x000214C6
		public void QFFEHQJPPCP(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x000232C6 File Offset: 0x000214C6
		public void JNOEFLJPJGL(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x000232CF File Offset: 0x000214CF
		public string EOODCKEIONJ()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x000232C6 File Offset: 0x000214C6
		public void HLDNNDBHHFE(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x000232CF File Offset: 0x000214CF
		public string KMDBCHQBGJN()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x000232CF File Offset: 0x000214CF
		public string NIPBEBKQINP()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x000232C6 File Offset: 0x000214C6
		public void CFOJLFELLIL(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x000232CF File Offset: 0x000214CF
		public string FEOJBJPPCLL()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x000232C6 File Offset: 0x000214C6
		public void OBEHBKPMFLK(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x000232C6 File Offset: 0x000214C6
		public void HBNQBICOLHE(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x000232C6 File Offset: 0x000214C6
		public void ECLLMOBMMIN(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x000232C6 File Offset: 0x000214C6
		public void EGOFIOJBFFC(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x000232C6 File Offset: 0x000214C6
		public void PFDJLQEDLEG(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x000232C6 File Offset: 0x000214C6
		public void HIIQNNDKGCP(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x000232C6 File Offset: 0x000214C6
		public void IEOKQHNQLDD(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x000232C6 File Offset: 0x000214C6
		public void FGPNGLIPFBQ(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x000232C6 File Offset: 0x000214C6
		public void KKCGIMMMCKD(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x000232C6 File Offset: 0x000214C6
		public void KFNLPCHNBML(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x000232CF File Offset: 0x000214CF
		public string BHGCOICCHNL()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x000232C6 File Offset: 0x000214C6
		public void JEDPEPNPQGO(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x000232C6 File Offset: 0x000214C6
		public void PMLJKHIKQFH(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x000232C6 File Offset: 0x000214C6
		public void QHHIFCBIOCE(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x000232CF File Offset: 0x000214CF
		public string GBJPEBHNMQJ()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x000232CF File Offset: 0x000214CF
		public string MDEJQDLGBEK()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x000232CF File Offset: 0x000214CF
		public string JHKGCGJBOND()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x000232CF File Offset: 0x000214CF
		public string GCIQNLLFOHP()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x000232CF File Offset: 0x000214CF
		public string OEQBCCKMECI()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x000232C6 File Offset: 0x000214C6
		public void GCJPEJBHQEL(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x000232CF File Offset: 0x000214CF
		public string KMLBOPHFBJI()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x000232CF File Offset: 0x000214CF
		public string MEJEICMNCDI()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x000232CF File Offset: 0x000214CF
		public string JMBJCBGGONM()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x000232CF File Offset: 0x000214CF
		public string NGFJOIFQJLC()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x000232CF File Offset: 0x000214CF
		public string CBLQBGDEKBI()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x000232CF File Offset: 0x000214CF
		public string ODKDFQMGEPH()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x000232C6 File Offset: 0x000214C6
		public void OFHCQLMKDMQ(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x000232C6 File Offset: 0x000214C6
		public void KIBJPJHELNL(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x000232CF File Offset: 0x000214CF
		public string JPIJEJOBFDP()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x000232C6 File Offset: 0x000214C6
		public void MCPIBNNLGNK(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x000232CF File Offset: 0x000214CF
		public string KFLDCNOMNKC()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x000232C6 File Offset: 0x000214C6
		public void JBLLMQPMKFJ(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x000232C6 File Offset: 0x000214C6
		public void JBMKBHQIGCF(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x000232CF File Offset: 0x000214CF
		public string NLGHPLEDLDL()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x000232CF File Offset: 0x000214CF
		public string DIKQPNEGPMO()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x000232CF File Offset: 0x000214CF
		public string NJOCDNIGPPJ()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x000232CF File Offset: 0x000214CF
		public string QLCPPHPEBNF()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x000232C6 File Offset: 0x000214C6
		public void CLNFOCLGHGH(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x000232C6 File Offset: 0x000214C6
		public void GQCQLDDOJGH(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x000232C6 File Offset: 0x000214C6
		public void IJFIJOOJLQD(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x000232C6 File Offset: 0x000214C6
		public void LNCLEPQPJNO(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059DB RID: 23003 RVA: 0x000232CF File Offset: 0x000214CF
		public string JMGHEDHFFLC()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059DC RID: 23004 RVA: 0x000232C6 File Offset: 0x000214C6
		public void LHPENPHPKQI(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059DD RID: 23005 RVA: 0x000232CF File Offset: 0x000214CF
		public string JMJNPHDKINM()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x000232CF File Offset: 0x000214CF
		public string FODGKHDODED()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x000232C6 File Offset: 0x000214C6
		public void MPICJMJKMGB(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x000232C6 File Offset: 0x000214C6
		public void QJFLEJIBHPN(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x000232CF File Offset: 0x000214CF
		public string QCGGKNIPCQJ()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x000232C6 File Offset: 0x000214C6
		public void LMQQFGNHFED(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E3 RID: 23011 RVA: 0x000232C6 File Offset: 0x000214C6
		public void KEPDDBENMLD(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x000232C6 File Offset: 0x000214C6
		public void PCMHJQBJBDL(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x000232C6 File Offset: 0x000214C6
		public void CCHMPQGHIDD(string BGBMIEJJQKC)
		{
			this.<GIFHBMHHHIP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x000232CF File Offset: 0x000214CF
		public string CLKHHBLHMFD()
		{
			return this.<GIFHBMHHHIP>k__BackingField;
		}
	}
}
