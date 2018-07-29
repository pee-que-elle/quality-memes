using System;
using PSXAPI.Request;
using UnityEngine;

// Token: 0x0200020E RID: 526
public class LCBQFQDLLEB : MonoBehaviour
{
	// Token: 0x0600464E RID: 17998 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void OCHHBFFHIDJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600464F RID: 17999 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void BOCKGMCFQPD()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x0021F408 File Offset: 0x0021D608
	private void DKJKOBGBKCN()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
			{
				Vote = LootVote.TimedOut,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.HPNFKNNLGJH();
		}
		float num = (62f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 319f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x0021F490 File Offset: 0x0021D690
	public void JPPHDFEEFGI()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Pass,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.PBPCFIJBJDB();
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x0021F4C8 File Offset: 0x0021D6C8
	public void Greed()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Greed,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.Close();
	}

	// Token: 0x06004654 RID: 18004 RVA: 0x0021F500 File Offset: 0x0021D700
	public void QGQOOPBKOQI()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)7,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.GKNLKBJOQJP();
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x0021F538 File Offset: 0x0021D738
	public void CLNOLHELNGO()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.Close();
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x0021F570 File Offset: 0x0021D770
	public void DFEBPEOOELI()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Greed,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.ODQKOBDHLPJ();
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x00002300 File Offset: 0x00000500
	private void PDCQCFKFOLQ()
	{
	}

	// Token: 0x06004658 RID: 18008 RVA: 0x0001DAB6 File Offset: 0x0001BCB6
	private void OIIEHOGHOCQ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("uproar", 242f);
		}
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void CPCCDJFGKOO()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x0021F5A8 File Offset: 0x0021D7A8
	public void MECIDGLQKDB()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = (LootVote)5,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.ODQKOBDHLPJ();
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x0021F5E0 File Offset: 0x0021D7E0
	public void MCFGDJLCHQD()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.TimedOut,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.GDDMKPQODFN();
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void HPNFKNNLGJH()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x0021F618 File Offset: 0x0021D818
	public void GDNENMIBGJF()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)6,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.ECQPFEPDQLO();
	}

	// Token: 0x0600465E RID: 18014 RVA: 0x0021F650 File Offset: 0x0021D850
	public void ODQHDJCPQDC()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = (LootVote)7,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.HPNFKNNLGJH();
	}

	// Token: 0x0600465F RID: 18015 RVA: 0x0021F688 File Offset: 0x0021D888
	public void OBKLEIOMJQC()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.PPPKJKQPHCE();
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void GDDMKPQODFN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004661 RID: 18017 RVA: 0x0021F6C0 File Offset: 0x0021D8C0
	private void HDMNIKNDNGQ()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
			{
				Vote = (LootVote)7,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.JMIOGDFLEDC();
		}
		float num = (1980f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 1831f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004662 RID: 18018 RVA: 0x0021F748 File Offset: 0x0021D948
	public void OJMCCMCJIJG()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = (LootVote)8,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.BOCKGMCFQPD();
	}

	// Token: 0x06004663 RID: 18019 RVA: 0x00002300 File Offset: 0x00000500
	private void JPNMOLDKPQP()
	{
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x0021F780 File Offset: 0x0021D980
	private void EHBDNIOCHNO()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
			{
				Vote = LootVote.Pass,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.ECQPFEPDQLO();
		}
		float num = (734f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 279f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void PPPKJKQPHCE()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004666 RID: 18022 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void ECQPFEPDQLO()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void LIBOEONEKNE()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004668 RID: 18024 RVA: 0x0001DADB File Offset: 0x0001BCDB
	private void PONLQNDQMEQ()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke(" (SoftClip)", 909f);
		}
	}

	// Token: 0x06004669 RID: 18025 RVA: 0x0021F808 File Offset: 0x0021DA08
	private void JPBJIKMEBOF()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
			{
				Vote = (LootVote)7,
				VoteID = this.DBPKNCDGGEP
			}, true);
			this.MEOCHHHCEHF();
		}
		float num = (1256f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 257f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x0600466A RID: 18026 RVA: 0x0001DB00 File Offset: 0x0001BD00
	private void DGODHNHPNHE()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Pokédex", 1680f);
		}
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x0021F890 File Offset: 0x0021DA90
	public void PGCCGCPDDPG()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Greed,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.CHMCLOQIOLN();
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x0021F8C8 File Offset: 0x0021DAC8
	public void LDLHOEQJBDO()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)8,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.CPCCDJFGKOO();
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void Close()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x0001DB38 File Offset: 0x0001BD38
	private void KJEBMEELMIH()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke(" has no mainTexture setter", 1910f);
		}
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x0021F900 File Offset: 0x0021DB00
	public void Pass()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Pass,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.Close();
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x00002300 File Offset: 0x00000500
	private void IKHIQQKHILB()
	{
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x0021F938 File Offset: 0x0021DB38
	public void NLIKFCOJKME()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)8,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.ECQPFEPDQLO();
	}

	// Token: 0x06004673 RID: 18035 RVA: 0x0021F970 File Offset: 0x0021DB70
	public void FGMDHBKDMQG()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)7,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.JMIOGDFLEDC();
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x0001DB5D File Offset: 0x0001BD5D
	private void DHBEOHDMFDO()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke(")", 1044f);
		}
	}

	// Token: 0x06004675 RID: 18037 RVA: 0x00002300 File Offset: 0x00000500
	private void NOLQNFCODBK()
	{
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x0021F9A8 File Offset: 0x0021DBA8
	private void OBNDQJFDQEK()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
			{
				Vote = LootVote.Pass,
				VoteID = this.DBPKNCDGGEP
			}, true);
			this.ODQKOBDHLPJ();
		}
		float num = (1344f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 487f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x0021FA30 File Offset: 0x0021DC30
	public void IGGILLPOHKN()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.JMIOGDFLEDC();
	}

	// Token: 0x06004678 RID: 18040 RVA: 0x0001DB82 File Offset: 0x0001BD82
	private void HMNILLOJHHB()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("UpdateAnchors", 1402f);
		}
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x0001DBA7 File Offset: 0x0001BDA7
	private void OnDestroy()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("Reposition", 0.2f);
		}
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x0021FA68 File Offset: 0x0021DC68
	public void GBOPOIPNHBB()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = (LootVote)5,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.JMIOGDFLEDC();
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x0001DBCC File Offset: 0x0001BDCC
	private void FGONNFBLJDD()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("'s ", 217f);
		}
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x0021FAA0 File Offset: 0x0021DCA0
	private void Update()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
			{
				Vote = LootVote.TimedOut,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.Close();
		}
		float num = (1f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 139f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void ODQKOBDHLPJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x00002300 File Offset: 0x00000500
	private void GJLLCMLLEQF()
	{
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x0021FB28 File Offset: 0x0021DD28
	public void QNJKEBGQECK()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Need,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.OCHHBFFHIDJ();
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x0021FB60 File Offset: 0x0021DD60
	public void IMKKPLCEFKJ()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Pass,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.LIBOEONEKNE();
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void PBPCFIJBJDB()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x0001DBF1 File Offset: 0x0001BDF1
	private void BJPEKCCDIIE()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("NPC", 557f);
		}
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void JMIOGDFLEDC()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004684 RID: 18052 RVA: 0x0021FB98 File Offset: 0x0021DD98
	private void NPQEGOIJHIL()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
			{
				Vote = (LootVote)6,
				VoteID = this.DBPKNCDGGEP
			}, true);
			this.LIBOEONEKNE();
		}
		float num = (1079f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 1011f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004685 RID: 18053 RVA: 0x0021FC20 File Offset: 0x0021DE20
	public void GKJGNBOIIBN()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = (LootVote)5,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.ECQPFEPDQLO();
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x0021FC58 File Offset: 0x0021DE58
	private void MOLCLOMMJNQ()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
			{
				Vote = LootVote.TimedOut,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.Close();
		}
		float num = (961f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 1039f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004687 RID: 18055 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void MEOCHHHCEHF()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004688 RID: 18056 RVA: 0x0021FCE0 File Offset: 0x0021DEE0
	public void IEPDOBDHNEG()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.PBPCFIJBJDB();
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x0021F538 File Offset: 0x0021D738
	public void JGLJPPPBPHK()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.Close();
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x0021FD18 File Offset: 0x0021DF18
	public void NKLLGKCFDNC()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Pass,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.JMIOGDFLEDC();
	}

	// Token: 0x0600468B RID: 18059 RVA: 0x0021FD50 File Offset: 0x0021DF50
	public void IKIEKQBFFNH()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.MEOCHHHCEHF();
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x0001DC16 File Offset: 0x0001BE16
	private void ILJNLCBQHPO()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("_FresnelFadePower", 1651f);
		}
	}

	// Token: 0x0600468D RID: 18061 RVA: 0x0021FD88 File Offset: 0x0021DF88
	public void NGEDLPMHILB()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = LootVote.Pass,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.CHMCLOQIOLN();
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x0021FDC0 File Offset: 0x0021DFC0
	private void QIHJCOLPLBQ()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
			{
				Vote = LootVote.Pass,
				VoteID = this.DBPKNCDGGEP
			}, false);
			this.ECQPFEPDQLO();
		}
		float num = (1578f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 250f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x0021FE48 File Offset: 0x0021E048
	public void HQQMDNLQECQ()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
		{
			Vote = (LootVote)7,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.JBHOOGECBHB();
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x0001DC3B File Offset: 0x0001BE3B
	private void JOLDGDIPFEC()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("raindance", 1697f);
		}
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x0021FE80 File Offset: 0x0021E080
	private void BLEHFIJGOHG()
	{
		if (UnityEngine.Time.time > this.CLBHJLICGPC + this.ICFJOIPHKDJ)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Loot
			{
				Vote = LootVote.Greed,
				VoteID = this.DBPKNCDGGEP
			}, true);
			this.ECQPFEPDQLO();
		}
		float num = (397f - (UnityEngine.Time.time - this.CLBHJLICGPC) / this.ICFJOIPHKDJ) * 376f;
		if (this.GDQHOCHHIJD.KJGMGPCEJJD != (int)num)
		{
			this.GDQHOCHHIJD.KJGMGPCEJJD = (int)num;
		}
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void JBHOOGECBHB()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x0001DC60 File Offset: 0x0001BE60
	private void QIPGKGEBBNI()
	{
		if (this.JHDGENGBPQF != null)
		{
			this.JHDGENGBPQF.Invoke("The stat changes the Pokémon receives are doubled.", 511f);
		}
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x0021FF08 File Offset: 0x0021E108
	public void Need()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Need,
			VoteID = this.DBPKNCDGGEP
		}, false);
		this.Close();
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void CHMCLOQIOLN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004696 RID: 18070 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
	private void GKNLKBJOQJP()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x0021FF40 File Offset: 0x0021E140
	public void QBBBLDBKHOJ()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Loot
		{
			Vote = LootVote.Unset,
			VoteID = this.DBPKNCDGGEP
		}, true);
		this.CPCCDJFGKOO();
	}

	// Token: 0x04000EF4 RID: 3828
	public BHLIGEGNFHG JHDGENGBPQF;

	// Token: 0x04000EF5 RID: 3829
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x04000EF6 RID: 3830
	public PLQFPBQEPJD GDQHOCHHIJD;

	// Token: 0x04000EF7 RID: 3831
	public JLMPBLMOICG PHMFEMBPQLN;

	// Token: 0x04000EF8 RID: 3832
	public Guid DBPKNCDGGEP;

	// Token: 0x04000EF9 RID: 3833
	public float ICFJOIPHKDJ = 120f;

	// Token: 0x04000EFA RID: 3834
	public float CLBHJLICGPC;
}
