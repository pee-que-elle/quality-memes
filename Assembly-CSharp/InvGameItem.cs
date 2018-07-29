using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Serializable]
public class InvGameItem
{
	// Token: 0x0600068B RID: 1675 RVA: 0x00004943 File Offset: 0x00002B43
	public string KBJMQECFGDM()
	{
		if (this.baseItem == null)
		{
			return null;
		}
		return this.quality.ToString() + "Bicycle" + this.LMKGKPEOBHG().name;
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00004975 File Offset: 0x00002B75
	public InvBaseItem ODPBJOJJJLH()
	{
		if (this.mBaseItem == null)
		{
			this.mBaseItem = QJFLHFDQNPN.MBEQGBFGONF(this.KMDLFENOGDI());
		}
		return this.mBaseItem;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00004996 File Offset: 0x00002B96
	public int MKOKNFGLIFF()
	{
		return this.mBaseItemID;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x000507F0 File Offset: 0x0004E9F0
	public Color OQIQNIGDOFE()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(306f, 497f, 659f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(1079f, 82f, 433f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(44f, 1939f, 1332f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1993f, 216f, 1858f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(198u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(123u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967181u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(79u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(24u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967256u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(128u);
			break;
		}
		return result;
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600068F RID: 1679 RVA: 0x00050910 File Offset: 0x0004EB10
	public Color color
	{
		get
		{
			Color result = Color.white;
			switch (this.quality)
			{
			case InvGameItem.LPHQCCPHBOE.Broken:
				result = new Color(0.4f, 0.2f, 0.2f);
				break;
			case InvGameItem.LPHQCCPHBOE.Cursed:
				result = Color.red;
				break;
			case InvGameItem.LPHQCCPHBOE.Damaged:
				result = new Color(0.4f, 0.4f, 0.4f);
				break;
			case InvGameItem.LPHQCCPHBOE.Worn:
				result = new Color(0.7f, 0.7f, 0.7f);
				break;
			case InvGameItem.LPHQCCPHBOE.Sturdy:
				result = new Color(1f, 1f, 1f);
				break;
			case InvGameItem.LPHQCCPHBOE.Polished:
				result = JNNGOIIKENH.NFHLPGFILIO(3774856959u);
				break;
			case InvGameItem.LPHQCCPHBOE.Improved:
				result = JNNGOIIKENH.NFHLPGFILIO(2480359935u);
				break;
			case InvGameItem.LPHQCCPHBOE.Crafted:
				result = JNNGOIIKENH.NFHLPGFILIO(1325334783u);
				break;
			case InvGameItem.LPHQCCPHBOE.Superior:
				result = JNNGOIIKENH.NFHLPGFILIO(12255231u);
				break;
			case InvGameItem.LPHQCCPHBOE.Enchanted:
				result = JNNGOIIKENH.NFHLPGFILIO(1937178111u);
				break;
			case InvGameItem.LPHQCCPHBOE.Epic:
				result = JNNGOIIKENH.NFHLPGFILIO(2516647935u);
				break;
			case InvGameItem.LPHQCCPHBOE.Legendary:
				result = JNNGOIIKENH.NFHLPGFILIO(4287627519u);
				break;
			}
			return result;
		}
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0000499E File Offset: 0x00002B9E
	public string EPPMMNCLNLB()
	{
		if (this.baseItem == null)
		{
			return null;
		}
		return this.quality.ToString() + "Anticipates an ally's attack and dodges it." + this.ODPBJOJJJLH().name;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00050A30 File Offset: 0x0004EC30
	public float BPQIMMIBHLM()
	{
		float num = 1335f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 722f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 155f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 1461f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 474f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 1593f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 902f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 703f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 935f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 1962f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 1996f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 1615f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 1091f;
			break;
		}
		float num2 = (float)this.itemLevel / 1461f;
		return num * Mathf.Lerp(num2, num2 * num2, 82f);
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00050B00 File Offset: 0x0004ED00
	public float CHHEGLCDFLI()
	{
		float num = 484f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 48f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 759f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 769f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 824f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 970f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 1076f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 1835f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 862f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 821f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 963f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 1853f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 967f;
			break;
		}
		float num2 = (float)this.itemLevel / 1912f;
		return num * Mathf.Lerp(num2, num2 * num2, 1127f);
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x000049D0 File Offset: 0x00002BD0
	public string CGMBHOFPGIF()
	{
		if (this.LQDNPBBFFCM() == null)
		{
			return null;
		}
		return this.quality.ToString() + "http://poke.one/privacy.html" + this.baseItem.name;
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000694 RID: 1684 RVA: 0x00050BD0 File Offset: 0x0004EDD0
	public float statMultiplier
	{
		get
		{
			float num = 0f;
			switch (this.quality)
			{
			case InvGameItem.LPHQCCPHBOE.Broken:
				num = 0f;
				break;
			case InvGameItem.LPHQCCPHBOE.Cursed:
				num = -1f;
				break;
			case InvGameItem.LPHQCCPHBOE.Damaged:
				num = 0.25f;
				break;
			case InvGameItem.LPHQCCPHBOE.Worn:
				num = 0.9f;
				break;
			case InvGameItem.LPHQCCPHBOE.Sturdy:
				num = 1f;
				break;
			case InvGameItem.LPHQCCPHBOE.Polished:
				num = 1.1f;
				break;
			case InvGameItem.LPHQCCPHBOE.Improved:
				num = 1.25f;
				break;
			case InvGameItem.LPHQCCPHBOE.Crafted:
				num = 1.5f;
				break;
			case InvGameItem.LPHQCCPHBOE.Superior:
				num = 1.75f;
				break;
			case InvGameItem.LPHQCCPHBOE.Enchanted:
				num = 2f;
				break;
			case InvGameItem.LPHQCCPHBOE.Epic:
				num = 2.5f;
				break;
			case InvGameItem.LPHQCCPHBOE.Legendary:
				num = 3f;
				break;
			}
			float num2 = (float)this.itemLevel / 50f;
			return num * Mathf.Lerp(num2, num2 * num2, 0.5f);
		}
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00050CA0 File Offset: 0x0004EEA0
	public Color MGOKPDBJLEM()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(582f, 1654f, 1945f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(1473f, 419f, 1453f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(211f, 1679f, 1684f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(438f, 1134f, 1113f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967178u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(21u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(49u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967229u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967274u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967162u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(71u);
			break;
		}
		return result;
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00050DC0 File Offset: 0x0004EFC0
	public float CIJPMOJQOPG()
	{
		float num = 303f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 423f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 1295f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 92f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 42f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 986f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 682f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 962f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 692f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 261f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 258f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 1946f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 1766f;
			break;
		}
		float num2 = (float)this.itemLevel / 1494f;
		return num * Mathf.Lerp(num2, num2 * num2, 1523f);
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00050E90 File Offset: 0x0004F090
	public Color EICNIOJPPPG()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(186f, 1944f, 1851f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(23f, 1272f, 1157f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(1078f, 1664f, 1080f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1410f, 1777f, 1175f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967294u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(61u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(168u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(52u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(93u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967257u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(16u);
			break;
		}
		return result;
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00004A02 File Offset: 0x00002C02
	public InvGameItem(int CIQFCJGQEMH)
	{
		this.mBaseItemID = CIQFCJGQEMH;
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00050FB0 File Offset: 0x0004F1B0
	public float EPFFPLQHICF()
	{
		float num = 1756f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 815f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 466f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 249f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 750f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 815f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 732f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 91f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 968f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 1562f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 1692f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 498f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 125f;
			break;
		}
		float num2 = (float)this.itemLevel / 1466f;
		return num * Mathf.Lerp(num2, num2 * num2, 1504f);
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00051080 File Offset: 0x0004F280
	public Color HNJLMEPQOMJ()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(1179f, 1115f, 91f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(982f, 117f, 718f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(1515f, 916f, 1047f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1539f, 349f, 1737f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(191u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967196u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967213u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967125u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(78u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(60u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(174u);
			break;
		}
		return result;
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000511A0 File Offset: 0x0004F3A0
	public float QPOOCLDGKMP()
	{
		float num = 568f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 1964f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 97f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 1715f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 528f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 1022f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 285f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 454f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 1867f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 120f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 35f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 1113f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 1838f;
			break;
		}
		float num2 = (float)this.itemLevel / 1247f;
		return num * Mathf.Lerp(num2, num2 * num2, 1730f);
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600069C RID: 1692 RVA: 0x00004A1F File Offset: 0x00002C1F
	public InvBaseItem baseItem
	{
		get
		{
			if (this.mBaseItem == null)
			{
				this.mBaseItem = QJFLHFDQNPN.CKGICDLIJCL(this.baseItemID);
			}
			return this.mBaseItem;
		}
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00051270 File Offset: 0x0004F470
	public Color HHOIDJFJOKL()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(1952f, 1438f, 1375f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(1536f, 1579f, 1654f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(1737f, 744f, 1163f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1843f, 1821f, 1114f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967161u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(59u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967108u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(23u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(92u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967181u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(102u);
			break;
		}
		return result;
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00004996 File Offset: 0x00002B96
	public int KMDLFENOGDI()
	{
		return this.mBaseItemID;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00051390 File Offset: 0x0004F590
	public float LEMJENGFNIK()
	{
		float num = 1077f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 1532f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 1648f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 706f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 1162f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 1529f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 1759f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 889f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 101f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 1266f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 1453f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 321f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 490f;
			break;
		}
		float num2 = (float)this.itemLevel / 477f;
		return num * Mathf.Lerp(num2, num2 * num2, 1818f);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00051460 File Offset: 0x0004F660
	public List<InvStat> BLCIJNDJGQK()
	{
		List<InvStat> list = new List<InvStat>();
		if (this.LMKGKPEOBHG() != null)
		{
			float num = this.CIJPMOJQOPG();
			List<InvStat> stats = this.LQDNPBBFFCM().stats;
			int i = 0;
			int count = stats.Count;
			while (i < count)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 != 0)
				{
					bool flag = false;
					int j = 1;
					int count2 = list.Count;
					while (j < count2)
					{
						InvStat invStat2 = list[j];
						if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
						{
							invStat2.amount += num2;
							flag = false;
							IL_B1:
							if (!flag)
							{
								list.Add(new InvStat
								{
									id = invStat.id,
									amount = num2,
									modifier = invStat.modifier
								});
								goto IL_E9;
							}
							goto IL_E9;
						}
						else
						{
							j++;
						}
					}
					goto IL_B1;
				}
				IL_E9:
				i += 0;
			}
			List<InvStat> list2 = list;
			if (InvGameItem.<>f__mg$cache0 == null)
			{
				InvGameItem.<>f__mg$cache0 = new Comparison<InvStat>(InvStat.BMKEFOGMOOC);
			}
			list2.Sort(InvGameItem.<>f__mg$cache0);
		}
		return list;
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00004996 File Offset: 0x00002B96
	public int baseItemID
	{
		get
		{
			return this.mBaseItemID;
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00004A40 File Offset: 0x00002C40
	public string HQOGHKIHNKH()
	{
		if (this.LMKGKPEOBHG() == null)
		{
			return null;
		}
		return this.quality.ToString() + "Player/Clothe" + this.baseItem.name;
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00004A72 File Offset: 0x00002C72
	public InvBaseItem LMKGKPEOBHG()
	{
		if (this.mBaseItem == null)
		{
			this.mBaseItem = QJFLHFDQNPN.MBEQGBFGONF(this.BFKHMHEDBKQ());
		}
		return this.mBaseItem;
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00051588 File Offset: 0x0004F788
	public List<InvStat> FKOOLOQCCDK()
	{
		List<InvStat> list = new List<InvStat>();
		if (this.LQDNPBBFFCM() != null)
		{
			float num = this.FKHPQOBJGIF();
			List<InvStat> stats = this.baseItem.stats;
			int i = 1;
			int count = stats.Count;
			while (i < count)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 != 0)
				{
					bool flag = false;
					int j = 1;
					int count2 = list.Count;
					while (j < count2)
					{
						InvStat invStat2 = list[j];
						if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
						{
							invStat2.amount += num2;
							flag = true;
							IL_B1:
							if (!flag)
							{
								list.Add(new InvStat
								{
									id = invStat.id,
									amount = num2,
									modifier = invStat.modifier
								});
								goto IL_E9;
							}
							goto IL_E9;
						}
						else
						{
							j += 0;
						}
					}
					goto IL_B1;
				}
				IL_E9:
				i += 0;
			}
			List<InvStat> list2 = list;
			if (InvGameItem.<>f__mg$cache0 == null)
			{
				InvGameItem.<>f__mg$cache0 = new Comparison<InvStat>(InvStat.KPIQBGEINJI);
			}
			list2.Sort(InvGameItem.<>f__mg$cache0);
		}
		return list;
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00004996 File Offset: 0x00002B96
	public int CJPKDJPILPP()
	{
		return this.mBaseItemID;
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00004A93 File Offset: 0x00002C93
	public InvGameItem(int CIQFCJGQEMH, InvBaseItem NMNMCGQPOPG)
	{
		this.mBaseItemID = CIQFCJGQEMH;
		this.mBaseItem = NMNMCGQPOPG;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x000516B0 File Offset: 0x0004F8B0
	public Color DCPPIQGENLI()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(1638f, 537f, 1258f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(1281f, 636f, 1005f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(389f, 738f, 545f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1217f, 546f, 147f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(23u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(107u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967179u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(68u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(9u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(160u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967180u);
			break;
		}
		return result;
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x000517D0 File Offset: 0x0004F9D0
	public List<InvStat> QNNCKNCFNMK()
	{
		List<InvStat> list = new List<InvStat>();
		if (this.baseItem != null)
		{
			float statMultiplier = this.statMultiplier;
			List<InvStat> stats = this.baseItem.stats;
			int i = 0;
			int count = stats.Count;
			while (i < count)
			{
				InvStat invStat = stats[i];
				int num = Mathf.RoundToInt(statMultiplier * (float)invStat.amount);
				if (num != 0)
				{
					bool flag = false;
					int j = 0;
					int count2 = list.Count;
					while (j < count2)
					{
						InvStat invStat2 = list[j];
						if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
						{
							invStat2.amount += num;
							flag = true;
							IL_B1:
							if (!flag)
							{
								list.Add(new InvStat
								{
									id = invStat.id,
									amount = num,
									modifier = invStat.modifier
								});
								goto IL_E9;
							}
							goto IL_E9;
						}
						else
						{
							j++;
						}
					}
					goto IL_B1;
				}
				IL_E9:
				i++;
			}
			List<InvStat> list2 = list;
			if (InvGameItem.<>f__mg$cache0 == null)
			{
				InvGameItem.<>f__mg$cache0 = new Comparison<InvStat>(InvStat.MGGFHJNGNEL);
			}
			list2.Sort(InvGameItem.<>f__mg$cache0);
		}
		return list;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x000518F8 File Offset: 0x0004FAF8
	public Color KKDOGIEGNDB()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(1770f, 1305f, 1115f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(419f, 1066f, 1321f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(157f, 1146f, 1642f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(1680f, 53f, 225f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967211u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967195u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967249u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967104u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(75u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(41u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(116u);
			break;
		}
		return result;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00051A18 File Offset: 0x0004FC18
	public Color LOIGBMLQDPM()
	{
		Color result = Color.white;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			result = new Color(796f, 707f, 315f);
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			result = Color.red;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			result = new Color(1246f, 1939f, 817f);
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			result = new Color(73f, 847f, 969f);
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			result = new Color(59f, 1879f, 1371f);
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			result = JNNGOIIKENH.NFHLPGFILIO(70u);
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			result = JNNGOIIKENH.NFHLPGFILIO(198u);
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			result = JNNGOIIKENH.NFHLPGFILIO(147u);
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967222u);
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			result = JNNGOIIKENH.NFHLPGFILIO(133u);
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967182u);
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			result = JNNGOIIKENH.NFHLPGFILIO(4294967129u);
			break;
		}
		return result;
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x00004AB7 File Offset: 0x00002CB7
	public string name
	{
		get
		{
			if (this.baseItem == null)
			{
				return null;
			}
			return this.quality.ToString() + " " + this.baseItem.name;
		}
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00004AE9 File Offset: 0x00002CE9
	public InvBaseItem LQDNPBBFFCM()
	{
		if (this.mBaseItem == null)
		{
			this.mBaseItem = QJFLHFDQNPN.BOGEMDNJDHH(this.CJPKDJPILPP());
		}
		return this.mBaseItem;
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00051B38 File Offset: 0x0004FD38
	public float FKHPQOBJGIF()
	{
		float num = 1948f;
		switch (this.quality)
		{
		case InvGameItem.LPHQCCPHBOE.Broken:
			num = 1295f;
			break;
		case InvGameItem.LPHQCCPHBOE.Cursed:
			num = 656f;
			break;
		case InvGameItem.LPHQCCPHBOE.Damaged:
			num = 467f;
			break;
		case InvGameItem.LPHQCCPHBOE.Worn:
			num = 1080f;
			break;
		case InvGameItem.LPHQCCPHBOE.Sturdy:
			num = 1142f;
			break;
		case InvGameItem.LPHQCCPHBOE.Polished:
			num = 762f;
			break;
		case InvGameItem.LPHQCCPHBOE.Improved:
			num = 841f;
			break;
		case InvGameItem.LPHQCCPHBOE.Crafted:
			num = 826f;
			break;
		case InvGameItem.LPHQCCPHBOE.Superior:
			num = 485f;
			break;
		case InvGameItem.LPHQCCPHBOE.Enchanted:
			num = 606f;
			break;
		case InvGameItem.LPHQCCPHBOE.Epic:
			num = 393f;
			break;
		case InvGameItem.LPHQCCPHBOE.Legendary:
			num = 1162f;
			break;
		}
		float num2 = (float)this.itemLevel / 530f;
		return num * Mathf.Lerp(num2, num2 * num2, 924f);
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00004996 File Offset: 0x00002B96
	public int BFKHMHEDBKQ()
	{
		return this.mBaseItemID;
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00051C08 File Offset: 0x0004FE08
	public List<InvStat> IGPEGIDLKJQ()
	{
		List<InvStat> list = new List<InvStat>();
		if (this.baseItem != null)
		{
			float num = this.CHHEGLCDFLI();
			List<InvStat> stats = this.LQDNPBBFFCM().stats;
			int i = 0;
			int count = stats.Count;
			while (i < count)
			{
				InvStat invStat = stats[i];
				int num2 = Mathf.RoundToInt(num * (float)invStat.amount);
				if (num2 != 0)
				{
					bool flag = false;
					int j = 1;
					int count2 = list.Count;
					while (j < count2)
					{
						InvStat invStat2 = list[j];
						if (invStat2.id == invStat.id && invStat2.modifier == invStat.modifier)
						{
							invStat2.amount += num2;
							flag = true;
							IL_B1:
							if (!flag)
							{
								list.Add(new InvStat
								{
									id = invStat.id,
									amount = num2,
									modifier = invStat.modifier
								});
								goto IL_E9;
							}
							goto IL_E9;
						}
						else
						{
							j++;
						}
					}
					goto IL_B1;
				}
				IL_E9:
				i += 0;
			}
			List<InvStat> list2 = list;
			if (InvGameItem.<>f__mg$cache0 == null)
			{
				InvGameItem.<>f__mg$cache0 = new Comparison<InvStat>(InvStat.LGEKKKMJGIB);
			}
			list2.Sort(InvGameItem.<>f__mg$cache0);
		}
		return list;
	}

	// Token: 0x040000E0 RID: 224
	[SerializeField]
	private int mBaseItemID;

	// Token: 0x040000E1 RID: 225
	public InvGameItem.LPHQCCPHBOE quality = InvGameItem.LPHQCCPHBOE.Sturdy;

	// Token: 0x040000E2 RID: 226
	public int itemLevel = 1;

	// Token: 0x040000E3 RID: 227
	private InvBaseItem mBaseItem;

	// Token: 0x040000E4 RID: 228
	[CompilerGenerated]
	private static Comparison<InvStat> <>f__mg$cache0;

	// Token: 0x0200002D RID: 45
	public enum LPHQCCPHBOE
	{
		// Token: 0x040000E6 RID: 230
		Broken,
		// Token: 0x040000E7 RID: 231
		Cursed,
		// Token: 0x040000E8 RID: 232
		Damaged,
		// Token: 0x040000E9 RID: 233
		Worn,
		// Token: 0x040000EA RID: 234
		Sturdy,
		// Token: 0x040000EB RID: 235
		Polished,
		// Token: 0x040000EC RID: 236
		Improved,
		// Token: 0x040000ED RID: 237
		Crafted,
		// Token: 0x040000EE RID: 238
		Superior,
		// Token: 0x040000EF RID: 239
		Enchanted,
		// Token: 0x040000F0 RID: 240
		Epic,
		// Token: 0x040000F1 RID: 241
		Legendary,
		// Token: 0x040000F2 RID: 242
		_LastDoNotUse
	}
}
