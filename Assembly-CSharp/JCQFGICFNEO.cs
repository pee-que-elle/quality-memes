using System;
using UnityEngine;

// Token: 0x02000267 RID: 615
public class JCQFGICFNEO : MonoBehaviour
{
	// Token: 0x060053F0 RID: 21488 RVA: 0x002AB11C File Offset: 0x002A931C
	public void BQLIIQIIMDH(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = true;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "[SHINY]") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "\r\nLv " + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str = "Small/";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = qoqonhoolne.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x002AB198 File Offset: 0x002A9398
	private void IGNPGKQFPEJ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = "Music" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NDPGCGDLEEQ() + "Moon Ball";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Description;
				GGGPJQEKNJD.HOICKEIJIHM(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x002AB204 File Offset: 0x002A9404
	private void JFKJOLEKQNF(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "p2" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + "qTrack";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).QKMHPDJNJHE();
				GGGPJQEKNJD.PLMQDDPDOOL(text);
			}
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x002AB270 File Offset: 0x002A9470
	public void JMDOHOLHGBN(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.LKPOBCBOFIC(((!DKFBPJOEGQC) ? string.Empty : "Can't find room with index: ") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Trigger Influence" + NPBLFIMGOPL.ToString());
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str = "TradeColliders";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x002AB2EC File Offset: 0x002A94EC
	public void LBIHDCQJNGB(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.LKPOBCBOFIC(((!DKFBPJOEGQC) ? string.Empty : "TM") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "_ClipSharpness" + NPBLFIMGOPL.ToString());
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str = "Simple";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = qoqonhoolne.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x002AB368 File Offset: 0x002A9568
	public void PJJFGOKNQMJ(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "gametype" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).MQIHCHFOPGE().ToString());
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x002AB3D8 File Offset: 0x002A95D8
	private void KGQIPMJOQGG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = "primal" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "primal";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).QKMHPDJNJHE();
				GGGPJQEKNJD.PLMQDDPDOOL(text);
			}
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x002AB444 File Offset: 0x002A9644
	public void QNJHMCKNJIK(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.LKPOBCBOFIC(((!DKFBPJOEGQC) ? string.Empty : "[-]\n") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "_FogData" + NPBLFIMGOPL.ToString());
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str = "clamp";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = qoqonhoolne.NMPCLCEQJMP(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x002AB4C0 File Offset: 0x002A96C0
	private void FJEHHBMBMQM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "_SunColor" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Name + "Shop";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).PNKGBNPIILC();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x002AB52C File Offset: 0x002A972C
	private void IEEDONJFQJK(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "PvP Wins:" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "Soul-Heart";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).LGOODGEDFQG();
				GGGPJQEKNJD.HOICKEIJIHM(text);
			}
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x002AB598 File Offset: 0x002A9798
	public void GKGEFEKKBCM(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).DFNQHDEDDKE() + "BuffIcon_Teleport2" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).LEQLIKKPHHI().ToString());
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x002AB608 File Offset: 0x002A9808
	private void OFCMPLCDCCJ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = "Assets/Media/Bundle_Items/" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).JQBDPHILQJO() + "\"\"";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Description;
				GGGPJQEKNJD.MFONIPHOFGF(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x002AB674 File Offset: 0x002A9874
	private void CIODIICODLO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "Hidden/Post FX/Lut Generator" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + " started!\r\n";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).QKMHPDJNJHE();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x002AB6E0 File Offset: 0x002A98E0
	public void MJNQFGMQFEQ(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).Name + "Assets/AssetBundles/MapAssets/Model Materials/Single_Window.mat" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x002AB750 File Offset: 0x002A9950
	private void KILQIQBFDEE(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "[00EE00]" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NDPGCGDLEEQ() + "Add to Friends";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).PNKGBNPIILC();
				GGGPJQEKNJD.JNDKHLFCEEB(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x002AB7BC File Offset: 0x002A99BC
	private void PNHCDLKIIEI(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "[FF9900]" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).JQBDPHILQJO() + "deltastream";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NKDOCPOOIIF();
				GGGPJQEKNJD.JEDHBMEEGEB(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x002AB828 File Offset: 0x002A9A28
	public void LQFDMHPELCJ(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "StopRow3") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + " time!" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str = "Changes the Pokémon's type to the type of the move it's about to use.";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = qoqonhoolne.NMPCLCEQJMP(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06005401 RID: 21505 RVA: 0x002AB8A4 File Offset: 0x002A9AA4
	public void BQLIIQIIMDH(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).Name + "\nx" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x06005402 RID: 21506 RVA: 0x002AB914 File Offset: 0x002A9B14
	private void JODQILJDCCQ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "Open" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + "_ReflectionTexture3";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).LGOODGEDFQG();
				GGGPJQEKNJD.JOFBCKFPFEN(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x002AB980 File Offset: 0x002A9B80
	public void QMKELEEOHBE(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "'s stats were not lowered!\r\n" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x002AB9F0 File Offset: 0x002A9BF0
	public void MDFGEPJEJCQ(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).FLFQBGJQBBD() + "Symbiosis" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x002ABA60 File Offset: 0x002A9C60
	public void DFEONCOPCPE(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "Teleport Cooldown") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Plant" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str = "blank";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x002ABADC File Offset: 0x002A9CDC
	private void FKCLGDJDBFN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = "TabSettings" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Name + "/mute ";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).PNKGBNPIILC();
				GGGPJQEKNJD.MFONIPHOFGF(text);
			}
		}
		else
		{
			GGGPJQEKNJD.MFONIPHOFGF(null);
		}
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x002ABB48 File Offset: 0x002A9D48
	public void QKCOIIKFPKG(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).DFNQHDEDDKE() + "Guild" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x06005408 RID: 21512 RVA: 0x002ABBB8 File Offset: 0x002A9DB8
	public void FDDENOHPGQF(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "map:") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Gluttony" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.GGBPGMMCGLI();
		string str = "-unboost";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x002ABC34 File Offset: 0x002A9E34
	public void ONNDNJHJNPI(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = true;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "Super Charged") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Icon_Status_Burn" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str = "p1";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x0600540A RID: 21514 RVA: 0x002ABCB0 File Offset: 0x002A9EB0
	private void HPKHMHMLQFM(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "[PD]" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).JQBDPHILQJO() + "HideEmote";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).OELFFKHICPQ();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x0600540B RID: 21515 RVA: 0x002ABD1C File Offset: 0x002A9F1C
	private void LDEINGNKILD(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = "-mega" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + "#,##0";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).QKMHPDJNJHE();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x0600540C RID: 21516 RVA: 0x002ABD88 File Offset: 0x002A9F88
	public void JKHJPEFINFL(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "Rising Badge" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.BEKHPOHIPDE().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).LEQLIKKPHHI().ToString());
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x002ABDF8 File Offset: 0x002A9FF8
	private void OEKDPJHKONQ(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = " maxed its Attack!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).JQBDPHILQJO() + "BuffIcon";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).JLECCEINFBO();
				GGGPJQEKNJD.MFONIPHOFGF(text);
			}
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x002ABE64 File Offset: 0x002AA064
	private void QQHGCHDMMBC(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "_Contrast" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "The two moves have become one! It's a combined move!\r\n";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NKDOCPOOIIF();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x002ABED0 File Offset: 0x002AA0D0
	public void CLMGPMLLIDN(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "[7fff49]") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + " is ready to help " + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str = "r";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x002ABF4C File Offset: 0x002AA14C
	public void IBJNQFPIMMC(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "rotomheat" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x002ABFBC File Offset: 0x002AA1BC
	public void BLFPCGEIDNL(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "_") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Appear Online" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str = " can not hold that many more '";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x002AC038 File Offset: 0x002AA238
	public void DLEDQFJCPDJ(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).FLFQBGJQBBD() + "WaitFrame" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06005413 RID: 21523 RVA: 0x002AC0A8 File Offset: 0x002AA2A8
	public void HOFCKQELDLF(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "rkssystem" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).MQIHCHFOPGE().ToString());
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x002AC118 File Offset: 0x002AA318
	private void CEFFKHOODCB(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 1)
			{
				string text = string.Empty;
				text = " can't move!\r\n" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NDPGCGDLEEQ() + " day, ";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Description;
				GGGPJQEKNJD.MFONIPHOFGF(text);
			}
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x002AC184 File Offset: 0x002AA384
	public void PCFNFCMCMII(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).NDPGCGDLEEQ() + "reflect" + DPDCGFEEFPB.ToString();
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x002AC1F4 File Offset: 0x002AA3F4
	private void JQFIDNCKHMH(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = ")" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + "Materials/DFGDesktopPlusOrthogonal";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).NKDOCPOOIIF();
				GGGPJQEKNJD.QOLKOBPCJBQ(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JEDHBMEEGEB(null);
		}
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x002AC260 File Offset: 0x002AA460
	public void CQKHIPOLJNL(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = true;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : " transformed!\r\n") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "jumpkick" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str = "ResolutionY";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.GOKLDOEGJHI(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x06005419 RID: 21529 RVA: 0x002AC2DC File Offset: 0x002AA4DC
	public void EJJBDNMPFIM(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).DFNQHDEDDKE() + "But it failed!\r\n" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x0600541A RID: 21530 RVA: 0x002AC34C File Offset: 0x002AA54C
	public void EEOOPJNPMPJ(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = true;
		this.FPQBICGEHMJ.LKPOBCBOFIC(((!DKFBPJOEGQC) ? string.Empty : "battlebag") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "Kick" + NPBLFIMGOPL.ToString());
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.MOGQNGEPCEO();
		string str = " restored its HP.\r\n";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x0600541B RID: 21531 RVA: 0x002AC3C8 File Offset: 0x002AA5C8
	private void ONJFQGIHJBO(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "Failed Sync" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Name + "sdata";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).PNKGBNPIILC();
				GGGPJQEKNJD.JEDHBMEEGEB(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JOFBCKFPFEN(null);
		}
	}

	// Token: 0x0600541C RID: 21532 RVA: 0x002AC434 File Offset: 0x002AA634
	private void JEKQNINDBGG(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "door_3" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "[ff6666]";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).LGOODGEDFQG();
				GGGPJQEKNJD.HOICKEIJIHM(text);
			}
		}
		else
		{
			GGGPJQEKNJD.JNDKHLFCEEB(null);
		}
	}

	// Token: 0x0600541D RID: 21533 RVA: 0x002AC4A0 File Offset: 0x002AA6A0
	public void MFBIIOKFFQG(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).DFNQHDEDDKE() + "_Dissolve" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().PINEJNIDONB(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).ItemImage.ToString());
	}

	// Token: 0x0600541E RID: 21534 RVA: 0x002AC510 File Offset: 0x002AA710
	private void ENDMIONFPKN(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "Encounter Rate Decreased (Hail)" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).DFNQHDEDDKE() + " Lv. [FF8787]";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).OELFFKHICPQ();
				GGGPJQEKNJD.JOFBCKFPFEN(text);
			}
		}
		else
		{
			GGGPJQEKNJD.PLMQDDPDOOL(null);
		}
	}

	// Token: 0x0600541F RID: 21535 RVA: 0x002AC57C File Offset: 0x002AA77C
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

	// Token: 0x06005420 RID: 21536 RVA: 0x002AC5E8 File Offset: 0x002AA7E8
	public void DFNDGODMFOM(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).FLFQBGJQBBD() + "Already in Guild" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().QDMQEBHOENL(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06005421 RID: 21537 RVA: 0x002AC658 File Offset: 0x002AA858
	public void PBEFGBBHKPH(int HFBPHOGKGLK, int DPDCGFEEFPB)
	{
		this.IIFLHGMKIEM = HFBPHOGKGLK;
		this.FPQBICGEHMJ.LKPOBCBOFIC(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).JQBDPHILQJO() + "Sound" + DPDCGFEEFPB.ToString());
		this.LQKBJPMICOD.GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.OKBJNLOPPBF(KGQECFKLKOP.BFNBQBMJHFL(HFBPHOGKGLK).QCQPPPFPCQH().ToString());
	}

	// Token: 0x06005422 RID: 21538 RVA: 0x002AC6C8 File Offset: 0x002AA8C8
	public void KDCHGCMPDLJ(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.LKPOBCBOFIC(((!DKFBPJOEGQC) ? string.Empty : "Sky") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "BuffIcon_Teleport" + NPBLFIMGOPL.ToString());
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ qoqonhoolne = GFHGEJNHLFQ.QOQONHOOLNE;
		string str = "[^a-zA-Z0-9]";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = qoqonhoolne.NMPCLCEQJMP(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
	}

	// Token: 0x06005423 RID: 21539 RVA: 0x002AC744 File Offset: 0x002AA944
	private void IGQIDQJMELD(bool OHOBDLMNJMC)
	{
		if (OHOBDLMNJMC)
		{
			if (!this.HLPQFNKBMLN && this.IIFLHGMKIEM > 0)
			{
				string text = string.Empty;
				text = "General" + KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).FLFQBGJQBBD() + "CombinersArgsColorSrc2";
				text += KGQECFKLKOP.BFNBQBMJHFL(this.IIFLHGMKIEM).Description;
				GGGPJQEKNJD.JOFBCKFPFEN(text);
			}
		}
		else
		{
			GGGPJQEKNJD.HOICKEIJIHM(null);
		}
	}

	// Token: 0x06005424 RID: 21540 RVA: 0x002AC7B0 File Offset: 0x002AA9B0
	public void COIMFDQIOKL(int IKIJBQLMKJO, bool DKFBPJOEGQC, int NPBLFIMGOPL)
	{
		this.HLPQFNKBMLN = false;
		this.FPQBICGEHMJ.PIDLOFMIEFQ = ((!DKFBPJOEGQC) ? string.Empty : "OnScroll") + KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO) + "marvelscale" + NPBLFIMGOPL.ToString();
		ENFMCDNLEQQ lqkbjpmicod = this.LQKBJPMICOD;
		GFHGEJNHLFQ gfhgejnhlfq = GFHGEJNHLFQ.BEKHPOHIPDE();
		string str = "Wimp Out";
		int num = IKIJBQLMKJO;
		lqkbjpmicod.GOIHJQNMMJD = gfhgejnhlfq.CPFJEOGMHOD(str + num.ToString(), GFHGEJNHLFQ.DBKNKGJJMJI.Player);
	}

	// Token: 0x0400125D RID: 4701
	public JLMPBLMOICG LQKBJPMICOD;

	// Token: 0x0400125E RID: 4702
	public BKKHLBCLPJM FPQBICGEHMJ;

	// Token: 0x0400125F RID: 4703
	private bool HLPQFNKBMLN;

	// Token: 0x04001260 RID: 4704
	public int IIFLHGMKIEM;
}
