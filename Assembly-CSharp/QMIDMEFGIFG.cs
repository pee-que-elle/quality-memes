using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x0200020C RID: 524
public class QMIDMEFGIFG : MonoBehaviour
{
	// Token: 0x06004599 RID: 17817 RVA: 0x0001D72B File Offset: 0x0001B92B
	public void KFFMEGGKBFJ(bool BGBMIEJJQKC)
	{
		this.CFQOINIEIFE.gameObject.SetActive(BGBMIEJJQKC);
		this.ODIHBHENHNB.gameObject.SetActive(BGBMIEJJQKC);
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x0001D74F File Offset: 0x0001B94F
	public bool MHQHCEQCMOD()
	{
		return this.DJDCQIJGBEF.value;
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060045A9 RID: 17833 RVA: 0x0001D7BC File Offset: 0x0001B9BC
	// (set) Token: 0x0600459B RID: 17819 RVA: 0x0001D75C File Offset: 0x0001B95C
	public bool GJKHGMCHKCG
	{
		get
		{
			return this.DJDCQIJGBEF.GetComponent<Collider>().enabled;
		}
		set
		{
			this.DJDCQIJGBEF.GetComponent<Collider>().enabled = value;
		}
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x0001D76F File Offset: 0x0001B96F
	public bool CONFJFMCGGJ()
	{
		return this.KEQPEKGIDGE.gameObject.activeSelf;
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x0001D781 File Offset: 0x0001B981
	public void BCOMHOINLDI(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.value = BGBMIEJJQKC;
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x0021C670 File Offset: 0x0021A870
	public void OnAccept()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = LobbyActorState.Accept
		}, false);
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x0021C698 File Offset: 0x0021A898
	public void OnSay()
	{
		if (!string.IsNullOrEmpty(this.HMKQBMELQNF.BGBMIEJJQKC.Trim()))
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyMessage
			{
				Message = this.HMKQBMELQNF.BGBMIEJJQKC.Trim()
			}, false);
		}
		this.HMKQBMELQNF.BGBMIEJJQKC = string.Empty;
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x0001D78F File Offset: 0x0001B98F
	public void JBBFDJBKQGK()
	{
		this.NCBPFOKDDPG.CPLBKPNNHJG();
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x0001D781 File Offset: 0x0001B981
	public void JJOJFLHBMIQ(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.value = BGBMIEJJQKC;
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x0001D79C File Offset: 0x0001B99C
	public void NBOMFHNBEGJ(bool BGBMIEJJQKC)
	{
		this.KEFQJLEDMKM.value = BGBMIEJJQKC;
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x0021C670 File Offset: 0x0021A870
	public void GQEJIFNCBDI()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = LobbyActorState.Accept
		}, false);
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	public bool IPECIOOIOFB()
	{
		return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x0021C6F4 File Offset: 0x0021A8F4
	public void NFJPQEDFQBF()
	{
		if (!string.IsNullOrEmpty(this.CFQOINIEIFE.BGBMIEJJQKC.Trim()))
		{
			CKMLKNPNPQO.INJDHLQHFFD().IPDHHJDHCLP(this.CFQOINIEIFE.BGBMIEJJQKC);
		}
		this.CFQOINIEIFE.NCBFKNGMKPB(string.Empty);
		this.CFQOINIEIFE.GOIKCGNOEKP();
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x0001D7BC File Offset: 0x0001B9BC
	public bool QLKIGJNLQIG()
	{
		return this.DJDCQIJGBEF.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x0001D74F File Offset: 0x0001B94F
	public bool IOOCFKCQJGC()
	{
		return this.DJDCQIJGBEF.value;
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	public bool OIQFEFQQFIC()
	{
		return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x0001D7CE File Offset: 0x0001B9CE
	public bool QMIHJHLJMPF()
	{
		return this.KEFQJLEDMKM.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
	public void FGEDLPIDGFC(bool BGBMIEJJQKC)
	{
		this.BBMMEBQBIJI.NHCNOIOCFCO((!BGBMIEJJQKC) ? ((PBJKDKBOLHO.OKKDIIQGHDD)5) : PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.BBMMEBQBIJI.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	public bool IBQGLNIDIPB()
	{
		return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x0001D806 File Offset: 0x0001BA06
	public void MKIGNOHIDBM(bool BGBMIEJJQKC)
	{
		this.KEQPEKGIDGE.gameObject.SetActive(BGBMIEJJQKC);
		this.OEJFBFOPFPK.gameObject.SetActive(!BGBMIEJJQKC);
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x0021C748 File Offset: 0x0021A948
	public void KDJIKIGJHNM()
	{
		this.QQQKCCMJDQP(this.DJDCQIJGBEF.value);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbySettings
		{
			AdjustPokemons = this.OIFJGGKEOKD,
			Items = this.LCNHIFKGECQ(),
			Ranked = true
		}, false);
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x0001D75C File Offset: 0x0001B95C
	public void IPHKQIGPGIP(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x0001D781 File Offset: 0x0001B981
	public void HMGIGQJGLMN(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.value = BGBMIEJJQKC;
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x0001D7CE File Offset: 0x0001B9CE
	public bool MFIJMOQCMNI()
	{
		return this.KEFQJLEDMKM.GetComponent<Collider>().enabled;
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060045F2 RID: 17906 RVA: 0x0001D929 File Offset: 0x0001BB29
	// (set) Token: 0x060045B2 RID: 17842 RVA: 0x0001D82D File Offset: 0x0001BA2D
	public bool MDPDFPGFCON
	{
		get
		{
			return this.BBMMEBQBIJI.GetComponent<Collider>().enabled;
		}
		set
		{
			this.BBMMEBQBIJI.NHCNOIOCFCO((!value) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.BBMMEBQBIJI.GetComponent<Collider>().enabled = value;
		}
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x0001D853 File Offset: 0x0001BA53
	public void DPKPGOIOJQK()
	{
		this.NCBPFOKDDPG.BPFQEKCPJDI();
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x0001D74F File Offset: 0x0001B94F
	public bool NICMCCPQBOM()
	{
		return this.DJDCQIJGBEF.value;
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x0001D860 File Offset: 0x0001BA60
	public void NOIILDLEFQD(bool BGBMIEJJQKC)
	{
		this.HQDDFHHGLCO.NHCNOIOCFCO((!BGBMIEJJQKC) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.HQDDFHHGLCO.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x0021C798 File Offset: 0x0021A998
	public void JHQPQFQKBMO()
	{
		if (!string.IsNullOrEmpty(this.CFQOINIEIFE.BGBMIEJJQKC.Trim()))
		{
			CKMLKNPNPQO.INJDHLQHFFD().GGCEBKIKQKI(this.CFQOINIEIFE.BGBMIEJJQKC);
		}
		this.CFQOINIEIFE.BGBMIEJJQKC = string.Empty;
		this.CFQOINIEIFE.POPMOIOELBB();
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x0001D781 File Offset: 0x0001B981
	public void QQQKCCMJDQP(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.value = BGBMIEJJQKC;
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060045F0 RID: 17904 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
	// (set) Token: 0x060045B8 RID: 17848 RVA: 0x0001D79C File Offset: 0x0001B99C
	public bool OIFJGGKEOKD
	{
		get
		{
			return this.KEFQJLEDMKM.value;
		}
		set
		{
			this.KEFQJLEDMKM.value = value;
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060045B9 RID: 17849 RVA: 0x0001D886 File Offset: 0x0001BA86
	// (set) Token: 0x060045E6 RID: 17894 RVA: 0x0001DA5B File Offset: 0x0001BC5B
	public bool GHNCLCGPOFC
	{
		get
		{
			return this.HQDDFHHGLCO.GetComponent<Collider>().enabled;
		}
		set
		{
			this.HQDDFHHGLCO.NHCNOIOCFCO((!value) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.HQDDFHHGLCO.GetComponent<Collider>().enabled = value;
		}
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x0021C7EC File Offset: 0x0021A9EC
	public void IPDFFNCQKME(int NNBJIJCQGPO, int QQGFMKOQHGK, int NGQJLIEBFOM, int MJGGCLOGKFL)
	{
		string str = QQGFMKOQHGK.ToString() + "[ATK]" + 8.ToString();
		string str2 = NGQJLIEBFOM.ToString() + "[FF0000]" + 7.ToString();
		string str3 = MJGGCLOGKFL.ToString();
		if (QQGFMKOQHGK < 1)
		{
			str = " intends to flip up a mat and block incoming attacks!\r\n" + str + " and ";
		}
		if (NGQJLIEBFOM < 1 || NGQJLIEBFOM > 0)
		{
			str2 = "berry_12" + str2 + "]";
		}
		if (NNBJIJCQGPO == 0)
		{
			this.GFGBKGLBEGH.LKPOBCBOFIC("iceburn" + str);
			this.LEIDBOIHGKN.LKPOBCBOFIC("The Pokémon is covered with a water veil, which prevents the Pokémon from getting a burn." + str2);
			this.MQBFHNOKLQC.PIDLOFMIEFQ = "wormadam" + str3;
		}
		else
		{
			this.ECPHPIJGKCE.LKPOBCBOFIC("Take 001" + str);
			this.EQDHHQBOKCH.LKPOBCBOFIC("item" + str2);
			this.IHIILDBPQFI.LKPOBCBOFIC("Item: " + str3);
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060045E9 RID: 17897 RVA: 0x0001D7CE File Offset: 0x0001B9CE
	// (set) Token: 0x060045BB RID: 17851 RVA: 0x0001D898 File Offset: 0x0001BA98
	public bool LEOHQPKNFPK
	{
		get
		{
			return this.KEFQJLEDMKM.GetComponent<Collider>().enabled;
		}
		set
		{
			this.KEFQJLEDMKM.GetComponent<Collider>().enabled = value;
		}
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x0001D78F File Offset: 0x0001B98F
	public void KFBOHQPLBJH()
	{
		this.NCBPFOKDDPG.CPLBKPNNHJG();
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x0001D806 File Offset: 0x0001BA06
	public void EGNDKJNFLKN(bool BGBMIEJJQKC)
	{
		this.KEQPEKGIDGE.gameObject.SetActive(BGBMIEJJQKC);
		this.OEJFBFOPFPK.gameObject.SetActive(!BGBMIEJJQKC);
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x0001D8AB File Offset: 0x0001BAAB
	public void OIMLKIPOGQK()
	{
		this.GHNCLCGPOFC = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbySwitch(), false);
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x0001D806 File Offset: 0x0001BA06
	public void KMIGBCHPGOB(bool BGBMIEJJQKC)
	{
		this.KEQPEKGIDGE.gameObject.SetActive(BGBMIEJJQKC);
		this.OEJFBFOPFPK.gameObject.SetActive(!BGBMIEJJQKC);
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
	public bool NFLPOQDJDNQ()
	{
		return this.KEFQJLEDMKM.value;
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x0021C910 File Offset: 0x0021AB10
	public void HOPFFIIJPOI()
	{
		if (!string.IsNullOrEmpty(this.HMKQBMELQNF.BGBMIEJJQKC.Trim()))
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyMessage
			{
				Message = this.HMKQBMELQNF.HJMJDJKOILH().Trim()
			}, true);
		}
		this.HMKQBMELQNF.BGBMIEJJQKC = string.Empty;
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060045CA RID: 17866 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	// (set) Token: 0x060045C2 RID: 17858 RVA: 0x0001D8D1 File Offset: 0x0001BAD1
	public bool BJMDJIQQDGM
	{
		get
		{
			return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
		}
		set
		{
			this.OEJFBFOPFPK.NHCNOIOCFCO((!value) ? PBJKDKBOLHO.OKKDIIQGHDD.Disabled : PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.OEJFBFOPFPK.GetComponent<Collider>().enabled = value;
		}
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x0001D8F7 File Offset: 0x0001BAF7
	public void BMEHFCOHFOI()
	{
		this.NOIILDLEFQD(true);
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbySwitch(), false);
	}

	// Token: 0x060045C4 RID: 17860 RVA: 0x0001D910 File Offset: 0x0001BB10
	public void JEHCCEEBQMN()
	{
		this.NOIILDLEFQD(true);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbySwitch(), false);
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x0001D929 File Offset: 0x0001BB29
	public bool KQPPGCMKGNB()
	{
		return this.BBMMEBQBIJI.GetComponent<Collider>().enabled;
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x060045C7 RID: 17863 RVA: 0x0001D74F File Offset: 0x0001B94F
	// (set) Token: 0x060045C6 RID: 17862 RVA: 0x0001D781 File Offset: 0x0001B981
	public bool HJCIIFCMIME
	{
		get
		{
			return this.DJDCQIJGBEF.value;
		}
		set
		{
			this.DJDCQIJGBEF.value = value;
		}
	}

	// Token: 0x060045C8 RID: 17864 RVA: 0x0001D75C File Offset: 0x0001B95C
	public void PMKIMHMMDPD(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045C9 RID: 17865 RVA: 0x0021C96C File Offset: 0x0021AB6C
	public void OnInvite()
	{
		if (!string.IsNullOrEmpty(this.CFQOINIEIFE.BGBMIEJJQKC.Trim()))
		{
			CKMLKNPNPQO.QOQONHOOLNE.BattleRequest(this.CFQOINIEIFE.BGBMIEJJQKC);
		}
		this.CFQOINIEIFE.BGBMIEJJQKC = string.Empty;
		this.CFQOINIEIFE.GOIKCGNOEKP();
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x0021C9C0 File Offset: 0x0021ABC0
	public void OnEqualLevels()
	{
		this.OIFJGGKEOKD = this.KEFQJLEDMKM.value;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbySettings
		{
			AdjustPokemons = this.OIFJGGKEOKD,
			Items = this.HJCIIFCMIME,
			Ranked = false
		}, false);
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x0021CA10 File Offset: 0x0021AC10
	public void GHOEKJKNOCH(int NNBJIJCQGPO, int QQGFMKOQHGK, int NGQJLIEBFOM, int MJGGCLOGKFL)
	{
		string str = QQGFMKOQHGK.ToString() + "/" + 4.ToString();
		string str2 = NGQJLIEBFOM.ToString() + "/" + 3.ToString();
		string str3 = MJGGCLOGKFL.ToString();
		if (QQGFMKOQHGK < 1)
		{
			str = "[FF6600]" + str + "[-]";
		}
		if (NGQJLIEBFOM < 1 || NGQJLIEBFOM > 3)
		{
			str2 = "[FF6600]" + str2 + "[-]";
		}
		if (NNBJIJCQGPO == 0)
		{
			this.GFGBKGLBEGH.PIDLOFMIEFQ = "Players: " + str;
			this.LEIDBOIHGKN.PIDLOFMIEFQ = "Active: " + str2;
			this.MQBFHNOKLQC.PIDLOFMIEFQ = "Max: " + str3;
		}
		else
		{
			this.ECPHPIJGKCE.PIDLOFMIEFQ = "Players: " + str;
			this.EQDHHQBOKCH.PIDLOFMIEFQ = "Active: " + str2;
			this.IHIILDBPQFI.PIDLOFMIEFQ = "Max: " + str3;
		}
	}

	// Token: 0x060045CD RID: 17869 RVA: 0x0001D72B File Offset: 0x0001B92B
	public void EBIEHFGJGLH(bool BGBMIEJJQKC)
	{
		this.CFQOINIEIFE.gameObject.SetActive(BGBMIEJJQKC);
		this.ODIHBHENHNB.gameObject.SetActive(BGBMIEJJQKC);
	}

	// Token: 0x060045CF RID: 17871 RVA: 0x0001D74F File Offset: 0x0001B94F
	public bool LCNHIFKGECQ()
	{
		return this.DJDCQIJGBEF.value;
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x0001D95B File Offset: 0x0001BB5B
	public bool JQIHOLMFLJO()
	{
		return this.CFQOINIEIFE.gameObject.activeSelf;
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x0001D96D File Offset: 0x0001BB6D
	public void LGOPHMGFEBE(bool BGBMIEJJQKC)
	{
		this.BBMMEBQBIJI.NHCNOIOCFCO((!BGBMIEJJQKC) ? PBJKDKBOLHO.OKKDIIQGHDD.Hover : PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.BBMMEBQBIJI.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x0001D7BC File Offset: 0x0001B9BC
	public bool IJLMPFNGDCJ()
	{
		return this.DJDCQIJGBEF.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	public bool KEFLPKOGJJD()
	{
		return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x0021CB34 File Offset: 0x0021AD34
	public void NDGOHJOFIEG()
	{
		if (!string.IsNullOrEmpty(this.CFQOINIEIFE.HJMJDJKOILH().Trim()))
		{
			CKMLKNPNPQO.QOQONHOOLNE.IPDHHJDHCLP(this.CFQOINIEIFE.HJMJDJKOILH());
		}
		this.CFQOINIEIFE.NCBFKNGMKPB(string.Empty);
		this.CFQOINIEIFE.GOIKCGNOEKP();
	}

	// Token: 0x060045D5 RID: 17877 RVA: 0x0021A670 File Offset: 0x00218870
	public void BEHGONHIGBQ()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyAccept
		{
			State = LobbyActorState.Idle
		}, false);
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x0001D993 File Offset: 0x0001BB93
	public void FOOOENOGFMD(bool BGBMIEJJQKC)
	{
		this.OEJFBFOPFPK.NHCNOIOCFCO((!BGBMIEJJQKC) ? PBJKDKBOLHO.OKKDIIQGHDD.Hover : PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.OEJFBFOPFPK.GetComponent<Collider>().enabled = BGBMIEJJQKC;
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x0021CB88 File Offset: 0x0021AD88
	public void QDDQDOIQLJH()
	{
		if (!string.IsNullOrEmpty(this.HMKQBMELQNF.BGBMIEJJQKC.Trim()))
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyMessage
			{
				Message = this.HMKQBMELQNF.BGBMIEJJQKC.Trim()
			}, false);
		}
		this.HMKQBMELQNF.NCBFKNGMKPB(string.Empty);
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x0021CBE4 File Offset: 0x0021ADE4
	public void OnItemAllowed()
	{
		this.HJCIIFCMIME = this.DJDCQIJGBEF.value;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbySettings
		{
			AdjustPokemons = this.OIFJGGKEOKD,
			Items = this.HJCIIFCMIME,
			Ranked = false
		}, false);
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x0001D72B File Offset: 0x0001B92B
	public void KDFDCIIOMHN(bool BGBMIEJJQKC)
	{
		this.CFQOINIEIFE.gameObject.SetActive(BGBMIEJJQKC);
		this.ODIHBHENHNB.gameObject.SetActive(BGBMIEJJQKC);
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x0001D9B9 File Offset: 0x0001BBB9
	public void FKHKQIFPJFL()
	{
		this.FGEDLPIDGFC(false);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyLeave(), false);
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x0021CC34 File Offset: 0x0021AE34
	public void OnStart()
	{
		if (BDLNNJFQOQH.QOQONHOOLNE.FFCCFEKPFMB.Count > 0 && BDLNNJFQOQH.QOQONHOOLNE.KMGCDOHKBGD.Count > 0)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
			{
				State = LobbyActorState.Accept
			}, false);
			return;
		}
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x0001D929 File Offset: 0x0001BB29
	public bool DMPMPKNQEPK()
	{
		return this.BBMMEBQBIJI.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x0021A670 File Offset: 0x00218870
	public void JKNQEILLKCQ()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyAccept
		{
			State = LobbyActorState.Idle
		}, false);
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x0001D7BC File Offset: 0x0001B9BC
	public bool CCEFHPNQDOP()
	{
		return this.DJDCQIJGBEF.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x0001D9D2 File Offset: 0x0001BBD2
	public void LHCQOMHJJLB()
	{
		this.NOIILDLEFQD(false);
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbySwitch(), true);
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x0001D7AA File Offset: 0x0001B9AA
	public bool OICJLCFBHED()
	{
		return this.OEJFBFOPFPK.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045E1 RID: 17889 RVA: 0x0021CC80 File Offset: 0x0021AE80
	public void JCBNCHDFPDB(int NNBJIJCQGPO, int QQGFMKOQHGK, int NGQJLIEBFOM, int MJGGCLOGKFL)
	{
		string str = QQGFMKOQHGK.ToString() + " for [PD]" + 4.ToString();
		string str2 = NGQJLIEBFOM.ToString() + "/01_" + 7.ToString();
		string str3 = MJGGCLOGKFL.ToString();
		if (QQGFMKOQHGK < 0)
		{
			str = "Plus" + str + "Player/Hair";
		}
		if (NGQJLIEBFOM < 1 || NGQJLIEBFOM > 7)
		{
			str2 = "item" + str2 + "aquaring";
		}
		if (NNBJIJCQGPO == 0)
		{
			this.GFGBKGLBEGH.PIDLOFMIEFQ = "Guild Request" + str;
			this.LEIDBOIHGKN.LKPOBCBOFIC("no arguments" + str2);
			this.MQBFHNOKLQC.PIDLOFMIEFQ = "_RayStepSize" + str3;
		}
		else
		{
			this.ECPHPIJGKCE.PIDLOFMIEFQ = "/01_" + str;
			this.EQDHHQBOKCH.PIDLOFMIEFQ = "BuffIcon_Surf" + str2;
			this.IHIILDBPQFI.PIDLOFMIEFQ = "The sunlight turned extremely harsh!" + str3;
		}
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x0001D9EB File Offset: 0x0001BBEB
	public void MIDPIFHNNDK(string CGHQEHCBQHB, string NQFQGCGPHBE)
	{
		if (!string.IsNullOrEmpty(CGHQEHCBQHB))
		{
			NQFQGCGPHBE = CGHQEHCBQHB + ": " + NQFQGCGPHBE;
		}
		else
		{
			NQFQGCGPHBE = "[FFFF00]" + NQFQGCGPHBE + "[-]";
		}
		this.NCBPFOKDDPG.LHQECHHMOGD(NQFQGCGPHBE);
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060045ED RID: 17901 RVA: 0x0001D76F File Offset: 0x0001B96F
	// (set) Token: 0x060045E3 RID: 17891 RVA: 0x0001D806 File Offset: 0x0001BA06
	public bool OKJQNGQHIHJ
	{
		get
		{
			return this.KEQPEKGIDGE.gameObject.activeSelf;
		}
		set
		{
			this.KEQPEKGIDGE.gameObject.SetActive(value);
			this.OEJFBFOPFPK.gameObject.SetActive(!value);
		}
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x0021CDA4 File Offset: 0x0021AFA4
	public void HGHGKBCIOOQ()
	{
		if (!string.IsNullOrEmpty(this.CFQOINIEIFE.HJMJDJKOILH().Trim()))
		{
			CKMLKNPNPQO.QOQONHOOLNE.CLPBNMQCGDE(this.CFQOINIEIFE.BGBMIEJJQKC);
		}
		this.CFQOINIEIFE.NCBFKNGMKPB(string.Empty);
		this.CFQOINIEIFE.GOIKCGNOEKP();
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x0001DA23 File Offset: 0x0001BC23
	public void COOFOFQCBLQ(string CGHQEHCBQHB, string NQFQGCGPHBE)
	{
		if (!string.IsNullOrEmpty(CGHQEHCBQHB))
		{
			NQFQGCGPHBE = CGHQEHCBQHB + "Johto" + NQFQGCGPHBE;
		}
		else
		{
			NQFQGCGPHBE = "_Texture0" + NQFQGCGPHBE + "\r\nHP";
		}
		this.NCBPFOKDDPG.LHQECHHMOGD(NQFQGCGPHBE);
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x0001D7BC File Offset: 0x0001B9BC
	public bool BLIJOJDLPNL()
	{
		return this.DJDCQIJGBEF.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x0021CDF8 File Offset: 0x0021AFF8
	public void MPDQKKBQJCF()
	{
		if (!string.IsNullOrEmpty(this.HMKQBMELQNF.HJMJDJKOILH().Trim()))
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyMessage
			{
				Message = this.HMKQBMELQNF.HJMJDJKOILH().Trim()
			}, true);
		}
		this.HMKQBMELQNF.BGBMIEJJQKC = string.Empty;
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060045F6 RID: 17910 RVA: 0x0001D95B File Offset: 0x0001BB5B
	// (set) Token: 0x060045EA RID: 17898 RVA: 0x0001D72B File Offset: 0x0001B92B
	public bool FDJJCDOGQLB
	{
		get
		{
			return this.CFQOINIEIFE.gameObject.activeSelf;
		}
		set
		{
			this.CFQOINIEIFE.gameObject.SetActive(value);
			this.ODIHBHENHNB.gameObject.SetActive(value);
		}
	}

	// Token: 0x060045EB RID: 17899 RVA: 0x0001DA81 File Offset: 0x0001BC81
	public void OnLeave()
	{
		this.MDPDFPGFCON = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyLeave(), false);
	}

	// Token: 0x060045EC RID: 17900 RVA: 0x0021CE54 File Offset: 0x0021B054
	public void DJGNNJIHEGO(int NNBJIJCQGPO, int QQGFMKOQHGK, int NGQJLIEBFOM, int MJGGCLOGKFL)
	{
		string str = QQGFMKOQHGK.ToString() + "1" + 6.ToString();
		string str2 = NGQJLIEBFOM.ToString() + "Repeater" + 7.ToString();
		string str3 = MJGGCLOGKFL.ToString();
		if (QQGFMKOQHGK < 0)
		{
			str = "BuffIcon_SteelIncrease" + str + "weakarmor";
		}
		if (NGQJLIEBFOM < 1 || NGQJLIEBFOM > 7)
		{
			str2 = "[FF9900]" + str2 + "Vertical";
		}
		if (NNBJIJCQGPO == 0)
		{
			this.GFGBKGLBEGH.PIDLOFMIEFQ = "4" + str;
			this.LEIDBOIHGKN.LKPOBCBOFIC("MSGBOX - " + str2);
			this.MQBFHNOKLQC.PIDLOFMIEFQ = "HidePanel" + str3;
		}
		else
		{
			this.ECPHPIJGKCE.LKPOBCBOFIC("Reset IVs" + str);
			this.EQDHHQBOKCH.LKPOBCBOFIC("[ff6666]" + str2);
			this.IHIILDBPQFI.LKPOBCBOFIC("Base Power: " + str3);
		}
	}

	// Token: 0x060045EE RID: 17902 RVA: 0x0001D8AB File Offset: 0x0001BAAB
	public void OnSwitchTeam()
	{
		this.GHNCLCGPOFC = false;
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbySwitch(), false);
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x0001D74F File Offset: 0x0001B94F
	public bool CLFILIODDJH()
	{
		return this.DJDCQIJGBEF.value;
	}

	// Token: 0x060045F1 RID: 17905 RVA: 0x0001D886 File Offset: 0x0001BA86
	public bool JLQNEBMFNGN()
	{
		return this.HQDDFHHGLCO.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045F3 RID: 17907 RVA: 0x0001D929 File Offset: 0x0001BB29
	public bool KNNCPOKKBIJ()
	{
		return this.BBMMEBQBIJI.GetComponent<Collider>().enabled;
	}

	// Token: 0x060045F4 RID: 17908 RVA: 0x0001D781 File Offset: 0x0001B981
	public void LCHBMFOIOHD(bool BGBMIEJJQKC)
	{
		this.DJDCQIJGBEF.value = BGBMIEJJQKC;
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x0001D79C File Offset: 0x0001B99C
	public void OHPQDLJIPKE(bool BGBMIEJJQKC)
	{
		this.KEFQJLEDMKM.value = BGBMIEJJQKC;
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x0001D78F File Offset: 0x0001B98F
	public void JEMIDEHFLMI()
	{
		this.NCBPFOKDDPG.CPLBKPNNHJG();
	}

	// Token: 0x04000EDF RID: 3807
	public BMLIGLPMMLG NCBPFOKDDPG;

	// Token: 0x04000EE0 RID: 3808
	public JIMBBPLINGI HMKQBMELQNF;

	// Token: 0x04000EE1 RID: 3809
	public CFDMNELIJLO OEJFBFOPFPK;

	// Token: 0x04000EE2 RID: 3810
	public CFDMNELIJLO KEQPEKGIDGE;

	// Token: 0x04000EE3 RID: 3811
	public CFDMNELIJLO BBMMEBQBIJI;

	// Token: 0x04000EE4 RID: 3812
	public CFDMNELIJLO ODIHBHENHNB;

	// Token: 0x04000EE5 RID: 3813
	public JIMBBPLINGI CFQOINIEIFE;

	// Token: 0x04000EE6 RID: 3814
	public UIToggle KEFQJLEDMKM;

	// Token: 0x04000EE7 RID: 3815
	public UIToggle DJDCQIJGBEF;

	// Token: 0x04000EE8 RID: 3816
	public CFDMNELIJLO HQDDFHHGLCO;

	// Token: 0x04000EE9 RID: 3817
	public BKKHLBCLPJM GFGBKGLBEGH;

	// Token: 0x04000EEA RID: 3818
	public BKKHLBCLPJM LEIDBOIHGKN;

	// Token: 0x04000EEB RID: 3819
	public BKKHLBCLPJM MQBFHNOKLQC;

	// Token: 0x04000EEC RID: 3820
	public BKKHLBCLPJM ECPHPIJGKCE;

	// Token: 0x04000EED RID: 3821
	public BKKHLBCLPJM EQDHHQBOKCH;

	// Token: 0x04000EEE RID: 3822
	public BKKHLBCLPJM IHIILDBPQFI;

	// Token: 0x04000EEF RID: 3823
	public DPFCQGKGQLL[] BPBJJMINKOB = new DPFCQGKGQLL[4];

	// Token: 0x04000EF0 RID: 3824
	public DPFCQGKGQLL[] FDMDBIIIEFM = new DPFCQGKGQLL[4];
}
