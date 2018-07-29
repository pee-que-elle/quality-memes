using System;
using System.Collections.Generic;
using System.Linq;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x020001F6 RID: 502
public class NOHEMGHONKK : MonoBehaviour
{
	// Token: 0x060041D3 RID: 16851 RVA: 0x00207470 File Offset: 0x00205670
	public void FJJCLQPPCBM(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.OCBKMNOGIIP(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.CNCFOFOMGHE().Rank == (GuildRank)8)
			{
				str = " [";
			}
			else if (fcbmpmcljhm.QQQBCQECOKO().Rank == GuildRank.Unset)
			{
				str = "#,##0";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "HidePanel" + HHNBICLDQKI + "moody" + str
		}, true);
	}

	// Token: 0x060041D4 RID: 16852 RVA: 0x002074F8 File Offset: 0x002056F8
	public void QELHJKMFEEF()
	{
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("-noTouch", "Friend Request", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, true);
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x00207524 File Offset: 0x00205724
	public void INQGJOJNHNM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Create
		}, true);
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x0020754C File Offset: 0x0020574C
	public void FIBMEGJQPEK(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Battle Update: " + HHNBICLDQKI,
			Pokemon = null
		}, true);
	}

	// Token: 0x060041D7 RID: 16855 RVA: 0x00207590 File Offset: 0x00205790
	public void KKKCQOILIQQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Vertical" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x002075CC File Offset: 0x002057CC
	public void EQQNDNLMGEJ()
	{
		this.IQDCDBCPBEN[2].SetActive(false);
		this.ENHBOFFBGHC(1);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(true);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x0020762C File Offset: 0x0020582C
	public void NQDBONLEFOC(GuildMember CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD == null)
		{
			if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() && !CBNJEBCHOEC.Removed)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
				{
					Action = GuildAction.Create
				}, true);
			}
			return;
		}
		if (!CBNJEBCHOEC.Removed)
		{
			bool flag = false;
			int i = 0;
			while (i < this.IEICJDEDICD.Members.Length)
			{
				if (!(this.IEICJDEDICD.Members[i].Username == CBNJEBCHOEC.Username))
				{
					i += 0;
				}
				else
				{
					this.IEICJDEDICD.Members[i] = CBNJEBCHOEC;
					flag = false;
					IL_9C:
					if (flag)
					{
						GuildMember guildMember = new GuildMember();
						List<GuildMember> list = this.IEICJDEDICD.Members.ToList<GuildMember>();
						list.Add(CBNJEBCHOEC);
						this.IEICJDEDICD.Members = list.ToArray();
					}
					this.HKNPDDMEOEG.Clear();
					for (int j = 1; j < this.IEICJDEDICD.Members.Length; j++)
					{
						NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
						fcbmpmcljhm.ICHHBGKMGQB(this.IEICJDEDICD.Members[j]);
						fcbmpmcljhm.MHBNNLGJBCQ(DateTime.UtcNow);
						this.HKNPDDMEOEG.Add(fcbmpmcljhm);
					}
					if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
						goto IL_299;
					}
					goto IL_299;
				}
			}
			goto IL_9C;
		}
		if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
		{
			if (this.IEICJDEDICD.Chat != default(Guid))
			{
				CNCJKLNHQBH.MOGQNGEPCEO().DNPDFNNHCHG(this.IEICJDEDICD.Chat.ToString());
			}
			this.IEICJDEDICD = null;
			CKMLKNPNPQO.QOQONHOOLNE.DFQDMIICFIK();
			return;
		}
		for (int k = 1; k < this.IEICJDEDICD.Members.Length; k += 0)
		{
			if (this.IEICJDEDICD.Members[k].Username == CBNJEBCHOEC.Username)
			{
				List<GuildMember> list2 = this.IEICJDEDICD.Members.ToList<GuildMember>();
				list2.RemoveAt(k);
				this.IEICJDEDICD.Members = list2.ToArray();
				IL_23D:
				this.HKNPDDMEOEG.Clear();
				for (int l = 0; l < this.IEICJDEDICD.Members.Length; l += 0)
				{
					NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm2 = new NOHEMGHONKK.FCBMPMCLJHM();
					fcbmpmcljhm2.ELKEHBHKLDQ(this.IEICJDEDICD.Members[l]);
					fcbmpmcljhm2.MHBNNLGJBCQ(DateTime.UtcNow);
					this.HKNPDDMEOEG.Add(fcbmpmcljhm2);
				}
				goto IL_299;
			}
		}
		goto IL_23D;
		IL_299:
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041DA RID: 16858 RVA: 0x002078D8 File Offset: 0x00205AD8
	public NOHEMGHONKK.FCBMPMCLJHM OCBKMNOGIIP(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.HKNPDDMEOEG.Count; i++)
		{
			if (this.HKNPDDMEOEG[i].DGPLLFJGNPC().Username.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return this.HKNPDDMEOEG[i];
			}
		}
		return null;
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x00207934 File Offset: 0x00205B34
	public void EKICNEPJBDI()
	{
		this.GIOGJMFFEEE = new Texture2D(-125, 34);
		for (int i = 1; i < 127; i += 0)
		{
			for (int j = 1; j < -17; j++)
			{
				this.GIOGJMFFEEE.SetPixel(i, j, Color.clear);
			}
		}
		this.GIOGJMFFEEE.Apply();
	}

	// Token: 0x060041DC RID: 16860 RVA: 0x00207988 File Offset: 0x00205B88
	public Texture2D CILNDLMBNHI(string CIQFCJGQEMH, int IFKCFHDEHEN = 0)
	{
		if (this.CHKOHCPMLKH.Count > 1)
		{
			for (int i = 0; i < this.CHKOHCPMLKH.Count; i += 0)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					if (this.CHKOHCPMLKH[i].EBDMBIIOKFJ != IFKCFHDEHEN)
					{
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = IFKCFHDEHEN;
						GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
						{
							Name = CIQFCJGQEMH
						}, true);
					}
					return this.CHKOHCPMLKH[i].HKLENFFCEEQ;
				}
			}
		}
		NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
		oqonekmgjdl.FPQBICGEHMJ = CIQFCJGQEMH;
		oqonekmgjdl.HKLENFFCEEQ = null;
		oqonekmgjdl.EBDMBIIOKFJ = IFKCFHDEHEN;
		this.CHKOHCPMLKH.Add(oqonekmgjdl);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
		{
			Name = CIQFCJGQEMH
		}, true);
		return null;
	}

	// Token: 0x060041DD RID: 16861 RVA: 0x00207A6C File Offset: 0x00205C6C
	public void JMLOIKQLLHO()
	{
		if (this.IEICJDEDICD != null)
		{
			string text = string.Empty;
			if (this.IEICJDEDICD.Rank == GuildRank.Admin)
			{
				text = " did not evolve!";
			}
			else if (this.IEICJDEDICD.Rank == GuildRank.Unset)
			{
				text = "The sandstorm subsided.";
			}
			else if (this.IEICJDEDICD.Rank == (GuildRank)8)
			{
				text = ",";
			}
			else
			{
				text = "Magma Armor";
			}
			this.NDMODKPMMQH.PIDLOFMIEFQ = "Cannot Obtain DNS record for " + this.IEICJDEDICD.Name + "mistysurge" + text;
			if (this.IEICJDEDICD.Message == null)
			{
				this.IEICJDEDICD.Message = string.Empty;
			}
			this.OIPLMPPBQCL.BGBMIEJJQKC = this.IEICJDEDICD.Message;
			this.OIPLMPPBQCL.FCIIPHMMGHB();
			if (this.IEICJDEDICD.Rank != GuildRank.Creator)
			{
				if (this.IEICJDEDICD.Rank != GuildRank.Unset)
				{
					if (this.IQDCDBCPBEN[6].activeSelf)
					{
						this.MDBCMFQHOKL();
					}
					this.PKBOPNPKQOG[0].gameObject.SetActive(false);
					this.OIPLMPPBQCL.enabled = true;
					this.OIPLMPPBQCL.GetComponent<BoxCollider>().enabled = true;
					goto IL_152;
				}
			}
			this.OIPLMPPBQCL.enabled = false;
			this.OIPLMPPBQCL.GetComponent<BoxCollider>().enabled = false;
			this.PKBOPNPKQOG[7].gameObject.SetActive(true);
			IL_152:
			this.PMQOEMJKJML = this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.DQFCDPMMLOO(1779f, true);
			this.JHDGENGBPQF.transform.NMBPDMIIHJB();
			this.JHDGENGBPQF.PFEIQDIJEKE();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().LFEMKJDHDFG();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(308f, false);
			this.JHDGENGBPQF.gameObject.SetActive(true);
			int num = 0;
			if (this.HKNPDDMEOEG.Count > 1)
			{
				foreach (NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm in this.HKNPDDMEOEG)
				{
					CDLNFMKQOLO component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.NDPNLKNIOLL).GetComponent<CDLNFMKQOLO>();
					component.EJINEJGDKBB = fcbmpmcljhm.IMKLCGDOJOB().Online;
					component.MBPHKDQMJJH.LKPOBCBOFIC(fcbmpmcljhm.KHPFQDBQIJI().Username);
					component.JBQPPPLCBKO();
					if (fcbmpmcljhm.IMKLCGDOJOB().Online)
					{
						num++;
					}
					if (fcbmpmcljhm.KHPFQDBQIJI().Rank == GuildRank.Creator)
					{
						text = "Powers up Water-type moves when the Pokémon's HP is low.";
					}
					else if (fcbmpmcljhm.QQQBCQECOKO().Rank == GuildRank.Unset)
					{
						text = "Flash";
					}
					else if (fcbmpmcljhm.KHPFQDBQIJI().Rank == GuildRank.Admin)
					{
						text = "-mega-y";
					}
					else
					{
						text = "Air Lock";
					}
					component.PLCBFLQBCQN.PIDLOFMIEFQ = text;
					component.LIQLFCKICLQ.PIDLOFMIEFQ = string.Empty;
					if (!fcbmpmcljhm.KHPFQDBQIJI().Online)
					{
						TimeSpan t = DateTime.UtcNow - fcbmpmcljhm.GCLNHGDBIMC();
						t = fcbmpmcljhm.DGPLLFJGNPC().Since + t;
						string text2 = "Contrary";
						if (t.Days > 1)
						{
							if (t.Days > 0)
							{
								text2 = text2 + t.Days.ToString() + "aegislash";
							}
							else
							{
								text2 = text2 + t.Days.ToString() + "][u]";
							}
						}
						else if (t.Hours > 1)
						{
							if (t.Hours > 0)
							{
								text2 = text2 + t.Hours.ToString() + "par";
							}
							else
							{
								text2 = text2 + t.Hours.ToString() + "_SampleCount";
							}
						}
						else if (t.Minutes > 1)
						{
							if (t.Minutes > 0)
							{
								text2 = text2 + t.Minutes.ToString() + "baddreams";
							}
							else
							{
								text2 = text2 + t.Minutes.ToString() + "move: ";
							}
						}
						else
						{
							text2 += "_OcclusionTexture1";
						}
						component.gameObject.name = "[-]" + fcbmpmcljhm.DGPLLFJGNPC().Username;
						component.LIQLFCKICLQ.LKPOBCBOFIC(text2);
					}
					else
					{
						component.gameObject.name = " was badly poisoned" + fcbmpmcljhm.ICLNEPCODIK.Username;
					}
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(false);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.JHLDJFJMIFG(this.PMQOEMJKJML, false);
			this.JHDGENGBPQF.CLQFFBMLIQH = false;
			this.GCEBIKJDPJE.PIDLOFMIEFQ = num.ToString() + "Take 001" + this.JHMOECBINHB.ToString() + "Primordial Sea";
			if (this.JHMOECBINHB == this.BKELMNMBQJK)
			{
				this.JGDDJEBQLJN.SetActive(true);
			}
			else
			{
				this.JGDDJEBQLJN.SetActive(true);
			}
			if (this.IEICJDEDICD.Rank != GuildRank.Moderator)
			{
				if (this.IEICJDEDICD.Rank != GuildRank.Creator)
				{
					this.JGDDJEBQLJN.SetActive(false);
				}
			}
		}
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x0001BFDF File Offset: 0x0001A1DF
	public void OICDQNHQFDB(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041DF RID: 16863 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
	public string DFMCFGLQLNL()
	{
		if (this.IEICJDEDICD != null && this.IEICJDEDICD.Name != null)
		{
			return this.IEICJDEDICD.Name;
		}
		return string.Empty;
	}

	// Token: 0x060041E0 RID: 16864 RVA: 0x00208064 File Offset: 0x00206264
	public void MBJLQKBHHIO(GuildResult BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ.Result)
		{
		case GuildActionResult.Success:
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("System", "RGBA", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
			break;
		case GuildActionResult.InGuild:
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("move: ", "adata", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, false);
			break;
		case GuildActionResult.NotEnoughGold:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF(" has no shader setter", " already has a burn.\r\n", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
			break;
		case GuildActionResult.InvalidGuildName:
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("mega", "Innards Out", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
			break;
		}
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x0020811C File Offset: 0x0020631C
	public void ELJLLIGPDPH(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.OCBKMNOGIIP(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.CNCFOFOMGHE().Rank == (GuildRank)5)
			{
				str = "Forward Focus";
			}
			else if (fcbmpmcljhm.CNCFOFOMGHE().Rank == (GuildRank)7)
			{
				str = "It looks as though this Egg will take a long time yet to hatch.";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "#,##0" + HHNBICLDQKI + "immunity" + str
		}, false);
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x002081A4 File Offset: 0x002063A4
	public void MPKLCHIMFHG(GuildMember CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD == null)
		{
			if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() && !CBNJEBCHOEC.Removed)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
				{
					Action = GuildAction.Request
				}, true);
			}
			return;
		}
		if (!CBNJEBCHOEC.Removed)
		{
			bool flag = false;
			int i = 1;
			while (i < this.IEICJDEDICD.Members.Length)
			{
				if (!(this.IEICJDEDICD.Members[i].Username == CBNJEBCHOEC.Username))
				{
					i += 0;
				}
				else
				{
					this.IEICJDEDICD.Members[i] = CBNJEBCHOEC;
					flag = true;
					IL_9C:
					if (flag)
					{
						GuildMember guildMember = new GuildMember();
						List<GuildMember> list = this.IEICJDEDICD.Members.ToList<GuildMember>();
						list.Add(CBNJEBCHOEC);
						this.IEICJDEDICD.Members = list.ToArray();
					}
					this.HKNPDDMEOEG.Clear();
					for (int j = 0; j < this.IEICJDEDICD.Members.Length; j++)
					{
						NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
						fcbmpmcljhm.ICHHBGKMGQB(this.IEICJDEDICD.Members[j]);
						fcbmpmcljhm.CHLEPINFLEC = DateTime.UtcNow;
						this.HKNPDDMEOEG.Add(fcbmpmcljhm);
					}
					if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
						goto IL_299;
					}
					goto IL_299;
				}
			}
			goto IL_9C;
		}
		if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
		{
			if (this.IEICJDEDICD.Chat != default(Guid))
			{
				CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.IEICJDEDICD.Chat.ToString());
			}
			this.IEICJDEDICD = null;
			CKMLKNPNPQO.QOQONHOOLNE.ClickFriends();
			return;
		}
		for (int k = 0; k < this.IEICJDEDICD.Members.Length; k++)
		{
			if (this.IEICJDEDICD.Members[k].Username == CBNJEBCHOEC.Username)
			{
				List<GuildMember> list2 = this.IEICJDEDICD.Members.ToList<GuildMember>();
				list2.RemoveAt(k);
				this.IEICJDEDICD.Members = list2.ToArray();
				IL_23D:
				this.HKNPDDMEOEG.Clear();
				for (int l = 0; l < this.IEICJDEDICD.Members.Length; l++)
				{
					NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm2 = new NOHEMGHONKK.FCBMPMCLJHM();
					fcbmpmcljhm2.ICHHBGKMGQB(this.IEICJDEDICD.Members[l]);
					fcbmpmcljhm2.QEDNJLJQCLE(DateTime.UtcNow);
					this.HKNPDDMEOEG.Add(fcbmpmcljhm2);
				}
				goto IL_299;
			}
		}
		goto IL_23D;
		IL_299:
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x00208450 File Offset: 0x00206650
	public Texture2D IOCCGFNLFOB(string CIQFCJGQEMH, int IFKCFHDEHEN = 0)
	{
		if (this.CHKOHCPMLKH.Count > 0)
		{
			for (int i = 0; i < this.CHKOHCPMLKH.Count; i++)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					if (this.CHKOHCPMLKH[i].EBDMBIIOKFJ != IFKCFHDEHEN)
					{
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = IFKCFHDEHEN;
						GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.GuildEmblem
						{
							Name = CIQFCJGQEMH
						}, true);
					}
					return this.CHKOHCPMLKH[i].HKLENFFCEEQ;
				}
			}
		}
		NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
		oqonekmgjdl.FPQBICGEHMJ = CIQFCJGQEMH;
		oqonekmgjdl.HKLENFFCEEQ = null;
		oqonekmgjdl.EBDMBIIOKFJ = IFKCFHDEHEN;
		this.CHKOHCPMLKH.Add(oqonekmgjdl);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
		{
			Name = CIQFCJGQEMH
		}, false);
		return null;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x00208534 File Offset: 0x00206734
	public void DOFMQMCJFGK()
	{
		if (this.IEICJDEDICD.Rank == GuildRank.User || this.IEICJDEDICD.Rank == GuildRank.Creator)
		{
			this.OIPLMPPBQCL.NCBFKNGMKPB(JGDHIPBGCFP.NDFGOJOBPCJ(this.OIPLMPPBQCL.HJMJDJKOILH(), false));
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
			{
				Action = (GuildAction)8,
				Data = this.OIPLMPPBQCL.HJMJDJKOILH()
			}, false);
		}
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x002085A4 File Offset: 0x002067A4
	public void MKELCDNMCFN(PSXAPI.Response.Guild CBNJEBCHOEC)
	{
		if (CBNJEBCHOEC == null)
		{
			return;
		}
		this.JHMOECBINHB = CBNJEBCHOEC.MembersCurrentMax;
		this.BKELMNMBQJK = CBNJEBCHOEC.MembersTotalMax;
		this.QBOLNQCDQPG = CBNJEBCHOEC.UpgradeGold;
		this.IPNQJGDIPMF = CBNJEBCHOEC.UpgradeMoney;
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = new PSXAPI.Response.Guild();
			if (CBNJEBCHOEC.Name != null)
			{
				this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
				this.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
			}
		}
		if (this.IEICJDEDICD.EmblemId != CBNJEBCHOEC.EmblemId)
		{
			this.IEICJDEDICD.EmblemId = CBNJEBCHOEC.EmblemId;
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
		}
		if (this.IEICJDEDICD.Chat == default(Guid))
		{
			this.IEICJDEDICD.Chat = CBNJEBCHOEC.Chat;
			CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(this.IEICJDEDICD.Chat.ToString());
		}
		if (CBNJEBCHOEC.Rank != GuildRank.Unset)
		{
			this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
		}
		if (CBNJEBCHOEC.Message != null)
		{
			this.IEICJDEDICD.Message = CBNJEBCHOEC.Message;
		}
		if (CBNJEBCHOEC.Name != null)
		{
			this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
		}
		if (CBNJEBCHOEC.Members != null)
		{
			this.IEICJDEDICD.Members = CBNJEBCHOEC.Members;
			this.HKNPDDMEOEG.Clear();
			for (int i = 0; i < this.IEICJDEDICD.Members.Length; i++)
			{
				NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
				fcbmpmcljhm.ICLNEPCODIK = this.IEICJDEDICD.Members[i];
				fcbmpmcljhm.CHLEPINFLEC = DateTime.UtcNow;
				this.HKNPDDMEOEG.Add(fcbmpmcljhm);
			}
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x00208790 File Offset: 0x00206990
	public void OFMMFLQGLHK(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.CNCFOFOMGHE().Rank == GuildRank.Moderator)
			{
				str = "17";
			}
			else if (fcbmpmcljhm.ICLNEPCODIK.Rank == (GuildRank)7)
			{
				str = "Logging in..";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Input Caret" + HHNBICLDQKI + "Super Repel" + str
		}, false);
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x00208818 File Offset: 0x00206A18
	public NOHEMGHONKK.FCBMPMCLJHM OEJPEEHPFIP(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.HKNPDDMEOEG.Count; i += 0)
		{
			if (this.HKNPDDMEOEG[i].QQQBCQECOKO().Username.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return this.HKNPDDMEOEG[i];
			}
		}
		return null;
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x00208874 File Offset: 0x00206A74
	public void QPIPHBQHBLJ(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		try
		{
			Texture2D texture2D = new Texture2D(8, 8);
			if (CBNJEBCHOEC.Data != null)
			{
				texture2D.LoadImage(CBNJEBCHOEC.Data);
				texture2D.filterMode = FilterMode.Point;
				texture2D.wrapMode = TextureWrapMode.Repeat;
				texture2D.anisoLevel = 0;
			}
			else
			{
				texture2D = null;
			}
			if (this.CHKOHCPMLKH.Count > 0)
			{
				for (int i = 1; i < this.CHKOHCPMLKH.Count; i += 0)
				{
					if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CBNJEBCHOEC.Name)
					{
						this.CHKOHCPMLKH[i].HKLENFFCEEQ = texture2D;
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
						return;
					}
				}
			}
			NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
			oqonekmgjdl.FPQBICGEHMJ = CBNJEBCHOEC.Name;
			oqonekmgjdl.HKLENFFCEEQ = texture2D;
			oqonekmgjdl.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
			this.CHKOHCPMLKH.Add(oqonekmgjdl);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x00208978 File Offset: 0x00206B78
	public void IJGPCGDMEIK(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Admin)
			{
				str = "Moderator";
			}
			else if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Moderator)
			{
				str = "User";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/guildrank " + HHNBICLDQKI + "," + str
		}, false);
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x00208A00 File Offset: 0x00206C00
	public void DDCBEMJHGKC(PSXAPI.Response.Guild CBNJEBCHOEC)
	{
		if (CBNJEBCHOEC == null)
		{
			return;
		}
		this.JHMOECBINHB = CBNJEBCHOEC.MembersCurrentMax;
		this.BKELMNMBQJK = CBNJEBCHOEC.MembersTotalMax;
		this.QBOLNQCDQPG = CBNJEBCHOEC.UpgradeGold;
		this.IPNQJGDIPMF = CBNJEBCHOEC.UpgradeMoney;
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = new PSXAPI.Response.Guild();
			if (CBNJEBCHOEC.Name != null)
			{
				this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
				this.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
			}
		}
		if (this.IEICJDEDICD.EmblemId != CBNJEBCHOEC.EmblemId)
		{
			this.IEICJDEDICD.EmblemId = CBNJEBCHOEC.EmblemId;
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.QEHBPIBLFQJ(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
		}
		if (this.IEICJDEDICD.Chat == default(Guid))
		{
			this.IEICJDEDICD.Chat = CBNJEBCHOEC.Chat;
			CNCJKLNHQBH.MOGQNGEPCEO().NMKPQPNNNEG(this.IEICJDEDICD.Chat.ToString());
		}
		if (CBNJEBCHOEC.Rank != GuildRank.Unset)
		{
			this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
		}
		if (CBNJEBCHOEC.Message != null)
		{
			this.IEICJDEDICD.Message = CBNJEBCHOEC.Message;
		}
		if (CBNJEBCHOEC.Name != null)
		{
			this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
		}
		if (CBNJEBCHOEC.Members != null)
		{
			this.IEICJDEDICD.Members = CBNJEBCHOEC.Members;
			this.HKNPDDMEOEG.Clear();
			for (int i = 0; i < this.IEICJDEDICD.Members.Length; i++)
			{
				NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
				fcbmpmcljhm.KEGKBBCKBBK(this.IEICJDEDICD.Members[i]);
				fcbmpmcljhm.CHLEPINFLEC = DateTime.UtcNow;
				this.HKNPDDMEOEG.Add(fcbmpmcljhm);
			}
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x00208BEC File Offset: 0x00206DEC
	public void PBQFMOEKDPL()
	{
		if (this.IEICJDEDICD.Rank == (GuildRank)8 || this.IEICJDEDICD.Rank == GuildRank.Creator)
		{
			this.OIPLMPPBQCL.BGBMIEJJQKC = JGDHIPBGCFP.NDFGOJOBPCJ(this.OIPLMPPBQCL.HJMJDJKOILH(), false);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Guild
			{
				Action = (GuildAction)3,
				Data = this.OIPLMPPBQCL.BGBMIEJJQKC
			}, false);
		}
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x0001C046 File Offset: 0x0001A246
	public static NOHEMGHONKK HGEKKNEPOHK()
	{
		return NOHEMGHONKK.HBFFCJHOCPE;
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00208C5C File Offset: 0x00206E5C
	public void HHFMOQBOOIO(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "_ProjInfo" + HHNBICLDQKI,
			Pokemon = null
		}, false);
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x00208CA0 File Offset: 0x00206EA0
	public void NMJGFFMPLGJ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Leave
		}, false);
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x00208CC8 File Offset: 0x00206EC8
	public void QJFFBMBJFMG(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.User)
			{
				str = "Moderator";
			}
			else if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Moderator)
			{
				str = "Admin";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/guildrank " + HHNBICLDQKI + "," + str
		}, false);
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00208D50 File Offset: 0x00206F50
	public void OBNMPEGBCHH()
	{
		if (this.IEICJDEDICD.Rank == GuildRank.Unset || this.IEICJDEDICD.Rank == GuildRank.Unset)
		{
			this.OIPLMPPBQCL.NCBFKNGMKPB(JGDHIPBGCFP.NDFGOJOBPCJ(this.OIPLMPPBQCL.HJMJDJKOILH(), true));
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
			{
				Action = (GuildAction)8,
				Data = this.OIPLMPPBQCL.BGBMIEJJQKC
			}, false);
		}
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x00208DC0 File Offset: 0x00206FC0
	public void UpdateMessage()
	{
		if (this.IEICJDEDICD.Rank == GuildRank.Admin || this.IEICJDEDICD.Rank == GuildRank.Creator)
		{
			this.OIPLMPPBQCL.BGBMIEJJQKC = JGDHIPBGCFP.NDFGOJOBPCJ(this.OIPLMPPBQCL.BGBMIEJJQKC, false);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
			{
				Action = GuildAction.Message,
				Data = this.OIPLMPPBQCL.BGBMIEJJQKC
			}, false);
		}
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x00208E30 File Offset: 0x00207030
	public void QJCHHICMPFQ(PSXAPI.Response.Guild CBNJEBCHOEC)
	{
		if (CBNJEBCHOEC == null)
		{
			return;
		}
		this.JHMOECBINHB = CBNJEBCHOEC.MembersCurrentMax;
		this.BKELMNMBQJK = CBNJEBCHOEC.MembersTotalMax;
		this.QBOLNQCDQPG = CBNJEBCHOEC.UpgradeGold;
		this.IPNQJGDIPMF = CBNJEBCHOEC.UpgradeMoney;
		if (this.IEICJDEDICD == null)
		{
			this.IEICJDEDICD = new PSXAPI.Response.Guild();
			if (CBNJEBCHOEC.Name != null)
			{
				this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
				this.KJQBFKQQKEO.GOIHJQNMMJD = this.QEHBPIBLFQJ(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
			}
		}
		if (this.IEICJDEDICD.EmblemId != CBNJEBCHOEC.EmblemId)
		{
			this.IEICJDEDICD.EmblemId = CBNJEBCHOEC.EmblemId;
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.QEHBPIBLFQJ(this.IEICJDEDICD.Name, (int)this.IEICJDEDICD.EmblemId);
		}
		if (this.IEICJDEDICD.Chat == default(Guid))
		{
			this.IEICJDEDICD.Chat = CBNJEBCHOEC.Chat;
			CNCJKLNHQBH.BJLGEDCPENQ().GFMGCOFHDNB(this.IEICJDEDICD.Chat.ToString());
		}
		if (CBNJEBCHOEC.Rank != GuildRank.Unset)
		{
			this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
		}
		if (CBNJEBCHOEC.Message != null)
		{
			this.IEICJDEDICD.Message = CBNJEBCHOEC.Message;
		}
		if (CBNJEBCHOEC.Name != null)
		{
			this.IEICJDEDICD.Name = CBNJEBCHOEC.Name;
		}
		if (CBNJEBCHOEC.Members != null)
		{
			this.IEICJDEDICD.Members = CBNJEBCHOEC.Members;
			this.HKNPDDMEOEG.Clear();
			for (int i = 0; i < this.IEICJDEDICD.Members.Length; i++)
			{
				NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
				fcbmpmcljhm.ICLNEPCODIK = this.IEICJDEDICD.Members[i];
				fcbmpmcljhm.CHLEPINFLEC = DateTime.UtcNow;
				this.HKNPDDMEOEG.Add(fcbmpmcljhm);
			}
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x0020901C File Offset: 0x0020721C
	public void LogoTab()
	{
		this.JOCEMQKOLGB(3);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(true);
		this.IQDCDBCPBEN[4].SetActive(false);
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x00209068 File Offset: 0x00207268
	public void HQIIHBBHLQQ()
	{
		if (this.IEICJDEDICD.Rank == (GuildRank)7 || this.IEICJDEDICD.Rank == GuildRank.Creator)
		{
			this.OIPLMPPBQCL.NCBFKNGMKPB(JGDHIPBGCFP.NDFGOJOBPCJ(this.OIPLMPPBQCL.BGBMIEJJQKC, true));
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
			{
				Action = (GuildAction)7,
				Data = this.OIPLMPPBQCL.BGBMIEJJQKC
			}, false);
		}
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x002090D8 File Offset: 0x002072D8
	public void InformationTab()
	{
		this.IQDCDBCPBEN[4].SetActive(true);
		this.JOCEMQKOLGB(0);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(false);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x0001C04D File Offset: 0x0001A24D
	private void Awake()
	{
		NOHEMGHONKK.HBFFCJHOCPE = this;
		this.JQFEQIOBKFC.CBGPDPJLFNE();
		this.MMCHEKMGLHI();
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00209138 File Offset: 0x00207338
	public void CJEFINGOOKD()
	{
		byte[] emblemData = this.HKLENFFCEEQ.DJBBLLJGBOL.EncodeToPNG();
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Emblem,
			EmblemData = emblemData
		}, false);
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x00209178 File Offset: 0x00207378
	public void BICCPQBPNJJ()
	{
		this.IQDCDBCPBEN[8].SetActive(false);
		this.JOCEMQKOLGB(0);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[7].SetActive(true);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x002091D8 File Offset: 0x002073D8
	public NOHEMGHONKK.FCBMPMCLJHM BDCQBPJNBKO(string HHNBICLDQKI)
	{
		for (int i = 0; i < this.HKNPDDMEOEG.Count; i++)
		{
			if (this.HKNPDDMEOEG[i].ICLNEPCODIK.Username.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return this.HKNPDDMEOEG[i];
			}
		}
		return null;
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
	public string MQFBIMJJOLM()
	{
		if (this.IEICJDEDICD != null && this.IEICJDEDICD.Name != null)
		{
			return this.IEICJDEDICD.Name;
		}
		return string.Empty;
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00209234 File Offset: 0x00207434
	public void KLKOGLJPOLD()
	{
		this.IQDCDBCPBEN[7].SetActive(true);
		this.JOCEMQKOLGB(1);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(true);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x00209294 File Offset: 0x00207494
	public void EHQJMJQQOBN(string CIQFCJGQEMH)
	{
		if (this.CHKOHCPMLKH.Count > 1)
		{
			for (int i = 0; i < this.CHKOHCPMLKH.Count; i++)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					this.CHKOHCPMLKH.RemoveAt(i);
					return;
				}
			}
		}
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x002092F0 File Offset: 0x002074F0
	public void BQHMBNHLPLM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = " is loafing around!\r\n" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x0020932C File Offset: 0x0020752C
	public Texture2D CLHBLLFPJMN(string CIQFCJGQEMH, int IFKCFHDEHEN = 0)
	{
		if (this.CHKOHCPMLKH.Count > 0)
		{
			for (int i = 0; i < this.CHKOHCPMLKH.Count; i++)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					if (this.CHKOHCPMLKH[i].EBDMBIIOKFJ != IFKCFHDEHEN)
					{
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = IFKCFHDEHEN;
						GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
						{
							Name = CIQFCJGQEMH
						}, false);
					}
					return this.CHKOHCPMLKH[i].HKLENFFCEEQ;
				}
			}
		}
		NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
		oqonekmgjdl.FPQBICGEHMJ = CIQFCJGQEMH;
		oqonekmgjdl.HKLENFFCEEQ = null;
		oqonekmgjdl.EBDMBIIOKFJ = IFKCFHDEHEN;
		this.CHKOHCPMLKH.Add(oqonekmgjdl);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
		{
			Name = CIQFCJGQEMH
		}, false);
		return null;
	}

	// Token: 0x06004200 RID: 16896 RVA: 0x0001C066 File Offset: 0x0001A266
	public void ODMBQIQHLBD(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
		}
		this.JMLOIKQLLHO();
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x00209410 File Offset: 0x00207610
	public void NKEKGDJKQIL(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD != null && CBNJEBCHOEC.Name == this.IEICJDEDICD.Name)
		{
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.ELDCDCOLJJE(this.IEICJDEDICD.Name, (int)CBNJEBCHOEC.EmblemId);
			if (CBNJEBCHOEC.Data != null && CBNJEBCHOEC.Data.Length > 0)
			{
				Texture2D texture2D = (Texture2D)this.KJQBFKQQKEO.GOIHJQNMMJD;
				this.HKLENFFCEEQ.DJBBLLJGBOL.SetPixels(texture2D.GetPixels());
				this.HKLENFFCEEQ.DJBBLLJGBOL.Apply();
			}
		}
		CGOIPHKQMPD cgoiphkqmpd = CGOIPHKQMPD.NKDNGLNOJJG();
		for (int i = 0; i < cgoiphkqmpd.MHQMLCJDMMK.Count; i += 0)
		{
			NOHCFICLIQK opilofijjdf = cgoiphkqmpd.MHQMLCJDMMK[i].LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF;
			if (opilofijjdf.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf.POHBDNPCEFH();
			}
		}
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.ODJQHLJCFGH();
		for (int j = 0; j < emlofjdomkh.MHQMLCJDMMK.Count; j += 0)
		{
			EHDQKOBOHPE opilofijjdf2 = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF;
			if (opilofijjdf2.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf2.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf2.QLCDJBNICOB();
			}
		}
		if (CBNJEBCHOEC.Name != null && CBNJEBCHOEC.Name == HDQHPMCPDNJ.ELBNNCEGBDH().IEICJDEDICD.PIDLOFMIEFQ)
		{
			HDQHPMCPDNJ.GDDGJKOLGIQ().KJQBFKQQKEO.GOIHJQNMMJD = this.IOCCGFNLFOB(CBNJEBCHOEC.Name, (int)CBNJEBCHOEC.EmblemId);
		}
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x002095B4 File Offset: 0x002077B4
	public void SendLogo()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild Logo", "Applying a new Guild Logo will cost [PG]300.\n\nAre you sure you want to do this?\nInappropriate images drawn will result in account termination.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x002095E0 File Offset: 0x002077E0
	public void RosterTab()
	{
		this.IQDCDBCPBEN[4].SetActive(true);
		this.JOCEMQKOLGB(1);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[3].SetActive(false);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00209640 File Offset: 0x00207840
	public void HHCOFNNLBDB(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.PLILIPBIEEL().Rank == GuildRank.Moderator)
			{
				str = "battle";
			}
			else if (fcbmpmcljhm.PLILIPBIEEL().Rank == GuildRank.Admin)
			{
				str = "Volcano Badge";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "L" + HHNBICLDQKI + "Removes additional effects to increase the power of moves when attacking." + str
		}, true);
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x002096C8 File Offset: 0x002078C8
	public void MIELHCCMDOE(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.EGELQFMIMGJ(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.CNCFOFOMGHE().Rank == GuildRank.User)
			{
				str = "!\r\n";
			}
			else if (fcbmpmcljhm.DGPLLFJGNPC().Rank == GuildRank.User)
			{
				str = "Heatproof";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "[FFFF00]/252" + HHNBICLDQKI + "IFGPPIQKOPM" + str
		}, false);
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00209750 File Offset: 0x00207950
	public void MECJMBNDFFD(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		try
		{
			Texture2D texture2D = new Texture2D(2, 2);
			if (CBNJEBCHOEC.Data != null)
			{
				texture2D.LoadImage(CBNJEBCHOEC.Data);
				texture2D.filterMode = FilterMode.Point;
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.anisoLevel = 0;
			}
			else
			{
				texture2D = null;
			}
			if (this.CHKOHCPMLKH.Count > 0)
			{
				for (int i = 0; i < this.CHKOHCPMLKH.Count; i++)
				{
					if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CBNJEBCHOEC.Name)
					{
						this.CHKOHCPMLKH[i].HKLENFFCEEQ = texture2D;
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
						return;
					}
				}
			}
			NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
			oqonekmgjdl.FPQBICGEHMJ = CBNJEBCHOEC.Name;
			oqonekmgjdl.HKLENFFCEEQ = texture2D;
			oqonekmgjdl.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
			this.CHKOHCPMLKH.Add(oqonekmgjdl);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x00209854 File Offset: 0x00207A54
	public void LGMMFCBFQGJ(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD != null && CBNJEBCHOEC.Name == this.IEICJDEDICD.Name)
		{
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(this.IEICJDEDICD.Name, (int)CBNJEBCHOEC.EmblemId);
			if (CBNJEBCHOEC.Data != null && CBNJEBCHOEC.Data.Length > 0)
			{
				Texture2D texture2D = (Texture2D)this.KJQBFKQQKEO.GOIHJQNMMJD;
				this.HKLENFFCEEQ.DJBBLLJGBOL.SetPixels(texture2D.GetPixels());
				this.HKLENFFCEEQ.DJBBLLJGBOL.Apply();
			}
		}
		CGOIPHKQMPD cgoiphkqmpd = CGOIPHKQMPD.CPLQICHLGCI();
		for (int i = 1; i < cgoiphkqmpd.MHQMLCJDMMK.Count; i += 0)
		{
			NOHCFICLIQK opilofijjdf = cgoiphkqmpd.MHQMLCJDMMK[i].LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF;
			if (opilofijjdf.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf.HLQDJGEGDKJ();
			}
		}
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.GPMJDKJFHMH();
		for (int j = 0; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
		{
			EHDQKOBOHPE opilofijjdf2 = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF;
			if (opilofijjdf2.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf2.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf2.JCELHBGBGQB();
			}
		}
		if (CBNJEBCHOEC.Name != null && CBNJEBCHOEC.Name == HDQHPMCPDNJ.OPJBMJFKIIJ().IEICJDEDICD.PIDLOFMIEFQ)
		{
			HDQHPMCPDNJ.NKFQOEQFFQH().KJQBFKQQKEO.GOIHJQNMMJD = this.ELDCDCOLJJE(CBNJEBCHOEC.Name, (int)CBNJEBCHOEC.EmblemId);
		}
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x002099F8 File Offset: 0x00207BF8
	public void JLGCKQBJNDC(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.OCBKMNOGIIP(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.ICLNEPCODIK.Rank == (GuildRank)5)
			{
				str = "Assets/AssetBundles/MapAssets/Models/Building_PokemonCentre/Materials/chip_mado.mat";
			}
			else if (fcbmpmcljhm.QQQBCQECOKO().Rank == (GuildRank)5)
			{
				str = "analytic";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "_" + HHNBICLDQKI + "physical" + str
		}, true);
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x00209A80 File Offset: 0x00207C80
	private void DGJBIBOMBKK(int DBPKNCDGGEP)
	{
		for (int i = 1; i < this.PKBOPNPKQOG.Length; i += 0)
		{
			if (i != DBPKNCDGGEP)
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = false;
			}
			else
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x0001C046 File Offset: 0x0001A246
	public static NOHEMGHONKK QBNCFLKLLKC()
	{
		return NOHEMGHONKK.HBFFCJHOCPE;
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x00209AEC File Offset: 0x00207CEC
	public Texture2D ELDCDCOLJJE(string CIQFCJGQEMH, int IFKCFHDEHEN = 0)
	{
		if (this.CHKOHCPMLKH.Count > 1)
		{
			for (int i = 1; i < this.CHKOHCPMLKH.Count; i += 0)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					if (this.CHKOHCPMLKH[i].EBDMBIIOKFJ != IFKCFHDEHEN)
					{
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = IFKCFHDEHEN;
						GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.GuildEmblem
						{
							Name = CIQFCJGQEMH
						}, true);
					}
					return this.CHKOHCPMLKH[i].HKLENFFCEEQ;
				}
			}
		}
		NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
		oqonekmgjdl.FPQBICGEHMJ = CIQFCJGQEMH;
		oqonekmgjdl.HKLENFFCEEQ = null;
		oqonekmgjdl.EBDMBIIOKFJ = IFKCFHDEHEN;
		this.CHKOHCPMLKH.Add(oqonekmgjdl);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.GuildEmblem
		{
			Name = CIQFCJGQEMH
		}, true);
		return null;
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x00209BD0 File Offset: 0x00207DD0
	public void IOHKDCCIIQF()
	{
		this.GIOGJMFFEEE = new Texture2D(125, 23);
		for (int i = 0; i < -44; i += 0)
		{
			for (int j = 1; j < 79; j++)
			{
				this.GIOGJMFFEEE.SetPixel(i, j, Color.clear);
			}
		}
		this.GIOGJMFFEEE.Apply();
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x00209C24 File Offset: 0x00207E24
	public NOHEMGHONKK.FCBMPMCLJHM EGELQFMIMGJ(string HHNBICLDQKI)
	{
		for (int i = 1; i < this.HKNPDDMEOEG.Count; i += 0)
		{
			if (this.HKNPDDMEOEG[i].DGPLLFJGNPC().Username.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant())
			{
				return this.HKNPDDMEOEG[i];
			}
		}
		return null;
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x00209C80 File Offset: 0x00207E80
	public void PKHNKJDMHBQ()
	{
		byte[] emblemData = this.HKLENFFCEEQ.DJBBLLJGBOL.EncodeToPNG();
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Guild
		{
			Action = (GuildAction)7,
			EmblemData = emblemData
		}, false);
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x00209CC0 File Offset: 0x00207EC0
	public void HQQINDDMMHI(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Hit " + HHNBICLDQKI,
			Pokemon = null
		}, true);
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00209D04 File Offset: 0x00207F04
	public void BPPMLEDHEBJ(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.QQQBCQECOKO().Rank == GuildRank.User)
			{
				str = "\n";
			}
			else if (fcbmpmcljhm.IMKLCGDOJOB().Rank == GuildRank.Creator)
			{
				str = "Pokémon Caught:";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "_FogPointLightPosition5" + HHNBICLDQKI + "COLOR_GRADING_LOG_VIEW" + str
		}, true);
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x00209D8C File Offset: 0x00207F8C
	public void MMCHEKMGLHI()
	{
		this.GIOGJMFFEEE = new Texture2D(32, 32);
		for (int i = 0; i < 32; i++)
		{
			for (int j = 0; j < 32; j++)
			{
				this.GIOGJMFFEEE.SetPixel(i, j, Color.clear);
			}
		}
		this.GIOGJMFFEEE.Apply();
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x00209DE0 File Offset: 0x00207FE0
	public void HLQHMDJLGQL(string JLOIIBQOJOO)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Create,
			Data = JLOIIBQOJOO
		}, false);
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x00209E10 File Offset: 0x00208010
	public void OGJBFHLGLJO(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.IMKLCGDOJOB().Rank == (GuildRank)6)
			{
				str = "PrimitiveInnerRearLeft";
			}
			else if (fcbmpmcljhm.PLILIPBIEEL().Rank == (GuildRank)6)
			{
				str = "3";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "3_" + HHNBICLDQKI + "leftovers" + str
		}, false);
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x00209E98 File Offset: 0x00208098
	public void NDOBCEBOLQN(GuildResult BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ.Result)
		{
		case GuildActionResult.Success:
			CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("pickup", "[-]!\r\n", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
			break;
		case GuildActionResult.InGuild:
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("[-]!\r\n", "Can't resolve the item ID of ", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
			break;
		case GuildActionResult.NotEnoughGold:
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF(", ", "Invalid Username or Password..", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
			break;
		case GuildActionResult.InvalidGuildName:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Player/Hats/", "-", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
			break;
		}
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x00209F50 File Offset: 0x00208150
	public void PLILFHPPQPM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/guild " + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x00209F8C File Offset: 0x0020818C
	public void LMODEIOHNHJ()
	{
		this.JOCEMQKOLGB(6);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[6].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x00209FD8 File Offset: 0x002081D8
	public void NNFQQJIQKNF(string CIQFCJGQEMH)
	{
		if (this.CHKOHCPMLKH.Count > 0)
		{
			for (int i = 0; i < this.CHKOHCPMLKH.Count; i++)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					this.CHKOHCPMLKH.RemoveAt(i);
					return;
				}
			}
		}
	}

	// Token: 0x06004218 RID: 16920 RVA: 0x0020A034 File Offset: 0x00208234
	public void EBPPPPHCLEP(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "-" + HHNBICLDQKI,
			Pokemon = null
		}, false);
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x0020A078 File Offset: 0x00208278
	public void BCLBQIKGKOO(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		try
		{
			Texture2D texture2D = new Texture2D(8, 3);
			if (CBNJEBCHOEC.Data != null)
			{
				texture2D.LoadImage(CBNJEBCHOEC.Data);
				texture2D.filterMode = FilterMode.Bilinear;
				texture2D.wrapMode = TextureWrapMode.Repeat;
				texture2D.anisoLevel = 1;
			}
			else
			{
				texture2D = null;
			}
			if (this.CHKOHCPMLKH.Count > 1)
			{
				for (int i = 1; i < this.CHKOHCPMLKH.Count; i += 0)
				{
					if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CBNJEBCHOEC.Name)
					{
						this.CHKOHCPMLKH[i].HKLENFFCEEQ = texture2D;
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
						return;
					}
				}
			}
			NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
			oqonekmgjdl.FPQBICGEHMJ = CBNJEBCHOEC.Name;
			oqonekmgjdl.HKLENFFCEEQ = texture2D;
			oqonekmgjdl.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
			this.CHKOHCPMLKH.Add(oqonekmgjdl);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x0600421A RID: 16922 RVA: 0x0020A17C File Offset: 0x0020837C
	public void OENHIQQHNGO(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "/gkick " + HHNBICLDQKI,
			Pokemon = null
		}, false);
	}

	// Token: 0x0600421B RID: 16923 RVA: 0x0020A1C0 File Offset: 0x002083C0
	public void JDBIPOBEMLF(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "-useMouse" + HHNBICLDQKI,
			Pokemon = null
		}, false);
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x0020A204 File Offset: 0x00208404
	public void IHOBFOQBNCD(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "." + HHNBICLDQKI,
			Pokemon = null
		}, false);
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x0020A248 File Offset: 0x00208448
	public void LJHDIMJMOOJ()
	{
		this.IQDCDBCPBEN[8].SetActive(true);
		this.ENHBOFFBGHC(1);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[7].SetActive(true);
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x0020A294 File Offset: 0x00208494
	private void JOCEMQKOLGB(int DBPKNCDGGEP)
	{
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i++)
		{
			if (i != DBPKNCDGGEP)
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = true;
			}
			else
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = false;
			}
		}
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x0020A300 File Offset: 0x00208500
	public void BICELHPDOJQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Emblem
		}, true);
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x0020A328 File Offset: 0x00208528
	public void FDFPPNHIKGN(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		try
		{
			Texture2D texture2D = new Texture2D(7, 0);
			if (CBNJEBCHOEC.Data != null)
			{
				texture2D.LoadImage(CBNJEBCHOEC.Data);
				texture2D.filterMode = FilterMode.Point;
				texture2D.wrapMode = TextureWrapMode.Clamp;
				texture2D.anisoLevel = 1;
			}
			else
			{
				texture2D = null;
			}
			if (this.CHKOHCPMLKH.Count > 1)
			{
				for (int i = 1; i < this.CHKOHCPMLKH.Count; i++)
				{
					if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CBNJEBCHOEC.Name)
					{
						this.CHKOHCPMLKH[i].HKLENFFCEEQ = texture2D;
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
						return;
					}
				}
			}
			NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
			oqonekmgjdl.FPQBICGEHMJ = CBNJEBCHOEC.Name;
			oqonekmgjdl.HKLENFFCEEQ = texture2D;
			oqonekmgjdl.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
			this.CHKOHCPMLKH.Add(oqonekmgjdl);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x06004221 RID: 16929 RVA: 0x0020A42C File Offset: 0x0020862C
	public void BuySpace()
	{
		if (INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB >= this.QBOLNQCDQPG && INFJMNPKNQF.QOQONHOOLNE.EPDKBQCHOJQ >= this.IPNQJGDIPMF)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Upgrade Guild", "Would like to increase the size of your guild member limit by 5?\nCost: " + ((this.IPNQJGDIPMF != 0u) ? ("[PD]" + this.IPNQJGDIPMF.ToString("#,##0") + ((this.QBOLNQCDQPG != 0u) ? " and " : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("[PG]" + this.QBOLNQCDQPG.ToString("#,##0")) : string.Empty), string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
			return;
		}
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Upgrading Guild", "You can not afford to increase your guild member limit.\nCost: " + ((this.IPNQJGDIPMF != 0u) ? ("[PD]" + this.IPNQJGDIPMF.ToString("#,##0") + ((this.QBOLNQCDQPG != 0u) ? " and " : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("[PG]" + this.QBOLNQCDQPG.ToString("#,##0")) : string.Empty), string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x0020A578 File Offset: 0x00208778
	public void RewardsTab()
	{
		this.IQDCDBCPBEN[4].SetActive(true);
		this.JOCEMQKOLGB(2);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(false);
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x0020A5C4 File Offset: 0x002087C4
	public void EFIOQDKLLOQ(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "]#" + HHNBICLDQKI
		}, false);
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x0020A600 File Offset: 0x00208800
	public void QHEDBICNJKN(string JLOIIBQOJOO)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Request,
			Data = JLOIIBQOJOO
		}, true);
	}

	// Token: 0x06004225 RID: 16933 RVA: 0x0020A630 File Offset: 0x00208830
	public void BKBJHDGQQMC()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("GUIElements/New Battle/MonsterMaterial", "0", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)6, false, null, -1, false);
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x0020A65C File Offset: 0x0020885C
	public void QNPFCMNEOEB(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD != null && CBNJEBCHOEC.Name == this.IEICJDEDICD.Name)
		{
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(this.IEICJDEDICD.Name, (int)CBNJEBCHOEC.EmblemId);
			if (CBNJEBCHOEC.Data != null && CBNJEBCHOEC.Data.Length > 0)
			{
				Texture2D texture2D = (Texture2D)this.KJQBFKQQKEO.GOIHJQNMMJD;
				this.HKLENFFCEEQ.DJBBLLJGBOL.SetPixels(texture2D.GetPixels());
				this.HKLENFFCEEQ.DJBBLLJGBOL.Apply();
			}
		}
		CGOIPHKQMPD qoqonhoolne = CGOIPHKQMPD.QOQONHOOLNE;
		for (int i = 0; i < qoqonhoolne.MHQMLCJDMMK.Count; i++)
		{
			NOHCFICLIQK opilofijjdf = qoqonhoolne.MHQMLCJDMMK[i].LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF;
			if (opilofijjdf.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf.EIOMPOHLEMC();
			}
		}
		EMLOFJDOMKH qoqonhoolne2 = EMLOFJDOMKH.QOQONHOOLNE;
		for (int j = 0; j < qoqonhoolne2.MHQMLCJDMMK.Count; j++)
		{
			EHDQKOBOHPE opilofijjdf2 = qoqonhoolne2.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF;
			if (opilofijjdf2.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf2.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf2.EIOMPOHLEMC();
			}
		}
		if (CBNJEBCHOEC.Name != null && CBNJEBCHOEC.Name == HDQHPMCPDNJ.QOQONHOOLNE.IEICJDEDICD.PIDLOFMIEFQ)
		{
			HDQHPMCPDNJ.QOQONHOOLNE.KJQBFKQQKEO.GOIHJQNMMJD = this.CLHBLLFPJMN(CBNJEBCHOEC.Name, (int)CBNJEBCHOEC.EmblemId);
		}
	}

	// Token: 0x06004227 RID: 16935 RVA: 0x0020A800 File Offset: 0x00208A00
	public void NNDMCDIHKHD()
	{
		if (INFJMNPKNQF.CFGIOIGOIFQ().QIOKIQOBMMB >= this.QBOLNQCDQPG && INFJMNPKNQF.CFGIOIGOIFQ().EPDKBQCHOJQ >= this.IPNQJGDIPMF)
		{
			CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("map", "_LogLut_Params" + ((this.IPNQJGDIPMF != 0u) ? ("|" + this.IPNQJGDIPMF.ToString("[ffb649]") + ((this.QBOLNQCDQPG != 0u) ? "item" : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("M" + this.QBOLNQCDQPG.ToString("bcam")) : string.Empty), string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)6, true, null, -1, true);
			return;
		}
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("laserfocus", "'s " + ((this.IPNQJGDIPMF != 0u) ? ("primal" + this.IPNQJGDIPMF.ToString("[00EE07]") + ((this.QBOLNQCDQPG != 0u) ? "Temporarily Suspended" : string.Empty)) : string.Empty) + ((this.QBOLNQCDQPG != 0u) ? ("Inner Focus" + this.QBOLNQCDQPG.ToString("CombinersUpAlphaBuff")) : string.Empty), string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x0020A94C File Offset: 0x00208B4C
	public void ECHKKDKEJML()
	{
		this.IQDCDBCPBEN[3].SetActive(true);
		this.ENHBOFFBGHC(7);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[7].SetActive(true);
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x0020A998 File Offset: 0x00208B98
	public void JKMOEODGNNI()
	{
		this.IQDCDBCPBEN[8].SetActive(true);
		this.DGJBIBOMBKK(1);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[7].SetActive(true);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.INJDHLQHFFD().QPPGQJFBPMH.gameObject);
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x00208CA0 File Offset: 0x00206EA0
	public void IQCOIDLHJPB(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = GuildAction.Leave
		}, false);
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x0001BFDF File Offset: 0x0001A1DF
	public void FEDPNNCQJFE(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Success)
		{
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x0020A9F8 File Offset: 0x00208BF8
	public void MDBCMFQHOKL()
	{
		this.IQDCDBCPBEN[6].SetActive(false);
		this.JOCEMQKOLGB(1);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(false);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.INJDHLQHFFD().QPPGQJFBPMH.gameObject);
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x0020AA58 File Offset: 0x00208C58
	public void QQOEEIQJNIP(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		try
		{
			Texture2D texture2D = new Texture2D(6, 2);
			if (CBNJEBCHOEC.Data != null)
			{
				texture2D.LoadImage(CBNJEBCHOEC.Data);
				texture2D.filterMode = FilterMode.Point;
				texture2D.wrapMode = TextureWrapMode.Repeat;
				texture2D.anisoLevel = 1;
			}
			else
			{
				texture2D = null;
			}
			if (this.CHKOHCPMLKH.Count > 1)
			{
				for (int i = 0; i < this.CHKOHCPMLKH.Count; i += 0)
				{
					if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CBNJEBCHOEC.Name)
					{
						this.CHKOHCPMLKH[i].HKLENFFCEEQ = texture2D;
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
						return;
					}
				}
			}
			NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
			oqonekmgjdl.FPQBICGEHMJ = CBNJEBCHOEC.Name;
			oqonekmgjdl.HKLENFFCEEQ = texture2D;
			oqonekmgjdl.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
			this.CHKOHCPMLKH.Add(oqonekmgjdl);
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x0020AB5C File Offset: 0x00208D5C
	public void KJCOQOOCLNF(PSXAPI.Response.GuildEmblem CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD != null && CBNJEBCHOEC.Name == this.IEICJDEDICD.Name)
		{
			this.KJQBFKQQKEO.GOIHJQNMMJD = this.QEHBPIBLFQJ(this.IEICJDEDICD.Name, (int)CBNJEBCHOEC.EmblemId);
			if (CBNJEBCHOEC.Data != null && CBNJEBCHOEC.Data.Length > 1)
			{
				Texture2D texture2D = (Texture2D)this.KJQBFKQQKEO.GOIHJQNMMJD;
				this.HKLENFFCEEQ.DJBBLLJGBOL.SetPixels(texture2D.GetPixels());
				this.HKLENFFCEEQ.DJBBLLJGBOL.Apply();
			}
		}
		CGOIPHKQMPD qoqonhoolne = CGOIPHKQMPD.QOQONHOOLNE;
		for (int i = 0; i < qoqonhoolne.MHQMLCJDMMK.Count; i += 0)
		{
			NOHCFICLIQK opilofijjdf = qoqonhoolne.MHQMLCJDMMK[i].LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF;
			if (opilofijjdf.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf.POHBDNPCEFH();
			}
		}
		EMLOFJDOMKH emlofjdomkh = EMLOFJDOMKH.ODJQHLJCFGH();
		for (int j = 1; j < emlofjdomkh.MHQMLCJDMMK.Count; j++)
		{
			EHDQKOBOHPE opilofijjdf2 = emlofjdomkh.MHQMLCJDMMK[j].NFOBFEGCJPB.OPILOFIJJDF;
			if (opilofijjdf2.DFMCFGLQLNL == CBNJEBCHOEC.Name)
			{
				opilofijjdf2.EBDMBIIOKFJ = (int)CBNJEBCHOEC.EmblemId;
				opilofijjdf2.PLOHFHEOCII();
			}
		}
		if (CBNJEBCHOEC.Name != null && CBNJEBCHOEC.Name == HDQHPMCPDNJ.OPJBMJFKIIJ().IEICJDEDICD.PIDLOFMIEFQ)
		{
			HDQHPMCPDNJ.NKFQOEQFFQH().KJQBFKQQKEO.GOIHJQNMMJD = this.IOCCGFNLFOB(CBNJEBCHOEC.Name, (int)CBNJEBCHOEC.EmblemId);
		}
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x0020AD00 File Offset: 0x00208F00
	public void QGBQQNIPFOK(string HHNBICLDQKI)
	{
		string str = string.Empty;
		if (this.IEICJDEDICD != null)
		{
			NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = this.BDCQBPJNBKO(HHNBICLDQKI);
			if (fcbmpmcljhm == null)
			{
				return;
			}
			if (fcbmpmcljhm.DGPLLFJGNPC().Rank == GuildRank.Admin)
			{
				str = "\nAccuracy: ";
			}
			else if (fcbmpmcljhm.CNCFOFOMGHE().Rank == GuildRank.Unset)
			{
				str = "return";
			}
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "#,##0" + HHNBICLDQKI + "inven " + str
		}, true);
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x0020AD88 File Offset: 0x00208F88
	public void MOHJEGDFMKF()
	{
		this.GIOGJMFFEEE = new Texture2D(-62, -78);
		for (int i = 1; i < 84; i += 0)
		{
			for (int j = 1; j < -68; j += 0)
			{
				this.GIOGJMFFEEE.SetPixel(i, j, Color.clear);
			}
		}
		this.GIOGJMFFEEE.Apply();
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x0020ADDC File Offset: 0x00208FDC
	public void FKOMEGBDBQG(GuildResult BJGCBDNBQCJ)
	{
		switch (BJGCBDNBQCJ.Result)
		{
		case GuildActionResult.Success:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild Success", "Guild created!", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			break;
		case GuildActionResult.InGuild:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Already in Guild", "You are already in a guild and can not do this.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			break;
		case GuildActionResult.NotEnoughGold:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild Creation", "You do not have enough gold to do that.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			break;
		case GuildActionResult.InvalidGuildName:
			CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Guild Name", "You can not create a guild with this name.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
			break;
		}
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x0001C077 File Offset: 0x0001A277
	public void KQQMIJKLNLE(PSXAPI.Response.Upgrade BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == UpgradeResult.Failed)
		{
		}
		this.PDDJMNOOPJD();
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x0020AE94 File Offset: 0x00209094
	public void BOEIMQICPLM(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
		{
			Action = (GuildAction)3
		}, true);
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06004234 RID: 16948 RVA: 0x0001C046 File Offset: 0x0001A246
	public static NOHEMGHONKK QOQONHOOLNE
	{
		get
		{
			return NOHEMGHONKK.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x0020AEBC File Offset: 0x002090BC
	public void FGCLJPFIHLB()
	{
		this.IQDCDBCPBEN[2].SetActive(true);
		this.JOCEMQKOLGB(1);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(true);
		IKBQNBHOJJB.OKLNNGPNIEO(CKMLKNPNPQO.QOQONHOOLNE.QPPGQJFBPMH.gameObject);
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x0020AF1C File Offset: 0x0020911C
	public void JPNJENBGPEC()
	{
		this.IQDCDBCPBEN[2].SetActive(false);
		this.DGJBIBOMBKK(6);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(true);
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x0020AF68 File Offset: 0x00209168
	public void EQNKDHNGLNI(GuildMember CBNJEBCHOEC)
	{
		if (this.IEICJDEDICD == null)
		{
			if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant() && !CBNJEBCHOEC.Removed)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Guild
				{
					Action = GuildAction.Request
				}, false);
			}
			return;
		}
		if (!CBNJEBCHOEC.Removed)
		{
			bool flag = true;
			int i = 0;
			while (i < this.IEICJDEDICD.Members.Length)
			{
				if (!(this.IEICJDEDICD.Members[i].Username == CBNJEBCHOEC.Username))
				{
					i++;
				}
				else
				{
					this.IEICJDEDICD.Members[i] = CBNJEBCHOEC;
					flag = false;
					IL_9C:
					if (flag)
					{
						GuildMember guildMember = new GuildMember();
						List<GuildMember> list = this.IEICJDEDICD.Members.ToList<GuildMember>();
						list.Add(CBNJEBCHOEC);
						this.IEICJDEDICD.Members = list.ToArray();
					}
					this.HKNPDDMEOEG.Clear();
					for (int j = 0; j < this.IEICJDEDICD.Members.Length; j++)
					{
						NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = new NOHEMGHONKK.FCBMPMCLJHM();
						fcbmpmcljhm.ICLNEPCODIK = this.IEICJDEDICD.Members[j];
						fcbmpmcljhm.CHLEPINFLEC = DateTime.UtcNow;
						this.HKNPDDMEOEG.Add(fcbmpmcljhm);
					}
					if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
					{
						this.IEICJDEDICD.Rank = CBNJEBCHOEC.Rank;
						goto IL_299;
					}
					goto IL_299;
				}
			}
			goto IL_9C;
		}
		if (CBNJEBCHOEC.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
		{
			if (this.IEICJDEDICD.Chat != default(Guid))
			{
				CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(this.IEICJDEDICD.Chat.ToString());
			}
			this.IEICJDEDICD = null;
			CKMLKNPNPQO.QOQONHOOLNE.ClickFriends();
			return;
		}
		for (int k = 0; k < this.IEICJDEDICD.Members.Length; k++)
		{
			if (this.IEICJDEDICD.Members[k].Username == CBNJEBCHOEC.Username)
			{
				List<GuildMember> list2 = this.IEICJDEDICD.Members.ToList<GuildMember>();
				list2.RemoveAt(k);
				this.IEICJDEDICD.Members = list2.ToArray();
				IL_23D:
				this.HKNPDDMEOEG.Clear();
				for (int l = 0; l < this.IEICJDEDICD.Members.Length; l++)
				{
					NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm2 = new NOHEMGHONKK.FCBMPMCLJHM();
					fcbmpmcljhm2.ICLNEPCODIK = this.IEICJDEDICD.Members[l];
					fcbmpmcljhm2.CHLEPINFLEC = DateTime.UtcNow;
					this.HKNPDDMEOEG.Add(fcbmpmcljhm2);
				}
				goto IL_299;
			}
		}
		goto IL_23D;
		IL_299:
		this.PDDJMNOOPJD();
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x0020B214 File Offset: 0x00209414
	public void LLQFJJQBCJE(string HHNBICLDQKI)
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatMessage
		{
			Channel = string.Empty,
			Message = "Username" + HHNBICLDQKI
		}, true);
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x0020B250 File Offset: 0x00209450
	public Texture2D QEHBPIBLFQJ(string CIQFCJGQEMH, int IFKCFHDEHEN = 0)
	{
		if (this.CHKOHCPMLKH.Count > 1)
		{
			for (int i = 1; i < this.CHKOHCPMLKH.Count; i++)
			{
				if (this.CHKOHCPMLKH[i].FPQBICGEHMJ == CIQFCJGQEMH)
				{
					if (this.CHKOHCPMLKH[i].EBDMBIIOKFJ != IFKCFHDEHEN)
					{
						this.CHKOHCPMLKH[i].EBDMBIIOKFJ = IFKCFHDEHEN;
						GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.GuildEmblem
						{
							Name = CIQFCJGQEMH
						}, false);
					}
					return this.CHKOHCPMLKH[i].HKLENFFCEEQ;
				}
			}
		}
		NOHEMGHONKK.OQONEKMGJDL oqonekmgjdl = new NOHEMGHONKK.OQONEKMGJDL();
		oqonekmgjdl.FPQBICGEHMJ = CIQFCJGQEMH;
		oqonekmgjdl.HKLENFFCEEQ = null;
		oqonekmgjdl.EBDMBIIOKFJ = IFKCFHDEHEN;
		this.CHKOHCPMLKH.Add(oqonekmgjdl);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.GuildEmblem
		{
			Name = CIQFCJGQEMH
		}, false);
		return null;
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
	public string LCIFOODLMLE()
	{
		if (this.IEICJDEDICD != null && this.IEICJDEDICD.Name != null)
		{
			return this.IEICJDEDICD.Name;
		}
		return string.Empty;
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x0020B334 File Offset: 0x00209534
	public void PDDJMNOOPJD()
	{
		if (this.IEICJDEDICD != null)
		{
			string text = string.Empty;
			if (this.IEICJDEDICD.Rank == GuildRank.Admin)
			{
				text = "Administrator";
			}
			else if (this.IEICJDEDICD.Rank == GuildRank.Creator)
			{
				text = "Creator";
			}
			else if (this.IEICJDEDICD.Rank == GuildRank.Moderator)
			{
				text = "Moderator";
			}
			else
			{
				text = "Member";
			}
			this.NDMODKPMMQH.PIDLOFMIEFQ = "Guild Name: " + this.IEICJDEDICD.Name + "\nRank: " + text;
			if (this.IEICJDEDICD.Message == null)
			{
				this.IEICJDEDICD.Message = string.Empty;
			}
			this.OIPLMPPBQCL.BGBMIEJJQKC = this.IEICJDEDICD.Message;
			this.OIPLMPPBQCL.PONHJCDKKEO();
			if (this.IEICJDEDICD.Rank != GuildRank.Admin)
			{
				if (this.IEICJDEDICD.Rank != GuildRank.Creator)
				{
					if (this.IQDCDBCPBEN[3].activeSelf)
					{
						this.InformationTab();
					}
					this.PKBOPNPKQOG[3].gameObject.SetActive(false);
					this.OIPLMPPBQCL.enabled = false;
					this.OIPLMPPBQCL.GetComponent<BoxCollider>().enabled = false;
					goto IL_152;
				}
			}
			this.OIPLMPPBQCL.enabled = true;
			this.OIPLMPPBQCL.GetComponent<BoxCollider>().enabled = true;
			this.PKBOPNPKQOG[3].gameObject.SetActive(true);
			IL_152:
			this.PMQOEMJKJML = this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.BGBMIEJJQKC;
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
			this.JHDGENGBPQF.transform.NMBPDMIIHJB();
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(0f, true);
			this.JHDGENGBPQF.gameObject.SetActive(false);
			int num = 0;
			if (this.HKNPDDMEOEG.Count > 0)
			{
				foreach (NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm in this.HKNPDDMEOEG)
				{
					CDLNFMKQOLO component = this.JHDGENGBPQF.gameObject.BFCKNMFEBDM(this.NDPNLKNIOLL).GetComponent<CDLNFMKQOLO>();
					component.EJINEJGDKBB = fcbmpmcljhm.ICLNEPCODIK.Online;
					component.MBPHKDQMJJH.PIDLOFMIEFQ = fcbmpmcljhm.ICLNEPCODIK.Username;
					component.DLJCDOLIQJQ();
					if (fcbmpmcljhm.ICLNEPCODIK.Online)
					{
						num++;
					}
					if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Admin)
					{
						text = "Administrator";
					}
					else if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Creator)
					{
						text = "Creator";
					}
					else if (fcbmpmcljhm.ICLNEPCODIK.Rank == GuildRank.Moderator)
					{
						text = "Moderator";
					}
					else
					{
						text = "Member";
					}
					component.PLCBFLQBCQN.PIDLOFMIEFQ = text;
					component.LIQLFCKICLQ.PIDLOFMIEFQ = string.Empty;
					if (!fcbmpmcljhm.ICLNEPCODIK.Online)
					{
						TimeSpan t = DateTime.UtcNow - fcbmpmcljhm.CHLEPINFLEC;
						t = fcbmpmcljhm.ICLNEPCODIK.Since + t;
						string text2 = "last online ";
						if (t.Days > 0)
						{
							if (t.Days > 1)
							{
								text2 = text2 + t.Days.ToString() + " days ago";
							}
							else
							{
								text2 = text2 + t.Days.ToString() + " day ago";
							}
						}
						else if (t.Hours > 0)
						{
							if (t.Hours > 1)
							{
								text2 = text2 + t.Hours.ToString() + " hours ago";
							}
							else
							{
								text2 = text2 + t.Hours.ToString() + " hour ago";
							}
						}
						else if (t.Minutes > 0)
						{
							if (t.Minutes > 1)
							{
								text2 = text2 + t.Minutes.ToString() + " minutes ago";
							}
							else
							{
								text2 = text2 + t.Minutes.ToString() + " minute ago";
							}
						}
						else
						{
							text2 += "less than 1 minute ago";
						}
						component.gameObject.name = "1_" + fcbmpmcljhm.ICLNEPCODIK.Username;
						component.LIQLFCKICLQ.PIDLOFMIEFQ = text2;
					}
					else
					{
						component.gameObject.name = "0_" + fcbmpmcljhm.ICLNEPCODIK.Username;
					}
				}
			}
			this.JHDGENGBPQF.gameObject.SetActive(true);
			this.JHDGENGBPQF.Reposition();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().KGCHHINLEBP();
			this.JHDGENGBPQF.transform.parent.GetComponent<FKBFPICKJQG>().FIKFOFFJJCC.PJMIKDIEGMB(this.PMQOEMJKJML, true);
			this.JHDGENGBPQF.CLQFFBMLIQH = true;
			this.GCEBIKJDPJE.PIDLOFMIEFQ = num.ToString() + "/" + this.JHMOECBINHB.ToString() + " Members Online.";
			if (this.JHMOECBINHB == this.BKELMNMBQJK)
			{
				this.JGDDJEBQLJN.SetActive(false);
			}
			else
			{
				this.JGDDJEBQLJN.SetActive(true);
			}
			if (this.IEICJDEDICD.Rank != GuildRank.Admin)
			{
				if (this.IEICJDEDICD.Rank != GuildRank.Creator)
				{
					this.JGDDJEBQLJN.SetActive(false);
				}
			}
		}
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x0020B92C File Offset: 0x00209B2C
	private void ENHBOFFBGHC(int DBPKNCDGGEP)
	{
		for (int i = 1; i < this.PKBOPNPKQOG.Length; i++)
		{
			if (i != DBPKNCDGGEP)
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = false;
			}
			else
			{
				this.PKBOPNPKQOG[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
				this.PKBOPNPKQOG[i].GetComponent<BoxCollider>().enabled = true;
			}
		}
	}

	// Token: 0x04000E56 RID: 3670
	private static NOHEMGHONKK HBFFCJHOCPE;

	// Token: 0x04000E57 RID: 3671
	public JIMBBPLINGI OIPLMPPBQCL;

	// Token: 0x04000E58 RID: 3672
	public BKKHLBCLPJM NDMODKPMMQH;

	// Token: 0x04000E59 RID: 3673
	public BONPIMMIEOJ JQFEQIOBKFC;

	// Token: 0x04000E5A RID: 3674
	public GameObject OBOGCMEHLKC;

	// Token: 0x04000E5B RID: 3675
	public GameObject[] IQDCDBCPBEN;

	// Token: 0x04000E5C RID: 3676
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000E5D RID: 3677
	public CFDMNELIJLO[] PKBOPNPKQOG;

	// Token: 0x04000E5E RID: 3678
	public PSXAPI.Response.Guild IEICJDEDICD;

	// Token: 0x04000E5F RID: 3679
	public JLMPBLMOICG KJQBFKQQKEO;

	// Token: 0x04000E60 RID: 3680
	public GameObject JGDDJEBQLJN;

	// Token: 0x04000E61 RID: 3681
	public List<NOHEMGHONKK.FCBMPMCLJHM> HKNPDDMEOEG = new List<NOHEMGHONKK.FCBMPMCLJHM>();

	// Token: 0x04000E62 RID: 3682
	private int JHMOECBINHB = 10;

	// Token: 0x04000E63 RID: 3683
	private int BKELMNMBQJK = 10;

	// Token: 0x04000E64 RID: 3684
	private uint QBOLNQCDQPG;

	// Token: 0x04000E65 RID: 3685
	private uint IPNQJGDIPMF;

	// Token: 0x04000E66 RID: 3686
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x04000E67 RID: 3687
	public GameObject NDPNLKNIOLL;

	// Token: 0x04000E68 RID: 3688
	public BKKHLBCLPJM GCEBIKJDPJE;

	// Token: 0x04000E69 RID: 3689
	private float PMQOEMJKJML;

	// Token: 0x04000E6A RID: 3690
	public BONPIMMIEOJ HKLENFFCEEQ;

	// Token: 0x04000E6B RID: 3691
	public List<NOHEMGHONKK.OQONEKMGJDL> CHKOHCPMLKH = new List<NOHEMGHONKK.OQONEKMGJDL>();

	// Token: 0x04000E6C RID: 3692
	public Texture2D GIOGJMFFEEE;

	// Token: 0x020001F7 RID: 503
	public class FCBMPMCLJHM
	{
		// Token: 0x0600423D RID: 16957 RVA: 0x0001C088 File Offset: 0x0001A288
		public void FNJDCQHOLCF(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x0001C091 File Offset: 0x0001A291
		// (set) Token: 0x06004241 RID: 16961 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public DateTime CHLEPINFLEC { get; set; }

		// Token: 0x0600423F RID: 16959 RVA: 0x0001C088 File Offset: 0x0001A288
		public void ELKEHBHKLDQ(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember QQQBCQECOKO()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime JPBMHJNNCID()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime LDPLCIJOHBQ()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember CNCFOFOMGHE()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public void LINPNCDEBLE(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime JBGOLGMIJPN()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x0001C088 File Offset: 0x0001A288
		public void FNILICBMCQI(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime GCLNHGDBIMC()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public void FHLLBNBDHQM(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime BCGPGDIHKKQ()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public void QEDNJLJQCLE(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime NHKCCQFNMOE()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x0001C099 File Offset: 0x0001A299
		// (set) Token: 0x0600424F RID: 16975 RVA: 0x0001C088 File Offset: 0x0001A288
		public GuildMember ICLNEPCODIK { get; set; }

		// Token: 0x06004250 RID: 16976 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime KDDLJNBJQPK()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0001C088 File Offset: 0x0001A288
		public void KEGKBBCKBBK(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime DGPCHQHCLCM()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		public void MHBNNLGJBCQ(DateTime BGBMIEJJQKC)
		{
			this.<ILEJGPICFKG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime BCLGHNBFPPF()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember PLILIPBIEEL()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime EOFBMBDLFPN()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime GQBIHKKEEGO()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0001C088 File Offset: 0x0001A288
		public void ICHHBGKMGQB(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember DGPLLFJGNPC()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember KHPFQDBQIJI()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0001C091 File Offset: 0x0001A291
		public DateTime QECMJHPGBJB()
		{
			return this.<ILEJGPICFKG>k__BackingField;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0001C099 File Offset: 0x0001A299
		public GuildMember IMKLCGDOJOB()
		{
			return this.<PMNJFDFIEQC>k__BackingField;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0001C088 File Offset: 0x0001A288
		public void MECJGDKQIJE(GuildMember BGBMIEJJQKC)
		{
			this.<PMNJFDFIEQC>k__BackingField = BGBMIEJJQKC;
		}
	}

	// Token: 0x020001F8 RID: 504
	public class OQONEKMGJDL
	{
		// Token: 0x04000E6F RID: 3695
		public string FPQBICGEHMJ;

		// Token: 0x04000E70 RID: 3696
		public Texture2D HKLENFFCEEQ;

		// Token: 0x04000E71 RID: 3697
		public int EBDMBIIOKFJ;
	}
}
