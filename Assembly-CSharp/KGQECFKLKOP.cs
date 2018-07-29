using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000250 RID: 592
public static class KGQECFKLKOP
{
	// Token: 0x06005112 RID: 20754 RVA: 0x002A2560 File Offset: 0x002A0760
	public static void HIKEIBKLDOQ(this Transform NPKDOHINPHI, Vector3 PELLENMFKHG)
	{
		NPKDOHINPHI.localScale = Vector3.one;
		NPKDOHINPHI.localScale = new Vector3(PELLENMFKHG.x / NPKDOHINPHI.lossyScale.x, PELLENMFKHG.y / NPKDOHINPHI.lossyScale.y, PELLENMFKHG.z / NPKDOHINPHI.lossyScale.z);
	}

	// Token: 0x06005113 RID: 20755 RVA: 0x002A25C8 File Offset: 0x002A07C8
	public static Transform KQQJCMQCFMN(this Transform BJPEOMNKCPC, string NBDLNFBCLIO)
	{
		Transform transform = BJPEOMNKCPC.Find(NBDLNFBCLIO);
		if (transform != null)
		{
			return transform;
		}
		IEnumerator enumerator = BJPEOMNKCPC.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform bjpeomnkcpc = (Transform)obj;
				transform = bjpeomnkcpc.KQQJCMQCFMN(NBDLNFBCLIO);
				if (transform != null)
				{
					return transform;
				}
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
		return BJPEOMNKCPC;
	}

	// Token: 0x06005114 RID: 20756 RVA: 0x000206F5 File Offset: 0x0001E8F5
	public static bool IBJHJDHKJKL(this string JMDLLJPEFKM)
	{
		return JMDLLJPEFKM.Contains("Primitive");
	}

