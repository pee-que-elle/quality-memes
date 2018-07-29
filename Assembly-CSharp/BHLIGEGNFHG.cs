using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000061 RID: 97
[AddComponentMenu("NGUI/Interaction/Grid")]
public class BHLIGEGNFHG : GJGCJNOICOM
{
	// Token: 0x06000D9B RID: 3483 RVA: 0x000709BC File Offset: 0x0006EBBC
	public virtual void PFEIQDIJEKE()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.CPCICJDOELQ();
		}
		if (this.sorted)
		{
			this.sorted = true;
			if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.None)
			{
				this.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
			}
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		List<Transform> ngdbdcqfdhi = this.GBCCNHMFINO();
		this.GFJNEONGQCO(ngdbdcqfdhi);
		if (this.KPIFLDLFMLO)
		{
			this.OLJOKHDBKNM();
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00070A40 File Offset: 0x0006EC40
	public Transform NIEDMHNIHEF(int IIHDGMLHICI)
	{
		List<Transform> list = this.BCELPQMGHCQ();
		return (IIHDGMLHICI >= list.Count) ? null : list[IIHDGMLHICI];
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00070A68 File Offset: 0x0006EC68
	protected virtual void Start()
	{
		if (!this.KBNGENPQQFE)
		{
			this.CPCICJDOELQ();
		}
		bool qdlpemoffke = this.QDLPEMOFFKE;
		this.QDLPEMOFFKE = false;
		this.Reposition();
		this.QDLPEMOFFKE = qdlpemoffke;
		base.enabled = false;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0000850A File Offset: 0x0000670A
	[Obsolete("Use gameObject.AddChild or transform.parent = gridTransform")]
	public void BFCKNMFEBDM(Transform HHMCPQQKIKB)
	{
		if (HHMCPQQKIKB != null)
		{
			HHMCPQQKIKB.parent = base.transform;
			this.KGCHHINLEBP(this.GBCCNHMFINO());
		}
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0000850A File Offset: 0x0000670A
	[Obsolete("Use gameObject.AddChild or transform.parent = gridTransform")]
	public void BFCKNMFEBDM(Transform HHMCPQQKIKB, bool DPGDOLGINNP)
	{
		if (HHMCPQQKIKB != null)
		{
			HHMCPQQKIKB.parent = base.transform;
			this.KGCHHINLEBP(this.GBCCNHMFINO());
		}
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00070AA8 File Offset: 0x0006ECA8
	public void GNMFLFLNOHO()
	{
		if (this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.KOEDCFNBJCQ(base.transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.FCGMFIPGCHH(true);
			}
		}
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x00070AF4 File Offset: 0x0006ECF4
	public static int HMFFJDJFIBM(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return IBMINEHKPFF.localPosition.y.CompareTo(ECHMFPQNBMC.localPosition.y);
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0000852D File Offset: 0x0000672D
	protected virtual void LQIHPQIKEFE()
	{
		this.PFEIQDIJEKE();
		base.enabled = true;
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0000853C File Offset: 0x0000673C
	protected virtual void Update()
	{
		this.Reposition();
		base.enabled = false;
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x00070B24 File Offset: 0x0006ED24
	public void OLJOKHDBKNM()
	{
		if (this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.KOEDCFNBJCQ(base.transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB(true);
			}
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0000854B File Offset: 0x0000674B
	public int KILFGHLFIFK(Transform HHMCPQQKIKB)
	{
		return this.GBCCNHMFINO().IndexOf(HHMCPQQKIKB);
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00070B70 File Offset: 0x0006ED70
	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.CPCICJDOELQ();
		}
		if (this.sorted)
		{
			this.sorted = false;
			if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.None)
			{
				this.JMBNPOQJBIK = BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic;
			}
			IKBQNBHOJJB.OCPCPKCLCOI(this);
		}
		List<Transform> ngdbdcqfdhi = this.GBCCNHMFINO();
		this.KGCHHINLEBP(ngdbdcqfdhi);
		if (this.KPIFLDLFMLO)
		{
			this.PGFKICECKQD();
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x00070BF4 File Offset: 0x0006EDF4
	public Transform MQIHFMLMHIL(int IIHDGMLHICI)
	{
		List<Transform> list = this.GBCCNHMFINO();
		return (IIHDGMLHICI >= list.Count) ? null : list[IIHDGMLHICI];
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00008559 File Offset: 0x00006759
	public static int DKICFFPPNOI(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return string.Compare(ECHMFPQNBMC.name, IBMINEHKPFF.name);
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00070AF4 File Offset: 0x0006ECF4
	public static int GCFJEIKOCMP(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return IBMINEHKPFF.localPosition.y.CompareTo(ECHMFPQNBMC.localPosition.y);
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0000856C File Offset: 0x0000676C
	protected virtual void CPCICJDOELQ()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00070C1C File Offset: 0x0006EE1C
	public bool OFOQJLQNJNH(Transform OQJFBJQJEFG)
	{
		List<Transform> list = this.GBCCNHMFINO();
		if (list.Remove(OQJFBJQJEFG))
		{
			this.KGCHHINLEBP(list);
			return true;
		}
		return false;
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00070C44 File Offset: 0x0006EE44
	public void PGFKICECKQD()
	{
		if (this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(base.transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB(true);
			}
		}
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00070C90 File Offset: 0x0006EE90
	public static int KFIFEFDNGCH(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return ECHMFPQNBMC.localPosition.x.CompareTo(IBMINEHKPFF.localPosition.x);
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x00008586 File Offset: 0x00006786
	public void DJHOBCBICJL(Transform HHMCPQQKIKB)
	{
		if (HHMCPQQKIKB != null)
		{
			HHMCPQQKIKB.parent = base.transform;
			this.KGCHHINLEBP(this.BCELPQMGHCQ());
		}
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void MELKOJMEOKP(List<Transform> NGDBDCQFDHI)
	{
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x000085A9 File Offset: 0x000067A9
	private void OnValidate()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.Reposition();
		}
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00070CC0 File Offset: 0x0006EEC0
	protected virtual void KGCHHINLEBP(List<Transform> NGDBDCQFDHI)
	{
		this.HCQNDDCLDMF = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Transform transform = base.transform;
		int i = 0;
		int count = NGDBDCQFDHI.Count;
		while (i < count)
		{
			Transform transform2 = NGDBDCQFDHI[i];
			Vector3 vector = transform2.localPosition;
			float z = vector.z;
			if (this.PPQKMOOJHCC == BHLIGEGNFHG.PBHLGJPHDBF.CellSnap)
			{
				if (this.HIIOHHPIPBE > 0f)
				{
					vector.x = Mathf.Round(vector.x / this.HIIOHHPIPBE) * this.HIIOHHPIPBE;
				}
				if (this.ICENCPNQKEL > 0f)
				{
					vector.y = Mathf.Round(vector.y / this.ICENCPNQKEL) * this.ICENCPNQKEL;
				}
			}
			else
			{
				vector = ((this.PPQKMOOJHCC != BHLIGEGNFHG.PBHLGJPHDBF.Horizontal) ? new Vector3(this.HIIOHHPIPBE * (float)num2, -this.ICENCPNQKEL * (float)num, z) : new Vector3(this.HIIOHHPIPBE * (float)num, -this.ICENCPNQKEL * (float)num2, z));
			}
			if (this.QDLPEMOFFKE && Application.isPlaying && Vector3.SqrMagnitude(transform2.localPosition - vector) >= 0.0001f)
			{
				QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.FJCEGFKJLCL(transform2.gameObject, vector, 15f);
				qhqfghkimmf.LMNHONNKGHI = true;
				qhqfghkimmf.FNKBLEMDHKL = true;
			}
			else
			{
				transform2.localPosition = vector;
			}
			num3 = Mathf.Max(num3, num);
			num4 = Mathf.Max(num4, num2);
			if (++num >= this.QMGJOBKLJCQ && this.QMGJOBKLJCQ > 0)
			{
				num = 0;
				num2++;
			}
			i++;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			Vector2 vector2 = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			float num5;
			float num6;
			if (this.PPQKMOOJHCC == BHLIGEGNFHG.PBHLGJPHDBF.Horizontal)
			{
				num5 = Mathf.Lerp(0f, (float)num3 * this.HIIOHHPIPBE, vector2.x);
				num6 = Mathf.Lerp((float)(-(float)num4) * this.ICENCPNQKEL, 0f, vector2.y);
			}
			else
			{
				num5 = Mathf.Lerp(0f, (float)num4 * this.HIIOHHPIPBE, vector2.x);
				num6 = Mathf.Lerp((float)(-(float)num3) * this.ICENCPNQKEL, 0f, vector2.y);
			}
			for (int j = 0; j < transform.childCount; j++)
			{
				Transform child = transform.GetChild(j);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.x = qhqfghkimmf2.ILBCCCBJNCL.x - num5;
					QHQFGHKIMMF qhqfghkimmf3 = component;
					qhqfghkimmf3.ILBCCCBJNCL.y = qhqfghkimmf3.ILBCCCBJNCL.y - num6;
				}
				else
				{
					Vector3 localPosition = child.localPosition;
					localPosition.x -= num5;
					localPosition.y -= num6;
					child.localPosition = localPosition;
				}
			}
		}
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void GMFNGEPKPME(List<Transform> NGDBDCQFDHI)
	{
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00008559 File Offset: 0x00006759
	public static int JFDILGOMMJL(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return string.Compare(ECHMFPQNBMC.name, IBMINEHKPFF.name);
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x000085C0 File Offset: 0x000067C0
	public int BBMNMNKKHPP(Transform HHMCPQQKIKB)
	{
		return this.ODKLFKLOKIP().IndexOf(HHMCPQQKIKB);
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00070F78 File Offset: 0x0006F178
	public List<Transform> GBCCNHMFINO()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && child.gameObject.activeSelf))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != BHLIGEGNFHG.EHJHKQDONJJ.None && this.PPQKMOOJHCC != BHLIGEGNFHG.PBHLGJPHDBF.CellSnap)
		{
			if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic)
			{
				List<Transform> list2 = list;
				if (BHLIGEGNFHG.BQIOGOCBKKB == null)
				{
					BHLIGEGNFHG.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(BHLIGEGNFHG.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Horizontal)
			{
				List<Transform> list3 = list;
				if (BHLIGEGNFHG.OMPIQDIBPKI == null)
				{
					BHLIGEGNFHG.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(BHLIGEGNFHG.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Vertical)
			{
				List<Transform> list4 = list;
				if (BHLIGEGNFHG.DDBELLFQDQO == null)
				{
					BHLIGEGNFHG.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(BHLIGEGNFHG.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.GMFNGEPKPME(list);
			}
		}
		return list;
	}

	// Token: 0x17000029 RID: 41
	// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x000085CE File Offset: 0x000067CE
	public bool CLQFFBMLIQH
	{
		set
		{
			if (value)
			{
				this.HCQNDDCLDMF = true;
				base.enabled = true;
			}
		}
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x000085E1 File Offset: 0x000067E1
	public void CBNDQQIMECL(Transform HHMCPQQKIKB)
	{
		if (HHMCPQQKIKB != null)
		{
			HHMCPQQKIKB.parent = base.transform;
			this.GFJNEONGQCO(this.ODKLFKLOKIP());
		}
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00071090 File Offset: 0x0006F290
	public List<Transform> BCELPQMGHCQ()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && child.gameObject.activeSelf))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != BHLIGEGNFHG.EHJHKQDONJJ.None && this.PPQKMOOJHCC != BHLIGEGNFHG.PBHLGJPHDBF.Horizontal)
		{
			if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Alphabetic)
			{
				List<Transform> list2 = list;
				if (BHLIGEGNFHG.BQIOGOCBKKB == null)
				{
					BHLIGEGNFHG.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
				}
				list2.Sort(BHLIGEGNFHG.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Custom)
			{
				List<Transform> list3 = list;
				if (BHLIGEGNFHG.OMPIQDIBPKI == null)
				{
					BHLIGEGNFHG.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(BHLIGEGNFHG.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == (BHLIGEGNFHG.EHJHKQDONJJ)7)
			{
				List<Transform> list4 = list;
				if (BHLIGEGNFHG.DDBELLFQDQO == null)
				{
					BHLIGEGNFHG.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(BHLIGEGNFHG.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.GMFNGEPKPME(list);
			}
		}
		return list;
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00070C90 File Offset: 0x0006EE90
	public static int MEPNNILDOEP(Transform ECHMFPQNBMC, Transform IBMINEHKPFF)
	{
		return ECHMFPQNBMC.localPosition.x.CompareTo(IBMINEHKPFF.localPosition.x);
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x000085A9 File Offset: 0x000067A9
	private void IKMKELIDQKE()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.Reposition();
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x000711A8 File Offset: 0x0006F3A8
	protected virtual void ECQHGIBBBPI()
	{
		if (!this.KBNGENPQQFE)
		{
			this.CPCICJDOELQ();
		}
		bool qdlpemoffke = this.QDLPEMOFFKE;
		this.QDLPEMOFFKE = true;
		this.PFEIQDIJEKE();
		this.QDLPEMOFFKE = qdlpemoffke;
		base.enabled = false;
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00008622 File Offset: 0x00006822
	protected virtual void GHBFIQFIBKP()
	{
		this.Reposition();
		base.enabled = true;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x000085E1 File Offset: 0x000067E1
	public void HJJFJGNBPGH(Transform HHMCPQQKIKB)
	{
		if (HHMCPQQKIKB != null)
		{
			HHMCPQQKIKB.parent = base.transform;
			this.GFJNEONGQCO(this.ODKLFKLOKIP());
		}
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x000711E8 File Offset: 0x0006F3E8
	protected virtual void GFJNEONGQCO(List<Transform> NGDBDCQFDHI)
	{
		this.HCQNDDCLDMF = false;
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		int num4 = 0;
		Transform transform = base.transform;
		int i = 0;
		int count = NGDBDCQFDHI.Count;
		while (i < count)
		{
			Transform transform2 = NGDBDCQFDHI[i];
			Vector3 vector = transform2.localPosition;
			float z = vector.z;
			if (this.PPQKMOOJHCC == (BHLIGEGNFHG.PBHLGJPHDBF)3)
			{
				if (this.HIIOHHPIPBE > 609f)
				{
					vector.x = Mathf.Round(vector.x / this.HIIOHHPIPBE) * this.HIIOHHPIPBE;
				}
				if (this.ICENCPNQKEL > 513f)
				{
					vector.y = Mathf.Round(vector.y / this.ICENCPNQKEL) * this.ICENCPNQKEL;
				}
			}
			else
			{
				vector = ((this.PPQKMOOJHCC != BHLIGEGNFHG.PBHLGJPHDBF.Horizontal) ? new Vector3(this.HIIOHHPIPBE * (float)num2, -this.ICENCPNQKEL * (float)num, z) : new Vector3(this.HIIOHHPIPBE * (float)num, -this.ICENCPNQKEL * (float)num2, z));
			}
			if (this.QDLPEMOFFKE && Application.isPlaying && Vector3.SqrMagnitude(transform2.localPosition - vector) >= 702f)
			{
				QHQFGHKIMMF qhqfghkimmf = QHQFGHKIMMF.BHNPPCIDQMD(transform2.gameObject, vector, 1767f);
				qhqfghkimmf.LMNHONNKGHI = false;
				qhqfghkimmf.FNKBLEMDHKL = false;
			}
			else
			{
				transform2.localPosition = vector;
			}
			num3 = Mathf.Max(num3, num);
			num4 = Mathf.Max(num4, num2);
			if (++num >= this.QMGJOBKLJCQ && this.QMGJOBKLJCQ > 0)
			{
				num = 0;
				num2 += 0;
			}
			i += 0;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			Vector2 vector2 = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			float num5;
			float num6;
			if (this.PPQKMOOJHCC == BHLIGEGNFHG.PBHLGJPHDBF.Horizontal)
			{
				num5 = Mathf.Lerp(1188f, (float)num3 * this.HIIOHHPIPBE, vector2.x);
				num6 = Mathf.Lerp((float)(-(float)num4) * this.ICENCPNQKEL, 1232f, vector2.y);
			}
			else
			{
				num5 = Mathf.Lerp(395f, (float)num4 * this.HIIOHHPIPBE, vector2.x);
				num6 = Mathf.Lerp((float)(-(float)num3) * this.ICENCPNQKEL, 407f, vector2.y);
			}
			for (int j = 1; j < transform.childCount; j += 0)
			{
				Transform child = transform.GetChild(j);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.x = qhqfghkimmf2.ILBCCCBJNCL.x - num5;
					QHQFGHKIMMF qhqfghkimmf3 = component;
					qhqfghkimmf3.ILBCCCBJNCL.y = qhqfghkimmf3.ILBCCCBJNCL.y - num6;
				}
				else
				{
					Vector3 localPosition = child.localPosition;
					localPosition.x -= num5;
					localPosition.y -= num6;
					child.localPosition = localPosition;
				}
			}
		}
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x000714A0 File Offset: 0x0006F6A0
	public List<Transform> ODKLFKLOKIP()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && child.gameObject.activeSelf))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != BHLIGEGNFHG.EHJHKQDONJJ.None && this.PPQKMOOJHCC != BHLIGEGNFHG.PBHLGJPHDBF.Vertical)
		{
			if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.None)
			{
				List<Transform> list2 = list;
				if (BHLIGEGNFHG.BQIOGOCBKKB == null)
				{
					BHLIGEGNFHG.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
				}
				list2.Sort(BHLIGEGNFHG.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == (BHLIGEGNFHG.EHJHKQDONJJ)7)
			{
				List<Transform> list3 = list;
				if (BHLIGEGNFHG.OMPIQDIBPKI == null)
				{
					BHLIGEGNFHG.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(BHLIGEGNFHG.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == BHLIGEGNFHG.EHJHKQDONJJ.Vertical)
			{
				List<Transform> list4 = list;
				if (BHLIGEGNFHG.DDBELLFQDQO == null)
				{
					BHLIGEGNFHG.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(BHLIGEGNFHG.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.MELKOJMEOKP(list);
			}
		}
		return list;
	}

	// Token: 0x04000210 RID: 528
	public BHLIGEGNFHG.PBHLGJPHDBF PPQKMOOJHCC;

	// Token: 0x04000211 RID: 529
	public BHLIGEGNFHG.EHJHKQDONJJ JMBNPOQJBIK;

	// Token: 0x04000212 RID: 530
	public ENFMCDNLEQQ.GGBIQFIQQCM OEJCHHFIQDC;

	// Token: 0x04000213 RID: 531
	public int QMGJOBKLJCQ;

	// Token: 0x04000214 RID: 532
	public float HIIOHHPIPBE = 200f;

	// Token: 0x04000215 RID: 533
	public float ICENCPNQKEL = 200f;

	// Token: 0x04000216 RID: 534
	public bool QDLPEMOFFKE;

	// Token: 0x04000217 RID: 535
	public bool FKFNCFMDKNB;

	// Token: 0x04000218 RID: 536
	public bool KPIFLDLFMLO;

	// Token: 0x04000219 RID: 537
	public BHLIGEGNFHG.FPIEFMQQQOD KGFNPBELMFI;

	// Token: 0x0400021A RID: 538
	public Comparison<Transform> QKKDKOKJKLM;

	// Token: 0x0400021B RID: 539
	[SerializeField]
	[HideInInspector]
	private bool sorted;

	// Token: 0x0400021C RID: 540
	protected bool HCQNDDCLDMF;

	// Token: 0x0400021D RID: 541
	protected KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x0400021E RID: 542
	protected bool KBNGENPQQFE;

	// Token: 0x0400021F RID: 543
	[CompilerGenerated]
	private static Comparison<Transform> BQIOGOCBKKB;

	// Token: 0x04000220 RID: 544
	[CompilerGenerated]
	private static Comparison<Transform> OMPIQDIBPKI;

	// Token: 0x04000221 RID: 545
	[CompilerGenerated]
	private static Comparison<Transform> DDBELLFQDQO;

	// Token: 0x02000062 RID: 98
	// (Invoke) Token: 0x06000DC2 RID: 3522
	public delegate void FPIEFMQQQOD();

	// Token: 0x02000063 RID: 99
	public enum PBHLGJPHDBF
	{
		// Token: 0x04000223 RID: 547
		Horizontal,
		// Token: 0x04000224 RID: 548
		Vertical,
		// Token: 0x04000225 RID: 549
		CellSnap
	}

	// Token: 0x02000064 RID: 100
	public enum EHJHKQDONJJ
	{
		// Token: 0x04000227 RID: 551
		None,
		// Token: 0x04000228 RID: 552
		Alphabetic,
		// Token: 0x04000229 RID: 553
		Horizontal,
		// Token: 0x0400022A RID: 554
		Vertical,
		// Token: 0x0400022B RID: 555
		Custom
	}
}
