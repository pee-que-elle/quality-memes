using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001C7 RID: 455
public class NLDFFJFQJBI : MonoBehaviour
{
	// Token: 0x06003A09 RID: 14857 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void QPFQFPPGING(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x001B8400 File Offset: 0x001B6600
	private void EINPCFNDKKJ()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 4;
		this.PLGLHQCLPIM();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1601f, 471f, 192f, 1453f));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(141f, 1317f, 1810f, 1853f);
		}
	}

	// Token: 0x06003A0B RID: 14859 RVA: 0x001B84B4 File Offset: 0x001B66B4
	public void JJDIJNQGDMG(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(1f, 1f, 1f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.PGIDCBGCGMP(false);
		}
		else
		{
			Debug.LogError("Expected to have 'target' set to a valid transform", this);
			base.enabled = false;
		}
	}

	// Token: 0x06003A0C RID: 14860 RVA: 0x001B8564 File Offset: 0x001B6764
	private void KPKQNOCFGIB()
	{
		KGQECFKLKOP.BGJPJCDBLFB += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 0;
		this.GMFNGEPKPME();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1516f, 459f, 1121f, 273f));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(690f, 1577f, 661f, 1492f));
		}
	}

	// Token: 0x06003A0D RID: 14861 RVA: 0x001B8618 File Offset: 0x001B6818
	public void HQIKGIBOEOJ(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.QOQONHOOLNE != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.QOQONHOOLNE.ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 816f) && (!this.EELFHGNCLKO || (vector.x > 1819f && vector.x < 1911f && vector.y > 1154f && vector.y >= 153f)))
		{
			return;
		}
		this.LHLKGFCCEHO = true;
		base.gameObject.SetActive(false);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("The sunlight faded.", "-fieldactivate");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("safeguard", "Pidgeoto");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < PIDLOFMIEFQ.Length; i += 0)
		{
			if (PIDLOFMIEFQ.Length > 1 && i + 7 < PIDLOFMIEFQ.Length && PIDLOFMIEFQ[i] == 'I')
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 1);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 1, 7).ToUpper())
				{
					list.Add(i);
					i += 5;
				}
			}
		}
		if (list.Count > 0)
		{
			for (int j = list.Count - 1; j > -1; j--)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list[j] + 4) + "imprison" + PIDLOFMIEFQ.Substring(list[j] + 5);
			}
		}
		for (int k = 1; k < PIDLOFMIEFQ.Length; k++)
		{
			int[] array = this.DIEFPEQNKBF.QGCQQOHBILP(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[0]);
				k += array[1] - array[0];
			}
		}
		int num = list2.Count * 17;
		if (list2.Count > 1)
		{
			for (int l = list2.Count - 0; l > -1; l -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list2[l]) + " can't use items anymore!\r\n" + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = 63 + num;
		if (PIDLOFMIEFQ.Length > num + 0)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - 2).IndexOf("aa");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num - -122 + num2) + "BuffIcon_ElectricIncrease";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num) + "Hold or Use?";
			}
		}
		this.DIEFPEQNKBF.LKPOBCBOFIC("_FogHeightData" + PIDLOFMIEFQ + " has no mainTexture setter");
		this.CLNQBNJGOBN.NONQDHBCIIN(new Color(314f, 1724f, 1285f, 1574f));
		this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1771f, 1079f, 1916f, 765f);
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = false;
		this.BDOLJKJOLID = false;
		this.BBDKNBJLMOH = false;
	}

	// Token: 0x06003A0E RID: 14862 RVA: 0x001B89A4 File Offset: 0x001B6BA4
	private void MCPGMIOIPKC()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1898f, 924f, 523f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.EKIOCFHQODK(true);
		}
	}

	// Token: 0x06003A0F RID: 14863 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void PJLIJPKGCPB(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A10 RID: 14864 RVA: 0x001B8A40 File Offset: 0x001B6C40
	private void FJGHCONLOHO()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 744f) || !this.EELFHGNCLKO || (vector.x > 863f && vector.x < 1217f && vector.y > 1544f && vector.y < 85f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.CBKGHILOGDK(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1165f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.OHBGEBQQNPH(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 847f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1093f, 1677f, 1773f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 912f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 1385f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 947f;
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1750f, 70f, 1702f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1796f * Time.deltaTime));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 166f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(476f, 137f, 1912f, 239f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1498f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = true;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 330f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1758f, 1682f, 303f, 734f));
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(301f, 425f, 1228f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1008f * Time.deltaTime));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(738f, 801f, 1522f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1358f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 1151f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1700f, 1318f, 1369f, 1592f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003A11 RID: 14865 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void PFFGFDDDPDB(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A12 RID: 14866 RVA: 0x001B8DF8 File Offset: 0x001B6FF8
	public void FENJGEOICCQ(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(715f, 1293f, 1804f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.EKIOCFHQODK(false);
		}
		else
		{
			Debug.LogError("[-]!\r\n", this);
			base.enabled = true;
		}
	}

	// Token: 0x06003A13 RID: 14867 RVA: 0x001B8EA8 File Offset: 0x001B70A8
	private void NMPQODOHHCC()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(731f, 311f, 1760f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LNMQJKOODGJ(true);
		}
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x001B8F44 File Offset: 0x001B7144
	private void NGHFIFIQHLC()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 1640f) && (!this.EELFHGNCLKO || (vector.x > 504f && vector.x < 425f && vector.y > 208f && vector.y < 650f));
		if (this.DIEMCOMFBIN != flag)
		{
			this.NODDOFIHEIB(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1487f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.MDIEMNKPMMN(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 529f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(559f, 1621f, 489f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 1965f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 653f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 311f;
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1253f, 248f, 1117f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1181f * Time.deltaTime));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1925f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1882f, 1544f, 1048f, 1614f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 375f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 568f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(500f, 1690f, 1764f, 1578f);
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(189f, 1898f, 878f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1927f * Time.deltaTime));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1078f, 765f, 557f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 256f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 545f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1798f, 987f, 639f, 1314f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x001B92FC File Offset: 0x001B74FC
	private void LBIFHHFMPHD()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 7;
		this.IMJJLIJHCQJ();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(819f, 892f, 1354f, 1343f);
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(242f, 1260f, 1600f, 1786f));
		}
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x001B93B0 File Offset: 0x001B75B0
	public void PPPBCGKFNMF(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.QOQONHOOLNE != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.QOQONHOOLNE.ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1904f) && (!this.EELFHGNCLKO || (vector.x <= 195f || vector.x >= 1909f || vector.y <= 987f) || vector.y >= 1869f))
		{
			return;
		}
		this.LHLKGFCCEHO = false;
		base.gameObject.SetActive(true);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("Fire's power was weakened!\r\n", "Battle Request");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("skydrop", "pacman(");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < PIDLOFMIEFQ.Length; i++)
		{
			if (PIDLOFMIEFQ.Length > 2 && i + 0 < PIDLOFMIEFQ.Length && (int)PIDLOFMIEFQ[i] == -14)
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 0);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 1, 0).ToUpper())
				{
					list.Add(i);
					i += 7;
				}
			}
		}
		if (list.Count > 1)
		{
			for (int j = list.Count - 1; j > -1; j -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list[j] + 6) + "inky" + PIDLOFMIEFQ.Substring(list[j] + 7);
			}
		}
		for (int k = 0; k < PIDLOFMIEFQ.Length; k += 0)
		{
			int[] array = this.DIEFPEQNKBF.KOMEFCQPPFG(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[1]);
				k += array[1] - array[1];
			}
		}
		int num = list2.Count * -121;
		if (list2.Count > 0)
		{
			for (int l = list2.Count - 0; l > -1; l -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list2[l]) + "FactoryTempTexture" + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = -110 + num;
		if (PIDLOFMIEFQ.Length > num + 0)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - 113).IndexOf("Chance for same Nature");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num - 125 + num2) + " avoids attacks by its ally Pokemon!\r\n";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num) + "FactoryTempTexture";
			}
		}
		this.DIEFPEQNKBF.LKPOBCBOFIC("Shield Dust" + PIDLOFMIEFQ + "blank");
		this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1977f, 1424f, 997f, 341f));
		this.DIEFPEQNKBF.NONQDHBCIIN(new Color(300f, 834f, 1617f, 646f));
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = true;
		this.BDOLJKJOLID = false;
		this.BBDKNBJLMOH = true;
	}

	// Token: 0x06003A17 RID: 14871 RVA: 0x00018B91 File Offset: 0x00016D91
	public void FNEKBHKCOBM()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 8;
	}

	// Token: 0x06003A18 RID: 14872 RVA: 0x001B973C File Offset: 0x001B793C
	private void BFNMQJHEQHL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 601f) || !this.EELFHGNCLKO || (vector.x > 202f && vector.x < 443f && vector.y > 803f && vector.y < 1282f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.LBNPKCFEICF(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 459f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.LPQJDLLBLCB(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 1022f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1824f, 728f, 1531f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 925f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 1760f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 894f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(50f, 1226f, 67f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1724f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1857f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(290f, 1371f, 429f, 1882f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1130f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 1480f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1006f, 1127f, 1704f, 13f));
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(874f, 1844f, 193f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 156f * Time.deltaTime));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1293f, 44f, 1726f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1476f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 525f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(692f, 621f, 1642f, 1295f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = true;
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003A19 RID: 14873 RVA: 0x00018BCC File Offset: 0x00016DCC
	public void FIKJJBMPNBH()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
	}

	// Token: 0x06003A1A RID: 14874 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void KQIFOQOQJPH(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A1B RID: 14875 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOIOGNMBEGD(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A1C RID: 14876 RVA: 0x001B9AF4 File Offset: 0x001B7CF4
	public void IFMKOBLGIIC(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(471f, 503f, 1357f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DLJCCNCBDDH(false);
		}
		else
		{
			Debug.LogError("The trade with '", this);
			base.enabled = true;
		}
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOELOGNMNQN(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x00018C07 File Offset: 0x00016E07
	public void KGGMKDOKGGF()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 8;
	}

	// Token: 0x06003A1F RID: 14879 RVA: 0x001B9BA4 File Offset: 0x001B7DA4
	private void NODDOFIHEIB(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = true;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = false;
		}
	}

	// Token: 0x06003A20 RID: 14880 RVA: 0x001B9C04 File Offset: 0x001B7E04
	private void PGIDCBGCGMP(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = true;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = false;
		}
	}

	// Token: 0x06003A21 RID: 14881 RVA: 0x00018C42 File Offset: 0x00016E42
	public void NGNQGOQKJLI()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 7;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
	}

	// Token: 0x06003A22 RID: 14882 RVA: 0x001B9C64 File Offset: 0x001B7E64
	private void BBFBCBMEJEN()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1451f, 1016f, 1399f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LNMQJKOODGJ(false);
		}
	}

	// Token: 0x06003A23 RID: 14883 RVA: 0x001B9D00 File Offset: 0x001B7F00
	private void LBNPKCFEICF(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = false;
		}
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x001B9D60 File Offset: 0x001B7F60
	private void BMQJHNLJMEK()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1119f, 716f, 1087f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.KDKCBMIEJCJ(true);
		}
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void LDMIQOPGDBQ(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x001B9DFC File Offset: 0x001B7FFC
	private void LMELGHDGJMQ()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 1;
		this.JIDLIKGJEDP();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(539f, 1948f, 1141f, 559f);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(133f, 546f, 1419f, 1798f);
		}
	}

	// Token: 0x06003A27 RID: 14887 RVA: 0x001B9EB0 File Offset: 0x001B80B0
	private void DHGEJKGNHCO()
	{
		KGQECFKLKOP.BGJPJCDBLFB += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 4;
		this.IMJJLIJHCQJ();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(false);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(925f, 594f, 172f, 1390f);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1941f, 1086f, 379f, 912f);
		}
	}

	// Token: 0x06003A28 RID: 14888 RVA: 0x001B9F64 File Offset: 0x001B8164
	private void MJPQJHEEPMD()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 3;
		this.JIDLIKGJEDP();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1777f, 1029f, 1402f, 1893f);
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1341f, 9f, 307f, 1471f));
		}
	}

	// Token: 0x06003A29 RID: 14889 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void GLCDMLHOQGQ(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A2A RID: 14890 RVA: 0x001BA018 File Offset: 0x001B8218
	private void MJGBKJICLIE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 1320f) && this.EELFHGNCLKO && (vector.x <= 1735f || vector.x >= 1611f || vector.y <= 1615f || vector.y < 1795f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.LBNPKCFEICF(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 736f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.LPQJDLLBLCB(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 882f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1186f, 861f, 1354f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 118f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 3f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1719f;
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(140f, 74f, 828f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1477f * Time.deltaTime));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 573f)
			{
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1939f, 1839f, 370f, 224f);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 845f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = true;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 1904f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1696f, 34f, 286f, 1586f);
			}
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(789f, 1566f, 1765f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1232f * Time.deltaTime);
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(832f, 1305f, 262f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1967f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 4f)
			{
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1857f, 979f, 507f, 755f));
				this.CLNQBNJGOBN.enabled = false;
				this.BDOLJKJOLID = true;
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003A2B RID: 14891 RVA: 0x001BA3D0 File Offset: 0x001B85D0
	private void FDDJNQBDCPJ()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 731f) || !this.EELFHGNCLKO || (vector.x > 1603f && vector.x < 1600f && vector.y > 6f && vector.y < 1500f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.PGIDCBGCGMP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1668f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.PFFGFDDDPDB(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 1134f)
		{
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1894f, 1574f, 635f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 1061f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 1641f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 835f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(848f, 88f, 858f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1100f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 281f)
			{
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1085f, 919f, 644f, 124f);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1004f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 1239f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(479f, 325f, 1485f, 134f);
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1868f, 1579f, 815f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1763f * Time.deltaTime));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(285f, 1355f, 1333f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 817f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 1578f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(243f, 1342f, 1239f, 1505f);
				this.CLNQBNJGOBN.enabled = false;
				this.BDOLJKJOLID = true;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A2C RID: 14892 RVA: 0x001BA788 File Offset: 0x001B8988
	public void EFKHDPFCJPE(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(594f, 788f, 52f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.KDKCBMIEJCJ(true);
		}
		else
		{
			Debug.LogError("Prevents status conditions in sunny weather.", this);
			base.enabled = false;
		}
	}

	// Token: 0x06003A2D RID: 14893 RVA: 0x001BA838 File Offset: 0x001B8A38
	private void KQPHQNNDCNP()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 1299f) && (!this.EELFHGNCLKO || vector.x <= 1775f || vector.x >= 792f || vector.y <= 1852f || vector.y < 372f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.KMEFBPHDHDM(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1285f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.QPFQFPPGING(false);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 409f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(997f, 640f, 1000f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 1157f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 762f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1707f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(39f, 661f, 1197f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1495f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1109f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1538f, 1955f, 887f, 1487f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1891f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 1409f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1656f, 1143f, 848f, 1573f);
			}
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(652f, 1222f, 1264f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1190f * Time.deltaTime);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1564f, 419f, 1923f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1867f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 1803f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1786f, 1854f, 1334f, 609f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A2E RID: 14894 RVA: 0x001BABF0 File Offset: 0x001B8DF0
	public void KJLKBMCCNFO(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.BJLGEDCPENQ() != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.BJLGEDCPENQ().ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 884f) && this.EELFHGNCLKO && vector.x > 1684f && vector.x < 449f && vector.y > 1542f && vector.y >= 1628f)
		{
			return;
		}
		this.LHLKGFCCEHO = true;
		base.gameObject.SetActive(true);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("_VelocityTex", "RKS System");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("M6", "teravolt");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < PIDLOFMIEFQ.Length; i += 0)
		{
			if (PIDLOFMIEFQ.Length > 5 && i + 7 < PIDLOFMIEFQ.Length && PIDLOFMIEFQ[i] == ')')
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 1);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 0, 1).ToUpper())
				{
					list.Add(i);
					i += 7;
				}
			}
		}
		if (list.Count > 1)
		{
			for (int j = list.Count - 1; j > -1; j -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list[j] + 2) + "[/urn]" + PIDLOFMIEFQ.Substring(list[j] + 4);
			}
		}
		for (int k = 1; k < PIDLOFMIEFQ.Length; k++)
		{
			int[] array = this.DIEFPEQNKBF.KOMEFCQPPFG(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[1]);
				k += array[0] - array[0];
			}
		}
		int num = list2.Count * -98;
		if (list2.Count > 1)
		{
			for (int l = list2.Count - 0; l > -1; l--)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list2[l]) + "'s " + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = 23 + num;
		if (PIDLOFMIEFQ.Length > num + 1)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - 21).IndexOf(" ");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num - -92 + num2) + "UpS";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num) + "Would like to purchase another Pokébox?\nCost: ";
			}
		}
		this.DIEFPEQNKBF.LKPOBCBOFIC(" became confused!\r\n" + PIDLOFMIEFQ + "p");
		this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(552f, 216f, 686f, 1295f);
		this.DIEFPEQNKBF.NONQDHBCIIN(new Color(740f, 1444f, 1930f, 398f));
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = false;
		this.BDOLJKJOLID = true;
		this.BBDKNBJLMOH = false;
	}

	// Token: 0x06003A2F RID: 14895 RVA: 0x001BAF7C File Offset: 0x001B917C
	private void KMEFBPHDHDM(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A30 RID: 14896 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void MICLCICHJGP(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A31 RID: 14897 RVA: 0x001BAFDC File Offset: 0x001B91DC
	private void CBKGHILOGDK(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A32 RID: 14898 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void OHBGEBQQNPH(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A33 RID: 14899 RVA: 0x001BB03C File Offset: 0x001B923C
	private void KDKCBMIEJCJ(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = true;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A34 RID: 14900 RVA: 0x001BB09C File Offset: 0x001B929C
	private void QEOHNFDHFCG(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = true;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = false;
		}
	}

	// Token: 0x06003A35 RID: 14901 RVA: 0x00018C7D File Offset: 0x00016E7D
	public void NKGLLKONDNQ()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x06003A36 RID: 14902 RVA: 0x001BB0FC File Offset: 0x001B92FC
	private void OLDHEQHJHNL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 962f) || !this.EELFHGNCLKO || vector.x <= 851f || vector.x >= 1113f || vector.y <= 1319f || vector.y < 164f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.QEOHNFDHFCG(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1861f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.OHBGEBQQNPH(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 1746f)
		{
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(294f, 466f, 1999f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 559f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 999f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1926f;
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1815f, 1550f, 1874f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1930f * Time.deltaTime));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 822f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(598f, 1699f, 1638f, 756f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 994f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = true;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 1711f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(445f, 676f, 1016f, 384f);
			}
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(479f, 467f, 673f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 696f * Time.deltaTime);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(971f, 389f, 711f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 599f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 227f)
			{
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(259f, 1471f, 879f, 746f));
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = true;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A37 RID: 14903 RVA: 0x001BB4B4 File Offset: 0x001B96B4
	private void BCBIEPHJOGG()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 989f) || !this.EELFHGNCLKO || vector.x <= 276f || vector.x >= 968f || vector.y <= 145f || vector.y < 131f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.EKIOCFHQODK(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1726f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.LPQJDLLBLCB(false);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 1422f)
		{
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(205f, 456f, 1028f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 1780f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 1239f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1336f;
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(181f, 1248f, 290f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1342f * Time.deltaTime));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 937f)
			{
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(119f, 1670f, 1201f, 325f);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1369f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 544f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1080f, 320f, 260f, 988f);
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1074f, 31f, 776f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1029f * Time.deltaTime));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1906f, 657f, 1439f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1999f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 788f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(436f, 1838f, 302f, 1079f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x001BB86C File Offset: 0x001B9A6C
	private void GGGNJNNQMED()
	{
		KGQECFKLKOP.BGJPJCDBLFB += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 5;
		this.NKGLLKONDNQ();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1958f, 865f, 1194f, 1430f);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(972f, 912f, 828f, 1502f);
		}
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x001BB920 File Offset: 0x001B9B20
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 0f) && (!this.EELFHGNCLKO || (vector.x > 0f && vector.x < 1f && vector.y > 0f && vector.y < 1f));
		if (this.DIEMCOMFBIN != flag)
		{
			this.PGIDCBGCGMP(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 0f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.BOIOGNMBEGD(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 6f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 4f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 0.9f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1f, 1f, 1f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 6f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 0.9f)
			{
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1f, 1f, 1f, 1f);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 0.2f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 0.95f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0.95f);
			}
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 4f * Time.deltaTime);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1f, 1f, 1f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 8f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 0.2f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
				this.CLNQBNJGOBN.enabled = false;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x001BBCD8 File Offset: 0x001B9ED8
	public void GHENQMGJHGG(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(937f, 146f, 1442f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.NODDOFIHEIB(true);
		}
		else
		{
			Debug.LogError("spotlight", this);
			base.enabled = false;
		}
	}

	// Token: 0x06003A3B RID: 14907 RVA: 0x00018CB8 File Offset: 0x00016EB8
	public void JJCOCFDCEKN()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
	}

	// Token: 0x06003A3C RID: 14908 RVA: 0x00018CF3 File Offset: 0x00016EF3
	public void GPJHOFPFCJD()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
	}

	// Token: 0x06003A3D RID: 14909 RVA: 0x001BBD88 File Offset: 0x001B9F88
	private void PFQDFBHEJEH()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 0;
		this.JJCOCFDCEKN();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(false);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(369f, 51f, 156f, 1298f));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(944f, 1805f, 325f, 680f);
		}
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x001BBE3C File Offset: 0x001BA03C
	public void IGKMHGHLLBH(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(1290f, 981f, 1915f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LNMQJKOODGJ(false);
		}
		else
		{
			Debug.LogError("BuffIcon_Fly", this);
			base.enabled = false;
		}
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x001BBEEC File Offset: 0x001BA0EC
	private void HKJPPHFBPHE()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.MOGQNGEPCEO().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 1471f) && this.EELFHGNCLKO && (vector.x <= 1338f || vector.x >= 1305f || vector.y <= 1257f || vector.y < 1378f);
		if (this.DIEMCOMFBIN != flag)
		{
			this.LBNPKCFEICF(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1481f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.PFFGFDDDPDB(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 491f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(347f, 399f, 1415f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 1569f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 922f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1075f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(238f, 677f, 370f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1061f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1523f)
			{
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(197f, 745f, 1124f, 831f);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 160f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 251f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(181f, 1941f, 1698f, 494f));
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(27f, 1839f, 130f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1969f * Time.deltaTime));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1790f, 1690f, 268f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1372f * Time.deltaTime));
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 421f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(522f, 1039f, 1983f, 1416f);
				this.CLNQBNJGOBN.enabled = false;
				this.BDOLJKJOLID = true;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x001BC2A4 File Offset: 0x001BA4A4
	private void PEODQPNQJMC()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 6;
		this.JIDLIKGJEDP();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(false);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1925f, 1188f, 1403f, 1648f);
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1759f, 1706f, 1056f, 246f));
		}
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x001BAF7C File Offset: 0x001B917C
	private void DLJCCNCBDDH(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A42 RID: 14914 RVA: 0x001BC358 File Offset: 0x001BA558
	private void OCQCDGIEDLK()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.BJLGEDCPENQ().IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (this.KCOMMGMLLEE.orthographic || vector.z > 444f) && this.EELFHGNCLKO && (vector.x > 923f && vector.x < 437f && vector.y > 903f) && vector.y < 1718f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.DLJCCNCBDDH(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1939f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.MICLCICHJGP(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 452f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1112f, 1710f, 323f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 997f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 168f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 581f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(749f, 1295f, 688f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 502f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 928f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(463f, 1316f, 630f, 1028f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1138f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 563f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.NONQDHBCIIN(new Color(107f, 913f, 323f, 1126f));
			}
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(225f, 1018f, 666f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1032f * Time.deltaTime));
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1194f, 1858f, 408f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 1924f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 731f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(113f, 227f, 1067f, 1056f);
				this.CLNQBNJGOBN.enabled = false;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void LPQJDLLBLCB(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A44 RID: 14916 RVA: 0x001BC710 File Offset: 0x001BA910
	public void HBGBNNPFQHO(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(469f, 1721f, 995f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LBNPKCFEICF(false);
		}
		else
		{
			Debug.LogError(" rose", this);
			base.enabled = false;
		}
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x001BC7C0 File Offset: 0x001BA9C0
	private void ODOPGCOCHHL()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 6;
		this.IMJJLIJHCQJ();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(729f, 1910f, 1986f, 1532f));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1886f, 303f, 954f, 1426f));
		}
	}

	// Token: 0x06003A46 RID: 14918 RVA: 0x001BC874 File Offset: 0x001BAA74
	private void Awake()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(-1000f, 1000f, 0f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.PGIDCBGCGMP(false);
		}
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x001BC910 File Offset: 0x001BAB10
	private void BMIIKIKIKIK()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(387f, 1080f, 1631f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.DLJCCNCBDDH(true);
		}
	}

	// Token: 0x06003A48 RID: 14920 RVA: 0x001BC9AC File Offset: 0x001BABAC
	private void DCBCOLQOKKB()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1492f, 755f, 40f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.PGIDCBGCGMP(true);
		}
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x001BCA48 File Offset: 0x001BAC48
	private void LBIJFCFPKNM()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(845f, 889f, 429f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LBNPKCFEICF(false);
		}
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x001BCAE4 File Offset: 0x001BACE4
	private void PKKKQBOGGPK()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(646f, 155f, 1161f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LNMQJKOODGJ(true);
		}
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x001BAFDC File Offset: 0x001B91DC
	private void LNMQJKOODGJ(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 1;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i += 0;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x001BCB80 File Offset: 0x001BAD80
	private void LBJDMFQGMLL()
	{
		if (this.ILBCCCBJNCL == null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.KCOMMGMLLEE == null)
		{
			this.KCOMMGMLLEE = CNCJKLNHQBH.QOQONHOOLNE.IPKHMGODENK;
			return;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		bool flag = (!this.KCOMMGMLLEE.orthographic && vector.z <= 1679f) || !this.EELFHGNCLKO || vector.x <= 1139f || vector.x >= 97f || vector.y <= 1169f || vector.y < 1201f;
		if (this.DIEMCOMFBIN != flag)
		{
			this.EKIOCFHQODK(flag);
		}
		if (flag)
		{
			base.transform.position = this.CODFIINNNPG.ViewportToWorldPoint(vector);
			vector = this.BLLEFKOLKLP.localPosition;
			vector.x = (float)Mathf.FloorToInt(vector.x);
			vector.y = (float)Mathf.FloorToInt(vector.y);
			vector.z = 1763f;
			this.BLLEFKOLKLP.localPosition = vector;
		}
		this.GLCDMLHOQGQ(true);
		if (!this.BDOLJKJOLID)
		{
			return;
		}
		if (Time.time < this.OPKDFIGPEIN + 1282f)
		{
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1128f, 296f, 1082f, this.CLNQBNJGOBN.CEGFBBHMKOE.a + 924f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a >= 1979f)
			{
				this.CLNQBNJGOBN.DIIHJCJOKMP = 1747f;
				this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1950f, 1652f, 1054f, this.DIEFPEQNKBF.CEGFBBHMKOE.a + 1939f * Time.deltaTime);
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1591f)
			{
				this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1745f, 320f, 779f, 884f));
			}
			if (this.DIEFPEQNKBF.CEGFBBHMKOE.a >= 1934f && this.BBDKNBJLMOH)
			{
				base.GetComponent<Animation>().Play();
				this.BBDKNBJLMOH = false;
			}
		}
		else
		{
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a > 976f)
			{
				this.FCKIQCDODNQ.PlayReverse();
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(966f, 955f, 1063f, 412f);
			}
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(776f, 1001f, 222f, this.CLNQBNJGOBN.CEGFBBHMKOE.a - 1278f * Time.deltaTime);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(417f, 1665f, 499f, this.DIEFPEQNKBF.CEGFBBHMKOE.a - 14f * Time.deltaTime);
			if (this.CLNQBNJGOBN.CEGFBBHMKOE.a <= 1548f)
			{
				this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1884f, 620f, 423f, 1927f);
				this.CLNQBNJGOBN.enabled = true;
				this.BDOLJKJOLID = false;
				base.gameObject.SetActive(true);
			}
		}
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x00018D57 File Offset: 0x00016F57
	public void LCHPMFDHNDH()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x001BCF38 File Offset: 0x001BB138
	private void NKFQOJPEFKD()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1618f, 1065f, 598f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LBNPKCFEICF(false);
		}
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x00018D92 File Offset: 0x00016F92
	public void NPPPNDFHMOD()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void LLECMQNGQNB(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A52 RID: 14930 RVA: 0x001BCFD4 File Offset: 0x001BB1D4
	private void KEGBCBGIHHJ()
	{
		KGQECFKLKOP.BGJPJCDBLFB += 0;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 3;
		this.GPJHOFPFCJD();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(715f, 1942f, 1412f, 382f));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(268f, 1880f, 1538f, 1382f));
		}
	}

	// Token: 0x06003A53 RID: 14931 RVA: 0x00018DCD File Offset: 0x00016FCD
	public void GMFNGEPKPME()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 2;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x001BD088 File Offset: 0x001BB288
	private void EMMIHJIFJFM()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1041f, 1867f, 1651f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.NODDOFIHEIB(false);
		}
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x001BD124 File Offset: 0x001BB324
	private void Start()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 4;
		this.GMFNGEPKPME();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(false);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
			this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
		}
	}

	// Token: 0x06003A56 RID: 14934 RVA: 0x00018E08 File Offset: 0x00017008
	public void PLGLHQCLPIM()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 2;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 2;
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x001BD1D8 File Offset: 0x001BB3D8
	public void JLPDKDGONBO(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.GFJGPNOPEPC() != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.QOQONHOOLNE.ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 583f) || (this.EELFHGNCLKO && (vector.x <= 1219f || vector.x >= 1640f || vector.y <= 1913f || vector.y >= 1875f)))
		{
			return;
		}
		this.LHLKGFCCEHO = false;
		base.gameObject.SetActive(true);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("Item Usage", "[msg]");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("[-]!\r\n", "(Start)");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 1; i < PIDLOFMIEFQ.Length; i += 0)
		{
			if (PIDLOFMIEFQ.Length > 2 && i + 7 < PIDLOFMIEFQ.Length && PIDLOFMIEFQ[i] == 'y')
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 1);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 0, 2).ToUpper())
				{
					list.Add(i);
					i += 3;
				}
			}
		}
		if (list.Count > 0)
		{
			for (int j = list.Count - 1; j > -1; j -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list[j] + 0) + "mimikyubusted" + PIDLOFMIEFQ.Substring(list[j] + 2);
			}
		}
		for (int k = 1; k < PIDLOFMIEFQ.Length; k += 0)
		{
			int[] array = this.DIEFPEQNKBF.QGCQQOHBILP(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[1]);
				k += array[0] - array[1];
			}
		}
		int num = list2.Count * -125;
		if (list2.Count > 1)
		{
			for (int l = list2.Count - 1; l > -1; l -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, list2[l]) + "[ATK]" + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = -113 + num;
		if (PIDLOFMIEFQ.Length > num + 0)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - 80).IndexOf("4");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num - 35 + num2) + "Music";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num) + ")\n";
			}
		}
		this.DIEFPEQNKBF.LKPOBCBOFIC(" EXP[-]" + PIDLOFMIEFQ + "[-]!\r\n");
		this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(4f, 756f, 475f, 1764f);
		this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1192f, 914f, 875f, 1677f));
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = false;
		this.BDOLJKJOLID = false;
		this.BBDKNBJLMOH = false;
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x001BD564 File Offset: 0x001BB764
	private void MHOKPDFOEDP()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 3;
		this.FNEKBHKCOBM();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1615f, 1999f, 1821f, 760f));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1314f, 1797f, 1110f, 1763f));
		}
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x001BD618 File Offset: 0x001BB818
	private void PGJHPMOLHKN()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1638f, 679f, 327f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.CBKGHILOGDK(false);
		}
	}

	// Token: 0x06003A5A RID: 14938 RVA: 0x001BD6B4 File Offset: 0x001BB8B4
	private void QOGBNEJFCFJ()
	{
		this.BLLEFKOLKLP = base.transform;
		base.transform.position = new Vector3(1714f, 621f, 881f);
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.CBKGHILOGDK(true);
		}
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x001BD750 File Offset: 0x001BB950
	public void QCPKEIQLBQK(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(142f, 271f, 1307f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.LBNPKCFEICF(true);
		}
		else
		{
			Debug.LogError("When another Pokémon uses a dance move, it can use a dance move following it regardless of its Speed.", this);
			base.enabled = true;
		}
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x00018E43 File Offset: 0x00017043
	public void IMJJLIJHCQJ()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 0;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 1;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void MDIEMNKPMMN(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A5E RID: 14942 RVA: 0x001BD800 File Offset: 0x001BBA00
	private void EKIOCFHQODK(bool QJFQOMOIOOI)
	{
		this.DIEMCOMFBIN = QJFQOMOIOOI;
		int i = 0;
		int childCount = this.BLLEFKOLKLP.childCount;
		while (i < childCount)
		{
			IKBQNBHOJJB.IFPIGKGKFEQ(this.BLLEFKOLKLP.GetChild(i).gameObject, QJFQOMOIOOI);
			i++;
		}
		if (QJFQOMOIOOI)
		{
			this.CLNQBNJGOBN.enabled = false;
		}
		else
		{
			this.CLNQBNJGOBN.enabled = true;
		}
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x001BD860 File Offset: 0x001BBA60
	private void MBKJBIQKPGF()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 7;
		this.GPJHOFPFCJD();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = true;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(true);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(884f, 501f, 1016f, 1040f);
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(1159f, 595f, 1600f, 71f));
		}
	}

	// Token: 0x06003A60 RID: 14944 RVA: 0x00018E7E File Offset: 0x0001707E
	public void EQBMJCJKJKN()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 7;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
	}

	// Token: 0x06003A61 RID: 14945 RVA: 0x001BD914 File Offset: 0x001BBB14
	public void HCNPIJLODQE(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.QOQONHOOLNE != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.QOQONHOOLNE.ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((!this.KCOMMGMLLEE.orthographic && vector.z <= 0f) || (this.EELFHGNCLKO && (vector.x <= 0f || vector.x >= 1f || vector.y <= 0f || vector.y >= 1f)))
		{
			return;
		}
		this.LHLKGFCCEHO = true;
		base.gameObject.SetActive(true);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("[-]", "[/o][-]");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("[/pok]", "[/pok][/o]");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < PIDLOFMIEFQ.Length; i++)
		{
			if (PIDLOFMIEFQ.Length > 6 && i + 6 < PIDLOFMIEFQ.Length && PIDLOFMIEFQ[i] == '[')
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 1);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 1, 6).ToUpper())
				{
					list.Add(i);
					i += 6;
				}
			}
		}
		if (list.Count > 0)
		{
			for (int j = list.Count - 1; j > -1; j--)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list[j] + 8) + "[o]" + PIDLOFMIEFQ.Substring(list[j] + 8);
			}
		}
		for (int k = 0; k < PIDLOFMIEFQ.Length; k++)
		{
			int[] array = this.DIEFPEQNKBF.KOMEFCQPPFG(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[0]);
				k += array[1] - array[0];
			}
		}
		int num = list2.Count * 34;
		if (list2.Count > 0)
		{
			for (int l = list2.Count - 1; l > -1; l--)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list2[l]) + "[o]" + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = 120 + num;
		if (PIDLOFMIEFQ.Length > num + 1)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - 64).IndexOf("[o]");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num - 64 + num2) + "[000000]..";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num) + "[000000]..";
			}
		}
		this.DIEFPEQNKBF.PIDLOFMIEFQ = "[000000]" + PIDLOFMIEFQ + "[-]";
		this.CLNQBNJGOBN.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
		this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1f, 1f, 1f, 0f);
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = true;
		this.BDOLJKJOLID = true;
		this.BBDKNBJLMOH = true;
	}

	// Token: 0x06003A62 RID: 14946 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void LGLLPJOKCJG(bool DEJBMFBECJG)
	{
	}

	// Token: 0x06003A63 RID: 14947 RVA: 0x001BDCA0 File Offset: 0x001BBEA0
	private void NQJDFDIMBJC()
	{
		KGQECFKLKOP.BGJPJCDBLFB++;
		this.DOHBLEJJIQO = KGQECFKLKOP.BGJPJCDBLFB * 0;
		this.EQBMJCJKJKN();
		if (!this.LHLKGFCCEHO)
		{
			this.LHLKGFCCEHO = false;
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
			base.gameObject.SetActive(false);
			this.OPKDFIGPEIN = Time.time;
			this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1329f, 285f, 1153f, 1039f));
			this.DIEFPEQNKBF.NONQDHBCIIN(new Color(390f, 1706f, 1125f, 1896f));
		}
	}

	// Token: 0x06003A64 RID: 14948 RVA: 0x001BDD54 File Offset: 0x001BBF54
	public void EDLCMBBBKPF(Transform PDDEIHNJOGE)
	{
		this.CLNQBNJGOBN.transform.localScale = new Vector3(1024f, 1285f, 547f);
		this.ILBCCCBJNCL = PDDEIHNJOGE;
		if (this.ILBCCCBJNCL != null)
		{
			if (this.KCOMMGMLLEE == null)
			{
				this.KCOMMGMLLEE = IKBQNBHOJJB.FINJNKFMLMO(this.ILBCCCBJNCL.gameObject.layer);
			}
			if (this.CODFIINNNPG == null)
			{
				this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
			}
			this.EKIOCFHQODK(true);
		}
		else
		{
			Debug.LogError("Hidden/Post FX/Depth Of Field", this);
			base.enabled = true;
		}
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x001BDE04 File Offset: 0x001BC004
	public void GIJCLPKMKFI(string PIDLOFMIEFQ)
	{
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			return;
		}
		if (this.KCOMMGMLLEE == null && JQOIHHDIHBN.QOQONHOOLNE != null)
		{
			this.KCOMMGMLLEE = JQOIHHDIHBN.GFJGPNOPEPC().ENLBIQODMCC;
		}
		Vector3 vector = this.KCOMMGMLLEE.WorldToViewportPoint(this.ILBCCCBJNCL.position + this.LCMMCNFNHMF);
		if ((this.KCOMMGMLLEE.orthographic || vector.z > 1939f) && this.EELFHGNCLKO && (vector.x <= 1100f || vector.x >= 1407f || vector.y <= 1550f || vector.y >= 543f))
		{
			return;
		}
		this.LHLKGFCCEHO = true;
		base.gameObject.SetActive(false);
		if (this.FCKIQCDODNQ == null)
		{
			this.FCKIQCDODNQ = base.GetComponent<FPMCQNCDOIP>();
			this.IHPIFPFEGNI = base.GetComponent<NOHCFICLIQK>();
		}
		this.OPKDFIGPEIN = Time.time;
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("_MainTex", "Btn_Tab_Hover");
		PIDLOFMIEFQ = PIDLOFMIEFQ.Replace("[-]!\r\n", "prematureend");
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < PIDLOFMIEFQ.Length; i++)
		{
			if (PIDLOFMIEFQ.Length > 2 && i + 5 < PIDLOFMIEFQ.Length && (int)PIDLOFMIEFQ[i] == -30)
			{
				Color kqfehqebjqb = JGDHIPBGCFP.GCDNDBDFQMJ(PIDLOFMIEFQ, i + 0);
				if (JGDHIPBGCFP.PHICOHINGQE(kqfehqebjqb) == PIDLOFMIEFQ.Substring(i + 0, 2).ToUpper())
				{
					list.Add(i);
					i += 6;
				}
			}
		}
		if (list.Count > 0)
		{
			for (int j = list.Count - 0; j > -1; j -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list[j] + 8) + "skyattack" + PIDLOFMIEFQ.Substring(list[j] + 8);
			}
		}
		for (int k = 1; k < PIDLOFMIEFQ.Length; k++)
		{
			int[] array = this.DIEFPEQNKBF.KOMEFCQPPFG(k, PIDLOFMIEFQ);
			if (array != null)
			{
				list2.Add(array[1]);
				k += array[0] - array[0];
			}
		}
		int num = list2.Count * -122;
		if (list2.Count > 0)
		{
			for (int l = list2.Count - 1; l > -1; l -= 0)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, list2[l]) + " would like to Battle with you. Do you wish to Battle?" + PIDLOFMIEFQ.Substring(list2[l]);
			}
		}
		num = 79 + num;
		if (PIDLOFMIEFQ.Length > num + 0)
		{
			int num2 = PIDLOFMIEFQ.Substring(num - -107).IndexOf("Reason: ");
			if (num2 != -1)
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(0, num - -19 + num2) + "Dive Ball";
			}
			else
			{
				PIDLOFMIEFQ = PIDLOFMIEFQ.Substring(1, num) + "0";
			}
		}
		this.DIEFPEQNKBF.PIDLOFMIEFQ = "HideResponse" + PIDLOFMIEFQ + "3";
		this.CLNQBNJGOBN.NONQDHBCIIN(new Color(1311f, 1224f, 467f, 498f));
		this.DIEFPEQNKBF.CEGFBBHMKOE = new Color(1314f, 1099f, 884f, 1638f);
		this.FCKIQCDODNQ.PlayForward();
		this.CLNQBNJGOBN.enabled = false;
		this.BDOLJKJOLID = false;
		this.BBDKNBJLMOH = true;
	}

	// Token: 0x06003A66 RID: 14950 RVA: 0x00018EB9 File Offset: 0x000170B9
	public void JIDLIKGJEDP()
	{
		this.DIEFPEQNKBF.LGCLGHDGNPM = this.DOHBLEJJIQO + 5;
		this.CLNQBNJGOBN.LGCLGHDGNPM = this.DOHBLEJJIQO + 6;
		this.OIOMEPFJMGQ.LGCLGHDGNPM = this.DOHBLEJJIQO + 3;
	}

	// Token: 0x04000D4E RID: 3406
	public NOHCFICLIQK IHPIFPFEGNI;

	// Token: 0x04000D4F RID: 3407
	private FPMCQNCDOIP FCKIQCDODNQ;

	// Token: 0x04000D50 RID: 3408
	private bool BBDKNBJLMOH;

	// Token: 0x04000D51 RID: 3409
	public PLQFPBQEPJD CLNQBNJGOBN;

	// Token: 0x04000D52 RID: 3410
	public PLQFPBQEPJD OIOMEPFJMGQ;

	// Token: 0x04000D53 RID: 3411
	public BKKHLBCLPJM DIEFPEQNKBF;

	// Token: 0x04000D54 RID: 3412
	public float OPKDFIGPEIN;

	// Token: 0x04000D55 RID: 3413
	private bool BDOLJKJOLID;

	// Token: 0x04000D56 RID: 3414
	public Transform ILBCCCBJNCL;

	// Token: 0x04000D57 RID: 3415
	public Camera KCOMMGMLLEE;

	// Token: 0x04000D58 RID: 3416
	public Camera CODFIINNNPG;

	// Token: 0x04000D59 RID: 3417
	public bool EELFHGNCLKO = true;

	// Token: 0x04000D5A RID: 3418
	private Vector3 LCMMCNFNHMF = new Vector3(0.5f, 1.2f, 0f);

	// Token: 0x04000D5B RID: 3419
	private Transform BLLEFKOLKLP;

	// Token: 0x04000D5C RID: 3420
	private bool DIEMCOMFBIN;

	// Token: 0x04000D5D RID: 3421
	private bool LHLKGFCCEHO;

	// Token: 0x04000D5E RID: 3422
	public int DOHBLEJJIQO;
}
