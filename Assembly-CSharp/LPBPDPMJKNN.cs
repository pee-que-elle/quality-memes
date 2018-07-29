using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x020001DD RID: 477
public class LPBPDPMJKNN : MonoBehaviour
{
	// Token: 0x06003E32 RID: 15922 RVA: 0x001E3448 File Offset: 0x001E1648
	public void CIILBFDLLQG()
	{
		if (this.ICHKBBMBPGM.Contains("It doesn't affect "))
		{
			string g = this.ICHKBBMBPGM.Substring(4);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = "Unnerves opposing Pokémon and makes them unable to eat Berries.",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x001E34B4 File Offset: 0x001E16B4
	public void LIDHPLOIFNP(CNCJKLNHQBH EJHIHINFCGL, string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int MOGLGJGFNDM = -1)
	{
		this.HCKMEIPJNLK = (float)MOGLGJGFNDM;
		this.PGBLHMLDGOJ[0].SetActive(true);
		this.PGBLHMLDGOJ[0].SetActive(true);
		this.PGBLHMLDGOJ[8].SetActive(false);
		this.PGBLHMLDGOJ[5].SetActive(false);
		this.PGBLHMLDGOJ[8].SetActive(true);
		this.PGBLHMLDGOJ[6].SetActive(false);
		this.POPHIHOHDJH.NDIJIFHOMJC();
		if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(false);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)0)
		{
			this.PGBLHMLDGOJ[6].SetActive(false);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel)
		{
			this.PGBLHMLDGOJ[1].SetActive(false);
			this.PGBLHMLDGOJ[1].SetActive(false);
			this.PGBLHMLDGOJ[3].SetActive(false);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)7)
		{
			this.PGBLHMLDGOJ[5].SetActive(false);
			this.PGBLHMLDGOJ[4].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(true);
		}
		if (DPQFDCNLLPC != (LPBPDPMJKNN.PJIJIFKBMBB)8)
		{
			this.QHEJPNJNMCI[1].transform.localPosition += new Vector3(1858f, 1378f, 1881f);
			this.QHEJPNJNMCI[0].MGQIGGNBBBD(52);
		}
		NQFQGCGPHBE = KGQECFKLKOP.LGGPFIJQHOM(NQFQGCGPHBE);
		this.PDIBIIKFBDH = MKBCKPPCIQO;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(HIEFQEEDHGG);
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = NQFQGCGPHBE;
		this.NKKMJICKKLB = HIEFQEEDHGG;
		this.ICHKBBMBPGM = GQFFOBCKGKG;
		if (this.NKKMJICKKLB == "[-]")
		{
			this.QHEJPNJNMCI[0].MNNBBPGPNJF = 4;
			this.PGBLHMLDGOJ[4].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Integer;
		}
		else
		{
			this.QHEJPNJNMCI[1].MNNBBPGPNJF = 0;
			this.PGBLHMLDGOJ[2].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Username;
		}
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x001E36B0 File Offset: 0x001E18B0
	public void KDCHGCMPDLJ(CNCJKLNHQBH EJHIHINFCGL, string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int MOGLGJGFNDM = -1)
	{
		this.HCKMEIPJNLK = (float)MOGLGJGFNDM;
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[8].SetActive(true);
		this.PGBLHMLDGOJ[3].SetActive(true);
		this.PGBLHMLDGOJ[8].SetActive(true);
		this.PGBLHMLDGOJ[3].SetActive(true);
		this.POPHIHOHDJH.NDIJIFHOMJC();
		if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)6)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[0].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[2].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.YesNo)
		{
			this.PGBLHMLDGOJ[1].SetActive(false);
			this.PGBLHMLDGOJ[0].SetActive(false);
			this.PGBLHMLDGOJ[7].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[3].SetActive(false);
			this.PGBLHMLDGOJ[6].SetActive(false);
			this.PGBLHMLDGOJ[1].SetActive(false);
		}
		if (DPQFDCNLLPC != (LPBPDPMJKNN.PJIJIFKBMBB)0)
		{
			this.QHEJPNJNMCI[0].transform.localPosition += new Vector3(767f, 522f, 1291f);
			this.QHEJPNJNMCI[0].DFKQMMIQDOO = -87;
		}
		NQFQGCGPHBE = KGQECFKLKOP.LGGPFIJQHOM(NQFQGCGPHBE);
		this.PDIBIIKFBDH = MKBCKPPCIQO;
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = HIEFQEEDHGG;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(NQFQGCGPHBE);
		this.NKKMJICKKLB = HIEFQEEDHGG;
		this.ICHKBBMBPGM = GQFFOBCKGKG;
		if (this.NKKMJICKKLB == "\"")
		{
			this.QHEJPNJNMCI[0].MNNBBPGPNJF = 3;
			this.PGBLHMLDGOJ[8].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Username;
		}
		else
		{
			this.QHEJPNJNMCI[1].MNNBBPGPNJF = 0;
			this.PGBLHMLDGOJ[5].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.GuildName;
		}
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003E35 RID: 15925 RVA: 0x001E38AC File Offset: 0x001E1AAC
	public void BEELHJLMENJ()
	{
		if (this.ICHKBBMBPGM.Contains("13"))
		{
			string g = this.ICHKBBMBPGM.Substring(2);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "System",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "'s ")
		{
			string[] array = this.ICHKBBMBPGM.Split(new string[]
			{
				"Grain Lookup Texture"
			}, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array[1]),
				SpriteID = Convert.ToInt32(array[1])
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "stealthrock")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = (UpgradeType)7
			}, true);
			NOHEMGHONKK.HGEKKNEPOHK().JGDDJEBQLJN.SetActive(true);
		}
		else if (this.NKKMJICKKLB == "Sound")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.None
			}, false);
			JJGLMJNELOK.KGOPJQOMMNC().BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
			JJGLMJNELOK.KGOPJQOMMNC().BMFCMLPMFHQ.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
		}
		else if (this.NKKMJICKKLB == "[/i]")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.BJLGEDCPENQ().MGJPFKOCGGC("(G)");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
				{
					Action = EffectAction.Cancel,
					UID = nbfcpoplomf.BEILHFKFLEG()
				}, false);
			}
		}
		else if (this.NKKMJICKKLB == "_Dissolve")
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array2 = new string[1];
			array2[1] = "snatch";
			string[] array3 = ichkbbmbpgm.Split(array2, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array3[0],
				ScriptID = new Guid(array3[0])
			}, true);
			QOHCEBMQKMB.QQCNCIQQPIG().CCQPKOGODQB();
		}
		else if (this.NKKMJICKKLB == "_SampleCount")
		{
			string ichkbbmbpgm2 = this.ICHKBBMBPGM;
			string[] array4 = new string[1];
			array4[1] = "sapsipper";
			string[] array5 = ichkbbmbpgm2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array5[0],
				ScriptID = new Guid(array5[0])
			}, false);
			QOHCEBMQKMB.JLLBKOOQKGO().FOCOHPNMBMG();
			QLKJQPNKPBC.KNOOOEMQOFL().QPFHQMFPNEQ(array5[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "'s [ffff00]")
			{
				INFJMNPKNQF.IPOKOKIJECO().DQMOQINPHHP(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "healreplacement")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evs
				{
					Action = (EvsAction)8,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "frustration")
			{
				NOHEMGHONKK.QBNCFLKLLKC().CJEFINGOOKD();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[PG]")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Ivs
				{
					Action = IvsAction.RequestPrice,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[0],
					Atk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Def = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[8],
					SpAtk = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[4],
					SpDef = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[5],
					Speed = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[7]
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[00FF00]")
			{
				INFJMNPKNQF.QOQONHOOLNE.IKNOBIPHNPP(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[-]")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = false
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "skydrop")
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>().NPEMPOHPMJK(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "AlwaysRain")
			{
				MBGHQMKEFKO.QOQONHOOLNE.OKDQLINCJOM(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Up")
			{
				if (INFJMNPKNQF.IPOKOKIJECO().QIOKIQOBMMB >= 4294967171u)
				{
					string bgbmiejjqkc = this.PGBLHMLDGOJ[1].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC;
					if (bgbmiejjqkc.Length >= 0 && bgbmiejjqkc.Length <= 24)
					{
						NOHEMGHONKK.QBNCFLKLLKC().HLQHMDJLGQL(bgbmiejjqkc);
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Player/Mounts/", "J16", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
					}
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("\n", "_", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "ability")
			{
				MBGHQMKEFKO.QOQONHOOLNE.OKMGGQDMQNO(this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "OnLocalize")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().JoinChatChannel(this.PGBLHMLDGOJ[7].GetComponent<JIMBBPLINGI>().HJMJDJKOILH());
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "\n")
			{
				MBGHQMKEFKO.QOQONHOOLNE.LPQCOJOBBJC(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "\r\n")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Friend
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Input - PMChat")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq2, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == " (ID:")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Party
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Becomes competitive and deals more damage to Pokémon of the same gender, but deals less to Pokémon of the opposite gender.")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Guild
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "item: ")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Guild
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("sandforce") != -1 && this.ICHKBBMBPGM.Length > 2)
		{
			string ichkbbmbpgm3 = this.ICHKBBMBPGM;
			string[] array6 = new string[1];
			array6[1] = "Pokémon Caught:";
			string[] array7 = ichkbbmbpgm3.Split(array6, StringSplitOptions.RemoveEmptyEntries);
			if (array7[0].Length <= 1)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E36 RID: 15926 RVA: 0x001E40E0 File Offset: 0x001E22E0
	public void No()
	{
		if (this.ICHKBBMBPGM != null && this.ICHKBBMBPGM.Contains("Script:"))
		{
			string g = this.ICHKBBMBPGM.Substring(7);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "0",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Trade Request")
		{
			Request dcgclgqcgdq = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Trade
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Party Request")
		{
			Request dcgclgqcgdq2 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Party
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq2, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Friend Request")
		{
			Request dcgclgqcgdq3 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Friend
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Battle Request")
		{
			Request dcgclgqcgdq4 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Battle
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Guild Request")
		{
			Request dcgclgqcgdq5 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Guild
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.ICHKBBMBPGM.IndexOf("<|>") != -1 && this.ICHKBBMBPGM.Length > 3)
		{
			string[] array = this.ICHKBBMBPGM.Split(new string[]
			{
				"<|>"
			}, StringSplitOptions.None);
			if (array[1].Length <= 1)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x001E4324 File Offset: 0x001E2524
	public void Yes()
	{
		if (this.ICHKBBMBPGM.Contains("Script:"))
		{
			string g = this.ICHKBBMBPGM.Substring(7);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "1",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Purchase Costume")
		{
			string[] array = this.ICHKBBMBPGM.Split(new string[]
			{
				":"
			}, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array[0]),
				SpriteID = Convert.ToInt32(array[1])
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Upgrade Guild")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.Guild
			}, false);
			NOHEMGHONKK.QOQONHOOLNE.JGDDJEBQLJN.SetActive(false);
		}
		else if (this.NKKMJICKKLB == "Upgrade Pokébox")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.Pokebox
			}, false);
			JJGLMJNELOK.QOQONHOOLNE.BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
			JJGLMJNELOK.QOQONHOOLNE.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
		else if (this.NKKMJICKKLB == "Surf")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.LJBHIMMHGLP("Surf");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
				{
					Action = EffectAction.Use,
					UID = nbfcpoplomf.CBBBCEMLMLP
				}, false);
			}
		}
		else if (this.NKKMJICKKLB == "Shop")
		{
			string[] array2 = this.ICHKBBMBPGM.Split(new string[]
			{
				"+"
			}, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array2[0],
				ScriptID = new Guid(array2[1])
			}, false);
			QOHCEBMQKMB.QOQONHOOLNE.FinishScript();
		}
		else if (this.NKKMJICKKLB == "Move Learning")
		{
			string[] array3 = this.ICHKBBMBPGM.Split(new string[]
			{
				"+"
			}, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array3[0],
				ScriptID = new Guid(array3[1])
			}, false);
			QOHCEBMQKMB.QOQONHOOLNE.FinishScript();
			QLKJQPNKPBC.QOQONHOOLNE.NPFHGOJMNLC(array3[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "Hold or Use?")
			{
				INFJMNPKNQF.QOQONHOOLNE.IHOJLPELDDI(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Reset EVs")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evs
				{
					Action = EvsAction.Reset,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Guild Logo")
			{
				NOHEMGHONKK.QOQONHOOLNE.CJEFINGOOKD();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Reset IVs")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Ivs
				{
					Action = IvsAction.Randomize,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Atk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[1],
					Def = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[2],
					SpAtk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[3],
					SpDef = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[4],
					Speed = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[5]
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Hold Item")
			{
				INFJMNPKNQF.QOQONHOOLNE.HGFPKGEDEBE(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Remove Item")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = true
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Confirm EVs")
			{
				HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>().ODJDNQIQMDH(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Delete Tab")
			{
				MBGHQMKEFKO.QOQONHOOLNE.KODDCDHNJMO(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Guild")
			{
				if (INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB >= 1000u)
				{
					string bgbmiejjqkc = this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC;
					if (bgbmiejjqkc.Length >= 3 && bgbmiejjqkc.Length <= 20)
					{
						NOHEMGHONKK.QOQONHOOLNE.HLQHMDJLGQL(bgbmiejjqkc);
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Create Guild", "Guild name must be between 3 and 20 Characters in length.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
					}
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Create Guild", "You need [PG]1,000 to create a Guild.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Create Tab")
			{
				MBGHQMKEFKO.QOQONHOOLNE.CreateTab(this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Join Channel")
			{
				MBGHQMKEFKO.QOQONHOOLNE.JoinChatChannel(this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Leave Channel")
			{
				MBGHQMKEFKO.QOQONHOOLNE.LeaveChatChannel(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Trade Request")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Trade
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Friend Request")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Friend
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq2, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Party Request")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Party
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Battle Request")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Battle
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Guild Request")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Guild
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("<|>") != -1 && this.ICHKBBMBPGM.Length > 3)
		{
			string[] array4 = this.ICHKBBMBPGM.Split(new string[]
			{
				"<|>"
			}, StringSplitOptions.None);
			if (array4[0].Length <= 1)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x001E4B58 File Offset: 0x001E2D58
	public void BQLIIQIIMDH(CNCJKLNHQBH EJHIHINFCGL, string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int MOGLGJGFNDM = -1)
	{
		this.HCKMEIPJNLK = (float)MOGLGJGFNDM;
		this.PGBLHMLDGOJ[0].SetActive(false);
		this.PGBLHMLDGOJ[1].SetActive(false);
		this.PGBLHMLDGOJ[2].SetActive(false);
		this.PGBLHMLDGOJ[3].SetActive(false);
		this.PGBLHMLDGOJ[4].SetActive(false);
		this.PGBLHMLDGOJ[5].SetActive(false);
		this.POPHIHOHDJH.NDIJIFHOMJC();
		if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.YesNo)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[2].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Input)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(true);
			this.PGBLHMLDGOJ[3].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel)
		{
			this.PGBLHMLDGOJ[4].SetActive(true);
			this.PGBLHMLDGOJ[5].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(true);
		}
		if (DPQFDCNLLPC != LPBPDPMJKNN.PJIJIFKBMBB.Input)
		{
			this.QHEJPNJNMCI[1].transform.localPosition += new Vector3(0f, -15f, 0f);
			this.QHEJPNJNMCI[1].DFKQMMIQDOO = 82;
		}
		NQFQGCGPHBE = KGQECFKLKOP.LGGPFIJQHOM(NQFQGCGPHBE);
		this.PDIBIIKFBDH = MKBCKPPCIQO;
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = HIEFQEEDHGG;
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = NQFQGCGPHBE;
		this.NKKMJICKKLB = HIEFQEEDHGG;
		this.ICHKBBMBPGM = GQFFOBCKGKG;
		if (this.NKKMJICKKLB == "Guild")
		{
			this.QHEJPNJNMCI[1].MNNBBPGPNJF = 4;
			this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.GuildName;
		}
		else
		{
			this.QHEJPNJNMCI[1].MNNBBPGPNJF = 0;
			this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Alphanumeric;
		}
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x00019BE0 File Offset: 0x00017DE0
	public void KCNQKFEQQEB()
	{
		if (this.NKKMJICKKLB == "_")
		{
			INFJMNPKNQF.QOQONHOOLNE.DIMBOLLHNKC(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x001E4D54 File Offset: 0x001E2F54
	public void DEPHJMJBIPE(CNCJKLNHQBH EJHIHINFCGL, string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int MOGLGJGFNDM = -1)
	{
		this.HCKMEIPJNLK = (float)MOGLGJGFNDM;
		this.PGBLHMLDGOJ[0].SetActive(false);
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[2].SetActive(true);
		this.PGBLHMLDGOJ[7].SetActive(true);
		this.PGBLHMLDGOJ[0].SetActive(false);
		this.POPHIHOHDJH.NDIJIFHOMJC();
		if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Okay)
		{
			this.PGBLHMLDGOJ[8].SetActive(true);
		}
		else if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.Input)
		{
			this.PGBLHMLDGOJ[1].SetActive(true);
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[7].SetActive(false);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)8)
		{
			this.PGBLHMLDGOJ[2].SetActive(false);
			this.PGBLHMLDGOJ[3].SetActive(true);
			this.PGBLHMLDGOJ[1].SetActive(false);
		}
		if (DPQFDCNLLPC != (LPBPDPMJKNN.PJIJIFKBMBB)5)
		{
			this.QHEJPNJNMCI[0].transform.localPosition += new Vector3(797f, 629f, 605f);
			this.QHEJPNJNMCI[1].DFKQMMIQDOO = -70;
		}
		NQFQGCGPHBE = KGQECFKLKOP.LGGPFIJQHOM(NQFQGCGPHBE);
		this.PDIBIIKFBDH = MKBCKPPCIQO;
		this.QHEJPNJNMCI[0].PIDLOFMIEFQ = HIEFQEEDHGG;
		this.QHEJPNJNMCI[0].LKPOBCBOFIC(NQFQGCGPHBE);
		this.NKKMJICKKLB = HIEFQEEDHGG;
		this.ICHKBBMBPGM = GQFFOBCKGKG;
		if (this.NKKMJICKKLB == "Remove Item")
		{
			this.QHEJPNJNMCI[0].IQCIHQJCINE(0);
			this.PGBLHMLDGOJ[8].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Integer;
		}
		else
		{
			this.QHEJPNJNMCI[0].IQCIHQJCINE(0);
			this.PGBLHMLDGOJ[8].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.GuildName;
		}
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x001E4F50 File Offset: 0x001E3150
	public void EJOGQGIFLJC()
	{
		if (this.ICHKBBMBPGM != null && this.ICHKBBMBPGM.Contains(" stole and ate its target's [ffff00]"))
		{
			string g = this.ICHKBBMBPGM.Substring(2);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "This Pokémon has its own tempo, and that prevents it from becoming confused.",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "scripted")
		{
			Request dcgclgqcgdq = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Guild
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Gotcha! ")
		{
			Request dcgclgqcgdq2 = new Request
			{
				Accepted = true,
				Sender = this.ICHKBBMBPGM,
				Type = (RequestType)6
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq2, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "/03_")
		{
			Request dcgclgqcgdq3 = new Request
			{
				Accepted = true,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Friend
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq3, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == " has been afflicted with an infestation by ")
		{
			Request dcgclgqcgdq4 = new Request
			{
				Accepted = true,
				Sender = this.ICHKBBMBPGM,
				Type = (RequestType)6
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "berry_16")
		{
			Request dcgclgqcgdq5 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Trade
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq5, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.ICHKBBMBPGM.IndexOf(". ") != -1 && this.ICHKBBMBPGM.Length > 3)
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array = new string[0];
			array[0] = "BuffIcon_HailstormEncounterDecreased";
			string[] array2 = ichkbbmbpgm.Split(array, StringSplitOptions.None);
			if (array2[1].Length <= 1)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E3D RID: 15933 RVA: 0x001E5194 File Offset: 0x001E3394
	public void HGCEFKJCPQP()
	{
		if (this.ICHKBBMBPGM.Contains("Simple"))
		{
			string g = this.ICHKBBMBPGM.Substring(0);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "!\r\n",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "money=")
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array = new string[0];
			array[1] = "_CoCTex";
			string[] array2 = ichkbbmbpgm.Split(array, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array2[1]),
				SpriteID = Convert.ToInt32(array2[0])
			}, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Prefabs/FogSphereArea")
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Upgrade
			{
				Type = (UpgradeType)5
			}, true);
			NOHEMGHONKK.QOQONHOOLNE.JGDDJEBQLJN.SetActive(false);
		}
		else if (this.NKKMJICKKLB == ")")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.None
			}, true);
			JJGLMJNELOK.BEKHPOHIPDE().BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
			JJGLMJNELOK.KGOPJQOMMNC().BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, true);
		}
		else if (this.NKKMJICKKLB == "'s power!\r\n")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.MKMJKLDDNDD().LJBHIMMHGLP("Mount");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
				{
					Action = EffectAction.Cancel,
					UID = nbfcpoplomf.CBBBCEMLMLP
				}, true);
			}
		}
		else if (this.NKKMJICKKLB == "System Message")
		{
			string[] array3 = this.ICHKBBMBPGM.Split(new string[]
			{
				"shedskin"
			}, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array3[0],
				ScriptID = new Guid(array3[1])
			}, true);
			QOHCEBMQKMB.JLLBKOOQKGO().KMPBMIHNOQM();
		}
		else if (this.NKKMJICKKLB == "_HatTex")
		{
			string ichkbbmbpgm2 = this.ICHKBBMBPGM;
			string[] array4 = new string[1];
			array4[1] = "Failed to use '";
			string[] array5 = ichkbbmbpgm2.Split(array4, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array5[1],
				ScriptID = new Guid(array5[0])
			}, false);
			QOHCEBMQKMB.JLLBKOOQKGO().FinishScript();
			QLKJQPNKPBC.QOQONHOOLNE.PIHCHEBPICI(array5[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "last online ")
			{
				INFJMNPKNQF.DOGEBLQHDHI().DQMOQINPHHP(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Boosts the Pokémon's Sp. Atk stat when it takes a hit that causes its HP to become half or less.")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evs
				{
					Action = (EvsAction)6,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "7fff49")
			{
				NOHEMGHONKK.QOQONHOOLNE.PKHNKJDMHBQ();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[-][/c]")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Ivs
				{
					Action = IvsAction.RequestPrice,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Atk = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[0],
					Def = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[5],
					SpAtk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[7],
					SpDef = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[4],
					Speed = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[3]
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "/trade ")
			{
				INFJMNPKNQF.DOGEBLQHDHI().QDIHIKCNPOD(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == ")[-]")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = true
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "DirY")
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>().ODJDNQIQMDH(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "blinky")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().OGJDPEGDKHL(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "/")
			{
				if (INFJMNPKNQF.IPOKOKIJECO().QIOKIQOBMMB >= 4294967188u)
				{
					string bgbmiejjqkc = this.PGBLHMLDGOJ[6].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC;
					if (bgbmiejjqkc.Length >= 0 && bgbmiejjqkc.Length <= -48)
					{
						NOHEMGHONKK.HGEKKNEPOHK().QHEDBICNJKN(bgbmiejjqkc);
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF(" doesn't become confused!\r\n", "Hidden/Post FX/Depth Of Field", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
					}
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("Blank", " is already frozen solid.\r\n", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "/")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().OKMGGQDMQNO(this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().HJMJDJKOILH());
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "pressure")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().JoinChatChannel(this.PGBLHMLDGOJ[1].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Appear Online")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().BJIDKDCIJLJ(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == " is hoping to take its attacker down with it!\r\n")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Trade
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[/urn]")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq2, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "#,##0")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Trade
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq3, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "berry_14")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Party
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "' is already present")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Guild
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq5, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("HidePanel") != -1 && this.ICHKBBMBPGM.Length > 2)
		{
			string[] array6 = this.ICHKBBMBPGM.Split(new string[]
			{
				" closed the Chat Window."
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array6[0].Length <= 0)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E3E RID: 15934 RVA: 0x001E59C8 File Offset: 0x001E3BC8
	private void Update()
	{
		if (this.HCKMEIPJNLK > -1f)
		{
			this.BCQCGFDQPDQ += UnityEngine.Time.deltaTime;
			int num = (int)(this.BCQCGFDQPDQ % 60f);
			if ((float)num >= this.HCKMEIPJNLK)
			{
				this.No();
			}
			this.QHEJPNJNMCI[0].PIDLOFMIEFQ = this.NKKMJICKKLB + " (" + (this.HCKMEIPJNLK - (float)num).ToString() + ")";
		}
	}

	// Token: 0x06003E3F RID: 15935 RVA: 0x001E5A4C File Offset: 0x001E3C4C
	public void GKDGGLDDJGP()
	{
		if (this.ICHKBBMBPGM.Contains("Times Fainted:"))
		{
			string g = this.ICHKBBMBPGM.Substring(5);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "Powers up punching moves.",
				ScriptID = new Guid(g)
			}, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Assets/AssetBundles/Pokes")
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array = new string[0];
			array[0] = "item";
			string[] array2 = ichkbbmbpgm.Split(array, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array2[0]),
				SpriteID = Convert.ToInt32(array2[0])
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "The healing wish came true for ")
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Upgrade
			{
				Type = UpgradeType.Pokebox
			}, false);
			NOHEMGHONKK.QBNCFLKLLKC().JGDDJEBQLJN.SetActive(false);
		}
		else if (this.NKKMJICKKLB == "Password Change")
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Upgrade
			{
				Type = UpgradeType.None
			}, true);
			JJGLMJNELOK.BEKHPOHIPDE().BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
			JJGLMJNELOK.BEKHPOHIPDE().BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
		else if (this.NKKMJICKKLB == "[PD]")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.QOQONHOOLNE.GBCDKJJGEFO("Boosts the Attack and Sp. Def stats of itself and allies when it is sunny.");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
				{
					Action = EffectAction.Use,
					UID = nbfcpoplomf.CBBBCEMLMLP
				}, false);
			}
		}
		else if (this.NKKMJICKKLB == "_Params")
		{
			string ichkbbmbpgm2 = this.ICHKBBMBPGM;
			string[] array3 = new string[0];
			array3[1] = "brickbreak";
			string[] array4 = ichkbbmbpgm2.Split(array3, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array4[1],
				ScriptID = new Guid(array4[0])
			}, true);
			QOHCEBMQKMB.QQCNCIQQPIG().FOCOHPNMBMG();
		}
		else if (this.NKKMJICKKLB == "Member")
		{
			string ichkbbmbpgm3 = this.ICHKBBMBPGM;
			string[] array5 = new string[0];
			array5[1] = "\nx";
			string[] array6 = ichkbbmbpgm3.Split(array5, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array6[0],
				ScriptID = new Guid(array6[0])
			}, false);
			QOHCEBMQKMB.QOQONHOOLNE.KMPBMIHNOQM();
			QLKJQPNKPBC.PDPCLOECLOF().QPFHQMFPNEQ(array6[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "Goto")
			{
				INFJMNPKNQF.CFGIOIGOIFQ().DQMOQINPHHP(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_Grain_Params1")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evs
				{
					Action = EvsAction.Request,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "d")
			{
				NOHEMGHONKK.QOQONHOOLNE.PKHNKJDMHBQ();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Corrupt preference file for ")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Ivs
				{
					Action = IvsAction.Randomize,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[1],
					Atk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Def = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[4],
					SpAtk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[8],
					SpDef = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[7],
					Speed = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[0]
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "BS")
			{
				INFJMNPKNQF.CFGIOIGOIFQ().HGFPKGEDEBE(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "3")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = false
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Hidden/Post FX/Screen Space Reflection")
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>().BMPDIPODNGP(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "][/pok] ")
			{
				MBGHQMKEFKO.QOQONHOOLNE.OKDQLINCJOM(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[")
			{
				if (INFJMNPKNQF.DOGEBLQHDHI().QIOKIQOBMMB >= 60u)
				{
					string text = this.PGBLHMLDGOJ[2].GetComponent<JIMBBPLINGI>().HJMJDJKOILH();
					if (text.Length >= 0 && text.Length <= 2)
					{
						NOHEMGHONKK.QBNCFLKLLKC().QHEDBICNJKN(text);
					}
					else
					{
						CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("Players: ", "http://www.yourwebsite.com/logo.png", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
					}
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("RGBA", "0", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Soul-Heart")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().CreateTab(this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Take 001")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().JoinChatChannel(this.PGBLHMLDGOJ[4].GetComponent<JIMBBPLINGI>().HJMJDJKOILH());
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "celebrate")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().LeaveChatChannel(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_FogSpeed")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "BuffIcon_Surf")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Friend
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq2, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_VelocityScale")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Guild
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "The hail stopped.")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "[green]")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Trade
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq5, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("_RcpAspect") != -1 && this.ICHKBBMBPGM.Length > 5)
		{
			string ichkbbmbpgm4 = this.ICHKBBMBPGM;
			string[] array7 = new string[0];
			array7[1] = "Protects the Pokémon from things like sand, hail, and powder.";
			string[] array8 = ichkbbmbpgm4.Split(array7, StringSplitOptions.RemoveEmptyEntries);
			if (array8[1].Length <= 1)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x001E6280 File Offset: 0x001E4480
	public void NFQQGEPQICF()
	{
		if (this.ICHKBBMBPGM != null && this.ICHKBBMBPGM.Contains("[-]\n\n"))
		{
			string g = this.ICHKBBMBPGM.Substring(5);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = "Rain Badge",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Empty Slot")
		{
			Request dcgclgqcgdq = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Guild
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Pokédex Caught:")
		{
			Request dcgclgqcgdq2 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.None
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq2, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "TCPManager")
		{
			Request dcgclgqcgdq3 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.None
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == " hours")
		{
			Request dcgclgqcgdq4 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Party
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq4, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "New Passwords do not match")
		{
			Request dcgclgqcgdq5 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.None
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq5, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.ICHKBBMBPGM.IndexOf(" EXP") != -1 && this.ICHKBBMBPGM.Length > 8)
		{
			string[] array = this.ICHKBBMBPGM.Split(new string[]
			{
				" Obtained "
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array[1].Length <= 0)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x00019C1B File Offset: 0x00017E1B
	public void Hold()
	{
		if (this.NKKMJICKKLB == "Hold or Use?")
		{
			INFJMNPKNQF.QOQONHOOLNE.HDGHLOGHHIK(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x001E64C4 File Offset: 0x001E46C4
	private void OBNDQJFDQEK()
	{
		if (this.HCKMEIPJNLK > 54f)
		{
			this.BCQCGFDQPDQ += UnityEngine.Time.deltaTime;
			int num = (int)(this.BCQCGFDQPDQ % 1292f);
			if ((float)num >= this.HCKMEIPJNLK)
			{
				this.EJOGQGIFLJC();
			}
			this.QHEJPNJNMCI[0].PIDLOFMIEFQ = this.NKKMJICKKLB + "New Passwords do not match" + (this.HCKMEIPJNLK - (float)num).ToString() + "defiant";
		}
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x00019C56 File Offset: 0x00017E56
	public void OGECDFDQLLI()
	{
		if (this.NKKMJICKKLB == "Blank")
		{
			INFJMNPKNQF.QOQONHOOLNE.DIMBOLLHNKC(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x001E6548 File Offset: 0x001E4748
	public void GHENGDEBJLH()
	{
		if (this.ICHKBBMBPGM != null && this.ICHKBBMBPGM.Contains("#,##0"))
		{
			string g = this.ICHKBBMBPGM.Substring(3);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "_1",
				ScriptID = new Guid(g)
			}, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Fishing Cooldown")
		{
			Request dcgclgqcgdq = new Request
			{
				Accepted = true,
				Sender = this.ICHKBBMBPGM,
				Type = (RequestType)6
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "[white]")
		{
			Request dcgclgqcgdq2 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = (RequestType)8
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq2, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Btn_TabHighlighted_Click")
		{
			Request dcgclgqcgdq3 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.None
			};
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq3, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "System")
		{
			Request dcgclgqcgdq4 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Party
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "bcam")
		{
			Request dcgclgqcgdq5 = new Request
			{
				Accepted = false,
				Sender = this.ICHKBBMBPGM,
				Type = RequestType.Friend
			};
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.ICHKBBMBPGM.IndexOf("Icon_Pokemon_Alive") != -1 && this.ICHKBBMBPGM.Length > 7)
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array = new string[0];
			array[1] = "'s perish count fell to 0.\r\n";
			string[] array2 = ichkbbmbpgm.Split(array, StringSplitOptions.RemoveEmptyEntries);
			if (array2[0].Length <= 0)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x00019C91 File Offset: 0x00017E91
	public void QEEDQBCGBHL()
	{
		if (this.NKKMJICKKLB == " has no Animation component")
		{
			INFJMNPKNQF.DOGEBLQHDHI().DIMBOLLHNKC(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x001E678C File Offset: 0x001E498C
	public void Ok()
	{
		if (this.ICHKBBMBPGM.Contains("Script:"))
		{
			string g = this.ICHKBBMBPGM.Substring(7);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = "0",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x001E67F8 File Offset: 0x001E49F8
	public void DCLICLNOMEQ()
	{
		if (this.ICHKBBMBPGM.Contains("item"))
		{
			string g = this.ICHKBBMBPGM.Substring(6);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = "Effect Spore",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "/")
		{
			string[] array = this.ICHKBBMBPGM.Split(new string[]
			{
				"PrimitiveFront"
			}, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array[1]),
				SpriteID = Convert.ToInt32(array[0])
			}, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "You are trapped and are unable to switch.")
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Upgrade
			{
				Type = (UpgradeType)8
			}, true);
			NOHEMGHONKK.QOQONHOOLNE.JGDDJEBQLJN.SetActive(false);
		}
		else if (this.NKKMJICKKLB == "Sticky Hold")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.None
			}, false);
			JJGLMJNELOK.BEKHPOHIPDE().BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = true;
			JJGLMJNELOK.KGOPJQOMMNC().BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		}
		else if (this.NKKMJICKKLB == "-combine")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.BJLGEDCPENQ().MGJPFKOCGGC("HideResponse");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Effect
				{
					Action = EffectAction.Cancel,
					UID = nbfcpoplomf.CBBBCEMLMLP
				}, false);
			}
		}
		else if (this.NKKMJICKKLB == "[-][/u]")
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array2 = new string[0];
			array2[1] = "Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_8_Light.mat";
			string[] array3 = ichkbbmbpgm.Split(array2, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Script
			{
				Response = array3[1],
				ScriptID = new Guid(array3[1])
			}, true);
			QOHCEBMQKMB.JLLBKOOQKGO().KMPBMIHNOQM();
		}
		else if (this.NKKMJICKKLB == "Active events: ")
		{
			string[] array4 = this.ICHKBBMBPGM.Split(new string[]
			{
				"Battery"
			}, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array4[1],
				ScriptID = new Guid(array4[1])
			}, true);
			QOHCEBMQKMB.JLLBKOOQKGO().FinishScript();
			QLKJQPNKPBC.KNOOOEMQOFL().FLMDGMNLQMN(array4[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "HidePanel")
			{
				INFJMNPKNQF.IPOKOKIJECO().IHOJLPELDDI(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "/[PD]")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evs
				{
					Action = EvsAction.Skill,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "powerherb")
			{
				NOHEMGHONKK.HGEKKNEPOHK().PKHNKJDMHBQ();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "FactoryTempTexture")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Ivs
				{
					Action = IvsAction.Randomize,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Atk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[1],
					Def = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[7],
					SpAtk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[7],
					SpDef = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[1],
					Speed = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[2]
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "berry_14")
			{
				INFJMNPKNQF.CFGIOIGOIFQ().QDIHIKCNPOD(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == " was cured of paralysis.\r\n")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = false
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "12:")
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>().ODJDNQIQMDH(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "HidePanel")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().KODDCDHNJMO(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Unlit/Transparent Colored")
			{
				if (INFJMNPKNQF.DOGEBLQHDHI().QIOKIQOBMMB >= 47u)
				{
					string text = this.PGBLHMLDGOJ[3].GetComponent<JIMBBPLINGI>().HJMJDJKOILH();
					if (text.Length >= 8 && text.Length <= -7)
					{
						NOHEMGHONKK.QOQONHOOLNE.HLQHMDJLGQL(text);
					}
					else
					{
						CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("_Downsample", " ", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
					}
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF(" switched stat changes with its target!\r\n", "_UserLut_Params", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "rkssystem")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().OKMGGQDMQNO(this.PGBLHMLDGOJ[2].GetComponent<JIMBBPLINGI>().HJMJDJKOILH());
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "-")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().JoinChatChannel(this.PGBLHMLDGOJ[7].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "'s health is sapped by Leech Seed!\r\n")
			{
				MBGHQMKEFKO.QOQONHOOLNE.LeaveChatChannel(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_DitheringTex")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Battle
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_EmissionColor")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Friend
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq2, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "F13")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Party
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "--idle")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Trade
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "blank")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = (RequestType)8
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("#,##0") != -1 && this.ICHKBBMBPGM.Length > 8)
		{
			string[] array5 = this.ICHKBBMBPGM.Split(new string[]
			{
				"You lost 1x "
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array5[1].Length <= 0)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x001E702C File Offset: 0x001E522C
	public void KGBBFDJGGPQ(CNCJKLNHQBH EJHIHINFCGL, string HIEFQEEDHGG, string NQFQGCGPHBE, string GQFFOBCKGKG, LPBPDPMJKNN.PJIJIFKBMBB DPQFDCNLLPC, KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO, int MOGLGJGFNDM = -1)
	{
		this.HCKMEIPJNLK = (float)MOGLGJGFNDM;
		this.PGBLHMLDGOJ[1].SetActive(false);
		this.PGBLHMLDGOJ[1].SetActive(true);
		this.PGBLHMLDGOJ[8].SetActive(false);
		this.PGBLHMLDGOJ[5].SetActive(false);
		this.PGBLHMLDGOJ[6].SetActive(true);
		this.PGBLHMLDGOJ[5].SetActive(false);
		this.POPHIHOHDJH.BBQFPBIIHCH();
		if (DPQFDCNLLPC == LPBPDPMJKNN.PJIJIFKBMBB.YesNo)
		{
			this.PGBLHMLDGOJ[1].SetActive(true);
			this.PGBLHMLDGOJ[0].SetActive(false);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)0)
		{
			this.PGBLHMLDGOJ[4].SetActive(false);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)5)
		{
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[0].SetActive(true);
			this.PGBLHMLDGOJ[7].SetActive(true);
		}
		else if (DPQFDCNLLPC == (LPBPDPMJKNN.PJIJIFKBMBB)8)
		{
			this.PGBLHMLDGOJ[6].SetActive(true);
			this.PGBLHMLDGOJ[2].SetActive(true);
			this.PGBLHMLDGOJ[0].SetActive(true);
		}
		if (DPQFDCNLLPC != LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel)
		{
			this.QHEJPNJNMCI[0].transform.localPosition += new Vector3(1020f, 1333f, 821f);
			this.QHEJPNJNMCI[1].DFKQMMIQDOO = 98;
		}
		NQFQGCGPHBE = KGQECFKLKOP.LGGPFIJQHOM(NQFQGCGPHBE);
		this.PDIBIIKFBDH = MKBCKPPCIQO;
		this.QHEJPNJNMCI[1].LKPOBCBOFIC(HIEFQEEDHGG);
		this.QHEJPNJNMCI[1].PIDLOFMIEFQ = NQFQGCGPHBE;
		this.NKKMJICKKLB = HIEFQEEDHGG;
		this.ICHKBBMBPGM = GQFFOBCKGKG;
		if (this.NKKMJICKKLB == "Open")
		{
			this.QHEJPNJNMCI[0].IQCIHQJCINE(2);
			this.PGBLHMLDGOJ[7].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Float;
		}
		else
		{
			this.QHEJPNJNMCI[1].MNNBBPGPNJF = 1;
			this.PGBLHMLDGOJ[1].GetComponent<JIMBBPLINGI>().GCLKNPHKJCC = JIMBBPLINGI.QNIJBQJFDEM.Alphanumeric;
		}
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x001E7228 File Offset: 0x001E5428
	public void KQNPNBNCDMJ()
	{
		if (this.ICHKBBMBPGM.Contains("!\r\n"))
		{
			string g = this.ICHKBBMBPGM.Substring(1);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = "MapCache",
				ScriptID = new Guid(g)
			}, false);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Invalid Username or Password..")
		{
			string ichkbbmbpgm = this.ICHKBBMBPGM;
			string[] array = new string[0];
			array[1] = "_1";
			string[] array2 = ichkbbmbpgm.Split(array, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Skin
			{
				Action = SkinAction.Buy,
				Type = (SkinType)Convert.ToInt32(array2[1]),
				SpriteID = Convert.ToInt32(array2[0])
			}, true);
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.NKKMJICKKLB == "Popup list needs a source object...")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.None
			}, false);
			NOHEMGHONKK.QOQONHOOLNE.JGDDJEBQLJN.SetActive(true);
		}
		else if (this.NKKMJICKKLB == "_")
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Upgrade
			{
				Type = UpgradeType.Pokebox
			}, false);
			JJGLMJNELOK.BEKHPOHIPDE().BMFCMLPMFHQ.GetComponent<BoxCollider>().enabled = false;
			JJGLMJNELOK.QOQONHOOLNE.BMFCMLPMFHQ.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
		else if (this.NKKMJICKKLB == "UI")
		{
			GNDQBCBDHKD.NBFCPOPLOMF nbfcpoplomf = GNDQBCBDHKD.GDDGJKOLGIQ().LJBHIMMHGLP("_DownsampledDepth");
			if (nbfcpoplomf != null)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Effect
				{
					Action = EffectAction.Cancel,
					UID = nbfcpoplomf.BEILHFKFLEG()
				}, false);
			}
		}
		else if (this.NKKMJICKKLB == "HideResponse")
		{
			string ichkbbmbpgm2 = this.ICHKBBMBPGM;
			string[] array3 = new string[1];
			array3[1] = "berry_10";
			string[] array4 = ichkbbmbpgm2.Split(array3, StringSplitOptions.RemoveEmptyEntries);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array4[0],
				ScriptID = new Guid(array4[0])
			}, false);
			QOHCEBMQKMB.QOQONHOOLNE.FOCOHPNMBMG();
		}
		else if (this.NKKMJICKKLB == "Queenly Majesty")
		{
			string ichkbbmbpgm3 = this.ICHKBBMBPGM;
			string[] array5 = new string[0];
			array5[0] = "[/U]";
			string[] array6 = ichkbbmbpgm3.Split(array5, StringSplitOptions.None);
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Script
			{
				Response = array6[0],
				ScriptID = new Guid(array6[0])
			}, false);
			QOHCEBMQKMB.QOQONHOOLNE.KMPBMIHNOQM();
			QLKJQPNKPBC.QOQONHOOLNE.KLEQQPMOHOM(array6[0]);
		}
		else
		{
			if (this.NKKMJICKKLB == "Battle Update: ")
			{
				INFJMNPKNQF.QOQONHOOLNE.OONOOFJNIHK(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "\nEvening")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evs
				{
					Action = (EvsAction)8,
					Pokemon = new Guid(this.ICHKBBMBPGM)
				}, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == ". ")
			{
				NOHEMGHONKK.HGEKKNEPOHK().PKHNKJDMHBQ();
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "General")
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Ivs
				{
					Action = IvsAction.RequestPrice,
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Hp = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[0],
					Atk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[1],
					Def = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[2],
					SpAtk = HFCMDEQKCKH.QOQONHOOLNE.HDCCPIMBMFE[1],
					SpDef = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[7],
					Speed = HFCMDEQKCKH.CFGIOIGOIFQ().HDCCPIMBMFE[5]
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "mudsport")
			{
				INFJMNPKNQF.FPQNIQELKMC().HGFPKGEDEBE(this.PDIBIIKFBDH, Convert.ToInt32(this.ICHKBBMBPGM));
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "_Female")
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new HoldItem
				{
					Pokemon = new Guid(this.ICHKBBMBPGM),
					Remove = true
				}, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "remember")
			{
				HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>().ODJDNQIQMDH(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "#,##0")
			{
				MBGHQMKEFKO.BBCBOIFQDBK().OGJDPEGDKHL(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Take 001")
			{
				if (INFJMNPKNQF.QOQONHOOLNE.QIOKIQOBMMB >= 113u)
				{
					string text = this.PGBLHMLDGOJ[6].GetComponent<JIMBBPLINGI>().HJMJDJKOILH();
					if (text.Length >= 4 && text.Length <= 82)
					{
						NOHEMGHONKK.QBNCFLKLLKC().HLQHMDJLGQL(text);
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("focussash", "When it enters a battle, the Pokémon can check an opposing Pokémon's held item.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, true);
					}
				}
				else
				{
					CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("HH:mm:ss", "WATER_EDGEBLEND_OFF", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
				}
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "\n[PG]")
			{
				MBGHQMKEFKO.QOQONHOOLNE.HJIEFQOGEKQ(this.PGBLHMLDGOJ[1].GetComponent<JIMBBPLINGI>().BGBMIEJJQKC);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "0")
			{
				MBGHQMKEFKO.QOQONHOOLNE.JoinChatChannel(this.PGBLHMLDGOJ[6].GetComponent<JIMBBPLINGI>().HJMJDJKOILH());
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "Open")
			{
				MBGHQMKEFKO.KGOPJQOMMNC().BJIDKDCIJLJ(this.ICHKBBMBPGM);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "blank")
			{
				Request dcgclgqcgdq = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = (RequestType)7
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "ability")
			{
				Request dcgclgqcgdq2 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(dcgclgqcgdq2, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "/")
			{
				Request dcgclgqcgdq3 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.Party
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq3, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "The Pokémon may pick up the item an opposing Pokémon used during a battle. It may pick up items outside of battle, too.")
			{
				Request dcgclgqcgdq4 = new Request
				{
					Accepted = true,
					Sender = this.ICHKBBMBPGM,
					Type = RequestType.None
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq4, false);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (this.NKKMJICKKLB == "More Likely Female Encounters")
			{
				Request dcgclgqcgdq5 = new Request
				{
					Accepted = false,
					Sender = this.ICHKBBMBPGM,
					Type = (RequestType)8
				};
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(dcgclgqcgdq5, true);
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
		}
		if (this.ICHKBBMBPGM.IndexOf("The Pokémon can sense an opposing Pokémon's dangerous moves.") != -1 && this.ICHKBBMBPGM.Length > 8)
		{
			string[] array7 = this.ICHKBBMBPGM.Split(new string[]
			{
				"physical"
			}, StringSplitOptions.None);
			if (array7[1].Length <= 0)
			{
			}
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x04000DC8 RID: 3528
	public string ICHKBBMBPGM;

	// Token: 0x04000DC9 RID: 3529
	public GameObject[] PGBLHMLDGOJ;

	// Token: 0x04000DCA RID: 3530
	public BKKHLBCLPJM[] QHEJPNJNMCI;

	// Token: 0x04000DCB RID: 3531
	private string NKKMJICKKLB;

	// Token: 0x04000DCC RID: 3532
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000DCD RID: 3533
	public KIQKEMNELKN POPHIHOHDJH;

	// Token: 0x04000DCE RID: 3534
	private KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH;

	// Token: 0x04000DCF RID: 3535
	private float HCKMEIPJNLK = -1f;

	// Token: 0x04000DD0 RID: 3536
	private float BCQCGFDQPDQ;

	// Token: 0x020001DE RID: 478
	public enum PJIJIFKBMBB
	{
		// Token: 0x04000DD2 RID: 3538
		Okay = 1,
		// Token: 0x04000DD3 RID: 3539
		YesNo,
		// Token: 0x04000DD4 RID: 3540
		Input,
		// Token: 0x04000DD5 RID: 3541
		HoldUseCancel
	}
}
