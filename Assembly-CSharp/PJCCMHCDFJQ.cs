using System;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200028D RID: 653
public class PJCCMHCDFJQ : MonoBehaviour
{
	// Token: 0x06005AA8 RID: 23208 RVA: 0x002EB708 File Offset: 0x002E9908
	public void KBQIEIHPBKC(Guid FFJJCIQPLOP)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		if (this.JHDGENGBPQF[1].ODKLFKLOKIP().Count >= 57)
		{
			return;
		}
		for (int i = 1; i < this.KOBFIGGHMEQ.Count; i += 0)
		{
			if (this.KOBFIGGHMEQ[i] == FFJJCIQPLOP)
			{
				return;
			}
		}
		this.KOBFIGGHMEQ.Add(FFJJCIQPLOP);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.AddPokemon,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005AA9 RID: 23209 RVA: 0x000237A2 File Offset: 0x000219A2
	private void Start()
	{
		this.HJKNJCKCBPD.JDBFENKBQQL = new JIMBBPLINGI.DNHJPIFLKNK(this.EMQHKNIGFQJ);
	}

	// Token: 0x06005AAA RID: 23210 RVA: 0x002EB794 File Offset: 0x002E9994
	public void LLLDOIINGLK(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = (TradeAction)7,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06005AAC RID: 23212 RVA: 0x002EB7D8 File Offset: 0x002E99D8
	public void DDGGOHGDNLD(int HFBPHOGKGLK, int DPDCGFEEFPB = 1)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel,
			ItemAmount = DPDCGFEEFPB,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06005AAD RID: 23213 RVA: 0x000237CE File Offset: 0x000219CE
	private void PKBNEKEHKKC()
	{
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005AAE RID: 23214 RVA: 0x000237E1 File Offset: 0x000219E1
	public void HGBJMGKPKQP(int HFBPHOGKGLK)
	{
		if (this.JHDGENGBPQF[0].ODKLFKLOKIP().Count >= -34)
		{
			return;
		}
		this.EHFQMDNBKQJ.SetActive(true);
		this.DQPFLILJDEM = HFBPHOGKGLK;
		this.BEDJMBPNPCN.LKPOBCBOFIC("move: ");
	}

	// Token: 0x06005AAF RID: 23215 RVA: 0x002EB810 File Offset: 0x002E9A10
	public void OGIDEJGOKEC(int HFBPHOGKGLK, int DPDCGFEEFPB = 1)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetItem,
			ItemAmount = DPDCGFEEFPB,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005AB0 RID: 23216 RVA: 0x0002381D File Offset: 0x00021A1D
	private void HHBCNGHCCCC()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005AB1 RID: 23217 RVA: 0x002EB848 File Offset: 0x002E9A48
	public void ConfirmTrade()
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.EHFQMDNBKQJ.SetActive(false);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.Confirm
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", "You can not trade during interactions or battles.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
		this.CancelTrade();
	}

	// Token: 0x06005AB2 RID: 23218 RVA: 0x00023825 File Offset: 0x00021A25
	private void ShowTrade()
	{
		this.IGDDONDGNGG.enabled = true;
		this.IGDDONDGNGG.PlayForward();
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x0002384F File Offset: 0x00021A4F
	private void KNHFQCPBMKN()
	{
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x00023862 File Offset: 0x00021A62
	public static PJCCMHCDFJQ DMOKBPOKHOQ()
	{
		return PJCCMHCDFJQ.HBFFCJHOCPE;
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x002EB8DC File Offset: 0x002E9ADC
	public void OEIBHGQJLFC()
	{
		if (!QOHCEBMQKMB.QQCNCIQQPIG().HEFMIKCHCJF() && !CNCJKLNHQBH.QOQONHOOLNE.LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.EHFQMDNBKQJ.SetActive(true);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.Confirm
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("OnClick", "Left", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
		this.EGPJPBJBILJ();
	}

	// Token: 0x06005AB6 RID: 23222 RVA: 0x002EB970 File Offset: 0x002E9B70
	public void DECDMFPFQEJ()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num--;
		if (num <= 1)
		{
			num = 1;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = num.ToString();
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x002EB9B0 File Offset: 0x002E9BB0
	public void HNFBIMQFBQB(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = (TradeAction)7,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
	}

	// Token: 0x06005AB8 RID: 23224 RVA: 0x002EB9F4 File Offset: 0x002E9BF4
	public void LQIENFHLFMJ()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num -= 0;
		if (num <= 0)
		{
			num = 0;
		}
		this.BEDJMBPNPCN.LKPOBCBOFIC(num.ToString());
	}

	// Token: 0x06005AB9 RID: 23225 RVA: 0x0002384F File Offset: 0x00021A4F
	private void KDPDIKIQGFL()
	{
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x0002381D File Offset: 0x00021A1D
	private void BMIIKIKIKIK()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005ABB RID: 23227 RVA: 0x0002381D File Offset: 0x00021A1D
	private void Awake()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x00023869 File Offset: 0x00021A69
	private void MLNGPJBFGQB()
	{
		this.IGDDONDGNGG.enabled = false;
		this.IGDDONDGNGG.PlayForward();
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005ABD RID: 23229 RVA: 0x002EBA34 File Offset: 0x002E9C34
	public void LPOOLFKNJNB()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num += 0;
		if (num >= 44)
		{
			num = -42;
		}
		if ((long)num > (long)((ulong)INFJMNPKNQF.CFGIOIGOIFQ().IIDQEHOHECF(this.DQPFLILJDEM)))
		{
			num = (int)INFJMNPKNQF.FPQNIQELKMC().IIDQEHOHECF(this.DQPFLILJDEM);
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = num.ToString();
	}

	// Token: 0x06005ABE RID: 23230 RVA: 0x00023862 File Offset: 0x00021A62
	public static PJCCMHCDFJQ QDGLKKGJDGI()
	{
		return PJCCMHCDFJQ.HBFFCJHOCPE;
	}

	// Token: 0x06005ABF RID: 23231 RVA: 0x002EBA9C File Offset: 0x002E9C9C
	public void EEIPLMLIGDP(Guid FFJJCIQPLOP)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005AC0 RID: 23232 RVA: 0x002EBACC File Offset: 0x002E9CCC
	public void PGLNOPDBOBP(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetItem,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005AC1 RID: 23233 RVA: 0x002EBB10 File Offset: 0x002E9D10
	public void CBODDDIBBME(Guid FFJJCIQPLOP)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		if (this.JHDGENGBPQF[1].GBCCNHMFINO().Count >= -21)
		{
			return;
		}
		for (int i = 0; i < this.KOBFIGGHMEQ.Count; i += 0)
		{
			if (this.KOBFIGGHMEQ[i] == FFJJCIQPLOP)
			{
				return;
			}
		}
		this.KOBFIGGHMEQ.Add(FFJJCIQPLOP);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.AddPokemon,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005AC2 RID: 23234 RVA: 0x00023893 File Offset: 0x00021A93
	public void DCCILNHHEIF(int HFBPHOGKGLK)
	{
		if (this.JHDGENGBPQF[1].ODKLFKLOKIP().Count >= -110)
		{
			return;
		}
		this.EHFQMDNBKQJ.SetActive(false);
		this.DQPFLILJDEM = HFBPHOGKGLK;
		this.BEDJMBPNPCN.LKPOBCBOFIC("Unlit/Transparent Colored");
	}

	// Token: 0x06005AC3 RID: 23235 RVA: 0x002EBB9C File Offset: 0x002E9D9C
	public void JPIHQPIFDEK()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x002EBBE4 File Offset: 0x002E9DE4
	public void FDHCCGLGPON(PSXAPI.Response.Trade OQJFBJQJEFG)
	{
		if (CNCJKLNHQBH.BJLGEDCPENQ().BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().BMKFDHDJPNE = null;
			CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.NQJHJNQFKKC();
		}
		EIDBQCPLPIL.PDPCLOECLOF().PHFEEOFGMHO();
		if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Start)
		{
			this.HLFPMILHOCF = OQJFBJQJEFG.TradeID;
			this.IIBNOEPBQGC[1].LKPOBCBOFIC(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH);
			this.IIBNOEPBQGC[1].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.IIBNOEPBQGC[4].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.KOBFIGGHMEQ.Clear();
			this.HJKNJCKCBPD.BGBMIEJJQKC = "-";
			this.CENKLIKPHIN();
			for (int i = 0; i < 1; i++)
			{
				this.PGBLHMLDGOJ[i].SetActive(false);
				this.LIHCHFFQKOF[i].LKPOBCBOFIC("[CFX_SpawnSystem.GetNextObject()] A new instance has been created for \"");
				this.JHDGENGBPQF[i].transform.NMBPDMIIHJB();
				this.JDOENMKLLQQ[i].SetActive(true);
			}
			this.JDBKHNFDPCP();
			this.JHDGENGBPQF[1].Reposition();
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Item)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.KNHFQCPBMKN();
			CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL("Unable to add '" + OQJFBJQJEFG.Username + "Player/Clothe");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Money)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.HFQBJQEMPNF();
			CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL(" was kicked from the Party." + OQJFBJQJEFG.Username + "Powers up Water-type moves when the Pokémon's HP is low.");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.PokemonRemoved)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform in this.JHDGENGBPQF[1].GBCCNHMFINO())
				{
					if (transform.gameObject.name == "forecast" + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform.gameObject);
							this.JHDGENGBPQF[1].Reposition();
							return;
						}
						transform.GetComponent<MHOCPCDCMHN>().FCLODIHFFQL(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component.FCLODIHFFQL(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, false);
				this.JHDGENGBPQF[1].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform2 in this.JHDGENGBPQF[0].ODKLFKLOKIP())
				{
					if (transform2.gameObject.name == "_AutoExposure" + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform2.gameObject);
							this.JHDGENGBPQF[1].Reposition();
							return;
						}
						transform2.GetComponent<MHOCPCDCMHN>().BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component2 = this.JHDGENGBPQF[0].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component2.FCLODIHFFQL(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, false);
				this.JHDGENGBPQF[1].PFEIQDIJEKE();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Item)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				this.HJKNJCKCBPD.POPMOIOELBB();
				this.LIHCHFFQKOF[1].PIDLOFMIEFQ = OQJFBJQJEFG.Money.ToString(" [M]");
			}
			else
			{
				this.LIHCHFFQKOF[1].LKPOBCBOFIC(OQJFBJQJEFG.Money.ToString("/ignore "));
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Canceled)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform3 in this.JHDGENGBPQF[1].GBCCNHMFINO())
				{
					if (transform3.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component3 = transform3.GetComponent<MHOCPCDCMHN>();
						component3.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.BQLIIQIIMDH(component3.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component4 = this.JHDGENGBPQF[0].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component4.IQMKEHHHQKG(OQJFBJQJEFG.Pokemon, false, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[1].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform4 in this.JHDGENGBPQF[0].BCELPQMGHCQ())
				{
					if (transform4.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component5 = transform4.GetComponent<MHOCPCDCMHN>();
						component5.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.BQLIIQIIMDH(component5.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component6 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component6.LQFDMHPELCJ(OQJFBJQJEFG.Pokemon, false, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[0].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Item)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform5 in this.JHDGENGBPQF[0].GBCCNHMFINO())
				{
					if (transform5.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						this.KOBFIGGHMEQ.Remove(OQJFBJQJEFG.Pokemon.UniqueID);
						UnityEngine.Object.Destroy(transform5.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[1].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform6 in this.JHDGENGBPQF[0].ODKLFKLOKIP())
				{
					if (transform6.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						UnityEngine.Object.Destroy(transform6.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[0].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.None)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
			{
				if (OQJFBJQJEFG.Accepted)
				{
					this.JDOENMKLLQQ[1].SetActive(true);
				}
				else
				{
					this.JDOENMKLLQQ[0].SetActive(true);
				}
			}
			else if (OQJFBJQJEFG.Accepted)
			{
				this.JDOENMKLLQQ[1].SetActive(false);
			}
			else
			{
				this.JDOENMKLLQQ[0].SetActive(true);
			}
			if (this.JDOENMKLLQQ[0].activeSelf && this.JDOENMKLLQQ[0].activeSelf)
			{
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = true;
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[2].SetActive(false);
				this.PGBLHMLDGOJ[0].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = false;
			}
		}
		else if (OQJFBJQJEFG.UpdateType == (TradeUpdateType)92)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Error == TradeError.PokemonLastActive)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("_Fade", OQJFBJQJEFG.Username + "Score: ", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
			else if (OQJFBJQJEFG.Error == TradeError.ItemAmountInvalid)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Game", OQJFBJQJEFG.Username + "'s [ffff00]", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, true);
			}
			if (OQJFBJQJEFG.Error == TradeError.PokemonInvalid)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("Mouse Y", OQJFBJQJEFG.Username + "[broken]", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, true);
			}
			if (OQJFBJQJEFG.Error == TradeError.PokemonLastActive)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("[", OQJFBJQJEFG.Username + " endured the hit!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(OQJFBJQJEFG.ItemID).FLFQBGJQBBD() + "No Mapping For Pokemon", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
		}
	}

	// Token: 0x06005AC5 RID: 23237 RVA: 0x000237CE File Offset: 0x000219CE
	private void GOPPMIDBMCO()
	{
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x002EC730 File Offset: 0x002EA930
	public void LLKOBMLEENK()
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.OCFGFJMJIGP() && !CNCJKLNHQBH.BJLGEDCPENQ().LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			this.EHFQMDNBKQJ.SetActive(true);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.SetItem,
				Accept = true
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("}]", "_Gain", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
		this.CancelTrade();
	}

	// Token: 0x06005AC7 RID: 23239 RVA: 0x002EC7CC File Offset: 0x002EA9CC
	public void GCJHKFOGHEI(Guid FFJJCIQPLOP)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetAccept,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005AC8 RID: 23240 RVA: 0x002EC7FC File Offset: 0x002EA9FC
	public void QLPILODKQOF()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num--;
		if (num <= 1)
		{
			num = 1;
		}
		this.BEDJMBPNPCN.LKPOBCBOFIC(num.ToString());
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x002EC83C File Offset: 0x002EAA3C
	public void POGQGBKBQLD()
	{
		this.EHFQMDNBKQJ.SetActive(true);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x0002381D File Offset: 0x00021A1D
	private void HFBHKNOCLOE()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x002EC884 File Offset: 0x002EAA84
	public void PIMHFHJOOHG()
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().DLNELFIPOHB() && !CNCJKLNHQBH.BJLGEDCPENQ().LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.EHFQMDNBKQJ.SetActive(true);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = (TradeAction)8
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("'s [ffff00]", ".", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
		this.JPIHQPIFDEK();
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x000238CF File Offset: 0x00021ACF
	public void FKOEOPCMLQF(int HFBPHOGKGLK)
	{
		if (this.JHDGENGBPQF[0].GBCCNHMFINO().Count >= 14)
		{
			return;
		}
		this.EHFQMDNBKQJ.SetActive(true);
		this.DQPFLILJDEM = HFBPHOGKGLK;
		this.BEDJMBPNPCN.PIDLOFMIEFQ = "1";
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x0002381D File Offset: 0x00021A1D
	private void CGDEBJQKGMO()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x00023862 File Offset: 0x00021A62
	public static PJCCMHCDFJQ GGBPGMMCGLI()
	{
		return PJCCMHCDFJQ.HBFFCJHOCPE;
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x002EC918 File Offset: 0x002EAB18
	public void EMQHKNIGFQJ()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		string text = this.HJKNJCKCBPD.BGBMIEJJQKC;
		if (text.Contains("-"))
		{
			text = "0";
		}
		if (text == string.Empty)
		{
			text = "0";
		}
		uint num = Convert.ToUInt32(text);
		if (num > INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ)
		{
			num = INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ;
		}
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetMoney,
			Money = num
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
		this.HJKNJCKCBPD.GOIKCGNOEKP();
		this.LIHCHFFQKOF[0].PIDLOFMIEFQ = num.ToString("#,##0");
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x002EC9C8 File Offset: 0x002EABC8
	public void IJOKQMKEGPF()
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			this.EHFQMDNBKQJ.SetActive(true);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.SetMoney
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("The two moves have become one! It's a combined move!\r\n", "_Dissolve", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
		this.EGPJPBJBILJ();
	}

	// Token: 0x06005AD1 RID: 23249 RVA: 0x0002390B File Offset: 0x00021B0B
	private void QMHOCOPELIL()
	{
		this.IGDDONDGNGG.enabled = false;
		this.IGDDONDGNGG.PlayForward();
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005AD2 RID: 23250 RVA: 0x002ECA5C File Offset: 0x002EAC5C
	public void NFNOIDKKHDO()
	{
		this.EHFQMDNBKQJ.SetActive(true);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.AddPokemon
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x002ECAA4 File Offset: 0x002EACA4
	public void FEDEJIGOEDB(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetMoney,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x002ECAE8 File Offset: 0x002EACE8
	private void CENKLIKPHIN()
	{
		this.JDOENMKLLQQ[1].SetActive(false);
		this.JDOENMKLLQQ[0].SetActive(false);
		this.PGBLHMLDGOJ[0].SetActive(true);
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[2].SetActive(false);
		this.PGBLHMLDGOJ[3].SetActive(false);
		this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = true;
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x002ECB5C File Offset: 0x002EAD5C
	public void CBKBPMBCFLB(PSXAPI.Response.Trade OQJFBJQJEFG)
	{
		if (CNCJKLNHQBH.MOGQNGEPCEO().BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().BMKFDHDJPNE = null;
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		EIDBQCPLPIL.BBCBOIFQDBK().FEJOFMOPGKM();
		if (OQJFBJQJEFG.UpdateType == TradeUpdateType.None)
		{
			this.HLFPMILHOCF = OQJFBJQJEFG.TradeID;
			this.IIBNOEPBQGC[0].PIDLOFMIEFQ = CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
			this.IIBNOEPBQGC[0].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.IIBNOEPBQGC[1].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.KOBFIGGHMEQ.Clear();
			this.HJKNJCKCBPD.BGBMIEJJQKC = "SSAO";
			this.CENKLIKPHIN();
			for (int i = 1; i < 5; i += 0)
			{
				this.PGBLHMLDGOJ[i].SetActive(false);
				this.LIHCHFFQKOF[i].PIDLOFMIEFQ = "System";
				this.JHDGENGBPQF[i].transform.NMBPDMIIHJB();
				this.JDOENMKLLQQ[i].SetActive(false);
			}
			this.QMHOCOPELIL();
			this.JHDGENGBPQF[0].PFEIQDIJEKE();
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Closed)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.KDPDIKIQGFL();
			CNCJKLNHQBH.MOGQNGEPCEO().GQOBKDLOCDL(" minute" + OQJFBJQJEFG.Username + "_ClipToWorld");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Closed)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.PKBNEKEHKKC();
			CNCJKLNHQBH.BJLGEDCPENQ().MIDPIFHNNDK("Can't equip \"" + OQJFBJQJEFG.Username + "freeze");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Money)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform in this.JHDGENGBPQF[0].BCELPQMGHCQ())
				{
					if (transform.gameObject.name == "OnPress" + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform.gameObject);
							this.JHDGENGBPQF[1].PFEIQDIJEKE();
							return;
						}
						transform.GetComponent<MHOCPCDCMHN>().BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component = this.JHDGENGBPQF[0].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component.FCLODIHFFQL(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
				this.JHDGENGBPQF[0].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform2 in this.JHDGENGBPQF[0].GBCCNHMFINO())
				{
					if (transform2.gameObject.name == "-" + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform2.gameObject);
							this.JHDGENGBPQF[0].Reposition();
							return;
						}
						transform2.GetComponent<MHOCPCDCMHN>().FDDENOHPGQF(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component2 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component2.COIMFDQIOKL(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
				this.JHDGENGBPQF[1].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Money)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
			{
				this.HJKNJCKCBPD.POPMOIOELBB();
				this.LIHCHFFQKOF[0].LKPOBCBOFIC(OQJFBJQJEFG.Money.ToString("battlearmor"));
			}
			else
			{
				this.LIHCHFFQKOF[0].PIDLOFMIEFQ = OQJFBJQJEFG.Money.ToString("HideResponse");
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.None)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform3 in this.JHDGENGBPQF[0].ODKLFKLOKIP())
				{
					if (transform3.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component3 = transform3.GetComponent<MHOCPCDCMHN>();
						component3.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.LBGCODKNHHP(component3.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component4 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component4.KEHBPLMFDIP(OQJFBJQJEFG.Pokemon, false, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[1].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform4 in this.JHDGENGBPQF[1].ODKLFKLOKIP())
				{
					if (transform4.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component5 = transform4.GetComponent<MHOCPCDCMHN>();
						component5.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.LBGCODKNHHP(component5.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component6 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component6.BQLIIQIIMDH(OQJFBJQJEFG.Pokemon, false, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[0].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Money)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform5 in this.JHDGENGBPQF[1].BCELPQMGHCQ())
				{
					if (transform5.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						this.KOBFIGGHMEQ.Remove(OQJFBJQJEFG.Pokemon.UniqueID);
						UnityEngine.Object.Destroy(transform5.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[0].PFEIQDIJEKE();
			}
			else
			{
				foreach (Transform transform6 in this.JHDGENGBPQF[1].ODKLFKLOKIP())
				{
					if (transform6.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						UnityEngine.Object.Destroy(transform6.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[1].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.State)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
			{
				if (OQJFBJQJEFG.Accepted)
				{
					this.JDOENMKLLQQ[1].SetActive(true);
				}
				else
				{
					this.JDOENMKLLQQ[1].SetActive(false);
				}
			}
			else if (OQJFBJQJEFG.Accepted)
			{
				this.JDOENMKLLQQ[0].SetActive(false);
			}
			else
			{
				this.JDOENMKLLQQ[0].SetActive(false);
			}
			if (this.JDOENMKLLQQ[1].activeSelf && this.JDOENMKLLQQ[0].activeSelf)
			{
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[2].SetActive(false);
				this.PGBLHMLDGOJ[4].SetActive(false);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[7].SetActive(true);
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = false;
			}
		}
		else if (OQJFBJQJEFG.UpdateType == (TradeUpdateType)81)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Error == TradeError.ItemAmountInvalid)
			{
				CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("17", OQJFBJQJEFG.Username + "shadowforce", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
			}
			else if (OQJFBJQJEFG.Error == TradeError.PokeboxFull)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("CombinersAlphaScale", OQJFBJQJEFG.Username + "taunt", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
			}
			if (OQJFBJQJEFG.Error == TradeError.MoneyCap)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Call", OQJFBJQJEFG.Username + "!\r\n", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
			if (OQJFBJQJEFG.Error == TradeError.ItemInvalid)
			{
				CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Unnerves opposing Pokémon and makes them unable to eat Berries.", OQJFBJQJEFG.Username + " already has a substitute!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(OQJFBJQJEFG.ItemID).Name + "\r\n", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
		}
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x00023935 File Offset: 0x00021B35
	private void PMCQGKPFJCK()
	{
		this.IGDDONDGNGG.enabled = true;
		this.IGDDONDGNGG.PlayForward();
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x00023862 File Offset: 0x00021A62
	public static PJCCMHCDFJQ QOQONHOOLNE
	{
		get
		{
			return PJCCMHCDFJQ.HBFFCJHOCPE;
		}
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x0002390B File Offset: 0x00021B0B
	private void JDBKHNFDPCP()
	{
		this.IGDDONDGNGG.enabled = false;
		this.IGDDONDGNGG.PlayForward();
		this.IGDDONDGNGG.gameObject.SetActive(true);
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x000237CE File Offset: 0x000219CE
	private void HFQBJQEMPNF()
	{
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x002ED6A8 File Offset: 0x002EB8A8
	public void IHCHIBNLJHL(int HFBPHOGKGLK, int DPDCGFEEFPB = 1)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel,
			ItemAmount = DPDCGFEEFPB,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x002ED6E0 File Offset: 0x002EB8E0
	public void AddAmount()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num++;
		if (num >= 100)
		{
			num = 100;
		}
		if ((long)num > (long)((ulong)INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.DQPFLILJDEM)))
		{
			num = (int)INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(this.DQPFLILJDEM);
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = num.ToString();
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x002ED748 File Offset: 0x002EB948
	public void FCEGNPIOEIN(Guid FFJJCIQPLOP)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetAccept,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x002ED778 File Offset: 0x002EB978
	public void ECODDLNCHEI(Guid FFJJCIQPLOP)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.RemovePokemon,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x002ED7A8 File Offset: 0x002EB9A8
	public void FPCICEKBEQH()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num += 0;
		if (num >= -99)
		{
			num = 83;
		}
		if ((long)num > (long)((ulong)INFJMNPKNQF.DOGEBLQHDHI().PNEEENCMBCN(this.DQPFLILJDEM)))
		{
			num = (int)INFJMNPKNQF.CFGIOIGOIFQ().IIDQEHOHECF(this.DQPFLILJDEM);
		}
		this.BEDJMBPNPCN.LKPOBCBOFIC(num.ToString());
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x002ED810 File Offset: 0x002EBA10
	public void PHFJELBJCME(Guid FFJJCIQPLOP)
	{
		this.EHFQMDNBKQJ.SetActive(true);
		if (this.JHDGENGBPQF[1].GBCCNHMFINO().Count >= 113)
		{
			return;
		}
		for (int i = 1; i < this.KOBFIGGHMEQ.Count; i++)
		{
			if (this.KOBFIGGHMEQ[i] == FFJJCIQPLOP)
			{
				return;
			}
		}
		this.KOBFIGGHMEQ.Add(FFJJCIQPLOP);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.AddPokemon,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06005AE0 RID: 23264 RVA: 0x002ED89C File Offset: 0x002EBA9C
	public void TakeAmount()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num--;
		if (num <= 0)
		{
			num = 0;
		}
		this.BEDJMBPNPCN.PIDLOFMIEFQ = num.ToString();
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x002ED8DC File Offset: 0x002EBADC
	public void CancelTrade()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005AE2 RID: 23266 RVA: 0x002ED924 File Offset: 0x002EBB24
	public void LIPMJJQFLBL()
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.BJLGEDCPENQ().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.EHFQMDNBKQJ.SetActive(false);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.RemovePokemon,
				Accept = true
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("_Texture0", "300", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, false);
		this.JPIHQPIFDEK();
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x002ED9C0 File Offset: 0x002EBBC0
	public void GLNJKKDEQBB(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(true);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = (TradeAction)8,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x000237A2 File Offset: 0x000219A2
	private void KPKQNOCFGIB()
	{
		this.HJKNJCKCBPD.JDBFENKBQQL = new JIMBBPLINGI.DNHJPIFLKNK(this.EMQHKNIGFQJ);
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x0002381D File Offset: 0x00021A1D
	private void CBIFGBNDMHB()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x002EDA04 File Offset: 0x002EBC04
	public void KHCOJNBNGFG()
	{
		int num = Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ);
		num++;
		if (num >= -37)
		{
			num = -50;
		}
		if ((long)num > (long)((ulong)INFJMNPKNQF.FPQNIQELKMC().IIDQEHOHECF(this.DQPFLILJDEM)))
		{
			num = (int)INFJMNPKNQF.DOGEBLQHDHI().IIDQEHOHECF(this.DQPFLILJDEM);
		}
		this.BEDJMBPNPCN.LKPOBCBOFIC(num.ToString());
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x002ED8DC File Offset: 0x002EBADC
	public void EGPJPBJBILJ()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
		this.IGDDONDGNGG.gameObject.SetActive(false);
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x0002381D File Offset: 0x00021A1D
	private void MBDGLQOGLDJ()
	{
		PJCCMHCDFJQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x0002395F File Offset: 0x00021B5F
	public void DLPOOIHPEKD(int HFBPHOGKGLK)
	{
		if (this.JHDGENGBPQF[0].ODKLFKLOKIP().Count >= -42)
		{
			return;
		}
		this.EHFQMDNBKQJ.SetActive(false);
		this.DQPFLILJDEM = HFBPHOGKGLK;
		this.BEDJMBPNPCN.LKPOBCBOFIC("'s [ffff00]");
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x002EDA6C File Offset: 0x002EBC6C
	public void BFEBONLJDCN()
	{
		if (!QOHCEBMQKMB.CNIMIQKQJJJ().PDOKGMLDIGL() && !CNCJKLNHQBH.BJLGEDCPENQ().LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.MOGQNGEPCEO().JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			this.EHFQMDNBKQJ.SetActive(false);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.AddPokemon,
				Accept = true
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("General", "Water", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
		this.POGQGBKBQLD();
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x0002399B File Offset: 0x00021B9B
	public void AcceptAmount()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		this.OGIDEJGOKEC(this.DQPFLILJDEM, Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ));
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x002EDB08 File Offset: 0x002EBD08
	public void JJIPJPNMBOK(int HFBPHOGKGLK, int DPDCGFEEFPB = 1)
	{
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.SetAccept,
			ItemAmount = DPDCGFEEFPB,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x002EDB40 File Offset: 0x002EBD40
	public void PGIQGOFDIDJ(PSXAPI.Response.Trade OQJFBJQJEFG)
	{
		if (CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE != null)
		{
			CNCJKLNHQBH.QOQONHOOLNE.BMKFDHDJPNE = null;
			CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.NQJHJNQFKKC();
		}
		EIDBQCPLPIL.QOQONHOOLNE.HidePanel();
		if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Start)
		{
			this.HLFPMILHOCF = OQJFBJQJEFG.TradeID;
			this.IIBNOEPBQGC[0].PIDLOFMIEFQ = CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
			this.IIBNOEPBQGC[1].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.IIBNOEPBQGC[2].PIDLOFMIEFQ = OQJFBJQJEFG.Username;
			this.KOBFIGGHMEQ.Clear();
			this.HJKNJCKCBPD.BGBMIEJJQKC = "0";
			this.CENKLIKPHIN();
			for (int i = 0; i < 2; i++)
			{
				this.PGBLHMLDGOJ[i].SetActive(true);
				this.LIHCHFFQKOF[i].PIDLOFMIEFQ = "0";
				this.JHDGENGBPQF[i].transform.NMBPDMIIHJB();
				this.JDOENMKLLQQ[i].SetActive(false);
			}
			this.ShowTrade();
			this.JHDGENGBPQF[0].Reposition();
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Canceled)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.GOPPMIDBMCO();
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("The trade with '" + OQJFBJQJEFG.Username + "' has been canceled.");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Closed)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.GOPPMIDBMCO();
			CNCJKLNHQBH.QOQONHOOLNE.MIDPIFHNNDK("The trade with '" + OQJFBJQJEFG.Username + "' was successful.");
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Item)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform in this.JHDGENGBPQF[0].GBCCNHMFINO())
				{
					if (transform.gameObject.name == "Item: " + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform.gameObject);
							this.JHDGENGBPQF[0].Reposition();
							return;
						}
						transform.GetComponent<MHOCPCDCMHN>().BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component = this.JHDGENGBPQF[0].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component.BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
				this.JHDGENGBPQF[0].Reposition();
			}
			else
			{
				foreach (Transform transform2 in this.JHDGENGBPQF[1].GBCCNHMFINO())
				{
					if (transform2.gameObject.name == "Item: " + OQJFBJQJEFG.ItemID.ToString())
					{
						if (OQJFBJQJEFG.ItemAmount == 0)
						{
							UnityEngine.Object.Destroy(transform2.gameObject);
							this.JHDGENGBPQF[1].Reposition();
							return;
						}
						transform2.GetComponent<MHOCPCDCMHN>().BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
						return;
					}
				}
				MHOCPCDCMHN component2 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component2.BQLIIQIIMDH(OQJFBJQJEFG.ItemID, OQJFBJQJEFG.ItemAmount, true);
				this.JHDGENGBPQF[1].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Money)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				this.HJKNJCKCBPD.GOIKCGNOEKP();
				this.LIHCHFFQKOF[0].PIDLOFMIEFQ = OQJFBJQJEFG.Money.ToString("#,##0");
			}
			else
			{
				this.LIHCHFFQKOF[1].PIDLOFMIEFQ = OQJFBJQJEFG.Money.ToString("#,##0");
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.PokemonAdded)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform3 in this.JHDGENGBPQF[0].GBCCNHMFINO())
				{
					if (transform3.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component3 = transform3.GetComponent<MHOCPCDCMHN>();
						component3.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.BQLIIQIIMDH(component3.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component4 = this.JHDGENGBPQF[0].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component4.BQLIIQIIMDH(OQJFBJQJEFG.Pokemon, true, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[0].Reposition();
			}
			else
			{
				foreach (Transform transform4 in this.JHDGENGBPQF[1].GBCCNHMFINO())
				{
					if (transform4.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						MHOCPCDCMHN component5 = transform4.GetComponent<MHOCPCDCMHN>();
						component5.EMLKKOFMIIH = OQJFBJQJEFG.Pokemon;
						if (this.JLCFIMNJGBB.LDQDJLFIDCN == OQJFBJQJEFG.Pokemon.UniqueID)
						{
							this.JLCFIMNJGBB.BQLIIQIIMDH(component5.EMLKKOFMIIH);
						}
						return;
					}
				}
				MHOCPCDCMHN component6 = this.JHDGENGBPQF[1].gameObject.BFCKNMFEBDM(this.QLEDDNCPHJK).GetComponent<MHOCPCDCMHN>();
				component6.BQLIIQIIMDH(OQJFBJQJEFG.Pokemon, false, this.JLCFIMNJGBB);
				this.JHDGENGBPQF[1].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.PokemonRemoved)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			this.CENKLIKPHIN();
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				foreach (Transform transform5 in this.JHDGENGBPQF[0].GBCCNHMFINO())
				{
					if (transform5.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						this.KOBFIGGHMEQ.Remove(OQJFBJQJEFG.Pokemon.UniqueID);
						UnityEngine.Object.Destroy(transform5.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[0].Reposition();
			}
			else
			{
				foreach (Transform transform6 in this.JHDGENGBPQF[1].GBCCNHMFINO())
				{
					if (transform6.gameObject.name == OQJFBJQJEFG.Pokemon.UniqueID.ToString())
					{
						UnityEngine.Object.Destroy(transform6.gameObject);
						break;
					}
				}
				this.JHDGENGBPQF[1].Reposition();
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.State)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Username.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
			{
				if (OQJFBJQJEFG.Accepted)
				{
					this.JDOENMKLLQQ[0].SetActive(true);
				}
				else
				{
					this.JDOENMKLLQQ[0].SetActive(false);
				}
			}
			else if (OQJFBJQJEFG.Accepted)
			{
				this.JDOENMKLLQQ[1].SetActive(true);
			}
			else
			{
				this.JDOENMKLLQQ[1].SetActive(false);
			}
			if (this.JDOENMKLLQQ[0].activeSelf && this.JDOENMKLLQQ[1].activeSelf)
			{
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[0].SetActive(false);
				this.PGBLHMLDGOJ[1].SetActive(false);
				this.PGBLHMLDGOJ[2].SetActive(true);
				this.PGBLHMLDGOJ[3].SetActive(true);
			}
			else
			{
				this.PGBLHMLDGOJ[0].SetActive(true);
				this.PGBLHMLDGOJ[1].SetActive(true);
				this.PGBLHMLDGOJ[2].SetActive(false);
				this.PGBLHMLDGOJ[3].SetActive(false);
				this.HJKNJCKCBPD.GetComponent<BoxCollider>().enabled = true;
			}
		}
		else if (OQJFBJQJEFG.UpdateType == TradeUpdateType.Error)
		{
			if (this.HLFPMILHOCF == Guid.Empty || OQJFBJQJEFG.TradeID != this.HLFPMILHOCF)
			{
				return;
			}
			if (OQJFBJQJEFG.Error == TradeError.PokemonLastActive)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", OQJFBJQJEFG.Username + " can not trade their last active Pokemon.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
			else if (OQJFBJQJEFG.Error == TradeError.PokeboxFull)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", OQJFBJQJEFG.Username + "'s Pokebox is full.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
			if (OQJFBJQJEFG.Error == TradeError.MoneyCap)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", OQJFBJQJEFG.Username + "'s Money will go over the money cap.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
			if (OQJFBJQJEFG.Error == TradeError.ItemsFull)
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", OQJFBJQJEFG.Username + " can not hold that many more '" + KGQECFKLKOP.BFNBQBMJHFL(OQJFBJQJEFG.ItemID).Name + "'.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			}
		}
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x002EE68C File Offset: 0x002EC88C
	public void JEEPMJPGIEB(Guid FFJJCIQPLOP)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		if (this.JHDGENGBPQF[0].GBCCNHMFINO().Count >= 14)
		{
			return;
		}
		for (int i = 0; i < this.KOBFIGGHMEQ.Count; i++)
		{
			if (this.KOBFIGGHMEQ[i] == FFJJCIQPLOP)
			{
				return;
			}
		}
		this.KOBFIGGHMEQ.Add(FFJJCIQPLOP);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.AddPokemon,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x002EE718 File Offset: 0x002EC918
	public void ODPDDMCHHOO()
	{
		if (!QOHCEBMQKMB.JLLBKOOQKGO().PDOKGMLDIGL() && !CNCJKLNHQBH.MOGQNGEPCEO().LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.CDDIILFBFCF() != null))
		{
			this.EHFQMDNBKQJ.SetActive(true);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.SetAccept
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("rebound", "[^a-zA-Z0-9]", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
		this.POGQGBKBQLD();
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x002EE7AC File Offset: 0x002EC9AC
	public void OKGJQPFDCFQ(Guid FFJJCIQPLOP)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		if (this.JHDGENGBPQF[1].BCELPQMGHCQ().Count >= 119)
		{
			return;
		}
		for (int i = 1; i < this.KOBFIGGHMEQ.Count; i += 0)
		{
			if (this.KOBFIGGHMEQ[i] == FFJJCIQPLOP)
			{
				return;
			}
		}
		this.KOBFIGGHMEQ.Add(FFJJCIQPLOP);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.Cancel,
			Pokemon = FFJJCIQPLOP
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x002EE838 File Offset: 0x002ECA38
	public void AcceptTrade()
	{
		if (!QOHCEBMQKMB.QOQONHOOLNE.EKEKMCMJEOC() && !CNCJKLNHQBH.QOQONHOOLNE.LPOPOLFKOPI.activeSelf && !CNCJKLNHQBH.QOQONHOOLNE.JOPCLLDNOHH.activeSelf && !(OGJJKKQPNMK.QOQONHOOLNE != null))
		{
			this.EHFQMDNBKQJ.SetActive(false);
			PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
			{
				Action = TradeAction.SetAccept,
				Accept = true
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Trade Error", "You can not trade during interactions or battles.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
		this.CancelTrade();
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x002EE8D4 File Offset: 0x002ECAD4
	public void ONEMEKMOQHI(int HFBPHOGKGLK)
	{
		this.EHFQMDNBKQJ.SetActive(false);
		PSXAPI.Request.Trade dcgclgqcgdq = new PSXAPI.Request.Trade
		{
			Action = TradeAction.RemovePokemon,
			ItemAmount = 0,
			ItemID = HFBPHOGKGLK
		};
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x000239C5 File Offset: 0x00021BC5
	public void HBMQJPBJEJB()
	{
		this.EHFQMDNBKQJ.SetActive(false);
		this.IHCHIBNLJHL(this.DQPFLILJDEM, Convert.ToInt32(this.BEDJMBPNPCN.PIDLOFMIEFQ));
	}

	// Token: 0x040013A1 RID: 5025
	private static PJCCMHCDFJQ HBFFCJHOCPE;

	// Token: 0x040013A2 RID: 5026
	public LINELKKDMEE JLCFIMNJGBB;

	// Token: 0x040013A3 RID: 5027
	public GameObject QLEDDNCPHJK;

	// Token: 0x040013A4 RID: 5028
	public GameObject FHOFDEIBFNH;

	// Token: 0x040013A5 RID: 5029
	public EPIJJNOIKEK IGDDONDGNGG;

	// Token: 0x040013A6 RID: 5030
	public JIMBBPLINGI HJKNJCKCBPD;

	// Token: 0x040013A7 RID: 5031
	public BKKHLBCLPJM[] IIBNOEPBQGC;

	// Token: 0x040013A8 RID: 5032
	public BKKHLBCLPJM[] LIHCHFFQKOF;

	// Token: 0x040013A9 RID: 5033
	public GameObject[] JDOENMKLLQQ;

	// Token: 0x040013AA RID: 5034
	public BHLIGEGNFHG[] JHDGENGBPQF;

	// Token: 0x040013AB RID: 5035
	public GameObject[] PGBLHMLDGOJ;

	// Token: 0x040013AC RID: 5036
	public GameObject CDKHIELMQIE;

	// Token: 0x040013AD RID: 5037
	public List<Guid> KOBFIGGHMEQ = new List<Guid>();

	// Token: 0x040013AE RID: 5038
	private Guid HLFPMILHOCF;

	// Token: 0x040013AF RID: 5039
	public GameObject EHFQMDNBKQJ;

	// Token: 0x040013B0 RID: 5040
	public BKKHLBCLPJM BEDJMBPNPCN;

	// Token: 0x040013B1 RID: 5041
	private int DQPFLILJDEM;
}
