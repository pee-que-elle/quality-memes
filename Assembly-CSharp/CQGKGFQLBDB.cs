using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200009E RID: 158
public static class CQGKGFQLBDB
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0000AF12 File Offset: 0x00009112
	// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000AF35 File Offset: 0x00009135
	public static Dictionary<string, string[]> HIFFBEJOJBL
	{
		get
		{
			if (!CQGKGFQLBDB.NLIOLJLFNHF)
			{
				CQGKGFQLBDB.GGJKPBGBONJ(PlayerPrefs.GetString("Language", "English"));
			}
			return CQGKGFQLBDB.GNMGBJNHBQB;
		}
		set
		{
			CQGKGFQLBDB.NLIOLJLFNHF = (value != null);
			CQGKGFQLBDB.GNMGBJNHBQB = value;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0000AF49 File Offset: 0x00009149
	public static string[] HOCNQMMBILD
	{
		get
		{
			if (!CQGKGFQLBDB.NLIOLJLFNHF)
			{
				CQGKGFQLBDB.GGJKPBGBONJ(PlayerPrefs.GetString("Language", "English"));
			}
			return CQGKGFQLBDB.FNLEPBFJOOL;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0000AF6C File Offset: 0x0000916C
	// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0000AF9E File Offset: 0x0000919E
	public static string PIBGCBIKMBQ
	{
		get
		{
			if (string.IsNullOrEmpty(CQGKGFQLBDB.EFDGFKNNJFQ))
			{
				CQGKGFQLBDB.EFDGFKNNJFQ = PlayerPrefs.GetString("Language", "English");
				CQGKGFQLBDB.MIKHEPCQHNQ(CQGKGFQLBDB.EFDGFKNNJFQ);
			}
			return CQGKGFQLBDB.EFDGFKNNJFQ;
		}
		set
		{
			if (CQGKGFQLBDB.EFDGFKNNJFQ != value)
			{
				CQGKGFQLBDB.EFDGFKNNJFQ = value;
				CQGKGFQLBDB.MIKHEPCQHNQ(value);
			}
		}
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x0009665C File Offset: 0x0009485C
	private static bool GGJKPBGBONJ(string BGBMIEJJQKC)
	{
		byte[] array = null;
		if (!CQGKGFQLBDB.NLIOLJLFNHF)
		{
			if (CQGKGFQLBDB.JLJONQCLQEG == null)
			{
				TextAsset textAsset = Resources.Load<TextAsset>("Localization");
				if (textAsset != null)
				{
					array = textAsset.bytes;
				}
			}
			else
			{
				array = CQGKGFQLBDB.JLJONQCLQEG("Localization");
			}
			CQGKGFQLBDB.NLIOLJLFNHF = true;
		}
		if (CQGKGFQLBDB.GPLGDLPGDNB(array, false))
		{
			return true;
		}
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			BGBMIEJJQKC = CQGKGFQLBDB.EFDGFKNNJFQ;
		}
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			return false;
		}
		if (CQGKGFQLBDB.JLJONQCLQEG == null)
		{
			TextAsset textAsset2 = Resources.Load<TextAsset>(BGBMIEJJQKC);
			if (textAsset2 != null)
			{
				array = textAsset2.bytes;
			}
		}
		else
		{
			array = CQGKGFQLBDB.JLJONQCLQEG(BGBMIEJJQKC);
		}
		if (array != null)
		{
			CQGKGFQLBDB.PJMIKDIEGMB(BGBMIEJJQKC, array);
			return true;
		}
		return false;
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x0009670C File Offset: 0x0009490C
	private static bool MIKHEPCQHNQ(string BGBMIEJJQKC)
	{
		if (!string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (CQGKGFQLBDB.GNMGBJNHBQB.Count == 0 && !CQGKGFQLBDB.GGJKPBGBONJ(BGBMIEJJQKC))
			{
				return false;
			}
			if (CQGKGFQLBDB.JQGBQCLBLCL(BGBMIEJJQKC))
			{
				return true;
			}
		}
		if (CQGKGFQLBDB.QBLHDLEBGCF.Count > 0)
		{
			return true;
		}
		CQGKGFQLBDB.QBLHDLEBGCF.Clear();
		CQGKGFQLBDB.GNMGBJNHBQB.Clear();
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			PlayerPrefs.DeleteKey("Language");
		}
		return false;
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00096778 File Offset: 0x00094978
	public static void BJNHBGHBHII(TextAsset FKFHDHMFOFH)
	{
		MNBLBMJJHKQ mnblbmjjhkq = new MNBLBMJJHKQ(FKFHDHMFOFH);
		CQGKGFQLBDB.PJMIKDIEGMB(FKFHDHMFOFH.name, mnblbmjjhkq.MJPQDDGKQJD());
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x000967A0 File Offset: 0x000949A0
	public static void PJMIKDIEGMB(string NBQPQQQJQKJ, byte[] BLJJPLEBHGQ)
	{
		MNBLBMJJHKQ mnblbmjjhkq = new MNBLBMJJHKQ(BLJJPLEBHGQ);
		CQGKGFQLBDB.PJMIKDIEGMB(NBQPQQQJQKJ, mnblbmjjhkq.MJPQDDGKQJD());
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x0000AFBA File Offset: 0x000091BA
	public static void MLDFPQOBQMP(string LOHECPFGPGO, string QJFQOMOIOOI)
	{
		if (!string.IsNullOrEmpty(QJFQOMOIOOI))
		{
			CQGKGFQLBDB.JMJCOBLDNNJ[LOHECPFGPGO] = QJFQOMOIOOI;
		}
		else
		{
			CQGKGFQLBDB.JMJCOBLDNNJ.Remove(LOHECPFGPGO);
		}
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x0000AFDE File Offset: 0x000091DE
	public static void LKBHLNKGGHN()
	{
		CQGKGFQLBDB.JMJCOBLDNNJ.Clear();
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x0000AFEA File Offset: 0x000091EA
	public static bool GPLGDLPGDNB(TextAsset FKFHDHMFOFH, bool EMFFGHJLDEK = false)
	{
		return CQGKGFQLBDB.GPLGDLPGDNB(FKFHDHMFOFH.bytes, FKFHDHMFOFH, EMFFGHJLDEK);
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x0000AFF9 File Offset: 0x000091F9
	public static bool GPLGDLPGDNB(byte[] BLJJPLEBHGQ, bool EMFFGHJLDEK = false)
	{
		return CQGKGFQLBDB.GPLGDLPGDNB(BLJJPLEBHGQ, null, EMFFGHJLDEK);
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x000967C0 File Offset: 0x000949C0
	private static bool CELGBFEHGKE(string NBQPQQQJQKJ)
	{
		int i = 0;
		int num = CQGKGFQLBDB.FNLEPBFJOOL.Length;
		while (i < num)
		{
			if (CQGKGFQLBDB.FNLEPBFJOOL[i] == NBQPQQQJQKJ)
			{
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x000967F4 File Offset: 0x000949F4
	private static bool GPLGDLPGDNB(byte[] BLJJPLEBHGQ, TextAsset FKFHDHMFOFH, bool EMFFGHJLDEK = false)
	{
		if (BLJJPLEBHGQ == null)
		{
			return false;
		}
		MNBLBMJJHKQ mnblbmjjhkq = new MNBLBMJJHKQ(BLJJPLEBHGQ);
		MHIDKMCBQEN<string> mhidkmcbqen = mnblbmjjhkq.DLODCMNNJJC();
		if (mhidkmcbqen.BJGMIBBEGDQ < 2)
		{
			return false;
		}
		mhidkmcbqen.IBGPNNLOENC(0);
		string[] array = null;
		if (string.IsNullOrEmpty(CQGKGFQLBDB.EFDGFKNNJFQ))
		{
			CQGKGFQLBDB.NLIOLJLFNHF = false;
		}
		if (CQGKGFQLBDB.NLIOLJLFNHF && (EMFFGHJLDEK || CQGKGFQLBDB.LMKLMQKPKIO) && CQGKGFQLBDB.FNLEPBFJOOL != null && CQGKGFQLBDB.FNLEPBFJOOL.Length != 0)
		{
			array = new string[mhidkmcbqen.BJGMIBBEGDQ];
			for (int i = 0; i < mhidkmcbqen.BJGMIBBEGDQ; i++)
			{
				array[i] = mhidkmcbqen.get_KNPPMKBOGDL(i);
			}
			for (int j = 0; j < mhidkmcbqen.BJGMIBBEGDQ; j++)
			{
				if (!CQGKGFQLBDB.CELGBFEHGKE(mhidkmcbqen.get_KNPPMKBOGDL(j)))
				{
					int num = CQGKGFQLBDB.FNLEPBFJOOL.Length + 1;
					Array.Resize<string>(ref CQGKGFQLBDB.FNLEPBFJOOL, num);
					CQGKGFQLBDB.FNLEPBFJOOL[num - 1] = mhidkmcbqen.get_KNPPMKBOGDL(j);
					Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
					foreach (KeyValuePair<string, string[]> keyValuePair in CQGKGFQLBDB.GNMGBJNHBQB)
					{
						string[] value = keyValuePair.Value;
						Array.Resize<string>(ref value, num);
						value[num - 1] = value[0];
						dictionary.Add(keyValuePair.Key, value);
					}
					CQGKGFQLBDB.GNMGBJNHBQB = dictionary;
				}
			}
		}
		else
		{
			CQGKGFQLBDB.GNMGBJNHBQB.Clear();
			CQGKGFQLBDB.FNLEPBFJOOL = new string[mhidkmcbqen.BJGMIBBEGDQ];
			if (!CQGKGFQLBDB.NLIOLJLFNHF)
			{
				CQGKGFQLBDB.EFDGFKNNJFQ = PlayerPrefs.GetString("Language", mhidkmcbqen.get_KNPPMKBOGDL(0));
				CQGKGFQLBDB.NLIOLJLFNHF = true;
			}
			for (int k = 0; k < mhidkmcbqen.BJGMIBBEGDQ; k++)
			{
				CQGKGFQLBDB.FNLEPBFJOOL[k] = mhidkmcbqen.get_KNPPMKBOGDL(k);
				if (CQGKGFQLBDB.FNLEPBFJOOL[k] == CQGKGFQLBDB.EFDGFKNNJFQ)
				{
					CQGKGFQLBDB.PJCFHPCMEPQ = k;
				}
			}
		}
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		for (int l = 0; l < CQGKGFQLBDB.FNLEPBFJOOL.Length; l++)
		{
			dictionary2.Add(CQGKGFQLBDB.FNLEPBFJOOL[l], l);
		}
		for (;;)
		{
			MHIDKMCBQEN<string> mhidkmcbqen2 = mnblbmjjhkq.DLODCMNNJJC();
			if (mhidkmcbqen2 == null || mhidkmcbqen2.BJGMIBBEGDQ == 0)
			{
				break;
			}
			if (!string.IsNullOrEmpty(mhidkmcbqen2.get_KNPPMKBOGDL(0)))
			{
				CQGKGFQLBDB.DJPDPNFEOOH(mhidkmcbqen2, array, dictionary2);
			}
		}
		if (!CQGKGFQLBDB.LMKLMQKPKIO && CQGKGFQLBDB.FIILINELJHN != null)
		{
			CQGKGFQLBDB.LMKLMQKPKIO = true;
			CQGKGFQLBDB.CGMIHBKFQKH fiilineljhn = CQGKGFQLBDB.FIILINELJHN;
			CQGKGFQLBDB.FIILINELJHN = null;
			fiilineljhn();
			CQGKGFQLBDB.FIILINELJHN = fiilineljhn;
			CQGKGFQLBDB.LMKLMQKPKIO = false;
		}
		return true;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00096A74 File Offset: 0x00094C74
	private static void DJPDPNFEOOH(MHIDKMCBQEN<string> KDDQEKEICDF, string[] CHFCDJPBLHF, Dictionary<string, int> BDFIFPKQIEL)
	{
		if (KDDQEKEICDF.BJGMIBBEGDQ < 2)
		{
			return;
		}
		string text = KDDQEKEICDF.get_KNPPMKBOGDL(0);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string[] value = CQGKGFQLBDB.EOQLLGOHPKF(KDDQEKEICDF, CHFCDJPBLHF, BDFIFPKQIEL);
		if (CQGKGFQLBDB.GNMGBJNHBQB.ContainsKey(text))
		{
			CQGKGFQLBDB.GNMGBJNHBQB[text] = value;
			if (CHFCDJPBLHF == null)
			{
				Debug.LogWarning("Localization key '" + text + "' is already present");
			}
		}
		else
		{
			try
			{
				CQGKGFQLBDB.GNMGBJNHBQB.Add(text, value);
			}
			catch (Exception ex)
			{
				Debug.LogError("Unable to add '" + text + "' to the Localization dictionary.\n" + ex.Message);
			}
		}
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00096B14 File Offset: 0x00094D14
	private static string[] EOQLLGOHPKF(MHIDKMCBQEN<string> MQHFIMMNOJK, string[] CHFCDJPBLHF, Dictionary<string, int> BDFIFPKQIEL)
	{
		if (CHFCDJPBLHF == null)
		{
			string[] array = new string[CQGKGFQLBDB.FNLEPBFJOOL.Length];
			int i = 1;
			int num = Mathf.Min(MQHFIMMNOJK.BJGMIBBEGDQ, array.Length + 1);
			while (i < num)
			{
				array[i - 1] = MQHFIMMNOJK.get_KNPPMKBOGDL(i);
				i++;
			}
			return array;
		}
		string key = MQHFIMMNOJK.get_KNPPMKBOGDL(0);
		string[] array2;
		if (!CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(key, out array2))
		{
			array2 = new string[CQGKGFQLBDB.FNLEPBFJOOL.Length];
		}
		int j = 0;
		int num2 = CHFCDJPBLHF.Length;
		while (j < num2)
		{
			string key2 = CHFCDJPBLHF[j];
			int num3 = BDFIFPKQIEL[key2];
			array2[num3] = MQHFIMMNOJK.get_KNPPMKBOGDL(j + 1);
			j++;
		}
		return array2;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00096BB8 File Offset: 0x00094DB8
	private static bool JQGBQCLBLCL(string PIBGCBIKMBQ)
	{
		CQGKGFQLBDB.PJCFHPCMEPQ = -1;
		if (CQGKGFQLBDB.GNMGBJNHBQB.Count == 0)
		{
			return false;
		}
		int i = 0;
		int num = CQGKGFQLBDB.FNLEPBFJOOL.Length;
		while (i < num)
		{
			if (CQGKGFQLBDB.FNLEPBFJOOL[i] == PIBGCBIKMBQ)
			{
				CQGKGFQLBDB.QBLHDLEBGCF.Clear();
				CQGKGFQLBDB.PJCFHPCMEPQ = i;
				CQGKGFQLBDB.EFDGFKNNJFQ = PIBGCBIKMBQ;
				PlayerPrefs.SetString("Language", CQGKGFQLBDB.EFDGFKNNJFQ);
				if (CQGKGFQLBDB.FIILINELJHN != null)
				{
					CQGKGFQLBDB.FIILINELJHN();
				}
				GKDCBJPLQLQ.OELIBIIBOBC("OnLocalize");
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00096C40 File Offset: 0x00094E40
	public static void PJMIKDIEGMB(string NBQPQQQJQKJ, Dictionary<string, string> HIFFBEJOJBL)
	{
		CQGKGFQLBDB.EFDGFKNNJFQ = NBQPQQQJQKJ;
		PlayerPrefs.SetString("Language", CQGKGFQLBDB.EFDGFKNNJFQ);
		CQGKGFQLBDB.QBLHDLEBGCF = HIFFBEJOJBL;
		CQGKGFQLBDB.NLIOLJLFNHF = true;
		CQGKGFQLBDB.PJCFHPCMEPQ = -1;
		CQGKGFQLBDB.FNLEPBFJOOL = new string[]
		{
			NBQPQQQJQKJ
		};
		if (CQGKGFQLBDB.FIILINELJHN != null)
		{
			CQGKGFQLBDB.FIILINELJHN();
		}
		GKDCBJPLQLQ.OELIBIIBOBC("OnLocalize");
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x0000B003 File Offset: 0x00009203
	public static void PJMIKDIEGMB(string LOHECPFGPGO, string BGBMIEJJQKC)
	{
		if (CQGKGFQLBDB.QBLHDLEBGCF.ContainsKey(LOHECPFGPGO))
		{
			CQGKGFQLBDB.QBLHDLEBGCF[LOHECPFGPGO] = BGBMIEJJQKC;
		}
		else
		{
			CQGKGFQLBDB.QBLHDLEBGCF.Add(LOHECPFGPGO, BGBMIEJJQKC);
		}
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00096CA0 File Offset: 0x00094EA0
	public static string INJNQNMOKKD(string LOHECPFGPGO)
	{
		if (string.IsNullOrEmpty(LOHECPFGPGO))
		{
			return null;
		}
		if (!CQGKGFQLBDB.NLIOLJLFNHF)
		{
			CQGKGFQLBDB.GGJKPBGBONJ(PlayerPrefs.GetString("Language", "English"));
		}
		if (CQGKGFQLBDB.FNLEPBFJOOL == null)
		{
			Debug.LogError("No localization data present");
			return null;
		}
		string pibgcbikmbq = CQGKGFQLBDB.PIBGCBIKMBQ;
		if (CQGKGFQLBDB.PJCFHPCMEPQ == -1)
		{
			for (int i = 0; i < CQGKGFQLBDB.FNLEPBFJOOL.Length; i++)
			{
				if (CQGKGFQLBDB.FNLEPBFJOOL[i] == pibgcbikmbq)
				{
					CQGKGFQLBDB.PJCFHPCMEPQ = i;
					break;
				}
			}
		}
		if (CQGKGFQLBDB.PJCFHPCMEPQ == -1)
		{
			CQGKGFQLBDB.PJCFHPCMEPQ = 0;
			CQGKGFQLBDB.EFDGFKNNJFQ = CQGKGFQLBDB.FNLEPBFJOOL[0];
			Debug.LogWarning("Language not found: " + pibgcbikmbq);
		}
		EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
		string result;
		string[] array;
		if (gmdqcmcjeqi == EMENMKHBPQE.EGIKELMMQOO.Touch)
		{
			string key = LOHECPFGPGO + " Mobile";
			if (CQGKGFQLBDB.JMJCOBLDNNJ.TryGetValue(key, out result))
			{
				return result;
			}
			if (CQGKGFQLBDB.PJCFHPCMEPQ != -1 && CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(key, out array) && CQGKGFQLBDB.PJCFHPCMEPQ < array.Length)
			{
				return array[CQGKGFQLBDB.PJCFHPCMEPQ];
			}
			if (CQGKGFQLBDB.QBLHDLEBGCF.TryGetValue(key, out result))
			{
				return result;
			}
		}
		else if (gmdqcmcjeqi == EMENMKHBPQE.EGIKELMMQOO.Controller)
		{
			string key2 = LOHECPFGPGO + " Controller";
			if (CQGKGFQLBDB.JMJCOBLDNNJ.TryGetValue(key2, out result))
			{
				return result;
			}
			if (CQGKGFQLBDB.PJCFHPCMEPQ != -1 && CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(key2, out array) && CQGKGFQLBDB.PJCFHPCMEPQ < array.Length)
			{
				return array[CQGKGFQLBDB.PJCFHPCMEPQ];
			}
			if (CQGKGFQLBDB.QBLHDLEBGCF.TryGetValue(key2, out result))
			{
				return result;
			}
		}
		if (CQGKGFQLBDB.JMJCOBLDNNJ.TryGetValue(LOHECPFGPGO, out result))
		{
			return result;
		}
		if (CQGKGFQLBDB.PJCFHPCMEPQ != -1 && CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(LOHECPFGPGO, out array))
		{
			if (CQGKGFQLBDB.PJCFHPCMEPQ < array.Length)
			{
				string text = array[CQGKGFQLBDB.PJCFHPCMEPQ];
				if (string.IsNullOrEmpty(text))
				{
					text = array[0];
				}
				return text;
			}
			return array[0];
		}
		else
		{
			if (CQGKGFQLBDB.QBLHDLEBGCF.TryGetValue(LOHECPFGPGO, out result))
			{
				return result;
			}
			return LOHECPFGPGO;
		}
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x0000B02C File Offset: 0x0000922C
	public static string JHQLPQQCKKI(string LOHECPFGPGO, params object[] GFLEDMKGGQH)
	{
		return string.Format(CQGKGFQLBDB.INJNQNMOKKD(LOHECPFGPGO), GFLEDMKGGQH);
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0000B03A File Offset: 0x0000923A
	[Obsolete("Localization is now always active. You no longer need to check this property.")]
	public static bool CPOJBKCQPHK
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0000B03D File Offset: 0x0000923D
	[Obsolete("Use Localization.Get instead")]
	public static string IOLNIPGDEEN(string LOHECPFGPGO)
	{
		return CQGKGFQLBDB.INJNQNMOKKD(LOHECPFGPGO);
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x0000B045 File Offset: 0x00009245
	public static bool OMQCJPOBICE(string LOHECPFGPGO)
	{
		if (!CQGKGFQLBDB.NLIOLJLFNHF)
		{
			CQGKGFQLBDB.PIBGCBIKMBQ = PlayerPrefs.GetString("Language", "English");
		}
		return CQGKGFQLBDB.GNMGBJNHBQB.ContainsKey(LOHECPFGPGO) || CQGKGFQLBDB.QBLHDLEBGCF.ContainsKey(LOHECPFGPGO);
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00096E70 File Offset: 0x00095070
	public static void PJMIKDIEGMB(string PIBGCBIKMBQ, string LOHECPFGPGO, string PIDLOFMIEFQ)
	{
		string[] array = CQGKGFQLBDB.HOCNQMMBILD;
		if (array == null)
		{
			CQGKGFQLBDB.FNLEPBFJOOL = new string[]
			{
				PIBGCBIKMBQ
			};
			array = CQGKGFQLBDB.FNLEPBFJOOL;
		}
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			if (array[i] == PIBGCBIKMBQ)
			{
				string[] array2;
				if (!CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(LOHECPFGPGO, out array2))
				{
					array2 = new string[array.Length];
					CQGKGFQLBDB.GNMGBJNHBQB[LOHECPFGPGO] = array2;
					array2[0] = PIDLOFMIEFQ;
				}
				array2[i] = PIDLOFMIEFQ;
				return;
			}
			i++;
		}
		int num2 = CQGKGFQLBDB.FNLEPBFJOOL.Length + 1;
		Array.Resize<string>(ref CQGKGFQLBDB.FNLEPBFJOOL, num2);
		CQGKGFQLBDB.FNLEPBFJOOL[num2 - 1] = PIBGCBIKMBQ;
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		foreach (KeyValuePair<string, string[]> keyValuePair in CQGKGFQLBDB.GNMGBJNHBQB)
		{
			string[] value = keyValuePair.Value;
			Array.Resize<string>(ref value, num2);
			value[num2 - 1] = value[0];
			dictionary.Add(keyValuePair.Key, value);
		}
		CQGKGFQLBDB.GNMGBJNHBQB = dictionary;
		string[] array3;
		if (!CQGKGFQLBDB.GNMGBJNHBQB.TryGetValue(LOHECPFGPGO, out array3))
		{
			array3 = new string[array.Length];
			CQGKGFQLBDB.GNMGBJNHBQB[LOHECPFGPGO] = array3;
			array3[0] = PIDLOFMIEFQ;
		}
		array3[num2 - 1] = PIDLOFMIEFQ;
	}

	// Token: 0x040003C6 RID: 966
	public static CQGKGFQLBDB.BGNNINKLCMO JLJONQCLQEG;

	// Token: 0x040003C7 RID: 967
	public static CQGKGFQLBDB.CGMIHBKFQKH FIILINELJHN;

	// Token: 0x040003C8 RID: 968
	public static bool NLIOLJLFNHF = false;

	// Token: 0x040003C9 RID: 969
	private static string[] FNLEPBFJOOL = null;

	// Token: 0x040003CA RID: 970
	private static Dictionary<string, string> QBLHDLEBGCF = new Dictionary<string, string>();

	// Token: 0x040003CB RID: 971
	private static Dictionary<string, string[]> GNMGBJNHBQB = new Dictionary<string, string[]>();

	// Token: 0x040003CC RID: 972
	private static Dictionary<string, string> JMJCOBLDNNJ = new Dictionary<string, string>();

	// Token: 0x040003CD RID: 973
	private static int PJCFHPCMEPQ = -1;

	// Token: 0x040003CE RID: 974
	private static string EFDGFKNNJFQ;

	// Token: 0x040003CF RID: 975
	private static bool LMKLMQKPKIO = false;

	// Token: 0x0200009F RID: 159
	// (Invoke) Token: 0x060014FD RID: 5373
	public delegate byte[] BGNNINKLCMO(string FJJHKICMPBP);

	// Token: 0x020000A0 RID: 160
	// (Invoke) Token: 0x06001501 RID: 5377
	public delegate void CGMIHBKFQKH();
}
