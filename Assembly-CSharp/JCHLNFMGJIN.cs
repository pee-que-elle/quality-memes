using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200034B RID: 843
[HelpURL("http://www.procamera2d.com/user-guide/extension-content-fitter/")]
public class JCHLNFMGJIN : BNEFIOCKQOE, NLQPOLOJJQE
{
	// Token: 0x06006F3F RID: 28479 RVA: 0x00029079 File Offset: 0x00027279
	public float LKKNQJEGCID(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.BGPMKOIGNNN(this.HCCDEQMJOOG) : GNBLMJIGCOD;
	}

	// Token: 0x06006F40 RID: 28480 RVA: 0x00029092 File Offset: 0x00027292
	public float CPLKGHDCFHE(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.OMBQKHHCQIL(this.HCCDEQMJOOG) : GNBLMJIGCOD;
	}

	// Token: 0x06006F41 RID: 28481 RVA: 0x000290AB File Offset: 0x000272AB
	public CKJHBJIMMKH JKBHCEDDDBC()
	{
		return this._contentFitterMode;
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06006F42 RID: 28482 RVA: 0x000290B3 File Offset: 0x000272B3
	// (set) Token: 0x06006FA2 RID: 28578 RVA: 0x000291BE File Offset: 0x000273BE
	public float JHBLECQLBIJ
	{
		get
		{
			return this._targetAspectRatio;
		}
		set
		{
			this._targetAspectRatio = value;
			this._targetWidth = this._targetHeight * value;
		}
	}

	// Token: 0x06006F43 RID: 28483 RVA: 0x000290BB File Offset: 0x000272BB
	public float CPPMIPQCFIG()
	{
		return this._targetHeight;
	}

	// Token: 0x06006F44 RID: 28484 RVA: 0x000290C3 File Offset: 0x000272C3
	protected virtual void FHPGLDNLOMQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QNDGKBBGHNK(this);
		}
	}

	// Token: 0x06006F46 RID: 28486 RVA: 0x00029118 File Offset: 0x00027318
	public void DHEGPQNLHKG(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.DJKLGKCINGD();
	}

	// Token: 0x06006F47 RID: 28487 RVA: 0x0002912F File Offset: 0x0002732F
	public bool OLBGFOCIPPJ()
	{
		return this._useLetterOrPillarboxing;
	}

	// Token: 0x06006F48 RID: 28488 RVA: 0x00029137 File Offset: 0x00027337
	public void HLKPHQMHJIN(float BGBMIEJJQKC)
	{
		this._targetHeight = BGBMIEJJQKC;
		this._targetWidth = BGBMIEJJQKC * this.JHBLECQLBIJ;
	}

	// Token: 0x06006F49 RID: 28489 RVA: 0x0002914E File Offset: 0x0002734E
	protected virtual void GMEOCGKEOFI()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CONFHHMNMDH(this);
		}
	}

	// Token: 0x06006F4A RID: 28490 RVA: 0x00364EC4 File Offset: 0x003630C4
	private Vector3[] PBNIQCFEOEL(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, Color EDKMQCELLFG, Color KNCKJHQCJFP)
	{
		Rect rect = new Rect(DGKOIGOLHDM, DDLQKFDFMCJ, KJGMGPCEJJD, DFKQMMIQDOO);
		rect.x -= rect.width / 634f;
		rect.y -= rect.height / 669f;
		Vector3[] array = new Vector3[7];
		array[1] = this.JQCCJCOPEJK(rect.position.x, rect.position.y, 1852f);
		array[0] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y, 1777f);
		array[3] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y + rect.height, 1050f);
		array[5] = this.JQCCJCOPEJK(rect.position.x, rect.position.y + rect.height, 1668f);
		return array;
	}

	// Token: 0x06006F4B RID: 28491 RVA: 0x0002916F File Offset: 0x0002736F
	public void BOOPDPPNIEP(bool BGBMIEJJQKC)
	{
		this._useLetterOrPillarboxing = BGBMIEJJQKC;
		this.DFBHLDLPCDB(BGBMIEJJQKC);
	}

	// Token: 0x06006F4C RID: 28492 RVA: 0x000290B3 File Offset: 0x000272B3
	public float DJKLGKCINGD()
	{
		return this._targetAspectRatio;
	}

	// Token: 0x06006F4D RID: 28493 RVA: 0x0036502C File Offset: 0x0036322C
	private static void OJIPOJQEEMD(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		if (NNGCLMQHDGE)
		{
			float num = 483f - FOJIIGFDDLJ / ((float)Screen.width / (float)Screen.height);
			EBINQJLDHPM.rect = new Rect(num / 265f + num / 1507f * NGEGEEBJHFF, 1919f, 162f - num, 1244f);
		}
		else
		{
			float num2 = 1440f - (float)Screen.width / (float)Screen.height / FOJIIGFDDLJ;
			EBINQJLDHPM.rect = new Rect(606f, num2 / 1231f + num2 / 1781f * QIJGCKOPKEH, 1820f, 168f - num2);
		}
	}

	// Token: 0x06006F4E RID: 28494 RVA: 0x003650C8 File Offset: 0x003632C8
	private static void BHBLCOKOCCP(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		if (NNGCLMQHDGE)
		{
			float num = 1693f - FOJIIGFDDLJ / ((float)Screen.width / (float)Screen.height);
			EBINQJLDHPM.rect = new Rect(num / 181f + num / 241f * NGEGEEBJHFF, 287f, 722f - num, 118f);
		}
		else
		{
			float num2 = 795f - (float)Screen.width / (float)Screen.height / FOJIIGFDDLJ;
			EBINQJLDHPM.rect = new Rect(704f, num2 / 1228f + num2 / 641f * QIJGCKOPKEH, 1510f, 1736f - num2);
		}
	}

	// Token: 0x06006F50 RID: 28496 RVA: 0x0002912F File Offset: 0x0002732F
	public bool NGHHPJOHMCP()
	{
		return this._useLetterOrPillarboxing;
	}

	// Token: 0x06006F51 RID: 28497 RVA: 0x00365164 File Offset: 0x00363364
	private static Matrix4x4 OFDCFJIIOEE(Rect FCHDFOMGNON, Matrix4x4 LOGFEIHDIJC)
	{
		Matrix4x4 rhs = Matrix4x4.TRS(new Vector3(1634f / FCHDFOMGNON.width - 1183f, 1420f / FCHDFOMGNON.height - 287f, 738f), Quaternion.identity, new Vector3(1971f / FCHDFOMGNON.width, 1232f / FCHDFOMGNON.height, 920f));
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(-FCHDFOMGNON.x * 388f / FCHDFOMGNON.width, -FCHDFOMGNON.y * 887f / FCHDFOMGNON.height, 1484f), Quaternion.identity, Vector3.one);
		return lhs * rhs * LOGFEIHDIJC;
	}

	// Token: 0x06006F52 RID: 28498 RVA: 0x00365224 File Offset: 0x00363424
	private void KOFODPDCKLI(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC && this.IGLQKJPJMBG == null)
		{
			this.EMQGGNQNNHD();
		}
		if (BGBMIEJJQKC)
		{
			this.IGLQKJPJMBG.gameObject.SetActive(false);
			JCHLNFMGJIN.BHBLCOKOCCP(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 933f > this.DJBHCNQHNGO() * 619f / JCHLNFMGJIN.EMMIJKMPBHP(), this.HGMQNOJNKHJ(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		else
		{
			if (this.IGLQKJPJMBG != null)
			{
				this.IGLQKJPJMBG.gameObject.SetActive(false);
			}
			base.GPONHFNLHCN.PGHJQNJLJKG.rect = new Rect(855f, 1677f, 1643f, 1974f);
			JCHLNFMGJIN.MFDICGOMHOG(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 1975f > this.BDCCMBLNHEB * 498f / JCHLNFMGJIN.FFOPBCNOHPN, this.GFDMBHMPMNQ(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
	}

	// Token: 0x06006F53 RID: 28499 RVA: 0x00365330 File Offset: 0x00363530
	private static void KMFMLBBOIDM(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		if (NNGCLMQHDGE)
		{
			float num = 1f - FOJIIGFDDLJ / ((float)Screen.width / (float)Screen.height);
			EBINQJLDHPM.rect = new Rect(num / 2f + num / 2f * NGEGEEBJHFF, 0f, 1f - num, 1f);
		}
		else
		{
			float num2 = 1f - (float)Screen.width / (float)Screen.height / FOJIIGFDDLJ;
			EBINQJLDHPM.rect = new Rect(0f, num2 / 2f + num2 / 2f * QIJGCKOPKEH, 1f, 1f - num2);
		}
	}

	// Token: 0x06006F54 RID: 28500 RVA: 0x0002918B File Offset: 0x0002738B
	protected virtual void NGDJNKQELNO()
	{
		base.Awake();
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06006F55 RID: 28501 RVA: 0x0002919F File Offset: 0x0002739F
	private static float EMMIJKMPBHP()
	{
		return (float)Screen.width / (float)Screen.height;
	}

	// Token: 0x06006F56 RID: 28502 RVA: 0x00029118 File Offset: 0x00027318
	public void BKKCQQPCQQN(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.DJKLGKCINGD();
	}

	// Token: 0x06006F57 RID: 28503 RVA: 0x003653CC File Offset: 0x003635CC
	private float BGPMKOIGNNN(CKJHBJIMMKH BGIIEGILLHN)
	{
		switch (BGIIEGILLHN)
		{
		case CKJHBJIMMKH.AspectRatio:
			if (this.FONEIKEOQMD != this.BDCCMBLNHEB || this.NOLHHCJQCIC != this.OHPIPBHKEGC || this.PKFHHPEICDN != this.JHBLECQLBIJ || this.KNDDDKCOCGN != base.GPONHFNLHCN.PGHJQNJLJKG.aspect || this.COICFJLPLFN != this.BIBHLONMEQK || this.JMILBIBHJEJ != this.NFNQBONBINO || this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
			{
				base.StartCoroutine(this.ELHIIJIGGIL());
			}
			this.FONEIKEOQMD = this.BDCCMBLNHEB;
			this.NOLHHCJQCIC = this.OHPIPBHKEGC;
			this.PKFHHPEICDN = this.JHBLECQLBIJ;
			this.KNDDDKCOCGN = base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
			this.COICFJLPLFN = this.BIBHLONMEQK;
			this.JMILBIBHJEJ = this.NFNQBONBINO;
			this.CHDJGKGKKMF = this._useLetterOrPillarboxing;
			return Mathf.Max(this.OHPIPBHKEGC * 0.5f, this.BDCCMBLNHEB * 0.5f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect);
		case CKJHBJIMMKH.FixedWidth:
			return this.BDCCMBLNHEB * 0.5f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
		case CKJHBJIMMKH.FixedHeight:
			return this.OHPIPBHKEGC * 0.5f;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x06006F58 RID: 28504 RVA: 0x000291AE File Offset: 0x000273AE
	public void MBCPMQHFCMP(bool BGBMIEJJQKC)
	{
		this._useLetterOrPillarboxing = BGBMIEJJQKC;
		this.ILNFFODFJEJ(BGBMIEJJQKC);
	}

	// Token: 0x06006F59 RID: 28505 RVA: 0x00365524 File Offset: 0x00363724
	private static void LNLBILDQIEK(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		EBINQJLDHPM.ResetProjectionMatrix();
		float x = (!NNGCLMQHDGE) ? 0f : ((-0.5f + FOJIIGFDDLJ / EBINQJLDHPM.aspect * 0.5f) * NGEGEEBJHFF);
		float y = NNGCLMQHDGE ? 0f : ((-0.5f + EBINQJLDHPM.aspect / FOJIIGFDDLJ * 0.5f) * QIJGCKOPKEH);
		EBINQJLDHPM.projectionMatrix = JCHLNFMGJIN.JNIBOIBHFMC(new Rect(x, y, 1f, 1f), EBINQJLDHPM.projectionMatrix);
	}

	// Token: 0x06006F5A RID: 28506 RVA: 0x0002919F File Offset: 0x0002739F
	private static float DBBIFEDIKHN()
	{
		return (float)Screen.width / (float)Screen.height;
	}

	// Token: 0x06006F5B RID: 28507 RVA: 0x0002914E File Offset: 0x0002734E
	protected virtual void LDJGQLNHCBN()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CONFHHMNMDH(this);
		}
	}

	// Token: 0x06006F5C RID: 28508 RVA: 0x0036559C File Offset: 0x0036379C
	private IEnumerator IGHEOBJOEDM()
	{
		bool nngclmqhdge = this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN;
		if (this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
		{
			this.JIDKLMHEQJC(this._useLetterOrPillarboxing);
		}
		if (this.IJMIMNJPNEQ)
		{
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		yield return new WaitForEndOfFrame();
		return 1;
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		yield break;
	}

	// Token: 0x06006F5D RID: 28509 RVA: 0x000291BE File Offset: 0x000273BE
	public void HEEPOPOEKPP(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006F5E RID: 28510 RVA: 0x000291D5 File Offset: 0x000273D5
	public void KHNPFEJIIEK(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.QCCPEOCLDJM();
	}

	// Token: 0x06006F5F RID: 28511 RVA: 0x000291EC File Offset: 0x000273EC
	public int BODOFFHMNFF()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06006F60 RID: 28512 RVA: 0x000291D5 File Offset: 0x000273D5
	public void CQQLIEDQJEP(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.QCCPEOCLDJM();
	}

	// Token: 0x06006F61 RID: 28513 RVA: 0x000291F4 File Offset: 0x000273F4
	public float QCGHEJQIKFH()
	{
		return this._targetWidth;
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x000291EC File Offset: 0x000273EC
	// (set) Token: 0x06006F62 RID: 28514 RVA: 0x000291FC File Offset: 0x000273FC
	public int OOKGEICHBQO
	{
		get
		{
			return this.GKLLDJLQPMM;
		}
		set
		{
			this.GKLLDJLQPMM = value;
		}
	}

	// Token: 0x06006F63 RID: 28515 RVA: 0x000291BE File Offset: 0x000273BE
	public void ILNJQPEDCHC(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006F64 RID: 28516 RVA: 0x003655B8 File Offset: 0x003637B8
	private IEnumerator HCHIDEKMEBB()
	{
		if (this.IJMIMNJPNEQ)
		{
			this.FKHKCKFGPBL();
		}
		yield return null;
		return 1;
		if (this.HCCDEQMJOOG != CKJHBJIMMKH.AspectRatio)
		{
			goto IL_CE;
		}
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		IL_CE:
		yield break;
	}

	// Token: 0x06006F65 RID: 28517 RVA: 0x003655B8 File Offset: 0x003637B8
	private IEnumerator Start()
	{
		if (this.IJMIMNJPNEQ)
		{
			this.FKHKCKFGPBL();
		}
		yield return null;
		return 1;
		if (this.HCCDEQMJOOG != CKJHBJIMMKH.AspectRatio)
		{
			goto IL_CE;
		}
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		IL_CE:
		yield break;
	}

	// Token: 0x06006F66 RID: 28518 RVA: 0x00029079 File Offset: 0x00027279
	public float GPQPBQPMNID(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.BGPMKOIGNNN(this.HCCDEQMJOOG) : GNBLMJIGCOD;
	}

	// Token: 0x06006F67 RID: 28519 RVA: 0x000290B3 File Offset: 0x000272B3
	public float QCCPEOCLDJM()
	{
		return this._targetAspectRatio;
	}

	// Token: 0x06006F68 RID: 28520 RVA: 0x0002918B File Offset: 0x0002738B
	protected virtual void CBIFGBNDMHB()
	{
		base.Awake();
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06006F69 RID: 28521 RVA: 0x0002919F File Offset: 0x0002739F
	private static float JDKOLMFHLLN()
	{
		return (float)Screen.width / (float)Screen.height;
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06006F6A RID: 28522 RVA: 0x000291F4 File Offset: 0x000273F4
	// (set) Token: 0x06006F9D RID: 28573 RVA: 0x000292D8 File Offset: 0x000274D8
	public float BDCCMBLNHEB
	{
		get
		{
			return this._targetWidth;
		}
		set
		{
			this._targetWidth = value;
			this._targetHeight = value / this.JHBLECQLBIJ;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06006F6B RID: 28523 RVA: 0x0002912F File Offset: 0x0002732F
	// (set) Token: 0x06006F7A RID: 28538 RVA: 0x00029205 File Offset: 0x00027405
	public bool IJMIMNJPNEQ
	{
		get
		{
			return this._useLetterOrPillarboxing;
		}
		set
		{
			this._useLetterOrPillarboxing = value;
			this.JIDKLMHEQJC(value);
		}
	}

	// Token: 0x06006F6C RID: 28524 RVA: 0x003655D4 File Offset: 0x003637D4
	private float OMBQKHHCQIL(CKJHBJIMMKH BGIIEGILLHN)
	{
		switch (BGIIEGILLHN)
		{
		case CKJHBJIMMKH.AspectRatio:
			if (this.FONEIKEOQMD != this.BDCCMBLNHEB || this.NOLHHCJQCIC != this.HGCMPIFNOMG() || this.PKFHHPEICDN != this.JHBLECQLBIJ || this.KNDDDKCOCGN != base.GPONHFNLHCN.PGHJQNJLJKG.aspect || this.COICFJLPLFN != this.BIBHLONMEQK || this.JMILBIBHJEJ != this.NFNQBONBINO || this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
			{
				base.StartCoroutine(this.HPDDHFJHKDL());
			}
			this.FONEIKEOQMD = this.QCGHEJQIKFH();
			this.NOLHHCJQCIC = this.OHPIPBHKEGC;
			this.PKFHHPEICDN = this.MHHONILBLFL();
			this.KNDDDKCOCGN = base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
			this.COICFJLPLFN = this.BIBHLONMEQK;
			this.JMILBIBHJEJ = this.NFNQBONBINO;
			this.CHDJGKGKKMF = this._useLetterOrPillarboxing;
			return Mathf.Max(this.HGCMPIFNOMG() * 51f, this.QCGHEJQIKFH() * 1622f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect);
		case CKJHBJIMMKH.FixedWidth:
			return this.DJBHCNQHNGO() * 1039f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
		case CKJHBJIMMKH.FixedHeight:
			return this.OHPIPBHKEGC * 1317f;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x06006F6D RID: 28525 RVA: 0x000290B3 File Offset: 0x000272B3
	public float MHHONILBLFL()
	{
		return this._targetAspectRatio;
	}

	// Token: 0x06006F6E RID: 28526 RVA: 0x000290B3 File Offset: 0x000272B3
	public float GFDMBHMPMNQ()
	{
		return this._targetAspectRatio;
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06006F6F RID: 28527 RVA: 0x000290AB File Offset: 0x000272AB
	// (set) Token: 0x06006F77 RID: 28535 RVA: 0x00029215 File Offset: 0x00027415
	public CKJHBJIMMKH HCCDEQMJOOG
	{
		get
		{
			return this._contentFitterMode;
		}
		set
		{
			this._contentFitterMode = value;
			base.GPONHFNLHCN.PGHJQNJLJKG.ResetProjectionMatrix();
			if (this._contentFitterMode == CKJHBJIMMKH.AspectRatio)
			{
				this.BDCCMBLNHEB = this.OHPIPBHKEGC * this.JHBLECQLBIJ;
			}
		}
	}

	// Token: 0x06006F70 RID: 28528 RVA: 0x000291EC File Offset: 0x000273EC
	public int HHLQJJDQFBO()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06006F71 RID: 28529 RVA: 0x000291BE File Offset: 0x000273BE
	public void ILPOKENMKNN(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006F72 RID: 28530 RVA: 0x00029205 File Offset: 0x00027405
	public void QGOLIJDFHEB(bool BGBMIEJJQKC)
	{
		this._useLetterOrPillarboxing = BGBMIEJJQKC;
		this.JIDKLMHEQJC(BGBMIEJJQKC);
	}

	// Token: 0x06006F73 RID: 28531 RVA: 0x0036572C File Offset: 0x0036392C
	private void ILNFFODFJEJ(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC && this.IGLQKJPJMBG == null)
		{
			this.FKHKCKFGPBL();
		}
		if (BGBMIEJJQKC)
		{
			this.IGLQKJPJMBG.gameObject.SetActive(false);
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, this.CPPMIPQCFIG() * 1269f > this.JOCPFIDMQBJ() * 48f / JCHLNFMGJIN.EMMIJKMPBHP(), this.DJKLGKCINGD(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		else
		{
			if (this.IGLQKJPJMBG != null)
			{
				this.IGLQKJPJMBG.gameObject.SetActive(false);
			}
			base.GPONHFNLHCN.PGHJQNJLJKG.rect = new Rect(1707f, 1399f, 479f, 1251f);
			JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, this.HGCMPIFNOMG() * 1331f > this.BDCCMBLNHEB * 756f / JCHLNFMGJIN.EMMIJKMPBHP(), this.QCCPEOCLDJM(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
	}

	// Token: 0x06006F74 RID: 28532 RVA: 0x00029118 File Offset: 0x00027318
	public void ENCEMMBIQIN(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.DJKLGKCINGD();
	}

	// Token: 0x06006F75 RID: 28533 RVA: 0x00365838 File Offset: 0x00363A38
	private Vector3[] COMGCJEDQEH(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, Color EDKMQCELLFG, Color KNCKJHQCJFP)
	{
		Rect rect = new Rect(DGKOIGOLHDM, DDLQKFDFMCJ, KJGMGPCEJJD, DFKQMMIQDOO);
		rect.x -= rect.width / 2f;
		rect.y -= rect.height / 2f;
		return new Vector3[]
		{
			this.JQCCJCOPEJK(rect.position.x, rect.position.y, 0f),
			this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y, 0f),
			this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y + rect.height, 0f),
			this.JQCCJCOPEJK(rect.position.x, rect.position.y + rect.height, 0f)
		};
	}

	// Token: 0x06006F76 RID: 28534 RVA: 0x0002916F File Offset: 0x0002736F
	public void LEDHEJJLIQN(bool BGBMIEJJQKC)
	{
		this._useLetterOrPillarboxing = BGBMIEJJQKC;
		this.DFBHLDLPCDB(BGBMIEJJQKC);
	}

	// Token: 0x06006F78 RID: 28536 RVA: 0x003659A0 File Offset: 0x00363BA0
	private Vector3[] IKQFJEIEDDO(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, Color EDKMQCELLFG, Color KNCKJHQCJFP)
	{
		Rect rect = new Rect(DGKOIGOLHDM, DDLQKFDFMCJ, KJGMGPCEJJD, DFKQMMIQDOO);
		rect.x -= rect.width / 1704f;
		rect.y -= rect.height / 1005f;
		Vector3[] array = new Vector3[1];
		array[1] = this.JQCCJCOPEJK(rect.position.x, rect.position.y, 1551f);
		array[0] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y, 881f);
		array[4] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y + rect.height, 747f);
		array[8] = this.JQCCJCOPEJK(rect.position.x, rect.position.y + rect.height, 1714f);
		return array;
	}

	// Token: 0x06006F79 RID: 28537 RVA: 0x000291EC File Offset: 0x000273EC
	public int HMFPLFJMGOF()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06006F7B RID: 28539 RVA: 0x00365B08 File Offset: 0x00363D08
	private static Matrix4x4 BECIDIKMINC(Rect FCHDFOMGNON, Matrix4x4 LOGFEIHDIJC)
	{
		Matrix4x4 rhs = Matrix4x4.TRS(new Vector3(1002f / FCHDFOMGNON.width - 881f, 1961f / FCHDFOMGNON.height - 1704f, 727f), Quaternion.identity, new Vector3(1248f / FCHDFOMGNON.width, 1517f / FCHDFOMGNON.height, 893f));
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(-FCHDFOMGNON.x * 396f / FCHDFOMGNON.width, -FCHDFOMGNON.y * 1752f / FCHDFOMGNON.height, 1392f), Quaternion.identity, Vector3.one);
		return lhs * rhs * LOGFEIHDIJC;
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06006F7C RID: 28540 RVA: 0x000290BB File Offset: 0x000272BB
	// (set) Token: 0x06006F82 RID: 28546 RVA: 0x00029137 File Offset: 0x00027337
	public float OHPIPBHKEGC
	{
		get
		{
			return this._targetHeight;
		}
		set
		{
			this._targetHeight = value;
			this._targetWidth = value * this.JHBLECQLBIJ;
		}
	}

	// Token: 0x06006F7D RID: 28541 RVA: 0x000291BE File Offset: 0x000273BE
	public void LHJEMLFOJOB(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06006F7E RID: 28542 RVA: 0x0002919F File Offset: 0x0002739F
	private static float FFOPBCNOHPN
	{
		get
		{
			return (float)Screen.width / (float)Screen.height;
		}
	}

	// Token: 0x06006F7F RID: 28543 RVA: 0x000291F4 File Offset: 0x000273F4
	public float JOCPFIDMQBJ()
	{
		return this._targetWidth;
	}

	// Token: 0x06006F80 RID: 28544 RVA: 0x00365BC8 File Offset: 0x00363DC8
	private void EMQGGNQNNHD()
	{
		string name = "status: ";
		Type[] array = new Type[1];
		array[1] = typeof(Camera);
		this.IGLQKJPJMBG = new GameObject(name, array).GetComponent<Camera>();
		this.IGLQKJPJMBG.depth = 717f;
		this.IGLQKJPJMBG.clearFlags = (CameraClearFlags)6;
		this.IGLQKJPJMBG.backgroundColor = Color.black;
		this.IGLQKJPJMBG.cullingMask = 1;
		this.IGLQKJPJMBG.transform.position = new Vector3(1222f, 191f, 768f);
		this.IGLQKJPJMBG.gameObject.hideFlags = HideFlags.None;
	}

	// Token: 0x06006F81 RID: 28545 RVA: 0x000291BE File Offset: 0x000273BE
	public void IPMFHQCDLNP(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006F83 RID: 28547 RVA: 0x00365C6C File Offset: 0x00363E6C
	private Vector3[] QNBFBDFMBCP(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, Color EDKMQCELLFG, Color KNCKJHQCJFP)
	{
		Rect rect = new Rect(DGKOIGOLHDM, DDLQKFDFMCJ, KJGMGPCEJJD, DFKQMMIQDOO);
		rect.x -= rect.width / 752f;
		rect.y -= rect.height / 1312f;
		Vector3[] array = new Vector3[7];
		array[1] = this.JQCCJCOPEJK(rect.position.x, rect.position.y, 1859f);
		array[0] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y, 1035f);
		array[0] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y + rect.height, 305f);
		array[4] = this.JQCCJCOPEJK(rect.position.x, rect.position.y + rect.height, 1208f);
		return array;
	}

	// Token: 0x06006F84 RID: 28548 RVA: 0x000290C3 File Offset: 0x000272C3
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QNDGKBBGHNK(this);
		}
	}

	// Token: 0x06006F85 RID: 28549 RVA: 0x00365DD4 File Offset: 0x00363FD4
	private float OHLEFNMJFPD(CKJHBJIMMKH BGIIEGILLHN)
	{
		switch (BGIIEGILLHN)
		{
		case CKJHBJIMMKH.AspectRatio:
			if (this.FONEIKEOQMD != this.DJBHCNQHNGO() || this.NOLHHCJQCIC != this.CPPMIPQCFIG() || this.PKFHHPEICDN != this.GFDMBHMPMNQ() || this.KNDDDKCOCGN != base.GPONHFNLHCN.PGHJQNJLJKG.aspect || this.COICFJLPLFN != this.BIBHLONMEQK || this.JMILBIBHJEJ != this.NFNQBONBINO || this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
			{
				base.StartCoroutine(this.HPDDHFJHKDL());
			}
			this.FONEIKEOQMD = this.DJBHCNQHNGO();
			this.NOLHHCJQCIC = this.CPPMIPQCFIG();
			this.PKFHHPEICDN = this.JHBLECQLBIJ;
			this.KNDDDKCOCGN = base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
			this.COICFJLPLFN = this.BIBHLONMEQK;
			this.JMILBIBHJEJ = this.NFNQBONBINO;
			this.CHDJGKGKKMF = this._useLetterOrPillarboxing;
			return Mathf.Max(this.HGCMPIFNOMG() * 1490f, this.BDCCMBLNHEB * 302f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect);
		case CKJHBJIMMKH.FixedWidth:
			return this.QCGHEJQIKFH() * 1236f / base.GPONHFNLHCN.PGHJQNJLJKG.aspect;
		case CKJHBJIMMKH.FixedHeight:
			return this.CPPMIPQCFIG() * 580f;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x06006F86 RID: 28550 RVA: 0x000291F4 File Offset: 0x000273F4
	public float KDJPBEFIQHE()
	{
		return this._targetWidth;
	}

	// Token: 0x06006F87 RID: 28551 RVA: 0x00029249 File Offset: 0x00027449
	public void BMPGBQMPDEO(float BGBMIEJJQKC)
	{
		this._targetHeight = BGBMIEJJQKC;
		this._targetWidth = BGBMIEJJQKC * this.QCCPEOCLDJM();
	}

	// Token: 0x06006F88 RID: 28552 RVA: 0x00365F2C File Offset: 0x0036412C
	private static void CHFOLKJEKJO(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		if (NNGCLMQHDGE)
		{
			float num = 75f - FOJIIGFDDLJ / ((float)Screen.width / (float)Screen.height);
			EBINQJLDHPM.rect = new Rect(num / 1446f + num / 1573f * NGEGEEBJHFF, 1647f, 867f - num, 1959f);
		}
		else
		{
			float num2 = 1608f - (float)Screen.width / (float)Screen.height / FOJIIGFDDLJ;
			EBINQJLDHPM.rect = new Rect(1098f, num2 / 833f + num2 / 942f * QIJGCKOPKEH, 529f, 1549f - num2);
		}
	}

	// Token: 0x06006F89 RID: 28553 RVA: 0x00029260 File Offset: 0x00027460
	public void NKMOOCKMCLP(CKJHBJIMMKH BGBMIEJJQKC)
	{
		this._contentFitterMode = BGBMIEJJQKC;
		base.GPONHFNLHCN.PGHJQNJLJKG.ResetProjectionMatrix();
		if (this._contentFitterMode == CKJHBJIMMKH.AspectRatio)
		{
			this.DMDCMFQMLIC(this.OHPIPBHKEGC * this.QCCPEOCLDJM());
		}
	}

	// Token: 0x06006F8A RID: 28554 RVA: 0x00365FC8 File Offset: 0x003641C8
	private void FKHKCKFGPBL()
	{
		this.IGLQKJPJMBG = new GameObject("PC2DBackgroundCamera", new Type[]
		{
			typeof(Camera)
		}).GetComponent<Camera>();
		this.IGLQKJPJMBG.depth = -2.14748365E+09f;
		this.IGLQKJPJMBG.clearFlags = CameraClearFlags.Color;
		this.IGLQKJPJMBG.backgroundColor = Color.black;
		this.IGLQKJPJMBG.cullingMask = 0;
		this.IGLQKJPJMBG.transform.position = new Vector3(10000f, 10000f, 10000f);
		this.IGLQKJPJMBG.gameObject.hideFlags = HideFlags.HideInHierarchy;
	}

	// Token: 0x06006F8B RID: 28555 RVA: 0x000291FC File Offset: 0x000273FC
	public void FKDOJNKCOJG(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006F8C RID: 28556 RVA: 0x00029294 File Offset: 0x00027494
	public float MBIBGJODKMF(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.OHLEFNMJFPD(this.JKBHCEDDDBC()) : GNBLMJIGCOD;
	}

	// Token: 0x06006F8D RID: 28557 RVA: 0x000291FC File Offset: 0x000273FC
	public void ODOLHJFGGFH(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06006F8E RID: 28558 RVA: 0x0002914E File Offset: 0x0002734E
	protected virtual void OJNNLMONFQN()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CONFHHMNMDH(this);
		}
	}

	// Token: 0x06006F8F RID: 28559 RVA: 0x0036606C File Offset: 0x0036426C
	private static Matrix4x4 MPCMJKOPPIF(Rect FCHDFOMGNON, Matrix4x4 LOGFEIHDIJC)
	{
		Matrix4x4 rhs = Matrix4x4.TRS(new Vector3(861f / FCHDFOMGNON.width - 1504f, 727f / FCHDFOMGNON.height - 1148f, 239f), Quaternion.identity, new Vector3(1539f / FCHDFOMGNON.width, 435f / FCHDFOMGNON.height, 371f));
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(-FCHDFOMGNON.x * 2f / FCHDFOMGNON.width, -FCHDFOMGNON.y * 229f / FCHDFOMGNON.height, 1606f), Quaternion.identity, Vector3.one);
		return lhs * rhs * LOGFEIHDIJC;
	}

	// Token: 0x06006F90 RID: 28560 RVA: 0x0036612C File Offset: 0x0036432C
	private static Matrix4x4 JNIBOIBHFMC(Rect FCHDFOMGNON, Matrix4x4 LOGFEIHDIJC)
	{
		Matrix4x4 rhs = Matrix4x4.TRS(new Vector3(1f / FCHDFOMGNON.width - 1f, 1f / FCHDFOMGNON.height - 1f, 0f), Quaternion.identity, new Vector3(1f / FCHDFOMGNON.width, 1f / FCHDFOMGNON.height, 1f));
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(-FCHDFOMGNON.x * 2f / FCHDFOMGNON.width, -FCHDFOMGNON.y * 2f / FCHDFOMGNON.height, 0f), Quaternion.identity, Vector3.one);
		return lhs * rhs * LOGFEIHDIJC;
	}

	// Token: 0x06006F91 RID: 28561 RVA: 0x000291F4 File Offset: 0x000273F4
	public float DJBHCNQHNGO()
	{
		return this._targetWidth;
	}

	// Token: 0x06006F92 RID: 28562 RVA: 0x0036559C File Offset: 0x0036379C
	private IEnumerator ELHIIJIGGIL()
	{
		nngclmqhdge = (this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN);
		if (this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
		{
			this.JIDKLMHEQJC(this._useLetterOrPillarboxing);
		}
		if (this.IJMIMNJPNEQ)
		{
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		yield return new WaitForEndOfFrame();
		return 1;
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		yield break;
	}

	// Token: 0x06006F93 RID: 28563 RVA: 0x0036559C File Offset: 0x0036379C
	private IEnumerator HPDDHFJHKDL()
	{
		nngclmqhdge = (this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN);
		if (this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
		{
			this.JIDKLMHEQJC(this._useLetterOrPillarboxing);
		}
		if (this.IJMIMNJPNEQ)
		{
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		yield return new WaitForEndOfFrame();
		return 1;
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		yield break;
	}

	// Token: 0x06006F94 RID: 28564 RVA: 0x000290BB File Offset: 0x000272BB
	public float HGCMPIFNOMG()
	{
		return this._targetHeight;
	}

	// Token: 0x06006F95 RID: 28565 RVA: 0x000292AD File Offset: 0x000274AD
	public void OLMQQCICELE(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.MHHONILBLFL();
	}

	// Token: 0x06006F96 RID: 28566 RVA: 0x00029079 File Offset: 0x00027279
	public float OOGEEMCDFPK(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.BGPMKOIGNNN(this.HCCDEQMJOOG) : GNBLMJIGCOD;
	}

	// Token: 0x06006F97 RID: 28567 RVA: 0x000290B3 File Offset: 0x000272B3
	public float HGMQNOJNKHJ()
	{
		return this._targetAspectRatio;
	}

	// Token: 0x06006F98 RID: 28568 RVA: 0x003661EC File Offset: 0x003643EC
	private void JIDKLMHEQJC(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC && this.IGLQKJPJMBG == null)
		{
			this.FKHKCKFGPBL();
		}
		if (BGBMIEJJQKC)
		{
			this.IGLQKJPJMBG.gameObject.SetActive(true);
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		else
		{
			if (this.IGLQKJPJMBG != null)
			{
				this.IGLQKJPJMBG.gameObject.SetActive(false);
			}
			base.GPONHFNLHCN.PGHJQNJLJKG.rect = new Rect(0f, 0f, 1f, 1f);
			JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
	}

	// Token: 0x06006F99 RID: 28569 RVA: 0x00029079 File Offset: 0x00027279
	public float LCHPMFFIFLL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		return base.enabled ? this.BGPMKOIGNNN(this.HCCDEQMJOOG) : GNBLMJIGCOD;
	}

	// Token: 0x06006F9A RID: 28570 RVA: 0x000291D5 File Offset: 0x000273D5
	public void DMDCMFQMLIC(float BGBMIEJJQKC)
	{
		this._targetWidth = BGBMIEJJQKC;
		this._targetHeight = BGBMIEJJQKC / this.QCCPEOCLDJM();
	}

	// Token: 0x06006F9B RID: 28571 RVA: 0x003662F8 File Offset: 0x003644F8
	private static void MFDICGOMHOG(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		EBINQJLDHPM.ResetProjectionMatrix();
		float x = (!NNGCLMQHDGE) ? 573f : ((630f + FOJIIGFDDLJ / EBINQJLDHPM.aspect * 1668f) * NGEGEEBJHFF);
		float y = NNGCLMQHDGE ? 1397f : ((456f + EBINQJLDHPM.aspect / FOJIIGFDDLJ * 313f) * QIJGCKOPKEH);
		EBINQJLDHPM.projectionMatrix = JCHLNFMGJIN.OFDCFJIIOEE(new Rect(x, y, 843f, 1678f), EBINQJLDHPM.projectionMatrix);
	}

	// Token: 0x06006F9C RID: 28572 RVA: 0x000292C4 File Offset: 0x000274C4
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x000291BE File Offset: 0x000273BE
	public void JKMEINEIPPL(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006F9F RID: 28575 RVA: 0x00366370 File Offset: 0x00364570
	private static void EMOENPHBNQM(Camera EBINQJLDHPM, bool NNGCLMQHDGE, float FOJIIGFDDLJ, float NGEGEEBJHFF, float QIJGCKOPKEH)
	{
		if (NNGCLMQHDGE)
		{
			float num = 360f - FOJIIGFDDLJ / ((float)Screen.width / (float)Screen.height);
			EBINQJLDHPM.rect = new Rect(num / 760f + num / 706f * NGEGEEBJHFF, 298f, 1210f - num, 1976f);
		}
		else
		{
			float num2 = 867f - (float)Screen.width / (float)Screen.height / FOJIIGFDDLJ;
			EBINQJLDHPM.rect = new Rect(765f, num2 / 1203f + num2 / 1319f * QIJGCKOPKEH, 129f, 1319f - num2);
		}
	}

	// Token: 0x06006FA0 RID: 28576 RVA: 0x0036559C File Offset: 0x0036379C
	private IEnumerator HOKHJMJEKQQ()
	{
		nngclmqhdge = (this.OHPIPBHKEGC * 0.5f > this.BDCCMBLNHEB * 0.5f / JCHLNFMGJIN.FFOPBCNOHPN);
		if (this.CHDJGKGKKMF != this._useLetterOrPillarboxing)
		{
			this.JIDKLMHEQJC(this._useLetterOrPillarboxing);
		}
		if (this.IJMIMNJPNEQ)
		{
			JCHLNFMGJIN.KMFMLBBOIDM(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		yield return new WaitForEndOfFrame();
		return 1;
		JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, nngclmqhdge, this.JHBLECQLBIJ, this.NFNQBONBINO, this.BIBHLONMEQK);
		yield break;
	}

	// Token: 0x06006FA1 RID: 28577 RVA: 0x0036640C File Offset: 0x0036460C
	private void DFBHLDLPCDB(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC && this.IGLQKJPJMBG == null)
		{
			this.FKHKCKFGPBL();
		}
		if (BGBMIEJJQKC)
		{
			this.IGLQKJPJMBG.gameObject.SetActive(true);
			JCHLNFMGJIN.BHBLCOKOCCP(base.GPONHFNLHCN.PGHJQNJLJKG, this.CPPMIPQCFIG() * 39f > this.KDJPBEFIQHE() * 1834f / JCHLNFMGJIN.FFOPBCNOHPN, this.HGMQNOJNKHJ(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
		else
		{
			if (this.IGLQKJPJMBG != null)
			{
				this.IGLQKJPJMBG.gameObject.SetActive(false);
			}
			base.GPONHFNLHCN.PGHJQNJLJKG.rect = new Rect(1736f, 446f, 1073f, 1058f);
			JCHLNFMGJIN.LNLBILDQIEK(base.GPONHFNLHCN.PGHJQNJLJKG, this.HGCMPIFNOMG() * 674f > this.JOCPFIDMQBJ() * 1060f / JCHLNFMGJIN.FFOPBCNOHPN, this.DJKLGKCINGD(), this.NFNQBONBINO, this.BIBHLONMEQK);
		}
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x0002918B File Offset: 0x0002738B
	protected virtual void LIPJCQHLQCQ()
	{
		base.Awake();
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06006FA4 RID: 28580 RVA: 0x00366518 File Offset: 0x00364718
	private static Matrix4x4 FHFPIFMDNNK(Rect FCHDFOMGNON, Matrix4x4 LOGFEIHDIJC)
	{
		Matrix4x4 rhs = Matrix4x4.TRS(new Vector3(1785f / FCHDFOMGNON.width - 60f, 1176f / FCHDFOMGNON.height - 1091f, 150f), Quaternion.identity, new Vector3(1608f / FCHDFOMGNON.width, 523f / FCHDFOMGNON.height, 5f));
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(-FCHDFOMGNON.x * 147f / FCHDFOMGNON.width, -FCHDFOMGNON.y * 904f / FCHDFOMGNON.height, 441f), Quaternion.identity, Vector3.one);
		return lhs * rhs * LOGFEIHDIJC;
	}

	// Token: 0x06006FA5 RID: 28581 RVA: 0x003665D8 File Offset: 0x003647D8
	private Vector3[] KMGIGCEELEK(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO, Color EDKMQCELLFG, Color KNCKJHQCJFP)
	{
		Rect rect = new Rect(DGKOIGOLHDM, DDLQKFDFMCJ, KJGMGPCEJJD, DFKQMMIQDOO);
		rect.x -= rect.width / 917f;
		rect.y -= rect.height / 437f;
		Vector3[] array = new Vector3[4];
		array[1] = this.JQCCJCOPEJK(rect.position.x, rect.position.y, 64f);
		array[1] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y, 424f);
		array[2] = this.JQCCJCOPEJK(rect.position.x + rect.width, rect.position.y + rect.height, 1883f);
		array[0] = this.JQCCJCOPEJK(rect.position.x, rect.position.y + rect.height, 571f);
		return array;
	}

	// Token: 0x06006FA6 RID: 28582 RVA: 0x000291BE File Offset: 0x000273BE
	public void DPODEPFJDID(float BGBMIEJJQKC)
	{
		this._targetAspectRatio = BGBMIEJJQKC;
		this._targetWidth = this._targetHeight * BGBMIEJJQKC;
	}

	// Token: 0x06006FA7 RID: 28583 RVA: 0x00029205 File Offset: 0x00027405
	public void MFKGNJNFNJN(bool BGBMIEJJQKC)
	{
		this._useLetterOrPillarboxing = BGBMIEJJQKC;
		this.JIDKLMHEQJC(BGBMIEJJQKC);
	}

	// Token: 0x06006FA9 RID: 28585 RVA: 0x000290AB File Offset: 0x000272AB
	public CKJHBJIMMKH BCCOCFQOOQO()
	{
		return this._contentFitterMode;
	}

	// Token: 0x040017C5 RID: 6085
	public static string OPGNGFNJDDP = "Content Fitter";

	// Token: 0x040017C6 RID: 6086
	[SerializeField]
	private CKJHBJIMMKH _contentFitterMode;

	// Token: 0x040017C7 RID: 6087
	[SerializeField]
	private bool _useLetterOrPillarboxing;

	// Token: 0x040017C8 RID: 6088
	[SerializeField]
	private float _targetHeight = 5.625f;

	// Token: 0x040017C9 RID: 6089
	[SerializeField]
	private float _targetWidth = 10f;

	// Token: 0x040017CA RID: 6090
	[Range(0.1f, 3f)]
	[SerializeField]
	private float _targetAspectRatio = 1.77777779f;

	// Token: 0x040017CB RID: 6091
	[Range(-1f, 1f)]
	public float BIBHLONMEQK;

	// Token: 0x040017CC RID: 6092
	[Range(-1f, 1f)]
	public float NFNQBONBINO;

	// Token: 0x040017CD RID: 6093
	private float NOLHHCJQCIC;

	// Token: 0x040017CE RID: 6094
	private float FONEIKEOQMD;

	// Token: 0x040017CF RID: 6095
	private float PKFHHPEICDN;

	// Token: 0x040017D0 RID: 6096
	private float KNDDDKCOCGN;

	// Token: 0x040017D1 RID: 6097
	private float COICFJLPLFN;

	// Token: 0x040017D2 RID: 6098
	private float JMILBIBHJEJ;

	// Token: 0x040017D3 RID: 6099
	private bool CHDJGKGKKMF;

	// Token: 0x040017D4 RID: 6100
	private Camera IGLQKJPJMBG;

	// Token: 0x040017D5 RID: 6101
	private int GKLLDJLQPMM = 5000;
}
