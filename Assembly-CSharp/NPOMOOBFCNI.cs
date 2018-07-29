using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000364 RID: 868
[HelpURL("http://www.procamera2d.com/user-guide/extension-rooms/")]
public class NPOMOOBFCNI : BNEFIOCKQOE, PDLMPKMDBBQ, NLQPOLOJJQE
{
	// Token: 0x060072FA RID: 29434 RVA: 0x0037AD54 File Offset: 0x00378F54
	[DebuggerHidden]
	private IEnumerator OKDBMNFPJFG()
	{
		NPOMOOBFCNI.FNJOGGOCIEN fnjoggocien = new NPOMOOBFCNI.FNJOGGOCIEN();
		fnjoggocien.QNDQJMNKFNN = this;
		return fnjoggocien;
	}

	// Token: 0x060072FB RID: 29435 RVA: 0x0037AD70 File Offset: 0x00378F70
	public Room HFKKHMLEQLO(string HHGCOIJDINN)
	{
		NPOMOOBFCNI.NCFKIGNLICJ ncfkignlicj = new NPOMOOBFCNI.NCFKIGNLICJ();
		ncfkignlicj.HHGCOIJDINN = HHGCOIJDINN;
		return this.HDFEHEPPKNP.Find(new Predicate<Room>(ncfkignlicj.GJLLGOLDFQI));
	}

