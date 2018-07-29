using System;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x020001D9 RID: 473
public class MDFQEBOLLJN : UIDragDropItem
{
	// Token: 0x06003D80 RID: 15744 RVA: 0x001DC30C File Offset: 0x001DA50C
	private void IGQIDQJMELD(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "\n" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "UpdateAnchors";
			text = text + "_ClipArgs0" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Chat Box", string.Empty) + "confusion";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x001DC384 File Offset: 0x001DA584
	protected virtual void KPDHHDMCJHB(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (component != null && component.gameObject.name != " cured its paralysis!\r\n" && !component.gameObject.name.Contains("You can not afford to increase your guild member limit.\nCost: ") && !component.gameObject.name.Contains("Damage adds to the amount of damage done in combat") && !component.gameObject.name.Contains("_"))
			{
				if (component.gameObject.name == "The Pokémon is protected by a layer of thick fat, which halves the damage taken from Fire- and Ice-type moves.")
				{
					if (component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP != null)
					{
						this.MEONDFKLQJQ.FBGCOKOHCQO(component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP.GBNQEKLJFCI());
					}
					INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
					return;
				}
				if (component.gameObject.name == "BuffIcon_EggSpeedIncrease")
				{
					if (this.MEONDFKLQJQ.MKBCKPPCIQO.PCIONNCGEOK())
					{
						PJCCMHCDFJQ.QOQONHOOLNE.HGBJMGKPKQP(this.MEONDFKLQJQ.MKBCKPPCIQO.HLMQODIHBIG());
					}
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
					PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					return;
				}
				this.MEONDFKLQJQ.FPLNCJJCCIF(component.PELCNBCMNFH);
				INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(true);
				base.OnDragDropRelease(HQMQBKPNDJL);
				PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
				return;
			}
			else
			{
				if (component != null)
				{
					if (component.gameObject.name == "_Jitter")
					{
						component.gameObject.GetComponent<NHPGIPEOKID>().AddItem(this.MEONDFKLQJQ.MKBCKPPCIQO.FQOOHOOPFOH());
						INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "\nNight")
					{
						component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().DDGGOHGDNLD(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
						INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(true);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "HM" || component.gameObject.name == "Illusion")
					{
						component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().AddItem(this.MEONDFKLQJQ.MKBCKPPCIQO.FQOOHOOPFOH());
						INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
						return;
					}
				}
				ONGOGFNONDC component2 = HQMQBKPNDJL.GetComponent<ONGOGFNONDC>();
				if (component2 != null)
				{
					GameObject.Find("Unable to convert ").GetComponent<QOHCEBMQKMB>().ECJPBBFIQEC(this.MEONDFKLQJQ.MKBCKPPCIQO);
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
					return;
				}
			}
		}
		INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(true);
		base.OnDragDropRelease(HQMQBKPNDJL);
		PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
	}

	// Token: 0x06003D82 RID: 15746 RVA: 0x001DC6EC File Offset: 0x001DA8EC
	public void QFEMQODLJKE(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.LKPOBCBOFIC("powersplit" + PDIBIIKFBDH.DFNBFIFFQMB());
		this.CGGNFLKJOHF.LKPOBCBOFIC(item.NDPGCGDLEEQ());
		this.HNINKEFBKJP = item.QKMHPDJNJHE();
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.PINEJNIDONB(item.QCQPPPFPCQH().ToString());
		base.gameObject.name = "Orleans.Runtime.GatewayTooBusyException" + item.NDPGCGDLEEQ();
		if (this.PQNQDKBGDMH != null)
		{
			if (item.OLDFMIBHHCI() == 0)
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(false);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(false);
			}
		}
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Fitter Line") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("e")) && this.HNINKEFBKJP.Contains("s Reflect wore off!\r\n"))
		{
			int num = this.HNINKEFBKJP.IndexOf("other");
			int num2 = this.HNINKEFBKJP.IndexOf("Camera Window");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Enabled" + this.HNINKEFBKJP.Substring(num + -62, num2 - (num + -95)));
			}
		}
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x001DC888 File Offset: 0x001DAA88
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

