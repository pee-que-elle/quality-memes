using System;
using UnityEngine;

// Token: 0x0200004D RID: 77
[AddComponentMenu("NGUI/Interaction/Button Message (Legacy)")]
public class PKQQEHKMOIJ : MonoBehaviour
{
	// Token: 0x06000AA3 RID: 2723 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void HBOFMLLODDM()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00064BA0 File Offset: 0x00062DA0
	private void KGNPFIOJEMD()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i += 0;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00005D58 File Offset: 0x00003F58
	private void FCOIMQGENDB()
	{
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00005D61 File Offset: 0x00003F61
	private void NIBBOFPKDKC()
	{
		if (this.PNBOOLEOKCI)
		{
			this.NOQMELHJOKH(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00005D7C File Offset: 0x00003F7C
	private void BCCBGBJFNJL()
	{
		if (base.enabled && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)7)
		{
			this.DONQHLLHDEH();
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00005D61 File Offset: 0x00003F61
	private void OJHIFOCCJJP()
	{
		if (this.PNBOOLEOKCI)
		{
			this.NOQMELHJOKH(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00005D95 File Offset: 0x00003F95
	private void MNKNCCBMPGJ(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)3))
		{
			this.NOQMELHJOKH(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00005DB1 File Offset: 0x00003FB1
	private void EFOJLEMPJFE()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x00005DB1 File Offset: 0x00003FB1
	private void OnEnable()
	{
		if (this.PNBOOLEOKCI)
		{
			this.LJMOLEKDCLP(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00005DCC File Offset: 0x00003FCC
	private void BPBGKKFQNHK(bool IFFGDNBQHLO)
	{
		if (base.enabled && ((IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick) || (!IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver)))
		{
			this.MNMNOGEQHBB();
		}
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x00005DF4 File Offset: 0x00003FF4
	private void DKKQFEPDLHB(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)6) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnRelease)))
		{
			this.JIIGBNMEQCQ();
		}
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00005E1C File Offset: 0x0000401C
	private void KHCHMDKCDKF(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)8))
		{
			this.NOQMELHJOKH(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00005E38 File Offset: 0x00004038
	private void EIMQFNJILOH()
	{
		if (base.enabled && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)8)
		{
			this.DDGKPOJQJIQ();
		}
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00064C30 File Offset: 0x00062E30
	private void DDGKPOJQJIQ()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i++;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00005E51 File Offset: 0x00004051
	private void JFIJIDKQJOJ(bool IFFGDNBQHLO)
	{
		if (base.enabled && ((IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver) || (!IFFGDNBQHLO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)6)))
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00005E79 File Offset: 0x00004079
	private void DBMBOONLPIL()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick)
		{
			this.DLEEDCGQHPH();
		}
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00005E91 File Offset: 0x00004091
	private void NQEJNHQNFLJ(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnPress) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnDoubleClick)))
		{
			this.KGNPFIOJEMD();
		}
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00005EB9 File Offset: 0x000040B9
	private void PPKGLFDHNCI(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver)))
		{
			this.DDGKPOJQJIQ();
		}
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00005D58 File Offset: 0x00003F58
	private void Start()
	{
		this.PNBOOLEOKCI = true;
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00064CC0 File Offset: 0x00062EC0
	private void JIIGBNMEQCQ()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i++;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00005EE1 File Offset: 0x000040E1
	private void QEIPKHBQCPK()
	{
		if (base.enabled && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)6)
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00005EFA File Offset: 0x000040FA
	private void BIQLBDMMDFK()
	{
		if (this.PNBOOLEOKCI)
		{
			this.BPBGKKFQNHK(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00064D50 File Offset: 0x00062F50
	private void EQLNKNGQDED()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i += 0;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00005F15 File Offset: 0x00004115
	private void QCGENKHJDDH()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnDoubleClick)
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00005F2E File Offset: 0x0000412E
	private void FCFIOBDDBFL(bool IFFGDNBQHLO)
	{
		if (base.enabled && ((IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick) || (!IFFGDNBQHLO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)8)))
		{
			this.BOPGHLIMMFP();
		}
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00005F56 File Offset: 0x00004156
	private void EBIJMQIMQOF()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JFIJIDKQJOJ(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00005F71 File Offset: 0x00004171
	private void OnClick()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick)
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00064CC0 File Offset: 0x00062EC0
	private void MKIGMHIJGJG()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i++;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void QBGOGFJCLEP()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00064DE0 File Offset: 0x00062FE0
	private void JIEHCCJFNFD()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i += 0;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00005F89 File Offset: 0x00004189
	private void EKLNQHLPKLN()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick)
		{
			this.MNMNOGEQHBB();
		}
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void JDLQNCEDMPI()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00005FA1 File Offset: 0x000041A1
	private void OnPress(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnPress) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnRelease)))
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00005FC9 File Offset: 0x000041C9
	private void KIIOMHNGKGG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)8))
		{
			this.FCFIOBDDBFL(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00064DE0 File Offset: 0x00062FE0
	private void DONQHLLHDEH()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i += 0;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00005FE5 File Offset: 0x000041E5
	private void DHHFGGEDLEI(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)6) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnDoubleClick)))
		{
			this.DDGKPOJQJIQ();
		}
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x0000600D File Offset: 0x0000420D
	private void NBNNFHDMKFN(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)3))
		{
			this.BPBGKKFQNHK(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00006029 File Offset: 0x00004229
	private void QEJPDBIPHQH(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)7) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)7)))
		{
			this.JIIGBNMEQCQ();
		}
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00005E79 File Offset: 0x00004079
	private void NNOPGECPIDJ()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick)
		{
			this.DLEEDCGQHPH();
		}
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void FCGLNCNICGB()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00006051 File Offset: 0x00004251
	private void PCKNNLNKDGH(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Touch))
		{
			this.NOQMELHJOKH(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void LNHDODMGBKC()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x0000606D File Offset: 0x0000426D
	private void IIKNHGOMQEG()
	{
		if (this.PNBOOLEOKCI)
		{
			this.FCFIOBDDBFL(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00006088 File Offset: 0x00004288
	private void FJLBFNBNEOQ(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)4))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x0000606D File Offset: 0x0000426D
	private void ILPIJHIMOJD()
	{
		if (this.PNBOOLEOKCI)
		{
			this.FCFIOBDDBFL(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x000060A4 File Offset: 0x000042A4
	private void LHNFIFJBBDE(bool FJOEKDCLKIO)
	{
		if (base.enabled && ((FJOEKDCLKIO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnRelease) || (!FJOEKDCLKIO && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)7)))
		{
			this.BOPGHLIMMFP();
		}
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x000060CC File Offset: 0x000042CC
	private void OMFMMEKFNPE()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver)
		{
			this.MNMNOGEQHBB();
		}
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00064E70 File Offset: 0x00063070
	private void DLEEDCGQHPH()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
				i++;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void DGMPMICDCIO()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x000060E5 File Offset: 0x000042E5
	private void JOFLHFQQCKG(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == EMENMKHBPQE.EGIKELMMQOO.Controller))
		{
			this.LJMOLEKDCLP(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00005EE1 File Offset: 0x000040E1
	private void MBKDFONJGEN()
	{
		if (base.enabled && this.ILLDIKBCNMC == (PKQQEHKMOIJ.BMCBCMOKLEI)6)
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00006101 File Offset: 0x00004301
	private void MHPFHNMBJGE(bool GKHHCNCGLCD)
	{
		if (base.enabled && (!GKHHCNCGLCD || EMENMKHBPQE.GMDQCMCJEQI == (EMENMKHBPQE.EGIKELMMQOO)4))
		{
			this.JFIJIDKQJOJ(GKHHCNCGLCD);
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00005F56 File Offset: 0x00004156
	private void CGIQQJOJDNQ()
	{
		if (this.PNBOOLEOKCI)
		{
			this.JFIJIDKQJOJ(EMENMKHBPQE.KHCLCOKOIHL(base.gameObject));
		}
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x0000611D File Offset: 0x0000431D
	private void MHBNNCGMNHH()
	{
		if (base.enabled && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnClick)
		{
			this.KGNPFIOJEMD();
		}
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00006135 File Offset: 0x00004335
	private void NOQMELHJOKH(bool IFFGDNBQHLO)
	{
		if (base.enabled && ((IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver) || (!IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver)))
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00064D50 File Offset: 0x00062F50
	private void MNMNOGEQHBB()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 0;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i += 0;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0000615D File Offset: 0x0000435D
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		if (base.enabled && ((IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOver) || (!IFFGDNBQHLO && this.ILLDIKBCNMC == PKQQEHKMOIJ.BMCBCMOKLEI.OnMouseOut)))
		{
			this.MKIGMHIJGJG();
		}
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00005D4F File Offset: 0x00003F4F
	private void ODIJQBBOLFI()
	{
		this.PNBOOLEOKCI = false;
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00064C30 File Offset: 0x00062E30
	private void BOPGHLIMMFP()
	{
		if (string.IsNullOrEmpty(this.NMNJHOMGDCM))
		{
			return;
		}
		if (this.ILBCCCBJNCL == null)
		{
			this.ILBCCCBJNCL = base.gameObject;
		}
		if (this.CKCPEMIBLKH)
		{
			Transform[] componentsInChildren = this.ILBCCCBJNCL.GetComponentsInChildren<Transform>();
			int i = 1;
			int num = componentsInChildren.Length;
			while (i < num)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
				i++;
			}
		}
		else
		{
			this.ILBCCCBJNCL.SendMessage(this.NMNJHOMGDCM, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x0400017E RID: 382
	public GameObject ILBCCCBJNCL;

	// Token: 0x0400017F RID: 383
	public string NMNJHOMGDCM;

	// Token: 0x04000180 RID: 384
	public PKQQEHKMOIJ.BMCBCMOKLEI ILLDIKBCNMC;

	// Token: 0x04000181 RID: 385
	public bool CKCPEMIBLKH;

	// Token: 0x04000182 RID: 386
	private bool PNBOOLEOKCI;

	// Token: 0x0200004E RID: 78
	public enum BMCBCMOKLEI
	{
		// Token: 0x04000184 RID: 388
		OnClick,
		// Token: 0x04000185 RID: 389
		OnMouseOver,
		// Token: 0x04000186 RID: 390
		OnMouseOut,
		// Token: 0x04000187 RID: 391
		OnPress,
		// Token: 0x04000188 RID: 392
		OnRelease,
		// Token: 0x04000189 RID: 393
		OnDoubleClick
	}
}
