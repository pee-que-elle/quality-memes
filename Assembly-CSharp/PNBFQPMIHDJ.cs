using System;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x020001E3 RID: 483
public class PNBFQPMIHDJ : UIDragDropItem
{
	// Token: 0x06003EFA RID: 16122 RVA: 0x001EB6B0 File Offset: 0x001E98B0
	protected virtual void ILFOJBDMJFI()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x001EB780 File Offset: 0x001E9980
	private void GNIHMKDCMKK()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 1; i < dfdmppnqhgf.Length; i++)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = true;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(this.QQQMCPDDONB));
	}

	// Token: 0x06003EFC RID: 16124 RVA: 0x001EB7D0 File Offset: 0x001E99D0
	protected virtual void LPMNBHMJOLE()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.BEKHPOHIPDE().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x001EB8A0 File Offset: 0x001E9AA0
	public void FPQIFQNBIDC(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "_History4LumaTex" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -59 && FFJJCIQPLOP.CCMOCLMEKJN() % -4 > 0)
		{
			str = "doomdesire" + (FFJJCIQPLOP.QKNEIJQHGCB % 13).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().CPFJEOGMHOD("RT" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = (int)(688.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1808.0) * 191.0 - 664.0);
		if (num > 81)
		{
			num = 15;
		}
		if (num <= 8)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.PIDLOFMIEFQ = " is frozen solid!\r\n";
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Blank" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void KDFOLQJDJQJ()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003EFF RID: 16127 RVA: 0x001EBA1C File Offset: 0x001E9C1C
	private void OIJDCCBPGHM()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 0; i < dfdmppnqhgf.Length; i += 0)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = true;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.QQQMCPDDONB));
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x0001A101 File Offset: 0x00018301
	protected virtual void HCHIDEKMEBB()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x001EBA6C File Offset: 0x001E9C6C
	protected virtual void JJDBOLDJQNJ()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x001EBB3C File Offset: 0x001E9D3C
	protected virtual void CBICBMGFHCP()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 265f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 1240f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1595f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void BCGQQOFCMQJ()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x001EBC18 File Offset: 0x001E9E18
	public void BQLIIQIIMDH(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "Lv " + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 201 && FFJJCIQPLOP.QKNEIJQHGCB % 28 > 0)
		{
			str = "_" + (FFJJCIQPLOP.QKNEIJQHGCB % 28).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(75.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 100.0) * 100.0 - 1.0);
		if (num > 75)
		{
			num = 75;
		}
		if (num <= 2)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.PIDLOFMIEFQ = "Egg";
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "[SHINY]" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x001EBD94 File Offset: 0x001E9F94
	protected virtual void NDPGBLIEGIL(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.BEKHPOHIPDE().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "map:" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == " surrounds itself with a protective mist!\r\n")
				{
					JJGLMJNELOK.QOQONHOOLNE.NKMOHHOJNIG(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[ATK]" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.CNIMIQKQJJJ().DGCENEPBNFF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Can only tween UIWidgets!" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().OKGJQPFDCFQ(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "_ReflectionTexture1" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "K0" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "Contact with the Pokémon lowers the attacker's Speed stat." || component.gameObject.name == "--run") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().LLHINCPGLJL(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == " is exerting its pressure!\r\n")
				{
					JJGLMJNELOK.QOQONHOOLNE.IKKKEIPJMHP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "[FFFF00]") && component.gameObject.name != "Windowed")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 0)
					{
						if (component.gameObject.name.Contains("Battle Request"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().GGHNEEKOGQG(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
		if (PJCCMHCDFJQ.QDGLKKGJDGI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 48f;
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x001EC208 File Offset: 0x001EA408
	protected override void Update()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 0f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 0f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 5f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x0001A101 File Offset: 0x00018301
	protected virtual void MMLKOGQFENF()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x001EC2E4 File Offset: 0x001EA4E4
	protected virtual void IGJMLLFDCHM()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 961f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 24f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1851f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F09 RID: 16137 RVA: 0x001EC3C0 File Offset: 0x001EA5C0
	private void MQJBDIJQQEP()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 1; i < dfdmppnqhgf.Length; i++)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = false;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.QQQMCPDDONB));
	}

	// Token: 0x06003F0A RID: 16138 RVA: 0x001EC410 File Offset: 0x001EA610
	protected override void OnDragDropStart()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(true);
		}
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
	}

	// Token: 0x06003F0B RID: 16139 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void LGNBMHBLLHD(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x001EC550 File Offset: 0x001EA750
	protected virtual void EGFFPGCMFOO()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 778f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 467f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 583f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x001EC62C File Offset: 0x001EA82C
	protected virtual void KNBFDBMPDDH()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 809f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 377f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 830f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F0E RID: 16142 RVA: 0x001EC708 File Offset: 0x001EA908
	public void EJJBDNMPFIM(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.LKPOBCBOFIC("pinky" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 178 && FFJJCIQPLOP.CCMOCLMEKJN() % 86 > 0)
		{
			str = "Join Channel" + (FFJJCIQPLOP.CCMOCLMEKJN() % 92).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("It hurt itself in its confusion!\r\n" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = (int)(831.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1794.0) * 1937.0 - 657.0);
		if (num > -87)
		{
			num = -115;
		}
		if (num <= 7)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("[7fff49]");
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " would like to be friends. Do you wish to accept?" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x001EC884 File Offset: 0x001EAA84
	protected virtual void JIHOGMQPHDF()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 1616f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 158f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 935f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F10 RID: 16144 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void CNIKQOQLFFB()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F11 RID: 16145 RVA: 0x001EC960 File Offset: 0x001EAB60
	public void KIIGEFHQMDI(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "door_4" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 96 && FFJJCIQPLOP.CCMOCLMEKJN() % 62 > 0)
		{
			str = "HidePanel" + (FFJJCIQPLOP.CCMOCLMEKJN() % 108).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("door_3" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = (int)(1895.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1919.0) * 1179.0 - 1252.0);
		if (num > -120)
		{
			num = 10;
		}
		if (num <= 6)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("Guild Request");
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Chat Box" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x0001A101 File Offset: 0x00018301
	protected virtual void HQGDEKJQQDE()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x001ECADC File Offset: 0x001EACDC
	protected virtual void FMBMNDJFCIN(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "4|" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "gastrodoneast" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "stamina")
				{
					JJGLMJNELOK.QOQONHOOLNE.QECOCJBEDNK(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "\n[ffdb4d]DEF:[-] " && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().OFMFCHLGDFM(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "bump" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "<|>" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "CacheDefaultColor" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().HDHQMGIKILF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "heavymetal" || component.gameObject.name == "Encounter Rate Lowered 50% in Hail\nTriggers: [2ecc71]Snow Cloak[-]") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().CNCDPIHEQED(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "_FogSkyData")
				{
					JJGLMJNELOK.QOQONHOOLNE.LIIEKJHIDBP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "_TransitionTex") && component.gameObject.name != "Assets/AssetBundles/MapAssets/Model Materials/Single_Window.mat")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 1)
					{
						if (component.gameObject.name.Contains("Sweet Scent"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.MDGQHMBNKQG(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().ECNHBBBHGPF(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(true);
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
		this.FEJJMHCCDFL = 582f;
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x001ECF50 File Offset: 0x001EB150
	private void OnClick()
	{
		foreach (UIToggle uitoggle in this.QFOFODQBFOJ.DFDMPPNQHGF)
		{
			uitoggle.value = false;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(this.QQQMCPDDONB));
	}

	// Token: 0x06003F15 RID: 16149 RVA: 0x001ECFA0 File Offset: 0x001EB1A0
	protected virtual void EIPENLJIBEK()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(false);
		}
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x001ED070 File Offset: 0x001EB270
	public void FQFIFPGJDBE(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.LKPOBCBOFIC("bp=" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 75 && FFJJCIQPLOP.QKNEIJQHGCB % 6 > 0)
		{
			str = "_HairTex" + (FFJJCIQPLOP.QKNEIJQHGCB % -2).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("BuffIcon_MuteIcon" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(692.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 966.0) * 1250.0 - 1656.0);
		if (num > 81)
		{
			num = -10;
		}
		if (num <= 6)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.PIDLOFMIEFQ = "Beacon Badge";
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "u" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x0001A101 File Offset: 0x00018301
	protected virtual void NOLQNFCODBK()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void BQDGDEJGGLK(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x001ED1EC File Offset: 0x001EB3EC
	protected virtual void OKLDMELBMBI()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x001ED2BC File Offset: 0x001EB4BC
	protected virtual void QIHJCOLPLBQ()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 909f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 1674f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1019f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F1B RID: 16155 RVA: 0x001ED398 File Offset: 0x001EB598
	protected virtual void OHQCMCDPHFI()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 836f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 188f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 536f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x001ED474 File Offset: 0x001EB674
	protected virtual void OLQJGIBJOGM()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.KGOPJQOMMNC().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(false);
		}
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x001ED544 File Offset: 0x001EB744
	protected virtual void GHBFIQFIBKP()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 699f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 306f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1780f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected override void Start()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void LDLDQKEONNI(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x001ED620 File Offset: 0x001EB820
	public void EEOOPJNPMPJ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.LKPOBCBOFIC("]" + FFJJCIQPLOP.EOMPMQNGIBD.ToString());
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 16 && FFJJCIQPLOP.CCMOCLMEKJN() % -52 > 1)
		{
			str = "defiant" + (FFJJCIQPLOP.QKNEIJQHGCB % -83).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP("Battle Update: " + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(1413.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1133.0) * 1546.0 - 1663.0);
		if (num > 16)
		{
			num = -8;
		}
		if (num <= 3)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.PIDLOFMIEFQ = "HidePanel";
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = " flung its [ffff00]" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x001ED79C File Offset: 0x001EB99C
	protected virtual void POCOMCDDNOL(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "Already in Guild" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "What Pokémon will hatch from this Egg? It doesn't seem close to hatching." && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[")
				{
					JJGLMJNELOK.QOQONHOOLNE.NKMOHHOJNIG(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "CombinersArgsColorSrc1" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.QQCNCIQQPIG().BCHEBQKCIIF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "_FogVoidPosition" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "_Female" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().HDHQMGIKILF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Take 001" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "_Contrast" || component.gameObject.name == ".") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().KQPHPLLQDGH(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Times Fainted:")
				{
					JJGLMJNELOK.BEKHPOHIPDE().QIPLNPPJFDQ(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == " for ") && component.gameObject.name != "/")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 1)
					{
						if (component.gameObject.name.Contains("_Direction"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.CFGIOIGOIFQ().GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.QOQONHOOLNE.ECNHBBBHGPF(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.KGOPJQOMMNC().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 1134f;
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void PODEQMJNGKL(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x001EDC10 File Offset: 0x001EBE10
	protected virtual void IILBDLHICFK(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == " is no longer protected by mist!\r\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.BEKHPOHIPDE().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.MDGQHMBNKQG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "[-] failed to run away!\r\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "p")
				{
					JJGLMJNELOK.KGOPJQOMMNC().QECOCJBEDNK(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[33CCFF]" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.QOQONHOOLNE.OFMFCHLGDFM(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[itm=" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "#" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[-]\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "#,##0" || component.gameObject.name == "BuffIcon_Dig") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().AddPokemon(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[-]!\r\n")
				{
					JJGLMJNELOK.KGOPJQOMMNC().MINFBKQJCGP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "_FogPointLightColor5") && component.gameObject.name != "[PD]")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 0)
					{
						if (component.gameObject.name.Contains("[/I]"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.MDGQHMBNKQG(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().ECNHBBBHGPF(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(true);
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.KGOPJQOMMNC().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(true);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 792f;
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x001EE084 File Offset: 0x001EC284
	protected virtual void KCDBOBQDPOP(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "Player/Hats/" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.BEKHPOHIPDE().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "frz" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "physical")
				{
					JJGLMJNELOK.QOQONHOOLNE.BLQHEDDJKLC(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "The Pokémon's marvelous scales boost the Defense stat if it has a status condition." && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().OFMFCHLGDFM(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "--offline" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().OKGJQPFDCFQ(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == " surrounded itself with a veil of sweetness!\r\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "System" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().PHFJELBJCME(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "Mouse Click Collider" || component.gameObject.name == " harvested one [ffff00]") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().DCLGFDKNOMN(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "limber")
				{
					JJGLMJNELOK.QOQONHOOLNE.PBMFDPPOHKH(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "uproar") && component.gameObject.name != "frz")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 1)
					{
						if (component.gameObject.name.Contains("<|>"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.JNQJDBOFCPC(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().GGHNEEKOGQG(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.SetActive(false);
		if (PJCCMHCDFJQ.QDGLKKGJDGI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 673f;
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x001EE4F8 File Offset: 0x001EC6F8
	protected virtual void BCGDDQPJIOO()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.KGOPJQOMMNC().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		INFJMNPKNQF.DOGEBLQHDHI().PNFPOQMPCJO.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.IPOKOKIJECO().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void HPCICOEMKGF()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x001EE5C8 File Offset: 0x001EC7C8
	protected virtual void FKFEDINPBFF()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 846f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 1818f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1585f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x001EE6A4 File Offset: 0x001EC8A4
	public void PBLFJLLHJFG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "!\r\n" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 134 && FFJJCIQPLOP.QKNEIJQHGCB % 111 > 1)
		{
			str = "]" + (FFJJCIQPLOP.CCMOCLMEKJN() % 43).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("_ClipArgs1" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = (int)(170.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 884.0) * 443.0 - 703.0);
		if (num > 105)
		{
			num = -90;
		}
		if (num <= 3)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("#,##0");
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "PlayDeadAnimation" + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void CBCMIHQNEFB(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x001EE820 File Offset: 0x001ECA20
	public void LQFDMHPELCJ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "-mega-y" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 124 && FFJJCIQPLOP.QKNEIJQHGCB % 95 > 1)
		{
			str = "d" + (FFJJCIQPLOP.CCMOCLMEKJN() % -77).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().NMPCLCEQJMP("\n" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(1722.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 948.0) * 1905.0 - 538.0);
		if (num > 29)
		{
			num = -20;
		}
		if (num <= 2)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("allyTeam");
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("Update" + this.JCKICOFIHIB.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void LMELGHDGJMQ()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x001EE99C File Offset: 0x001ECB9C
	protected virtual void FBKNCKKFJJG()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 1270f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 145f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1455f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void KPKQNOCFGIB()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x001EEA78 File Offset: 0x001ECC78
	public void JMDOHOLHGBN(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "HideWinow" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -192 && FFJJCIQPLOP.CCMOCLMEKJN() % 59 > 1)
		{
			str = "Music" + (FFJJCIQPLOP.QKNEIJQHGCB % -39).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("Delete Tab" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(58.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1485.0) * 266.0 - 772.0);
		if (num > 118)
		{
			num = -16;
		}
		if (num <= 2)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC(" became cloaked in freezing air!\r\n");
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Powers up the Pokémon's Fire-type moves if it's hit by one." + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x001EEBF4 File Offset: 0x001ECDF4
	private void JMLMNQIHQBJ()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 0; i < dfdmppnqhgf.Length; i += 0)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = false;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(this.QQQMCPDDONB));
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x0001A0C1 File Offset: 0x000182C1
	protected virtual void GJLLCMLLEQF()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.QOQONHOOLNE.GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x001EEC44 File Offset: 0x001ECE44
	public void MFBIIOKFFQG(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "-" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.BEQHNFFEHMQ == 128 && FFJJCIQPLOP.CCMOCLMEKJN() % 16 > 0)
		{
			str = "[pok=" + (FFJJCIQPLOP.CCMOCLMEKJN() % 62).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().GOKLDOEGJHI("_FogColor" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(1853.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 808.0) * 1420.0 - 165.0);
		if (num > -38)
		{
			num = 84;
		}
		if (num <= 8)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL());
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.PIDLOFMIEFQ = "Upgrading Pokébox";
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("/[PD]" + this.JCKICOFIHIB.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected override void GetClone(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void OGNGFDEJOHC(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x001EEDC0 File Offset: 0x001ECFC0
	protected virtual void CPGLEOCGFIP(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "Illuminate" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "High Level Encounter Rate Increased 50%\nTriggers: [2ecc71]Hustle[-], [2ecc71]Pressure[-], [2ecc71]Vital Spirit[-], [2ecc71]Keen Eye[-], [2ecc71]Intimidate[-]" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Turns the ground into Electric Terrain when the Pokémon enters a battle.")
				{
					JJGLMJNELOK.KGOPJQOMMNC().NKMOHHOJNIG(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "HTE/Camera Effects Shader" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.QQCNCIQQPIG().OLKCDCMFQCN(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "-sm" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().KBQIEIHPBKC(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Big/" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "FOG_HAZE_ON" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().HDHQMGIKILF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "--idle" || component.gameObject.name == " is hurt by the sea of fire!\r\n") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().EHEQOGHQNMD(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "HidePanel")
				{
					JJGLMJNELOK.BEKHPOHIPDE().MINFBKQJCGP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "[-] was burned up!\r\n") && component.gameObject.name != "fighting")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 1)
					{
						if (component.gameObject.name.Contains("_ProjInfo"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.CFGIOIGOIFQ().GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().GGHNEEKOGQG(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 23f;
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x001EF234 File Offset: 0x001ED434
	protected virtual void EOFDDGOGMIF()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x001EF304 File Offset: 0x001ED504
	public void BPJHFHOPKEL(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "HideEmote" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == 172 && FFJJCIQPLOP.CCMOCLMEKJN() % 28 > 1)
		{
			str = "Battle" + (FFJJCIQPLOP.QKNEIJQHGCB % 77).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("Icon_Pokemon_Alive" + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(672.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 774.0) * 1717.0 - 1224.0);
		if (num > -35)
		{
			num = 42;
		}
		if (num <= 5)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.BEQHNFFEHMQ);
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("VolumetricFogAndMist/Chaos Lerp");
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("It's So Hard To See!" + this.JCKICOFIHIB.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void PENQCCNCBEQ(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void KHKPHGHNHKF(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x001EF480 File Offset: 0x001ED680
	protected virtual void LNFQEJCKQIG()
	{
		this.FEJJMHCCDFL = Time.time;
		if (PJCCMHCDFJQ.GGBPGMMCGLI().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
		}
		if (JJGLMJNELOK.BEKHPOHIPDE().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
		base.transform.parent = INFJMNPKNQF.CFGIOIGOIFQ().PNFPOQMPCJO.transform.parent;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = false;
		}
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x001EF550 File Offset: 0x001ED750
	private void INOQDGMGINK()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 0; i < dfdmppnqhgf.Length; i += 0)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = true;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.QQQMCPDDONB));
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x001EF5A0 File Offset: 0x001ED7A0
	public void KDCHGCMPDLJ(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(true);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "[00DD00]Owned" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -81 && FFJJCIQPLOP.CCMOCLMEKJN() % 53 > 1)
		{
			str = "TONEMAPPING_NEUTRAL" + (FFJJCIQPLOP.QKNEIJQHGCB % 120).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("[-] " + FFJJCIQPLOP.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		int num = (int)(1328.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 789.0) * 1688.0 - 826.0);
		if (num > -106)
		{
			num = -112;
		}
		if (num <= 2)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("p2");
		}
		if (FFJJCIQPLOP.GEFODCNPFFI())
		{
			this.JCKICOFIHIB.LKPOBCBOFIC("[-]!\r\n" + this.JCKICOFIHIB.PIDLOFMIEFQ);
		}
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x001EF71C File Offset: 0x001ED91C
	protected virtual void HHHPJQQNDNQ(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "'s Snow Warning whipped up a hailstorm!" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.JNQJDBOFCPC(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "OnSocketDataRecieved" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Luxury Ball")
				{
					JJGLMJNELOK.KGOPJQOMMNC().KNINHNNOPIM(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[-]" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.QQCNCIQQPIG().OLKCDCMFQCN(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "_ClipSharpness" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().KBQIEIHPBKC(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "|" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().PHFJELBJCME(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[FF8F00]" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().QOQLEMMOQOI(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == " awake!\r\n" || component.gameObject.name == "Battle Update: ") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().NLQCGQGECGE(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "0")
				{
					JJGLMJNELOK.KGOPJQOMMNC().DLHEFQDFNIP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == " ") && component.gameObject.name != "Open")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 1)
					{
						if (component.gameObject.name.Contains("ANTI_FLICKER"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.OLEFNOKCLIG(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.QOQONHOOLNE.ECNHBBBHGPF(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.FPQNIQELKMC().PNFPOQMPCJO.SetActive(true);
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.KGOPJQOMMNC().JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 116f;
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x001EFB90 File Offset: 0x001EDD90
	protected virtual void GKLNBLPIQIJ(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "u" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.MDGQHMBNKQG(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == " Changed to Shield Forme!\r\n" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.CFGIOIGOIFQ().HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == " hung on using its [ffff00]Focus Band[-]!\r\n")
				{
					JJGLMJNELOK.BEKHPOHIPDE().NKMOHHOJNIG(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "[FFFF00]/252" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.JLLBKOOQKGO().DILFBDPIENJ(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "skilllink" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().KBQIEIHPBKC(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == " days ago" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().HDHQMGIKILF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Natural Cure" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "-damage" || component.gameObject.name == "p2") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().NLMIBLCDCMP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "EditorOnly")
				{
					JJGLMJNELOK.BEKHPOHIPDE().MINFBKQJCGP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "-mega-x") && component.gameObject.name != "_")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 0)
					{
						if (component.gameObject.name.Contains("clyde"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(1, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.CFGIOIGOIFQ().ECNHBBBHGPF(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		if (PJCCMHCDFJQ.DMOKBPOKHOQ().IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.KGOPJQOMMNC().KMHFFGFPEMB.gameObject.SetActive(true);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 1071f;
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x001F0004 File Offset: 0x001EE204
	private void DBMBOONLPIL()
	{
		foreach (UIToggle uitoggle in this.QFOFODQBFOJ.DFDMPPNQHGF)
		{
			uitoggle.value = false;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.QQQMCPDDONB));
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void LGQLJJCFOEI(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void HLGBINGKEHI(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x0001A101 File Offset: 0x00018301
	protected virtual void LNHDODMGBKC()
	{
		this.PQQEJQHDCPK = base.transform.parent;
		this.NDLCLMNEHOI = base.GetComponent<BoxCollider>();
		this.QFOFODQBFOJ = HFCMDEQKCKH.CFGIOIGOIFQ().GetComponent<LINELKKDMEE>();
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x001F0054 File Offset: 0x001EE254
	public void EEMHMOCLHPP(KGQECFKLKOP.FEKOIOJQNKH FFJJCIQPLOP)
	{
		if (FFJJCIQPLOP.GECLELHHNIO == 0)
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		else
		{
			this.JDKIICNEQEI.SetActive(false);
		}
		this.ICLNEPCODIK.PIDLOFMIEFQ = "focusband" + FFJJCIQPLOP.EOMPMQNGIBD.ToString();
		string str = string.Empty;
		if (FFJJCIQPLOP.EDGHHFPMHBL() == -199 && FFJJCIQPLOP.QKNEIJQHGCB % 126 > 1)
		{
			str = "BuffIcon" + (FFJJCIQPLOP.QKNEIJQHGCB % -23).ToString();
		}
		this.PHMFEMBPQLN.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("???" + FFJJCIQPLOP.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		int num = (int)(1519.0 / ((double)FFJJCIQPLOP.QKBGGCKIOLG / (double)FFJJCIQPLOP.DCFKMOILHEC * 1375.0) * 100.0 - 1513.0);
		if (num > -37)
		{
			num = -4;
		}
		if (num <= 1)
		{
		}
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
		}
		this.JCKICOFIHIB.LKPOBCBOFIC(KGQECFKLKOP.NNHFLHEQMOI(FFJJCIQPLOP.EDGHHFPMHBL()));
		if (FFJJCIQPLOP.CQQPFJQINIM != EggState.None)
		{
			this.ICLNEPCODIK.LKPOBCBOFIC("Monsters/");
		}
		if (FFJJCIQPLOP.BKNFHNFFCHE)
		{
			this.JCKICOFIHIB.PIDLOFMIEFQ = "Waiting..." + this.JCKICOFIHIB.PIDLOFMIEFQ;
		}
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x001F01D0 File Offset: 0x001EE3D0
	protected override void OnDragDropRelease(GameObject HQMQBKPNDJL)
	{
		if (HQMQBKPNDJL != null)
		{
			OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
			if (this.MEONDFKLQJQ == null)
			{
				this.MEONDFKLQJQ = this;
			}
			if (component == null)
			{
				if (HQMQBKPNDJL.gameObject.name == "Pokebox Button(Clone)" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0 && JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.activeSelf && HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>() != null)
				{
					HFCMDEQKCKH.QOQONHOOLNE.GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HQMQBKPNDJL.GetComponent<PNBFQPMIHDJ>().QQQMCPDDONB);
				}
			}
			else if (component != null)
			{
				if (component.gameObject.name == "PokeboxCollider" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(component.PELCNBCMNFH, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "PokeboxNumber")
				{
					JJGLMJNELOK.QOQONHOOLNE.NKMOHHOJNIG(component.GetComponent<GLDMQOIQDJD>().CCHDHKECLCD + 1, this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "ScriptPokemon" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					QOHCEBMQKMB.QOQONHOOLNE.DGCENEPBNFF(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "TradeColliders" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					PJCCMHCDFJQ.QOQONHOOLNE.JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Chat Input" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.gameObject.GetComponent<NHPGIPEOKID>().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "Chat Box" && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<NHPGIPEOKID>().JEEPMJPGIEB(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if ((component.gameObject.name == "Input - PMChat" || component.gameObject.name == "Chat Box - PMChat") && this.MEONDFKLQJQ.GNLNPCCPBCF == 0)
				{
					component.JCJBMKDBMFN.GetComponent<DBNMEGNMIDG>().AddPokemon(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (component.gameObject.name == "ReleasePoke")
				{
					JJGLMJNELOK.QOQONHOOLNE.LIIEKJHIDBP(this.MEONDFKLQJQ.QQQMCPDDONB);
				}
				else if (!(component.gameObject.name == "Pokemon View") && component.gameObject.name != "PokeboxCollider")
				{
					if (this.MEONDFKLQJQ.GNLNPCCPBCF > 0)
					{
						if (component.gameObject.name.Contains("Pokemons"))
						{
							if (component.PELCNBCMNFH < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count)
							{
								HFCMDEQKCKH.QOQONHOOLNE.GJMNNFOPODM(this.MEONDFKLQJQ.QQQMCPDDONB, HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[component.PELCNBCMNFH]);
							}
							else
							{
								HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
							}
						}
						else
						{
							HFCMDEQKCKH.QOQONHOOLNE.HIFNEGDCPDO(0, this.MEONDFKLQJQ.QQQMCPDDONB);
						}
					}
					else
					{
						HFCMDEQKCKH.QOQONHOOLNE.GGHNEEKOGQG(this.PELCNBCMNFH, component.PELCNBCMNFH);
					}
				}
			}
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		IKBQNBHOJJB.OKLNNGPNIEO(base.gameObject);
		INFJMNPKNQF.QOQONHOOLNE.PNFPOQMPCJO.SetActive(false);
		if (PJCCMHCDFJQ.QOQONHOOLNE.IGDDONDGNGG.gameObject.activeSelf)
		{
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		}
		if (JJGLMJNELOK.QOQONHOOLNE.JDPBPOKJFQK.gameObject.activeSelf)
		{
			JJGLMJNELOK.QOQONHOOLNE.KMHFFGFPEMB.gameObject.SetActive(false);
		}
		if (this.NDLCLMNEHOI != null)
		{
			this.NDLCLMNEHOI.enabled = true;
		}
		this.FEJJMHCCDFL = 0f;
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x001F0644 File Offset: 0x001EE844
	protected virtual void JPBJIKMEBOF()
	{
		base.Update();
		if (this.FEJJMHCCDFL != 725f && !this.mDragging && !this.mPressed)
		{
			this.FEJJMHCCDFL = 1292f;
			this.OnDragDropRelease(null);
		}
		if (this.DOPHECFHLEK != base.transform.localPosition)
		{
			this.DOPHECFHLEK = base.transform.localPosition;
			this.LBQKJFBNQDJ = Time.time;
		}
		if (this.NDLCLMNEHOI != null && base.transform.localPosition != this.OPGQPOPOPEB && !this.NDLCLMNEHOI.enabled && Time.time > this.LBQKJFBNQDJ + 1944f)
		{
			this.DOPHECFHLEK = Vector3.zero;
			this.LBQKJFBNQDJ = Time.time;
			this.OnDragDropRelease(null);
		}
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
	protected virtual void QHEMOQFIGBF(GameObject GFFOJEKBKJD, GameObject DJIFCJKKMBL)
	{
		PNBFQPMIHDJ component = GFFOJEKBKJD.GetComponent<PNBFQPMIHDJ>();
		this.MEONDFKLQJQ = DJIFCJKKMBL.GetComponent<PNBFQPMIHDJ>();
		component.PHMFEMBPQLN.GOIHJQNMMJD = this.MEONDFKLQJQ.PHMFEMBPQLN.GOIHJQNMMJD;
		component.QQQMCPDDONB = this.MEONDFKLQJQ.QQQMCPDDONB;
		component.GNLNPCCPBCF = this.MEONDFKLQJQ.GNLNPCCPBCF;
		component.PELCNBCMNFH = this.MEONDFKLQJQ.PELCNBCMNFH;
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x001F0720 File Offset: 0x001EE920
	private void CEGPCMGDLBO()
	{
		UIToggle[] dfdmppnqhgf = this.QFOFODQBFOJ.DFDMPPNQHGF;
		for (int i = 0; i < dfdmppnqhgf.Length; i += 0)
		{
			UIToggle uitoggle = dfdmppnqhgf[i];
			uitoggle.value = false;
		}
		this.QFOFODQBFOJ.BQLIIQIIMDH(HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(this.QQQMCPDDONB));
	}

	// Token: 0x04000DE8 RID: 3560
	public int PELCNBCMNFH;

	// Token: 0x04000DE9 RID: 3561
	public int GNLNPCCPBCF;

	// Token: 0x04000DEA RID: 3562
	private Transform PQQEJQHDCPK;

	// Token: 0x04000DEB RID: 3563
	private Vector3 OPGQPOPOPEB;

	// Token: 0x04000DEC RID: 3564
	private BoxCollider NDLCLMNEHOI;

	// Token: 0x04000DED RID: 3565
	public BKKHLBCLPJM ICLNEPCODIK;

	// Token: 0x04000DEE RID: 3566
	public BKKHLBCLPJM JCKICOFIHIB;

	// Token: 0x04000DEF RID: 3567
	public JLMPBLMOICG PHMFEMBPQLN;

	// Token: 0x04000DF0 RID: 3568
	public Guid QQQMCPDDONB;

	// Token: 0x04000DF1 RID: 3569
	private LINELKKDMEE QFOFODQBFOJ;

	// Token: 0x04000DF2 RID: 3570
	public GameObject JDKIICNEQEI;

	// Token: 0x04000DF3 RID: 3571
	public CFDMNELIJLO BLLHQPQBHBB;

	// Token: 0x04000DF4 RID: 3572
	private float FEJJMHCCDFL;

	// Token: 0x04000DF5 RID: 3573
	private Vector3 DOPHECFHLEK;

	// Token: 0x04000DF6 RID: 3574
	private float LBQKJFBNQDJ;

	// Token: 0x04000DF7 RID: 3575
	private PNBFQPMIHDJ MEONDFKLQJQ;
}