	// Token: 0x06003D84 RID: 15748 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected virtual void DENPHCBPNGF(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x001DC94C File Offset: 0x001DAB4C
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			if (this.MKBCKPPCIQO != null && this.MKBCKPPCIQO.CLEMKHNIPEI == ItemCategory.Machine)
			{
				if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("HM") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("TM")) && this.HNINKEFBKJP.Contains("[u][33CCFF]"))
				{
					int num = this.HNINKEFBKJP.IndexOf("[u][33CCFF]");
					int num2 = this.HNINKEFBKJP.IndexOf("[-][/u]");
					if (num != -1 && num2 != -1)
					{
						string oofgfdhlfbn = this.HNINKEFBKJP.Substring(num + 11, num2 - (num + 11));
						foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
						{
							if (cgnfqjpjepc.DGKDPPQICKH != null)
							{
								if (KGQECFKLKOP.BGCIDLJNBOO(KGQECFKLKOP.NNHFLHEQMOI(cgnfqjpjepc.DGKDPPQICKH.BEQHNFFEHMQ), oofgfdhlfbn))
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[0];
								}
								else
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
							}
						}
					}
				}
			}
			else
			{
				foreach (CGNFQJPJEPC cgnfqjpjepc2 in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
				{
					cgnfqjpjepc2.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
				}
			}
		}
		else
		{
			foreach (CGNFQJPJEPC cgnfqjpjepc3 in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
			{
				cgnfqjpjepc3.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
			}
		}
	}

	// Token: 0x06003D86 RID: 15750 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected virtual void CBCMIHQNEFB(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x001DCAF8 File Offset: 0x001DACF8
	protected virtual void FHHMBOIIBIL()
	{
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
		base.transform.parent = INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
		}
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x001DCB5C File Offset: 0x001DAD5C
	private void NGDKDFILIDJ(Guid JNOOPPDPFEH)
	{
		if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 1)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i] == JNOOPPDPFEH)
				{
					this.IPCKQDIKIBI(i);
					return;
				}
			}
		}
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected override void GetClone(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003D8A RID: 15754 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected virtual void OQPIBGNEQNB(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x001DCBC4 File Offset: 0x001DADC4
	private void JQFIDNCKHMH(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "enablenpc(" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "FOG_AREA_SPHERE";
			text = text + "r" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Own Tempo", string.Empty) + "2";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JEDHBMEEGEB(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x001DCC3C File Offset: 0x001DAE3C
	protected virtual void BCBIJJKECFI()
	{
		INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(true);
		base.transform.parent = INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(true);
		}
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x001DCCA0 File Offset: 0x001DAEA0
	protected virtual void LCBPGFGEBBD()
	{
		INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(true);
		base.transform.parent = INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		}
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x001DCD04 File Offset: 0x001DAF04
	public void EJJBDNMPFIM(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "´" + PDIBIIKFBDH.EQCJBDOQDBB();
		this.CGGNFLKJOHF.LKPOBCBOFIC(item.FLFQBGJQBBD());
		this.HNINKEFBKJP = item.Description;
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(item.MQIHCHFOPGE().ToString());
		base.gameObject.name = "Bluenoise64/LDR_LLL1_" + item.Name;
		if (this.PQNQDKBGDMH != null)
		{
			if (item.HPPJBCJDJFK() == 1)
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(true);
				this.DJBNKKFLFMO.gameObject.SetActive(false);
			}
		}
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("uproar") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("p1")) && this.HNINKEFBKJP.Contains("("))
		{
			int num = this.HNINKEFBKJP.IndexOf("Hive Badge");
			int num2 = this.HNINKEFBKJP.IndexOf("blank");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "-singleturn" + this.HNINKEFBKJP.Substring(num + 97, num2 - (num + -78)));
			}
		}
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x001DCEA0 File Offset: 0x001DB0A0
	public void KGBBFDJGGPQ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.LKPOBCBOFIC("Max Repel" + PDIBIIKFBDH.NJLQNHJLNDC());
		this.CGGNFLKJOHF.LKPOBCBOFIC(item.Name);
		this.HNINKEFBKJP = item.OELFFKHICPQ();
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().OKBJNLOPPBF(item.ItemImage.ToString());
		base.gameObject.name = "-" + item.Name;
		if (this.PQNQDKBGDMH != null)
		{
			if (item.CJDBOLCHOHB() == 1)
			{
				this.PQNQDKBGDMH.SetActive(true);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
		}
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("[00DD00]Owned") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("shieldsdown")) && this.HNINKEFBKJP.Contains("$"))
		{
			int num = this.HNINKEFBKJP.IndexOf("ProCamera2D does not have a TransitionFX extension.");
			int num2 = this.HNINKEFBKJP.IndexOf("embargo");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "Chances of finding a wild Pokémon holding an item increased.\nTriggers: [2ecc71]Compound Eyes[-]" + this.HNINKEFBKJP.Substring(num + 17, num2 - (num + -65)));
			}
		}
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x001DD03C File Offset: 0x001DB23C
	private void KDEBCGQHPDO(int DBPKNCDGGEP = -1)
	{
		if (INFJMNPKNQF.FPQNIQELKMC().GLEBQIDOLKN.HLFELPLQLBC.activeSelf)
		{
			INFJMNPKNQF.DOGEBLQHDHI().GLEBQIDOLKN.EHJEDBLDGGJ();
			return;
		}
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			return;
		}
		if (DBPKNCDGGEP > -1 && DBPKNCDGGEP + 0 > HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count)
		{
			return;
		}
		if (this.MKBCKPPCIQO.MGQHOMNFHDL() || this.MKBCKPPCIQO.CMCPGDIKKOQ())
		{
			if (this.MKBCKPPCIQO.NFHMMDJNIKL())
			{
				if (DBPKNCDGGEP > -1)
				{
					if (!this.MKBCKPPCIQO.OMEFGOCNLQO())
					{
						INFJMNPKNQF.CFGIOIGOIFQ().DIMBOLLHNKC(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
					else
					{
						CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.MOGQNGEPCEO();
						string hiefqeedhgg = "[-]!\r\n";
						string[] array = new string[5];
						array[0] = "'s ";
						array[0] = KGQECFKLKOP.BFNBQBMJHFL(this.MKBCKPPCIQO.DBPKNCDGGEP).FLFQBGJQBBD();
						array[1] = "SSAO";
						array[8] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[DBPKNCDGGEP]).BEQHNFFEHMQ);
						array[7] = "English";
						cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), DBPKNCDGGEP.ToString(), (LPBPDPMJKNN.PJIJIFKBMBB)0, false, this.MKBCKPPCIQO, -1, false);
					}
				}
				if (DBPKNCDGGEP == -1)
				{
					if (!this.MKBCKPPCIQO.MGQHOMNFHDL())
					{
						CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("Teleport", "FOG_DISTANCE_ON", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
					}
					else if (this.MKBCKPPCIQO.OMEFGOCNLQO())
					{
						INFJMNPKNQF.IPOKOKIJECO().NFODEGPOGLG(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
				}
				return;
			}
			INFJMNPKNQF.QOQONHOOLNE.OONOOFJNIHK(this.MKBCKPPCIQO, DBPKNCDGGEP);
		}
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected virtual void MKKHQDQQKNN(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x001DD1D8 File Offset: 0x001DB3D8
	private void GPBLEHILJOQ(int DBPKNCDGGEP = -1)
	{
		if (INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.HLFELPLQLBC.activeSelf)
		{
			INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.Hide();
			return;
		}
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			return;
		}
		if (DBPKNCDGGEP > -1 && DBPKNCDGGEP + 1 > HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
		{
			return;
		}
		if (this.MKBCKPPCIQO.EBOKELDPMMO || this.MKBCKPPCIQO.LBNCFLKGCBH)
		{
			if (this.MKBCKPPCIQO.LBNCFLKGCBH)
			{
				if (DBPKNCDGGEP > -1)
				{
					if (!this.MKBCKPPCIQO.EBOKELDPMMO)
					{
						INFJMNPKNQF.QOQONHOOLNE.HDGHLOGHHIK(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
					else
					{
						CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Hold or Use?", string.Concat(new string[]
						{
							"Do you wish to Hold or Use [2ecc71]",
							KGQECFKLKOP.BFNBQBMJHFL(this.MKBCKPPCIQO.DBPKNCDGGEP).Name,
							"[-] on ",
							KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[DBPKNCDGGEP]).BEQHNFFEHMQ),
							"?"
						}), DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel, true, this.MKBCKPPCIQO, -1, false);
					}
				}
				if (DBPKNCDGGEP == -1)
				{
					if (!this.MKBCKPPCIQO.EBOKELDPMMO)
					{
						CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Item Usage", "Pokémon can only Hold this item, drag it onto a Pokémon to let it hold it.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
					}
					else if (this.MKBCKPPCIQO.EBOKELDPMMO)
					{
						INFJMNPKNQF.QOQONHOOLNE.IHOJLPELDDI(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
				}
				return;
			}
			INFJMNPKNQF.QOQONHOOLNE.IHOJLPELDDI(this.MKBCKPPCIQO, DBPKNCDGGEP);
		}
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x00019B7E File Offset: 0x00017D7E
	private void OnClick()
	{
		this.GPBLEHILJOQ(-1);
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x001DD374 File Offset: 0x001DB574
	private void GPBLEHILJOQ(Guid JNOOPPDPFEH)
	{
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i++)
			{
				if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i] == JNOOPPDPFEH)
				{
					this.GPBLEHILJOQ(i);
					return;
				}
			}
		}
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x001DD3DC File Offset: 0x001DB5DC
	private void IPCKQDIKIBI(int DBPKNCDGGEP = -1)
	{
		if (INFJMNPKNQF.QOQONHOOLNE.GLEBQIDOLKN.HLFELPLQLBC.activeSelf)
		{
			INFJMNPKNQF.FPQNIQELKMC().GLEBQIDOLKN.QGGBIBFNFGD();
			return;
		}
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			return;
		}
		if (DBPKNCDGGEP > -1 && DBPKNCDGGEP + 1 > HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count)
		{
			return;
		}
		if (this.MKBCKPPCIQO.OMEFGOCNLQO() || this.MKBCKPPCIQO.LBNCFLKGCBH)
		{
			if (this.MKBCKPPCIQO.PQDBIDNDHIO())
			{
				if (DBPKNCDGGEP > -1)
				{
					if (!this.MKBCKPPCIQO.MGQHOMNFHDL())
					{
						INFJMNPKNQF.QOQONHOOLNE.DIMBOLLHNKC(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
					else
					{
						CNCJKLNHQBH cncjklnhqbh = CNCJKLNHQBH.MOGQNGEPCEO();
						string hiefqeedhgg = "-sideend";
						string[] array = new string[1];
						array[1] = "HidePanel";
						array[0] = KGQECFKLKOP.BFNBQBMJHFL(this.MKBCKPPCIQO.HLMQODIHBIG()).Name;
						array[4] = "[ff6666]Battle";
						array[1] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[DBPKNCDGGEP]).BEQHNFFEHMQ);
						array[5] = "[spread]";
						cncjklnhqbh.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, this.MKBCKPPCIQO, -1, true);
					}
				}
				if (DBPKNCDGGEP == -1)
				{
					if (!this.MKBCKPPCIQO.EKHOPODHKKK())
					{
						CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Default", "default", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, true);
					}
					else if (this.MKBCKPPCIQO.MGQHOMNFHDL())
					{
						INFJMNPKNQF.QOQONHOOLNE.NFODEGPOGLG(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
				}
				return;
			}
			INFJMNPKNQF.QOQONHOOLNE.OONOOFJNIHK(this.MKBCKPPCIQO, DBPKNCDGGEP);
		}
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x001DD578 File Offset: 0x001DB778
	private void JEKQNINDBGG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = " Controller" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "BuffIcon_SweetScent";
			text = text + "any" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("VIGNETTE_CLASSIC", string.Empty) + "_TileMaxLoop";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JNDKHLFCEEB(text);
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x001DD5F0 File Offset: 0x001DB7F0
	private void PCPENHOHPBP(bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			if (this.MKBCKPPCIQO != null && this.MKBCKPPCIQO.KJLJHGEECPK() == ItemCategory.Machine)
			{
				if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Encounter Rate Increased 50%\nTriggers: [2ecc71]Arena Trap[-], [2ecc71]Swarm[-], [2ecc71]Illuminate[-], [2ecc71]No Guard[-]") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("cherrim")) && this.HNINKEFBKJP.Contains("!"))
				{
					int num = this.HNINKEFBKJP.IndexOf("Resetting EVs for your ");
					int num2 = this.HNINKEFBKJP.IndexOf("Fly");
					if (num != -1 && num2 != -1)
					{
						string oofgfdhlfbn = this.HNINKEFBKJP.Substring(num + 92, num2 - (num + 90));
						foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
						{
							if (cgnfqjpjepc.DGKDPPQICKH != null)
							{
								if (KGQECFKLKOP.BGCIDLJNBOO(KGQECFKLKOP.NNHFLHEQMOI(cgnfqjpjepc.DGKDPPQICKH.EDGHHFPMHBL()), oofgfdhlfbn))
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
								else
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
							}
						}
					}
				}
			}
			else
			{
				foreach (CGNFQJPJEPC cgnfqjpjepc2 in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
				{
					cgnfqjpjepc2.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
				}
			}
		}
		else
		{
			CGNFQJPJEPC[] nlcfmolbkgi3 = HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI;
			for (int k = 0; k < nlcfmolbkgi3.Length; k += 0)
			{
				CGNFQJPJEPC cgnfqjpjepc3 = nlcfmolbkgi3[k];
				cgnfqjpjepc3.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
			}
		}
	}

	// Token: 0x06003D99 RID: 15769 RVA: 0x001DD79C File Offset: 0x001DB99C
	private void IHMCNPOJBGN(bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			if (this.MKBCKPPCIQO != null && this.MKBCKPPCIQO.CLEMKHNIPEI == ItemCategory.Unknown)
			{
				if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("battler") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("Hidden/Post FX/Motion Blur")) && this.HNINKEFBKJP.Contains("_Offset"))
				{
					int num = this.HNINKEFBKJP.IndexOf("[PG]");
					int num2 = this.HNINKEFBKJP.IndexOf("status: ");
					if (num != -1 && num2 != -1)
					{
						string oofgfdhlfbn = this.HNINKEFBKJP.Substring(num + 42, num2 - (num + -89));
						foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
						{
							if (cgnfqjpjepc.DGKDPPQICKH != null)
							{
								if (KGQECFKLKOP.BGCIDLJNBOO(KGQECFKLKOP.NNHFLHEQMOI(cgnfqjpjepc.DGKDPPQICKH.EDGHHFPMHBL()), oofgfdhlfbn))
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
								else
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
							}
						}
					}
				}
			}
			else
			{
				CGNFQJPJEPC[] nlcfmolbkgi2 = HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI;
				for (int j = 1; j < nlcfmolbkgi2.Length; j++)
				{
					CGNFQJPJEPC cgnfqjpjepc2 = nlcfmolbkgi2[j];
					cgnfqjpjepc2.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
				}
			}
		}
		else
		{
			CGNFQJPJEPC[] nlcfmolbkgi3 = HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI;
			for (int k = 0; k < nlcfmolbkgi3.Length; k += 0)
			{
				CGNFQJPJEPC cgnfqjpjepc3 = nlcfmolbkgi3[k];
				cgnfqjpjepc3.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
			}
		}
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x001DD948 File Offset: 0x001DBB48
	protected override void OnDragDropRelease(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (component != null && component.gameObject.name != "ScriptPokemon" && !component.gameObject.name.Contains("Input") && !component.gameObject.name.Contains("input") && !component.gameObject.name.Contains("Chat Box"))
			{
				if (component.gameObject.name == "Pokemon View")
				{
					if (component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP != null)
					{
						this.MEONDFKLQJQ.GPBLEHILJOQ(component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP.LDQDJLFIDCN);
					}
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
					return;
				}
				if (component.gameObject.name == "TradeColliders")
				{
					if (this.MEONDFKLQJQ.MKBCKPPCIQO.PQCNDKGBHHQ)
					{
						PJCCMHCDFJQ.QOQONHOOLNE.FKOEOPCMLQF(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
					}
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
					PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					return;
				}
				this.MEONDFKLQJQ.GPBLEHILJOQ(component.PELCNBCMNFH);
				INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
				base.OnDragDropRelease(HQMQBKPNDJL);
				PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
				return;
			}
			else
			{
				if (component != null)
				{
					if (component.gameObject.name == "Chat Input")
					{
						component.gameObject.GetComponent<NHPGIPEOKID>().AddItem(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
						INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "Chat Box")
					{
						component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().AddItem(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
						INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "Input - PMChat" || component.gameObject.name == "Chat Box - PMChat")
					{
						component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().AddItem(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
						INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
						return;
					}
				}
				ONGOGFNONDC component2 = HQMQBKPNDJL.GetComponent<ONGOGFNONDC>();
				if (component2 != null)
				{
					GameObject.Find("PlayerHandler").GetComponent<QOHCEBMQKMB>().ECJPBBFIQEC(this.MEONDFKLQJQ.MKBCKPPCIQO);
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
					return;
				}
			}
		}
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		base.OnDragDropRelease(HQMQBKPNDJL);
		PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x001DDCB0 File Offset: 0x001DBEB0
	private void FBGCOKOHCQO(Guid JNOOPPDPFEH)
	{
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i++)
			{
				if (HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[i] == JNOOPPDPFEH)
				{
					this.IPCKQDIKIBI(i);
					return;
				}
			}
		}
	}

	// Token: 0x06003D9C RID: 15772 RVA: 0x001DDD18 File Offset: 0x001DBF18
	private void FPLNCJJCCIF(int DBPKNCDGGEP = -1)
	{
		if (INFJMNPKNQF.CFGIOIGOIFQ().GLEBQIDOLKN.HLFELPLQLBC.activeSelf)
		{
			INFJMNPKNQF.CFGIOIGOIFQ().GLEBQIDOLKN.LLIKMPBFNLK();
			return;
		}
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			return;
		}
		if (DBPKNCDGGEP > -1 && DBPKNCDGGEP + 1 > HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
		{
			return;
		}
		if (this.MKBCKPPCIQO.EBOKELDPMMO || this.MKBCKPPCIQO.NFHMMDJNIKL())
		{
			if (this.MKBCKPPCIQO.DJNKMJIFDKN())
			{
				if (DBPKNCDGGEP > -1)
				{
					if (!this.MKBCKPPCIQO.EBOKELDPMMO)
					{
						INFJMNPKNQF.FPQNIQELKMC().DIMBOLLHNKC(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
					else
					{
						CNCJKLNHQBH qoqonhoolne = CNCJKLNHQBH.QOQONHOOLNE;
						string hiefqeedhgg = " - ";
						string[] array = new string[2];
						array[0] = "Defeatist";
						array[0] = KGQECFKLKOP.BFNBQBMJHFL(this.MKBCKPPCIQO.FQOOHOOPFOH()).FLFQBGJQBBD();
						array[2] = "HidePanel";
						array[3] = KGQECFKLKOP.NNHFLHEQMOI(HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[DBPKNCDGGEP]).BEQHNFFEHMQ);
						array[7] = "burmy";
						qoqonhoolne.OBCNMKNGFIF(hiefqeedhgg, string.Concat(array), DBPKNCDGGEP.ToString(), LPBPDPMJKNN.PJIJIFKBMBB.HoldUseCancel, false, this.MKBCKPPCIQO, -1, true);
					}
				}
				if (DBPKNCDGGEP == -1)
				{
					if (!this.MKBCKPPCIQO.EBOKELDPMMO)
					{
						CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("The Pokémon, sensing danger, switches out when its HP becomes half or less.", "A", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
					}
					else if (this.MKBCKPPCIQO.EKHOPODHKKK())
					{
						INFJMNPKNQF.FPQNIQELKMC().PGCGKDGQIIJ(this.MKBCKPPCIQO, DBPKNCDGGEP);
					}
				}
				return;
			}
			INFJMNPKNQF.CFGIOIGOIFQ().PGCGKDGQIIJ(this.MKBCKPPCIQO, DBPKNCDGGEP);
		}
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x001DDEB4 File Offset: 0x001DC0B4
	public void BQLIIQIIMDH(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "x" + PDIBIIKFBDH.IFFFLJINPPQ;
		this.CGGNFLKJOHF.PIDLOFMIEFQ = item.Name;
		this.HNINKEFBKJP = item.Description;
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(item.ItemImage.ToString());
		base.gameObject.name = "inven " + item.Name;
		if (this.PQNQDKBGDMH != null)
		{
			if (item.Border == 1)
			{
				this.PQNQDKBGDMH.SetActive(true);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(false);
			}
		}
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
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x001DE050 File Offset: 0x001DC250
	private void LEEFNDOOJCE(Guid JNOOPPDPFEH)
	{
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; i += 0)
			{
				if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i] == JNOOPPDPFEH)
				{
					this.KDEBCGQHPDO(i);
					return;
				}
			}
		}
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x001DE0B8 File Offset: 0x001DC2B8
	private void FKCLGDJDBFN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = ")" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "You used '";
			text = text + " ended!\r\n" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("/", string.Empty) + "[7fff49]";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JEDHBMEEGEB(text);
		}
		else
		{
			GGGPJQEKNJD.QOLKOBPCJBQ(null);
		}
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x001DC900 File Offset: 0x001DAB00
	protected virtual void KDIKNNIKJJK(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		MDFQEBOLLJN component = GFFOJEKBKJD.GetComponent<MDFQEBOLLJN>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<MDFQEBOLLJN>();
		component.DGCGPPOIKOI.GOIHJQNMMJD = this.MEONDFKLQJQ.DGCGPPOIKOI.GOIHJQNMMJD;
		component.DBPKNCDGGEP = this.MEONDFKLQJQ.DBPKNCDGGEP;
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x001DE130 File Offset: 0x001DC330
	private void FEEJPEPPLNB(Guid JNOOPPDPFEH)
	{
		if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK != null && HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count > 0)
		{
			for (int i = 0; i < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; i += 0)
			{
				if (HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[i] == JNOOPPDPFEH)
				{
					this.FPLNCJJCCIF(i);
					return;
				}
			}
		}
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x001DE198 File Offset: 0x001DC398
	protected virtual void FEQQIGMEMBP(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (component != null && component.gameObject.name != "adata" && !component.gameObject.name.Contains("Surge Surfer") && !component.gameObject.name.Contains("Confirm EVs") && !component.gameObject.name.Contains("/gkick "))
			{
				if (component.gameObject.name == "Take 001")
				{
					if (component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP != null)
					{
						this.MEONDFKLQJQ.NGDKDFILIDJ(component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP.KGMFIOCJLEP());
					}
					INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(false);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
					return;
				}
				if (component.gameObject.name == "_Dissolve")
				{
					if (this.MEONDFKLQJQ.MKBCKPPCIQO.PCIONNCGEOK())
					{
						PJCCMHCDFJQ.DMOKBPOKHOQ().FKOEOPCMLQF(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
					}
					INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(false);
					PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
					base.OnDragDropRelease(HQMQBKPNDJL);
					return;
				}
				this.MEONDFKLQJQ.IPCKQDIKIBI(component.PELCNBCMNFH);
				INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(true);
				base.OnDragDropRelease(HQMQBKPNDJL);
				PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
				return;
			}
			else
			{
				if (component != null)
				{
					if (component.gameObject.name == "LeftS")
					{
						component.gameObject.GetComponent<NHPGIPEOKID>().BFEKQBJQMDQ(this.MEONDFKLQJQ.MKBCKPPCIQO.DBCHHNGOKGD());
						INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "Keen eyes prevent other Pokémon from lowering this Pokémon's accuracy.")
					{
						component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().EGMIIFOFQIE(this.MEONDFKLQJQ.MKBCKPPCIQO.HLMQODIHBIG());
						INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(true);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "Current Region:" || component.gameObject.name == "HidePanel")
					{
						component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().KFPGMHCCCCG(this.MEONDFKLQJQ.MKBCKPPCIQO.HLMQODIHBIG());
						INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
						return;
					}
				}
				ONGOGFNONDC component2 = HQMQBKPNDJL.GetComponent<ONGOGFNONDC>();
				if (component2 != null)
				{
					GameObject.Find("WATER_REFLECTIVE").GetComponent<QOHCEBMQKMB>().LOELCBDKJNO(this.MEONDFKLQJQ.MKBCKPPCIQO);
					INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(true);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
					return;
				}
			}
		}
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		base.OnDragDropRelease(HQMQBKPNDJL);
		PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x001DE500 File Offset: 0x001DC700
	protected virtual void LQQDEOKGCCQ(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (component != null && component.gameObject.name != "Limber" && !component.gameObject.name.Contains("synchronize") && !component.gameObject.name.Contains("[/pok]") && !component.gameObject.name.Contains("/Model.prefab"))
			{
				if (component.gameObject.name == "special")
				{
					if (component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP != null)
					{
						this.MEONDFKLQJQ.GPBLEHILJOQ(component.JCJBMKDBMFN.GetComponent<LINELKKDMEE>().QEPKKJKQMPP.KPJLEOCJFFO());
					}
					INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(true);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
					return;
				}
				if (component.gameObject.name == "#,##0")
				{
					if (this.MEONDFKLQJQ.MKBCKPPCIQO.QBHFODPEHDK())
					{
						PJCCMHCDFJQ.DMOKBPOKHOQ().HGBJMGKPKQP(this.MEONDFKLQJQ.MKBCKPPCIQO.DBPKNCDGGEP);
					}
					INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
					PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
					base.OnDragDropRelease(HQMQBKPNDJL);
					return;
				}
				this.MEONDFKLQJQ.IPCKQDIKIBI(component.PELCNBCMNFH);
				INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
				base.OnDragDropRelease(HQMQBKPNDJL);
				PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
				return;
			}
			else
			{
				if (component != null)
				{
					if (component.gameObject.name == " to ")
					{
						component.gameObject.GetComponent<NHPGIPEOKID>().KFCICKPDQJO(this.MEONDFKLQJQ.MKBCKPPCIQO.HLMQODIHBIG());
						INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
						return;
					}
					if (component.gameObject.name == "bag")
					{
						component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().BFEKQBJQMDQ(this.MEONDFKLQJQ.MKBCKPPCIQO.FQOOHOOPFOH());
						INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(false);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
						return;
					}
					if (component.gameObject.name == "You can not use item during interactions." || component.gameObject.name == "airballoon")
					{
						component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().KFPGMHCCCCG(this.MEONDFKLQJQ.MKBCKPPCIQO.HLMQODIHBIG());
						INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
						base.OnDragDropRelease(HQMQBKPNDJL);
						PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
						return;
					}
				}
				ONGOGFNONDC component2 = HQMQBKPNDJL.GetComponent<ONGOGFNONDC>();
				if (component2 != null)
				{
					GameObject.Find("grasspelt").GetComponent<QOHCEBMQKMB>().ECJPBBFIQEC(this.MEONDFKLQJQ.MKBCKPPCIQO);
					INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(true);
					base.OnDragDropRelease(HQMQBKPNDJL);
					PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(true);
					return;
				}
			}
		}
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
		base.OnDragDropRelease(HQMQBKPNDJL);
		PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(true);
	}

	// Token: 0x06003DA4 RID: 15780 RVA: 0x001DE868 File Offset: 0x001DCA68
	protected virtual void KDLBLFMLKQC()
	{
		INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(false);
		base.transform.parent = INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(true);
		}
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x001DE8CC File Offset: 0x001DCACC
	protected virtual void CQEIHGGKECE()
	{
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(false);
		base.transform.parent = INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QDGLKKGJDGI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		}
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x001DE930 File Offset: 0x001DCB30
	protected override void OnDragDropStart()
	{
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
		base.transform.parent = INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
		}
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x001DE994 File Offset: 0x001DCB94
	public void EEOOPJNPMPJ(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.DBPKNCDGGEP;
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.LKPOBCBOFIC("gray" + PDIBIIKFBDH.NJLQNHJLNDC());
		this.CGGNFLKJOHF.PIDLOFMIEFQ = item.NDPGCGDLEEQ();
		this.HNINKEFBKJP = item.PGEGEFKDKBB();
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().PINEJNIDONB(item.QCQPPPFPCQH().ToString());
		base.gameObject.name = "Enables a sure getaway from wild Pokémon." + item.FLFQBGJQBBD();
		if (this.PQNQDKBGDMH != null)
		{
			if (item.CJDBOLCHOHB() == 0)
			{
				this.PQNQDKBGDMH.SetActive(true);
				this.DJBNKKFLFMO.gameObject.SetActive(false);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(true);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
		}
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("wideguard") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("BB:")) && this.HNINKEFBKJP.Contains(","))
		{
			int num = this.HNINKEFBKJP.IndexOf("M0");
			int num2 = this.HNINKEFBKJP.IndexOf("GUIElements/New Battle/MonsterMaterial");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "[ATK]" + this.HNINKEFBKJP.Substring(num + -108, num2 - (num + -17)));
			}
		}
	}

	// Token: 0x06003DA8 RID: 15784 RVA: 0x001DEB30 File Offset: 0x001DCD30
	private void HMIILGLLNQM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "\\n" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "darkvoid";
			text = text + "You won 1x " + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace(" severely", string.Empty) + "&";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.JOFBCKFPFEN(text);
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x001DEBA8 File Offset: 0x001DCDA8
	private void JFKJOLEKQNF(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			string text = string.Empty;
			text = "[^a-zA-Z0-9_.]+" + this.CGGNFLKJOHF.PIDLOFMIEFQ + "UpdateAnchors";
			text = text + " was identified!\r\n" + this.ECJBGGNPOOQ.PIDLOFMIEFQ.Replace("Creator", string.Empty) + "Mind Badge";
			text += this.HNINKEFBKJP;
			GGGPJQEKNJD.HOICKEIJIHM(text);
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06003DAA RID: 15786 RVA: 0x001DEC20 File Offset: 0x001DCE20
	protected virtual void NDIOJNHOKMG()
	{
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(false);
		base.transform.parent = INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		}
	}

	// Token: 0x06003DAB RID: 15787 RVA: 0x001DEC84 File Offset: 0x001DCE84
	protected virtual void EONLDKJFFPO()
	{
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(false);
		base.transform.parent = INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.transform.parent;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
		}
	}

	// Token: 0x06003DAC RID: 15788 RVA: 0x001DECE8 File Offset: 0x001DCEE8
	private void QCEKMLKNKHP(bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			if (this.MKBCKPPCIQO != null && this.MKBCKPPCIQO.KJLJHGEECPK() == ItemCategory.General)
			{
				if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("allyTeam") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("2")) && this.HNINKEFBKJP.Contains("This Pokémon inflicts damage with its rough skin to the attacker on contact."))
				{
					int num = this.HNINKEFBKJP.IndexOf("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!");
					int num2 = this.HNINKEFBKJP.IndexOf("leafguard");
					if (num != -1 && num2 != -1)
					{
						string oofgfdhlfbn = this.HNINKEFBKJP.Substring(num + -39, num2 - (num + 113));
						foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
						{
							if (cgnfqjpjepc.DGKDPPQICKH != null)
							{
								if (KGQECFKLKOP.BGCIDLJNBOO(KGQECFKLKOP.NNHFLHEQMOI(cgnfqjpjepc.DGKDPPQICKH.BEQHNFFEHMQ), oofgfdhlfbn))
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[0];
								}
								else
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
							}
						}
					}
				}
			}
			else
			{
				foreach (CGNFQJPJEPC cgnfqjpjepc2 in HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI)
				{
					cgnfqjpjepc2.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
				}
			}
		}
		else
		{
			foreach (CGNFQJPJEPC cgnfqjpjepc3 in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
			{
				cgnfqjpjepc3.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
			}
		}
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x00019B7E File Offset: 0x00017D7E
	private void NNLDKMENINQ()
	{
		this.GPBLEHILJOQ(-1);
	}

	// Token: 0x06003DAE RID: 15790 RVA: 0x001DEE94 File Offset: 0x001DD094
	private void NGDBJMJDDFC(bool IFFGDNBQHLO)
	{
		if (IFFGDNBQHLO)
		{
			if (this.MKBCKPPCIQO != null && this.MKBCKPPCIQO.QLGFDFKBHMN() == ItemCategory.Machine)
			{
				if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("struggle") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("RenderType")) && this.HNINKEFBKJP.Contains("]"))
				{
					int num = this.HNINKEFBKJP.IndexOf("Shields Down");
					int num2 = this.HNINKEFBKJP.IndexOf("0000");
					if (num != -1 && num2 != -1)
					{
						string oofgfdhlfbn = this.HNINKEFBKJP.Substring(num + 1, num2 - (num + -82));
						foreach (CGNFQJPJEPC cgnfqjpjepc in HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI)
						{
							if (cgnfqjpjepc.DGKDPPQICKH != null)
							{
								if (KGQECFKLKOP.BGCIDLJNBOO(KGQECFKLKOP.NNHFLHEQMOI(cgnfqjpjepc.DGKDPPQICKH.BEQHNFFEHMQ), oofgfdhlfbn))
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[1];
								}
								else
								{
									cgnfqjpjepc.BLLHQPQBHBB.IDEOONDHNEL = this.HCCNMMDGHMQ[0];
								}
							}
						}
					}
				}
			}
			else
			{
				CGNFQJPJEPC[] nlcfmolbkgi2 = HFCMDEQKCKH.CFGIOIGOIFQ().NLCFMOLBKGI;
				for (int j = 1; j < nlcfmolbkgi2.Length; j += 0)
				{
					CGNFQJPJEPC cgnfqjpjepc2 = nlcfmolbkgi2[j];
					cgnfqjpjepc2.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
				}
			}
		}
		else
		{
			CGNFQJPJEPC[] nlcfmolbkgi3 = HFCMDEQKCKH.QOQONHOOLNE.NLCFMOLBKGI;
			for (int k = 0; k < nlcfmolbkgi3.Length; k += 0)
			{
				CGNFQJPJEPC cgnfqjpjepc3 = nlcfmolbkgi3[k];
				cgnfqjpjepc3.BLLHQPQBHBB.IDEOONDHNEL = Color.white;
			}
		}
	}

	// Token: 0x06003DAF RID: 15791 RVA: 0x001DF040 File Offset: 0x001DD240
	public void QMKELEEOHBE(KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH, INFJMNPKNQF HPCGCKLPFOD)
	{
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.DBPKNCDGGEP = PDIBIIKFBDH.HLMQODIHBIG();
		KGQECFKLKOP.Item item = KGQECFKLKOP.BFNBQBMJHFL(this.DBPKNCDGGEP);
		this.ECJBGGNPOOQ.PIDLOFMIEFQ = "game4.poke.one" + PDIBIIKFBDH.EHPJLLIEPDP();
		this.CGGNFLKJOHF.LKPOBCBOFIC(item.NDPGCGDLEEQ());
		this.HNINKEFBKJP = item.QKMHPDJNJHE();
		this.DGCGPPOIKOI.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.PINEJNIDONB(item.MQIHCHFOPGE().ToString());
		base.gameObject.name = "East" + item.Name;
		if (this.PQNQDKBGDMH != null)
		{
			if (item.Border == 1)
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
			else
			{
				this.PQNQDKBGDMH.SetActive(false);
				this.DJBNKKFLFMO.gameObject.SetActive(true);
			}
		}
		if ((this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("[-]!\r\n") || this.CGGNFLKJOHF.PIDLOFMIEFQ.Contains("CFX_SpawnSystem: There should only be one instance of CFX_SpawnSystem per Scene!\n")) && this.HNINKEFBKJP.Contains("[-]!\r\n"))
		{
			int num = this.HNINKEFBKJP.IndexOf("HideResponse");
			int num2 = this.HNINKEFBKJP.IndexOf("UP");
			if (num != -1 && num2 != -1)
			{
				BKKHLBCLPJM cggnflkjohf = this.CGGNFLKJOHF;
				cggnflkjohf.LKPOBCBOFIC(cggnflkjohf.PIDLOFMIEFQ + "F8" + this.HNINKEFBKJP.Substring(num + 34, num2 - (num + 31)));
			}
		}
	}

	// Token: 0x04000DB5 RID: 3509
	public BKKHLBCLPJM CGGNFLKJOHF;

	// Token: 0x04000DB6 RID: 3510
	public BKKHLBCLPJM ECJBGGNPOOQ;

	// Token: 0x04000DB7 RID: 3511
	public int DBPKNCDGGEP;

	// Token: 0x04000DB8 RID: 3512
	public JLMPBLMOICG DGCGPPOIKOI;

	// Token: 0x04000DB9 RID: 3513
	private string HNINKEFBKJP = string.Empty;

	// Token: 0x04000DBA RID: 3514
	public PLQFPBQEPJD DJBNKKFLFMO;

	// Token: 0x04000DBB RID: 3515
	public GameObject PQNQDKBGDMH;

	// Token: 0x04000DBC RID: 3516
	private KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO;

	// Token: 0x04000DBD RID: 3517
	public Color[] HCCNMMDGHMQ;

	// Token: 0x04000DBE RID: 3518
	private MDFQEBOLLJN MEONDFKLQJQ;
}
