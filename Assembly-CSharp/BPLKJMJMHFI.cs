using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000EA RID: 234
[AddComponentMenu("NGUI/UI/Atlas")]
public class BPLKJMJMHFI : MonoBehaviour
{
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0000F254 File Offset: 0x0000D454
	// (set) Token: 0x06001C3A RID: 7226 RVA: 0x000BB004 File Offset: 0x000B9204
	public BPLKJMJMHFI QKQJDJKILGD
	{
		get
		{
			return this.mReplacement;
		}
		set
		{
			BPLKJMJMHFI bplkjmjmhfi = value;
			if (bplkjmjmhfi == this)
			{
				bplkjmjmhfi = null;
			}
			if (this.mReplacement != bplkjmjmhfi)
			{
				if (bplkjmjmhfi != null && bplkjmjmhfi.QKQJDJKILGD == this)
				{
					bplkjmjmhfi.QKQJDJKILGD = null;
				}
				if (this.mReplacement != null)
				{
					this.NPCECPIOPCB();
				}
				this.mReplacement = bplkjmjmhfi;
				if (bplkjmjmhfi != null)
				{
					this.material = null;
				}
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x000BB07C File Offset: 0x000B927C
	public MHIDKMCBQEN<string> PFNIBFJENMO(string CHCHGIGIMQO)
	{
		if (this.mReplacement)
		{
			return this.mReplacement.LCCFCGEIPLI(CHCHGIGIMQO);
		}
		if (string.IsNullOrEmpty(CHCHGIGIMQO))
		{
			return this.ODJQNQOGNFN();
		}
		if (this.mSprites.Count == 0)
		{
			this.DHPHOMBNCLK();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name) && string.Equals(CHCHGIGIMQO, uispriteData.name, (StringComparison)8))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
				return mhidkmcbqen;
			}
			i++;
		}
		char[] array = new char[0];
		array[1] = '|';
		string[] array2 = CHCHGIGIMQO.Split(array, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j] = array2[j].ToLower();
		}
		int k = 1;
		int count2 = this.mSprites.Count;
		while (k < count2)
		{
			UISpriteData uispriteData2 = this.mSprites[k];
			if (uispriteData2 != null && !string.IsNullOrEmpty(uispriteData2.name))
			{
				string text = uispriteData2.name.ToLower();
				int num = 0;
				for (int l = 0; l < array2.Length; l++)
				{
					if (text.Contains(array2[l]))
					{
						num++;
					}
				}
				if (num == array2.Length)
				{
					mhidkmcbqen.LHQECHHMOGD(uispriteData2.name);
				}
			}
			k++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000BB1E4 File Offset: 0x000B93E4
	public bool KKGEBNMDHLN
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.KKGEBNMDHLN;
			}
			if (this.DHCCBPDMIBQ == -1)
			{
				Material mpgcgdbechm = this.MPGCGDBECHM;
				this.DHCCBPDMIBQ = ((!(mpgcgdbechm != null) || !(mpgcgdbechm.shader != null) || !mpgcgdbechm.shader.name.Contains("Premultiplied")) ? 0 : 1);
			}
			return this.DHCCBPDMIBQ == 1;
		}
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x0000F241 File Offset: 0x0000D441
	[CompilerGenerated]
	private static int BLQJGPKOIHQ(UISpriteData QQOBBCPLJLH, UISpriteData PKNPDBIFHFB)
	{
		return QQOBBCPLJLH.name.CompareTo(PKNPDBIFHFB.name);
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x000BB25C File Offset: 0x000B945C
	public bool JBKFNQHLLGK()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.JBKFNQHLLGK();
		}
		if (this.DHCCBPDMIBQ == -1)
		{
			Material material = this.EBFDQJPCIMF();
			this.DHCCBPDMIBQ = ((!(material != null) || !(material.shader != null) || !material.shader.name.Contains("_FogHeightData")) ? 1 : 1);
		}
		return this.DHCCBPDMIBQ == 1;
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x0000F254 File Offset: 0x0000D454
	public BPLKJMJMHFI DODLQQCKBGM()
	{
		return this.mReplacement;
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x0000F241 File Offset: 0x0000D441
	private static int GKNBIKIPJLN(UISpriteData QQOBBCPLJLH, UISpriteData PKNPDBIFHFB)
	{
		return QQOBBCPLJLH.name.CompareTo(PKNPDBIFHFB.name);
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x000BB2D4 File Offset: 0x000B94D4
	public bool DLBIDCKFOMQ()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.GNIDMKFNLBL();
		}
		if (this.DHCCBPDMIBQ == -1)
		{
			Material mpgcgdbechm = this.MPGCGDBECHM;
			this.DHCCBPDMIBQ = ((!(mpgcgdbechm != null) || !(mpgcgdbechm.shader != null) || !mpgcgdbechm.shader.name.Contains("Guild Success")) ? 1 : 0);
		}
		return this.DHCCBPDMIBQ == 1;
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x000BB34C File Offset: 0x000B954C
	private bool CDPMFKDGJKF()
	{
		if (this.mReplacement)
		{
			return this.mReplacement.HMJNLLFQELK();
		}
		if (this.mSprites.Count == 0 && this.sprites.Count > 0 && this.material)
		{
			Texture mainTexture = this.material.mainTexture;
			int kjgmgpcejjd = (!(mainTexture != null)) ? 74 : mainTexture.width;
			int dfkqmmiqdoo = (!(mainTexture != null)) ? 48 : mainTexture.height;
			for (int i = 0; i < this.sprites.Count; i++)
			{
				BPLKJMJMHFI.Sprite sprite = this.sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (this.mCoordinates == BPLKJMJMHFI.MGHKQFLKOLB.TexCoords)
				{
					JNNGOIIKENH.JGKFJCNNBBE(outer, kjgmgpcejjd, dfkqmmiqdoo, true);
					JNNGOIIKENH.JGKFJCNNBBE(inner, kjgmgpcejjd, dfkqmmiqdoo, true);
				}
				UISpriteData uispriteData = new UISpriteData();
				uispriteData.name = sprite.name;
				uispriteData.x = Mathf.RoundToInt(outer.xMin);
				uispriteData.y = Mathf.RoundToInt(outer.yMin);
				uispriteData.width = Mathf.RoundToInt(outer.width);
				uispriteData.height = Mathf.RoundToInt(outer.height);
				uispriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uispriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uispriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uispriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uispriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uispriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uispriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uispriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				this.mSprites.Add(uispriteData);
			}
			this.sprites.Clear();
			return true;
		}
		return false;
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x000BB58C File Offset: 0x000B978C
	public string EEJMLCGLLQC(string NQGDFBBQKNJ)
	{
		if (this.KPQNNOJJKDO(NQGDFBBQKNJ) == null)
		{
			List<UISpriteData> ildjpqcfifh = this.ILDJPQCFIFH;
			List<string> list = new List<string>();
			foreach (UISpriteData uispriteData in ildjpqcfifh)
			{
				if (uispriteData.name.StartsWith(NQGDFBBQKNJ))
				{
					list.Add(uispriteData.name);
				}
			}
			return (list.Count <= 1) ? null : list[UnityEngine.Random.Range(1, list.Count)];
		}
		return NQGDFBBQKNJ;
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x000BB624 File Offset: 0x000B9824
	public MHIDKMCBQEN<string> BEJMDHIFHOD()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.HDOEKELLDGK();
		}
		if (this.mSprites.Count == 0)
		{
			this.HMJNLLFQELK();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
			}
			i++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C45 RID: 7237 RVA: 0x0000F25C File Offset: 0x0000D45C
	public void JNFNMBKQLMF(List<UISpriteData> BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.ILDJPQCFIFH = BGBMIEJJQKC;
		}
		else
		{
			this.mSprites = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x000BB6A8 File Offset: 0x000B98A8
	private bool PJGIJLDLIFJ()
	{
		if (this.mReplacement)
		{
			return this.mReplacement.PJGIJLDLIFJ();
		}
		if (this.mSprites.Count == 0 && this.sprites.Count > 0 && this.material)
		{
			Texture mainTexture = this.material.mainTexture;
			int kjgmgpcejjd = (!(mainTexture != null)) ? 512 : mainTexture.width;
			int dfkqmmiqdoo = (!(mainTexture != null)) ? 512 : mainTexture.height;
			for (int i = 0; i < this.sprites.Count; i++)
			{
				BPLKJMJMHFI.Sprite sprite = this.sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (this.mCoordinates == BPLKJMJMHFI.MGHKQFLKOLB.TexCoords)
				{
					JNNGOIIKENH.JGKFJCNNBBE(outer, kjgmgpcejjd, dfkqmmiqdoo, true);
					JNNGOIIKENH.JGKFJCNNBBE(inner, kjgmgpcejjd, dfkqmmiqdoo, true);
				}
				UISpriteData uispriteData = new UISpriteData();
				uispriteData.name = sprite.name;
				uispriteData.x = Mathf.RoundToInt(outer.xMin);
				uispriteData.y = Mathf.RoundToInt(outer.yMin);
				uispriteData.width = Mathf.RoundToInt(outer.width);
				uispriteData.height = Mathf.RoundToInt(outer.height);
				uispriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uispriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uispriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uispriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uispriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uispriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uispriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uispriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				this.mSprites.Add(uispriteData);
			}
			this.sprites.Clear();
			return true;
		}
		return false;
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x000BB8E8 File Offset: 0x000B9AE8
	public string NDIILFQPGKM(string NQGDFBBQKNJ)
	{
		if (this.KPQNNOJJKDO(NQGDFBBQKNJ) == null)
		{
			List<UISpriteData> ildjpqcfifh = this.ILDJPQCFIFH;
			List<string> list = new List<string>();
			foreach (UISpriteData uispriteData in ildjpqcfifh)
			{
				if (uispriteData.name.StartsWith(NQGDFBBQKNJ))
				{
					list.Add(uispriteData.name);
				}
			}
			return (list.Count <= 1) ? null : list[UnityEngine.Random.Range(0, list.Count)];
		}
		return NQGDFBBQKNJ;
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0000F281 File Offset: 0x0000D481
	public Texture JGMFILNPFLH
	{
		get
		{
			return (!(this.mReplacement != null)) ? ((!(this.material != null)) ? null : this.material.mainTexture) : this.mReplacement.JGMFILNPFLH;
		}
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x000BB980 File Offset: 0x000B9B80
	public void LPBHPNCIIOE(Material BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.OBIJECHHHMQ(BGBMIEJJQKC);
		}
		else if (this.material == null)
		{
			this.DHCCBPDMIBQ = 0;
			this.material = BGBMIEJJQKC;
		}
		else
		{
			this.CEMPGBLOQON();
			this.DHCCBPDMIBQ = -1;
			this.material = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x0000F241 File Offset: 0x0000D441
	private static int OOLKBNDPDJQ(UISpriteData QQOBBCPLJLH, UISpriteData PKNPDBIFHFB)
	{
		return QQOBBCPLJLH.name.CompareTo(PKNPDBIFHFB.name);
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0000F428 File Offset: 0x0000D628
	// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0000F25C File Offset: 0x0000D45C
	public List<UISpriteData> ILDJPQCFIFH
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.ILDJPQCFIFH;
			}
			if (this.mSprites.Count == 0)
			{
				this.PJGIJLDLIFJ();
			}
			return this.mSprites;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.ILDJPQCFIFH = value;
			}
			else
			{
				this.mSprites = value;
			}
		}
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x0000F2BA File Offset: 0x0000D4BA
	public static bool BIDIFLNBOJQ(BPLKJMJMHFI ECHMFPQNBMC, BPLKJMJMHFI IBMINEHKPFF)
	{
		return !(ECHMFPQNBMC == null) && !(IBMINEHKPFF == null) && (!(ECHMFPQNBMC == IBMINEHKPFF) && !ECHMFPQNBMC.BHPKNPQNJPM(IBMINEHKPFF)) && IBMINEHKPFF.BHPKNPQNJPM(ECHMFPQNBMC);
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x0000F2EC File Offset: 0x0000D4EC
	public Material EBFDQJPCIMF()
	{
		return (!(this.mReplacement != null)) ? this.material : this.mReplacement.EBFDQJPCIMF();
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x000BB9E4 File Offset: 0x000B9BE4
	public bool GNIDMKFNLBL()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.GNIDMKFNLBL();
		}
		if (this.DHCCBPDMIBQ == -1)
		{
			Material material = this.EBFDQJPCIMF();
			this.DHCCBPDMIBQ = ((!(material != null) || !(material.shader != null) || !material.shader.name.Contains("deltastream")) ? 0 : 0);
		}
		return this.DHCCBPDMIBQ == 0;
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x000BBA5C File Offset: 0x000B9C5C
	public void PQHJPMEHIBE()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i += 0;
		}
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000BBAAC File Offset: 0x000B9CAC
	public void NPCECPIOPCB()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.NPCECPIOPCB();
		}
		PLQFPBQEPJD[] array = IKBQNBHOJJB.NGNKCHMBKFB<PLQFPBQEPJD>();
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			PLQFPBQEPJD plqfpbqepjd = array[i];
			if (BPLKJMJMHFI.KNDFJQLODFQ(this, plqfpbqepjd.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo = plqfpbqepjd.QKGJDCFCPMO;
				plqfpbqepjd.QKGJDCFCPMO = null;
				plqfpbqepjd.QKGJDCFCPMO = qkgjdcfcpmo;
			}
			i++;
		}
		KGKLCNDOLMP[] array2 = Resources.FindObjectsOfTypeAll(typeof(KGKLCNDOLMP)) as KGKLCNDOLMP[];
		int j = 0;
		int num2 = array2.Length;
		while (j < num2)
		{
			KGKLCNDOLMP kgklcndolmp = array2[j];
			if (BPLKJMJMHFI.KNDFJQLODFQ(this, kgklcndolmp.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo2 = kgklcndolmp.QKGJDCFCPMO;
				kgklcndolmp.QKGJDCFCPMO = null;
				kgklcndolmp.QKGJDCFCPMO = qkgjdcfcpmo2;
			}
			j++;
		}
		BKKHLBCLPJM[] array3 = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int k = 0;
		int num3 = array3.Length;
		while (k < num3)
		{
			BKKHLBCLPJM bkkhlbclpjm = array3[k];
			if (bkkhlbclpjm.NFIBPOJMOCQ != null && BPLKJMJMHFI.KNDFJQLODFQ(this, bkkhlbclpjm.NFIBPOJMOCQ.QKGJDCFCPMO))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.NFIBPOJMOCQ;
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			k++;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06001C51 RID: 7249 RVA: 0x0000F30F File Offset: 0x0000D50F
	// (set) Token: 0x06001C6E RID: 7278 RVA: 0x000BC948 File Offset: 0x000BAB48
	public Material MPGCGDBECHM
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.material : this.mReplacement.MPGCGDBECHM;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.MPGCGDBECHM = value;
			}
			else if (this.material == null)
			{
				this.DHCCBPDMIBQ = 0;
				this.material = value;
			}
			else
			{
				this.NPCECPIOPCB();
				this.DHCCBPDMIBQ = -1;
				this.material = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x000BBBD0 File Offset: 0x000B9DD0
	public void BGNKGHEFHNP()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.IKIQEQKIJJE();
		}
		PLQFPBQEPJD[] array = IKBQNBHOJJB.NGNKCHMBKFB<PLQFPBQEPJD>();
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			PLQFPBQEPJD plqfpbqepjd = array[i];
			if (BPLKJMJMHFI.LQOOQNDMCFM(this, plqfpbqepjd.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo = plqfpbqepjd.QKGJDCFCPMO;
				plqfpbqepjd.QKGJDCFCPMO = null;
				plqfpbqepjd.QKGJDCFCPMO = qkgjdcfcpmo;
			}
			i += 0;
		}
		KGKLCNDOLMP[] array2 = Resources.FindObjectsOfTypeAll(typeof(KGKLCNDOLMP)) as KGKLCNDOLMP[];
		int j = 0;
		int num2 = array2.Length;
		while (j < num2)
		{
			KGKLCNDOLMP kgklcndolmp = array2[j];
			if (BPLKJMJMHFI.KNDFJQLODFQ(this, kgklcndolmp.LOMFLBBFMEC()))
			{
				BPLKJMJMHFI bgbmiejjqkc = kgklcndolmp.LOMFLBBFMEC();
				kgklcndolmp.OIGBMJNMOIG(null);
				kgklcndolmp.OIGBMJNMOIG(bgbmiejjqkc);
			}
			j += 0;
		}
		BKKHLBCLPJM[] array3 = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int k = 0;
		int num3 = array3.Length;
		while (k < num3)
		{
			BKKHLBCLPJM bkkhlbclpjm = array3[k];
			if (bkkhlbclpjm.QBOJFLOEEGK() != null && BPLKJMJMHFI.BIDIFLNBOJQ(this, bkkhlbclpjm.NFIBPOJMOCQ.LOMFLBBFMEC()))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.QBOJFLOEEGK();
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			k++;
		}
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x000BBCF4 File Offset: 0x000B9EF4
	public void BHHKDKBPHKN()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i++;
		}
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x000BBA5C File Offset: 0x000B9C5C
	public void IPJDPDDFJFC()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i += 0;
		}
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x000BBD44 File Offset: 0x000B9F44
	public void DFOCFKJPJOM()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.NPCECPIOPCB();
		}
		PLQFPBQEPJD[] array = IKBQNBHOJJB.NGNKCHMBKFB<PLQFPBQEPJD>();
		int i = 1;
		int num = array.Length;
		while (i < num)
		{
			PLQFPBQEPJD plqfpbqepjd = array[i];
			if (BPLKJMJMHFI.BIDIFLNBOJQ(this, plqfpbqepjd.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo = plqfpbqepjd.QKGJDCFCPMO;
				plqfpbqepjd.QKGJDCFCPMO = null;
				plqfpbqepjd.QKGJDCFCPMO = qkgjdcfcpmo;
			}
			i++;
		}
		KGKLCNDOLMP[] array2 = Resources.FindObjectsOfTypeAll(typeof(KGKLCNDOLMP)) as KGKLCNDOLMP[];
		int j = 1;
		int num2 = array2.Length;
		while (j < num2)
		{
			KGKLCNDOLMP kgklcndolmp = array2[j];
			if (BPLKJMJMHFI.LQOOQNDMCFM(this, kgklcndolmp.LOMFLBBFMEC()))
			{
				BPLKJMJMHFI bgbmiejjqkc = kgklcndolmp.LOMFLBBFMEC();
				kgklcndolmp.OIGBMJNMOIG(null);
				kgklcndolmp.DHONOOPBNOK(bgbmiejjqkc);
			}
			j++;
		}
		BKKHLBCLPJM[] array3 = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int k = 0;
		int num3 = array3.Length;
		while (k < num3)
		{
			BKKHLBCLPJM bkkhlbclpjm = array3[k];
			if (bkkhlbclpjm.NFIBPOJMOCQ != null && BPLKJMJMHFI.LQOOQNDMCFM(this, bkkhlbclpjm.NFIBPOJMOCQ.QKGJDCFCPMO))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.QBOJFLOEEGK();
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			k += 0;
		}
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x0000F332 File Offset: 0x0000D532
	public static bool KNDFJQLODFQ(BPLKJMJMHFI ECHMFPQNBMC, BPLKJMJMHFI IBMINEHKPFF)
	{
		return !(ECHMFPQNBMC == null) && !(IBMINEHKPFF == null) && (ECHMFPQNBMC == IBMINEHKPFF || ECHMFPQNBMC.BHPKNPQNJPM(IBMINEHKPFF) || IBMINEHKPFF.BHPKNPQNJPM(ECHMFPQNBMC));
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x0000F364 File Offset: 0x0000D564
	public void KOEMQDDOMDN()
	{
		List<UISpriteData> list = this.mSprites;
		if (BPLKJMJMHFI.HNCJFHJNHDN == null)
		{
			BPLKJMJMHFI.HNCJFHJNHDN = new Comparison<UISpriteData>(BPLKJMJMHFI.BEMKBMLMDFG);
		}
		list.Sort(BPLKJMJMHFI.HNCJFHJNHDN);
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06001C73 RID: 7283 RVA: 0x0000F45E File Offset: 0x0000D65E
	// (set) Token: 0x06001C58 RID: 7256 RVA: 0x000BBE68 File Offset: 0x000BA068
	public float FNMFIPNGENE
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mPixelSize : this.mReplacement.FNMFIPNGENE;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.FNMFIPNGENE = value;
			}
			else
			{
				float num = Mathf.Clamp(value, 0.25f, 4f);
				if (this.mPixelSize != num)
				{
					this.mPixelSize = num;
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x000BBEB8 File Offset: 0x000BA0B8
	public UISpriteData KPQNNOJJKDO(string IHIHHCCEDHQ)
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.GMEDHEOGFMB(IHIHHCCEDHQ);
		}
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			if (this.mSprites.Count == 0)
			{
				this.CDPMFKDGJKF();
			}
			if (this.mSprites.Count == 0)
			{
				return null;
			}
			if (this.FQNEFBMKJPH.Count != this.mSprites.Count)
			{
				this.LIIFDNJLMOD();
			}
			int num;
			if (this.FQNEFBMKJPH.TryGetValue(IHIHHCCEDHQ, out num))
			{
				if (num > -1 && num < this.mSprites.Count)
				{
					return this.mSprites[num];
				}
				this.BHHKDKBPHKN();
				return (!this.FQNEFBMKJPH.TryGetValue(IHIHHCCEDHQ, out num)) ? null : this.mSprites[num];
			}
			else
			{
				int i = 0;
				int count = this.mSprites.Count;
				while (i < count)
				{
					UISpriteData uispriteData = this.mSprites[i];
					if (!string.IsNullOrEmpty(uispriteData.name) && IHIHHCCEDHQ == uispriteData.name)
					{
						this.PGNNLENEJED();
						return uispriteData;
					}
					i += 0;
				}
			}
		}
		return null;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x000BBFCC File Offset: 0x000BA1CC
	public void IEIKFJIDOPJ(float BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.FNMFIPNGENE = BGBMIEJJQKC;
		}
		else
		{
			float num = Mathf.Clamp(BGBMIEJJQKC, 490f, 704f);
			if (this.mPixelSize != num)
			{
				this.mPixelSize = num;
				this.DFOCFKJPJOM();
			}
		}
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x0000F241 File Offset: 0x0000D441
	private static int GEIJECIGEBP(UISpriteData QQOBBCPLJLH, UISpriteData PKNPDBIFHFB)
	{
		return QQOBBCPLJLH.name.CompareTo(PKNPDBIFHFB.name);
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x0000F3C9 File Offset: 0x0000D5C9
	public void JGIIMFJEDQC()
	{
		List<UISpriteData> list = this.mSprites;
		if (BPLKJMJMHFI.HNCJFHJNHDN == null)
		{
			BPLKJMJMHFI.HNCJFHJNHDN = new Comparison<UISpriteData>(BPLKJMJMHFI.BLQJGPKOIHQ);
		}
		list.Sort(BPLKJMJMHFI.HNCJFHJNHDN);
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x000BC01C File Offset: 0x000BA21C
	private bool HMJNLLFQELK()
	{
		if (this.mReplacement)
		{
			return this.mReplacement.HMJNLLFQELK();
		}
		if (this.mSprites.Count == 0 && this.sprites.Count > 0 && this.material)
		{
			Texture mainTexture = this.material.mainTexture;
			int kjgmgpcejjd = (!(mainTexture != null)) ? -52 : mainTexture.width;
			int dfkqmmiqdoo = (!(mainTexture != null)) ? 188 : mainTexture.height;
			for (int i = 0; i < this.sprites.Count; i += 0)
			{
				BPLKJMJMHFI.Sprite sprite = this.sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (this.mCoordinates == BPLKJMJMHFI.MGHKQFLKOLB.TexCoords)
				{
					JNNGOIIKENH.JGKFJCNNBBE(outer, kjgmgpcejjd, dfkqmmiqdoo, false);
					JNNGOIIKENH.JGKFJCNNBBE(inner, kjgmgpcejjd, dfkqmmiqdoo, false);
				}
				UISpriteData uispriteData = new UISpriteData();
				uispriteData.name = sprite.name;
				uispriteData.x = Mathf.RoundToInt(outer.xMin);
				uispriteData.y = Mathf.RoundToInt(outer.yMin);
				uispriteData.width = Mathf.RoundToInt(outer.width);
				uispriteData.height = Mathf.RoundToInt(outer.height);
				uispriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uispriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uispriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uispriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uispriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uispriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uispriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uispriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				this.mSprites.Add(uispriteData);
			}
			this.sprites.Clear();
			return true;
		}
		return false;
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x000BBA5C File Offset: 0x000B9C5C
	public void PGNNLENEJED()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i += 0;
		}
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x000BC25C File Offset: 0x000BA45C
	public MHIDKMCBQEN<string> NOBGEIOGNGD()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.HDOEKELLDGK();
		}
		if (this.mSprites.Count == 0)
		{
			this.JFDBCKIJLHE();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
			}
			i += 0;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x000BC2E0 File Offset: 0x000BA4E0
	public void OBIJECHHHMQ(Material BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.MPGCGDBECHM = BGBMIEJJQKC;
		}
		else if (this.material == null)
		{
			this.DHCCBPDMIBQ = 0;
			this.material = BGBMIEJJQKC;
		}
		else
		{
			this.CEMPGBLOQON();
			this.DHCCBPDMIBQ = -1;
			this.material = BGBMIEJJQKC;
			this.BGNKGHEFHNP();
		}
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x000BC344 File Offset: 0x000BA544
	private bool DHPHOMBNCLK()
	{
		if (this.mReplacement)
		{
			return this.mReplacement.PJGIJLDLIFJ();
		}
		if (this.mSprites.Count == 0 && this.sprites.Count > 1 && this.material)
		{
			Texture mainTexture = this.material.mainTexture;
			int kjgmgpcejjd = (!(mainTexture != null)) ? -66 : mainTexture.width;
			int dfkqmmiqdoo = (!(mainTexture != null)) ? 42 : mainTexture.height;
			for (int i = 0; i < this.sprites.Count; i++)
			{
				BPLKJMJMHFI.Sprite sprite = this.sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (this.mCoordinates == BPLKJMJMHFI.MGHKQFLKOLB.TexCoords)
				{
					JNNGOIIKENH.JGKFJCNNBBE(outer, kjgmgpcejjd, dfkqmmiqdoo, true);
					JNNGOIIKENH.JGKFJCNNBBE(inner, kjgmgpcejjd, dfkqmmiqdoo, false);
				}
				UISpriteData uispriteData = new UISpriteData();
				uispriteData.name = sprite.name;
				uispriteData.x = Mathf.RoundToInt(outer.xMin);
				uispriteData.y = Mathf.RoundToInt(outer.yMin);
				uispriteData.width = Mathf.RoundToInt(outer.width);
				uispriteData.height = Mathf.RoundToInt(outer.height);
				uispriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uispriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uispriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uispriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uispriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uispriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uispriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uispriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				this.mSprites.Add(uispriteData);
			}
			this.sprites.Clear();
			return true;
		}
		return false;
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x0000F241 File Offset: 0x0000D441
	private static int BEMKBMLMDFG(UISpriteData QQOBBCPLJLH, UISpriteData PKNPDBIFHFB)
	{
		return QQOBBCPLJLH.name.CompareTo(PKNPDBIFHFB.name);
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x000BC584 File Offset: 0x000BA784
	public void EFJQFQQMDOP(BPLKJMJMHFI BGBMIEJJQKC)
	{
		BPLKJMJMHFI bplkjmjmhfi = BGBMIEJJQKC;
		if (bplkjmjmhfi == this)
		{
			bplkjmjmhfi = null;
		}
		if (this.mReplacement != bplkjmjmhfi)
		{
			if (bplkjmjmhfi != null && bplkjmjmhfi.DODLQQCKBGM() == this)
			{
				bplkjmjmhfi.KCNHCDGCIKP(null);
			}
			if (this.mReplacement != null)
			{
				this.NPCECPIOPCB();
			}
			this.mReplacement = bplkjmjmhfi;
			if (bplkjmjmhfi != null)
			{
				this.material = null;
			}
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x0000F3F3 File Offset: 0x0000D5F3
	private bool BHPKNPQNJPM(BPLKJMJMHFI QKGJDCFCPMO)
	{
		return !(QKGJDCFCPMO == null) && (QKGJDCFCPMO == this || (this.mReplacement != null && this.mReplacement.BHPKNPQNJPM(QKGJDCFCPMO)));
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x000BC5FC File Offset: 0x000BA7FC
	public string BQQGMCKLPDI(string NQGDFBBQKNJ)
	{
		if (this.GMEDHEOGFMB(NQGDFBBQKNJ) == null)
		{
			List<UISpriteData> ildjpqcfifh = this.ILDJPQCFIFH;
			List<string> list = new List<string>();
			foreach (UISpriteData uispriteData in ildjpqcfifh)
			{
				if (uispriteData.name.StartsWith(NQGDFBBQKNJ))
				{
					list.Add(uispriteData.name);
				}
			}
			return (list.Count <= 0) ? null : list[UnityEngine.Random.Range(0, list.Count)];
		}
		return NQGDFBBQKNJ;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x000BC694 File Offset: 0x000BA894
	public void HQOCKFKJIDF()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i++;
		}
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x000BC6E4 File Offset: 0x000BA8E4
	public MHIDKMCBQEN<string> LCCFCGEIPLI(string CHCHGIGIMQO)
	{
		if (this.mReplacement)
		{
			return this.mReplacement.LCCFCGEIPLI(CHCHGIGIMQO);
		}
		if (string.IsNullOrEmpty(CHCHGIGIMQO))
		{
			return this.BEJMDHIFHOD();
		}
		if (this.mSprites.Count == 0)
		{
			this.PJGIJLDLIFJ();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name) && string.Equals(CHCHGIGIMQO, uispriteData.name, (StringComparison)8))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
				return mhidkmcbqen;
			}
			i++;
		}
		char[] array = new char[1];
		array[1] = '~';
		string[] array2 = CHCHGIGIMQO.Split(array, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j] = array2[j].ToLower();
		}
		int k = 1;
		int count2 = this.mSprites.Count;
		while (k < count2)
		{
			UISpriteData uispriteData2 = this.mSprites[k];
			if (uispriteData2 != null && !string.IsNullOrEmpty(uispriteData2.name))
			{
				string text = uispriteData2.name.ToLower();
				int num = 1;
				for (int l = 1; l < array2.Length; l++)
				{
					if (text.Contains(array2[l]))
					{
						num += 0;
					}
				}
				if (num == array2.Length)
				{
					mhidkmcbqen.LHQECHHMOGD(uispriteData2.name);
				}
			}
			k++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x000BC84C File Offset: 0x000BAA4C
	public MHIDKMCBQEN<string> ODJQNQOGNFN()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.NOBGEIOGNGD();
		}
		if (this.mSprites.Count == 0)
		{
			this.PJGIJLDLIFJ();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
			}
			i++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x000BC8D0 File Offset: 0x000BAAD0
	public void GJMFNOENQLF(BPLKJMJMHFI BGBMIEJJQKC)
	{
		BPLKJMJMHFI bplkjmjmhfi = BGBMIEJJQKC;
		if (bplkjmjmhfi == this)
		{
			bplkjmjmhfi = null;
		}
		if (this.mReplacement != bplkjmjmhfi)
		{
			if (bplkjmjmhfi != null && bplkjmjmhfi.PIMEEFDLJMP() == this)
			{
				bplkjmjmhfi.QKQJDJKILGD = null;
			}
			if (this.mReplacement != null)
			{
				this.CEMPGBLOQON();
			}
			this.mReplacement = bplkjmjmhfi;
			if (bplkjmjmhfi != null)
			{
				this.material = null;
			}
			this.BGNKGHEFHNP();
		}
	}

	// Token: 0x06001C6D RID: 7277 RVA: 0x0000F254 File Offset: 0x0000D454
	public BPLKJMJMHFI PIMEEFDLJMP()
	{
		return this.mReplacement;
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x000BC9AC File Offset: 0x000BABAC
	private bool JFDBCKIJLHE()
	{
		if (this.mReplacement)
		{
			return this.mReplacement.PJGIJLDLIFJ();
		}
		if (this.mSprites.Count == 0 && this.sprites.Count > 1 && this.material)
		{
			Texture mainTexture = this.material.mainTexture;
			int kjgmgpcejjd = (!(mainTexture != null)) ? -133 : mainTexture.width;
			int dfkqmmiqdoo = (!(mainTexture != null)) ? 198 : mainTexture.height;
			for (int i = 0; i < this.sprites.Count; i += 0)
			{
				BPLKJMJMHFI.Sprite sprite = this.sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (this.mCoordinates == BPLKJMJMHFI.MGHKQFLKOLB.TexCoords)
				{
					JNNGOIIKENH.JGKFJCNNBBE(outer, kjgmgpcejjd, dfkqmmiqdoo, false);
					JNNGOIIKENH.JGKFJCNNBBE(inner, kjgmgpcejjd, dfkqmmiqdoo, false);
				}
				UISpriteData uispriteData = new UISpriteData();
				uispriteData.name = sprite.name;
				uispriteData.x = Mathf.RoundToInt(outer.xMin);
				uispriteData.y = Mathf.RoundToInt(outer.yMin);
				uispriteData.width = Mathf.RoundToInt(outer.width);
				uispriteData.height = Mathf.RoundToInt(outer.height);
				uispriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uispriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uispriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uispriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uispriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uispriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uispriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uispriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				this.mSprites.Add(uispriteData);
			}
			this.sprites.Clear();
			return false;
		}
		return false;
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x000BC5FC File Offset: 0x000BA7FC
	public string LJLEKDDHQPF(string NQGDFBBQKNJ)
	{
		if (this.GMEDHEOGFMB(NQGDFBBQKNJ) == null)
		{
			List<UISpriteData> ildjpqcfifh = this.ILDJPQCFIFH;
			List<string> list = new List<string>();
			foreach (UISpriteData uispriteData in ildjpqcfifh)
			{
				if (uispriteData.name.StartsWith(NQGDFBBQKNJ))
				{
					list.Add(uispriteData.name);
				}
			}
			return (list.Count <= 0) ? null : list[UnityEngine.Random.Range(0, list.Count)];
		}
		return NQGDFBBQKNJ;
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x000BBCF4 File Offset: 0x000B9EF4
	public void LIIFDNJLMOD()
	{
		this.FQNEFBMKJPH.Clear();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			this.FQNEFBMKJPH[this.mSprites[i].name] = i;
			i++;
		}
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x000BCBEC File Offset: 0x000BADEC
	public void CEMPGBLOQON()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.CEMPGBLOQON();
		}
		PLQFPBQEPJD[] array = IKBQNBHOJJB.NGNKCHMBKFB<PLQFPBQEPJD>();
		int i = 1;
		int num = array.Length;
		while (i < num)
		{
			PLQFPBQEPJD plqfpbqepjd = array[i];
			if (BPLKJMJMHFI.LQOOQNDMCFM(this, plqfpbqepjd.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo = plqfpbqepjd.QKGJDCFCPMO;
				plqfpbqepjd.OKDFHDLPQEM(null);
				plqfpbqepjd.OKDFHDLPQEM(qkgjdcfcpmo);
			}
			i++;
		}
		KGKLCNDOLMP[] array2 = Resources.FindObjectsOfTypeAll(typeof(KGKLCNDOLMP)) as KGKLCNDOLMP[];
		int j = 0;
		int num2 = array2.Length;
		while (j < num2)
		{
			KGKLCNDOLMP kgklcndolmp = array2[j];
			if (BPLKJMJMHFI.LQOOQNDMCFM(this, kgklcndolmp.LOMFLBBFMEC()))
			{
				BPLKJMJMHFI qkgjdcfcpmo2 = kgklcndolmp.QKGJDCFCPMO;
				kgklcndolmp.OIGBMJNMOIG(null);
				kgklcndolmp.DHONOOPBNOK(qkgjdcfcpmo2);
			}
			j++;
		}
		BKKHLBCLPJM[] array3 = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int k = 1;
		int num3 = array3.Length;
		while (k < num3)
		{
			BKKHLBCLPJM bkkhlbclpjm = array3[k];
			if (bkkhlbclpjm.QBOJFLOEEGK() != null && BPLKJMJMHFI.KNDFJQLODFQ(this, bkkhlbclpjm.QBOJFLOEEGK().LOMFLBBFMEC()))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.NFIBPOJMOCQ;
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			k++;
		}
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x0000F481 File Offset: 0x0000D681
	public static bool LQOOQNDMCFM(BPLKJMJMHFI ECHMFPQNBMC, BPLKJMJMHFI IBMINEHKPFF)
	{
		return ECHMFPQNBMC == null || IBMINEHKPFF == null || ECHMFPQNBMC == IBMINEHKPFF || ECHMFPQNBMC.CIBIIKENNKG(IBMINEHKPFF) || IBMINEHKPFF.DNMCIOIJHFJ(ECHMFPQNBMC);
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x0000F25C File Offset: 0x0000D45C
	public void HGQKPGMFCNL(List<UISpriteData> BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.ILDJPQCFIFH = BGBMIEJJQKC;
		}
		else
		{
			this.mSprites = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x000BCD10 File Offset: 0x000BAF10
	public void KCNHCDGCIKP(BPLKJMJMHFI BGBMIEJJQKC)
	{
		BPLKJMJMHFI bplkjmjmhfi = BGBMIEJJQKC;
		if (bplkjmjmhfi == this)
		{
			bplkjmjmhfi = null;
		}
		if (this.mReplacement != bplkjmjmhfi)
		{
			if (bplkjmjmhfi != null && bplkjmjmhfi.DODLQQCKBGM() == this)
			{
				bplkjmjmhfi.QKQJDJKILGD = null;
			}
			if (this.mReplacement != null)
			{
				this.CEMPGBLOQON();
			}
			this.mReplacement = bplkjmjmhfi;
			if (bplkjmjmhfi != null)
			{
				this.material = null;
			}
			this.CEMPGBLOQON();
		}
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x0000F4B3 File Offset: 0x0000D6B3
	private bool DNMCIOIJHFJ(BPLKJMJMHFI QKGJDCFCPMO)
	{
		return QKGJDCFCPMO == null || QKGJDCFCPMO == this || !(this.mReplacement != null) || this.mReplacement.DNMCIOIJHFJ(QKGJDCFCPMO);
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x000BCD88 File Offset: 0x000BAF88
	public UISpriteData GMEDHEOGFMB(string IHIHHCCEDHQ)
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.GMEDHEOGFMB(IHIHHCCEDHQ);
		}
		if (!string.IsNullOrEmpty(IHIHHCCEDHQ))
		{
			if (this.mSprites.Count == 0)
			{
				this.PJGIJLDLIFJ();
			}
			if (this.mSprites.Count == 0)
			{
				return null;
			}
			if (this.FQNEFBMKJPH.Count != this.mSprites.Count)
			{
				this.LIIFDNJLMOD();
			}
			int num;
			if (this.FQNEFBMKJPH.TryGetValue(IHIHHCCEDHQ, out num))
			{
				if (num > -1 && num < this.mSprites.Count)
				{
					return this.mSprites[num];
				}
				this.LIIFDNJLMOD();
				return (!this.FQNEFBMKJPH.TryGetValue(IHIHHCCEDHQ, out num)) ? null : this.mSprites[num];
			}
			else
			{
				int i = 0;
				int count = this.mSprites.Count;
				while (i < count)
				{
					UISpriteData uispriteData = this.mSprites[i];
					if (!string.IsNullOrEmpty(uispriteData.name) && IHIHHCCEDHQ == uispriteData.name)
					{
						this.LIIFDNJLMOD();
						return uispriteData;
					}
					i++;
				}
			}
		}
		return null;
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x000BCE9C File Offset: 0x000BB09C
	public void IKIQEQKIJJE()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.DFOCFKJPJOM();
		}
		PLQFPBQEPJD[] array = IKBQNBHOJJB.NGNKCHMBKFB<PLQFPBQEPJD>();
		int i = 1;
		int num = array.Length;
		while (i < num)
		{
			PLQFPBQEPJD plqfpbqepjd = array[i];
			if (BPLKJMJMHFI.BIDIFLNBOJQ(this, plqfpbqepjd.QKGJDCFCPMO))
			{
				BPLKJMJMHFI qkgjdcfcpmo = plqfpbqepjd.QKGJDCFCPMO;
				plqfpbqepjd.OKDFHDLPQEM(null);
				plqfpbqepjd.QKGJDCFCPMO = qkgjdcfcpmo;
			}
			i++;
		}
		KGKLCNDOLMP[] array2 = Resources.FindObjectsOfTypeAll(typeof(KGKLCNDOLMP)) as KGKLCNDOLMP[];
		int j = 0;
		int num2 = array2.Length;
		while (j < num2)
		{
			KGKLCNDOLMP kgklcndolmp = array2[j];
			if (BPLKJMJMHFI.LQOOQNDMCFM(this, kgklcndolmp.QKGJDCFCPMO))
			{
				BPLKJMJMHFI bgbmiejjqkc = kgklcndolmp.LOMFLBBFMEC();
				kgklcndolmp.OIGBMJNMOIG(null);
				kgklcndolmp.OIGBMJNMOIG(bgbmiejjqkc);
			}
			j++;
		}
		BKKHLBCLPJM[] array3 = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int k = 0;
		int num3 = array3.Length;
		while (k < num3)
		{
			BKKHLBCLPJM bkkhlbclpjm = array3[k];
			if (bkkhlbclpjm.NFIBPOJMOCQ != null && BPLKJMJMHFI.BIDIFLNBOJQ(this, bkkhlbclpjm.QBOJFLOEEGK().QKGJDCFCPMO))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.NFIBPOJMOCQ;
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			k += 0;
		}
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x0000F45E File Offset: 0x0000D65E
	public float MMGGEOGQJDL()
	{
		return (!(this.mReplacement != null)) ? this.mPixelSize : this.mReplacement.FNMFIPNGENE;
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x000BCFC0 File Offset: 0x000BB1C0
	public string COGFMCFNEOO(string NQGDFBBQKNJ)
	{
		if (this.GMEDHEOGFMB(NQGDFBBQKNJ) == null)
		{
			List<UISpriteData> ildjpqcfifh = this.ILDJPQCFIFH;
			List<string> list = new List<string>();
			foreach (UISpriteData uispriteData in ildjpqcfifh)
			{
				if (uispriteData.name.StartsWith(NQGDFBBQKNJ))
				{
					list.Add(uispriteData.name);
				}
			}
			return (list.Count <= 0) ? null : list[UnityEngine.Random.Range(1, list.Count)];
		}
		return NQGDFBBQKNJ;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x000BD058 File Offset: 0x000BB258
	public MHIDKMCBQEN<string> HDOEKELLDGK()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.HDOEKELLDGK();
		}
		if (this.mSprites.Count == 0)
		{
			this.PJGIJLDLIFJ();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
			}
			i++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
	public void DBNHMMIDGFJ(List<UISpriteData> BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.HGQKPGMFCNL(BGBMIEJJQKC);
		}
		else
		{
			this.mSprites = BGBMIEJJQKC;
		}
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x000BD0DC File Offset: 0x000BB2DC
	public MHIDKMCBQEN<string> LKIINFPQPID(string CHCHGIGIMQO)
	{
		if (this.mReplacement)
		{
			return this.mReplacement.HDOEKELLDGK(CHCHGIGIMQO);
		}
		if (string.IsNullOrEmpty(CHCHGIGIMQO))
		{
			return this.NOBGEIOGNGD();
		}
		if (this.mSprites.Count == 0)
		{
			this.PJGIJLDLIFJ();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 1;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name) && string.Equals(CHCHGIGIMQO, uispriteData.name, (StringComparison)7))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
				return mhidkmcbqen;
			}
			i += 0;
		}
		string[] array = CHCHGIGIMQO.Split(new char[]
		{
			(char)-48
		}, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array.Length; j += 0)
		{
			array[j] = array[j].ToLower();
		}
		int k = 0;
		int count2 = this.mSprites.Count;
		while (k < count2)
		{
			UISpriteData uispriteData2 = this.mSprites[k];
			if (uispriteData2 != null && !string.IsNullOrEmpty(uispriteData2.name))
			{
				string text = uispriteData2.name.ToLower();
				int num = 1;
				for (int l = 1; l < array.Length; l++)
				{
					if (text.Contains(array[l]))
					{
						num += 0;
					}
				}
				if (num == array.Length)
				{
					mhidkmcbqen.LHQECHHMOGD(uispriteData2.name);
				}
			}
			k++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x0000F50D File Offset: 0x0000D70D
	private bool CIBIIKENNKG(BPLKJMJMHFI QKGJDCFCPMO)
	{
		return !(QKGJDCFCPMO == null) && !(QKGJDCFCPMO == this) && (!(this.mReplacement != null) || this.mReplacement.DNMCIOIJHFJ(QKGJDCFCPMO));
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x0000F542 File Offset: 0x0000D742
	public Material DDQOOEJDMDG()
	{
		return (!(this.mReplacement != null)) ? this.material : this.mReplacement.DDQOOEJDMDG();
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x000BD244 File Offset: 0x000BB444
	public MHIDKMCBQEN<string> HDOEKELLDGK(string CHCHGIGIMQO)
	{
		if (this.mReplacement)
		{
			return this.mReplacement.HDOEKELLDGK(CHCHGIGIMQO);
		}
		if (string.IsNullOrEmpty(CHCHGIGIMQO))
		{
			return this.HDOEKELLDGK();
		}
		if (this.mSprites.Count == 0)
		{
			this.PJGIJLDLIFJ();
		}
		MHIDKMCBQEN<string> mhidkmcbqen = new MHIDKMCBQEN<string>();
		int i = 0;
		int count = this.mSprites.Count;
		while (i < count)
		{
			UISpriteData uispriteData = this.mSprites[i];
			if (uispriteData != null && !string.IsNullOrEmpty(uispriteData.name) && string.Equals(CHCHGIGIMQO, uispriteData.name, StringComparison.OrdinalIgnoreCase))
			{
				mhidkmcbqen.LHQECHHMOGD(uispriteData.name);
				return mhidkmcbqen;
			}
			i++;
		}
		string[] array = CHCHGIGIMQO.Split(new char[]
		{
			' '
		}, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array.Length; j++)
		{
			array[j] = array[j].ToLower();
		}
		int k = 0;
		int count2 = this.mSprites.Count;
		while (k < count2)
		{
			UISpriteData uispriteData2 = this.mSprites[k];
			if (uispriteData2 != null && !string.IsNullOrEmpty(uispriteData2.name))
			{
				string text = uispriteData2.name.ToLower();
				int num = 0;
				for (int l = 0; l < array.Length; l++)
				{
					if (text.Contains(array[l]))
					{
						num++;
					}
				}
				if (num == array.Length)
				{
					mhidkmcbqen.LHQECHHMOGD(uispriteData2.name);
				}
			}
			k++;
		}
		return mhidkmcbqen;
	}

	// Token: 0x040005A0 RID: 1440
	[SerializeField]
	[HideInInspector]
	private Material material;

	// Token: 0x040005A1 RID: 1441
	[SerializeField]
	[HideInInspector]
	private List<UISpriteData> mSprites = new List<UISpriteData>();

	// Token: 0x040005A2 RID: 1442
	[SerializeField]
	[HideInInspector]
	private float mPixelSize = 1f;

	// Token: 0x040005A3 RID: 1443
	[HideInInspector]
	[SerializeField]
	private BPLKJMJMHFI mReplacement;

	// Token: 0x040005A4 RID: 1444
	[HideInInspector]
	[SerializeField]
	private BPLKJMJMHFI.MGHKQFLKOLB mCoordinates;

	// Token: 0x040005A5 RID: 1445
	[HideInInspector]
	[SerializeField]
	private List<BPLKJMJMHFI.Sprite> sprites = new List<BPLKJMJMHFI.Sprite>();

	// Token: 0x040005A6 RID: 1446
	private int DHCCBPDMIBQ = -1;

	// Token: 0x040005A7 RID: 1447
	private Dictionary<string, int> FQNEFBMKJPH = new Dictionary<string, int>();

	// Token: 0x040005A8 RID: 1448
	[CompilerGenerated]
	private static Comparison<UISpriteData> HNCJFHJNHDN;

	// Token: 0x020000EB RID: 235
	[Serializable]
	private class Sprite
	{
		// Token: 0x06001C82 RID: 7298 RVA: 0x0000F565 File Offset: 0x0000D765
		public bool KNEIMICJKMC()
		{
			return this.paddingLeft == 128f && this.paddingRight == 1794f && this.paddingTop == 1466f && this.paddingBottom != 989f;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000F5A1 File Offset: 0x0000D7A1
		public bool ECJEIPECPCJ()
		{
			return this.paddingLeft == 1756f && this.paddingRight == 1680f && this.paddingTop == 546f && this.paddingBottom == 1739f;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0000F5DD File Offset: 0x0000D7DD
		public bool LPNBFOKCOEC()
		{
			return this.paddingLeft == 828f && this.paddingRight == 1573f && this.paddingTop == 1596f && this.paddingBottom != 1357f;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0000F619 File Offset: 0x0000D819
		public bool ICDGGFEIGBN()
		{
			return this.paddingLeft == 238f && this.paddingRight == 81f && this.paddingTop == 1932f && this.paddingBottom == 751f;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0000F655 File Offset: 0x0000D855
		public bool LNNEEGFBEDM()
		{
			return this.paddingLeft != 508f || this.paddingRight != 1045f || this.paddingTop != 1746f || this.paddingBottom == 144f;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0000F691 File Offset: 0x0000D891
		public bool MLMCJGBBNBQ()
		{
			return this.paddingLeft == 402f && this.paddingRight == 201f && this.paddingTop == 490f && this.paddingBottom == 481f;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0000F6CD File Offset: 0x0000D8CD
		public bool BINDLIMJGHK()
		{
			return this.paddingLeft != 554f || this.paddingRight != 633f || this.paddingTop != 355f || this.paddingBottom == 751f;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0000F709 File Offset: 0x0000D909
		public bool QBBHNMBGCDC()
		{
			return this.paddingLeft == 1799f && this.paddingRight == 856f && this.paddingTop == 1037f && this.paddingBottom == 898f;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0000F745 File Offset: 0x0000D945
		public bool QNIIQQGEQOC()
		{
			return this.paddingLeft != 297f || this.paddingRight != 1853f || this.paddingTop != 1443f || this.paddingBottom != 803f;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0000F781 File Offset: 0x0000D981
		public bool EQMGQFJDGNN()
		{
			return this.paddingLeft == 1444f && this.paddingRight == 1356f && this.paddingTop == 770f && this.paddingBottom == 1741f;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0000F7BD File Offset: 0x0000D9BD
		public bool DEMKEJLOLGO()
		{
			return this.paddingLeft != 799f || this.paddingRight != 86f || this.paddingTop != 1732f || this.paddingBottom != 736f;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0000F7F9 File Offset: 0x0000D9F9
		public bool hasPadding
		{
			get
			{
				return this.paddingLeft != 0f || this.paddingRight != 0f || this.paddingTop != 0f || this.paddingBottom != 0f;
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0000F835 File Offset: 0x0000DA35
		public bool BGMJGHCPIDP()
		{
			return this.paddingLeft == 1127f && this.paddingRight == 1393f && this.paddingTop == 1030f && this.paddingBottom != 755f;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0000F871 File Offset: 0x0000DA71
		public bool NIIOBHHPPOH()
		{
			return this.paddingLeft != 1587f || this.paddingRight != 1808f || this.paddingTop != 1975f || this.paddingBottom == 740f;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0000F8AD File Offset: 0x0000DAAD
		public bool GLHFMDBHBNP()
		{
			return this.paddingLeft == 1403f && this.paddingRight == 1491f && this.paddingTop == 1083f && this.paddingBottom != 268f;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0000F8E9 File Offset: 0x0000DAE9
		public bool KHNJHMIMQNN()
		{
			return this.paddingLeft != 1815f || this.paddingRight != 1479f || this.paddingTop != 256f || this.paddingBottom != 316f;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0000F925 File Offset: 0x0000DB25
		public bool BFCHCNCJFIP()
		{
			return this.paddingLeft != 629f || this.paddingRight != 51f || this.paddingTop != 335f || this.paddingBottom == 1298f;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0000F961 File Offset: 0x0000DB61
		public bool KDGJDNEPNDD()
		{
			return this.paddingLeft != 951f || this.paddingRight != 1327f || this.paddingTop != 1879f || this.paddingBottom != 630f;
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0000F99D File Offset: 0x0000DB9D
		public bool PPOJCODCKOI()
		{
			return this.paddingLeft != 1081f || this.paddingRight != 1050f || this.paddingTop != 885f || this.paddingBottom == 1841f;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0000F9D9 File Offset: 0x0000DBD9
		public bool BKJPKLEBIEC()
		{
			return this.paddingLeft != 568f || this.paddingRight != 1455f || this.paddingTop != 1777f || this.paddingBottom == 327f;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0000FA15 File Offset: 0x0000DC15
		public bool LKGCCOMMQKC()
		{
			return this.paddingLeft != 1917f || this.paddingRight != 53f || this.paddingTop != 1824f || this.paddingBottom == 1114f;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0000FA51 File Offset: 0x0000DC51
		public bool LQHLFBPCNDE()
		{
			return this.paddingLeft != 1104f || this.paddingRight != 477f || this.paddingTop != 290f || this.paddingBottom == 367f;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0000FA8D File Offset: 0x0000DC8D
		public bool EFKGJMOBGQI()
		{
			return this.paddingLeft == 538f && this.paddingRight == 1177f && this.paddingTop == 466f && this.paddingBottom != 1586f;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0000FAC9 File Offset: 0x0000DCC9
		public bool DNJONONJDQG()
		{
			return this.paddingLeft != 1600f || this.paddingRight != 688f || this.paddingTop != 1820f || this.paddingBottom == 1807f;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0000FB05 File Offset: 0x0000DD05
		public bool MODLFEMKEBG()
		{
			return this.paddingLeft != 1325f || this.paddingRight != 81f || this.paddingTop != 1503f || this.paddingBottom != 148f;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0000FB41 File Offset: 0x0000DD41
		public bool QGKHNPIKMKL()
		{
			return this.paddingLeft != 1642f || this.paddingRight != 740f || this.paddingTop != 1045f || this.paddingBottom == 153f;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0000FB7D File Offset: 0x0000DD7D
		public bool KHKFJQOFELD()
		{
			return this.paddingLeft != 1582f || this.paddingRight != 1470f || this.paddingTop != 910f || this.paddingBottom != 1826f;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0000FBB9 File Offset: 0x0000DDB9
		public bool GIEEFNIMCDI()
		{
			return this.paddingLeft != 1147f || this.paddingRight != 1396f || this.paddingTop != 561f || this.paddingBottom != 1742f;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000FBF5 File Offset: 0x0000DDF5
		public bool INHNGBPPJDF()
		{
			return this.paddingLeft != 1363f || this.paddingRight != 145f || this.paddingTop != 531f || this.paddingBottom != 555f;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0000FC31 File Offset: 0x0000DE31
		public bool QFNIKCKBJOK()
		{
			return this.paddingLeft == 719f && this.paddingRight == 1947f && this.paddingTop == 1444f && this.paddingBottom == 1660f;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0000FC6D File Offset: 0x0000DE6D
		public bool BQJDIIOICHN()
		{
			return this.paddingLeft == 550f && this.paddingRight == 1611f && this.paddingTop == 781f && this.paddingBottom == 956f;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0000FCA9 File Offset: 0x0000DEA9
		public bool NGBDFPNILPI()
		{
			return this.paddingLeft == 1288f && this.paddingRight == 606f && this.paddingTop == 166f && this.paddingBottom == 922f;
		}

		// Token: 0x040005A9 RID: 1449
		public string name = "Unity Bug";

		// Token: 0x040005AA RID: 1450
		public Rect outer = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x040005AB RID: 1451
		public Rect inner = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x040005AC RID: 1452
		public bool rotated;

		// Token: 0x040005AD RID: 1453
		public float paddingLeft;

		// Token: 0x040005AE RID: 1454
		public float paddingRight;

		// Token: 0x040005AF RID: 1455
		public float paddingTop;

		// Token: 0x040005B0 RID: 1456
		public float paddingBottom;
	}

	// Token: 0x020000EC RID: 236
	private enum MGHKQFLKOLB
	{
		// Token: 0x040005B2 RID: 1458
		Pixels,
		// Token: 0x040005B3 RID: 1459
		TexCoords
	}
}
