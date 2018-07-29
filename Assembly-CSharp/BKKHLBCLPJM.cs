using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000111 RID: 273
[AddComponentMenu("NGUI/UI/NGUI Label")]
[ExecuteInEditMode]
public class BKKHLBCLPJM : ENFMCDNLEQQ
{
	// Token: 0x06001EC0 RID: 7872 RVA: 0x00010DC1 File Offset: 0x0000EFC1
	private void LMGQBPNOLPF()
	{
		if (this.IOCQLIKGMEO != null)
		{
			this.LJGQIHIPOMD();
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00010DD7 File Offset: 0x0000EFD7
	// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00011681 File Offset: 0x0000F881
	public KGKLCNDOLMP NFIBPOJMOCQ
	{
		get
		{
			return this.mFont;
		}
		set
		{
			if (this.mFont != value)
			{
				base.QFQNGQHLFNE();
				this.mFont = value;
				this.mTrueTypeFont = null;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x000CC438 File Offset: 0x000CA638
	public string NKKFKOQQGDE
	{
		get
		{
			if (this.HCNHMMPBGQN != this.mWidth || this.OIKLGOPLNEO != this.mHeight)
			{
				this.HCNHMMPBGQN = this.mWidth;
				this.OIKLGOPLNEO = this.mHeight;
				this.FHQDQEQMKOK = true;
			}
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return this.LHFFFGFPIBH;
		}
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000CC494 File Offset: 0x000CA694
	public virtual Material NQPCNQHIGKP()
	{
		if (this.mMat != null)
		{
			return this.mMat;
		}
		if (this.mFont != null)
		{
			return this.mFont.PPLIPCEHGNM;
		}
		if (this.mTrueTypeFont != null)
		{
			return this.mTrueTypeFont.material;
		}
		return null;
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00010DDF File Offset: 0x0000EFDF
	public int EPCEBKNONLF
	{
		get
		{
			return (!(this.OFHEQIDHQOP != null)) ? ((!(this.mFont != null)) ? 16 : this.mFont.BDHMPMFLMHI) : this.mFontSize;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x000CC4EC File Offset: 0x000CA6EC
	public string CDBBENHQGIJ
	{
		get
		{
			if (!string.IsNullOrEmpty(this.mText))
			{
				if (this.mModifier == BKKHLBCLPJM.IFMLQGIMMJO.None)
				{
					return this.mText;
				}
				if (this.mModifier == BKKHLBCLPJM.IFMLQGIMMJO.ToLowercase)
				{
					return this.mText.ToLower();
				}
				if (this.mModifier == BKKHLBCLPJM.IFMLQGIMMJO.ToUppercase)
				{
					return this.mText.ToUpper();
				}
				if (this.mModifier == BKKHLBCLPJM.IFMLQGIMMJO.Custom && this.QONMMIEFJLB != null)
				{
					return this.QONMMIEFJLB(this.mText);
				}
			}
			return this.mText;
		}
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x00010E14 File Offset: 0x0000F014
	public string MBIMPOFHJQF(Vector3 PHCMBMCKQDC)
	{
		return this.FDPHEKIEQFN(this.LJBKLGBQHJI(PHCMBMCKQDC, true));
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000CC56C File Offset: 0x000CA76C
	public int EMNKCMHDLHO(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 5 > text.Length)
			{
				JKBFLJQHMCE -= 6;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 0;
				}
				if (text.LastIndexOf("[/pok]", JKBFLJQHMCE) == -1)
				{
					return -1;
				}
			}
			int num;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'p' && text[JKBFLJQHMCE + 2] == 'o' && text[JKBFLJQHMCE + 3] == 'k' && text[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = text.LastIndexOf("[pok=", JKBFLJQHMCE + 4);
			}
			if (num == -1)
			{
				return -1;
			}
			num += 5;
			int num2 = text.IndexOf("]", num);
			if (num2 == -1)
			{
				return -1;
			}
			int num3 = text.IndexOf("[/pok]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3 + 5)
			{
				return num - 4;
			}
		}
		return -1;
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00010E24 File Offset: 0x0000F024
	// (set) Token: 0x06001F1B RID: 7963 RVA: 0x000CD584 File Offset: 0x000CB784
	public UnityEngine.Object IOCQLIKGMEO
	{
		get
		{
			return this.mFont ?? this.mTrueTypeFont;
		}
		set
		{
			KGKLCNDOLMP kgklcndolmp = value as KGKLCNDOLMP;
			if (kgklcndolmp != null)
			{
				this.NFIBPOJMOCQ = kgklcndolmp;
			}
			else
			{
				this.OFHEQIDHQOP = (value as Font);
			}
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00010E36 File Offset: 0x0000F036
	// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x00011107 File Offset: 0x0000F307
	public bool IOCILKPHDHH
	{
		get
		{
			return this.mEncoding;
		}
		set
		{
			if (this.mEncoding != value)
			{
				this.mEncoding = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00010E3E File Offset: 0x0000F03E
	public Color OHJDKQHMOBH()
	{
		return this.mGradientTop;
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06001F6B RID: 8043 RVA: 0x0001101B File Offset: 0x0000F21B
	// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00010E46 File Offset: 0x0000F046
	public int OFBGHIBHBLI
	{
		get
		{
			return this.mMaxLineCount;
		}
		set
		{
			if (this.mMaxLineCount != value)
			{
				this.mMaxLineCount = Mathf.Max(value, 0);
				this.HDBQMJJKQME = true;
				if (this.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent)
				{
					this.IQFQEOFBQKM();
				}
			}
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00011467 File Offset: 0x0000F667
	// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00010E73 File Offset: 0x0000F073
	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	public bool PDMPNIPGMHL
	{
		get
		{
			return this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
		}
		set
		{
			if (value)
			{
				this.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
			}
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00010E7F File Offset: 0x0000F07F
	// (set) Token: 0x06001F04 RID: 7940 RVA: 0x000110AD File Offset: 0x0000F2AD
	public int FQPCHEGNMMO
	{
		get
		{
			return this.mOverflowWidth;
		}
		set
		{
			if (this.mOverflowWidth != value)
			{
				this.mOverflowWidth = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x00010E87 File Offset: 0x0000F087
	public virtual void KGPFBNMCBIC()
	{
		this.HDBQMJJKQME = false;
		base.NPCECPIOPCB();
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00010E96 File Offset: 0x0000F096
	public void CEMGPDFFIDH(Color BGBMIEJJQKC)
	{
		if (this.mGradientTop != BGBMIEJJQKC)
		{
			this.mGradientTop = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x00010EBB File Offset: 0x0000F0BB
	public int FMCOIMLKGQN()
	{
		if (this.mEffectStyle == BKKHLBCLPJM.GIMCHOOBMML.Shadow)
		{
			return 4;
		}
		if (this.mEffectStyle == (BKKHLBCLPJM.GIMCHOOBMML)7)
		{
			return 0;
		}
		if (this.mEffectStyle == (BKKHLBCLPJM.GIMCHOOBMML)6)
		{
			return -8;
		}
		return 1;
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00010EE0 File Offset: 0x0000F0E0
	// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x00011023 File Offset: 0x0000F223
	public bool OGGCMIKJGLD
	{
		get
		{
			return this.mOverflowEllipsis;
		}
		set
		{
			if (this.mOverflowEllipsis != value)
			{
				this.mOverflowEllipsis = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000CC658 File Offset: 0x000CA858
	protected override void NHONJJHBBEN()
	{
		base.NHONJJHBBEN();
		if (this.mLineWidth > 0f)
		{
			this.mMaxLineWidth = Mathf.RoundToInt(this.mLineWidth);
			this.mLineWidth = 0f;
		}
		if (!this.mMultiline)
		{
			this.mMaxLineCount = 1;
			this.mMultiline = true;
		}
		this.JHKLMMDCLQG = (this.PPLIPCEHGNM != null && this.PPLIPCEHGNM.shader != null && this.PPLIPCEHGNM.shader.name.Contains("Premultiplied"));
		this.LMGQBPNOLPF();
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00010EE8 File Offset: 0x0000F0E8
	public override Vector3[] PMCNQICHCLE
	{
		get
		{
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return base.PMCNQICHCLE;
		}
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00010EFE File Offset: 0x0000F0FE
	public virtual Vector3[] NILCQFHDDOD()
	{
		if (this.HDBQMJJKQME)
		{
			this.LJGQIHIPOMD();
		}
		return base.PIGMLPNGMNO;
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000115CF File Offset: 0x0000F7CF
	// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x00010F14 File Offset: 0x0000F114
	public int MOQHNNIINFL
	{
		get
		{
			return this.mSpacingX;
		}
		set
		{
			if (this.mSpacingX != value)
			{
				this.mSpacingX = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x00010F2C File Offset: 0x0000F12C
	public void NNNLGMMIHMH(int BGBMIEJJQKC)
	{
		base.KJGMGPCEJJD = BGBMIEJJQKC;
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00010F35 File Offset: 0x0000F135
	// (set) Token: 0x06001F07 RID: 7943 RVA: 0x000111B1 File Offset: 0x0000F3B1
	public bool JPKFNEQCQCP
	{
		get
		{
			return this.mApplyGradient;
		}
		set
		{
			if (this.mApplyGradient != value)
			{
				this.mApplyGradient = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00010F3D File Offset: 0x0000F13D
	// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00010FBC File Offset: 0x0000F1BC
	public BKKHLBCLPJM.IFMLQGIMMJO FMPOLMDPCNL
	{
		get
		{
			return this.mModifier;
		}
		set
		{
			if (this.mModifier != value)
			{
				this.mModifier = value;
				this.NPCECPIOPCB();
				this.LMGQBPNOLPF();
			}
		}
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000CC6F4 File Offset: 0x000CA8F4
	public Vector2 LCJLEJKIEHP(List<Vector3> EQINHIFFOGG, int GBEBKHGGPKM)
	{
		Vector2 pfpekeldlcn = base.PFPEKELDLCN;
		float num = Mathf.Lerp(1755f, (float)(-(float)this.mWidth), pfpekeldlcn.x);
		float num2 = Mathf.Lerp((float)this.mHeight, 694f, pfpekeldlcn.y) + Mathf.Lerp(this.NCDNEEHPMFB.y - (float)this.mHeight, 120f, pfpekeldlcn.y);
		num = Mathf.Round(num);
		num2 = Mathf.Round(num2);
		int i = GBEBKHGGPKM;
		int count = EQINHIFFOGG.Count;
		while (i < count)
		{
			Vector3 value = EQINHIFFOGG[i];
			value.x += num;
			value.y += num2;
			EQINHIFFOGG[i] = value;
			i++;
		}
		return new Vector2(num, num2);
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x000CC7C0 File Offset: 0x000CA9C0
	public Vector2 DQPPLOMKFMO(List<Vector3> EQINHIFFOGG, int GBEBKHGGPKM)
	{
		Vector2 pfpekeldlcn = base.PFPEKELDLCN;
		float num = Mathf.Lerp(1168f, (float)(-(float)this.mWidth), pfpekeldlcn.x);
		float num2 = Mathf.Lerp((float)this.mHeight, 1329f, pfpekeldlcn.y) + Mathf.Lerp(this.NCDNEEHPMFB.y - (float)this.mHeight, 1617f, pfpekeldlcn.y);
		num = Mathf.Round(num);
		num2 = Mathf.Round(num2);
		int i = GBEBKHGGPKM;
		int count = EQINHIFFOGG.Count;
		while (i < count)
		{
			Vector3 value = EQINHIFFOGG[i];
			value.x += num;
			value.y += num2;
			EQINHIFFOGG[i] = value;
			i += 0;
		}
		return new Vector2(num, num2);
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00010F45 File Offset: 0x0000F145
	public string NEDOCKOEFPF(Vector2 PNNOLPKBHNQ)
	{
		return this.PCPNQDENHMO(this.LJBKLGBQHJI(PNNOLPKBHNQ, true));
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00010F85 File Offset: 0x0000F185
	// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0001134A File Offset: 0x0000F54A
	public bool QJJLOHHFQNC
	{
		get
		{
			return this.mMaxLineCount != 1;
		}
		set
		{
			if (this.mMaxLineCount != 1 != value)
			{
				this.mMaxLineCount = ((!value) ? 1 : 0);
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x00010F93 File Offset: 0x0000F193
	public string QCPEGBEJFCK(Vector2 PNNOLPKBHNQ)
	{
		return this.DJJPKEHILBG(this.LJBKLGBQHJI(PNNOLPKBHNQ, true));
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000113D4 File Offset: 0x0000F5D4
	// (set) Token: 0x06001EDF RID: 7903 RVA: 0x000CC88C File Offset: 0x000CAA8C
	public Font OFHEQIDHQOP
	{
		get
		{
			if (this.mTrueTypeFont != null)
			{
				return this.mTrueTypeFont;
			}
			return (!(this.mFont != null)) ? null : this.mFont.KDDNGBFFFJL;
		}
		set
		{
			if (this.mTrueTypeFont != value)
			{
				this.FIQLOMBJOCD(null);
				base.QFQNGQHLFNE();
				this.mTrueTypeFont = value;
				this.HDBQMJJKQME = true;
				this.mFont = null;
				this.FIQLOMBJOCD(value);
				this.LMGQBPNOLPF();
				if (this.QIDEHMIOMOJ != null)
				{
					base.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00010FA3 File Offset: 0x0000F1A3
	public float LKLGLCMCMMO
	{
		get
		{
			return (!this.mUseFloatSpacing) ? ((float)this.mSpacingY) : this.mFloatSpacingY;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0001123F File Offset: 0x0000F43F
	// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00010FDA File Offset: 0x0000F1DA
	private bool HDBQMJJKQME
	{
		get
		{
			return this.FHQDQEQMKOK;
		}
		set
		{
			if (value)
			{
				this.LHQDFLPFGME = true;
				this.FHQDQEQMKOK = true;
			}
			else
			{
				this.FHQDQEQMKOK = false;
			}
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00011542 File Offset: 0x0000F742
	// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x00010FF6 File Offset: 0x0000F1F6
	public float CQNGMJCMGDE
	{
		get
		{
			return this.mFloatSpacingX;
		}
		set
		{
			if (!Mathf.Approximately(this.mFloatSpacingX, value))
			{
				this.mFloatSpacingX = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00011013 File Offset: 0x0000F213
	// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00011613 File Offset: 0x0000F813
	[Obsolete("Use 'height' instead")]
	public int JMCQOCQOLIG
	{
		get
		{
			return base.DFKQMMIQDOO;
		}
		set
		{
			base.DFKQMMIQDOO = value;
		}
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x000CC8EC File Offset: 0x000CAAEC
	public Vector2 CKBEDCLMENE(List<Vector3> EQINHIFFOGG, int GBEBKHGGPKM)
	{
		Vector2 pfpekeldlcn = base.PFPEKELDLCN;
		float num = Mathf.Lerp(0f, (float)(-(float)this.mWidth), pfpekeldlcn.x);
		float num2 = Mathf.Lerp((float)this.mHeight, 0f, pfpekeldlcn.y) + Mathf.Lerp(this.NCDNEEHPMFB.y - (float)this.mHeight, 0f, pfpekeldlcn.y);
		num = Mathf.Round(num);
		num2 = Mathf.Round(num2);
		int i = GBEBKHGGPKM;
		int count = EQINHIFFOGG.Count;
		while (i < count)
		{
			Vector3 value = EQINHIFFOGG[i];
			value.x += num;
			value.y += num2;
			EQINHIFFOGG[i] = value;
			i++;
		}
		return new Vector2(num, num2);
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x0001101B File Offset: 0x0000F21B
	public int NGKMOMPQQPQ()
	{
		return this.mMaxLineCount;
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06001F16 RID: 7958 RVA: 0x0001128D File Offset: 0x0000F48D
	// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x0001103B File Offset: 0x0000F23B
	[Obsolete("Use UILabel.bitmapFont instead")]
	public KGKLCNDOLMP NKKDJJOKQDK
	{
		get
		{
			return this.NFIBPOJMOCQ;
		}
		set
		{
			this.NFIBPOJMOCQ = value;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00011044 File Offset: 0x0000F244
	public int PQPGLDGJCOO
	{
		get
		{
			if (this.mEffectStyle == BKKHLBCLPJM.GIMCHOOBMML.Shadow)
			{
				return 2;
			}
			if (this.mEffectStyle == BKKHLBCLPJM.GIMCHOOBMML.Outline)
			{
				return 5;
			}
			if (this.mEffectStyle == BKKHLBCLPJM.GIMCHOOBMML.Outline8)
			{
				return 9;
			}
			return 1;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06001F42 RID: 8002 RVA: 0x000114AB File Offset: 0x0000F6AB
	// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00011069 File Offset: 0x0000F269
	public Color QEQOQOOCEEN
	{
		get
		{
			return this.mGradientBottom;
		}
		set
		{
			if (this.mGradientBottom != value)
			{
				this.mGradientBottom = value;
				if (this.mApplyGradient)
				{
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000CC9B8 File Offset: 0x000CABB8
	public override void PIEBLFFMJEH(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO)
	{
		if (!this.INEMKLPCLOP)
		{
			return;
		}
		int num = EQINHIFFOGG.Count;
		Color color = base.CEGFBBHMKOE;
		color.a = this.NHCNEDEEONK;
		if (this.mFont != null && this.mFont.QBLKBOJQMDL)
		{
			color = IKBQNBHOJJB.BQCGKIDLIOC(color);
		}
		string nkkfkoqqgde = this.NKKFKOQQGDE;
		int count = EQINHIFFOGG.Count;
		this.KMLKNBFNOIC();
		JGDHIPBGCFP.BLEDJGLIIPF = color;
		JGDHIPBGCFP.JBCCFGJGOPH(nkkfkoqqgde, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		JGDHIPBGCFP.NFIBPOJMOCQ = null;
		JGDHIPBGCFP.KDDNGBFFFJL = null;
		Vector2 vector = this.CKBEDCLMENE(EQINHIFFOGG, count);
		if (this.mFont != null && this.mFont.CHLEEPHFEGC)
		{
			return;
		}
		if (this.LMHJBBOENQB != BKKHLBCLPJM.GIMCHOOBMML.None)
		{
			int count2 = EQINHIFFOGG.Count;
			vector.x = this.mEffectDistance.x;
			vector.y = this.mEffectDistance.y;
			this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, vector.x, -vector.y);
			if (this.LMHJBBOENQB == BKKHLBCLPJM.GIMCHOOBMML.Outline || this.LMHJBBOENQB == BKKHLBCLPJM.GIMCHOOBMML.Outline8)
			{
				num = count2;
				count2 = EQINHIFFOGG.Count;
				this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, -vector.x, vector.y);
				num = count2;
				count2 = EQINHIFFOGG.Count;
				this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, vector.x, vector.y);
				num = count2;
				count2 = EQINHIFFOGG.Count;
				this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, -vector.x, -vector.y);
				if (this.LMHJBBOENQB == BKKHLBCLPJM.GIMCHOOBMML.Outline8)
				{
					num = count2;
					count2 = EQINHIFFOGG.Count;
					this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, -vector.x, 0f);
					num = count2;
					count2 = EQINHIFFOGG.Count;
					this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, vector.x, 0f);
					num = count2;
					count2 = EQINHIFFOGG.Count;
					this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, 0f, vector.y);
					num = count2;
					count2 = EQINHIFFOGG.Count;
					this.PIDHGEJEQQM(EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO, num, count2, 0f, -vector.y);
				}
			}
		}
		if (this.GOFBKEHQPDK != null)
		{
			this.GOFBKEHQPDK(this, num, EQINHIFFOGG, PICFCJNMJMC, HQOONBPDFHO);
		}
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00010E36 File Offset: 0x0000F036
	public bool OIJIKGKKDCC()
	{
		return this.mEncoding;
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x0001108E File Offset: 0x0000F28E
	protected override void FHJOQKCCMDH()
	{
		base.FHJOQKCCMDH();
		BKKHLBCLPJM.JNMDHMGQBMD.LHQECHHMOGD(this);
		this.FIQLOMBJOCD(this.OFHEQIDHQOP);
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x000110AD File Offset: 0x0000F2AD
	public void IGHDGGMCGOF(int BGBMIEJJQKC)
	{
		if (this.mOverflowWidth != BGBMIEJJQKC)
		{
			this.mOverflowWidth = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06001EEF RID: 7919 RVA: 0x000110C5 File Offset: 0x0000F2C5
	// (set) Token: 0x06001F51 RID: 8017 RVA: 0x000112B4 File Offset: 0x0000F4B4
	public int MNNBBPGPNJF
	{
		get
		{
			return this.mSpacingY;
		}
		set
		{
			if (this.mSpacingY != value)
			{
				this.mSpacingY = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x000CCBEC File Offset: 0x000CADEC
	public string DJJPKEHILBG(int JKBFLJQHMCE)
	{
		string cdbbenhqgij = this.CDBBENHQGIJ;
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < cdbbenhqgij.Length - 6)
		{
			int num;
			if (cdbbenhqgij[JKBFLJQHMCE] == '[' && cdbbenhqgij[JKBFLJQHMCE + 1] == 'u' && cdbbenhqgij[JKBFLJQHMCE + 2] == 'r' && cdbbenhqgij[JKBFLJQHMCE + 3] == 'n' && cdbbenhqgij[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = cdbbenhqgij.LastIndexOf("[urn=", JKBFLJQHMCE);
			}
			if (num == -1)
			{
				return null;
			}
			num += 5;
			int num2 = cdbbenhqgij.IndexOf("]", num);
			if (num2 == -1)
			{
				return null;
			}
			int num3 = cdbbenhqgij.IndexOf("[/urn]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3)
			{
				return cdbbenhqgij.Substring(num, num2 - num);
			}
		}
		return null;
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x000110CD File Offset: 0x0000F2CD
	public float FEEIBPMLFLM()
	{
		return (!this.mUseFloatSpacing) ? ((float)this.mSpacingX) : this.mFloatSpacingX;
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x000CCCA4 File Offset: 0x000CAEA4
	protected override void HFODGDLHGJL()
	{
		this.LJGQIHIPOMD(true, true);
		if (this.mShrinkToFit)
		{
			this.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
			this.mMaxLineCount = 0;
		}
		if (this.mMaxLineWidth != 0)
		{
			base.KJGMGPCEJJD = this.mMaxLineWidth;
			this.NKMQLQJDBPF = ((this.mMaxLineCount <= 0) ? BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent : BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight);
		}
		else
		{
			this.NKMQLQJDBPF = BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely;
		}
		if (this.mMaxLineHeight != 0)
		{
			base.DFKQMMIQDOO = this.mMaxLineHeight;
		}
		if (this.mFont != null)
		{
			int bdhmpmflmhi = this.mFont.BDHMPMFLMHI;
			if (base.DFKQMMIQDOO < bdhmpmflmhi)
			{
				base.DFKQMMIQDOO = bdhmpmflmhi;
			}
			this.HQLMJHHPHQL = bdhmpmflmhi;
		}
		this.mMaxLineWidth = 0;
		this.mMaxLineHeight = 0;
		this.mShrinkToFit = false;
		IKBQNBHOJJB.DDHFKDFHCQB(base.gameObject, true);
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000CE0FC File Offset: 0x000CC2FC
	// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x000110E6 File Offset: 0x0000F2E6
	public override Texture GOIHJQNMMJD
	{
		get
		{
			if (this.mFont != null)
			{
				return this.mFont.JGMFILNPFLH;
			}
			if (this.mTrueTypeFont != null)
			{
				Material material = this.mTrueTypeFont.material;
				if (material != null)
				{
					return material.mainTexture;
				}
			}
			return null;
		}
		set
		{
			base.GOIHJQNMMJD = value;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x000CC494 File Offset: 0x000CA694
	// (set) Token: 0x06001F1A RID: 7962 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public override Material PPLIPCEHGNM
	{
		get
		{
			if (this.mMat != null)
			{
				return this.mMat;
			}
			if (this.mFont != null)
			{
				return this.mFont.PPLIPCEHGNM;
			}
			if (this.mTrueTypeFont != null)
			{
				return this.mTrueTypeFont.material;
			}
			return null;
		}
		set
		{
			base.PPLIPCEHGNM = value;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000110EF File Offset: 0x0000F2EF
	// (set) Token: 0x06001F5E RID: 8030 RVA: 0x000115A2 File Offset: 0x0000F7A2
	public int HQLMJHHPHQL
	{
		get
		{
			return this.mFontSize;
		}
		set
		{
			value = Mathf.Clamp(value, 0, 256);
			if (this.mFontSize != value)
			{
				this.mFontSize = value;
				this.HDBQMJJKQME = true;
				this.LMGQBPNOLPF();
			}
		}
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000CCD68 File Offset: 0x000CAF68
	private void LJGQIHIPOMD(bool HJLNIMEECCL, bool FLQNGOHDNDE)
	{
		if (!this.INEMKLPCLOP)
		{
			return;
		}
		this.LHQDFLPFGME = true;
		this.HDBQMJJKQME = false;
		float num = this.KQGOECJHBNK.z - this.KQGOECJHBNK.x;
		float num2 = this.KQGOECJHBNK.w - this.KQGOECJHBNK.y;
		JGDHIPBGCFP.JQGIJOFBHME = ((!HJLNIMEECCL) ? base.KJGMGPCEJJD : ((this.mMaxLineWidth == 0) ? 1000000 : this.mMaxLineWidth));
		JGDHIPBGCFP.ECQBIIGPJQO = ((!HJLNIMEECCL) ? base.DFKQMMIQDOO : ((this.mMaxLineHeight == 0) ? 1000000 : this.mMaxLineHeight));
		JGDHIPBGCFP.PPMHDQJHPLO = ((num == 1f) ? JGDHIPBGCFP.JQGIJOFBHME : Mathf.RoundToInt((float)JGDHIPBGCFP.JQGIJOFBHME * num));
		JGDHIPBGCFP.NNHJHLOFKFD = ((num2 == 1f) ? JGDHIPBGCFP.ECQBIIGPJQO : Mathf.RoundToInt((float)JGDHIPBGCFP.ECQBIIGPJQO * num2));
		this.KQDPKEJDEMH = Mathf.Abs((!HJLNIMEECCL) ? this.EPCEBKNONLF : Mathf.RoundToInt(base.CGDFDPHIENG.localScale.x));
		this.DGEGGLFHBKO = 1f;
		if (JGDHIPBGCFP.PPMHDQJHPLO >= 1 && JGDHIPBGCFP.NNHJHLOFKFD >= 0)
		{
			bool flag;
			if ((flag = (this.OFHEQIDHQOP != null)) && this.LLCKDIBHNQB)
			{
				GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
				if (qobpijdbngl != null)
				{
					this.KCKPBKHEPMM = ((!(qobpijdbngl != null)) ? 1f : qobpijdbngl.PNBFQDLQENI);
				}
			}
			else
			{
				this.KCKPBKHEPMM = 1f;
			}
			if (FLQNGOHDNDE)
			{
				this.KMLKNBFNOIC();
			}
			if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely)
			{
				JGDHIPBGCFP.JQGIJOFBHME = 1000000;
				JGDHIPBGCFP.PPMHDQJHPLO = 1000000;
				if (this.mOverflowWidth > 0)
				{
					JGDHIPBGCFP.JQGIJOFBHME = Mathf.Min(JGDHIPBGCFP.JQGIJOFBHME, this.mOverflowWidth);
					JGDHIPBGCFP.PPMHDQJHPLO = Mathf.Min(JGDHIPBGCFP.PPMHDQJHPLO, this.mOverflowWidth);
				}
			}
			if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight)
			{
				JGDHIPBGCFP.ECQBIIGPJQO = 1000000;
				JGDHIPBGCFP.NNHJHLOFKFD = 1000000;
			}
			if (this.KQDPKEJDEMH > 0)
			{
				bool llckdibhnqb = this.LLCKDIBHNQB;
				int i = this.KQDPKEJDEMH;
				while (i > 0)
				{
					if (llckdibhnqb)
					{
						this.KQDPKEJDEMH = i;
						JGDHIPBGCFP.HQLMJHHPHQL = this.KQDPKEJDEMH;
					}
					else
					{
						this.DGEGGLFHBKO = (float)i / (float)this.KQDPKEJDEMH;
						JGDHIPBGCFP.CNLNKDBIMDB = ((!flag) ? ((float)this.mFontSize / (float)this.mFont.BDHMPMFLMHI * this.DGEGGLFHBKO) : this.DGEGGLFHBKO);
					}
					JGDHIPBGCFP.IBQCMOEQPGF(false);
					bool flag2 = JGDHIPBGCFP.QDHGBPQDDMQ(this.CDBBENHQGIJ, out this.LHFFFGFPIBH, true, false, this.mOverflowEllipsis && this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent, 0f);
					if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent && !flag2)
					{
						if (--i <= 1)
						{
							break;
						}
						i--;
					}
					else
					{
						if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely)
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
							int num3 = Mathf.Max(this.DJBGEBNJKLK, Mathf.RoundToInt(this.NCDNEEHPMFB.x));
							if (num != 1f)
							{
								num3 = Mathf.RoundToInt((float)num3 / num);
							}
							int num4 = Mathf.Max(this.IPGGCHLFDCF, Mathf.RoundToInt(this.NCDNEEHPMFB.y));
							if (num2 != 1f)
							{
								num4 = Mathf.RoundToInt((float)num4 / num2);
							}
							if (this.mOverflowHeight > 0 && num4 < this.mOverflowHeight)
							{
								num4 = this.mOverflowHeight;
							}
							if (this.DJBGEBNJKLK > 0 && num3 < this.DJBGEBNJKLK)
							{
								num3 = this.DJBGEBNJKLK;
							}
							if ((num3 & 1) == 1)
							{
								num3++;
							}
							if ((num4 & 1) == 1)
							{
								num4++;
							}
							if (this.mWidth != num3 || this.mHeight != num4)
							{
								this.mWidth = num3;
								this.mHeight = num4;
								if (this.OHEFEKMMIFL != null)
								{
									this.OHEFEKMMIFL();
								}
							}
						}
						else if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight)
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
							int num5 = Mathf.Max(this.IPGGCHLFDCF, Mathf.RoundToInt(this.NCDNEEHPMFB.y));
							if (num2 != 1f)
							{
								num5 = Mathf.RoundToInt((float)num5 / num2);
							}
							if ((num5 & 1) == 1)
							{
								num5++;
							}
							if (this.mHeight != num5)
							{
								this.mHeight = num5;
								if (this.OHEFEKMMIFL != null)
								{
									this.OHEFEKMMIFL();
								}
							}
						}
						else
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
						}
						if (HJLNIMEECCL)
						{
							base.KJGMGPCEJJD = Mathf.RoundToInt(this.NCDNEEHPMFB.x);
							base.DFKQMMIQDOO = Mathf.RoundToInt(this.NCDNEEHPMFB.y);
							base.CGDFDPHIENG.localScale = Vector3.one;
							break;
						}
						break;
					}
				}
			}
			else
			{
				base.CGDFDPHIENG.localScale = Vector3.one;
				this.LHFFFGFPIBH = string.Empty;
				this.DGEGGLFHBKO = 1f;
			}
			if (FLQNGOHDNDE)
			{
				JGDHIPBGCFP.NFIBPOJMOCQ = null;
				JGDHIPBGCFP.KDDNGBFFFJL = null;
			}
			return;
		}
		this.LHFFFGFPIBH = string.Empty;
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000110F7 File Offset: 0x0000F2F7
	// (set) Token: 0x06001F0A RID: 7946 RVA: 0x00010F2C File Offset: 0x0000F12C
	[Obsolete("Use 'width' instead")]
	public int OJKFILHQBMC
	{
		get
		{
			return base.KJGMGPCEJJD;
		}
		set
		{
			base.KJGMGPCEJJD = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x000110FF File Offset: 0x0000F2FF
	// (set) Token: 0x06001F49 RID: 8009 RVA: 0x00011529 File Offset: 0x0000F729
	public bool KCBHFKQPDIE
	{
		get
		{
			return this.mUseFloatSpacing;
		}
		set
		{
			if (this.mUseFloatSpacing != value)
			{
				this.mUseFloatSpacing = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x00011120 File Offset: 0x0000F320
	public void LJGQIHIPOMD()
	{
		this.LJGQIHIPOMD(false, true);
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x0001112A File Offset: 0x0000F32A
	protected override void OnDisable()
	{
		this.FIQLOMBJOCD(null);
		BKKHLBCLPJM.JNMDHMGQBMD.FQDMDDOHCQJ(this);
		base.OnDisable();
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x000CD268 File Offset: 0x000CB468
	public string CCHHEDGIPIL(int JKBFLJQHMCE)
	{
		string cdbbenhqgij = this.CDBBENHQGIJ;
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < cdbbenhqgij.Length)
		{
			int num = cdbbenhqgij.LastIndexOfAny(new char[]
			{
				' ',
				'\n'
			}, JKBFLJQHMCE) + 1;
			int num2 = cdbbenhqgij.IndexOfAny(new char[]
			{
				' ',
				'\n',
				',',
				'.'
			}, JKBFLJQHMCE);
			if (num2 == -1)
			{
				num2 = cdbbenhqgij.Length;
			}
			if (num != num2)
			{
				int num3 = num2 - num;
				if (num3 > 0)
				{
					string pidlofmiefq = cdbbenhqgij.Substring(num, num3);
					return JGDHIPBGCFP.IMOMGBNIENN(pidlofmiefq);
				}
			}
		}
		return null;
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x000CD2E8 File Offset: 0x000CB4E8
	protected override void NEBPQFKGHLL()
	{
		if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely)
		{
			if (base.IQKPIEHJMDH)
			{
				this.mOverflow = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
			}
		}
		else if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight && this.NOPCJFECJDP.target != null && this.LBGJKGDECCN.target != null)
		{
			this.mOverflow = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
		}
		base.NEBPQFKGHLL();
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x000CD34C File Offset: 0x000CB54C
	protected virtual void BGBLGFCCPLJ()
	{
		if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent)
		{
			if (base.IQKPIEHJMDH)
			{
				this.mOverflow = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
			}
		}
		else if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely && this.NOPCJFECJDP.target != null && this.LBGJKGDECCN.target != null)
		{
			this.mOverflow = BKKHLBCLPJM.QJCBBQNCBKG.ClampContent;
		}
		base.NEBPQFKGHLL();
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x00011145 File Offset: 0x0000F345
	public virtual Vector4 IOPLOGIBCFJ()
	{
		if (this.HDBQMJJKQME)
		{
			this.LJGQIHIPOMD();
		}
		return base.BCEPPKGMNFE;
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x000CD3B0 File Offset: 0x000CB5B0
	public string FDPHEKIEQFN(int JKBFLJQHMCE)
	{
		string cdbbenhqgij = this.CDBBENHQGIJ;
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < cdbbenhqgij.Length - 8)
		{
			int num;
			if ((int)cdbbenhqgij[JKBFLJQHMCE] == -62 && (int)cdbbenhqgij[JKBFLJQHMCE + 0] == -93 && cdbbenhqgij[JKBFLJQHMCE + 8] == '\'' && (int)cdbbenhqgij[JKBFLJQHMCE + 6] == -123 && cdbbenhqgij[JKBFLJQHMCE + 8] == '\t')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = cdbbenhqgij.LastIndexOf("/3", JKBFLJQHMCE);
			}
			if (num == -1)
			{
				return null;
			}
			num++;
			int num2 = cdbbenhqgij.IndexOf("Cacophony", num);
			if (num2 == -1)
			{
				return null;
			}
			int num3 = cdbbenhqgij.IndexOf("Encounter Rate Increased 50%\nTriggers: [2ecc71]Arena Trap[-], [2ecc71]Swarm[-], [2ecc71]Illuminate[-], [2ecc71]No Guard[-]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3)
			{
				return cdbbenhqgij.Substring(num, num2 - num);
			}
		}
		return null;
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x00010E14 File Offset: 0x0000F014
	public string NKHNBCPLINC(Vector3 PHCMBMCKQDC)
	{
		return this.FDPHEKIEQFN(this.LJBKLGBQHJI(PHCMBMCKQDC, true));
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00011731 File Offset: 0x0000F931
	// (set) Token: 0x06001F02 RID: 7938 RVA: 0x0001115B File Offset: 0x0000F35B
	public FontStyle GOIMOQJFMHE
	{
		get
		{
			return this.mFontStyle;
		}
		set
		{
			if (this.mFontStyle != value)
			{
				this.mFontStyle = value;
				this.HDBQMJJKQME = true;
				this.LMGQBPNOLPF();
			}
		}
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x00010E87 File Offset: 0x0000F087
	public virtual void DFOCFKJPJOM()
	{
		this.HDBQMJJKQME = false;
		base.NPCECPIOPCB();
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x000CD468 File Offset: 0x000CB668
	private static void QLFLICOIPKH(Font NKKDJJOKQDK)
	{
		for (int i = 1; i < BKKHLBCLPJM.JNMDHMGQBMD.BJGMIBBEGDQ; i += 0)
		{
			BKKHLBCLPJM bkkhlbclpjm = BKKHLBCLPJM.JNMDHMGQBMD.get_KNPPMKBOGDL(i);
			if (bkkhlbclpjm != null)
			{
				Font ofheqidhqop = bkkhlbclpjm.OFHEQIDHQOP;
				if (ofheqidhqop == NKKDJJOKQDK)
				{
					ofheqidhqop.RequestCharactersInTexture(bkkhlbclpjm.CDBBENHQGIJ, bkkhlbclpjm.KQDPKEJDEMH, bkkhlbclpjm.mFontStyle);
					bkkhlbclpjm.NPCECPIOPCB();
					if (bkkhlbclpjm.BCHNDNICINJ == null)
					{
						bkkhlbclpjm.KJPQKFEBFDJ();
					}
					if (BKKHLBCLPJM.CBMDCGDPKKD == null)
					{
						BKKHLBCLPJM.CBMDCGDPKKD = new List<KMCGDKDIJIE>();
					}
					if (bkkhlbclpjm.OQKBOCHIFKH != null && !BKKHLBCLPJM.CBMDCGDPKKD.Contains(bkkhlbclpjm.OQKBOCHIFKH))
					{
						BKKHLBCLPJM.CBMDCGDPKKD.Add(bkkhlbclpjm.OQKBOCHIFKH);
					}
				}
			}
		}
		if (BKKHLBCLPJM.CBMDCGDPKKD != null)
		{
			int j = 1;
			int count = BKKHLBCLPJM.CBMDCGDPKKD.Count;
			while (j < count)
			{
				KMCGDKDIJIE kmcgdkdijie = BKKHLBCLPJM.CBMDCGDPKKD[j];
				if (kmcgdkdijie.BCHNDNICINJ != null)
				{
					kmcgdkdijie.BCHNDNICINJ.DEPEMLBPJLD(kmcgdkdijie);
				}
				j++;
			}
			BKKHLBCLPJM.CBMDCGDPKKD.Clear();
		}
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x0001117A File Offset: 0x0000F37A
	protected override void OnEnable()
	{
		base.OnEnable();
		if (!BKKHLBCLPJM.EFOOGEFNKFN)
		{
			BKKHLBCLPJM.EFOOGEFNKFN = true;
			if (BKKHLBCLPJM.BQIOGOCBKKB == null)
			{
				BKKHLBCLPJM.BQIOGOCBKKB = new Action<Font>(BKKHLBCLPJM.LNGICOJJIIF);
			}
			Font.textureRebuilt += BKKHLBCLPJM.BQIOGOCBKKB;
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x06001F08 RID: 7944 RVA: 0x000111C9 File Offset: 0x0000F3C9
	// (set) Token: 0x06001F4D RID: 8013 RVA: 0x00011558 File Offset: 0x0000F758
	public JGDHIPBGCFP.OQGGLOQFNPE FJPNBPJQODQ
	{
		get
		{
			return this.mSymbols;
		}
		set
		{
			if (this.mSymbols != value)
			{
				this.mSymbols = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000111D1 File Offset: 0x0000F3D1
	// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00011749 File Offset: 0x0000F949
	public int JQJEMBJLHCI
	{
		get
		{
			return this.mOverflowHeight;
		}
		set
		{
			if (this.mOverflowHeight != value)
			{
				this.mOverflowHeight = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000111D9 File Offset: 0x0000F3D9
	public bool LCJJFBHHFQD(string PIDLOFMIEFQ, out string MLDEDBINHGL)
	{
		return this.LCJJFBHHFQD(PIDLOFMIEFQ, out MLDEDBINHGL, 1000000);
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000111E8 File Offset: 0x0000F3E8
	public int HDDMQEJGKMI
	{
		get
		{
			if (this.OFHEQIDHQOP)
			{
				return Mathf.RoundToInt(this.DGEGGLFHBKO * (float)this.KQDPKEJDEMH);
			}
			return Mathf.RoundToInt((float)this.KQDPKEJDEMH * this.DGEGGLFHBKO);
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00011571 File Offset: 0x0000F771
	// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0001121E File Offset: 0x0000F41E
	public BKKHLBCLPJM.GIMCHOOBMML LMHJBBOENQB
	{
		get
		{
			return this.mEffectStyle;
		}
		set
		{
			if (this.mEffectStyle != value)
			{
				this.mEffectStyle = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00011237 File Offset: 0x0000F437
	// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0001132D File Offset: 0x0000F52D
	public float GDLDDIGGKKP
	{
		get
		{
			return this.mFloatSpacingY;
		}
		set
		{
			if (!Mathf.Approximately(this.mFloatSpacingY, value))
			{
				this.mFloatSpacingY = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x00011247 File Offset: 0x0000F447
	public bool MFJBOOJPJJO(string PIDLOFMIEFQ, out string MLDEDBINHGL)
	{
		return this.LCJJFBHHFQD(PIDLOFMIEFQ, out MLDEDBINHGL, -92);
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x00011256 File Offset: 0x0000F456
	public string BMIHQGEBQPH()
	{
		return this.mText;
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x00010E36 File Offset: 0x0000F036
	public bool DOQNLCBIGKJ()
	{
		return this.mEncoding;
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x0001125E File Offset: 0x0000F45E
	public virtual bool PCQFKKGEQCG()
	{
		return base.MQKHMKGCJLC || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent || this.mOverflow == (BKKHLBCLPJM.QJCBBQNCBKG)4;
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x000110CD File Offset: 0x0000F2CD
	public float COMPICDBHKE()
	{
		return (!this.mUseFloatSpacing) ? ((float)this.mSpacingX) : this.mFloatSpacingX;
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x0001127D File Offset: 0x0000F47D
	public string NEDOCKOEFPF(Vector3 PHCMBMCKQDC)
	{
		return this.PCPNQDENHMO(this.LJBKLGBQHJI(PHCMBMCKQDC, true));
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0001161C File Offset: 0x0000F81C
	// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00011295 File Offset: 0x0000F495
	public JGDHIPBGCFP.MNMQCONMCFH PBHNPKNJNJH
	{
		get
		{
			return this.mAlignment;
		}
		set
		{
			if (this.mAlignment != value)
			{
				this.mAlignment = value;
				this.HDBQMJJKQME = true;
				this.LMGQBPNOLPF();
			}
		}
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000112B4 File Offset: 0x0000F4B4
	public void IQCIHQJCINE(int BGBMIEJJQKC)
	{
		if (this.mSpacingY != BGBMIEJJQKC)
		{
			this.mSpacingY = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x000112CC File Offset: 0x0000F4CC
	public int BDMDPKDHBFD(Vector3 PHCMBMCKQDC)
	{
		return this.LJBKLGBQHJI(PHCMBMCKQDC, false);
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00010E3E File Offset: 0x0000F03E
	// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00010E96 File Offset: 0x0000F096
	public Color MBCPMFDMEEQ
	{
		get
		{
			return this.mGradientTop;
		}
		set
		{
			if (this.mGradientTop != value)
			{
				this.mGradientTop = value;
				if (this.mApplyGradient)
				{
					this.NPCECPIOPCB();
				}
			}
		}
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x000112DF File Offset: 0x0000F4DF
	public string GLPIDIJHEIF(Vector3 PHCMBMCKQDC)
	{
		return this.ONLFGLFLKFM(this.LJBKLGBQHJI(PHCMBMCKQDC, true), string.Empty);
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x000112F4 File Offset: 0x0000F4F4
	public Color ECMQBHEJKMG()
	{
		return this.mEffectColor;
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x000112FC File Offset: 0x0000F4FC
	public string LNGQHNCCFIK(Vector2 PNNOLPKBHNQ)
	{
		return this.QIBHMNOCKGN(this.LJBKLGBQHJI(PNNOLPKBHNQ, true), string.Empty);
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x00011311 File Offset: 0x0000F511
	public void EFEJBMHOGHG()
	{
		this.LHFFFGFPIBH = string.Empty;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x0001131E File Offset: 0x0000F51E
	public override void NPCECPIOPCB()
	{
		this.HDBQMJJKQME = true;
		base.NPCECPIOPCB();
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000CD5B8 File Offset: 0x000CB7B8
	public string PLEHEDKKQGC(Vector3 PHCMBMCKQDC)
	{
		int jkbfljqhmce = this.LJBKLGBQHJI(PHCMBMCKQDC, false);
		return this.CCHHEDGIPIL(jkbfljqhmce);
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00010EFE File Offset: 0x0000F0FE
	public override Vector3[] PIGMLPNGMNO
	{
		get
		{
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return base.PIGMLPNGMNO;
		}
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000CC494 File Offset: 0x000CA694
	public virtual Material FGGNHMPBEPK()
	{
		if (this.mMat != null)
		{
			return this.mMat;
		}
		if (this.mFont != null)
		{
			return this.mFont.PPLIPCEHGNM;
		}
		if (this.mTrueTypeFont != null)
		{
			return this.mTrueTypeFont.material;
		}
		return null;
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000CC494 File Offset: 0x000CA694
	public virtual Material MBDPGECDBKF()
	{
		if (this.mMat != null)
		{
			return this.mMat;
		}
		if (this.mFont != null)
		{
			return this.mFont.PPLIPCEHGNM;
		}
		if (this.mTrueTypeFont != null)
		{
			return this.mTrueTypeFont.material;
		}
		return null;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x00010EE8 File Offset: 0x0000F0E8
	public virtual Vector3[] GJFFPLQIDNH()
	{
		if (this.HDBQMJJKQME)
		{
			this.LJGQIHIPOMD();
		}
		return base.PMCNQICHCLE;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x000CD5D8 File Offset: 0x000CB7D8
	public void OCPPIJFKGJP(int GBEBKHGGPKM, int QNDMNIDPICH, QDHDQQEKMGO GFEONCKBDBC, QDHDQQEKMGO FOGFQQEMIIB, Color HMNMOCKFCBJ, Color JIOMEMJQJCC, string LBKMBCOOIHC = "")
	{
		if (GFEONCKBDBC != null)
		{
			GFEONCKBDBC.CPLBKPNNHJG();
		}
		if (FOGFQQEMIIB != null)
		{
			FOGFQQEMIIB.CPLBKPNNHJG();
		}
		if (!this.INEMKLPCLOP)
		{
			return;
		}
		string pidlofmiefq = this.NKKFKOQQGDE;
		if (LBKMBCOOIHC != string.Empty)
		{
			pidlofmiefq = LBKMBCOOIHC;
		}
		this.KMLKNBFNOIC();
		int count = GFEONCKBDBC.EQINHIFFOGG.Count;
		Vector2 item = new Vector2(0.5f, 0.5f);
		float nhcnedeeonk = this.NHCNEDEEONK;
		if (FOGFQQEMIIB != null && GBEBKHGGPKM != QNDMNIDPICH)
		{
			int count2 = FOGFQQEMIIB.EQINHIFFOGG.Count;
			JGDHIPBGCFP.NCINCCJDLOM(pidlofmiefq, GBEBKHGGPKM, QNDMNIDPICH, GFEONCKBDBC.EQINHIFFOGG, FOGFQQEMIIB.EQINHIFFOGG);
			if (FOGFQQEMIIB.EQINHIFFOGG.Count > count2)
			{
				this.CKBEDCLMENE(FOGFQQEMIIB.EQINHIFFOGG, count2);
				Color item2 = new Color(JIOMEMJQJCC.r, JIOMEMJQJCC.g, JIOMEMJQJCC.b, JIOMEMJQJCC.a * nhcnedeeonk);
				int i = count2;
				int count3 = FOGFQQEMIIB.EQINHIFFOGG.Count;
				while (i < count3)
				{
					FOGFQQEMIIB.PICFCJNMJMC.Add(item);
					FOGFQQEMIIB.HQOONBPDFHO.Add(item2);
					i++;
				}
			}
		}
		else
		{
			JGDHIPBGCFP.NCINCCJDLOM(pidlofmiefq, GBEBKHGGPKM, QNDMNIDPICH, GFEONCKBDBC.EQINHIFFOGG, null);
		}
		this.CKBEDCLMENE(GFEONCKBDBC.EQINHIFFOGG, count);
		Color item3 = new Color(HMNMOCKFCBJ.r, HMNMOCKFCBJ.g, HMNMOCKFCBJ.b, HMNMOCKFCBJ.a * nhcnedeeonk);
		int j = count;
		int count4 = GFEONCKBDBC.EQINHIFFOGG.Count;
		while (j < count4)
		{
			GFEONCKBDBC.PICFCJNMJMC.Add(item);
			GFEONCKBDBC.HQOONBPDFHO.Add(item3);
			j++;
		}
		JGDHIPBGCFP.NFIBPOJMOCQ = null;
		JGDHIPBGCFP.KDDNGBFFFJL = null;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x000CD780 File Offset: 0x000CB980
	public int IIIDCNDGHCO(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 5 > text.Length)
			{
				JKBFLJQHMCE -= 7;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 0;
				}
				if (text.LastIndexOf("'s can't use [ffff00]", JKBFLJQHMCE) == -1)
				{
					return -1;
				}
			}
			int num;
			if ((int)text[JKBFLJQHMCE] == -26 && (int)text[JKBFLJQHMCE + 0] == -13 && text[JKBFLJQHMCE + 4] == 'n' && (int)text[JKBFLJQHMCE + 6] == -50 && text[JKBFLJQHMCE + 6] == '\u001b')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = text.LastIndexOf(" shared its guard with ", JKBFLJQHMCE + 5);
			}
			if (num == -1)
			{
				return -1;
			}
			num += 5;
			int num2 = text.IndexOf("]#", num);
			if (num2 == -1)
			{
				return -1;
			}
			int num3 = text.IndexOf("Icon_Pokemon_Dead", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3 + 1)
			{
				return num - 2;
			}
		}
		return -1;
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x00011069 File Offset: 0x0000F269
	public void NDJBCCEOLEM(Color BGBMIEJJQKC)
	{
		if (this.mGradientBottom != BGBMIEJJQKC)
		{
			this.mGradientBottom = BGBMIEJJQKC;
			if (this.mApplyGradient)
			{
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x0001136F File Offset: 0x0000F56F
	private bool FQCMIEEPJBF()
	{
		return !(this.mFont != null) && this.mTrueTypeFont != null;
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x000CD86C File Offset: 0x000CBA6C
	public int[] QGCQQOHBILP(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		int num = JKBFLJQHMCE;
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (text.Length > -71 && JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 6 > text.Length)
			{
				JKBFLJQHMCE -= 4;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 1;
				}
			}
			int num2;
			if ((int)text[JKBFLJQHMCE] == -89 && text[JKBFLJQHMCE + 0] == '\u001e' && text[JKBFLJQHMCE + 5] == 'M' && text[JKBFLJQHMCE + 3] == 'f' && (int)text[JKBFLJQHMCE + 7] == -43)
			{
				num2 = JKBFLJQHMCE;
			}
			else
			{
				num2 = text.LastIndexOf("WATER_SIMPLE", JKBFLJQHMCE + 1);
			}
			if (num2 == -1)
			{
				return null;
			}
			num2 += 7;
			int num3 = text.IndexOf("Fix", num2);
			if (num3 == -1)
			{
				return null;
			}
			int num4 = text.IndexOf("Update", num3);
			if (num4 == -1)
			{
				return null;
			}
			if (num <= num4 + 5)
			{
				int[] array = new int[]
				{
					num2 - 0
				};
				array[0] = num4 + 6;
				return array;
			}
		}
		return null;
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00011592 File Offset: 0x0000F792
	// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0001138E File Offset: 0x0000F58E
	public BKKHLBCLPJM.QJCBBQNCBKG NKMQLQJDBPF
	{
		get
		{
			return this.mOverflow;
		}
		set
		{
			if (this.mOverflow != value)
			{
				this.mOverflow = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000113A7 File Offset: 0x0000F5A7
	public void LKMEQQOPQFD(int BGBMIEJJQKC)
	{
		if (this.mMaxLineCount != BGBMIEJJQKC)
		{
			this.mMaxLineCount = Mathf.Max(BGBMIEJJQKC, 1);
			this.HDBQMJJKQME = true;
			if (this.NKMQLQJDBPF == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent)
			{
				this.IQFQEOFBQKM();
			}
		}
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000CD968 File Offset: 0x000CBB68
	public override void IQFQEOFBQKM()
	{
		if (this.IOCQLIKGMEO != null)
		{
			Vector3 localPosition = base.CGDFDPHIENG.localPosition;
			localPosition.x = (float)Mathf.RoundToInt(localPosition.x);
			localPosition.y = (float)Mathf.RoundToInt(localPosition.y);
			localPosition.z = (float)Mathf.RoundToInt(localPosition.z);
			base.CGDFDPHIENG.localPosition = localPosition;
			base.CGDFDPHIENG.localScale = Vector3.one;
			if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely)
			{
				this.PNHIQOJOOKN();
			}
			else
			{
				int kjgmgpcejjd = base.KJGMGPCEJJD;
				int dfkqmmiqdoo = base.DFKQMMIQDOO;
				BKKHLBCLPJM.QJCBBQNCBKG qjcbbqncbkg = this.mOverflow;
				if (qjcbbqncbkg != BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight)
				{
					this.mWidth = 100000;
				}
				this.mHeight = 100000;
				this.mOverflow = BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
				this.LJGQIHIPOMD(false, true);
				this.mOverflow = qjcbbqncbkg;
				int num = Mathf.RoundToInt(this.NCDNEEHPMFB.x);
				int num2 = Mathf.RoundToInt(this.NCDNEEHPMFB.y);
				num = Mathf.Max(num, base.QPKCPBJINBK);
				num2 = Mathf.Max(num2, base.IPGGCHLFDCF);
				if ((num & 1) == 1)
				{
					num++;
				}
				if ((num2 & 1) == 1)
				{
					num2++;
				}
				this.mWidth = Mathf.Max(kjgmgpcejjd, num);
				this.mHeight = Mathf.Max(dfkqmmiqdoo, num2);
				this.NPCECPIOPCB();
			}
		}
		else
		{
			base.IQFQEOFBQKM();
		}
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000CDACC File Offset: 0x000CBCCC
	public void KMLKNBFNOIC()
	{
		Font ofheqidhqop = this.OFHEQIDHQOP;
		bool flag = ofheqidhqop != null;
		JGDHIPBGCFP.HQLMJHHPHQL = this.KQDPKEJDEMH;
		JGDHIPBGCFP.GOIMOQJFMHE = this.mFontStyle;
		JGDHIPBGCFP.JQGIJOFBHME = this.mWidth;
		JGDHIPBGCFP.ECQBIIGPJQO = this.mHeight;
		JGDHIPBGCFP.PPMHDQJHPLO = Mathf.RoundToInt((float)this.mWidth * (this.KQGOECJHBNK.z - this.KQGOECJHBNK.x));
		JGDHIPBGCFP.NNHJHLOFKFD = Mathf.RoundToInt((float)this.mHeight * (this.KQGOECJHBNK.w - this.KQGOECJHBNK.y));
		JGDHIPBGCFP.JFQBHOFLBQG = (this.mApplyGradient && (this.mFont == null || !this.mFont.CHLEEPHFEGC));
		JGDHIPBGCFP.MBCPMFDMEEQ = this.mGradientTop;
		JGDHIPBGCFP.QEQOQOOCEEN = this.mGradientBottom;
		JGDHIPBGCFP.CKGCLBODNNJ = this.mEncoding;
		JGDHIPBGCFP.NFLEOLEGPJJ = this.JHKLMMDCLQG;
		JGDHIPBGCFP.FJPNBPJQODQ = this.mSymbols;
		JGDHIPBGCFP.BPIPFOJNJCQ = this.mMaxLineCount;
		JGDHIPBGCFP.MOQHNNIINFL = this.MNOMGIEKPHG;
		JGDHIPBGCFP.MNNBBPGPNJF = this.LKLGLCMCMMO;
		JGDHIPBGCFP.CNLNKDBIMDB = ((!flag) ? ((float)this.mFontSize / (float)this.mFont.BDHMPMFLMHI * this.DGEGGLFHBKO) : this.DGEGGLFHBKO);
		if (this.mFont != null)
		{
			JGDHIPBGCFP.NFIBPOJMOCQ = this.mFont;
			for (;;)
			{
				KGKLCNDOLMP qkqjdjkilgd = JGDHIPBGCFP.NFIBPOJMOCQ.QKQJDJKILGD;
				if (qkqjdjkilgd == null)
				{
					break;
				}
				JGDHIPBGCFP.NFIBPOJMOCQ = qkqjdjkilgd;
			}
			if (JGDHIPBGCFP.NFIBPOJMOCQ.IIENDKNLHMC)
			{
				JGDHIPBGCFP.KDDNGBFFFJL = JGDHIPBGCFP.NFIBPOJMOCQ.KDDNGBFFFJL;
				JGDHIPBGCFP.NFIBPOJMOCQ = null;
			}
			else
			{
				JGDHIPBGCFP.KDDNGBFFFJL = null;
			}
		}
		else
		{
			JGDHIPBGCFP.KDDNGBFFFJL = ofheqidhqop;
			JGDHIPBGCFP.NFIBPOJMOCQ = null;
		}
		if (flag && this.LLCKDIBHNQB)
		{
			GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
			if (qobpijdbngl != null)
			{
				JGDHIPBGCFP.OOBHQPCDCPD = ((!(qobpijdbngl != null)) ? 1f : qobpijdbngl.PNBFQDLQENI);
			}
		}
		else
		{
			JGDHIPBGCFP.OOBHQPCDCPD = 1f;
		}
		if (this.KCKPBKHEPMM != JGDHIPBGCFP.OOBHQPCDCPD)
		{
			this.LJGQIHIPOMD(false, false);
			JGDHIPBGCFP.JQGIJOFBHME = this.mWidth;
			JGDHIPBGCFP.ECQBIIGPJQO = this.mHeight;
			JGDHIPBGCFP.PPMHDQJHPLO = Mathf.RoundToInt((float)this.mWidth * (this.KQGOECJHBNK.z - this.KQGOECJHBNK.x));
			JGDHIPBGCFP.NNHJHLOFKFD = Mathf.RoundToInt((float)this.mHeight * (this.KQGOECJHBNK.w - this.KQGOECJHBNK.y));
		}
		if (this.PBHNPKNJNJH == JGDHIPBGCFP.MNMQCONMCFH.Automatic)
		{
			ENFMCDNLEQQ.GGBIQFIQQCM oejchhfiqdc = base.OEJCHHFIQDC;
			if (oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.Left && oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
			{
				if (oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.BottomLeft)
				{
					if (oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.Right && oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.TopRight)
					{
						if (oejchhfiqdc != ENFMCDNLEQQ.GGBIQFIQQCM.BottomRight)
						{
							JGDHIPBGCFP.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Center;
							goto IL_2BE;
						}
					}
					JGDHIPBGCFP.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Right;
					goto IL_2BE;
				}
			}
			JGDHIPBGCFP.PBHNPKNJNJH = JGDHIPBGCFP.MNMQCONMCFH.Left;
		}
		else
		{
			JGDHIPBGCFP.PBHNPKNJNJH = this.PBHNPKNJNJH;
		}
		IL_2BE:
		JGDHIPBGCFP.IBQCMOEQPGF();
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x00011407 File Offset: 0x0000F607
	public int PPDMDKMQMHD(Vector2 PNNOLPKBHNQ)
	{
		return this.LJBKLGBQHJI(PNNOLPKBHNQ, false);
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x000CDD9C File Offset: 0x000CBF9C
	protected void FIQLOMBJOCD(Font MPDBJQJBNKI)
	{
		if (this.QIDEHMIOMOJ != MPDBJQJBNKI)
		{
			Font qidehmiomoj = this.QIDEHMIOMOJ;
			int num;
			if (qidehmiomoj != null && BKKHLBCLPJM.CGKCMKIMCGB.TryGetValue(qidehmiomoj, out num))
			{
				num = Mathf.Max(0, --num);
				if (num == 0)
				{
					BKKHLBCLPJM.CGKCMKIMCGB.Remove(qidehmiomoj);
				}
				else
				{
					BKKHLBCLPJM.CGKCMKIMCGB[qidehmiomoj] = num;
				}
			}
			this.QIDEHMIOMOJ = MPDBJQJBNKI;
			if (MPDBJQJBNKI != null)
			{
				BKKHLBCLPJM.CGKCMKIMCGB[MPDBJQJBNKI] = 1;
			}
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0001159A File Offset: 0x0000F79A
	// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00011411 File Offset: 0x0000F611
	public int DJBGEBNJKLK
	{
		get
		{
			return this.mminWidth;
		}
		set
		{
			if (this.mminWidth != value)
			{
				this.mminWidth = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x00011429 File Offset: 0x0000F629
	private void EKIIJKNEJML(bool IGKFNOFJOOI)
	{
		if (!IGKFNOFJOOI && this.mTrueTypeFont != null)
		{
			this.CKLIDQPPPON(true);
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000110CD File Offset: 0x0000F2CD
	public float MNOMGIEKPHG
	{
		get
		{
			return (!this.mUseFloatSpacing) ? ((float)this.mSpacingX) : this.mFloatSpacingX;
		}
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x00011443 File Offset: 0x0000F643
	public bool FNDCJHHNOFL()
	{
		return this.mMaxLineCount == 1;
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x000110F7 File Offset: 0x0000F2F7
	public int GEECCEPGBDK()
	{
		return base.KJGMGPCEJJD;
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00011451 File Offset: 0x0000F651
	public override bool GHLPPQOBKLN
	{
		get
		{
			return base.GHLPPQOBKLN || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely;
		}
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000CDE20 File Offset: 0x000CC020
	public int LJBKLGBQHJI(Vector2 PNNOLPKBHNQ, bool FMLGKOFJCDE)
	{
		if (this.INEMKLPCLOP)
		{
			string nkkfkoqqgde = this.NKKFKOQQGDE;
			if (string.IsNullOrEmpty(nkkfkoqqgde))
			{
				return 0;
			}
			this.KMLKNBFNOIC();
			if (FMLGKOFJCDE)
			{
				JGDHIPBGCFP.KPJMMMIQDNB(nkkfkoqqgde, BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP);
			}
			else
			{
				JGDHIPBGCFP.QCQIMIPHMKG(nkkfkoqqgde, BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP);
			}
			if (BKKHLBCLPJM.GDFPKOGLBMM.Count > 0)
			{
				this.CKBEDCLMENE(BKKHLBCLPJM.GDFPKOGLBMM, 0);
				int result = (!FMLGKOFJCDE) ? JGDHIPBGCFP.JEJHCLIQBOM(BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP, PNNOLPKBHNQ) : JGDHIPBGCFP.DKOIDEHOHHM(BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP, PNNOLPKBHNQ);
				BKKHLBCLPJM.GDFPKOGLBMM.Clear();
				BKKHLBCLPJM.OCDCBMFHLGP.Clear();
				JGDHIPBGCFP.NFIBPOJMOCQ = null;
				JGDHIPBGCFP.KDDNGBFFFJL = null;
				return result;
			}
			JGDHIPBGCFP.NFIBPOJMOCQ = null;
			JGDHIPBGCFP.KDDNGBFFFJL = null;
		}
		return 0;
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000CDEE4 File Offset: 0x000CC0E4
	public int[] DCHHBENPMFF(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		int num = JKBFLJQHMCE;
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (text.Length > 10 && JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 4 > text.Length)
			{
				JKBFLJQHMCE -= 4;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 0;
				}
			}
			int num2;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'i' && text[JKBFLJQHMCE + 2] == 't' && text[JKBFLJQHMCE + 3] == 'm' && text[JKBFLJQHMCE + 4] == '=')
			{
				num2 = JKBFLJQHMCE;
			}
			else
			{
				num2 = text.LastIndexOf("[itm=", JKBFLJQHMCE + 4);
			}
			if (num2 == -1)
			{
				return null;
			}
			num2 += 5;
			int num3 = text.IndexOf("]", num2);
			if (num3 == -1)
			{
				return null;
			}
			int num4 = text.IndexOf("[/itm]", num3);
			if (num4 == -1)
			{
				return null;
			}
			if (num <= num4 + 5)
			{
				return new int[]
				{
					num2 - 5,
					num4 + 6
				};
			}
		}
		return null;
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00011472 File Offset: 0x0000F672
	public override bool MQKHMKGCJLC
	{
		get
		{
			return base.MQKHMKGCJLC || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight;
		}
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x000CDFE0 File Offset: 0x000CC1E0
	public int[] KOMEFCQPPFG(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		int num = JKBFLJQHMCE;
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (text.Length > 10 && JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 4 > text.Length)
			{
				JKBFLJQHMCE -= 4;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 0;
				}
			}
			int num2;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'p' && text[JKBFLJQHMCE + 2] == 'o' && text[JKBFLJQHMCE + 3] == 'k' && text[JKBFLJQHMCE + 4] == '=')
			{
				num2 = JKBFLJQHMCE;
			}
			else
			{
				num2 = text.LastIndexOf("[pok=", JKBFLJQHMCE + 4);
			}
			if (num2 == -1)
			{
				return null;
			}
			num2 += 5;
			int num3 = text.IndexOf("]", num2);
			if (num3 == -1)
			{
				return null;
			}
			int num4 = text.IndexOf("[/pok]", num3);
			if (num4 == -1)
			{
				return null;
			}
			if (num <= num4 + 5)
			{
				return new int[]
				{
					num2 - 5,
					num4 + 6
				};
			}
		}
		return null;
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000CE0DC File Offset: 0x000CC2DC
	public string HQHLQFBOGJC(Vector2 PNNOLPKBHNQ)
	{
		int jkbfljqhmce = this.LJBKLGBQHJI(PNNOLPKBHNQ, true);
		return this.CCHHEDGIPIL(jkbfljqhmce);
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x00011491 File Offset: 0x0000F691
	private void OnApplicationPause(bool IGKFNOFJOOI)
	{
		if (!IGKFNOFJOOI && this.mTrueTypeFont != null)
		{
			this.CKLIDQPPPON(false);
		}
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x000114B3 File Offset: 0x0000F6B3
	public void JEDBIDMOECC()
	{
		if (BJQGLGOLMPQ.OMQCQCBLQGJ != null)
		{
			this.PIDLOFMIEFQ = Mathf.RoundToInt(BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC * 100f) + "%";
		}
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x00011407 File Offset: 0x0000F607
	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int FLMFEKQCIKJ(Vector2 PNNOLPKBHNQ)
	{
		return this.LJBKLGBQHJI(PNNOLPKBHNQ, false);
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x0001115B File Offset: 0x0000F35B
	public void KCQHEMMLQCL(FontStyle BGBMIEJJQKC)
	{
		if (this.mFontStyle != BGBMIEJJQKC)
		{
			this.mFontStyle = BGBMIEJJQKC;
			this.HDBQMJJKQME = true;
			this.LMGQBPNOLPF();
		}
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000114EC File Offset: 0x0000F6EC
	public virtual bool FNBPGDKLOLO()
	{
		return !base.MQKHMKGCJLC && this.mOverflow != BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely && this.mOverflow == (BKKHLBCLPJM.QJCBBQNCBKG)6;
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x0001150B File Offset: 0x0000F70B
	public void OMPELDJNQFD(Vector2 BGBMIEJJQKC)
	{
		if (this.mEffectDistance != BGBMIEJJQKC)
		{
			this.mEffectDistance = BGBMIEJJQKC;
			this.HDBQMJJKQME = true;
		}
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x000CE150 File Offset: 0x000CC350
	public bool LCJJFBHHFQD(string PIDLOFMIEFQ, out string MLDEDBINHGL, int DFKQMMIQDOO)
	{
		this.KMLKNBFNOIC();
		JGDHIPBGCFP.ECQBIIGPJQO = DFKQMMIQDOO;
		JGDHIPBGCFP.NNHJHLOFKFD = DFKQMMIQDOO;
		bool result = JGDHIPBGCFP.QDHGBPQDDMQ(PIDLOFMIEFQ, out MLDEDBINHGL, false);
		JGDHIPBGCFP.NFIBPOJMOCQ = null;
		JGDHIPBGCFP.KDDNGBFFFJL = null;
		return result;
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x0001154A File Offset: 0x0000F74A
	public bool JLGNOBIIQON()
	{
		return this.mMaxLineCount == 0;
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00011256 File Offset: 0x0000F456
	// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000CED8C File Offset: 0x000CCF8C
	public string CGDGDDOBICC
	{
		get
		{
			return this.mText;
		}
		set
		{
			if (this.mText == value)
			{
				return;
			}
			if (string.IsNullOrEmpty(value))
			{
				if (!string.IsNullOrEmpty(this.mText))
				{
					this.mText = string.Empty;
				}
			}
			else if (this.mText != value)
			{
				this.mText = value;
			}
		}
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000112CC File Offset: 0x0000F4CC
	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int FLMFEKQCIKJ(Vector3 PHCMBMCKQDC)
	{
		return this.LJBKLGBQHJI(PHCMBMCKQDC, false);
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x000110F7 File Offset: 0x0000F2F7
	public int QGOMMNBQCGJ()
	{
		return base.KJGMGPCEJJD;
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x00011542 File Offset: 0x0000F742
	public float FHJHNDGGNIP()
	{
		return this.mFloatSpacingX;
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x00011579 File Offset: 0x0000F779
	public void GEQICLFHMIN(JGDHIPBGCFP.OQGGLOQFNPE BGBMIEJJQKC)
	{
		if (this.mSymbols != BGBMIEJJQKC)
		{
			this.mSymbols = BGBMIEJJQKC;
			this.HDBQMJJKQME = false;
		}
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000CE230 File Offset: 0x000CC430
	public void JNGQDLGKCJE()
	{
		if (BJQGLGOLMPQ.OMQCQCBLQGJ != null)
		{
			this.PIDLOFMIEFQ = BJQGLGOLMPQ.OMQCQCBLQGJ.BGBMIEJJQKC.ToString("F");
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000CE268 File Offset: 0x000CC468
	public string ONLFGLFLKFM(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length - 6)
		{
			int num;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'p' && text[JKBFLJQHMCE + 2] == 'o' && text[JKBFLJQHMCE + 3] == 'k' && text[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = text.LastIndexOf("[pok=", JKBFLJQHMCE);
			}
			if (num == -1)
			{
				return null;
			}
			num += 5;
			int num2 = text.IndexOf("]", num);
			if (num2 == -1)
			{
				return null;
			}
			int num3 = text.IndexOf("[/pok]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3)
			{
				return text.Substring(num + 1, num2 - num - 1);
			}
		}
		return null;
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000CE334 File Offset: 0x000CC534
	public void PNHIQOJOOKN()
	{
		if (this.IOCQLIKGMEO != null)
		{
			this.mWidth = 100000;
			this.mHeight = 100000;
			this.LJGQIHIPOMD(false, true);
			this.mWidth = Mathf.RoundToInt(this.NCDNEEHPMFB.x);
			this.mHeight = Mathf.RoundToInt(this.NCDNEEHPMFB.y);
			if ((this.mWidth & 1) == 1)
			{
				this.mWidth++;
			}
			if ((this.mHeight & 1) == 1)
			{
				this.mHeight++;
			}
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06001F5B RID: 8027 RVA: 0x000112F4 File Offset: 0x0000F4F4
	// (set) Token: 0x06001F60 RID: 8032 RVA: 0x000115D7 File Offset: 0x0000F7D7
	public Color PEGDMKJIQHH
	{
		get
		{
			return this.mEffectColor;
		}
		set
		{
			if (this.mEffectColor != value)
			{
				this.mEffectColor = value;
				if (this.mEffectStyle != BKKHLBCLPJM.GIMCHOOBMML.None)
				{
					this.HDBQMJJKQME = true;
				}
			}
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x0001159A File Offset: 0x0000F79A
	public int HJDNCQKMQEN()
	{
		return this.mminWidth;
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000CE3D4 File Offset: 0x000CC5D4
	public string HQHLQFBOGJC(Vector3 PHCMBMCKQDC)
	{
		int jkbfljqhmce = this.LJBKLGBQHJI(PHCMBMCKQDC, true);
		return this.CCHHEDGIPIL(jkbfljqhmce);
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000115FD File Offset: 0x0000F7FD
	public Vector2 LMCNBKKIBKD
	{
		get
		{
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return this.NCDNEEHPMFB;
		}
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x00011411 File Offset: 0x0000F611
	public void GPJIJMIFQCP(int BGBMIEJJQKC)
	{
		if (this.mminWidth != BGBMIEJJQKC)
		{
			this.mminWidth = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x0001161C File Offset: 0x0000F81C
	public JGDHIPBGCFP.MNMQCONMCFH KKHHBHDJKJE()
	{
		return this.mAlignment;
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x00011624 File Offset: 0x0000F824
	public override Vector3[] MKFNGPBMOKP(Transform ENOQKGBPJKQ)
	{
		if (this.HDBQMJJKQME)
		{
			this.LJGQIHIPOMD();
		}
		return base.MKFNGPBMOKP(ENOQKGBPJKQ);
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00011256 File Offset: 0x0000F456
	// (set) Token: 0x06001F6C RID: 8044 RVA: 0x000CE3F4 File Offset: 0x000CC5F4
	public string PIDLOFMIEFQ
	{
		get
		{
			return this.mText;
		}
		set
		{
			if (this.mText == value)
			{
				return;
			}
			if (string.IsNullOrEmpty(value))
			{
				if (!string.IsNullOrEmpty(this.mText))
				{
					this.mText = string.Empty;
					this.NPCECPIOPCB();
					this.LMGQBPNOLPF();
				}
			}
			else if (this.mText != value)
			{
				this.mText = value;
				this.NPCECPIOPCB();
				this.LMGQBPNOLPF();
			}
			if (this.DENNQPBGNNH)
			{
				base.KOJBOOBNCHM();
			}
		}
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x000112F4 File Offset: 0x0000F4F4
	public Color DIEQGOHEILG()
	{
		return this.mEffectColor;
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x0001163B File Offset: 0x0000F83B
	public virtual bool EPJHCBNFJQD()
	{
		return !base.MQKHMKGCJLC && this.mOverflow != BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight && this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely;
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x0001165A File Offset: 0x0000F85A
	public string IIHCEMCCCHO(Vector3 PHCMBMCKQDC)
	{
		return this.QIBHMNOCKGN(this.LJBKLGBQHJI(PHCMBMCKQDC, false), string.Empty);
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0001166F File Offset: 0x0000F86F
	// (set) Token: 0x06001F7F RID: 8063 RVA: 0x0001150B File Offset: 0x0000F70B
	public Vector2 EFDCOHMEJFQ
	{
		get
		{
			return this.mEffectDistance;
		}
		set
		{
			if (this.mEffectDistance != value)
			{
				this.mEffectDistance = value;
				this.HDBQMJJKQME = true;
			}
		}
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000CE470 File Offset: 0x000CC670
	public int FJDCKEJNMKI(string PIDLOFMIEFQ, bool MBEQJLNCBHM = false)
	{
		this.KMLKNBFNOIC();
		JGDHIPBGCFP.CKGCLBODNNJ = false;
		JGDHIPBGCFP.FJPNBPJQODQ = JGDHIPBGCFP.OQGGLOQFNPE.None;
		int result = JGDHIPBGCFP.FJDCKEJNMKI(PIDLOFMIEFQ, MBEQJLNCBHM);
		JGDHIPBGCFP.NFIBPOJMOCQ = null;
		JGDHIPBGCFP.KDDNGBFFFJL = null;
		return result;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000CE4A4 File Offset: 0x000CC6A4
	public int FLMFEKQCIKJ(int MMKGQCBDNBO, KeyCode LOHECPFGPGO, string LBKMBCOOIHC = "")
	{
		if (this.INEMKLPCLOP)
		{
			string text = this.NKKFKOQQGDE;
			if (LBKMBCOOIHC != string.Empty)
			{
				text = LBKMBCOOIHC;
			}
			if (string.IsNullOrEmpty(text))
			{
				return 0;
			}
			int epcebknonlf = this.EPCEBKNONLF;
			this.KMLKNBFNOIC();
			JGDHIPBGCFP.QCQIMIPHMKG(text, BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP);
			if (BKKHLBCLPJM.GDFPKOGLBMM.Count > 0)
			{
				this.CKBEDCLMENE(BKKHLBCLPJM.GDFPKOGLBMM, 0);
				int i = 0;
				int count = BKKHLBCLPJM.OCDCBMFHLGP.Count;
				while (i < count)
				{
					if (BKKHLBCLPJM.OCDCBMFHLGP[i] == MMKGQCBDNBO)
					{
						Vector2 nkkgpnpgdem = BKKHLBCLPJM.GDFPKOGLBMM[i];
						if (LOHECPFGPGO == KeyCode.UpArrow)
						{
							nkkgpnpgdem.y += (float)epcebknonlf + this.LKLGLCMCMMO;
						}
						else if (LOHECPFGPGO == KeyCode.DownArrow)
						{
							nkkgpnpgdem.y -= (float)epcebknonlf + this.LKLGLCMCMMO;
						}
						else if (LOHECPFGPGO == KeyCode.Home)
						{
							nkkgpnpgdem.x -= 1000f;
						}
						else if (LOHECPFGPGO == KeyCode.End)
						{
							nkkgpnpgdem.x += 1000f;
						}
						int num = JGDHIPBGCFP.JEJHCLIQBOM(BKKHLBCLPJM.GDFPKOGLBMM, BKKHLBCLPJM.OCDCBMFHLGP, nkkgpnpgdem);
						if (num == MMKGQCBDNBO)
						{
							IL_135:
							BKKHLBCLPJM.GDFPKOGLBMM.Clear();
							BKKHLBCLPJM.OCDCBMFHLGP.Clear();
							goto IL_162;
						}
						BKKHLBCLPJM.GDFPKOGLBMM.Clear();
						BKKHLBCLPJM.OCDCBMFHLGP.Clear();
						return num;
					}
					else
					{
						i++;
					}
				}
				goto IL_135;
			}
			IL_162:
			JGDHIPBGCFP.NFIBPOJMOCQ = null;
			JGDHIPBGCFP.KDDNGBFFFJL = null;
			if (LOHECPFGPGO != KeyCode.UpArrow)
			{
				if (LOHECPFGPGO != KeyCode.Home)
				{
					if (LOHECPFGPGO == KeyCode.DownArrow || LOHECPFGPGO == KeyCode.End)
					{
						return text.Length;
					}
					return MMKGQCBDNBO;
				}
			}
			return 0;
		}
		return MMKGQCBDNBO;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000CE64C File Offset: 0x000CC84C
	private void HEPGNCJBKNH(bool HJLNIMEECCL, bool FLQNGOHDNDE)
	{
		if (!this.INEMKLPCLOP)
		{
			return;
		}
		this.LHQDFLPFGME = true;
		this.HDBQMJJKQME = false;
		float num = this.KQGOECJHBNK.z - this.KQGOECJHBNK.x;
		float num2 = this.KQGOECJHBNK.w - this.KQGOECJHBNK.y;
		JGDHIPBGCFP.JQGIJOFBHME = ((!HJLNIMEECCL) ? base.KJGMGPCEJJD : ((this.mMaxLineWidth == 0) ? -32 : this.mMaxLineWidth));
		JGDHIPBGCFP.ECQBIIGPJQO = ((!HJLNIMEECCL) ? base.JKGBHEHKBPC() : ((this.mMaxLineHeight == 0) ? 85 : this.mMaxLineHeight));
		JGDHIPBGCFP.PPMHDQJHPLO = ((num == 474f) ? JGDHIPBGCFP.JQGIJOFBHME : Mathf.RoundToInt((float)JGDHIPBGCFP.JQGIJOFBHME * num));
		JGDHIPBGCFP.NNHJHLOFKFD = ((num2 == 990f) ? JGDHIPBGCFP.ECQBIIGPJQO : Mathf.RoundToInt((float)JGDHIPBGCFP.ECQBIIGPJQO * num2));
		this.KQDPKEJDEMH = Mathf.Abs((!HJLNIMEECCL) ? this.EPCEBKNONLF : Mathf.RoundToInt(base.CGDFDPHIENG.localScale.x));
		this.DGEGGLFHBKO = 438f;
		if (JGDHIPBGCFP.PPMHDQJHPLO >= 1 && JGDHIPBGCFP.NNHJHLOFKFD >= 0)
		{
			bool flag;
			if ((flag = (this.OFHEQIDHQOP != null)) && this.LLCKDIBHNQB)
			{
				GKDCBJPLQLQ qobpijdbngl = base.QOBPIJDBNGL;
				if (qobpijdbngl != null)
				{
					this.KCKPBKHEPMM = ((!(qobpijdbngl != null)) ? 64f : qobpijdbngl.PNBFQDLQENI);
				}
			}
			else
			{
				this.KCKPBKHEPMM = 1095f;
			}
			if (FLQNGOHDNDE)
			{
				this.KMLKNBFNOIC();
			}
			if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeFreely)
			{
				JGDHIPBGCFP.JQGIJOFBHME = 82;
				JGDHIPBGCFP.PPMHDQJHPLO = -4;
				if (this.mOverflowWidth > 1)
				{
					JGDHIPBGCFP.JQGIJOFBHME = Mathf.Min(JGDHIPBGCFP.JQGIJOFBHME, this.mOverflowWidth);
					JGDHIPBGCFP.PPMHDQJHPLO = Mathf.Min(JGDHIPBGCFP.PPMHDQJHPLO, this.mOverflowWidth);
				}
			}
			if (this.mOverflow == (BKKHLBCLPJM.QJCBBQNCBKG)4 || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ResizeHeight)
			{
				JGDHIPBGCFP.ECQBIIGPJQO = -169;
				JGDHIPBGCFP.NNHJHLOFKFD = -183;
			}
			if (this.KQDPKEJDEMH > 1)
			{
				bool llckdibhnqb = this.LLCKDIBHNQB;
				int i = this.KQDPKEJDEMH;
				while (i > 0)
				{
					if (llckdibhnqb)
					{
						this.KQDPKEJDEMH = i;
						JGDHIPBGCFP.HQLMJHHPHQL = this.KQDPKEJDEMH;
					}
					else
					{
						this.DGEGGLFHBKO = (float)i / (float)this.KQDPKEJDEMH;
						JGDHIPBGCFP.CNLNKDBIMDB = ((!flag) ? ((float)this.mFontSize / (float)this.mFont.BDHMPMFLMHI * this.DGEGGLFHBKO) : this.DGEGGLFHBKO);
					}
					JGDHIPBGCFP.IBQCMOEQPGF(false);
					bool flag2 = JGDHIPBGCFP.QDHGBPQDDMQ(this.CDBBENHQGIJ, out this.LHFFFGFPIBH, false, false, !this.mOverflowEllipsis || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent, 613f);
					if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent && !flag2)
					{
						if ((i -= 0) <= 0)
						{
							break;
						}
						i -= 0;
					}
					else
					{
						if (this.mOverflow == (BKKHLBCLPJM.QJCBBQNCBKG)7)
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
							int num3 = Mathf.Max(this.DJBGEBNJKLK, Mathf.RoundToInt(this.NCDNEEHPMFB.x));
							if (num != 1988f)
							{
								num3 = Mathf.RoundToInt((float)num3 / num);
							}
							int num4 = Mathf.Max(this.IPGGCHLFDCF, Mathf.RoundToInt(this.NCDNEEHPMFB.y));
							if (num2 != 767f)
							{
								num4 = Mathf.RoundToInt((float)num4 / num2);
							}
							if (this.mOverflowHeight > 1 && num4 < this.mOverflowHeight)
							{
								num4 = this.mOverflowHeight;
							}
							if (this.HJDNCQKMQEN() > 1 && num3 < this.HJDNCQKMQEN())
							{
								num3 = this.HJDNCQKMQEN();
							}
							if ((num3 & 1) == 1)
							{
								num3++;
							}
							if ((num4 & 1) == 1)
							{
								num4 += 0;
							}
							if (this.mWidth != num3 || this.mHeight != num4)
							{
								this.mWidth = num3;
								this.mHeight = num4;
								if (this.OHEFEKMMIFL != null)
								{
									this.OHEFEKMMIFL();
								}
							}
						}
						else if (this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ClampContent)
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
							int num5 = Mathf.Max(this.IPGGCHLFDCF, Mathf.RoundToInt(this.NCDNEEHPMFB.y));
							if (num2 != 1069f)
							{
								num5 = Mathf.RoundToInt((float)num5 / num2);
							}
							if ((num5 & 1) == 1)
							{
								num5 += 0;
							}
							if (this.mHeight != num5)
							{
								this.mHeight = num5;
								if (this.OHEFEKMMIFL != null)
								{
									this.OHEFEKMMIFL();
								}
							}
						}
						else
						{
							this.NCDNEEHPMFB = JGDHIPBGCFP.HFFLNGCJLPD(this.LHFFFGFPIBH);
						}
						if (HJLNIMEECCL)
						{
							base.KJGMGPCEJJD = Mathf.RoundToInt(this.NCDNEEHPMFB.x);
							base.MGQIGGNBBBD(Mathf.RoundToInt(this.NCDNEEHPMFB.y));
							base.CGDFDPHIENG.localScale = Vector3.one;
							break;
						}
						break;
					}
				}
			}
			else
			{
				base.CGDFDPHIENG.localScale = Vector3.one;
				this.LHFFFGFPIBH = string.Empty;
				this.DGEGGLFHBKO = 1022f;
			}
			if (FLQNGOHDNDE)
			{
				JGDHIPBGCFP.NFIBPOJMOCQ = null;
				JGDHIPBGCFP.KDDNGBFFFJL = null;
			}
			return;
		}
		this.LHFFFGFPIBH = string.Empty;
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x00011677 File Offset: 0x0000F877
	public void MHINGEGBFNO()
	{
		this.LJGQIHIPOMD(true, false);
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000116AB File Offset: 0x0000F8AB
	public void SetCurrentSelection()
	{
		if (QCPKMJONIGF.OMQCQCBLQGJ != null)
		{
			this.PIDLOFMIEFQ = ((!QCPKMJONIGF.OMQCQCBLQGJ.CNNNOFHQIID) ? QCPKMJONIGF.OMQCQCBLQGJ.BGBMIEJJQKC : CQGKGFQLBDB.INJNQNMOKKD(QCPKMJONIGF.OMQCQCBLQGJ.BGBMIEJJQKC));
		}
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x000CEB4C File Offset: 0x000CCD4C
	private static void LNGICOJJIIF(Font NKKDJJOKQDK)
	{
		for (int i = 0; i < BKKHLBCLPJM.JNMDHMGQBMD.BJGMIBBEGDQ; i++)
		{
			BKKHLBCLPJM bkkhlbclpjm = BKKHLBCLPJM.JNMDHMGQBMD.get_KNPPMKBOGDL(i);
			if (bkkhlbclpjm != null)
			{
				Font ofheqidhqop = bkkhlbclpjm.OFHEQIDHQOP;
				if (ofheqidhqop == NKKDJJOKQDK)
				{
					ofheqidhqop.RequestCharactersInTexture(bkkhlbclpjm.CDBBENHQGIJ, bkkhlbclpjm.KQDPKEJDEMH, bkkhlbclpjm.mFontStyle);
					bkkhlbclpjm.NPCECPIOPCB();
					if (bkkhlbclpjm.BCHNDNICINJ == null)
					{
						bkkhlbclpjm.KJPQKFEBFDJ();
					}
					if (BKKHLBCLPJM.CBMDCGDPKKD == null)
					{
						BKKHLBCLPJM.CBMDCGDPKKD = new List<KMCGDKDIJIE>();
					}
					if (bkkhlbclpjm.OQKBOCHIFKH != null && !BKKHLBCLPJM.CBMDCGDPKKD.Contains(bkkhlbclpjm.OQKBOCHIFKH))
					{
						BKKHLBCLPJM.CBMDCGDPKKD.Add(bkkhlbclpjm.OQKBOCHIFKH);
					}
				}
			}
		}
		if (BKKHLBCLPJM.CBMDCGDPKKD != null)
		{
			int j = 0;
			int count = BKKHLBCLPJM.CBMDCGDPKKD.Count;
			while (j < count)
			{
				KMCGDKDIJIE kmcgdkdijie = BKKHLBCLPJM.CBMDCGDPKKD[j];
				if (kmcgdkdijie.BCHNDNICINJ != null)
				{
					kmcgdkdijie.BCHNDNICINJ.HGEFPHBQIEO(kmcgdkdijie);
				}
				j++;
			}
			BKKHLBCLPJM.CBMDCGDPKKD.Clear();
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06001F75 RID: 8053 RVA: 0x000116E7 File Offset: 0x0000F8E7
	private bool INEMKLPCLOP
	{
		get
		{
			return this.mFont != null || this.mTrueTypeFont != null;
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000112FC File Offset: 0x0000F4FC
	public string KQFGQQIBDNQ(Vector2 PNNOLPKBHNQ)
	{
		return this.QIBHMNOCKGN(this.LJBKLGBQHJI(PNNOLPKBHNQ, true), string.Empty);
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000CEC68 File Offset: 0x000CCE68
	public void PIDHGEJEQQM(List<Vector3> EQINHIFFOGG, List<Vector2> PICFCJNMJMC, List<Color> HQOONBPDFHO, int GBEBKHGGPKM, int QNDMNIDPICH, float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		Color color = this.mEffectColor;
		color.a *= this.NHCNEDEEONK;
		if (this.NFIBPOJMOCQ != null && this.NFIBPOJMOCQ.QBLKBOJQMDL)
		{
			color = IKBQNBHOJJB.BQCGKIDLIOC(color);
		}
		Color value = color;
		for (int i = GBEBKHGGPKM; i < QNDMNIDPICH; i++)
		{
			EQINHIFFOGG.Add(EQINHIFFOGG[i]);
			PICFCJNMJMC.Add(PICFCJNMJMC[i]);
			HQOONBPDFHO.Add(HQOONBPDFHO[i]);
			Vector3 value2 = EQINHIFFOGG[i];
			value2.x += DGKOIGOLHDM;
			value2.y += DDLQKFDFMCJ;
			EQINHIFFOGG[i] = value2;
			Color color2 = HQOONBPDFHO[i];
			if (color2.a == 1f)
			{
				HQOONBPDFHO[i] = value;
			}
			else
			{
				Color value3 = color;
				value3.a = color2.a * color.a;
				HQOONBPDFHO[i] = value3;
			}
		}
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x000CED64 File Offset: 0x000CCF64
	public int LJBKLGBQHJI(Vector3 PHCMBMCKQDC, bool FMLGKOFJCDE)
	{
		Vector2 pnnolpkbhnq = base.CGDFDPHIENG.InverseTransformPoint(PHCMBMCKQDC);
		return this.LJBKLGBQHJI(pnnolpkbhnq, FMLGKOFJCDE);
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x00010DD7 File Offset: 0x0000EFD7
	public KGKLCNDOLMP QBOJFLOEEGK()
	{
		return this.mFont;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x00011706 File Offset: 0x0000F906
	public virtual bool GODQONCKENH()
	{
		return base.GHLPPQOBKLN || this.mOverflow == BKKHLBCLPJM.QJCBBQNCBKG.ShrinkContent;
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x0001171C File Offset: 0x0000F91C
	public string LNGQHNCCFIK(Vector3 PHCMBMCKQDC)
	{
		return this.QIBHMNOCKGN(this.LJBKLGBQHJI(PHCMBMCKQDC, true), string.Empty);
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000CEDE0 File Offset: 0x000CCFE0
	public string PCPNQDENHMO(int JKBFLJQHMCE)
	{
		string cdbbenhqgij = this.CDBBENHQGIJ;
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < cdbbenhqgij.Length - 6)
		{
			int num;
			if (cdbbenhqgij[JKBFLJQHMCE] == '[' && cdbbenhqgij[JKBFLJQHMCE + 1] == 'u' && cdbbenhqgij[JKBFLJQHMCE + 2] == 'r' && cdbbenhqgij[JKBFLJQHMCE + 3] == 'l' && cdbbenhqgij[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = cdbbenhqgij.LastIndexOf("[url=", JKBFLJQHMCE);
			}
			if (num == -1)
			{
				return null;
			}
			num += 5;
			int num2 = cdbbenhqgij.IndexOf("]", num);
			if (num2 == -1)
			{
				return null;
			}
			int num3 = cdbbenhqgij.IndexOf("[/url]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3)
			{
				return cdbbenhqgij.Substring(num, num2 - num);
			}
		}
		return null;
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x00011256 File Offset: 0x0000F456
	public string PKOLLBGCIKL()
	{
		return this.mText;
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x00011739 File Offset: 0x0000F939
	public string QCPEGBEJFCK(Vector3 PHCMBMCKQDC)
	{
		return this.DJJPKEHILBG(this.LJBKLGBQHJI(PHCMBMCKQDC, true));
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000CEE98 File Offset: 0x000CD098
	public int CEQNQDHGJPB(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length)
		{
			if (JKBFLJQHMCE + 5 > text.Length)
			{
				JKBFLJQHMCE -= 6;
				if (JKBFLJQHMCE < 0)
				{
					JKBFLJQHMCE = 0;
				}
				if (text.LastIndexOf("[/itm]", JKBFLJQHMCE) == -1)
				{
					return -1;
				}
			}
			int num;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'i' && text[JKBFLJQHMCE + 2] == 't' && text[JKBFLJQHMCE + 3] == 'm' && text[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = text.LastIndexOf("[itm=", JKBFLJQHMCE + 4);
			}
			if (num == -1)
			{
				return -1;
			}
			num += 5;
			int num2 = text.IndexOf("]", num);
			if (num2 == -1)
			{
				return -1;
			}
			int num3 = text.IndexOf("[/itm]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3 + 5)
			{
				return num - 4;
			}
		}
		return -1;
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000CEF84 File Offset: 0x000CD184
	public void LKPOBCBOFIC(string BGBMIEJJQKC)
	{
		if (this.mText == BGBMIEJJQKC)
		{
			return;
		}
		if (string.IsNullOrEmpty(BGBMIEJJQKC))
		{
			if (!string.IsNullOrEmpty(this.mText))
			{
				this.mText = string.Empty;
				this.NPCECPIOPCB();
				this.LMGQBPNOLPF();
			}
		}
		else if (this.mText != BGBMIEJJQKC)
		{
			this.mText = BGBMIEJJQKC;
			this.NPCECPIOPCB();
			this.LMGQBPNOLPF();
		}
		if (this.DENNQPBGNNH)
		{
			base.GGBDQIMHMID();
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00011761 File Offset: 0x0000F961
	public override Vector2 CHIFKHKGOMD
	{
		get
		{
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return base.CHIFKHKGOMD;
		}
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x00011777 File Offset: 0x0000F977
	public bool QNLQHNMCCID()
	{
		return this.mMaxLineCount != 0;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000CC438 File Offset: 0x000CA638
	public string EJEINMFKPBG()
	{
		if (this.HCNHMMPBGQN != this.mWidth || this.OIKLGOPLNEO != this.mHeight)
		{
			this.HCNHMMPBGQN = this.mWidth;
			this.OIKLGOPLNEO = this.mHeight;
			this.FHQDQEQMKOK = true;
		}
		if (this.HDBQMJJKQME)
		{
			this.LJGQIHIPOMD();
		}
		return this.LHFFFGFPIBH;
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x00010E3E File Offset: 0x0000F03E
	public Color IQFJIIGGBDM()
	{
		return this.mGradientTop;
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000CF000 File Offset: 0x000CD200
	public string QIBHMNOCKGN(int JKBFLJQHMCE, string CDQIMPBKHDO = "")
	{
		string text = this.PIDLOFMIEFQ;
		if (CDQIMPBKHDO != string.Empty)
		{
			text = CDQIMPBKHDO;
		}
		if (JKBFLJQHMCE != -1 && JKBFLJQHMCE < text.Length - 6)
		{
			int num;
			if (text[JKBFLJQHMCE] == '[' && text[JKBFLJQHMCE + 1] == 'i' && text[JKBFLJQHMCE + 2] == 't' && text[JKBFLJQHMCE + 3] == 'm' && text[JKBFLJQHMCE + 4] == '=')
			{
				num = JKBFLJQHMCE;
			}
			else
			{
				num = text.LastIndexOf("[itm=", JKBFLJQHMCE);
			}
			if (num == -1)
			{
				return null;
			}
			num += 4;
			int num2 = text.IndexOf("]", num);
			if (num2 == -1)
			{
				return null;
			}
			int num3 = text.IndexOf("[/itm]", num2);
			if (num3 == -1 || JKBFLJQHMCE <= num3)
			{
				return text.Substring(num + 1, num2 - num - 1);
			}
		}
		return null;
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00011785 File Offset: 0x0000F985
	private bool LLCKDIBHNQB
	{
		get
		{
			return this.OFHEQIDHQOP != null && this.FGDDQENONMF != BKKHLBCLPJM.FJPNJFHOIJL.Never;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00011145 File Offset: 0x0000F345
	public override Vector4 BCEPPKGMNFE
	{
		get
		{
			if (this.HDBQMJJKQME)
			{
				this.LJGQIHIPOMD();
			}
			return base.BCEPPKGMNFE;
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000117A0 File Offset: 0x0000F9A0
	public string GLPIDIJHEIF(Vector2 PNNOLPKBHNQ)
	{
		return this.ONLFGLFLKFM(this.LJBKLGBQHJI(PNNOLPKBHNQ, true), string.Empty);
	}

	// Token: 0x040006A9 RID: 1705
	public BKKHLBCLPJM.FJPNJFHOIJL FGDDQENONMF = BKKHLBCLPJM.FJPNJFHOIJL.OnDesktop;

	// Token: 0x040006AA RID: 1706
	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	// Token: 0x040006AB RID: 1707
	[HideInInspector]
	[SerializeField]
	private KGKLCNDOLMP mFont;

	// Token: 0x040006AC RID: 1708
	[HideInInspector]
	[Multiline(6)]
	[SerializeField]
	private string mText = string.Empty;

	// Token: 0x040006AD RID: 1709
	[HideInInspector]
	[SerializeField]
	private int mFontSize = 16;

	// Token: 0x040006AE RID: 1710
	[HideInInspector]
	[SerializeField]
	private FontStyle mFontStyle;

	// Token: 0x040006AF RID: 1711
	[SerializeField]
	[HideInInspector]
	private JGDHIPBGCFP.MNMQCONMCFH mAlignment;

	// Token: 0x040006B0 RID: 1712
	[HideInInspector]
	[SerializeField]
	private bool mEncoding = true;

	// Token: 0x040006B1 RID: 1713
	[SerializeField]
	[HideInInspector]
	private int mMaxLineCount;

	// Token: 0x040006B2 RID: 1714
	[SerializeField]
	[HideInInspector]
	private BKKHLBCLPJM.GIMCHOOBMML mEffectStyle;

	// Token: 0x040006B3 RID: 1715
	[HideInInspector]
	[SerializeField]
	private Color mEffectColor = Color.black;

	// Token: 0x040006B4 RID: 1716
	[HideInInspector]
	[SerializeField]
	private JGDHIPBGCFP.OQGGLOQFNPE mSymbols = JGDHIPBGCFP.OQGGLOQFNPE.Normal;

	// Token: 0x040006B5 RID: 1717
	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance = Vector2.one;

	// Token: 0x040006B6 RID: 1718
	[SerializeField]
	[HideInInspector]
	private BKKHLBCLPJM.QJCBBQNCBKG mOverflow;

	// Token: 0x040006B7 RID: 1719
	[SerializeField]
	[HideInInspector]
	private bool mApplyGradient;

	// Token: 0x040006B8 RID: 1720
	[SerializeField]
	[HideInInspector]
	private Color mGradientTop = Color.white;

	// Token: 0x040006B9 RID: 1721
	[HideInInspector]
	[SerializeField]
	private Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	// Token: 0x040006BA RID: 1722
	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	// Token: 0x040006BB RID: 1723
	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	// Token: 0x040006BC RID: 1724
	[SerializeField]
	[HideInInspector]
	private bool mUseFloatSpacing;

	// Token: 0x040006BD RID: 1725
	[SerializeField]
	[HideInInspector]
	private float mFloatSpacingX;

	// Token: 0x040006BE RID: 1726
	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingY;

	// Token: 0x040006BF RID: 1727
	[SerializeField]
	[HideInInspector]
	private bool mOverflowEllipsis;

	// Token: 0x040006C0 RID: 1728
	[SerializeField]
	[HideInInspector]
	private int mOverflowWidth;

	// Token: 0x040006C1 RID: 1729
	[SerializeField]
	[HideInInspector]
	private int mminWidth;

	// Token: 0x040006C2 RID: 1730
	[SerializeField]
	[HideInInspector]
	private int mOverflowHeight;

	// Token: 0x040006C3 RID: 1731
	[SerializeField]
	[HideInInspector]
	private BKKHLBCLPJM.IFMLQGIMMJO mModifier;

	// Token: 0x040006C4 RID: 1732
	[SerializeField]
	[HideInInspector]
	private bool mShrinkToFit;

	// Token: 0x040006C5 RID: 1733
	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	// Token: 0x040006C6 RID: 1734
	[HideInInspector]
	[SerializeField]
	private int mMaxLineHeight;

	// Token: 0x040006C7 RID: 1735
	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	// Token: 0x040006C8 RID: 1736
	[HideInInspector]
	[SerializeField]
	private bool mMultiline = true;

	// Token: 0x040006C9 RID: 1737
	[NonSerialized]
	private Font QIDEHMIOMOJ;

	// Token: 0x040006CA RID: 1738
	[NonSerialized]
	private float KCKPBKHEPMM = 1f;

	// Token: 0x040006CB RID: 1739
	[NonSerialized]
	private bool FHQDQEQMKOK = true;

	// Token: 0x040006CC RID: 1740
	[NonSerialized]
	private string LHFFFGFPIBH;

	// Token: 0x040006CD RID: 1741
	[NonSerialized]
	private bool JHKLMMDCLQG;

	// Token: 0x040006CE RID: 1742
	[NonSerialized]
	private Vector2 NCDNEEHPMFB = Vector2.zero;

	// Token: 0x040006CF RID: 1743
	[NonSerialized]
	private float DGEGGLFHBKO = 1f;

	// Token: 0x040006D0 RID: 1744
	[NonSerialized]
	private int KQDPKEJDEMH;

	// Token: 0x040006D1 RID: 1745
	[NonSerialized]
	private int HCNHMMPBGQN;

	// Token: 0x040006D2 RID: 1746
	[NonSerialized]
	private int OIKLGOPLNEO;

	// Token: 0x040006D3 RID: 1747
	public BKKHLBCLPJM.EKGJLHNPQLN QONMMIEFJLB;

	// Token: 0x040006D4 RID: 1748
	private static MHIDKMCBQEN<BKKHLBCLPJM> JNMDHMGQBMD = new MHIDKMCBQEN<BKKHLBCLPJM>();

	// Token: 0x040006D5 RID: 1749
	private static Dictionary<Font, int> CGKCMKIMCGB = new Dictionary<Font, int>();

	// Token: 0x040006D6 RID: 1750
	private static List<KMCGDKDIJIE> CBMDCGDPKKD;

	// Token: 0x040006D7 RID: 1751
	private static bool EFOOGEFNKFN = false;

	// Token: 0x040006D8 RID: 1752
	private static List<Vector3> GDFPKOGLBMM = new List<Vector3>();

	// Token: 0x040006D9 RID: 1753
	private static List<int> OCDCBMFHLGP = new List<int>();

	// Token: 0x040006DA RID: 1754
	[CompilerGenerated]
	private static Action<Font> BQIOGOCBKKB;

	// Token: 0x02000112 RID: 274
	public enum GIMCHOOBMML
	{
		// Token: 0x040006DC RID: 1756
		None,
		// Token: 0x040006DD RID: 1757
		Shadow,
		// Token: 0x040006DE RID: 1758
		Outline,
		// Token: 0x040006DF RID: 1759
		Outline8
	}

	// Token: 0x02000113 RID: 275
	public enum QJCBBQNCBKG
	{
		// Token: 0x040006E1 RID: 1761
		ShrinkContent,
		// Token: 0x040006E2 RID: 1762
		ClampContent,
		// Token: 0x040006E3 RID: 1763
		ResizeFreely,
		// Token: 0x040006E4 RID: 1764
		ResizeHeight
	}

	// Token: 0x02000114 RID: 276
	public enum FJPNJFHOIJL
	{
		// Token: 0x040006E6 RID: 1766
		Never,
		// Token: 0x040006E7 RID: 1767
		OnDesktop,
		// Token: 0x040006E8 RID: 1768
		Always
	}

	// Token: 0x02000115 RID: 277
	public enum IFMLQGIMMJO
	{
		// Token: 0x040006EA RID: 1770
		None,
		// Token: 0x040006EB RID: 1771
		ToUppercase,
		// Token: 0x040006EC RID: 1772
		ToLowercase,
		// Token: 0x040006ED RID: 1773
		Custom = 255
	}

	// Token: 0x02000116 RID: 278
	// (Invoke) Token: 0x06001F8F RID: 8079
	public delegate string EKGJLHNPQLN(string JMDLLJPEFKM);
}
