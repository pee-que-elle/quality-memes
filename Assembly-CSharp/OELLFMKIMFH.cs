using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000185 RID: 389
public class OELLFMKIMFH : MonoBehaviour
{
	// Token: 0x0600302E RID: 12334 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator MJNQFGMQFEQ(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		string gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		string str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x00015AE9 File Offset: 0x00013CE9
	public void FDKIBLMDCKL(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.EBKJIEKBHHQ();
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator EJJBDNMPFIM(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x00015AFD File Offset: 0x00013CFD
	public void FIDFQFGOFFI(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.PPIBEQBJNIE();
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x00015B11 File Offset: 0x00013D11
	public void IPEONEPPEHM(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.QEKJOCGEGBK();
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x0016AD94 File Offset: 0x00168F94
	public void HBPLNQOFMQM()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 1253f;
			return;
		case "\n[5cd65c]SPDEF:[-] ":
		case "Sticky Hold":
		case "[-]!\r\n":
			this.BDGLGOHJBJN.OGQLCMOFLLQ("BuffIcon_MaleIncrease");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 487f;
			return;
		case "_Scale":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "17";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 534f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("'s side disappeared!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1672f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("[ATK]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1727f;
			return;

			this.BDGLGOHJBJN.DPBGHDMHKNC("ability");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 127f;
			return;
		case "13":
			this.BDGLGOHJBJN.JLENFJGDNFN("TradeColliders");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 465f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1802f;
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator BLFPCGEIDNL(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003035 RID: 12341 RVA: 0x0016AF80 File Offset: 0x00169180
	private void HDMNIKNDNGQ()
	{
		float num = 1116f;
		if (num > 820f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x0016AFA8 File Offset: 0x001691A8
	private void Update()
	{
		float num = 0f;
		if (num > 0.4f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003037 RID: 12343 RVA: 0x0016AFD0 File Offset: 0x001691D0
	public void MLOMDHOLLGD()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "substitute":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1831f;
			return;
		case "map":
			this.BDGLGOHJBJN.IQBBDKFDGGP("NPC/");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 581f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("Insomnia");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 792f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("_");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 299f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("/force down");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 889f;
			return;
		case "Invalid Username or Password..":
			this.BDGLGOHJBJN.JOHBNEHCEJH("stockple");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1889f;
			return;
		case "clyde":
			this.BDGLGOHJBJN.OGQLCMOFLLQ("_Color");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 495f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 765f;
	}

	// Token: 0x06003038 RID: 12344 RVA: 0x0016B1BC File Offset: 0x001693BC
	public void KLDHCCJEKFC()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "Guild":
		case "Not Input":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 989f;
			return;

			this.BDGLGOHJBJN.DPBGHDMHKNC("\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 30f;
			return;
		case "teravolt":
			this.BDGLGOHJBJN.DPBGHDMHKNC(" declined the Trade Request.");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 278f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1365f;
			return;
		case "#,##0":
			this.BDGLGOHJBJN.LGJOOQIBQDC("HideResponse");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1085f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Surf";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 337f;
			return;
		case "owntempo":
			this.BDGLGOHJBJN.JLENFJGDNFN("StopRow2");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 520f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 894f;
	}

	// Token: 0x06003039 RID: 12345 RVA: 0x0016B3A8 File Offset: 0x001695A8
	public void BLCBMCEJIKF()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "PP: ":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1451f;
			return;
		case "Rain":
		case "ENABLE_BLUE_CHANNEL":
			this.BDGLGOHJBJN.LGJOOQIBQDC("]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 256f;
			return;

			this.BDGLGOHJBJN.JLENFJGDNFN("battlebag");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1707f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("2_");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1323f;
			return;

			this.BDGLGOHJBJN.JOHBNEHCEJH("][");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1303f;
			return;
		case "!":
			this.BDGLGOHJBJN.IQBBDKFDGGP("A deluge of ions showers the battlefield!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1346f;
			return;
		case "Hidden/Post FX/Ambient Occlusion":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "WaveSpeed";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1240f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1287f;
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x0016B594 File Offset: 0x00169794
	private void HIKDHMFBNOD()
	{
		float num = 234f;
		if (num > 199f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator FQFIFPGJDBE(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x0016B5BC File Offset: 0x001697BC
	public void PPIBEQBJNIE()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 1128f;
			return;
		case "Bad Dreams":
			this.BDGLGOHJBJN.DPBGHDMHKNC(" did not evolve!");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 707f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("CombinersColorCombine");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1245f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("Map");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1528f;
			return;
		case "#,##0":
		case "WATER_SIMPLE":
			this.BDGLGOHJBJN.DPBGHDMHKNC("_");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 829f;
			return;
		case "4_":
			this.BDGLGOHJBJN.OGQLCMOFLLQ(" @ ");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 899f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("Purchasing");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 171f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 574f;
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x00015B25 File Offset: 0x00013D25
	public void JIIIPEPJJBQ(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.IGKKIPLOFDE();
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x0016B7A8 File Offset: 0x001699A8
	public void HFGCJIBECML()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 0f;
			return;
		case "brn":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_Burn";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		case "tox":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_BadlyPoisoned";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		case "psn":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_Poisoned";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		case "slp":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_Sleep";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		case "par":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_Paralyzed";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		case "frz":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Icon_Status_Frozen";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 0f;
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x0016B994 File Offset: 0x00169B94
	private void JLBMOKHNDBI()
	{
		float num = 238f;
		if (num > 440f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x00015B39 File Offset: 0x00013D39
	public void HFNCQMNHQCI(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.HFGCJIBECML();
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x0016BA30 File Offset: 0x00169C30
	public void LMBCFGHFIKE()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "inven ":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1596f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("Teleport");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 626f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("_Contrast");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1252f;
			return;

			this.BDGLGOHJBJN.JOHBNEHCEJH("Chat Box");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 742f;
			return;
		case "'s perish count fell to 3.\r\n":
		case ")":
			this.BDGLGOHJBJN.JOHBNEHCEJH("magicbounce");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1914f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("Earth Badge");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1313f;
			return;
		case "general":
			this.BDGLGOHJBJN.DPBGHDMHKNC("(B)");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 819f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 409f;
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x0016BC1C File Offset: 0x00169E1C
	private void QIHJCOLPLBQ()
	{
		float num = 1442f;
		if (num > 233f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator PBEFGBBHKPH(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x00015B4D File Offset: 0x00013D4D
	public void JCIOCQHKBQK(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.LMBCFGHFIKE();
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator BQLIIQIIMDH(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00015B61 File Offset: 0x00013D61
	public void KJPNFFIEGBD(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.GBMQDLPNCJG();
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00015B75 File Offset: 0x00013D75
	public void GEODLOLFKIB(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.HBPLNQOFMQM();
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00015B89 File Offset: 0x00013D89
	public void KMELQEBEBKH(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.KLDHCCJEKFC();
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00015AFD File Offset: 0x00013CFD
	public void LMMGCNPEFLQ(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.PPIBEQBJNIE();
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x0016BC44 File Offset: 0x00169E44
	public void HJMGNLHLMMP()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "Normal-type moves become Electric-type moves. The power of those moves is boosted a little.":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 523f;
			return;
		case "Influences Sum":
			this.BDGLGOHJBJN.JOHBNEHCEJH("allAdjacent");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 822f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 743f;
			return;
		case "[^a-zA-Z0-9]":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "[-][/u]\n";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 881f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP(", Account creation successful!");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 371f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("[33CCFF]Escape Stone[-]\n\nUsing this will return you to your last Pokecenter, at the same cost as fainting in battle.\n[00AA00]Cooldown Remaining: -[-]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1399f;
			return;
		case "[PD]":
		case "Analytic":
			this.BDGLGOHJBJN.IQBBDKFDGGP(", ");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 191f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 929f;
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x00015B9D File Offset: 0x00013D9D
	public void LIKGBQCIJDD(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.BLCBMCEJIKF();
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator PJJFGOKNQMJ(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x0600304E RID: 12366 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator FDDENOHPGQF(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x0600304F RID: 12367 RVA: 0x0016BE30 File Offset: 0x0016A030
	private void HGKPKMMIPLG()
	{
		float num = 682f;
		if (num > 717f)
		{
		}
		this.MPHLLMKDQEF = true;
	}

	// Token: 0x06003050 RID: 12368 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator DFEONCOPCPE(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003051 RID: 12369 RVA: 0x0016BE58 File Offset: 0x0016A058
	public void EBKJIEKBHHQ()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "The Battle was a tie!\r\n":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 548f;
			return;
		case "Disabled":
			this.BDGLGOHJBJN.LGJOOQIBQDC("_");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1776f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Invite";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1721f;
			return;
		case "Big Pecks":
			this.BDGLGOHJBJN.LGJOOQIBQDC("[668cff]Inspect");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 264f;
			return;
		case "Emails do not match":
		case "AFK":
			this.BDGLGOHJBJN.IQBBDKFDGGP("PokeboxCollider");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1084f;
			return;

			this.BDGLGOHJBJN.JOHBNEHCEJH(" fell straight down!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1825f;
			return;
		case " rose":
			this.BDGLGOHJBJN.JOHBNEHCEJH("System");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 319f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1005f;
	}

	// Token: 0x06003052 RID: 12370 RVA: 0x00015B61 File Offset: 0x00013D61
	public void CBHOCFQPHME(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.GBMQDLPNCJG();
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator EGKMLKHJCDD(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003054 RID: 12372 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator QKCOIIKFPKG(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003055 RID: 12373 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator LQFDMHPELCJ(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003056 RID: 12374 RVA: 0x0016AD34 File Offset: 0x00168F34
	public IEnumerator QNJHMCKNJIK(bool CDELDHPHQHG, int NGCLGFMBMHL, bool DKFBPJOEGQC = false, BFKFEDPKDHL IBMINEHKPFF = null, BKKHLBCLPJM DOGLCQPEBMI = null, PLQFPBQEPJD GBQLBQPGCFG = null, OELLFMKIMFH.MFFGQCJKPBD NMNMCGQPOPG = null, string JJPDHJPLNGQ = null, bool FDCPNIDOCGG = false)
	{
		if (NMNMCGQPOPG != null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = NMNMCGQPOPG.PLCBFLQBCQN;
			this.JKBEKOBJDBF.EOMPMQNGIBD = NMNMCGQPOPG.EOMPMQNGIBD;
			this.JKBEKOBJDBF.OQDOCCGPJDQ = NMNMCGQPOPG.OQDOCCGPJDQ;
			this.JKBEKOBJDBF.QKNEIJQHGCB = NMNMCGQPOPG.QKNEIJQHGCB;
		}
		base.transform.localScale = Vector3.zero;
		base.transform.NMBPDMIIHJB();
		gffqfofdbge = "M";
		if (this.JKBEKOBJDBF != null)
		{
			gffqfofdbge = this.JKBEKOBJDBF.OQDOCCGPJDQ;
		}
		if (NGCLGFMBMHL == 201)
		{
			JJPDHJPLNGQ = (this.JKBEKOBJDBF.QKNEIJQHGCB % 28).ToString();
		}
		if (CDELDHPHQHG)
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 180f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		else
		{
			base.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(NGCLGFMBMHL, DKFBPJOEGQC, base.transform.position, new Vector3(0f, 0f, 0f), JJPDHJPLNGQ, gffqfofdbge);
		}
		this.QNBGPKBQEEN = NGCLGFMBMHL;
		if (IBMINEHKPFF != null)
		{
			this.MKKBONLOFFP = IBMINEHKPFF;
		}
		if (NGCLGFMBMHL == 0)
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 0f;
		}
		else
		{
			this.MKKBONLOFFP.GetComponent<PLQFPBQEPJD>().DIIHJCJOKMP = 1f;
		}
		if (DOGLCQPEBMI != null)
		{
			this.LGJMJDIQCFC = DOGLCQPEBMI;
		}
		if (GBQLBQPGCFG != null)
		{
			this.BDGLGOHJBJN = GBQLBQPGCFG;
		}
		this.QNBFBLJCHDC = 1f;
		this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = KGQECFKLKOP.NNHFLHEQMOI(NGCLGFMBMHL);
		if (FDCPNIDOCGG)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "Ditto";
		}
		if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.ToLowerInvariant().Contains("-primal"))
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "P. " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (DKFBPJOEGQC)
		{
			this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[SHINY]" + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
		}
		if (JJPDHJPLNGQ != null)
		{
			if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-x"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega-y"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
			else if (JJPDHJPLNGQ.ToLowerInvariant().Contains("-mega"))
			{
				this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ = "[MEGA] " + this.MKKBONLOFFP.GNLJOOJDLGJ.PIDLOFMIEFQ;
			}
		}
		str = string.Empty;
		if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "F")
		{
			str = " [F]";
		}
		else if (this.JKBEKOBJDBF.OQDOCCGPJDQ == "M")
		{
			str = " [M]";
		}
		if (FDCPNIDOCGG)
		{
			str = string.Empty;
		}
		BKKHLBCLPJM gnljoojdlgj = this.MKKBONLOFFP.GNLJOOJDLGJ;
		gnljoojdlgj.PIDLOFMIEFQ += str;
		this.LGJMJDIQCFC.PIDLOFMIEFQ = "[Lv]" + this.JKBEKOBJDBF.EOMPMQNGIBD;
		this.HFGCJIBECML();
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x0016C044 File Offset: 0x0016A244
	public void IGKKIPLOFDE()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case " finally got its act together!\r\n":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 630f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "*";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1197f;
			return;

			this.BDGLGOHJBJN.LGJOOQIBQDC("_CurrentMipLevel");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1613f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "LA";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1340f;
			return;
		case "[-]":
			this.BDGLGOHJBJN.IQBBDKFDGGP("[PD]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 934f;
			return;
		case "&":
		case "The bursting flame hit ":
		case "_HistoryTex":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "24";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1421f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Enabled";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1952f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 536f;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00015B39 File Offset: 0x00013D39
	public void CDKDOMQGHBE(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.HFGCJIBECML();
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x0016C230 File Offset: 0x0016A430
	public void GBMQDLPNCJG()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 307f;
			return;
		case "USER_LUT":
			this.BDGLGOHJBJN.JLENFJGDNFN("!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 779f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("Items held by the Pokémon are stuck fast and cannot be removed by other Pokémon.");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1742f;
			return;
		case "][":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Guild";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 52f;
			return;

			this.BDGLGOHJBJN.JOHBNEHCEJH("_SunColor");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 438f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("Solid Rock");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 801f;
			return;
		case "PvP Losses:":
		case "]":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "wishiwashischool";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 483f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1334f;
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x00015BB1 File Offset: 0x00013DB1
	public void NCCMBOBHLEL(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.NKNLOCEBCLJ();
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x0016C41C File Offset: 0x0016A61C
	private void NIIPIECJPOL()
	{
		float num = 1265f;
		if (num > 742f)
		{
		}
		this.MPHLLMKDQEF = false;
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x0016C444 File Offset: 0x0016A644
	public void QEKJOCGEGBK()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 1292f;
			return;
		case "Battle Update: ":
		case "[ff6666]":
			this.BDGLGOHJBJN.LGJOOQIBQDC("_AutoExposure");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 691f;
			return;

			this.BDGLGOHJBJN.DPBGHDMHKNC("strength");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 464f;
			return;
		case " hour":
			this.BDGLGOHJBJN.JOHBNEHCEJH("itemamount");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1080f;
			return;
		case "2.6.3":
			this.BDGLGOHJBJN.OGQLCMOFLLQ("ability");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1478f;
			return;
		case " can't sleep in an uproar!\r\n":
			this.BDGLGOHJBJN.KCLBMPFIPNQ = "Dig";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 338f;
			return;

			this.BDGLGOHJBJN.JLENFJGDNFN("heatproof");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 25f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1230f;
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00015BC5 File Offset: 0x00013DC5
	public void IBNDDMLEMKB(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.KEELLGBCOPL();
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x0016C630 File Offset: 0x0016A830
	public void NKNLOCEBCLJ()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{

			this.BDGLGOHJBJN.DIIHJCJOKMP = 1804f;
			return;
		case "All sound-based moves become Water-type moves.":
		case "swap":
			this.BDGLGOHJBJN.LGJOOQIBQDC("WATER_REFRACTIVE");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1186f;
			return;
		case "LJMOLEKDCLP":
			this.BDGLGOHJBJN.LGJOOQIBQDC("' tab?");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1681f;
			return;

			this.BDGLGOHJBJN.DPBGHDMHKNC("bug");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1431f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("[-]. Should it forget another move to learn it?");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 180f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("Hydration");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 375f;
			return;
		case "Btn_TabHighlighted_Hover":
			this.BDGLGOHJBJN.OGQLCMOFLLQ(" was hurt by its burn!\r\n");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 394f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1340f;
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x0016C81C File Offset: 0x0016AA1C
	public void CJJLOBQHGKH()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "[/B]":
		case "Cinematics":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1703f;
			return;
		case "rotomfrost":
			this.BDGLGOHJBJN.IQBBDKFDGGP(")");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1741f;
			return;
		case "[PD]":
			this.BDGLGOHJBJN.JOHBNEHCEJH("_FogAlpha");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 254f;
			return;

			this.BDGLGOHJBJN.OGQLCMOFLLQ("[MEGA] ");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 904f;
			return;
		case "4":
			this.BDGLGOHJBJN.DPBGHDMHKNC("Surf");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 838f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("P");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1578f;
			return;

			this.BDGLGOHJBJN.DPBGHDMHKNC("None");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 240f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 1156f;
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00015B9D File Offset: 0x00013D9D
	public void JIKCDFHOGOC(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.BLCBMCEJIKF();
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x0016CA08 File Offset: 0x0016AC08
	public void KEELLGBCOPL()
	{
		if (this.JKBEKOBJDBF.PLCBFLQBCQN == null)
		{
			this.JKBEKOBJDBF.PLCBFLQBCQN = string.Empty;
		}
		if (this.BDGLGOHJBJN == null)
		{
			return;
		}
		string text = this.JKBEKOBJDBF.PLCBFLQBCQN.ToLowerInvariant();
		switch (text)
		{
		case "_Cutoff":
			this.BDGLGOHJBJN.DIIHJCJOKMP = 219f;
			return;
		case "Height: ":
		case "Error calling ":
			this.BDGLGOHJBJN.DPBGHDMHKNC(".");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1896f;
			return;

			this.BDGLGOHJBJN.KCLBMPFIPNQ = "moody";
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1871f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("CombinersUpColorBuff");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 789f;
			return;

			this.BDGLGOHJBJN.JOHBNEHCEJH("_MainTex");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 828f;
			return;

			this.BDGLGOHJBJN.IQBBDKFDGGP("[ff6666]");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1104f;
			return;
		case "psn":
		case "0000000000000000000000000000\n0111111111111001111111111110\n0100001000001001000001000010\n0100001000001111000001000010\n0100001000001001000001000010\n0111111111111001111111111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001111001111001111110\n0001001000001001000001001000\n0001001000001001000001001000\n0111001111111111111111001110\n0100001001000000001001000010\n0100001001000000001001000010\n0111111001000000001001111110\n0100001001000000001001000010\n0100001001000000001001000010\n0111001001111111111001001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111111111111111111111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111001111111001111111001110\n0001001001000000001001001000\n0001001001000000001001001000\n0111111001111001111001111110\n0100001000001001000001000010\n0100001000001001000001000010\n0111111111111111111111111110\n0000000000000000000000000000":
		case "s Tailwind petered out!\r\n":
			this.BDGLGOHJBJN.OGQLCMOFLLQ("4_");
			this.BDGLGOHJBJN.DIIHJCJOKMP = 1243f;
			return;
		}
		this.BDGLGOHJBJN.DIIHJCJOKMP = 439f;
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00015BD9 File Offset: 0x00013DD9
	public void GFEMOICDIPH(string DIHGCPNKJCP = "")
	{
		this.JKBEKOBJDBF.PLCBFLQBCQN = DIHGCPNKJCP;
		this.MLOMDHOLLGD();
	}

	// Token: 0x04000B25 RID: 2853
	public MeshRenderer NEGLQQQDBEE;

	// Token: 0x04000B26 RID: 2854
	public MeshRenderer QEPKKJKQMPP;

	// Token: 0x04000B27 RID: 2855
	public BFKFEDPKDHL MKKBONLOFFP;

	// Token: 0x04000B28 RID: 2856
	public bool HFDFIILFGBL;

	// Token: 0x04000B29 RID: 2857
	public bool GPJLQMFKNON;

	// Token: 0x04000B2A RID: 2858
	public bool MPHLLMKDQEF = true;

	// Token: 0x04000B2B RID: 2859
	public KGQECFKLKOP.GPFFQQMDFPB HHKJGOPMMQL = new KGQECFKLKOP.GPFFQQMDFPB();

	// Token: 0x04000B2C RID: 2860
	public OELLFMKIMFH.MFFGQCJKPBD JKBEKOBJDBF = new OELLFMKIMFH.MFFGQCJKPBD();

	// Token: 0x04000B2D RID: 2861
	[Range(0f, 1f)]
	public float QNBFBLJCHDC = 1f;

	// Token: 0x04000B2E RID: 2862
	[Range(0f, 2f)]
	public float NBJPJBEQKPI = 1f;

	// Token: 0x04000B2F RID: 2863
	[Range(0f, 1f)]
	public float FJIKLOFOBBC;

	// Token: 0x04000B30 RID: 2864
	public float GJEMMBBNGLB = 128f;

	// Token: 0x04000B31 RID: 2865
	[Range(0f, 1f)]
	public float LDBMOOIEBHP = 0.02f;

	// Token: 0x04000B32 RID: 2866
	[Range(0f, 255f)]
	public float DMOLEJHGHCF;

	// Token: 0x04000B33 RID: 2867
	[Range(0f, 255f)]
	public float LKFEFNKEFDH;

	// Token: 0x04000B34 RID: 2868
	[Range(0f, 1f)]
	public float PLDLQOMPMHB;

	// Token: 0x04000B35 RID: 2869
	[Range(0f, 1f)]
	public float GKOFGGEHFBM;

	// Token: 0x04000B36 RID: 2870
	public Texture2D MGJBMGMEGBF;

	// Token: 0x04000B37 RID: 2871
	public Vector2 HOOONLPEQOI = Vector2.zero;

	// Token: 0x04000B38 RID: 2872
	public Vector2 GDCCBPNGNCE = Vector2.one;

	// Token: 0x04000B39 RID: 2873
	public BKKHLBCLPJM LGJMJDIQCFC;

	// Token: 0x04000B3A RID: 2874
	public PLQFPBQEPJD BDGLGOHJBJN;

	// Token: 0x04000B3B RID: 2875
	public int QNBGPKBQEEN;

	// Token: 0x04000B3C RID: 2876
	[CompilerGenerated]
	private static Dictionary<string, int> FBOKHFOEJFI;

	// Token: 0x02000186 RID: 390
	public class MFFGQCJKPBD
	{
		// Token: 0x04000B3D RID: 2877
		public string EOMPMQNGIBD = string.Empty;

		// Token: 0x04000B3E RID: 2878
		public string OQDOCCGPJDQ = string.Empty;

		// Token: 0x04000B3F RID: 2879
		public string PLCBFLQBCQN = string.Empty;

		// Token: 0x04000B40 RID: 2880
		public int QKNEIJQHGCB;
	}
}
