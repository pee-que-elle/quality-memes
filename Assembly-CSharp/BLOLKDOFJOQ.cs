using System;
using UnityEngine;

// Token: 0x02000293 RID: 659
[AddComponentMenu("NGUI/Tween/Tween Emission")]
public class BLOLKDOFJOQ : UITweener
{
	// Token: 0x06005BA7 RID: 23463 RVA: 0x00023E51 File Offset: 0x00022051
	public void OMLKPPLFQJI(Color BGBMIEJJQKC)
	{
		this.GFEBHPLLBHO(BGBMIEJJQKC);
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x00023E5A File Offset: 0x0002205A
	[ContextMenu("Assume value of 'From'")]
	private void MOKOMDGBDHD()
	{
		this.BGBMIEJJQKC = this.CGHQEHCBQHB;
	}

	// Token: 0x06005BA9 RID: 23465 RVA: 0x00023E68 File Offset: 0x00022068
	public void GFEBHPLLBHO(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.KGOILPPMHMH();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.SetColor(" attack!\r\n", BGBMIEJJQKC);
		}
	}

	// Token: 0x06005BAA RID: 23466 RVA: 0x00023E99 File Offset: 0x00022099
	public Color FIDCEOEFBDK()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CDIDEPNHDPD();
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.GetColor("_WorldLightDir");
		}
		return Color.black;
	}

	// Token: 0x06005BAB RID: 23467 RVA: 0x00023ECD File Offset: 0x000220CD
	protected virtual void PMDQKHLNGEK(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.KGHDBJDLJBG(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06005BAC RID: 23468 RVA: 0x00023EE7 File Offset: 0x000220E7
	protected virtual void OBEHKKHPHQM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BILOLFJGFHD(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06005BAD RID: 23469 RVA: 0x00023F01 File Offset: 0x00022101
	public Color LHFPNEDFOGE()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.QBCIHDNDDCL();
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.GetColor("Goto");
		}
		return Color.black;
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06005BBF RID: 23487 RVA: 0x000240A6 File Offset: 0x000222A6
	// (set) Token: 0x06005BAE RID: 23470 RVA: 0x00023F35 File Offset: 0x00022135
	[Obsolete("Use 'value' instead")]
	public Color CEGFBBHMKOE
	{
		get
		{
			return this.BGBMIEJJQKC;
		}
		set
		{
			this.BGBMIEJJQKC = value;
		}
	}

	// Token: 0x06005BAF RID: 23471 RVA: 0x00023F3E File Offset: 0x0002213E
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
		this.BKMCCCGOGOM = this.BGBMIEJJQKC;
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x00023F4C File Offset: 0x0002214C
	public void KGHDBJDLJBG(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.SetColor("[/SUP]", BGBMIEJJQKC);
		}
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x002F4C0C File Offset: 0x002F2E0C
	private void NEMMDNLLFLG()
	{
		this.BJJNMHBPFNL = false;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x00023F7D File Offset: 0x0002217D
	// (set) Token: 0x06005BB8 RID: 23480 RVA: 0x00024026 File Offset: 0x00022226
	public Color BGBMIEJJQKC
	{
		get
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			if (this.OEFCJHKBJJG != null)
			{
				return this.OEFCJHKBJJG.GetColor("_EmissionColor");
			}
			return Color.black;
		}
		set
		{
			if (!this.BJJNMHBPFNL)
			{
				this.MDKEQEPIOEF();
			}
			else if (this.OEFCJHKBJJG != null)
			{
				this.OEFCJHKBJJG.SetColor("_EmissionColor", value);
			}
		}
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x00023FB1 File Offset: 0x000221B1
	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
		this.CGHQEHCBQHB = this.BGBMIEJJQKC;
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x00023FBF File Offset: 0x000221BF
	public virtual void JMHCCGEHJDF()
	{
		this.BKMCCCGOGOM = this.FKLOPEGEHGL();
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x00023FCD File Offset: 0x000221CD
	private void BIQKQBHOPOL()
	{
		this.DNLMCLKPOLM(this.CGHQEHCBQHB);
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x00023FDB File Offset: 0x000221DB
	protected virtual void PGLLINKQBFM(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x00023FF5 File Offset: 0x000221F5
	public void POQDIKDHCDF(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.MDKEQEPIOEF();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.SetColor("[-][/u]", BGBMIEJJQKC);
		}
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x002F4C0C File Offset: 0x002F2E0C
	private void QBCIHDNDDCL()
	{
		this.BJJNMHBPFNL = false;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x002F4C40 File Offset: 0x002F2E40
	public static NCNDQDBPNQN COEGBIHCDQE(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 416f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LDPDKOQLDDJ();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 462f)
		{
			ncndqdbpnqn.Sample(564f, true);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x00024075 File Offset: 0x00022275
	public void BILOLFJGFHD(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.CDIDEPNHDPD();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.SetColor("[CFX_SpawnSystem.GetNextObject()] A new instance has been created for \"", BGBMIEJJQKC);
		}
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x00023F35 File Offset: 0x00022135
	public void FQDFILFJIBB(Color BGBMIEJJQKC)
	{
		this.BGBMIEJJQKC = BGBMIEJJQKC;
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x00023FCD File Offset: 0x000221CD
	private void HICQNGNNCFG()
	{
		this.DNLMCLKPOLM(this.CGHQEHCBQHB);
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x002F4C0C File Offset: 0x002F2E0C
	private void CDIDEPNHDPD()
	{
		this.BJJNMHBPFNL = false;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x000AE1F8 File Offset: 0x000AC3F8
	public static NCNDQDBPNQN FJCEGFKJLCL(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 0f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.BGBMIEJJQKC;
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 0f)
		{
			ncndqdbpnqn.Sample(1f, true);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x000240AE File Offset: 0x000222AE
	private void GDKDQBEHJIC()
	{
		this.BILOLFJGFHD(this.BKMCCCGOGOM);
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x000240BC File Offset: 0x000222BC
	[ContextMenu("Assume value of 'To'")]
	private void IQPDLQCEQHJ()
	{
		this.BGBMIEJJQKC = this.BKMCCCGOGOM;
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x000240CA File Offset: 0x000222CA
	public virtual void QFQIBIDIEQK()
	{
		this.BKMCCCGOGOM = this.LHFPNEDFOGE();
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x002F4C0C File Offset: 0x002F2E0C
	private void NJOIMOJOBQG()
	{
		this.BJJNMHBPFNL = false;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x000240AE File Offset: 0x000222AE
	private void PCJODQLGMKM()
	{
		this.BILOLFJGFHD(this.BKMCCCGOGOM);
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x000240D8 File Offset: 0x000222D8
	protected virtual void GLCDMLHOQGQ(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.POQDIKDHCDF(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x000240F2 File Offset: 0x000222F2
	private void HGGDHJMPJBG()
	{
		this.POQDIKDHCDF(this.CGHQEHCBQHB);
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x00024100 File Offset: 0x00022300
	protected virtual void MICLCICHJGP(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.DNLMCLKPOLM(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x00023FDB File Offset: 0x000221DB
	protected override void OnUpdate(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x002F4C8C File Offset: 0x002F2E8C
	public static NCNDQDBPNQN HHOCDFFIBBP(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 504f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.BGBMIEJJQKC;
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 1961f)
		{
			ncndqdbpnqn.Sample(1254f, false);
			ncndqdbpnqn.enabled = true;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x0002411A File Offset: 0x0002231A
	public void DNLMCLKPOLM(Color BGBMIEJJQKC)
	{
		if (!this.BJJNMHBPFNL)
		{
			this.NJOIMOJOBQG();
		}
		else if (this.OEFCJHKBJJG != null)
		{
			this.OEFCJHKBJJG.SetColor("'s [ffff00]", BGBMIEJJQKC);
		}
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x000240CA File Offset: 0x000222CA
	public virtual void PENINFJMPDB()
	{
		this.BKMCCCGOGOM = this.LHFPNEDFOGE();
	}

	// Token: 0x06005BCE RID: 23502 RVA: 0x002F4CD8 File Offset: 0x002F2ED8
	private void KGOILPPMHMH()
	{
		this.BJJNMHBPFNL = true;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x000240F2 File Offset: 0x000222F2
	private void OQMCLMIFNJD()
	{
		this.POQDIKDHCDF(this.CGHQEHCBQHB);
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x0002414B File Offset: 0x0002234B
	public Color FKLOPEGEHGL()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.KGOILPPMHMH();
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.GetColor("$");
		}
		return Color.black;
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x002F4CD8 File Offset: 0x002F2ED8
	private void MDKEQEPIOEF()
	{
		this.BJJNMHBPFNL = true;
		Renderer component = base.GetComponent<Renderer>();
		if (component != null)
		{
			this.OEFCJHKBJJG = component.material;
			return;
		}
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x0002417F File Offset: 0x0002237F
	public Color KPEMLDHQLMJ()
	{
		return this.LHFPNEDFOGE();
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x00023FDB File Offset: 0x000221DB
	protected virtual void DPCGJCMJFND(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x002F4D0C File Offset: 0x002F2F0C
	public static NCNDQDBPNQN PCNQDPHGDFJ(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 1489f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.FIDCEOEFBDK();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 613f)
		{
			ncndqdbpnqn.Sample(946f, false);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x00023FDB File Offset: 0x000221DB
	protected virtual void BHHILMHJGDL(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.BGBMIEJJQKC = Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ);
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x00024187 File Offset: 0x00022387
	public Color NMQHEJINHKI()
	{
		if (!this.BJJNMHBPFNL)
		{
			this.NEMMDNLLFLG();
		}
		if (this.OEFCJHKBJJG != null)
		{
			return this.OEFCJHKBJJG.GetColor("Drizzle");
		}
		return Color.black;
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x002F4D58 File Offset: 0x002F2F58
	public static NCNDQDBPNQN EOKHEPPPQDD(GameObject CGHIENBIHCO, float CPKNEQGKQPQ, Color CEGFBBHMKOE)
	{
		NCNDQDBPNQN ncndqdbpnqn = UITweener.Begin<NCNDQDBPNQN>(CGHIENBIHCO, CPKNEQGKQPQ, 1435f);
		ncndqdbpnqn.CGHQEHCBQHB = ncndqdbpnqn.LGNFPGFPBII();
		ncndqdbpnqn.BKMCCCGOGOM = CEGFBBHMKOE;
		if (CPKNEQGKQPQ <= 1048f)
		{
			ncndqdbpnqn.Sample(1554f, false);
			ncndqdbpnqn.enabled = false;
		}
		return ncndqdbpnqn;
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x000241BB File Offset: 0x000223BB
	protected virtual void CGBQENMCPGN(float PJDGFDBEOOJ, bool IJKDMCLDHNL)
	{
		this.GFEBHPLLBHO(Color.Lerp(this.CGHQEHCBQHB, this.BKMCCCGOGOM, PJDGFDBEOOJ));
	}

	// Token: 0x040013DF RID: 5087
	public Color CGHQEHCBQHB = Color.white;

	// Token: 0x040013E0 RID: 5088
	public Color BKMCCCGOGOM = Color.white;

	// Token: 0x040013E1 RID: 5089
	private bool BJJNMHBPFNL;

	// Token: 0x040013E2 RID: 5090
	private Material OEFCJHKBJJG;
}
