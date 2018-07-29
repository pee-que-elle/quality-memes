using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x020000B1 RID: 177
public abstract class PHINQNMFEHC : ENFMCDNLEQQ
{
	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060016C5 RID: 5829 RVA: 0x0000BCA2 File Offset: 0x00009EA2
	// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000BCAA File Offset: 0x00009EAA
	public virtual PHINQNMFEHC.OFPCLCEBHFL DPQFDCNLLPC
	{
		get
		{
			return this.mType;
		}
		set
		{
			if (this.mType != value)
			{
				this.mType = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060016C7 RID: 5831 RVA: 0x0000BCC2 File Offset: 0x00009EC2
	// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0000BCCA File Offset: 0x00009ECA
	public PHINQNMFEHC.OOPCCQKNGOC LIKDPCQFMGH
	{
		get
		{
			return this.mFlip;
		}
		set
		{
			if (this.mFlip != value)
			{
				this.mFlip = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0000BCE2 File Offset: 0x00009EE2
	// (set) Token: 0x060016CA RID: 5834 RVA: 0x0000BCEA File Offset: 0x00009EEA
	public PHINQNMFEHC.MQIMDDINNEQ JOGPPPPKFNC
	{
		get
		{
			return this.mFillDirection;
		}
		set
		{
			if (this.mFillDirection != value)
			{
				this.mFillDirection = value;
				this.LHQDFLPFGME = true;
			}
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060016CB RID: 5835 RVA: 0x0000BD03 File Offset: 0x00009F03
	// (set) Token: 0x060016CC RID: 5836 RVA: 0x000A3314 File Offset: 0x000A1514
	public float KJNJQMLJELI
	{
		get
		{
			return this.mFillAmount;
		}
		set
		{
			float num = Mathf.Clamp01(value);
			if (this.mFillAmount != num)
			{
				this.mFillAmount = num;
				this.LHQDFLPFGME = true;
			}
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060016CD RID: 5837 RVA: 0x000A3340 File Offset: 0x000A1540
	public override int QPKCPBJINBK
	{
		get
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
			{
				if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Advanced)
				{
					return base.QPKCPBJINBK;
				}
			}
			Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
			int num = Mathf.RoundToInt(vector.x + vector.z);
			return Mathf.Max(base.QPKCPBJINBK, ((num & 1) != 1) ? num : (num + 1));
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060016CE RID: 5838 RVA: 0x000A33A8 File Offset: 0x000A15A8
	public override int IPGGCHLFDCF
	{
		get
		{
			if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Sliced)
			{
				if (this.DPQFDCNLLPC != PHINQNMFEHC.OFPCLCEBHFL.Advanced)
				{
					return base.IPGGCHLFDCF;
				}
			}
			Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
			int num = Mathf.RoundToInt(vector.y + vector.w);
			return Mathf.Max(base.IPGGCHLFDCF, ((num & 1) != 1) ? num : (num + 1));
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060016CF RID: 5839 RVA: 0x0000BD0B File Offset: 0x00009F0B
	// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000BD13 File Offset: 0x00009F13
	public bool DELNOHEFELI
	{
		get
		{
			return this.mInvert;
		}
		set
		{
			if (this.mInvert != value)
			{
				this.mInvert = value;
				this.LHQDFLPFGME = true;
			}
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000A3410 File Offset: 0x000A1610
	public bool CMGIPNDQKIE
	{
		get
		{
			Vector4 fmgjbhhndpc = this.FMGJBHHNDPC;
			return fmgjbhhndpc.x != 0f || fmgjbhhndpc.y != 0f || fmgjbhhndpc.z != 0f || fmgjbhhndpc.w != 0f;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0000BD2C File Offset: 0x00009F2C
	public virtual bool KKGEBNMDHLN
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0000BD2F File Offset: 0x00009F2F
	public virtual float FNMFIPNGENE
	{
		get
		{
			return 1f;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000A3464 File Offset: 0x000A1664
	private Vector4 FKEJLMMDINP
	{
		get
		{
			switch (this.mFlip)
			{
			case PHINQNMFEHC.OOPCCQKNGOC.Horizontally:
				return new Vector4(this.JFQBMCELJHC.xMax, this.JFQBMCELJHC.yMin, this.JFQBMCELJHC.xMin, this.JFQBMCELJHC.yMax);
			case PHINQNMFEHC.OOPCCQKNGOC.Vertically:
				return new Vector4(this.JFQBMCELJHC.xMin, this.JFQBMCELJHC.yMax, this.JFQBMCELJHC.xMax, this.JFQBMCELJHC.yMin);
			case PHINQNMFEHC.OOPCCQKNGOC.Both:
				return new Vector4(this.JFQBMCELJHC.xMax, this.JFQBMCELJHC.yMax, this.JFQBMCELJHC.xMin, this.JFQBMCELJHC.yMin);
			default:
				return new Vector4(this.JFQBMCELJHC.xMin, this.JFQBMCELJHC.yMin, this.JFQBMCELJHC.xMax, this.JFQBMCELJHC.yMax);
			}
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000A3554 File Offset: 0x000A1754
	protected Color FNBDGHBQPHJ
	{
		get
		{
			Color color = base.CEGFBBHMKOE;
			color.a = this.NHCNEDEEONK;
			if (this.KKGEBNMDHLN)
			{
				color = IKBQNBHOJJB.BQCGKIDLIOC(color);
			}
			return color;
		}
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x000A3588 File Offset: 0x000A1788
	protected void NBINLNQEIIJ(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO, Rect BBCEGNHBOOF, Rect QBJKDMBFPBJ)
	{
		this.JFQBMCELJHC = BBCEGNHBOOF;
		this.MGOGCLMNMME = QBJKDMBFPBJ;
		switch (this.DPQFDCNLLPC)
		{
		case PHINQNMFEHC.OFPCLCEBHFL.Simple:
			this.NPNPGQKKKJM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			break;
		case PHINQNMFEHC.OFPCLCEBHFL.Sliced:
			this.NKJFIOKDPLM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			break;
		case PHINQNMFEHC.OFPCLCEBHFL.Tiled:
			this.PJEJDLQKLJH(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			break;
		case PHINQNMFEHC.OFPCLCEBHFL.Filled:
			this.ONGHMGBDQJH(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			break;
		case PHINQNMFEHC.OFPCLCEBHFL.Advanced:
			this.HNLENFEDPIC(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			break;
		}
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x000A3600 File Offset: 0x000A1800
	private void NPNPGQKKKJM(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Vector4 bceppkgmnfe = this.BCEPPKGMNFE;
		Vector4 fkejlmmdinp = this.FKEJLMMDINP;
		Color fnbdghbqphj = this.FNBDGHBQPHJ;
		EQINHIFFOGG.Add(new Vector3(bceppkgmnfe.x, bceppkgmnfe.y));
		EQINHIFFOGG.Add(new Vector3(bceppkgmnfe.x, bceppkgmnfe.w));
		EQINHIFFOGG.Add(new Vector3(bceppkgmnfe.z, bceppkgmnfe.w));
		EQINHIFFOGG.Add(new Vector3(bceppkgmnfe.z, bceppkgmnfe.y));
		PICFCJNMJMC.Add(new Vector2(fkejlmmdinp.x, fkejlmmdinp.y));
		PICFCJNMJMC.Add(new Vector2(fkejlmmdinp.x, fkejlmmdinp.w));
		PICFCJNMJMC.Add(new Vector2(fkejlmmdinp.z, fkejlmmdinp.w));
		PICFCJNMJMC.Add(new Vector2(fkejlmmdinp.z, fkejlmmdinp.y));
		if (!this.mApplyGradient)
		{
			HQOONBPDFHO.Add(fnbdghbqphj);
			HQOONBPDFHO.Add(fnbdghbqphj);
			HQOONBPDFHO.Add(fnbdghbqphj);
			HQOONBPDFHO.Add(fnbdghbqphj);
		}
		else
		{
			this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, 1, 1);
			this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, 1, 2);
			this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, 2, 2);
			this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, 2, 1);
		}
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x000A373C File Offset: 0x000A193C
	private void NKJFIOKDPLM(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		if (vector.x == 0f && vector.y == 0f && vector.z == 0f && vector.w == 0f)
		{
			this.NPNPGQKKKJM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			return;
		}
		Color fnbdghbqphj = this.FNBDGHBQPHJ;
		Vector4 bceppkgmnfe = this.BCEPPKGMNFE;
		PHINQNMFEHC.HJKPELHQJPL[0].x = bceppkgmnfe.x;
		PHINQNMFEHC.HJKPELHQJPL[0].y = bceppkgmnfe.y;
		PHINQNMFEHC.HJKPELHQJPL[3].x = bceppkgmnfe.z;
		PHINQNMFEHC.HJKPELHQJPL[3].y = bceppkgmnfe.w;
		if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
		{
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
			{
				PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x + vector.x;
				PHINQNMFEHC.HJKPELHQJPL[2].x = PHINQNMFEHC.HJKPELHQJPL[3].x - vector.z;
				PHINQNMFEHC.LCFNDMLMJKF[0].x = this.JFQBMCELJHC.xMin;
				PHINQNMFEHC.LCFNDMLMJKF[1].x = this.MGOGCLMNMME.xMin;
				PHINQNMFEHC.LCFNDMLMJKF[2].x = this.MGOGCLMNMME.xMax;
				PHINQNMFEHC.LCFNDMLMJKF[3].x = this.JFQBMCELJHC.xMax;
				goto IL_255;
			}
		}
		PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x + vector.z;
		PHINQNMFEHC.HJKPELHQJPL[2].x = PHINQNMFEHC.HJKPELHQJPL[3].x - vector.x;
		PHINQNMFEHC.LCFNDMLMJKF[3].x = this.JFQBMCELJHC.xMin;
		PHINQNMFEHC.LCFNDMLMJKF[2].x = this.MGOGCLMNMME.xMin;
		PHINQNMFEHC.LCFNDMLMJKF[1].x = this.MGOGCLMNMME.xMax;
		PHINQNMFEHC.LCFNDMLMJKF[0].x = this.JFQBMCELJHC.xMax;
		IL_255:
		if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
		{
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
			{
				PHINQNMFEHC.HJKPELHQJPL[1].y = PHINQNMFEHC.HJKPELHQJPL[0].y + vector.y;
				PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[3].y - vector.w;
				PHINQNMFEHC.LCFNDMLMJKF[0].y = this.JFQBMCELJHC.yMin;
				PHINQNMFEHC.LCFNDMLMJKF[1].y = this.MGOGCLMNMME.yMin;
				PHINQNMFEHC.LCFNDMLMJKF[2].y = this.MGOGCLMNMME.yMax;
				PHINQNMFEHC.LCFNDMLMJKF[3].y = this.JFQBMCELJHC.yMax;
				goto IL_3EC;
			}
		}
		PHINQNMFEHC.HJKPELHQJPL[1].y = PHINQNMFEHC.HJKPELHQJPL[0].y + vector.w;
		PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[3].y - vector.y;
		PHINQNMFEHC.LCFNDMLMJKF[3].y = this.JFQBMCELJHC.yMin;
		PHINQNMFEHC.LCFNDMLMJKF[2].y = this.MGOGCLMNMME.yMin;
		PHINQNMFEHC.LCFNDMLMJKF[1].y = this.MGOGCLMNMME.yMax;
		PHINQNMFEHC.LCFNDMLMJKF[0].y = this.JFQBMCELJHC.yMax;
		IL_3EC:
		for (int i = 0; i < 3; i++)
		{
			int num = i + 1;
			for (int j = 0; j < 3; j++)
			{
				if (this.MMNMEHKBLOH != PHINQNMFEHC.OGEQPBCECPM.Invisible || i != 1 || j != 1)
				{
					int num2 = j + 1;
					EQINHIFFOGG.Add(new Vector3(PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[j].y));
					EQINHIFFOGG.Add(new Vector3(PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[num2].y));
					EQINHIFFOGG.Add(new Vector3(PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[num2].y));
					EQINHIFFOGG.Add(new Vector3(PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[j].y));
					PICFCJNMJMC.Add(new Vector2(PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[j].y));
					PICFCJNMJMC.Add(new Vector2(PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[num2].y));
					PICFCJNMJMC.Add(new Vector2(PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[num2].y));
					PICFCJNMJMC.Add(new Vector2(PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[j].y));
					if (!this.mApplyGradient)
					{
						HQOONBPDFHO.Add(fnbdghbqphj);
						HQOONBPDFHO.Add(fnbdghbqphj);
						HQOONBPDFHO.Add(fnbdghbqphj);
						HQOONBPDFHO.Add(fnbdghbqphj);
					}
					else
					{
						this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, i, j);
						this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, i, num2);
						this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, num, num2);
						this.MOHHMFEJDJJ(HQOONBPDFHO, ref fnbdghbqphj, num, j);
					}
				}
			}
		}
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x000A3D3C File Offset: 0x000A1F3C
	[DebuggerHidden]
	[DebuggerStepThrough]
	private void MOHHMFEJDJJ(List<Color> HQOONBPDFHO, ref Color CEGFBBHMKOE, int DGKOIGOLHDM, int DDLQKFDFMCJ)
	{
		if (DDLQKFDFMCJ != 0)
		{
			if (DDLQKFDFMCJ != 1)
			{
				if (DDLQKFDFMCJ == 2 || DDLQKFDFMCJ == 3)
				{
					HQOONBPDFHO.Add(CEGFBBHMKOE * this.mGradientTop);
					return;
				}
				return;
			}
		}
		HQOONBPDFHO.Add(CEGFBBHMKOE * this.mGradientBottom);
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x000A3D90 File Offset: 0x000A1F90
	private void PJEJDLQKLJH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Vector2 a = new Vector2(this.MGOGCLMNMME.width * (float)goihjqnmmjd.width, this.MGOGCLMNMME.height * (float)goihjqnmmjd.height);
		a *= this.FNMFIPNGENE;
		if (!(goihjqnmmjd == null) && a.x >= 2f && a.y >= 2f)
		{
			Color fnbdghbqphj = this.FNBDGHBQPHJ;
			Vector4 bceppkgmnfe = this.BCEPPKGMNFE;
			Vector4 vector;
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
			{
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
				{
					vector.x = this.MGOGCLMNMME.xMin;
					vector.z = this.MGOGCLMNMME.xMax;
					goto IL_E5;
				}
			}
			vector.x = this.MGOGCLMNMME.xMax;
			vector.z = this.MGOGCLMNMME.xMin;
			IL_E5:
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
			{
				if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
				{
					vector.y = this.MGOGCLMNMME.yMin;
					vector.w = this.MGOGCLMNMME.yMax;
					goto IL_143;
				}
			}
			vector.y = this.MGOGCLMNMME.yMax;
			vector.w = this.MGOGCLMNMME.yMin;
			IL_143:
			float num = bceppkgmnfe.x;
			float num2 = bceppkgmnfe.y;
			float x = vector.x;
			float y = vector.y;
			while (num2 < bceppkgmnfe.w)
			{
				num = bceppkgmnfe.x;
				float num3 = num2 + a.y;
				float y2 = vector.w;
				if (num3 > bceppkgmnfe.w)
				{
					y2 = Mathf.Lerp(vector.y, vector.w, (bceppkgmnfe.w - num2) / a.y);
					num3 = bceppkgmnfe.w;
				}
				while (num < bceppkgmnfe.z)
				{
					float num4 = num + a.x;
					float x2 = vector.z;
					if (num4 > bceppkgmnfe.z)
					{
						x2 = Mathf.Lerp(vector.x, vector.z, (bceppkgmnfe.z - num) / a.x);
						num4 = bceppkgmnfe.z;
					}
					EQINHIFFOGG.Add(new Vector3(num, num2));
					EQINHIFFOGG.Add(new Vector3(num, num3));
					EQINHIFFOGG.Add(new Vector3(num4, num3));
					EQINHIFFOGG.Add(new Vector3(num4, num2));
					PICFCJNMJMC.Add(new Vector2(x, y));
					PICFCJNMJMC.Add(new Vector2(x, y2));
					PICFCJNMJMC.Add(new Vector2(x2, y2));
					PICFCJNMJMC.Add(new Vector2(x2, y));
					HQOONBPDFHO.Add(fnbdghbqphj);
					HQOONBPDFHO.Add(fnbdghbqphj);
					HQOONBPDFHO.Add(fnbdghbqphj);
					HQOONBPDFHO.Add(fnbdghbqphj);
					num += a.x;
				}
				num2 += a.y;
			}
			return;
		}
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x000A4084 File Offset: 0x000A2284
	private void ONGHMGBDQJH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (this.mFillAmount < 0.001f)
		{
			return;
		}
		Vector4 bceppkgmnfe = this.BCEPPKGMNFE;
		Vector4 fkejlmmdinp = this.FKEJLMMDINP;
		Color fnbdghbqphj = this.FNBDGHBQPHJ;
		if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Horizontal || this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Vertical)
		{
			if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Horizontal)
			{
				float num = (fkejlmmdinp.z - fkejlmmdinp.x) * this.mFillAmount;
				if (this.mInvert)
				{
					bceppkgmnfe.x = bceppkgmnfe.z - (bceppkgmnfe.z - bceppkgmnfe.x) * this.mFillAmount;
					fkejlmmdinp.x = fkejlmmdinp.z - num;
				}
				else
				{
					bceppkgmnfe.z = bceppkgmnfe.x + (bceppkgmnfe.z - bceppkgmnfe.x) * this.mFillAmount;
					fkejlmmdinp.z = fkejlmmdinp.x + num;
				}
			}
			else if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Vertical)
			{
				float num2 = (fkejlmmdinp.w - fkejlmmdinp.y) * this.mFillAmount;
				if (this.mInvert)
				{
					bceppkgmnfe.y = bceppkgmnfe.w - (bceppkgmnfe.w - bceppkgmnfe.y) * this.mFillAmount;
					fkejlmmdinp.y = fkejlmmdinp.w - num2;
				}
				else
				{
					bceppkgmnfe.w = bceppkgmnfe.y + (bceppkgmnfe.w - bceppkgmnfe.y) * this.mFillAmount;
					fkejlmmdinp.w = fkejlmmdinp.y + num2;
				}
			}
		}
		PHINQNMFEHC.HJKPELHQJPL[0] = new Vector2(bceppkgmnfe.x, bceppkgmnfe.y);
		PHINQNMFEHC.HJKPELHQJPL[1] = new Vector2(bceppkgmnfe.x, bceppkgmnfe.w);
		PHINQNMFEHC.HJKPELHQJPL[2] = new Vector2(bceppkgmnfe.z, bceppkgmnfe.w);
		PHINQNMFEHC.HJKPELHQJPL[3] = new Vector2(bceppkgmnfe.z, bceppkgmnfe.y);
		PHINQNMFEHC.LCFNDMLMJKF[0] = new Vector2(fkejlmmdinp.x, fkejlmmdinp.y);
		PHINQNMFEHC.LCFNDMLMJKF[1] = new Vector2(fkejlmmdinp.x, fkejlmmdinp.w);
		PHINQNMFEHC.LCFNDMLMJKF[2] = new Vector2(fkejlmmdinp.z, fkejlmmdinp.w);
		PHINQNMFEHC.LCFNDMLMJKF[3] = new Vector2(fkejlmmdinp.z, fkejlmmdinp.y);
		if (this.mFillAmount < 1f)
		{
			if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Radial90)
			{
				if (PHINQNMFEHC.JNDGJCCMCOO(PHINQNMFEHC.HJKPELHQJPL, PHINQNMFEHC.LCFNDMLMJKF, this.mFillAmount, this.mInvert, 0))
				{
					for (int i = 0; i < 4; i++)
					{
						EQINHIFFOGG.Add(PHINQNMFEHC.HJKPELHQJPL[i]);
						PICFCJNMJMC.Add(PHINQNMFEHC.LCFNDMLMJKF[i]);
						HQOONBPDFHO.Add(fnbdghbqphj);
					}
				}
				return;
			}
			if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Radial180)
			{
				for (int j = 0; j < 2; j++)
				{
					float t = 0f;
					float t2 = 1f;
					float t3;
					float t4;
					if (j == 0)
					{
						t3 = 0f;
						t4 = 0.5f;
					}
					else
					{
						t3 = 0.5f;
						t4 = 1f;
					}
					PHINQNMFEHC.HJKPELHQJPL[0].x = Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, t3);
					PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x;
					PHINQNMFEHC.HJKPELHQJPL[2].x = Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, t4);
					PHINQNMFEHC.HJKPELHQJPL[3].x = PHINQNMFEHC.HJKPELHQJPL[2].x;
					PHINQNMFEHC.HJKPELHQJPL[0].y = Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, t);
					PHINQNMFEHC.HJKPELHQJPL[1].y = Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, t2);
					PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[1].y;
					PHINQNMFEHC.HJKPELHQJPL[3].y = PHINQNMFEHC.HJKPELHQJPL[0].y;
					PHINQNMFEHC.LCFNDMLMJKF[0].x = Mathf.Lerp(fkejlmmdinp.x, fkejlmmdinp.z, t3);
					PHINQNMFEHC.LCFNDMLMJKF[1].x = PHINQNMFEHC.LCFNDMLMJKF[0].x;
					PHINQNMFEHC.LCFNDMLMJKF[2].x = Mathf.Lerp(fkejlmmdinp.x, fkejlmmdinp.z, t4);
					PHINQNMFEHC.LCFNDMLMJKF[3].x = PHINQNMFEHC.LCFNDMLMJKF[2].x;
					PHINQNMFEHC.LCFNDMLMJKF[0].y = Mathf.Lerp(fkejlmmdinp.y, fkejlmmdinp.w, t);
					PHINQNMFEHC.LCFNDMLMJKF[1].y = Mathf.Lerp(fkejlmmdinp.y, fkejlmmdinp.w, t2);
					PHINQNMFEHC.LCFNDMLMJKF[2].y = PHINQNMFEHC.LCFNDMLMJKF[1].y;
					PHINQNMFEHC.LCFNDMLMJKF[3].y = PHINQNMFEHC.LCFNDMLMJKF[0].y;
					float value = this.mInvert ? (this.mFillAmount * 2f - (float)(1 - j)) : (this.KJNJQMLJELI * 2f - (float)j);
					if (PHINQNMFEHC.JNDGJCCMCOO(PHINQNMFEHC.HJKPELHQJPL, PHINQNMFEHC.LCFNDMLMJKF, Mathf.Clamp01(value), !this.mInvert, JNNGOIIKENH.FNNIKCNKDIN(j + 3, 4)))
					{
						for (int k = 0; k < 4; k++)
						{
							EQINHIFFOGG.Add(PHINQNMFEHC.HJKPELHQJPL[k]);
							PICFCJNMJMC.Add(PHINQNMFEHC.LCFNDMLMJKF[k]);
							HQOONBPDFHO.Add(fnbdghbqphj);
						}
					}
				}
				return;
			}
			if (this.mFillDirection == PHINQNMFEHC.MQIMDDINNEQ.Radial360)
			{
				int l = 0;
				while (l < 4)
				{
					float t5;
					float t6;
					if (l < 2)
					{
						t5 = 0f;
						t6 = 0.5f;
					}
					else
					{
						t5 = 0.5f;
						t6 = 1f;
					}
					if (l == 0)
					{
						goto IL_679;
					}
					if (l == 3)
					{
						goto IL_679;
					}
					float t7 = 0.5f;
					float t8 = 1f;
					IL_687:
					PHINQNMFEHC.HJKPELHQJPL[0].x = Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, t5);
					PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x;
					PHINQNMFEHC.HJKPELHQJPL[2].x = Mathf.Lerp(bceppkgmnfe.x, bceppkgmnfe.z, t6);
					PHINQNMFEHC.HJKPELHQJPL[3].x = PHINQNMFEHC.HJKPELHQJPL[2].x;
					PHINQNMFEHC.HJKPELHQJPL[0].y = Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, t7);
					PHINQNMFEHC.HJKPELHQJPL[1].y = Mathf.Lerp(bceppkgmnfe.y, bceppkgmnfe.w, t8);
					PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[1].y;
					PHINQNMFEHC.HJKPELHQJPL[3].y = PHINQNMFEHC.HJKPELHQJPL[0].y;
					PHINQNMFEHC.LCFNDMLMJKF[0].x = Mathf.Lerp(fkejlmmdinp.x, fkejlmmdinp.z, t5);
					PHINQNMFEHC.LCFNDMLMJKF[1].x = PHINQNMFEHC.LCFNDMLMJKF[0].x;
					PHINQNMFEHC.LCFNDMLMJKF[2].x = Mathf.Lerp(fkejlmmdinp.x, fkejlmmdinp.z, t6);
					PHINQNMFEHC.LCFNDMLMJKF[3].x = PHINQNMFEHC.LCFNDMLMJKF[2].x;
					PHINQNMFEHC.LCFNDMLMJKF[0].y = Mathf.Lerp(fkejlmmdinp.y, fkejlmmdinp.w, t7);
					PHINQNMFEHC.LCFNDMLMJKF[1].y = Mathf.Lerp(fkejlmmdinp.y, fkejlmmdinp.w, t8);
					PHINQNMFEHC.LCFNDMLMJKF[2].y = PHINQNMFEHC.LCFNDMLMJKF[1].y;
					PHINQNMFEHC.LCFNDMLMJKF[3].y = PHINQNMFEHC.LCFNDMLMJKF[0].y;
					float value2 = (!this.mInvert) ? (this.mFillAmount * 4f - (float)(3 - JNNGOIIKENH.FNNIKCNKDIN(l + 2, 4))) : (this.mFillAmount * 4f - (float)JNNGOIIKENH.FNNIKCNKDIN(l + 2, 4));
					if (PHINQNMFEHC.JNDGJCCMCOO(PHINQNMFEHC.HJKPELHQJPL, PHINQNMFEHC.LCFNDMLMJKF, Mathf.Clamp01(value2), this.mInvert, JNNGOIIKENH.FNNIKCNKDIN(l + 2, 4)))
					{
						for (int m = 0; m < 4; m++)
						{
							EQINHIFFOGG.Add(PHINQNMFEHC.HJKPELHQJPL[m]);
							PICFCJNMJMC.Add(PHINQNMFEHC.LCFNDMLMJKF[m]);
							HQOONBPDFHO.Add(fnbdghbqphj);
						}
					}
					l++;
					continue;
					IL_679:
					t7 = 0f;
					t8 = 0.5f;
					goto IL_687;
				}
				return;
			}
		}
		for (int n = 0; n < 4; n++)
		{
			EQINHIFFOGG.Add(PHINQNMFEHC.HJKPELHQJPL[n]);
			PICFCJNMJMC.Add(PHINQNMFEHC.LCFNDMLMJKF[n]);
			HQOONBPDFHO.Add(fnbdghbqphj);
		}
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x000A4A4C File Offset: 0x000A2C4C
	private void HNLENFEDPIC(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		Texture goihjqnmmjd = this.GOIHJQNMMJD;
		if (goihjqnmmjd == null)
		{
			return;
		}
		Vector4 vector = this.FMGJBHHNDPC * this.FNMFIPNGENE;
		if (vector.x == 0f && vector.y == 0f && vector.z == 0f && vector.w == 0f)
		{
			this.NPNPGQKKKJM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
			return;
		}
		Color fnbdghbqphj = this.FNBDGHBQPHJ;
		Vector4 bceppkgmnfe = this.BCEPPKGMNFE;
		Vector2 a = new Vector2(this.MGOGCLMNMME.width * (float)goihjqnmmjd.width, this.MGOGCLMNMME.height * (float)goihjqnmmjd.height);
		a *= this.FNMFIPNGENE;
		if (a.x < 1f)
		{
			a.x = 1f;
		}
		if (a.y < 1f)
		{
			a.y = 1f;
		}
		PHINQNMFEHC.HJKPELHQJPL[0].x = bceppkgmnfe.x;
		PHINQNMFEHC.HJKPELHQJPL[0].y = bceppkgmnfe.y;
		PHINQNMFEHC.HJKPELHQJPL[3].x = bceppkgmnfe.z;
		PHINQNMFEHC.HJKPELHQJPL[3].y = bceppkgmnfe.w;
		if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Horizontally)
		{
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
			{
				PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x + vector.x;
				PHINQNMFEHC.HJKPELHQJPL[2].x = PHINQNMFEHC.HJKPELHQJPL[3].x - vector.z;
				PHINQNMFEHC.LCFNDMLMJKF[0].x = this.JFQBMCELJHC.xMin;
				PHINQNMFEHC.LCFNDMLMJKF[1].x = this.MGOGCLMNMME.xMin;
				PHINQNMFEHC.LCFNDMLMJKF[2].x = this.MGOGCLMNMME.xMax;
				PHINQNMFEHC.LCFNDMLMJKF[3].x = this.JFQBMCELJHC.xMax;
				goto IL_2D6;
			}
		}
		PHINQNMFEHC.HJKPELHQJPL[1].x = PHINQNMFEHC.HJKPELHQJPL[0].x + vector.z;
		PHINQNMFEHC.HJKPELHQJPL[2].x = PHINQNMFEHC.HJKPELHQJPL[3].x - vector.x;
		PHINQNMFEHC.LCFNDMLMJKF[3].x = this.JFQBMCELJHC.xMin;
		PHINQNMFEHC.LCFNDMLMJKF[2].x = this.MGOGCLMNMME.xMin;
		PHINQNMFEHC.LCFNDMLMJKF[1].x = this.MGOGCLMNMME.xMax;
		PHINQNMFEHC.LCFNDMLMJKF[0].x = this.JFQBMCELJHC.xMax;
		IL_2D6:
		if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Vertically)
		{
			if (this.mFlip != PHINQNMFEHC.OOPCCQKNGOC.Both)
			{
				PHINQNMFEHC.HJKPELHQJPL[1].y = PHINQNMFEHC.HJKPELHQJPL[0].y + vector.y;
				PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[3].y - vector.w;
				PHINQNMFEHC.LCFNDMLMJKF[0].y = this.JFQBMCELJHC.yMin;
				PHINQNMFEHC.LCFNDMLMJKF[1].y = this.MGOGCLMNMME.yMin;
				PHINQNMFEHC.LCFNDMLMJKF[2].y = this.MGOGCLMNMME.yMax;
				PHINQNMFEHC.LCFNDMLMJKF[3].y = this.JFQBMCELJHC.yMax;
				goto IL_46D;
			}
		}
		PHINQNMFEHC.HJKPELHQJPL[1].y = PHINQNMFEHC.HJKPELHQJPL[0].y + vector.w;
		PHINQNMFEHC.HJKPELHQJPL[2].y = PHINQNMFEHC.HJKPELHQJPL[3].y - vector.y;
		PHINQNMFEHC.LCFNDMLMJKF[3].y = this.JFQBMCELJHC.yMin;
		PHINQNMFEHC.LCFNDMLMJKF[2].y = this.MGOGCLMNMME.yMin;
		PHINQNMFEHC.LCFNDMLMJKF[1].y = this.MGOGCLMNMME.yMax;
		PHINQNMFEHC.LCFNDMLMJKF[0].y = this.JFQBMCELJHC.yMax;
		IL_46D:
		for (int i = 0; i < 3; i++)
		{
			int num = i + 1;
			for (int j = 0; j < 3; j++)
			{
				if (this.MMNMEHKBLOH != PHINQNMFEHC.OGEQPBCECPM.Invisible || i != 1 || j != 1)
				{
					int num2 = j + 1;
					if (i == 1 && j == 1)
					{
						if (this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Tiled)
						{
							float x = PHINQNMFEHC.HJKPELHQJPL[i].x;
							float x2 = PHINQNMFEHC.HJKPELHQJPL[num].x;
							float y = PHINQNMFEHC.HJKPELHQJPL[j].y;
							float y2 = PHINQNMFEHC.HJKPELHQJPL[num2].y;
							float x3 = PHINQNMFEHC.LCFNDMLMJKF[i].x;
							float y3 = PHINQNMFEHC.LCFNDMLMJKF[j].y;
							for (float num3 = y; num3 < y2; num3 += a.y)
							{
								float num4 = x;
								float num5 = PHINQNMFEHC.LCFNDMLMJKF[num2].y;
								float num6 = num3 + a.y;
								if (num6 > y2)
								{
									num5 = Mathf.Lerp(y3, num5, (y2 - num3) / a.y);
									num6 = y2;
								}
								while (num4 < x2)
								{
									float num7 = num4 + a.x;
									float num8 = PHINQNMFEHC.LCFNDMLMJKF[num].x;
									if (num7 > x2)
									{
										num8 = Mathf.Lerp(x3, num8, (x2 - num4) / a.x);
										num7 = x2;
									}
									PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num4, num7, num3, num6, x3, num8, y3, num5, fnbdghbqphj);
									num4 += a.x;
								}
							}
						}
						else if (this.MMNMEHKBLOH == PHINQNMFEHC.OGEQPBCECPM.Sliced)
						{
							PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[j].y, PHINQNMFEHC.HJKPELHQJPL[num2].y, PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[j].y, PHINQNMFEHC.LCFNDMLMJKF[num2].y, fnbdghbqphj);
						}
					}
					else if (i == 1)
					{
						if ((j == 0 && this.NEOHDFGQHCD == PHINQNMFEHC.OGEQPBCECPM.Tiled) || (j == 2 && this.QOOOQQOMCKD == PHINQNMFEHC.OGEQPBCECPM.Tiled))
						{
							float x4 = PHINQNMFEHC.HJKPELHQJPL[i].x;
							float x5 = PHINQNMFEHC.HJKPELHQJPL[num].x;
							float y4 = PHINQNMFEHC.HJKPELHQJPL[j].y;
							float y5 = PHINQNMFEHC.HJKPELHQJPL[num2].y;
							float x6 = PHINQNMFEHC.LCFNDMLMJKF[i].x;
							float y6 = PHINQNMFEHC.LCFNDMLMJKF[j].y;
							float y7 = PHINQNMFEHC.LCFNDMLMJKF[num2].y;
							for (float num9 = x4; num9 < x5; num9 += a.x)
							{
								float num10 = num9 + a.x;
								float num11 = PHINQNMFEHC.LCFNDMLMJKF[num].x;
								if (num10 > x5)
								{
									num11 = Mathf.Lerp(x6, num11, (x5 - num9) / a.x);
									num10 = x5;
								}
								PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num9, num10, y4, y5, x6, num11, y6, y7, fnbdghbqphj);
							}
						}
						else if ((j == 0 && this.NEOHDFGQHCD != PHINQNMFEHC.OGEQPBCECPM.Invisible) || (j == 2 && this.QOOOQQOMCKD != PHINQNMFEHC.OGEQPBCECPM.Invisible))
						{
							PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[j].y, PHINQNMFEHC.HJKPELHQJPL[num2].y, PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[j].y, PHINQNMFEHC.LCFNDMLMJKF[num2].y, fnbdghbqphj);
						}
					}
					else if (j == 1)
					{
						if ((i == 0 && this.MHIPDHCDFKF == PHINQNMFEHC.OGEQPBCECPM.Tiled) || (i == 2 && this.EFFMOOFFBHB == PHINQNMFEHC.OGEQPBCECPM.Tiled))
						{
							float x7 = PHINQNMFEHC.HJKPELHQJPL[i].x;
							float x8 = PHINQNMFEHC.HJKPELHQJPL[num].x;
							float y8 = PHINQNMFEHC.HJKPELHQJPL[j].y;
							float y9 = PHINQNMFEHC.HJKPELHQJPL[num2].y;
							float x9 = PHINQNMFEHC.LCFNDMLMJKF[i].x;
							float x10 = PHINQNMFEHC.LCFNDMLMJKF[num].x;
							float y10 = PHINQNMFEHC.LCFNDMLMJKF[j].y;
							for (float num12 = y8; num12 < y9; num12 += a.y)
							{
								float num13 = PHINQNMFEHC.LCFNDMLMJKF[num2].y;
								float num14 = num12 + a.y;
								if (num14 > y9)
								{
									num13 = Mathf.Lerp(y10, num13, (y9 - num12) / a.y);
									num14 = y9;
								}
								PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, x7, x8, num12, num14, x9, x10, y10, num13, fnbdghbqphj);
							}
						}
						else if ((i == 0 && this.MHIPDHCDFKF != PHINQNMFEHC.OGEQPBCECPM.Invisible) || (i == 2 && this.EFFMOOFFBHB != PHINQNMFEHC.OGEQPBCECPM.Invisible))
						{
							PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[j].y, PHINQNMFEHC.HJKPELHQJPL[num2].y, PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[j].y, PHINQNMFEHC.LCFNDMLMJKF[num2].y, fnbdghbqphj);
						}
					}
					else if ((j == 0 && this.NEOHDFGQHCD != PHINQNMFEHC.OGEQPBCECPM.Invisible) || (j == 2 && this.QOOOQQOMCKD != PHINQNMFEHC.OGEQPBCECPM.Invisible) || (i == 0 && this.MHIPDHCDFKF != PHINQNMFEHC.OGEQPBCECPM.Invisible) || (i == 2 && this.EFFMOOFFBHB != PHINQNMFEHC.OGEQPBCECPM.Invisible))
					{
						PHINQNMFEHC.NBINLNQEIIJ(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, PHINQNMFEHC.HJKPELHQJPL[i].x, PHINQNMFEHC.HJKPELHQJPL[num].x, PHINQNMFEHC.HJKPELHQJPL[j].y, PHINQNMFEHC.HJKPELHQJPL[num2].y, PHINQNMFEHC.LCFNDMLMJKF[i].x, PHINQNMFEHC.LCFNDMLMJKF[num].x, PHINQNMFEHC.LCFNDMLMJKF[j].y, PHINQNMFEHC.LCFNDMLMJKF[num2].y, fnbdghbqphj);
					}
				}
			}
		}
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x000A559C File Offset: 0x000A379C
	private static bool JNDGJCCMCOO(Vector2[] NCEJDGLPCJC, Vector2[] JPGKPFKIGMH, float OQEOFMPMFBB, bool DELNOHEFELI, int KGQKHLFFMEG)
	{
		if (OQEOFMPMFBB < 0.001f)
		{
			return false;
		}
		if ((KGQKHLFFMEG & 1) == 1)
		{
			DELNOHEFELI = !DELNOHEFELI;
		}
		if (!DELNOHEFELI && OQEOFMPMFBB > 0.999f)
		{
			return true;
		}
		float num = Mathf.Clamp01(OQEOFMPMFBB);
		if (DELNOHEFELI)
		{
			num = 1f - num;
		}
		num *= 1.57079637f;
		float cgcgoedclqe = Mathf.Cos(num);
		float iqlkfmhbqfd = Mathf.Sin(num);
		PHINQNMFEHC.JNDGJCCMCOO(NCEJDGLPCJC, cgcgoedclqe, iqlkfmhbqfd, DELNOHEFELI, KGQKHLFFMEG);
		PHINQNMFEHC.JNDGJCCMCOO(JPGKPFKIGMH, cgcgoedclqe, iqlkfmhbqfd, DELNOHEFELI, KGQKHLFFMEG);
		return true;
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x000A560C File Offset: 0x000A380C
	private static void JNDGJCCMCOO(Vector2[] NCEJDGLPCJC, float CGCGOEDCLQE, float IQLKFMHBQFD, bool DELNOHEFELI, int KGQKHLFFMEG)
	{
		int num = JNNGOIIKENH.FNNIKCNKDIN(KGQKHLFFMEG + 1, 4);
		int num2 = JNNGOIIKENH.FNNIKCNKDIN(KGQKHLFFMEG + 2, 4);
		int num3 = JNNGOIIKENH.FNNIKCNKDIN(KGQKHLFFMEG + 3, 4);
		if ((KGQKHLFFMEG & 1) == 1)
		{
			if (IQLKFMHBQFD > CGCGOEDCLQE)
			{
				CGCGOEDCLQE /= IQLKFMHBQFD;
				IQLKFMHBQFD = 1f;
				if (DELNOHEFELI)
				{
					NCEJDGLPCJC[num].x = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].x, NCEJDGLPCJC[num2].x, CGCGOEDCLQE);
					NCEJDGLPCJC[num2].x = NCEJDGLPCJC[num].x;
				}
			}
			else if (CGCGOEDCLQE > IQLKFMHBQFD)
			{
				IQLKFMHBQFD /= CGCGOEDCLQE;
				CGCGOEDCLQE = 1f;
				if (!DELNOHEFELI)
				{
					NCEJDGLPCJC[num2].y = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].y, NCEJDGLPCJC[num2].y, IQLKFMHBQFD);
					NCEJDGLPCJC[num3].y = NCEJDGLPCJC[num2].y;
				}
			}
			else
			{
				CGCGOEDCLQE = 1f;
				IQLKFMHBQFD = 1f;
			}
			if (!DELNOHEFELI)
			{
				NCEJDGLPCJC[num3].x = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].x, NCEJDGLPCJC[num2].x, CGCGOEDCLQE);
			}
			else
			{
				NCEJDGLPCJC[num].y = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].y, NCEJDGLPCJC[num2].y, IQLKFMHBQFD);
			}
		}
		else
		{
			if (CGCGOEDCLQE > IQLKFMHBQFD)
			{
				IQLKFMHBQFD /= CGCGOEDCLQE;
				CGCGOEDCLQE = 1f;
				if (!DELNOHEFELI)
				{
					NCEJDGLPCJC[num].y = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].y, NCEJDGLPCJC[num2].y, IQLKFMHBQFD);
					NCEJDGLPCJC[num2].y = NCEJDGLPCJC[num].y;
				}
			}
			else if (IQLKFMHBQFD > CGCGOEDCLQE)
			{
				CGCGOEDCLQE /= IQLKFMHBQFD;
				IQLKFMHBQFD = 1f;
				if (DELNOHEFELI)
				{
					NCEJDGLPCJC[num2].x = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].x, NCEJDGLPCJC[num2].x, CGCGOEDCLQE);
					NCEJDGLPCJC[num3].x = NCEJDGLPCJC[num2].x;
				}
			}
			else
			{
				CGCGOEDCLQE = 1f;
				IQLKFMHBQFD = 1f;
			}
			if (DELNOHEFELI)
			{
				NCEJDGLPCJC[num3].y = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].y, NCEJDGLPCJC[num2].y, IQLKFMHBQFD);
			}
			else
			{
				NCEJDGLPCJC[num].x = Mathf.Lerp(NCEJDGLPCJC[KGQKHLFFMEG].x, NCEJDGLPCJC[num2].x, CGCGOEDCLQE);
			}
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x000A5880 File Offset: 0x000A3A80
	private static void NBINLNQEIIJ(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO, float OLPDNBOLDEB, float FGDLHECKNII, float KIOPQEGKHFF, float EIPHNOBNGQB, float PJGCOJJNOFD, float DMPJPPBNBOF, float INKJPKLDGNQ, float ODGIJKKGHQI, Color NHGMOKGKOJN)
	{
		EQINHIFFOGG.Add(new Vector3(OLPDNBOLDEB, KIOPQEGKHFF));
		EQINHIFFOGG.Add(new Vector3(OLPDNBOLDEB, EIPHNOBNGQB));
		EQINHIFFOGG.Add(new Vector3(FGDLHECKNII, EIPHNOBNGQB));
		EQINHIFFOGG.Add(new Vector3(FGDLHECKNII, KIOPQEGKHFF));
		PICFCJNMJMC.Add(new Vector2(PJGCOJJNOFD, INKJPKLDGNQ));
		PICFCJNMJMC.Add(new Vector2(PJGCOJJNOFD, ODGIJKKGHQI));
		PICFCJNMJMC.Add(new Vector2(DMPJPPBNBOF, ODGIJKKGHQI));
		PICFCJNMJMC.Add(new Vector2(DMPJPPBNBOF, INKJPKLDGNQ));
		HQOONBPDFHO.Add(NHGMOKGKOJN);
		HQOONBPDFHO.Add(NHGMOKGKOJN);
		HQOONBPDFHO.Add(NHGMOKGKOJN);
		HQOONBPDFHO.Add(NHGMOKGKOJN);
	}

	// Token: 0x04000437 RID: 1079
	[SerializeField]
	[HideInInspector]
	protected PHINQNMFEHC.OFPCLCEBHFL mType;

	// Token: 0x04000438 RID: 1080
	[SerializeField]
	[HideInInspector]
	protected PHINQNMFEHC.MQIMDDINNEQ mFillDirection = PHINQNMFEHC.MQIMDDINNEQ.Radial360;

	// Token: 0x04000439 RID: 1081
	[Range(0f, 1f)]
	[SerializeField]
	[HideInInspector]
	protected float mFillAmount = 1f;

	// Token: 0x0400043A RID: 1082
	[HideInInspector]
	[SerializeField]
	protected bool mInvert;

	// Token: 0x0400043B RID: 1083
	[SerializeField]
	[HideInInspector]
	protected PHINQNMFEHC.OOPCCQKNGOC mFlip;

	// Token: 0x0400043C RID: 1084
	[SerializeField]
	[HideInInspector]
	protected bool mApplyGradient;

	// Token: 0x0400043D RID: 1085
	[SerializeField]
	[HideInInspector]
	protected Color mGradientTop = Color.white;

	// Token: 0x0400043E RID: 1086
	[HideInInspector]
	[SerializeField]
	protected Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	// Token: 0x0400043F RID: 1087
	[NonSerialized]
	private Rect MGOGCLMNMME = default(Rect);

	// Token: 0x04000440 RID: 1088
	[NonSerialized]
	private Rect JFQBMCELJHC = default(Rect);

	// Token: 0x04000441 RID: 1089
	public PHINQNMFEHC.OGEQPBCECPM MMNMEHKBLOH = PHINQNMFEHC.OGEQPBCECPM.Sliced;

	// Token: 0x04000442 RID: 1090
	public PHINQNMFEHC.OGEQPBCECPM MHIPDHCDFKF = PHINQNMFEHC.OGEQPBCECPM.Sliced;

	// Token: 0x04000443 RID: 1091
	public PHINQNMFEHC.OGEQPBCECPM EFFMOOFFBHB = PHINQNMFEHC.OGEQPBCECPM.Sliced;

	// Token: 0x04000444 RID: 1092
	public PHINQNMFEHC.OGEQPBCECPM NEOHDFGQHCD = PHINQNMFEHC.OGEQPBCECPM.Sliced;

	// Token: 0x04000445 RID: 1093
	public PHINQNMFEHC.OGEQPBCECPM QOOOQQOMCKD = PHINQNMFEHC.OGEQPBCECPM.Sliced;

	// Token: 0x04000446 RID: 1094
	protected static Vector2[] HJKPELHQJPL = new Vector2[4];

	// Token: 0x04000447 RID: 1095
	protected static Vector2[] LCFNDMLMJKF = new Vector2[4];

	// Token: 0x020000B2 RID: 178
	public enum OFPCLCEBHFL
	{
		// Token: 0x04000449 RID: 1097
		Simple,
		// Token: 0x0400044A RID: 1098
		Sliced,
		// Token: 0x0400044B RID: 1099
		Tiled,
		// Token: 0x0400044C RID: 1100
		Filled,
		// Token: 0x0400044D RID: 1101
		Advanced
	}

	// Token: 0x020000B3 RID: 179
	public enum MQIMDDINNEQ
	{
		// Token: 0x0400044F RID: 1103
		Horizontal,
		// Token: 0x04000450 RID: 1104
		Vertical,
		// Token: 0x04000451 RID: 1105
		Radial90,
		// Token: 0x04000452 RID: 1106
		Radial180,
		// Token: 0x04000453 RID: 1107
		Radial360
	}

	// Token: 0x020000B4 RID: 180
	public enum OGEQPBCECPM
	{
		// Token: 0x04000455 RID: 1109
		Invisible,
		// Token: 0x04000456 RID: 1110
		Sliced,
		// Token: 0x04000457 RID: 1111
		Tiled
	}

	// Token: 0x020000B5 RID: 181
	public enum OOPCCQKNGOC
	{
		// Token: 0x04000459 RID: 1113
		Nothing,
		// Token: 0x0400045A RID: 1114
		Horizontally,
		// Token: 0x0400045B RID: 1115
		Vertically,
		// Token: 0x0400045C RID: 1116
		Both
	}
}
