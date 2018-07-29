using System;
using PSXAPI.Request;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200020B RID: 523
public class DPFCQGKGQLL : MonoBehaviour
{
	// Token: 0x0600455D RID: 17757 RVA: 0x0021C000 File Offset: 0x0021A200
	public int EHBJPMEBCIK()
	{
		int result = 1;
		if (this.IGMHDFHHDJO.DMBBLJCLCEJ().Contains("[common]"))
		{
			string text = this.IGMHDFHHDJO.HIOCELIDJII();
			char[] array = new char[0];
			array[0] = (char)-99;
			result = int.Parse(text.Split(array)[1]);
		}
		return result;
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x0600455E RID: 17758 RVA: 0x0001D447 File Offset: 0x0001B647
	// (set) Token: 0x0600455F RID: 17759 RVA: 0x0001D459 File Offset: 0x0001B659
	public int LKNEHDIOMDJ
	{
		get
		{
			return int.Parse(this.JIMNLQCGNFP.PIDLOFMIEFQ);
		}
		set
		{
			this.JIMNLQCGNFP.PIDLOFMIEFQ = ((value >= 1) ? value.ToString() : "-");
		}
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x0021C04C File Offset: 0x0021A24C
	public void EOEFDQHNLJK(float BGBMIEJJQKC)
	{
		this.DIIHJCJOKMP = BGBMIEJJQKC;
		foreach (ENFMCDNLEQQ enfmcdnleqq in base.GetComponentsInChildren<ENFMCDNLEQQ>())
		{
			enfmcdnleqq.DIIHJCJOKMP = BGBMIEJJQKC;
		}
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x0001D47E File Offset: 0x0001B67E
	public void GOQPBFNDGDG(bool BGBMIEJJQKC)
	{
		this.GMBHNPCOBGO = BGBMIEJJQKC;
		this.DLFHMPOPNMN.CEGFBBHMKOE = ((!BGBMIEJJQKC) ? Color.white : Color.green);
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x0001D4A1 File Offset: 0x0001B6A1
	public void HJPGEKMCHBB(bool BGBMIEJJQKC)
	{
		this.GMBHNPCOBGO = BGBMIEJJQKC;
		this.DLFHMPOPNMN.NONQDHBCIIN((!BGBMIEJJQKC) ? Color.white : Color.green);
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x0021C080 File Offset: 0x0021A280
	public void BFHDCFICJNH(ActorType BGBMIEJJQKC)
	{
		this.DPQFDCNLLPC = BGBMIEJJQKC;
		switch (this.DPQFDCNLLPC)
		{
		case ActorType.Leader:
			this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[0];
			this.NBKCBIMINHF.LKPOBCBOFIC("mdata");
			this.NBKCBIMINHF.NONQDHBCIIN(Color.yellow);
			break;
		case ActorType.User:
			this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[0];
			this.NBKCBIMINHF.PIDLOFMIEFQ = "BuffIcon_SandstormEncounterDecreased";
			this.NBKCBIMINHF.NONQDHBCIIN(Color.cyan);
			break;
		case ActorType.NPC:
			this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[0];
			this.NBKCBIMINHF.PIDLOFMIEFQ = " (";
			this.NBKCBIMINHF.CEGFBBHMKOE = Color.green;
			break;
		case ActorType.Inactive:
			this.MCPNNHMOFQH.NONQDHBCIIN(this.LPEGECBMQKQ[3]);
			this.NBKCBIMINHF.LKPOBCBOFIC("1");
			this.NBKCBIMINHF.NONQDHBCIIN(Color.white);
			break;
		case ActorType.Offline:
			this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[1];
			this.NBKCBIMINHF.PIDLOFMIEFQ = "Internal Curves Texture";
			this.NBKCBIMINHF.NONQDHBCIIN(Color.red);
			break;
		}
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
	public bool QGOQOJLCGJF()
	{
		return this.CLBKQBFMGEJ;
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x0001D4CC File Offset: 0x0001B6CC
	private void OEFEKHJBGPN()
	{
		if (this.NIPQDJHKPOQ)
		{
			this.EOEFDQHNLJK(1988f + Mathf.PingPong(UnityEngine.Time.time * 1122f, 30f));
		}
	}

	// Token: 0x06004566 RID: 17766 RVA: 0x0001D4F7 File Offset: 0x0001B6F7
	public void HIPNGHHJJFB(bool BGBMIEJJQKC)
	{
		this.NIPQDJHKPOQ = BGBMIEJJQKC;
		this.EOEFDQHNLJK(1465f);
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x0001D50B File Offset: 0x0001B70B
	private void FHFMKHDMDDI()
	{
		if (this.NIPQDJHKPOQ)
		{
			this.DQPHMIQGPBL = 762f + Mathf.PingPong(UnityEngine.Time.time * 1304f, 1669f);
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06004568 RID: 17768 RVA: 0x0001D536 File Offset: 0x0001B736
	// (set) Token: 0x0600458D RID: 17805 RVA: 0x0021C04C File Offset: 0x0021A24C
	public float DQPHMIQGPBL
	{
		get
		{
			return this.DIIHJCJOKMP;
		}
		set
		{
			this.DIIHJCJOKMP = value;
			foreach (ENFMCDNLEQQ enfmcdnleqq in base.GetComponentsInChildren<ENFMCDNLEQQ>())
			{
				enfmcdnleqq.DIIHJCJOKMP = value;
			}
		}
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x0001D536 File Offset: 0x0001B736
	public float FMEHCODBMKB()
	{
		return this.DIIHJCJOKMP;
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x0600456A RID: 17770 RVA: 0x0021C1F8 File Offset: 0x0021A3F8
	public int NKJQHJFNQJM
	{
		get
		{
			int result = 0;
			if (this.QIGJMOIHFIP.BGBMIEJJQKC != "Spectator" && this.QIGJMOIHFIP.BGBMIEJJQKC != "Inactive")
			{
				result = int.Parse(this.QIGJMOIHFIP.BGBMIEJJQKC.Split(new char[]
				{
					' '
				})[1]);
			}
			return result;
		}
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x0021C25C File Offset: 0x0021A45C
	private void EOFDHBQMHGF(int MJGGCLOGKFL, int NGQJLIEBFOM)
	{
		for (int i = 0; i < 6; i++)
		{
			if (MJGGCLOGKFL <= i)
			{
				this.OCLPCGQBNPK[i].KCLBMPFIPNQ = "Icon_Pokemon_Empty";
			}
			else if (NGQJLIEBFOM <= i)
			{
				this.OCLPCGQBNPK[i].KCLBMPFIPNQ = "Icon_Pokemon_Dead";
			}
			else
			{
				this.OCLPCGQBNPK[i].KCLBMPFIPNQ = "Icon_Pokemon_Alive";
			}
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x0600456E RID: 17774 RVA: 0x0001D576 File Offset: 0x0001B776
	// (set) Token: 0x0600456C RID: 17772 RVA: 0x0001D53E File Offset: 0x0001B73E
	public bool PQLDPGCIFHQ
	{
		get
		{
			return this.QIGJMOIHFIP.enabled;
		}
		set
		{
			this.QIGJMOIHFIP.enabled = value;
			this.EBDKLQHFENC.enabled = value;
			if (value)
			{
				this.QIGJMOIHFIP.LJOIIDQEJCC();
			}
			this.QIGJMOIHFIP.GetComponent<PLQFPBQEPJD>().Update();
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x0600456D RID: 17773 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
	// (set) Token: 0x0600456F RID: 17775 RVA: 0x0001D583 File Offset: 0x0001B783
	public bool BPCNHCMEJHP
	{
		get
		{
			return this.CLBKQBFMGEJ;
		}
		set
		{
			this.CLBKQBFMGEJ = value;
		}
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x0001D536 File Offset: 0x0001B736
	public float FBJGJOMDNKL()
	{
		return this.DIIHJCJOKMP;
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06004571 RID: 17777 RVA: 0x0021C2B8 File Offset: 0x0021A4B8
	public int JEBDNHCCHMQ
	{
		get
		{
			int result = 0;
			if (this.IGMHDFHHDJO.BGBMIEJJQKC.Contains("Max:"))
			{
				result = int.Parse(this.IGMHDFHHDJO.BGBMIEJJQKC.Split(new char[]
				{
					' '
				})[1]);
			}
			return result;
		}
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x0001D58C File Offset: 0x0001B78C
	public void ILPIILBPLPM(string BGBMIEJJQKC)
	{
		this.DLFHMPOPNMN.LKPOBCBOFIC(BGBMIEJJQKC);
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06004573 RID: 17779 RVA: 0x0001D59A File Offset: 0x0001B79A
	// (set) Token: 0x0600457A RID: 17786 RVA: 0x0001D5F9 File Offset: 0x0001B7F9
	public int BHFJIIGGPEQ
	{
		get
		{
			return int.Parse(this.PIQGIDHNPMM.PIDLOFMIEFQ);
		}
		set
		{
			this.PIQGIDHNPMM.PIDLOFMIEFQ = ((value >= 1) ? value.ToString() : "-");
		}
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x0001D58C File Offset: 0x0001B78C
	public void HJKPJLKMHEO(string BGBMIEJJQKC)
	{
		this.DLFHMPOPNMN.LKPOBCBOFIC(BGBMIEJJQKC);
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06004575 RID: 17781 RVA: 0x0001D5AC File Offset: 0x0001B7AC
	// (set) Token: 0x0600457C RID: 17788 RVA: 0x0001D47E File Offset: 0x0001B67E
	public bool FKEDKMDDGBG
	{
		get
		{
			return this.GMBHNPCOBGO;
		}
		set
		{
			this.GMBHNPCOBGO = value;
			this.DLFHMPOPNMN.CEGFBBHMKOE = ((!value) ? Color.white : Color.green);
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06004576 RID: 17782 RVA: 0x0001D5B4 File Offset: 0x0001B7B4
	// (set) Token: 0x06004588 RID: 17800 RVA: 0x0001D640 File Offset: 0x0001B840
	public string FPQBICGEHMJ
	{
		get
		{
			return this.DLFHMPOPNMN.PIDLOFMIEFQ;
		}
		set
		{
			this.DLFHMPOPNMN.PIDLOFMIEFQ = value;
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x0600458B RID: 17803 RVA: 0x0001D69A File Offset: 0x0001B89A
	// (set) Token: 0x06004577 RID: 17783 RVA: 0x0001D5C1 File Offset: 0x0001B7C1
	public bool EQCGNKKCJMK
	{
		get
		{
			return this.IGMHDFHHDJO.enabled;
		}
		set
		{
			this.OGOCJCIOEOO.enabled = value;
			this.IGMHDFHHDJO.enabled = value;
			if (value)
			{
				this.IGMHDFHHDJO.LJOIIDQEJCC();
			}
			this.IGMHDFHHDJO.GetComponent<PLQFPBQEPJD>().Update();
		}
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x0021C304 File Offset: 0x0021A504
	public void ChangeActive()
	{
		if (this.CLBKQBFMGEJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyPokemon
			{
				PokemonCount = this.JEBDNHCCHMQ,
				Simultaneously = this.NKJQHJFNQJM
			}, false);
		}
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x0021C04C File Offset: 0x0021A24C
	public void MIQHMFKIKBC(float BGBMIEJJQKC)
	{
		this.DIIHJCJOKMP = BGBMIEJJQKC;
		foreach (ENFMCDNLEQQ enfmcdnleqq in base.GetComponentsInChildren<ENFMCDNLEQQ>())
		{
			enfmcdnleqq.DIIHJCJOKMP = BGBMIEJJQKC;
		}
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x0001D53E File Offset: 0x0001B73E
	public void QJPIQHNPMHI(bool BGBMIEJJQKC)
	{
		this.QIGJMOIHFIP.enabled = BGBMIEJJQKC;
		this.EBDKLQHFENC.enabled = BGBMIEJJQKC;
		if (BGBMIEJJQKC)
		{
			this.QIGJMOIHFIP.LJOIIDQEJCC();
		}
		this.QIGJMOIHFIP.GetComponent<PLQFPBQEPJD>().Update();
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x0001D61E File Offset: 0x0001B81E
	public ActorType QLIMLJGLKHF()
	{
		return this.DPQFDCNLLPC;
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x0021C344 File Offset: 0x0021A544
	private void HBOENGLGNQH(int MJGGCLOGKFL, int NGQJLIEBFOM)
	{
		for (int i = 1; i < 8; i++)
		{
			if (MJGGCLOGKFL <= i)
			{
				this.OCLPCGQBNPK[i].LGJOOQIBQDC("-ability");
			}
			else if (NGQJLIEBFOM <= i)
			{
				this.OCLPCGQBNPK[i].LGJOOQIBQDC("\nEvening");
			}
			else
			{
				this.OCLPCGQBNPK[i].DPBGHDMHKNC("PrimitiveRight");
			}
		}
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x0021C04C File Offset: 0x0021A24C
	public void HHIQLHICOCL(float BGBMIEJJQKC)
	{
		this.DIIHJCJOKMP = BGBMIEJJQKC;
		foreach (ENFMCDNLEQQ enfmcdnleqq in base.GetComponentsInChildren<ENFMCDNLEQQ>())
		{
			enfmcdnleqq.DIIHJCJOKMP = BGBMIEJJQKC;
		}
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x0021C3A0 File Offset: 0x0021A5A0
	public void LKINOLFHMPM()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyKick
		{
			Username = this.FPQBICGEHMJ
		}, false);
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06004581 RID: 17793 RVA: 0x0001D626 File Offset: 0x0001B826
	// (set) Token: 0x06004597 RID: 17815 RVA: 0x0001D717 File Offset: 0x0001B917
	public bool HJMLLNFGDPK
	{
		get
		{
			return this.NIPQDJHKPOQ;
		}
		set
		{
			this.NIPQDJHKPOQ = value;
			this.DQPHMIQGPBL = 1f;
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x06004582 RID: 17794 RVA: 0x0001D62E File Offset: 0x0001B82E
	// (set) Token: 0x06004591 RID: 17809 RVA: 0x0001D6A7 File Offset: 0x0001B8A7
	public bool OLGBIGPMNFM
	{
		get
		{
			return this.EJNLBGODEEK.gameObject.activeSelf;
		}
		set
		{
			this.EJNLBGODEEK.gameObject.SetActive(value);
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06004587 RID: 17799 RVA: 0x0001D61E File Offset: 0x0001B81E
	// (set) Token: 0x06004583 RID: 17795 RVA: 0x0021C3CC File Offset: 0x0021A5CC
	public ActorType BBKKHIDMQIQ
	{
		get
		{
			return this.DPQFDCNLLPC;
		}
		set
		{
			this.DPQFDCNLLPC = value;
			switch (this.DPQFDCNLLPC)
			{
			case ActorType.Leader:
				this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[0];
				this.NBKCBIMINHF.PIDLOFMIEFQ = "Leader";
				this.NBKCBIMINHF.CEGFBBHMKOE = Color.yellow;
				break;
			case ActorType.User:
				this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[1];
				this.NBKCBIMINHF.PIDLOFMIEFQ = "User";
				this.NBKCBIMINHF.CEGFBBHMKOE = Color.cyan;
				break;
			case ActorType.NPC:
				this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[0];
				this.NBKCBIMINHF.PIDLOFMIEFQ = "NPC";
				this.NBKCBIMINHF.CEGFBBHMKOE = Color.green;
				break;
			case ActorType.Inactive:
				this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[2];
				this.NBKCBIMINHF.PIDLOFMIEFQ = "Waiting...";
				this.NBKCBIMINHF.CEGFBBHMKOE = Color.white;
				break;
			case ActorType.Offline:
				this.MCPNNHMOFQH.CEGFBBHMKOE = this.LPEGECBMQKQ[3];
				this.NBKCBIMINHF.PIDLOFMIEFQ = "Offline";
				this.NBKCBIMINHF.CEGFBBHMKOE = Color.red;
				break;
			}
		}
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x0001D640 File Offset: 0x0001B840
	public void LNPFBNNOFFF(string BGBMIEJJQKC)
	{
		this.DLFHMPOPNMN.PIDLOFMIEFQ = BGBMIEJJQKC;
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x0021C304 File Offset: 0x0021A504
	public void ChangeMax()
	{
		if (this.CLBKQBFMGEJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyPokemon
			{
				PokemonCount = this.JEBDNHCCHMQ,
				Simultaneously = this.NKJQHJFNQJM
			}, false);
		}
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x0001D4A1 File Offset: 0x0001B6A1
	public void GKQIKJOMIMO(bool BGBMIEJJQKC)
	{
		this.GMBHNPCOBGO = BGBMIEJJQKC;
		this.DLFHMPOPNMN.NONQDHBCIIN((!BGBMIEJJQKC) ? Color.white : Color.green);
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x0001D66F File Offset: 0x0001B86F
	private void Update()
	{
		if (this.NIPQDJHKPOQ)
		{
			this.DQPHMIQGPBL = 0.7f + Mathf.PingPong(UnityEngine.Time.time * 0.5f, 0.3f);
		}
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x0001D58C File Offset: 0x0001B78C
	public void MEPOOBGIHPK(string BGBMIEJJQKC)
	{
		this.DLFHMPOPNMN.LKPOBCBOFIC(BGBMIEJJQKC);
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x0021C3A0 File Offset: 0x0021A5A0
	public void Kick()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyKick
		{
			Username = this.FPQBICGEHMJ
		}, false);
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x0021C544 File Offset: 0x0021A744
	public int BLDKGCIMJJH()
	{
		int result = 0;
		if (this.IGMHDFHHDJO.LGNFPGFPBII().Contains("weakarmor"))
		{
			string text = this.IGMHDFHHDJO.ONPQLDJHHGB();
			char[] array = new char[0];
			array[0] = 'g';
			result = int.Parse(text.Split(array)[0]);
		}
		return result;
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x0021C590 File Offset: 0x0021A790
	public void LLMMGEELIHK(int MJGGCLOGKFL, int NGQJLIEBFOM)
	{
		if (this.DPQFDCNLLPC == ActorType.Inactive)
		{
			this.QIGJMOIHFIP.BGBMIEJJQKC = "Inactive";
			MJGGCLOGKFL = 0;
		}
		else if (NGQJLIEBFOM == 0)
		{
			this.QIGJMOIHFIP.BGBMIEJJQKC = "Spectator";
			MJGGCLOGKFL = 0;
		}
		else
		{
			this.QIGJMOIHFIP.BGBMIEJJQKC = "Active: " + NGQJLIEBFOM;
		}
		if (MJGGCLOGKFL > 0)
		{
			this.IGMHDFHHDJO.BGBMIEJJQKC = "Max: " + MJGGCLOGKFL;
		}
		else
		{
			this.EQCGNKKCJMK = false;
			this.IGMHDFHHDJO.BGBMIEJJQKC = "None";
		}
		this.EOFDHBQMHGF(MJGGCLOGKFL, NGQJLIEBFOM);
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x0001D6BA File Offset: 0x0001B8BA
	public void KHMCNBNQIBJ(int BGBMIEJJQKC)
	{
		this.PIQGIDHNPMM.PIDLOFMIEFQ = ((BGBMIEJJQKC >= 0) ? BGBMIEJJQKC.ToString() : "!\r\n");
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x0001D6DF File Offset: 0x0001B8DF
	public void BICMDMQDQDE(bool BGBMIEJJQKC)
	{
		this.OGOCJCIOEOO.enabled = BGBMIEJJQKC;
		this.IGMHDFHHDJO.enabled = BGBMIEJJQKC;
		if (BGBMIEJJQKC)
		{
			this.IGMHDFHHDJO.GJEPLPOONCQ();
		}
		this.IGMHDFHHDJO.GetComponent<PLQFPBQEPJD>().Update();
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x0021C630 File Offset: 0x0021A830
	public void MJHFMPDDLOL()
	{
		if (this.CLBKQBFMGEJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyPokemon
			{
				PokemonCount = this.JEBDNHCCHMQ,
				Simultaneously = this.NKJQHJFNQJM
			}, true);
		}
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x0001D583 File Offset: 0x0001B783
	public void CMHOEQMHJCC(bool BGBMIEJJQKC)
	{
		this.CLBKQBFMGEJ = BGBMIEJJQKC;
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x0001D6A7 File Offset: 0x0001B8A7
	public void LPMNMEEFJPQ(bool BGBMIEJJQKC)
	{
		this.EJNLBGODEEK.gameObject.SetActive(BGBMIEJJQKC);
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x0021C3A0 File Offset: 0x0021A5A0
	public void BMOMQONFOHH()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyKick
		{
			Username = this.FPQBICGEHMJ
		}, false);
	}

	// Token: 0x04000ECC RID: 3788
	public PLQFPBQEPJD MCPNNHMOFQH;

	// Token: 0x04000ECD RID: 3789
	public CFDMNELIJLO EJNLBGODEEK;

	// Token: 0x04000ECE RID: 3790
	public QCPKMJONIGF QIGJMOIHFIP;

	// Token: 0x04000ECF RID: 3791
	public PLQFPBQEPJD DIHPNOCELFN;

	// Token: 0x04000ED0 RID: 3792
	public PLQFPBQEPJD EBDKLQHFENC;

	// Token: 0x04000ED1 RID: 3793
	public QCPKMJONIGF IGMHDFHHDJO;

	// Token: 0x04000ED2 RID: 3794
	public PLQFPBQEPJD HNLGDLOGNGP;

	// Token: 0x04000ED3 RID: 3795
	public PLQFPBQEPJD OGOCJCIOEOO;

	// Token: 0x04000ED4 RID: 3796
	public BKKHLBCLPJM DLFHMPOPNMN;

	// Token: 0x04000ED5 RID: 3797
	public BKKHLBCLPJM NBKCBIMINHF;

	// Token: 0x04000ED6 RID: 3798
	public BKKHLBCLPJM PIQGIDHNPMM;

	// Token: 0x04000ED7 RID: 3799
	public BKKHLBCLPJM JIMNLQCGNFP;

	// Token: 0x04000ED8 RID: 3800
	public PLQFPBQEPJD[] OCLPCGQBNPK;

	// Token: 0x04000ED9 RID: 3801
	private ActorType DPQFDCNLLPC = ActorType.Inactive;

	// Token: 0x04000EDA RID: 3802
	private float DIIHJCJOKMP = 1f;

	// Token: 0x04000EDB RID: 3803
	private bool NIPQDJHKPOQ = true;

	// Token: 0x04000EDC RID: 3804
	private bool GMBHNPCOBGO;

	// Token: 0x04000EDD RID: 3805
	private bool CLBKQBFMGEJ;

	// Token: 0x04000EDE RID: 3806
	public Color[] LPEGECBMQKQ;
}
