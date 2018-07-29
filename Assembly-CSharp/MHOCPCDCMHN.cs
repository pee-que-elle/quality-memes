using System;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x0200028E RID: 654
public class MHOCPCDCMHN : UIDragDropItem
{
	// Token: 0x06005AF4 RID: 23284 RVA: 0x002EE918 File Offset: 0x002ECB18
	public void HDNLCNIHJBM(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = ")" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "*" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x000239EF File Offset: 0x00021BEF
	private void LLJQQGDPJFD()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.BQLIIQIIMDH(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x002EE9C4 File Offset: 0x002ECBC4
	private void IPEFEBPPLBM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "'s " + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "O";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).LGOODGEDFQG();
				GGGPJQEKNJD.HOICKEIJIHM(text);
			}
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x000239EF File Offset: 0x00021BEF
	private void OnClick()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.BQLIIQIIMDH(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x00023A1A File Offset: 0x00021C1A
	private void GGMINIPOKJI()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.LBGCODKNHHP(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x002EEA30 File Offset: 0x002ECC30
	public void HOFCKQELDLF(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "Disabled" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).Name + "_FogColor" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x002EEADC File Offset: 0x002ECCDC
	protected override void OnDragDropRelease(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(false);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(false);
		if (this.ECJJLBGHJME)
		{
			bool flag = true;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "TradeColliders")
				{
					flag = false;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.QOQONHOOLNE.ECODDLNCHEI(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.QOQONHOOLNE.PGLNOPDBOBP(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(true);
			PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(true);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(true);
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x002EEC58 File Offset: 0x002ECE58
	public void BQLIIQIIMDH(PokemonData FFJJCIQPLOP, bool CDICPIDFLOO = true, LINELKKDMEE MPIKNHKEHMF = null)
	{
		this.QFOFODQBFOJ = MPIKNHKEHMF;
		this.EMLKKOFMIIH = FFJJCIQPLOP;
		this.ECJJLBGHJME = CDICPIDFLOO;
		this.HLPQFNKBMLN = true;
		base.gameObject.name = FFJJCIQPLOP.UniqueID.ToString();
		if (FFJJCIQPLOP.Payload == null)
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = "Egg";
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/9999", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!FFJJCIQPLOP.Payload.Shiny) ? string.Empty : "[SHINY]") + KGQECFKLKOP.NNHFLHEQMOI((int)FFJJCIQPLOP.Payload.PokemonID) + "\r\nLv " + FFJJCIQPLOP.Payload.Level.ToString();
			string str = string.Empty;
			if (FFJJCIQPLOP.Payload.PokemonID == PokemonID.unown && FFJJCIQPLOP.Payload.Personality % 28 > 0)
			{
				str = "_" + (FFJJCIQPLOP.Payload.Personality % 28).ToString();
			}
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Small/" + ((int)FFJJCIQPLOP.Payload.PokemonID).ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x00023A45 File Offset: 0x00021C45
	protected virtual void QONIDQLOEDP()
	{
		PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005AFD RID: 23293 RVA: 0x002EEDCC File Offset: 0x002ECFCC
	public void QMKELEEOHBE(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "r" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "Obtain the " + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).MQIHCHFOPGE().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005AFF RID: 23295 RVA: 0x002EEE78 File Offset: 0x002ED078
	public void LCCQBMMFONQ(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = " started!\r\n" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "Player/Hair" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x002EEF24 File Offset: 0x002ED124
	protected virtual void GFMOCQHDLGB(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(true);
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[1].gameObject.SetActive(true);
		if (this.ECJJLBGHJME)
		{
			bool flag = false;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "r")
				{
					flag = true;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.QDGLKKGJDGI().EEIPLMLIGDP(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().HNFBIMQFBQB(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[1].gameObject.SetActive(true);
			PJCCMHCDFJQ.GGBPGMMCGLI().JHDGENGBPQF[0].gameObject.SetActive(false);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[0].gameObject.SetActive(false);
	}

	// Token: 0x06005B01 RID: 23297 RVA: 0x00023A45 File Offset: 0x00021C45
	protected virtual void BHMQEEPCIEN()
	{
		PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005B02 RID: 23298 RVA: 0x002EF0A0 File Offset: 0x002ED2A0
	public void FDDENOHPGQF(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "17" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "Take 001" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).MQIHCHFOPGE().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B03 RID: 23299 RVA: 0x002EF14C File Offset: 0x002ED34C
	public void IQMKEHHHQKG(PokemonData FFJJCIQPLOP, bool CDICPIDFLOO = true, LINELKKDMEE MPIKNHKEHMF = null)
	{
		this.QFOFODQBFOJ = MPIKNHKEHMF;
		this.EMLKKOFMIIH = FFJJCIQPLOP;
		this.ECJJLBGHJME = CDICPIDFLOO;
		this.HLPQFNKBMLN = true;
		base.gameObject.name = FFJJCIQPLOP.UniqueID.ToString();
		if (FFJJCIQPLOP.Payload == null)
		{
			this.FPQBICGEHMJ.LKPOBCBOFIC(" has been afflicted with an infestation by ");
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("electricterrain", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!FFJJCIQPLOP.Payload.Shiny) ? string.Empty : "Confirm EVs") + KGQECFKLKOP.NNHFLHEQMOI((int)FFJJCIQPLOP.Payload.PokemonID) + "_Detail" + FFJJCIQPLOP.Payload.Level.ToString();
			string str = string.Empty;
			if (FFJJCIQPLOP.Payload.PokemonID == (PokemonID)(-12) && FFJJCIQPLOP.Payload.Personality % -60 > 1)
			{
				str = "UNITY_COLORSPACE_GAMMA" + (FFJJCIQPLOP.Payload.Personality % -37).ToString();
			}
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("memento" + ((int)FFJJCIQPLOP.Payload.PokemonID).ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B04 RID: 23300 RVA: 0x000239EF File Offset: 0x00021BEF
	private void NHDKCIJQGCH()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.BQLIIQIIMDH(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005B05 RID: 23301 RVA: 0x002EF2C0 File Offset: 0x002ED4C0
	public void KEHBPLMFDIP(PokemonData FFJJCIQPLOP, bool CDICPIDFLOO = true, LINELKKDMEE MPIKNHKEHMF = null)
	{
		this.QFOFODQBFOJ = MPIKNHKEHMF;
		this.EMLKKOFMIIH = FFJJCIQPLOP;
		this.ECJJLBGHJME = CDICPIDFLOO;
		this.HLPQFNKBMLN = true;
		base.gameObject.name = FFJJCIQPLOP.UniqueID.ToString();
		if (FFJJCIQPLOP.Payload == null)
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = " became the center of attention!\r\n";
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.GOKLDOEGJHI("Compound Eyes", GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		else
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!FFJJCIQPLOP.Payload.Shiny) ? string.Empty : "psn") + KGQECFKLKOP.NNHFLHEQMOI((int)FFJJCIQPLOP.Payload.PokemonID) + "throatchop" + FFJJCIQPLOP.Payload.Level.ToString();
			string str = string.Empty;
			if (FFJJCIQPLOP.Payload.PokemonID == (PokemonID)(-200) && FFJJCIQPLOP.Payload.Personality % -23 > 1)
			{
				str = "[block]" + (FFJJCIQPLOP.Payload.Personality % 92).ToString();
			}
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().NMPCLCEQJMP(" can't use the move!\r\n" + ((int)FFJJCIQPLOP.Payload.PokemonID).ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B06 RID: 23302 RVA: 0x002EF434 File Offset: 0x002ED634
	public void BQLIIQIIMDH(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "Item: " + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).Name + "\nx" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x00023A7E File Offset: 0x00021C7E
	protected virtual void FOKFJKKCQML()
	{
		PJCCMHCDFJQ.GGBPGMMCGLI().CDKHIELMQIE.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005B08 RID: 23304 RVA: 0x000239EF File Offset: 0x00021BEF
	private void CDMJBDGFHBD()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.BQLIIQIIMDH(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005B09 RID: 23305 RVA: 0x002EF4E0 File Offset: 0x002ED6E0
	protected virtual void INBFEIJMHJK(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[1].gameObject.SetActive(false);
		if (this.ECJJLBGHJME)
		{
			bool flag = true;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "DownS")
				{
					flag = true;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().GCJHKFOGHEI(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.QOQONHOOLNE.PGLNOPDBOBP(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(false);
			PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[0].gameObject.SetActive(false);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[1].gameObject.SetActive(false);
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[0].gameObject.SetActive(true);
	}

	// Token: 0x06005B0A RID: 23306 RVA: 0x002EF65C File Offset: 0x002ED85C
	public void COIMFDQIOKL(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "Torrent" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "Dream Ball" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B0B RID: 23307 RVA: 0x00023AA1 File Offset: 0x00021CA1
	private void CEGPCMGDLBO()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.BQLDFQOMHNP(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005B0C RID: 23308 RVA: 0x002EF708 File Offset: 0x002ED908
	public void LOIGHBENOJC(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "Script:" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "-" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B0D RID: 23309 RVA: 0x00023ACC File Offset: 0x00021CCC
	protected virtual void KMJDBIHMCNP()
	{
		PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005B0E RID: 23310 RVA: 0x002EF7B4 File Offset: 0x002ED9B4
	public void LQFDMHPELCJ(PokemonData FFJJCIQPLOP, bool CDICPIDFLOO = true, LINELKKDMEE MPIKNHKEHMF = null)
	{
		this.QFOFODQBFOJ = MPIKNHKEHMF;
		this.EMLKKOFMIIH = FFJJCIQPLOP;
		this.ECJJLBGHJME = CDICPIDFLOO;
		this.HLPQFNKBMLN = false;
		base.gameObject.name = FFJJCIQPLOP.UniqueID.ToString();
		if (FFJJCIQPLOP.Payload == null)
		{
			this.FPQBICGEHMJ.LKPOBCBOFIC("Trade Error");
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().CPFJEOGMHOD("_Source", GFHGEJNHLFQ.DBKNKGJJMJI.Player);
		}
		else
		{
			this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!FFJJCIQPLOP.Payload.Shiny) ? string.Empty : "SetVolumeBack") + KGQECFKLKOP.NNHFLHEQMOI((int)FFJJCIQPLOP.Payload.PokemonID) + "CombinersArgsColorSrc0" + FFJJCIQPLOP.Payload.Level.ToString();
			string str = string.Empty;
			if (FFJJCIQPLOP.Payload.PokemonID == PokemonID.poliwag && FFJJCIQPLOP.Payload.Personality % 82 > 0)
			{
				str = "-waiting" + (FFJJCIQPLOP.Payload.Personality % -72).ToString();
			}
			this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("26" + ((int)FFJJCIQPLOP.Payload.PokemonID).ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
		}
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B0F RID: 23311 RVA: 0x00023A1A File Offset: 0x00021C1A
	private void DNLLCMHCHMJ()
	{
		if (this.GNDINJEBLBQ && this.HLPQFNKBMLN && this.EMLKKOFMIIH != null)
		{
			this.QFOFODQBFOJ.LBGCODKNHHP(this.EMLKKOFMIIH);
		}
	}

	// Token: 0x06005B10 RID: 23312 RVA: 0x002EF928 File Offset: 0x002EDB28
	protected virtual void HJMHFLMLOOB(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.GGBPGMMCGLI().JHDGENGBPQF[1].gameObject.SetActive(true);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[0].gameObject.SetActive(false);
		if (this.ECJJLBGHJME)
		{
			bool flag = false;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "unnerve")
				{
					flag = false;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().EEIPLMLIGDP(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.QOQONHOOLNE.HNFBIMQFBQB(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(false);
			PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(true);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.GGBPGMMCGLI().JHDGENGBPQF[1].gameObject.SetActive(true);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[1].gameObject.SetActive(false);
	}

	// Token: 0x06005B11 RID: 23313 RVA: 0x00023AEF File Offset: 0x00021CEF
	protected override void OnDragDropStart()
	{
		PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x00023B12 File Offset: 0x00021D12
	protected virtual void BPLFNMONFOG()
	{
		PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(false);
		this.OPGQPOPOPEB = base.transform.localPosition;
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x002EFAA4 File Offset: 0x002EDCA4
	protected virtual void IQQPOOCMCGK(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(false);
		PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[1].gameObject.SetActive(false);
		if (this.ECJJLBGHJME)
		{
			bool flag = false;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "J10")
				{
					flag = false;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.QOQONHOOLNE.CDKHIELMQIE.SetActive(true);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().FCEGNPIOEIN(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.DMOKBPOKHOQ().GLNJKKDEQBB(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.GGBPGMMCGLI().JHDGENGBPQF[0].gameObject.SetActive(true);
			PJCCMHCDFJQ.GGBPGMMCGLI().JHDGENGBPQF[1].gameObject.SetActive(false);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(false);
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x002EFC20 File Offset: 0x002EDE20
	protected virtual void ONCKLNJKECP(GameObject HQMQBKPNDJL)
	{
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.QDGLKKGJDGI().JHDGENGBPQF[0].gameObject.SetActive(false);
		if (this.ECJJLBGHJME)
		{
			bool flag = true;
			if (HQMQBKPNDJL != null)
			{
				OKCHLNIDDCC component = HQMQBKPNDJL.GetComponent<OKCHLNIDDCC>();
				if (component != null && component.gameObject.name == "telekinesis")
				{
					flag = false;
				}
			}
			base.OnDragDropRelease(HQMQBKPNDJL);
			base.transform.parent = this.PQQEJQHDCPK;
			base.transform.localPosition = this.OPGQPOPOPEB;
			PJCCMHCDFJQ.DMOKBPOKHOQ().CDKHIELMQIE.SetActive(true);
			if (flag)
			{
				if (this.HLPQFNKBMLN)
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().FCEGNPIOEIN(this.EMLKKOFMIIH.UniqueID);
				}
				else
				{
					PJCCMHCDFJQ.GGBPGMMCGLI().FEDEJIGOEDB(this.IIFLHGMKIEM);
				}
			}
			PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[1].gameObject.SetActive(true);
			PJCCMHCDFJQ.DMOKBPOKHOQ().JHDGENGBPQF[0].gameObject.SetActive(false);
			return;
		}
		base.OnDragDropRelease(HQMQBKPNDJL);
		base.transform.parent = this.PQQEJQHDCPK;
		base.transform.localPosition = this.OPGQPOPOPEB;
		PJCCMHCDFJQ.QDGLKKGJDGI().CDKHIELMQIE.SetActive(false);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[0].gameObject.SetActive(true);
		PJCCMHCDFJQ.QOQONHOOLNE.JHDGENGBPQF[1].gameObject.SetActive(false);
	}

	// Token: 0x06005B15 RID: 23317 RVA: 0x002EFD9C File Offset: 0x002EDF9C
	public void FCLODIHFFQL(int HFBPHOGKGLK, int DPDCGFEEFPB, bool CDICPIDFLOO = true)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.ECJJLBGHJME = CDICPIDFLOO;
		base.gameObject.name = "Mana increases the number of spells that can be cast" + HFBPHOGKGLK.ToString();
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "powerofalchemy" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
		this.PQQEJQHDCPK = base.transform.parent;
	}

	// Token: 0x06005B16 RID: 23318 RVA: 0x002EFE48 File Offset: 0x002EE048
	private void JFKJOLEKQNF(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "#,##0" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NDPGCGDLEEQ() + "Primordial Sea";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NKDOCPOOIIF();
				GGGPJQEKNJD.HOICKEIJIHM(text);
			}
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06005B17 RID: 23319 RVA: 0x002EFEB4 File Offset: 0x002EE0B4
	private void IFGPPIQKOPM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "[33CCFF]" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Name + "[-]\n\n";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Description;
				GGGPJQEKNJD.MFONIPHOFGF(text);
			}
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x040013B2 RID: 5042
	private Transform PQQEJQHDCPK;

	// Token: 0x040013B3 RID: 5043
	private Vector3 OPGQPOPOPEB;

	// Token: 0x040013B4 RID: 5044
	public JLMPBLMOICG LQKBJPMICOD;

	// Token: 0x040013B5 RID: 5045
	public BKKHLBCLPJM FPQBICGEHMJ;

	// Token: 0x040013B6 RID: 5046
	private bool HLPQFNKBMLN;

	// Token: 0x040013B7 RID: 5047
	private bool ECJJLBGHJME = true;

	// Token: 0x040013B8 RID: 5048
	public PokemonData EMLKKOFMIIH;

	// Token: 0x040013B9 RID: 5049
	private LINELKKDMEE QFOFODQBFOJ;

	// Token: 0x040013BA RID: 5050
	public int IIFLHGMKIEM;

	// Token: 0x040013BB RID: 5051
	public bool GNDINJEBLBQ = true;
}
