using System;
using UnityEngine;

// Token: 0x0200005E RID: 94
[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
public class KBIJFBOECFE : MonoBehaviour
{
	// Token: 0x06000D01 RID: 3329 RVA: 0x00007242 File Offset: 0x00005442
	private void Start()
	{
		this.PNBOOLEOKCI = true;
		this.EIMGHQNJNHL();
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x00007251 File Offset: 0x00005451
	private void OLLNOFNEEIL()
	{
		this.PNBOOLEOKCI = false;
		this.EIMGHQNJNHL();
	}

	// Token: 0x06000D03 RID: 3331 RVA: 0x00070528 File Offset: 0x0006E728
	private void GGKFLLNHIFB(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = true;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x000705CC File Offset: 0x0006E7CC
	private void OnEnable()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.EPDKEQFDCDC == null && this.draggablePanel != null)
		{
			this.EPDKEQFDCDC = this.draggablePanel;
			this.draggablePanel = null;
		}
		if (this.PNBOOLEOKCI && (this.DMPBHCOMNHL || this.HCLBPEMQFBO == null))
		{
			this.EIMGHQNJNHL();
		}
	}

	// Token: 0x06000D05 RID: 3333 RVA: 0x00007260 File Offset: 0x00005460
	public void PHJFIQQCIMG(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x00070638 File Offset: 0x0006E838
	private void MLOQLQBHNFH()
	{
		FKBFPICKJQG fkbfpickjqg = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
		if (!(this.EPDKEQFDCDC == null) && (!this.DMPBHCOMNHL || !(fkbfpickjqg != this.EPDKEQFDCDC)))
		{
			if (this.EPDKEQFDCDC == fkbfpickjqg)
			{
				this.DMPBHCOMNHL = false;
			}
		}
		else
		{
			this.EPDKEQFDCDC = fkbfpickjqg;
			this.DMPBHCOMNHL = false;
		}
		this.HCLBPEMQFBO = this.EPDKEQFDCDC;
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x00007283 File Offset: 0x00005483
	private void QEKCDOIDHII(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.EODHILDCPNH(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x000072A6 File Offset: 0x000054A6
	private void IKHIQQKHILB()
	{
		this.PNBOOLEOKCI = false;
		this.DNJEMGLDPKB();
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x00007260 File Offset: 0x00005460
	public void BFHBCIMICHD(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x000072B5 File Offset: 0x000054B5
	private void GJNGNIBFMLG(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.HBJGEQFDQQP(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x000072D8 File Offset: 0x000054D8
	private void QNFHEHFHHGC()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(false);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x000072A6 File Offset: 0x000054A6
	private void LNHDODMGBKC()
	{
		this.PNBOOLEOKCI = false;
		this.DNJEMGLDPKB();
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00007260 File Offset: 0x00005460
	public void HCDEGLICGOB(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00007251 File Offset: 0x00005451
	private void FCOIMQGENDB()
	{
		this.PNBOOLEOKCI = false;
		this.EIMGHQNJNHL();
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x000072A6 File Offset: 0x000054A6
	private void JCQCNFLNMNP()
	{
		this.PNBOOLEOKCI = false;
		this.DNJEMGLDPKB();
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x000706A8 File Offset: 0x0006E8A8
	private void LHNFIFJBBDE(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = false;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00007316 File Offset: 0x00005516
	private void MKQFKMQDGPE()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(true);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x000706A8 File Offset: 0x0006E8A8
	private void FFMOLDQLBEE(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = false;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00007260 File Offset: 0x00005460
	public void IKQDJCPHMLD(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00070528 File Offset: 0x0006E728
	private void IJJQNKBOKCM(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = true;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00007354 File Offset: 0x00005554
	private void NIECOBNOCEQ(Vector2 JDOGIQGGLKM)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.OHPHCINGFGI();
		}
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00007242 File Offset: 0x00005442
	private void JDLQNCEDMPI()
	{
		this.PNBOOLEOKCI = true;
		this.EIMGHQNJNHL();
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00007260 File Offset: 0x00005460
	public void DFBDPGOJHHM(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00007283 File Offset: 0x00005483
	private void OnScroll(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.EODHILDCPNH(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0000737F File Offset: 0x0000557F
	private void DFNFEDMJKGK()
	{
		this.PNBOOLEOKCI = false;
		this.GOGKOBDODEB();
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00007283 File Offset: 0x00005483
	private void ENCBNMLNJJK(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.EODHILDCPNH(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x000706A8 File Offset: 0x0006E8A8
	private void OnPress(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = false;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x000072D8 File Offset: 0x000054D8
	private void ENEEJOGCLEB()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(false);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x000072B5 File Offset: 0x000054B5
	private void FCNEEGLGDPI(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.HBJGEQFDQQP(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0007074C File Offset: 0x0006E94C
	private void EFOJLEMPJFE()
	{
		this.BLLEFKOLKLP = base.transform;
		if (this.EPDKEQFDCDC == null && this.draggablePanel != null)
		{
			this.EPDKEQFDCDC = this.draggablePanel;
			this.draggablePanel = null;
		}
		if (this.PNBOOLEOKCI && (this.DMPBHCOMNHL || this.HCLBPEMQFBO == null))
		{
			this.MLOQLQBHNFH();
		}
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x000707B8 File Offset: 0x0006E9B8
	private void EIMGHQNJNHL()
	{
		FKBFPICKJQG fkbfpickjqg = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
		if (!(this.EPDKEQFDCDC == null) && (!this.DMPBHCOMNHL || !(fkbfpickjqg != this.EPDKEQFDCDC)))
		{
			if (this.EPDKEQFDCDC == fkbfpickjqg)
			{
				this.DMPBHCOMNHL = true;
			}
		}
		else
		{
			this.EPDKEQFDCDC = fkbfpickjqg;
			this.DMPBHCOMNHL = true;
		}
		this.HCLBPEMQFBO = this.EPDKEQFDCDC;
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0000738E File Offset: 0x0000558E
	private void OnDrag(Vector2 JDOGIQGGLKM)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.GBCKBGHDLKP();
		}
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00007260 File Offset: 0x00005460
	public void CKQOMENFHOM(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00070528 File Offset: 0x0006E728
	private void EDGHMGPBEKE(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = true;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0000737F File Offset: 0x0000557F
	private void ECQHGIBBBPI()
	{
		this.PNBOOLEOKCI = false;
		this.GOGKOBDODEB();
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x000072B5 File Offset: 0x000054B5
	private void HCHIHJNNEKC(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.HBJGEQFDQQP(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x00007260 File Offset: 0x00005460
	public void JBQCQHMNCHG(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x00007260 File Offset: 0x00005460
	public void GKHGLPNEBJC(Vector2 JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.DFBDPGOJHHM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00070528 File Offset: 0x0006E728
	private void JCCMBIHCLCD(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = true;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00070528 File Offset: 0x0006E728
	private void MQGPEPQLCQO(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = true;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x000073B9 File Offset: 0x000055B9
	private void DBFJHIHLQHO()
	{
		this.PNBOOLEOKCI = false;
		this.MLOQLQBHNFH();
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x000706A8 File Offset: 0x0006E8A8
	private void DHHFGGEDLEI(bool KCICOJFDCPQ)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		this.EIQLEKDFMMC = KCICOJFDCPQ;
		if (this.DMPBHCOMNHL && this.HCLBPEMQFBO != this.EPDKEQFDCDC)
		{
			this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			this.DMPBHCOMNHL = false;
		}
		if (this.EPDKEQFDCDC && base.enabled && IKBQNBHOJJB.PBBDNDMELHQ(base.gameObject))
		{
			this.EPDKEQFDCDC.EQGPDOCPPQQ(KCICOJFDCPQ);
			if (!KCICOJFDCPQ && this.DMPBHCOMNHL)
			{
				this.EPDKEQFDCDC = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
				this.HCLBPEMQFBO = this.EPDKEQFDCDC;
			}
		}
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x000073C8 File Offset: 0x000055C8
	private void OCEKBCEQGLB(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.GCIDJGDQPJM(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000072D8 File Offset: 0x000054D8
	private void OnDisable()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(false);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00007283 File Offset: 0x00005483
	private void HLGBFJICLNG(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.EODHILDCPNH(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00007316 File Offset: 0x00005516
	private void PPLIBEGDKHC()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(true);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00070828 File Offset: 0x0006EA28
	private void DNJEMGLDPKB()
	{
		FKBFPICKJQG fkbfpickjqg = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
		if (!(this.EPDKEQFDCDC == null) && (!this.DMPBHCOMNHL || !(fkbfpickjqg != this.EPDKEQFDCDC)))
		{
			if (this.EPDKEQFDCDC == fkbfpickjqg)
			{
				this.DMPBHCOMNHL = false;
			}
		}
		else
		{
			this.EPDKEQFDCDC = fkbfpickjqg;
			this.DMPBHCOMNHL = true;
		}
		this.HCLBPEMQFBO = this.EPDKEQFDCDC;
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x000073B9 File Offset: 0x000055B9
	private void NDFNCDDDJPN()
	{
		this.PNBOOLEOKCI = false;
		this.MLOQLQBHNFH();
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x00007354 File Offset: 0x00005554
	private void OPJCPEHFJGD(Vector2 JDOGIQGGLKM)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.OHPHCINGFGI();
		}
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x000073EB File Offset: 0x000055EB
	private void GLBLGKLEICM(Vector2 JDOGIQGGLKM)
	{
		if (this.FBLDNGKKEQJ)
		{
			return;
		}
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.QJKHGDCFMPO();
		}
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x00007316 File Offset: 0x00005516
	private void GKPPOKPLBPH()
	{
		if (this.EIQLEKDFMMC && this.HCLBPEMQFBO != null && this.HCLBPEMQFBO.GetComponentInChildren<PNEOGLLCBMK>() == null)
		{
			this.HCLBPEMQFBO.EQGPDOCPPQQ(true);
			this.HCLBPEMQFBO = null;
		}
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00007416 File Offset: 0x00005616
	private void JCLBDOHFHFQ(float JDOGIQGGLKM)
	{
		if (this.EPDKEQFDCDC && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EPDKEQFDCDC.QFODDIFQCEO(JDOGIQGGLKM);
		}
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x00070638 File Offset: 0x0006E838
	private void GOGKOBDODEB()
	{
		FKBFPICKJQG fkbfpickjqg = IKBQNBHOJJB.BBDJCHKMCPI<FKBFPICKJQG>(this.BLLEFKOLKLP);
		if (!(this.EPDKEQFDCDC == null) && (!this.DMPBHCOMNHL || !(fkbfpickjqg != this.EPDKEQFDCDC)))
		{
			if (this.EPDKEQFDCDC == fkbfpickjqg)
			{
				this.DMPBHCOMNHL = false;
			}
		}
		else
		{
			this.EPDKEQFDCDC = fkbfpickjqg;
			this.DMPBHCOMNHL = false;
		}
		this.HCLBPEMQFBO = this.EPDKEQFDCDC;
	}

	// Token: 0x040001F0 RID: 496
	public FKBFPICKJQG EPDKEQFDCDC;

	// Token: 0x040001F1 RID: 497
	[HideInInspector]
	[SerializeField]
	private FKBFPICKJQG draggablePanel;

	// Token: 0x040001F2 RID: 498
	private Transform BLLEFKOLKLP;

	// Token: 0x040001F3 RID: 499
	private FKBFPICKJQG HCLBPEMQFBO;

	// Token: 0x040001F4 RID: 500
	private bool DMPBHCOMNHL;

	// Token: 0x040001F5 RID: 501
	private bool PNBOOLEOKCI;

	// Token: 0x040001F6 RID: 502
	public bool FBLDNGKKEQJ;

	// Token: 0x040001F7 RID: 503
	[NonSerialized]
	private bool EIQLEKDFMMC;
}
