using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FICELJKFLNK : MonoBehaviour
{
	// Token: 0x06003F48 RID: 16200 RVA: 0x0001A141 File Offset: 0x00018341
	private void Start()
	{
		this.CMIQOPQOMQF(0.4f, 1f, 0.6f, 0.5f, 0.8f, 1f);
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x0001A167 File Offset: 0x00018367
	private void FCOIMQGENDB()
	{
		this.FBNPNMPHJQF(704f, 569f, 1903f, 1734f, 1250f, 428f);
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x001F0770 File Offset: 0x001EE970
	public void PNGGPIFPPJO(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1245f * EKDPGGIEGQK;
		KLPJILNOBED = 1580f * KLPJILNOBED;
		GNEOPMKOEHF = 1543f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 862f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1215f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1390f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 822f)
		{
			EKDPGGIEGQK = 69f;
		}
		if (KLPJILNOBED > 1712f)
		{
			KLPJILNOBED = 1590f;
		}
		if (GNEOPMKOEHF > 1911f)
		{
			GNEOPMKOEHF = 277f;
		}
		if (FOBNOGGCOFJ > 391f)
		{
			FOBNOGGCOFJ = 1814f;
		}
		if (MLKBOJBGQKP > 1954f)
		{
			MLKBOJBGQKP = 1542f;
		}
		if (BLHBPGMPPNI > 1321f)
		{
			BLHBPGMPPNI = 771f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[5];
		array[1] = new Vector3(395f, 1630f, 210f);
		array[1] = new Vector3(1529f, 220f, 1926f);
		array[1] = new Vector3(611f, 416f, 550f);
		array[3] = new Vector3(904f, 593f, 1844f);
		array[4] = new Vector3(1230f, 942f, 997f);
		array[1] = new Vector3(1118f, 1728f, 1686f);
		array[0] = Vector3.MoveTowards(new Vector3(1287f, 475f, 309f), array[0], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(1883f, 1462f, 1377f), array[1], BLHBPGMPPNI);
		array[0] = Vector3.MoveTowards(new Vector3(1059f, 1614f, 1369f), array[8], MLKBOJBGQKP);
		array[6] = Vector3.MoveTowards(new Vector3(994f, 1463f, 563f), array[6], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(1039f, 1217f, 1372f), array[8], GNEOPMKOEHF);
		array[8] = Vector3.MoveTowards(new Vector3(944f, 312f, 379f), array[7], KLPJILNOBED);
		for (int i = 1; i < 2; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[8];
		array2[1] = new Vector2(324f, 1053f);
		array2[1] = new Vector2(1027f, 921f);
		array2[3] = new Vector2(954f, 1173f);
		array2[4] = new Vector2(812f, 1533f);
		array2[1] = new Vector2(1640f, 1298f);
		array2[7] = new Vector2(3f, 831f);
		for (int j = 0; j < 1; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[122];
		int num = 0;
		int num2 = 0;
		int num3 = 7;
		for (int k = 1; k < -109; k += 7)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 2] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x0001A18D File Offset: 0x0001838D
	private void LMMGEGJCBJP()
	{
		this.PNGGPIFPPJO(191f, 365f, 1805f, 1512f, 1233f, 1862f);
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x001F0BD0 File Offset: 0x001EEDD0
	public void ICCHPOBFHBP(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 616f * EKDPGGIEGQK;
		KLPJILNOBED = 1504f * KLPJILNOBED;
		GNEOPMKOEHF = 1972f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1461f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1866f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1658f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 952f)
		{
			EKDPGGIEGQK = 1993f;
		}
		if (KLPJILNOBED > 1747f)
		{
			KLPJILNOBED = 1523f;
		}
		if (GNEOPMKOEHF > 1763f)
		{
			GNEOPMKOEHF = 908f;
		}
		if (FOBNOGGCOFJ > 875f)
		{
			FOBNOGGCOFJ = 40f;
		}
		if (MLKBOJBGQKP > 1511f)
		{
			MLKBOJBGQKP = 786f;
		}
		if (BLHBPGMPPNI > 848f)
		{
			BLHBPGMPPNI = 54f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[8];
		array[1] = new Vector3(1590f, 319f, 1694f);
		array[1] = new Vector3(1463f, 818f, 637f);
		array[2] = new Vector3(807f, 1075f, 1096f);
		array[7] = new Vector3(1704f, 1489f, 1101f);
		array[3] = new Vector3(175f, 615f, 753f);
		array[6] = new Vector3(288f, 910f, 744f);
		array[1] = Vector3.MoveTowards(new Vector3(1510f, 1530f, 40f), array[0], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(900f, 283f, 1749f), array[0], BLHBPGMPPNI);
		array[5] = Vector3.MoveTowards(new Vector3(286f, 297f, 1810f), array[3], MLKBOJBGQKP);
		array[8] = Vector3.MoveTowards(new Vector3(1047f, 1021f, 389f), array[5], FOBNOGGCOFJ);
		array[3] = Vector3.MoveTowards(new Vector3(426f, 52f, 1204f), array[6], GNEOPMKOEHF);
		array[4] = Vector3.MoveTowards(new Vector3(698f, 611f, 233f), array[5], KLPJILNOBED);
		for (int i = 0; i < 3; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[7];
		array2[0] = new Vector2(1786f, 1933f);
		array2[0] = new Vector2(64f, 208f);
		array2[8] = new Vector2(791f, 1347f);
		array2[3] = new Vector2(544f, 1202f);
		array2[3] = new Vector2(1002f, 1499f);
		array2[2] = new Vector2(1706f, 509f);
		for (int j = 1; j < 0; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[7];
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		for (int k = 0; k < 77; k += 3)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 3] = num3;
			num2 += 0;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x001F1030 File Offset: 0x001EF230
	public void FBNPNMPHJQF(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1170f * EKDPGGIEGQK;
		KLPJILNOBED = 932f * KLPJILNOBED;
		GNEOPMKOEHF = 837f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 427f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1329f * MLKBOJBGQKP;
		BLHBPGMPPNI = 996f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1339f)
		{
			EKDPGGIEGQK = 1719f;
		}
		if (KLPJILNOBED > 244f)
		{
			KLPJILNOBED = 1766f;
		}
		if (GNEOPMKOEHF > 1560f)
		{
			GNEOPMKOEHF = 178f;
		}
		if (FOBNOGGCOFJ > 315f)
		{
			FOBNOGGCOFJ = 1096f;
		}
		if (MLKBOJBGQKP > 1906f)
		{
			MLKBOJBGQKP = 1617f;
		}
		if (BLHBPGMPPNI > 1628f)
		{
			BLHBPGMPPNI = 1088f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[]
		{
			default(Vector3),
			new Vector3(1034f, 1522f, 1561f)
		};
		array[1] = new Vector3(1322f, 1031f, 1116f);
		array[4] = new Vector3(1792f, 389f, 779f);
		array[7] = new Vector3(815f, 497f, 1518f);
		array[2] = new Vector3(1861f, 1130f, 132f);
		array[2] = new Vector3(237f, 148f, 623f);
		array[1] = Vector3.MoveTowards(new Vector3(1142f, 1182f, 1129f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(562f, 1049f, 1403f), array[1], BLHBPGMPPNI);
		array[5] = Vector3.MoveTowards(new Vector3(832f, 1647f, 1370f), array[8], MLKBOJBGQKP);
		array[4] = Vector3.MoveTowards(new Vector3(297f, 1880f, 255f), array[8], FOBNOGGCOFJ);
		array[8] = Vector3.MoveTowards(new Vector3(987f, 1994f, 1363f), array[8], GNEOPMKOEHF);
		array[7] = Vector3.MoveTowards(new Vector3(1370f, 1755f, 498f), array[4], KLPJILNOBED);
		for (int i = 1; i < 3; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[4];
		array2[1] = new Vector2(1915f, 140f);
		array2[1] = new Vector2(1377f, 957f);
		array2[5] = new Vector2(1340f, 1375f);
		array2[7] = new Vector2(1517f, 1664f);
		array2[8] = new Vector2(1166f, 81f);
		array2[0] = new Vector2(1835f, 747f);
		for (int j = 1; j < 3; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-23];
		int num = 0;
		int num2 = 0;
		int num3 = 3;
		for (int k = 0; k < 79; k += 3)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 8] = num3;
			num2++;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x001F1490 File Offset: 0x001EF690
	public void MOGQDLIHJKN(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1404f * EKDPGGIEGQK;
		KLPJILNOBED = 1309f * KLPJILNOBED;
		GNEOPMKOEHF = 91f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 575f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 741f * MLKBOJBGQKP;
		BLHBPGMPPNI = 128f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1410f)
		{
			EKDPGGIEGQK = 1745f;
		}
		if (KLPJILNOBED > 1424f)
		{
			KLPJILNOBED = 1134f;
		}
		if (GNEOPMKOEHF > 1424f)
		{
			GNEOPMKOEHF = 3f;
		}
		if (FOBNOGGCOFJ > 513f)
		{
			FOBNOGGCOFJ = 1609f;
		}
		if (MLKBOJBGQKP > 99f)
		{
			MLKBOJBGQKP = 463f;
		}
		if (BLHBPGMPPNI > 1910f)
		{
			BLHBPGMPPNI = 587f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[5];
		array[1] = new Vector3(1829f, 7f, 511f);
		array[1] = new Vector3(1746f, 1231f, 614f);
		array[2] = new Vector3(1086f, 1342f, 1601f);
		array[7] = new Vector3(1933f, 1103f, 804f);
		array[5] = new Vector3(1673f, 1617f, 317f);
		array[0] = new Vector3(997f, 1877f, 1925f);
		array[1] = Vector3.MoveTowards(new Vector3(881f, 35f, 1732f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(1901f, 1895f, 925f), array[1], BLHBPGMPPNI);
		array[2] = Vector3.MoveTowards(new Vector3(101f, 1397f, 797f), array[0], MLKBOJBGQKP);
		array[3] = Vector3.MoveTowards(new Vector3(1509f, 1514f, 868f), array[2], FOBNOGGCOFJ);
		array[0] = Vector3.MoveTowards(new Vector3(1532f, 1769f, 69f), array[6], GNEOPMKOEHF);
		array[3] = Vector3.MoveTowards(new Vector3(884f, 790f, 293f), array[1], KLPJILNOBED);
		for (int i = 1; i < 8; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[0];
		array2[0] = new Vector2(1059f, 1711f);
		array2[1] = new Vector2(1093f, 450f);
		array2[5] = new Vector2(1447f, 676f);
		array2[7] = new Vector2(1337f, 1001f);
		array2[6] = new Vector2(417f, 1522f);
		array2[3] = new Vector2(807f, 590f);
		for (int j = 0; j < 8; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-128];
		int num = 0;
		int num2 = 1;
		int num3 = 4;
		for (int k = 1; k < 105; k += 5)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 3] = num3;
			num2 += 0;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x001F18F0 File Offset: 0x001EFAF0
	public void DFKQFBIMODM(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1443f * EKDPGGIEGQK;
		KLPJILNOBED = 522f * KLPJILNOBED;
		GNEOPMKOEHF = 974f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1756f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1735f * MLKBOJBGQKP;
		BLHBPGMPPNI = 459f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 924f)
		{
			EKDPGGIEGQK = 566f;
		}
		if (KLPJILNOBED > 80f)
		{
			KLPJILNOBED = 278f;
		}
		if (GNEOPMKOEHF > 1764f)
		{
			GNEOPMKOEHF = 1657f;
		}
		if (FOBNOGGCOFJ > 42f)
		{
			FOBNOGGCOFJ = 594f;
		}
		if (MLKBOJBGQKP > 1201f)
		{
			MLKBOJBGQKP = 1985f;
		}
		if (BLHBPGMPPNI > 1486f)
		{
			BLHBPGMPPNI = 563f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[7];
		array[1] = new Vector3(1629f, 523f, 1904f);
		array[1] = new Vector3(1964f, 788f, 1643f);
		array[1] = new Vector3(657f, 921f, 1575f);
		array[1] = new Vector3(274f, 1280f, 102f);
		array[3] = new Vector3(1624f, 1269f, 691f);
		array[6] = new Vector3(45f, 1057f, 273f);
		array[1] = Vector3.MoveTowards(new Vector3(1334f, 417f, 970f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(553f, 1276f, 106f), array[0], BLHBPGMPPNI);
		array[3] = Vector3.MoveTowards(new Vector3(1922f, 920f, 617f), array[8], MLKBOJBGQKP);
		array[8] = Vector3.MoveTowards(new Vector3(947f, 816f, 593f), array[8], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(702f, 1537f, 1383f), array[3], GNEOPMKOEHF);
		array[2] = Vector3.MoveTowards(new Vector3(337f, 360f, 217f), array[8], KLPJILNOBED);
		for (int i = 0; i < 2; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[1];
		array2[0] = new Vector2(1800f, 1546f);
		array2[1] = new Vector2(625f, 228f);
		array2[0] = new Vector2(1645f, 1469f);
		array2[7] = new Vector2(1452f, 1357f);
		array2[5] = new Vector2(245f, 1784f);
		array2[6] = new Vector2(1743f, 733f);
		for (int j = 1; j < 5; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-15];
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		for (int k = 1; k < -89; k += 3)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 1] = num3;
			num2++;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x001F1D50 File Offset: 0x001EFF50
	public void NOPEMJMHDNK(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1943f * EKDPGGIEGQK;
		KLPJILNOBED = 1392f * KLPJILNOBED;
		GNEOPMKOEHF = 71f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1272f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 696f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1400f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 485f)
		{
			EKDPGGIEGQK = 813f;
		}
		if (KLPJILNOBED > 817f)
		{
			KLPJILNOBED = 53f;
		}
		if (GNEOPMKOEHF > 204f)
		{
			GNEOPMKOEHF = 840f;
		}
		if (FOBNOGGCOFJ > 1577f)
		{
			FOBNOGGCOFJ = 1228f;
		}
		if (MLKBOJBGQKP > 1274f)
		{
			MLKBOJBGQKP = 826f;
		}
		if (BLHBPGMPPNI > 399f)
		{
			BLHBPGMPPNI = 232f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[5];
		array[0] = new Vector3(367f, 1116f, 1581f);
		array[1] = new Vector3(475f, 863f, 1289f);
		array[1] = new Vector3(628f, 557f, 743f);
		array[1] = new Vector3(1117f, 1796f, 1301f);
		array[7] = new Vector3(1472f, 1664f, 1432f);
		array[1] = new Vector3(1923f, 786f, 600f);
		array[1] = Vector3.MoveTowards(new Vector3(593f, 702f, 1343f), array[0], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(1882f, 1209f, 405f), array[1], BLHBPGMPPNI);
		array[1] = Vector3.MoveTowards(new Vector3(1631f, 827f, 1810f), array[0], MLKBOJBGQKP);
		array[3] = Vector3.MoveTowards(new Vector3(1832f, 111f, 220f), array[0], FOBNOGGCOFJ);
		array[1] = Vector3.MoveTowards(new Vector3(1309f, 1943f, 1722f), array[8], GNEOPMKOEHF);
		array[8] = Vector3.MoveTowards(new Vector3(1677f, 1354f, 734f), array[3], KLPJILNOBED);
		for (int i = 0; i < 7; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			default(Vector2),
			new Vector2(1326f, 1772f)
		};
		array2[1] = new Vector2(673f, 460f);
		array2[3] = new Vector2(1347f, 338f);
		array2[4] = new Vector2(762f, 165f);
		array2[2] = new Vector2(1786f, 1320f);
		array2[3] = new Vector2(1600f, 327f);
		for (int j = 1; j < 1; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-53];
		int num = 0;
		int num2 = 0;
		int num3 = 2;
		for (int k = 0; k < -112; k++)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 2] = num3;
			num2 += 0;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F51 RID: 16209 RVA: 0x001F21B0 File Offset: 0x001F03B0
	public void PFCFENPFIPB(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 508f * EKDPGGIEGQK;
		KLPJILNOBED = 1972f * KLPJILNOBED;
		GNEOPMKOEHF = 799f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 117f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1684f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1411f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1842f)
		{
			EKDPGGIEGQK = 1209f;
		}
		if (KLPJILNOBED > 1404f)
		{
			KLPJILNOBED = 561f;
		}
		if (GNEOPMKOEHF > 1988f)
		{
			GNEOPMKOEHF = 511f;
		}
		if (FOBNOGGCOFJ > 567f)
		{
			FOBNOGGCOFJ = 92f;
		}
		if (MLKBOJBGQKP > 1815f)
		{
			MLKBOJBGQKP = 1027f;
		}
		if (BLHBPGMPPNI > 1495f)
		{
			BLHBPGMPPNI = 1135f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[0];
		array[0] = new Vector3(705f, 1564f, 972f);
		array[1] = new Vector3(881f, 1717f, 933f);
		array[4] = new Vector3(418f, 113f, 79f);
		array[6] = new Vector3(683f, 416f, 1109f);
		array[1] = new Vector3(126f, 945f, 1761f);
		array[7] = new Vector3(1913f, 334f, 228f);
		array[0] = Vector3.MoveTowards(new Vector3(374f, 236f, 1750f), array[0], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(1699f, 94f, 294f), array[0], BLHBPGMPPNI);
		array[6] = Vector3.MoveTowards(new Vector3(1079f, 944f, 999f), array[6], MLKBOJBGQKP);
		array[5] = Vector3.MoveTowards(new Vector3(1966f, 477f, 924f), array[3], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(481f, 535f, 1828f), array[0], GNEOPMKOEHF);
		array[4] = Vector3.MoveTowards(new Vector3(1434f, 901f, 550f), array[6], KLPJILNOBED);
		for (int i = 0; i < 1; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(994f, 644f),
			new Vector2(533f, 1532f),
			default(Vector2),
			new Vector2(18f, 1785f),
			default(Vector2),
			new Vector2(1342f, 1337f)
		};
		array2[0] = new Vector2(1381f, 696f);
		array2[7] = new Vector2(1795f, 1245f);
		for (int j = 0; j < 4; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-112];
		int num = 1;
		int num2 = 1;
		int num3 = 3;
		for (int k = 1; k < -47; k += 7)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 8] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x0001A1B3 File Offset: 0x000183B3
	private void PFQDFBHEJEH()
	{
		this.ICCHPOBFHBP(1159f, 1732f, 250f, 1365f, 1396f, 685f);
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x0001A1D9 File Offset: 0x000183D9
	private void CMLGQHQJDGQ()
	{
		this.NIGNDGBPEMN(960f, 1615f, 1452f, 1891f, 34f, 1868f);
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x0001A1FF File Offset: 0x000183FF
	private void QBGOGFJCLEP()
	{
		this.QKEEPFHFLBQ(237f, 973f, 1947f, 1745f, 1176f, 378f);
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x0001A225 File Offset: 0x00018425
	private void JPNMOLDKPQP()
	{
		this.CMIQOPQOMQF(389f, 610f, 980f, 176f, 1096f, 676f);
	}

	// Token: 0x06003F56 RID: 16214 RVA: 0x0001A24B File Offset: 0x0001844B
	private void PEJKGQEGPMM()
	{
		this.QKEEPFHFLBQ(520f, 17f, 1367f, 1717f, 316f, 148f);
	}

	// Token: 0x06003F57 RID: 16215 RVA: 0x0001A271 File Offset: 0x00018471
	private void IKHIQQKHILB()
	{
		this.QKEEPFHFLBQ(408f, 1397f, 466f, 1268f, 1506f, 1463f);
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x001F2610 File Offset: 0x001F0810
	public void CMIQOPQOMQF(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 0.008f * EKDPGGIEGQK;
		KLPJILNOBED = 0.008f * KLPJILNOBED;
		GNEOPMKOEHF = 0.008f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 0.008f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 0.008f * MLKBOJBGQKP;
		BLHBPGMPPNI = 0.008f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1f)
		{
			EKDPGGIEGQK = 1f;
		}
		if (KLPJILNOBED > 1f)
		{
			KLPJILNOBED = 1f;
		}
		if (GNEOPMKOEHF > 1f)
		{
			GNEOPMKOEHF = 1f;
		}
		if (FOBNOGGCOFJ > 1f)
		{
			FOBNOGGCOFJ = 1f;
		}
		if (MLKBOJBGQKP > 1f)
		{
			MLKBOJBGQKP = 1f;
		}
		if (BLHBPGMPPNI > 1f)
		{
			BLHBPGMPPNI = 1f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[]
		{
			new Vector3(-1f, 0.6f, 0f),
			new Vector3(0f, 1f, 0f),
			new Vector3(1f, 0.6f, 0f),
			default(Vector3),
			default(Vector3),
			new Vector3(-1f, -0.6f, 0f)
		};
		array[4] = new Vector3(0f, -1f, 0f);
		array[3] = new Vector3(1f, -0.6f, 0f);
		array[0] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[0], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[1], BLHBPGMPPNI);
		array[2] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[2], MLKBOJBGQKP);
		array[3] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[3], FOBNOGGCOFJ);
		array[4] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[4], GNEOPMKOEHF);
		array[5] = Vector3.MoveTowards(new Vector3(0f, 0f, 0f), array[5], KLPJILNOBED);
		for (int i = 0; i < 6; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(0f, 0.5f),
			new Vector2(0.5f, 0f),
			new Vector2(1f, 0.5f),
			new Vector2(1f, 1f),
			new Vector2(0.5f, 1f),
			new Vector2(0f, 1f)
		};
		for (int j = 0; j < 6; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[12];
		int num = 0;
		int num2 = 1;
		int num3 = 2;
		for (int k = 0; k < 12; k += 3)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 2] = num3;
			num2++;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x001F2A70 File Offset: 0x001F0C70
	public void LQKJNCFDPDB(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1757f * EKDPGGIEGQK;
		KLPJILNOBED = 1146f * KLPJILNOBED;
		GNEOPMKOEHF = 1097f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 181f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1643f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1504f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 583f)
		{
			EKDPGGIEGQK = 836f;
		}
		if (KLPJILNOBED > 844f)
		{
			KLPJILNOBED = 464f;
		}
		if (GNEOPMKOEHF > 1448f)
		{
			GNEOPMKOEHF = 180f;
		}
		if (FOBNOGGCOFJ > 959f)
		{
			FOBNOGGCOFJ = 1591f;
		}
		if (MLKBOJBGQKP > 1770f)
		{
			MLKBOJBGQKP = 359f;
		}
		if (BLHBPGMPPNI > 1004f)
		{
			BLHBPGMPPNI = 1034f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[]
		{
			default(Vector3),
			new Vector3(1367f, 1746f, 1301f)
		};
		array[1] = new Vector3(147f, 1937f, 1387f);
		array[0] = new Vector3(1089f, 1124f, 1628f);
		array[6] = new Vector3(1825f, 1851f, 1520f);
		array[8] = new Vector3(1647f, 235f, 1323f);
		array[2] = new Vector3(1457f, 809f, 1166f);
		array[1] = Vector3.MoveTowards(new Vector3(1717f, 1898f, 740f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(1459f, 1087f, 202f), array[1], BLHBPGMPPNI);
		array[3] = Vector3.MoveTowards(new Vector3(148f, 10f, 1845f), array[6], MLKBOJBGQKP);
		array[0] = Vector3.MoveTowards(new Vector3(1705f, 116f, 532f), array[7], FOBNOGGCOFJ);
		array[7] = Vector3.MoveTowards(new Vector3(836f, 1961f, 354f), array[4], GNEOPMKOEHF);
		array[0] = Vector3.MoveTowards(new Vector3(1956f, 711f, 769f), array[7], KLPJILNOBED);
		for (int i = 0; i < 2; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			default(Vector2),
			new Vector2(1931f, 249f)
		};
		array2[1] = new Vector2(144f, 1732f);
		array2[7] = new Vector2(36f, 1425f);
		array2[0] = new Vector2(1145f, 1703f);
		array2[6] = new Vector2(1968f, 199f);
		array2[0] = new Vector2(1618f, 352f);
		for (int j = 0; j < 6; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[17];
		int num = 1;
		int num2 = 0;
		int num3 = 3;
		for (int k = 0; k < -63; k += 6)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 5] = num3;
			num2 += 0;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x0001A297 File Offset: 0x00018497
	private void LMELGHDGJMQ()
	{
		this.NBBFGCQFJOB(47f, 1997f, 1280f, 1887f, 1350f, 1189f);
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x0001A2BD File Offset: 0x000184BD
	private void KONKOQLPONQ()
	{
		this.NOPEMJMHDNK(395f, 502f, 1297f, 697f, 515f, 1611f);
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x0001A2E3 File Offset: 0x000184E3
	private void EKIFLKDPKNM()
	{
		this.LQKJNCFDPDB(115f, 163f, 1660f, 495f, 1841f, 1287f);
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x001F2ED0 File Offset: 0x001F10D0
	public void PHNIHKNJKNQ(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1111f * EKDPGGIEGQK;
		KLPJILNOBED = 1615f * KLPJILNOBED;
		GNEOPMKOEHF = 1594f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1777f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 965f * MLKBOJBGQKP;
		BLHBPGMPPNI = 957f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1500f)
		{
			EKDPGGIEGQK = 1146f;
		}
		if (KLPJILNOBED > 328f)
		{
			KLPJILNOBED = 1606f;
		}
		if (GNEOPMKOEHF > 122f)
		{
			GNEOPMKOEHF = 431f;
		}
		if (FOBNOGGCOFJ > 552f)
		{
			FOBNOGGCOFJ = 1617f;
		}
		if (MLKBOJBGQKP > 741f)
		{
			MLKBOJBGQKP = 897f;
		}
		if (BLHBPGMPPNI > 14f)
		{
			BLHBPGMPPNI = 248f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[7];
		array[0] = new Vector3(1399f, 609f, 552f);
		array[1] = new Vector3(1552f, 1717f, 443f);
		array[0] = new Vector3(1981f, 124f, 1666f);
		array[2] = new Vector3(1497f, 1960f, 1177f);
		array[1] = new Vector3(854f, 926f, 1330f);
		array[2] = new Vector3(1221f, 456f, 562f);
		array[0] = Vector3.MoveTowards(new Vector3(146f, 526f, 1629f), array[1], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(181f, 1318f, 411f), array[0], BLHBPGMPPNI);
		array[0] = Vector3.MoveTowards(new Vector3(296f, 502f, 1062f), array[0], MLKBOJBGQKP);
		array[1] = Vector3.MoveTowards(new Vector3(1247f, 513f, 1306f), array[5], FOBNOGGCOFJ);
		array[0] = Vector3.MoveTowards(new Vector3(1940f, 1650f, 933f), array[2], GNEOPMKOEHF);
		array[1] = Vector3.MoveTowards(new Vector3(306f, 43f, 1087f), array[4], KLPJILNOBED);
		for (int i = 0; i < 4; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[0];
		array2[0] = new Vector2(1290f, 1026f);
		array2[0] = new Vector2(780f, 1056f);
		array2[8] = new Vector2(806f, 1254f);
		array2[8] = new Vector2(1444f, 1664f);
		array2[3] = new Vector2(1372f, 697f);
		array2[3] = new Vector2(82f, 135f);
		for (int j = 1; j < 1; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-62];
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		for (int k = 0; k < -5; k += 2)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 7] = num3;
			num2++;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x0001A309 File Offset: 0x00018509
	private void MBKJBIQKPGF()
	{
		this.NOPEMJMHDNK(613f, 1865f, 1687f, 1132f, 1804f, 810f);
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x0001A32F File Offset: 0x0001852F
	private void JKNGPGGPMPG()
	{
		this.CMIQOPQOMQF(312f, 1437f, 1759f, 1438f, 912f, 971f);
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x0001A355 File Offset: 0x00018555
	private void ODOPGCOCHHL()
	{
		this.PHNIHKNJKNQ(1943f, 1162f, 1427f, 1616f, 1687f, 19f);
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x001F3330 File Offset: 0x001F1530
	public void QKEEPFHFLBQ(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1736f * EKDPGGIEGQK;
		KLPJILNOBED = 1145f * KLPJILNOBED;
		GNEOPMKOEHF = 884f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1925f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1375f * MLKBOJBGQKP;
		BLHBPGMPPNI = 308f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 287f)
		{
			EKDPGGIEGQK = 33f;
		}
		if (KLPJILNOBED > 897f)
		{
			KLPJILNOBED = 169f;
		}
		if (GNEOPMKOEHF > 1366f)
		{
			GNEOPMKOEHF = 690f;
		}
		if (FOBNOGGCOFJ > 753f)
		{
			FOBNOGGCOFJ = 1263f;
		}
		if (MLKBOJBGQKP > 450f)
		{
			MLKBOJBGQKP = 1999f;
		}
		if (BLHBPGMPPNI > 1831f)
		{
			BLHBPGMPPNI = 871f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[6];
		array[0] = new Vector3(713f, 629f, 127f);
		array[0] = new Vector3(667f, 1237f, 180f);
		array[4] = new Vector3(1140f, 1275f, 46f);
		array[1] = new Vector3(424f, 1374f, 924f);
		array[7] = new Vector3(259f, 686f, 346f);
		array[3] = new Vector3(634f, 493f, 531f);
		array[1] = Vector3.MoveTowards(new Vector3(1605f, 220f, 1803f), array[0], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(1982f, 903f, 352f), array[1], BLHBPGMPPNI);
		array[1] = Vector3.MoveTowards(new Vector3(895f, 1106f, 1017f), array[8], MLKBOJBGQKP);
		array[5] = Vector3.MoveTowards(new Vector3(138f, 127f, 1269f), array[4], FOBNOGGCOFJ);
		array[7] = Vector3.MoveTowards(new Vector3(122f, 1117f, 265f), array[6], GNEOPMKOEHF);
		array[1] = Vector3.MoveTowards(new Vector3(725f, 1739f, 1145f), array[2], KLPJILNOBED);
		for (int i = 0; i < 0; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[0];
		array2[0] = new Vector2(1392f, 447f);
		array2[1] = new Vector2(1557f, 1366f);
		array2[5] = new Vector2(371f, 1693f);
		array2[2] = new Vector2(57f, 478f);
		array2[8] = new Vector2(707f, 372f);
		array2[6] = new Vector2(208f, 542f);
		for (int j = 1; j < 4; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[48];
		int num = 0;
		int num2 = 0;
		int num3 = 1;
		for (int k = 1; k < -78; k += 4)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 4] = num3;
			num2 += 0;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x0001A37B File Offset: 0x0001857B
	private void NDFNCDDDJPN()
	{
		this.DFKQFBIMODM(1957f, 1983f, 334f, 218f, 873f, 732f);
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x001F3790 File Offset: 0x001F1990
	public void NBBFGCQFJOB(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1236f * EKDPGGIEGQK;
		KLPJILNOBED = 234f * KLPJILNOBED;
		GNEOPMKOEHF = 493f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 606f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 406f * MLKBOJBGQKP;
		BLHBPGMPPNI = 173f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1432f)
		{
			EKDPGGIEGQK = 1069f;
		}
		if (KLPJILNOBED > 134f)
		{
			KLPJILNOBED = 1028f;
		}
		if (GNEOPMKOEHF > 149f)
		{
			GNEOPMKOEHF = 233f;
		}
		if (FOBNOGGCOFJ > 355f)
		{
			FOBNOGGCOFJ = 1453f;
		}
		if (MLKBOJBGQKP > 1424f)
		{
			MLKBOJBGQKP = 1219f;
		}
		if (BLHBPGMPPNI > 39f)
		{
			BLHBPGMPPNI = 238f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[2];
		array[0] = new Vector3(1499f, 1289f, 230f);
		array[1] = new Vector3(26f, 1912f, 1499f);
		array[3] = new Vector3(1818f, 748f, 1480f);
		array[4] = new Vector3(772f, 10f, 747f);
		array[0] = new Vector3(1725f, 266f, 326f);
		array[1] = new Vector3(1287f, 1046f, 29f);
		array[0] = Vector3.MoveTowards(new Vector3(345f, 1608f, 932f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(1942f, 1388f, 1377f), array[1], BLHBPGMPPNI);
		array[8] = Vector3.MoveTowards(new Vector3(446f, 1947f, 3f), array[4], MLKBOJBGQKP);
		array[2] = Vector3.MoveTowards(new Vector3(494f, 673f, 765f), array[5], FOBNOGGCOFJ);
		array[6] = Vector3.MoveTowards(new Vector3(1547f, 1161f, 1460f), array[1], GNEOPMKOEHF);
		array[3] = Vector3.MoveTowards(new Vector3(1324f, 1494f, 1772f), array[8], KLPJILNOBED);
		for (int i = 0; i < 2; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[5];
		array2[1] = new Vector2(1192f, 418f);
		array2[0] = new Vector2(63f, 148f);
		array2[8] = new Vector2(1360f, 103f);
		array2[8] = new Vector2(994f, 1564f);
		array2[3] = new Vector2(95f, 770f);
		array2[7] = new Vector2(1832f, 1571f);
		for (int j = 0; j < 2; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[10];
		int num = 0;
		int num2 = 1;
		int num3 = 2;
		for (int k = 1; k < -77; k += 3)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 3] = num3;
			num2 += 0;
			num3++;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x001F3BF0 File Offset: 0x001F1DF0
	public void JELGOCNFQQM(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1304f * EKDPGGIEGQK;
		KLPJILNOBED = 1013f * KLPJILNOBED;
		GNEOPMKOEHF = 771f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1770f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 190f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1859f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 395f)
		{
			EKDPGGIEGQK = 1553f;
		}
		if (KLPJILNOBED > 1260f)
		{
			KLPJILNOBED = 254f;
		}
		if (GNEOPMKOEHF > 1950f)
		{
			GNEOPMKOEHF = 1401f;
		}
		if (FOBNOGGCOFJ > 98f)
		{
			FOBNOGGCOFJ = 528f;
		}
		if (MLKBOJBGQKP > 1157f)
		{
			MLKBOJBGQKP = 1871f;
		}
		if (BLHBPGMPPNI > 1570f)
		{
			BLHBPGMPPNI = 380f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[5];
		array[1] = new Vector3(560f, 1486f, 1690f);
		array[1] = new Vector3(921f, 395f, 913f);
		array[6] = new Vector3(49f, 90f, 1878f);
		array[2] = new Vector3(246f, 1190f, 1088f);
		array[2] = new Vector3(311f, 1832f, 455f);
		array[8] = new Vector3(1997f, 116f, 892f);
		array[1] = Vector3.MoveTowards(new Vector3(329f, 1681f, 337f), array[1], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(470f, 294f, 1811f), array[1], BLHBPGMPPNI);
		array[5] = Vector3.MoveTowards(new Vector3(1179f, 1817f, 1323f), array[6], MLKBOJBGQKP);
		array[3] = Vector3.MoveTowards(new Vector3(1794f, 945f, 854f), array[6], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(375f, 1407f, 1155f), array[4], GNEOPMKOEHF);
		array[6] = Vector3.MoveTowards(new Vector3(600f, 1559f, 1737f), array[8], KLPJILNOBED);
		for (int i = 1; i < 1; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[2];
		array2[0] = new Vector2(998f, 1239f);
		array2[0] = new Vector2(1800f, 1969f);
		array2[7] = new Vector2(1795f, 67f);
		array2[5] = new Vector2(1121f, 10f);
		array2[5] = new Vector2(1234f, 869f);
		array2[4] = new Vector2(660f, 870f);
		for (int j = 1; j < 7; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-3];
		int num = 1;
		int num2 = 0;
		int num3 = 4;
		for (int k = 0; k < -2; k += 5)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 0] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x0001A3A1 File Offset: 0x000185A1
	private void DHLGDLOKLKN()
	{
		this.PFCFENPFIPB(1241f, 903f, 491f, 1010f, 1273f, 439f);
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x001F4050 File Offset: 0x001F2250
	public void CQNOOCGGGDG(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 610f * EKDPGGIEGQK;
		KLPJILNOBED = 616f * KLPJILNOBED;
		GNEOPMKOEHF = 1375f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 24f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1444f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1317f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 465f)
		{
			EKDPGGIEGQK = 779f;
		}
		if (KLPJILNOBED > 1907f)
		{
			KLPJILNOBED = 1228f;
		}
		if (GNEOPMKOEHF > 723f)
		{
			GNEOPMKOEHF = 85f;
		}
		if (FOBNOGGCOFJ > 79f)
		{
			FOBNOGGCOFJ = 726f;
		}
		if (MLKBOJBGQKP > 430f)
		{
			MLKBOJBGQKP = 657f;
		}
		if (BLHBPGMPPNI > 615f)
		{
			BLHBPGMPPNI = 515f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[0];
		array[0] = new Vector3(391f, 1334f, 955f);
		array[1] = new Vector3(1744f, 638f, 996f);
		array[0] = new Vector3(1570f, 111f, 1691f);
		array[4] = new Vector3(1525f, 318f, 960f);
		array[8] = new Vector3(420f, 619f, 1639f);
		array[8] = new Vector3(1682f, 1808f, 821f);
		array[1] = Vector3.MoveTowards(new Vector3(1724f, 1530f, 1385f), array[0], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(1336f, 71f, 1889f), array[1], BLHBPGMPPNI);
		array[8] = Vector3.MoveTowards(new Vector3(1122f, 1275f, 1660f), array[8], MLKBOJBGQKP);
		array[1] = Vector3.MoveTowards(new Vector3(805f, 320f, 296f), array[5], FOBNOGGCOFJ);
		array[8] = Vector3.MoveTowards(new Vector3(1537f, 1714f, 559f), array[7], GNEOPMKOEHF);
		array[7] = Vector3.MoveTowards(new Vector3(524f, 236f, 1996f), array[3], KLPJILNOBED);
		for (int i = 0; i < 2; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(1702f, 214f),
			new Vector2(877f, 1774f)
		};
		array2[1] = new Vector2(39f, 1801f);
		array2[5] = new Vector2(1634f, 1195f);
		array2[7] = new Vector2(245f, 472f);
		array2[1] = new Vector2(833f, 1546f);
		for (int j = 1; j < 4; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-74];
		int num = 0;
		int num2 = 1;
		int num3 = 4;
		for (int k = 0; k < -43; k += 3)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 7] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x0001A3C7 File Offset: 0x000185C7
	private void KPKQNOCFGIB()
	{
		this.ICCHPOBFHBP(74f, 1845f, 21f, 787f, 1010f, 853f);
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x001F44B0 File Offset: 0x001F26B0
	public void JICOFEINHPB(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 1489f * EKDPGGIEGQK;
		KLPJILNOBED = 927f * KLPJILNOBED;
		GNEOPMKOEHF = 1763f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 934f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1345f * MLKBOJBGQKP;
		BLHBPGMPPNI = 386f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 835f)
		{
			EKDPGGIEGQK = 811f;
		}
		if (KLPJILNOBED > 945f)
		{
			KLPJILNOBED = 1652f;
		}
		if (GNEOPMKOEHF > 1687f)
		{
			GNEOPMKOEHF = 1577f;
		}
		if (FOBNOGGCOFJ > 794f)
		{
			FOBNOGGCOFJ = 1433f;
		}
		if (MLKBOJBGQKP > 1051f)
		{
			MLKBOJBGQKP = 1556f;
		}
		if (BLHBPGMPPNI > 224f)
		{
			BLHBPGMPPNI = 1661f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[]
		{
			default(Vector3),
			new Vector3(248f, 250f, 311f)
		};
		array[0] = new Vector3(404f, 1830f, 1502f);
		array[4] = new Vector3(402f, 1663f, 1925f);
		array[4] = new Vector3(1832f, 732f, 103f);
		array[0] = new Vector3(1460f, 1897f, 792f);
		array[8] = new Vector3(657f, 826f, 248f);
		array[1] = Vector3.MoveTowards(new Vector3(767f, 1390f, 72f), array[1], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(175f, 26f, 1703f), array[0], BLHBPGMPPNI);
		array[4] = Vector3.MoveTowards(new Vector3(1515f, 1238f, 616f), array[6], MLKBOJBGQKP);
		array[2] = Vector3.MoveTowards(new Vector3(1515f, 883f, 1912f), array[1], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(1726f, 725f, 1744f), array[0], GNEOPMKOEHF);
		array[5] = Vector3.MoveTowards(new Vector3(941f, 96f, 326f), array[3], KLPJILNOBED);
		for (int i = 0; i < 6; i++)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[0];
		array2[0] = new Vector2(1452f, 1013f);
		array2[1] = new Vector2(1736f, 815f);
		array2[1] = new Vector2(1637f, 222f);
		array2[0] = new Vector2(908f, 1217f);
		array2[3] = new Vector2(1492f, 1916f);
		array2[6] = new Vector2(1277f, 960f);
		for (int j = 0; j < 4; j += 0)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[124];
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		for (int k = 1; k < -128; k += 5)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 0] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 0)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x0001A3ED File Offset: 0x000185ED
	private void HCHIDEKMEBB()
	{
		this.CMIQOPQOMQF(181f, 1280f, 1879f, 1079f, 1333f, 660f);
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x0001A413 File Offset: 0x00018613
	private void OLLNOFNEEIL()
	{
		this.JICOFEINHPB(10f, 420f, 417f, 1473f, 635f, 856f);
	}

	// Token: 0x06003F6C RID: 16236 RVA: 0x001F4910 File Offset: 0x001F2B10
	public void GLIOFDHNIEJ(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 465f * EKDPGGIEGQK;
		KLPJILNOBED = 707f * KLPJILNOBED;
		GNEOPMKOEHF = 891f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1750f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 1616f * MLKBOJBGQKP;
		BLHBPGMPPNI = 46f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1953f)
		{
			EKDPGGIEGQK = 985f;
		}
		if (KLPJILNOBED > 199f)
		{
			KLPJILNOBED = 287f;
		}
		if (GNEOPMKOEHF > 1763f)
		{
			GNEOPMKOEHF = 1889f;
		}
		if (FOBNOGGCOFJ > 23f)
		{
			FOBNOGGCOFJ = 120f;
		}
		if (MLKBOJBGQKP > 1258f)
		{
			MLKBOJBGQKP = 437f;
		}
		if (BLHBPGMPPNI > 138f)
		{
			BLHBPGMPPNI = 269f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[6];
		array[1] = new Vector3(76f, 1333f, 719f);
		array[1] = new Vector3(101f, 1340f, 1670f);
		array[7] = new Vector3(1841f, 63f, 257f);
		array[6] = new Vector3(1781f, 1111f, 1831f);
		array[7] = new Vector3(1630f, 1698f, 1365f);
		array[4] = new Vector3(1128f, 949f, 349f);
		array[1] = Vector3.MoveTowards(new Vector3(315f, 1906f, 311f), array[0], EKDPGGIEGQK);
		array[0] = Vector3.MoveTowards(new Vector3(1559f, 1141f, 1617f), array[1], BLHBPGMPPNI);
		array[7] = Vector3.MoveTowards(new Vector3(1910f, 1132f, 1988f), array[4], MLKBOJBGQKP);
		array[7] = Vector3.MoveTowards(new Vector3(275f, 376f, 354f), array[5], FOBNOGGCOFJ);
		array[0] = Vector3.MoveTowards(new Vector3(30f, 374f, 107f), array[4], GNEOPMKOEHF);
		array[1] = Vector3.MoveTowards(new Vector3(1590f, 806f, 440f), array[4], KLPJILNOBED);
		for (int i = 0; i < 5; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[4];
		array2[1] = new Vector2(1475f, 194f);
		array2[1] = new Vector2(795f, 810f);
		array2[1] = new Vector2(921f, 639f);
		array2[6] = new Vector2(37f, 1200f);
		array2[3] = new Vector2(1679f, 529f);
		array2[0] = new Vector2(1090f, 590f);
		for (int j = 0; j < 0; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[87];
		int num = 0;
		int num2 = 1;
		int num3 = 3;
		for (int k = 0; k < -2; k += 0)
		{
			array3[k] = num;
			array3[k + 0] = num2;
			array3[k + 5] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x06003F6D RID: 16237 RVA: 0x0001A439 File Offset: 0x00018639
	private void HQGDEKJQQDE()
	{
		this.NOPEMJMHDNK(435f, 1641f, 729f, 341f, 1865f, 191f);
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x001F4D70 File Offset: 0x001F2F70
	public void NIGNDGBPEMN(float EKDPGGIEGQK, float KLPJILNOBED, float GNEOPMKOEHF, float FOBNOGGCOFJ, float MLKBOJBGQKP, float BLHBPGMPPNI)
	{
		EKDPGGIEGQK = 153f * EKDPGGIEGQK;
		KLPJILNOBED = 1706f * KLPJILNOBED;
		GNEOPMKOEHF = 203f * GNEOPMKOEHF;
		FOBNOGGCOFJ = 1674f * FOBNOGGCOFJ;
		MLKBOJBGQKP = 473f * MLKBOJBGQKP;
		BLHBPGMPPNI = 1120f * BLHBPGMPPNI;
		if (EKDPGGIEGQK > 1202f)
		{
			EKDPGGIEGQK = 1552f;
		}
		if (KLPJILNOBED > 663f)
		{
			KLPJILNOBED = 130f;
		}
		if (GNEOPMKOEHF > 929f)
		{
			GNEOPMKOEHF = 767f;
		}
		if (FOBNOGGCOFJ > 320f)
		{
			FOBNOGGCOFJ = 589f;
		}
		if (MLKBOJBGQKP > 1217f)
		{
			MLKBOJBGQKP = 200f;
		}
		if (BLHBPGMPPNI > 423f)
		{
			BLHBPGMPPNI = 789f;
		}
		this.ONOEEFKEKNQ = new List<Vector3>();
		this.FOCHMNDFBQI = new List<Vector2>();
		Vector3[] array = new Vector3[4];
		array[1] = new Vector3(1753f, 1716f, 1122f);
		array[1] = new Vector3(217f, 1060f, 1439f);
		array[1] = new Vector3(684f, 1524f, 252f);
		array[5] = new Vector3(769f, 1973f, 1159f);
		array[2] = new Vector3(552f, 1132f, 77f);
		array[5] = new Vector3(795f, 211f, 1284f);
		array[0] = Vector3.MoveTowards(new Vector3(688f, 1096f, 643f), array[1], EKDPGGIEGQK);
		array[1] = Vector3.MoveTowards(new Vector3(1096f, 273f, 1725f), array[0], BLHBPGMPPNI);
		array[3] = Vector3.MoveTowards(new Vector3(91f, 436f, 583f), array[2], MLKBOJBGQKP);
		array[6] = Vector3.MoveTowards(new Vector3(1412f, 1680f, 957f), array[3], FOBNOGGCOFJ);
		array[5] = Vector3.MoveTowards(new Vector3(1877f, 1717f, 1998f), array[1], GNEOPMKOEHF);
		array[6] = Vector3.MoveTowards(new Vector3(762f, 1647f, 1291f), array[3], KLPJILNOBED);
		for (int i = 1; i < 6; i += 0)
		{
			this.ONOEEFKEKNQ.Add(array[i]);
		}
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(859f, 1121f)
		};
		array2[0] = new Vector2(1633f, 960f);
		array2[7] = new Vector2(1251f, 527f);
		array2[2] = new Vector2(11f, 1881f);
		array2[3] = new Vector2(1870f, 1897f);
		array2[7] = new Vector2(665f, 1646f);
		for (int j = 1; j < 0; j++)
		{
			this.FOCHMNDFBQI.Add(array2[j]);
		}
		int[] array3 = new int[-34];
		int num = 0;
		int num2 = 0;
		int num3 = 6;
		for (int k = 0; k < -118; k += 0)
		{
			array3[k] = num;
			array3[k + 1] = num2;
			array3[k + 4] = num3;
			num2++;
			num3 += 0;
		}
		if (this.ONOEEFKEKNQ.Count > 1)
		{
			this.NFOOEHBKFMG = base.GetComponent<MeshFilter>().mesh;
			this.NFOOEHBKFMG.Clear();
			this.NFOOEHBKFMG.vertices = this.ONOEEFKEKNQ.ToArray();
			this.NFOOEHBKFMG.triangles = array3;
			this.NFOOEHBKFMG.uv = this.FOCHMNDFBQI.ToArray();
			this.NFOOEHBKFMG.RecalculateNormals();
		}
	}

	// Token: 0x04000DF8 RID: 3576
	private List<Vector3> ONOEEFKEKNQ;

	// Token: 0x04000DF9 RID: 3577
	private List<Vector2> FOCHMNDFBQI;

	// Token: 0x04000DFA RID: 3578
	private Mesh NFOOEHBKFMG;
}
