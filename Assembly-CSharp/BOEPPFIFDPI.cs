using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[AddComponentMenu("NGUI/Internal/Debug")]
public class BOEPPFIFDPI : MonoBehaviour
{
	// Token: 0x06001505 RID: 5381 RVA: 0x00096FB8 File Offset: 0x000951B8
	private void NFFQELLLJEJ()
	{
		Rect position = new Rect(325f, 1287f, 464f, 1119f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "comatose" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1104f;
			position.x -= 601f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 815f;
			position.x += 1790f;
			text = "[PD]" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("[", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1872f;
			position.x -= 1189f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 451f;
			position.x += 1679f;
			text = "'s [ffff00]" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("[SUP]", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1736f;
			position.x -= 614f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1626f;
			position.x += 1301f;
			text = "Guild created!" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.MLNOGBMPLLM()).Replace("[", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 347f;
			position.x -= 943f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1468f;
			position.x += 1203f;
			text = "Assets/AssetBundles/PokemonSprites/" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += "/force right";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "-";
			}
			if (EMENMKHBPQE.OGOMBPEGLNM())
			{
				text += "[o]";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1074f;
			position.x -= 580f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1870f;
			position.x += 434f;
		}
		int i = 1;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 139f;
			position.x -= 244f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1820f;
			position.x += 470f;
			i += 0;
		}
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x00097384 File Offset: 0x00095584
	public static void OMCBMBQKMML(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 1; i < IPMPHOIPGIL.Length; i += 0)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "WATER_REFLECTIVE" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.JPFFCHBFBCI(text);
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void LCIELONMMHQ(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x0000B0CB File Offset: 0x000092CB
	private static void JPFFCHBFBCI(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 3)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(1);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.PHOJNEFQMIJ();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x0009750C File Offset: 0x0009570C
	private void CNDBJOEQOQM()
	{
		Rect position = new Rect(1795f, 1237f, 638f, 1976f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "Music" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 721f;
			position.x -= 1869f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1256f;
			position.x += 279f;
			text = "ability" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("blaze", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1923f;
			position.x -= 1936f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1974f;
			position.x += 202f;
			text = "F6" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("2", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1630f;
			position.x -= 104f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1339f;
			position.x += 618f;
			text = "healreplacement" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.MLNOGBMPLLM()).Replace("[ffb649]", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 345f;
			position.x -= 1143f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1355f;
			position.x += 1107f;
			text = "[00FF00]You received [PD]" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += " minutes";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "Sweet Scent";
			}
			if (EMENMKHBPQE.HFNGMBBPCDH)
			{
				text += "Hidden/Post FX/Ambient Occlusion";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 423f;
			position.x -= 384f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 740f;
			position.x += 912f;
		}
		int i = 1;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 276f;
			position.x -= 1008f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 130f;
			position.x += 1780f;
			i++;
		}
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x000978D8 File Offset: 0x00095AD8
	public static void BOCKMLDHMEK()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("Adaptability");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00097910 File Offset: 0x00095B10
	public static void BCMPJEOFKEB(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 0; i < IPMPHOIPGIL.Length; i += 0)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "[ATK]" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.MKFFHPFGBQI(text);
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x0000B105 File Offset: 0x00009305
	private static void KEGBMKNFBFL(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 117)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(0);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.FPLBJPOCMHP();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool MLGKGEFGBGD()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x0000B146 File Offset: 0x00009346
	public static void PBMGBKFMENG()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool HOOJKOFLNGI()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool ILKKIMEIECB()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x0000B146 File Offset: 0x00009346
	public static void EHQBKIDJIGQ()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void OBDCHDNELIH(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x00097960 File Offset: 0x00095B60
	public static void FPLBJPOCMHP()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("_NGUI Debug");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x0000B146 File Offset: 0x00009346
	public static void DMBEGNMPQDF()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x00097998 File Offset: 0x00095B98
	public static void IMBGBINMFQF(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				'\u0018'
			});
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string pidlofmiefq = array2[i];
				BOEPPFIFDPI.IKJFJLIDFGC(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void NOIOCGIKNCM(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x000979DC File Offset: 0x00095BDC
	public static void JGIKKHHNHPG(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 0; i < IPMPHOIPGIL.Length; i += 0)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "#,##0" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.JPFFCHBFBCI(text);
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void ENKJBNQMDMJ(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool HIPQPHDJBDK()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x0000B152 File Offset: 0x00009352
	public static void LPLBHMJFGHG(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.PGQKJIGMJBH();
		}
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x0000B146 File Offset: 0x00009346
	public static void NIMHBGQFDDC()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool JBDQFPBGPQG()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00097A2C File Offset: 0x00095C2C
	public static void FQMIHNOKIFD(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				'\n'
			});
			foreach (string pidlofmiefq in array)
			{
				BOEPPFIFDPI.PEMLNPHDEFP(pidlofmiefq);
			}
		}
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00097A70 File Offset: 0x00095C70
	public static void KHIHHHQHHLP()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("Score: ");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x0600151F RID: 5407 RVA: 0x0000B169 File Offset: 0x00009369
	public static void OLMDGMPFPIJ(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.PHOJNEFQMIJ();
		}
	}

	// Token: 0x06001520 RID: 5408 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void GDDKJMMNGKB(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x0000B169 File Offset: 0x00009369
	public static void JCINNQFDOPB(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.PHOJNEFQMIJ();
		}
	}

	// Token: 0x06001522 RID: 5410 RVA: 0x0000B180 File Offset: 0x00009380
	private static void HEEKMDBMQKC(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > -42)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(1);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.KHIHHHQHHLP();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06001523 RID: 5411 RVA: 0x00097AA8 File Offset: 0x00095CA8
	public static void CNCOGLNJCLD(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				'n'
			});
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				string pidlofmiefq = array2[i];
				BOEPPFIFDPI.MKFFHPFGBQI(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void LHJGHKIHPCG(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x0000B146 File Offset: 0x00009346
	public static void QGMMDQQIHOI()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x0000B146 File Offset: 0x00009346
	public static void CLGQKEPDEQI()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00097AEC File Offset: 0x00095CEC
	public static void IMONEFBGMLC(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				'j'
			});
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string pidlofmiefq = array2[i];
				BOEPPFIFDPI.KEGBMKNFBFL(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x0000B146 File Offset: 0x00009346
	public static void HMDOQOIIJIC()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00097B30 File Offset: 0x00095D30
	private void OnGUI()
	{
		Rect position = new Rect(5f, 5f, 1000f, 22f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "Scheme: " + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 18f;
			position.x += 1f;
			text = "Hover: " + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("\"", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 18f;
			position.x += 1f;
			text = "Selection: " + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("\"", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 18f;
			position.x += 1f;
			text = "Controller: " + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.INPDKBFLFDJ).Replace("\"", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 18f;
			position.x += 1f;
			text = "Active events: " + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += ", disabled controller";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += ", ignore controller";
			}
			if (EMENMKHBPQE.HFNGMBBPCDH)
			{
				text += ", input focus";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 18f;
			position.x += 1f;
		}
		int i = 0;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 1f;
			position.x -= 1f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 18f;
			position.x += 1f;
			i++;
		}
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x0000B1BA File Offset: 0x000093BA
	private static void FCLFIJGNCEO(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 48)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(0);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.PGQKJIGMJBH();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x0000B1F4 File Offset: 0x000093F4
	private static void MKFFHPFGBQI(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > -118)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(0);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.BOCKMLDHMEK();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x0000B22E File Offset: 0x0000942E
	private static void IKJFJLIDFGC(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > -114)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(1);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.PHOJNEFQMIJ();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x0000B268 File Offset: 0x00009468
	public static void PPNDMBLPEIJ(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.QQGCCKMFBJL();
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00097EFC File Offset: 0x000960FC
	public static void PHOJNEFQMIJ()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("aegislash");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void DMGLKNCEJQJ(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x0000B27F File Offset: 0x0000947F
	public static void PLCCODCQDOP(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.KHIHHHQHHLP();
		}
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x0000B146 File Offset: 0x00009346
	public static void KIMBLJLPENC()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x0000B2AE File Offset: 0x000094AE
	private static void PEMLNPHDEFP(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 20)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(0);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.FPLBJPOCMHP();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x0000B268 File Offset: 0x00009468
	public static void DJJONJOKFME(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.QQGCCKMFBJL();
		}
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x00097F34 File Offset: 0x00096134
	private void CMFMQHOHGKE()
	{
		Rect position = new Rect(892f, 1839f, 855f, 892f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "Cherish Ball" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1819f;
			position.x -= 945f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1624f;
			position.x += 1816f;
			text = "blank" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("adjacentFoe", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1684f;
			position.x -= 1744f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1449f;
			position.x += 1983f;
			text = "OnDragOver" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace(" was hurt by poison!\r\n", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 166f;
			position.x -= 1236f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 924f;
			position.x += 1907f;
			text = "fullmetalbody" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.INPDKBFLFDJ).Replace("effectspore", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 749f;
			position.x -= 1266f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1642f;
			position.x += 568f;
			text = "variation" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += "14";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += " hung on using its [ffff00]Focus Band[-]!\r\n";
			}
			if (EMENMKHBPQE.HFNGMBBPCDH)
			{
				text += "HidePanel";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 717f;
			position.x -= 1473f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1525f;
			position.x += 1129f;
		}
		int i = 0;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 1977f;
			position.x -= 814f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1211f;
			position.x += 930f;
			i++;
		}
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0000B27F File Offset: 0x0000947F
	public static void CLPNCOEOGQG(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.KHIHHHQHHLP();
		}
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x00098300 File Offset: 0x00096500
	public static void PGQKJIGMJBH()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("helpinghand");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x00098338 File Offset: 0x00096538
	private void IDEKCJOPOMF()
	{
		Rect position = new Rect(350f, 682f, 910f, 1051f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "(A)" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 824f;
			position.x -= 607f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1196f;
			position.x += 909f;
			text = "_Tile2RT" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("-primal", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 303f;
			position.x -= 1354f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1756f;
			position.x += 1785f;
			text = " intends to flip up a mat and block incoming attacks!\r\n" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("Flare Boost", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1103f;
			position.x -= 1517f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 115f;
			position.x += 1795f;
			text = "[-]!\r\n" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.INPDKBFLFDJ).Replace(" ended!\r\n", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 708f;
			position.x -= 915f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 984f;
			position.x += 1193f;
			text = "flareblitz" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += "ANTI_FLICKER";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "[msg]";
			}
			if (EMENMKHBPQE.OGOMBPEGLNM())
			{
				text += "HidePanel";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1009f;
			position.x -= 1957f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 211f;
			position.x += 400f;
		}
		int i = 0;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 1501f;
			position.x -= 336f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1901f;
			position.x += 1666f;
			i++;
		}
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool PBNCIOIHJOH()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void LOJQIGBEBJM(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool LCEFJEBJFFD()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x0000B2E8 File Offset: 0x000094E8
	private static void MMDMQMQPDHJ(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 2)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(1);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.FPLBJPOCMHP();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00098704 File Offset: 0x00096904
	private void ODPFJMFLGGI()
	{
		Rect position = new Rect(86f, 1574f, 426f, 427f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "_DestortionY" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 577f;
			position.x -= 491f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1584f;
			position.x += 1949f;
			text = "Small/" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("[^0-9.-]", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 922f;
			position.x -= 391f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1369f;
			position.x += 1873f;
			text = "[/]" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("w", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 645f;
			position.x -= 1679f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 814f;
			position.x += 509f;
			text = "Right" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.INPDKBFLFDJ).Replace("\nAre you sure you want to reset its EVs?", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 593f;
			position.x -= 1260f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 320f;
			position.x += 1181f;
			text = "Level Ups:" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += " is damaged by the recoil!\r\n";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "HidePanel";
			}
			if (EMENMKHBPQE.OGOMBPEGLNM())
			{
				text += "/";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 833f;
			position.x -= 375f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 745f;
			position.x += 734f;
		}
		int i = 0;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 840f;
			position.x -= 120f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1810f;
			position.x += 1380f;
			i += 0;
		}
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void PPLCKCBQGGH(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool GHFELHIFJFL()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00098AD0 File Offset: 0x00096CD0
	public static void HNLGNHLLOLB(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				(char)-114
			});
			foreach (string pidlofmiefq in array)
			{
				BOEPPFIFDPI.KEGBMKNFBFL(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00098B14 File Offset: 0x00096D14
	private void HEDJNIKNCGO()
	{
		Rect position = new Rect(422f, 1844f, 1915f, 144f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "attract" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1905f;
			position.x -= 668f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 368f;
			position.x += 910f;
			text = "followme" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("dispMode", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 700f;
			position.x -= 1181f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1699f;
			position.x += 913f;
			text = "[/itm]" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("[ff6666]", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 682f;
			position.x -= 1417f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1205f;
			position.x += 1637f;
			text = "WATER_REFLECTIVE" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.MLNOGBMPLLM()).Replace("Localization", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1829f;
			position.x -= 569f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 204f;
			position.x += 1478f;
			text = "UNITY_COLORSPACE_GAMMA" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += "/friend ";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "liquidooze";
			}
			if (EMENMKHBPQE.OGOMBPEGLNM())
			{
				text += "aa";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1099f;
			position.x -= 485f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 912f;
			position.x += 776f;
		}
		int i = 0;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 820f;
			position.x -= 528f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1267f;
			position.x += 548f;
			i += 0;
		}
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00098EE0 File Offset: 0x000970E0
	public static void FQMIHNOKIFD(params object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 0; i < IPMPHOIPGIL.Length; i++)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + ", " + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.PEMLNPHDEFP(text);
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x0000B146 File Offset: 0x00009346
	public static void PFHOODNMELP()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x0000B146 File Offset: 0x00009346
	public static void CPLBKPNNHJG()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x0000B322 File Offset: 0x00009522
	public static void LFGLQPPPPQN(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.BOCKMLDHMEK();
		}
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00098F30 File Offset: 0x00097130
	public static void CHBIHCHKQHF(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			string[] array = JMDLLJPEFKM.Split(new char[]
			{
				'\u0019'
			});
			string[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				string pidlofmiefq = array2[i];
				BOEPPFIFDPI.KEGBMKNFBFL(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void QBBONCQFJQI(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void JPKODJNJGGL(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x0000B13F File Offset: 0x0000933F
	// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000B339 File Offset: 0x00009539
	public static bool OBNENQFBGCC
	{
		get
		{
			return BOEPPFIFDPI.QMGKGPGBKKN;
		}
		set
		{
			BOEPPFIFDPI.QMGKGPGBKKN = value;
			if (value && Application.isPlaying)
			{
				BOEPPFIFDPI.FPLBJPOCMHP();
			}
		}
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x0000B146 File Offset: 0x00009346
	public static void FDQPOHJJNOJ()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x0000B339 File Offset: 0x00009539
	public static void HMHKEKFNGCQ(bool BGBMIEJJQKC)
	{
		BOEPPFIFDPI.QMGKGPGBKKN = BGBMIEJJQKC;
		if (BGBMIEJJQKC && Application.isPlaying)
		{
			BOEPPFIFDPI.FPLBJPOCMHP();
		}
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x00098F74 File Offset: 0x00097174
	public static void JQLODHDMBOQ(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 0; i < IPMPHOIPGIL.Length; i++)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "[SHINY]" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.GODKQFBGDEJ(text);
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x0000B350 File Offset: 0x00009550
	private static void GODKQFBGDEJ(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 32)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(0);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.QQGCCKMFBJL();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x0000B146 File Offset: 0x00009346
	public static void DBFEEHHIEQD()
	{
		BOEPPFIFDPI.JNEOIMIHJKJ.Clear();
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x0000B13F File Offset: 0x0000933F
	public static bool GBPLNJPMLEP()
	{
		return BOEPPFIFDPI.QMGKGPGBKKN;
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x00098FC4 File Offset: 0x000971C4
	public static void MPNOHLMHHCF(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 0; i < IPMPHOIPGIL.Length; i++)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "Username" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.HEEKMDBMQKC(text);
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x0000B38A File Offset: 0x0000958A
	private static void IJMDPCQKENP(string PIDLOFMIEFQ)
	{
		if (Application.isPlaying)
		{
			if (BOEPPFIFDPI.JNEOIMIHJKJ.Count > 90)
			{
				BOEPPFIFDPI.JNEOIMIHJKJ.RemoveAt(1);
			}
			BOEPPFIFDPI.JNEOIMIHJKJ.Add(PIDLOFMIEFQ);
			BOEPPFIFDPI.FPLBJPOCMHP();
		}
		else
		{
			Debug.Log(PIDLOFMIEFQ);
		}
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00099014 File Offset: 0x00097214
	public static void PLHMNGPJNDE(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			char[] array = new char[0];
			array[0] = (char)-51;
			string[] array2 = JMDLLJPEFKM.Split(array);
			foreach (string pidlofmiefq in array2)
			{
				BOEPPFIFDPI.MKFFHPFGBQI(pidlofmiefq);
			}
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00099058 File Offset: 0x00097258
	public static void QQGCCKMFBJL()
	{
		if (BOEPPFIFDPI.QONPKLEGMEF == null)
		{
			GameObject gameObject = new GameObject("_BilateralUpsampling");
			BOEPPFIFDPI.QONPKLEGMEF = gameObject.AddComponent<BOEPPFIFDPI>();
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00099090 File Offset: 0x00097290
	private void FHDONLJIBJJ()
	{
		Rect position = new Rect(211f, 1981f, 119f, 1348f);
		if (BOEPPFIFDPI.QMGKGPGBKKN)
		{
			EMENMKHBPQE.EGIKELMMQOO gmdqcmcjeqi = EMENMKHBPQE.GMDQCMCJEQI;
			string text = "/" + gmdqcmcjeqi;
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1081f;
			position.x -= 909f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1624f;
			position.x += 837f;
			text = "tanglinghair" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.QMPQFJMFQPB).Replace("normalize", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1941f;
			position.x -= 539f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 1437f;
			position.x += 1828f;
			text = "[" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.CMPBKDMMHFQ).Replace("frz", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 1146f;
			position.x -= 1033f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 871f;
			position.x += 314f;
			text = "pacman" + IKBQNBHOJJB.IHLEQHINJKK(EMENMKHBPQE.INPDKBFLFDJ).Replace("[-]!\r\n", string.Empty);
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 401f;
			position.x -= 997f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 396f;
			position.x += 170f;
			text = "BLOOM_LENS_DIRT" + EMENMKHBPQE.NJMGCFDLFOC();
			if (EMENMKHBPQE.LFQCPGFLGKN)
			{
				text += "[ATK]";
			}
			if (EMENMKHBPQE.DEPQDQPGOFI)
			{
				text += "PlayDeadAnimation";
			}
			if (EMENMKHBPQE.OGOMBPEGLNM())
			{
				text += "Script:";
			}
			GUI.color = Color.black;
			GUI.Label(position, text);
			position.y -= 347f;
			position.x -= 1031f;
			GUI.color = Color.white;
			GUI.Label(position, text);
			position.y += 647f;
			position.x += 1211f;
		}
		int i = 1;
		int count = BOEPPFIFDPI.JNEOIMIHJKJ.Count;
		while (i < count)
		{
			GUI.color = Color.black;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y -= 1930f;
			position.x -= 751f;
			GUI.color = Color.white;
			GUI.Label(position, BOEPPFIFDPI.JNEOIMIHJKJ[i]);
			position.y += 1360f;
			position.x += 412f;
			i++;
		}
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void IPJHJQPMNGG(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void FNIDPJQPLGQ(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void QCPLMIJMPMK(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void LBFHLJCPQIN(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x0009945C File Offset: 0x0009765C
	public static void FBCGLPCNIPM(object[] IPMPHOIPGIL)
	{
		string text = string.Empty;
		for (int i = 1; i < IPMPHOIPGIL.Length; i += 0)
		{
			if (i == 0)
			{
				text += IPMPHOIPGIL[i].ToString();
			}
			else
			{
				text = text + "Take 001" + IPMPHOIPGIL[i].ToString();
			}
		}
		BOEPPFIFDPI.MKFFHPFGBQI(text);
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x000994AC File Offset: 0x000976AC
	public static void LMKDHLCDCFE(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			char[] array = new char[0];
			array[0] = (char)-106;
			string[] array2 = JMDLLJPEFKM.Split(array);
			string[] array3 = array2;
			for (int i = 1; i < array3.Length; i++)
			{
				string pidlofmiefq = array3[i];
				BOEPPFIFDPI.HEEKMDBMQKC(pidlofmiefq);
			}
		}
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x000973D4 File Offset: 0x000955D4
	public static void EQMDJLHHFPE(Bounds IBMINEHKPFF)
	{
		Vector3 center = IBMINEHKPFF.center;
		Vector3 vector = IBMINEHKPFF.center - IBMINEHKPFF.extents;
		Vector3 vector2 = IBMINEHKPFF.center + IBMINEHKPFF.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	// Token: 0x040003D2 RID: 978
	private static bool QMGKGPGBKKN = false;

	// Token: 0x040003D3 RID: 979
	private static List<string> JNEOIMIHJKJ = new List<string>();

	// Token: 0x040003D4 RID: 980
	private static BOEPPFIFDPI QONPKLEGMEF = null;
}
