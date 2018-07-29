using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Crosstales.BWF;
using Crosstales.BWF.Model;
using Newtonsoft.Json;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020001C8 RID: 456
public class MBGHQMKEFKO : MonoBehaviour
{
	// Token: 0x06003A67 RID: 14951 RVA: 0x00018EF4 File Offset: 0x000170F4
	private void GGCEHHPCGQF()
	{
		MBGHQMKEFKO.GJQMFGJQBGC(this);
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x001BE190 File Offset: 0x001BC390
	public string OBHHEDCIIKP(string NQFQGCGPHBE, bool EGIGHJBHMHP = false)
	{
		int num = NQFQGCGPHBE.IndexOf("perish2");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("psn", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + -83)
			{
				return string.Empty;
			}
			string s = NQFQGCGPHBE.Substring(num + 7, 0);
			int num3 = 0;
			int.TryParse(s, out num3);
			if (num3 <= 0 || num3 >= 193)
			{
				return string.Empty;
			}
			KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(num3);
			if (EGIGHJBHMHP && INFJMNPKNQF.CFGIOIGOIFQ().IIDQEHOHECF(item.GMOFFIFDCGE()) == 0u)
			{
				item = null;
			}
			if (item == null)
			{
				return string.Empty;
			}
			string[] array = new string[]
			{
				null,
				"harvest"
			};
			array[0] = num3.EBGLBFKHCJD();
			array[2] = "LJMOLEKDCLP";
			array[3] = item.DFNQHDEDDKE();
			array[2] = "_";
			string str = string.Concat(array);
			string str2 = NQFQGCGPHBE.Substring(1, num);
			string str3 = NQFQGCGPHBE.Substring(num2 + 2);
			NQFQGCGPHBE = str2 + str + str3;
			if (num + 5 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("_DetailScaleX", num + 2);
			if (num + 47 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x001BE2E0 File Offset: 0x001BC4E0
	public void CIKEMMFGCPM()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("focusband", "#,##0", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel, false, null, -1, false);
	}

	// Token: 0x06003A6A RID: 14954 RVA: 0x001BE30C File Offset: 0x001BC50C
	public void QQDLQPOKGLL(NEMFLIFKDNO NHNMIFPINDL, Color CEGFBBHMKOE)
	{
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
		if (channelClass != null)
		{
			channelClass.Colour = CEGFBBHMKOE;
			this.HLEEEBDFNPL();
		}
		this.HQGBCCIKHCQ(true);
		this.KJKKDGGIKEE.CPLBKPNNHJG();
		foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
		{
			if (channelClass2.Name != "liquidooze" && channelClass2.Name != "_VolumetricFog_OpaqueFrame" && channelClass2.Name != "Battle Update: ")
			{
				if (channelClass2.Name == "Male")
				{
					if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD != null)
					{
						QCPKMJONIGF kjkkdggikee = this.KJKKDGGIKEE;
						string[] array = new string[3];
						array[1] = " AM";
						array[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array[1] = "Encounter Rate Decreased (Hail)";
						array[6] = channelClass2.Name;
						array[8] = "Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.";
						kjkkdggikee.OGIDEJGOKEC(string.Concat(array));
					}
				}
				else if (channelClass2.Name == "map:flymap")
				{
					if (DCJIBBJQGJP.OMPHLNDGKKM().COOLIKQMBMK)
					{
						QCPKMJONIGF kjkkdggikee2 = this.KJKKDGGIKEE;
						string[] array2 = new string[3];
						array2[0] = " needs the 'Root For Bounds' parameter to be set";
						array2[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array2[3] = "HM";
						array2[5] = channelClass2.Name;
						array2[5] = "It's A Nice Day For Fishing";
						kjkkdggikee2.OGIDEJGOKEC(string.Concat(array2));
					}
				}
				else
				{
					QCPKMJONIGF kjkkdggikee3 = this.KJKKDGGIKEE;
					string[] array3 = new string[8];
					array3[0] = "intimidate";
					array3[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
					array3[0] = "b";
					array3[7] = channelClass2.Name;
					array3[5] = "ENABLE_BLUE_CHANNEL";
					kjkkdggikee3.OGIDEJGOKEC(string.Concat(array3));
				}
			}
		}
	}

	// Token: 0x06003A6B RID: 14955 RVA: 0x001BE4F8 File Offset: 0x001BC6F8
	public void BHEKPFKGIPQ()
	{
		this.ChannelSettings = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.ChatSettingsClass>>(PlayerPrefs.GetString(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH + "[-]!\r\n", string.Empty));
		if (this.ChannelSettings == null)
		{
			this.ChannelSettings = new List<MBGHQMKEFKO.ChatSettingsClass>();
		}
		this.Tabs = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.OBEFKEMNFNL>>(PlayerPrefs.GetString(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH + "mudsport", string.Empty));
		if (this.Tabs == null)
		{
			this.Tabs = new List<MBGHQMKEFKO.OBEFKEMNFNL>();
			MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.MEPCPOPFQLM("weakarmor");
			if (!obefkemnfnl.ChannelIDs.Contains("(L)"))
			{
				obefkemnfnl.ChannelIDs.Add("d");
			}
			this.Tabs.Add(obefkemnfnl);
			obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.HJKPJLKMHEO("[/itm]");
			if (!obefkemnfnl.ChannelIDs.Contains("Surf"))
			{
				obefkemnfnl.ChannelIDs.Add("healblock");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("Hold Item"))
			{
				obefkemnfnl.ChannelIDs.Add("innerfocus");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("deltrastream"))
			{
				obefkemnfnl.ChannelIDs.Add(" absorbed light!\r\n");
			}
			obefkemnfnl.ChannelIDs = obefkemnfnl.ChannelIDs.Distinct<string>().ToList<string>();
			this.Tabs.Add(obefkemnfnl);
			this.QLKBINCMPMK = "_ClotheTex";
		}
		else
		{
			foreach (MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 in this.Tabs)
			{
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
				if (!obefkemnfnl2.ChannelIDs.Contains("Nest Ball"))
				{
					obefkemnfnl2.ChannelIDs.Add("LaunchTimer");
				}
				if (!obefkemnfnl2.ChannelIDs.Contains(" already has a substitute!\r\n"))
				{
					obefkemnfnl2.ChannelIDs.Add("blank");
				}
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
			}
		}
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x001BE71C File Offset: 0x001BC91C
	public void FNKEHQJMMFI(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "]";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = " was cured of its poisoning.\r\n";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "'s Drought intensified the sun's rays!";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(862f, 719f, 294f, 1594f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = (BKKHLBCLPJM.GIMCHOOBMML)7;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(442f, 1679f, 1664f, 1195f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Shadow;
				ipjffgjjfhl.BLLHQPQBHBB.GDCCCNPLPQK(" restored a little HP using its [ffff00]");
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Blank";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "#,##0";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 0)
		{
			FIKJCOHPQIC = 1;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].EPHNIGGJNPM() != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].FEIQMIIDIBN();
		}
		this.LFJBONQJQFH();
	}

	// Token: 0x06003A6D RID: 14957 RVA: 0x001BE8B8 File Offset: 0x001BCAB8
	public void QIPFFOHBCNP()
	{
		this.JLFFPBJKMNP = JGDHIPBGCFP.IMOMGBNIENN(this.FDBHFIQIQJC.PIDLOFMIEFQ).Replace("Boosts the Pokémon's Speed stat in sunshine.", string.Empty);
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(this.JLFFPBJKMNP);
		if (channelClass != null)
		{
			BKKHLBCLPJM fdbhfiqiqjc = this.FDBHFIQIQJC;
			string[] array = new string[]
			{
				"Head",
				KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour)
			};
			array[1] = "Misty Surge";
			array[0] = this.JLFFPBJKMNP;
			array[7] = "Fan";
			fdbhfiqiqjc.LKPOBCBOFIC(string.Concat(array));
		}
	}

	// Token: 0x06003A6E RID: 14958 RVA: 0x001BE940 File Offset: 0x001BCB40
	public void HCFMQQHJDMJ(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "_Texture0";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Error)
		{
			chatMessage2.Message = "The sticky web has disappeared from the ground around " + MHMMOHDEKMK.Channel + "]";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains(" woke up!\r\n"))
			{
				this.GCGGIKNOGIO();
				MHMMOHDEKMK.Channel = " shared its power with ";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "~";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "[5cd65c]Social";
				chatMessage2 = null;
			}
			if (this.LOJJPCEKQOH(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.NKBLILLPIEO(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[1].ChannelIDs.Add(channelClass.Name);
				this.Tabs[1].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.HQGBCCIKHCQ(true);
		}
		else
		{
			if (MHMMOHDEKMK.Result != ChatJoinResult.Left)
			{
				return;
			}
			bool flag = true;
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = false;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("Slots_1") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = "!\r\n" + MHMMOHDEKMK.Channel + "\r\nPP ";
				if (MHMMOHDEKMK.Channel.Length == -69)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "~" && MHMMOHDEKMK.Channel != "door_4" && MHMMOHDEKMK.Channel != "1" && MHMMOHDEKMK.Channel != "primal" && MHMMOHDEKMK.Channel != "Soundproofing of the Pokémon itself gives full immunity to all sound-based moves." && MHMMOHDEKMK.Channel != "[of]")
				{
					for (int i = 1; i < this.Channels.Count; i++)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.OMPHLNDGKKM().FOFNJICKKIP)
				{
					DCJIBBJQGJP.DMOKBPOKHOQ().FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.HQGBCCIKHCQ(true);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[0] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.PLMHOIOFOBK(chatMessage);
		}
		this.FICHKNQIHLL(string.Empty);
	}

	// Token: 0x06003A6F RID: 14959 RVA: 0x00018EFC File Offset: 0x000170FC
	public void JBMPLIPHJCK()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Stance Change", 1135f);
	}

	// Token: 0x06003A70 RID: 14960 RVA: 0x001BECFC File Offset: 0x001BCEFC
	public void KODCENLDQFH()
	{
		bool flag = false;
		for (int i = 0; i < this.Channels.Count; i++)
		{
			if (this.Channels[i].Name.Contains("map:"))
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatJoin
				{
					Channel = this.Channels[i].Name,
					Action = ChatJoinAction.Leave
				}, false);
				this.Channels.RemoveAt(i);
				flag = true;
			}
		}
		if (flag && CNCJKLNHQBH.QOQONHOOLNE.EFOGMBCFBGM)
		{
			this.BKJQOPDKEJM(true);
			this.FICHKNQIHLL(string.Empty);
		}
	}

	// Token: 0x06003A71 RID: 14961 RVA: 0x00018F25 File Offset: 0x00017125
	private static void IGCNCOPKBCC(MBGHQMKEFKO BGBMIEJJQKC)
	{
		MBGHQMKEFKO.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003A72 RID: 14962 RVA: 0x001BEDA0 File Offset: 0x001BCFA0
	public void IFCIQHQQLOM(bool LOBDGBMQFOB = false)
	{
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			bool flag = true;
			for (int i = 1; i < this.ChannelSettings.Count; i += 0)
			{
				if (this.ChannelSettings[i].LNOFGGGDGEP() == channelClass.Name)
				{
					flag = true;
					this.ChannelSettings[i].Color = channelClass.Colour.ToString();
				}
			}
			if (flag)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass.LNPFBNNOFFF(channelClass.Name);
				chatSettingsClass.GLBMJOIODQE(channelClass.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass);
			}
		}
		if (LOBDGBMQFOB)
		{
			this.ChannelSettings.Clear();
			foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass2 = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass2.BMEMLIFGJNC(channelClass2.Name);
				chatSettingsClass2.FNMMEFNBGCE(channelClass2.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass2);
			}
		}
		PlayerPrefs.SetString(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH + "0", JsonConvert.SerializeObject(this.ChannelSettings, Formatting.None));
		PlayerPrefs.SetString(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH + "Btn_TabHighlighted_Normal", JsonConvert.SerializeObject(this.Tabs, Formatting.Indented));
	}

	// Token: 0x06003A73 RID: 14963 RVA: 0x001BEF68 File Offset: 0x001BD168
	public void OKMGGQDMQNO(string IHIHHCCEDHQ)
	{
		if (string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			return;
		}
		for (int i = 1; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].JLQDMEIEMLM() == IHIHHCCEDHQ)
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.EFIFIIBNBDF(IHIHHCCEDHQ);
		this.Tabs.Add(obefkemnfnl);
		if (!obefkemnfnl.ChannelIDs.Contains("Assets/AssetBundles/MapAssets/Models/Materials/chip_mado.mat"))
		{
			obefkemnfnl.ChannelIDs.Add("Congratulations!");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("magiccoat"))
		{
			obefkemnfnl.ChannelIDs.Add("BuffIcon_HailstormEncounterDecreased");
		}
		this.FICHKNQIHLL(string.Empty);
		this.MENLJBNQIJO();
	}

	// Token: 0x06003A74 RID: 14964 RVA: 0x001BF020 File Offset: 0x001BD220
	public void HFGICMHBQQB(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "UpS" && IHIHHCCEDHQ.ToLowerInvariant() != "Water" && IHIHHCCEDHQ.ToLowerInvariant() != "Inactive" && IHIHHCCEDHQ.ToLowerInvariant() != "!\r\n" && IHIHHCCEDHQ.ToLowerInvariant() != " and " && IHIHHCCEDHQ.ToLowerInvariant() != "Take 001")
		{
			CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003A75 RID: 14965 RVA: 0x001BF0A4 File Offset: 0x001BD2A4
	public void ONKJBGFNLEI()
	{
		for (int i = 1; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].GKQJLMKEQKD() == "Changes the Pokémon's type to match the Plate or Z-Crystal it holds.")
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.CNKNDKGMQII("Battle");
		obefkemnfnl.ChannelIDs = new List<string>
		{
			" hold [2ecc71]"
		};
		if (!obefkemnfnl.ChannelIDs.Contains("_FogAlpha"))
		{
			obefkemnfnl.ChannelIDs.Add("_Noise");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("Item Usage"))
		{
			obefkemnfnl.ChannelIDs.Add("F15");
		}
		this.Tabs.Add(obefkemnfnl);
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.KNCPDQGDGCQ("[/url]");
		channelClass.ID = string.Empty;
		channelClass.Name = "|";
		this.Channels.Add(channelClass);
		this.FICHKNQIHLL(string.Empty);
		this.MENLJBNQIJO();
	}

