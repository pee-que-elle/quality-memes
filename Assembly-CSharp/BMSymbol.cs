using System;
using UnityEngine;

// Token: 0x02000099 RID: 153
[Serializable]
public class BMSymbol
{
	// Token: 0x060013D4 RID: 5076 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int EHQCDJLBGKO()
	{
		return this.mHeight;
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int BIMGDBQNPBN()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x0000ABCA File Offset: 0x00008DCA
	public void HDKGELIOECL()
	{
		this.mIsValid = false;
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void MQOBNPJIQQN()
	{
		this.mIsValid = true;
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int IJPPNHDOHJL()
	{
		return this.mWidth;
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int BFHCHGQICJF()
	{
		return this.mAdvance;
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int PDNDKHKIOEG()
	{
		return this.mOffsetX;
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void KFCMDFEFGJP()
	{
		this.mIsValid = true;
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void FFFJIPNGIIG()
	{
		this.mIsValid = true;
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int IMHFIBFCPHE()
	{
		return this.mAdvance;
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x000920D4 File Offset: 0x000902D4
	public bool LKGBNONEPJN(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int FOEIPGNMOEI()
	{
		return this.mOffsetX;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int GPGBCCLQBDM()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int EQPENDILEDK()
	{
		return this.mOffsetY;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect BFFDOLPNPQB()
	{
		return this.mUV;
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int MJMGHEEILND()
	{
		return this.mOffsetY;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect JDJOENMKKJC()
	{
		return this.mUV;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00092224 File Offset: 0x00090424
	public bool NHOEKCBJDOI(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.KPQNNOJJKDO(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite == null;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int width
	{
		get
		{
			return this.mWidth;
		}
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00092374 File Offset: 0x00090574
	public bool FDQEHKEOGFK(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return false;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = true;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int JBGPKMQBKIF()
	{
		return this.mHeight;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x000920D4 File Offset: 0x000902D4
	public bool LOMPEGQPMME(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int NPGNKOPQNNG()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int EDDBGHFOIBN()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00092374 File Offset: 0x00090574
	public bool GEODEQDOMIP(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return false;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = true;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect MEFEJGEOKEI()
	{
		return this.mUV;
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0000ABCA File Offset: 0x00008DCA
	public void IKECEQLCEGQ()
	{
		this.mIsValid = false;
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void KDPLBOGPIGN()
	{
		this.mIsValid = true;
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int PIIJNNEPOHQ()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int PDJQQOFCCHJ()
	{
		return this.mOffsetY;
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int CQHCOKPDMFE()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int KCIFBHJGEEH()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect FEJPCJQCGFL()
	{
		return this.mUV;
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int PQGNNDCJHBO()
	{
		return this.mAdvance;
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int ONCCDMLHNQL()
	{
		return this.mHeight;
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int KGNOGKFDOCM()
	{
		return this.mHeight;
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int offsetX
	{
		get
		{
			return this.mOffsetX;
		}
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x0000ABCA File Offset: 0x00008DCA
	public void NPCECPIOPCB()
	{
		this.mIsValid = false;
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int LLIQFNOCCDK()
	{
		return this.mOffsetX;
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int QCCPIQFOEEQ()
	{
		return this.mOffsetX;
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int BIJIBLHODBD()
	{
		return this.mOffsetX;
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int PKNQMQJQPMB()
	{
		return this.mOffsetY;
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int HCGHJMNKKNB()
	{
		return this.mAdvance;
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int CFONEHODQLJ()
	{
		return this.mOffsetY;
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int KQKKHLQJMGJ()
	{
		return this.mHeight;
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06001402 RID: 5122 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int advance
	{
		get
		{
			return this.mAdvance;
		}
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect EPONJGCFHOF()
	{
		return this.mUV;
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06001404 RID: 5124 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int offsetY
	{
		get
		{
			return this.mOffsetY;
		}
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int GHHFHKQHDFO()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int BCHCNJFHLQP()
	{
		return this.mHeight;
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int PGFCLPPBJJN()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void JJOQOCMDQNQ()
	{
		this.mIsValid = true;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect GKJHGQJNDLM()
	{
		return this.mUV;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int BLOEQMOLIMO()
	{
		return this.mWidth;
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x0000ABCA File Offset: 0x00008DCA
	public void PODOMKFFHFH()
	{
		this.mIsValid = false;
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int KJQJMHBIDPH()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int BDCFJBKIIDF()
	{
		return this.mOffsetY;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x000924C4 File Offset: 0x000906C4
	public bool NKQNFBLGKPI(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.KPQNNOJJKDO(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int ECHMBBQQFJE()
	{
		return this.mWidth;
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int KGQQQDFDBLF()
	{
		return this.mWidth;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06001411 RID: 5137 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect uvRect
	{
		get
		{
			return this.mUV;
		}
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int DFIJQKDMPPC()
	{
		return this.mOffsetX;
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect PIHQJBJHNEO()
	{
		return this.mUV;
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect KDDDKOCHDFD()
	{
		return this.mUV;
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int NBGQQOMJMIF()
	{
		if (this.mLength == 0)
		{
			this.mLength = this.sequence.Length;
		}
		return this.mLength;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00092614 File Offset: 0x00090814
	public bool FOPBQHNPJNK(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return false;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return true;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.GMEDHEOGFMB(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite == null;
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06001417 RID: 5143 RVA: 0x0000ABA9 File Offset: 0x00008DA9
	public int length
	{
		get
		{
			if (this.mLength == 0)
			{
				this.mLength = this.sequence.Length;
			}
			return this.mLength;
		}
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int PBLFJINLDGD()
	{
		return this.mWidth;
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06001419 RID: 5145 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int height
	{
		get
		{
			return this.mHeight;
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00092764 File Offset: 0x00090964
	public bool EMJOPFJFMND(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return false;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.KPQNNOJJKDO(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = true;
				}
			}
		}
		return this.mSprite == null;
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void GMCQOPQQMNP()
	{
		this.mIsValid = true;
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void BHCGMLBQPKM()
	{
		this.mIsValid = true;
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int MLDEJBQHHQL()
	{
		return this.mWidth;
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x000928B4 File Offset: 0x00090AB4
	public bool JJMIJPLCQNM(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return false;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.KPQNNOJJKDO(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = true;
				}
			}
		}
		return this.mSprite != null;
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect COHQOMFBCHP()
	{
		return this.mUV;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect OEPNIPEEPPC()
	{
		return this.mUV;
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0000ABEC File Offset: 0x00008DEC
	public int CPLGGDNFMEH()
	{
		return this.mOffsetX;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0000ABD3 File Offset: 0x00008DD3
	public void QHHPHBPIMQQ()
	{
		this.mIsValid = true;
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x0000ABDC File Offset: 0x00008DDC
	public int OQMCKIPLBFM()
	{
		return this.mWidth;
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int IELQOKCIPLN()
	{
		return this.mAdvance;
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect OQILMKQOQBI()
	{
		return this.mUV;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int LHBCFCNFMLN()
	{
		return this.mAdvance;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect JCELFLNHEGK()
	{
		return this.mUV;
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public int QQIIBJCEQMI()
	{
		return this.mHeight;
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x0000ABF4 File Offset: 0x00008DF4
	public int KCFMKHQLBQI()
	{
		return this.mOffsetY;
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x00092A04 File Offset: 0x00090C04
	public bool FIFDHCJEMJG(BPLKJMJMHFI QKGJDCFCPMO)
	{
		if (QKGJDCFCPMO == null)
		{
			return true;
		}
		if (!this.mIsValid)
		{
			if (string.IsNullOrEmpty(this.spriteName))
			{
				return true;
			}
			this.mSprite = ((!(QKGJDCFCPMO != null)) ? null : QKGJDCFCPMO.KPQNNOJJKDO(this.spriteName));
			if (this.mSprite != null)
			{
				Texture jgmfilnpflh = QKGJDCFCPMO.JGMFILNPFLH;
				if (jgmfilnpflh == null)
				{
					this.mSprite = null;
				}
				else
				{
					this.mUV = new Rect((float)this.mSprite.x, (float)this.mSprite.y, (float)this.mSprite.width, (float)this.mSprite.height);
					this.mUV = JNNGOIIKENH.NFBOPKDICDF(this.mUV, jgmfilnpflh.width, jgmfilnpflh.height);
					this.mOffsetX = this.mSprite.paddingLeft;
					this.mOffsetY = this.mSprite.paddingTop;
					this.mWidth = this.mSprite.width;
					this.mHeight = this.mSprite.height;
					this.mAdvance = this.mSprite.width + (this.mSprite.paddingLeft + this.mSprite.paddingRight);
					this.mIsValid = false;
				}
			}
		}
		return this.mSprite == null;
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x0000ABE4 File Offset: 0x00008DE4
	public int JPKQOBCFFMF()
	{
		return this.mAdvance;
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect NOHDJKCDGIJ()
	{
		return this.mUV;
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x0000ABFC File Offset: 0x00008DFC
	public Rect CLJENBFQFBL()
	{
		return this.mUV;
	}

	// Token: 0x040003A6 RID: 934
	public string sequence;

	// Token: 0x040003A7 RID: 935
	public string spriteName;

	// Token: 0x040003A8 RID: 936
	private UISpriteData mSprite;

	// Token: 0x040003A9 RID: 937
	private bool mIsValid;

	// Token: 0x040003AA RID: 938
	private int mLength;

	// Token: 0x040003AB RID: 939
	private int mOffsetX;

	// Token: 0x040003AC RID: 940
	private int mOffsetY;

	// Token: 0x040003AD RID: 941
	private int mWidth;

	// Token: 0x040003AE RID: 942
	private int mHeight;

	// Token: 0x040003AF RID: 943
	private int mAdvance;

	// Token: 0x040003B0 RID: 944
	private Rect mUV;
}