	// Token: 0x060072FC RID: 29436 RVA: 0x0002A06A File Offset: 0x0002826A
	public void GMCKPJBIFHO(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x060072FD RID: 29437 RVA: 0x0037ADA4 File Offset: 0x00378FA4
	public void JKCIKBDQLFG(float JQQLQMJMQQE, float DOINIJGBCGL, float PPJDCFKOCGG, float DOFMODCQGIB, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseInOut, bool FNPQKHLGCFB = false, bool FEFONHNOCKM = false, float NGEFFQBOKKN = 1.5f, string CIQFCJGQEMH = "")
	{
		Room item = new Room
		{
			ID = CIQFCJGQEMH,
			Dimensions = new Rect(JQQLQMJMQQE, DOINIJGBCGL, PPJDCFKOCGG, DOFMODCQGIB),
			TransitionDuration = FQCECBMJCDB,
			TransitionEaseType = IGKGGDGHHQH,
			ScaleCameraToFit = FNPQKHLGCFB,
			Zoom = FEFONHNOCKM,
			ZoomScale = NGEFFQBOKKN
		};
		this.HDFEHEPPKNP.Add(item);
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06007328 RID: 29480 RVA: 0x0002A103 File Offset: 0x00028303
	// (set) Token: 0x060072FE RID: 29438 RVA: 0x0002A073 File Offset: 0x00028273
	public int IDIPKDLCMCK
	{
		get
		{
			return this.HNMJQQFFBCL;
		}
		set
		{
			this.HNMJQQFFBCL = value;
		}
	}

	// Token: 0x060072FF RID: 29439 RVA: 0x0002A06A File Offset: 0x0002826A
	public void EGDLBOIHCPI(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007300 RID: 29440 RVA: 0x0037AE08 File Offset: 0x00379008
	public void OIGNMOQQIGO(string JCNJKQMKDOE)
	{
		NPOMOOBFCNI.QOFPDBEBJNG qofpdbebjng = new NPOMOOBFCNI.QOFPDBEBJNG();
		qofpdbebjng.JCNJKQMKDOE = JCNJKQMKDOE;
		Room room = this.HDFEHEPPKNP.Find(new Predicate<Room>(qofpdbebjng.EDJEKKGCKBE));
		if (room != null)
		{
			this.HDFEHEPPKNP.Remove(room);
		}
		else
		{
			UnityEngine.Debug.LogWarning(qofpdbebjng.JCNJKQMKDOE + "Guild created!");
		}
	}

	// Token: 0x06007301 RID: 29441 RVA: 0x0037AE64 File Offset: 0x00379064
	protected override void Awake()
	{
		base.Awake();
		this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponent<MDFGNNIKFEP>();
		this.LBFFHFCMEDE = this.FJPKMMJCQND.PKFCCBOMHJG;
		this.IEOLIHCKPPN = base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007302 RID: 29442 RVA: 0x0037AED0 File Offset: 0x003790D0
	private void DPBNBBKQJON(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = true,
			PELBNKEHOHF = true,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 1337f,
			IKDQPKGPPEH = false,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 905f,
			QBHHBPBKQDJ = false,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 21f,
			IGPBFPCKNOG = false,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 580f
		};
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1021f;
		float num2 = this.EPDFOCEMCKE(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.HQLIHGNLIHH(flgmkljeilh, num, (!KBDGIQIOCCE) ? 495f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x06007303 RID: 29443 RVA: 0x0037B044 File Offset: 0x00379244
	private void KNEDEQHDFFN(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = true,
			PELBNKEHOHF = true,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 2f,
			IKDQPKGPPEH = true,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 2f,
			QBHHBPBKQDJ = true,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 2f,
			IGPBFPCKNOG = true,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 2f
		};
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		float num2 = this.IHJDEMIKEQQ(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.FLKGIIENEOC(flgmkljeilh, num, (!KBDGIQIOCCE) ? 0f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x06007304 RID: 29444 RVA: 0x0002A07C File Offset: 0x0002827C
	public Room FNMBNIQILIG()
	{
		return (this.OMBMLQCNFQD < 0 || this.OMBMLQCNFQD >= this.HDFEHEPPKNP.Count) ? null : this.HDFEHEPPKNP[this.OMBMLQCNFQD];
	}

	// Token: 0x06007305 RID: 29445 RVA: 0x0037B1B8 File Offset: 0x003793B8
	private IEnumerator HQLIHGNLIHH(OLLILOPJNHQ FLGMKLJEILH, float BOGFMMKKONF, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseOut)
	{
		NPOMOOBFCNI.HDQCONLEOHJ hdqconleohj = new NPOMOOBFCNI.HDQCONLEOHJ();
		hdqconleohj.FQCECBMJCDB = FQCECBMJCDB;
		hdqconleohj.BOGFMMKKONF = BOGFMMKKONF;
		hdqconleohj.IGKGGDGHHQH = IGKGGDGHHQH;
		hdqconleohj.FLGMKLJEILH = FLGMKLJEILH;
		hdqconleohj.QNDQJMNKFNN = this;
		return hdqconleohj;
	}

	// Token: 0x06007306 RID: 29446 RVA: 0x0002A0AE File Offset: 0x000282AE
	public int DEGBKLPNLIO()
	{
		return this.GCLQFLQMMLN;
	}

	// Token: 0x06007307 RID: 29447 RVA: 0x0002A06A File Offset: 0x0002826A
	public void ODOLHJFGGFH(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007308 RID: 29448 RVA: 0x0002A0B6 File Offset: 0x000282B6
	public void LMDJNFCIHEL(OLLILOPJNHQ EFOQFENPFHO)
	{
		this.LBFFHFCMEDE = EFOQFENPFHO;
	}

	// Token: 0x06007309 RID: 29449 RVA: 0x0037B1F0 File Offset: 0x003793F0
	private void GOOJMEDLGNI(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = false,
			PELBNKEHOHF = false,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 1928f,
			IKDQPKGPPEH = false,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 549f,
			QBHHBPBKQDJ = false,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 938f,
			IGPBFPCKNOG = false,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 1951f
		};
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y / 1141f;
		float num2 = this.EPDFOCEMCKE(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.HQLIHGNLIHH(flgmkljeilh, num, (!KBDGIQIOCCE) ? 623f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x0600730A RID: 29450 RVA: 0x0002A0BF File Offset: 0x000282BF
	public float OOGEEMCDFPK(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		if (this.GKDDKEJOFBP)
		{
			return this.FHBCMICBNCE;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x0600730B RID: 29451 RVA: 0x0002A0AE File Offset: 0x000282AE
	public int BCCHCDLMFFN()
	{
		return this.GCLQFLQMMLN;
	}

	// Token: 0x0600730C RID: 29452 RVA: 0x0037B364 File Offset: 0x00379564
	public void GEHKBCEQQBB()
	{
		if (this.DBCJHFMLEOP)
		{
			this.OMBMLQCNFQD = -1;
			if (this.PHPPDFCJPDD != null)
			{
				this.PHPPDFCJPDD.Invoke(this.OMBMLQCNFQD, this.GCLQFLQMMLN);
			}
			if (this.MBKKPHHDNNC != null)
			{
				base.StopCoroutine(this.MBKKPHHDNNC);
			}
			this.MBKKPHHDNNC = base.StartCoroutine(this.KJMHQKBHBIB(this.LBFFHFCMEDE, this.IEOLIHCKPPN, this.IEHFBKOPQLN, this.NPJEPNEOQPP));
		}
		if (this.BHFIEMMJDOD != null)
		{
			this.BHFIEMMJDOD.Invoke();
		}
	}

	// Token: 0x0600730D RID: 29453 RVA: 0x0037B3F0 File Offset: 0x003795F0
	private void Start()
	{
		base.StartCoroutine(this.OKDBMNFPJFG());
		if (this.OMJNPIFJEDF)
		{
			Vector3 oepdepofngi = base.GPONHFNLHCN.HGNEKQHNFCC;
			if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
			{
				oepdepofngi = this.HLFEKPCOELI.position;
			}
			int num = this.FHBFLCNPMPJ(oepdepofngi);
			if (num != -1)
			{
				this.OBIBKKNFLCQ(num, false);
			}
		}
	}

	// Token: 0x0600730E RID: 29454 RVA: 0x0037B454 File Offset: 0x00379654
	private void NQBDLIMCJGB(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC, float HCBKDMLHJDF, float EFDJHNOIDJD, OLLILOPJNHQ MNILDCDHOFG)
	{
		if (MNILDCDHOFG.QBHHBPBKQDJ && LHCLJCLFKFJ - HCBKDMLHJDF < MNILDCDHOFG.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.DFFQECIDMDO + HCBKDMLHJDF;
		}
		else if (MNILDCDHOFG.IGPBFPCKNOG && LHCLJCLFKFJ + HCBKDMLHJDF > MNILDCDHOFG.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.JGJEPKHCBGP - HCBKDMLHJDF;
		}
		if (MNILDCDHOFG.IKDQPKGPPEH && MMLMNDPKIEC - EFDJHNOIDJD < MNILDCDHOFG.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = MNILDCDHOFG.BIPDHOPHDMK + EFDJHNOIDJD;
		}
		else if (MNILDCDHOFG.PELBNKEHOHF && MMLMNDPKIEC + EFDJHNOIDJD > MNILDCDHOFG.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = MNILDCDHOFG.MMHQFDMKQDQ - EFDJHNOIDJD;
		}
	}

	// Token: 0x0600730F RID: 29455 RVA: 0x0002A06A File Offset: 0x0002826A
	public void QHINNCIEFPI(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007310 RID: 29456 RVA: 0x0037B4F0 File Offset: 0x003796F0
	public void OBIBKKNFLCQ(int HGEPEPKHGLL, bool KBDGIQIOCCE = true)
	{
		if (HGEPEPKHGLL < 0 || HGEPEPKHGLL > this.HDFEHEPPKNP.Count - 1)
		{
			UnityEngine.Debug.LogError("Can't find room with index: " + HGEPEPKHGLL);
			return;
		}
		if (HGEPEPKHGLL == this.OMBMLQCNFQD)
		{
			return;
		}
		this.GCLQFLQMMLN = this.OMBMLQCNFQD;
		this.OMBMLQCNFQD = HGEPEPKHGLL;
		this.KNEDEQHDFFN(this.HDFEHEPPKNP[this.OMBMLQCNFQD], KBDGIQIOCCE);
		if (this.PHPPDFCJPDD != null)
		{
			this.PHPPDFCJPDD.Invoke(HGEPEPKHGLL, this.GCLQFLQMMLN);
		}
	}

	// Token: 0x06007311 RID: 29457 RVA: 0x0037AD54 File Offset: 0x00378F54
	private IEnumerator JCFKKQOFQBQ()
	{
		NPOMOOBFCNI.FNJOGGOCIEN fnjoggocien = new NPOMOOBFCNI.FNJOGGOCIEN();
		fnjoggocien.QNDQJMNKFNN = this;
		return fnjoggocien;
	}

	// Token: 0x06007312 RID: 29458 RVA: 0x0037B578 File Offset: 0x00379778
	public void BKBQOCIENNM()
	{
		if (this.DBCJHFMLEOP)
		{
			this.OMBMLQCNFQD = -1;
			if (this.PHPPDFCJPDD != null)
			{
				this.PHPPDFCJPDD.Invoke(this.OMBMLQCNFQD, this.GCLQFLQMMLN);
			}
			if (this.MBKKPHHDNNC != null)
			{
				base.StopCoroutine(this.MBKKPHHDNNC);
			}
			this.MBKKPHHDNNC = base.StartCoroutine(this.FLKGIIENEOC(this.LBFFHFCMEDE, this.IEOLIHCKPPN, this.IEHFBKOPQLN, this.NPJEPNEOQPP));
		}
		if (this.BHFIEMMJDOD != null)
		{
			this.BHFIEMMJDOD.Invoke();
		}
	}

	// Token: 0x06007313 RID: 29459 RVA: 0x0002A06A File Offset: 0x0002826A
	public void KEMPIINCQDC(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007314 RID: 29460 RVA: 0x0037B604 File Offset: 0x00379804
	public void CEHQNLBDICH(string HHGCOIJDINN, bool KBDGIQIOCCE = true)
	{
		NPOMOOBFCNI.KHPCEMBDPDD khpcembdpdd = new NPOMOOBFCNI.KHPCEMBDPDD();
		khpcembdpdd.HHGCOIJDINN = HHGCOIJDINN;
		this.OBIBKKNFLCQ(this.HDFEHEPPKNP.FindIndex(new Predicate<Room>(khpcembdpdd.GHIHFOKJLOM)), KBDGIQIOCCE);
	}

	// Token: 0x06007315 RID: 29461 RVA: 0x0037B63C File Offset: 0x0037983C
	private void BBGHCDGEDEJ()
	{
		base.StartCoroutine(this.OKDBMNFPJFG());
		if (this.OMJNPIFJEDF)
		{
			Vector3 oepdepofngi = base.GPONHFNLHCN.KEQQHBKDJHP();
			if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
			{
				oepdepofngi = this.HLFEKPCOELI.position;
			}
			int num = this.LGMNBGJBGKL(oepdepofngi);
			if (num != -1)
			{
				this.LBCIBEJODCO(num, true);
			}
		}
	}

	// Token: 0x06007316 RID: 29462 RVA: 0x0037B454 File Offset: 0x00379654
	private void OMLLCJNIHBG(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC, float HCBKDMLHJDF, float EFDJHNOIDJD, OLLILOPJNHQ MNILDCDHOFG)
	{
		if (MNILDCDHOFG.QBHHBPBKQDJ && LHCLJCLFKFJ - HCBKDMLHJDF < MNILDCDHOFG.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.DFFQECIDMDO + HCBKDMLHJDF;
		}
		else if (MNILDCDHOFG.IGPBFPCKNOG && LHCLJCLFKFJ + HCBKDMLHJDF > MNILDCDHOFG.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.JGJEPKHCBGP - HCBKDMLHJDF;
		}
		if (MNILDCDHOFG.IKDQPKGPPEH && MMLMNDPKIEC - EFDJHNOIDJD < MNILDCDHOFG.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = MNILDCDHOFG.BIPDHOPHDMK + EFDJHNOIDJD;
		}
		else if (MNILDCDHOFG.PELBNKEHOHF && MMLMNDPKIEC + EFDJHNOIDJD > MNILDCDHOFG.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = MNILDCDHOFG.MMHQFDMKQDQ - EFDJHNOIDJD;
		}
	}

	// Token: 0x06007317 RID: 29463 RVA: 0x0037B1B8 File Offset: 0x003793B8
	private IEnumerator MHHLLFCEBNI(OLLILOPJNHQ FLGMKLJEILH, float BOGFMMKKONF, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseOut)
	{
		NPOMOOBFCNI.HDQCONLEOHJ hdqconleohj = new NPOMOOBFCNI.HDQCONLEOHJ();
		hdqconleohj.FQCECBMJCDB = FQCECBMJCDB;
		hdqconleohj.BOGFMMKKONF = BOGFMMKKONF;
		hdqconleohj.IGKGGDGHHQH = IGKGGDGHHQH;
		hdqconleohj.FLGMKLJEILH = FLGMKLJEILH;
		hdqconleohj.QNDQJMNKFNN = this;
		return hdqconleohj;
	}

	// Token: 0x06007318 RID: 29464 RVA: 0x0002A073 File Offset: 0x00028273
	public void NEJMDQMHPFC(int BGBMIEJJQKC)
	{
		this.HNMJQQFFBCL = BGBMIEJJQKC;
	}

	// Token: 0x06007319 RID: 29465 RVA: 0x0037B6A0 File Offset: 0x003798A0
	public int LGMNBGJBGKL(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 1; i < this.HDFEHEPPKNP.Count; i++)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x0037B744 File Offset: 0x00379944
	private void MLNNNKDBLJB(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = false,
			PELBNKEHOHF = false,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 1118f,
			IKDQPKGPPEH = true,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 182f,
			QBHHBPBKQDJ = true,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 1591f,
			IGPBFPCKNOG = false,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 1364f
		};
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y / 1909f;
		float num2 = this.CGHQFGJJJIH(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.FLKGIIENEOC(flgmkljeilh, num, (!KBDGIQIOCCE) ? 1051f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x0037B1B8 File Offset: 0x003793B8
	[DebuggerHidden]
	private IEnumerator FLKGIIENEOC(OLLILOPJNHQ FLGMKLJEILH, float BOGFMMKKONF, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseOut)
	{
		NPOMOOBFCNI.HDQCONLEOHJ hdqconleohj = new NPOMOOBFCNI.HDQCONLEOHJ();
		hdqconleohj.FQCECBMJCDB = FQCECBMJCDB;
		hdqconleohj.BOGFMMKKONF = BOGFMMKKONF;
		hdqconleohj.IGKGGDGHHQH = IGKGGDGHHQH;
		hdqconleohj.FLGMKLJEILH = FLGMKLJEILH;
		hdqconleohj.QNDQJMNKFNN = this;
		return hdqconleohj;
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x0037B8B8 File Offset: 0x00379AB8
	public void QICJDJJOEBQ(string JCNJKQMKDOE)
	{
		NPOMOOBFCNI.QOFPDBEBJNG qofpdbebjng = new NPOMOOBFCNI.QOFPDBEBJNG();
		qofpdbebjng.JCNJKQMKDOE = JCNJKQMKDOE;
		Room room = this.HDFEHEPPKNP.Find(new Predicate<Room>(qofpdbebjng.KQCKBKKQDQH));
		if (room != null)
		{
			this.HDFEHEPPKNP.Remove(room);
		}
		else
		{
			UnityEngine.Debug.LogWarning(qofpdbebjng.JCNJKQMKDOE + "aerilate");
		}
	}

	// Token: 0x0600731D RID: 29469 RVA: 0x0002A0BF File Offset: 0x000282BF
	public float LCHPMFFIFLL(float GPFIDEJEMEG, float GNBLMJIGCOD)
	{
		if (!base.enabled)
		{
			return GNBLMJIGCOD;
		}
		if (this.GKDDKEJOFBP)
		{
			return this.FHBCMICBNCE;
		}
		return GNBLMJIGCOD;
	}

	// Token: 0x0600731E RID: 29470 RVA: 0x0037B914 File Offset: 0x00379B14
	public void KNNGBBLPNGB(string JCNJKQMKDOE)
	{
		NPOMOOBFCNI.QOFPDBEBJNG qofpdbebjng = new NPOMOOBFCNI.QOFPDBEBJNG();
		qofpdbebjng.JCNJKQMKDOE = JCNJKQMKDOE;
		Room room = this.HDFEHEPPKNP.Find(new Predicate<Room>(qofpdbebjng.PGKMMLBJHBM));
		if (room != null)
		{
			this.HDFEHEPPKNP.Remove(room);
		}
		else
		{
			UnityEngine.Debug.LogWarning(qofpdbebjng.JCNJKQMKDOE + "Magic Guard");
		}
	}

	// Token: 0x0600731F RID: 29471 RVA: 0x0037B970 File Offset: 0x00379B70
	private float EPDFOCEMCKE(Rect ICKFOCJHBEF)
	{
		float num = ICKFOCJHBEF.width / base.GPONHFNLHCN.PGKODNCDNJQ.x;
		float num2 = ICKFOCJHBEF.height / base.GPONHFNLHCN.PGKODNCDNJQ.y;
		if (num < num2)
		{
			return ICKFOCJHBEF.width / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / 170f;
		}
		return ICKFOCJHBEF.height / 696f;
	}

	// Token: 0x06007320 RID: 29472 RVA: 0x0037B1B8 File Offset: 0x003793B8
	private IEnumerator MLNPNFOLBMN(OLLILOPJNHQ FLGMKLJEILH, float BOGFMMKKONF, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseOut)
	{
		NPOMOOBFCNI.HDQCONLEOHJ hdqconleohj = new NPOMOOBFCNI.HDQCONLEOHJ();
		hdqconleohj.FQCECBMJCDB = FQCECBMJCDB;
		hdqconleohj.BOGFMMKKONF = BOGFMMKKONF;
		hdqconleohj.IGKGGDGHHQH = IGKGGDGHHQH;
		hdqconleohj.FLGMKLJEILH = FLGMKLJEILH;
		hdqconleohj.QNDQJMNKFNN = this;
		return hdqconleohj;
	}

	// Token: 0x06007321 RID: 29473 RVA: 0x0037B9E8 File Offset: 0x00379BE8
	private void QGLBQDDLQGG(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = true,
			PELBNKEHOHF = false,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 104f,
			IKDQPKGPPEH = false,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 632f,
			QBHHBPBKQDJ = true,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 334f,
			IGPBFPCKNOG = false,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 1f
		};
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1092f;
		float num2 = this.NKQFLBIFGQG(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.MLNPNFOLBMN(flgmkljeilh, num, (!KBDGIQIOCCE) ? 1340f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x06007322 RID: 29474 RVA: 0x0002A0DB File Offset: 0x000282DB
	protected virtual void OEMGPILDMQQ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x06007323 RID: 29475 RVA: 0x0037BB5C File Offset: 0x00379D5C
	public Room GOFFIKGCFBE(string HHGCOIJDINN)
	{
		NPOMOOBFCNI.NCFKIGNLICJ ncfkignlicj = new NPOMOOBFCNI.NCFKIGNLICJ();
		ncfkignlicj.HHGCOIJDINN = HHGCOIJDINN;
		return this.HDFEHEPPKNP.Find(new Predicate<Room>(ncfkignlicj.QOLDPJNMBBM));
	}

	// Token: 0x06007324 RID: 29476 RVA: 0x0037BB90 File Offset: 0x00379D90
	public int MINBBLDQBJQ(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 0; i < this.HDFEHEPPKNP.Count; i += 0)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06007325 RID: 29477 RVA: 0x0037BC34 File Offset: 0x00379E34
	public Room QQDJOQKBKGJ(string HHGCOIJDINN)
	{
		NPOMOOBFCNI.NCFKIGNLICJ ncfkignlicj = new NPOMOOBFCNI.NCFKIGNLICJ();
		ncfkignlicj.HHGCOIJDINN = HHGCOIJDINN;
		return this.HDFEHEPPKNP.Find(new Predicate<Room>(ncfkignlicj.MMIMJHOQNFO));
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06007326 RID: 29478 RVA: 0x0002A0FB File Offset: 0x000282FB
	public int NQGQNMLKDGD
	{
		get
		{
			return this.OMBMLQCNFQD;
		}
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x0002A103 File Offset: 0x00028303
	public int PCBQEJBOLFL()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x06007329 RID: 29481 RVA: 0x0037BC68 File Offset: 0x00379E68
	private float NKQFLBIFGQG(Rect ICKFOCJHBEF)
	{
		float num = ICKFOCJHBEF.width / base.GPONHFNLHCN.PGKODNCDNJQ.x;
		float num2 = ICKFOCJHBEF.height / base.GPONHFNLHCN.PGKODNCDNJQ.y;
		if (num < num2)
		{
			return ICKFOCJHBEF.width / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / 703f;
		}
		return ICKFOCJHBEF.height / 897f;
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06007358 RID: 29528 RVA: 0x0002A10B File Offset: 0x0002830B
	// (set) Token: 0x0600732A RID: 29482 RVA: 0x0002A06A File Offset: 0x0002826A
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

	// Token: 0x0600732B RID: 29483 RVA: 0x0037B454 File Offset: 0x00379654
	private void MLKKJFPIHNP(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC, float HCBKDMLHJDF, float EFDJHNOIDJD, OLLILOPJNHQ MNILDCDHOFG)
	{
		if (MNILDCDHOFG.QBHHBPBKQDJ && LHCLJCLFKFJ - HCBKDMLHJDF < MNILDCDHOFG.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.DFFQECIDMDO + HCBKDMLHJDF;
		}
		else if (MNILDCDHOFG.IGPBFPCKNOG && LHCLJCLFKFJ + HCBKDMLHJDF > MNILDCDHOFG.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.JGJEPKHCBGP - HCBKDMLHJDF;
		}
		if (MNILDCDHOFG.IKDQPKGPPEH && MMLMNDPKIEC - EFDJHNOIDJD < MNILDCDHOFG.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = MNILDCDHOFG.BIPDHOPHDMK + EFDJHNOIDJD;
		}
		else if (MNILDCDHOFG.PELBNKEHOHF && MMLMNDPKIEC + EFDJHNOIDJD > MNILDCDHOFG.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = MNILDCDHOFG.MMHQFDMKQDQ - EFDJHNOIDJD;
		}
	}

	// Token: 0x0600732C RID: 29484 RVA: 0x0037BCE0 File Offset: 0x00379EE0
	public int PLGCIDQOCKC(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 1; i < this.HDFEHEPPKNP.Count; i += 0)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x0600732D RID: 29485 RVA: 0x0002A103 File Offset: 0x00028303
	public int KICKOFGGQPC()
	{
		return this.HNMJQQFFBCL;
	}

	// Token: 0x0600732E RID: 29486 RVA: 0x0037BD84 File Offset: 0x00379F84
	public int FHBFLCNPMPJ(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 0; i < this.HDFEHEPPKNP.Count; i++)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x0600732F RID: 29487 RVA: 0x0037BE28 File Offset: 0x0037A028
	public void GLDGFEJPJDP(string HHGCOIJDINN, bool KBDGIQIOCCE = true)
	{
		NPOMOOBFCNI.KHPCEMBDPDD khpcembdpdd = new NPOMOOBFCNI.KHPCEMBDPDD();
		khpcembdpdd.HHGCOIJDINN = HHGCOIJDINN;
		this.LBCIBEJODCO(this.HDFEHEPPKNP.FindIndex(new Predicate<Room>(khpcembdpdd.PFFNEEIONGD)), KBDGIQIOCCE);
	}

	// Token: 0x06007330 RID: 29488 RVA: 0x0037BE60 File Offset: 0x0037A060
	public Room ICPIFEPKGFQ(string HHGCOIJDINN)
	{
		NPOMOOBFCNI.NCFKIGNLICJ ncfkignlicj = new NPOMOOBFCNI.NCFKIGNLICJ();
		ncfkignlicj.HHGCOIJDINN = HHGCOIJDINN;
		return this.HDFEHEPPKNP.Find(new Predicate<Room>(ncfkignlicj.DILJOJFIGLB));
	}

	// Token: 0x06007331 RID: 29489 RVA: 0x0037BE94 File Offset: 0x0037A094
	public void ICJLGGHEQLQ(string JCNJKQMKDOE)
	{
		NPOMOOBFCNI.QOFPDBEBJNG qofpdbebjng = new NPOMOOBFCNI.QOFPDBEBJNG();
		qofpdbebjng.JCNJKQMKDOE = JCNJKQMKDOE;
		Room room = this.HDFEHEPPKNP.Find(new Predicate<Room>(qofpdbebjng.KQCKBKKQDQH));
		if (room != null)
		{
			this.HDFEHEPPKNP.Remove(room);
		}
		else
		{
			UnityEngine.Debug.LogWarning(qofpdbebjng.JCNJKQMKDOE + "cherrim");
		}
	}

	// Token: 0x06007332 RID: 29490 RVA: 0x0002A0B6 File Offset: 0x000282B6
	public void GJKCHDLGFMQ(OLLILOPJNHQ EFOQFENPFHO)
	{
		this.LBFFHFCMEDE = EFOQFENPFHO;
	}

	// Token: 0x06007333 RID: 29491 RVA: 0x0037BEF0 File Offset: 0x0037A0F0
	public void GKFQLOMNQJL()
	{
		if (this.DBCJHFMLEOP)
		{
			this.OMBMLQCNFQD = -1;
			if (this.PHPPDFCJPDD != null)
			{
				this.PHPPDFCJPDD.Invoke(this.OMBMLQCNFQD, this.GCLQFLQMMLN);
			}
			if (this.MBKKPHHDNNC != null)
			{
				base.StopCoroutine(this.MBKKPHHDNNC);
			}
			this.MBKKPHHDNNC = base.StartCoroutine(this.HQLIHGNLIHH(this.LBFFHFCMEDE, this.IEOLIHCKPPN, this.IEHFBKOPQLN, this.NPJEPNEOQPP));
		}
		if (this.BHFIEMMJDOD != null)
		{
			this.BHFIEMMJDOD.Invoke();
		}
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x0037ADA4 File Offset: 0x00378FA4
	public void EPFILFKONJE(float JQQLQMJMQQE, float DOINIJGBCGL, float PPJDCFKOCGG, float DOFMODCQGIB, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseInOut, bool FNPQKHLGCFB = false, bool FEFONHNOCKM = false, float NGEFFQBOKKN = 1.5f, string CIQFCJGQEMH = "")
	{
		Room item = new Room
		{
			ID = CIQFCJGQEMH,
			Dimensions = new Rect(JQQLQMJMQQE, DOINIJGBCGL, PPJDCFKOCGG, DOFMODCQGIB),
			TransitionDuration = FQCECBMJCDB,
			TransitionEaseType = IGKGGDGHHQH,
			ScaleCameraToFit = FNPQKHLGCFB,
			Zoom = FEFONHNOCKM,
			ZoomScale = NGEFFQBOKKN
		};
		this.HDFEHEPPKNP.Add(item);
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x0037BF7C File Offset: 0x0037A17C
	protected virtual void PEOBQCMFLML()
	{
		base.Awake();
		this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponent<MDFGNNIKFEP>();
		this.LBFFHFCMEDE = this.FJPKMMJCQND.PKFCCBOMHJG;
		this.IEOLIHCKPPN = base.GPONHFNLHCN.FOOEEHDJBQN().y / 488f;
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.CIDMBQQGPNM(this);
	}

	// Token: 0x06007336 RID: 29494 RVA: 0x0002A10B File Offset: 0x0002830B
	public int GLGFDMQIBKJ()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007337 RID: 29495 RVA: 0x0037BFE8 File Offset: 0x0037A1E8
	public void JGNLPPPEFJL()
	{
		Vector3 oepdepofngi = base.GPONHFNLHCN.HGNEKQHNFCC;
		if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
		{
			oepdepofngi = this.HLFEKPCOELI.position;
		}
		int num = this.PLGCIDQOCKC(oepdepofngi);
		if (num != -1 && this.OMBMLQCNFQD != num)
		{
			this.OBIBKKNFLCQ(num, true);
		}
		if (num == -1 && this.OMBMLQCNFQD != -1)
		{
			this.GEHKBCEQQBB();
		}
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x0037B454 File Offset: 0x00379654
	private void PHKNEHDHOHK(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC, float HCBKDMLHJDF, float EFDJHNOIDJD, OLLILOPJNHQ MNILDCDHOFG)
	{
		if (MNILDCDHOFG.QBHHBPBKQDJ && LHCLJCLFKFJ - HCBKDMLHJDF < MNILDCDHOFG.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.DFFQECIDMDO + HCBKDMLHJDF;
		}
		else if (MNILDCDHOFG.IGPBFPCKNOG && LHCLJCLFKFJ + HCBKDMLHJDF > MNILDCDHOFG.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.JGJEPKHCBGP - HCBKDMLHJDF;
		}
		if (MNILDCDHOFG.IKDQPKGPPEH && MMLMNDPKIEC - EFDJHNOIDJD < MNILDCDHOFG.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = MNILDCDHOFG.BIPDHOPHDMK + EFDJHNOIDJD;
		}
		else if (MNILDCDHOFG.PELBNKEHOHF && MMLMNDPKIEC + EFDJHNOIDJD > MNILDCDHOFG.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = MNILDCDHOFG.MMHQFDMKQDQ - EFDJHNOIDJD;
		}
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x0037C054 File Offset: 0x0037A254
	public void OBIBKKNFLCQ(string HHGCOIJDINN, bool KBDGIQIOCCE = true)
	{
		NPOMOOBFCNI.KHPCEMBDPDD khpcembdpdd = new NPOMOOBFCNI.KHPCEMBDPDD();
		khpcembdpdd.HHGCOIJDINN = HHGCOIJDINN;
		this.OBIBKKNFLCQ(this.HDFEHEPPKNP.FindIndex(new Predicate<Room>(khpcembdpdd.QOLDPJNMBBM)), KBDGIQIOCCE);
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x0037B1B8 File Offset: 0x003793B8
	private IEnumerator KJMHQKBHBIB(OLLILOPJNHQ FLGMKLJEILH, float BOGFMMKKONF, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseOut)
	{
		NPOMOOBFCNI.HDQCONLEOHJ hdqconleohj = new NPOMOOBFCNI.HDQCONLEOHJ();
		hdqconleohj.FQCECBMJCDB = FQCECBMJCDB;
		hdqconleohj.BOGFMMKKONF = BOGFMMKKONF;
		hdqconleohj.IGKGGDGHHQH = IGKGGDGHHQH;
		hdqconleohj.FLGMKLJEILH = FLGMKLJEILH;
		hdqconleohj.QNDQJMNKFNN = this;
		return hdqconleohj;
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x0037C08C File Offset: 0x0037A28C
	public void NPKBPPQDIPE(string HHGCOIJDINN, bool KBDGIQIOCCE = true)
	{
		NPOMOOBFCNI.KHPCEMBDPDD khpcembdpdd = new NPOMOOBFCNI.KHPCEMBDPDD();
		khpcembdpdd.HHGCOIJDINN = HHGCOIJDINN;
		this.LBCIBEJODCO(this.HDFEHEPPKNP.FindIndex(new Predicate<Room>(khpcembdpdd.BFPJJOJJGNN)), KBDGIQIOCCE);
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x0002A07C File Offset: 0x0002827C
	public Room DKPKGGPCDDJ()
	{
		return (this.OMBMLQCNFQD < 0 || this.OMBMLQCNFQD >= this.HDFEHEPPKNP.Count) ? null : this.HDFEHEPPKNP[this.OMBMLQCNFQD];
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x0037ADA4 File Offset: 0x00378FA4
	public void JCLBPLNLHBM(float JQQLQMJMQQE, float DOINIJGBCGL, float PPJDCFKOCGG, float DOFMODCQGIB, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseInOut, bool FNPQKHLGCFB = false, bool FEFONHNOCKM = false, float NGEFFQBOKKN = 1.5f, string CIQFCJGQEMH = "")
	{
		Room item = new Room
		{
			ID = CIQFCJGQEMH,
			Dimensions = new Rect(JQQLQMJMQQE, DOINIJGBCGL, PPJDCFKOCGG, DOFMODCQGIB),
			TransitionDuration = FQCECBMJCDB,
			TransitionEaseType = IGKGGDGHHQH,
			ScaleCameraToFit = FNPQKHLGCFB,
			Zoom = FEFONHNOCKM,
			ZoomScale = NGEFFQBOKKN
		};
		this.HDFEHEPPKNP.Add(item);
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x0037C134 File Offset: 0x0037A334
	public void MQECIDFPGBC(string JCNJKQMKDOE)
	{
		NPOMOOBFCNI.QOFPDBEBJNG qofpdbebjng = new NPOMOOBFCNI.QOFPDBEBJNG();
		qofpdbebjng.JCNJKQMKDOE = JCNJKQMKDOE;
		Room room = this.HDFEHEPPKNP.Find(new Predicate<Room>(qofpdbebjng.QOLDPJNMBBM));
		if (room != null)
		{
			this.HDFEHEPPKNP.Remove(room);
		}
		else
		{
			UnityEngine.Debug.LogWarning(qofpdbebjng.JCNJKQMKDOE + " not found in the Rooms list.");
		}
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x0037ADA4 File Offset: 0x00378FA4
	public void QNDMDGMMQOO(float JQQLQMJMQQE, float DOINIJGBCGL, float PPJDCFKOCGG, float DOFMODCQGIB, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseInOut, bool FNPQKHLGCFB = false, bool FEFONHNOCKM = false, float NGEFFQBOKKN = 1.5f, string CIQFCJGQEMH = "")
	{
		Room item = new Room
		{
			ID = CIQFCJGQEMH,
			Dimensions = new Rect(JQQLQMJMQQE, DOINIJGBCGL, PPJDCFKOCGG, DOFMODCQGIB),
			TransitionDuration = FQCECBMJCDB,
			TransitionEaseType = IGKGGDGHHQH,
			ScaleCameraToFit = FNPQKHLGCFB,
			Zoom = FEFONHNOCKM,
			ZoomScale = NGEFFQBOKKN
		};
		this.HDFEHEPPKNP.Add(item);
	}

	// Token: 0x06007341 RID: 29505 RVA: 0x0037C190 File Offset: 0x0037A390
	protected virtual void JIMBLQBBDKO()
	{
		base.Awake();
		this.FJPKMMJCQND = base.GPONHFNLHCN.GetComponent<MDFGNNIKFEP>();
		this.LBFFHFCMEDE = this.FJPKMMJCQND.QDNQCGMNNOJ();
		this.IEOLIHCKPPN = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1353f;
		base.GPONHFNLHCN.MPHJLPNDJJL(this);
		base.GPONHFNLHCN.NODLKQNBMFD(this);
	}

	// Token: 0x06007342 RID: 29506 RVA: 0x0037C1FC File Offset: 0x0037A3FC
	private float CGHQFGJJJIH(Rect ICKFOCJHBEF)
	{
		float num = ICKFOCJHBEF.width / base.GPONHFNLHCN.PGKODNCDNJQ.x;
		float num2 = ICKFOCJHBEF.height / base.GPONHFNLHCN.FOOEEHDJBQN().y;
		if (num < num2)
		{
			return ICKFOCJHBEF.width / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / 1785f;
		}
		return ICKFOCJHBEF.height / 620f;
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x0002A10B File Offset: 0x0002830B
	public int LMMONBFBHBI()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x0037C274 File Offset: 0x0037A474
	public void PMMDJKQEKBN()
	{
		Vector3 oepdepofngi = base.GPONHFNLHCN.KEQQHBKDJHP();
		if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
		{
			oepdepofngi = this.HLFEKPCOELI.position;
		}
		int num = this.IQEKEKOPIQF(oepdepofngi);
		if (num != -1 && this.OMBMLQCNFQD != num)
		{
			this.LBCIBEJODCO(num, true);
		}
		if (num == -1 && this.OMBMLQCNFQD != -1)
		{
			this.GKFQLOMNQJL();
		}
	}

	// Token: 0x06007345 RID: 29509 RVA: 0x0037C2E0 File Offset: 0x0037A4E0
	private void FNBMELMIGPD(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = false,
			PELBNKEHOHF = false,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 1872f,
			IKDQPKGPPEH = true,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 579f,
			QBHHBPBKQDJ = true,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 1790f,
			IGPBFPCKNOG = false,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 1857f
		};
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1558f;
		float num2 = this.NKQFLBIFGQG(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.HQLIHGNLIHH(flgmkljeilh, num, (!KBDGIQIOCCE) ? 1964f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x0037ADA4 File Offset: 0x00378FA4
	public void ICBEHOIQLGQ(float JQQLQMJMQQE, float DOINIJGBCGL, float PPJDCFKOCGG, float DOFMODCQGIB, float FQCECBMJCDB = 1f, GMNJJQQPEDB IGKGGDGHHQH = GMNJJQQPEDB.EaseInOut, bool FNPQKHLGCFB = false, bool FEFONHNOCKM = false, float NGEFFQBOKKN = 1.5f, string CIQFCJGQEMH = "")
	{
		Room item = new Room
		{
			ID = CIQFCJGQEMH,
			Dimensions = new Rect(JQQLQMJMQQE, DOINIJGBCGL, PPJDCFKOCGG, DOFMODCQGIB),
			TransitionDuration = FQCECBMJCDB,
			TransitionEaseType = IGKGGDGHHQH,
			ScaleCameraToFit = FNPQKHLGCFB,
			Zoom = FEFONHNOCKM,
			ZoomScale = NGEFFQBOKKN
		};
		this.HDFEHEPPKNP.Add(item);
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x0002A06A File Offset: 0x0002826A
	public void IEFKIHBEMKH(int BGBMIEJJQKC)
	{
		this.GKLLDJLQPMM = BGBMIEJJQKC;
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x0037BB90 File Offset: 0x00379D90
	public int KJDOFHOGGGC(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 0; i < this.HDFEHEPPKNP.Count; i += 0)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06007349 RID: 29513 RVA: 0x0037C454 File Offset: 0x0037A654
	public void IJQEQGPQGKD()
	{
		if (this.DBCJHFMLEOP)
		{
			this.OMBMLQCNFQD = -1;
			if (this.PHPPDFCJPDD != null)
			{
				this.PHPPDFCJPDD.Invoke(this.OMBMLQCNFQD, this.GCLQFLQMMLN);
			}
			if (this.MBKKPHHDNNC != null)
			{
				base.StopCoroutine(this.MBKKPHHDNNC);
			}
			this.MBKKPHHDNNC = base.StartCoroutine(this.MHHLLFCEBNI(this.LBFFHFCMEDE, this.IEOLIHCKPPN, this.IEHFBKOPQLN, this.NPJEPNEOQPP));
		}
		if (this.BHFIEMMJDOD != null)
		{
			this.BHFIEMMJDOD.Invoke();
		}
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x0002A113 File Offset: 0x00028313
	public Vector3 FIOLQHKHOED(float GPFIDEJEMEG, Vector3 PJKPLOCIBHP)
	{
		if (!base.enabled)
		{
			return PJKPLOCIBHP;
		}
		if (this.GKDDKEJOFBP)
		{
			return this.NHCKFQMGIJD;
		}
		return PJKPLOCIBHP;
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x0037B578 File Offset: 0x00379778
	public void QNOFLOGHQPN()
	{
		if (this.DBCJHFMLEOP)
		{
			this.OMBMLQCNFQD = -1;
			if (this.PHPPDFCJPDD != null)
			{
				this.PHPPDFCJPDD.Invoke(this.OMBMLQCNFQD, this.GCLQFLQMMLN);
			}
			if (this.MBKKPHHDNNC != null)
			{
				base.StopCoroutine(this.MBKKPHHDNNC);
			}
			this.MBKKPHHDNNC = base.StartCoroutine(this.FLKGIIENEOC(this.LBFFHFCMEDE, this.IEOLIHCKPPN, this.IEHFBKOPQLN, this.NPJEPNEOQPP));
		}
		if (this.BHFIEMMJDOD != null)
		{
			this.BHFIEMMJDOD.Invoke();
		}
	}

	// Token: 0x0600734C RID: 29516 RVA: 0x00028EBD File Offset: 0x000270BD
	protected virtual void CCDOMEQLFGJ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x0600734D RID: 29517 RVA: 0x0037C4E0 File Offset: 0x0037A6E0
	private float IHJDEMIKEQQ(Rect ICKFOCJHBEF)
	{
		float num = ICKFOCJHBEF.width / base.GPONHFNLHCN.PGKODNCDNJQ.x;
		float num2 = ICKFOCJHBEF.height / base.GPONHFNLHCN.PGKODNCDNJQ.y;
		if (num < num2)
		{
			return ICKFOCJHBEF.width / base.GPONHFNLHCN.PGHJQNJLJKG.aspect / 2f;
		}
		return ICKFOCJHBEF.height / 2f;
	}

	// Token: 0x0600734E RID: 29518 RVA: 0x0037BD84 File Offset: 0x00379F84
	public int IJICMECBPNG(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 0; i < this.HDFEHEPPKNP.Count; i++)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x0037BD84 File Offset: 0x00379F84
	public int IQEKEKOPIQF(Vector3 OEPDEPOFNGI)
	{
		int result = -1;
		for (int i = 0; i < this.HDFEHEPPKNP.Count; i++)
		{
			if (BDKMFJQPGGE.NDDFJBMCIDB(this.HDFEHEPPKNP[i].Dimensions.x, this.HDFEHEPPKNP[i].Dimensions.y, this.HDFEHEPPKNP[i].Dimensions.width, this.HDFEHEPPKNP[i].Dimensions.height, this.FKGNBCKJPQO(OEPDEPOFNGI), this.JNBBJCLFFBB(OEPDEPOFNGI)))
			{
				result = i;
			}
		}
		return result;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x0002A0DB File Offset: 0x000282DB
	protected virtual void JOLDGDIPFEC()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x06007351 RID: 29521 RVA: 0x0037B454 File Offset: 0x00379654
	private void BQNBQHBNDGH(ref float LHCLJCLFKFJ, ref float MMLMNDPKIEC, float HCBKDMLHJDF, float EFDJHNOIDJD, OLLILOPJNHQ MNILDCDHOFG)
	{
		if (MNILDCDHOFG.QBHHBPBKQDJ && LHCLJCLFKFJ - HCBKDMLHJDF < MNILDCDHOFG.DFFQECIDMDO)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.DFFQECIDMDO + HCBKDMLHJDF;
		}
		else if (MNILDCDHOFG.IGPBFPCKNOG && LHCLJCLFKFJ + HCBKDMLHJDF > MNILDCDHOFG.JGJEPKHCBGP)
		{
			LHCLJCLFKFJ = MNILDCDHOFG.JGJEPKHCBGP - HCBKDMLHJDF;
		}
		if (MNILDCDHOFG.IKDQPKGPPEH && MMLMNDPKIEC - EFDJHNOIDJD < MNILDCDHOFG.BIPDHOPHDMK)
		{
			MMLMNDPKIEC = MNILDCDHOFG.BIPDHOPHDMK + EFDJHNOIDJD;
		}
		else if (MNILDCDHOFG.PELBNKEHOHF && MMLMNDPKIEC + EFDJHNOIDJD > MNILDCDHOFG.MMHQFDMKQDQ)
		{
			MMLMNDPKIEC = MNILDCDHOFG.MMHQFDMKQDQ - EFDJHNOIDJD;
		}
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x0002A10B File Offset: 0x0002830B
	public int DGQNIQFFBDF()
	{
		return this.GKLLDJLQPMM;
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x0037C558 File Offset: 0x0037A758
	private void NOBKFOPJHJG(Room NGOHPMHQKHB, bool KBDGIQIOCCE = true)
	{
		if (this.MBKKPHHDNNC != null)
		{
			base.StopCoroutine(this.MBKKPHHDNNC);
		}
		OLLILOPJNHQ flgmkljeilh = new OLLILOPJNHQ
		{
			GICJLBDMMEQ = true,
			PELBNKEHOHF = false,
			MMHQFDMKQDQ = NGOHPMHQKHB.Dimensions.y + NGOHPMHQKHB.Dimensions.height / 818f,
			IKDQPKGPPEH = true,
			BIPDHOPHDMK = NGOHPMHQKHB.Dimensions.y - NGOHPMHQKHB.Dimensions.height / 125f,
			QBHHBPBKQDJ = false,
			DFFQECIDMDO = NGOHPMHQKHB.Dimensions.x - NGOHPMHQKHB.Dimensions.width / 1042f,
			IGPBFPCKNOG = true,
			JGJEPKHCBGP = NGOHPMHQKHB.Dimensions.x + NGOHPMHQKHB.Dimensions.width / 1584f
		};
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1035f;
		float num2 = this.IHJDEMIKEQQ(NGOHPMHQKHB.Dimensions);
		if (NGOHPMHQKHB.ScaleCameraToFit)
		{
			num = num2;
		}
		else if (NGOHPMHQKHB.Zoom && this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale < num2)
		{
			num = this.IEOLIHCKPPN * NGOHPMHQKHB.ZoomScale;
		}
		else if (num2 < num)
		{
			num = num2;
		}
		this.MBKKPHHDNNC = base.StartCoroutine(this.HQLIHGNLIHH(flgmkljeilh, num, (!KBDGIQIOCCE) ? 1602f : NGOHPMHQKHB.TransitionDuration, NGOHPMHQKHB.TransitionEaseType));
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x0037C6CC File Offset: 0x0037A8CC
	public Room JCPPOMJBGCJ(string HHGCOIJDINN)
	{
		NPOMOOBFCNI.NCFKIGNLICJ ncfkignlicj = new NPOMOOBFCNI.NCFKIGNLICJ();
		ncfkignlicj.HHGCOIJDINN = HHGCOIJDINN;
		return this.HDFEHEPPKNP.Find(new Predicate<Room>(ncfkignlicj.PLBIJPINCJQ));
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x0037C700 File Offset: 0x0037A900
	public void MBQLINENPJF()
	{
		Vector3 oepdepofngi = base.GPONHFNLHCN.HGNEKQHNFCC;
		if (!this.OCGFLQMHBBG && this.HLFEKPCOELI != null)
		{
			oepdepofngi = this.HLFEKPCOELI.position;
		}
		int num = this.FHBFLCNPMPJ(oepdepofngi);
		if (num != -1 && this.OMBMLQCNFQD != num)
		{
			this.OBIBKKNFLCQ(num, true);
		}
		if (num == -1 && this.OMBMLQCNFQD != -1)
		{
			this.QNOFLOGHQPN();
		}
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x00028EBD File Offset: 0x000270BD
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.QNDGKBBGHNK(this);
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x0002A0DB File Offset: 0x000282DB
	protected virtual void DGJDQDOFNFP()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.BOFHBQKBBFC(this);
		base.GPONHFNLHCN.CONFHHMNMDH(this);
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x0037C76C File Offset: 0x0037A96C
	public void LBCIBEJODCO(int HGEPEPKHGLL, bool KBDGIQIOCCE = true)
	{
		if (HGEPEPKHGLL < 1 || HGEPEPKHGLL > this.HDFEHEPPKNP.Count - 1)
		{
			UnityEngine.Debug.LogError("toxicspikes" + HGEPEPKHGLL);
			return;
		}
		if (HGEPEPKHGLL == this.OMBMLQCNFQD)
		{
			return;
		}
		this.GCLQFLQMMLN = this.OMBMLQCNFQD;
		this.OMBMLQCNFQD = HGEPEPKHGLL;
		this.NOBKFOPJHJG(this.HDFEHEPPKNP[this.OMBMLQCNFQD], KBDGIQIOCCE);
		if (this.PHPPDFCJPDD != null)
		{
			this.PHPPDFCJPDD.Invoke(HGEPEPKHGLL, this.GCLQFLQMMLN);
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x0600735A RID: 29530 RVA: 0x0002A07C File Offset: 0x0002827C
	public Room NEHFKJOBDPN
	{
		get
		{
			return (this.OMBMLQCNFQD < 0 || this.OMBMLQCNFQD >= this.HDFEHEPPKNP.Count) ? null : this.HDFEHEPPKNP[this.OMBMLQCNFQD];
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x0600735B RID: 29531 RVA: 0x0002A0AE File Offset: 0x000282AE
	public int NONBHINEBME
	{
		get
		{
			return this.GCLQFLQMMLN;
		}
	}

	// Token: 0x040018C3 RID: 6339
	public const string OPGNGFNJDDP = "Rooms";

	// Token: 0x040018C4 RID: 6340
	private int OMBMLQCNFQD = -1;

	// Token: 0x040018C5 RID: 6341
	private int GCLQFLQMMLN = -1;

	// Token: 0x040018C6 RID: 6342
	public List<Room> HDFEHEPPKNP = new List<Room>();

	// Token: 0x040018C7 RID: 6343
	public float DDOHKDQFNDH = 0.1f;

	// Token: 0x040018C8 RID: 6344
	public bool OCGFLQMHBBG = true;

	// Token: 0x040018C9 RID: 6345
	public Transform HLFEKPCOELI;

	// Token: 0x040018CA RID: 6346
	public bool OMJNPIFJEDF = true;

	// Token: 0x040018CB RID: 6347
	public bool DBCJHFMLEOP;

	// Token: 0x040018CC RID: 6348
	public float IEHFBKOPQLN = 1f;

	// Token: 0x040018CD RID: 6349
	public GMNJJQQPEDB NPJEPNEOQPP;

	// Token: 0x040018CE RID: 6350
	public bool HIIEFLIFCNP = true;

	// Token: 0x040018CF RID: 6351
	public RoomEvent PHPPDFCJPDD;

	// Token: 0x040018D0 RID: 6352
	public RoomEvent GJFQNOEQLCQ;

	// Token: 0x040018D1 RID: 6353
	public UnityEvent BHFIEMMJDOD;

	// Token: 0x040018D2 RID: 6354
	private MDFGNNIKFEP FJPKMMJCQND;

	// Token: 0x040018D3 RID: 6355
	private OLLILOPJNHQ LBFFHFCMEDE;

	// Token: 0x040018D4 RID: 6356
	private bool GKDDKEJOFBP;

	// Token: 0x040018D5 RID: 6357
	private Vector3 NHCKFQMGIJD;

	// Token: 0x040018D6 RID: 6358
	private float FHBCMICBNCE;

	// Token: 0x040018D7 RID: 6359
	private Coroutine MBKKPHHDNNC;

	// Token: 0x040018D8 RID: 6360
	private float IEOLIHCKPPN;

	// Token: 0x040018D9 RID: 6361
	private int HNMJQQFFBCL = 1001;

	// Token: 0x040018DA RID: 6362
	private int GKLLDJLQPMM = 3001;

	// Token: 0x02000365 RID: 869
	[CompilerGenerated]
	private sealed class KHPCEMBDPDD
	{
		// Token: 0x0600735C RID: 29532 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool GHIHFOKJLOM(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PLBIJPINCJQ(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PFFNEEIONGD(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PKDCKGFHMLJ(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool OJBPHFHFPHL(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool CNCBEFQOQJD(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool LFBNBDHKNGB(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool BFPJJOJJGNN(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool DKPDDQPNNOI(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool NBJDHHMEPJE(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool IPLFPDLIOGQ(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool ONCBOEQMGGP(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool QQFJCGNCOJJ(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PDKEEIPKOFK(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PGKMMLBJHBM(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool LGBHQGHDLCB(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool QOLDPJNMBBM(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool PCJPNNBPOEC(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool POGJNQEMENH(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x0002A12F File Offset: 0x0002832F
		internal bool NLIGJMHCJGN(Room NGOHPMHQKHB)
		{
			return NGOHPMHQKHB.ID == this.HHGCOIJDINN;
		}

		// Token: 0x040018DB RID: 6363
		internal string HHGCOIJDINN;
	}

	// Token: 0x02000366 RID: 870
	[CompilerGenerated]
	private sealed class QOFPDBEBJNG
	{
		// Token: 0x06007371 RID: 29553 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool PDKEEIPKOFK(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool HDJJCMCPPEH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool KQCKBKKQDQH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool GHIHFOKJLOM(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool QQFJCGNCOJJ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool IBONGDIOLNF(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool NBJDHHMEPJE(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool POGJNQEMENH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool QOLDPJNMBBM(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool PGKMMLBJHBM(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool GHFMGEKPKCE(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool PCNBJBKOCJH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool EJCEEPECCBC(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool MHBEIFOJMIB(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool IPLFPDLIOGQ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool PCJPNNBPOEC(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool EDJEKKGCKBE(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool PLBIJPINCJQ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool ONCBOEQMGGP(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool QBMNQFFBBCI(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x0002A142 File Offset: 0x00028342
		internal bool MEQDCJHMEMH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.JCNJKQMKDOE;
		}

		// Token: 0x040018DC RID: 6364
		internal string JCNJKQMKDOE;
	}

	// Token: 0x02000367 RID: 871
	[CompilerGenerated]
	private sealed class NCFKIGNLICJ
	{
		// Token: 0x06007387 RID: 29575 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool MMIMJHOQNFO(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PKDCKGFHMLJ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PLBIJPINCJQ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PKCMHIKBGED(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool CNCBEFQOQJD(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool GJLLGOLDFQI(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool KMGIDJIIBOC(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PCJPNNBPOEC(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool ONCBOEQMGGP(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool QQFJCGNCOJJ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PGKMMLBJHBM(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool DILJOJFIGLB(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool JIEIPQGGEHO(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool OCGHFEHKILC(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool IPLFPDLIOGQ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool IBONGDIOLNF(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool QOLDPJNMBBM(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool CIQBIFONFKJ(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool MEQDCJHMEMH(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool NOMLDCCENGO(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool DJMKJMBLCFP(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x0002A155 File Offset: 0x00028355
		internal bool PDKEEIPKOFK(Room NJBFOQDJBON)
		{
			return NJBFOQDJBON.ID == this.HHGCOIJDINN;
		}

		// Token: 0x040018DD RID: 6365
		internal string HHGCOIJDINN;
	}
}