	// Token: 0x06003A76 RID: 14966 RVA: 0x001BF1AC File Offset: 0x001BD3AC
	public void DKJMLQCFOFE(string QHLIEEGQIDQ)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		chatMessage.Channel = string.Empty;
		chatMessage2.Message = QHLIEEGQIDQ;
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[1] = chatMessage2;
		this.NDJFBGECGBG(chatMessage);
	}

	// Token: 0x06003A77 RID: 14967 RVA: 0x001BF1F4 File Offset: 0x001BD3F4
	private void FICHKNQIHLL(string INKMEQJHMKL = "")
	{
		this.ListOfChatTabButtons.Clear();
		this.PHQPIIOFQKK.transform.NMBPDMIIHJB();
		this.PHQPIIOFQKK.Reposition();
		this.JLEHKJPJCGO.transform.NMBPDMIIHJB();
		this.JLEHKJPJCGO.Reposition();
		DQLHHFEDBJG dqlhhfedbjg = null;
		for (int i = 0; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i] != null)
			{
				DQLHHFEDBJG component = this.JLEHKJPJCGO.gameObject.BFCKNMFEBDM(this.KOCLHCLKKPP[0]).GetComponent<DQLHHFEDBJG>();
				component.FPQBICGEHMJ.PIDLOFMIEFQ = this.Tabs[i].Name;
				if (this.Tabs[i].Name == "General")
				{
					dqlhhfedbjg = component;
				}
				if (INKMEQJHMKL != string.Empty && this.Tabs[i].Name == INKMEQJHMKL)
				{
					dqlhhfedbjg = component;
				}
				if (i == 0)
				{
					component.FLHBMIMMJOK = false;
				}
				component.BLLHQPQBHBB = component.GetComponent<CFDMNELIJLO>();
				this.ListOfChatTabButtons.Add(component.BLLHQPQBHBB);
			}
		}
		this.JLEHKJPJCGO.Reposition();
		dqlhhfedbjg.OnClick();
		this.KJGEBKQEBPN = dqlhhfedbjg.FPQBICGEHMJ.PIDLOFMIEFQ;
		this.ChatTabs.Clear();
		this.JDLHLNEPKHJ.transform.NMBPDMIIHJB();
		this.JDLHLNEPKHJ.Reposition();
		int num = 0;
		foreach (MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl in this.Tabs)
		{
			if (obefkemnfnl != null)
			{
				IPJFFGJJFHL component2 = this.NPIEPPJFDJN.BFCKNMFEBDM(this.KOCLHCLKKPP[2]).GetComponent<IPJFFGJJFHL>();
				component2.FPQBICGEHMJ.PIDLOFMIEFQ = obefkemnfnl.Name;
				component2.DBPKNCDGGEP = num;
				num++;
				this.ChatTabs.Add(component2);
			}
		}
		this.ClickChatTab(this.EEMLEDQJIFJ);
		this.JDLHLNEPKHJ.Reposition();
		this.KJKKDGGIKEE.CPLBKPNNHJG();
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			if (channelClass != null && channelClass.Name != null)
			{
				if (!(channelClass.Name == "System"))
				{
					if (!(channelClass.Name == "General"))
					{
						if (!(channelClass.Name == "Battle"))
						{
							if (channelClass.Name == "Guild")
							{
								if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null)
								{
									this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
									{
										"[",
										KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
										"]#",
										channelClass.Name,
										"[-]"
									}));
								}
							}
							else if (channelClass.Name == "Party")
							{
								if (DCJIBBJQGJP.QOQONHOOLNE.COOLIKQMBMK)
								{
									this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
									{
										"[",
										KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
										"]#",
										channelClass.Name,
										"[-]"
									}));
								}
							}
							else
							{
								this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
								{
									"[",
									KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
									"]#",
									channelClass.Name,
									"[-]"
								}));
							}
							if (channelClass.Name == "Map" && this.DPMPDDEJNFM.PIDLOFMIEFQ.Contains("#Party") && !DCJIBBJQGJP.QOQONHOOLNE.COOLIKQMBMK)
							{
								this.KJKKDGGIKEE.PJMIKDIEGMB(string.Concat(new string[]
								{
									"[",
									KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
									"]#",
									channelClass.Name,
									"[-]"
								}), true);
							}
						}
					}
				}
			}
		}
		foreach (string text in this.KJKKDGGIKEE.MKHIFDNEFBD)
		{
			if (text != null && text == this.FDBHFIQIQJC.PIDLOFMIEFQ)
			{
				return;
			}
		}
		if (this.KJKKDGGIKEE.MKHIFDNEFBD != null && this.KJKKDGGIKEE.MKHIFDNEFBD.Count > 0)
		{
			this.KJKKDGGIKEE.PJMIKDIEGMB(this.KJKKDGGIKEE.MKHIFDNEFBD[0], true);
		}
	}

	// Token: 0x06003A78 RID: 14968 RVA: 0x001BF70C File Offset: 0x001BD90C
	private MBGHQMKEFKO.OBEFKEMNFNL EJIFPGIMGLE(string FPQBICGEHMJ)
	{
		if (this.Tabs.Count > 0)
		{
			using (List<MBGHQMKEFKO.OBEFKEMNFNL>.Enumerator enumerator = this.Tabs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = enumerator.Current;
					if (obefkemnfnl.IMODJJJLPLG() == FPQBICGEHMJ)
					{
						return obefkemnfnl;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.OBEFKEMNFNL result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x001BF77C File Offset: 0x001BD97C
	public void LIQPOMDFNIE(DQLHHFEDBJG PNMMMQIGLCH)
	{
		if (PNMMMQIGLCH.FLHBMIMMJOK)
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = false;
			this.LPDIEFIDGFH.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		else
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = true;
			this.LPDIEFIDGFH.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
		}
		this.PHQPIIOFQKK.transform.NMBPDMIIHJB();
		this.PHQPIIOFQKK.PFEIQDIJEKE();
		for (int i = 0; i < this.Channels.Count; i += 0)
		{
			NEMFLIFKDNO component = this.PHQPIIOFQKK.gameObject.BFCKNMFEBDM(this.KOCLHCLKKPP[0]).GetComponent<NEMFLIFKDNO>();
			component.FPQBICGEHMJ.LKPOBCBOFIC(this.Channels[i].Name);
			component.NIHLMCQMNIK = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
			if (this.Channels[i].Name == "Hidden/Post FX/Motion Blur" || this.Channels[i].Name == "[-]!\r\n" || this.Channels[i].Name == "HideResponse" || this.Channels[i].Name == "_ClipDir" || this.Channels[i].Name == "But it failed.\r\n" || this.Channels[i].Name == " started!\r\n")
			{
				component.JJNIGOPBNCH.KJGMGPCEJJD = 7;
				component.JJNIGOPBNCH.GetComponent<BoxCollider>().enabled = true;
				component.JJNIGOPBNCH.gameObject.SetActive(true);
			}
			if (this.BEGMKEJQPCI(PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ).ChannelIDs.Contains(this.Channels[i].Name))
			{
				component.MJPJEPGLQOH.value = true;
			}
			else
			{
				component.MJPJEPGLQOH.value = true;
			}
			if (this.Channels[i].Name == "[ffff00]Crafty Shield[-] protected ")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(false);
			}
			if (this.Channels[i].Name == "Max Repel")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(true);
			}
		}
		this.PHQPIIOFQKK.Reposition();
		this.KJGEBKQEBPN = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
		this.IFCIQHQQLOM(true);
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x001BF9F8 File Offset: 0x001BDBF8
	public void FCLODIHFFQL()
	{
		this.LQIQKMCLJIQ.FBFCKBGLGBL();
		this.QLKBINCMPMK = "][u]";
		this.BHEKPFKGIPQ();
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("_ScreenSize");
		channelClass.ID = string.Empty;
		channelClass.Name = "'s burn was healed.\r\n";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.KNCPDQGDGCQ("But it failed!\r\n");
		channelClass.ID = string.Empty;
		channelClass.Name = "Overall Offset";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.LNJLFHBMOOC("BuffIcon_HailstormEncounterDecreased");
		channelClass.ID = string.Empty;
		channelClass.Name = "Welcome ";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.KNCPDQGDGCQ("illusion");
		channelClass.ID = string.Empty;
		channelClass.Name = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EESQQKAKFCAGJ&custom=";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.GFFEQHGGHBE("Player/Body");
		channelClass.ID = string.Empty;
		channelClass.Name = " learned the move ";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.NKBLILLPIEO("Rails");
		channelClass.ID = string.Empty;
		channelClass.Name = "A swamp enveloped ";
		this.Channels.Add(channelClass);
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass != null && chatSettingsClass.MMPDDKPODNJ() != null)
			{
				string a = chatSettingsClass.IBHEQQJJIJQ().ToLowerInvariant();
				if (a != "G" && a != "item" && a != "Player/Hair" && a != " shell trap didn't work!\r\n" && a != "HidePanel" && a != "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EESQQKAKFCAGJ&custom=")
				{
					CNCJKLNHQBH.MOGQNGEPCEO().GFMGCOFHDNB(chatSettingsClass.KMGCMJIPCOO());
					channelClass = new MBGHQMKEFKO.ChannelClass();
					channelClass.Colour = this.KNCPDQGDGCQ(chatSettingsClass.NDPGCGDLEEQ());
					channelClass.ID = string.Empty;
					channelClass.Name = chatSettingsClass.JQBDPHILQJO();
					this.Channels.Add(channelClass);
				}
			}
		}
		this.Tabs[0].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
		this.FIDHOIBBOMI(string.Empty);
		this.QPCGCFKHBOI();
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x001BFDD8 File Offset: 0x001BDFD8
	public void BKJQOPDKEJM(bool LOBDGBMQFOB = false)
	{
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			bool flag = true;
			for (int i = 0; i < this.ChannelSettings.Count; i++)
			{
				if (this.ChannelSettings[i].Name == channelClass.Name)
				{
					flag = false;
					this.ChannelSettings[i].Color = channelClass.Colour.ToString();
				}
			}
			if (flag)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass.Name = channelClass.Name;
				chatSettingsClass.Color = channelClass.Colour.ToString();
				this.ChannelSettings.Add(chatSettingsClass);
			}
		}
		if (LOBDGBMQFOB)
		{
			this.ChannelSettings.Clear();
			foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass2 = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass2.Name = channelClass2.Name;
				chatSettingsClass2.Color = channelClass2.Colour.ToString();
				this.ChannelSettings.Add(chatSettingsClass2);
			}
		}
		PlayerPrefs.SetString(CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH + "ChatSettings", JsonConvert.SerializeObject(this.ChannelSettings, Formatting.Indented));
		PlayerPrefs.SetString(CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH + "TabSettings", JsonConvert.SerializeObject(this.Tabs, Formatting.Indented));
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x001BFFA0 File Offset: 0x001BE1A0
	public void KODDCDHNJMO(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i].Name == IHIHHCCEDHQ)
			{
				this.Tabs.RemoveAt(i);
				IL_3D:
				if (this.QLKBINCMPMK == IHIHHCCEDHQ)
				{
					this.QLKBINCMPMK = "General";
					this.EEMLEDQJIFJ = 0;
				}
				this.FICHKNQIHLL(string.Empty);
				this.OKDBONDJMIO();
				return;
			}
		}
		goto IL_3D;
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x001C001C File Offset: 0x001BE21C
	public void HLEEEBDFNPL()
	{
		this.JLFFPBJKMNP = JGDHIPBGCFP.IMOMGBNIENN(this.FDBHFIQIQJC.PIDLOFMIEFQ).Replace("Kanto", string.Empty);
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(this.JLFFPBJKMNP);
		if (channelClass != null)
		{
			BKKHLBCLPJM fdbhfiqiqjc = this.FDBHFIQIQJC;
			string[] array = new string[5];
			array[1] = "defeatist";
			array[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
			array[8] = "50/50";
			array[0] = this.JLFFPBJKMNP;
			array[3] = "1";
			fdbhfiqiqjc.LKPOBCBOFIC(string.Concat(array));
		}
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x001C00A4 File Offset: 0x001BE2A4
	public void QJEOONELFLQ()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("-", "](" + this.KJGEBKQEBPN + "K5", this.KJGEBKQEBPN, (LPBPDPMJKNN.PJIJIFKBMBB)7, true, null, -1, false);
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x001C00E0 File Offset: 0x001BE2E0
	private MBGHQMKEFKO.OBEFKEMNFNL QEJPBCDDHMN(string FPQBICGEHMJ)
	{
		if (this.Tabs.Count > 0)
		{
			using (List<MBGHQMKEFKO.OBEFKEMNFNL>.Enumerator enumerator = this.Tabs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = enumerator.Current;
					if (obefkemnfnl.Name == FPQBICGEHMJ)
					{
						return obefkemnfnl;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.OBEFKEMNFNL result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x001C0150 File Offset: 0x001BE350
	public void OOOQEBMMEEM(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "[itm=";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Error)
		{
			chatMessage2.Message = "bcam" + MHMMOHDEKMK.Channel + "_Start";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("Username already in use"))
			{
				this.KODCENLDQFH();
				MHMMOHDEKMK.Channel = "rebound";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.OMPHLNDGKKM().FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "Enables a sure getaway from wild Pokémon.";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = ")";
				chatMessage2 = null;
			}
			if (this.LOJJPCEKQOH(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.LNJLFHBMOOC(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[0].ChannelIDs.Add(channelClass.Name);
				this.Tabs[1].ChannelIDs = this.Tabs[1].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.BKJQOPDKEJM(false);
		}
		else
		{
			if (MHMMOHDEKMK.Result != (ChatJoinResult)3)
			{
				return;
			}
			bool flag = true;
			if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD != null && NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = false;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.DMOKBPOKHOQ().FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("[/u]") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = "magicbounce" + MHMMOHDEKMK.Channel + "freeze";
				if (MHMMOHDEKMK.Channel.Length == -29)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "mistyterrain" && MHMMOHDEKMK.Channel != "slowstart" && MHMMOHDEKMK.Channel != "wimpout" && MHMMOHDEKMK.Channel != "BuffIcon_Teleport2" && MHMMOHDEKMK.Channel != "Skill Link" && MHMMOHDEKMK.Channel != "Marsh Badge")
				{
					for (int i = 1; i < this.Channels.Count; i += 0)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.DJQIJGOLPIO().FOFNJICKKIP)
				{
					DCJIBBJQGJP.DMOKBPOKHOQ().FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.HQGBCCIKHCQ(false);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[1] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.IGFCQCCEMFF(chatMessage);
		}
		this.FICHKNQIHLL(string.Empty);
	}

	// Token: 0x06003A81 RID: 14977 RVA: 0x001C050C File Offset: 0x001BE70C
	public void KIFNLHDEJIH(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "(";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Error)
		{
			chatMessage2.Message = "[-] to evolve?" + MHMMOHDEKMK.Channel + "Shop";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("!\r\n"))
			{
				this.KODCENLDQFH();
				MHMMOHDEKMK.Channel = "WATER_REFLECTIVE";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "steel";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "[-]?";
				chatMessage2 = null;
			}
			if (this.LOJJPCEKQOH(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.GJHKKKMGCHQ(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[0].ChannelIDs.Add(channelClass.Name);
				this.Tabs[1].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.BKJQOPDKEJM(true);
		}
		else
		{
			if (MHMMOHDEKMK.Result != (ChatJoinResult)8)
			{
				return;
			}
			bool flag = true;
			if (NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD != null && NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = false;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("-noJoystick") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = " hung on using its [ffff00]Focus Band[-]!\r\n" + MHMMOHDEKMK.Channel + "[00EE07]";
				if (MHMMOHDEKMK.Channel.Length == -122)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "Interact" && MHMMOHDEKMK.Channel != "HidePanel" && MHMMOHDEKMK.Channel != "Pokebox Button(Clone)" && MHMMOHDEKMK.Channel != "The Pokémon is covered with a water veil, which prevents the Pokémon from getting a burn." && MHMMOHDEKMK.Channel != " day ago" && MHMMOHDEKMK.Channel != "Ambient Occlusion")
				{
					for (int i = 0; i < this.Channels.Count; i++)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP)
				{
					DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.IFCIQHQQLOM(false);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[0];
		chatMessage.Messages[1] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.PLMHOIOFOBK(chatMessage);
		}
		this.FIDHOIBBOMI(string.Empty);
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x001C08C8 File Offset: 0x001BEAC8
	public void LCDLEMDMBNC(NEMFLIFKDNO NHNMIFPINDL)
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.NJNIKKOEPFE(NHNMIFPINDL.NIHLMCQMNIK);
		if (obefkemnfnl != null)
		{
			if (obefkemnfnl.ChannelIDs.Contains(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ))
			{
				obefkemnfnl.ChannelIDs.Remove(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
			}
			else
			{
				obefkemnfnl.ChannelIDs.Add(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
			}
			obefkemnfnl.ChannelIDs = obefkemnfnl.ChannelIDs.Distinct<string>().ToList<string>();
		}
		this.FIDHOIBBOMI(NHNMIFPINDL.NIHLMCQMNIK);
		this.OKDBONDJMIO();
	}

	// Token: 0x06003A83 RID: 14979 RVA: 0x001C0954 File Offset: 0x001BEB54
	public void CEMODQHLFIQ()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Boosts the Sp. Atk stat sharply when a stat is lowered.", "The spikes disappeared from the ground around " + this.KJGEBKQEBPN + "Cheek Pouch", this.KJGEBKQEBPN, (LPBPDPMJKNN.PJIJIFKBMBB)8, true, null, -1, false);
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x001C0990 File Offset: 0x001BEB90
	private MBGHQMKEFKO.OBEFKEMNFNL NJNIKKOEPFE(string FPQBICGEHMJ)
	{
		if (this.Tabs.Count > 1)
		{
			using (List<MBGHQMKEFKO.OBEFKEMNFNL>.Enumerator enumerator = this.Tabs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = enumerator.Current;
					if (obefkemnfnl.DOBGCHNIOHL() == FPQBICGEHMJ)
					{
						return obefkemnfnl;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.OBEFKEMNFNL result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x001C0A00 File Offset: 0x001BEC00
	public void BQLIIQIIMDH()
	{
		this.LQIQKMCLJIQ.CPLBKPNNHJG();
		this.QLKBINCMPMK = "General";
		this.LoadChatSettings();
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("General");
		channelClass.ID = string.Empty;
		channelClass.Name = "General";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("System");
		channelClass.ID = string.Empty;
		channelClass.Name = "System";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("Map");
		channelClass.ID = string.Empty;
		channelClass.Name = "Map";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("Party");
		channelClass.ID = string.Empty;
		channelClass.Name = "Party";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("Guild");
		channelClass.ID = string.Empty;
		channelClass.Name = "Guild";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("Battle");
		channelClass.ID = string.Empty;
		channelClass.Name = "Battle";
		this.Channels.Add(channelClass);
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass != null && chatSettingsClass.Name != null)
			{
				string a = chatSettingsClass.Name.ToLowerInvariant();
				if (a != "guild" && a != "party" && a != "map" && a != "general" && a != "battle" && a != "system")
				{
					CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(chatSettingsClass.Name);
					channelClass = new MBGHQMKEFKO.ChannelClass();
					channelClass.Colour = this.HMIFJPEQDQJ(chatSettingsClass.Name);
					channelClass.ID = string.Empty;
					channelClass.Name = chatSettingsClass.Name;
					this.Channels.Add(channelClass);
				}
			}
		}
		this.Tabs[0].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
		this.FICHKNQIHLL(string.Empty);
		this.UpdateCurrentChat();
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x00018F2D File Offset: 0x0001712D
	private static int QBGBFICJNKN(MBGHQMKEFKO.StoredChat DGKOIGOLHDM, MBGHQMKEFKO.StoredChat DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.Time.CompareTo(DDLQKFDFMCJ.Time);
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x00018F40 File Offset: 0x00017140
	private void LKDKBNOBIPK()
	{
		MBGHQMKEFKO.IGCNCOPKBCC(this);
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x001C0DE0 File Offset: 0x001BEFE0
	public void HPGELNGEGPM()
	{
		this.LQIQKMCLJIQ.FBFCKBGLGBL();
		this.QLKBINCMPMK = "[00FF00]You received [PG]";
		this.LoadChatSettings();
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("u");
		channelClass.ID = string.Empty;
		channelClass.Name = "/510)";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.LNJLFHBMOOC("lightscreen");
		channelClass.ID = string.Empty;
		channelClass.Name = "powerconstruct";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.NKBLILLPIEO("Repeat Ball");
		channelClass.ID = string.Empty;
		channelClass.Name = " ";
		if (!this.Tabs[0].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[0].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.NKBLILLPIEO("Filter");
		channelClass.ID = string.Empty;
		channelClass.Name = "Frost";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.NKBLILLPIEO("partingshot");
		channelClass.ID = string.Empty;
		channelClass.Name = "_SampleScale";
		if (!this.Tabs[1].ChannelIDs.Contains(channelClass.Name))
		{
			this.Tabs[1].ChannelIDs.Add(channelClass.Name);
		}
		this.Channels.Add(channelClass);
		channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.GJHKKKMGCHQ("By releasing stench when attacking, this Pokémon may cause the target to flinch.");
		channelClass.ID = string.Empty;
		channelClass.Name = "[u][33CCFF]";
		this.Channels.Add(channelClass);
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass != null && chatSettingsClass.BEIQPGGCMGH() != null)
			{
				string a = chatSettingsClass.HBJBDKMGOJL().ToLowerInvariant();
				if (a != "_FogPointLightColor2" && a != "OnDragOut" && a != "_TransitionTex" && a != "/01_" && a != "achievement" && a != "But it failed!\r\n")
				{
					CNCJKLNHQBH.MOGQNGEPCEO().GFMGCOFHDNB(chatSettingsClass.IBHEQQJJIJQ());
					channelClass = new MBGHQMKEFKO.ChannelClass();
					channelClass.Colour = this.GFFEQHGGHBE(chatSettingsClass.KHBIDFLQOOL());
					channelClass.ID = string.Empty;
					channelClass.Name = chatSettingsClass.Name;
					this.Channels.Add(channelClass);
				}
			}
		}
		this.Tabs[1].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
		this.FICHKNQIHLL(string.Empty);
		this.HLEEEBDFNPL();
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x001C11C0 File Offset: 0x001BF3C0
	public void OKDQLINCJOM(string IHIHHCCEDHQ)
	{
		for (int i = 0; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].FEIQMIIDIBN() == IHIHHCCEDHQ)
			{
				this.Tabs.RemoveAt(i);
				IL_3D:
				if (this.QLKBINCMPMK == IHIHHCCEDHQ)
				{
					this.QLKBINCMPMK = "[-] was burned up!\r\n";
					this.EEMLEDQJIFJ = 0;
				}
				this.FIDHOIBBOMI(string.Empty);
				this.MFQONPCGGIG();
				return;
			}
		}
		goto IL_3D;
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x001C123C File Offset: 0x001BF43C
	private void CHJEOHDNCFD(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(1);
		}
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x001C128C File Offset: 0x001BF48C
	public void CreateTab(string IHIHHCCEDHQ)
	{
		if (string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			return;
		}
		for (int i = 0; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i].Name == IHIHHCCEDHQ)
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.Name = IHIHHCCEDHQ;
		this.Tabs.Add(obefkemnfnl);
		if (!obefkemnfnl.ChannelIDs.Contains("System"))
		{
			obefkemnfnl.ChannelIDs.Add("System");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("General"))
		{
			obefkemnfnl.ChannelIDs.Add("General");
		}
		this.FICHKNQIHLL(string.Empty);
		this.OKDBONDJMIO();
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x001C1344 File Offset: 0x001BF544
	private Color LNJLFHBMOOC(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.IBHEQQJJIJQ() == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.DDKEKDQBHCQ());
			}
		}
		if (IHIHHCCEDHQ == "purepower")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == "FOG_COMPUTE_DEPTH")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x001C13DC File Offset: 0x001BF5DC
	public void LHQECHHMOGD(string QHLIEEGQIDQ)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		chatMessage.Channel = string.Empty;
		chatMessage2.Message = QHLIEEGQIDQ;
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[0] = chatMessage2;
		this.IGFCQCCEMFF(chatMessage);
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x001C1424 File Offset: 0x001BF624
	public void CreateBattleTab()
	{
		for (int i = 0; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i].Name == "Battle")
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.Name = "Battle";
		obefkemnfnl.ChannelIDs = new List<string>
		{
			"Battle"
		};
		if (!obefkemnfnl.ChannelIDs.Contains("System"))
		{
			obefkemnfnl.ChannelIDs.Add("System");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("General"))
		{
			obefkemnfnl.ChannelIDs.Add("General");
		}
		this.Tabs.Add(obefkemnfnl);
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.HMIFJPEQDQJ("General");
		channelClass.ID = string.Empty;
		channelClass.Name = "Battle";
		this.Channels.Add(channelClass);
		this.FICHKNQIHLL(string.Empty);
		this.OKDBONDJMIO();
	}

	// Token: 0x06003A8F RID: 14991 RVA: 0x001C152C File Offset: 0x001BF72C
	public void CMOFGBMGPPB(string BHFOIQQMLGF)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("primordialsea", "J16" + BHFOIQQMLGF + "HH:mm:ss", BHFOIQQMLGF, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, false, null, -1, false);
	}

	// Token: 0x06003A90 RID: 14992 RVA: 0x00018F48 File Offset: 0x00017148
	private void BFHJEBIOCLM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06003A91 RID: 14993 RVA: 0x001C1560 File Offset: 0x001BF760
	public void BQGGFMKELMK(PSXAPI.Response.ChatMessage NQFQGCGPHBE)
	{
		if (NQFQGCGPHBE.Messages != null)
		{
			foreach (PSXAPI.Response.Payload.ChatMessage chatMessage in NQFQGCGPHBE.Messages)
			{
				if (!(CKMLKNPNPQO.INJDHLQHFFD() != null) || !CKMLKNPNPQO.QOQONHOOLNE.IPHGGDIEOOF(chatMessage.Username))
				{
					if (chatMessage.Pokemon != null && HFCMDEQKCKH.CFGIOIGOIFQ() != null)
					{
						for (int j = 1; j < chatMessage.Pokemon.Length; j++)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().LKFLGPCGHFD(chatMessage.Pokemon[j]);
						}
					}
					chatMessage.Message = this.JOEICKPOGNK(chatMessage.Message);
					chatMessage.Message = this.LFGQJBFJMEP(chatMessage.Message, true);
					if (this.PCOJLOJJMMI.KGGCOFHHKEK)
					{
						chatMessage.Message = BWFManager.ReplaceAll(chatMessage.Message, ManagerMask.All | ManagerMask.Domain, Array.Empty<string>());
					}
					if (NQFQGCGPHBE.Channel != null && NQFQGCGPHBE.Channel != string.Empty)
					{
						if (NQFQGCGPHBE.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant())
						{
							NQFQGCGPHBE.Channel = "_1";
						}
						else if (NQFQGCGPHBE.Channel.Contains("Sport Ball"))
						{
							return;
						}
						if (NQFQGCGPHBE.Channel == DCJIBBJQGJP.OMPHLNDGKKM().FOFNJICKKIP && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "magmastorm";
						}
						if (NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD != null && NQFQGCGPHBE.Channel == NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString() && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "rotom";
						}
						MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(NQFQGCGPHBE.Channel);
						if (channelClass == null)
						{
							channelClass = this.Channels[1];
						}
						if (NQFQGCGPHBE.Channel == "stealthrock")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								if (chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("[/url]"))
									{
										int ciqfcjgqemh = 1;
										int.TryParse(chatMessage.Message.Replace("perish0", string.Empty), out ciqfcjgqemh);
										EBBMJNQGLJC.PFQBLOEPBJB().OQNDMEJFCEN(ciqfcjgqemh, 594f);
										goto IL_626;
									}
									CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.HEDDMKGFMQO.JLPDKDGONBO(chatMessage.Message);
								}
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = CGOIPHKQMPD.NKDNGLNOJJG().GLLELMQODQI(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb != null && chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("Old Password is to Short"))
									{
										int ciqfcjgqemh2 = 1;
										int.TryParse(chatMessage.Message.Replace("[pok=", string.Empty), out ciqfcjgqemh2);
										ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF.ONOOKCBOPEF(ciqfcjgqemh2, 1286f);
										goto IL_626;
									}
									ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.GIJCLPKMKFI(chatMessage.Message);
								}
							}
						}
						else if (NQFQGCGPHBE.Channel == "[-][/u]")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								CNCJKLNHQBH.MOGQNGEPCEO().PPMJCBONMQJ.HEDDMKGFMQO.KJLKBMCCNFO(chatMessage.Message);
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb2 = CGOIPHKQMPD.NKDNGLNOJJG().KQEECNLCGHK(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb2 != null)
								{
									ojoepkeebcb2.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.PPPBCGKFNMF(chatMessage.Message);
								}
							}
						}
						if (chatMessage.Message == null || !chatMessage.Message.Contains(" is drowsing!\r\n"))
						{
							string text = "RenderType";
							StaffRank rank = chatMessage.Rank;
							if (rank != StaffRank.None)
							{
								if (rank != StaffRank.Developer)
								{
									if (rank == StaffRank.Developer)
									{
										text = " ";
									}
								}
								else
								{
									text = " for [PG]";
								}
							}
							else
							{
								text = "Pokémon in ";
							}
							string text2 = string.Empty;
							if (chatMessage.Rank == StaffRank.None)
							{
								string[] array = new string[8];
								array[1] = "mega";
								array[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array[7] = ".";
								array[0] = NQFQGCGPHBE.Channel;
								array[0] = "primal";
								int num = 0;
								string text3;
								if (chatMessage.Username != null)
								{
									string[] array2 = new string[6];
									array2[0] = "Grassy Surge";
									array2[1] = chatMessage.Username;
									array2[6] = "gravity";
									array2[5] = text;
									array2[8] = "-";
									array2[4] = chatMessage.Username;
									array2[1] = "Head";
									text3 = string.Concat(array2);
								}
								else
								{
									text3 = string.Empty;
								}
								array[num] = text3;
								array[5] = chatMessage.Message;
								array[1] = "Pokemon View";
								text2 = string.Concat(array);
							}
							else
							{
								string[] array3 = new string[4];
								array3[0] = "Geometry Boundaries";
								array3[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array3[7] = "FindGameCamera";
								array3[5] = NQFQGCGPHBE.Channel;
								array3[6] = "!\r\n";
								int num2 = 5;
								string text4;
								if (chatMessage.Username != null)
								{
									string[] array4 = new string[7];
									array4[1] = "curse";
									array4[1] = chatMessage.Username;
									array4[6] = "curse";
									array4[4] = text;
									array4[1] = "berry_11";
									array4[8] = chatMessage.Username;
									array4[6] = "Disabled";
									text4 = string.Concat(array4);
								}
								else
								{
									text4 = string.Empty;
								}
								array3[num2] = text4;
								array3[3] = chatMessage.Message;
								array3[2] = "moldbreaker";
								text2 = string.Concat(array3);
							}
							this.CHJEOHDNCFD(channelClass, text2);
							MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.BEGMKEJQPCI(this.QLKBINCMPMK);
							if (obefkemnfnl != null && obefkemnfnl.ChannelIDs.Contains(channelClass.Name))
							{
								this.LQIQKMCLJIQ.LHQECHHMOGD(text2);
							}
						}
					}
					else
					{
						MBGHQMKEFKO.ChannelClass channelClass2 = this.Channels[0];
						string[] array5 = new string[1];
						array5[0] = "Current Camera Position";
						array5[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array5[7] = "[itm=";
						array5[3] = channelClass2.Name;
						array5[2] = "trapped";
						array5[1] = chatMessage.Message;
						array5[1] = "Chat Box";
						string text5 = string.Concat(array5);
						this.IMIQFKPIFCM(channelClass2, text5);
						MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 = this.QEJPBCDDHMN(this.QLKBINCMPMK);
						if (obefkemnfnl2 != null && obefkemnfnl2.ChannelIDs.Contains(channelClass2.Name))
						{
							this.LQIQKMCLJIQ.LHQECHHMOGD(text5);
						}
					}
				}
				IL_626:;
			}
		}
	}

	// Token: 0x06003A92 RID: 14994 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
	private void IKKDIFFDDEB(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(0);
		}
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x001C1BF4 File Offset: 0x001BFDF4
	public string FQJQHQFGKOI(string NQFQGCGPHBE, bool EGIGHJBHMHP = false)
	{
		int num = NQFQGCGPHBE.IndexOf("[itm=");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("[/itm]", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + 18)
			{
				return string.Empty;
			}
			string s = NQFQGCGPHBE.Substring(num + 5, 5);
			int num3 = 0;
			int.TryParse(s, out num3);
			if (num3 <= 0 || num3 >= 9999)
			{
				return string.Empty;
			}
			KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(num3);
			if (EGIGHJBHMHP && INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(item.ID) == 0u)
			{
				item = null;
			}
			if (item == null)
			{
				return string.Empty;
			}
			string str = string.Concat(new string[]
			{
				"[itm=",
				num3.EBGLBFKHCJD(),
				"][",
				item.Name,
				"][/itm]"
			});
			string str2 = NQFQGCGPHBE.Substring(0, num);
			string str3 = NQFQGCGPHBE.Substring(num2 + 6);
			NQFQGCGPHBE = str2 + str + str3;
			if (num + 6 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("[itm=", num + 5);
			if (num + 18 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x001C1D44 File Offset: 0x001BFF44
	public void PLMHOIOFOBK(PSXAPI.Response.ChatMessage NQFQGCGPHBE)
	{
		if (NQFQGCGPHBE.Messages != null)
		{
			PSXAPI.Response.Payload.ChatMessage[] messages = NQFQGCGPHBE.Messages;
			for (int i = 1; i < messages.Length; i++)
			{
				PSXAPI.Response.Payload.ChatMessage chatMessage = messages[i];
				if (!(CKMLKNPNPQO.QOQONHOOLNE != null) || !CKMLKNPNPQO.INJDHLQHFFD().OFKHICHJCIP(chatMessage.Username))
				{
					if (chatMessage.Pokemon != null && HFCMDEQKCKH.QOQONHOOLNE != null)
					{
						for (int j = 0; j < chatMessage.Pokemon.Length; j++)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().EJNMJKMKMJB(chatMessage.Pokemon[j]);
						}
					}
					chatMessage.Message = this.JOEICKPOGNK(chatMessage.Message);
					chatMessage.Message = this.FQJQHQFGKOI(chatMessage.Message, false);
					if (this.PCOJLOJJMMI.KGGCOFHHKEK)
					{
						chatMessage.Message = BWFManager.ReplaceAll(chatMessage.Message, ManagerMask.All, Array.Empty<string>());
					}
					if (NQFQGCGPHBE.Channel != null && NQFQGCGPHBE.Channel != string.Empty)
					{
						if (NQFQGCGPHBE.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant())
						{
							NQFQGCGPHBE.Channel = "Sky";
						}
						else if (NQFQGCGPHBE.Channel.Contains("It doesn't affect "))
						{
							return;
						}
						if (NQFQGCGPHBE.Channel == DCJIBBJQGJP.MOGQNGEPCEO().FOFNJICKKIP && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "Guild";
						}
						if (NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD != null && NQFQGCGPHBE.Channel == NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString() && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "harvest";
						}
						MBGHQMKEFKO.ChannelClass channelClass = this.GPOPMFLGNHE(NQFQGCGPHBE.Channel);
						if (channelClass == null)
						{
							channelClass = this.Channels[0];
						}
						if (NQFQGCGPHBE.Channel == "tox")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								if (chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("This Pokémon uses suction cups to stay in one spot to negate all moves and items that force switching out."))
									{
										int ciqfcjgqemh = 1;
										int.TryParse(chatMessage.Message.Replace("poke", string.Empty), out ciqfcjgqemh);
										EBBMJNQGLJC.PFQBLOEPBJB().HPHPONPKQIH(ciqfcjgqemh, 1483f);
										goto IL_626;
									}
									CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.HEDDMKGFMQO.JLPDKDGONBO(chatMessage.Message);
								}
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = CGOIPHKQMPD.CPLQICHLGCI().NMPKLGGJEJG(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb != null && chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("PokeboxNumber"))
									{
										int ciqfcjgqemh2 = 1;
										int.TryParse(chatMessage.Message.Replace("_DestortionShiftY", string.Empty), out ciqfcjgqemh2);
										ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF.ONOOKCBOPEF(ciqfcjgqemh2, 580f);
										goto IL_626;
									}
									ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.PPPBCGKFNMF(chatMessage.Message);
								}
							}
						}
						else if (NQFQGCGPHBE.Channel == "None")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.HEDDMKGFMQO.HQIKGIBOEOJ(chatMessage.Message);
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb2 = CGOIPHKQMPD.KJKGLNEHCKH().LNJBLNFMCBK(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb2 != null)
								{
									ojoepkeebcb2.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.HQIKGIBOEOJ(chatMessage.Message);
								}
							}
						}
						if (chatMessage.Message == null || !chatMessage.Message.Contains("_ClipToWorld"))
						{
							string text = " acquired ";
							StaffRank rank = chatMessage.Rank;
							if (rank != StaffRank.Developer)
							{
								if (rank != (StaffRank)5)
								{
									if (rank == (StaffRank)4)
									{
										text = "qTrack";
									}
								}
								else
								{
									text = "'s ";
								}
							}
							else
							{
								text = ". Vertex Count: ";
							}
							string text2 = string.Empty;
							if (chatMessage.Rank == StaffRank.None)
							{
								string[] array = new string[]
								{
									null,
									"_FogOfWarCenterAdjusted"
								};
								array[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array[4] = ".";
								array[0] = NQFQGCGPHBE.Channel;
								array[4] = "](";
								int num = 1;
								string text3;
								if (chatMessage.Username != null)
								{
									string[] array2 = new string[5];
									array2[0] = "a";
									array2[1] = chatMessage.Username;
									array2[5] = "WATER_REFLECTIVE";
									array2[8] = text;
									array2[7] = "-transform";
									array2[3] = chatMessage.Username;
									array2[5] = "ability";
									text3 = string.Concat(array2);
								}
								else
								{
									text3 = string.Empty;
								}
								array[num] = text3;
								array[6] = chatMessage.Message;
								array[3] = "Battle Update: ";
								text2 = string.Concat(array);
							}
							else
							{
								string[] array3 = new string[6];
								array3[0] = " used the move instructed by ";
								array3[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array3[6] = "UpdateAnchors";
								array3[3] = NQFQGCGPHBE.Channel;
								array3[3] = "[upkeep]";
								int num2 = 4;
								string text4;
								if (chatMessage.Username != null)
								{
									string[] array4 = new string[7];
									array4[0] = "None";
									array4[0] = chatMessage.Username;
									array4[5] = "m_TangentMode";
									array4[0] = text;
									array4[2] = "ability";
									array4[5] = chatMessage.Username;
									array4[4] = "0_";
									text4 = string.Concat(array4);
								}
								else
								{
									text4 = string.Empty;
								}
								array3[num2] = text4;
								array3[6] = chatMessage.Message;
								array3[1] = " hours";
								text2 = string.Concat(array3);
							}
							this.GCOKGKDGHIQ(channelClass, text2);
							MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.BEGMKEJQPCI(this.QLKBINCMPMK);
							if (obefkemnfnl != null && obefkemnfnl.ChannelIDs.Contains(channelClass.Name))
							{
								this.LQIQKMCLJIQ.LHQECHHMOGD(text2);
							}
						}
					}
					else
					{
						MBGHQMKEFKO.ChannelClass channelClass2 = this.Channels[1];
						string[] array5 = new string[]
						{
							"RightS",
							KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour)
						};
						array5[0] = "Egg";
						array5[5] = channelClass2.Name;
						array5[8] = "Moody";
						array5[1] = chatMessage.Message;
						array5[7] = "BuffIcon_RodCooldown";
						string text5 = string.Concat(array5);
						this.IMIQFKPIFCM(channelClass2, text5);
						MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 = this.EJIFPGIMGLE(this.QLKBINCMPMK);
						if (obefkemnfnl2 != null && obefkemnfnl2.ChannelIDs.Contains(channelClass2.Name))
						{
							this.LQIQKMCLJIQ.LHQECHHMOGD(text5);
						}
					}
				}
				IL_626:;
			}
		}
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x001C2388 File Offset: 0x001C0588
	public void LeaveChannel(string BHFOIQQMLGF)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Leave Channel", "Are you sure you wish to leave the Channel '" + BHFOIQQMLGF + "'?", BHFOIQQMLGF, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x06003A96 RID: 14998 RVA: 0x001C23BC File Offset: 0x001C05BC
	private MBGHQMKEFKO.OBEFKEMNFNL BEGMKEJQPCI(string FPQBICGEHMJ)
	{
		if (this.Tabs.Count > 0)
		{
			using (List<MBGHQMKEFKO.OBEFKEMNFNL>.Enumerator enumerator = this.Tabs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = enumerator.Current;
					if (obefkemnfnl.ECEEDMJLHDB() == FPQBICGEHMJ)
					{
						return obefkemnfnl;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.OBEFKEMNFNL result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x001C242C File Offset: 0x001C062C
	private MBGHQMKEFKO.ChannelClass GPOPMFLGNHE(string FPQBICGEHMJ)
	{
		if (this.Channels.Count > 0)
		{
			using (List<MBGHQMKEFKO.ChannelClass>.Enumerator enumerator = this.Channels.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.ChannelClass channelClass = enumerator.Current;
					if (channelClass.Name == FPQBICGEHMJ)
					{
						return channelClass;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.ChannelClass result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x001C249C File Offset: 0x001C069C
	public void OGJDPEGDKHL(string IHIHHCCEDHQ)
	{
		for (int i = 1; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i].IFCMDJMCLBD() == IHIHHCCEDHQ)
			{
				this.Tabs.RemoveAt(i);
				IL_3D:
				if (this.QLKBINCMPMK == IHIHHCCEDHQ)
				{
					this.QLKBINCMPMK = "frz";
					this.EEMLEDQJIFJ = 1;
				}
				this.FICHKNQIHLL(string.Empty);
				this.LFJBONQJQFH();
				return;
			}
		}
		goto IL_3D;
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x001C2518 File Offset: 0x001C0718
	public void DeleteTab()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Delete Tab", "Are you sure you wish to delete your '" + this.KJGEBKQEBPN + "' tab?", this.KJGEBKQEBPN, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x001C2554 File Offset: 0x001C0754
	public void HQGBCCIKHCQ(bool LOBDGBMQFOB = false)
	{
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			bool flag = true;
			for (int i = 0; i < this.ChannelSettings.Count; i++)
			{
				if (this.ChannelSettings[i].FEIQMIIDIBN() == channelClass.Name)
				{
					flag = false;
					this.ChannelSettings[i].BDJKKDFIGHM(channelClass.Colour.ToString());
				}
			}
			if (flag)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass.NNELHDQOKPE(channelClass.Name);
				chatSettingsClass.ODOPPOHDQMB(channelClass.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass);
			}
		}
		if (LOBDGBMQFOB)
		{
			this.ChannelSettings.Clear();
			foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass2 = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass2.GNLEBEQDPBK(channelClass2.Name);
				chatSettingsClass2.MQJECFEIKFJ(channelClass2.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass2);
			}
		}
		PlayerPrefs.SetString(CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH + "[url=", JsonConvert.SerializeObject(this.ChannelSettings, Formatting.Indented));
		PlayerPrefs.SetString(CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH + "leftovers", JsonConvert.SerializeObject(this.Tabs, Formatting.Indented));
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x001C271C File Offset: 0x001C091C
	public void UpdateCurrentChat()
	{
		this.JLFFPBJKMNP = JGDHIPBGCFP.IMOMGBNIENN(this.FDBHFIQIQJC.PIDLOFMIEFQ).Replace("#", string.Empty);
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(this.JLFFPBJKMNP);
		if (channelClass != null)
		{
			this.FDBHFIQIQJC.PIDLOFMIEFQ = string.Concat(new string[]
			{
				"[",
				KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
				"]#",
				this.JLFFPBJKMNP,
				"[-]"
			});
		}
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
	private void IMIQFKPIFCM(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(0);
		}
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x001C27A4 File Offset: 0x001C09A4
	public void Open()
	{
		this.FICHKNQIHLL(string.Empty);
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x001C2800 File Offset: 0x001C0A00
	public void FHGINOFDGDE()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("[PD]", " minute ago", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x001C282C File Offset: 0x001C0A2C
	public void GQBQLCCDLNF(bool LOBDGBMQFOB = false)
	{
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			bool flag = true;
			for (int i = 0; i < this.ChannelSettings.Count; i += 0)
			{
				if (this.ChannelSettings[i].JPMMGDNMPQC() == channelClass.Name)
				{
					flag = true;
					this.ChannelSettings[i].FQMHEFFKPDD(channelClass.Colour.ToString());
				}
			}
			if (flag)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass.IFDHPPQDKDK(channelClass.Name);
				chatSettingsClass.BDJKKDFIGHM(channelClass.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass);
			}
		}
		if (LOBDGBMQFOB)
		{
			this.ChannelSettings.Clear();
			foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
			{
				MBGHQMKEFKO.ChatSettingsClass chatSettingsClass2 = new MBGHQMKEFKO.ChatSettingsClass();
				chatSettingsClass2.DDOHFOPPIIB(channelClass2.Name);
				chatSettingsClass2.FHCBJOIBKDO(channelClass2.Colour.ToString());
				this.ChannelSettings.Add(chatSettingsClass2);
			}
		}
		PlayerPrefs.SetString(CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH + "ChatSettings", JsonConvert.SerializeObject(this.ChannelSettings, Formatting.None));
		PlayerPrefs.SetString(CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH + "EditorOnly", JsonConvert.SerializeObject(this.Tabs, Formatting.None));
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x001C29F4 File Offset: 0x001C0BF4
	public void HJIEFQOGEKQ(string IHIHHCCEDHQ)
	{
		if (string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			return;
		}
		for (int i = 0; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].DFNQHDEDDKE() == IHIHHCCEDHQ)
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.FEJCEKHLJQP(IHIHHCCEDHQ);
		this.Tabs.Add(obefkemnfnl);
		if (!obefkemnfnl.ChannelIDs.Contains("Effect Spore"))
		{
			obefkemnfnl.ChannelIDs.Add("WATER_REFRACTIVE");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("_OnRails"))
		{
			obefkemnfnl.ChannelIDs.Add(" is making an uproar!\r\n");
		}
		this.FIDHOIBBOMI(string.Empty);
		this.MFQONPCGGIG();
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x00018EF4 File Offset: 0x000170F4
	private void PBENCICMMLI()
	{
		MBGHQMKEFKO.GJQMFGJQBGC(this);
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x001C2AAC File Offset: 0x001C0CAC
	public void LPQCOJOBBJC(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "OnClientConnect" && IHIHHCCEDHQ.ToLowerInvariant() != "Primordial Sea" && IHIHHCCEDHQ.ToLowerInvariant() != "Username" && IHIHHCCEDHQ.ToLowerInvariant() != "Blank" && IHIHHCCEDHQ.ToLowerInvariant() != "Up" && IHIHHCCEDHQ.ToLowerInvariant() != "]")
		{
			CNCJKLNHQBH.MOGQNGEPCEO().DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x001C2B30 File Offset: 0x001C0D30
	public void IGFCQCCEMFF(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "General";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Joined)
		{
			chatMessage2.Message = "Joined Chat Channel: " + MHMMOHDEKMK.Channel + ".";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("map:"))
			{
				this.KODCENLDQFH();
				MHMMOHDEKMK.Channel = "Map";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "Party";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "Guild";
				chatMessage2 = null;
			}
			if (this.LOJJPCEKQOH(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.HMIFJPEQDQJ(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[0].ChannelIDs.Add(channelClass.Name);
				this.Tabs[0].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.BKJQOPDKEJM(false);
		}
		else
		{
			if (MHMMOHDEKMK.Result != ChatJoinResult.Left)
			{
				return;
			}
			bool flag = false;
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = true;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("map:") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = "Left Chat Channel: " + MHMMOHDEKMK.Channel + ".";
				if (MHMMOHDEKMK.Channel.Length == 36)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "Party" && MHMMOHDEKMK.Channel != "General" && MHMMOHDEKMK.Channel != "Guild" && MHMMOHDEKMK.Channel != "Map" && MHMMOHDEKMK.Channel != "Battle" && MHMMOHDEKMK.Channel != "System")
				{
					for (int i = 0; i < this.Channels.Count; i++)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP)
				{
					DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.BKJQOPDKEJM(true);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[0] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.IGFCQCCEMFF(chatMessage);
		}
		this.FICHKNQIHLL(string.Empty);
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x001C2EEC File Offset: 0x001C10EC
	public void INKGBOONGKB()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("ability: ", "\r\n", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x001C2F18 File Offset: 0x001C1118
	public void LFJBONQJQFH()
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.NJNIKKOEPFE(this.QLKBINCMPMK);
		List<MBGHQMKEFKO.StoredChat> list = new List<MBGHQMKEFKO.StoredChat>();
		if (obefkemnfnl != null)
		{
			foreach (string fpqbicgehmj in obefkemnfnl.ChannelIDs)
			{
				MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(fpqbicgehmj);
				if (channelClass != null)
				{
					list.AddRange(channelClass.StoredLines);
				}
			}
		}
		List<MBGHQMKEFKO.StoredChat> list2 = list;
		if (MBGHQMKEFKO.HNCJFHJNHDN == null)
		{
			MBGHQMKEFKO.HNCJFHJNHDN = new Comparison<MBGHQMKEFKO.StoredChat>(MBGHQMKEFKO.QBGBFICJNKN);
		}
		list2.Sort(MBGHQMKEFKO.HNCJFHJNHDN);
		this.LQIQKMCLJIQ.BPFQEKCPJDI();
		for (int i = 1; i < list.Count; i++)
		{
			this.LQIQKMCLJIQ.DEJNPQEJINP(list[i].Message);
		}
		this.LQIQKMCLJIQ.QBFPECFJCLO();
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x00018F5B File Offset: 0x0001715B
	// (set) Token: 0x06003AAB RID: 15019 RVA: 0x00018F25 File Offset: 0x00017125
	public static MBGHQMKEFKO QOQONHOOLNE { get; private set; }

	// Token: 0x06003AA8 RID: 15016 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
	private void GCOKGKDGHIQ(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(0);
		}
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x001C2FFC File Offset: 0x001C11FC
	public void IJJCBFNCPGJ(string QHLIEEGQIDQ)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		chatMessage.Channel = string.Empty;
		chatMessage2.Message = QHLIEEGQIDQ;
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[0] = chatMessage2;
		this.NDJFBGECGBG(chatMessage);
	}

	// Token: 0x06003AAA RID: 15018 RVA: 0x00018F62 File Offset: 0x00017162
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06003AAC RID: 15020 RVA: 0x001C3044 File Offset: 0x001C1244
	public void QPCGCFKHBOI()
	{
		this.JLFFPBJKMNP = JGDHIPBGCFP.IMOMGBNIENN(this.FDBHFIQIQJC.PIDLOFMIEFQ).Replace("Reflection", string.Empty);
		MBGHQMKEFKO.ChannelClass channelClass = this.GPOPMFLGNHE(this.JLFFPBJKMNP);
		if (channelClass != null)
		{
			BKKHLBCLPJM fdbhfiqiqjc = this.FDBHFIQIQJC;
			string[] array = new string[1];
			array[1] = "\r\nHP";
			array[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
			array[2] = "primordialsea";
			array[2] = this.JLFFPBJKMNP;
			array[8] = "BuffIcon_Dig";
			fdbhfiqiqjc.LKPOBCBOFIC(string.Concat(array));
		}
	}

	// Token: 0x06003AAD RID: 15021 RVA: 0x00018F5B File Offset: 0x0001715B
	public static MBGHQMKEFKO BBCBOIFQDBK()
	{
		return MBGHQMKEFKO.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003AAE RID: 15022 RVA: 0x001C30CC File Offset: 0x001C12CC
	public void GCGGIKNOGIO()
	{
		bool flag = false;
		for (int i = 1; i < this.Channels.Count; i++)
		{
			if (this.Channels[i].Name.Contains("F10"))
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.ChatJoin
				{
					Channel = this.Channels[i].Name,
					Action = ChatJoinAction.Join
				}, false);
				this.Channels.RemoveAt(i);
				flag = true;
			}
		}
		if (flag && CNCJKLNHQBH.BJLGEDCPENQ().EFOGMBCFBGM)
		{
			this.GQBQLCCDLNF(false);
			this.FICHKNQIHLL(string.Empty);
		}
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x001C3170 File Offset: 0x001C1370
	public void BJIDKDCIJLJ(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "[00EE07]" && IHIHHCCEDHQ.ToLowerInvariant() != "#,##0" && IHIHHCCEDHQ.ToLowerInvariant() != "MapDownloader" && IHIHHCCEDHQ.ToLowerInvariant() != "4x" && IHIHHCCEDHQ.ToLowerInvariant() != "Wonder Guard" && IHIHHCCEDHQ.ToLowerInvariant() != "_")
		{
			CNCJKLNHQBH.MOGQNGEPCEO().DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x001C31F4 File Offset: 0x001C13F4
	public void NLKQNEIMHII(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "_" && IHIHHCCEDHQ.ToLowerInvariant() != "d" && IHIHHCCEDHQ.ToLowerInvariant() != "Player Fly Mount" && IHIHHCCEDHQ.ToLowerInvariant() != "HideResponse" && IHIHHCCEDHQ.ToLowerInvariant() != "Localization" && IHIHHCCEDHQ.ToLowerInvariant() != "u")
		{
			CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x001C3278 File Offset: 0x001C1478
	private void FIDHOIBBOMI(string INKMEQJHMKL = "")
	{
		this.ListOfChatTabButtons.Clear();
		this.PHQPIIOFQKK.transform.NMBPDMIIHJB();
		this.PHQPIIOFQKK.PFEIQDIJEKE();
		this.JLEHKJPJCGO.transform.NMBPDMIIHJB();
		this.JLEHKJPJCGO.PFEIQDIJEKE();
		DQLHHFEDBJG dqlhhfedbjg = null;
		for (int i = 0; i < this.Tabs.Count; i++)
		{
			if (this.Tabs[i] != null)
			{
				DQLHHFEDBJG component = this.JLEHKJPJCGO.gameObject.BFCKNMFEBDM(this.KOCLHCLKKPP[0]).GetComponent<DQLHHFEDBJG>();
				component.FPQBICGEHMJ.LKPOBCBOFIC(this.Tabs[i].KMGCMJIPCOO());
				if (this.Tabs[i].KMGCMJIPCOO() == " ")
				{
					dqlhhfedbjg = component;
				}
				if (INKMEQJHMKL != string.Empty && this.Tabs[i].BGDJDBNKJHJ() == INKMEQJHMKL)
				{
					dqlhhfedbjg = component;
				}
				if (i == 0)
				{
					component.FLHBMIMMJOK = true;
				}
				component.BLLHQPQBHBB = component.GetComponent<CFDMNELIJLO>();
				this.ListOfChatTabButtons.Add(component.BLLHQPQBHBB);
			}
		}
		this.JLEHKJPJCGO.PFEIQDIJEKE();
		dqlhhfedbjg.NBQGBEJCHKM();
		this.KJGEBKQEBPN = dqlhhfedbjg.FPQBICGEHMJ.PIDLOFMIEFQ;
		this.ChatTabs.Clear();
		this.JDLHLNEPKHJ.transform.NMBPDMIIHJB();
		this.JDLHLNEPKHJ.PFEIQDIJEKE();
		int num = 1;
		foreach (MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl in this.Tabs)
		{
			if (obefkemnfnl != null)
			{
				IPJFFGJJFHL component2 = this.NPIEPPJFDJN.BFCKNMFEBDM(this.KOCLHCLKKPP[1]).GetComponent<IPJFFGJJFHL>();
				component2.FPQBICGEHMJ.PIDLOFMIEFQ = obefkemnfnl.ONLHOLQGCHI();
				component2.DBPKNCDGGEP = num;
				num += 0;
				this.ChatTabs.Add(component2);
			}
		}
		this.FJKQLIFBCKD(this.EEMLEDQJIFJ);
		this.JDLHLNEPKHJ.PFEIQDIJEKE();
		this.KJKKDGGIKEE.CPLBKPNNHJG();
		foreach (MBGHQMKEFKO.ChannelClass channelClass in this.Channels)
		{
			if (channelClass != null && channelClass.Name != null)
			{
				if (!(channelClass.Name == "WATER_EDGEBLEND_ON"))
				{
					if (!(channelClass.Name == "allAdjacent"))
					{
						if (!(channelClass.Name == " cured its paralysis!\r\n"))
						{
							if (channelClass.Name == "settag(")
							{
								if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null)
								{
									QCPKMJONIGF kjkkdggikee = this.KJKKDGGIKEE;
									string[] array = new string[5];
									array[0] = "An electric current runs across the battlefield!\r\n";
									array[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
									array[6] = "Halves the Pokémon's weight.";
									array[6] = channelClass.Name;
									array[5] = "Rock Head";
									kjkkdggikee.OGIDEJGOKEC(string.Concat(array));
								}
							}
							else if (channelClass.Name == "adata")
							{
								if (DCJIBBJQGJP.CNIMIQKQJJJ().COOLIKQMBMK)
								{
									QCPKMJONIGF kjkkdggikee2 = this.KJKKDGGIKEE;
									string[] array2 = new string[4];
									array2[1] = "qTrack";
									array2[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
									array2[5] = " minute";
									array2[8] = channelClass.Name;
									array2[4] = "Take 001";
									kjkkdggikee2.OGIDEJGOKEC(string.Concat(array2));
								}
							}
							else
							{
								QCPKMJONIGF kjkkdggikee3 = this.KJKKDGGIKEE;
								string[] array3 = new string[7];
								array3[1] = ",";
								array3[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array3[1] = "[-]!\r\n";
								array3[1] = channelClass.Name;
								array3[7] = "wideguard";
								kjkkdggikee3.OGIDEJGOKEC(string.Concat(array3));
							}
							if (channelClass.Name == " is radiating a blazing aura!\r\n" && this.DPMPDDEJNFM.PIDLOFMIEFQ.Contains("healblock") && !DCJIBBJQGJP.MOGQNGEPCEO().COOLIKQMBMK)
							{
								QCPKMJONIGF kjkkdggikee4 = this.KJKKDGGIKEE;
								string[] array4 = new string[5];
								array4[0] = "adjacentAllyOrSelf";
								array4[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array4[7] = "Guild created!";
								array4[3] = channelClass.Name;
								array4[0] = "-endability";
								kjkkdggikee4.PJMIKDIEGMB(string.Concat(array4), false);
							}
						}
					}
				}
			}
		}
		foreach (string text in this.KJKKDGGIKEE.MKHIFDNEFBD)
		{
			if (text != null && text == this.FDBHFIQIQJC.PIDLOFMIEFQ)
			{
				return;
			}
		}
		if (this.KJKKDGGIKEE.MKHIFDNEFBD != null && this.KJKKDGGIKEE.MKHIFDNEFBD.Count > 0)
		{
			this.KJKKDGGIKEE.PJMIKDIEGMB(this.KJKKDGGIKEE.MKHIFDNEFBD[1], true);
		}
	}

	// Token: 0x06003AB2 RID: 15026 RVA: 0x001C3790 File Offset: 0x001C1990
	public void LoadChatSettings()
	{
		this.ChannelSettings = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.ChatSettingsClass>>(PlayerPrefs.GetString(CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH + "ChatSettings", string.Empty));
		if (this.ChannelSettings == null)
		{
			this.ChannelSettings = new List<MBGHQMKEFKO.ChatSettingsClass>();
		}
		this.Tabs = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.OBEFKEMNFNL>>(PlayerPrefs.GetString(CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH + "TabSettings", string.Empty));
		if (this.Tabs == null)
		{
			this.Tabs = new List<MBGHQMKEFKO.OBEFKEMNFNL>();
			MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.Name = "General";
			if (!obefkemnfnl.ChannelIDs.Contains("System"))
			{
				obefkemnfnl.ChannelIDs.Add("System");
			}
			this.Tabs.Add(obefkemnfnl);
			obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.Name = "Battle";
			if (!obefkemnfnl.ChannelIDs.Contains("System"))
			{
				obefkemnfnl.ChannelIDs.Add("System");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("Battle"))
			{
				obefkemnfnl.ChannelIDs.Add("Battle");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("General"))
			{
				obefkemnfnl.ChannelIDs.Add("General");
			}
			obefkemnfnl.ChannelIDs = obefkemnfnl.ChannelIDs.Distinct<string>().ToList<string>();
			this.Tabs.Add(obefkemnfnl);
			this.QLKBINCMPMK = "General";
		}
		else
		{
			foreach (MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 in this.Tabs)
			{
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
				if (!obefkemnfnl2.ChannelIDs.Contains("System"))
				{
					obefkemnfnl2.ChannelIDs.Add("System");
				}
				if (!obefkemnfnl2.ChannelIDs.Contains("General"))
				{
					obefkemnfnl2.ChannelIDs.Add("General");
				}
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
			}
		}
	}

	// Token: 0x06003AB3 RID: 15027 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
	private void GHQFKGIJOPQ(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(0);
		}
	}

	// Token: 0x06003AB4 RID: 15028 RVA: 0x001C39B4 File Offset: 0x001C1BB4
	public void ClickChatTab(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "Btn_TabHighlighted_Normal";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Btn_TabHighlighted_Hover";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "Btn_TabHighlighted_Click";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1f, 1f, 1f, 1f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Outline;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1f, 1f, 1f, 0.65f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.None;
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "Btn_Tab_Normal";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Btn_Tab_Hover";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "Btn_Tab_Click";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 0)
		{
			FIKJCOHPQIC = 0;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].Name != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].Name;
		}
		this.OKDBONDJMIO();
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x001C3B50 File Offset: 0x001C1D50
	private Color GFFEQHGGHBE(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.LNOFGGGDGEP() == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.LGLLLOCOMPH());
			}
		}
		if (IHIHHCCEDHQ == "[ff6666]")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == "When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003AB6 RID: 15030 RVA: 0x00018F2D File Offset: 0x0001712D
	[CompilerGenerated]
	private static int KOIEPPDEOLH(MBGHQMKEFKO.StoredChat DGKOIGOLHDM, MBGHQMKEFKO.StoredChat DDLQKFDFMCJ)
	{
		return DGKOIGOLHDM.Time.CompareTo(DDLQKFDFMCJ.Time);
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x001C3BE8 File Offset: 0x001C1DE8
	public void FELKCOCMIGP(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.GJBCDOKDQQF(" is loafing around!\r\n");
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "-mega-y";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "DN";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1641f, 1326f, 1300f, 693f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Outline8;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(727f, 1803f, 1920f, 819f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Shadow;
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "OnSelectionChange";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "new npc";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "doomdesire";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 0)
		{
			FIKJCOHPQIC = 1;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].GEJFHIGHLGO() != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].GEJFHIGHLGO();
		}
		this.MENLJBNQIJO();
	}

	// Token: 0x06003AB8 RID: 15032 RVA: 0x001C3D84 File Offset: 0x001C1F84
	public void JPFBMBHOJHG()
	{
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("_FogSkyColor", "'s item cannot be removed!\r\n" + this.KJGEBKQEBPN + "suctioncups", this.KJGEBKQEBPN, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, false);
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x001C3DC0 File Offset: 0x001C1FC0
	public void NNODBQKLBBB(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "data4";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Error)
		{
			chatMessage2.Message = "Hidden/Post FX/Grain Generator" + MHMMOHDEKMK.Channel + "_MainTex";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("]["))
			{
				this.GCGGIKNOGIO();
				MHMMOHDEKMK.Channel = "Egg";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.MOGQNGEPCEO().FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "'s ";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "Assets/AssetBundles/MapAssets2/Models/House F 1/Materials/com_chip_mado1_mat.mat";
				chatMessage2 = null;
			}
			if (this.GPOPMFLGNHE(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.LNJLFHBMOOC(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[0].ChannelIDs.Add(channelClass.Name);
				this.Tabs[1].ChannelIDs = this.Tabs[0].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.GQBQLCCDLNF(true);
		}
		else
		{
			if (MHMMOHDEKMK.Result != ChatJoinResult.Error)
			{
				return;
			}
			bool flag = true;
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = false;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.DJQIJGOLPIO().FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("_FogPointLightColor3") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = "paralize" + MHMMOHDEKMK.Channel + "PvP Wins:";
				if (MHMMOHDEKMK.Channel.Length == 112)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "(A)" && MHMMOHDEKMK.Channel != "_HueShift" && MHMMOHDEKMK.Channel != " is covered in powder!\r\n" && MHMMOHDEKMK.Channel != "_" && MHMMOHDEKMK.Channel != "last online " && MHMMOHDEKMK.Channel != "_Texture0")
				{
					for (int i = 0; i < this.Channels.Count; i += 0)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.MOGQNGEPCEO().FOFNJICKKIP)
				{
					DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.IFCIQHQQLOM(true);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[0];
		chatMessage.Messages[1] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.NDJFBGECGBG(chatMessage);
		}
		this.FIDHOIBBOMI(string.Empty);
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x001C417C File Offset: 0x001C237C
	public void CGNPGNIOMEN(DQLHHFEDBJG PNMMMQIGLCH)
	{
		if (PNMMMQIGLCH.FLHBMIMMJOK)
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = true;
			this.LPDIEFIDGFH.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		else
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = false;
			this.LPDIEFIDGFH.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
		this.PHQPIIOFQKK.transform.NMBPDMIIHJB();
		this.PHQPIIOFQKK.Reposition();
		for (int i = 0; i < this.Channels.Count; i++)
		{
			NEMFLIFKDNO component = this.PHQPIIOFQKK.gameObject.BFCKNMFEBDM(this.KOCLHCLKKPP[1]).GetComponent<NEMFLIFKDNO>();
			component.FPQBICGEHMJ.PIDLOFMIEFQ = this.Channels[i].Name;
			component.NIHLMCQMNIK = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
			if (this.Channels[i].Name == "Party" || this.Channels[i].Name == "Map" || this.Channels[i].Name == "Guild" || this.Channels[i].Name == "General" || this.Channels[i].Name == "Battle" || this.Channels[i].Name == "System")
			{
				component.JJNIGOPBNCH.KJGMGPCEJJD = 2;
				component.JJNIGOPBNCH.GetComponent<BoxCollider>().enabled = false;
				component.JJNIGOPBNCH.gameObject.SetActive(false);
			}
			if (this.QEJPBCDDHMN(PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ).ChannelIDs.Contains(this.Channels[i].Name))
			{
				component.MJPJEPGLQOH.value = true;
			}
			else
			{
				component.MJPJEPGLQOH.value = false;
			}
			if (this.Channels[i].Name == "General")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(false);
			}
			if (this.Channels[i].Name == "System")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(false);
			}
		}
		this.PHQPIIOFQKK.Reposition();
		this.KJGEBKQEBPN = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
		this.BKJQOPDKEJM(false);
	}

	// Token: 0x06003ABB RID: 15035 RVA: 0x001C43F8 File Offset: 0x001C25F8
	public string HMLGEKPKGLL(string NQFQGCGPHBE)
	{
		int num = NQFQGCGPHBE.IndexOf("ability");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("UpdateTweenPosition", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + -14)
			{
				return string.Empty;
			}
			string input = NQFQGCGPHBE.Substring(num + 5, -107);
			Guid empty = Guid.Empty;
			Guid.TryParse(input, out empty);
			if (!(empty != Guid.Empty))
			{
				return string.Empty;
			}
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(empty);
			if (fekoiojqnkh == null)
			{
				return string.Empty;
			}
			string text = "[/S]" + KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString() + fekoiojqnkh.FCQMGQOEDLJ().ToString() + "!\r\n";
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				text = text + "sdata" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + "Limber";
			}
			else
			{
				text = text + "Pointer Influence" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL()) + "_RefractionTex";
			}
			text += "/";
			string str = NQFQGCGPHBE.Substring(0, num);
			string str2 = NQFQGCGPHBE.Substring(num2 + 1);
			NQFQGCGPHBE = str + text + str2;
			if (num + 1 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("_FogPointLightPosition2", num + 2);
			if (num + 48 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003ABD RID: 15037 RVA: 0x001C4604 File Offset: 0x001C2804
	public void OOQEIMFIOEP()
	{
		for (int i = 0; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].Name == "HM")
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.NMLFJEJNEIB("Sky");
		obefkemnfnl.ChannelIDs = new List<string>
		{
			"3"
		};
		if (!obefkemnfnl.ChannelIDs.Contains("grass"))
		{
			obefkemnfnl.ChannelIDs.Add("\n");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("0"))
		{
			obefkemnfnl.ChannelIDs.Add("_");
		}
		this.Tabs.Add(obefkemnfnl);
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.GJHKKKMGCHQ("Icicle Badge");
		channelClass.ID = string.Empty;
		channelClass.Name = "RA";
		this.Channels.Add(channelClass);
		this.FIDHOIBBOMI(string.Empty);
		this.MENLJBNQIJO();
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x001C470C File Offset: 0x001C290C
	public void CGCOEFCDIIN(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.GDCCCNPLPQK("Cacophony");
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Trigger Shape";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "Fitter Line";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1884f, 1238f, 1219f, 670f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Shadow;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(770f, 574f, 649f, 1506f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Shadow;
				ipjffgjjfhl.BLLHQPQBHBB.GJBCDOKDQQF("Expected to have 'target' set to a valid transform");
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Hidden/Post FX/Temporal Anti-aliasing";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = " endured the hit!\r\n";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 1)
		{
			FIKJCOHPQIC = 1;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].DOBGCHNIOHL() != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].BGDJDBNKJHJ();
		}
		this.MFQONPCGGIG();
	}

	// Token: 0x06003ABF RID: 15039 RVA: 0x001C48A8 File Offset: 0x001C2AA8
	public void LeaveChatChannel(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "guild" && IHIHHCCEDHQ.ToLowerInvariant() != "party" && IHIHHCCEDHQ.ToLowerInvariant() != "map" && IHIHHCCEDHQ.ToLowerInvariant() != "general" && IHIHHCCEDHQ.ToLowerInvariant() != "battle" && IHIHHCCEDHQ.ToLowerInvariant() != "system")
		{
			CNCJKLNHQBH.QOQONHOOLNE.DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x001C492C File Offset: 0x001C2B2C
	private Color NKBLILLPIEO(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.FBKKEFOHNOF() == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.CIHKDLPPIGG());
			}
		}
		if (IHIHHCCEDHQ == "The pointed stones disappeared from around ")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == "3")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x001C49C4 File Offset: 0x001C2BC4
	public string QKQCMHNEILL(string NQFQGCGPHBE)
	{
		int num = NQFQGCGPHBE.IndexOf("Hold Item");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("Hidden/Post FX/Blit", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + 117)
			{
				return string.Empty;
			}
			string input = NQFQGCGPHBE.Substring(num + 6, -20);
			Guid empty = Guid.Empty;
			Guid.TryParse(input, out empty);
			if (!(empty != Guid.Empty))
			{
				return string.Empty;
			}
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(empty);
			if (fekoiojqnkh == null)
			{
				return string.Empty;
			}
			string text = " is exerting its pressure!\r\n" + KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString() + fekoiojqnkh.LDQDJLFIDCN.ToString() + "Primordial Sea";
			if (fekoiojqnkh.GEFODCNPFFI())
			{
				text = text + "ability" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL()) + "klutz";
			}
			else
			{
				text = text + " ended!\r\n" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + "Spearow";
			}
			text += " became fully charged due to its [ffff00]Power Herb[-]!\r\n";
			string str = NQFQGCGPHBE.Substring(1, num);
			string str2 = NQFQGCGPHBE.Substring(num2 + 7);
			NQFQGCGPHBE = str + text + str2;
			if (num + 5 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("Rock Head", num + 6);
			if (num + -109 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x001C123C File Offset: 0x001BF43C
	private void FLLICIOJBFH(MBGHQMKEFKO.ChannelClass KQFEHQEBJQB, string QHLIEEGQIDQ)
	{
		MBGHQMKEFKO.StoredChat storedChat = new MBGHQMKEFKO.StoredChat();
		storedChat.Message = QHLIEEGQIDQ;
		storedChat.Time = DateTime.Now;
		KQFEHQEBJQB.StoredLines.Add(storedChat);
		if (KQFEHQEBJQB.StoredLines.Count > this.MHNBGLFDCQM)
		{
			KQFEHQEBJQB.StoredLines.RemoveAt(1);
		}
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x00018F48 File Offset: 0x00017148
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x001C4B5C File Offset: 0x001C2D5C
	public void LLNKINDMONH(PSXAPI.Response.ChatJoin MHMMOHDEKMK)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		chatMessage.Channel = "-";
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		if (MHMMOHDEKMK.Result == ChatJoinResult.Error)
		{
			chatMessage2.Message = "BLOOM" + MHMMOHDEKMK.Channel + "ChangeBattleInventory";
			if (MHMMOHDEKMK.Channel.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF.ToLowerInvariant() || MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("%"))
			{
				this.HLMPKGHJIPM();
				MHMMOHDEKMK.Channel = "_ClipToWorld";
				chatMessage2 = null;
			}
			if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.DJQIJGOLPIO().FOFNJICKKIP && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "Crit increases the chance of landing a critical strike";
				chatMessage2 = null;
			}
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && MHMMOHDEKMK.Channel == NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() && MHMMOHDEKMK.Channel != string.Empty)
			{
				MHMMOHDEKMK.Channel = "move";
				chatMessage2 = null;
			}
			if (this.GPOPMFLGNHE(MHMMOHDEKMK.Channel) == null)
			{
				MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
				channelClass.Colour = this.GJHKKKMGCHQ(MHMMOHDEKMK.Channel);
				channelClass.ID = string.Empty;
				channelClass.Name = MHMMOHDEKMK.Channel;
				this.Channels.Add(channelClass);
				this.Tabs[0].ChannelIDs.Add(channelClass.Name);
				this.Tabs[1].ChannelIDs = this.Tabs[1].ChannelIDs.Distinct<string>().ToList<string>();
			}
			this.HQGBCCIKHCQ(false);
		}
		else
		{
			if (MHMMOHDEKMK.Result != ChatJoinResult.Left)
			{
				return;
			}
			bool flag = true;
			if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NOHEMGHONKK.HGEKKNEPOHK().IEICJDEDICD.Chat.ToString() == MHMMOHDEKMK.Channel)
			{
				flag = false;
			}
			if (MHMMOHDEKMK.Channel != DCJIBBJQGJP.CNIMIQKQJJJ().FOFNJICKKIP && !MHMMOHDEKMK.Channel.ToLowerInvariant().Contains("[pok=") && MHMMOHDEKMK.Channel.ToLowerInvariant() != CNCJKLNHQBH.BJLGEDCPENQ().KBEHCHKDFBF.ToLowerInvariant() && !flag)
			{
				chatMessage2.Message = "door_1" + MHMMOHDEKMK.Channel + "rocksmash";
				if (MHMMOHDEKMK.Channel.Length == 71)
				{
					chatMessage2 = null;
				}
				if (MHMMOHDEKMK.Channel != "ironfist" && MHMMOHDEKMK.Channel != "Member" && MHMMOHDEKMK.Channel != "firespin" && MHMMOHDEKMK.Channel != "..." && MHMMOHDEKMK.Channel != "_ChromaticAberration_Spectrum" && MHMMOHDEKMK.Channel != "HidePanel")
				{
					for (int i = 0; i < this.Channels.Count; i++)
					{
						if (this.Channels[i].Name == MHMMOHDEKMK.Channel)
						{
							this.Channels.RemoveAt(i);
							break;
						}
					}
				}
				else
				{
					chatMessage2 = null;
				}
			}
			else
			{
				if (MHMMOHDEKMK.Channel == DCJIBBJQGJP.OMPHLNDGKKM().FOFNJICKKIP)
				{
					DCJIBBJQGJP.MOGQNGEPCEO().FOFNJICKKIP = string.Empty;
				}
				chatMessage2 = null;
			}
			this.BKJQOPDKEJM(true);
		}
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[0] = chatMessage2;
		if (chatMessage2 != null)
		{
			this.PLMHOIOFOBK(chatMessage);
		}
		this.FIDHOIBBOMI(string.Empty);
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x00018F8B File Offset: 0x0001718B
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

	// Token: 0x06003AC6 RID: 15046 RVA: 0x001C4F18 File Offset: 0x001C3118
	public void LCCINOCIKLP(string QHLIEEGQIDQ)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		chatMessage.Channel = string.Empty;
		chatMessage2.Message = QHLIEEGQIDQ;
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[0];
		chatMessage.Messages[0] = chatMessage2;
		this.NDJFBGECGBG(chatMessage);
	}

	// Token: 0x06003AC7 RID: 15047 RVA: 0x001C4F60 File Offset: 0x001C3160
	public string JOEICKPOGNK(string NQFQGCGPHBE)
	{
		int num = NQFQGCGPHBE.IndexOf("[pok=");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("[/pok]", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + 49)
			{
				return string.Empty;
			}
			string input = NQFQGCGPHBE.Substring(num + 6, 36);
			Guid empty = Guid.Empty;
			Guid.TryParse(input, out empty);
			if (!(empty != Guid.Empty))
			{
				return string.Empty;
			}
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(empty);
			if (fekoiojqnkh == null)
			{
				return string.Empty;
			}
			string text = "[pok=" + KGQECFKLKOP.FHKHCIOMFEE(fekoiojqnkh).ToString() + fekoiojqnkh.LDQDJLFIDCN.ToString() + "]";
			if (fekoiojqnkh.BKNFHNFFCHE)
			{
				text = text + "[{" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + "}]";
			}
			else
			{
				text = text + "[" + KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ) + "]";
			}
			text += "[/pok]";
			string str = NQFQGCGPHBE.Substring(0, num);
			string str2 = NQFQGCGPHBE.Substring(num2 + 6);
			NQFQGCGPHBE = str + text + str2;
			if (num + 6 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("[pok=", num + 6);
			if (num + 48 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x001C50F8 File Offset: 0x001C32F8
	public void JQHJKFHHJIO()
	{
		for (int i = 0; i < this.Tabs.Count; i += 0)
		{
			if (this.Tabs[i].FLDOLNOLHLD() == "HidePanel")
			{
				return;
			}
		}
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
		obefkemnfnl.KJQHOGHFLFE("???");
		obefkemnfnl.ChannelIDs = new List<string>
		{
			"[00EE07]"
		};
		if (!obefkemnfnl.ChannelIDs.Contains("HidePanel"))
		{
			obefkemnfnl.ChannelIDs.Add("Speed Based Zoom");
		}
		if (!obefkemnfnl.ChannelIDs.Contains("Disabled"))
		{
			obefkemnfnl.ChannelIDs.Add("Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.");
		}
		this.Tabs.Add(obefkemnfnl);
		MBGHQMKEFKO.ChannelClass channelClass = new MBGHQMKEFKO.ChannelClass();
		channelClass.Colour = this.KNCPDQGDGCQ("Remove from Ignore");
		channelClass.ID = string.Empty;
		channelClass.Name = "TM";
		this.Channels.Add(channelClass);
		this.FICHKNQIHLL(string.Empty);
		this.MENLJBNQIJO();
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x001C5200 File Offset: 0x001C3400
	public void OKDBONDJMIO()
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.QEJPBCDDHMN(this.QLKBINCMPMK);
		List<MBGHQMKEFKO.StoredChat> list = new List<MBGHQMKEFKO.StoredChat>();
		if (obefkemnfnl != null)
		{
			foreach (string fpqbicgehmj in obefkemnfnl.ChannelIDs)
			{
				MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(fpqbicgehmj);
				if (channelClass != null)
				{
					list.AddRange(channelClass.StoredLines);
				}
			}
		}
		List<MBGHQMKEFKO.StoredChat> list2 = list;
		if (MBGHQMKEFKO.HNCJFHJNHDN == null)
		{
			MBGHQMKEFKO.HNCJFHJNHDN = new Comparison<MBGHQMKEFKO.StoredChat>(MBGHQMKEFKO.KOIEPPDEOLH);
		}
		list2.Sort(MBGHQMKEFKO.HNCJFHJNHDN);
		this.LQIQKMCLJIQ.CPLBKPNNHJG();
		for (int i = 0; i < list.Count; i++)
		{
			this.LQIQKMCLJIQ.DEJNPQEJINP(list[i].Message);
		}
		this.LQIQKMCLJIQ.NCDKCEPCQEB();
	}

	// Token: 0x06003ACA RID: 15050 RVA: 0x001C52E4 File Offset: 0x001C34E4
	public void ECKCCJBOPPM(DQLHHFEDBJG PNMMMQIGLCH)
	{
		if (PNMMMQIGLCH.FLHBMIMMJOK)
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = true;
			this.LPDIEFIDGFH.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		}
		else
		{
			this.LPDIEFIDGFH.GetComponent<BoxCollider>().enabled = true;
			this.LPDIEFIDGFH.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
		}
		this.PHQPIIOFQKK.transform.NMBPDMIIHJB();
		this.PHQPIIOFQKK.PFEIQDIJEKE();
		for (int i = 0; i < this.Channels.Count; i += 0)
		{
			NEMFLIFKDNO component = this.PHQPIIOFQKK.gameObject.BFCKNMFEBDM(this.KOCLHCLKKPP[0]).GetComponent<NEMFLIFKDNO>();
			component.FPQBICGEHMJ.LKPOBCBOFIC(this.Channels[i].Name);
			component.NIHLMCQMNIK = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
			if (this.Channels[i].Name == "anticipation" || this.Channels[i].Name == "hail" || this.Channels[i].Name == "DontScale" || this.Channels[i].Name == "Sand Force" || this.Channels[i].Name == "[ff4949]" || this.Channels[i].Name == "\nDay")
			{
				component.JJNIGOPBNCH.KJGMGPCEJJD = 0;
				component.JJNIGOPBNCH.GetComponent<BoxCollider>().enabled = true;
				component.JJNIGOPBNCH.gameObject.SetActive(false);
			}
			if (this.QEJPBCDDHMN(PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ).ChannelIDs.Contains(this.Channels[i].Name))
			{
				component.MJPJEPGLQOH.value = false;
			}
			else
			{
				component.MJPJEPGLQOH.value = true;
			}
			if (this.Channels[i].Name == "(D)")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(false);
			}
			if (this.Channels[i].Name == "There's no relief from this heavy rain!\r\n")
			{
				component.MJPJEPGLQOH.gameObject.SetActive(false);
			}
		}
		this.PHQPIIOFQKK.PFEIQDIJEKE();
		this.KJGEBKQEBPN = PNMMMQIGLCH.FPQBICGEHMJ.PIDLOFMIEFQ;
		this.IFCIQHQQLOM(false);
	}

	// Token: 0x06003ACB RID: 15051 RVA: 0x001C5560 File Offset: 0x001C3760
	public void IIGGMIJJPPM(string QHLIEEGQIDQ)
	{
		PSXAPI.Response.ChatMessage chatMessage = new PSXAPI.Response.ChatMessage();
		PSXAPI.Response.Payload.ChatMessage chatMessage2 = new PSXAPI.Response.Payload.ChatMessage();
		chatMessage.Channel = string.Empty;
		chatMessage2.Message = QHLIEEGQIDQ;
		chatMessage.Messages = new PSXAPI.Response.Payload.ChatMessage[1];
		chatMessage.Messages[1] = chatMessage2;
		this.PLMHOIOFOBK(chatMessage);
	}

	// Token: 0x06003ACC RID: 15052 RVA: 0x001C55A8 File Offset: 0x001C37A8
	public void FJKQLIFBCKD(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "Encounter Rate Increased";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "unnerve";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "FOG_HAZE_ON";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1181f, 894f, 1658f, 10f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = (BKKHLBCLPJM.GIMCHOOBMML)5;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(1170f, 7f, 905f, 151f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.None;
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "0";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "Player/Clothe";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = " is drowsing!\r\n";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 0)
		{
			FIKJCOHPQIC = 0;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].DFNQHDEDDKE() != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].GKQJLMKEQKD();
		}
		this.MFQONPCGGIG();
	}

	// Token: 0x06003ACD RID: 15053 RVA: 0x001C5744 File Offset: 0x001C3944
	public void MODFQKFPQNB(int FIKJCOHPQIC = 0)
	{
		foreach (IPJFFGJJFHL ipjffgjjfhl in this.ChatTabs)
		{
			if (ipjffgjjfhl.DBPKNCDGGEP == FIKJCOHPQIC)
			{
				ipjffgjjfhl.BLLHQPQBHBB.GJBCDOKDQQF(" stole and ate its target's [ffff00]");
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "/";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "hail";
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(464f, 125f, 1210f, 524f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = (BKKHLBCLPJM.GIMCHOOBMML)6;
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
			else
			{
				ipjffgjjfhl.BLLHQPQBHBB.IDEOONDHNEL = new Color(803f, 879f, 604f, 40f);
				ipjffgjjfhl.FPQBICGEHMJ.LMHJBBOENQB = BKKHLBCLPJM.GIMCHOOBMML.Shadow;
				ipjffgjjfhl.BLLHQPQBHBB.MNIPPKQLKNL = "Pointed stones dug into ";
				ipjffgjjfhl.BLLHQPQBHBB.OGEJCFNKILL = "After your payment has been verified your Lootboxes will be added to your account.";
				ipjffgjjfhl.BLLHQPQBHBB.MQGOHKQLLKH = "0";
				ipjffgjjfhl.BLLHQPQBHBB.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
		}
		if (FIKJCOHPQIC >= this.Tabs.Count || FIKJCOHPQIC < 1)
		{
			FIKJCOHPQIC = 1;
		}
		this.EEMLEDQJIFJ = FIKJCOHPQIC;
		if (this.Tabs[FIKJCOHPQIC].EPHNIGGJNPM() != string.Empty)
		{
			this.QLKBINCMPMK = this.Tabs[FIKJCOHPQIC].FEIQMIIDIBN();
		}
		this.MENLJBNQIJO();
	}

	// Token: 0x06003ACE RID: 15054 RVA: 0x00018FBD File Offset: 0x000171BD
	public void NJDLHKMHNOG()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("-", 1467f);
	}

	// Token: 0x06003ACF RID: 15055 RVA: 0x00018FE6 File Offset: 0x000171E6
	private void Awake()
	{
		MBGHQMKEFKO.QOQONHOOLNE = this;
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x001C58E0 File Offset: 0x001C3AE0
	public void NDJFBGECGBG(PSXAPI.Response.ChatMessage NQFQGCGPHBE)
	{
		if (NQFQGCGPHBE.Messages != null)
		{
			foreach (PSXAPI.Response.Payload.ChatMessage chatMessage in NQFQGCGPHBE.Messages)
			{
				if (!(CKMLKNPNPQO.QOQONHOOLNE != null) || !CKMLKNPNPQO.INJDHLQHFFD().OFKHICHJCIP(chatMessage.Username))
				{
					if (chatMessage.Pokemon != null && HFCMDEQKCKH.QOQONHOOLNE != null)
					{
						for (int j = 1; j < chatMessage.Pokemon.Length; j += 0)
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().LKFLGPCGHFD(chatMessage.Pokemon[j]);
						}
					}
					chatMessage.Message = this.HMLGEKPKGLL(chatMessage.Message);
					chatMessage.Message = this.FQJQHQFGKOI(chatMessage.Message, false);
					if (this.PCOJLOJJMMI.KGGCOFHHKEK)
					{
						chatMessage.Message = BWFManager.ReplaceAll(chatMessage.Message, ManagerMask.Capitalization, Array.Empty<string>());
					}
					if (NQFQGCGPHBE.Channel != null && NQFQGCGPHBE.Channel != string.Empty)
					{
						if (NQFQGCGPHBE.Channel.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().KBEHCHKDFBF.ToLowerInvariant())
						{
							NQFQGCGPHBE.Channel = "[FF8F00]";
						}
						else if (NQFQGCGPHBE.Channel.Contains("Eggs will now hatch quicker then normal.\nTriggers: [2ecc71]Flame Body[-], [2ecc71]Magma Armor[-]"))
						{
							return;
						}
						if (NQFQGCGPHBE.Channel == DCJIBBJQGJP.OQDOKBJNBBL().FOFNJICKKIP && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "-sideend";
						}
						if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NQFQGCGPHBE.Channel == NOHEMGHONKK.QBNCFLKLLKC().IEICJDEDICD.Chat.ToString() && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "_OcclusionTexture1";
						}
						MBGHQMKEFKO.ChannelClass channelClass = this.GPOPMFLGNHE(NQFQGCGPHBE.Channel);
						if (channelClass == null)
						{
							channelClass = this.Channels[0];
						}
						if (NQFQGCGPHBE.Channel == "Battle Update: ")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								if (chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("/Model.prefab"))
									{
										int ciqfcjgqemh = 1;
										int.TryParse(chatMessage.Message.Replace("0000000000000000000000000000\n0111111111111001111111111110\n0100001000001001000001000010\n0100001000001111000001000010\n0100001000001001000001000010\n0111111111111001111111111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001111001111001111110\n0001001000001001000001001000\n0001001000001001000001001000\n0111001111111111111111001110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001000000001001111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111001001111111111001001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111111111111111111111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111001111111001111111001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111001111001111001111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111111111111111111111111110\n0000000000000000000000000000", string.Empty), out ciqfcjgqemh);
										EBBMJNQGLJC.QOQONHOOLNE.GJJMFEIHCJO(ciqfcjgqemh, 172f);
										goto IL_626;
									}
									CNCJKLNHQBH.BJLGEDCPENQ().PPMJCBONMQJ.HEDDMKGFMQO.GIJCLPKMKFI(chatMessage.Message);
								}
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = CGOIPHKQMPD.LQIDEJOEHNH().EPOENLHFMON(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb != null && chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("runaway"))
									{
										int ciqfcjgqemh2 = 1;
										int.TryParse(chatMessage.Message.Replace("Enabled", string.Empty), out ciqfcjgqemh2);
										ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF.ONOOKCBOPEF(ciqfcjgqemh2, 1123f);
										goto IL_626;
									}
									ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.HQIKGIBOEOJ(chatMessage.Message);
								}
							}
						}
						else if (NQFQGCGPHBE.Channel == "[ff6666]")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.HEDDMKGFMQO.PPPBCGKFNMF(chatMessage.Message);
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb2 = CGOIPHKQMPD.QOQONHOOLNE.ODPOPBMMFIJ(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb2 != null)
								{
									ojoepkeebcb2.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.HCNPIJLODQE(chatMessage.Message);
								}
							}
						}
						if (chatMessage.Message == null || !chatMessage.Message.Contains("friendr"))
						{
							string text = "_Male";
							StaffRank rank = chatMessage.Rank;
							if (rank != StaffRank.Developer)
							{
								if (rank != StaffRank.GameModerator)
								{
									if (rank == (StaffRank)4)
									{
										text = "The healing wish came true for ";
									}
								}
								else
								{
									text = "^emote+";
								}
							}
							else
							{
								text = "You will encounter more bites when fishing!\nTriggers: [2ecc71]Sticky Hold[-], [2ecc71]Suction Cups[-]";
							}
							string text2 = string.Empty;
							if (chatMessage.Rank == StaffRank.Developer)
							{
								string[] array = new string[6];
								array[0] = "1";
								array[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array[2] = "[-] activated!\r\n";
								array[0] = NQFQGCGPHBE.Channel;
								array[3] = "Icon_Status_BadlyPoisoned";
								int num = 4;
								string text3;
								if (chatMessage.Username != null)
								{
									string[] array2 = new string[]
									{
										null,
										"*"
									};
									array2[1] = chatMessage.Username;
									array2[7] = "cdata";
									array2[7] = text;
									array2[2] = "default";
									array2[8] = chatMessage.Username;
									array2[7] = " / ";
									text3 = string.Concat(array2);
								}
								else
								{
									text3 = string.Empty;
								}
								array[num] = text3;
								array[6] = chatMessage.Message;
								array[4] = " (";
								text2 = string.Concat(array);
							}
							else
							{
								string[] array3 = new string[]
								{
									null,
									"_ClipToWorld"
								};
								array3[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour);
								array3[4] = "battler";
								array3[1] = NQFQGCGPHBE.Channel;
								array3[1] = "Guild Request";
								int num2 = 1;
								string text4;
								if (chatMessage.Username != null)
								{
									string[] array4 = new string[8];
									array4[0] = "p1";
									array4[0] = chatMessage.Username;
									array4[5] = "_FogColor";
									array4[6] = text;
									array4[4] = "Control+";
									array4[2] = chatMessage.Username;
									array4[2] = "MSGBOX - ";
									text4 = string.Concat(array4);
								}
								else
								{
									text4 = string.Empty;
								}
								array3[num2] = text4;
								array3[7] = chatMessage.Message;
								array3[7] = "CombinersArgsColorOp1";
								text2 = string.Concat(array3);
							}
							this.FLLICIOJBFH(channelClass, text2);
							MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.QEJPBCDDHMN(this.QLKBINCMPMK);
							if (obefkemnfnl != null && obefkemnfnl.ChannelIDs.Contains(channelClass.Name))
							{
								this.LQIQKMCLJIQ.LHQECHHMOGD(text2);
							}
						}
					}
					else
					{
						MBGHQMKEFKO.ChannelClass channelClass2 = this.Channels[1];
						string[] array5 = new string[0];
						array5[1] = "ingrain";
						array5[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array5[0] = "Marsh Badge";
						array5[5] = channelClass2.Name;
						array5[6] = "+";
						array5[5] = chatMessage.Message;
						array5[1] = "Guild Name";
						string text5 = string.Concat(array5);
						this.IKKDIFFDDEB(channelClass2, text5);
						MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 = this.BEGMKEJQPCI(this.QLKBINCMPMK);
						if (obefkemnfnl2 != null && obefkemnfnl2.ChannelIDs.Contains(channelClass2.Name))
						{
							this.LQIQKMCLJIQ.LHQECHHMOGD(text5);
						}
					}
				}
				IL_626:;
			}
		}
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x00018F25 File Offset: 0x00017125
	private static void GJQMFGJQBGC(MBGHQMKEFKO BGBMIEJJQKC)
	{
		MBGHQMKEFKO.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x001C5F24 File Offset: 0x001C4124
	public void HMMNNJBQELJ(NEMFLIFKDNO NHNMIFPINDL, Color CEGFBBHMKOE)
	{
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
		if (channelClass != null)
		{
			channelClass.Colour = CEGFBBHMKOE;
			this.HLEEEBDFNPL();
		}
		this.IFCIQHQQLOM(true);
		this.KJKKDGGIKEE.CPLBKPNNHJG();
		foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
		{
			if (channelClass2.Name != "_Power" && channelClass2.Name != "Fly" && channelClass2.Name != "aurabreak")
			{
				if (channelClass2.Name == "[")
				{
					if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null)
					{
						QCPKMJONIGF kjkkdggikee = this.KJKKDGGIKEE;
						string[] array = new string[]
						{
							" "
						};
						array[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array[0] = "???";
						array[7] = channelClass2.Name;
						array[1] = "Milk Drink";
						kjkkdggikee.OGIDEJGOKEC(string.Concat(array));
					}
				}
				else if (channelClass2.Name == " (TextureClip)")
				{
					if (DCJIBBJQGJP.DJQIJGOLPIO().COOLIKQMBMK)
					{
						QCPKMJONIGF kjkkdggikee2 = this.KJKKDGGIKEE;
						string[] array2 = new string[4];
						array2[1] = "sunnyday";
						array2[1] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
						array2[6] = "_BlurTex";
						array2[0] = channelClass2.Name;
						array2[7] = "HidePanel";
						kjkkdggikee2.OGIDEJGOKEC(string.Concat(array2));
					}
				}
				else
				{
					QCPKMJONIGF kjkkdggikee3 = this.KJKKDGGIKEE;
					string[] array3 = new string[1];
					array3[1] = "noguard";
					array3[0] = KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour);
					array3[8] = "TradeColliders";
					array3[6] = channelClass2.Name;
					array3[1] = "mdata";
					kjkkdggikee3.OGIDEJGOKEC(string.Concat(array3));
				}
			}
		}
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x001C6110 File Offset: 0x001C4310
	public void JoinChatChannel(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "guild" && IHIHHCCEDHQ.ToLowerInvariant() != "party" && IHIHHCCEDHQ.ToLowerInvariant() != "map" && IHIHHCCEDHQ.ToLowerInvariant() != "general" && IHIHHCCEDHQ.ToLowerInvariant() != "battle" && IHIHHCCEDHQ.ToLowerInvariant() != "system")
		{
			CNCJKLNHQBH.QOQONHOOLNE.NPNCKMQPGOK(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x001C6194 File Offset: 0x001C4394
	private Color GJHKKKMGCHQ(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.FEIQMIIDIBN() == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.FNCCGFEHNDC());
			}
		}
		if (IHIHHCCEDHQ == "quickguard")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == " ")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x001C622C File Offset: 0x001C442C
	public void MENLJBNQIJO()
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.BEGMKEJQPCI(this.QLKBINCMPMK);
		List<MBGHQMKEFKO.StoredChat> list = new List<MBGHQMKEFKO.StoredChat>();
		if (obefkemnfnl != null)
		{
			foreach (string fpqbicgehmj in obefkemnfnl.ChannelIDs)
			{
				MBGHQMKEFKO.ChannelClass channelClass = this.GPOPMFLGNHE(fpqbicgehmj);
				if (channelClass != null)
				{
					list.AddRange(channelClass.StoredLines);
				}
			}
		}
		List<MBGHQMKEFKO.StoredChat> list2 = list;
		if (MBGHQMKEFKO.HNCJFHJNHDN == null)
		{
			MBGHQMKEFKO.HNCJFHJNHDN = new Comparison<MBGHQMKEFKO.StoredChat>(MBGHQMKEFKO.KOIEPPDEOLH);
		}
		list2.Sort(MBGHQMKEFKO.HNCJFHJNHDN);
		this.LQIQKMCLJIQ.CPLBKPNNHJG();
		for (int i = 1; i < list.Count; i++)
		{
			this.LQIQKMCLJIQ.MCKMQCKEIBJ(list[i].Message);
		}
		this.LQIQKMCLJIQ.FCEJQKJMBDF();
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x00018FE6 File Offset: 0x000171E6
	private void EBBBBBBOCPJ()
	{
		MBGHQMKEFKO.QOQONHOOLNE = this;
	}

	// Token: 0x06003AD7 RID: 15063 RVA: 0x00018F5B File Offset: 0x0001715B
	public static MBGHQMKEFKO KGOPJQOMMNC()
	{
		return MBGHQMKEFKO.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003AD8 RID: 15064 RVA: 0x001C6310 File Offset: 0x001C4510
	public void JoinChannel()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Join Channel", "Enter a name of the Channel you wish to join.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Input, true, null, -1, false);
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x001C633C File Offset: 0x001C453C
	public string JJHPLIGNDJG(string NQFQGCGPHBE, bool EGIGHJBHMHP = false)
	{
		int num = NQFQGCGPHBE.IndexOf("-mega-x");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf(" days", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + -43)
			{
				return string.Empty;
			}
			string s = NQFQGCGPHBE.Substring(num + 1, 3);
			int num3 = 1;
			int.TryParse(s, out num3);
			if (num3 <= 1 || num3 >= -150)
			{
				return string.Empty;
			}
			KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(num3);
			if (EGIGHJBHMHP && INFJMNPKNQF.CFGIOIGOIFQ().IIDQEHOHECF(item.HLMQODIHBIG()) == 0u)
			{
				item = null;
			}
			if (item == null)
			{
				return string.Empty;
			}
			string[] array = new string[6];
			array[1] = "Btn_TabHighlighted_Hover";
			array[1] = num3.EBGLBFKHCJD();
			array[3] = "bind";
			array[6] = item.FLFQBGJQBBD();
			array[3] = "Protects itself and its allies from attacks that limit their move choices.";
			string str = string.Concat(array);
			string str2 = NQFQGCGPHBE.Substring(0, num);
			string str3 = NQFQGCGPHBE.Substring(num2 + 5);
			NQFQGCGPHBE = str2 + str + str3;
			if (num + 5 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("Battle Update: ", num + 1);
			if (num + 34 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x001C648C File Offset: 0x001C468C
	public void NBJOPEPEQBQ(NEMFLIFKDNO NHNMIFPINDL)
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.QEJPBCDDHMN(NHNMIFPINDL.NIHLMCQMNIK);
		if (obefkemnfnl != null)
		{
			if (obefkemnfnl.ChannelIDs.Contains(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ))
			{
				obefkemnfnl.ChannelIDs.Remove(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
			}
			else
			{
				obefkemnfnl.ChannelIDs.Add(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
			}
			obefkemnfnl.ChannelIDs = obefkemnfnl.ChannelIDs.Distinct<string>().ToList<string>();
		}
		this.FICHKNQIHLL(NHNMIFPINDL.NIHLMCQMNIK);
		this.OKDBONDJMIO();
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x001C6518 File Offset: 0x001C4718
	private Color KNCPDQGDGCQ(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.KHBIDFLQOOL() == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.Color);
			}
		}
		if (IHIHHCCEDHQ == " shrouded itself with Magic Coat!\r\n")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == "Sound")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x00018FEE File Offset: 0x000171EE
	public void LMBFMIBKDBF()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Reckless", 1162f);
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x001C242C File Offset: 0x001C062C
	private MBGHQMKEFKO.ChannelClass LOJJPCEKQOH(string FPQBICGEHMJ)
	{
		if (this.Channels.Count > 0)
		{
			using (List<MBGHQMKEFKO.ChannelClass>.Enumerator enumerator = this.Channels.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					MBGHQMKEFKO.ChannelClass channelClass = enumerator.Current;
					if (channelClass.Name == FPQBICGEHMJ)
					{
						return channelClass;
					}
				}
				goto IL_52;
			}
			MBGHQMKEFKO.ChannelClass result;
			return result;
		}
		IL_52:
		return null;
	}

	// Token: 0x06003ADE RID: 15070 RVA: 0x001C65B0 File Offset: 0x001C47B0
	private Color HMIFJPEQDQJ(string IHIHHCCEDHQ)
	{
		foreach (MBGHQMKEFKO.ChatSettingsClass chatSettingsClass in this.ChannelSettings)
		{
			if (chatSettingsClass.Name == IHIHHCCEDHQ)
			{
				return KGQECFKLKOP.JJQFHKDMDOL(chatSettingsClass.Color);
			}
		}
		if (IHIHHCCEDHQ == "General")
		{
			return this.HKOQJINJHGL;
		}
		if (IHIHHCCEDHQ == "System")
		{
			return Color.green;
		}
		return this.PHGNIDKPPHC;
	}

	// Token: 0x06003ADF RID: 15071 RVA: 0x001C6648 File Offset: 0x001C4848
	public void KHHMJIJDOOQ()
	{
		CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Map", "substitute", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)7, true, null, -1, false);
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x001C6674 File Offset: 0x001C4874
	public void IGFCQCCEMFF(PSXAPI.Response.ChatMessage NQFQGCGPHBE)
	{
		if (NQFQGCGPHBE.Messages != null)
		{
			foreach (PSXAPI.Response.Payload.ChatMessage chatMessage in NQFQGCGPHBE.Messages)
			{
				if (!(CKMLKNPNPQO.QOQONHOOLNE != null) || !CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(chatMessage.Username))
				{
					if (chatMessage.Pokemon != null && HFCMDEQKCKH.QOQONHOOLNE != null)
					{
						for (int j = 0; j < chatMessage.Pokemon.Length; j++)
						{
							HFCMDEQKCKH.QOQONHOOLNE.EJNMJKMKMJB(chatMessage.Pokemon[j]);
						}
					}
					chatMessage.Message = this.JOEICKPOGNK(chatMessage.Message);
					chatMessage.Message = this.FQJQHQFGKOI(chatMessage.Message, false);
					if (this.PCOJLOJJMMI.KGGCOFHHKEK)
					{
						chatMessage.Message = BWFManager.ReplaceAll(chatMessage.Message, ManagerMask.BadWord, Array.Empty<string>());
					}
					if (NQFQGCGPHBE.Channel != null && NQFQGCGPHBE.Channel != string.Empty)
					{
						if (NQFQGCGPHBE.Channel.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.KBEHCHKDFBF.ToLowerInvariant())
						{
							NQFQGCGPHBE.Channel = "Map";
						}
						else if (NQFQGCGPHBE.Channel.Contains("map:"))
						{
							return;
						}
						if (NQFQGCGPHBE.Channel == DCJIBBJQGJP.QOQONHOOLNE.FOFNJICKKIP && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "Party";
						}
						if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null && NQFQGCGPHBE.Channel == NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD.Chat.ToString() && NQFQGCGPHBE.Channel != string.Empty)
						{
							NQFQGCGPHBE.Channel = "Guild";
						}
						MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(NQFQGCGPHBE.Channel);
						if (channelClass == null)
						{
							channelClass = this.Channels[0];
						}
						if (NQFQGCGPHBE.Channel == "Map")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								if (chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("^emote+"))
									{
										int ciqfcjgqemh = 0;
										int.TryParse(chatMessage.Message.Replace("^emote+", string.Empty), out ciqfcjgqemh);
										EBBMJNQGLJC.QOQONHOOLNE.ONOOKCBOPEF(ciqfcjgqemh, 4f);
										goto IL_626;
									}
									CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.HEDDMKGFMQO.HCNPIJLODQE(chatMessage.Message);
								}
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb = CGOIPHKQMPD.QOQONHOOLNE.GMNHGNPKDML(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb != null && chatMessage.Message != null)
								{
									if (chatMessage.Message.Contains("^emote+"))
									{
										int ciqfcjgqemh2 = 0;
										int.TryParse(chatMessage.Message.Replace("^emote+", string.Empty), out ciqfcjgqemh2);
										ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().OPILOFIJJDF.ONOOKCBOPEF(ciqfcjgqemh2, 4f);
										goto IL_626;
									}
									ojoepkeebcb.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.HCNPIJLODQE(chatMessage.Message);
								}
							}
						}
						else if (NQFQGCGPHBE.Channel == "Party")
						{
							if (chatMessage.Username.ToLowerInvariant() == KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
							{
								CNCJKLNHQBH.QOQONHOOLNE.PPMJCBONMQJ.HEDDMKGFMQO.HCNPIJLODQE(chatMessage.Message);
							}
							else
							{
								CGOIPHKQMPD.OJOEPKEEBCB ojoepkeebcb2 = CGOIPHKQMPD.QOQONHOOLNE.GMNHGNPKDML(chatMessage.Username.ToLowerInvariant());
								if (ojoepkeebcb2 != null)
								{
									ojoepkeebcb2.LMIPGJDLQDP.GetComponent<DJOOHHIQGJK>().HEDDMKGFMQO.HCNPIJLODQE(chatMessage.Message);
								}
							}
						}
						if (chatMessage.Message == null || !chatMessage.Message.Contains("^emote+"))
						{
							string text = "ffffff";
							StaffRank rank = chatMessage.Rank;
							if (rank != StaffRank.Developer)
							{
								if (rank != StaffRank.GameModerator)
								{
									if (rank == StaffRank.Moderator)
									{
										text = "7fff49";
									}
								}
								else
								{
									text = "ffb649";
								}
							}
							else
							{
								text = "ff6649";
							}
							string text2 = string.Empty;
							if (chatMessage.Rank == StaffRank.Developer)
							{
								text2 = string.Concat(new string[]
								{
									"[",
									KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
									"][#",
									NQFQGCGPHBE.Channel,
									"][-] [00CCFF]",
									(chatMessage.Username == null) ? string.Empty : string.Concat(new string[]
									{
										"[urn=",
										chatMessage.Username,
										"][",
										text,
										"][u]",
										chatMessage.Username,
										"[/u][-][/urn]: "
									}),
									chatMessage.Message,
									"[-]"
								});
							}
							else
							{
								text2 = string.Concat(new string[]
								{
									"[",
									KGQECFKLKOP.PCLCOFCKINO(channelClass.Colour),
									"][#",
									NQFQGCGPHBE.Channel,
									"][-] [00CCFF]",
									(chatMessage.Username == null) ? string.Empty : string.Concat(new string[]
									{
										"[urn=",
										chatMessage.Username,
										"][",
										text,
										"]",
										chatMessage.Username,
										"[-][/urn]: "
									}),
									chatMessage.Message,
									"[-]"
								});
							}
							this.IKKDIFFDDEB(channelClass, text2);
							MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.QEJPBCDDHMN(this.QLKBINCMPMK);
							if (obefkemnfnl != null && obefkemnfnl.ChannelIDs.Contains(channelClass.Name))
							{
								this.LQIQKMCLJIQ.LHQECHHMOGD(text2);
							}
						}
					}
					else
					{
						MBGHQMKEFKO.ChannelClass channelClass2 = this.Channels[0];
						string text3 = string.Concat(new string[]
						{
							"[",
							KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour),
							"][#",
							channelClass2.Name,
							"][-] [00CCFF]",
							chatMessage.Message,
							"[-]"
						});
						this.IKKDIFFDDEB(channelClass2, text3);
						MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 = this.QEJPBCDDHMN(this.QLKBINCMPMK);
						if (obefkemnfnl2 != null && obefkemnfnl2.ChannelIDs.Contains(channelClass2.Name))
						{
							this.LQIQKMCLJIQ.LHQECHHMOGD(text3);
						}
					}
				}
				IL_626:;
			}
		}
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x001C6CB8 File Offset: 0x001C4EB8
	public void FFJKHLIGKMM(NEMFLIFKDNO NHNMIFPINDL, Color CEGFBBHMKOE)
	{
		MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(NHNMIFPINDL.FPQBICGEHMJ.PIDLOFMIEFQ);
		if (channelClass != null)
		{
			channelClass.Colour = CEGFBBHMKOE;
			this.UpdateCurrentChat();
		}
		this.BKJQOPDKEJM(false);
		this.KJKKDGGIKEE.CPLBKPNNHJG();
		foreach (MBGHQMKEFKO.ChannelClass channelClass2 in this.Channels)
		{
			if (channelClass2.Name != "General" && channelClass2.Name != "Battle" && channelClass2.Name != "System")
			{
				if (channelClass2.Name == "Guild")
				{
					if (NOHEMGHONKK.QOQONHOOLNE.IEICJDEDICD != null)
					{
						this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
						{
							"[",
							KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour),
							"]#",
							channelClass2.Name,
							"[-]"
						}));
					}
				}
				else if (channelClass2.Name == "Party")
				{
					if (DCJIBBJQGJP.QOQONHOOLNE.COOLIKQMBMK)
					{
						this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
						{
							"[",
							KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour),
							"]#",
							channelClass2.Name,
							"[-]"
						}));
					}
				}
				else
				{
					this.KJKKDGGIKEE.OGIDEJGOKEC(string.Concat(new string[]
					{
						"[",
						KGQECFKLKOP.PCLCOFCKINO(channelClass2.Colour),
						"]#",
						channelClass2.Name,
						"[-]"
					}));
				}
			}
		}
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x001C6EA4 File Offset: 0x001C50A4
	public void MFQONPCGGIG()
	{
		MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = this.BEGMKEJQPCI(this.QLKBINCMPMK);
		List<MBGHQMKEFKO.StoredChat> list = new List<MBGHQMKEFKO.StoredChat>();
		if (obefkemnfnl != null)
		{
			foreach (string fpqbicgehmj in obefkemnfnl.ChannelIDs)
			{
				MBGHQMKEFKO.ChannelClass channelClass = this.LOJJPCEKQOH(fpqbicgehmj);
				if (channelClass != null)
				{
					list.AddRange(channelClass.StoredLines);
				}
			}
		}
		List<MBGHQMKEFKO.StoredChat> list2 = list;
		if (MBGHQMKEFKO.HNCJFHJNHDN == null)
		{
			MBGHQMKEFKO.HNCJFHJNHDN = new Comparison<MBGHQMKEFKO.StoredChat>(MBGHQMKEFKO.KOIEPPDEOLH);
		}
		list2.Sort(MBGHQMKEFKO.HNCJFHJNHDN);
		this.LQIQKMCLJIQ.FBFCKBGLGBL();
		for (int i = 1; i < list.Count; i++)
		{
			this.LQIQKMCLJIQ.DEJNPQEJINP(list[i].Message);
		}
		this.LQIQKMCLJIQ.BIMPEOMLNBP();
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x001C6F88 File Offset: 0x001C5188
	public void NewTab()
	{
		CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Create Tab", "Enter a name for your New Tab.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Input, true, null, -1, false);
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x00019017 File Offset: 0x00017217
	public void HQFDFBKMQJM()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("For five turns, the Pokémon's Attack and Speed stats are halved.", 1844f);
	}

	// Token: 0x06003AE5 RID: 15077 RVA: 0x001C6FB4 File Offset: 0x001C51B4
	public void QFEHOKNPDGG()
	{
		this.ChannelSettings = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.ChatSettingsClass>>(PlayerPrefs.GetString(CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH + "_", string.Empty));
		if (this.ChannelSettings == null)
		{
			this.ChannelSettings = new List<MBGHQMKEFKO.ChatSettingsClass>();
		}
		this.Tabs = JsonConvert.DeserializeObject<List<MBGHQMKEFKO.OBEFKEMNFNL>>(PlayerPrefs.GetString(CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH + "You can not afford to reset your EVs", string.Empty));
		if (this.Tabs == null)
		{
			this.Tabs = new List<MBGHQMKEFKO.OBEFKEMNFNL>();
			MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.Name = "Guild Name: ";
			if (!obefkemnfnl.ChannelIDs.Contains("ability: "))
			{
				obefkemnfnl.ChannelIDs.Add("pickup");
			}
			this.Tabs.Add(obefkemnfnl);
			obefkemnfnl = new MBGHQMKEFKO.OBEFKEMNFNL();
			obefkemnfnl.IFDHPPQDKDK("PvP Wins:");
			if (!obefkemnfnl.ChannelIDs.Contains("nightmare"))
			{
				obefkemnfnl.ChannelIDs.Add("IFGPPIQKOPM");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("ditto"))
			{
				obefkemnfnl.ChannelIDs.Add("\nAccuracy: ");
			}
			if (!obefkemnfnl.ChannelIDs.Contains("You sense the presence of many!\r\n"))
			{
				obefkemnfnl.ChannelIDs.Add("colorchange");
			}
			obefkemnfnl.ChannelIDs = obefkemnfnl.ChannelIDs.Distinct<string>().ToList<string>();
			this.Tabs.Add(obefkemnfnl);
			this.QLKBINCMPMK = "firepledge";
		}
		else
		{
			foreach (MBGHQMKEFKO.OBEFKEMNFNL obefkemnfnl2 in this.Tabs)
			{
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
				if (!obefkemnfnl2.ChannelIDs.Contains("wrap"))
				{
					obefkemnfnl2.ChannelIDs.Add("#,##0");
				}
				if (!obefkemnfnl2.ChannelIDs.Contains("Resetting EVs"))
				{
					obefkemnfnl2.ChannelIDs.Add(" foresaw an attack!\r\n");
				}
				obefkemnfnl2.ChannelIDs = obefkemnfnl2.ChannelIDs.Distinct<string>().ToList<string>();
			}
		}
	}

	// Token: 0x06003AE6 RID: 15078 RVA: 0x001C71D8 File Offset: 0x001C53D8
	public void HLMPKGHJIPM()
	{
		bool flag = true;
		for (int i = 1; i < this.Channels.Count; i++)
		{
			if (this.Channels[i].Name.Contains("Connection Established.."))
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.ChatJoin
				{
					Channel = this.Channels[i].Name,
					Action = ChatJoinAction.Join
				}, true);
				this.Channels.RemoveAt(i);
				flag = false;
			}
		}
		if (flag && CNCJKLNHQBH.MOGQNGEPCEO().EFOGMBCFBGM)
		{
			this.HQGBCCIKHCQ(false);
			this.FIDHOIBBOMI(string.Empty);
		}
	}

	// Token: 0x06003AE7 RID: 15079 RVA: 0x001C727C File Offset: 0x001C547C
	public void HNHCNLOEEDB(string BHFOIQQMLGF)
	{
		CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("megalauncher", "Pokebox Button(Clone)" + BHFOIQQMLGF + "_Emission", BHFOIQQMLGF, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x001C72B0 File Offset: 0x001C54B0
	public string LFGQJBFJMEP(string NQFQGCGPHBE, bool EGIGHJBHMHP = false)
	{
		int num = NQFQGCGPHBE.IndexOf(" lost some of its HP!\r\n");
		while (num > -1 && num <= NQFQGCGPHBE.Length)
		{
			int num2 = NQFQGCGPHBE.IndexOf("#,##0", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			if (NQFQGCGPHBE.Length <= num + -118)
			{
				return string.Empty;
			}
			string s = NQFQGCGPHBE.Substring(num + 5, 7);
			int num3 = 0;
			int.TryParse(s, out num3);
			if (num3 <= 0 || num3 >= -36)
			{
				return string.Empty;
			}
			KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(num3);
			if (EGIGHJBHMHP && INFJMNPKNQF.QOQONHOOLNE.PNEEENCMBCN(item.GMOFFIFDCGE()) == 0u)
			{
				item = null;
			}
			if (item == null)
			{
				return string.Empty;
			}
			string[] array = new string[8];
			array[0] = "[-]!\r\n";
			array[1] = num3.EBGLBFKHCJD();
			array[2] = "Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.";
			array[4] = item.DFNQHDEDDKE();
			array[0] = "Logging in..";
			string str = string.Concat(array);
			string str2 = NQFQGCGPHBE.Substring(0, num);
			string str3 = NQFQGCGPHBE.Substring(num2 + 8);
			NQFQGCGPHBE = str2 + str + str3;
			if (num + 4 > NQFQGCGPHBE.Length)
			{
				return string.Empty;
			}
			num = NQFQGCGPHBE.IndexOf("'s power!\r\n", num + 0);
			if (num + -118 > NQFQGCGPHBE.Length)
			{
				num = -1;
			}
		}
		return NQFQGCGPHBE;
	}

	// Token: 0x06003AE9 RID: 15081 RVA: 0x001C7400 File Offset: 0x001C5600
	public void NHQFQJECQPQ(string IHIHHCCEDHQ)
	{
		if (IHIHHCCEDHQ.ToLowerInvariant() != "wrap" && IHIHHCCEDHQ.ToLowerInvariant() != "F14" && IHIHHCCEDHQ.ToLowerInvariant() != ">" && IHIHHCCEDHQ.ToLowerInvariant() != " found one [ffff00]" && IHIHHCCEDHQ.ToLowerInvariant() != "/01_1" && IHIHHCCEDHQ.ToLowerInvariant() != "Thunder Badge")
		{
			CNCJKLNHQBH.BJLGEDCPENQ().DNPDFNNHCHG(IHIHHCCEDHQ);
		}
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x001C7484 File Offset: 0x001C5684
	public void QPIJHMMDLDI()
	{
		CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("_Axis", "[00DD00]Owned" + this.KJGEBKQEBPN + "Vertical", this.KJGEBKQEBPN, LPBPDPMJKNN.PJIJIFKBMBB.YesNo, true, null, -1, true);
	}

	// Token: 0x04000D60 RID: 3424
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000D61 RID: 3425
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000D62 RID: 3426
	private int MHNBGLFDCQM = 40;

	// Token: 0x04000D63 RID: 3427
	public BHLIGEGNFHG JLEHKJPJCGO;

	// Token: 0x04000D64 RID: 3428
	public BHLIGEGNFHG PHQPIIOFQKK;

	// Token: 0x04000D65 RID: 3429
	public GameObject[] KOCLHCLKKPP;

	// Token: 0x04000D66 RID: 3430
	public List<MBGHQMKEFKO.OBEFKEMNFNL> Tabs = new List<MBGHQMKEFKO.OBEFKEMNFNL>();

	// Token: 0x04000D67 RID: 3431
	public List<MBGHQMKEFKO.ChannelClass> Channels = new List<MBGHQMKEFKO.ChannelClass>();

	// Token: 0x04000D68 RID: 3432
	public BMLIGLPMMLG LQIQKMCLJIQ;

	// Token: 0x04000D69 RID: 3433
	public string QLKBINCMPMK = "General";

	// Token: 0x04000D6A RID: 3434
	public int EEMLEDQJIFJ;

	// Token: 0x04000D6B RID: 3435
	public Color PHGNIDKPPHC;

	// Token: 0x04000D6C RID: 3436
	public Color HKOQJINJHGL;

	// Token: 0x04000D6D RID: 3437
	public CFDMNELIJLO LPDIEFIDGFH;

	// Token: 0x04000D6E RID: 3438
	public List<CFDMNELIJLO> ListOfChatTabButtons = new List<CFDMNELIJLO>();

	// Token: 0x04000D6F RID: 3439
	public List<IPJFFGJJFHL> ChatTabs = new List<IPJFFGJJFHL>();

	// Token: 0x04000D70 RID: 3440
	public GameObject NPIEPPJFDJN;

	// Token: 0x04000D71 RID: 3441
	private string JLFFPBJKMNP = "Map";

	// Token: 0x04000D72 RID: 3442
	public BKKHLBCLPJM FDBHFIQIQJC;

	// Token: 0x04000D73 RID: 3443
	public QCPKMJONIGF KJKKDGGIKEE;

	// Token: 0x04000D74 RID: 3444
	public DOQMQKHFODD PCOJLOJJMMI;

	// Token: 0x04000D75 RID: 3445
	public List<MBGHQMKEFKO.ChatSettingsClass> ChannelSettings = new List<MBGHQMKEFKO.ChatSettingsClass>();

	// Token: 0x04000D76 RID: 3446
	public BHLIGEGNFHG JDLHLNEPKHJ;

	// Token: 0x04000D77 RID: 3447
	public BKKHLBCLPJM DPMPDDEJNFM;

	// Token: 0x04000D78 RID: 3448
	private string KJGEBKQEBPN = string.Empty;

	// Token: 0x04000D79 RID: 3449
	[CompilerGenerated]
	private static Comparison<MBGHQMKEFKO.StoredChat> HNCJFHJNHDN;

	// Token: 0x020001C9 RID: 457
	public class StoredChat
	{
		// Token: 0x04000D7A RID: 3450
		public string Message;

		// Token: 0x04000D7B RID: 3451
		public DateTime Time;
	}

	// Token: 0x020001CA RID: 458
	public class ChannelClass
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x00019053 File Offset: 0x00017253
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x0001905B File Offset: 0x0001725B
		public string Name { get; set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x00019064 File Offset: 0x00017264
		// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x0001906C File Offset: 0x0001726C
		public string ID { get; set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x00019075 File Offset: 0x00017275
		// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x0001907D File Offset: 0x0001727D
		public Color Colour { get; set; }

		// Token: 0x04000D7F RID: 3455
		public List<MBGHQMKEFKO.StoredChat> StoredLines = new List<MBGHQMKEFKO.StoredChat>();
	}

	// Token: 0x020001CB RID: 459
	public class OBEFKEMNFNL
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x00019086 File Offset: 0x00017286
		public void EPKFPOHHPDL(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x0001908F File Offset: 0x0001728F
		public string PQGBDJGKECP()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x0001908F File Offset: 0x0001728F
		public string GKQJLMKEQKD()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00019086 File Offset: 0x00017286
		public void GJIGIBQKBGM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00019086 File Offset: 0x00017286
		public void HFEDLGBJBHD(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x0001908F File Offset: 0x0001728F
		public string EPHNIGGJNPM()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x0001908F File Offset: 0x0001728F
		public string FEIQMIIDIBN()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00019086 File Offset: 0x00017286
		public void FEENBPHHQKO(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00019086 File Offset: 0x00017286
		public void MGQQKDJMBLL(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00019086 File Offset: 0x00017286
		public void OOJCJOLNEDQ(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00019086 File Offset: 0x00017286
		public void EEONPDKOIOO(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00019086 File Offset: 0x00017286
		public void DDMNKIDJGBM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x0001908F File Offset: 0x0001728F
		public string NDPGCGDLEEQ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00019086 File Offset: 0x00017286
		public void LGCDCNNMPMN(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00019086 File Offset: 0x00017286
		public void CNKNDKGMQII(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06003B02 RID: 15106 RVA: 0x0001908F File Offset: 0x0001728F
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x00019086 File Offset: 0x00017286
		public string Name { get; set; }

		// Token: 0x06003B03 RID: 15107 RVA: 0x0001908F File Offset: 0x0001728F
		public string DOBGCHNIOHL()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x0001908F File Offset: 0x0001728F
		public string IGLOGLEBNQO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x0001908F File Offset: 0x0001728F
		public string IFCMDJMCLBD()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00019086 File Offset: 0x00017286
		public void BIKCFDCGKEI(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00019086 File Offset: 0x00017286
		public void IFDHPPQDKDK(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x0001908F File Offset: 0x0001728F
		public string NOOIDIKJOKF()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00019086 File Offset: 0x00017286
		public void EFIFIIBNBDF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x0001908F File Offset: 0x0001728F
		public string DQIHMNJNLNM()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x0001908F File Offset: 0x0001728F
		public string GEJFHIGHLGO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00019086 File Offset: 0x00017286
		public void PQDOKCGOCLQ(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x0001908F File Offset: 0x0001728F
		public string ECEEDMJLHDB()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x0001908F File Offset: 0x0001728F
		public string ONLHOLQGCHI()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x0001908F File Offset: 0x0001728F
		public string BGDJDBNKJHJ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x0001908F File Offset: 0x0001728F
		public string DFNQHDEDDKE()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00019086 File Offset: 0x00017286
		public void KDOOEOKBFJL(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x00019086 File Offset: 0x00017286
		public void DDOHFOPPIIB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00019086 File Offset: 0x00017286
		public void HJKPJLKMHEO(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x0001908F File Offset: 0x0001728F
		public string JOMPPDLDOJO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00019086 File Offset: 0x00017286
		public void FEJCEKHLJQP(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00019086 File Offset: 0x00017286
		public void KODLFNGFDGM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00019086 File Offset: 0x00017286
		public void ECPNDOEJGPE(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00019086 File Offset: 0x00017286
		public void HCOQLKCINHB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x0001908F File Offset: 0x0001728F
		public string IMODJJJLPLG()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00019086 File Offset: 0x00017286
		public void GHPFFIEQNJP(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00019086 File Offset: 0x00017286
		public void MEPCPOPFQLM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x00019086 File Offset: 0x00017286
		public void QQKGFJLHGPH(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x00019086 File Offset: 0x00017286
		public void CENFHDLNCMC(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x00019086 File Offset: 0x00017286
		public void LQQJDIODPED(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x0001908F File Offset: 0x0001728F
		public string FBDBHGEIGBE()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x0001908F File Offset: 0x0001728F
		public string JLQDMEIEMLM()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x0001908F File Offset: 0x0001728F
		public string KMGCMJIPCOO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00019086 File Offset: 0x00017286
		public void LNPFBNNOFFF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B24 RID: 15140 RVA: 0x00019086 File Offset: 0x00017286
		public void HGDIKCPEOMM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00019086 File Offset: 0x00017286
		public void KFDBJDHONHM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x00019086 File Offset: 0x00017286
		public void OEQFQJJGIJF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B28 RID: 15144 RVA: 0x0001908F File Offset: 0x0001728F
		public string DGQIJHLKJCP()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x00019086 File Offset: 0x00017286
		public void COEPBFDLHNG(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00019086 File Offset: 0x00017286
		public void NMLFJEJNEIB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x0001908F File Offset: 0x0001728F
		public string FLDOLNOLHLD()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x0001908F File Offset: 0x0001728F
		public string JJGEFDFEKEP()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00019086 File Offset: 0x00017286
		public void KJQHOGHFLFE(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x04000D81 RID: 3457
		public List<string> ChannelIDs = new List<string>();
	}

	// Token: 0x020001CC RID: 460
	public class ChatSettingsClass
	{
		// Token: 0x06003B2E RID: 15150 RVA: 0x000190AA File Offset: 0x000172AA
		public void PCGEOFIQMQE(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x000190B3 File Offset: 0x000172B3
		public string LNOFGGGDGEP()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x000190BB File Offset: 0x000172BB
		public void NNELHDQOKPE(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x000190B3 File Offset: 0x000172B3
		public string KMGCMJIPCOO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x000190B3 File Offset: 0x000172B3
		public string IGLOGLEBNQO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x000190C4 File Offset: 0x000172C4
		public string HEIDDBFKKNQ()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x000190BB File Offset: 0x000172BB
		public void PQDOKCGOCLQ(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x000190AA File Offset: 0x000172AA
		public void GLBMJOIODQE(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x000190BB File Offset: 0x000172BB
		public void KFDBJDHONHM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x000190AA File Offset: 0x000172AA
		public void FQMHEFFKPDD(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x000190B3 File Offset: 0x000172B3
		public string IBHEQQJJIJQ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x000190BB File Offset: 0x000172BB
		public void LNPFBNNOFFF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x000190C4 File Offset: 0x000172C4
		public string GPHKCOLHNHP()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000190BB File Offset: 0x000172BB
		public void OOJCJOLNEDQ(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x000190AA File Offset: 0x000172AA
		public void LHKQKIGMEMP(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x000190C4 File Offset: 0x000172C4
		public string NFIGKCGPIMO()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x000190B3 File Offset: 0x000172B3
		public string MMPDDKPODNJ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000190BB File Offset: 0x000172BB
		public void FEJCEKHLJQP(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x000190AA File Offset: 0x000172AA
		public void CHJLNJOLCDM(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000190AA File Offset: 0x000172AA
		public void FQFNPNKCMHB(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000190B3 File Offset: 0x000172B3
		public string KHBIDFLQOOL()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000190AA File Offset: 0x000172AA
		public void IPLBLNFJJJC(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x000190BB File Offset: 0x000172BB
		public void GNLEBEQDPBK(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x000190B3 File Offset: 0x000172B3
		public string ONKPQQBJLQM()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x000190C4 File Offset: 0x000172C4
		public string FNCCGFEHNDC()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x000190C4 File Offset: 0x000172C4
		public string HFJNOOGJHKM()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x000190C4 File Offset: 0x000172C4
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x000190AA File Offset: 0x000172AA
		public string Color { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x000190B3 File Offset: 0x000172B3
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x000190BB File Offset: 0x000172BB
		public string Name { get; set; }

		// Token: 0x06003B4A RID: 15178 RVA: 0x000190AA File Offset: 0x000172AA
		public void EJBEEOBJBEC(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x000190B3 File Offset: 0x000172B3
		public string FBKKEFOHNOF()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x000190BB File Offset: 0x000172BB
		public void MGQQKDJMBLL(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x000190BB File Offset: 0x000172BB
		public void QNJDNDEIBJL(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x000190AA File Offset: 0x000172AA
		public void QECDOCHDKHJ(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x000190C4 File Offset: 0x000172C4
		public string GQGLJQJBOOG()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x000190AA File Offset: 0x000172AA
		public void ODOPPOHDQMB(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x000190B3 File Offset: 0x000172B3
		public string FLFQBGJQBBD()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x000190BB File Offset: 0x000172BB
		public void PCMKFLFMMOF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x000190C4 File Offset: 0x000172C4
		public string JGLPPBELNJO()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x000190B3 File Offset: 0x000172B3
		public string BEIQPGGCMGH()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000190AA File Offset: 0x000172AA
		public void HEBFFBNGNBN(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x000190C4 File Offset: 0x000172C4
		public string NMMIENNBEFK()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000190B3 File Offset: 0x000172B3
		public string HBJBDKMGOJL()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000190AA File Offset: 0x000172AA
		public void MQJECFEIKFJ(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000190C4 File Offset: 0x000172C4
		public string JGOHQBQDHFC()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x000190BB File Offset: 0x000172BB
		public void CNKNDKGMQII(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x000190AA File Offset: 0x000172AA
		public void BDJKKDFIGHM(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x000190B3 File Offset: 0x000172B3
		public string FEIQMIIDIBN()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x000190BB File Offset: 0x000172BB
		public void QQKGFJLHGPH(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x000190BB File Offset: 0x000172BB
		public void GDPNJNJIJPM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x000190C4 File Offset: 0x000172C4
		public string OJLLBMFHFDQ()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x000190C4 File Offset: 0x000172C4
		public string LOIEHILHOHE()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000190B3 File Offset: 0x000172B3
		public string JQBDPHILQJO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000190BB File Offset: 0x000172BB
		public void HDFKNCIIPKP(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000190BB File Offset: 0x000172BB
		public void DDOHFOPPIIB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000190C4 File Offset: 0x000172C4
		public string CIHKDLPPIGG()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x000190B3 File Offset: 0x000172B3
		public string NDPGCGDLEEQ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x000190C4 File Offset: 0x000172C4
		public string HMOLNPPFDFL()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x000190BB File Offset: 0x000172BB
		public void EOOFJIHMFQB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x000190BB File Offset: 0x000172BB
		public void LNBFLMCFBIG(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x000190C4 File Offset: 0x000172C4
		public string DDKEKDQBHCQ()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x000190AA File Offset: 0x000172AA
		public void JNMDBINILJM(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x000190AA File Offset: 0x000172AA
		public void LBGQOLKBCKK(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x000190C4 File Offset: 0x000172C4
		public string CIMIJKOLJMH()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x000190BB File Offset: 0x000172BB
		public void BMEMLIFGJNC(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x000190B3 File Offset: 0x000172B3
		public string NCELICJEDKG()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x000190B3 File Offset: 0x000172B3
		public string JPMMGDNMPQC()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x000190BB File Offset: 0x000172BB
		public void IFDHPPQDKDK(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x000190AA File Offset: 0x000172AA
		public void FNMMEFNBGCE(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x000190BB File Offset: 0x000172BB
		public void GMGLQDLHCBB(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x000190C4 File Offset: 0x000172C4
		public string HPMCFHBBBFD()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x000190B3 File Offset: 0x000172B3
		public string EBNPCFNMEEF()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x000190C4 File Offset: 0x000172C4
		public string KDGIKOEKDQG()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x000190C4 File Offset: 0x000172C4
		public string LGLLLOCOMPH()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x000190C4 File Offset: 0x000172C4
		public string IQNPBIMKMQI()
		{
			return this.<Color>k__BackingField;
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x000190AA File Offset: 0x000172AA
		public void FHCBJOIBKDO(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x000190AA File Offset: 0x000172AA
		public void OEIMKMCDCLQ(string BGBMIEJJQKC)
		{
			this.<Color>k__BackingField = BGBMIEJJQKC;
		}
	}
}
