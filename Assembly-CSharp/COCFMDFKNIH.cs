using System;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000175 RID: 373
public class COCFMDFKNIH : MonoBehaviour
{
	// Token: 0x06002EE3 RID: 12003 RVA: 0x0013F368 File Offset: 0x0013D568
	public void PEHHOQIHMKP(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "-useJoystick" + PDIBIIKFBDH.NJLQNHJLNDC();
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		base.gameObject.name = "afteryou" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Data/pokemonmodels") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("healreplacement")) && this.HNINKEFBKJP.Contains("Interact"))
		{
			int num = this.HNINKEFBKJP.IndexOf("frz");
			int num2 = this.HNINKEFBKJP.IndexOf("/01_");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "move: " + this.HNINKEFBKJP.Substring(num + 57, num2 - (num + -57));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Battle)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06002EE4 RID: 12004 RVA: 0x0013F524 File Offset: 0x0013D724
	public void IJCHNEQQFGE(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBCHHNGOKGD();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("truant" + PDIBIIKFBDH.EHPJLLIEPDP());
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NDPGCGDLEEQ());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NKDOCPOOIIF();
		base.gameObject.name = "#,##0" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("+") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Hidden/Post FX/FXAA")) && this.HNINKEFBKJP.Contains("M"))
		{
			int num = this.HNINKEFBKJP.IndexOf("_HitPointTexture");
			int num2 = this.HNINKEFBKJP.IndexOf("_ScreenSize");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "Icon_Pokemon_Alive" + this.HNINKEFBKJP.Substring(num + 113, num2 - (num + 95));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Berry)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06002EE5 RID: 12005 RVA: 0x0013F6E0 File Offset: 0x0013D8E0
	public void EEOOPJNPMPJ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.FQOOHOOPFOH();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "Could not find a shake preset with the index: " + PDIBIIKFBDH.DFNBFIFFQMB();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QKMHPDJNJHE();
		base.gameObject.name = "0" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Tangling Hair") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("'s health is sapped by Leech Seed!\r\n")) && this.HNINKEFBKJP.Contains("/"))
		{
			int num = this.HNINKEFBKJP.IndexOf("[/sup]");
			int num2 = this.HNINKEFBKJP.IndexOf("Clear Body");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "Textures/Noise3" + this.HNINKEFBKJP.Substring(num + -72, num2 - (num + 56));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.KJLJHGEECPK() == ItemCategory.Battle)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002EE6 RID: 12006 RVA: 0x0013F89C File Offset: 0x0013DA9C
	public void KIBBEKODBBQ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "Immunity" + PDIBIIKFBDH.EQCJBDOQDBB();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		base.gameObject.name = "/" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Contrary") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("2")) && this.HNINKEFBKJP.Contains("[PG]"))
		{
			int num = this.HNINKEFBKJP.IndexOf("BuffIcon_Teleport");
			int num2 = this.HNINKEFBKJP.IndexOf("/01_");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "Goto" + this.HNINKEFBKJP.Substring(num + -32, num2 - (num + 74));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LEQLIKKPHHI().ToString());
	}

