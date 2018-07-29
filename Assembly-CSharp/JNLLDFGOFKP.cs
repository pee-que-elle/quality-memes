using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002D2 RID: 722
public sealed class JNLLDFGOFKP : ONQQOCQBQIE<UserLutModel>
{
	// Token: 0x060063DA RID: 25562 RVA: 0x0032E918 File Offset: 0x0032CB18
	public bool IODDLCIHECG()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 993f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060063DB RID: 25563 RVA: 0x0032E990 File Offset: 0x0032CB90
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("USER_LUT");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1f / (float)settings.lut.width, 1f / (float)settings.lut.height, (float)settings.lut.height - 1f, settings.contribution));
	}

	// Token: 0x060063DC RID: 25564 RVA: 0x0032EA18 File Offset: 0x0032CC18
	public bool HLNQKONHMND()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 964f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060063DD RID: 25565 RVA: 0x0032EA90 File Offset: 0x0032CC90
	public void NNMLQFLMKCN()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		Rect position = new Rect(this.BEHMQBIFCOJ.BOPPGOHCMHP().x * (float)Screen.width + 834f, 1880f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063DE RID: 25566 RVA: 0x0032EAFC File Offset: 0x0032CCFC
	public bool COBEIPEMFHD()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.KNBMBCNPNLF();
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 321f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060063DF RID: 25567 RVA: 0x0032EB74 File Offset: 0x0032CD74
	public void HDPLJPCCCOH()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		Rect position = new Rect(this.BEHMQBIFCOJ.GDBEDMQFGNE.x * (float)Screen.width + 8f, 8f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063E0 RID: 25568 RVA: 0x0032EBE0 File Offset: 0x0032CDE0
	public void HFBHMPPLCJE(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		LQMHKMOOHDB.EnableKeyword(" into the sky!\r\n");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(983f / (float)settings.lut.width, 1941f / (float)settings.lut.height, (float)settings.lut.height - 644f, settings.contribution));
	}

	// Token: 0x060063E1 RID: 25569 RVA: 0x0032EC68 File Offset: 0x0032CE68
	public bool PBBQNFJELLP()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 651f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x060063E2 RID: 25570 RVA: 0x0032ECE0 File Offset: 0x0032CEE0
	public void NEFFOIJNIGG(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("Username already in use");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(532f / (float)settings.lut.width, 1575f / (float)settings.lut.height, (float)settings.lut.height - 1546f, settings.contribution));
	}

	// Token: 0x060063E3 RID: 25571 RVA: 0x0032ED68 File Offset: 0x0032CF68
	public void PQIJIJMPEFO()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		Rect position = new Rect(this.BEHMQBIFCOJ.NPOOBMGJGEB().x * (float)Screen.width + 1764f, 1037f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063E4 RID: 25572 RVA: 0x0032EDD4 File Offset: 0x0032CFD4
	public void HONQLJPLOPK()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		Rect position = new Rect(this.BEHMQBIFCOJ.FNGCCEFEGLQ().x * (float)Screen.width + 599f, 267f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063E5 RID: 25573 RVA: 0x0032EE40 File Offset: 0x0032D040
	public void CHOBOLIKNJM()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		Rect position = new Rect(this.BEHMQBIFCOJ.QEFJIQQHNEI().x * (float)Screen.width + 898f, 159f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063E6 RID: 25574 RVA: 0x0032EEAC File Offset: 0x0032D0AC
	public void BEPLNIICNEH(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		LQMHKMOOHDB.EnableKeyword("The Pokémon is charged with static electricity, so contact with it may cause paralysis.");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(985f / (float)settings.lut.width, 909f / (float)settings.lut.height, (float)settings.lut.height - 1638f, settings.contribution));
	}

	// Token: 0x060063E7 RID: 25575 RVA: 0x0032EF34 File Offset: 0x0032D134
	public void NGCDNPDQEJM()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		Rect position = new Rect(this.BEHMQBIFCOJ.BOPPGOHCMHP().x * (float)Screen.width + 1013f, 18f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063E8 RID: 25576 RVA: 0x0032EFA0 File Offset: 0x0032D1A0
	public bool DHHJCEFGDJN()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1459f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060063E9 RID: 25577 RVA: 0x0032F018 File Offset: 0x0032D218
	public bool DDPQKIGQKEE()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1170f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060063EA RID: 25578 RVA: 0x0032F090 File Offset: 0x0032D290
	public void CKBBCHNFCJG(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.KNBMBCNPNLF();
		LQMHKMOOHDB.EnableKeyword("toxicspikes");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1657f / (float)settings.lut.width, 568f / (float)settings.lut.height, (float)settings.lut.height - 1142f, settings.contribution));
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x060063EB RID: 25579 RVA: 0x0032F118 File Offset: 0x0032D318
	public override bool NGQJLIEBFOM
	{
		get
		{
			UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
			return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 0f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x060063EC RID: 25580 RVA: 0x0032F190 File Offset: 0x0032D390
	public void LPFDNCGKFCD()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		Rect position = new Rect(this.BEHMQBIFCOJ.FNGCCEFEGLQ().x * (float)Screen.width + 1138f, 628f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063ED RID: 25581 RVA: 0x0032F1FC File Offset: 0x0032D3FC
	public void MFKBJEJLDNJ(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		LQMHKMOOHDB.EnableKeyword("electricterrain");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(953f / (float)settings.lut.width, 149f / (float)settings.lut.height, (float)settings.lut.height - 1986f, settings.contribution));
	}

	// Token: 0x060063EE RID: 25582 RVA: 0x0032F284 File Offset: 0x0032D484
	public void FDMJHMNHKDI()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		Rect position = new Rect(this.BEHMQBIFCOJ.NDQOJMOOCFM().x * (float)Screen.width + 829f, 248f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063EF RID: 25583 RVA: 0x0032F2F0 File Offset: 0x0032D4F0
	public void EIIMQBGGBGF(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		LQMHKMOOHDB.EnableKeyword("_FogColor");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1856f / (float)settings.lut.width, 1384f / (float)settings.lut.height, (float)settings.lut.height - 641f, settings.contribution));
	}

	// Token: 0x060063F0 RID: 25584 RVA: 0x0032F378 File Offset: 0x0032D578
	public bool QEKKBBKKBPD()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1640f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060063F1 RID: 25585 RVA: 0x0032F3F0 File Offset: 0x0032D5F0
	public void FJPDEBIGDDQ(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		LQMHKMOOHDB.EnableKeyword("psychic");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(227f / (float)settings.lut.width, 328f / (float)settings.lut.height, (float)settings.lut.height - 749f, settings.contribution));
	}

	// Token: 0x060063F2 RID: 25586 RVA: 0x0032F478 File Offset: 0x0032D678
	public void HKCEBPEMIEF(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.KNBMBCNPNLF();
		LQMHKMOOHDB.EnableKeyword("[00DD00]Equipped");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1952f / (float)settings.lut.width, 141f / (float)settings.lut.height, (float)settings.lut.height - 1499f, settings.contribution));
	}

	// Token: 0x060063F3 RID: 25587 RVA: 0x0032F500 File Offset: 0x0032D700
	public void JIEIGPPCDIN()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		Rect position = new Rect(this.BEHMQBIFCOJ.IJCOFDDFIBD().x * (float)Screen.width + 284f, 1728f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063F4 RID: 25588 RVA: 0x0032F56C File Offset: 0x0032D76C
	public void KNIICIPCILH()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		Rect position = new Rect(this.BEHMQBIFCOJ.IJCOFDDFIBD().x * (float)Screen.width + 1255f, 380f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063F5 RID: 25589 RVA: 0x0032F5D8 File Offset: 0x0032D7D8
	public void MNDMJDOOBFQ(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		LQMHKMOOHDB.EnableKeyword("Big/");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1984f / (float)settings.lut.width, 1762f / (float)settings.lut.height, (float)settings.lut.height - 423f, settings.contribution));
	}

	// Token: 0x060063F6 RID: 25590 RVA: 0x0032F660 File Offset: 0x0032D860
	public bool NMLQJHEPGJO()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1957f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060063F7 RID: 25591 RVA: 0x0032F6D8 File Offset: 0x0032D8D8
	public bool KQIKKBHKHME()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.KNBMBCNPNLF();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1728f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060063F8 RID: 25592 RVA: 0x0032F750 File Offset: 0x0032D950
	public void DKKBDQMCPLQ()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		Rect position = new Rect(this.BEHMQBIFCOJ.IJCOFDDFIBD().x * (float)Screen.width + 1315f, 1431f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063F9 RID: 25593 RVA: 0x0032F7BC File Offset: 0x0032D9BC
	public void FCQFPKLPQPK()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		Rect position = new Rect(this.BEHMQBIFCOJ.OCQPMDOCLLB().x * (float)Screen.width + 725f, 866f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063FB RID: 25595 RVA: 0x0032F828 File Offset: 0x0032DA28
	public void BMFKEOHKHLG(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		LQMHKMOOHDB.EnableKeyword("Battle Started.");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(943f / (float)settings.lut.width, 57f / (float)settings.lut.height, (float)settings.lut.height - 1110f, settings.contribution));
	}

	// Token: 0x060063FC RID: 25596 RVA: 0x0032F8B0 File Offset: 0x0032DAB0
	public bool JBOJHCQNCMJ()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1584f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060063FD RID: 25597 RVA: 0x0032F928 File Offset: 0x0032DB28
	public bool GGBQICFGNGQ()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1777f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060063FE RID: 25598 RVA: 0x0032F9A0 File Offset: 0x0032DBA0
	public void HKFBJMEKDHG()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		Rect position = new Rect(this.BEHMQBIFCOJ.OCQPMDOCLLB().x * (float)Screen.width + 373f, 1750f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x060063FF RID: 25599 RVA: 0x0032FA0C File Offset: 0x0032DC0C
	public void HNIKQEHIOBJ()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.POHNNDKPEDF();
		Rect position = new Rect(this.BEHMQBIFCOJ.GDBEDMQFGNE.x * (float)Screen.width + 468f, 1720f, (float)settings.lut.width, (float)settings.lut.height);
		GUI.DrawTexture(position, settings.lut);
	}

	// Token: 0x06006400 RID: 25600 RVA: 0x0032FA78 File Offset: 0x0032DC78
	public bool EQQNCODCDFK()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.OILMJDEQKHM();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 299f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006401 RID: 25601 RVA: 0x0032FAF0 File Offset: 0x0032DCF0
	public bool PNPPMEDQGCG()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1351f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x06006402 RID: 25602 RVA: 0x0032FB68 File Offset: 0x0032DD68
	public bool MMFCHMLIDLO()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 272f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006403 RID: 25603 RVA: 0x0032FBE0 File Offset: 0x0032DDE0
	public bool EEEJKHJQBPL()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 577f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006404 RID: 25604 RVA: 0x0032FC58 File Offset: 0x0032DE58
	public void LEBDPJJPFBB(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.HKOKEQMOINC();
		LQMHKMOOHDB.EnableKeyword("flowerveil");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(898f / (float)settings.lut.width, 232f / (float)settings.lut.height, (float)settings.lut.height - 344f, settings.contribution));
	}

	// Token: 0x06006405 RID: 25605 RVA: 0x0032FCE0 File Offset: 0x0032DEE0
	public bool KJNQOOQQDDO()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		return !base.FIFNHCKNDQE.enabled || !(settings.lut != null) || settings.contribution <= 1980f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006406 RID: 25606 RVA: 0x0032FD58 File Offset: 0x0032DF58
	public bool EPEEBMIMHDB()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.KNBMBCNPNLF();
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 462f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006407 RID: 25607 RVA: 0x0032FDD0 File Offset: 0x0032DFD0
	public void EPKBGOOFGIO(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.settings;
		LQMHKMOOHDB.EnableKeyword("(E)");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(1934f / (float)settings.lut.width, 1477f / (float)settings.lut.height, (float)settings.lut.height - 344f, settings.contribution));
	}

	// Token: 0x06006408 RID: 25608 RVA: 0x0032FE58 File Offset: 0x0032E058
	public void PEKQOCCPHLD(Material LQMHKMOOHDB)
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.LPNEBDNLDDB();
		LQMHKMOOHDB.EnableKeyword("magiccoat");
		LQMHKMOOHDB.SetTexture(JNLLDFGOFKP.GJKJQHOOHBO.CCLPPCQOIHH, settings.lut);
		LQMHKMOOHDB.SetVector(JNLLDFGOFKP.GJKJQHOOHBO.LCGLBMFEQFD, new Vector4(556f / (float)settings.lut.width, 1089f / (float)settings.lut.height, (float)settings.lut.height - 1646f, settings.contribution));
	}

	// Token: 0x06006409 RID: 25609 RVA: 0x0032FEE0 File Offset: 0x0032E0E0
	public bool PEDKKOKCBOB()
	{
		UserLutModel.Settings settings = base.FIFNHCKNDQE.QLIGQMEDNJC();
		return base.FIFNHCKNDQE.enabled && settings.lut != null && settings.contribution > 1059f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x020002D3 RID: 723
	private static class GJKJQHOOHBO
	{
		// Token: 0x0400156A RID: 5482
		internal static readonly int CCLPPCQOIHH = Shader.PropertyToID("_UserLut");

		// Token: 0x0400156B RID: 5483
		internal static readonly int LCGLBMFEQFD = Shader.PropertyToID("_UserLut_Params");
	}
}
