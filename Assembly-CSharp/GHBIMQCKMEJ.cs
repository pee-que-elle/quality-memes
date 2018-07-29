using System;
using System.Collections;
using System.Diagnostics;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000268 RID: 616
public class GHBIMQCKMEJ : MonoBehaviour
{
	// Token: 0x06005425 RID: 21541 RVA: 0x000211E9 File Offset: 0x0001F3E9
	private void NLIIPCFHBPD()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005427 RID: 21543 RVA: 0x002AC82C File Offset: 0x002AAA2C
	public void CJNOMLONOJO()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[8].SetActive(false);
		this.IQDCDBCPBEN[8].SetActive(false);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("Mouse ScrollWheel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1533f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005428 RID: 21544 RVA: 0x000211FC File Offset: 0x0001F3FC
	public void NGGJLQNMHFD()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("focussash", 1625f);
	}

	// Token: 0x06005429 RID: 21545 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ FFCOKMHBCQJ()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x0600542A RID: 21546 RVA: 0x002AC8C4 File Offset: 0x002AAAC4
	public void ELODIBLHHDI()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[2].SetActive(true);
		this.IQDCDBCPBEN[6].SetActive(false);
		this.MBPHKDQMJJH.NCBFKNGMKPB(string.Empty);
		base.CancelInvoke("1");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 628f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x0600542B RID: 21547 RVA: 0x0002122C File Offset: 0x0001F42C
	private void FOLBFDNJLII()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x0600542C RID: 21548 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ QOQONHOOLNE
	{
		get
		{
			return GHBIMQCKMEJ.HBFFCJHOCPE;
		}
	}

