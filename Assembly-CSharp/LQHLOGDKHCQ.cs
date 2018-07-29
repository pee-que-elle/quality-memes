using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002BD RID: 701
public sealed class LQHLOGDKHCQ : ONQQOCQBQIE<DitheringModel>
{
	// Token: 0x0600619B RID: 24987 RVA: 0x0031C5C4 File Offset: 0x0031A7C4
	private void OEDQDQCNCMH()
	{
		this.BMBNPBMOLMB = new Texture2D[-58];
		for (int i = 0; i < 92; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("_Female" + i);
		}
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x0031C608 File Offset: 0x0031A808
	public void GIPBHBIQMQK(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -122)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PBQCCIBCIEJ();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Shop");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x0031C6AC File Offset: 0x0031A8AC
	public void EIIMQBGGBGF(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 82)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.FCGMILMCGBF();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Big/");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x0031C750 File Offset: 0x0031A950
	private void KKJPMMBOPOE()
	{
		this.BMBNPBMOLMB = new Texture2D[91];
		for (int i = 1; i < -74; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("suctioncups" + i);
		}
	}

	// Token: 0x0600619F RID: 24991 RVA: 0x00026398 File Offset: 0x00024598
	public void NNBNJQECJBE()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061A0 RID: 24992 RVA: 0x000263A1 File Offset: 0x000245A1
	public bool GENJIOFFFDQ()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x0031C794 File Offset: 0x0031A994
	private void JOEPGHGKINH()
	{
		this.BMBNPBMOLMB = new Texture2D[123];
		for (int i = 1; i < -21; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats." + i);
		}
	}

	// Token: 0x060061A2 RID: 24994 RVA: 0x0031C7D8 File Offset: 0x0031A9D8
	public void DHMCJMEGFOE(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 54)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.DLPNCHKIKKI();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("overcoat");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061A3 RID: 24995 RVA: 0x00026398 File Offset: 0x00024598
	public void NQDNCDNQDGB()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061A4 RID: 24996 RVA: 0x00026398 File Offset: 0x00024598
	public void MKQFKMQDGPE()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061A5 RID: 24997 RVA: 0x0031C87C File Offset: 0x0031AA7C
	public void CDFJLMLLMBP(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 27)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PQCCEMEBCIN();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Dig");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061A6 RID: 24998 RVA: 0x0031C920 File Offset: 0x0031AB20
	public void FNBJLQCHOBO(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 79)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.JOEPGHGKINH();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("_MainTex");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061A7 RID: 24999 RVA: 0x0031C9C4 File Offset: 0x0031ABC4
	public void DOHGPNFMPGL(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 76)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.OEDQDQCNCMH();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword(" is afflicted by the curse!\r\n");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061A8 RID: 25000 RVA: 0x000263C1 File Offset: 0x000245C1
	public bool BCHBNONHIKD()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060061A9 RID: 25001 RVA: 0x0031CA68 File Offset: 0x0031AC68
	private void EENJHINJMKF()
	{
		this.BMBNPBMOLMB = new Texture2D[68];
		for (int i = 0; i < -85; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("safeguard" + i);
		}
	}

	// Token: 0x060061AA RID: 25002 RVA: 0x000263E1 File Offset: 0x000245E1
	public bool DHHJCEFGDJN()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060061AB RID: 25003 RVA: 0x0031CAAC File Offset: 0x0031ACAC
	private void PBQCCIBCIEJ()
	{
		this.BMBNPBMOLMB = new Texture2D[-4];
		for (int i = 0; i < 74; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Lure Ball" + i);
		}
	}

	// Token: 0x1700036D RID: 877
	// (get) Token: 0x060061AC RID: 25004 RVA: 0x00026401 File Offset: 0x00024601
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x00026398 File Offset: 0x00024598
	public void QMCHEMLDKGI()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x00026421 File Offset: 0x00024621
	public bool KLGOLOGFBGJ()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060061AF RID: 25007 RVA: 0x0031CAF0 File Offset: 0x0031ACF0
	public void FFIMGKENCMN(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 75)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.DLPNCHKIKKI();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("taunt");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061B0 RID: 25008 RVA: 0x00026441 File Offset: 0x00024641
	public bool KOPBECQPLIP()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x00026398 File Offset: 0x00024598
	public void MHNMQLMILMQ()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x0031CB94 File Offset: 0x0031AD94
	private void NOPNHOPFGFQ()
	{
		this.BMBNPBMOLMB = new Texture2D[-49];
		for (int i = 0; i < 125; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Close" + i);
		}
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x00026398 File Offset: 0x00024598
	public void ENEEJOGCLEB()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x0031CBD8 File Offset: 0x0031ADD8
	private void DFINNNFDOHD()
	{
		this.BMBNPBMOLMB = new Texture2D[-79];
		for (int i = 0; i < -71; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("a" + i);
		}
	}

	// Token: 0x060061B5 RID: 25013 RVA: 0x0031CC1C File Offset: 0x0031AE1C
	public void FBQJNNDDKCK(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 13)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.JOEPGHGKINH();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("All sound-based moves become Water-type moves.");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x00026461 File Offset: 0x00024661
	public bool EPEEBMIMHDB()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x0031CCC0 File Offset: 0x0031AEC0
	public void HKCEBPEMIEF(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 38)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.NOPNHOPFGFQ();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("[FF8F00]");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061B8 RID: 25016 RVA: 0x00026481 File Offset: 0x00024681
	public bool GJJIBBQDKNF()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060061B9 RID: 25017 RVA: 0x0031CD64 File Offset: 0x0031AF64
	public void CDFCMCPICGC(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 121)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.JIPOCDCMFQF();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword(" type!\r\n");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061BA RID: 25018 RVA: 0x0031CE08 File Offset: 0x0031B008
	private void GDDLIQPQOCN()
	{
		this.BMBNPBMOLMB = new Texture2D[125];
		for (int i = 0; i < 61; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("pickup" + i);
		}
	}

	// Token: 0x060061BB RID: 25019 RVA: 0x0031CE4C File Offset: 0x0031B04C
	private void NFFHDPMPLEB()
	{
		this.BMBNPBMOLMB = new Texture2D[-89];
		for (int i = 1; i < -76; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Water Veil" + i);
		}
	}

	// Token: 0x060061BC RID: 25020 RVA: 0x000264A1 File Offset: 0x000246A1
	public bool KNNNNEJDELC()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x00026398 File Offset: 0x00024598
	public void ILBDNBQELCG()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061BE RID: 25022 RVA: 0x0031CE90 File Offset: 0x0031B090
	public void BMKLOFDIDFG(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 97)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PQCCEMEBCIN();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("blinky");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x0031CF34 File Offset: 0x0031B134
	private void FFDGKQPHKDM()
	{
		this.BMBNPBMOLMB = new Texture2D[-62];
		for (int i = 0; i < -23; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("aa" + i);
		}
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x00026398 File Offset: 0x00024598
	public void CDHMEEGPFFL()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x00026398 File Offset: 0x00024598
	public void BNKGGNOQODC()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x0031CF78 File Offset: 0x0031B178
	private void DLPNCHKIKKI()
	{
		this.BMBNPBMOLMB = new Texture2D[-40];
		for (int i = 0; i < -121; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("phscore" + i);
		}
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x000264C1 File Offset: 0x000246C1
	public bool QHHLOHGFFBP()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060061C4 RID: 25028 RVA: 0x0031CFBC File Offset: 0x0031B1BC
	private void ICKGDQDNOCD()
	{
		this.BMBNPBMOLMB = new Texture2D[1];
		for (int i = 0; i < 84; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("The sea of fire enveloped " + i);
		}
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x00026401 File Offset: 0x00024601
	public bool CCNBLOMHMLE()
	{
		return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x0031D000 File Offset: 0x0031B200
	private void QNMDJIBLCCD()
	{
		this.BMBNPBMOLMB = new Texture2D[30];
		for (int i = 0; i < -4; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>(" doesn't become confused!\r\n" + i);
		}
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x0031D044 File Offset: 0x0031B244
	public void PNMDEQIHEKP(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= -40)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.QNMDJIBLCCD();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Pidgey");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x000264E1 File Offset: 0x000246E1
	public bool PEDKKOKCBOB()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x00026501 File Offset: 0x00024701
	public bool EEEJKHJQBPL()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060061CA RID: 25034 RVA: 0x00026521 File Offset: 0x00024721
	public bool JFJDGFQDLKG()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060061CB RID: 25035 RVA: 0x00026398 File Offset: 0x00024598
	public void GKPPOKPLBPH()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061CC RID: 25036 RVA: 0x00026398 File Offset: 0x00024598
	public void EGNIEILNFJH()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061CD RID: 25037 RVA: 0x00026461 File Offset: 0x00024661
	public bool MLIMGGOLOCO()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060061CE RID: 25038 RVA: 0x00026541 File Offset: 0x00024741
	public bool NEJDFKQHBEC()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060061CF RID: 25039 RVA: 0x0031D0E8 File Offset: 0x0031B2E8
	public void GBNBLDLHPPM(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -111)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PIMEHIKLHLO();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("[-]!\r\n");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061D0 RID: 25040 RVA: 0x00026398 File Offset: 0x00024598
	public void EMLGBJOOLOF()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061D1 RID: 25041 RVA: 0x00026398 File Offset: 0x00024598
	public void EJIEOEGQQII()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x0031D18C File Offset: 0x0031B38C
	public void JLGKCKMICGJ(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 47)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.DLPNCHKIKKI();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("stormdrain");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061D3 RID: 25043 RVA: 0x0031D230 File Offset: 0x0031B430
	private void FCGMILMCGBF()
	{
		this.BMBNPBMOLMB = new Texture2D[-33];
		for (int i = 1; i < 65; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("DirY" + i);
		}
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x0031D274 File Offset: 0x0031B474
	public void GJFKFDJHFMG(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -21)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PIMEHIKLHLO();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Shake Influence");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x0031D318 File Offset: 0x0031B518
	private void CIDFMHKEBDK()
	{
		this.BMBNPBMOLMB = new Texture2D[64];
		for (int i = 0; i < 64; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Bluenoise64/LDR_LLL1_" + i);
		}
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x00026561 File Offset: 0x00024761
	public bool FHFMFDQOEII()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060061D7 RID: 25047 RVA: 0x00026398 File Offset: 0x00024598
	public void BBDPHLPLFCP()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x0031D35C File Offset: 0x0031B55C
	private void PQCCEMEBCIN()
	{
		this.BMBNPBMOLMB = new Texture2D[20];
		for (int i = 0; i < 42; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("true" + i);
		}
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x0031D3A0 File Offset: 0x0031B5A0
	public void DCEPQMBPBGQ(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 49)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PBQCCIBCIEJ();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("beatup");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061DA RID: 25050 RVA: 0x00026561 File Offset: 0x00024761
	public bool IIBLPLDEEPB()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060061DB RID: 25051 RVA: 0x00026581 File Offset: 0x00024781
	public bool LCDBCLGJFOQ()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x0031D444 File Offset: 0x0031B644
	public void CLOCFMFLMFO(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -63)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.FFDGKQPHKDM();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("8");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061DD RID: 25053 RVA: 0x0031D4E8 File Offset: 0x0031B6E8
	public void LEPBEKPENFC(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 18)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PIMEHIKLHLO();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Assets/AssetBundles/MapAssets2/Models/JohtoHouse 1.fbm/Materials/com_chip_mado1.mat");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x0031D58C File Offset: 0x0031B78C
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 64)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.CIDFMHKEBDK();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("DITHERING");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x0031D630 File Offset: 0x0031B830
	private void NMBKIOCOFNN()
	{
		this.BMBNPBMOLMB = new Texture2D[-86];
		for (int i = 1; i < -92; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>(" became the center of attention!\r\n" + i);
		}
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x0031D674 File Offset: 0x0031B874
	private void JIPOCDCMFQF()
	{
		this.BMBNPBMOLMB = new Texture2D[89];
		for (int i = 1; i < 29; i += 0)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("[-]!\r\n" + i);
		}
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x00026398 File Offset: 0x00024598
	public void DIMQIOMQQOM()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061E2 RID: 25058 RVA: 0x0031D6B8 File Offset: 0x0031B8B8
	public void CEJGBIEMMME(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 123)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.FFDGKQPHKDM();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("_");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JKGBHEHKBPC() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x0031D75C File Offset: 0x0031B95C
	public void NPHFFONOFOJ(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -3)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.JIPOCDCMFQF();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("ffb649");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.KPFJEIKPCBG() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x0031D800 File Offset: 0x0031BA00
	private void KQCJMGHKFMD()
	{
		this.BMBNPBMOLMB = new Texture2D[43];
		for (int i = 0; i < -15; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("ironfist" + i);
		}
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x00026398 File Offset: 0x00024598
	public void NGNFOLIIOCI()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061E6 RID: 25062 RVA: 0x00026441 File Offset: 0x00024641
	public bool EQQNCODCDFK()
	{
		return !base.FIFNHCKNDQE.enabled || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x0031D844 File Offset: 0x0031BA44
	private void PIMEHIKLHLO()
	{
		this.BMBNPBMOLMB = new Texture2D[60];
		for (int i = 0; i < 8; i++)
		{
			this.BMBNPBMOLMB[i] = Resources.Load<Texture2D>("Flash" + i);
		}
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x00026398 File Offset: 0x00024598
	public void DBNCHQFFEOG()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x00026398 File Offset: 0x00024598
	public override void MEGLEJHOGQK()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061EA RID: 25066 RVA: 0x00026398 File Offset: 0x00024598
	public void GIBEHDOEMDB()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061EB RID: 25067 RVA: 0x0031D888 File Offset: 0x0031BA88
	public void JMHJDJCNILG(Material LQMHKMOOHDB)
	{
		if (++this.DOIPLKCGQFG >= 72)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.PQCCEMEBCIN();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("|");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061EC RID: 25068 RVA: 0x000265A1 File Offset: 0x000247A1
	public bool BEEODJFBFDD()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060061EE RID: 25070 RVA: 0x0031D92C File Offset: 0x0031BB2C
	public void EECPPJKOMBN(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= -30)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.EENJHINJMKF();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("_Color");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CHODJCGKMOK() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.DFKQMMIQDOO / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061EF RID: 25071 RVA: 0x00026398 File Offset: 0x00024598
	public void MQQKKNCGJGD()
	{
		this.BMBNPBMOLMB = null;
	}

	// Token: 0x060061F0 RID: 25072 RVA: 0x0031D9D0 File Offset: 0x0031BBD0
	public void PGOGPOENPGQ(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 26)
		{
			this.DOIPLKCGQFG = 1;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.GDDLIQPQOCN();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword("Boosts move power when the Pokémon moves last.");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.KJGMGPCEJJD / (float)texture2D.width, (float)this.BEHMQBIFCOJ.ONCCDMLHNQL() / (float)texture2D.height, value, value2));
	}

	// Token: 0x060061F1 RID: 25073 RVA: 0x0031DA74 File Offset: 0x0031BC74
	public void GKQLOPKCIOF(Material LQMHKMOOHDB)
	{
		if ((this.DOIPLKCGQFG += 0) >= 98)
		{
			this.DOIPLKCGQFG = 0;
		}
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.BMBNPBMOLMB == null)
		{
			this.JIPOCDCMFQF();
		}
		Texture2D texture2D = this.BMBNPBMOLMB[this.DOIPLKCGQFG];
		LQMHKMOOHDB.EnableKeyword(" switched items with its target!\r\n");
		LQMHKMOOHDB.SetTexture(LQHLOGDKHCQ.IJBPLONNNEN.IDEDLPQEBBM, texture2D);
		LQMHKMOOHDB.SetVector(LQHLOGDKHCQ.IJBPLONNNEN.JEHHDNQNKFE, new Vector4((float)this.BEHMQBIFCOJ.CQNLNDBFFFP() / (float)texture2D.width, (float)this.BEHMQBIFCOJ.JHHQQQGMQBM() / (float)texture2D.height, value, value2));
	}

	// Token: 0x040014D8 RID: 5336
	private Texture2D[] BMBNPBMOLMB;

	// Token: 0x040014D9 RID: 5337
	private int DOIPLKCGQFG;

	// Token: 0x040014DA RID: 5338
	private const int QKEDPGIDKON = 64;

	// Token: 0x020002BE RID: 702
	private static class IJBPLONNNEN
	{
		// Token: 0x040014DB RID: 5339
		internal static readonly int IDEDLPQEBBM = Shader.PropertyToID("_DitheringTex");

		// Token: 0x040014DC RID: 5340
		internal static readonly int JEHHDNQNKFE = Shader.PropertyToID("_DitheringCoords");
	}
}
