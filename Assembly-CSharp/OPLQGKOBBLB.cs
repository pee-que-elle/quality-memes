using System;
using UnityEngine;

// Token: 0x0200023C RID: 572
public class OPLQGKOBBLB : MonoBehaviour
{
	// Token: 0x06004E3B RID: 20027 RVA: 0x0001FE13 File Offset: 0x0001E013
	public void HKIPFMIEIJL(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 1544f;
		this.QEKQQGPMIMJ.EDGCGMGCCDN.BGBMIEJJQKC -= QJFQOMOIOOI;
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x0001FE36 File Offset: 0x0001E036
	public void HCHIHJNNEKC(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 965f;
		KDIEKDCQIHM edgcgmgccdn = this.QEKQQGPMIMJ.EDGCGMGCCDN;
		edgcgmgccdn.FONJFPIKGEP(edgcgmgccdn.HKDJGHOHBFQ() - QJFQOMOIOOI);
	}

	// Token: 0x06004E3D RID: 20029 RVA: 0x0001FE59 File Offset: 0x0001E059
	public void IEKKHBBDGDK()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.OPQLLMHCCHB(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E3E RID: 20030 RVA: 0x0001FE8D File Offset: 0x0001E08D
	private void CMLGQHQJDGQ()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(403f, 1714f, 25f, 1795f);
		this.IGBFFCJCFBG.PIDLOFMIEFQ = "_Texture2";
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x0028D7E0 File Offset: 0x0028B9E0
	public void DPBQLJNPIFB()
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(string.Empty);
		this.NGHNKQHLQBB.SetActive(true);
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(12f, 1580f, 1467f, 1437f);
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x0028D830 File Offset: 0x0028BA30
	public void MKPCPBJQNID(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("]" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1194f, 1374f, 1626f, 1363f));
			this.NGHNKQHLQBB.SetActive(true);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1252f, 1790f, 1837f, 606f));
			if (PCOKMPDNHBJ > 1)
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
		}
	}

	// Token: 0x06004E41 RID: 20033 RVA: 0x0028D8F4 File Offset: 0x0028BAF4
	public void BEMOIELFCDM(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = DBPKNCDGGEP.DBFPJOCLQBI();
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("#,##0" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(754f, 1814f, 1886f, 110f));
			this.NGHNKQHLQBB.SetActive(true);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1414f, 1540f, 1810f, 512f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E42 RID: 20034 RVA: 0x0028D9B8 File Offset: 0x0028BBB8
	public void BQLIIQIIMDH(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = DBPKNCDGGEP.DBFPJOCLQBI();
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(0f, 0f, 0f, 1f);
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1f, 1f, 1f, 1f);
			if (PCOKMPDNHBJ > 1)
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E43 RID: 20035 RVA: 0x0028DA7C File Offset: 0x0028BC7C
	public void QGJPMKPOGKN()
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = string.Empty;
		this.NGHNKQHLQBB.SetActive(false);
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1180f, 1458f, 605f, 1929f);
	}

	// Token: 0x06004E44 RID: 20036 RVA: 0x0001FEC3 File Offset: 0x0001E0C3
	public void MONPDKMHOFP()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.GPQKFHFNDPM(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E45 RID: 20037 RVA: 0x0028DACC File Offset: 0x0028BCCC
	public void HOFCKQELDLF(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("This Pokémon has its own tempo, and that prevents it from becoming confused." + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(623f, 1947f, 1195f, 756f));
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1517f, 1117f, 1972f, 930f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E46 RID: 20038 RVA: 0x0001FEF7 File Offset: 0x0001E0F7
	public void KPECFPBBPHK(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 1166f;
		KDIEKDCQIHM edgcgmgccdn = this.QEKQQGPMIMJ.EDGCGMGCCDN;
		edgcgmgccdn.BGBMIEJJQKC = edgcgmgccdn.HKDJGHOHBFQ() - QJFQOMOIOOI;
	}

	// Token: 0x06004E47 RID: 20039 RVA: 0x0028DB90 File Offset: 0x0028BD90
	public void DOEGKLDPQKB(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("/" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1313f, 1218f, 1676f, 1854f);
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(144f, 1975f, 983f, 565f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
		}
	}

	// Token: 0x06004E48 RID: 20040 RVA: 0x0001FF1A File Offset: 0x0001E11A
	private void KCFPNFCPPCC()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(973f, 1314f, 1610f, 399f);
		this.IGBFFCJCFBG.LKPOBCBOFIC(")\n");
	}

	// Token: 0x06004E49 RID: 20041 RVA: 0x0001FF50 File Offset: 0x0001E150
	private void DGMPMICDCIO()
	{
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(37f, 550f, 714f, 1321f));
		this.IGBFFCJCFBG.PIDLOFMIEFQ = "Powers up each Pokémon's Fairy-type moves.";
	}

	// Token: 0x06004E4A RID: 20042 RVA: 0x0001FF86 File Offset: 0x0001E186
	private void QBGOGFJCLEP()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(85f, 332f, 804f, 979f);
		this.IGBFFCJCFBG.LKPOBCBOFIC("_Texture0");
	}

	// Token: 0x06004E4B RID: 20043 RVA: 0x0001FFBC File Offset: 0x0001E1BC
	private void HCHIDEKMEBB()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1828f, 1682f, 278f, 479f);
		this.IGBFFCJCFBG.LKPOBCBOFIC("Leader");
	}

	// Token: 0x06004E4C RID: 20044 RVA: 0x0001FFF2 File Offset: 0x0001E1F2
	private void Start()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(0f, 0f, 0f, 1f);
		this.IGBFFCJCFBG.PIDLOFMIEFQ = "001";
	}

	// Token: 0x06004E4D RID: 20045 RVA: 0x0028DC54 File Offset: 0x0028BE54
	public void FQFIFPGJDBE(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("-useTouch" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(741f, 279f, 606f, 648f);
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1427f, 416f, 1008f, 1516f);
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
		}
	}

	// Token: 0x06004E4E RID: 20046 RVA: 0x00020028 File Offset: 0x0001E228
	private void LMMGEGJCBJP()
	{
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(926f, 1127f, 1891f, 1142f));
		this.IGBFFCJCFBG.LKPOBCBOFIC("ability: ");
	}

	// Token: 0x06004E4F RID: 20047 RVA: 0x0028DD18 File Offset: 0x0028BF18
	public void FDEDICFQNEJ(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = DBPKNCDGGEP.DBFPJOCLQBI();
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD(" restored its HP!\r\n" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(948f, 752f, 977f, 72f);
			this.NGHNKQHLQBB.SetActive(true);
		}
		else
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1966f, 533f, 1299f, 885f);
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E50 RID: 20048 RVA: 0x0002005E File Offset: 0x0001E25E
	private void LIFJCBMQELJ()
	{
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(663f, 345f, 894f, 685f));
		this.IGBFFCJCFBG.LKPOBCBOFIC("Fishing Cooldown");
	}

	// Token: 0x06004E51 RID: 20049 RVA: 0x00020094 File Offset: 0x0001E294
	public void LQFIGGEOLHP(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 1231f;
		KDIEKDCQIHM edgcgmgccdn = this.QEKQQGPMIMJ.EDGCGMGCCDN;
		edgcgmgccdn.BGBMIEJJQKC = edgcgmgccdn.HKDJGHOHBFQ() - QJFQOMOIOOI;
	}

	// Token: 0x06004E52 RID: 20050 RVA: 0x0028DDDC File Offset: 0x0028BFDC
	public void BGDMMFNKBII()
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(string.Empty);
		this.NGHNKQHLQBB.SetActive(false);
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(145f, 1956f, 1008f, 1644f));
	}

	// Token: 0x06004E53 RID: 20051 RVA: 0x0028DE2C File Offset: 0x0028C02C
	public void Hide()
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = string.Empty;
		this.NGHNKQHLQBB.SetActive(false);
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(0f, 0f, 0f, 0f);
	}

	// Token: 0x06004E54 RID: 20052 RVA: 0x000200B7 File Offset: 0x0001E2B7
	public void NNGNQFEJJBQ(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 810f;
		KDIEKDCQIHM edgcgmgccdn = this.QEKQQGPMIMJ.EDGCGMGCCDN;
		edgcgmgccdn.PLLQOHPCBOP(edgcgmgccdn.BGBMIEJJQKC - QJFQOMOIOOI);
	}

	// Token: 0x06004E55 RID: 20053 RVA: 0x000200DA File Offset: 0x0001E2DA
	public void HCNENCHLNII()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.SelectPoke(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E56 RID: 20054 RVA: 0x0002010E File Offset: 0x0001E30E
	private void ODIJQBBOLFI()
	{
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1342f, 852f, 1343f, 512f);
		this.IGBFFCJCFBG.LKPOBCBOFIC("Home");
	}

	// Token: 0x06004E57 RID: 20055 RVA: 0x0028DE7C File Offset: 0x0028C07C
	public void NPCKENGDEIN()
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = string.Empty;
		this.NGHNKQHLQBB.SetActive(true);
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(258f, 590f, 594f, 1482f));
	}

	// Token: 0x06004E58 RID: 20056 RVA: 0x0028DECC File Offset: 0x0028C0CC
	public void FPQIFQNBIDC(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("wonderroom" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(716f, 1263f, 1172f, 789f));
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1118f, 1013f, 837f, 1198f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E59 RID: 20057 RVA: 0x00020144 File Offset: 0x0001E344
	public void CGMQCMLFLFG()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.GCDKMDJNDQQ(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E5A RID: 20058 RVA: 0x00020178 File Offset: 0x0001E378
	public void CJCBOFBELQC()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.NDPPNOHNDJK(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E5B RID: 20059 RVA: 0x0028DF90 File Offset: 0x0028C190
	public void EDKDPDKIBJN(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(DBPKNCDGGEP.DBFPJOCLQBI());
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Stone Badge" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(206f, 798f, 1169f, 346f));
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1695f, 297f, 915f, 220f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E5C RID: 20060 RVA: 0x000200DA File Offset: 0x0001E2DA
	public void SelectPoke()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.SelectPoke(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E5D RID: 20061 RVA: 0x000201AC File Offset: 0x0001E3AC
	private void IKHIQQKHILB()
	{
		this.QEPKKJKQMPP.NONQDHBCIIN(new Color(640f, 727f, 116f, 125f));
		this.IGBFFCJCFBG.PIDLOFMIEFQ = "[sup]";
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x0028E054 File Offset: 0x0028C254
	public void HDNLCNIHJBM(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = DBPKNCDGGEP.DBFPJOCLQBI();
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().CPFJEOGMHOD("Boosts the accuracy of its allies and itself." + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1920f, 720f, 284f, 1536f);
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(447f, 1072f, 1720f, 846f);
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E5F RID: 20063 RVA: 0x0028E118 File Offset: 0x0028C318
	public void LCCQBMMFONQ(bool GJPMJJILHFQ, int PCOKMPDNHBJ, int DBPKNCDGGEP)
	{
		this.IGBFFCJCFBG.PIDLOFMIEFQ = DBPKNCDGGEP.DBFPJOCLQBI();
		this.QEPKKJKQMPP.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Dig" + DBPKNCDGGEP.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		if (PCOKMPDNHBJ == 0)
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1204f, 1608f, 1449f, 1316f));
			this.NGHNKQHLQBB.SetActive(false);
		}
		else
		{
			this.QEPKKJKQMPP.NONQDHBCIIN(new Color(1776f, 1062f, 1368f, 1041f));
			if (PCOKMPDNHBJ > 0)
			{
				this.NGHNKQHLQBB.SetActive(true);
			}
			else
			{
				this.NGHNKQHLQBB.SetActive(false);
			}
		}
	}

	// Token: 0x06004E60 RID: 20064 RVA: 0x0001FE59 File Offset: 0x0001E059
	public void IKQLBPCEHQH()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.OPQLLMHCCHB(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E62 RID: 20066 RVA: 0x000201E2 File Offset: 0x0001E3E2
	public void OnScroll(float QJFQOMOIOOI)
	{
		QJFQOMOIOOI *= 0.1f;
		this.QEKQQGPMIMJ.EDGCGMGCCDN.BGBMIEJJQKC -= QJFQOMOIOOI;
	}

	// Token: 0x06004E63 RID: 20067 RVA: 0x0001FE59 File Offset: 0x0001E059
	public void HKNJPGEBCJP()
	{
		if (this.IGBFFCJCFBG.PIDLOFMIEFQ != string.Empty)
		{
			this.QEKQQGPMIMJ.OPQLLMHCCHB(Convert.ToInt32(this.IGBFFCJCFBG.PIDLOFMIEFQ));
		}
	}

	// Token: 0x06004E64 RID: 20068 RVA: 0x0028E1DC File Offset: 0x0028C3DC
	public void CBBOOJHHGDG()
	{
		this.IGBFFCJCFBG.LKPOBCBOFIC(string.Empty);
		this.NGHNKQHLQBB.SetActive(false);
		this.QEPKKJKQMPP.CEGFBBHMKOE = new Color(1689f, 53f, 975f, 1730f);
	}

	// Token: 0x040010D4 RID: 4308
	public EIDBQCPLPIL QEKQQGPMIMJ;

	// Token: 0x040010D5 RID: 4309
	public BKKHLBCLPJM IGBFFCJCFBG;

	// Token: 0x040010D6 RID: 4310
	public JLMPBLMOICG QEPKKJKQMPP;

	// Token: 0x040010D7 RID: 4311
	public GameObject NGHNKQHLQBB;
}
