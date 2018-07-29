using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
[AddComponentMenu("NGUI/Interaction/Button Color")]
[ExecuteInEditMode]
public class PBJKDKBOLHO : GJGCJNOICOM
{
	// Token: 0x06000A4E RID: 2638 RVA: 0x000640E4 File Offset: 0x000622E4
	protected virtual void OnEnable()
	{
		if (this.KBNGENPQQFE)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
		if (EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject)
			{
				this.OnPress(true);
			}
			else if (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject)
			{
				this.LJMOLEKDCLP(true);
			}
		}
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00005A14 File Offset: 0x00003C14
	private void KPKQNOCFGIB()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJQQFQLLQO();
		}
		if (!this.GGBPLMICFHN)
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		}
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00064150 File Offset: 0x00062350
	protected virtual void DGDJOKNGOMG()
	{
		if (this.KBNGENPQQFE && this.NDPCGHQDHMO != PBJKDKBOLHO.OKKDIIQGHDD.Normal)
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			if (this.DMCGHNCHOHQ != null)
			{
				NCNDQDBPNQN component = this.DMCGHNCHOHQ.GetComponent<NCNDQDBPNQN>();
				if (component != null)
				{
					component.NCBFKNGMKPB(this.FJNHLJFLILF);
					component.enabled = false;
				}
			}
		}
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00005A34 File Offset: 0x00003C34
	protected virtual void JHNIPQLONMK()
	{
		if (this.GGBPLMICFHN)
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
		}
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x000641AC File Offset: 0x000623AC
	protected virtual void INFMNHJJDCD()
	{
		if (this.KBNGENPQQFE)
		{
			this.BIINILQKOQM(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
		if (EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (EMENMKHBPQE.JHEDGGMDIEE.KCICOJFDCPQ == base.gameObject)
			{
				this.OnPress(false);
			}
			else if (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject)
			{
				this.BIINILQKOQM(false);
			}
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00005B24 File Offset: 0x00003D24
	// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00005A62 File Offset: 0x00003C62
	public PBJKDKBOLHO.OKKDIIQGHDD HHJEFGFNBPG
	{
		get
		{
			return this.NDPCGHQDHMO;
		}
		set
		{
			this.NHCNOIOCFCO(value, false);
		}
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00005A6C File Offset: 0x00003C6C
	protected virtual void DMOJGIOIJEJ()
	{
		if (this.EFBQLPLOMQB())
		{
			if (!this.KBNGENPQQFE)
			{
				this.MLENNDFLBFC();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
		}
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00005A9A File Offset: 0x00003C9A
	private void Start()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJOQKCCMDH();
		}
		if (!this.GGBPLMICFHN)
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		}
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00005A62 File Offset: 0x00003C62
	public void JNJGIMPQBOJ(PBJKDKBOLHO.OKKDIIQGHDD BGBMIEJJQKC)
	{
		this.NHCNOIOCFCO(BGBMIEJJQKC, false);
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00005ABA File Offset: 0x00003CBA
	public virtual bool EFBQLPLOMQB()
	{
		return base.enabled;
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00064218 File Offset: 0x00062418
	protected virtual void MLENNDFLBFC()
	{
		this.KBNGENPQQFE = false;
		if (this.DMCGHNCHOHQ == null && !Application.isPlaying)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
		if (this.DMCGHNCHOHQ != null)
		{
			this.DLQMOLJPEMO = this.DMCGHNCHOHQ.GetComponent<ENFMCDNLEQQ>();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.FJNHLJFLILF = this.DLQMOLJPEMO.CEGFBBHMKOE;
			this.PBFMHPICDIN = this.FJNHLJFLILF;
		}
		else if (this.DMCGHNCHOHQ != null)
		{
			Renderer component = this.DMCGHNCHOHQ.GetComponent<Renderer>();
			if (component != null)
			{
				this.FJNHLJFLILF = ((!Application.isPlaying) ? component.sharedMaterial.color : component.material.color);
				this.PBFMHPICDIN = this.FJNHLJFLILF;
			}
			else
			{
				Light component2 = this.DMCGHNCHOHQ.GetComponent<Light>();
				if (component2 != null)
				{
					this.FJNHLJFLILF = component2.color;
					this.PBFMHPICDIN = this.FJNHLJFLILF;
				}
				else
				{
					this.DMCGHNCHOHQ = null;
					this.KBNGENPQQFE = false;
				}
			}
		}
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00005AC2 File Offset: 0x00003CC2
	protected virtual void KJDNCMCPHNM()
	{
		if (this.IQKKIGIKGDN())
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00005AF0 File Offset: 0x00003CF0
	protected virtual void BIINILQKOQM(bool IFFGDNBQHLO)
	{
		if (this.GGBPLMICFHN)
		{
			if (!this.KBNGENPQQFE)
			{
				this.MLENNDFLBFC();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO((!IFFGDNBQHLO) ? PBJKDKBOLHO.OKKDIIQGHDD.Normal : PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
		}
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00005ABA File Offset: 0x00003CBA
	public virtual bool IQKKIGIKGDN()
	{
		return base.enabled;
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00005B24 File Offset: 0x00003D24
	public PBJKDKBOLHO.OKKDIIQGHDD PEBQLHQJFGG()
	{
		return this.NDPCGHQDHMO;
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00005C31 File Offset: 0x00003E31
	// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00064334 File Offset: 0x00062534
	public Color IDEOONDHNEL
	{
		get
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			return this.FJNHLJFLILF;
		}
		set
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			this.FJNHLJFLILF = value;
			PBJKDKBOLHO.OKKDIIQGHDD ndpcghqdhmo = this.NDPCGHQDHMO;
			this.NDPCGHQDHMO = PBJKDKBOLHO.OKKDIIQGHDD.Disabled;
			this.NHCNOIOCFCO(ndpcghqdhmo, false);
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00005ABA File Offset: 0x00003CBA
	// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00005B2C File Offset: 0x00003D2C
	public virtual bool GGBPLMICFHN
	{
		get
		{
			return base.enabled;
		}
		set
		{
			base.enabled = value;
		}
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00005A62 File Offset: 0x00003C62
	public void OIFMKKPHMLM(PBJKDKBOLHO.OKKDIIQGHDD BGBMIEJJQKC)
	{
		this.NHCNOIOCFCO(BGBMIEJJQKC, false);
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00005B35 File Offset: 0x00003D35
	protected virtual void LQBGEEBFNBI()
	{
		if (this.GGBPLMICFHN)
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJQQFQLLQO();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00005B63 File Offset: 0x00003D63
	public virtual void NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD HHJEFGFNBPG, bool NMEJGDJEJKP)
	{
		if (!this.KBNGENPQQFE)
		{
			this.KBNGENPQQFE = true;
			this.FHJOQKCCMDH();
		}
		if (this.NDPCGHQDHMO != HHJEFGFNBPG)
		{
			this.NDPCGHQDHMO = HHJEFGFNBPG;
			this.DKMHBQNHQGD(NMEJGDJEJKP);
		}
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x0006436C File Offset: 0x0006256C
	protected virtual void FHJQQFQLLQO()
	{
		this.KBNGENPQQFE = false;
		if (this.DMCGHNCHOHQ == null && !Application.isPlaying)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
		if (this.DMCGHNCHOHQ != null)
		{
			this.DLQMOLJPEMO = this.DMCGHNCHOHQ.GetComponent<ENFMCDNLEQQ>();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.FJNHLJFLILF = this.DLQMOLJPEMO.CEGFBBHMKOE;
			this.PBFMHPICDIN = this.FJNHLJFLILF;
		}
		else if (this.DMCGHNCHOHQ != null)
		{
			Renderer component = this.DMCGHNCHOHQ.GetComponent<Renderer>();
			if (component != null)
			{
				this.FJNHLJFLILF = ((!Application.isPlaying) ? component.sharedMaterial.color : component.material.color);
				this.PBFMHPICDIN = this.FJNHLJFLILF;
			}
			else
			{
				Light component2 = this.DMCGHNCHOHQ.GetComponent<Light>();
				if (component2 != null)
				{
					this.FJNHLJFLILF = component2.color;
					this.PBFMHPICDIN = this.FJNHLJFLILF;
				}
				else
				{
					this.DMCGHNCHOHQ = null;
					this.KBNGENPQQFE = true;
				}
			}
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00064488 File Offset: 0x00062688
	public void DKMHBQNHQGD(bool NMEJGDJEJKP)
	{
		if (this.DMCGHNCHOHQ != null)
		{
			NCNDQDBPNQN ncndqdbpnqn;
			switch (this.NDPCGHQDHMO)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				ncndqdbpnqn = NCNDQDBPNQN.FJCEGFKJLCL(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BBIJQCIJQNM);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				ncndqdbpnqn = NCNDQDBPNQN.FJCEGFKJLCL(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.KCICOJFDCPQ);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				ncndqdbpnqn = NCNDQDBPNQN.FJCEGFKJLCL(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BKOENCLICDI);
				break;
			default:
				ncndqdbpnqn = NCNDQDBPNQN.FJCEGFKJLCL(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.FJNHLJFLILF);
				break;
			}
			if (NMEJGDJEJKP && ncndqdbpnqn != null)
			{
				ncndqdbpnqn.BGBMIEJJQKC = ncndqdbpnqn.BKMCCCGOGOM;
				ncndqdbpnqn.enabled = false;
			}
		}
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00005B91 File Offset: 0x00003D91
	public void DNCKOMJKDQG()
	{
		this.IDEOONDHNEL = this.PBFMHPICDIN;
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00005B9F File Offset: 0x00003D9F
	protected virtual void PHEQFQKIQDQ()
	{
		if (this.EFBQLPLOMQB())
		{
			if (!this.KBNGENPQQFE)
			{
				this.MLENNDFLBFC();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
			}
		}
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00005BCD File Offset: 0x00003DCD
	protected virtual void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (this.GGBPLMICFHN)
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO((!IFFGDNBQHLO) ? PBJKDKBOLHO.OKKDIIQGHDD.Normal : PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
		}
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00005A62 File Offset: 0x00003C62
	public void IJFIIPQPNMG(PBJKDKBOLHO.OKKDIIQGHDD BGBMIEJJQKC)
	{
		this.NHCNOIOCFCO(BGBMIEJJQKC, false);
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00064548 File Offset: 0x00062748
	protected virtual void EMLGBJOOLOF()
	{
		if (this.KBNGENPQQFE && this.NDPCGHQDHMO != PBJKDKBOLHO.OKKDIIQGHDD.Normal)
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			if (this.DMCGHNCHOHQ != null)
			{
				NCNDQDBPNQN component = this.DMCGHNCHOHQ.GetComponent<NCNDQDBPNQN>();
				if (component != null)
				{
					component.MBKMJBBDCHL(this.FJNHLJFLILF);
					component.enabled = false;
				}
			}
		}
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x000645A4 File Offset: 0x000627A4
	protected virtual void OnDisable()
	{
		if (this.KBNGENPQQFE && this.NDPCGHQDHMO != PBJKDKBOLHO.OKKDIIQGHDD.Normal)
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			if (this.DMCGHNCHOHQ != null)
			{
				NCNDQDBPNQN component = this.DMCGHNCHOHQ.GetComponent<NCNDQDBPNQN>();
				if (component != null)
				{
					component.BGBMIEJJQKC = this.FJNHLJFLILF;
					component.enabled = false;
				}
			}
		}
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00064600 File Offset: 0x00062800
	public void LBCBOHGJEIM(bool NMEJGDJEJKP)
	{
		if (this.DMCGHNCHOHQ != null)
		{
			NCNDQDBPNQN ncndqdbpnqn;
			switch (this.NDPCGHQDHMO)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				ncndqdbpnqn = NCNDQDBPNQN.EOKHEPPPQDD(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BBIJQCIJQNM);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				ncndqdbpnqn = NCNDQDBPNQN.OBCNHPELFJK(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.KCICOJFDCPQ);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				ncndqdbpnqn = NCNDQDBPNQN.EOKHEPPPQDD(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BKOENCLICDI);
				break;
			default:
				ncndqdbpnqn = NCNDQDBPNQN.FEBFHOPOJQN(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.FJNHLJFLILF);
				break;
			}
			if (NMEJGDJEJKP && ncndqdbpnqn != null)
			{
				ncndqdbpnqn.BGBMIEJJQKC = ncndqdbpnqn.BKMCCCGOGOM;
				ncndqdbpnqn.enabled = true;
			}
		}
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00064728 File Offset: 0x00062928
	protected virtual void FHJOQKCCMDH()
	{
		this.KBNGENPQQFE = true;
		if (this.DMCGHNCHOHQ == null && !Application.isPlaying)
		{
			this.DMCGHNCHOHQ = base.gameObject;
		}
		if (this.DMCGHNCHOHQ != null)
		{
			this.DLQMOLJPEMO = this.DMCGHNCHOHQ.GetComponent<ENFMCDNLEQQ>();
		}
		if (this.DLQMOLJPEMO != null)
		{
			this.FJNHLJFLILF = this.DLQMOLJPEMO.CEGFBBHMKOE;
			this.PBFMHPICDIN = this.FJNHLJFLILF;
		}
		else if (this.DMCGHNCHOHQ != null)
		{
			Renderer component = this.DMCGHNCHOHQ.GetComponent<Renderer>();
			if (component != null)
			{
				this.FJNHLJFLILF = ((!Application.isPlaying) ? component.sharedMaterial.color : component.material.color);
				this.PBFMHPICDIN = this.FJNHLJFLILF;
			}
			else
			{
				Light component2 = this.DMCGHNCHOHQ.GetComponent<Light>();
				if (component2 != null)
				{
					this.FJNHLJFLILF = component2.color;
					this.PBFMHPICDIN = this.FJNHLJFLILF;
				}
				else
				{
					this.DMCGHNCHOHQ = null;
					this.KBNGENPQQFE = false;
				}
			}
		}
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00005C01 File Offset: 0x00003E01
	private void JHQCMGKJCCI()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJQQFQLLQO();
		}
		if (!this.IQKKIGIKGDN())
		{
			this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, true);
		}
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00064844 File Offset: 0x00062A44
	public void MFGCPBBBBGM(bool NMEJGDJEJKP)
	{
		if (this.DMCGHNCHOHQ != null)
		{
			NCNDQDBPNQN ncndqdbpnqn;
			switch (this.NDPCGHQDHMO)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Normal:
				ncndqdbpnqn = NCNDQDBPNQN.FEBFHOPOJQN(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BBIJQCIJQNM);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				ncndqdbpnqn = NCNDQDBPNQN.OBCNHPELFJK(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.KCICOJFDCPQ);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				ncndqdbpnqn = NCNDQDBPNQN.EOKHEPPPQDD(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BKOENCLICDI);
				break;
			default:
				ncndqdbpnqn = NCNDQDBPNQN.IOELIBBIPGB(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.FJNHLJFLILF);
				break;
			}
			if (NMEJGDJEJKP && ncndqdbpnqn != null)
			{
				ncndqdbpnqn.NCBFKNGMKPB(ncndqdbpnqn.BKMCCCGOGOM);
				ncndqdbpnqn.enabled = false;
			}
		}
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00005C21 File Offset: 0x00003E21
	public void MNQJNEEEJPQ()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJOQKCCMDH();
		}
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00064904 File Offset: 0x00062B04
	protected virtual void OnPress(bool FJOEKDCLKIO)
	{
		if (this.GGBPLMICFHN && EMENMKHBPQE.JHEDGGMDIEE != null)
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				if (FJOEKDCLKIO)
				{
					this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, false);
				}
				else if (EMENMKHBPQE.JHEDGGMDIEE.OMQCQCBLQGJ == base.gameObject)
				{
					if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller)
					{
						this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
					}
					else if (EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Mouse && EMENMKHBPQE.QMPQFJMFQPB == base.gameObject)
					{
						this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
					}
					else
					{
						this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
					}
				}
				else
				{
					this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
				}
			}
		}
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000649B0 File Offset: 0x00062BB0
	public void CEPLHGPGIJB(bool NMEJGDJEJKP)
	{
		if (this.DMCGHNCHOHQ != null)
		{
			NCNDQDBPNQN ncndqdbpnqn;
			switch (this.NDPCGHQDHMO)
			{
			case PBJKDKBOLHO.OKKDIIQGHDD.Hover:
				ncndqdbpnqn = NCNDQDBPNQN.OBCNHPELFJK(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BBIJQCIJQNM);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Pressed:
				ncndqdbpnqn = NCNDQDBPNQN.KJJQQBDHLJE(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.KCICOJFDCPQ);
				break;
			case PBJKDKBOLHO.OKKDIIQGHDD.Disabled:
				ncndqdbpnqn = NCNDQDBPNQN.EOKHEPPPQDD(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.BKOENCLICDI);
				break;
			default:
				ncndqdbpnqn = NCNDQDBPNQN.EOKHEPPPQDD(this.DMCGHNCHOHQ, this.CPKNEQGKQPQ, this.FJNHLJFLILF);
				break;
			}
			if (NMEJGDJEJKP && ncndqdbpnqn != null)
			{
				ncndqdbpnqn.EJBFHKJNELQ(ncndqdbpnqn.BKMCCCGOGOM);
				ncndqdbpnqn.enabled = false;
			}
		}
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00005C21 File Offset: 0x00003E21
	public void CacheDefaultColor()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJOQKCCMDH();
		}
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00005C47 File Offset: 0x00003E47
	protected virtual void NMGDOKQLMEG()
	{
		if (this.GGBPLMICFHN)
		{
			if (!this.KBNGENPQQFE)
			{
				this.FHJOQKCCMDH();
			}
			if (this.DMCGHNCHOHQ != null)
			{
				this.NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, false);
			}
		}
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00005C21 File Offset: 0x00003E21
	public void CKJOLQOIMDF()
	{
		if (!this.KBNGENPQQFE)
		{
			this.FHJOQKCCMDH();
		}
	}

	// Token: 0x0400016A RID: 362
	public GameObject DMCGHNCHOHQ;

	// Token: 0x0400016B RID: 363
	public Color BBIJQCIJQNM = new Color(0.882352948f, 0.784313738f, 0.5882353f, 1f);

	// Token: 0x0400016C RID: 364
	public Color KCICOJFDCPQ = new Color(0.7176471f, 0.6392157f, 0.482352942f, 1f);

	// Token: 0x0400016D RID: 365
	public Color BKOENCLICDI = Color.grey;

	// Token: 0x0400016E RID: 366
	public float CPKNEQGKQPQ = 0.2f;

	// Token: 0x0400016F RID: 367
	[NonSerialized]
	protected Color PBFMHPICDIN;

	// Token: 0x04000170 RID: 368
	[NonSerialized]
	protected Color FJNHLJFLILF;

	// Token: 0x04000171 RID: 369
	[NonSerialized]
	protected bool KBNGENPQQFE;

	// Token: 0x04000172 RID: 370
	[NonSerialized]
	protected ENFMCDNLEQQ DLQMOLJPEMO;

	// Token: 0x04000173 RID: 371
	[NonSerialized]
	protected PBJKDKBOLHO.OKKDIIQGHDD NDPCGHQDHMO;

	// Token: 0x0200004B RID: 75
	public enum OKKDIIQGHDD
	{
		// Token: 0x04000175 RID: 373
		Normal,
		// Token: 0x04000176 RID: 374
		Hover,
		// Token: 0x04000177 RID: 375
		Pressed,
		// Token: 0x04000178 RID: 376
		Disabled
	}
}