	// Token: 0x0600542D RID: 21549 RVA: 0x0002122C File Offset: 0x0001F42C
	private void PCHJHFGCOCK()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600542E RID: 21550 RVA: 0x002AC95C File Offset: 0x002AAB5C
	public void HDHJDOIMHHO(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == PasswordResult.Reseted)
		{
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[4].SetActive(false);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[8].SetActive(true);
			this.IQDCDBCPBEN[8].SetActive(false);
		}
	}

	// Token: 0x0600542F RID: 21551 RVA: 0x002AC9EC File Offset: 0x002AABEC
	public void PHEPIPPFNGD(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == PasswordResult.Reseted)
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[3].SetActive(false);
			this.IQDCDBCPBEN[2].SetActive(true);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[2].SetActive(false);
			this.IQDCDBCPBEN[3].SetActive(true);
		}
	}

	// Token: 0x06005430 RID: 21552 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator LDOQCPJLGFP()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x06005431 RID: 21553 RVA: 0x002ACA98 File Offset: 0x002AAC98
	public void NHBGDLCJGPM()
	{
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[5].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("Player/Hair");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1876f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005432 RID: 21554 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ BDPEQNCNPJO()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x06005433 RID: 21555 RVA: 0x00021234 File Offset: 0x0001F434
	public void GDDMKPQODFN()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("recharge", 929f);
	}

	// Token: 0x06005434 RID: 21556 RVA: 0x0002122C File Offset: 0x0001F42C
	private void BCEKGNDIIOE()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005435 RID: 21557 RVA: 0x002ACB30 File Offset: 0x002AAD30
	public void POKHGLILDEB(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == (PasswordResult)6)
		{
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[8].SetActive(true);
			this.IQDCDBCPBEN[8].SetActive(true);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(false);
		}
	}

	// Token: 0x06005436 RID: 21558 RVA: 0x0002122C File Offset: 0x0001F42C
	private void JENKEGOEEHO()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005437 RID: 21559 RVA: 0x002ACBC0 File Offset: 0x002AADC0
	public void CNBFHPCFGGO()
	{
		if (this.IQDCDBCPBEN[0].activeSelf)
		{
			return;
		}
		if (this.MBPHKDQMJJH.BGBMIEJJQKC.Length < 0)
		{
			return;
		}
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[3].SetActive(true);
		this.IQDCDBCPBEN[2].SetActive(true);
		base.StartCoroutine(this.NCIQHEHQJHN());
	}

	// Token: 0x06005438 RID: 21560 RVA: 0x002ACC38 File Offset: 0x002AAE38
	public void PFGHIONHQIQ(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == (PasswordResult)7)
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[7].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(true);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[5].SetActive(true);
			this.IQDCDBCPBEN[7].SetActive(true);
		}
	}

	// Token: 0x06005439 RID: 21561 RVA: 0x002ACCC8 File Offset: 0x002AAEC8
	public void OFBIGEHJOMG()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[3].SetActive(false);
		this.IQDCDBCPBEN[8].SetActive(true);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("[ATK]");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 737f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x0600543A RID: 21562 RVA: 0x0002122C File Offset: 0x0001F42C
	private void LEJQMIECFCH()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600543B RID: 21563 RVA: 0x0002122C File Offset: 0x0001F42C
	private void NGDJNKQELNO()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600543C RID: 21564 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ GFNJCNOBMON()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x0600543D RID: 21565 RVA: 0x0002122C File Offset: 0x0001F42C
	private void Awake()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600543E RID: 21566 RVA: 0x002ACD60 File Offset: 0x002AAF60
	public void NCKFMEOOBGM(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == (PasswordResult)4)
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[8].SetActive(true);
			this.IQDCDBCPBEN[8].SetActive(false);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[4].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(true);
		}
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x002ACDF0 File Offset: 0x002AAFF0
	public void ProcessResetPassword()
	{
		if (this.IQDCDBCPBEN[1].activeSelf)
		{
			return;
		}
		if (this.MBPHKDQMJJH.BGBMIEJJQKC.Length < 4)
		{
			return;
		}
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[2].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(false);
		base.StartCoroutine(this.MDMQCMGMDIL());
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ OQDOKBJNBBL()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x002ACE68 File Offset: 0x002AB068
	public void BQOFGLCKNEE()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[8].SetActive(false);
		this.IQDCDBCPBEN[5].SetActive(true);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("BuffIcon_Repel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1546f;
		this.QPPGQJFBPMH.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator QFFNIHFNGLB()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x0002122C File Offset: 0x0001F42C
	private void MLDGCPIEMJJ()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x0002125D File Offset: 0x0001F45D
	public void HPMFPNQDQLH()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("_", 1764f);
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x0002122C File Offset: 0x0001F42C
	private void MCPOMCHMKJK()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ GFJGPNOPEPC()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x06005447 RID: 21575 RVA: 0x002ACF00 File Offset: 0x002AB100
	public void IKJDEDNOEGH()
	{
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[7].SetActive(false);
		this.MBPHKDQMJJH.NCBFKNGMKPB(string.Empty);
		base.CancelInvoke(" sealed any moves its target shares with it!\r\n");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 86f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x002ACF98 File Offset: 0x002AB198
	public void MMLQEFINIFK(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == PasswordResult.Updated)
		{
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[8].SetActive(false);
			this.IQDCDBCPBEN[7].SetActive(true);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[3].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(false);
		}
	}

	// Token: 0x06005449 RID: 21577 RVA: 0x0002122C File Offset: 0x0001F42C
	private void CGGDNNKBIJC()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600544A RID: 21578 RVA: 0x000211E9 File Offset: 0x0001F3E9
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x002AD028 File Offset: 0x002AB228
	public void Open()
	{
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[2].SetActive(false);
		this.IQDCDBCPBEN[3].SetActive(false);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x002AD0C0 File Offset: 0x002AB2C0
	public void EHQBIQLNNQL(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == (PasswordResult)6)
		{
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[6].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(false);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[1].SetActive(false);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[7].SetActive(false);
			this.IQDCDBCPBEN[3].SetActive(true);
		}
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x0002122C File Offset: 0x0001F42C
	private void QQMLFMFEKNH()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x000211E9 File Offset: 0x0001F3E9
	private void QJFLJBBOCBF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ DMOKBPOKHOQ()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x06005450 RID: 21584 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator GKLCIQQGBNH()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x06005451 RID: 21585 RVA: 0x000211E9 File Offset: 0x0001F3E9
	private void CCCNIPFPNGQ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x002AD150 File Offset: 0x002AB350
	public void KDGJPMBPNPL(Password BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == (PasswordResult)5)
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[7].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(false);
		}
		else if (BJGCBDNBQCJ.Result == PasswordResult.Failed)
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[4].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(false);
		}
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	[DebuggerHidden]
	private IEnumerator MDMQCMGMDIL()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x06005454 RID: 21588 RVA: 0x00021286 File Offset: 0x0001F486
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x06005455 RID: 21589 RVA: 0x002AD1E0 File Offset: 0x002AB3E0
	public void LBOHDIJOQCC()
	{
		if (this.IQDCDBCPBEN[0].activeSelf)
		{
			return;
		}
		if (this.MBPHKDQMJJH.HJMJDJKOILH().Length < 6)
		{
			return;
		}
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(true);
		this.IQDCDBCPBEN[6].SetActive(false);
		this.IQDCDBCPBEN[8].SetActive(false);
		base.StartCoroutine(this.GKLCIQQGBNH());
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x000212AF File Offset: 0x0001F4AF
	public void JDPIMDFEMKN()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke(")", 1472f);
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x00021225 File Offset: 0x0001F425
	public static GHBIMQCKMEJ KKICFMLLMHQ()
	{
		return GHBIMQCKMEJ.HBFFCJHOCPE;
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x002AD258 File Offset: 0x002AB458
	public void GCFPJOQDGLD()
	{
		this.IQDCDBCPBEN[0].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[2].SetActive(false);
		this.MBPHKDQMJJH.NCBFKNGMKPB(string.Empty);
		base.CancelInvoke("???");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1745f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator KLMDQBLLCFJ()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator NCIQHEHQJHN()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x0002122C File Offset: 0x0001F42C
	private void MEOLPIBOBHB()
	{
		GHBIMQCKMEJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator HKICMJJHCEO()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	private IEnumerator KHCLFFQDMIK()
	{
		GHBIMQCKMEJ.JFLQLPOFGLN jflqlpofgln = new GHBIMQCKMEJ.JFLQLPOFGLN();
		jflqlpofgln.QNDQJMNKFNN = this;
		return jflqlpofgln;
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x000211E9 File Offset: 0x0001F3E9
	private void QOEMELPLOOG()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x000212D8 File Offset: 0x0001F4D8
	private void IDEJFKDOGIB()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x04001261 RID: 4705
	private static GHBIMQCKMEJ HBFFCJHOCPE;

	// Token: 0x04001262 RID: 4706
	public JIMBBPLINGI MBPHKDQMJJH;

	// Token: 0x04001263 RID: 4707
	public GameObject[] IQDCDBCPBEN;

	// Token: 0x04001264 RID: 4708
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04001265 RID: 4709
	public EPIJJNOIKEK JDPBPOKJFQK;
}
