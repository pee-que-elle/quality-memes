using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000108 RID: 264
[AddComponentMenu("NGUI/UI/NGUI Font")]
[ExecuteInEditMode]
public class KGKLCNDOLMP : MonoBehaviour
{
	// Token: 0x06001DA9 RID: 7593 RVA: 0x000C4D68 File Offset: 0x000C2F68
	public static bool KNDFJQLODFQ(KGKLCNDOLMP ECHMFPQNBMC, KGKLCNDOLMP IBMINEHKPFF)
	{
		return !(ECHMFPQNBMC == null) && !(IBMINEHKPFF == null) && ((ECHMFPQNBMC.IIENDKNLHMC && IBMINEHKPFF.IIENDKNLHMC && ECHMFPQNBMC.KDDNGBFFFJL.fontNames[0] == IBMINEHKPFF.KDDNGBFFFJL.fontNames[0]) || ECHMFPQNBMC == IBMINEHKPFF || ECHMFPQNBMC.BHPKNPQNJPM(IBMINEHKPFF) || IBMINEHKPFF.BHPKNPQNJPM(ECHMFPQNBMC));
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x00010141 File Offset: 0x0000E341
	public int CECEPHLMPKQ()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.OOLNHIIJMOO();
		}
		if (!this.JDFNMMNJIBK() && this.mFont != null)
		{
			return this.mFont.QQPFJPGKIKO();
		}
		return this.mDynamicFontSize;
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0001017F File Offset: 0x0000E37F
	// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x00010654 File Offset: 0x0000E854
	public FontStyle MNPNLKCOMJG
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mDynamicFontStyle : this.mReplacement.MNPNLKCOMJG;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.MNPNLKCOMJG = value;
			}
			else if (this.mDynamicFontStyle != value)
			{
				this.mDynamicFontStyle = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000C4DD8 File Offset: 0x000C2FD8
	// (set) Token: 0x06001DAC RID: 7596 RVA: 0x000101A2 File Offset: 0x0000E3A2
	public Material PPLIPCEHGNM
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.PPLIPCEHGNM;
			}
			if (this.mAtlas != null)
			{
				return this.mAtlas.MPGCGDBECHM;
			}
			if (this.mMat != null)
			{
				if (this.mDynamicFont != null && this.mMat != this.mDynamicFont.material)
				{
					this.mMat.mainTexture = this.mDynamicFont.material.mainTexture;
				}
				return this.mMat;
			}
			if (this.mDynamicFont != null)
			{
				return this.mDynamicFont.material;
			}
			return null;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.PPLIPCEHGNM = value;
			}
			else if (this.mMat != value)
			{
				this.DHCCBPDMIBQ = -1;
				this.mMat = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x000101E2 File Offset: 0x0000E3E2
	public void FHHKELHDFFJ(Material BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.PPLIPCEHGNM = BGBMIEJJQKC;
		}
		else if (this.mMat != BGBMIEJJQKC)
		{
			this.DHCCBPDMIBQ = -1;
			this.mMat = BGBMIEJJQKC;
			this.PODOMKFFHFH();
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x000105D5 File Offset: 0x0000E7D5
	// (set) Token: 0x06001DAF RID: 7599 RVA: 0x00010222 File Offset: 0x0000E422
	public int BDHMPMFLMHI
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.BDHMPMFLMHI;
			}
			if (!this.IIENDKNLHMC && this.mFont != null)
			{
				return this.mFont.charSize;
			}
			return this.mDynamicFontSize;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.BDHMPMFLMHI = value;
			}
			else
			{
				this.mDynamicFontSize = value;
			}
		}
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x000C4E8C File Offset: 0x000C308C
	public void PODOMKFFHFH()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.NPCECPIOPCB();
		}
		this.LNMJLFLDCML = null;
		BKKHLBCLPJM[] array = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int i = 1;
		int num = array.Length;
		while (i < num)
		{
			BKKHLBCLPJM bkkhlbclpjm = array[i];
			if (bkkhlbclpjm.enabled && IKBQNBHOJJB.PBBDNDMELHQ(bkkhlbclpjm.gameObject) && KGKLCNDOLMP.KNDFJQLODFQ(this, bkkhlbclpjm.NFIBPOJMOCQ))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.QBOJFLOEEGK();
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			i += 0;
		}
		int j = 0;
		int count = this.OMIDEBFBQBQ.Count;
		while (j < count)
		{
			this.OMIDEBFBQBQ[j].GMCQOPQQMNP();
			j += 0;
		}
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000C4F40 File Offset: 0x000C3140
	public void HNQQNLCLMHP(string NLFQGDGEPFO, string JIDIKNLLDOO)
	{
		BMSymbol bmsymbol = this.CHLPMCCFDPP(NLFQGDGEPFO, false);
		if (bmsymbol != null)
		{
			bmsymbol.sequence = JIDIKNLLDOO;
		}
		this.NPCECPIOPCB();
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000C4F68 File Offset: 0x000C3168
	private BMSymbol CHLPMCCFDPP(string KJMHINNELJJ, bool IBKGGGCBJCL)
	{
		int i = 0;
		int count = this.mSymbols.Count;
		while (i < count)
		{
			BMSymbol bmsymbol = this.mSymbols[i];
			if (bmsymbol.sequence == KJMHINNELJJ)
			{
				return bmsymbol;
			}
			i++;
		}
		if (IBKGGGCBJCL)
		{
			BMSymbol bmsymbol2 = new BMSymbol();
			bmsymbol2.sequence = KJMHINNELJJ;
			this.mSymbols.Add(bmsymbol2);
			return bmsymbol2;
		}
		return null;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00010247 File Offset: 0x0000E447
	public List<BMSymbol> MLQNMJHEOMJ()
	{
		return (!(this.mReplacement != null)) ? this.mSymbols : this.mReplacement.OMIDEBFBQBQ;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000C4FCC File Offset: 0x000C31CC
	public UISpriteData QPQLHJJJLCD()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.QPQLHJJJLCD();
		}
		if (this.LNMJLFLDCML == null && this.mAtlas != null && !string.IsNullOrEmpty(this.mFont.spriteName))
		{
			this.LNMJLFLDCML = this.mAtlas.GMEDHEOGFMB(this.mFont.spriteName);
			if (this.LNMJLFLDCML == null)
			{
				this.LNMJLFLDCML = this.mAtlas.KPQNNOJJKDO(base.name);
			}
			if (this.LNMJLFLDCML == null)
			{
				this.mFont.spriteName = null;
			}
			else
			{
				this.MOCQLICGNPM();
			}
			int i = 1;
			int count = this.mSymbols.Count;
			while (i < count)
			{
				this.MLQNMJHEOMJ()[i].GMCQOPQQMNP();
				i++;
			}
		}
		return this.LNMJLFLDCML;
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0001026A File Offset: 0x0000E46A
	// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x000C5E8C File Offset: 0x000C408C
	public string KCLBMPFIPNQ
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mFont.spriteName : this.mReplacement.KCLBMPFIPNQ;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.KCLBMPFIPNQ = value;
			}
			else if (this.mFont.spriteName != value)
			{
				this.mFont.spriteName = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00010292 File Offset: 0x0000E492
	private Texture PGDHCNJKCGD
	{
		get
		{
			if (this.mReplacement)
			{
				return this.mReplacement.PGDHCNJKCGD;
			}
			if (this.IIENDKNLHMC)
			{
				return this.mDynamicFont.material.mainTexture;
			}
			return null;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00010247 File Offset: 0x0000E447
	public List<BMSymbol> OMIDEBFBQBQ
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mSymbols : this.mReplacement.OMIDEBFBQBQ;
		}
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x000102C7 File Offset: 0x0000E4C7
	public BMFont OKPOQOLHJGK()
	{
		return (!(this.mReplacement != null)) ? this.mFont : this.mReplacement.OKPOQOLHJGK();
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x000102EA File Offset: 0x0000E4EA
	public void NIOOHDDGIQF(int BGBMIEJJQKC)
	{
		this.BDHMPMFLMHI = BGBMIEJJQKC;
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00010631 File Offset: 0x0000E831
	// (set) Token: 0x06001DBA RID: 7610 RVA: 0x000102F3 File Offset: 0x0000E4F3
	public BMFont ICJBMNQMGGD
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mFont : this.mReplacement.ICJBMNQMGGD;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.ICJBMNQMGGD = value;
			}
			else
			{
				this.mFont = value;
			}
		}
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00010318 File Offset: 0x0000E518
	public string MLDCIQBEGNF()
	{
		return (!(this.mReplacement != null)) ? this.mFont.spriteName : this.mReplacement.MLDCIQBEGNF();
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x000C50AC File Offset: 0x000C32AC
	public BMSymbol EIJDIDPMNMP(string PIDLOFMIEFQ, int LCMMCNFNHMF, int JBPDNFNEEKP)
	{
		int count = this.mSymbols.Count;
		if (count == 0)
		{
			return null;
		}
		JBPDNFNEEKP -= LCMMCNFNHMF;
		for (int i = 0; i < count; i += 0)
		{
			BMSymbol bmsymbol = this.mSymbols[i];
			int num = bmsymbol.NBGQQOMJMIF();
			if (num != 0 && JBPDNFNEEKP >= num)
			{
				bool flag = false;
				int j = 0;
				while (j < num)
				{
					if (PIDLOFMIEFQ[LCMMCNFNHMF + j] != bmsymbol.sequence[j])
					{
						flag = false;
						IL_68:
						if (!flag || !bmsymbol.EMJOPFJFMND(this.LOMFLBBFMEC()))
						{
							goto IL_7A;
						}
						return bmsymbol;
					}
					else
					{
						j++;
					}
				}
				goto IL_68;
			}
			IL_7A:;
		}
		return null;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x00010340 File Offset: 0x0000E540
	public int QGBQENGOHQB()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.QGBQENGOHQB();
		}
		if (!this.JDFNMMNJIBK() && this.mFont != null)
		{
			return this.mFont.QQPFJPGKIKO();
		}
		return this.mDynamicFontSize;
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000105A2 File Offset: 0x0000E7A2
	// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0001037E File Offset: 0x0000E57E
	public int EGFBNNLLKKD
	{
		get
		{
			return (!(this.mReplacement != null)) ? ((this.mFont == null) ? 1 : this.mFont.texWidth) : this.mReplacement.EGFBNNLLKKD;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.EGFBNNLLKKD = value;
			}
			else if (this.mFont != null)
			{
				this.mFont.texWidth = value;
			}
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000103B0 File Offset: 0x0000E5B0
	public bool IIENDKNLHMC
	{
		get
		{
			return (!(this.mReplacement != null)) ? (this.mDynamicFont != null) : this.mReplacement.IIENDKNLHMC;
		}
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x000103D9 File Offset: 0x0000E5D9
	public bool HBELLQBFLOL()
	{
		return !(this.mDynamicFont != null) && this.mFont.MKIEGBNBCPD();
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x000C5140 File Offset: 0x000C3340
	public void NPCECPIOPCB()
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.NPCECPIOPCB();
		}
		this.LNMJLFLDCML = null;
		BKKHLBCLPJM[] array = IKBQNBHOJJB.NGNKCHMBKFB<BKKHLBCLPJM>();
		int i = 0;
		int num = array.Length;
		while (i < num)
		{
			BKKHLBCLPJM bkkhlbclpjm = array[i];
			if (bkkhlbclpjm.enabled && IKBQNBHOJJB.PBBDNDMELHQ(bkkhlbclpjm.gameObject) && KGKLCNDOLMP.KNDFJQLODFQ(this, bkkhlbclpjm.NFIBPOJMOCQ))
			{
				KGKLCNDOLMP nfibpojmocq = bkkhlbclpjm.NFIBPOJMOCQ;
				bkkhlbclpjm.NFIBPOJMOCQ = null;
				bkkhlbclpjm.NFIBPOJMOCQ = nfibpojmocq;
			}
			i++;
		}
		int j = 0;
		int count = this.OMIDEBFBQBQ.Count;
		while (j < count)
		{
			this.OMIDEBFBQBQ[j].NPCECPIOPCB();
			j++;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x000C51F4 File Offset: 0x000C33F4
	public bool CHLEEPHFEGC
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.CHLEEPHFEGC;
			}
			if (this.mAtlas != null)
			{
				return false;
			}
			if (this.EPJMQJFQMFP == -1)
			{
				Material pplipcehgnm = this.PPLIPCEHGNM;
				this.EPJMQJFQMFP = ((!(pplipcehgnm != null) || !(pplipcehgnm.shader != null) || !pplipcehgnm.shader.name.Contains("Packed")) ? 0 : 1);
			}
			return this.EPJMQJFQMFP == 1;
		}
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x000C527C File Offset: 0x000C347C
	public void QEHBJCQHLPM(string KJMHINNELJJ, string KCLBMPFIPNQ)
	{
		BMSymbol bmsymbol = this.CHLPMCCFDPP(KJMHINNELJJ, true);
		bmsymbol.spriteName = KCLBMPFIPNQ;
		this.NPCECPIOPCB();
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x000C52A0 File Offset: 0x000C34A0
	public void OMBHCPKNIDJ()
	{
		if (this.mAtlas == null)
		{
			return;
		}
		Texture jgmfilnpflh = this.mAtlas.JGMFILNPFLH;
		if (jgmfilnpflh != null)
		{
			this.mUVRect = new Rect((float)(this.LNMJLFLDCML.x - this.LNMJLFLDCML.paddingLeft), (float)(this.LNMJLFLDCML.y - this.LNMJLFLDCML.paddingTop), (float)(this.LNMJLFLDCML.width + this.LNMJLFLDCML.paddingLeft + this.LNMJLFLDCML.paddingRight), (float)(this.LNMJLFLDCML.height + this.LNMJLFLDCML.paddingTop + this.LNMJLFLDCML.paddingBottom));
			this.mUVRect = JNNGOIIKENH.NFBOPKDICDF(this.mUVRect, jgmfilnpflh.width, jgmfilnpflh.height);
			if (this.LNMJLFLDCML.hasPadding)
			{
				this.PCNCNHMKBKL();
			}
		}
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x000103F7 File Offset: 0x0000E5F7
	public bool LMIQOLPPLKM()
	{
		return (!(this.mReplacement != null)) ? (this.mSymbols == null || this.mSymbols.Count == 0) : this.mReplacement.LMIQOLPPLKM();
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x000C5388 File Offset: 0x000C3588
	public static bool CONNMLOHODF(KGKLCNDOLMP ECHMFPQNBMC, KGKLCNDOLMP IBMINEHKPFF)
	{
		return !(ECHMFPQNBMC == null) && !(IBMINEHKPFF == null) && ((ECHMFPQNBMC.JDFNMMNJIBK() && IBMINEHKPFF.IIENDKNLHMC && ECHMFPQNBMC.KDDNGBFFFJL.fontNames[1] == IBMINEHKPFF.DILBOKEOFOK().fontNames[0]) || ECHMFPQNBMC == IBMINEHKPFF || ECHMFPQNBMC.BHPKNPQNJPM(IBMINEHKPFF) || IBMINEHKPFF.BHPKNPQNJPM(ECHMFPQNBMC));
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x00010430 File Offset: 0x0000E630
	public bool MBEBLCCHNEC()
	{
		return this.QBLKBOJQMDL;
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000104DD File Offset: 0x0000E6DD
	// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00010438 File Offset: 0x0000E638
	public int JMGGLEHMOIF
	{
		get
		{
			return (!(this.mReplacement != null)) ? ((this.mFont == null) ? 1 : this.mFont.texHeight) : this.mReplacement.JMGGLEHMOIF;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.JMGGLEHMOIF = value;
			}
			else if (this.mFont != null)
			{
				this.mFont.texHeight = value;
			}
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x0001046A File Offset: 0x0000E66A
	public void ENLJEBKMNPO(BMFont BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.ENLJEBKMNPO(BGBMIEJJQKC);
		}
		else
		{
			this.mFont = BGBMIEJJQKC;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000104D5 File Offset: 0x0000E6D5
	// (set) Token: 0x06001DCA RID: 7626 RVA: 0x000102EA File Offset: 0x0000E4EA
	[Obsolete("Use UIFont.defaultSize instead")]
	public int BJGMIBBEGDQ
	{
		get
		{
			return this.BDHMPMFLMHI;
		}
		set
		{
			this.BDHMPMFLMHI = value;
		}
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0001048F File Offset: 0x0000E68F
	public BPLKJMJMHFI LOMFLBBFMEC()
	{
		return (!(this.mReplacement != null)) ? this.mAtlas : this.mReplacement.LOMFLBBFMEC();
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000C53F8 File Offset: 0x000C35F8
	public Texture2D JGMFILNPFLH
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.JGMFILNPFLH;
			}
			Material pplipcehgnm = this.PPLIPCEHGNM;
			return (!(pplipcehgnm != null)) ? null : (pplipcehgnm.mainTexture as Texture2D);
		}
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000104B2 File Offset: 0x0000E6B2
	public FontStyle NQFNPKLHEKO()
	{
		return (!(this.mReplacement != null)) ? this.mDynamicFontStyle : this.mReplacement.NQFNPKLHEKO();
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x000C5440 File Offset: 0x000C3640
	public bool LFFGNINEQMK(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			if (JMDLLJPEFKM.Equals(this.KCLBMPFIPNQ))
			{
				return true;
			}
			int i = 0;
			int count = this.OMIDEBFBQBQ.Count;
			while (i < count)
			{
				BMSymbol bmsymbol = this.OMIDEBFBQBQ[i];
				if (JMDLLJPEFKM.Equals(bmsymbol.spriteName))
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000C54A0 File Offset: 0x000C36A0
	public bool PKKLFJDQCMP(string JMDLLJPEFKM)
	{
		if (!string.IsNullOrEmpty(JMDLLJPEFKM))
		{
			if (JMDLLJPEFKM.Equals(this.MLDCIQBEGNF()))
			{
				return true;
			}
			int i = 1;
			int count = this.OMIDEBFBQBQ.Count;
			while (i < count)
			{
				BMSymbol bmsymbol = this.OMIDEBFBQBQ[i];
				if (JMDLLJPEFKM.Equals(bmsymbol.spriteName))
				{
					return false;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x000C5500 File Offset: 0x000C3700
	public void OIGBMJNMOIG(BPLKJMJMHFI BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.OIGBMJNMOIG(BGBMIEJJQKC);
		}
		else if (this.mAtlas != BGBMIEJJQKC)
		{
			this.DHCCBPDMIBQ = -1;
			this.mAtlas = BGBMIEJJQKC;
			if (this.mAtlas != null)
			{
				this.mMat = this.mAtlas.MPGCGDBECHM;
				if (this.QDDJBICKQIG != null)
				{
					this.mUVRect = this.GINPFQOBGBO;
				}
			}
			this.PODOMKFFHFH();
		}
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x00010430 File Offset: 0x0000E630
	public bool LKFPPKHMPOO()
	{
		return this.QBLKBOJQMDL;
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x000C5580 File Offset: 0x000C3780
	public void HHQIKNDIEEH(KGKLCNDOLMP BGBMIEJJQKC)
	{
		KGKLCNDOLMP kgklcndolmp = BGBMIEJJQKC;
		if (kgklcndolmp == this)
		{
			kgklcndolmp = null;
		}
		if (this.mReplacement != kgklcndolmp)
		{
			if (kgklcndolmp != null && kgklcndolmp.OHKLFOBGEOL() == this)
			{
				kgklcndolmp.HHQIKNDIEEH(null);
			}
			if (this.mReplacement != null)
			{
				this.PODOMKFFHFH();
			}
			this.mReplacement = kgklcndolmp;
			if (kgklcndolmp != null)
			{
				this.DHCCBPDMIBQ = -1;
				this.mMat = null;
				this.mFont = null;
				this.mDynamicFont = null;
			}
			this.PODOMKFFHFH();
		}
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x000102EA File Offset: 0x0000E4EA
	public void CJPNHBCQHOE(int BGBMIEJJQKC)
	{
		this.BDHMPMFLMHI = BGBMIEJJQKC;
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x000C560C File Offset: 0x000C380C
	public bool QBLKBOJQMDL
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.QBLKBOJQMDL;
			}
			if (this.mAtlas != null)
			{
				return this.mAtlas.KKGEBNMDHLN;
			}
			if (this.DHCCBPDMIBQ == -1)
			{
				Material pplipcehgnm = this.PPLIPCEHGNM;
				this.DHCCBPDMIBQ = ((!(pplipcehgnm != null) || !(pplipcehgnm.shader != null) || !pplipcehgnm.shader.name.Contains("Premultiplied")) ? 0 : 1);
			}
			return this.DHCCBPDMIBQ == 1;
		}
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x0001017F File Offset: 0x0000E37F
	public FontStyle FNBBCNGCGNL()
	{
		return (!(this.mReplacement != null)) ? this.mDynamicFontStyle : this.mReplacement.MNPNLKCOMJG;
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x000C56A0 File Offset: 0x000C38A0
	public void MOCQLICGNPM()
	{
		if (this.mAtlas == null)
		{
			return;
		}
		Texture jgmfilnpflh = this.mAtlas.JGMFILNPFLH;
		if (jgmfilnpflh != null)
		{
			this.mUVRect = new Rect((float)(this.LNMJLFLDCML.x - this.LNMJLFLDCML.paddingLeft), (float)(this.LNMJLFLDCML.y - this.LNMJLFLDCML.paddingTop), (float)(this.LNMJLFLDCML.width + this.LNMJLFLDCML.paddingLeft + this.LNMJLFLDCML.paddingRight), (float)(this.LNMJLFLDCML.height + this.LNMJLFLDCML.paddingTop + this.LNMJLFLDCML.paddingBottom));
			this.mUVRect = JNNGOIIKENH.NFBOPKDICDF(this.mUVRect, jgmfilnpflh.width, jgmfilnpflh.height);
			if (this.LNMJLFLDCML.INHNGBPPJDF())
			{
				this.PCNCNHMKBKL();
			}
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000C5788 File Offset: 0x000C3988
	public UISpriteData QDDJBICKQIG
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.QDDJBICKQIG;
			}
			if (this.LNMJLFLDCML == null && this.mAtlas != null && !string.IsNullOrEmpty(this.mFont.spriteName))
			{
				this.LNMJLFLDCML = this.mAtlas.GMEDHEOGFMB(this.mFont.spriteName);
				if (this.LNMJLFLDCML == null)
				{
					this.LNMJLFLDCML = this.mAtlas.GMEDHEOGFMB(base.name);
				}
				if (this.LNMJLFLDCML == null)
				{
					this.mFont.spriteName = null;
				}
				else
				{
					this.OMBHCPKNIDJ();
				}
				int i = 0;
				int count = this.mSymbols.Count;
				while (i < count)
				{
					this.OMIDEBFBQBQ[i].NPCECPIOPCB();
					i++;
				}
			}
			return this.LNMJLFLDCML;
		}
	}

	// Token: 0x06001DDA RID: 7642 RVA: 0x000C527C File Offset: 0x000C347C
	public void BEMLPCONNPN(string KJMHINNELJJ, string KCLBMPFIPNQ)
	{
		BMSymbol bmsymbol = this.CHLPMCCFDPP(KJMHINNELJJ, true);
		bmsymbol.spriteName = KCLBMPFIPNQ;
		this.NPCECPIOPCB();
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x00010510 File Offset: 0x0000E710
	public bool JDFNMMNJIBK()
	{
		return (!(this.mReplacement != null)) ? (this.mDynamicFont != null) : this.mReplacement.JDFNMMNJIBK();
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x00010539 File Offset: 0x0000E739
	public Font DILBOKEOFOK()
	{
		return (!(this.mReplacement != null)) ? this.mDynamicFont : this.mReplacement.DILBOKEOFOK();
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00010719 File Offset: 0x0000E919
	// (set) Token: 0x06001DDE RID: 7646 RVA: 0x000C58C8 File Offset: 0x000C3AC8
	public BPLKJMJMHFI QKGJDCFCPMO
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mAtlas : this.mReplacement.QKGJDCFCPMO;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.QKGJDCFCPMO = value;
			}
			else if (this.mAtlas != value)
			{
				this.DHCCBPDMIBQ = -1;
				this.mAtlas = value;
				if (this.mAtlas != null)
				{
					this.mMat = this.mAtlas.MPGCGDBECHM;
					if (this.QDDJBICKQIG != null)
					{
						this.mUVRect = this.GINPFQOBGBO;
					}
				}
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x0001055C File Offset: 0x0000E75C
	public int OOLNHIIJMOO()
	{
		if (this.mReplacement != null)
		{
			return this.mReplacement.OOLNHIIJMOO();
		}
		if (!this.IIENDKNLHMC && this.mFont != null)
		{
			return this.mFont.QQPFJPGKIKO();
		}
		return this.mDynamicFontSize;
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x0001059A File Offset: 0x0000E79A
	// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x000C5EDC File Offset: 0x000C40DC
	public KGKLCNDOLMP QKQJDJKILGD
	{
		get
		{
			return this.mReplacement;
		}
		set
		{
			KGKLCNDOLMP kgklcndolmp = value;
			if (kgklcndolmp == this)
			{
				kgklcndolmp = null;
			}
			if (this.mReplacement != kgklcndolmp)
			{
				if (kgklcndolmp != null && kgklcndolmp.QKQJDJKILGD == this)
				{
					kgklcndolmp.QKQJDJKILGD = null;
				}
				if (this.mReplacement != null)
				{
					this.NPCECPIOPCB();
				}
				this.mReplacement = kgklcndolmp;
				if (kgklcndolmp != null)
				{
					this.DHCCBPDMIBQ = -1;
					this.mMat = null;
					this.mFont = null;
					this.mDynamicFont = null;
				}
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000C5948 File Offset: 0x000C3B48
	// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x000C5C04 File Offset: 0x000C3E04
	public Rect GINPFQOBGBO
	{
		get
		{
			if (this.mReplacement != null)
			{
				return this.mReplacement.GINPFQOBGBO;
			}
			return (!(this.mAtlas != null) || this.QDDJBICKQIG == null) ? new Rect(0f, 0f, 1f, 1f) : this.mUVRect;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.GINPFQOBGBO = value;
			}
			else if (this.QDDJBICKQIG == null && this.mUVRect != value)
			{
				this.mUVRect = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000C59A8 File Offset: 0x000C3BA8
	public void KOMOOQQGLML()
	{
		if (this.mAtlas == null)
		{
			return;
		}
		Texture jgmfilnpflh = this.mAtlas.JGMFILNPFLH;
		if (jgmfilnpflh != null)
		{
			this.mUVRect = new Rect((float)(this.LNMJLFLDCML.x - this.LNMJLFLDCML.paddingLeft), (float)(this.LNMJLFLDCML.y - this.LNMJLFLDCML.paddingTop), (float)(this.LNMJLFLDCML.width + this.LNMJLFLDCML.paddingLeft + this.LNMJLFLDCML.paddingRight), (float)(this.LNMJLFLDCML.height + this.LNMJLFLDCML.paddingTop + this.LNMJLFLDCML.paddingBottom));
			this.mUVRect = JNNGOIIKENH.NFBOPKDICDF(this.mUVRect, jgmfilnpflh.width, jgmfilnpflh.height);
			if (this.LNMJLFLDCML.INHNGBPPJDF())
			{
				this.MJOQDONBHDO();
			}
		}
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x000C5A90 File Offset: 0x000C3C90
	public void DHONOOPBNOK(BPLKJMJMHFI BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.OIGBMJNMOIG(BGBMIEJJQKC);
		}
		else if (this.mAtlas != BGBMIEJJQKC)
		{
			this.DHCCBPDMIBQ = -1;
			this.mAtlas = BGBMIEJJQKC;
			if (this.mAtlas != null)
			{
				this.mMat = this.mAtlas.DDQOOEJDMDG();
				if (this.QPQLHJJJLCD() != null)
				{
					this.mUVRect = this.GINPFQOBGBO;
				}
			}
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000C5B10 File Offset: 0x000C3D10
	private void MJOQDONBHDO()
	{
		Texture jgmfilnpflh = this.mAtlas.JGMFILNPFLH;
		if (jgmfilnpflh != null && this.LNMJLFLDCML != null)
		{
			Rect rect = JNNGOIIKENH.JGKFJCNNBBE(this.mUVRect, this.JGMFILNPFLH.width, this.JGMFILNPFLH.height, false);
			Rect rect2 = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
			int gmqphogqfmg = Mathf.RoundToInt(rect2.xMin - rect.xMin);
			int hlipoqgbjnn = Mathf.RoundToInt(rect2.yMin - rect.yMin);
			int fjdginjehoe = Mathf.RoundToInt(rect2.xMax - rect.xMin);
			int jfjfcgqoemc = Mathf.RoundToInt(rect2.yMax - rect.yMin);
			this.mFont.PQFOQKBDIGG(gmqphogqfmg, hlipoqgbjnn, fjdginjehoe, jfjfcgqoemc);
		}
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x000C5C50 File Offset: 0x000C3E50
	public void DOFCHBHMNON(string KJMHINNELJJ, string KCLBMPFIPNQ)
	{
		BMSymbol bmsymbol = this.KJHIMDBHFBG(KJMHINNELJJ, true);
		bmsymbol.spriteName = KCLBMPFIPNQ;
		this.NPCECPIOPCB();
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000C5C74 File Offset: 0x000C3E74
	public void KOCGFIELFNJ(string KJMHINNELJJ)
	{
		BMSymbol bmsymbol = this.CHLPMCCFDPP(KJMHINNELJJ, false);
		if (bmsymbol != null)
		{
			this.OMIDEBFBQBQ.Remove(bmsymbol);
		}
		this.NPCECPIOPCB();
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000C5CA0 File Offset: 0x000C3EA0
	public BMSymbol FCHBILGIEGB(string PIDLOFMIEFQ, int LCMMCNFNHMF, int JBPDNFNEEKP)
	{
		int count = this.mSymbols.Count;
		if (count == 0)
		{
			return null;
		}
		JBPDNFNEEKP -= LCMMCNFNHMF;
		for (int i = 0; i < count; i += 0)
		{
			BMSymbol bmsymbol = this.mSymbols[i];
			int num = bmsymbol.KCIFBHJGEEH();
			if (num != 0 && JBPDNFNEEKP >= num)
			{
				bool flag = false;
				int j = 0;
				while (j < num)
				{
					if (PIDLOFMIEFQ[LCMMCNFNHMF + j] != bmsymbol.sequence[j])
					{
						flag = true;
						IL_68:
						if (!flag || !bmsymbol.LOMPEGQPMME(this.LOMFLBBFMEC()))
						{
							goto IL_7A;
						}
						return bmsymbol;
					}
					else
					{
						j++;
					}
				}
				goto IL_68;
			}
			IL_7A:;
		}
		return null;
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x000C5D34 File Offset: 0x000C3F34
	private void PCNCNHMKBKL()
	{
		Texture jgmfilnpflh = this.mAtlas.JGMFILNPFLH;
		if (jgmfilnpflh != null && this.LNMJLFLDCML != null)
		{
			Rect rect = JNNGOIIKENH.JGKFJCNNBBE(this.mUVRect, this.JGMFILNPFLH.width, this.JGMFILNPFLH.height, true);
			Rect rect2 = new Rect((float)this.LNMJLFLDCML.x, (float)this.LNMJLFLDCML.y, (float)this.LNMJLFLDCML.width, (float)this.LNMJLFLDCML.height);
			int gmqphogqfmg = Mathf.RoundToInt(rect2.xMin - rect.xMin);
			int hlipoqgbjnn = Mathf.RoundToInt(rect2.yMin - rect.yMin);
			int fjdginjehoe = Mathf.RoundToInt(rect2.xMax - rect.xMin);
			int jfjfcgqoemc = Mathf.RoundToInt(rect2.yMax - rect.yMin);
			this.mFont.PCNCNHMKBKL(gmqphogqfmg, hlipoqgbjnn, fjdginjehoe, jfjfcgqoemc);
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00010430 File Offset: 0x0000E630
	[Obsolete("Use UIFont.premultipliedAlphaShader instead")]
	public bool KKGEBNMDHLN
	{
		get
		{
			return this.QBLKBOJQMDL;
		}
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000C5E28 File Offset: 0x000C4028
	private BMSymbol KJHIMDBHFBG(string KJMHINNELJJ, bool IBKGGGCBJCL)
	{
		int i = 1;
		int count = this.mSymbols.Count;
		while (i < count)
		{
			BMSymbol bmsymbol = this.mSymbols[i];
			if (bmsymbol.sequence == KJMHINNELJJ)
			{
				return bmsymbol;
			}
			i++;
		}
		if (IBKGGGCBJCL)
		{
			BMSymbol bmsymbol2 = new BMSymbol();
			bmsymbol2.sequence = KJMHINNELJJ;
			this.mSymbols.Add(bmsymbol2);
			return bmsymbol2;
		}
		return null;
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000C5E8C File Offset: 0x000C408C
	public void EGCOJLEJNQH(string BGBMIEJJQKC)
	{
		if (this.mReplacement != null)
		{
			this.mReplacement.KCLBMPFIPNQ = BGBMIEJJQKC;
		}
		else if (this.mFont.spriteName != BGBMIEJJQKC)
		{
			this.mFont.spriteName = BGBMIEJJQKC;
			this.NPCECPIOPCB();
		}
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x0001059A File Offset: 0x0000E79A
	public KGKLCNDOLMP OHKLFOBGEOL()
	{
		return this.mReplacement;
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x0001059A File Offset: 0x0000E79A
	public KGKLCNDOLMP JBLMHIIFGLH()
	{
		return this.mReplacement;
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x00010613 File Offset: 0x0000E813
	public bool INEMKLPCLOP
	{
		get
		{
			return this.mDynamicFont != null || this.mFont.isValid;
		}
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000C527C File Offset: 0x000C347C
	public void PPDPGLOIMJE(string KJMHINNELJJ, string KCLBMPFIPNQ)
	{
		BMSymbol bmsymbol = this.CHLPMCCFDPP(KJMHINNELJJ, true);
		bmsymbol.spriteName = KCLBMPFIPNQ;
		this.NPCECPIOPCB();
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00010688 File Offset: 0x0000E888
	// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x000C5F68 File Offset: 0x000C4168
	public Font KDDNGBFFFJL
	{
		get
		{
			return (!(this.mReplacement != null)) ? this.mDynamicFont : this.mReplacement.KDDNGBFFFJL;
		}
		set
		{
			if (this.mReplacement != null)
			{
				this.mReplacement.KDDNGBFFFJL = value;
			}
			else if (this.mDynamicFont != value)
			{
				if (this.mDynamicFont != null)
				{
					this.PPLIPCEHGNM = null;
				}
				this.mDynamicFont = value;
				this.NPCECPIOPCB();
			}
		}
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000106AB File Offset: 0x0000E8AB
	private bool BHPKNPQNJPM(KGKLCNDOLMP NKKDJJOKQDK)
	{
		return !(NKKDJJOKQDK == null) && (NKKDJJOKQDK == this || (this.mReplacement != null && this.mReplacement.BHPKNPQNJPM(NKKDJJOKQDK)));
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000C5FC4 File Offset: 0x000C41C4
	public BMSymbol FHCLPQMLEIP(string PIDLOFMIEFQ, int LCMMCNFNHMF, int JBPDNFNEEKP)
	{
		int count = this.mSymbols.Count;
		if (count == 0)
		{
			return null;
		}
		JBPDNFNEEKP -= LCMMCNFNHMF;
		for (int i = 0; i < count; i++)
		{
			BMSymbol bmsymbol = this.mSymbols[i];
			int length = bmsymbol.length;
			if (length != 0 && JBPDNFNEEKP >= length)
			{
				bool flag = true;
				int j = 0;
				while (j < length)
				{
					if (PIDLOFMIEFQ[LCMMCNFNHMF + j] != bmsymbol.sequence[j])
					{
						flag = false;
						IL_68:
						if (!flag || !bmsymbol.GEODEQDOMIP(this.QKGJDCFCPMO))
						{
							goto IL_7A;
						}
						return bmsymbol;
					}
					else
					{
						j++;
					}
				}
				goto IL_68;
			}
			IL_7A:;
		}
		return null;
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06001DFB RID: 7675 RVA: 0x000106E0 File Offset: 0x0000E8E0
	public bool PDFKLBNDIIB
	{
		get
		{
			return (!(this.mReplacement != null)) ? (this.mSymbols != null && this.mSymbols.Count != 0) : this.mReplacement.PDFKLBNDIIB;
		}
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x000103D9 File Offset: 0x0000E5D9
	public bool FNMKEGGKBPO()
	{
		return !(this.mDynamicFont != null) && this.mFont.MKIEGBNBCPD();
	}

	// Token: 0x04000653 RID: 1619
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	// Token: 0x04000654 RID: 1620
	[HideInInspector]
	[SerializeField]
	private Rect mUVRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04000655 RID: 1621
	[HideInInspector]
	[SerializeField]
	private BMFont mFont = new BMFont();

	// Token: 0x04000656 RID: 1622
	[HideInInspector]
	[SerializeField]
	private BPLKJMJMHFI mAtlas;

	// Token: 0x04000657 RID: 1623
	[HideInInspector]
	[SerializeField]
	private KGKLCNDOLMP mReplacement;

	// Token: 0x04000658 RID: 1624
	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols = new List<BMSymbol>();

	// Token: 0x04000659 RID: 1625
	[HideInInspector]
	[SerializeField]
	private Font mDynamicFont;

	// Token: 0x0400065A RID: 1626
	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize = 16;

	// Token: 0x0400065B RID: 1627
	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	// Token: 0x0400065C RID: 1628
	[NonSerialized]
	private UISpriteData LNMJLFLDCML;

	// Token: 0x0400065D RID: 1629
	private int DHCCBPDMIBQ = -1;

	// Token: 0x0400065E RID: 1630
	private int EPJMQJFQMFP = -1;
}
