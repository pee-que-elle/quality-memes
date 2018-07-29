using System;
using UnityEngine;

// Token: 0x020001B2 RID: 434
public class OQNEQCIKBQJ : MonoBehaviour
{
	// Token: 0x0600371A RID: 14106 RVA: 0x00017A50 File Offset: 0x00015C50
	private static void BDGOJEFNBDP(OQNEQCIKBQJ BGBMIEJJQKC)
	{
		OQNEQCIKBQJ.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x00017A58 File Offset: 0x00015C58
	public void NPHKMHMMBPQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.KEBCGPFBFJL();
		}
		else
		{
			this.ODMCOCHJFLF();
		}
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x00017A7A File Offset: 0x00015C7A
	public void FFCEMKIQQFQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.JDPBPOKJFQK.enabled = true;
			this.HidePanel();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x00017AA8 File Offset: 0x00015CA8
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

	// Token: 0x0600371E RID: 14110 RVA: 0x00017ACA File Offset: 0x00015CCA
	public void GJLLFLMLCBC()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.KEBCGPFBFJL();
		}
		else
		{
			this.MDKQBGJKHCF();
		}
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x00017AEC File Offset: 0x00015CEC
	private void Awake()
	{
		OQNEQCIKBQJ.QOQONHOOLNE = this;
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x0600372B RID: 14123 RVA: 0x00017AF4 File Offset: 0x00015CF4
	// (set) Token: 0x06003720 RID: 14112 RVA: 0x00017A50 File Offset: 0x00015C50
	public static OQNEQCIKBQJ QOQONHOOLNE { get; private set; }

	// Token: 0x06003721 RID: 14113 RVA: 0x00017AF4 File Offset: 0x00015CF4
	public static OQNEQCIKBQJ CPIJOBOQLOK()
	{
		return OQNEQCIKBQJ.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06003722 RID: 14114 RVA: 0x00017AFB File Offset: 0x00015CFB
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06003723 RID: 14115 RVA: 0x00017AA8 File Offset: 0x00015CA8
	public void KLKECFEFBPJ()
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

	// Token: 0x06003724 RID: 14116 RVA: 0x00017B0E File Offset: 0x00015D0E
	public void QGQDJIENFON()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.JDPBPOKJFQK.enabled = false;
			this.HidePanel();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x001A2B9C File Offset: 0x001A0D9C
	public void Open()
	{
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x00017B3C File Offset: 0x00015D3C
	public void MDKQBGJKHCF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("_GrainTex", 1906f);
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x001A2BFC File Offset: 0x001A0DFC
	public void KEBCGPFBFJL()
	{
		base.CancelInvoke("liquidooze");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 65f;
		this.JDPBPOKJFQK.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x00017AF4 File Offset: 0x00015CF4
	public static OQNEQCIKBQJ FHCMDGCONNE()
	{
		return OQNEQCIKBQJ.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x00017B65 File Offset: 0x00015D65
	public void ODMCOCHJFLF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("snorlax", 1354f);
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x00017B8E File Offset: 0x00015D8E
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x00017AA8 File Offset: 0x00015CA8
	public void PJOODQMKDMG()
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

	// Token: 0x0600372E RID: 14126 RVA: 0x00017A50 File Offset: 0x00015C50
	private static void PJKBBLGKKJQ(OQNEQCIKBQJ BGBMIEJJQKC)
	{
		OQNEQCIKBQJ.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x04000CF0 RID: 3312
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000CF1 RID: 3313
	public EPIJJNOIKEK JDPBPOKJFQK;
}
