using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000375 RID: 885
[HelpURL("http://www.procamera2d.com/user-guide/extension-transitions-fx/")]
public class CIKGJLEIPCG : BNEFIOCKQOE
{
	// Token: 0x0600757F RID: 30079 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void GBQMDEENGCL()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x0002A3B8 File Offset: 0x000285B8
	public void BFGNJNGLJLI()
	{
		this.FFKKNCPPHGK(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1186f, 1453f, this.HJHIHKCMKOG);
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void LKBCQODDQGJ()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x06007582 RID: 30082 RVA: 0x00386158 File Offset: 0x00384358
	protected virtual void GLLCQQCCGOG()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("thickfat");
		this.DLHEBHDNFBF = Shader.PropertyToID("FNT");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = true;
		this.PDBQNOEKBQC();
		this.GCELDLBDPOD();
		this.CKBMPNMBHLM();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 1909f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = true;
		}
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x0038620C File Offset: 0x0038440C
	protected virtual void PGJHPMOLHKN()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("[-] threw an ");
		this.DLHEBHDNFBF = Shader.PropertyToID(" waits for a target to make a move!\r\n");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = true;
		this.NGIMNGKPIIQ();
		this.EIDKPJCOONL();
		this.CKBMPNMBHLM();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 625f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = true;
		}
	}

	// Token: 0x06007584 RID: 30084 RVA: 0x003862C0 File Offset: 0x003844C0
	private IEnumerator IQLFHDILPDB(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		CIKGJLEIPCG.BNKQOEJQNHG bnkqoejqnhg = new CIKGJLEIPCG.BNKQOEJQNHG();
		bnkqoejqnhg.NNNQQHEGHQJ = NNNQQHEGHQJ;
		bnkqoejqnhg.PPLIPCEHGNM = PPLIPCEHGNM;
		bnkqoejqnhg.QNILHOOMMHG = QNILHOOMMHG;
		bnkqoejqnhg.GCIJNEIIPIM = GCIJNEIIPIM;
		bnkqoejqnhg.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bnkqoejqnhg.IBMMEEDBIJB = IBMMEEDBIJB;
		bnkqoejqnhg.QNDQJMNKFNN = this;
		return bnkqoejqnhg;
	}

	// Token: 0x06007585 RID: 30085 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void CQMHDDPGHBC()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x06007586 RID: 30086 RVA: 0x0002A412 File Offset: 0x00028612
	public void BMNGIILEKDM()
	{
		this.FFKKNCPPHGK(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1765f, 1569f, this.HJHIHKCMKOG);
	}

	// Token: 0x06007587 RID: 30087 RVA: 0x0002A43C File Offset: 0x0002863C
	public static CIKGJLEIPCG BEKHPOHIPDE()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("50/50");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x06007588 RID: 30088 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void PMCDDPNDPOH()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x06007589 RID: 30089 RVA: 0x00386308 File Offset: 0x00384508
	protected override void Awake()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("_Step");
		this.DLHEBHDNFBF = Shader.PropertyToID("_BackgroundColor");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = false;
		this.LEGNIFBLLMJ();
		this.GKJCJNEODFJ();
		this.CKBMPNMBHLM();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 1f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = true;
		}
	}

	// Token: 0x0600758A RID: 30090 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void GQEMPBLQFCF()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x0600758B RID: 30091 RVA: 0x0002A477 File Offset: 0x00028677
	public void MMBBBIMGQLH()
	{
		this.JONBKJNHCBC(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1067f, 895f, this.HJHIHKCMKOG);
	}

	// Token: 0x0600758C RID: 30092 RVA: 0x003863BC File Offset: 0x003845BC
	protected virtual void PIQJPNIKGJP()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("V");
		this.DLHEBHDNFBF = Shader.PropertyToID(" foresaw an attack!\r\n");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = false;
		this.COEEIKGGMFE();
		this.QOBNPGKQIKK();
		this.GQEMPBLQFCF();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 1371f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = false;
		}
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x00386470 File Offset: 0x00384670
	public void LEGNIFBLLMJ()
	{
		string text = this.HMGGMNQMGCB.ToString();
		if (!this.LHQMQQNKFHO.Equals(text))
		{
			this.ONGNJMFLGNP = new Material(Shader.Find("Hidden/ProCamera2D/TransitionsFX/" + text));
			this.LHQMQQNKFHO = text;
		}
		string text2 = this.PLNFKCJIGNQ.ToString();
		if (!this.HKIDFGEKFGC.Equals(text2))
		{
			this.HDKLHGONGGK = new Material(Shader.Find("Hidden/ProCamera2D/TransitionsFX/" + text2));
			this.HKIDFGEKFGC = text2;
		}
	}

	// Token: 0x0600758E RID: 30094 RVA: 0x00386504 File Offset: 0x00384704
	public void GCELDLBDPOD()
	{
		if (this.HMGGMNQMGCB != MDLFMPEEHMP.Fade)
		{
			if (this.HMGGMNQMGCB != (MDLFMPEEHMP)7)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Wipe)
				{
					this.ONGNJMFLGNP.SetInt("NPC", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Fade)
				{
					this.ONGNJMFLGNP.SetTexture("ironbarbs", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat("klutz", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("Slots_5", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("(X)", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Texture)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Circle)
			{
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Shutters)
				{
					this.HDKLHGONGGK.SetInt("start", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == (MDLFMPEEHMP)6)
				{
					this.HDKLHGONGGK.SetTexture("Content Fitter", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("\nText: ", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt("/01_", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("[04B9E6]Party", this.QCGQKLNLJEG);
	}

	// Token: 0x0600758F RID: 30095 RVA: 0x0002A4A1 File Offset: 0x000286A1
	public void ECHBJCKMKCC()
	{
		this.MNBQHMJCHHJ(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1554f, 1441f, this.HJHIHKCMKOG);
	}

	// Token: 0x06007590 RID: 30096 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void GOHNBKBPNDJ()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x06007591 RID: 30097 RVA: 0x00386644 File Offset: 0x00384844
	private void JONBKJNHCBC(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		if (this.ONGNJMFLGNP == null)
		{
			UnityEngine.Debug.LogWarning(" is getting pumped!\r\n");
			return;
		}
		if (this.QBNIMMOHKFQ != null)
		{
			base.StopCoroutine(this.QBNIMMOHKFQ);
		}
		this.QBNIMMOHKFQ = base.StartCoroutine(this.FLKGIIENEOC(PPLIPCEHGNM, CPKNEQGKQPQ, GCIJNEIIPIM, NNNQQHEGHQJ, QNILHOOMMHG, IBMMEEDBIJB));
	}

	// Token: 0x06007593 RID: 30099 RVA: 0x0002A4D7 File Offset: 0x000286D7
	public void QJNHGOKGNGJ()
	{
		this.MNBQHMJCHHJ(this.HDKLHGONGGK, this.FCPOGFMNGNB, this.GEHLJMEMQJG, 921f, 1445f, this.MCKPKEBELMF);
	}

	// Token: 0x06007594 RID: 30100 RVA: 0x0038669C File Offset: 0x0038489C
	public void PKMIOCPMIBC()
	{
		if (this.HMGGMNQMGCB != (MDLFMPEEHMP)8)
		{
			if (this.HMGGMNQMGCB != (MDLFMPEEHMP)7)
			{
				if (this.HMGGMNQMGCB == (MDLFMPEEHMP)8)
				{
					this.ONGNJMFLGNP.SetInt("!\r\n", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == (MDLFMPEEHMP)8)
				{
					this.ONGNJMFLGNP.SetTexture("\n[ff6666]HP:[-] ", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat("flyLimit", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("-enditem", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("skinshop", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Fade)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Shutters)
			{
				if (this.PLNFKCJIGNQ == (MDLFMPEEHMP)6)
				{
					this.HDKLHGONGGK.SetInt("Fly Cooldown", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Fade)
				{
					this.HDKLHGONGGK.SetTexture("Icon_Status_Paralyzed", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("Player/Clothe", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt(" began charging power!\r\n", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("Materials/DFODesktop", this.QCGQKLNLJEG);
	}

	// Token: 0x06007595 RID: 30101 RVA: 0x003867DC File Offset: 0x003849DC
	protected virtual void OJQHKOJJNCP()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("8x");
		this.DLHEBHDNFBF = Shader.PropertyToID("bag");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = true;
		this.LEGNIFBLLMJ();
		this.PKMIOCPMIBC();
		this.OPLMHDGMNEL();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 355f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = false;
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06007596 RID: 30102 RVA: 0x0002A501 File Offset: 0x00028701
	public static CIKGJLEIPCG QOQONHOOLNE
	{
		get
		{
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
				if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
				{
					throw new UnityException("ProCamera2D does not have a TransitionFX extension.");
				}
			}
			return CIKGJLEIPCG.NKGPQKNLCMC;
		}
	}

	// Token: 0x06007597 RID: 30103 RVA: 0x00386890 File Offset: 0x00384A90
	public void BIFIHNJKOBC()
	{
		if (this.HMGGMNQMGCB != (MDLFMPEEHMP)6)
		{
			if (this.HMGGMNQMGCB != MDLFMPEEHMP.Shutters)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Circle)
				{
					this.ONGNJMFLGNP.SetInt("Failed to use '", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == (MDLFMPEEHMP)8)
				{
					this.ONGNJMFLGNP.SetTexture(" lost all of its PP due to the grudge!\r\n", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat(" fell", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("Mute", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("Unlit/Transparent Colored", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Wipe)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Shutters)
			{
				if (this.PLNFKCJIGNQ == (MDLFMPEEHMP)6)
				{
					this.HDKLHGONGGK.SetInt("11", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Wipe)
				{
					this.HDKLHGONGGK.SetTexture("Guts", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("]", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt("frz", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("_ClipToWorld", this.QCGQKLNLJEG);
	}

	// Token: 0x06007598 RID: 30104 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void NIKMDKQEQKI()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x06007599 RID: 30105 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void CKBMPNMBHLM()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x0600759A RID: 30106 RVA: 0x0002A53C File Offset: 0x0002873C
	public void GLQGJINIJLL()
	{
		this.BPBFIBFPJMP.enabled = true;
	}

	// Token: 0x0600759B RID: 30107 RVA: 0x003869D0 File Offset: 0x00384BD0
	protected virtual void BEHGFNEDJDF()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("!");
		this.DLHEBHDNFBF = Shader.PropertyToID("!\r\n");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = true;
		this.PDBQNOEKBQC();
		this.QOBNPGKQIKK();
		this.CQMHDDPGHBC();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 203f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = true;
		}
	}

	// Token: 0x0600759C RID: 30108 RVA: 0x0002A54A File Offset: 0x0002874A
	public static CIKGJLEIPCG ODJQHLJCFGH()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.GHFFHFCEENG().GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("GUIRoot");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x0600759D RID: 30109 RVA: 0x0002A585 File Offset: 0x00028785
	public static CIKGJLEIPCG KNOOOEMQOFL()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("quickguard");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x0600759E RID: 30110 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void NOHJCKMOQJI()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x0600759F RID: 30111 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void CPLBKPNNHJG()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x060075A0 RID: 30112 RVA: 0x00386A84 File Offset: 0x00384C84
	public void HFMGCGPDINI()
	{
		if (this.HMGGMNQMGCB != (MDLFMPEEHMP)8)
		{
			if (this.HMGGMNQMGCB != MDLFMPEEHMP.Texture)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Fade)
				{
					this.ONGNJMFLGNP.SetInt("East", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == (MDLFMPEEHMP)6)
				{
					this.ONGNJMFLGNP.SetTexture("F7", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat("[00EE07]", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("23", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("[", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != (MDLFMPEEHMP)8)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Circle)
			{
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Texture)
				{
					this.HDKLHGONGGK.SetInt("/", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Blinds)
				{
					this.HDKLHGONGGK.SetTexture("d", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("System", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt("The Pokémon is protected by its white smoke, which prevents other Pokémon from lowering its stats.", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("BuffIcon_EncounterRateLowered", this.QCGQKLNLJEG);
	}

	// Token: 0x060075A1 RID: 30113 RVA: 0x00386BC4 File Offset: 0x00384DC4
	private void KKPEMQKNGMJ(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		if (this.ONGNJMFLGNP == null)
		{
			UnityEngine.Debug.LogWarning("unboost");
			return;
		}
		if (this.QBNIMMOHKFQ != null)
		{
			base.StopCoroutine(this.QBNIMMOHKFQ);
		}
		this.QBNIMMOHKFQ = base.StartCoroutine(this.MLNPNFOLBMN(PPLIPCEHGNM, CPKNEQGKQPQ, GCIJNEIIPIM, NNNQQHEGHQJ, QNILHOOMMHG, IBMMEEDBIJB));
	}

	// Token: 0x060075A2 RID: 30114 RVA: 0x003862C0 File Offset: 0x003844C0
	private IEnumerator MLNPNFOLBMN(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		CIKGJLEIPCG.BNKQOEJQNHG bnkqoejqnhg = new CIKGJLEIPCG.BNKQOEJQNHG();
		bnkqoejqnhg.NNNQQHEGHQJ = NNNQQHEGHQJ;
		bnkqoejqnhg.PPLIPCEHGNM = PPLIPCEHGNM;
		bnkqoejqnhg.QNILHOOMMHG = QNILHOOMMHG;
		bnkqoejqnhg.GCIJNEIIPIM = GCIJNEIIPIM;
		bnkqoejqnhg.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bnkqoejqnhg.IBMMEEDBIJB = IBMMEEDBIJB;
		bnkqoejqnhg.QNDQJMNKFNN = this;
		return bnkqoejqnhg;
	}

	// Token: 0x060075A3 RID: 30115 RVA: 0x00386C1C File Offset: 0x00384E1C
	private void FFKKNCPPHGK(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		if (this.ONGNJMFLGNP == null)
		{
			UnityEngine.Debug.LogWarning("TransitionsFX not initialized yet. You're probably calling TransitionEnter/Exit from an Awake method. Please call it from a Start method instead.");
			return;
		}
		if (this.QBNIMMOHKFQ != null)
		{
			base.StopCoroutine(this.QBNIMMOHKFQ);
		}
		this.QBNIMMOHKFQ = base.StartCoroutine(this.FLKGIIENEOC(PPLIPCEHGNM, CPKNEQGKQPQ, GCIJNEIIPIM, NNNQQHEGHQJ, QNILHOOMMHG, IBMMEEDBIJB));
	}

	// Token: 0x060075A4 RID: 30116 RVA: 0x0002A53C File Offset: 0x0002873C
	public void JENBHJDBLEE()
	{
		this.BPBFIBFPJMP.enabled = true;
	}

	// Token: 0x060075A5 RID: 30117 RVA: 0x0002A5C0 File Offset: 0x000287C0
	public static CIKGJLEIPCG KGOPJQOMMNC()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.GHFFHFCEENG().GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("Protects the Pokémon from recoil damage.");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x060075A6 RID: 30118 RVA: 0x0002A5FB File Offset: 0x000287FB
	public static CIKGJLEIPCG BLDBOFBFDED()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("K1");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x060075A7 RID: 30119 RVA: 0x003862C0 File Offset: 0x003844C0
	private IEnumerator JDLBGBFNFHJ(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		CIKGJLEIPCG.BNKQOEJQNHG bnkqoejqnhg = new CIKGJLEIPCG.BNKQOEJQNHG();
		bnkqoejqnhg.NNNQQHEGHQJ = NNNQQHEGHQJ;
		bnkqoejqnhg.PPLIPCEHGNM = PPLIPCEHGNM;
		bnkqoejqnhg.QNILHOOMMHG = QNILHOOMMHG;
		bnkqoejqnhg.GCIJNEIIPIM = GCIJNEIIPIM;
		bnkqoejqnhg.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bnkqoejqnhg.IBMMEEDBIJB = IBMMEEDBIJB;
		bnkqoejqnhg.QNDQJMNKFNN = this;
		return bnkqoejqnhg;
	}

	// Token: 0x060075A8 RID: 30120 RVA: 0x0002A636 File Offset: 0x00028836
	public static CIKGJLEIPCG JPMOJGDNKNC()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("Battle");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x060075A9 RID: 30121 RVA: 0x00386C74 File Offset: 0x00384E74
	public void COEEIKGGMFE()
	{
		string text = this.HMGGMNQMGCB.ToString();
		if (!this.LHQMQQNKFHO.Equals(text))
		{
			this.ONGNJMFLGNP = new Material(Shader.Find("#,##0" + text));
			this.LHQMQQNKFHO = text;
		}
		string text2 = this.PLNFKCJIGNQ.ToString();
		if (!this.HKIDFGEKFGC.Equals(text2))
		{
			this.HDKLHGONGGK = new Material(Shader.Find("[PG]" + text2));
			this.HKIDFGEKFGC = text2;
		}
	}

	// Token: 0x060075AA RID: 30122 RVA: 0x0002A3E2 File Offset: 0x000285E2
	public void OPLMHDGMNEL()
	{
		this.ONGNJMFLGNP.SetColor(this.DLHEBHDNFBF, this.DONIPNIDBOH);
		this.HDKLHGONGGK.SetColor(this.DLHEBHDNFBF, this.QBHDIBNMDJG);
	}

	// Token: 0x060075AB RID: 30123 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void CPIMICLBFMG()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x060075AC RID: 30124 RVA: 0x0002A671 File Offset: 0x00028871
	public void QQJOJMKJIOE()
	{
		this.FFKKNCPPHGK(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1f, 0f, this.HJHIHKCMKOG);
	}

	// Token: 0x060075AD RID: 30125 RVA: 0x00386D08 File Offset: 0x00384F08
	public void GKJCJNEODFJ()
	{
		if (this.HMGGMNQMGCB != MDLFMPEEHMP.Wipe)
		{
			if (this.HMGGMNQMGCB != MDLFMPEEHMP.Blinds)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Shutters)
				{
					this.ONGNJMFLGNP.SetInt("_Direction", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Texture)
				{
					this.ONGNJMFLGNP.SetTexture("_TransitionTex", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat("_Smoothing", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("_Direction", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("_Blinds", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Wipe)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Blinds)
			{
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Shutters)
				{
					this.HDKLHGONGGK.SetInt("_Direction", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Texture)
				{
					this.HDKLHGONGGK.SetTexture("_TransitionTex", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("_Smoothing", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt("_Direction", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("_Blinds", this.QCGQKLNLJEG);
	}

	// Token: 0x060075AE RID: 30126 RVA: 0x00386E48 File Offset: 0x00385048
	public void NGIMNGKPIIQ()
	{
		string text = this.HMGGMNQMGCB.ToString();
		if (!this.LHQMQQNKFHO.Equals(text))
		{
			this.ONGNJMFLGNP = new Material(Shader.Find("Old Password is to Short" + text));
			this.LHQMQQNKFHO = text;
		}
		string text2 = this.PLNFKCJIGNQ.ToString();
		if (!this.HKIDFGEKFGC.Equals(text2))
		{
			this.HDKLHGONGGK = new Material(Shader.Find("ResolutionX" + text2));
			this.HKIDFGEKFGC = text2;
		}
	}

	// Token: 0x060075AF RID: 30127 RVA: 0x0002A69B File Offset: 0x0002889B
	public void NQBLKJPMILD()
	{
		this.MNBQHMJCHHJ(this.HDKLHGONGGK, this.FCPOGFMNGNB, this.GEHLJMEMQJG, 1295f, 210f, this.MCKPKEBELMF);
	}

	// Token: 0x060075B0 RID: 30128 RVA: 0x00386EDC File Offset: 0x003850DC
	private void HOFMPLLJJIJ(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		if (this.ONGNJMFLGNP == null)
		{
			UnityEngine.Debug.LogWarning("waterabsorb");
			return;
		}
		if (this.QBNIMMOHKFQ != null)
		{
			base.StopCoroutine(this.QBNIMMOHKFQ);
		}
		this.QBNIMMOHKFQ = base.StartCoroutine(this.IQLFHDILPDB(PPLIPCEHGNM, CPKNEQGKQPQ, GCIJNEIIPIM, NNNQQHEGHQJ, QNILHOOMMHG, IBMMEEDBIJB));
	}

	// Token: 0x060075B1 RID: 30129 RVA: 0x00386F34 File Offset: 0x00385134
	public void QOBNPGKQIKK()
	{
		if (this.HMGGMNQMGCB != MDLFMPEEHMP.Fade)
		{
			if (this.HMGGMNQMGCB != MDLFMPEEHMP.Shutters)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Shutters)
				{
					this.ONGNJMFLGNP.SetInt("The sea of fire around ", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Wipe)
				{
					this.ONGNJMFLGNP.SetTexture("P. ", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat(" won 1x ", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt(" couldn't stay airborne because of gravity!\r\n", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("_MainTex", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != (MDLFMPEEHMP)6)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Circle)
			{
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Shutters)
				{
					this.HDKLHGONGGK.SetInt("HidePanel", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Blinds)
				{
					this.HDKLHGONGGK.SetTexture("w", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("cloudnine", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt(" caused an uproar!\r\n", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt("_1", this.QCGQKLNLJEG);
	}

	// Token: 0x060075B2 RID: 30130 RVA: 0x00387074 File Offset: 0x00385274
	protected virtual void ICINMCLMJDJ()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID(" Coins");
		this.DLHEBHDNFBF = Shader.PropertyToID("PvP Losses:");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = true;
		this.MDIGOQIJGGN();
		this.EIDKPJCOONL();
		this.OPLMHDGMNEL();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 1760f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = false;
		}
	}

	// Token: 0x060075B3 RID: 30131 RVA: 0x00387128 File Offset: 0x00385328
	public void PDBQNOEKBQC()
	{
		string text = this.HMGGMNQMGCB.ToString();
		if (!this.LHQMQQNKFHO.Equals(text))
		{
			this.ONGNJMFLGNP = new Material(Shader.Find("paralize" + text));
			this.LHQMQQNKFHO = text;
		}
		string text2 = this.PLNFKCJIGNQ.ToString();
		if (!this.HKIDFGEKFGC.Equals(text2))
		{
			this.HDKLHGONGGK = new Material(Shader.Find("]" + text2));
			this.HKIDFGEKFGC = text2;
		}
	}

	// Token: 0x060075B4 RID: 30132 RVA: 0x0002A6C5 File Offset: 0x000288C5
	public static CIKGJLEIPCG DOGEBLQHDHI()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.GHFFHFCEENG().GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("true");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x060075B5 RID: 30133 RVA: 0x003871BC File Offset: 0x003853BC
	private void MNBQHMJCHHJ(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		if (this.ONGNJMFLGNP == null)
		{
			UnityEngine.Debug.LogWarning("Big/");
			return;
		}
		if (this.QBNIMMOHKFQ != null)
		{
			base.StopCoroutine(this.QBNIMMOHKFQ);
		}
		this.QBNIMMOHKFQ = base.StartCoroutine(this.MLNPNFOLBMN(PPLIPCEHGNM, CPKNEQGKQPQ, GCIJNEIIPIM, NNNQQHEGHQJ, QNILHOOMMHG, IBMMEEDBIJB));
	}

	// Token: 0x060075B6 RID: 30134 RVA: 0x00387214 File Offset: 0x00385414
	protected virtual void LEJQMIECFCH()
	{
		base.Awake();
		CIKGJLEIPCG.NKGPQKNLCMC = this;
		this.FEMQNHDCQBJ = Shader.PropertyToID("focusband");
		this.DLHEBHDNFBF = Shader.PropertyToID("[FF8F00]");
		this.BPBFIBFPJMP = base.gameObject.AddComponent<IPHBCBQFPOI>();
		this.BPBFIBFPJMP.enabled = false;
		this.COEEIKGGMFE();
		this.EIDKPJCOONL();
		this.CQMHDDPGHBC();
		if (this.QHHBQKHNKIK)
		{
			this.IEEDKKNGBKO = 437f;
			this.BPBFIBFPJMP.GMNGIJCDNHK = this.ONGNJMFLGNP;
			this.BPBFIBFPJMP.GMNGIJCDNHK.SetFloat(this.FEMQNHDCQBJ, this.IEEDKKNGBKO);
			this.BPBFIBFPJMP.enabled = true;
		}
	}

	// Token: 0x060075B7 RID: 30135 RVA: 0x003872C8 File Offset: 0x003854C8
	public void EIDKPJCOONL()
	{
		if (this.HMGGMNQMGCB != MDLFMPEEHMP.Fade)
		{
			if (this.HMGGMNQMGCB != MDLFMPEEHMP.Blinds)
			{
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Circle)
				{
					this.ONGNJMFLGNP.SetInt("OnScroll", (int)this.PNEFLOOMGCH);
					goto IL_98;
				}
				if (this.HMGGMNQMGCB == MDLFMPEEHMP.Texture)
				{
					this.ONGNJMFLGNP.SetTexture("deltastream", this.IHLLIBOODEI);
					this.ONGNJMFLGNP.SetFloat("[PD]", this.MOLFGOFLQDF);
					goto IL_98;
				}
				goto IL_98;
			}
		}
		this.ONGNJMFLGNP.SetInt("_Detail", (int)this.FDLBCEIHLNQ);
		this.ONGNJMFLGNP.SetInt("BuffIcon_Teleport", this.DJKIKBQEDFD);
		IL_98:
		if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Circle)
		{
			if (this.PLNFKCJIGNQ != MDLFMPEEHMP.Shutters)
			{
				if (this.PLNFKCJIGNQ == MDLFMPEEHMP.Blinds)
				{
					this.HDKLHGONGGK.SetInt("_DetailOffsetX", (int)this.EPICDFDNPBF);
					return;
				}
				if (this.PLNFKCJIGNQ == (MDLFMPEEHMP)7)
				{
					this.HDKLHGONGGK.SetTexture("L", this.CHNKKQJFBCB);
					this.HDKLHGONGGK.SetFloat("' has been canceled.", this.LFENIDNKDPD);
					return;
				}
				return;
			}
		}
		this.HDKLHGONGGK.SetInt("#,##0", (int)this.FPBLJIHGBFO);
		this.HDKLHGONGGK.SetInt(" stockpiled 2!\r\n", this.QCGQKLNLJEG);
	}

	// Token: 0x060075B8 RID: 30136 RVA: 0x0002A700 File Offset: 0x00028900
	public void NJKQLGJFLGQ()
	{
		this.JONBKJNHCBC(this.HDKLHGONGGK, this.FCPOGFMNGNB, this.GEHLJMEMQJG, 1689f, 752f, this.MCKPKEBELMF);
	}

	// Token: 0x060075BA RID: 30138 RVA: 0x0002A72A File Offset: 0x0002892A
	public void KHEEMLQLJNE()
	{
		this.KKPEMQKNGMJ(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1699f, 1953f, this.HJHIHKCMKOG);
	}

	// Token: 0x060075BB RID: 30139 RVA: 0x0002A754 File Offset: 0x00028954
	public static CIKGJLEIPCG IKJJKLMMGBO()
	{
		if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
		{
			CIKGJLEIPCG.NKGPQKNLCMC = GNKDCOHMFEG.QOQONHOOLNE.GetComponent<CIKGJLEIPCG>();
			if (object.Equals(CIKGJLEIPCG.NKGPQKNLCMC, null))
			{
				throw new UnityException("[FF9900]");
			}
		}
		return CIKGJLEIPCG.NKGPQKNLCMC;
	}

	// Token: 0x060075BC RID: 30140 RVA: 0x003862C0 File Offset: 0x003844C0
	[DebuggerHidden]
	private IEnumerator FLKGIIENEOC(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		CIKGJLEIPCG.BNKQOEJQNHG bnkqoejqnhg = new CIKGJLEIPCG.BNKQOEJQNHG();
		bnkqoejqnhg.NNNQQHEGHQJ = NNNQQHEGHQJ;
		bnkqoejqnhg.PPLIPCEHGNM = PPLIPCEHGNM;
		bnkqoejqnhg.QNILHOOMMHG = QNILHOOMMHG;
		bnkqoejqnhg.GCIJNEIIPIM = GCIJNEIIPIM;
		bnkqoejqnhg.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bnkqoejqnhg.IBMMEEDBIJB = IBMMEEDBIJB;
		bnkqoejqnhg.QNDQJMNKFNN = this;
		return bnkqoejqnhg;
	}

	// Token: 0x060075BD RID: 30141 RVA: 0x003862C0 File Offset: 0x003844C0
	private IEnumerator JCPIKMKQMFK(Material PPLIPCEHGNM, float CPKNEQGKQPQ, float GCIJNEIIPIM, float NNNQQHEGHQJ, float QNILHOOMMHG, GMNJJQQPEDB IBMMEEDBIJB)
	{
		CIKGJLEIPCG.BNKQOEJQNHG bnkqoejqnhg = new CIKGJLEIPCG.BNKQOEJQNHG();
		bnkqoejqnhg.NNNQQHEGHQJ = NNNQQHEGHQJ;
		bnkqoejqnhg.PPLIPCEHGNM = PPLIPCEHGNM;
		bnkqoejqnhg.QNILHOOMMHG = QNILHOOMMHG;
		bnkqoejqnhg.GCIJNEIIPIM = GCIJNEIIPIM;
		bnkqoejqnhg.CPKNEQGKQPQ = CPKNEQGKQPQ;
		bnkqoejqnhg.IBMMEEDBIJB = IBMMEEDBIJB;
		bnkqoejqnhg.QNDQJMNKFNN = this;
		return bnkqoejqnhg;
	}

	// Token: 0x060075BE RID: 30142 RVA: 0x0002A78F File Offset: 0x0002898F
	public void LOQPKNJGQEH()
	{
		this.FFKKNCPPHGK(this.HDKLHGONGGK, this.FCPOGFMNGNB, this.GEHLJMEMQJG, 0f, 1f, this.MCKPKEBELMF);
	}

	// Token: 0x060075BF RID: 30143 RVA: 0x003874A0 File Offset: 0x003856A0
	public void MDIGOQIJGGN()
	{
		string text = this.HMGGMNQMGCB.ToString();
		if (!this.LHQMQQNKFHO.Equals(text))
		{
			this.ONGNJMFLGNP = new Material(Shader.Find("Sometimes heals an ally's status condition." + text));
			this.LHQMQQNKFHO = text;
		}
		string text2 = this.PLNFKCJIGNQ.ToString();
		if (!this.HKIDFGEKFGC.Equals(text2))
		{
			this.HDKLHGONGGK = new Material(Shader.Find("[PG]" + text2));
			this.HKIDFGEKFGC = text2;
		}
	}

	// Token: 0x060075C0 RID: 30144 RVA: 0x0002A7B9 File Offset: 0x000289B9
	public void FCHPQOGIQBD()
	{
		this.MNBQHMJCHHJ(this.ONGNJMFLGNP, this.MIQKNMIKBCL, this.MINBHFPKNBM, 1664f, 1065f, this.HJHIHKCMKOG);
	}

	// Token: 0x060075C1 RID: 30145 RVA: 0x0002A3AA File Offset: 0x000285AA
	public void BJKQHFKGBPE()
	{
		this.BPBFIBFPJMP.enabled = false;
	}

	// Token: 0x04001959 RID: 6489
	public static string OPGNGFNJDDP = "TransitionsFX";

	// Token: 0x0400195A RID: 6490
	public Action KPGEQBGFBDN;

	// Token: 0x0400195B RID: 6491
	public Action JEKGIBCDDMB;

	// Token: 0x0400195C RID: 6492
	public Action EDGDKKGFQFG;

	// Token: 0x0400195D RID: 6493
	public Action OMHMENQQCHQ;

	// Token: 0x0400195E RID: 6494
	public Action MQJKNKDJNKH;

	// Token: 0x0400195F RID: 6495
	public Action JOEDCNPCHCH;

	// Token: 0x04001960 RID: 6496
	private static CIKGJLEIPCG NKGPQKNLCMC;

	// Token: 0x04001961 RID: 6497
	public MDLFMPEEHMP HMGGMNQMGCB;

	// Token: 0x04001962 RID: 6498
	public float MIQKNMIKBCL = 0.5f;

	// Token: 0x04001963 RID: 6499
	public float MINBHFPKNBM;

	// Token: 0x04001964 RID: 6500
	public GMNJJQQPEDB HJHIHKCMKOG = GMNJJQQPEDB.EaseOut;

	// Token: 0x04001965 RID: 6501
	public Color DONIPNIDBOH = Color.black;

	// Token: 0x04001966 RID: 6502
	public QBCJMJBQJFM FDLBCEIHLNQ;

	// Token: 0x04001967 RID: 6503
	public PNQIQMFEELP PNEFLOOMGCH;

	// Token: 0x04001968 RID: 6504
	[Range(2f, 128f)]
	public int DJKIKBQEDFD = 16;

	// Token: 0x04001969 RID: 6505
	public Texture IHLLIBOODEI;

	// Token: 0x0400196A RID: 6506
	[Range(0f, 1f)]
	public float MOLFGOFLQDF = 0.2f;

	// Token: 0x0400196B RID: 6507
	public MDLFMPEEHMP PLNFKCJIGNQ;

	// Token: 0x0400196C RID: 6508
	public float FCPOGFMNGNB = 0.5f;

	// Token: 0x0400196D RID: 6509
	public float GEHLJMEMQJG;

	// Token: 0x0400196E RID: 6510
	public GMNJJQQPEDB MCKPKEBELMF = GMNJJQQPEDB.EaseOut;

	// Token: 0x0400196F RID: 6511
	public Color QBHDIBNMDJG = Color.black;

	// Token: 0x04001970 RID: 6512
	public QBCJMJBQJFM FPBLJIHGBFO;

	// Token: 0x04001971 RID: 6513
	public PNQIQMFEELP EPICDFDNPBF;

	// Token: 0x04001972 RID: 6514
	[Range(2f, 128f)]
	public int QCGQKLNLJEG = 16;

	// Token: 0x04001973 RID: 6515
	public Texture CHNKKQJFBCB;

	// Token: 0x04001974 RID: 6516
	[Range(0f, 1f)]
	public float LFENIDNKDPD = 0.2f;

	// Token: 0x04001975 RID: 6517
	public bool QHHBQKHNKIK = true;

	// Token: 0x04001976 RID: 6518
	public bool EDIENPQKDNL = true;

	// Token: 0x04001977 RID: 6519
	private Coroutine QBNIMMOHKFQ;

	// Token: 0x04001978 RID: 6520
	private float IEEDKKNGBKO;

	// Token: 0x04001979 RID: 6521
	private Material ONGNJMFLGNP;

	// Token: 0x0400197A RID: 6522
	private Material HDKLHGONGGK;

	// Token: 0x0400197B RID: 6523
	private IPHBCBQFPOI BPBFIBFPJMP;

	// Token: 0x0400197C RID: 6524
	private int FEMQNHDCQBJ;

	// Token: 0x0400197D RID: 6525
	private int DLHEBHDNFBF;

	// Token: 0x0400197E RID: 6526
	private string LHQMQQNKFHO = string.Empty;

	// Token: 0x0400197F RID: 6527
	private string HKIDFGEKFGC = string.Empty;
}
