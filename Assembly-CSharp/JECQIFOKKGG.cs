using System;
using PSXAPI.Request;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020001BE RID: 446
public class JECQIFOKKGG : MonoBehaviour
{
	// Token: 0x06003884 RID: 14468 RVA: 0x000182E7 File Offset: 0x000164E7
	private void HCHIDEKMEBB()
	{
		this.FQDHOBEPBIL = new Texture2D[8];
	}

	// Token: 0x06003885 RID: 14469 RVA: 0x001AE13C File Offset: 0x001AC33C
	private void LPFCGLONBKP()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1651f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 563f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 908f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 804f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x000182F5 File Offset: 0x000164F5
	public void OHPQCLCNBCC()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 76f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x00018324 File Offset: 0x00016524
	public void NNJMKGEMQOJ()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 794f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x001AE2A8 File Offset: 0x001AC4A8
	private void NMIHFGBFHMD()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[3];
		array[0] = "battle";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[7] = "Net Ball";
		array[6] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[7] = "GRAIN";
		array[4] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[3] = "2_";
		qpqlflhkopq.PIDLOFMIEFQ = string.Concat(array);
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 171 && fekoiojqnkh.QKNEIJQHGCB % 86 > 0)
		{
			str = "HidePanel" + (fekoiojqnkh.CCMOCLMEKJN() % 99).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("safeguard" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 1;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "stockpile1";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.GOKLDOEGJHI(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1918f;
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x00018353 File Offset: 0x00016553
	public void LOKCFBFMHND()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1340f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x001AE41C File Offset: 0x001AC61C
	private void JQGDBHBGINO()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[]
		{
			null,
			"p"
		};
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[5] = "flyLimit";
		array[1] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[3] = " shared its power with ";
		array[7] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[7] = "(F)";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 85 && fekoiojqnkh.QKNEIJQHGCB % 85 > 1)
		{
			str = "[00EE07]" + (fekoiojqnkh.CCMOCLMEKJN() % 124).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("Icon_Status_Poisoned" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str2 = "#Party";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = qoqonhoolne.GOKLDOEGJHI(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 578f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x0600388B RID: 14475 RVA: 0x00018382 File Offset: 0x00016582
	private void LODQBMMKNNM()
	{
		this.FQDHOBEPBIL = new Texture2D[3];
	}

	// Token: 0x0600388C RID: 14476 RVA: 0x001AE590 File Offset: 0x001AC790
	public bool ICGEMLMMJOP()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 845f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.HDLGEPEGNJM();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x0600388D RID: 14477 RVA: 0x001AE684 File Offset: 0x001AC884
	public bool IMMDFNIOPOE()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 854f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.KPJLEOCJFFO();
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.HDPBPFPIHCI();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600388E RID: 14478 RVA: 0x001AE778 File Offset: 0x001AC978
	private void EPKGNIPJOEF()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1227f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1203f)
			{
				this.EGQKKLJCHLN = 7;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 4)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 159f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 4)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 866f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x0600388F RID: 14479 RVA: 0x00018390 File Offset: 0x00016590
	private void DBFJHIHLQHO()
	{
		this.FQDHOBEPBIL = new Texture2D[2];
	}

	// Token: 0x06003890 RID: 14480 RVA: 0x0001839E File Offset: 0x0001659E
	public void LLIKMPBFNLK()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1853f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x06003891 RID: 14481 RVA: 0x001AE8E4 File Offset: 0x001ACAE4
	private void KNGQHHLPDMH()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1914f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 902f)
			{
				this.EGQKKLJCHLN = 2;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 2)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 181f)
			{
				this.EGQKKLJCHLN = 6;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1626f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
	}

	// Token: 0x06003892 RID: 14482 RVA: 0x001AEA50 File Offset: 0x001ACC50
	public void HGMNJEGKOBQ(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.OHPQCLCNBCC();
	}

	// Token: 0x06003893 RID: 14483 RVA: 0x000183CD File Offset: 0x000165CD
	public void IMOBOQMJNPH()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1789f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x06003894 RID: 14484 RVA: 0x001AEA94 File Offset: 0x001ACC94
	public void ChooseEvolution(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.Hide();
	}

	// Token: 0x06003895 RID: 14485 RVA: 0x001AEAD8 File Offset: 0x001ACCD8
	private void ELHGOEQPBPP()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[1];
		array[0] = "[PG]";
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[4] = "Player/Hats/";
		array[8] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[4] = "}]";
		array[5] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[5] = "skydrop";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -192 && fekoiojqnkh.CCMOCLMEKJN() % -42 > 0)
		{
			str = "4x" + (fekoiojqnkh.CCMOCLMEKJN() % -83).ToString();
		}
		this.FQDHOBEPBIL[1] = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("u" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "Logging in..";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.NMPCLCEQJMP(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1741f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x06003896 RID: 14486 RVA: 0x001AEC4C File Offset: 0x001ACE4C
	public bool FNQKBPFKDDK()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1613f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.KGMFIOCJLEP();
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.KHLHOBFCKMB();
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06003897 RID: 14487 RVA: 0x000182E7 File Offset: 0x000164E7
	private void KHFDJHFJMDK()
	{
		this.FQDHOBEPBIL = new Texture2D[8];
	}

	// Token: 0x06003898 RID: 14488 RVA: 0x001AED40 File Offset: 0x001ACF40
	public void QBOKPIFCEJK(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.OHPQCLCNBCC();
	}

	// Token: 0x06003899 RID: 14489 RVA: 0x001AED84 File Offset: 0x001ACF84
	public bool FQNNDCHBKME()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 514f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.bulbasaur)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.PLHHOQEBPCJ();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x00018390 File Offset: 0x00016590
	private void Start()
	{
		this.FQDHOBEPBIL = new Texture2D[2];
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x001AEE78 File Offset: 0x001AD078
	private void Update()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 0.01f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1f)
			{
				this.EGQKKLJCHLN = 2;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 2)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 0.01f)
			{
				this.EGQKKLJCHLN = 3;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 3)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x0600389C RID: 14492 RVA: 0x001AEFE4 File Offset: 0x001AD1E4
	private void CLNOPBFEBID()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1925f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1698f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 3)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1591f)
			{
				this.EGQKKLJCHLN = 5;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 7)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 765f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
	}

	// Token: 0x0600389D RID: 14493 RVA: 0x001AF150 File Offset: 0x001AD350
	public void ONPFHQCBJPN(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.BIMBBCFQJCE();
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x000183FC File Offset: 0x000165FC
	public void KJMQHHNFONN()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1259f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x0600389F RID: 14495 RVA: 0x001AF194 File Offset: 0x001AD394
	private void CBICBMGFHCP()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1008f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 460f)
			{
				this.EGQKKLJCHLN = 4;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 366f)
			{
				this.EGQKKLJCHLN = 7;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 759f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x060038A0 RID: 14496 RVA: 0x001AF300 File Offset: 0x001AD500
	public void IHHJMIHBNDM(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.DGOOJQEECPH();
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x001AF344 File Offset: 0x001AD544
	public void ODLIKFNNNJJ(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.POFOEMPKIQE();
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x001AF388 File Offset: 0x001AD588
	private void HDPBPFPIHCI()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[5];
		array[1] = "embargo";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[7] = "[silent]";
		array[7] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[2] = "FOG_OFF";
		array[6] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[1] = "Encounter Rate Decreased (Sandstorm)";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -81 && fekoiojqnkh.QKNEIJQHGCB % -23 > 0)
		{
			str = "Party" + (fekoiojqnkh.QKNEIJQHGCB % -69).ToString();
		}
		this.FQDHOBEPBIL[1] = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("OnDrag" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str2 = "Enter a name of the Channel you wish to join.";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = qoqonhoolne.NMPCLCEQJMP(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 574f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x0001842B File Offset: 0x0001662B
	public void BIMBBCFQJCE()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1918f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x0001845A File Offset: 0x0001665A
	public void HNMHKIJEDIE()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 656f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x001AF4FC File Offset: 0x001AD6FC
	private void HDLGEPEGNJM()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[]
		{
			"sturdy"
		};
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[7] = "_DetailOffsetX";
		array[2] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[6] = "ability";
		array[3] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[2] = " restored its HP.\r\n";
		qpqlflhkopq.PIDLOFMIEFQ = string.Concat(array);
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 133 && fekoiojqnkh.CCMOCLMEKJN() % 68 > 0)
		{
			str = " harshly" + (fekoiojqnkh.CCMOCLMEKJN() % -42).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("Battle" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 1;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "/03_1";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1313f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x001AF670 File Offset: 0x001AD870
	private void HOHNQFCMOIP()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[2];
		array[0] = "[-]'s team won the battle!\r\n";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[0] = "Only The Best!";
		array[1] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[8] = "Protects the Pokémon from things like sand, hail, and powder.";
		array[2] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[1] = "Magic Room wore off, and held items' effects returned to normal!\r\n";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 62 && fekoiojqnkh.QKNEIJQHGCB % -93 > 0)
		{
			str = " doesn't become confused!\r\n" + (fekoiojqnkh.CCMOCLMEKJN() % 62).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("speedboost" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "/01_";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1356f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x001AF7E4 File Offset: 0x001AD9E4
	public bool BDJNHBKKOON()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1034f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.KGMFIOCJLEP();
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.HDLGEPEGNJM();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x001AF8D8 File Offset: 0x001ADAD8
	public void GNMMEHNNNJI(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.FPGOEMCDQJC();
	}

	// Token: 0x060038A9 RID: 14505 RVA: 0x001AF91C File Offset: 0x001ADB1C
	public void NOHEOEDCPFC(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.KJMQHHNFONN();
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x001AF960 File Offset: 0x001ADB60
	public void BHKILQCOBQB(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.NNJMKGEMQOJ();
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x001AF9A4 File Offset: 0x001ADBA4
	private void HIKDHMFBNOD()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 773f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 174f)
			{
				this.EGQKKLJCHLN = 6;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 747f)
			{
				this.EGQKKLJCHLN = 8;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 8)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1508f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x060038AD RID: 14509 RVA: 0x001AFB10 File Offset: 0x001ADD10
	private void KHLHOBFCKMB()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[6];
		array[0] = "Blank";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[7] = " lost all of its PP due to the grudge!\r\n";
		array[1] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[5] = "[d9b38c]Message";
		array[4] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[3] = "_";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -136 && fekoiojqnkh.QKNEIJQHGCB % 62 > 1)
		{
			str = "_FogData2" + (fekoiojqnkh.QKNEIJQHGCB % 124).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("timer" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str2 = "[ATK]";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.NMPCLCEQJMP(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 806f;
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x0001849C File Offset: 0x0001669C
	public void FPGOEMCDQJC()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 121f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060038AF RID: 14511 RVA: 0x001AFC84 File Offset: 0x001ADE84
	public void GQCCPIJGLPK(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH == 0)
		{
			accept = true;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.BIMBBCFQJCE();
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x000184CB File Offset: 0x000166CB
	public void Hide()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060038B1 RID: 14513 RVA: 0x001AFCC8 File Offset: 0x001ADEC8
	public void BMIJOMFQBPH(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.HNMHKIJEDIE();
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x000184FA File Offset: 0x000166FA
	public void POFOEMPKIQE()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 536f;
		this.JDPBPOKJFQK.enabled = false;
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x00018529 File Offset: 0x00016729
	private void MJPQJHEEPMD()
	{
		this.FQDHOBEPBIL = new Texture2D[4];
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x001AFD0C File Offset: 0x001ADF0C
	private void INGCMBHKBKB()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[7];
		array[0] = "[broken]";
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[0] = "_MainTex";
		array[1] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[6] = "Close";
		array[3] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[1] = "[PG]";
		qpqlflhkopq.PIDLOFMIEFQ = string.Concat(array);
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -7 && fekoiojqnkh.CCMOCLMEKJN() % -65 > 0)
		{
			str = "The Tailwind blew from behind " + (fekoiojqnkh.QKNEIJQHGCB % 16).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("Create Tab" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 1;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
		string str2 = "HidePanel";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.NMPCLCEQJMP(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 850f;
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x001AFE80 File Offset: 0x001AE080
	private void NEDNFFNQFDG()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[7];
		array[1] = "castform";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[2] = "Powers up Grass-type moves when the Pokémon's HP is low.";
		array[5] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[0] = "[-]!\r\n";
		array[6] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[3] = "phscore";
		qpqlflhkopq.PIDLOFMIEFQ = string.Concat(array);
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == -168 && fekoiojqnkh.CCMOCLMEKJN() % 65 > 1)
		{
			str = "JOFLHFQQCKG" + (fekoiojqnkh.CCMOCLMEKJN() % -40).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Are you sure you wish to confirm your EV changes on [2ecc71]" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "#,##0";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.GOKLDOEGJHI(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1484f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060038B6 RID: 14518 RVA: 0x001AFFF4 File Offset: 0x001AE1F4
	public void NCMQBHBPOPB(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.NNJMKGEMQOJ();
	}

	// Token: 0x060038B7 RID: 14519 RVA: 0x00018537 File Offset: 0x00016737
	private void QNGIFIJOQML()
	{
		this.FQDHOBEPBIL = new Texture2D[1];
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x001B0038 File Offset: 0x001AE238
	private void BMPDMCLEFFH()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		this.QPQLFLHKOPQ.PIDLOFMIEFQ = string.Concat(new string[]
		{
			"[FF9900]",
			this.OFFKHFCFJLQ.GBDHFKQLINP,
			"[-] is trying to evolve into [FF9900]",
			this.OFFKHFCFJLQ.QDNHFJMGKOF,
			"[-], do you want your [FF9900]",
			this.OFFKHFCFJLQ.GBDHFKQLINP,
			"[-] to evolve?"
		});
		string str = string.Empty;
		if (fekoiojqnkh.BEQHNFFEHMQ == 201 && fekoiojqnkh.QKNEIJQHGCB % 28 > 0)
		{
			str = "_" + (fekoiojqnkh.QKNEIJQHGCB % 28).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 1;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str2 = "Big/";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = qoqonhoolne.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 0f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x00018545 File Offset: 0x00016745
	private void HMJOBKGICKD()
	{
		this.FQDHOBEPBIL = new Texture2D[6];
	}

	// Token: 0x060038BA RID: 14522 RVA: 0x001B01AC File Offset: 0x001AE3AC
	private void KCBFHOIENIQ()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1662f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 19f)
			{
				this.EGQKKLJCHLN = 6;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1501f)
			{
				this.EGQKKLJCHLN = 3;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 5)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1882f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x060038BB RID: 14523 RVA: 0x001B0318 File Offset: 0x001AE518
	public bool BLGLLGPFJPM()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 234f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.bulbasaur)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.EDGHHFPMHBL());
					this.FCLQKBFLQIP();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x00018553 File Offset: 0x00016753
	public void NJLLLEIOGGF()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1112f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060038BD RID: 14525 RVA: 0x001B040C File Offset: 0x001AE60C
	private void FCLQKBFLQIP()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[7];
		array[1] = " is no longer protected by mist!\r\n";
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[4] = "suctioncups";
		array[6] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[6] = "East";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[6] = "Can only tween MonsterTextures!";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -84 && fekoiojqnkh.QKNEIJQHGCB % -73 > 1)
		{
			str = "[00FF00]You received [PG]" + (fekoiojqnkh.CCMOCLMEKJN() % -36).ToString();
		}
		this.FQDHOBEPBIL[0] = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Item chance increased" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "(A)";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.NMPCLCEQJMP(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 779f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060038BE RID: 14526 RVA: 0x001B0580 File Offset: 0x001AE780
	public void GCQCJMDJCEG(int QDPCEEHDDPH)
	{
		bool accept = false;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, true);
		this.FPGOEMCDQJC();
	}

	// Token: 0x060038BF RID: 14527 RVA: 0x00018582 File Offset: 0x00016782
	public void EBCHEJCQDOP()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 143f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060038C0 RID: 14528 RVA: 0x001B05C4 File Offset: 0x001AE7C4
	public void MDNHGCHDJMC(int QDPCEEHDDPH)
	{
		bool accept = true;
		if (QDPCEEHDDPH == 0)
		{
			accept = false;
		}
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new Evolve
		{
			Accept = accept,
			Pokemon = this.OFFKHFCFJLQ.QEPKKJKQMPP
		}, false);
		this.NJLLLEIOGGF();
	}

	// Token: 0x060038C1 RID: 14529 RVA: 0x001B0608 File Offset: 0x001AE808
	private void PNHPFOHOGMC()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1595f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 304f)
			{
				this.EGQKKLJCHLN = 7;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 2)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 602f)
			{
				this.EGQKKLJCHLN = 3;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 8)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 386f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
	}

	// Token: 0x060038C2 RID: 14530 RVA: 0x001B0774 File Offset: 0x001AE974
	public bool NJQJPIEIPOD()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 1779f;
		this.JDPBPOKJFQK.enabled = true;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 1; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.bulbasaur)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.ELHGOEQPBPP();
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x001B0868 File Offset: 0x001AEA68
	public bool CQFFDMEDGCB()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 71f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.GBNQEKLJFCI();
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.NEDNFFNQFDG();
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x001B095C File Offset: 0x001AEB5C
	public bool CKNDFBPHPDG()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.enabled = false;
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i]);
				if (fekoiojqnkh != null && fekoiojqnkh.PEIDDQJBENJ > PokemonID.missingno)
				{
					this.OFFKHFCFJLQ = new JECQIFOKKGG.LEHJPHGNEIM();
					this.OFFKHFCFJLQ.QEPKKJKQMPP = fekoiojqnkh.LDQDJLFIDCN;
					this.OFFKHFCFJLQ.QDNHFJMGKOF = KGQECFKLKOP.NNHFLHEQMOI((int)fekoiojqnkh.PEIDDQJBENJ);
					this.OFFKHFCFJLQ.GBDHFKQLINP = KGQECFKLKOP.NNHFLHEQMOI(fekoiojqnkh.BEQHNFFEHMQ);
					this.BMPDMCLEFFH();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x001B0A50 File Offset: 0x001AEC50
	private void QNDKKMBJIEG()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[8];
		array[1] = "System Message";
		array[0] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[2] = "colorchange";
		array[3] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[3] = "berry_11";
		array[3] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[3] = "'s [ffff00]";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 174 && fekoiojqnkh.CCMOCLMEKJN() % -60 > 1)
		{
			str = "[-]!\r\n" + (fekoiojqnkh.CCMOCLMEKJN() % 50).ToString();
		}
		this.FQDHOBEPBIL[1] = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("[-][/urn]: " + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
		string str2 = "[00DD00]Equipped";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 143f;
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x000185B1 File Offset: 0x000167B1
	private void PFQDFBHEJEH()
	{
		this.FQDHOBEPBIL = new Texture2D[7];
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x001B0BC4 File Offset: 0x001AEDC4
	private void JJLGHJIBJBG()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[7];
		array[1] = "Play Time:";
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[3] = "[-]";
		array[7] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[1] = "flamewheel";
		array[2] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[6] = "\n";
		qpqlflhkopq.PIDLOFMIEFQ = string.Concat(array);
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == 147 && fekoiojqnkh.QKNEIJQHGCB % -66 > 1)
		{
			str = " anchored itself with its roots!\r\n" + (fekoiojqnkh.QKNEIJQHGCB % 93).ToString();
		}
		this.FQDHOBEPBIL[1] = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("Battle Update: " + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 0;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str2 = "\n";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 443f;
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x001B0D38 File Offset: 0x001AEF38
	private void JIHOGMQPHDF()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 411f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1717f)
			{
				this.EGQKKLJCHLN = 5;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1935f)
			{
				this.EGQKKLJCHLN = 5;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 5)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1574f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x001B0EA4 File Offset: 0x001AF0A4
	private void PLHHOQEBPCJ()
	{
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.OFFKHFCFJLQ.QEPKKJKQMPP);
		BKKHLBCLPJM qpqlflhkopq = this.QPQLFLHKOPQ;
		string[] array = new string[6];
		array[0] = "hyperspacefury";
		array[1] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[4] = "#,##0";
		array[2] = this.OFFKHFCFJLQ.QDNHFJMGKOF;
		array[7] = "special";
		array[6] = this.OFFKHFCFJLQ.GBDHFKQLINP;
		array[5] = "foeSide";
		qpqlflhkopq.LKPOBCBOFIC(string.Concat(array));
		string str = string.Empty;
		if (fekoiojqnkh.EDGHHFPMHBL() == -174 && fekoiojqnkh.QKNEIJQHGCB % 0 > 0)
		{
			str = "normal" + (fekoiojqnkh.CCMOCLMEKJN() % -5).ToString();
		}
		this.FQDHOBEPBIL[1] = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("MSGBOX - " + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		Texture2D[] fqdhobepbil = this.FQDHOBEPBIL;
		int num = 1;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str2 = "You can not afford to buy this item.";
		int peiddqjbenj = (int)fekoiojqnkh.PEIDDQJBENJ;
		fqdhobepbil[num] = gfhgejnhlfq.CPFJEOGMHOD(str2 + peiddqjbenj.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 947f;
		this.HDLHKMFEDBI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x000185BF File Offset: 0x000167BF
	public void DGOOJQEECPH()
	{
		this.HDLHKMFEDBI.gameObject.SetActive(true);
		this.HDLHKMFEDBI.DIIHJCJOKMP = 146f;
		this.JDPBPOKJFQK.enabled = true;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x001B1018 File Offset: 0x001AF218
	private void JPBJIKMEBOF()
	{
		if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 163f)
			{
				this.EGQKKLJCHLN = 1;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
		else if (this.EGQKKLJCHLN == 1)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 1804f)
			{
				this.EGQKKLJCHLN = 3;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 2)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP -= this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP <= 1516f)
			{
				this.EGQKKLJCHLN = 8;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[0];
			}
		}
		else if (this.EGQKKLJCHLN == 0)
		{
			this.MDEEECKGNKI.DIIHJCJOKMP += this.OMLNQFDKGHO * UnityEngine.Time.deltaTime;
			if (this.MDEEECKGNKI.DIIHJCJOKMP >= 729f)
			{
				this.EGQKKLJCHLN = 0;
				this.MDEEECKGNKI.GOIHJQNMMJD = this.FQDHOBEPBIL[1];
			}
		}
	}

	// Token: 0x04000D28 RID: 3368
	public KQHJOLQLQBJ HDLHKMFEDBI;

	// Token: 0x04000D29 RID: 3369
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000D2A RID: 3370
	public BKKHLBCLPJM QPQLFLHKOPQ;

	// Token: 0x04000D2B RID: 3371
	public JLMPBLMOICG MDEEECKGNKI;

	// Token: 0x04000D2C RID: 3372
	private Texture2D[] FQDHOBEPBIL;

	// Token: 0x04000D2D RID: 3373
	private int EGQKKLJCHLN;

	// Token: 0x04000D2E RID: 3374
	private float OMLNQFDKGHO = 3f;

	// Token: 0x04000D2F RID: 3375
	private JECQIFOKKGG.LEHJPHGNEIM OFFKHFCFJLQ;

	// Token: 0x020001BF RID: 447
	public class LEHJPHGNEIM
	{
		// Token: 0x04000D30 RID: 3376
		public Guid QEPKKJKQMPP;

		// Token: 0x04000D31 RID: 3377
		public string QDNHFJMGKOF;

		// Token: 0x04000D32 RID: 3378
		public string GBDHFKQLINP;
	}
}