	// Token: 0x06002EE7 RID: 12007 RVA: 0x0013FA58 File Offset: 0x0013DC58
	private void DMLGQQILHQO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "_ClipRange2" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "The Pokémon changes the weather to nullify Fire-type attacks.";
			text = text + "0" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("normal", string.Empty) + "Rainbow Badge";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.MFONIPHOFGF(text);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06002EE8 RID: 12008 RVA: 0x0013FAD0 File Offset: 0x0013DCD0
	private void MFECCENINQJ()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, false, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EE9 RID: 12009 RVA: 0x0013FB54 File Offset: 0x0013DD54
	private void CIODIICODLO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "/" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "[00EE07]";
			text = text + "Expected to have 'target' set to a valid transform" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Add to Friends", string.Empty) + "'s [ffff00]";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.QOLKOBPCJBQ(text);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x0013FBCC File Offset: 0x0013DDCC
	private void PQEFNPPCKOH()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Berry)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 0, true, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x0013FC50 File Offset: 0x0013DE50
	private void JQFIDNCKHMH(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "ability: " + this.CGGNFLKJOHF.PIDLOFMIEFQ + "foresight";
			text = text + "craftyshield" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("/", string.Empty) + "Score: ";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06002EEC RID: 12012 RVA: 0x0013FCC8 File Offset: 0x0013DEC8
	public void IBJNQFPIMMC(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.FQOOHOOPFOH();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("Its disguise served it as a decoy!\r\n" + PDIBIIKFBDH.EHPJLLIEPDP());
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		base.gameObject.name = "[ffff00]Wide Guard[-] protected " + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains(" Pokédollars.") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("sandstorm")) && this.HNINKEFBKJP.Contains("\r\nHP"))
		{
			int num = this.HNINKEFBKJP.IndexOf("special");
			int num2 = this.HNINKEFBKJP.IndexOf("normal");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "Run_White" + this.HNINKEFBKJP.Substring(num + 67, num2 - (num + 33));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.General)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LEQLIKKPHHI().ToString());
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x0013FE84 File Offset: 0x0013E084
	private void CPFPLCDFCCQ()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, false, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x0013FF08 File Offset: 0x0013E108
	public void MOPCGGEMCKK(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("_MainTex" + PDIBIIKFBDH.DFNBFIFFQMB());
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		base.gameObject.name = "steel" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name;
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("When used inside of a cave or certain buildings, you will be transported to the last entrance you used.\n\n[2ecc71]Left Click to use this.[-]") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("minus")) && this.HNINKEFBKJP.Contains(" has their Player Information set to private."))
		{
			int num = this.HNINKEFBKJP.IndexOf("[-]");
			int num2 = this.HNINKEFBKJP.IndexOf("Stop");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Snow Warning" + this.HNINKEFBKJP.Substring(num + 60, num2 - (num + 119)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Unknown)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x001400C4 File Offset: 0x0013E2C4
	private void IEEDONJFQJK(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "2" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "Soundproof";
			text = text + "FOG_SUN_SHADOWS_ON" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace(" ", string.Empty) + "Localization";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.QOLKOBPCJBQ(text);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x0014013C File Offset: 0x0013E33C
	private void FDDJMGKIFHD()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Medicine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, false, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x001401C0 File Offset: 0x0013E3C0
	private void EMJNKCLHLIP(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "Blank" + this.CGGNFLKJOHF.PIDLOFMIEFQ + " (ID:";
			text = text + " thanks to its [ffff00]Safety Goggles[-]!\r\n" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("'s ", string.Empty) + "_DetailOffsetY";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x00140238 File Offset: 0x0013E438
	private void OFLNDJGLONN()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == (ItemCategory)8)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 0, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x001402BC File Offset: 0x0013E4BC
	private void MPQCMPELLFC()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Machine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x00140340 File Offset: 0x0013E540
	private void KFHBPOIMMND()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Battle)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, false, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x001403C4 File Offset: 0x0013E5C4
	private void ONNKBKELKNF(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "l" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "inky";
			text = text + "slushrush" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("!\r\n", string.Empty) + "Guild Creation";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x0014043C File Offset: 0x0013E63C
	private void POENFFOGPPP(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "0" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "http://";
			text = text + "F2" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("???", string.Empty) + "HidePanel";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.QOLKOBPCJBQ(null);
		}
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x001404B4 File Offset: 0x0013E6B4
	private void IGKEFODHEGE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "#,##0" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "Assets/AssetBundles/Pokes";
			text = text + "aftermath" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("-", string.Empty) + "_FogPointLightColor4";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x0014052C File Offset: 0x0013E72C
	public void GLFKLCGKJEI(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.FQOOHOOPFOH();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("CombinersArgsAlphaOp1" + PDIBIIKFBDH.IFFFLJINPPQ);
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		base.gameObject.name = "CombinersArgsAlphaSrc2" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("whirlpool") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Horizontal")) && this.HNINKEFBKJP.Contains("#,##0"))
		{
			int num = this.HNINKEFBKJP.IndexOf("filter");
			int num2 = this.HNINKEFBKJP.IndexOf("\\n");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "other" + this.HNINKEFBKJP.Substring(num + -82, num2 - (num + -50)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LEQLIKKPHHI().ToString());
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x001406E8 File Offset: 0x0013E8E8
	private void LHLLPPOQQIO()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Berry)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 1, true, 0, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x0014076C File Offset: 0x0013E96C
	private void OnClick()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 1, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x001407F0 File Offset: 0x0013E9F0
	private void PNHCDLKIIEI(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = " hour" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "[-] threw an ";
			text = text + "System" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("The Pokémon, sensing danger, switches out when its HP becomes half or less.", string.Empty) + "[7fff49]";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x00140868 File Offset: 0x0013EA68
	private void PELLNMMQIII(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "OnScroll" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "-fail";
			text = text + "map:" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("roleplay", string.Empty) + "pickup";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x001408E0 File Offset: 0x0013EAE0
	public void OEJDMOMEKGC(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "Sniper" + PDIBIIKFBDH.EHPJLLIEPDP();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name;
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LGOODGEDFQG();
		base.gameObject.name = "ability: " + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains(" is already asleep!\r\n") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Start")) && this.HNINKEFBKJP.Contains("["))
		{
			int num = this.HNINKEFBKJP.IndexOf("[WAIT]");
			int num2 = this.HNINKEFBKJP.IndexOf("Moon Ball");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "Surf" + this.HNINKEFBKJP.Substring(num + 127, num2 - (num + 5));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.KJLJHGEECPK() == ItemCategory.Unknown)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x00140A9C File Offset: 0x0013EC9C
	private void IGQIDQJMELD(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "comatose" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "MSGBOX - Shop";
			text = text + "Pokebox Button(Clone)" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("#,##0", string.Empty) + "[00FF00]You received ";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002F00 RID: 12032 RVA: 0x00140B14 File Offset: 0x0013ED14
	public void QNJHMCKNJIK(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "/" + PDIBIIKFBDH.IFFFLJINPPQ;
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NKDOCPOOIIF();
		base.gameObject.name = ")" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name;
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Moxie") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("F10")) && this.HNINKEFBKJP.Contains("Kick"))
		{
			int num = this.HNINKEFBKJP.IndexOf("00000000");
			int num2 = this.HNINKEFBKJP.IndexOf("_ColorMul");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "PM: " + this.HNINKEFBKJP.Substring(num + 40, num2 - (num + 85)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Hold)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LEQLIKKPHHI().ToString());
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x00140CD0 File Offset: 0x0013EED0
	private void DINJLFDBFJL(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "Max: " + this.CGGNFLKJOHF.PIDLOFMIEFQ + "HideEmote";
			text = text + "blank" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("_Speed", string.Empty) + "[00DD00]Equipped";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x00140D48 File Offset: 0x0013EF48
	private void GGCOLIGCMNB()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Hold)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, true, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x00140DCC File Offset: 0x0013EFCC
	private void IPEFEBPPLBM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "[-]!\r\n" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "V";
			text = text + "wish" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("'s Wonder Guard evades the attack!\r\n", string.Empty) + "#,##0";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x00140E44 File Offset: 0x0013F044
	private void JLQKECLHOJN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = " was hurt by poison!\r\n" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "#";
			text = text + "Super Charged" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("b", string.Empty) + "desolateland";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06002F05 RID: 12037 RVA: 0x00140EBC File Offset: 0x0013F0BC
	private void HKLIDELHEJB()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.General)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, true, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F06 RID: 12038 RVA: 0x00140F40 File Offset: 0x0013F140
	private void KOJDIBMFDFL()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Unknown)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, false, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x00140FC4 File Offset: 0x0013F1C4
	private void GNIHMKDCMKK()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Machine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 1, true, 0, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x00141048 File Offset: 0x0013F248
	private void HPKHMHMLQFM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "?" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "OnPress";
			text = text + "The Pokémon cowardly switches out when its HP becomes half or less." + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("MSGBOX - Confirm EVs", string.Empty) + "1";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.MFONIPHOFGF(text);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x001410C0 File Offset: 0x0013F2C0
	public void PIDHMOPPOJK(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		this.ECJBGGNPOOQ.LKPOBCBOFIC("Assets/AssetBundles/MapAssets2/Models/Materials/com_c02_mado0.mat" + PDIBIIKFBDH.EQCJBDOQDBB());
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PNKGBNPIILC();
		base.gameObject.name = "Assets/AssetBundles/Pokes" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("\n") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("perish0")) && this.HNINKEFBKJP.Contains("It was alerted to "))
		{
			int num = this.HNINKEFBKJP.IndexOf("raindish");
			int num2 = this.HNINKEFBKJP.IndexOf("new npc");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "[-]!\r\n" + this.HNINKEFBKJP.Substring(num + -89, num2 - (num + -27));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.KJLJHGEECPK() == ItemCategory.Medicine)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x0014127C File Offset: 0x0013F47C
	public void PJJFGOKNQMJ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "battler" + PDIBIIKFBDH.NJLQNHJLNDC();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		base.gameObject.name = "Take 001" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains(" became trapped in the fiery vortex!\r\n") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("DEPTH_OF_FIELD_COC_VIEW")) && this.HNINKEFBKJP.Contains("!\r\n"))
		{
			int num = this.HNINKEFBKJP.IndexOf("stealthrock");
			int num2 = this.HNINKEFBKJP.IndexOf("adjacentAlly");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "You used '" + this.HNINKEFBKJP.Substring(num + 7, num2 - (num + 116));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Battle)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x00141438 File Offset: 0x0013F638
	private void INOQDGMGINK()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, false, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x001414BC File Offset: 0x0013F6BC
	public void IJOCQICOCNB(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		this.ECJBGGNPOOQ.LKPOBCBOFIC("_Bottom" + PDIBIIKFBDH.IFFFLJINPPQ);
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NDPGCGDLEEQ());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		base.gameObject.name = "confusion" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NDPGCGDLEEQ();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Upgrade Guild") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("_Male")) && this.HNINKEFBKJP.Contains("Blank"))
		{
			int num = this.HNINKEFBKJP.IndexOf("12:");
			int num2 = this.HNINKEFBKJP.IndexOf("[-]!\r\n");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Battle Update: " + this.HNINKEFBKJP.Substring(num + 113, num2 - (num + 94)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.General)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).LEQLIKKPHHI().ToString());
	}

	// Token: 0x06002F0D RID: 12045 RVA: 0x00141678 File Offset: 0x0013F878
	private void JKCPMBPBDCH()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Unknown)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, true, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F0E RID: 12046 RVA: 0x001416FC File Offset: 0x0013F8FC
	private void DNLLCMHCHMJ()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Unknown)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F0F RID: 12047 RVA: 0x00141780 File Offset: 0x0013F980
	public void LQFDMHPELCJ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "[00DD00]Equipped" + PDIBIIKFBDH.EQCJBDOQDBB();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		base.gameObject.name = " seems to have a null sprite!" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JQBDPHILQJO();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Guild") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("_Detail")) && this.HNINKEFBKJP.Contains("Pointed stones float in the air around "))
		{
			int num = this.HNINKEFBKJP.IndexOf("settag(");
			int num2 = this.HNINKEFBKJP.IndexOf("Socket not connected anymore");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "powerofalchemy" + this.HNINKEFBKJP.Substring(num + 78, num2 - (num + -118));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Machine)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06002F10 RID: 12048 RVA: 0x0014193C File Offset: 0x0013FB3C
	private void IFGPPIQKOPM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "[33CCFF]" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "[-]\n";
			text = text + "QTY: " + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("x", string.Empty) + "\n\n";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.MFONIPHOFGF(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06002F11 RID: 12049 RVA: 0x001419B4 File Offset: 0x0013FBB4
	private void MHBNNCGMNHH()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.General)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 1, false, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F12 RID: 12050 RVA: 0x00141A38 File Offset: 0x0013FC38
	private void OLOLDFNCBJN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "4" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "#,##0";
			text = text + "r" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Avoids sound-based moves.", string.Empty) + " is hurt by its [ffff00]";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.PLMQDDPDOOL(text);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06002F13 RID: 12051 RVA: 0x00141AB0 File Offset: 0x0013FCB0
	private void NBQGBEJCHKM()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Berry)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 0, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F14 RID: 12052 RVA: 0x00141B34 File Offset: 0x0013FD34
	private void KJCPFNLBHJB(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "Dazzling" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "Assets/AssetBundles/Pokes";
			text = text + "Player/Hair" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("[-]!\r\n", string.Empty) + " would like to Battle with you. Do you wish to Battle?";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.QOLKOBPCJBQ(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002F15 RID: 12053 RVA: 0x00141BAC File Offset: 0x0013FDAC
	private void QOEQHBIDMIP()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Medicine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 1, true, 0, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F16 RID: 12054 RVA: 0x00141C30 File Offset: 0x0013FE30
	public void DOEGKLDPQKB(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBCHHNGOKGD();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "-" + PDIBIIKFBDH.IFFFLJINPPQ;
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name);
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		base.gameObject.name = ")" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("item") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("electricterrain")) && this.HNINKEFBKJP.Contains("MusicManager"))
		{
			int num = this.HNINKEFBKJP.IndexOf(" is unaffected!\r\n");
			int num2 = this.HNINKEFBKJP.IndexOf("Sound");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Create Guild" + this.HNINKEFBKJP.Substring(num + -94, num2 - (num + -11)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Medicine)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x00141DEC File Offset: 0x0013FFEC
	private void NMHKDFCQJNB()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.General)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 0, true, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F18 RID: 12056 RVA: 0x00141E70 File Offset: 0x00140070
	private void MGLBOMIDNML(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "   " + this.CGGNFLKJOHF.PIDLOFMIEFQ + "0";
			text = text + "Dream Ball" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Enabled", string.Empty) + "Daily Quests";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JEDHBMEEGEB(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06002F19 RID: 12057 RVA: 0x00141EE8 File Offset: 0x001400E8
	public void PCFNFCMCMII(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "!\r\n" + PDIBIIKFBDH.DFNBFIFFQMB();
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name);
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).OELFFKHICPQ();
		base.gameObject.name = "System" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("inky") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("aegislash")) && this.HNINKEFBKJP.Contains(" [M]"))
		{
			int num = this.HNINKEFBKJP.IndexOf("#,##0");
			int num2 = this.HNINKEFBKJP.IndexOf("[ff6666]");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Map" + this.HNINKEFBKJP.Substring(num + -117, num2 - (num + -8)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Battle)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002F1A RID: 12058 RVA: 0x001420A4 File Offset: 0x001402A4
	private void KGQIPMJOQGG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "_Vignette_Opacity" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "-item";
			text = text + "[FF0000]-" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("4", string.Empty) + "1";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.PLMQDDPDOOL(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06002F1B RID: 12059 RVA: 0x0014211C File Offset: 0x0014031C
	public void FDDENOHPGQF(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.FQOOHOOPFOH();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("Turns the ground into Psychic Terrain when the Pokémon enters a battle." + PDIBIIKFBDH.EQCJBDOQDBB());
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NDPGCGDLEEQ());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).JLECCEINFBO();
		base.gameObject.name = " was frozen solid!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Hard armor protects the Pokémon from critical hits.") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("pdata")) && this.HNINKEFBKJP.Contains("Tangled Feet"))
		{
			int num = this.HNINKEFBKJP.IndexOf("Oozed liquid has strong stench, which damages attackers using any draining move.");
			int num2 = this.HNINKEFBKJP.IndexOf("[PD]");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + "wonderguard" + this.HNINKEFBKJP.Substring(num + 124, num2 - (num + -24));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Battle)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06002F1C RID: 12060 RVA: 0x001422D8 File Offset: 0x001404D8
	private void KOIKMFGPHPB(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "powder" + this.CGGNFLKJOHF.PIDLOFMIEFQ + ",";
			text = text + "Changes the Pokémon's type to match the Plate or Z-Crystal it holds." + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("a", string.Empty) + "Teleport Cooldown";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002F1D RID: 12061 RVA: 0x00142350 File Offset: 0x00140550
	private void MFPMIFEKEME()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, false, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F1E RID: 12062 RVA: 0x001423D4 File Offset: 0x001405D4
	public void BQLIIQIIMDH(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "x" + PDIBIIKFBDH.IFFFLJINPPQ;
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name;
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Description;
		base.gameObject.name = "inven " + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).Name;
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("HM") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("TM")) && this.HNINKEFBKJP.Contains("[u][33CCFF]"))
		{
			int num = this.HNINKEFBKJP.IndexOf("[u][33CCFF]");
			int num2 = this.HNINKEFBKJP.IndexOf("[-][/u]");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.PIDLOFMIEFQ = cggnflkjohf.PIDLOFMIEFQ + " - " + this.HNINKEFBKJP.Substring(num + 11, num2 - (num + 11));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.CLEMKHNIPEI == ItemCategory.Pokeball)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x00142590 File Offset: 0x00140790
	private void CGNKLQOQLHJ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "'s burn was healed.\r\n" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "whitesmoke";
			text = text + "[i]" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("System", string.Empty) + "_TempRT";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x00142608 File Offset: 0x00140808
	private void KIODMEIKPIP(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "_MainTex" + this.CGGNFLKJOHF.PIDLOFMIEFQ + ",";
			text = text + "Enabled" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("_Bloom_Settings", string.Empty) + "Follow/";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JEDHBMEEGEB(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06002F21 RID: 12065 RVA: 0x00142680 File Offset: 0x00140880
	private void CFOPEJIQPPF()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Battle)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 0, false, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F22 RID: 12066 RVA: 0x00142704 File Offset: 0x00140904
	private void LBQBHIPHOPC()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Battle)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 0, false, 0, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x00142788 File Offset: 0x00140988
	private void FJECHOHDBOG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "speedboost" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "The Pokémon moves after all other Pokémon do.";
			text = text + "[msg]" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace(" / ", string.Empty) + "quickclaw";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x00142800 File Offset: 0x00140A00
	private void NOMONLLNICG()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Medicine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.CLIEFPPGCHK(this.DBPKNCDGGEP, 1, true, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x00142884 File Offset: 0x00140A84
	private void EMDKJEPDIFO()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.QLGFDFKBHMN() == ItemCategory.Hold)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.GLJQEPIEEFE(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, false, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x00142908 File Offset: 0x00140B08
	private void OMIKGHLDCHL(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "[/itm]" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "[-][/u]\n";
			text = text + "_Dissolve" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Chat Box - PMChat", string.Empty) + "[";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x00142980 File Offset: 0x00140B80
	public void FILJGHLFMMB(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.LKPOBCBOFIC("rock" + PDIBIIKFBDH.EHPJLLIEPDP());
		this.CGGNFLKJOHF.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD());
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).NKDOCPOOIIF();
		base.gameObject.name = "Repel" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("magician") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Liquid Ooze")) && this.HNINKEFBKJP.Contains("sketch"))
		{
			int num = this.HNINKEFBKJP.IndexOf("2");
			int num2 = this.HNINKEFBKJP.IndexOf("innerfocus");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "New Password is to short" + this.HNINKEFBKJP.Substring(num + 6, num2 - (num + -109)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = true;
			this.MCCPGFMCFBJ = true;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Medicine)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).ItemImage.ToString());
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x00142B3C File Offset: 0x00140D3C
	private void EKLNQHLPKLN()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Pokeball)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 0, false, 0, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x00142BC0 File Offset: 0x00140DC0
	private void CLKFLBHGIFE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "-enditem" + this.CGGNFLKJOHF.PIDLOFMIEFQ + ". Remember you need to add it to the ConstantShakePresets list first.";
			text = text + "Powers up moves that make direct contact." + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("_DepthScale", string.Empty) + " hid underwater!\r\n";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.MFONIPHOFGF(text);
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x00142C38 File Offset: 0x00140E38
	private void LCDOHIPLEHB()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Berry)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 1)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 1, true, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F2B RID: 12075 RVA: 0x00142CBC File Offset: 0x00140EBC
	private void DHPFLPDNHFK()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == (ItemCategory)8)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.BDHDICQKQPN(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NGJDHBBPCOK(this.DBPKNCDGGEP, 1, true, 1, false);
			}
		}
		else
		{
			this.GMQPDFJJDPO.NIFKFLLMHCM(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x00142D40 File Offset: 0x00140F40
	public void JMDOHOLHGBN(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, OGJJKKQPNMK BKCCLIFIQLH, bool QNDFDFLQIKI = true)
	{
		this.BKHELHQFOBF = PDIBIIKFBDH;
		this.GMQPDFJJDPO = BKCCLIFIQLH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "lightscreen" + PDIBIIKFBDH.EHPJLLIEPDP();
		this.CGGNFLKJOHF.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).FLFQBGJQBBD();
		this.HNINKEFBKJP = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).PGEGEFKDKBB();
		base.gameObject.name = "00000000" + KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).DFNQHDEDDKE();
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("hustle") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("][/itm]")) && this.HNINKEFBKJP.Contains("Guild"))
		{
			int num = this.HNINKEFBKJP.IndexOf("Left");
			int num2 = this.HNINKEFBKJP.IndexOf("Vital Spirit");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Dig Cooldown" + this.HNINKEFBKJP.Substring(num + -38, num2 - (num + 114)));
			}
		}
		if (!QNDFDFLQIKI)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		else
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = false;
		}
		if (!BKCCLIFIQLH.GHQOEDBJDNI && PDIBIIKFBDH.QLGFDFKBHMN() == ItemCategory.Hold)
		{
			base.GetComponent<CFDMNELIJLO>().GGBPLMICFHN = false;
			this.MCCPGFMCFBJ = true;
		}
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06002F2D RID: 12077 RVA: 0x00142EFC File Offset: 0x001410FC
	private void MQQHIHHPHNN()
	{
		if (!this.MCCPGFMCFBJ)
		{
			return;
		}
		if (this.BKHELHQFOBF.KJLJHGEECPK() == ItemCategory.Machine)
		{
			if (!this.GMQPDFJJDPO.GHQOEDBJDNI)
			{
				return;
			}
			if (this.GMQPDFJJDPO.EQFDHBJKGCQ.Length > 0)
			{
				this.GMQPDFJJDPO.CFGMNHFIPBB(this.DBPKNCDGGEP);
			}
			else
			{
				this.GMQPDFJJDPO.NIFFMBHOLMD(this.DBPKNCDGGEP, 0, false, 1, true);
			}
		}
		else
		{
			this.GMQPDFJJDPO.DGQNLBDBIGG(this.DBPKNCDGGEP, this.BKHELHQFOBF);
		}
	}

	// Token: 0x04000A26 RID: 2598
	public BKKHLBCLPJM CGGNFLKJOHF;

	// Token: 0x04000A27 RID: 2599
	public BKKHLBCLPJM ECJBGGNPOOQ;

	// Token: 0x04000A28 RID: 2600
	public int DBPKNCDGGEP;

	// Token: 0x04000A29 RID: 2601
	public JLMPBLMOICG DGCGPPOIKOI;

	// Token: 0x04000A2A RID: 2602
	private string HNINKEFBKJP = string.Empty;

	// Token: 0x04000A2B RID: 2603
	private OGJJKKQPNMK GMQPDFJJDPO;

	// Token: 0x04000A2C RID: 2604
	private KGQECFKLKOP.IJHPPMDDKIE BKHELHQFOBF;

	// Token: 0x04000A2D RID: 2605
	private bool MCCPGFMCFBJ;
}
