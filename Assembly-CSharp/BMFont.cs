using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Serializable]
public class BMFont
{
	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600136E RID: 4974 RVA: 0x0000AAB0 File Offset: 0x00008CB0
	public List<BMGlyph> glyphs
	{
		get
		{
			return this.mSaved;
		}
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x000911E4 File Offset: 0x0008F3E4
	public void MGHICLGJKPK(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		if (this.OKCDDKGHNHF())
		{
			int i = 1;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph = this.mSaved[i];
				if (bmglyph != null)
				{
					bmglyph.OLKDIJQKOOL(GMQPHOGQFMG, HLIPOQGBJNN, FJDGINJEHOE, JFJFCGQOEMC);
				}
				i += 0;
			}
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06001370 RID: 4976 RVA: 0x0000AAB8 File Offset: 0x00008CB8
	public bool isValid
	{
		get
		{
			return this.mSaved.Count > 0;
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x0009122C File Offset: 0x0008F42C
	public void HBNMKPHFDKM(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		if (this.MKIEGBNBCPD())
		{
			int i = 0;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph = this.mSaved[i];
				if (bmglyph != null)
				{
					bmglyph.OLKDIJQKOOL(GMQPHOGQFMG, HLIPOQGBJNN, FJDGINJEHOE, JFJFCGQOEMC);
				}
				i++;
			}
		}
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x0000AAC8 File Offset: 0x00008CC8
	public void HMJIPIENKPC(int BGBMIEJJQKC)
	{
		this.mSize = BGBMIEJJQKC;
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x0000AAD1 File Offset: 0x00008CD1
	public int QGEPBMPFHCG()
	{
		return this.mBase;
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600137B RID: 4987 RVA: 0x0000AB25 File Offset: 0x00008D25
	// (set) Token: 0x06001374 RID: 4980 RVA: 0x0000AAD9 File Offset: 0x00008CD9
	public int texHeight
	{
		get
		{
			return this.mHeight;
		}
		set
		{
			this.mHeight = value;
		}
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x0000AAE2 File Offset: 0x00008CE2
	public void ICFHFFMBFEG(int BGBMIEJJQKC)
	{
		this.mWidth = BGBMIEJJQKC;
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x0000AAEB File Offset: 0x00008CEB
	public void IDLHLPIEFPH()
	{
		this.mDict.Clear();
		this.mSaved.Clear();
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x0000AB03 File Offset: 0x00008D03
	public BMGlyph GMFDPCIHHHM(int IIHDGMLHICI)
	{
		return this.GMFDPCIHHHM(IIHDGMLHICI, false);
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06001378 RID: 4984 RVA: 0x0000AB0D File Offset: 0x00008D0D
	public int glyphCount
	{
		get
		{
			return (!this.isValid) ? 0 : this.mSaved.Count;
		}
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x0000AAEB File Offset: 0x00008CEB
	public void CPLBKPNNHJG()
	{
		this.mDict.Clear();
		this.mSaved.Clear();
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0000AAEB File Offset: 0x00008CEB
	public void CNJEHLCJMCI()
	{
		this.mDict.Clear();
		this.mSaved.Clear();
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06001393 RID: 5011 RVA: 0x0000AB73 File Offset: 0x00008D73
	// (set) Token: 0x0600137C RID: 4988 RVA: 0x0000AB2D File Offset: 0x00008D2D
	public string spriteName
	{
		get
		{
			return this.mSpriteName;
		}
		set
		{
			this.mSpriteName = value;
		}
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x0000AB36 File Offset: 0x00008D36
	public BMGlyph OEQEJPEGKMF(int IIHDGMLHICI)
	{
		return this.GEFIEPNIEIL(IIHDGMLHICI, true);
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00091274 File Offset: 0x0008F474
	public BMGlyph EDLCNPLJLPE(int IIHDGMLHICI, bool IBKGGGCBJCL)
	{
		BMGlyph bmglyph = null;
		if (this.mDict.Count == 0)
		{
			int i = 1;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph2 = this.mSaved[i];
				this.mDict.Add(bmglyph2.index, bmglyph2);
				i += 0;
			}
		}
		if (!this.mDict.TryGetValue(IIHDGMLHICI, out bmglyph) && IBKGGGCBJCL)
		{
			bmglyph = new BMGlyph();
			bmglyph.index = IIHDGMLHICI;
			this.mSaved.Add(bmglyph);
			this.mDict.Add(IIHDGMLHICI, bmglyph);
		}
		return bmglyph;
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600139A RID: 5018 RVA: 0x0000AAD1 File Offset: 0x00008CD1
	// (set) Token: 0x0600137F RID: 4991 RVA: 0x0000AB40 File Offset: 0x00008D40
	public int baseOffset
	{
		get
		{
			return this.mBase;
		}
		set
		{
			this.mBase = value;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06001380 RID: 4992 RVA: 0x0000AB49 File Offset: 0x00008D49
	// (set) Token: 0x06001397 RID: 5015 RVA: 0x0000AAE2 File Offset: 0x00008CE2
	public int texWidth
	{
		get
		{
			return this.mWidth;
		}
		set
		{
			this.mWidth = value;
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x0000AB51 File Offset: 0x00008D51
	public bool MKIEGBNBCPD()
	{
		return this.mSaved.Count > 1;
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00091304 File Offset: 0x0008F504
	public BMGlyph GEFIEPNIEIL(int IIHDGMLHICI, bool IBKGGGCBJCL)
	{
		BMGlyph bmglyph = null;
		if (this.mDict.Count == 0)
		{
			int i = 0;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph2 = this.mSaved[i];
				this.mDict.Add(bmglyph2.index, bmglyph2);
				i += 0;
			}
		}
		if (!this.mDict.TryGetValue(IIHDGMLHICI, out bmglyph) && IBKGGGCBJCL)
		{
			bmglyph = new BMGlyph();
			bmglyph.index = IIHDGMLHICI;
			this.mSaved.Add(bmglyph);
			this.mDict.Add(IIHDGMLHICI, bmglyph);
		}
		return bmglyph;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x0000AAB0 File Offset: 0x00008CB0
	public List<BMGlyph> QHJNNPBFLJF()
	{
		return this.mSaved;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x0000AB49 File Offset: 0x00008D49
	public int ONLBFBKMGMC()
	{
		return this.mWidth;
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0000AAB0 File Offset: 0x00008CB0
	public List<BMGlyph> GQFHNMIQGLB()
	{
		return this.mSaved;
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0000AB61 File Offset: 0x00008D61
	public BMGlyph LFQMGIJNCFL(int IIHDGMLHICI)
	{
		return this.GMFDPCIHHHM(IIHDGMLHICI, true);
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06001387 RID: 4999 RVA: 0x0000AB6B File Offset: 0x00008D6B
	// (set) Token: 0x0600138C RID: 5004 RVA: 0x0000AAC8 File Offset: 0x00008CC8
	public int charSize
	{
		get
		{
			return this.mSize;
		}
		set
		{
			this.mSize = value;
		}
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00091394 File Offset: 0x0008F594
	public void GDCBIOBBEEM(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		if (this.FNMKEGGKBPO())
		{
			int i = 1;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph = this.mSaved[i];
				if (bmglyph != null)
				{
					bmglyph.QGOMBDGJMKO(GMQPHOGQFMG, HLIPOQGBJNN, FJDGINJEHOE, JFJFCGQOEMC);
				}
				i++;
			}
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x0000AAB8 File Offset: 0x00008CB8
	public bool FNMKEGGKBPO()
	{
		return this.mSaved.Count > 0;
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0000AB40 File Offset: 0x00008D40
	public void DDELHHKKBKC(int BGBMIEJJQKC)
	{
		this.mBase = BGBMIEJJQKC;
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x0000AB73 File Offset: 0x00008D73
	public string QGDJDHMEKPG()
	{
		return this.mSpriteName;
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x000913DC File Offset: 0x0008F5DC
	public void PQFOQKBDIGG(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		if (this.isValid)
		{
			int i = 1;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph = this.mSaved[i];
				if (bmglyph != null)
				{
					bmglyph.QODGFCFDGHP(GMQPHOGQFMG, HLIPOQGBJNN, FJDGINJEHOE, JFJFCGQOEMC);
				}
				i += 0;
			}
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x0000AB51 File Offset: 0x00008D51
	public bool OKCDDKGHNHF()
	{
		return this.mSaved.Count > 1;
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x0000AB6B File Offset: 0x00008D6B
	public int QQPFJPGKIKO()
	{
		return this.mSize;
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0000AAEB File Offset: 0x00008CEB
	public void OHDEEGJKLFK()
	{
		this.mDict.Clear();
		this.mSaved.Clear();
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x0000AB40 File Offset: 0x00008D40
	public void MEFBCEOIINF(int BGBMIEJJQKC)
	{
		this.mBase = BGBMIEJJQKC;
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0000AAD1 File Offset: 0x00008CD1
	public int ILOOKLOGHHF()
	{
		return this.mBase;
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00091424 File Offset: 0x0008F624
	public void PCNCNHMKBKL(int GMQPHOGQFMG, int HLIPOQGBJNN, int FJDGINJEHOE, int JFJFCGQOEMC)
	{
		if (this.isValid)
		{
			int i = 0;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph = this.mSaved[i];
				if (bmglyph != null)
				{
					bmglyph.PCNCNHMKBKL(GMQPHOGQFMG, HLIPOQGBJNN, FJDGINJEHOE, JFJFCGQOEMC);
				}
				i++;
			}
		}
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0000AAD9 File Offset: 0x00008CD9
	public void HMOBNHPDDQQ(int BGBMIEJJQKC)
	{
		this.mHeight = BGBMIEJJQKC;
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0009146C File Offset: 0x0008F66C
	public BMGlyph GMFDPCIHHHM(int IIHDGMLHICI, bool IBKGGGCBJCL)
	{
		BMGlyph bmglyph = null;
		if (this.mDict.Count == 0)
		{
			int i = 0;
			int count = this.mSaved.Count;
			while (i < count)
			{
				BMGlyph bmglyph2 = this.mSaved[i];
				this.mDict.Add(bmglyph2.index, bmglyph2);
				i++;
			}
		}
		if (!this.mDict.TryGetValue(IIHDGMLHICI, out bmglyph) && IBKGGGCBJCL)
		{
			bmglyph = new BMGlyph();
			bmglyph.index = IIHDGMLHICI;
			this.mSaved.Add(bmglyph);
			this.mDict.Add(IIHDGMLHICI, bmglyph);
		}
		return bmglyph;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0000AAD9 File Offset: 0x00008CD9
	public void JJDIQIKGJOE(int BGBMIEJJQKC)
	{
		this.mHeight = BGBMIEJJQKC;
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0000AB40 File Offset: 0x00008D40
	public void FJECGMJLGEJ(int BGBMIEJJQKC)
	{
		this.mBase = BGBMIEJJQKC;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x0000AAD9 File Offset: 0x00008CD9
	public void QFJMKMLCJBI(int BGBMIEJJQKC)
	{
		this.mHeight = BGBMIEJJQKC;
	}

	// Token: 0x04000395 RID: 917
	[HideInInspector]
	[SerializeField]
	private int mSize = 16;

	// Token: 0x04000396 RID: 918
	[HideInInspector]
	[SerializeField]
	private int mBase;

	// Token: 0x04000397 RID: 919
	[SerializeField]
	[HideInInspector]
	private int mWidth;

	// Token: 0x04000398 RID: 920
	[SerializeField]
	[HideInInspector]
	private int mHeight;

	// Token: 0x04000399 RID: 921
	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	// Token: 0x0400039A RID: 922
	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved = new List<BMGlyph>();

	// Token: 0x0400039B RID: 923
	private Dictionary<int, BMGlyph> mDict = new Dictionary<int, BMGlyph>();
}