	// Token: 0x06005115 RID: 20757 RVA: 0x002A2644 File Offset: 0x002A0844
	public static string LGGPFIJQHOM(string NQFQGCGPHBE)
	{
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[red]", "[FF0000]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[green]", MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[2]);
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[blue]", MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[1]);
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[orange]", "[ff9900]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[yellow]", "[ffff00]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[purple]", MDBOHBDKMMM.QOQONHOOLNE.IEHHHBCDIOH[0]);
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[white]", "[ffffff]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[EOL]", "\n");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[eol]", "\n");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[common]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[0]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[uncommon]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[1]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[rare]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[2]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[epic]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[3]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[mythical]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[4]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[special]", "[" + KGQECFKLKOP.PCLCOFCKINO(MDBOHBDKMMM.QOQONHOOLNE.EGLLCPNBQIG[5]) + "]");
		NQFQGCGPHBE = NQFQGCGPHBE.Replace("[/]", "[-]");
		return NQFQGCGPHBE;
	}

	// Token: 0x06005116 RID: 20758 RVA: 0x002A2860 File Offset: 0x002A0A60
	public static int FHKHCIOMFEE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		int num = FFJJCIQPLOP.DGOCNDGDBOJ.JOJCLQMGJJP;
		num += FFJJCIQPLOP.DGOCNDGDBOJ.EOCPIGECLCM;
		num += FFJJCIQPLOP.DGOCNDGDBOJ.BLHBPGMPPNI;
		num += FFJJCIQPLOP.DGOCNDGDBOJ.OCNKGBBOOHF;
		num += FFJJCIQPLOP.DGOCNDGDBOJ.PFDGJOLJEHC;
		num += FFJJCIQPLOP.DGOCNDGDBOJ.OHGEFICKJJN;
		if (num < 48)
		{
			return 0;
		}
		if (num < 84)
		{
			return 1;
		}
		if (num < 108)
		{
			return 2;
		}
		if (num < 132)
		{
			return 3;
		}
		if (num < 156)
		{
			return 4;
		}
		if (num < 180)
		{
			return 5;
		}
		if (num >= 180)
		{
			return 5;
		}
		return 0;
	}

	// Token: 0x06005117 RID: 20759 RVA: 0x002A2900 File Offset: 0x002A0B00
	public static int PJFQQHNJMFM(int NPBLFIMGOPL, KGQECFKLKOP.EMEQCLNIHNL DQDFBDCLFKF)
	{
		double num = (double)(NPBLFIMGOPL * NPBLFIMGOPL * NPBLFIMGOPL);
		switch (DQDFBDCLFKF)
		{
		case KGQECFKLKOP.EMEQCLNIHNL.Erratic:
			if (NPBLFIMGOPL < 50)
			{
				return (int)(num * (double)(100 - NPBLFIMGOPL) / 50.0);
			}
			if (NPBLFIMGOPL < 68)
			{
				return (int)(num * (double)(150 - NPBLFIMGOPL) / 100.0);
			}
			if (NPBLFIMGOPL < 98)
			{
				return (int)(num * (double)((1911 - 10 * NPBLFIMGOPL) / 3) / 500.0);
			}
			return (int)(num * (double)(160 - NPBLFIMGOPL) / 100.0);
		case KGQECFKLKOP.EMEQCLNIHNL.Fast:
			return (int)(0.8 * num);
		case KGQECFKLKOP.EMEQCLNIHNL.MediumFast:
			return (int)num;
		case KGQECFKLKOP.EMEQCLNIHNL.MediumSlow:
			return (int)(1.2 * num) - 15 * NPBLFIMGOPL * NPBLFIMGOPL + 100 * NPBLFIMGOPL - 140;
		case KGQECFKLKOP.EMEQCLNIHNL.Slow:
			return (int)(1.25 * num);
		case KGQECFKLKOP.EMEQCLNIHNL.Fluctuating:
			if (NPBLFIMGOPL < 15)
			{
				return (int)(num * (double)(((NPBLFIMGOPL + 1) / 3 + 24) / 50));
			}
			if (NPBLFIMGOPL < 36)
			{
				return (int)(num * (double)((NPBLFIMGOPL + 14) / 50));
			}
			return (int)(num * (double)((NPBLFIMGOPL / 2 + 32) / 50));
		default:
			return 0;
		}
	}

	// Token: 0x06005118 RID: 20760 RVA: 0x002A2A10 File Offset: 0x002A0C10
	public static Color JJQFHKDMDOL(string LOHECPFGPGO)
	{
		if (LOHECPFGPGO != null && !(LOHECPFGPGO == string.Empty))
		{
			LOHECPFGPGO = LOHECPFGPGO.Replace("(", string.Empty);
			LOHECPFGPGO = LOHECPFGPGO.Replace(")", string.Empty);
			LOHECPFGPGO = LOHECPFGPGO.Replace("RGBA", string.Empty);
			LOHECPFGPGO = LOHECPFGPGO.Replace(", ", "!");
			LOHECPFGPGO = LOHECPFGPGO.Replace(",", ".");
			string[] array = LOHECPFGPGO.Split(new char[]
			{
				'!'
			});
			return new Color(float.Parse(array[0].Replace(",", "."), CultureInfo.InvariantCulture), float.Parse(array[1].Replace(",", "."), CultureInfo.InvariantCulture), float.Parse(array[2].Replace(",", "."), CultureInfo.InvariantCulture), float.Parse(array[3].Replace(",", "."), CultureInfo.InvariantCulture));
		}
		return Color.white;
	}

	// Token: 0x06005119 RID: 20761 RVA: 0x00020707 File Offset: 0x0001E907
	public static string PCLCOFCKINO(Color KQFEHQEBJQB)
	{
		return ColorUtility.ToHtmlStringRGB(KQFEHQEBJQB).Replace("#", string.Empty);
	}

	// Token: 0x0600511A RID: 20762 RVA: 0x002A2B1C File Offset: 0x002A0D1C
	public static string HHCGODNQJOP(TimeSpan OQJFBJQJEFG)
	{
		string text = string.Empty;
		if (OQJFBJQJEFG.Days <= 1 && OQJFBJQJEFG.Days != 0)
		{
			text = text + OQJFBJQJEFG.Days.ToString() + " day, ";
		}
		else
		{
			text = text + OQJFBJQJEFG.Days.ToString() + " days, ";
		}
		if (OQJFBJQJEFG.Hours <= 1 && OQJFBJQJEFG.Hours != 0)
		{
			text = text + OQJFBJQJEFG.Hours.ToString() + " hr, ";
		}
		else
		{
			text = text + OQJFBJQJEFG.Hours.ToString() + " hrs, ";
		}
		if (OQJFBJQJEFG.Minutes <= 1 && OQJFBJQJEFG.Minutes != 0)
		{
			text = text + OQJFBJQJEFG.Minutes.ToString() + " min";
		}
		else
		{
			text = text + OQJFBJQJEFG.Minutes.ToString() + " mins";
		}
		return text;
	}

	// Token: 0x0600511B RID: 20763 RVA: 0x002A2C38 File Offset: 0x002A0E38
	public static string MPMOFEFLJLE(TimeSpan OQJFBJQJEFG)
	{
		if (OQJFBJQJEFG.Days > 1)
		{
			return OQJFBJQJEFG.Days.ToString() + "d";
		}
		if (OQJFBJQJEFG.Hours > 1)
		{
			return OQJFBJQJEFG.Hours.ToString() + "hr";
		}
		if (OQJFBJQJEFG.Minutes > 1)
		{
			return OQJFBJQJEFG.Minutes.ToString() + "m";
		}
		return OQJFBJQJEFG.Seconds.ToString() + "s";
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x002A2CE4 File Offset: 0x002A0EE4
	public static string PBKLDIHQLGE(int CIQFCJGQEMH)
	{
		switch (CIQFCJGQEMH)
		{
		case 1:
			return "Boulder Badge";
		case 2:
			return "Cascade Badge";
		case 3:
			return "Thunder Badge";
		case 4:
			return "Rainbow Badge";
		case 5:
			return "Soul Badge";
		case 6:
			return "Marsh Badge";
		case 7:
			return "Volcano Badge";
		case 8:
			return "Earth Badge";
		case 9:
			return "Zephyr Badge";
		case 10:
			return "Hive Badge";
		case 11:
			return "Plain Badge";
		case 12:
			return "Fog Badge";
		case 13:
			return "Storm Badge";
		case 14:
			return "Mineral Badge";
		case 15:
			return "Glacier Badge";
		case 16:
			return "Rising Badge";
		case 17:
			return "Stone Badge";
		case 18:
			return "Knuckle Badge";
		case 19:
			return "Dynamo Badge";
		case 20:
			return "Heat Badge";
		case 21:
			return "Balance Badge";
		case 22:
			return "Feather Badge";
		case 23:
			return "Mind Badge";
		case 24:
			return "Rain Badge";
		case 25:
			return "Coal Badge";
		case 26:
			return "Forest Badge";
		case 27:
			return "Cobble Badge";
		case 28:
			return "Fen Badge";
		case 29:
			return "Relic Badge";
		case 30:
			return "Mine Badge";
		case 31:
			return "Icicle Badge";
		case 32:
			return "Beacon Badge";
		default:
			return string.Empty;
		}
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x0002071E File Offset: 0x0001E91E
	public static string QQKICQQBIJL(this int IGBFFCJCFBG)
	{
		if (IGBFFCJCFBG < 10)
		{
			return "0" + IGBFFCJCFBG.ToString();
		}
		return IGBFFCJCFBG.ToString();
	}

	// Token: 0x0600511E RID: 20766 RVA: 0x002A2E40 File Offset: 0x002A1040
	public static string DBFPJOCLQBI(this int IGBFFCJCFBG)
	{
		if (IGBFFCJCFBG < 10)
		{
			return "00" + IGBFFCJCFBG.ToString();
		}
		if (IGBFFCJCFBG < 100)
		{
			return "0" + IGBFFCJCFBG.ToString();
		}
		return IGBFFCJCFBG.ToString();
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x002A2E94 File Offset: 0x002A1094
	public static string EBGLBFKHCJD(this int IGBFFCJCFBG)
	{
		if (IGBFFCJCFBG < 10)
		{
			return "0000" + IGBFFCJCFBG.ToString();
		}
		if (IGBFFCJCFBG < 100)
		{
			return "000" + IGBFFCJCFBG.ToString();
		}
		if (IGBFFCJCFBG < 1000)
		{
			return "00" + IGBFFCJCFBG.ToString();
		}
		if (IGBFFCJCFBG < 10000)
		{
			return "0" + IGBFFCJCFBG.ToString();
		}
		return IGBFFCJCFBG.ToString();
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x0002074A File Offset: 0x0001E94A
	public static string QQKICQQBIJL(this byte IGBFFCJCFBG)
	{
		if (IGBFFCJCFBG < 10)
		{
			return "0" + IGBFFCJCFBG.ToString();
		}
		return IGBFFCJCFBG.ToString();
	}

	// Token: 0x06005121 RID: 20769 RVA: 0x002A2F28 File Offset: 0x002A1128
	public static bool HGBIQHBEBHF(this string JMDLLJPEFKM)
	{
		float num;
		return float.TryParse(JMDLLJPEFKM, out num);
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x002A2F40 File Offset: 0x002A1140
	public static void NMBPDMIIHJB(this Transform KJIHDMEHLIH)
	{
		IEnumerator enumerator = KJIHDMEHLIH.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				Transform transform = (Transform)obj;
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		finally
		{
			IDisposable disposable;
			if ((disposable = (enumerator as IDisposable)) != null)
			{
				disposable.Dispose();
			}
		}
	}

	// Token: 0x06005123 RID: 20771 RVA: 0x002A2F9C File Offset: 0x002A119C
	public static KGQECFKLKOP.Item BFNBQBMJHFL(int CIQFCJGQEMH)
	{
		for (int i = 0; i < KGQECFKLKOP.CNNFBFLDLLO.items.Length; i++)
		{
			if (KGQECFKLKOP.CNNFBFLDLLO.items[i].ID == CIQFCJGQEMH)
			{
				return KGQECFKLKOP.CNNFBFLDLLO.items[i];
			}
		}
		return KGQECFKLKOP.CNNFBFLDLLO.items[0];
	}

	// Token: 0x06005124 RID: 20772 RVA: 0x002A2FF0 File Offset: 0x002A11F0
	public static KGQECFKLKOP.ModelID CEKEFONEMIK(int CIQFCJGQEMH)
	{
		for (int i = 0; i < KGQECFKLKOP.PBOFHGEQIKO.Pokemon.Length; i++)
		{
			if (KGQECFKLKOP.PBOFHGEQIKO.Pokemon[i].ID == CIQFCJGQEMH)
			{
				return KGQECFKLKOP.PBOFHGEQIKO.Pokemon[i];
			}
		}
		return null;
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x002A3038 File Offset: 0x002A1238
	public static void GKHNLKOPGGD()
	{
		TextAsset textAsset = Resources.Load<TextAsset>("Pokemon3D/Index");
		KGQECFKLKOP.GLFOCQDNHQC = Encoding.UTF8.GetString(textAsset.bytes).Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		KGQECFKLKOP.CNNFBFLDLLO = new KGQECFKLKOP.BPHCGQMPMKB();
		KGQECFKLKOP.EEILBMOOJHJ = new KGQECFKLKOP.GLNPQNLFKBQ();
		KGQECFKLKOP.PBOFHGEQIKO = new KGQECFKLKOP.DKBCOJFQJHB();
		TextAsset textAsset2 = (TextAsset)Resources.Load("Data/items");
		KGQECFKLKOP.CNNFBFLDLLO = JsonConvert.DeserializeObject<KGQECFKLKOP.BPHCGQMPMKB>(Encoding.UTF8.GetString(textAsset2.bytes));
		TextAsset textAsset3 = (TextAsset)Resources.Load("Data/moves");
		KGQECFKLKOP.EEILBMOOJHJ = JsonConvert.DeserializeObject<KGQECFKLKOP.GLNPQNLFKBQ>(Encoding.UTF8.GetString(textAsset3.bytes));
		TextAsset textAsset4 = (TextAsset)Resources.Load("Data/pokemon");
		KGQECFKLKOP.DDBIKNCLDGI = JsonConvert.DeserializeObject<KGQECFKLKOP.JPBJIJCKOBG>(Encoding.UTF8.GetString(textAsset4.bytes));
		TextAsset textAsset5 = (TextAsset)Resources.Load("Data/pokemonmodels");
		KGQECFKLKOP.PBOFHGEQIKO = JsonConvert.DeserializeObject<KGQECFKLKOP.DKBCOJFQJHB>(Encoding.UTF8.GetString(textAsset5.bytes));
		TextAsset textAsset6 = (TextAsset)Resources.Load("Data/learnsets");
		KGQECFKLKOP.OEFKBDGIFBL = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string[]>>>>(Encoding.UTF8.GetString(textAsset6.bytes));
		for (int i = 0; i < KGQECFKLKOP.CNNFBFLDLLO.items.Length; i++)
		{
			KGQECFKLKOP.CNNFBFLDLLO.items[i].ItemImage--;
		}
		KGQECFKLKOP.PGBCDJLIDOK = new List<KGQECFKLKOP.KINDLGJMPDI>();
		KGQECFKLKOP.KINDLGJMPDI kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Adaptability";
		kindlgjmpdi.DBPKNCDGGEP = "adaptability";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up moves of the same type as the Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Aerilate";
		kindlgjmpdi.DBPKNCDGGEP = "aerilate";
		kindlgjmpdi.KFFQQDLOLLQ = "Normal-type moves become Flying-type moves. The power of those moves is boosted a little.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Aftermath";
		kindlgjmpdi.DBPKNCDGGEP = "aftermath";
		kindlgjmpdi.KFFQQDLOLLQ = "Damages the attacker if it contacts the Pokémon with a finishing hit.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Air Lock";
		kindlgjmpdi.DBPKNCDGGEP = "airlock";
		kindlgjmpdi.KFFQQDLOLLQ = "Eliminates the effects of weather.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Analytic";
		kindlgjmpdi.DBPKNCDGGEP = "analytic";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts move power when the Pokémon moves last.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Anger Point";
		kindlgjmpdi.DBPKNCDGGEP = "angerpoint";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is angered when it takes a critical hit, and that maxes its Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Anticipation";
		kindlgjmpdi.DBPKNCDGGEP = "anticipation";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can sense an opposing Pokémon's dangerous moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Arena Trap";
		kindlgjmpdi.DBPKNCDGGEP = "arenatrap";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents opposing Pokémon from fleeing.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Aroma Veil";
		kindlgjmpdi.DBPKNCDGGEP = "aromaveil";
		kindlgjmpdi.KFFQQDLOLLQ = "Protects itself and its allies from attacks that limit their move choices.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Aura Break";
		kindlgjmpdi.DBPKNCDGGEP = "aurabreak";
		kindlgjmpdi.KFFQQDLOLLQ = "The effects of 'Aura' Abilities are reversed to lower the power of affected moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Bad Dreams";
		kindlgjmpdi.DBPKNCDGGEP = "baddreams";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the HP of sleeping opposing Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Battery";
		kindlgjmpdi.DBPKNCDGGEP = "battery";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up ally Pokémon's special moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Battle Armor";
		kindlgjmpdi.DBPKNCDGGEP = "battlearmor";
		kindlgjmpdi.KFFQQDLOLLQ = "Hard armor protects the Pokémon from critical hits.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Battle Bond";
		kindlgjmpdi.DBPKNCDGGEP = "battlebond";
		kindlgjmpdi.KFFQQDLOLLQ = "Defeating an opposing Pokémon strengthens the Pokémon's bond with its Trainer, and it becomes Ash-Greninja. Water Shuriken gets more powerful.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Beast Boost";
		kindlgjmpdi.DBPKNCDGGEP = "beastboost";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon boosts its most proficient stat each time it knocks out a Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Berserk";
		kindlgjmpdi.DBPKNCDGGEP = "berserk";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Sp. Atk stat when it takes a hit that causes its HP to become half or less.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Big Pecks";
		kindlgjmpdi.DBPKNCDGGEP = "bigpecks";
		kindlgjmpdi.KFFQQDLOLLQ = "Protects the Pokémon from Defense-lowering effects.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Blaze";
		kindlgjmpdi.DBPKNCDGGEP = "blaze";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up Fire-type moves when the Pokémon's HP is low.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Bulletproof";
		kindlgjmpdi.DBPKNCDGGEP = "bulletproof";
		kindlgjmpdi.KFFQQDLOLLQ = "Protects the Pokémon from some ball and bomb moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Cacophony";
		kindlgjmpdi.DBPKNCDGGEP = "cacophony";
		kindlgjmpdi.KFFQQDLOLLQ = "Avoids sound-based moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Cheek Pouch";
		kindlgjmpdi.DBPKNCDGGEP = "cheekpouch";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores HP as well when the Pokémon eats a Berry.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Chlorophyll";
		kindlgjmpdi.DBPKNCDGGEP = "chlorophyll";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Speed stat in sunshine.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Clear Body";
		kindlgjmpdi.DBPKNCDGGEP = "clearbody";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Cloud Nine";
		kindlgjmpdi.DBPKNCDGGEP = "cloudnine";
		kindlgjmpdi.KFFQQDLOLLQ = "Eliminates the effects of weather.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Color Change";
		kindlgjmpdi.DBPKNCDGGEP = "colorchange";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's type becomes the type of the move used on it.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Comatose";
		kindlgjmpdi.DBPKNCDGGEP = "comatose";
		kindlgjmpdi.KFFQQDLOLLQ = "It's always drowsing and will never wake up. It can attack without waking up.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Competitive";
		kindlgjmpdi.DBPKNCDGGEP = "competitive";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Sp. Atk stat sharply when a stat is lowered.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Compound Eyes";
		kindlgjmpdi.DBPKNCDGGEP = "compoundeyes";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's compound eyes boost its accuracy.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Contrary";
		kindlgjmpdi.DBPKNCDGGEP = "contrary";
		kindlgjmpdi.KFFQQDLOLLQ = "Makes stat changes have an opposite effect.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Corrosion";
		kindlgjmpdi.DBPKNCDGGEP = "corrosion";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can poison the target even if it's a Steel or Poison type.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Cursed Body";
		kindlgjmpdi.DBPKNCDGGEP = "cursedbody";
		kindlgjmpdi.KFFQQDLOLLQ = "May disable a move used on the Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Cute Charm";
		kindlgjmpdi.DBPKNCDGGEP = "cutecharm";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon may cause infatuation.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Damp";
		kindlgjmpdi.DBPKNCDGGEP = "damp";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents the use of explosive moves such as Self-Destruct by dampening its surroundings.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Dancer";
		kindlgjmpdi.DBPKNCDGGEP = "dancer";
		kindlgjmpdi.KFFQQDLOLLQ = "When another Pokémon uses a dance move, it can use a dance move following it regardless of its Speed.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Dark Aura";
		kindlgjmpdi.DBPKNCDGGEP = "darkaura";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up each Pokémon's Dark-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Dazzling";
		kindlgjmpdi.DBPKNCDGGEP = "dazzling";
		kindlgjmpdi.KFFQQDLOLLQ = "Surprises the opposing Pokémon, making it unable to attack using priority moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Defeatist";
		kindlgjmpdi.DBPKNCDGGEP = "defeatist";
		kindlgjmpdi.KFFQQDLOLLQ = "Halves the Pokémon's Attack and Sp. Atk stats when its HP becomes half or less.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Defiant";
		kindlgjmpdi.DBPKNCDGGEP = "defiant";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Attack stat sharply when its stats are lowered.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Delta Stream";
		kindlgjmpdi.DBPKNCDGGEP = "deltastream";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Desolate Land";
		kindlgjmpdi.DBPKNCDGGEP = "desolateland";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon changes the weather to nullify Water-type attacks.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Disguise";
		kindlgjmpdi.DBPKNCDGGEP = "disguise";
		kindlgjmpdi.KFFQQDLOLLQ = "Once per battle, the shroud that covers the Pokémon can protect it from an attack.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Download";
		kindlgjmpdi.DBPKNCDGGEP = "download";
		kindlgjmpdi.KFFQQDLOLLQ = "Compares an opposing Pokémon's Defense and Sp. Def stats before raising its own Attack or Sp. Atk stat—whichever will be more effective.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Drizzle";
		kindlgjmpdi.DBPKNCDGGEP = "drizzle";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon makes it rain when it enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Drought";
		kindlgjmpdi.DBPKNCDGGEP = "drought";
		kindlgjmpdi.KFFQQDLOLLQ = "Turns the sunlight harsh when the Pokémon enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Dry Skin";
		kindlgjmpdi.DBPKNCDGGEP = "dryskin";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores HP in rain or when hit by Water-type moves. Reduces HP in sunshine, and increases the damage received from Fire-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Early Bird";
		kindlgjmpdi.DBPKNCDGGEP = "earlybird";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon awakens twice as fast as other Pokémon from sleep.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Effect Spore";
		kindlgjmpdi.DBPKNCDGGEP = "effectspore";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon may inflict poison, sleep, or paralysis on its attacker.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Electric Surge";
		kindlgjmpdi.DBPKNCDGGEP = "electricsurge";
		kindlgjmpdi.KFFQQDLOLLQ = "Turns the ground into Electric Terrain when the Pokémon enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Emergency Exit";
		kindlgjmpdi.DBPKNCDGGEP = "emergencyexit";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon, sensing danger, switches out when its HP becomes half or less.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Fairy Aura";
		kindlgjmpdi.DBPKNCDGGEP = "fairyaura";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up each Pokémon's Fairy-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Filter";
		kindlgjmpdi.DBPKNCDGGEP = "filter";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the power of supereffective attacks taken.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Flame Body";
		kindlgjmpdi.DBPKNCDGGEP = "flamebody";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon may burn the attacker.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Flare Boost";
		kindlgjmpdi.DBPKNCDGGEP = "flareboost";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up special attacks when the Pokémon is burned.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Flash Fire";
		kindlgjmpdi.DBPKNCDGGEP = "flashfire";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up the Pokémon's Fire-type moves if it's hit by one.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Flower Gift";
		kindlgjmpdi.DBPKNCDGGEP = "flowergift";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Attack and Sp. Def stats of itself and allies when it is sunny.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Flower Veil";
		kindlgjmpdi.DBPKNCDGGEP = "flowerveil";
		kindlgjmpdi.KFFQQDLOLLQ = "Ally Grass-type Pokémon are protected from status conditions and the lowering of their stats.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Fluffy";
		kindlgjmpdi.DBPKNCDGGEP = "fluffy";
		kindlgjmpdi.KFFQQDLOLLQ = "Halves the damage taken from moves that make direct contact, but doubles that of Fire-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Forecast";
		kindlgjmpdi.DBPKNCDGGEP = "forecast";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon transforms with the weather to change its type to Water, Fire, or Ice.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Forewarn";
		kindlgjmpdi.DBPKNCDGGEP = "forewarn";
		kindlgjmpdi.KFFQQDLOLLQ = "When it enters a battle, the Pokémon can tell one of the moves an opposing Pokémon has.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Friend Guard";
		kindlgjmpdi.DBPKNCDGGEP = "friendguard";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces damage done to allies.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Frisk";
		kindlgjmpdi.DBPKNCDGGEP = "frisk";
		kindlgjmpdi.KFFQQDLOLLQ = "When it enters a battle, the Pokémon can check an opposing Pokémon's held item.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Full Metal Body";
		kindlgjmpdi.DBPKNCDGGEP = "fullmetalbody";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents other Pokémon's moves or Abilities from lowering the Pokémon's stats.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Fur Coat";
		kindlgjmpdi.DBPKNCDGGEP = "furcoat";
		kindlgjmpdi.KFFQQDLOLLQ = "Halves the damage from physical moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Gale Wings";
		kindlgjmpdi.DBPKNCDGGEP = "galewings";
		kindlgjmpdi.KFFQQDLOLLQ = "Gives priority to Flying-type moves when the Pokémon's HP is full.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Galvanize";
		kindlgjmpdi.DBPKNCDGGEP = "galvanize";
		kindlgjmpdi.KFFQQDLOLLQ = "Normal-type moves become Electric-type moves. The power of those moves is boosted a little.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Gluttony";
		kindlgjmpdi.DBPKNCDGGEP = "gluttony";
		kindlgjmpdi.KFFQQDLOLLQ = "Makes the Pokémon eat a held Berry when its HP drops to half or less, which is sooner than usual.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Gooey";
		kindlgjmpdi.DBPKNCDGGEP = "gooey";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon lowers the attacker's Speed stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Grass Pelt";
		kindlgjmpdi.DBPKNCDGGEP = "grasspelt";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Defense stat in Grassy Terrain.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Grassy Surge";
		kindlgjmpdi.DBPKNCDGGEP = "grassysurge";
		kindlgjmpdi.KFFQQDLOLLQ = "Turns the ground into Grassy Terrain when the Pokémon enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Guts";
		kindlgjmpdi.DBPKNCDGGEP = "guts";
		kindlgjmpdi.KFFQQDLOLLQ = "It's so gutsy that having a status condition boosts the Pokémon's Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Harvest";
		kindlgjmpdi.DBPKNCDGGEP = "harvest";
		kindlgjmpdi.KFFQQDLOLLQ = "May create another Berry after one is used.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Healer";
		kindlgjmpdi.DBPKNCDGGEP = "healer";
		kindlgjmpdi.KFFQQDLOLLQ = "Sometimes heals an ally's status condition.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Heatproof";
		kindlgjmpdi.DBPKNCDGGEP = "heatproof";
		kindlgjmpdi.KFFQQDLOLLQ = "The heatproof body of the Pokémon halves the damage from Fire-type moves that hit it.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Heavy Metal";
		kindlgjmpdi.DBPKNCDGGEP = "heavymetal";
		kindlgjmpdi.KFFQQDLOLLQ = "Doubles the Pokémon's weight.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Honey Gather";
		kindlgjmpdi.DBPKNCDGGEP = "honeygather";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon may gather Honey after a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Huge Power";
		kindlgjmpdi.DBPKNCDGGEP = "hugepower";
		kindlgjmpdi.KFFQQDLOLLQ = "Doubles the Pokémon's Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Hustle";
		kindlgjmpdi.DBPKNCDGGEP = "hustle";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Attack stat, but lowers accuracy.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Hydration";
		kindlgjmpdi.DBPKNCDGGEP = "hydration";
		kindlgjmpdi.KFFQQDLOLLQ = "Heals status conditions if it's raining.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Hyper Cutter";
		kindlgjmpdi.DBPKNCDGGEP = "hypercutter";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's proud of its powerful pincers. They prevent other Pokémon from lowering its Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Ice Body";
		kindlgjmpdi.DBPKNCDGGEP = "icebody";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon gradually regains HP in a hailstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Illuminate";
		kindlgjmpdi.DBPKNCDGGEP = "illuminate";
		kindlgjmpdi.KFFQQDLOLLQ = "Raises the likelihood of meeting wild Pokémon by illuminating the surroundings.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Illusion";
		kindlgjmpdi.DBPKNCDGGEP = "illusion";
		kindlgjmpdi.KFFQQDLOLLQ = "Comes out disguised as the Pokémon in the party's last spot.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Immunity";
		kindlgjmpdi.DBPKNCDGGEP = "immunity";
		kindlgjmpdi.KFFQQDLOLLQ = "The immune system of the Pokémon prevents it from getting poisoned.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Imposter";
		kindlgjmpdi.DBPKNCDGGEP = "imposter";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon transforms itself into the Pokémon it's facing.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Infiltrator";
		kindlgjmpdi.DBPKNCDGGEP = "infiltrator";
		kindlgjmpdi.KFFQQDLOLLQ = "Passes through the opposing Pokémon's barrier, substitute, and the like and strikes.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Innards Out";
		kindlgjmpdi.DBPKNCDGGEP = "innardsout";
		kindlgjmpdi.KFFQQDLOLLQ = "Damages the attacker landing the finishing hit by the amount equal to its last HP.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Inner Focus";
		kindlgjmpdi.DBPKNCDGGEP = "innerfocus";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's intensely focused, and that protects the Pokémon from flinching.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Insomnia";
		kindlgjmpdi.DBPKNCDGGEP = "insomnia";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is suffering from insomnia and cannot fall asleep.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Intimidate";
		kindlgjmpdi.DBPKNCDGGEP = "intimidate";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon intimidates opposing Pokémon upon entering battle, lowering their Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Iron Barbs";
		kindlgjmpdi.DBPKNCDGGEP = "ironbarbs";
		kindlgjmpdi.KFFQQDLOLLQ = "Inflicts damage to the attacker on contact with iron barbs.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Iron Fist";
		kindlgjmpdi.DBPKNCDGGEP = "ironfist";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up punching moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Justified";
		kindlgjmpdi.DBPKNCDGGEP = "justified";
		kindlgjmpdi.KFFQQDLOLLQ = "Being hit by a Dark-type move boosts the Attack stat of the Pokémon, for justice.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Keen Eye";
		kindlgjmpdi.DBPKNCDGGEP = "keeneye";
		kindlgjmpdi.KFFQQDLOLLQ = "Keen eyes prevent other Pokémon from lowering this Pokémon's accuracy.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Klutz";
		kindlgjmpdi.DBPKNCDGGEP = "klutz";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can't use any held items.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Leaf Guard";
		kindlgjmpdi.DBPKNCDGGEP = "leafguard";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents status conditions in sunny weather.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Levitate";
		kindlgjmpdi.DBPKNCDGGEP = "levitate";
		kindlgjmpdi.KFFQQDLOLLQ = "By floating in the air, the Pokémon receives full immunity to all Ground-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Light Metal";
		kindlgjmpdi.DBPKNCDGGEP = "lightmetal";
		kindlgjmpdi.KFFQQDLOLLQ = "Halves the Pokémon's weight.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Lightning Rod";
		kindlgjmpdi.DBPKNCDGGEP = "lightningrod";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon draws in all Electric-type moves. Instead of being hit by Electric-type moves, it boosts its Sp. Atk.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Limber";
		kindlgjmpdi.DBPKNCDGGEP = "limber";
		kindlgjmpdi.KFFQQDLOLLQ = "Its limber body protects the Pokémon from paralysis.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Liquid Ooze";
		kindlgjmpdi.DBPKNCDGGEP = "liquidooze";
		kindlgjmpdi.KFFQQDLOLLQ = "Oozed liquid has strong stench, which damages attackers using any draining move.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Liquid Voice";
		kindlgjmpdi.DBPKNCDGGEP = "liquidvoice";
		kindlgjmpdi.KFFQQDLOLLQ = "All sound-based moves become Water-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Long Reach";
		kindlgjmpdi.DBPKNCDGGEP = "longreach";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon uses its moves without making contact with the target.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Magic Bounce";
		kindlgjmpdi.DBPKNCDGGEP = "magicbounce";
		kindlgjmpdi.KFFQQDLOLLQ = "Reflects status moves, instead of getting hit by them.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Magic Guard";
		kindlgjmpdi.DBPKNCDGGEP = "magicguard";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon only takes damage from attacks.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Magician";
		kindlgjmpdi.DBPKNCDGGEP = "magician";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon steals the held item of a Pokémon it hits with a move.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Magma Armor";
		kindlgjmpdi.DBPKNCDGGEP = "magmaarmor";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is covered with hot magma, which prevents the Pokémon from becoming frozen.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Magnet Pull";
		kindlgjmpdi.DBPKNCDGGEP = "magnetpull";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents Steel-type Pokémon from escaping using its magnetic force.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Marvel Scale";
		kindlgjmpdi.DBPKNCDGGEP = "marvelscale";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's marvelous scales boost the Defense stat if it has a status condition.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Mega Launcher";
		kindlgjmpdi.DBPKNCDGGEP = "megalauncher";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up aura and pulse moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Merciless";
		kindlgjmpdi.DBPKNCDGGEP = "merciless";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's attacks become critical hits if the target is poisoned.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Minus";
		kindlgjmpdi.DBPKNCDGGEP = "minus";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Misty Surge";
		kindlgjmpdi.DBPKNCDGGEP = "mistysurge";
		kindlgjmpdi.KFFQQDLOLLQ = "Turns the ground into Misty Terrain when the Pokémon enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Mold Breaker";
		kindlgjmpdi.DBPKNCDGGEP = "moldbreaker";
		kindlgjmpdi.KFFQQDLOLLQ = "Moves can be used on the target regardless of its Abilities.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Moody";
		kindlgjmpdi.DBPKNCDGGEP = "moody";
		kindlgjmpdi.KFFQQDLOLLQ = "Raises one stat sharply and lowers another every turn.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Motor Drive";
		kindlgjmpdi.DBPKNCDGGEP = "motordrive";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts its Speed stat if hit by an Electric-type move, instead of taking damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Moxie";
		kindlgjmpdi.DBPKNCDGGEP = "moxie";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon shows moxie, and that boosts the Attack stat after knocking out any Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Multiscale";
		kindlgjmpdi.DBPKNCDGGEP = "multiscale";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the amount of damage the Pokémon takes when its HP is full.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Multitype";
		kindlgjmpdi.DBPKNCDGGEP = "multitype";
		kindlgjmpdi.KFFQQDLOLLQ = "Changes the Pokémon's type to match the Plate or Z-Crystal it holds.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Mummy";
		kindlgjmpdi.DBPKNCDGGEP = "mummy";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon changes the attacker's Ability to Mummy.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Natural Cure";
		kindlgjmpdi.DBPKNCDGGEP = "naturalcure";
		kindlgjmpdi.KFFQQDLOLLQ = "All status conditions heal when the Pokémon switches out.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "No Guard";
		kindlgjmpdi.DBPKNCDGGEP = "noguard";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon employs no-guard tactics to ensure incoming and outgoing attacks always land.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Normalize";
		kindlgjmpdi.DBPKNCDGGEP = "normalize";
		kindlgjmpdi.KFFQQDLOLLQ = "All the Pokémon's moves become Normal type. The power of those moves is boosted a little.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Oblivious";
		kindlgjmpdi.DBPKNCDGGEP = "oblivious";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is oblivious, and that keeps it from being infatuated or falling for taunts.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Overcoat";
		kindlgjmpdi.DBPKNCDGGEP = "overcoat";
		kindlgjmpdi.KFFQQDLOLLQ = "Protects the Pokémon from things like sand, hail, and powder.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Overgrow";
		kindlgjmpdi.DBPKNCDGGEP = "overgrow";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up Grass-type moves when the Pokémon's HP is low.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Own Tempo";
		kindlgjmpdi.DBPKNCDGGEP = "owntempo";
		kindlgjmpdi.KFFQQDLOLLQ = "This Pokémon has its own tempo, and that prevents it from becoming confused.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Parental Bond";
		kindlgjmpdi.DBPKNCDGGEP = "parentalbond";
		kindlgjmpdi.KFFQQDLOLLQ = "Parent and child each attacks.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Pickpocket";
		kindlgjmpdi.DBPKNCDGGEP = "pickpocket";
		kindlgjmpdi.KFFQQDLOLLQ = "Steals an item from an attacker that made direct contact.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Pickup";
		kindlgjmpdi.DBPKNCDGGEP = "pickup";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon may pick up the item an opposing Pokémon used during a battle. It may pick up items outside of battle, too.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Pixilate";
		kindlgjmpdi.DBPKNCDGGEP = "pixilate";
		kindlgjmpdi.KFFQQDLOLLQ = "Normal-type moves become Fairy-type moves. The power of those moves is boosted a little.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Plus";
		kindlgjmpdi.DBPKNCDGGEP = "plus";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Sp. Atk stat of the Pokémon if an ally with the Plus or Minus Ability is also in battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Poison Heal";
		kindlgjmpdi.DBPKNCDGGEP = "poisonheal";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores HP if the Pokémon is poisoned, instead of losing HP.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Poison Point";
		kindlgjmpdi.DBPKNCDGGEP = "poisonpoint";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon may poison the attacker.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Poison Touch";
		kindlgjmpdi.DBPKNCDGGEP = "poisontouch";
		kindlgjmpdi.KFFQQDLOLLQ = "May poison a target when the Pokémon makes contact.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Power Construct";
		kindlgjmpdi.DBPKNCDGGEP = "powerconstruct";
		kindlgjmpdi.KFFQQDLOLLQ = "Other Cells gather to aid when its HP becomes half or less. Then the Pokémon changes its form to Complete Forme.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Power of Alchemy";
		kindlgjmpdi.DBPKNCDGGEP = "powerofalchemy";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon copies the Ability of a defeated ally.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Prankster";
		kindlgjmpdi.DBPKNCDGGEP = "prankster";
		kindlgjmpdi.KFFQQDLOLLQ = "Gives priority to a status move.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Pressure";
		kindlgjmpdi.DBPKNCDGGEP = "pressure";
		kindlgjmpdi.KFFQQDLOLLQ = "By putting pressure on the opposing Pokémon, it raises their PP usage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Primordial Sea";
		kindlgjmpdi.DBPKNCDGGEP = "primordialsea";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon changes the weather to nullify Fire-type attacks.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Prism Armor";
		kindlgjmpdi.DBPKNCDGGEP = "prismarmor";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the power of supereffective attacks taken.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Protean";
		kindlgjmpdi.DBPKNCDGGEP = "protean";
		kindlgjmpdi.KFFQQDLOLLQ = "Changes the Pokémon's type to the type of the move it's about to use.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Psychic Surge";
		kindlgjmpdi.DBPKNCDGGEP = "psychicsurge";
		kindlgjmpdi.KFFQQDLOLLQ = "Turns the ground into Psychic Terrain when the Pokémon enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Pure Power";
		kindlgjmpdi.DBPKNCDGGEP = "purepower";
		kindlgjmpdi.KFFQQDLOLLQ = "Using its pure power, the Pokémon doubles its Attack stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Queenly Majesty";
		kindlgjmpdi.DBPKNCDGGEP = "queenlymajesty";
		kindlgjmpdi.KFFQQDLOLLQ = "Its majesty pressures the opposing Pokémon, making it unable to attack using priority moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Quick Feet";
		kindlgjmpdi.DBPKNCDGGEP = "quickfeet";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Speed stat if the Pokémon has a status condition.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Rain Dish";
		kindlgjmpdi.DBPKNCDGGEP = "raindish";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon gradually regains HP in rain.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Rattled";
		kindlgjmpdi.DBPKNCDGGEP = "rattled";
		kindlgjmpdi.KFFQQDLOLLQ = "Dark-, Ghost-, and Bug-type moves scare the Pokémon and boost its Speed stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Receiver";
		kindlgjmpdi.DBPKNCDGGEP = "receiver";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon copies the Ability of a defeated ally.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Reckless";
		kindlgjmpdi.DBPKNCDGGEP = "reckless";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up moves that have recoil damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Refrigerate";
		kindlgjmpdi.DBPKNCDGGEP = "refrigerate";
		kindlgjmpdi.KFFQQDLOLLQ = "Normal-type moves become Ice-type moves. The power of those moves is boosted a little.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Regenerator";
		kindlgjmpdi.DBPKNCDGGEP = "regenerator";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores a little HP when withdrawn from battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Rivalry";
		kindlgjmpdi.DBPKNCDGGEP = "rivalry";
		kindlgjmpdi.KFFQQDLOLLQ = "Becomes competitive and deals more damage to Pokémon of the same gender, but deals less to Pokémon of the opposite gender.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "RKS System";
		kindlgjmpdi.DBPKNCDGGEP = "rkssystem";
		kindlgjmpdi.KFFQQDLOLLQ = "Changes the Pokémon's type to match the memory disc it holds.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Rock Head";
		kindlgjmpdi.DBPKNCDGGEP = "rockhead";
		kindlgjmpdi.KFFQQDLOLLQ = "Protects the Pokémon from recoil damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Rough Skin";
		kindlgjmpdi.DBPKNCDGGEP = "roughskin";
		kindlgjmpdi.KFFQQDLOLLQ = "This Pokémon inflicts damage with its rough skin to the attacker on contact.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Run Away";
		kindlgjmpdi.DBPKNCDGGEP = "runaway";
		kindlgjmpdi.KFFQQDLOLLQ = "Enables a sure getaway from wild Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sand Force";
		kindlgjmpdi.DBPKNCDGGEP = "sandforce";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the power of Rock-, Ground-, and Steel-type moves in a sandstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sand Rush";
		kindlgjmpdi.DBPKNCDGGEP = "sandrush";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Speed stat in a sandstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sand Stream";
		kindlgjmpdi.DBPKNCDGGEP = "sandstream";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon summons a sandstorm when it enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sand Veil";
		kindlgjmpdi.DBPKNCDGGEP = "sandveil";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's evasion in a sandstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sap Sipper";
		kindlgjmpdi.DBPKNCDGGEP = "sapsipper";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Schooling";
		kindlgjmpdi.DBPKNCDGGEP = "schooling";
		kindlgjmpdi.KFFQQDLOLLQ = "When it has a lot of HP, the Pokémon forms a powerful school. It stops schooling when its HP is low.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Scrappy";
		kindlgjmpdi.DBPKNCDGGEP = "scrappy";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can hit Ghost-type Pokémon with Normal- and Fighting-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Serene Grace";
		kindlgjmpdi.DBPKNCDGGEP = "serenegrace";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the likelihood of additional effects occurring when attacking.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shadow Shield";
		kindlgjmpdi.DBPKNCDGGEP = "shadowshield";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the amount of damage the Pokémon takes while its HP is full.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shadow Tag";
		kindlgjmpdi.DBPKNCDGGEP = "shadowtag";
		kindlgjmpdi.KFFQQDLOLLQ = "This Pokémon steps on the opposing Pokémon's shadow to prevent it from escaping.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shed Skin";
		kindlgjmpdi.DBPKNCDGGEP = "shedskin";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon may heal its own status conditions by shedding its skin.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sheer Force";
		kindlgjmpdi.DBPKNCDGGEP = "sheerforce";
		kindlgjmpdi.KFFQQDLOLLQ = "Removes additional effects to increase the power of moves when attacking.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shell Armor";
		kindlgjmpdi.DBPKNCDGGEP = "shellarmor";
		kindlgjmpdi.KFFQQDLOLLQ = "A hard shell protects the Pokémon from critical hits.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shield Dust";
		kindlgjmpdi.DBPKNCDGGEP = "shielddust";
		kindlgjmpdi.KFFQQDLOLLQ = "This Pokémon's dust blocks the additional effects of attacks taken.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Shields Down";
		kindlgjmpdi.DBPKNCDGGEP = "shieldsdown";
		kindlgjmpdi.KFFQQDLOLLQ = "When its HP becomes half or less, the Pokémon's shell breaks and it becomes aggressive.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Simple";
		kindlgjmpdi.DBPKNCDGGEP = "simple";
		kindlgjmpdi.KFFQQDLOLLQ = "The stat changes the Pokémon receives are doubled.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Skill Link";
		kindlgjmpdi.DBPKNCDGGEP = "skilllink";
		kindlgjmpdi.KFFQQDLOLLQ = "Maximizes the number of times multi-strike moves hit.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Slow Start";
		kindlgjmpdi.DBPKNCDGGEP = "slowstart";
		kindlgjmpdi.KFFQQDLOLLQ = "For five turns, the Pokémon's Attack and Speed stats are halved.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Slush Rush";
		kindlgjmpdi.DBPKNCDGGEP = "slushrush";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Speed stat in a hailstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sniper";
		kindlgjmpdi.DBPKNCDGGEP = "sniper";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up moves if they become critical hits when attacking.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Snow Cloak";
		kindlgjmpdi.DBPKNCDGGEP = "snowcloak";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts evasion in a hailstorm.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Snow Warning";
		kindlgjmpdi.DBPKNCDGGEP = "snowwarning";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon summons a hailstorm when it enters a battle.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Solar Power";
		kindlgjmpdi.DBPKNCDGGEP = "solarpower";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Sp. Atk stat in sunny weather, but HP decreases every turn.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Solid Rock";
		kindlgjmpdi.DBPKNCDGGEP = "solidrock";
		kindlgjmpdi.KFFQQDLOLLQ = "Reduces the power of supereffective attacks taken.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Soul-Heart";
		kindlgjmpdi.DBPKNCDGGEP = "soulheart";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts its Sp. Atk stat every time a Pokémon faints.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Soundproof";
		kindlgjmpdi.DBPKNCDGGEP = "soundproof";
		kindlgjmpdi.KFFQQDLOLLQ = "Soundproofing of the Pokémon itself gives full immunity to all sound-based moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Speed Boost";
		kindlgjmpdi.DBPKNCDGGEP = "speedboost";
		kindlgjmpdi.KFFQQDLOLLQ = "Its Speed stat is boosted every turn.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Stakeout";
		kindlgjmpdi.DBPKNCDGGEP = "stakeout";
		kindlgjmpdi.KFFQQDLOLLQ = "Doubles the damage dealt to the target's replacement if the target switches out.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Stall";
		kindlgjmpdi.DBPKNCDGGEP = "stall";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon moves after all other Pokémon do.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Stamina";
		kindlgjmpdi.DBPKNCDGGEP = "stamina";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Defense stat when hit by an attack.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Stance Change";
		kindlgjmpdi.DBPKNCDGGEP = "stancechange";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon changes its form to Blade Forme when it uses an attack move, and changes to Shield Forme when it uses King's Shield.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Static";
		kindlgjmpdi.DBPKNCDGGEP = "static";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is charged with static electricity, so contact with it may cause paralysis.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Steadfast";
		kindlgjmpdi.DBPKNCDGGEP = "steadfast";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's determination boosts the Speed stat each time the Pokémon flinches.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Steelworker";
		kindlgjmpdi.DBPKNCDGGEP = "steelworker";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up Steel-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Stench";
		kindlgjmpdi.DBPKNCDGGEP = "stench";
		kindlgjmpdi.KFFQQDLOLLQ = "By releasing stench when attacking, this Pokémon may cause the target to flinch.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sticky Hold";
		kindlgjmpdi.DBPKNCDGGEP = "stickyhold";
		kindlgjmpdi.KFFQQDLOLLQ = "Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Storm Drain";
		kindlgjmpdi.DBPKNCDGGEP = "stormdrain";
		kindlgjmpdi.KFFQQDLOLLQ = "Draws in all Water-type moves. Instead of being hit by Water-type moves, it boosts its Sp. Atk.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Strong Jaw";
		kindlgjmpdi.DBPKNCDGGEP = "strongjaw";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon's strong jaw boosts the power of its biting moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sturdy";
		kindlgjmpdi.DBPKNCDGGEP = "sturdy";
		kindlgjmpdi.KFFQQDLOLLQ = "It cannot be knocked out with one hit. One-hit KO moves cannot knock it out, either.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Suction Cups";
		kindlgjmpdi.DBPKNCDGGEP = "suctioncups";
		kindlgjmpdi.KFFQQDLOLLQ = "This Pokémon uses suction cups to stay in one spot to negate all moves and items that force switching out.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Super Luck";
		kindlgjmpdi.DBPKNCDGGEP = "superluck";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is so lucky that the critical-hit ratios of its moves are boosted.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Surge Surfer";
		kindlgjmpdi.DBPKNCDGGEP = "surgesurfer";
		kindlgjmpdi.KFFQQDLOLLQ = "Doubles the Pokémon's Speed stat on Electric Terrain.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Swarm";
		kindlgjmpdi.DBPKNCDGGEP = "swarm";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up Bug-type moves when the Pokémon's HP is low.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Sweet Veil";
		kindlgjmpdi.DBPKNCDGGEP = "sweetveil";
		kindlgjmpdi.KFFQQDLOLLQ = "Prevents itself and ally Pokémon from falling asleep.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Swift Swim";
		kindlgjmpdi.DBPKNCDGGEP = "swiftswim";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Speed stat in rain.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Symbiosis";
		kindlgjmpdi.DBPKNCDGGEP = "symbiosis";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon passes its item to an ally that has used up an item.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Synchronize";
		kindlgjmpdi.DBPKNCDGGEP = "synchronize";
		kindlgjmpdi.KFFQQDLOLLQ = "The attacker will receive the same status condition if it inflicts a burn, poison, or paralysis to the Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Tangled Feet";
		kindlgjmpdi.DBPKNCDGGEP = "tangledfeet";
		kindlgjmpdi.KFFQQDLOLLQ = "Raises evasion if the Pokémon is confused.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Tangling Hair";
		kindlgjmpdi.DBPKNCDGGEP = "tanglinghair";
		kindlgjmpdi.KFFQQDLOLLQ = "Contact with the Pokémon lowers the attacker's Speed stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Technician";
		kindlgjmpdi.DBPKNCDGGEP = "technician";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up the Pokémon's weaker moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Telepathy";
		kindlgjmpdi.DBPKNCDGGEP = "telepathy";
		kindlgjmpdi.KFFQQDLOLLQ = "Anticipates an ally's attack and dodges it.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Teravolt";
		kindlgjmpdi.DBPKNCDGGEP = "teravolt";
		kindlgjmpdi.KFFQQDLOLLQ = "Moves can be used on the target regardless of its Abilities.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Thick Fat";
		kindlgjmpdi.DBPKNCDGGEP = "thickfat";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Tinted Lens";
		kindlgjmpdi.DBPKNCDGGEP = "tintedlens";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can use 'not very effective' moves to deal regular damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Torrent";
		kindlgjmpdi.DBPKNCDGGEP = "torrent";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up Water-type moves when the Pokémon's HP is low.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Tough Claws";
		kindlgjmpdi.DBPKNCDGGEP = "toughclaws";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up moves that make direct contact.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Toxic Boost";
		kindlgjmpdi.DBPKNCDGGEP = "toxicboost";
		kindlgjmpdi.KFFQQDLOLLQ = "Powers up physical attacks when the Pokémon is poisoned.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Trace";
		kindlgjmpdi.DBPKNCDGGEP = "trace";
		kindlgjmpdi.KFFQQDLOLLQ = "When it enters a battle, the Pokémon copies an opposing Pokémon's Ability.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Triage";
		kindlgjmpdi.DBPKNCDGGEP = "triage";
		kindlgjmpdi.KFFQQDLOLLQ = "Gives priority to a healing move.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Truant";
		kindlgjmpdi.DBPKNCDGGEP = "truant";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon can't use a move the following turn if it uses one.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Turboblaze";
		kindlgjmpdi.DBPKNCDGGEP = "turboblaze";
		kindlgjmpdi.KFFQQDLOLLQ = "Moves can be used on the target regardless of its Abilities.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Unaware";
		kindlgjmpdi.DBPKNCDGGEP = "unaware";
		kindlgjmpdi.KFFQQDLOLLQ = "When attacking, the Pokémon ignores the target Pokémon's stat changes.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Unburden";
		kindlgjmpdi.DBPKNCDGGEP = "unburden";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Speed stat if the Pokémon's held item is used or lost.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Unnerve";
		kindlgjmpdi.DBPKNCDGGEP = "unnerve";
		kindlgjmpdi.KFFQQDLOLLQ = "Unnerves opposing Pokémon and makes them unable to eat Berries.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Victory Star";
		kindlgjmpdi.DBPKNCDGGEP = "victorystar";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the accuracy of its allies and itself.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Vital Spirit";
		kindlgjmpdi.DBPKNCDGGEP = "vitalspirit";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is full of vitality, and that prevents it from falling asleep.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Volt Absorb";
		kindlgjmpdi.DBPKNCDGGEP = "voltabsorb";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores HP if hit by an Electric-type move, instead of taking damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Water Absorb";
		kindlgjmpdi.DBPKNCDGGEP = "waterabsorb";
		kindlgjmpdi.KFFQQDLOLLQ = "Restores HP if hit by a Water-type move, instead of taking damage.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Water Bubble";
		kindlgjmpdi.DBPKNCDGGEP = "waterbubble";
		kindlgjmpdi.KFFQQDLOLLQ = "Lowers the power of Fire-type moves done to the Pokémon and prevents the Pokémon from getting a burn.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Water Compaction";
		kindlgjmpdi.DBPKNCDGGEP = "watercompaction";
		kindlgjmpdi.KFFQQDLOLLQ = "Boosts the Pokémon's Defense stat sharply when hit by a Water-type move.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Water Veil";
		kindlgjmpdi.DBPKNCDGGEP = "waterveil";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is covered with a water veil, which prevents the Pokémon from getting a burn.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Weak Armor";
		kindlgjmpdi.DBPKNCDGGEP = "weakarmor";
		kindlgjmpdi.KFFQQDLOLLQ = "Physical attacks to the Pokémon lower its Defense stat but sharply raise its Speed stat.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "White Smoke";
		kindlgjmpdi.DBPKNCDGGEP = "whitesmoke";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon is protected by its white smoke, which prevents other Pokémon from lowering its stats.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Wimp Out";
		kindlgjmpdi.DBPKNCDGGEP = "wimpout";
		kindlgjmpdi.KFFQQDLOLLQ = "The Pokémon cowardly switches out when its HP becomes half or less.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Wonder Guard";
		kindlgjmpdi.DBPKNCDGGEP = "wonderguard";
		kindlgjmpdi.KFFQQDLOLLQ = "Its mysterious power only lets supereffective moves hit the Pokémon.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Wonder Skin";
		kindlgjmpdi.DBPKNCDGGEP = "wonderskin";
		kindlgjmpdi.KFFQQDLOLLQ = "Makes status moves more likely to miss.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
		kindlgjmpdi = new KGQECFKLKOP.KINDLGJMPDI();
		kindlgjmpdi.FPQBICGEHMJ = "Zen Mode";
		kindlgjmpdi.DBPKNCDGGEP = "zenmode";
		kindlgjmpdi.KFFQQDLOLLQ = "Changes the Pokémon's shape when HP is half or less.";
		KGQECFKLKOP.PGBCDJLIDOK.Add(kindlgjmpdi);
	}

	// Token: 0x06005126 RID: 20774 RVA: 0x002A63B8 File Offset: 0x002A45B8
	public static bool BGCIDLJNBOO(string IDNLDLJJEIN, string OOFGFDHLFBN)
	{
		int num = 7;
		OOFGFDHLFBN = KGQECFKLKOP.FMLPNPFKFLM(OOFGFDHLFBN);
		IDNLDLJJEIN = KGQECFKLKOP.FMLPNPFKFLM(IDNLDLJJEIN);
		foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string[]>>> keyValuePair in KGQECFKLKOP.OEFKBDGIFBL)
		{
			if (keyValuePair.Key.ToLowerInvariant() == IDNLDLJJEIN)
			{
				foreach (KeyValuePair<string, string[]> keyValuePair2 in keyValuePair.Value["learnset"])
				{
					if (KGQECFKLKOP.FMLPNPFKFLM(keyValuePair2.Key) == OOFGFDHLFBN)
					{
						foreach (string text in keyValuePair2.Value)
						{
							int num2 = (int)char.GetNumericValue(text[0]);
							if (num2 <= num)
							{
								char c = text[1];
								if (c == 'M')
								{
									return true;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005127 RID: 20775 RVA: 0x002A64E4 File Offset: 0x002A46E4
	public static List<string> PGEKKBDOHKH(int IKIJBQLMKJO, char FHPJLMGPQFJ = 'L')
	{
		int num = 7;
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		string b = KGQECFKLKOP.FMLPNPFKFLM(KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO));
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string[]>>> keyValuePair in KGQECFKLKOP.OEFKBDGIFBL)
		{
			if (keyValuePair.Key.ToLowerInvariant() == b)
			{
				foreach (KeyValuePair<string, string[]> keyValuePair2 in keyValuePair.Value["learnset"])
				{
					int num2 = 0;
					foreach (string text in keyValuePair2.Value)
					{
						int num3 = (int)char.GetNumericValue(text[0]);
						if (num3 == num)
						{
							char c = text[1];
							if (FHPJLMGPQFJ == 'L' && c == 'L')
							{
								int value2 = int.Parse(text.Substring(2));
								dictionary.Add(num2.DBFPJOCLQBI() + keyValuePair2.Key, value2);
							}
							num2++;
						}
					}
				}
			}
		}
		IEnumerable<KeyValuePair<string, int>> source = dictionary;
		if (KGQECFKLKOP.HNCJFHJNHDN == null)
		{
			KGQECFKLKOP.HNCJFHJNHDN = new Func<KeyValuePair<string, int>, int>(KGQECFKLKOP.GJIFCJFHQCF);
		}
		foreach (KeyValuePair<string, int> keyValuePair3 in source.OrderBy(KGQECFKLKOP.HNCJFHJNHDN))
		{
			if (!list.Contains("[33ccff]Lv. " + keyValuePair3.Value.ToString() + "[-] " + KGQECFKLKOP.BHNKDENQEBN(keyValuePair3.Key.Substring(3))))
			{
				list.Add("[33ccff]Lv. " + keyValuePair3.Value.ToString() + "[-] " + KGQECFKLKOP.BHNKDENQEBN(keyValuePair3.Key.Substring(3)));
			}
		}
		return list;
	}

	// Token: 0x06005128 RID: 20776 RVA: 0x002A6718 File Offset: 0x002A4918
	public static List<string> QBJGNLGDJIP(int IKIJBQLMKJO)
	{
		List<string> list = new List<string>();
		string b = KGQECFKLKOP.FMLPNPFKFLM(KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO));
		foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string[]>>> keyValuePair in KGQECFKLKOP.OEFKBDGIFBL)
		{
			if (keyValuePair.Key.ToLowerInvariant() == b)
			{
				foreach (KeyValuePair<string, string[]> keyValuePair2 in keyValuePair.Value["learnset"])
				{
					int num = 7;
					foreach (string text in keyValuePair2.Value)
					{
						int num2 = (int)char.GetNumericValue(text[0]);
						if (num2 <= num)
						{
							char c = text[1];
							if (c == 'M')
							{
								list.Add(KGQECFKLKOP.BHNKDENQEBN(keyValuePair2.Key));
								break;
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06005129 RID: 20777 RVA: 0x002A6844 File Offset: 0x002A4A44
	public static List<string> DMNQCIPOBKO(int IKIJBQLMKJO)
	{
		List<string> list = new List<string>();
		string b = KGQECFKLKOP.FMLPNPFKFLM(KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO));
		foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string[]>>> keyValuePair in KGQECFKLKOP.OEFKBDGIFBL)
		{
			if (keyValuePair.Key.ToLowerInvariant() == b)
			{
				foreach (KeyValuePair<string, string[]> keyValuePair2 in keyValuePair.Value["learnset"])
				{
					int num = 7;
					foreach (string text in keyValuePair2.Value)
					{
						int num2 = (int)char.GetNumericValue(text[0]);
						if (num2 <= num)
						{
							char c = text[1];
							if (c == 'T')
							{
								list.Add(KGQECFKLKOP.BHNKDENQEBN(keyValuePair2.Key));
								break;
							}
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600512A RID: 20778 RVA: 0x00020776 File Offset: 0x0001E976
	public static string NNHFLHEQMOI(int CIQFCJGQEMH)
	{
		if (CIQFCJGQEMH == 9999)
		{
			return "Egg";
		}
		return KGQECFKLKOP.DDBIKNCLDGI.Pokemon[CIQFCJGQEMH].Name;
	}

	// Token: 0x0600512B RID: 20779 RVA: 0x00020797 File Offset: 0x0001E997
	public static int LEPLCEFNHHF(int CIQFCJGQEMH)
	{
		return -1;
	}

	// Token: 0x0600512C RID: 20780 RVA: 0x002A6970 File Offset: 0x002A4B70
	public static string KOILGQHHQIQ(int CIQFCJGQEMH)
	{
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.ID == CIQFCJGQEMH)
			{
				return moveInfo.Name;
			}
		}
		return string.Empty;
	}

	// Token: 0x0600512D RID: 20781 RVA: 0x002A69B4 File Offset: 0x002A4BB4
	public static int BEQHNFFEHMQ(string GEQLENOFNDG)
	{
		GEQLENOFNDG = GEQLENOFNDG.ToLowerInvariant();
		GEQLENOFNDG = GEQLENOFNDG.Replace("-primal", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-mega-x", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-mega-y", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-mega", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("'", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-busted", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-school", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-meteor", string.Empty);
		GEQLENOFNDG = GEQLENOFNDG.Replace("-core", string.Empty);
		if (GEQLENOFNDG == "egg")
		{
			return 9999;
		}
		if (GEQLENOFNDG == "nidoran-f")
		{
			return 29;
		}
		if (GEQLENOFNDG == "nidoran-m")
		{
			return 32;
		}
		for (int i = 0; i < 803; i++)
		{
			if (KGQECFKLKOP.DDBIKNCLDGI.Pokemon[i].Name.Replace("'", string.Empty).ToLowerInvariant() == GEQLENOFNDG.ToLowerInvariant())
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x0600512E RID: 20782 RVA: 0x002A6AE4 File Offset: 0x002A4CE4
	public static string NHNMKGHIKIB(string JBNFQFNOKHP)
	{
		if (JBNFQFNOKHP != null && JBNFQFNOKHP.Length >= 2)
		{
			JBNFQFNOKHP = KGQECFKLKOP.FMLPNPFKFLM(JBNFQFNOKHP);
			foreach (KGQECFKLKOP.KINDLGJMPDI kindlgjmpdi in KGQECFKLKOP.PGBCDJLIDOK)
			{
				if (kindlgjmpdi.DBPKNCDGGEP == JBNFQFNOKHP)
				{
					return kindlgjmpdi.KFFQQDLOLLQ;
				}
				if (kindlgjmpdi.FPQBICGEHMJ == JBNFQFNOKHP)
				{
					return kindlgjmpdi.KFFQQDLOLLQ;
				}
			}
			return string.Empty;
		}
		return string.Empty;
	}

	// Token: 0x0600512F RID: 20783 RVA: 0x002A6B80 File Offset: 0x002A4D80
	public static string DPDPPDNIFQN(string JBNFQFNOKHP)
	{
		if (JBNFQFNOKHP != null && JBNFQFNOKHP.Length >= 2)
		{
			foreach (KGQECFKLKOP.KINDLGJMPDI kindlgjmpdi in KGQECFKLKOP.PGBCDJLIDOK)
			{
				if (kindlgjmpdi.DBPKNCDGGEP == JBNFQFNOKHP)
				{
					return kindlgjmpdi.FPQBICGEHMJ;
				}
				if (kindlgjmpdi.FPQBICGEHMJ == JBNFQFNOKHP)
				{
					return kindlgjmpdi.DBPKNCDGGEP;
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06005130 RID: 20784 RVA: 0x002A6C0C File Offset: 0x002A4E0C
	public static KGQECFKLKOP.Item QDMQEBHOENL(string JBNFQFNOKHP)
	{
		if (JBNFQFNOKHP != null && JBNFQFNOKHP.Length >= 2)
		{
			foreach (KGQECFKLKOP.Item item in KGQECFKLKOP.CNNFBFLDLLO.items)
			{
				if (item.BattleID == JBNFQFNOKHP)
				{
					return item;
				}
				if (item.Name == JBNFQFNOKHP)
				{
					return item;
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06005131 RID: 20785 RVA: 0x002A6C68 File Offset: 0x002A4E68
	public static bool JNIMJICDKHK(string JBNFQFNOKHP)
	{
		return JBNFQFNOKHP != null && (JBNFQFNOKHP == "brn" || JBNFQFNOKHP == "par" || JBNFQFNOKHP == "slp" || JBNFQFNOKHP == "frz" || JBNFQFNOKHP == "psn" || JBNFQFNOKHP == "tox");
	}

	// Token: 0x06005132 RID: 20786 RVA: 0x0002079A File Offset: 0x0001E99A
	public static string FMLPNPFKFLM(string PIDLOFMIEFQ)
	{
		if (PIDLOFMIEFQ == null)
		{
			return null;
		}
		return Regex.Replace(PIDLOFMIEFQ, "[^a-zA-Z0-9_]+", string.Empty, RegexOptions.Compiled).ToLowerInvariant();
	}

	// Token: 0x06005133 RID: 20787 RVA: 0x002A6CCC File Offset: 0x002A4ECC
	public static bool QKFBHKEDIHQ(string JBNFQFNOKHP)
	{
		JBNFQFNOKHP = KGQECFKLKOP.FMLPNPFKFLM(JBNFQFNOKHP);
		if (JBNFQFNOKHP != null)
		{
			if (KGQECFKLKOP.FLGCJNOQKJE == null)
			{
				KGQECFKLKOP.FLGCJNOQKJE = new Dictionary<string, int>(11)
				{
					{
						"fly",
						0
					},
					{
						"cut",
						0
					},
					{
						"surf",
						0
					},
					{
						"strength",
						0
					},
					{
						"waterfall",
						0
					},
					{
						"rocksmash",
						0
					},
					{
						"dive",
						0
					},
					{
						"flash",
						0
					},
					{
						"defog",
						0
					},
					{
						"whirlpool",
						0
					},
					{
						"rockclimb",
						0
					}
				};
			}
			int num;
			if (KGQECFKLKOP.FLGCJNOQKJE.TryGetValue(JBNFQFNOKHP, out num) && num == 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005134 RID: 20788 RVA: 0x002A6D98 File Offset: 0x002A4F98
	public static bool HKPPKBIGMBM(string JBNFQFNOKHP)
	{
		JBNFQFNOKHP = KGQECFKLKOP.FMLPNPFKFLM(JBNFQFNOKHP);
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.BattleID == JBNFQFNOKHP)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06005135 RID: 20789 RVA: 0x002A6DDC File Offset: 0x002A4FDC
	public static string BHNKDENQEBN(string JBNFQFNOKHP)
	{
		JBNFQFNOKHP = KGQECFKLKOP.FMLPNPFKFLM(JBNFQFNOKHP);
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.BattleID == JBNFQFNOKHP)
			{
				return moveInfo.Name;
			}
		}
		return string.Empty;
	}

	// Token: 0x06005136 RID: 20790 RVA: 0x002A6E28 File Offset: 0x002A5028
	public static KGQECFKLKOP.MoveInfo MEFMNMCKQOG(int DBPKNCDGGEP)
	{
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.ID == DBPKNCDGGEP)
			{
				return moveInfo;
			}
		}
		return null;
	}

	// Token: 0x06005137 RID: 20791 RVA: 0x002A6E60 File Offset: 0x002A5060
	public static KGQECFKLKOP.MoveInfo MIKJDLGLEDQ(string DBPKNCDGGEP)
	{
		DBPKNCDGGEP = KGQECFKLKOP.FMLPNPFKFLM(DBPKNCDGGEP);
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.BattleID != null && moveInfo.BattleID.ToLowerInvariant() == DBPKNCDGGEP.ToLowerInvariant())
			{
				return moveInfo;
			}
		}
		return null;
	}

	// Token: 0x06005138 RID: 20792 RVA: 0x002A6EB8 File Offset: 0x002A50B8
	public static string OMFQIEPOKLM(string JBNFQFNOKHP)
	{
		JBNFQFNOKHP = KGQECFKLKOP.FMLPNPFKFLM(JBNFQFNOKHP);
		foreach (KGQECFKLKOP.MoveInfo moveInfo in KGQECFKLKOP.EEILBMOOJHJ.Moves)
		{
			if (moveInfo.BattleID == JBNFQFNOKHP)
			{
				return moveInfo.Type;
			}
		}
		return string.Empty;
	}

	// Token: 0x06005139 RID: 20793 RVA: 0x002A6F04 File Offset: 0x002A5104
	public static string HDKMGCBMEIJ(string JMDLLJPEFKM)
	{
		if (string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			return string.Empty;
		}
		char[] array = JMDLLJPEFKM.ToCharArray();
		array[0] = char.ToUpper(array[0]);
		return new string(array);
	}

	// Token: 0x0600513A RID: 20794 RVA: 0x002A6F38 File Offset: 0x002A5138
	public static void EQKKLBFPGPB()
	{
		EMENMKHBPQE.NBBKPCKOEPI.transform.NMBPDMIIHJB();
		if (EMENMKHBPQE.JQCODFPLPNJ == -2)
		{
			GameObject gameObject = CNCJKLNHQBH.QOQONHOOLNE.PIBNGFEMQBL.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.OMCQINBLOEL);
			BMNBILHJHGP component = gameObject.GetComponent<BMNBILHJHGP>();
			component.HDNDNHJMCBG = CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
			component.PKKLDKIIMHJ("AFK", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.AFK), null, null, false);
			if (DCJIBBJQGJP.QOQONHOOLNE.COOLIKQMBMK)
			{
				component.PKKLDKIIMHJ("Leave Party", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(DCJIBBJQGJP.QOQONHOOLNE.IFDMFFQHHIC), null, null, false);
			}
			Vector2 v = Input.mousePosition;
			Vector3 localPosition = v;
			localPosition.z = 0f;
			localPosition.x -= (float)(Screen.width / 2);
			localPosition.y -= (float)(Screen.height / 2);
			component.NKKMJICKKLB.PIDLOFMIEFQ = CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
			localPosition.x = (float)((int)localPosition.x);
			localPosition.y = (float)((int)localPosition.y);
			gameObject.transform.localPosition = localPosition;
		}
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x002A7068 File Offset: 0x002A5268
	public static void LGHLQDLBBIB(string HHNBICLDQKI)
	{
		EMENMKHBPQE.NBBKPCKOEPI.transform.NMBPDMIIHJB();
		GameObject gameObject = CNCJKLNHQBH.QOQONHOOLNE.PIBNGFEMQBL.BFCKNMFEBDM(CNCJKLNHQBH.QOQONHOOLNE.OMCQINBLOEL);
		BMNBILHJHGP component = gameObject.GetComponent<BMNBILHJHGP>();
		component.HDNDNHJMCBG = HHNBICLDQKI;
		if (HHNBICLDQKI.ToLowerInvariant() != KGQECFKLKOP.HFKHODPJQOJ().ToLowerInvariant())
		{
			component.PKKLDKIIMHJ("[d9b38c]Message", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(LQCPKKCJPPB.QOQONHOOLNE.FIIDGLDFLEG), null, null, false);
			if (DCJIBBJQGJP.QOQONHOOLNE.COOLIKQMBMK)
			{
				if (DCJIBBJQGJP.QOQONHOOLNE.IIDPPHPJDBN(HHNBICLDQKI))
				{
					if (DCJIBBJQGJP.QOQONHOOLNE.JQCDEEPLNDF)
					{
						BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm = new BMNBILHJHGP.MGCFKFPPGLM();
						mgcfkfppglm.NKKMJICKKLB = "[04B9E6]Party";
						mgcfkfppglm.NPMDMKHKQNQ = true;
						mgcfkfppglm.PKKLDKIIMHJ("Kick", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(DCJIBBJQGJP.QOQONHOOLNE.OENHIQQHNGO));
						mgcfkfppglm.PKKLDKIIMHJ("Set to Leader", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(DCJIBBJQGJP.QOQONHOOLNE.BDDQBKFGCIE));
						component.HJEFIPJDEEK(mgcfkfppglm);
					}
				}
				else if (DCJIBBJQGJP.QOQONHOOLNE.JQCDEEPLNDF)
				{
					BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm2 = new BMNBILHJHGP.MGCFKFPPGLM();
					mgcfkfppglm2.NKKMJICKKLB = "[04B9E6]Party";
					mgcfkfppglm2.NPMDMKHKQNQ = true;
					mgcfkfppglm2.PKKLDKIIMHJ("Invite to Party", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(DCJIBBJQGJP.QOQONHOOLNE.PLILFHPPQPM));
					component.HJEFIPJDEEK(mgcfkfppglm2);
				}
			}
			else
			{
				BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm3 = new BMNBILHJHGP.MGCFKFPPGLM();
				mgcfkfppglm3.NKKMJICKKLB = "[04B9E6]Party";
				mgcfkfppglm3.NPMDMKHKQNQ = true;
				mgcfkfppglm3.PKKLDKIIMHJ("Invite to Party", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(DCJIBBJQGJP.QOQONHOOLNE.PLILFHPPQPM));
				component.HJEFIPJDEEK(mgcfkfppglm3);
			}
			BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm4 = new BMNBILHJHGP.MGCFKFPPGLM();
			mgcfkfppglm4.NKKMJICKKLB = "[5cd65c]Social";
			mgcfkfppglm4.NPMDMKHKQNQ = true;
			if (CKMLKNPNPQO.QOQONHOOLNE.HONOPIHKKDL(HHNBICLDQKI))
			{
				mgcfkfppglm4.PKKLDKIIMHJ("Remove from Friends", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.RemoveFriend));
				if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(HHNBICLDQKI))
				{
					mgcfkfppglm4.PKKLDKIIMHJ("Remove from Ignore", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.RemoveIgnore));
				}
				else
				{
					mgcfkfppglm4.PKKLDKIIMHJ("Add to Ignore", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.IgnoreRequest));
				}
			}
			else if (CKMLKNPNPQO.QOQONHOOLNE.OFKHICHJCIP(HHNBICLDQKI))
			{
				mgcfkfppglm4.PKKLDKIIMHJ("Add to Friends", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.FriendRequest));
				mgcfkfppglm4.PKKLDKIIMHJ("Remove from Ignore", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.RemoveIgnore));
			}
			else
			{
				mgcfkfppglm4.PKKLDKIIMHJ("Add to Friends", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.FriendRequest));
				mgcfkfppglm4.PKKLDKIIMHJ("Add to Ignore", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.IgnoreRequest));
			}
			component.HJEFIPJDEEK(mgcfkfppglm4);
			component.PKKLDKIIMHJ("[ffdb4d]Trade", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.TradeRequest), null, null, false);
			component.PKKLDKIIMHJ("[ff6666]Battle", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.BattleRequest), null, null, false);
			component.PKKLDKIIMHJ("[668cff]Inspect", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(HDQHPMCPDNJ.QOQONHOOLNE.Open), null, null, false);
			NOHEMGHONKK qoqonhoolne = NOHEMGHONKK.QOQONHOOLNE;
			if (qoqonhoolne != null && qoqonhoolne.IEICJDEDICD != null)
			{
				GuildRank rank = qoqonhoolne.IEICJDEDICD.Rank;
				if (rank != GuildRank.Unset && rank != GuildRank.User)
				{
					NOHEMGHONKK.FCBMPMCLJHM fcbmpmcljhm = null;
					int i = 0;
					while (i < qoqonhoolne.HKNPDDMEOEG.Count)
					{
						if (!(qoqonhoolne.HKNPDDMEOEG[i].ICLNEPCODIK.Username.ToLowerInvariant() == HHNBICLDQKI.ToLowerInvariant()))
						{
							i++;
						}
						else
						{
							fcbmpmcljhm = qoqonhoolne.HKNPDDMEOEG[i];
							IL_383:
							BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm5 = new BMNBILHJHGP.MGCFKFPPGLM();
							mgcfkfppglm5.NKKMJICKKLB = "[aa66cc]Guild";
							mgcfkfppglm5.NPMDMKHKQNQ = true;
							if (rank == GuildRank.Admin || rank == GuildRank.Creator)
							{
								if (fcbmpmcljhm != null)
								{
									if (fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Creator)
									{
										mgcfkfppglm5.PKKLDKIIMHJ("Kick", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.OENHIQQHNGO));
									}
									if (fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Creator && fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.User)
									{
										mgcfkfppglm5.PKKLDKIIMHJ("Demote", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.IJGPCGDMEIK));
									}
									if (fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Creator && fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Admin)
									{
										mgcfkfppglm5.PKKLDKIIMHJ("Promote", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.QJFFBMBJFMG));
									}
								}
								else
								{
									mgcfkfppglm5.PKKLDKIIMHJ("Invite", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.PLILFHPPQPM));
								}
							}
							if (rank == GuildRank.Moderator)
							{
								if (fcbmpmcljhm != null)
								{
									if (fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Creator && fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Admin)
									{
										mgcfkfppglm5.PKKLDKIIMHJ("Kick", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.OENHIQQHNGO));
									}
								}
								else
								{
									mgcfkfppglm5.PKKLDKIIMHJ("Invite", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne.PLILFHPPQPM));
								}
							}
							if (fcbmpmcljhm != null)
							{
								if (fcbmpmcljhm.ICLNEPCODIK.Rank != GuildRank.Creator && mgcfkfppglm5.DCENLGCQFDN.Count > 0)
								{
									component.HJEFIPJDEEK(mgcfkfppglm5);
									goto IL_501;
								}
								goto IL_501;
							}
							else
							{
								if (mgcfkfppglm5.DCENLGCQFDN.Count > 0)
								{
									component.HJEFIPJDEEK(mgcfkfppglm5);
									goto IL_501;
								}
								goto IL_501;
							}
						}
					}
					goto IL_383;
				}
			}
			IL_501:
			if (CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG != StaffRank.None)
			{
				BMNBILHJHGP.MGCFKFPPGLM mgcfkfppglm6 = new BMNBILHJHGP.MGCFKFPPGLM();
				mgcfkfppglm6.NKKMJICKKLB = "[FF8888]Admin";
				mgcfkfppglm6.NPMDMKHKQNQ = true;
				if (CNCJKLNHQBH.QOQONHOOLNE.IBPEBDGDQLG == StaffRank.Developer)
				{
					mgcfkfppglm6.PKKLDKIIMHJ("Call", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.CallUser));
					mgcfkfppglm6.PKKLDKIIMHJ("Goto", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.GotoUser));
					mgcfkfppglm6.PKKLDKIIMHJ("Ban", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.BanUser));
				}
				mgcfkfppglm6.PKKLDKIIMHJ("Mute", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(CKMLKNPNPQO.QOQONHOOLNE.MuteUser));
				component.HJEFIPJDEEK(mgcfkfppglm6);
			}
		}
		else
		{
			NOHEMGHONKK qoqonhoolne2 = NOHEMGHONKK.QOQONHOOLNE;
			if (qoqonhoolne2 != null && qoqonhoolne2.IEICJDEDICD != null)
			{
				component.PKKLDKIIMHJ("Leave Guild", new BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ(qoqonhoolne2.IQCOIDLHJPB), null, null, false);
			}
		}
		Vector2 v = Input.mousePosition;
		Vector3 localPosition = v;
		localPosition.z = 0f;
		component.NKKMJICKKLB.PIDLOFMIEFQ = HHNBICLDQKI;
		float num = (float)gameObject.GetComponent<ENFMCDNLEQQ>().DFKQMMIQDOO;
		if (localPosition.x + 170f > (float)Screen.width)
		{
			localPosition.x = (float)(Screen.width - 170);
		}
		if (localPosition.y - num < 0f)
		{
			localPosition.y += num;
		}
		localPosition.x -= (float)Screen.width * 0.5f;
		localPosition.y -= (float)Screen.height * 0.5f;
		localPosition.x = (float)((int)localPosition.x);
		localPosition.y = (float)((int)localPosition.y);
		gameObject.transform.localPosition = localPosition;
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x000207B7 File Offset: 0x0001E9B7
	public static string HFKHODPJQOJ()
	{
		return CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH;
	}

	// Token: 0x0600513E RID: 20798 RVA: 0x000207CF File Offset: 0x0001E9CF
	[CompilerGenerated]
	private static int GJIFCJFHQCF(KeyValuePair<string, int> OMBOCJEKDFF)
	{
		return OMBOCJEKDFF.Value;
	}

	// Token: 0x04001164 RID: 4452
	public static int IPOEOCFGEIP;

	// Token: 0x04001165 RID: 4453
	public static int BGJPJCDBLFB = 1000;

	// Token: 0x04001166 RID: 4454
	public static string[] GLFOCQDNHQC;

	// Token: 0x04001167 RID: 4455
	public static KGQECFKLKOP.JPBJIJCKOBG DDBIKNCLDGI;

	// Token: 0x04001168 RID: 4456
	public static KGQECFKLKOP.BPHCGQMPMKB CNNFBFLDLLO;

	// Token: 0x04001169 RID: 4457
	public static KGQECFKLKOP.DKBCOJFQJHB PBOFHGEQIKO;

	// Token: 0x0400116A RID: 4458
	private static KGQECFKLKOP.GLNPQNLFKBQ EEILBMOOJHJ;

	// Token: 0x0400116B RID: 4459
	private static List<KGQECFKLKOP.KINDLGJMPDI> PGBCDJLIDOK;

	// Token: 0x0400116C RID: 4460
	public static Dictionary<string, Dictionary<string, Dictionary<string, string[]>>> OEFKBDGIFBL;

	// Token: 0x0400116D RID: 4461
	[CompilerGenerated]
	private static Func<KeyValuePair<string, int>, int> HNCJFHJNHDN;

	// Token: 0x0400116E RID: 4462
	[CompilerGenerated]
	private static Dictionary<string, int> FLGCJNOQKJE;

	// Token: 0x02000251 RID: 593
	public enum EMEQCLNIHNL
	{
		// Token: 0x04001170 RID: 4464
		Unset,
		// Token: 0x04001171 RID: 4465
		Erratic,
		// Token: 0x04001172 RID: 4466
		Fast,
		// Token: 0x04001173 RID: 4467
		MediumFast,
		// Token: 0x04001174 RID: 4468
		MediumSlow,
		// Token: 0x04001175 RID: 4469
		Slow,
		// Token: 0x04001176 RID: 4470
		Fluctuating
	}

	// Token: 0x02000252 RID: 594
	public enum LKHFHFNEKIJ
	{
		// Token: 0x04001178 RID: 4472
		None,
		// Token: 0x04001179 RID: 4473
		Male,
		// Token: 0x0400117A RID: 4474
		Female
	}

	// Token: 0x02000253 RID: 595
	public enum MMOPMGNGOQB
	{
		// Token: 0x0400117C RID: 4476
		None,
		// Token: 0x0400117D RID: 4477
		Adamant,
		// Token: 0x0400117E RID: 4478
		Bashful,
		// Token: 0x0400117F RID: 4479
		Bold,
		// Token: 0x04001180 RID: 4480
		Brave,
		// Token: 0x04001181 RID: 4481
		Calm,
		// Token: 0x04001182 RID: 4482
		Careful,
		// Token: 0x04001183 RID: 4483
		Docile,
		// Token: 0x04001184 RID: 4484
		Gentle,
		// Token: 0x04001185 RID: 4485
		Hardy,
		// Token: 0x04001186 RID: 4486
		Hasty,
		// Token: 0x04001187 RID: 4487
		Impish,
		// Token: 0x04001188 RID: 4488
		Jolly,
		// Token: 0x04001189 RID: 4489
		Lax,
		// Token: 0x0400118A RID: 4490
		Lonely,
		// Token: 0x0400118B RID: 4491
		Mild,
		// Token: 0x0400118C RID: 4492
		Modest,
		// Token: 0x0400118D RID: 4493
		Naive,
		// Token: 0x0400118E RID: 4494
		Naughty,
		// Token: 0x0400118F RID: 4495
		Quiet,
		// Token: 0x04001190 RID: 4496
		Quirky,
		// Token: 0x04001191 RID: 4497
		Rash,
		// Token: 0x04001192 RID: 4498
		Relaxed,
		// Token: 0x04001193 RID: 4499
		Sassy,
		// Token: 0x04001194 RID: 4500
		Serious,
		// Token: 0x04001195 RID: 4501
		Timid
	}

	// Token: 0x02000254 RID: 596
	public enum PFPBKQFQFFG
	{
		// Token: 0x04001197 RID: 4503
		None,
		// Token: 0x04001198 RID: 4504
		Fainted,
		// Token: 0x04001199 RID: 4505
		Burn,
		// Token: 0x0400119A RID: 4506
		Freeze,
		// Token: 0x0400119B RID: 4507
		Paralysis,
		// Token: 0x0400119C RID: 4508
		Poison,
		// Token: 0x0400119D RID: 4509
		Sleep,
		// Token: 0x0400119E RID: 4510
		BadlyPoisoned
	}

	// Token: 0x02000255 RID: 597
	public class JEMOPHMPLJB
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600513F RID: 20799 RVA: 0x000207D8 File Offset: 0x0001E9D8
		// (set) Token: 0x0600514E RID: 20814 RVA: 0x00020823 File Offset: 0x0001EA23
		public int EOCPIGECLCM { get; set; }

		// Token: 0x06005141 RID: 20801 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public void KHLNCDDHMHQ(int BGBMIEJJQKC)
		{
			this.<GFEJQBBHLMQ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x000207E9 File Offset: 0x0001E9E9
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x00020811 File Offset: 0x0001EA11
		public int OCNKGBBOOHF { get; set; }

		// Token: 0x06005143 RID: 20803 RVA: 0x000207F1 File Offset: 0x0001E9F1
		public int EJBLPILCDDD()
		{
			return this.<OJDPMCMQEEI>k__BackingField;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x000207F9 File Offset: 0x0001E9F9
		// (set) Token: 0x0600515A RID: 20826 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public int JOJCLQMGJJP { get; set; }

		// Token: 0x06005145 RID: 20805 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int IMDHJHNJIKQ()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x000207F1 File Offset: 0x0001E9F1
		// (set) Token: 0x06005171 RID: 20849 RVA: 0x0002082C File Offset: 0x0001EA2C
		public int BLHBPGMPPNI { get; set; }

		// Token: 0x06005147 RID: 20807 RVA: 0x00020801 File Offset: 0x0001EA01
		public int GLGIIGKJEJC()
		{
			return this.<NBEJFKBFBHP>k__BackingField;
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00020809 File Offset: 0x0001EA09
		public int PDNHQMJNONQ()
		{
			return this.<IQNDIGGMLPF>k__BackingField;
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x000207F1 File Offset: 0x0001E9F1
		public int IGKEBDDFGBJ()
		{
			return this.<OJDPMCMQEEI>k__BackingField;
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00020801 File Offset: 0x0001EA01
		public int FILLBJJJCHC()
		{
			return this.<NBEJFKBFBHP>k__BackingField;
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00020811 File Offset: 0x0001EA11
		public void DHGDDKDEHHM(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x0002081A File Offset: 0x0001EA1A
		public void JHIOCFNHCLG(int BGBMIEJJQKC)
		{
			this.<NBEJFKBFBHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x000207F9 File Offset: 0x0001E9F9
		public int JEKNFMFNPDF()
		{
			return this.<GFEJQBBHLMQ>k__BackingField;
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00020823 File Offset: 0x0001EA23
		public void LEQMKNLPKHI(int BGBMIEJJQKC)
		{
			this.<NKIKQJNNCQQ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00020811 File Offset: 0x0001EA11
		public void JBEEQJJEGOL(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x000207F9 File Offset: 0x0001E9F9
		public int BECCOHODMJG()
		{
			return this.<GFEJQBBHLMQ>k__BackingField;
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x0002082C File Offset: 0x0001EA2C
		public void MFDFLGQCKOO(int BGBMIEJJQKC)
		{
			this.<OJDPMCMQEEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00020835 File Offset: 0x0001EA35
		public void BGKDKPEFMJI(int BGBMIEJJQKC)
		{
			this.<IQNDIGGMLPF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0002081A File Offset: 0x0001EA1A
		public void KDPQNIPNBHD(int BGBMIEJJQKC)
		{
			this.<NBEJFKBFBHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x000207F9 File Offset: 0x0001E9F9
		public int FEKDIBBBBFH()
		{
			return this.<GFEJQBBHLMQ>k__BackingField;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x00020809 File Offset: 0x0001EA09
		// (set) Token: 0x06005158 RID: 20824 RVA: 0x00020835 File Offset: 0x0001EA35
		public int OHGEFICKJJN { get; set; }

		// Token: 0x06005157 RID: 20823 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public void CNQHCGCKDLM(int BGBMIEJJQKC)
		{
			this.<GFEJQBBHLMQ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x0002082C File Offset: 0x0001EA2C
		public void FBHCKFCQJDC(int BGBMIEJJQKC)
		{
			this.<OJDPMCMQEEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x0002082C File Offset: 0x0001EA2C
		public void KIODEJHFLDM(int BGBMIEJJQKC)
		{
			this.<OJDPMCMQEEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00020835 File Offset: 0x0001EA35
		public void MHDELFIJJMI(int BGBMIEJJQKC)
		{
			this.<IQNDIGGMLPF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00020823 File Offset: 0x0001EA23
		public void DOFDHGDMNBJ(int BGBMIEJJQKC)
		{
			this.<NKIKQJNNCQQ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x0002082C File Offset: 0x0001EA2C
		public void QBKHOPLHEJH(int BGBMIEJJQKC)
		{
			this.<OJDPMCMQEEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int BKNBBGNDJGB()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x0002082C File Offset: 0x0001EA2C
		public void FJKJJILNECP(int BGBMIEJJQKC)
		{
			this.<OJDPMCMQEEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00020811 File Offset: 0x0001EA11
		public void GOIDCIDMLCN(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00020809 File Offset: 0x0001EA09
		public int CLMPLCGNMKE()
		{
			return this.<IQNDIGGMLPF>k__BackingField;
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int EOBCCCKPLOE()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x00020835 File Offset: 0x0001EA35
		public void DEHIKNQGCNQ(int BGBMIEJJQKC)
		{
			this.<IQNDIGGMLPF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x00020811 File Offset: 0x0001EA11
		public void GOQNPJHBLMB(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x000207F9 File Offset: 0x0001E9F9
		public int LPKFPFEQDCI()
		{
			return this.<GFEJQBBHLMQ>k__BackingField;
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x0002081A File Offset: 0x0001EA1A
		public void CMGBEHMHDJQ(int BGBMIEJJQKC)
		{
			this.<NBEJFKBFBHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public void EQOCFKQLIQI(int BGBMIEJJQKC)
		{
			this.<GFEJQBBHLMQ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x00020801 File Offset: 0x0001EA01
		// (set) Token: 0x0600516A RID: 20842 RVA: 0x0002081A File Offset: 0x0001EA1A
		public int PFDGJOLJEHC { get; set; }

		// Token: 0x0600516B RID: 20843 RVA: 0x00020811 File Offset: 0x0001EA11
		public void LLJNDFDKODD(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00020801 File Offset: 0x0001EA01
		public int JHPPQPMDFMK()
		{
			return this.<NBEJFKBFBHP>k__BackingField;
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int KPOIGHHLNQJ()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00020801 File Offset: 0x0001EA01
		public int QEODDBNLQID()
		{
			return this.<NBEJFKBFBHP>k__BackingField;
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int ECCQKFLOJLN()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00020811 File Offset: 0x0001EA11
		public void CJGPQDKIENB(int BGBMIEJJQKC)
		{
			this.<PBKEJFOENNM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x0002081A File Offset: 0x0001EA1A
		public void QCLCPPFKMOF(int BGBMIEJJQKC)
		{
			this.<NBEJFKBFBHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00020801 File Offset: 0x0001EA01
		public int DJNQMFHEODO()
		{
			return this.<NBEJFKBFBHP>k__BackingField;
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x00020835 File Offset: 0x0001EA35
		public void GEHNNOIODBK(int BGBMIEJJQKC)
		{
			this.<IQNDIGGMLPF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x000207E9 File Offset: 0x0001E9E9
		public int HBDKQLFGMGJ()
		{
			return this.<PBKEJFOENNM>k__BackingField;
		}
	}

	// Token: 0x02000256 RID: 598
	public class FEKOIOJQNKH
	{
		// Token: 0x06005177 RID: 20855 RVA: 0x0002083E File Offset: 0x0001EA3E
		public void LQBNDHOCQEJ(int BGBMIEJJQKC)
		{
			this.<GJIIIFQCDHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x00020882 File Offset: 0x0001EA82
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x00020847 File Offset: 0x0001EA47
		public KGQECFKLKOP.PFPBKQFQFFG PLCBFLQBCQN { get; set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06005179 RID: 20857 RVA: 0x00020850 File Offset: 0x0001EA50
		// (set) Token: 0x0600518E RID: 20878 RVA: 0x000208F9 File Offset: 0x0001EAF9
		public string FOKJIJLEIDO { get; set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x00020A45 File Offset: 0x0001EC45
		// (set) Token: 0x0600517A RID: 20858 RVA: 0x00020858 File Offset: 0x0001EA58
		public int PELCNBCMNFH { get; set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x00020861 File Offset: 0x0001EA61
		// (set) Token: 0x060051A2 RID: 20898 RVA: 0x00020960 File Offset: 0x0001EB60
		public int BEQHNFFEHMQ { get; set; }

		// Token: 0x0600517C RID: 20860 RVA: 0x00020869 File Offset: 0x0001EA69
		public Guid GBNQEKLJFCI()
		{
			return this.<GQOFQMBDCQK>k__BackingField;
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00020871 File Offset: 0x0001EA71
		public void HOIEQINCNFI(int BGBMIEJJQKC)
		{
			this.<MHJGLGDKFCL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x0002087A File Offset: 0x0001EA7A
		// (set) Token: 0x0600519A RID: 20890 RVA: 0x00020947 File Offset: 0x0001EB47
		public KGQECFKLKOP.LKHFHFNEKIJ OQDOCCGPJDQ { get; set; }

		// Token: 0x06005180 RID: 20864 RVA: 0x0002088A File Offset: 0x0001EA8A
		public int GNBICQOEOMJ()
		{
			return this.<IOPGGIICMIC>k__BackingField;
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00020892 File Offset: 0x0001EA92
		public void EHHMQOODCFH(int BGBMIEJJQKC)
		{
			this.<QQGKKHEGFFK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x0002089B File Offset: 0x0001EA9B
		public void NHIFQFNBECF(KGQECFKLKOP.JEMOPHMPLJB BGBMIEJJQKC)
		{
			this.<CGNGPQQKQMI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x00020958 File Offset: 0x0001EB58
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public int CKPQFBKFLND { get; set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x000208AD File Offset: 0x0001EAAD
		// (set) Token: 0x06005193 RID: 20883 RVA: 0x00020871 File Offset: 0x0001EA71
		public int EOMPMQNGIBD { get; set; }

		// Token: 0x06005185 RID: 20869 RVA: 0x000208B5 File Offset: 0x0001EAB5
		public void IGNCCHJJGCI(KGQECFKLKOP.JEMOPHMPLJB BGBMIEJJQKC)
		{
			this.<KEOMQQMDBOC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x000209C7 File Offset: 0x0001EBC7
		// (set) Token: 0x06005186 RID: 20870 RVA: 0x0002089B File Offset: 0x0001EA9B
		public KGQECFKLKOP.JEMOPHMPLJB HHKJGOPMMQL { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06005187 RID: 20871 RVA: 0x000208BE File Offset: 0x0001EABE
		// (set) Token: 0x060051A7 RID: 20903 RVA: 0x00020984 File Offset: 0x0001EB84
		public int QKBGGCKIOLG { get; set; }

		// Token: 0x06005188 RID: 20872 RVA: 0x000208C6 File Offset: 0x0001EAC6
		public void JHMGIDEIELL(Guid BGBMIEJJQKC)
		{
			this.<GQOFQMBDCQK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x000208CF File Offset: 0x0001EACF
		public bool NQGGOHPGCQM()
		{
			return this.<KIIDNHIGEJK>k__BackingField;
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x000208D7 File Offset: 0x0001EAD7
		public string JJHDPCBQGLG()
		{
			return this.<GNPNLIHEQLO>k__BackingField;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600519D RID: 20893 RVA: 0x00020914 File Offset: 0x0001EB14
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x000208DF File Offset: 0x0001EADF
		public bool BKNFHNFFCHE { get; set; }

		// Token: 0x0600518C RID: 20876 RVA: 0x000208E8 File Offset: 0x0001EAE8
		public int CCMOCLMEKJN()
		{
			return this.<BEFLDEJNOHD>k__BackingField;
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x000208F0 File Offset: 0x0001EAF0
		public void PMLIIKLEBMI(int BGBMIEJJQKC)
		{
			this.<BEFLDEJNOHD>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x00020A22 File Offset: 0x0001EC22
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x00020902 File Offset: 0x0001EB02
		public KGQECFKLKOP.JEMOPHMPLJB ELNPOGIQCGK { get; set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x000208CF File Offset: 0x0001EACF
		// (set) Token: 0x06005190 RID: 20880 RVA: 0x0002090B File Offset: 0x0001EB0B
		public bool PQCNDKGBHHQ { get; set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x00020869 File Offset: 0x0001EA69
		// (set) Token: 0x06005191 RID: 20881 RVA: 0x000208C6 File Offset: 0x0001EAC6
		public Guid LDQDJLFIDCN { get; set; }

		// Token: 0x06005192 RID: 20882 RVA: 0x00020914 File Offset: 0x0001EB14
		public bool GEFODCNPFFI()
		{
			return this.<BGCNMNEJHNF>k__BackingField;
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x0002091C File Offset: 0x0001EB1C
		public void EKNHKNEFKQP(KGQECFKLKOP.JEMOPHMPLJB BGBMIEJJQKC)
		{
			this.<MQFBDBBJIJE>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00020A01 File Offset: 0x0001EC01
		// (set) Token: 0x06005195 RID: 20885 RVA: 0x00020925 File Offset: 0x0001EB25
		public int EGDMHCLOGCC { get; set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x0002092E File Offset: 0x0001EB2E
		// (set) Token: 0x060051A4 RID: 20900 RVA: 0x00020969 File Offset: 0x0001EB69
		public KGQECFKLKOP.EDHMLDLCFHC[] EEILBMOOJHJ { get; set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x000209B6 File Offset: 0x0001EBB6
		// (set) Token: 0x06005197 RID: 20887 RVA: 0x00020936 File Offset: 0x0001EB36
		public int GECLELHHNIO { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x0002093F File Offset: 0x0001EB3F
		// (set) Token: 0x060051A5 RID: 20901 RVA: 0x00020972 File Offset: 0x0001EB72
		public int DCFKMOILHEC { get; set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x000209A6 File Offset: 0x0001EBA6
		// (set) Token: 0x06005199 RID: 20889 RVA: 0x00020892 File Offset: 0x0001EA92
		public int PCIEOCNICGI { get; set; }

		// Token: 0x0600519B RID: 20891 RVA: 0x00020869 File Offset: 0x0001EA69
		public Guid KGMFIOCJLEP()
		{
			return this.<GQOFQMBDCQK>k__BackingField;
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00020869 File Offset: 0x0001EA69
		public Guid FCQMGQOEDLJ()
		{
			return this.<GQOFQMBDCQK>k__BackingField;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x000208E8 File Offset: 0x0001EAE8
		// (set) Token: 0x0600519E RID: 20894 RVA: 0x000208F0 File Offset: 0x0001EAF0
		public int QKNEIJQHGCB { get; set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x00020950 File Offset: 0x0001EB50
		// (set) Token: 0x060051B4 RID: 20916 RVA: 0x000209BE File Offset: 0x0001EBBE
		public string BHPMOFEKHPM { get; set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x000209AE File Offset: 0x0001EBAE
		// (set) Token: 0x060051A1 RID: 20897 RVA: 0x0002083E File Offset: 0x0001EA3E
		public int BNGBQLEQCPL { get; set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x000209E8 File Offset: 0x0001EBE8
		// (set) Token: 0x060051A3 RID: 20899 RVA: 0x0002091C File Offset: 0x0001EB1C
		public KGQECFKLKOP.JEMOPHMPLJB JQJCBJQNQGH { get; set; }

		// Token: 0x060051A6 RID: 20902 RVA: 0x0002097B File Offset: 0x0001EB7B
		public void KJHPHCELIEM(int BGBMIEJJQKC)
		{
			this.<FPOEPIBMHHL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00020950 File Offset: 0x0001EB50
		public string GQJGKFEBICQ()
		{
			return this.<DGPLEBNIOOK>k__BackingField;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x0002098D File Offset: 0x0001EB8D
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x0002097B File Offset: 0x0001EB7B
		public int JJLPBICFJKB { get; set; }

		// Token: 0x060051AA RID: 20906 RVA: 0x000208C6 File Offset: 0x0001EAC6
		public void FDLHKNJJQQH(Guid BGBMIEJJQKC)
		{
			this.<GQOFQMBDCQK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x0002088A File Offset: 0x0001EA8A
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x000209D7 File Offset: 0x0001EBD7
		public int BBJIGEGIEGN { get; set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x0002099E File Offset: 0x0001EB9E
		// (set) Token: 0x060051AC RID: 20908 RVA: 0x000208B5 File Offset: 0x0001EAB5
		public KGQECFKLKOP.JEMOPHMPLJB DGOCNDGDBOJ { get; set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x000209CF File Offset: 0x0001EBCF
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x00020995 File Offset: 0x0001EB95
		public string KICBMJDNCJQ { get; set; }

		// Token: 0x060051AE RID: 20910 RVA: 0x0002099E File Offset: 0x0001EB9E
		public KGQECFKLKOP.JEMOPHMPLJB PHNEOKOLPJH()
		{
			return this.<KEOMQQMDBOC>k__BackingField;
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00020969 File Offset: 0x0001EB69
		public void BNGOLEPOJGM(KGQECFKLKOP.EDHMLDLCFHC[] BGBMIEJJQKC)
		{
			this.<ELQCJJHCIJB>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x000209BE File Offset: 0x0001EBBE
		public void PGOOOKLGJKQ(string BGBMIEJJQKC)
		{
			this.<DGPLEBNIOOK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x000209E0 File Offset: 0x0001EBE0
		// (set) Token: 0x060051D8 RID: 20952 RVA: 0x00020A33 File Offset: 0x0001EC33
		public KGQECFKLKOP.MMOPMGNGOQB NIONIJNNKCE { get; set; }

		// Token: 0x060051BA RID: 20922 RVA: 0x0002083E File Offset: 0x0001EA3E
		public void QBIOBPFKCBK(int BGBMIEJJQKC)
		{
			this.<GJIIIFQCDHP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x000209F0 File Offset: 0x0001EBF0
		public int GQHJCIMDHEI()
		{
			return this.<FFJGJFPFNCM>k__BackingField;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x000208D7 File Offset: 0x0001EAD7
		// (set) Token: 0x060051BE RID: 20926 RVA: 0x000209F8 File Offset: 0x0001EBF8
		public string OMMNBECPELQ { get; set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x000209F0 File Offset: 0x0001EBF0
		// (set) Token: 0x060051C7 RID: 20935 RVA: 0x00020A09 File Offset: 0x0001EC09
		public int JENKCPBFNQC { get; set; }

		// Token: 0x060051C1 RID: 20929 RVA: 0x00020850 File Offset: 0x0001EA50
		public string MGDKFQILOEL()
		{
			return this.<INIMILKJHEI>k__BackingField;
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public void GMEHGLPQQIN(int BGBMIEJJQKC)
		{
			this.<QQLGIEBQCNN>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00020861 File Offset: 0x0001EA61
		public int EDGHHFPMHBL()
		{
			return this.<LHPNBDCCOKF>k__BackingField;
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x000209F8 File Offset: 0x0001EBF8
		public void KIFNIBMPFFP(string BGBMIEJJQKC)
		{
			this.<GNPNLIHEQLO>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00020972 File Offset: 0x0001EB72
		public void OJBCJLMDNIC(int BGBMIEJJQKC)
		{
			this.<PCBQBDFJJLB>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00020995 File Offset: 0x0001EB95
		public void EHDCIPCBMHG(string BGBMIEJJQKC)
		{
			this.<JINCCLHHOMD>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x00020A12 File Offset: 0x0001EC12
		// (set) Token: 0x060051D7 RID: 20951 RVA: 0x00020A2A File Offset: 0x0001EC2A
		public int GNLNPCCPBCF { get; set; }

		// Token: 0x060051CB RID: 20939 RVA: 0x00020972 File Offset: 0x0001EB72
		public void PFLNFKGPHFP(int BGBMIEJJQKC)
		{
			this.<PCBQBDFJJLB>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x00020A1A File Offset: 0x0001EC1A
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x00020A3C File Offset: 0x0001EC3C
		public string HHNOCOQJOJF { get; set; }

		// Token: 0x060051CF RID: 20943 RVA: 0x000209A6 File Offset: 0x0001EBA6
		public int HFKQMNDQKNG()
		{
			return this.<QQGKKHEGFFK>k__BackingField;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x000208F9 File Offset: 0x0001EAF9
		public void HPNHCMMQHNF(string BGBMIEJJQKC)
		{
			this.<INIMILKJHEI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00020950 File Offset: 0x0001EB50
		public string DCIPHBMEILB()
		{
			return this.<DGPLEBNIOOK>k__BackingField;
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00020869 File Offset: 0x0001EA69
		public Guid KPJLEOCJFFO()
		{
			return this.<GQOFQMBDCQK>k__BackingField;
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00020882 File Offset: 0x0001EA82
		public KGQECFKLKOP.PFPBKQFQFFG HBBQJQEQGMP()
		{
			return this.<FNKDDQJEBJL>k__BackingField;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00020892 File Offset: 0x0001EA92
		public void CQHJHGHHEPP(int BGBMIEJJQKC)
		{
			this.<QQGKKHEGFFK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x0002097B File Offset: 0x0001EB7B
		public void EMDGBLLKKKD(int BGBMIEJJQKC)
		{
			this.<FPOEPIBMHHL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x0002087A File Offset: 0x0001EA7A
		public KGQECFKLKOP.LKHFHFNEKIJ BGOBJOJBPPK()
		{
			return this.<OCFJCJPKOHD>k__BackingField;
		}

		// Token: 0x040011C2 RID: 4546
		public PokemonMoveID[] HMOJBOLDNNI;

		// Token: 0x040011C3 RID: 4547
		public PokemonID PEIDDQJBENJ;

		// Token: 0x040011C4 RID: 4548
		public EggState CQQPFJQINIM;
	}

	// Token: 0x02000257 RID: 599
	public enum NHDNHHGJDHG
	{
		// Token: 0x040011C8 RID: 4552
		FocusUser,
		// Token: 0x040011C9 RID: 4553
		FocusPlayer,
		// Token: 0x040011CA RID: 4554
		Idle,
		// Token: 0x040011CB RID: 4555
		Idle2,
		// Token: 0x040011CC RID: 4556
		HitFoe,
		// Token: 0x040011CD RID: 4557
		HitUser,
		// Token: 0x040011CE RID: 4558
		SelectFoe,
		// Token: 0x040011CF RID: 4559
		SelectUser,
		// Token: 0x040011D0 RID: 4560
		SelectField,
		// Token: 0x040011D1 RID: 4561
		Default,
		// Token: 0x040011D2 RID: 4562
		Still
	}

	// Token: 0x02000258 RID: 600
	public class EDHMLDLCFHC
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x00020A67 File Offset: 0x0001EC67
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x00020A4D File Offset: 0x0001EC4D
		public string FBCKQEDONJK { get; set; }

		// Token: 0x060051DE RID: 20958 RVA: 0x00020A4D File Offset: 0x0001EC4D
		public void GNJLGJQCJOI(string BGBMIEJJQKC)
		{
			this.<QFOQINJNPOL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00020A56 File Offset: 0x0001EC56
		public void CKOQNHHLHMD(string BGBMIEJJQKC)
		{
			this.<GJNKDDQLEKM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00020A56 File Offset: 0x0001EC56
		public void DNEICCPKCBL(string BGBMIEJJQKC)
		{
			this.<GJNKDDQLEKM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00020A5F File Offset: 0x0001EC5F
		public int PPPDMFPGPDD()
		{
			return this.<MMLLCGLQENF>k__BackingField;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x00020A5F File Offset: 0x0001EC5F
		// (set) Token: 0x060051F8 RID: 20984 RVA: 0x00020AA2 File Offset: 0x0001ECA2
		public int JPLIFCNPICK { get; set; }

		// Token: 0x060051E3 RID: 20963 RVA: 0x00020A56 File Offset: 0x0001EC56
		public void DKJCNPPBPEI(string BGBMIEJJQKC)
		{
			this.<GJNKDDQLEKM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x00020A6F File Offset: 0x0001EC6F
		// (set) Token: 0x060051F7 RID: 20983 RVA: 0x00020A99 File Offset: 0x0001EC99
		public bool DONPNIFGBBF { get; set; }

		// Token: 0x060051E6 RID: 20966 RVA: 0x00020A77 File Offset: 0x0001EC77
		public string NKCPBOHKQBM()
		{
			return this.<GJNKDDQLEKM>k__BackingField;
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00020A4D File Offset: 0x0001EC4D
		public void FQNNCDMMJKE(string BGBMIEJJQKC)
		{
			this.<QFOQINJNPOL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x00020A5F File Offset: 0x0001EC5F
		public int DJJLKKGDCKF()
		{
			return this.<MMLLCGLQENF>k__BackingField;
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00020A67 File Offset: 0x0001EC67
		public string DHFJQINPMBH()
		{
			return this.<QFOQINJNPOL>k__BackingField;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00020AAB File Offset: 0x0001ECAB
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x00020A7F File Offset: 0x0001EC7F
		public string ILBCCCBJNCL { get; set; }

		// Token: 0x060051EB RID: 20971 RVA: 0x00020A88 File Offset: 0x0001EC88
		public int HLHBPNMEMIC()
		{
			return this.<FHMQCFCBOJL>k__BackingField;
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00020A90 File Offset: 0x0001EC90
		public void HPMPDPMMGFE(int BGBMIEJJQKC)
		{
			this.<FHMQCFCBOJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00020A90 File Offset: 0x0001EC90
		public void LFPNPJIDOGE(int BGBMIEJJQKC)
		{
			this.<FHMQCFCBOJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x00020A7F File Offset: 0x0001EC7F
		public void MQLBDHPCIHE(string BGBMIEJJQKC)
		{
			this.<HNDKGMMOJOI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00020A99 File Offset: 0x0001EC99
		public void BDOHOCGPKPB(bool BGBMIEJJQKC)
		{
			this.<BBMFLPKKKNB>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x00020A77 File Offset: 0x0001EC77
		public string NBKOCBDGKQO()
		{
			return this.<GJNKDDQLEKM>k__BackingField;
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00020A7F File Offset: 0x0001EC7F
		public void DOKKEQBNODN(string BGBMIEJJQKC)
		{
			this.<HNDKGMMOJOI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00020A77 File Offset: 0x0001EC77
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x00020A56 File Offset: 0x0001EC56
		public string CIQFCJGQEMH { get; set; }

		// Token: 0x060051F5 RID: 20981 RVA: 0x00020AA2 File Offset: 0x0001ECA2
		public void QPPQLOIHJKQ(int BGBMIEJJQKC)
		{
			this.<MMLLCGLQENF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00020AA2 File Offset: 0x0001ECA2
		public void BIBOCQIFDDG(int BGBMIEJJQKC)
		{
			this.<MMLLCGLQENF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x00020A88 File Offset: 0x0001EC88
		// (set) Token: 0x060051F9 RID: 20985 RVA: 0x00020A90 File Offset: 0x0001EC90
		public int LIQCECMEOIJ { get; set; }

		// Token: 0x060051FB RID: 20987 RVA: 0x00020A88 File Offset: 0x0001EC88
		public int EIQJMIMCEGE()
		{
			return this.<FHMQCFCBOJL>k__BackingField;
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00020A4D File Offset: 0x0001EC4D
		public void CKDGGBOMOGO(string BGBMIEJJQKC)
		{
			this.<QFOQINJNPOL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00020AA2 File Offset: 0x0001ECA2
		public void JMMIPIBDEKL(int BGBMIEJJQKC)
		{
			this.<MMLLCGLQENF>k__BackingField = BGBMIEJJQKC;
		}
	}

	// Token: 0x02000259 RID: 601
	public class GPFFQQMDFPB
	{
		// Token: 0x040011D9 RID: 4569
		public int DBPKNCDGGEP;

		// Token: 0x040011DA RID: 4570
		public int CBBBCEMLMLP;

		// Token: 0x040011DB RID: 4571
		public int QKBGGCKIOLG;

		// Token: 0x040011DC RID: 4572
		public int DCFKMOILHEC;

		// Token: 0x040011DD RID: 4573
		public bool OEBEBPJEINC;

		// Token: 0x040011DE RID: 4574
		public int EOMPMQNGIBD;

		// Token: 0x040011DF RID: 4575
		public bool BKNFHNFFCHE;

		// Token: 0x040011E0 RID: 4576
		public int HFLNDOPMBLE;

		// Token: 0x040011E1 RID: 4577
		public string OQDOCCGPJDQ = string.Empty;

		// Token: 0x040011E2 RID: 4578
		public string PLCBFLQBCQN = string.Empty;

		// Token: 0x040011E3 RID: 4579
		public KGQECFKLKOP.EDHMLDLCFHC[] EEILBMOOJHJ = new KGQECFKLKOP.EDHMLDLCFHC[4];

		// Token: 0x040011E4 RID: 4580
		public bool CPOJBKCQPHK;

		// Token: 0x040011E5 RID: 4581
		public bool NEBPMMPMQBD;

		// Token: 0x040011E6 RID: 4582
		public bool JHCFQOPLHQE;

		// Token: 0x040011E7 RID: 4583
		public bool IHIMHNGOLQJ;

		// Token: 0x040011E8 RID: 4584
		public string HHNOCOQJOJF;

		// Token: 0x040011E9 RID: 4585
		public int QKNEIJQHGCB;

		// Token: 0x040011EA RID: 4586
		public bool BPHKNGMPLML;

		// Token: 0x040011EB RID: 4587
		public bool FGQHEDFQIFC;

		// Token: 0x040011EC RID: 4588
		public string BHPMOFEKHPM = string.Empty;

		// Token: 0x040011ED RID: 4589
		public string KMNQBFKKNMB;

		// Token: 0x040011EE RID: 4590
		public bool NGHNKQHLQBB;

		// Token: 0x040011EF RID: 4591
		public bool DQNDIMFPMBM;
	}

	// Token: 0x0200025A RID: 602
	public class IJHPPMDDKIE
	{
		// Token: 0x06005200 RID: 20992 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		public bool MGQHOMNFHDL()
		{
			return this.<KOKHILDLNLH>k__BackingField;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x00020B34 File Offset: 0x0001ED34
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public ItemCategory CLEMKHNIPEI { get; set; }

		// Token: 0x06005202 RID: 20994 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void GONOKKHBNHI(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00020B02 File Offset: 0x0001ED02
		public int FQOOHOOPFOH()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00020B0A File Offset: 0x0001ED0A
		// (set) Token: 0x06005253 RID: 21075 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public bool LBNCFLKGCBH { get; set; }

		// Token: 0x06005205 RID: 20997 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void KFLQIHKFQBN(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x00020B1B File Offset: 0x0001ED1B
		public bool LOPGPBQQOOP()
		{
			return this.<CNLHQIMIEMF>k__BackingField;
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void PDIBQDOQQEQ(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00020B23 File Offset: 0x0001ED23
		public void OINGOHBICNQ(bool BGBMIEJJQKC)
		{
			this.<CNLHQIMIEMF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00020B2C File Offset: 0x0001ED2C
		// (set) Token: 0x0600525D RID: 21085 RVA: 0x00020B78 File Offset: 0x0001ED78
		public bool PQCNDKGBHHQ { get; set; }

		// Token: 0x0600520C RID: 21004 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void MCIJHJBBODP(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00020B45 File Offset: 0x0001ED45
		public void BQQQHOKFKEC(ItemTarget BGBMIEJJQKC)
		{
			this.<BCIOJMMFOLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x00020B4E File Offset: 0x0001ED4E
		// (set) Token: 0x06005258 RID: 21080 RVA: 0x00020B12 File Offset: 0x0001ED12
		public uint IFFFLJINPPQ { get; set; }

		// Token: 0x0600520F RID: 21007 RVA: 0x00020B56 File Offset: 0x0001ED56
		public void HKNKLONQFQN(bool BGBMIEJJQKC)
		{
			this.<KOKHILDLNLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void LFQEIHJMBGB(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool NFHMMDJNIKL()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public void IEOCDQKPBFP(ItemCategory BGBMIEJJQKC)
		{
			this.<PEGCOEEINJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06005247 RID: 21063 RVA: 0x00020B68 File Offset: 0x0001ED68
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x00020B45 File Offset: 0x0001ED45
		public ItemTarget JILENMCJCHF { get; set; }

		// Token: 0x06005214 RID: 21012 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void MDHQFPCMCMH(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00020B68 File Offset: 0x0001ED68
		public ItemTarget FEMOIOPMLNC()
		{
			return this.<BCIOJMMFOLI>k__BackingField;
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x00020B68 File Offset: 0x0001ED68
		public ItemTarget HDGBNKQBFGN()
		{
			return this.<BCIOJMMFOLI>k__BackingField;
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00020B45 File Offset: 0x0001ED45
		public void KMBIJNPPKQM(ItemTarget BGBMIEJJQKC)
		{
			this.<BCIOJMMFOLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x00020B68 File Offset: 0x0001ED68
		public ItemTarget PLINJOIECJD()
		{
			return this.<BCIOJMMFOLI>k__BackingField;
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void BHKGCCEIGLQ(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool CMCPGDIKKOQ()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x00020B2C File Offset: 0x0001ED2C
		public bool PCIONNCGEOK()
		{
			return this.<KIIDNHIGEJK>k__BackingField;
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void QKLLHENIDCL(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		public bool OMEFGOCNLQO()
		{
			return this.<KOKHILDLNLH>k__BackingField;
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00020B23 File Offset: 0x0001ED23
		public void HFBKQLQCDCI(bool BGBMIEJJQKC)
		{
			this.<CNLHQIMIEMF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00020B45 File Offset: 0x0001ED45
		public void BKKIPBHLFEP(ItemTarget BGBMIEJJQKC)
		{
			this.<BCIOJMMFOLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00020B70 File Offset: 0x0001ED70
		public ItemPocket MOEDNLLOQBG()
		{
			return this.<EILNJLMMLPJ>k__BackingField;
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00020B45 File Offset: 0x0001ED45
		public void GQFDIDDFPKM(ItemTarget BGBMIEJJQKC)
		{
			this.<BCIOJMMFOLI>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00020B68 File Offset: 0x0001ED68
		public ItemTarget BHJGOJMDEFJ()
		{
			return this.<BCIOJMMFOLI>k__BackingField;
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void FFJEHJMILCP(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00020B4E File Offset: 0x0001ED4E
		public uint NJLQNHJLNDC()
		{
			return this.<CIJOPGBKNQG>k__BackingField;
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00020B4E File Offset: 0x0001ED4E
		public uint DFNBFIFFQMB()
		{
			return this.<CIJOPGBKNQG>k__BackingField;
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00020B2C File Offset: 0x0001ED2C
		public bool LQFIDFIKOKO()
		{
			return this.<KIIDNHIGEJK>k__BackingField;
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00020B2C File Offset: 0x0001ED2C
		public bool JDEQGIBHPCE()
		{
			return this.<KIIDNHIGEJK>k__BackingField;
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void GJPHOKODBIO(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void EFCHIPINJEG(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public void OPLNNPOCQGK(ItemCategory BGBMIEJJQKC)
		{
			this.<PEGCOEEINJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		public bool EKHOPODHKKK()
		{
			return this.<KOKHILDLNLH>k__BackingField;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x00020B70 File Offset: 0x0001ED70
		// (set) Token: 0x0600522C RID: 21036 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public ItemPocket EEKHLKJMCLD { get; set; }

		// Token: 0x0600522D RID: 21037 RVA: 0x00020B68 File Offset: 0x0001ED68
		public ItemTarget JCOENGICDQK()
		{
			return this.<BCIOJMMFOLI>k__BackingField;
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool OPGLDCLOKEC()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00020B70 File Offset: 0x0001ED70
		public ItemPocket KMGEEDFNOJH()
		{
			return this.<EILNJLMMLPJ>k__BackingField;
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00020B2C File Offset: 0x0001ED2C
		public bool QBHFODPEHDK()
		{
			return this.<KIIDNHIGEJK>k__BackingField;
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00020B56 File Offset: 0x0001ED56
		public void JNOBHLDHQBP(bool BGBMIEJJQKC)
		{
			this.<KOKHILDLNLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public void OHKPQLHNEOI(ItemCategory BGBMIEJJQKC)
		{
			this.<PEGCOEEINJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00020B1B File Offset: 0x0001ED1B
		public bool IECCGCPNNLO()
		{
			return this.<CNLHQIMIEMF>k__BackingField;
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void ELOEGECOCCB(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void QJBCNEFKEEJ(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00020B70 File Offset: 0x0001ED70
		public ItemPocket OCKBFGFPJLL()
		{
			return this.<EILNJLMMLPJ>k__BackingField;
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void FBPLHEEGKOK(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00020B02 File Offset: 0x0001ED02
		public int HLMQODIHBIG()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x00020B02 File Offset: 0x0001ED02
		// (set) Token: 0x06005263 RID: 21091 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public int DBPKNCDGGEP { get; set; }

		// Token: 0x0600523A RID: 21050 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void EFIGFPHLPNI(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void LDNNFMLDKMQ(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void DNFQHHLHEGH(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public void ICKBELFQQLI(ItemCategory BGBMIEJJQKC)
		{
			this.<PEGCOEEINJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00020B4E File Offset: 0x0001ED4E
		public uint EHPJLLIEPDP()
		{
			return this.<CIJOPGBKNQG>k__BackingField;
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void GHQLMFGLDCJ(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void LKOEEGNCMDC(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void QOHMCLEEFHC(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00020B34 File Offset: 0x0001ED34
		public ItemCategory QLGFDFKBHMN()
		{
			return this.<PEGCOEEINJL>k__BackingField;
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00020B4E File Offset: 0x0001ED4E
		public uint EQCJBDOQDBB()
		{
			return this.<CIJOPGBKNQG>k__BackingField;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x00020B1B File Offset: 0x0001ED1B
		// (set) Token: 0x06005244 RID: 21060 RVA: 0x00020B23 File Offset: 0x0001ED23
		public bool OJFFMQCKCML { get; set; }

		// Token: 0x06005245 RID: 21061 RVA: 0x00020B34 File Offset: 0x0001ED34
		public ItemCategory KJLJHGEECPK()
		{
			return this.<PEGCOEEINJL>k__BackingField;
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00020B02 File Offset: 0x0001ED02
		public int DBCHHNGOKGD()
		{
			return this.<ECPFNNLOFPC>k__BackingField;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600524A RID: 21066 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		// (set) Token: 0x06005248 RID: 21064 RVA: 0x00020B56 File Offset: 0x0001ED56
		public bool EBOKELDPMMO { get; set; }

		// Token: 0x06005249 RID: 21065 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public void EFJJPJGCQGE(ItemCategory BGBMIEJJQKC)
		{
			this.<PEGCOEEINJL>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void JJBLNNNHDJD(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00020B1B File Offset: 0x0001ED1B
		public bool HNPDJKCEGBC()
		{
			return this.<CNLHQIMIEMF>k__BackingField;
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool PQDBIDNDHIO()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void KGCKKCFFEBK(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void QEPHCKEHOBB(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool DJNKMJIFDKN()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00020B23 File Offset: 0x0001ED23
		public void FGBJICIGBLB(bool BGBMIEJJQKC)
		{
			this.<CNLHQIMIEMF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void NKMFBNLOCIP(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public void BOOBMKJFLDN(bool BGBMIEJJQKC)
		{
			this.<KMBFJDLQKNP>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public void DOLOICOBPPK(int BGBMIEJJQKC)
		{
			this.<ECPFNNLOFPC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void DKQQDMICNLQ(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00020B1B File Offset: 0x0001ED1B
		public bool DLMIPEEGBFI()
		{
			return this.<CNLHQIMIEMF>k__BackingField;
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00020B78 File Offset: 0x0001ED78
		public void MHEDJDFNQDE(bool BGBMIEJJQKC)
		{
			this.<KIIDNHIGEJK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void KMDDMBMGGJH(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00020B0A File Offset: 0x0001ED0A
		public bool LLEBKQKNIHJ()
		{
			return this.<KMBFJDLQKNP>k__BackingField;
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public void NKJHNBKJFEL(ItemPocket BGBMIEJJQKC)
		{
			this.<EILNJLMMLPJ>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00020B12 File Offset: 0x0001ED12
		public void LBDPINBPFNL(uint BGBMIEJJQKC)
		{
			this.<CIJOPGBKNQG>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00020B56 File Offset: 0x0001ED56
		public void NMGENCPENJC(bool BGBMIEJJQKC)
		{
			this.<KOKHILDLNLH>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00020B45 File Offset: 0x0001ED45
		public void PQBKMHOHHFJ(ItemTarget BGBMIEJJQKC)
		{
			this.<BCIOJMMFOLI>k__BackingField = BGBMIEJJQKC;
		}
	}

	// Token: 0x0200025B RID: 603
	public class KINDLGJMPDI
	{
		// Token: 0x040011F9 RID: 4601
		public string FPQBICGEHMJ;

		// Token: 0x040011FA RID: 4602
		public string DBPKNCDGGEP;

		// Token: 0x040011FB RID: 4603
		public string KFFQQDLOLLQ;
	}

	// Token: 0x0200025C RID: 604
	public enum EKOKQPFGLDM
	{
		// Token: 0x040011FD RID: 4605
		Default,
		// Token: 0x040011FE RID: 4606
		ChoosePokemon,
		// Token: 0x040011FF RID: 4607
		CheckYesNo,
		// Token: 0x04001200 RID: 4608
		BattleOnly
	}

	// Token: 0x0200025D RID: 605
	public class Item
	{
		// Token: 0x06005265 RID: 21093 RVA: 0x00020B81 File Offset: 0x0001ED81
		public int QCQPPPFPCQH()
		{
			return this.<ItemImage>k__BackingField;
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00020B89 File Offset: 0x0001ED89
		public void JFEEKKNJHNQ(int BGBMIEJJQKC)
		{
			this.<Usage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string LGOODGEDFQG()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00020B9A File Offset: 0x0001ED9A
		public void IJKNHJPHOMC(int BGBMIEJJQKC)
		{
			this.<ItemImage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00020B89 File Offset: 0x0001ED89
		public void HCJOPJJMDNJ(int BGBMIEJJQKC)
		{
			this.<Usage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00020B81 File Offset: 0x0001ED81
		public int LEQLIKKPHHI()
		{
			return this.<ItemImage>k__BackingField;
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void QLLDDMGKBDP(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x00020BAC File Offset: 0x0001EDAC
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public int Border { get; set; }

		// Token: 0x0600526D RID: 21101 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string PGEGEFKDKBB()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public string JQBDPHILQJO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public int OCFQDGNMIID()
		{
			return this.<Usage>k__BackingField;
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int CJDBOLCHOHB()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00020B81 File Offset: 0x0001ED81
		public int MQIHCHFOPGE()
		{
			return this.<ItemImage>k__BackingField;
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void EPNBMLMLNOM(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00020B89 File Offset: 0x0001ED89
		public void ECQEEENOOFP(int BGBMIEJJQKC)
		{
			this.<Usage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x00020BDF File Offset: 0x0001EDDF
		// (set) Token: 0x06005274 RID: 21108 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public int ID { get; set; }

		// Token: 0x06005275 RID: 21109 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string PNKGBNPIILC()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		// (set) Token: 0x06005276 RID: 21110 RVA: 0x00020BCD File Offset: 0x0001EDCD
		public int Pocket { get; set; }

		// Token: 0x06005277 RID: 21111 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void CBONLPHLJBE(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00020BDF File Offset: 0x0001EDDF
		public int HLMQODIHBIG()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x00020BE7 File Offset: 0x0001EDE7
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public string BattleID { get; set; }

		// Token: 0x0600527B RID: 21115 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int KNCLHNILJOM()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void OEQFQJJGIJF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public void PPIIIQOQILK(string BGBMIEJJQKC)
		{
			this.<BattleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int POPCGFGIGDG()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public int LLCFQMHKLIJ()
		{
			return this.<Pocket>k__BackingField;
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00020B9A File Offset: 0x0001ED9A
		public void MODIQBHNQNB(int BGBMIEJJQKC)
		{
			this.<ItemImage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600529E RID: 21150 RVA: 0x00020B81 File Offset: 0x0001ED81
		// (set) Token: 0x06005282 RID: 21122 RVA: 0x00020B9A File Offset: 0x0001ED9A
		public int ItemImage { get; set; }

		// Token: 0x06005283 RID: 21123 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string NKDOCPOOIIF()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public int FCNJQHJHNBE()
		{
			return this.<Usage>k__BackingField;
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void CBEFIPDMHKQ(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00020BCD File Offset: 0x0001EDCD
		public void LFQEIHJMBGB(int BGBMIEJJQKC)
		{
			this.<Pocket>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00020C00 File Offset: 0x0001EE00
		public void DLINMELDGGD(string BGBMIEJJQKC)
		{
			this.<Description>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public string DFNQHDEDDKE()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void QQKGFJLHGPH(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string QKMHPDJNJHE()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void NDBFJQGCBEG(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060052A2 RID: 21154 RVA: 0x00020B92 File Offset: 0x0001ED92
		// (set) Token: 0x0600528D RID: 21133 RVA: 0x00020C00 File Offset: 0x0001EE00
		public string Description { get; set; }

		// Token: 0x0600528E RID: 21134 RVA: 0x00020BDF File Offset: 0x0001EDDF
		public int GMOFFIFDCGE()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int OLDFMIBHHCI()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void NKKOJBNFGPP(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void KODLFNGFDGM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void GIQJNJLEHDF(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void NEMGOCGHDPN(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00020BE7 File Offset: 0x0001EDE7
		public string LBKHIMFJEBI()
		{
			return this.<BattleID>k__BackingField;
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public int DBHGNBHDNDM()
		{
			return this.<Usage>k__BackingField;
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00020BE7 File Offset: 0x0001EDE7
		public string CKQBHDLPHLE()
		{
			return this.<BattleID>k__BackingField;
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void QEDMCFLMPBD(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00020BBC File Offset: 0x0001EDBC
		public int BLOKGPEPBQJ()
		{
			return this.<Usage>k__BackingField;
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00020B9A File Offset: 0x0001ED9A
		public void LCFHJPNOPOJ(int BGBMIEJJQKC)
		{
			this.<ItemImage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void KFGKFQDGKDC(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00020C00 File Offset: 0x0001EE00
		public void LFNNKGLHKGO(string BGBMIEJJQKC)
		{
			this.<Description>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00020B89 File Offset: 0x0001ED89
		public void OFCEHLFBCQK(int BGBMIEJJQKC)
		{
			this.<Usage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public int PCGLBJBJCHM()
		{
			return this.<Pocket>k__BackingField;
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int HPPJBCJDJFK()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string JLECCEINFBO()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public int QLNBQIPHLBK()
		{
			return this.<Pocket>k__BackingField;
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00020B89 File Offset: 0x0001ED89
		public void FQHCJIMFNFN(int BGBMIEJJQKC)
		{
			this.<Usage>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void JMNODFDMGBO(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int NNCEFMCKOKM()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public string NDPGCGDLEEQ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void BPDOKQQEMBI(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void IQBEQNBMQJK(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public void LQQJDIODPED(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		// (set) Token: 0x060052AC RID: 21164 RVA: 0x00020BD6 File Offset: 0x0001EDD6
		public string Name { get; set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x00020BBC File Offset: 0x0001EDBC
		// (set) Token: 0x060052AF RID: 21167 RVA: 0x00020B89 File Offset: 0x0001ED89
		public int Usage { get; set; }

		// Token: 0x060052AE RID: 21166 RVA: 0x00020BAC File Offset: 0x0001EDAC
		public int KPDNLOJHIJQ()
		{
			return this.<Border>k__BackingField;
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public void KPPGCIEFKJK(string BGBMIEJJQKC)
		{
			this.<BattleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		public void JGQBNMDGHJC(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00020BB4 File Offset: 0x0001EDB4
		public string FLFQBGJQBBD()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00020B92 File Offset: 0x0001ED92
		public string OELFFKHICPQ()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public void PJLLMCJGDEQ(int BGBMIEJJQKC)
		{
			this.<Border>k__BackingField = BGBMIEJJQKC;
		}
	}

	// Token: 0x0200025E RID: 606
	public class BPHCGQMPMKB
	{
		// Token: 0x04001209 RID: 4617
		public KGQECFKLKOP.Item[] items;
	}

	// Token: 0x0200025F RID: 607
	public class ModelID
	{
		// Token: 0x060052B7 RID: 21175 RVA: 0x00020C09 File Offset: 0x0001EE09
		public void MDHHKMIELQF(int BGBMIEJJQKC)
		{
			this.<MaleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00020C12 File Offset: 0x0001EE12
		public int IJOOHEDKQGQ()
		{
			return this.<MaleID>k__BackingField;
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00020C1A File Offset: 0x0001EE1A
		public int BHFKKGOLPIC()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00020C12 File Offset: 0x0001EE12
		public int BDJNHCCQHNO()
		{
			return this.<MaleID>k__BackingField;
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00020C22 File Offset: 0x0001EE22
		public void DOLOICOBPPK(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x00020C1A File Offset: 0x0001EE1A
		// (set) Token: 0x060052C0 RID: 21184 RVA: 0x00020C22 File Offset: 0x0001EE22
		public int ID { get; set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x00020C12 File Offset: 0x0001EE12
		// (set) Token: 0x060052BD RID: 21181 RVA: 0x00020C09 File Offset: 0x0001EE09
		public int MaleID { get; set; }

		// Token: 0x060052BE RID: 21182 RVA: 0x00020C2B File Offset: 0x0001EE2B
		public int QPDFPHPBNNL()
		{
			return this.<MegaYID>k__BackingField;
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00020C12 File Offset: 0x0001EE12
		public int BBDNPQBOFFM()
		{
			return this.<MaleID>k__BackingField;
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00020C33 File Offset: 0x0001EE33
		public void LNINHIKJOIL(int BGBMIEJJQKC)
		{
			this.<MegaYID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public string JJGEFDFEKEP()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00020C44 File Offset: 0x0001EE44
		public void DDMNKIDJGBM(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00020C1A File Offset: 0x0001EE1A
		public int HEDEMELEHGG()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060052C5 RID: 21189 RVA: 0x00020C4D File Offset: 0x0001EE4D
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x00020C95 File Offset: 0x0001EE95
		public int MegaID { get; set; }

		// Token: 0x060052C6 RID: 21190 RVA: 0x00020C2B File Offset: 0x0001EE2B
		public int EMPENLEJGKK()
		{
			return this.<MegaYID>k__BackingField;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060052E0 RID: 21216 RVA: 0x00020C3C File Offset: 0x0001EE3C
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x00020C44 File Offset: 0x0001EE44
		public string Name { get; set; }

		// Token: 0x060052C8 RID: 21192 RVA: 0x00020C09 File Offset: 0x0001EE09
		public void KCFQQHILHHG(int BGBMIEJJQKC)
		{
			this.<MaleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00020C55 File Offset: 0x0001EE55
		public void GNEMEBCPDGK(int BGBMIEJJQKC)
		{
			this.<PrimalID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00020C5E File Offset: 0x0001EE5E
		public int ECDEGKLGJOE()
		{
			return this.<FemaleID>k__BackingField;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public string JPMMGDNMPQC()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00020C66 File Offset: 0x0001EE66
		public int QOEPDGFCEHF()
		{
			return this.<PrimalID>k__BackingField;
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00020C33 File Offset: 0x0001EE33
		public void MJJOCLGCQPB(int BGBMIEJJQKC)
		{
			this.<MegaYID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00020C55 File Offset: 0x0001EE55
		public void FJQCHBNLMDC(int BGBMIEJJQKC)
		{
			this.<PrimalID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00020C22 File Offset: 0x0001EE22
		public void NPHPLCOHEOK(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060052D1 RID: 21201 RVA: 0x00020C66 File Offset: 0x0001EE66
		// (set) Token: 0x060052E3 RID: 21219 RVA: 0x00020C55 File Offset: 0x0001EE55
		public int PrimalID { get; set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060052D9 RID: 21209 RVA: 0x00020C2B File Offset: 0x0001EE2B
		// (set) Token: 0x060052D3 RID: 21203 RVA: 0x00020C33 File Offset: 0x0001EE33
		public int MegaYID { get; set; }

		// Token: 0x060052D4 RID: 21204 RVA: 0x00020C09 File Offset: 0x0001EE09
		public void EEGIQQCQGKN(int BGBMIEJJQKC)
		{
			this.<MaleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00020C22 File Offset: 0x0001EE22
		public void HHDMJKHLDIB(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00020C8C File Offset: 0x0001EE8C
		public void HKIDLKNJCJJ(int BGBMIEJJQKC)
		{
			this.<FemaleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00020C1A File Offset: 0x0001EE1A
		public int IENCOLEBINI()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x00020C44 File Offset: 0x0001EE44
		public void EHPKFKNPCLJ(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00020C44 File Offset: 0x0001EE44
		public void NHMMOILLEGF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00020C12 File Offset: 0x0001EE12
		public int IDINLFBJKPG()
		{
			return this.<MaleID>k__BackingField;
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x00020C5E File Offset: 0x0001EE5E
		public int HICCIBLNGDP()
		{
			return this.<FemaleID>k__BackingField;
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00020C8C File Offset: 0x0001EE8C
		public void GDOINEHPGMI(int BGBMIEJJQKC)
		{
			this.<FemaleID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00020C22 File Offset: 0x0001EE22
		public void KNPJIQQEBFN(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x00020C5E File Offset: 0x0001EE5E
		// (set) Token: 0x060052E1 RID: 21217 RVA: 0x00020C8C File Offset: 0x0001EE8C
		public int FemaleID { get; set; }

		// Token: 0x060052E4 RID: 21220 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public string BMCDGFMQJFB()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00020C95 File Offset: 0x0001EE95
		public void LEBLMBEIKPL(int BGBMIEJJQKC)
		{
			this.<MegaID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00020C2B File Offset: 0x0001EE2B
		public int LONGOKIBGQK()
		{
			return this.<MegaYID>k__BackingField;
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00020C1A File Offset: 0x0001EE1A
		public int BHKILNEIMHI()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x00020C33 File Offset: 0x0001EE33
		public void GFCJIEKJKMM(int BGBMIEJJQKC)
		{
			this.<MegaYID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00020C22 File Offset: 0x0001EE22
		public void QOHMCLEEFHC(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public string NCEFDJLMGOJ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00020C12 File Offset: 0x0001EE12
		public int PHIDQIFFDGI()
		{
			return this.<MaleID>k__BackingField;
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public string HMNNMFHDKQQ()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00020C55 File Offset: 0x0001EE55
		public void GFIJJLHHNOF(int BGBMIEJJQKC)
		{
			this.<PrimalID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00020C33 File Offset: 0x0001EE33
		public void CGCKPEOGNCC(int BGBMIEJJQKC)
		{
			this.<MegaYID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00020C5E File Offset: 0x0001EE5E
		public int GPMQEQNNKEB()
		{
			return this.<FemaleID>k__BackingField;
		}

		// Token: 0x04001211 RID: 4625
		public float ScaleFactor = 1f;

		// Token: 0x04001212 RID: 4626
		public float ScaleFactorMega = 1f;
	}

	// Token: 0x02000260 RID: 608
	public class DKBCOJFQJHB
	{
		// Token: 0x04001213 RID: 4627
		public KGQECFKLKOP.ModelID[] Pokemon;
	}

	// Token: 0x02000261 RID: 609
	public class MoveInfo
	{
		// Token: 0x060052F1 RID: 21233 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void HGNPBKKGHOD(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060052F2 RID: 21234 RVA: 0x00020CA7 File Offset: 0x0001EEA7
		// (set) Token: 0x06005334 RID: 21300 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public string ACC { get; set; }

		// Token: 0x060052F3 RID: 21235 RVA: 0x00020CAF File Offset: 0x0001EEAF
		public string FFFMCHDOOOI()
		{
			return this.<Power>k__BackingField;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x00020CB7 File Offset: 0x0001EEB7
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x00020D25 File Offset: 0x0001EF25
		public string PP { get; set; }

		// Token: 0x060052F5 RID: 21237 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public void QLGLDDKOBBI(string BGBMIEJJQKC)
		{
			this.<Power>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public string MGQFELMKFFK()
		{
			return this.<Type>k__BackingField;
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void GPJDOILOLDJ(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00020CD0 File Offset: 0x0001EED0
		public int IDINCDEMFJF()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public string DBQIBEDQKCF()
		{
			return this.<Type>k__BackingField;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060052FB RID: 21243 RVA: 0x00020CD0 File Offset: 0x0001EED0
		// (set) Token: 0x060052FF RID: 21247 RVA: 0x00020CE9 File Offset: 0x0001EEE9
		public int ID { get; set; }

		// Token: 0x060052FC RID: 21244 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void PNCDDQFEGFI(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void BIHNCGBEFJI(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060052FE RID: 21246 RVA: 0x00020CE1 File Offset: 0x0001EEE1
		// (set) Token: 0x06005319 RID: 21273 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public string Category { get; set; }

		// Token: 0x06005300 RID: 21248 RVA: 0x00020CE9 File Offset: 0x0001EEE9
		public void QLLOMDNKEEO(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00020CF2 File Offset: 0x0001EEF2
		public string IBIOONEJCMJ()
		{
			return this.<BattleID>k__BackingField;
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void OMGEHGQPNDI(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x00020D0A File Offset: 0x0001EF0A
		public string Type { get; set; }

		// Token: 0x06005304 RID: 21252 RVA: 0x00020CD0 File Offset: 0x0001EED0
		public int BDOMBJBDGQC()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00020CFA File Offset: 0x0001EEFA
		public string DFNQHDEDDKE()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public void IEQCNMOLIEK(string BGBMIEJJQKC)
		{
			this.<Power>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00020CB7 File Offset: 0x0001EEB7
		public string MEQCECHDEIP()
		{
			return this.<PP>k__BackingField;
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00020CA7 File Offset: 0x0001EEA7
		public string QCBKIHIKPCG()
		{
			return this.<ACC>k__BackingField;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public void KKQKIBCLQEP(string BGBMIEJJQKC)
		{
			this.<Power>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public string PDKNHHDCQOE()
		{
			return this.<Type>k__BackingField;
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public void OOLHFEEKNEQ(string BGBMIEJJQKC)
		{
			this.<Power>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void KOBKHDHGJEK(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x00020D02 File Offset: 0x0001EF02
		// (set) Token: 0x06005310 RID: 21264 RVA: 0x00020D13 File Offset: 0x0001EF13
		public string Description { get; set; }

		// Token: 0x0600530E RID: 21262 RVA: 0x00020D0A File Offset: 0x0001EF0A
		public void ONHEELGIEDJ(string BGBMIEJJQKC)
		{
			this.<Type>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void EQPDPMOMMDF(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void HCCNLNCLEMM(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void NBFPIEMJIDH(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00020CE1 File Offset: 0x0001EEE1
		public string DPDGNFHLQMF()
		{
			return this.<Category>k__BackingField;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x00020CAF File Offset: 0x0001EEAF
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public string Power { get; set; }

		// Token: 0x06005315 RID: 21269 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public string CMOOQIDINKO()
		{
			return this.<Type>k__BackingField;
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x00020CD0 File Offset: 0x0001EED0
		public int BKBDEHGFGKJ()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00020D13 File Offset: 0x0001EF13
		public void OOBMCBEFPGI(string BGBMIEJJQKC)
		{
			this.<Description>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x00020CE9 File Offset: 0x0001EEE9
		public void BHCFJIPGBFF(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x00020CE9 File Offset: 0x0001EEE9
		public void EQPIDGKCKFP(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public void CCMJNJQPJFC(string BGBMIEJJQKC)
		{
			this.<Power>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600531D RID: 21277 RVA: 0x00020CF2 File Offset: 0x0001EEF2
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x00020D2E File Offset: 0x0001EF2E
		public string BattleID { get; set; }

		// Token: 0x0600531E RID: 21278 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public void GHPFFIEQNJP(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void BDJHKDDDPKG(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public void DFEMCBPDBJF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06005321 RID: 21281 RVA: 0x00020CFA File Offset: 0x0001EEFA
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public string Name { get; set; }

		// Token: 0x06005322 RID: 21282 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void EFJJPJGCQGE(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x00020CD8 File Offset: 0x0001EED8
		public void JNNLNMPHNCJ(string BGBMIEJJQKC)
		{
			this.<Category>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void QNIJMQQHLQN(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00020D0A File Offset: 0x0001EF0A
		public void BFHDCFICJNH(string BGBMIEJJQKC)
		{
			this.<Type>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x00020CF2 File Offset: 0x0001EEF2
		public string BPCLFJGEBJB()
		{
			return this.<BattleID>k__BackingField;
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x00020CD0 File Offset: 0x0001EED0
		public int LIJPCCBNFQD()
		{
			return this.<ID>k__BackingField;
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x00020CB7 File Offset: 0x0001EEB7
		public string QLMIQGLGQCC()
		{
			return this.<PP>k__BackingField;
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x00020CA7 File Offset: 0x0001EEA7
		public string BLLFNBKDCMJ()
		{
			return this.<ACC>k__BackingField;
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x00020D1C File Offset: 0x0001EF1C
		public void LNPFBNNOFFF(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public string OCCQGODQGPC()
		{
			return this.<Type>k__BackingField;
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00020D0A File Offset: 0x0001EF0A
		public void CFOMFKCIEQM(string BGBMIEJJQKC)
		{
			this.<Type>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00020CFA File Offset: 0x0001EEFA
		public string IGLOGLEBNQO()
		{
			return this.<Name>k__BackingField;
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00020CE1 File Offset: 0x0001EEE1
		public string QHEJQOCDJGL()
		{
			return this.<Category>k__BackingField;
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00020C9E File Offset: 0x0001EE9E
		public void CBKHNMEHHHE(string BGBMIEJJQKC)
		{
			this.<ACC>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00020CA7 File Offset: 0x0001EEA7
		public string QPGFMHBJPCE()
		{
			return this.<ACC>k__BackingField;
		}
	}

	// Token: 0x02000262 RID: 610
	public class GLNPQNLFKBQ
	{
		// Token: 0x0400121D RID: 4637
		public KGQECFKLKOP.MoveInfo[] Moves;
	}

	// Token: 0x02000263 RID: 611
	public class PokedexInfo
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x00020D37 File Offset: 0x0001EF37
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		public int EVSPDEF { get; set; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x00020D3F File Offset: 0x0001EF3F
		// (set) Token: 0x0600536C RID: 21356 RVA: 0x00020E8A File Offset: 0x0001F08A
		public int CaptureRate { get; set; }

		// Token: 0x06005339 RID: 21305 RVA: 0x00020D3F File Offset: 0x0001EF3F
		public int MLGEGIFILHP()
		{
			return this.<CaptureRate>k__BackingField;
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00020D47 File Offset: 0x0001EF47
		public int BDQOHCDOFGP()
		{
			return this.<EggCycles>k__BackingField;
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		// (set) Token: 0x0600533B RID: 21307 RVA: 0x00020D4F File Offset: 0x0001EF4F
		public int HP { get; set; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x00020D58 File Offset: 0x0001EF58
		// (set) Token: 0x0600534E RID: 21326 RVA: 0x00020DE9 File Offset: 0x0001EFE9
		public int SPD { get; set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x00020D60 File Offset: 0x0001EF60
		// (set) Token: 0x0600539A RID: 21402 RVA: 0x00020E56 File Offset: 0x0001F056
		public string Height { get; set; }

		// Token: 0x0600533E RID: 21310 RVA: 0x00020D68 File Offset: 0x0001EF68
		public void CFEHFIGIPLG(string BGBMIEJJQKC)
		{
			this.<Type2>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00020D71 File Offset: 0x0001EF71
		public int NEJHOQMJCJE()
		{
			return this.<EVATK>k__BackingField;
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00020D79 File Offset: 0x0001EF79
		public string IGMOEONIJJF()
		{
			return this.<Type2>k__BackingField;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x00020E2C File Offset: 0x0001F02C
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x00020D81 File Offset: 0x0001EF81
		public int ID { get; set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x00020DB7 File Offset: 0x0001EFB7
		// (set) Token: 0x06005342 RID: 21314 RVA: 0x00020D8A File Offset: 0x0001EF8A
		public string Species { get; set; }

		// Token: 0x06005343 RID: 21315 RVA: 0x00020D93 File Offset: 0x0001EF93
		public void GEHCOJFFMML(int BGBMIEJJQKC)
		{
			this.<BaseHappiness>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06005397 RID: 21399 RVA: 0x00020F03 File Offset: 0x0001F103
		// (set) Token: 0x06005344 RID: 21316 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public int BaseExp { get; set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x00020DFA File Offset: 0x0001EFFA
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x00020DA5 File Offset: 0x0001EFA5
		public int EVSPD { get; set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x00020F1C File Offset: 0x0001F11C
		// (set) Token: 0x06005346 RID: 21318 RVA: 0x00020DAE File Offset: 0x0001EFAE
		public int EVSPATK { get; set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x00020DBF File Offset: 0x0001EFBF
		// (set) Token: 0x06005376 RID: 21366 RVA: 0x00020E9B File Offset: 0x0001F09B
		public int EVDEF { get; set; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x00020D71 File Offset: 0x0001EF71
		// (set) Token: 0x06005354 RID: 21332 RVA: 0x00020E1B File Offset: 0x0001F01B
		public int EVATK { get; set; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x00020DC7 File Offset: 0x0001EFC7
		// (set) Token: 0x06005388 RID: 21384 RVA: 0x00020EAD File Offset: 0x0001F0AD
		public int DEF { get; set; }

		// Token: 0x0600534B RID: 21323 RVA: 0x00020DCF File Offset: 0x0001EFCF
		public int ILECQIKPEPI()
		{
			return this.<SPATK>k__BackingField;
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00020DD7 File Offset: 0x0001EFD7
		public void PHGPEMNQKDM(int BGBMIEJJQKC)
		{
			this.<ATK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x00020E02 File Offset: 0x0001F002
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		public string Ability2 { get; set; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600534F RID: 21327 RVA: 0x00020DF2 File Offset: 0x0001EFF2
		// (set) Token: 0x06005352 RID: 21330 RVA: 0x00020E0A File Offset: 0x0001F00A
		public string Weight { get; set; }

		// Token: 0x06005351 RID: 21329 RVA: 0x00020E02 File Offset: 0x0001F002
		public string QLOBICEOMBF()
		{
			return this.<Ability2>k__BackingField;
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00020E13 File Offset: 0x0001F013
		public string ILOMPJBLEHO()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x00020D68 File Offset: 0x0001EF68
		public void CFJEQHECDCP(string BGBMIEJJQKC)
		{
			this.<Type2>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x00020E24 File Offset: 0x0001F024
		public int HBEPNELQMLF()
		{
			return this.<SPDEF>k__BackingField;
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x00020E0A File Offset: 0x0001F00A
		public void JKCNPBMHDFQ(string BGBMIEJJQKC)
		{
			this.<Weight>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x00020E3D File Offset: 0x0001F03D
		// (set) Token: 0x06005359 RID: 21337 RVA: 0x00020E34 File Offset: 0x0001F034
		public string ExpRate { get; set; }

		// Token: 0x0600535A RID: 21338 RVA: 0x00020D47 File Offset: 0x0001EF47
		public int NBOHOPLMQIM()
		{
			return this.<EggCycles>k__BackingField;
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x00020E4E File Offset: 0x0001F04E
		// (set) Token: 0x0600535B RID: 21339 RVA: 0x00020D93 File Offset: 0x0001EF93
		public int BaseHappiness { get; set; }

		// Token: 0x0600535D RID: 21341 RVA: 0x00020DBF File Offset: 0x0001EFBF
		public int QIIDLMDDGPM()
		{
			return this.<EVDEF>k__BackingField;
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00020E02 File Offset: 0x0001F002
		public string DNGJDQNNNML()
		{
			return this.<Ability2>k__BackingField;
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00020E3D File Offset: 0x0001F03D
		public string BLMMBKNKHFL()
		{
			return this.<ExpRate>k__BackingField;
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00020E45 File Offset: 0x0001F045
		public void EDBMPGQMFLF(string BGBMIEJJQKC)
		{
			this.<Ability3>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00020E56 File Offset: 0x0001F056
		public void NPDIGQHGOKJ(string BGBMIEJJQKC)
		{
			this.<Height>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x00020E5F File Offset: 0x0001F05F
		// (set) Token: 0x06005382 RID: 21378 RVA: 0x00020EC7 File Offset: 0x0001F0C7
		public double RatioM { get; set; }

		// Token: 0x06005364 RID: 21348 RVA: 0x00020D47 File Offset: 0x0001EF47
		public int JJDBEJMBMEO()
		{
			return this.<EggCycles>k__BackingField;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00020E67 File Offset: 0x0001F067
		public void LQQJDIODPED(string BGBMIEJJQKC)
		{
			this.<Name>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x00020E93 File Offset: 0x0001F093
		// (set) Token: 0x06005366 RID: 21350 RVA: 0x00020E70 File Offset: 0x0001F070
		public string Ability1 { get; set; }

		// Token: 0x06005367 RID: 21351 RVA: 0x00020E79 File Offset: 0x0001F079
		public void FCBFHMGGJJM(string BGBMIEJJQKC)
		{
			this.<Description>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x00020EB6 File Offset: 0x0001F0B6
		// (set) Token: 0x06005368 RID: 21352 RVA: 0x00020E45 File Offset: 0x0001F045
		public string Ability3 { get; set; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x00020E13 File Offset: 0x0001F013
		// (set) Token: 0x0600538D RID: 21389 RVA: 0x00020E79 File Offset: 0x0001F079
		public string Description { get; set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x00020E82 File Offset: 0x0001F082
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x00020F13 File Offset: 0x0001F113
		public int EVHP { get; set; }

		// Token: 0x0600536B RID: 21355 RVA: 0x00020E13 File Offset: 0x0001F013
		public string LGOODGEDFQG()
		{
			return this.<Description>k__BackingField;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x00020F0B File Offset: 0x0001F10B
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x00020DD7 File Offset: 0x0001EFD7
		public int ATK { get; set; }

		// Token: 0x0600536E RID: 21358 RVA: 0x00020DCF File Offset: 0x0001EFCF
		public int KGLNBBQLDIO()
		{
			return this.<SPATK>k__BackingField;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06005383 RID: 21379 RVA: 0x00020D79 File Offset: 0x0001EF79
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x00020D68 File Offset: 0x0001EF68
		public string Type2 { get; set; }

		// Token: 0x06005371 RID: 21361 RVA: 0x00020DC7 File Offset: 0x0001EFC7
		public int PIHNCFDOHJC()
		{
			return this.<DEF>k__BackingField;
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00020D71 File Offset: 0x0001EF71
		public int KKMNOIGJOKJ()
		{
			return this.<EVATK>k__BackingField;
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00020E93 File Offset: 0x0001F093
		public string GIDDJOJEMLH()
		{
			return this.<Ability1>k__BackingField;
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00020D79 File Offset: 0x0001EF79
		public string CFCMMIKCQCD()
		{
			return this.<Type2>k__BackingField;
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00020D81 File Offset: 0x0001EF81
		public void MJJPLJOKMMH(int BGBMIEJJQKC)
		{
			this.<ID>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600538E RID: 21390 RVA: 0x00020EEA File Offset: 0x0001F0EA
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x00020EA4 File Offset: 0x0001F0A4
		public string Type { get; set; }

		// Token: 0x06005379 RID: 21369 RVA: 0x00020E5F File Offset: 0x0001F05F
		public double CEHEEKCKJQO()
		{
			return this.<RatioM>k__BackingField;
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00020E24 File Offset: 0x0001F024
		public int LMEGFPQPDKI()
		{
			return this.<SPDEF>k__BackingField;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06005395 RID: 21397 RVA: 0x00020EFB File Offset: 0x0001F0FB
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x00020E67 File Offset: 0x0001F067
		public string Name { get; set; }

		// Token: 0x0600537C RID: 21372 RVA: 0x00020E82 File Offset: 0x0001F082
		public int GOQGPQLHQFI()
		{
			return this.<EVHP>k__BackingField;
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00020DF2 File Offset: 0x0001EFF2
		public string IPKMIHLCEOF()
		{
			return this.<Weight>k__BackingField;
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00020EAD File Offset: 0x0001F0AD
		public void GPOEJIQGNBE(int BGBMIEJJQKC)
		{
			this.<DEF>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00020E93 File Offset: 0x0001F093
		public string KBLGGEOMBEL()
		{
			return this.<Ability1>k__BackingField;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x00020E24 File Offset: 0x0001F024
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x00020EBE File Offset: 0x0001F0BE
		public int SPDEF { get; set; }

		// Token: 0x06005384 RID: 21380 RVA: 0x00020E93 File Offset: 0x0001F093
		public string JMCNGQNFCPI()
		{
			return this.<Ability1>k__BackingField;
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		public int MOOGMOLJCFC()
		{
			return this.<HP>k__BackingField;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06005386 RID: 21382 RVA: 0x00020DCF File Offset: 0x0001EFCF
		// (set) Token: 0x0600538B RID: 21387 RVA: 0x00020EE1 File Offset: 0x0001F0E1
		public int SPATK { get; set; }

		// Token: 0x06005389 RID: 21385 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		public int PGGEGHIDIHE()
		{
			return this.<HP>k__BackingField;
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x00020D47 File Offset: 0x0001EF47
		// (set) Token: 0x06005391 RID: 21393 RVA: 0x00020EF2 File Offset: 0x0001F0F2
		public int EggCycles { get; set; }

		// Token: 0x0600538F RID: 21391 RVA: 0x00020D3F File Offset: 0x0001EF3F
		public int KPFGHNQCCDO()
		{
			return this.<CaptureRate>k__BackingField;
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00020EE1 File Offset: 0x0001F0E1
		public void GGGPJMQDGPB(int BGBMIEJJQKC)
		{
			this.<SPATK>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00020D47 File Offset: 0x0001EF47
		public int LJGCDOCFPFK()
		{
			return this.<EggCycles>k__BackingField;
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00020E5F File Offset: 0x0001F05F
		public double QLMNOIPHCJD()
		{
			return this.<RatioM>k__BackingField;
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00020D93 File Offset: 0x0001EF93
		public void MNLDLFLQPIB(int BGBMIEJJQKC)
		{
			this.<BaseHappiness>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00020EC7 File Offset: 0x0001F0C7
		public void BJENFBFCHEJ(double BGBMIEJJQKC)
		{
			this.<RatioM>k__BackingField = BGBMIEJJQKC;
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00020D58 File Offset: 0x0001EF58
		public int BCQDOBBIBIM()
		{
			return this.<SPD>k__BackingField;
		}
	}

	// Token: 0x02000264 RID: 612
	public class JPBJIJCKOBG
	{
		// Token: 0x0400123B RID: 4667
		public KGQECFKLKOP.PokedexInfo[] Pokemon;
	}
}
