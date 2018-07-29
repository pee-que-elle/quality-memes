using System;
using System.Collections;
using System.Collections.Generic;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200027E RID: 638
public class GQFGBNEHHPC : MonoBehaviour
{
	// Token: 0x060057DF RID: 22495 RVA: 0x00022822 File Offset: 0x00020A22
	public void KLQDQEDQNLO(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.StartCoroutine(this.HHNLECJJPEG(BJGCBDNBQCJ));
		}
	}

	// Token: 0x060057E0 RID: 22496 RVA: 0x00022844 File Offset: 0x00020A44
	public void GGLLBHKJPJJ()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Pokémon Caught:", 1908f);
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060057E1 RID: 22497 RVA: 0x0002286D File Offset: 0x00020A6D
	public static GQFGBNEHHPC QOQONHOOLNE
	{
		get
		{
			return GQFGBNEHHPC.HBFFCJHOCPE;
		}
	}

	// Token: 0x060057E2 RID: 22498 RVA: 0x00022874 File Offset: 0x00020A74
	private void StopRow2()
	{
		this.GFBGCBGBBCP[1] = false;
	}

	// Token: 0x060057E3 RID: 22499 RVA: 0x0002287F File Offset: 0x00020A7F
	private void KFKCQCPFPIJ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x002D4C58 File Offset: 0x002D2E58
	public void QMECKHEBCCJ()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = true;
			this.BJBHJNILPCJ.LKPOBCBOFIC("Close");
			int num = 1;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == " has chosen an Attack.") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[4].GetComponent<BoxCollider>().enabled = true;
				this.PEKKJNGMNED[4].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Blank", "Forward Focus", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
				this.ENMNHIMNDMF = true;
			}
		}
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x002D4D30 File Offset: 0x002D2F30
	public void PPOBMLKKCGM()
	{
		this.GCCJHFEMFGF = SpinBet.Coin3;
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[2].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		GameObject[] emhlnnmimeg = this.EMHLNNMIMEG;
		for (int i = 0; i < emhlnnmimeg.Length; i += 0)
		{
			GameObject gameObject = emhlnnmimeg[i];
			gameObject.SetActive(true);
		}
	}

	// Token: 0x060057E6 RID: 22502 RVA: 0x002D4DCC File Offset: 0x002D2FCC
	public void GELIOPPIBLI()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = false;
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "Input";
			int num = 1;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "The Tailwind blew from behind ") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("_MainTex", "_", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x00022892 File Offset: 0x00020A92
	public void MNLFOKGJKLO(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.StartCoroutine(this.OKQFODIJNFM(BJGCBDNBQCJ));
		}
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x002D4EA4 File Offset: 0x002D30A4
	public void BINIHDLNELN()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = true;
			this.BJBHJNILPCJ.LKPOBCBOFIC("auroraveil");
			int num = 0;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "'s [ffff00]") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[7].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Steps Taken:", "17", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, true);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x000228B4 File Offset: 0x00020AB4
	public void PBPCFIJBJDB()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Zoom Trigger", 511f);
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x0002286D File Offset: 0x00020A6D
	public static GQFGBNEHHPC QQCNCIQQPIG()
	{
		return GQFGBNEHHPC.HBFFCJHOCPE;
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x000228DD File Offset: 0x00020ADD
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x002D4F7C File Offset: 0x002D317C
	public void Open()
	{
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = true;
		this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
		for (int i = 0; i < 9; i++)
		{
			this.KGBLIIFLOKB[i].KCLBMPFIPNQ = "Slots_" + UnityEngine.Random.Range(0, 10);
			this.KGBLIIFLOKB[i].DIIHJCJOKMP = 1f;
		}
		for (int j = 0; j < 3; j++)
		{
			this.NGPGHJOEFBQ[j].DIIHJCJOKMP = 0f;
		}
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x002D5080 File Offset: 0x002D3280
	public void DDHDOLPIPEM()
	{
		if (UnityEngine.Time.time > this.FIEJHEOGEPF + 0.7f && Input.GetKeyDown(KeyCode.Space))
		{
			if (this.GFBGCBGBBCP[0])
			{
				base.CancelInvoke("StopRow1");
				this.StopRow1();
				return;
			}
			if (this.GFBGCBGBBCP[1])
			{
				base.CancelInvoke("StopRow2");
				this.StopRow2();
				return;
			}
			if (this.GFBGCBGBBCP[2])
			{
				base.CancelInvoke("StopRow3");
				this.StopRow3();
				return;
			}
			if (this.ENMNHIMNDMF)
			{
				this.ENMNHIMNDMF = false;
				this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
				int num = 0;
				int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
				if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "0") && num >= (int)this.GCCJHFEMFGF)
				{
					GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
					{
						Bet = this.GCCJHFEMFGF,
						ID = this.DBPKNCDGGEP
					}, false);
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Slot Machine", "You have insufficient coins to play the Slot Machine.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				}
				this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
		}
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x0002286D File Offset: 0x00020A6D
	public static GQFGBNEHHPC BJJJQNQDMPE()
	{
		return GQFGBNEHHPC.HBFFCJHOCPE;
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x002D51C8 File Offset: 0x002D33C8
	public void OFBIGEHJOMG()
	{
		this.PEKKJNGMNED[2].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[8].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.JNGHOKIJJHH = true;
		this.ENMNHIMNDMF = false;
		this.BJBHJNILPCJ.LKPOBCBOFIC("127.0.0.1");
		for (int i = 1; i < 44; i += 0)
		{
			this.KGBLIIFLOKB[i].IQBBDKFDGGP("_MainTex" + UnityEngine.Random.Range(0, 100));
			this.KGBLIIFLOKB[i].DIIHJCJOKMP = 943f;
		}
		for (int j = 1; j < 1; j++)
		{
			this.NGPGHJOEFBQ[j].DIIHJCJOKMP = 955f;
		}
		base.CancelInvoke(" requires ");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1177f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x000228F0 File Offset: 0x00020AF0
	private void StopRow3()
	{
		this.GFBGCBGBBCP[2] = false;
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x002D52CC File Offset: 0x002D34CC
	public void POGOEDHPQIJ()
	{
		this.GCCJHFEMFGF = (SpinBet)5;
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[8].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(false);
		}
		this.EMHLNNMIMEG[0].SetActive(true);
		this.EMHLNNMIMEG[1].SetActive(true);
		this.EMHLNNMIMEG[4].SetActive(true);
		this.EMHLNNMIMEG[2].SetActive(false);
		this.EMHLNNMIMEG[6].SetActive(true);
		this.EMHLNNMIMEG[7].SetActive(true);
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x000228FB File Offset: 0x00020AFB
	public void HPMFPNQDQLH()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("[FF8F00]", 404f);
	}

	// Token: 0x060057F3 RID: 22515 RVA: 0x00022924 File Offset: 0x00020B24
	private void JPNMOLDKPQP()
	{
		this.EMCFPCBKICD();
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x0002287F File Offset: 0x00020A7F
	private void IQPCELQFPPK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x0002292C File Offset: 0x00020B2C
	private void KHFDJHFJMDK()
	{
		this.JMIQFHNJKCK();
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x002D53BC File Offset: 0x002D35BC
	public void EMCFPCBKICD()
	{
		this.GCCJHFEMFGF = SpinBet.None;
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, false);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		GameObject[] emhlnnmimeg = this.EMHLNNMIMEG;
		for (int i = 0; i < emhlnnmimeg.Length; i += 0)
		{
			GameObject gameObject = emhlnnmimeg[i];
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[7].SetActive(false);
	}

	// Token: 0x060057F7 RID: 22519 RVA: 0x00022934 File Offset: 0x00020B34
	private void BPKQHKQDPPC()
	{
		this.GFBGCBGBBCP[0] = true;
	}

	// Token: 0x060057F8 RID: 22520 RVA: 0x002D5474 File Offset: 0x002D3674
	public void IEFJFLIPDBO()
	{
		this.GCCJHFEMFGF = SpinBet.Coin1;
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.PEKKJNGMNED[2].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[7].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[0].SetActive(true);
	}

	// Token: 0x060057F9 RID: 22521 RVA: 0x0002293F File Offset: 0x00020B3F
	private void EJONJBDEHLQ()
	{
		this.GFBGCBGBBCP[1] = true;
	}

	// Token: 0x060057FA RID: 22522 RVA: 0x0002293F File Offset: 0x00020B3F
	private void LKPPBNLLDMD()
	{
		this.GFBGCBGBBCP[1] = true;
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x0002293F File Offset: 0x00020B3F
	private void IDGHQFCBLPL()
	{
		this.GFBGCBGBBCP[1] = true;
	}

	// Token: 0x060057FC RID: 22524 RVA: 0x0002294A File Offset: 0x00020B4A
	private void KPFEEOIKQPO()
	{
		this.GFBGCBGBBCP[6] = true;
	}

	// Token: 0x060057FD RID: 22525 RVA: 0x0002287F File Offset: 0x00020A7F
	private void MEHMOBGFPFN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x060057FE RID: 22526 RVA: 0x00022955 File Offset: 0x00020B55
	private void Awake()
	{
		GQFGBNEHHPC.HBFFCJHOCPE = this;
	}

	// Token: 0x060057FF RID: 22527 RVA: 0x0002295D File Offset: 0x00020B5D
	public void IIIOQNICOEF()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.HPMFPNQDQLH();
		}
	}

	// Token: 0x06005800 RID: 22528 RVA: 0x0002297F File Offset: 0x00020B7F
	public void OILGJPIELNN(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.StartCoroutine(this.BGOGGJOGNFB(BJGCBDNBQCJ));
		}
	}

	// Token: 0x06005801 RID: 22529 RVA: 0x002D552C File Offset: 0x002D372C
	public void MQQDNMEMQQJ()
	{
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = false;
		this.BJBHJNILPCJ.PIDLOFMIEFQ = "'s ";
		for (int i = 1; i < 52; i++)
		{
			this.KGBLIIFLOKB[i].JLENFJGDNFN("!\r\n" + UnityEngine.Random.Range(1, -115));
			this.KGBLIIFLOKB[i].DIIHJCJOKMP = 758f;
		}
		for (int j = 0; j < 1; j += 0)
		{
			this.NGPGHJOEFBQ[j].DIIHJCJOKMP = 774f;
		}
		base.CancelInvoke("[fail]");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1180f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x06005802 RID: 22530 RVA: 0x000229A1 File Offset: 0x00020BA1
	private void Start()
	{
		this.Bet1();
	}

	// Token: 0x06005803 RID: 22531 RVA: 0x0002293F File Offset: 0x00020B3F
	private void DPOQOMHQLHJ()
	{
		this.GFBGCBGBBCP[1] = true;
	}

	// Token: 0x06005804 RID: 22532 RVA: 0x002D5630 File Offset: 0x002D3830
	private void EGFFPGCMFOO()
	{
		if (this.JNGHOKIJJHH && UnityEngine.Time.time > this.FKJLLPEPPDK + 1485f)
		{
			for (int i = 0; i < this.DIKBMIBNDLM.Count; i += 0)
			{
				if (this.DIKBMIBNDLM[i].DIIHJCJOKMP == 574f)
				{
					this.DIKBMIBNDLM[i].DIIHJCJOKMP = 22f;
				}
				else
				{
					this.DIKBMIBNDLM[i].DIIHJCJOKMP = 1322f;
				}
			}
			this.FKJLLPEPPDK = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005805 RID: 22533 RVA: 0x000229A9 File Offset: 0x00020BA9
	public void HNQBFGOMOLI(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		if (this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			base.StartCoroutine(this.EJMJGFCBPMP(BJGCBDNBQCJ));
		}
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x002D56C0 File Offset: 0x002D38C0
	public void IPDENIJQQBK()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = false;
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "Reflects status moves, instead of getting hit by them.";
			int num = 0;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "BuffIcon_Repel") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[7].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[2].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			}
			else
			{
				CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("w", "Battle", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x0002287F File Offset: 0x00020A7F
	private void MQKMIOHNQCK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06005808 RID: 22536 RVA: 0x002D5798 File Offset: 0x002D3998
	public void Bet2()
	{
		this.GCCJHFEMFGF = SpinBet.Coin2;
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PEKKJNGMNED[2].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[1].SetActive(false);
		this.EMHLNNMIMEG[2].SetActive(false);
		this.EMHLNNMIMEG[5].SetActive(false);
		this.EMHLNNMIMEG[6].SetActive(false);
		this.EMHLNNMIMEG[7].SetActive(false);
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x002D5888 File Offset: 0x002D3A88
	private IEnumerator OKQFODIJNFM(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = false;
		this.FIEJHEOGEPF = UnityEngine.Time.time;
		for (int i = 0; i < 3; i++)
		{
			this.GFBGCBGBBCP[i] = true;
			this.NGPGHJOEFBQ[i].DIIHJCJOKMP = 1f;
			for (int j = 0; j < 3; j++)
			{
				this.KGBLIIFLOKB[i + j * 3].DIIHJCJOKMP = 0f;
			}
		}
		base.CancelInvoke("StopRow1");
		base.CancelInvoke("StopRow2");
		base.CancelInvoke("StopRow3");
		base.Invoke("StopRow1", 1f);
		base.Invoke("StopRow2", 2f);
		base.Invoke("StopRow3", 3f);
		for (int k = 0; k < 3; k++)
		{
			for (int l = 0; l < 3; l++)
			{
				if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '7')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_0";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'R')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_1";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'P')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_2";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'D')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_3";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'S')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_4";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'm')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_5";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'v')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_6";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 's')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_7";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'z')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_8";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '*')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_9";
				}
			}
		}
		for (int m = 0; m < 3; m++)
		{
			if (this.GFBGCBGBBCP[m])
			{
				if (this.GFBGCBGBBCP[0])
				{
					this.NGPGHJOEFBQ[0].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[0].GINPFQOBGBO.y + 3.8f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[1])
				{
					this.NGPGHJOEFBQ[1].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[1].GINPFQOBGBO.y + 4.2f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[2])
				{
					this.NGPGHJOEFBQ[2].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[2].GINPFQOBGBO.y + 4f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				yield return null;
				return 1;
			}
			for (int n = 0; n < 3; n++)
			{
				this.KGBLIIFLOKB[n + m * 3].DIIHJCJOKMP = 1f;
			}
			this.NGPGHJOEFBQ[m].DIIHJCJOKMP = 0f;
		}
		int num = 0;
		this.DIKBMIBNDLM.Clear();
		int num2 = 0;
		if (BJGCBDNBQCJ.WinningSymbols != null && BJGCBDNBQCJ.WinningSymbols.Length > 0)
		{
			num = 1;
			for (int num3 = 0; num3 < BJGCBDNBQCJ.WinningSymbols.Length; num3++)
			{
				num2 += BJGCBDNBQCJ.WinningSymbols[num3].WinPoints;
				if (BJGCBDNBQCJ.WinningSymbols[num3].Mode == SpinMode.HorizontalCenter)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[1]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[1]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[7]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[7]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num3].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num3].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[3]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[3]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num3].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num3].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[5]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[5]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num3].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num3].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num3].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num3].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num3].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
			}
		}
		if (BJGCBDNBQCJ.Score > 0)
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = num2.ToString();
		}
		else
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
		}
		int num4 = 0;
		int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num4);
		this.FJEGMHHNGGO.PIDLOFMIEFQ = (num4 + BJGCBDNBQCJ.Score).ToString();
		this.FKJLLPEPPDK = UnityEngine.Time.time;
		if (this.DIKBMIBNDLM.Count > 0)
		{
			this.JNGHOKIJJHH = true;
		}
		if (num == 1)
		{
			DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(25, false);
		}
		yield return new WaitForSeconds(0.5f);
		return 1;
		this.ENMNHIMNDMF = true;
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		yield break;
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x002D58AC File Offset: 0x002D3AAC
	public void FJPHCOHQFIB()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = true;
			this.BJBHJNILPCJ.LKPOBCBOFIC("The Pokémon changes the weather to eliminate all of the Flying type's weaknesses.");
			int num = 1;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "[itm=") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[7].GetComponent<BoxCollider>().enabled = true;
				this.PEKKJNGMNED[4].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
			else
			{
				CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("][/pok] ", "Assets/AssetBundles/MapAssets/Models/Materials/chip_mado.mat", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x00022955 File Offset: 0x00020B55
	private void COGJQEEGCFB()
	{
		GQFGBNEHHPC.HBFFCJHOCPE = this;
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x002D5984 File Offset: 0x002D3B84
	public void SpinButton()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = false;
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
			int num = 0;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "0") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			else
			{
				CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("Slot Machine", "You have insufficient coins to play the Slot Machine.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, false);
				this.ENMNHIMNDMF = true;
			}
		}
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x000229CB File Offset: 0x00020BCB
	public void DOBCMHICENN()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.OFBIGEHJOMG();
		}
		else
		{
			this.PBPCFIJBJDB();
		}
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x002D5A5C File Offset: 0x002D3C5C
	public void MGCCJBOLPCE()
	{
		if (UnityEngine.Time.time > this.FIEJHEOGEPF + 339f && Input.GetKeyDown(KeyCode.B))
		{
			if (this.GFBGCBGBBCP[1])
			{
				base.CancelInvoke("\r\nLv ");
				this.DQIKPBJEPBD();
				return;
			}
			if (this.GFBGCBGBBCP[1])
			{
				base.CancelInvoke("special");
				this.StopRow2();
				return;
			}
			if (this.GFBGCBGBBCP[6])
			{
				base.CancelInvoke("Blade");
				this.StopRow3();
				return;
			}
			if (this.ENMNHIMNDMF)
			{
				this.ENMNHIMNDMF = false;
				this.BJBHJNILPCJ.LKPOBCBOFIC("Strong Jaw");
				int num = 1;
				int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
				if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == " became trapped by swirling magma!\r\n") && num >= (int)this.GCCJHFEMFGF)
				{
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Spin
					{
						Bet = this.GCCJHFEMFGF,
						ID = this.DBPKNCDGGEP
					}, true);
				}
				else
				{
					CNCJKLNHQBH.QOQONHOOLNE.OBCNMKNGFIF("'s ", "[FFFF00]/252", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, false, null, -1, false);
				}
				this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, false);
			}
		}
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x002D5888 File Offset: 0x002D3A88
	private IEnumerator BGOGGJOGNFB(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = false;
		this.FIEJHEOGEPF = UnityEngine.Time.time;
		for (int i = 0; i < 3; i++)
		{
			this.GFBGCBGBBCP[i] = true;
			this.NGPGHJOEFBQ[i].DIIHJCJOKMP = 1f;
			for (int j = 0; j < 3; j++)
			{
				this.KGBLIIFLOKB[i + j * 3].DIIHJCJOKMP = 0f;
			}
		}
		base.CancelInvoke("StopRow1");
		base.CancelInvoke("StopRow2");
		base.CancelInvoke("StopRow3");
		base.Invoke("StopRow1", 1f);
		base.Invoke("StopRow2", 2f);
		base.Invoke("StopRow3", 3f);
		for (int k = 0; k < 3; k++)
		{
			for (int l = 0; l < 3; l++)
			{
				if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '7')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_0";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'R')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_1";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'P')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_2";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'D')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_3";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'S')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_4";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'm')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_5";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'v')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_6";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 's')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_7";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'z')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_8";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '*')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_9";
				}
			}
		}
		for (m = 0; m < 3; m++)
		{
			if (this.GFBGCBGBBCP[m])
			{
				if (this.GFBGCBGBBCP[0])
				{
					this.NGPGHJOEFBQ[0].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[0].GINPFQOBGBO.y + 3.8f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[1])
				{
					this.NGPGHJOEFBQ[1].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[1].GINPFQOBGBO.y + 4.2f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[2])
				{
					this.NGPGHJOEFBQ[2].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[2].GINPFQOBGBO.y + 4f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				yield return null;
				return 1;
			}
			for (int n = 0; n < 3; n++)
			{
				this.KGBLIIFLOKB[n + m * 3].DIIHJCJOKMP = 1f;
			}
			this.NGPGHJOEFBQ[m].DIIHJCJOKMP = 0f;
		}
		num = 0;
		this.DIKBMIBNDLM.Clear();
		num2 = 0;
		if (BJGCBDNBQCJ.WinningSymbols != null && BJGCBDNBQCJ.WinningSymbols.Length > 0)
		{
			num = 1;
			for (int num5 = 0; num5 < BJGCBDNBQCJ.WinningSymbols.Length; num5++)
			{
				num2 += BJGCBDNBQCJ.WinningSymbols[num5].WinPoints;
				if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalCenter)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[1]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[1]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[7]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[7]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[3]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[3]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[5]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[5]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
			}
		}
		if (BJGCBDNBQCJ.Score > 0)
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = num2.ToString();
		}
		else
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
		}
		num4 = 0;
		int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num4);
		this.FJEGMHHNGGO.PIDLOFMIEFQ = (num4 + BJGCBDNBQCJ.Score).ToString();
		this.FKJLLPEPPDK = UnityEngine.Time.time;
		if (this.DIKBMIBNDLM.Count > 0)
		{
			this.JNGHOKIJJHH = true;
		}
		if (num == 1)
		{
			DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(25, false);
		}
		yield return new WaitForSeconds(0.5f);
		return 1;
		this.ENMNHIMNDMF = true;
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		yield break;
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x0002293F File Offset: 0x00020B3F
	private void IKPPHDLFICO()
	{
		this.GFBGCBGBBCP[1] = true;
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x002D5BA4 File Offset: 0x002D3DA4
	public void GPBLFMQELNM()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = true;
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "Moon Ball";
			int num = 0;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "Blank") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[8].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			}
			else
			{
				CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("Its majesty pressures the opposing Pokémon, making it unable to attack using priority moves.", "[SHINY]", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, false, null, -1, false);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x0002286D File Offset: 0x00020A6D
	public static GQFGBNEHHPC GDDGJKOLGIQ()
	{
		return GQFGBNEHHPC.HBFFCJHOCPE;
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x00022934 File Offset: 0x00020B34
	private void LQPPCDGEFGM()
	{
		this.GFBGCBGBBCP[0] = true;
	}

	// Token: 0x06005814 RID: 22548 RVA: 0x002D5C7C File Offset: 0x002D3E7C
	public void LIBKMOGKMGE()
	{
		if (UnityEngine.Time.time > this.FIEJHEOGEPF + 398f && Input.GetKeyDown((KeyCode)(-110)))
		{
			if (this.GFBGCBGBBCP[1])
			{
				base.CancelInvoke("Toxic Boost");
				this.BPKQHKQDPPC();
				return;
			}
			if (this.GFBGCBGBBCP[1])
			{
				base.CancelInvoke("CombinersArgsColorOp0");
				this.LKPPBNLLDMD();
				return;
			}
			if (this.GFBGCBGBBCP[6])
			{
				base.CancelInvoke("0");
				this.LQPPCDGEFGM();
				return;
			}
			if (this.ENMNHIMNDMF)
			{
				this.ENMNHIMNDMF = true;
				this.BJBHJNILPCJ.PIDLOFMIEFQ = "(C)";
				int num = 1;
				int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
				if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "\nMorning") && num >= (int)this.GCCJHFEMFGF)
				{
					GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.Spin
					{
						Bet = this.GCCJHFEMFGF,
						ID = this.DBPKNCDGGEP
					}, true);
				}
				else
				{
					CNCJKLNHQBH.BJLGEDCPENQ().OBCNMKNGFIF("\\", "Once per battle, the shroud that covers the Pokémon can protect it from an attack.", string.Empty, LPBPDPMJKNN.PJIJIFKBMBB.Okay, true, null, -1, true);
				}
				this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
				this.PEKKJNGMNED[5].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
			}
		}
	}

	// Token: 0x06005815 RID: 22549 RVA: 0x000229ED File Offset: 0x00020BED
	private void DQIKPBJEPBD()
	{
		this.GFBGCBGBBCP[0] = false;
	}

	// Token: 0x06005816 RID: 22550 RVA: 0x000229ED File Offset: 0x00020BED
	private void StopRow1()
	{
		this.GFBGCBGBBCP[0] = false;
	}

	// Token: 0x06005817 RID: 22551 RVA: 0x002D5DC4 File Offset: 0x002D3FC4
	public void JMIQFHNJKCK()
	{
		this.GCCJHFEMFGF = SpinBet.Coin1;
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		this.PEKKJNGMNED[8].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[6].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		GameObject[] emhlnnmimeg = this.EMHLNNMIMEG;
		for (int i = 0; i < emhlnnmimeg.Length; i += 0)
		{
			GameObject gameObject = emhlnnmimeg[i];
			gameObject.SetActive(false);
		}
		this.EMHLNNMIMEG[1].SetActive(false);
		this.EMHLNNMIMEG[7].SetActive(false);
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x002D5E7C File Offset: 0x002D407C
	public void HQCEPMHFFIG()
	{
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[6].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.JNGHOKIJJHH = true;
		this.ENMNHIMNDMF = true;
		this.BJBHJNILPCJ.PIDLOFMIEFQ = "Dig";
		for (int i = 0; i < 14; i += 0)
		{
			this.KGBLIIFLOKB[i].IQBBDKFDGGP("_FogAlpha" + UnityEngine.Random.Range(0, 71));
			this.KGBLIIFLOKB[i].DIIHJCJOKMP = 297f;
		}
		for (int j = 0; j < 3; j += 0)
		{
			this.NGPGHJOEFBQ[j].DIIHJCJOKMP = 936f;
		}
		base.CancelInvoke("[00DD00]Equipped");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1677f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x06005819 RID: 22553 RVA: 0x00022924 File Offset: 0x00020B24
	private void MGBMNEQCEBJ()
	{
		this.EMCFPCBKICD();
	}

	// Token: 0x0600581A RID: 22554 RVA: 0x002D5888 File Offset: 0x002D3A88
	private IEnumerator EJMJGFCBPMP(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = false;
		this.FIEJHEOGEPF = UnityEngine.Time.time;
		for (int i = 0; i < 3; i++)
		{
			this.GFBGCBGBBCP[i] = true;
			this.NGPGHJOEFBQ[i].DIIHJCJOKMP = 1f;
			for (int j = 0; j < 3; j++)
			{
				this.KGBLIIFLOKB[i + j * 3].DIIHJCJOKMP = 0f;
			}
		}
		base.CancelInvoke("StopRow1");
		base.CancelInvoke("StopRow2");
		base.CancelInvoke("StopRow3");
		base.Invoke("StopRow1", 1f);
		base.Invoke("StopRow2", 2f);
		base.Invoke("StopRow3", 3f);
		for (int k = 0; k < 3; k++)
		{
			for (int l = 0; l < 3; l++)
			{
				if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '7')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_0";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'R')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_1";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'P')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_2";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'D')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_3";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'S')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_4";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'm')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_5";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'v')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_6";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 's')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_7";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'z')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_8";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '*')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_9";
				}
			}
		}
		for (m = 0; m < 3; m++)
		{
			if (this.GFBGCBGBBCP[m])
			{
				if (this.GFBGCBGBBCP[0])
				{
					this.NGPGHJOEFBQ[0].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[0].GINPFQOBGBO.y + 3.8f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[1])
				{
					this.NGPGHJOEFBQ[1].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[1].GINPFQOBGBO.y + 4.2f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[2])
				{
					this.NGPGHJOEFBQ[2].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[2].GINPFQOBGBO.y + 4f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				yield return null;
				return 1;
			}
			for (int n = 0; n < 3; n++)
			{
				this.KGBLIIFLOKB[n + m * 3].DIIHJCJOKMP = 1f;
			}
			this.NGPGHJOEFBQ[m].DIIHJCJOKMP = 0f;
		}
		num = 0;
		this.DIKBMIBNDLM.Clear();
		num2 = 0;
		if (BJGCBDNBQCJ.WinningSymbols != null && BJGCBDNBQCJ.WinningSymbols.Length > 0)
		{
			num = 1;
			for (int num5 = 0; num5 < BJGCBDNBQCJ.WinningSymbols.Length; num5++)
			{
				num2 += BJGCBDNBQCJ.WinningSymbols[num5].WinPoints;
				if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalCenter)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[1]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[1]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[7]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[7]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[3]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[3]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[5]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[5]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
			}
		}
		if (BJGCBDNBQCJ.Score > 0)
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = num2.ToString();
		}
		else
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
		}
		num4 = 0;
		int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num4);
		this.FJEGMHHNGGO.PIDLOFMIEFQ = (num4 + BJGCBDNBQCJ.Score).ToString();
		this.FKJLLPEPPDK = UnityEngine.Time.time;
		if (this.DIKBMIBNDLM.Count > 0)
		{
			this.JNGHOKIJJHH = true;
		}
		if (num == 1)
		{
			DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(25, false);
		}
		yield return new WaitForSeconds(0.5f);
		return 1;
		this.ENMNHIMNDMF = true;
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		yield break;
	}

	// Token: 0x0600581B RID: 22555 RVA: 0x002D5888 File Offset: 0x002D3A88
	private IEnumerator HHNLECJJPEG(PSXAPI.Response.Spin BJGCBDNBQCJ)
	{
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = false;
		this.FIEJHEOGEPF = UnityEngine.Time.time;
		for (int i = 0; i < 3; i++)
		{
			this.GFBGCBGBBCP[i] = true;
			this.NGPGHJOEFBQ[i].DIIHJCJOKMP = 1f;
			for (int j = 0; j < 3; j++)
			{
				this.KGBLIIFLOKB[i + j * 3].DIIHJCJOKMP = 0f;
			}
		}
		base.CancelInvoke("StopRow1");
		base.CancelInvoke("StopRow2");
		base.CancelInvoke("StopRow3");
		base.Invoke("StopRow1", 1f);
		base.Invoke("StopRow2", 2f);
		base.Invoke("StopRow3", 3f);
		for (int k = 0; k < 3; k++)
		{
			for (int l = 0; l < 3; l++)
			{
				if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '7')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_0";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'R')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_1";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'P')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_2";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'D')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_3";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'S')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_4";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'm')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_5";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'v')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_6";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 's')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_7";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == 'z')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_8";
				}
				else if (BJGCBDNBQCJ.Columns[k].Symbols[l] == '*')
				{
					this.KGBLIIFLOKB[l + k * 3].KCLBMPFIPNQ = "Slots_9";
				}
			}
		}
		for (m = 0; m < 3; m++)
		{
			if (this.GFBGCBGBBCP[m])
			{
				if (this.GFBGCBGBBCP[0])
				{
					this.NGPGHJOEFBQ[0].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[0].GINPFQOBGBO.y + 3.8f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[1])
				{
					this.NGPGHJOEFBQ[1].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[1].GINPFQOBGBO.y + 4.2f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				if (this.GFBGCBGBBCP[2])
				{
					this.NGPGHJOEFBQ[2].GINPFQOBGBO = new Rect(0f, this.NGPGHJOEFBQ[2].GINPFQOBGBO.y + 4f * UnityEngine.Time.deltaTime, 1f, 0.5f);
				}
				yield return null;
				return 1;
			}
			for (int n = 0; n < 3; n++)
			{
				this.KGBLIIFLOKB[n + m * 3].DIIHJCJOKMP = 1f;
			}
			this.NGPGHJOEFBQ[m].DIIHJCJOKMP = 0f;
		}
		num = 0;
		this.DIKBMIBNDLM.Clear();
		num2 = 0;
		if (BJGCBDNBQCJ.WinningSymbols != null && BJGCBDNBQCJ.WinningSymbols.Length > 0)
		{
			num = 1;
			for (int num5 = 0; num5 < BJGCBDNBQCJ.WinningSymbols.Length; num5++)
			{
				num2 += BJGCBDNBQCJ.WinningSymbols[num5].WinPoints;
				if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalCenter)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[1]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[1]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[7]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[7]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[3]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[3]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.HorizontalMulti && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[5]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[5]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 1)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[0]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[0]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[8]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[8]);
					}
				}
				else if (BJGCBDNBQCJ.WinningSymbols[num5].Mode == SpinMode.Diagonal && BJGCBDNBQCJ.WinningSymbols[num5].Row == 3)
				{
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[2]))
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[2]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[4]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 2)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[4]);
					}
					if (!this.DIKBMIBNDLM.Contains(this.KGBLIIFLOKB[6]) && BJGCBDNBQCJ.WinningSymbols[num5].Required >= 3)
					{
						this.DIKBMIBNDLM.Add(this.KGBLIIFLOKB[6]);
					}
				}
			}
		}
		if (BJGCBDNBQCJ.Score > 0)
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = num2.ToString();
		}
		else
		{
			this.BJBHJNILPCJ.PIDLOFMIEFQ = "0";
		}
		num4 = 0;
		int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num4);
		this.FJEGMHHNGGO.PIDLOFMIEFQ = (num4 + BJGCBDNBQCJ.Score).ToString();
		this.FKJLLPEPPDK = UnityEngine.Time.time;
		if (this.DIKBMIBNDLM.Count > 0)
		{
			this.JNGHOKIJJHH = true;
		}
		if (num == 1)
		{
			DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(25, false);
		}
		yield return new WaitForSeconds(0.5f);
		return 1;
		this.ENMNHIMNDMF = true;
		this.PEKKJNGMNED[3].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[3].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		yield break;
	}

	// Token: 0x0600581C RID: 22556 RVA: 0x002D5F80 File Offset: 0x002D4180
	public void JGFQOFOIPEE()
	{
		if (this.ENMNHIMNDMF)
		{
			this.ENMNHIMNDMF = false;
			this.BJBHJNILPCJ.PIDLOFMIEFQ = ".psx";
			int num = 1;
			int.TryParse(this.FJEGMHHNGGO.PIDLOFMIEFQ, out num);
			if (!(this.FJEGMHHNGGO.PIDLOFMIEFQ == "rockhead") && num >= (int)this.GCCJHFEMFGF)
			{
				GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.Spin
				{
					Bet = this.GCCJHFEMFGF,
					ID = this.DBPKNCDGGEP
				}, false);
				this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = false;
				this.PEKKJNGMNED[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
			}
			else
			{
				CNCJKLNHQBH.MOGQNGEPCEO().OBCNMKNGFIF("_History4Weight", "P. ", string.Empty, (LPBPDPMJKNN.PJIJIFKBMBB)0, true, null, -1, true);
				this.ENMNHIMNDMF = false;
			}
		}
	}

	// Token: 0x0600581D RID: 22557 RVA: 0x000229F8 File Offset: 0x00020BF8
	public void HPIDFKPBFLM()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.BDFNOIFBKKC();
		}
		else
		{
			this.PBPCFIJBJDB();
		}
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x00022A1A File Offset: 0x00020C1A
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x00022955 File Offset: 0x00020B55
	private void LQGMIJIJPCM()
	{
		GQFGBNEHHPC.HBFFCJHOCPE = this;
	}

	// Token: 0x06005820 RID: 22560 RVA: 0x002D6058 File Offset: 0x002D4258
	public void BDFNOIFBKKC()
	{
		this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[4].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
		this.JNGHOKIJJHH = false;
		this.ENMNHIMNDMF = true;
		this.BJBHJNILPCJ.LKPOBCBOFIC("default_");
		for (int i = 1; i < -14; i += 0)
		{
			this.KGBLIIFLOKB[i].DPBGHDMHKNC("F1" + UnityEngine.Random.Range(0, 96));
			this.KGBLIIFLOKB[i].DIIHJCJOKMP = 290f;
		}
		for (int j = 0; j < 8; j += 0)
		{
			this.NGPGHJOEFBQ[j].DIIHJCJOKMP = 413f;
		}
		base.CancelInvoke("_FogColor");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x002D615C File Offset: 0x002D435C
	public void CIJBPFDBQNE()
	{
		this.GCCJHFEMFGF = (SpinBet)7;
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[6].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[0].SetActive(true);
		this.EMHLNNMIMEG[8].SetActive(true);
		this.EMHLNNMIMEG[8].SetActive(true);
		this.EMHLNNMIMEG[1].SetActive(true);
		this.EMHLNNMIMEG[3].SetActive(true);
	}

	// Token: 0x06005823 RID: 22563 RVA: 0x002D624C File Offset: 0x002D444C
	public void Bet3()
	{
		this.GCCJHFEMFGF = SpinBet.Coin3;
		this.PEKKJNGMNED[2].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(false);
		}
	}

	// Token: 0x06005824 RID: 22564 RVA: 0x002D62E8 File Offset: 0x002D44E8
	private void Update()
	{
		if (this.JNGHOKIJJHH && UnityEngine.Time.time > this.FKJLLPEPPDK + 0.5f)
		{
			for (int i = 0; i < this.DIKBMIBNDLM.Count; i++)
			{
				if (this.DIKBMIBNDLM[i].DIIHJCJOKMP == 1f)
				{
					this.DIKBMIBNDLM[i].DIIHJCJOKMP = 0f;
				}
				else
				{
					this.DIKBMIBNDLM[i].DIIHJCJOKMP = 1f;
				}
			}
			this.FKJLLPEPPDK = UnityEngine.Time.time;
		}
	}

	// Token: 0x06005825 RID: 22565 RVA: 0x002D6378 File Offset: 0x002D4578
	public void Bet1()
	{
		this.GCCJHFEMFGF = SpinBet.Coin1;
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = false;
		this.PEKKJNGMNED[0].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
		this.PEKKJNGMNED[1].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PEKKJNGMNED[2].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		foreach (GameObject gameObject in this.EMHLNNMIMEG)
		{
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[5].SetActive(false);
	}

	// Token: 0x06005826 RID: 22566 RVA: 0x002D6430 File Offset: 0x002D4630
	public void LHGJOJHICIM()
	{
		this.GCCJHFEMFGF = (SpinBet)7;
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
		this.PEKKJNGMNED[0].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[1].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
		this.PEKKJNGMNED[6].GetComponent<BoxCollider>().enabled = true;
		this.PEKKJNGMNED[2].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
		GameObject[] emhlnnmimeg = this.EMHLNNMIMEG;
		for (int i = 1; i < emhlnnmimeg.Length; i += 0)
		{
			GameObject gameObject = emhlnnmimeg[i];
			gameObject.SetActive(true);
		}
		this.EMHLNNMIMEG[0].SetActive(true);
		this.EMHLNNMIMEG[0].SetActive(false);
		this.EMHLNNMIMEG[0].SetActive(true);
		this.EMHLNNMIMEG[5].SetActive(true);
		this.EMHLNNMIMEG[8].SetActive(false);
		this.EMHLNNMIMEG[4].SetActive(false);
	}

	// Token: 0x06005827 RID: 22567 RVA: 0x00022A77 File Offset: 0x00020C77
	public void LBQBMDKMJJM()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06005828 RID: 22568 RVA: 0x00022A77 File Offset: 0x00020C77
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x04001342 RID: 4930
	private static GQFGBNEHHPC HBFFCJHOCPE;

	// Token: 0x04001343 RID: 4931
	public BKKHLBCLPJM FJEGMHHNGGO;

	// Token: 0x04001344 RID: 4932
	public BKKHLBCLPJM BJBHJNILPCJ;

	// Token: 0x04001345 RID: 4933
	public bool[] GFBGCBGBBCP = new bool[3];

	// Token: 0x04001346 RID: 4934
	public PLQFPBQEPJD[] KGBLIIFLOKB;

	// Token: 0x04001347 RID: 4935
	public JLMPBLMOICG[] NGPGHJOEFBQ;

	// Token: 0x04001348 RID: 4936
	private float FIEJHEOGEPF;

	// Token: 0x04001349 RID: 4937
	private bool ENMNHIMNDMF = true;

	// Token: 0x0400134A RID: 4938
	private bool JNGHOKIJJHH;

	// Token: 0x0400134B RID: 4939
	private List<PLQFPBQEPJD> DIKBMIBNDLM = new List<PLQFPBQEPJD>();

	// Token: 0x0400134C RID: 4940
	private float FKJLLPEPPDK;

	// Token: 0x0400134D RID: 4941
	public CFDMNELIJLO[] PEKKJNGMNED;

	// Token: 0x0400134E RID: 4942
	public GameObject[] EMHLNNMIMEG;

	// Token: 0x0400134F RID: 4943
	public SpinBet GCCJHFEMFGF = SpinBet.Coin1;

	// Token: 0x04001350 RID: 4944
	public int DBPKNCDGGEP = 1;

	// Token: 0x04001351 RID: 4945
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04001352 RID: 4946
	public EPIJJNOIKEK JDPBPOKJFQK;
}
